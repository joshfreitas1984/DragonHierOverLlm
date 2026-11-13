// ============================================================
// Type  : PlotInteractController
// Token : 0x2000332
// ============================================================

public class PlotInteractController
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001AB9
    public SinglePlotChoiceData choiceData;

    // Token: 0x4001ABA
    private bool meetRequire;

    // Token: 0x4001ABB
    private bool meetCost;

    // Token: 0x4001ABC
    private float refreshTime;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6002078
    // RVA   : 0x8AFB50   Offset: 0x8AE950   Length: 0x7AD
    public void Update()
    {
        var pStatics = *(int64*)(DAT_181e538e8 + 184);
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
        LAB_1808afeca:
          this.meetRequire = 1;
        }
        else {
          lVar5 = FUN_180210a70(0);
          if ((this.choiceData == null) || (lVar5 == null)) throw; // [null/range check failed]
          cVar3 = PlotController.CheckChoiceMeetRequire
                            (lVar5,this.choiceData.requirements,0,0);
          if (cVar3) {
            lVar5 = Component.get_transform(this,0);
            if ((lVar5 == null) || (lVar5 = Transform.Find(lVar5,"Require",0)) == null)
            throw; // [null/range check failed]
            lVar5 = Component.GetComponent(lVar5,DAT_181e77e38);
            lVar2 = pStatics;
            if (lVar5 == null) throw; // [null/range check failed]
            local_28 = *(uint32 *)(lVar2 + 0x2c0);
            uStack_24 = *(uint32 *)(lVar2 + 0x2c4);
            uStack_20 = *(uint32 *)(lVar2 + 0x2c8);
            uStack_1c = *(uint32 *)(lVar2 + 0x2cc);
        LAB_1808afeb5:
            Shadow.set_effectColor(lVar5,&local_28,0);
            goto LAB_1808afeca;
          }
          lVar5 = FUN_180210a70(0);
          if ((this.choiceData == null) || (lVar5 == null)) throw; // [null/range check failed]
          cVar3 = PlotController.CheckChoiceMeetRequire
                            (lVar5,this.choiceData.requirements,1,0);
          if (cVar3) {
            lVar5 = Component.get_transform(this,0);
            if ((lVar5 == null) || (lVar5 = Transform.Find(lVar5,"Require",0)) == null)
            throw; // [null/range check failed]
            lVar5 = Component.GetComponent(lVar5,DAT_181e77e38);
            lVar2 = pStatics;
            if (lVar5 == null) throw; // [null/range check failed]
            local_28 = *(uint32 *)(lVar2 + 0x338);
            uStack_24 = *(uint32 *)(lVar2 + 0x33c);
            uStack_20 = *(uint32 *)(lVar2 + 0x340);
            uStack_1c = *(uint32 *)(lVar2 + 0x344);
            goto LAB_1808afeb5;
          }
          lVar5 = Component.get_transform(this,0);
          if ((lVar5 == null) || (lVar5 = Transform.Find(lVar5,"Require",0)) == null)
          throw; // [null/range check failed]
          lVar5 = Component.GetComponent(lVar5,DAT_181e77e38);
          lVar2 = pStatics;
          if (lVar5 == null) throw; // [null/range check failed]
          local_28 = *(uint32 *)(lVar2 + 0x318);
          uStack_24 = *(uint32 *)(lVar2 + 0x31c);
          uStack_20 = *(uint32 *)(lVar2 + 800);
          uStack_1c = *(uint32 *)(lVar2 + 0x324);
          Shadow.set_effectColor(lVar5,&local_28,0);
          this.meetRequire = 0;
        }
        if (this.choiceData == null) throw; // [null/range check failed]
        lVar5 = this.choiceData.costResource;
        if ((lVar5 == null) || (*(int *)(lVar5 + 24) < 1)) {
          this.meetCost = 1;
        }
        else {
          lVar5 = FUN_1802106e0(0);
          if ((lVar5 == null) || (*(int64 *)(lVar5 + 32) == 0)) throw; // [null/range check failed]
          lVar5 = WorldData.Player(*(int64 *)(lVar5 + 32),0);
          if ((this.choiceData == null) || (lVar5 == null)) throw; // [null/range check failed]
          uVar4 = HeroData.HaveResource(lVar5,this.choiceData.costResource,0);
          this.meetCost = uVar4;
          lVar5 = Component.get_transform(this,0);
          if ((lVar5 == null) || (lVar5 = Transform.Find(lVar5,"Cost",0)) == null)
          throw; // [null/range check failed]
          lVar5 = Component.GetComponent(lVar5,DAT_181e77e38);
          if (!this.meetCost) {
            lVar2 = pStatics;
            uVar8 = *(uint32 *)(lVar2 + 0x318);
            uVar9 = *(uint32 *)(lVar2 + 0x31c);
            uVar10 = *(uint32 *)(lVar2 + 800);
            uVar11 = *(uint32 *)(lVar2 + 0x324);
          }
          else {
            lVar2 = pStatics;
            uVar8 = *(uint32 *)(lVar2 + 0x2c0);
            uVar9 = *(uint32 *)(lVar2 + 0x2c4);
            uVar10 = *(uint32 *)(lVar2 + 0x2c8);
            uVar11 = *(uint32 *)(lVar2 + 0x2cc);
          }
          if (lVar5 == null) throw; // [null/range check failed]
          local_28 = uVar8;
          uStack_24 = uVar9;
          uStack_20 = uVar10;
          uStack_1c = uVar11;
          Shadow.set_effectColor(lVar5,&local_28,0);
        }
        lVar5 = Component.GetComponent(this,DAT_181e76ab8);
        if (lVar5 == null) throw; // [null/range check failed]
        Selectable.set_interactable(lVar5,1,0);
        if (this.choiceData == null) throw; // [null/range check failed]
        if (this.choiceData.playerInteractionTimeNeed == null) {
        LAB_1808b01a5:
          lVar5 = Component.get_transform(this,0);
          if ((lVar5 == null) || (lVar5 = Transform.Find(lVar5,"InteractTime",0)) == null)
          throw; // [null/range check failed]
          uVar6 = Component.GetComponent(lVar5,DAT_181e79538);
          LTLocalization.SetText(uVar6,"",0);
          lVar5 = *(int64 *)(*(int64 *)(DAT_181e71f68 + 184) + 24);
          if (lVar5 == null) throw; // [null/range check failed]
          if (*(char *)(lVar5 + 208) == false) {
            lVar5 = FUN_180210a70(0);
            if (lVar5 == null) throw; // [null/range check failed]
            if (((*(char *)(lVar5 + 209) == false) && (this.meetRequire)) &&
               (this.meetCost)) {
              return;
            }
          }
        }
        else {
          lVar5 = FUN_180210a70(0);
          if (lVar5 == null) throw; // [null/range check failed]
          if (*(int64 *)(lVar5 + 112) == 0) goto LAB_1808b01a5;
          lVar5 = FUN_180210a70(0);
          if ((((lVar5 == null) || (*(int64 *)(lVar5 + 112) == 0)) ||
              (lVar5 = *(int64 *)(*(int64 *)(lVar5 + 112) + 0x308)) == null) ||
             ((this.choiceData == null || (lVar5 = *(int64 *)(lVar5 + 16)) == null)))
          throw; // [null/range check failed]
          uVar1 = this.choiceData.playerInteractionTimeNeed;
          if (*(uint32 *)(lVar5 + 24) <= uVar1) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          if (0 < lVar5[uVar1])
          goto LAB_1808b01a5;
          lVar5 = Component.get_transform(this,0);
          if ((lVar5 == null) || (lVar5 = Transform.Find(lVar5,"InteractTime",0)) == null)
          throw; // [null/range check failed]
          uVar6 = Component.GetComponent(lVar5,DAT_181e79538);
          LTLocalization.SetText(uVar6,"本月已用",0);
        }
        lVar5 = Component.GetComponent(this,DAT_181e76ab8);
        if (lVar5 != null) {
          Selectable.set_interactable(lVar5,0,0);
          return;
        }
    }

    // Token : 0x6002079
    // RVA   : 0x8AF780   Offset: 0x8AE580   Length: 0x3C7
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
            lVar1 = FUN_180210a70(0);
            lVar2 = FUN_1802106e0(0);
            if (((lVar2 != null) && (*(int64 *)(lVar2 + 32) != 0)) &&
               (lVar2 = WorldData.Player(*(int64 *)(lVar2 + 32),0)) != null) {
              uVar3 = HeroData.HeroName(lVar2,0,0);
              if ((this.choiceData != null) &&
                 (uVar3 = String.Format("\n\n{0}: {1}",uVar3,
                                         this.choiceData.choiceText,0),
                 lVar1 != null)) {
                PlotController.AddPlotRecordText(lVar1,uVar3,0);
                lVar1 = FUN_180210a70(0);
                if (lVar1 != null) {
                  *(uint64 *)(lVar1 + 176) = this.choiceData;
                  lVar1 = this.choiceData;
                  if ((lVar1 != null) && (lVar1.costResource != null)) {
                    if (0 < *(int *)(lVar1.costResource + 24)) {
                      lVar1 = FUN_1802106e0(0);
                      if ((lVar1 == null) || (lVar1.callParam == null)) throw; // [null/range check failed]
                      lVar1 = WorldData.Player(lVar1.callParam,0);
                      if ((this.choiceData == null) || (lVar1 == null)) throw; // [null/range check failed]
                      HeroData.CostResource
                                (lVar1,this.choiceData.costResource,0);
                      lVar1 = this.choiceData;
                      if (lVar1 == null) throw; // [null/range check failed]
                    }
                    if (lVar1.destroyEvent) {
                      lVar1 = FUN_180210a70(0);
                      lVar2 = FUN_180210a70(0);
                      if ((lVar2 == null) || (lVar1 == null)) throw; // [null/range check failed]
                      PlotController.RemoveEvent(lVar1,*(uint64 *)(lVar2 + 152),0);
                      lVar1 = this.choiceData;
                      if (lVar1 == null) throw; // [null/range check failed]
                    }
                    if (lVar1.callParam == null) {
                      lVar1 = FUN_180210a70(0);
                      if ((this.choiceData != null) && (lVar1 != null)) {
                        Component.SendMessage
                                  (lVar1,this.choiceData.callFuc,0);
                        return;
                      }
                    }
                    else {
                      lVar2 = FUN_180210a70(0);
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

    // Token : 0x600207A
    // RVA   : 0x2110A0   Offset: 0x20FEA0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_180ae8740(this,0);
    }

}
