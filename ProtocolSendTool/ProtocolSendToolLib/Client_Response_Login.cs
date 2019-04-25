using System.IO;
using Message.Gate.Protocol.GateC;
using System.Collections.Generic;
using Message.Barrack.Protocol.BarrackC;
using EnumerateUtility;
using Logger;
using Message.IdGenerator;
using CryptoUtility;

namespace ProtocolSendToolLib
{
    public partial class Client
    {
        List<int> loginedServers = new List<int>();
        List<MSG_GC_CHARACTER_INFO> characterList = new List<MSG_GC_CHARACTER_INFO>();
        public void BindResponse_Login()
        {
            Net.AddResponser(Id<MSG_BC_LOGIN_SERVERS>.Value, OnResponse_MSG_BC_LOGIN_SERVERS);
            Net.AddResponser(Id<MSG_BC_USER_LOGIN>.Value, OnResponse_MSG_BC_USER_LOGIN);
            Net.AddResponser(Id<MSG_GC_CHARACTER_LIST>.Value, OnResponse_MSG_GC_CHARACTER_LIST);
            Net.AddResponser(Id<MSG_GC_ENTER_WORLD>.Value, OnResponse_MSG_GC_ENTER_WORLD);
            Net.AddResponser(Id<MSG_GC_ENTER_ZONE>.Value, OnResponse_MSG_GC_ENTER_ZONE);
            Net.AddResponser(Id<MSG_GC_CREATE_CHARACTER>.Value, OnResponse_MSG_GC_CREATE_CHARACTER);

            //Net.AddResponser(Id<MSG_GC_TIME_SYNC>.Value, OnResponse_MSG_GC_TIME_SYNC);
            Net.AddResponser(Id<MSG_GC_BLOWFISHKEY>.Value, OnResponse_MSG_GC_BLOWFISHKEY);
            //Net.AddResponser(Id<MSG_GC_HEARTBEAT>.Value, OnResponse_MSG_GC_HEARTBEAT);
        }

        public void OnResponse_MSG_BC_LOGIN_SERVERS(MemoryStream stream)
        {
            MSG_BC_LOGIN_SERVERS MSG_BC_LOGIN_SERVERS =MessagePacker.ProtobufHelper.Deserialize<MSG_BC_LOGIN_SERVERS>(stream);
            loginedServers.AddRange(MSG_BC_LOGIN_SERVERS.LoginServers);

            int mainId = ChoseOneLoginedServer();
            Request_MSG_CB_USER_LOGIN(mainId);
        }

        public void OnResponse_MSG_BC_USER_LOGIN(MemoryStream stream)
        {
            MSG_BC_USER_LOGIN MSG_BC_USER_LOGIN =MessagePacker.ProtobufHelper.Deserialize<MSG_BC_USER_LOGIN>(stream);

            if (MSG_BC_USER_LOGIN.Result == (int)ErrorCode.Success)
            {
                player.Token = MSG_BC_USER_LOGIN.Token;
                //1断开Barrack
                Exit();
                SetConnect(MSG_BC_USER_LOGIN.GateIp, MSG_BC_USER_LOGIN.GatePort, MSG_BC_USER_LOGIN.Token);
                //2 连接Gate    
                Connect2Server();
                if (IsConnected())
                {
                    //Request_MSG_CG_CHARACTER_LIST();
                    Request_MSG_CG_GET_BLOWFISHKEY();
                }
                else
                {
                    Log.WriteLine("connect to gate failed ,please try to login again");
                }
            }
        }

        public void OnResponse_MSG_GC_CHARACTER_LIST(MemoryStream stream)
        {
            MSG_GC_CHARACTER_LIST MSG_GC_CHARACTER_LIST =MessagePacker.ProtobufHelper.Deserialize<MSG_GC_CHARACTER_LIST>(stream);

            if (MSG_GC_CHARACTER_LIST.Result == (int)ErrorCode.Success)
            {
                player.IsLogin = true;
                characterList.AddRange(MSG_GC_CHARACTER_LIST.List);
                if (characterList.Count > 0)
                {
                    int uid = ChoseOneCharacter();
                    Request_MSG_CG_TO_ZONE(uid);
                }
                else
                {
                    CreaterCharactor();
                }
            }
        }

        public void OnResponse_MSG_GC_ENTER_WORLD(MemoryStream stream)
        {
            MSG_GC_ENTER_WORLD MSG_GC_ENTER_WORLD =MessagePacker.ProtobufHelper.Deserialize<MSG_GC_ENTER_WORLD>(stream);
            player.CharInfo = MSG_GC_ENTER_WORLD.MyselfInfo;
            player.CurrentCharacterUid = MSG_GC_ENTER_WORLD.MyselfInfo.Uid;
            player.EquipPetID = MSG_GC_ENTER_WORLD.MyselfInfo.PetId;
            player.Token = MSG_GC_ENTER_WORLD.Token;
            player.InFindingTarget = false;
        }

