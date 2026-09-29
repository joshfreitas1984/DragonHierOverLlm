// ============================================================
// Type  : DebateCardData
// Token : 0x2000260
// ============================================================

public class DebateCardData
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001307
    public bool isPlayerCard;

    // Token: 0x4001308
    public bool isSpeCard;

    // Token: 0x4001309
    public int rareLv;

    // Token: 0x400130A
    public int targetAttriID;

    // Token: 0x400130B
    public int attriLv;

    // Token: 0x400130C
    public static List<string> SpeCardName;

    // Token: 0x400130D
    public static List<string> SpeCardDescribe;

    // Token: 0x400130E
    public static List<string> SpeCardTalk;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6001388
    // RVA   : 0xA50BF0   Offset: 0xA4FFF0   Length: 0x55
    public void /*ctor*/(bool _isPlayerCard, bool _isSpeCard, int _rareLv, int _targetAttriID, int _attriLv)
    {
        void DebateCardData.ctor
                     (int64 this,uint8 _isPlayerCard,uint8 _isSpeCard,uint32 _rareLv,
                     uint32 _targetAttriID,uint32 _attriLv)
        {
        ZhSegment.Initialize(this,0);
        this.targetAttriID = _targetAttriID;
        this.isPlayerCard = _isPlayerCard;
        this.rareLv = _rareLv;
        this.attriLv = _attriLv;
        this.isSpeCard = _isSpeCard;
    }

    // Token : 0x6001389
    // RVA   : 0xA508D0   Offset: 0xA4FCD0   Length: 0x31A
    private static void /*cctor*/()
    {
        var pStatics = *(int64*)(DAT_181dbfbd0 + 184);
        long lVar1;
        lVar1 = il2cpp_internal(DAT_181d97768);
        FUN_181330100(lVar1,DAT_181da3bf0);
        if (lVar1 != null) {
          FUN_18181e6b0(lVar1,"道破",DAT_181da3d70);
          FUN_18181e6b0(lVar1,"怒骂",DAT_181da3d70);
          FUN_18181e6b0(lVar1,"反论",DAT_181da3d70);
          FUN_18181e6b0(lVar1,"无视",DAT_181da3d70);
          FUN_18181e6b0(lVar1,"冷静",DAT_181da3d70);
          plVar2 = pStatics;
          *plVar2 = lVar1;
          il2cpp_internal(plVar2,lVar1);
          lVar1 = il2cpp_internal(DAT_181d97768);
          FUN_181330100(lVar1,DAT_181da3bf0);
          if (lVar1 != null) {
            FUN_18181e6b0(lVar1,"无视普通卡牌并造成15伤害",DAT_181da3d70);
            FUN_18181e6b0(lVar1,"对方下回合无法出牌",DAT_181da3d70);
            FUN_18181e6b0(lVar1,"使对方出牌反作用于自身",DAT_181da3d70);
            FUN_18181e6b0(lVar1,"无视对方卡牌对我方效果",DAT_181da3d70);
            FUN_18181e6b0(lVar1,"恢复自身30耐心\n抵消愤怒效果",DAT_181da3d70);
            DebateCardData.SpeCardDescribe = lVar1;
            lVar1 = il2cpp_internal(DAT_181d97768);
            FUN_181330100(lVar1,DAT_181da3bf0);
            if (lVar1 != null) {
              FUN_18181e6b0(lVar1,"这些言语不过诡辩而已，我早已看破！",DAT_181da3d70);
              FUN_18181e6b0(lVar1,"吞吞吐吐，瞻前顾后，真乃无胆鼠辈！",DAT_181da3d70);
              FUN_18181e6b0(lVar1,"若将你所说的话如数奉还，又该如何应对？",DAT_181da3d70);
              FUN_18181e6b0(lVar1,"你在说什么？我好像没听清...",DAT_181da3d70);
              FUN_18181e6b0(lVar1,"事已至此，需先冷静下来，稳住阵脚。",DAT_181da3d70);
              DebateCardData.SpeCardTalk = lVar1;
              return;
            }
          }
        }
    }

}
