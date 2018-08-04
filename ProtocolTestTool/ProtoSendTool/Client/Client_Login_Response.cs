using System.IO;
using Engine.Foundation;
using Message.Server.Gate.Protocol.GateC;
using System.Collections.Generic;
using EnumerateUtility.Battle;

namespace ProtoSendTool
{
    public partial class Client
    {
        public void BindResponse_Login()
        {
            Net.AddResponser(Id<MSG_GC_TIME_SYNC>.Value, OnResponse_MSG_GC_TIME_SYNC);
            Net.AddResponser(Id<MSG_GC_BLOWFISHKEY>.Value, OnResponse_MSG_GC_BLOWFISHKEY);
            Net.AddResponser(Id<MSG_GC_USER_LOGIN>.Value, OnResponse_MSG_GC_USER_LOGIN);
            Net.AddResponser(Id<MSG_GC_ENTER_WORLD>.Value, OnResponse_MSG_GC_ENTER_WORLD);
            Net.AddResponser(Id<MSG_GC_ENTER_ZONE>.Value, OnResponse_MSG_GC_ENTER_ZONE);
            Net.AddResponser(Id<MSG_GC_HEARTBEAT>.Value, OnResponse_MSG_GC_HEARTBEAT);

        }

        public void OnResponse_MSG_GC_HEARTBEAT(MemoryStream stream)
        {
            MSG_GC_HEARTBEAT MSG_GC_HEARTBEAT = ProtoBuf.Serializer.Deserialize<MSG_GC_HEARTBEAT>(stream);
            Parser.Parse(MSG_GC_HEARTBEAT);
            Request_MSG_CG_HEARTBEAT();
        }
        public void OnResponse_MSG_GC_TIME_SYNC(MemoryStream stream)
        {
            MSG_GC_TIME_SYNC MSG_GC_TIME_SYNC = ProtoBuf.Serializer.Deserialize<MSG_GC_TIME_SYNC>(stream);
            Parser.Parse(MSG_GC_TIME_SYNC);

            //RefreshTimer.inst.ServerTime = RefreshTimer.inst.StampToDateTime((long)msg.timeStamp);
            //RefreshTimer.inst.GameSyncTime = DateTime.Now;
            //LuaManager.inst.Call("TimeManager.SetServerTime", LuaManager.GetMainState()["TimeManager"], msg.timeStamp.ToString());
        }



        static string GetPublicKey()
        {
            string txt = "AwEAAb6o1PA1tWqffHgpSUJNcDYxBavJ4CARq8Dd7JUdR / MbcwpaRVk2tw / WN3pS8uge0n8kjY5hvi9oJWVwHyXHORGhZYYcBk9DvLL0GfkEsRscL3jhedoAwkC4Cdy + N2pDycuCiNyp6W3oRBKPPk7D4anCSESe0pOpxmxYHjKSvVaP";
            return txt;
        }
        public void OnResponse_MSG_GC_BLOWFISHKEY(MemoryStream stream)
        {
            MSG_GC_BLOWFISHKEY MSG_GC_BLOWFISHKEY = ProtoBuf.Serializer.Deserialize<MSG_GC_BLOWFISHKEY>(stream);
            Parser.Parse(MSG_GC_BLOWFISHKEY);
            //string rsaKey = RSAHelper.DecryptString(MSG_GC_BLOWFISHKEY.BlowfishKey, GetPublicKey());
            ////ProtocolPacket.blowFishInst = new BlowFish(rsaKey);

            //if (ProtocolPacket.gettingBlowFishKey)
            //{
            //    //NET.GetProtocol().gettingBlowFishKey = false;
            //    //MSG_CG_RECONNECT_LOGIN login = new MSG_CG_RECONNECT_LOGIN();
            //    //login.token = PLAYER.Token;
            //    //login.uid = PLAYER.CurrentCharacterUid;
            //    //login.accountName = PLAYER.AccountName;
            //    //m_protocol.Send(login);
            //}
        }

