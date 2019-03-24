using System.IO;
using System.Collections.Generic;
using Message.Server.Client.Protocol.CGate;
using Message.Server.Client.Protocol.CBarrack;
using Message.Server.Gate.Protocol.GateC;
using Message.Server.Barrack.Protocol.BarrackC;
using ProtocolObjectParserLib;
using NetPacketLib;
using Engine.Foundation;

namespace ProtocolObjectLib
{
    public class ProtoMsgManager
    {
        public void OnResponse_MSG_GC_INSTANCES_REMOVE(MemoryStream stream)
        {
            MSG_GC_INSTANCES_REMOVE MSG_GC_INSTANCES_REMOVE = ProtoBuf.Serializer.Deserialize<MSG_GC_INSTANCES_REMOVE>(stream);
            Parser.Parse(MSG_GC_INSTANCES_REMOVE);
        }
        public object Deserialize_MSG_GC_INSTANCES_REMOVE(MemoryStream stream)
        {
            return ProtoBuf.Serializer.Deserialize<MSG_GC_INSTANCES_REMOVE>(stream);
        }

        public void OnResponse_MODEL_INFO(MemoryStream stream)
        {
            MODEL_INFO MODEL_INFO = ProtoBuf.Serializer.Deserialize<MODEL_INFO>(stream);
            Parser.Parse(MODEL_INFO);
        }
        public object Deserialize_MODEL_INFO(MemoryStream stream)
        {
            return ProtoBuf.Serializer.Deserialize<MODEL_INFO>(stream);
        }

        public void OnResponse_MSG_GC_CHARACTER_INFO(MemoryStream stream)
        {
            MSG_GC_CHARACTER_INFO MSG_GC_CHARACTER_INFO = ProtoBuf.Serializer.Deserialize<MSG_GC_CHARACTER_INFO>(stream);
            Parser.Parse(MSG_GC_CHARACTER_INFO);
        }
        public object Deserialize_MSG_GC_CHARACTER_INFO(MemoryStream stream)
        {
            return ProtoBuf.Serializer.Deserialize<MSG_GC_CHARACTER_INFO>(stream);
        }

        public void OnResponse_MSG_GC_CHARACTER_LIST(MemoryStream stream)
        {
            MSG_GC_CHARACTER_LIST MSG_GC_CHARACTER_LIST = ProtoBuf.Serializer.Deserialize<MSG_GC_CHARACTER_LIST>(stream);
            Parser.Parse(MSG_GC_CHARACTER_LIST);
        }
        public object Deserialize_MSG_GC_CHARACTER_LIST(MemoryStream stream)
        {
            return ProtoBuf.Serializer.Deserialize<MSG_GC_CHARACTER_LIST>(stream);
        }

        public void OnResponse_MSG_GC_CREATE_CHARACTER(MemoryStream stream)
        {
            MSG_GC_CREATE_CHARACTER MSG_GC_CREATE_CHARACTER = ProtoBuf.Serializer.Deserialize<MSG_GC_CREATE_CHARACTER>(stream);
            Parser.Parse(MSG_GC_CREATE_CHARACTER);
        }
        public object Deserialize_MSG_GC_CREATE_CHARACTER(MemoryStream stream)
        {
            return ProtoBuf.Serializer.Deserialize<MSG_GC_CREATE_CHARACTER>(stream);
        }

        public void OnResponse_MSG_GC_TO_ZONE(MemoryStream stream)
        {
            MSG_GC_TO_ZONE MSG_GC_TO_ZONE = ProtoBuf.Serializer.Deserialize<MSG_GC_TO_ZONE>(stream);
            Parser.Parse(MSG_GC_TO_ZONE);
        }
        public object Deserialize_MSG_GC_TO_ZONE(MemoryStream stream)
        {
            return ProtoBuf.Serializer.Deserialize<MSG_GC_TO_ZONE>(stream);
        }

        public void OnResponse_MSG_GC_HEARTBEAT(MemoryStream stream)
        {
            MSG_GC_HEARTBEAT MSG_GC_HEARTBEAT = ProtoBuf.Serializer.Deserialize<MSG_GC_HEARTBEAT>(stream);
            Parser.Parse(MSG_GC_HEARTBEAT);
        }
        public object Deserialize_MSG_GC_HEARTBEAT(MemoryStream stream)
        {
            return ProtoBuf.Serializer.Deserialize<MSG_GC_HEARTBEAT>(stream);
        }

        public void OnResponse_MSG_GC_ENTER_ZONE(MemoryStream stream)
        {
            MSG_GC_ENTER_ZONE MSG_GC_ENTER_ZONE = ProtoBuf.Serializer.Deserialize<MSG_GC_ENTER_ZONE>(stream);
            Parser.Parse(MSG_GC_ENTER_ZONE);
        }
        public object Deserialize_MSG_GC_ENTER_ZONE(MemoryStream stream)
        {
            return ProtoBuf.Serializer.Deserialize<MSG_GC_ENTER_ZONE>(stream);
        }

        public void OnResponse_MSG_GC_ENTER_WORLD(MemoryStream stream)
        {
            MSG_GC_ENTER_WORLD MSG_GC_ENTER_WORLD = ProtoBuf.Serializer.Deserialize<MSG_GC_ENTER_WORLD>(stream);
            Parser.Parse(MSG_GC_ENTER_WORLD);
        }
        public object Deserialize_MSG_GC_ENTER_WORLD(MemoryStream stream)
        {
            return ProtoBuf.Serializer.Deserialize<MSG_GC_ENTER_WORLD>(stream);
        }

        public void OnResponse_MSG_GC_TIME_SYNC(MemoryStream stream)
        {
            MSG_GC_TIME_SYNC MSG_GC_TIME_SYNC = ProtoBuf.Serializer.Deserialize<MSG_GC_TIME_SYNC>(stream);
            Parser.Parse(MSG_GC_TIME_SYNC);
        }
        public object Deserialize_MSG_GC_TIME_SYNC(MemoryStream stream)
        {
            return ProtoBuf.Serializer.Deserialize<MSG_GC_TIME_SYNC>(stream);
        }

        public void OnResponse_MSG_ZGC_ERROR_CODE(MemoryStream stream)
        {
            MSG_ZGC_ERROR_CODE MSG_ZGC_ERROR_CODE = ProtoBuf.Serializer.Deserialize<MSG_ZGC_ERROR_CODE>(stream);
            Parser.Parse(MSG_ZGC_ERROR_CODE);
        }
        public object Deserialize_MSG_ZGC_ERROR_CODE(MemoryStream stream)
        {
            return ProtoBuf.Serializer.Deserialize<MSG_ZGC_ERROR_CODE>(stream);
        }

        public void OnResponse_MSG_ZGC_NPC_INFO(MemoryStream stream)
        {
            MSG_ZGC_NPC_INFO MSG_ZGC_NPC_INFO = ProtoBuf.Serializer.Deserialize<MSG_ZGC_NPC_INFO>(stream);
            Parser.Parse(MSG_ZGC_NPC_INFO);
        }
        public object Deserialize_MSG_ZGC_NPC_INFO(MemoryStream stream)
        {
            return ProtoBuf.Serializer.Deserialize<MSG_ZGC_NPC_INFO>(stream);
        }

        public void OnResponse_MSG_ZGC_GOODS_INFO(MemoryStream stream)
        {
            MSG_ZGC_GOODS_INFO MSG_ZGC_GOODS_INFO = ProtoBuf.Serializer.Deserialize<MSG_ZGC_GOODS_INFO>(stream);
            Parser.Parse(MSG_ZGC_GOODS_INFO);
        }
        public object Deserialize_MSG_ZGC_GOODS_INFO(MemoryStream stream)
        {
            return ProtoBuf.Serializer.Deserialize<MSG_ZGC_GOODS_INFO>(stream);
        }

        public void OnResponse_MSG_ZGC_INTERACTION(MemoryStream stream)
        {
            MSG_ZGC_INTERACTION MSG_ZGC_INTERACTION = ProtoBuf.Serializer.Deserialize<MSG_ZGC_INTERACTION>(stream);
            Parser.Parse(MSG_ZGC_INTERACTION);
        }
        public object Deserialize_MSG_ZGC_INTERACTION(MemoryStream stream)
        {
            return ProtoBuf.Serializer.Deserialize<MSG_ZGC_INTERACTION>(stream);
        }

        public void OnResponse_MSG_GC_RECONNECT_LOGIN(MemoryStream stream)
        {
            MSG_GC_RECONNECT_LOGIN MSG_GC_RECONNECT_LOGIN = ProtoBuf.Serializer.Deserialize<MSG_GC_RECONNECT_LOGIN>(stream);
            Parser.Parse(MSG_GC_RECONNECT_LOGIN);
        }
        public object Deserialize_MSG_GC_RECONNECT_LOGIN(MemoryStream stream)
        {
            return ProtoBuf.Serializer.Deserialize<MSG_GC_RECONNECT_LOGIN>(stream);
        }

        public void OnResponse_MSG_ZGC_LOGIN_FREEZE(MemoryStream stream)
        {
            MSG_ZGC_LOGIN_FREEZE MSG_ZGC_LOGIN_FREEZE = ProtoBuf.Serializer.Deserialize<MSG_ZGC_LOGIN_FREEZE>(stream);
            Parser.Parse(MSG_ZGC_LOGIN_FREEZE);
        }
        public object Deserialize_MSG_ZGC_LOGIN_FREEZE(MemoryStream stream)
        {
            return ProtoBuf.Serializer.Deserialize<MSG_ZGC_LOGIN_FREEZE>(stream);
        }

        public void OnResponse_MSG_GC_BLOWFISHKEY(MemoryStream stream)
        {
            MSG_GC_BLOWFISHKEY MSG_GC_BLOWFISHKEY = ProtoBuf.Serializer.Deserialize<MSG_GC_BLOWFISHKEY>(stream);
            Parser.Parse(MSG_GC_BLOWFISHKEY);
        }
        public object Deserialize_MSG_GC_BLOWFISHKEY(MemoryStream stream)
        {
            return ProtoBuf.Serializer.Deserialize<MSG_GC_BLOWFISHKEY>(stream);
        }

        public void OnResponse_MSG_ZGC_SUGGEST(MemoryStream stream)
        {
            MSG_ZGC_SUGGEST MSG_ZGC_SUGGEST = ProtoBuf.Serializer.Deserialize<MSG_ZGC_SUGGEST>(stream);
            Parser.Parse(MSG_ZGC_SUGGEST);
        }
        public object Deserialize_MSG_ZGC_SUGGEST(MemoryStream stream)
        {
            return ProtoBuf.Serializer.Deserialize<MSG_ZGC_SUGGEST>(stream);
        }

        public void OnResponse_MSG_ZGC_FIGHTING_COUNT(MemoryStream stream)
        {
            MSG_ZGC_FIGHTING_COUNT MSG_ZGC_FIGHTING_COUNT = ProtoBuf.Serializer.Deserialize<MSG_ZGC_FIGHTING_COUNT>(stream);
            Parser.Parse(MSG_ZGC_FIGHTING_COUNT);
        }
        public object Deserialize_MSG_ZGC_FIGHTING_COUNT(MemoryStream stream)
        {
            return ProtoBuf.Serializer.Deserialize<MSG_ZGC_FIGHTING_COUNT>(stream);
        }

        public void OnResponse_MSG_ZGC_FIRST_ADD_EXP(MemoryStream stream)
        {
            MSG_ZGC_FIRST_ADD_EXP MSG_ZGC_FIRST_ADD_EXP = ProtoBuf.Serializer.Deserialize<MSG_ZGC_FIRST_ADD_EXP>(stream);
            Parser.Parse(MSG_ZGC_FIRST_ADD_EXP);
        }
        public object Deserialize_MSG_ZGC_FIRST_ADD_EXP(MemoryStream stream)
        {
            return ProtoBuf.Serializer.Deserialize<MSG_ZGC_FIRST_ADD_EXP>(stream);
        }

        public void OnResponse_MSG_ZGC_CHANGE_CHANNEL(MemoryStream stream)
        {
            MSG_ZGC_CHANGE_CHANNEL MSG_ZGC_CHANGE_CHANNEL = ProtoBuf.Serializer.Deserialize<MSG_ZGC_CHANGE_CHANNEL>(stream);
            Parser.Parse(MSG_ZGC_CHANGE_CHANNEL);
        }
        public object Deserialize_MSG_ZGC_CHANGE_CHANNEL(MemoryStream stream)
        {
            return ProtoBuf.Serializer.Deserialize<MSG_ZGC_CHANGE_CHANNEL>(stream);
        }

        public void OnResponse_MSG_GC_FieldObject_MOVE(MemoryStream stream)
        {
            MSG_GC_FieldObject_MOVE MSG_GC_FieldObject_MOVE = ProtoBuf.Serializer.Deserialize<MSG_GC_FieldObject_MOVE>(stream);
            Parser.Parse(MSG_GC_FieldObject_MOVE);
        }
        public object Deserialize_MSG_GC_FieldObject_MOVE(MemoryStream stream)
        {
            return ProtoBuf.Serializer.Deserialize<MSG_GC_FieldObject_MOVE>(stream);
        }

        public void OnResponse_MSG_ZGC_CHARACTER_STOP(MemoryStream stream)
        {
            MSG_ZGC_CHARACTER_STOP MSG_ZGC_CHARACTER_STOP = ProtoBuf.Serializer.Deserialize<MSG_ZGC_CHARACTER_STOP>(stream);
            Parser.Parse(MSG_ZGC_CHARACTER_STOP);
        }
        public object Deserialize_MSG_ZGC_CHARACTER_STOP(MemoryStream stream)
        {
            return ProtoBuf.Serializer.Deserialize<MSG_ZGC_CHARACTER_STOP>(stream);
        }

        public void OnResponse_MSG_GC_CHAR_SIMPLE_INFO(MemoryStream stream)
        {
            MSG_GC_CHAR_SIMPLE_INFO MSG_GC_CHAR_SIMPLE_INFO = ProtoBuf.Serializer.Deserialize<MSG_GC_CHAR_SIMPLE_INFO>(stream);
            Parser.Parse(MSG_GC_CHAR_SIMPLE_INFO);
        }
        public object Deserialize_MSG_GC_CHAR_SIMPLE_INFO(MemoryStream stream)
        {
            return ProtoBuf.Serializer.Deserialize<MSG_GC_CHAR_SIMPLE_INFO>(stream);
        }

        public void OnResponse_MSG_GC_BROADCAST_INFO(MemoryStream stream)
        {
            MSG_GC_BROADCAST_INFO MSG_GC_BROADCAST_INFO = ProtoBuf.Serializer.Deserialize<MSG_GC_BROADCAST_INFO>(stream);
            Parser.Parse(MSG_GC_BROADCAST_INFO);
        }
        public object Deserialize_MSG_GC_BROADCAST_INFO(MemoryStream stream)
        {
            return ProtoBuf.Serializer.Deserialize<MSG_GC_BROADCAST_INFO>(stream);
        }

        public void OnResponse_MSG_GC_BROADCAST_LIST(MemoryStream stream)
        {
            MSG_GC_BROADCAST_LIST MSG_GC_BROADCAST_LIST = ProtoBuf.Serializer.Deserialize<MSG_GC_BROADCAST_LIST>(stream);
            Parser.Parse(MSG_GC_BROADCAST_LIST);
        }
        public object Deserialize_MSG_GC_BROADCAST_LIST(MemoryStream stream)
        {
            return ProtoBuf.Serializer.Deserialize<MSG_GC_BROADCAST_LIST>(stream);
        }

        public void OnResponse_MSG_GC_CHARACTER_ENTER_LIST(MemoryStream stream)
        {
            MSG_GC_CHARACTER_ENTER_LIST MSG_GC_CHARACTER_ENTER_LIST = ProtoBuf.Serializer.Deserialize<MSG_GC_CHARACTER_ENTER_LIST>(stream);
            Parser.Parse(MSG_GC_CHARACTER_ENTER_LIST);
        }
        public object Deserialize_MSG_GC_CHARACTER_ENTER_LIST(MemoryStream stream)
        {
            return ProtoBuf.Serializer.Deserialize<MSG_GC_CHARACTER_ENTER_LIST>(stream);
        }

        public void OnResponse_MSG_GC_CHARACTER_LEAVE(MemoryStream stream)
        {
            MSG_GC_CHARACTER_LEAVE MSG_GC_CHARACTER_LEAVE = ProtoBuf.Serializer.Deserialize<MSG_GC_CHARACTER_LEAVE>(stream);
            Parser.Parse(MSG_GC_CHARACTER_LEAVE);
        }
        public object Deserialize_MSG_GC_CHARACTER_LEAVE(MemoryStream stream)
        {
            return ProtoBuf.Serializer.Deserialize<MSG_GC_CHARACTER_LEAVE>(stream);
        }

        public void OnResponse_MSG_ZGC_PET_SIMPLE_INFO(MemoryStream stream)
        {
            MSG_ZGC_PET_SIMPLE_INFO MSG_ZGC_PET_SIMPLE_INFO = ProtoBuf.Serializer.Deserialize<MSG_ZGC_PET_SIMPLE_INFO>(stream);
            Parser.Parse(MSG_ZGC_PET_SIMPLE_INFO);
        }
        public object Deserialize_MSG_ZGC_PET_SIMPLE_INFO(MemoryStream stream)
        {
            return ProtoBuf.Serializer.Deserialize<MSG_ZGC_PET_SIMPLE_INFO>(stream);
        }

        public void OnResponse_MSG_GC_PET_ENTER_LIST(MemoryStream stream)
        {
            MSG_GC_PET_ENTER_LIST MSG_GC_PET_ENTER_LIST = ProtoBuf.Serializer.Deserialize<MSG_GC_PET_ENTER_LIST>(stream);
            Parser.Parse(MSG_GC_PET_ENTER_LIST);
        }
        public object Deserialize_MSG_GC_PET_ENTER_LIST(MemoryStream stream)
        {
            return ProtoBuf.Serializer.Deserialize<MSG_GC_PET_ENTER_LIST>(stream);
        }

        public void OnResponse_MSG_ZGC_PET_LEAVE(MemoryStream stream)
        {
            MSG_ZGC_PET_LEAVE MSG_ZGC_PET_LEAVE = ProtoBuf.Serializer.Deserialize<MSG_ZGC_PET_LEAVE>(stream);
            Parser.Parse(MSG_ZGC_PET_LEAVE);
        }
        public object Deserialize_MSG_ZGC_PET_LEAVE(MemoryStream stream)
        {
            return ProtoBuf.Serializer.Deserialize<MSG_ZGC_PET_LEAVE>(stream);
        }

        public void OnResponse_MSG_ZGC_NPC_MOVE(MemoryStream stream)
        {
            MSG_ZGC_NPC_MOVE MSG_ZGC_NPC_MOVE = ProtoBuf.Serializer.Deserialize<MSG_ZGC_NPC_MOVE>(stream);
            Parser.Parse(MSG_ZGC_NPC_MOVE);
        }
        public object Deserialize_MSG_ZGC_NPC_MOVE(MemoryStream stream)
        {
            return ProtoBuf.Serializer.Deserialize<MSG_ZGC_NPC_MOVE>(stream);
        }

        public void OnResponse_MSG_ZGC_NPC_LEAVE(MemoryStream stream)
        {
            MSG_ZGC_NPC_LEAVE MSG_ZGC_NPC_LEAVE = ProtoBuf.Serializer.Deserialize<MSG_ZGC_NPC_LEAVE>(stream);
            Parser.Parse(MSG_ZGC_NPC_LEAVE);
        }
        public object Deserialize_MSG_ZGC_NPC_LEAVE(MemoryStream stream)
        {
            return ProtoBuf.Serializer.Deserialize<MSG_ZGC_NPC_LEAVE>(stream);
        }

        public void OnResponse_MSG_ZGC_NPC_SIMPLE_INFO(MemoryStream stream)
        {
            MSG_ZGC_NPC_SIMPLE_INFO MSG_ZGC_NPC_SIMPLE_INFO = ProtoBuf.Serializer.Deserialize<MSG_ZGC_NPC_SIMPLE_INFO>(stream);
            Parser.Parse(MSG_ZGC_NPC_SIMPLE_INFO);
        }
        public object Deserialize_MSG_ZGC_NPC_SIMPLE_INFO(MemoryStream stream)
        {
            return ProtoBuf.Serializer.Deserialize<MSG_ZGC_NPC_SIMPLE_INFO>(stream);
        }

        public void OnResponse_MSG_GC_NPC_ENTER_LIST(MemoryStream stream)
        {
            MSG_GC_NPC_ENTER_LIST MSG_GC_NPC_ENTER_LIST = ProtoBuf.Serializer.Deserialize<MSG_GC_NPC_ENTER_LIST>(stream);
            Parser.Parse(MSG_GC_NPC_ENTER_LIST);
        }
        public object Deserialize_MSG_GC_NPC_ENTER_LIST(MemoryStream stream)
        {
            return ProtoBuf.Serializer.Deserialize<MSG_GC_NPC_ENTER_LIST>(stream);
        }

        public void OnResponse_CURRENCY(MemoryStream stream)
        {
            CURRENCY CURRENCY = ProtoBuf.Serializer.Deserialize<CURRENCY>(stream);
            Parser.Parse(CURRENCY);
        }
        public object Deserialize_CURRENCY(MemoryStream stream)
        {
            return ProtoBuf.Serializer.Deserialize<CURRENCY>(stream);
        }

        public void OnResponse_MSG_ZGC_SYNC_CURRENCIES(MemoryStream stream)
        {
            MSG_ZGC_SYNC_CURRENCIES MSG_ZGC_SYNC_CURRENCIES = ProtoBuf.Serializer.Deserialize<MSG_ZGC_SYNC_CURRENCIES>(stream);
            Parser.Parse(MSG_ZGC_SYNC_CURRENCIES);
        }
        public object Deserialize_MSG_ZGC_SYNC_CURRENCIES(MemoryStream stream)
        {
            return ProtoBuf.Serializer.Deserialize<MSG_ZGC_SYNC_CURRENCIES>(stream);
        }

        public void OnResponse_ZGC_COUNTER(MemoryStream stream)
        {
            ZGC_COUNTER ZGC_COUNTER = ProtoBuf.Serializer.Deserialize<ZGC_COUNTER>(stream);
            Parser.Parse(ZGC_COUNTER);
        }
        public object Deserialize_ZGC_COUNTER(MemoryStream stream)
        {
            return ProtoBuf.Serializer.Deserialize<ZGC_COUNTER>(stream);
        }

        public void OnResponse_MSG_ZGC_COUNTER_INFO(MemoryStream stream)
        {
            MSG_ZGC_COUNTER_INFO MSG_ZGC_COUNTER_INFO = ProtoBuf.Serializer.Deserialize<MSG_ZGC_COUNTER_INFO>(stream);
            Parser.Parse(MSG_ZGC_COUNTER_INFO);
        }
        public object Deserialize_MSG_ZGC_COUNTER_INFO(MemoryStream stream)
        {
            return ProtoBuf.Serializer.Deserialize<MSG_ZGC_COUNTER_INFO>(stream);
        }

        public void OnResponse_MSG_ZGC_PLAYER_LEVEL(MemoryStream stream)
        {
            MSG_ZGC_PLAYER_LEVEL MSG_ZGC_PLAYER_LEVEL = ProtoBuf.Serializer.Deserialize<MSG_ZGC_PLAYER_LEVEL>(stream);
            Parser.Parse(MSG_ZGC_PLAYER_LEVEL);
        }
        public object Deserialize_MSG_ZGC_PLAYER_LEVEL(MemoryStream stream)
        {
            return ProtoBuf.Serializer.Deserialize<MSG_ZGC_PLAYER_LEVEL>(stream);
        }

        public void OnResponse_MSG_ZGC_KNAPSACK_SYNC(MemoryStream stream)
        {
            MSG_ZGC_KNAPSACK_SYNC MSG_ZGC_KNAPSACK_SYNC = ProtoBuf.Serializer.Deserialize<MSG_ZGC_KNAPSACK_SYNC>(stream);
            Parser.Parse(MSG_ZGC_KNAPSACK_SYNC);
        }
        public object Deserialize_MSG_ZGC_KNAPSACK_SYNC(MemoryStream stream)
        {
            return ProtoBuf.Serializer.Deserialize<MSG_ZGC_KNAPSACK_SYNC>(stream);
        }

        public void OnResponse_MSG_ZGC_KNAPSACK_UPDATE(MemoryStream stream)
        {
            MSG_ZGC_KNAPSACK_UPDATE MSG_ZGC_KNAPSACK_UPDATE = ProtoBuf.Serializer.Deserialize<MSG_ZGC_KNAPSACK_UPDATE>(stream);
            Parser.Parse(MSG_ZGC_KNAPSACK_UPDATE);
        }
        public object Deserialize_MSG_ZGC_KNAPSACK_UPDATE(MemoryStream stream)
        {
            return ProtoBuf.Serializer.Deserialize<MSG_ZGC_KNAPSACK_UPDATE>(stream);
        }

        public void OnResponse_MSG_ZGC_ITEM_USE(MemoryStream stream)
        {
            MSG_ZGC_ITEM_USE MSG_ZGC_ITEM_USE = ProtoBuf.Serializer.Deserialize<MSG_ZGC_ITEM_USE>(stream);
            Parser.Parse(MSG_ZGC_ITEM_USE);
        }
        public object Deserialize_MSG_ZGC_ITEM_USE(MemoryStream stream)
        {
            return ProtoBuf.Serializer.Deserialize<MSG_ZGC_ITEM_USE>(stream);
        }

        public void OnResponse_MSG_ZGC_ITEM_SELL(MemoryStream stream)
        {
            MSG_ZGC_ITEM_SELL MSG_ZGC_ITEM_SELL = ProtoBuf.Serializer.Deserialize<MSG_ZGC_ITEM_SELL>(stream);
            Parser.Parse(MSG_ZGC_ITEM_SELL);
        }
        public object Deserialize_MSG_ZGC_ITEM_SELL(MemoryStream stream)
        {
            return ProtoBuf.Serializer.Deserialize<MSG_ZGC_ITEM_SELL>(stream);
        }

        public void OnResponse_MSG_ZGC_EQUIP_FACEFRAME(MemoryStream stream)
        {
            MSG_ZGC_EQUIP_FACEFRAME MSG_ZGC_EQUIP_FACEFRAME = ProtoBuf.Serializer.Deserialize<MSG_ZGC_EQUIP_FACEFRAME>(stream);
            Parser.Parse(MSG_ZGC_EQUIP_FACEFRAME);
        }
        public object Deserialize_MSG_ZGC_EQUIP_FACEFRAME(MemoryStream stream)
        {
            return ProtoBuf.Serializer.Deserialize<MSG_ZGC_EQUIP_FACEFRAME>(stream);
        }

        public void OnResponse_MSG_ZGC_ITEM_BUY(MemoryStream stream)
        {
            MSG_ZGC_ITEM_BUY MSG_ZGC_ITEM_BUY = ProtoBuf.Serializer.Deserialize<MSG_ZGC_ITEM_BUY>(stream);
            Parser.Parse(MSG_ZGC_ITEM_BUY);
        }
        public object Deserialize_MSG_ZGC_ITEM_BUY(MemoryStream stream)
        {
            return ProtoBuf.Serializer.Deserialize<MSG_ZGC_ITEM_BUY>(stream);
        }

        public void OnResponse_REWARD_ITEM_INFO(MemoryStream stream)
        {
            REWARD_ITEM_INFO REWARD_ITEM_INFO = ProtoBuf.Serializer.Deserialize<REWARD_ITEM_INFO>(stream);
            Parser.Parse(REWARD_ITEM_INFO);
        }
        public object Deserialize_REWARD_ITEM_INFO(MemoryStream stream)
        {
            return ProtoBuf.Serializer.Deserialize<REWARD_ITEM_INFO>(stream);
        }

        public void OnResponse_MSG_ZGC_USE_FIREWORKS(MemoryStream stream)
        {
            MSG_ZGC_USE_FIREWORKS MSG_ZGC_USE_FIREWORKS = ProtoBuf.Serializer.Deserialize<MSG_ZGC_USE_FIREWORKS>(stream);
            Parser.Parse(MSG_ZGC_USE_FIREWORKS);
        }
        public object Deserialize_MSG_ZGC_USE_FIREWORKS(MemoryStream stream)
        {
            return ProtoBuf.Serializer.Deserialize<MSG_ZGC_USE_FIREWORKS>(stream);
        }

        public void OnResponse_ITEM(MemoryStream stream)
        {
            ITEM ITEM = ProtoBuf.Serializer.Deserialize<ITEM>(stream);
            Parser.Parse(ITEM);
        }
        public object Deserialize_ITEM(MemoryStream stream)
        {
            return ProtoBuf.Serializer.Deserialize<ITEM>(stream);
        }

        public void OnResponse_MSG_ZGC_EMAIL_REMIND(MemoryStream stream)
        {
            MSG_ZGC_EMAIL_REMIND MSG_ZGC_EMAIL_REMIND = ProtoBuf.Serializer.Deserialize<MSG_ZGC_EMAIL_REMIND>(stream);
            Parser.Parse(MSG_ZGC_EMAIL_REMIND);
        }
        public object Deserialize_MSG_ZGC_EMAIL_REMIND(MemoryStream stream)
        {
            return ProtoBuf.Serializer.Deserialize<MSG_ZGC_EMAIL_REMIND>(stream);
        }

        public void OnResponse_MSG_ZGC_EMAIL_OPENE_BOX(MemoryStream stream)
        {
            MSG_ZGC_EMAIL_OPENE_BOX MSG_ZGC_EMAIL_OPENE_BOX = ProtoBuf.Serializer.Deserialize<MSG_ZGC_EMAIL_OPENE_BOX>(stream);
            Parser.Parse(MSG_ZGC_EMAIL_OPENE_BOX);
        }
        public object Deserialize_MSG_ZGC_EMAIL_OPENE_BOX(MemoryStream stream)
        {
            return ProtoBuf.Serializer.Deserialize<MSG_ZGC_EMAIL_OPENE_BOX>(stream);
        }

        public void OnResponse_MSG_ZGC_EMAIL_ITEM(MemoryStream stream)
        {
            MSG_ZGC_EMAIL_ITEM MSG_ZGC_EMAIL_ITEM = ProtoBuf.Serializer.Deserialize<MSG_ZGC_EMAIL_ITEM>(stream);
            Parser.Parse(MSG_ZGC_EMAIL_ITEM);
        }
        public object Deserialize_MSG_ZGC_EMAIL_ITEM(MemoryStream stream)
        {
            return ProtoBuf.Serializer.Deserialize<MSG_ZGC_EMAIL_ITEM>(stream);
        }

        public void OnResponse_MSG_ZGC_EMAIL_READ(MemoryStream stream)
        {
            MSG_ZGC_EMAIL_READ MSG_ZGC_EMAIL_READ = ProtoBuf.Serializer.Deserialize<MSG_ZGC_EMAIL_READ>(stream);
            Parser.Parse(MSG_ZGC_EMAIL_READ);
        }
        public object Deserialize_MSG_ZGC_EMAIL_READ(MemoryStream stream)
        {
            return ProtoBuf.Serializer.Deserialize<MSG_ZGC_EMAIL_READ>(stream);
        }

        public void OnResponse_MSG_ZGC_ATTACHMENT_PICKUP(MemoryStream stream)
        {
            MSG_ZGC_ATTACHMENT_PICKUP MSG_ZGC_ATTACHMENT_PICKUP = ProtoBuf.Serializer.Deserialize<MSG_ZGC_ATTACHMENT_PICKUP>(stream);
            Parser.Parse(MSG_ZGC_ATTACHMENT_PICKUP);
        }
        public object Deserialize_MSG_ZGC_ATTACHMENT_PICKUP(MemoryStream stream)
        {
            return ProtoBuf.Serializer.Deserialize<MSG_ZGC_ATTACHMENT_PICKUP>(stream);
        }

        public void OnResponse_MSG_ZGC_SHOP_ITEM(MemoryStream stream)
        {
            MSG_ZGC_SHOP_ITEM MSG_ZGC_SHOP_ITEM = ProtoBuf.Serializer.Deserialize<MSG_ZGC_SHOP_ITEM>(stream);
            Parser.Parse(MSG_ZGC_SHOP_ITEM);
        }
        public object Deserialize_MSG_ZGC_SHOP_ITEM(MemoryStream stream)
        {
            return ProtoBuf.Serializer.Deserialize<MSG_ZGC_SHOP_ITEM>(stream);
        }

        public void OnResponse_MSG_ZGC_SHOP_LIST(MemoryStream stream)
        {
            MSG_ZGC_SHOP_LIST MSG_ZGC_SHOP_LIST = ProtoBuf.Serializer.Deserialize<MSG_ZGC_SHOP_LIST>(stream);
            Parser.Parse(MSG_ZGC_SHOP_LIST);
        }
        public object Deserialize_MSG_ZGC_SHOP_LIST(MemoryStream stream)
        {
            return ProtoBuf.Serializer.Deserialize<MSG_ZGC_SHOP_LIST>(stream);
        }

        public void OnResponse_MSG_ZGC_SHOP_BUY_RESULT(MemoryStream stream)
        {
            MSG_ZGC_SHOP_BUY_RESULT MSG_ZGC_SHOP_BUY_RESULT = ProtoBuf.Serializer.Deserialize<MSG_ZGC_SHOP_BUY_RESULT>(stream);
            Parser.Parse(MSG_ZGC_SHOP_BUY_RESULT);
        }
        public object Deserialize_MSG_ZGC_SHOP_BUY_RESULT(MemoryStream stream)
        {
            return ProtoBuf.Serializer.Deserialize<MSG_ZGC_SHOP_BUY_RESULT>(stream);
        }

        public void OnResponse_MSG_ZGC_SHOP_GET_SSR(MemoryStream stream)
        {
            MSG_ZGC_SHOP_GET_SSR MSG_ZGC_SHOP_GET_SSR = ProtoBuf.Serializer.Deserialize<MSG_ZGC_SHOP_GET_SSR>(stream);
            Parser.Parse(MSG_ZGC_SHOP_GET_SSR);
        }
        public object Deserialize_MSG_ZGC_SHOP_GET_SSR(MemoryStream stream)
        {
            return ProtoBuf.Serializer.Deserialize<MSG_ZGC_SHOP_GET_SSR>(stream);
        }

        public void OnResponse_MSG_ZGC_CONVERT_FISH_COIN(MemoryStream stream)
        {
            MSG_ZGC_CONVERT_FISH_COIN MSG_ZGC_CONVERT_FISH_COIN = ProtoBuf.Serializer.Deserialize<MSG_ZGC_CONVERT_FISH_COIN>(stream);
            Parser.Parse(MSG_ZGC_CONVERT_FISH_COIN);
        }
        public object Deserialize_MSG_ZGC_CONVERT_FISH_COIN(MemoryStream stream)
        {
            return ProtoBuf.Serializer.Deserialize<MSG_ZGC_CONVERT_FISH_COIN>(stream);
        }

        public void OnResponse_MSG_ZGC_RECHARGE_HISTORY(MemoryStream stream)
        {
            MSG_ZGC_RECHARGE_HISTORY MSG_ZGC_RECHARGE_HISTORY = ProtoBuf.Serializer.Deserialize<MSG_ZGC_RECHARGE_HISTORY>(stream);
            Parser.Parse(MSG_ZGC_RECHARGE_HISTORY);
        }
        public object Deserialize_MSG_ZGC_RECHARGE_HISTORY(MemoryStream stream)
        {
            return ProtoBuf.Serializer.Deserialize<MSG_ZGC_RECHARGE_HISTORY>(stream);
        }

        public void OnResponse_MSG_ZGC_RECHARGE_INFO(MemoryStream stream)
        {
            MSG_ZGC_RECHARGE_INFO MSG_ZGC_RECHARGE_INFO = ProtoBuf.Serializer.Deserialize<MSG_ZGC_RECHARGE_INFO>(stream);
            Parser.Parse(MSG_ZGC_RECHARGE_INFO);
        }
        public object Deserialize_MSG_ZGC_RECHARGE_INFO(MemoryStream stream)
        {
            return ProtoBuf.Serializer.Deserialize<MSG_ZGC_RECHARGE_INFO>(stream);
        }

        public void OnResponse_MSG_ZGC_RECHARGE_MANAGER(MemoryStream stream)
        {
            MSG_ZGC_RECHARGE_MANAGER MSG_ZGC_RECHARGE_MANAGER = ProtoBuf.Serializer.Deserialize<MSG_ZGC_RECHARGE_MANAGER>(stream);
            Parser.Parse(MSG_ZGC_RECHARGE_MANAGER);
        }
        public object Deserialize_MSG_ZGC_RECHARGE_MANAGER(MemoryStream stream)
        {
            return ProtoBuf.Serializer.Deserialize<MSG_ZGC_RECHARGE_MANAGER>(stream);
        }

        public void OnResponse_PLAYER_BASE_INFO(MemoryStream stream)
        {
            PLAYER_BASE_INFO PLAYER_BASE_INFO = ProtoBuf.Serializer.Deserialize<PLAYER_BASE_INFO>(stream);
            Parser.Parse(PLAYER_BASE_INFO);
        }
        public object Deserialize_PLAYER_BASE_INFO(MemoryStream stream)
        {
            return ProtoBuf.Serializer.Deserialize<PLAYER_BASE_INFO>(stream);
        }

