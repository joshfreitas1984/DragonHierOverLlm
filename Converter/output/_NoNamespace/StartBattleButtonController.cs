// ============================================================
// Type  : StartBattleButtonController
// Token : 0x200037C
// ============================================================

public class StartBattleButtonController
{
    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6002263
    // RVA   : 0xA08A00   Offset: 0xA07800   Length: 0x83
    public void OnPointerEnter()
    {
        long lVar1;
        lVar1 = Component.GetComponent(this,DAT_181e78a38);
        if (lVar1 != null) {
          lVar1 = SkeletonGraphic.get_Skeleton(lVar1,0);
          if (lVar1 != null) {
            Skeleton.SetAttachment(lVar1,"startfight","战斗准备_动画/开战_高亮",0);
            return;
          }
        }
    }

    // Token : 0x6002264
    // RVA   : 0xA08A90   Offset: 0xA07890   Length: 0x83
    public void OnPointerExit()
    {
        long lVar1;
        lVar1 = Component.GetComponent(this,DAT_181e78a38);
        if (lVar1 != null) {
          lVar1 = SkeletonGraphic.get_Skeleton(lVar1,0);
          if (lVar1 != null) {
            Skeleton.SetAttachment(lVar1,"startfight","战斗准备_动画/开战_常态",0);
            return;
          }
        }
    }

    // Token : 0x6002265
    // RVA   : 0x2110A0   Offset: 0x20FEA0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_180ae8740(this,0);
    }

}
