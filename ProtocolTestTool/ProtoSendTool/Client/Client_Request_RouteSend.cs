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
public bool RouteSend(string className,object msg)
{
 switch (className)
{

case "MSG_CG_ITEM_BUY":
return Net.Send((MSG_CG_ITEM_BUY)msg);

case "MSG_CG_CREATE_CHARACTER":
return Net.Send((MSG_CG_CREATE_CHARACTER)msg);

case "MSG_CG_CHARACTER_MOVE":
return Net.Send((MSG_CG_CHARACTER_MOVE)msg);

case "MSG_CG_MOVE_ZONE":
return Net.Send((MSG_CG_MOVE_ZONE)msg);

case "MSG_CG_AUTOPATHFINDING":
return Net.Send((MSG_CG_AUTOPATHFINDING)msg);

case "MSG_CG_GEOGRAPHY":
return Net.Send((MSG_CG_GEOGRAPHY)msg);

case "MSG_CG_RECONNECT_LOGIN":
return Net.Send((MSG_CG_RECONNECT_LOGIN)msg);

case "MSG_CG_CROSS_PORTAL":
return Net.Send((MSG_CG_CROSS_PORTAL)msg);

case "MSG_CG_OPEN_CHEST":
return Net.Send((MSG_CG_OPEN_CHEST)msg);

case "MSG_CG_UNLOCK_CHEST":
return Net.Send((MSG_CG_UNLOCK_CHEST)msg);

case "MSG_CG_ITEM_USE":
return Net.Send((MSG_CG_ITEM_USE)msg);

case "MSG_CG_ITEM_SELL":
return Net.Send((MSG_CG_ITEM_SELL)msg);

case "MSG_CG_FRIEND_SEARCH":
return Net.Send((MSG_CG_FRIEND_SEARCH)msg);

case "MSG_CG_FRIEND_ADD_REQUEST":
return Net.Send((MSG_CG_FRIEND_ADD_REQUEST)msg);

case "MSG_CG_FRIEND_ADD_RESPONSE":
return Net.Send((MSG_CG_FRIEND_ADD_RESPONSE)msg);

case "MSG_CG_FRIEND_DELETE":
return Net.Send((MSG_CG_FRIEND_DELETE)msg);

case "MSG_CG_FRIEND_REQUEST_LIST":
return Net.Send((MSG_CG_FRIEND_REQUEST_LIST)msg);

case "MSG_CG_FRIEND_RECENT_LIST":
return Net.Send((MSG_CG_FRIEND_RECENT_LIST)msg);

case "MSG_CG_FRIEND_BLACK_LIST":
return Net.Send((MSG_CG_FRIEND_BLACK_LIST)msg);

case "MSG_CG_FRIEND_LIST":
return Net.Send((MSG_CG_FRIEND_LIST)msg);

case "MSG_CG_FRIEND_BLACK_ADD":
return Net.Send((MSG_CG_FRIEND_BLACK_ADD)msg);

case "MSG_CG_FRIEND_BLACK_DEL":
return Net.Send((MSG_CG_FRIEND_BLACK_DEL)msg);

case "MSG_CG_FRIEND_RECOMMEND":
return Net.Send((MSG_CG_FRIEND_RECOMMEND)msg);

case "MSG_CG_SHOW_CHARACTER":
return Net.Send((MSG_CG_SHOW_CHARACTER)msg);

case "MSG_CG_CHANGE_NAME":
return Net.Send((MSG_CG_CHANGE_NAME)msg);

case "MSG_CG_SHOW_FACEICON":
return Net.Send((MSG_CG_SHOW_FACEICON)msg);

case "MSG_CG_SHOW_FACEJPG":
return Net.Send((MSG_CG_SHOW_FACEJPG)msg);

case "MSG_CG_SET_SEX":
return Net.Send((MSG_CG_SET_SEX)msg);

case "MSG_CG_SET_BIRTHDAY":
return Net.Send((MSG_CG_SET_BIRTHDAY)msg);

case "MSG_CG_SET_SIGNATURE":
return Net.Send((MSG_CG_SET_SIGNATURE)msg);

case "MSG_CG_SHOW_VOICE":
return Net.Send((MSG_CG_SHOW_VOICE)msg);

case "MSG_CG_PRESENT_GIFT":
return Net.Send((MSG_CG_PRESENT_GIFT)msg);

case "MSG_CG_GET_GIFTRECORD":
return Net.Send((MSG_CG_GET_GIFTRECORD)msg);

case "MSG_CG_SET_SOCIAL_NUM":
return Net.Send((MSG_CG_SET_SOCIAL_NUM)msg);

case "MSG_CG_GET_SOCIAL_NUM":
return Net.Send((MSG_CG_GET_SOCIAL_NUM)msg);

case "MSG_CG_SHOW_CUR_CARDQUEUE":
return Net.Send((MSG_CG_SHOW_CUR_CARDQUEUE)msg);

case "MSG_CG_SHOW_CAREER":
return Net.Send((MSG_CG_SHOW_CAREER)msg);

case "MSG_CG_GET_RANKING_FRIEND_LIST":
return Net.Send((MSG_CG_GET_RANKING_FRIEND_LIST)msg);

case "MSG_CG_GET_RANKING_ALL_LIST":
return Net.Send((MSG_CG_GET_RANKING_ALL_LIST)msg);

case "MSG_CG_GET_RANKING_NEARBY_LIST":
return Net.Send((MSG_CG_GET_RANKING_NEARBY_LIST)msg);

case "MSG_CG_CREATE_GUILD":
return Net.Send((MSG_CG_CREATE_GUILD)msg);

case "MSG_CG_MATCHING_BATTLE":
return Net.Send((MSG_CG_MATCHING_BATTLE)msg);

case "MSG_CG_LEAVE_BATTLE_MAP":
return Net.Send((MSG_CG_LEAVE_BATTLE_MAP)msg);

case "MSG_CG_CHALLENGE_PLAYER":
return Net.Send((MSG_CG_CHALLENGE_PLAYER)msg);

case "MSG_CG_CHALLENGE_PLAYER_REQUEST":
return Net.Send((MSG_CG_CHALLENGE_PLAYER_REQUEST)msg);

case "MSG_CG_CHALLENGE_PLAYER_RESPONSE":
return Net.Send((MSG_CG_CHALLENGE_PLAYER_RESPONSE)msg);

case "MSG_CG_CHALLENGE_PLAYER_CANCEL":
return Net.Send((MSG_CG_CHALLENGE_PLAYER_CANCEL)msg);

case "MSG_CG_BATTLE_MAP_STATE_END":
return Net.Send((MSG_CG_BATTLE_MAP_STATE_END)msg);

case "MSG_CG_BATTLE_GET_MAP_STATE":
return Net.Send((MSG_CG_BATTLE_GET_MAP_STATE)msg);

case "MSG_CG_SYNC_SUMMON_ANIM":
return Net.Send((MSG_CG_SYNC_SUMMON_ANIM)msg);

case "MSG_CG_SYNC_SUMMON_ANGLE":
return Net.Send((MSG_CG_SYNC_SUMMON_ANGLE)msg);

case "MSG_CG_SYNC_SUMMON_INFO":
return Net.Send((MSG_CG_SYNC_SUMMON_INFO)msg);

case "MSG_CG_BATTLE_SKILL":
return Net.Send((MSG_CG_BATTLE_SKILL)msg);

case "MSG_CG_VEDIO_INFO":
return Net.Send((MSG_CG_VEDIO_INFO)msg);

case "MSG_CG_ENTER_TASK_BATTLE":
return Net.Send((MSG_CG_ENTER_TASK_BATTLE)msg);

case "MSG_CG_FINISH_TASK_BATTLE":
return Net.Send((MSG_CG_FINISH_TASK_BATTLE)msg);

case "MSG_CG_ENTER_PERSONAL_BATTLE":
return Net.Send((MSG_CG_ENTER_PERSONAL_BATTLE)msg);

case "MSG_CG_FINISH_PERSONAL_BATTLE":
return Net.Send((MSG_CG_FINISH_PERSONAL_BATTLE)msg);

case "MSG_CG_TEAM_CHALLENGE":
return Net.Send((MSG_CG_TEAM_CHALLENGE)msg);

case "MSG_CG_LEAVE_MATCHING":
return Net.Send((MSG_CG_LEAVE_MATCHING)msg);

case "MSG_CG_SYNC_BATTLE_EMOJI":
return Net.Send((MSG_CG_SYNC_BATTLE_EMOJI)msg);

case "MSG_CG_GET_SEASON_REWARD":
return Net.Send((MSG_CG_GET_SEASON_REWARD)msg);

case "MSG_CG_INVITE_FRIEND_FRIGHTING":
return Net.Send((MSG_CG_INVITE_FRIEND_FRIGHTING)msg);

case "MSG_CG_AGREE_INVITE_FRIGHTING":
return Net.Send((MSG_CG_AGREE_INVITE_FRIGHTING)msg);

case "MSG_CG_SURRENDER":
return Net.Send((MSG_CG_SURRENDER)msg);

case "MSG_CG_UPDATE_HERO_POSITION":
return Net.Send((MSG_CG_UPDATE_HERO_POSITION)msg);

case "MSG_CG_HERO_QUEUE_NAME":
return Net.Send((MSG_CG_HERO_QUEUE_NAME)msg);

case "MSG_CG_CUR_HERO_QUEUE":
return Net.Send((MSG_CG_CUR_HERO_QUEUE)msg);

case "MSG_CG_SKILL_QUEUE_NAME":
return Net.Send((MSG_CG_SKILL_QUEUE_NAME)msg);

case "MSG_CG_CUR_SKILL_QUEUE":
return Net.Send((MSG_CG_CUR_SKILL_QUEUE)msg);

case "MSG_CG_UPGRADE_HERO":
return Net.Send((MSG_CG_UPGRADE_HERO)msg);

case "MSG_CG_UPGRADE_SKILL":
return Net.Send((MSG_CG_UPGRADE_SKILL)msg);

case "MSG_CG_HERO_COMMENT":
return Net.Send((MSG_CG_HERO_COMMENT)msg);

case "MSG_CG_HERO_COMMENT_LIKES":
return Net.Send((MSG_CG_HERO_COMMENT_LIKES)msg);

case "MSG_CG_ADD_HERO_COMMENT":
return Net.Send((MSG_CG_ADD_HERO_COMMENT)msg);

case "MSG_CG_CALL_PET":
return Net.Send((MSG_CG_CALL_PET)msg);

case "MSG_CG_USE_HERO_SKIN":
return Net.Send((MSG_CG_USE_HERO_SKIN)msg);

case "MSG_CG_BUY_HERO_SKIN":
return Net.Send((MSG_CG_BUY_HERO_SKIN)msg);

case "MSG_CG_UPDATE_SKILL_POSITION":
return Net.Send((MSG_CG_UPDATE_SKILL_POSITION)msg);

case "MSG_CG_TASK_COMPLETE":
return Net.Send((MSG_CG_TASK_COMPLETE)msg);

case "MSG_CG_OPENE_HERO_TASK":
return Net.Send((MSG_CG_OPENE_HERO_TASK)msg);

case "MSG_CG_OPENE_EMAIL_TASK":
return Net.Send((MSG_CG_OPENE_EMAIL_TASK)msg);

case "MSG_CG_UNLOCK_HERO_STORY":
return Net.Send((MSG_CG_UNLOCK_HERO_STORY)msg);

case "MSG_CG_TASK_COLLECT":
return Net.Send((MSG_CG_TASK_COLLECT)msg);

case "MSG_CG_TASK_SELECT":
return Net.Send((MSG_CG_TASK_SELECT)msg);

case "MSG_CG_TASK_MAKE":
return Net.Send((MSG_CG_TASK_MAKE)msg);

case "MSG_CG_EMAIL_READ":
return Net.Send((MSG_CG_EMAIL_READ)msg);

case "MSG_CG_PICKUP_ATTACHMENT":
return Net.Send((MSG_CG_PICKUP_ATTACHMENT)msg);

case "MSG_CG_EMAIL_OPENE_BOX":
return Net.Send((MSG_CG_EMAIL_OPENE_BOX)msg);

case "MSG_CG_CHAT_EMOJI":
return Net.Send((MSG_CG_CHAT_EMOJI)msg);

case "MSG_CG_CHAT_WORDS":
return Net.Send((MSG_CG_CHAT_WORDS)msg);

case "MSG_CG_CHANGE_WORLD_ROOM":
return Net.Send((MSG_CG_CHANGE_WORLD_ROOM)msg);

case "MSG_CG_GET_WORLD_ROOM_LIST":
return Net.Send((MSG_CG_GET_WORLD_ROOM_LIST)msg);

case "MSG_CG_CHAT_TRUMPET":
return Net.Send((MSG_CG_CHAT_TRUMPET)msg);

case "MSG_CG_CHAT_REPORT":
return Net.Send((MSG_CG_CHAT_REPORT)msg);

case "MSG_CG_NEARBY_EMOJI":
return Net.Send((MSG_CG_NEARBY_EMOJI)msg);

case "MSG_CG_TIP_OFF":
return Net.Send((MSG_CG_TIP_OFF)msg);

case "MSG_CG_ACTIVITY_CHAT_BUBBLE":
return Net.Send((MSG_CG_ACTIVITY_CHAT_BUBBLE)msg);

case "MSG_CG_UPLOAD_PHOTO":
return Net.Send((MSG_CG_UPLOAD_PHOTO)msg);

case "MSG_CG_REMOVE_PHOTO":
return Net.Send((MSG_CG_REMOVE_PHOTO)msg);

case "MSG_CG_PHOTO_LIST":
return Net.Send((MSG_CG_PHOTO_LIST)msg);

case "MSG_CG_LIKE_SPACE":
return Net.Send((MSG_CG_LIKE_SPACE)msg);

case "MSG_CG_POP_RANK":
return Net.Send((MSG_CG_POP_RANK)msg);

case "MSG_CG_SHOP_BUY_ITEM":
return Net.Send((MSG_CG_SHOP_BUY_ITEM)msg);

case "MSG_CG_SHOP_GET_SSR":
return Net.Send((MSG_CG_SHOP_GET_SSR)msg);

case "MSG_CG_BATTLE_VEDIO_LIST":
return Net.Send((MSG_CG_BATTLE_VEDIO_LIST)msg);

case "MSG_CG_CHANGE_CHANNEL":
return Net.Send((MSG_CG_CHANGE_CHANNEL)msg);

case "MSG_CG_OPEN_BATTLE_VEDIO":
return Net.Send((MSG_CG_OPEN_BATTLE_VEDIO)msg);

case "MSG_CG_LEAVE_BATTLE_VEDIO":
return Net.Send((MSG_CG_LEAVE_BATTLE_VEDIO)msg);

case "MSG_CG_CHAT_VEDIO":
return Net.Send((MSG_CG_CHAT_VEDIO)msg);

case "MSG_CG_WATCHED_VEDIO":
return Net.Send((MSG_CG_WATCHED_VEDIO)msg);

case "MSG_CG_SAVE_ORDER":
return Net.Send((MSG_CG_SAVE_ORDER)msg);

case "MSG_CG_GET_RECHARGE_HISTORY":
return Net.Send((MSG_CG_GET_RECHARGE_HISTORY)msg);

case "MSG_CG_DELETE_RECHARGE_HISTORY":
return Net.Send((MSG_CG_DELETE_RECHARGE_HISTORY)msg);

default:
return false;
}
}
}
}
