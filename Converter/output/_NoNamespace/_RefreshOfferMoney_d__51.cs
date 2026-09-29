// ============================================================
// Type  : <RefreshOfferMoney>d__51
// Token : 0x200014F
// ============================================================

public class <RefreshOfferMoney>d__51
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x400086D
    private int <>1__state;

    // Token: 0x400086E
    private object <>2__current;

    // Token: 0x400086F
    public AuctionController <>4__this;

    // Token: 0x4000870
    public HeroData newOfferHero;

    // Token: 0x4000871
    public float newOfferMoney;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000ADA
    // RVA   : 0x219070   Offset: 0x218470   Length: 0x24
    public void /*ctor*/(int <>1__state)
    {
        ZhSegment.Initialize(this,0);
        this.<>1__state = <>1__state;
    }

    // Token : 0x6000ADB
    // RVA   : 0x245810   Offset: 0x244C10   Length: 0x3
    private virtual void System.IDisposable.Dispose()
    {
    }

    // Token : 0x6000ADC
    // RVA   : 0x9C5700   Offset: 0x9C4B00   Length: 0x6A5
    private virtual bool MoveNext()
    {
        long lVar1;
        uint uVar2;
        ulong uVar3;
        ulong uVar4;
        ulong uVar5;
        ulong uVar6;
        long lVar7;
        long lVar8;
        long lVar9;
        float fVar10;
        float fVar11;
        int[] local_res8 = new int[2];
        lVar1 = this.<>4__this;
        local_res8[0] = 0;
        if (this.<>1__state != 0) {
          if (this.<>1__state == 1) {
            this.<>1__state = 0xffffffff;
            if (lVar1 == null) throw; // [null/range check failed]
            *(uint32 *)(lVar1 + 72) = 2;
          }
          return false;
        }
        this.<>1__state = 0xffffffff;
        if (lVar1 == null) throw; // [null/range check failed]
        *(uint32 *)(lVar1 + 72) = 3;
        AuctionController.SetOfferHero(lVar1,this.newOfferHero,0);
        AuctionController.SetOfferMoney(lVar1);
        *(uint32 *)(lVar1 + 148) = **(uint32 **)(DAT_181daf2e0 + 184);
        if (*(int64 *)(lVar1 + 152) != 0) {
          lVar7 = *(int64 *)(lVar1 + 120);
          if (*(int64 *)(lVar1 + 112) == 0) throw; // [null/range check failed]
          uVar2 = FUN_1817ebaf0(*(int64 *)(lVar1 + 112),*(int64 *)(lVar1 + 152),DAT_181d8b7b0);
          if (lVar7 == null) throw; // [null/range check failed]
          if (*(uint32 *)(lVar7 + 24) <= uVar2) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          lVar7 = lVar7[uVar2];
          if (lVar7 == null) throw; // [null/range check failed]
          uVar3 = GameObject.get_transform(lVar7,0);
          uVar3 = ShortcutExtensions.DOScale(uVar3);
          uVar3 = TweenSettingsExtensions.SetEase(uVar3,3,DAT_181dc1128);
          TweenSettingsExtensions.SetLoops(uVar3,2,1,DAT_181dc14d8);
          lVar7 = *(int64 *)(lVar1 + 120);
          lVar9 = **(int64 **)(DAT_181d761e8 + 184);
          if (*(int64 *)(lVar1 + 112) == 0) throw; // [null/range check failed]
          uVar2 = FUN_1817ebaf0(*(int64 *)(lVar1 + 112),*(uint64 *)(lVar1 + 152),DAT_181d8b7b0);
          if (lVar7 == null) throw; // [null/range check failed]
          if (*(uint32 *)(lVar7 + 24) <= uVar2) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          uVar3 = lVar7[uVar2];
          lVar7 = *(int64 *)(*(int64 *)(DAT_181daf2e0 + 184) + 8);
          if (lVar7 == null) throw; // [null/range check failed]
          uVar2 = FUN_180d96040(0,*(uint32 *)(lVar7 + 24),0);
          if (*(uint32 *)(lVar7 + 24) <= uVar2) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          uVar6 = lVar7[uVar2];
          local_res8[0] = (int)*(float *)(lVar1 + 144);
          uVar4 = Int32.ToString(local_res8,0);
          lVar7 = *(int64 *)(lVar1 + 88);
          if (lVar7 == null) throw; // [null/range check failed]
          if (*(int *)(lVar7 + 24) == 0) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          lVar8 = *(int64 *)(*(int64 *)(lVar7 + 16) + 32);
          if (lVar8 == null) throw; // [null/range check failed]
          uVar5 = ItemData.Name(lVar8,CONCAT71((int7)((uint64)*(int64 *)(lVar7 + 16) >> 8),1),0);
          uVar6 = String.Format(uVar6,uVar4,uVar5,0);
          if (lVar9 == null) throw; // [null/range check failed]
          HeroLittleTalkController.HeroTalk
                    (lVar9,uVar3,uVar6,0x40400000,*(uint64 *)(lVar1 + 192),2,0);
        }
        lVar7 = il2cpp_internal(DAT_181d93ce8);
        FUN_181330100(lVar7,DAT_181d8f0b0);
        uVar2 = 0;
        lVar9 = 32;
        while (lVar8 = *(int64 *)(lVar1 + 112)) != null {
          if ((int)*(uint32 *)(lVar8 + 24) <= (int)uVar2) {
            if (lVar7 == null) break;
            if (*(int *)(lVar7 + 24) != 0) {
              fVar10 = (float)Random.get_value(0);
              lVar9 = *(int64 *)(lVar1 + 88);
              if (lVar9 == null) break;
              if (*(int *)(lVar9 + 24) == 0) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              if (*(int64 *)(*(int64 *)(lVar9 + 16) + 32) == 0) break;
              fVar11 = (float)FUN_1810e3cd0();
              if (fVar11 < fVar10) {
                lVar9 = *(int64 *)(lVar1 + 112);
                uVar2 = FUN_180d96040(0,*(uint32 *)(lVar7 + 24),0);
                if (*(uint32 *)(lVar7 + 24) <= uVar2) {
                  ThrowHelper.ThrowArgumentOutOfRangeException(0);
                }
                if (lVar9 != null) {
                  uVar2 = lVar7[uVar2];
                  if (*(uint32 *)(lVar9 + 24) <= uVar2) {
                    ThrowHelper.ThrowArgumentOutOfRangeException(0);
                  }
                  *(uint64 *)(lVar1 + 168) =
                       lVar9[uVar2];
                  il2cpp_internal();
                  fVar10 = (float)Random.Range();
                  fVar10 = fVar10 * **(float **)(DAT_181daf2e0 + 184);
                  goto LAB_1809c5cf8;
                }
                break;
              }
            }
            *(uint64 *)(lVar1 + 168) = 0;
            fVar10 = 0.0;
        LAB_1809c5cf8:
            *(float *)(lVar1 + 160) = fVar10;
            uVar3 = new WaitForSeconds();
            this.<>2__current = uVar3;
            this.<>1__state = 1;
            return true;
          }
          if (*(uint32 *)(lVar8 + 24) <= uVar2) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          if (*(int64 *)(lVar9 + *(int64 *)(lVar8 + 16)) != *(int64 *)(lVar1 + 152)) {
            if ((*(int64 *)(lVar1 + 112) == 0) || (lVar8 = FUN_180002f80()) == null) break;
            if (*(int *)(lVar8 + 88) != 0) {
              fVar10 = this.newOfferMoney;
              if (((*(int64 *)(lVar1 + 112) == 0) || (lVar8 = FUN_180002f80()) == null) ||
                 (*(int64 *)(lVar8 + 0x220) == 0)) break;
              if (fVar10 <= (float)*(int *)(*(int64 *)(lVar8 + 0x220) + 24)) {
                if (lVar7 == null) break;
                FUN_18182a6c0(lVar7);
              }
            }
          }
          uVar2 = uVar2 + 1;
          lVar9 = lVar9 + 8;
        }
    }

    // Token : 0x6000ADD
    // RVA   : 0x20F140   Offset: 0x20E540   Length: 0x5
    private virtual object System.Collections.Generic.IEnumerator<System.object>.get_Current()
    {
        return this.<>2__current;
    }

    // Token : 0x6000ADE
    // RVA   : 0x9C5DB0   Offset: 0x9C51B0   Length: 0x3E
    private virtual void System.Collections.IEnumerator.Reset()
    {
        ulong uVar1;
        ulong uVar2;
        uVar1 = il2cpp_runtime_class_init(&DAT_181d8d528);
        uVar1 = il2cpp_internal(uVar1);
        NotSupportedException.ctor(uVar1,0);
        uVar2 = il2cpp_runtime_class_init(&DAT_181d97150);
    }

    // Token : 0x6000ADF
    // RVA   : 0x20F140   Offset: 0x20E540   Length: 0x5
    private virtual object System.Collections.IEnumerator.get_Current()
    {
        return this.<>2__current;
    }

}
