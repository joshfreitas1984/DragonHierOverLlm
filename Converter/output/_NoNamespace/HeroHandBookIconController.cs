// ============================================================
// Type  : HeroHandBookIconController
// Token : 0x20002C4
// ============================================================

public class HeroHandBookIconController
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x400166E
    public HeroData heroData;

    // Token: 0x400166F
    public SkeletonGraphic skeletonGraphic;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x600178C
    // RVA   : 0xB33540   Offset: 0xB31D40   Length: 0x370
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
              uVar6 = Component.GetComponent(lVar5,DAT_181d6d8c0);
              if (this.heroData != null) {
                uVar7 = HeroData.HeroName(this.heroData,0,0);
                LTLocalization.SetText(uVar6,uVar7,0);
                lVar5 = Component.get_transform(this,0);
                if (lVar5 != null) {
                  lVar5 = Transform.Find(lVar5,"ForceBack",0);
                  if (lVar5 != null) {
                    lVar5 = Transform.Find(lVar5,"Text",0);
                    if (lVar5 != null) {
                      uVar6 = Component.GetComponent(lVar5,DAT_181d6d8c0);
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
                                  lVar5 = *(int64 *)(*(int64 *)(DAT_181d4e010 + 184) + 8);
                                  if (lVar5 != null) {
                                    lVar5 = lVar5.isSummon;
                                    if (this.heroData != null) {
                                      uVar6 = Int32.ToString(this.heroData + 88,0);
                                      uVar6 = String.Concat("HandBookHero_",uVar6,0);
                                      if (lVar5 != null) {
                                        iVar4 = PlayerPrefDictionary.GetInt(lVar5,uVar6,0);
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
    }

    // Token : 0x600178D
    // RVA   : 0xB338C0   Offset: 0xB320C0   Length: 0x171
    public void Update()
    {
        long lVar1;
        long lVar2;
        bool cVar3;
        int iVar4;
        ulong uVar5;
        ulong uVar6;
        lVar1 = this.skeletonGraphic;
        uVar6 = *(uint64 *)(*(int64 *)(DAT_181d66570 + 184) + 72);
        uVar5 = Component.get_gameObject(this,0);
        cVar3 = Object.op_Inequality(uVar6,uVar5,0);
        if (!cVar3) {
          lVar2 = *(int64 *)(*(int64 *)(DAT_181d4e010 + 184) + 8);
          if (lVar2 == null) throw; // [null/range check failed]
          lVar2 = *(int64 *)(lVar2 + 16);
          if (this.heroData == null) throw; // [null/range check failed]
          uVar6 = Int32.ToString(this.heroData + 88,0);
          uVar6 = String.Concat("HandBookHero_",uVar6,0);
          if (lVar2 == null) throw; // [null/range check failed]
          iVar4 = PlayerPrefDictionary.GetInt(lVar2,uVar6,0);
          bVar7 = iVar4 == 0;
        }
        else {
          bVar7 = true;
        }
        if (lVar1 != null) {
          *(bool *)(lVar1 + 0x118) = bVar7;
          return;
        }
    }

    // Token : 0x600178E
    // RVA   : 0x3A17B0   Offset: 0x39FFB0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_18044ef50(this,0);
    }

}
