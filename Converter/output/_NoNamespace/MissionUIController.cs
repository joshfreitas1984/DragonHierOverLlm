// ============================================================
// Type  : MissionUIController
// Token : 0x2000312
// ============================================================

public class MissionUIController
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x400196C
    public bool showUI;

    // Token: 0x400196D
    public GameObject missionUI;

    // Token: 0x400196E
    public GameObject missionIconPrefab;

    // Token: 0x400196F
    public GameObject missionTable;

    // Token: 0x4001970
    public GameObject worldEventIconPrefab;

    // Token: 0x4001971
    public GameObject worldEventTable;

    // Token: 0x4001972
    public GameObject worldEventNewNumIcon;

    // Token: 0x4001973
    public GameObject mailIconPrefab;

    // Token: 0x4001974
    public GameObject mailTable;

    // Token: 0x4001975
    public GameObject mailNewNumIcon;

    // Token: 0x4001976
    public List<GameObject> toggleButton;

    // Token: 0x4001977
    public GameObject forceMission;

    // Token: 0x4001978
    public int nowShowType;

    // Token: 0x4001979
    public GameObject pigeon;

    // Token: 0x400197A
    public Transform pigeonPathParent;

    // Token: 0x400197B
    public Vector3[] pigeonPath;

    // Token: 0x400197C
    public Tween pigeonTween;

    // Token: 0x400197D
    public bool worldEventTableDirty;

    // Token: 0x400197E
    private GameObject temp;

    // Token: 0x400197F
    private bool inited;

    // Token: 0x4001980
    private Image forceMissionIcon;

    // Token: 0x4001981
    private Text forceMissionText;

    // Token: 0x4001982
    private Text forceMissionTimeText;

    // Token: 0x4001983
    private SimpleDetailText forceMissionDetailText;

    // Token: 0x4001984
    private bool forceMissionRefsReady;

    // Token: 0x4001985
    private float forceMissionRefreshTimer;

    // Token: 0x4001986
    private const float ForceMissionRefreshInterval;

    // Token: 0x4001987
    private static MissionUIController _instance;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60019C1
    // RVA   : 0x8485F0   Offset: 0x8473F0   Length: 0x1F7
    private void EnsureForceMissionRefs()
    {
        bool cVar1;
        long lVar2;
        ulong uVar3;
        if (this.forceMissionRefsReady) {
          uVar3 = this.forceMissionIcon;
          cVar1 = Object.op_Inequality(uVar3,0,0);
          if (cVar1) {
            return;
          }
        }
        this.forceMissionRefsReady = 1;
        if (this.forceMission != null) {
          lVar2 = GameObject.get_transform(this.forceMission,0);
          if (lVar2 != null) {
            lVar2 = Transform.Find(lVar2,"Icon",0);
            if (lVar2 != null) {
              uVar3 = Component.GetComponent(lVar2,DAT_181e777b8);
              this.forceMissionIcon = uVar3;
              if (this.forceMission != null) {
                lVar2 = GameObject.get_transform(this.forceMission,0);
                if (lVar2 != null) {
                  lVar2 = Transform.Find(lVar2,"Text",0);
                  if (lVar2 != null) {
                    uVar3 = Component.GetComponent(lVar2,DAT_181e79538);
                    this.forceMissionText = uVar3;
                    if (this.forceMission != null) {
                      lVar2 = GameObject.get_transform(this.forceMission,0);
                      if (lVar2 != null) {
                        lVar2 = Transform.Find(lVar2,"ForceMissionTime",0);
                        if (lVar2 != null) {
                          uVar3 = Component.GetComponent(lVar2,DAT_181e79538);
                          *(uint64 *)(this + 200) = uVar3;
                          if (this.forceMission != null) {
                            uVar3 = GameObject.GetComponent(this.forceMission,DAT_181e56510);
                            this.forceMissionDetailText = uVar3;
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

    // Token : 0x60019C2
    // RVA   : 0x8487F0   Offset: 0x8475F0   Length: 0x11
    public void ForceRefreshForceMission()
    {
        void FUN_1808487f0(int64 this)
        {
        this.forceMissionRefreshTimer = 0;
        MissionUIController.RefreshForceMission(this,0);
    }

    // Token : 0x60019C3
    // RVA   : 0x84B700   Offset: 0x84A500   Length: 0x36
    public static MissionUIController get_Instance()
    {
        return **(uint64 **)(DAT_181e6af70 + 184);
    }

    // Token : 0x60019C4
    // RVA   : 0x848340   Offset: 0x847140   Length: 0x43
    private void Awake()
    {
        puVar1 = *(uint64 **)(DAT_181e6af70 + 184);
        *puVar1 = this;
        il2cpp_internal(puVar1,this);
    }

    // Token : 0x60019C5
    // RVA   : 0x84AD80   Offset: 0x849B80   Length: 0x117
    private void Start()
    {
        long lVar1;
        uint uVar2;
        ulong uVar3;
        long lVar4;
        uint uVar6;
        byte[] local_18 = new byte[16];
        if (this.pigeonPathParent != null) {
          uVar2 = Transform.get_childCount(this.pigeonPathParent,0);
          uVar3 = FUN_1801dfd90(DAT_181e86eb8,uVar2);
          this.pigeonPath = uVar3;
          uVar6 = 0;
          lVar1 = this.pigeonPath;
          while (lVar1 != null) {
            if (*(int *)(lVar1 + 24) <= (int)uVar6) {
              return;
            }
            if (((this.pigeonPathParent == null) ||
                (lVar4 = Transform.GetChild(this.pigeonPathParent,uVar6,0)) == null) ||
               (puVar5 = (uint64 *)Transform.get_localPosition(local_18,lVar4), lVar1 == null)) break;
            if (*(uint32 *)(lVar1 + 24) <= uVar6) {
              uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1801e02d0(uVar3,0);
            }
            lVar4 = (int64)(int)uVar6;
            uVar6 = uVar6 + 1;
            *(uint64 *)(lVar1 + 32 + lVar4 * 12) = *puVar5;
            *(uint32 *)(lVar1 + 40 + lVar4 * 12) = *(uint32 *)(puVar5 + 1);
            lVar1 = this.pigeonPath;
          }
        }
    }

    // Token : 0x60019C6
    // RVA   : 0x84B570   Offset: 0x84A370   Length: 0x18E
    private void Update()
    {
        var pStatics = *(int64*)(DAT_181e8e150 + 184);
        bool cVar1;
        if (!this.inited) {
          this.inited = 1;
          MissionUIController.RefreshMissionTable(this,0);
          MissionUIController.RefreshWorldEventTable(this,0);
          MissionUIController.RefreshMailTable(this,0);
        }
        else if (this.worldEventTableDirty) {
          this.worldEventTableDirty = 0;
          MissionUIController.RefreshWorldEventTable(this,0);
        }
        MissionUIController.RefreshForceMission(this,0);
        cVar1 = GlobalData.GetKeyDown(9);
        if (cVar1) {
          if (this.missionUI == null) {
        LAB_18084b6f9:
                          // WARNING: Subroutine does not return
            FUN_1801e0300();
          }
          cVar1 = GameObject.get_activeInHierarchy(this.missionUI,0);
          if (cVar1) {
            if (*pStatics == 0) goto LAB_18084b6f9;
            if (*(char *)(*pStatics + 56) == false) {
              MissionUIController.ShowMissionUI(this,!this.showUI,0);
              plVar2 = (int64 *)Resources.Load("Sound/SoundEffect/Button/TabButton",0);
              plVar3 = (int64 *)0;
              if ((plVar2 != (int64 *)0) && (*plVar2 == DAT_181e8f4a0)) {
                plVar3 = plVar2;
              }
              NGUITools.PlaySound(plVar3,0);
              return;
            }
          }
        }
    }

    // Token : 0x60019C7
    // RVA   : 0x848D50   Offset: 0x847B50   Length: 0x9A2
    public void RefreshForceMission()
    {
        var pStatics_b8e8 = *(int64*)(DAT_181e8b8e8 + 184);
        bool cVar1;
        long lVar2;
        long lVar3;
        ulong uVar4;
        ulong uVar6;
        ulong uVar7;
        long lVar8;
        float fVar10;
        float fVar11;
        int[] local_res18 = new int[2];
        int[] local_res20 = new int[2];
        uint local_48;
        uint uStack_44;
        uint uStack_40;
        uint32 uStack_3c;
        if (((GameController._instance == null) ||
            (lVar8 = GameController._instance.worldData) == null) ||
           (lVar2 = WorldData.Player(lVar8,0)) == null) goto LAB_1808496cf;
        cVar1 = HeroData.HaveForce(lVar2,0);
        if (((cVar1) && (*(char *)(lVar2 + 180) == false)) || (*(int64 *)(lVar2 + 0x2e0) != 0))
        {
          lVar3 = lVar8.worldTime;
          if (lVar3 == null) goto LAB_1808496cf;
          if ((1 < *(int *)(lVar3 + 16)) || (2 < *(int *)(lVar3 + 20))) {
            if (this.forceMission != null) {
              cVar1 = GameObject.get_activeSelf(this.forceMission,0);
              if (!cVar1) {
                if (this.forceMission == null) goto LAB_1808496cf;
                GameObject.SetActive(this.forceMission,1,0);
                this.forceMissionRefreshTimer = 0;
              }
              fVar11 = this.forceMissionRefreshTimer;
              fVar10 = (float)Time.get_unscaledDeltaTime(0);
              fVar11 = fVar11 - fVar10;
              this.forceMissionRefreshTimer = fVar11;
              if (0.0 < fVar11) {
                return;
              }
              this.forceMissionRefreshTimer = 0x3e800000;
              MissionUIController.EnsureForceMissionRefs(this,0);
              if ((*(int64 *)(lVar2 + 0x2e0) == 0) ||
                 (cVar1 = FUN_1816387f0(*(uint64 *)(*(int64 *)(lVar2 + 0x2e0) + 24),""
                                        ,0), cVar1)) {
                lVar3 = this.forceMissionIcon;
                if ((*pStatics_b8e8 != 0) &&
                   (uVar4 = TextureController.LoadAtlasSprite
                                      (*pStatics_b8e8,"UIAtlas","门派会议",0
                                      ), lVar3 != null)) {
                  Image.set_sprite(lVar3,uVar4,0);
                  if (this.forceMissionDetailText != null) {
                    this.forceMissionDetailText.text = "<i>每月一日门派正厅召开会议\n持续五日</i>";
                    plVar9 = this.forceMissionIcon;
                    if (!lVar8.forceMeetingStarted) {
                      puVar5 = (uint32 *)FUN_180f24b80();
                      if (plVar9 != (int64 *)0) {
                        local_48 = *puVar5;
                        uStack_44 = puVar5[1];
                        uStack_40 = puVar5[2];
                        uStack_3c = puVar5[3];
                        (**(code **)(*plVar9 + 0x2a8))(plVar9,&local_48,*(uint64 *)(*plVar9 + 0x2b0));
                        lVar3 = DAT_181e6dc98;
                        uVar4 = this.forceMissionText;
                        lVar2 = **(int64 **)(DAT_181e6dc98 + 48);
                        if ((*(byte *)(lVar2 + 0x132) & 1) == 0) {
                          FUN_1801a41f0(lVar2);
                        }
                        if ((*(byte *)(lVar2 + 0x133) & 4) != 0) {
                          lVar2 = **(int64 **)(lVar3 + 48);
                          if ((*(byte *)(lVar2 + 0x132) & 1) == 0) {
                            FUN_1801a41f0(lVar2);
                          }
                          if (*(int *)(lVar2 + 224) == 0) {
                            lVar2 = **(int64 **)(lVar3 + 48);
                            if ((*(byte *)(lVar2 + 0x132) & 1) == 0) {
                              FUN_1801a41f0(lVar2);
                            }
                            il2cpp_runtime_class_init(lVar2);
                          }
                        }
                        lVar2 = **(int64 **)(lVar3 + 48);
                        if ((*(byte *)(lVar2 + 0x132) & 1) == 0) {
                          FUN_1801a41f0(lVar2);
                        }
                        uVar6 = String.Format("等待下次门派会议",**(uint64 **)(lVar2 + 184),0);
                        LTLocalization.SetText(uVar4,uVar6,0);
                        uVar4 = *(uint64 *)(this + 200);
                        if (lVar8.worldTime != null) {
                          local_res18[0] = TimeData.NextMeetingTime(lVar8.worldTime,0);
                          uVar6 = il2cpp_value_box(DAT_181e60808,local_res18);
                          uVar6 = String.Format("{0}日",uVar6,0);
                          LTLocalization.SetText(uVar4,uVar6,0);
                          plVar9 = *(int64 **)(this + 200);
                          puVar5 = (uint32 *)Color.get_black(&local_48,0);
                          if (plVar9 != (int64 *)0) {
        LAB_180849675:
                            local_48 = *puVar5;
                            uStack_44 = puVar5[1];
                            uStack_40 = puVar5[2];
                            uStack_3c = puVar5[3];
                            (**(code **)(*plVar9 + 0x2a8))
                                      (plVar9,&local_48,*(uint64 *)(*plVar9 + 0x2b0));
                            return;
                          }
                        }
                      }
                          // WARNING: Subroutine does not return
                      FUN_1801e0300();
                    }
                    puVar5 = (uint32 *)FUN_180f24d00(&local_48);
                    if (plVar9 != (int64 *)0) {
                      local_48 = *puVar5;
                      uStack_44 = puVar5[1];
                      uStack_40 = puVar5[2];
                      uStack_3c = puVar5[3];
                      (**(code **)(*plVar9 + 0x2a8))(plVar9,&local_48,*(uint64 *)(*plVar9 + 0x2b0));
                      uVar4 = this.forceMissionText;
                      LTLocalization.SetText(uVar4,"门派会议已召开\n",0);
                      if ((*(int *)(lVar2 + 184) < 2) ||
                         ((*(int *)(lVar2 + 184) < 4 && (0 < lVar8.forceMeetingMissedTime)))) {
                        uVar4 = this.forceMissionText;
                        if (lVar8.worldTime == null) {
                          // WARNING: Subroutine does not return
                          FUN_1801e0300();
                        }
                        local_res18[0] = 6 - *(int *)(lVar8.worldTime + 24);
                        uVar7 = il2cpp_value_box(DAT_181e60808,local_res18);
                        uVar6 = "尽快返回门派正厅！";
                      }
                      else {
                        uVar4 = this.forceMissionText;
                        if (lVar8.worldTime == null) {
                          // WARNING: Subroutine does not return
                          FUN_1801e0300();
                        }
                        local_res18[0] = 6 - *(int *)(lVar8.worldTime + 24);
                        uVar7 = il2cpp_value_box(DAT_181e60808,local_res18);
                        uVar6 = "可以不参加";
                      }
                      uVar6 = String.Format(uVar6,uVar7,0);
                      LTLocalization.AddText(uVar4,uVar6,0);
                      uVar4 = *(uint64 *)(this + 200);
                      if (lVar8.worldTime != null) {
                        local_res18[0] = 6 - *(int *)(lVar8.worldTime + 24);
                        uVar6 = il2cpp_value_box(DAT_181e60808,local_res18);
                        uVar6 = String.Format("{0}日",uVar6,0);
                        LTLocalization.SetText(uVar4,uVar6,0);
                        plVar9 = *(int64 **)(this + 200);
                        puVar5 = (uint32 *)Color.get_red(&local_48,0);
                        if (plVar9 != (int64 *)0) goto LAB_180849675;
                      }
                          // WARNING: Subroutine does not return
                      FUN_1801e0300();
                    }
                  }
                }
              }
              else {
                lVar8 = this.forceMissionIcon;
                lVar3 = FUN_180210d00(0);
                if ((lVar3 != null) &&
                   (uVar4 = TextureController.LoadAtlasSprite(lVar3,"UIAtlas","门派任务",0),
                   lVar8 != null)) {
                  Image.set_sprite(lVar8,uVar4,0);
                  plVar9 = this.forceMissionIcon;
                  puVar5 = (uint32 *)FUN_180f24d00(&local_48,0);
                  if (plVar9 != (int64 *)0) {
                    local_48 = *puVar5;
                    uStack_44 = puVar5[1];
                    uStack_40 = puVar5[2];
                    uStack_3c = puVar5[3];
                    (**(code **)(*plVar9 + 0x2a8))(plVar9,&local_48,*(uint64 *)(*plVar9 + 0x2b0));
                    uVar4 = this.forceMissionText;
                    if (*(int64 *)(lVar2 + 0x2e0) != 0) {
                      uVar6 = MissionData.GetMissionDescribe(*(int64 *)(lVar2 + 0x2e0),0,0,1,0,0);
                      uVar6 = String.Concat("门派任务\n",uVar6,0);
                      LTLocalization.SetText(uVar4,uVar6,0);
                      uVar4 = *(uint64 *)(this + 200);
                      uVar6 = "";
                      if (*(char *)(lVar2 + 180) == false) {
                        lVar8 = *(int64 *)(lVar2 + 0x2e0);
                        if (lVar8 == null) goto LAB_1808496cf;
                        if (lVar8.resizeHeightWidth < 0) {
                          if (((*(byte *)(DAT_181e538e8 + 0x133) & 4) != 0) &&
                             (*(int *)(DAT_181e538e8 + 224) == 0)) {
                            il2cpp_runtime_class_init(DAT_181e538e8);
                            lVar8 = *(int64 *)(lVar2 + 0x2e0);
                          }
                          uVar6 = *(uint64 *)(*(int64 *)(DAT_181e538e8 + 184) + 0x2d8);
                          if (lVar8 == null) {
                          // WARNING: Subroutine does not return
                            FUN_1801e0300();
                          }
                          local_res20[0] = -lVar8.resizeHeightWidth;
                          uVar7 = il2cpp_value_box(DAT_181e60808,local_res20);
                          uVar6 = String.Format("{0}{1}日</color>",uVar6,uVar7,0);
                        }
                        else {
                          local_res18[0] = lVar8.resizeHeightWidth;
                          uVar6 = il2cpp_value_box(DAT_181e60808,local_res18);
                          uVar6 = String.Format("{0}日",uVar6,0);
                        }
                      }
                      LTLocalization.SetText(uVar4,uVar6,0);
                      plVar9 = *(int64 **)(this + 200);
                      puVar5 = (uint32 *)Color.get_black(&local_48,0);
                      if (plVar9 != (int64 *)0) {
                        local_48 = *puVar5;
                        uStack_44 = puVar5[1];
                        uStack_40 = puVar5[2];
                        uStack_3c = puVar5[3];
                        (**(code **)(*plVar9 + 0x2a8))(plVar9,&local_48,*(uint64 *)(*plVar9 + 0x2b0));
                        if (*(char *)(lVar2 + 180) == false) {
                          if (*(int64 *)(lVar2 + 0x2e0) == 0) goto LAB_1808496cf;
                          cVar1 = MissionData.MissionNeedFinished(*(int64 *)(lVar2 + 0x2e0),0,0);
                          lVar8 = this.forceMissionDetailText;
                          uVar4 = "<i>目标已满足\n返回门派正厅复命</i>";
                          if (!cVar1) {
                            uVar4 = "<i>请在时限内完成任务\n然后返回门派正厅复命</i>";
                          }
                        }
                        else {
                          lVar8 = this.forceMissionDetailText;
                          uVar4 = "";
                        }
                        if (lVar8 != null) {
                          lVar8.text = uVar4;
                          return;
                        }
                      }
                    }
                  }
                }
              }
            }
            goto LAB_1808496cf;
          }
        }
        if (this.forceMission == null) {
        LAB_1808496cf:
                          // WARNING: Subroutine does not return
          FUN_1801e0300();
        }
        cVar1 = GameObject.get_activeSelf(this.forceMission,0);
        if (cVar1) {
          if (this.forceMission == null) goto LAB_1808496cf;
          GameObject.SetActive(this.forceMission,0,0);
        }
        this.forceMissionRefreshTimer = 0;
    }

    // Token : 0x60019C8
    // RVA   : 0x848810   Offset: 0x847610   Length: 0x1FC
    public void PlayPigeonAnim()
    {
        bool cVar1;
        ulong uVar2;
        ulong uVar3;
        ulong in_stack_ffffffffffffffa8;
        uint uVar4;
        ulong local_38;
        ulong uStack_30;
        ulong local_28;
        ulong uStack_20;
        uint local_18;
        uVar4 = (uint32)((uint64)in_stack_ffffffffffffffa8 >> 32);
        if (this.pigeonTween != null) {
          cVar1 = TweenExtensions.IsPlaying(this.pigeonTween,0);
          if (!cVar1) {
            TweenExtensions.Restart(this.pigeonTween,1,0xbf800000,0);
          }
          return;
        }
        if (this.pigeon != null) {
          uVar3 = GameObject.get_transform(this.pigeon,0);
          local_18 = 0;
          local_28 = 0;
          uStack_20 = 0;
          uVar3 = ShortcutExtensions.DOLocalPath
                            (uVar3,this.pigeonPath,0x3fc00000,1,CONCAT44(uVar4,3),10,
                             &local_28,0);
          local_38 = 0;
          uStack_30 = 0;
          local_28 = 0;
          uStack_20 = 0;
          uVar3 = TweenSettingsExtensions.SetLookAt(uVar3,0,&local_28,&local_38,0);
          uVar3 = TweenSettingsExtensions.SetEase(uVar3,10,DAT_181ea4b00);
          uVar2 = new OnTooltipCB(this,DAT_181e6fff8,0);
          uVar3 = TweenSettingsExtensions.OnPlay(uVar3,uVar2,DAT_181ea3f58);
          uVar2 = new OnTooltipCB(this,DAT_181e70078,0);
          uVar3 = TweenSettingsExtensions.OnComplete(uVar3,uVar2,DAT_181ea3d38);
          this.pigeonTween = uVar3;
          return;
        }
    }

    // Token : 0x60019C9
    // RVA   : 0x84ACE0   Offset: 0x849AE0   Length: 0x96
    public void ShowMissionUI(bool showState)
    {
        long lVar1;
        lVar1 = this.missionUI;
        if (!showState) {
          this.showUI = 0;
          if (lVar1 != null) {
            lVar1 = GameObject.GetComponent(lVar1,DAT_181e57588);
            if (lVar1 != null) {
              UITweener.PlayReverse(lVar1,0);
              return;
            }
          }
        }
        else {
          this.showUI = 1;
          if (lVar1 != null) {
            lVar1 = GameObject.GetComponent(lVar1,DAT_181e57588);
            if (lVar1 != null) {
              UITweener.PlayForward(lVar1,0);
              return;
            }
          }
        }
    }

    // Token : 0x60019CA
    // RVA   : 0x84AEA0   Offset: 0x849CA0   Length: 0x3EB
    public void ToggleButtonClicked(GameObject buttonClicked)
    {
        int iVar1;
        long lVar2;
        ulong uVar3;
        long lVar4;
        uint uVar7;
        uint local_38;
        uint uStack_34;
        uint uStack_30;
        uint32 uStack_2c;
        uint64 local_28;
        uint64 uStack_20;
        if ((buttonClicked == null) || (lVar2 = GameObject.GetComponent(buttonClicked,DAT_181e57478)) == null)
        throw; // [null/range check failed]
        if (*(char *)(lVar2 + 0x118) != false) {
          if (!this.showUI) {
            this.showUI = 1;
            if ((this.missionUI == null) ||
               (lVar2 = GameObject.GetComponent(this.missionUI,DAT_181e57588)) == null
               ) throw; // [null/range check failed]
            UITweener.PlayForward(lVar2,0);
          }
          else {
            if (this.toggleButton == null) throw; // [null/range check failed]
            iVar1 = FUN_181662a20(this.toggleButton,buttonClicked,DAT_181e6b878);
            if (iVar1 == this.nowShowType) {
              this.showUI = 0;
              if ((this.missionUI == null) ||
                 (lVar2 = GameObject.GetComponent(this.missionUI,DAT_181e57588),
                 lVar2 == null)) throw; // [null/range check failed]
              UITweener.PlayReverse(lVar2,0);
            }
          }
          if (this.toggleButton == null) throw; // [null/range check failed]
          iVar1 = FUN_181662a20(this.toggleButton,buttonClicked,DAT_181e6b878);
          this.nowShowType = iVar1;
          if (iVar1 == 2) {
            uVar3 = MissionUIController.RebuildMailTable(this,0);
            FUN_180ae80b0(this,uVar3,0);
          }
        }
        lVar2 = GameObject.get_transform(buttonClicked,0);
        lVar4 = GameObject.GetComponent(buttonClicked,DAT_181e57478);
        if (lVar4 != null) {
          if (*(char *)(lVar4 + 0x118) == false) {
            uVar7 = 0xc3390000;
          }
          else {
            uVar7 = 0xc3480000;
          }
          lVar4 = GameObject.get_transform(buttonClicked,0);
          if (lVar4 != null) {
            puVar5 = (uint64 *)Transform.get_localPosition(&local_28,lVar4,0);
            local_28 = *puVar5;
            uStack_34 = (uint32)((uint64)local_28 >> 32);
            uStack_30 = 0;
            uStack_20 = CONCAT44(uStack_20._4_4_,*(uint32 *)(puVar5 + 1));
            local_38 = uVar7;
            if (lVar2 != null) {
              local_28 = CONCAT44(uStack_34,uVar7);
              uStack_20 = (uint64)uStack_20._4_4_ << 32;
              Transform.set_localPosition(lVar2,&local_28,0);
              plVar6 = (int64 *)GameObject.GetComponent(buttonClicked,DAT_181e54f48);
              lVar2 = GameObject.GetComponent(buttonClicked,DAT_181e57478);
              if (lVar2 != null) {
                uVar7 = 0x3f800000;
                if (*(char *)(lVar2 + 0x118) == false) {
                  uVar7 = 0x3f4ccccd;
                }
                local_28 = 0;
                uStack_20 = 0;
                FUN_1807282e0(&local_28,0x3f800000,0x3f800000,0x3f800000,uVar7,0);
                if (plVar6 == (int64 *)0) {
                          // WARNING: Subroutine does not return
                  FUN_1801e0300();
                }
                local_38 = (uint32)local_28;
                uStack_34 = local_28._4_4_;
                uStack_30 = (uint32)uStack_20;
                uStack_2c = uStack_20._4_4_;
                (**(code **)(*plVar6 + 0x2a8))(plVar6,&local_38,*(uint64 *)(*plVar6 + 0x2b0));
                if (this.nowShowType == 2) {
                  lVar2 = GameObject.get_transform(buttonClicked,0);
                  if (lVar2 == null) throw; // [null/range check failed]
                  lVar2 = Transform.Find(lVar2,"Pigeon",0);
                  uVar3 = DAT_181e78a38;
                }
                else {
                  lVar2 = GameObject.get_transform(buttonClicked,0);
                  if (lVar2 == null) throw; // [null/range check failed]
                  lVar2 = Transform.Find(lVar2,"Mark",0);
                  uVar3 = DAT_181e777b8;
                }
                if (lVar2 != null) {
                  plVar6 = (int64 *)Component.GetComponent(lVar2,uVar3);
                  lVar2 = GameObject.GetComponent(buttonClicked);
                  if (lVar2 != null) {
                    if (*(char *)(lVar2 + 0x118) == false) {
                      puVar5 = (uint64 *)FUN_180f24b80(&local_28);
                    }
                    else {
                      puVar5 = (uint64 *)FUN_180f24d00();
                    }
                    if (plVar6 != (int64 *)0) {
                      local_28 = *puVar5;
                      uStack_20 = puVar5[1];
                      (**(code **)(*plVar6 + 0x2a8))(plVar6,&local_28,*(uint64 *)(*plVar6 + 0x2b0));
                      return;
                    }
                  }
                }
              }
            }
          }
        }
    }

    // Token : 0x60019CB
    // RVA   : 0x848CE0   Offset: 0x847AE0   Length: 0x6C
    public IEnumerator RebuildMailTable()
    {
        long lVar1;
        lVar1 = new WarpText_d__8(0,0);
        if (lVar1 != null) {
          *(uint64 *)(lVar1 + 32) = this;
          return lVar1;
        }
    }

    // Token : 0x60019CC
    // RVA   : 0x848390   Offset: 0x847190   Length: 0x25D
    public void ClearMailButtonClicked()
    {
        int iVar1;
        long lVar3;
        bVar2 = false;
        if (((GameController._instance != null) &&
            (lVar3 = GameController._instance.worldData) != null) &&
           (lVar3 = lVar3.MailDatas) != null) {
          iVar1 = lVar3.cityAreaID;
          while( true ) {
            do {
              iVar1 = iVar1 + -1;
              if (iVar1 < 0) {
                plVar4 = (int64 *)Resources.Load("Sound/SoundEffect/PaperQuick",0);
                plVar5 = (int64 *)0;
                if ((plVar4 != (int64 *)0) && (*plVar4 == DAT_181e8f4a0)) {
                  plVar5 = plVar4;
                }
                NGUITools.PlaySound(plVar5,0);
                if (bVar2) {
                  MissionUIController.RefreshMailTable(this,0);
                }
                return;
              }
              lVar3 = FUN_1802106e0(0);
              if ((((lVar3 == null) || (lVar3.villageAreaID == null)) ||
                  (lVar3 = *(int64 *)(lVar3.villageAreaID + 144)) == null) ||
                 (lVar3 = FUN_1800024b0(lVar3,iVar1,DAT_181e75a70)) == null) throw; // [null/range check failed]
            } while (*(char *)(lVar3 + 41) == false);
            lVar3 = FUN_1802106e0(0);
            if (((lVar3 == null) || (lVar3.villageAreaID == null)) ||
               (lVar3 = *(int64 *)(lVar3.villageAreaID + 144)) == null) break;
            FUN_181763390(lVar3,iVar1,DAT_181e75970);
            bVar2 = true;
          }
        }
    }

    // Token : 0x60019CD
    // RVA   : 0x848A10   Offset: 0x847810   Length: 0x2C6
    public void ReadAllMailButtonClicked()
    {
        int iVar1;
        long lVar3;
        bVar2 = false;
        if (((GameController._instance != null) &&
            (lVar3 = GameController._instance.worldData) != null) &&
           (lVar3 = lVar3.MailDatas) != null) {
          iVar1 = lVar3.cityAreaID;
          while( true ) {
            do {
              do {
                iVar1 = iVar1 + -1;
                if (iVar1 < 0) {
                  plVar4 = (int64 *)Resources.Load("Sound/SoundEffect/PaperQuick",0);
                  plVar5 = (int64 *)0;
                  if ((plVar4 != (int64 *)0) && (*plVar4 == DAT_181e8f4a0)) {
                    plVar5 = plVar4;
                  }
                  NGUITools.PlaySound(plVar5,0);
                  if (bVar2) {
                    MissionUIController.RefreshMailTable(this,0);
                  }
                  return;
                }
                lVar3 = FUN_1802106e0(0);
                if ((((lVar3 == null) || (lVar3.villageAreaID == null)) ||
                    (lVar3 = *(int64 *)(lVar3.villageAreaID + 144)) == null) ||
                   (lVar3 = FUN_1800024b0(lVar3,iVar1,DAT_181e75a70)) == null) throw; // [null/range check failed]
              } while (*(char *)(lVar3 + 41) != false);
              lVar3 = FUN_1802106e0(0);
              if (((lVar3 == null) || (lVar3.villageAreaID == null)) ||
                 ((lVar3 = *(int64 *)(lVar3.villageAreaID + 144), lVar3 == null ||
                  (lVar3 = FUN_1800024b0(lVar3,iVar1,DAT_181e75a70)) == null))) throw; // [null/range check failed]
            } while (lVar3.forceAreaID);
            lVar3 = FUN_1802106e0(0);
            if ((((lVar3 == null) || (lVar3.villageAreaID == null)) ||
                (lVar3 = *(int64 *)(lVar3.villageAreaID + 144)) == null) ||
               (lVar3 = FUN_1800024b0(lVar3,iVar1,DAT_181e75a70)) == null) break;
            *(uint8 *)(lVar3 + 41) = 1;
            bVar2 = true;
          }
        }
    }

    // Token : 0x60019CE
    // RVA   : 0x849700   Offset: 0x848500   Length: 0x344
    public void RefreshMailNewIcon()
    {
        long lVar1;
        long lVar2;
        ulong uVar3;
        ulong uVar4;
        int iVar5;
        int[] local_res18 = new int[4];
        local_res18[0] = 0;
        iVar5 = 0;
        while( true ) {
          lVar2 = GameController._instance;
          if (((lVar2 == null) || (lVar2.worldData == null)) ||
             (lVar1 = *(int64 *)(lVar2.worldData + 144)) == null) throw; // [null/range check failed]
          if (*(int *)(lVar1 + 24) <= iVar5) break;
          lVar2 = FUN_1802106e0(0);
          if ((((lVar2 == null) || (lVar2.worldData == null)) ||
              (lVar2 = *(int64 *)(lVar2.worldData + 144)) == null) ||
             (lVar2 = FUN_1800024b0(lVar2,iVar5)) == null) throw; // [null/range check failed]
          if (*(char *)(lVar2 + 41) == false) {
            local_res18[0] = local_res18[0] + 1;
          }
          iVar5 = iVar5 + 1;
        }
        lVar1 = this.mailNewNumIcon;
        if (local_res18[0] < 1) {
          if (lVar1 != null) {
            GameObject.SetActive(lVar1,0,0);
            if (((this.pigeon != null) &&
                (lVar2 = GameObject.GetComponent(this.pigeon,DAT_181e566a8), lVar2 != null
                )) && ((lVar2 = SkeletonGraphic.get_AnimationState(lVar2,0), lVar2 != null &&
                       (lVar2 = AnimationState.GetCurrent(lVar2,0,0)) != null))) {
              *(uint32 *)(lVar2 + 144) = 0;
              if (((this.pigeon != null) &&
                  (lVar2 = GameObject.GetComponent(this.pigeon,DAT_181e566a8),
                  lVar2 != null)) && (lVar2 = SkeletonGraphic.get_AnimationState(lVar2,0)) != null) {
                *(uint32 *)(lVar2 + 108) = 0;
                return;
              }
            }
          }
        }
        else if (lVar1 != null) {
          GameObject.SetActive(lVar1,CONCAT71((int7)((uint64)lVar2 >> 8),1),0);
          if (((this.mailNewNumIcon != null) &&
              (lVar2 = GameObject.get_transform(this.mailNewNumIcon,0)) != null) &&
             (lVar2 = Transform.Find(lVar2,"NewNum",0)) != null) {
            uVar3 = Component.GetComponent(lVar2,DAT_181e79538);
            uVar4 = "⋯";
            if (local_res18[0] < 10) {
              uVar4 = Int32.ToString(local_res18,0);
            }
            LTLocalization.SetText(uVar3,uVar4,0);
            if (((this.pigeon != null) &&
                (lVar2 = GameObject.GetComponent(this.pigeon,DAT_181e566a8), lVar2 != null
                )) && (lVar2 = SkeletonGraphic.get_AnimationState(lVar2,0)) != null) {
              *(uint32 *)(lVar2 + 108) = 0x3f800000;
              return;
            }
          }
        }
    }

    // Token : 0x60019CF
    // RVA   : 0x849A50   Offset: 0x848850   Length: 0x6F1
    public void RefreshMailTable()
    {
        ulong uVar1;
        bool cVar2;
        int iVar3;
        int iVar4;
        long lVar5;
        long lVar6;
        ulong uVar7;
        if ((this.mailTable != null) &&
           (lVar5 = GameObject.get_transform(this.mailTable,0)) != null) {
          iVar3 = Transform.get_childCount(lVar5,0);
          while (iVar3 = iVar3 + -1, 1 < iVar3) {
            lVar5 = FUN_1802106e0(0);
            if ((lVar5 == null) || (lVar5.villageAreaID == null)) throw; // [null/range check failed]
            lVar5 = *(int64 *)(lVar5.villageAreaID + 144);
            if (((this.mailTable == null) ||
                (((lVar6 = GameObject.get_transform(this.mailTable,0), lVar6 == null ||
                  (lVar6 = Transform.GetChild(lVar6,iVar3,0)) == null) ||
                 (lVar6 = Component.GetComponent(lVar6,DAT_181e77c38)) == null))) || (lVar5 == null))
            throw; // [null/range check failed]
            cVar2 = FUN_18175e190(lVar5,*(uint64 *)(lVar6 + 24));
            lVar5 = this.mailTable;
            if (!cVar2) {
              if (((lVar5 == null) || (lVar5 = GameObject.get_transform(lVar5,0)) == null) ||
                 (lVar5 = Transform.GetChild(lVar5,iVar3,0)) == null) throw; // [null/range check failed]
              uVar7 = Component.get_gameObject(lVar5);
              Object.Destroy(uVar7);
            }
            else {
              if ((((lVar5 == null) || (lVar5 = GameObject.get_transform(lVar5,0)) == null) ||
                  (lVar5 = Transform.GetChild(lVar5,iVar3,0)) == null) ||
                 (lVar5 = Component.GetComponent(lVar5)) == null) throw; // [null/range check failed]
              MailIconController.RefreshNoticeText(lVar5);
            }
          }
          iVar3 = 0;
          while( true ) {
            if (((GameController._instance == null) ||
                (lVar5 = GameController._instance.worldData) == null) ||
               (lVar5 = lVar5.MailDatas) == null) throw; // [null/range check failed]
            if (lVar5.cityAreaID <= iVar3) break;
            if ((this.mailTable == null) ||
               (lVar5 = GameObject.get_transform(this.mailTable,0)) == null)
            throw; // [null/range check failed]
            iVar4 = Transform.get_childCount(lVar5,0);
            do {
              iVar4 = iVar4 + -1;
              if (iVar4 < 2) {
                uVar7 = this.mailTable;
                uVar1 = this.mailIconPrefab;
                uVar7 = GlobalData.AddChild(uVar7,uVar1,0);
                this.temp = uVar7;
                if ((this.temp == null) ||
                   (lVar5 = GameObject.get_transform(this.temp,0)) == null)
                throw; // [null/range check failed]
                Transform.SetSiblingIndex(lVar5,2);
                if (this.temp == null) throw; // [null/range check failed]
                lVar5 = GameObject.GetComponent(this.temp,DAT_181e55410);
                lVar6 = FUN_1802106e0(0);
                if ((((lVar6 == null) || (*(int64 *)(lVar6 + 32) == 0)) ||
                    (lVar6 = *(int64 *)(*(int64 *)(lVar6 + 32) + 144)) == null) ||
                   (uVar7 = FUN_1800024b0(lVar6,iVar3), lVar5 == null)) throw; // [null/range check failed]
                lVar5.cityAreaID = uVar7;
                break;
              }
              if (((this.mailTable == null) ||
                  (lVar5 = GameObject.get_transform(this.mailTable,0)) == null) ||
                 ((lVar5 = Transform.GetChild(lVar5,iVar4,0), lVar5 == null ||
                  (lVar5 = Component.GetComponent(lVar5,DAT_181e77c38)) == null)))
              throw; // [null/range check failed]
              lVar5 = lVar5.cityAreaID;
              lVar6 = FUN_1802106e0(0);
              if (((lVar6 == null) || (*(int64 *)(lVar6 + 32) == 0)) ||
                 (*(int64 *)(*(int64 *)(lVar6 + 32) + 144) == 0)) throw; // [null/range check failed]
              lVar6 = FUN_1800024b0();
            } while (lVar5 != lVar6);
            iVar3 = iVar3 + 1;
          }
          lVar5 = FUN_1802106e0(0);
          if (((lVar5 != null) && (lVar5.villageAreaID != null)) &&
             (lVar5 = *(int64 *)(lVar5.villageAreaID + 144)) != null) {
            lVar6 = this.mailTable;
            if (lVar5.cityAreaID == null) {
              if ((((lVar6 != null) && (lVar5 = GameObject.get_transform(lVar6,0)) != null) &&
                  (lVar5 = Transform.Find(lVar5,"ClearMailButton",0)) != null) &&
                 (lVar5 = Component.GetComponent(lVar5,DAT_181e76ab8)) != null) {
                Selectable.set_interactable(lVar5,0,0);
                if (((this.mailTable != null) &&
                    (lVar5 = GameObject.get_transform(this.mailTable,0)) != null) &&
                   ((lVar5 = Transform.Find(lVar5,"ReadAllMailButton",0), lVar5 != null &&
                    (lVar5 = Component.GetComponent(lVar5,DAT_181e76ab8)) != null))) {
                  uVar7 = 0;
                  goto LAB_18084a0fb;
                }
              }
            }
            else if (((lVar6 != null) && (lVar5 = GameObject.get_transform(lVar6,0)) != null) &&
                    ((lVar5 = Transform.Find(lVar5,"ClearMailButton",0), lVar5 != null &&
                     (lVar5 = Component.GetComponent(lVar5,DAT_181e76ab8)) != null))) {
              Selectable.set_interactable(lVar5,1,0);
              if ((((this.mailTable != null) &&
                   (lVar5 = GameObject.get_transform(this.mailTable,0)) != null) &&
                  (lVar5 = Transform.Find(lVar5,"ReadAllMailButton",0)) != null) &&
                 (lVar5 = Component.GetComponent(lVar5,DAT_181e76ab8)) != null) {
                uVar7 = 1;
        LAB_18084a0fb:
                Selectable.set_interactable(lVar5,uVar7,0);
                MissionUIController.RefreshMailNewIcon(this,0);
                uVar7 = MissionUIController.RebuildMailTable(this,0);
                FUN_180ae80b0(this,uVar7,0);
                return;
              }
            }
          }
        }
    }

    // Token : 0x60019D0
    // RVA   : 0x84A600   Offset: 0x849400   Length: 0x260
    public void RefreshWorldEventNewIcon()
    {
        long lVar1;
        long lVar2;
        ulong uVar3;
        ulong uVar4;
        int iVar5;
        int[] local_res18 = new int[4];
        iVar5 = 0;
        local_res18[0] = 0;
        while( true ) {
          lVar2 = GameController._instance;
          if (((lVar2 == null) || (lVar2.worldData == null)) ||
             (lVar1 = *(int64 *)(lVar2.worldData + 128)) == null) throw; // [null/range check failed]
          if (*(int *)(lVar1 + 24) <= iVar5) break;
          lVar2 = FUN_1802106e0(0);
          if ((((lVar2 == null) || (lVar2.worldData == null)) ||
              (lVar2 = *(int64 *)(lVar2.worldData + 128)) == null) ||
             (lVar2 = FUN_1800024b0(lVar2,iVar5)) == null) throw; // [null/range check failed]
          if (*(char *)(lVar2 + 98) == false) {
            local_res18[0] = local_res18[0] + 1;
          }
          iVar5 = iVar5 + 1;
        }
        lVar1 = this.worldEventNewNumIcon;
        if (local_res18[0] < 1) {
          if (lVar1 != null) {
            GameObject.SetActive(lVar1,0,0);
            return;
          }
        }
        else if (lVar1 != null) {
          GameObject.SetActive(lVar1,CONCAT71((int7)((uint64)lVar2 >> 8),1),0);
          if (((this.worldEventNewNumIcon != null) &&
              (lVar2 = GameObject.get_transform(this.worldEventNewNumIcon,0)) != null) &&
             (lVar2 = Transform.Find(lVar2,"NewNum",0)) != null) {
            uVar3 = Component.GetComponent(lVar2,DAT_181e79538);
            uVar4 = "⋯";
            if (local_res18[0] < 10) {
              uVar4 = Int32.ToString(local_res18,0);
            }
            LTLocalization.SetText(uVar3,uVar4,0);
            return;
          }
        }
    }

    // Token : 0x60019D1
    // RVA   : 0x84A870   Offset: 0x849670   Length: 0x46E
    public void RefreshWorldEventTable()
    {
        ulong uVar1;
        bool cVar2;
        int iVar3;
        int iVar4;
        long lVar5;
        long lVar6;
        ulong uVar7;
        if ((this.worldEventTable != null) &&
           (lVar5 = GameObject.get_transform(this.worldEventTable,0)) != null) {
          iVar3 = Transform.get_childCount(lVar5,0);
          while (iVar3 = iVar3 + -1, -1 < iVar3) {
            lVar5 = FUN_1802106e0(0);
            if ((lVar5 == null) || (lVar5.villageAreaID == null)) throw; // [null/range check failed]
            lVar5 = *(int64 *)(lVar5.villageAreaID + 128);
            if (((this.worldEventTable == null) ||
                (((lVar6 = GameObject.get_transform(this.worldEventTable,0), lVar6 == null ||
                  (lVar6 = Transform.GetChild(lVar6,iVar3,0)) == null) ||
                 (lVar6 = Component.GetComponent(lVar6,DAT_181e7a638)) == null))) || (lVar5 == null))
            throw; // [null/range check failed]
            cVar2 = FUN_18175e190(lVar5);
            if (!cVar2) {
              if (((this.worldEventTable == null) ||
                  (lVar5 = GameObject.get_transform(this.worldEventTable,0)) == null) ||
                 (lVar5 = Transform.GetChild(lVar5,iVar3,0)) == null) throw; // [null/range check failed]
              uVar7 = Component.get_gameObject(lVar5);
              Object.Destroy(uVar7);
            }
          }
          iVar3 = 0;
          while( true ) {
            if (((GameController._instance == null) ||
                (lVar5 = GameController._instance.worldData) == null) ||
               (lVar5 = lVar5.WorldEventDatas) == null) break;
            if (lVar5.cityAreaID <= iVar3) {
              MissionUIController.RefreshWorldEventNewIcon(this,0);
              return;
            }
            if ((this.worldEventTable == null) ||
               (lVar5 = GameObject.get_transform(this.worldEventTable,0)) == null) break;
            iVar4 = Transform.get_childCount(lVar5,0);
            do {
              iVar4 = iVar4 + -1;
              if (iVar4 < 0) {
                uVar7 = this.worldEventTable;
                uVar1 = this.worldEventIconPrefab;
                uVar7 = GlobalData.AddChild(uVar7,uVar1,0);
                this.temp = uVar7;
                if (this.temp == null) throw; // [null/range check failed]
                lVar5 = GameObject.GetComponent(this.temp,DAT_181e57d80);
                lVar6 = FUN_1802106e0(0);
                if ((((lVar6 == null) || (*(int64 *)(lVar6 + 32) == 0)) ||
                    (lVar6 = *(int64 *)(*(int64 *)(lVar6 + 32) + 128)) == null) ||
                   (uVar7 = FUN_1800024b0(lVar6,iVar3), lVar5 == null)) throw; // [null/range check failed]
                lVar5.cityAreaID = uVar7;
                break;
              }
              if (((this.worldEventTable == null) ||
                  (lVar5 = GameObject.get_transform(this.worldEventTable,0)) == null) ||
                 ((lVar5 = Transform.GetChild(lVar5,iVar4,0), lVar5 == null ||
                  (lVar5 = Component.GetComponent(lVar5,DAT_181e7a638)) == null)))
              throw; // [null/range check failed]
              lVar5 = lVar5.cityAreaID;
              lVar6 = FUN_1802106e0(0);
              if (((lVar6 == null) || (*(int64 *)(lVar6 + 32) == 0)) ||
                 (*(int64 *)(*(int64 *)(lVar6 + 32) + 128) == 0)) throw; // [null/range check failed]
              lVar6 = FUN_1800024b0();
            } while (lVar5 != lVar6);
            iVar3 = iVar3 + 1;
          }
        }
    }

    // Token : 0x60019D2
    // RVA   : 0x84A150   Offset: 0x848F50   Length: 0x4A1
    public void RefreshMissionTable()
    {
        ulong uVar1;
        bool cVar2;
        int iVar3;
        int iVar4;
        long lVar5;
        long lVar6;
        ulong uVar7;
        if ((this.missionTable != null) &&
           (lVar5 = GameObject.get_transform(this.missionTable,0)) != null) {
          iVar3 = Transform.get_childCount(lVar5,0);
          while (iVar3 = iVar3 + -1, -1 < iVar3) {
            lVar5 = FUN_1802106e0(0);
            if (((lVar5 == null) || (lVar5.villageAreaID == null)) ||
               (lVar5 = WorldData.Player(lVar5.villageAreaID,0)) == null) throw; // [null/range check failed]
            lVar5 = *(int64 *)(lVar5 + 0x2e8);
            if (((this.missionTable == null) ||
                (lVar6 = GameObject.get_transform(this.missionTable,0)) == null) ||
               ((lVar6 = Transform.GetChild(lVar6,iVar3,0), lVar6 == null ||
                ((lVar6 = Component.GetComponent(lVar6,DAT_181e77db8), lVar6 == null || (lVar5 == null))))))
            throw; // [null/range check failed]
            cVar2 = FUN_18175e190(lVar5);
            if (!cVar2) {
              if (((this.missionTable == null) ||
                  (lVar5 = GameObject.get_transform(this.missionTable,0)) == null) ||
                 (lVar5 = Transform.GetChild(lVar5,iVar3,0)) == null) throw; // [null/range check failed]
              uVar7 = Component.get_gameObject(lVar5);
              Object.Destroy(uVar7);
            }
          }
          iVar3 = 0;
          while( true ) {
            if ((((GameController._instance == null) ||
                 (lVar5 = GameController._instance.worldData) == null) ||
                (lVar5 = WorldData.Player(lVar5,0)) == null) || (*(int64 *)(lVar5 + 0x2e8) == 0))
            break;
            if (*(int *)(*(int64 *)(lVar5 + 0x2e8) + 24) <= iVar3) {
              return;
            }
            if ((this.missionTable == null) ||
               (lVar5 = GameObject.get_transform(this.missionTable,0)) == null) break;
            iVar4 = Transform.get_childCount(lVar5,0);
            do {
              iVar4 = iVar4 + -1;
              if (iVar4 < 0) {
                uVar7 = this.missionTable;
                uVar1 = this.missionIconPrefab;
                uVar7 = GlobalData.AddChild(uVar7,uVar1,0);
                this.temp = uVar7;
                if (this.temp == null) throw; // [null/range check failed]
                lVar5 = GameObject.GetComponent(this.temp,DAT_181e55630);
                lVar6 = FUN_1802106e0(0);
                if ((((lVar6 == null) || (*(int64 *)(lVar6 + 32) == 0)) ||
                    (lVar6 = WorldData.Player(*(int64 *)(lVar6 + 32),0)) == null) ||
                   ((*(int64 *)(lVar6 + 0x2e8) == 0 ||
                    (uVar7 = FUN_1800024b0(*(int64 *)(lVar6 + 0x2e8),iVar3), lVar5 == null))))
                throw; // [null/range check failed]
                lVar5.cityAreaID = uVar7;
                break;
              }
              if (((this.missionTable == null) ||
                  (lVar5 = GameObject.get_transform(this.missionTable,0)) == null) ||
                 ((lVar5 = Transform.GetChild(lVar5,iVar4,0), lVar5 == null ||
                  (lVar5 = Component.GetComponent(lVar5,DAT_181e77db8)) == null)))
              throw; // [null/range check failed]
              lVar5 = lVar5.cityAreaID;
              lVar6 = FUN_1802106e0(0);
              if ((((lVar6 == null) || (*(int64 *)(lVar6 + 32) == 0)) ||
                  (lVar6 = WorldData.Player(*(int64 *)(lVar6 + 32),0)) == null) ||
                 (*(int64 *)(lVar6 + 0x2e8) == 0)) throw; // [null/range check failed]
              lVar6 = FUN_1800024b0();
            } while (lVar5 != lVar6);
            iVar3 = iVar3 + 1;
          }
        }
    }

    // Token : 0x60019D3
    // RVA   : 0x2110A0   Offset: 0x20FEA0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_180ae8740(this,0);
    }

    // Token : 0x60019D4
    // RVA   : 0x84B290   Offset: 0x84A090   Length: 0x1B3
    private void <PlayPigeonAnim>b__36_0()
    {
        long lVar1;
        ulong uVar2;
        if (this.pigeon != null) {
          lVar1 = GameObject.GetComponent(this.pigeon,DAT_181e566a8);
          if (lVar1 != null) {
            lVar1 = SkeletonGraphic.get_AnimationState(lVar1,0);
            if (lVar1 != null) {
              *(uint32 *)(lVar1 + 108) = 0x40000000;
              if (this.pigeon != null) {
                lVar1 = GameObject.GetComponent(this.pigeon,DAT_181e566a8);
                if (lVar1 != null) {
                  lVar1 = SkeletonGraphic.get_AnimationState(lVar1,0);
                  if (lVar1 != null) {
                    AnimationState.SetAnimation(lVar1,0,"fly",1,0);
                    if (this.pigeon != null) {
                      uVar2 = GameObject.get_transform(this.pigeon,0);
                      uVar2 = ShortcutExtensions.DOScale(uVar2,0x3f400000,0x3f400000,0);
                      uVar2 = TweenSettingsExtensions.SetLoops(uVar2,2,1,DAT_181ea4f40);
                      TweenSettingsExtensions.SetEase(uVar2,7,DAT_181ea4b88);
                      plVar3 = (int64 *)Resources.Load("Sound/SoundEffect/鸽子",0);
                      plVar4 = (int64 *)0;
                      if ((plVar3 != (int64 *)0) && (*plVar3 == DAT_181e8f4a0)) {
                        plVar4 = plVar3;
                      }
                      NGUITools.PlaySound(plVar4,0);
                      return;
                    }
                  }
                }
              }
            }
          }
        }
    }

    // Token : 0x60019D5
    // RVA   : 0x84B450   Offset: 0x84A250   Length: 0x11C
    private void <PlayPigeonAnim>b__36_1()
    {
        long lVar1;
        uint local_18;
        uint uStack_14;
        uint uStack_10;
        uint32 uStack_c;
        if (this.pigeon != null) {
          lVar1 = GameObject.GetComponent(this.pigeon,DAT_181e566a8);
          if (lVar1 != null) {
            lVar1 = SkeletonGraphic.get_AnimationState(lVar1,0);
            if (lVar1 != null) {
              *(uint32 *)(lVar1 + 108) = 0x3f800000;
              if (this.pigeon != null) {
                lVar1 = GameObject.GetComponent(this.pigeon,DAT_181e566a8);
                if (lVar1 != null) {
                  lVar1 = SkeletonGraphic.get_AnimationState(lVar1,0);
                  if (lVar1 != null) {
                    AnimationState.SetAnimation(lVar1,0,"idle",1,0);
                    TweenExtensions.Rewind(this.pigeonTween,1,0);
                    if (this.pigeon != null) {
                      lVar1 = GameObject.get_transform(this.pigeon,0);
                      puVar2 = (uint32 *)Quaternion.get_identity(&local_18,0);
                      if (lVar1 != null) {
                        local_18 = *puVar2;
                        uStack_14 = puVar2[1];
                        uStack_10 = puVar2[2];
                        uStack_c = puVar2[3];
                        Transform.set_localRotation(lVar1,&local_18,0);
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
