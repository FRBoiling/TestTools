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

public object Get_MSG_CG_ITEM_BUY()
{
return msg_MSG_CG_ITEM_BUY;
}
public object Get_MSG_CG_CREATE_CHARACTER()
{
return msg_MSG_CG_CREATE_CHARACTER;
}
public object Get_MSG_CG_CHARACTER_MOVE()
{
return msg_MSG_CG_CHARACTER_MOVE;
}
public object Get_MSG_CG_MOVE_ZONE()
{
return msg_MSG_CG_MOVE_ZONE;
}
public object Get_MSG_CG_AUTOPATHFINDING()
{
return msg_MSG_CG_AUTOPATHFINDING;
}
public object Get_MSG_CG_GEOGRAPHY()
{
return msg_MSG_CG_GEOGRAPHY;
}
public object Get_MSG_CG_RECONNECT_LOGIN()
{
return msg_MSG_CG_RECONNECT_LOGIN;
}
public object Get_MSG_CG_CROSS_PORTAL()
{
return msg_MSG_CG_CROSS_PORTAL;
}
public object Get_MSG_CG_OPEN_CHEST()
{
return msg_MSG_CG_OPEN_CHEST;
}
public object Get_MSG_CG_UNLOCK_CHEST()
{
return msg_MSG_CG_UNLOCK_CHEST;
}
public object Get_MSG_CG_ITEM_USE()
{
return msg_MSG_CG_ITEM_USE;
}
public object Get_MSG_CG_ITEM_SELL()
{
return msg_MSG_CG_ITEM_SELL;
}
public object Get_MSG_CG_FRIEND_SEARCH()
{
return msg_MSG_CG_FRIEND_SEARCH;
}
public object Get_MSG_CG_FRIEND_ADD_REQUEST()
{
return msg_MSG_CG_FRIEND_ADD_REQUEST;
}
public object Get_MSG_CG_FRIEND_ADD_RESPONSE()
{
return msg_MSG_CG_FRIEND_ADD_RESPONSE;
}
public object Get_MSG_CG_FRIEND_DELETE()
{
return msg_MSG_CG_FRIEND_DELETE;
}
public object Get_MSG_CG_FRIEND_REQUEST_LIST()
{
return msg_MSG_CG_FRIEND_REQUEST_LIST;
}
public object Get_MSG_CG_FRIEND_RECENT_LIST()
{
return msg_MSG_CG_FRIEND_RECENT_LIST;
}
public object Get_MSG_CG_FRIEND_BLACK_LIST()
{
return msg_MSG_CG_FRIEND_BLACK_LIST;
}
public object Get_MSG_CG_FRIEND_LIST()
{
return msg_MSG_CG_FRIEND_LIST;
}
public object Get_MSG_CG_FRIEND_BLACK_ADD()
{
return msg_MSG_CG_FRIEND_BLACK_ADD;
}
public object Get_MSG_CG_FRIEND_BLACK_DEL()
{
return msg_MSG_CG_FRIEND_BLACK_DEL;
}
public object Get_MSG_CG_FRIEND_RECOMMEND()
{
return msg_MSG_CG_FRIEND_RECOMMEND;
}
public object Get_MSG_CG_SHOW_CHARACTER()
{
return msg_MSG_CG_SHOW_CHARACTER;
}
public object Get_MSG_CG_CHANGE_NAME()
{
return msg_MSG_CG_CHANGE_NAME;
}
public object Get_MSG_CG_SHOW_FACEICON()
{
return msg_MSG_CG_SHOW_FACEICON;
}
public object Get_MSG_CG_SHOW_FACEJPG()
{
return msg_MSG_CG_SHOW_FACEJPG;
}
public object Get_MSG_CG_SET_SEX()
{
return msg_MSG_CG_SET_SEX;
}
public object Get_MSG_CG_SET_BIRTHDAY()
{
return msg_MSG_CG_SET_BIRTHDAY;
}
public object Get_MSG_CG_SET_SIGNATURE()
{
return msg_MSG_CG_SET_SIGNATURE;
}
public object Get_MSG_CG_SHOW_VOICE()
{
return msg_MSG_CG_SHOW_VOICE;
}
public object Get_MSG_CG_PRESENT_GIFT()
{
return msg_MSG_CG_PRESENT_GIFT;
}
public object Get_MSG_CG_GET_GIFTRECORD()
{
return msg_MSG_CG_GET_GIFTRECORD;
}
public object Get_MSG_CG_SET_SOCIAL_NUM()
{
return msg_MSG_CG_SET_SOCIAL_NUM;
}
public object Get_MSG_CG_GET_SOCIAL_NUM()
{
return msg_MSG_CG_GET_SOCIAL_NUM;
}
public object Get_MSG_CG_SHOW_CUR_CARDQUEUE()
{
return msg_MSG_CG_SHOW_CUR_CARDQUEUE;
}
public object Get_MSG_CG_SHOW_CAREER()
{
return msg_MSG_CG_SHOW_CAREER;
}
public object Get_MSG_CG_GET_RANKING_FRIEND_LIST()
{
return msg_MSG_CG_GET_RANKING_FRIEND_LIST;
}
public object Get_MSG_CG_GET_RANKING_ALL_LIST()
{
return msg_MSG_CG_GET_RANKING_ALL_LIST;
}
public object Get_MSG_CG_GET_RANKING_NEARBY_LIST()
{
return msg_MSG_CG_GET_RANKING_NEARBY_LIST;
}
public object Get_MSG_CG_CREATE_GUILD()
{
return msg_MSG_CG_CREATE_GUILD;
}
public object Get_MSG_CG_MATCHING_BATTLE()
{
return msg_MSG_CG_MATCHING_BATTLE;
}
public object Get_MSG_CG_LEAVE_BATTLE_MAP()
{
return msg_MSG_CG_LEAVE_BATTLE_MAP;
}
public object Get_MSG_CG_CHALLENGE_PLAYER()
{
return msg_MSG_CG_CHALLENGE_PLAYER;
}
public object Get_MSG_CG_CHALLENGE_PLAYER_REQUEST()
{
return msg_MSG_CG_CHALLENGE_PLAYER_REQUEST;
}
public object Get_MSG_CG_CHALLENGE_PLAYER_RESPONSE()
{
return msg_MSG_CG_CHALLENGE_PLAYER_RESPONSE;
}
public object Get_MSG_CG_CHALLENGE_PLAYER_CANCEL()
{
return msg_MSG_CG_CHALLENGE_PLAYER_CANCEL;
}
public object Get_MSG_CG_BATTLE_MAP_STATE_END()
{
return msg_MSG_CG_BATTLE_MAP_STATE_END;
}
public object Get_MSG_CG_BATTLE_GET_MAP_STATE()
{
return msg_MSG_CG_BATTLE_GET_MAP_STATE;
}
public object Get_MSG_CG_SYNC_SUMMON_ANIM()
{
return msg_MSG_CG_SYNC_SUMMON_ANIM;
}
public object Get_MSG_CG_SYNC_SUMMON_ANGLE()
{
return msg_MSG_CG_SYNC_SUMMON_ANGLE;
}
public object Get_MSG_CG_SYNC_SUMMON_INFO()
{
return msg_MSG_CG_SYNC_SUMMON_INFO;
}
public object Get_MSG_CG_BATTLE_SKILL()
{
return msg_MSG_CG_BATTLE_SKILL;
}
public object Get_MSG_CG_VEDIO_INFO()
{
return msg_MSG_CG_VEDIO_INFO;
}
public object Get_MSG_CG_ENTER_TASK_BATTLE()
{
return msg_MSG_CG_ENTER_TASK_BATTLE;
}
public object Get_MSG_CG_FINISH_TASK_BATTLE()
{
return msg_MSG_CG_FINISH_TASK_BATTLE;
}
public object Get_MSG_CG_ENTER_PERSONAL_BATTLE()
{
return msg_MSG_CG_ENTER_PERSONAL_BATTLE;
}
public object Get_MSG_CG_FINISH_PERSONAL_BATTLE()
{
return msg_MSG_CG_FINISH_PERSONAL_BATTLE;
}
public object Get_MSG_CG_TEAM_CHALLENGE()
{
return msg_MSG_CG_TEAM_CHALLENGE;
}
public object Get_MSG_CG_LEAVE_MATCHING()
{
return msg_MSG_CG_LEAVE_MATCHING;
}
public object Get_MSG_CG_SYNC_BATTLE_EMOJI()
{
return msg_MSG_CG_SYNC_BATTLE_EMOJI;
}
public object Get_MSG_CG_GET_SEASON_REWARD()
{
return msg_MSG_CG_GET_SEASON_REWARD;
}
public object Get_MSG_CG_INVITE_FRIEND_FRIGHTING()
{
return msg_MSG_CG_INVITE_FRIEND_FRIGHTING;
}
public object Get_MSG_CG_AGREE_INVITE_FRIGHTING()
{
return msg_MSG_CG_AGREE_INVITE_FRIGHTING;
}
public object Get_MSG_CG_SURRENDER()
{
return msg_MSG_CG_SURRENDER;
}
public object Get_MSG_CG_UPDATE_HERO_POSITION()
{
return msg_MSG_CG_UPDATE_HERO_POSITION;
}
public object Get_MSG_CG_HERO_QUEUE_NAME()
{
return msg_MSG_CG_HERO_QUEUE_NAME;
}
public object Get_MSG_CG_CUR_HERO_QUEUE()
{
return msg_MSG_CG_CUR_HERO_QUEUE;
}
public object Get_MSG_CG_SKILL_QUEUE_NAME()
{
return msg_MSG_CG_SKILL_QUEUE_NAME;
}
public object Get_MSG_CG_CUR_SKILL_QUEUE()
{
return msg_MSG_CG_CUR_SKILL_QUEUE;
}
public object Get_MSG_CG_UPGRADE_HERO()
{
return msg_MSG_CG_UPGRADE_HERO;
}
public object Get_MSG_CG_UPGRADE_SKILL()
{
return msg_MSG_CG_UPGRADE_SKILL;
}
public object Get_MSG_CG_HERO_COMMENT()
{
return msg_MSG_CG_HERO_COMMENT;
}
public object Get_MSG_CG_HERO_COMMENT_LIKES()
{
return msg_MSG_CG_HERO_COMMENT_LIKES;
}
public object Get_MSG_CG_ADD_HERO_COMMENT()
{
return msg_MSG_CG_ADD_HERO_COMMENT;
}
public object Get_MSG_CG_CALL_PET()
{
return msg_MSG_CG_CALL_PET;
}
public object Get_MSG_CG_USE_HERO_SKIN()
{
return msg_MSG_CG_USE_HERO_SKIN;
}
public object Get_MSG_CG_BUY_HERO_SKIN()
{
return msg_MSG_CG_BUY_HERO_SKIN;
}
public object Get_MSG_CG_UPDATE_SKILL_POSITION()
{
return msg_MSG_CG_UPDATE_SKILL_POSITION;
}
public object Get_MSG_CG_TASK_COMPLETE()
{
return msg_MSG_CG_TASK_COMPLETE;
}
public object Get_MSG_CG_OPENE_HERO_TASK()
{
return msg_MSG_CG_OPENE_HERO_TASK;
}
public object Get_MSG_CG_OPENE_EMAIL_TASK()
{
return msg_MSG_CG_OPENE_EMAIL_TASK;
}
public object Get_MSG_CG_UNLOCK_HERO_STORY()
{
return msg_MSG_CG_UNLOCK_HERO_STORY;
}
public object Get_MSG_CG_TASK_COLLECT()
{
return msg_MSG_CG_TASK_COLLECT;
}
public object Get_MSG_CG_TASK_SELECT()
{
return msg_MSG_CG_TASK_SELECT;
}
public object Get_MSG_CG_TASK_MAKE()
{
return msg_MSG_CG_TASK_MAKE;
}
public object Get_MSG_CG_EMAIL_READ()
{
return msg_MSG_CG_EMAIL_READ;
}
public object Get_MSG_CG_PICKUP_ATTACHMENT()
{
return msg_MSG_CG_PICKUP_ATTACHMENT;
}
public object Get_MSG_CG_EMAIL_OPENE_BOX()
{
return msg_MSG_CG_EMAIL_OPENE_BOX;
}
public object Get_MSG_CG_CHAT_EMOJI()
{
return msg_MSG_CG_CHAT_EMOJI;
}
public object Get_MSG_CG_CHAT_WORDS()
{
return msg_MSG_CG_CHAT_WORDS;
}
public object Get_MSG_CG_CHANGE_WORLD_ROOM()
{
return msg_MSG_CG_CHANGE_WORLD_ROOM;
}
public object Get_MSG_CG_GET_WORLD_ROOM_LIST()
{
return msg_MSG_CG_GET_WORLD_ROOM_LIST;
}
public object Get_MSG_CG_CHAT_TRUMPET()
{
return msg_MSG_CG_CHAT_TRUMPET;
}
public object Get_MSG_CG_CHAT_REPORT()
{
return msg_MSG_CG_CHAT_REPORT;
}
public object Get_MSG_CG_NEARBY_EMOJI()
{
return msg_MSG_CG_NEARBY_EMOJI;
}
public object Get_MSG_CG_TIP_OFF()
{
return msg_MSG_CG_TIP_OFF;
}
public object Get_MSG_CG_ACTIVITY_CHAT_BUBBLE()
{
return msg_MSG_CG_ACTIVITY_CHAT_BUBBLE;
}
public object Get_MSG_CG_UPLOAD_PHOTO()
{
return msg_MSG_CG_UPLOAD_PHOTO;
}
public object Get_MSG_CG_REMOVE_PHOTO()
{
return msg_MSG_CG_REMOVE_PHOTO;
}
public object Get_MSG_CG_PHOTO_LIST()
{
return msg_MSG_CG_PHOTO_LIST;
}
public object Get_MSG_CG_LIKE_SPACE()
{
return msg_MSG_CG_LIKE_SPACE;
}
public object Get_MSG_CG_POP_RANK()
{
return msg_MSG_CG_POP_RANK;
}
public object Get_MSG_CG_SHOP_BUY_ITEM()
{
return msg_MSG_CG_SHOP_BUY_ITEM;
}
public object Get_MSG_CG_SHOP_GET_SSR()
{
return msg_MSG_CG_SHOP_GET_SSR;
}
public object Get_MSG_CG_BATTLE_VEDIO_LIST()
{
return msg_MSG_CG_BATTLE_VEDIO_LIST;
}
public object Get_MSG_CG_CHANGE_CHANNEL()
{
return msg_MSG_CG_CHANGE_CHANNEL;
}
public object Get_MSG_CG_OPEN_BATTLE_VEDIO()
{
return msg_MSG_CG_OPEN_BATTLE_VEDIO;
}
public object Get_MSG_CG_LEAVE_BATTLE_VEDIO()
{
return msg_MSG_CG_LEAVE_BATTLE_VEDIO;
}
public object Get_MSG_CG_CHAT_VEDIO()
{
return msg_MSG_CG_CHAT_VEDIO;
}
public object Get_MSG_CG_WATCHED_VEDIO()
{
return msg_MSG_CG_WATCHED_VEDIO;
}
public object Get_MSG_CG_SAVE_ORDER()
{
return msg_MSG_CG_SAVE_ORDER;
}
public object Get_MSG_CG_GET_RECHARGE_HISTORY()
{
return msg_MSG_CG_GET_RECHARGE_HISTORY;
}
public object Get_MSG_CG_DELETE_RECHARGE_HISTORY()
{
return msg_MSG_CG_DELETE_RECHARGE_HISTORY;
}
}
}
