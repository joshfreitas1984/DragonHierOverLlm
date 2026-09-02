// ============================================================
// Type  : <EndParty>d__59
// Token : 0x2000311
// ============================================================

public class <EndParty>d__59
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x400188A
    private int <>1__state;

    // Token: 0x400188B
    private object <>2__current;

    // Token: 0x400188C
    public PartyController <>4__this;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6001953
    // RVA   : 0x219070   Offset: 0x217870   Length: 0x24
    public void /*ctor*/(int <>1__state)
    {
        ZhSegment.Initialize(this,0);
        this.<>1__state = <>1__state;
    }

    // Token : 0x6001954
    // RVA   : 0x245810   Offset: 0x244010   Length: 0x3
    private virtual void System.IDisposable.Dispose()
    {
    }

    // Token : 0x6001955
    // RVA   : 0x8C9A50   Offset: 0x8C8250   Length: 0x5E9
    private virtual bool MoveNext()
    {
        var pStatics = *(int64*)(DAT_181d6b060 + 184);
        long lVar1;
        long lVar2;
        uint uVar3;
        int iVar4;
        long lVar5;
        ulong uVar6;
        float fVar7;
        byte[] auVar8 = new byte[16];
        byte[] auVar9 = new byte[16];
        uint64 extraout_XMM0_Qb;
        lVar1 = this.<>4__this;
        if (this.<>1__state != 0) {
          if (this.<>1__state == 1) {
            this.<>1__state = 0xffffffff;
            if (lVar1 == null) throw; // [null/range check failed]
            PartyController.PartyEnd(lVar1,0);
          }
          return false;
        }
        this.<>1__state = 0xffffffff;
        if (lVar1 != null) {
          if (*(int64 *)(lVar1 + 72) != 0) {
            lVar5 = *(int64 *)(lVar1 + 168);
            if (lVar5 == null) throw; // [null/range check failed]
            HeroData.CosumeMedFood
                      (lVar5,*(int64 *)(lVar1 + 72),1,lVar5,*(uint32 *)(lVar1 + 200),0);
            if (*(int64 *)(lVar1 + 176) != 0) {
              HeroData.CosumeMedFood
                        (*(int64 *)(lVar1 + 176),*(uint64 *)(lVar1 + 72),1,
                         *(uint64 *)(lVar1 + 168),*(uint32 *)(lVar1 + 200),0);
            }
          }
          if (*(int64 *)(lVar1 + 104) != 0) {
            lVar5 = *(int64 *)(lVar1 + 168);
            if (lVar5 == null) throw; // [null/range check failed]
            HeroData.CosumeMedFood
                      (lVar5,*(int64 *)(lVar1 + 104),1,lVar5,*(uint32 *)(lVar1 + 200),0);
            if (*(int64 *)(lVar1 + 176) != 0) {
              HeroData.CosumeMedFood
                        (*(int64 *)(lVar1 + 176),*(uint64 *)(lVar1 + 104),1,
                         *(uint64 *)(lVar1 + 168),*(uint32 *)(lVar1 + 200),0);
            }
          }
          lVar5 = *(int64 *)(lVar1 + 168);
          Random.Range();
          PartyController.GetMaxHeroLv(lVar1,0);
          if (*(int64 *)(lVar1 + 168) != 0) {
            uVar3 = Mathf.RoundToInt();
            lVar2 = *(int64 *)(pStatics + 24);
            if ((lVar2 != null) && (iVar4 = Mathf.Clamp(uVar3,0,*(int *)(lVar2 + 24) + -1,0), lVar5 != null))
            {
              HeroData.AddTag(lVar5,iVar4 + 0x14e,0x41200000,0,1,1,0);
              lVar5 = *(int64 *)(lVar1 + 176);
              if (lVar5 != null) {
                fVar7 = (float)Random.Range();
                auVar8._0_8_ = PartyController.GetMaxHeroLv(lVar1,0);
                auVar8._8_8_ = extraout_XMM0_Qb;
                if (*(int64 *)(lVar1 + 176) == 0) throw; // [null/range check failed]
                auVar9._4_12_ = auVar8._4_12_;
                auVar9._0_4_ = ((float)auVar8._0_8_ + fVar7) -
                               (float)*(int *)(*(int64 *)(lVar1 + 176) + 184);
                uVar3 = Mathf.RoundToInt(auVar9._0_8_,0);
                lVar2 = *(int64 *)(pStatics + 24);
                if (lVar2 == null) throw; // [null/range check failed]
                iVar4 = Mathf.Clamp(uVar3,0,*(int *)(lVar2 + 24) + -1,0);
                HeroData.AddTag(lVar5,iVar4 + 0x14e,0x41200000,0,1,1,0);
              }
              lVar5 = *(int64 *)(lVar1 + 168);
              if (*(int *)(lVar1 + 24) == 1) {
                if (lVar5 == null) throw; // [null/range check failed]
                lVar5 = HeroData.GetForce(lVar5,0,0);
                fVar7 = (float)PartyController.GetMaxHeroLv(lVar1,0);
                if (lVar5 == null) throw; // [null/range check failed]
                ForceData.ChangeResource(lVar5,5,fVar7 * 50.0,1,1,0);
              }
              else {
                PartyController.GetMaxHeroLv(lVar1,0);
                if (lVar5 == null) throw; // [null/range check failed]
                HeroData.ChangeFame(lVar5);
              }
              if (*(int *)(lVar1 + 24) != 2) goto LAB_1808c9fa5;
              if ((*(int64 *)(lVar1 + 176) != 0) && (*(int64 *)(lVar1 + 168) != 0)) {
                HeroData.SetLover(*(int64 *)(lVar1 + 168),
                                   *(uint32 *)(*(int64 *)(lVar1 + 176) + 88),1,0);
                lVar5 = *(int64 *)(lVar1 + 168);
                if (lVar5 != null) {
                  if (*(int *)(lVar5 + 88) == 0) {
                    if (*(int64 *)(lVar5 + 0x330) == 0) throw; // [null/range check failed]
                    iVar4 = *(int *)(*(int64 *)(lVar5 + 0x330) + 24);
                    while (iVar4 = iVar4 + -1, -1 < iVar4) {
                      lVar5 = FUN_18046c0a0(0);
                      if (lVar5 == null) throw; // [null/range check failed]
                      lVar5 = *(int64 *)(lVar5 + 32);
                      if ((((*(int64 *)(lVar1 + 168) == 0) ||
                           (lVar2 = *(int64 *)(*(int64 *)(lVar1 + 168) + 0x330)) == null) ||
                          (uVar3 = FUN_1800d6750(lVar2,iVar4,DAT_181d68270), lVar5 == null)) ||
                         (lVar5 = WorldData.GetHero(lVar5,uVar3,0)) == null) throw; // [null/range check failed]
                      HeroData.ChangeFavor(lVar5);
                      lVar5 = FUN_18046c0a0(0);
                      if (lVar5 == null) throw; // [null/range check failed]
                      lVar5 = *(int64 *)(lVar5 + 32);
                      if (((*(int64 *)(lVar1 + 168) == 0) ||
                          (lVar2 = *(int64 *)(*(int64 *)(lVar1 + 168) + 0x330)) == null) ||
                         ((uVar3 = FUN_1800d6750(lVar2,iVar4,DAT_181d68270), lVar5 == null ||
                          (lVar5 = WorldData.GetHero(lVar5,uVar3,0)) == null))) throw; // [null/range check failed]
                      HeroData.CheckPlayerMakeLoverUnhappy(lVar5,0);
                    }
                  }
        LAB_1808c9fa5:
                  uVar6 = new WaitForSeconds();
                  this.<>2__current = uVar6;
                  this.<>1__state = 1;
                  return true;
                }
              }
            }
          }
        }
    }

    // Token : 0x6001956
    // RVA   : 0x20F140   Offset: 0x20D940   Length: 0x5
    private virtual object System.Collections.Generic.IEnumerator<System.object>.get_Current()
    {
        return this.<>2__current;
    }

    // Token : 0x6001957
    // RVA   : 0x8CA040   Offset: 0x8C8840   Length: 0x3E
    private virtual void System.Collections.IEnumerator.Reset()
    {
        ulong uVar1;
        ulong uVar2;
        uVar1 = il2cpp_runtime_class_init(&DAT_181d682e8);
        uVar1 = il2cpp_internal(uVar1);
        NotSupportedException.ctor(uVar1,0);
        uVar2 = il2cpp_runtime_class_init(&DAT_181d809a8);
    }

    // Token : 0x6001958
    // RVA   : 0x20F140   Offset: 0x20D940   Length: 0x5
    private virtual object System.Collections.IEnumerator.get_Current()
    {
        return this.<>2__current;
    }

}
