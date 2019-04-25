using System.IO;
 using System.Collections.Generic;
using Message.Client.Protocol.CGate;
using Message.Client.Protocol.CBarrack;
using Message.Gate.Protocol.GateC;
using Message.Barrack.Protocol.BarrackC;
using ProtocolObjectParserLib;
using Message.IdGenerator;

namespace ProtocolObjectLib
{
public class ProtoMsgManager
{
public void OnResponse_MSG_GC_CHARACTER_INFO(MemoryStream stream,out string msgName)
{
MSG_GC_CHARACTER_INFO MSG_GC_CHARACTER_INFO = MessagePacker.ProtobufHelper.Deserialize<MSG_GC_CHARACTER_INFO>(stream);
msgName = "MSG_GC_CHARACTER_INFO";
Parser.Parse(MSG_GC_CHARACTER_INFO);
}
public object Deserialize_MSG_GC_CHARACTER_INFO(MemoryStream stream)
{
return  MessagePacker.ProtobufHelper.Deserialize<MSG_GC_CHARACTER_INFO>(stream);
}

public void OnResponse_MSG_GC_CHARACTER_LIST(MemoryStream stream,out string msgName)
{
MSG_GC_CHARACTER_LIST MSG_GC_CHARACTER_LIST = MessagePacker.ProtobufHelper.Deserialize<MSG_GC_CHARACTER_LIST>(stream);
msgName = "MSG_GC_CHARACTER_LIST";
Parser.Parse(MSG_GC_CHARACTER_LIST);
}
public object Deserialize_MSG_GC_CHARACTER_LIST(MemoryStream stream)
{
return  MessagePacker.ProtobufHelper.Deserialize<MSG_GC_CHARACTER_LIST>(stream);
}

public void OnResponse_MSG_GC_CREATE_CHARACTER(MemoryStream stream,out string msgName)
{
MSG_GC_CREATE_CHARACTER MSG_GC_CREATE_CHARACTER = MessagePacker.ProtobufHelper.Deserialize<MSG_GC_CREATE_CHARACTER>(stream);
msgName = "MSG_GC_CREATE_CHARACTER";
Parser.Parse(MSG_GC_CREATE_CHARACTER);
}
public object Deserialize_MSG_GC_CREATE_CHARACTER(MemoryStream stream)
{
return  MessagePacker.ProtobufHelper.Deserialize<MSG_GC_CREATE_CHARACTER>(stream);
}

public void OnResponse_MSG_GC_TO_ZONE(MemoryStream stream,out string msgName)
{
MSG_GC_TO_ZONE MSG_GC_TO_ZONE = MessagePacker.ProtobufHelper.Deserialize<MSG_GC_TO_ZONE>(stream);
msgName = "MSG_GC_TO_ZONE";
Parser.Parse(MSG_GC_TO_ZONE);
}
public object Deserialize_MSG_GC_TO_ZONE(MemoryStream stream)
{
return  MessagePacker.ProtobufHelper.Deserialize<MSG_GC_TO_ZONE>(stream);
}

public void OnResponse_MSG_GC_HEARTBEAT(MemoryStream stream,out string msgName)
{
MSG_GC_HEARTBEAT MSG_GC_HEARTBEAT = MessagePacker.ProtobufHelper.Deserialize<MSG_GC_HEARTBEAT>(stream);
msgName = "MSG_GC_HEARTBEAT";
Parser.Parse(MSG_GC_HEARTBEAT);
}
public object Deserialize_MSG_GC_HEARTBEAT(MemoryStream stream)
{
return  MessagePacker.ProtobufHelper.Deserialize<MSG_GC_HEARTBEAT>(stream);
}

public void OnResponse_MSG_GC_ENTER_ZONE(MemoryStream stream,out string msgName)
{
MSG_GC_ENTER_ZONE MSG_GC_ENTER_ZONE = MessagePacker.ProtobufHelper.Deserialize<MSG_GC_ENTER_ZONE>(stream);
msgName = "MSG_GC_ENTER_ZONE";
Parser.Parse(MSG_GC_ENTER_ZONE);
}
public object Deserialize_MSG_GC_ENTER_ZONE(MemoryStream stream)
{
return  MessagePacker.ProtobufHelper.Deserialize<MSG_GC_ENTER_ZONE>(stream);
}

public void OnResponse_MSG_GC_ENTER_WORLD(MemoryStream stream,out string msgName)
{
MSG_GC_ENTER_WORLD MSG_GC_ENTER_WORLD = MessagePacker.ProtobufHelper.Deserialize<MSG_GC_ENTER_WORLD>(stream);
msgName = "MSG_GC_ENTER_WORLD";
Parser.Parse(MSG_GC_ENTER_WORLD);
}
public object Deserialize_MSG_GC_ENTER_WORLD(MemoryStream stream)
{
return  MessagePacker.ProtobufHelper.Deserialize<MSG_GC_ENTER_WORLD>(stream);
}

public void OnResponse_MSG_GC_TIME_SYNC(MemoryStream stream,out string msgName)
{
MSG_GC_TIME_SYNC MSG_GC_TIME_SYNC = MessagePacker.ProtobufHelper.Deserialize<MSG_GC_TIME_SYNC>(stream);
msgName = "MSG_GC_TIME_SYNC";
Parser.Parse(MSG_GC_TIME_SYNC);
}
public object Deserialize_MSG_GC_TIME_SYNC(MemoryStream stream)
{
return  MessagePacker.ProtobufHelper.Deserialize<MSG_GC_TIME_SYNC>(stream);
}

public void OnResponse_MSG_ZGC_ERROR_CODE(MemoryStream stream,out string msgName)
{
MSG_ZGC_ERROR_CODE MSG_ZGC_ERROR_CODE = MessagePacker.ProtobufHelper.Deserialize<MSG_ZGC_ERROR_CODE>(stream);
msgName = "MSG_ZGC_ERROR_CODE";
Parser.Parse(MSG_ZGC_ERROR_CODE);
}
public object Deserialize_MSG_ZGC_ERROR_CODE(MemoryStream stream)
{
return  MessagePacker.ProtobufHelper.Deserialize<MSG_ZGC_ERROR_CODE>(stream);
}

public void OnResponse_MSG_ZGC_NPC_INFO(MemoryStream stream,out string msgName)
{
MSG_ZGC_NPC_INFO MSG_ZGC_NPC_INFO = MessagePacker.ProtobufHelper.Deserialize<MSG_ZGC_NPC_INFO>(stream);
msgName = "MSG_ZGC_NPC_INFO";
Parser.Parse(MSG_ZGC_NPC_INFO);
}
public object Deserialize_MSG_ZGC_NPC_INFO(MemoryStream stream)
{
return  MessagePacker.ProtobufHelper.Deserialize<MSG_ZGC_NPC_INFO>(stream);
}

public void OnResponse_MSG_ZGC_GOODS_INFO(MemoryStream stream,out string msgName)
{
MSG_ZGC_GOODS_INFO MSG_ZGC_GOODS_INFO = MessagePacker.ProtobufHelper.Deserialize<MSG_ZGC_GOODS_INFO>(stream);
msgName = "MSG_ZGC_GOODS_INFO";
Parser.Parse(MSG_ZGC_GOODS_INFO);
}
public object Deserialize_MSG_ZGC_GOODS_INFO(MemoryStream stream)
{
return  MessagePacker.ProtobufHelper.Deserialize<MSG_ZGC_GOODS_INFO>(stream);
}

public void OnResponse_MSG_ZGC_INTERACTION(MemoryStream stream,out string msgName)
{
MSG_ZGC_INTERACTION MSG_ZGC_INTERACTION = MessagePacker.ProtobufHelper.Deserialize<MSG_ZGC_INTERACTION>(stream);
msgName = "MSG_ZGC_INTERACTION";
Parser.Parse(MSG_ZGC_INTERACTION);
}
public object Deserialize_MSG_ZGC_INTERACTION(MemoryStream stream)
{
return  MessagePacker.ProtobufHelper.Deserialize<MSG_ZGC_INTERACTION>(stream);
}

public void OnResponse_MSG_GC_RECONNECT_LOGIN(MemoryStream stream,out string msgName)
{
MSG_GC_RECONNECT_LOGIN MSG_GC_RECONNECT_LOGIN = MessagePacker.ProtobufHelper.Deserialize<MSG_GC_RECONNECT_LOGIN>(stream);
msgName = "MSG_GC_RECONNECT_LOGIN";
Parser.Parse(MSG_GC_RECONNECT_LOGIN);
}
public object Deserialize_MSG_GC_RECONNECT_LOGIN(MemoryStream stream)
{
return  MessagePacker.ProtobufHelper.Deserialize<MSG_GC_RECONNECT_LOGIN>(stream);
}

public void OnResponse_MSG_ZGC_LOGIN_FREEZE(MemoryStream stream,out string msgName)
{
MSG_ZGC_LOGIN_FREEZE MSG_ZGC_LOGIN_FREEZE = MessagePacker.ProtobufHelper.Deserialize<MSG_ZGC_LOGIN_FREEZE>(stream);
msgName = "MSG_ZGC_LOGIN_FREEZE";
Parser.Parse(MSG_ZGC_LOGIN_FREEZE);
}
public object Deserialize_MSG_ZGC_LOGIN_FREEZE(MemoryStream stream)
{
return  MessagePacker.ProtobufHelper.Deserialize<MSG_ZGC_LOGIN_FREEZE>(stream);
}

public void OnResponse_MSG_GC_BLOWFISHKEY(MemoryStream stream,out string msgName)
{
MSG_GC_BLOWFISHKEY MSG_GC_BLOWFISHKEY = MessagePacker.ProtobufHelper.Deserialize<MSG_GC_BLOWFISHKEY>(stream);
msgName = "MSG_GC_BLOWFISHKEY";
Parser.Parse(MSG_GC_BLOWFISHKEY);
}
public object Deserialize_MSG_GC_BLOWFISHKEY(MemoryStream stream)
{
return  MessagePacker.ProtobufHelper.Deserialize<MSG_GC_BLOWFISHKEY>(stream);
}

public void OnResponse_MSG_ZGC_SUGGEST(MemoryStream stream,out string msgName)
{
MSG_ZGC_SUGGEST MSG_ZGC_SUGGEST = MessagePacker.ProtobufHelper.Deserialize<MSG_ZGC_SUGGEST>(stream);
msgName = "MSG_ZGC_SUGGEST";
Parser.Parse(MSG_ZGC_SUGGEST);
}
public object Deserialize_MSG_ZGC_SUGGEST(MemoryStream stream)
{
return  MessagePacker.ProtobufHelper.Deserialize<MSG_ZGC_SUGGEST>(stream);
}

public void OnResponse_MSG_ZGC_FIGHTING_COUNT(MemoryStream stream,out string msgName)
{
MSG_ZGC_FIGHTING_COUNT MSG_ZGC_FIGHTING_COUNT = MessagePacker.ProtobufHelper.Deserialize<MSG_ZGC_FIGHTING_COUNT>(stream);
msgName = "MSG_ZGC_FIGHTING_COUNT";
Parser.Parse(MSG_ZGC_FIGHTING_COUNT);
}
public object Deserialize_MSG_ZGC_FIGHTING_COUNT(MemoryStream stream)
{
return  MessagePacker.ProtobufHelper.Deserialize<MSG_ZGC_FIGHTING_COUNT>(stream);
}

public void OnResponse_MSG_ZGC_FIRST_ADD_EXP(MemoryStream stream,out string msgName)
{
MSG_ZGC_FIRST_ADD_EXP MSG_ZGC_FIRST_ADD_EXP = MessagePacker.ProtobufHelper.Deserialize<MSG_ZGC_FIRST_ADD_EXP>(stream);
msgName = "MSG_ZGC_FIRST_ADD_EXP";
Parser.Parse(MSG_ZGC_FIRST_ADD_EXP);
}
public object Deserialize_MSG_ZGC_FIRST_ADD_EXP(MemoryStream stream)
{
return  MessagePacker.ProtobufHelper.Deserialize<MSG_ZGC_FIRST_ADD_EXP>(stream);
}

public void OnResponse_MSG_ZGC_CHANGE_CHANNEL(MemoryStream stream,out string msgName)
{
MSG_ZGC_CHANGE_CHANNEL MSG_ZGC_CHANGE_CHANNEL = MessagePacker.ProtobufHelper.Deserialize<MSG_ZGC_CHANGE_CHANNEL>(stream);
msgName = "MSG_ZGC_CHANGE_CHANNEL";
Parser.Parse(MSG_ZGC_CHANGE_CHANNEL);
}
public object Deserialize_MSG_ZGC_CHANGE_CHANNEL(MemoryStream stream)
{
return  MessagePacker.ProtobufHelper.Deserialize<MSG_ZGC_CHANGE_CHANNEL>(stream);
}

public void OnResponse_MSG_GC_FieldObject_MOVE(MemoryStream stream,out string msgName)
{
MSG_GC_FieldObject_MOVE MSG_GC_FieldObject_MOVE = MessagePacker.ProtobufHelper.Deserialize<MSG_GC_FieldObject_MOVE>(stream);
msgName = "MSG_GC_FieldObject_MOVE";
Parser.Parse(MSG_GC_FieldObject_MOVE);
}
public object Deserialize_MSG_GC_FieldObject_MOVE(MemoryStream stream)
{
return  MessagePacker.ProtobufHelper.Deserialize<MSG_GC_FieldObject_MOVE>(stream);
}

public void OnResponse_MSG_ZGC_CHARACTER_STOP(MemoryStream stream,out string msgName)
{
MSG_ZGC_CHARACTER_STOP MSG_ZGC_CHARACTER_STOP = MessagePacker.ProtobufHelper.Deserialize<MSG_ZGC_CHARACTER_STOP>(stream);
msgName = "MSG_ZGC_CHARACTER_STOP";
Parser.Parse(MSG_ZGC_CHARACTER_STOP);
}
public object Deserialize_MSG_ZGC_CHARACTER_STOP(MemoryStream stream)
{
return  MessagePacker.ProtobufHelper.Deserialize<MSG_ZGC_CHARACTER_STOP>(stream);
}

public void OnResponse_MSG_GC_CHAR_SIMPLE_INFO(MemoryStream stream,out string msgName)
{
MSG_GC_CHAR_SIMPLE_INFO MSG_GC_CHAR_SIMPLE_INFO = MessagePacker.ProtobufHelper.Deserialize<MSG_GC_CHAR_SIMPLE_INFO>(stream);
msgName = "MSG_GC_CHAR_SIMPLE_INFO";
Parser.Parse(MSG_GC_CHAR_SIMPLE_INFO);
}
public object Deserialize_MSG_GC_CHAR_SIMPLE_INFO(MemoryStream stream)
{
return  MessagePacker.ProtobufHelper.Deserialize<MSG_GC_CHAR_SIMPLE_INFO>(stream);
}

public void OnResponse_MSG_GC_BROADCAST_INFO(MemoryStream stream,out string msgName)
{
MSG_GC_BROADCAST_INFO MSG_GC_BROADCAST_INFO = MessagePacker.ProtobufHelper.Deserialize<MSG_GC_BROADCAST_INFO>(stream);
msgName = "MSG_GC_BROADCAST_INFO";
Parser.Parse(MSG_GC_BROADCAST_INFO);
}
public object Deserialize_MSG_GC_BROADCAST_INFO(MemoryStream stream)
{
return  MessagePacker.ProtobufHelper.Deserialize<MSG_GC_BROADCAST_INFO>(stream);
}

public void OnResponse_MSG_GC_BROADCAST_LIST(MemoryStream stream,out string msgName)
{
MSG_GC_BROADCAST_LIST MSG_GC_BROADCAST_LIST = MessagePacker.ProtobufHelper.Deserialize<MSG_GC_BROADCAST_LIST>(stream);
msgName = "MSG_GC_BROADCAST_LIST";
Parser.Parse(MSG_GC_BROADCAST_LIST);
}
public object Deserialize_MSG_GC_BROADCAST_LIST(MemoryStream stream)
{
return  MessagePacker.ProtobufHelper.Deserialize<MSG_GC_BROADCAST_LIST>(stream);
}

public void OnResponse_MSG_GC_CHARACTER_ENTER_LIST(MemoryStream stream,out string msgName)
{
MSG_GC_CHARACTER_ENTER_LIST MSG_GC_CHARACTER_ENTER_LIST = MessagePacker.ProtobufHelper.Deserialize<MSG_GC_CHARACTER_ENTER_LIST>(stream);
msgName = "MSG_GC_CHARACTER_ENTER_LIST";
Parser.Parse(MSG_GC_CHARACTER_ENTER_LIST);
}
public object Deserialize_MSG_GC_CHARACTER_ENTER_LIST(MemoryStream stream)
{
return  MessagePacker.ProtobufHelper.Deserialize<MSG_GC_CHARACTER_ENTER_LIST>(stream);
}

public void OnResponse_MSG_GC_CHARACTER_LEAVE(MemoryStream stream,out string msgName)
{
MSG_GC_CHARACTER_LEAVE MSG_GC_CHARACTER_LEAVE = MessagePacker.ProtobufHelper.Deserialize<MSG_GC_CHARACTER_LEAVE>(stream);
msgName = "MSG_GC_CHARACTER_LEAVE";
Parser.Parse(MSG_GC_CHARACTER_LEAVE);
}
public object Deserialize_MSG_GC_CHARACTER_LEAVE(MemoryStream stream)
{
return  MessagePacker.ProtobufHelper.Deserialize<MSG_GC_CHARACTER_LEAVE>(stream);
}

public void OnResponse_MSG_GC_INSTANCES_REMOVE(MemoryStream stream,out string msgName)
{
MSG_GC_INSTANCES_REMOVE MSG_GC_INSTANCES_REMOVE = MessagePacker.ProtobufHelper.Deserialize<MSG_GC_INSTANCES_REMOVE>(stream);
msgName = "MSG_GC_INSTANCES_REMOVE";
Parser.Parse(MSG_GC_INSTANCES_REMOVE);
}
public object Deserialize_MSG_GC_INSTANCES_REMOVE(MemoryStream stream)
{
return  MessagePacker.ProtobufHelper.Deserialize<MSG_GC_INSTANCES_REMOVE>(stream);
}

public void OnResponse_MSG_ZGC_PET_SIMPLE_INFO(MemoryStream stream,out string msgName)
{
MSG_ZGC_PET_SIMPLE_INFO MSG_ZGC_PET_SIMPLE_INFO = MessagePacker.ProtobufHelper.Deserialize<MSG_ZGC_PET_SIMPLE_INFO>(stream);
msgName = "MSG_ZGC_PET_SIMPLE_INFO";
Parser.Parse(MSG_ZGC_PET_SIMPLE_INFO);
}
public object Deserialize_MSG_ZGC_PET_SIMPLE_INFO(MemoryStream stream)
{
return  MessagePacker.ProtobufHelper.Deserialize<MSG_ZGC_PET_SIMPLE_INFO>(stream);
}

public void OnResponse_MSG_GC_PET_ENTER_LIST(MemoryStream stream,out string msgName)
{
MSG_GC_PET_ENTER_LIST MSG_GC_PET_ENTER_LIST = MessagePacker.ProtobufHelper.Deserialize<MSG_GC_PET_ENTER_LIST>(stream);
msgName = "MSG_GC_PET_ENTER_LIST";
Parser.Parse(MSG_GC_PET_ENTER_LIST);
}
public object Deserialize_MSG_GC_PET_ENTER_LIST(MemoryStream stream)
{
return  MessagePacker.ProtobufHelper.Deserialize<MSG_GC_PET_ENTER_LIST>(stream);
}

public void OnResponse_MSG_ZGC_PET_LEAVE(MemoryStream stream,out string msgName)
{
MSG_ZGC_PET_LEAVE MSG_ZGC_PET_LEAVE = MessagePacker.ProtobufHelper.Deserialize<MSG_ZGC_PET_LEAVE>(stream);
msgName = "MSG_ZGC_PET_LEAVE";
Parser.Parse(MSG_ZGC_PET_LEAVE);
}
public object Deserialize_MSG_ZGC_PET_LEAVE(MemoryStream stream)
{
return  MessagePacker.ProtobufHelper.Deserialize<MSG_ZGC_PET_LEAVE>(stream);
}

public void OnResponse_MSG_ZGC_NPC_MOVE(MemoryStream stream,out string msgName)
{
MSG_ZGC_NPC_MOVE MSG_ZGC_NPC_MOVE = MessagePacker.ProtobufHelper.Deserialize<MSG_ZGC_NPC_MOVE>(stream);
msgName = "MSG_ZGC_NPC_MOVE";
Parser.Parse(MSG_ZGC_NPC_MOVE);
}
public object Deserialize_MSG_ZGC_NPC_MOVE(MemoryStream stream)
{
return  MessagePacker.ProtobufHelper.Deserialize<MSG_ZGC_NPC_MOVE>(stream);
}

public void OnResponse_MSG_ZGC_NPC_LEAVE(MemoryStream stream,out string msgName)
{
MSG_ZGC_NPC_LEAVE MSG_ZGC_NPC_LEAVE = MessagePacker.ProtobufHelper.Deserialize<MSG_ZGC_NPC_LEAVE>(stream);
msgName = "MSG_ZGC_NPC_LEAVE";
Parser.Parse(MSG_ZGC_NPC_LEAVE);
}
public object Deserialize_MSG_ZGC_NPC_LEAVE(MemoryStream stream)
{
return  MessagePacker.ProtobufHelper.Deserialize<MSG_ZGC_NPC_LEAVE>(stream);
}

public void OnResponse_MSG_ZGC_NPC_SIMPLE_INFO(MemoryStream stream,out string msgName)
{
MSG_ZGC_NPC_SIMPLE_INFO MSG_ZGC_NPC_SIMPLE_INFO = MessagePacker.ProtobufHelper.Deserialize<MSG_ZGC_NPC_SIMPLE_INFO>(stream);
msgName = "MSG_ZGC_NPC_SIMPLE_INFO";
Parser.Parse(MSG_ZGC_NPC_SIMPLE_INFO);
}
public object Deserialize_MSG_ZGC_NPC_SIMPLE_INFO(MemoryStream stream)
{
return  MessagePacker.ProtobufHelper.Deserialize<MSG_ZGC_NPC_SIMPLE_INFO>(stream);
}

public void OnResponse_MSG_GC_NPC_ENTER_LIST(MemoryStream stream,out string msgName)
{
MSG_GC_NPC_ENTER_LIST MSG_GC_NPC_ENTER_LIST = MessagePacker.ProtobufHelper.Deserialize<MSG_GC_NPC_ENTER_LIST>(stream);
msgName = "MSG_GC_NPC_ENTER_LIST";
Parser.Parse(MSG_GC_NPC_ENTER_LIST);
}
public object Deserialize_MSG_GC_NPC_ENTER_LIST(MemoryStream stream)
{
return  MessagePacker.ProtobufHelper.Deserialize<MSG_GC_NPC_ENTER_LIST>(stream);
}

public void OnResponse_MSG_ZGC_MONSTER_SIMPLE_INFO(MemoryStream stream,out string msgName)
{
MSG_ZGC_MONSTER_SIMPLE_INFO MSG_ZGC_MONSTER_SIMPLE_INFO = MessagePacker.ProtobufHelper.Deserialize<MSG_ZGC_MONSTER_SIMPLE_INFO>(stream);
msgName = "MSG_ZGC_MONSTER_SIMPLE_INFO";
Parser.Parse(MSG_ZGC_MONSTER_SIMPLE_INFO);
}
public object Deserialize_MSG_ZGC_MONSTER_SIMPLE_INFO(MemoryStream stream)
{
return  MessagePacker.ProtobufHelper.Deserialize<MSG_ZGC_MONSTER_SIMPLE_INFO>(stream);
}

public void OnResponse_MSG_ZGC_MONSTER_INFO(MemoryStream stream,out string msgName)
{
MSG_ZGC_MONSTER_INFO MSG_ZGC_MONSTER_INFO = MessagePacker.ProtobufHelper.Deserialize<MSG_ZGC_MONSTER_INFO>(stream);
msgName = "MSG_ZGC_MONSTER_INFO";
Parser.Parse(MSG_ZGC_MONSTER_INFO);
}
public object Deserialize_MSG_ZGC_MONSTER_INFO(MemoryStream stream)
{
return  MessagePacker.ProtobufHelper.Deserialize<MSG_ZGC_MONSTER_INFO>(stream);
}

public void OnResponse_MSG_ZGC_MONSTER_LEAVE(MemoryStream stream,out string msgName)
{
MSG_ZGC_MONSTER_LEAVE MSG_ZGC_MONSTER_LEAVE = MessagePacker.ProtobufHelper.Deserialize<MSG_ZGC_MONSTER_LEAVE>(stream);
msgName = "MSG_ZGC_MONSTER_LEAVE";
Parser.Parse(MSG_ZGC_MONSTER_LEAVE);
}
public object Deserialize_MSG_ZGC_MONSTER_LEAVE(MemoryStream stream)
{
return  MessagePacker.ProtobufHelper.Deserialize<MSG_ZGC_MONSTER_LEAVE>(stream);
}

public void OnResponse_MSG_GC_MONSTER_ENTER_LIST(MemoryStream stream,out string msgName)
{
MSG_GC_MONSTER_ENTER_LIST MSG_GC_MONSTER_ENTER_LIST = MessagePacker.ProtobufHelper.Deserialize<MSG_GC_MONSTER_ENTER_LIST>(stream);
msgName = "MSG_GC_MONSTER_ENTER_LIST";
Parser.Parse(MSG_GC_MONSTER_ENTER_LIST);
}
public object Deserialize_MSG_GC_MONSTER_ENTER_LIST(MemoryStream stream)
{
return  MessagePacker.ProtobufHelper.Deserialize<MSG_GC_MONSTER_ENTER_LIST>(stream);
}

public void OnResponse_MSG_ZGC_CHARACTER_HP(MemoryStream stream,out string msgName)
{
MSG_ZGC_CHARACTER_HP MSG_ZGC_CHARACTER_HP = MessagePacker.ProtobufHelper.Deserialize<MSG_ZGC_CHARACTER_HP>(stream);
msgName = "MSG_ZGC_CHARACTER_HP";
Parser.Parse(MSG_ZGC_CHARACTER_HP);
}
public object Deserialize_MSG_ZGC_CHARACTER_HP(MemoryStream stream)
{
return  MessagePacker.ProtobufHelper.Deserialize<MSG_ZGC_CHARACTER_HP>(stream);
}

public void OnResponse_MSG_ZGC_HERO_SIMPLE_INFO(MemoryStream stream,out string msgName)
{
MSG_ZGC_HERO_SIMPLE_INFO MSG_ZGC_HERO_SIMPLE_INFO = MessagePacker.ProtobufHelper.Deserialize<MSG_ZGC_HERO_SIMPLE_INFO>(stream);
msgName = "MSG_ZGC_HERO_SIMPLE_INFO";
Parser.Parse(MSG_ZGC_HERO_SIMPLE_INFO);
}
public object Deserialize_MSG_ZGC_HERO_SIMPLE_INFO(MemoryStream stream)
{
return  MessagePacker.ProtobufHelper.Deserialize<MSG_ZGC_HERO_SIMPLE_INFO>(stream);
}

public void OnResponse_MSG_GC_HERO_ENTER_LIST(MemoryStream stream,out string msgName)
{
MSG_GC_HERO_ENTER_LIST MSG_GC_HERO_ENTER_LIST = MessagePacker.ProtobufHelper.Deserialize<MSG_GC_HERO_ENTER_LIST>(stream);
msgName = "MSG_GC_HERO_ENTER_LIST";
Parser.Parse(MSG_GC_HERO_ENTER_LIST);
}
public object Deserialize_MSG_GC_HERO_ENTER_LIST(MemoryStream stream)
{
return  MessagePacker.ProtobufHelper.Deserialize<MSG_GC_HERO_ENTER_LIST>(stream);
}

public void OnResponse_MSG_ZGC_HERO_LEAVE(MemoryStream stream,out string msgName)
{
MSG_ZGC_HERO_LEAVE MSG_ZGC_HERO_LEAVE = MessagePacker.ProtobufHelper.Deserialize<MSG_ZGC_HERO_LEAVE>(stream);
msgName = "MSG_ZGC_HERO_LEAVE";
Parser.Parse(MSG_ZGC_HERO_LEAVE);
}
public object Deserialize_MSG_ZGC_HERO_LEAVE(MemoryStream stream)
{
return  MessagePacker.ProtobufHelper.Deserialize<MSG_ZGC_HERO_LEAVE>(stream);
}

public void OnResponse_MSG_ZGC_SYNC_CURRENCIES(MemoryStream stream,out string msgName)
{
MSG_ZGC_SYNC_CURRENCIES MSG_ZGC_SYNC_CURRENCIES = MessagePacker.ProtobufHelper.Deserialize<MSG_ZGC_SYNC_CURRENCIES>(stream);
msgName = "MSG_ZGC_SYNC_CURRENCIES";
Parser.Parse(MSG_ZGC_SYNC_CURRENCIES);
}
public object Deserialize_MSG_ZGC_SYNC_CURRENCIES(MemoryStream stream)
{
return  MessagePacker.ProtobufHelper.Deserialize<MSG_ZGC_SYNC_CURRENCIES>(stream);
}

public void OnResponse_MSG_ZGC_COUNTER_INFO(MemoryStream stream,out string msgName)
{
MSG_ZGC_COUNTER_INFO MSG_ZGC_COUNTER_INFO = MessagePacker.ProtobufHelper.Deserialize<MSG_ZGC_COUNTER_INFO>(stream);
msgName = "MSG_ZGC_COUNTER_INFO";
Parser.Parse(MSG_ZGC_COUNTER_INFO);
}
public object Deserialize_MSG_ZGC_COUNTER_INFO(MemoryStream stream)
{
return  MessagePacker.ProtobufHelper.Deserialize<MSG_ZGC_COUNTER_INFO>(stream);
}

public void OnResponse_MSG_ZGC_PLAYER_LEVEL(MemoryStream stream,out string msgName)
{
MSG_ZGC_PLAYER_LEVEL MSG_ZGC_PLAYER_LEVEL = MessagePacker.ProtobufHelper.Deserialize<MSG_ZGC_PLAYER_LEVEL>(stream);
msgName = "MSG_ZGC_PLAYER_LEVEL";
Parser.Parse(MSG_ZGC_PLAYER_LEVEL);
}
public object Deserialize_MSG_ZGC_PLAYER_LEVEL(MemoryStream stream)
{
return  MessagePacker.ProtobufHelper.Deserialize<MSG_ZGC_PLAYER_LEVEL>(stream);
}

public void OnResponse_MSG_ZGC_BAG_SYNC(MemoryStream stream,out string msgName)
{
MSG_ZGC_BAG_SYNC MSG_ZGC_BAG_SYNC = MessagePacker.ProtobufHelper.Deserialize<MSG_ZGC_BAG_SYNC>(stream);
msgName = "MSG_ZGC_BAG_SYNC";
Parser.Parse(MSG_ZGC_BAG_SYNC);
}
public object Deserialize_MSG_ZGC_BAG_SYNC(MemoryStream stream)
{
return  MessagePacker.ProtobufHelper.Deserialize<MSG_ZGC_BAG_SYNC>(stream);
}

public void OnResponse_MSG_ZGC_BAG_UPDATE(MemoryStream stream,out string msgName)
{
MSG_ZGC_BAG_UPDATE MSG_ZGC_BAG_UPDATE = MessagePacker.ProtobufHelper.Deserialize<MSG_ZGC_BAG_UPDATE>(stream);
msgName = "MSG_ZGC_BAG_UPDATE";
Parser.Parse(MSG_ZGC_BAG_UPDATE);
}
public object Deserialize_MSG_ZGC_BAG_UPDATE(MemoryStream stream)
{
return  MessagePacker.ProtobufHelper.Deserialize<MSG_ZGC_BAG_UPDATE>(stream);
}

public void OnResponse_MSG_ZGC_BAG_DILATATION(MemoryStream stream,out string msgName)
{
MSG_ZGC_BAG_DILATATION MSG_ZGC_BAG_DILATATION = MessagePacker.ProtobufHelper.Deserialize<MSG_ZGC_BAG_DILATATION>(stream);
msgName = "MSG_ZGC_BAG_DILATATION";
Parser.Parse(MSG_ZGC_BAG_DILATATION);
}
public object Deserialize_MSG_ZGC_BAG_DILATATION(MemoryStream stream)
{
return  MessagePacker.ProtobufHelper.Deserialize<MSG_ZGC_BAG_DILATATION>(stream);
}

public void OnResponse_MSG_ZGC_ITEM_USE(MemoryStream stream,out string msgName)
{
MSG_ZGC_ITEM_USE MSG_ZGC_ITEM_USE = MessagePacker.ProtobufHelper.Deserialize<MSG_ZGC_ITEM_USE>(stream);
msgName = "MSG_ZGC_ITEM_USE";
Parser.Parse(MSG_ZGC_ITEM_USE);
}
public object Deserialize_MSG_ZGC_ITEM_USE(MemoryStream stream)
{
return  MessagePacker.ProtobufHelper.Deserialize<MSG_ZGC_ITEM_USE>(stream);
}

public void OnResponse_MSG_ZGC_ITEM_SELL(MemoryStream stream,out string msgName)
{
MSG_ZGC_ITEM_SELL MSG_ZGC_ITEM_SELL = MessagePacker.ProtobufHelper.Deserialize<MSG_ZGC_ITEM_SELL>(stream);
msgName = "MSG_ZGC_ITEM_SELL";
Parser.Parse(MSG_ZGC_ITEM_SELL);
}
public object Deserialize_MSG_ZGC_ITEM_SELL(MemoryStream stream)
{
return  MessagePacker.ProtobufHelper.Deserialize<MSG_ZGC_ITEM_SELL>(stream);
}

public void OnResponse_MSG_ZGC_EQUIP_FACEFRAME(MemoryStream stream,out string msgName)
{
MSG_ZGC_EQUIP_FACEFRAME MSG_ZGC_EQUIP_FACEFRAME = MessagePacker.ProtobufHelper.Deserialize<MSG_ZGC_EQUIP_FACEFRAME>(stream);
msgName = "MSG_ZGC_EQUIP_FACEFRAME";
Parser.Parse(MSG_ZGC_EQUIP_FACEFRAME);
}
public object Deserialize_MSG_ZGC_EQUIP_FACEFRAME(MemoryStream stream)
{
return  MessagePacker.ProtobufHelper.Deserialize<MSG_ZGC_EQUIP_FACEFRAME>(stream);
}

public void OnResponse_MSG_ZGC_ITEM_BUY(MemoryStream stream,out string msgName)
{
MSG_ZGC_ITEM_BUY MSG_ZGC_ITEM_BUY = MessagePacker.ProtobufHelper.Deserialize<MSG_ZGC_ITEM_BUY>(stream);
msgName = "MSG_ZGC_ITEM_BUY";
Parser.Parse(MSG_ZGC_ITEM_BUY);
}
public object Deserialize_MSG_ZGC_ITEM_BUY(MemoryStream stream)
{
return  MessagePacker.ProtobufHelper.Deserialize<MSG_ZGC_ITEM_BUY>(stream);
}

public void OnResponse_MSG_ZGC_USE_FIREWORKS(MemoryStream stream,out string msgName)
{
MSG_ZGC_USE_FIREWORKS MSG_ZGC_USE_FIREWORKS = MessagePacker.ProtobufHelper.Deserialize<MSG_ZGC_USE_FIREWORKS>(stream);
msgName = "MSG_ZGC_USE_FIREWORKS";
Parser.Parse(MSG_ZGC_USE_FIREWORKS);
}
public object Deserialize_MSG_ZGC_USE_FIREWORKS(MemoryStream stream)
{
return  MessagePacker.ProtobufHelper.Deserialize<MSG_ZGC_USE_FIREWORKS>(stream);
}

public void OnResponse_MSG_ZGC_ITEM_COMPOSE(MemoryStream stream,out string msgName)
{
MSG_ZGC_ITEM_COMPOSE MSG_ZGC_ITEM_COMPOSE = MessagePacker.ProtobufHelper.Deserialize<MSG_ZGC_ITEM_COMPOSE>(stream);
msgName = "MSG_ZGC_ITEM_COMPOSE";
Parser.Parse(MSG_ZGC_ITEM_COMPOSE);
}
public object Deserialize_MSG_ZGC_ITEM_COMPOSE(MemoryStream stream)
{
return  MessagePacker.ProtobufHelper.Deserialize<MSG_ZGC_ITEM_COMPOSE>(stream);
}

public void OnResponse_MSG_ZGC_ITEM_RESOLVE(MemoryStream stream,out string msgName)
{
MSG_ZGC_ITEM_RESOLVE MSG_ZGC_ITEM_RESOLVE = MessagePacker.ProtobufHelper.Deserialize<MSG_ZGC_ITEM_RESOLVE>(stream);
msgName = "MSG_ZGC_ITEM_RESOLVE";
Parser.Parse(MSG_ZGC_ITEM_RESOLVE);
}
public object Deserialize_MSG_ZGC_ITEM_RESOLVE(MemoryStream stream)
{
return  MessagePacker.ProtobufHelper.Deserialize<MSG_ZGC_ITEM_RESOLVE>(stream);
}

public void OnResponse_MSG_ZGC_SOUL_BONE_ITEM(MemoryStream stream,out string msgName)
{
MSG_ZGC_SOUL_BONE_ITEM MSG_ZGC_SOUL_BONE_ITEM = MessagePacker.ProtobufHelper.Deserialize<MSG_ZGC_SOUL_BONE_ITEM>(stream);
msgName = "MSG_ZGC_SOUL_BONE_ITEM";
Parser.Parse(MSG_ZGC_SOUL_BONE_ITEM);
}
public object Deserialize_MSG_ZGC_SOUL_BONE_ITEM(MemoryStream stream)
{
return  MessagePacker.ProtobufHelper.Deserialize<MSG_ZGC_SOUL_BONE_ITEM>(stream);
}

public void OnResponse_MSG_ZGC_SOULBONE_SMELT_RESULT(MemoryStream stream,out string msgName)
{
MSG_ZGC_SOULBONE_SMELT_RESULT MSG_ZGC_SOULBONE_SMELT_RESULT = MessagePacker.ProtobufHelper.Deserialize<MSG_ZGC_SOULBONE_SMELT_RESULT>(stream);
msgName = "MSG_ZGC_SOULBONE_SMELT_RESULT";
Parser.Parse(MSG_ZGC_SOULBONE_SMELT_RESULT);
}
public object Deserialize_MSG_ZGC_SOULBONE_SMELT_RESULT(MemoryStream stream)
{
return  MessagePacker.ProtobufHelper.Deserialize<MSG_ZGC_SOULBONE_SMELT_RESULT>(stream);
}

public void OnResponse_MSG_ZGC_EQUIP_SOULBONE_RESULT(MemoryStream stream,out string msgName)
{
MSG_ZGC_EQUIP_SOULBONE_RESULT MSG_ZGC_EQUIP_SOULBONE_RESULT = MessagePacker.ProtobufHelper.Deserialize<MSG_ZGC_EQUIP_SOULBONE_RESULT>(stream);
msgName = "MSG_ZGC_EQUIP_SOULBONE_RESULT";
Parser.Parse(MSG_ZGC_EQUIP_SOULBONE_RESULT);
}
public object Deserialize_MSG_ZGC_EQUIP_SOULBONE_RESULT(MemoryStream stream)
{
return  MessagePacker.ProtobufHelper.Deserialize<MSG_ZGC_EQUIP_SOULBONE_RESULT>(stream);
}

public void OnResponse_MSG_ZGC_EMAIL_REMIND(MemoryStream stream,out string msgName)
{
MSG_ZGC_EMAIL_REMIND MSG_ZGC_EMAIL_REMIND = MessagePacker.ProtobufHelper.Deserialize<MSG_ZGC_EMAIL_REMIND>(stream);
msgName = "MSG_ZGC_EMAIL_REMIND";
Parser.Parse(MSG_ZGC_EMAIL_REMIND);
}
public object Deserialize_MSG_ZGC_EMAIL_REMIND(MemoryStream stream)
{
return  MessagePacker.ProtobufHelper.Deserialize<MSG_ZGC_EMAIL_REMIND>(stream);
}

public void OnResponse_MSG_ZGC_EMAIL_OPENE_BOX(MemoryStream stream,out string msgName)
{
MSG_ZGC_EMAIL_OPENE_BOX MSG_ZGC_EMAIL_OPENE_BOX = MessagePacker.ProtobufHelper.Deserialize<MSG_ZGC_EMAIL_OPENE_BOX>(stream);
msgName = "MSG_ZGC_EMAIL_OPENE_BOX";
Parser.Parse(MSG_ZGC_EMAIL_OPENE_BOX);
}
public object Deserialize_MSG_ZGC_EMAIL_OPENE_BOX(MemoryStream stream)
{
return  MessagePacker.ProtobufHelper.Deserialize<MSG_ZGC_EMAIL_OPENE_BOX>(stream);
}

public void OnResponse_MSG_ZGC_EMAIL_ITEM(MemoryStream stream,out string msgName)
{
MSG_ZGC_EMAIL_ITEM MSG_ZGC_EMAIL_ITEM = MessagePacker.ProtobufHelper.Deserialize<MSG_ZGC_EMAIL_ITEM>(stream);
msgName = "MSG_ZGC_EMAIL_ITEM";
Parser.Parse(MSG_ZGC_EMAIL_ITEM);
}
public object Deserialize_MSG_ZGC_EMAIL_ITEM(MemoryStream stream)
{
return  MessagePacker.ProtobufHelper.Deserialize<MSG_ZGC_EMAIL_ITEM>(stream);
}

public void OnResponse_MSG_ZGC_EMAIL_READ(MemoryStream stream,out string msgName)
{
MSG_ZGC_EMAIL_READ MSG_ZGC_EMAIL_READ = MessagePacker.ProtobufHelper.Deserialize<MSG_ZGC_EMAIL_READ>(stream);
msgName = "MSG_ZGC_EMAIL_READ";
Parser.Parse(MSG_ZGC_EMAIL_READ);
}
public object Deserialize_MSG_ZGC_EMAIL_READ(MemoryStream stream)
{
return  MessagePacker.ProtobufHelper.Deserialize<MSG_ZGC_EMAIL_READ>(stream);
}

public void OnResponse_MSG_ZGC_ATTACHMENT_PICKUP(MemoryStream stream,out string msgName)
{
MSG_ZGC_ATTACHMENT_PICKUP MSG_ZGC_ATTACHMENT_PICKUP = MessagePacker.ProtobufHelper.Deserialize<MSG_ZGC_ATTACHMENT_PICKUP>(stream);
msgName = "MSG_ZGC_ATTACHMENT_PICKUP";
Parser.Parse(MSG_ZGC_ATTACHMENT_PICKUP);
}
public object Deserialize_MSG_ZGC_ATTACHMENT_PICKUP(MemoryStream stream)
{
return  MessagePacker.ProtobufHelper.Deserialize<MSG_ZGC_ATTACHMENT_PICKUP>(stream);
}

public void OnResponse_MSG_ZGC_SHOP_ITEM(MemoryStream stream,out string msgName)
{
MSG_ZGC_SHOP_ITEM MSG_ZGC_SHOP_ITEM = MessagePacker.ProtobufHelper.Deserialize<MSG_ZGC_SHOP_ITEM>(stream);
msgName = "MSG_ZGC_SHOP_ITEM";
Parser.Parse(MSG_ZGC_SHOP_ITEM);
}
public object Deserialize_MSG_ZGC_SHOP_ITEM(MemoryStream stream)
{
return  MessagePacker.ProtobufHelper.Deserialize<MSG_ZGC_SHOP_ITEM>(stream);
}

public void OnResponse_MSG_ZGC_SHOP_LIST(MemoryStream stream,out string msgName)
{
MSG_ZGC_SHOP_LIST MSG_ZGC_SHOP_LIST = MessagePacker.ProtobufHelper.Deserialize<MSG_ZGC_SHOP_LIST>(stream);
msgName = "MSG_ZGC_SHOP_LIST";
Parser.Parse(MSG_ZGC_SHOP_LIST);
}
public object Deserialize_MSG_ZGC_SHOP_LIST(MemoryStream stream)
{
return  MessagePacker.ProtobufHelper.Deserialize<MSG_ZGC_SHOP_LIST>(stream);
}

public void OnResponse_MSG_ZGC_SHOP_BUY_RESULT(MemoryStream stream,out string msgName)
{
MSG_ZGC_SHOP_BUY_RESULT MSG_ZGC_SHOP_BUY_RESULT = MessagePacker.ProtobufHelper.Deserialize<MSG_ZGC_SHOP_BUY_RESULT>(stream);
msgName = "MSG_ZGC_SHOP_BUY_RESULT";
Parser.Parse(MSG_ZGC_SHOP_BUY_RESULT);
}
public object Deserialize_MSG_ZGC_SHOP_BUY_RESULT(MemoryStream stream)
{
return  MessagePacker.ProtobufHelper.Deserialize<MSG_ZGC_SHOP_BUY_RESULT>(stream);
}

public void OnResponse_MSG_ZGC_SHOP_GET_SSR(MemoryStream stream,out string msgName)
{
MSG_ZGC_SHOP_GET_SSR MSG_ZGC_SHOP_GET_SSR = MessagePacker.ProtobufHelper.Deserialize<MSG_ZGC_SHOP_GET_SSR>(stream);
msgName = "MSG_ZGC_SHOP_GET_SSR";
Parser.Parse(MSG_ZGC_SHOP_GET_SSR);
}
public object Deserialize_MSG_ZGC_SHOP_GET_SSR(MemoryStream stream)
{
return  MessagePacker.ProtobufHelper.Deserialize<MSG_ZGC_SHOP_GET_SSR>(stream);
}

public void OnResponse_MSG_ZGC_CONVERT_FISH_COIN(MemoryStream stream,out string msgName)
{
MSG_ZGC_CONVERT_FISH_COIN MSG_ZGC_CONVERT_FISH_COIN = MessagePacker.ProtobufHelper.Deserialize<MSG_ZGC_CONVERT_FISH_COIN>(stream);
msgName = "MSG_ZGC_CONVERT_FISH_COIN";
Parser.Parse(MSG_ZGC_CONVERT_FISH_COIN);
}
public object Deserialize_MSG_ZGC_CONVERT_FISH_COIN(MemoryStream stream)
{
return  MessagePacker.ProtobufHelper.Deserialize<MSG_ZGC_CONVERT_FISH_COIN>(stream);
}

public void OnResponse_MSG_ZGC_RECHARGE_HISTORY(MemoryStream stream,out string msgName)
{
MSG_ZGC_RECHARGE_HISTORY MSG_ZGC_RECHARGE_HISTORY = MessagePacker.ProtobufHelper.Deserialize<MSG_ZGC_RECHARGE_HISTORY>(stream);
msgName = "MSG_ZGC_RECHARGE_HISTORY";
Parser.Parse(MSG_ZGC_RECHARGE_HISTORY);
}
public object Deserialize_MSG_ZGC_RECHARGE_HISTORY(MemoryStream stream)
{
return  MessagePacker.ProtobufHelper.Deserialize<MSG_ZGC_RECHARGE_HISTORY>(stream);
}

public void OnResponse_MSG_ZGC_RECHARGE_INFO(MemoryStream stream,out string msgName)
{
MSG_ZGC_RECHARGE_INFO MSG_ZGC_RECHARGE_INFO = MessagePacker.ProtobufHelper.Deserialize<MSG_ZGC_RECHARGE_INFO>(stream);
msgName = "MSG_ZGC_RECHARGE_INFO";
Parser.Parse(MSG_ZGC_RECHARGE_INFO);
}
public object Deserialize_MSG_ZGC_RECHARGE_INFO(MemoryStream stream)
{
return  MessagePacker.ProtobufHelper.Deserialize<MSG_ZGC_RECHARGE_INFO>(stream);
}

public void OnResponse_MSG_ZGC_RECHARGE_MANAGER(MemoryStream stream,out string msgName)
{
MSG_ZGC_RECHARGE_MANAGER MSG_ZGC_RECHARGE_MANAGER = MessagePacker.ProtobufHelper.Deserialize<MSG_ZGC_RECHARGE_MANAGER>(stream);
msgName = "MSG_ZGC_RECHARGE_MANAGER";
Parser.Parse(MSG_ZGC_RECHARGE_MANAGER);
}
public object Deserialize_MSG_ZGC_RECHARGE_MANAGER(MemoryStream stream)
{
return  MessagePacker.ProtobufHelper.Deserialize<MSG_ZGC_RECHARGE_MANAGER>(stream);
}

public void OnResponse_MSG_ZGC_FRIEND_SEARCH(MemoryStream stream,out string msgName)
{
MSG_ZGC_FRIEND_SEARCH MSG_ZGC_FRIEND_SEARCH = MessagePacker.ProtobufHelper.Deserialize<MSG_ZGC_FRIEND_SEARCH>(stream);
msgName = "MSG_ZGC_FRIEND_SEARCH";
Parser.Parse(MSG_ZGC_FRIEND_SEARCH);
}
public object Deserialize_MSG_ZGC_FRIEND_SEARCH(MemoryStream stream)
{
return  MessagePacker.ProtobufHelper.Deserialize<MSG_ZGC_FRIEND_SEARCH>(stream);
}

public void OnResponse_MSG_ZGC_FRIEND_ADD_REQUEST(MemoryStream stream,out string msgName)
{
MSG_ZGC_FRIEND_ADD_REQUEST MSG_ZGC_FRIEND_ADD_REQUEST = MessagePacker.ProtobufHelper.Deserialize<MSG_ZGC_FRIEND_ADD_REQUEST>(stream);
msgName = "MSG_ZGC_FRIEND_ADD_REQUEST";
Parser.Parse(MSG_ZGC_FRIEND_ADD_REQUEST);
}
public object Deserialize_MSG_ZGC_FRIEND_ADD_REQUEST(MemoryStream stream)
{
return  MessagePacker.ProtobufHelper.Deserialize<MSG_ZGC_FRIEND_ADD_REQUEST>(stream);
}

public void OnResponse_MSG_ZGC_FRIEND_ADD_RESPONSE(MemoryStream stream,out string msgName)
{
MSG_ZGC_FRIEND_ADD_RESPONSE MSG_ZGC_FRIEND_ADD_RESPONSE = MessagePacker.ProtobufHelper.Deserialize<MSG_ZGC_FRIEND_ADD_RESPONSE>(stream);
msgName = "MSG_ZGC_FRIEND_ADD_RESPONSE";
Parser.Parse(MSG_ZGC_FRIEND_ADD_RESPONSE);
}
public object Deserialize_MSG_ZGC_FRIEND_ADD_RESPONSE(MemoryStream stream)
{
return  MessagePacker.ProtobufHelper.Deserialize<MSG_ZGC_FRIEND_ADD_RESPONSE>(stream);
}

public void OnResponse_MSG_ZGC_FRIEND_DELETE(MemoryStream stream,out string msgName)
{
MSG_ZGC_FRIEND_DELETE MSG_ZGC_FRIEND_DELETE = MessagePacker.ProtobufHelper.Deserialize<MSG_ZGC_FRIEND_DELETE>(stream);
msgName = "MSG_ZGC_FRIEND_DELETE";
Parser.Parse(MSG_ZGC_FRIEND_DELETE);
}
public object Deserialize_MSG_ZGC_FRIEND_DELETE(MemoryStream stream)
{
return  MessagePacker.ProtobufHelper.Deserialize<MSG_ZGC_FRIEND_DELETE>(stream);
}

public void OnResponse_MSG_ZGC_FRIEND_LIST(MemoryStream stream,out string msgName)
{
MSG_ZGC_FRIEND_LIST MSG_ZGC_FRIEND_LIST = MessagePacker.ProtobufHelper.Deserialize<MSG_ZGC_FRIEND_LIST>(stream);
msgName = "MSG_ZGC_FRIEND_LIST";
Parser.Parse(MSG_ZGC_FRIEND_LIST);
}
public object Deserialize_MSG_ZGC_FRIEND_LIST(MemoryStream stream)
{
return  MessagePacker.ProtobufHelper.Deserialize<MSG_ZGC_FRIEND_LIST>(stream);
}

public void OnResponse_MSG_ZGC_FRIEND_REQUEST_LIST(MemoryStream stream,out string msgName)
{
MSG_ZGC_FRIEND_REQUEST_LIST MSG_ZGC_FRIEND_REQUEST_LIST = MessagePacker.ProtobufHelper.Deserialize<MSG_ZGC_FRIEND_REQUEST_LIST>(stream);
msgName = "MSG_ZGC_FRIEND_REQUEST_LIST";
Parser.Parse(MSG_ZGC_FRIEND_REQUEST_LIST);
}
public object Deserialize_MSG_ZGC_FRIEND_REQUEST_LIST(MemoryStream stream)
{
return  MessagePacker.ProtobufHelper.Deserialize<MSG_ZGC_FRIEND_REQUEST_LIST>(stream);
}

public void OnResponse_MSG_ZGC_FRIEND_RECENT_LIST(MemoryStream stream,out string msgName)
{
MSG_ZGC_FRIEND_RECENT_LIST MSG_ZGC_FRIEND_RECENT_LIST = MessagePacker.ProtobufHelper.Deserialize<MSG_ZGC_FRIEND_RECENT_LIST>(stream);
msgName = "MSG_ZGC_FRIEND_RECENT_LIST";
Parser.Parse(MSG_ZGC_FRIEND_RECENT_LIST);
}
public object Deserialize_MSG_ZGC_FRIEND_RECENT_LIST(MemoryStream stream)
{
return  MessagePacker.ProtobufHelper.Deserialize<MSG_ZGC_FRIEND_RECENT_LIST>(stream);
}

public void OnResponse_MSG_ZGC_FRIEND_BLACK_LIST(MemoryStream stream,out string msgName)
{
MSG_ZGC_FRIEND_BLACK_LIST MSG_ZGC_FRIEND_BLACK_LIST = MessagePacker.ProtobufHelper.Deserialize<MSG_ZGC_FRIEND_BLACK_LIST>(stream);
msgName = "MSG_ZGC_FRIEND_BLACK_LIST";
Parser.Parse(MSG_ZGC_FRIEND_BLACK_LIST);
}
public object Deserialize_MSG_ZGC_FRIEND_BLACK_LIST(MemoryStream stream)
{
return  MessagePacker.ProtobufHelper.Deserialize<MSG_ZGC_FRIEND_BLACK_LIST>(stream);
}

public void OnResponse_MSG_ZGC_FRIEND_BLACK_ADD(MemoryStream stream,out string msgName)
{
MSG_ZGC_FRIEND_BLACK_ADD MSG_ZGC_FRIEND_BLACK_ADD = MessagePacker.ProtobufHelper.Deserialize<MSG_ZGC_FRIEND_BLACK_ADD>(stream);
msgName = "MSG_ZGC_FRIEND_BLACK_ADD";
Parser.Parse(MSG_ZGC_FRIEND_BLACK_ADD);
}
public object Deserialize_MSG_ZGC_FRIEND_BLACK_ADD(MemoryStream stream)
{
return  MessagePacker.ProtobufHelper.Deserialize<MSG_ZGC_FRIEND_BLACK_ADD>(stream);
}

public void OnResponse_MSG_ZGC_FRIEND_BLACK_DEL(MemoryStream stream,out string msgName)
{
MSG_ZGC_FRIEND_BLACK_DEL MSG_ZGC_FRIEND_BLACK_DEL = MessagePacker.ProtobufHelper.Deserialize<MSG_ZGC_FRIEND_BLACK_DEL>(stream);
msgName = "MSG_ZGC_FRIEND_BLACK_DEL";
Parser.Parse(MSG_ZGC_FRIEND_BLACK_DEL);
}
public object Deserialize_MSG_ZGC_FRIEND_BLACK_DEL(MemoryStream stream)
{
return  MessagePacker.ProtobufHelper.Deserialize<MSG_ZGC_FRIEND_BLACK_DEL>(stream);
}

public void OnResponse_MSG_ZGC_FRIEND_RECOMMEND(MemoryStream stream,out string msgName)
{
MSG_ZGC_FRIEND_RECOMMEND MSG_ZGC_FRIEND_RECOMMEND = MessagePacker.ProtobufHelper.Deserialize<MSG_ZGC_FRIEND_RECOMMEND>(stream);
msgName = "MSG_ZGC_FRIEND_RECOMMEND";
Parser.Parse(MSG_ZGC_FRIEND_RECOMMEND);
}
public object Deserialize_MSG_ZGC_FRIEND_RECOMMEND(MemoryStream stream)
{
return  MessagePacker.ProtobufHelper.Deserialize<MSG_ZGC_FRIEND_RECOMMEND>(stream);
}

public void OnResponse_MSG_ZGC_RANKING_FRIEND_LIST(MemoryStream stream,out string msgName)
{
MSG_ZGC_RANKING_FRIEND_LIST MSG_ZGC_RANKING_FRIEND_LIST = MessagePacker.ProtobufHelper.Deserialize<MSG_ZGC_RANKING_FRIEND_LIST>(stream);
msgName = "MSG_ZGC_RANKING_FRIEND_LIST";
Parser.Parse(MSG_ZGC_RANKING_FRIEND_LIST);
}
public object Deserialize_MSG_ZGC_RANKING_FRIEND_LIST(MemoryStream stream)
{
return  MessagePacker.ProtobufHelper.Deserialize<MSG_ZGC_RANKING_FRIEND_LIST>(stream);
}

public void OnResponse_MSG_ZGC_RANKING_ALL_LIST(MemoryStream stream,out string msgName)
{
MSG_ZGC_RANKING_ALL_LIST MSG_ZGC_RANKING_ALL_LIST = MessagePacker.ProtobufHelper.Deserialize<MSG_ZGC_RANKING_ALL_LIST>(stream);
msgName = "MSG_ZGC_RANKING_ALL_LIST";
Parser.Parse(MSG_ZGC_RANKING_ALL_LIST);
}
public object Deserialize_MSG_ZGC_RANKING_ALL_LIST(MemoryStream stream)
{
return  MessagePacker.ProtobufHelper.Deserialize<MSG_ZGC_RANKING_ALL_LIST>(stream);
}

public void OnResponse_MSG_ZGC_RANKING_NEARBY_LIST(MemoryStream stream,out string msgName)
{
MSG_ZGC_RANKING_NEARBY_LIST MSG_ZGC_RANKING_NEARBY_LIST = MessagePacker.ProtobufHelper.Deserialize<MSG_ZGC_RANKING_NEARBY_LIST>(stream);
msgName = "MSG_ZGC_RANKING_NEARBY_LIST";
Parser.Parse(MSG_ZGC_RANKING_NEARBY_LIST);
}
public object Deserialize_MSG_ZGC_RANKING_NEARBY_LIST(MemoryStream stream)
{
return  MessagePacker.ProtobufHelper.Deserialize<MSG_ZGC_RANKING_NEARBY_LIST>(stream);
}

public void OnResponse_MSG_ZGC_CREATE_GUILD(MemoryStream stream,out string msgName)
{
MSG_ZGC_CREATE_GUILD MSG_ZGC_CREATE_GUILD = MessagePacker.ProtobufHelper.Deserialize<MSG_ZGC_CREATE_GUILD>(stream);
msgName = "MSG_ZGC_CREATE_GUILD";
Parser.Parse(MSG_ZGC_CREATE_GUILD);
}
public object Deserialize_MSG_ZGC_CREATE_GUILD(MemoryStream stream)
{
return  MessagePacker.ProtobufHelper.Deserialize<MSG_ZGC_CREATE_GUILD>(stream);
}

public void OnResponse_MSG_ZGC_CHAT_PLAYER_INFO(MemoryStream stream,out string msgName)
{
MSG_ZGC_CHAT_PLAYER_INFO MSG_ZGC_CHAT_PLAYER_INFO = MessagePacker.ProtobufHelper.Deserialize<MSG_ZGC_CHAT_PLAYER_INFO>(stream);
msgName = "MSG_ZGC_CHAT_PLAYER_INFO";
Parser.Parse(MSG_ZGC_CHAT_PLAYER_INFO);
}
public object Deserialize_MSG_ZGC_CHAT_PLAYER_INFO(MemoryStream stream)
{
return  MessagePacker.ProtobufHelper.Deserialize<MSG_ZGC_CHAT_PLAYER_INFO>(stream);
}

public void OnResponse_MSG_ZGC_CHAT_WORDS(MemoryStream stream,out string msgName)
{
MSG_ZGC_CHAT_WORDS MSG_ZGC_CHAT_WORDS = MessagePacker.ProtobufHelper.Deserialize<MSG_ZGC_CHAT_WORDS>(stream);
msgName = "MSG_ZGC_CHAT_WORDS";
Parser.Parse(MSG_ZGC_CHAT_WORDS);
}
public object Deserialize_MSG_ZGC_CHAT_WORDS(MemoryStream stream)
{
return  MessagePacker.ProtobufHelper.Deserialize<MSG_ZGC_CHAT_WORDS>(stream);
}

public void OnResponse_MSG_ZGC_PERSON_CHAT_WORDS(MemoryStream stream,out string msgName)
{
MSG_ZGC_PERSON_CHAT_WORDS MSG_ZGC_PERSON_CHAT_WORDS = MessagePacker.ProtobufHelper.Deserialize<MSG_ZGC_PERSON_CHAT_WORDS>(stream);
msgName = "MSG_ZGC_PERSON_CHAT_WORDS";
Parser.Parse(MSG_ZGC_PERSON_CHAT_WORDS);
}
public object Deserialize_MSG_ZGC_PERSON_CHAT_WORDS(MemoryStream stream)
{
return  MessagePacker.ProtobufHelper.Deserialize<MSG_ZGC_PERSON_CHAT_WORDS>(stream);
}

public void OnResponse_MSG_GC_CHANGE_WORLD_ROOM(MemoryStream stream,out string msgName)
{
MSG_GC_CHANGE_WORLD_ROOM MSG_GC_CHANGE_WORLD_ROOM = MessagePacker.ProtobufHelper.Deserialize<MSG_GC_CHANGE_WORLD_ROOM>(stream);
msgName = "MSG_GC_CHANGE_WORLD_ROOM";
Parser.Parse(MSG_GC_CHANGE_WORLD_ROOM);
}
public object Deserialize_MSG_GC_CHANGE_WORLD_ROOM(MemoryStream stream)
{
return  MessagePacker.ProtobufHelper.Deserialize<MSG_GC_CHANGE_WORLD_ROOM>(stream);
}

public void OnResponse_MSG_CMGC_WORLD_ROOM_INFO(MemoryStream stream,out string msgName)
{
MSG_CMGC_WORLD_ROOM_INFO MSG_CMGC_WORLD_ROOM_INFO = MessagePacker.ProtobufHelper.Deserialize<MSG_CMGC_WORLD_ROOM_INFO>(stream);
msgName = "MSG_CMGC_WORLD_ROOM_INFO";
Parser.Parse(MSG_CMGC_WORLD_ROOM_INFO);
}
public object Deserialize_MSG_CMGC_WORLD_ROOM_INFO(MemoryStream stream)
{
return  MessagePacker.ProtobufHelper.Deserialize<MSG_CMGC_WORLD_ROOM_INFO>(stream);
}

public void OnResponse_MSG_CMGC_GET_WORLD_ROOM_LIST(MemoryStream stream,out string msgName)
{
MSG_CMGC_GET_WORLD_ROOM_LIST MSG_CMGC_GET_WORLD_ROOM_LIST = MessagePacker.ProtobufHelper.Deserialize<MSG_CMGC_GET_WORLD_ROOM_LIST>(stream);
msgName = "MSG_CMGC_GET_WORLD_ROOM_LIST";
Parser.Parse(MSG_CMGC_GET_WORLD_ROOM_LIST);
}
public object Deserialize_MSG_CMGC_GET_WORLD_ROOM_LIST(MemoryStream stream)
{
return  MessagePacker.ProtobufHelper.Deserialize<MSG_CMGC_GET_WORLD_ROOM_LIST>(stream);
}

public void OnResponse_MSG_ZGC_CHAT_TRUMPET(MemoryStream stream,out string msgName)
{
MSG_ZGC_CHAT_TRUMPET MSG_ZGC_CHAT_TRUMPET = MessagePacker.ProtobufHelper.Deserialize<MSG_ZGC_CHAT_TRUMPET>(stream);
msgName = "MSG_ZGC_CHAT_TRUMPET";
Parser.Parse(MSG_ZGC_CHAT_TRUMPET);
}
public object Deserialize_MSG_ZGC_CHAT_TRUMPET(MemoryStream stream)
{
return  MessagePacker.ProtobufHelper.Deserialize<MSG_ZGC_CHAT_TRUMPET>(stream);
}

public void OnResponse_MSG_ZGC_CHAT_TRUMPET_RESULT(MemoryStream stream,out string msgName)
{
MSG_ZGC_CHAT_TRUMPET_RESULT MSG_ZGC_CHAT_TRUMPET_RESULT = MessagePacker.ProtobufHelper.Deserialize<MSG_ZGC_CHAT_TRUMPET_RESULT>(stream);
msgName = "MSG_ZGC_CHAT_TRUMPET_RESULT";
Parser.Parse(MSG_ZGC_CHAT_TRUMPET_RESULT);
}
public object Deserialize_MSG_ZGC_CHAT_TRUMPET_RESULT(MemoryStream stream)
{
return  MessagePacker.ProtobufHelper.Deserialize<MSG_ZGC_CHAT_TRUMPET_RESULT>(stream);
}

public void OnResponse_MSG_GC_ANNOUNCEMENT(MemoryStream stream,out string msgName)
{
MSG_GC_ANNOUNCEMENT MSG_GC_ANNOUNCEMENT = MessagePacker.ProtobufHelper.Deserialize<MSG_GC_ANNOUNCEMENT>(stream);
msgName = "MSG_GC_ANNOUNCEMENT";
Parser.Parse(MSG_GC_ANNOUNCEMENT);
}
public object Deserialize_MSG_GC_ANNOUNCEMENT(MemoryStream stream)
{
return  MessagePacker.ProtobufHelper.Deserialize<MSG_GC_ANNOUNCEMENT>(stream);
}

public void OnResponse_MSG_ZGC_NEARBY_EMOJI(MemoryStream stream,out string msgName)
{
MSG_ZGC_NEARBY_EMOJI MSG_ZGC_NEARBY_EMOJI = MessagePacker.ProtobufHelper.Deserialize<MSG_ZGC_NEARBY_EMOJI>(stream);
msgName = "MSG_ZGC_NEARBY_EMOJI";
Parser.Parse(MSG_ZGC_NEARBY_EMOJI);
}
public object Deserialize_MSG_ZGC_NEARBY_EMOJI(MemoryStream stream)
{
return  MessagePacker.ProtobufHelper.Deserialize<MSG_ZGC_NEARBY_EMOJI>(stream);
}

public void OnResponse_MSG_ZGC_TIP_OFF(MemoryStream stream,out string msgName)
{
MSG_ZGC_TIP_OFF MSG_ZGC_TIP_OFF = MessagePacker.ProtobufHelper.Deserialize<MSG_ZGC_TIP_OFF>(stream);
msgName = "MSG_ZGC_TIP_OFF";
Parser.Parse(MSG_ZGC_TIP_OFF);
}
public object Deserialize_MSG_ZGC_TIP_OFF(MemoryStream stream)
{
return  MessagePacker.ProtobufHelper.Deserialize<MSG_ZGC_TIP_OFF>(stream);
}

public void OnResponse_MSG_ZGC_CHAT_BROADCAST(MemoryStream stream,out string msgName)
{
MSG_ZGC_CHAT_BROADCAST MSG_ZGC_CHAT_BROADCAST = MessagePacker.ProtobufHelper.Deserialize<MSG_ZGC_CHAT_BROADCAST>(stream);
msgName = "MSG_ZGC_CHAT_BROADCAST";
Parser.Parse(MSG_ZGC_CHAT_BROADCAST);
}
public object Deserialize_MSG_ZGC_CHAT_BROADCAST(MemoryStream stream)
{
return  MessagePacker.ProtobufHelper.Deserialize<MSG_ZGC_CHAT_BROADCAST>(stream);
}

public void OnResponse_MSG_GC_NEARBY_ROOM(MemoryStream stream,out string msgName)
{
MSG_GC_NEARBY_ROOM MSG_GC_NEARBY_ROOM = MessagePacker.ProtobufHelper.Deserialize<MSG_GC_NEARBY_ROOM>(stream);
msgName = "MSG_GC_NEARBY_ROOM";
Parser.Parse(MSG_GC_NEARBY_ROOM);
}
public object Deserialize_MSG_GC_NEARBY_ROOM(MemoryStream stream)
{
return  MessagePacker.ProtobufHelper.Deserialize<MSG_GC_NEARBY_ROOM>(stream);
}

public void OnResponse_MSG_ZGC_SILENCE(MemoryStream stream,out string msgName)
{
MSG_ZGC_SILENCE MSG_ZGC_SILENCE = MessagePacker.ProtobufHelper.Deserialize<MSG_ZGC_SILENCE>(stream);
msgName = "MSG_ZGC_SILENCE";
Parser.Parse(MSG_ZGC_SILENCE);
}
public object Deserialize_MSG_ZGC_SILENCE(MemoryStream stream)
{
return  MessagePacker.ProtobufHelper.Deserialize<MSG_ZGC_SILENCE>(stream);
}

public void OnResponse_MSG_ZGC_ACTIVITY_CHAT_BUBBLE(MemoryStream stream,out string msgName)
{
MSG_ZGC_ACTIVITY_CHAT_BUBBLE MSG_ZGC_ACTIVITY_CHAT_BUBBLE = MessagePacker.ProtobufHelper.Deserialize<MSG_ZGC_ACTIVITY_CHAT_BUBBLE>(stream);
msgName = "MSG_ZGC_ACTIVITY_CHAT_BUBBLE";
Parser.Parse(MSG_ZGC_ACTIVITY_CHAT_BUBBLE);
}
public object Deserialize_MSG_ZGC_ACTIVITY_CHAT_BUBBLE(MemoryStream stream)
{
return  MessagePacker.ProtobufHelper.Deserialize<MSG_ZGC_ACTIVITY_CHAT_BUBBLE>(stream);
}

public void OnResponse_MSG_ZGC_TASK_LIST(MemoryStream stream,out string msgName)
{
MSG_ZGC_TASK_LIST MSG_ZGC_TASK_LIST = MessagePacker.ProtobufHelper.Deserialize<MSG_ZGC_TASK_LIST>(stream);
msgName = "MSG_ZGC_TASK_LIST";
Parser.Parse(MSG_ZGC_TASK_LIST);
}
public object Deserialize_MSG_ZGC_TASK_LIST(MemoryStream stream)
{
return  MessagePacker.ProtobufHelper.Deserialize<MSG_ZGC_TASK_LIST>(stream);
}

public void OnResponse_MSG_ZGC_TASK_INFO(MemoryStream stream,out string msgName)
{
MSG_ZGC_TASK_INFO MSG_ZGC_TASK_INFO = MessagePacker.ProtobufHelper.Deserialize<MSG_ZGC_TASK_INFO>(stream);
msgName = "MSG_ZGC_TASK_INFO";
Parser.Parse(MSG_ZGC_TASK_INFO);
}
public object Deserialize_MSG_ZGC_TASK_INFO(MemoryStream stream)
{
return  MessagePacker.ProtobufHelper.Deserialize<MSG_ZGC_TASK_INFO>(stream);
}

public void OnResponse_MSG_ZGC_TASK_CHANGE(MemoryStream stream,out string msgName)
{
MSG_ZGC_TASK_CHANGE MSG_ZGC_TASK_CHANGE = MessagePacker.ProtobufHelper.Deserialize<MSG_ZGC_TASK_CHANGE>(stream);
msgName = "MSG_ZGC_TASK_CHANGE";
Parser.Parse(MSG_ZGC_TASK_CHANGE);
}
public object Deserialize_MSG_ZGC_TASK_CHANGE(MemoryStream stream)
{
return  MessagePacker.ProtobufHelper.Deserialize<MSG_ZGC_TASK_CHANGE>(stream);
}

public void OnResponse_MSG_ZGC_GET_TASK_RESULT(MemoryStream stream,out string msgName)
{
MSG_ZGC_GET_TASK_RESULT MSG_ZGC_GET_TASK_RESULT = MessagePacker.ProtobufHelper.Deserialize<MSG_ZGC_GET_TASK_RESULT>(stream);
msgName = "MSG_ZGC_GET_TASK_RESULT";
Parser.Parse(MSG_ZGC_GET_TASK_RESULT);
}
public object Deserialize_MSG_ZGC_GET_TASK_RESULT(MemoryStream stream)
{
return  MessagePacker.ProtobufHelper.Deserialize<MSG_ZGC_GET_TASK_RESULT>(stream);
}

public void OnResponse_MSG_ZGC_TASK_COLLECT(MemoryStream stream,out string msgName)
{
MSG_ZGC_TASK_COLLECT MSG_ZGC_TASK_COLLECT = MessagePacker.ProtobufHelper.Deserialize<MSG_ZGC_TASK_COLLECT>(stream);
msgName = "MSG_ZGC_TASK_COLLECT";
Parser.Parse(MSG_ZGC_TASK_COLLECT);
}
public object Deserialize_MSG_ZGC_TASK_COLLECT(MemoryStream stream)
{
return  MessagePacker.ProtobufHelper.Deserialize<MSG_ZGC_TASK_COLLECT>(stream);
}

public void OnResponse_MSG_ZGC_TASK_COMPLETE(MemoryStream stream,out string msgName)
{
MSG_ZGC_TASK_COMPLETE MSG_ZGC_TASK_COMPLETE = MessagePacker.ProtobufHelper.Deserialize<MSG_ZGC_TASK_COMPLETE>(stream);
msgName = "MSG_ZGC_TASK_COMPLETE";
Parser.Parse(MSG_ZGC_TASK_COMPLETE);
}
public object Deserialize_MSG_ZGC_TASK_COMPLETE(MemoryStream stream)
{
return  MessagePacker.ProtobufHelper.Deserialize<MSG_ZGC_TASK_COMPLETE>(stream);
}

public void OnResponse_MSG_ZGC_USE_TASKFLY_ANSWER(MemoryStream stream,out string msgName)
{
MSG_ZGC_USE_TASKFLY_ANSWER MSG_ZGC_USE_TASKFLY_ANSWER = MessagePacker.ProtobufHelper.Deserialize<MSG_ZGC_USE_TASKFLY_ANSWER>(stream);
msgName = "MSG_ZGC_USE_TASKFLY_ANSWER";
Parser.Parse(MSG_ZGC_USE_TASKFLY_ANSWER);
}
public object Deserialize_MSG_ZGC_USE_TASKFLY_ANSWER(MemoryStream stream)
{
return  MessagePacker.ProtobufHelper.Deserialize<MSG_ZGC_USE_TASKFLY_ANSWER>(stream);
}

public void OnResponse_MSG_ZGC_TASKFLY_POSITION_SETDONE(MemoryStream stream,out string msgName)
{
MSG_ZGC_TASKFLY_POSITION_SETDONE MSG_ZGC_TASKFLY_POSITION_SETDONE = MessagePacker.ProtobufHelper.Deserialize<MSG_ZGC_TASKFLY_POSITION_SETDONE>(stream);
msgName = "MSG_ZGC_TASKFLY_POSITION_SETDONE";
Parser.Parse(MSG_ZGC_TASKFLY_POSITION_SETDONE);
}
public object Deserialize_MSG_ZGC_TASKFLY_POSITION_SETDONE(MemoryStream stream)
{
return  MessagePacker.ProtobufHelper.Deserialize<MSG_ZGC_TASKFLY_POSITION_SETDONE>(stream);
}

public void OnResponse_MSG_ZGC_TASK_BATTLE_REWARD(MemoryStream stream,out string msgName)
{
MSG_ZGC_TASK_BATTLE_REWARD MSG_ZGC_TASK_BATTLE_REWARD = MessagePacker.ProtobufHelper.Deserialize<MSG_ZGC_TASK_BATTLE_REWARD>(stream);
msgName = "MSG_ZGC_TASK_BATTLE_REWARD";
Parser.Parse(MSG_ZGC_TASK_BATTLE_REWARD);
}
public object Deserialize_MSG_ZGC_TASK_BATTLE_REWARD(MemoryStream stream)
{
return  MessagePacker.ProtobufHelper.Deserialize<MSG_ZGC_TASK_BATTLE_REWARD>(stream);
}

public void OnResponse_MSG_ZGC_ACTIVITY_LIST(MemoryStream stream,out string msgName)
{
MSG_ZGC_ACTIVITY_LIST MSG_ZGC_ACTIVITY_LIST = MessagePacker.ProtobufHelper.Deserialize<MSG_ZGC_ACTIVITY_LIST>(stream);
msgName = "MSG_ZGC_ACTIVITY_LIST";
Parser.Parse(MSG_ZGC_ACTIVITY_LIST);
}
public object Deserialize_MSG_ZGC_ACTIVITY_LIST(MemoryStream stream)
{
return  MessagePacker.ProtobufHelper.Deserialize<MSG_ZGC_ACTIVITY_LIST>(stream);
}

public void OnResponse_MSG_ZGC_ACTIVITY_INFO(MemoryStream stream,out string msgName)
{
MSG_ZGC_ACTIVITY_INFO MSG_ZGC_ACTIVITY_INFO = MessagePacker.ProtobufHelper.Deserialize<MSG_ZGC_ACTIVITY_INFO>(stream);
msgName = "MSG_ZGC_ACTIVITY_INFO";
Parser.Parse(MSG_ZGC_ACTIVITY_INFO);
}
public object Deserialize_MSG_ZGC_ACTIVITY_INFO(MemoryStream stream)
{
return  MessagePacker.ProtobufHelper.Deserialize<MSG_ZGC_ACTIVITY_INFO>(stream);
}

public void OnResponse_MSG_ZGC_ACTIVITY_CHANGE(MemoryStream stream,out string msgName)
{
MSG_ZGC_ACTIVITY_CHANGE MSG_ZGC_ACTIVITY_CHANGE = MessagePacker.ProtobufHelper.Deserialize<MSG_ZGC_ACTIVITY_CHANGE>(stream);
msgName = "MSG_ZGC_ACTIVITY_CHANGE";
Parser.Parse(MSG_ZGC_ACTIVITY_CHANGE);
}
public object Deserialize_MSG_ZGC_ACTIVITY_CHANGE(MemoryStream stream)
{
return  MessagePacker.ProtobufHelper.Deserialize<MSG_ZGC_ACTIVITY_CHANGE>(stream);
}

public void OnResponse_MSG_ZGC_ACTIVITY_COMPLETE(MemoryStream stream,out string msgName)
{
MSG_ZGC_ACTIVITY_COMPLETE MSG_ZGC_ACTIVITY_COMPLETE = MessagePacker.ProtobufHelper.Deserialize<MSG_ZGC_ACTIVITY_COMPLETE>(stream);
msgName = "MSG_ZGC_ACTIVITY_COMPLETE";
Parser.Parse(MSG_ZGC_ACTIVITY_COMPLETE);
}
public object Deserialize_MSG_ZGC_ACTIVITY_COMPLETE(MemoryStream stream)
{
return  MessagePacker.ProtobufHelper.Deserialize<MSG_ZGC_ACTIVITY_COMPLETE>(stream);
}

public void OnResponse_MSG_ZGC_QUESTIONNAIRE_COMPLETE(MemoryStream stream,out string msgName)
{
MSG_ZGC_QUESTIONNAIRE_COMPLETE MSG_ZGC_QUESTIONNAIRE_COMPLETE = MessagePacker.ProtobufHelper.Deserialize<MSG_ZGC_QUESTIONNAIRE_COMPLETE>(stream);
msgName = "MSG_ZGC_QUESTIONNAIRE_COMPLETE";
Parser.Parse(MSG_ZGC_QUESTIONNAIRE_COMPLETE);
}
public object Deserialize_MSG_ZGC_QUESTIONNAIRE_COMPLETE(MemoryStream stream)
{
return  MessagePacker.ProtobufHelper.Deserialize<MSG_ZGC_QUESTIONNAIRE_COMPLETE>(stream);
}

public void OnResponse_MSG_GC_LOGIN_WAIT_QUEUE(MemoryStream stream,out string msgName)
{
MSG_GC_LOGIN_WAIT_QUEUE MSG_GC_LOGIN_WAIT_QUEUE = MessagePacker.ProtobufHelper.Deserialize<MSG_GC_LOGIN_WAIT_QUEUE>(stream);
msgName = "MSG_GC_LOGIN_WAIT_QUEUE";
Parser.Parse(MSG_GC_LOGIN_WAIT_QUEUE);
}
public object Deserialize_MSG_GC_LOGIN_WAIT_QUEUE(MemoryStream stream)
{
return  MessagePacker.ProtobufHelper.Deserialize<MSG_GC_LOGIN_WAIT_QUEUE>(stream);
}

public void OnResponse_MSG_ZGC_DAILY_QUESTION_COUNTER(MemoryStream stream,out string msgName)
{
MSG_ZGC_DAILY_QUESTION_COUNTER MSG_ZGC_DAILY_QUESTION_COUNTER = MessagePacker.ProtobufHelper.Deserialize<MSG_ZGC_DAILY_QUESTION_COUNTER>(stream);
msgName = "MSG_ZGC_DAILY_QUESTION_COUNTER";
Parser.Parse(MSG_ZGC_DAILY_QUESTION_COUNTER);
}
public object Deserialize_MSG_ZGC_DAILY_QUESTION_COUNTER(MemoryStream stream)
{
return  MessagePacker.ProtobufHelper.Deserialize<MSG_ZGC_DAILY_QUESTION_COUNTER>(stream);
}

public void OnResponse_MSG_ZGC_DAILY_QUESTION_REWARD(MemoryStream stream,out string msgName)
{
MSG_ZGC_DAILY_QUESTION_REWARD MSG_ZGC_DAILY_QUESTION_REWARD = MessagePacker.ProtobufHelper.Deserialize<MSG_ZGC_DAILY_QUESTION_REWARD>(stream);
msgName = "MSG_ZGC_DAILY_QUESTION_REWARD";
Parser.Parse(MSG_ZGC_DAILY_QUESTION_REWARD);
}
public object Deserialize_MSG_ZGC_DAILY_QUESTION_REWARD(MemoryStream stream)
{
return  MessagePacker.ProtobufHelper.Deserialize<MSG_ZGC_DAILY_QUESTION_REWARD>(stream);
}

public void OnResponse_MSG_ZGC_SHOW_CHARACTER(MemoryStream stream,out string msgName)
{
MSG_ZGC_SHOW_CHARACTER MSG_ZGC_SHOW_CHARACTER = MessagePacker.ProtobufHelper.Deserialize<MSG_ZGC_SHOW_CHARACTER>(stream);
msgName = "MSG_ZGC_SHOW_CHARACTER";
Parser.Parse(MSG_ZGC_SHOW_CHARACTER);
}
public object Deserialize_MSG_ZGC_SHOW_CHARACTER(MemoryStream stream)
{
return  MessagePacker.ProtobufHelper.Deserialize<MSG_ZGC_SHOW_CHARACTER>(stream);
}

public void OnResponse_MSG_ZGC_CHANGE_NAME(MemoryStream stream,out string msgName)
{
MSG_ZGC_CHANGE_NAME MSG_ZGC_CHANGE_NAME = MessagePacker.ProtobufHelper.Deserialize<MSG_ZGC_CHANGE_NAME>(stream);
msgName = "MSG_ZGC_CHANGE_NAME";
Parser.Parse(MSG_ZGC_CHANGE_NAME);
}
public object Deserialize_MSG_ZGC_CHANGE_NAME(MemoryStream stream)
{
return  MessagePacker.ProtobufHelper.Deserialize<MSG_ZGC_CHANGE_NAME>(stream);
}

public void OnResponse_MSG_ZGC_SHOW_FACEICON(MemoryStream stream,out string msgName)
{
MSG_ZGC_SHOW_FACEICON MSG_ZGC_SHOW_FACEICON = MessagePacker.ProtobufHelper.Deserialize<MSG_ZGC_SHOW_FACEICON>(stream);
msgName = "MSG_ZGC_SHOW_FACEICON";
Parser.Parse(MSG_ZGC_SHOW_FACEICON);
}
public object Deserialize_MSG_ZGC_SHOW_FACEICON(MemoryStream stream)
{
return  MessagePacker.ProtobufHelper.Deserialize<MSG_ZGC_SHOW_FACEICON>(stream);
}

public void OnResponse_MSG_ZGC_SHOW_FACEJPG(MemoryStream stream,out string msgName)
{
MSG_ZGC_SHOW_FACEJPG MSG_ZGC_SHOW_FACEJPG = MessagePacker.ProtobufHelper.Deserialize<MSG_ZGC_SHOW_FACEJPG>(stream);
msgName = "MSG_ZGC_SHOW_FACEJPG";
Parser.Parse(MSG_ZGC_SHOW_FACEJPG);
}
public object Deserialize_MSG_ZGC_SHOW_FACEJPG(MemoryStream stream)
{
return  MessagePacker.ProtobufHelper.Deserialize<MSG_ZGC_SHOW_FACEJPG>(stream);
}

public void OnResponse_MSG_ZGC_SET_SEX(MemoryStream stream,out string msgName)
{
MSG_ZGC_SET_SEX MSG_ZGC_SET_SEX = MessagePacker.ProtobufHelper.Deserialize<MSG_ZGC_SET_SEX>(stream);
msgName = "MSG_ZGC_SET_SEX";
Parser.Parse(MSG_ZGC_SET_SEX);
}
public object Deserialize_MSG_ZGC_SET_SEX(MemoryStream stream)
{
return  MessagePacker.ProtobufHelper.Deserialize<MSG_ZGC_SET_SEX>(stream);
}

public void OnResponse_MSG_ZGC_SET_BIRTHDAY(MemoryStream stream,out string msgName)
{
MSG_ZGC_SET_BIRTHDAY MSG_ZGC_SET_BIRTHDAY = MessagePacker.ProtobufHelper.Deserialize<MSG_ZGC_SET_BIRTHDAY>(stream);
msgName = "MSG_ZGC_SET_BIRTHDAY";
Parser.Parse(MSG_ZGC_SET_BIRTHDAY);
}
public object Deserialize_MSG_ZGC_SET_BIRTHDAY(MemoryStream stream)
{
return  MessagePacker.ProtobufHelper.Deserialize<MSG_ZGC_SET_BIRTHDAY>(stream);
}

public void OnResponse_MSG_ZGC_SET_SIGNATURE(MemoryStream stream,out string msgName)
{
MSG_ZGC_SET_SIGNATURE MSG_ZGC_SET_SIGNATURE = MessagePacker.ProtobufHelper.Deserialize<MSG_ZGC_SET_SIGNATURE>(stream);
msgName = "MSG_ZGC_SET_SIGNATURE";
Parser.Parse(MSG_ZGC_SET_SIGNATURE);
}
public object Deserialize_MSG_ZGC_SET_SIGNATURE(MemoryStream stream)
{
return  MessagePacker.ProtobufHelper.Deserialize<MSG_ZGC_SET_SIGNATURE>(stream);
}

public void OnResponse_MSG_ZGC_SHOW_VOICE(MemoryStream stream,out string msgName)
{
MSG_ZGC_SHOW_VOICE MSG_ZGC_SHOW_VOICE = MessagePacker.ProtobufHelper.Deserialize<MSG_ZGC_SHOW_VOICE>(stream);
msgName = "MSG_ZGC_SHOW_VOICE";
Parser.Parse(MSG_ZGC_SHOW_VOICE);
}
public object Deserialize_MSG_ZGC_SHOW_VOICE(MemoryStream stream)
{
return  MessagePacker.ProtobufHelper.Deserialize<MSG_ZGC_SHOW_VOICE>(stream);
}

public void OnResponse_MSG_ZGC_PRESENT_GIFT(MemoryStream stream,out string msgName)
{
MSG_ZGC_PRESENT_GIFT MSG_ZGC_PRESENT_GIFT = MessagePacker.ProtobufHelper.Deserialize<MSG_ZGC_PRESENT_GIFT>(stream);
msgName = "MSG_ZGC_PRESENT_GIFT";
Parser.Parse(MSG_ZGC_PRESENT_GIFT);
}
public object Deserialize_MSG_ZGC_PRESENT_GIFT(MemoryStream stream)
{
return  MessagePacker.ProtobufHelper.Deserialize<MSG_ZGC_PRESENT_GIFT>(stream);
}

public void OnResponse_MSG_ZGC_SET_SOCIAL_NUM(MemoryStream stream,out string msgName)
{
MSG_ZGC_SET_SOCIAL_NUM MSG_ZGC_SET_SOCIAL_NUM = MessagePacker.ProtobufHelper.Deserialize<MSG_ZGC_SET_SOCIAL_NUM>(stream);
msgName = "MSG_ZGC_SET_SOCIAL_NUM";
Parser.Parse(MSG_ZGC_SET_SOCIAL_NUM);
}
public object Deserialize_MSG_ZGC_SET_SOCIAL_NUM(MemoryStream stream)
{
return  MessagePacker.ProtobufHelper.Deserialize<MSG_ZGC_SET_SOCIAL_NUM>(stream);
}

public void OnResponse_MSG_ZGC_GET_SOCIAL_NUM(MemoryStream stream,out string msgName)
{
MSG_ZGC_GET_SOCIAL_NUM MSG_ZGC_GET_SOCIAL_NUM = MessagePacker.ProtobufHelper.Deserialize<MSG_ZGC_GET_SOCIAL_NUM>(stream);
msgName = "MSG_ZGC_GET_SOCIAL_NUM";
Parser.Parse(MSG_ZGC_GET_SOCIAL_NUM);
}
public object Deserialize_MSG_ZGC_GET_SOCIAL_NUM(MemoryStream stream)
{
return  MessagePacker.ProtobufHelper.Deserialize<MSG_ZGC_GET_SOCIAL_NUM>(stream);
}

public void OnResponse_MSG_ZGC_GEOGRAPHY(MemoryStream stream,out string msgName)
{
MSG_ZGC_GEOGRAPHY MSG_ZGC_GEOGRAPHY = MessagePacker.ProtobufHelper.Deserialize<MSG_ZGC_GEOGRAPHY>(stream);
msgName = "MSG_ZGC_GEOGRAPHY";
Parser.Parse(MSG_ZGC_GEOGRAPHY);
}
public object Deserialize_MSG_ZGC_GEOGRAPHY(MemoryStream stream)
{
return  MessagePacker.ProtobufHelper.Deserialize<MSG_ZGC_GEOGRAPHY>(stream);
}

public void OnResponse_MSG_ZGC_UPDATE_SOME_SHOW(MemoryStream stream,out string msgName)
{
MSG_ZGC_UPDATE_SOME_SHOW MSG_ZGC_UPDATE_SOME_SHOW = MessagePacker.ProtobufHelper.Deserialize<MSG_ZGC_UPDATE_SOME_SHOW>(stream);
msgName = "MSG_ZGC_UPDATE_SOME_SHOW";
Parser.Parse(MSG_ZGC_UPDATE_SOME_SHOW);
}
public object Deserialize_MSG_ZGC_UPDATE_SOME_SHOW(MemoryStream stream)
{
return  MessagePacker.ProtobufHelper.Deserialize<MSG_ZGC_UPDATE_SOME_SHOW>(stream);
}

public void OnResponse_MSG_ZGC_SHOW_CAREER(MemoryStream stream,out string msgName)
{
MSG_ZGC_SHOW_CAREER MSG_ZGC_SHOW_CAREER = MessagePacker.ProtobufHelper.Deserialize<MSG_ZGC_SHOW_CAREER>(stream);
msgName = "MSG_ZGC_SHOW_CAREER";
Parser.Parse(MSG_ZGC_SHOW_CAREER);
}
public object Deserialize_MSG_ZGC_SHOW_CAREER(MemoryStream stream)
{
return  MessagePacker.ProtobufHelper.Deserialize<MSG_ZGC_SHOW_CAREER>(stream);
}

public void OnResponse_MSG_ZGC_CAREER_ITEM(MemoryStream stream,out string msgName)
{
MSG_ZGC_CAREER_ITEM MSG_ZGC_CAREER_ITEM = MessagePacker.ProtobufHelper.Deserialize<MSG_ZGC_CAREER_ITEM>(stream);
msgName = "MSG_ZGC_CAREER_ITEM";
Parser.Parse(MSG_ZGC_CAREER_ITEM);
}
public object Deserialize_MSG_ZGC_CAREER_ITEM(MemoryStream stream)
{
return  MessagePacker.ProtobufHelper.Deserialize<MSG_ZGC_CAREER_ITEM>(stream);
}

public void OnResponse_MSG_ZGC_GET_GIFTRECORD(MemoryStream stream,out string msgName)
{
MSG_ZGC_GET_GIFTRECORD MSG_ZGC_GET_GIFTRECORD = MessagePacker.ProtobufHelper.Deserialize<MSG_ZGC_GET_GIFTRECORD>(stream);
msgName = "MSG_ZGC_GET_GIFTRECORD";
Parser.Parse(MSG_ZGC_GET_GIFTRECORD);
}
public object Deserialize_MSG_ZGC_GET_GIFTRECORD(MemoryStream stream)
{
return  MessagePacker.ProtobufHelper.Deserialize<MSG_ZGC_GET_GIFTRECORD>(stream);
}

public void OnResponse_MSG_ZGC_TITLE_INFO(MemoryStream stream,out string msgName)
{
MSG_ZGC_TITLE_INFO MSG_ZGC_TITLE_INFO = MessagePacker.ProtobufHelper.Deserialize<MSG_ZGC_TITLE_INFO>(stream);
msgName = "MSG_ZGC_TITLE_INFO";
Parser.Parse(MSG_ZGC_TITLE_INFO);
}
public object Deserialize_MSG_ZGC_TITLE_INFO(MemoryStream stream)
{
return  MessagePacker.ProtobufHelper.Deserialize<MSG_ZGC_TITLE_INFO>(stream);
}

public void OnResponse_MSG_ZGC_CHANGE_TITLE_ANSWER(MemoryStream stream,out string msgName)
{
MSG_ZGC_CHANGE_TITLE_ANSWER MSG_ZGC_CHANGE_TITLE_ANSWER = MessagePacker.ProtobufHelper.Deserialize<MSG_ZGC_CHANGE_TITLE_ANSWER>(stream);
msgName = "MSG_ZGC_CHANGE_TITLE_ANSWER";
Parser.Parse(MSG_ZGC_CHANGE_TITLE_ANSWER);
}
public object Deserialize_MSG_ZGC_CHANGE_TITLE_ANSWER(MemoryStream stream)
{
return  MessagePacker.ProtobufHelper.Deserialize<MSG_ZGC_CHANGE_TITLE_ANSWER>(stream);
}

public void OnResponse_MSG_ZGC_UPLOAD_PHOTO(MemoryStream stream,out string msgName)
{
MSG_ZGC_UPLOAD_PHOTO MSG_ZGC_UPLOAD_PHOTO = MessagePacker.ProtobufHelper.Deserialize<MSG_ZGC_UPLOAD_PHOTO>(stream);
msgName = "MSG_ZGC_UPLOAD_PHOTO";
Parser.Parse(MSG_ZGC_UPLOAD_PHOTO);
}
public object Deserialize_MSG_ZGC_UPLOAD_PHOTO(MemoryStream stream)
{
return  MessagePacker.ProtobufHelper.Deserialize<MSG_ZGC_UPLOAD_PHOTO>(stream);
}

public void OnResponse_MSG_ZGC_REMOVE_PHOTO(MemoryStream stream,out string msgName)
{
MSG_ZGC_REMOVE_PHOTO MSG_ZGC_REMOVE_PHOTO = MessagePacker.ProtobufHelper.Deserialize<MSG_ZGC_REMOVE_PHOTO>(stream);
msgName = "MSG_ZGC_REMOVE_PHOTO";
Parser.Parse(MSG_ZGC_REMOVE_PHOTO);
}
public object Deserialize_MSG_ZGC_REMOVE_PHOTO(MemoryStream stream)
{
return  MessagePacker.ProtobufHelper.Deserialize<MSG_ZGC_REMOVE_PHOTO>(stream);
}

public void OnResponse_MSG_ZGC_PHOTO_LIST(MemoryStream stream,out string msgName)
{
MSG_ZGC_PHOTO_LIST MSG_ZGC_PHOTO_LIST = MessagePacker.ProtobufHelper.Deserialize<MSG_ZGC_PHOTO_LIST>(stream);
msgName = "MSG_ZGC_PHOTO_LIST";
Parser.Parse(MSG_ZGC_PHOTO_LIST);
}
public object Deserialize_MSG_ZGC_PHOTO_LIST(MemoryStream stream)
{
return  MessagePacker.ProtobufHelper.Deserialize<MSG_ZGC_PHOTO_LIST>(stream);
}

public void OnResponse_MSG_ZGC_POP_RANK(MemoryStream stream,out string msgName)
{
MSG_ZGC_POP_RANK MSG_ZGC_POP_RANK = MessagePacker.ProtobufHelper.Deserialize<MSG_ZGC_POP_RANK>(stream);
msgName = "MSG_ZGC_POP_RANK";
Parser.Parse(MSG_ZGC_POP_RANK);
}
public object Deserialize_MSG_ZGC_POP_RANK(MemoryStream stream)
{
return  MessagePacker.ProtobufHelper.Deserialize<MSG_ZGC_POP_RANK>(stream);
}

public void OnResponse_MSG_ZGC_RADIO_ALL_ANCHOR_RANK(MemoryStream stream,out string msgName)
{
MSG_ZGC_RADIO_ALL_ANCHOR_RANK MSG_ZGC_RADIO_ALL_ANCHOR_RANK = MessagePacker.ProtobufHelper.Deserialize<MSG_ZGC_RADIO_ALL_ANCHOR_RANK>(stream);
msgName = "MSG_ZGC_RADIO_ALL_ANCHOR_RANK";
Parser.Parse(MSG_ZGC_RADIO_ALL_ANCHOR_RANK);
}
public object Deserialize_MSG_ZGC_RADIO_ALL_ANCHOR_RANK(MemoryStream stream)
{
return  MessagePacker.ProtobufHelper.Deserialize<MSG_ZGC_RADIO_ALL_ANCHOR_RANK>(stream);
}

public void OnResponse_MSG_ZGC_RADIO_ANCHOR_CONTRIBUTION_RANK(MemoryStream stream,out string msgName)
{
MSG_ZGC_RADIO_ANCHOR_CONTRIBUTION_RANK MSG_ZGC_RADIO_ANCHOR_CONTRIBUTION_RANK = MessagePacker.ProtobufHelper.Deserialize<MSG_ZGC_RADIO_ANCHOR_CONTRIBUTION_RANK>(stream);
msgName = "MSG_ZGC_RADIO_ANCHOR_CONTRIBUTION_RANK";
Parser.Parse(MSG_ZGC_RADIO_ANCHOR_CONTRIBUTION_RANK);
}
public object Deserialize_MSG_ZGC_RADIO_ANCHOR_CONTRIBUTION_RANK(MemoryStream stream)
{
return  MessagePacker.ProtobufHelper.Deserialize<MSG_ZGC_RADIO_ANCHOR_CONTRIBUTION_RANK>(stream);
}

public void OnResponse_MSG_ZGC_RADIO_ALL_CONTRIBUTION_RANK(MemoryStream stream,out string msgName)
{
MSG_ZGC_RADIO_ALL_CONTRIBUTION_RANK MSG_ZGC_RADIO_ALL_CONTRIBUTION_RANK = MessagePacker.ProtobufHelper.Deserialize<MSG_ZGC_RADIO_ALL_CONTRIBUTION_RANK>(stream);
msgName = "MSG_ZGC_RADIO_ALL_CONTRIBUTION_RANK";
Parser.Parse(MSG_ZGC_RADIO_ALL_CONTRIBUTION_RANK);
}
public object Deserialize_MSG_ZGC_RADIO_ALL_CONTRIBUTION_RANK(MemoryStream stream)
{
return  MessagePacker.ProtobufHelper.Deserialize<MSG_ZGC_RADIO_ALL_CONTRIBUTION_RANK>(stream);
}

public void OnResponse_MSG_ZGC_RADIO_CONTRIBUTION_REWARD(MemoryStream stream,out string msgName)
{
MSG_ZGC_RADIO_CONTRIBUTION_REWARD MSG_ZGC_RADIO_CONTRIBUTION_REWARD = MessagePacker.ProtobufHelper.Deserialize<MSG_ZGC_RADIO_CONTRIBUTION_REWARD>(stream);
msgName = "MSG_ZGC_RADIO_CONTRIBUTION_REWARD";
Parser.Parse(MSG_ZGC_RADIO_CONTRIBUTION_REWARD);
}
public object Deserialize_MSG_ZGC_RADIO_CONTRIBUTION_REWARD(MemoryStream stream)
{
return  MessagePacker.ProtobufHelper.Deserialize<MSG_ZGC_RADIO_CONTRIBUTION_REWARD>(stream);
}

public void OnResponse_MSG_ZGC_RADIO_GIFT(MemoryStream stream,out string msgName)
{
MSG_ZGC_RADIO_GIFT MSG_ZGC_RADIO_GIFT = MessagePacker.ProtobufHelper.Deserialize<MSG_ZGC_RADIO_GIFT>(stream);
msgName = "MSG_ZGC_RADIO_GIFT";
Parser.Parse(MSG_ZGC_RADIO_GIFT);
}
public object Deserialize_MSG_ZGC_RADIO_GIFT(MemoryStream stream)
{
return  MessagePacker.ProtobufHelper.Deserialize<MSG_ZGC_RADIO_GIFT>(stream);
}

public void OnResponse_MSG_ZGC_ANCHOR_INFO(MemoryStream stream,out string msgName)
{
MSG_ZGC_ANCHOR_INFO MSG_ZGC_ANCHOR_INFO = MessagePacker.ProtobufHelper.Deserialize<MSG_ZGC_ANCHOR_INFO>(stream);
msgName = "MSG_ZGC_ANCHOR_INFO";
Parser.Parse(MSG_ZGC_ANCHOR_INFO);
}
public object Deserialize_MSG_ZGC_ANCHOR_INFO(MemoryStream stream)
{
return  MessagePacker.ProtobufHelper.Deserialize<MSG_ZGC_ANCHOR_INFO>(stream);
}

public void OnResponse_MSG_ZGC_DAMAGE(MemoryStream stream,out string msgName)
{
MSG_ZGC_DAMAGE MSG_ZGC_DAMAGE = MessagePacker.ProtobufHelper.Deserialize<MSG_ZGC_DAMAGE>(stream);
msgName = "MSG_ZGC_DAMAGE";
Parser.Parse(MSG_ZGC_DAMAGE);
}
public object Deserialize_MSG_ZGC_DAMAGE(MemoryStream stream)
{
return  MessagePacker.ProtobufHelper.Deserialize<MSG_ZGC_DAMAGE>(stream);
}

public void OnResponse_MSG_ZGC_CAST_SKILL(MemoryStream stream,out string msgName)
{
MSG_ZGC_CAST_SKILL MSG_ZGC_CAST_SKILL = MessagePacker.ProtobufHelper.Deserialize<MSG_ZGC_CAST_SKILL>(stream);
msgName = "MSG_ZGC_CAST_SKILL";
Parser.Parse(MSG_ZGC_CAST_SKILL);
}
public object Deserialize_MSG_ZGC_CAST_SKILL(MemoryStream stream)
{
return  MessagePacker.ProtobufHelper.Deserialize<MSG_ZGC_CAST_SKILL>(stream);
}

public void OnResponse_MSG_ZGC_CALL_PET(MemoryStream stream,out string msgName)
{
MSG_ZGC_CALL_PET MSG_ZGC_CALL_PET = MessagePacker.ProtobufHelper.Deserialize<MSG_ZGC_CALL_PET>(stream);
msgName = "MSG_ZGC_CALL_PET";
Parser.Parse(MSG_ZGC_CALL_PET);
}
public object Deserialize_MSG_ZGC_CALL_PET(MemoryStream stream)
{
return  MessagePacker.ProtobufHelper.Deserialize<MSG_ZGC_CALL_PET>(stream);
}

public void OnResponse_MSG_ZGC_RECALL_PET(MemoryStream stream,out string msgName)
{
MSG_ZGC_RECALL_PET MSG_ZGC_RECALL_PET = MessagePacker.ProtobufHelper.Deserialize<MSG_ZGC_RECALL_PET>(stream);
msgName = "MSG_ZGC_RECALL_PET";
Parser.Parse(MSG_ZGC_RECALL_PET);
}
public object Deserialize_MSG_ZGC_RECALL_PET(MemoryStream stream)
{
return  MessagePacker.ProtobufHelper.Deserialize<MSG_ZGC_RECALL_PET>(stream);
}

public void OnResponse_MSG_ZGC_CALL_HERO(MemoryStream stream,out string msgName)
{
MSG_ZGC_CALL_HERO MSG_ZGC_CALL_HERO = MessagePacker.ProtobufHelper.Deserialize<MSG_ZGC_CALL_HERO>(stream);
msgName = "MSG_ZGC_CALL_HERO";
Parser.Parse(MSG_ZGC_CALL_HERO);
}
public object Deserialize_MSG_ZGC_CALL_HERO(MemoryStream stream)
{
return  MessagePacker.ProtobufHelper.Deserialize<MSG_ZGC_CALL_HERO>(stream);
}

public void OnResponse_MSG_ZGC_RECALL_HERO(MemoryStream stream,out string msgName)
{
MSG_ZGC_RECALL_HERO MSG_ZGC_RECALL_HERO = MessagePacker.ProtobufHelper.Deserialize<MSG_ZGC_RECALL_HERO>(stream);
msgName = "MSG_ZGC_RECALL_HERO";
Parser.Parse(MSG_ZGC_RECALL_HERO);
}
public object Deserialize_MSG_ZGC_RECALL_HERO(MemoryStream stream)
{
return  MessagePacker.ProtobufHelper.Deserialize<MSG_ZGC_RECALL_HERO>(stream);
}

public void OnResponse_MSG_ZGC_HERO_LIST(MemoryStream stream,out string msgName)
{
MSG_ZGC_HERO_LIST MSG_ZGC_HERO_LIST = MessagePacker.ProtobufHelper.Deserialize<MSG_ZGC_HERO_LIST>(stream);
msgName = "MSG_ZGC_HERO_LIST";
Parser.Parse(MSG_ZGC_HERO_LIST);
}
public object Deserialize_MSG_ZGC_HERO_LIST(MemoryStream stream)
{
return  MessagePacker.ProtobufHelper.Deserialize<MSG_ZGC_HERO_LIST>(stream);
}

public void OnResponse_MSG_ZGC_HERO_INFO(MemoryStream stream,out string msgName)
{
MSG_ZGC_HERO_INFO MSG_ZGC_HERO_INFO = MessagePacker.ProtobufHelper.Deserialize<MSG_ZGC_HERO_INFO>(stream);
msgName = "MSG_ZGC_HERO_INFO";
Parser.Parse(MSG_ZGC_HERO_INFO);
}
public object Deserialize_MSG_ZGC_HERO_INFO(MemoryStream stream)
{
return  MessagePacker.ProtobufHelper.Deserialize<MSG_ZGC_HERO_INFO>(stream);
}

public void OnResponse_MSG_ZGC_HERO_CHANGE(MemoryStream stream,out string msgName)
{
MSG_ZGC_HERO_CHANGE MSG_ZGC_HERO_CHANGE = MessagePacker.ProtobufHelper.Deserialize<MSG_ZGC_HERO_CHANGE>(stream);
msgName = "MSG_ZGC_HERO_CHANGE";
Parser.Parse(MSG_ZGC_HERO_CHANGE);
}
public object Deserialize_MSG_ZGC_HERO_CHANGE(MemoryStream stream)
{
return  MessagePacker.ProtobufHelper.Deserialize<MSG_ZGC_HERO_CHANGE>(stream);
}

public void OnResponse_MSG_ZGC_HERO_TALENT(MemoryStream stream,out string msgName)
{
MSG_ZGC_HERO_TALENT MSG_ZGC_HERO_TALENT = MessagePacker.ProtobufHelper.Deserialize<MSG_ZGC_HERO_TALENT>(stream);
msgName = "MSG_ZGC_HERO_TALENT";
Parser.Parse(MSG_ZGC_HERO_TALENT);
}
public object Deserialize_MSG_ZGC_HERO_TALENT(MemoryStream stream)
{
return  MessagePacker.ProtobufHelper.Deserialize<MSG_ZGC_HERO_TALENT>(stream);
}

public void OnResponse_MSG_ZGC_HERO_LEVEL_UP(MemoryStream stream,out string msgName)
{
MSG_ZGC_HERO_LEVEL_UP MSG_ZGC_HERO_LEVEL_UP = MessagePacker.ProtobufHelper.Deserialize<MSG_ZGC_HERO_LEVEL_UP>(stream);
msgName = "MSG_ZGC_HERO_LEVEL_UP";
Parser.Parse(MSG_ZGC_HERO_LEVEL_UP);
}
public object Deserialize_MSG_ZGC_HERO_LEVEL_UP(MemoryStream stream)
{
return  MessagePacker.ProtobufHelper.Deserialize<MSG_ZGC_HERO_LEVEL_UP>(stream);
}

public void OnResponse_MSG_ZGC_HERO_AWAKEN(MemoryStream stream,out string msgName)
{
MSG_ZGC_HERO_AWAKEN MSG_ZGC_HERO_AWAKEN = MessagePacker.ProtobufHelper.Deserialize<MSG_ZGC_HERO_AWAKEN>(stream);
msgName = "MSG_ZGC_HERO_AWAKEN";
Parser.Parse(MSG_ZGC_HERO_AWAKEN);
}
public object Deserialize_MSG_ZGC_HERO_AWAKEN(MemoryStream stream)
{
return  MessagePacker.ProtobufHelper.Deserialize<MSG_ZGC_HERO_AWAKEN>(stream);
}

public void OnResponse_MSG_ZGC_HERO_ABSORB_SOUL_LINK(MemoryStream stream,out string msgName)
{
MSG_ZGC_HERO_ABSORB_SOUL_LINK MSG_ZGC_HERO_ABSORB_SOUL_LINK = MessagePacker.ProtobufHelper.Deserialize<MSG_ZGC_HERO_ABSORB_SOUL_LINK>(stream);
msgName = "MSG_ZGC_HERO_ABSORB_SOUL_LINK";
Parser.Parse(MSG_ZGC_HERO_ABSORB_SOUL_LINK);
}
public object Deserialize_MSG_ZGC_HERO_ABSORB_SOUL_LINK(MemoryStream stream)
{
return  MessagePacker.ProtobufHelper.Deserialize<MSG_ZGC_HERO_ABSORB_SOUL_LINK>(stream);
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
public void OnResponse_MSG_CG_CHARACTER_LIST(MemoryStream stream,out string msgName)
{
MSG_CG_CHARACTER_LIST MSG_CG_CHARACTER_LIST = MessagePacker.ProtobufHelper.Deserialize<MSG_CG_CHARACTER_LIST>(stream);
msgName = "MSG_CG_CHARACTER_LIST";
Parser.Parse(MSG_CG_CHARACTER_LIST);
}
public object Deserialize_MSG_CG_CHARACTER_LIST(MemoryStream stream)
{
return  MessagePacker.ProtobufHelper.Deserialize<MSG_CG_CHARACTER_LIST>(stream);
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
public void OnResponse_MSG_CG_CREATE_CHARACTER(MemoryStream stream,out string msgName)
{
MSG_CG_CREATE_CHARACTER MSG_CG_CREATE_CHARACTER = MessagePacker.ProtobufHelper.Deserialize<MSG_CG_CREATE_CHARACTER>(stream);
msgName = "MSG_CG_CREATE_CHARACTER";
Parser.Parse(MSG_CG_CREATE_CHARACTER);
}
public object Deserialize_MSG_CG_CREATE_CHARACTER(MemoryStream stream)
{
return  MessagePacker.ProtobufHelper.Deserialize<MSG_CG_CREATE_CHARACTER>(stream);
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
public void OnResponse_MSG_CG_TO_ZONE(MemoryStream stream,out string msgName)
{
MSG_CG_TO_ZONE MSG_CG_TO_ZONE = MessagePacker.ProtobufHelper.Deserialize<MSG_CG_TO_ZONE>(stream);
msgName = "MSG_CG_TO_ZONE";
Parser.Parse(MSG_CG_TO_ZONE);
}
public object Deserialize_MSG_CG_TO_ZONE(MemoryStream stream)
{
return  MessagePacker.ProtobufHelper.Deserialize<MSG_CG_TO_ZONE>(stream);
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
public void OnResponse_MSG_CG_MAP_LOADING_DONE(MemoryStream stream,out string msgName)
{
MSG_CG_MAP_LOADING_DONE MSG_CG_MAP_LOADING_DONE = MessagePacker.ProtobufHelper.Deserialize<MSG_CG_MAP_LOADING_DONE>(stream);
msgName = "MSG_CG_MAP_LOADING_DONE";
Parser.Parse(MSG_CG_MAP_LOADING_DONE);
}
public object Deserialize_MSG_CG_MAP_LOADING_DONE(MemoryStream stream)
{
return  MessagePacker.ProtobufHelper.Deserialize<MSG_CG_MAP_LOADING_DONE>(stream);
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
public void OnResponse_MSG_CG_HEARTBEAT(MemoryStream stream,out string msgName)
{
MSG_CG_HEARTBEAT MSG_CG_HEARTBEAT = MessagePacker.ProtobufHelper.Deserialize<MSG_CG_HEARTBEAT>(stream);
msgName = "MSG_CG_HEARTBEAT";
Parser.Parse(MSG_CG_HEARTBEAT);
}
public object Deserialize_MSG_CG_HEARTBEAT(MemoryStream stream)
{
return  MessagePacker.ProtobufHelper.Deserialize<MSG_CG_HEARTBEAT>(stream);
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
public void OnResponse_MSG_CG_SHIP_STEP(MemoryStream stream,out string msgName)
{
MSG_CG_SHIP_STEP MSG_CG_SHIP_STEP = MessagePacker.ProtobufHelper.Deserialize<MSG_CG_SHIP_STEP>(stream);
msgName = "MSG_CG_SHIP_STEP";
Parser.Parse(MSG_CG_SHIP_STEP);
}
public object Deserialize_MSG_CG_SHIP_STEP(MemoryStream stream)
{
return  MessagePacker.ProtobufHelper.Deserialize<MSG_CG_SHIP_STEP>(stream);
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
public void OnResponse_MSG_CG_CHARACTER_MOVE(MemoryStream stream,out string msgName)
{
MSG_CG_CHARACTER_MOVE MSG_CG_CHARACTER_MOVE = MessagePacker.ProtobufHelper.Deserialize<MSG_CG_CHARACTER_MOVE>(stream);
msgName = "MSG_CG_CHARACTER_MOVE";
Parser.Parse(MSG_CG_CHARACTER_MOVE);
}
public object Deserialize_MSG_CG_CHARACTER_MOVE(MemoryStream stream)
{
return  MessagePacker.ProtobufHelper.Deserialize<MSG_CG_CHARACTER_MOVE>(stream);
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
public void OnResponse_MSG_CG_MOVE_ZONE(MemoryStream stream,out string msgName)
{
MSG_CG_MOVE_ZONE MSG_CG_MOVE_ZONE = MessagePacker.ProtobufHelper.Deserialize<MSG_CG_MOVE_ZONE>(stream);
msgName = "MSG_CG_MOVE_ZONE";
Parser.Parse(MSG_CG_MOVE_ZONE);
}
public object Deserialize_MSG_CG_MOVE_ZONE(MemoryStream stream)
{
return  MessagePacker.ProtobufHelper.Deserialize<MSG_CG_MOVE_ZONE>(stream);
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
public void OnResponse_MSG_CG_AUTOPATHFINDING(MemoryStream stream,out string msgName)
{
MSG_CG_AUTOPATHFINDING MSG_CG_AUTOPATHFINDING = MessagePacker.ProtobufHelper.Deserialize<MSG_CG_AUTOPATHFINDING>(stream);
msgName = "MSG_CG_AUTOPATHFINDING";
Parser.Parse(MSG_CG_AUTOPATHFINDING);
}
public object Deserialize_MSG_CG_AUTOPATHFINDING(MemoryStream stream)
{
return  MessagePacker.ProtobufHelper.Deserialize<MSG_CG_AUTOPATHFINDING>(stream);
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
public void OnResponse_MSG_CG_GEOGRAPHY(MemoryStream stream,out string msgName)
{
MSG_CG_GEOGRAPHY MSG_CG_GEOGRAPHY = MessagePacker.ProtobufHelper.Deserialize<MSG_CG_GEOGRAPHY>(stream);
msgName = "MSG_CG_GEOGRAPHY";
Parser.Parse(MSG_CG_GEOGRAPHY);
}
public object Deserialize_MSG_CG_GEOGRAPHY(MemoryStream stream)
{
return  MessagePacker.ProtobufHelper.Deserialize<MSG_CG_GEOGRAPHY>(stream);
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
public void OnResponse_MSG_CG_RECONNECT_LOGIN(MemoryStream stream,out string msgName)
{
MSG_CG_RECONNECT_LOGIN MSG_CG_RECONNECT_LOGIN = MessagePacker.ProtobufHelper.Deserialize<MSG_CG_RECONNECT_LOGIN>(stream);
msgName = "MSG_CG_RECONNECT_LOGIN";
Parser.Parse(MSG_CG_RECONNECT_LOGIN);
}
public object Deserialize_MSG_CG_RECONNECT_LOGIN(MemoryStream stream)
{
return  MessagePacker.ProtobufHelper.Deserialize<MSG_CG_RECONNECT_LOGIN>(stream);
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
public void OnResponse_MSG_CG_CROSS_PORTAL(MemoryStream stream,out string msgName)
{
MSG_CG_CROSS_PORTAL MSG_CG_CROSS_PORTAL = MessagePacker.ProtobufHelper.Deserialize<MSG_CG_CROSS_PORTAL>(stream);
msgName = "MSG_CG_CROSS_PORTAL";
Parser.Parse(MSG_CG_CROSS_PORTAL);
}
public object Deserialize_MSG_CG_CROSS_PORTAL(MemoryStream stream)
{
return  MessagePacker.ProtobufHelper.Deserialize<MSG_CG_CROSS_PORTAL>(stream);
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
public void OnResponse_MSG_CG_GET_BLOWFISHKEY(MemoryStream stream,out string msgName)
{
MSG_CG_GET_BLOWFISHKEY MSG_CG_GET_BLOWFISHKEY = MessagePacker.ProtobufHelper.Deserialize<MSG_CG_GET_BLOWFISHKEY>(stream);
msgName = "MSG_CG_GET_BLOWFISHKEY";
Parser.Parse(MSG_CG_GET_BLOWFISHKEY);
}
public object Deserialize_MSG_CG_GET_BLOWFISHKEY(MemoryStream stream)
{
return  MessagePacker.ProtobufHelper.Deserialize<MSG_CG_GET_BLOWFISHKEY>(stream);
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
public void OnResponse_MSG_CG_SUGGEST(MemoryStream stream,out string msgName)
{
MSG_CG_SUGGEST MSG_CG_SUGGEST = MessagePacker.ProtobufHelper.Deserialize<MSG_CG_SUGGEST>(stream);
msgName = "MSG_CG_SUGGEST";
Parser.Parse(MSG_CG_SUGGEST);
}
public object Deserialize_MSG_CG_SUGGEST(MemoryStream stream)
{
return  MessagePacker.ProtobufHelper.Deserialize<MSG_CG_SUGGEST>(stream);
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
public void OnResponse_MSG_CG_LOGOUT(MemoryStream stream,out string msgName)
{
MSG_CG_LOGOUT MSG_CG_LOGOUT = MessagePacker.ProtobufHelper.Deserialize<MSG_CG_LOGOUT>(stream);
msgName = "MSG_CG_LOGOUT";
Parser.Parse(MSG_CG_LOGOUT);
}
public object Deserialize_MSG_CG_LOGOUT(MemoryStream stream)
{
return  MessagePacker.ProtobufHelper.Deserialize<MSG_CG_LOGOUT>(stream);
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
public void OnResponse_MSG_CG_SAVE_GUIDE_ID(MemoryStream stream,out string msgName)
{
MSG_CG_SAVE_GUIDE_ID MSG_CG_SAVE_GUIDE_ID = MessagePacker.ProtobufHelper.Deserialize<MSG_CG_SAVE_GUIDE_ID>(stream);
msgName = "MSG_CG_SAVE_GUIDE_ID";
Parser.Parse(MSG_CG_SAVE_GUIDE_ID);
}
public object Deserialize_MSG_CG_SAVE_GUIDE_ID(MemoryStream stream)
{
return  MessagePacker.ProtobufHelper.Deserialize<MSG_CG_SAVE_GUIDE_ID>(stream);
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
public void OnResponse_MSG_CG_SAVE_MAIN_LINE_ID(MemoryStream stream,out string msgName)
{
MSG_CG_SAVE_MAIN_LINE_ID MSG_CG_SAVE_MAIN_LINE_ID = MessagePacker.ProtobufHelper.Deserialize<MSG_CG_SAVE_MAIN_LINE_ID>(stream);
msgName = "MSG_CG_SAVE_MAIN_LINE_ID";
Parser.Parse(MSG_CG_SAVE_MAIN_LINE_ID);
}
public object Deserialize_MSG_CG_SAVE_MAIN_LINE_ID(MemoryStream stream)
{
return  MessagePacker.ProtobufHelper.Deserialize<MSG_CG_SAVE_MAIN_LINE_ID>(stream);
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
public void OnResponse_MSG_CG_SAVE_GAME_COMMENT(MemoryStream stream,out string msgName)
{
MSG_CG_SAVE_GAME_COMMENT MSG_CG_SAVE_GAME_COMMENT = MessagePacker.ProtobufHelper.Deserialize<MSG_CG_SAVE_GAME_COMMENT>(stream);
msgName = "MSG_CG_SAVE_GAME_COMMENT";
Parser.Parse(MSG_CG_SAVE_GAME_COMMENT);
}
public object Deserialize_MSG_CG_SAVE_GAME_COMMENT(MemoryStream stream)
{
return  MessagePacker.ProtobufHelper.Deserialize<MSG_CG_SAVE_GAME_COMMENT>(stream);
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
public void OnResponse_MSG_CG_CHANGE_CHANNEL(MemoryStream stream,out string msgName)
{
MSG_CG_CHANGE_CHANNEL MSG_CG_CHANGE_CHANNEL = MessagePacker.ProtobufHelper.Deserialize<MSG_CG_CHANGE_CHANNEL>(stream);
msgName = "MSG_CG_CHANGE_CHANNEL";
Parser.Parse(MSG_CG_CHANGE_CHANNEL);
}
public object Deserialize_MSG_CG_CHANGE_CHANNEL(MemoryStream stream)
{
return  MessagePacker.ProtobufHelper.Deserialize<MSG_CG_CHANGE_CHANNEL>(stream);
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
public void OnResponse_MSG_CG_ITEM_USE(MemoryStream stream,out string msgName)
{
MSG_CG_ITEM_USE MSG_CG_ITEM_USE = MessagePacker.ProtobufHelper.Deserialize<MSG_CG_ITEM_USE>(stream);
msgName = "MSG_CG_ITEM_USE";
Parser.Parse(MSG_CG_ITEM_USE);
}
public object Deserialize_MSG_CG_ITEM_USE(MemoryStream stream)
{
return  MessagePacker.ProtobufHelper.Deserialize<MSG_CG_ITEM_USE>(stream);
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
public void OnResponse_MSG_CG_ITEM_SELL(MemoryStream stream,out string msgName)
{
MSG_CG_ITEM_SELL MSG_CG_ITEM_SELL = MessagePacker.ProtobufHelper.Deserialize<MSG_CG_ITEM_SELL>(stream);
msgName = "MSG_CG_ITEM_SELL";
Parser.Parse(MSG_CG_ITEM_SELL);
}
public object Deserialize_MSG_CG_ITEM_SELL(MemoryStream stream)
{
return  MessagePacker.ProtobufHelper.Deserialize<MSG_CG_ITEM_SELL>(stream);
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
public void OnResponse_MSG_CG_ITEM_BUY(MemoryStream stream,out string msgName)
{
MSG_CG_ITEM_BUY MSG_CG_ITEM_BUY = MessagePacker.ProtobufHelper.Deserialize<MSG_CG_ITEM_BUY>(stream);
msgName = "MSG_CG_ITEM_BUY";
Parser.Parse(MSG_CG_ITEM_BUY);
}
public object Deserialize_MSG_CG_ITEM_BUY(MemoryStream stream)
{
return  MessagePacker.ProtobufHelper.Deserialize<MSG_CG_ITEM_BUY>(stream);
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
public void OnResponse_MSG_CG_USE_FIREWORKS(MemoryStream stream,out string msgName)
{
MSG_CG_USE_FIREWORKS MSG_CG_USE_FIREWORKS = MessagePacker.ProtobufHelper.Deserialize<MSG_CG_USE_FIREWORKS>(stream);
msgName = "MSG_CG_USE_FIREWORKS";
Parser.Parse(MSG_CG_USE_FIREWORKS);
}
public object Deserialize_MSG_CG_USE_FIREWORKS(MemoryStream stream)
{
return  MessagePacker.ProtobufHelper.Deserialize<MSG_CG_USE_FIREWORKS>(stream);
}

MSG_CG_ITEM_ID_NUM msg_MSG_CG_ITEM_ID_NUM;

public object Init_MSG_CG_ITEM_ID_NUM()
{
msg_MSG_CG_ITEM_ID_NUM = new MSG_CG_ITEM_ID_NUM();
return msg_MSG_CG_ITEM_ID_NUM;
}
public object Get_MSG_CG_ITEM_ID_NUM()
{
return msg_MSG_CG_ITEM_ID_NUM;
}
public object New_MSG_CG_ITEM_ID_NUM()
{
return msg_MSG_CG_ITEM_ID_NUM;
}
public void OnResponse_MSG_CG_ITEM_ID_NUM(MemoryStream stream,out string msgName)
{
MSG_CG_ITEM_ID_NUM MSG_CG_ITEM_ID_NUM = MessagePacker.ProtobufHelper.Deserialize<MSG_CG_ITEM_ID_NUM>(stream);
msgName = "MSG_CG_ITEM_ID_NUM";
Parser.Parse(MSG_CG_ITEM_ID_NUM);
}
public object Deserialize_MSG_CG_ITEM_ID_NUM(MemoryStream stream)
{
return  MessagePacker.ProtobufHelper.Deserialize<MSG_CG_ITEM_ID_NUM>(stream);
}

MSG_CG_ITEM_COMPOSE msg_MSG_CG_ITEM_COMPOSE;

public object Init_MSG_CG_ITEM_COMPOSE()
{
msg_MSG_CG_ITEM_COMPOSE = new MSG_CG_ITEM_COMPOSE();
return msg_MSG_CG_ITEM_COMPOSE;
}
public object Get_MSG_CG_ITEM_COMPOSE()
{
return msg_MSG_CG_ITEM_COMPOSE;
}
public object New_MSG_CG_ITEM_COMPOSE()
{
return msg_MSG_CG_ITEM_COMPOSE;
}
public void OnResponse_MSG_CG_ITEM_COMPOSE(MemoryStream stream,out string msgName)
{
MSG_CG_ITEM_COMPOSE MSG_CG_ITEM_COMPOSE = MessagePacker.ProtobufHelper.Deserialize<MSG_CG_ITEM_COMPOSE>(stream);
msgName = "MSG_CG_ITEM_COMPOSE";
Parser.Parse(MSG_CG_ITEM_COMPOSE);
}
public object Deserialize_MSG_CG_ITEM_COMPOSE(MemoryStream stream)
{
return  MessagePacker.ProtobufHelper.Deserialize<MSG_CG_ITEM_COMPOSE>(stream);
}

MSG_CG_ITEM_RESOLVE msg_MSG_CG_ITEM_RESOLVE;

public object Init_MSG_CG_ITEM_RESOLVE()
{
msg_MSG_CG_ITEM_RESOLVE = new MSG_CG_ITEM_RESOLVE();
return msg_MSG_CG_ITEM_RESOLVE;
}
public object Get_MSG_CG_ITEM_RESOLVE()
{
return msg_MSG_CG_ITEM_RESOLVE;
}
public object New_MSG_CG_ITEM_RESOLVE()
{
return msg_MSG_CG_ITEM_RESOLVE;
}
public void OnResponse_MSG_CG_ITEM_RESOLVE(MemoryStream stream,out string msgName)
{
MSG_CG_ITEM_RESOLVE MSG_CG_ITEM_RESOLVE = MessagePacker.ProtobufHelper.Deserialize<MSG_CG_ITEM_RESOLVE>(stream);
msgName = "MSG_CG_ITEM_RESOLVE";
Parser.Parse(MSG_CG_ITEM_RESOLVE);
}
public object Deserialize_MSG_CG_ITEM_RESOLVE(MemoryStream stream)
{
return  MessagePacker.ProtobufHelper.Deserialize<MSG_CG_ITEM_RESOLVE>(stream);
}

MSG_CG_SMELT_SOULBONE msg_MSG_CG_SMELT_SOULBONE;

public object Init_MSG_CG_SMELT_SOULBONE()
{
msg_MSG_CG_SMELT_SOULBONE = new MSG_CG_SMELT_SOULBONE();
return msg_MSG_CG_SMELT_SOULBONE;
}
public object Get_MSG_CG_SMELT_SOULBONE()
{
return msg_MSG_CG_SMELT_SOULBONE;
}
public object New_MSG_CG_SMELT_SOULBONE()
{
return msg_MSG_CG_SMELT_SOULBONE;
}
public void OnResponse_MSG_CG_SMELT_SOULBONE(MemoryStream stream,out string msgName)
{
MSG_CG_SMELT_SOULBONE MSG_CG_SMELT_SOULBONE = MessagePacker.ProtobufHelper.Deserialize<MSG_CG_SMELT_SOULBONE>(stream);
msgName = "MSG_CG_SMELT_SOULBONE";
Parser.Parse(MSG_CG_SMELT_SOULBONE);
}
public object Deserialize_MSG_CG_SMELT_SOULBONE(MemoryStream stream)
{
return  MessagePacker.ProtobufHelper.Deserialize<MSG_CG_SMELT_SOULBONE>(stream);
}

MSG_CG_SOULBONE msg_MSG_CG_SOULBONE;

public object Init_MSG_CG_SOULBONE()
{
msg_MSG_CG_SOULBONE = new MSG_CG_SOULBONE();
return msg_MSG_CG_SOULBONE;
}
public object Get_MSG_CG_SOULBONE()
{
return msg_MSG_CG_SOULBONE;
}
public object New_MSG_CG_SOULBONE()
{
return msg_MSG_CG_SOULBONE;
}
public void OnResponse_MSG_CG_SOULBONE(MemoryStream stream,out string msgName)
{
MSG_CG_SOULBONE MSG_CG_SOULBONE = MessagePacker.ProtobufHelper.Deserialize<MSG_CG_SOULBONE>(stream);
msgName = "MSG_CG_SOULBONE";
Parser.Parse(MSG_CG_SOULBONE);
}
public object Deserialize_MSG_CG_SOULBONE(MemoryStream stream)
{
return  MessagePacker.ProtobufHelper.Deserialize<MSG_CG_SOULBONE>(stream);
}

MSG_CG_EQUIP_SOULBONE msg_MSG_CG_EQUIP_SOULBONE;

public object Init_MSG_CG_EQUIP_SOULBONE()
{
msg_MSG_CG_EQUIP_SOULBONE = new MSG_CG_EQUIP_SOULBONE();
return msg_MSG_CG_EQUIP_SOULBONE;
}
public object Get_MSG_CG_EQUIP_SOULBONE()
{
return msg_MSG_CG_EQUIP_SOULBONE;
}
public object New_MSG_CG_EQUIP_SOULBONE()
{
return msg_MSG_CG_EQUIP_SOULBONE;
}
public void OnResponse_MSG_CG_EQUIP_SOULBONE(MemoryStream stream,out string msgName)
{
MSG_CG_EQUIP_SOULBONE MSG_CG_EQUIP_SOULBONE = MessagePacker.ProtobufHelper.Deserialize<MSG_CG_EQUIP_SOULBONE>(stream);
msgName = "MSG_CG_EQUIP_SOULBONE";
Parser.Parse(MSG_CG_EQUIP_SOULBONE);
}
public object Deserialize_MSG_CG_EQUIP_SOULBONE(MemoryStream stream)
{
return  MessagePacker.ProtobufHelper.Deserialize<MSG_CG_EQUIP_SOULBONE>(stream);
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
public void OnResponse_MSG_CG_EMAIL_READ(MemoryStream stream,out string msgName)
{
MSG_CG_EMAIL_READ MSG_CG_EMAIL_READ = MessagePacker.ProtobufHelper.Deserialize<MSG_CG_EMAIL_READ>(stream);
msgName = "MSG_CG_EMAIL_READ";
Parser.Parse(MSG_CG_EMAIL_READ);
}
public object Deserialize_MSG_CG_EMAIL_READ(MemoryStream stream)
{
return  MessagePacker.ProtobufHelper.Deserialize<MSG_CG_EMAIL_READ>(stream);
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
public void OnResponse_MSG_CG_PICKUP_ATTACHMENT(MemoryStream stream,out string msgName)
{
MSG_CG_PICKUP_ATTACHMENT MSG_CG_PICKUP_ATTACHMENT = MessagePacker.ProtobufHelper.Deserialize<MSG_CG_PICKUP_ATTACHMENT>(stream);
msgName = "MSG_CG_PICKUP_ATTACHMENT";
Parser.Parse(MSG_CG_PICKUP_ATTACHMENT);
}
public object Deserialize_MSG_CG_PICKUP_ATTACHMENT(MemoryStream stream)
{
return  MessagePacker.ProtobufHelper.Deserialize<MSG_CG_PICKUP_ATTACHMENT>(stream);
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
public void OnResponse_MSG_CG_EMAIL_OPENE_BOX(MemoryStream stream,out string msgName)
{
MSG_CG_EMAIL_OPENE_BOX MSG_CG_EMAIL_OPENE_BOX = MessagePacker.ProtobufHelper.Deserialize<MSG_CG_EMAIL_OPENE_BOX>(stream);
msgName = "MSG_CG_EMAIL_OPENE_BOX";
Parser.Parse(MSG_CG_EMAIL_OPENE_BOX);
}
public object Deserialize_MSG_CG_EMAIL_OPENE_BOX(MemoryStream stream)
{
return  MessagePacker.ProtobufHelper.Deserialize<MSG_CG_EMAIL_OPENE_BOX>(stream);
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
public void OnResponse_MSG_CG_SHOP_BUY_ITEM(MemoryStream stream,out string msgName)
{
MSG_CG_SHOP_BUY_ITEM MSG_CG_SHOP_BUY_ITEM = MessagePacker.ProtobufHelper.Deserialize<MSG_CG_SHOP_BUY_ITEM>(stream);
msgName = "MSG_CG_SHOP_BUY_ITEM";
Parser.Parse(MSG_CG_SHOP_BUY_ITEM);
}
public object Deserialize_MSG_CG_SHOP_BUY_ITEM(MemoryStream stream)
{
return  MessagePacker.ProtobufHelper.Deserialize<MSG_CG_SHOP_BUY_ITEM>(stream);
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
public void OnResponse_MSG_CG_SHOP_GET_SSR(MemoryStream stream,out string msgName)
{
MSG_CG_SHOP_GET_SSR MSG_CG_SHOP_GET_SSR = MessagePacker.ProtobufHelper.Deserialize<MSG_CG_SHOP_GET_SSR>(stream);
msgName = "MSG_CG_SHOP_GET_SSR";
Parser.Parse(MSG_CG_SHOP_GET_SSR);
}
public object Deserialize_MSG_CG_SHOP_GET_SSR(MemoryStream stream)
{
return  MessagePacker.ProtobufHelper.Deserialize<MSG_CG_SHOP_GET_SSR>(stream);
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
public void OnResponse_MSG_CG_REFRESH_SHOP_ITEM(MemoryStream stream,out string msgName)
{
MSG_CG_REFRESH_SHOP_ITEM MSG_CG_REFRESH_SHOP_ITEM = MessagePacker.ProtobufHelper.Deserialize<MSG_CG_REFRESH_SHOP_ITEM>(stream);
msgName = "MSG_CG_REFRESH_SHOP_ITEM";
Parser.Parse(MSG_CG_REFRESH_SHOP_ITEM);
}
public object Deserialize_MSG_CG_REFRESH_SHOP_ITEM(MemoryStream stream)
{
return  MessagePacker.ProtobufHelper.Deserialize<MSG_CG_REFRESH_SHOP_ITEM>(stream);
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
public void OnResponse_MSG_CG_CONVERT_FISH_COIN(MemoryStream stream,out string msgName)
{
MSG_CG_CONVERT_FISH_COIN MSG_CG_CONVERT_FISH_COIN = MessagePacker.ProtobufHelper.Deserialize<MSG_CG_CONVERT_FISH_COIN>(stream);
msgName = "MSG_CG_CONVERT_FISH_COIN";
Parser.Parse(MSG_CG_CONVERT_FISH_COIN);
}
public object Deserialize_MSG_CG_CONVERT_FISH_COIN(MemoryStream stream)
{
return  MessagePacker.ProtobufHelper.Deserialize<MSG_CG_CONVERT_FISH_COIN>(stream);
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
public void OnResponse_MSG_CG_SAVE_ORDER(MemoryStream stream,out string msgName)
{
MSG_CG_SAVE_ORDER MSG_CG_SAVE_ORDER = MessagePacker.ProtobufHelper.Deserialize<MSG_CG_SAVE_ORDER>(stream);
msgName = "MSG_CG_SAVE_ORDER";
Parser.Parse(MSG_CG_SAVE_ORDER);
}
public object Deserialize_MSG_CG_SAVE_ORDER(MemoryStream stream)
{
return  MessagePacker.ProtobufHelper.Deserialize<MSG_CG_SAVE_ORDER>(stream);
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
public void OnResponse_MSG_CG_GET_RECHARGE_HISTORY(MemoryStream stream,out string msgName)
{
MSG_CG_GET_RECHARGE_HISTORY MSG_CG_GET_RECHARGE_HISTORY = MessagePacker.ProtobufHelper.Deserialize<MSG_CG_GET_RECHARGE_HISTORY>(stream);
msgName = "MSG_CG_GET_RECHARGE_HISTORY";
Parser.Parse(MSG_CG_GET_RECHARGE_HISTORY);
}
public object Deserialize_MSG_CG_GET_RECHARGE_HISTORY(MemoryStream stream)
{
return  MessagePacker.ProtobufHelper.Deserialize<MSG_CG_GET_RECHARGE_HISTORY>(stream);
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
public void OnResponse_MSG_CG_DELETE_RECHARGE_HISTORY(MemoryStream stream,out string msgName)
{
MSG_CG_DELETE_RECHARGE_HISTORY MSG_CG_DELETE_RECHARGE_HISTORY = MessagePacker.ProtobufHelper.Deserialize<MSG_CG_DELETE_RECHARGE_HISTORY>(stream);
msgName = "MSG_CG_DELETE_RECHARGE_HISTORY";
Parser.Parse(MSG_CG_DELETE_RECHARGE_HISTORY);
}
public object Deserialize_MSG_CG_DELETE_RECHARGE_HISTORY(MemoryStream stream)
{
return  MessagePacker.ProtobufHelper.Deserialize<MSG_CG_DELETE_RECHARGE_HISTORY>(stream);
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
public void OnResponse_MSG_CG_FRIEND_SEARCH(MemoryStream stream,out string msgName)
{
MSG_CG_FRIEND_SEARCH MSG_CG_FRIEND_SEARCH = MessagePacker.ProtobufHelper.Deserialize<MSG_CG_FRIEND_SEARCH>(stream);
msgName = "MSG_CG_FRIEND_SEARCH";
Parser.Parse(MSG_CG_FRIEND_SEARCH);
}
public object Deserialize_MSG_CG_FRIEND_SEARCH(MemoryStream stream)
{
return  MessagePacker.ProtobufHelper.Deserialize<MSG_CG_FRIEND_SEARCH>(stream);
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
public void OnResponse_MSG_CG_FRIEND_ADD_REQUEST(MemoryStream stream,out string msgName)
{
MSG_CG_FRIEND_ADD_REQUEST MSG_CG_FRIEND_ADD_REQUEST = MessagePacker.ProtobufHelper.Deserialize<MSG_CG_FRIEND_ADD_REQUEST>(stream);
msgName = "MSG_CG_FRIEND_ADD_REQUEST";
Parser.Parse(MSG_CG_FRIEND_ADD_REQUEST);
}
public object Deserialize_MSG_CG_FRIEND_ADD_REQUEST(MemoryStream stream)
{
return  MessagePacker.ProtobufHelper.Deserialize<MSG_CG_FRIEND_ADD_REQUEST>(stream);
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
public void OnResponse_MSG_CG_FRIEND_ADD_RESPONSE(MemoryStream stream,out string msgName)
{
MSG_CG_FRIEND_ADD_RESPONSE MSG_CG_FRIEND_ADD_RESPONSE = MessagePacker.ProtobufHelper.Deserialize<MSG_CG_FRIEND_ADD_RESPONSE>(stream);
msgName = "MSG_CG_FRIEND_ADD_RESPONSE";
Parser.Parse(MSG_CG_FRIEND_ADD_RESPONSE);
}
public object Deserialize_MSG_CG_FRIEND_ADD_RESPONSE(MemoryStream stream)
{
return  MessagePacker.ProtobufHelper.Deserialize<MSG_CG_FRIEND_ADD_RESPONSE>(stream);
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
public void OnResponse_MSG_CG_FRIEND_DELETE(MemoryStream stream,out string msgName)
{
MSG_CG_FRIEND_DELETE MSG_CG_FRIEND_DELETE = MessagePacker.ProtobufHelper.Deserialize<MSG_CG_FRIEND_DELETE>(stream);
msgName = "MSG_CG_FRIEND_DELETE";
Parser.Parse(MSG_CG_FRIEND_DELETE);
}
public object Deserialize_MSG_CG_FRIEND_DELETE(MemoryStream stream)
{
return  MessagePacker.ProtobufHelper.Deserialize<MSG_CG_FRIEND_DELETE>(stream);
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
public void OnResponse_MSG_CG_FRIEND_REQUEST_LIST(MemoryStream stream,out string msgName)
{
MSG_CG_FRIEND_REQUEST_LIST MSG_CG_FRIEND_REQUEST_LIST = MessagePacker.ProtobufHelper.Deserialize<MSG_CG_FRIEND_REQUEST_LIST>(stream);
msgName = "MSG_CG_FRIEND_REQUEST_LIST";
Parser.Parse(MSG_CG_FRIEND_REQUEST_LIST);
}
public object Deserialize_MSG_CG_FRIEND_REQUEST_LIST(MemoryStream stream)
{
return  MessagePacker.ProtobufHelper.Deserialize<MSG_CG_FRIEND_REQUEST_LIST>(stream);
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
public void OnResponse_MSG_CG_FRIEND_RECENT_LIST(MemoryStream stream,out string msgName)
{
MSG_CG_FRIEND_RECENT_LIST MSG_CG_FRIEND_RECENT_LIST = MessagePacker.ProtobufHelper.Deserialize<MSG_CG_FRIEND_RECENT_LIST>(stream);
msgName = "MSG_CG_FRIEND_RECENT_LIST";
Parser.Parse(MSG_CG_FRIEND_RECENT_LIST);
}
public object Deserialize_MSG_CG_FRIEND_RECENT_LIST(MemoryStream stream)
{
return  MessagePacker.ProtobufHelper.Deserialize<MSG_CG_FRIEND_RECENT_LIST>(stream);
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
public void OnResponse_MSG_CG_FRIEND_BLACK_LIST(MemoryStream stream,out string msgName)
{
MSG_CG_FRIEND_BLACK_LIST MSG_CG_FRIEND_BLACK_LIST = MessagePacker.ProtobufHelper.Deserialize<MSG_CG_FRIEND_BLACK_LIST>(stream);
msgName = "MSG_CG_FRIEND_BLACK_LIST";
Parser.Parse(MSG_CG_FRIEND_BLACK_LIST);
}
public object Deserialize_MSG_CG_FRIEND_BLACK_LIST(MemoryStream stream)
{
return  MessagePacker.ProtobufHelper.Deserialize<MSG_CG_FRIEND_BLACK_LIST>(stream);
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
public void OnResponse_MSG_CG_FRIEND_LIST(MemoryStream stream,out string msgName)
{
MSG_CG_FRIEND_LIST MSG_CG_FRIEND_LIST = MessagePacker.ProtobufHelper.Deserialize<MSG_CG_FRIEND_LIST>(stream);
msgName = "MSG_CG_FRIEND_LIST";
Parser.Parse(MSG_CG_FRIEND_LIST);
}
public object Deserialize_MSG_CG_FRIEND_LIST(MemoryStream stream)
{
return  MessagePacker.ProtobufHelper.Deserialize<MSG_CG_FRIEND_LIST>(stream);
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
public void OnResponse_MSG_CG_FRIEND_BLACK_ADD(MemoryStream stream,out string msgName)
{
MSG_CG_FRIEND_BLACK_ADD MSG_CG_FRIEND_BLACK_ADD = MessagePacker.ProtobufHelper.Deserialize<MSG_CG_FRIEND_BLACK_ADD>(stream);
msgName = "MSG_CG_FRIEND_BLACK_ADD";
Parser.Parse(MSG_CG_FRIEND_BLACK_ADD);
}
public object Deserialize_MSG_CG_FRIEND_BLACK_ADD(MemoryStream stream)
{
return  MessagePacker.ProtobufHelper.Deserialize<MSG_CG_FRIEND_BLACK_ADD>(stream);
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
public void OnResponse_MSG_CG_FRIEND_BLACK_DEL(MemoryStream stream,out string msgName)
{
MSG_CG_FRIEND_BLACK_DEL MSG_CG_FRIEND_BLACK_DEL = MessagePacker.ProtobufHelper.Deserialize<MSG_CG_FRIEND_BLACK_DEL>(stream);
msgName = "MSG_CG_FRIEND_BLACK_DEL";
Parser.Parse(MSG_CG_FRIEND_BLACK_DEL);
}
public object Deserialize_MSG_CG_FRIEND_BLACK_DEL(MemoryStream stream)
{
return  MessagePacker.ProtobufHelper.Deserialize<MSG_CG_FRIEND_BLACK_DEL>(stream);
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
public void OnResponse_MSG_CG_FRIEND_RECOMMEND(MemoryStream stream,out string msgName)
{
MSG_CG_FRIEND_RECOMMEND MSG_CG_FRIEND_RECOMMEND = MessagePacker.ProtobufHelper.Deserialize<MSG_CG_FRIEND_RECOMMEND>(stream);
msgName = "MSG_CG_FRIEND_RECOMMEND";
Parser.Parse(MSG_CG_FRIEND_RECOMMEND);
}
public object Deserialize_MSG_CG_FRIEND_RECOMMEND(MemoryStream stream)
{
return  MessagePacker.ProtobufHelper.Deserialize<MSG_CG_FRIEND_RECOMMEND>(stream);
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
public void OnResponse_MSG_CG_CREATE_GUILD(MemoryStream stream,out string msgName)
{
MSG_CG_CREATE_GUILD MSG_CG_CREATE_GUILD = MessagePacker.ProtobufHelper.Deserialize<MSG_CG_CREATE_GUILD>(stream);
msgName = "MSG_CG_CREATE_GUILD";
Parser.Parse(MSG_CG_CREATE_GUILD);
}
public object Deserialize_MSG_CG_CREATE_GUILD(MemoryStream stream)
{
return  MessagePacker.ProtobufHelper.Deserialize<MSG_CG_CREATE_GUILD>(stream);
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
public void OnResponse_MSG_CG_CHAT_EMOJI(MemoryStream stream,out string msgName)
{
MSG_CG_CHAT_EMOJI MSG_CG_CHAT_EMOJI = MessagePacker.ProtobufHelper.Deserialize<MSG_CG_CHAT_EMOJI>(stream);
msgName = "MSG_CG_CHAT_EMOJI";
Parser.Parse(MSG_CG_CHAT_EMOJI);
}
public object Deserialize_MSG_CG_CHAT_EMOJI(MemoryStream stream)
{
return  MessagePacker.ProtobufHelper.Deserialize<MSG_CG_CHAT_EMOJI>(stream);
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
public void OnResponse_MSG_CG_CHAT_WORDS(MemoryStream stream,out string msgName)
{
MSG_CG_CHAT_WORDS MSG_CG_CHAT_WORDS = MessagePacker.ProtobufHelper.Deserialize<MSG_CG_CHAT_WORDS>(stream);
msgName = "MSG_CG_CHAT_WORDS";
Parser.Parse(MSG_CG_CHAT_WORDS);
}
public object Deserialize_MSG_CG_CHAT_WORDS(MemoryStream stream)
{
return  MessagePacker.ProtobufHelper.Deserialize<MSG_CG_CHAT_WORDS>(stream);
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
public void OnResponse_MSG_CG_CHANGE_WORLD_ROOM(MemoryStream stream,out string msgName)
{
MSG_CG_CHANGE_WORLD_ROOM MSG_CG_CHANGE_WORLD_ROOM = MessagePacker.ProtobufHelper.Deserialize<MSG_CG_CHANGE_WORLD_ROOM>(stream);
msgName = "MSG_CG_CHANGE_WORLD_ROOM";
Parser.Parse(MSG_CG_CHANGE_WORLD_ROOM);
}
public object Deserialize_MSG_CG_CHANGE_WORLD_ROOM(MemoryStream stream)
{
return  MessagePacker.ProtobufHelper.Deserialize<MSG_CG_CHANGE_WORLD_ROOM>(stream);
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
public void OnResponse_MSG_CG_GET_WORLD_ROOM_LIST(MemoryStream stream,out string msgName)
{
MSG_CG_GET_WORLD_ROOM_LIST MSG_CG_GET_WORLD_ROOM_LIST = MessagePacker.ProtobufHelper.Deserialize<MSG_CG_GET_WORLD_ROOM_LIST>(stream);
msgName = "MSG_CG_GET_WORLD_ROOM_LIST";
Parser.Parse(MSG_CG_GET_WORLD_ROOM_LIST);
}
public object Deserialize_MSG_CG_GET_WORLD_ROOM_LIST(MemoryStream stream)
{
return  MessagePacker.ProtobufHelper.Deserialize<MSG_CG_GET_WORLD_ROOM_LIST>(stream);
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
public void OnResponse_MSG_CG_CHAT_TRUMPET(MemoryStream stream,out string msgName)
{
MSG_CG_CHAT_TRUMPET MSG_CG_CHAT_TRUMPET = MessagePacker.ProtobufHelper.Deserialize<MSG_CG_CHAT_TRUMPET>(stream);
msgName = "MSG_CG_CHAT_TRUMPET";
Parser.Parse(MSG_CG_CHAT_TRUMPET);
}
public object Deserialize_MSG_CG_CHAT_TRUMPET(MemoryStream stream)
{
return  MessagePacker.ProtobufHelper.Deserialize<MSG_CG_CHAT_TRUMPET>(stream);
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
public void OnResponse_MSG_CG_CHAT_REPORT(MemoryStream stream,out string msgName)
{
MSG_CG_CHAT_REPORT MSG_CG_CHAT_REPORT = MessagePacker.ProtobufHelper.Deserialize<MSG_CG_CHAT_REPORT>(stream);
msgName = "MSG_CG_CHAT_REPORT";
Parser.Parse(MSG_CG_CHAT_REPORT);
}
public object Deserialize_MSG_CG_CHAT_REPORT(MemoryStream stream)
{
return  MessagePacker.ProtobufHelper.Deserialize<MSG_CG_CHAT_REPORT>(stream);
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
public void OnResponse_MSG_CG_NEARBY_EMOJI(MemoryStream stream,out string msgName)
{
MSG_CG_NEARBY_EMOJI MSG_CG_NEARBY_EMOJI = MessagePacker.ProtobufHelper.Deserialize<MSG_CG_NEARBY_EMOJI>(stream);
msgName = "MSG_CG_NEARBY_EMOJI";
Parser.Parse(MSG_CG_NEARBY_EMOJI);
}
public object Deserialize_MSG_CG_NEARBY_EMOJI(MemoryStream stream)
{
return  MessagePacker.ProtobufHelper.Deserialize<MSG_CG_NEARBY_EMOJI>(stream);
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
public void OnResponse_MSG_CG_TIP_OFF(MemoryStream stream,out string msgName)
{
MSG_CG_TIP_OFF MSG_CG_TIP_OFF = MessagePacker.ProtobufHelper.Deserialize<MSG_CG_TIP_OFF>(stream);
msgName = "MSG_CG_TIP_OFF";
Parser.Parse(MSG_CG_TIP_OFF);
}
public object Deserialize_MSG_CG_TIP_OFF(MemoryStream stream)
{
return  MessagePacker.ProtobufHelper.Deserialize<MSG_CG_TIP_OFF>(stream);
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
public void OnResponse_MSG_CG_ACTIVITY_CHAT_BUBBLE(MemoryStream stream,out string msgName)
{
MSG_CG_ACTIVITY_CHAT_BUBBLE MSG_CG_ACTIVITY_CHAT_BUBBLE = MessagePacker.ProtobufHelper.Deserialize<MSG_CG_ACTIVITY_CHAT_BUBBLE>(stream);
msgName = "MSG_CG_ACTIVITY_CHAT_BUBBLE";
Parser.Parse(MSG_CG_ACTIVITY_CHAT_BUBBLE);
}
public object Deserialize_MSG_CG_ACTIVITY_CHAT_BUBBLE(MemoryStream stream)
{
return  MessagePacker.ProtobufHelper.Deserialize<MSG_CG_ACTIVITY_CHAT_BUBBLE>(stream);
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
public void OnResponse_MSG_CG_USE_CHAT_TRUMPET(MemoryStream stream,out string msgName)
{
MSG_CG_USE_CHAT_TRUMPET MSG_CG_USE_CHAT_TRUMPET = MessagePacker.ProtobufHelper.Deserialize<MSG_CG_USE_CHAT_TRUMPET>(stream);
msgName = "MSG_CG_USE_CHAT_TRUMPET";
Parser.Parse(MSG_CG_USE_CHAT_TRUMPET);
}
public object Deserialize_MSG_CG_USE_CHAT_TRUMPET(MemoryStream stream)
{
return  MessagePacker.ProtobufHelper.Deserialize<MSG_CG_USE_CHAT_TRUMPET>(stream);
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
public void OnResponse_MSG_CG_TASK_COMPLETE(MemoryStream stream,out string msgName)
{
MSG_CG_TASK_COMPLETE MSG_CG_TASK_COMPLETE = MessagePacker.ProtobufHelper.Deserialize<MSG_CG_TASK_COMPLETE>(stream);
msgName = "MSG_CG_TASK_COMPLETE";
Parser.Parse(MSG_CG_TASK_COMPLETE);
}
public object Deserialize_MSG_CG_TASK_COMPLETE(MemoryStream stream)
{
return  MessagePacker.ProtobufHelper.Deserialize<MSG_CG_TASK_COMPLETE>(stream);
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
public void OnResponse_MSG_CG_OPENE_EMAIL_TASK(MemoryStream stream,out string msgName)
{
MSG_CG_OPENE_EMAIL_TASK MSG_CG_OPENE_EMAIL_TASK = MessagePacker.ProtobufHelper.Deserialize<MSG_CG_OPENE_EMAIL_TASK>(stream);
msgName = "MSG_CG_OPENE_EMAIL_TASK";
Parser.Parse(MSG_CG_OPENE_EMAIL_TASK);
}
public object Deserialize_MSG_CG_OPENE_EMAIL_TASK(MemoryStream stream)
{
return  MessagePacker.ProtobufHelper.Deserialize<MSG_CG_OPENE_EMAIL_TASK>(stream);
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
public void OnResponse_MSG_CG_TASK_COLLECT(MemoryStream stream,out string msgName)
{
MSG_CG_TASK_COLLECT MSG_CG_TASK_COLLECT = MessagePacker.ProtobufHelper.Deserialize<MSG_CG_TASK_COLLECT>(stream);
msgName = "MSG_CG_TASK_COLLECT";
Parser.Parse(MSG_CG_TASK_COLLECT);
}
public object Deserialize_MSG_CG_TASK_COLLECT(MemoryStream stream)
{
return  MessagePacker.ProtobufHelper.Deserialize<MSG_CG_TASK_COLLECT>(stream);
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
public void OnResponse_MSG_CG_TASK_SELECT(MemoryStream stream,out string msgName)
{
MSG_CG_TASK_SELECT MSG_CG_TASK_SELECT = MessagePacker.ProtobufHelper.Deserialize<MSG_CG_TASK_SELECT>(stream);
msgName = "MSG_CG_TASK_SELECT";
Parser.Parse(MSG_CG_TASK_SELECT);
}
public object Deserialize_MSG_CG_TASK_SELECT(MemoryStream stream)
{
return  MessagePacker.ProtobufHelper.Deserialize<MSG_CG_TASK_SELECT>(stream);
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
public void OnResponse_MSG_CG_TASK_MAKE(MemoryStream stream,out string msgName)
{
MSG_CG_TASK_MAKE MSG_CG_TASK_MAKE = MessagePacker.ProtobufHelper.Deserialize<MSG_CG_TASK_MAKE>(stream);
msgName = "MSG_CG_TASK_MAKE";
Parser.Parse(MSG_CG_TASK_MAKE);
}
public object Deserialize_MSG_CG_TASK_MAKE(MemoryStream stream)
{
return  MessagePacker.ProtobufHelper.Deserialize<MSG_CG_TASK_MAKE>(stream);
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
public void OnResponse_MSG_CG_TASKFLY_FLY_DONE(MemoryStream stream,out string msgName)
{
MSG_CG_TASKFLY_FLY_DONE MSG_CG_TASKFLY_FLY_DONE = MessagePacker.ProtobufHelper.Deserialize<MSG_CG_TASKFLY_FLY_DONE>(stream);
msgName = "MSG_CG_TASKFLY_FLY_DONE";
Parser.Parse(MSG_CG_TASKFLY_FLY_DONE);
}
public object Deserialize_MSG_CG_TASKFLY_FLY_DONE(MemoryStream stream)
{
return  MessagePacker.ProtobufHelper.Deserialize<MSG_CG_TASKFLY_FLY_DONE>(stream);
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
public void OnResponse_MSG_CG_TASKFLY_STARTPATHFINDING(MemoryStream stream,out string msgName)
{
MSG_CG_TASKFLY_STARTPATHFINDING MSG_CG_TASKFLY_STARTPATHFINDING = MessagePacker.ProtobufHelper.Deserialize<MSG_CG_TASKFLY_STARTPATHFINDING>(stream);
msgName = "MSG_CG_TASKFLY_STARTPATHFINDING";
Parser.Parse(MSG_CG_TASKFLY_STARTPATHFINDING);
}
public object Deserialize_MSG_CG_TASKFLY_STARTPATHFINDING(MemoryStream stream)
{
return  MessagePacker.ProtobufHelper.Deserialize<MSG_CG_TASKFLY_STARTPATHFINDING>(stream);
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
public void OnResponse_MSG_CG_ACTIVITY_COMPLETE(MemoryStream stream,out string msgName)
{
MSG_CG_ACTIVITY_COMPLETE MSG_CG_ACTIVITY_COMPLETE = MessagePacker.ProtobufHelper.Deserialize<MSG_CG_ACTIVITY_COMPLETE>(stream);
msgName = "MSG_CG_ACTIVITY_COMPLETE";
Parser.Parse(MSG_CG_ACTIVITY_COMPLETE);
}
public object Deserialize_MSG_CG_ACTIVITY_COMPLETE(MemoryStream stream)
{
return  MessagePacker.ProtobufHelper.Deserialize<MSG_CG_ACTIVITY_COMPLETE>(stream);
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
public void OnResponse_MSG_CG_SHOW_CHARACTER(MemoryStream stream,out string msgName)
{
MSG_CG_SHOW_CHARACTER MSG_CG_SHOW_CHARACTER = MessagePacker.ProtobufHelper.Deserialize<MSG_CG_SHOW_CHARACTER>(stream);
msgName = "MSG_CG_SHOW_CHARACTER";
Parser.Parse(MSG_CG_SHOW_CHARACTER);
}
public object Deserialize_MSG_CG_SHOW_CHARACTER(MemoryStream stream)
{
return  MessagePacker.ProtobufHelper.Deserialize<MSG_CG_SHOW_CHARACTER>(stream);
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
public void OnResponse_MSG_CG_CHANGE_NAME(MemoryStream stream,out string msgName)
{
MSG_CG_CHANGE_NAME MSG_CG_CHANGE_NAME = MessagePacker.ProtobufHelper.Deserialize<MSG_CG_CHANGE_NAME>(stream);
msgName = "MSG_CG_CHANGE_NAME";
Parser.Parse(MSG_CG_CHANGE_NAME);
}
public object Deserialize_MSG_CG_CHANGE_NAME(MemoryStream stream)
{
return  MessagePacker.ProtobufHelper.Deserialize<MSG_CG_CHANGE_NAME>(stream);
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
public void OnResponse_MSG_CG_SHOW_FACEICON(MemoryStream stream,out string msgName)
{
MSG_CG_SHOW_FACEICON MSG_CG_SHOW_FACEICON = MessagePacker.ProtobufHelper.Deserialize<MSG_CG_SHOW_FACEICON>(stream);
msgName = "MSG_CG_SHOW_FACEICON";
Parser.Parse(MSG_CG_SHOW_FACEICON);
}
public object Deserialize_MSG_CG_SHOW_FACEICON(MemoryStream stream)
{
return  MessagePacker.ProtobufHelper.Deserialize<MSG_CG_SHOW_FACEICON>(stream);
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
public void OnResponse_MSG_CG_SHOW_FACEJPG(MemoryStream stream,out string msgName)
{
MSG_CG_SHOW_FACEJPG MSG_CG_SHOW_FACEJPG = MessagePacker.ProtobufHelper.Deserialize<MSG_CG_SHOW_FACEJPG>(stream);
msgName = "MSG_CG_SHOW_FACEJPG";
Parser.Parse(MSG_CG_SHOW_FACEJPG);
}
public object Deserialize_MSG_CG_SHOW_FACEJPG(MemoryStream stream)
{
return  MessagePacker.ProtobufHelper.Deserialize<MSG_CG_SHOW_FACEJPG>(stream);
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
public void OnResponse_MSG_CG_SET_SEX(MemoryStream stream,out string msgName)
{
MSG_CG_SET_SEX MSG_CG_SET_SEX = MessagePacker.ProtobufHelper.Deserialize<MSG_CG_SET_SEX>(stream);
msgName = "MSG_CG_SET_SEX";
Parser.Parse(MSG_CG_SET_SEX);
}
public object Deserialize_MSG_CG_SET_SEX(MemoryStream stream)
{
return  MessagePacker.ProtobufHelper.Deserialize<MSG_CG_SET_SEX>(stream);
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
public void OnResponse_MSG_CG_SET_BIRTHDAY(MemoryStream stream,out string msgName)
{
MSG_CG_SET_BIRTHDAY MSG_CG_SET_BIRTHDAY = MessagePacker.ProtobufHelper.Deserialize<MSG_CG_SET_BIRTHDAY>(stream);
msgName = "MSG_CG_SET_BIRTHDAY";
Parser.Parse(MSG_CG_SET_BIRTHDAY);
}
public object Deserialize_MSG_CG_SET_BIRTHDAY(MemoryStream stream)
{
return  MessagePacker.ProtobufHelper.Deserialize<MSG_CG_SET_BIRTHDAY>(stream);
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
public void OnResponse_MSG_CG_SET_SIGNATURE(MemoryStream stream,out string msgName)
{
MSG_CG_SET_SIGNATURE MSG_CG_SET_SIGNATURE = MessagePacker.ProtobufHelper.Deserialize<MSG_CG_SET_SIGNATURE>(stream);
msgName = "MSG_CG_SET_SIGNATURE";
Parser.Parse(MSG_CG_SET_SIGNATURE);
}
public object Deserialize_MSG_CG_SET_SIGNATURE(MemoryStream stream)
{
return  MessagePacker.ProtobufHelper.Deserialize<MSG_CG_SET_SIGNATURE>(stream);
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
public void OnResponse_MSG_CG_SHOW_VOICE(MemoryStream stream,out string msgName)
{
MSG_CG_SHOW_VOICE MSG_CG_SHOW_VOICE = MessagePacker.ProtobufHelper.Deserialize<MSG_CG_SHOW_VOICE>(stream);
msgName = "MSG_CG_SHOW_VOICE";
Parser.Parse(MSG_CG_SHOW_VOICE);
}
public object Deserialize_MSG_CG_SHOW_VOICE(MemoryStream stream)
{
return  MessagePacker.ProtobufHelper.Deserialize<MSG_CG_SHOW_VOICE>(stream);
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
public void OnResponse_MSG_CG_PRESENT_GIFT(MemoryStream stream,out string msgName)
{
MSG_CG_PRESENT_GIFT MSG_CG_PRESENT_GIFT = MessagePacker.ProtobufHelper.Deserialize<MSG_CG_PRESENT_GIFT>(stream);
msgName = "MSG_CG_PRESENT_GIFT";
Parser.Parse(MSG_CG_PRESENT_GIFT);
}
public object Deserialize_MSG_CG_PRESENT_GIFT(MemoryStream stream)
{
return  MessagePacker.ProtobufHelper.Deserialize<MSG_CG_PRESENT_GIFT>(stream);
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
public void OnResponse_MSG_CG_GET_GIFTRECORD(MemoryStream stream,out string msgName)
{
MSG_CG_GET_GIFTRECORD MSG_CG_GET_GIFTRECORD = MessagePacker.ProtobufHelper.Deserialize<MSG_CG_GET_GIFTRECORD>(stream);
msgName = "MSG_CG_GET_GIFTRECORD";
Parser.Parse(MSG_CG_GET_GIFTRECORD);
}
public object Deserialize_MSG_CG_GET_GIFTRECORD(MemoryStream stream)
{
return  MessagePacker.ProtobufHelper.Deserialize<MSG_CG_GET_GIFTRECORD>(stream);
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
public void OnResponse_MSG_CG_SET_SOCIAL_NUM(MemoryStream stream,out string msgName)
{
MSG_CG_SET_SOCIAL_NUM MSG_CG_SET_SOCIAL_NUM = MessagePacker.ProtobufHelper.Deserialize<MSG_CG_SET_SOCIAL_NUM>(stream);
msgName = "MSG_CG_SET_SOCIAL_NUM";
Parser.Parse(MSG_CG_SET_SOCIAL_NUM);
}
public object Deserialize_MSG_CG_SET_SOCIAL_NUM(MemoryStream stream)
{
return  MessagePacker.ProtobufHelper.Deserialize<MSG_CG_SET_SOCIAL_NUM>(stream);
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
public void OnResponse_MSG_CG_GET_SOCIAL_NUM(MemoryStream stream,out string msgName)
{
MSG_CG_GET_SOCIAL_NUM MSG_CG_GET_SOCIAL_NUM = MessagePacker.ProtobufHelper.Deserialize<MSG_CG_GET_SOCIAL_NUM>(stream);
msgName = "MSG_CG_GET_SOCIAL_NUM";
Parser.Parse(MSG_CG_GET_SOCIAL_NUM);
}
public object Deserialize_MSG_CG_GET_SOCIAL_NUM(MemoryStream stream)
{
return  MessagePacker.ProtobufHelper.Deserialize<MSG_CG_GET_SOCIAL_NUM>(stream);
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
public void OnResponse_MSG_CG_SHOW_CAREER(MemoryStream stream,out string msgName)
{
MSG_CG_SHOW_CAREER MSG_CG_SHOW_CAREER = MessagePacker.ProtobufHelper.Deserialize<MSG_CG_SHOW_CAREER>(stream);
msgName = "MSG_CG_SHOW_CAREER";
Parser.Parse(MSG_CG_SHOW_CAREER);
}
public object Deserialize_MSG_CG_SHOW_CAREER(MemoryStream stream)
{
return  MessagePacker.ProtobufHelper.Deserialize<MSG_CG_SHOW_CAREER>(stream);
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
public void OnResponse_MSG_CG_GET_RANKING_FRIEND_LIST(MemoryStream stream,out string msgName)
{
MSG_CG_GET_RANKING_FRIEND_LIST MSG_CG_GET_RANKING_FRIEND_LIST = MessagePacker.ProtobufHelper.Deserialize<MSG_CG_GET_RANKING_FRIEND_LIST>(stream);
msgName = "MSG_CG_GET_RANKING_FRIEND_LIST";
Parser.Parse(MSG_CG_GET_RANKING_FRIEND_LIST);
}
public object Deserialize_MSG_CG_GET_RANKING_FRIEND_LIST(MemoryStream stream)
{
return  MessagePacker.ProtobufHelper.Deserialize<MSG_CG_GET_RANKING_FRIEND_LIST>(stream);
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
public void OnResponse_MSG_CG_GET_RANKING_ALL_LIST(MemoryStream stream,out string msgName)
{
MSG_CG_GET_RANKING_ALL_LIST MSG_CG_GET_RANKING_ALL_LIST = MessagePacker.ProtobufHelper.Deserialize<MSG_CG_GET_RANKING_ALL_LIST>(stream);
msgName = "MSG_CG_GET_RANKING_ALL_LIST";
Parser.Parse(MSG_CG_GET_RANKING_ALL_LIST);
}
public object Deserialize_MSG_CG_GET_RANKING_ALL_LIST(MemoryStream stream)
{
return  MessagePacker.ProtobufHelper.Deserialize<MSG_CG_GET_RANKING_ALL_LIST>(stream);
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
public void OnResponse_MSG_CG_GET_RANKING_NEARBY_LIST(MemoryStream stream,out string msgName)
{
MSG_CG_GET_RANKING_NEARBY_LIST MSG_CG_GET_RANKING_NEARBY_LIST = MessagePacker.ProtobufHelper.Deserialize<MSG_CG_GET_RANKING_NEARBY_LIST>(stream);
msgName = "MSG_CG_GET_RANKING_NEARBY_LIST";
Parser.Parse(MSG_CG_GET_RANKING_NEARBY_LIST);
}
public object Deserialize_MSG_CG_GET_RANKING_NEARBY_LIST(MemoryStream stream)
{
return  MessagePacker.ProtobufHelper.Deserialize<MSG_CG_GET_RANKING_NEARBY_LIST>(stream);
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
public void OnResponse_MSG_CG_CHANGE_TITLE(MemoryStream stream,out string msgName)
{
MSG_CG_CHANGE_TITLE MSG_CG_CHANGE_TITLE = MessagePacker.ProtobufHelper.Deserialize<MSG_CG_CHANGE_TITLE>(stream);
msgName = "MSG_CG_CHANGE_TITLE";
Parser.Parse(MSG_CG_CHANGE_TITLE);
}
public object Deserialize_MSG_CG_CHANGE_TITLE(MemoryStream stream)
{
return  MessagePacker.ProtobufHelper.Deserialize<MSG_CG_CHANGE_TITLE>(stream);
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
public void OnResponse_MSG_CG_UPLOAD_PHOTO(MemoryStream stream,out string msgName)
{
MSG_CG_UPLOAD_PHOTO MSG_CG_UPLOAD_PHOTO = MessagePacker.ProtobufHelper.Deserialize<MSG_CG_UPLOAD_PHOTO>(stream);
msgName = "MSG_CG_UPLOAD_PHOTO";
Parser.Parse(MSG_CG_UPLOAD_PHOTO);
}
public object Deserialize_MSG_CG_UPLOAD_PHOTO(MemoryStream stream)
{
return  MessagePacker.ProtobufHelper.Deserialize<MSG_CG_UPLOAD_PHOTO>(stream);
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
public void OnResponse_MSG_CG_REMOVE_PHOTO(MemoryStream stream,out string msgName)
{
MSG_CG_REMOVE_PHOTO MSG_CG_REMOVE_PHOTO = MessagePacker.ProtobufHelper.Deserialize<MSG_CG_REMOVE_PHOTO>(stream);
msgName = "MSG_CG_REMOVE_PHOTO";
Parser.Parse(MSG_CG_REMOVE_PHOTO);
}
public object Deserialize_MSG_CG_REMOVE_PHOTO(MemoryStream stream)
{
return  MessagePacker.ProtobufHelper.Deserialize<MSG_CG_REMOVE_PHOTO>(stream);
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
public void OnResponse_MSG_CG_PHOTO_LIST(MemoryStream stream,out string msgName)
{
MSG_CG_PHOTO_LIST MSG_CG_PHOTO_LIST = MessagePacker.ProtobufHelper.Deserialize<MSG_CG_PHOTO_LIST>(stream);
msgName = "MSG_CG_PHOTO_LIST";
Parser.Parse(MSG_CG_PHOTO_LIST);
}
public object Deserialize_MSG_CG_PHOTO_LIST(MemoryStream stream)
{
return  MessagePacker.ProtobufHelper.Deserialize<MSG_CG_PHOTO_LIST>(stream);
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
public void OnResponse_MSG_CG_POP_RANK(MemoryStream stream,out string msgName)
{
MSG_CG_POP_RANK MSG_CG_POP_RANK = MessagePacker.ProtobufHelper.Deserialize<MSG_CG_POP_RANK>(stream);
msgName = "MSG_CG_POP_RANK";
Parser.Parse(MSG_CG_POP_RANK);
}
public object Deserialize_MSG_CG_POP_RANK(MemoryStream stream)
{
return  MessagePacker.ProtobufHelper.Deserialize<MSG_CG_POP_RANK>(stream);
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
public void OnResponse_MSG_CG_QUESTION(MemoryStream stream,out string msgName)
{
MSG_CG_QUESTION MSG_CG_QUESTION = MessagePacker.ProtobufHelper.Deserialize<MSG_CG_QUESTION>(stream);
msgName = "MSG_CG_QUESTION";
Parser.Parse(MSG_CG_QUESTION);
}
public object Deserialize_MSG_CG_QUESTION(MemoryStream stream)
{
return  MessagePacker.ProtobufHelper.Deserialize<MSG_CG_QUESTION>(stream);
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
public void OnResponse_MSG_CG_QUESTIONNAIRE(MemoryStream stream,out string msgName)
{
MSG_CG_QUESTIONNAIRE MSG_CG_QUESTIONNAIRE = MessagePacker.ProtobufHelper.Deserialize<MSG_CG_QUESTIONNAIRE>(stream);
msgName = "MSG_CG_QUESTIONNAIRE";
Parser.Parse(MSG_CG_QUESTIONNAIRE);
}
public object Deserialize_MSG_CG_QUESTIONNAIRE(MemoryStream stream)
{
return  MessagePacker.ProtobufHelper.Deserialize<MSG_CG_QUESTIONNAIRE>(stream);
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
public void OnResponse_MSG_CG_DAILY_QUESTION_COUNTER(MemoryStream stream,out string msgName)
{
MSG_CG_DAILY_QUESTION_COUNTER MSG_CG_DAILY_QUESTION_COUNTER = MessagePacker.ProtobufHelper.Deserialize<MSG_CG_DAILY_QUESTION_COUNTER>(stream);
msgName = "MSG_CG_DAILY_QUESTION_COUNTER";
Parser.Parse(MSG_CG_DAILY_QUESTION_COUNTER);
}
public object Deserialize_MSG_CG_DAILY_QUESTION_COUNTER(MemoryStream stream)
{
return  MessagePacker.ProtobufHelper.Deserialize<MSG_CG_DAILY_QUESTION_COUNTER>(stream);
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
public void OnResponse_MSG_CG_DAILY_QUESTION_REWARD(MemoryStream stream,out string msgName)
{
MSG_CG_DAILY_QUESTION_REWARD MSG_CG_DAILY_QUESTION_REWARD = MessagePacker.ProtobufHelper.Deserialize<MSG_CG_DAILY_QUESTION_REWARD>(stream);
msgName = "MSG_CG_DAILY_QUESTION_REWARD";
Parser.Parse(MSG_CG_DAILY_QUESTION_REWARD);
}
public object Deserialize_MSG_CG_DAILY_QUESTION_REWARD(MemoryStream stream)
{
return  MessagePacker.ProtobufHelper.Deserialize<MSG_CG_DAILY_QUESTION_REWARD>(stream);
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
public void OnResponse_MSG_CG_RADIO_GET_ALL_ANCHOR_RANK(MemoryStream stream,out string msgName)
{
MSG_CG_RADIO_GET_ALL_ANCHOR_RANK MSG_CG_RADIO_GET_ALL_ANCHOR_RANK = MessagePacker.ProtobufHelper.Deserialize<MSG_CG_RADIO_GET_ALL_ANCHOR_RANK>(stream);
msgName = "MSG_CG_RADIO_GET_ALL_ANCHOR_RANK";
Parser.Parse(MSG_CG_RADIO_GET_ALL_ANCHOR_RANK);
}
public object Deserialize_MSG_CG_RADIO_GET_ALL_ANCHOR_RANK(MemoryStream stream)
{
return  MessagePacker.ProtobufHelper.Deserialize<MSG_CG_RADIO_GET_ALL_ANCHOR_RANK>(stream);
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
public void OnResponse_MSG_CG_RADIO_GET_ANCHOR_CONTRIBUTION_RANK(MemoryStream stream,out string msgName)
{
MSG_CG_RADIO_GET_ANCHOR_CONTRIBUTION_RANK MSG_CG_RADIO_GET_ANCHOR_CONTRIBUTION_RANK = MessagePacker.ProtobufHelper.Deserialize<MSG_CG_RADIO_GET_ANCHOR_CONTRIBUTION_RANK>(stream);
msgName = "MSG_CG_RADIO_GET_ANCHOR_CONTRIBUTION_RANK";
Parser.Parse(MSG_CG_RADIO_GET_ANCHOR_CONTRIBUTION_RANK);
}
public object Deserialize_MSG_CG_RADIO_GET_ANCHOR_CONTRIBUTION_RANK(MemoryStream stream)
{
return  MessagePacker.ProtobufHelper.Deserialize<MSG_CG_RADIO_GET_ANCHOR_CONTRIBUTION_RANK>(stream);
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
public void OnResponse_MSG_CG_RADIO_GET_ALL_CONTRIBUTION_RANK(MemoryStream stream,out string msgName)
{
MSG_CG_RADIO_GET_ALL_CONTRIBUTION_RANK MSG_CG_RADIO_GET_ALL_CONTRIBUTION_RANK = MessagePacker.ProtobufHelper.Deserialize<MSG_CG_RADIO_GET_ALL_CONTRIBUTION_RANK>(stream);
msgName = "MSG_CG_RADIO_GET_ALL_CONTRIBUTION_RANK";
Parser.Parse(MSG_CG_RADIO_GET_ALL_CONTRIBUTION_RANK);
}
public object Deserialize_MSG_CG_RADIO_GET_ALL_CONTRIBUTION_RANK(MemoryStream stream)
{
return  MessagePacker.ProtobufHelper.Deserialize<MSG_CG_RADIO_GET_ALL_CONTRIBUTION_RANK>(stream);
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
public void OnResponse_MSG_CG_RADIO_GET_CONTRIBUTION_REWARD(MemoryStream stream,out string msgName)
{
MSG_CG_RADIO_GET_CONTRIBUTION_REWARD MSG_CG_RADIO_GET_CONTRIBUTION_REWARD = MessagePacker.ProtobufHelper.Deserialize<MSG_CG_RADIO_GET_CONTRIBUTION_REWARD>(stream);
msgName = "MSG_CG_RADIO_GET_CONTRIBUTION_REWARD";
Parser.Parse(MSG_CG_RADIO_GET_CONTRIBUTION_REWARD);
}
public object Deserialize_MSG_CG_RADIO_GET_CONTRIBUTION_REWARD(MemoryStream stream)
{
return  MessagePacker.ProtobufHelper.Deserialize<MSG_CG_RADIO_GET_CONTRIBUTION_REWARD>(stream);
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
public void OnResponse_MSG_CG_RADIO_GIVE_GIFT(MemoryStream stream,out string msgName)
{
MSG_CG_RADIO_GIVE_GIFT MSG_CG_RADIO_GIVE_GIFT = MessagePacker.ProtobufHelper.Deserialize<MSG_CG_RADIO_GIVE_GIFT>(stream);
msgName = "MSG_CG_RADIO_GIVE_GIFT";
Parser.Parse(MSG_CG_RADIO_GIVE_GIFT);
}
public object Deserialize_MSG_CG_RADIO_GIVE_GIFT(MemoryStream stream)
{
return  MessagePacker.ProtobufHelper.Deserialize<MSG_CG_RADIO_GIVE_GIFT>(stream);
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
public void OnResponse_MSG_CG_RADIO_ENTER(MemoryStream stream,out string msgName)
{
MSG_CG_RADIO_ENTER MSG_CG_RADIO_ENTER = MessagePacker.ProtobufHelper.Deserialize<MSG_CG_RADIO_ENTER>(stream);
msgName = "MSG_CG_RADIO_ENTER";
Parser.Parse(MSG_CG_RADIO_ENTER);
}
public object Deserialize_MSG_CG_RADIO_ENTER(MemoryStream stream)
{
return  MessagePacker.ProtobufHelper.Deserialize<MSG_CG_RADIO_ENTER>(stream);
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
public void OnResponse_MSG_CG_RADIO_LEAVE(MemoryStream stream,out string msgName)
{
MSG_CG_RADIO_LEAVE MSG_CG_RADIO_LEAVE = MessagePacker.ProtobufHelper.Deserialize<MSG_CG_RADIO_LEAVE>(stream);
msgName = "MSG_CG_RADIO_LEAVE";
Parser.Parse(MSG_CG_RADIO_LEAVE);
}
public object Deserialize_MSG_CG_RADIO_LEAVE(MemoryStream stream)
{
return  MessagePacker.ProtobufHelper.Deserialize<MSG_CG_RADIO_LEAVE>(stream);
}

MSG_CG_CALL_PET msg_MSG_CG_CALL_PET;

public object Init_MSG_CG_CALL_PET()
{
msg_MSG_CG_CALL_PET = new MSG_CG_CALL_PET();
return msg_MSG_CG_CALL_PET;
}
public object Get_MSG_CG_CALL_PET()
{
return msg_MSG_CG_CALL_PET;
}
public object New_MSG_CG_CALL_PET()
{
return msg_MSG_CG_CALL_PET;
}
public void OnResponse_MSG_CG_CALL_PET(MemoryStream stream,out string msgName)
{
MSG_CG_CALL_PET MSG_CG_CALL_PET = MessagePacker.ProtobufHelper.Deserialize<MSG_CG_CALL_PET>(stream);
msgName = "MSG_CG_CALL_PET";
Parser.Parse(MSG_CG_CALL_PET);
}
public object Deserialize_MSG_CG_CALL_PET(MemoryStream stream)
{
return  MessagePacker.ProtobufHelper.Deserialize<MSG_CG_CALL_PET>(stream);
}

MSG_CG_RECALL_PET msg_MSG_CG_RECALL_PET;

public object Init_MSG_CG_RECALL_PET()
{
msg_MSG_CG_RECALL_PET = new MSG_CG_RECALL_PET();
return msg_MSG_CG_RECALL_PET;
}
public object Get_MSG_CG_RECALL_PET()
{
return msg_MSG_CG_RECALL_PET;
}
public object New_MSG_CG_RECALL_PET()
{
return msg_MSG_CG_RECALL_PET;
}
public void OnResponse_MSG_CG_RECALL_PET(MemoryStream stream,out string msgName)
{
MSG_CG_RECALL_PET MSG_CG_RECALL_PET = MessagePacker.ProtobufHelper.Deserialize<MSG_CG_RECALL_PET>(stream);
msgName = "MSG_CG_RECALL_PET";
Parser.Parse(MSG_CG_RECALL_PET);
}
public object Deserialize_MSG_CG_RECALL_PET(MemoryStream stream)
{
return  MessagePacker.ProtobufHelper.Deserialize<MSG_CG_RECALL_PET>(stream);
}

MSG_CG_CALL_HERO msg_MSG_CG_CALL_HERO;

public object Init_MSG_CG_CALL_HERO()
{
msg_MSG_CG_CALL_HERO = new MSG_CG_CALL_HERO();
return msg_MSG_CG_CALL_HERO;
}
public object Get_MSG_CG_CALL_HERO()
{
return msg_MSG_CG_CALL_HERO;
}
public object New_MSG_CG_CALL_HERO()
{
return msg_MSG_CG_CALL_HERO;
}
public void OnResponse_MSG_CG_CALL_HERO(MemoryStream stream,out string msgName)
{
MSG_CG_CALL_HERO MSG_CG_CALL_HERO = MessagePacker.ProtobufHelper.Deserialize<MSG_CG_CALL_HERO>(stream);
msgName = "MSG_CG_CALL_HERO";
Parser.Parse(MSG_CG_CALL_HERO);
}
public object Deserialize_MSG_CG_CALL_HERO(MemoryStream stream)
{
return  MessagePacker.ProtobufHelper.Deserialize<MSG_CG_CALL_HERO>(stream);
}

MSG_CG_RECALL_HERO msg_MSG_CG_RECALL_HERO;

public object Init_MSG_CG_RECALL_HERO()
{
msg_MSG_CG_RECALL_HERO = new MSG_CG_RECALL_HERO();
return msg_MSG_CG_RECALL_HERO;
}
public object Get_MSG_CG_RECALL_HERO()
{
return msg_MSG_CG_RECALL_HERO;
}
public object New_MSG_CG_RECALL_HERO()
{
return msg_MSG_CG_RECALL_HERO;
}
public void OnResponse_MSG_CG_RECALL_HERO(MemoryStream stream,out string msgName)
{
MSG_CG_RECALL_HERO MSG_CG_RECALL_HERO = MessagePacker.ProtobufHelper.Deserialize<MSG_CG_RECALL_HERO>(stream);
msgName = "MSG_CG_RECALL_HERO";
Parser.Parse(MSG_CG_RECALL_HERO);
}
public object Deserialize_MSG_CG_RECALL_HERO(MemoryStream stream)
{
return  MessagePacker.ProtobufHelper.Deserialize<MSG_CG_RECALL_HERO>(stream);
}

MSG_CG_HERO_LEVEL_UP msg_MSG_CG_HERO_LEVEL_UP;

public object Init_MSG_CG_HERO_LEVEL_UP()
{
msg_MSG_CG_HERO_LEVEL_UP = new MSG_CG_HERO_LEVEL_UP();
return msg_MSG_CG_HERO_LEVEL_UP;
}
public object Get_MSG_CG_HERO_LEVEL_UP()
{
return msg_MSG_CG_HERO_LEVEL_UP;
}
public object New_MSG_CG_HERO_LEVEL_UP()
{
return msg_MSG_CG_HERO_LEVEL_UP;
}
public void OnResponse_MSG_CG_HERO_LEVEL_UP(MemoryStream stream,out string msgName)
{
MSG_CG_HERO_LEVEL_UP MSG_CG_HERO_LEVEL_UP = MessagePacker.ProtobufHelper.Deserialize<MSG_CG_HERO_LEVEL_UP>(stream);
msgName = "MSG_CG_HERO_LEVEL_UP";
Parser.Parse(MSG_CG_HERO_LEVEL_UP);
}
public object Deserialize_MSG_CG_HERO_LEVEL_UP(MemoryStream stream)
{
return  MessagePacker.ProtobufHelper.Deserialize<MSG_CG_HERO_LEVEL_UP>(stream);
}

MSG_CG_HERO_AWAKEN msg_MSG_CG_HERO_AWAKEN;

public object Init_MSG_CG_HERO_AWAKEN()
{
msg_MSG_CG_HERO_AWAKEN = new MSG_CG_HERO_AWAKEN();
return msg_MSG_CG_HERO_AWAKEN;
}
public object Get_MSG_CG_HERO_AWAKEN()
{
return msg_MSG_CG_HERO_AWAKEN;
}
public object New_MSG_CG_HERO_AWAKEN()
{
return msg_MSG_CG_HERO_AWAKEN;
}
public void OnResponse_MSG_CG_HERO_AWAKEN(MemoryStream stream,out string msgName)
{
MSG_CG_HERO_AWAKEN MSG_CG_HERO_AWAKEN = MessagePacker.ProtobufHelper.Deserialize<MSG_CG_HERO_AWAKEN>(stream);
msgName = "MSG_CG_HERO_AWAKEN";
Parser.Parse(MSG_CG_HERO_AWAKEN);
}
public object Deserialize_MSG_CG_HERO_AWAKEN(MemoryStream stream)
{
return  MessagePacker.ProtobufHelper.Deserialize<MSG_CG_HERO_AWAKEN>(stream);
}

MSG_CG_HERO_ABSORB_SOUL_LINK msg_MSG_CG_HERO_ABSORB_SOUL_LINK;

public object Init_MSG_CG_HERO_ABSORB_SOUL_LINK()
{
msg_MSG_CG_HERO_ABSORB_SOUL_LINK = new MSG_CG_HERO_ABSORB_SOUL_LINK();
return msg_MSG_CG_HERO_ABSORB_SOUL_LINK;
}
public object Get_MSG_CG_HERO_ABSORB_SOUL_LINK()
{
return msg_MSG_CG_HERO_ABSORB_SOUL_LINK;
}
public object New_MSG_CG_HERO_ABSORB_SOUL_LINK()
{
return msg_MSG_CG_HERO_ABSORB_SOUL_LINK;
}
public void OnResponse_MSG_CG_HERO_ABSORB_SOUL_LINK(MemoryStream stream,out string msgName)
{
MSG_CG_HERO_ABSORB_SOUL_LINK MSG_CG_HERO_ABSORB_SOUL_LINK = MessagePacker.ProtobufHelper.Deserialize<MSG_CG_HERO_ABSORB_SOUL_LINK>(stream);
msgName = "MSG_CG_HERO_ABSORB_SOUL_LINK";
Parser.Parse(MSG_CG_HERO_ABSORB_SOUL_LINK);
}
public object Deserialize_MSG_CG_HERO_ABSORB_SOUL_LINK(MemoryStream stream)
{
return  MessagePacker.ProtobufHelper.Deserialize<MSG_CG_HERO_ABSORB_SOUL_LINK>(stream);
}

MSG_CG_HERO_CLICK_TALENT msg_MSG_CG_HERO_CLICK_TALENT;

public object Init_MSG_CG_HERO_CLICK_TALENT()
{
msg_MSG_CG_HERO_CLICK_TALENT = new MSG_CG_HERO_CLICK_TALENT();
return msg_MSG_CG_HERO_CLICK_TALENT;
}
public object Get_MSG_CG_HERO_CLICK_TALENT()
{
return msg_MSG_CG_HERO_CLICK_TALENT;
}
public object New_MSG_CG_HERO_CLICK_TALENT()
{
return msg_MSG_CG_HERO_CLICK_TALENT;
}
public void OnResponse_MSG_CG_HERO_CLICK_TALENT(MemoryStream stream,out string msgName)
{
MSG_CG_HERO_CLICK_TALENT MSG_CG_HERO_CLICK_TALENT = MessagePacker.ProtobufHelper.Deserialize<MSG_CG_HERO_CLICK_TALENT>(stream);
msgName = "MSG_CG_HERO_CLICK_TALENT";
Parser.Parse(MSG_CG_HERO_CLICK_TALENT);
}
public object Deserialize_MSG_CG_HERO_CLICK_TALENT(MemoryStream stream)
{
return  MessagePacker.ProtobufHelper.Deserialize<MSG_CG_HERO_CLICK_TALENT>(stream);
}

public void OnResponse_MSG_CB_HEARTBEAT(MemoryStream stream,out string msgName)
{
MSG_CB_HEARTBEAT MSG_CB_HEARTBEAT = MessagePacker.ProtobufHelper.Deserialize<MSG_CB_HEARTBEAT>(stream);
msgName = "MSG_CB_HEARTBEAT";
Parser.Parse(MSG_CB_HEARTBEAT);
}
public object Deserialize_MSG_CB_HEARTBEAT(MemoryStream stream)
{
return  MessagePacker.ProtobufHelper.Deserialize<MSG_CB_HEARTBEAT>(stream);
}

public void OnResponse_MSG_CB_USER_LOGIN(MemoryStream stream,out string msgName)
{
MSG_CB_USER_LOGIN MSG_CB_USER_LOGIN = MessagePacker.ProtobufHelper.Deserialize<MSG_CB_USER_LOGIN>(stream);
msgName = "MSG_CB_USER_LOGIN";
Parser.Parse(MSG_CB_USER_LOGIN);
}
public object Deserialize_MSG_CB_USER_LOGIN(MemoryStream stream)
{
return  MessagePacker.ProtobufHelper.Deserialize<MSG_CB_USER_LOGIN>(stream);
}

public void OnResponse_MSG_CB_LOGIN_SERVERS(MemoryStream stream,out string msgName)
{
MSG_CB_LOGIN_SERVERS MSG_CB_LOGIN_SERVERS = MessagePacker.ProtobufHelper.Deserialize<MSG_CB_LOGIN_SERVERS>(stream);
msgName = "MSG_CB_LOGIN_SERVERS";
Parser.Parse(MSG_CB_LOGIN_SERVERS);
}
public object Deserialize_MSG_CB_LOGIN_SERVERS(MemoryStream stream)
{
return  MessagePacker.ProtobufHelper.Deserialize<MSG_CB_LOGIN_SERVERS>(stream);
}

public void OnResponse_MSG_BC_HEARTBEAT(MemoryStream stream,out string msgName)
{
MSG_BC_HEARTBEAT MSG_BC_HEARTBEAT = MessagePacker.ProtobufHelper.Deserialize<MSG_BC_HEARTBEAT>(stream);
msgName = "MSG_BC_HEARTBEAT";
Parser.Parse(MSG_BC_HEARTBEAT);
}
public object Deserialize_MSG_BC_HEARTBEAT(MemoryStream stream)
{
return  MessagePacker.ProtobufHelper.Deserialize<MSG_BC_HEARTBEAT>(stream);
}

public void OnResponse_MSG_BC_USER_LOGIN(MemoryStream stream,out string msgName)
{
MSG_BC_USER_LOGIN MSG_BC_USER_LOGIN = MessagePacker.ProtobufHelper.Deserialize<MSG_BC_USER_LOGIN>(stream);
msgName = "MSG_BC_USER_LOGIN";
Parser.Parse(MSG_BC_USER_LOGIN);
}
public object Deserialize_MSG_BC_USER_LOGIN(MemoryStream stream)
{
return  MessagePacker.ProtobufHelper.Deserialize<MSG_BC_USER_LOGIN>(stream);
}

public void OnResponse_MSG_BC_LOGIN_SERVERS(MemoryStream stream,out string msgName)
{
MSG_BC_LOGIN_SERVERS MSG_BC_LOGIN_SERVERS = MessagePacker.ProtobufHelper.Deserialize<MSG_BC_LOGIN_SERVERS>(stream);
msgName = "MSG_BC_LOGIN_SERVERS";
Parser.Parse(MSG_BC_LOGIN_SERVERS);
}
public object Deserialize_MSG_BC_LOGIN_SERVERS(MemoryStream stream)
{
return  MessagePacker.ProtobufHelper.Deserialize<MSG_BC_LOGIN_SERVERS>(stream);
}


public object RouteInit(string className)
{
switch (className)
{
case "MSG_CG_CHARACTER_LIST":
return Init_MSG_CG_CHARACTER_LIST();

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

case "MSG_CG_ITEM_BUY":
return Init_MSG_CG_ITEM_BUY();

case "MSG_CG_USE_FIREWORKS":
return Init_MSG_CG_USE_FIREWORKS();

case "MSG_CG_ITEM_ID_NUM":
return Init_MSG_CG_ITEM_ID_NUM();

case "MSG_CG_ITEM_COMPOSE":
return Init_MSG_CG_ITEM_COMPOSE();

case "MSG_CG_ITEM_RESOLVE":
return Init_MSG_CG_ITEM_RESOLVE();

case "MSG_CG_SMELT_SOULBONE":
return Init_MSG_CG_SMELT_SOULBONE();

case "MSG_CG_SOULBONE":
return Init_MSG_CG_SOULBONE();

case "MSG_CG_EQUIP_SOULBONE":
return Init_MSG_CG_EQUIP_SOULBONE();

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

case "MSG_CG_CALL_PET":
return Init_MSG_CG_CALL_PET();

case "MSG_CG_RECALL_PET":
return Init_MSG_CG_RECALL_PET();

case "MSG_CG_CALL_HERO":
return Init_MSG_CG_CALL_HERO();

case "MSG_CG_RECALL_HERO":
return Init_MSG_CG_RECALL_HERO();

case "MSG_CG_HERO_LEVEL_UP":
return Init_MSG_CG_HERO_LEVEL_UP();

case "MSG_CG_HERO_AWAKEN":
return Init_MSG_CG_HERO_AWAKEN();

case "MSG_CG_HERO_ABSORB_SOUL_LINK":
return Init_MSG_CG_HERO_ABSORB_SOUL_LINK();

case "MSG_CG_HERO_CLICK_TALENT":
return Init_MSG_CG_HERO_CLICK_TALENT();


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

case "MSG_CG_ITEM_BUY":
return New_MSG_CG_ITEM_BUY();

case "MSG_CG_USE_FIREWORKS":
return New_MSG_CG_USE_FIREWORKS();

case "MSG_CG_ITEM_ID_NUM":
return New_MSG_CG_ITEM_ID_NUM();

case "MSG_CG_ITEM_COMPOSE":
return New_MSG_CG_ITEM_COMPOSE();

case "MSG_CG_ITEM_RESOLVE":
return New_MSG_CG_ITEM_RESOLVE();

case "MSG_CG_SMELT_SOULBONE":
return New_MSG_CG_SMELT_SOULBONE();

case "MSG_CG_SOULBONE":
return New_MSG_CG_SOULBONE();

case "MSG_CG_EQUIP_SOULBONE":
return New_MSG_CG_EQUIP_SOULBONE();

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

case "MSG_CG_CALL_PET":
return New_MSG_CG_CALL_PET();

case "MSG_CG_RECALL_PET":
return New_MSG_CG_RECALL_PET();

case "MSG_CG_CALL_HERO":
return New_MSG_CG_CALL_HERO();

case "MSG_CG_RECALL_HERO":
return New_MSG_CG_RECALL_HERO();

case "MSG_CG_HERO_LEVEL_UP":
return New_MSG_CG_HERO_LEVEL_UP();

case "MSG_CG_HERO_AWAKEN":
return New_MSG_CG_HERO_AWAKEN();

case "MSG_CG_HERO_ABSORB_SOUL_LINK":
return New_MSG_CG_HERO_ABSORB_SOUL_LINK();

case "MSG_CG_HERO_CLICK_TALENT":
return New_MSG_CG_HERO_CLICK_TALENT();


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

case "MSG_CG_ITEM_BUY":
return Get_MSG_CG_ITEM_BUY();

case "MSG_CG_USE_FIREWORKS":
return Get_MSG_CG_USE_FIREWORKS();

case "MSG_CG_ITEM_ID_NUM":
return Get_MSG_CG_ITEM_ID_NUM();

case "MSG_CG_ITEM_COMPOSE":
return Get_MSG_CG_ITEM_COMPOSE();

case "MSG_CG_ITEM_RESOLVE":
return Get_MSG_CG_ITEM_RESOLVE();

case "MSG_CG_SMELT_SOULBONE":
return Get_MSG_CG_SMELT_SOULBONE();

case "MSG_CG_SOULBONE":
return Get_MSG_CG_SOULBONE();

case "MSG_CG_EQUIP_SOULBONE":
return Get_MSG_CG_EQUIP_SOULBONE();

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

case "MSG_CG_CALL_PET":
return Get_MSG_CG_CALL_PET();

case "MSG_CG_RECALL_PET":
return Get_MSG_CG_RECALL_PET();

case "MSG_CG_CALL_HERO":
return Get_MSG_CG_CALL_HERO();

case "MSG_CG_RECALL_HERO":
return Get_MSG_CG_RECALL_HERO();

case "MSG_CG_HERO_LEVEL_UP":
return Get_MSG_CG_HERO_LEVEL_UP();

case "MSG_CG_HERO_AWAKEN":
return Get_MSG_CG_HERO_AWAKEN();

case "MSG_CG_HERO_ABSORB_SOUL_LINK":
return Get_MSG_CG_HERO_ABSORB_SOUL_LINK();

case "MSG_CG_HERO_CLICK_TALENT":
return Get_MSG_CG_HERO_CLICK_TALENT();


default:
return null;
}
}
public object RouteDeserialize(string className,MemoryStream stream)
{
switch (className)
{
case "MSG_CG_CHARACTER_LIST":
return Deserialize_MSG_CG_CHARACTER_LIST(stream);

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

case "MSG_CG_ITEM_BUY":
return Deserialize_MSG_CG_ITEM_BUY(stream);

case "MSG_CG_USE_FIREWORKS":
return Deserialize_MSG_CG_USE_FIREWORKS(stream);

case "MSG_CG_ITEM_ID_NUM":
return Deserialize_MSG_CG_ITEM_ID_NUM(stream);

case "MSG_CG_ITEM_COMPOSE":
return Deserialize_MSG_CG_ITEM_COMPOSE(stream);

case "MSG_CG_ITEM_RESOLVE":
return Deserialize_MSG_CG_ITEM_RESOLVE(stream);

case "MSG_CG_SMELT_SOULBONE":
return Deserialize_MSG_CG_SMELT_SOULBONE(stream);

case "MSG_CG_SOULBONE":
return Deserialize_MSG_CG_SOULBONE(stream);

case "MSG_CG_EQUIP_SOULBONE":
return Deserialize_MSG_CG_EQUIP_SOULBONE(stream);

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

case "MSG_CG_CALL_PET":
return Deserialize_MSG_CG_CALL_PET(stream);

case "MSG_CG_RECALL_PET":
return Deserialize_MSG_CG_RECALL_PET(stream);

case "MSG_CG_CALL_HERO":
return Deserialize_MSG_CG_CALL_HERO(stream);

case "MSG_CG_RECALL_HERO":
return Deserialize_MSG_CG_RECALL_HERO(stream);

case "MSG_CG_HERO_LEVEL_UP":
return Deserialize_MSG_CG_HERO_LEVEL_UP(stream);

case "MSG_CG_HERO_AWAKEN":
return Deserialize_MSG_CG_HERO_AWAKEN(stream);

case "MSG_CG_HERO_ABSORB_SOUL_LINK":
return Deserialize_MSG_CG_HERO_ABSORB_SOUL_LINK(stream);

case "MSG_CG_HERO_CLICK_TALENT":
return Deserialize_MSG_CG_HERO_CLICK_TALENT(stream);


default:
return null;
}
}
public void BindParser()
{
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

Parser.AddResponser_Msg(Id<MSG_GC_INSTANCES_REMOVE>.Value, OnResponse_MSG_GC_INSTANCES_REMOVE);

Parser.AddResponser_Msg(Id<MSG_ZGC_PET_SIMPLE_INFO>.Value, OnResponse_MSG_ZGC_PET_SIMPLE_INFO);

Parser.AddResponser_Msg(Id<MSG_GC_PET_ENTER_LIST>.Value, OnResponse_MSG_GC_PET_ENTER_LIST);

Parser.AddResponser_Msg(Id<MSG_ZGC_PET_LEAVE>.Value, OnResponse_MSG_ZGC_PET_LEAVE);

Parser.AddResponser_Msg(Id<MSG_ZGC_NPC_MOVE>.Value, OnResponse_MSG_ZGC_NPC_MOVE);

Parser.AddResponser_Msg(Id<MSG_ZGC_NPC_LEAVE>.Value, OnResponse_MSG_ZGC_NPC_LEAVE);

Parser.AddResponser_Msg(Id<MSG_ZGC_NPC_SIMPLE_INFO>.Value, OnResponse_MSG_ZGC_NPC_SIMPLE_INFO);

Parser.AddResponser_Msg(Id<MSG_GC_NPC_ENTER_LIST>.Value, OnResponse_MSG_GC_NPC_ENTER_LIST);

Parser.AddResponser_Msg(Id<MSG_ZGC_MONSTER_SIMPLE_INFO>.Value, OnResponse_MSG_ZGC_MONSTER_SIMPLE_INFO);

Parser.AddResponser_Msg(Id<MSG_ZGC_MONSTER_INFO>.Value, OnResponse_MSG_ZGC_MONSTER_INFO);

Parser.AddResponser_Msg(Id<MSG_ZGC_MONSTER_LEAVE>.Value, OnResponse_MSG_ZGC_MONSTER_LEAVE);

Parser.AddResponser_Msg(Id<MSG_GC_MONSTER_ENTER_LIST>.Value, OnResponse_MSG_GC_MONSTER_ENTER_LIST);

Parser.AddResponser_Msg(Id<MSG_ZGC_CHARACTER_HP>.Value, OnResponse_MSG_ZGC_CHARACTER_HP);

Parser.AddResponser_Msg(Id<MSG_ZGC_HERO_SIMPLE_INFO>.Value, OnResponse_MSG_ZGC_HERO_SIMPLE_INFO);

Parser.AddResponser_Msg(Id<MSG_GC_HERO_ENTER_LIST>.Value, OnResponse_MSG_GC_HERO_ENTER_LIST);

Parser.AddResponser_Msg(Id<MSG_ZGC_HERO_LEAVE>.Value, OnResponse_MSG_ZGC_HERO_LEAVE);

Parser.AddResponser_Msg(Id<MSG_ZGC_SYNC_CURRENCIES>.Value, OnResponse_MSG_ZGC_SYNC_CURRENCIES);

Parser.AddResponser_Msg(Id<MSG_ZGC_COUNTER_INFO>.Value, OnResponse_MSG_ZGC_COUNTER_INFO);

Parser.AddResponser_Msg(Id<MSG_ZGC_PLAYER_LEVEL>.Value, OnResponse_MSG_ZGC_PLAYER_LEVEL);

Parser.AddResponser_Msg(Id<MSG_ZGC_BAG_SYNC>.Value, OnResponse_MSG_ZGC_BAG_SYNC);

Parser.AddResponser_Msg(Id<MSG_ZGC_BAG_UPDATE>.Value, OnResponse_MSG_ZGC_BAG_UPDATE);

Parser.AddResponser_Msg(Id<MSG_ZGC_BAG_DILATATION>.Value, OnResponse_MSG_ZGC_BAG_DILATATION);

Parser.AddResponser_Msg(Id<MSG_ZGC_ITEM_USE>.Value, OnResponse_MSG_ZGC_ITEM_USE);

Parser.AddResponser_Msg(Id<MSG_ZGC_ITEM_SELL>.Value, OnResponse_MSG_ZGC_ITEM_SELL);

Parser.AddResponser_Msg(Id<MSG_ZGC_EQUIP_FACEFRAME>.Value, OnResponse_MSG_ZGC_EQUIP_FACEFRAME);

Parser.AddResponser_Msg(Id<MSG_ZGC_ITEM_BUY>.Value, OnResponse_MSG_ZGC_ITEM_BUY);

Parser.AddResponser_Msg(Id<MSG_ZGC_USE_FIREWORKS>.Value, OnResponse_MSG_ZGC_USE_FIREWORKS);

Parser.AddResponser_Msg(Id<MSG_ZGC_ITEM_COMPOSE>.Value, OnResponse_MSG_ZGC_ITEM_COMPOSE);

Parser.AddResponser_Msg(Id<MSG_ZGC_ITEM_RESOLVE>.Value, OnResponse_MSG_ZGC_ITEM_RESOLVE);

Parser.AddResponser_Msg(Id<MSG_ZGC_SOUL_BONE_ITEM>.Value, OnResponse_MSG_ZGC_SOUL_BONE_ITEM);

Parser.AddResponser_Msg(Id<MSG_ZGC_SOULBONE_SMELT_RESULT>.Value, OnResponse_MSG_ZGC_SOULBONE_SMELT_RESULT);

Parser.AddResponser_Msg(Id<MSG_ZGC_EQUIP_SOULBONE_RESULT>.Value, OnResponse_MSG_ZGC_EQUIP_SOULBONE_RESULT);

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

Parser.AddResponser_Msg(Id<MSG_ZGC_FRIEND_SEARCH>.Value, OnResponse_MSG_ZGC_FRIEND_SEARCH);

Parser.AddResponser_Msg(Id<MSG_ZGC_FRIEND_ADD_REQUEST>.Value, OnResponse_MSG_ZGC_FRIEND_ADD_REQUEST);

Parser.AddResponser_Msg(Id<MSG_ZGC_FRIEND_ADD_RESPONSE>.Value, OnResponse_MSG_ZGC_FRIEND_ADD_RESPONSE);

Parser.AddResponser_Msg(Id<MSG_ZGC_FRIEND_DELETE>.Value, OnResponse_MSG_ZGC_FRIEND_DELETE);

Parser.AddResponser_Msg(Id<MSG_ZGC_FRIEND_LIST>.Value, OnResponse_MSG_ZGC_FRIEND_LIST);

Parser.AddResponser_Msg(Id<MSG_ZGC_FRIEND_REQUEST_LIST>.Value, OnResponse_MSG_ZGC_FRIEND_REQUEST_LIST);

Parser.AddResponser_Msg(Id<MSG_ZGC_FRIEND_RECENT_LIST>.Value, OnResponse_MSG_ZGC_FRIEND_RECENT_LIST);

Parser.AddResponser_Msg(Id<MSG_ZGC_FRIEND_BLACK_LIST>.Value, OnResponse_MSG_ZGC_FRIEND_BLACK_LIST);

Parser.AddResponser_Msg(Id<MSG_ZGC_FRIEND_BLACK_ADD>.Value, OnResponse_MSG_ZGC_FRIEND_BLACK_ADD);

Parser.AddResponser_Msg(Id<MSG_ZGC_FRIEND_BLACK_DEL>.Value, OnResponse_MSG_ZGC_FRIEND_BLACK_DEL);

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

Parser.AddResponser_Msg(Id<MSG_ZGC_POP_RANK>.Value, OnResponse_MSG_ZGC_POP_RANK);

Parser.AddResponser_Msg(Id<MSG_ZGC_RADIO_ALL_ANCHOR_RANK>.Value, OnResponse_MSG_ZGC_RADIO_ALL_ANCHOR_RANK);

Parser.AddResponser_Msg(Id<MSG_ZGC_RADIO_ANCHOR_CONTRIBUTION_RANK>.Value, OnResponse_MSG_ZGC_RADIO_ANCHOR_CONTRIBUTION_RANK);

Parser.AddResponser_Msg(Id<MSG_ZGC_RADIO_ALL_CONTRIBUTION_RANK>.Value, OnResponse_MSG_ZGC_RADIO_ALL_CONTRIBUTION_RANK);

Parser.AddResponser_Msg(Id<MSG_ZGC_RADIO_CONTRIBUTION_REWARD>.Value, OnResponse_MSG_ZGC_RADIO_CONTRIBUTION_REWARD);

Parser.AddResponser_Msg(Id<MSG_ZGC_RADIO_GIFT>.Value, OnResponse_MSG_ZGC_RADIO_GIFT);

Parser.AddResponser_Msg(Id<MSG_ZGC_ANCHOR_INFO>.Value, OnResponse_MSG_ZGC_ANCHOR_INFO);

Parser.AddResponser_Msg(Id<MSG_ZGC_DAMAGE>.Value, OnResponse_MSG_ZGC_DAMAGE);

Parser.AddResponser_Msg(Id<MSG_ZGC_CAST_SKILL>.Value, OnResponse_MSG_ZGC_CAST_SKILL);

Parser.AddResponser_Msg(Id<MSG_ZGC_CALL_PET>.Value, OnResponse_MSG_ZGC_CALL_PET);

Parser.AddResponser_Msg(Id<MSG_ZGC_RECALL_PET>.Value, OnResponse_MSG_ZGC_RECALL_PET);

Parser.AddResponser_Msg(Id<MSG_ZGC_CALL_HERO>.Value, OnResponse_MSG_ZGC_CALL_HERO);

Parser.AddResponser_Msg(Id<MSG_ZGC_RECALL_HERO>.Value, OnResponse_MSG_ZGC_RECALL_HERO);

Parser.AddResponser_Msg(Id<MSG_ZGC_HERO_LIST>.Value, OnResponse_MSG_ZGC_HERO_LIST);

Parser.AddResponser_Msg(Id<MSG_ZGC_HERO_INFO>.Value, OnResponse_MSG_ZGC_HERO_INFO);

Parser.AddResponser_Msg(Id<MSG_ZGC_HERO_CHANGE>.Value, OnResponse_MSG_ZGC_HERO_CHANGE);

Parser.AddResponser_Msg(Id<MSG_ZGC_HERO_TALENT>.Value, OnResponse_MSG_ZGC_HERO_TALENT);

Parser.AddResponser_Msg(Id<MSG_ZGC_HERO_LEVEL_UP>.Value, OnResponse_MSG_ZGC_HERO_LEVEL_UP);

Parser.AddResponser_Msg(Id<MSG_ZGC_HERO_AWAKEN>.Value, OnResponse_MSG_ZGC_HERO_AWAKEN);

Parser.AddResponser_Msg(Id<MSG_ZGC_HERO_ABSORB_SOUL_LINK>.Value, OnResponse_MSG_ZGC_HERO_ABSORB_SOUL_LINK);

Parser.AddResponser_Msg(Id<MSG_CG_CHARACTER_LIST>.Value, OnResponse_MSG_CG_CHARACTER_LIST);

Parser.AddResponser_Msg(Id<MSG_CG_CREATE_CHARACTER>.Value, OnResponse_MSG_CG_CREATE_CHARACTER);

Parser.AddResponser_Msg(Id<MSG_CG_TO_ZONE>.Value, OnResponse_MSG_CG_TO_ZONE);

Parser.AddResponser_Msg(Id<MSG_CG_MAP_LOADING_DONE>.Value, OnResponse_MSG_CG_MAP_LOADING_DONE);

Parser.AddResponser_Msg(Id<MSG_CG_HEARTBEAT>.Value, OnResponse_MSG_CG_HEARTBEAT);

Parser.AddResponser_Msg(Id<MSG_CG_SHIP_STEP>.Value, OnResponse_MSG_CG_SHIP_STEP);

Parser.AddResponser_Msg(Id<MSG_CG_CHARACTER_MOVE>.Value, OnResponse_MSG_CG_CHARACTER_MOVE);

Parser.AddResponser_Msg(Id<MSG_CG_MOVE_ZONE>.Value, OnResponse_MSG_CG_MOVE_ZONE);

Parser.AddResponser_Msg(Id<MSG_CG_AUTOPATHFINDING>.Value, OnResponse_MSG_CG_AUTOPATHFINDING);

Parser.AddResponser_Msg(Id<MSG_CG_GEOGRAPHY>.Value, OnResponse_MSG_CG_GEOGRAPHY);

Parser.AddResponser_Msg(Id<MSG_CG_RECONNECT_LOGIN>.Value, OnResponse_MSG_CG_RECONNECT_LOGIN);

Parser.AddResponser_Msg(Id<MSG_CG_CROSS_PORTAL>.Value, OnResponse_MSG_CG_CROSS_PORTAL);

Parser.AddResponser_Msg(Id<MSG_CG_GET_BLOWFISHKEY>.Value, OnResponse_MSG_CG_GET_BLOWFISHKEY);

Parser.AddResponser_Msg(Id<MSG_CG_SUGGEST>.Value, OnResponse_MSG_CG_SUGGEST);

Parser.AddResponser_Msg(Id<MSG_CG_LOGOUT>.Value, OnResponse_MSG_CG_LOGOUT);

Parser.AddResponser_Msg(Id<MSG_CG_SAVE_GUIDE_ID>.Value, OnResponse_MSG_CG_SAVE_GUIDE_ID);

Parser.AddResponser_Msg(Id<MSG_CG_SAVE_MAIN_LINE_ID>.Value, OnResponse_MSG_CG_SAVE_MAIN_LINE_ID);

Parser.AddResponser_Msg(Id<MSG_CG_SAVE_GAME_COMMENT>.Value, OnResponse_MSG_CG_SAVE_GAME_COMMENT);

Parser.AddResponser_Msg(Id<MSG_CG_CHANGE_CHANNEL>.Value, OnResponse_MSG_CG_CHANGE_CHANNEL);

Parser.AddResponser_Msg(Id<MSG_CG_ITEM_USE>.Value, OnResponse_MSG_CG_ITEM_USE);

Parser.AddResponser_Msg(Id<MSG_CG_ITEM_SELL>.Value, OnResponse_MSG_CG_ITEM_SELL);

Parser.AddResponser_Msg(Id<MSG_CG_ITEM_BUY>.Value, OnResponse_MSG_CG_ITEM_BUY);

Parser.AddResponser_Msg(Id<MSG_CG_USE_FIREWORKS>.Value, OnResponse_MSG_CG_USE_FIREWORKS);

Parser.AddResponser_Msg(Id<MSG_CG_ITEM_ID_NUM>.Value, OnResponse_MSG_CG_ITEM_ID_NUM);

Parser.AddResponser_Msg(Id<MSG_CG_ITEM_COMPOSE>.Value, OnResponse_MSG_CG_ITEM_COMPOSE);

Parser.AddResponser_Msg(Id<MSG_CG_ITEM_RESOLVE>.Value, OnResponse_MSG_CG_ITEM_RESOLVE);

Parser.AddResponser_Msg(Id<MSG_CG_SMELT_SOULBONE>.Value, OnResponse_MSG_CG_SMELT_SOULBONE);

Parser.AddResponser_Msg(Id<MSG_CG_SOULBONE>.Value, OnResponse_MSG_CG_SOULBONE);

Parser.AddResponser_Msg(Id<MSG_CG_EQUIP_SOULBONE>.Value, OnResponse_MSG_CG_EQUIP_SOULBONE);

Parser.AddResponser_Msg(Id<MSG_CG_EMAIL_READ>.Value, OnResponse_MSG_CG_EMAIL_READ);

Parser.AddResponser_Msg(Id<MSG_CG_PICKUP_ATTACHMENT>.Value, OnResponse_MSG_CG_PICKUP_ATTACHMENT);

Parser.AddResponser_Msg(Id<MSG_CG_EMAIL_OPENE_BOX>.Value, OnResponse_MSG_CG_EMAIL_OPENE_BOX);

Parser.AddResponser_Msg(Id<MSG_CG_SHOP_BUY_ITEM>.Value, OnResponse_MSG_CG_SHOP_BUY_ITEM);

Parser.AddResponser_Msg(Id<MSG_CG_SHOP_GET_SSR>.Value, OnResponse_MSG_CG_SHOP_GET_SSR);

Parser.AddResponser_Msg(Id<MSG_CG_REFRESH_SHOP_ITEM>.Value, OnResponse_MSG_CG_REFRESH_SHOP_ITEM);

Parser.AddResponser_Msg(Id<MSG_CG_CONVERT_FISH_COIN>.Value, OnResponse_MSG_CG_CONVERT_FISH_COIN);

Parser.AddResponser_Msg(Id<MSG_CG_SAVE_ORDER>.Value, OnResponse_MSG_CG_SAVE_ORDER);

Parser.AddResponser_Msg(Id<MSG_CG_GET_RECHARGE_HISTORY>.Value, OnResponse_MSG_CG_GET_RECHARGE_HISTORY);

Parser.AddResponser_Msg(Id<MSG_CG_DELETE_RECHARGE_HISTORY>.Value, OnResponse_MSG_CG_DELETE_RECHARGE_HISTORY);

Parser.AddResponser_Msg(Id<MSG_CG_FRIEND_SEARCH>.Value, OnResponse_MSG_CG_FRIEND_SEARCH);

Parser.AddResponser_Msg(Id<MSG_CG_FRIEND_ADD_REQUEST>.Value, OnResponse_MSG_CG_FRIEND_ADD_REQUEST);

Parser.AddResponser_Msg(Id<MSG_CG_FRIEND_ADD_RESPONSE>.Value, OnResponse_MSG_CG_FRIEND_ADD_RESPONSE);

Parser.AddResponser_Msg(Id<MSG_CG_FRIEND_DELETE>.Value, OnResponse_MSG_CG_FRIEND_DELETE);

Parser.AddResponser_Msg(Id<MSG_CG_FRIEND_REQUEST_LIST>.Value, OnResponse_MSG_CG_FRIEND_REQUEST_LIST);

Parser.AddResponser_Msg(Id<MSG_CG_FRIEND_RECENT_LIST>.Value, OnResponse_MSG_CG_FRIEND_RECENT_LIST);

Parser.AddResponser_Msg(Id<MSG_CG_FRIEND_BLACK_LIST>.Value, OnResponse_MSG_CG_FRIEND_BLACK_LIST);

Parser.AddResponser_Msg(Id<MSG_CG_FRIEND_LIST>.Value, OnResponse_MSG_CG_FRIEND_LIST);

Parser.AddResponser_Msg(Id<MSG_CG_FRIEND_BLACK_ADD>.Value, OnResponse_MSG_CG_FRIEND_BLACK_ADD);

Parser.AddResponser_Msg(Id<MSG_CG_FRIEND_BLACK_DEL>.Value, OnResponse_MSG_CG_FRIEND_BLACK_DEL);

Parser.AddResponser_Msg(Id<MSG_CG_FRIEND_RECOMMEND>.Value, OnResponse_MSG_CG_FRIEND_RECOMMEND);

Parser.AddResponser_Msg(Id<MSG_CG_CREATE_GUILD>.Value, OnResponse_MSG_CG_CREATE_GUILD);

Parser.AddResponser_Msg(Id<MSG_CG_CHAT_EMOJI>.Value, OnResponse_MSG_CG_CHAT_EMOJI);

Parser.AddResponser_Msg(Id<MSG_CG_CHAT_WORDS>.Value, OnResponse_MSG_CG_CHAT_WORDS);

Parser.AddResponser_Msg(Id<MSG_CG_CHANGE_WORLD_ROOM>.Value, OnResponse_MSG_CG_CHANGE_WORLD_ROOM);

Parser.AddResponser_Msg(Id<MSG_CG_GET_WORLD_ROOM_LIST>.Value, OnResponse_MSG_CG_GET_WORLD_ROOM_LIST);

Parser.AddResponser_Msg(Id<MSG_CG_CHAT_TRUMPET>.Value, OnResponse_MSG_CG_CHAT_TRUMPET);

Parser.AddResponser_Msg(Id<MSG_CG_CHAT_REPORT>.Value, OnResponse_MSG_CG_CHAT_REPORT);

Parser.AddResponser_Msg(Id<MSG_CG_NEARBY_EMOJI>.Value, OnResponse_MSG_CG_NEARBY_EMOJI);

Parser.AddResponser_Msg(Id<MSG_CG_TIP_OFF>.Value, OnResponse_MSG_CG_TIP_OFF);

Parser.AddResponser_Msg(Id<MSG_CG_ACTIVITY_CHAT_BUBBLE>.Value, OnResponse_MSG_CG_ACTIVITY_CHAT_BUBBLE);

Parser.AddResponser_Msg(Id<MSG_CG_USE_CHAT_TRUMPET>.Value, OnResponse_MSG_CG_USE_CHAT_TRUMPET);

Parser.AddResponser_Msg(Id<MSG_CG_TASK_COMPLETE>.Value, OnResponse_MSG_CG_TASK_COMPLETE);

Parser.AddResponser_Msg(Id<MSG_CG_OPENE_EMAIL_TASK>.Value, OnResponse_MSG_CG_OPENE_EMAIL_TASK);

Parser.AddResponser_Msg(Id<MSG_CG_TASK_COLLECT>.Value, OnResponse_MSG_CG_TASK_COLLECT);

Parser.AddResponser_Msg(Id<MSG_CG_TASK_SELECT>.Value, OnResponse_MSG_CG_TASK_SELECT);

Parser.AddResponser_Msg(Id<MSG_CG_TASK_MAKE>.Value, OnResponse_MSG_CG_TASK_MAKE);

Parser.AddResponser_Msg(Id<MSG_CG_TASKFLY_FLY_DONE>.Value, OnResponse_MSG_CG_TASKFLY_FLY_DONE);

Parser.AddResponser_Msg(Id<MSG_CG_TASKFLY_STARTPATHFINDING>.Value, OnResponse_MSG_CG_TASKFLY_STARTPATHFINDING);

Parser.AddResponser_Msg(Id<MSG_CG_ACTIVITY_COMPLETE>.Value, OnResponse_MSG_CG_ACTIVITY_COMPLETE);

Parser.AddResponser_Msg(Id<MSG_CG_SHOW_CHARACTER>.Value, OnResponse_MSG_CG_SHOW_CHARACTER);

Parser.AddResponser_Msg(Id<MSG_CG_CHANGE_NAME>.Value, OnResponse_MSG_CG_CHANGE_NAME);

Parser.AddResponser_Msg(Id<MSG_CG_SHOW_FACEICON>.Value, OnResponse_MSG_CG_SHOW_FACEICON);

Parser.AddResponser_Msg(Id<MSG_CG_SHOW_FACEJPG>.Value, OnResponse_MSG_CG_SHOW_FACEJPG);

Parser.AddResponser_Msg(Id<MSG_CG_SET_SEX>.Value, OnResponse_MSG_CG_SET_SEX);

Parser.AddResponser_Msg(Id<MSG_CG_SET_BIRTHDAY>.Value, OnResponse_MSG_CG_SET_BIRTHDAY);

Parser.AddResponser_Msg(Id<MSG_CG_SET_SIGNATURE>.Value, OnResponse_MSG_CG_SET_SIGNATURE);

Parser.AddResponser_Msg(Id<MSG_CG_SHOW_VOICE>.Value, OnResponse_MSG_CG_SHOW_VOICE);

Parser.AddResponser_Msg(Id<MSG_CG_PRESENT_GIFT>.Value, OnResponse_MSG_CG_PRESENT_GIFT);

Parser.AddResponser_Msg(Id<MSG_CG_GET_GIFTRECORD>.Value, OnResponse_MSG_CG_GET_GIFTRECORD);

Parser.AddResponser_Msg(Id<MSG_CG_SET_SOCIAL_NUM>.Value, OnResponse_MSG_CG_SET_SOCIAL_NUM);

Parser.AddResponser_Msg(Id<MSG_CG_GET_SOCIAL_NUM>.Value, OnResponse_MSG_CG_GET_SOCIAL_NUM);

Parser.AddResponser_Msg(Id<MSG_CG_SHOW_CAREER>.Value, OnResponse_MSG_CG_SHOW_CAREER);

Parser.AddResponser_Msg(Id<MSG_CG_GET_RANKING_FRIEND_LIST>.Value, OnResponse_MSG_CG_GET_RANKING_FRIEND_LIST);

Parser.AddResponser_Msg(Id<MSG_CG_GET_RANKING_ALL_LIST>.Value, OnResponse_MSG_CG_GET_RANKING_ALL_LIST);

Parser.AddResponser_Msg(Id<MSG_CG_GET_RANKING_NEARBY_LIST>.Value, OnResponse_MSG_CG_GET_RANKING_NEARBY_LIST);

Parser.AddResponser_Msg(Id<MSG_CG_CHANGE_TITLE>.Value, OnResponse_MSG_CG_CHANGE_TITLE);

Parser.AddResponser_Msg(Id<MSG_CG_UPLOAD_PHOTO>.Value, OnResponse_MSG_CG_UPLOAD_PHOTO);

Parser.AddResponser_Msg(Id<MSG_CG_REMOVE_PHOTO>.Value, OnResponse_MSG_CG_REMOVE_PHOTO);

Parser.AddResponser_Msg(Id<MSG_CG_PHOTO_LIST>.Value, OnResponse_MSG_CG_PHOTO_LIST);

Parser.AddResponser_Msg(Id<MSG_CG_POP_RANK>.Value, OnResponse_MSG_CG_POP_RANK);

Parser.AddResponser_Msg(Id<MSG_CG_QUESTION>.Value, OnResponse_MSG_CG_QUESTION);

Parser.AddResponser_Msg(Id<MSG_CG_QUESTIONNAIRE>.Value, OnResponse_MSG_CG_QUESTIONNAIRE);

Parser.AddResponser_Msg(Id<MSG_CG_DAILY_QUESTION_COUNTER>.Value, OnResponse_MSG_CG_DAILY_QUESTION_COUNTER);

Parser.AddResponser_Msg(Id<MSG_CG_DAILY_QUESTION_REWARD>.Value, OnResponse_MSG_CG_DAILY_QUESTION_REWARD);

Parser.AddResponser_Msg(Id<MSG_CG_RADIO_GET_ALL_ANCHOR_RANK>.Value, OnResponse_MSG_CG_RADIO_GET_ALL_ANCHOR_RANK);

Parser.AddResponser_Msg(Id<MSG_CG_RADIO_GET_ANCHOR_CONTRIBUTION_RANK>.Value, OnResponse_MSG_CG_RADIO_GET_ANCHOR_CONTRIBUTION_RANK);

Parser.AddResponser_Msg(Id<MSG_CG_RADIO_GET_ALL_CONTRIBUTION_RANK>.Value, OnResponse_MSG_CG_RADIO_GET_ALL_CONTRIBUTION_RANK);

Parser.AddResponser_Msg(Id<MSG_CG_RADIO_GET_CONTRIBUTION_REWARD>.Value, OnResponse_MSG_CG_RADIO_GET_CONTRIBUTION_REWARD);

Parser.AddResponser_Msg(Id<MSG_CG_RADIO_GIVE_GIFT>.Value, OnResponse_MSG_CG_RADIO_GIVE_GIFT);

Parser.AddResponser_Msg(Id<MSG_CG_RADIO_ENTER>.Value, OnResponse_MSG_CG_RADIO_ENTER);

Parser.AddResponser_Msg(Id<MSG_CG_RADIO_LEAVE>.Value, OnResponse_MSG_CG_RADIO_LEAVE);

Parser.AddResponser_Msg(Id<MSG_CG_CALL_PET>.Value, OnResponse_MSG_CG_CALL_PET);

Parser.AddResponser_Msg(Id<MSG_CG_RECALL_PET>.Value, OnResponse_MSG_CG_RECALL_PET);

Parser.AddResponser_Msg(Id<MSG_CG_CALL_HERO>.Value, OnResponse_MSG_CG_CALL_HERO);

Parser.AddResponser_Msg(Id<MSG_CG_RECALL_HERO>.Value, OnResponse_MSG_CG_RECALL_HERO);

Parser.AddResponser_Msg(Id<MSG_CG_HERO_LEVEL_UP>.Value, OnResponse_MSG_CG_HERO_LEVEL_UP);

Parser.AddResponser_Msg(Id<MSG_CG_HERO_AWAKEN>.Value, OnResponse_MSG_CG_HERO_AWAKEN);

Parser.AddResponser_Msg(Id<MSG_CG_HERO_ABSORB_SOUL_LINK>.Value, OnResponse_MSG_CG_HERO_ABSORB_SOUL_LINK);

Parser.AddResponser_Msg(Id<MSG_CG_HERO_CLICK_TALENT>.Value, OnResponse_MSG_CG_HERO_CLICK_TALENT);

Parser.AddResponser_Msg(Id<MSG_CB_HEARTBEAT>.Value, OnResponse_MSG_CB_HEARTBEAT);

Parser.AddResponser_Msg(Id<MSG_CB_USER_LOGIN>.Value, OnResponse_MSG_CB_USER_LOGIN);

Parser.AddResponser_Msg(Id<MSG_CB_LOGIN_SERVERS>.Value, OnResponse_MSG_CB_LOGIN_SERVERS);

Parser.AddResponser_Msg(Id<MSG_BC_HEARTBEAT>.Value, OnResponse_MSG_BC_HEARTBEAT);

Parser.AddResponser_Msg(Id<MSG_BC_USER_LOGIN>.Value, OnResponse_MSG_BC_USER_LOGIN);

Parser.AddResponser_Msg(Id<MSG_BC_LOGIN_SERVERS>.Value, OnResponse_MSG_BC_LOGIN_SERVERS);


}
public bool RouteSend(SendMethodInterface sendHandler,string className,object msg)
{
switch (className)
{
case "MSG_CG_CHARACTER_LIST":
return sendHandler.Send((MSG_CG_CHARACTER_LIST)msg);

case "MSG_CG_CREATE_CHARACTER":
return sendHandler.Send((MSG_CG_CREATE_CHARACTER)msg);

case "MSG_CG_TO_ZONE":
return sendHandler.Send((MSG_CG_TO_ZONE)msg);

case "MSG_CG_MAP_LOADING_DONE":
return sendHandler.Send((MSG_CG_MAP_LOADING_DONE)msg);

case "MSG_CG_HEARTBEAT":
return sendHandler.Send((MSG_CG_HEARTBEAT)msg);

case "MSG_CG_SHIP_STEP":
return sendHandler.Send((MSG_CG_SHIP_STEP)msg);

case "MSG_CG_CHARACTER_MOVE":
return sendHandler.Send((MSG_CG_CHARACTER_MOVE)msg);

case "MSG_CG_MOVE_ZONE":
return sendHandler.Send((MSG_CG_MOVE_ZONE)msg);

case "MSG_CG_AUTOPATHFINDING":
return sendHandler.Send((MSG_CG_AUTOPATHFINDING)msg);

case "MSG_CG_GEOGRAPHY":
return sendHandler.Send((MSG_CG_GEOGRAPHY)msg);

case "MSG_CG_RECONNECT_LOGIN":
return sendHandler.Send((MSG_CG_RECONNECT_LOGIN)msg);

case "MSG_CG_CROSS_PORTAL":
return sendHandler.Send((MSG_CG_CROSS_PORTAL)msg);

case "MSG_CG_GET_BLOWFISHKEY":
return sendHandler.Send((MSG_CG_GET_BLOWFISHKEY)msg);

case "MSG_CG_SUGGEST":
return sendHandler.Send((MSG_CG_SUGGEST)msg);

case "MSG_CG_LOGOUT":
return sendHandler.Send((MSG_CG_LOGOUT)msg);

case "MSG_CG_SAVE_GUIDE_ID":
return sendHandler.Send((MSG_CG_SAVE_GUIDE_ID)msg);

case "MSG_CG_SAVE_MAIN_LINE_ID":
return sendHandler.Send((MSG_CG_SAVE_MAIN_LINE_ID)msg);

case "MSG_CG_SAVE_GAME_COMMENT":
return sendHandler.Send((MSG_CG_SAVE_GAME_COMMENT)msg);

case "MSG_CG_CHANGE_CHANNEL":
return sendHandler.Send((MSG_CG_CHANGE_CHANNEL)msg);

case "MSG_CG_ITEM_USE":
return sendHandler.Send((MSG_CG_ITEM_USE)msg);

case "MSG_CG_ITEM_SELL":
return sendHandler.Send((MSG_CG_ITEM_SELL)msg);

case "MSG_CG_ITEM_BUY":
return sendHandler.Send((MSG_CG_ITEM_BUY)msg);

case "MSG_CG_USE_FIREWORKS":
return sendHandler.Send((MSG_CG_USE_FIREWORKS)msg);

case "MSG_CG_ITEM_ID_NUM":
return sendHandler.Send((MSG_CG_ITEM_ID_NUM)msg);

case "MSG_CG_ITEM_COMPOSE":
return sendHandler.Send((MSG_CG_ITEM_COMPOSE)msg);

case "MSG_CG_ITEM_RESOLVE":
return sendHandler.Send((MSG_CG_ITEM_RESOLVE)msg);

case "MSG_CG_SMELT_SOULBONE":
return sendHandler.Send((MSG_CG_SMELT_SOULBONE)msg);

case "MSG_CG_SOULBONE":
return sendHandler.Send((MSG_CG_SOULBONE)msg);

case "MSG_CG_EQUIP_SOULBONE":
return sendHandler.Send((MSG_CG_EQUIP_SOULBONE)msg);

case "MSG_CG_EMAIL_READ":
return sendHandler.Send((MSG_CG_EMAIL_READ)msg);

case "MSG_CG_PICKUP_ATTACHMENT":
return sendHandler.Send((MSG_CG_PICKUP_ATTACHMENT)msg);

case "MSG_CG_EMAIL_OPENE_BOX":
return sendHandler.Send((MSG_CG_EMAIL_OPENE_BOX)msg);

case "MSG_CG_SHOP_BUY_ITEM":
return sendHandler.Send((MSG_CG_SHOP_BUY_ITEM)msg);

case "MSG_CG_SHOP_GET_SSR":
return sendHandler.Send((MSG_CG_SHOP_GET_SSR)msg);

case "MSG_CG_REFRESH_SHOP_ITEM":
return sendHandler.Send((MSG_CG_REFRESH_SHOP_ITEM)msg);

case "MSG_CG_CONVERT_FISH_COIN":
return sendHandler.Send((MSG_CG_CONVERT_FISH_COIN)msg);

case "MSG_CG_SAVE_ORDER":
return sendHandler.Send((MSG_CG_SAVE_ORDER)msg);

case "MSG_CG_GET_RECHARGE_HISTORY":
return sendHandler.Send((MSG_CG_GET_RECHARGE_HISTORY)msg);

case "MSG_CG_DELETE_RECHARGE_HISTORY":
return sendHandler.Send((MSG_CG_DELETE_RECHARGE_HISTORY)msg);

case "MSG_CG_FRIEND_SEARCH":
return sendHandler.Send((MSG_CG_FRIEND_SEARCH)msg);

case "MSG_CG_FRIEND_ADD_REQUEST":
return sendHandler.Send((MSG_CG_FRIEND_ADD_REQUEST)msg);

case "MSG_CG_FRIEND_ADD_RESPONSE":
return sendHandler.Send((MSG_CG_FRIEND_ADD_RESPONSE)msg);

case "MSG_CG_FRIEND_DELETE":
return sendHandler.Send((MSG_CG_FRIEND_DELETE)msg);

case "MSG_CG_FRIEND_REQUEST_LIST":
return sendHandler.Send((MSG_CG_FRIEND_REQUEST_LIST)msg);

case "MSG_CG_FRIEND_RECENT_LIST":
return sendHandler.Send((MSG_CG_FRIEND_RECENT_LIST)msg);

case "MSG_CG_FRIEND_BLACK_LIST":
return sendHandler.Send((MSG_CG_FRIEND_BLACK_LIST)msg);

case "MSG_CG_FRIEND_LIST":
return sendHandler.Send((MSG_CG_FRIEND_LIST)msg);

case "MSG_CG_FRIEND_BLACK_ADD":
return sendHandler.Send((MSG_CG_FRIEND_BLACK_ADD)msg);

case "MSG_CG_FRIEND_BLACK_DEL":
return sendHandler.Send((MSG_CG_FRIEND_BLACK_DEL)msg);

case "MSG_CG_FRIEND_RECOMMEND":
return sendHandler.Send((MSG_CG_FRIEND_RECOMMEND)msg);

case "MSG_CG_CREATE_GUILD":
return sendHandler.Send((MSG_CG_CREATE_GUILD)msg);

case "MSG_CG_CHAT_EMOJI":
return sendHandler.Send((MSG_CG_CHAT_EMOJI)msg);

case "MSG_CG_CHAT_WORDS":
return sendHandler.Send((MSG_CG_CHAT_WORDS)msg);

case "MSG_CG_CHANGE_WORLD_ROOM":
return sendHandler.Send((MSG_CG_CHANGE_WORLD_ROOM)msg);

case "MSG_CG_GET_WORLD_ROOM_LIST":
return sendHandler.Send((MSG_CG_GET_WORLD_ROOM_LIST)msg);

case "MSG_CG_CHAT_TRUMPET":
return sendHandler.Send((MSG_CG_CHAT_TRUMPET)msg);

case "MSG_CG_CHAT_REPORT":
return sendHandler.Send((MSG_CG_CHAT_REPORT)msg);

case "MSG_CG_NEARBY_EMOJI":
return sendHandler.Send((MSG_CG_NEARBY_EMOJI)msg);

case "MSG_CG_TIP_OFF":
return sendHandler.Send((MSG_CG_TIP_OFF)msg);

case "MSG_CG_ACTIVITY_CHAT_BUBBLE":
return sendHandler.Send((MSG_CG_ACTIVITY_CHAT_BUBBLE)msg);

case "MSG_CG_USE_CHAT_TRUMPET":
return sendHandler.Send((MSG_CG_USE_CHAT_TRUMPET)msg);

case "MSG_CG_TASK_COMPLETE":
return sendHandler.Send((MSG_CG_TASK_COMPLETE)msg);

case "MSG_CG_OPENE_EMAIL_TASK":
return sendHandler.Send((MSG_CG_OPENE_EMAIL_TASK)msg);

case "MSG_CG_TASK_COLLECT":
return sendHandler.Send((MSG_CG_TASK_COLLECT)msg);

case "MSG_CG_TASK_SELECT":
return sendHandler.Send((MSG_CG_TASK_SELECT)msg);

case "MSG_CG_TASK_MAKE":
return sendHandler.Send((MSG_CG_TASK_MAKE)msg);

case "MSG_CG_TASKFLY_FLY_DONE":
return sendHandler.Send((MSG_CG_TASKFLY_FLY_DONE)msg);

case "MSG_CG_TASKFLY_STARTPATHFINDING":
return sendHandler.Send((MSG_CG_TASKFLY_STARTPATHFINDING)msg);

case "MSG_CG_ACTIVITY_COMPLETE":
return sendHandler.Send((MSG_CG_ACTIVITY_COMPLETE)msg);

case "MSG_CG_SHOW_CHARACTER":
return sendHandler.Send((MSG_CG_SHOW_CHARACTER)msg);

case "MSG_CG_CHANGE_NAME":
return sendHandler.Send((MSG_CG_CHANGE_NAME)msg);

case "MSG_CG_SHOW_FACEICON":
return sendHandler.Send((MSG_CG_SHOW_FACEICON)msg);

case "MSG_CG_SHOW_FACEJPG":
return sendHandler.Send((MSG_CG_SHOW_FACEJPG)msg);

case "MSG_CG_SET_SEX":
return sendHandler.Send((MSG_CG_SET_SEX)msg);

case "MSG_CG_SET_BIRTHDAY":
return sendHandler.Send((MSG_CG_SET_BIRTHDAY)msg);

case "MSG_CG_SET_SIGNATURE":
return sendHandler.Send((MSG_CG_SET_SIGNATURE)msg);

case "MSG_CG_SHOW_VOICE":
return sendHandler.Send((MSG_CG_SHOW_VOICE)msg);

case "MSG_CG_PRESENT_GIFT":
return sendHandler.Send((MSG_CG_PRESENT_GIFT)msg);

case "MSG_CG_GET_GIFTRECORD":
return sendHandler.Send((MSG_CG_GET_GIFTRECORD)msg);

case "MSG_CG_SET_SOCIAL_NUM":
return sendHandler.Send((MSG_CG_SET_SOCIAL_NUM)msg);

case "MSG_CG_GET_SOCIAL_NUM":
return sendHandler.Send((MSG_CG_GET_SOCIAL_NUM)msg);

case "MSG_CG_SHOW_CAREER":
return sendHandler.Send((MSG_CG_SHOW_CAREER)msg);

case "MSG_CG_GET_RANKING_FRIEND_LIST":
return sendHandler.Send((MSG_CG_GET_RANKING_FRIEND_LIST)msg);

case "MSG_CG_GET_RANKING_ALL_LIST":
return sendHandler.Send((MSG_CG_GET_RANKING_ALL_LIST)msg);

case "MSG_CG_GET_RANKING_NEARBY_LIST":
return sendHandler.Send((MSG_CG_GET_RANKING_NEARBY_LIST)msg);

case "MSG_CG_CHANGE_TITLE":
return sendHandler.Send((MSG_CG_CHANGE_TITLE)msg);

case "MSG_CG_UPLOAD_PHOTO":
return sendHandler.Send((MSG_CG_UPLOAD_PHOTO)msg);

case "MSG_CG_REMOVE_PHOTO":
return sendHandler.Send((MSG_CG_REMOVE_PHOTO)msg);

case "MSG_CG_PHOTO_LIST":
return sendHandler.Send((MSG_CG_PHOTO_LIST)msg);

case "MSG_CG_POP_RANK":
return sendHandler.Send((MSG_CG_POP_RANK)msg);

case "MSG_CG_QUESTION":
return sendHandler.Send((MSG_CG_QUESTION)msg);

case "MSG_CG_QUESTIONNAIRE":
return sendHandler.Send((MSG_CG_QUESTIONNAIRE)msg);

case "MSG_CG_DAILY_QUESTION_COUNTER":
return sendHandler.Send((MSG_CG_DAILY_QUESTION_COUNTER)msg);

case "MSG_CG_DAILY_QUESTION_REWARD":
return sendHandler.Send((MSG_CG_DAILY_QUESTION_REWARD)msg);

case "MSG_CG_RADIO_GET_ALL_ANCHOR_RANK":
return sendHandler.Send((MSG_CG_RADIO_GET_ALL_ANCHOR_RANK)msg);

case "MSG_CG_RADIO_GET_ANCHOR_CONTRIBUTION_RANK":
return sendHandler.Send((MSG_CG_RADIO_GET_ANCHOR_CONTRIBUTION_RANK)msg);

case "MSG_CG_RADIO_GET_ALL_CONTRIBUTION_RANK":
return sendHandler.Send((MSG_CG_RADIO_GET_ALL_CONTRIBUTION_RANK)msg);

case "MSG_CG_RADIO_GET_CONTRIBUTION_REWARD":
return sendHandler.Send((MSG_CG_RADIO_GET_CONTRIBUTION_REWARD)msg);

case "MSG_CG_RADIO_GIVE_GIFT":
return sendHandler.Send((MSG_CG_RADIO_GIVE_GIFT)msg);

case "MSG_CG_RADIO_ENTER":
return sendHandler.Send((MSG_CG_RADIO_ENTER)msg);

case "MSG_CG_RADIO_LEAVE":
return sendHandler.Send((MSG_CG_RADIO_LEAVE)msg);

case "MSG_CG_CALL_PET":
return sendHandler.Send((MSG_CG_CALL_PET)msg);

case "MSG_CG_RECALL_PET":
return sendHandler.Send((MSG_CG_RECALL_PET)msg);

case "MSG_CG_CALL_HERO":
return sendHandler.Send((MSG_CG_CALL_HERO)msg);

case "MSG_CG_RECALL_HERO":
return sendHandler.Send((MSG_CG_RECALL_HERO)msg);

case "MSG_CG_HERO_LEVEL_UP":
return sendHandler.Send((MSG_CG_HERO_LEVEL_UP)msg);

case "MSG_CG_HERO_AWAKEN":
return sendHandler.Send((MSG_CG_HERO_AWAKEN)msg);

case "MSG_CG_HERO_ABSORB_SOUL_LINK":
return sendHandler.Send((MSG_CG_HERO_ABSORB_SOUL_LINK)msg);

case "MSG_CG_HERO_CLICK_TALENT":
return sendHandler.Send((MSG_CG_HERO_CLICK_TALENT)msg);


default:
return false;
}
}
public void BindMsgId()
{
Message.Gate.Protocol.GateC.GateCIdGenerator.GenerateId();
Message.Client.Protocol.CGate.CGateIdGenerator.GenerateId();
Message.Barrack.Protocol.BarrackC.BarrackCIdGenerator.GenerateId();
Message.Client.Protocol.CBarrack.CBarrackIdGenerator.GenerateId();
}

}
}

