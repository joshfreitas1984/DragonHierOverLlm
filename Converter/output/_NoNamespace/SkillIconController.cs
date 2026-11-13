// ============================================================
// Type  : SkillIconController
// Token : 0x200036B
// ============================================================

public class SkillIconController
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001C2A
    public int skillListID;

    // Token: 0x4001C2B
    public KungfuSkillLvData skillLvData;

    // Token: 0x4001C2C
    public SkillIconType skillIconType;

    // Token: 0x4001C2D
    public bool inited;

    // Token: 0x4001C2E
    private float refreshTime;

    // Token: 0x4001C2F
    private static Color activeColor;

    // Token: 0x4001C30
    private static Color activeOutLineColor;

    // Token: 0x4001C31
    private static Color cdColor;

    // Token: 0x4001C32
    private static Color cdOutLineColor;

    // Token: 0x4001C33
    private Text nameText;

    // Token: 0x4001C34
    private Outline nameOutline;

    // Token: 0x4001C35
    private Image skillLvBackImage;

    // Token: 0x4001C36
    private Image iconImage;

    // Token: 0x4001C37
    private GameObject forceObj;

    // Token: 0x4001C38
    private Image forceImage;

    // Token: 0x4001C39
    private GameObject newIconObj;

    // Token: 0x4001C3A
    private Text skillLvText;

    // Token: 0x4001C3B
    private GameObject lockObj;

    // Token: 0x4001C3C
    private Image lockIconImage;

    // Token: 0x4001C3D
    private SimpleDetailText lockDetailText;

    // Token: 0x4001C3E
    private GameObject expBackObj;

    // Token: 0x4001C3F
    private GameObject expFullObj;

    // Token: 0x4001C40
    private Image bookExpImage;

    // Token: 0x4001C41
    private Image fightExpImage;

    // Token: 0x4001C42
    private Image cdCoverImage;

    // Token: 0x4001C43
    private Text cdTimeText;

    // Token: 0x4001C44
    private Outline cdTimeOutline;

    // Token: 0x4001C45
    private Image powerBarImage;

    // Token: 0x4001C46
    private bool refsReady;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60021D1
    // RVA   : 0x6AD5C0   Offset: 0x6AC3C0   Length: 0x33F
    private void EnsureBaseRefs()
    {
        bool cVar1;
        long lVar2;
        long lVar3;
        ulong uVar4;
        long lVar5;
        if (this.refsReady) {
          uVar4 = this.newIconObj;
          cVar1 = Object.op_Inequality(uVar4,0,0);
          if (cVar1) {
            return;
          }
        }
        this.refsReady = 1;
        lVar2 = Component.get_transform(this,0);
        if ((lVar2 != null) && (lVar3 = Transform.Find(lVar2,"Name",0)) != null) {
          uVar4 = Component.GetComponent(lVar3,DAT_181e79538);
          this.nameText = uVar4;
          uVar4 = Component.GetComponent(lVar3,DAT_181e77e38);
          this.nameOutline = uVar4;
          lVar3 = Transform.Find(lVar2,"SkillLvBack",0);
          if (lVar3 != null) {
            uVar4 = Component.GetComponent(lVar3,DAT_181e777b8);
            this.skillLvBackImage = uVar4;
            lVar5 = Transform.Find(lVar3,"SkillLv",0);
            if (lVar5 != null) {
              uVar4 = Component.GetComponent(lVar5,DAT_181e79538);
              this.skillLvText = uVar4;
              lVar3 = Transform.Find(lVar3,"Lock",0);
              if (lVar3 != null) {
                uVar4 = Component.get_gameObject(lVar3,0);
                this.lockObj = uVar4;
                lVar3 = Transform.Find(lVar2,"Icon",0);
                if (lVar3 != null) {
                  uVar4 = Component.GetComponent(lVar3,DAT_181e777b8);
                  this.iconImage = uVar4;
                  lVar3 = Transform.Find(lVar2,"Force",0);
                  if (lVar3 != null) {
                    uVar4 = Component.get_gameObject(lVar3,0);
                    this.forceObj = uVar4;
                    lVar3 = Transform.Find(lVar2,"New",0);
                    if (lVar3 != null) {
                      uVar4 = Component.get_gameObject(lVar3,0);
                      this.newIconObj = uVar4;
                      lVar3 = Transform.Find(lVar2,"ExpBack",0);
                      if (lVar3 != null) {
                        uVar4 = Component.get_gameObject(lVar3,0);
                        this.expBackObj = uVar4;
                        lVar2 = Transform.Find(lVar2,"ExpFull",0);
                        if (lVar2 != null) {
                          uVar4 = Component.get_gameObject(lVar2,0);
                          this.expFullObj = uVar4;
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

    // Token : 0x60021D2
    // RVA   : 0x6AD900   Offset: 0x6AC700   Length: 0x137
    private void EnsureCdRefs()
    {
        bool cVar1;
        long lVar2;
        ulong uVar3;
        uVar3 = this.cdCoverImage;
        cVar1 = Object.op_Inequality(uVar3,0,0);
        if (cVar1) {
          return;
        }
        lVar2 = Component.get_transform(this,0);
        if ((lVar2 != null) && (lVar2 = Transform.Find(lVar2,"CdCover",0)) != null) {
          uVar3 = Component.GetComponent(lVar2,DAT_181e777b8);
          this.cdCoverImage = uVar3;
          lVar2 = Transform.Find(lVar2,"CdTime",0);
          if (lVar2 != null) {
            uVar3 = Component.GetComponent(lVar2,DAT_181e79538);
            this.cdTimeText = uVar3;
            return;
          }
        }
    }

    // Token : 0x60021D3
    // RVA   : 0x6AE230   Offset: 0x6AD030   Length: 0xE0B
    private void Update()
    {
        var pStatics_35a8 = *(int64*)(DAT_181e835a8 + 184);
        var pStatics_38e8 = *(int64*)(DAT_181e538e8 + 184);
        uint uVar1;
        bool cVar3;
        ulong uVar4;
        long lVar5;
        ulong uVar6;
        long lVar7;
        long lVar8;
        float fVar11;
        uint uVar12;
        uint uVar13;
        uint uVar14;
        uint uVar15;
        float fVar16;
        uint local_38;
        uint uStack_34;
        uint uStack_30;
        uint32 uStack_2c;
        if (!this.inited) {
          this.inited = 1;
          SkillIconController.EnsureBaseRefs(this,0);
          uVar6 = this.nameText;
          if (this.skillLvData == null) throw; // [null/range check failed]
          uVar4 = KungfuSkillLvData.Name(this.skillLvData,0,0);
          LTLocalization.SetText(uVar6,uVar4,0);
          if (this.skillIconType == 3) {
            plVar2 = this.nameText;
            puVar9 = (uint32 *)FUN_180f24d00(&local_38,0);
            if (plVar2 == (int64 *)0) throw; // [null/range check failed]
            local_38 = *puVar9;
            uStack_34 = puVar9[1];
            uStack_30 = puVar9[2];
            uStack_2c = puVar9[3];
            (**(code **)(*plVar2 + 0x2a8))(plVar2,&local_38,*(uint64 *)(*plVar2 + 0x2b0));
            lVar7 = this.nameOutline;
            puVar9 = (uint32 *)Color.get_black(&local_38,0);
            if (lVar7 == null) throw; // [null/range check failed]
            uVar12 = *puVar9;
            uVar13 = puVar9[1];
            uVar14 = puVar9[2];
            uVar15 = puVar9[3];
          }
          else {
            lVar7 = this.nameOutline;
            if (this.skillIconType == 4) {
        LAB_1806ae3eb:
              puVar9 = (uint32 *)FUN_180f24d00(&local_38,0);
              uVar12 = *puVar9;
              uVar13 = puVar9[1];
              uVar14 = puVar9[2];
              uVar15 = puVar9[3];
            }
            else {
              if (this.skillLvData == null) throw; // [null/range check failed]
              if (!this.skillLvData.equiped) goto LAB_1806ae3eb;
              lVar5 = pStatics_38e8;
              uVar12 = *(uint32 *)(lVar5 + 0x380);
              uVar13 = *(uint32 *)(lVar5 + 900);
              uVar14 = *(uint32 *)(lVar5 + 0x388);
              uVar15 = *(uint32 *)(lVar5 + 0x38c);
            }
            if (lVar7 == null) throw; // [null/range check failed]
          }
          uStack_2c = uVar15;
          uStack_30 = uVar14;
          uStack_34 = uVar13;
          local_38 = uVar12;
          Shadow.set_effectColor(lVar7,&local_38,0);
          plVar2 = this.skillLvBackImage;
          lVar7 = *(int64 *)(*(int64 *)(DAT_181e528f8 + 184) + 32);
          if (lVar7 == null) throw; // [null/range check failed]
          lVar7 = lVar7.speUseData;
          if (((this.skillLvData == null) ||
              (lVar5 = KungfuSkillLvData.DataBase(this.skillLvData,0)) == null) ||
             (lVar7 == null)) throw; // [null/range check failed]
          uVar1 = *(uint32 *)(lVar5 + 52);
          if (lVar7.fightExp <= uVar1) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          lVar7 = lVar7.skillID[uVar1];
          if ((lVar7 == null) || (plVar2 == (int64 *)0)) throw; // [null/range check failed]
          local_38 = lVar7.fightExp;
          uStack_34 = lVar7.bookExp;
          uStack_30 = lVar7.equiped;
          uStack_2c = lVar7.belongHeroID;
          (**(code **)(*plVar2 + 0x2a8))(plVar2,&local_38,*(uint64 *)(*plVar2 + 0x2b0));
          lVar7 = this.iconImage;
          lVar5 = **(int64 **)(DAT_181e8b8e8 + 184);
          if (((this.skillLvData == null) ||
              (uVar6 = KungfuSkillLvData.GetSkillIcon(this.skillLvData,0), lVar5 == null)) ||
             (uVar6 = TextureController.LoadAtlasSprite(lVar5,"IconAtlas",uVar6,0), lVar7 == null))
          throw; // [null/range check failed]
          Image.set_sprite(lVar7,uVar6,0);
          if ((this.skillLvData == null) ||
             (lVar7 = KungfuSkillLvData.DataBase(this.skillLvData,0)) == null)
          throw; // [null/range check failed]
          cVar3 = KungfuSkillData.HaveForce(lVar7,0);
          lVar7 = this.forceObj;
          if (!cVar3) {
            if (lVar7 == null) throw; // [null/range check failed]
            GameObject.SetActive(lVar7,0,0);
          }
          else {
            if (lVar7 == null) throw; // [null/range check failed]
            GameObject.SetActive(lVar7,1,0);
            uVar6 = this.forceImage;
            cVar3 = Object.op_Equality(uVar6,0,0);
            if (cVar3) {
              if (this.forceObj == null) throw; // [null/range check failed]
              uVar6 = GameObject.GetComponent(this.forceObj,DAT_181e54f48);
              this.forceImage = uVar6;
            }
            lVar7 = this.forceImage;
            lVar5 = FUN_1802106e0(0);
            if (lVar5 == null) throw; // [null/range check failed]
            lVar5 = *(int64 *)(lVar5 + 32);
            if (((((this.skillLvData == null) ||
                  (lVar8 = KungfuSkillLvData.DataBase(this.skillLvData,0)) == null) ||
                 (lVar5 == null)) ||
                ((lVar5 = WorldData.GetForce(lVar5,*(uint32 *)(lVar8 + 24),0), lVar5 == null ||
                 (lVar5 = ForceData.DataBase(lVar5,0)) == null))) ||
               (uVar6 = ForceData.GetForceIcon(lVar5,0), lVar7 == null)) throw; // [null/range check failed]
            Image.set_sprite(lVar7,uVar6,0);
          }
          SkillIconController.RefreshSkillLvAndExp(this,0);
        }
        uVar6 = *(uint64 *)(*(int64 *)(DAT_181e6bb68 + 184) + 72);
        uVar4 = Component.get_gameObject(this,0);
        cVar3 = Object.op_Equality(uVar6,uVar4,0);
        if (cVar3) {
          if (this.skillLvData == null) throw; // [null/range check failed]
          this.skillLvData.isNew = 0;
        }
        if (this.newIconObj == null) throw; // [null/range check failed]
        cVar3 = GameObject.get_activeSelf(this.newIconObj,0);
        lVar7 = this.skillLvData;
        if (lVar7 == null) throw; // [null/range check failed]
        if (cVar3 != lVar7.isNew) {
          if (this.newIconObj == null) throw; // [null/range check failed]
          GameObject.SetActive(this.newIconObj,lVar7.isNew,0);
          lVar7 = this.skillLvData;
          if (lVar7 == null) throw; // [null/range check failed]
        }
        if (lVar7.skillIconDirty) {
          SkillIconController.RefreshSkillLvAndExp(this,0);
        }
        if ((this.skillIconType - 1U & 0xfffffffd) != 0) {
          return;
        }
        fVar16 = this.refreshTime;
        fVar11 = (float)Time.get_deltaTime(0);
        fVar16 = fVar16 - fVar11;
        this.refreshTime = fVar16;
        if (0.0 < fVar16) {
          return;
        }
        bVar10 = !DAT_181eb6ce0;
        this.refreshTime = 0x3dcccccd;
        if (bVar10) {
          il2cpp_runtime_class_init(&DAT_181e777b8);
          il2cpp_runtime_class_init(&DAT_181e79538);
          il2cpp_runtime_class_init(&DAT_181e6e5e8);
          il2cpp_internal(&"CdCover");
          il2cpp_internal(&"CdTime");
          DAT_181eb6ce0 = true;
        }
        lVar7 = this.cdCoverImage;
        cVar3 = Object.op_Inequality(lVar7,0,0);
        if (!cVar3) {
          lVar7 = Component.get_transform(this,0);
          if ((lVar7 == null) || (lVar7 = Transform.Find(lVar7,"CdCover",0)) == null)
          throw; // [null/range check failed]
          lVar5 = Component.GetComponent(lVar7,DAT_181e777b8);
          *plVar2 = lVar5;
          il2cpp_internal(plVar2,lVar5);
          lVar7 = Transform.Find(lVar7,"CdTime",0);
          if (lVar7 == null) throw; // [null/range check failed]
          uVar6 = Component.GetComponent(lVar7,DAT_181e79538);
          this.cdTimeText = uVar6;
        }
        lVar7 = this.skillLvData;
        if (lVar7 == null) throw; // [null/range check failed]
        if (0.0 < lVar7.activeTimeLeft) {
          uVar6 = this.cdTimeText;
          uVar4 = Single.ToString(lVar7 + 96,"f0",0);
          LTLocalization.SetText(uVar6,uVar4,0);
          plVar2 = (int64 *)*plVar2;
          puVar9 = *(uint32 **)(DAT_181e835a8 + 184);
          if (plVar2 == (int64 *)0) throw; // [null/range check failed]
          local_38 = *puVar9;
          uStack_34 = puVar9[1];
          uStack_30 = puVar9[2];
          uStack_2c = puVar9[3];
          (**(code **)(*plVar2 + 0x2a8))(plVar2,&local_38,*(uint64 *)(*plVar2 + 0x2b0));
          plVar2 = this.cdTimeText;
          lVar7 = pStatics_38e8;
          if (plVar2 == (int64 *)0) throw; // [null/range check failed]
          local_38 = *(uint32 *)(lVar7 + 0x290);
          uStack_34 = *(uint32 *)(lVar7 + 0x294);
          uStack_30 = *(uint32 *)(lVar7 + 0x298);
          uStack_2c = *(uint32 *)(lVar7 + 0x29c);
          (**(code **)(*plVar2 + 0x2a8))(plVar2,&local_38,*(uint64 *)(*plVar2 + 0x2b0));
          uVar6 = this.cdTimeOutline;
          cVar3 = Object.op_Equality(uVar6,0,0);
          if (cVar3) {
            if (this.cdTimeText == null) throw; // [null/range check failed]
            uVar6 = Component.GetComponent(this.cdTimeText,DAT_181e77e38);
            this.cdTimeOutline = uVar6;
          }
          lVar7 = this.cdTimeOutline;
          lVar5 = pStatics_35a8;
          if (lVar7 == null) throw; // [null/range check failed]
          local_38 = *(uint32 *)(lVar5 + 16);
          uStack_34 = *(uint32 *)(lVar5 + 20);
          uStack_30 = *(uint32 *)(lVar5 + 24);
          uStack_2c = *(uint32 *)(lVar5 + 28);
        LAB_1806aee44:
          Shadow.set_effectColor(lVar7,&local_38,0);
        }
        else {
          lVar7 = FUN_1802101c0(0);
          if (lVar7 == null) throw; // [null/range check failed]
          uVar6 = *(uint64 *)(lVar7 + 0x110);
          cVar3 = Object.op_Inequality(uVar6,0,0);
          if (cVar3) {
            lVar7 = FUN_1802101c0(0);
            if (((lVar7 == null) || (*(int64 *)(lVar7 + 0x110) == 0)) ||
               (lVar7 = *(int64 *)(*(int64 *)(lVar7 + 0x110) + 64)) == null)
            throw; // [null/range check failed]
            cVar3 = HeroData.CanUseSkill(lVar7,this.skillLvData,0);
            if (!cVar3) {
              lVar7 = this.skillLvData;
              uVar6 = this.cdTimeText;
              if (lVar7 == null) throw; // [null/range check failed]
              uVar4 = "";
              if (0.0 < lVar7.cdTimeLeft) {
                uVar4 = Single.ToString(lVar7 + 88,"f0",0);
              }
              LTLocalization.SetText(uVar6,uVar4,0);
              plVar2 = (int64 *)*plVar2;
              lVar7 = pStatics_35a8;
              if (plVar2 == (int64 *)0) throw; // [null/range check failed]
              local_38 = lVar7.equiped;
              uStack_34 = lVar7.belongHeroID;
              uStack_30 = lVar7.speEquipData;
              uStack_2c = *(uint32 *)(lVar7 + 44);
              (**(code **)(*plVar2 + 0x2a8))(plVar2,&local_38,*(uint64 *)(*plVar2 + 0x2b0));
              plVar2 = this.cdTimeText;
              lVar7 = pStatics_38e8;
              if (plVar2 == (int64 *)0) throw; // [null/range check failed]
              local_38 = *(uint32 *)(lVar7 + 0x2f8);
              uStack_34 = *(uint32 *)(lVar7 + 0x2fc);
              uStack_30 = *(uint32 *)(lVar7 + 0x300);
              uStack_2c = *(uint32 *)(lVar7 + 0x304);
              (**(code **)(*plVar2 + 0x2a8))(plVar2,&local_38,*(uint64 *)(*plVar2 + 0x2b0));
              uVar6 = this.cdTimeOutline;
              cVar3 = Object.op_Equality(uVar6,0,0);
              if (cVar3) {
                if (this.cdTimeText == null) throw; // [null/range check failed]
                uVar6 = Component.GetComponent(this.cdTimeText,DAT_181e77e38);
                this.cdTimeOutline = uVar6;
              }
              lVar7 = this.cdTimeOutline;
              lVar5 = pStatics_35a8;
              if (lVar7 == null) throw; // [null/range check failed]
              local_38 = *(uint32 *)(lVar5 + 48);
              uStack_34 = *(uint32 *)(lVar5 + 52);
              uStack_30 = *(uint32 *)(lVar5 + 56);
              uStack_2c = *(uint32 *)(lVar5 + 60);
              goto LAB_1806aee44;
            }
          }
          plVar2 = (int64 *)*plVar2;
          puVar9 = (uint32 *)FUN_180af4e90(&local_38,0);
          if (plVar2 == (int64 *)0) throw; // [null/range check failed]
          local_38 = *puVar9;
          uStack_34 = puVar9[1];
          uStack_30 = puVar9[2];
          uStack_2c = puVar9[3];
          (**(code **)(*plVar2 + 0x2a8))(plVar2,&local_38,*(uint64 *)(*plVar2 + 0x2b0));
          uVar6 = this.cdTimeText;
          LTLocalization.SetText(uVar6,"",0);
        }
        if ((this.skillLvData != null) &&
           (lVar7 = KungfuSkillLvData.DataBase(this.skillLvData,0)) != null) {
          if (2 < lVar7.equipUseSpeAddValue) {
            return;
          }
          uVar6 = *(uint64 *)(this + 200);
          cVar3 = Object.op_Equality(uVar6,0,0);
          if (cVar3) {
            lVar7 = Component.get_transform(this,0);
            if ((lVar7 == null) || (lVar7 = Transform.Find(lVar7,"PowerBar",0)) == null)
            throw; // [null/range check failed]
            uVar6 = Component.GetComponent(lVar7,DAT_181e777b8);
            *(uint64 *)(this + 200) = uVar6;
          }
          lVar7 = this.skillLvData;
          if (lVar7 != null) {
            lVar5 = *(int64 *)(this + 200);
            if (0.0 < lVar7.activeTimeLeft) {
              if (lVar5 != null) {
                Image.set_fillAmount(lVar5,0,0);
                return;
              }
            }
            else {
              fVar16 = lVar7.power;
              fVar11 = (float)KungfuSkillLvData.MaxPower(lVar7,0);
              if (lVar5 != null) {
                Image.set_fillAmount(lVar5,fVar16 / fVar11,0);
                lVar7 = this.skillLvData;
                plVar2 = *(int64 **)(this + 200);
                if (lVar7 != null) {
                  fVar16 = lVar7.power;
                  fVar11 = (float)KungfuSkillLvData.MaxPower(lVar7,0);
                  if (fVar16 < fVar11) {
                    lVar7 = pStatics_38e8;
                    uVar12 = *(uint32 *)(lVar7 + 0x360);
                    uVar13 = *(uint32 *)(lVar7 + 0x364);
                    uVar14 = *(uint32 *)(lVar7 + 0x368);
                    uVar15 = *(uint32 *)(lVar7 + 0x36c);
                  }
                  else {
                    lVar7 = pStatics_38e8;
                    uVar12 = *(uint32 *)(lVar7 + 0x350);
                    uVar13 = *(uint32 *)(lVar7 + 0x354);
                    uVar14 = *(uint32 *)(lVar7 + 0x358);
                    uVar15 = *(uint32 *)(lVar7 + 0x35c);
                  }
                  if (plVar2 != (int64 *)0) {
                    local_38 = uVar12;
                    uStack_34 = uVar13;
                    uStack_30 = uVar14;
                    uStack_2c = uVar15;
                    (**(code **)(*plVar2 + 0x2a8))(plVar2,&local_38,*(uint64 *)(*plVar2 + 0x2b0));
                    return;
                  }
                }
              }
            }
          }
        }
    }

    // Token : 0x60021D4
    // RVA   : 0x6ADC10   Offset: 0x6ACA10   Length: 0x61C
    public void RefreshSkillLvAndExp()
    {
        float fVar1;
        uint uVar2;
        bool cVar3;
        bool cVar4;
        byte uVar5;
        ulong uVar7;
        long lVar9;
        long lVar10;
        ulong uVar11;
        float fVar12;
        uint local_28;
        uint uStack_24;
        uint uStack_20;
        uint32 uStack_1c;
        if (this.skillLvData != null) {
          this.skillLvData.skillIconDirty = 0;
          SkillIconController.EnsureBaseRefs(this,0);
          uVar11 = this.skillLvText;
          if (this.skillLvData != null) {
            uVar2 = this.skillLvData.lv;
            plVar6 = (int64 *)GlobalData.GetNumText(uVar2,0);
            if (plVar6 != (int64 *)0) {
              uVar7 = (**(code **)(*plVar6 + 0x168))(plVar6,*(uint64 *)(*plVar6 + 0x170));
              LTLocalization.SetText(uVar11,uVar7,0);
              if (this.skillLvData != null) {
                lVar9 = this.lockObj;
                if (this.skillLvData.belongHeroID == null) {
                  if (lVar9 == null) throw; // [null/range check failed]
                  cVar3 = GameObject.get_activeSelf(lVar9,0);
                  if (this.skillLvData == null) throw; // [null/range check failed]
                  cVar4 = KungfuSkillLvData.SkillMeetObstacleLv(this.skillLvData,0);
                  if (cVar3 != cVar4) {
                    lVar9 = this.lockObj;
                    if ((this.skillLvData == null) ||
                       (uVar5 = KungfuSkillLvData.SkillMeetObstacleLv(this.skillLvData,0),
                       lVar9 == null)) throw; // [null/range check failed]
                    GameObject.SetActive(lVar9,uVar5,0);
                  }
                  if (this.skillLvData == null) throw; // [null/range check failed]
                  cVar3 = KungfuSkillLvData.SkillMeetObstacleLv(this.skillLvData,0);
                  if (cVar3) {
                    if (this.skillLvData == null) throw; // [null/range check failed]
                    cVar3 = KungfuSkillLvData.BookExpFull(this.skillLvData,0);
                    if (!cVar3) {
                      cVar3 = false;
                    }
                    else {
                      if (this.skillLvData == null) throw; // [null/range check failed]
                      cVar3 = KungfuSkillLvData.FightExpFull(this.skillLvData,0);
                    }
                    uVar11 = this.lockIconImage;
                    cVar4 = Object.op_Equality(uVar11,0,0);
                    if (cVar4) {
                      lVar9 = Component.get_transform(this,0);
                      if ((((lVar9 == null) || (lVar9 = Transform.Find(lVar9,"SkillLvBack",0)) == null)
                          || (lVar9 = Transform.Find(lVar9,"Lock",0)) == null) ||
                         (lVar10 = Transform.Find(lVar9,"Icon",0)) == null)
                      throw; // [null/range check failed]
                      uVar11 = Component.GetComponent(lVar10,DAT_181e777b8);
                      this.lockIconImage = uVar11;
                      uVar11 = Component.GetComponent(lVar9,DAT_181e788b8);
                      this.lockDetailText = uVar11;
                    }
                    plVar6 = this.lockIconImage;
                    if (!cVar3) {
                      puVar8 = (uint32 *)Color.get_red(&local_28,0);
                    }
                    else {
                      puVar8 = (uint32 *)Color.get_green();
                    }
                    if (plVar6 == (int64 *)0) throw; // [null/range check failed]
                    local_28 = *puVar8;
                    uStack_24 = puVar8[1];
                    uStack_20 = puVar8[2];
                    uStack_1c = puVar8[3];
                    (**(code **)(*plVar6 + 0x2a8))(plVar6,&local_28,*(uint64 *)(*plVar6 + 0x2b0));
                    uVar11 = "<color=red>经验未满\n无法突破</color>";
                    if (cVar3) {
                      uVar11 = "<color=green>经验已满\n在闭关室突破</color>";
                    }
                    if (this.lockDetailText == null) throw; // [null/range check failed]
                    this.lockDetailText.text = uVar11;
                  }
                }
                else {
                  if (lVar9 == null) throw; // [null/range check failed]
                  cVar3 = GameObject.get_activeSelf(lVar9,0);
                  if (cVar3) {
                    if (this.lockObj == null) throw; // [null/range check failed]
                    GameObject.SetActive(this.lockObj,0,0);
                  }
                }
                if (this.skillLvData != null) {
                  lVar9 = this.expBackObj;
                  if (this.skillLvData.lv < 10) {
                    if (lVar9 != null) {
                      cVar3 = GameObject.get_activeSelf(lVar9,0);
                      if (!cVar3) {
                        if (this.expBackObj == null) throw; // [null/range check failed]
                        GameObject.SetActive(this.expBackObj,1,0);
                      }
                      if (this.expFullObj != null) {
                        cVar3 = GameObject.get_activeSelf(this.expFullObj,0);
                        if (cVar3) {
                          if (this.expFullObj == null) throw; // [null/range check failed]
                          GameObject.SetActive(this.expFullObj,0,0);
                        }
                        uVar11 = this.bookExpImage;
                        cVar3 = Object.op_Equality(uVar11,0,0);
                        if (cVar3) {
                          lVar9 = Component.get_transform(this,0);
                          if (((lVar9 == null) ||
                              (lVar9 = Transform.Find(lVar9,"ExpBack",0)) == null) ||
                             (lVar10 = Transform.Find(lVar9,"BookExp",0)) == null)
                          throw; // [null/range check failed]
                          uVar11 = Component.GetComponent(lVar10,DAT_181e777b8);
                          this.bookExpImage = uVar11;
                          lVar9 = Transform.Find(lVar9,"FightExp",0);
                          if (lVar9 == null) throw; // [null/range check failed]
                          uVar11 = Component.GetComponent(lVar9,DAT_181e777b8);
                          this.fightExpImage = uVar11;
                        }
                        lVar9 = this.skillLvData;
                        lVar10 = this.bookExpImage;
                        if (lVar9 != null) {
                          fVar1 = lVar9.bookExp;
                          fVar12 = (float)KungfuSkillLvData.SkillGetMaxExp(lVar9,0,0);
                          if (lVar10 != null) {
                            Image.set_fillAmount(lVar10,fVar1 / fVar12,0);
                            lVar9 = this.skillLvData;
                            lVar10 = this.fightExpImage;
                            if (lVar9 != null) {
                              fVar1 = lVar9.fightExp;
                              fVar12 = (float)KungfuSkillLvData.SkillGetMaxExp(lVar9,1);
                              if (lVar10 != null) {
                                Image.set_fillAmount(lVar10,fVar1 / fVar12,0);
                                return;
                              }
                            }
                          }
                        }
                      }
                    }
                  }
                  else if (lVar9 != null) {
                    cVar3 = GameObject.get_activeSelf(lVar9,0);
                    if (cVar3) {
                      if (this.expBackObj == null) throw; // [null/range check failed]
                      GameObject.SetActive(this.expBackObj,0,0);
                    }
                    if (this.expFullObj != null) {
                      cVar3 = GameObject.get_activeSelf(this.expFullObj,0);
                      if (!cVar3) {
                        if (this.expFullObj == null) throw; // [null/range check failed]
                        GameObject.SetActive(this.expFullObj,1,0);
                      }
                      return;
                    }
                  }
                }
              }
            }
          }
        }
    }

    // Token : 0x60021D5
    // RVA   : 0x6AD260   Offset: 0x6AC060   Length: 0x33C
    public void AutoSetName(SkillSortType sortType, bool reverseOrder)
    {
        long lVar1;
        ulong uVar2;
        ulong uVar3;
        ulong uVar4;
        int[] local_res8 = new int[2];
        float[] local_28 = new float[4];
        local_28[0] = 0.0;
        if ((this.skillLvData == null) ||
           (lVar1 = KungfuSkillLvData.DataBase(this.skillLvData,0)) == null) {
        LAB_1806ad595:
                          // WARNING: Subroutine does not return
          FUN_1801e0300();
        }
        uVar2 = Int32.ToString(lVar1 + 52,"",0);
        if ((this.skillLvData == null) ||
           (lVar1 = KungfuSkillLvData.DataBase(this.skillLvData,0)) == null)
        goto LAB_1806ad595;
        local_res8[0] = lVar1.fightExp + 1;
        uVar3 = Int32.ToString(local_res8,"00",0);
        if (this.skillLvData == null) goto LAB_1806ad595;
        uVar4 = Int32.ToString(this.skillLvData + 16,"00000",0);
        uVar2 = String.Concat(uVar2,uVar3,uVar4,0);
        Object.set_name(this,uVar2,0);
        switch(sortType) {
        case 0:
          piVar5 = &this.skillListID;
          uVar2 = "0000";
          if (reverseOrder) {
            local_res8[0] = 9999 - *piVar5;
            piVar5 = local_res8;
          }
          break;
        case 1:
          lVar1 = this.skillLvData;
          if (!reverseOrder) {
            if ((lVar1 == null) || (lVar1 = KungfuSkillLvData.DataBase(lVar1,0)) == null)
            goto LAB_1806ad595;
            uVar2 = Int32.ToString(lVar1 + 52,0);
          }
          else {
            if ((lVar1 == null) || (lVar1 = KungfuSkillLvData.DataBase(lVar1,0)) == null)
            goto LAB_1806ad595;
            local_res8[0] = 9 - *(int *)(lVar1 + 52);
            uVar2 = Int32.ToString(local_res8,0);
          }
          goto LAB_1806ad3c2;
        case 2:
          lVar1 = this.skillLvData;
          uVar2 = "00";
          if (!reverseOrder) {
            if (lVar1 == null) goto LAB_1806ad595;
            piVar5 = &lVar1.lv;
          }
          else {
            if (lVar1 == null) goto LAB_1806ad595;
            local_res8[0] = 10 - lVar1.lv;
            piVar5 = local_res8;
          }
          break;
        case 3:
          lVar1 = this.skillLvData;
          if (!reverseOrder) {
            if ((lVar1 == null) || (lVar1 = KungfuSkillLvData.DataBase(lVar1,0)) == null)
            goto LAB_1806ad595;
            piVar5 = &lVar1.fightExp;
            uVar2 = "00";
          }
          else {
            if ((lVar1 == null) || (lVar1 = KungfuSkillLvData.DataBase(lVar1,0)) == null)
            goto LAB_1806ad595;
            local_res8[0] = 99 - lVar1.fightExp;
            piVar5 = local_res8;
            uVar2 = "00";
          }
          break;
        case 4:
          lVar1 = this.skillLvData;
          if (!reverseOrder) {
            if (lVar1 == null) goto LAB_1806ad595;
            local_28[0] = (float)KungfuSkillLvData.GetBaseDamage(lVar1,0);
          }
          else {
            if (lVar1 == null) goto LAB_1806ad595;
            local_28[0] = (float)KungfuSkillLvData.GetBaseDamage(lVar1,0);
        LAB_1806ad532:
            local_28[0] = 99.0 - local_28[0];
          }
          goto LAB_1806ad558;
        case 5:
          lVar1 = this.skillLvData;
          if (reverseOrder) {
            if (lVar1 == null) goto LAB_1806ad595;
            local_28[0] = (float)KungfuSkillLvData.GetManaCost(lVar1,0);
            goto LAB_1806ad532;
          }
          if (lVar1 == null) goto LAB_1806ad595;
          local_28[0] = (float)KungfuSkillLvData.GetManaCost(lVar1,0);
        LAB_1806ad558:
          uVar2 = Single.ToString(local_28,"00.0",0);
          goto LAB_1806ad3c2;
        default:
          goto switchD_1806ad396_default;
        }
        uVar2 = Int32.ToString(piVar5,uVar2,0);
        LAB_1806ad3c2:
        uVar3 = Object.get_name(this,0);
        uVar2 = String.Concat(uVar2,uVar3,0);
        Object.set_name(this,uVar2,0);
        switchD_1806ad396_default:
    }

    // Token : 0x60021D6
    // RVA   : 0x6ADA40   Offset: 0x6AC840   Length: 0x1CF
    public void OnClick()
    {
        var pStatics = *(int64*)(DAT_181e55ae8 + 184);
        int iVar1;
        long lVar2;
        ulong uVar3;
        long lVar4;
        ulong local_28;
        uint local_20;
        byte[] local_18 = new byte[16];
        iVar1 = this.skillIconType;
        if (iVar1 == 0) {
          if ((*pStatics != 0) &&
             (lVar2 = *(int64 *)(*pStatics + 96)) != null) {
            HeroData.EquipSkill(lVar2,this.skillLvData,1,0);
            return;
          }
        }
        else if (iVar1 == 1) {
          if ((*pStatics != 0) &&
             (lVar2 = *(int64 *)(*pStatics + 96)) != null) {
            HeroData.UnequipSkill(lVar2,this.skillLvData,1,0);
            return;
          }
        }
        else {
          if (iVar1 != 3) {
            if (iVar1 == 4) {
              lVar2 = FUN_1802103a0(0);
              uVar3 = Component.get_gameObject(this,0);
              if (lVar2 == null) throw; // [null/range check failed]
              ChooseController.ChooseObj(lVar2,uVar3,0);
            }
            return;
          }
          lVar2 = FUN_1802101c0(0);
          uVar3 = this.skillLvData;
          lVar4 = Component.get_transform(this,0);
          if (lVar4 != null) {
            puVar5 = (uint64 *)Transform.get_position(local_18,lVar4,0);
            if (lVar2 != null) {
              local_28 = *puVar5;
              local_20 = *(uint32 *)(puVar5 + 1);
              BattleController.ChangeActiveSkill(lVar2,uVar3,&local_28,0);
              return;
            }
          }
        }
    }

    // Token : 0x60021D7
    // RVA   : 0x2110A0   Offset: 0x20FEA0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_180ae8740(this,0);
    }

    // Token : 0x60021D8
    // RVA   : 0x6AF040   Offset: 0x6ADE40   Length: 0x139
    private static void /*cctor*/()
    {
        var pStatics = *(int64*)(DAT_181e835a8 + 184);
        long lVar2;
        ulong local_48;
        ulong uStack_40;
        ulong local_38;
        ulong uStack_30;
        ulong local_28;
        ulong uStack_20;
        ulong local_18;
        ulong uStack_10;
        local_48 = 0;
        uStack_40 = 0;
        FUN_1807282e0(&local_48,0,0x3f19999a,0,0x3f000000,0);
        puVar1 = *(uint64 **)(DAT_181e835a8 + 184);
        *puVar1 = local_48;
        puVar1[1] = uStack_40;
        local_38 = 0;
        uStack_30 = 0;
        FUN_1807282e0(&local_38,0,0,0,0x3f333333,0);
        lVar2 = pStatics;
        *(uint64 *)(lVar2 + 16) = local_38;
        *(uint64 *)(lVar2 + 24) = uStack_30;
        local_28 = 0;
        uStack_20 = 0;
        FUN_1807282e0(&local_28,0,0,0,0x3f400000,0);
        lVar2 = pStatics;
        *(uint32 *)(lVar2 + 32) = (uint32)local_28;
        *(uint32 *)(lVar2 + 36) = local_28._4_4_;
        *(uint32 *)(lVar2 + 40) = (uint32)uStack_20;
        *(uint32 *)(lVar2 + 44) = uStack_20._4_4_;
        local_18 = 0;
        uStack_10 = 0;
        FUN_1807282e0(&local_18,0x3f800000,0x3f800000,0x3f800000,0x3f800000,0);
        lVar2 = pStatics;
        *(uint64 *)(lVar2 + 48) = local_18;
        *(uint64 *)(lVar2 + 56) = uStack_10;
    }

}
