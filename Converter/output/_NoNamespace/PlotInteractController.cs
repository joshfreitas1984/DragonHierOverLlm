// ============================================================
// Type  : PlotInteractController
// Token : 0x2000328
// ============================================================

public class PlotInteractController
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001A3E
    public SinglePlotChoiceData choiceData;

    // Token: 0x4001A3F
    private bool meetRequire;

    // Token: 0x4001A40
    private bool meetCost;

    // Token: 0x4001A41
    private float refreshTime;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6001FD9
    // RVA   : 0xB0D010   Offset: 0xB0C410   Length: 0x7AD
    public void Update()
    {
        var pStatics = *(int64*)(DAT_181d73d40 + 184);
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
        LAB_180b0d38a:
          this.meetRequire = 1;
        }
        else {
          lVar5 = FUN_18046c400(0);
          if ((this.choiceData == null) || (lVar5 == null)) throw; // [null/range check failed]
          cVar3 = PlotController.CheckChoiceMeetRequire
                            (lVar5,this.choiceData.requirements,0,0);
          if (cVar3) {
            lVar5 = Component.get_transform(this,0);
            if ((lVar5 == null) || (lVar5 = Transform.Find(lVar5,"Require",0)) == null)
            throw; // [null/range check failed]
            lVar5 = Component.GetComponent(lVar5,DAT_181d94ae0);
            lVar2 = pStatics;
            if (lVar5 == null) throw; // [null/range check failed]
            local_28 = *(uint32 *)(lVar2 + 0x2b8);
            uStack_24 = *(uint32 *)(lVar2 + 700);
            uStack_20 = *(uint32 *)(lVar2 + 0x2c0);
            uStack_1c = *(uint32 *)(lVar2 + 0x2c4);
        LAB_180b0d375:
            Shadow.set_effectColor(lVar5,&local_28,0);
            goto LAB_180b0d38a;
          }
          lVar5 = FUN_18046c400(0);
          if ((this.choiceData == null) || (lVar5 == null)) throw; // [null/range check failed]
          cVar3 = PlotController.CheckChoiceMeetRequire
                            (lVar5,this.choiceData.requirements,1,0);
          if (cVar3) {
            lVar5 = Component.get_transform(this,0);
            if ((lVar5 == null) || (lVar5 = Transform.Find(lVar5,"Require",0)) == null)
            throw; // [null/range check failed]
            lVar5 = Component.GetComponent(lVar5,DAT_181d94ae0);
            lVar2 = pStatics;
            if (lVar5 == null) throw; // [null/range check failed]
            local_28 = *(uint32 *)(lVar2 + 0x330);
            uStack_24 = *(uint32 *)(lVar2 + 0x334);
            uStack_20 = *(uint32 *)(lVar2 + 0x338);
            uStack_1c = *(uint32 *)(lVar2 + 0x33c);
            goto LAB_180b0d375;
          }
          lVar5 = Component.get_transform(this,0);
          if ((lVar5 == null) || (lVar5 = Transform.Find(lVar5,"Require",0)) == null)
          throw; // [null/range check failed]
          lVar5 = Component.GetComponent(lVar5,DAT_181d94ae0);
          lVar2 = pStatics;
          if (lVar5 == null) throw; // [null/range check failed]
          local_28 = *(uint32 *)(lVar2 + 0x310);
          uStack_24 = *(uint32 *)(lVar2 + 0x314);
          uStack_20 = *(uint32 *)(lVar2 + 0x318);
          uStack_1c = *(uint32 *)(lVar2 + 0x31c);
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
          lVar5 = Component.GetComponent(lVar5,DAT_181d94ae0);
          if (!this.meetCost) {
            lVar2 = pStatics;
            uVar8 = *(uint32 *)(lVar2 + 0x310);
            uVar9 = *(uint32 *)(lVar2 + 0x314);
            uVar10 = *(uint32 *)(lVar2 + 0x318);
            uVar11 = *(uint32 *)(lVar2 + 0x31c);
          }
          else {
            lVar2 = pStatics;
            uVar8 = *(uint32 *)(lVar2 + 0x2b8);
            uVar9 = *(uint32 *)(lVar2 + 700);
            uVar10 = *(uint32 *)(lVar2 + 0x2c0);
            uVar11 = *(uint32 *)(lVar2 + 0x2c4);
          }
          if (lVar5 == null) throw; // [null/range check failed]
          local_28 = uVar8;
          uStack_24 = uVar9;
          uStack_20 = uVar10;
          uStack_1c = uVar11;
          Shadow.set_effectColor(lVar5,&local_28,0);
        }
        lVar5 = Component.GetComponent(this,DAT_181d93760);
        if (lVar5 == null) throw; // [null/range check failed]
        Selectable.set_interactable(lVar5,1,0);
        if (this.choiceData == null) throw; // [null/range check failed]
        if (this.choiceData.playerInteractionTimeNeed == null) {
        LAB_180b0d665:
          lVar5 = Component.get_transform(this,0);
          if ((lVar5 == null) || (lVar5 = Transform.Find(lVar5,"InteractTime",0)) == null)
          throw; // [null/range check failed]
          uVar6 = Component.GetComponent(lVar5,DAT_181d96160);
          LTLocalization.SetText(uVar6,"",0);
          lVar5 = *(int64 *)(*(int64 *)(DAT_181d91b88 + 184) + 24);
          if (lVar5 == null) throw; // [null/range check failed]
          if (*(char *)(lVar5 + 208) == false) {
            lVar5 = FUN_18046c400(0);
            if (lVar5 == null) throw; // [null/range check failed]
            if (((*(char *)(lVar5 + 209) == false) && (this.meetRequire)) &&
               (this.meetCost)) {
              return;
            }
          }
        }
        else {
          lVar5 = FUN_18046c400(0);
          if (lVar5 == null) throw; // [null/range check failed]
          if (*(int64 *)(lVar5 + 112) == 0) goto LAB_180b0d665;
          lVar5 = FUN_18046c400(0);
          if ((((lVar5 == null) || (*(int64 *)(lVar5 + 112) == 0)) ||
              (lVar5 = *(int64 *)(*(int64 *)(lVar5 + 112) + 0x308)) == null) ||
             ((this.choiceData == null || (lVar5 = *(int64 *)(lVar5 + 16)) == null)))
          throw; // [null/range check failed]
          uVar1 = this.choiceData.playerInteractionTimeNeed;
          if (*(uint32 *)(lVar5 + 24) <= uVar1) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          if (0 < lVar5[uVar1])
          goto LAB_180b0d665;
          lVar5 = Component.get_transform(this,0);
          if ((lVar5 == null) || (lVar5 = Transform.Find(lVar5,"InteractTime",0)) == null)
          throw; // [null/range check failed]
          uVar6 = Component.GetComponent(lVar5,DAT_181d96160);
          LTLocalization.SetText(uVar6,"本月已用",0);
        }
        lVar5 = Component.GetComponent(this,DAT_181d93760);
        if (lVar5 != null) {
          Selectable.set_interactable(lVar5,0,0);
          return;
        }
    }

    // Token : 0x6001FDA
    // RVA   : 0xB0CC40   Offset: 0xB0C040   Length: 0x3C7
    public void OnClick()
    {
        long lVar1;
        long lVar2;
        ulong uVar3;
        lVar1 = BuildingUIController.PartyLvName;
        if (lVar1 != null) {
          if (*(char *)(lVar1 + 208) != false) {
            return;
          }
          lVar1 = BuildingUIController.PartyLvName;
          if (lVar1 != null) {
            if (*(char *)(lVar1 + 209) != false) {
              return;
            }
            lVar1 = FUN_18046c400(0);
            lVar2 = FUN_18046c0a0(0);
            if (((lVar2 != null) && (*(int64 *)(lVar2 + 32) != 0)) &&
               (lVar2 = WorldData.Player(*(int64 *)(lVar2 + 32),0)) != null) {
              uVar3 = HeroData.HeroName(lVar2,0,0);
              if ((this.choiceData != null) &&
                 (uVar3 = String.Format("\n\n{0}: {1}",uVar3,
                                         this.choiceData.choiceText,0),
                 lVar1 != null)) {
                PlotController.AddPlotRecordText(lVar1,uVar3,0);
                lVar1 = FUN_18046c400(0);
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
                      lVar1 = FUN_18046c400(0);
                      lVar2 = FUN_18046c400(0);
                      if ((lVar2 == null) || (lVar1 == null)) throw; // [null/range check failed]
                      PlotController.RemoveEvent(lVar1,*(uint64 *)(lVar2 + 152),0);
                      lVar1 = this.choiceData;
                      if (lVar1 == null) throw; // [null/range check failed]
                    }
                    if (lVar1.callParam == null) {
                      lVar1 = FUN_18046c400(0);
                      if ((this.choiceData != null) && (lVar1 != null)) {
                        Component.SendMessage
                                  (lVar1,this.choiceData.callFuc,0);
                        return;
                      }
                    }
                    else {
                      lVar2 = FUN_18046c400(0);
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

    // Token : 0x6001FDB
    // RVA   : 0x3A17B0   Offset: 0x3A0BB0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_18044ef50(this,0);
    }

}
