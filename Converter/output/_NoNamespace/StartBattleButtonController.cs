// ============================================================
// Type  : StartBattleButtonController
// Token : 0x200036F
// ============================================================

public class StartBattleButtonController
{
    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60021B9
    // RVA   : 0xC5F1D0   Offset: 0xC5E5D0   Length: 0x83
    public void OnPointerEnter()
    {
        long lVar1;
        lVar1 = Component.GetComponent(this,DAT_181d956e0);
        if (lVar1 != null) {
          lVar1 = SkeletonGraphic.get_Skeleton(lVar1,0);
          if (lVar1 != null) {
            Skeleton.SetAttachment(lVar1,"startfight","战斗准备_动画/开战_高亮",0);
            return;
          }
        }
    }

    // Token : 0x60021BA
    // RVA   : 0xC5F260   Offset: 0xC5E660   Length: 0x83
    public void OnPointerExit()
    {
        long lVar1;
        lVar1 = Component.GetComponent(this,DAT_181d956e0);
        if (lVar1 != null) {
          lVar1 = SkeletonGraphic.get_Skeleton(lVar1,0);
          if (lVar1 != null) {
            Skeleton.SetAttachment(lVar1,"startfight","战斗准备_动画/开战_常态",0);
            return;
          }
        }
    }

    // Token : 0x60021BB
    // RVA   : 0x3A17B0   Offset: 0x3A0BB0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_18044ef50(this,0);
    }

}