        public void OnResponse_MSG_ZGC_FRIEND_SEARCH(MemoryStream stream)
        {
            MSG_ZGC_FRIEND_SEARCH MSG_ZGC_FRIEND_SEARCH = ProtoBuf.Serializer.Deserialize<MSG_ZGC_FRIEND_SEARCH>(stream);
            Parser.Parse(MSG_ZGC_FRIEND_SEARCH);
        }
        public object Deserialize_MSG_ZGC_FRIEND_SEARCH(MemoryStream stream)
        {
            return ProtoBuf.Serializer.Deserialize<MSG_ZGC_FRIEND_SEARCH>(stream);
        }

        public void OnResponse_MSG_ZGC_FRIEND_ADD_REQUEST(MemoryStream stream)
        {
            MSG_ZGC_FRIEND_ADD_REQUEST MSG_ZGC_FRIEND_ADD_REQUEST = ProtoBuf.Serializer.Deserialize<MSG_ZGC_FRIEND_ADD_REQUEST>(stream);
            Parser.Parse(MSG_ZGC_FRIEND_ADD_REQUEST);
        }
        public object Deserialize_MSG_ZGC_FRIEND_ADD_REQUEST(MemoryStream stream)
        {
            return ProtoBuf.Serializer.Deserialize<MSG_ZGC_FRIEND_ADD_REQUEST>(stream);
        }

        public void OnResponse_MSG_ZGC_FRIEND_ADD_RESPONSE(MemoryStream stream)
        {
            MSG_ZGC_FRIEND_ADD_RESPONSE MSG_ZGC_FRIEND_ADD_RESPONSE = ProtoBuf.Serializer.Deserialize<MSG_ZGC_FRIEND_ADD_RESPONSE>(stream);
            Parser.Parse(MSG_ZGC_FRIEND_ADD_RESPONSE);
        }
        public object Deserialize_MSG_ZGC_FRIEND_ADD_RESPONSE(MemoryStream stream)
        {
            return ProtoBuf.Serializer.Deserialize<MSG_ZGC_FRIEND_ADD_RESPONSE>(stream);
        }

        public void OnResponse_MSG_ZGC_FRIEND_DELETE(MemoryStream stream)
        {
            MSG_ZGC_FRIEND_DELETE MSG_ZGC_FRIEND_DELETE = ProtoBuf.Serializer.Deserialize<MSG_ZGC_FRIEND_DELETE>(stream);
            Parser.Parse(MSG_ZGC_FRIEND_DELETE);
        }
        public object Deserialize_MSG_ZGC_FRIEND_DELETE(MemoryStream stream)
        {
            return ProtoBuf.Serializer.Deserialize<MSG_ZGC_FRIEND_DELETE>(stream);
        }

        public void OnResponse_MSG_ZGC_FRIEND_LIST(MemoryStream stream)
        {
            MSG_ZGC_FRIEND_LIST MSG_ZGC_FRIEND_LIST = ProtoBuf.Serializer.Deserialize<MSG_ZGC_FRIEND_LIST>(stream);
            Parser.Parse(MSG_ZGC_FRIEND_LIST);
        }
        public object Deserialize_MSG_ZGC_FRIEND_LIST(MemoryStream stream)
        {
            return ProtoBuf.Serializer.Deserialize<MSG_ZGC_FRIEND_LIST>(stream);
        }

        public void OnResponse_FRIEND_REQUEST_INFO(MemoryStream stream)
        {
            FRIEND_REQUEST_INFO FRIEND_REQUEST_INFO = ProtoBuf.Serializer.Deserialize<FRIEND_REQUEST_INFO>(stream);
            Parser.Parse(FRIEND_REQUEST_INFO);
        }
        public object Deserialize_FRIEND_REQUEST_INFO(MemoryStream stream)
        {
            return ProtoBuf.Serializer.Deserialize<FRIEND_REQUEST_INFO>(stream);
        }

        public void OnResponse_MSG_ZGC_FRIEND_REQUEST_LIST(MemoryStream stream)
        {
            MSG_ZGC_FRIEND_REQUEST_LIST MSG_ZGC_FRIEND_REQUEST_LIST = ProtoBuf.Serializer.Deserialize<MSG_ZGC_FRIEND_REQUEST_LIST>(stream);
            Parser.Parse(MSG_ZGC_FRIEND_REQUEST_LIST);
        }
        public object Deserialize_MSG_ZGC_FRIEND_REQUEST_LIST(MemoryStream stream)
        {
            return ProtoBuf.Serializer.Deserialize<MSG_ZGC_FRIEND_REQUEST_LIST>(stream);
        }

        public void OnResponse_MSG_ZGC_FRIEND_RECENT_LIST(MemoryStream stream)
        {
            MSG_ZGC_FRIEND_RECENT_LIST MSG_ZGC_FRIEND_RECENT_LIST = ProtoBuf.Serializer.Deserialize<MSG_ZGC_FRIEND_RECENT_LIST>(stream);
            Parser.Parse(MSG_ZGC_FRIEND_RECENT_LIST);
        }
        public object Deserialize_MSG_ZGC_FRIEND_RECENT_LIST(MemoryStream stream)
        {
            return ProtoBuf.Serializer.Deserialize<MSG_ZGC_FRIEND_RECENT_LIST>(stream);
        }

        public void OnResponse_BLACK_INFO(MemoryStream stream)
        {
            BLACK_INFO BLACK_INFO = ProtoBuf.Serializer.Deserialize<BLACK_INFO>(stream);
            Parser.Parse(BLACK_INFO);
        }
        public object Deserialize_BLACK_INFO(MemoryStream stream)
        {
            return ProtoBuf.Serializer.Deserialize<BLACK_INFO>(stream);
        }

        public void OnResponse_MSG_ZGC_FRIEND_BLACK_LIST(MemoryStream stream)
        {
            MSG_ZGC_FRIEND_BLACK_LIST MSG_ZGC_FRIEND_BLACK_LIST = ProtoBuf.Serializer.Deserialize<MSG_ZGC_FRIEND_BLACK_LIST>(stream);
            Parser.Parse(MSG_ZGC_FRIEND_BLACK_LIST);
        }
        public object Deserialize_MSG_ZGC_FRIEND_BLACK_LIST(MemoryStream stream)
        {
            return ProtoBuf.Serializer.Deserialize<MSG_ZGC_FRIEND_BLACK_LIST>(stream);
        }

        public void OnResponse_MSG_ZGC_FRIEND_BLACK_ADD(MemoryStream stream)
        {
            MSG_ZGC_FRIEND_BLACK_ADD MSG_ZGC_FRIEND_BLACK_ADD = ProtoBuf.Serializer.Deserialize<MSG_ZGC_FRIEND_BLACK_ADD>(stream);
            Parser.Parse(MSG_ZGC_FRIEND_BLACK_ADD);
        }
        public object Deserialize_MSG_ZGC_FRIEND_BLACK_ADD(MemoryStream stream)
        {
            return ProtoBuf.Serializer.Deserialize<MSG_ZGC_FRIEND_BLACK_ADD>(stream);
        }

        public void OnResponse_MSG_ZGC_FRIEND_BLACK_DEL(MemoryStream stream)
        {
            MSG_ZGC_FRIEND_BLACK_DEL MSG_ZGC_FRIEND_BLACK_DEL = ProtoBuf.Serializer.Deserialize<MSG_ZGC_FRIEND_BLACK_DEL>(stream);
            Parser.Parse(MSG_ZGC_FRIEND_BLACK_DEL);
        }
        public object Deserialize_MSG_ZGC_FRIEND_BLACK_DEL(MemoryStream stream)
        {
            return ProtoBuf.Serializer.Deserialize<MSG_ZGC_FRIEND_BLACK_DEL>(stream);
        }

        public void OnResponse_FRIEND_SEARCH_INFO(MemoryStream stream)
        {
            FRIEND_SEARCH_INFO FRIEND_SEARCH_INFO = ProtoBuf.Serializer.Deserialize<FRIEND_SEARCH_INFO>(stream);
            Parser.Parse(FRIEND_SEARCH_INFO);
        }
        public object Deserialize_FRIEND_SEARCH_INFO(MemoryStream stream)
        {
            return ProtoBuf.Serializer.Deserialize<FRIEND_SEARCH_INFO>(stream);
        }

        public void OnResponse_MSG_ZGC_FRIEND_RECOMMEND(MemoryStream stream)
        {
            MSG_ZGC_FRIEND_RECOMMEND MSG_ZGC_FRIEND_RECOMMEND = ProtoBuf.Serializer.Deserialize<MSG_ZGC_FRIEND_RECOMMEND>(stream);
            Parser.Parse(MSG_ZGC_FRIEND_RECOMMEND);
        }
        public object Deserialize_MSG_ZGC_FRIEND_RECOMMEND(MemoryStream stream)
        {
            return ProtoBuf.Serializer.Deserialize<MSG_ZGC_FRIEND_RECOMMEND>(stream);
        }

        public void OnResponse_MSG_ZGC_RANKING_FRIEND_LIST(MemoryStream stream)
        {
            MSG_ZGC_RANKING_FRIEND_LIST MSG_ZGC_RANKING_FRIEND_LIST = ProtoBuf.Serializer.Deserialize<MSG_ZGC_RANKING_FRIEND_LIST>(stream);
            Parser.Parse(MSG_ZGC_RANKING_FRIEND_LIST);
        }
        public object Deserialize_MSG_ZGC_RANKING_FRIEND_LIST(MemoryStream stream)
        {
            return ProtoBuf.Serializer.Deserialize<MSG_ZGC_RANKING_FRIEND_LIST>(stream);
        }

        public void OnResponse_MSG_ZGC_RANKING_ALL_LIST(MemoryStream stream)
        {
            MSG_ZGC_RANKING_ALL_LIST MSG_ZGC_RANKING_ALL_LIST = ProtoBuf.Serializer.Deserialize<MSG_ZGC_RANKING_ALL_LIST>(stream);
            Parser.Parse(MSG_ZGC_RANKING_ALL_LIST);
        }
        public object Deserialize_MSG_ZGC_RANKING_ALL_LIST(MemoryStream stream)
        {
            return ProtoBuf.Serializer.Deserialize<MSG_ZGC_RANKING_ALL_LIST>(stream);
        }

        public void OnResponse_MSG_ZGC_RANKING_NEARBY_LIST(MemoryStream stream)
        {
            MSG_ZGC_RANKING_NEARBY_LIST MSG_ZGC_RANKING_NEARBY_LIST = ProtoBuf.Serializer.Deserialize<MSG_ZGC_RANKING_NEARBY_LIST>(stream);
            Parser.Parse(MSG_ZGC_RANKING_NEARBY_LIST);
        }
        public object Deserialize_MSG_ZGC_RANKING_NEARBY_LIST(MemoryStream stream)
        {
            return ProtoBuf.Serializer.Deserialize<MSG_ZGC_RANKING_NEARBY_LIST>(stream);
        }

        public void OnResponse_MSG_ZGC_CREATE_GUILD(MemoryStream stream)
        {
            MSG_ZGC_CREATE_GUILD MSG_ZGC_CREATE_GUILD = ProtoBuf.Serializer.Deserialize<MSG_ZGC_CREATE_GUILD>(stream);
            Parser.Parse(MSG_ZGC_CREATE_GUILD);
        }
        public object Deserialize_MSG_ZGC_CREATE_GUILD(MemoryStream stream)
        {
            return ProtoBuf.Serializer.Deserialize<MSG_ZGC_CREATE_GUILD>(stream);
        }

        public void OnResponse_MSG_ZGC_CHAT_PLAYER_INFO(MemoryStream stream)
        {
            MSG_ZGC_CHAT_PLAYER_INFO MSG_ZGC_CHAT_PLAYER_INFO = ProtoBuf.Serializer.Deserialize<MSG_ZGC_CHAT_PLAYER_INFO>(stream);
            Parser.Parse(MSG_ZGC_CHAT_PLAYER_INFO);
        }
        public object Deserialize_MSG_ZGC_CHAT_PLAYER_INFO(MemoryStream stream)
        {
            return ProtoBuf.Serializer.Deserialize<MSG_ZGC_CHAT_PLAYER_INFO>(stream);
        }

        public void OnResponse_MSG_ZGC_CHAT_WORDS(MemoryStream stream)
        {
            MSG_ZGC_CHAT_WORDS MSG_ZGC_CHAT_WORDS = ProtoBuf.Serializer.Deserialize<MSG_ZGC_CHAT_WORDS>(stream);
            Parser.Parse(MSG_ZGC_CHAT_WORDS);
        }
        public object Deserialize_MSG_ZGC_CHAT_WORDS(MemoryStream stream)
        {
            return ProtoBuf.Serializer.Deserialize<MSG_ZGC_CHAT_WORDS>(stream);
        }

        public void OnResponse_MSG_ZGC_PERSON_CHAT_WORDS(MemoryStream stream)
        {
            MSG_ZGC_PERSON_CHAT_WORDS MSG_ZGC_PERSON_CHAT_WORDS = ProtoBuf.Serializer.Deserialize<MSG_ZGC_PERSON_CHAT_WORDS>(stream);
            Parser.Parse(MSG_ZGC_PERSON_CHAT_WORDS);
        }
        public object Deserialize_MSG_ZGC_PERSON_CHAT_WORDS(MemoryStream stream)
        {
            return ProtoBuf.Serializer.Deserialize<MSG_ZGC_PERSON_CHAT_WORDS>(stream);
        }

        public void OnResponse_MSG_GC_CHANGE_WORLD_ROOM(MemoryStream stream)
        {
            MSG_GC_CHANGE_WORLD_ROOM MSG_GC_CHANGE_WORLD_ROOM = ProtoBuf.Serializer.Deserialize<MSG_GC_CHANGE_WORLD_ROOM>(stream);
            Parser.Parse(MSG_GC_CHANGE_WORLD_ROOM);
        }
        public object Deserialize_MSG_GC_CHANGE_WORLD_ROOM(MemoryStream stream)
        {
            return ProtoBuf.Serializer.Deserialize<MSG_GC_CHANGE_WORLD_ROOM>(stream);
        }

        public void OnResponse_MSG_CMGC_WORLD_ROOM_INFO(MemoryStream stream)
        {
            MSG_CMGC_WORLD_ROOM_INFO MSG_CMGC_WORLD_ROOM_INFO = ProtoBuf.Serializer.Deserialize<MSG_CMGC_WORLD_ROOM_INFO>(stream);
            Parser.Parse(MSG_CMGC_WORLD_ROOM_INFO);
        }
        public object Deserialize_MSG_CMGC_WORLD_ROOM_INFO(MemoryStream stream)
        {
            return ProtoBuf.Serializer.Deserialize<MSG_CMGC_WORLD_ROOM_INFO>(stream);
        }

        public void OnResponse_MSG_CMGC_GET_WORLD_ROOM_LIST(MemoryStream stream)
        {
            MSG_CMGC_GET_WORLD_ROOM_LIST MSG_CMGC_GET_WORLD_ROOM_LIST = ProtoBuf.Serializer.Deserialize<MSG_CMGC_GET_WORLD_ROOM_LIST>(stream);
            Parser.Parse(MSG_CMGC_GET_WORLD_ROOM_LIST);
        }
        public object Deserialize_MSG_CMGC_GET_WORLD_ROOM_LIST(MemoryStream stream)
        {
            return ProtoBuf.Serializer.Deserialize<MSG_CMGC_GET_WORLD_ROOM_LIST>(stream);
        }

        public void OnResponse_MSG_ZGC_CHAT_TRUMPET(MemoryStream stream)
        {
            MSG_ZGC_CHAT_TRUMPET MSG_ZGC_CHAT_TRUMPET = ProtoBuf.Serializer.Deserialize<MSG_ZGC_CHAT_TRUMPET>(stream);
            Parser.Parse(MSG_ZGC_CHAT_TRUMPET);
        }
        public object Deserialize_MSG_ZGC_CHAT_TRUMPET(MemoryStream stream)
        {
            return ProtoBuf.Serializer.Deserialize<MSG_ZGC_CHAT_TRUMPET>(stream);
        }

        public void OnResponse_MSG_ZGC_CHAT_TRUMPET_RESULT(MemoryStream stream)
        {
            MSG_ZGC_CHAT_TRUMPET_RESULT MSG_ZGC_CHAT_TRUMPET_RESULT = ProtoBuf.Serializer.Deserialize<MSG_ZGC_CHAT_TRUMPET_RESULT>(stream);
            Parser.Parse(MSG_ZGC_CHAT_TRUMPET_RESULT);
        }
        public object Deserialize_MSG_ZGC_CHAT_TRUMPET_RESULT(MemoryStream stream)
        {
            return ProtoBuf.Serializer.Deserialize<MSG_ZGC_CHAT_TRUMPET_RESULT>(stream);
        }

        public void OnResponse_MSG_GC_ANNOUNCEMENT(MemoryStream stream)
        {
            MSG_GC_ANNOUNCEMENT MSG_GC_ANNOUNCEMENT = ProtoBuf.Serializer.Deserialize<MSG_GC_ANNOUNCEMENT>(stream);
            Parser.Parse(MSG_GC_ANNOUNCEMENT);
        }
        public object Deserialize_MSG_GC_ANNOUNCEMENT(MemoryStream stream)
        {
            return ProtoBuf.Serializer.Deserialize<MSG_GC_ANNOUNCEMENT>(stream);
        }

        public void OnResponse_MSG_ZGC_NEARBY_EMOJI(MemoryStream stream)
        {
            MSG_ZGC_NEARBY_EMOJI MSG_ZGC_NEARBY_EMOJI = ProtoBuf.Serializer.Deserialize<MSG_ZGC_NEARBY_EMOJI>(stream);
            Parser.Parse(MSG_ZGC_NEARBY_EMOJI);
        }
        public object Deserialize_MSG_ZGC_NEARBY_EMOJI(MemoryStream stream)
        {
            return ProtoBuf.Serializer.Deserialize<MSG_ZGC_NEARBY_EMOJI>(stream);
        }

        public void OnResponse_MSG_ZGC_TIP_OFF(MemoryStream stream)
        {
            MSG_ZGC_TIP_OFF MSG_ZGC_TIP_OFF = ProtoBuf.Serializer.Deserialize<MSG_ZGC_TIP_OFF>(stream);
            Parser.Parse(MSG_ZGC_TIP_OFF);
        }
        public object Deserialize_MSG_ZGC_TIP_OFF(MemoryStream stream)
        {
            return ProtoBuf.Serializer.Deserialize<MSG_ZGC_TIP_OFF>(stream);
        }

        public void OnResponse_MSG_ZGC_CHAT_BROADCAST(MemoryStream stream)
        {
            MSG_ZGC_CHAT_BROADCAST MSG_ZGC_CHAT_BROADCAST = ProtoBuf.Serializer.Deserialize<MSG_ZGC_CHAT_BROADCAST>(stream);
            Parser.Parse(MSG_ZGC_CHAT_BROADCAST);
        }
        public object Deserialize_MSG_ZGC_CHAT_BROADCAST(MemoryStream stream)
        {
            return ProtoBuf.Serializer.Deserialize<MSG_ZGC_CHAT_BROADCAST>(stream);
        }

        public void OnResponse_MSG_GC_NEARBY_ROOM(MemoryStream stream)
        {
            MSG_GC_NEARBY_ROOM MSG_GC_NEARBY_ROOM = ProtoBuf.Serializer.Deserialize<MSG_GC_NEARBY_ROOM>(stream);
            Parser.Parse(MSG_GC_NEARBY_ROOM);
        }
        public object Deserialize_MSG_GC_NEARBY_ROOM(MemoryStream stream)
        {
            return ProtoBuf.Serializer.Deserialize<MSG_GC_NEARBY_ROOM>(stream);
        }

        public void OnResponse_MSG_ZGC_SILENCE(MemoryStream stream)
        {
            MSG_ZGC_SILENCE MSG_ZGC_SILENCE = ProtoBuf.Serializer.Deserialize<MSG_ZGC_SILENCE>(stream);
            Parser.Parse(MSG_ZGC_SILENCE);
        }
        public object Deserialize_MSG_ZGC_SILENCE(MemoryStream stream)
        {
            return ProtoBuf.Serializer.Deserialize<MSG_ZGC_SILENCE>(stream);
        }

        public void OnResponse_MSG_ZGC_ACTIVITY_CHAT_BUBBLE(MemoryStream stream)
        {
            MSG_ZGC_ACTIVITY_CHAT_BUBBLE MSG_ZGC_ACTIVITY_CHAT_BUBBLE = ProtoBuf.Serializer.Deserialize<MSG_ZGC_ACTIVITY_CHAT_BUBBLE>(stream);
            Parser.Parse(MSG_ZGC_ACTIVITY_CHAT_BUBBLE);
        }
        public object Deserialize_MSG_ZGC_ACTIVITY_CHAT_BUBBLE(MemoryStream stream)
        {
            return ProtoBuf.Serializer.Deserialize<MSG_ZGC_ACTIVITY_CHAT_BUBBLE>(stream);
        }

        public void OnResponse_MSG_ZGC_TASK_LIST(MemoryStream stream)
        {
            MSG_ZGC_TASK_LIST MSG_ZGC_TASK_LIST = ProtoBuf.Serializer.Deserialize<MSG_ZGC_TASK_LIST>(stream);
            Parser.Parse(MSG_ZGC_TASK_LIST);
        }
        public object Deserialize_MSG_ZGC_TASK_LIST(MemoryStream stream)
        {
            return ProtoBuf.Serializer.Deserialize<MSG_ZGC_TASK_LIST>(stream);
        }

        public void OnResponse_MSG_ZGC_TASK_INFO(MemoryStream stream)
        {
            MSG_ZGC_TASK_INFO MSG_ZGC_TASK_INFO = ProtoBuf.Serializer.Deserialize<MSG_ZGC_TASK_INFO>(stream);
            Parser.Parse(MSG_ZGC_TASK_INFO);
        }
        public object Deserialize_MSG_ZGC_TASK_INFO(MemoryStream stream)
        {
            return ProtoBuf.Serializer.Deserialize<MSG_ZGC_TASK_INFO>(stream);
        }

        public void OnResponse_MSG_ZGC_TASK_CHANGE(MemoryStream stream)
        {
            MSG_ZGC_TASK_CHANGE MSG_ZGC_TASK_CHANGE = ProtoBuf.Serializer.Deserialize<MSG_ZGC_TASK_CHANGE>(stream);
            Parser.Parse(MSG_ZGC_TASK_CHANGE);
        }
        public object Deserialize_MSG_ZGC_TASK_CHANGE(MemoryStream stream)
        {
            return ProtoBuf.Serializer.Deserialize<MSG_ZGC_TASK_CHANGE>(stream);
        }

        public void OnResponse_MSG_ZGC_GET_TASK_RESULT(MemoryStream stream)
        {
            MSG_ZGC_GET_TASK_RESULT MSG_ZGC_GET_TASK_RESULT = ProtoBuf.Serializer.Deserialize<MSG_ZGC_GET_TASK_RESULT>(stream);
            Parser.Parse(MSG_ZGC_GET_TASK_RESULT);
        }
        public object Deserialize_MSG_ZGC_GET_TASK_RESULT(MemoryStream stream)
        {
            return ProtoBuf.Serializer.Deserialize<MSG_ZGC_GET_TASK_RESULT>(stream);
        }

        public void OnResponse_MSG_ZGC_TASK_COLLECT(MemoryStream stream)
        {
            MSG_ZGC_TASK_COLLECT MSG_ZGC_TASK_COLLECT = ProtoBuf.Serializer.Deserialize<MSG_ZGC_TASK_COLLECT>(stream);
            Parser.Parse(MSG_ZGC_TASK_COLLECT);
        }
        public object Deserialize_MSG_ZGC_TASK_COLLECT(MemoryStream stream)
        {
            return ProtoBuf.Serializer.Deserialize<MSG_ZGC_TASK_COLLECT>(stream);
        }

        public void OnResponse_MSG_ZGC_TASK_COMPLETE(MemoryStream stream)
        {
            MSG_ZGC_TASK_COMPLETE MSG_ZGC_TASK_COMPLETE = ProtoBuf.Serializer.Deserialize<MSG_ZGC_TASK_COMPLETE>(stream);
            Parser.Parse(MSG_ZGC_TASK_COMPLETE);
        }
        public object Deserialize_MSG_ZGC_TASK_COMPLETE(MemoryStream stream)
        {
            return ProtoBuf.Serializer.Deserialize<MSG_ZGC_TASK_COMPLETE>(stream);
        }

        public void OnResponse_MSG_ZGC_USE_TASKFLY_ANSWER(MemoryStream stream)
        {
            MSG_ZGC_USE_TASKFLY_ANSWER MSG_ZGC_USE_TASKFLY_ANSWER = ProtoBuf.Serializer.Deserialize<MSG_ZGC_USE_TASKFLY_ANSWER>(stream);
            Parser.Parse(MSG_ZGC_USE_TASKFLY_ANSWER);
        }
        public object Deserialize_MSG_ZGC_USE_TASKFLY_ANSWER(MemoryStream stream)
        {
            return ProtoBuf.Serializer.Deserialize<MSG_ZGC_USE_TASKFLY_ANSWER>(stream);
        }

        public void OnResponse_MSG_ZGC_TASKFLY_POSITION_SETDONE(MemoryStream stream)
        {
            MSG_ZGC_TASKFLY_POSITION_SETDONE MSG_ZGC_TASKFLY_POSITION_SETDONE = ProtoBuf.Serializer.Deserialize<MSG_ZGC_TASKFLY_POSITION_SETDONE>(stream);
            Parser.Parse(MSG_ZGC_TASKFLY_POSITION_SETDONE);
        }
        public object Deserialize_MSG_ZGC_TASKFLY_POSITION_SETDONE(MemoryStream stream)
        {
            return ProtoBuf.Serializer.Deserialize<MSG_ZGC_TASKFLY_POSITION_SETDONE>(stream);
        }

        public void OnResponse_MSG_ZGC_TASK_BATTLE_REWARD(MemoryStream stream)
        {
            MSG_ZGC_TASK_BATTLE_REWARD MSG_ZGC_TASK_BATTLE_REWARD = ProtoBuf.Serializer.Deserialize<MSG_ZGC_TASK_BATTLE_REWARD>(stream);
            Parser.Parse(MSG_ZGC_TASK_BATTLE_REWARD);
        }
        public object Deserialize_MSG_ZGC_TASK_BATTLE_REWARD(MemoryStream stream)
        {
            return ProtoBuf.Serializer.Deserialize<MSG_ZGC_TASK_BATTLE_REWARD>(stream);
        }

        public void OnResponse_MSG_ZGC_ACTIVITY_LIST(MemoryStream stream)
        {
            MSG_ZGC_ACTIVITY_LIST MSG_ZGC_ACTIVITY_LIST = ProtoBuf.Serializer.Deserialize<MSG_ZGC_ACTIVITY_LIST>(stream);
            Parser.Parse(MSG_ZGC_ACTIVITY_LIST);
        }
        public object Deserialize_MSG_ZGC_ACTIVITY_LIST(MemoryStream stream)
        {
            return ProtoBuf.Serializer.Deserialize<MSG_ZGC_ACTIVITY_LIST>(stream);
        }

        public void OnResponse_MSG_ZGC_ACTIVITY_INFO(MemoryStream stream)
        {
            MSG_ZGC_ACTIVITY_INFO MSG_ZGC_ACTIVITY_INFO = ProtoBuf.Serializer.Deserialize<MSG_ZGC_ACTIVITY_INFO>(stream);
            Parser.Parse(MSG_ZGC_ACTIVITY_INFO);
        }
        public object Deserialize_MSG_ZGC_ACTIVITY_INFO(MemoryStream stream)
        {
            return ProtoBuf.Serializer.Deserialize<MSG_ZGC_ACTIVITY_INFO>(stream);
        }

        public void OnResponse_MSG_ZGC_ACTIVITY_CHANGE(MemoryStream stream)
        {
            MSG_ZGC_ACTIVITY_CHANGE MSG_ZGC_ACTIVITY_CHANGE = ProtoBuf.Serializer.Deserialize<MSG_ZGC_ACTIVITY_CHANGE>(stream);
            Parser.Parse(MSG_ZGC_ACTIVITY_CHANGE);
        }
        public object Deserialize_MSG_ZGC_ACTIVITY_CHANGE(MemoryStream stream)
        {
            return ProtoBuf.Serializer.Deserialize<MSG_ZGC_ACTIVITY_CHANGE>(stream);
        }

        public void OnResponse_MSG_ZGC_ACTIVITY_COMPLETE(MemoryStream stream)
        {
            MSG_ZGC_ACTIVITY_COMPLETE MSG_ZGC_ACTIVITY_COMPLETE = ProtoBuf.Serializer.Deserialize<MSG_ZGC_ACTIVITY_COMPLETE>(stream);
            Parser.Parse(MSG_ZGC_ACTIVITY_COMPLETE);
        }
        public object Deserialize_MSG_ZGC_ACTIVITY_COMPLETE(MemoryStream stream)
        {
            return ProtoBuf.Serializer.Deserialize<MSG_ZGC_ACTIVITY_COMPLETE>(stream);
        }

        public void OnResponse_MSG_ZGC_QUESTIONNAIRE_COMPLETE(MemoryStream stream)
        {
            MSG_ZGC_QUESTIONNAIRE_COMPLETE MSG_ZGC_QUESTIONNAIRE_COMPLETE = ProtoBuf.Serializer.Deserialize<MSG_ZGC_QUESTIONNAIRE_COMPLETE>(stream);
            Parser.Parse(MSG_ZGC_QUESTIONNAIRE_COMPLETE);
        }
        public object Deserialize_MSG_ZGC_QUESTIONNAIRE_COMPLETE(MemoryStream stream)
        {
            return ProtoBuf.Serializer.Deserialize<MSG_ZGC_QUESTIONNAIRE_COMPLETE>(stream);
        }

        public void OnResponse_MSG_GC_LOGIN_WAIT_QUEUE(MemoryStream stream)
        {
            MSG_GC_LOGIN_WAIT_QUEUE MSG_GC_LOGIN_WAIT_QUEUE = ProtoBuf.Serializer.Deserialize<MSG_GC_LOGIN_WAIT_QUEUE>(stream);
            Parser.Parse(MSG_GC_LOGIN_WAIT_QUEUE);
        }
        public object Deserialize_MSG_GC_LOGIN_WAIT_QUEUE(MemoryStream stream)
        {
            return ProtoBuf.Serializer.Deserialize<MSG_GC_LOGIN_WAIT_QUEUE>(stream);
        }

        public void OnResponse_MSG_ZGC_DAILY_QUESTION_COUNTER(MemoryStream stream)
        {
            MSG_ZGC_DAILY_QUESTION_COUNTER MSG_ZGC_DAILY_QUESTION_COUNTER = ProtoBuf.Serializer.Deserialize<MSG_ZGC_DAILY_QUESTION_COUNTER>(stream);
            Parser.Parse(MSG_ZGC_DAILY_QUESTION_COUNTER);
        }
        public object Deserialize_MSG_ZGC_DAILY_QUESTION_COUNTER(MemoryStream stream)
        {
            return ProtoBuf.Serializer.Deserialize<MSG_ZGC_DAILY_QUESTION_COUNTER>(stream);
        }

        public void OnResponse_MSG_ZGC_DAILY_QUESTION_REWARD(MemoryStream stream)
        {
            MSG_ZGC_DAILY_QUESTION_REWARD MSG_ZGC_DAILY_QUESTION_REWARD = ProtoBuf.Serializer.Deserialize<MSG_ZGC_DAILY_QUESTION_REWARD>(stream);
            Parser.Parse(MSG_ZGC_DAILY_QUESTION_REWARD);
        }
        public object Deserialize_MSG_ZGC_DAILY_QUESTION_REWARD(MemoryStream stream)
        {
            return ProtoBuf.Serializer.Deserialize<MSG_ZGC_DAILY_QUESTION_REWARD>(stream);
        }

        public void OnResponse_MSG_ZGC_SHOW_CHARACTER(MemoryStream stream)
        {
            MSG_ZGC_SHOW_CHARACTER MSG_ZGC_SHOW_CHARACTER = ProtoBuf.Serializer.Deserialize<MSG_ZGC_SHOW_CHARACTER>(stream);
            Parser.Parse(MSG_ZGC_SHOW_CHARACTER);
        }
        public object Deserialize_MSG_ZGC_SHOW_CHARACTER(MemoryStream stream)
        {
            return ProtoBuf.Serializer.Deserialize<MSG_ZGC_SHOW_CHARACTER>(stream);
        }

        public void OnResponse_SHOW_CHARACTERINFO(MemoryStream stream)
        {
            SHOW_CHARACTERINFO SHOW_CHARACTERINFO = ProtoBuf.Serializer.Deserialize<SHOW_CHARACTERINFO>(stream);
            Parser.Parse(SHOW_CHARACTERINFO);
        }
        public object Deserialize_SHOW_CHARACTERINFO(MemoryStream stream)
        {
            return ProtoBuf.Serializer.Deserialize<SHOW_CHARACTERINFO>(stream);
        }

        public void OnResponse_SHOW_SPACEINFO(MemoryStream stream)
        {
            SHOW_SPACEINFO SHOW_SPACEINFO = ProtoBuf.Serializer.Deserialize<SHOW_SPACEINFO>(stream);
            Parser.Parse(SHOW_SPACEINFO);
        }
        public object Deserialize_SHOW_SPACEINFO(MemoryStream stream)
        {
            return ProtoBuf.Serializer.Deserialize<SHOW_SPACEINFO>(stream);
        }

        public void OnResponse_MSG_ZGC_CHANGE_NAME(MemoryStream stream)
        {
            MSG_ZGC_CHANGE_NAME MSG_ZGC_CHANGE_NAME = ProtoBuf.Serializer.Deserialize<MSG_ZGC_CHANGE_NAME>(stream);
            Parser.Parse(MSG_ZGC_CHANGE_NAME);
        }
        public object Deserialize_MSG_ZGC_CHANGE_NAME(MemoryStream stream)
        {
            return ProtoBuf.Serializer.Deserialize<MSG_ZGC_CHANGE_NAME>(stream);
        }

        public void OnResponse_MSG_ZGC_SHOW_FACEICON(MemoryStream stream)
        {
            MSG_ZGC_SHOW_FACEICON MSG_ZGC_SHOW_FACEICON = ProtoBuf.Serializer.Deserialize<MSG_ZGC_SHOW_FACEICON>(stream);
            Parser.Parse(MSG_ZGC_SHOW_FACEICON);
        }
        public object Deserialize_MSG_ZGC_SHOW_FACEICON(MemoryStream stream)
        {
            return ProtoBuf.Serializer.Deserialize<MSG_ZGC_SHOW_FACEICON>(stream);
        }

        public void OnResponse_MSG_ZGC_SHOW_FACEJPG(MemoryStream stream)
        {
            MSG_ZGC_SHOW_FACEJPG MSG_ZGC_SHOW_FACEJPG = ProtoBuf.Serializer.Deserialize<MSG_ZGC_SHOW_FACEJPG>(stream);
            Parser.Parse(MSG_ZGC_SHOW_FACEJPG);
        }
        public object Deserialize_MSG_ZGC_SHOW_FACEJPG(MemoryStream stream)
        {
            return ProtoBuf.Serializer.Deserialize<MSG_ZGC_SHOW_FACEJPG>(stream);
        }

        public void OnResponse_MSG_ZGC_SET_SEX(MemoryStream stream)
        {
            MSG_ZGC_SET_SEX MSG_ZGC_SET_SEX = ProtoBuf.Serializer.Deserialize<MSG_ZGC_SET_SEX>(stream);
            Parser.Parse(MSG_ZGC_SET_SEX);
        }
        public object Deserialize_MSG_ZGC_SET_SEX(MemoryStream stream)
        {
            return ProtoBuf.Serializer.Deserialize<MSG_ZGC_SET_SEX>(stream);
        }

        public void OnResponse_MSG_ZGC_SET_BIRTHDAY(MemoryStream stream)
        {
            MSG_ZGC_SET_BIRTHDAY MSG_ZGC_SET_BIRTHDAY = ProtoBuf.Serializer.Deserialize<MSG_ZGC_SET_BIRTHDAY>(stream);
            Parser.Parse(MSG_ZGC_SET_BIRTHDAY);
        }
        public object Deserialize_MSG_ZGC_SET_BIRTHDAY(MemoryStream stream)
        {
            return ProtoBuf.Serializer.Deserialize<MSG_ZGC_SET_BIRTHDAY>(stream);
        }

        public void OnResponse_MSG_ZGC_SET_SIGNATURE(MemoryStream stream)
        {
            MSG_ZGC_SET_SIGNATURE MSG_ZGC_SET_SIGNATURE = ProtoBuf.Serializer.Deserialize<MSG_ZGC_SET_SIGNATURE>(stream);
            Parser.Parse(MSG_ZGC_SET_SIGNATURE);
        }
        public object Deserialize_MSG_ZGC_SET_SIGNATURE(MemoryStream stream)
        {
            return ProtoBuf.Serializer.Deserialize<MSG_ZGC_SET_SIGNATURE>(stream);
        }

