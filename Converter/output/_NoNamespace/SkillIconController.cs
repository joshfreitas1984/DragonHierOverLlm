// ============================================================
// Type  : SkillIconController
// Token : 0x2000357
// ============================================================

public class SkillIconController
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001AAA
    public int skillListID;

    // Token: 0x4001AAB
    public KungfuSkillLvData skillLvData;

    // Token: 0x4001AAC
    public SkillIconType skillIconType;

    // Token: 0x4001AAD
    public bool inited;

    // Token: 0x4001AAE
    private float refreshTime;

    // Token: 0x4001AAF
    private static Color activeColor;

    // Token: 0x4001AB0
    private static Color activeOutLineColor;

    // Token: 0x4001AB1
    private static Color cdColor;

    // Token: 0x4001AB2
    private static Color cdOutLineColor;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60020A8
    // RVA   : 0x973230   Offset: 0x971A30   Length: 0x10F9
    private void Update()
    {
        var pStatics_6270 = *(int64*)(DAT_181d86270 + 184);
        var pStatics_df30 = *(int64*)(DAT_181d7df30 + 184);
        var pStatics_ef00 = *(int64*)(DAT_181d4ef00 + 184);
        uint uVar1;
        bool cVar2;
        long lVar3;
        ulong uVar4;
        ulong uVar5;
        long lVar7;
        long lVar8;
        float fVar10;
        uint uVar11;
        uint uVar12;
        uint uVar13;
        uint uVar14;
        float fVar15;
        uint local_38;
        uint uStack_34;
        uint uStack_30;
        uint32 uStack_2c;
        if (!this.inited) {
          this.inited = 1;
          lVar3 = Component.get_transform(this,0);
          if ((lVar3 == null) || (lVar3 = Transform.Find(lVar3,"Name",0)) == null)
          throw; // [null/range check failed]
          uVar4 = Component.GetComponent(lVar3,DAT_181d6d8c0);
          if (this.skillLvData == null) throw; // [null/range check failed]
          uVar5 = KungfuSkillLvData.Name(this.skillLvData,0,0);
          LTLocalization.SetText(uVar4,uVar5,0);
          if (this.skillIconType == 3) {
            lVar3 = Component.get_transform(this,0);
            if ((lVar3 == null) || (lVar3 = Transform.Find(lVar3,"Name",0)) == null)
            throw; // [null/range check failed]
            plVar6 = (int64 *)Component.GetComponent(lVar3,DAT_181d6d8c0);
            puVar9 = (uint32 *)FUN_181098a50(&local_38,0);
            if (plVar6 == (int64 *)0) throw; // [null/range check failed]
            local_38 = *puVar9;
            uStack_34 = puVar9[1];
            uStack_30 = puVar9[2];
            uStack_2c = puVar9[3];
            (**(code **)(*plVar6 + 0x2a8))(plVar6,&local_38,*(uint64 *)(*plVar6 + 0x2b0));
            lVar3 = Component.get_transform(this,0);
            if ((lVar3 == null) || (lVar3 = Transform.Find(lVar3,"Name",0)) == null)
            throw; // [null/range check failed]
            lVar3 = Component.GetComponent(lVar3,DAT_181d6c2c0);
            puVar9 = (uint32 *)Color.get_black(&local_38,0);
            if (lVar3 == null) throw; // [null/range check failed]
            uVar11 = *puVar9;
            uVar12 = puVar9[1];
            uVar13 = puVar9[2];
            uVar14 = puVar9[3];
          }
          else {
            lVar3 = Component.get_transform(this,0);
            if ((lVar3 == null) || (lVar3 = Transform.Find(lVar3,"Name",0)) == null)
            throw; // [null/range check failed]
            lVar3 = Component.GetComponent(lVar3,DAT_181d6c2c0);
            if (this.skillIconType == 4) {
        LAB_180973483:
              puVar9 = (uint32 *)FUN_181098a50(&local_38,0);
              uVar11 = *puVar9;
              uVar12 = puVar9[1];
              uVar13 = puVar9[2];
              uVar14 = puVar9[3];
            }
            else {
              if (this.skillLvData == null) throw; // [null/range check failed]
              if (!this.skillLvData.equiped) goto LAB_180973483;
              lVar7 = pStatics_ef00;
              uVar11 = *(uint32 *)(lVar7 + 0x370);
              uVar12 = *(uint32 *)(lVar7 + 0x374);
              uVar13 = *(uint32 *)(lVar7 + 0x378);
              uVar14 = *(uint32 *)(lVar7 + 0x37c);
            }
            if (lVar3 == null) throw; // [null/range check failed]
          }
          uStack_2c = uVar14;
          uStack_30 = uVar13;
          uStack_34 = uVar12;
          local_38 = uVar11;
          Shadow.set_effectColor(lVar3,&local_38,0);
          lVar3 = Component.get_transform(this,0);
          if ((lVar3 == null) || (lVar3 = Transform.Find(lVar3,"SkillLvBack",0)) == null)
          throw; // [null/range check failed]
          plVar6 = (int64 *)Component.GetComponent(lVar3,DAT_181d6bc40);
          lVar3 = *(int64 *)(*(int64 *)(DAT_181d4e010 + 184) + 32);
          if (lVar3 == null) throw; // [null/range check failed]
          lVar3 = lVar3.speUseData;
          if (((this.skillLvData == null) ||
              (lVar7 = KungfuSkillLvData.DataBase(this.skillLvData,0)) == null) ||
             (lVar3 == null)) throw; // [null/range check failed]
          uVar1 = *(uint32 *)(lVar7 + 52);
          if (lVar3.fightExp <= uVar1) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          lVar3 = lVar3.skillID[uVar1];
          if ((lVar3 == null) || (plVar6 == (int64 *)0)) throw; // [null/range check failed]
          local_38 = lVar3.fightExp;
          uStack_34 = lVar3.bookExp;
          uStack_30 = lVar3.equiped;
          uStack_2c = lVar3.belongHeroID;
          (**(code **)(*plVar6 + 0x2a8))(plVar6,&local_38,*(uint64 *)(*plVar6 + 0x2b0));
          lVar3 = Component.get_transform(this,0);
          if ((lVar3 == null) || (lVar3 = Transform.Find(lVar3,"Icon",0)) == null)
          throw; // [null/range check failed]
          lVar3 = Component.GetComponent(lVar3,DAT_181d6bc40);
          lVar7 = *pStatics_6270;
          if (((this.skillLvData == null) ||
              (uVar4 = KungfuSkillLvData.GetSkillIcon(this.skillLvData,0), lVar7 == null)) ||
             ((uVar4 = TextureController.LoadAtlasSprite(lVar7,"IconAtlas",uVar4,0), lVar3 == null ||
              ((Image.set_sprite(lVar3,uVar4,0), this.skillLvData == null ||
               (lVar3 = KungfuSkillLvData.DataBase()) == null))))) throw; // [null/range check failed]
          if (lVar3.fightExp < 0) {
            lVar3 = Component.get_transform(this);
            if (((lVar3 == null) || (lVar3 = Transform.Find(lVar3,"Force",0)) == null) ||
               (lVar3 = Component.get_gameObject(lVar3,0)) == null) throw; // [null/range check failed]
            GameObject.SetActive(lVar3,0,0);
          }
          else {
            lVar3 = Component.get_transform(this);
            if (((lVar3 == null) || (lVar3 = Transform.Find(lVar3,"Force",0)) == null) ||
               (lVar3 = Component.get_gameObject(lVar3,0)) == null) throw; // [null/range check failed]
            GameObject.SetActive(lVar3,1,0);
            lVar3 = Component.get_transform(this,0);
            if ((lVar3 == null) || (lVar3 = Transform.Find(lVar3,"Force",0)) == null)
            throw; // [null/range check failed]
            lVar3 = Component.GetComponent(lVar3,DAT_181d6bc40);
            lVar7 = *pStatics_6270;
            if ((this.skillLvData == null) ||
               (lVar8 = KungfuSkillLvData.DataBase(this.skillLvData,0)) == null)
            throw; // [null/range check failed]
            uVar11 = *(uint32 *)(lVar8 + 24);
            uVar4 = GlobalData.GetForceIconName(uVar11,0);
            if ((lVar7 == null) ||
               (uVar4 = TextureController.LoadAtlasSprite(lVar7,"UIAtlas",uVar4,0), lVar3 == null))
            throw; // [null/range check failed]
            Image.set_sprite(lVar3,uVar4,0);
          }
          SkillIconController.RefreshSkillLvAndExp(this,0);
        }
        uVar4 = *(uint64 *)(*(int64 *)(DAT_181d66570 + 184) + 72);
        uVar5 = Component.get_gameObject(this,0);
        cVar2 = Object.op_Equality(uVar4,uVar5,0);
        if (cVar2) {
          if (this.skillLvData == null) throw; // [null/range check failed]
          this.skillLvData.isNew = 0;
        }
        lVar3 = Component.get_transform(this,0);
        if (((lVar3 == null) || (lVar3 = Transform.Find(lVar3,"New",0)) == null) ||
           (lVar3 = Component.get_gameObject(lVar3,0)) == null) throw; // [null/range check failed]
        cVar2 = GameObject.get_activeSelf(lVar3,0);
        lVar3 = this.skillLvData;
        if (lVar3 == null) throw; // [null/range check failed]
        if (cVar2 != lVar3.isNew) {
          lVar3 = Component.get_transform(this,0);
          if ((lVar3 == null) || (lVar3 = Transform.Find(lVar3,"New",0)) == null)
          throw; // [null/range check failed]
          lVar3 = Component.get_gameObject(lVar3,0);
          if ((this.skillLvData == null) || (lVar3 == null)) throw; // [null/range check failed]
          GameObject.SetActive(lVar3,this.skillLvData.isNew,0);
          lVar3 = this.skillLvData;
          if (lVar3 == null) throw; // [null/range check failed]
        }
        if (lVar3.skillIconDirty) {
          SkillIconController.RefreshSkillLvAndExp(this,0);
        }
        if ((this.skillIconType - 1U & 0xfffffffd) != 0) {
          return;
        }
        fVar15 = this.refreshTime;
        fVar10 = (float)Time.get_deltaTime(0);
        fVar15 = fVar15 - fVar10;
        this.refreshTime = fVar15;
        if (0.0 < fVar15) {
          return;
        }
        this.refreshTime = 0x3dcccccd;
        if (this.skillLvData == null) throw; // [null/range check failed]
        if (0.0 < this.skillLvData.activeTimeLeft) {
          lVar3 = Component.get_transform(this,0);
          if (((lVar3 == null) || (lVar3 = Transform.Find(lVar3,"CdCover",0)) == null) ||
             (lVar3 = Transform.Find(lVar3,"CdTime",0)) == null) throw; // [null/range check failed]
          uVar4 = Component.GetComponent(lVar3,DAT_181d6d8c0);
          if (this.skillLvData == null) throw; // [null/range check failed]
          uVar5 = Single.ToString(this.skillLvData + 96,"f0",0);
          LTLocalization.SetText(uVar4,uVar5,0);
          lVar3 = Component.get_transform(this,0);
          if ((lVar3 == null) || (lVar3 = Transform.Find(lVar3,"CdCover",0)) == null)
          throw; // [null/range check failed]
          plVar6 = (int64 *)Component.GetComponent(lVar3,DAT_181d6bc40);
          puVar9 = *(uint32 **)(DAT_181d7df30 + 184);
          if (plVar6 == (int64 *)0) throw; // [null/range check failed]
          local_38 = *puVar9;
          uStack_34 = puVar9[1];
          uStack_30 = puVar9[2];
          uStack_2c = puVar9[3];
          (**(code **)(*plVar6 + 0x2a8))(plVar6,&local_38,*(uint64 *)(*plVar6 + 0x2b0));
          lVar3 = Component.get_transform(this,0);
          if (((lVar3 == null) || (lVar3 = Transform.Find(lVar3,"CdCover",0)) == null) ||
             (lVar3 = Transform.Find(lVar3,"CdTime",0)) == null) throw; // [null/range check failed]
          plVar6 = (int64 *)Component.GetComponent(lVar3,DAT_181d6d8c0);
          lVar3 = pStatics_ef00;
          if (plVar6 == (int64 *)0) throw; // [null/range check failed]
          local_38 = *(uint32 *)(lVar3 + 0x280);
          uStack_34 = *(uint32 *)(lVar3 + 0x284);
          uStack_30 = *(uint32 *)(lVar3 + 0x288);
          uStack_2c = *(uint32 *)(lVar3 + 0x28c);
          (**(code **)(*plVar6 + 0x2a8))(plVar6,&local_38,*(uint64 *)(*plVar6 + 0x2b0));
          lVar3 = Component.get_transform(this,0);
          if (((lVar3 == null) || (lVar3 = Transform.Find(lVar3,"CdCover",0)) == null) ||
             (lVar3 = Transform.Find(lVar3,"CdTime",0)) == null) throw; // [null/range check failed]
          lVar7 = Component.GetComponent(lVar3,DAT_181d6c2c0);
          lVar3 = pStatics_df30;
          if (lVar7 == null) throw; // [null/range check failed]
          local_38 = lVar3.skillID;
          uStack_34 = lVar3.lv;
          uStack_30 = lVar3.fightExp;
          uStack_2c = lVar3.bookExp;
        LAB_180974108:
          Shadow.set_effectColor(lVar7,&local_38,0);
        }
        else {
          lVar3 = FUN_18046bb80(0);
          if (lVar3 == null) throw; // [null/range check failed]
          uVar4 = *(uint64 *)(lVar3 + 0x110);
          cVar2 = Object.op_Inequality(uVar4,0,0);
          if (cVar2) {
            lVar3 = FUN_18046bb80(0);
            if (((lVar3 == null) || (*(int64 *)(lVar3 + 0x110) == 0)) ||
               (lVar3 = *(int64 *)(*(int64 *)(lVar3 + 0x110) + 64)) == null)
            throw; // [null/range check failed]
            cVar2 = HeroData.CanUseSkill(lVar3,this.skillLvData,0);
            if (!cVar2) {
              lVar3 = Component.get_transform(this,0);
              if (((lVar3 == null) || (lVar3 = Transform.Find(lVar3,"CdCover",0)) == null) ||
                 (lVar3 = Transform.Find(lVar3,"CdTime",0)) == null) throw; // [null/range check failed]
              uVar4 = Component.GetComponent(lVar3,DAT_181d6d8c0);
              lVar3 = this.skillLvData;
              if (lVar3 == null) throw; // [null/range check failed]
              uVar5 = "";
              if (0.0 < lVar3.cdTimeLeft) {
                uVar5 = Single.ToString(lVar3 + 88,"f0",0);
              }
              LTLocalization.SetText(uVar4,uVar5,0);
              lVar3 = Component.get_transform(this,0);
              if ((lVar3 == null) || (lVar3 = Transform.Find(lVar3,"CdCover",0)) == null)
              throw; // [null/range check failed]
              plVar6 = (int64 *)Component.GetComponent(lVar3,DAT_181d6bc40);
              lVar3 = pStatics_df30;
              if (plVar6 == (int64 *)0) throw; // [null/range check failed]
              local_38 = lVar3.equiped;
              uStack_34 = lVar3.belongHeroID;
              uStack_30 = lVar3.speEquipData;
              uStack_2c = *(uint32 *)(lVar3 + 44);
              (**(code **)(*plVar6 + 0x2a8))(plVar6,&local_38,*(uint64 *)(*plVar6 + 0x2b0));
              lVar3 = Component.get_transform(this,0);
              if (((lVar3 == null) || (lVar3 = Transform.Find(lVar3,"CdCover",0)) == null) ||
                 (lVar3 = Transform.Find(lVar3,"CdTime",0)) == null) throw; // [null/range check failed]
              plVar6 = (int64 *)Component.GetComponent(lVar3,DAT_181d6d8c0);
              lVar3 = pStatics_ef00;
              if (plVar6 == (int64 *)0) throw; // [null/range check failed]
              local_38 = *(uint32 *)(lVar3 + 0x2e8);
              uStack_34 = *(uint32 *)(lVar3 + 0x2ec);
              uStack_30 = *(uint32 *)(lVar3 + 0x2f0);
              uStack_2c = *(uint32 *)(lVar3 + 0x2f4);
              (**(code **)(*plVar6 + 0x2a8))(plVar6,&local_38,*(uint64 *)(*plVar6 + 0x2b0));
              lVar3 = Component.get_transform(this,0);
              if (((lVar3 == null) || (lVar3 = Transform.Find(lVar3,"CdCover",0)) == null) ||
                 (lVar3 = Transform.Find(lVar3,"CdTime",0)) == null) throw; // [null/range check failed]
              lVar7 = Component.GetComponent(lVar3,DAT_181d6c2c0);
              lVar3 = pStatics_df30;
              if (lVar7 == null) throw; // [null/range check failed]
              local_38 = lVar3.equipUseSpeAddValue;
              uStack_34 = *(uint32 *)(lVar3 + 52);
              uStack_30 = lVar3.speUseData;
              uStack_2c = *(uint32 *)(lVar3 + 60);
              goto LAB_180974108;
            }
          }
          lVar3 = Component.get_transform(this,0);
          if ((lVar3 == null) || (lVar3 = Transform.Find(lVar3,"CdCover",0)) == null)
          throw; // [null/range check failed]
          plVar6 = (int64 *)Component.GetComponent(lVar3,DAT_181d6bc40);
          puVar9 = (uint32 *)FUN_180d904c0(&local_38,0);
          if (plVar6 == (int64 *)0) throw; // [null/range check failed]
          local_38 = *puVar9;
          uStack_34 = puVar9[1];
          uStack_30 = puVar9[2];
          uStack_2c = puVar9[3];
          (**(code **)(*plVar6 + 0x2a8))(plVar6,&local_38,*(uint64 *)(*plVar6 + 0x2b0));
          lVar3 = Component.get_transform(this,0);
          if (((lVar3 == null) || (lVar3 = Transform.Find(lVar3,"CdCover",0)) == null) ||
             (lVar3 = Transform.Find(lVar3,"CdTime",0)) == null) throw; // [null/range check failed]
          uVar4 = Component.GetComponent(lVar3,DAT_181d6d8c0);
          LTLocalization.SetText(uVar4,"",0);
        }
        if ((this.skillLvData != null) &&
           (lVar3 = KungfuSkillLvData.DataBase(this.skillLvData,0)) != null) {
          if (2 < lVar3.equipUseSpeAddValue) {
            return;
          }
          if (this.skillLvData != null) {
            if (0.0 < this.skillLvData.activeTimeLeft) {
              lVar3 = Component.get_transform(this,0);
              if (((lVar3 != null) && (lVar3 = Transform.Find(lVar3,"PowerBar",0)) != null) &&
                 (lVar3 = Component.GetComponent(lVar3,DAT_181d6bc40)) != null) {
                Image.set_fillAmount(lVar3,0,0);
                return;
              }
            }
            else {
              lVar3 = Component.get_transform(this,0);
              if ((lVar3 != null) && (lVar3 = Transform.Find(lVar3,"PowerBar",0)) != null) {
                lVar7 = Component.GetComponent(lVar3,DAT_181d6bc40);
                lVar3 = this.skillLvData;
                if (lVar3 != null) {
                  fVar15 = lVar3.power;
                  fVar10 = (float)KungfuSkillLvData.MaxPower(lVar3,0);
                  if (lVar7 != null) {
                    Image.set_fillAmount(lVar7,fVar15 / fVar10,0);
                    lVar3 = Component.get_transform(this,0);
                    if ((lVar3 != null) && (lVar3 = Transform.Find(lVar3,"PowerBar",0)) != null) {
                      plVar6 = (int64 *)Component.GetComponent(lVar3,DAT_181d6bc40);
                      lVar3 = this.skillLvData;
                      if (lVar3 != null) {
                        fVar15 = lVar3.power;
                        fVar10 = (float)KungfuSkillLvData.MaxPower(lVar3,0);
                        if (fVar15 < fVar10) {
                          lVar3 = pStatics_ef00;
                          uVar11 = *(uint32 *)(lVar3 + 0x350);
                          uVar12 = *(uint32 *)(lVar3 + 0x354);
                          uVar13 = *(uint32 *)(lVar3 + 0x358);
                          uVar14 = *(uint32 *)(lVar3 + 0x35c);
                        }
                        else {
                          lVar3 = pStatics_ef00;
                          uVar11 = *(uint32 *)(lVar3 + 0x340);
                          uVar12 = *(uint32 *)(lVar3 + 0x344);
                          uVar13 = *(uint32 *)(lVar3 + 0x348);
                          uVar14 = *(uint32 *)(lVar3 + 0x34c);
                        }
                        if (plVar6 != (int64 *)0) {
                          local_38 = uVar11;
                          uStack_34 = uVar12;
                          uStack_30 = uVar13;
                          uStack_2c = uVar14;
                          (**(code **)(*plVar6 + 0x2a8))
                                    (plVar6,&local_38,*(uint64 *)(*plVar6 + 0x2b0));
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

    // Token : 0x60020A9
    // RVA   : 0x972950   Offset: 0x971150   Length: 0x8D4
    public void RefreshSkillLvAndExp()
    {
        float fVar1;
        uint uVar2;
        bool cVar3;
        bool cVar4;
        byte uVar5;
        long lVar6;
        ulong uVar7;
        ulong uVar9;
        long lVar11;
        float fVar12;
        uint local_28;
        uint uStack_24;
        uint uStack_20;
        uint32 uStack_1c;
        if (this.skillLvData != null) {
          this.skillLvData.skillIconDirty = 0;
          lVar6 = Component.get_transform(this,0);
          if (((lVar6 != null) && (lVar6 = Transform.Find(lVar6,"SkillLvBack",0)) != null) &&
             (lVar6 = Transform.Find(lVar6,"SkillLv",0)) != null) {
            uVar7 = Component.GetComponent(lVar6,DAT_181d6d8c0);
            if (this.skillLvData != null) {
              uVar2 = this.skillLvData.lv;
              plVar8 = (int64 *)GlobalData.GetNumText(uVar2,0);
              if (plVar8 != (int64 *)0) {
                uVar9 = (**(code **)(*plVar8 + 0x168))(plVar8,*(uint64 *)(*plVar8 + 0x170));
                LTLocalization.SetText(uVar7,uVar9,0);
                if (this.skillLvData != null) {
                  if (this.skillLvData.belongHeroID == null) {
                    lVar6 = Component.get_transform(this);
                    if (((lVar6 == null) || (lVar6 = Transform.Find(lVar6,"SkillLvBack",0)) == null) ||
                       ((lVar6 = Transform.Find(lVar6,"Lock",0), lVar6 == null ||
                        (lVar6 = Component.get_gameObject(lVar6,0)) == null))) throw; // [null/range check failed]
                    cVar3 = GameObject.get_activeSelf(lVar6,0);
                    if (this.skillLvData == null) throw; // [null/range check failed]
                    cVar4 = KungfuSkillLvData.SkillMeetObstacleLv(this.skillLvData,0);
                    if (cVar3 != cVar4) {
                      lVar6 = Component.get_transform(this,0);
                      if (((lVar6 == null) || (lVar6 = Transform.Find(lVar6,"SkillLvBack",0)) == null)
                         || (lVar6 = Transform.Find(lVar6,"Lock",0)) == null)
                      throw; // [null/range check failed]
                      lVar6 = Component.get_gameObject(lVar6,0);
                      if ((this.skillLvData == null) ||
                         (uVar5 = KungfuSkillLvData.SkillMeetObstacleLv(this.skillLvData,0),
                         lVar6 == null)) throw; // [null/range check failed]
                      GameObject.SetActive(lVar6,uVar5,0);
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
                      lVar6 = Component.get_transform(this,0);
                      if (((lVar6 == null) || (lVar6 = Transform.Find(lVar6,"SkillLvBack",0)) == null)
                         || ((lVar6 = Transform.Find(lVar6,"Lock",0), lVar6 == null ||
                             (lVar6 = Transform.Find(lVar6,"Icon",0)) == null)))
                      throw; // [null/range check failed]
                      plVar8 = (int64 *)Component.GetComponent(lVar6,DAT_181d6bc40);
                      if (!cVar3) {
                        puVar10 = (uint32 *)Color.get_red(&local_28,0);
                      }
                      else {
                        puVar10 = (uint32 *)Color.get_green();
                      }
                      if (plVar8 == (int64 *)0) throw; // [null/range check failed]
                      local_28 = *puVar10;
                      uStack_24 = puVar10[1];
                      uStack_20 = puVar10[2];
                      uStack_1c = puVar10[3];
                      (**(code **)(*plVar8 + 0x2a8))(plVar8,&local_28,*(uint64 *)(*plVar8 + 0x2b0));
                      lVar6 = Component.get_transform(this,0);
                      if (((lVar6 == null) || (lVar6 = Transform.Find(lVar6,"SkillLvBack",0)) == null)
                         || (lVar6 = Transform.Find(lVar6,"Lock",0)) == null)
                      throw; // [null/range check failed]
                      lVar6 = Component.GetComponent(lVar6,DAT_181d6ccc0);
                      uVar7 = "<color=red>经验未满\n无法突破</color>";
                      if (cVar3) {
                        uVar7 = "<color=green>经验已满\n在闭关室突破</color>";
                      }
                      if (lVar6 == null) throw; // [null/range check failed]
                      lVar6.fightExp = uVar7;
                    }
                  }
                  else {
                    lVar6 = Component.get_transform(this);
                    if (((lVar6 == null) || (lVar6 = Transform.Find(lVar6,"SkillLvBack",0)) == null) ||
                       ((lVar6 = Transform.Find(lVar6,"Lock",0), lVar6 == null ||
                        (lVar6 = Component.get_gameObject(lVar6,0)) == null))) throw; // [null/range check failed]
                    cVar3 = GameObject.get_activeSelf(lVar6,0);
                    if (cVar3) {
                      lVar6 = Component.get_transform(this,0);
                      if (((lVar6 == null) || (lVar6 = Transform.Find(lVar6,"SkillLvBack",0)) == null)
                         || ((lVar6 = Transform.Find(lVar6,"Lock",0), lVar6 == null ||
                             (lVar6 = Component.get_gameObject(lVar6,0)) == null)))
                      throw; // [null/range check failed]
                      GameObject.SetActive(lVar6,0,0);
                    }
                  }
                  if (this.skillLvData != null) {
                    if (this.skillLvData.lv < 10) {
                      lVar6 = Component.get_transform(this,0);
                      if (((lVar6 != null) && (lVar6 = Transform.Find(lVar6,"ExpBack",0)) != null)
                         && (lVar6 = Component.get_gameObject(lVar6,0)) != null) {
                        cVar3 = GameObject.get_activeSelf(lVar6,0);
                        if (!cVar3) {
                          lVar6 = Component.get_transform(this,0);
                          if ((lVar6 == null) || (lVar6 = Transform.Find(lVar6,"ExpBack",0)) == null
                             ) throw; // [null/range check failed]
                          lVar6 = Component.get_gameObject(lVar6,0);
                          if (lVar6 == null) throw; // [null/range check failed]
                          GameObject.SetActive(lVar6,1,0);
                        }
                        lVar6 = Component.get_transform(this,0);
                        if (((lVar6 != null) && (lVar6 = Transform.Find(lVar6,"ExpFull",0)) != null)
                           && (lVar6 = Component.get_gameObject(lVar6,0)) != null) {
                          cVar3 = GameObject.get_activeSelf(lVar6,0);
                          if (cVar3) {
                            lVar6 = Component.get_transform(this,0);
                            if (((lVar6 == null) ||
                                (lVar6 = Transform.Find(lVar6,"ExpFull",0)) == null) ||
                               (lVar6 = Component.get_gameObject(lVar6,0)) == null)
                            throw; // [null/range check failed]
                            GameObject.SetActive(lVar6,0,0);
                          }
                          lVar6 = Component.get_transform(this,0);
                          if (((lVar6 != null) &&
                              (lVar6 = Transform.Find(lVar6,"ExpBack",0)) != null) &&
                             (lVar6 = Transform.Find(lVar6,"BookExp",0)) != null) {
                            lVar11 = Component.GetComponent(lVar6,DAT_181d6bc40);
                            lVar6 = this.skillLvData;
                            if (lVar6 != null) {
                              fVar1 = lVar6.bookExp;
                              fVar12 = (float)KungfuSkillLvData.SkillGetMaxExp(lVar6,0,0);
                              if (lVar11 != null) {
                                Image.set_fillAmount(lVar11,fVar1 / fVar12,0);
                                lVar6 = Component.get_transform(this,0);
                                if (((lVar6 != null) &&
                                    (lVar6 = Transform.Find(lVar6,"ExpBack",0)) != null) &&
                                   (lVar6 = Transform.Find(lVar6,"FightExp",0)) != null) {
                                  lVar11 = Component.GetComponent(lVar6,DAT_181d6bc40);
                                  lVar6 = this.skillLvData;
                                  if (lVar6 != null) {
                                    fVar1 = lVar6.fightExp;
                                    fVar12 = (float)KungfuSkillLvData.SkillGetMaxExp(lVar6,1);
                                    if (lVar11 != null) {
                                      Image.set_fillAmount(lVar11,fVar1 / fVar12,0);
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
                    else {
                      lVar6 = Component.get_transform(this,0);
                      if (((lVar6 != null) && (lVar6 = Transform.Find(lVar6,"ExpBack",0)) != null)
                         && (lVar6 = Component.get_gameObject(lVar6,0)) != null) {
                        cVar3 = GameObject.get_activeSelf(lVar6,0);
                        if (cVar3) {
                          lVar6 = Component.get_transform(this,0);
                          if (((lVar6 == null) ||
                              (lVar6 = Transform.Find(lVar6,"ExpBack",0)) == null) ||
                             (lVar6 = Component.get_gameObject(lVar6,0)) == null) throw; // [null/range check failed]
                          GameObject.SetActive(lVar6,0,0);
                        }
                        lVar6 = Component.get_transform(this,0);
                        if (((lVar6 != null) && (lVar6 = Transform.Find(lVar6,"ExpFull",0)) != null)
                           && (lVar6 = Component.get_gameObject(lVar6,0)) != null) {
                          cVar3 = GameObject.get_activeSelf(lVar6,0);
                          if (cVar3) {
                            return;
                          }
                          lVar6 = Component.get_transform(this,0);
                          if ((lVar6 != null) && (lVar6 = Transform.Find(lVar6,"ExpFull",0)) != null
                             ) {
                            lVar6 = Component.get_gameObject(lVar6,0);
                            if (lVar6 != null) {
                              GameObject.SetActive(lVar6,1,0);
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

    // Token : 0x60020AA
    // RVA   : 0x972420   Offset: 0x970C20   Length: 0x33C
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
        LAB_180972755:
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
        uVar2 = Int32.ToString(lVar1 + 52,"",0);
        if ((this.skillLvData == null) ||
           (lVar1 = KungfuSkillLvData.DataBase(this.skillLvData,0)) == null)
        goto LAB_180972755;
        local_res8[0] = lVar1.fightExp + 1;
        uVar3 = Int32.ToString(local_res8,"00",0);
        if (this.skillLvData == null) goto LAB_180972755;
        uVar4 = Int32.ToString(this.skillLvData + 16,"0000",0);
        uVar2 = String.Concat(uVar2,uVar3,uVar4,0);
        Object.set_name(this,uVar2,0);
        switch(sortType) {
        case 0:
          piVar5 = &this.skillListID;
          uVar2 = "000";
          if (reverseOrder) {
            local_res8[0] = 999 - *piVar5;
            piVar5 = local_res8;
          }
          break;
        case 1:
          lVar1 = this.skillLvData;
          if (!reverseOrder) {
            if ((lVar1 == null) || (lVar1 = KungfuSkillLvData.DataBase(lVar1,0)) == null)
            goto LAB_180972755;
            uVar2 = Int32.ToString(lVar1 + 52,0);
          }
          else {
            if ((lVar1 == null) || (lVar1 = KungfuSkillLvData.DataBase(lVar1,0)) == null)
            goto LAB_180972755;
            local_res8[0] = 9 - *(int *)(lVar1 + 52);
            uVar2 = Int32.ToString(local_res8,0);
          }
          goto LAB_180972582;
        case 2:
          lVar1 = this.skillLvData;
          uVar2 = "00";
          if (!reverseOrder) {
            if (lVar1 == null) goto LAB_180972755;
            piVar5 = &lVar1.lv;
          }
          else {
            if (lVar1 == null) goto LAB_180972755;
            local_res8[0] = 10 - lVar1.lv;
            piVar5 = local_res8;
          }
          break;
        case 3:
          lVar1 = this.skillLvData;
          if (!reverseOrder) {
            if ((lVar1 == null) || (lVar1 = KungfuSkillLvData.DataBase(lVar1,0)) == null)
            goto LAB_180972755;
            piVar5 = &lVar1.fightExp;
            uVar2 = "00";
          }
          else {
            if ((lVar1 == null) || (lVar1 = KungfuSkillLvData.DataBase(lVar1,0)) == null)
            goto LAB_180972755;
            local_res8[0] = 99 - lVar1.fightExp;
            piVar5 = local_res8;
            uVar2 = "00";
          }
          break;
        case 4:
          lVar1 = this.skillLvData;
          if (!reverseOrder) {
            if (lVar1 == null) goto LAB_180972755;
            local_28[0] = (float)KungfuSkillLvData.GetBaseDamage(lVar1,0);
          }
          else {
            if (lVar1 == null) goto LAB_180972755;
            local_28[0] = (float)KungfuSkillLvData.GetBaseDamage(lVar1,0);
        LAB_1809726f2:
            local_28[0] = 99.0 - local_28[0];
          }
          goto LAB_180972718;
        case 5:
          lVar1 = this.skillLvData;
          if (reverseOrder) {
            if (lVar1 == null) goto LAB_180972755;
            local_28[0] = (float)KungfuSkillLvData.GetManaCost(lVar1,0);
            goto LAB_1809726f2;
          }
          if (lVar1 == null) goto LAB_180972755;
          local_28[0] = (float)KungfuSkillLvData.GetManaCost(lVar1,0);
        LAB_180972718:
          uVar2 = Single.ToString(local_28,"00.0",0);
          goto LAB_180972582;
        default:
          goto switchD_180972556_default;
        }
        uVar2 = Int32.ToString(piVar5,uVar2,0);
        LAB_180972582:
        uVar3 = Object.get_name(this,0);
        uVar2 = String.Concat(uVar2,uVar3,0);
        Object.set_name(this,uVar2,0);
        switchD_180972556_default:
    }

    // Token : 0x60020AB
    // RVA   : 0x972780   Offset: 0x970F80   Length: 0x1CF
    public void OnClick()
    {
        var pStatics = *(int64*)(DAT_181d50f00 + 184);
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
              lVar2 = FUN_18046bd60(0);
              uVar3 = Component.get_gameObject(this,0);
              if (lVar2 == null) throw; // [null/range check failed]
              ChooseController.ChooseObj(lVar2,uVar3,0);
            }
            return;
          }
          lVar2 = FUN_18046bb80(0);
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

    // Token : 0x60020AC
    // RVA   : 0x3A17B0   Offset: 0x39FFB0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_18044ef50(this,0);
    }

    // Token : 0x60020AD
    // RVA   : 0x974330   Offset: 0x972B30   Length: 0x139
    private static void /*cctor*/()
    {
        var pStatics = *(int64*)(DAT_181d7df30 + 184);
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
        FUN_1809981e0(&local_48,0,0x3f19999a,0,0x3f000000,0);
        puVar1 = *(uint64 **)(DAT_181d7df30 + 184);
        *puVar1 = local_48;
        puVar1[1] = uStack_40;
        local_38 = 0;
        uStack_30 = 0;
        FUN_1809981e0(&local_38,0,0,0,0x3f333333,0);
        lVar2 = pStatics;
        *(uint64 *)(lVar2 + 16) = local_38;
        *(uint64 *)(lVar2 + 24) = uStack_30;
        local_28 = 0;
        uStack_20 = 0;
        FUN_1809981e0(&local_28,0,0,0,0x3f400000,0);
        lVar2 = pStatics;
        *(uint32 *)(lVar2 + 32) = (uint32)local_28;
        *(uint32 *)(lVar2 + 36) = local_28._4_4_;
        *(uint32 *)(lVar2 + 40) = (uint32)uStack_20;
        *(uint32 *)(lVar2 + 44) = uStack_20._4_4_;
        local_18 = 0;
        uStack_10 = 0;
        FUN_1809981e0(&local_18,0x3f800000,0x3f800000,0x3f800000,0x3f800000,0);
        lVar2 = pStatics;
        *(uint64 *)(lVar2 + 48) = local_18;
        *(uint64 *)(lVar2 + 56) = uStack_10;
    }

}
