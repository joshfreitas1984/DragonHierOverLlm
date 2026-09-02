// ============================================================
// Type  : <PartyContinue>d__56
// Token : 0x200030F
// ============================================================

public class <PartyContinue>d__56
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001883
    private int <>1__state;

    // Token: 0x4001884
    private object <>2__current;

    // Token: 0x4001885
    public PartyController <>4__this;

    // Token: 0x4001886
    private int <i>5__2;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6001947
    // RVA   : 0x219070   Offset: 0x217870   Length: 0x24
    public void /*ctor*/(int <>1__state)
    {
        ZhSegment.Initialize(this,0);
        this.<>1__state = <>1__state;
    }

    // Token : 0x6001948
    // RVA   : 0x245810   Offset: 0x244010   Length: 0x3
    private virtual void System.IDisposable.Dispose()
    {
    }

    // Token : 0x6001949
    // RVA   : 0x8CE700   Offset: 0x8CCF00   Length: 0xA9C
    private virtual bool MoveNext()
    {
        var plVar2 = *(int64*)(lVar2 + 184);
        var pStatics = *(int64*)(DAT_181d9d3c0 + 184);
        uint uVar1;
        long lVar2;
        uint uVar3;
        long lVar4;
        long lVar5;
        ulong uVar6;
        ulong uVar7;
        ulong uVar9;
        int iVar10;
        float fVar11;
        float fVar12;
        uint64 extraout_XMM0_Qb;
        uint8 auVar13 [16];
        uint8 auVar14 [16];
        float local_res8 [2];
        uint64 in_stack_ffffffffffffff38;
        uint64 in_stack_ffffffffffffff40;
        uint32 uVar15;
        uint64 local_98;
        uint32 local_90;
        uint64 local_88;
        uint64 uStack_80;
        uVar3 = (uint32)((uint64)in_stack_ffffffffffffff38 >> 32);
        uVar15 = (uint32)((uint64)in_stack_ffffffffffffff40 >> 32);
        iVar10 = this.<>1__state;
        lVar2 = this.<>4__this;
        local_res8[0] = 0.0;
        if (iVar10 == 0) {
          this.<>1__state = 0xffffffff;
          if ((lVar2 == null) || (*(int64 *)(lVar2 + 48) == 0)) throw; // [null/range check failed]
          AudioSource.set_volume();
          if (*(int64 *)(lVar2 + 48) == 0) throw; // [null/range check failed]
          AudioSource.Play(*(int64 *)(lVar2 + 48),0);
          DOTweenModuleAudio.DOFade(*(uint64 *)(lVar2 + 48));
          if ((((*(int64 *)(lVar2 + 32) == 0) ||
               (lVar4 = GameObject.get_transform(*(int64 *)(lVar2 + 32),0)) == null) ||
              (lVar4 = Transform.Find(lVar4,"ProgressBar",0)) == null) ||
             ((lVar4 = Transform.Find(lVar4,"Bar",0), lVar4 == null ||
              (lVar4 = Component.GetComponent(lVar4,DAT_181d6bc40)) == null))) throw; // [null/range check failed]
          Image.set_fillAmount(lVar4);
          if (((*(int64 *)(lVar2 + 32) == 0) ||
              ((lVar4 = GameObject.get_transform(*(int64 *)(lVar2 + 32),0), lVar4 == null ||
               (lVar4 = Transform.Find(lVar4,"ProgressBar",0)) == null))) ||
             (lVar4 = Component.get_gameObject(lVar4,0)) == null) throw; // [null/range check failed]
          GameObject.SetActive(lVar4,1,0);
          iVar10 = 0;
          this.<i>5__2 = 0;
        }
        else {
          if (iVar10 != 1) {
            if (iVar10 != 2) {
              return false;
            }
            this.<>1__state = 0xffffffff;
            lVar4 = FUN_18046c440(0);
            lVar5 = il2cpp_internal(DAT_181d72a30);
            FUN_180f58a90(lVar5,DAT_181d7c250);
            if (((lVar5 != null) && (FUN_181827900(lVar5,"客人离席;FinishParty",DAT_181d7c3d0), lVar2 != null)) &&
               (*(int64 *)(lVar2 + 168) != 0)) {
              uVar6 = Int32.ToString(*(int64 *)(lVar2 + 168) + 88,0);
              uVar7 = new SinglePlotData("宴会持续良久，肴核既尽，杯盘狼籍。相与枕藉，不觉天色昏沉。",lVar5,1,0,CONCAT44(uVar15,3),uVar6,3,0,0);
              if (lVar4 != null) {
                PlotController.AddPlot(lVar4,uVar7,0);
                return false;
              }
            }
            throw; // [null/range check failed]
          }
          this.<>1__state = 0xffffffff;
          if (((lVar2 == null) || (*(int64 *)(lVar2 + 32) == 0)) ||
             ((lVar4 = GameObject.get_transform(*(int64 *)(lVar2 + 32),0), lVar4 == null ||
              ((lVar4 = Transform.Find(lVar4,"ProgressBar",0), lVar4 == null ||
               (lVar4 = Transform.Find(lVar4,"Bar",0)) == null))))) throw; // [null/range check failed]
          lVar4 = Component.GetComponent(lVar4,DAT_181d6bc40);
          if ((*(int64 *)(lVar2 + 192) == 0) || (lVar4 == null)) throw; // [null/range check failed]
          Image.set_fillAmount
                    (lVar4,((float)this.<i>5__2 + 1.0) /
                           (float)*(int *)(*(int64 *)(lVar2 + 192) + 24),0);
          if (*(int64 *)(lVar2 + 72) != 0) {
            lVar4 = plVar2;
            if (lVar4 == null) throw; // [null/range check failed]
            uVar1 = this.<i>5__2;
            if (*(uint32 *)(lVar4 + 24) <= uVar1) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            lVar4 = lVar4[uVar1];
            if (lVar4 == null) throw; // [null/range check failed]
            uVar6 = CONCAT44(uVar3,*(uint32 *)(lVar2 + 200));
            HeroData.CosumeMedFood
                      (lVar4,*(uint64 *)(lVar2 + 72),1,*(uint64 *)(lVar2 + 168),uVar6,0);
            uVar3 = (uint32)((uint64)uVar6 >> 32);
          }
          if (*(int64 *)(lVar2 + 104) != 0) {
            lVar4 = plVar2;
            if (lVar4 == null) throw; // [null/range check failed]
            uVar1 = this.<i>5__2;
            if (*(uint32 *)(lVar4 + 24) <= uVar1) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            lVar4 = lVar4[uVar1];
            if (lVar4 == null) throw; // [null/range check failed]
            HeroData.CosumeMedFood
                      (lVar4,*(uint64 *)(lVar2 + 104),1,*(uint64 *)(lVar2 + 168),
                       CONCAT44(uVar3,*(uint32 *)(lVar2 + 200)),0);
          }
          lVar4 = plVar2;
          if (lVar4 == null) throw; // [null/range check failed]
          uVar1 = this.<i>5__2;
          if (*(uint32 *)(lVar4 + 24) <= uVar1) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          lVar4 = lVar4[uVar1];
          if (lVar4 == null) throw; // [null/range check failed]
          fVar12 = *(float *)(lVar4 + 0x1c4);
          fVar11 = (float)Random.Range();
          lVar4 = plVar2;
          if (lVar4 == null) throw; // [null/range check failed]
          uVar1 = this.<i>5__2;
          if (*(uint32 *)(lVar4 + 24) <= uVar1) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          lVar4 = lVar4[uVar1];
          if (lVar4 == null) throw; // [null/range check failed]
          uVar6 = HeroData.Favor(lVar4,0,0);
          auVar13._8_4_ = (int)extraout_XMM0_Qb;
          auVar13._0_8_ = uVar6;
          auVar13._12_4_ = (int)((uint64)extraout_XMM0_Qb >> 32);
          auVar14._4_12_ = auVar13._4_12_;
          auVar14._0_4_ = ((float)uVar6 * 0.05 + 1.0) * fVar12 * 0.05 * fVar11;
          local_res8[0] = auVar14._0_4_;
          PartyController.ChangeBaseScore(lVar2,auVar14._0_8_,0);
          lVar5 = FUN_18046c0a0(0);
          uVar6 = Single.ToString(local_res8,"+0;-0;0",0);
          uVar6 = String.Concat("宴会评分",uVar6,0);
          lVar4 = *(int64 *)(lVar2 + 192);
          if (lVar4 == null) throw; // [null/range check failed]
          uVar1 = this.<i>5__2;
          if (*(uint32 *)(lVar4 + 24) <= uVar1) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          lVar4 = lVar4[uVar1];
          if ((lVar4 == null) || (lVar4 = GameObject.get_transform(lVar4,0)) == null)
          throw; // [null/range check failed]
          puVar8 = (uint64 *)Transform.get_position(&local_98,lVar4,0);
          uVar7 = *puVar8;
          uVar3 = *(uint32 *)(puVar8 + 1);
          puVar8 = (uint64 *)Color.get_green(&local_88,0);
          if (lVar5 == null) throw; // [null/range check failed]
          local_88 = *puVar8;
          uStack_80 = puVar8[1];
          uVar15 = 0;
          local_98 = uVar7;
          local_90 = uVar3;
          GameController.ShowTextAtPos(lVar5,uVar6,&local_98,20,&local_88,0);
          if (**(int **)(DAT_181d4ef00 + 184) != 2) {
            lVar4 = *(int64 *)(lVar2 + 192);
            lVar5 = **(int64 **)(DAT_181d51180 + 184);
            if (lVar4 == null) throw; // [null/range check failed]
            uVar1 = this.<i>5__2;
            if (*(uint32 *)(lVar4 + 24) <= uVar1) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            uVar6 = lVar4[uVar1];
            fVar12 = (float)Random.get_value(0);
            if (0.5 <= fVar12) {
              lVar4 = *(int64 *)(pStatics + 24);
              if (lVar4 == null) throw; // [null/range check failed]
              uVar3 = FUN_180d8cf10(0,*(uint32 *)(lVar4 + 24),0);
              lVar4 = FUN_180002f80(lVar4,uVar3,DAT_181d7c9c0);
              if (lVar4 == null) throw; // [null/range check failed]
              uVar7 = String.Replace(lVar4,"，","\n",0);
            }
            else {
              lVar4 = *(int64 *)(pStatics + 16);
              if (lVar4 == null) throw; // [null/range check failed]
              uVar3 = FUN_180d8cf10(0,*(uint32 *)(lVar4 + 24),0);
              uVar7 = FUN_180002f80(lVar4,uVar3,DAT_181d7c9c0);
            }
            if ((((*(int64 *)(lVar2 + 32) == 0) ||
                 (lVar4 = GameObject.get_transform(*(int64 *)(lVar2 + 32),0)) == null) ||
                (lVar4 = Transform.Find(lVar4,"TalkPanel",0)) == null) ||
               (uVar9 = Component.get_gameObject(lVar4,0), lVar5 == null)) throw; // [null/range check failed]
            HeroLittleTalkController.HeroTalk(lVar5,uVar6,uVar7,0x40000000,uVar9,CONCAT44(uVar15,2),0);
          }
          this.<i>5__2 = this.<i>5__2 + 1;
          iVar10 = this.<i>5__2;
        }
        if (*(int64 *)(lVar2 + 192) != 0) {
          if (iVar10 < *(int *)(*(int64 *)(lVar2 + 192) + 24)) {
            uVar6 = new WaitForSeconds();
            this.<>2__current = uVar6;
            this.<>1__state = 1;
          }
          else {
            uVar6 = DOTweenModuleAudio.DOFade(*(uint64 *)(lVar2 + 48));
            uVar7 = new OnTooltipCB(lVar2,DAT_181d6d370,0);
            TweenSettingsExtensions.OnComplete(uVar6,uVar7,DAT_181d96d50);
            uVar6 = new WaitForSeconds();
            this.<>2__current = uVar6;
            this.<>1__state = 2;
          }
          return true;
        }
    }

    // Token : 0x600194A
    // RVA   : 0x20F140   Offset: 0x20D940   Length: 0x5
    private virtual object System.Collections.Generic.IEnumerator<System.object>.get_Current()
    {
        return this.<>2__current;
    }

    // Token : 0x600194B
    // RVA   : 0x8CF1A0   Offset: 0x8CD9A0   Length: 0x3E
    private virtual void System.Collections.IEnumerator.Reset()
    {
        ulong uVar1;
        ulong uVar2;
        uVar1 = il2cpp_runtime_class_init(&DAT_181d682e8);
        uVar1 = il2cpp_internal(uVar1);
        NotSupportedException.ctor(uVar1,0);
        uVar2 = il2cpp_runtime_class_init(&DAT_181d80b28);
    }

    // Token : 0x600194C
    // RVA   : 0x20F140   Offset: 0x20D940   Length: 0x5
    private virtual object System.Collections.IEnumerator.get_Current()
    {
        return this.<>2__current;
    }

}