        public void OnResponse_MSG_ZGC_SHOW_VOICE(MemoryStream stream)
        {
            MSG_ZGC_SHOW_VOICE MSG_ZGC_SHOW_VOICE = ProtoBuf.Serializer.Deserialize<MSG_ZGC_SHOW_VOICE>(stream);
            Parser.Parse(MSG_ZGC_SHOW_VOICE);
        }
        public object Deserialize_MSG_ZGC_SHOW_VOICE(MemoryStream stream)
        {
            return ProtoBuf.Serializer.Deserialize<MSG_ZGC_SHOW_VOICE>(stream);
        }

        public void OnResponse_MSG_ZGC_PRESENT_GIFT(MemoryStream stream)
        {
            MSG_ZGC_PRESENT_GIFT MSG_ZGC_PRESENT_GIFT = ProtoBuf.Serializer.Deserialize<MSG_ZGC_PRESENT_GIFT>(stream);
            Parser.Parse(MSG_ZGC_PRESENT_GIFT);
        }
        public object Deserialize_MSG_ZGC_PRESENT_GIFT(MemoryStream stream)
        {
            return ProtoBuf.Serializer.Deserialize<MSG_ZGC_PRESENT_GIFT>(stream);
        }

        public void OnResponse_MSG_ZGC_SET_SOCIAL_NUM(MemoryStream stream)
        {
            MSG_ZGC_SET_SOCIAL_NUM MSG_ZGC_SET_SOCIAL_NUM = ProtoBuf.Serializer.Deserialize<MSG_ZGC_SET_SOCIAL_NUM>(stream);
            Parser.Parse(MSG_ZGC_SET_SOCIAL_NUM);
        }
        public object Deserialize_MSG_ZGC_SET_SOCIAL_NUM(MemoryStream stream)
        {
            return ProtoBuf.Serializer.Deserialize<MSG_ZGC_SET_SOCIAL_NUM>(stream);
        }

        public void OnResponse_MSG_ZGC_GET_SOCIAL_NUM(MemoryStream stream)
        {
            MSG_ZGC_GET_SOCIAL_NUM MSG_ZGC_GET_SOCIAL_NUM = ProtoBuf.Serializer.Deserialize<MSG_ZGC_GET_SOCIAL_NUM>(stream);
            Parser.Parse(MSG_ZGC_GET_SOCIAL_NUM);
        }
        public object Deserialize_MSG_ZGC_GET_SOCIAL_NUM(MemoryStream stream)
        {
            return ProtoBuf.Serializer.Deserialize<MSG_ZGC_GET_SOCIAL_NUM>(stream);
        }

        public void OnResponse_MSG_ZGC_GEOGRAPHY(MemoryStream stream)
        {
            MSG_ZGC_GEOGRAPHY MSG_ZGC_GEOGRAPHY = ProtoBuf.Serializer.Deserialize<MSG_ZGC_GEOGRAPHY>(stream);
            Parser.Parse(MSG_ZGC_GEOGRAPHY);
        }
        public object Deserialize_MSG_ZGC_GEOGRAPHY(MemoryStream stream)
        {
            return ProtoBuf.Serializer.Deserialize<MSG_ZGC_GEOGRAPHY>(stream);
        }

        public void OnResponse_MSG_ZGC_UPDATE_SOME_SHOW(MemoryStream stream)
        {
            MSG_ZGC_UPDATE_SOME_SHOW MSG_ZGC_UPDATE_SOME_SHOW = ProtoBuf.Serializer.Deserialize<MSG_ZGC_UPDATE_SOME_SHOW>(stream);
            Parser.Parse(MSG_ZGC_UPDATE_SOME_SHOW);
        }
        public object Deserialize_MSG_ZGC_UPDATE_SOME_SHOW(MemoryStream stream)
        {
            return ProtoBuf.Serializer.Deserialize<MSG_ZGC_UPDATE_SOME_SHOW>(stream);
        }

        public void OnResponse_MSG_ZGC_SHOW_CAREER(MemoryStream stream)
        {
            MSG_ZGC_SHOW_CAREER MSG_ZGC_SHOW_CAREER = ProtoBuf.Serializer.Deserialize<MSG_ZGC_SHOW_CAREER>(stream);
            Parser.Parse(MSG_ZGC_SHOW_CAREER);
        }
        public object Deserialize_MSG_ZGC_SHOW_CAREER(MemoryStream stream)
        {
            return ProtoBuf.Serializer.Deserialize<MSG_ZGC_SHOW_CAREER>(stream);
        }

        public void OnResponse_MSG_ZGC_CAREER_ITEM(MemoryStream stream)
        {
            MSG_ZGC_CAREER_ITEM MSG_ZGC_CAREER_ITEM = ProtoBuf.Serializer.Deserialize<MSG_ZGC_CAREER_ITEM>(stream);
            Parser.Parse(MSG_ZGC_CAREER_ITEM);
        }
        public object Deserialize_MSG_ZGC_CAREER_ITEM(MemoryStream stream)
        {
            return ProtoBuf.Serializer.Deserialize<MSG_ZGC_CAREER_ITEM>(stream);
        }

        public void OnResponse_MSG_ZGC_GET_GIFTRECORD(MemoryStream stream)
        {
            MSG_ZGC_GET_GIFTRECORD MSG_ZGC_GET_GIFTRECORD = ProtoBuf.Serializer.Deserialize<MSG_ZGC_GET_GIFTRECORD>(stream);
            Parser.Parse(MSG_ZGC_GET_GIFTRECORD);
        }
        public object Deserialize_MSG_ZGC_GET_GIFTRECORD(MemoryStream stream)
        {
            return ProtoBuf.Serializer.Deserialize<MSG_ZGC_GET_GIFTRECORD>(stream);
        }

        public void OnResponse_MSG_ZGC_TITLE_INFO(MemoryStream stream)
        {
            MSG_ZGC_TITLE_INFO MSG_ZGC_TITLE_INFO = ProtoBuf.Serializer.Deserialize<MSG_ZGC_TITLE_INFO>(stream);
            Parser.Parse(MSG_ZGC_TITLE_INFO);
        }
        public object Deserialize_MSG_ZGC_TITLE_INFO(MemoryStream stream)
        {
            return ProtoBuf.Serializer.Deserialize<MSG_ZGC_TITLE_INFO>(stream);
        }

        public void OnResponse_MSG_ZGC_CHANGE_TITLE_ANSWER(MemoryStream stream)
        {
            MSG_ZGC_CHANGE_TITLE_ANSWER MSG_ZGC_CHANGE_TITLE_ANSWER = ProtoBuf.Serializer.Deserialize<MSG_ZGC_CHANGE_TITLE_ANSWER>(stream);
            Parser.Parse(MSG_ZGC_CHANGE_TITLE_ANSWER);
        }
        public object Deserialize_MSG_ZGC_CHANGE_TITLE_ANSWER(MemoryStream stream)
        {
            return ProtoBuf.Serializer.Deserialize<MSG_ZGC_CHANGE_TITLE_ANSWER>(stream);
        }

        public void OnResponse_MSG_ZGC_UPLOAD_PHOTO(MemoryStream stream)
        {
            MSG_ZGC_UPLOAD_PHOTO MSG_ZGC_UPLOAD_PHOTO = ProtoBuf.Serializer.Deserialize<MSG_ZGC_UPLOAD_PHOTO>(stream);
            Parser.Parse(MSG_ZGC_UPLOAD_PHOTO);
        }
        public object Deserialize_MSG_ZGC_UPLOAD_PHOTO(MemoryStream stream)
        {
            return ProtoBuf.Serializer.Deserialize<MSG_ZGC_UPLOAD_PHOTO>(stream);
        }

        public void OnResponse_MSG_ZGC_REMOVE_PHOTO(MemoryStream stream)
        {
            MSG_ZGC_REMOVE_PHOTO MSG_ZGC_REMOVE_PHOTO = ProtoBuf.Serializer.Deserialize<MSG_ZGC_REMOVE_PHOTO>(stream);
            Parser.Parse(MSG_ZGC_REMOVE_PHOTO);
        }
        public object Deserialize_MSG_ZGC_REMOVE_PHOTO(MemoryStream stream)
        {
            return ProtoBuf.Serializer.Deserialize<MSG_ZGC_REMOVE_PHOTO>(stream);
        }

        public void OnResponse_MSG_ZGC_PHOTO_LIST(MemoryStream stream)
        {
            MSG_ZGC_PHOTO_LIST MSG_ZGC_PHOTO_LIST = ProtoBuf.Serializer.Deserialize<MSG_ZGC_PHOTO_LIST>(stream);
            Parser.Parse(MSG_ZGC_PHOTO_LIST);
        }
        public object Deserialize_MSG_ZGC_PHOTO_LIST(MemoryStream stream)
        {
            return ProtoBuf.Serializer.Deserialize<MSG_ZGC_PHOTO_LIST>(stream);
        }

        public void OnResponse_POP_RANK_PLAYER(MemoryStream stream)
        {
            POP_RANK_PLAYER POP_RANK_PLAYER = ProtoBuf.Serializer.Deserialize<POP_RANK_PLAYER>(stream);
            Parser.Parse(POP_RANK_PLAYER);
        }
        public object Deserialize_POP_RANK_PLAYER(MemoryStream stream)
        {
            return ProtoBuf.Serializer.Deserialize<POP_RANK_PLAYER>(stream);
        }

        public void OnResponse_MSG_ZGC_POP_RANK(MemoryStream stream)
        {
            MSG_ZGC_POP_RANK MSG_ZGC_POP_RANK = ProtoBuf.Serializer.Deserialize<MSG_ZGC_POP_RANK>(stream);
            Parser.Parse(MSG_ZGC_POP_RANK);
        }
        public object Deserialize_MSG_ZGC_POP_RANK(MemoryStream stream)
        {
            return ProtoBuf.Serializer.Deserialize<MSG_ZGC_POP_RANK>(stream);
        }

        public void OnResponse_MSG_ZGC_RADIO_ALL_ANCHOR_RANK(MemoryStream stream)
        {
            MSG_ZGC_RADIO_ALL_ANCHOR_RANK MSG_ZGC_RADIO_ALL_ANCHOR_RANK = ProtoBuf.Serializer.Deserialize<MSG_ZGC_RADIO_ALL_ANCHOR_RANK>(stream);
            Parser.Parse(MSG_ZGC_RADIO_ALL_ANCHOR_RANK);
        }
        public object Deserialize_MSG_ZGC_RADIO_ALL_ANCHOR_RANK(MemoryStream stream)
        {
            return ProtoBuf.Serializer.Deserialize<MSG_ZGC_RADIO_ALL_ANCHOR_RANK>(stream);
        }

        public void OnResponse_MSG_ZGC_RADIO_ANCHOR_CONTRIBUTION_RANK(MemoryStream stream)
        {
            MSG_ZGC_RADIO_ANCHOR_CONTRIBUTION_RANK MSG_ZGC_RADIO_ANCHOR_CONTRIBUTION_RANK = ProtoBuf.Serializer.Deserialize<MSG_ZGC_RADIO_ANCHOR_CONTRIBUTION_RANK>(stream);
            Parser.Parse(MSG_ZGC_RADIO_ANCHOR_CONTRIBUTION_RANK);
        }
        public object Deserialize_MSG_ZGC_RADIO_ANCHOR_CONTRIBUTION_RANK(MemoryStream stream)
        {
            return ProtoBuf.Serializer.Deserialize<MSG_ZGC_RADIO_ANCHOR_CONTRIBUTION_RANK>(stream);
        }

        public void OnResponse_MSG_ZGC_RADIO_ALL_CONTRIBUTION_RANK(MemoryStream stream)
        {
            MSG_ZGC_RADIO_ALL_CONTRIBUTION_RANK MSG_ZGC_RADIO_ALL_CONTRIBUTION_RANK = ProtoBuf.Serializer.Deserialize<MSG_ZGC_RADIO_ALL_CONTRIBUTION_RANK>(stream);
            Parser.Parse(MSG_ZGC_RADIO_ALL_CONTRIBUTION_RANK);
        }
        public object Deserialize_MSG_ZGC_RADIO_ALL_CONTRIBUTION_RANK(MemoryStream stream)
        {
            return ProtoBuf.Serializer.Deserialize<MSG_ZGC_RADIO_ALL_CONTRIBUTION_RANK>(stream);
        }

        public void OnResponse_MSG_ZGC_RADIO_CONTRIBUTION_REWARD(MemoryStream stream)
        {
            MSG_ZGC_RADIO_CONTRIBUTION_REWARD MSG_ZGC_RADIO_CONTRIBUTION_REWARD = ProtoBuf.Serializer.Deserialize<MSG_ZGC_RADIO_CONTRIBUTION_REWARD>(stream);
            Parser.Parse(MSG_ZGC_RADIO_CONTRIBUTION_REWARD);
        }
        public object Deserialize_MSG_ZGC_RADIO_CONTRIBUTION_REWARD(MemoryStream stream)
        {
            return ProtoBuf.Serializer.Deserialize<MSG_ZGC_RADIO_CONTRIBUTION_REWARD>(stream);
        }

        public void OnResponse_MSG_ZGC_RADIO_GIFT(MemoryStream stream)
        {
            MSG_ZGC_RADIO_GIFT MSG_ZGC_RADIO_GIFT = ProtoBuf.Serializer.Deserialize<MSG_ZGC_RADIO_GIFT>(stream);
            Parser.Parse(MSG_ZGC_RADIO_GIFT);
        }
        public object Deserialize_MSG_ZGC_RADIO_GIFT(MemoryStream stream)
        {
            return ProtoBuf.Serializer.Deserialize<MSG_ZGC_RADIO_GIFT>(stream);
        }

        public void OnResponse_MSG_ZGC_ANCHOR_INFO(MemoryStream stream)
        {
            MSG_ZGC_ANCHOR_INFO MSG_ZGC_ANCHOR_INFO = ProtoBuf.Serializer.Deserialize<MSG_ZGC_ANCHOR_INFO>(stream);
            Parser.Parse(MSG_ZGC_ANCHOR_INFO);
        }
        public object Deserialize_MSG_ZGC_ANCHOR_INFO(MemoryStream stream)
        {
            return ProtoBuf.Serializer.Deserialize<MSG_ZGC_ANCHOR_INFO>(stream);
        }

        MSG_CG_CHARACTER_LIST msg_MSG_CG_CHARACTER_LIST;

        public object Init_MSG_CG_CHARACTER_LIST()
        {
            msg_MSG_CG_CHARACTER_LIST = new MSG_CG_CHARACTER_LIST();
            return msg_MSG_CG_CHARACTER_LIST;
        }
        public object Get_MSG_CG_CHARACTER_LIST()
        {
            return msg_MSG_CG_CHARACTER_LIST;
        }
        public object New_MSG_CG_CHARACTER_LIST()
        {
            return msg_MSG_CG_CHARACTER_LIST;
        }
        public void OnResponse_MSG_CG_CHARACTER_LIST(MemoryStream stream)
        {
            MSG_CG_CHARACTER_LIST MSG_CG_CHARACTER_LIST = ProtoBuf.Serializer.Deserialize<MSG_CG_CHARACTER_LIST>(stream);
            Parser.Parse(MSG_CG_CHARACTER_LIST);
        }
        public object Deserialize_MSG_CG_CHARACTER_LIST(MemoryStream stream)
        {
            return ProtoBuf.Serializer.Deserialize<MSG_CG_CHARACTER_LIST>(stream);
        }

        MSG_CG_ITEM_BUY msg_MSG_CG_ITEM_BUY;

        public object Init_MSG_CG_ITEM_BUY()
        {
            msg_MSG_CG_ITEM_BUY = new MSG_CG_ITEM_BUY();
            return msg_MSG_CG_ITEM_BUY;
        }
        public object Get_MSG_CG_ITEM_BUY()
        {
            return msg_MSG_CG_ITEM_BUY;
        }
        public object New_MSG_CG_ITEM_BUY()
        {
            return msg_MSG_CG_ITEM_BUY;
        }
        public void OnResponse_MSG_CG_ITEM_BUY(MemoryStream stream)
        {
            MSG_CG_ITEM_BUY MSG_CG_ITEM_BUY = ProtoBuf.Serializer.Deserialize<MSG_CG_ITEM_BUY>(stream);
            Parser.Parse(MSG_CG_ITEM_BUY);
        }
        public object Deserialize_MSG_CG_ITEM_BUY(MemoryStream stream)
        {
            return ProtoBuf.Serializer.Deserialize<MSG_CG_ITEM_BUY>(stream);
        }

        MSG_CG_CREATE_CHARACTER msg_MSG_CG_CREATE_CHARACTER;

        public object Init_MSG_CG_CREATE_CHARACTER()
        {
            msg_MSG_CG_CREATE_CHARACTER = new MSG_CG_CREATE_CHARACTER();
            return msg_MSG_CG_CREATE_CHARACTER;
        }
        public object Get_MSG_CG_CREATE_CHARACTER()
        {
            return msg_MSG_CG_CREATE_CHARACTER;
        }
        public object New_MSG_CG_CREATE_CHARACTER()
        {
            return msg_MSG_CG_CREATE_CHARACTER;
        }
        public void OnResponse_MSG_CG_CREATE_CHARACTER(MemoryStream stream)
        {
            MSG_CG_CREATE_CHARACTER MSG_CG_CREATE_CHARACTER = ProtoBuf.Serializer.Deserialize<MSG_CG_CREATE_CHARACTER>(stream);
            Parser.Parse(MSG_CG_CREATE_CHARACTER);
        }
        public object Deserialize_MSG_CG_CREATE_CHARACTER(MemoryStream stream)
        {
            return ProtoBuf.Serializer.Deserialize<MSG_CG_CREATE_CHARACTER>(stream);
        }

        MSG_CG_TO_ZONE msg_MSG_CG_TO_ZONE;

        public object Init_MSG_CG_TO_ZONE()
        {
            msg_MSG_CG_TO_ZONE = new MSG_CG_TO_ZONE();
            return msg_MSG_CG_TO_ZONE;
        }
        public object Get_MSG_CG_TO_ZONE()
        {
            return msg_MSG_CG_TO_ZONE;
        }
        public object New_MSG_CG_TO_ZONE()
        {
            return msg_MSG_CG_TO_ZONE;
        }
        public void OnResponse_MSG_CG_TO_ZONE(MemoryStream stream)
        {
            MSG_CG_TO_ZONE MSG_CG_TO_ZONE = ProtoBuf.Serializer.Deserialize<MSG_CG_TO_ZONE>(stream);
            Parser.Parse(MSG_CG_TO_ZONE);
        }
        public object Deserialize_MSG_CG_TO_ZONE(MemoryStream stream)
        {
            return ProtoBuf.Serializer.Deserialize<MSG_CG_TO_ZONE>(stream);
        }

        MSG_CG_MAP_LOADING_DONE msg_MSG_CG_MAP_LOADING_DONE;

        public object Init_MSG_CG_MAP_LOADING_DONE()
        {
            msg_MSG_CG_MAP_LOADING_DONE = new MSG_CG_MAP_LOADING_DONE();
            return msg_MSG_CG_MAP_LOADING_DONE;
        }
        public object Get_MSG_CG_MAP_LOADING_DONE()
        {
            return msg_MSG_CG_MAP_LOADING_DONE;
        }
        public object New_MSG_CG_MAP_LOADING_DONE()
        {
            return msg_MSG_CG_MAP_LOADING_DONE;
        }
        public void OnResponse_MSG_CG_MAP_LOADING_DONE(MemoryStream stream)
        {
            MSG_CG_MAP_LOADING_DONE MSG_CG_MAP_LOADING_DONE = ProtoBuf.Serializer.Deserialize<MSG_CG_MAP_LOADING_DONE>(stream);
            Parser.Parse(MSG_CG_MAP_LOADING_DONE);
        }
        public object Deserialize_MSG_CG_MAP_LOADING_DONE(MemoryStream stream)
        {
            return ProtoBuf.Serializer.Deserialize<MSG_CG_MAP_LOADING_DONE>(stream);
        }

        MSG_CG_HEARTBEAT msg_MSG_CG_HEARTBEAT;

        public object Init_MSG_CG_HEARTBEAT()
        {
            msg_MSG_CG_HEARTBEAT = new MSG_CG_HEARTBEAT();
            return msg_MSG_CG_HEARTBEAT;
        }
        public object Get_MSG_CG_HEARTBEAT()
        {
            return msg_MSG_CG_HEARTBEAT;
        }
        public object New_MSG_CG_HEARTBEAT()
        {
            return msg_MSG_CG_HEARTBEAT;
        }
        public void OnResponse_MSG_CG_HEARTBEAT(MemoryStream stream)
        {
            MSG_CG_HEARTBEAT MSG_CG_HEARTBEAT = ProtoBuf.Serializer.Deserialize<MSG_CG_HEARTBEAT>(stream);
            Parser.Parse(MSG_CG_HEARTBEAT);
        }
        public object Deserialize_MSG_CG_HEARTBEAT(MemoryStream stream)
        {
            return ProtoBuf.Serializer.Deserialize<MSG_CG_HEARTBEAT>(stream);
        }

        MSG_CG_SHIP_STEP msg_MSG_CG_SHIP_STEP;

        public object Init_MSG_CG_SHIP_STEP()
        {
            msg_MSG_CG_SHIP_STEP = new MSG_CG_SHIP_STEP();
            return msg_MSG_CG_SHIP_STEP;
        }
        public object Get_MSG_CG_SHIP_STEP()
        {
            return msg_MSG_CG_SHIP_STEP;
        }
        public object New_MSG_CG_SHIP_STEP()
        {
            return msg_MSG_CG_SHIP_STEP;
        }
        public void OnResponse_MSG_CG_SHIP_STEP(MemoryStream stream)
        {
            MSG_CG_SHIP_STEP MSG_CG_SHIP_STEP = ProtoBuf.Serializer.Deserialize<MSG_CG_SHIP_STEP>(stream);
            Parser.Parse(MSG_CG_SHIP_STEP);
        }
        public object Deserialize_MSG_CG_SHIP_STEP(MemoryStream stream)
        {
            return ProtoBuf.Serializer.Deserialize<MSG_CG_SHIP_STEP>(stream);
        }

        MSG_CG_CHARACTER_MOVE msg_MSG_CG_CHARACTER_MOVE;

        public object Init_MSG_CG_CHARACTER_MOVE()
        {
            msg_MSG_CG_CHARACTER_MOVE = new MSG_CG_CHARACTER_MOVE();
            return msg_MSG_CG_CHARACTER_MOVE;
        }
        public object Get_MSG_CG_CHARACTER_MOVE()
        {
            return msg_MSG_CG_CHARACTER_MOVE;
        }
        public object New_MSG_CG_CHARACTER_MOVE()
        {
            return msg_MSG_CG_CHARACTER_MOVE;
        }
        public void OnResponse_MSG_CG_CHARACTER_MOVE(MemoryStream stream)
        {
            MSG_CG_CHARACTER_MOVE MSG_CG_CHARACTER_MOVE = ProtoBuf.Serializer.Deserialize<MSG_CG_CHARACTER_MOVE>(stream);
            Parser.Parse(MSG_CG_CHARACTER_MOVE);
        }
        public object Deserialize_MSG_CG_CHARACTER_MOVE(MemoryStream stream)
        {
            return ProtoBuf.Serializer.Deserialize<MSG_CG_CHARACTER_MOVE>(stream);
        }

        MSG_CG_MOVE_ZONE msg_MSG_CG_MOVE_ZONE;

        public object Init_MSG_CG_MOVE_ZONE()
        {
            msg_MSG_CG_MOVE_ZONE = new MSG_CG_MOVE_ZONE();
            return msg_MSG_CG_MOVE_ZONE;
        }
        public object Get_MSG_CG_MOVE_ZONE()
        {
            return msg_MSG_CG_MOVE_ZONE;
        }
        public object New_MSG_CG_MOVE_ZONE()
        {
            return msg_MSG_CG_MOVE_ZONE;
        }
        public void OnResponse_MSG_CG_MOVE_ZONE(MemoryStream stream)
        {
            MSG_CG_MOVE_ZONE MSG_CG_MOVE_ZONE = ProtoBuf.Serializer.Deserialize<MSG_CG_MOVE_ZONE>(stream);
            Parser.Parse(MSG_CG_MOVE_ZONE);
        }
        public object Deserialize_MSG_CG_MOVE_ZONE(MemoryStream stream)
        {
            return ProtoBuf.Serializer.Deserialize<MSG_CG_MOVE_ZONE>(stream);
        }

        MSG_CG_AUTOPATHFINDING msg_MSG_CG_AUTOPATHFINDING;

        public object Init_MSG_CG_AUTOPATHFINDING()
        {
            msg_MSG_CG_AUTOPATHFINDING = new MSG_CG_AUTOPATHFINDING();
            return msg_MSG_CG_AUTOPATHFINDING;
        }
        public object Get_MSG_CG_AUTOPATHFINDING()
        {
            return msg_MSG_CG_AUTOPATHFINDING;
        }
        public object New_MSG_CG_AUTOPATHFINDING()
        {
            return msg_MSG_CG_AUTOPATHFINDING;
        }
        public void OnResponse_MSG_CG_AUTOPATHFINDING(MemoryStream stream)
        {
            MSG_CG_AUTOPATHFINDING MSG_CG_AUTOPATHFINDING = ProtoBuf.Serializer.Deserialize<MSG_CG_AUTOPATHFINDING>(stream);
            Parser.Parse(MSG_CG_AUTOPATHFINDING);
        }
        public object Deserialize_MSG_CG_AUTOPATHFINDING(MemoryStream stream)
        {
            return ProtoBuf.Serializer.Deserialize<MSG_CG_AUTOPATHFINDING>(stream);
        }

        MSG_CG_GEOGRAPHY msg_MSG_CG_GEOGRAPHY;

        public object Init_MSG_CG_GEOGRAPHY()
        {
            msg_MSG_CG_GEOGRAPHY = new MSG_CG_GEOGRAPHY();
            return msg_MSG_CG_GEOGRAPHY;
        }
        public object Get_MSG_CG_GEOGRAPHY()
        {
            return msg_MSG_CG_GEOGRAPHY;
        }
        public object New_MSG_CG_GEOGRAPHY()
        {
            return msg_MSG_CG_GEOGRAPHY;
        }
        public void OnResponse_MSG_CG_GEOGRAPHY(MemoryStream stream)
        {
            MSG_CG_GEOGRAPHY MSG_CG_GEOGRAPHY = ProtoBuf.Serializer.Deserialize<MSG_CG_GEOGRAPHY>(stream);
            Parser.Parse(MSG_CG_GEOGRAPHY);
        }
        public object Deserialize_MSG_CG_GEOGRAPHY(MemoryStream stream)
        {
            return ProtoBuf.Serializer.Deserialize<MSG_CG_GEOGRAPHY>(stream);
        }

        MSG_CG_RECONNECT_LOGIN msg_MSG_CG_RECONNECT_LOGIN;

        public object Init_MSG_CG_RECONNECT_LOGIN()
        {
            msg_MSG_CG_RECONNECT_LOGIN = new MSG_CG_RECONNECT_LOGIN();
            return msg_MSG_CG_RECONNECT_LOGIN;
        }
        public object Get_MSG_CG_RECONNECT_LOGIN()
        {
            return msg_MSG_CG_RECONNECT_LOGIN;
        }
        public object New_MSG_CG_RECONNECT_LOGIN()
        {
            return msg_MSG_CG_RECONNECT_LOGIN;
        }
        public void OnResponse_MSG_CG_RECONNECT_LOGIN(MemoryStream stream)
        {
            MSG_CG_RECONNECT_LOGIN MSG_CG_RECONNECT_LOGIN = ProtoBuf.Serializer.Deserialize<MSG_CG_RECONNECT_LOGIN>(stream);
            Parser.Parse(MSG_CG_RECONNECT_LOGIN);
        }
        public object Deserialize_MSG_CG_RECONNECT_LOGIN(MemoryStream stream)
        {
            return ProtoBuf.Serializer.Deserialize<MSG_CG_RECONNECT_LOGIN>(stream);
        }

        MSG_CG_CROSS_PORTAL msg_MSG_CG_CROSS_PORTAL;

        public object Init_MSG_CG_CROSS_PORTAL()
        {
            msg_MSG_CG_CROSS_PORTAL = new MSG_CG_CROSS_PORTAL();
            return msg_MSG_CG_CROSS_PORTAL;
        }
        public object Get_MSG_CG_CROSS_PORTAL()
        {
            return msg_MSG_CG_CROSS_PORTAL;
        }
        public object New_MSG_CG_CROSS_PORTAL()
        {
            return msg_MSG_CG_CROSS_PORTAL;
        }
        public void OnResponse_MSG_CG_CROSS_PORTAL(MemoryStream stream)
        {
            MSG_CG_CROSS_PORTAL MSG_CG_CROSS_PORTAL = ProtoBuf.Serializer.Deserialize<MSG_CG_CROSS_PORTAL>(stream);
            Parser.Parse(MSG_CG_CROSS_PORTAL);
        }
        public object Deserialize_MSG_CG_CROSS_PORTAL(MemoryStream stream)
        {
            return ProtoBuf.Serializer.Deserialize<MSG_CG_CROSS_PORTAL>(stream);
        }

        MSG_CG_GET_BLOWFISHKEY msg_MSG_CG_GET_BLOWFISHKEY;

        public object Init_MSG_CG_GET_BLOWFISHKEY()
        {
            msg_MSG_CG_GET_BLOWFISHKEY = new MSG_CG_GET_BLOWFISHKEY();
            return msg_MSG_CG_GET_BLOWFISHKEY;
        }
        public object Get_MSG_CG_GET_BLOWFISHKEY()
        {
            return msg_MSG_CG_GET_BLOWFISHKEY;
        }
        public object New_MSG_CG_GET_BLOWFISHKEY()
        {
            return msg_MSG_CG_GET_BLOWFISHKEY;
        }
        public void OnResponse_MSG_CG_GET_BLOWFISHKEY(MemoryStream stream)
        {
            MSG_CG_GET_BLOWFISHKEY MSG_CG_GET_BLOWFISHKEY = ProtoBuf.Serializer.Deserialize<MSG_CG_GET_BLOWFISHKEY>(stream);
            Parser.Parse(MSG_CG_GET_BLOWFISHKEY);
        }
        public object Deserialize_MSG_CG_GET_BLOWFISHKEY(MemoryStream stream)
        {
            return ProtoBuf.Serializer.Deserialize<MSG_CG_GET_BLOWFISHKEY>(stream);
        }

        MSG_CG_SUGGEST msg_MSG_CG_SUGGEST;

        public object Init_MSG_CG_SUGGEST()
        {
            msg_MSG_CG_SUGGEST = new MSG_CG_SUGGEST();
            return msg_MSG_CG_SUGGEST;
        }
        public object Get_MSG_CG_SUGGEST()
        {
            return msg_MSG_CG_SUGGEST;
        }
        public object New_MSG_CG_SUGGEST()
        {
            return msg_MSG_CG_SUGGEST;
        }
        public void OnResponse_MSG_CG_SUGGEST(MemoryStream stream)
        {
            MSG_CG_SUGGEST MSG_CG_SUGGEST = ProtoBuf.Serializer.Deserialize<MSG_CG_SUGGEST>(stream);
            Parser.Parse(MSG_CG_SUGGEST);
        }
        public object Deserialize_MSG_CG_SUGGEST(MemoryStream stream)
        {
            return ProtoBuf.Serializer.Deserialize<MSG_CG_SUGGEST>(stream);
        }

        MSG_CG_LOGOUT msg_MSG_CG_LOGOUT;

        public object Init_MSG_CG_LOGOUT()
        {
            msg_MSG_CG_LOGOUT = new MSG_CG_LOGOUT();
            return msg_MSG_CG_LOGOUT;
        }
        public object Get_MSG_CG_LOGOUT()
        {
            return msg_MSG_CG_LOGOUT;
        }
        public object New_MSG_CG_LOGOUT()
        {
            return msg_MSG_CG_LOGOUT;
        }
        public void OnResponse_MSG_CG_LOGOUT(MemoryStream stream)
        {
            MSG_CG_LOGOUT MSG_CG_LOGOUT = ProtoBuf.Serializer.Deserialize<MSG_CG_LOGOUT>(stream);
            Parser.Parse(MSG_CG_LOGOUT);
        }
        public object Deserialize_MSG_CG_LOGOUT(MemoryStream stream)
        {
            return ProtoBuf.Serializer.Deserialize<MSG_CG_LOGOUT>(stream);
        }

        MSG_CG_SAVE_GUIDE_ID msg_MSG_CG_SAVE_GUIDE_ID;

        public object Init_MSG_CG_SAVE_GUIDE_ID()
        {
            msg_MSG_CG_SAVE_GUIDE_ID = new MSG_CG_SAVE_GUIDE_ID();
            return msg_MSG_CG_SAVE_GUIDE_ID;
        }
        public object Get_MSG_CG_SAVE_GUIDE_ID()
        {
            return msg_MSG_CG_SAVE_GUIDE_ID;
        }
        public object New_MSG_CG_SAVE_GUIDE_ID()
        {
            return msg_MSG_CG_SAVE_GUIDE_ID;
        }
        public void OnResponse_MSG_CG_SAVE_GUIDE_ID(MemoryStream stream)
        {
            MSG_CG_SAVE_GUIDE_ID MSG_CG_SAVE_GUIDE_ID = ProtoBuf.Serializer.Deserialize<MSG_CG_SAVE_GUIDE_ID>(stream);
            Parser.Parse(MSG_CG_SAVE_GUIDE_ID);
        }
        public object Deserialize_MSG_CG_SAVE_GUIDE_ID(MemoryStream stream)
        {
            return ProtoBuf.Serializer.Deserialize<MSG_CG_SAVE_GUIDE_ID>(stream);
        }

        MSG_CG_SAVE_MAIN_LINE_ID msg_MSG_CG_SAVE_MAIN_LINE_ID;

        public object Init_MSG_CG_SAVE_MAIN_LINE_ID()
        {
            msg_MSG_CG_SAVE_MAIN_LINE_ID = new MSG_CG_SAVE_MAIN_LINE_ID();
            return msg_MSG_CG_SAVE_MAIN_LINE_ID;
        }
        public object Get_MSG_CG_SAVE_MAIN_LINE_ID()
        {
            return msg_MSG_CG_SAVE_MAIN_LINE_ID;
        }
        public object New_MSG_CG_SAVE_MAIN_LINE_ID()
        {
            return msg_MSG_CG_SAVE_MAIN_LINE_ID;
        }
        public void OnResponse_MSG_CG_SAVE_MAIN_LINE_ID(MemoryStream stream)
        {
            MSG_CG_SAVE_MAIN_LINE_ID MSG_CG_SAVE_MAIN_LINE_ID = ProtoBuf.Serializer.Deserialize<MSG_CG_SAVE_MAIN_LINE_ID>(stream);
            Parser.Parse(MSG_CG_SAVE_MAIN_LINE_ID);
        }
        public object Deserialize_MSG_CG_SAVE_MAIN_LINE_ID(MemoryStream stream)
        {
            return ProtoBuf.Serializer.Deserialize<MSG_CG_SAVE_MAIN_LINE_ID>(stream);
        }

        MSG_CG_SAVE_GAME_COMMENT msg_MSG_CG_SAVE_GAME_COMMENT;

        public object Init_MSG_CG_SAVE_GAME_COMMENT()
        {
            msg_MSG_CG_SAVE_GAME_COMMENT = new MSG_CG_SAVE_GAME_COMMENT();
            return msg_MSG_CG_SAVE_GAME_COMMENT;
        }
        public object Get_MSG_CG_SAVE_GAME_COMMENT()
        {
            return msg_MSG_CG_SAVE_GAME_COMMENT;
        }
        public object New_MSG_CG_SAVE_GAME_COMMENT()
        {
            return msg_MSG_CG_SAVE_GAME_COMMENT;
        }
        public void OnResponse_MSG_CG_SAVE_GAME_COMMENT(MemoryStream stream)
        {
            MSG_CG_SAVE_GAME_COMMENT MSG_CG_SAVE_GAME_COMMENT = ProtoBuf.Serializer.Deserialize<MSG_CG_SAVE_GAME_COMMENT>(stream);
            Parser.Parse(MSG_CG_SAVE_GAME_COMMENT);
        }
        public object Deserialize_MSG_CG_SAVE_GAME_COMMENT(MemoryStream stream)
        {
            return ProtoBuf.Serializer.Deserialize<MSG_CG_SAVE_GAME_COMMENT>(stream);
        }

        MSG_CG_CHANGE_CHANNEL msg_MSG_CG_CHANGE_CHANNEL;

