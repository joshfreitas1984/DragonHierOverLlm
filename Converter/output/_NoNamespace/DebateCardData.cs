// ============================================================
// Type  : DebateCardData
// Token : 0x2000267
// ============================================================

public class DebateCardData
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001345
    public bool isPlayerCard;

    // Token: 0x4001346
    public bool isSpeCard;

    // Token: 0x4001347
    public int rareLv;

    // Token: 0x4001348
    public int targetAttriID;

    // Token: 0x4001349
    public int attriLv;

    // Token: 0x400134A
    public static List<string> SpeCardName;

    // Token: 0x400134B
    public static List<string> SpeCardDescribe;

    // Token: 0x400134C
    public static List<string> SpeCardTalk;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60013F0
    // RVA   : 0x6682F0   Offset: 0x6670F0   Length: 0x55
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

    // Token : 0x60013F1
    // RVA   : 0x667FD0   Offset: 0x666DD0   Length: 0x31A
    private static void /*cctor*/()
    {
        var pStatics = *(int64*)(DAT_181ea00a8 + 184);
        long lVar1;
        lVar1 = il2cpp_internal(DAT_181e77728);
        FUN_1810f3480(lVar1,DAT_181e861f0);
        if (lVar1 != null) {
          FUN_18175de30(lVar1,"道破",DAT_181e86370);
          FUN_18175de30(lVar1,"怒骂",DAT_181e86370);
          FUN_18175de30(lVar1,"反论",DAT_181e86370);
          FUN_18175de30(lVar1,"无视",DAT_181e86370);
          FUN_18175de30(lVar1,"冷静",DAT_181e86370);
          plVar2 = pStatics;
          *plVar2 = lVar1;
          il2cpp_internal(plVar2,lVar1);
          lVar1 = il2cpp_internal(DAT_181e77728);
          FUN_1810f3480(lVar1,DAT_181e861f0);
          if (lVar1 != null) {
            FUN_18175de30(lVar1,"无视普通卡牌并造成15伤害",DAT_181e86370);
            FUN_18175de30(lVar1,"对方下回合无法出牌",DAT_181e86370);
            FUN_18175de30(lVar1,"使对方出牌反作用于自身",DAT_181e86370);
            FUN_18175de30(lVar1,"无视对方卡牌对我方效果",DAT_181e86370);
            FUN_18175de30(lVar1,"恢复自身30耐心\n抵消愤怒效果",DAT_181e86370);
            DebateCardData.SpeCardDescribe = lVar1;
            lVar1 = il2cpp_internal(DAT_181e77728);
            FUN_1810f3480(lVar1,DAT_181e861f0);
            if (lVar1 != null) {
              FUN_18175de30(lVar1,"这些言语不过诡辩而已，我早已看破！",DAT_181e86370);
              FUN_18175de30(lVar1,"吞吞吐吐，瞻前顾后，真乃无胆鼠辈！",DAT_181e86370);
              FUN_18175de30(lVar1,"若将你所说的话如数奉还，又该如何应对？",DAT_181e86370);
              FUN_18175de30(lVar1,"你在说什么？我好像没听清...",DAT_181e86370);
              FUN_18175de30(lVar1,"事已至此，需先冷静下来，稳住阵脚。",DAT_181e86370);
              DebateCardData.SpeCardTalk = lVar1;
              return;
            }
          }
        }
    }

}
