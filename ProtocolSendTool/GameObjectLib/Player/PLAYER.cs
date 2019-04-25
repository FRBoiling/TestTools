using Message.Server.Gate.Protocol.GateC;

public partial class PLAYER
{
    public bool IsLogin = false;

    public int Channel { get; set; }
    public int MinChannel { get; set; }
    public int MaxChannel { get; set; }
    public MSG_GC_CHARACTER_INFO CharInfo { get; set; }

    public int CurrentCharacterUid; // NOTE : 角色固有id
    public int CurrentCharacterId; // NOTE : 区内使用的实例id
    public int CurrentPetId; // NOTE : 区内使用的实例id
    public int InTriangleIndex = -1; // 当前人物在第几个方格中
    public int GameServerID = 101;
    public int ChatServerID = 101;
    public string AccountName = "";
    public string PassWord = "";
    public string GameServerName = "";
    public int PayServerID = 1;
    public int EquipPetID;
    public int Token; //用于连接
    public bool IsChangeChannel = false;
    public bool isEnterByTrigger;
    public bool InFindingTarget;
    public string FindindGuideNPCName = null;

    // NOTE : 当前角色信息
    public bool IsDirtyInput = false;
    public bool IsFindPathInClient = false;
    public bool IsFindPathByJoystick = false;

    public bool IsMaskAll = false;
    public bool MapTransforming = false;

    public void CheckMaskALL(bool isEnable)
    {
        IsMaskAll = isEnable;
    }
    public float SendTriggerDelta = 2f;
    public float LastSendTrigger = 0f;
    public bool InputIsUp = false;
    public float TouchHoldTime = 0.0f;
    public bool JoystickTouchMoved = false;
    public bool SendTriggerWrap = false;
    public float SkillAndFindTouchTime = 0.0f;
}
