// ============================================================
// Type  : ForceHeroUIController
// Token : 0x2000288
// ============================================================

public class ForceHeroUIController
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x40013D0
    public ForceHeroUIType forceHeroUIType;

    // Token: 0x40013D1
    public GameObject forceHeroUIPanel;

    // Token: 0x40013D2
    public GameObject upgradeButton;

    // Token: 0x40013D3
    public GameObject servantButton;

    // Token: 0x40013D4
    public GameObject betrayButton;

    // Token: 0x40013D5
    public GameObject leaveButton;

    // Token: 0x40013D6
    public GameObject upgradeText;

    // Token: 0x40013D7
    public ForceData targetForce;

    // Token: 0x40013D8
    private static ForceHeroUIController _instance;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x600147D
    // RVA   : 0x77E630   Offset: 0x77CE30   Length: 0x36
    public static ForceHeroUIController get_Instance()
    {
        return **(uint64 **)(DAT_181da2ba0 + 184);
    }

    // Token : 0x600147E
    // RVA   : 0x77C300   Offset: 0x77AB00   Length: 0x43
    private void Awake()
    {
        puVar1 = *(uint64 **)(DAT_181da2ba0 + 184);
        *puVar1 = this;
        il2cpp_internal(puVar1,this);
    }

    // Token : 0x600147F
    // RVA   : 0x77C5B0   Offset: 0x77ADB0   Length: 0x2D
    public void HideForceHeroUI()
    {
        ForceHeroUIController.ClearHeroList(this,0);
        if (this.forceHeroUIPanel != null) {
          GameObject.SetActive(this.forceHeroUIPanel,0,0);
          return;
        }
    }

    // Token : 0x6001480
    // RVA   : 0x77CAA0   Offset: 0x77B2A0   Length: 0x194E
    public void ShowForceHeroUI(ForceHeroUIType targetType, ForceData _targetForce)
    {
        var pStatics_df90 = *(int64*)(DAT_181d4df90 + 184);
        var pStatics_ef00 = *(int64*)(DAT_181d4ef00 + 184);
        float fVar1;
        byte uVar2;
        bool cVar3;
        int iVar4;
        int iVar5;
        long lVar7;
        ulong uVar8;
        ulong uVar9;
        long lVar10;
        long lVar11;
        uint uVar14;
        uint[] local_res8 = new uint[2];
        uint local_48;
        uint[] local_44 = new uint[3];
        ulong local_38;
        ulong uStack_30;
        plVar6 = (int64 *)Resources.Load("Sound/SoundEffect/OpenBook",0);
        plVar15 = (int64 *)0;
        plVar13 = plVar15;
        if ((plVar6 != (int64 *)0) && (plVar13 = (int64 *)0, *plVar6 == DAT_181d8a228)) {
          plVar13 = plVar6;
        }
        NGUITools.PlaySound(plVar13,0);
        if (this.forceHeroUIPanel == null) throw; // [null/range check failed]
        GameObject.SetActive(this.forceHeroUIPanel,1,0);
        this.forceHeroUIType = targetType;
        this.targetForce = _targetForce;
        if ((*pStatics_df90 == 0) ||
           (lVar7 = *(int64 *)(*pStatics_df90 + 32)) == null)
        throw; // [null/range check failed]
        if ((*(int *)(lVar7 + 156) == 1) && (this.forceHeroUIType == null)) {
          lVar7 = FUN_18046c0a0(0);
          if (((lVar7 == null) || (*(int64 *)(lVar7 + 32) == 0)) ||
             (lVar7 = WorldData.Player(*(int64 *)(lVar7 + 32),0)) == null) throw; // [null/range check failed]
          if (-1 < *(int *)(lVar7 + 132)) goto LAB_18077cfe2;
          lVar7 = FUN_18046c0a0(0);
          if ((lVar7 == null) || (*(int64 *)(lVar7 + 32) == 0)) throw; // [null/range check failed]
          lVar7 = WorldData.Player(*(int64 *)(lVar7 + 32),0);
          if (lVar7 == null) throw; // [null/range check failed]
          if (-1 < *(int *)(lVar7 + 0x380)) goto LAB_18077cfe2;
          if (this.upgradeButton == null) throw; // [null/range check failed]
          GameObject.SetActive(this.upgradeButton,1,0);
          if (this.servantButton == null) throw; // [null/range check failed]
          GameObject.SetActive(this.servantButton,1,0);
          if (this.upgradeText == null) throw; // [null/range check failed]
          GameObject.SetActive(this.upgradeText,1,0);
          if (this.upgradeText == null) throw; // [null/range check failed]
          uVar8 = GameObject.GetComponent(this.upgradeText,DAT_181da1eb0);
          if (this.targetForce == null) throw; // [null/range check failed]
          uVar9 = ForceData.GetJoinForceNeedDescribe(this.targetForce,0);
          uVar9 = String.Concat("入门需要:\n",uVar9,0);
          LTLocalization.SetText(uVar8,uVar9,0);
          if (this.upgradeButton == null) throw; // [null/range check failed]
          lVar7 = GameObject.GetComponent(this.upgradeButton,DAT_181d9ee60);
          if ((this.targetForce == null) ||
             (uVar2 = ForceData.PlayerMeetForceJoinRequire(this.targetForce,0), lVar7 == null))
          throw; // [null/range check failed]
          Selectable.set_interactable(lVar7,uVar2,0);
          if (this.servantButton == null) throw; // [null/range check failed]
          lVar7 = GameObject.GetComponent(this.servantButton,DAT_181d9ee60);
          if ((this.targetForce == null) ||
             (uVar2 = ForceData.PlayerMeetForceJoinRequire(this.targetForce,0), lVar7 == null))
          throw; // [null/range check failed]
          Selectable.set_interactable(lVar7,uVar2,0);
          if ((this.upgradeButton == null) ||
             ((lVar7 = GameObject.get_transform(this.upgradeButton,0), lVar7 == null ||
              (lVar7 = Transform.Find(lVar7,"Text",0)) == null))) throw; // [null/range check failed]
          uVar8 = Component.GetComponent(lVar7,DAT_181d6d8c0);
          LTLocalization.SetText(uVar8,"拜入",0);
        }
        else {
        LAB_18077cfe2:
          if ((((*pStatics_df90 == 0) ||
               (lVar7 = *(int64 *)(*pStatics_df90 + 32)) == null) ||
              (lVar7 = WorldData.Player(lVar7,0)) == null) || (this.targetForce == null))
          throw; // [null/range check failed]
          if ((*(int *)(lVar7 + 0x380) != this.targetForce.forceID) &&
             (this.forceHeroUIType == 1)) {
            lVar7 = FUN_18046c0a0(0);
            if ((lVar7 == null) || (*(int64 *)(lVar7 + 32) == 0)) throw; // [null/range check failed]
            if (*(int *)(*(int64 *)(lVar7 + 32) + 156) == 0) {
              lVar7 = FUN_18046c0a0(0);
              if ((lVar7 == null) || (*(int64 *)(lVar7 + 32) == 0)) throw; // [null/range check failed]
              lVar7 = WorldData.Player(*(int64 *)(lVar7 + 32),0);
              if (lVar7 == null) throw; // [null/range check failed]
              if (4 < *(int *)(lVar7 + 184)) goto LAB_18077d133;
        LAB_18077d1d3:
              if (this.upgradeButton == null) throw; // [null/range check failed]
              GameObject.SetActive(this.upgradeButton,1,0);
              if (this.servantButton == null) throw; // [null/range check failed]
              GameObject.SetActive(this.servantButton,0,0);
              if (this.upgradeText == null) throw; // [null/range check failed]
              GameObject.SetActive(this.upgradeText,1,0);
              if (this.upgradeText == null) throw; // [null/range check failed]
              uVar8 = GameObject.GetComponent(this.upgradeText,DAT_181da1eb0);
              lVar7 = FUN_18046c0a0(0);
              if (((lVar7 == null) || (*(int64 *)(lVar7 + 32) == 0)) ||
                 (lVar7 = WorldData.Player(*(int64 *)(lVar7 + 32),0)) == null)
              throw; // [null/range check failed]
              uVar9 = HeroData.GetUpgradeForceLvNeedText(lVar7,0);
              LTLocalization.SetText(uVar8,uVar9,0);
              if (*(int *)(pStatics_ef00 + 8) == 1) {
                if (((*pStatics_df90 == 0) ||
                    (lVar7 = *(int64 *)(*pStatics_df90 + 32)) == null) ||
                   (lVar7 = WorldData.Player(lVar7,0)) == null) throw; // [null/range check failed]
                iVar5 = *(int *)(lVar7 + 184);
                if (*(int *)(pStatics_ef00 + 104) <= iVar5) {
                  if ((this.upgradeButton == null) ||
                     (lVar7 = GameObject.GetComponent(this.upgradeButton,DAT_181d9ee60),
                     lVar7 == null)) throw; // [null/range check failed]
                  Selectable.set_interactable(lVar7,0,0);
                  if ((this.upgradeButton == null) ||
                     ((lVar7 = GameObject.get_transform(this.upgradeButton,0), lVar7 == null ||
                      (lVar7 = Transform.Find(lVar7,"Text",0)) == null))) throw; // [null/range check failed]
                  uVar8 = Component.GetComponent(lVar7,DAT_181d6d8c0);
                  LTLocalization.SetText(uVar8,"已达试玩版上限",0);
                  goto LAB_18077d68b;
                }
              }
              if (this.upgradeButton == null) throw; // [null/range check failed]
              lVar7 = GameObject.GetComponent(this.upgradeButton,DAT_181d9ee60);
              lVar11 = FUN_18046c0a0(0);
              if (((lVar11 == null) || (*(int64 *)(lVar11 + 32) == 0)) ||
                 (lVar11 = WorldData.Player(*(int64 *)(lVar11 + 32),0)) == null)
              throw; // [null/range check failed]
              fVar1 = *(float *)(lVar11 + 0x1c0);
              lVar11 = FUN_18046c0a0(0);
              if (((lVar11 == null) || (*(int64 *)(lVar11 + 32) == 0)) ||
                 (lVar11 = WorldData.Player(*(int64 *)(lVar11 + 32),0)) == null)
              throw; // [null/range check failed]
              iVar5 = HeroData.GetUpgradeForceLvNeedContribution(lVar11,0x3f800000,0);
              if ((float)iVar5 <= fVar1) {
                lVar11 = FUN_18046c0a0(0);
                if (((lVar11 == null) || (*(int64 *)(lVar11 + 32) == 0)) ||
                   (lVar11 = WorldData.Player(*(int64 *)(lVar11 + 32),0)) == null)
                throw; // [null/range check failed]
                lVar11 = *(int64 *)(lVar11 + 600);
                lVar10 = FUN_18046c0a0(0);
                if (((lVar10 == null) || (*(int64 *)(lVar10 + 32) == 0)) ||
                   ((lVar10 = WorldData.Player(*(int64 *)(lVar10 + 32),0), lVar10 == null ||
                    (lVar11 == null)))) throw; // [null/range check failed]
                iVar5 = FUN_1800d6750(lVar11,*(uint32 *)(lVar10 + 184),DAT_181d68270);
                lVar11 = FUN_18046c0a0(0);
                if (((lVar11 == null) || (*(int64 *)(lVar11 + 32) == 0)) ||
                   (lVar11 = WorldData.Player(*(int64 *)(lVar11 + 32),0)) == null)
                throw; // [null/range check failed]
                iVar4 = HeroData.GetUpgradeForceLvNeedSkillNum(lVar11,0);
                bVar12 = iVar4 <= iVar5;
              }
              else {
                bVar12 = false;
              }
              if (lVar7 == null) throw; // [null/range check failed]
              Selectable.set_interactable(lVar7,bVar12,0);
              if (((this.upgradeButton == null) ||
                  (lVar7 = GameObject.get_transform(this.upgradeButton,0)) == null) ||
                 (lVar7 = Transform.Find(lVar7,"Text",0)) == null) throw; // [null/range check failed]
              uVar8 = Component.GetComponent(lVar7,DAT_181d6d8c0);
              LTLocalization.SetText(uVar8,"晋升",0);
              goto LAB_18077d68b;
            }
        LAB_18077d133:
            lVar7 = FUN_18046c0a0(0);
            if ((lVar7 == null) || (*(int64 *)(lVar7 + 32) == 0)) throw; // [null/range check failed]
            if (*(int *)(*(int64 *)(lVar7 + 32) + 156) == 1) {
              lVar7 = FUN_18046c0a0(0);
              if ((lVar7 == null) || (*(int64 *)(lVar7 + 32) == 0)) throw; // [null/range check failed]
              lVar7 = WorldData.Player(*(int64 *)(lVar7 + 32),0);
              if (lVar7 == null) throw; // [null/range check failed]
              if (*(char *)(lVar7 + 180) == false) goto LAB_18077d1d3;
            }
          }
          if (this.upgradeButton == null) throw; // [null/range check failed]
          GameObject.SetActive(this.upgradeButton,0,0);
          if (this.servantButton == null) throw; // [null/range check failed]
          GameObject.SetActive(this.servantButton,0,0);
          if (this.upgradeText == null) throw; // [null/range check failed]
          GameObject.SetActive(this.upgradeText,0,0);
        }
        LAB_18077d68b:
        if ((((*pStatics_df90 == 0) ||
             (lVar7 = *(int64 *)(*pStatics_df90 + 32)) == null) ||
            (lVar7 = WorldData.Player(lVar7,0)) == null) || (this.targetForce == null))
        throw; // [null/range check failed]
        if (*(int *)(lVar7 + 0x380) == this.targetForce.forceID) {
          if (this.betrayButton == null) throw; // [null/range check failed]
          GameObject.SetActive(this.betrayButton,0,0);
          if (this.leaveButton == null) throw; // [null/range check failed]
          GameObject.SetActive(this.leaveButton,1,0);
          if ((this.leaveButton == null) ||
             (lVar7 = GameObject.GetComponent(this.leaveButton,DAT_181d9ee60)) == null)
          throw; // [null/range check failed]
          Selectable.set_interactable(lVar7,1,0);
          if (this.leaveButton == null) throw; // [null/range check failed]
          lVar7 = GameObject.GetComponent(this.leaveButton,DAT_181da12b0);
          uVar8 = "解除门客关系{0}";
          if ((*pStatics_df90 == 0) ||
             (lVar11 = *(int64 *)(*pStatics_df90 + 32)) == null)
          throw; // [null/range check failed]
          uVar9 = "";
          if (0 < *(int *)(lVar11 + 200)) {
            lVar11 = FUN_18046c0a0(0);
            if ((lVar11 == null) || (*(int64 *)(lVar11 + 32) == 0)) {
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            local_48 = *(uint32 *)(*(int64 *)(lVar11 + 32) + 200);
            uVar9 = il2cpp_value_box(DAT_181d5b2f8,&local_48);
            uVar9 = String.Format("\n还需任职{0}日",uVar9,0);
          }
          uVar8 = String.Format(uVar8,uVar9,0);
          if (lVar7 == null) throw; // [null/range check failed]
          *(uint64 *)(lVar7 + 24) = uVar8;
          if (((this.leaveButton == null) ||
              (lVar7 = GameObject.get_transform(this.leaveButton,0)) == null) ||
             (lVar7 = Transform.Find(lVar7,"Text",0)) == null) throw; // [null/range check failed]
          uVar8 = Component.GetComponent(lVar7,DAT_181d6d8c0);
          LTLocalization.SetText(uVar8,"解聘",0);
        }
        else {
          if ((*pStatics_df90 == 0) ||
             (lVar7 = *(int64 *)(*pStatics_df90 + 32)) == null)
          throw; // [null/range check failed]
          if ((*(int *)(lVar7 + 156) == 1) && (this.forceHeroUIType == 1)) {
            lVar7 = this.betrayButton;
            lVar11 = FUN_18046c0a0(0);
            if ((lVar11 == null) || (*(int64 *)(lVar11 + 32) == 0)) throw; // [null/range check failed]
            lVar11 = WorldData.Player(*(int64 *)(lVar11 + 32),0);
            if ((lVar11 == null) || (lVar7 == null)) throw; // [null/range check failed]
            GameObject.SetActive(lVar7,*(int *)(lVar11 + 184) < 5,0);
            lVar7 = this.leaveButton;
            lVar11 = FUN_18046c0a0(0);
            if ((lVar11 == null) || (*(int64 *)(lVar11 + 32) == 0)) throw; // [null/range check failed]
            lVar11 = WorldData.Player(*(int64 *)(lVar11 + 32),0);
            if ((lVar11 == null) || (lVar7 == null)) throw; // [null/range check failed]
            GameObject.SetActive(lVar7,*(int *)(lVar11 + 184) < 4,0);
            if ((this.leaveButton == null) ||
               (lVar7 = GameObject.GetComponent(this.leaveButton,DAT_181da12b0)) == null
               ) throw; // [null/range check failed]
            *(uint64 *)(lVar7 + 24) = "清空功绩并离开门派\n需身份为亲传弟子\n且功绩达到满值";
            if ((this.leaveButton == null) ||
               ((lVar7 = GameObject.get_transform(this.leaveButton,0), lVar7 == null ||
                (lVar7 = Transform.Find(lVar7,"Text",0)) == null))) throw; // [null/range check failed]
            uVar8 = Component.GetComponent(lVar7,DAT_181d6d8c0);
            LTLocalization.SetText(uVar8,"出师",0);
            lVar7 = FUN_18046c0a0(0);
            if ((lVar7 == null) ||
               ((*(int64 *)(lVar7 + 32) == 0 ||
                (lVar7 = WorldData.Player(*(int64 *)(lVar7 + 32),0)) == null)))
            throw; // [null/range check failed]
            if (*(int *)(lVar7 + 184) == 3) {
              lVar7 = FUN_18046c0a0(0);
              if (((lVar7 == null) || (*(int64 *)(lVar7 + 32) == 0)) ||
                 (lVar7 = WorldData.Player(*(int64 *)(lVar7 + 32),0)) == null)
              throw; // [null/range check failed]
              fVar1 = *(float *)(lVar7 + 0x1c0);
              lVar7 = FUN_18046c0a0(0);
              if (((lVar7 == null) || (*(int64 *)(lVar7 + 32) == 0)) ||
                 (lVar7 = WorldData.Player(*(int64 *)(lVar7 + 32),0)) == null)
              throw; // [null/range check failed]
              iVar5 = HeroData.GetUpgradeForceLvNeedContribution(lVar7,0x3f800000,0);
              if ((float)iVar5 <= fVar1) {
                if ((this.leaveButton == null) ||
                   (lVar7 = GameObject.GetComponent(this.leaveButton,DAT_181d9ee60),
                   lVar7 == null)) throw; // [null/range check failed]
                Selectable.set_interactable(lVar7,1,0);
                goto LAB_18077dc8f;
              }
            }
            if ((this.leaveButton == null) ||
               (lVar7 = GameObject.GetComponent(this.leaveButton,DAT_181d9ee60)) == null
               ) throw; // [null/range check failed]
            Selectable.set_interactable(lVar7,0,0);
          }
          else {
            if (this.betrayButton == null) throw; // [null/range check failed]
            GameObject.SetActive(this.betrayButton,0,0);
            if (this.leaveButton == null) throw; // [null/range check failed]
            GameObject.SetActive(this.leaveButton,0,0);
          }
        }
        LAB_18077dc8f:
        if ((((this.upgradeButton != null) &&
             (lVar7 = GameObject.get_transform(this.upgradeButton,0)) != null) &&
            (lVar7 = FUN_180da0f00(lVar7,0)) != null) &&
           (lVar7 = Component.GetComponent(lVar7,DAT_181d6e0c0)) != null) {
          UIGrid.set_repositionNow(lVar7,1,0);
          local_res8[0] = 0;
          do {
            lVar7 = *(int64 *)(pStatics_ef00 + 0x4f0);
            if (lVar7 == null) break;
            if (*(int *)(lVar7 + 24) <= (int)plVar15) {
              if ((*pStatics_df90 == 0) ||
                 (lVar7 = *(int64 *)(*pStatics_df90 + 32)) == null) break;
              if (*(int *)(lVar7 + 156) == 1) {
                lVar7 = *(int64 *)(pStatics_ef00 + 0x3a0);
                if ((this.targetForce == null) || (lVar7 == null)) break;
                cVar3 = FUN_181815240(lVar7,this.targetForce.forceID,
                                      DAT_181d67bf8);
                if (!cVar3) {
                  if (((this.forceHeroUIPanel != null) &&
                      (lVar7 = GameObject.get_transform(this.forceHeroUIPanel,0)) != null) &&
                     (lVar7 = Transform.Find(lVar7,"SpeFunctionText",0)) != null) {
                    uVar8 = Component.GetComponent(lVar7,DAT_181d6d8c0);
                    lVar7 = FUN_18046c100(0);
                    if (((lVar7 != null) && (this.targetForce != null)) &&
                       ((*(int64 *)(lVar7 + 208) != 0 &&
                        (lVar7 = FUN_1817cc780(*(int64 *)(lVar7 + 208),
                                               this.targetForce.forceID,
                                               DAT_181d94178), lVar7 != null)))) {
                      uVar9 = *(uint64 *)(lVar7 + 0x180);
                      uVar9 = String.Format("<b>门派特性</b>\n{1}{0}</color>",uVar9,
                                             *(uint64 *)(pStatics_ef00 + 0x250),
                                             0);
                      goto LAB_18077e3b0;
                    }
                  }
                  break;
                }
              }
              if (((this.forceHeroUIPanel != null) &&
                  (lVar7 = GameObject.get_transform(this.forceHeroUIPanel,0)) != null) &&
                 (lVar7 = Transform.Find(lVar7,"SpeFunctionText",0)) != null) {
                uVar8 = Component.GetComponent(lVar7,DAT_181d6d8c0);
                uVar9 = "";
        LAB_18077e3b0:
                LTLocalization.SetText(uVar8,uVar9,0);
                ForceHeroUIController.RefreshHeroList(this,0);
                return;
              }
              break;
            }
            if ((this.forceHeroUIPanel == null) ||
               (lVar7 = GameObject.get_transform(this.forceHeroUIPanel,0)) == null) break;
            lVar7 = Transform.Find(lVar7,"Grid",0);
            uVar8 = Int32.ToString(local_res8,0);
            if ((((lVar7 == null) ||
                 ((lVar7 = Transform.Find(lVar7,uVar8,0), lVar7 == null ||
                  (lVar7 = Transform.Find(lVar7,"Scroll View",0)) == null))) ||
                (lVar7 = Transform.Find(lVar7,"Viewport",0)) == null) ||
               (lVar7 = Transform.Find(lVar7,"Content",0)) == null) break;
            uVar8 = Component.get_gameObject(lVar7,0);
            GlobalData.SortChild(uVar8,0);
            if ((this.forceHeroUIPanel == null) ||
               (lVar7 = GameObject.get_transform(this.forceHeroUIPanel,0)) == null) break;
            lVar7 = Transform.Find(lVar7,"Grid",0);
            uVar8 = Int32.ToString(local_res8,0);
            if ((lVar7 == null) ||
               ((lVar7 = Transform.Find(lVar7,uVar8,0), lVar7 == null ||
                (lVar7 = Transform.Find(lVar7,"Label",0)) == null))) break;
            plVar6 = (int64 *)Component.GetComponent(lVar7,DAT_181d6d8c0);
            lVar7 = FUN_18046c100(0);
            if ((((lVar7 == null) || (*(int64 *)(lVar7 + 56) == 0)) ||
                (lVar7 = FUN_180002f80(*(int64 *)(lVar7 + 56),local_res8[0],DAT_181d76758),
                lVar7 == null)) || (plVar6 == (int64 *)0)) break;
            local_38 = *(uint64 *)(lVar7 + 24);
            uStack_30 = *(uint64 *)(lVar7 + 32);
            (**(code **)(*plVar6 + 0x2a8))(plVar6,&local_38,*(uint64 *)(*plVar6 + 0x2b0));
            if ((this.forceHeroUIPanel == null) ||
               (lVar7 = GameObject.get_transform(this.forceHeroUIPanel,0)) == null) break;
            lVar7 = Transform.Find(lVar7,"Grid",0);
            uVar8 = Int32.ToString(local_res8,0);
            if ((lVar7 == null) ||
               ((lVar7 = Transform.Find(lVar7,uVar8,0), lVar7 == null ||
                (lVar7 = Transform.Find(lVar7,"Label",0)) == null))) break;
            uVar8 = Component.GetComponent(lVar7,DAT_181d6d8c0);
            if (local_res8[0] == 5) {
              lVar7 = *(int64 *)(pStatics_ef00 + 0x3d0);
              if (lVar7 == null) break;
              uVar14 = local_res8[0] + 1;
            }
            else {
              lVar7 = *(int64 *)(pStatics_ef00 + 0x3d0);
              uVar14 = local_res8[0];
              if (lVar7 == null) break;
            }
            uVar9 = FUN_180002f80(lVar7,uVar14,DAT_181d7c9c0);
            LTLocalization.SetText(uVar8,uVar9,0);
            if ((this.forceHeroUIPanel == null) ||
               (lVar7 = GameObject.get_transform(this.forceHeroUIPanel,0)) == null) {
        LAB_18077e3e9:
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            lVar7 = Transform.Find(lVar7,"Grid",0);
            uVar8 = Int32.ToString(local_res8,0);
            if ((lVar7 == null) ||
               ((lVar7 = Transform.Find(lVar7,uVar8,0), lVar7 == null ||
                (lVar7 = Transform.Find(lVar7,"Label",0)) == null))) goto LAB_18077e3e9;
            lVar7 = Component.GetComponent(lVar7,DAT_181d6ccc0);
            local_48 = HeroData.GetHeroSalary(local_res8[0],0);
            uVar8 = il2cpp_value_box(DAT_181d5b2f8,&local_48);
            local_44[0] = HeroData.GetHeroPopulation(local_res8[0],0);
            uVar9 = il2cpp_value_box(DAT_181d5b2f8,local_44);
            uVar8 = String.Format("月俸 {0}\n人口 {1}",uVar8,uVar9,0);
            if (lVar7 == null) goto LAB_18077e3e9;
            *(uint64 *)(lVar7 + 24) = uVar8;
            local_res8[0] = local_res8[0] + 1;
            plVar15 = (int64 *)(uint64)local_res8[0];
          } while( true );
        }
    }

    // Token : 0x6001481
    // RVA   : 0x77C400   Offset: 0x77AC00   Length: 0x1AB
    public void ClearHeroList()
    {
        long lVar1;
        ulong uVar2;
        int iVar3;
        int[] local_res18 = new int[4];
        iVar3 = 0;
        while( true ) {
          local_res18[0] = iVar3;
          lVar1 = *(int64 *)(*(int64 *)(DAT_181d4ef00 + 184) + 0x4f0);
          if (lVar1 == null) break;
          if (*(int *)(lVar1 + 24) <= iVar3) {
            return;
          }
          if (this.forceHeroUIPanel == null) break;
          lVar1 = GameObject.get_transform(this.forceHeroUIPanel,0);
          if (lVar1 == null) break;
          lVar1 = Transform.Find(lVar1,"Grid",0);
          uVar2 = Int32.ToString(local_res18,0);
          if (lVar1 == null) break;
          lVar1 = Transform.Find(lVar1,uVar2,0);
          if (lVar1 == null) break;
          lVar1 = Transform.Find(lVar1,"Scroll View",0);
          if (lVar1 == null) break;
          lVar1 = Transform.Find(lVar1,"Viewport",0);
          if (lVar1 == null) break;
          lVar1 = Transform.Find(lVar1,"Content",0);
          if (lVar1 == null) break;
          uVar2 = Component.get_gameObject(lVar1);
          GlobalData.DeleteAllChild(uVar2);
          iVar3 = local_res18[0] + 1;
        }
    }

    // Token : 0x6001482
    // RVA   : 0x77C6A0   Offset: 0x77AEA0   Length: 0x330
    public void RefreshHeroList()
    {
        var pStatics = *(int64*)(DAT_181d4e188 + 184);
        ulong uVar1;
        long lVar2;
        long lVar3;
        ulong uVar4;
        int iVar5;
        ForceHeroUIController.ClearHeroList(this,0);
        lVar2 = this.targetForce;
        iVar5 = 0;
        if (lVar2 != null) {
          while (lVar2.ownHeros != null) {
            if (*(int *)(lVar2.ownHeros + 24) <= iVar5) {
              return;
            }
            if ((this.forceHeroUIPanel == null) ||
               (lVar2 = GameObject.get_transform(this.forceHeroUIPanel,0)) == null) break;
            lVar2 = Transform.Find(lVar2,"Grid",0);
            if (((this.targetForce == null) ||
                ((((lVar3 = ForceData.GetOwnHero(this.targetForce,iVar5), lVar3 == null ||
                   (uVar4 = Int32.ToString(lVar3 + 184,0), lVar2 == null)) ||
                  (lVar2 = Transform.Find(lVar2,uVar4,0)) == null) ||
                 ((lVar2 = Transform.Find(lVar2,"Scroll View",0), lVar2 == null ||
                  (lVar2 = Transform.Find(lVar2,"Viewport",0)) == null))))) ||
               (lVar2 = Transform.Find(lVar2,"Content",0)) == null) break;
            uVar4 = Component.get_gameObject(lVar2,0);
            if (*pStatics == 0) break;
            uVar1 = *(uint64 *)(*pStatics + 144);
            lVar2 = GlobalData.AddChild(uVar4,uVar1);
            if (lVar2 == null) break;
            lVar3 = GameObject.GetComponent(lVar2,DAT_181d9fb20);
            if ((this.targetForce == null) ||
               (uVar4 = ForceData.GetOwnHero(this.targetForce,iVar5), lVar3 == null)) break;
            *(uint64 *)(lVar3 + 32) = uVar4;
            lVar3 = GameObject.GetComponent(lVar2,DAT_181d9fb20);
            if (lVar3 == null) break;
            *(uint32 *)(lVar3 + 24) = 2;
            if (this.forceHeroUIType == 2) {
              if ((this.targetForce == null) ||
                 (lVar3 = ForceData.GetOwnHero(this.targetForce,iVar5)) == null) break;
              if (*(char *)(lVar3 + 180) == false) {
                lVar3 = GameObject.GetComponent(lVar2,DAT_181d9fb20);
                if (lVar3 == null) break;
                *(uint8 *)(lVar3 + 64) = 1;
              }
            }
            if ((this.targetForce == null) ||
               (lVar3 = ForceData.GetOwnHero(this.targetForce,iVar5)) == null) break;
            if (*(int *)(lVar3 + 88) == 0) {
              lVar3 = GameObject.GetComponent(lVar2,DAT_181d9fb20);
              if (lVar3 == null) break;
              *(uint8 *)(lVar3 + 41) = 1;
            }
            lVar2 = GameObject.GetComponent(lVar2,DAT_181d9fb20);
            if (lVar2 == null) break;
            HeroIconController.AutoSetName(lVar2,0);
            lVar2 = this.targetForce;
            iVar5 = iVar5 + 1;
            if (lVar2 == null) break;
          }
        }
    }

    // Token : 0x6001483
    // RVA   : 0x77E3F0   Offset: 0x77CBF0   Length: 0x23A
    public void UpgradeButtonClicked()
    {
        var pStatics = *(int64*)(DAT_181d4df90 + 184);
        long lVar1;
        long lVar2;
        ulong uVar3;
        if ((*pStatics != 0) &&
           (lVar2 = *(int64 *)(*pStatics + 32)) != null) {
          if ((*(int *)(lVar2 + 156) == 1) && (this.forceHeroUIType == null)) {
            lVar2 = FUN_18046c440(0);
            if (lVar2 != null) {
              PlotController.ManagePlayerJoinForcePlot(lVar2,this.targetForce,0);
              return;
            }
          }
          else {
            if (this.forceHeroUIType != 1) {
              return;
            }
            lVar2 = **(int64 **)(DAT_181d6c960 + 184);
            if ((*pStatics != 0) &&
               (lVar1 = *(int64 *)(*pStatics + 32)) != null) {
              uVar3 = WorldData.Player(lVar1,0);
              if (lVar2 != null) {
                PlotController.ManageHeroForceLvPlot(lVar2,uVar3,0);
                return;
              }
            }
          }
        }
    }

    // Token : 0x6001484
    // RVA   : 0x77C350   Offset: 0x77AB50   Length: 0xAB
    public void BetrayButtonClicked()
    {
        var pStatics = *(int64*)(DAT_181d6c960 + 184);
        if (*pStatics != 0) {
          PlotController.ManagePlayerBetrayForcePlot(*pStatics,0);
          return;
        }
    }

    // Token : 0x6001485
    // RVA   : 0x77C5E0   Offset: 0x77ADE0   Length: 0xB6
    public void LeaveButtonClicked()
    {
        var pStatics = *(int64*)(DAT_181d6c960 + 184);
        if (*pStatics != 0) {
          PlotController.ManagePlayerLeaveForcePlot
                    (*pStatics,this.targetForce,0);
          return;
        }
    }

    // Token : 0x6001486
    // RVA   : 0x77C9E0   Offset: 0x77B1E0   Length: 0xB6
    public void ServantButtonClicked()
    {
        var pStatics = *(int64*)(DAT_181d6c960 + 184);
        if (*pStatics != 0) {
          PlotController.ManagePlayerServantForcePlot
                    (*pStatics,this.targetForce,0);
          return;
        }
    }

    // Token : 0x6001487
    // RVA   : 0x3A17B0   Offset: 0x39FFB0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_18044ef50(this,0);
    }

}