        public object Init_MSG_CG_CHANGE_CHANNEL()
        {
            msg_MSG_CG_CHANGE_CHANNEL = new MSG_CG_CHANGE_CHANNEL();
            return msg_MSG_CG_CHANGE_CHANNEL;
        }
        public object Get_MSG_CG_CHANGE_CHANNEL()
        {
            return msg_MSG_CG_CHANGE_CHANNEL;
        }
        public object New_MSG_CG_CHANGE_CHANNEL()
        {
            return msg_MSG_CG_CHANGE_CHANNEL;
        }
        public void OnResponse_MSG_CG_CHANGE_CHANNEL(MemoryStream stream)
        {
            MSG_CG_CHANGE_CHANNEL MSG_CG_CHANGE_CHANNEL = ProtoBuf.Serializer.Deserialize<MSG_CG_CHANGE_CHANNEL>(stream);
            Parser.Parse(MSG_CG_CHANGE_CHANNEL);
        }
        public object Deserialize_MSG_CG_CHANGE_CHANNEL(MemoryStream stream)
        {
            return ProtoBuf.Serializer.Deserialize<MSG_CG_CHANGE_CHANNEL>(stream);
        }

        MSG_CG_ITEM_USE msg_MSG_CG_ITEM_USE;

        public object Init_MSG_CG_ITEM_USE()
        {
            msg_MSG_CG_ITEM_USE = new MSG_CG_ITEM_USE();
            return msg_MSG_CG_ITEM_USE;
        }
        public object Get_MSG_CG_ITEM_USE()
        {
            return msg_MSG_CG_ITEM_USE;
        }
        public object New_MSG_CG_ITEM_USE()
        {
            return msg_MSG_CG_ITEM_USE;
        }
        public void OnResponse_MSG_CG_ITEM_USE(MemoryStream stream)
        {
            MSG_CG_ITEM_USE MSG_CG_ITEM_USE = ProtoBuf.Serializer.Deserialize<MSG_CG_ITEM_USE>(stream);
            Parser.Parse(MSG_CG_ITEM_USE);
        }
        public object Deserialize_MSG_CG_ITEM_USE(MemoryStream stream)
        {
            return ProtoBuf.Serializer.Deserialize<MSG_CG_ITEM_USE>(stream);
        }

        MSG_CG_ITEM_SELL msg_MSG_CG_ITEM_SELL;

        public object Init_MSG_CG_ITEM_SELL()
        {
            msg_MSG_CG_ITEM_SELL = new MSG_CG_ITEM_SELL();
            return msg_MSG_CG_ITEM_SELL;
        }
        public object Get_MSG_CG_ITEM_SELL()
        {
            return msg_MSG_CG_ITEM_SELL;
        }
        public object New_MSG_CG_ITEM_SELL()
        {
            return msg_MSG_CG_ITEM_SELL;
        }
        public void OnResponse_MSG_CG_ITEM_SELL(MemoryStream stream)
        {
            MSG_CG_ITEM_SELL MSG_CG_ITEM_SELL = ProtoBuf.Serializer.Deserialize<MSG_CG_ITEM_SELL>(stream);
            Parser.Parse(MSG_CG_ITEM_SELL);
        }
        public object Deserialize_MSG_CG_ITEM_SELL(MemoryStream stream)
        {
            return ProtoBuf.Serializer.Deserialize<MSG_CG_ITEM_SELL>(stream);
        }

        MSG_CG_USE_FIREWORKS msg_MSG_CG_USE_FIREWORKS;

        public object Init_MSG_CG_USE_FIREWORKS()
        {
            msg_MSG_CG_USE_FIREWORKS = new MSG_CG_USE_FIREWORKS();
            return msg_MSG_CG_USE_FIREWORKS;
        }
        public object Get_MSG_CG_USE_FIREWORKS()
        {
            return msg_MSG_CG_USE_FIREWORKS;
        }
        public object New_MSG_CG_USE_FIREWORKS()
        {
            return msg_MSG_CG_USE_FIREWORKS;
        }
        public void OnResponse_MSG_CG_USE_FIREWORKS(MemoryStream stream)
        {
            MSG_CG_USE_FIREWORKS MSG_CG_USE_FIREWORKS = ProtoBuf.Serializer.Deserialize<MSG_CG_USE_FIREWORKS>(stream);
            Parser.Parse(MSG_CG_USE_FIREWORKS);
        }
        public object Deserialize_MSG_CG_USE_FIREWORKS(MemoryStream stream)
        {
            return ProtoBuf.Serializer.Deserialize<MSG_CG_USE_FIREWORKS>(stream);
        }

        MSG_CG_EMAIL_READ msg_MSG_CG_EMAIL_READ;

        public object Init_MSG_CG_EMAIL_READ()
        {
            msg_MSG_CG_EMAIL_READ = new MSG_CG_EMAIL_READ();
            return msg_MSG_CG_EMAIL_READ;
        }
        public object Get_MSG_CG_EMAIL_READ()
        {
            return msg_MSG_CG_EMAIL_READ;
        }
        public object New_MSG_CG_EMAIL_READ()
        {
            return msg_MSG_CG_EMAIL_READ;
        }
        public void OnResponse_MSG_CG_EMAIL_READ(MemoryStream stream)
        {
            MSG_CG_EMAIL_READ MSG_CG_EMAIL_READ = ProtoBuf.Serializer.Deserialize<MSG_CG_EMAIL_READ>(stream);
            Parser.Parse(MSG_CG_EMAIL_READ);
        }
        public object Deserialize_MSG_CG_EMAIL_READ(MemoryStream stream)
        {
            return ProtoBuf.Serializer.Deserialize<MSG_CG_EMAIL_READ>(stream);
        }

        MSG_CG_PICKUP_ATTACHMENT msg_MSG_CG_PICKUP_ATTACHMENT;

        public object Init_MSG_CG_PICKUP_ATTACHMENT()
        {
            msg_MSG_CG_PICKUP_ATTACHMENT = new MSG_CG_PICKUP_ATTACHMENT();
            return msg_MSG_CG_PICKUP_ATTACHMENT;
        }
        public object Get_MSG_CG_PICKUP_ATTACHMENT()
        {
            return msg_MSG_CG_PICKUP_ATTACHMENT;
        }
        public object New_MSG_CG_PICKUP_ATTACHMENT()
        {
            return msg_MSG_CG_PICKUP_ATTACHMENT;
        }
        public void OnResponse_MSG_CG_PICKUP_ATTACHMENT(MemoryStream stream)
        {
            MSG_CG_PICKUP_ATTACHMENT MSG_CG_PICKUP_ATTACHMENT = ProtoBuf.Serializer.Deserialize<MSG_CG_PICKUP_ATTACHMENT>(stream);
            Parser.Parse(MSG_CG_PICKUP_ATTACHMENT);
        }
        public object Deserialize_MSG_CG_PICKUP_ATTACHMENT(MemoryStream stream)
        {
            return ProtoBuf.Serializer.Deserialize<MSG_CG_PICKUP_ATTACHMENT>(stream);
        }

        MSG_CG_EMAIL_OPENE_BOX msg_MSG_CG_EMAIL_OPENE_BOX;

        public object Init_MSG_CG_EMAIL_OPENE_BOX()
        {
            msg_MSG_CG_EMAIL_OPENE_BOX = new MSG_CG_EMAIL_OPENE_BOX();
            return msg_MSG_CG_EMAIL_OPENE_BOX;
        }
        public object Get_MSG_CG_EMAIL_OPENE_BOX()
        {
            return msg_MSG_CG_EMAIL_OPENE_BOX;
        }
        public object New_MSG_CG_EMAIL_OPENE_BOX()
        {
            return msg_MSG_CG_EMAIL_OPENE_BOX;
        }
        public void OnResponse_MSG_CG_EMAIL_OPENE_BOX(MemoryStream stream)
        {
            MSG_CG_EMAIL_OPENE_BOX MSG_CG_EMAIL_OPENE_BOX = ProtoBuf.Serializer.Deserialize<MSG_CG_EMAIL_OPENE_BOX>(stream);
            Parser.Parse(MSG_CG_EMAIL_OPENE_BOX);
        }
        public object Deserialize_MSG_CG_EMAIL_OPENE_BOX(MemoryStream stream)
        {
            return ProtoBuf.Serializer.Deserialize<MSG_CG_EMAIL_OPENE_BOX>(stream);
        }

        MSG_CG_SHOP_BUY_ITEM msg_MSG_CG_SHOP_BUY_ITEM;

        public object Init_MSG_CG_SHOP_BUY_ITEM()
        {
            msg_MSG_CG_SHOP_BUY_ITEM = new MSG_CG_SHOP_BUY_ITEM();
            return msg_MSG_CG_SHOP_BUY_ITEM;
        }
        public object Get_MSG_CG_SHOP_BUY_ITEM()
        {
            return msg_MSG_CG_SHOP_BUY_ITEM;
        }
        public object New_MSG_CG_SHOP_BUY_ITEM()
        {
            return msg_MSG_CG_SHOP_BUY_ITEM;
        }
        public void OnResponse_MSG_CG_SHOP_BUY_ITEM(MemoryStream stream)
        {
            MSG_CG_SHOP_BUY_ITEM MSG_CG_SHOP_BUY_ITEM = ProtoBuf.Serializer.Deserialize<MSG_CG_SHOP_BUY_ITEM>(stream);
            Parser.Parse(MSG_CG_SHOP_BUY_ITEM);
        }
        public object Deserialize_MSG_CG_SHOP_BUY_ITEM(MemoryStream stream)
        {
            return ProtoBuf.Serializer.Deserialize<MSG_CG_SHOP_BUY_ITEM>(stream);
        }

        MSG_CG_SHOP_GET_SSR msg_MSG_CG_SHOP_GET_SSR;

        public object Init_MSG_CG_SHOP_GET_SSR()
        {
            msg_MSG_CG_SHOP_GET_SSR = new MSG_CG_SHOP_GET_SSR();
            return msg_MSG_CG_SHOP_GET_SSR;
        }
        public object Get_MSG_CG_SHOP_GET_SSR()
        {
            return msg_MSG_CG_SHOP_GET_SSR;
        }
        public object New_MSG_CG_SHOP_GET_SSR()
        {
            return msg_MSG_CG_SHOP_GET_SSR;
        }
        public void OnResponse_MSG_CG_SHOP_GET_SSR(MemoryStream stream)
        {
            MSG_CG_SHOP_GET_SSR MSG_CG_SHOP_GET_SSR = ProtoBuf.Serializer.Deserialize<MSG_CG_SHOP_GET_SSR>(stream);
            Parser.Parse(MSG_CG_SHOP_GET_SSR);
        }
        public object Deserialize_MSG_CG_SHOP_GET_SSR(MemoryStream stream)
        {
            return ProtoBuf.Serializer.Deserialize<MSG_CG_SHOP_GET_SSR>(stream);
        }

        MSG_CG_REFRESH_SHOP_ITEM msg_MSG_CG_REFRESH_SHOP_ITEM;

        public object Init_MSG_CG_REFRESH_SHOP_ITEM()
        {
            msg_MSG_CG_REFRESH_SHOP_ITEM = new MSG_CG_REFRESH_SHOP_ITEM();
            return msg_MSG_CG_REFRESH_SHOP_ITEM;
        }
        public object Get_MSG_CG_REFRESH_SHOP_ITEM()
        {
            return msg_MSG_CG_REFRESH_SHOP_ITEM;
        }
        public object New_MSG_CG_REFRESH_SHOP_ITEM()
        {
            return msg_MSG_CG_REFRESH_SHOP_ITEM;
        }
        public void OnResponse_MSG_CG_REFRESH_SHOP_ITEM(MemoryStream stream)
        {
            MSG_CG_REFRESH_SHOP_ITEM MSG_CG_REFRESH_SHOP_ITEM = ProtoBuf.Serializer.Deserialize<MSG_CG_REFRESH_SHOP_ITEM>(stream);
            Parser.Parse(MSG_CG_REFRESH_SHOP_ITEM);
        }
        public object Deserialize_MSG_CG_REFRESH_SHOP_ITEM(MemoryStream stream)
        {
            return ProtoBuf.Serializer.Deserialize<MSG_CG_REFRESH_SHOP_ITEM>(stream);
        }

        MSG_CG_CONVERT_FISH_COIN msg_MSG_CG_CONVERT_FISH_COIN;

        public object Init_MSG_CG_CONVERT_FISH_COIN()
        {
            msg_MSG_CG_CONVERT_FISH_COIN = new MSG_CG_CONVERT_FISH_COIN();
            return msg_MSG_CG_CONVERT_FISH_COIN;
        }
        public object Get_MSG_CG_CONVERT_FISH_COIN()
        {
            return msg_MSG_CG_CONVERT_FISH_COIN;
        }
        public object New_MSG_CG_CONVERT_FISH_COIN()
        {
            return msg_MSG_CG_CONVERT_FISH_COIN;
        }
        public void OnResponse_MSG_CG_CONVERT_FISH_COIN(MemoryStream stream)
        {
            MSG_CG_CONVERT_FISH_COIN MSG_CG_CONVERT_FISH_COIN = ProtoBuf.Serializer.Deserialize<MSG_CG_CONVERT_FISH_COIN>(stream);
            Parser.Parse(MSG_CG_CONVERT_FISH_COIN);
        }
        public object Deserialize_MSG_CG_CONVERT_FISH_COIN(MemoryStream stream)
        {
            return ProtoBuf.Serializer.Deserialize<MSG_CG_CONVERT_FISH_COIN>(stream);
        }

        MSG_CG_SAVE_ORDER msg_MSG_CG_SAVE_ORDER;

        public object Init_MSG_CG_SAVE_ORDER()
        {
            msg_MSG_CG_SAVE_ORDER = new MSG_CG_SAVE_ORDER();
            return msg_MSG_CG_SAVE_ORDER;
        }
        public object Get_MSG_CG_SAVE_ORDER()
        {
            return msg_MSG_CG_SAVE_ORDER;
        }
        public object New_MSG_CG_SAVE_ORDER()
        {
            return msg_MSG_CG_SAVE_ORDER;
        }
        public void OnResponse_MSG_CG_SAVE_ORDER(MemoryStream stream)
        {
            MSG_CG_SAVE_ORDER MSG_CG_SAVE_ORDER = ProtoBuf.Serializer.Deserialize<MSG_CG_SAVE_ORDER>(stream);
            Parser.Parse(MSG_CG_SAVE_ORDER);
        }
        public object Deserialize_MSG_CG_SAVE_ORDER(MemoryStream stream)
        {
            return ProtoBuf.Serializer.Deserialize<MSG_CG_SAVE_ORDER>(stream);
        }

        MSG_CG_GET_RECHARGE_HISTORY msg_MSG_CG_GET_RECHARGE_HISTORY;

        public object Init_MSG_CG_GET_RECHARGE_HISTORY()
        {
            msg_MSG_CG_GET_RECHARGE_HISTORY = new MSG_CG_GET_RECHARGE_HISTORY();
            return msg_MSG_CG_GET_RECHARGE_HISTORY;
        }
        public object Get_MSG_CG_GET_RECHARGE_HISTORY()
        {
            return msg_MSG_CG_GET_RECHARGE_HISTORY;
        }
        public object New_MSG_CG_GET_RECHARGE_HISTORY()
        {
            return msg_MSG_CG_GET_RECHARGE_HISTORY;
        }
        public void OnResponse_MSG_CG_GET_RECHARGE_HISTORY(MemoryStream stream)
        {
            MSG_CG_GET_RECHARGE_HISTORY MSG_CG_GET_RECHARGE_HISTORY = ProtoBuf.Serializer.Deserialize<MSG_CG_GET_RECHARGE_HISTORY>(stream);
            Parser.Parse(MSG_CG_GET_RECHARGE_HISTORY);
        }
        public object Deserialize_MSG_CG_GET_RECHARGE_HISTORY(MemoryStream stream)
        {
            return ProtoBuf.Serializer.Deserialize<MSG_CG_GET_RECHARGE_HISTORY>(stream);
        }

        MSG_CG_DELETE_RECHARGE_HISTORY msg_MSG_CG_DELETE_RECHARGE_HISTORY;

        public object Init_MSG_CG_DELETE_RECHARGE_HISTORY()
        {
            msg_MSG_CG_DELETE_RECHARGE_HISTORY = new MSG_CG_DELETE_RECHARGE_HISTORY();
            return msg_MSG_CG_DELETE_RECHARGE_HISTORY;
        }
        public object Get_MSG_CG_DELETE_RECHARGE_HISTORY()
        {
            return msg_MSG_CG_DELETE_RECHARGE_HISTORY;
        }
        public object New_MSG_CG_DELETE_RECHARGE_HISTORY()
        {
            return msg_MSG_CG_DELETE_RECHARGE_HISTORY;
        }
        public void OnResponse_MSG_CG_DELETE_RECHARGE_HISTORY(MemoryStream stream)
        {
            MSG_CG_DELETE_RECHARGE_HISTORY MSG_CG_DELETE_RECHARGE_HISTORY = ProtoBuf.Serializer.Deserialize<MSG_CG_DELETE_RECHARGE_HISTORY>(stream);
            Parser.Parse(MSG_CG_DELETE_RECHARGE_HISTORY);
        }
        public object Deserialize_MSG_CG_DELETE_RECHARGE_HISTORY(MemoryStream stream)
        {
            return ProtoBuf.Serializer.Deserialize<MSG_CG_DELETE_RECHARGE_HISTORY>(stream);
        }

        MSG_CG_FRIEND_SEARCH msg_MSG_CG_FRIEND_SEARCH;

        public object Init_MSG_CG_FRIEND_SEARCH()
        {
            msg_MSG_CG_FRIEND_SEARCH = new MSG_CG_FRIEND_SEARCH();
            return msg_MSG_CG_FRIEND_SEARCH;
        }
        public object Get_MSG_CG_FRIEND_SEARCH()
        {
            return msg_MSG_CG_FRIEND_SEARCH;
        }
        public object New_MSG_CG_FRIEND_SEARCH()
        {
            return msg_MSG_CG_FRIEND_SEARCH;
        }
        public void OnResponse_MSG_CG_FRIEND_SEARCH(MemoryStream stream)
        {
            MSG_CG_FRIEND_SEARCH MSG_CG_FRIEND_SEARCH = ProtoBuf.Serializer.Deserialize<MSG_CG_FRIEND_SEARCH>(stream);
            Parser.Parse(MSG_CG_FRIEND_SEARCH);
        }
        public object Deserialize_MSG_CG_FRIEND_SEARCH(MemoryStream stream)
        {
            return ProtoBuf.Serializer.Deserialize<MSG_CG_FRIEND_SEARCH>(stream);
        }

        MSG_CG_FRIEND_ADD_REQUEST msg_MSG_CG_FRIEND_ADD_REQUEST;

        public object Init_MSG_CG_FRIEND_ADD_REQUEST()
        {
            msg_MSG_CG_FRIEND_ADD_REQUEST = new MSG_CG_FRIEND_ADD_REQUEST();
            return msg_MSG_CG_FRIEND_ADD_REQUEST;
        }
        public object Get_MSG_CG_FRIEND_ADD_REQUEST()
        {
            return msg_MSG_CG_FRIEND_ADD_REQUEST;
        }
        public object New_MSG_CG_FRIEND_ADD_REQUEST()
        {
            return msg_MSG_CG_FRIEND_ADD_REQUEST;
        }
        public void OnResponse_MSG_CG_FRIEND_ADD_REQUEST(MemoryStream stream)
        {
            MSG_CG_FRIEND_ADD_REQUEST MSG_CG_FRIEND_ADD_REQUEST = ProtoBuf.Serializer.Deserialize<MSG_CG_FRIEND_ADD_REQUEST>(stream);
            Parser.Parse(MSG_CG_FRIEND_ADD_REQUEST);
        }
        public object Deserialize_MSG_CG_FRIEND_ADD_REQUEST(MemoryStream stream)
        {
            return ProtoBuf.Serializer.Deserialize<MSG_CG_FRIEND_ADD_REQUEST>(stream);
        }

        MSG_CG_FRIEND_ADD_RESPONSE msg_MSG_CG_FRIEND_ADD_RESPONSE;

        public object Init_MSG_CG_FRIEND_ADD_RESPONSE()
        {
            msg_MSG_CG_FRIEND_ADD_RESPONSE = new MSG_CG_FRIEND_ADD_RESPONSE();
            return msg_MSG_CG_FRIEND_ADD_RESPONSE;
        }
        public object Get_MSG_CG_FRIEND_ADD_RESPONSE()
        {
            return msg_MSG_CG_FRIEND_ADD_RESPONSE;
        }
        public object New_MSG_CG_FRIEND_ADD_RESPONSE()
        {
            return msg_MSG_CG_FRIEND_ADD_RESPONSE;
        }
        public void OnResponse_MSG_CG_FRIEND_ADD_RESPONSE(MemoryStream stream)
        {
            MSG_CG_FRIEND_ADD_RESPONSE MSG_CG_FRIEND_ADD_RESPONSE = ProtoBuf.Serializer.Deserialize<MSG_CG_FRIEND_ADD_RESPONSE>(stream);
            Parser.Parse(MSG_CG_FRIEND_ADD_RESPONSE);
        }
        public object Deserialize_MSG_CG_FRIEND_ADD_RESPONSE(MemoryStream stream)
        {
            return ProtoBuf.Serializer.Deserialize<MSG_CG_FRIEND_ADD_RESPONSE>(stream);
        }

        MSG_CG_FRIEND_DELETE msg_MSG_CG_FRIEND_DELETE;

        public object Init_MSG_CG_FRIEND_DELETE()
        {
            msg_MSG_CG_FRIEND_DELETE = new MSG_CG_FRIEND_DELETE();
            return msg_MSG_CG_FRIEND_DELETE;
        }
        public object Get_MSG_CG_FRIEND_DELETE()
        {
            return msg_MSG_CG_FRIEND_DELETE;
        }
        public object New_MSG_CG_FRIEND_DELETE()
        {
            return msg_MSG_CG_FRIEND_DELETE;
        }
        public void OnResponse_MSG_CG_FRIEND_DELETE(MemoryStream stream)
        {
            MSG_CG_FRIEND_DELETE MSG_CG_FRIEND_DELETE = ProtoBuf.Serializer.Deserialize<MSG_CG_FRIEND_DELETE>(stream);
            Parser.Parse(MSG_CG_FRIEND_DELETE);
        }
        public object Deserialize_MSG_CG_FRIEND_DELETE(MemoryStream stream)
        {
            return ProtoBuf.Serializer.Deserialize<MSG_CG_FRIEND_DELETE>(stream);
        }

        MSG_CG_FRIEND_REQUEST_LIST msg_MSG_CG_FRIEND_REQUEST_LIST;

        public object Init_MSG_CG_FRIEND_REQUEST_LIST()
        {
            msg_MSG_CG_FRIEND_REQUEST_LIST = new MSG_CG_FRIEND_REQUEST_LIST();
            return msg_MSG_CG_FRIEND_REQUEST_LIST;
        }
        public object Get_MSG_CG_FRIEND_REQUEST_LIST()
        {
            return msg_MSG_CG_FRIEND_REQUEST_LIST;
        }
        public object New_MSG_CG_FRIEND_REQUEST_LIST()
        {
            return msg_MSG_CG_FRIEND_REQUEST_LIST;
        }
        public void OnResponse_MSG_CG_FRIEND_REQUEST_LIST(MemoryStream stream)
        {
            MSG_CG_FRIEND_REQUEST_LIST MSG_CG_FRIEND_REQUEST_LIST = ProtoBuf.Serializer.Deserialize<MSG_CG_FRIEND_REQUEST_LIST>(stream);
            Parser.Parse(MSG_CG_FRIEND_REQUEST_LIST);
        }
        public object Deserialize_MSG_CG_FRIEND_REQUEST_LIST(MemoryStream stream)
        {
            return ProtoBuf.Serializer.Deserialize<MSG_CG_FRIEND_REQUEST_LIST>(stream);
        }

        MSG_CG_FRIEND_RECENT_LIST msg_MSG_CG_FRIEND_RECENT_LIST;

        public object Init_MSG_CG_FRIEND_RECENT_LIST()
        {
            msg_MSG_CG_FRIEND_RECENT_LIST = new MSG_CG_FRIEND_RECENT_LIST();
            return msg_MSG_CG_FRIEND_RECENT_LIST;
        }
        public object Get_MSG_CG_FRIEND_RECENT_LIST()
        {
            return msg_MSG_CG_FRIEND_RECENT_LIST;
        }
        public object New_MSG_CG_FRIEND_RECENT_LIST()
        {
            return msg_MSG_CG_FRIEND_RECENT_LIST;
        }
        public void OnResponse_MSG_CG_FRIEND_RECENT_LIST(MemoryStream stream)
        {
            MSG_CG_FRIEND_RECENT_LIST MSG_CG_FRIEND_RECENT_LIST = ProtoBuf.Serializer.Deserialize<MSG_CG_FRIEND_RECENT_LIST>(stream);
            Parser.Parse(MSG_CG_FRIEND_RECENT_LIST);
        }
        public object Deserialize_MSG_CG_FRIEND_RECENT_LIST(MemoryStream stream)
        {
            return ProtoBuf.Serializer.Deserialize<MSG_CG_FRIEND_RECENT_LIST>(stream);
        }

        MSG_CG_FRIEND_BLACK_LIST msg_MSG_CG_FRIEND_BLACK_LIST;

        public object Init_MSG_CG_FRIEND_BLACK_LIST()
        {
            msg_MSG_CG_FRIEND_BLACK_LIST = new MSG_CG_FRIEND_BLACK_LIST();
            return msg_MSG_CG_FRIEND_BLACK_LIST;
        }
        public object Get_MSG_CG_FRIEND_BLACK_LIST()
        {
            return msg_MSG_CG_FRIEND_BLACK_LIST;
        }
        public object New_MSG_CG_FRIEND_BLACK_LIST()
        {
            return msg_MSG_CG_FRIEND_BLACK_LIST;
        }
        public void OnResponse_MSG_CG_FRIEND_BLACK_LIST(MemoryStream stream)
        {
            MSG_CG_FRIEND_BLACK_LIST MSG_CG_FRIEND_BLACK_LIST = ProtoBuf.Serializer.Deserialize<MSG_CG_FRIEND_BLACK_LIST>(stream);
            Parser.Parse(MSG_CG_FRIEND_BLACK_LIST);
        }
        public object Deserialize_MSG_CG_FRIEND_BLACK_LIST(MemoryStream stream)
        {
            return ProtoBuf.Serializer.Deserialize<MSG_CG_FRIEND_BLACK_LIST>(stream);
        }

        MSG_CG_FRIEND_LIST msg_MSG_CG_FRIEND_LIST;

        public object Init_MSG_CG_FRIEND_LIST()
        {
            msg_MSG_CG_FRIEND_LIST = new MSG_CG_FRIEND_LIST();
            return msg_MSG_CG_FRIEND_LIST;
        }
        public object Get_MSG_CG_FRIEND_LIST()
        {
            return msg_MSG_CG_FRIEND_LIST;
        }
        public object New_MSG_CG_FRIEND_LIST()
        {
            return msg_MSG_CG_FRIEND_LIST;
        }
        public void OnResponse_MSG_CG_FRIEND_LIST(MemoryStream stream)
        {
            MSG_CG_FRIEND_LIST MSG_CG_FRIEND_LIST = ProtoBuf.Serializer.Deserialize<MSG_CG_FRIEND_LIST>(stream);
            Parser.Parse(MSG_CG_FRIEND_LIST);
        }
        public object Deserialize_MSG_CG_FRIEND_LIST(MemoryStream stream)
        {
            return ProtoBuf.Serializer.Deserialize<MSG_CG_FRIEND_LIST>(stream);
        }

        MSG_CG_FRIEND_BLACK_ADD msg_MSG_CG_FRIEND_BLACK_ADD;

        public object Init_MSG_CG_FRIEND_BLACK_ADD()
        {
            msg_MSG_CG_FRIEND_BLACK_ADD = new MSG_CG_FRIEND_BLACK_ADD();
            return msg_MSG_CG_FRIEND_BLACK_ADD;
        }
        public object Get_MSG_CG_FRIEND_BLACK_ADD()
        {
            return msg_MSG_CG_FRIEND_BLACK_ADD;
        }
        public object New_MSG_CG_FRIEND_BLACK_ADD()
        {
            return msg_MSG_CG_FRIEND_BLACK_ADD;
        }
        public void OnResponse_MSG_CG_FRIEND_BLACK_ADD(MemoryStream stream)
        {
            MSG_CG_FRIEND_BLACK_ADD MSG_CG_FRIEND_BLACK_ADD = ProtoBuf.Serializer.Deserialize<MSG_CG_FRIEND_BLACK_ADD>(stream);
            Parser.Parse(MSG_CG_FRIEND_BLACK_ADD);
        }
        public object Deserialize_MSG_CG_FRIEND_BLACK_ADD(MemoryStream stream)
        {
            return ProtoBuf.Serializer.Deserialize<MSG_CG_FRIEND_BLACK_ADD>(stream);
        }

        MSG_CG_FRIEND_BLACK_DEL msg_MSG_CG_FRIEND_BLACK_DEL;

        public object Init_MSG_CG_FRIEND_BLACK_DEL()
        {
            msg_MSG_CG_FRIEND_BLACK_DEL = new MSG_CG_FRIEND_BLACK_DEL();
            return msg_MSG_CG_FRIEND_BLACK_DEL;
        }
        public object Get_MSG_CG_FRIEND_BLACK_DEL()
        {
            return msg_MSG_CG_FRIEND_BLACK_DEL;
        }
        public object New_MSG_CG_FRIEND_BLACK_DEL()
        {
            return msg_MSG_CG_FRIEND_BLACK_DEL;
        }
        public void OnResponse_MSG_CG_FRIEND_BLACK_DEL(MemoryStream stream)
        {
            MSG_CG_FRIEND_BLACK_DEL MSG_CG_FRIEND_BLACK_DEL = ProtoBuf.Serializer.Deserialize<MSG_CG_FRIEND_BLACK_DEL>(stream);
            Parser.Parse(MSG_CG_FRIEND_BLACK_DEL);
        }
        public object Deserialize_MSG_CG_FRIEND_BLACK_DEL(MemoryStream stream)
        {
            return ProtoBuf.Serializer.Deserialize<MSG_CG_FRIEND_BLACK_DEL>(stream);
        }

        MSG_CG_FRIEND_RECOMMEND msg_MSG_CG_FRIEND_RECOMMEND;

        public object Init_MSG_CG_FRIEND_RECOMMEND()
        {
            msg_MSG_CG_FRIEND_RECOMMEND = new MSG_CG_FRIEND_RECOMMEND();
            return msg_MSG_CG_FRIEND_RECOMMEND;
        }
        public object Get_MSG_CG_FRIEND_RECOMMEND()
        {
            return msg_MSG_CG_FRIEND_RECOMMEND;
        }
        public object New_MSG_CG_FRIEND_RECOMMEND()
        {
            return msg_MSG_CG_FRIEND_RECOMMEND;
        }
        public void OnResponse_MSG_CG_FRIEND_RECOMMEND(MemoryStream stream)
        {
            MSG_CG_FRIEND_RECOMMEND MSG_CG_FRIEND_RECOMMEND = ProtoBuf.Serializer.Deserialize<MSG_CG_FRIEND_RECOMMEND>(stream);
            Parser.Parse(MSG_CG_FRIEND_RECOMMEND);
        }
        public object Deserialize_MSG_CG_FRIEND_RECOMMEND(MemoryStream stream)
        {
            return ProtoBuf.Serializer.Deserialize<MSG_CG_FRIEND_RECOMMEND>(stream);
        }

        MSG_CG_CREATE_GUILD msg_MSG_CG_CREATE_GUILD;

        public object Init_MSG_CG_CREATE_GUILD()
        {
            msg_MSG_CG_CREATE_GUILD = new MSG_CG_CREATE_GUILD();
            return msg_MSG_CG_CREATE_GUILD;
        }
        public object Get_MSG_CG_CREATE_GUILD()
        {
            return msg_MSG_CG_CREATE_GUILD;
        }
        public object New_MSG_CG_CREATE_GUILD()
        {
            return msg_MSG_CG_CREATE_GUILD;
        }
        public void OnResponse_MSG_CG_CREATE_GUILD(MemoryStream stream)
        {
            MSG_CG_CREATE_GUILD MSG_CG_CREATE_GUILD = ProtoBuf.Serializer.Deserialize<MSG_CG_CREATE_GUILD>(stream);
            Parser.Parse(MSG_CG_CREATE_GUILD);
        }
        public object Deserialize_MSG_CG_CREATE_GUILD(MemoryStream stream)
        {
            return ProtoBuf.Serializer.Deserialize<MSG_CG_CREATE_GUILD>(stream);
        }

        MSG_CG_CHAT_EMOJI msg_MSG_CG_CHAT_EMOJI;

        public object Init_MSG_CG_CHAT_EMOJI()
        {
            msg_MSG_CG_CHAT_EMOJI = new MSG_CG_CHAT_EMOJI();
            return msg_MSG_CG_CHAT_EMOJI;
        }
        public object Get_MSG_CG_CHAT_EMOJI()
        {
            return msg_MSG_CG_CHAT_EMOJI;
        }
        public object New_MSG_CG_CHAT_EMOJI()
        {
            return msg_MSG_CG_CHAT_EMOJI;
        }
        public void OnResponse_MSG_CG_CHAT_EMOJI(MemoryStream stream)
        {
            MSG_CG_CHAT_EMOJI MSG_CG_CHAT_EMOJI = ProtoBuf.Serializer.Deserialize<MSG_CG_CHAT_EMOJI>(stream);
            Parser.Parse(MSG_CG_CHAT_EMOJI);
        }
        public object Deserialize_MSG_CG_CHAT_EMOJI(MemoryStream stream)
        {
            return ProtoBuf.Serializer.Deserialize<MSG_CG_CHAT_EMOJI>(stream);
        }

        MSG_CG_CHAT_WORDS msg_MSG_CG_CHAT_WORDS;

        public object Init_MSG_CG_CHAT_WORDS()
        {
            msg_MSG_CG_CHAT_WORDS = new MSG_CG_CHAT_WORDS();
            return msg_MSG_CG_CHAT_WORDS;
        }
        public object Get_MSG_CG_CHAT_WORDS()
        {
            return msg_MSG_CG_CHAT_WORDS;
        }
        public object New_MSG_CG_CHAT_WORDS()
        {
            return msg_MSG_CG_CHAT_WORDS;
        }
        public void OnResponse_MSG_CG_CHAT_WORDS(MemoryStream stream)
        {
            MSG_CG_CHAT_WORDS MSG_CG_CHAT_WORDS = ProtoBuf.Serializer.Deserialize<MSG_CG_CHAT_WORDS>(stream);
            Parser.Parse(MSG_CG_CHAT_WORDS);
        }
        public object Deserialize_MSG_CG_CHAT_WORDS(MemoryStream stream)
        {
            return ProtoBuf.Serializer.Deserialize<MSG_CG_CHAT_WORDS>(stream);
        }

        MSG_CG_CHANGE_WORLD_ROOM msg_MSG_CG_CHANGE_WORLD_ROOM;

        public object Init_MSG_CG_CHANGE_WORLD_ROOM()
        {
            msg_MSG_CG_CHANGE_WORLD_ROOM = new MSG_CG_CHANGE_WORLD_ROOM();
            return msg_MSG_CG_CHANGE_WORLD_ROOM;
        }
        public object Get_MSG_CG_CHANGE_WORLD_ROOM()
        {
            return msg_MSG_CG_CHANGE_WORLD_ROOM;
        }
        public object New_MSG_CG_CHANGE_WORLD_ROOM()
        {
            return msg_MSG_CG_CHANGE_WORLD_ROOM;
        }
        public void OnResponse_MSG_CG_CHANGE_WORLD_ROOM(MemoryStream stream)
        {
            MSG_CG_CHANGE_WORLD_ROOM MSG_CG_CHANGE_WORLD_ROOM = ProtoBuf.Serializer.Deserialize<MSG_CG_CHANGE_WORLD_ROOM>(stream);
            Parser.Parse(MSG_CG_CHANGE_WORLD_ROOM);
        }
        public object Deserialize_MSG_CG_CHANGE_WORLD_ROOM(MemoryStream stream)
        {
            return ProtoBuf.Serializer.Deserialize<MSG_CG_CHANGE_WORLD_ROOM>(stream);
        }

        MSG_CG_GET_WORLD_ROOM_LIST msg_MSG_CG_GET_WORLD_ROOM_LIST;

        public object Init_MSG_CG_GET_WORLD_ROOM_LIST()
        {
            msg_MSG_CG_GET_WORLD_ROOM_LIST = new MSG_CG_GET_WORLD_ROOM_LIST();
            return msg_MSG_CG_GET_WORLD_ROOM_LIST;
        }
        public object Get_MSG_CG_GET_WORLD_ROOM_LIST()
        {
            return msg_MSG_CG_GET_WORLD_ROOM_LIST;
        }
        public object New_MSG_CG_GET_WORLD_ROOM_LIST()
        {
            return msg_MSG_CG_GET_WORLD_ROOM_LIST;
        }
        public void OnResponse_MSG_CG_GET_WORLD_ROOM_LIST(MemoryStream stream)
        {
            MSG_CG_GET_WORLD_ROOM_LIST MSG_CG_GET_WORLD_ROOM_LIST = ProtoBuf.Serializer.Deserialize<MSG_CG_GET_WORLD_ROOM_LIST>(stream);
            Parser.Parse(MSG_CG_GET_WORLD_ROOM_LIST);
        }
        public object Deserialize_MSG_CG_GET_WORLD_ROOM_LIST(MemoryStream stream)
        {
            return ProtoBuf.Serializer.Deserialize<MSG_CG_GET_WORLD_ROOM_LIST>(stream);
        }

