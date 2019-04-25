using DataProperty;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Reflection;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using UtilityLibrary;
using ProtocolObjectParserLib;
using ProtocolOperationLib;
using ProtocolSendToolLib;
using Logger;

namespace ProtocolSendTool
{
    public partial class MainForm : Form
    {
        private bool bIsAssembly = false;
        Client client = new Client();
        AbstractProtoMsg msgApi;

        Dictionary<string, AssemblyClassInfo> list = new Dictionary<string, AssemblyClassInfo>();
        string key = "MSG_CB_USER_LOGIN";

        Thread netThread;
        static string ServerIp = "127.0.0.1";
        static int ServerPort = 8403;

        private void ThreadFunc()
        {
            client.Init(ServerIp, ServerPort);
            client.BindResponse_Login();

            if (client.Net != null)
            {
                client.Connect2Server();
            }
            else
            {
                Log.ErrorLine("Net is null");
            }

            while (client.IsConnected())
            {
                client.Update();
            }
        }
        static void InitXml()
        {
            DataListManager.InitManager();
            string[] files = Directory.GetFiles(PathExt.FullPathFromServerData("XML"), "*.xml", SearchOption.AllDirectories);
            foreach (string file in files)
            {
                DataListManager.inst.Parse(file);
            }

            Log.WriteLine("Load Xml success!");
        }
        static void LoadXml()
        {
            try
            {
                Data data = DataListManager.inst.GetData("BarrackList", 1);
                ServerIp = data.GetString("ip");
                ServerPort = data.GetInt("port");
                Log.WriteLine("Init NetConfig success!");
            }
            catch (System.Exception)
            {

                throw;
            }
        }

        public void WinFromLog(string log)
        {
            if (MainTextBox.InvokeRequired)
            {
                Action<string> actionDelegate = (x) =>
                {
                    MainTextBox.AppendText(Environment.NewLine);
                    MainTextBox.AppendText(x.ToString());
                    MainTextBox.AppendText(Environment.NewLine);
                    MainTextBox.ScrollToCaret();
                };
                MainTextBox.Invoke(actionDelegate, log);
            }
            else
            {
                try
                {
                    MainTextBox.AppendText(log);
                    MainTextBox.AppendText(Environment.NewLine);
                    MainTextBox.AppendText(Environment.NewLine);
                    MainTextBox.ScrollToCaret();
                }
                catch (Exception)
                {
                    return;
                }
              
            }
        }

        public void WinFromLog(string log, Color color)
        {
            if (MainTextBox.InvokeRequired)
            {
                Action<string> actionDelegate = (x) =>
                {
                    MainTextBox.AppendText(x.ToString());
                    MainTextBox.AppendText(Environment.NewLine);
                    MainTextBox.ScrollToCaret();
                };
                MainTextBox.Invoke(actionDelegate, log);
            }
            else
            {
                MainTextBox.AppendText(log);
                MainTextBox.AppendText(Environment.NewLine);
                MainTextBox.ScrollToCaret();
            }
        }

        public void WinFromLogSetColor(Color color)
        {
            MainTextBox.ForeColor = color;
        }

        public void ClearDataGrid()
        {
            dataGridView1.Rows.Clear();
        }

        public void SetDataGridValue(PropertyInfo msg)
        {
            int index = this.dataGridView1.Rows.Add();

            switch (msg.PropertyType.Name)
            {
                case PropertyType.List:
                    int offset = msg.PropertyType.FullName.IndexOf(",");
                    string strTemp = msg.PropertyType.FullName.Substring(0, offset);
                    offset = strTemp.LastIndexOf(".");
                    strTemp = strTemp.Substring(offset + 1, strTemp.Length - offset - 1);
                    strTemp = string.Format("{0}<{1}>", msg.PropertyType.Name, strTemp);
                    this.dataGridView1.Rows[index].Cells[0].Value = strTemp;
                    break;
                case PropertyType.Int32:
                case PropertyType.UInt64:
                case PropertyType.Float:
                case PropertyType.Bool:
                case PropertyType.String:
                default:
                    this.dataGridView1.Rows[index].Cells[0].Value = msg.PropertyType.Name;
                    break;
            }
            this.dataGridView1.Columns[0].ReadOnly = true;
            this.dataGridView1.Rows[index].Cells[1].Value = msg.Name;
            this.dataGridView1.Columns[1].ReadOnly = true;
        }

        public void Parse(object obj, AssemblyClassInfo assemblyClassInfo, MainForm mainForm)
        {
            mainForm.ClearDataGrid();
            if (obj == null)
            {
                return;
            }
            Type t = obj.GetType();

            foreach (var item in t.GetProperties())
            {
                mainForm.SetDataGridValue(item);
            }
            return;
        }

