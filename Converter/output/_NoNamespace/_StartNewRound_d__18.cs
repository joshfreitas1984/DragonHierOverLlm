// ============================================================
// Type  : <StartNewRound>d__18
// Token : 0x20002DF
// ============================================================

public class <StartNewRound>d__18
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x400172E
    private int <>1__state;

    // Token: 0x400172F
    private object <>2__current;

    // Token: 0x4001730
    public float waitTime;

    // Token: 0x4001731
    public IdentifyMatchController <>4__this;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x600180B
    // RVA   : 0x219070   Offset: 0x217870   Length: 0x24
    public void /*ctor*/(int <>1__state)
    {
        ZhSegment.Initialize(this,0);
        this.<>1__state = <>1__state;
    }

    // Token : 0x600180C
    // RVA   : 0x245810   Offset: 0x244010   Length: 0x3
    private virtual void System.IDisposable.Dispose()
    {
    }

    // Token : 0x600180D
    // RVA   : 0x8D15D0   Offset: 0x8CFDD0   Length: 0x7A8
    private virtual bool MoveNext()
    {
        float fVar1;
        long lVar2;
        int iVar3;
        ulong uVar4;
        long lVar5;
        long lVar6;
        ulong uVar8;
        int iVar10;
        int iVar11;
        float fVar12;
        float fVar13;
        ulong in_stack_fffffffffffffef0;
        uint uVar14;
        uint local_e8;
        uint local_e4;
        uint local_e0;
        ulong local_d8;
        uint local_d0;
        byte[] local_c8 = new byte[16];
        ulong local_b8;
        ulong uStack_b0;
        ulong local_a8;
        ulong uStack_a0;
        ulong local_98;
        ulong uStack_90;
        lVar2 = this.<>4__this;
        if (this.<>1__state == 0) {
          this.<>1__state = 0xffffffff;
          uVar4 = new WaitForSecondsRealtime();
          this.<>2__current = uVar4;
          uVar4 = 1;
          this.<>1__state = 1;
        }
        else {
          if (this.<>1__state == 1) {
            this.<>1__state = 0xffffffff;
            if ((lVar2 == null) || (*(int64 *)(lVar2 + 96) == 0)) goto LAB_1808d1d6d;
            if (*(int *)(*(int64 *)(lVar2 + 96) + 24) == 5) {
              IdentifyMatchController.HideIdentifyMatchUI(lVar2,0);
            }
            else {
              iVar11 = 0;
              *(uint64 *)(lVar2 + 64) = 0;
              if (*(int64 *)(lVar2 + 40) == 0) {
        LAB_1808d1d6d:
                          // WARNING: Subroutine does not return
                FUN_1800d6620();
              }
              GameObject.SetActive(*(int64 *)(lVar2 + 40),0,0);
              if (((*(int64 *)(lVar2 + 32) == 0) ||
                  (lVar5 = GameObject.get_transform(*(int64 *)(lVar2 + 32),0)) == null) ||
                 (lVar5 = Transform.Find(lVar5,"TreasureGrid",0)) == null) goto LAB_1808d1d6d;
              uVar4 = Component.get_gameObject(lVar5,0);
              GlobalData.DeleteAllChild(uVar4,0);
              fVar13 = -999999.0;
              iVar10 = (int)(*(float *)(lVar2 + 80) * 0.5 + 5.0);
              if (*(int64 *)(lVar2 + 72) == 0) goto LAB_1808d1d6d;
              FUN_180f56130(*(int64 *)(lVar2 + 72),DAT_181d61c78);
              if (0 < iVar10) {
                do {
                  uVar14 = (uint32)((uint64)in_stack_fffffffffffffef0 >> 32);
                  lVar5 = FUN_18046c0a0(0);
                  fVar1 = *(float *)(lVar2 + 80);
                  fVar12 = (float)Random.Range();
                  if (lVar5 == null) goto LAB_1808d1d6d;
                  lVar5 = GameController.GenerateRandomItem
                                    (lVar5,4,fVar12 + fVar1,0,1,CONCAT44(uVar14,0xffffffff),0,0,0);
                  if (((*(int64 *)(lVar2 + 32) == 0) ||
                      (lVar6 = GameObject.get_transform(*(int64 *)(lVar2 + 32),0)) == null) ||
                     (lVar6 = Transform.Find(lVar6,"TreasureGrid",0)) == null) goto LAB_1808d1d6d;
                  uVar4 = Component.get_gameObject(lVar6,0);
                  lVar6 = FUN_18046c1a0(0);
                  if (lVar6 == null) goto LAB_1808d1d6d;
                  uVar8 = *(uint64 *)(lVar6 + 160);
                  uVar4 = GlobalData.AddChild(uVar4,uVar8,0);
                  *(uint64 *)(lVar2 + 112) = uVar4;
                  if ((*(int64 *)(lVar2 + 112) == 0) ||
                     (lVar6 = GameObject.GetComponent(*(int64 *)(lVar2 + 112),DAT_181da0070),
                     lVar6 == null)) goto LAB_1808d1d6d;
                  *(int64 *)(lVar6 + 32) = lVar5;
                  if ((*(int64 *)(lVar2 + 112) == 0) ||
                     (lVar6 = GameObject.GetComponent(*(int64 *)(lVar2 + 112),DAT_181da0070),
                     lVar6 == null)) goto LAB_1808d1d6d;
                  *(uint32 *)(lVar6 + 40) = 6;
                  if (*(int64 *)(lVar2 + 112) == 0) goto LAB_1808d1d6d;
                  lVar6 = GameObject.get_transform(*(int64 *)(lVar2 + 112),0);
                  puVar7 = (uint64 *)Vector3.get_zero(local_c8,0);
                  if (lVar6 == null) goto LAB_1808d1d6d;
                  local_d0 = *(uint32 *)(puVar7 + 1);
                  local_d8 = *puVar7;
                  Transform.set_localScale(lVar6,&local_d8,0);
                  lVar6 = *(int64 *)(lVar2 + 112);
                  if (iVar11 == iVar10 + -1) {
                    if (lVar6 == null) goto LAB_1808d1d6d;
                    uVar4 = GameObject.get_transform(lVar6,0);
                    uVar4 = ShortcutExtensions.DOScale(uVar4);
                    uVar4 = TweenSettingsExtensions.SetDelay(uVar4,(float)iVar11 * 0.1,DAT_181d97978);
                    uVar8 = new OnTooltipCB(lVar2,DAT_181d52190,0);
                    TweenSettingsExtensions.OnComplete(uVar4,uVar8,DAT_181d96ee8);
                  }
                  else {
                    if (lVar6 == null) goto LAB_1808d1d6d;
                    uVar4 = GameObject.get_transform(lVar6,0);
                    uVar4 = ShortcutExtensions.DOScale(uVar4);
                    TweenSettingsExtensions.SetDelay(uVar4,(float)iVar11 * 0.1,DAT_181d97978);
                  }
                  if (lVar5 == null) goto LAB_1808d1d6d;
                  iVar3 = ItemData.GetTreasureRealValue(lVar5,0);
                  if (fVar13 < (float)iVar3) {
                    iVar3 = ItemData.GetTreasureRealValue(lVar5,0);
                    fVar13 = (float)iVar3;
                    if (*(int64 *)(lVar2 + 72) == 0) goto LAB_1808d1d6d;
                    FUN_180f56130(*(int64 *)(lVar2 + 72),DAT_181d61c78);
        LAB_1808d1b7f:
                    if (*(int64 *)(lVar2 + 72) == 0) goto LAB_1808d1d6d;
                    FUN_181827900(*(int64 *)(lVar2 + 72),*(uint64 *)(lVar2 + 112),DAT_181d61bf8)
                    ;
                  }
                  else {
                    iVar3 = ItemData.GetTreasureRealValue(lVar5,0);
                    if ((float)iVar3 == fVar13) goto LAB_1808d1b7f;
                  }
                  uVar4 = *(uint64 *)(lVar2 + 112);
                  lVar5 = FUN_18046c6c0(0);
                  if (lVar5 == null) {
        LAB_1808d1d73:
                          // WARNING: Subroutine does not return
                    FUN_1800d6620();
                  }
                  uVar8 = TextureController.LoadAtlasSprite(lVar5,"UIAtlas","托盘",0);
                  local_e8 = 0;
                  local_e4 = 0xc1f00000;
                  local_b8 = 0;
                  uStack_b0 = 0;
                  local_e0 = 0;
                  FUN_1815cf310(&local_b8,&local_e8,DAT_181d92dc0);
                  in_stack_fffffffffffffef0 = 0;
                  local_98 = local_b8;
                  uStack_90 = uStack_b0;
                  local_a8 = 0;
                  uStack_a0 = 0;
                  lVar5 = GlobalData.AddImage(uVar4,0,uVar8,&local_98,&local_a8,0);
                  if ((lVar5 == null) || (lVar6 = GameObject.get_transform(lVar5,0)) == null)
                  goto LAB_1808d1d73;
                  Transform.SetAsFirstSibling(lVar6,0);
                  plVar9 = (int64 *)GameObject.GetComponent(lVar5,DAT_181d9fe50);
                  if (plVar9 == (int64 *)0) goto LAB_1808d1d73;
                  (**(code **)(*plVar9 + 0x408))(plVar9,*(uint64 *)(*plVar9 + 0x410));
                  plVar9 = (int64 *)GameObject.GetComponent(lVar5,DAT_181d9fe50);
                  if (plVar9 == (int64 *)0) goto LAB_1808d1d73;
                  (**(code **)(*plVar9 + 0x2c8))(plVar9,0);
                  iVar11 = iVar11 + 1;
                } while (iVar11 < iVar10);
              }
            }
          }
          uVar4 = 0;
        }
        return uVar4;
    }

    // Token : 0x600180E
    // RVA   : 0x20F140   Offset: 0x20D940   Length: 0x5
    private virtual object System.Collections.Generic.IEnumerator<System.object>.get_Current()
    {
        return this.<>2__current;
    }

    // Token : 0x600180F
    // RVA   : 0x8D1D80   Offset: 0x8D0580   Length: 0x3E
    private virtual void System.Collections.IEnumerator.Reset()
    {
        ulong uVar1;
        ulong uVar2;
        uVar1 = il2cpp_runtime_class_init(&DAT_181d682e8);
        uVar1 = il2cpp_internal(uVar1);
        NotSupportedException.ctor(uVar1,0);
        uVar2 = il2cpp_runtime_class_init(&DAT_181d7cc70);
    }

    // Token : 0x6001810
    // RVA   : 0x20F140   Offset: 0x20D940   Length: 0x5
    private virtual object System.Collections.IEnumerator.get_Current()
    {
        return this.<>2__current;
    }

}