        MSG_CG_CHAT_TRUMPET msg_MSG_CG_CHAT_TRUMPET;

        public object Init_MSG_CG_CHAT_TRUMPET()
        {
            msg_MSG_CG_CHAT_TRUMPET = new MSG_CG_CHAT_TRUMPET();
            return msg_MSG_CG_CHAT_TRUMPET;
        }
        public object Get_MSG_CG_CHAT_TRUMPET()
        {
            return msg_MSG_CG_CHAT_TRUMPET;
        }
        public object New_MSG_CG_CHAT_TRUMPET()
        {
            return msg_MSG_CG_CHAT_TRUMPET;
        }
        public void OnResponse_MSG_CG_CHAT_TRUMPET(MemoryStream stream)
        {
            MSG_CG_CHAT_TRUMPET MSG_CG_CHAT_TRUMPET = ProtoBuf.Serializer.Deserialize<MSG_CG_CHAT_TRUMPET>(stream);
            Parser.Parse(MSG_CG_CHAT_TRUMPET);
        }
        public object Deserialize_MSG_CG_CHAT_TRUMPET(MemoryStream stream)
        {
            return ProtoBuf.Serializer.Deserialize<MSG_CG_CHAT_TRUMPET>(stream);
        }

        MSG_CG_CHAT_REPORT msg_MSG_CG_CHAT_REPORT;

        public object Init_MSG_CG_CHAT_REPORT()
        {
            msg_MSG_CG_CHAT_REPORT = new MSG_CG_CHAT_REPORT();
            return msg_MSG_CG_CHAT_REPORT;
        }
        public object Get_MSG_CG_CHAT_REPORT()
        {
            return msg_MSG_CG_CHAT_REPORT;
        }
        public object New_MSG_CG_CHAT_REPORT()
        {
            return msg_MSG_CG_CHAT_REPORT;
        }
        public void OnResponse_MSG_CG_CHAT_REPORT(MemoryStream stream)
        {
            MSG_CG_CHAT_REPORT MSG_CG_CHAT_REPORT = ProtoBuf.Serializer.Deserialize<MSG_CG_CHAT_REPORT>(stream);
            Parser.Parse(MSG_CG_CHAT_REPORT);
        }
        public object Deserialize_MSG_CG_CHAT_REPORT(MemoryStream stream)
        {
            return ProtoBuf.Serializer.Deserialize<MSG_CG_CHAT_REPORT>(stream);
        }

        MSG_CG_NEARBY_EMOJI msg_MSG_CG_NEARBY_EMOJI;

        public object Init_MSG_CG_NEARBY_EMOJI()
        {
            msg_MSG_CG_NEARBY_EMOJI = new MSG_CG_NEARBY_EMOJI();
            return msg_MSG_CG_NEARBY_EMOJI;
        }
        public object Get_MSG_CG_NEARBY_EMOJI()
        {
            return msg_MSG_CG_NEARBY_EMOJI;
        }
        public object New_MSG_CG_NEARBY_EMOJI()
        {
            return msg_MSG_CG_NEARBY_EMOJI;
        }
        public void OnResponse_MSG_CG_NEARBY_EMOJI(MemoryStream stream)
        {
            MSG_CG_NEARBY_EMOJI MSG_CG_NEARBY_EMOJI = ProtoBuf.Serializer.Deserialize<MSG_CG_NEARBY_EMOJI>(stream);
            Parser.Parse(MSG_CG_NEARBY_EMOJI);
        }
        public object Deserialize_MSG_CG_NEARBY_EMOJI(MemoryStream stream)
        {
            return ProtoBuf.Serializer.Deserialize<MSG_CG_NEARBY_EMOJI>(stream);
        }

        MSG_CG_TIP_OFF msg_MSG_CG_TIP_OFF;

        public object Init_MSG_CG_TIP_OFF()
        {
            msg_MSG_CG_TIP_OFF = new MSG_CG_TIP_OFF();
            return msg_MSG_CG_TIP_OFF;
        }
        public object Get_MSG_CG_TIP_OFF()
        {
            return msg_MSG_CG_TIP_OFF;
        }
        public object New_MSG_CG_TIP_OFF()
        {
            return msg_MSG_CG_TIP_OFF;
        }
        public void OnResponse_MSG_CG_TIP_OFF(MemoryStream stream)
        {
            MSG_CG_TIP_OFF MSG_CG_TIP_OFF = ProtoBuf.Serializer.Deserialize<MSG_CG_TIP_OFF>(stream);
            Parser.Parse(MSG_CG_TIP_OFF);
        }
        public object Deserialize_MSG_CG_TIP_OFF(MemoryStream stream)
        {
            return ProtoBuf.Serializer.Deserialize<MSG_CG_TIP_OFF>(stream);
        }

        MSG_CG_ACTIVITY_CHAT_BUBBLE msg_MSG_CG_ACTIVITY_CHAT_BUBBLE;

        public object Init_MSG_CG_ACTIVITY_CHAT_BUBBLE()
        {
            msg_MSG_CG_ACTIVITY_CHAT_BUBBLE = new MSG_CG_ACTIVITY_CHAT_BUBBLE();
            return msg_MSG_CG_ACTIVITY_CHAT_BUBBLE;
        }
        public object Get_MSG_CG_ACTIVITY_CHAT_BUBBLE()
        {
            return msg_MSG_CG_ACTIVITY_CHAT_BUBBLE;
        }
        public object New_MSG_CG_ACTIVITY_CHAT_BUBBLE()
        {
            return msg_MSG_CG_ACTIVITY_CHAT_BUBBLE;
        }
        public void OnResponse_MSG_CG_ACTIVITY_CHAT_BUBBLE(MemoryStream stream)
        {
            MSG_CG_ACTIVITY_CHAT_BUBBLE MSG_CG_ACTIVITY_CHAT_BUBBLE = ProtoBuf.Serializer.Deserialize<MSG_CG_ACTIVITY_CHAT_BUBBLE>(stream);
            Parser.Parse(MSG_CG_ACTIVITY_CHAT_BUBBLE);
        }
        public object Deserialize_MSG_CG_ACTIVITY_CHAT_BUBBLE(MemoryStream stream)
        {
            return ProtoBuf.Serializer.Deserialize<MSG_CG_ACTIVITY_CHAT_BUBBLE>(stream);
        }

        MSG_CG_USE_CHAT_TRUMPET msg_MSG_CG_USE_CHAT_TRUMPET;

        public object Init_MSG_CG_USE_CHAT_TRUMPET()
        {
            msg_MSG_CG_USE_CHAT_TRUMPET = new MSG_CG_USE_CHAT_TRUMPET();
            return msg_MSG_CG_USE_CHAT_TRUMPET;
        }
        public object Get_MSG_CG_USE_CHAT_TRUMPET()
        {
            return msg_MSG_CG_USE_CHAT_TRUMPET;
        }
        public object New_MSG_CG_USE_CHAT_TRUMPET()
        {
            return msg_MSG_CG_USE_CHAT_TRUMPET;
        }
        public void OnResponse_MSG_CG_USE_CHAT_TRUMPET(MemoryStream stream)
        {
            MSG_CG_USE_CHAT_TRUMPET MSG_CG_USE_CHAT_TRUMPET = ProtoBuf.Serializer.Deserialize<MSG_CG_USE_CHAT_TRUMPET>(stream);
            Parser.Parse(MSG_CG_USE_CHAT_TRUMPET);
        }
        public object Deserialize_MSG_CG_USE_CHAT_TRUMPET(MemoryStream stream)
        {
            return ProtoBuf.Serializer.Deserialize<MSG_CG_USE_CHAT_TRUMPET>(stream);
        }

        MSG_CG_TASK_COMPLETE msg_MSG_CG_TASK_COMPLETE;

        public object Init_MSG_CG_TASK_COMPLETE()
        {
            msg_MSG_CG_TASK_COMPLETE = new MSG_CG_TASK_COMPLETE();
            return msg_MSG_CG_TASK_COMPLETE;
        }
        public object Get_MSG_CG_TASK_COMPLETE()
        {
            return msg_MSG_CG_TASK_COMPLETE;
        }
        public object New_MSG_CG_TASK_COMPLETE()
        {
            return msg_MSG_CG_TASK_COMPLETE;
        }
        public void OnResponse_MSG_CG_TASK_COMPLETE(MemoryStream stream)
        {
            MSG_CG_TASK_COMPLETE MSG_CG_TASK_COMPLETE = ProtoBuf.Serializer.Deserialize<MSG_CG_TASK_COMPLETE>(stream);
            Parser.Parse(MSG_CG_TASK_COMPLETE);
        }
        public object Deserialize_MSG_CG_TASK_COMPLETE(MemoryStream stream)
        {
            return ProtoBuf.Serializer.Deserialize<MSG_CG_TASK_COMPLETE>(stream);
        }

        MSG_CG_OPENE_EMAIL_TASK msg_MSG_CG_OPENE_EMAIL_TASK;

        public object Init_MSG_CG_OPENE_EMAIL_TASK()
        {
            msg_MSG_CG_OPENE_EMAIL_TASK = new MSG_CG_OPENE_EMAIL_TASK();
            return msg_MSG_CG_OPENE_EMAIL_TASK;
        }
        public object Get_MSG_CG_OPENE_EMAIL_TASK()
        {
            return msg_MSG_CG_OPENE_EMAIL_TASK;
        }
        public object New_MSG_CG_OPENE_EMAIL_TASK()
        {
            return msg_MSG_CG_OPENE_EMAIL_TASK;
        }
        public void OnResponse_MSG_CG_OPENE_EMAIL_TASK(MemoryStream stream)
        {
            MSG_CG_OPENE_EMAIL_TASK MSG_CG_OPENE_EMAIL_TASK = ProtoBuf.Serializer.Deserialize<MSG_CG_OPENE_EMAIL_TASK>(stream);
            Parser.Parse(MSG_CG_OPENE_EMAIL_TASK);
        }
        public object Deserialize_MSG_CG_OPENE_EMAIL_TASK(MemoryStream stream)
        {
            return ProtoBuf.Serializer.Deserialize<MSG_CG_OPENE_EMAIL_TASK>(stream);
        }

        MSG_CG_TASK_COLLECT msg_MSG_CG_TASK_COLLECT;

        public object Init_MSG_CG_TASK_COLLECT()
        {
            msg_MSG_CG_TASK_COLLECT = new MSG_CG_TASK_COLLECT();
            return msg_MSG_CG_TASK_COLLECT;
        }
        public object Get_MSG_CG_TASK_COLLECT()
        {
            return msg_MSG_CG_TASK_COLLECT;
        }
        public object New_MSG_CG_TASK_COLLECT()
        {
            return msg_MSG_CG_TASK_COLLECT;
        }
        public void OnResponse_MSG_CG_TASK_COLLECT(MemoryStream stream)
        {
            MSG_CG_TASK_COLLECT MSG_CG_TASK_COLLECT = ProtoBuf.Serializer.Deserialize<MSG_CG_TASK_COLLECT>(stream);
            Parser.Parse(MSG_CG_TASK_COLLECT);
        }
        public object Deserialize_MSG_CG_TASK_COLLECT(MemoryStream stream)
        {
            return ProtoBuf.Serializer.Deserialize<MSG_CG_TASK_COLLECT>(stream);
        }

        MSG_CG_TASK_SELECT msg_MSG_CG_TASK_SELECT;

        public object Init_MSG_CG_TASK_SELECT()
        {
            msg_MSG_CG_TASK_SELECT = new MSG_CG_TASK_SELECT();
            return msg_MSG_CG_TASK_SELECT;
        }
        public object Get_MSG_CG_TASK_SELECT()
        {
            return msg_MSG_CG_TASK_SELECT;
        }
        public object New_MSG_CG_TASK_SELECT()
        {
            return msg_MSG_CG_TASK_SELECT;
        }
        public void OnResponse_MSG_CG_TASK_SELECT(MemoryStream stream)
        {
            MSG_CG_TASK_SELECT MSG_CG_TASK_SELECT = ProtoBuf.Serializer.Deserialize<MSG_CG_TASK_SELECT>(stream);
            Parser.Parse(MSG_CG_TASK_SELECT);
        }
        public object Deserialize_MSG_CG_TASK_SELECT(MemoryStream stream)
        {
            return ProtoBuf.Serializer.Deserialize<MSG_CG_TASK_SELECT>(stream);
        }

        MSG_CG_TASK_MAKE msg_MSG_CG_TASK_MAKE;

        public object Init_MSG_CG_TASK_MAKE()
        {
            msg_MSG_CG_TASK_MAKE = new MSG_CG_TASK_MAKE();
            return msg_MSG_CG_TASK_MAKE;
        }
        public object Get_MSG_CG_TASK_MAKE()
        {
            return msg_MSG_CG_TASK_MAKE;
        }
        public object New_MSG_CG_TASK_MAKE()
        {
            return msg_MSG_CG_TASK_MAKE;
        }
        public void OnResponse_MSG_CG_TASK_MAKE(MemoryStream stream)
        {
            MSG_CG_TASK_MAKE MSG_CG_TASK_MAKE = ProtoBuf.Serializer.Deserialize<MSG_CG_TASK_MAKE>(stream);
            Parser.Parse(MSG_CG_TASK_MAKE);
        }
        public object Deserialize_MSG_CG_TASK_MAKE(MemoryStream stream)
        {
            return ProtoBuf.Serializer.Deserialize<MSG_CG_TASK_MAKE>(stream);
        }

        MSG_CG_TASKFLY_FLY_DONE msg_MSG_CG_TASKFLY_FLY_DONE;

        public object Init_MSG_CG_TASKFLY_FLY_DONE()
        {
            msg_MSG_CG_TASKFLY_FLY_DONE = new MSG_CG_TASKFLY_FLY_DONE();
            return msg_MSG_CG_TASKFLY_FLY_DONE;
        }
        public object Get_MSG_CG_TASKFLY_FLY_DONE()
        {
            return msg_MSG_CG_TASKFLY_FLY_DONE;
        }
        public object New_MSG_CG_TASKFLY_FLY_DONE()
        {
            return msg_MSG_CG_TASKFLY_FLY_DONE;
        }
        public void OnResponse_MSG_CG_TASKFLY_FLY_DONE(MemoryStream stream)
        {
            MSG_CG_TASKFLY_FLY_DONE MSG_CG_TASKFLY_FLY_DONE = ProtoBuf.Serializer.Deserialize<MSG_CG_TASKFLY_FLY_DONE>(stream);
            Parser.Parse(MSG_CG_TASKFLY_FLY_DONE);
        }
        public object Deserialize_MSG_CG_TASKFLY_FLY_DONE(MemoryStream stream)
        {
            return ProtoBuf.Serializer.Deserialize<MSG_CG_TASKFLY_FLY_DONE>(stream);
        }

        MSG_CG_TASKFLY_STARTPATHFINDING msg_MSG_CG_TASKFLY_STARTPATHFINDING;

        public object Init_MSG_CG_TASKFLY_STARTPATHFINDING()
        {
            msg_MSG_CG_TASKFLY_STARTPATHFINDING = new MSG_CG_TASKFLY_STARTPATHFINDING();
            return msg_MSG_CG_TASKFLY_STARTPATHFINDING;
        }
        public object Get_MSG_CG_TASKFLY_STARTPATHFINDING()
        {
            return msg_MSG_CG_TASKFLY_STARTPATHFINDING;
        }
        public object New_MSG_CG_TASKFLY_STARTPATHFINDING()
        {
            return msg_MSG_CG_TASKFLY_STARTPATHFINDING;
        }
        public void OnResponse_MSG_CG_TASKFLY_STARTPATHFINDING(MemoryStream stream)
        {
            MSG_CG_TASKFLY_STARTPATHFINDING MSG_CG_TASKFLY_STARTPATHFINDING = ProtoBuf.Serializer.Deserialize<MSG_CG_TASKFLY_STARTPATHFINDING>(stream);
            Parser.Parse(MSG_CG_TASKFLY_STARTPATHFINDING);
        }
        public object Deserialize_MSG_CG_TASKFLY_STARTPATHFINDING(MemoryStream stream)
        {
            return ProtoBuf.Serializer.Deserialize<MSG_CG_TASKFLY_STARTPATHFINDING>(stream);
        }

        MSG_CG_ACTIVITY_COMPLETE msg_MSG_CG_ACTIVITY_COMPLETE;

        public object Init_MSG_CG_ACTIVITY_COMPLETE()
        {
            msg_MSG_CG_ACTIVITY_COMPLETE = new MSG_CG_ACTIVITY_COMPLETE();
            return msg_MSG_CG_ACTIVITY_COMPLETE;
        }
        public object Get_MSG_CG_ACTIVITY_COMPLETE()
        {
            return msg_MSG_CG_ACTIVITY_COMPLETE;
        }
        public object New_MSG_CG_ACTIVITY_COMPLETE()
        {
            return msg_MSG_CG_ACTIVITY_COMPLETE;
        }
        public void OnResponse_MSG_CG_ACTIVITY_COMPLETE(MemoryStream stream)
        {
            MSG_CG_ACTIVITY_COMPLETE MSG_CG_ACTIVITY_COMPLETE = ProtoBuf.Serializer.Deserialize<MSG_CG_ACTIVITY_COMPLETE>(stream);
            Parser.Parse(MSG_CG_ACTIVITY_COMPLETE);
        }
        public object Deserialize_MSG_CG_ACTIVITY_COMPLETE(MemoryStream stream)
        {
            return ProtoBuf.Serializer.Deserialize<MSG_CG_ACTIVITY_COMPLETE>(stream);
        }

        MSG_CG_SHOW_CHARACTER msg_MSG_CG_SHOW_CHARACTER;

        public object Init_MSG_CG_SHOW_CHARACTER()
        {
            msg_MSG_CG_SHOW_CHARACTER = new MSG_CG_SHOW_CHARACTER();
            return msg_MSG_CG_SHOW_CHARACTER;
        }
        public object Get_MSG_CG_SHOW_CHARACTER()
        {
            return msg_MSG_CG_SHOW_CHARACTER;
        }
        public object New_MSG_CG_SHOW_CHARACTER()
        {
            return msg_MSG_CG_SHOW_CHARACTER;
        }
        public void OnResponse_MSG_CG_SHOW_CHARACTER(MemoryStream stream)
        {
            MSG_CG_SHOW_CHARACTER MSG_CG_SHOW_CHARACTER = ProtoBuf.Serializer.Deserialize<MSG_CG_SHOW_CHARACTER>(stream);
            Parser.Parse(MSG_CG_SHOW_CHARACTER);
        }
        public object Deserialize_MSG_CG_SHOW_CHARACTER(MemoryStream stream)
        {
            return ProtoBuf.Serializer.Deserialize<MSG_CG_SHOW_CHARACTER>(stream);
        }

        MSG_CG_CHANGE_NAME msg_MSG_CG_CHANGE_NAME;

        public object Init_MSG_CG_CHANGE_NAME()
        {
            msg_MSG_CG_CHANGE_NAME = new MSG_CG_CHANGE_NAME();
            return msg_MSG_CG_CHANGE_NAME;
        }
        public object Get_MSG_CG_CHANGE_NAME()
        {
            return msg_MSG_CG_CHANGE_NAME;
        }
        public object New_MSG_CG_CHANGE_NAME()
        {
            return msg_MSG_CG_CHANGE_NAME;
        }
        public void OnResponse_MSG_CG_CHANGE_NAME(MemoryStream stream)
        {
            MSG_CG_CHANGE_NAME MSG_CG_CHANGE_NAME = ProtoBuf.Serializer.Deserialize<MSG_CG_CHANGE_NAME>(stream);
            Parser.Parse(MSG_CG_CHANGE_NAME);
        }
        public object Deserialize_MSG_CG_CHANGE_NAME(MemoryStream stream)
        {
            return ProtoBuf.Serializer.Deserialize<MSG_CG_CHANGE_NAME>(stream);
        }

        MSG_CG_SHOW_FACEICON msg_MSG_CG_SHOW_FACEICON;

        public object Init_MSG_CG_SHOW_FACEICON()
        {
            msg_MSG_CG_SHOW_FACEICON = new MSG_CG_SHOW_FACEICON();
            return msg_MSG_CG_SHOW_FACEICON;
        }
        public object Get_MSG_CG_SHOW_FACEICON()
        {
            return msg_MSG_CG_SHOW_FACEICON;
        }
        public object New_MSG_CG_SHOW_FACEICON()
        {
            return msg_MSG_CG_SHOW_FACEICON;
        }
        public void OnResponse_MSG_CG_SHOW_FACEICON(MemoryStream stream)
        {
            MSG_CG_SHOW_FACEICON MSG_CG_SHOW_FACEICON = ProtoBuf.Serializer.Deserialize<MSG_CG_SHOW_FACEICON>(stream);
            Parser.Parse(MSG_CG_SHOW_FACEICON);
        }
        public object Deserialize_MSG_CG_SHOW_FACEICON(MemoryStream stream)
        {
            return ProtoBuf.Serializer.Deserialize<MSG_CG_SHOW_FACEICON>(stream);
        }

        MSG_CG_SHOW_FACEJPG msg_MSG_CG_SHOW_FACEJPG;

        public object Init_MSG_CG_SHOW_FACEJPG()
        {
            msg_MSG_CG_SHOW_FACEJPG = new MSG_CG_SHOW_FACEJPG();
            return msg_MSG_CG_SHOW_FACEJPG;
        }
        public object Get_MSG_CG_SHOW_FACEJPG()
        {
            return msg_MSG_CG_SHOW_FACEJPG;
        }
        public object New_MSG_CG_SHOW_FACEJPG()
        {
            return msg_MSG_CG_SHOW_FACEJPG;
        }
        public void OnResponse_MSG_CG_SHOW_FACEJPG(MemoryStream stream)
        {
            MSG_CG_SHOW_FACEJPG MSG_CG_SHOW_FACEJPG = ProtoBuf.Serializer.Deserialize<MSG_CG_SHOW_FACEJPG>(stream);
            Parser.Parse(MSG_CG_SHOW_FACEJPG);
        }
        public object Deserialize_MSG_CG_SHOW_FACEJPG(MemoryStream stream)
        {
            return ProtoBuf.Serializer.Deserialize<MSG_CG_SHOW_FACEJPG>(stream);
        }

        MSG_CG_SET_SEX msg_MSG_CG_SET_SEX;

        public object Init_MSG_CG_SET_SEX()
        {
            msg_MSG_CG_SET_SEX = new MSG_CG_SET_SEX();
            return msg_MSG_CG_SET_SEX;
        }
        public object Get_MSG_CG_SET_SEX()
        {
            return msg_MSG_CG_SET_SEX;
        }
        public object New_MSG_CG_SET_SEX()
        {
            return msg_MSG_CG_SET_SEX;
        }
        public void OnResponse_MSG_CG_SET_SEX(MemoryStream stream)
        {
            MSG_CG_SET_SEX MSG_CG_SET_SEX = ProtoBuf.Serializer.Deserialize<MSG_CG_SET_SEX>(stream);
            Parser.Parse(MSG_CG_SET_SEX);
        }
        public object Deserialize_MSG_CG_SET_SEX(MemoryStream stream)
        {
            return ProtoBuf.Serializer.Deserialize<MSG_CG_SET_SEX>(stream);
        }

        MSG_CG_SET_BIRTHDAY msg_MSG_CG_SET_BIRTHDAY;

        public object Init_MSG_CG_SET_BIRTHDAY()
        {
            msg_MSG_CG_SET_BIRTHDAY = new MSG_CG_SET_BIRTHDAY();
            return msg_MSG_CG_SET_BIRTHDAY;
        }
        public object Get_MSG_CG_SET_BIRTHDAY()
        {
            return msg_MSG_CG_SET_BIRTHDAY;
        }
        public object New_MSG_CG_SET_BIRTHDAY()
        {
            return msg_MSG_CG_SET_BIRTHDAY;
        }
        public void OnResponse_MSG_CG_SET_BIRTHDAY(MemoryStream stream)
        {
            MSG_CG_SET_BIRTHDAY MSG_CG_SET_BIRTHDAY = ProtoBuf.Serializer.Deserialize<MSG_CG_SET_BIRTHDAY>(stream);
            Parser.Parse(MSG_CG_SET_BIRTHDAY);
        }
        public object Deserialize_MSG_CG_SET_BIRTHDAY(MemoryStream stream)
        {
            return ProtoBuf.Serializer.Deserialize<MSG_CG_SET_BIRTHDAY>(stream);
        }

        MSG_CG_SET_SIGNATURE msg_MSG_CG_SET_SIGNATURE;

        public object Init_MSG_CG_SET_SIGNATURE()
        {
            msg_MSG_CG_SET_SIGNATURE = new MSG_CG_SET_SIGNATURE();
            return msg_MSG_CG_SET_SIGNATURE;
        }
        public object Get_MSG_CG_SET_SIGNATURE()
        {
            return msg_MSG_CG_SET_SIGNATURE;
        }
        public object New_MSG_CG_SET_SIGNATURE()
        {
            return msg_MSG_CG_SET_SIGNATURE;
        }
        public void OnResponse_MSG_CG_SET_SIGNATURE(MemoryStream stream)
        {
            MSG_CG_SET_SIGNATURE MSG_CG_SET_SIGNATURE = ProtoBuf.Serializer.Deserialize<MSG_CG_SET_SIGNATURE>(stream);
            Parser.Parse(MSG_CG_SET_SIGNATURE);
        }
        public object Deserialize_MSG_CG_SET_SIGNATURE(MemoryStream stream)
        {
            return ProtoBuf.Serializer.Deserialize<MSG_CG_SET_SIGNATURE>(stream);
        }

        MSG_CG_SHOW_VOICE msg_MSG_CG_SHOW_VOICE;

        public object Init_MSG_CG_SHOW_VOICE()
        {
            msg_MSG_CG_SHOW_VOICE = new MSG_CG_SHOW_VOICE();
            return msg_MSG_CG_SHOW_VOICE;
        }
        public object Get_MSG_CG_SHOW_VOICE()
        {
            return msg_MSG_CG_SHOW_VOICE;
        }
        public object New_MSG_CG_SHOW_VOICE()
        {
            return msg_MSG_CG_SHOW_VOICE;
        }
        public void OnResponse_MSG_CG_SHOW_VOICE(MemoryStream stream)
        {
            MSG_CG_SHOW_VOICE MSG_CG_SHOW_VOICE = ProtoBuf.Serializer.Deserialize<MSG_CG_SHOW_VOICE>(stream);
            Parser.Parse(MSG_CG_SHOW_VOICE);
        }
        public object Deserialize_MSG_CG_SHOW_VOICE(MemoryStream stream)
        {
            return ProtoBuf.Serializer.Deserialize<MSG_CG_SHOW_VOICE>(stream);
        }

        MSG_CG_PRESENT_GIFT msg_MSG_CG_PRESENT_GIFT;

        public object Init_MSG_CG_PRESENT_GIFT()
        {
            msg_MSG_CG_PRESENT_GIFT = new MSG_CG_PRESENT_GIFT();
            return msg_MSG_CG_PRESENT_GIFT;
        }
        public object Get_MSG_CG_PRESENT_GIFT()
        {
            return msg_MSG_CG_PRESENT_GIFT;
        }
        public object New_MSG_CG_PRESENT_GIFT()
        {
            return msg_MSG_CG_PRESENT_GIFT;
        }
        public void OnResponse_MSG_CG_PRESENT_GIFT(MemoryStream stream)
        {
            MSG_CG_PRESENT_GIFT MSG_CG_PRESENT_GIFT = ProtoBuf.Serializer.Deserialize<MSG_CG_PRESENT_GIFT>(stream);
            Parser.Parse(MSG_CG_PRESENT_GIFT);
        }
        public object Deserialize_MSG_CG_PRESENT_GIFT(MemoryStream stream)
        {
            return ProtoBuf.Serializer.Deserialize<MSG_CG_PRESENT_GIFT>(stream);
        }

        MSG_CG_GET_GIFTRECORD msg_MSG_CG_GET_GIFTRECORD;

        public object Init_MSG_CG_GET_GIFTRECORD()
        {
            msg_MSG_CG_GET_GIFTRECORD = new MSG_CG_GET_GIFTRECORD();
            return msg_MSG_CG_GET_GIFTRECORD;
        }
        public object Get_MSG_CG_GET_GIFTRECORD()
        {
            return msg_MSG_CG_GET_GIFTRECORD;
        }
        public object New_MSG_CG_GET_GIFTRECORD()
        {
            return msg_MSG_CG_GET_GIFTRECORD;
        }
        public void OnResponse_MSG_CG_GET_GIFTRECORD(MemoryStream stream)
        {
            MSG_CG_GET_GIFTRECORD MSG_CG_GET_GIFTRECORD = ProtoBuf.Serializer.Deserialize<MSG_CG_GET_GIFTRECORD>(stream);
            Parser.Parse(MSG_CG_GET_GIFTRECORD);
        }
        public object Deserialize_MSG_CG_GET_GIFTRECORD(MemoryStream stream)
        {
            return ProtoBuf.Serializer.Deserialize<MSG_CG_GET_GIFTRECORD>(stream);
        }

        MSG_CG_SET_SOCIAL_NUM msg_MSG_CG_SET_SOCIAL_NUM;

        public object Init_MSG_CG_SET_SOCIAL_NUM()
        {
            msg_MSG_CG_SET_SOCIAL_NUM = new MSG_CG_SET_SOCIAL_NUM();
            return msg_MSG_CG_SET_SOCIAL_NUM;
        }
        public object Get_MSG_CG_SET_SOCIAL_NUM()
        {
            return msg_MSG_CG_SET_SOCIAL_NUM;
        }
        public object New_MSG_CG_SET_SOCIAL_NUM()
        {
            return msg_MSG_CG_SET_SOCIAL_NUM;
        }
        public void OnResponse_MSG_CG_SET_SOCIAL_NUM(MemoryStream stream)
        {
            MSG_CG_SET_SOCIAL_NUM MSG_CG_SET_SOCIAL_NUM = ProtoBuf.Serializer.Deserialize<MSG_CG_SET_SOCIAL_NUM>(stream);
            Parser.Parse(MSG_CG_SET_SOCIAL_NUM);
        }
        public object Deserialize_MSG_CG_SET_SOCIAL_NUM(MemoryStream stream)
        {
            return ProtoBuf.Serializer.Deserialize<MSG_CG_SET_SOCIAL_NUM>(stream);
        }

        MSG_CG_GET_SOCIAL_NUM msg_MSG_CG_GET_SOCIAL_NUM;

        public object Init_MSG_CG_GET_SOCIAL_NUM()
        {
            msg_MSG_CG_GET_SOCIAL_NUM = new MSG_CG_GET_SOCIAL_NUM();
            return msg_MSG_CG_GET_SOCIAL_NUM;
        }
        public object Get_MSG_CG_GET_SOCIAL_NUM()
        {
            return msg_MSG_CG_GET_SOCIAL_NUM;
        }
        public object New_MSG_CG_GET_SOCIAL_NUM()
        {
            return msg_MSG_CG_GET_SOCIAL_NUM;
        }
        public void OnResponse_MSG_CG_GET_SOCIAL_NUM(MemoryStream stream)
        {
            MSG_CG_GET_SOCIAL_NUM MSG_CG_GET_SOCIAL_NUM = ProtoBuf.Serializer.Deserialize<MSG_CG_GET_SOCIAL_NUM>(stream);
            Parser.Parse(MSG_CG_GET_SOCIAL_NUM);
        }
        public object Deserialize_MSG_CG_GET_SOCIAL_NUM(MemoryStream stream)
        {
            return ProtoBuf.Serializer.Deserialize<MSG_CG_GET_SOCIAL_NUM>(stream);
        }

        MSG_CG_SHOW_CAREER msg_MSG_CG_SHOW_CAREER;

        public object Init_MSG_CG_SHOW_CAREER()
        {
            msg_MSG_CG_SHOW_CAREER = new MSG_CG_SHOW_CAREER();
            return msg_MSG_CG_SHOW_CAREER;
        }
        public object Get_MSG_CG_SHOW_CAREER()
        {
            return msg_MSG_CG_SHOW_CAREER;
        }
        public object New_MSG_CG_SHOW_CAREER()
        {
            return msg_MSG_CG_SHOW_CAREER;
        }
        public void OnResponse_MSG_CG_SHOW_CAREER(MemoryStream stream)
        {
            MSG_CG_SHOW_CAREER MSG_CG_SHOW_CAREER = ProtoBuf.Serializer.Deserialize<MSG_CG_SHOW_CAREER>(stream);
            Parser.Parse(MSG_CG_SHOW_CAREER);
        }
        public object Deserialize_MSG_CG_SHOW_CAREER(MemoryStream stream)
        {
            return ProtoBuf.Serializer.Deserialize<MSG_CG_SHOW_CAREER>(stream);
        }

        MSG_CG_GET_RANKING_FRIEND_LIST msg_MSG_CG_GET_RANKING_FRIEND_LIST;

        public object Init_MSG_CG_GET_RANKING_FRIEND_LIST()
        {
            msg_MSG_CG_GET_RANKING_FRIEND_LIST = new MSG_CG_GET_RANKING_FRIEND_LIST();
            return msg_MSG_CG_GET_RANKING_FRIEND_LIST;
        }
        public object Get_MSG_CG_GET_RANKING_FRIEND_LIST()
        {
            return msg_MSG_CG_GET_RANKING_FRIEND_LIST;
        }
        public object New_MSG_CG_GET_RANKING_FRIEND_LIST()
        {
            return msg_MSG_CG_GET_RANKING_FRIEND_LIST;
        }
        public void OnResponse_MSG_CG_GET_RANKING_FRIEND_LIST(MemoryStream stream)
        {
            MSG_CG_GET_RANKING_FRIEND_LIST MSG_CG_GET_RANKING_FRIEND_LIST = ProtoBuf.Serializer.Deserialize<MSG_CG_GET_RANKING_FRIEND_LIST>(stream);
            Parser.Parse(MSG_CG_GET_RANKING_FRIEND_LIST);
        }
        public object Deserialize_MSG_CG_GET_RANKING_FRIEND_LIST(MemoryStream stream)
        {
            return ProtoBuf.Serializer.Deserialize<MSG_CG_GET_RANKING_FRIEND_LIST>(stream);
        }

        MSG_CG_GET_RANKING_ALL_LIST msg_MSG_CG_GET_RANKING_ALL_LIST;

        public object Init_MSG_CG_GET_RANKING_ALL_LIST()
        {
            msg_MSG_CG_GET_RANKING_ALL_LIST = new MSG_CG_GET_RANKING_ALL_LIST();
            return msg_MSG_CG_GET_RANKING_ALL_LIST;
        }
        public object Get_MSG_CG_GET_RANKING_ALL_LIST()
        {
            return msg_MSG_CG_GET_RANKING_ALL_LIST;
        }
        public object New_MSG_CG_GET_RANKING_ALL_LIST()
        {
            return msg_MSG_CG_GET_RANKING_ALL_LIST;
        }
        public void OnResponse_MSG_CG_GET_RANKING_ALL_LIST(MemoryStream stream)
        {
            MSG_CG_GET_RANKING_ALL_LIST MSG_CG_GET_RANKING_ALL_LIST = ProtoBuf.Serializer.Deserialize<MSG_CG_GET_RANKING_ALL_LIST>(stream);
            Parser.Parse(MSG_CG_GET_RANKING_ALL_LIST);
        }
        public object Deserialize_MSG_CG_GET_RANKING_ALL_LIST(MemoryStream stream)
        {
            return ProtoBuf.Serializer.Deserialize<MSG_CG_GET_RANKING_ALL_LIST>(stream);
        }

        MSG_CG_GET_RANKING_NEARBY_LIST msg_MSG_CG_GET_RANKING_NEARBY_LIST;

        public object Init_MSG_CG_GET_RANKING_NEARBY_LIST()
        {
            msg_MSG_CG_GET_RANKING_NEARBY_LIST = new MSG_CG_GET_RANKING_NEARBY_LIST();
            return msg_MSG_CG_GET_RANKING_NEARBY_LIST;
        }
        public object Get_MSG_CG_GET_RANKING_NEARBY_LIST()
        {
            return msg_MSG_CG_GET_RANKING_NEARBY_LIST;
        }
        public object New_MSG_CG_GET_RANKING_NEARBY_LIST()
        {
            return msg_MSG_CG_GET_RANKING_NEARBY_LIST;
        }
        public void OnResponse_MSG_CG_GET_RANKING_NEARBY_LIST(MemoryStream stream)
        {
            MSG_CG_GET_RANKING_NEARBY_LIST MSG_CG_GET_RANKING_NEARBY_LIST = ProtoBuf.Serializer.Deserialize<MSG_CG_GET_RANKING_NEARBY_LIST>(stream);
            Parser.Parse(MSG_CG_GET_RANKING_NEARBY_LIST);
        }
        public object Deserialize_MSG_CG_GET_RANKING_NEARBY_LIST(MemoryStream stream)
        {
            return ProtoBuf.Serializer.Deserialize<MSG_CG_GET_RANKING_NEARBY_LIST>(stream);
        }

