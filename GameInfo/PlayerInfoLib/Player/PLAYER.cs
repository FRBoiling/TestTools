static public partial class PLAYER
{
    //public static MSG_GC_CHARACTER_INFO CharInfo;

    public static bool IsLogin = false;

    public static int Channel { get; set; }
    public static int MinChannel { get; set; }
    public static int MaxChannel { get; set; }


    static public int CurrentCharacterUid; // NOTE : 角色固有id
    static public int CurrentCharacterId; // NOTE : 区内使用的实例id
    static public int CurrentPetId; // NOTE : 区内使用的实例id
    static public int InTriangleIndex = -1; // 当前人物在第几个方格中
    public static int ServerGroupID = 1001;
    public static int ChatServerID = 1001;
    public static string username = "";
    public static string GameServerName = "";
    public static int PayServerID = 1;
    public static int EquipPetID;
    public static int Token; //用于连接
    public static bool IsChangeChannel = false;
    public static bool isEnterByTrigger;
    public static bool InFindingTarget;
    public static string FindindGuideNPCName = null;

    // NOTE : 当前角色信息
    static public bool IsDirtyInput = false;
    static public bool IsFindPathInClient = false;
    static public bool IsFindPathByJoystick = false;

    public static bool IsMaskAll = false;
    public static bool MapTransforming = false;

    public static void CheckMaskALL(bool isEnable)
	{
		IsMaskAll = isEnable;
	}
    static public float SendTriggerDelta = 2f;
    static public float LastSendTrigger = 0f;
    static public bool InputIsUp = false;
    static public float TouchHoldTime = 0.0f;
    static public bool JoystickTouchMoved = false;
    static public bool SendTriggerWrap = false;
    static public float SkillAndFindTouchTime = 0.0f;
}
