// ============================================================
// Type  : SkillExpShowPrefab
// Token : 0x2000353
// ============================================================

public class SkillExpShowPrefab
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001A94
    public static float minSpeed;

    // Token: 0x4001A95
    public static float maxTime;

    // Token: 0x4001A96
    public KungfuSkillLvData targetSkill;

    // Token: 0x4001A97
    public int originLv;

    // Token: 0x4001A98
    public int expType;

    // Token: 0x4001A99
    public float totalExp;

    // Token: 0x4001A9A
    public float changeExpSpeed;

    // Token: 0x4001A9B
    private bool inited;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60020A1
    // RVA   : 0x9720F0   Offset: 0x9708F0   Length: 0x27A
    private void Update()
    {
        int iVar1;
        bool cVar2;
        long lVar3;
        ulong uVar4;
        float fVar5;
        float fVar6;
        float fVar7;
        if (!this.inited) {
          this.inited = 1;
          SkillExpShowPrefab.Init(this,0);
          return;
        }
        if (this.totalExp <= 0.0) {
          return;
        }
        lVar3 = Component.GetComponent(this,DAT_181d6ab40);
        if (lVar3 != null) {
          cVar2 = AudioSource.get_isPlaying(lVar3,0);
          if (!cVar2) {
            lVar3 = Component.GetComponent(this,DAT_181d6ab40);
            if (lVar3 == null) throw; // [null/range check failed]
            AudioSource.Play(lVar3,0);
          }
          fVar5 = (float)RealTime.get_deltaTime(0);
          fVar7 = this.totalExp;
          fVar6 = fVar7;
          if (fVar5 * this.changeExpSpeed <= fVar7) {
            fVar6 = (float)RealTime.get_deltaTime(0);
            fVar7 = this.totalExp;
            fVar6 = fVar6 * this.changeExpSpeed;
          }
          this.totalExp = fVar7 - fVar6;
          if (this.targetSkill != null) {
            iVar1 = this.targetSkill.lv;
            if (this.expType == null) {
              lVar3 = FUN_18046c0a0(0);
              if (((lVar3 == null) || (*(int64 *)(lVar3 + 32) == 0)) ||
                 (lVar3 = WorldData.Player(*(int64 *)(lVar3 + 32),0)) == null)
              throw; // [null/range check failed]
              HeroData.AddSkillBookExp(lVar3,fVar6,this.targetSkill,0,0);
            }
            else {
              lVar3 = FUN_18046c0a0(0);
              if (((lVar3 == null) || (*(int64 *)(lVar3 + 32) == 0)) ||
                 (lVar3 = WorldData.Player(*(int64 *)(lVar3 + 32),0)) == null)
              throw; // [null/range check failed]
              HeroData.AddSkillFightExp(lVar3,fVar6,this.targetSkill,0,0);
            }
            if (this.targetSkill != null) {
              if (iVar1 < this.targetSkill.lv) {
                lVar3 = FUN_18046c600(0);
                uVar4 = Component.get_gameObject(this,0);
                if (lVar3 == null) throw; // [null/range check failed]
                SpeShowController.ShowSkillLevelUpParticle(lVar3,uVar4,this.targetSkill,0)
                ;
              }
              if (this.totalExp <= 0.0) {
                lVar3 = Component.GetComponent(this,DAT_181d6ab40);
                if (lVar3 == null) throw; // [null/range check failed]
                AudioSource.Stop(lVar3,0);
              }
              SkillExpShowPrefab.RefreshUI(this,0);
              return;
            }
          }
        }
    }

    // Token : 0x60020A2
    // RVA   : 0x971A20   Offset: 0x970220   Length: 0x6C5
    private void RefreshUI()
    {
        float fVar1;
        uint uVar2;
        long lVar3;
        ulong uVar4;
        ulong uVar5;
        ulong uVar6;
        long lVar7;
        float fVar8;
        int[] local_res18 = new int[2];
        uint[] local_res20 = new uint[2];
        local_res18[0] = 0;
        local_res20[0] = 0;
        lVar3 = Component.get_transform(this,0);
        if ((lVar3 != null) && (lVar3 = Transform.Find(lVar3,"Lv",0)) != null) {
          uVar4 = Component.GetComponent(lVar3,DAT_181d6d8c0);
          if (this.targetSkill != null) {
            uVar2 = this.targetSkill.lv;
            uVar5 = GlobalData.GetNumText(uVar2,0);
            uVar5 = String.Concat(uVar5,"级",0);
            LTLocalization.SetText(uVar4,uVar5,0);
            if (this.targetSkill != null) {
              if (this.targetSkill.lv < 10) {
                lVar3 = Component.get_transform(this,0);
                if (((lVar3 == null) || (lVar3 = Transform.Find(lVar3,"BookExpBar",0)) == null) ||
                   (lVar3 = Transform.Find(lVar3,"Exp",0)) == null) throw; // [null/range check failed]
                uVar4 = Component.GetComponent(lVar3,DAT_181d6d8c0);
                if (this.targetSkill == null) throw; // [null/range check failed]
                local_res18[0] = (int)this.targetSkill.bookExp;
                uVar5 = Int32.ToString(local_res18,0);
                if (this.targetSkill == null) throw; // [null/range check failed]
                local_res20[0] = KungfuSkillLvData.SkillGetMaxExp(this.targetSkill,0,0);
                uVar6 = Single.ToString(local_res20,0);
                uVar5 = String.Concat(uVar5,"/",uVar6,0);
                LTLocalization.SetText(uVar4,uVar5,0);
                lVar3 = Component.get_transform(this,0);
                if (((lVar3 == null) || (lVar3 = Transform.Find(lVar3,"BookExpBar",0)) == null) ||
                   (lVar3 = Transform.Find(lVar3,"Bar",0)) == null) throw; // [null/range check failed]
                lVar7 = Component.GetComponent(lVar3,DAT_181d6bc40);
                lVar3 = this.targetSkill;
                if (lVar3 == null) throw; // [null/range check failed]
                fVar1 = lVar3.bookExp;
                fVar8 = (float)KungfuSkillLvData.SkillGetMaxExp(lVar3,0,0);
                if (lVar7 == null) throw; // [null/range check failed]
                Image.set_fillAmount(lVar7,fVar1 / fVar8,0);
                lVar3 = Component.get_transform(this,0);
                if (((lVar3 == null) || (lVar3 = Transform.Find(lVar3,"FightExpBar",0)) == null) ||
                   (lVar3 = Transform.Find(lVar3,"Exp",0)) == null) throw; // [null/range check failed]
                uVar4 = Component.GetComponent(lVar3,DAT_181d6d8c0);
                if (this.targetSkill == null) throw; // [null/range check failed]
                local_res18[0] = (int)this.targetSkill.fightExp;
                uVar5 = Int32.ToString(local_res18,0);
                if (this.targetSkill == null) throw; // [null/range check failed]
                local_res20[0] = KungfuSkillLvData.SkillGetMaxExp(this.targetSkill,1);
                uVar6 = Single.ToString(local_res20,0);
                uVar5 = String.Concat(uVar5,"/",uVar6,0);
                LTLocalization.SetText(uVar4,uVar5,0);
                lVar3 = Component.get_transform(this,0);
                if (((lVar3 == null) || (lVar3 = Transform.Find(lVar3,"FightExpBar",0)) == null) ||
                   (lVar3 = Transform.Find(lVar3,"Bar",0)) == null) throw; // [null/range check failed]
                lVar7 = Component.GetComponent(lVar3,DAT_181d6bc40);
                lVar3 = this.targetSkill;
                if (lVar3 == null) throw; // [null/range check failed]
                fVar1 = lVar3.fightExp;
                fVar8 = (float)KungfuSkillLvData.SkillGetMaxExp(lVar3,1);
                if (lVar7 == null) throw; // [null/range check failed]
                Image.set_fillAmount(lVar7,fVar1 / fVar8,0);
              }
              else {
                lVar3 = Component.get_transform(this,0);
                if (((lVar3 == null) || (lVar3 = Transform.Find(lVar3,"BookExpBar",0)) == null) ||
                   (lVar3 = Component.get_gameObject(lVar3,0)) == null) throw; // [null/range check failed]
                GameObject.SetActive(lVar3,0,0);
                lVar3 = Component.get_transform(this,0);
                if (((lVar3 == null) || (lVar3 = Transform.Find(lVar3,"FightExpBar",0)) == null) ||
                   (lVar3 = Component.get_gameObject(lVar3,0)) == null) throw; // [null/range check failed]
                GameObject.SetActive(lVar3,0,0);
                lVar3 = Component.get_transform(this,0);
                if ((lVar3 == null) || (lVar3 = Transform.Find(lVar3,"Max",0)) == null)
                throw; // [null/range check failed]
                lVar3 = Component.get_gameObject(lVar3,0);
                if (lVar3 == null) throw; // [null/range check failed]
                GameObject.SetActive(lVar3,1,0);
              }
              if (this.targetSkill != null) {
                if (this.originLv < this.targetSkill.lv) {
                  lVar3 = Component.get_transform(this,0);
                  if ((lVar3 != null) && (lVar3 = Transform.Find(lVar3,"LvUp",0)) != null) {
                    lVar3 = Component.get_gameObject(lVar3,0);
                    if (lVar3 != null) {
                      GameObject.SetActive(lVar3,1,0);
                      lVar3 = Component.get_transform(this,0);
                      if ((((lVar3 != null) && (lVar3 = Transform.Find(lVar3,"BookExpBar",0)) != null)
                          && (lVar3 = Transform.Find(lVar3,"OriginBar",0)) != null) &&
                         (lVar3 = Component.GetComponent(lVar3,DAT_181d6bc40)) != null) {
                        Image.set_fillAmount(lVar3,0,0);
                        lVar3 = Component.get_transform(this,0);
                        if (((lVar3 != null) && (lVar3 = Transform.Find(lVar3,"FightExpBar",0)) != null)
                           && ((lVar3 = Transform.Find(lVar3,"OriginBar",0), lVar3 != null &&
                               (lVar3 = Component.GetComponent(lVar3,DAT_181d6bc40)) != null))) {
                          Image.set_fillAmount(lVar3,0,0);
                          return;
                        }
                      }
                    }
                  }
                }
                else {
                  lVar3 = Component.get_transform(this,0);
                  if (((lVar3 != null) && (lVar3 = Transform.Find(lVar3,"LvUp",0)) != null) &&
                     (lVar3 = Component.get_gameObject(lVar3,0)) != null) {
                    GameObject.SetActive(lVar3,0,0);
                    return;
                  }
                }
              }
            }
          }
        }
    }

    // Token : 0x60020A3
    // RVA   : 0x9715F0   Offset: 0x96FDF0   Length: 0x424
    public void Init()
    {
        bool cVar1;
        long lVar2;
        ulong uVar3;
        ulong uVar4;
        long lVar5;
        float fVar6;
        uint uVar7;
        float fVar8;
        lVar2 = Component.get_transform(this,0);
        if (lVar2 != null) {
          lVar2 = Transform.Find(lVar2,"Name",0);
          if (lVar2 != null) {
            uVar3 = Component.GetComponent(lVar2,DAT_181d6d8c0);
            if (this.targetSkill != null) {
              uVar4 = KungfuSkillLvData.Name(this.targetSkill,0,0);
              LTLocalization.SetText(uVar3,uVar4,0);
              lVar2 = Component.get_transform(this,0);
              if (lVar2 != null) {
                lVar2 = Transform.Find(lVar2,"Icon",0);
                if (lVar2 != null) {
                  lVar2 = Component.GetComponent(lVar2,DAT_181d6bc40);
                  lVar5 = **(int64 **)(DAT_181d86270 + 184);
                  if (this.targetSkill != null) {
                    uVar3 = KungfuSkillLvData.GetSkillIcon(this.targetSkill,0);
                    if (lVar5 != null) {
                      uVar3 = TextureController.LoadAtlasSprite(lVar5,"IconAtlas",uVar3,0);
                      if (lVar2 != null) {
                        Image.set_sprite(lVar2,uVar3,0);
                        lVar2 = Component.get_transform(this,0);
                        if (lVar2 != null) {
                          lVar2 = Transform.Find(lVar2,"BookExpBar",0);
                          if (lVar2 != null) {
                            lVar2 = Transform.Find(lVar2,"OriginBar",0);
                            if (lVar2 != null) {
                              lVar5 = Component.GetComponent(lVar2,DAT_181d6bc40);
                              lVar2 = this.targetSkill;
                              if (lVar2 != null) {
                                fVar8 = lVar2.bookExp;
                                fVar6 = (float)KungfuSkillLvData.SkillGetMaxExp(lVar2,0,0);
                                if (lVar5 != null) {
                                  Image.set_fillAmount(lVar5,fVar8 / fVar6,0);
                                  lVar2 = Component.get_transform(this,0);
                                  if (lVar2 != null) {
                                    lVar2 = Transform.Find(lVar2,"FightExpBar",0);
                                    if (lVar2 != null) {
                                      lVar2 = Transform.Find(lVar2,"OriginBar",0);
                                      if (lVar2 != null) {
                                        lVar5 = Component.GetComponent(lVar2,DAT_181d6bc40);
                                        lVar2 = this.targetSkill;
                                        if (lVar2 != null) {
                                          fVar8 = lVar2.fightExp;
                                          fVar6 = (float)KungfuSkillLvData.SkillGetMaxExp(lVar2,1);
                                          if (lVar5 != null) {
                                            Image.set_fillAmount(lVar5,fVar8 / fVar6,0);
                                            uVar7 = Mathf.Max(**(uint32 **)(DAT_181d7deb0 + 184),
                                                               this.totalExp /
                                                               (float)(*(uint32 **)
                                                                        (DAT_181d7deb0 + 184))[1],0);
                                            this.changeExpSpeed = uVar7;
                                            if (this.targetSkill != null) {
                                              this.originLv =
                                                   this.targetSkill.lv;
                                              uVar3 = Component.GetComponent(this,DAT_181d6ab40);
                                              cVar1 = Object.op_Inequality(uVar3,0,0);
                                              if (cVar1) {
                                                lVar2 = Component.GetComponent(this,DAT_181d6ab40);
                                                if (lVar2 == null) throw; // [null/range check failed]
                                                fVar8 = (float)AudioSource.get_volume(lVar2,0);
                                                AudioSource.set_volume
                                                          (lVar2,fVar8 * *(float *)(*(int64 *)
                                                                                     (DAT_181d4e010 + 184
                                                                                     ) + 16),0);
                                              }
                                              SkillExpShowPrefab.RefreshUI(this,0);
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

    // Token : 0x60020A4
    // RVA   : 0x3A17B0   Offset: 0x39FFB0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_18044ef50(this,0);
    }

    // Token : 0x60020A5
    // RVA   : 0x972370   Offset: 0x970B70   Length: 0x4E
    private static void /*cctor*/()
    {
        **(uint32 **)(DAT_181d7deb0 + 184) = 0x42480000;
        *(uint32 *)(*(int64 *)(DAT_181d7deb0 + 184) + 4) = 0x40000000;
    }

}
