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

public object New_MSG_CG_ITEM_BUY()
{
return new MSG_CG_ITEM_BUY();
}
public object New_MSG_CG_CREATE_CHARACTER()
{
return new MSG_CG_CREATE_CHARACTER();
}
public object New_MSG_CG_CHARACTER_MOVE()
{
return new MSG_CG_CHARACTER_MOVE();
}
public object New_MSG_CG_MOVE_ZONE()
{
return new MSG_CG_MOVE_ZONE();
}
public object New_MSG_CG_AUTOPATHFINDING()
{
return new MSG_CG_AUTOPATHFINDING();
}
public object New_MSG_CG_GEOGRAPHY()
{
return new MSG_CG_GEOGRAPHY();
}
public object New_MSG_CG_RECONNECT_LOGIN()
{
return new MSG_CG_RECONNECT_LOGIN();
}
public object New_MSG_CG_CROSS_PORTAL()
{
return new MSG_CG_CROSS_PORTAL();
}
public object New_MSG_CG_OPEN_CHEST()
{
return new MSG_CG_OPEN_CHEST();
}
public object New_MSG_CG_UNLOCK_CHEST()
{
return new MSG_CG_UNLOCK_CHEST();
}
public object New_MSG_CG_ITEM_USE()
{
return new MSG_CG_ITEM_USE();
}
public object New_MSG_CG_ITEM_SELL()
{
return new MSG_CG_ITEM_SELL();
}
public object New_MSG_CG_FRIEND_SEARCH()
{
return new MSG_CG_FRIEND_SEARCH();
}
public object New_MSG_CG_FRIEND_ADD_REQUEST()
{
return new MSG_CG_FRIEND_ADD_REQUEST();
}
public object New_MSG_CG_FRIEND_ADD_RESPONSE()
{
return new MSG_CG_FRIEND_ADD_RESPONSE();
}
public object New_MSG_CG_FRIEND_DELETE()
{
return new MSG_CG_FRIEND_DELETE();
}
public object New_MSG_CG_FRIEND_REQUEST_LIST()
{
return new MSG_CG_FRIEND_REQUEST_LIST();
}
public object New_MSG_CG_FRIEND_RECENT_LIST()
{
return new MSG_CG_FRIEND_RECENT_LIST();
}
public object New_MSG_CG_FRIEND_BLACK_LIST()
{
return new MSG_CG_FRIEND_BLACK_LIST();
}
public object New_MSG_CG_FRIEND_LIST()
{
return new MSG_CG_FRIEND_LIST();
}
public object New_MSG_CG_FRIEND_BLACK_ADD()
{
return new MSG_CG_FRIEND_BLACK_ADD();
}
public object New_MSG_CG_FRIEND_BLACK_DEL()
{
return new MSG_CG_FRIEND_BLACK_DEL();
}
public object New_MSG_CG_FRIEND_RECOMMEND()
{
return new MSG_CG_FRIEND_RECOMMEND();
}
public object New_MSG_CG_SHOW_CHARACTER()
{
return new MSG_CG_SHOW_CHARACTER();
}
public object New_MSG_CG_CHANGE_NAME()
{
return new MSG_CG_CHANGE_NAME();
}
public object New_MSG_CG_SHOW_FACEICON()
{
return new MSG_CG_SHOW_FACEICON();
}
public object New_MSG_CG_SHOW_FACEJPG()
{
return new MSG_CG_SHOW_FACEJPG();
}
public object New_MSG_CG_SET_SEX()
{
return new MSG_CG_SET_SEX();
}
public object New_MSG_CG_SET_BIRTHDAY()
{
return new MSG_CG_SET_BIRTHDAY();
}
public object New_MSG_CG_SET_SIGNATURE()
{
return new MSG_CG_SET_SIGNATURE();
}
public object New_MSG_CG_SHOW_VOICE()
{
return new MSG_CG_SHOW_VOICE();
}
public object New_MSG_CG_PRESENT_GIFT()
{
return new MSG_CG_PRESENT_GIFT();
}
public object New_MSG_CG_GET_GIFTRECORD()
{
return new MSG_CG_GET_GIFTRECORD();
}
public object New_MSG_CG_SET_SOCIAL_NUM()
{
return new MSG_CG_SET_SOCIAL_NUM();
}
public object New_MSG_CG_GET_SOCIAL_NUM()
{
return new MSG_CG_GET_SOCIAL_NUM();
}
public object New_MSG_CG_SHOW_CUR_CARDQUEUE()
{
return new MSG_CG_SHOW_CUR_CARDQUEUE();
}
public object New_MSG_CG_SHOW_CAREER()
{
return new MSG_CG_SHOW_CAREER();
}
public object New_MSG_CG_GET_RANKING_FRIEND_LIST()
{
return new MSG_CG_GET_RANKING_FRIEND_LIST();
}
public object New_MSG_CG_GET_RANKING_ALL_LIST()
{
return new MSG_CG_GET_RANKING_ALL_LIST();
}
public object New_MSG_CG_GET_RANKING_NEARBY_LIST()
{
return new MSG_CG_GET_RANKING_NEARBY_LIST();
}
public object New_MSG_CG_CREATE_GUILD()
{
return new MSG_CG_CREATE_GUILD();
}
public object New_MSG_CG_MATCHING_BATTLE()
{
return new MSG_CG_MATCHING_BATTLE();
}
public object New_MSG_CG_LEAVE_BATTLE_MAP()
{
return new MSG_CG_LEAVE_BATTLE_MAP();
}
public object New_MSG_CG_CHALLENGE_PLAYER()
{
return new MSG_CG_CHALLENGE_PLAYER();
}
public object New_MSG_CG_CHALLENGE_PLAYER_REQUEST()
{
return new MSG_CG_CHALLENGE_PLAYER_REQUEST();
}
public object New_MSG_CG_CHALLENGE_PLAYER_RESPONSE()
{
return new MSG_CG_CHALLENGE_PLAYER_RESPONSE();
}
public object New_MSG_CG_CHALLENGE_PLAYER_CANCEL()
{
return new MSG_CG_CHALLENGE_PLAYER_CANCEL();
}
public object New_MSG_CG_BATTLE_MAP_STATE_END()
{
return new MSG_CG_BATTLE_MAP_STATE_END();
}
public object New_MSG_CG_BATTLE_GET_MAP_STATE()
{
return new MSG_CG_BATTLE_GET_MAP_STATE();
}
public object New_MSG_CG_SYNC_SUMMON_ANIM()
{
return new MSG_CG_SYNC_SUMMON_ANIM();
}
public object New_MSG_CG_SYNC_SUMMON_ANGLE()
{
return new MSG_CG_SYNC_SUMMON_ANGLE();
}
public object New_MSG_CG_SYNC_SUMMON_INFO()
{
return new MSG_CG_SYNC_SUMMON_INFO();
}
public object New_MSG_CG_BATTLE_SKILL()
{
return new MSG_CG_BATTLE_SKILL();
}
public object New_MSG_CG_VEDIO_INFO()
{
return new MSG_CG_VEDIO_INFO();
}
public object New_MSG_CG_ENTER_TASK_BATTLE()
{
return new MSG_CG_ENTER_TASK_BATTLE();
}
public object New_MSG_CG_FINISH_TASK_BATTLE()
{
return new MSG_CG_FINISH_TASK_BATTLE();
}
public object New_MSG_CG_ENTER_PERSONAL_BATTLE()
{
return new MSG_CG_ENTER_PERSONAL_BATTLE();
}
public object New_MSG_CG_FINISH_PERSONAL_BATTLE()
{
return new MSG_CG_FINISH_PERSONAL_BATTLE();
}
public object New_MSG_CG_TEAM_CHALLENGE()
{
return new MSG_CG_TEAM_CHALLENGE();
}
public object New_MSG_CG_LEAVE_MATCHING()
{
return new MSG_CG_LEAVE_MATCHING();
}
public object New_MSG_CG_SYNC_BATTLE_EMOJI()
{
return new MSG_CG_SYNC_BATTLE_EMOJI();
}
public object New_MSG_CG_GET_SEASON_REWARD()
{
return new MSG_CG_GET_SEASON_REWARD();
}
public object New_MSG_CG_INVITE_FRIEND_FRIGHTING()
{
return new MSG_CG_INVITE_FRIEND_FRIGHTING();
}
public object New_MSG_CG_AGREE_INVITE_FRIGHTING()
{
return new MSG_CG_AGREE_INVITE_FRIGHTING();
}
public object New_MSG_CG_SURRENDER()
{
return new MSG_CG_SURRENDER();
}
public object New_MSG_CG_UPDATE_HERO_POSITION()
{
return new MSG_CG_UPDATE_HERO_POSITION();
}
public object New_MSG_CG_HERO_QUEUE_NAME()
{
return new MSG_CG_HERO_QUEUE_NAME();
}
public object New_MSG_CG_CUR_HERO_QUEUE()
{
return new MSG_CG_CUR_HERO_QUEUE();
}
public object New_MSG_CG_SKILL_QUEUE_NAME()
{
return new MSG_CG_SKILL_QUEUE_NAME();
}
public object New_MSG_CG_CUR_SKILL_QUEUE()
{
return new MSG_CG_CUR_SKILL_QUEUE();
}
public object New_MSG_CG_UPGRADE_HERO()
{
return new MSG_CG_UPGRADE_HERO();
}
public object New_MSG_CG_UPGRADE_SKILL()
{
return new MSG_CG_UPGRADE_SKILL();
}
public object New_MSG_CG_HERO_COMMENT()
{
return new MSG_CG_HERO_COMMENT();
}
public object New_MSG_CG_HERO_COMMENT_LIKES()
{
return new MSG_CG_HERO_COMMENT_LIKES();
}
public object New_MSG_CG_ADD_HERO_COMMENT()
{
return new MSG_CG_ADD_HERO_COMMENT();
}
public object New_MSG_CG_CALL_PET()
{
return new MSG_CG_CALL_PET();
}
public object New_MSG_CG_USE_HERO_SKIN()
{
return new MSG_CG_USE_HERO_SKIN();
}
public object New_MSG_CG_BUY_HERO_SKIN()
{
return new MSG_CG_BUY_HERO_SKIN();
}
public object New_MSG_CG_UPDATE_SKILL_POSITION()
{
return new MSG_CG_UPDATE_SKILL_POSITION();
}
public object New_MSG_CG_TASK_COMPLETE()
{
return new MSG_CG_TASK_COMPLETE();
}
public object New_MSG_CG_OPENE_HERO_TASK()
{
return new MSG_CG_OPENE_HERO_TASK();
}
public object New_MSG_CG_OPENE_EMAIL_TASK()
{
return new MSG_CG_OPENE_EMAIL_TASK();
}
public object New_MSG_CG_UNLOCK_HERO_STORY()
{
return new MSG_CG_UNLOCK_HERO_STORY();
}
public object New_MSG_CG_TASK_COLLECT()
{
return new MSG_CG_TASK_COLLECT();
}
public object New_MSG_CG_TASK_SELECT()
{
return new MSG_CG_TASK_SELECT();
}
public object New_MSG_CG_TASK_MAKE()
{
return new MSG_CG_TASK_MAKE();
}
public object New_MSG_CG_EMAIL_READ()
{
return new MSG_CG_EMAIL_READ();
}
public object New_MSG_CG_PICKUP_ATTACHMENT()
{
return new MSG_CG_PICKUP_ATTACHMENT();
}
public object New_MSG_CG_EMAIL_OPENE_BOX()
{
return new MSG_CG_EMAIL_OPENE_BOX();
}
public object New_MSG_CG_CHAT_EMOJI()
{
return new MSG_CG_CHAT_EMOJI();
}
public object New_MSG_CG_CHAT_WORDS()
{
return new MSG_CG_CHAT_WORDS();
}
public object New_MSG_CG_CHANGE_WORLD_ROOM()
{
return new MSG_CG_CHANGE_WORLD_ROOM();
}
public object New_MSG_CG_GET_WORLD_ROOM_LIST()
{
return new MSG_CG_GET_WORLD_ROOM_LIST();
}
public object New_MSG_CG_CHAT_TRUMPET()
{
return new MSG_CG_CHAT_TRUMPET();
}
public object New_MSG_CG_CHAT_REPORT()
{
return new MSG_CG_CHAT_REPORT();
}
public object New_MSG_CG_NEARBY_EMOJI()
{
return new MSG_CG_NEARBY_EMOJI();
}
public object New_MSG_CG_TIP_OFF()
{
return new MSG_CG_TIP_OFF();
}
public object New_MSG_CG_ACTIVITY_CHAT_BUBBLE()
{
return new MSG_CG_ACTIVITY_CHAT_BUBBLE();
}
public object New_MSG_CG_UPLOAD_PHOTO()
{
return new MSG_CG_UPLOAD_PHOTO();
}
public object New_MSG_CG_REMOVE_PHOTO()
{
return new MSG_CG_REMOVE_PHOTO();
}
public object New_MSG_CG_PHOTO_LIST()
{
return new MSG_CG_PHOTO_LIST();
}
public object New_MSG_CG_LIKE_SPACE()
{
return new MSG_CG_LIKE_SPACE();
}
public object New_MSG_CG_POP_RANK()
{
return new MSG_CG_POP_RANK();
}
public object New_MSG_CG_SHOP_BUY_ITEM()
{
return new MSG_CG_SHOP_BUY_ITEM();
}
public object New_MSG_CG_SHOP_GET_SSR()
{
return new MSG_CG_SHOP_GET_SSR();
}
public object New_MSG_CG_BATTLE_VEDIO_LIST()
{
return new MSG_CG_BATTLE_VEDIO_LIST();
}
public object New_MSG_CG_CHANGE_CHANNEL()
{
return new MSG_CG_CHANGE_CHANNEL();
}
public object New_MSG_CG_OPEN_BATTLE_VEDIO()
{
return new MSG_CG_OPEN_BATTLE_VEDIO();
}
public object New_MSG_CG_LEAVE_BATTLE_VEDIO()
{
return new MSG_CG_LEAVE_BATTLE_VEDIO();
}
public object New_MSG_CG_CHAT_VEDIO()
{
return new MSG_CG_CHAT_VEDIO();
}
public object New_MSG_CG_WATCHED_VEDIO()
{
return new MSG_CG_WATCHED_VEDIO();
}
public object New_MSG_CG_SAVE_ORDER()
{
return new MSG_CG_SAVE_ORDER();
}
public object New_MSG_CG_GET_RECHARGE_HISTORY()
{
return new MSG_CG_GET_RECHARGE_HISTORY();
}
public object New_MSG_CG_DELETE_RECHARGE_HISTORY()
{
return new MSG_CG_DELETE_RECHARGE_HISTORY();
}
}
}
