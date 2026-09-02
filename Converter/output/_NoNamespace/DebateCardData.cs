// ============================================================
// Type  : DebateCardData
// Token : 0x200025A
// ============================================================

public class DebateCardData
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001264
    public bool isPlayerCard;

    // Token: 0x4001265
    public bool isSpeCard;

    // Token: 0x4001266
    public int rareLv;

    // Token: 0x4001267
    public int targetAttriID;

    // Token: 0x4001268
    public int attriLv;

    // Token: 0x4001269
    public static List<string> SpeCardName;

    // Token: 0x400126A
    public static List<string> SpeCardDescribe;

    // Token: 0x400126B
    public static List<string> SpeCardTalk;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6001347
    // RVA   : 0xA5D640   Offset: 0xA5BE40   Length: 0x55
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

    // Token : 0x6001348
    // RVA   : 0xA5D320   Offset: 0xA5BB20   Length: 0x31A
    private static void /*cctor*/()
    {
        var pStatics = *(int64*)(DAT_181d9aa08 + 184);
        long lVar1;
        lVar1 = il2cpp_internal(DAT_181d72a30);
        FUN_180f58a90(lVar1,DAT_181d7c250);
        if (lVar1 != null) {
          FUN_181827900(lVar1,"道破",DAT_181d7c3d0);
          FUN_181827900(lVar1,"怒骂",DAT_181d7c3d0);
          FUN_181827900(lVar1,"反论",DAT_181d7c3d0);
          FUN_181827900(lVar1,"无视",DAT_181d7c3d0);
          FUN_181827900(lVar1,"冷静",DAT_181d7c3d0);
          plVar2 = pStatics;
          *plVar2 = lVar1;
          il2cpp_internal(plVar2,lVar1);
          lVar1 = il2cpp_internal(DAT_181d72a30);
          FUN_180f58a90(lVar1,DAT_181d7c250);
          if (lVar1 != null) {
            FUN_181827900(lVar1,"无视普通卡牌并造成15伤害",DAT_181d7c3d0);
            FUN_181827900(lVar1,"对方下回合无法出牌",DAT_181d7c3d0);
            FUN_181827900(lVar1,"使对方出牌反作用于自身",DAT_181d7c3d0);
            FUN_181827900(lVar1,"无视对方卡牌对我方效果",DAT_181d7c3d0);
            FUN_181827900(lVar1,"恢复自身30耐心\n抵消愤怒效果",DAT_181d7c3d0);
            plVar2 = (int64 *)(pStatics + 8);
            *plVar2 = lVar1;
            il2cpp_internal(plVar2,lVar1);
            lVar1 = il2cpp_internal(DAT_181d72a30);
            FUN_180f58a90(lVar1,DAT_181d7c250);
            if (lVar1 != null) {
              FUN_181827900(lVar1,"这些言语不过诡辩而已，我早已看破！",DAT_181d7c3d0);
              FUN_181827900(lVar1,"吞吞吐吐，瞻前顾后，真乃无胆鼠辈！",DAT_181d7c3d0);
              FUN_181827900(lVar1,"若将你所说的话如数奉还，又该如何应对？",DAT_181d7c3d0);
              FUN_181827900(lVar1,"你在说什么？我好像没听清...",DAT_181d7c3d0);
              FUN_181827900(lVar1,"事已至此，需先冷静下来，稳住阵脚。",DAT_181d7c3d0);
              plVar2 = (int64 *)(pStatics + 16);
              *plVar2 = lVar1;
              il2cpp_internal(plVar2,lVar1);
              return;
            }
          }
        }
    }

}
