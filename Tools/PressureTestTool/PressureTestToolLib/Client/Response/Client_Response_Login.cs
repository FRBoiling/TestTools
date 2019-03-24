using EnumerateUtility;
using Logger;
using Message.Server.Gate.Protocol.GateC;
using Message.Server.Barrack.Protocol.BarrackC;
using System.IO;

namespace PressureTestToolLib
{
    public partial class Client
    {
        private void OnResponse_MSG_BC_LOGIN_SERVERS(MemoryStream stream)
        {
            if (player.IsLogin)
            {
                return;
            }
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

        public void CreaterCharactor()
        {
            Request_CreateCharacter();
        }

        public void OnResponse_MSG_GC_CREATE_CHARACTER(MemoryStream stream)
        {
            MSG_GC_CREATE_CHARACTER MSG_GC_CREATE_CHARACTER = ProtoBuf.Serializer.Deserialize<MSG_GC_CREATE_CHARACTER>(stream);
            if (MSG_GC_CREATE_CHARACTER.result == (int)ErrorCode.Success)
            {
                 player.CharInfo = MSG_GC_CREATE_CHARACTER.character;
                 Request_MSG_CG_TO_ZONE(MSG_GC_CREATE_CHARACTER.character.Uid);
            }
            else
            {
                Log.WriteLine("create charactor fail : errocode {0}", MSG_GC_CREATE_CHARACTER.result);
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
         
 
            Request_MSG_CG_MAP_LOADING_DONE(MSG_GC_ENTER_ZONE.mapId, player.Channel);
        
        }



    }
}