        public void OnResponse_MSG_GC_ENTER_ZONE(MemoryStream stream)
        {
            MSG_GC_ENTER_ZONE MSG_GC_ENTER_ZONE =MessagePacker.ProtobufHelper.Deserialize<MSG_GC_ENTER_ZONE>(stream);
            player.MapTransforming = true;
            player.CharInfo.InstanceId = MSG_GC_ENTER_ZONE.InstanceId;
            player.CurrentCharacterId = MSG_GC_ENTER_ZONE.InstanceId;
            player.CharInfo.PosX = MSG_GC_ENTER_ZONE.PosX;
            player.CharInfo.PosY = MSG_GC_ENTER_ZONE.PosY;
            player.IsChangeChannel = false;
            if (player.Channel != 0 && player.Channel != MSG_GC_ENTER_ZONE.Channel)
            { //判断是否切线，是则不load场景 不清除NPC和采集物 TODO
                player.IsChangeChannel = true;
            }
            player.Channel = MSG_GC_ENTER_ZONE.Channel;
            player.MinChannel = MSG_GC_ENTER_ZONE.MinChannel;
            player.MaxChannel = MSG_GC_ENTER_ZONE.MaxChannel;
            //if (PLAYER.BattleType < (int)BattleType.MatchNormal)
            //{//非战场
            if (!player.IsChangeChannel)
            {//非切线
             //CharacterManager.inst.ClearQueue();
             //CharacterManager.inst.BindPlayer(PLAYER.CharInfo);
             //MapManager.inst.LoadMap(MSG_GC_ENTER_ZONE.mapId);
             //foreach (MSG_ZGC_NPC_INFO info in MSG_GC_ENTER_ZONE.NpcList)
             //{
             //    CharacterManager.inst.BindNPC(info);
             //}
             //foreach (MSG_ZGC_GOODS_INFO item in MSG_GC_ENTER_ZONE.GoodsList)
             //{
             //    CharacterManager.inst.BindNPCItem(item);
             //}
                Login_Request_MSG_CG_MAP_LOADING_DONE(MSG_GC_ENTER_ZONE.MapId, player.Channel);
            }
            else
            {//切线 清除场景中玩家
             //CharacterManager.inst.ClearOtherPlayer();
             //// CharacterManager.inst.ClearQueue();
             //CharacterManager.inst.BindPlayer(PLAYER.CharInfo);
             //UI.CloseWait(OnCloseWait(), 3f, "system_changechannelsuccess");
                Login_Request_MSG_CG_MAP_LOADING_DONE(MSG_GC_ENTER_ZONE.MapId, player.Channel);
                player.MapTransforming = false;
            }
        }

        public void OnResponse_MSG_GC_CREATE_CHARACTER(MemoryStream stream)
        {
            MSG_GC_CREATE_CHARACTER MSG_GC_CREATE_CHARACTER =MessagePacker.ProtobufHelper.Deserialize<MSG_GC_CREATE_CHARACTER>(stream);
            if (MSG_GC_CREATE_CHARACTER.Result == (int)ErrorCode.Success)
            {
                Request_MSG_CG_TO_ZONE(MSG_GC_CREATE_CHARACTER.Character.Uid);
            }
            else
            {
                Log.WriteLine("create charactor fail!");
            }
        }

        //public void OnResponse_MSG_GC_HEARTBEAT(MemoryStream stream)
        //{
        //    MSG_GC_HEARTBEAT MSG_GC_HEARTBEAT =MessagePacker.ProtobufHelper.Deserialize<MSG_GC_HEARTBEAT>(stream);
        //    //Parser.Parse(MSG_GC_HEARTBEAT);
        //    Request_MSG_CG_HEARTBEAT();
        //}
        //public void OnResponse_MSG_GC_TIME_SYNC(MemoryStream stream)
        //{
        //    MSG_GC_TIME_SYNC MSG_GC_TIME_SYNC =MessagePacker.ProtobufHelper.Deserialize<MSG_GC_TIME_SYNC>(stream);
        //    //Parser.Parse(MSG_GC_TIME_SYNC);

        //    //RefreshTimer.inst.ServerTime = RefreshTimer.inst.StampToDateTime((long)msg.timeStamp);
        //    //RefreshTimer.inst.GameSyncTime = DateTime.Now;
        //    //LuaManager.inst.Call("TimeManager.SetServerTime", LuaManager.GetMainState()["TimeManager"], msg.timeStamp.ToString());
        //}

        static string GetPublicKey()
        {
            string txt = "AwEAAcAWrXsUCksi1ezxNvx5Vvr+NPoJl03/oOo3tPaUan3e6Bnal+9D9tJDQr4nd0p1Kw2XtqfSAbGbWoMlJoUf29vRlOunViQq1OMsn1KXUEG3YOwsrnd5+D3ncMyNHYfTrgeVR8RbwughVqFu0y4QCNUtv18rXYueH0pFHkvafO5F";
            return txt;
        }

        public void OnResponse_MSG_GC_BLOWFISHKEY(MemoryStream stream)
        {
            MSG_GC_BLOWFISHKEY MSG_GC_BLOWFISHKEY = MessagePacker.ProtobufHelper.Deserialize<MSG_GC_BLOWFISHKEY>(stream);
            //Parser.Parse(MSG_GC_BLOWFISHKEY);
            string rsaKey = RSAHelper.DecryptString(MSG_GC_BLOWFISHKEY.BlowfishKey, GetPublicKey());

            Net.packetHandler.BlowFishInst = new BlowFish(rsaKey);

            //if (Net.packetHandler.gettingBlowFishKey)
            //{
            //NET.GetProtocol().gettingBlowFishKey = false;
            //MSG_CG_RECONNECT_LOGIN login = new MSG_CG_RECONNECT_LOGIN();
            //login.token = PLAYER.Token;
            //login.uid = PLAYER.CurrentCharacterUid;
            //login.accountName = PLAYER.AccountName;
            //m_protocol.Send(login);
            //}

            //获取角色列表
            Request_MSG_CG_CHARACTER_LIST();
        }

    }
}