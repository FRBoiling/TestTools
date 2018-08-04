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
public object RouteType(string className)
{
 switch (className)
{

case "MSG_CG_ITEM_BUY":
return typeof(MSG_CG_ITEM_BUY);

case "MSG_CG_CREATE_CHARACTER":
return typeof(MSG_CG_CREATE_CHARACTER);

case "MSG_CG_CHARACTER_MOVE":
return typeof(MSG_CG_CHARACTER_MOVE);

case "MSG_CG_MOVE_ZONE":
return typeof(MSG_CG_MOVE_ZONE);

case "MSG_CG_AUTOPATHFINDING":
return typeof(MSG_CG_AUTOPATHFINDING);

case "MSG_CG_GEOGRAPHY":
return typeof(MSG_CG_GEOGRAPHY);

case "MSG_CG_RECONNECT_LOGIN":
return typeof(MSG_CG_RECONNECT_LOGIN);

case "MSG_CG_CROSS_PORTAL":
return typeof(MSG_CG_CROSS_PORTAL);

case "MSG_CG_OPEN_CHEST":
return typeof(MSG_CG_OPEN_CHEST);

case "MSG_CG_UNLOCK_CHEST":
return typeof(MSG_CG_UNLOCK_CHEST);

case "MSG_CG_ITEM_USE":
return typeof(MSG_CG_ITEM_USE);

case "MSG_CG_ITEM_SELL":
return typeof(MSG_CG_ITEM_SELL);

case "MSG_CG_FRIEND_SEARCH":
return typeof(MSG_CG_FRIEND_SEARCH);

case "MSG_CG_FRIEND_ADD_REQUEST":
return typeof(MSG_CG_FRIEND_ADD_REQUEST);

case "MSG_CG_FRIEND_ADD_RESPONSE":
return typeof(MSG_CG_FRIEND_ADD_RESPONSE);

case "MSG_CG_FRIEND_DELETE":
return typeof(MSG_CG_FRIEND_DELETE);

case "MSG_CG_FRIEND_REQUEST_LIST":
return typeof(MSG_CG_FRIEND_REQUEST_LIST);

case "MSG_CG_FRIEND_RECENT_LIST":
return typeof(MSG_CG_FRIEND_RECENT_LIST);

case "MSG_CG_FRIEND_BLACK_LIST":
return typeof(MSG_CG_FRIEND_BLACK_LIST);

case "MSG_CG_FRIEND_LIST":
return typeof(MSG_CG_FRIEND_LIST);

case "MSG_CG_FRIEND_BLACK_ADD":
return typeof(MSG_CG_FRIEND_BLACK_ADD);

case "MSG_CG_FRIEND_BLACK_DEL":
return typeof(MSG_CG_FRIEND_BLACK_DEL);

case "MSG_CG_FRIEND_RECOMMEND":
return typeof(MSG_CG_FRIEND_RECOMMEND);

case "MSG_CG_SHOW_CHARACTER":
return typeof(MSG_CG_SHOW_CHARACTER);

case "MSG_CG_CHANGE_NAME":
return typeof(MSG_CG_CHANGE_NAME);

case "MSG_CG_SHOW_FACEICON":
return typeof(MSG_CG_SHOW_FACEICON);

case "MSG_CG_SHOW_FACEJPG":
return typeof(MSG_CG_SHOW_FACEJPG);

case "MSG_CG_SET_SEX":
return typeof(MSG_CG_SET_SEX);

case "MSG_CG_SET_BIRTHDAY":
return typeof(MSG_CG_SET_BIRTHDAY);

case "MSG_CG_SET_SIGNATURE":
return typeof(MSG_CG_SET_SIGNATURE);

case "MSG_CG_SHOW_VOICE":
return typeof(MSG_CG_SHOW_VOICE);

case "MSG_CG_PRESENT_GIFT":
return typeof(MSG_CG_PRESENT_GIFT);

case "MSG_CG_GET_GIFTRECORD":
return typeof(MSG_CG_GET_GIFTRECORD);

case "MSG_CG_SET_SOCIAL_NUM":
return typeof(MSG_CG_SET_SOCIAL_NUM);

case "MSG_CG_GET_SOCIAL_NUM":
return typeof(MSG_CG_GET_SOCIAL_NUM);

case "MSG_CG_SHOW_CUR_CARDQUEUE":
return typeof(MSG_CG_SHOW_CUR_CARDQUEUE);

case "MSG_CG_SHOW_CAREER":
return typeof(MSG_CG_SHOW_CAREER);

case "MSG_CG_GET_RANKING_FRIEND_LIST":
return typeof(MSG_CG_GET_RANKING_FRIEND_LIST);

case "MSG_CG_GET_RANKING_ALL_LIST":
return typeof(MSG_CG_GET_RANKING_ALL_LIST);

case "MSG_CG_GET_RANKING_NEARBY_LIST":
return typeof(MSG_CG_GET_RANKING_NEARBY_LIST);

case "MSG_CG_CREATE_GUILD":
return typeof(MSG_CG_CREATE_GUILD);

case "MSG_CG_MATCHING_BATTLE":
return typeof(MSG_CG_MATCHING_BATTLE);

case "MSG_CG_LEAVE_BATTLE_MAP":
return typeof(MSG_CG_LEAVE_BATTLE_MAP);

case "MSG_CG_CHALLENGE_PLAYER":
return typeof(MSG_CG_CHALLENGE_PLAYER);

case "MSG_CG_CHALLENGE_PLAYER_REQUEST":
return typeof(MSG_CG_CHALLENGE_PLAYER_REQUEST);

case "MSG_CG_CHALLENGE_PLAYER_RESPONSE":
return typeof(MSG_CG_CHALLENGE_PLAYER_RESPONSE);

case "MSG_CG_CHALLENGE_PLAYER_CANCEL":
return typeof(MSG_CG_CHALLENGE_PLAYER_CANCEL);

case "MSG_CG_BATTLE_MAP_STATE_END":
return typeof(MSG_CG_BATTLE_MAP_STATE_END);

case "MSG_CG_BATTLE_GET_MAP_STATE":
return typeof(MSG_CG_BATTLE_GET_MAP_STATE);

case "MSG_CG_SYNC_SUMMON_ANIM":
return typeof(MSG_CG_SYNC_SUMMON_ANIM);

case "MSG_CG_SYNC_SUMMON_ANGLE":
return typeof(MSG_CG_SYNC_SUMMON_ANGLE);

case "MSG_CG_SYNC_SUMMON_INFO":
return typeof(MSG_CG_SYNC_SUMMON_INFO);

case "MSG_CG_BATTLE_SKILL":
return typeof(MSG_CG_BATTLE_SKILL);

case "MSG_CG_VEDIO_INFO":
return typeof(MSG_CG_VEDIO_INFO);

case "MSG_CG_ENTER_TASK_BATTLE":
return typeof(MSG_CG_ENTER_TASK_BATTLE);

case "MSG_CG_FINISH_TASK_BATTLE":
return typeof(MSG_CG_FINISH_TASK_BATTLE);

case "MSG_CG_ENTER_PERSONAL_BATTLE":
return typeof(MSG_CG_ENTER_PERSONAL_BATTLE);

case "MSG_CG_FINISH_PERSONAL_BATTLE":
return typeof(MSG_CG_FINISH_PERSONAL_BATTLE);

case "MSG_CG_TEAM_CHALLENGE":
return typeof(MSG_CG_TEAM_CHALLENGE);

case "MSG_CG_LEAVE_MATCHING":
return typeof(MSG_CG_LEAVE_MATCHING);

case "MSG_CG_SYNC_BATTLE_EMOJI":
return typeof(MSG_CG_SYNC_BATTLE_EMOJI);

case "MSG_CG_GET_SEASON_REWARD":
return typeof(MSG_CG_GET_SEASON_REWARD);

case "MSG_CG_INVITE_FRIEND_FRIGHTING":
return typeof(MSG_CG_INVITE_FRIEND_FRIGHTING);

case "MSG_CG_AGREE_INVITE_FRIGHTING":
return typeof(MSG_CG_AGREE_INVITE_FRIGHTING);

case "MSG_CG_SURRENDER":
return typeof(MSG_CG_SURRENDER);

case "MSG_CG_UPDATE_HERO_POSITION":
return typeof(MSG_CG_UPDATE_HERO_POSITION);

case "MSG_CG_HERO_QUEUE_NAME":
return typeof(MSG_CG_HERO_QUEUE_NAME);

case "MSG_CG_CUR_HERO_QUEUE":
return typeof(MSG_CG_CUR_HERO_QUEUE);

case "MSG_CG_SKILL_QUEUE_NAME":
return typeof(MSG_CG_SKILL_QUEUE_NAME);

case "MSG_CG_CUR_SKILL_QUEUE":
return typeof(MSG_CG_CUR_SKILL_QUEUE);

case "MSG_CG_UPGRADE_HERO":
return typeof(MSG_CG_UPGRADE_HERO);

case "MSG_CG_UPGRADE_SKILL":
return typeof(MSG_CG_UPGRADE_SKILL);

case "MSG_CG_HERO_COMMENT":
return typeof(MSG_CG_HERO_COMMENT);

case "MSG_CG_HERO_COMMENT_LIKES":
return typeof(MSG_CG_HERO_COMMENT_LIKES);

case "MSG_CG_ADD_HERO_COMMENT":
return typeof(MSG_CG_ADD_HERO_COMMENT);

case "MSG_CG_CALL_PET":
return typeof(MSG_CG_CALL_PET);

case "MSG_CG_USE_HERO_SKIN":
return typeof(MSG_CG_USE_HERO_SKIN);

case "MSG_CG_BUY_HERO_SKIN":
return typeof(MSG_CG_BUY_HERO_SKIN);

case "MSG_CG_UPDATE_SKILL_POSITION":
return typeof(MSG_CG_UPDATE_SKILL_POSITION);

case "MSG_CG_TASK_COMPLETE":
return typeof(MSG_CG_TASK_COMPLETE);

case "MSG_CG_OPENE_HERO_TASK":
return typeof(MSG_CG_OPENE_HERO_TASK);

case "MSG_CG_OPENE_EMAIL_TASK":
return typeof(MSG_CG_OPENE_EMAIL_TASK);

case "MSG_CG_UNLOCK_HERO_STORY":
return typeof(MSG_CG_UNLOCK_HERO_STORY);

case "MSG_CG_TASK_COLLECT":
return typeof(MSG_CG_TASK_COLLECT);

case "MSG_CG_TASK_SELECT":
return typeof(MSG_CG_TASK_SELECT);

case "MSG_CG_TASK_MAKE":
return typeof(MSG_CG_TASK_MAKE);

case "MSG_CG_EMAIL_READ":
return typeof(MSG_CG_EMAIL_READ);

case "MSG_CG_PICKUP_ATTACHMENT":
return typeof(MSG_CG_PICKUP_ATTACHMENT);

case "MSG_CG_EMAIL_OPENE_BOX":
return typeof(MSG_CG_EMAIL_OPENE_BOX);

case "MSG_CG_CHAT_EMOJI":
return typeof(MSG_CG_CHAT_EMOJI);

case "MSG_CG_CHAT_WORDS":
return typeof(MSG_CG_CHAT_WORDS);

case "MSG_CG_CHANGE_WORLD_ROOM":
return typeof(MSG_CG_CHANGE_WORLD_ROOM);

case "MSG_CG_GET_WORLD_ROOM_LIST":
return typeof(MSG_CG_GET_WORLD_ROOM_LIST);

case "MSG_CG_CHAT_TRUMPET":
return typeof(MSG_CG_CHAT_TRUMPET);

case "MSG_CG_CHAT_REPORT":
return typeof(MSG_CG_CHAT_REPORT);

case "MSG_CG_NEARBY_EMOJI":
return typeof(MSG_CG_NEARBY_EMOJI);

case "MSG_CG_TIP_OFF":
return typeof(MSG_CG_TIP_OFF);

case "MSG_CG_ACTIVITY_CHAT_BUBBLE":
return typeof(MSG_CG_ACTIVITY_CHAT_BUBBLE);

case "MSG_CG_UPLOAD_PHOTO":
return typeof(MSG_CG_UPLOAD_PHOTO);

case "MSG_CG_REMOVE_PHOTO":
return typeof(MSG_CG_REMOVE_PHOTO);

case "MSG_CG_PHOTO_LIST":
return typeof(MSG_CG_PHOTO_LIST);

case "MSG_CG_LIKE_SPACE":
return typeof(MSG_CG_LIKE_SPACE);

case "MSG_CG_POP_RANK":
return typeof(MSG_CG_POP_RANK);

case "MSG_CG_SHOP_BUY_ITEM":
return typeof(MSG_CG_SHOP_BUY_ITEM);

case "MSG_CG_SHOP_GET_SSR":
return typeof(MSG_CG_SHOP_GET_SSR);

case "MSG_CG_BATTLE_VEDIO_LIST":
return typeof(MSG_CG_BATTLE_VEDIO_LIST);

case "MSG_CG_CHANGE_CHANNEL":
return typeof(MSG_CG_CHANGE_CHANNEL);

case "MSG_CG_OPEN_BATTLE_VEDIO":
return typeof(MSG_CG_OPEN_BATTLE_VEDIO);

case "MSG_CG_LEAVE_BATTLE_VEDIO":
return typeof(MSG_CG_LEAVE_BATTLE_VEDIO);

case "MSG_CG_CHAT_VEDIO":
return typeof(MSG_CG_CHAT_VEDIO);

case "MSG_CG_WATCHED_VEDIO":
return typeof(MSG_CG_WATCHED_VEDIO);

case "MSG_CG_SAVE_ORDER":
return typeof(MSG_CG_SAVE_ORDER);

case "MSG_CG_GET_RECHARGE_HISTORY":
return typeof(MSG_CG_GET_RECHARGE_HISTORY);

case "MSG_CG_DELETE_RECHARGE_HISTORY":
return typeof(MSG_CG_DELETE_RECHARGE_HISTORY);

default:
return null;
}
}
}
}