        MSG_CG_CHANGE_TITLE msg_MSG_CG_CHANGE_TITLE;

        public object Init_MSG_CG_CHANGE_TITLE()
        {
            msg_MSG_CG_CHANGE_TITLE = new MSG_CG_CHANGE_TITLE();
            return msg_MSG_CG_CHANGE_TITLE;
        }
        public object Get_MSG_CG_CHANGE_TITLE()
        {
            return msg_MSG_CG_CHANGE_TITLE;
        }
        public object New_MSG_CG_CHANGE_TITLE()
        {
            return msg_MSG_CG_CHANGE_TITLE;
        }
        public void OnResponse_MSG_CG_CHANGE_TITLE(MemoryStream stream)
        {
            MSG_CG_CHANGE_TITLE MSG_CG_CHANGE_TITLE = ProtoBuf.Serializer.Deserialize<MSG_CG_CHANGE_TITLE>(stream);
            Parser.Parse(MSG_CG_CHANGE_TITLE);
        }
        public object Deserialize_MSG_CG_CHANGE_TITLE(MemoryStream stream)
        {
            return ProtoBuf.Serializer.Deserialize<MSG_CG_CHANGE_TITLE>(stream);
        }

        MSG_CG_UPLOAD_PHOTO msg_MSG_CG_UPLOAD_PHOTO;

        public object Init_MSG_CG_UPLOAD_PHOTO()
        {
            msg_MSG_CG_UPLOAD_PHOTO = new MSG_CG_UPLOAD_PHOTO();
            return msg_MSG_CG_UPLOAD_PHOTO;
        }
        public object Get_MSG_CG_UPLOAD_PHOTO()
        {
            return msg_MSG_CG_UPLOAD_PHOTO;
        }
        public object New_MSG_CG_UPLOAD_PHOTO()
        {
            return msg_MSG_CG_UPLOAD_PHOTO;
        }
        public void OnResponse_MSG_CG_UPLOAD_PHOTO(MemoryStream stream)
        {
            MSG_CG_UPLOAD_PHOTO MSG_CG_UPLOAD_PHOTO = ProtoBuf.Serializer.Deserialize<MSG_CG_UPLOAD_PHOTO>(stream);
            Parser.Parse(MSG_CG_UPLOAD_PHOTO);
        }
        public object Deserialize_MSG_CG_UPLOAD_PHOTO(MemoryStream stream)
        {
            return ProtoBuf.Serializer.Deserialize<MSG_CG_UPLOAD_PHOTO>(stream);
        }

        MSG_CG_REMOVE_PHOTO msg_MSG_CG_REMOVE_PHOTO;

        public object Init_MSG_CG_REMOVE_PHOTO()
        {
            msg_MSG_CG_REMOVE_PHOTO = new MSG_CG_REMOVE_PHOTO();
            return msg_MSG_CG_REMOVE_PHOTO;
        }
        public object Get_MSG_CG_REMOVE_PHOTO()
        {
            return msg_MSG_CG_REMOVE_PHOTO;
        }
        public object New_MSG_CG_REMOVE_PHOTO()
        {
            return msg_MSG_CG_REMOVE_PHOTO;
        }
        public void OnResponse_MSG_CG_REMOVE_PHOTO(MemoryStream stream)
        {
            MSG_CG_REMOVE_PHOTO MSG_CG_REMOVE_PHOTO = ProtoBuf.Serializer.Deserialize<MSG_CG_REMOVE_PHOTO>(stream);
            Parser.Parse(MSG_CG_REMOVE_PHOTO);
        }
        public object Deserialize_MSG_CG_REMOVE_PHOTO(MemoryStream stream)
        {
            return ProtoBuf.Serializer.Deserialize<MSG_CG_REMOVE_PHOTO>(stream);
        }

        MSG_CG_PHOTO_LIST msg_MSG_CG_PHOTO_LIST;

        public object Init_MSG_CG_PHOTO_LIST()
        {
            msg_MSG_CG_PHOTO_LIST = new MSG_CG_PHOTO_LIST();
            return msg_MSG_CG_PHOTO_LIST;
        }
        public object Get_MSG_CG_PHOTO_LIST()
        {
            return msg_MSG_CG_PHOTO_LIST;
        }
        public object New_MSG_CG_PHOTO_LIST()
        {
            return msg_MSG_CG_PHOTO_LIST;
        }
        public void OnResponse_MSG_CG_PHOTO_LIST(MemoryStream stream)
        {
            MSG_CG_PHOTO_LIST MSG_CG_PHOTO_LIST = ProtoBuf.Serializer.Deserialize<MSG_CG_PHOTO_LIST>(stream);
            Parser.Parse(MSG_CG_PHOTO_LIST);
        }
        public object Deserialize_MSG_CG_PHOTO_LIST(MemoryStream stream)
        {
            return ProtoBuf.Serializer.Deserialize<MSG_CG_PHOTO_LIST>(stream);
        }

        MSG_CG_POP_RANK msg_MSG_CG_POP_RANK;

        public object Init_MSG_CG_POP_RANK()
        {
            msg_MSG_CG_POP_RANK = new MSG_CG_POP_RANK();
            return msg_MSG_CG_POP_RANK;
        }
        public object Get_MSG_CG_POP_RANK()
        {
            return msg_MSG_CG_POP_RANK;
        }
        public object New_MSG_CG_POP_RANK()
        {
            return msg_MSG_CG_POP_RANK;
        }
        public void OnResponse_MSG_CG_POP_RANK(MemoryStream stream)
        {
            MSG_CG_POP_RANK MSG_CG_POP_RANK = ProtoBuf.Serializer.Deserialize<MSG_CG_POP_RANK>(stream);
            Parser.Parse(MSG_CG_POP_RANK);
        }
        public object Deserialize_MSG_CG_POP_RANK(MemoryStream stream)
        {
            return ProtoBuf.Serializer.Deserialize<MSG_CG_POP_RANK>(stream);
        }

        MSG_CG_QUESTION msg_MSG_CG_QUESTION;

        public object Init_MSG_CG_QUESTION()
        {
            msg_MSG_CG_QUESTION = new MSG_CG_QUESTION();
            return msg_MSG_CG_QUESTION;
        }
        public object Get_MSG_CG_QUESTION()
        {
            return msg_MSG_CG_QUESTION;
        }
        public object New_MSG_CG_QUESTION()
        {
            return msg_MSG_CG_QUESTION;
        }
        public void OnResponse_MSG_CG_QUESTION(MemoryStream stream)
        {
            MSG_CG_QUESTION MSG_CG_QUESTION = ProtoBuf.Serializer.Deserialize<MSG_CG_QUESTION>(stream);
            Parser.Parse(MSG_CG_QUESTION);
        }
        public object Deserialize_MSG_CG_QUESTION(MemoryStream stream)
        {
            return ProtoBuf.Serializer.Deserialize<MSG_CG_QUESTION>(stream);
        }

        MSG_CG_QUESTIONNAIRE msg_MSG_CG_QUESTIONNAIRE;

        public object Init_MSG_CG_QUESTIONNAIRE()
        {
            msg_MSG_CG_QUESTIONNAIRE = new MSG_CG_QUESTIONNAIRE();
            return msg_MSG_CG_QUESTIONNAIRE;
        }
        public object Get_MSG_CG_QUESTIONNAIRE()
        {
            return msg_MSG_CG_QUESTIONNAIRE;
        }
        public object New_MSG_CG_QUESTIONNAIRE()
        {
            return msg_MSG_CG_QUESTIONNAIRE;
        }
        public void OnResponse_MSG_CG_QUESTIONNAIRE(MemoryStream stream)
        {
            MSG_CG_QUESTIONNAIRE MSG_CG_QUESTIONNAIRE = ProtoBuf.Serializer.Deserialize<MSG_CG_QUESTIONNAIRE>(stream);
            Parser.Parse(MSG_CG_QUESTIONNAIRE);
        }
        public object Deserialize_MSG_CG_QUESTIONNAIRE(MemoryStream stream)
        {
            return ProtoBuf.Serializer.Deserialize<MSG_CG_QUESTIONNAIRE>(stream);
        }

        MSG_CG_DAILY_QUESTION_COUNTER msg_MSG_CG_DAILY_QUESTION_COUNTER;

        public object Init_MSG_CG_DAILY_QUESTION_COUNTER()
        {
            msg_MSG_CG_DAILY_QUESTION_COUNTER = new MSG_CG_DAILY_QUESTION_COUNTER();
            return msg_MSG_CG_DAILY_QUESTION_COUNTER;
        }
        public object Get_MSG_CG_DAILY_QUESTION_COUNTER()
        {
            return msg_MSG_CG_DAILY_QUESTION_COUNTER;
        }
        public object New_MSG_CG_DAILY_QUESTION_COUNTER()
        {
            return msg_MSG_CG_DAILY_QUESTION_COUNTER;
        }
        public void OnResponse_MSG_CG_DAILY_QUESTION_COUNTER(MemoryStream stream)
        {
            MSG_CG_DAILY_QUESTION_COUNTER MSG_CG_DAILY_QUESTION_COUNTER = ProtoBuf.Serializer.Deserialize<MSG_CG_DAILY_QUESTION_COUNTER>(stream);
            Parser.Parse(MSG_CG_DAILY_QUESTION_COUNTER);
        }
        public object Deserialize_MSG_CG_DAILY_QUESTION_COUNTER(MemoryStream stream)
        {
            return ProtoBuf.Serializer.Deserialize<MSG_CG_DAILY_QUESTION_COUNTER>(stream);
        }

        MSG_CG_DAILY_QUESTION_REWARD msg_MSG_CG_DAILY_QUESTION_REWARD;

        public object Init_MSG_CG_DAILY_QUESTION_REWARD()
        {
            msg_MSG_CG_DAILY_QUESTION_REWARD = new MSG_CG_DAILY_QUESTION_REWARD();
            return msg_MSG_CG_DAILY_QUESTION_REWARD;
        }
        public object Get_MSG_CG_DAILY_QUESTION_REWARD()
        {
            return msg_MSG_CG_DAILY_QUESTION_REWARD;
        }
        public object New_MSG_CG_DAILY_QUESTION_REWARD()
        {
            return msg_MSG_CG_DAILY_QUESTION_REWARD;
        }
        public void OnResponse_MSG_CG_DAILY_QUESTION_REWARD(MemoryStream stream)
        {
            MSG_CG_DAILY_QUESTION_REWARD MSG_CG_DAILY_QUESTION_REWARD = ProtoBuf.Serializer.Deserialize<MSG_CG_DAILY_QUESTION_REWARD>(stream);
            Parser.Parse(MSG_CG_DAILY_QUESTION_REWARD);
        }
        public object Deserialize_MSG_CG_DAILY_QUESTION_REWARD(MemoryStream stream)
        {
            return ProtoBuf.Serializer.Deserialize<MSG_CG_DAILY_QUESTION_REWARD>(stream);
        }

        MSG_CG_RADIO_GET_ALL_ANCHOR_RANK msg_MSG_CG_RADIO_GET_ALL_ANCHOR_RANK;

        public object Init_MSG_CG_RADIO_GET_ALL_ANCHOR_RANK()
        {
            msg_MSG_CG_RADIO_GET_ALL_ANCHOR_RANK = new MSG_CG_RADIO_GET_ALL_ANCHOR_RANK();
            return msg_MSG_CG_RADIO_GET_ALL_ANCHOR_RANK;
        }
        public object Get_MSG_CG_RADIO_GET_ALL_ANCHOR_RANK()
        {
            return msg_MSG_CG_RADIO_GET_ALL_ANCHOR_RANK;
        }
        public object New_MSG_CG_RADIO_GET_ALL_ANCHOR_RANK()
        {
            return msg_MSG_CG_RADIO_GET_ALL_ANCHOR_RANK;
        }
        public void OnResponse_MSG_CG_RADIO_GET_ALL_ANCHOR_RANK(MemoryStream stream)
        {
            MSG_CG_RADIO_GET_ALL_ANCHOR_RANK MSG_CG_RADIO_GET_ALL_ANCHOR_RANK = ProtoBuf.Serializer.Deserialize<MSG_CG_RADIO_GET_ALL_ANCHOR_RANK>(stream);
            Parser.Parse(MSG_CG_RADIO_GET_ALL_ANCHOR_RANK);
        }
        public object Deserialize_MSG_CG_RADIO_GET_ALL_ANCHOR_RANK(MemoryStream stream)
        {
            return ProtoBuf.Serializer.Deserialize<MSG_CG_RADIO_GET_ALL_ANCHOR_RANK>(stream);
        }

        MSG_CG_RADIO_GET_ANCHOR_CONTRIBUTION_RANK msg_MSG_CG_RADIO_GET_ANCHOR_CONTRIBUTION_RANK;

        public object Init_MSG_CG_RADIO_GET_ANCHOR_CONTRIBUTION_RANK()
        {
            msg_MSG_CG_RADIO_GET_ANCHOR_CONTRIBUTION_RANK = new MSG_CG_RADIO_GET_ANCHOR_CONTRIBUTION_RANK();
            return msg_MSG_CG_RADIO_GET_ANCHOR_CONTRIBUTION_RANK;
        }
        public object Get_MSG_CG_RADIO_GET_ANCHOR_CONTRIBUTION_RANK()
        {
            return msg_MSG_CG_RADIO_GET_ANCHOR_CONTRIBUTION_RANK;
        }
        public object New_MSG_CG_RADIO_GET_ANCHOR_CONTRIBUTION_RANK()
        {
            return msg_MSG_CG_RADIO_GET_ANCHOR_CONTRIBUTION_RANK;
        }
        public void OnResponse_MSG_CG_RADIO_GET_ANCHOR_CONTRIBUTION_RANK(MemoryStream stream)
        {
            MSG_CG_RADIO_GET_ANCHOR_CONTRIBUTION_RANK MSG_CG_RADIO_GET_ANCHOR_CONTRIBUTION_RANK = ProtoBuf.Serializer.Deserialize<MSG_CG_RADIO_GET_ANCHOR_CONTRIBUTION_RANK>(stream);
            Parser.Parse(MSG_CG_RADIO_GET_ANCHOR_CONTRIBUTION_RANK);
        }
        public object Deserialize_MSG_CG_RADIO_GET_ANCHOR_CONTRIBUTION_RANK(MemoryStream stream)
        {
            return ProtoBuf.Serializer.Deserialize<MSG_CG_RADIO_GET_ANCHOR_CONTRIBUTION_RANK>(stream);
        }

        MSG_CG_RADIO_GET_ALL_CONTRIBUTION_RANK msg_MSG_CG_RADIO_GET_ALL_CONTRIBUTION_RANK;

        public object Init_MSG_CG_RADIO_GET_ALL_CONTRIBUTION_RANK()
        {
            msg_MSG_CG_RADIO_GET_ALL_CONTRIBUTION_RANK = new MSG_CG_RADIO_GET_ALL_CONTRIBUTION_RANK();
            return msg_MSG_CG_RADIO_GET_ALL_CONTRIBUTION_RANK;
        }
        public object Get_MSG_CG_RADIO_GET_ALL_CONTRIBUTION_RANK()
        {
            return msg_MSG_CG_RADIO_GET_ALL_CONTRIBUTION_RANK;
        }
        public object New_MSG_CG_RADIO_GET_ALL_CONTRIBUTION_RANK()
        {
            return msg_MSG_CG_RADIO_GET_ALL_CONTRIBUTION_RANK;
        }
        public void OnResponse_MSG_CG_RADIO_GET_ALL_CONTRIBUTION_RANK(MemoryStream stream)
        {
            MSG_CG_RADIO_GET_ALL_CONTRIBUTION_RANK MSG_CG_RADIO_GET_ALL_CONTRIBUTION_RANK = ProtoBuf.Serializer.Deserialize<MSG_CG_RADIO_GET_ALL_CONTRIBUTION_RANK>(stream);
            Parser.Parse(MSG_CG_RADIO_GET_ALL_CONTRIBUTION_RANK);
        }
        public object Deserialize_MSG_CG_RADIO_GET_ALL_CONTRIBUTION_RANK(MemoryStream stream)
        {
            return ProtoBuf.Serializer.Deserialize<MSG_CG_RADIO_GET_ALL_CONTRIBUTION_RANK>(stream);
        }

        MSG_CG_RADIO_GET_CONTRIBUTION_REWARD msg_MSG_CG_RADIO_GET_CONTRIBUTION_REWARD;

        public object Init_MSG_CG_RADIO_GET_CONTRIBUTION_REWARD()
        {
            msg_MSG_CG_RADIO_GET_CONTRIBUTION_REWARD = new MSG_CG_RADIO_GET_CONTRIBUTION_REWARD();
            return msg_MSG_CG_RADIO_GET_CONTRIBUTION_REWARD;
        }
        public object Get_MSG_CG_RADIO_GET_CONTRIBUTION_REWARD()
        {
            return msg_MSG_CG_RADIO_GET_CONTRIBUTION_REWARD;
        }
        public object New_MSG_CG_RADIO_GET_CONTRIBUTION_REWARD()
        {
            return msg_MSG_CG_RADIO_GET_CONTRIBUTION_REWARD;
        }
        public void OnResponse_MSG_CG_RADIO_GET_CONTRIBUTION_REWARD(MemoryStream stream)
        {
            MSG_CG_RADIO_GET_CONTRIBUTION_REWARD MSG_CG_RADIO_GET_CONTRIBUTION_REWARD = ProtoBuf.Serializer.Deserialize<MSG_CG_RADIO_GET_CONTRIBUTION_REWARD>(stream);
            Parser.Parse(MSG_CG_RADIO_GET_CONTRIBUTION_REWARD);
        }
        public object Deserialize_MSG_CG_RADIO_GET_CONTRIBUTION_REWARD(MemoryStream stream)
        {
            return ProtoBuf.Serializer.Deserialize<MSG_CG_RADIO_GET_CONTRIBUTION_REWARD>(stream);
        }

        MSG_CG_RADIO_GIVE_GIFT msg_MSG_CG_RADIO_GIVE_GIFT;

        public object Init_MSG_CG_RADIO_GIVE_GIFT()
        {
            msg_MSG_CG_RADIO_GIVE_GIFT = new MSG_CG_RADIO_GIVE_GIFT();
            return msg_MSG_CG_RADIO_GIVE_GIFT;
        }
        public object Get_MSG_CG_RADIO_GIVE_GIFT()
        {
            return msg_MSG_CG_RADIO_GIVE_GIFT;
        }
        public object New_MSG_CG_RADIO_GIVE_GIFT()
        {
            return msg_MSG_CG_RADIO_GIVE_GIFT;
        }
        public void OnResponse_MSG_CG_RADIO_GIVE_GIFT(MemoryStream stream)
        {
            MSG_CG_RADIO_GIVE_GIFT MSG_CG_RADIO_GIVE_GIFT = ProtoBuf.Serializer.Deserialize<MSG_CG_RADIO_GIVE_GIFT>(stream);
            Parser.Parse(MSG_CG_RADIO_GIVE_GIFT);
        }
        public object Deserialize_MSG_CG_RADIO_GIVE_GIFT(MemoryStream stream)
        {
            return ProtoBuf.Serializer.Deserialize<MSG_CG_RADIO_GIVE_GIFT>(stream);
        }

        MSG_CG_RADIO_ENTER msg_MSG_CG_RADIO_ENTER;

        public object Init_MSG_CG_RADIO_ENTER()
        {
            msg_MSG_CG_RADIO_ENTER = new MSG_CG_RADIO_ENTER();
            return msg_MSG_CG_RADIO_ENTER;
        }
        public object Get_MSG_CG_RADIO_ENTER()
        {
            return msg_MSG_CG_RADIO_ENTER;
        }
        public object New_MSG_CG_RADIO_ENTER()
        {
            return msg_MSG_CG_RADIO_ENTER;
        }
        public void OnResponse_MSG_CG_RADIO_ENTER(MemoryStream stream)
        {
            MSG_CG_RADIO_ENTER MSG_CG_RADIO_ENTER = ProtoBuf.Serializer.Deserialize<MSG_CG_RADIO_ENTER>(stream);
            Parser.Parse(MSG_CG_RADIO_ENTER);
        }
        public object Deserialize_MSG_CG_RADIO_ENTER(MemoryStream stream)
        {
            return ProtoBuf.Serializer.Deserialize<MSG_CG_RADIO_ENTER>(stream);
        }

        MSG_CG_RADIO_LEAVE msg_MSG_CG_RADIO_LEAVE;

        public object Init_MSG_CG_RADIO_LEAVE()
        {
            msg_MSG_CG_RADIO_LEAVE = new MSG_CG_RADIO_LEAVE();
            return msg_MSG_CG_RADIO_LEAVE;
        }
        public object Get_MSG_CG_RADIO_LEAVE()
        {
            return msg_MSG_CG_RADIO_LEAVE;
        }
        public object New_MSG_CG_RADIO_LEAVE()
        {
            return msg_MSG_CG_RADIO_LEAVE;
        }
        public void OnResponse_MSG_CG_RADIO_LEAVE(MemoryStream stream)
        {
            MSG_CG_RADIO_LEAVE MSG_CG_RADIO_LEAVE = ProtoBuf.Serializer.Deserialize<MSG_CG_RADIO_LEAVE>(stream);
            Parser.Parse(MSG_CG_RADIO_LEAVE);
        }
        public object Deserialize_MSG_CG_RADIO_LEAVE(MemoryStream stream)
        {
            return ProtoBuf.Serializer.Deserialize<MSG_CG_RADIO_LEAVE>(stream);
        }

        public void OnResponse_MSG_CB_HEARTBEAT(MemoryStream stream)
        {
            MSG_CB_HEARTBEAT MSG_CB_HEARTBEAT = ProtoBuf.Serializer.Deserialize<MSG_CB_HEARTBEAT>(stream);
            Parser.Parse(MSG_CB_HEARTBEAT);
        }
        public object Deserialize_MSG_CB_HEARTBEAT(MemoryStream stream)
        {
            return ProtoBuf.Serializer.Deserialize<MSG_CB_HEARTBEAT>(stream);
        }

        public void OnResponse_MSG_CB_USER_LOGIN(MemoryStream stream)
        {
            MSG_CB_USER_LOGIN MSG_CB_USER_LOGIN = ProtoBuf.Serializer.Deserialize<MSG_CB_USER_LOGIN>(stream);
            Parser.Parse(MSG_CB_USER_LOGIN);
        }
        public object Deserialize_MSG_CB_USER_LOGIN(MemoryStream stream)
        {
            return ProtoBuf.Serializer.Deserialize<MSG_CB_USER_LOGIN>(stream);
        }

        public void OnResponse_MSG_CB_LOGIN_SERVERS(MemoryStream stream)
        {
            MSG_CB_LOGIN_SERVERS MSG_CB_LOGIN_SERVERS = ProtoBuf.Serializer.Deserialize<MSG_CB_LOGIN_SERVERS>(stream);
            Parser.Parse(MSG_CB_LOGIN_SERVERS);
        }
        public object Deserialize_MSG_CB_LOGIN_SERVERS(MemoryStream stream)
        {
            return ProtoBuf.Serializer.Deserialize<MSG_CB_LOGIN_SERVERS>(stream);
        }

        public void OnResponse_MSG_BC_HEARTBEAT(MemoryStream stream)
        {
            MSG_BC_HEARTBEAT MSG_BC_HEARTBEAT = ProtoBuf.Serializer.Deserialize<MSG_BC_HEARTBEAT>(stream);
            Parser.Parse(MSG_BC_HEARTBEAT);
        }
        public object Deserialize_MSG_BC_HEARTBEAT(MemoryStream stream)
        {
            return ProtoBuf.Serializer.Deserialize<MSG_BC_HEARTBEAT>(stream);
        }

        public void OnResponse_MSG_BC_USER_LOGIN(MemoryStream stream)
        {
            MSG_BC_USER_LOGIN MSG_BC_USER_LOGIN = ProtoBuf.Serializer.Deserialize<MSG_BC_USER_LOGIN>(stream);
            Parser.Parse(MSG_BC_USER_LOGIN);
        }
        public object Deserialize_MSG_BC_USER_LOGIN(MemoryStream stream)
        {
            return ProtoBuf.Serializer.Deserialize<MSG_BC_USER_LOGIN>(stream);
        }

        public void OnResponse_MSG_BC_LOGIN_SERVERS(MemoryStream stream)
        {
            MSG_BC_LOGIN_SERVERS MSG_BC_LOGIN_SERVERS = ProtoBuf.Serializer.Deserialize<MSG_BC_LOGIN_SERVERS>(stream);
            Parser.Parse(MSG_BC_LOGIN_SERVERS);
        }
        public object Deserialize_MSG_BC_LOGIN_SERVERS(MemoryStream stream)
        {
            return ProtoBuf.Serializer.Deserialize<MSG_BC_LOGIN_SERVERS>(stream);
        }


