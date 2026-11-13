// ============================================================
// Type  : <>c__DisplayClass101_0
// Token : 0x200032D
// ============================================================

public class <>c__DisplayClass101_0
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001AA3
    public bool hightLight;

    // Token: 0x4001AA4
    public GameObject targetSkeleton;

    // Token: 0x4001AA5
    public TweenCallback <>9__0;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x600205D
    // RVA   : 0x42F150   Offset: 0x42DF50   Length: 0x7
    public void /*ctor*/()
    {
        ZhSegment.Initialize(this,0);
    }

    // Token : 0x600205E
    // RVA   : 0x616500   Offset: 0x615300   Length: 0xD0
    internal void <ManageHeroFace>b__0()
    {
        ulong uVar1;
        ulong local_18;
        ulong uStack_10;
        if (this.targetSkeleton != null) {
          uVar1 = GameObject.GetComponent(this.targetSkeleton,DAT_181e566a8);
          if (!this.hightLight) {
            local_18 = 0;
            uStack_10 = 0;
            Color.ctor(&local_18,0x3ecccccd,0x3ecccccd,0x3ecccccd,0);
          }
          else {
            puVar2 = (uint32 *)FUN_180f24d00(&local_18,0);
            local_18._0_4_ = *puVar2;
            local_18._4_4_ = puVar2[1];
            uStack_10._0_4_ = puVar2[2];
            uStack_10._4_4_ = puVar2[3];
          }
          uVar1 = DOTweenModuleUI.DOColor(uVar1,&local_18,0x3e99999a,0);
          TweenSettingsExtensions.SetUpdate(uVar1,1,DAT_181ea5848);
          return;
        }
    }

}
