using System.IO;
using Engine.Foundation;
using Message.Server.Gate.Protocol.GateC;
using System.Collections.Generic;
using Message.Server.Barrack.Protocol.BarrackC;
using EnumerateUtility;
using Logger;

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
            //Net.AddResponser(Id<MSG_GC_BLOWFISHKEY>.Value, OnResponse_MSG_GC_BLOWFISHKEY);
            //Net.AddResponser(Id<MSG_GC_HEARTBEAT>.Value, OnResponse_MSG_GC_HEARTBEAT);
        }

        public void OnResponse_MSG_BC_LOGIN_SERVERS(MemoryStream stream)
        {
            MSG_BC_LOGIN_SERVERS MSG_BC_LOGIN_SERVERS = ProtoBuf.Serializer.Deserialize<MSG_BC_LOGIN_SERVERS>(stream);
            loginedServers.AddRange(MSG_BC_LOGIN_SERVERS.loginServers);

            int mainId = ChoseOneLoginedServer();
            Request_MSG_CB_USER_LOGIN(mainId);
        }

        public void OnResponse_MSG_BC_USER_LOGIN(MemoryStream stream)
        {
            MSG_BC_USER_LOGIN MSG_BC_USER_LOGIN = ProtoBuf.Serializer.Deserialize<MSG_BC_USER_LOGIN>(stream);

            if (MSG_BC_USER_LOGIN.result == (int)ErrorCode.Success)
            {
                player.Token = MSG_BC_USER_LOGIN.token;
                //1断开Barrack
                Exit();
                SetConnect(MSG_BC_USER_LOGIN.gateIp, MSG_BC_USER_LOGIN.gatePort, MSG_BC_USER_LOGIN.token);
                //2 连接Gate    
                Connect2Server();
                if (IsConnected())
                {
                    Request_MSG_CG_CHARACTER_LIST();
                }
                else
                {
                    Log.WriteLine("connect to gate failed ,please try to login again");
                }
            }
        }

        public void OnResponse_MSG_GC_CHARACTER_LIST(MemoryStream stream)
        {
            MSG_GC_CHARACTER_LIST MSG_GC_CHARACTER_LIST = ProtoBuf.Serializer.Deserialize<MSG_GC_CHARACTER_LIST>(stream);

            if (MSG_GC_CHARACTER_LIST.result == (int)ErrorCode.Success)
            {
                player.IsLogin = true;
                characterList.AddRange(MSG_GC_CHARACTER_LIST.list);
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
            MSG_GC_ENTER_WORLD MSG_GC_ENTER_WORLD = ProtoBuf.Serializer.Deserialize<MSG_GC_ENTER_WORLD>(stream);
            player.CharInfo = MSG_GC_ENTER_WORLD.myselfInfo;
            player.CurrentCharacterUid = MSG_GC_ENTER_WORLD.myselfInfo.Uid;
            player.EquipPetID = MSG_GC_ENTER_WORLD.myselfInfo.PetId;
            player.Token = MSG_GC_ENTER_WORLD.Token;
            player.InFindingTarget = false;
        }

        public void OnResponse_MSG_GC_ENTER_ZONE(MemoryStream stream)
        {
            MSG_GC_ENTER_ZONE MSG_GC_ENTER_ZONE = ProtoBuf.Serializer.Deserialize<MSG_GC_ENTER_ZONE>(stream);
            player.MapTransforming = true;
            player.CharInfo.InstanceId = MSG_GC_ENTER_ZONE.instanceId;
            player.CurrentCharacterId = MSG_GC_ENTER_ZONE.instanceId;
            player.CharInfo.PosX = MSG_GC_ENTER_ZONE.posX;
            player.CharInfo.PosY = MSG_GC_ENTER_ZONE.posY;
            player.IsChangeChannel = false;
            if (player.Channel != 0 && player.Channel != MSG_GC_ENTER_ZONE.channel)
            { //判断是否切线，是则不load场景 不清除NPC和采集物 TODO
                player.IsChangeChannel = true;
            }
            player.Channel = MSG_GC_ENTER_ZONE.channel;
            player.MinChannel = MSG_GC_ENTER_ZONE.minChannel;
            player.MaxChannel = MSG_GC_ENTER_ZONE.maxChannel;
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
                Login_Request_MSG_CG_MAP_LOADING_DONE(MSG_GC_ENTER_ZONE.mapId, player.Channel);
            }
            else
            {//切线 清除场景中玩家
             //CharacterManager.inst.ClearOtherPlayer();
             //// CharacterManager.inst.ClearQueue();
             //CharacterManager.inst.BindPlayer(PLAYER.CharInfo);
             //UI.CloseWait(OnCloseWait(), 3f, "system_changechannelsuccess");
                Login_Request_MSG_CG_MAP_LOADING_DONE(MSG_GC_ENTER_ZONE.mapId, player.Channel);
                player.MapTransforming = false;
            }
        }

        public void OnResponse_MSG_GC_CREATE_CHARACTER(MemoryStream stream)
        {
            MSG_GC_CREATE_CHARACTER MSG_GC_CREATE_CHARACTER = ProtoBuf.Serializer.Deserialize<MSG_GC_CREATE_CHARACTER>(stream);
            if (MSG_GC_CREATE_CHARACTER.result == (int)ErrorCode.Success)
            {
                Request_MSG_CG_TO_ZONE(MSG_GC_CREATE_CHARACTER.character.Uid);
            }
            else
            {
                Log.WriteLine("create charactor fail!");
            }
        }

        //public void OnResponse_MSG_GC_HEARTBEAT(MemoryStream stream)
        //{
        //    MSG_GC_HEARTBEAT MSG_GC_HEARTBEAT = ProtoBuf.Serializer.Deserialize<MSG_GC_HEARTBEAT>(stream);
        //    //Parser.Parse(MSG_GC_HEARTBEAT);
        //    Request_MSG_CG_HEARTBEAT();
        //}
        //public void OnResponse_MSG_GC_TIME_SYNC(MemoryStream stream)
        //{
        //    MSG_GC_TIME_SYNC MSG_GC_TIME_SYNC = ProtoBuf.Serializer.Deserialize<MSG_GC_TIME_SYNC>(stream);
        //    //Parser.Parse(MSG_GC_TIME_SYNC);

        //    //RefreshTimer.inst.ServerTime = RefreshTimer.inst.StampToDateTime((long)msg.timeStamp);
        //    //RefreshTimer.inst.GameSyncTime = DateTime.Now;
        //    //LuaManager.inst.Call("TimeManager.SetServerTime", LuaManager.GetMainState()["TimeManager"], msg.timeStamp.ToString());
        //}

        //static string GetPublicKey()
        //{
        //    string txt = "AwEAAb6o1PA1tWqffHgpSUJNcDYxBavJ4CARq8Dd7JUdR / MbcwpaRVk2tw / WN3pS8uge0n8kjY5hvi9oJWVwHyXHORGhZYYcBk9DvLL0GfkEsRscL3jhedoAwkC4Cdy + N2pDycuCiNyp6W3oRBKPPk7D4anCSESe0pOpxmxYHjKSvVaP";
        //    return txt;
        //}
        //public void OnResponse_MSG_GC_BLOWFISHKEY(MemoryStream stream)
        //{
        //    MSG_GC_BLOWFISHKEY MSG_GC_BLOWFISHKEY = ProtoBuf.Serializer.Deserialize<MSG_GC_BLOWFISHKEY>(stream);
        //    //Parser.Parse(MSG_GC_BLOWFISHKEY);
        //    //string rsaKey = RSAHelper.DecryptString(MSG_GC_BLOWFISHKEY.BlowfishKey, GetPublicKey());
        //    ////ProtocolPacket.blowFishInst = new BlowFish(rsaKey);

        //    //if (ProtocolPacket.gettingBlowFishKey)
        //    //{
        //    //    //NET.GetProtocol().gettingBlowFishKey = false;
        //    //    //MSG_CG_RECONNECT_LOGIN login = new MSG_CG_RECONNECT_LOGIN();
        //    //    //login.token = PLAYER.Token;
        //    //    //login.uid = PLAYER.CurrentCharacterUid;
        //    //    //login.accountName = PLAYER.AccountName;
        //    //    //m_protocol.Send(login);
        //    //}
        //}

    }
}