        public object RouteInit(string className)
        {
            switch (className)
            {
                case "MSG_CG_CHARACTER_LIST":
                    return Init_MSG_CG_CHARACTER_LIST();

                case "MSG_CG_ITEM_BUY":
                    return Init_MSG_CG_ITEM_BUY();

                case "MSG_CG_CREATE_CHARACTER":
                    return Init_MSG_CG_CREATE_CHARACTER();

                case "MSG_CG_TO_ZONE":
                    return Init_MSG_CG_TO_ZONE();

                case "MSG_CG_MAP_LOADING_DONE":
                    return Init_MSG_CG_MAP_LOADING_DONE();

                case "MSG_CG_HEARTBEAT":
                    return Init_MSG_CG_HEARTBEAT();

                case "MSG_CG_SHIP_STEP":
                    return Init_MSG_CG_SHIP_STEP();

                case "MSG_CG_CHARACTER_MOVE":
                    return Init_MSG_CG_CHARACTER_MOVE();

                case "MSG_CG_MOVE_ZONE":
                    return Init_MSG_CG_MOVE_ZONE();

                case "MSG_CG_AUTOPATHFINDING":
                    return Init_MSG_CG_AUTOPATHFINDING();

                case "MSG_CG_GEOGRAPHY":
                    return Init_MSG_CG_GEOGRAPHY();

                case "MSG_CG_RECONNECT_LOGIN":
                    return Init_MSG_CG_RECONNECT_LOGIN();

                case "MSG_CG_CROSS_PORTAL":
                    return Init_MSG_CG_CROSS_PORTAL();

                case "MSG_CG_GET_BLOWFISHKEY":
                    return Init_MSG_CG_GET_BLOWFISHKEY();

                case "MSG_CG_SUGGEST":
                    return Init_MSG_CG_SUGGEST();

                case "MSG_CG_LOGOUT":
                    return Init_MSG_CG_LOGOUT();

                case "MSG_CG_SAVE_GUIDE_ID":
                    return Init_MSG_CG_SAVE_GUIDE_ID();

                case "MSG_CG_SAVE_MAIN_LINE_ID":
                    return Init_MSG_CG_SAVE_MAIN_LINE_ID();

                case "MSG_CG_SAVE_GAME_COMMENT":
                    return Init_MSG_CG_SAVE_GAME_COMMENT();

                case "MSG_CG_CHANGE_CHANNEL":
                    return Init_MSG_CG_CHANGE_CHANNEL();

                case "MSG_CG_ITEM_USE":
                    return Init_MSG_CG_ITEM_USE();

                case "MSG_CG_ITEM_SELL":
                    return Init_MSG_CG_ITEM_SELL();

                case "MSG_CG_USE_FIREWORKS":
                    return Init_MSG_CG_USE_FIREWORKS();

                case "MSG_CG_EMAIL_READ":
                    return Init_MSG_CG_EMAIL_READ();

                case "MSG_CG_PICKUP_ATTACHMENT":
                    return Init_MSG_CG_PICKUP_ATTACHMENT();

                case "MSG_CG_EMAIL_OPENE_BOX":
                    return Init_MSG_CG_EMAIL_OPENE_BOX();

                case "MSG_CG_SHOP_BUY_ITEM":
                    return Init_MSG_CG_SHOP_BUY_ITEM();

                case "MSG_CG_SHOP_GET_SSR":
                    return Init_MSG_CG_SHOP_GET_SSR();

                case "MSG_CG_REFRESH_SHOP_ITEM":
                    return Init_MSG_CG_REFRESH_SHOP_ITEM();

                case "MSG_CG_CONVERT_FISH_COIN":
                    return Init_MSG_CG_CONVERT_FISH_COIN();

                case "MSG_CG_SAVE_ORDER":
                    return Init_MSG_CG_SAVE_ORDER();

                case "MSG_CG_GET_RECHARGE_HISTORY":
                    return Init_MSG_CG_GET_RECHARGE_HISTORY();

                case "MSG_CG_DELETE_RECHARGE_HISTORY":
                    return Init_MSG_CG_DELETE_RECHARGE_HISTORY();

                case "MSG_CG_FRIEND_SEARCH":
                    return Init_MSG_CG_FRIEND_SEARCH();

                case "MSG_CG_FRIEND_ADD_REQUEST":
                    return Init_MSG_CG_FRIEND_ADD_REQUEST();

                case "MSG_CG_FRIEND_ADD_RESPONSE":
                    return Init_MSG_CG_FRIEND_ADD_RESPONSE();

                case "MSG_CG_FRIEND_DELETE":
                    return Init_MSG_CG_FRIEND_DELETE();

                case "MSG_CG_FRIEND_REQUEST_LIST":
                    return Init_MSG_CG_FRIEND_REQUEST_LIST();

                case "MSG_CG_FRIEND_RECENT_LIST":
                    return Init_MSG_CG_FRIEND_RECENT_LIST();

                case "MSG_CG_FRIEND_BLACK_LIST":
                    return Init_MSG_CG_FRIEND_BLACK_LIST();

                case "MSG_CG_FRIEND_LIST":
                    return Init_MSG_CG_FRIEND_LIST();

                case "MSG_CG_FRIEND_BLACK_ADD":
                    return Init_MSG_CG_FRIEND_BLACK_ADD();

                case "MSG_CG_FRIEND_BLACK_DEL":
                    return Init_MSG_CG_FRIEND_BLACK_DEL();

                case "MSG_CG_FRIEND_RECOMMEND":
                    return Init_MSG_CG_FRIEND_RECOMMEND();

                case "MSG_CG_CREATE_GUILD":
                    return Init_MSG_CG_CREATE_GUILD();

                case "MSG_CG_CHAT_EMOJI":
                    return Init_MSG_CG_CHAT_EMOJI();

                case "MSG_CG_CHAT_WORDS":
                    return Init_MSG_CG_CHAT_WORDS();

                case "MSG_CG_CHANGE_WORLD_ROOM":
                    return Init_MSG_CG_CHANGE_WORLD_ROOM();

                case "MSG_CG_GET_WORLD_ROOM_LIST":
                    return Init_MSG_CG_GET_WORLD_ROOM_LIST();

                case "MSG_CG_CHAT_TRUMPET":
                    return Init_MSG_CG_CHAT_TRUMPET();

                case "MSG_CG_CHAT_REPORT":
                    return Init_MSG_CG_CHAT_REPORT();

                case "MSG_CG_NEARBY_EMOJI":
                    return Init_MSG_CG_NEARBY_EMOJI();

                case "MSG_CG_TIP_OFF":
                    return Init_MSG_CG_TIP_OFF();

                case "MSG_CG_ACTIVITY_CHAT_BUBBLE":
                    return Init_MSG_CG_ACTIVITY_CHAT_BUBBLE();

                case "MSG_CG_USE_CHAT_TRUMPET":
                    return Init_MSG_CG_USE_CHAT_TRUMPET();

                case "MSG_CG_TASK_COMPLETE":
                    return Init_MSG_CG_TASK_COMPLETE();

                case "MSG_CG_OPENE_EMAIL_TASK":
                    return Init_MSG_CG_OPENE_EMAIL_TASK();

                case "MSG_CG_TASK_COLLECT":
                    return Init_MSG_CG_TASK_COLLECT();

                case "MSG_CG_TASK_SELECT":
                    return Init_MSG_CG_TASK_SELECT();

                case "MSG_CG_TASK_MAKE":
                    return Init_MSG_CG_TASK_MAKE();

                case "MSG_CG_TASKFLY_FLY_DONE":
                    return Init_MSG_CG_TASKFLY_FLY_DONE();

                case "MSG_CG_TASKFLY_STARTPATHFINDING":
                    return Init_MSG_CG_TASKFLY_STARTPATHFINDING();

                case "MSG_CG_ACTIVITY_COMPLETE":
                    return Init_MSG_CG_ACTIVITY_COMPLETE();

                case "MSG_CG_SHOW_CHARACTER":
                    return Init_MSG_CG_SHOW_CHARACTER();

                case "MSG_CG_CHANGE_NAME":
                    return Init_MSG_CG_CHANGE_NAME();

                case "MSG_CG_SHOW_FACEICON":
                    return Init_MSG_CG_SHOW_FACEICON();

                case "MSG_CG_SHOW_FACEJPG":
                    return Init_MSG_CG_SHOW_FACEJPG();

                case "MSG_CG_SET_SEX":
                    return Init_MSG_CG_SET_SEX();

                case "MSG_CG_SET_BIRTHDAY":
                    return Init_MSG_CG_SET_BIRTHDAY();

                case "MSG_CG_SET_SIGNATURE":
                    return Init_MSG_CG_SET_SIGNATURE();

                case "MSG_CG_SHOW_VOICE":
                    return Init_MSG_CG_SHOW_VOICE();

                case "MSG_CG_PRESENT_GIFT":
                    return Init_MSG_CG_PRESENT_GIFT();

                case "MSG_CG_GET_GIFTRECORD":
                    return Init_MSG_CG_GET_GIFTRECORD();

                case "MSG_CG_SET_SOCIAL_NUM":
                    return Init_MSG_CG_SET_SOCIAL_NUM();

                case "MSG_CG_GET_SOCIAL_NUM":
                    return Init_MSG_CG_GET_SOCIAL_NUM();

                case "MSG_CG_SHOW_CAREER":
                    return Init_MSG_CG_SHOW_CAREER();

                case "MSG_CG_GET_RANKING_FRIEND_LIST":
                    return Init_MSG_CG_GET_RANKING_FRIEND_LIST();

                case "MSG_CG_GET_RANKING_ALL_LIST":
                    return Init_MSG_CG_GET_RANKING_ALL_LIST();

                case "MSG_CG_GET_RANKING_NEARBY_LIST":
                    return Init_MSG_CG_GET_RANKING_NEARBY_LIST();

                case "MSG_CG_CHANGE_TITLE":
                    return Init_MSG_CG_CHANGE_TITLE();

                case "MSG_CG_UPLOAD_PHOTO":
                    return Init_MSG_CG_UPLOAD_PHOTO();

                case "MSG_CG_REMOVE_PHOTO":
                    return Init_MSG_CG_REMOVE_PHOTO();

                case "MSG_CG_PHOTO_LIST":
                    return Init_MSG_CG_PHOTO_LIST();

                case "MSG_CG_POP_RANK":
                    return Init_MSG_CG_POP_RANK();

                case "MSG_CG_QUESTION":
                    return Init_MSG_CG_QUESTION();

                case "MSG_CG_QUESTIONNAIRE":
                    return Init_MSG_CG_QUESTIONNAIRE();

                case "MSG_CG_DAILY_QUESTION_COUNTER":
                    return Init_MSG_CG_DAILY_QUESTION_COUNTER();

                case "MSG_CG_DAILY_QUESTION_REWARD":
                    return Init_MSG_CG_DAILY_QUESTION_REWARD();

                case "MSG_CG_RADIO_GET_ALL_ANCHOR_RANK":
                    return Init_MSG_CG_RADIO_GET_ALL_ANCHOR_RANK();

                case "MSG_CG_RADIO_GET_ANCHOR_CONTRIBUTION_RANK":
                    return Init_MSG_CG_RADIO_GET_ANCHOR_CONTRIBUTION_RANK();

                case "MSG_CG_RADIO_GET_ALL_CONTRIBUTION_RANK":
                    return Init_MSG_CG_RADIO_GET_ALL_CONTRIBUTION_RANK();

                case "MSG_CG_RADIO_GET_CONTRIBUTION_REWARD":
                    return Init_MSG_CG_RADIO_GET_CONTRIBUTION_REWARD();

                case "MSG_CG_RADIO_GIVE_GIFT":
                    return Init_MSG_CG_RADIO_GIVE_GIFT();

                case "MSG_CG_RADIO_ENTER":
                    return Init_MSG_CG_RADIO_ENTER();

                case "MSG_CG_RADIO_LEAVE":
                    return Init_MSG_CG_RADIO_LEAVE();


                default:
                    return null;
            }
        }
        public object RouteNew(string className)
        {
            switch (className)
            {
                case "MSG_CG_CHARACTER_LIST":
                    return New_MSG_CG_CHARACTER_LIST();

                case "MSG_CG_ITEM_BUY":
                    return New_MSG_CG_ITEM_BUY();

                case "MSG_CG_CREATE_CHARACTER":
                    return New_MSG_CG_CREATE_CHARACTER();

                case "MSG_CG_TO_ZONE":
                    return New_MSG_CG_TO_ZONE();

                case "MSG_CG_MAP_LOADING_DONE":
                    return New_MSG_CG_MAP_LOADING_DONE();

                case "MSG_CG_HEARTBEAT":
                    return New_MSG_CG_HEARTBEAT();

                case "MSG_CG_SHIP_STEP":
                    return New_MSG_CG_SHIP_STEP();

                case "MSG_CG_CHARACTER_MOVE":
                    return New_MSG_CG_CHARACTER_MOVE();

                case "MSG_CG_MOVE_ZONE":
                    return New_MSG_CG_MOVE_ZONE();

                case "MSG_CG_AUTOPATHFINDING":
                    return New_MSG_CG_AUTOPATHFINDING();

                case "MSG_CG_GEOGRAPHY":
                    return New_MSG_CG_GEOGRAPHY();

                case "MSG_CG_RECONNECT_LOGIN":
                    return New_MSG_CG_RECONNECT_LOGIN();

                case "MSG_CG_CROSS_PORTAL":
                    return New_MSG_CG_CROSS_PORTAL();

                case "MSG_CG_GET_BLOWFISHKEY":
                    return New_MSG_CG_GET_BLOWFISHKEY();

                case "MSG_CG_SUGGEST":
                    return New_MSG_CG_SUGGEST();

                case "MSG_CG_LOGOUT":
                    return New_MSG_CG_LOGOUT();

                case "MSG_CG_SAVE_GUIDE_ID":
                    return New_MSG_CG_SAVE_GUIDE_ID();

                case "MSG_CG_SAVE_MAIN_LINE_ID":
                    return New_MSG_CG_SAVE_MAIN_LINE_ID();

                case "MSG_CG_SAVE_GAME_COMMENT":
                    return New_MSG_CG_SAVE_GAME_COMMENT();

                case "MSG_CG_CHANGE_CHANNEL":
                    return New_MSG_CG_CHANGE_CHANNEL();

                case "MSG_CG_ITEM_USE":
                    return New_MSG_CG_ITEM_USE();

                case "MSG_CG_ITEM_SELL":
                    return New_MSG_CG_ITEM_SELL();

                case "MSG_CG_USE_FIREWORKS":
                    return New_MSG_CG_USE_FIREWORKS();

                case "MSG_CG_EMAIL_READ":
                    return New_MSG_CG_EMAIL_READ();

                case "MSG_CG_PICKUP_ATTACHMENT":
                    return New_MSG_CG_PICKUP_ATTACHMENT();

                case "MSG_CG_EMAIL_OPENE_BOX":
                    return New_MSG_CG_EMAIL_OPENE_BOX();

                case "MSG_CG_SHOP_BUY_ITEM":
                    return New_MSG_CG_SHOP_BUY_ITEM();

                case "MSG_CG_SHOP_GET_SSR":
                    return New_MSG_CG_SHOP_GET_SSR();

                case "MSG_CG_REFRESH_SHOP_ITEM":
                    return New_MSG_CG_REFRESH_SHOP_ITEM();

                case "MSG_CG_CONVERT_FISH_COIN":
                    return New_MSG_CG_CONVERT_FISH_COIN();

                case "MSG_CG_SAVE_ORDER":
                    return New_MSG_CG_SAVE_ORDER();

                case "MSG_CG_GET_RECHARGE_HISTORY":
                    return New_MSG_CG_GET_RECHARGE_HISTORY();

                case "MSG_CG_DELETE_RECHARGE_HISTORY":
                    return New_MSG_CG_DELETE_RECHARGE_HISTORY();

                case "MSG_CG_FRIEND_SEARCH":
                    return New_MSG_CG_FRIEND_SEARCH();

                case "MSG_CG_FRIEND_ADD_REQUEST":
                    return New_MSG_CG_FRIEND_ADD_REQUEST();

                case "MSG_CG_FRIEND_ADD_RESPONSE":
                    return New_MSG_CG_FRIEND_ADD_RESPONSE();

                case "MSG_CG_FRIEND_DELETE":
                    return New_MSG_CG_FRIEND_DELETE();

                case "MSG_CG_FRIEND_REQUEST_LIST":
                    return New_MSG_CG_FRIEND_REQUEST_LIST();

                case "MSG_CG_FRIEND_RECENT_LIST":
                    return New_MSG_CG_FRIEND_RECENT_LIST();

                case "MSG_CG_FRIEND_BLACK_LIST":
                    return New_MSG_CG_FRIEND_BLACK_LIST();

                case "MSG_CG_FRIEND_LIST":
                    return New_MSG_CG_FRIEND_LIST();

                case "MSG_CG_FRIEND_BLACK_ADD":
                    return New_MSG_CG_FRIEND_BLACK_ADD();

                case "MSG_CG_FRIEND_BLACK_DEL":
                    return New_MSG_CG_FRIEND_BLACK_DEL();

                case "MSG_CG_FRIEND_RECOMMEND":
                    return New_MSG_CG_FRIEND_RECOMMEND();

                case "MSG_CG_CREATE_GUILD":
                    return New_MSG_CG_CREATE_GUILD();

                case "MSG_CG_CHAT_EMOJI":
                    return New_MSG_CG_CHAT_EMOJI();

                case "MSG_CG_CHAT_WORDS":
                    return New_MSG_CG_CHAT_WORDS();

                case "MSG_CG_CHANGE_WORLD_ROOM":
                    return New_MSG_CG_CHANGE_WORLD_ROOM();

                case "MSG_CG_GET_WORLD_ROOM_LIST":
                    return New_MSG_CG_GET_WORLD_ROOM_LIST();

                case "MSG_CG_CHAT_TRUMPET":
                    return New_MSG_CG_CHAT_TRUMPET();

                case "MSG_CG_CHAT_REPORT":
                    return New_MSG_CG_CHAT_REPORT();

                case "MSG_CG_NEARBY_EMOJI":
                    return New_MSG_CG_NEARBY_EMOJI();

                case "MSG_CG_TIP_OFF":
                    return New_MSG_CG_TIP_OFF();

                case "MSG_CG_ACTIVITY_CHAT_BUBBLE":
                    return New_MSG_CG_ACTIVITY_CHAT_BUBBLE();

                case "MSG_CG_USE_CHAT_TRUMPET":
                    return New_MSG_CG_USE_CHAT_TRUMPET();

                case "MSG_CG_TASK_COMPLETE":
                    return New_MSG_CG_TASK_COMPLETE();

                case "MSG_CG_OPENE_EMAIL_TASK":
                    return New_MSG_CG_OPENE_EMAIL_TASK();

                case "MSG_CG_TASK_COLLECT":
                    return New_MSG_CG_TASK_COLLECT();

                case "MSG_CG_TASK_SELECT":
                    return New_MSG_CG_TASK_SELECT();

                case "MSG_CG_TASK_MAKE":
                    return New_MSG_CG_TASK_MAKE();

                case "MSG_CG_TASKFLY_FLY_DONE":
                    return New_MSG_CG_TASKFLY_FLY_DONE();

                case "MSG_CG_TASKFLY_STARTPATHFINDING":
                    return New_MSG_CG_TASKFLY_STARTPATHFINDING();

                case "MSG_CG_ACTIVITY_COMPLETE":
                    return New_MSG_CG_ACTIVITY_COMPLETE();

                case "MSG_CG_SHOW_CHARACTER":
                    return New_MSG_CG_SHOW_CHARACTER();

                case "MSG_CG_CHANGE_NAME":
                    return New_MSG_CG_CHANGE_NAME();

                case "MSG_CG_SHOW_FACEICON":
                    return New_MSG_CG_SHOW_FACEICON();

                case "MSG_CG_SHOW_FACEJPG":
                    return New_MSG_CG_SHOW_FACEJPG();

                case "MSG_CG_SET_SEX":
                    return New_MSG_CG_SET_SEX();

                case "MSG_CG_SET_BIRTHDAY":
                    return New_MSG_CG_SET_BIRTHDAY();

                case "MSG_CG_SET_SIGNATURE":
                    return New_MSG_CG_SET_SIGNATURE();

                case "MSG_CG_SHOW_VOICE":
                    return New_MSG_CG_SHOW_VOICE();

                case "MSG_CG_PRESENT_GIFT":
                    return New_MSG_CG_PRESENT_GIFT();

                case "MSG_CG_GET_GIFTRECORD":
                    return New_MSG_CG_GET_GIFTRECORD();

                case "MSG_CG_SET_SOCIAL_NUM":
                    return New_MSG_CG_SET_SOCIAL_NUM();

                case "MSG_CG_GET_SOCIAL_NUM":
                    return New_MSG_CG_GET_SOCIAL_NUM();

                case "MSG_CG_SHOW_CAREER":
                    return New_MSG_CG_SHOW_CAREER();

                case "MSG_CG_GET_RANKING_FRIEND_LIST":
                    return New_MSG_CG_GET_RANKING_FRIEND_LIST();

                case "MSG_CG_GET_RANKING_ALL_LIST":
                    return New_MSG_CG_GET_RANKING_ALL_LIST();

                case "MSG_CG_GET_RANKING_NEARBY_LIST":
                    return New_MSG_CG_GET_RANKING_NEARBY_LIST();

                case "MSG_CG_CHANGE_TITLE":
                    return New_MSG_CG_CHANGE_TITLE();

                case "MSG_CG_UPLOAD_PHOTO":
                    return New_MSG_CG_UPLOAD_PHOTO();

                case "MSG_CG_REMOVE_PHOTO":
                    return New_MSG_CG_REMOVE_PHOTO();

                case "MSG_CG_PHOTO_LIST":
                    return New_MSG_CG_PHOTO_LIST();

                case "MSG_CG_POP_RANK":
                    return New_MSG_CG_POP_RANK();

                case "MSG_CG_QUESTION":
                    return New_MSG_CG_QUESTION();

                case "MSG_CG_QUESTIONNAIRE":
                    return New_MSG_CG_QUESTIONNAIRE();

                case "MSG_CG_DAILY_QUESTION_COUNTER":
                    return New_MSG_CG_DAILY_QUESTION_COUNTER();

                case "MSG_CG_DAILY_QUESTION_REWARD":
                    return New_MSG_CG_DAILY_QUESTION_REWARD();

                case "MSG_CG_RADIO_GET_ALL_ANCHOR_RANK":
                    return New_MSG_CG_RADIO_GET_ALL_ANCHOR_RANK();

                case "MSG_CG_RADIO_GET_ANCHOR_CONTRIBUTION_RANK":
                    return New_MSG_CG_RADIO_GET_ANCHOR_CONTRIBUTION_RANK();

                case "MSG_CG_RADIO_GET_ALL_CONTRIBUTION_RANK":
                    return New_MSG_CG_RADIO_GET_ALL_CONTRIBUTION_RANK();

                case "MSG_CG_RADIO_GET_CONTRIBUTION_REWARD":
                    return New_MSG_CG_RADIO_GET_CONTRIBUTION_REWARD();

                case "MSG_CG_RADIO_GIVE_GIFT":
                    return New_MSG_CG_RADIO_GIVE_GIFT();

                case "MSG_CG_RADIO_ENTER":
                    return New_MSG_CG_RADIO_ENTER();

                case "MSG_CG_RADIO_LEAVE":
                    return New_MSG_CG_RADIO_LEAVE();


                default:
                    return null;
            }
        }
        public object RouteGet(string className)
        {
            switch (className)
            {
                case "MSG_CG_CHARACTER_LIST":
                    return Get_MSG_CG_CHARACTER_LIST();

                case "MSG_CG_ITEM_BUY":
                    return Get_MSG_CG_ITEM_BUY();

                case "MSG_CG_CREATE_CHARACTER":
                    return Get_MSG_CG_CREATE_CHARACTER();

                case "MSG_CG_TO_ZONE":
                    return Get_MSG_CG_TO_ZONE();

                case "MSG_CG_MAP_LOADING_DONE":
                    return Get_MSG_CG_MAP_LOADING_DONE();

                case "MSG_CG_HEARTBEAT":
                    return Get_MSG_CG_HEARTBEAT();

                case "MSG_CG_SHIP_STEP":
                    return Get_MSG_CG_SHIP_STEP();

                case "MSG_CG_CHARACTER_MOVE":
                    return Get_MSG_CG_CHARACTER_MOVE();

                case "MSG_CG_MOVE_ZONE":
                    return Get_MSG_CG_MOVE_ZONE();

                case "MSG_CG_AUTOPATHFINDING":
                    return Get_MSG_CG_AUTOPATHFINDING();

                case "MSG_CG_GEOGRAPHY":
                    return Get_MSG_CG_GEOGRAPHY();

                case "MSG_CG_RECONNECT_LOGIN":
                    return Get_MSG_CG_RECONNECT_LOGIN();

                case "MSG_CG_CROSS_PORTAL":
                    return Get_MSG_CG_CROSS_PORTAL();

                case "MSG_CG_GET_BLOWFISHKEY":
                    return Get_MSG_CG_GET_BLOWFISHKEY();

                case "MSG_CG_SUGGEST":
                    return Get_MSG_CG_SUGGEST();

                case "MSG_CG_LOGOUT":
                    return Get_MSG_CG_LOGOUT();

                case "MSG_CG_SAVE_GUIDE_ID":
                    return Get_MSG_CG_SAVE_GUIDE_ID();

                case "MSG_CG_SAVE_MAIN_LINE_ID":
                    return Get_MSG_CG_SAVE_MAIN_LINE_ID();

                case "MSG_CG_SAVE_GAME_COMMENT":
                    return Get_MSG_CG_SAVE_GAME_COMMENT();

                case "MSG_CG_CHANGE_CHANNEL":
                    return Get_MSG_CG_CHANGE_CHANNEL();

                case "MSG_CG_ITEM_USE":
                    return Get_MSG_CG_ITEM_USE();

                case "MSG_CG_ITEM_SELL":
                    return Get_MSG_CG_ITEM_SELL();

                case "MSG_CG_USE_FIREWORKS":
                    return Get_MSG_CG_USE_FIREWORKS();

                case "MSG_CG_EMAIL_READ":
                    return Get_MSG_CG_EMAIL_READ();

                case "MSG_CG_PICKUP_ATTACHMENT":
                    return Get_MSG_CG_PICKUP_ATTACHMENT();

                case "MSG_CG_EMAIL_OPENE_BOX":
                    return Get_MSG_CG_EMAIL_OPENE_BOX();

                case "MSG_CG_SHOP_BUY_ITEM":
                    return Get_MSG_CG_SHOP_BUY_ITEM();

                case "MSG_CG_SHOP_GET_SSR":
                    return Get_MSG_CG_SHOP_GET_SSR();

                case "MSG_CG_REFRESH_SHOP_ITEM":
                    return Get_MSG_CG_REFRESH_SHOP_ITEM();

                case "MSG_CG_CONVERT_FISH_COIN":
                    return Get_MSG_CG_CONVERT_FISH_COIN();

                case "MSG_CG_SAVE_ORDER":
                    return Get_MSG_CG_SAVE_ORDER();

                case "MSG_CG_GET_RECHARGE_HISTORY":
                    return Get_MSG_CG_GET_RECHARGE_HISTORY();

                case "MSG_CG_DELETE_RECHARGE_HISTORY":
                    return Get_MSG_CG_DELETE_RECHARGE_HISTORY();

                case "MSG_CG_FRIEND_SEARCH":
                    return Get_MSG_CG_FRIEND_SEARCH();

                case "MSG_CG_FRIEND_ADD_REQUEST":
                    return Get_MSG_CG_FRIEND_ADD_REQUEST();

                case "MSG_CG_FRIEND_ADD_RESPONSE":
                    return Get_MSG_CG_FRIEND_ADD_RESPONSE();

                case "MSG_CG_FRIEND_DELETE":
                    return Get_MSG_CG_FRIEND_DELETE();

                case "MSG_CG_FRIEND_REQUEST_LIST":
                    return Get_MSG_CG_FRIEND_REQUEST_LIST();

                case "MSG_CG_FRIEND_RECENT_LIST":
                    return Get_MSG_CG_FRIEND_RECENT_LIST();

                case "MSG_CG_FRIEND_BLACK_LIST":
                    return Get_MSG_CG_FRIEND_BLACK_LIST();

                case "MSG_CG_FRIEND_LIST":
                    return Get_MSG_CG_FRIEND_LIST();

                case "MSG_CG_FRIEND_BLACK_ADD":
                    return Get_MSG_CG_FRIEND_BLACK_ADD();

                case "MSG_CG_FRIEND_BLACK_DEL":
                    return Get_MSG_CG_FRIEND_BLACK_DEL();

                case "MSG_CG_FRIEND_RECOMMEND":
                    return Get_MSG_CG_FRIEND_RECOMMEND();

                case "MSG_CG_CREATE_GUILD":
                    return Get_MSG_CG_CREATE_GUILD();

                case "MSG_CG_CHAT_EMOJI":
                    return Get_MSG_CG_CHAT_EMOJI();

                case "MSG_CG_CHAT_WORDS":
                    return Get_MSG_CG_CHAT_WORDS();

                case "MSG_CG_CHANGE_WORLD_ROOM":
                    return Get_MSG_CG_CHANGE_WORLD_ROOM();

                case "MSG_CG_GET_WORLD_ROOM_LIST":
                    return Get_MSG_CG_GET_WORLD_ROOM_LIST();

                case "MSG_CG_CHAT_TRUMPET":
                    return Get_MSG_CG_CHAT_TRUMPET();

                case "MSG_CG_CHAT_REPORT":
                    return Get_MSG_CG_CHAT_REPORT();

                case "MSG_CG_NEARBY_EMOJI":
                    return Get_MSG_CG_NEARBY_EMOJI();

                case "MSG_CG_TIP_OFF":
                    return Get_MSG_CG_TIP_OFF();

                case "MSG_CG_ACTIVITY_CHAT_BUBBLE":
                    return Get_MSG_CG_ACTIVITY_CHAT_BUBBLE();

                case "MSG_CG_USE_CHAT_TRUMPET":
                    return Get_MSG_CG_USE_CHAT_TRUMPET();

                case "MSG_CG_TASK_COMPLETE":
                    return Get_MSG_CG_TASK_COMPLETE();

                case "MSG_CG_OPENE_EMAIL_TASK":
                    return Get_MSG_CG_OPENE_EMAIL_TASK();

                case "MSG_CG_TASK_COLLECT":
                    return Get_MSG_CG_TASK_COLLECT();

                case "MSG_CG_TASK_SELECT":
                    return Get_MSG_CG_TASK_SELECT();

                case "MSG_CG_TASK_MAKE":
                    return Get_MSG_CG_TASK_MAKE();

                case "MSG_CG_TASKFLY_FLY_DONE":
                    return Get_MSG_CG_TASKFLY_FLY_DONE();

                case "MSG_CG_TASKFLY_STARTPATHFINDING":
                    return Get_MSG_CG_TASKFLY_STARTPATHFINDING();

                case "MSG_CG_ACTIVITY_COMPLETE":
                    return Get_MSG_CG_ACTIVITY_COMPLETE();

                case "MSG_CG_SHOW_CHARACTER":
                    return Get_MSG_CG_SHOW_CHARACTER();

                case "MSG_CG_CHANGE_NAME":
                    return Get_MSG_CG_CHANGE_NAME();

                case "MSG_CG_SHOW_FACEICON":
                    return Get_MSG_CG_SHOW_FACEICON();

                case "MSG_CG_SHOW_FACEJPG":
                    return Get_MSG_CG_SHOW_FACEJPG();

                case "MSG_CG_SET_SEX":
                    return Get_MSG_CG_SET_SEX();

                case "MSG_CG_SET_BIRTHDAY":
                    return Get_MSG_CG_SET_BIRTHDAY();

                case "MSG_CG_SET_SIGNATURE":
                    return Get_MSG_CG_SET_SIGNATURE();

                case "MSG_CG_SHOW_VOICE":
                    return Get_MSG_CG_SHOW_VOICE();

                case "MSG_CG_PRESENT_GIFT":
                    return Get_MSG_CG_PRESENT_GIFT();

                case "MSG_CG_GET_GIFTRECORD":
                    return Get_MSG_CG_GET_GIFTRECORD();

                case "MSG_CG_SET_SOCIAL_NUM":
                    return Get_MSG_CG_SET_SOCIAL_NUM();

                case "MSG_CG_GET_SOCIAL_NUM":
                    return Get_MSG_CG_GET_SOCIAL_NUM();

                case "MSG_CG_SHOW_CAREER":
                    return Get_MSG_CG_SHOW_CAREER();

                case "MSG_CG_GET_RANKING_FRIEND_LIST":
                    return Get_MSG_CG_GET_RANKING_FRIEND_LIST();

                case "MSG_CG_GET_RANKING_ALL_LIST":
                    return Get_MSG_CG_GET_RANKING_ALL_LIST();

                case "MSG_CG_GET_RANKING_NEARBY_LIST":
                    return Get_MSG_CG_GET_RANKING_NEARBY_LIST();

                case "MSG_CG_CHANGE_TITLE":
                    return Get_MSG_CG_CHANGE_TITLE();

                case "MSG_CG_UPLOAD_PHOTO":
                    return Get_MSG_CG_UPLOAD_PHOTO();

                case "MSG_CG_REMOVE_PHOTO":
                    return Get_MSG_CG_REMOVE_PHOTO();

                case "MSG_CG_PHOTO_LIST":
                    return Get_MSG_CG_PHOTO_LIST();

                case "MSG_CG_POP_RANK":
                    return Get_MSG_CG_POP_RANK();

                case "MSG_CG_QUESTION":
                    return Get_MSG_CG_QUESTION();

                case "MSG_CG_QUESTIONNAIRE":
                    return Get_MSG_CG_QUESTIONNAIRE();

                case "MSG_CG_DAILY_QUESTION_COUNTER":
                    return Get_MSG_CG_DAILY_QUESTION_COUNTER();

                case "MSG_CG_DAILY_QUESTION_REWARD":
                    return Get_MSG_CG_DAILY_QUESTION_REWARD();

                case "MSG_CG_RADIO_GET_ALL_ANCHOR_RANK":
                    return Get_MSG_CG_RADIO_GET_ALL_ANCHOR_RANK();

                case "MSG_CG_RADIO_GET_ANCHOR_CONTRIBUTION_RANK":
                    return Get_MSG_CG_RADIO_GET_ANCHOR_CONTRIBUTION_RANK();

                case "MSG_CG_RADIO_GET_ALL_CONTRIBUTION_RANK":
                    return Get_MSG_CG_RADIO_GET_ALL_CONTRIBUTION_RANK();

                case "MSG_CG_RADIO_GET_CONTRIBUTION_REWARD":
                    return Get_MSG_CG_RADIO_GET_CONTRIBUTION_REWARD();

                case "MSG_CG_RADIO_GIVE_GIFT":
                    return Get_MSG_CG_RADIO_GIVE_GIFT();

                case "MSG_CG_RADIO_ENTER":
                    return Get_MSG_CG_RADIO_ENTER();

                case "MSG_CG_RADIO_LEAVE":
                    return Get_MSG_CG_RADIO_LEAVE();


                default:
                    return null;
            }
        }
        public object RouteDeserialize(string className, MemoryStream stream)
        {
            switch (className)
            {
                case "MSG_CG_CHARACTER_LIST":
                    return Deserialize_MSG_CG_CHARACTER_LIST(stream);

                case "MSG_CG_ITEM_BUY":
                    return Deserialize_MSG_CG_ITEM_BUY(stream);

                case "MSG_CG_CREATE_CHARACTER":
                    return Deserialize_MSG_CG_CREATE_CHARACTER(stream);

                case "MSG_CG_TO_ZONE":
                    return Deserialize_MSG_CG_TO_ZONE(stream);

                case "MSG_CG_MAP_LOADING_DONE":
                    return Deserialize_MSG_CG_MAP_LOADING_DONE(stream);

                case "MSG_CG_HEARTBEAT":
                    return Deserialize_MSG_CG_HEARTBEAT(stream);

                case "MSG_CG_SHIP_STEP":
                    return Deserialize_MSG_CG_SHIP_STEP(stream);

                case "MSG_CG_CHARACTER_MOVE":
                    return Deserialize_MSG_CG_CHARACTER_MOVE(stream);

                case "MSG_CG_MOVE_ZONE":
                    return Deserialize_MSG_CG_MOVE_ZONE(stream);

                case "MSG_CG_AUTOPATHFINDING":
                    return Deserialize_MSG_CG_AUTOPATHFINDING(stream);

                case "MSG_CG_GEOGRAPHY":
                    return Deserialize_MSG_CG_GEOGRAPHY(stream);

                case "MSG_CG_RECONNECT_LOGIN":
                    return Deserialize_MSG_CG_RECONNECT_LOGIN(stream);

                case "MSG_CG_CROSS_PORTAL":
                    return Deserialize_MSG_CG_CROSS_PORTAL(stream);

                case "MSG_CG_GET_BLOWFISHKEY":
                    return Deserialize_MSG_CG_GET_BLOWFISHKEY(stream);

                case "MSG_CG_SUGGEST":
                    return Deserialize_MSG_CG_SUGGEST(stream);

                case "MSG_CG_LOGOUT":
                    return Deserialize_MSG_CG_LOGOUT(stream);

                case "MSG_CG_SAVE_GUIDE_ID":
                    return Deserialize_MSG_CG_SAVE_GUIDE_ID(stream);

                case "MSG_CG_SAVE_MAIN_LINE_ID":
                    return Deserialize_MSG_CG_SAVE_MAIN_LINE_ID(stream);

                case "MSG_CG_SAVE_GAME_COMMENT":
                    return Deserialize_MSG_CG_SAVE_GAME_COMMENT(stream);

                case "MSG_CG_CHANGE_CHANNEL":
                    return Deserialize_MSG_CG_CHANGE_CHANNEL(stream);

                case "MSG_CG_ITEM_USE":
                    return Deserialize_MSG_CG_ITEM_USE(stream);

                case "MSG_CG_ITEM_SELL":
                    return Deserialize_MSG_CG_ITEM_SELL(stream);

                case "MSG_CG_USE_FIREWORKS":
                    return Deserialize_MSG_CG_USE_FIREWORKS(stream);

                case "MSG_CG_EMAIL_READ":
                    return Deserialize_MSG_CG_EMAIL_READ(stream);

                case "MSG_CG_PICKUP_ATTACHMENT":
                    return Deserialize_MSG_CG_PICKUP_ATTACHMENT(stream);

                case "MSG_CG_EMAIL_OPENE_BOX":
                    return Deserialize_MSG_CG_EMAIL_OPENE_BOX(stream);

                case "MSG_CG_SHOP_BUY_ITEM":
                    return Deserialize_MSG_CG_SHOP_BUY_ITEM(stream);

                case "MSG_CG_SHOP_GET_SSR":
                    return Deserialize_MSG_CG_SHOP_GET_SSR(stream);

                case "MSG_CG_REFRESH_SHOP_ITEM":
                    return Deserialize_MSG_CG_REFRESH_SHOP_ITEM(stream);

                case "MSG_CG_CONVERT_FISH_COIN":
                    return Deserialize_MSG_CG_CONVERT_FISH_COIN(stream);

                case "MSG_CG_SAVE_ORDER":
                    return Deserialize_MSG_CG_SAVE_ORDER(stream);

                case "MSG_CG_GET_RECHARGE_HISTORY":
                    return Deserialize_MSG_CG_GET_RECHARGE_HISTORY(stream);

                case "MSG_CG_DELETE_RECHARGE_HISTORY":
                    return Deserialize_MSG_CG_DELETE_RECHARGE_HISTORY(stream);

                case "MSG_CG_FRIEND_SEARCH":
                    return Deserialize_MSG_CG_FRIEND_SEARCH(stream);

                case "MSG_CG_FRIEND_ADD_REQUEST":
                    return Deserialize_MSG_CG_FRIEND_ADD_REQUEST(stream);

                case "MSG_CG_FRIEND_ADD_RESPONSE":
                    return Deserialize_MSG_CG_FRIEND_ADD_RESPONSE(stream);

                case "MSG_CG_FRIEND_DELETE":
                    return Deserialize_MSG_CG_FRIEND_DELETE(stream);

                case "MSG_CG_FRIEND_REQUEST_LIST":
                    return Deserialize_MSG_CG_FRIEND_REQUEST_LIST(stream);

                case "MSG_CG_FRIEND_RECENT_LIST":
                    return Deserialize_MSG_CG_FRIEND_RECENT_LIST(stream);

                case "MSG_CG_FRIEND_BLACK_LIST":
                    return Deserialize_MSG_CG_FRIEND_BLACK_LIST(stream);

                case "MSG_CG_FRIEND_LIST":
                    return Deserialize_MSG_CG_FRIEND_LIST(stream);

                case "MSG_CG_FRIEND_BLACK_ADD":
                    return Deserialize_MSG_CG_FRIEND_BLACK_ADD(stream);

                case "MSG_CG_FRIEND_BLACK_DEL":
                    return Deserialize_MSG_CG_FRIEND_BLACK_DEL(stream);

                case "MSG_CG_FRIEND_RECOMMEND":
                    return Deserialize_MSG_CG_FRIEND_RECOMMEND(stream);

                case "MSG_CG_CREATE_GUILD":
                    return Deserialize_MSG_CG_CREATE_GUILD(stream);

                case "MSG_CG_CHAT_EMOJI":
                    return Deserialize_MSG_CG_CHAT_EMOJI(stream);

                case "MSG_CG_CHAT_WORDS":
                    return Deserialize_MSG_CG_CHAT_WORDS(stream);

                case "MSG_CG_CHANGE_WORLD_ROOM":
                    return Deserialize_MSG_CG_CHANGE_WORLD_ROOM(stream);

                case "MSG_CG_GET_WORLD_ROOM_LIST":
                    return Deserialize_MSG_CG_GET_WORLD_ROOM_LIST(stream);

                case "MSG_CG_CHAT_TRUMPET":
                    return Deserialize_MSG_CG_CHAT_TRUMPET(stream);

                case "MSG_CG_CHAT_REPORT":
                    return Deserialize_MSG_CG_CHAT_REPORT(stream);

                case "MSG_CG_NEARBY_EMOJI":
                    return Deserialize_MSG_CG_NEARBY_EMOJI(stream);

                case "MSG_CG_TIP_OFF":
                    return Deserialize_MSG_CG_TIP_OFF(stream);

                case "MSG_CG_ACTIVITY_CHAT_BUBBLE":
                    return Deserialize_MSG_CG_ACTIVITY_CHAT_BUBBLE(stream);

                case "MSG_CG_USE_CHAT_TRUMPET":
                    return Deserialize_MSG_CG_USE_CHAT_TRUMPET(stream);

                case "MSG_CG_TASK_COMPLETE":
                    return Deserialize_MSG_CG_TASK_COMPLETE(stream);

                case "MSG_CG_OPENE_EMAIL_TASK":
                    return Deserialize_MSG_CG_OPENE_EMAIL_TASK(stream);

                case "MSG_CG_TASK_COLLECT":
                    return Deserialize_MSG_CG_TASK_COLLECT(stream);

                case "MSG_CG_TASK_SELECT":
                    return Deserialize_MSG_CG_TASK_SELECT(stream);

                case "MSG_CG_TASK_MAKE":
                    return Deserialize_MSG_CG_TASK_MAKE(stream);

                case "MSG_CG_TASKFLY_FLY_DONE":
                    return Deserialize_MSG_CG_TASKFLY_FLY_DONE(stream);

                case "MSG_CG_TASKFLY_STARTPATHFINDING":
                    return Deserialize_MSG_CG_TASKFLY_STARTPATHFINDING(stream);

                case "MSG_CG_ACTIVITY_COMPLETE":
                    return Deserialize_MSG_CG_ACTIVITY_COMPLETE(stream);

                case "MSG_CG_SHOW_CHARACTER":
                    return Deserialize_MSG_CG_SHOW_CHARACTER(stream);

                case "MSG_CG_CHANGE_NAME":
                    return Deserialize_MSG_CG_CHANGE_NAME(stream);

                case "MSG_CG_SHOW_FACEICON":
                    return Deserialize_MSG_CG_SHOW_FACEICON(stream);

                case "MSG_CG_SHOW_FACEJPG":
                    return Deserialize_MSG_CG_SHOW_FACEJPG(stream);

                case "MSG_CG_SET_SEX":
                    return Deserialize_MSG_CG_SET_SEX(stream);

                case "MSG_CG_SET_BIRTHDAY":
                    return Deserialize_MSG_CG_SET_BIRTHDAY(stream);

                case "MSG_CG_SET_SIGNATURE":
                    return Deserialize_MSG_CG_SET_SIGNATURE(stream);

                case "MSG_CG_SHOW_VOICE":
                    return Deserialize_MSG_CG_SHOW_VOICE(stream);

                case "MSG_CG_PRESENT_GIFT":
                    return Deserialize_MSG_CG_PRESENT_GIFT(stream);

                case "MSG_CG_GET_GIFTRECORD":
                    return Deserialize_MSG_CG_GET_GIFTRECORD(stream);

                case "MSG_CG_SET_SOCIAL_NUM":
                    return Deserialize_MSG_CG_SET_SOCIAL_NUM(stream);

                case "MSG_CG_GET_SOCIAL_NUM":
                    return Deserialize_MSG_CG_GET_SOCIAL_NUM(stream);

                case "MSG_CG_SHOW_CAREER":
                    return Deserialize_MSG_CG_SHOW_CAREER(stream);

                case "MSG_CG_GET_RANKING_FRIEND_LIST":
                    return Deserialize_MSG_CG_GET_RANKING_FRIEND_LIST(stream);

                case "MSG_CG_GET_RANKING_ALL_LIST":
                    return Deserialize_MSG_CG_GET_RANKING_ALL_LIST(stream);

                case "MSG_CG_GET_RANKING_NEARBY_LIST":
                    return Deserialize_MSG_CG_GET_RANKING_NEARBY_LIST(stream);

                case "MSG_CG_CHANGE_TITLE":
                    return Deserialize_MSG_CG_CHANGE_TITLE(stream);

                case "MSG_CG_UPLOAD_PHOTO":
                    return Deserialize_MSG_CG_UPLOAD_PHOTO(stream);

                case "MSG_CG_REMOVE_PHOTO":
                    return Deserialize_MSG_CG_REMOVE_PHOTO(stream);

                case "MSG_CG_PHOTO_LIST":
                    return Deserialize_MSG_CG_PHOTO_LIST(stream);

                case "MSG_CG_POP_RANK":
                    return Deserialize_MSG_CG_POP_RANK(stream);

                case "MSG_CG_QUESTION":
                    return Deserialize_MSG_CG_QUESTION(stream);

                case "MSG_CG_QUESTIONNAIRE":
                    return Deserialize_MSG_CG_QUESTIONNAIRE(stream);

                case "MSG_CG_DAILY_QUESTION_COUNTER":
                    return Deserialize_MSG_CG_DAILY_QUESTION_COUNTER(stream);

                case "MSG_CG_DAILY_QUESTION_REWARD":
                    return Deserialize_MSG_CG_DAILY_QUESTION_REWARD(stream);

                case "MSG_CG_RADIO_GET_ALL_ANCHOR_RANK":
                    return Deserialize_MSG_CG_RADIO_GET_ALL_ANCHOR_RANK(stream);

                case "MSG_CG_RADIO_GET_ANCHOR_CONTRIBUTION_RANK":
                    return Deserialize_MSG_CG_RADIO_GET_ANCHOR_CONTRIBUTION_RANK(stream);

                case "MSG_CG_RADIO_GET_ALL_CONTRIBUTION_RANK":
                    return Deserialize_MSG_CG_RADIO_GET_ALL_CONTRIBUTION_RANK(stream);

                case "MSG_CG_RADIO_GET_CONTRIBUTION_REWARD":
                    return Deserialize_MSG_CG_RADIO_GET_CONTRIBUTION_REWARD(stream);

                case "MSG_CG_RADIO_GIVE_GIFT":
                    return Deserialize_MSG_CG_RADIO_GIVE_GIFT(stream);

                case "MSG_CG_RADIO_ENTER":
                    return Deserialize_MSG_CG_RADIO_ENTER(stream);

                case "MSG_CG_RADIO_LEAVE":
                    return Deserialize_MSG_CG_RADIO_LEAVE(stream);


                default:
                    return null;
            }
        }
        public void BindParser()
        {
            Parser.AddResponser_Msg(Id<MSG_GC_INSTANCES_REMOVE>.Value, OnResponse_MSG_GC_INSTANCES_REMOVE);

            Parser.AddResponser_Msg(Id<MODEL_INFO>.Value, OnResponse_MODEL_INFO);

            Parser.AddResponser_Msg(Id<MSG_GC_CHARACTER_INFO>.Value, OnResponse_MSG_GC_CHARACTER_INFO);

            Parser.AddResponser_Msg(Id<MSG_GC_CHARACTER_LIST>.Value, OnResponse_MSG_GC_CHARACTER_LIST);

            Parser.AddResponser_Msg(Id<MSG_GC_CREATE_CHARACTER>.Value, OnResponse_MSG_GC_CREATE_CHARACTER);

            Parser.AddResponser_Msg(Id<MSG_GC_TO_ZONE>.Value, OnResponse_MSG_GC_TO_ZONE);

            Parser.AddResponser_Msg(Id<MSG_GC_HEARTBEAT>.Value, OnResponse_MSG_GC_HEARTBEAT);

            Parser.AddResponser_Msg(Id<MSG_GC_ENTER_ZONE>.Value, OnResponse_MSG_GC_ENTER_ZONE);

            Parser.AddResponser_Msg(Id<MSG_GC_ENTER_WORLD>.Value, OnResponse_MSG_GC_ENTER_WORLD);

            Parser.AddResponser_Msg(Id<MSG_GC_TIME_SYNC>.Value, OnResponse_MSG_GC_TIME_SYNC);

            Parser.AddResponser_Msg(Id<MSG_ZGC_ERROR_CODE>.Value, OnResponse_MSG_ZGC_ERROR_CODE);

            Parser.AddResponser_Msg(Id<MSG_ZGC_NPC_INFO>.Value, OnResponse_MSG_ZGC_NPC_INFO);

            Parser.AddResponser_Msg(Id<MSG_ZGC_GOODS_INFO>.Value, OnResponse_MSG_ZGC_GOODS_INFO);

            Parser.AddResponser_Msg(Id<MSG_ZGC_INTERACTION>.Value, OnResponse_MSG_ZGC_INTERACTION);

            Parser.AddResponser_Msg(Id<MSG_GC_RECONNECT_LOGIN>.Value, OnResponse_MSG_GC_RECONNECT_LOGIN);

            Parser.AddResponser_Msg(Id<MSG_ZGC_LOGIN_FREEZE>.Value, OnResponse_MSG_ZGC_LOGIN_FREEZE);

            Parser.AddResponser_Msg(Id<MSG_GC_BLOWFISHKEY>.Value, OnResponse_MSG_GC_BLOWFISHKEY);

            Parser.AddResponser_Msg(Id<MSG_ZGC_SUGGEST>.Value, OnResponse_MSG_ZGC_SUGGEST);

            Parser.AddResponser_Msg(Id<MSG_ZGC_FIGHTING_COUNT>.Value, OnResponse_MSG_ZGC_FIGHTING_COUNT);

            Parser.AddResponser_Msg(Id<MSG_ZGC_FIRST_ADD_EXP>.Value, OnResponse_MSG_ZGC_FIRST_ADD_EXP);

            Parser.AddResponser_Msg(Id<MSG_ZGC_CHANGE_CHANNEL>.Value, OnResponse_MSG_ZGC_CHANGE_CHANNEL);

            Parser.AddResponser_Msg(Id<MSG_GC_FieldObject_MOVE>.Value, OnResponse_MSG_GC_FieldObject_MOVE);

            Parser.AddResponser_Msg(Id<MSG_ZGC_CHARACTER_STOP>.Value, OnResponse_MSG_ZGC_CHARACTER_STOP);

            Parser.AddResponser_Msg(Id<MSG_GC_CHAR_SIMPLE_INFO>.Value, OnResponse_MSG_GC_CHAR_SIMPLE_INFO);

            Parser.AddResponser_Msg(Id<MSG_GC_BROADCAST_INFO>.Value, OnResponse_MSG_GC_BROADCAST_INFO);

            Parser.AddResponser_Msg(Id<MSG_GC_BROADCAST_LIST>.Value, OnResponse_MSG_GC_BROADCAST_LIST);

            Parser.AddResponser_Msg(Id<MSG_GC_CHARACTER_ENTER_LIST>.Value, OnResponse_MSG_GC_CHARACTER_ENTER_LIST);

            Parser.AddResponser_Msg(Id<MSG_GC_CHARACTER_LEAVE>.Value, OnResponse_MSG_GC_CHARACTER_LEAVE);

            Parser.AddResponser_Msg(Id<MSG_ZGC_PET_SIMPLE_INFO>.Value, OnResponse_MSG_ZGC_PET_SIMPLE_INFO);

            Parser.AddResponser_Msg(Id<MSG_GC_PET_ENTER_LIST>.Value, OnResponse_MSG_GC_PET_ENTER_LIST);

            Parser.AddResponser_Msg(Id<MSG_ZGC_PET_LEAVE>.Value, OnResponse_MSG_ZGC_PET_LEAVE);

            Parser.AddResponser_Msg(Id<MSG_ZGC_NPC_MOVE>.Value, OnResponse_MSG_ZGC_NPC_MOVE);

            Parser.AddResponser_Msg(Id<MSG_ZGC_NPC_LEAVE>.Value, OnResponse_MSG_ZGC_NPC_LEAVE);

            Parser.AddResponser_Msg(Id<MSG_ZGC_NPC_SIMPLE_INFO>.Value, OnResponse_MSG_ZGC_NPC_SIMPLE_INFO);

            Parser.AddResponser_Msg(Id<MSG_GC_NPC_ENTER_LIST>.Value, OnResponse_MSG_GC_NPC_ENTER_LIST);

            Parser.AddResponser_Msg(Id<CURRENCY>.Value, OnResponse_CURRENCY);

            Parser.AddResponser_Msg(Id<MSG_ZGC_SYNC_CURRENCIES>.Value, OnResponse_MSG_ZGC_SYNC_CURRENCIES);

            Parser.AddResponser_Msg(Id<ZGC_COUNTER>.Value, OnResponse_ZGC_COUNTER);

            Parser.AddResponser_Msg(Id<MSG_ZGC_COUNTER_INFO>.Value, OnResponse_MSG_ZGC_COUNTER_INFO);

            Parser.AddResponser_Msg(Id<MSG_ZGC_PLAYER_LEVEL>.Value, OnResponse_MSG_ZGC_PLAYER_LEVEL);

            Parser.AddResponser_Msg(Id<MSG_ZGC_KNAPSACK_SYNC>.Value, OnResponse_MSG_ZGC_KNAPSACK_SYNC);

            Parser.AddResponser_Msg(Id<MSG_ZGC_KNAPSACK_UPDATE>.Value, OnResponse_MSG_ZGC_KNAPSACK_UPDATE);

            Parser.AddResponser_Msg(Id<MSG_ZGC_ITEM_USE>.Value, OnResponse_MSG_ZGC_ITEM_USE);

            Parser.AddResponser_Msg(Id<MSG_ZGC_ITEM_SELL>.Value, OnResponse_MSG_ZGC_ITEM_SELL);

            Parser.AddResponser_Msg(Id<MSG_ZGC_EQUIP_FACEFRAME>.Value, OnResponse_MSG_ZGC_EQUIP_FACEFRAME);

            Parser.AddResponser_Msg(Id<MSG_ZGC_ITEM_BUY>.Value, OnResponse_MSG_ZGC_ITEM_BUY);

            Parser.AddResponser_Msg(Id<REWARD_ITEM_INFO>.Value, OnResponse_REWARD_ITEM_INFO);

            Parser.AddResponser_Msg(Id<MSG_ZGC_USE_FIREWORKS>.Value, OnResponse_MSG_ZGC_USE_FIREWORKS);

            Parser.AddResponser_Msg(Id<ITEM>.Value, OnResponse_ITEM);

            Parser.AddResponser_Msg(Id<MSG_ZGC_EMAIL_REMIND>.Value, OnResponse_MSG_ZGC_EMAIL_REMIND);

            Parser.AddResponser_Msg(Id<MSG_ZGC_EMAIL_OPENE_BOX>.Value, OnResponse_MSG_ZGC_EMAIL_OPENE_BOX);

            Parser.AddResponser_Msg(Id<MSG_ZGC_EMAIL_ITEM>.Value, OnResponse_MSG_ZGC_EMAIL_ITEM);

            Parser.AddResponser_Msg(Id<MSG_ZGC_EMAIL_READ>.Value, OnResponse_MSG_ZGC_EMAIL_READ);

            Parser.AddResponser_Msg(Id<MSG_ZGC_ATTACHMENT_PICKUP>.Value, OnResponse_MSG_ZGC_ATTACHMENT_PICKUP);

            Parser.AddResponser_Msg(Id<MSG_ZGC_SHOP_ITEM>.Value, OnResponse_MSG_ZGC_SHOP_ITEM);

            Parser.AddResponser_Msg(Id<MSG_ZGC_SHOP_LIST>.Value, OnResponse_MSG_ZGC_SHOP_LIST);

            Parser.AddResponser_Msg(Id<MSG_ZGC_SHOP_BUY_RESULT>.Value, OnResponse_MSG_ZGC_SHOP_BUY_RESULT);

            Parser.AddResponser_Msg(Id<MSG_ZGC_SHOP_GET_SSR>.Value, OnResponse_MSG_ZGC_SHOP_GET_SSR);

            Parser.AddResponser_Msg(Id<MSG_ZGC_CONVERT_FISH_COIN>.Value, OnResponse_MSG_ZGC_CONVERT_FISH_COIN);

            Parser.AddResponser_Msg(Id<MSG_ZGC_RECHARGE_HISTORY>.Value, OnResponse_MSG_ZGC_RECHARGE_HISTORY);

            Parser.AddResponser_Msg(Id<MSG_ZGC_RECHARGE_INFO>.Value, OnResponse_MSG_ZGC_RECHARGE_INFO);

            Parser.AddResponser_Msg(Id<MSG_ZGC_RECHARGE_MANAGER>.Value, OnResponse_MSG_ZGC_RECHARGE_MANAGER);

            Parser.AddResponser_Msg(Id<PLAYER_BASE_INFO>.Value, OnResponse_PLAYER_BASE_INFO);

            Parser.AddResponser_Msg(Id<MSG_ZGC_FRIEND_SEARCH>.Value, OnResponse_MSG_ZGC_FRIEND_SEARCH);

            Parser.AddResponser_Msg(Id<MSG_ZGC_FRIEND_ADD_REQUEST>.Value, OnResponse_MSG_ZGC_FRIEND_ADD_REQUEST);

            Parser.AddResponser_Msg(Id<MSG_ZGC_FRIEND_ADD_RESPONSE>.Value, OnResponse_MSG_ZGC_FRIEND_ADD_RESPONSE);

            Parser.AddResponser_Msg(Id<MSG_ZGC_FRIEND_DELETE>.Value, OnResponse_MSG_ZGC_FRIEND_DELETE);

            Parser.AddResponser_Msg(Id<MSG_ZGC_FRIEND_LIST>.Value, OnResponse_MSG_ZGC_FRIEND_LIST);

            Parser.AddResponser_Msg(Id<FRIEND_REQUEST_INFO>.Value, OnResponse_FRIEND_REQUEST_INFO);

            Parser.AddResponser_Msg(Id<MSG_ZGC_FRIEND_REQUEST_LIST>.Value, OnResponse_MSG_ZGC_FRIEND_REQUEST_LIST);

            Parser.AddResponser_Msg(Id<MSG_ZGC_FRIEND_RECENT_LIST>.Value, OnResponse_MSG_ZGC_FRIEND_RECENT_LIST);

            Parser.AddResponser_Msg(Id<BLACK_INFO>.Value, OnResponse_BLACK_INFO);

            Parser.AddResponser_Msg(Id<MSG_ZGC_FRIEND_BLACK_LIST>.Value, OnResponse_MSG_ZGC_FRIEND_BLACK_LIST);

            Parser.AddResponser_Msg(Id<MSG_ZGC_FRIEND_BLACK_ADD>.Value, OnResponse_MSG_ZGC_FRIEND_BLACK_ADD);

            Parser.AddResponser_Msg(Id<MSG_ZGC_FRIEND_BLACK_DEL>.Value, OnResponse_MSG_ZGC_FRIEND_BLACK_DEL);

            Parser.AddResponser_Msg(Id<FRIEND_SEARCH_INFO>.Value, OnResponse_FRIEND_SEARCH_INFO);

            Parser.AddResponser_Msg(Id<MSG_ZGC_FRIEND_RECOMMEND>.Value, OnResponse_MSG_ZGC_FRIEND_RECOMMEND);

            Parser.AddResponser_Msg(Id<MSG_ZGC_RANKING_FRIEND_LIST>.Value, OnResponse_MSG_ZGC_RANKING_FRIEND_LIST);

            Parser.AddResponser_Msg(Id<MSG_ZGC_RANKING_ALL_LIST>.Value, OnResponse_MSG_ZGC_RANKING_ALL_LIST);

            Parser.AddResponser_Msg(Id<MSG_ZGC_RANKING_NEARBY_LIST>.Value, OnResponse_MSG_ZGC_RANKING_NEARBY_LIST);

            Parser.AddResponser_Msg(Id<MSG_ZGC_CREATE_GUILD>.Value, OnResponse_MSG_ZGC_CREATE_GUILD);

            Parser.AddResponser_Msg(Id<MSG_ZGC_CHAT_PLAYER_INFO>.Value, OnResponse_MSG_ZGC_CHAT_PLAYER_INFO);

            Parser.AddResponser_Msg(Id<MSG_ZGC_CHAT_WORDS>.Value, OnResponse_MSG_ZGC_CHAT_WORDS);

            Parser.AddResponser_Msg(Id<MSG_ZGC_PERSON_CHAT_WORDS>.Value, OnResponse_MSG_ZGC_PERSON_CHAT_WORDS);

            Parser.AddResponser_Msg(Id<MSG_GC_CHANGE_WORLD_ROOM>.Value, OnResponse_MSG_GC_CHANGE_WORLD_ROOM);

            Parser.AddResponser_Msg(Id<MSG_CMGC_WORLD_ROOM_INFO>.Value, OnResponse_MSG_CMGC_WORLD_ROOM_INFO);

            Parser.AddResponser_Msg(Id<MSG_CMGC_GET_WORLD_ROOM_LIST>.Value, OnResponse_MSG_CMGC_GET_WORLD_ROOM_LIST);

            Parser.AddResponser_Msg(Id<MSG_ZGC_CHAT_TRUMPET>.Value, OnResponse_MSG_ZGC_CHAT_TRUMPET);

            Parser.AddResponser_Msg(Id<MSG_ZGC_CHAT_TRUMPET_RESULT>.Value, OnResponse_MSG_ZGC_CHAT_TRUMPET_RESULT);

            Parser.AddResponser_Msg(Id<MSG_GC_ANNOUNCEMENT>.Value, OnResponse_MSG_GC_ANNOUNCEMENT);

            Parser.AddResponser_Msg(Id<MSG_ZGC_NEARBY_EMOJI>.Value, OnResponse_MSG_ZGC_NEARBY_EMOJI);

            Parser.AddResponser_Msg(Id<MSG_ZGC_TIP_OFF>.Value, OnResponse_MSG_ZGC_TIP_OFF);

            Parser.AddResponser_Msg(Id<MSG_ZGC_CHAT_BROADCAST>.Value, OnResponse_MSG_ZGC_CHAT_BROADCAST);

            Parser.AddResponser_Msg(Id<MSG_GC_NEARBY_ROOM>.Value, OnResponse_MSG_GC_NEARBY_ROOM);

            Parser.AddResponser_Msg(Id<MSG_ZGC_SILENCE>.Value, OnResponse_MSG_ZGC_SILENCE);

            Parser.AddResponser_Msg(Id<MSG_ZGC_ACTIVITY_CHAT_BUBBLE>.Value, OnResponse_MSG_ZGC_ACTIVITY_CHAT_BUBBLE);

            Parser.AddResponser_Msg(Id<MSG_ZGC_TASK_LIST>.Value, OnResponse_MSG_ZGC_TASK_LIST);

            Parser.AddResponser_Msg(Id<MSG_ZGC_TASK_INFO>.Value, OnResponse_MSG_ZGC_TASK_INFO);

            Parser.AddResponser_Msg(Id<MSG_ZGC_TASK_CHANGE>.Value, OnResponse_MSG_ZGC_TASK_CHANGE);

            Parser.AddResponser_Msg(Id<MSG_ZGC_GET_TASK_RESULT>.Value, OnResponse_MSG_ZGC_GET_TASK_RESULT);

            Parser.AddResponser_Msg(Id<MSG_ZGC_TASK_COLLECT>.Value, OnResponse_MSG_ZGC_TASK_COLLECT);

            Parser.AddResponser_Msg(Id<MSG_ZGC_TASK_COMPLETE>.Value, OnResponse_MSG_ZGC_TASK_COMPLETE);

            Parser.AddResponser_Msg(Id<MSG_ZGC_USE_TASKFLY_ANSWER>.Value, OnResponse_MSG_ZGC_USE_TASKFLY_ANSWER);

            Parser.AddResponser_Msg(Id<MSG_ZGC_TASKFLY_POSITION_SETDONE>.Value, OnResponse_MSG_ZGC_TASKFLY_POSITION_SETDONE);

            Parser.AddResponser_Msg(Id<MSG_ZGC_TASK_BATTLE_REWARD>.Value, OnResponse_MSG_ZGC_TASK_BATTLE_REWARD);

            Parser.AddResponser_Msg(Id<MSG_ZGC_ACTIVITY_LIST>.Value, OnResponse_MSG_ZGC_ACTIVITY_LIST);

            Parser.AddResponser_Msg(Id<MSG_ZGC_ACTIVITY_INFO>.Value, OnResponse_MSG_ZGC_ACTIVITY_INFO);

            Parser.AddResponser_Msg(Id<MSG_ZGC_ACTIVITY_CHANGE>.Value, OnResponse_MSG_ZGC_ACTIVITY_CHANGE);

            Parser.AddResponser_Msg(Id<MSG_ZGC_ACTIVITY_COMPLETE>.Value, OnResponse_MSG_ZGC_ACTIVITY_COMPLETE);

            Parser.AddResponser_Msg(Id<MSG_ZGC_QUESTIONNAIRE_COMPLETE>.Value, OnResponse_MSG_ZGC_QUESTIONNAIRE_COMPLETE);

            Parser.AddResponser_Msg(Id<MSG_GC_LOGIN_WAIT_QUEUE>.Value, OnResponse_MSG_GC_LOGIN_WAIT_QUEUE);

            Parser.AddResponser_Msg(Id<MSG_ZGC_DAILY_QUESTION_COUNTER>.Value, OnResponse_MSG_ZGC_DAILY_QUESTION_COUNTER);

            Parser.AddResponser_Msg(Id<MSG_ZGC_DAILY_QUESTION_REWARD>.Value, OnResponse_MSG_ZGC_DAILY_QUESTION_REWARD);

            Parser.AddResponser_Msg(Id<MSG_ZGC_SHOW_CHARACTER>.Value, OnResponse_MSG_ZGC_SHOW_CHARACTER);

            Parser.AddResponser_Msg(Id<SHOW_CHARACTERINFO>.Value, OnResponse_SHOW_CHARACTERINFO);

            Parser.AddResponser_Msg(Id<SHOW_SPACEINFO>.Value, OnResponse_SHOW_SPACEINFO);

            Parser.AddResponser_Msg(Id<MSG_ZGC_CHANGE_NAME>.Value, OnResponse_MSG_ZGC_CHANGE_NAME);

            Parser.AddResponser_Msg(Id<MSG_ZGC_SHOW_FACEICON>.Value, OnResponse_MSG_ZGC_SHOW_FACEICON);

            Parser.AddResponser_Msg(Id<MSG_ZGC_SHOW_FACEJPG>.Value, OnResponse_MSG_ZGC_SHOW_FACEJPG);

            Parser.AddResponser_Msg(Id<MSG_ZGC_SET_SEX>.Value, OnResponse_MSG_ZGC_SET_SEX);

            Parser.AddResponser_Msg(Id<MSG_ZGC_SET_BIRTHDAY>.Value, OnResponse_MSG_ZGC_SET_BIRTHDAY);

            Parser.AddResponser_Msg(Id<MSG_ZGC_SET_SIGNATURE>.Value, OnResponse_MSG_ZGC_SET_SIGNATURE);

            Parser.AddResponser_Msg(Id<MSG_ZGC_SHOW_VOICE>.Value, OnResponse_MSG_ZGC_SHOW_VOICE);

            Parser.AddResponser_Msg(Id<MSG_ZGC_PRESENT_GIFT>.Value, OnResponse_MSG_ZGC_PRESENT_GIFT);

            Parser.AddResponser_Msg(Id<MSG_ZGC_SET_SOCIAL_NUM>.Value, OnResponse_MSG_ZGC_SET_SOCIAL_NUM);

            Parser.AddResponser_Msg(Id<MSG_ZGC_GET_SOCIAL_NUM>.Value, OnResponse_MSG_ZGC_GET_SOCIAL_NUM);

            Parser.AddResponser_Msg(Id<MSG_ZGC_GEOGRAPHY>.Value, OnResponse_MSG_ZGC_GEOGRAPHY);

            Parser.AddResponser_Msg(Id<MSG_ZGC_UPDATE_SOME_SHOW>.Value, OnResponse_MSG_ZGC_UPDATE_SOME_SHOW);

            Parser.AddResponser_Msg(Id<MSG_ZGC_SHOW_CAREER>.Value, OnResponse_MSG_ZGC_SHOW_CAREER);

            Parser.AddResponser_Msg(Id<MSG_ZGC_CAREER_ITEM>.Value, OnResponse_MSG_ZGC_CAREER_ITEM);

            Parser.AddResponser_Msg(Id<MSG_ZGC_GET_GIFTRECORD>.Value, OnResponse_MSG_ZGC_GET_GIFTRECORD);

            Parser.AddResponser_Msg(Id<MSG_ZGC_TITLE_INFO>.Value, OnResponse_MSG_ZGC_TITLE_INFO);

            Parser.AddResponser_Msg(Id<MSG_ZGC_CHANGE_TITLE_ANSWER>.Value, OnResponse_MSG_ZGC_CHANGE_TITLE_ANSWER);

            Parser.AddResponser_Msg(Id<MSG_ZGC_UPLOAD_PHOTO>.Value, OnResponse_MSG_ZGC_UPLOAD_PHOTO);

            Parser.AddResponser_Msg(Id<MSG_ZGC_REMOVE_PHOTO>.Value, OnResponse_MSG_ZGC_REMOVE_PHOTO);

            Parser.AddResponser_Msg(Id<MSG_ZGC_PHOTO_LIST>.Value, OnResponse_MSG_ZGC_PHOTO_LIST);

            Parser.AddResponser_Msg(Id<POP_RANK_PLAYER>.Value, OnResponse_POP_RANK_PLAYER);

            Parser.AddResponser_Msg(Id<MSG_ZGC_POP_RANK>.Value, OnResponse_MSG_ZGC_POP_RANK);

            Parser.AddResponser_Msg(Id<MSG_ZGC_RADIO_ALL_ANCHOR_RANK>.Value, OnResponse_MSG_ZGC_RADIO_ALL_ANCHOR_RANK);

            Parser.AddResponser_Msg(Id<MSG_ZGC_RADIO_ANCHOR_CONTRIBUTION_RANK>.Value, OnResponse_MSG_ZGC_RADIO_ANCHOR_CONTRIBUTION_RANK);

            Parser.AddResponser_Msg(Id<MSG_ZGC_RADIO_ALL_CONTRIBUTION_RANK>.Value, OnResponse_MSG_ZGC_RADIO_ALL_CONTRIBUTION_RANK);

            Parser.AddResponser_Msg(Id<MSG_ZGC_RADIO_CONTRIBUTION_REWARD>.Value, OnResponse_MSG_ZGC_RADIO_CONTRIBUTION_REWARD);

            Parser.AddResponser_Msg(Id<MSG_ZGC_RADIO_GIFT>.Value, OnResponse_MSG_ZGC_RADIO_GIFT);

            Parser.AddResponser_Msg(Id<MSG_ZGC_ANCHOR_INFO>.Value, OnResponse_MSG_ZGC_ANCHOR_INFO);

            Parser.AddResponser_Msg(Id<MSG_BC_HEARTBEAT>.Value, OnResponse_MSG_BC_HEARTBEAT);

            Parser.AddResponser_Msg(Id<MSG_BC_USER_LOGIN>.Value, OnResponse_MSG_BC_USER_LOGIN);

            Parser.AddResponser_Msg(Id<MSG_BC_LOGIN_SERVERS>.Value, OnResponse_MSG_BC_LOGIN_SERVERS);


        }
        public bool RouteSend(ComnunicationClient net, string className, object msg)
        {
            switch (className)
            {
                case "MSG_CG_CHARACTER_LIST":
                    return net.Send((MSG_CG_CHARACTER_LIST)msg);

                case "MSG_CG_ITEM_BUY":
                    return net.Send((MSG_CG_ITEM_BUY)msg);

                case "MSG_CG_CREATE_CHARACTER":
                    return net.Send((MSG_CG_CREATE_CHARACTER)msg);

                case "MSG_CG_TO_ZONE":
                    return net.Send((MSG_CG_TO_ZONE)msg);

                case "MSG_CG_MAP_LOADING_DONE":
                    return net.Send((MSG_CG_MAP_LOADING_DONE)msg);

                case "MSG_CG_HEARTBEAT":
                    return net.Send((MSG_CG_HEARTBEAT)msg);

                case "MSG_CG_SHIP_STEP":
                    return net.Send((MSG_CG_SHIP_STEP)msg);

                case "MSG_CG_CHARACTER_MOVE":
                    return net.Send((MSG_CG_CHARACTER_MOVE)msg);

                case "MSG_CG_MOVE_ZONE":
                    return net.Send((MSG_CG_MOVE_ZONE)msg);

                case "MSG_CG_AUTOPATHFINDING":
                    return net.Send((MSG_CG_AUTOPATHFINDING)msg);

                case "MSG_CG_GEOGRAPHY":
                    return net.Send((MSG_CG_GEOGRAPHY)msg);

                case "MSG_CG_RECONNECT_LOGIN":
                    return net.Send((MSG_CG_RECONNECT_LOGIN)msg);

                case "MSG_CG_CROSS_PORTAL":
                    return net.Send((MSG_CG_CROSS_PORTAL)msg);

                case "MSG_CG_GET_BLOWFISHKEY":
                    return net.Send((MSG_CG_GET_BLOWFISHKEY)msg);

                case "MSG_CG_SUGGEST":
                    return net.Send((MSG_CG_SUGGEST)msg);

                case "MSG_CG_LOGOUT":
                    return net.Send((MSG_CG_LOGOUT)msg);

                case "MSG_CG_SAVE_GUIDE_ID":
                    return net.Send((MSG_CG_SAVE_GUIDE_ID)msg);

                case "MSG_CG_SAVE_MAIN_LINE_ID":
                    return net.Send((MSG_CG_SAVE_MAIN_LINE_ID)msg);

                case "MSG_CG_SAVE_GAME_COMMENT":
                    return net.Send((MSG_CG_SAVE_GAME_COMMENT)msg);

                case "MSG_CG_CHANGE_CHANNEL":
                    return net.Send((MSG_CG_CHANGE_CHANNEL)msg);

                case "MSG_CG_ITEM_USE":
                    return net.Send((MSG_CG_ITEM_USE)msg);

                case "MSG_CG_ITEM_SELL":
                    return net.Send((MSG_CG_ITEM_SELL)msg);

                case "MSG_CG_USE_FIREWORKS":
                    return net.Send((MSG_CG_USE_FIREWORKS)msg);

                case "MSG_CG_EMAIL_READ":
                    return net.Send((MSG_CG_EMAIL_READ)msg);

                case "MSG_CG_PICKUP_ATTACHMENT":
                    return net.Send((MSG_CG_PICKUP_ATTACHMENT)msg);

                case "MSG_CG_EMAIL_OPENE_BOX":
                    return net.Send((MSG_CG_EMAIL_OPENE_BOX)msg);

                case "MSG_CG_SHOP_BUY_ITEM":
                    return net.Send((MSG_CG_SHOP_BUY_ITEM)msg);

                case "MSG_CG_SHOP_GET_SSR":
                    return net.Send((MSG_CG_SHOP_GET_SSR)msg);

                case "MSG_CG_REFRESH_SHOP_ITEM":
                    return net.Send((MSG_CG_REFRESH_SHOP_ITEM)msg);

                case "MSG_CG_CONVERT_FISH_COIN":
                    return net.Send((MSG_CG_CONVERT_FISH_COIN)msg);

                case "MSG_CG_SAVE_ORDER":
                    return net.Send((MSG_CG_SAVE_ORDER)msg);

                case "MSG_CG_GET_RECHARGE_HISTORY":
                    return net.Send((MSG_CG_GET_RECHARGE_HISTORY)msg);

                case "MSG_CG_DELETE_RECHARGE_HISTORY":
                    return net.Send((MSG_CG_DELETE_RECHARGE_HISTORY)msg);

                case "MSG_CG_FRIEND_SEARCH":
                    return net.Send((MSG_CG_FRIEND_SEARCH)msg);

                case "MSG_CG_FRIEND_ADD_REQUEST":
                    return net.Send((MSG_CG_FRIEND_ADD_REQUEST)msg);

                case "MSG_CG_FRIEND_ADD_RESPONSE":
                    return net.Send((MSG_CG_FRIEND_ADD_RESPONSE)msg);

                case "MSG_CG_FRIEND_DELETE":
                    return net.Send((MSG_CG_FRIEND_DELETE)msg);

                case "MSG_CG_FRIEND_REQUEST_LIST":
                    return net.Send((MSG_CG_FRIEND_REQUEST_LIST)msg);

                case "MSG_CG_FRIEND_RECENT_LIST":
                    return net.Send((MSG_CG_FRIEND_RECENT_LIST)msg);

                case "MSG_CG_FRIEND_BLACK_LIST":
                    return net.Send((MSG_CG_FRIEND_BLACK_LIST)msg);

                case "MSG_CG_FRIEND_LIST":
                    return net.Send((MSG_CG_FRIEND_LIST)msg);

                case "MSG_CG_FRIEND_BLACK_ADD":
                    return net.Send((MSG_CG_FRIEND_BLACK_ADD)msg);

                case "MSG_CG_FRIEND_BLACK_DEL":
                    return net.Send((MSG_CG_FRIEND_BLACK_DEL)msg);

                case "MSG_CG_FRIEND_RECOMMEND":
                    return net.Send((MSG_CG_FRIEND_RECOMMEND)msg);

                case "MSG_CG_CREATE_GUILD":
                    return net.Send((MSG_CG_CREATE_GUILD)msg);

                case "MSG_CG_CHAT_EMOJI":
                    return net.Send((MSG_CG_CHAT_EMOJI)msg);

                case "MSG_CG_CHAT_WORDS":
                    return net.Send((MSG_CG_CHAT_WORDS)msg);

                case "MSG_CG_CHANGE_WORLD_ROOM":
                    return net.Send((MSG_CG_CHANGE_WORLD_ROOM)msg);

                case "MSG_CG_GET_WORLD_ROOM_LIST":
                    return net.Send((MSG_CG_GET_WORLD_ROOM_LIST)msg);

                case "MSG_CG_CHAT_TRUMPET":
                    return net.Send((MSG_CG_CHAT_TRUMPET)msg);

                case "MSG_CG_CHAT_REPORT":
                    return net.Send((MSG_CG_CHAT_REPORT)msg);

                case "MSG_CG_NEARBY_EMOJI":
                    return net.Send((MSG_CG_NEARBY_EMOJI)msg);

                case "MSG_CG_TIP_OFF":
                    return net.Send((MSG_CG_TIP_OFF)msg);

                case "MSG_CG_ACTIVITY_CHAT_BUBBLE":
                    return net.Send((MSG_CG_ACTIVITY_CHAT_BUBBLE)msg);

                case "MSG_CG_USE_CHAT_TRUMPET":
                    return net.Send((MSG_CG_USE_CHAT_TRUMPET)msg);

                case "MSG_CG_TASK_COMPLETE":
                    return net.Send((MSG_CG_TASK_COMPLETE)msg);

                case "MSG_CG_OPENE_EMAIL_TASK":
                    return net.Send((MSG_CG_OPENE_EMAIL_TASK)msg);

                case "MSG_CG_TASK_COLLECT":
                    return net.Send((MSG_CG_TASK_COLLECT)msg);

                case "MSG_CG_TASK_SELECT":
                    return net.Send((MSG_CG_TASK_SELECT)msg);

                case "MSG_CG_TASK_MAKE":
                    return net.Send((MSG_CG_TASK_MAKE)msg);

                case "MSG_CG_TASKFLY_FLY_DONE":
                    return net.Send((MSG_CG_TASKFLY_FLY_DONE)msg);

                case "MSG_CG_TASKFLY_STARTPATHFINDING":
                    return net.Send((MSG_CG_TASKFLY_STARTPATHFINDING)msg);

                case "MSG_CG_ACTIVITY_COMPLETE":
                    return net.Send((MSG_CG_ACTIVITY_COMPLETE)msg);

                case "MSG_CG_SHOW_CHARACTER":
                    return net.Send((MSG_CG_SHOW_CHARACTER)msg);

                case "MSG_CG_CHANGE_NAME":
                    return net.Send((MSG_CG_CHANGE_NAME)msg);

                case "MSG_CG_SHOW_FACEICON":
                    return net.Send((MSG_CG_SHOW_FACEICON)msg);

                case "MSG_CG_SHOW_FACEJPG":
                    return net.Send((MSG_CG_SHOW_FACEJPG)msg);

                case "MSG_CG_SET_SEX":
                    return net.Send((MSG_CG_SET_SEX)msg);

                case "MSG_CG_SET_BIRTHDAY":
                    return net.Send((MSG_CG_SET_BIRTHDAY)msg);

                case "MSG_CG_SET_SIGNATURE":
                    return net.Send((MSG_CG_SET_SIGNATURE)msg);

                case "MSG_CG_SHOW_VOICE":
                    return net.Send((MSG_CG_SHOW_VOICE)msg);

                case "MSG_CG_PRESENT_GIFT":
                    return net.Send((MSG_CG_PRESENT_GIFT)msg);

                case "MSG_CG_GET_GIFTRECORD":
                    return net.Send((MSG_CG_GET_GIFTRECORD)msg);

                case "MSG_CG_SET_SOCIAL_NUM":
                    return net.Send((MSG_CG_SET_SOCIAL_NUM)msg);

                case "MSG_CG_GET_SOCIAL_NUM":
                    return net.Send((MSG_CG_GET_SOCIAL_NUM)msg);

                case "MSG_CG_SHOW_CAREER":
                    return net.Send((MSG_CG_SHOW_CAREER)msg);

                case "MSG_CG_GET_RANKING_FRIEND_LIST":
                    return net.Send((MSG_CG_GET_RANKING_FRIEND_LIST)msg);

                case "MSG_CG_GET_RANKING_ALL_LIST":
                    return net.Send((MSG_CG_GET_RANKING_ALL_LIST)msg);

                case "MSG_CG_GET_RANKING_NEARBY_LIST":
                    return net.Send((MSG_CG_GET_RANKING_NEARBY_LIST)msg);

                case "MSG_CG_CHANGE_TITLE":
                    return net.Send((MSG_CG_CHANGE_TITLE)msg);

                case "MSG_CG_UPLOAD_PHOTO":
                    return net.Send((MSG_CG_UPLOAD_PHOTO)msg);

                case "MSG_CG_REMOVE_PHOTO":
                    return net.Send((MSG_CG_REMOVE_PHOTO)msg);

                case "MSG_CG_PHOTO_LIST":
                    return net.Send((MSG_CG_PHOTO_LIST)msg);

                case "MSG_CG_POP_RANK":
                    return net.Send((MSG_CG_POP_RANK)msg);

                case "MSG_CG_QUESTION":
                    return net.Send((MSG_CG_QUESTION)msg);

                case "MSG_CG_QUESTIONNAIRE":
                    return net.Send((MSG_CG_QUESTIONNAIRE)msg);

                case "MSG_CG_DAILY_QUESTION_COUNTER":
                    return net.Send((MSG_CG_DAILY_QUESTION_COUNTER)msg);

                case "MSG_CG_DAILY_QUESTION_REWARD":
                    return net.Send((MSG_CG_DAILY_QUESTION_REWARD)msg);

                case "MSG_CG_RADIO_GET_ALL_ANCHOR_RANK":
                    return net.Send((MSG_CG_RADIO_GET_ALL_ANCHOR_RANK)msg);

                case "MSG_CG_RADIO_GET_ANCHOR_CONTRIBUTION_RANK":
                    return net.Send((MSG_CG_RADIO_GET_ANCHOR_CONTRIBUTION_RANK)msg);

                case "MSG_CG_RADIO_GET_ALL_CONTRIBUTION_RANK":
                    return net.Send((MSG_CG_RADIO_GET_ALL_CONTRIBUTION_RANK)msg);

                case "MSG_CG_RADIO_GET_CONTRIBUTION_REWARD":
                    return net.Send((MSG_CG_RADIO_GET_CONTRIBUTION_REWARD)msg);

                case "MSG_CG_RADIO_GIVE_GIFT":
                    return net.Send((MSG_CG_RADIO_GIVE_GIFT)msg);

                case "MSG_CG_RADIO_ENTER":
                    return net.Send((MSG_CG_RADIO_ENTER)msg);

                case "MSG_CG_RADIO_LEAVE":
                    return net.Send((MSG_CG_RADIO_LEAVE)msg);


                default:
                    return false;
            }
        }
        public void BindMsgId()
        {
            Message.Server.Gate.Protocol.GateC.Api.GenerateId();
            Message.Server.Client.Protocol.CGate.Api.GenerateId();
            Message.Server.Barrack.Protocol.BarrackC.Api.GenerateId();
            Message.Server.Client.Protocol.CBarrack.Api.GenerateId();
        }

    }
}

