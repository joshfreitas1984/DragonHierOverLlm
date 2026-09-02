// ============================================================
// Type  : OtherForceContributionExchangeController
// Token : 0x2000309
// ============================================================

public class OtherForceContributionExchangeController
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001848
    public ForceData targetForceData;

    // Token: 0x4001849
    public GameObject exchangeUIPanel;

    // Token: 0x400184A
    public GameObject exchangeSkillGrid;

    // Token: 0x400184B
    public GameObject contributionSkillUnlockButtonPrefab;

    // Token: 0x400184C
    public SkeletonGraphic buildingIcon;

    // Token: 0x400184D
    private GameObject temp;

    // Token: 0x400184E
    private static List<float> exchangeMinFame;

    // Token: 0x400184F
    private static List<float> exchangeMinFavor;

    // Token: 0x4001850
    private static OtherForceContributionExchangeController _instance;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6001911
    // RVA   : 0x4730F0   Offset: 0x4718F0   Length: 0x58
    public static OtherForceContributionExchangeController get_Instance()
    {
        return *(uint64 *)(*(int64 *)(DAT_181d6a268 + 184) + 16);
    }

    // Token : 0x6001912
    // RVA   : 0x46F050   Offset: 0x46D850   Length: 0xE0
    private void Awake()
    {
        var pStatics = *(int64*)(DAT_181d6a268 + 184);
        ulong uVar1;
        bool cVar2;
        uVar1 = *(uint64 *)(pStatics + 16);
        cVar2 = Object.op_Equality(uVar1,0,0);
        if (cVar2) {
          puVar3 = (uint64 *)(pStatics + 16);
          *puVar3 = this;
          il2cpp_internal(puVar3,this);
        }
    }

    // Token : 0x6001913
    // RVA   : 0x470A50   Offset: 0x46F250   Length: 0x10FE
    public void ShowExchangeUI(ForceData targetForce)
    {
        var pStatics_a268 = *(int64*)(DAT_181d6a268 + 184);
        var pStatics_e188 = *(int64*)(DAT_181d4e188 + 184);
        ulong uVar1;
        bool cVar2;
        long lVar4;
        ulong uVar5;
        ulong uVar6;
        ulong uVar7;
        long lVar9;
        float fVar12;
        int[] local_res8 = new int[2];
        int[] local_res10 = new int[2];
        uint[] local_res20 = new uint[2];
        ulong in_stack_ffffffffffffff38;
        ulong uVar13;
        uint uVar14;
        uint[] local_a8 = new uint[2];
        float local_a0;
        float fStack_9c;
        float local_98;
        float local_88;
        uint64 local_78;
        float local_70;
        uint32 local_58;
        uint32 uStack_54;
        uint32 uStack_50;
        uint32 uStack_4c;
        plVar11 = (int64 *)0;
        local_res10[0] = 0;
        plVar3 = (int64 *)Resources.Load("Sound/SoundEffect/OpenBook",0);
        plVar10 = plVar11;
        if ((plVar3 != (int64 *)0) && (*plVar3 == DAT_181d8a228)) {
          plVar10 = plVar3;
        }
        NGUITools.PlaySound(plVar10,0);
        this.targetForceData = targetForce;
        if (this.exchangeUIPanel != null) {
          GameObject.SetActive(this.exchangeUIPanel,1,0);
          if (((this.exchangeUIPanel != null) &&
              (lVar4 = GameObject.get_transform(this.exchangeUIPanel,0)) != null) &&
             (lVar4 = Transform.Find(lVar4,"ForceName",0)) != null) {
            uVar5 = Component.GetComponent(lVar4,DAT_181d6d8c0);
            if (this.targetForceData != null) {
              LTLocalization.SetText(uVar5,this.targetForceData.forceName,0);
              local_res8[0] = 0;
              do {
                if ((this.exchangeUIPanel == null) ||
                   (lVar4 = GameObject.get_transform(this.exchangeUIPanel,0)) == null)
                throw; // [null/range check failed]
                lVar4 = Transform.Find(lVar4,"ExchangeNeeds",0);
                uVar5 = Int32.ToString(local_res8,0);
                if ((lVar4 == null) ||
                   ((lVar4 = Transform.Find(lVar4,uVar5,0), lVar4 == null ||
                    (lVar4 = Transform.Find(lVar4,"Icon",0)) == null))) throw; // [null/range check failed]
                plVar3 = (int64 *)Component.GetComponent(lVar4,DAT_181d6bc40);
                lVar4 = FUN_18046c100(0);
                if ((((lVar4 == null) || (lVar4.mainAreaID == null)) ||
                    (lVar4 = FUN_180002f80(lVar4.mainAreaID,local_res8[0],DAT_181d76758),
                    lVar4 == null)) || (plVar3 == (int64 *)0)) throw; // [null/range check failed]
                local_58 = lVar4.forceName;
                uStack_54 = *(uint32 *)(lVar4 + 28);
                uStack_50 = lVar4.defaultSkinID;
                uStack_4c = lVar4.bigForce;
                (**(code **)(*plVar3 + 0x2a8))(plVar3,&local_58,*(uint64 *)(*plVar3 + 0x2b0));
                if ((this.exchangeUIPanel == null) ||
                   (lVar4 = GameObject.get_transform(this.exchangeUIPanel,0)) == null)
                throw; // [null/range check failed]
                lVar4 = Transform.Find(lVar4,"ExchangeNeeds",0);
                uVar5 = Int32.ToString(local_res8,0);
                if ((lVar4 == null) ||
                   ((lVar4 = Transform.Find(lVar4,uVar5,0), lVar4 == null ||
                    (lVar4 = Transform.Find(lVar4,"Name",0)) == null))) throw; // [null/range check failed]
                uVar5 = Component.GetComponent(lVar4,DAT_181d6d8c0);
                lVar4 = *(int64 *)(*(int64 *)(DAT_181d4ef00 + 184) + 0x4f0);
                if (lVar4 == null) throw; // [null/range check failed]
                uVar6 = FUN_180002f80(lVar4,local_res8[0]);
                uVar6 = String.Concat(uVar6,"武功");
                LTLocalization.SetText(uVar5,uVar6);
                if ((this.exchangeUIPanel == null) ||
                   (lVar4 = GameObject.get_transform(this.exchangeUIPanel,0)) == null)
                throw; // [null/range check failed]
                lVar4 = Transform.Find(lVar4,"ExchangeNeeds",0);
                uVar5 = Int32.ToString(local_res8,0);
                if ((lVar4 == null) ||
                   ((lVar4 = Transform.Find(lVar4,uVar5,0), lVar4 == null ||
                    (lVar4 = Transform.Find(lVar4,"Describe",0)) == null))) throw; // [null/range check failed]
                uVar5 = Component.GetComponent(lVar4,DAT_181d6d8c0);
                cVar2 = OtherForceContributionExchangeController.ForceIsPlayerServant(this,0);
                if (!cVar2) {
                  if (*pStatics_a268 == 0) {
        LAB_180471b34:
                          // WARNING: Subroutine does not return
                    FUN_1800d6620();
                  }
                  local_res20[0] =
                       FUN_1800d6780(*pStatics_a268,local_res8[0],DAT_181d796d8);
                  uVar6 = il2cpp_value_box(DAT_181d7d0b8,local_res20);
                  lVar4 = *(int64 *)(pStatics_a268 + 8);
                  if (lVar4 == null) goto LAB_180471b34;
                  fVar12 = (float)FUN_1800d6780(lVar4,local_res8[0],DAT_181d796d8);
                  uVar1 = "{0}点声望{1}";
                  uVar7 = "";
                  if (0.0 < fVar12) {
                    lVar4 = *(int64 *)(pStatics_a268 + 8);
                    if (lVar4 == null) {
                          // WARNING: Subroutine does not return
                      FUN_1800d6620();
                    }
                    local_a8[0] = FUN_1800d6780(lVar4,local_res8[0],DAT_181d796d8);
                    uVar7 = il2cpp_value_box(DAT_181d7d0b8,local_a8);
                    uVar7 = String.Format(" {0}点掌门好感",uVar7,0);
                  }
                  String.Format(uVar1,uVar6,uVar7,0);
                }
                LTLocalization.SetText(uVar5);
                local_res8[0] = local_res8[0] + 1;
              } while (local_res8[0] < 6);
              lVar4 = this.targetForceData;
              plVar3 = plVar11;
              if (lVar4 != null) {
                while( true ) {
                  uVar14 = (uint32)((uint64)in_stack_ffffffffffffff38 >> 32);
                  if ((lVar4.bookStorage == null) ||
                     (lVar9 = *(int64 *)(lVar4.bookStorage + 40)) == null)
                  throw; // [null/range check failed]
                  if (*(int *)(lVar9 + 24) <= (int)plVar3) break;
                  uVar5 = this.exchangeSkillGrid;
                  if (*pStatics_e188 == 0) throw; // [null/range check failed]
                  uVar6 = *(uint64 *)(*pStatics_e188 + 168);
                  uVar5 = GlobalData.AddChild(uVar5,uVar6,0);
                  this.temp = uVar5;
                  if ((((this.targetForceData == null) ||
                       (lVar4 = this.targetForceData.bookStorage) == null) ||
                      (lVar4 = lVar4.forceStyle) == null) ||
                     ((lVar4 = FUN_180002f80(lVar4,plVar3), lVar4 == null ||
                      (lVar4.ownHeros == null)))) throw; // [null/range check failed]
                  uVar14 = *(uint32 *)(lVar4.ownHeros + 16);
                  uVar5 = new KungfuSkillLvData(uVar14);
                  if ((this.temp == null) ||
                     (lVar4 = GameObject.GetComponent(this.temp,DAT_181da1630),
                     lVar4 == null)) throw; // [null/range check failed]
                  lVar4.defaultSkinID = uVar5;
                  if ((this.temp == null) ||
                     (lVar4 = GameObject.GetComponent(this.temp,DAT_181da1630),
                     lVar4 == null)) throw; // [null/range check failed]
                  lVar4.forceStyle = 2;
                  lVar4 = GlobalData.AddChild
                                    (this.temp,this.contributionSkillUnlockButtonPrefab);
                  if (lVar4 == null) throw; // [null/range check failed]
                  Object.set_name(lVar4,"UnlockButton");
                  lVar4 = GameObject.get_transform(lVar4,0);
                  puVar8 = (uint64 *)Vector3.get_down(&local_58,0);
                  local_88 = *(float *)(puVar8 + 1);
                  fStack_9c = (float)((uint64)*puVar8 >> 32) * 75.0;
                  local_a0 = (float)*puVar8 * 75.0;
                  local_98 = local_88 * 75.0;
                  if (lVar4 == null) throw; // [null/range check failed]
                  local_78 = CONCAT44(fStack_9c,local_a0);
                  local_70 = local_98;
                  Transform.set_localPosition(lVar4,&local_78);
                  lVar4 = this.targetForceData;
                  plVar3 = (int64 *)(uint64)((int)plVar3 + 1);
                  if (lVar4 == null) throw; // [null/range check failed]
                }
                if (lVar4 != null) {
                  lVar9 = this.exchangeUIPanel;
                  if (lVar4.defaultSkinID == -99) {
                    if ((((lVar9 != null) && (lVar4 = GameObject.get_transform(lVar9,0)) != null) &&
                        (lVar4 = Transform.Find(lVar4,"ClothList",0)) != null) &&
                       (lVar4 = Component.get_gameObject(lVar4,0)) != null) {
                      GameObject.SetActive(lVar4,0,0);
                      goto LAB_180471763;
                    }
                  }
                  else if (((lVar9 != null) && (lVar4 = GameObject.get_transform(lVar9,0)) != null) &&
                          (lVar4 = Transform.Find(lVar4,"ClothList",0)) != null) {
                    lVar4 = Component.get_gameObject(lVar4,0);
                    if (lVar4 != null) {
                      GameObject.SetActive(lVar4,1,0);
                      goto LAB_1804713d0;
                    }
                  }
                }
              }
            }
          }
        }
        throw; // [null/range check failed]
        while( true ) {
          lVar4 = Transform.Find(lVar4,"ClothList",0);
          uVar5 = Int32.ToString(local_res10,0);
          uVar5 = String.Concat("Cloth",uVar5,0);
          if ((lVar4 == null) ||
             ((lVar4 = Transform.Find(lVar4,uVar5,0), lVar4 == null ||
              (lVar4 = Transform.Find(lVar4,"Text",0)) == null))) throw; // [null/range check failed]
          uVar5 = Component.GetComponent(lVar4,DAT_181d6d8c0);
          if (this.targetForceData == null) throw; // [null/range check failed]
          uVar14 = this.targetForceData.defaultSkinID;
          lVar4 = new SkinUnlockData(uVar14,0);
          if (lVar4 == null) throw; // [null/range check failed]
          uVar13 = 0;
          uVar6 = SkinUnlockData.GetSkinFullName(lVar4,local_res10[0],1,0,0);
          LTLocalization.SetText(uVar5,uVar6,0);
          if ((this.exchangeUIPanel == null) ||
             (lVar4 = GameObject.get_transform(this.exchangeUIPanel,0)) == null)
          throw; // [null/range check failed]
          lVar4 = Transform.Find(lVar4,"ClothList",0);
          uVar5 = Int32.ToString(local_res10,0);
          uVar5 = String.Concat("Cloth",uVar5,0);
          if ((lVar4 == null) ||
             ((lVar4 = Transform.Find(lVar4,uVar5,0), lVar4 == null ||
              (lVar4 = Transform.Find(lVar4,"Icon",0)) == null))) throw; // [null/range check failed]
          plVar3 = (int64 *)Component.GetComponent(lVar4,DAT_181d6bc40);
          lVar4 = FUN_18046c100(0);
          if ((((lVar4 == null) || (lVar4.mainAreaID == null)) ||
              (lVar4 = FUN_180002f80(lVar4.mainAreaID,local_res10[0],DAT_181d76758), lVar4 == null
              )) || (plVar3 == (int64 *)0)) throw; // [null/range check failed]
          local_58 = lVar4.forceName;
          uStack_54 = *(uint32 *)(lVar4 + 28);
          uStack_50 = lVar4.defaultSkinID;
          uStack_4c = lVar4.bigForce;
          (**(code **)(*plVar3 + 0x2a8))(plVar3,&local_58,*(uint64 *)(*plVar3 + 0x2b0));
          if ((this.exchangeUIPanel == null) ||
             (lVar4 = GameObject.get_transform(this.exchangeUIPanel,0)) == null)
          throw; // [null/range check failed]
          lVar4 = Transform.Find(lVar4,"ClothList",0);
          uVar5 = Int32.ToString(local_res10,0);
          uVar5 = String.Concat("Cloth",uVar5,0);
          if ((lVar4 == null) ||
             ((lVar4 = Transform.Find(lVar4,uVar5,0), lVar4 == null ||
              (lVar4 = Transform.Find(lVar4,"UnlockButton",0)) == null))) throw; // [null/range check failed]
          lVar4 = Component.GetComponent(lVar4,DAT_181d6ccc0);
          lVar9 = FUN_18046c100(0);
          if ((this.targetForceData == null) ||
             (((lVar9 == null ||
               (lVar9 = GameDataController.FindSkinDataBase
                                  (lVar9,this.targetForceData.defaultSkinID,0),
               lVar9 == null)) || (lVar9 = SkinDataBase.GetSkinSpeAdd(lVar9,local_res10[0],0)) == null))
             ) throw; // [null/range check failed]
          uVar13 = uVar13 & 0xffffffffffffff00;
          uVar5 = HeroSpeAddData.GetDescribe(lVar9,1,1,1,uVar13,0);
          uVar14 = (uint32)(uVar13 >> 32);
          if (lVar4 == null) throw; // [null/range check failed]
          lVar4.forceName = uVar5;
          local_res10[0] = local_res10[0] + 1;
          if (5 < local_res10[0]) break;
        LAB_1804713d0:
          if ((this.exchangeUIPanel == null) ||
             (lVar4 = GameObject.get_transform(this.exchangeUIPanel,0)) == null)
          throw; // [null/range check failed]
        }
        LAB_180471763:
        if (**(int **)(DAT_181d4ef00 + 184) != 2) {
          if (this.targetForceData == null) throw; // [null/range check failed]
          if (0 < this.targetForceData.speBuildingID) {
            if (((this.exchangeUIPanel != null) &&
                (lVar4 = GameObject.get_transform(this.exchangeUIPanel,0)) != null) &&
               (lVar4 = Transform.Find(lVar4,"SpeBuilding",0)) != null) {
              lVar4 = Component.get_gameObject(lVar4,0);
              if (lVar4 == null) throw; // [null/range check failed]
              GameObject.SetActive(lVar4,1,0);
              if ((((this.exchangeUIPanel == null) ||
                   (lVar4 = GameObject.get_transform(this.exchangeUIPanel,0)) == null) ||
                  (lVar4 = Transform.Find(lVar4,"SpeBuilding",0)) == null) ||
                 (lVar4 = Transform.Find(lVar4,"Text",0)) == null) throw; // [null/range check failed]
              uVar5 = Component.GetComponent(lVar4,DAT_181d6d8c0);
              lVar4 = FUN_18046c100(0);
              if (((lVar4 == null) || (this.targetForceData == null)) ||
                 ((lVar4.allyForce == null ||
                  (lVar4 = FUN_1817cc780(lVar4.allyForce,
                                         this.targetForceData.speBuildingID,
                                         DAT_181d925f0), lVar4 == null)))) throw; // [null/range check failed]
              LTLocalization.SetText(uVar5,lVar4.forceName,0);
              lVar4 = this.buildingIcon;
              lVar9 = FUN_18046c100(0);
              if ((((lVar9 == null) || (this.targetForceData == null)) ||
                  (*(int64 *)(lVar9 + 224) == 0)) ||
                 (lVar9 = FUN_1817cc780(*(int64 *)(lVar9 + 224),
                                        this.targetForceData.speBuildingID,
                                        DAT_181d925f0), lVar9 == null)) throw; // [null/range check failed]
              uVar5 = String.Concat("Skeleton/Building/",*(uint64 *)(lVar9 + 32),"/skeleton_SkeletonData",0);
              plVar3 = (int64 *)Resources.Load(uVar5,0);
              if (lVar4 == null) throw; // [null/range check failed]
              if (plVar3 != (int64 *)0) {
              }
              lVar4.forceFavorDict = plVar11;
              if (this.buildingIcon == null) throw; // [null/range check failed]
              SkeletonGraphic.Initialize(this.buildingIcon,1,0);
              if (((this.exchangeUIPanel == null) ||
                  (lVar4 = GameObject.get_transform(this.exchangeUIPanel,0)) == null) ||
                 ((lVar4 = Transform.Find(lVar4,"SpeBuilding",0), lVar4 == null ||
                  (lVar4 = Transform.Find(lVar4,"UnlockButton",0)) == null))) throw; // [null/range check failed]
              lVar4 = Component.GetComponent(lVar4,DAT_181d6ccc0);
              lVar9 = FUN_18046c100(0);
              if ((((lVar9 == null) || (this.targetForceData == null)) ||
                  (*(int64 *)(lVar9 + 224) == 0)) ||
                 ((lVar9 = FUN_1817cc780(*(int64 *)(lVar9 + 224),
                                         this.targetForceData.speBuildingID,
                                         DAT_181d925f0), lVar9 == null ||
                  (uVar5 = AreaBuildingDataBase.GetBuildingText
                                     (lVar9,0,1,1,CONCAT44(uVar14,0x3f800000),1,0,0), lVar4 == null))))
              throw; // [null/range check failed]
              lVar4.forceName = uVar5;
              goto LAB_180471b02;
            }
            throw; // [null/range check failed]
          }
        }
        if (((this.exchangeUIPanel != null) &&
            (lVar4 = GameObject.get_transform(this.exchangeUIPanel,0)) != null) &&
           ((lVar4 = Transform.Find(lVar4,"SpeBuilding",0), lVar4 != null &&
            (lVar4 = Component.get_gameObject(lVar4,0)) != null))) {
          GameObject.SetActive(lVar4,0,0);
        LAB_180471b02:
          OtherForceContributionExchangeController.RefreshExchangeUI(this,0);
          return;
        }
    }

    // Token : 0x6001914
    // RVA   : 0x46FEB0   Offset: 0x46E6B0   Length: 0xB98
    public void RefreshExchangeUI()
    {
        float fVar1;
        bool cVar2;
        bool cVar3;
        int iVar4;
        int iVar5;
        long lVar6;
        ulong uVar7;
        ulong uVar8;
        long lVar9;
        int iVar12;
        byte[] auVar14 = new byte[16];
        byte[] auVar15 = new byte[16];
        byte[] auVar16 = new byte[16];
        byte[] auVar17 = new byte[16];
        int[] local_res8 = new int[2];
        int[] local_res18 = new int[2];
        ulong local_88;
        ulong uStack_80;
        byte[] local_78 = new byte[16];
        byte[] local_68 = new byte[16];
        byte[] local_58 = new byte[48];
        uint64 extraout_XMM0_Qb;
        uint64 extraout_XMM0_Qb_00;
        iVar5 = 0;
        local_res8[0] = 0;
        if (((this.exchangeUIPanel != null) &&
            (lVar6 = GameObject.get_transform(this.exchangeUIPanel,0)) != null) &&
           (lVar6 = Transform.Find(lVar6,"ForceContribution",0)) != null) {
          uVar7 = Component.GetComponent(lVar6,DAT_181d6d8c0);
          if (this.targetForceData != null) {
            local_res18[0] = (int)this.targetForceData.playerOutForceContribution;
            uVar8 = Int32.ToString(local_res18,0);
            uVar8 = String.Concat("功绩 ",uVar8,0);
            LTLocalization.SetText(uVar7,uVar8,0);
            lVar6 = this.exchangeSkillGrid;
            iVar12 = 0;
            if (lVar6 != null) {
              while (lVar6 = GameObject.get_transform(lVar6,0)) != null {
                iVar4 = Transform.get_childCount(lVar6,0);
                if (iVar4 <= iVar12) goto LAB_1804703c0;
                if (((this.exchangeSkillGrid == null) ||
                    (lVar6 = GameObject.get_transform(this.exchangeSkillGrid,0)) == null) ||
                   ((lVar6 = Transform.GetChild(lVar6,iVar12,0), lVar6 == null ||
                    (lVar6 = Component.GetComponent(lVar6,DAT_181d6d240)) == null))) break;
                lVar6 = *(int64 *)(lVar6 + 32);
                lVar9 = FUN_18046c0a0(0);
                if ((((lVar9 == null) || (*(int64 *)(lVar9 + 32) == 0)) ||
                    (lVar9 = WorldData.Player(*(int64 *)(lVar9 + 32),0), lVar6 == null)) ||
                   (lVar9 == null)) break;
                lVar9 = HeroData.FindSkill(lVar9,*(uint32 *)(lVar6 + 16),0);
                bVar13 = lVar9 != null;
                if (((this.exchangeSkillGrid == null) ||
                    (lVar9 = GameObject.get_transform(this.exchangeSkillGrid,0)) == null) ||
                   ((lVar9 = Transform.GetChild(lVar9,iVar12,0), lVar9 == null ||
                    ((lVar9 = Transform.Find(lVar9,"UnlockButton",0), lVar9 == null ||
                     (lVar9 = Component.GetComponent(lVar9,DAT_181d6af40)) == null))))) break;
                Selectable.set_interactable(lVar9,!bVar13,0);
                if ((this.exchangeSkillGrid == null) ||
                   ((((lVar9 = GameObject.get_transform(this.exchangeSkillGrid,0), lVar9 == null ||
                      (lVar9 = Transform.GetChild(lVar9,iVar12,0)) == null) ||
                     (lVar9 = Transform.Find(lVar9,"UnlockButton",0)) == null) ||
                    (lVar9 = Transform.Find(lVar9,"Cost",0)) == null))) break;
                uVar8 = Component.GetComponent(lVar9,DAT_181d6d8c0);
                uVar7 = "已习得";
                if (!bVar13) {
                  lVar9 = KungfuSkillLvData.DataBase(lVar6,0);
                  if (lVar9 == null) break;
                  local_res18[0] =
                       OtherForceContributionExchangeController.GetExchangeContributionCost
                                 (this,*(uint32 *)(lVar9 + 52),0x3f800000);
                  uVar7 = Int32.ToString(local_res18,0);
                  uVar7 = String.Concat("功绩 ",uVar7,0);
                }
                LTLocalization.SetText(uVar8,uVar7,0);
                if (((this.exchangeSkillGrid == null) ||
                    (lVar9 = GameObject.get_transform(this.exchangeSkillGrid,0)) == null) ||
                   ((lVar9 = Transform.GetChild(lVar9,iVar12,0), lVar9 == null ||
                    ((lVar9 = Transform.Find(lVar9,"UnlockButton",0), lVar9 == null ||
                     (lVar9 = Transform.Find(lVar9,"Cost",0)) == null))))) break;
                plVar10 = (int64 *)Component.GetComponent(lVar9,DAT_181d6d8c0);
                if (bVar13) {
        LAB_180470363:
                  puVar11 = (uint64 *)Color.get_black(local_68,0);
                }
                else {
                  if (this.targetForceData == null) break;
                  fVar1 = this.targetForceData.playerOutForceContribution;
                  lVar6 = KungfuSkillLvData.DataBase(lVar6,0);
                  if (lVar6 == null) break;
                  iVar4 = OtherForceContributionExchangeController.GetExchangeContributionCost
                                    (this,*(uint32 *)(lVar6 + 52),0x3f800000);
                  if ((float)iVar4 <= fVar1) goto LAB_180470363;
                  puVar11 = (uint64 *)Color.get_red(local_78,0);
                }
                if (plVar10 == (int64 *)0) break;
                local_88 = *puVar11;
                uStack_80 = puVar11[1];
                (**(code **)(*plVar10 + 0x2a8))(plVar10);
                lVar6 = this.exchangeSkillGrid;
                iVar12 = iVar12 + 1;
                if (lVar6 == null) break;
              }
            }
          }
        }
        throw; // [null/range check failed]
        while( true ) {
          cVar2 = WorldData.SkinUnlocked
                            (*(int64 *)(lVar6 + 32),
                             this.targetForceData.defaultSkinID,local_res8[0],0);
          if ((this.exchangeUIPanel == null) ||
             (lVar6 = GameObject.get_transform(this.exchangeUIPanel,0)) == null)
          throw; // [null/range check failed]
          lVar6 = Transform.Find(lVar6,"ClothList",0);
          uVar7 = Int32.ToString(local_res8,0);
          uVar7 = String.Concat("Cloth",uVar7,0);
          if ((lVar6 == null) ||
             (((lVar6 = Transform.Find(lVar6,uVar7,0), lVar6 == null ||
               (lVar6 = Transform.Find(lVar6,"UnlockButton",0)) == null) ||
              (lVar6 = Component.GetComponent(lVar6,DAT_181d6af40)) == null))) throw; // [null/range check failed]
          Selectable.set_interactable(lVar6,!cVar2,0);
          if ((this.exchangeUIPanel == null) ||
             (lVar6 = GameObject.get_transform(this.exchangeUIPanel,0)) == null)
          throw; // [null/range check failed]
          lVar6 = Transform.Find(lVar6,"ClothList",0);
          uVar7 = Int32.ToString(local_res8,0);
          uVar7 = String.Concat("Cloth",uVar7,0);
          if ((lVar6 == null) ||
             (((lVar6 = Transform.Find(lVar6,uVar7,0), lVar6 == null ||
               (lVar6 = Transform.Find(lVar6,"UnlockButton",0)) == null) ||
              (lVar6 = Transform.Find(lVar6,"Cost",0)) == null))) throw; // [null/range check failed]
          uVar8 = Component.GetComponent(lVar6,DAT_181d6d8c0);
          uVar7 = "已获取";
          if (!cVar2) {
            local_res18[0] =
                 OtherForceContributionExchangeController.GetExchangeContributionCost
                           (this,local_res8[0],0x3f000000);
            uVar7 = Int32.ToString(local_res18,0);
            uVar7 = String.Concat("功绩 ",uVar7,0);
          }
          LTLocalization.SetText(uVar8,uVar7,0);
          if ((this.exchangeUIPanel == null) ||
             (lVar6 = GameObject.get_transform(this.exchangeUIPanel,0)) == null)
          throw; // [null/range check failed]
          lVar6 = Transform.Find(lVar6,"ClothList",0);
          uVar7 = Int32.ToString(local_res8,0);
          uVar7 = String.Concat("Cloth",uVar7,0);
          if ((lVar6 == null) ||
             (((lVar6 = Transform.Find(lVar6,uVar7,0), lVar6 == null ||
               (lVar6 = Transform.Find(lVar6,"UnlockButton",0)) == null) ||
              (lVar6 = Transform.Find(lVar6,"Cost",0)) == null))) throw; // [null/range check failed]
          plVar10 = (int64 *)Component.GetComponent(lVar6,DAT_181d6d8c0);
          if (!cVar2) {
            if (this.targetForceData == null) throw; // [null/range check failed]
            fVar1 = this.targetForceData.playerOutForceContribution;
            iVar12 = OtherForceContributionExchangeController.GetExchangeContributionCost
                               (this,local_res8[0],0x3f000000);
            if (fVar1 < (float)iVar12) {
              puVar11 = (uint64 *)Color.get_red(local_58,0);
            }
            else {
              puVar11 = (uint64 *)Color.get_black(local_78);
            }
          }
          else {
            puVar11 = (uint64 *)Color.get_black(local_68,0);
          }
          if (plVar10 == (int64 *)0) throw; // [null/range check failed]
          local_88 = *puVar11;
          uStack_80 = puVar11[1];
          (**(code **)(*plVar10 + 0x2a8))(plVar10,&local_88,*(uint64 *)(*plVar10 + 0x2b0));
          local_res8[0] = local_res8[0] + 1;
          if (5 < local_res8[0]) break;
        LAB_1804703c0:
          lVar6 = FUN_18046c0a0(0);
          if (((lVar6 == null) || (this.targetForceData == null)) || (*(int64 *)(lVar6 + 32) == 0)
             ) throw; // [null/range check failed]
        }
        lVar6 = FUN_18046c0a0(0);
        if (((lVar6 == null) || (*(int64 *)(lVar6 + 32) == 0)) ||
           ((this.targetForceData == null ||
            (lVar6 = *(int64 *)(*(int64 *)(lVar6 + 32) + 0x180)) == null)))
        throw; // [null/range check failed]
        cVar2 = FUN_181815240(lVar6,this.targetForceData.speBuildingID,DAT_181d67bf8);
        if ((((this.exchangeUIPanel == null) ||
             (lVar6 = GameObject.get_transform(this.exchangeUIPanel,0)) == null) ||
            (lVar6 = Transform.Find(lVar6,"SpeBuilding",0)) == null) ||
           ((lVar6 = Transform.Find(lVar6,"UnlockButton",0), lVar6 == null ||
            (lVar6 = Component.GetComponent(lVar6,DAT_181d6af40)) == null))) throw; // [null/range check failed]
        Selectable.set_interactable(lVar6,!cVar2,0);
        if (((this.exchangeUIPanel == null) ||
            ((lVar6 = GameObject.get_transform(this.exchangeUIPanel,0), lVar6 == null ||
             (lVar6 = Transform.Find(lVar6,"SpeBuilding",0)) == null))) ||
           ((lVar6 = Transform.Find(lVar6,"UnlockButton",0), lVar6 == null ||
            (lVar6 = Transform.Find(lVar6,"Cost",0)) == null))) throw; // [null/range check failed]
        uVar8 = Component.GetComponent(lVar6,DAT_181d6d8c0);
        uVar7 = "已获取";
        if (!cVar2) {
          cVar3 = OtherForceContributionExchangeController.ForceIsPlayerServant(this,0);
          if (!cVar3) {
            auVar14._0_8_ = FUN_1801f7f00();
            auVar14._8_8_ = extraout_XMM0_Qb;
            auVar15._4_12_ = auVar14._4_12_;
            auVar15._0_4_ = (float)auVar14._0_8_ * 50.0;
            local_res18[0] = Mathf.RoundToInt(auVar15._0_8_,0);
          }
          else {
            local_res18[0] = 0;
          }
          uVar7 = Int32.ToString(local_res18,0);
          uVar7 = String.Concat("功绩 ",uVar7,0);
        }
        LTLocalization.SetText(uVar8,uVar7,0);
        if ((((this.exchangeUIPanel == null) ||
             (lVar6 = GameObject.get_transform(this.exchangeUIPanel,0)) == null) ||
            (lVar6 = Transform.Find(lVar6,"SpeBuilding",0)) == null) ||
           ((lVar6 = Transform.Find(lVar6,"UnlockButton",0), lVar6 == null ||
            (lVar6 = Transform.Find(lVar6,"Cost",0)) == null))) throw; // [null/range check failed]
        plVar10 = (int64 *)Component.GetComponent(lVar6,DAT_181d6d8c0);
        if (!cVar2) {
          if (this.targetForceData == null) throw; // [null/range check failed]
          fVar1 = this.targetForceData.playerOutForceContribution;
          cVar2 = OtherForceContributionExchangeController.ForceIsPlayerServant(this,0);
          if (!cVar2) {
            auVar16._0_8_ = FUN_1801f7f00();
            auVar16._8_8_ = extraout_XMM0_Qb_00;
            auVar17._4_12_ = auVar16._4_12_;
            auVar17._0_4_ = (float)auVar16._0_8_ * 50.0;
            iVar5 = Mathf.RoundToInt(auVar17._0_8_,0);
          }
          if ((float)iVar5 > fVar1)
          {
            puVar11 = (uint64 *)Color.get_red(local_58,0);
            }
            else {
          }
          puVar11 = (uint64 *)Color.get_black(local_58,0);
        }
        if (plVar10 != (int64 *)0) {
          local_88 = *puVar11;
          uStack_80 = puVar11[1];
          (**(code **)(*plVar10 + 0x2a8))(plVar10,&local_88,*(uint64 *)(*plVar10 + 0x2b0));
          return;
        }
    }

    // Token : 0x6001915
    // RVA   : 0x46F130   Offset: 0x46D930   Length: 0xB89
    public void ExchangeSkillClicked(KungfuSkillLvData targetSkill)
    {
        var pStatics_a268 = *(int64*)(DAT_181d6a268 + 184);
        var pStatics_c960 = *(int64*)(DAT_181d6c960 + 184);
        var pStatics_df90 = *(int64*)(DAT_181d4df90 + 184);
        var pStatics_ef00 = *(int64*)(DAT_181d4ef00 + 184);
        void OtherForceContributionExchangeController.ExchangeSkillClicked
                     (int64 this,int64 targetSkill)
        {
        uint32 uVar1;
        char cVar2;
        int64 lVar3;
        int64 lVar4;
        int64 lVar5;
        uint64 uVar6;
        uint64 uVar7;
        uint64 uVar8;
        float fVar9;
        uint32 local_res20 [2];
        if ((((*pStatics_df90 == 0) ||
             (lVar3 = *(int64 *)(*pStatics_df90 + 32)) == null) ||
            (lVar3 = WorldData.Player(lVar3,0), targetSkill == null)) || (lVar3 == null)) goto LAB_18046fca2;
        lVar3 = HeroData.FindSkill(lVar3,*(uint32 *)(targetSkill + 16),0);
        if (lVar3 != null) {
          if (*pStatics_df90 != 0) {
            GameController.ShowTextOnMouse(*pStatics_df90,"已学会！",0);
            return;
          }
          goto LAB_18046fca2;
        }
        cVar2 = OtherForceContributionExchangeController.ForceIsPlayerServant(this,0);
        if (!cVar2) {
          lVar3 = FUN_18046c0a0(0);
          if (((lVar3 == null) || (*(int64 *)(lVar3 + 32) == 0)) ||
             (lVar3 = WorldData.Player(*(int64 *)(lVar3 + 32),0)) == null) goto LAB_18046fca2;
          fVar9 = *(float *)(lVar3 + 0x1c4);
          lVar3 = *pStatics_a268;
          lVar4 = KungfuSkillLvData.DataBase(targetSkill,0);
          if ((lVar4 == null) || (lVar3 == null)) goto LAB_18046fca2;
          uVar1 = *(uint32 *)(lVar4 + 52);
          if (*(uint32 *)(lVar3 + 24) <= uVar1) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          if (fVar9 < lVar3[uVar1]) {
            lVar3 = FUN_18046c440(0);
            lVar4 = *pStatics_a268;
            lVar5 = KungfuSkillLvData.DataBase(targetSkill,0);
            if ((lVar5 == null) || (lVar4 == null)) {
        LAB_18046fca8:
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            uVar1 = *(uint32 *)(lVar5 + 52);
            if (*(uint32 *)(lVar4 + 24) <= uVar1) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            local_res20[0] =
                 lVar4[uVar1];
            uVar6 = il2cpp_value_box(DAT_181d7d0b8,local_res20);
            lVar4 = *(int64 *)(pStatics_ef00 + 0x4f0);
            lVar5 = KungfuSkillLvData.DataBase(targetSkill,0);
            if ((lVar5 == null) || (lVar4 == null)) goto LAB_18046fca8;
            uVar1 = *(uint32 *)(lVar5 + 52);
            if (*(uint32 *)(lVar4 + 24) <= uVar1) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            uVar6 = String.Format("#PlayerName#的江湖声望太低，若将本门{1}武学托付于你，只怕难以服众。\n(需要至少{0}点声望。)",uVar6,
                                   *(uint64 *)
                                    (*(int64 *)(lVar4 + 16) + 32 + (int64)(int)uVar1 * 8),0);
            lVar4 = il2cpp_internal(DAT_181d72a30);
            FUN_180f58a90(lVar4,DAT_181d7c250);
            if (lVar4 == null) goto LAB_18046fca8;
            FUN_181827900(lVar4,"是我唐突了;HideInteractUI",DAT_181d7c3d0);
            lVar5 = FUN_18046bac0(0);
            if (((lVar5 == null) || (*(int64 *)(lVar5 + 88) == 0)) ||
               (lVar5 = AreaData.GetForce(*(int64 *)(lVar5 + 88),0)) == null)
            goto LAB_18046fca8;
            uVar7 = Int32.ToString(lVar5 + 88,0);
            var uVar8 = new SinglePlotData(uVar6,lVar4,3,uVar7,3,"0",0,0,0);
            if (lVar3 == null) goto LAB_18046fca8;
            goto LAB_18046f61a;
          }
        }
        cVar2 = OtherForceContributionExchangeController.ForceIsPlayerServant(this,0);
        if (!cVar2) {
          lVar3 = *(int64 *)(pStatics_a268 + 8);
          lVar4 = KungfuSkillLvData.DataBase(targetSkill,0);
          if ((lVar4 == null) || (lVar3 == null)) goto LAB_18046fca2;
          uVar1 = *(uint32 *)(lVar4 + 52);
          if (*(uint32 *)(lVar3 + 24) <= uVar1) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          if (0.0 < lVar3[uVar1]) {
            lVar3 = FUN_18046bac0(0);
            if ((((lVar3 == null) || (*(int64 *)(lVar3 + 88) == 0)) ||
                (lVar3 = AreaData.GetForce(*(int64 *)(lVar3 + 88),0)) == null) ||
               (lVar3 = ForceData.GetLeader(lVar3,0)) == null) {
        LAB_18046fca2:
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            fVar9 = (float)HeroData.Favor(lVar3,0,0);
            lVar3 = *(int64 *)(pStatics_a268 + 8);
            lVar4 = KungfuSkillLvData.DataBase(targetSkill,0);
            if ((lVar4 == null) || (lVar3 == null)) goto LAB_18046fca2;
            uVar1 = *(uint32 *)(lVar4 + 52);
            if (*(uint32 *)(lVar3 + 24) <= uVar1) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            if (fVar9 < lVar3[uVar1]) {
              lVar3 = FUN_18046c440(0);
              lVar4 = *(int64 *)(pStatics_a268 + 8);
              lVar5 = KungfuSkillLvData.DataBase(targetSkill,0);
              if ((lVar5 == null) || (lVar4 == null)) {
        LAB_18046fcae:
                          // WARNING: Subroutine does not return
                FUN_1800d6620();
              }
              local_res20[0] = FUN_1800d6780(lVar4,*(uint32 *)(lVar5 + 52),DAT_181d796d8);
              uVar6 = il2cpp_value_box(DAT_181d7d0b8,local_res20);
              lVar4 = *(int64 *)(pStatics_ef00 + 0x4f0);
              lVar5 = KungfuSkillLvData.DataBase(targetSkill,0);
              if ((lVar5 == null) || (lVar4 == null)) goto LAB_18046fcae;
              uVar8 = FUN_180002f80(lVar4,*(uint32 *)(lVar5 + 52),DAT_181d7c9c0);
              uVar6 = String.Format("本座与#PlayerName#你交情尚浅，恐怕还不能将本门{1}武学贸然托付于你。\n(需要至少{0}点掌门好感。)",uVar6,uVar8,0);
              lVar4 = il2cpp_internal(DAT_181d72a30);
              FUN_180f58a90(lVar4,DAT_181d7c250);
              if (lVar4 == null) goto LAB_18046fcae;
              FUN_181827900(lVar4,"是我唐突了;HideInteractUI",DAT_181d7c3d0);
              lVar5 = FUN_18046bac0(0);
              if (((lVar5 == null) || (*(int64 *)(lVar5 + 88) == 0)) ||
                 (lVar5 = AreaData.GetForce(*(int64 *)(lVar5 + 88),0)) == null)
              goto LAB_18046fcae;
              uVar7 = Int32.ToString(lVar5 + 88,0);
              var uVar8 = new SinglePlotData(uVar6,lVar4,3,uVar7,3,"0",0,0,0);
              if (lVar3 == null) goto LAB_18046fcae;
              goto LAB_18046f61a;
            }
          }
        }
        if (*pStatics_c960 != 0) {
          PlotController.SetPlotSkill(*pStatics_c960,targetSkill,1,0);
          lVar3 = *pStatics_c960;
          uVar6 = KungfuSkillLvData.Name(targetSkill,1,0);
          lVar4 = KungfuSkillLvData.DataBase(targetSkill,0);
          if (lVar4 != null) {
            cVar2 = OtherForceContributionExchangeController.ForceIsPlayerServant(this,0);
            local_res20[0] = 0;
            if (!cVar2) {
              fVar9 = (float)FUN_1801f7f00(0x40000000);
              local_res20[0] = Mathf.RoundToInt(fVar9 * 50.0,0);
            }
            uVar8 = il2cpp_value_box(DAT_181d5b2f8,local_res20);
            uVar6 = String.Format("#PlayerName#想要学习本门的{0}吗？\n#PlayerName#虽非本门弟子，但在江湖中声名显赫，且与本座私交甚笃。\n因此若能为本门立下{1}点功绩，倒也可破例而为。",uVar6,uVar8,0);
            lVar4 = il2cpp_internal(DAT_181d72a30);
            FUN_180f58a90(lVar4,DAT_181d7c250);
            uVar8 = Int32.ToString(targetSkill + 16,0);
            uVar8 = String.Concat("兑换该武学;SureExchangeOtherForceSkill;",uVar8,0);
            if (lVar4 != null) {
              FUN_181827900(lVar4,uVar8,DAT_181d7c3d0);
              FUN_181827900(lVar4,"还是算了;HideInteractUI",DAT_181d7c3d0);
              if (this.targetForceData != null) {
                uVar7 = Int32.ToString(this.targetForceData + 88,0);
                var uVar8 = new SinglePlotData(uVar6,lVar4,3,uVar7,3,"0",0,0,0);
                if (lVar3 != null) {
        LAB_18046f61a:
                  PlotController.ChangePlot(lVar3,uVar8,0,0);
                  return;
                }
              }
            }
          }
        }
    }

    // Token : 0x6001916
    // RVA   : 0x472460   Offset: 0x470C60   Length: 0xA10
    public void UnlockClothButtonClicked(int lv)
    {
        var pStatics_a268 = *(int64*)(DAT_181d6a268 + 184);
        var pStatics_df90 = *(int64*)(DAT_181d4df90 + 184);
        var pStatics_ef00 = *(int64*)(DAT_181d4ef00 + 184);
        void OtherForceContributionExchangeController.UnlockClothButtonClicked
                     (int64 this,uint32 lv)
        {
        char cVar1;
        int iVar2;
        int64 *plVar3;
        int64 lVar4;
        uint64 uVar5;
        int64 lVar6;
        uint64 uVar7;
        uint64 uVar8;
        int64 lVar9;
        int64 *plVar10;
        float fVar11;
        uint8 auVar12 [16];
        uint8 auVar13 [16];
        uint8 auVar14 [16];
        uint8 auVar15 [16];
        uint32 local_res20 [2];
        uint64 extraout_XMM0_Qb;
        uint64 extraout_XMM0_Qb_00;
        lVar9 = (int64)(int)lv;
        cVar1 = OtherForceContributionExchangeController.ForceIsPlayerServant(this,0);
        iVar2 = 0;
        if (!cVar1) {
          if (this.targetForceData == null) throw; // [null/range check failed]
          fVar11 = this.targetForceData.playerOutForceContribution;
          cVar1 = OtherForceContributionExchangeController.ForceIsPlayerServant(this,0);
          if (!cVar1) {
            auVar12._0_8_ = FUN_1801f7f00();
            auVar12._8_8_ = extraout_XMM0_Qb;
            auVar13._4_12_ = auVar12._4_12_;
            auVar13._0_4_ = (float)auVar12._0_8_ * 50.0 * 0.5;
            iVar2 = Mathf.RoundToInt(auVar13._0_8_,0);
          }
          if (fVar11 < (float)iVar2) {
            lVar9 = FUN_18046c0a0(0);
            if (lVar9 != null) {
              GameController.ShowTextOnMouse(lVar9,"功绩不足！",0);
              plVar3 = (int64 *)Resources.Load("Sound/SoundEffect/WrongClick",0);
              plVar10 = (int64 *)0;
              if ((plVar3 != (int64 *)0) && (*plVar3 == DAT_181d8a228)) {
                plVar10 = plVar3;
              }
              NGUITools.PlaySound(plVar10,0);
              return;
            }
            throw; // [null/range check failed]
          }
        }
        cVar1 = OtherForceContributionExchangeController.ForceIsPlayerServant(this,0);
        if (!cVar1) {
          if (((*pStatics_df90 == 0) ||
              (lVar4 = *(int64 *)(*pStatics_df90 + 32)) == null) ||
             (lVar4 = WorldData.Player(lVar4,0)) == null) throw; // [null/range check failed]
          fVar11 = *(float *)(lVar4 + 0x1c4);
          lVar4 = *pStatics_a268;
          if (lVar4 == null) throw; // [null/range check failed]
          if (lVar4.forceName <= lv) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          if (fVar11 < *(float *)(lVar4.forceID + 32 + lVar9 * 4)) {
            lVar4 = FUN_18046c440(0);
            lVar6 = *pStatics_a268;
            if (lVar6 == null) {
        LAB_180472e65:
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            if (*(uint32 *)(lVar6 + 24) <= lv) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            local_res20[0] = *(uint32 *)(*(int64 *)(lVar6 + 16) + 32 + lVar9 * 4);
            uVar5 = il2cpp_value_box(DAT_181d7d0b8,local_res20);
            lVar6 = *(int64 *)(pStatics_ef00 + 0x3d0);
            if (lVar6 == null) goto LAB_180472e65;
            if (*(uint32 *)(lVar6 + 24) <= lv) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            uVar5 = String.Format("#PlayerName#的江湖声望太低，若将本门{1}服饰托付于你，只怕难以服众。\n(需要至少{0}点声望)",uVar5,
                                   *(uint64 *)(*(int64 *)(lVar6 + 16) + 32 + lVar9 * 8),0);
            lVar9 = il2cpp_internal(DAT_181d72a30);
            FUN_180f58a90(lVar9,DAT_181d7c250);
            if (lVar9 == null) goto LAB_180472e65;
            FUN_181827900(lVar9,"是我唐突了;HideInteractUI",DAT_181d7c3d0);
            lVar6 = FUN_18046bac0(0);
            if (((lVar6 == null) || (*(int64 *)(lVar6 + 88) == 0)) ||
               (lVar6 = AreaData.GetForce(*(int64 *)(lVar6 + 88),0)) == null)
            goto LAB_180472e65;
            uVar7 = Int32.ToString(lVar6 + 88,0);
            var uVar8 = new SinglePlotData(uVar5,lVar9,3,uVar7,3,"0",0,0,0);
            if (lVar4 == null) goto LAB_180472e65;
            goto LAB_1804729a2;
          }
        }
        cVar1 = OtherForceContributionExchangeController.ForceIsPlayerServant(this,0);
        if (!cVar1) {
          lVar4 = *(int64 *)(pStatics_a268 + 8);
          if (lVar4 == null) throw; // [null/range check failed]
          if (lVar4.forceName <= lv) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          if (0.0 < *(float *)(lVar4.forceID + 32 + lVar9 * 4)) {
            lVar4 = FUN_18046bac0(0);
            if ((((lVar4 == null) || (lVar4.leader == null)) ||
                (lVar4 = AreaData.GetForce(lVar4.leader,0)) == null) ||
               (lVar4 = ForceData.GetLeader(lVar4,0)) == null) throw; // [null/range check failed]
            fVar11 = (float)HeroData.Favor(lVar4,0,0);
            lVar4 = *(int64 *)(pStatics_a268 + 8);
            if (lVar4 == null) throw; // [null/range check failed]
            if (lVar4.forceName <= lv) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            if (fVar11 < *(float *)(lVar4.forceID + 32 + lVar9 * 4)) {
              lVar4 = FUN_18046c440(0);
              lVar6 = *(int64 *)(pStatics_a268 + 8);
              if (lVar6 != null) {
                if (*(uint32 *)(lVar6 + 24) <= lv) {
                  ThrowHelper.ThrowArgumentOutOfRangeException(0);
                }
                local_res20[0] = *(uint32 *)(*(int64 *)(lVar6 + 16) + 32 + lVar9 * 4);
                uVar5 = il2cpp_value_box(DAT_181d7d0b8,local_res20);
                lVar6 = *(int64 *)(pStatics_ef00 + 0x3d0);
                if (lVar6 != null) {
                  if (*(uint32 *)(lVar6 + 24) <= lv) {
                    ThrowHelper.ThrowArgumentOutOfRangeException(0);
                  }
                  uVar5 = String.Format("本座与#PlayerName#你交情尚浅，恐怕还不能将本门{1}服饰贸然托付于你。\n(需要至少{0}点掌门好感)",uVar5,
                                         *(uint64 *)(*(int64 *)(lVar6 + 16) + 32 + lVar9 * 8),0
                                        );
                  lVar9 = il2cpp_internal(DAT_181d72a30);
                  FUN_180f58a90(lVar9,DAT_181d7c250);
                  if (lVar9 != null) {
                    FUN_181827900(lVar9,"是我唐突了;HideInteractUI",DAT_181d7c3d0);
                    lVar6 = FUN_18046bac0(0);
                    if (((lVar6 != null) && (*(int64 *)(lVar6 + 88) != 0)) &&
                       (lVar6 = AreaData.GetForce(*(int64 *)(lVar6 + 88),0)) != null) {
                      uVar7 = Int32.ToString(lVar6 + 88,0);
                      var uVar8 = new SinglePlotData(uVar5,lVar9,3,uVar7,3,"0",0,0,0);
                      if (lVar4 != null) {
        LAB_1804729a2:
                        PlotController.ChangePlot(lVar4,uVar8,0,0);
                        return;
                      }
                    }
                  }
                }
              }
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
          }
        }
        if ((*pStatics_df90 != 0) &&
           (lVar9 = *(int64 *)(*pStatics_df90 + 32)) != null) {
          lVar9 = WorldData.Player(lVar9,0);
          cVar1 = OtherForceContributionExchangeController.ForceIsPlayerServant(this,0);
          if (!cVar1) {
            auVar14._0_8_ = FUN_1801f7f00();
            auVar14._8_8_ = extraout_XMM0_Qb_00;
            auVar15._4_12_ = auVar14._4_12_;
            auVar15._0_4_ = (float)auVar14._0_8_ * 50.0 * 0.5;
            Mathf.RoundToInt(auVar15._0_8_,0);
          }
          lVar4 = this.targetForceData;
          if ((lVar4 != null) && (lVar9 != null)) {
            HeroData.ChangeForceContribution(lVar9,lVar4,1,lVar4.forceID,0);
            if (((*pStatics_df90 != 0) && (this.targetForceData != null)) &&
               (lVar9 = *(int64 *)(*pStatics_df90 + 32)) != null) {
              WorldData.UnlockSkin
                        (lVar9,this.targetForceData.defaultSkinID,lv,1,0);
              OtherForceContributionExchangeController.RefreshExchangeUI(this,0);
              return;
            }
          }
        }
    }

    // Token : 0x6001917
    // RVA   : 0x471B50   Offset: 0x470350   Length: 0x903
    public void SpeBuildingButtonClicked()
    {
        var pStatics_a268 = *(int64*)(DAT_181d6a268 + 184);
        var pStatics_df90 = *(int64*)(DAT_181d4df90 + 184);
        bool cVar1;
        int iVar2;
        long lVar3;
        ulong uVar5;
        long lVar6;
        long lVar7;
        ulong uVar8;
        ulong uVar9;
        float fVar11;
        byte[] auVar12 = new byte[16];
        byte[] auVar13 = new byte[16];
        byte[] auVar14 = new byte[16];
        byte[] auVar15 = new byte[16];
        uint[] local_res18 = new uint[2];
        uint64 extraout_XMM0_Qb;
        uint64 extraout_XMM0_Qb_00;
        cVar1 = OtherForceContributionExchangeController.ForceIsPlayerServant(this,0);
        iVar2 = 0;
        if (!cVar1) {
          if (this.targetForceData == null) throw; // [null/range check failed]
          fVar11 = this.targetForceData.playerOutForceContribution;
          cVar1 = OtherForceContributionExchangeController.ForceIsPlayerServant(this,0);
          if (!cVar1) {
            auVar12._0_8_ = FUN_1801f7f00();
            auVar12._8_8_ = extraout_XMM0_Qb;
            auVar13._4_12_ = auVar12._4_12_;
            auVar13._0_4_ = (float)auVar12._0_8_ * 50.0;
            iVar2 = Mathf.RoundToInt(auVar13._0_8_,0);
          }
          if (fVar11 < (float)iVar2) {
            lVar3 = FUN_18046c0a0(0);
            if (lVar3 != null) {
              GameController.ShowTextOnMouse(lVar3,"功绩不足！",0);
              plVar4 = (int64 *)Resources.Load("Sound/SoundEffect/WrongClick",0);
              plVar10 = (int64 *)0;
              if ((plVar4 != (int64 *)0) && (*plVar4 == DAT_181d8a228)) {
                plVar10 = plVar4;
              }
              NGUITools.PlaySound(plVar10,0);
              return;
            }
            throw; // [null/range check failed]
          }
        }
        cVar1 = OtherForceContributionExchangeController.ForceIsPlayerServant(this,0);
        if (!cVar1) {
          if (((*pStatics_df90 == 0) ||
              (lVar3 = *(int64 *)(*pStatics_df90 + 32)) == null) ||
             (lVar3 = WorldData.Player(lVar3,0)) == null) throw; // [null/range check failed]
          fVar11 = *(float *)(lVar3 + 0x1c4);
          lVar3 = *pStatics_a268;
          if (lVar3 == null) throw; // [null/range check failed]
          if (*(uint32 *)(lVar3 + 24) < 6) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          if (fVar11 < *(float *)(*(int64 *)(lVar3 + 16) + 52)) {
            lVar3 = FUN_18046c440(0);
            lVar6 = *pStatics_a268;
            if (lVar6 == null) {
        LAB_180472448:
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            if (lVar6.forceName < 6) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            local_res18[0] = *(uint32 *)(lVar6.forceID + 52);
            uVar5 = il2cpp_value_box(DAT_181d7d0b8,local_res18);
            uVar5 = String.Format("#PlayerName#的江湖声望太低，若将本门特殊建筑托付于你，只怕难以服众。\n(需要至少{0}点声望)",uVar5,0);
            lVar6 = il2cpp_internal(DAT_181d72a30);
            FUN_180f58a90(lVar6,DAT_181d7c250);
            if (lVar6 == null) goto LAB_180472448;
            FUN_181827900(lVar6,"是我唐突了;HideInteractUI",DAT_181d7c3d0);
            lVar7 = FUN_18046bac0(0);
            if (((lVar7 == null) || (*(int64 *)(lVar7 + 88) == 0)) ||
               (lVar7 = AreaData.GetForce(*(int64 *)(lVar7 + 88),0)) == null)
            goto LAB_180472448;
            uVar8 = Int32.ToString(lVar7 + 88,0);
            uVar9 = new SinglePlotData(uVar5,lVar6,3,uVar8,3,"0",0,0,0);
            if (lVar3 == null) goto LAB_180472448;
            goto LAB_180472031;
          }
        }
        cVar1 = OtherForceContributionExchangeController.ForceIsPlayerServant(this,0);
        if (!cVar1) {
          lVar3 = FUN_18046bac0(0);
          if ((((lVar3 == null) || (*(int64 *)(lVar3 + 88) == 0)) ||
              (lVar3 = AreaData.GetForce(*(int64 *)(lVar3 + 88),0)) == null) ||
             (lVar3 = ForceData.GetLeader(lVar3,0)) == null) throw; // [null/range check failed]
          fVar11 = (float)HeroData.Favor(lVar3,0,0);
          lVar3 = *(int64 *)(pStatics_a268 + 8);
          if (lVar3 == null) throw; // [null/range check failed]
          if (*(uint32 *)(lVar3 + 24) < 6) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          if (fVar11 < *(float *)(*(int64 *)(lVar3 + 16) + 52)) {
            lVar3 = FUN_18046c440(0);
            lVar6 = *(int64 *)(pStatics_a268 + 8);
            if (lVar6 != null) {
              if (lVar6.forceName < 6) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              local_res18[0] = *(uint32 *)(lVar6.forceID + 52);
              uVar5 = il2cpp_value_box(DAT_181d7d0b8,local_res18);
              uVar5 = String.Format("本座与#PlayerName#你交情尚浅，恐怕还不能将本门特殊建筑贸然托付于你。\n(需要至少{0}点掌门好感)",uVar5,0);
              lVar6 = il2cpp_internal(DAT_181d72a30);
              FUN_180f58a90(lVar6,DAT_181d7c250);
              if (lVar6 != null) {
                FUN_181827900(lVar6,"是我唐突了;HideInteractUI",DAT_181d7c3d0);
                lVar7 = FUN_18046bac0(0);
                if (((lVar7 != null) && (*(int64 *)(lVar7 + 88) != 0)) &&
                   (lVar7 = AreaData.GetForce(*(int64 *)(lVar7 + 88),0)) != null) {
                  uVar8 = Int32.ToString(lVar7 + 88,0);
                  uVar9 = new SinglePlotData(uVar5,lVar6,3,uVar8,3,"0",0,0,0);
                  if (lVar3 != null) {
        LAB_180472031:
                    PlotController.ChangePlot(lVar3,uVar9,0,0);
                    return;
                  }
                }
              }
            }
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
        }
        if ((*pStatics_df90 != 0) &&
           (lVar3 = *(int64 *)(*pStatics_df90 + 32)) != null) {
          lVar3 = WorldData.Player(lVar3,0);
          cVar1 = OtherForceContributionExchangeController.ForceIsPlayerServant(this,0);
          if (!cVar1) {
            auVar14._0_8_ = FUN_1801f7f00();
            auVar14._8_8_ = extraout_XMM0_Qb_00;
            auVar15._4_12_ = auVar14._4_12_;
            auVar15._0_4_ = (float)auVar14._0_8_ * 50.0;
            Mathf.RoundToInt(auVar15._0_8_,0);
          }
          lVar6 = this.targetForceData;
          if ((lVar6 != null) && (lVar3 != null)) {
            HeroData.ChangeForceContribution(lVar3,lVar6,1,lVar6.forceID,0);
            if ((((*pStatics_df90 != 0) &&
                 (lVar3 = *(int64 *)(*pStatics_df90 + 32)) != null) &&
                (this.targetForceData != null)) &&
               (lVar3 = *(int64 *)(lVar3 + 0x180)) != null) {
              FUN_181814fa0(lVar3,this.targetForceData.speBuildingID,DAT_181d67a78);
              OtherForceContributionExchangeController.RefreshExchangeUI(this,0);
              return;
            }
          }
        }
    }

    // Token : 0x6001918
    // RVA   : 0x46FE50   Offset: 0x46E650   Length: 0x59
    public int GetExchangeContributionCost(int lv, float rate)
    {
        uint64
        OtherForceContributionExchangeController.GetExchangeContributionCost
                (uint32 this,uint64 lv,float rate)
        {
        char cVar1;
        uint64 uVar2;
        float fVar3;
        cVar1 = OtherForceContributionExchangeController.ForceIsPlayerServant(this,0);
        if (cVar1) {
          return 0;
        }
        fVar3 = (float)FUN_1801f7f00(0x40000000);
        uVar2 = Mathf.RoundToInt(fVar3 * 50.0 * rate,0);
        return uVar2;
    }

    // Token : 0x6001919
    // RVA   : 0x46FCC0   Offset: 0x46E4C0   Length: 0x186
    public bool ForceIsPlayerServant()
    {
        var pStatics = *(int64*)(DAT_181d4df90 + 184);
        int iVar1;
        long lVar2;
        if ((*pStatics != 0) &&
           (lVar2 = *(int64 *)(*pStatics + 32)) != null) {
          lVar2 = WorldData.Player(lVar2,0);
          if (lVar2 != null) {
            if (*(int *)(lVar2 + 132) < 0) {
              return false;
            }
            if (this.targetForceData != null) {
              iVar1 = this.targetForceData.masterForce;
              if ((*pStatics != 0) &&
                 (lVar2 = *(int64 *)(*pStatics + 32)) != null) {
                lVar2 = WorldData.Player(lVar2,0);
                if (lVar2 != null) {
                  return iVar1 == *(int *)(lVar2 + 132);
                }
              }
            }
          }
        }
    }

    // Token : 0x600191A
    // RVA   : 0x472E80   Offset: 0x471680   Length: 0x80
    public void UnshowExchangeUI()
    {
        ulong uVar1;
        this.targetForceData = 0;
        if (this.exchangeUIPanel != null) {
          GameObject.SetActive(this.exchangeUIPanel,0,0);
          uVar1 = this.exchangeSkillGrid;
          GlobalData.DeleteAllChild(uVar1,0);
          return;
        }
    }

    // Token : 0x600191B
    // RVA   : 0x3A17B0   Offset: 0x39FFB0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_18044ef50(this,0);
    }

    // Token : 0x600191C
    // RVA   : 0x472F10   Offset: 0x471710   Length: 0x1D9
    private static void /*cctor*/()
    {
        var pStatics = *(int64*)(DAT_181d6a268 + 184);
        long lVar1;
        lVar1 = il2cpp_internal(DAT_181d721b0);
        FUN_180f58a90(lVar1,DAT_181d79358);
        if (lVar1 != null) {
          FUN_181805690(lVar1,0x42c80000,DAT_181d79458);
          FUN_181805690(lVar1,0x43480000,DAT_181d79458);
          FUN_181805690(lVar1,0x43c80000,DAT_181d79458);
          FUN_181805690(lVar1,0x44480000,DAT_181d79458);
          FUN_181805690(lVar1,0x44c80000,DAT_181d79458);
          FUN_181805690(lVar1,0x45480000,DAT_181d79458);
          plVar2 = pStatics;
          *plVar2 = lVar1;
          il2cpp_internal(plVar2,lVar1);
          lVar1 = il2cpp_internal(DAT_181d721b0);
          FUN_180f58a90(lVar1,DAT_181d79358);
          if (lVar1 != null) {
            FUN_181805690(lVar1,0,DAT_181d79458);
            FUN_181805690(lVar1,0,DAT_181d79458);
            FUN_181805690(lVar1,0,DAT_181d79458);
            FUN_181805690(lVar1,0x41a00000,DAT_181d79458);
            FUN_181805690(lVar1,0x42480000,DAT_181d79458);
            FUN_181805690(lVar1,0x42c80000,DAT_181d79458);
            plVar2 = (int64 *)(pStatics + 8);
            *plVar2 = lVar1;
            il2cpp_internal(plVar2,lVar1);
            return;
          }
        }
    }

}
