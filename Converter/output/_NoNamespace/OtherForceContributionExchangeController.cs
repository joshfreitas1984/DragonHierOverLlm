// ============================================================
// Type  : OtherForceContributionExchangeController
// Token : 0x2000310
// ============================================================

public class OtherForceContributionExchangeController
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001939
    public ForceData targetForceData;

    // Token: 0x400193A
    public GameObject exchangeUIPanel;

    // Token: 0x400193B
    public GameObject exchangeSkillGrid;

    // Token: 0x400193C
    public GameObject contributionSkillUnlockButtonPrefab;

    // Token: 0x400193D
    public SkeletonGraphic buildingIcon;

    // Token: 0x400193E
    private GameObject temp;

    // Token: 0x400193F
    private static List<float> exchangeMinFame;

    // Token: 0x4001940
    private static List<float> exchangeMinFavor;

    // Token: 0x4001941
    private static OtherForceContributionExchangeController _instance;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6001970
    // RVA   : 0xB953E0   Offset: 0xB947E0   Length: 0x58
    public static OtherForceContributionExchangeController get_Instance()
    {
        return *(uint64 *)(*(int64 *)(DAT_181d8f490 + 184) + 16);
    }

    // Token : 0x6001971
    // RVA   : 0xB91220   Offset: 0xB90620   Length: 0xE0
    private void Awake()
    {
        ulong uVar1;
        bool cVar2;
        uVar1 = OtherForceContributionExchangeController._instance;
        cVar2 = Object.op_Equality(uVar1,0,0);
        if (cVar2) {
          OtherForceContributionExchangeController._instance = this;
        }
    }

    // Token : 0x6001972
    // RVA   : 0xB92C30   Offset: 0xB92030   Length: 0x121A
    public void ShowExchangeUI(ForceData targetForce)
    {
        var pStatics_2ee8 = *(int64*)(DAT_181d72ee8 + 184);
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
        ulong in_stack_ffffffffffffff28;
        ulong uVar13;
        uint uVar14;
        uint[] local_b8 = new uint[2];
        float local_b0;
        float fStack_ac;
        float local_a8;
        float local_98;
        uint64 local_88;
        float local_80;
        uint32 local_68;
        uint32 uStack_64;
        uint32 uStack_60;
        uint32 uStack_5c;
        plVar10 = (int64 *)0;
        local_res10[0] = 0;
        plVar3 = (int64 *)Resources.Load("Sound/SoundEffect/OpenBook",0);
        plVar11 = plVar10;
        if ((plVar3 != (int64 *)0) && (*plVar3 == DAT_181daf348)) {
          plVar11 = plVar3;
        }
        NGUITools.PlaySound(plVar11,0x3f800000,0x3f800000,0);
        this.targetForceData = targetForce;
        if (this.exchangeUIPanel != null) {
          GameObject.SetActive(this.exchangeUIPanel,1,0);
          if (((this.exchangeUIPanel != null) &&
              (lVar4 = GameObject.get_transform(this.exchangeUIPanel,0)) != null) &&
             (lVar4 = Transform.Find(lVar4,"ForceName",0)) != null) {
            uVar5 = Component.GetComponent(lVar4,DAT_181d96160);
            if (this.targetForceData != null) {
              uVar6 = ForceData.GetForceName(this.targetForceData,1,0);
              LTLocalization.SetText(uVar5,uVar6,0);
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
                plVar3 = (int64 *)Component.GetComponent(lVar4,DAT_181d94460);
                lVar4 = FUN_18046c100(0);
                if ((((lVar4 == null) || (lVar4.mainAreaID == null)) ||
                    (lVar4 = FUN_180002f80(lVar4.mainAreaID,local_res8[0],DAT_181d9e108),
                    lVar4 == null)) || (plVar3 == (int64 *)0)) throw; // [null/range check failed]
                local_68 = lVar4.forceName;
                uStack_64 = *(uint32 *)(lVar4 + 28);
                uStack_60 = lVar4.defaultSkinID;
                uStack_5c = lVar4.bigForce;
                (**(code **)(*plVar3 + 0x2a8))(plVar3,&local_68,*(uint64 *)(*plVar3 + 0x2b0));
                if ((this.exchangeUIPanel == null) ||
                   (lVar4 = GameObject.get_transform(this.exchangeUIPanel,0)) == null)
                throw; // [null/range check failed]
                lVar4 = Transform.Find(lVar4,"ExchangeNeeds",0);
                uVar5 = Int32.ToString(local_res8,0);
                if ((lVar4 == null) ||
                   ((lVar4 = Transform.Find(lVar4,uVar5,0), lVar4 == null ||
                    (lVar4 = Transform.Find(lVar4,"Name",0)) == null))) throw; // [null/range check failed]
                uVar5 = Component.GetComponent(lVar4,DAT_181d96160);
                lVar4 = *(int64 *)(*(int64 *)(DAT_181d73d40 + 184) + 0x4f8);
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
                uVar5 = Component.GetComponent(lVar4,DAT_181d96160);
                cVar2 = OtherForceContributionExchangeController.ForceIsPlayerServant(this,0);
                if (!cVar2) {
                  if (OtherForceContributionExchangeController.exchangeMinFame == null) {
        LAB_180b93e30:
                          // WARNING: Subroutine does not return
                    FUN_1800d6620();
                  }
                  local_res20[0] =
                       FUN_1800d6790(OtherForceContributionExchangeController.exchangeMinFame,local_res8[0],DAT_181da1078);
                  uVar6 = il2cpp_value_box(DAT_181da22d8,local_res20);
                  lVar4 = OtherForceContributionExchangeController.exchangeMinFavor;
                  if (lVar4 == null) goto LAB_180b93e30;
                  fVar12 = (float)FUN_1800d6790(lVar4,local_res8[0],DAT_181da1078);
                  uVar1 = "{0}点声望{1}";
                  uVar7 = "";
                  if (0.0 < fVar12) {
                    lVar4 = OtherForceContributionExchangeController.exchangeMinFavor;
                    if (lVar4 == null) {
                          // WARNING: Subroutine does not return
                      FUN_1800d6620();
                    }
                    local_b8[0] = FUN_1800d6790(lVar4,local_res8[0],DAT_181da1078);
                    uVar7 = il2cpp_value_box(DAT_181da22d8,local_b8);
                    uVar7 = String.Format(" {0}点掌门好感",uVar7,0);
                  }
                  String.Format(uVar1,uVar6,uVar7,0);
                }
                LTLocalization.SetText(uVar5);
                local_res8[0] = local_res8[0] + 1;
              } while (local_res8[0] < 6);
              lVar4 = this.targetForceData;
              plVar3 = plVar10;
              if (lVar4 != null) {
                while( true ) {
                  uVar14 = (uint32)((uint64)in_stack_ffffffffffffff28 >> 32);
                  if ((lVar4.bookStorage == null) ||
                     (lVar9 = *(int64 *)(lVar4.bookStorage + 40)) == null)
                  throw; // [null/range check failed]
                  if (*(int *)(lVar9 + 24) <= (int)plVar3) break;
                  uVar5 = this.exchangeSkillGrid;
                  if (*pStatics_2ee8 == 0) throw; // [null/range check failed]
                  uVar6 = *(uint64 *)(*pStatics_2ee8 + 168);
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
                     (lVar4 = GameObject.GetComponent(this.temp,DAT_181d73800),
                     lVar4 == null)) throw; // [null/range check failed]
                  lVar4.defaultSkinID = uVar5;
                  if ((this.temp == null) ||
                     (lVar4 = GameObject.GetComponent(this.temp,DAT_181d73800),
                     lVar4 == null)) throw; // [null/range check failed]
                  lVar4.forceStyle = 2;
                  lVar4 = GlobalData.AddChild
                                    (this.temp,this.contributionSkillUnlockButtonPrefab);
                  if (lVar4 == null) throw; // [null/range check failed]
                  Object.set_name(lVar4,"UnlockButton");
                  lVar4 = GameObject.get_transform(lVar4,0);
                  puVar8 = (uint64 *)Vector3.get_down(&local_68,0);
                  local_98 = *(float *)(puVar8 + 1);
                  fStack_ac = (float)((uint64)*puVar8 >> 32) * 75.0;
                  local_b0 = (float)*puVar8 * 75.0;
                  local_a8 = local_98 * 75.0;
                  if (lVar4 == null) throw; // [null/range check failed]
                  local_88 = CONCAT44(fStack_ac,local_b0);
                  local_80 = local_a8;
                  Transform.set_localPosition(lVar4,&local_88);
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
                      goto LAB_180b93a44;
                    }
                  }
                  else if (((lVar9 != null) && (lVar4 = GameObject.get_transform(lVar9,0)) != null) &&
                          (lVar4 = Transform.Find(lVar4,"ClothList",0)) != null) {
                    lVar4 = Component.get_gameObject(lVar4,0);
                    if (lVar4 != null) {
                      GameObject.SetActive(lVar4,1,0);
                      goto LAB_180b93690;
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
          uVar5 = Component.GetComponent(lVar4,DAT_181d96160);
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
          plVar3 = (int64 *)Component.GetComponent(lVar4,DAT_181d94460);
          lVar4 = FUN_18046c100(0);
          if ((((lVar4 == null) || (lVar4.mainAreaID == null)) ||
              (lVar4 = FUN_180002f80(lVar4.mainAreaID,local_res10[0],DAT_181d9e108), lVar4 == null
              )) || (plVar3 == (int64 *)0)) throw; // [null/range check failed]
          local_68 = lVar4.forceName;
          uStack_64 = *(uint32 *)(lVar4 + 28);
          uStack_60 = lVar4.defaultSkinID;
          uStack_5c = lVar4.bigForce;
          (**(code **)(*plVar3 + 0x2a8))(plVar3,&local_68,*(uint64 *)(*plVar3 + 0x2b0));
          if ((this.exchangeUIPanel == null) ||
             (lVar4 = GameObject.get_transform(this.exchangeUIPanel,0)) == null)
          throw; // [null/range check failed]
          lVar4 = Transform.Find(lVar4,"ClothList",0);
          uVar5 = Int32.ToString(local_res10,0);
          uVar5 = String.Concat("Cloth",uVar5,0);
          if ((lVar4 == null) ||
             ((lVar4 = Transform.Find(lVar4,uVar5,0), lVar4 == null ||
              (lVar4 = Transform.Find(lVar4,"UnlockButton",0)) == null))) throw; // [null/range check failed]
          lVar4 = Component.GetComponent(lVar4,DAT_181d95560);
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
        LAB_180b93690:
          if ((this.exchangeUIPanel == null) ||
             (lVar4 = GameObject.get_transform(this.exchangeUIPanel,0)) == null)
          throw; // [null/range check failed]
        }
        LAB_180b93a44:
        if (**(int **)(DAT_181d73d40 + 184) != 2) {
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
              uVar5 = Component.GetComponent(lVar4,DAT_181d96160);
              lVar4 = FUN_18046c100(0);
              if (((lVar4 == null) || (this.targetForceData == null)) ||
                 ((lVar4.allyForce == null ||
                  (lVar4 = FUN_1817d9e10(lVar4.allyForce,
                                         this.targetForceData.speBuildingID,
                                         DAT_181db7bd8), lVar4 == null)))) throw; // [null/range check failed]
              uVar6 = lVar4.forceName;
              LTLocalization.SetText(uVar5,uVar6,0);
              lVar4 = this.buildingIcon;
              lVar9 = FUN_18046c100(0);
              if ((((lVar9 == null) || (this.targetForceData == null)) ||
                  (*(int64 *)(lVar9 + 224) == 0)) ||
                 (lVar9 = FUN_1817d9e10(*(int64 *)(lVar9 + 224),
                                        this.targetForceData.speBuildingID,
                                        DAT_181db7bd8), lVar9 == null)) throw; // [null/range check failed]
              uVar5 = String.Concat("Skeleton/Building/",*(uint64 *)(lVar9 + 32),"/skeleton_SkeletonData",0);
              plVar3 = (int64 *)Resources.Load(uVar5,0);
              if (lVar4 == null) throw; // [null/range check failed]
              if (plVar3 != (int64 *)0) {
              }
              lVar4.forceFavorDict = plVar10;
              if (this.buildingIcon == null) throw; // [null/range check failed]
              SkeletonGraphic.Initialize(this.buildingIcon,1,0);
              if (((this.exchangeUIPanel == null) ||
                  (lVar4 = GameObject.get_transform(this.exchangeUIPanel,0)) == null) ||
                 ((lVar4 = Transform.Find(lVar4,"SpeBuilding",0), lVar4 == null ||
                  (lVar4 = Transform.Find(lVar4,"UnlockButton",0)) == null))) throw; // [null/range check failed]
              lVar4 = Component.GetComponent(lVar4,DAT_181d95560);
              lVar9 = FUN_18046c100(0);
              if ((((lVar9 == null) || (this.targetForceData == null)) ||
                  (*(int64 *)(lVar9 + 224) == 0)) ||
                 ((lVar9 = FUN_1817d9e10(*(int64 *)(lVar9 + 224),
                                         this.targetForceData.speBuildingID,
                                         DAT_181db7bd8), lVar9 == null ||
                  (uVar5 = AreaBuildingDataBase.GetBuildingText
                                     (lVar9,0,1,1,CONCAT44(uVar14,0x3f800000),1,0,0), lVar4 == null))))
              throw; // [null/range check failed]
              lVar4.forceName = uVar5;
              goto LAB_180b93dfc;
            }
            throw; // [null/range check failed]
          }
        }
        if (((this.exchangeUIPanel != null) &&
            (lVar4 = GameObject.get_transform(this.exchangeUIPanel,0)) != null) &&
           ((lVar4 = Transform.Find(lVar4,"SpeBuilding",0), lVar4 != null &&
            (lVar4 = Component.get_gameObject(lVar4,0)) != null))) {
          GameObject.SetActive(lVar4,0,0);
        LAB_180b93dfc:
          OtherForceContributionExchangeController.RefreshExchangeUI(this,0);
          return;
        }
    }

    // Token : 0x6001973
    // RVA   : 0xB91FF0   Offset: 0xB913F0   Length: 0xC32
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
        int[] local_res18 = new int[4];
        ulong local_98;
        ulong uStack_90;
        byte[] local_88 = new byte[16];
        byte[] local_78 = new byte[16];
        byte[] local_68 = new byte[48];
        uint64 extraout_XMM0_Qb;
        uint64 extraout_XMM0_Qb_00;
        iVar5 = 0;
        local_res8[0] = 0;
        if (((this.exchangeUIPanel != null) &&
            (lVar6 = GameObject.get_transform(this.exchangeUIPanel,0)) != null) &&
           (lVar6 = Transform.Find(lVar6,"ForceContribution",0)) != null) {
          uVar7 = Component.GetComponent(lVar6,DAT_181d96160);
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
                if (iVar4 <= iVar12) goto LAB_180b92550;
                if (((this.exchangeSkillGrid == null) ||
                    (lVar6 = GameObject.get_transform(this.exchangeSkillGrid,0)) == null) ||
                   ((lVar6 = Transform.GetChild(lVar6,iVar12,0), lVar6 == null ||
                    (lVar6 = Component.GetComponent(lVar6,DAT_181d95ae0)) == null))) break;
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
                     (lVar9 = Component.GetComponent(lVar9,DAT_181d93760)) == null))))) break;
                Selectable.set_interactable(lVar9,!bVar13,0);
                if ((this.exchangeSkillGrid == null) ||
                   ((((lVar9 = GameObject.get_transform(this.exchangeSkillGrid,0), lVar9 == null ||
                      (lVar9 = Transform.GetChild(lVar9,iVar12,0)) == null) ||
                     (lVar9 = Transform.Find(lVar9,"UnlockButton",0)) == null) ||
                    (lVar9 = Transform.Find(lVar9,"Cost",0)) == null))) break;
                uVar8 = Component.GetComponent(lVar9,DAT_181d96160);
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
                plVar10 = (int64 *)Component.GetComponent(lVar9,DAT_181d96160);
                if (bVar13) {
        LAB_180b924f4:
                  puVar11 = (uint64 *)Color.get_black(local_78,0);
                }
                else {
                  if (this.targetForceData == null) break;
                  fVar1 = this.targetForceData.playerOutForceContribution;
                  lVar6 = KungfuSkillLvData.DataBase(lVar6,0);
                  if (lVar6 == null) break;
                  iVar4 = OtherForceContributionExchangeController.GetExchangeContributionCost
                                    (this,*(uint32 *)(lVar6 + 52),0x3f800000);
                  if ((float)iVar4 <= fVar1) goto LAB_180b924f4;
                  puVar11 = (uint64 *)Color.get_red(local_88,0);
                }
                if (plVar10 == (int64 *)0) break;
                local_98 = *puVar11;
                uStack_90 = puVar11[1];
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
          if (((lVar6 == null) ||
              ((lVar6 = Transform.Find(lVar6,uVar7,0), lVar6 == null ||
               (lVar6 = Transform.Find(lVar6,"UnlockButton",0)) == null))) ||
             (lVar6 = Component.GetComponent(lVar6,DAT_181d93760)) == null) throw; // [null/range check failed]
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
          uVar8 = Component.GetComponent(lVar6,DAT_181d96160);
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
          plVar10 = (int64 *)Component.GetComponent(lVar6,DAT_181d96160);
          if (!cVar2) {
            if (this.targetForceData == null) throw; // [null/range check failed]
            fVar1 = this.targetForceData.playerOutForceContribution;
            iVar12 = OtherForceContributionExchangeController.GetExchangeContributionCost
                               (this,local_res8[0],0x3f000000);
            if (fVar1 < (float)iVar12) {
              puVar11 = (uint64 *)Color.get_red(local_68,0);
            }
            else {
              puVar11 = (uint64 *)Color.get_black(local_88);
            }
          }
          else {
            puVar11 = (uint64 *)Color.get_black(local_78,0);
          }
          if (plVar10 == (int64 *)0) throw; // [null/range check failed]
          local_98 = *puVar11;
          uStack_90 = puVar11[1];
          (**(code **)(*plVar10 + 0x2a8))(plVar10,&local_98,*(uint64 *)(*plVar10 + 0x2b0));
          local_res8[0] = local_res8[0] + 1;
          if (5 < local_res8[0]) break;
        LAB_180b92550:
          lVar6 = FUN_18046c0a0(0);
          if (((lVar6 == null) || (this.targetForceData == null)) || (*(int64 *)(lVar6 + 32) == 0)
             ) throw; // [null/range check failed]
        }
        lVar6 = FUN_18046c0a0(0);
        if (((lVar6 == null) || (*(int64 *)(lVar6 + 32) == 0)) ||
           ((this.targetForceData == null ||
            (lVar6 = *(int64 *)(*(int64 *)(lVar6 + 32) + 0x180)) == null)))
        throw; // [null/range check failed]
        cVar2 = FUN_18182a3a0(lVar6,this.targetForceData.speBuildingID,DAT_181d8f398);
        if ((((this.exchangeUIPanel == null) ||
             (lVar6 = GameObject.get_transform(this.exchangeUIPanel,0)) == null) ||
            (lVar6 = Transform.Find(lVar6,"SpeBuilding",0)) == null) ||
           ((lVar6 = Transform.Find(lVar6,"UnlockButton",0), lVar6 == null ||
            (lVar6 = Component.GetComponent(lVar6,DAT_181d93760)) == null))) throw; // [null/range check failed]
        Selectable.set_interactable(lVar6,!cVar2,0);
        if (((this.exchangeUIPanel == null) ||
            ((lVar6 = GameObject.get_transform(this.exchangeUIPanel,0), lVar6 == null ||
             (lVar6 = Transform.Find(lVar6,"SpeBuilding",0)) == null))) ||
           ((lVar6 = Transform.Find(lVar6,"UnlockButton",0), lVar6 == null ||
            (lVar6 = Transform.Find(lVar6,"Cost",0)) == null))) throw; // [null/range check failed]
        uVar8 = Component.GetComponent(lVar6,DAT_181d96160);
        uVar7 = "已获取";
        if (!cVar2) {
          cVar3 = OtherForceContributionExchangeController.ForceIsPlayerServant(this,0);
          if (!cVar3) {
            auVar14._0_8_ = FUN_1801f8ab0();
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
        plVar10 = (int64 *)Component.GetComponent(lVar6,DAT_181d96160);
        if (!cVar2) {
          if (this.targetForceData == null) throw; // [null/range check failed]
          fVar1 = this.targetForceData.playerOutForceContribution;
          cVar2 = OtherForceContributionExchangeController.ForceIsPlayerServant(this,0);
          if (!cVar2) {
            auVar16._0_8_ = FUN_1801f8ab0();
            auVar16._8_8_ = extraout_XMM0_Qb_00;
            auVar17._4_12_ = auVar16._4_12_;
            auVar17._0_4_ = (float)auVar16._0_8_ * 50.0;
            iVar5 = Mathf.RoundToInt(auVar17._0_8_,0);
          }
          if ((float)iVar5 > fVar1)
          {
            puVar11 = (uint64 *)Color.get_red(local_68,0);
            }
            else {
          }
          puVar11 = (uint64 *)Color.get_black(local_68,0);
        }
        if (plVar10 != (int64 *)0) {
          local_98 = *puVar11;
          uStack_90 = puVar11[1];
          (**(code **)(*plVar10 + 0x2a8))(plVar10,&local_98,*(uint64 *)(*plVar10 + 0x2b0));
          return;
        }
    }

    // Token : 0x6001974
    // RVA   : 0xB91300   Offset: 0xB90700   Length: 0xAF4
    public void ExchangeSkillClicked(KungfuSkillLvData targetSkill)
    {
        var pStatics_3d40 = *(int64*)(DAT_181d73d40 + 184);
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
        if ((((GameController._instance == null) ||
             (lVar3 = GameController._instance.worldData) == null) ||
            (lVar3 = WorldData.Player(lVar3,0), targetSkill == null)) || (lVar3 == null)) goto LAB_180b91ddd;
        lVar3 = HeroData.FindSkill(lVar3,*(uint32 *)(targetSkill + 16),0);
        if (lVar3 != null) {
          if (GameController._instance != null) {
            GameController.ShowTextOnMouse(GameController._instance,"已学会！",0);
            return;
          }
          goto LAB_180b91ddd;
        }
        cVar2 = OtherForceContributionExchangeController.ForceIsPlayerServant(this,0);
        if (!cVar2) {
          lVar3 = FUN_18046c0a0(0);
          if (((lVar3 == null) || (lVar3.villageAreaID == null)) ||
             (lVar3 = WorldData.Player(lVar3.villageAreaID,0)) == null) goto LAB_180b91ddd;
          fVar9 = *(float *)(lVar3 + 0x1c4);
          lVar3 = OtherForceContributionExchangeController.exchangeMinFame;
          lVar4 = KungfuSkillLvData.DataBase(targetSkill,0);
          if ((lVar4 == null) || (lVar3 == null)) goto LAB_180b91ddd;
          uVar1 = *(uint32 *)(lVar4 + 52);
          if (lVar3.cityAreaID <= uVar1) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          if (fVar9 < lVar3.chapter[uVar1]) {
            lVar3 = FUN_18046c400(0);
            lVar4 = OtherForceContributionExchangeController.exchangeMinFame;
            lVar5 = KungfuSkillLvData.DataBase(targetSkill,0);
            if ((lVar5 == null) || (lVar4 == null)) {
        LAB_180b91de3:
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            uVar1 = *(uint32 *)(lVar5 + 52);
            if (*(uint32 *)(lVar4 + 24) <= uVar1) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            local_res20[0] =
                 lVar4[uVar1];
            uVar6 = il2cpp_value_box(DAT_181da22d8,local_res20);
            lVar4 = *(int64 *)(pStatics_3d40 + 0x4f8);
            lVar5 = KungfuSkillLvData.DataBase(targetSkill,0);
            if ((lVar5 == null) || (lVar4 == null)) goto LAB_180b91de3;
            uVar1 = *(uint32 *)(lVar5 + 52);
            if (*(uint32 *)(lVar4 + 24) <= uVar1) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            uVar6 = String.Format("#PlayerName#的江湖声望太低，若将本门{1}武学托付于你，只怕难以服众。\n(需要至少{0}点声望。)",uVar6,
                                   *(uint64 *)
                                    (*(int64 *)(lVar4 + 16) + 32 + (int64)(int)uVar1 * 8),0);
            lVar4 = il2cpp_internal(DAT_181d97750);
            FUN_18132faf0(lVar4,DAT_181da3bd8);
            if (lVar4 == null) goto LAB_180b91de3;
            FUN_18181e0a0(lVar4,"是我唐突了;HideInteractUI",DAT_181da3d58);
            lVar5 = FUN_18046bac0(0);
            if (((lVar5 == null) || (*(int64 *)(lVar5 + 88) == 0)) ||
               (lVar5 = AreaData.GetForce(*(int64 *)(lVar5 + 88),0)) == null)
            goto LAB_180b91de3;
            uVar7 = Int32.ToString(lVar5 + 88,0);
            var uVar8 = new SinglePlotData(uVar6,lVar4,3,uVar7,3,"0",0,0,0);
            if (lVar3 == null) goto LAB_180b91de3;
            goto LAB_180b917ea;
          }
        }
        cVar2 = OtherForceContributionExchangeController.ForceIsPlayerServant(this,0);
        if (!cVar2) {
          lVar3 = OtherForceContributionExchangeController.exchangeMinFavor;
          lVar4 = KungfuSkillLvData.DataBase(targetSkill,0);
          if ((lVar4 == null) || (lVar3 == null)) goto LAB_180b91ddd;
          uVar1 = *(uint32 *)(lVar4 + 52);
          if (lVar3.cityAreaID <= uVar1) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          if (0.0 < lVar3.chapter[uVar1]) {
            lVar3 = FUN_18046bac0(0);
            if ((((lVar3 == null) || (lVar3.TempHeros == null)) ||
                (lVar3 = AreaData.GetForce(lVar3.TempHeros,0)) == null) ||
               (lVar3 = ForceData.GetLeader(lVar3,0)) == null) {
        LAB_180b91ddd:
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            fVar9 = (float)HeroData.Favor(lVar3,0,0);
            lVar3 = OtherForceContributionExchangeController.exchangeMinFavor;
            lVar4 = KungfuSkillLvData.DataBase(targetSkill,0);
            if ((lVar4 == null) || (lVar3 == null)) goto LAB_180b91ddd;
            uVar1 = *(uint32 *)(lVar4 + 52);
            if (lVar3.cityAreaID <= uVar1) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            if (fVar9 < lVar3.chapter[uVar1]) {
              lVar3 = FUN_18046c400(0);
              lVar4 = OtherForceContributionExchangeController.exchangeMinFavor;
              lVar5 = KungfuSkillLvData.DataBase(targetSkill,0);
              if ((lVar5 == null) || (lVar4 == null)) {
        LAB_180b91de9:
                          // WARNING: Subroutine does not return
                FUN_1800d6620();
              }
              local_res20[0] = FUN_1800d6790(lVar4,*(uint32 *)(lVar5 + 52),DAT_181da1078);
              uVar6 = il2cpp_value_box(DAT_181da22d8,local_res20);
              lVar4 = *(int64 *)(pStatics_3d40 + 0x4f8);
              lVar5 = KungfuSkillLvData.DataBase(targetSkill,0);
              if ((lVar5 == null) || (lVar4 == null)) goto LAB_180b91de9;
              uVar8 = FUN_180002f80(lVar4,*(uint32 *)(lVar5 + 52),DAT_181da4358);
              uVar6 = String.Format("本座与#PlayerName#你交情尚浅，恐怕还不能将本门{1}武学贸然托付于你。\n(需要至少{0}点掌门好感。)",uVar6,uVar8,0);
              lVar4 = il2cpp_internal(DAT_181d97750);
              FUN_18132faf0(lVar4,DAT_181da3bd8);
              if (lVar4 == null) goto LAB_180b91de9;
              FUN_18181e0a0(lVar4,"是我唐突了;HideInteractUI",DAT_181da3d58);
              lVar5 = FUN_18046bac0(0);
              if (((lVar5 == null) || (*(int64 *)(lVar5 + 88) == 0)) ||
                 (lVar5 = AreaData.GetForce(*(int64 *)(lVar5 + 88),0)) == null)
              goto LAB_180b91de9;
              uVar7 = Int32.ToString(lVar5 + 88,0);
              var uVar8 = new SinglePlotData(uVar6,lVar4,3,uVar7,3,"0",0,0,0);
              if (lVar3 == null) goto LAB_180b91de9;
              goto LAB_180b917ea;
            }
          }
        }
        lVar3 = FUN_18046c400(0);
        if (lVar3 != null) {
          PlotController.SetPlotSkill(lVar3,targetSkill,1,0);
          lVar3 = FUN_18046c400(0);
          uVar6 = KungfuSkillLvData.Name(targetSkill,1,0);
          lVar4 = KungfuSkillLvData.DataBase(targetSkill,0);
          if (lVar4 != null) {
            cVar2 = OtherForceContributionExchangeController.ForceIsPlayerServant(this,0);
            local_res20[0] = 0;
            if (!cVar2) {
              fVar9 = (float)FUN_1801f8ab0(0x40000000);
              local_res20[0] = Mathf.RoundToInt(fVar9 * 50.0,0);
            }
            uVar8 = il2cpp_value_box(DAT_181d80418,local_res20);
            uVar6 = String.Format("#PlayerName#想要学习本门的{0}吗？\n#PlayerName#虽非本门弟子，但在江湖中声名显赫，且与本座私交甚笃。\n因此若能为本门立下{1}点功绩，倒也可破例而为。",uVar6,uVar8,0);
            lVar4 = il2cpp_internal(DAT_181d97750);
            FUN_18132faf0(lVar4,DAT_181da3bd8);
            uVar8 = Int32.ToString(targetSkill + 16,0);
            uVar8 = String.Concat("兑换该武学;SureExchangeOtherForceSkill;",uVar8,0);
            if (lVar4 != null) {
              FUN_18181e0a0(lVar4,uVar8,DAT_181da3d58);
              FUN_18181e0a0(lVar4,"还是算了;HideInteractUI",DAT_181da3d58);
              if (this.targetForceData != null) {
                uVar7 = Int32.ToString(this.targetForceData + 88,0);
                var uVar8 = new SinglePlotData(uVar6,lVar4,3,uVar7,3,"0",0,0,0);
                if (lVar3 != null) {
        LAB_180b917ea:
                  PlotController.ChangePlot(lVar3,uVar8,0);
                  return;
                }
              }
            }
          }
        }
    }

    // Token : 0x6001975
    // RVA   : 0xB94760   Offset: 0xB93B60   Length: 0xA0D
    public void UnlockClothButtonClicked(int lv)
    {
        var pStatics_3d40 = *(int64*)(DAT_181d73d40 + 184);
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
            auVar12._0_8_ = FUN_1801f8ab0();
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
              if ((plVar3 != (int64 *)0) && (*plVar3 == DAT_181daf348)) {
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
          if (((GameController._instance == null) ||
              (lVar4 = GameController._instance.worldData) == null) ||
             (lVar4 = WorldData.Player(lVar4,0)) == null) throw; // [null/range check failed]
          fVar11 = *(float *)(lVar4 + 0x1c4);
          lVar4 = OtherForceContributionExchangeController.exchangeMinFame;
          if (lVar4 == null) throw; // [null/range check failed]
          if (lVar4.forceName <= lv) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          if (fVar11 < *(float *)(lVar4.forceID + 32 + lVar9 * 4)) {
            lVar4 = FUN_18046c400(0);
            lVar6 = OtherForceContributionExchangeController.exchangeMinFame;
            if (lVar6 == null) {
        LAB_180b95162:
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            if (*(uint32 *)(lVar6 + 24) <= lv) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            local_res20[0] = *(uint32 *)(*(int64 *)(lVar6 + 16) + 32 + lVar9 * 4);
            uVar5 = il2cpp_value_box(DAT_181da22d8,local_res20);
            lVar6 = *(int64 *)(pStatics_3d40 + 0x3d8);
            if (lVar6 == null) goto LAB_180b95162;
            if (*(uint32 *)(lVar6 + 24) <= lv) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            uVar5 = String.Format("#PlayerName#的江湖声望太低，若将本门{1}服饰托付于你，只怕难以服众。\n(需要至少{0}点声望)",uVar5,
                                   *(uint64 *)(*(int64 *)(lVar6 + 16) + 32 + lVar9 * 8),0);
            lVar9 = il2cpp_internal(DAT_181d97750);
            FUN_18132faf0(lVar9,DAT_181da3bd8);
            if (lVar9 == null) goto LAB_180b95162;
            FUN_18181e0a0(lVar9,"是我唐突了;HideInteractUI",DAT_181da3d58);
            lVar6 = FUN_18046bac0(0);
            if (((lVar6 == null) || (*(int64 *)(lVar6 + 88) == 0)) ||
               (lVar6 = AreaData.GetForce(*(int64 *)(lVar6 + 88),0)) == null)
            goto LAB_180b95162;
            uVar7 = Int32.ToString(lVar6 + 88,0);
            var uVar8 = new SinglePlotData(uVar5,lVar9,3,uVar7,3,"0",0,0,0);
            if (lVar4 == null) goto LAB_180b95162;
            goto LAB_180b94ca2;
          }
        }
        cVar1 = OtherForceContributionExchangeController.ForceIsPlayerServant(this,0);
        if (!cVar1) {
          lVar4 = OtherForceContributionExchangeController.exchangeMinFavor;
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
            lVar4 = OtherForceContributionExchangeController.exchangeMinFavor;
            if (lVar4 == null) throw; // [null/range check failed]
            if (lVar4.forceName <= lv) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            if (fVar11 < *(float *)(lVar4.forceID + 32 + lVar9 * 4)) {
              lVar4 = FUN_18046c400(0);
              lVar6 = OtherForceContributionExchangeController.exchangeMinFavor;
              if (lVar6 != null) {
                if (*(uint32 *)(lVar6 + 24) <= lv) {
                  ThrowHelper.ThrowArgumentOutOfRangeException(0);
                }
                local_res20[0] = *(uint32 *)(*(int64 *)(lVar6 + 16) + 32 + lVar9 * 4);
                uVar5 = il2cpp_value_box(DAT_181da22d8,local_res20);
                lVar6 = *(int64 *)(pStatics_3d40 + 0x3d8);
                if (lVar6 != null) {
                  if (*(uint32 *)(lVar6 + 24) <= lv) {
                    ThrowHelper.ThrowArgumentOutOfRangeException(0);
                  }
                  uVar5 = String.Format("本座与#PlayerName#你交情尚浅，恐怕还不能将本门{1}服饰贸然托付于你。\n(需要至少{0}点掌门好感)",uVar5,
                                         *(uint64 *)(*(int64 *)(lVar6 + 16) + 32 + lVar9 * 8),0
                                        );
                  lVar9 = il2cpp_internal(DAT_181d97750);
                  FUN_18132faf0(lVar9,DAT_181da3bd8);
                  if (lVar9 != null) {
                    FUN_18181e0a0(lVar9,"是我唐突了;HideInteractUI",DAT_181da3d58);
                    lVar6 = FUN_18046bac0(0);
                    if (((lVar6 != null) && (*(int64 *)(lVar6 + 88) != 0)) &&
                       (lVar6 = AreaData.GetForce(*(int64 *)(lVar6 + 88),0)) != null) {
                      uVar7 = Int32.ToString(lVar6 + 88,0);
                      var uVar8 = new SinglePlotData(uVar5,lVar9,3,uVar7,3,"0",0,0,0);
                      if (lVar4 != null) {
        LAB_180b94ca2:
                        PlotController.ChangePlot(lVar4,uVar8,0);
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
        if ((GameController._instance != null) &&
           (lVar9 = GameController._instance.worldData) != null) {
          lVar9 = WorldData.Player(lVar9,0);
          cVar1 = OtherForceContributionExchangeController.ForceIsPlayerServant(this,0);
          if (!cVar1) {
            auVar14._0_8_ = FUN_1801f8ab0();
            auVar14._8_8_ = extraout_XMM0_Qb_00;
            auVar15._4_12_ = auVar14._4_12_;
            auVar15._0_4_ = (float)auVar14._0_8_ * 50.0 * 0.5;
            Mathf.RoundToInt(auVar15._0_8_,0);
          }
          lVar4 = this.targetForceData;
          if ((lVar4 != null) && (lVar9 != null)) {
            HeroData.ChangeForceContribution(lVar9,lVar4,1,lVar4.forceID,0);
            if (((GameController._instance != null) && (this.targetForceData != null)) &&
               (lVar9 = GameController._instance.worldData) != null) {
              WorldData.UnlockSkin
                        (lVar9,this.targetForceData.defaultSkinID,lv,1,0);
              OtherForceContributionExchangeController.RefreshExchangeUI(this,0);
              return;
            }
          }
        }
    }

    // Token : 0x6001976
    // RVA   : 0xB93E50   Offset: 0xB93250   Length: 0x900
    public void SpeBuildingButtonClicked()
    {
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
            auVar12._0_8_ = FUN_1801f8ab0();
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
              if ((plVar4 != (int64 *)0) && (*plVar4 == DAT_181daf348)) {
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
          if (((GameController._instance == null) ||
              (lVar3 = GameController._instance.worldData) == null) ||
             (lVar3 = WorldData.Player(lVar3,0)) == null) throw; // [null/range check failed]
          fVar11 = *(float *)(lVar3 + 0x1c4);
          lVar3 = OtherForceContributionExchangeController.exchangeMinFame;
          if (lVar3 == null) throw; // [null/range check failed]
          if (lVar3.cityAreaID < 6) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          if (fVar11 < *(float *)(lVar3.chapter + 52)) {
            lVar3 = FUN_18046c400(0);
            lVar6 = OtherForceContributionExchangeController.exchangeMinFame;
            if (lVar6 == null) {
        LAB_180b94745:
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            if (lVar6.forceName < 6) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            local_res18[0] = *(uint32 *)(lVar6.forceID + 52);
            uVar5 = il2cpp_value_box(DAT_181da22d8,local_res18);
            uVar5 = String.Format("#PlayerName#的江湖声望太低，若将本门特殊建筑托付于你，只怕难以服众。\n(需要至少{0}点声望)",uVar5,0);
            lVar6 = il2cpp_internal(DAT_181d97750);
            FUN_18132faf0(lVar6,DAT_181da3bd8);
            if (lVar6 == null) goto LAB_180b94745;
            FUN_18181e0a0(lVar6,"是我唐突了;HideInteractUI",DAT_181da3d58);
            lVar7 = FUN_18046bac0(0);
            if (((lVar7 == null) || (*(int64 *)(lVar7 + 88) == 0)) ||
               (lVar7 = AreaData.GetForce(*(int64 *)(lVar7 + 88),0)) == null)
            goto LAB_180b94745;
            uVar8 = Int32.ToString(lVar7 + 88,0);
            uVar9 = new SinglePlotData(uVar5,lVar6,3,uVar8,3,"0",0,0,0);
            if (lVar3 == null) goto LAB_180b94745;
            goto LAB_180b94331;
          }
        }
        cVar1 = OtherForceContributionExchangeController.ForceIsPlayerServant(this,0);
        if (!cVar1) {
          lVar3 = FUN_18046bac0(0);
          if ((((lVar3 == null) || (lVar3.TempHeros == null)) ||
              (lVar3 = AreaData.GetForce(lVar3.TempHeros,0)) == null) ||
             (lVar3 = ForceData.GetLeader(lVar3,0)) == null) throw; // [null/range check failed]
          fVar11 = (float)HeroData.Favor(lVar3,0,0);
          lVar3 = OtherForceContributionExchangeController.exchangeMinFavor;
          if (lVar3 == null) throw; // [null/range check failed]
          if (lVar3.cityAreaID < 6) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          if (fVar11 < *(float *)(lVar3.chapter + 52)) {
            lVar3 = FUN_18046c400(0);
            lVar6 = OtherForceContributionExchangeController.exchangeMinFavor;
            if (lVar6 != null) {
              if (lVar6.forceName < 6) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              local_res18[0] = *(uint32 *)(lVar6.forceID + 52);
              uVar5 = il2cpp_value_box(DAT_181da22d8,local_res18);
              uVar5 = String.Format("本座与#PlayerName#你交情尚浅，恐怕还不能将本门特殊建筑贸然托付于你。\n(需要至少{0}点掌门好感)",uVar5,0);
              lVar6 = il2cpp_internal(DAT_181d97750);
              FUN_18132faf0(lVar6,DAT_181da3bd8);
              if (lVar6 != null) {
                FUN_18181e0a0(lVar6,"是我唐突了;HideInteractUI",DAT_181da3d58);
                lVar7 = FUN_18046bac0(0);
                if (((lVar7 != null) && (*(int64 *)(lVar7 + 88) != 0)) &&
                   (lVar7 = AreaData.GetForce(*(int64 *)(lVar7 + 88),0)) != null) {
                  uVar8 = Int32.ToString(lVar7 + 88,0);
                  uVar9 = new SinglePlotData(uVar5,lVar6,3,uVar8,3,"0",0,0,0);
                  if (lVar3 != null) {
        LAB_180b94331:
                    PlotController.ChangePlot(lVar3,uVar9,0);
                    return;
                  }
                }
              }
            }
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
        }
        if ((GameController._instance != null) &&
           (lVar3 = GameController._instance.worldData) != null) {
          lVar3 = WorldData.Player(lVar3,0);
          cVar1 = OtherForceContributionExchangeController.ForceIsPlayerServant(this,0);
          if (!cVar1) {
            auVar14._0_8_ = FUN_1801f8ab0();
            auVar14._8_8_ = extraout_XMM0_Qb_00;
            auVar15._4_12_ = auVar14._4_12_;
            auVar15._0_4_ = (float)auVar14._0_8_ * 50.0;
            Mathf.RoundToInt(auVar15._0_8_,0);
          }
          lVar6 = this.targetForceData;
          if ((lVar6 != null) && (lVar3 != null)) {
            HeroData.ChangeForceContribution(lVar3,lVar6,1,lVar6.forceID,0);
            if ((((GameController._instance != null) &&
                 (lVar3 = GameController._instance.worldData) != null) &&
                (this.targetForceData != null)) &&
               (lVar3 = lVar3.speBuildingUnlocked) != null) {
              FUN_18182a0b0(lVar3,this.targetForceData.speBuildingID,DAT_181d8f218);
              OtherForceContributionExchangeController.RefreshExchangeUI(this,0);
              return;
            }
          }
        }
    }

    // Token : 0x6001977
    // RVA   : 0xB91F90   Offset: 0xB91390   Length: 0x59
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
        fVar3 = (float)FUN_1801f8ab0(0x40000000);
        uVar2 = Mathf.RoundToInt(fVar3 * 50.0 * rate,0);
        return uVar2;
    }

    // Token : 0x6001978
    // RVA   : 0xB91E00   Offset: 0xB91200   Length: 0x189
    public bool ForceIsPlayerServant()
    {
        int iVar1;
        bool cVar2;
        long lVar3;
        if ((GameController._instance != null) &&
           (lVar3 = GameController._instance.worldData) != null) {
          lVar3 = WorldData.Player(lVar3,0);
          if (lVar3 != null) {
            cVar2 = HeroData.HaveForce(lVar3,0);
            if (!cVar2) {
              return false;
            }
            if (this.targetForceData != null) {
              iVar1 = this.targetForceData.masterForce;
              if ((GameController._instance != null) &&
                 (lVar3 = GameController._instance.worldData) != null) {
                lVar3 = WorldData.Player(lVar3,0);
                if (lVar3 != null) {
                  return iVar1 == *(int *)(lVar3 + 132);
                }
              }
            }
          }
        }
    }

    // Token : 0x6001979
    // RVA   : 0xB95170   Offset: 0xB94570   Length: 0x80
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

    // Token : 0x600197A
    // RVA   : 0x3A17B0   Offset: 0x3A0BB0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_18044ef50(this,0);
    }

    // Token : 0x600197B
    // RVA   : 0xB95200   Offset: 0xB94600   Length: 0x1D9
    private static void /*cctor*/()
    {
        var pStatics = *(int64*)(DAT_181d8f490 + 184);
        long lVar1;
        lVar1 = il2cpp_internal(DAT_181d96ed0);
        FUN_18132faf0(lVar1,DAT_181da0cf8);
        if (lVar1 != null) {
          FUN_18181de10(lVar1,0x42c80000,DAT_181da0df8);
          FUN_18181de10(lVar1,0x43480000,DAT_181da0df8);
          FUN_18181de10(lVar1,0x43c80000,DAT_181da0df8);
          FUN_18181de10(lVar1,0x44480000,DAT_181da0df8);
          FUN_18181de10(lVar1,0x44c80000,DAT_181da0df8);
          FUN_18181de10(lVar1,0x45480000,DAT_181da0df8);
          plVar2 = pStatics;
          *plVar2 = lVar1;
          il2cpp_internal(plVar2,lVar1);
          lVar1 = il2cpp_internal(DAT_181d96ed0);
          FUN_18132faf0(lVar1,DAT_181da0cf8);
          if (lVar1 != null) {
            FUN_18181de10(lVar1,0,DAT_181da0df8);
            FUN_18181de10(lVar1,0,DAT_181da0df8);
            FUN_18181de10(lVar1,0,DAT_181da0df8);
            FUN_18181de10(lVar1,0x41a00000,DAT_181da0df8);
            FUN_18181de10(lVar1,0x42480000,DAT_181da0df8);
            FUN_18181de10(lVar1,0x42c80000,DAT_181da0df8);
            OtherForceContributionExchangeController.exchangeMinFavor = lVar1;
            return;
          }
        }
    }

}
