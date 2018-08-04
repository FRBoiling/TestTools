using System;
using System.IO;
using Message.Server.Client.Protocol.CGate;
using Message.Server.Gate.Protocol.GateC;
using ProtoSendTool;
using UtilityLibrary;
using Engine.Foundation;
using LogLibrary;
using System.Reflection;
namespace ProtoSendTool
{
 public partial class Client 
{

public void OnResponse_MSG_GC_INSTANCES_REMOVE(MemoryStream stream)
{
 MSG_GC_INSTANCES_REMOVE MSG_GC_INSTANCES_REMOVE = ProtoBuf.Serializer.Deserialize<MSG_GC_INSTANCES_REMOVE>(stream);
Parser.Parse(MSG_GC_INSTANCES_REMOVE);
}
public void OnResponse_MODEL_INFO(MemoryStream stream)
{
 MODEL_INFO MODEL_INFO = ProtoBuf.Serializer.Deserialize<MODEL_INFO>(stream);
Parser.Parse(MODEL_INFO);
}
public void OnResponse_MSG_GC_CHARACTER_INFO(MemoryStream stream)
{
 MSG_GC_CHARACTER_INFO MSG_GC_CHARACTER_INFO = ProtoBuf.Serializer.Deserialize<MSG_GC_CHARACTER_INFO>(stream);
Parser.Parse(MSG_GC_CHARACTER_INFO);
}
public void OnResponse_MSG_GC_CREATE_CHARACTER(MemoryStream stream)
{
 MSG_GC_CREATE_CHARACTER MSG_GC_CREATE_CHARACTER = ProtoBuf.Serializer.Deserialize<MSG_GC_CREATE_CHARACTER>(stream);
Parser.Parse(MSG_GC_CREATE_CHARACTER);
}
public void OnResponse_MSG_GC_TO_ZONE(MemoryStream stream)
{
 MSG_GC_TO_ZONE MSG_GC_TO_ZONE = ProtoBuf.Serializer.Deserialize<MSG_GC_TO_ZONE>(stream);
Parser.Parse(MSG_GC_TO_ZONE);
}
public void OnResponse_MSG_ZGC_ERROR_CODE(MemoryStream stream)
{
 MSG_ZGC_ERROR_CODE MSG_ZGC_ERROR_CODE = ProtoBuf.Serializer.Deserialize<MSG_ZGC_ERROR_CODE>(stream);
Parser.Parse(MSG_ZGC_ERROR_CODE);
}
public void OnResponse_MSG_ZGC_NPC_INFO(MemoryStream stream)
{
 MSG_ZGC_NPC_INFO MSG_ZGC_NPC_INFO = ProtoBuf.Serializer.Deserialize<MSG_ZGC_NPC_INFO>(stream);
Parser.Parse(MSG_ZGC_NPC_INFO);
}
public void OnResponse_MSG_ZGC_GOODS_INFO(MemoryStream stream)
{
 MSG_ZGC_GOODS_INFO MSG_ZGC_GOODS_INFO = ProtoBuf.Serializer.Deserialize<MSG_ZGC_GOODS_INFO>(stream);
Parser.Parse(MSG_ZGC_GOODS_INFO);
}
public void OnResponse_MSG_ZGC_INTERACTION(MemoryStream stream)
{
 MSG_ZGC_INTERACTION MSG_ZGC_INTERACTION = ProtoBuf.Serializer.Deserialize<MSG_ZGC_INTERACTION>(stream);
Parser.Parse(MSG_ZGC_INTERACTION);
}
public void OnResponse_MSG_GC_RECONNECT_LOGIN(MemoryStream stream)
{
 MSG_GC_RECONNECT_LOGIN MSG_GC_RECONNECT_LOGIN = ProtoBuf.Serializer.Deserialize<MSG_GC_RECONNECT_LOGIN>(stream);
Parser.Parse(MSG_GC_RECONNECT_LOGIN);
}
public void OnResponse_MSG_ZGC_LOGIN_FREEZE(MemoryStream stream)
{
 MSG_ZGC_LOGIN_FREEZE MSG_ZGC_LOGIN_FREEZE = ProtoBuf.Serializer.Deserialize<MSG_ZGC_LOGIN_FREEZE>(stream);
Parser.Parse(MSG_ZGC_LOGIN_FREEZE);
}
public void OnResponse_MSG_GC_FieldObject_MOVE(MemoryStream stream)
{
 MSG_GC_FieldObject_MOVE MSG_GC_FieldObject_MOVE = ProtoBuf.Serializer.Deserialize<MSG_GC_FieldObject_MOVE>(stream);
Parser.Parse(MSG_GC_FieldObject_MOVE);
}
public void OnResponse_MSG_ZGC_CHARACTER_STOP(MemoryStream stream)
{
 MSG_ZGC_CHARACTER_STOP MSG_ZGC_CHARACTER_STOP = ProtoBuf.Serializer.Deserialize<MSG_ZGC_CHARACTER_STOP>(stream);
Parser.Parse(MSG_ZGC_CHARACTER_STOP);
}
public void OnResponse_MSG_GC_CHAR_SIMPLE_INFO(MemoryStream stream)
{
 MSG_GC_CHAR_SIMPLE_INFO MSG_GC_CHAR_SIMPLE_INFO = ProtoBuf.Serializer.Deserialize<MSG_GC_CHAR_SIMPLE_INFO>(stream);
Parser.Parse(MSG_GC_CHAR_SIMPLE_INFO);
}
public void OnResponse_MSG_GC_BROADCAST_INFO(MemoryStream stream)
{
 MSG_GC_BROADCAST_INFO MSG_GC_BROADCAST_INFO = ProtoBuf.Serializer.Deserialize<MSG_GC_BROADCAST_INFO>(stream);
Parser.Parse(MSG_GC_BROADCAST_INFO);
}
public void OnResponse_MSG_GC_BROADCAST_LIST(MemoryStream stream)
{
 MSG_GC_BROADCAST_LIST MSG_GC_BROADCAST_LIST = ProtoBuf.Serializer.Deserialize<MSG_GC_BROADCAST_LIST>(stream);
Parser.Parse(MSG_GC_BROADCAST_LIST);
}
public void OnResponse_MSG_GC_CHARACTER_ENTER_LIST(MemoryStream stream)
{
 MSG_GC_CHARACTER_ENTER_LIST MSG_GC_CHARACTER_ENTER_LIST = ProtoBuf.Serializer.Deserialize<MSG_GC_CHARACTER_ENTER_LIST>(stream);
Parser.Parse(MSG_GC_CHARACTER_ENTER_LIST);
}
public void OnResponse_MSG_GC_CHARACTER_LEAVE(MemoryStream stream)
{
 MSG_GC_CHARACTER_LEAVE MSG_GC_CHARACTER_LEAVE = ProtoBuf.Serializer.Deserialize<MSG_GC_CHARACTER_LEAVE>(stream);
Parser.Parse(MSG_GC_CHARACTER_LEAVE);
}
public void OnResponse_MSG_ZGC_PET_SIMPLE_INFO(MemoryStream stream)
{
 MSG_ZGC_PET_SIMPLE_INFO MSG_ZGC_PET_SIMPLE_INFO = ProtoBuf.Serializer.Deserialize<MSG_ZGC_PET_SIMPLE_INFO>(stream);
Parser.Parse(MSG_ZGC_PET_SIMPLE_INFO);
}
public void OnResponse_MSG_GC_PET_ENTER_LIST(MemoryStream stream)
{
 MSG_GC_PET_ENTER_LIST MSG_GC_PET_ENTER_LIST = ProtoBuf.Serializer.Deserialize<MSG_GC_PET_ENTER_LIST>(stream);
Parser.Parse(MSG_GC_PET_ENTER_LIST);
}
public void OnResponse_MSG_ZGC_PET_LEAVE(MemoryStream stream)
{
 MSG_ZGC_PET_LEAVE MSG_ZGC_PET_LEAVE = ProtoBuf.Serializer.Deserialize<MSG_ZGC_PET_LEAVE>(stream);
Parser.Parse(MSG_ZGC_PET_LEAVE);
}
public void OnResponse_MSG_ZGC_NPC_MOVE(MemoryStream stream)
{
 MSG_ZGC_NPC_MOVE MSG_ZGC_NPC_MOVE = ProtoBuf.Serializer.Deserialize<MSG_ZGC_NPC_MOVE>(stream);
Parser.Parse(MSG_ZGC_NPC_MOVE);
}
public void OnResponse_MSG_ZGC_NPC_LEAVE(MemoryStream stream)
{
 MSG_ZGC_NPC_LEAVE MSG_ZGC_NPC_LEAVE = ProtoBuf.Serializer.Deserialize<MSG_ZGC_NPC_LEAVE>(stream);
Parser.Parse(MSG_ZGC_NPC_LEAVE);
}
public void OnResponse_MSG_ZGC_NPC_SIMPLE_INFO(MemoryStream stream)
{
 MSG_ZGC_NPC_SIMPLE_INFO MSG_ZGC_NPC_SIMPLE_INFO = ProtoBuf.Serializer.Deserialize<MSG_ZGC_NPC_SIMPLE_INFO>(stream);
Parser.Parse(MSG_ZGC_NPC_SIMPLE_INFO);
}
public void OnResponse_MSG_GC_NPC_ENTER_LIST(MemoryStream stream)
{
 MSG_GC_NPC_ENTER_LIST MSG_GC_NPC_ENTER_LIST = ProtoBuf.Serializer.Deserialize<MSG_GC_NPC_ENTER_LIST>(stream);
Parser.Parse(MSG_GC_NPC_ENTER_LIST);
}
public void OnResponse_MSG_ZGC_CHEST_STATE_SYNC(MemoryStream stream)
{
 MSG_ZGC_CHEST_STATE_SYNC MSG_ZGC_CHEST_STATE_SYNC = ProtoBuf.Serializer.Deserialize<MSG_ZGC_CHEST_STATE_SYNC>(stream);
Parser.Parse(MSG_ZGC_CHEST_STATE_SYNC);
}
public void OnResponse_CHEST_FREE(MemoryStream stream)
{
 CHEST_FREE CHEST_FREE = ProtoBuf.Serializer.Deserialize<CHEST_FREE>(stream);
Parser.Parse(CHEST_FREE);
}
public void OnResponse_CHEST_LADDER(MemoryStream stream)
{
 CHEST_LADDER CHEST_LADDER = ProtoBuf.Serializer.Deserialize<CHEST_LADDER>(stream);
Parser.Parse(CHEST_LADDER);
}
public void OnResponse_CHEST_NORMAL(MemoryStream stream)
{
 CHEST_NORMAL CHEST_NORMAL = ProtoBuf.Serializer.Deserialize<CHEST_NORMAL>(stream);
Parser.Parse(CHEST_NORMAL);
}
public void OnResponse_MSG_ZGC_OPEN_CHEST(MemoryStream stream)
{
 MSG_ZGC_OPEN_CHEST MSG_ZGC_OPEN_CHEST = ProtoBuf.Serializer.Deserialize<MSG_ZGC_OPEN_CHEST>(stream);
Parser.Parse(MSG_ZGC_OPEN_CHEST);
}
public void OnResponse_CHEST_ITEM_INFO(MemoryStream stream)
{
 CHEST_ITEM_INFO CHEST_ITEM_INFO = ProtoBuf.Serializer.Deserialize<CHEST_ITEM_INFO>(stream);
Parser.Parse(CHEST_ITEM_INFO);
}
public void OnResponse_MSG_ZGC_UNLOCK_CHEST(MemoryStream stream)
{
 MSG_ZGC_UNLOCK_CHEST MSG_ZGC_UNLOCK_CHEST = ProtoBuf.Serializer.Deserialize<MSG_ZGC_UNLOCK_CHEST>(stream);
Parser.Parse(MSG_ZGC_UNLOCK_CHEST);
}
public void OnResponse_MSG_ZGC_OPEN_CHEST_RESULT(MemoryStream stream)
{
 MSG_ZGC_OPEN_CHEST_RESULT MSG_ZGC_OPEN_CHEST_RESULT = ProtoBuf.Serializer.Deserialize<MSG_ZGC_OPEN_CHEST_RESULT>(stream);
Parser.Parse(MSG_ZGC_OPEN_CHEST_RESULT);
}
public void OnResponse_ITEM(MemoryStream stream)
{
 ITEM ITEM = ProtoBuf.Serializer.Deserialize<ITEM>(stream);
Parser.Parse(ITEM);
}
public void OnResponse_MSG_ZGC_KNAPSACK_SYNC(MemoryStream stream)
{
 MSG_ZGC_KNAPSACK_SYNC MSG_ZGC_KNAPSACK_SYNC = ProtoBuf.Serializer.Deserialize<MSG_ZGC_KNAPSACK_SYNC>(stream);
Parser.Parse(MSG_ZGC_KNAPSACK_SYNC);
}
public void OnResponse_MSG_ZGC_KNAPSACK_UPDATE(MemoryStream stream)
{
 MSG_ZGC_KNAPSACK_UPDATE MSG_ZGC_KNAPSACK_UPDATE = ProtoBuf.Serializer.Deserialize<MSG_ZGC_KNAPSACK_UPDATE>(stream);
Parser.Parse(MSG_ZGC_KNAPSACK_UPDATE);
}
public void OnResponse_MSG_ZGC_ITEM_USE(MemoryStream stream)
{
 MSG_ZGC_ITEM_USE MSG_ZGC_ITEM_USE = ProtoBuf.Serializer.Deserialize<MSG_ZGC_ITEM_USE>(stream);
Parser.Parse(MSG_ZGC_ITEM_USE);
}
public void OnResponse_MSG_ZGC_ITEM_SELL(MemoryStream stream)
{
 MSG_ZGC_ITEM_SELL MSG_ZGC_ITEM_SELL = ProtoBuf.Serializer.Deserialize<MSG_ZGC_ITEM_SELL>(stream);
Parser.Parse(MSG_ZGC_ITEM_SELL);
}
public void OnResponse_MSG_ZGC_EQUIP_FACEFRAME(MemoryStream stream)
{
 MSG_ZGC_EQUIP_FACEFRAME MSG_ZGC_EQUIP_FACEFRAME = ProtoBuf.Serializer.Deserialize<MSG_ZGC_EQUIP_FACEFRAME>(stream);
Parser.Parse(MSG_ZGC_EQUIP_FACEFRAME);
}
public void OnResponse_MSG_ZGC_ITEM_BUY(MemoryStream stream)
{
 MSG_ZGC_ITEM_BUY MSG_ZGC_ITEM_BUY = ProtoBuf.Serializer.Deserialize<MSG_ZGC_ITEM_BUY>(stream);
Parser.Parse(MSG_ZGC_ITEM_BUY);
}
public void OnResponse_CURRENCY(MemoryStream stream)
{
 CURRENCY CURRENCY = ProtoBuf.Serializer.Deserialize<CURRENCY>(stream);
Parser.Parse(CURRENCY);
}
public void OnResponse_MSG_ZGC_SYNC_CURRENCIES(MemoryStream stream)
{
 MSG_ZGC_SYNC_CURRENCIES MSG_ZGC_SYNC_CURRENCIES = ProtoBuf.Serializer.Deserialize<MSG_ZGC_SYNC_CURRENCIES>(stream);
Parser.Parse(MSG_ZGC_SYNC_CURRENCIES);
}
public void OnResponse_MSG_ZGC_SHOW_CHARACTER(MemoryStream stream)
{
 MSG_ZGC_SHOW_CHARACTER MSG_ZGC_SHOW_CHARACTER = ProtoBuf.Serializer.Deserialize<MSG_ZGC_SHOW_CHARACTER>(stream);
Parser.Parse(MSG_ZGC_SHOW_CHARACTER);
}
public void OnResponse_SHOW_CHARACTERINFO(MemoryStream stream)
{
 SHOW_CHARACTERINFO SHOW_CHARACTERINFO = ProtoBuf.Serializer.Deserialize<SHOW_CHARACTERINFO>(stream);
Parser.Parse(SHOW_CHARACTERINFO);
}
public void OnResponse_MSG_ZGC_SHOW_VOICE(MemoryStream stream)
{
 MSG_ZGC_SHOW_VOICE MSG_ZGC_SHOW_VOICE = ProtoBuf.Serializer.Deserialize<MSG_ZGC_SHOW_VOICE>(stream);
Parser.Parse(MSG_ZGC_SHOW_VOICE);
}
public void OnResponse_SHOW_SPACEINFO(MemoryStream stream)
{
 SHOW_SPACEINFO SHOW_SPACEINFO = ProtoBuf.Serializer.Deserialize<SHOW_SPACEINFO>(stream);
Parser.Parse(SHOW_SPACEINFO);
}
public void OnResponse_MSG_ZGC_CHANGE_NAME(MemoryStream stream)
{
 MSG_ZGC_CHANGE_NAME MSG_ZGC_CHANGE_NAME = ProtoBuf.Serializer.Deserialize<MSG_ZGC_CHANGE_NAME>(stream);
Parser.Parse(MSG_ZGC_CHANGE_NAME);
}
public void OnResponse_MSG_ZGC_SHOW_FACEICON(MemoryStream stream)
{
 MSG_ZGC_SHOW_FACEICON MSG_ZGC_SHOW_FACEICON = ProtoBuf.Serializer.Deserialize<MSG_ZGC_SHOW_FACEICON>(stream);
Parser.Parse(MSG_ZGC_SHOW_FACEICON);
}
public void OnResponse_MSG_ZGC_SHOW_FACEJPG(MemoryStream stream)
{
 MSG_ZGC_SHOW_FACEJPG MSG_ZGC_SHOW_FACEJPG = ProtoBuf.Serializer.Deserialize<MSG_ZGC_SHOW_FACEJPG>(stream);
Parser.Parse(MSG_ZGC_SHOW_FACEJPG);
}
public void OnResponse_MSG_ZGC_SET_SEX(MemoryStream stream)
{
 MSG_ZGC_SET_SEX MSG_ZGC_SET_SEX = ProtoBuf.Serializer.Deserialize<MSG_ZGC_SET_SEX>(stream);
Parser.Parse(MSG_ZGC_SET_SEX);
}
public void OnResponse_MSG_ZGC_SET_BIRTHDAY(MemoryStream stream)
{
 MSG_ZGC_SET_BIRTHDAY MSG_ZGC_SET_BIRTHDAY = ProtoBuf.Serializer.Deserialize<MSG_ZGC_SET_BIRTHDAY>(stream);
Parser.Parse(MSG_ZGC_SET_BIRTHDAY);
}
public void OnResponse_MSG_ZGC_SET_SIGNATURE(MemoryStream stream)
{
 MSG_ZGC_SET_SIGNATURE MSG_ZGC_SET_SIGNATURE = ProtoBuf.Serializer.Deserialize<MSG_ZGC_SET_SIGNATURE>(stream);
Parser.Parse(MSG_ZGC_SET_SIGNATURE);
}
public void OnResponse_MSG_ZGC_PRESENT_GIFT(MemoryStream stream)
{
 MSG_ZGC_PRESENT_GIFT MSG_ZGC_PRESENT_GIFT = ProtoBuf.Serializer.Deserialize<MSG_ZGC_PRESENT_GIFT>(stream);
Parser.Parse(MSG_ZGC_PRESENT_GIFT);
}
public void OnResponse_MSG_ZGC_SET_SOCIAL_NUM(MemoryStream stream)
{
 MSG_ZGC_SET_SOCIAL_NUM MSG_ZGC_SET_SOCIAL_NUM = ProtoBuf.Serializer.Deserialize<MSG_ZGC_SET_SOCIAL_NUM>(stream);
Parser.Parse(MSG_ZGC_SET_SOCIAL_NUM);
}
public void OnResponse_MSG_ZGC_GET_SOCIAL_NUM(MemoryStream stream)
{
 MSG_ZGC_GET_SOCIAL_NUM MSG_ZGC_GET_SOCIAL_NUM = ProtoBuf.Serializer.Deserialize<MSG_ZGC_GET_SOCIAL_NUM>(stream);
Parser.Parse(MSG_ZGC_GET_SOCIAL_NUM);
}
public void OnResponse_MSG_ZGC_GEOGRAPHY(MemoryStream stream)
{
 MSG_ZGC_GEOGRAPHY MSG_ZGC_GEOGRAPHY = ProtoBuf.Serializer.Deserialize<MSG_ZGC_GEOGRAPHY>(stream);
Parser.Parse(MSG_ZGC_GEOGRAPHY);
}
public void OnResponse_SHOW_HERO(MemoryStream stream)
{
 SHOW_HERO SHOW_HERO = ProtoBuf.Serializer.Deserialize<SHOW_HERO>(stream);
Parser.Parse(SHOW_HERO);
}
public void OnResponse_CUR_HERO_QUEUE(MemoryStream stream)
{
 CUR_HERO_QUEUE CUR_HERO_QUEUE = ProtoBuf.Serializer.Deserialize<CUR_HERO_QUEUE>(stream);
Parser.Parse(CUR_HERO_QUEUE);
}
public void OnResponse_SHOW_SKILL(MemoryStream stream)
{
 SHOW_SKILL SHOW_SKILL = ProtoBuf.Serializer.Deserialize<SHOW_SKILL>(stream);
Parser.Parse(SHOW_SKILL);
}
public void OnResponse_CUR_SKILL_QUEUE(MemoryStream stream)
{
 CUR_SKILL_QUEUE CUR_SKILL_QUEUE = ProtoBuf.Serializer.Deserialize<CUR_SKILL_QUEUE>(stream);
Parser.Parse(CUR_SKILL_QUEUE);
}
public void OnResponse_MSG_ZGC_SHOW_CUR_CARDQUEUE(MemoryStream stream)
{
 MSG_ZGC_SHOW_CUR_CARDQUEUE MSG_ZGC_SHOW_CUR_CARDQUEUE = ProtoBuf.Serializer.Deserialize<MSG_ZGC_SHOW_CUR_CARDQUEUE>(stream);
Parser.Parse(MSG_ZGC_SHOW_CUR_CARDQUEUE);
}
public void OnResponse_MSG_ZGC_UPDATE_SOME_SHOW(MemoryStream stream)
{
 MSG_ZGC_UPDATE_SOME_SHOW MSG_ZGC_UPDATE_SOME_SHOW = ProtoBuf.Serializer.Deserialize<MSG_ZGC_UPDATE_SOME_SHOW>(stream);
Parser.Parse(MSG_ZGC_UPDATE_SOME_SHOW);
}
public void OnResponse_MSG_ZGC_SHOW_CAREER(MemoryStream stream)
{
 MSG_ZGC_SHOW_CAREER MSG_ZGC_SHOW_CAREER = ProtoBuf.Serializer.Deserialize<MSG_ZGC_SHOW_CAREER>(stream);
Parser.Parse(MSG_ZGC_SHOW_CAREER);
}
public void OnResponse_MSG_ZGC_CAREER_ITEM(MemoryStream stream)
{
 MSG_ZGC_CAREER_ITEM MSG_ZGC_CAREER_ITEM = ProtoBuf.Serializer.Deserialize<MSG_ZGC_CAREER_ITEM>(stream);
Parser.Parse(MSG_ZGC_CAREER_ITEM);
}
public void OnResponse_MSG_ZGC_GET_GIFTRECORD(MemoryStream stream)
{
 MSG_ZGC_GET_GIFTRECORD MSG_ZGC_GET_GIFTRECORD = ProtoBuf.Serializer.Deserialize<MSG_ZGC_GET_GIFTRECORD>(stream);
Parser.Parse(MSG_ZGC_GET_GIFTRECORD);
}
public void OnResponse_PLAYER_BASE_INFO(MemoryStream stream)
{
 PLAYER_BASE_INFO PLAYER_BASE_INFO = ProtoBuf.Serializer.Deserialize<PLAYER_BASE_INFO>(stream);
Parser.Parse(PLAYER_BASE_INFO);
}
public void OnResponse_MSG_ZGC_FRIEND_SEARCH(MemoryStream stream)
{
 MSG_ZGC_FRIEND_SEARCH MSG_ZGC_FRIEND_SEARCH = ProtoBuf.Serializer.Deserialize<MSG_ZGC_FRIEND_SEARCH>(stream);
Parser.Parse(MSG_ZGC_FRIEND_SEARCH);
}
public void OnResponse_MSG_ZGC_FRIEND_ADD_REQUEST(MemoryStream stream)
{
 MSG_ZGC_FRIEND_ADD_REQUEST MSG_ZGC_FRIEND_ADD_REQUEST = ProtoBuf.Serializer.Deserialize<MSG_ZGC_FRIEND_ADD_REQUEST>(stream);
Parser.Parse(MSG_ZGC_FRIEND_ADD_REQUEST);
}
public void OnResponse_MSG_ZGC_FRIEND_ADD_RESPONSE(MemoryStream stream)
{
 MSG_ZGC_FRIEND_ADD_RESPONSE MSG_ZGC_FRIEND_ADD_RESPONSE = ProtoBuf.Serializer.Deserialize<MSG_ZGC_FRIEND_ADD_RESPONSE>(stream);
Parser.Parse(MSG_ZGC_FRIEND_ADD_RESPONSE);
}
public void OnResponse_MSG_ZGC_FRIEND_DELETE(MemoryStream stream)
{
 MSG_ZGC_FRIEND_DELETE MSG_ZGC_FRIEND_DELETE = ProtoBuf.Serializer.Deserialize<MSG_ZGC_FRIEND_DELETE>(stream);
Parser.Parse(MSG_ZGC_FRIEND_DELETE);
}
public void OnResponse_MSG_ZGC_FRIEND_LIST(MemoryStream stream)
{
 MSG_ZGC_FRIEND_LIST MSG_ZGC_FRIEND_LIST = ProtoBuf.Serializer.Deserialize<MSG_ZGC_FRIEND_LIST>(stream);
Parser.Parse(MSG_ZGC_FRIEND_LIST);
}
public void OnResponse_FRIEND_REQUEST_INFO(MemoryStream stream)
{
 FRIEND_REQUEST_INFO FRIEND_REQUEST_INFO = ProtoBuf.Serializer.Deserialize<FRIEND_REQUEST_INFO>(stream);
Parser.Parse(FRIEND_REQUEST_INFO);
}
public void OnResponse_MSG_ZGC_FRIEND_REQUEST_LIST(MemoryStream stream)
{
 MSG_ZGC_FRIEND_REQUEST_LIST MSG_ZGC_FRIEND_REQUEST_LIST = ProtoBuf.Serializer.Deserialize<MSG_ZGC_FRIEND_REQUEST_LIST>(stream);
Parser.Parse(MSG_ZGC_FRIEND_REQUEST_LIST);
}
public void OnResponse_MSG_ZGC_FRIEND_RECENT_LIST(MemoryStream stream)
{
 MSG_ZGC_FRIEND_RECENT_LIST MSG_ZGC_FRIEND_RECENT_LIST = ProtoBuf.Serializer.Deserialize<MSG_ZGC_FRIEND_RECENT_LIST>(stream);
Parser.Parse(MSG_ZGC_FRIEND_RECENT_LIST);
}
public void OnResponse_BLACK_INFO(MemoryStream stream)
{
 BLACK_INFO BLACK_INFO = ProtoBuf.Serializer.Deserialize<BLACK_INFO>(stream);
Parser.Parse(BLACK_INFO);
}
public void OnResponse_MSG_ZGC_FRIEND_BLACK_LIST(MemoryStream stream)
{
 MSG_ZGC_FRIEND_BLACK_LIST MSG_ZGC_FRIEND_BLACK_LIST = ProtoBuf.Serializer.Deserialize<MSG_ZGC_FRIEND_BLACK_LIST>(stream);
Parser.Parse(MSG_ZGC_FRIEND_BLACK_LIST);
}
public void OnResponse_MSG_ZGC_FRIEND_BLACK_ADD(MemoryStream stream)
{
 MSG_ZGC_FRIEND_BLACK_ADD MSG_ZGC_FRIEND_BLACK_ADD = ProtoBuf.Serializer.Deserialize<MSG_ZGC_FRIEND_BLACK_ADD>(stream);
Parser.Parse(MSG_ZGC_FRIEND_BLACK_ADD);
}
public void OnResponse_MSG_ZGC_FRIEND_BLACK_DEL(MemoryStream stream)
{
 MSG_ZGC_FRIEND_BLACK_DEL MSG_ZGC_FRIEND_BLACK_DEL = ProtoBuf.Serializer.Deserialize<MSG_ZGC_FRIEND_BLACK_DEL>(stream);
Parser.Parse(MSG_ZGC_FRIEND_BLACK_DEL);
}
public void OnResponse_FRIEND_SEARCH_INFO(MemoryStream stream)
{
 FRIEND_SEARCH_INFO FRIEND_SEARCH_INFO = ProtoBuf.Serializer.Deserialize<FRIEND_SEARCH_INFO>(stream);
Parser.Parse(FRIEND_SEARCH_INFO);
}
public void OnResponse_MSG_ZGC_FRIEND_RECOMMEND(MemoryStream stream)
{
 MSG_ZGC_FRIEND_RECOMMEND MSG_ZGC_FRIEND_RECOMMEND = ProtoBuf.Serializer.Deserialize<MSG_ZGC_FRIEND_RECOMMEND>(stream);
Parser.Parse(MSG_ZGC_FRIEND_RECOMMEND);
}
public void OnResponse_MSG_ZGC_RANKING_FRIEND_LIST(MemoryStream stream)
{
 MSG_ZGC_RANKING_FRIEND_LIST MSG_ZGC_RANKING_FRIEND_LIST = ProtoBuf.Serializer.Deserialize<MSG_ZGC_RANKING_FRIEND_LIST>(stream);
Parser.Parse(MSG_ZGC_RANKING_FRIEND_LIST);
}
public void OnResponse_MSG_ZGC_RANKING_ALL_LIST(MemoryStream stream)
{
 MSG_ZGC_RANKING_ALL_LIST MSG_ZGC_RANKING_ALL_LIST = ProtoBuf.Serializer.Deserialize<MSG_ZGC_RANKING_ALL_LIST>(stream);
Parser.Parse(MSG_ZGC_RANKING_ALL_LIST);
}
public void OnResponse_MSG_ZGC_RANKING_NEARBY_LIST(MemoryStream stream)
{
 MSG_ZGC_RANKING_NEARBY_LIST MSG_ZGC_RANKING_NEARBY_LIST = ProtoBuf.Serializer.Deserialize<MSG_ZGC_RANKING_NEARBY_LIST>(stream);
Parser.Parse(MSG_ZGC_RANKING_NEARBY_LIST);
}
public void OnResponse_MSG_ZGC_CREATE_GUILD(MemoryStream stream)
{
 MSG_ZGC_CREATE_GUILD MSG_ZGC_CREATE_GUILD = ProtoBuf.Serializer.Deserialize<MSG_ZGC_CREATE_GUILD>(stream);
Parser.Parse(MSG_ZGC_CREATE_GUILD);
}
public void OnResponse_MSG_BZGC_HERO_INFO(MemoryStream stream)
{
 MSG_BZGC_HERO_INFO MSG_BZGC_HERO_INFO = ProtoBuf.Serializer.Deserialize<MSG_BZGC_HERO_INFO>(stream);
Parser.Parse(MSG_BZGC_HERO_INFO);
}
public void OnResponse_BATTLE_HERO(MemoryStream stream)
{
 BATTLE_HERO BATTLE_HERO = ProtoBuf.Serializer.Deserialize<BATTLE_HERO>(stream);
Parser.Parse(BATTLE_HERO);
}
public void OnResponse_BATTLE_SKILL(MemoryStream stream)
{
 BATTLE_SKILL BATTLE_SKILL = ProtoBuf.Serializer.Deserialize<BATTLE_SKILL>(stream);
Parser.Parse(BATTLE_SKILL);
}
public void OnResponse_MSG_BZGC_HERO_BASE(MemoryStream stream)
{
 MSG_BZGC_HERO_BASE MSG_BZGC_HERO_BASE = ProtoBuf.Serializer.Deserialize<MSG_BZGC_HERO_BASE>(stream);
Parser.Parse(MSG_BZGC_HERO_BASE);
}
public void OnResponse_MSG_BZGC_HERO_POSITION(MemoryStream stream)
{
 MSG_BZGC_HERO_POSITION MSG_BZGC_HERO_POSITION = ProtoBuf.Serializer.Deserialize<MSG_BZGC_HERO_POSITION>(stream);
Parser.Parse(MSG_BZGC_HERO_POSITION);
}
public void OnResponse_MSG_BZGC_HERO_RELATIVE(MemoryStream stream)
{
 MSG_BZGC_HERO_RELATIVE MSG_BZGC_HERO_RELATIVE = ProtoBuf.Serializer.Deserialize<MSG_BZGC_HERO_RELATIVE>(stream);
Parser.Parse(MSG_BZGC_HERO_RELATIVE);
}
public void OnResponse_BATTLE_NATURE(MemoryStream stream)
{
 BATTLE_NATURE BATTLE_NATURE = ProtoBuf.Serializer.Deserialize<BATTLE_NATURE>(stream);
Parser.Parse(BATTLE_NATURE);
}
public void OnResponse_MSG_BZGC_SKILL_CAST(MemoryStream stream)
{
 MSG_BZGC_SKILL_CAST MSG_BZGC_SKILL_CAST = ProtoBuf.Serializer.Deserialize<MSG_BZGC_SKILL_CAST>(stream);
Parser.Parse(MSG_BZGC_SKILL_CAST);
}
public void OnResponse_MSG_BZGC_DAMGE(MemoryStream stream)
{
 MSG_BZGC_DAMGE MSG_BZGC_DAMGE = ProtoBuf.Serializer.Deserialize<MSG_BZGC_DAMGE>(stream);
Parser.Parse(MSG_BZGC_DAMGE);
}
public void OnResponse_MSG_BZGC_HERO_MOVE(MemoryStream stream)
{
 MSG_BZGC_HERO_MOVE MSG_BZGC_HERO_MOVE = ProtoBuf.Serializer.Deserialize<MSG_BZGC_HERO_MOVE>(stream);
Parser.Parse(MSG_BZGC_HERO_MOVE);
}
public void OnResponse_MSG_BZGC_ENTER_BTTLE_MAP(MemoryStream stream)
{
 MSG_BZGC_ENTER_BTTLE_MAP MSG_BZGC_ENTER_BTTLE_MAP = ProtoBuf.Serializer.Deserialize<MSG_BZGC_ENTER_BTTLE_MAP>(stream);
Parser.Parse(MSG_BZGC_ENTER_BTTLE_MAP);
}
public void OnResponse_MSG_ZGC_LOADING_HERO_INFO(MemoryStream stream)
{
 MSG_ZGC_LOADING_HERO_INFO MSG_ZGC_LOADING_HERO_INFO = ProtoBuf.Serializer.Deserialize<MSG_ZGC_LOADING_HERO_INFO>(stream);
Parser.Parse(MSG_ZGC_LOADING_HERO_INFO);
}
public void OnResponse_MSG_ZGC_LOADING_INFO(MemoryStream stream)
{
 MSG_ZGC_LOADING_INFO MSG_ZGC_LOADING_INFO = ProtoBuf.Serializer.Deserialize<MSG_ZGC_LOADING_INFO>(stream);
Parser.Parse(MSG_ZGC_LOADING_INFO);
}
public void OnResponse_MSG_BZGC_BATTLE_MAP_STATE(MemoryStream stream)
{
 MSG_BZGC_BATTLE_MAP_STATE MSG_BZGC_BATTLE_MAP_STATE = ProtoBuf.Serializer.Deserialize<MSG_BZGC_BATTLE_MAP_STATE>(stream);
Parser.Parse(MSG_BZGC_BATTLE_MAP_STATE);
}
public void OnResponse_MSG_BZGC_SUMMON_STATE(MemoryStream stream)
{
 MSG_BZGC_SUMMON_STATE MSG_BZGC_SUMMON_STATE = ProtoBuf.Serializer.Deserialize<MSG_BZGC_SUMMON_STATE>(stream);
Parser.Parse(MSG_BZGC_SUMMON_STATE);
}
public void OnResponse_MSG_BZGC_SUMMON_INFO(MemoryStream stream)
{
 MSG_BZGC_SUMMON_INFO MSG_BZGC_SUMMON_INFO = ProtoBuf.Serializer.Deserialize<MSG_BZGC_SUMMON_INFO>(stream);
Parser.Parse(MSG_BZGC_SUMMON_INFO);
}
public void OnResponse_MSG_BZGC_SUMMON_ANGLE(MemoryStream stream)
{
 MSG_BZGC_SUMMON_ANGLE MSG_BZGC_SUMMON_ANGLE = ProtoBuf.Serializer.Deserialize<MSG_BZGC_SUMMON_ANGLE>(stream);
Parser.Parse(MSG_BZGC_SUMMON_ANGLE);
}
public void OnResponse_MSG_BZGC_BATTLE_EMOJI(MemoryStream stream)
{
 MSG_BZGC_BATTLE_EMOJI MSG_BZGC_BATTLE_EMOJI = ProtoBuf.Serializer.Deserialize<MSG_BZGC_BATTLE_EMOJI>(stream);
Parser.Parse(MSG_BZGC_BATTLE_EMOJI);
}
public void OnResponse_MSG_BZGC_BATTLE_FPS_INFO(MemoryStream stream)
{
 MSG_BZGC_BATTLE_FPS_INFO MSG_BZGC_BATTLE_FPS_INFO = ProtoBuf.Serializer.Deserialize<MSG_BZGC_BATTLE_FPS_INFO>(stream);
Parser.Parse(MSG_BZGC_BATTLE_FPS_INFO);
}
public void OnResponse_MSG_BZGC_BATTLE_SHOW_INFO(MemoryStream stream)
{
 MSG_BZGC_BATTLE_SHOW_INFO MSG_BZGC_BATTLE_SHOW_INFO = ProtoBuf.Serializer.Deserialize<MSG_BZGC_BATTLE_SHOW_INFO>(stream);
Parser.Parse(MSG_BZGC_BATTLE_SHOW_INFO);
}
public void OnResponse_MSG_BZGC_VEDIO_SUMMON_ANGLE(MemoryStream stream)
{
 MSG_BZGC_VEDIO_SUMMON_ANGLE MSG_BZGC_VEDIO_SUMMON_ANGLE = ProtoBuf.Serializer.Deserialize<MSG_BZGC_VEDIO_SUMMON_ANGLE>(stream);
Parser.Parse(MSG_BZGC_VEDIO_SUMMON_ANGLE);
}
public void OnResponse_MSG_BZGC_VEDIO_BTTLE_MAP(MemoryStream stream)
{
 MSG_BZGC_VEDIO_BTTLE_MAP MSG_BZGC_VEDIO_BTTLE_MAP = ProtoBuf.Serializer.Deserialize<MSG_BZGC_VEDIO_BTTLE_MAP>(stream);
Parser.Parse(MSG_BZGC_VEDIO_BTTLE_MAP);
}
public void OnResponse_MSG_BZGC_BATTLE_RESULT_FPS(MemoryStream stream)
{
 MSG_BZGC_BATTLE_RESULT_FPS MSG_BZGC_BATTLE_RESULT_FPS = ProtoBuf.Serializer.Deserialize<MSG_BZGC_BATTLE_RESULT_FPS>(stream);
Parser.Parse(MSG_BZGC_BATTLE_RESULT_FPS);
}
public void OnResponse_MSG_BZGC_VEDIO_INFO(MemoryStream stream)
{
 MSG_BZGC_VEDIO_INFO MSG_BZGC_VEDIO_INFO = ProtoBuf.Serializer.Deserialize<MSG_BZGC_VEDIO_INFO>(stream);
Parser.Parse(MSG_BZGC_VEDIO_INFO);
}
public void OnResponse_MSG_BZGC_ENTER_TASK_BATTLE(MemoryStream stream)
{
 MSG_BZGC_ENTER_TASK_BATTLE MSG_BZGC_ENTER_TASK_BATTLE = ProtoBuf.Serializer.Deserialize<MSG_BZGC_ENTER_TASK_BATTLE>(stream);
Parser.Parse(MSG_BZGC_ENTER_TASK_BATTLE);
}
public void OnResponse_MSG_BZGC_FINISH_TASK_BATTLE(MemoryStream stream)
{
 MSG_BZGC_FINISH_TASK_BATTLE MSG_BZGC_FINISH_TASK_BATTLE = ProtoBuf.Serializer.Deserialize<MSG_BZGC_FINISH_TASK_BATTLE>(stream);
Parser.Parse(MSG_BZGC_FINISH_TASK_BATTLE);
}
public void OnResponse_MSG_BZGC_ENTER_PERSONAL_BATTLE(MemoryStream stream)
{
 MSG_BZGC_ENTER_PERSONAL_BATTLE MSG_BZGC_ENTER_PERSONAL_BATTLE = ProtoBuf.Serializer.Deserialize<MSG_BZGC_ENTER_PERSONAL_BATTLE>(stream);
Parser.Parse(MSG_BZGC_ENTER_PERSONAL_BATTLE);
}
public void OnResponse_MSG_BZGC_FINISH_PERSONAL_BATTLE(MemoryStream stream)
{
 MSG_BZGC_FINISH_PERSONAL_BATTLE MSG_BZGC_FINISH_PERSONAL_BATTLE = ProtoBuf.Serializer.Deserialize<MSG_BZGC_FINISH_PERSONAL_BATTLE>(stream);
Parser.Parse(MSG_BZGC_FINISH_PERSONAL_BATTLE);
}
public void OnResponse_MSG_ZGC_PLAYER_RANKING(MemoryStream stream)
{
 MSG_ZGC_PLAYER_RANKING MSG_ZGC_PLAYER_RANKING = ProtoBuf.Serializer.Deserialize<MSG_ZGC_PLAYER_RANKING>(stream);
Parser.Parse(MSG_ZGC_PLAYER_RANKING);
}
public void OnResponse_MSG_ZGC_FIND_PLAYER_INFO(MemoryStream stream)
{
 MSG_ZGC_FIND_PLAYER_INFO MSG_ZGC_FIND_PLAYER_INFO = ProtoBuf.Serializer.Deserialize<MSG_ZGC_FIND_PLAYER_INFO>(stream);
Parser.Parse(MSG_ZGC_FIND_PLAYER_INFO);
}
public void OnResponse_MSG_ZGC_LEAVE_MATCHING(MemoryStream stream)
{
 MSG_ZGC_LEAVE_MATCHING MSG_ZGC_LEAVE_MATCHING = ProtoBuf.Serializer.Deserialize<MSG_ZGC_LEAVE_MATCHING>(stream);
Parser.Parse(MSG_ZGC_LEAVE_MATCHING);
}
public void OnResponse_MSG_ZGC_TEAM_FIND_PLAYER_INFO(MemoryStream stream)
{
 MSG_ZGC_TEAM_FIND_PLAYER_INFO MSG_ZGC_TEAM_FIND_PLAYER_INFO = ProtoBuf.Serializer.Deserialize<MSG_ZGC_TEAM_FIND_PLAYER_INFO>(stream);
Parser.Parse(MSG_ZGC_TEAM_FIND_PLAYER_INFO);
}
public void OnResponse_MSG_BZGC_HERO_BATTLE_RESULT_FPS(MemoryStream stream)
{
 MSG_BZGC_HERO_BATTLE_RESULT_FPS MSG_BZGC_HERO_BATTLE_RESULT_FPS = ProtoBuf.Serializer.Deserialize<MSG_BZGC_HERO_BATTLE_RESULT_FPS>(stream);
Parser.Parse(MSG_BZGC_HERO_BATTLE_RESULT_FPS);
}
public void OnResponse_MSG_BZGC_SKILL_BATTLE_RESULT_FPS(MemoryStream stream)
{
 MSG_BZGC_SKILL_BATTLE_RESULT_FPS MSG_BZGC_SKILL_BATTLE_RESULT_FPS = ProtoBuf.Serializer.Deserialize<MSG_BZGC_SKILL_BATTLE_RESULT_FPS>(stream);
Parser.Parse(MSG_BZGC_SKILL_BATTLE_RESULT_FPS);
}
public void OnResponse_MSG_BZGC_PLAYER_BATTLE_RESULT_FPS(MemoryStream stream)
{
 MSG_BZGC_PLAYER_BATTLE_RESULT_FPS MSG_BZGC_PLAYER_BATTLE_RESULT_FPS = ProtoBuf.Serializer.Deserialize<MSG_BZGC_PLAYER_BATTLE_RESULT_FPS>(stream);
Parser.Parse(MSG_BZGC_PLAYER_BATTLE_RESULT_FPS);
}
public void OnResponse_MSG_ZGC_CHALLENGE_PLAYER_REQUEST(MemoryStream stream)
{
 MSG_ZGC_CHALLENGE_PLAYER_REQUEST MSG_ZGC_CHALLENGE_PLAYER_REQUEST = ProtoBuf.Serializer.Deserialize<MSG_ZGC_CHALLENGE_PLAYER_REQUEST>(stream);
Parser.Parse(MSG_ZGC_CHALLENGE_PLAYER_REQUEST);
}
public void OnResponse_MSG_ZGC_CHALLENGE_PLAYER_RESPONSE(MemoryStream stream)
{
 MSG_ZGC_CHALLENGE_PLAYER_RESPONSE MSG_ZGC_CHALLENGE_PLAYER_RESPONSE = ProtoBuf.Serializer.Deserialize<MSG_ZGC_CHALLENGE_PLAYER_RESPONSE>(stream);
Parser.Parse(MSG_ZGC_CHALLENGE_PLAYER_RESPONSE);
}
public void OnResponse_MSG_ZGC_CHALLENGE_PLAYER_CANCEL(MemoryStream stream)
{
 MSG_ZGC_CHALLENGE_PLAYER_CANCEL MSG_ZGC_CHALLENGE_PLAYER_CANCEL = ProtoBuf.Serializer.Deserialize<MSG_ZGC_CHALLENGE_PLAYER_CANCEL>(stream);
Parser.Parse(MSG_ZGC_CHALLENGE_PLAYER_CANCEL);
}
public void OnResponse_MSG_ZGC_PLAYER_INVITE_FRIGHTING(MemoryStream stream)
{
 MSG_ZGC_PLAYER_INVITE_FRIGHTING MSG_ZGC_PLAYER_INVITE_FRIGHTING = ProtoBuf.Serializer.Deserialize<MSG_ZGC_PLAYER_INVITE_FRIGHTING>(stream);
Parser.Parse(MSG_ZGC_PLAYER_INVITE_FRIGHTING);
}
public void OnResponse_MSG_ZGC_INVITE_FRIGHTING_ERROR(MemoryStream stream)
{
 MSG_ZGC_INVITE_FRIGHTING_ERROR MSG_ZGC_INVITE_FRIGHTING_ERROR = ProtoBuf.Serializer.Deserialize<MSG_ZGC_INVITE_FRIGHTING_ERROR>(stream);
Parser.Parse(MSG_ZGC_INVITE_FRIGHTING_ERROR);
}
public void OnResponse_MSG_BZGC_SURRENDER_RESULT(MemoryStream stream)
{
 MSG_BZGC_SURRENDER_RESULT MSG_BZGC_SURRENDER_RESULT = ProtoBuf.Serializer.Deserialize<MSG_BZGC_SURRENDER_RESULT>(stream);
Parser.Parse(MSG_BZGC_SURRENDER_RESULT);
}
public void OnResponse_MSG_BZGC_BATTLE_FPS(MemoryStream stream)
{
 MSG_BZGC_BATTLE_FPS MSG_BZGC_BATTLE_FPS = ProtoBuf.Serializer.Deserialize<MSG_BZGC_BATTLE_FPS>(stream);
Parser.Parse(MSG_BZGC_BATTLE_FPS);
}
public void OnResponse_CastSkillInfo(MemoryStream stream)
{
 CastSkillInfo CastSkillInfo = ProtoBuf.Serializer.Deserialize<CastSkillInfo>(stream);
Parser.Parse(CastSkillInfo);
}
public void OnResponse_MSG_BZGC_PLAYER_BATTLE_FPS(MemoryStream stream)
{
 MSG_BZGC_PLAYER_BATTLE_FPS MSG_BZGC_PLAYER_BATTLE_FPS = ProtoBuf.Serializer.Deserialize<MSG_BZGC_PLAYER_BATTLE_FPS>(stream);
Parser.Parse(MSG_BZGC_PLAYER_BATTLE_FPS);
}
public void OnResponse_MSG_ZGC_HERO_SKIN_INFO(MemoryStream stream)
{
 MSG_ZGC_HERO_SKIN_INFO MSG_ZGC_HERO_SKIN_INFO = ProtoBuf.Serializer.Deserialize<MSG_ZGC_HERO_SKIN_INFO>(stream);
Parser.Parse(MSG_ZGC_HERO_SKIN_INFO);
}
public void OnResponse_MSG_ZGC_HERO_INFO(MemoryStream stream)
{
 MSG_ZGC_HERO_INFO MSG_ZGC_HERO_INFO = ProtoBuf.Serializer.Deserialize<MSG_ZGC_HERO_INFO>(stream);
Parser.Parse(MSG_ZGC_HERO_INFO);
}
public void OnResponse_MSG_ZGC_HERO_LIST(MemoryStream stream)
{
 MSG_ZGC_HERO_LIST MSG_ZGC_HERO_LIST = ProtoBuf.Serializer.Deserialize<MSG_ZGC_HERO_LIST>(stream);
Parser.Parse(MSG_ZGC_HERO_LIST);
}
public void OnResponse_MSG_ZGC_SKILL_INFO(MemoryStream stream)
{
 MSG_ZGC_SKILL_INFO MSG_ZGC_SKILL_INFO = ProtoBuf.Serializer.Deserialize<MSG_ZGC_SKILL_INFO>(stream);
Parser.Parse(MSG_ZGC_SKILL_INFO);
}
public void OnResponse_MSG_ZGC_SKILL_LIST(MemoryStream stream)
{
 MSG_ZGC_SKILL_LIST MSG_ZGC_SKILL_LIST = ProtoBuf.Serializer.Deserialize<MSG_ZGC_SKILL_LIST>(stream);
Parser.Parse(MSG_ZGC_SKILL_LIST);
}
public void OnResponse_MSG_ZGC_UPDATE_HERO_POSITION(MemoryStream stream)
{
 MSG_ZGC_UPDATE_HERO_POSITION MSG_ZGC_UPDATE_HERO_POSITION = ProtoBuf.Serializer.Deserialize<MSG_ZGC_UPDATE_HERO_POSITION>(stream);
Parser.Parse(MSG_ZGC_UPDATE_HERO_POSITION);
}
public void OnResponse_MSG_ZGC_HERO_QUEUE_NAME(MemoryStream stream)
{
 MSG_ZGC_HERO_QUEUE_NAME MSG_ZGC_HERO_QUEUE_NAME = ProtoBuf.Serializer.Deserialize<MSG_ZGC_HERO_QUEUE_NAME>(stream);
Parser.Parse(MSG_ZGC_HERO_QUEUE_NAME);
}
public void OnResponse_MSG_ZGC_CUR_HERO_QUEUE(MemoryStream stream)
{
 MSG_ZGC_CUR_HERO_QUEUE MSG_ZGC_CUR_HERO_QUEUE = ProtoBuf.Serializer.Deserialize<MSG_ZGC_CUR_HERO_QUEUE>(stream);
Parser.Parse(MSG_ZGC_CUR_HERO_QUEUE);
}
public void OnResponse_MSG_ZGC_UPDATE_SKILL_POSITION(MemoryStream stream)
{
 MSG_ZGC_UPDATE_SKILL_POSITION MSG_ZGC_UPDATE_SKILL_POSITION = ProtoBuf.Serializer.Deserialize<MSG_ZGC_UPDATE_SKILL_POSITION>(stream);
Parser.Parse(MSG_ZGC_UPDATE_SKILL_POSITION);
}
public void OnResponse_MSG_ZGC_SKILL_QUEUE_NAME(MemoryStream stream)
{
 MSG_ZGC_SKILL_QUEUE_NAME MSG_ZGC_SKILL_QUEUE_NAME = ProtoBuf.Serializer.Deserialize<MSG_ZGC_SKILL_QUEUE_NAME>(stream);
Parser.Parse(MSG_ZGC_SKILL_QUEUE_NAME);
}
public void OnResponse_MSG_ZGC_CUR_SKILL_QUEUE(MemoryStream stream)
{
 MSG_ZGC_CUR_SKILL_QUEUE MSG_ZGC_CUR_SKILL_QUEUE = ProtoBuf.Serializer.Deserialize<MSG_ZGC_CUR_SKILL_QUEUE>(stream);
Parser.Parse(MSG_ZGC_CUR_SKILL_QUEUE);
}
public void OnResponse_MSG_ZGC_UPGRADE_HERO(MemoryStream stream)
{
 MSG_ZGC_UPGRADE_HERO MSG_ZGC_UPGRADE_HERO = ProtoBuf.Serializer.Deserialize<MSG_ZGC_UPGRADE_HERO>(stream);
Parser.Parse(MSG_ZGC_UPGRADE_HERO);
}
public void OnResponse_MSG_ZGC_UPGRADE_SKILL(MemoryStream stream)
{
 MSG_ZGC_UPGRADE_SKILL MSG_ZGC_UPGRADE_SKILL = ProtoBuf.Serializer.Deserialize<MSG_ZGC_UPGRADE_SKILL>(stream);
Parser.Parse(MSG_ZGC_UPGRADE_SKILL);
}
public void OnResponse_HERO_COMMENT(MemoryStream stream)
{
 HERO_COMMENT HERO_COMMENT = ProtoBuf.Serializer.Deserialize<HERO_COMMENT>(stream);
Parser.Parse(HERO_COMMENT);
}
public void OnResponse_MSG_ZGC_HERO_COMMENT(MemoryStream stream)
{
 MSG_ZGC_HERO_COMMENT MSG_ZGC_HERO_COMMENT = ProtoBuf.Serializer.Deserialize<MSG_ZGC_HERO_COMMENT>(stream);
Parser.Parse(MSG_ZGC_HERO_COMMENT);
}
public void OnResponse_MSG_ZGC_HERO_COMMENT_LIKES(MemoryStream stream)
{
 MSG_ZGC_HERO_COMMENT_LIKES MSG_ZGC_HERO_COMMENT_LIKES = ProtoBuf.Serializer.Deserialize<MSG_ZGC_HERO_COMMENT_LIKES>(stream);
Parser.Parse(MSG_ZGC_HERO_COMMENT_LIKES);
}
public void OnResponse_MSG_ZGC_ADD_HERO_COMMENT(MemoryStream stream)
{
 MSG_ZGC_ADD_HERO_COMMENT MSG_ZGC_ADD_HERO_COMMENT = ProtoBuf.Serializer.Deserialize<MSG_ZGC_ADD_HERO_COMMENT>(stream);
Parser.Parse(MSG_ZGC_ADD_HERO_COMMENT);
}
public void OnResponse_MSG_ZGC_PLAYER_LEVEL(MemoryStream stream)
{
 MSG_ZGC_PLAYER_LEVEL MSG_ZGC_PLAYER_LEVEL = ProtoBuf.Serializer.Deserialize<MSG_ZGC_PLAYER_LEVEL>(stream);
Parser.Parse(MSG_ZGC_PLAYER_LEVEL);
}
public void OnResponse_MSG_ZGC_HERO_COUNT(MemoryStream stream)
{
 MSG_ZGC_HERO_COUNT MSG_ZGC_HERO_COUNT = ProtoBuf.Serializer.Deserialize<MSG_ZGC_HERO_COUNT>(stream);
Parser.Parse(MSG_ZGC_HERO_COUNT);
}
public void OnResponse_MSG_ZGC_SKILL_COUNT(MemoryStream stream)
{
 MSG_ZGC_SKILL_COUNT MSG_ZGC_SKILL_COUNT = ProtoBuf.Serializer.Deserialize<MSG_ZGC_SKILL_COUNT>(stream);
Parser.Parse(MSG_ZGC_SKILL_COUNT);
}
public void OnResponse_MSG_ZGC_CALL_PET(MemoryStream stream)
{
 MSG_ZGC_CALL_PET MSG_ZGC_CALL_PET = ProtoBuf.Serializer.Deserialize<MSG_ZGC_CALL_PET>(stream);
Parser.Parse(MSG_ZGC_CALL_PET);
}
public void OnResponse_MSG_ZGC_UPDATE_HEROS(MemoryStream stream)
{
 MSG_ZGC_UPDATE_HEROS MSG_ZGC_UPDATE_HEROS = ProtoBuf.Serializer.Deserialize<MSG_ZGC_UPDATE_HEROS>(stream);
Parser.Parse(MSG_ZGC_UPDATE_HEROS);
}
public void OnResponse_MSG_ZGC_UPDATE_SKILLS(MemoryStream stream)
{
 MSG_ZGC_UPDATE_SKILLS MSG_ZGC_UPDATE_SKILLS = ProtoBuf.Serializer.Deserialize<MSG_ZGC_UPDATE_SKILLS>(stream);
Parser.Parse(MSG_ZGC_UPDATE_SKILLS);
}
public void OnResponse_MSG_ZGC_USE_HERO_SKIN(MemoryStream stream)
{
 MSG_ZGC_USE_HERO_SKIN MSG_ZGC_USE_HERO_SKIN = ProtoBuf.Serializer.Deserialize<MSG_ZGC_USE_HERO_SKIN>(stream);
Parser.Parse(MSG_ZGC_USE_HERO_SKIN);
}
public void OnResponse_MSG_ZGC_PLAYER_LADDER_LEVEL(MemoryStream stream)
{
 MSG_ZGC_PLAYER_LADDER_LEVEL MSG_ZGC_PLAYER_LADDER_LEVEL = ProtoBuf.Serializer.Deserialize<MSG_ZGC_PLAYER_LADDER_LEVEL>(stream);
Parser.Parse(MSG_ZGC_PLAYER_LADDER_LEVEL);
}
public void OnResponse_MSG_ZGC_BUY_HERO_SKIN(MemoryStream stream)
{
 MSG_ZGC_BUY_HERO_SKIN MSG_ZGC_BUY_HERO_SKIN = ProtoBuf.Serializer.Deserialize<MSG_ZGC_BUY_HERO_SKIN>(stream);
Parser.Parse(MSG_ZGC_BUY_HERO_SKIN);
}
public void OnResponse_MSG_ZGC_TASK_LIST(MemoryStream stream)
{
 MSG_ZGC_TASK_LIST MSG_ZGC_TASK_LIST = ProtoBuf.Serializer.Deserialize<MSG_ZGC_TASK_LIST>(stream);
Parser.Parse(MSG_ZGC_TASK_LIST);
}
public void OnResponse_MSG_ZGC_TASK_INFO(MemoryStream stream)
{
 MSG_ZGC_TASK_INFO MSG_ZGC_TASK_INFO = ProtoBuf.Serializer.Deserialize<MSG_ZGC_TASK_INFO>(stream);
Parser.Parse(MSG_ZGC_TASK_INFO);
}
public void OnResponse_MSG_ZGC_TASK_CHANGE(MemoryStream stream)
{
 MSG_ZGC_TASK_CHANGE MSG_ZGC_TASK_CHANGE = ProtoBuf.Serializer.Deserialize<MSG_ZGC_TASK_CHANGE>(stream);
Parser.Parse(MSG_ZGC_TASK_CHANGE);
}
public void OnResponse_MSG_ZGC_GET_TASK_RESULT(MemoryStream stream)
{
 MSG_ZGC_GET_TASK_RESULT MSG_ZGC_GET_TASK_RESULT = ProtoBuf.Serializer.Deserialize<MSG_ZGC_GET_TASK_RESULT>(stream);
Parser.Parse(MSG_ZGC_GET_TASK_RESULT);
}
public void OnResponse_MSG_ZGC_TASK_COLLECT(MemoryStream stream)
{
 MSG_ZGC_TASK_COLLECT MSG_ZGC_TASK_COLLECT = ProtoBuf.Serializer.Deserialize<MSG_ZGC_TASK_COLLECT>(stream);
Parser.Parse(MSG_ZGC_TASK_COLLECT);
}
public void OnResponse_MSG_ZGC_TASK_COMPLETE(MemoryStream stream)
{
 MSG_ZGC_TASK_COMPLETE MSG_ZGC_TASK_COMPLETE = ProtoBuf.Serializer.Deserialize<MSG_ZGC_TASK_COMPLETE>(stream);
Parser.Parse(MSG_ZGC_TASK_COMPLETE);
}
public void OnResponse_MSG_ZGC_EMAIL_REMIND(MemoryStream stream)
{
 MSG_ZGC_EMAIL_REMIND MSG_ZGC_EMAIL_REMIND = ProtoBuf.Serializer.Deserialize<MSG_ZGC_EMAIL_REMIND>(stream);
Parser.Parse(MSG_ZGC_EMAIL_REMIND);
}
public void OnResponse_MSG_ZGC_EMAIL_OPENE_BOX(MemoryStream stream)
{
 MSG_ZGC_EMAIL_OPENE_BOX MSG_ZGC_EMAIL_OPENE_BOX = ProtoBuf.Serializer.Deserialize<MSG_ZGC_EMAIL_OPENE_BOX>(stream);
Parser.Parse(MSG_ZGC_EMAIL_OPENE_BOX);
}
public void OnResponse_MSG_ZGC_EMAIL_ITEM(MemoryStream stream)
{
 MSG_ZGC_EMAIL_ITEM MSG_ZGC_EMAIL_ITEM = ProtoBuf.Serializer.Deserialize<MSG_ZGC_EMAIL_ITEM>(stream);
Parser.Parse(MSG_ZGC_EMAIL_ITEM);
}
public void OnResponse_MSG_ZGC_EMAIL_READ(MemoryStream stream)
{
 MSG_ZGC_EMAIL_READ MSG_ZGC_EMAIL_READ = ProtoBuf.Serializer.Deserialize<MSG_ZGC_EMAIL_READ>(stream);
Parser.Parse(MSG_ZGC_EMAIL_READ);
}
public void OnResponse_MSG_ZGC_ATTACHMENT_PICKUP(MemoryStream stream)
{
 MSG_ZGC_ATTACHMENT_PICKUP MSG_ZGC_ATTACHMENT_PICKUP = ProtoBuf.Serializer.Deserialize<MSG_ZGC_ATTACHMENT_PICKUP>(stream);
Parser.Parse(MSG_ZGC_ATTACHMENT_PICKUP);
}
public void OnResponse_MSG_ZGC_CHAT_PLAYER_INFO(MemoryStream stream)
{
 MSG_ZGC_CHAT_PLAYER_INFO MSG_ZGC_CHAT_PLAYER_INFO = ProtoBuf.Serializer.Deserialize<MSG_ZGC_CHAT_PLAYER_INFO>(stream);
Parser.Parse(MSG_ZGC_CHAT_PLAYER_INFO);
}
public void OnResponse_MSG_ZGC_CHAT_WORDS(MemoryStream stream)
{
 MSG_ZGC_CHAT_WORDS MSG_ZGC_CHAT_WORDS = ProtoBuf.Serializer.Deserialize<MSG_ZGC_CHAT_WORDS>(stream);
Parser.Parse(MSG_ZGC_CHAT_WORDS);
}
public void OnResponse_MSG_ZGC_PERSON_CHAT_WORDS(MemoryStream stream)
{
 MSG_ZGC_PERSON_CHAT_WORDS MSG_ZGC_PERSON_CHAT_WORDS = ProtoBuf.Serializer.Deserialize<MSG_ZGC_PERSON_CHAT_WORDS>(stream);
Parser.Parse(MSG_ZGC_PERSON_CHAT_WORDS);
}
public void OnResponse_MSG_GC_CHANGE_WORLD_ROOM(MemoryStream stream)
{
 MSG_GC_CHANGE_WORLD_ROOM MSG_GC_CHANGE_WORLD_ROOM = ProtoBuf.Serializer.Deserialize<MSG_GC_CHANGE_WORLD_ROOM>(stream);
Parser.Parse(MSG_GC_CHANGE_WORLD_ROOM);
}
public void OnResponse_MSG_CMGC_WORLD_ROOM_INFO(MemoryStream stream)
{
 MSG_CMGC_WORLD_ROOM_INFO MSG_CMGC_WORLD_ROOM_INFO = ProtoBuf.Serializer.Deserialize<MSG_CMGC_WORLD_ROOM_INFO>(stream);
Parser.Parse(MSG_CMGC_WORLD_ROOM_INFO);
}
public void OnResponse_MSG_CMGC_GET_WORLD_ROOM_LIST(MemoryStream stream)
{
 MSG_CMGC_GET_WORLD_ROOM_LIST MSG_CMGC_GET_WORLD_ROOM_LIST = ProtoBuf.Serializer.Deserialize<MSG_CMGC_GET_WORLD_ROOM_LIST>(stream);
Parser.Parse(MSG_CMGC_GET_WORLD_ROOM_LIST);
}
public void OnResponse_MSG_ZGC_CHAT_TRUMPET(MemoryStream stream)
{
 MSG_ZGC_CHAT_TRUMPET MSG_ZGC_CHAT_TRUMPET = ProtoBuf.Serializer.Deserialize<MSG_ZGC_CHAT_TRUMPET>(stream);
Parser.Parse(MSG_ZGC_CHAT_TRUMPET);
}
public void OnResponse_MSG_ZGC_CHAT_TRUMPET_RESULT(MemoryStream stream)
{
 MSG_ZGC_CHAT_TRUMPET_RESULT MSG_ZGC_CHAT_TRUMPET_RESULT = ProtoBuf.Serializer.Deserialize<MSG_ZGC_CHAT_TRUMPET_RESULT>(stream);
Parser.Parse(MSG_ZGC_CHAT_TRUMPET_RESULT);
}
public void OnResponse_MSG_GC_ANNOUNCEMENT(MemoryStream stream)
{
 MSG_GC_ANNOUNCEMENT MSG_GC_ANNOUNCEMENT = ProtoBuf.Serializer.Deserialize<MSG_GC_ANNOUNCEMENT>(stream);
Parser.Parse(MSG_GC_ANNOUNCEMENT);
}
public void OnResponse_MSG_ZGC_NEARBY_EMOJI(MemoryStream stream)
{
 MSG_ZGC_NEARBY_EMOJI MSG_ZGC_NEARBY_EMOJI = ProtoBuf.Serializer.Deserialize<MSG_ZGC_NEARBY_EMOJI>(stream);
Parser.Parse(MSG_ZGC_NEARBY_EMOJI);
}
public void OnResponse_MSG_ZGC_TIP_OFF(MemoryStream stream)
{
 MSG_ZGC_TIP_OFF MSG_ZGC_TIP_OFF = ProtoBuf.Serializer.Deserialize<MSG_ZGC_TIP_OFF>(stream);
Parser.Parse(MSG_ZGC_TIP_OFF);
}
public void OnResponse_MSG_ZGC_CHAT_BROADCAST(MemoryStream stream)
{
 MSG_ZGC_CHAT_BROADCAST MSG_ZGC_CHAT_BROADCAST = ProtoBuf.Serializer.Deserialize<MSG_ZGC_CHAT_BROADCAST>(stream);
Parser.Parse(MSG_ZGC_CHAT_BROADCAST);
}
public void OnResponse_MSG_GC_NEARBY_ROOM(MemoryStream stream)
{
 MSG_GC_NEARBY_ROOM MSG_GC_NEARBY_ROOM = ProtoBuf.Serializer.Deserialize<MSG_GC_NEARBY_ROOM>(stream);
Parser.Parse(MSG_GC_NEARBY_ROOM);
}
public void OnResponse_MSG_ZGC_SILENCE(MemoryStream stream)
{
 MSG_ZGC_SILENCE MSG_ZGC_SILENCE = ProtoBuf.Serializer.Deserialize<MSG_ZGC_SILENCE>(stream);
Parser.Parse(MSG_ZGC_SILENCE);
}
public void OnResponse_MSG_ZGC_ACTIVITY_CHAT_BUBBLE(MemoryStream stream)
{
 MSG_ZGC_ACTIVITY_CHAT_BUBBLE MSG_ZGC_ACTIVITY_CHAT_BUBBLE = ProtoBuf.Serializer.Deserialize<MSG_ZGC_ACTIVITY_CHAT_BUBBLE>(stream);
Parser.Parse(MSG_ZGC_ACTIVITY_CHAT_BUBBLE);
}
public void OnResponse_MSG_ZGC_UPLOAD_PHOTO(MemoryStream stream)
{
 MSG_ZGC_UPLOAD_PHOTO MSG_ZGC_UPLOAD_PHOTO = ProtoBuf.Serializer.Deserialize<MSG_ZGC_UPLOAD_PHOTO>(stream);
Parser.Parse(MSG_ZGC_UPLOAD_PHOTO);
}
public void OnResponse_MSG_ZGC_REMOVE_PHOTO(MemoryStream stream)
{
 MSG_ZGC_REMOVE_PHOTO MSG_ZGC_REMOVE_PHOTO = ProtoBuf.Serializer.Deserialize<MSG_ZGC_REMOVE_PHOTO>(stream);
Parser.Parse(MSG_ZGC_REMOVE_PHOTO);
}
public void OnResponse_MSG_ZGC_PHOTO_LIST(MemoryStream stream)
{
 MSG_ZGC_PHOTO_LIST MSG_ZGC_PHOTO_LIST = ProtoBuf.Serializer.Deserialize<MSG_ZGC_PHOTO_LIST>(stream);
Parser.Parse(MSG_ZGC_PHOTO_LIST);
}
public void OnResponse_MSG_ZGC_LIKE_SPACE(MemoryStream stream)
{
 MSG_ZGC_LIKE_SPACE MSG_ZGC_LIKE_SPACE = ProtoBuf.Serializer.Deserialize<MSG_ZGC_LIKE_SPACE>(stream);
Parser.Parse(MSG_ZGC_LIKE_SPACE);
}
public void OnResponse_POP_RANK_PLAYER(MemoryStream stream)
{
 POP_RANK_PLAYER POP_RANK_PLAYER = ProtoBuf.Serializer.Deserialize<POP_RANK_PLAYER>(stream);
Parser.Parse(POP_RANK_PLAYER);
}
public void OnResponse_MSG_ZGC_POP_RANK(MemoryStream stream)
{
 MSG_ZGC_POP_RANK MSG_ZGC_POP_RANK = ProtoBuf.Serializer.Deserialize<MSG_ZGC_POP_RANK>(stream);
Parser.Parse(MSG_ZGC_POP_RANK);
}
public void OnResponse_MSG_ZGC_SHOP_ITEM(MemoryStream stream)
{
 MSG_ZGC_SHOP_ITEM MSG_ZGC_SHOP_ITEM = ProtoBuf.Serializer.Deserialize<MSG_ZGC_SHOP_ITEM>(stream);
Parser.Parse(MSG_ZGC_SHOP_ITEM);
}
public void OnResponse_MSG_ZGC_SHOP_LIST(MemoryStream stream)
{
 MSG_ZGC_SHOP_LIST MSG_ZGC_SHOP_LIST = ProtoBuf.Serializer.Deserialize<MSG_ZGC_SHOP_LIST>(stream);
Parser.Parse(MSG_ZGC_SHOP_LIST);
}
public void OnResponse_MSG_ZGC_SHOP_BUY_RESULT(MemoryStream stream)
{
 MSG_ZGC_SHOP_BUY_RESULT MSG_ZGC_SHOP_BUY_RESULT = ProtoBuf.Serializer.Deserialize<MSG_ZGC_SHOP_BUY_RESULT>(stream);
Parser.Parse(MSG_ZGC_SHOP_BUY_RESULT);
}
public void OnResponse_MSG_ZGC_SHOP_GET_SSR(MemoryStream stream)
{
 MSG_ZGC_SHOP_GET_SSR MSG_ZGC_SHOP_GET_SSR = ProtoBuf.Serializer.Deserialize<MSG_ZGC_SHOP_GET_SSR>(stream);
Parser.Parse(MSG_ZGC_SHOP_GET_SSR);
}
public void OnResponse_VEDIO_HERO(MemoryStream stream)
{
 VEDIO_HERO VEDIO_HERO = ProtoBuf.Serializer.Deserialize<VEDIO_HERO>(stream);
Parser.Parse(VEDIO_HERO);
}
public void OnResponse_VEDIO_SKILL(MemoryStream stream)
{
 VEDIO_SKILL VEDIO_SKILL = ProtoBuf.Serializer.Deserialize<VEDIO_SKILL>(stream);
Parser.Parse(VEDIO_SKILL);
}
public void OnResponse_VEDIO_PLAYER(MemoryStream stream)
{
 VEDIO_PLAYER VEDIO_PLAYER = ProtoBuf.Serializer.Deserialize<VEDIO_PLAYER>(stream);
Parser.Parse(VEDIO_PLAYER);
}
public void OnResponse_MSG_ZGC_VEDIO_INFO(MemoryStream stream)
{
 MSG_ZGC_VEDIO_INFO MSG_ZGC_VEDIO_INFO = ProtoBuf.Serializer.Deserialize<MSG_ZGC_VEDIO_INFO>(stream);
Parser.Parse(MSG_ZGC_VEDIO_INFO);
}
public void OnResponse_MSG_ZGC_BATTLE_VEDIO_LIST(MemoryStream stream)
{
 MSG_ZGC_BATTLE_VEDIO_LIST MSG_ZGC_BATTLE_VEDIO_LIST = ProtoBuf.Serializer.Deserialize<MSG_ZGC_BATTLE_VEDIO_LIST>(stream);
Parser.Parse(MSG_ZGC_BATTLE_VEDIO_LIST);
}
public void OnResponse_MSG_ZGC_CHAT_VEDIO(MemoryStream stream)
{
 MSG_ZGC_CHAT_VEDIO MSG_ZGC_CHAT_VEDIO = ProtoBuf.Serializer.Deserialize<MSG_ZGC_CHAT_VEDIO>(stream);
Parser.Parse(MSG_ZGC_CHAT_VEDIO);
}
public void OnResponse_MSG_ZGC_CHANGE_CHANNEL(MemoryStream stream)
{
 MSG_ZGC_CHANGE_CHANNEL MSG_ZGC_CHANGE_CHANNEL = ProtoBuf.Serializer.Deserialize<MSG_ZGC_CHANGE_CHANNEL>(stream);
Parser.Parse(MSG_ZGC_CHANGE_CHANNEL);
}
public void OnResponse_MSG_ZGC_RECHARGE_HISTORY(MemoryStream stream)
{
 MSG_ZGC_RECHARGE_HISTORY MSG_ZGC_RECHARGE_HISTORY = ProtoBuf.Serializer.Deserialize<MSG_ZGC_RECHARGE_HISTORY>(stream);
Parser.Parse(MSG_ZGC_RECHARGE_HISTORY);
}
public void OnResponse_MSG_ZGC_RECHARGE_INFO(MemoryStream stream)
{
 MSG_ZGC_RECHARGE_INFO MSG_ZGC_RECHARGE_INFO = ProtoBuf.Serializer.Deserialize<MSG_ZGC_RECHARGE_INFO>(stream);
Parser.Parse(MSG_ZGC_RECHARGE_INFO);
}
}
}
