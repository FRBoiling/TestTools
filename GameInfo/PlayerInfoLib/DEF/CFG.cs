// NOTE : 游戏中使用的环境变量


static public class CFG
{
    static public bool isEnableDecalShadow = true;
    static public bool isFirEnter = true;
    static public bool isEnableBGM = true;
    static public bool isEnableSound = true;
    static public bool isEnableDisPlayTeam = true;
    static public bool isEnableDisPlayGroup = false;
    static public bool isEnableMaskPC = false;
    static public bool isEnableMaskEff = false;

    static public float minCameraDistance = 15;
    static public float maxCameraDistance = 35;
    static public float CameraDistance = 23f;

    static public string Language = "chs";
    static public string last_logined_id = "";
    static public string last_logined_ip = "";
    static public int last_play_character_uid = 0;

    static public string AppName = "com.wanxin.zoo";
    static public bool DebugMode = true;
    //账号输入，渠道包需关闭
    static public bool LoginInput = true;
    static public bool UseReconnect = true;
    static public string Version = "1.9.0.0";
    //static public string Version = "1.8.6.0";
    static public bool GenerateAllResXml = false;

    static public bool MapGridDebug = false;

    static public bool isOutlineOn = true;

}

static public class DEV
{
	static public bool isTest_SlowMode = false;
}

static public class HOST
{
    static public bool isDomain = false;
}


static public class CFG_SAVE
{
    static string key_logined_id = "LOGINED_ID";
	static string key_logined_pw = "LOGINED_PW";
    static string key_logined_server_key = "LOGINED_SERVER_KEY";
    static string key_logined_server_id = "LOGINED_SERVER_ID";
    static string key_played_character_uid = "PLAYED_CHARACTER_UID";

    static string key_graphic_decalshadow = "GRAPHIC_DECALSHADOW";
    static string key_graphic_cameradistance = "GRAPHIC_CAMDISTANCE";
    static string key_sound_bgm = "SOUND_BGM";
    static string key_sound_sound = "SOUND_SOUND";
	static string key_graphic_displayteam = "GRAPHIC_DISPLAY_TEAM";
	static string key_graphic_displaygroup = "GRAPHIC_DISPLAY_GROUP";
	static string key_graphic_maskpc = "GRAPHIC_MASKPC";
	static string key_graphic_maskeff = "GRAPHIC_MASKEFF";
    static string key_save_server_id = "ServerId";
    static string key_save_server_time = "ServerTime";
    static string key_save_server_cnt = "ServerCnt";

    static string key_fir_enter = "FIR_ENTER";
}