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

public object Init_MSG_CG_ITEM_BUY()
{
 msg_MSG_CG_ITEM_BUY = new MSG_CG_ITEM_BUY();
return msg_MSG_CG_ITEM_BUY;
}
public object Init_MSG_CG_CREATE_CHARACTER()
{
 msg_MSG_CG_CREATE_CHARACTER = new MSG_CG_CREATE_CHARACTER();
return msg_MSG_CG_CREATE_CHARACTER;
}
public object Init_MSG_CG_CHARACTER_MOVE()
{
 msg_MSG_CG_CHARACTER_MOVE = new MSG_CG_CHARACTER_MOVE();
return msg_MSG_CG_CHARACTER_MOVE;
}
public object Init_MSG_CG_MOVE_ZONE()
{
 msg_MSG_CG_MOVE_ZONE = new MSG_CG_MOVE_ZONE();
return msg_MSG_CG_MOVE_ZONE;
}
public object Init_MSG_CG_AUTOPATHFINDING()
{
 msg_MSG_CG_AUTOPATHFINDING = new MSG_CG_AUTOPATHFINDING();
return msg_MSG_CG_AUTOPATHFINDING;
}
public object Init_MSG_CG_GEOGRAPHY()
{
 msg_MSG_CG_GEOGRAPHY = new MSG_CG_GEOGRAPHY();
return msg_MSG_CG_GEOGRAPHY;
}
public object Init_MSG_CG_RECONNECT_LOGIN()
{
 msg_MSG_CG_RECONNECT_LOGIN = new MSG_CG_RECONNECT_LOGIN();
return msg_MSG_CG_RECONNECT_LOGIN;
}
public object Init_MSG_CG_CROSS_PORTAL()
{
 msg_MSG_CG_CROSS_PORTAL = new MSG_CG_CROSS_PORTAL();
return msg_MSG_CG_CROSS_PORTAL;
}
public object Init_MSG_CG_OPEN_CHEST()
{
 msg_MSG_CG_OPEN_CHEST = new MSG_CG_OPEN_CHEST();
return msg_MSG_CG_OPEN_CHEST;
}
public object Init_MSG_CG_UNLOCK_CHEST()
{
 msg_MSG_CG_UNLOCK_CHEST = new MSG_CG_UNLOCK_CHEST();
return msg_MSG_CG_UNLOCK_CHEST;
}
public object Init_MSG_CG_ITEM_USE()
{
 msg_MSG_CG_ITEM_USE = new MSG_CG_ITEM_USE();
return msg_MSG_CG_ITEM_USE;
}
public object Init_MSG_CG_ITEM_SELL()
{
 msg_MSG_CG_ITEM_SELL = new MSG_CG_ITEM_SELL();
return msg_MSG_CG_ITEM_SELL;
}
public object Init_MSG_CG_FRIEND_SEARCH()
{
 msg_MSG_CG_FRIEND_SEARCH = new MSG_CG_FRIEND_SEARCH();
return msg_MSG_CG_FRIEND_SEARCH;
}
public object Init_MSG_CG_FRIEND_ADD_REQUEST()
{
 msg_MSG_CG_FRIEND_ADD_REQUEST = new MSG_CG_FRIEND_ADD_REQUEST();
return msg_MSG_CG_FRIEND_ADD_REQUEST;
}
public object Init_MSG_CG_FRIEND_ADD_RESPONSE()
{
 msg_MSG_CG_FRIEND_ADD_RESPONSE = new MSG_CG_FRIEND_ADD_RESPONSE();
return msg_MSG_CG_FRIEND_ADD_RESPONSE;
}
public object Init_MSG_CG_FRIEND_DELETE()
{
 msg_MSG_CG_FRIEND_DELETE = new MSG_CG_FRIEND_DELETE();
return msg_MSG_CG_FRIEND_DELETE;
}
public object Init_MSG_CG_FRIEND_REQUEST_LIST()
{
 msg_MSG_CG_FRIEND_REQUEST_LIST = new MSG_CG_FRIEND_REQUEST_LIST();
return msg_MSG_CG_FRIEND_REQUEST_LIST;
}
public object Init_MSG_CG_FRIEND_RECENT_LIST()
{
 msg_MSG_CG_FRIEND_RECENT_LIST = new MSG_CG_FRIEND_RECENT_LIST();
return msg_MSG_CG_FRIEND_RECENT_LIST;
}
public object Init_MSG_CG_FRIEND_BLACK_LIST()
{
 msg_MSG_CG_FRIEND_BLACK_LIST = new MSG_CG_FRIEND_BLACK_LIST();
return msg_MSG_CG_FRIEND_BLACK_LIST;
}
public object Init_MSG_CG_FRIEND_LIST()
{
 msg_MSG_CG_FRIEND_LIST = new MSG_CG_FRIEND_LIST();
return msg_MSG_CG_FRIEND_LIST;
}
public object Init_MSG_CG_FRIEND_BLACK_ADD()
{
 msg_MSG_CG_FRIEND_BLACK_ADD = new MSG_CG_FRIEND_BLACK_ADD();
return msg_MSG_CG_FRIEND_BLACK_ADD;
}
public object Init_MSG_CG_FRIEND_BLACK_DEL()
{
 msg_MSG_CG_FRIEND_BLACK_DEL = new MSG_CG_FRIEND_BLACK_DEL();
return msg_MSG_CG_FRIEND_BLACK_DEL;
}
public object Init_MSG_CG_FRIEND_RECOMMEND()
{
 msg_MSG_CG_FRIEND_RECOMMEND = new MSG_CG_FRIEND_RECOMMEND();
return msg_MSG_CG_FRIEND_RECOMMEND;
}
public object Init_MSG_CG_SHOW_CHARACTER()
{
 msg_MSG_CG_SHOW_CHARACTER = new MSG_CG_SHOW_CHARACTER();
return msg_MSG_CG_SHOW_CHARACTER;
}
public object Init_MSG_CG_CHANGE_NAME()
{
 msg_MSG_CG_CHANGE_NAME = new MSG_CG_CHANGE_NAME();
return msg_MSG_CG_CHANGE_NAME;
}
public object Init_MSG_CG_SHOW_FACEICON()
{
 msg_MSG_CG_SHOW_FACEICON = new MSG_CG_SHOW_FACEICON();
return msg_MSG_CG_SHOW_FACEICON;
}
public object Init_MSG_CG_SHOW_FACEJPG()
{
 msg_MSG_CG_SHOW_FACEJPG = new MSG_CG_SHOW_FACEJPG();
return msg_MSG_CG_SHOW_FACEJPG;
}
public object Init_MSG_CG_SET_SEX()
{
 msg_MSG_CG_SET_SEX = new MSG_CG_SET_SEX();
return msg_MSG_CG_SET_SEX;
}
public object Init_MSG_CG_SET_BIRTHDAY()
{
 msg_MSG_CG_SET_BIRTHDAY = new MSG_CG_SET_BIRTHDAY();
return msg_MSG_CG_SET_BIRTHDAY;
}
public object Init_MSG_CG_SET_SIGNATURE()
{
 msg_MSG_CG_SET_SIGNATURE = new MSG_CG_SET_SIGNATURE();
return msg_MSG_CG_SET_SIGNATURE;
}
public object Init_MSG_CG_SHOW_VOICE()
{
 msg_MSG_CG_SHOW_VOICE = new MSG_CG_SHOW_VOICE();
return msg_MSG_CG_SHOW_VOICE;
}
public object Init_MSG_CG_PRESENT_GIFT()
{
 msg_MSG_CG_PRESENT_GIFT = new MSG_CG_PRESENT_GIFT();
return msg_MSG_CG_PRESENT_GIFT;
}
public object Init_MSG_CG_GET_GIFTRECORD()
{
 msg_MSG_CG_GET_GIFTRECORD = new MSG_CG_GET_GIFTRECORD();
return msg_MSG_CG_GET_GIFTRECORD;
}
public object Init_MSG_CG_SET_SOCIAL_NUM()
{
 msg_MSG_CG_SET_SOCIAL_NUM = new MSG_CG_SET_SOCIAL_NUM();
return msg_MSG_CG_SET_SOCIAL_NUM;
}
public object Init_MSG_CG_GET_SOCIAL_NUM()
{
 msg_MSG_CG_GET_SOCIAL_NUM = new MSG_CG_GET_SOCIAL_NUM();
return msg_MSG_CG_GET_SOCIAL_NUM;
}
public object Init_MSG_CG_SHOW_CUR_CARDQUEUE()
{
 msg_MSG_CG_SHOW_CUR_CARDQUEUE = new MSG_CG_SHOW_CUR_CARDQUEUE();
return msg_MSG_CG_SHOW_CUR_CARDQUEUE;
}
public object Init_MSG_CG_SHOW_CAREER()
{
 msg_MSG_CG_SHOW_CAREER = new MSG_CG_SHOW_CAREER();
return msg_MSG_CG_SHOW_CAREER;
}
public object Init_MSG_CG_GET_RANKING_FRIEND_LIST()
{
 msg_MSG_CG_GET_RANKING_FRIEND_LIST = new MSG_CG_GET_RANKING_FRIEND_LIST();
return msg_MSG_CG_GET_RANKING_FRIEND_LIST;
}
public object Init_MSG_CG_GET_RANKING_ALL_LIST()
{
 msg_MSG_CG_GET_RANKING_ALL_LIST = new MSG_CG_GET_RANKING_ALL_LIST();
return msg_MSG_CG_GET_RANKING_ALL_LIST;
}
public object Init_MSG_CG_GET_RANKING_NEARBY_LIST()
{
 msg_MSG_CG_GET_RANKING_NEARBY_LIST = new MSG_CG_GET_RANKING_NEARBY_LIST();
return msg_MSG_CG_GET_RANKING_NEARBY_LIST;
}
public object Init_MSG_CG_CREATE_GUILD()
{
 msg_MSG_CG_CREATE_GUILD = new MSG_CG_CREATE_GUILD();
return msg_MSG_CG_CREATE_GUILD;
}
public object Init_MSG_CG_MATCHING_BATTLE()
{
 msg_MSG_CG_MATCHING_BATTLE = new MSG_CG_MATCHING_BATTLE();
return msg_MSG_CG_MATCHING_BATTLE;
}
public object Init_MSG_CG_LEAVE_BATTLE_MAP()
{
 msg_MSG_CG_LEAVE_BATTLE_MAP = new MSG_CG_LEAVE_BATTLE_MAP();
return msg_MSG_CG_LEAVE_BATTLE_MAP;
}
public object Init_MSG_CG_CHALLENGE_PLAYER()
{
 msg_MSG_CG_CHALLENGE_PLAYER = new MSG_CG_CHALLENGE_PLAYER();
return msg_MSG_CG_CHALLENGE_PLAYER;
}
public object Init_MSG_CG_CHALLENGE_PLAYER_REQUEST()
{
 msg_MSG_CG_CHALLENGE_PLAYER_REQUEST = new MSG_CG_CHALLENGE_PLAYER_REQUEST();
return msg_MSG_CG_CHALLENGE_PLAYER_REQUEST;
}
public object Init_MSG_CG_CHALLENGE_PLAYER_RESPONSE()
{
 msg_MSG_CG_CHALLENGE_PLAYER_RESPONSE = new MSG_CG_CHALLENGE_PLAYER_RESPONSE();
return msg_MSG_CG_CHALLENGE_PLAYER_RESPONSE;
}
public object Init_MSG_CG_CHALLENGE_PLAYER_CANCEL()
{
 msg_MSG_CG_CHALLENGE_PLAYER_CANCEL = new MSG_CG_CHALLENGE_PLAYER_CANCEL();
return msg_MSG_CG_CHALLENGE_PLAYER_CANCEL;
}
public object Init_MSG_CG_BATTLE_MAP_STATE_END()
{
 msg_MSG_CG_BATTLE_MAP_STATE_END = new MSG_CG_BATTLE_MAP_STATE_END();
return msg_MSG_CG_BATTLE_MAP_STATE_END;
}
public object Init_MSG_CG_BATTLE_GET_MAP_STATE()
{
 msg_MSG_CG_BATTLE_GET_MAP_STATE = new MSG_CG_BATTLE_GET_MAP_STATE();
return msg_MSG_CG_BATTLE_GET_MAP_STATE;
}
public object Init_MSG_CG_SYNC_SUMMON_ANIM()
{
 msg_MSG_CG_SYNC_SUMMON_ANIM = new MSG_CG_SYNC_SUMMON_ANIM();
return msg_MSG_CG_SYNC_SUMMON_ANIM;
}
public object Init_MSG_CG_SYNC_SUMMON_ANGLE()
{
 msg_MSG_CG_SYNC_SUMMON_ANGLE = new MSG_CG_SYNC_SUMMON_ANGLE();
return msg_MSG_CG_SYNC_SUMMON_ANGLE;
}
public object Init_MSG_CG_SYNC_SUMMON_INFO()
{
 msg_MSG_CG_SYNC_SUMMON_INFO = new MSG_CG_SYNC_SUMMON_INFO();
return msg_MSG_CG_SYNC_SUMMON_INFO;
}
public object Init_MSG_CG_BATTLE_SKILL()
{
 msg_MSG_CG_BATTLE_SKILL = new MSG_CG_BATTLE_SKILL();
return msg_MSG_CG_BATTLE_SKILL;
}
public object Init_MSG_CG_VEDIO_INFO()
{
 msg_MSG_CG_VEDIO_INFO = new MSG_CG_VEDIO_INFO();
return msg_MSG_CG_VEDIO_INFO;
}
public object Init_MSG_CG_ENTER_TASK_BATTLE()
{
 msg_MSG_CG_ENTER_TASK_BATTLE = new MSG_CG_ENTER_TASK_BATTLE();
return msg_MSG_CG_ENTER_TASK_BATTLE;
}
public object Init_MSG_CG_FINISH_TASK_BATTLE()
{
 msg_MSG_CG_FINISH_TASK_BATTLE = new MSG_CG_FINISH_TASK_BATTLE();
return msg_MSG_CG_FINISH_TASK_BATTLE;
}
public object Init_MSG_CG_ENTER_PERSONAL_BATTLE()
{
 msg_MSG_CG_ENTER_PERSONAL_BATTLE = new MSG_CG_ENTER_PERSONAL_BATTLE();
return msg_MSG_CG_ENTER_PERSONAL_BATTLE;
}
public object Init_MSG_CG_FINISH_PERSONAL_BATTLE()
{
 msg_MSG_CG_FINISH_PERSONAL_BATTLE = new MSG_CG_FINISH_PERSONAL_BATTLE();
return msg_MSG_CG_FINISH_PERSONAL_BATTLE;
}
public object Init_MSG_CG_TEAM_CHALLENGE()
{
 msg_MSG_CG_TEAM_CHALLENGE = new MSG_CG_TEAM_CHALLENGE();
return msg_MSG_CG_TEAM_CHALLENGE;
}
public object Init_MSG_CG_LEAVE_MATCHING()
{
 msg_MSG_CG_LEAVE_MATCHING = new MSG_CG_LEAVE_MATCHING();
return msg_MSG_CG_LEAVE_MATCHING;
}
public object Init_MSG_CG_SYNC_BATTLE_EMOJI()
{
 msg_MSG_CG_SYNC_BATTLE_EMOJI = new MSG_CG_SYNC_BATTLE_EMOJI();
return msg_MSG_CG_SYNC_BATTLE_EMOJI;
}
public object Init_MSG_CG_GET_SEASON_REWARD()
{
 msg_MSG_CG_GET_SEASON_REWARD = new MSG_CG_GET_SEASON_REWARD();
return msg_MSG_CG_GET_SEASON_REWARD;
}
public object Init_MSG_CG_INVITE_FRIEND_FRIGHTING()
{
 msg_MSG_CG_INVITE_FRIEND_FRIGHTING = new MSG_CG_INVITE_FRIEND_FRIGHTING();
return msg_MSG_CG_INVITE_FRIEND_FRIGHTING;
}
public object Init_MSG_CG_AGREE_INVITE_FRIGHTING()
{
 msg_MSG_CG_AGREE_INVITE_FRIGHTING = new MSG_CG_AGREE_INVITE_FRIGHTING();
return msg_MSG_CG_AGREE_INVITE_FRIGHTING;
}
public object Init_MSG_CG_SURRENDER()
{
 msg_MSG_CG_SURRENDER = new MSG_CG_SURRENDER();
return msg_MSG_CG_SURRENDER;
}
public object Init_MSG_CG_UPDATE_HERO_POSITION()
{
 msg_MSG_CG_UPDATE_HERO_POSITION = new MSG_CG_UPDATE_HERO_POSITION();
return msg_MSG_CG_UPDATE_HERO_POSITION;
}
public object Init_MSG_CG_HERO_QUEUE_NAME()
{
 msg_MSG_CG_HERO_QUEUE_NAME = new MSG_CG_HERO_QUEUE_NAME();
return msg_MSG_CG_HERO_QUEUE_NAME;
}
public object Init_MSG_CG_CUR_HERO_QUEUE()
{
 msg_MSG_CG_CUR_HERO_QUEUE = new MSG_CG_CUR_HERO_QUEUE();
return msg_MSG_CG_CUR_HERO_QUEUE;
}
public object Init_MSG_CG_SKILL_QUEUE_NAME()
{
 msg_MSG_CG_SKILL_QUEUE_NAME = new MSG_CG_SKILL_QUEUE_NAME();
return msg_MSG_CG_SKILL_QUEUE_NAME;
}
public object Init_MSG_CG_CUR_SKILL_QUEUE()
{
 msg_MSG_CG_CUR_SKILL_QUEUE = new MSG_CG_CUR_SKILL_QUEUE();
return msg_MSG_CG_CUR_SKILL_QUEUE;
}
public object Init_MSG_CG_UPGRADE_HERO()
{
 msg_MSG_CG_UPGRADE_HERO = new MSG_CG_UPGRADE_HERO();
return msg_MSG_CG_UPGRADE_HERO;
}
public object Init_MSG_CG_UPGRADE_SKILL()
{
 msg_MSG_CG_UPGRADE_SKILL = new MSG_CG_UPGRADE_SKILL();
return msg_MSG_CG_UPGRADE_SKILL;
}
public object Init_MSG_CG_HERO_COMMENT()
{
 msg_MSG_CG_HERO_COMMENT = new MSG_CG_HERO_COMMENT();
return msg_MSG_CG_HERO_COMMENT;
}
public object Init_MSG_CG_HERO_COMMENT_LIKES()
{
 msg_MSG_CG_HERO_COMMENT_LIKES = new MSG_CG_HERO_COMMENT_LIKES();
return msg_MSG_CG_HERO_COMMENT_LIKES;
}
public object Init_MSG_CG_ADD_HERO_COMMENT()
{
 msg_MSG_CG_ADD_HERO_COMMENT = new MSG_CG_ADD_HERO_COMMENT();
return msg_MSG_CG_ADD_HERO_COMMENT;
}
public object Init_MSG_CG_CALL_PET()
{
 msg_MSG_CG_CALL_PET = new MSG_CG_CALL_PET();
return msg_MSG_CG_CALL_PET;
}
public object Init_MSG_CG_USE_HERO_SKIN()
{
 msg_MSG_CG_USE_HERO_SKIN = new MSG_CG_USE_HERO_SKIN();
return msg_MSG_CG_USE_HERO_SKIN;
}
public object Init_MSG_CG_BUY_HERO_SKIN()
{
 msg_MSG_CG_BUY_HERO_SKIN = new MSG_CG_BUY_HERO_SKIN();
return msg_MSG_CG_BUY_HERO_SKIN;
}
public object Init_MSG_CG_UPDATE_SKILL_POSITION()
{
 msg_MSG_CG_UPDATE_SKILL_POSITION = new MSG_CG_UPDATE_SKILL_POSITION();
return msg_MSG_CG_UPDATE_SKILL_POSITION;
}
public object Init_MSG_CG_TASK_COMPLETE()
{
 msg_MSG_CG_TASK_COMPLETE = new MSG_CG_TASK_COMPLETE();
return msg_MSG_CG_TASK_COMPLETE;
}
public object Init_MSG_CG_OPENE_HERO_TASK()
{
 msg_MSG_CG_OPENE_HERO_TASK = new MSG_CG_OPENE_HERO_TASK();
return msg_MSG_CG_OPENE_HERO_TASK;
}
public object Init_MSG_CG_OPENE_EMAIL_TASK()
{
 msg_MSG_CG_OPENE_EMAIL_TASK = new MSG_CG_OPENE_EMAIL_TASK();
return msg_MSG_CG_OPENE_EMAIL_TASK;
}
public object Init_MSG_CG_UNLOCK_HERO_STORY()
{
 msg_MSG_CG_UNLOCK_HERO_STORY = new MSG_CG_UNLOCK_HERO_STORY();
return msg_MSG_CG_UNLOCK_HERO_STORY;
}
public object Init_MSG_CG_TASK_COLLECT()
{
 msg_MSG_CG_TASK_COLLECT = new MSG_CG_TASK_COLLECT();
return msg_MSG_CG_TASK_COLLECT;
}
public object Init_MSG_CG_TASK_SELECT()
{
 msg_MSG_CG_TASK_SELECT = new MSG_CG_TASK_SELECT();
return msg_MSG_CG_TASK_SELECT;
}
public object Init_MSG_CG_TASK_MAKE()
{
 msg_MSG_CG_TASK_MAKE = new MSG_CG_TASK_MAKE();
return msg_MSG_CG_TASK_MAKE;
}
public object Init_MSG_CG_EMAIL_READ()
{
 msg_MSG_CG_EMAIL_READ = new MSG_CG_EMAIL_READ();
return msg_MSG_CG_EMAIL_READ;
}
public object Init_MSG_CG_PICKUP_ATTACHMENT()
{
 msg_MSG_CG_PICKUP_ATTACHMENT = new MSG_CG_PICKUP_ATTACHMENT();
return msg_MSG_CG_PICKUP_ATTACHMENT;
}
public object Init_MSG_CG_EMAIL_OPENE_BOX()
{
 msg_MSG_CG_EMAIL_OPENE_BOX = new MSG_CG_EMAIL_OPENE_BOX();
return msg_MSG_CG_EMAIL_OPENE_BOX;
}
public object Init_MSG_CG_CHAT_EMOJI()
{
 msg_MSG_CG_CHAT_EMOJI = new MSG_CG_CHAT_EMOJI();
return msg_MSG_CG_CHAT_EMOJI;
}
public object Init_MSG_CG_CHAT_WORDS()
{
 msg_MSG_CG_CHAT_WORDS = new MSG_CG_CHAT_WORDS();
return msg_MSG_CG_CHAT_WORDS;
}
public object Init_MSG_CG_CHANGE_WORLD_ROOM()
{
 msg_MSG_CG_CHANGE_WORLD_ROOM = new MSG_CG_CHANGE_WORLD_ROOM();
return msg_MSG_CG_CHANGE_WORLD_ROOM;
}
public object Init_MSG_CG_GET_WORLD_ROOM_LIST()
{
 msg_MSG_CG_GET_WORLD_ROOM_LIST = new MSG_CG_GET_WORLD_ROOM_LIST();
return msg_MSG_CG_GET_WORLD_ROOM_LIST;
}
public object Init_MSG_CG_CHAT_TRUMPET()
{
 msg_MSG_CG_CHAT_TRUMPET = new MSG_CG_CHAT_TRUMPET();
return msg_MSG_CG_CHAT_TRUMPET;
}
public object Init_MSG_CG_CHAT_REPORT()
{
 msg_MSG_CG_CHAT_REPORT = new MSG_CG_CHAT_REPORT();
return msg_MSG_CG_CHAT_REPORT;
}
public object Init_MSG_CG_NEARBY_EMOJI()
{
 msg_MSG_CG_NEARBY_EMOJI = new MSG_CG_NEARBY_EMOJI();
return msg_MSG_CG_NEARBY_EMOJI;
}
public object Init_MSG_CG_TIP_OFF()
{
 msg_MSG_CG_TIP_OFF = new MSG_CG_TIP_OFF();
return msg_MSG_CG_TIP_OFF;
}
public object Init_MSG_CG_ACTIVITY_CHAT_BUBBLE()
{
 msg_MSG_CG_ACTIVITY_CHAT_BUBBLE = new MSG_CG_ACTIVITY_CHAT_BUBBLE();
return msg_MSG_CG_ACTIVITY_CHAT_BUBBLE;
}
public object Init_MSG_CG_UPLOAD_PHOTO()
{
 msg_MSG_CG_UPLOAD_PHOTO = new MSG_CG_UPLOAD_PHOTO();
return msg_MSG_CG_UPLOAD_PHOTO;
}
public object Init_MSG_CG_REMOVE_PHOTO()
{
 msg_MSG_CG_REMOVE_PHOTO = new MSG_CG_REMOVE_PHOTO();
return msg_MSG_CG_REMOVE_PHOTO;
}
public object Init_MSG_CG_PHOTO_LIST()
{
 msg_MSG_CG_PHOTO_LIST = new MSG_CG_PHOTO_LIST();
return msg_MSG_CG_PHOTO_LIST;
}
public object Init_MSG_CG_LIKE_SPACE()
{
 msg_MSG_CG_LIKE_SPACE = new MSG_CG_LIKE_SPACE();
return msg_MSG_CG_LIKE_SPACE;
}
public object Init_MSG_CG_POP_RANK()
{
 msg_MSG_CG_POP_RANK = new MSG_CG_POP_RANK();
return msg_MSG_CG_POP_RANK;
}
public object Init_MSG_CG_SHOP_BUY_ITEM()
{
 msg_MSG_CG_SHOP_BUY_ITEM = new MSG_CG_SHOP_BUY_ITEM();
return msg_MSG_CG_SHOP_BUY_ITEM;
}
public object Init_MSG_CG_SHOP_GET_SSR()
{
 msg_MSG_CG_SHOP_GET_SSR = new MSG_CG_SHOP_GET_SSR();
return msg_MSG_CG_SHOP_GET_SSR;
}
public object Init_MSG_CG_BATTLE_VEDIO_LIST()
{
 msg_MSG_CG_BATTLE_VEDIO_LIST = new MSG_CG_BATTLE_VEDIO_LIST();
return msg_MSG_CG_BATTLE_VEDIO_LIST;
}
public object Init_MSG_CG_CHANGE_CHANNEL()
{
 msg_MSG_CG_CHANGE_CHANNEL = new MSG_CG_CHANGE_CHANNEL();
return msg_MSG_CG_CHANGE_CHANNEL;
}
public object Init_MSG_CG_OPEN_BATTLE_VEDIO()
{
 msg_MSG_CG_OPEN_BATTLE_VEDIO = new MSG_CG_OPEN_BATTLE_VEDIO();
return msg_MSG_CG_OPEN_BATTLE_VEDIO;
}
public object Init_MSG_CG_LEAVE_BATTLE_VEDIO()
{
 msg_MSG_CG_LEAVE_BATTLE_VEDIO = new MSG_CG_LEAVE_BATTLE_VEDIO();
return msg_MSG_CG_LEAVE_BATTLE_VEDIO;
}
public object Init_MSG_CG_CHAT_VEDIO()
{
 msg_MSG_CG_CHAT_VEDIO = new MSG_CG_CHAT_VEDIO();
return msg_MSG_CG_CHAT_VEDIO;
}
public object Init_MSG_CG_WATCHED_VEDIO()
{
 msg_MSG_CG_WATCHED_VEDIO = new MSG_CG_WATCHED_VEDIO();
return msg_MSG_CG_WATCHED_VEDIO;
}
public object Init_MSG_CG_SAVE_ORDER()
{
 msg_MSG_CG_SAVE_ORDER = new MSG_CG_SAVE_ORDER();
return msg_MSG_CG_SAVE_ORDER;
}
public object Init_MSG_CG_GET_RECHARGE_HISTORY()
{
 msg_MSG_CG_GET_RECHARGE_HISTORY = new MSG_CG_GET_RECHARGE_HISTORY();
return msg_MSG_CG_GET_RECHARGE_HISTORY;
}
public object Init_MSG_CG_DELETE_RECHARGE_HISTORY()
{
 msg_MSG_CG_DELETE_RECHARGE_HISTORY = new MSG_CG_DELETE_RECHARGE_HISTORY();
return msg_MSG_CG_DELETE_RECHARGE_HISTORY;
}
}
}