// ============================================================
// Type  : HeroHandBookIconController
// Token : 0x20002D3
// ============================================================

public class HeroHandBookIconController
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001776
    public HeroData heroData;

    // Token: 0x4001777
    public SkeletonGraphic skeletonGraphic;

    // Token: 0x4001778
    private bool handBookUnlocked;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x600184C
    // RVA   : 0x896A40   Offset: 0x895840   Length: 0x3A2
    public void Init()
    {
        uint uVar3;
        int iVar4;
        long lVar5;
        ulong uVar6;
        ulong uVar7;
        long lVar8;
        uint local_18;
        uint uStack_14;
        uint uStack_10;
        uint32 uStack_c;
        lVar5 = Component.get_transform(this,0);
        if (lVar5 != null) {
          lVar5 = Transform.Find(lVar5,"NameBack",0);
          if (lVar5 != null) {
            lVar5 = Transform.Find(lVar5,"Text",0);
            if (lVar5 != null) {
              uVar6 = Component.GetComponent(lVar5,DAT_181e79538);
              if (this.heroData != null) {
                uVar7 = HeroData.HeroName(this.heroData,0,0);
                LTLocalization.SetText(uVar6,uVar7,0);
                lVar5 = Component.get_transform(this,0);
                if (lVar5 != null) {
                  lVar5 = Transform.Find(lVar5,"ForceBack",0);
                  if (lVar5 != null) {
                    lVar5 = Transform.Find(lVar5,"Text",0);
                    if (lVar5 != null) {
                      uVar6 = Component.GetComponent(lVar5,DAT_181e79538);
                      if (this.heroData != null) {
                        uVar7 = HeroData.GetHeroForceLvDescribe(this.heroData,1,0);
                        LTLocalization.SetText(uVar6,uVar7,0);
                        lVar5 = this.heroData;
                        lVar8 = Component.get_transform(this,0);
                        if (lVar8 != null) {
                          uVar6 = Transform.Find(lVar8,"Back",0);
                          if (this.heroData != null) {
                            uVar3 = HeroData.GetDefaultSkinID(this.heroData,0);
                            if ((this.heroData != null) && (lVar5 != null)) {
                              HeroData.SetSkeletonGraphic
                                        (lVar5,uVar6,uVar3,
                                         this.heroData.heroForceLv,0);
                              lVar5 = this.heroData;
                              lVar8 = Component.get_transform(this,0);
                              if (lVar8 != null) {
                                uVar6 = Transform.Find(lVar8,"Back",0);
                                if (lVar5 != null) {
                                  lVar5 = HeroData.GetSkeletonGraphic(lVar5,uVar6,0);
                                  this.skeletonGraphic = lVar5;
                                  if (this.heroData != null) {
                                    uVar6 = Int32.ToString(this.heroData + 88,0);
                                    uVar6 = String.Concat("HandBookHero_",uVar6,0);

                                    if ((lVar5 = *(int64 *)(*(int64 *)(DAT_181e528f8 + 184) + 8)?.isSummon) != null)
                                    {
                                      iVar4 = PlayerPrefDictionary.GetInt(lVar5,uVar6,0);
                                      this.handBookUnlocked = iVar4 != 0;
                                      if (iVar4 == 0) {
                                        plVar2 = (int64 *)*plVar1;
                                        puVar9 = (uint32 *)Color.get_black(&local_18,0);
                                        if (plVar2 == (int64 *)0) throw; // [null/range check failed]
                                        local_18 = *puVar9;
                                        uStack_14 = puVar9[1];
                                        uStack_10 = puVar9[2];
                                        uStack_c = puVar9[3];
                                        (**(code **)(*plVar2 + 0x2a8))
                                                  (plVar2,&local_18,*(uint64 *)(*plVar2 + 0x2b0));
                                        if (*plVar1 == 0) throw; // [null/range check failed]
                                        lVar5 = SkeletonGraphic.get_AnimationState(*plVar1,0);
                                        if (lVar5 == null) throw; // [null/range check failed]
                                        lVar5 = AnimationState.GetCurrent(lVar5,0,0);
                                        if (lVar5 == null) throw; // [null/range check failed]
                                        lVar5.thisMonthContribution = 0;
                                      }
                                      if (*plVar1 != 0) {
                                        lVar5 = SkeletonGraphic.get_AnimationState(*plVar1,0);
                                        if (lVar5 != null) {
                                          lVar5 = AnimationState.GetCurrent(lVar5,0,0);
                                          if (lVar5 != null) {
                                            lVar5.forceJobType = 0;
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
                        }
                      }
                    }
                  }
                }
              }
            }
          }
        }
    }

    // Token : 0x600184D
    // RVA   : 0x896DF0   Offset: 0x895BF0   Length: 0xE7
    public void Update()
    {
        long lVar1;
        ulong uVar2;
        bool cVar3;
        ulong uVar4;
        lVar1 = this.skeletonGraphic;
        uVar2 = *(uint64 *)(*(int64 *)(DAT_181e6bb68 + 184) + 72);
        uVar4 = Component.get_gameObject(this,0);
        cVar3 = Object.op_Inequality(uVar2,uVar4,0);
        if (!cVar3) {
          bVar5 = !this.handBookUnlocked;
        }
        else {
          bVar5 = true;
        }
        if (lVar1 != null) {
          *(bool *)(lVar1 + 0x118) = bVar5;
          return;
        }
    }

    // Token : 0x600184E
    // RVA   : 0x2110A0   Offset: 0x20FEA0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_180ae8740(this,0);
    }

}
