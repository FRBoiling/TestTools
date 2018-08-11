using LibLog;
using LibUtil;
using ProtoParserLib;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Threading;
using System.Windows.Forms;
using XmlDataParser;

namespace ProtoSendTool
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            var height = Height;
            MinimumSize = new Size(height, height);
            MaximumSize = new Size(Screen.PrimaryScreen.WorkingArea.Width, height);
        }

        IClient client;
        Dictionary<string, AssemblyClassInfo> list = new Dictionary<string, AssemblyClassInfo>();
        string key = "MSG_CG_USER_LOGIN";
        string clientMsgDll = "Message.ClientProtocol.dll";

        Thread netThread;
        static string GateIp = "127.0.0.1";
        static int GatePort = 8403;
        private bool bIsAssembly = false;

        private void Method()
        {
            if (client == null)
            {
                if (bIsAssembly)
                {
                    client = new AssemblyClient();
                }
                else
                {
                    client = new LibClient();
                }
            }
            client.Init(GateIp, GatePort);
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
                Data data = DataListManager.inst.GetData("GateList", 1);
                GateIp = data.GetString("GateIp");
                GatePort = data.GetInt("GatePort");
                Log.WriteLine("Init NetConfig success!");
            }
            catch (System.Exception)
            {

                throw;
            }
        }


        private void MainForm_Load(object sender, EventArgs e)
        {
            LogManager.inst.Init(this);

            PathExt.InitPath();
            PathExt.SetTestPath();
            InitXml();
            LoadXml();

            if (ParseInit())
            {
                Connect();
            }

            clientMsgDll = @"Message.ClientProtocol.dll";

            AssemblyHandler handler = new AssemblyHandler();
            AssemblyResult result = handler.GetClassName(clientMsgDll);
            result.AssemblyNameList = new List<string>();
            result.AssemblyNameList.Add(clientMsgDll);

            foreach (var item in result.ClassList)
            {
                if (item.Value.Contains("protocol.client") && item.Key.Contains("MSG_CG"))
                {
                    AssemblyClassInfo classInfo = handler.GetClassInfo(clientMsgDll, item.Value);
                    list.Add(classInfo.ClassName, classInfo);
                    ProtocolSelect.Items.Add(classInfo.ClassName);
                }
            }
        }
        public void Parse(object obj, AssemblyClassInfo assemblyClassInfo, MainForm mainForm)
        {
            mainForm.ClearDataGrid();
            if (obj == null)
            {
                return;
            }
            Type t = obj.GetType();

            foreach (var item in assemblyClassInfo.Properties)
            {
                mainForm.SetDataGridValue(item);
            }
            return;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (ProtocolSelect.SelectedItem != null)
            {
                key = ProtocolSelect.SelectedItem.ToString();
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
                    object msg = client.RouteInit(key);
                    Parse(msg, list[key], this);
                }
            }
            else
            {
                Log.ErrorLine("choose an null protobuff name");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (client == null)
            {
                Log.WriteLine("please check tcp connect!");
                return;
            }
            object msg = client.RouteGet(key);
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
            if (PLAYER.IsLogin)
            {
                client.RouteSend(key, msg);
            }
            else
            {
                Log.WarnLine("please login your account!");
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
                MainTextBox.AppendText(log);
                MainTextBox.AppendText(Environment.NewLine);
                MainTextBox.AppendText(Environment.NewLine);
                MainTextBox.ScrollToCaret();
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
                    string[] sp = StringParser.GetSplitString(tempString, '|');

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

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            if (UsernameInput.Text != null)
            {
                PLAYER.username = UsernameInput.Text.ToString();
                if (client == null)
                {
                    Log.WriteLine("please check tcp connect!");
                }
                else
                {
                    client.Login_Request_MSG_CG_USER_LOGIN();
                }
            }
            else
            {
                Log.Write("请输入账号进行登录");
            }

        }

        private void ReconnectLoginBtn_Click(object sender, EventArgs e)
        {
            if (client == null)
            {
                Log.WriteLine("please check tcp connect!");
            }
            else
            {
                client.ReconnectLogin_Request_MSG_CG_RECONNECT_LOGIN();
            }
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            MainTextBox.Clear();
            MainTextBox.Refresh();
        }

        private void ParserBtn_Click(object sender, EventArgs e)
        {
            ParseInit();
        }

        private bool ParseInit()
        {
            if (client == null)
            {
                Log.WriteLine("tcp already disconnected! ");
            }
            else
            {
                client.Exit();
            }
            if (!bIsAssembly)
            {
                return true;
            }

            Log.WriteLine("compile the proto buff");
           
            string code = ParseCode.AssemblyParseDll(clientMsgDll);

            string soure = PathExt.workPath + @"\ProtocolTestTool\ProtoSendLib\";
            string str1 = soure + @"Client.cs";
            string str2 = soure + @"Client_Code.cs";
            string str3 = soure + @"Client_Login_Requset.cs";
            string str4 = soure + @"Client_Login_Response.cs";
            string str5 = soure + @"HostInfo.cs";

            string[] files = new string[] { str1, str2, str3, str4, str5 };

            CompilerResults result = ParseCode.DebugRun(files, "ProtoSendLib.dll");
            if (result.Errors.HasErrors)
            {
                Log.WriteLine("编译错误");
                foreach (CompilerError err in result.Errors)
                {
                    Log.ErrorLine(err.ErrorText);
                }
                return false;
            }
            else
            {
                Log.WriteLine("编译成功");
                //Assembly objAssembly = result.CompiledAssembly;
                //object objectClient = objAssembly.CreateInstance("ProtoSendLib.Client");
                //client = new Client(objectClient);
                return true;
            }
        }

        private void ConnectBtn_Click(object sender, EventArgs e)
        {

            Connect();
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
                netThread = new Thread(new ThreadStart(Method));
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
                    netThread = new Thread(new ThreadStart(Method));
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

        private void DisConnectBtn_Click(object sender, EventArgs e)
        {
            if (client == null)
            {
                Log.WriteLine("tcp already disconnected!");
                return;
            }
            client.Exit();
        }

        private void MainForm_Closing(object sender, FormClosingEventArgs e)
        {
            if (client == null)
            {
                Log.WriteLine("tcp already disconnected!");
                return;
            }
            client.Exit();
        }

    }
}
