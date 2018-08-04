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
public void BindResponse()
{
 
Net.AddResponser(Id<MSG_GC_INSTANCES_REMOVE>.Value, OnResponse_MSG_GC_INSTANCES_REMOVE);

Net.AddResponser(Id<MODEL_INFO>.Value, OnResponse_MODEL_INFO);

Net.AddResponser(Id<MSG_GC_CHARACTER_INFO>.Value, OnResponse_MSG_GC_CHARACTER_INFO);

Net.AddResponser(Id<MSG_GC_CREATE_CHARACTER>.Value, OnResponse_MSG_GC_CREATE_CHARACTER);

Net.AddResponser(Id<MSG_GC_TO_ZONE>.Value, OnResponse_MSG_GC_TO_ZONE);

Net.AddResponser(Id<MSG_ZGC_ERROR_CODE>.Value, OnResponse_MSG_ZGC_ERROR_CODE);

Net.AddResponser(Id<MSG_ZGC_NPC_INFO>.Value, OnResponse_MSG_ZGC_NPC_INFO);

Net.AddResponser(Id<MSG_ZGC_GOODS_INFO>.Value, OnResponse_MSG_ZGC_GOODS_INFO);

Net.AddResponser(Id<MSG_ZGC_INTERACTION>.Value, OnResponse_MSG_ZGC_INTERACTION);

Net.AddResponser(Id<MSG_GC_RECONNECT_LOGIN>.Value, OnResponse_MSG_GC_RECONNECT_LOGIN);

Net.AddResponser(Id<MSG_ZGC_LOGIN_FREEZE>.Value, OnResponse_MSG_ZGC_LOGIN_FREEZE);

Net.AddResponser(Id<MSG_GC_FieldObject_MOVE>.Value, OnResponse_MSG_GC_FieldObject_MOVE);

Net.AddResponser(Id<MSG_ZGC_CHARACTER_STOP>.Value, OnResponse_MSG_ZGC_CHARACTER_STOP);

Net.AddResponser(Id<MSG_GC_CHAR_SIMPLE_INFO>.Value, OnResponse_MSG_GC_CHAR_SIMPLE_INFO);

Net.AddResponser(Id<MSG_GC_BROADCAST_INFO>.Value, OnResponse_MSG_GC_BROADCAST_INFO);

Net.AddResponser(Id<MSG_GC_BROADCAST_LIST>.Value, OnResponse_MSG_GC_BROADCAST_LIST);

Net.AddResponser(Id<MSG_GC_CHARACTER_ENTER_LIST>.Value, OnResponse_MSG_GC_CHARACTER_ENTER_LIST);

Net.AddResponser(Id<MSG_GC_CHARACTER_LEAVE>.Value, OnResponse_MSG_GC_CHARACTER_LEAVE);

Net.AddResponser(Id<MSG_ZGC_PET_SIMPLE_INFO>.Value, OnResponse_MSG_ZGC_PET_SIMPLE_INFO);

Net.AddResponser(Id<MSG_GC_PET_ENTER_LIST>.Value, OnResponse_MSG_GC_PET_ENTER_LIST);

Net.AddResponser(Id<MSG_ZGC_PET_LEAVE>.Value, OnResponse_MSG_ZGC_PET_LEAVE);

Net.AddResponser(Id<MSG_ZGC_NPC_MOVE>.Value, OnResponse_MSG_ZGC_NPC_MOVE);

Net.AddResponser(Id<MSG_ZGC_NPC_LEAVE>.Value, OnResponse_MSG_ZGC_NPC_LEAVE);

Net.AddResponser(Id<MSG_ZGC_NPC_SIMPLE_INFO>.Value, OnResponse_MSG_ZGC_NPC_SIMPLE_INFO);

Net.AddResponser(Id<MSG_GC_NPC_ENTER_LIST>.Value, OnResponse_MSG_GC_NPC_ENTER_LIST);

Net.AddResponser(Id<MSG_ZGC_CHEST_STATE_SYNC>.Value, OnResponse_MSG_ZGC_CHEST_STATE_SYNC);

Net.AddResponser(Id<CHEST_FREE>.Value, OnResponse_CHEST_FREE);

Net.AddResponser(Id<CHEST_LADDER>.Value, OnResponse_CHEST_LADDER);

Net.AddResponser(Id<CHEST_NORMAL>.Value, OnResponse_CHEST_NORMAL);

Net.AddResponser(Id<MSG_ZGC_OPEN_CHEST>.Value, OnResponse_MSG_ZGC_OPEN_CHEST);

Net.AddResponser(Id<CHEST_ITEM_INFO>.Value, OnResponse_CHEST_ITEM_INFO);

Net.AddResponser(Id<MSG_ZGC_UNLOCK_CHEST>.Value, OnResponse_MSG_ZGC_UNLOCK_CHEST);

Net.AddResponser(Id<MSG_ZGC_OPEN_CHEST_RESULT>.Value, OnResponse_MSG_ZGC_OPEN_CHEST_RESULT);

Net.AddResponser(Id<ITEM>.Value, OnResponse_ITEM);

Net.AddResponser(Id<MSG_ZGC_KNAPSACK_SYNC>.Value, OnResponse_MSG_ZGC_KNAPSACK_SYNC);

Net.AddResponser(Id<MSG_ZGC_KNAPSACK_UPDATE>.Value, OnResponse_MSG_ZGC_KNAPSACK_UPDATE);

Net.AddResponser(Id<MSG_ZGC_ITEM_USE>.Value, OnResponse_MSG_ZGC_ITEM_USE);

Net.AddResponser(Id<MSG_ZGC_ITEM_SELL>.Value, OnResponse_MSG_ZGC_ITEM_SELL);

Net.AddResponser(Id<MSG_ZGC_EQUIP_FACEFRAME>.Value, OnResponse_MSG_ZGC_EQUIP_FACEFRAME);

Net.AddResponser(Id<MSG_ZGC_ITEM_BUY>.Value, OnResponse_MSG_ZGC_ITEM_BUY);

Net.AddResponser(Id<CURRENCY>.Value, OnResponse_CURRENCY);

Net.AddResponser(Id<MSG_ZGC_SYNC_CURRENCIES>.Value, OnResponse_MSG_ZGC_SYNC_CURRENCIES);

Net.AddResponser(Id<MSG_ZGC_SHOW_CHARACTER>.Value, OnResponse_MSG_ZGC_SHOW_CHARACTER);

Net.AddResponser(Id<SHOW_CHARACTERINFO>.Value, OnResponse_SHOW_CHARACTERINFO);

Net.AddResponser(Id<MSG_ZGC_SHOW_VOICE>.Value, OnResponse_MSG_ZGC_SHOW_VOICE);

Net.AddResponser(Id<SHOW_SPACEINFO>.Value, OnResponse_SHOW_SPACEINFO);

Net.AddResponser(Id<MSG_ZGC_CHANGE_NAME>.Value, OnResponse_MSG_ZGC_CHANGE_NAME);

Net.AddResponser(Id<MSG_ZGC_SHOW_FACEICON>.Value, OnResponse_MSG_ZGC_SHOW_FACEICON);

Net.AddResponser(Id<MSG_ZGC_SHOW_FACEJPG>.Value, OnResponse_MSG_ZGC_SHOW_FACEJPG);

Net.AddResponser(Id<MSG_ZGC_SET_SEX>.Value, OnResponse_MSG_ZGC_SET_SEX);

Net.AddResponser(Id<MSG_ZGC_SET_BIRTHDAY>.Value, OnResponse_MSG_ZGC_SET_BIRTHDAY);

Net.AddResponser(Id<MSG_ZGC_SET_SIGNATURE>.Value, OnResponse_MSG_ZGC_SET_SIGNATURE);

Net.AddResponser(Id<MSG_ZGC_PRESENT_GIFT>.Value, OnResponse_MSG_ZGC_PRESENT_GIFT);

Net.AddResponser(Id<MSG_ZGC_SET_SOCIAL_NUM>.Value, OnResponse_MSG_ZGC_SET_SOCIAL_NUM);

Net.AddResponser(Id<MSG_ZGC_GET_SOCIAL_NUM>.Value, OnResponse_MSG_ZGC_GET_SOCIAL_NUM);

Net.AddResponser(Id<MSG_ZGC_GEOGRAPHY>.Value, OnResponse_MSG_ZGC_GEOGRAPHY);

Net.AddResponser(Id<SHOW_HERO>.Value, OnResponse_SHOW_HERO);

Net.AddResponser(Id<CUR_HERO_QUEUE>.Value, OnResponse_CUR_HERO_QUEUE);

Net.AddResponser(Id<SHOW_SKILL>.Value, OnResponse_SHOW_SKILL);

Net.AddResponser(Id<CUR_SKILL_QUEUE>.Value, OnResponse_CUR_SKILL_QUEUE);

Net.AddResponser(Id<MSG_ZGC_SHOW_CUR_CARDQUEUE>.Value, OnResponse_MSG_ZGC_SHOW_CUR_CARDQUEUE);

Net.AddResponser(Id<MSG_ZGC_UPDATE_SOME_SHOW>.Value, OnResponse_MSG_ZGC_UPDATE_SOME_SHOW);

Net.AddResponser(Id<MSG_ZGC_SHOW_CAREER>.Value, OnResponse_MSG_ZGC_SHOW_CAREER);

Net.AddResponser(Id<MSG_ZGC_CAREER_ITEM>.Value, OnResponse_MSG_ZGC_CAREER_ITEM);

Net.AddResponser(Id<MSG_ZGC_GET_GIFTRECORD>.Value, OnResponse_MSG_ZGC_GET_GIFTRECORD);

Net.AddResponser(Id<PLAYER_BASE_INFO>.Value, OnResponse_PLAYER_BASE_INFO);

Net.AddResponser(Id<MSG_ZGC_FRIEND_SEARCH>.Value, OnResponse_MSG_ZGC_FRIEND_SEARCH);

Net.AddResponser(Id<MSG_ZGC_FRIEND_ADD_REQUEST>.Value, OnResponse_MSG_ZGC_FRIEND_ADD_REQUEST);

Net.AddResponser(Id<MSG_ZGC_FRIEND_ADD_RESPONSE>.Value, OnResponse_MSG_ZGC_FRIEND_ADD_RESPONSE);

Net.AddResponser(Id<MSG_ZGC_FRIEND_DELETE>.Value, OnResponse_MSG_ZGC_FRIEND_DELETE);

Net.AddResponser(Id<MSG_ZGC_FRIEND_LIST>.Value, OnResponse_MSG_ZGC_FRIEND_LIST);

Net.AddResponser(Id<FRIEND_REQUEST_INFO>.Value, OnResponse_FRIEND_REQUEST_INFO);

Net.AddResponser(Id<MSG_ZGC_FRIEND_REQUEST_LIST>.Value, OnResponse_MSG_ZGC_FRIEND_REQUEST_LIST);

Net.AddResponser(Id<MSG_ZGC_FRIEND_RECENT_LIST>.Value, OnResponse_MSG_ZGC_FRIEND_RECENT_LIST);

Net.AddResponser(Id<BLACK_INFO>.Value, OnResponse_BLACK_INFO);

Net.AddResponser(Id<MSG_ZGC_FRIEND_BLACK_LIST>.Value, OnResponse_MSG_ZGC_FRIEND_BLACK_LIST);

Net.AddResponser(Id<MSG_ZGC_FRIEND_BLACK_ADD>.Value, OnResponse_MSG_ZGC_FRIEND_BLACK_ADD);

Net.AddResponser(Id<MSG_ZGC_FRIEND_BLACK_DEL>.Value, OnResponse_MSG_ZGC_FRIEND_BLACK_DEL);

Net.AddResponser(Id<FRIEND_SEARCH_INFO>.Value, OnResponse_FRIEND_SEARCH_INFO);

Net.AddResponser(Id<MSG_ZGC_FRIEND_RECOMMEND>.Value, OnResponse_MSG_ZGC_FRIEND_RECOMMEND);

Net.AddResponser(Id<MSG_ZGC_RANKING_FRIEND_LIST>.Value, OnResponse_MSG_ZGC_RANKING_FRIEND_LIST);

Net.AddResponser(Id<MSG_ZGC_RANKING_ALL_LIST>.Value, OnResponse_MSG_ZGC_RANKING_ALL_LIST);

Net.AddResponser(Id<MSG_ZGC_RANKING_NEARBY_LIST>.Value, OnResponse_MSG_ZGC_RANKING_NEARBY_LIST);

Net.AddResponser(Id<MSG_ZGC_CREATE_GUILD>.Value, OnResponse_MSG_ZGC_CREATE_GUILD);

Net.AddResponser(Id<MSG_BZGC_HERO_INFO>.Value, OnResponse_MSG_BZGC_HERO_INFO);

Net.AddResponser(Id<BATTLE_HERO>.Value, OnResponse_BATTLE_HERO);

Net.AddResponser(Id<BATTLE_SKILL>.Value, OnResponse_BATTLE_SKILL);

Net.AddResponser(Id<MSG_BZGC_HERO_BASE>.Value, OnResponse_MSG_BZGC_HERO_BASE);

Net.AddResponser(Id<MSG_BZGC_HERO_POSITION>.Value, OnResponse_MSG_BZGC_HERO_POSITION);

Net.AddResponser(Id<MSG_BZGC_HERO_RELATIVE>.Value, OnResponse_MSG_BZGC_HERO_RELATIVE);

Net.AddResponser(Id<BATTLE_NATURE>.Value, OnResponse_BATTLE_NATURE);

Net.AddResponser(Id<MSG_BZGC_SKILL_CAST>.Value, OnResponse_MSG_BZGC_SKILL_CAST);

Net.AddResponser(Id<MSG_BZGC_DAMGE>.Value, OnResponse_MSG_BZGC_DAMGE);

Net.AddResponser(Id<MSG_BZGC_HERO_MOVE>.Value, OnResponse_MSG_BZGC_HERO_MOVE);

Net.AddResponser(Id<MSG_BZGC_ENTER_BTTLE_MAP>.Value, OnResponse_MSG_BZGC_ENTER_BTTLE_MAP);

Net.AddResponser(Id<MSG_ZGC_LOADING_HERO_INFO>.Value, OnResponse_MSG_ZGC_LOADING_HERO_INFO);

Net.AddResponser(Id<MSG_ZGC_LOADING_INFO>.Value, OnResponse_MSG_ZGC_LOADING_INFO);

Net.AddResponser(Id<MSG_BZGC_BATTLE_MAP_STATE>.Value, OnResponse_MSG_BZGC_BATTLE_MAP_STATE);

Net.AddResponser(Id<MSG_BZGC_SUMMON_STATE>.Value, OnResponse_MSG_BZGC_SUMMON_STATE);

Net.AddResponser(Id<MSG_BZGC_SUMMON_INFO>.Value, OnResponse_MSG_BZGC_SUMMON_INFO);

Net.AddResponser(Id<MSG_BZGC_SUMMON_ANGLE>.Value, OnResponse_MSG_BZGC_SUMMON_ANGLE);

Net.AddResponser(Id<MSG_BZGC_BATTLE_EMOJI>.Value, OnResponse_MSG_BZGC_BATTLE_EMOJI);

Net.AddResponser(Id<MSG_BZGC_BATTLE_FPS_INFO>.Value, OnResponse_MSG_BZGC_BATTLE_FPS_INFO);

Net.AddResponser(Id<MSG_BZGC_BATTLE_SHOW_INFO>.Value, OnResponse_MSG_BZGC_BATTLE_SHOW_INFO);

Net.AddResponser(Id<MSG_BZGC_VEDIO_SUMMON_ANGLE>.Value, OnResponse_MSG_BZGC_VEDIO_SUMMON_ANGLE);

Net.AddResponser(Id<MSG_BZGC_VEDIO_BTTLE_MAP>.Value, OnResponse_MSG_BZGC_VEDIO_BTTLE_MAP);

Net.AddResponser(Id<MSG_BZGC_BATTLE_RESULT_FPS>.Value, OnResponse_MSG_BZGC_BATTLE_RESULT_FPS);

Net.AddResponser(Id<MSG_BZGC_VEDIO_INFO>.Value, OnResponse_MSG_BZGC_VEDIO_INFO);

Net.AddResponser(Id<MSG_BZGC_ENTER_TASK_BATTLE>.Value, OnResponse_MSG_BZGC_ENTER_TASK_BATTLE);

Net.AddResponser(Id<MSG_BZGC_FINISH_TASK_BATTLE>.Value, OnResponse_MSG_BZGC_FINISH_TASK_BATTLE);

Net.AddResponser(Id<MSG_BZGC_ENTER_PERSONAL_BATTLE>.Value, OnResponse_MSG_BZGC_ENTER_PERSONAL_BATTLE);

Net.AddResponser(Id<MSG_BZGC_FINISH_PERSONAL_BATTLE>.Value, OnResponse_MSG_BZGC_FINISH_PERSONAL_BATTLE);

Net.AddResponser(Id<MSG_ZGC_PLAYER_RANKING>.Value, OnResponse_MSG_ZGC_PLAYER_RANKING);

Net.AddResponser(Id<MSG_ZGC_FIND_PLAYER_INFO>.Value, OnResponse_MSG_ZGC_FIND_PLAYER_INFO);

Net.AddResponser(Id<MSG_ZGC_LEAVE_MATCHING>.Value, OnResponse_MSG_ZGC_LEAVE_MATCHING);

Net.AddResponser(Id<MSG_ZGC_TEAM_FIND_PLAYER_INFO>.Value, OnResponse_MSG_ZGC_TEAM_FIND_PLAYER_INFO);

Net.AddResponser(Id<MSG_BZGC_HERO_BATTLE_RESULT_FPS>.Value, OnResponse_MSG_BZGC_HERO_BATTLE_RESULT_FPS);

Net.AddResponser(Id<MSG_BZGC_SKILL_BATTLE_RESULT_FPS>.Value, OnResponse_MSG_BZGC_SKILL_BATTLE_RESULT_FPS);

Net.AddResponser(Id<MSG_BZGC_PLAYER_BATTLE_RESULT_FPS>.Value, OnResponse_MSG_BZGC_PLAYER_BATTLE_RESULT_FPS);

Net.AddResponser(Id<MSG_ZGC_CHALLENGE_PLAYER_REQUEST>.Value, OnResponse_MSG_ZGC_CHALLENGE_PLAYER_REQUEST);

Net.AddResponser(Id<MSG_ZGC_CHALLENGE_PLAYER_RESPONSE>.Value, OnResponse_MSG_ZGC_CHALLENGE_PLAYER_RESPONSE);

Net.AddResponser(Id<MSG_ZGC_CHALLENGE_PLAYER_CANCEL>.Value, OnResponse_MSG_ZGC_CHALLENGE_PLAYER_CANCEL);

Net.AddResponser(Id<MSG_ZGC_PLAYER_INVITE_FRIGHTING>.Value, OnResponse_MSG_ZGC_PLAYER_INVITE_FRIGHTING);

Net.AddResponser(Id<MSG_ZGC_INVITE_FRIGHTING_ERROR>.Value, OnResponse_MSG_ZGC_INVITE_FRIGHTING_ERROR);

Net.AddResponser(Id<MSG_BZGC_SURRENDER_RESULT>.Value, OnResponse_MSG_BZGC_SURRENDER_RESULT);

Net.AddResponser(Id<MSG_BZGC_BATTLE_FPS>.Value, OnResponse_MSG_BZGC_BATTLE_FPS);

Net.AddResponser(Id<CastSkillInfo>.Value, OnResponse_CastSkillInfo);

Net.AddResponser(Id<MSG_BZGC_PLAYER_BATTLE_FPS>.Value, OnResponse_MSG_BZGC_PLAYER_BATTLE_FPS);

Net.AddResponser(Id<MSG_ZGC_HERO_SKIN_INFO>.Value, OnResponse_MSG_ZGC_HERO_SKIN_INFO);

Net.AddResponser(Id<MSG_ZGC_HERO_INFO>.Value, OnResponse_MSG_ZGC_HERO_INFO);

Net.AddResponser(Id<MSG_ZGC_HERO_LIST>.Value, OnResponse_MSG_ZGC_HERO_LIST);

Net.AddResponser(Id<MSG_ZGC_SKILL_INFO>.Value, OnResponse_MSG_ZGC_SKILL_INFO);

Net.AddResponser(Id<MSG_ZGC_SKILL_LIST>.Value, OnResponse_MSG_ZGC_SKILL_LIST);

Net.AddResponser(Id<MSG_ZGC_UPDATE_HERO_POSITION>.Value, OnResponse_MSG_ZGC_UPDATE_HERO_POSITION);

Net.AddResponser(Id<MSG_ZGC_HERO_QUEUE_NAME>.Value, OnResponse_MSG_ZGC_HERO_QUEUE_NAME);

Net.AddResponser(Id<MSG_ZGC_CUR_HERO_QUEUE>.Value, OnResponse_MSG_ZGC_CUR_HERO_QUEUE);

Net.AddResponser(Id<MSG_ZGC_UPDATE_SKILL_POSITION>.Value, OnResponse_MSG_ZGC_UPDATE_SKILL_POSITION);

Net.AddResponser(Id<MSG_ZGC_SKILL_QUEUE_NAME>.Value, OnResponse_MSG_ZGC_SKILL_QUEUE_NAME);

Net.AddResponser(Id<MSG_ZGC_CUR_SKILL_QUEUE>.Value, OnResponse_MSG_ZGC_CUR_SKILL_QUEUE);

Net.AddResponser(Id<MSG_ZGC_UPGRADE_HERO>.Value, OnResponse_MSG_ZGC_UPGRADE_HERO);

Net.AddResponser(Id<MSG_ZGC_UPGRADE_SKILL>.Value, OnResponse_MSG_ZGC_UPGRADE_SKILL);

Net.AddResponser(Id<HERO_COMMENT>.Value, OnResponse_HERO_COMMENT);

Net.AddResponser(Id<MSG_ZGC_HERO_COMMENT>.Value, OnResponse_MSG_ZGC_HERO_COMMENT);

Net.AddResponser(Id<MSG_ZGC_HERO_COMMENT_LIKES>.Value, OnResponse_MSG_ZGC_HERO_COMMENT_LIKES);

Net.AddResponser(Id<MSG_ZGC_ADD_HERO_COMMENT>.Value, OnResponse_MSG_ZGC_ADD_HERO_COMMENT);

Net.AddResponser(Id<MSG_ZGC_PLAYER_LEVEL>.Value, OnResponse_MSG_ZGC_PLAYER_LEVEL);

Net.AddResponser(Id<MSG_ZGC_HERO_COUNT>.Value, OnResponse_MSG_ZGC_HERO_COUNT);

Net.AddResponser(Id<MSG_ZGC_SKILL_COUNT>.Value, OnResponse_MSG_ZGC_SKILL_COUNT);

Net.AddResponser(Id<MSG_ZGC_CALL_PET>.Value, OnResponse_MSG_ZGC_CALL_PET);

Net.AddResponser(Id<MSG_ZGC_UPDATE_HEROS>.Value, OnResponse_MSG_ZGC_UPDATE_HEROS);

Net.AddResponser(Id<MSG_ZGC_UPDATE_SKILLS>.Value, OnResponse_MSG_ZGC_UPDATE_SKILLS);

Net.AddResponser(Id<MSG_ZGC_USE_HERO_SKIN>.Value, OnResponse_MSG_ZGC_USE_HERO_SKIN);

Net.AddResponser(Id<MSG_ZGC_PLAYER_LADDER_LEVEL>.Value, OnResponse_MSG_ZGC_PLAYER_LADDER_LEVEL);

Net.AddResponser(Id<MSG_ZGC_BUY_HERO_SKIN>.Value, OnResponse_MSG_ZGC_BUY_HERO_SKIN);

Net.AddResponser(Id<MSG_ZGC_TASK_LIST>.Value, OnResponse_MSG_ZGC_TASK_LIST);

Net.AddResponser(Id<MSG_ZGC_TASK_INFO>.Value, OnResponse_MSG_ZGC_TASK_INFO);

Net.AddResponser(Id<MSG_ZGC_TASK_CHANGE>.Value, OnResponse_MSG_ZGC_TASK_CHANGE);

Net.AddResponser(Id<MSG_ZGC_GET_TASK_RESULT>.Value, OnResponse_MSG_ZGC_GET_TASK_RESULT);

Net.AddResponser(Id<MSG_ZGC_TASK_COLLECT>.Value, OnResponse_MSG_ZGC_TASK_COLLECT);

Net.AddResponser(Id<MSG_ZGC_TASK_COMPLETE>.Value, OnResponse_MSG_ZGC_TASK_COMPLETE);

Net.AddResponser(Id<MSG_ZGC_EMAIL_REMIND>.Value, OnResponse_MSG_ZGC_EMAIL_REMIND);

Net.AddResponser(Id<MSG_ZGC_EMAIL_OPENE_BOX>.Value, OnResponse_MSG_ZGC_EMAIL_OPENE_BOX);

Net.AddResponser(Id<MSG_ZGC_EMAIL_ITEM>.Value, OnResponse_MSG_ZGC_EMAIL_ITEM);

Net.AddResponser(Id<MSG_ZGC_EMAIL_READ>.Value, OnResponse_MSG_ZGC_EMAIL_READ);

Net.AddResponser(Id<MSG_ZGC_ATTACHMENT_PICKUP>.Value, OnResponse_MSG_ZGC_ATTACHMENT_PICKUP);

Net.AddResponser(Id<MSG_ZGC_CHAT_PLAYER_INFO>.Value, OnResponse_MSG_ZGC_CHAT_PLAYER_INFO);

Net.AddResponser(Id<MSG_ZGC_CHAT_WORDS>.Value, OnResponse_MSG_ZGC_CHAT_WORDS);

Net.AddResponser(Id<MSG_ZGC_PERSON_CHAT_WORDS>.Value, OnResponse_MSG_ZGC_PERSON_CHAT_WORDS);

Net.AddResponser(Id<MSG_GC_CHANGE_WORLD_ROOM>.Value, OnResponse_MSG_GC_CHANGE_WORLD_ROOM);

Net.AddResponser(Id<MSG_CMGC_WORLD_ROOM_INFO>.Value, OnResponse_MSG_CMGC_WORLD_ROOM_INFO);

Net.AddResponser(Id<MSG_CMGC_GET_WORLD_ROOM_LIST>.Value, OnResponse_MSG_CMGC_GET_WORLD_ROOM_LIST);

Net.AddResponser(Id<MSG_ZGC_CHAT_TRUMPET>.Value, OnResponse_MSG_ZGC_CHAT_TRUMPET);

Net.AddResponser(Id<MSG_ZGC_CHAT_TRUMPET_RESULT>.Value, OnResponse_MSG_ZGC_CHAT_TRUMPET_RESULT);

Net.AddResponser(Id<MSG_GC_ANNOUNCEMENT>.Value, OnResponse_MSG_GC_ANNOUNCEMENT);

Net.AddResponser(Id<MSG_ZGC_NEARBY_EMOJI>.Value, OnResponse_MSG_ZGC_NEARBY_EMOJI);

Net.AddResponser(Id<MSG_ZGC_TIP_OFF>.Value, OnResponse_MSG_ZGC_TIP_OFF);

Net.AddResponser(Id<MSG_ZGC_CHAT_BROADCAST>.Value, OnResponse_MSG_ZGC_CHAT_BROADCAST);

Net.AddResponser(Id<MSG_GC_NEARBY_ROOM>.Value, OnResponse_MSG_GC_NEARBY_ROOM);

Net.AddResponser(Id<MSG_ZGC_SILENCE>.Value, OnResponse_MSG_ZGC_SILENCE);

Net.AddResponser(Id<MSG_ZGC_ACTIVITY_CHAT_BUBBLE>.Value, OnResponse_MSG_ZGC_ACTIVITY_CHAT_BUBBLE);

Net.AddResponser(Id<MSG_ZGC_UPLOAD_PHOTO>.Value, OnResponse_MSG_ZGC_UPLOAD_PHOTO);

Net.AddResponser(Id<MSG_ZGC_REMOVE_PHOTO>.Value, OnResponse_MSG_ZGC_REMOVE_PHOTO);

Net.AddResponser(Id<MSG_ZGC_PHOTO_LIST>.Value, OnResponse_MSG_ZGC_PHOTO_LIST);

Net.AddResponser(Id<MSG_ZGC_LIKE_SPACE>.Value, OnResponse_MSG_ZGC_LIKE_SPACE);

Net.AddResponser(Id<POP_RANK_PLAYER>.Value, OnResponse_POP_RANK_PLAYER);

Net.AddResponser(Id<MSG_ZGC_POP_RANK>.Value, OnResponse_MSG_ZGC_POP_RANK);

Net.AddResponser(Id<MSG_ZGC_SHOP_ITEM>.Value, OnResponse_MSG_ZGC_SHOP_ITEM);

Net.AddResponser(Id<MSG_ZGC_SHOP_LIST>.Value, OnResponse_MSG_ZGC_SHOP_LIST);

Net.AddResponser(Id<MSG_ZGC_SHOP_BUY_RESULT>.Value, OnResponse_MSG_ZGC_SHOP_BUY_RESULT);

Net.AddResponser(Id<MSG_ZGC_SHOP_GET_SSR>.Value, OnResponse_MSG_ZGC_SHOP_GET_SSR);

Net.AddResponser(Id<VEDIO_HERO>.Value, OnResponse_VEDIO_HERO);

Net.AddResponser(Id<VEDIO_SKILL>.Value, OnResponse_VEDIO_SKILL);

Net.AddResponser(Id<VEDIO_PLAYER>.Value, OnResponse_VEDIO_PLAYER);

Net.AddResponser(Id<MSG_ZGC_VEDIO_INFO>.Value, OnResponse_MSG_ZGC_VEDIO_INFO);

Net.AddResponser(Id<MSG_ZGC_BATTLE_VEDIO_LIST>.Value, OnResponse_MSG_ZGC_BATTLE_VEDIO_LIST);

Net.AddResponser(Id<MSG_ZGC_CHAT_VEDIO>.Value, OnResponse_MSG_ZGC_CHAT_VEDIO);

Net.AddResponser(Id<MSG_ZGC_CHANGE_CHANNEL>.Value, OnResponse_MSG_ZGC_CHANGE_CHANNEL);

Net.AddResponser(Id<MSG_ZGC_RECHARGE_HISTORY>.Value, OnResponse_MSG_ZGC_RECHARGE_HISTORY);

Net.AddResponser(Id<MSG_ZGC_RECHARGE_INFO>.Value, OnResponse_MSG_ZGC_RECHARGE_INFO);

}
}
}
