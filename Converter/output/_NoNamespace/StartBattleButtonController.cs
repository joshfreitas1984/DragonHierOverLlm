// ============================================================
// Type  : StartBattleButtonController
// Token : 0x2000368
// ============================================================

public class StartBattleButtonController
{
    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6002138
    // RVA   : 0xC6FBB0   Offset: 0xC6E3B0   Length: 0x83
    public void OnPointerEnter()
    {
        long lVar1;
        lVar1 = Component.GetComponent(this,DAT_181d6ce40);
        if (lVar1 != null) {
          lVar1 = SkeletonGraphic.get_Skeleton(lVar1,0);
          if (lVar1 != null) {
            Skeleton.SetAttachment(lVar1,"startfight","战斗准备_动画/开战_高亮",0);
            return;
          }
        }
    }

    // Token : 0x6002139
    // RVA   : 0xC6FC40   Offset: 0xC6E440   Length: 0x83
    public void OnPointerExit()
    {
        long lVar1;
        lVar1 = Component.GetComponent(this,DAT_181d6ce40);
        if (lVar1 != null) {
          lVar1 = SkeletonGraphic.get_Skeleton(lVar1,0);
          if (lVar1 != null) {
            Skeleton.SetAttachment(lVar1,"startfight","战斗准备_动画/开战_常态",0);
            return;
          }
        }
    }

    // Token : 0x600213A
    // RVA   : 0x3A17B0   Offset: 0x39FFB0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_18044ef50(this,0);
    }

}
