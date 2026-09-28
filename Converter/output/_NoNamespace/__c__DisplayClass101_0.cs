// ============================================================
// Type  : <>c__DisplayClass101_0
// Token : 0x2000323
// ============================================================

public class <>c__DisplayClass101_0
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001A28
    public bool hightLight;

    // Token: 0x4001A29
    public GameObject targetSkeleton;

    // Token: 0x4001A2A
    public TweenCallback <>9__0;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6001FBE
    // RVA   : 0x210B70   Offset: 0x20FF70   Length: 0x7
    public void /*ctor*/()
    {
        ZhSegment.Initialize(this,0);
    }

    // Token : 0x6001FBF
    // RVA   : 0x8F5E80   Offset: 0x8F5280   Length: 0xD0
    internal void <ManageHeroFace>b__0()
    {
        ulong uVar1;
        ulong local_18;
        ulong uStack_10;
        if (this.targetSkeleton != null) {
          uVar1 = GameObject.GetComponent(this.targetSkeleton,DAT_181d735e0);
          if (!this.hightLight) {
            local_18 = 0;
            uStack_10 = 0;
            Color.ctor(&local_18,0x3ecccccd,0x3ecccccd,0x3ecccccd,0);
          }
          else {
            puVar2 = (uint32 *)FUN_1810d3570(&local_18,0);
            local_18._0_4_ = *puVar2;
            local_18._4_4_ = puVar2[1];
            uStack_10._0_4_ = puVar2[2];
            uStack_10._4_4_ = puVar2[3];
          }
          uVar1 = DOTweenModuleUI.DOColor(uVar1,&local_18,0x3e99999a,0);
          TweenSettingsExtensions.SetUpdate(uVar1,1,DAT_181dc1c20);
          return;
        }
    }

}
