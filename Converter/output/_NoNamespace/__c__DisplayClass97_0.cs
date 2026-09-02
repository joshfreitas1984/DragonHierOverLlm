// ============================================================
// Type  : <>c__DisplayClass97_0
// Token : 0x200031C
// ============================================================

public class <>c__DisplayClass97_0
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001931
    public bool hightLight;

    // Token: 0x4001932
    public GameObject targetSkeleton;

    // Token: 0x4001933
    public TweenCallback <>9__0;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6001F3E
    // RVA   : 0x210B70   Offset: 0x20F370   Length: 0x7
    public void /*ctor*/()
    {
        ZhSegment.Initialize(this,0);
    }

    // Token : 0x6001F3F
    // RVA   : 0x8D7D60   Offset: 0x8D6560   Length: 0xD0
    internal void <ManageHeroFace>b__0()
    {
        ulong uVar1;
        ulong local_18;
        ulong uStack_10;
        if (this.targetSkeleton != null) {
          uVar1 = GameObject.GetComponent(this.targetSkeleton,DAT_181da1430);
          if (!this.hightLight) {
            local_18 = 0;
            uStack_10 = 0;
            Color.ctor(&local_18,0x3ecccccd,0x3ecccccd,0x3ecccccd,0);
          }
          else {
            puVar2 = (uint32 *)FUN_181098a50(&local_18,0);
            local_18._0_4_ = *puVar2;
            local_18._4_4_ = puVar2[1];
            uStack_10._0_4_ = puVar2[2];
            uStack_10._4_4_ = puVar2[3];
          }
          uVar1 = DOTweenModuleUI.DOColor(uVar1,&local_18,0x3e99999a,0);
          TweenSettingsExtensions.SetUpdate(uVar1,1,DAT_181d98958);
          return;
        }
    }

}
