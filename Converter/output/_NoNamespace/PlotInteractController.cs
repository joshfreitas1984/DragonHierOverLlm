// ============================================================
// Type  : PlotInteractController
// Token : 0x2000321
// ============================================================

public class PlotInteractController
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001947
    public SinglePlotChoiceData choiceData;

    // Token: 0x4001948
    private bool meetRequire;

    // Token: 0x4001949
    private bool meetCost;

    // Token: 0x400194A
    private float refreshTime;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6001F59
    // RVA   : 0xBD8BE0   Offset: 0xBD73E0   Length: 0x75E
    public void Update()
    {
        var pStatics_c960 = *(int64*)(DAT_181d6c960 + 184);
        var pStatics_ef00 = *(int64*)(DAT_181d4ef00 + 184);
        uint uVar1;
        long lVar2;
        bool cVar3;
        byte uVar4;
        long lVar5;
        ulong uVar6;
        float fVar7;
        uint uVar8;
        uint uVar9;
        uint uVar10;
        uint uVar11;
        float fVar12;
        uint local_28;
        uint uStack_24;
        uint uStack_20;
        uint32 uStack_1c;
        fVar12 = this.refreshTime;
        fVar7 = (float)RealTime.get_deltaTime(0);
        fVar12 = fVar12 - fVar7;
        this.refreshTime = fVar12;
        if (0.0 < fVar12) {
          return;
        }
        this.refreshTime = 0x3dcccccd;
        if (this.choiceData == null) throw; // [null/range check failed]
        lVar5 = this.choiceData.requirements;
        if ((lVar5 == null) || (*(int *)(lVar5 + 24) < 1)) {
        LAB_180bd8f4e:
          this.meetRequire = 1;
        }
        else {
          lVar5 = FUN_18046c440(0);
          if ((this.choiceData == null) || (lVar5 == null)) throw; // [null/range check failed]
          cVar3 = PlotController.CheckChoiceMeetRequire
                            (lVar5,this.choiceData.requirements,0,0);
          if (cVar3) {
            lVar5 = Component.get_transform(this,0);
            if ((lVar5 == null) || (lVar5 = Transform.Find(lVar5,"Require",0)) == null)
            throw; // [null/range check failed]
            lVar5 = Component.GetComponent(lVar5,DAT_181d6c2c0);
            lVar2 = pStatics_ef00;
            if (lVar5 == null) throw; // [null/range check failed]
            local_28 = *(uint32 *)(lVar2 + 0x2b0);
            uStack_24 = *(uint32 *)(lVar2 + 0x2b4);
            uStack_20 = *(uint32 *)(lVar2 + 0x2b8);
            uStack_1c = *(uint32 *)(lVar2 + 700);
        LAB_180bd8f39:
            Shadow.set_effectColor(lVar5,&local_28,0);
            goto LAB_180bd8f4e;
          }
          lVar5 = FUN_18046c440(0);
          if ((this.choiceData == null) || (lVar5 == null)) throw; // [null/range check failed]
          cVar3 = PlotController.CheckChoiceMeetRequire
                            (lVar5,this.choiceData.requirements,1,0);
          if (cVar3) {
            lVar5 = Component.get_transform(this,0);
            if ((lVar5 == null) || (lVar5 = Transform.Find(lVar5,"Require",0)) == null)
            throw; // [null/range check failed]
            lVar5 = Component.GetComponent(lVar5,DAT_181d6c2c0);
            lVar2 = pStatics_ef00;
            if (lVar5 == null) throw; // [null/range check failed]
            local_28 = *(uint32 *)(lVar2 + 0x328);
            uStack_24 = *(uint32 *)(lVar2 + 0x32c);
            uStack_20 = *(uint32 *)(lVar2 + 0x330);
            uStack_1c = *(uint32 *)(lVar2 + 0x334);
            goto LAB_180bd8f39;
          }
          lVar5 = Component.get_transform(this,0);
          if ((lVar5 == null) || (lVar5 = Transform.Find(lVar5,"Require",0)) == null)
          throw; // [null/range check failed]
          lVar5 = Component.GetComponent(lVar5,DAT_181d6c2c0);
          lVar2 = pStatics_ef00;
          if (lVar5 == null) throw; // [null/range check failed]
          local_28 = *(uint32 *)(lVar2 + 0x308);
          uStack_24 = *(uint32 *)(lVar2 + 0x30c);
          uStack_20 = *(uint32 *)(lVar2 + 0x310);
          uStack_1c = *(uint32 *)(lVar2 + 0x314);
          Shadow.set_effectColor(lVar5,&local_28,0);
          this.meetRequire = 0;
        }
        if (this.choiceData == null) throw; // [null/range check failed]
        lVar5 = this.choiceData.costResource;
        if ((lVar5 == null) || (*(int *)(lVar5 + 24) < 1)) {
          this.meetCost = 1;
        }
        else {
          lVar5 = FUN_18046c0a0(0);
          if ((lVar5 == null) || (*(int64 *)(lVar5 + 32) == 0)) throw; // [null/range check failed]
          lVar5 = WorldData.Player(*(int64 *)(lVar5 + 32),0);
          if ((this.choiceData == null) || (lVar5 == null)) throw; // [null/range check failed]
          uVar4 = HeroData.HaveResource(lVar5,this.choiceData.costResource,0);
          this.meetCost = uVar4;
          lVar5 = Component.get_transform(this,0);
          if ((lVar5 == null) || (lVar5 = Transform.Find(lVar5,"Cost",0)) == null)
          throw; // [null/range check failed]
          lVar5 = Component.GetComponent(lVar5,DAT_181d6c2c0);
          if (!this.meetCost) {
            lVar2 = pStatics_ef00;
            uVar8 = *(uint32 *)(lVar2 + 0x308);
            uVar9 = *(uint32 *)(lVar2 + 0x30c);
            uVar10 = *(uint32 *)(lVar2 + 0x310);
            uVar11 = *(uint32 *)(lVar2 + 0x314);
          }
          else {
            lVar2 = pStatics_ef00;
            uVar8 = *(uint32 *)(lVar2 + 0x2b0);
            uVar9 = *(uint32 *)(lVar2 + 0x2b4);
            uVar10 = *(uint32 *)(lVar2 + 0x2b8);
            uVar11 = *(uint32 *)(lVar2 + 700);
          }
          if (lVar5 == null) throw; // [null/range check failed]
          local_28 = uVar8;
          uStack_24 = uVar9;
          uStack_20 = uVar10;
          uStack_1c = uVar11;
          Shadow.set_effectColor(lVar5,&local_28,0);
        }
        lVar5 = Component.GetComponent(this,DAT_181d6af40);
        if (lVar5 == null) throw; // [null/range check failed]
        Selectable.set_interactable(lVar5,1,0);
        if (this.choiceData == null) throw; // [null/range check failed]
        if (this.choiceData.playerInteractionTimeNeed == null) {
        LAB_180bd9208:
          lVar5 = Component.get_transform(this,0);
          if ((lVar5 == null) || (lVar5 = Transform.Find(lVar5,"InteractTime",0)) == null)
          throw; // [null/range check failed]
          uVar6 = Component.GetComponent(lVar5,DAT_181d6d8c0);
          LTLocalization.SetText(uVar6,"",0);
          if (*pStatics_c960 == 0) throw; // [null/range check failed]
          if (*(char *)(*pStatics_c960 + 208) == false) {
            lVar5 = FUN_18046c440(0);
            if (lVar5 == null) throw; // [null/range check failed]
            if (((*(char *)(lVar5 + 209) == false) && (this.meetRequire)) &&
               (this.meetCost)) {
              return;
            }
          }
        }
        else {
          lVar5 = FUN_18046c440(0);
          if (lVar5 == null) throw; // [null/range check failed]
          if (*(int64 *)(lVar5 + 112) == 0) goto LAB_180bd9208;
          lVar5 = FUN_18046c440(0);
          if ((((lVar5 == null) || (*(int64 *)(lVar5 + 112) == 0)) ||
              (lVar5 = *(int64 *)(*(int64 *)(lVar5 + 112) + 0x308)) == null) ||
             ((this.choiceData == null || (lVar5 = *(int64 *)(lVar5 + 16)) == null)))
          throw; // [null/range check failed]
          uVar1 = this.choiceData.playerInteractionTimeNeed;
          if (*(uint32 *)(lVar5 + 24) <= uVar1) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          if (0 < lVar5[uVar1])
          goto LAB_180bd9208;
          lVar5 = Component.get_transform(this,0);
          if ((lVar5 == null) || (lVar5 = Transform.Find(lVar5,"InteractTime",0)) == null)
          throw; // [null/range check failed]
          uVar6 = Component.GetComponent(lVar5,DAT_181d6d8c0);
          LTLocalization.SetText(uVar6,"本月已用",0);
        }
        lVar5 = Component.GetComponent(this,DAT_181d6af40);
        if (lVar5 != null) {
          Selectable.set_interactable(lVar5,0,0);
          return;
        }
    }

    // Token : 0x6001F5A
    // RVA   : 0xBD8810   Offset: 0xBD7010   Length: 0x3C5
    public void OnClick()
    {
        var pStatics = *(int64*)(DAT_181d6c960 + 184);
        long lVar1;
        long lVar2;
        ulong uVar3;
        if (*pStatics != 0) {
          if (*(char *)(*pStatics + 208) != false) {
            return;
          }
          if (*pStatics != 0) {
            if (*(char *)(*pStatics + 209) != false) {
              return;
            }
            lVar1 = FUN_18046c440(0);
            lVar2 = FUN_18046c0a0(0);
            if (((lVar2 != null) && (*(int64 *)(lVar2 + 32) != 0)) &&
               (lVar2 = WorldData.Player(*(int64 *)(lVar2 + 32),0)) != null) {
              uVar3 = HeroData.HeroName(lVar2,0,0);
              if ((this.choiceData != null) &&
                 (uVar3 = String.Format("\n\n{0}: {1}",uVar3,
                                         this.choiceData.choiceText,0),
                 lVar1 != null)) {
                PlotController.AddPlotRecordText(lVar1,uVar3,0);
                lVar1 = FUN_18046c440(0);
                if (lVar1 != null) {
                  *(uint64 *)(lVar1 + 176) = this.choiceData;
                  lVar1 = this.choiceData;
                  if ((lVar1 != null) && (lVar1.costResource != null)) {
                    if (0 < *(int *)(lVar1.costResource + 24)) {
                      lVar1 = FUN_18046c0a0(0);
                      if ((lVar1 == null) || (lVar1.callParam == null)) throw; // [null/range check failed]
                      lVar1 = WorldData.Player(lVar1.callParam,0);
                      if ((this.choiceData == null) || (lVar1 == null)) throw; // [null/range check failed]
                      HeroData.CostResource
                                (lVar1,this.choiceData.costResource,0);
                      lVar1 = this.choiceData;
                      if (lVar1 == null) throw; // [null/range check failed]
                    }
                    if (lVar1.destroyEvent) {
                      lVar1 = FUN_18046c440(0);
                      lVar2 = FUN_18046c440(0);
                      if ((lVar2 == null) || (lVar1 == null)) throw; // [null/range check failed]
                      PlotController.RemoveEvent(lVar1,*(uint64 *)(lVar2 + 152),0);
                      lVar1 = this.choiceData;
                      if (lVar1 == null) throw; // [null/range check failed]
                    }
                    if (lVar1.callParam == null) {
                      lVar1 = FUN_18046c440(0);
                      if ((this.choiceData != null) && (lVar1 != null)) {
                        Component.SendMessage
                                  (lVar1,this.choiceData.callFuc,0);
                        return;
                      }
                    }
                    else {
                      lVar2 = FUN_18046c440(0);
                      lVar1 = this.choiceData;
                      if ((lVar1 != null) && (lVar2 != null)) {
                        Component.SendMessage
                                  (lVar2,lVar1.callFuc,lVar1.callParam,0);
                        return;
                      }
                    }
                  }
                }
              }
            }
          }
        }
    }

    // Token : 0x6001F5B
    // RVA   : 0x3A17B0   Offset: 0x39FFB0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_18044ef50(this,0);
    }

}
