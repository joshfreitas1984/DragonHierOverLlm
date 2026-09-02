// ============================================================
// Type  : AttriNumData
// Token : 0x200021F
// ============================================================

public class AttriNumData
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x400109B
    public List<float> attri;

    // Token: 0x400109C
    public List<float> fightSkill;

    // Token: 0x400109D
    public List<float> livingSkill;

    // Token: 0x400109E
    public float Hp;

    // Token: 0x400109F
    public float Power;

    // Token: 0x40010A0
    public float Mana;

    // Token: 0x40010A1
    public float Charm;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6001215
    // RVA   : 0x7F2820   Offset: 0x7F1020   Length: 0x2AC
    public void /*ctor*/()
    {
        long lVar1;
        ZhSegment.Initialize(this,0);
        lVar1 = il2cpp_internal(DAT_181d721b0);
        FUN_180f58a90(lVar1,DAT_181d79358);
        if (lVar1 != null) {
          FUN_181805690(lVar1,0,DAT_181d79458);
          FUN_181805690(lVar1,0,DAT_181d79458);
          FUN_181805690(lVar1,0,DAT_181d79458);
          FUN_181805690(lVar1,0,DAT_181d79458);
          FUN_181805690(lVar1,0,DAT_181d79458);
          FUN_181805690(lVar1,0,DAT_181d79458);
          this.attri = lVar1;
          lVar1 = il2cpp_internal(DAT_181d721b0);
          FUN_180f58a90(lVar1,DAT_181d79358);
          if (lVar1 != null) {
            FUN_181805690(lVar1,0,DAT_181d79458);
            FUN_181805690(lVar1,0,DAT_181d79458);
            FUN_181805690(lVar1,0,DAT_181d79458);
            FUN_181805690(lVar1,0,DAT_181d79458);
            FUN_181805690(lVar1,0,DAT_181d79458);
            FUN_181805690(lVar1,0,DAT_181d79458);
            FUN_181805690(lVar1,0,DAT_181d79458);
            FUN_181805690(lVar1,0,DAT_181d79458);
            FUN_181805690(lVar1,0,DAT_181d79458);
            this.fightSkill = lVar1;
            lVar1 = il2cpp_internal(DAT_181d721b0);
            FUN_180f58a90(lVar1,DAT_181d79358);
            if (lVar1 != null) {
              FUN_181805690(lVar1,0,DAT_181d79458);
              FUN_181805690(lVar1,0,DAT_181d79458);
              FUN_181805690(lVar1,0,DAT_181d79458);
              FUN_181805690(lVar1,0,DAT_181d79458);
              FUN_181805690(lVar1,0,DAT_181d79458);
              FUN_181805690(lVar1,0,DAT_181d79458);
              FUN_181805690(lVar1,0,DAT_181d79458);
              FUN_181805690(lVar1,0,DAT_181d79458);
              FUN_181805690(lVar1,0,DAT_181d79458);
              this.livingSkill = lVar1;
              return;
            }
          }
        }
    }

    // Token : 0x6001216
    // RVA   : 0x7F0E30   Offset: 0x7EF630   Length: 0x299
    public string GetAttriRatioString(float attriRatio)
    {
        var plVar4 = *(int64*)(lVar4 + 184);
        long lVar1;
        uint uVar2;
        ulong uVar3;
        long lVar4;
        int iVar5;
        uint uVar6;
        uVar6 = 0;
        lVar4 = DAT_181d4ef00;
        do {
          if (((*(byte *)(lVar4 + 0x133) & 4) != 0) && (*(int *)(lVar4 + 224) == 0)) {
            il2cpp_runtime_class_init();
            lVar4 = DAT_181d4ef00;
          }
          lVar1 = *(int64 *)(plVar4 + 0x558);
          if (lVar1 == null) goto LAB_1807f10c4;
          if (*(int *)(lVar1 + 24) <= (int)uVar6) {
            if (((*(byte *)(lVar4 + 0x133) & 4) != 0) && (*(int *)(lVar4 + 224) == 0)) {
              il2cpp_runtime_class_init();
              lVar4 = DAT_181d4ef00;
            }
            lVar4 = *(int64 *)(plVar4 + 0x558);
            if (lVar4 == null) goto LAB_1807f10c4;
            if (*(uint32 *)(lVar4 + 24) <= uVar6) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            uVar3 = lVar4[uVar6];
            lVar4 = *(int64 *)(*(int64 *)(DAT_181d4e010 + 184) + 32);
            if ((lVar4 == null) || (lVar4 = *(int64 *)(lVar4 + 56)) == null) goto LAB_1807f10c4;
            iVar5 = *(int *)(lVar4 + 24);
            goto LAB_1807f0fc2;
          }
          if ((float)(int)uVar6 <= attriRatio) {
            if (attriRatio < (float)(int)(uVar6 + 1)) {
        LAB_1807f0f3e:
              if (((*(byte *)(lVar4 + 0x133) & 4) != 0) && (*(int *)(lVar4 + 224) == 0)) {
                il2cpp_runtime_class_init();
                lVar4 = DAT_181d4ef00;
              }
              lVar4 = *(int64 *)(plVar4 + 0x558);
              if (lVar4 != null) {
                uVar3 = FUN_180002f80(lVar4,uVar6,DAT_181d7c9c0);
                lVar4 = FUN_18046c100(0);
                if ((lVar4 != null) && (*(int64 *)(lVar4 + 56) != 0)) {
                  iVar5 = *(int *)(*(int64 *)(lVar4 + 56) + 24);
        LAB_1807f0fc2:
                  uVar2 = Mathf.Min(uVar6,iVar5 + -1,0);
                  GlobalData.GenerateRareLvColorText(uVar3,uVar2,0);
                  return;
                }
              }
        LAB_1807f10c4:
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            if (((*(byte *)(lVar4 + 0x133) & 4) != 0) && (*(int *)(lVar4 + 224) == 0)) {
              il2cpp_runtime_class_init();
              lVar4 = DAT_181d4ef00;
            }
            lVar1 = *(int64 *)(plVar4 + 0x558);
            if (lVar1 == null) goto LAB_1807f10c4;
            if (uVar6 == *(int *)(lVar1 + 24) - 1U) goto LAB_1807f0f3e;
          }
          uVar6 = uVar6 + 1;
        } while( true );
    }

    // Token : 0x6001217
    // RVA   : 0x7F10D0   Offset: 0x7EF8D0   Length: 0x703
    public string GetDamageRatioDescribe(float speRate)
    {
        var pStatics = *(int64*)(DAT_181d4ef00 + 184);
        bool cVar1;
        ulong uVar2;
        ulong uVar3;
        ulong uVar4;
        long lVar5;
        uint uVar6;
        uint uVar7;
        ulong uVar8;
        long lVar9;
        long lVar10;
        float fVar11;
        lVar5 = this.attri;
        uVar7 = 0;
        if (lVar5 != null) {
          lVar9 = 32;
          lVar10 = 32;
          uVar4 = "";
          uVar6 = uVar7;
          do {
            if (lVar5.Count <= (int)uVar7) {
              lVar5 = this.fightSkill;
              uVar7 = 0;
              if (lVar5 != null) {
                lVar10 = 32;
                goto LAB_1807f1315;
              }
              break;
            }
            if (lVar5 == null) break;
            if (lVar5.Count <= uVar7) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            if (*(float *)(lVar10 + lVar5._items) != 0.0) {
              cVar1 = FUN_1816fd990(uVar4,"",0);
              uVar8 = "";
              if ((!cVar1) &&
                 (uVar8 = " ",
                 uVar6 == ((int)uVar6 / 3 + ((int)uVar6 >> 31) +
                          (int)(((int64)(int)uVar6 / 3 + ((int64)(int)uVar6 >> 63) & 0xffffffffU)
                               >> 31)) * 3)) {
                uVar8 = "\n";
              }
              lVar5 = *(int64 *)(pStatics + 0x490);
              if (lVar5 == null) break;
              uVar2 = FUN_180002f80(lVar5,uVar7,DAT_181d7c9c0);
              if (this.attri == null) break;
              fVar11 = (float)FUN_1800d6780(this.attri,uVar7,DAT_181d796d8);
              uVar3 = AttriNumData.GetAttriRatioString(this,fVar11 * speRate,0);
              uVar4 = String.Concat(uVar4,uVar8,uVar2,uVar3,0);
              uVar6 = uVar6 + 1;
            }
            lVar5 = this.attri;
            uVar7 = uVar7 + 1;
            lVar10 = lVar10 + 4;
          } while (lVar5 != null);
        }
        throw; // [null/range check failed]
        while( true ) {
          if (lVar5 == null) break;
          if (lVar5.Count <= uVar7) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          if (*(float *)(lVar10 + lVar5._items) != 0.0) {
            cVar1 = FUN_1816fd990(uVar4,"",0);
            uVar8 = "";
            if ((!cVar1) &&
               (uVar8 = " ",
               uVar6 == ((int)uVar6 / 3 + ((int)uVar6 >> 31) +
                        (int)(((int64)(int)uVar6 / 3 + ((int64)(int)uVar6 >> 63) & 0xffffffffU) >>
                             31)) * 3)) {
              uVar8 = "\n";
            }
            lVar5 = *(int64 *)(pStatics + 0x498);
            if (lVar5 == null) break;
            uVar2 = FUN_180002f80(lVar5,uVar7,DAT_181d7c9c0);
            if (this.fightSkill == null) break;
            fVar11 = (float)FUN_1800d6780(this.fightSkill,uVar7,DAT_181d796d8);
            uVar3 = AttriNumData.GetAttriRatioString(this,fVar11 * speRate,0);
            uVar4 = String.Concat(uVar4,uVar8,uVar2,uVar3,0);
            uVar6 = uVar6 + 1;
          }
          lVar5 = this.fightSkill;
          uVar7 = uVar7 + 1;
          lVar10 = lVar10 + 4;
          if (lVar5 == null) break;
        LAB_1807f1315:
          if (lVar5.Count <= (int)uVar7) {
            lVar5 = this.livingSkill;
            uVar7 = 0;
            if (lVar5 != null) goto LAB_1807f1460;
            break;
          }
        }
        throw; // [null/range check failed]
        while( true ) {
          lVar5 = this.livingSkill;
          uVar7 = uVar7 + 1;
          lVar9 = lVar9 + 4;
          if (lVar5 == null) break;
        LAB_1807f1460:
          if (lVar5.Count <= (int)uVar7) {
            if (this.Hp != null.0) {
              cVar1 = FUN_1816fd990(uVar4,"",0);
              uVar8 = "";
              if ((!cVar1) &&
                 (uVar8 = " ",
                 uVar6 == ((int)uVar6 / 3 + ((int)uVar6 >> 31) +
                          (int)(((int64)(int)uVar6 / 3 + ((int64)(int)uVar6 >> 63) & 0xffffffffU)
                               >> 31)) * 3)) {
                uVar8 = "\n";
              }
              uVar2 = AttriNumData.GetAttriRatioString
                                (this,this.Hp * 10.0 * speRate,0);
              uVar4 = String.Concat(uVar4,uVar8,"生命",uVar2,0);
              uVar6 = uVar6 + 1;
            }
            if (this.Power != null.0) {
              cVar1 = FUN_1816fd990(uVar4,"",0);
              uVar8 = "";
              if ((!cVar1) &&
                 (uVar8 = " ",
                 uVar6 == ((int)uVar6 / 3 + ((int)uVar6 >> 31) +
                          (int)(((int64)(int)uVar6 / 3 + ((int64)(int)uVar6 >> 63) & 0xffffffffU)
                               >> 31)) * 3)) {
                uVar8 = "\n";
              }
              uVar2 = AttriNumData.GetAttriRatioString(this,this.Power * speRate,0);
              uVar4 = String.Concat(uVar4,uVar8,"体力",uVar2,0);
              uVar6 = uVar6 + 1;
            }
            if (this.Mana != null.0) {
              cVar1 = FUN_1816fd990(uVar4,"",0);
              uVar8 = "";
              if ((!cVar1) &&
                 (uVar8 = " ",
                 uVar6 == ((int)uVar6 / 3 + ((int)uVar6 >> 31) +
                          (int)(((int64)(int)uVar6 / 3 + ((int64)(int)uVar6 >> 63) & 0xffffffffU)
                               >> 31)) * 3)) {
                uVar8 = "\n";
              }
              uVar2 = AttriNumData.GetAttriRatioString
                                (this,this.Mana * 10.0 * speRate,0);
              uVar4 = String.Concat(uVar4,uVar8,"内力",uVar2,0);
              uVar6 = uVar6 + 1;
            }
            if (this.Charm != null.0) {
              cVar1 = FUN_1816fd990(uVar4,"",0);
              uVar8 = "";
              if ((!cVar1) &&
                 (uVar8 = " ",
                 uVar6 == ((int)uVar6 / 3 + ((int)uVar6 >> 31) +
                          (int)(((int64)(int)uVar6 / 3 + ((int64)(int)uVar6 >> 63) & 0xffffffffU)
                               >> 31)) * 3)) {
                uVar8 = "\n";
              }
              uVar2 = AttriNumData.GetAttriRatioString(this,this.Charm * speRate,0);
              uVar4 = String.Concat(uVar4,uVar8,"魅力",uVar2,0);
            }
            return uVar4;
          }
          if (lVar5 == null) break;
          if (lVar5.Count <= uVar7) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          if (*(float *)(lVar5._items + lVar9) != 0.0) {
            cVar1 = FUN_1816fd990(uVar4,"",0);
            uVar8 = "";
            if ((!cVar1) &&
               (uVar8 = " ",
               uVar6 == ((int)uVar6 / 3 + ((int)uVar6 >> 31) +
                        (int)(((int64)(int)uVar6 / 3 + ((int64)(int)uVar6 >> 63) & 0xffffffffU) >>
                             31)) * 3)) {
              uVar8 = "\n";
            }
            lVar5 = *(int64 *)(pStatics + 0x4a8);
            if (lVar5 == null) break;
            uVar2 = FUN_180002f80(lVar5,uVar7,DAT_181d7c9c0);
            if (this.livingSkill == null) break;
            fVar11 = (float)FUN_1800d6780(this.livingSkill,uVar7,DAT_181d796d8);
            uVar3 = AttriNumData.GetAttriRatioString(this,fVar11 * speRate,0);
            uVar4 = String.Concat(uVar4,uVar8,uVar2,uVar3,0);
            uVar6 = uVar6 + 1;
          }
        }
    }

    // Token : 0x6001218
    // RVA   : 0x7F1F10   Offset: 0x7F0710   Length: 0x90E
    public string GetSkillNeedsDescribe(HeroData targetHero)
    {
        var pStatics = *(int64*)(DAT_181d4ef00 + 184);
        bool cVar1;
        ulong uVar2;
        ulong uVar3;
        ulong uVar4;
        ulong uVar5;
        long lVar6;
        uint uVar7;
        ulong uVar8;
        uint uVar9;
        long lVar10;
        float fVar11;
        float fVar12;
        uint[] local_res8 = new uint[2];
        lVar6 = this.attri;
        uVar7 = 0;
        uVar9 = 0;
        local_res8[0] = 0;
        if (lVar6 != null) {
          lVar10 = 32;
          uVar5 = "";
          while ((int)uVar9 < lVar6.Count) {
            if (lVar6 == null) goto LAB_1807f2819;
            if (lVar6.Count <= uVar9) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            if (*(float *)(lVar10 + lVar6._items) != 0.0) {
              cVar1 = FUN_1816fd990(uVar5,"",0);
              uVar8 = "/";
              if (cVar1) {
                uVar8 = "";
              }
              if ((targetHero == null) || (*(int64 *)(targetHero + 0x138) == 0)) goto LAB_1807f2819;
              fVar11 = (float)FUN_1800d6780(*(int64 *)(targetHero + 0x138),uVar9,DAT_181d796d8);
              if (this.attri == null) goto LAB_1807f2819;
              fVar12 = (float)FUN_1800d6780(this.attri,uVar9,DAT_181d796d8);
              uVar2 = "{1}{0}";
              if (fVar11 < fVar12) {
                uVar2 = String.Concat(*(uint64 *)(pStatics + 0x2c8),
                                       "{1}{0}</color>",0);
              }
              if (this.attri == null) goto LAB_1807f2819;
              local_res8[0] = FUN_1800d6780(this.attri,uVar9,DAT_181d796d8);
              uVar3 = Single.ToString(local_res8,0);
              lVar6 = *(int64 *)(pStatics + 0x490);
              if (lVar6 == null) goto LAB_1807f2819;
              uVar4 = FUN_180002f80(lVar6,uVar9,DAT_181d7c9c0);
              uVar2 = String.Format(uVar2,uVar3,uVar4);
              uVar5 = String.Concat(uVar5,uVar8,uVar2,0);
            }
            lVar6 = this.attri;
            uVar9 = uVar9 + 1;
            lVar10 = lVar10 + 4;
            if (lVar6 == null) goto LAB_1807f2819;
          }
          lVar6 = this.fightSkill;
          uVar9 = 0;
          if (lVar6 != null) {
            lVar10 = 32;
            goto LAB_1807f2205;
          }
        }
        LAB_1807f2819:
                          // WARNING: Subroutine does not return
        FUN_1800d6620();
        LAB_1807f2205:
        if (lVar6.Count <= (int)uVar9) {
          lVar6 = this.livingSkill;
          if (lVar6 != null) {
            lVar10 = 32;
            goto LAB_1807f23e0;
          }
          goto LAB_1807f2819;
        }
        if (lVar6 == null) goto LAB_1807f2819;
        if (lVar6.Count <= uVar9) {
          ThrowHelper.ThrowArgumentOutOfRangeException(0);
        }
        if (*(float *)(lVar10 + lVar6._items) != 0.0) {
          cVar1 = FUN_1816fd990(uVar5,"",0);
          uVar8 = "/";
          if (cVar1) {
            uVar8 = "";
          }
          if ((targetHero == null) || (*(int64 *)(targetHero + 0x150) == 0)) goto LAB_1807f2819;
          fVar11 = (float)FUN_1800d6780(*(int64 *)(targetHero + 0x150),uVar9,DAT_181d796d8);
          if (this.fightSkill == null) goto LAB_1807f2819;
          fVar12 = (float)FUN_1800d6780(this.fightSkill,uVar9,DAT_181d796d8);
          uVar2 = "{1}{0}";
          if (fVar11 < fVar12) {
            uVar2 = String.Concat(*(uint64 *)(pStatics + 0x2c8),
                                   "{1}{0}</color>",0);
          }
          if (this.fightSkill == null) goto LAB_1807f2819;
          local_res8[0] = FUN_1800d6780(this.fightSkill,uVar9,DAT_181d796d8);
          uVar3 = Single.ToString(local_res8,0);
          lVar6 = *(int64 *)(pStatics + 0x498);
          if (lVar6 == null) goto LAB_1807f2819;
          uVar4 = FUN_180002f80(lVar6,uVar9,DAT_181d7c9c0);
          uVar2 = String.Format(uVar2,uVar3,uVar4);
          uVar5 = String.Concat(uVar5,uVar8,uVar2,0);
        }
        lVar6 = this.fightSkill;
        uVar9 = uVar9 + 1;
        lVar10 = lVar10 + 4;
        if (lVar6 == null) goto LAB_1807f2819;
        goto LAB_1807f2205;
        LAB_1807f23e0:
        if (lVar6.Count <= (int)uVar7) {
          if (this.Hp != null.0) {
            cVar1 = FUN_1816fd990(uVar5,"",0);
            uVar8 = "/";
            if (cVar1) {
              uVar8 = "";
            }
            if (targetHero == null) goto LAB_1807f2819;
            uVar2 = "生命{0}";
            if (*(float *)(targetHero + 0x17c) <= this.Hp &&
                this.Hp != *(float *)(targetHero + 0x17c)) {
              uVar2 = String.Concat(*(uint64 *)(pStatics + 0x2c8),
                                     "生命{0}</color>",0);
            }
            uVar3 = Single.ToString(this + 40,0);
            uVar2 = String.Format(uVar2,uVar3,0);
            uVar5 = String.Concat(uVar5,uVar8,uVar2,0);
          }
          if (this.Power != null.0) {
            cVar1 = FUN_1816fd990(uVar5,"",0);
            uVar8 = "/";
            if (cVar1) {
              uVar8 = "";
            }
            if (targetHero == null) goto LAB_1807f2819;
            uVar2 = "体力{0}";
            if (*(float *)(targetHero + 0x188) <= this.Power &&
                this.Power != *(float *)(targetHero + 0x188)) {
              uVar2 = String.Concat(*(uint64 *)(pStatics + 0x2c8),
                                     "体力{0}</color>",0);
            }
            uVar3 = Single.ToString(this + 44,0);
            uVar2 = String.Format(uVar2,uVar3,0);
            uVar5 = String.Concat(uVar5,uVar8,uVar2,0);
          }
          if (this.Mana != null.0) {
            cVar1 = FUN_1816fd990(uVar5,"",0);
            uVar8 = "/";
            if (cVar1) {
              uVar8 = "";
            }
            if (targetHero == null) goto LAB_1807f2819;
            uVar2 = "内力{0}";
            if (*(float *)(targetHero + 0x194) <= this.Mana &&
                this.Mana != *(float *)(targetHero + 0x194)) {
              uVar2 = String.Concat(*(uint64 *)(pStatics + 0x2c8),
                                     "内力{0}</color>",0);
            }
            uVar3 = Single.ToString(this + 48,0);
            uVar2 = String.Format(uVar2,uVar3,0);
            uVar5 = String.Concat(uVar5,uVar8,uVar2,0);
          }
          return uVar5;
        }
        if (lVar6 == null) goto LAB_1807f2819;
        if (lVar6.Count <= uVar7) {
          ThrowHelper.ThrowArgumentOutOfRangeException(0);
        }
        if (*(float *)(lVar10 + lVar6._items) != 0.0) {
          cVar1 = FUN_1816fd990(uVar5,"",0);
          uVar8 = "/";
          if (cVar1) {
            uVar8 = "";
          }
          if ((targetHero == null) || (*(int64 *)(targetHero + 0x168) == 0)) goto LAB_1807f2819;
          fVar11 = (float)FUN_1800d6780(*(int64 *)(targetHero + 0x168),uVar7,DAT_181d796d8);
          if (this.livingSkill == null) goto LAB_1807f2819;
          fVar12 = (float)FUN_1800d6780(this.livingSkill,uVar7,DAT_181d796d8);
          uVar2 = "{1}{0}";
          if (fVar11 < fVar12) {
            uVar2 = String.Concat(*(uint64 *)(pStatics + 0x2c8),
                                   "{1}{0}</color>",0);
          }
          if (this.livingSkill == null) goto LAB_1807f2819;
          local_res8[0] = FUN_1800d6780(this.livingSkill,uVar7,DAT_181d796d8);
          uVar3 = Single.ToString(local_res8,0);
          lVar6 = *(int64 *)(pStatics + 0x4a8);
          if (lVar6 == null) goto LAB_1807f2819;
          uVar4 = FUN_180002f80(lVar6,uVar7,DAT_181d7c9c0);
          uVar2 = String.Format(uVar2,uVar3,uVar4);
          uVar5 = String.Concat(uVar5,uVar8,uVar2,0);
        }
        lVar6 = this.livingSkill;
        uVar7 = uVar7 + 1;
        lVar10 = lVar10 + 4;
        if (lVar6 == null) goto LAB_1807f2819;
        goto LAB_1807f23e0;
    }

    // Token : 0x6001219
    // RVA   : 0x7F17E0   Offset: 0x7EFFE0   Length: 0x728
    public float GetSkillNeedExpRate(HeroData targetHero)
    {
        var pStatics = *(int64*)(DAT_181d4e010 + 184);
        long lVar1;
        uint uVar2;
        uint uVar3;
        long lVar4;
        long lVar5;
        float fVar6;
        float fVar7;
        float fVar8;
        float fVar9;
        float fVar10;
        float fVar11;
        lVar1 = this.attri;
        uVar3 = 0;
        fVar11 = 1.0;
        uVar2 = 0;
        if (lVar1 != null) {
          lVar4 = 32;
          lVar5 = 32;
          fVar10 = 0.0;
          while ((int)uVar2 < lVar1.Count) {
            if (lVar1 == null) goto LAB_1807f1f03;
            if (lVar1.Count <= uVar2) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            if (*(float *)(lVar5 + lVar1._items) != 0.0) {
              if ((targetHero == null) || (*(int64 *)(targetHero + 0x138) == 0)) goto LAB_1807f1f03;
              fVar6 = (float)FUN_1800d6780(*(int64 *)(targetHero + 0x138),uVar2,DAT_181d796d8);
              if (this.attri == null) goto LAB_1807f1f03;
              fVar7 = (float)FUN_1800d6780(this.attri,uVar2,DAT_181d796d8);
              if (*(int64 *)(targetHero + 0x138) == 0) goto LAB_1807f1f03;
              fVar8 = (float)FUN_1800d6780(*(int64 *)(targetHero + 0x138),uVar2,DAT_181d796d8);
              if (this.attri == null) goto LAB_1807f1f03;
              fVar9 = (float)FUN_1800d6780(this.attri,uVar2);
              if (fVar8 <= fVar9) {
                fVar8 = 0.1;
              }
              else {
                fVar8 = 0.0;
              }
              fVar11 = fVar11 + (fVar6 - fVar7) * fVar8;
            }
            lVar1 = this.attri;
            uVar2 = uVar2 + 1;
            lVar5 = lVar5 + 4;
            if (lVar1 == null) goto LAB_1807f1f03;
          }
          lVar1 = this.fightSkill;
          uVar2 = 0;
          if (lVar1 != null) {
            lVar5 = 32;
            goto LAB_1807f19b0;
          }
        }
        LAB_1807f1f03:
                          // WARNING: Subroutine does not return
        FUN_1800d6620();
        LAB_1807f19b0:
        if (lVar1.Count <= (int)uVar2) {
          lVar1 = this.livingSkill;
          if (lVar1 != null) goto LAB_1807f1ab5;
          goto LAB_1807f1f03;
        }
        if (lVar1 == null) goto LAB_1807f1f03;
        if (lVar1.Count <= uVar2) {
          ThrowHelper.ThrowArgumentOutOfRangeException(0);
        }
        if (*(float *)(lVar5 + lVar1._items) != 0.0) {
          if ((targetHero == null) || (*(int64 *)(targetHero + 0x150) == 0)) goto LAB_1807f1f03;
          fVar6 = (float)FUN_1800d6780(*(int64 *)(targetHero + 0x150),uVar2,DAT_181d796d8);
          if (this.fightSkill == null) goto LAB_1807f1f03;
          fVar7 = (float)FUN_1800d6780(this.fightSkill,uVar2,DAT_181d796d8);
          if (*(int64 *)(targetHero + 0x150) == 0) goto LAB_1807f1f03;
          fVar8 = (float)FUN_1800d6780(*(int64 *)(targetHero + 0x150),uVar2,DAT_181d796d8);
          if (this.fightSkill == null) goto LAB_1807f1f03;
          fVar9 = (float)FUN_1800d6780(this.fightSkill,uVar2);
          if (fVar8 <= fVar9) {
            fVar8 = 0.1;
          }
          else {
            fVar8 = 0.0;
          }
          fVar11 = fVar11 + (fVar6 - fVar7) * fVar8;
        }
        lVar1 = this.fightSkill;
        uVar2 = uVar2 + 1;
        lVar5 = lVar5 + 4;
        if (lVar1 == null) goto LAB_1807f1f03;
        goto LAB_1807f19b0;
        LAB_1807f1ab5:
        if (lVar1.Count <= (int)uVar3) {
          fVar6 = this.Hp;
          if (fVar6 != 0.0) {
            if (targetHero == null) goto LAB_1807f1f03;
            fVar7 = *(float *)(targetHero + 0x17c);
            lVar1 = *(int64 *)(pStatics + 32);
            if ((lVar1 == null) || (lVar1 = *(int64 *)(lVar1 + 144)) == null) goto LAB_1807f1f03;
            if (lVar1.Count < 58) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            lVar1 = *(int64 *)(lVar1._items + 0x1e8);
            if (lVar1 == null) goto LAB_1807f1f03;
            if (*(float *)(targetHero + 0x17c) < this.Hp ||
                *(float *)(targetHero + 0x17c) == this.Hp) {
              fVar8 = 0.1;
            }
            else {
              fVar8 = 0.0;
            }
            fVar11 = fVar11 + ((fVar7 - fVar6) / *(float *)(lVar1 + 32)) * fVar8;
          }
          fVar6 = this.Power;
          if (fVar6 != 0.0) {
            if (targetHero == null) goto LAB_1807f1f03;
            fVar7 = *(float *)(targetHero + 0x188);
            lVar1 = *(int64 *)(pStatics + 32);
            if ((lVar1 == null) || (lVar1 = *(int64 *)(lVar1 + 144)) == null) goto LAB_1807f1f03;
            if (lVar1.Count < 59) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            lVar1 = *(int64 *)(lVar1._items + 0x1f0);
            if (lVar1 == null) goto LAB_1807f1f03;
            if (*(float *)(targetHero + 0x188) < this.Power ||
                *(float *)(targetHero + 0x188) == this.Power) {
              fVar8 = 0.1;
            }
            else {
              fVar8 = 0.0;
            }
            fVar11 = fVar11 + ((fVar7 - fVar6) / *(float *)(lVar1 + 32)) * fVar8;
          }
          fVar6 = this.Mana;
          if (fVar6 != 0.0) {
            if (targetHero == null) goto LAB_1807f1f03;
            fVar7 = *(float *)(targetHero + 0x194);
            lVar1 = *(int64 *)(pStatics + 32);
            if ((lVar1 == null) || (lVar1 = *(int64 *)(lVar1 + 144)) == null) goto LAB_1807f1f03;
            if (lVar1.Count < 60) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            lVar1 = *(int64 *)(lVar1._items + 0x1f8);
            if (lVar1 == null) goto LAB_1807f1f03;
            if (*(float *)(targetHero + 0x194) < this.Mana ||
                *(float *)(targetHero + 0x194) == this.Mana) {
              fVar10 = 0.1;
            }
            fVar11 = fVar11 + ((fVar7 - fVar6) / *(float *)(lVar1 + 32)) * fVar10;
          }
          Mathf.Max(fVar11,0x3d4ccccd,0);
          return;
        }
        if (lVar1 == null) goto LAB_1807f1f03;
        if (lVar1.Count <= uVar3) {
          ThrowHelper.ThrowArgumentOutOfRangeException(0);
        }
        if (*(float *)(lVar4 + lVar1._items) != 0.0) {
          if ((targetHero == null) || (*(int64 *)(targetHero + 0x168) == 0)) goto LAB_1807f1f03;
          fVar6 = (float)FUN_1800d6780(*(int64 *)(targetHero + 0x168),uVar3,DAT_181d796d8);
          if (this.livingSkill == null) goto LAB_1807f1f03;
          fVar7 = (float)FUN_1800d6780(this.livingSkill,uVar3,DAT_181d796d8);
          if (*(int64 *)(targetHero + 0x168) == 0) goto LAB_1807f1f03;
          fVar8 = (float)FUN_1800d6780(*(int64 *)(targetHero + 0x168),uVar3,DAT_181d796d8);
          if (this.livingSkill == null) goto LAB_1807f1f03;
          fVar9 = (float)FUN_1800d6780(this.livingSkill,uVar3);
          if (fVar8 <= fVar9) {
            fVar8 = 0.1;
          }
          else {
            fVar8 = 0.0;
          }
          fVar11 = fVar11 + (fVar6 - fVar7) * fVar8;
        }
        lVar1 = this.livingSkill;
        uVar3 = uVar3 + 1;
        lVar4 = lVar4 + 4;
        if (lVar1 == null) goto LAB_1807f1f03;
        goto LAB_1807f1ab5;
    }

    // Token : 0x600121A
    // RVA   : 0x7F0CB0   Offset: 0x7EF4B0   Length: 0x175
    public virtual object Clone()
    {
        long lVar2;
        ulong uVar3;
        ulong local_38;
        ulong uStack_30;
        uint local_28;
        uint uStack_24;
        uint uStack_20;
        uint32 uStack_1c;
        plVar1 = (int64 *)il2cpp_internal(DAT_181d63ff0);
        plVar4 = plVar1;
        MemoryStream.ctor(plVar1,1000,0);
        local_38 = 0;
        uStack_30 = 0;
        StreamingContext.ctor(&local_38,64,0);
        lVar2 = il2cpp_internal(DAT_181d8c5a8);
        local_28 = (uint32)local_38;
        uStack_24 = local_38._4_4_;
        uStack_20 = (uint32)uStack_30;
        uStack_1c = uStack_30._4_4_;
        BinaryFormatter.ctor(lVar2,0,&local_28,0,plVar4);
        if (lVar2 != null) {
          BinaryFormatter.Serialize(lVar2,plVar1,this,0);
          if (plVar1 != (int64 *)0) {
            (**(code **)(*plVar1 + 0x2c8))(plVar1,0,0,*(uint64 *)(*plVar1 + 0x2d0));
            uVar3 = BinaryFormatter.Deserialize(lVar2,plVar1,0);
            (**(code **)(*plVar1 + 0x238))(plVar1,*(uint64 *)(*plVar1 + 0x240));
            FUN_180002970(0,DAT_181d53c70,plVar1);
            return uVar3;
          }
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
    }

}
