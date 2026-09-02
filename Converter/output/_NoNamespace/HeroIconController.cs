// ============================================================
// Type  : HeroIconController
// Token : 0x20002C6
// ============================================================

public class HeroIconController
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001675
    public HeroIconType heroIconType;

    // Token: 0x4001676
    public HeroData heroData;

    // Token: 0x4001677
    public bool inited;

    // Token: 0x4001678
    public bool needHighLight;

    // Token: 0x4001679
    public GameObject highLightPrefab;

    // Token: 0x400167A
    public GameObject highLight;

    // Token: 0x400167B
    public bool showForceLvUpgrade;

    // Token: 0x400167C
    public GameObject upgradeForceLvButtonPrefab;

    // Token: 0x400167D
    public GameObject upgradeForceLvButton;

    // Token: 0x400167E
    public bool hideBack;

    // Token: 0x400167F
    private GameObject battlePrepareSpellIcon;

    // Token: 0x4001680
    private static Color defaultNameColor;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x600178F
    // RVA   : 0xB34260   Offset: 0xB32A60   Length: 0xE
    private void OnEnable()
    {
        void FUN_180b34260(int64 this)
        {
        if (this.inited) {
          HeroIconController.RefreshHeroIcon(this,0);
          return;
        }
    }

    // Token : 0x6001790
    // RVA   : 0xB35BD0   Offset: 0xB343D0   Length: 0xE
    private void Update()
    {
        void FUN_180b35bd0(int64 this)
        {
        if (!this.inited) {
          HeroIconController.Init(this,0);
          return;
        }
    }

    // Token : 0x6001791
    // RVA   : 0xB33FC0   Offset: 0xB327C0   Length: 0x40
    private void LateUpdate()
    {
        long lVar1;
        bool cVar2;
        lVar1 = this.heroData;
        if (lVar1 == null) {
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
        if (!lVar1.heroDetailDirty) {
          cVar2 = HeroData.get_HeroIconDirty(lVar1,0);
          if (!cVar2) {
            return;
          }
        }
        HeroIconController.RefreshHeroIcon(this,0);
    }

    // Token : 0x6001792
    // RVA   : 0xB35A00   Offset: 0xB34200   Length: 0x10D
    public void SetImageSprite(Image targetImage, string spriteName)
    {
        var pStatics = *(int64*)(DAT_181d86270 + 184);
        bool cVar1;
        long lVar2;
        ulong uVar3;
        if (targetImage != null) {
          uVar3 = *(uint64 *)(targetImage + 216);
          cVar1 = Object.op_Equality(uVar3,0,0);
          if (!cVar1) {
            if ((*(int64 *)(targetImage + 216) == 0) ||
               (lVar2 = Object.get_name(*(int64 *)(targetImage + 216),0)) == null)
            throw; // [null/range check failed]
            cVar1 = String.Contains(lVar2,spriteName,0);
            if (cVar1) {
              return;
            }
          }
          if (*pStatics != 0) {
            uVar3 = TextureController.LoadAtlasSprite
                              (*pStatics,"UIAtlas",spriteName,0);
            Image.set_sprite(targetImage,uVar3,0);
            return;
          }
        }
    }

    // Token : 0x6001793
    // RVA   : 0xB34270   Offset: 0xB32A70   Length: 0x1785
    public void RefreshHeroIcon()
    {
        var pStatics_4cc0 = *(int64*)(DAT_181d84cc0 + 184);
        var pStatics_b4a8 = *(int64*)(DAT_181d8b4a8 + 184);
        var pStatics_ef00 = *(int64*)(DAT_181d4ef00 + 184);
        bool cVar1;
        int iVar2;
        uint uVar3;
        long lVar4;
        ulong uVar5;
        ulong uVar6;
        long lVar8;
        uint uVar12;
        uint uVar13;
        uint uVar14;
        ulong local_48;
        float local_40;
        ulong local_38;
        float local_30;
        byte[] local_28 = new byte[16];
        uint local_18;
        uint uStack_14;
        uint uStack_10;
        uint32 uStack_c;
        if (this.heroData == null) throw; // [null/range check failed]
        HeroData.CheckHeroDetailDirty(this.heroData,0,0);
        lVar4 = Component.get_transform(this,0);
        if ((lVar4 == null) || (lVar4 = Transform.Find(lVar4,"HeroName",0)) == null)
        throw; // [null/range check failed]
        uVar5 = Component.GetComponent(lVar4,DAT_181d6d8c0);
        if (this.heroData == null) throw; // [null/range check failed]
        uVar6 = HeroData.HeroName(this.heroData,1,0);
        LTLocalization.SetText(uVar5,uVar6,0);
        lVar4 = Component.get_transform(this,0);
        if ((lVar4 == null) || (lVar4 = Transform.Find(lVar4,"HeroName",0)) == null)
        throw; // [null/range check failed]
        lVar4 = Component.GetComponent(lVar4,DAT_181d6d8c0);
        if (this.heroData == null) throw; // [null/range check failed]
        cVar1 = HeroData.HaveSetName(this.heroData,0);
        if (lVar4 == null) throw; // [null/range check failed]
        Text.set_alignment(lVar4,4 - (uint32)(cVar1),0);
        lVar4 = Component.get_transform(this,0);
        if ((lVar4 == null) || (lVar4 = Transform.Find(lVar4,"HeroName",0)) == null)
        throw; // [null/range check failed]
        plVar7 = (int64 *)Component.GetComponent(lVar4,DAT_181d6d8c0);
        if (this.heroData == null) throw; // [null/range check failed]
        iVar2 = HeroData.GetBountyPirce(this.heroData,0);
        if (iVar2 < 1) {
          puVar9 = *(uint32 **)(DAT_181d51100 + 184);
          uVar3 = *puVar9;
          uVar12 = puVar9[1];
          uVar13 = puVar9[2];
          uVar14 = puVar9[3];
        }
        else {
          lVar4 = pStatics_ef00;
          uVar3 = lVar4.missions;
          uVar12 = *(uint32 *)(lVar4 + 0x2ec);
          uVar13 = lVar4.inTeam;
          uVar14 = lVar4.teamLeader;
        }
        if (plVar7 == (int64 *)0) throw; // [null/range check failed]
        local_18 = uVar3;
        uStack_14 = uVar12;
        uStack_10 = uVar13;
        uStack_c = uVar14;
        (**(code **)(*plVar7 + 0x2a8))(plVar7,&local_18,*(uint64 *)(*plVar7 + 0x2b0));
        lVar4 = this.heroData;
        lVar8 = Component.get_transform(this,0);
        if (((lVar8 == null) || (lVar8 = Transform.Find(lVar8,"State",0)) == null) ||
           (uVar5 = Component.get_gameObject(lVar8,0), lVar4 == null)) throw; // [null/range check failed]
        HeroData.SetHpBar(lVar4,uVar5,0);
        lVar4 = this.heroData;
        lVar8 = Component.get_transform(this,0);
        if (((lVar8 == null) || (lVar8 = Transform.Find(lVar8,"State",0)) == null) ||
           (uVar5 = Component.get_gameObject(lVar8,0), lVar4 == null)) throw; // [null/range check failed]
        HeroData.SetMpBar(lVar4,uVar5,0);
        lVar4 = this.heroData;
        lVar8 = Component.get_transform(this,0);
        if (((lVar8 == null) || (lVar8 = Transform.Find(lVar8,"HeroFavor",0)) == null) ||
           (uVar5 = Component.get_gameObject(lVar8,0), lVar4 == null)) throw; // [null/range check failed]
        HeroData.SetHeroFavorUI(lVar4,uVar5,0,0);
        if (this.heroData == null) throw; // [null/range check failed]
        if (this.heroData.belongForceID < 0) {
          lVar4 = Component.get_transform(this);
          if (((lVar4 == null) || (lVar4 = Transform.Find(lVar4,"HeroForceIcon",0)) == null) ||
             (lVar4 = Component.get_gameObject(lVar4,0)) == null) throw; // [null/range check failed]
          cVar1 = GameObject.get_activeSelf(lVar4,0);
          if (cVar1) {
            lVar4 = Component.get_transform(this,0);
            if (((lVar4 == null) || (lVar4 = Transform.Find(lVar4,"HeroForceIcon",0)) == null) ||
               (lVar4 = Component.get_gameObject(lVar4,0)) == null) throw; // [null/range check failed]
            GameObject.SetActive(lVar4,0,0);
          }
        }
        else {
          lVar4 = Component.get_transform(this);
          if (((lVar4 == null) || (lVar4 = Transform.Find(lVar4,"HeroForceIcon",0)) == null) ||
             (lVar4 = Component.get_gameObject(lVar4,0)) == null) throw; // [null/range check failed]
          cVar1 = GameObject.get_activeSelf(lVar4,0);
          if (!cVar1) {
            lVar4 = Component.get_transform(this,0);
            if (((lVar4 == null) || (lVar4 = Transform.Find(lVar4,"HeroForceIcon",0)) == null) ||
               (lVar4 = Component.get_gameObject(lVar4,0)) == null) throw; // [null/range check failed]
            GameObject.SetActive(lVar4,1,0);
          }
          lVar4 = Component.get_transform(this,0);
          if ((lVar4 == null) || (lVar4 = Transform.Find(lVar4,"HeroForceIcon",0)) == null)
          throw; // [null/range check failed]
          uVar5 = Component.GetComponent(lVar4,DAT_181d6bc40);
          if (this.heroData == null) throw; // [null/range check failed]
          uVar3 = this.heroData.belongForceID;
          uVar6 = GlobalData.GetForceIconName(uVar3,0);
          HeroIconController.SetImageSprite(this,uVar5,uVar6,0);
        }
        lVar4 = Component.get_transform(this,0);
        if ((lVar4 == null) || (lVar4 = Transform.Find(lVar4,"HeroForce",0)) == null)
        throw; // [null/range check failed]
        uVar5 = Component.GetComponent(lVar4,DAT_181d6d8c0);
        if (this.heroData == null) throw; // [null/range check failed]
        uVar6 = HeroData.GetHeroForceLvDescribeSimplify(this.heroData,0);
        LTLocalization.SetText(uVar5,uVar6,0);
        lVar4 = Component.get_transform(this,0);
        if ((lVar4 == null) || (lVar4 = Transform.Find(lVar4,"PrisonCover",0)) == null)
        throw; // [null/range check failed]
        plVar7 = (int64 *)Component.GetComponent(lVar4,DAT_181d6bc40);
        if (this.heroData == null) throw; // [null/range check failed]
        if (!this.heroData.inPrison) {
        LAB_180b34a19:
          puVar9 = (uint32 *)FUN_180d904c0(&local_18,0);
        }
        else {
          lVar4 = *(int64 *)(*(int64 *)(DAT_181d8b128 + 184) + 80);
          if (lVar4 == null) throw; // [null/range check failed]
          if (*(int *)(lVar4 + 36) != 0) goto LAB_180b34a19;
          puVar9 = (uint32 *)FUN_181098a50(&local_18,0);
        }
        if (plVar7 == (int64 *)0) throw; // [null/range check failed]
        local_18 = *puVar9;
        uStack_14 = puVar9[1];
        uStack_10 = puVar9[2];
        uStack_c = puVar9[3];
        (**(code **)(*plVar7 + 0x2a8))(plVar7,&local_18,*(uint64 *)(*plVar7 + 0x2b0));
        lVar4 = this.heroData;
        if (lVar4 == null) throw; // [null/range check failed]
        if (lVar4.plotNumCount < 1) {
          if (lVar4.missionNumCount < 1) {
            if ((lVar4.playerInteractionTimeData == null) ||
               (lVar4 = *(int64 *)(lVar4.playerInteractionTimeData + 16)) == null)
            throw; // [null/range check failed]
            if (lVar4.summonLv < 8) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            if (0 < *(int *)(lVar4.isSummon + 60)) {
              if (this.heroData == null) throw; // [null/range check failed]
              if (this.heroData.haveMeet) {
                lVar4 = Component.get_transform(this,0);
                if ((lVar4 == null) || (lVar4 = Transform.Find(lVar4,"MissionIcon",0)) == null)
                throw; // [null/range check failed]
                plVar7 = (int64 *)Component.GetComponent(lVar4,DAT_181d6bc40);
                puVar9 = (uint32 *)FUN_181098a50(&local_18,0);
                if (plVar7 == (int64 *)0) throw; // [null/range check failed]
                local_18 = *puVar9;
                uStack_14 = puVar9[1];
                uStack_10 = puVar9[2];
                uStack_c = puVar9[3];
                (**(code **)(*plVar7 + 0x2a8))(plVar7,&local_18,*(uint64 *)(*plVar7 + 0x2b0));
                lVar4 = Component.get_transform(this,0);
                if ((lVar4 == null) || (lVar4 = Transform.Find(lVar4,"MissionIcon",0)) == null)
                throw; // [null/range check failed]
                uVar5 = Component.GetComponent(lVar4,DAT_181d6bc40);
                HeroIconController.SetImageSprite(this,uVar5,"问号",0);
                lVar4 = Component.get_transform(this,0);
                if ((lVar4 == null) ||
                   ((lVar4 = Transform.Find(lVar4,"MissionIcon",0), lVar4 == null ||
                    (plVar7 = (int64 *)Component.GetComponent(lVar4,DAT_181d6bc40),
                    plVar7 == (int64 *)0)))) throw; // [null/range check failed]
                (**(code **)(*plVar7 + 0x2c8))(plVar7,1,*(uint64 *)(*plVar7 + 0x2d0));
                lVar4 = Component.get_transform(this,0);
                if ((lVar4 == null) || (lVar4 = Transform.Find(lVar4,"MissionIcon",0)) == null)
                throw; // [null/range check failed]
                lVar4 = Component.GetComponent(lVar4,DAT_181d6ccc0);
                uVar5 = "个人委托";
                goto joined_r0x000180b3502d;
              }
            }
            lVar4 = Component.get_transform(this,0);
            if ((lVar4 == null) || (lVar4 = Transform.Find(lVar4,"MissionIcon",0)) == null)
            throw; // [null/range check failed]
            plVar7 = (int64 *)Component.GetComponent(lVar4,DAT_181d6bc40);
            puVar9 = (uint32 *)FUN_180d904c0(&local_18,0);
            if (plVar7 == (int64 *)0) throw; // [null/range check failed]
            local_18 = *puVar9;
            uStack_14 = puVar9[1];
            uStack_10 = puVar9[2];
            uStack_c = puVar9[3];
            (**(code **)(*plVar7 + 0x2a8))(plVar7,&local_18,*(uint64 *)(*plVar7 + 0x2b0));
            lVar4 = Component.get_transform(this,0);
            if (((lVar4 == null) || (lVar4 = Transform.Find(lVar4,"MissionIcon",0)) == null) ||
               (plVar7 = (int64 *)Component.GetComponent(lVar4,DAT_181d6bc40),
               plVar7 == (int64 *)0)) throw; // [null/range check failed]
            (**(code **)(*plVar7 + 0x2c8))(plVar7,0,*(uint64 *)(*plVar7 + 0x2d0));
            lVar4 = Component.get_transform(this,0);
            if ((lVar4 == null) || (lVar4 = Transform.Find(lVar4,"MissionIcon",0)) == null)
            throw; // [null/range check failed]
            lVar4 = Component.GetComponent(lVar4,DAT_181d6ccc0);
            uVar5 = "";
          }
          else {
            lVar4 = Component.get_transform(this,0);
            if ((lVar4 == null) || (lVar4 = Transform.Find(lVar4,"MissionIcon",0)) == null)
            throw; // [null/range check failed]
            plVar7 = (int64 *)Component.GetComponent(lVar4,DAT_181d6bc40);
            puVar9 = (uint32 *)FUN_181098a50(&local_18,0);
            if (plVar7 == (int64 *)0) throw; // [null/range check failed]
            local_18 = *puVar9;
            uStack_14 = puVar9[1];
            uStack_10 = puVar9[2];
            uStack_c = puVar9[3];
            (**(code **)(*plVar7 + 0x2a8))(plVar7,&local_18,*(uint64 *)(*plVar7 + 0x2b0));
            lVar4 = Component.get_transform(this,0);
            if ((lVar4 == null) || (lVar4 = Transform.Find(lVar4,"MissionIcon",0)) == null)
            throw; // [null/range check failed]
            uVar5 = Component.GetComponent(lVar4,DAT_181d6bc40);
            HeroIconController.SetImageSprite(this,uVar5,"任务目标",0);
            lVar4 = Component.get_transform(this,0);
            if ((lVar4 == null) ||
               ((lVar4 = Transform.Find(lVar4,"MissionIcon",0), lVar4 == null ||
                (plVar7 = (int64 *)Component.GetComponent(lVar4,DAT_181d6bc40),
                plVar7 == (int64 *)0)))) throw; // [null/range check failed]
            (**(code **)(*plVar7 + 0x2c8))(plVar7,1,*(uint64 *)(*plVar7 + 0x2d0));
            lVar4 = Component.get_transform(this,0);
            if ((lVar4 == null) || (lVar4 = Transform.Find(lVar4,"MissionIcon",0)) == null)
            throw; // [null/range check failed]
            lVar4 = Component.GetComponent(lVar4,DAT_181d6ccc0);
            uVar5 = "任务目标";
          }
        }
        else {
          lVar4 = Component.get_transform(this,0);
          if ((lVar4 == null) || (lVar4 = Transform.Find(lVar4,"MissionIcon",0)) == null)
          throw; // [null/range check failed]
          plVar7 = (int64 *)Component.GetComponent(lVar4,DAT_181d6bc40);
          puVar9 = (uint32 *)Color.get_yellow(&local_18,0);
          if (plVar7 == (int64 *)0) throw; // [null/range check failed]
          local_18 = *puVar9;
          uStack_14 = puVar9[1];
          uStack_10 = puVar9[2];
          uStack_c = puVar9[3];
          (**(code **)(*plVar7 + 0x2a8))(plVar7,&local_18,*(uint64 *)(*plVar7 + 0x2b0));
          lVar4 = Component.get_transform(this,0);
          if ((lVar4 == null) || (lVar4 = Transform.Find(lVar4,"MissionIcon",0)) == null)
          throw; // [null/range check failed]
          uVar5 = Component.GetComponent(lVar4,DAT_181d6bc40);
          HeroIconController.SetImageSprite(this,uVar5,"问号",0);
          lVar4 = Component.get_transform(this,0);
          if ((lVar4 == null) ||
             ((lVar4 = Transform.Find(lVar4,"MissionIcon",0), lVar4 == null ||
              (plVar7 = (int64 *)Component.GetComponent(lVar4,DAT_181d6bc40),
              plVar7 == (int64 *)0)))) throw; // [null/range check failed]
          (**(code **)(*plVar7 + 0x2c8))(plVar7,1,*(uint64 *)(*plVar7 + 0x2d0));
          lVar4 = Component.get_transform(this,0);
          if ((lVar4 == null) || (lVar4 = Transform.Find(lVar4,"MissionIcon",0)) == null)
          throw; // [null/range check failed]
          lVar4 = Component.GetComponent(lVar4,DAT_181d6ccc0);
          uVar5 = "剧情事件";
        }
        joined_r0x000180b3502d:
        if (lVar4 == null) throw; // [null/range check failed]
        lVar4.summonLv = uVar5;
        if (this.showForceLvUpgrade) {
          uVar5 = this.upgradeForceLvButton;
          cVar1 = Object.op_Inequality(uVar5,0,0);
          if (cVar1) {
            if (this.upgradeForceLvButton == null) throw; // [null/range check failed]
            lVar8 = GameObject.GetComponent(this.upgradeForceLvButton,DAT_181d9ee60);
            lVar4 = this.heroData;
            if (lVar4 == null) throw; // [null/range check failed]
            bVar11 = false;
            if (!lVar4.hide) {
              bVar11 = !lVar4.inPrison;
            }
            if (lVar8 == null) throw; // [null/range check failed]
            Selectable.set_interactable(lVar8,bVar11,0);
            lVar4 = this.heroData;
            if (lVar4 == null) throw; // [null/range check failed]
            if ((!lVar4.isLeader) && (lVar4.heroForceLv < 5)) {
              if (this.upgradeForceLvButton == null) throw; // [null/range check failed]
              lVar4 = GameObject.GetComponent(this.upgradeForceLvButton,DAT_181da12b0);
              if ((this.heroData == null) ||
                 (uVar5 = HeroData.GetUpgradeForceLvNeedText(this.heroData,0), lVar4 == null
                 )) throw; // [null/range check failed]
              lVar4.summonLv = uVar5;
            }
            else {
              if ((this.upgradeForceLvButton == null) ||
                 (lVar4 = GameObject.GetComponent(this.upgradeForceLvButton,DAT_181da12b0),
                 uVar5 = "", lVar4 == null)) throw; // [null/range check failed]
              lVar4.summonLv = "";
            }
            il2cpp_internal(puVar10,uVar5);
          }
        }
        lVar4 = this.heroData;
        if (lVar4 == null) throw; // [null/range check failed]
        if (!lVar4.dead) {
          if (this.heroIconType == 1) {
            if (lVar4.heroAIData == null) throw; // [null/range check failed]
            if (*(int *)(lVar4.heroAIData + 16) != 0) {
              lVar4 = FUN_18046bb80(0);
              if (lVar4 == null) throw; // [null/range check failed]
              if (*(int *)(lVar4 + 36) == 0) {
                lVar4 = Component.get_transform(this,0);
                if ((lVar4 == null) || (lVar4 = Transform.Find(lVar4,"AIStuff",0)) == null)
                throw; // [null/range check failed]
                plVar7 = (int64 *)Component.GetComponent(lVar4,DAT_181d6bc40);
                puVar9 = (uint32 *)FUN_181098a50(&local_18,0);
                if (plVar7 == (int64 *)0) throw; // [null/range check failed]
                local_18 = *puVar9;
                uStack_14 = puVar9[1];
                uStack_10 = puVar9[2];
                uStack_c = puVar9[3];
                (**(code **)(*plVar7 + 0x2a8))(plVar7,&local_18,*(uint64 *)(*plVar7 + 0x2b0));
                lVar4 = Component.get_transform(this,0);
                if (((lVar4 == null) || (lVar4 = Transform.Find(lVar4,"AIStuff",0)) == null) ||
                   (lVar4 = Component.GetComponent(lVar4,DAT_181d6c2c0)) == null) throw; // [null/range check failed]
                Behaviour.set_enabled(lVar4,0,0);
                lVar4 = Component.get_transform(this,0);
                if (((lVar4 == null) || (lVar4 = Transform.Find(lVar4,"AIStuff",0)) == null) ||
                   (lVar4 = Component.GetComponent(lVar4,DAT_181d6bc40)) == null) throw; // [null/range check failed]
                lVar4 = Component.get_transform(lVar4,0);
                puVar10 = (uint64 *)Vector3.get_one(local_28,0);
                if (lVar4 == null) throw; // [null/range check failed]
                local_40 = *(float *)(puVar10 + 1);
                local_48 = *puVar10;
                Transform.set_localScale(lVar4,&local_48,0);
                if ((this.heroData == null) ||
                   (lVar4 = this.heroData.heroAIData) == null)
                throw; // [null/range check failed]
                if (lVar4.isSummon == 7) {
                  lVar4 = Component.get_transform(this,0);
                  if ((lVar4 == null) || (lVar4 = Transform.Find(lVar4,"AIStuff",0)) == null)
                  throw; // [null/range check failed]
                  uVar6 = Component.GetComponent(lVar4,DAT_181d6bc40);
                  lVar4 = *(int64 *)(pStatics_ef00 + 0x430);
                  if (((this.heroData == null) ||
                      (lVar8 = this.heroData.heroAIData) == null) ||
                     (uVar3 = Int32.Parse(*(uint64 *)(lVar8 + 24),0), lVar4 == null))
                  throw; // [null/range check failed]
                  uVar5 = FUN_180002f80(lVar4,uVar3,DAT_181d7c9c0);
                }
                else {
                  lVar4 = Component.get_transform(this,0);
                  if ((lVar4 == null) || (lVar4 = Transform.Find(lVar4,"AIStuff",0)) == null)
                  throw; // [null/range check failed]
                  uVar6 = Component.GetComponent(lVar4,DAT_181d6bc40);
                  if (((this.heroData == null) ||
                      (lVar4 = this.heroData.heroAIData) == null) ||
                     (*pStatics_4cc0 == 0)) throw; // [null/range check failed]
                  uVar5 = FUN_180002f80(*pStatics_4cc0,
                                        lVar4.isSummon,DAT_181d7c9c0);
                  uVar5 = String.Concat("从事工作_",uVar5,0);
                }
                goto LAB_180b355f4;
              }
            }
          }
          lVar4 = Component.get_transform(this,0);
          if ((lVar4 == null) || (lVar4 = Transform.Find(lVar4,"AIStuff",0)) == null)
          throw; // [null/range check failed]
          plVar7 = (int64 *)Component.GetComponent(lVar4,DAT_181d6bc40);
          puVar9 = (uint32 *)FUN_180d904c0(&local_18,0);
          if (plVar7 == (int64 *)0) throw; // [null/range check failed]
          local_18 = *puVar9;
          uStack_14 = puVar9[1];
          uStack_10 = puVar9[2];
          uStack_c = puVar9[3];
          (**(code **)(*plVar7 + 0x2a8))(plVar7,&local_18,*(uint64 *)(*plVar7 + 0x2b0));
        }
        else {
          lVar4 = Component.get_transform(this,0);
          if ((lVar4 == null) || (lVar4 = Transform.Find(lVar4,"AIStuff",0)) == null)
          throw; // [null/range check failed]
          plVar7 = (int64 *)Component.GetComponent(lVar4,DAT_181d6bc40);
          puVar9 = (uint32 *)FUN_181098a50(&local_18,0);
          if (plVar7 == (int64 *)0) throw; // [null/range check failed]
          local_18 = *puVar9;
          uStack_14 = puVar9[1];
          uStack_10 = puVar9[2];
          uStack_c = puVar9[3];
          (**(code **)(*plVar7 + 0x2a8))(plVar7,&local_18,*(uint64 *)(*plVar7 + 0x2b0));
          lVar4 = Component.get_transform(this,0);
          if ((lVar4 == null) || (lVar4 = Transform.Find(lVar4,"AIStuff",0)) == null)
          throw; // [null/range check failed]
          uVar6 = Component.GetComponent(lVar4,DAT_181d6bc40);
          uVar5 = "墓碑";
        LAB_180b355f4:
          HeroIconController.SetImageSprite(this,uVar6,uVar5,0);
        }
        if (this.heroData == null) throw; // [null/range check failed]
        uVar5 = this.battlePrepareSpellIcon;
        if (this.heroData.battlePrepareSpellData == null) {
          cVar1 = Object.op_Inequality(uVar5,0,0);
          if (cVar1) {
            uVar5 = this.battlePrepareSpellIcon;
            Object.Destroy(uVar5,0);
          }
        }
        else {
          cVar1 = Object.op_Equality(uVar5,0,0);
          if (cVar1) {
            uVar5 = Component.get_gameObject(this,0);
            if (*pStatics_b4a8 == 0) throw; // [null/range check failed]
            uVar6 = *(uint64 *)(*pStatics_b4a8 + 40);
            uVar5 = GlobalData.AddChild(uVar5,uVar6,0);
            this.battlePrepareSpellIcon = uVar5;
            if ((this.battlePrepareSpellIcon == null) ||
               (lVar4 = GameObject.get_transform(this.battlePrepareSpellIcon,0)) == null)
            throw; // [null/range check failed]
            local_48 = 0x4282000042200000;
            local_40 = 0.0;
            Transform.set_localPosition(lVar4,&local_48,0);
            if (this.battlePrepareSpellIcon == null) throw; // [null/range check failed]
            lVar4 = GameObject.get_transform(this.battlePrepareSpellIcon,0);
            puVar10 = (uint64 *)Vector3.get_one(&local_18,0);
            local_38 = *puVar10;
            local_30 = *(float *)(puVar10 + 1);
            local_40 = local_30 * 5.0;
            local_48 = CONCAT44((float)((uint64)local_38 >> 32) * 5.0,(float)local_38 * 5.0);
            if (lVar4 == null) throw; // [null/range check failed]
            local_38 = local_48;
            local_30 = local_40;
            Transform.set_localScale(lVar4,&local_38,0);
            if (this.battlePrepareSpellIcon == null) throw; // [null/range check failed]
            uVar5 = GameObject.get_transform(this.battlePrepareSpellIcon,0);
            uVar5 = ShortcutExtensions.DOScale(uVar5,0x3f800000,0x3e800000,0);
            TweenSettingsExtensions.SetEase(uVar5,9,DAT_181d97ca8);
          }
          if (this.battlePrepareSpellIcon == null) throw; // [null/range check failed]
          lVar4 = GameObject.GetComponent(this.battlePrepareSpellIcon,DAT_181d9e668);
          if ((this.heroData == null) || (lVar4 == null)) throw; // [null/range check failed]
          lVar4.summonLv = this.heroData.battlePrepareSpellData;
          if (this.battlePrepareSpellIcon == null) throw; // [null/range check failed]
          lVar4 = GameObject.GetComponent(this.battlePrepareSpellIcon,DAT_181d9e668);
          if (lVar4 == null) throw; // [null/range check failed]
          lVar4.summonSourceHero = this.heroData;
          if ((this.battlePrepareSpellIcon == null) ||
             (lVar4 = GameObject.GetComponent(this.battlePrepareSpellIcon,DAT_181d9e668)) == null)
          throw; // [null/range check failed]
          lVar4.summonControlable = 1;
          if ((this.battlePrepareSpellIcon == null) ||
             (lVar4 = GameObject.GetComponent(this.battlePrepareSpellIcon,DAT_181d9e668)) == null)
          throw; // [null/range check failed]
          BattlePrepareSpellButtonController.Init(lVar4,0);
        }
        lVar4 = Component.get_transform(this,0);
        if (((lVar4 != null) && (lVar4 = Transform.Find(lVar4,"Star",0)) != null) &&
           (lVar4 = Component.get_gameObject(lVar4,0)) != null) {
          cVar1 = GameObject.get_activeSelf(lVar4,0);
          lVar4 = this.heroData;
          if (lVar4 != null) {
            if (cVar1 == lVar4.interestingStar) {
        LAB_180b359c7:
              HeroData.set_HeroIconDirty(lVar4,0,0);
              return;
            }
            lVar4 = Component.get_transform(this,0);
            if ((lVar4 != null) && (lVar4 = Transform.Find(lVar4,"Star",0)) != null) {
              lVar4 = Component.get_gameObject(lVar4,0);
              if ((this.heroData != null) && (lVar4 != null)) {
                GameObject.SetActive(lVar4,this.heroData.interestingStar,0);
                lVar4 = this.heroData;
                if (lVar4 != null) goto LAB_180b359c7;
              }
            }
          }
        }
    }

    // Token : 0x6001794
    // RVA   : 0xB33A40   Offset: 0xB32240   Length: 0x147
    public void AutoSetName()
    {
        long lVar1;
        ulong uVar2;
        ulong uVar3;
        ulong uVar4;
        int[] local_res8 = new int[2];
        if (this.heroData != null) {
          if (!this.heroData.isLeader) {
            lVar1 = *(int64 *)(*(int64 *)(DAT_181d4ef00 + 184) + 0x3d0);
            if ((lVar1 == null) || (this.heroData == null)) throw; // [null/range check failed]
            local_res8[0] = *(int *)(lVar1 + 24) - this.heroData.heroForceLv;
          }
          else {
            local_res8[0] = 0;
          }
          uVar2 = Int32.ToString(local_res8,0);
          if (this.heroData != null) {
            uVar3 = Int32.ToString(this.heroData + 132,"00",0);
            if (this.heroData != null) {
              uVar4 = Int32.ToString(this.heroData + 88,"0000",0);
              uVar2 = String.Concat(uVar2,uVar3,uVar4,0);
              Object.set_name(this,uVar2,0);
              return;
            }
          }
        }
    }

    // Token : 0x6001795
    // RVA   : 0xB33B90   Offset: 0xB32390   Length: 0x425
    public void Init()
    {
        bool cVar1;
        long lVar4;
        ulong uVar5;
        ulong uVar6;
        long lVar7;
        uint local_18;
        uint uStack_14;
        uint uStack_10;
        uint32 uStack_c;
        this.inited = 1;
        if (this.hideBack) {
          plVar2 = (int64 *)Component.GetComponent(this,DAT_181d6bc40);
          puVar3 = (uint32 *)FUN_180d904c0(&local_18,0);
          if (plVar2 == (int64 *)0) goto LAB_180b33fb0;
          local_18 = *puVar3;
          uStack_14 = puVar3[1];
          uStack_10 = puVar3[2];
          uStack_c = puVar3[3];
          (**(code **)(*plVar2 + 0x2a8))(plVar2,&local_18,*(uint64 *)(*plVar2 + 0x2b0));
        }
        lVar7 = this.heroData;
        lVar4 = Component.get_transform(this,0);
        if (lVar4 == null) goto LAB_180b33fb0;
        uVar5 = Transform.Find(lVar4,"Back",0);
        if (lVar7 == null) goto LAB_180b33fb0;
        HeroData.SetSkeletonGraphic(lVar7,uVar5,0xffffff9d,0xffffffff,0);
        lVar7 = this.heroData;
        lVar4 = Component.get_transform(this,0);
        if (lVar4 == null) goto LAB_180b33fb0;
        uVar5 = Transform.Find(lVar4,"Back",0);
        if (lVar7 == null) goto LAB_180b33fb0;
        plVar2 = (int64 *)HeroData.GetSkeletonGraphic(lVar7,uVar5,0);
        lVar7 = *(int64 *)(*(int64 *)(DAT_181d8b128 + 184) + 80);
        if (lVar7 == null) goto LAB_180b33fb0;
        if (*(int *)(lVar7 + 36) == 0) {
          lVar7 = this.heroData;
          if (lVar7 == null) goto LAB_180b33fb0;
          if (!((!lVar7.dead) && (!lVar7.hide)))
          {
            puVar3 = (uint32 *)FUN_1810988d0(&local_18,0);
            }
            else {
          }
          puVar3 = (uint32 *)FUN_181098a50(&local_18,0);
        }
        if (plVar2 == (int64 *)0) goto LAB_180b33fb0;
        local_18 = *puVar3;
        uStack_14 = puVar3[1];
        uStack_10 = puVar3[2];
        uStack_c = puVar3[3];
        (**(code **)(*plVar2 + 0x2a8))(plVar2,&local_18,*(uint64 *)(*plVar2 + 0x2b0));
        if (this.showForceLvUpgrade) {
          uVar5 = this.upgradeForceLvButton;
          cVar1 = Object.op_Equality(uVar5,0,0);
          if (cVar1) {
            uVar6 = Component.get_gameObject(this,0);
            uVar5 = this.upgradeForceLvButtonPrefab;
            uVar5 = GlobalData.AddChild(uVar6,uVar5,0);
            this.upgradeForceLvButton = uVar5;
            if (this.upgradeForceLvButton == null) goto LAB_180b33fb0;
            lVar7 = GameObject.GetComponent(this.upgradeForceLvButton,DAT_181d9ee60);
            if (lVar7 == null) goto LAB_180b33fb0;
            lVar7 = lVar7.changeSkinCd;
            uVar5 = new OnTooltipCB(this,DAT_181d50390,0);
            if (lVar7 == null) goto LAB_180b33fb0;
            UnityEvent.AddListener(lVar7,uVar5,0);
            if (this.upgradeForceLvButton == null) goto LAB_180b33fb0;
            lVar7 = GameObject.get_transform(this.upgradeForceLvButton,0);
            if (lVar7 == null) goto LAB_180b33fb0;
            uStack_14 = 0xc2000000;
            local_18 = 0;
            uStack_10 = 0;
            Transform.set_localPosition(lVar7,&local_18,0);
          }
        }
        if (this.needHighLight) {
          uVar6 = Component.get_gameObject(this,0);
          uVar5 = this.highLightPrefab;
          uVar5 = GlobalData.AddChild(uVar6,uVar5,0);
          this.highLight = uVar5;
          if (this.highLight != null) {
            lVar7 = GameObject.get_transform(this.highLight,0);
            if (lVar7 != null) {
              Transform.SetSiblingIndex(lVar7,0,0);
              goto LAB_180b33f92;
            }
          }
        LAB_180b33fb0:
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
        LAB_180b33f92:
        HeroIconController.RefreshHeroIcon(this,0);
    }

    // Token : 0x6001796
    // RVA   : 0xB35B10   Offset: 0xB34310   Length: 0xB6
    public void UpgradeForceLvButtonClicked()
    {
        var pStatics = *(int64*)(DAT_181d6c960 + 184);
        if (*pStatics != 0) {
          PlotController.ManageHeroForceLvPlot
                    (*pStatics,this.heroData,0);
          return;
        }
    }

    // Token : 0x6001797
    // RVA   : 0xB34010   Offset: 0xB32810   Length: 0x244
    public void OnClick()
    {
        var pStatics_0f00 = *(int64*)(DAT_181d50f00 + 184);
        var pStatics_6278 = *(int64*)(DAT_181d96278 + 184);
        int iVar1;
        ulong uVar2;
        long lVar3;
        if (*pStatics_6278 == 0) throw; // [null/range check failed]
        if (*(int *)(*pStatics_6278 + 24) != 0) {
          plVar4 = (int64 *)Resources.Load("Sound/SoundEffect/WrongClick",0);
          plVar5 = (int64 *)0;
          if ((plVar4 != (int64 *)0) && (*plVar4 == DAT_181d8a228)) {
            plVar5 = plVar4;
          }
          NGUITools.PlaySound(plVar5,0);
          return;
        }
        if (this.heroIconType != 1) {
          lVar3 = this.heroData;
          if (lVar3 == null) throw; // [null/range check failed]
          uVar2 = HeroData.GetHeroMeetSound(lVar3,"Meet",0);
          HeroData.PlayHeroSound(lVar3,uVar2,0x3f000000,0xbf800000,0);
          iVar1 = this.heroIconType;
          if (iVar1 != 1) {
            if (iVar1 != 2) {
              if (iVar1 == 3) {
                lVar3 = **(int64 **)(DAT_181d92370 + 184);
                uVar2 = Component.get_gameObject(this,0);
                if (lVar3 == null) throw; // [null/range check failed]
                ChooseController.ChooseObj(lVar3,uVar2,0);
              }
              return;
            }
            if (*pStatics_0f00 != 0) {
              HeroDetailController.ShowHeroDetail
                        (*pStatics_0f00,this.heroData,
                         this.showForceLvUpgrade,0);
              return;
            }
            throw; // [null/range check failed]
          }
        }
        lVar3 = FUN_18046c440(0);
        if (lVar3 != null) {
          PlotController.ShowHeroInteractUI(lVar3,this.heroData,0);
          return;
        }
    }

    // Token : 0x6001798
    // RVA   : 0x3A17B0   Offset: 0x39FFB0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_18044ef50(this,0);
    }

    // Token : 0x6001799
    // RVA   : 0xB35BE0   Offset: 0xB343E0   Length: 0x6E
    private static void /*cctor*/()
    {
        ulong local_18;
        ulong uStack_10;
        local_18 = 0;
        uStack_10 = 0;
        Color.ctor(&local_18,0x3f3fbfc0,0x3f19999a,0x3e60e0e1,0);
        puVar1 = *(uint64 **)(DAT_181d51100 + 184);
        *puVar1 = local_18;
        puVar1[1] = uStack_10;
    }

    // Token : 0x600179A
    // RVA   : 0xB35B10   Offset: 0xB34310   Length: 0xB6
    private void <Init>b__18_0()
    {
        var pStatics = *(int64*)(DAT_181d6c960 + 184);
        if (*pStatics != 0) {
          PlotController.ManageHeroForceLvPlot
                    (*pStatics,this.heroData,0);
          return;
        }
    }

}
