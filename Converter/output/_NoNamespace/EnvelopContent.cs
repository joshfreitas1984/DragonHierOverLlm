// ============================================================
// Type  : EnvelopContent
// Token : 0x2000029
// ============================================================

public class EnvelopContent
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x40000BD
    public Transform targetRoot;

    // Token: 0x40000BE
    public int padLeft;

    // Token: 0x40000BF
    public int padRight;

    // Token: 0x40000C0
    public int padBottom;

    // Token: 0x40000C1
    public int padTop;

    // Token: 0x40000C2
    public bool ignoreDisabled;

    // Token: 0x40000C3
    private bool mStarted;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60000A0
    // RVA   : 0x944EA0   Offset: 0x9442A0   Length: 0xB
    private void Start()
    {
        void FUN_180944ea0(int64 this)
        {
        this.mStarted = 1;
        EnvelopContent.Execute(this,0);
    }

    // Token : 0x60000A1
    // RVA   : 0x944E90   Offset: 0x944290   Length: 0xE
    private void OnEnable()
    {
        void FUN_180944e90(int64 this)
        {
        if (this.mStarted) {
          EnvelopContent.Execute(this,0);
          return;
        }
    }

    // Token : 0x60000A2
    // RVA   : 0x944B50   Offset: 0x943F50   Length: 0x339
    public void Execute()
    {
        float fVar1;
        int iVar2;
        int iVar3;
        bool cVar4;
        ulong uVar5;
        long lVar6;
        ulong uVar7;
        float fVar11;
        float fVar12;
        ulong local_78;
        uint local_70;
        byte[] local_68 = new byte[24];
        ulong local_50;
        ulong uStack_48;
        ulong local_40;
        uVar7 = this.targetRoot;
        uVar5 = Component.get_transform(this,0);
        cVar4 = Object.op_Equality(uVar7,uVar5,0);
        if (!cVar4) {
          uVar7 = this.targetRoot;
          uVar5 = Component.get_transform(this,0);
          cVar4 = NGUITools.IsChild(uVar7,uVar5,0);
          if (!cVar4) {
            lVar6 = Component.get_transform(this,0);
            if (lVar6 != null) {
              uVar7 = FUN_180daa030(lVar6,0);
              puVar8 = (uint64 *)
                       NGUIMath.CalculateRelativeWidgetBounds
                                 (local_68,uVar7,this.targetRoot,
                                  !this.ignoreDisabled,1,0);
              local_50 = *puVar8;
              uStack_48 = puVar8[1];
              local_40 = puVar8[2];
              pfVar9 = (float *)Bounds.get_min(&local_78,&local_50,0);
              fVar11 = (float)this.padLeft + *pfVar9;
              puVar8 = (uint64 *)Bounds.get_min(&local_78,&local_50,0);
              local_78 = *puVar8;
              local_70 = *(uint32 *)(puVar8 + 1);
              fVar12 = (float)this.padBottom + (float)((uint64)local_78 >> 32);
              pfVar9 = (float *)Bounds.get_max(&local_78,&local_50,0);
              iVar2 = this.padRight;
              fVar1 = *pfVar9;
              puVar8 = (uint64 *)Bounds.get_max(local_68,&local_50,0);
              iVar3 = this.padTop;
              local_78 = *puVar8;
              plVar10 = (int64 *)Component.GetComponent(this,DAT_181d97078);
              if (plVar10 != (int64 *)0) {
                (**(code **)(*plVar10 + 0x268))
                          (plVar10,fVar11,fVar12,((float)iVar2 + fVar1) - fVar11,
                           ((float)iVar3 + local_78._4_4_) - fVar12,*(uint64 *)(*plVar10 + 0x270));
                Component.BroadcastMessage(this,"UpdateAnchors",1);
                uVar7 = Component.get_gameObject(this,0);
                NGUITools.UpdateWidgetCollider(uVar7,0);
                return;
              }
            }
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          Debug.LogError("Target Root object should not be a parent of Envelop Content. Make it a sibling instead.",this,0);
        }
        else {
          Debug.LogError("Target Root object cannot be the same object that has Envelop Content. Make it a sibling instead.",this,0);
        }
    }

    // Token : 0x60000A3
    // RVA   : 0x944EB0   Offset: 0x9442B0   Length: 0xB
    public void /*ctor*/()
    {
        void FUN_180944eb0(int64 this)
        {
        this.ignoreDisabled = 1;
        FUN_18044ef50(this,0);
    }

}