        private void Connect()
        {
            if (netThread != null && netThread.IsAlive && client != null)
            {
                Log.WriteLine("tcp already connected!");
                return;
            }
            Log.WriteLine("tcp try to connect");

            if (netThread == null)
            {
                netThread = new Thread(new ThreadStart(ThreadFunc));
            }
            ThreadState state = netThread.ThreadState;
            //Log.WriteLine("ThreadState :{0}", state);
            switch (state)
            {
                case ThreadState.Running:
                    break;
                case ThreadState.StopRequested:
                    break;
                case ThreadState.SuspendRequested:
                    break;
                case ThreadState.Background:
                    break;
                case ThreadState.Unstarted:
                    netThread.Start();
                    break;
                case ThreadState.Stopped:
                    netThread = new Thread(new ThreadStart(ThreadFunc));
                    netThread.Start();
                    break;
                case ThreadState.WaitSleepJoin:
                    break;
                case ThreadState.Suspended:
                    break;
                case ThreadState.AbortRequested:
                    break;
                case ThreadState.Aborted:
                    break;
                default:
                    break;
            }
        }

        public void SetDateValue(object msg, string dataName, object value)
        {
            if (msg == null)
            {
                return;
            }
            Type t = msg.GetType();
            PropertyInfo info = t.GetProperty(dataName);
            switch (info.PropertyType.Name)
            {
                case PropertyType.Int32:
                    int n = Convert.ToInt32(value);
                    info.SetValue(msg, n, null);
                    return;
                case PropertyType.String:
                    string str = value.ToString();
                    info.SetValue(msg, str, null);
                    return;
                case PropertyType.UInt64:
                    UInt64 uInt = Convert.ToUInt64(value);
                    info.SetValue(msg, uInt, null);
                    break;
                case PropertyType.Float:
                    float fN = Convert.ToSingle(value);
                    info.SetValue(msg, fN, null);
                    break;
                case PropertyType.Bool:
                    bool bN = Convert.ToBoolean(value);
                    info.SetValue(msg, bN, null);
                    break;
                case PropertyType.List:
                    string tempString = value.ToString();
                    string[] sp = StringUtil.GetSplitString(tempString, '|');

                    var lst = info.GetValue(msg, null);
                    var addMethod = lst.GetType().GetMethod("Add");

                    var TType = lst.GetType().GetTypeInfo().GenericTypeArguments[0];
                    switch (TType.Name)
                    {
                        case PropertyType.Int32:
                            foreach (string item in sp)
                            {
                                addMethod.Invoke(lst, new object[] { Convert.ToInt32(item) });
                            }
                            return;
                        case PropertyType.String:
                            foreach (string item in sp)
                            {
                                addMethod.Invoke(lst, new object[] { item });
                            }
                            return;
                        case PropertyType.UInt64:
                            foreach (string item in sp)
                            {
                                addMethod.Invoke(lst, new object[] { Convert.ToUInt64(item) });
                            }
                            break;
                        case PropertyType.Float:
                            foreach (string item in sp)
                            {
                                addMethod.Invoke(lst, new object[] { Convert.ToSingle(item) });
                            }
                            break;
                        case PropertyType.Bool:
                            foreach (string item in sp)
                            {
                                addMethod.Invoke(lst, new object[] { Convert.ToBoolean(item) });
                            }
                            break;
                        default:
                            Log.ErrorLine("相关类型数据解析功能正在建设中！");
                            break;
                    }

                    //if (t.Name == "MSG_CG_GET_WORLD_ROOM_LIST")
                    //{
                    //    MSG_CG_GET_WORLD_ROOM_LIST tempmsg = (MSG_CG_GET_WORLD_ROOM_LIST)msg;
                    //    foreach (var item in tempmsg.RoomIds)
                    //    {
                    //        Log.ErrorLine("{0}\n",item);
                    //    } 
                    //}

                    break;
                default:
                    break;

            }
        }

        private bool ParseInit()
        {
            if (client == null)
            {
                Log.WriteLine("tcp already disconnected!now to compile the protoBuff");
            }
            else
            {
                client.Exit();
            }
            if (!bIsAssembly)
            {

                return true;
            }

            return AssemblyParser.AssemblyParse(PathExt.codePath);
        }