        List<MSG_GC_CHARACTER_INFO> mCharacterList = new List<MSG_GC_CHARACTER_INFO>();
        public void OnResponse_MSG_GC_USER_LOGIN(MemoryStream stream)
        {
            MSG_GC_USER_LOGIN MSG_GC_USER_LOGIN = ProtoBuf.Serializer.Deserialize<MSG_GC_USER_LOGIN>(stream);
            Parser.Parse(MSG_GC_USER_LOGIN);

            if (MSG_GC_USER_LOGIN.result == 1)
            {
                mCharacterList.Clear();
                for (int i = 0; i < MSG_GC_USER_LOGIN.character_list.Count; ++i)
                {
                    MSG_GC_CHARACTER_INFO characterInfo = MSG_GC_USER_LOGIN.character_list[i];
                    mCharacterList.Add(characterInfo);
                }
                if (mCharacterList.Count > 0)
                {
                    //����ѡ�� TODO
                    Request_MSG_CG_TO_ZONE(mCharacterList[0].Uid);
                }
                else
                {
                    //UnityEngine.Debug.Log("Create new player");
                    //GameManager.inst.ChangeScene(DEF.SCENE_CREATECHARACTER);
                }
                //CFG_SAVE.SaveConfig();

            }
            else if (MSG_GC_USER_LOGIN.result == 144)
            {
                //EventManager.Dispatch(EventConst.BadVersion);
            }
            else
            {
                //UnityEngine.Debug.Log("Login failed: {0}" + MSG_GC_USER_LOGIN.result.ToString());
            }
            //UI.CloseWait();
        }
        public void OnResponse_MSG_GC_ENTER_WORLD(MemoryStream stream)
        {
            MSG_GC_ENTER_WORLD MSG_GC_ENTER_WORLD = ProtoBuf.Serializer.Deserialize<MSG_GC_ENTER_WORLD>(stream);
            Parser.Parse(MSG_GC_ENTER_WORLD);

            PLAYER.CharInfo = MSG_GC_ENTER_WORLD.myselfInfo;
            PLAYER.CurrentCharacterUid = MSG_GC_ENTER_WORLD.myselfInfo.Uid;
            PLAYER.EquipPetID = MSG_GC_ENTER_WORLD.myselfInfo.PetId;
            PLAYER.Token = MSG_GC_ENTER_WORLD.Token;
            PLAYER.InFindingTarget = false;
        }
        public void OnResponse_MSG_GC_ENTER_ZONE(MemoryStream stream)
        {
            MSG_GC_ENTER_ZONE MSG_GC_ENTER_ZONE = ProtoBuf.Serializer.Deserialize<MSG_GC_ENTER_ZONE>(stream);
            Parser.Parse(MSG_GC_ENTER_ZONE);

            PLAYER.MapTransforming = true;
            PLAYER.CharInfo.InstanceId = MSG_GC_ENTER_ZONE.instanceId;
            PLAYER.CurrentCharacterId = MSG_GC_ENTER_ZONE.instanceId;
            PLAYER.CharInfo.PosX = MSG_GC_ENTER_ZONE.posX;
            PLAYER.CharInfo.PosY = MSG_GC_ENTER_ZONE.posY;
            PLAYER.IsChangeChannel = false;
            if (PLAYER.Channel != 0 && PLAYER.Channel != MSG_GC_ENTER_ZONE.channel)
            { //�ж��Ƿ����ߣ�����load���� �����NPC�Ͳɼ��� TODO
                PLAYER.IsChangeChannel = true;
            }
            PLAYER.Channel = MSG_GC_ENTER_ZONE.channel;
            PLAYER.MinChannel = MSG_GC_ENTER_ZONE.minChannel;
            PLAYER.MaxChannel = MSG_GC_ENTER_ZONE.maxChannel;
            if (PLAYER.BattleType < (int)BattleType.MatchNormal)
            {//��ս��
                if (!PLAYER.IsChangeChannel)
                {//������
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
                    Request_MSG_CG_MAP_LOADING_DONE(MSG_GC_ENTER_ZONE.mapId, PLAYER.Channel);
                }
                else
                {//���� ������������
                    //CharacterManager.inst.ClearOtherPlayer();
                    //// CharacterManager.inst.ClearQueue();
                    //CharacterManager.inst.BindPlayer(PLAYER.CharInfo);
                    //UI.CloseWait(OnCloseWait(), 3f, "system_changechannelsuccess");
                    Request_MSG_CG_MAP_LOADING_DONE(MSG_GC_ENTER_ZONE.mapId, PLAYER.Channel);
                    PLAYER.MapTransforming = false;
                    //UnityEngine.Debug.Log("===PLAYER.Channel=== ���߳ɹ�" + PLAYER.Channel);
                }
            }
            else
            {//ս��
                //CharacterManager.inst.ClearQueue();
                //CharacterManager.inst.BindPlayer(PLAYER.CharInfo);
                Request_MSG_CG_MAP_LOADING_DONE(MSG_GC_ENTER_ZONE.mapId, PLAYER.Channel);
            }
            //PLAYER.CurrentActorInfo.lookAngle = MSG_GC_ENTER_ZONE.angle;
            //return true;
        }
    }
}