        public MainForm()
        {
            InitializeComponent();

            var height = Height;
            MinimumSize = new Size(height, height);
            MaximumSize = new Size(Screen.PrimaryScreen.WorkingArea.Width, height);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LogManager.inst.Init(this);

            PathExt.InitPath();
            InitXml();
            LoadXml();
            if (bIsAssembly)
            {
                if (ParseInit())
                {
                    msgApi = new AssemblyProtoMsg();
                }
               
            }
            else
            {
                msgApi = new ProtoMsg();
            }
            if (msgApi == null)
            {
                Log.ErrorLine("msgApi is null");
                return;
            }
            msgApi.BindMsgId();
            msgApi.BindParser();
            Connect();

            AssemblyHandler handler;
            AssemblyResult result;

            AssemblyParser.GetAsseblyResult(out handler, out result);
            if (result == null)
            {
                Log.ErrorLine("AssemblyResult is null");
            }
            foreach (var item in result.ClassList)
            {
                if (item.Value.Contains("Message") && item.Key.Contains("MSG_CG"))
                {
                    AssemblyClassInfo classInfo = handler.GetClassInfo(ConstData.ClientMsgDll, item.Value);
                    list.Add(classInfo.ClassName, classInfo);
                    comboBox2.Items.Add(classInfo.ClassName);
                }
            }
        }
        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            client.Exit();
            if (netThread.IsAlive)
            {
                netThread.Abort();
            }
            LogManager.inst.Close();
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            if (AccountNameInput.Text != null)
            {
                client.SetAccountName(AccountNameInput.Text.ToString());
                if (client == null)
                {
                    Log.WriteLine("please check tcp connect!");
                }
                else
                {
                    client.Request_MSG_CB_LOGIN_SERVERS();
                }
            }
            else
            {
                Log.Write("请输入账号进行登录");
            }
        }

        private void GetProto_Click(object sender, EventArgs e)
        {
            if (comboBox2.SelectedItem != null)
            {
                key = comboBox2.SelectedItem.ToString();
                if (client == null)
                {
                    Log.WriteLine("please check tcp connect!");
                }
                else
                {
                    if (client == null)
                    {
                        Log.WriteLine("please check tcp connect!");
                        return;
                    }
                    object msg = msgApi.RouteInit(key);
                    Parse(msg, list[key], this);
                }
            }
            else
            {
                Log.ErrorLine("choose an null protobuff name");
            }
        }

        private void SendBtn_Click(object sender, EventArgs e)
        {
            if (client == null)
            {
                Log.WriteLine("please check tcp connect!");
                return;
            }
            object msg = msgApi.RouteGet(key);
            if (msg == null)
            {
                return;
            }

            int rowCount = this.dataGridView1.Rows.Count;
            int columnsCount = this.dataGridView1.ColumnCount;
            for (int i = 0; i < rowCount - 1; i++)
            {
                string dataType = "";
                string dataName = "";
                string dataValue = "";

                object objtmp;
                objtmp = this.dataGridView1.Rows[i].Cells[0].Value;
                if (objtmp != null)
                {
                    dataType = objtmp.ToString();
                }
                else
                {
                    string strLog = string.Format("row {0} dataType null", i);
                    Log.WarnLine(strLog);
                }

                objtmp = this.dataGridView1.Rows[i].Cells[1].Value;
                if (objtmp != null)
                {
                    dataName = objtmp.ToString();
                }
                else
                {
                    string strLog = string.Format("row {0} dataName null", i);
                    Log.WarnLine(strLog);
                }
                objtmp = this.dataGridView1.Rows[i].Cells[2].Value;

                if (objtmp != null)
                {
                    dataValue = objtmp.ToString();
                }
                else
                {
                    string strLog = string.Format("row {0} dataValue null", i);
                    Log.WarnLine(strLog);
                    return;
                    //MessageBox.Show(strLog);
                }
                SetDateValue(msg, dataName, objtmp);

                string strText = dataName + ":" + dataValue + " " + DateTime.Now + System.Environment.NewLine;
                MainTextBox.AppendText(strText);
                MainTextBox.ScrollToCaret();
            }

            //MSG_CG_ITEM_BUY TESTMSG = (MSG_CG_ITEM_BUY)msg;
            //int a = TESTMSG.Id;
            //int b = TESTMSG.Num;
            //Console.Write("id:{0},Num{1}", TESTMSG.Id, TESTMSG.Num);
            if (client.IsLogin())
            {
                msgApi.RouteSend(client.Net, key,msg);
            }
            else
            {
                Log.WarnLine("please login your account!");
            }
        }

        private void ConnectBtn_Click(object sender, EventArgs e)
        {
            Connect();
        }

        private void DisConnectBtn_Click(object sender, EventArgs e)
        {
            if (client == null)
            {
                Log.WriteLine("tcp already disconnected!");
                return;
            }
            client.Exit();
        }

        private void GenrateBtn_Click(object sender, EventArgs e)
        {
            ParseInit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainTextBox.Clear();
            MainTextBox.Refresh();
        }


    }
}
