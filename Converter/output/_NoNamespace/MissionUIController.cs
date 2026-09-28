// ============================================================
// Type  : MissionUIController
// Token : 0x2000308
// ============================================================

public class MissionUIController
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x40018F9
    public bool showUI;

    // Token: 0x40018FA
    public GameObject missionUI;

    // Token: 0x40018FB
    public GameObject missionIconPrefab;

    // Token: 0x40018FC
    public GameObject missionTable;

    // Token: 0x40018FD
    public GameObject worldEventIconPrefab;

    // Token: 0x40018FE
    public GameObject worldEventTable;

    // Token: 0x40018FF
    public GameObject worldEventNewNumIcon;

    // Token: 0x4001900
    public GameObject mailIconPrefab;

    // Token: 0x4001901
    public GameObject mailTable;

    // Token: 0x4001902
    public GameObject mailNewNumIcon;

    // Token: 0x4001903
    public List<GameObject> toggleButton;

    // Token: 0x4001904
    public GameObject forceMission;

    // Token: 0x4001905
    public int nowShowType;

    // Token: 0x4001906
    public GameObject pigeon;

    // Token: 0x4001907
    public Transform pigeonPathParent;

    // Token: 0x4001908
    public Vector3[] pigeonPath;

    // Token: 0x4001909
    public Tween pigeonTween;

    // Token: 0x400190A
    public bool worldEventTableDirty;

    // Token: 0x400190B
    private GameObject temp;

    // Token: 0x400190C
    private bool inited;

    // Token: 0x400190D
    private static MissionUIController _instance;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x600192D
    // RVA   : 0xE6E0F0   Offset: 0xE6D4F0   Length: 0x36
    public static MissionUIController get_Instance()
    {
        return **(uint64 **)(DAT_181d8ab90 + 184);
    }

    // Token : 0x600192E
    // RVA   : 0xE6A390   Offset: 0xE69790   Length: 0x43
    private void Awake()
    {
        puVar1 = *(uint64 **)(DAT_181d8ab90 + 184);
        *puVar1 = this;
        il2cpp_internal(puVar1,this);
    }

    // Token : 0x600192F
    // RVA   : 0xE6D770   Offset: 0xE6CB70   Length: 0x117
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
          uVar3 = FUN_1800d60b0(DAT_181da6d60,uVar2);
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
              FUN_1800d65f0(uVar3,0);
            }
            lVar4 = (int64)(int)uVar6;
            uVar6 = uVar6 + 1;
            *(uint64 *)(lVar1 + 32 + lVar4 * 12) = *puVar5;
            *(uint32 *)(lVar1 + 40 + lVar4 * 12) = *(uint32 *)(puVar5 + 1);
            lVar1 = this.pigeonPath;
          }
        }
    }

    // Token : 0x6001930
    // RVA   : 0xE6DF60   Offset: 0xE6D360   Length: 0x18E
    private void Update()
    {
        var pStatics = *(int64*)(DAT_181dadcf8 + 184);
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
        LAB_180e6e0e9:
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          cVar1 = GameObject.get_activeInHierarchy(this.missionUI,0);
          if (cVar1) {
            if (*pStatics == 0) goto LAB_180e6e0e9;
            if (*(char *)(*pStatics + 56) == false) {
              MissionUIController.ShowMissionUI(this,!this.showUI,0);
              plVar2 = (int64 *)Resources.Load("Sound/SoundEffect/Button/TabButton",0);
              plVar3 = (int64 *)0;
              if ((plVar2 != (int64 *)0) && (*plVar2 == DAT_181daf348)) {
                plVar3 = plVar2;
              }
              NGUITools.PlaySound(plVar3,0);
              return;
            }
          }
        }
    }

    // Token : 0x6001931
    // RVA   : 0xE6AB80   Offset: 0xE69F80   Length: 0x156F
    public void RefreshForceMission()
    {
        var pStatics_2cc8 = *(int64*)(DAT_181d72cc8 + 184);
        var pStatics_b490 = *(int64*)(DAT_181dab490 + 184);
        long lVar1;
        bool cVar2;
        long lVar3;
        ulong uVar4;
        ulong uVar7;
        ulong uVar8;
        int[] local_res18 = new int[2];
        int[] local_res20 = new int[2];
        uint local_28;
        uint uStack_24;
        uint uStack_20;
        uint32 uStack_1c;
        if (((*pStatics_2cc8 == 0) ||
            (lVar3 = *(int64 *)(*pStatics_2cc8 + 32)) == null) ||
           (lVar3 = WorldData.Player(lVar3,0)) == null) goto LAB_180e6c0c6;
        cVar2 = HeroData.HaveForce(lVar3,0);
        if (!cVar2) {
        LAB_180e6ae33:
          if (((*pStatics_2cc8 == 0) ||
              (lVar3 = *(int64 *)(*pStatics_2cc8 + 32)) == null) ||
             (lVar3 = WorldData.Player(lVar3,0)) == null) goto LAB_180e6c0c6;
          if (*(int64 *)(lVar3 + 0x2e0) != 0) goto LAB_180e6aedd;
        LAB_180e6c096:
          if (this.forceMission != null) {
            cVar2 = GameObject.get_activeSelf(this.forceMission,0);
            if (!cVar2) {
              return;
            }
            if (this.forceMission != null) {
              GameObject.SetActive(this.forceMission,0,0);
              return;
            }
          }
        LAB_180e6c0c6:
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
        if (((*pStatics_2cc8 == 0) ||
            (lVar3 = *(int64 *)(*pStatics_2cc8 + 32)) == null) ||
           (lVar3 = WorldData.Player(lVar3,0)) == null) goto LAB_180e6c0c6;
        if (*(char *)(lVar3 + 180) != false) goto LAB_180e6ae33;
        LAB_180e6aedd:
        if (((*pStatics_2cc8 == 0) ||
            (lVar3 = *(int64 *)(*pStatics_2cc8 + 32)) == null) ||
           (lVar3 = *(int64 *)(lVar3 + 168)) == null) goto LAB_180e6c0c6;
        if (*(int *)(lVar3 + 16) < 2) {
          lVar3 = FUN_18046c0a0(0);
          if (((lVar3 == null) || (*(int64 *)(lVar3 + 32) == 0)) ||
             (lVar3 = *(int64 *)(*(int64 *)(lVar3 + 32) + 168)) == null) goto LAB_180e6c0c6;
          if (*(int *)(lVar3 + 20) < 3) goto LAB_180e6c096;
        }
        if (this.forceMission == null) goto LAB_180e6c0c6;
        cVar2 = GameObject.get_activeSelf(this.forceMission,0);
        if (!cVar2) {
          if (this.forceMission == null) goto LAB_180e6c0c6;
          GameObject.SetActive(this.forceMission,1,0);
        }
        if (((*pStatics_2cc8 == 0) ||
            (lVar3 = *(int64 *)(*pStatics_2cc8 + 32)) == null) ||
           (lVar3 = WorldData.Player(lVar3,0)) == null) goto LAB_180e6c0c6;
        if (*(int64 *)(lVar3 + 0x2e0) != 0) {
          lVar3 = FUN_18046c0a0(0);
          if (((lVar3 == null) || (*(int64 *)(lVar3 + 32) == 0)) ||
             ((lVar3 = WorldData.Player(*(int64 *)(lVar3 + 32),0), lVar3 == null ||
              (*(int64 *)(lVar3 + 0x2e0) == 0)))) goto LAB_180e6c0c6;
          cVar2 = FUN_18171e540(*(uint64 *)(*(int64 *)(lVar3 + 0x2e0) + 24),"",0);
          if (!cVar2) {
            if (((this.forceMission != null) &&
                (lVar3 = GameObject.get_transform(this.forceMission,0)) != null) &&
               (lVar3 = Transform.Find(lVar3,"Icon",0)) != null) {
              lVar3 = Component.GetComponent(lVar3,DAT_181d94460);
              if ((*pStatics_b490 != 0) &&
                 (uVar4 = TextureController.LoadAtlasSprite
                                    (*pStatics_b490,"UIAtlas","门派任务",0),
                 lVar3 != null)) {
                Image.set_sprite(lVar3,uVar4,0);
                if ((this.forceMission != null) &&
                   ((lVar3 = GameObject.get_transform(this.forceMission,0), lVar3 != null &&
                    (lVar3 = Transform.Find(lVar3,"Icon",0)) != null))) {
                  plVar5 = (int64 *)Component.GetComponent(lVar3,DAT_181d94460);
                  puVar6 = (uint32 *)FUN_1810d3570(&local_28,0);
                  if (plVar5 != (int64 *)0) {
                    local_28 = *puVar6;
                    uStack_24 = puVar6[1];
                    uStack_20 = puVar6[2];
                    uStack_1c = puVar6[3];
                    (**(code **)(*plVar5 + 0x2a8))(plVar5,&local_28,*(uint64 *)(*plVar5 + 0x2b0));
                    if (((this.forceMission != null) &&
                        (lVar3 = GameObject.get_transform(this.forceMission,0)) != null)
                       && (lVar3 = Transform.Find(lVar3,"Text",0)) != null) {
                      uVar4 = Component.GetComponent(lVar3,DAT_181d96160);
                      lVar3 = FUN_18046c0a0(0);
                      if (((lVar3 != null) && (*(int64 *)(lVar3 + 32) != 0)) &&
                         ((lVar3 = WorldData.Player(*(int64 *)(lVar3 + 32),0), lVar3 != null &&
                          (*(int64 *)(lVar3 + 0x2e0) != 0)))) {
                        uVar7 = MissionData.GetMissionDescribe(*(int64 *)(lVar3 + 0x2e0),0,0,1,0,0);
                        uVar7 = String.Concat("门派任务\n",uVar7,0);
                        LTLocalization.SetText(uVar4,uVar7,0);
                        if (((this.forceMission != null) &&
                            (lVar3 = GameObject.get_transform(this.forceMission,0),
                            lVar3 != null)) && (lVar3 = Transform.Find(lVar3,"ForceMissionTime",0)) != null)
                        {
                          uVar4 = Component.GetComponent(lVar3,DAT_181d96160);
                          lVar3 = FUN_18046c0a0(0);
                          if (((lVar3 != null) && (*(int64 *)(lVar3 + 32) != 0)) &&
                             (lVar3 = WorldData.Player(*(int64 *)(lVar3 + 32),0)) != null) {
                            uVar7 = "";
                            if (*(char *)(lVar3 + 180) == false) {
                              lVar3 = FUN_18046c0a0(0);
                              if ((((lVar3 == null) || (*(int64 *)(lVar3 + 32) == 0)) ||
                                  (lVar3 = WorldData.Player(*(int64 *)(lVar3 + 32),0)) == null)
                                 || (*(int64 *)(lVar3 + 0x2e0) == 0)) goto LAB_180e6c0c6;
                              if (*(int *)(*(int64 *)(lVar3 + 0x2e0) + 36) < 0) {
                                uVar7 = *(uint64 *)(*(int64 *)(DAT_181d73d40 + 184) + 0x2d0);
                                if ((((*pStatics_2cc8 == 0) ||
                                     (lVar3 = *(int64 *)(*pStatics_2cc8 + 32),
                                     lVar3 == null)) || (lVar3 = WorldData.Player(lVar3,0)) == null) ||
                                   (*(int64 *)(lVar3 + 0x2e0) == 0)) {
                          // WARNING: Subroutine does not return
                                  FUN_1800d6620();
                                }
                                local_res20[0] = -*(int *)(*(int64 *)(lVar3 + 0x2e0) + 36);
                                uVar8 = il2cpp_value_box(DAT_181d80418,local_res20);
                                uVar7 = String.Format("{0}{1}日</color>",uVar7,uVar8,0);
                              }
                              else {
                                lVar3 = FUN_18046c0a0(0);
                                if (((lVar3 == null) || (*(int64 *)(lVar3 + 32) == 0)) ||
                                   ((lVar3 = WorldData.Player(*(int64 *)(lVar3 + 32),0), lVar3 == null
                                    || (*(int64 *)(lVar3 + 0x2e0) == 0)))) {
                          // WARNING: Subroutine does not return
                                  FUN_1800d6620();
                                }
                                local_res18[0] = *(int *)(*(int64 *)(lVar3 + 0x2e0) + 36);
                                uVar7 = il2cpp_value_box(DAT_181d80418,local_res18);
                                uVar7 = String.Format("{0}日",uVar7,0);
                              }
                            }
                            LTLocalization.SetText(uVar4,uVar7,0);
                            if (((this.forceMission != null) &&
                                (lVar3 = GameObject.get_transform(this.forceMission,0),
                                lVar3 != null)) &&
                               (lVar3 = Transform.Find(lVar3,"ForceMissionTime",0)) != null) {
                              plVar5 = (int64 *)Component.GetComponent(lVar3,DAT_181d96160);
                              puVar6 = (uint32 *)Color.get_black(&local_28,0);
                              if (plVar5 != (int64 *)0) {
                                local_28 = *puVar6;
                                uStack_24 = puVar6[1];
                                uStack_20 = puVar6[2];
                                uStack_1c = puVar6[3];
                                (**(code **)(*plVar5 + 0x2a8))
                                          (plVar5,&local_28,*(uint64 *)(*plVar5 + 0x2b0));
                                lVar3 = FUN_18046c0a0(0);
                                if (((lVar3 != null) && (*(int64 *)(lVar3 + 32) != 0)) &&
                                   (lVar3 = WorldData.Player(*(int64 *)(lVar3 + 32),0)) != null)
                                {
                                  if (*(char *)(lVar3 + 180) == false) {
                                    lVar3 = FUN_18046c0a0(0);
                                    if ((((lVar3 == null) || (*(int64 *)(lVar3 + 32) == 0)) ||
                                        (lVar3 = WorldData.Player(*(int64 *)(lVar3 + 32),0),
                                        lVar3 == null)) || (*(int64 *)(lVar3 + 0x2e0) == 0))
                                    goto LAB_180e6c0c6;
                                    cVar2 = MissionData.MissionNeedFinished
                                                      (*(int64 *)(lVar3 + 0x2e0),0,0);
                                    lVar3 = this.forceMission;
                                    if (!cVar2) {
                                      if (lVar3 == null) goto LAB_180e6c0c6;
                                      lVar3 = GameObject.GetComponent(lVar3,DAT_181d73448);
                                      uVar4 = "<i>请在时限内完成任务\n然后返回门派正厅复命</i>";
                                    }
                                    else {
                                      if (lVar3 == null) goto LAB_180e6c0c6;
                                      lVar3 = GameObject.GetComponent(lVar3,DAT_181d73448);
                                      uVar4 = "<i>目标已满足\n返回门派正厅复命</i>";
                                    }
                                  }
                                  else {
                                    if (this.forceMission == null) goto LAB_180e6c0c6;
                                    lVar3 = GameObject.GetComponent
                                                      (this.forceMission,DAT_181d73448);
                                    uVar4 = "";
                                  }
                                  if (lVar3 != null) {
                                    *(uint64 *)(lVar3 + 24) = uVar4;
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
            goto LAB_180e6c0c6;
          }
        }
        if (((this.forceMission == null) ||
            (lVar3 = GameObject.get_transform(this.forceMission,0)) == null) ||
           (lVar3 = Transform.Find(lVar3,"Icon",0)) == null) goto LAB_180e6c0c6;
        lVar3 = Component.GetComponent(lVar3,DAT_181d94460);
        if ((*pStatics_b490 == 0) ||
           (uVar4 = TextureController.LoadAtlasSprite
                              (*pStatics_b490,"UIAtlas","门派会议",0),
           lVar3 == null)) goto LAB_180e6c0c6;
        Image.set_sprite(lVar3,uVar4,0);
        if ((this.forceMission == null) ||
           (lVar3 = GameObject.GetComponent(this.forceMission,DAT_181d73448)) == null)
        goto LAB_180e6c0c6;
        *(uint64 *)(lVar3 + 24) = "<i>每月一日门派正厅召开会议\n持续五日</i>";
        if ((*pStatics_2cc8 == 0) ||
           (lVar3 = *(int64 *)(*pStatics_2cc8 + 32)) == null)
        goto LAB_180e6c0c6;
        lVar1 = this.forceMission;
        if (*(char *)(lVar3 + 184) == false) {
          if (((lVar1 == null) || (lVar3 = GameObject.get_transform(lVar1,0)) == null) ||
             (lVar3 = Transform.Find(lVar3,"Icon",0)) == null) {
        LAB_180e6c0d8:
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          plVar5 = (int64 *)Component.GetComponent(lVar3,DAT_181d94460);
          puVar6 = (uint32 *)FUN_1810d33f0(&local_28,0);
          if (plVar5 == (int64 *)0) goto LAB_180e6c0d8;
          local_28 = *puVar6;
          uStack_24 = puVar6[1];
          uStack_20 = puVar6[2];
          uStack_1c = puVar6[3];
          (**(code **)(*plVar5 + 0x2a8))(plVar5,&local_28,*(uint64 *)(*plVar5 + 0x2b0));
          if (((this.forceMission == null) ||
              (lVar3 = GameObject.get_transform(this.forceMission,0)) == null) ||
             (lVar3 = Transform.Find(lVar3,"Text",0)) == null) goto LAB_180e6c0d8;
          uVar4 = Component.GetComponent(lVar3,DAT_181d96160);
          uVar7 = FUN_180004500(DAT_181d8b140);
          uVar7 = String.Format("等待下次门派会议",uVar7,0);
          LTLocalization.SetText(uVar4,uVar7,0);
          if (((this.forceMission == null) ||
              (lVar3 = GameObject.get_transform(this.forceMission,0)) == null) ||
             (lVar3 = Transform.Find(lVar3,"ForceMissionTime",0)) == null) goto LAB_180e6c0d8;
          uVar4 = Component.GetComponent(lVar3,DAT_181d96160);
          lVar3 = FUN_18046c0a0(0);
          if (((lVar3 == null) || (*(int64 *)(lVar3 + 32) == 0)) ||
             (lVar3 = *(int64 *)(*(int64 *)(lVar3 + 32) + 168)) == null) goto LAB_180e6c0d8;
          local_res18[0] = TimeData.NextMeetingTime(lVar3,0);
          uVar7 = il2cpp_value_box(DAT_181d80418,local_res18);
          uVar7 = String.Format("{0}日",uVar7,0);
          LTLocalization.SetText(uVar4,uVar7,0);
          if (((this.forceMission == null) ||
              (lVar3 = GameObject.get_transform(this.forceMission,0)) == null) ||
             (lVar3 = Transform.Find(lVar3,"ForceMissionTime",0)) == null) goto LAB_180e6c0d8;
          plVar5 = (int64 *)Component.GetComponent(lVar3,DAT_181d96160);
          puVar6 = (uint32 *)Color.get_black(&local_28,0);
          if (plVar5 == (int64 *)0) goto LAB_180e6c0d8;
          goto LAB_180e6c072;
        }
        if (((lVar1 == null) || (lVar3 = GameObject.get_transform(lVar1,0)) == null) ||
           (lVar3 = Transform.Find(lVar3,"Icon",0)) == null) goto LAB_180e6c0c6;
        plVar5 = (int64 *)Component.GetComponent(lVar3,DAT_181d94460);
        puVar6 = (uint32 *)FUN_1810d3570(&local_28,0);
        if (plVar5 == (int64 *)0) goto LAB_180e6c0c6;
        local_28 = *puVar6;
        uStack_24 = puVar6[1];
        uStack_20 = puVar6[2];
        uStack_1c = puVar6[3];
        (**(code **)(*plVar5 + 0x2a8))(plVar5,&local_28,*(uint64 *)(*plVar5 + 0x2b0));
        if (((this.forceMission == null) ||
            (lVar3 = GameObject.get_transform(this.forceMission,0)) == null) ||
           (lVar3 = Transform.Find(lVar3,"Text",0)) == null) goto LAB_180e6c0c6;
        uVar4 = Component.GetComponent(lVar3,DAT_181d96160);
        LTLocalization.SetText(uVar4,"门派会议已召开\n",0);
        lVar3 = FUN_18046c0a0(0);
        if (((lVar3 == null) || (*(int64 *)(lVar3 + 32) == 0)) ||
           (lVar3 = WorldData.Player(*(int64 *)(lVar3 + 32),0)) == null) goto LAB_180e6c0c6;
        if (*(int *)(lVar3 + 184) < 2) {
        LAB_180e6be39:
          if (((this.forceMission == null) ||
              (lVar3 = GameObject.get_transform(this.forceMission,0)) == null) ||
             (lVar3 = Transform.Find(lVar3,"Text",0)) == null) {
        LAB_180e6c0ea:
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          uVar4 = Component.GetComponent(lVar3,DAT_181d96160);
          lVar3 = FUN_18046c0a0(0);
          if (((lVar3 == null) || (*(int64 *)(lVar3 + 32) == 0)) ||
             (lVar3 = *(int64 *)(*(int64 *)(lVar3 + 32) + 168)) == null) goto LAB_180e6c0ea;
          local_res18[0] = 6 - *(int *)(lVar3 + 24);
          uVar8 = il2cpp_value_box(DAT_181d80418,local_res18);
          uVar7 = "尽快返回门派正厅！";
        }
        else {
          lVar3 = FUN_18046c0a0(0);
          if (((lVar3 == null) || (*(int64 *)(lVar3 + 32) == 0)) ||
             (lVar3 = WorldData.Player(*(int64 *)(lVar3 + 32),0)) == null) goto LAB_180e6c0c6;
          if (*(int *)(lVar3 + 184) < 4) {
            lVar3 = FUN_18046c0a0(0);
            if ((lVar3 == null) || (*(int64 *)(lVar3 + 32) == 0)) goto LAB_180e6c0c6;
            if (0 < *(int *)(*(int64 *)(lVar3 + 32) + 188)) goto LAB_180e6be39;
          }
          if (((this.forceMission == null) ||
              (lVar3 = GameObject.get_transform(this.forceMission,0)) == null) ||
             (lVar3 = Transform.Find(lVar3,"Text",0)) == null) {
        LAB_180e6c0de:
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          uVar4 = Component.GetComponent(lVar3,DAT_181d96160);
          lVar3 = FUN_18046c0a0(0);
          if (((lVar3 == null) || (*(int64 *)(lVar3 + 32) == 0)) ||
             (lVar3 = *(int64 *)(*(int64 *)(lVar3 + 32) + 168)) == null) goto LAB_180e6c0de;
          local_res18[0] = 6 - *(int *)(lVar3 + 24);
          uVar8 = il2cpp_value_box(DAT_181d80418,local_res18);
          uVar7 = "可以不参加";
        }
        uVar7 = String.Format(uVar7,uVar8,0);
        LTLocalization.AddText(uVar4,uVar7,0);
        if (((this.forceMission != null) &&
            (lVar3 = GameObject.get_transform(this.forceMission,0)) != null) &&
           (lVar3 = Transform.Find(lVar3,"ForceMissionTime",0)) != null) {
          uVar4 = Component.GetComponent(lVar3,DAT_181d96160);
          lVar3 = FUN_18046c0a0(0);
          if (((lVar3 != null) && (*(int64 *)(lVar3 + 32) != 0)) &&
             (lVar3 = *(int64 *)(*(int64 *)(lVar3 + 32) + 168)) != null) {
            local_res18[0] = 6 - *(int *)(lVar3 + 24);
            uVar7 = il2cpp_value_box(DAT_181d80418,local_res18);
            uVar7 = String.Format("{0}日",uVar7,0);
            LTLocalization.SetText(uVar4,uVar7,0);
            if (((this.forceMission != null) &&
                (lVar3 = GameObject.get_transform(this.forceMission,0)) != null) &&
               (lVar3 = Transform.Find(lVar3,"ForceMissionTime",0)) != null) {
              plVar5 = (int64 *)Component.GetComponent(lVar3,DAT_181d96160);
              puVar6 = (uint32 *)Color.get_red(&local_28,0);
              if (plVar5 != (int64 *)0) {
        LAB_180e6c072:
                local_28 = *puVar6;
                uStack_24 = puVar6[1];
                uStack_20 = puVar6[2];
                uStack_1c = puVar6[3];
                (**(code **)(*plVar5 + 0x2a8))(plVar5,&local_28,*(uint64 *)(*plVar5 + 0x2b0));
                return;
              }
            }
          }
        }
    }

    // Token : 0x6001932
    // RVA   : 0xE6A640   Offset: 0xE69A40   Length: 0x1FC
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
          uVar3 = TweenSettingsExtensions.SetEase(uVar3,10,DAT_181dc0ef8);
          uVar2 = new OnTooltipCB(this,DAT_181d8cb20,0);
          uVar3 = TweenSettingsExtensions.OnPlay(uVar3,uVar2,DAT_181dc0368);
          uVar2 = new OnTooltipCB(this,DAT_181d8cba0,0);
          uVar3 = TweenSettingsExtensions.OnComplete(uVar3,uVar2,DAT_181dc0148);
          this.pigeonTween = uVar3;
          return;
        }
    }

    // Token : 0x6001933
    // RVA   : 0xE6D6D0   Offset: 0xE6CAD0   Length: 0x96
    public void ShowMissionUI(bool showState)
    {
        long lVar1;
        lVar1 = this.missionUI;
        if (!showState) {
          this.showUI = 0;
          if (lVar1 != null) {
            lVar1 = GameObject.GetComponent(lVar1,DAT_181d744c0);
            if (lVar1 != null) {
              UITweener.PlayReverse(lVar1,0);
              return;
            }
          }
        }
        else {
          this.showUI = 1;
          if (lVar1 != null) {
            lVar1 = GameObject.GetComponent(lVar1,DAT_181d744c0);
            if (lVar1 != null) {
              UITweener.PlayForward(lVar1,0);
              return;
            }
          }
        }
    }

    // Token : 0x6001934
    // RVA   : 0xE6D890   Offset: 0xE6CC90   Length: 0x3EB
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
        if ((buttonClicked == null) || (lVar2 = GameObject.GetComponent(buttonClicked,DAT_181d743b0)) == null)
        throw; // [null/range check failed]
        if (*(char *)(lVar2 + 0x118) != false) {
          if (!this.showUI) {
            this.showUI = 1;
            if ((this.missionUI == null) ||
               (lVar2 = GameObject.GetComponent(this.missionUI,DAT_181d744c0)) == null
               ) throw; // [null/range check failed]
            UITweener.PlayForward(lVar2,0);
          }
          else {
            if (this.toggleButton == null) throw; // [null/range check failed]
            iVar1 = FUN_1817eb4e0(this.toggleButton,buttonClicked,DAT_181d89518);
            if (iVar1 == this.nowShowType) {
              this.showUI = 0;
              if ((this.missionUI == null) ||
                 (lVar2 = GameObject.GetComponent(this.missionUI,DAT_181d744c0),
                 lVar2 == null)) throw; // [null/range check failed]
              UITweener.PlayReverse(lVar2,0);
            }
          }
          if (this.toggleButton == null) throw; // [null/range check failed]
          iVar1 = FUN_1817eb4e0(this.toggleButton,buttonClicked,DAT_181d89518);
          this.nowShowType = iVar1;
          if (iVar1 == 2) {
            uVar3 = MissionUIController.RebuildMailTable(this,0);
            FUN_180d8c2e0(this,uVar3,0);
          }
        }
        lVar2 = GameObject.get_transform(buttonClicked,0);
        lVar4 = GameObject.GetComponent(buttonClicked,DAT_181d743b0);
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
              plVar6 = (int64 *)GameObject.GetComponent(buttonClicked,DAT_181d71e80);
              lVar2 = GameObject.GetComponent(buttonClicked,DAT_181d743b0);
              if (lVar2 != null) {
                uVar7 = 0x3f800000;
                if (*(char *)(lVar2 + 0x118) == false) {
                  uVar7 = 0x3f4ccccd;
                }
                local_28 = 0;
                uStack_20 = 0;
                FUN_1809dc910(&local_28,0x3f800000,0x3f800000,0x3f800000,uVar7,0);
                if (plVar6 == (int64 *)0) {
                          // WARNING: Subroutine does not return
                  FUN_1800d6620();
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
                  uVar3 = DAT_181d956e0;
                }
                else {
                  lVar2 = GameObject.get_transform(buttonClicked,0);
                  if (lVar2 == null) throw; // [null/range check failed]
                  lVar2 = Transform.Find(lVar2,"Mark",0);
                  uVar3 = DAT_181d94460;
                }
                if (lVar2 != null) {
                  plVar6 = (int64 *)Component.GetComponent(lVar2,uVar3);
                  lVar2 = GameObject.GetComponent(buttonClicked);
                  if (lVar2 != null) {
                    if (*(char *)(lVar2 + 0x118) == false) {
                      puVar5 = (uint64 *)FUN_1810d33f0(&local_28);
                    }
                    else {
                      puVar5 = (uint64 *)FUN_1810d3570();
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

    // Token : 0x6001935
    // RVA   : 0xE6AB10   Offset: 0xE69F10   Length: 0x6C
    public IEnumerator RebuildMailTable()
    {
        long lVar1;
        lVar1 = new WarpText_d__8(0,0);
        if (lVar1 != null) {
          *(uint64 *)(lVar1 + 32) = this;
          return lVar1;
        }
    }

    // Token : 0x6001936
    // RVA   : 0xE6A3E0   Offset: 0xE697E0   Length: 0x25D
    public void ClearMailButtonClicked()
    {
        var pStatics = *(int64*)(DAT_181d72cc8 + 184);
        int iVar1;
        long lVar3;
        bVar2 = false;
        if (((*pStatics != 0) &&
            (lVar3 = *(int64 *)(*pStatics + 32)) != null) &&
           (lVar3 = *(int64 *)(lVar3 + 144)) != null) {
          iVar1 = *(int *)(lVar3 + 24);
          while( true ) {
            do {
              iVar1 = iVar1 + -1;
              if (iVar1 < 0) {
                plVar4 = (int64 *)Resources.Load("Sound/SoundEffect/PaperQuick",0);
                plVar5 = (int64 *)0;
                if ((plVar4 != (int64 *)0) && (*plVar4 == DAT_181daf348)) {
                  plVar5 = plVar4;
                }
                NGUITools.PlaySound(plVar5,0);
                if (bVar2) {
                  MissionUIController.RefreshMailTable(this,0);
                }
                return;
              }
              lVar3 = FUN_18046c0a0(0);
              if ((((lVar3 == null) || (*(int64 *)(lVar3 + 32) == 0)) ||
                  (lVar3 = *(int64 *)(*(int64 *)(lVar3 + 32) + 144)) == null) ||
                 (lVar3 = FUN_180002f80(lVar3,iVar1,DAT_181d93808)) == null) throw; // [null/range check failed]
            } while (*(char *)(lVar3 + 41) == false);
            lVar3 = FUN_18046c0a0(0);
            if (((lVar3 == null) || (*(int64 *)(lVar3 + 32) == 0)) ||
               (lVar3 = *(int64 *)(*(int64 *)(lVar3 + 32) + 144)) == null) break;
            FUN_181823590(lVar3,iVar1,DAT_181d93708);
            bVar2 = true;
          }
        }
    }

    // Token : 0x6001937
    // RVA   : 0xE6A840   Offset: 0xE69C40   Length: 0x2C6
    public void ReadAllMailButtonClicked()
    {
        var pStatics = *(int64*)(DAT_181d72cc8 + 184);
        int iVar1;
        long lVar3;
        bVar2 = false;
        if (((*pStatics != 0) &&
            (lVar3 = *(int64 *)(*pStatics + 32)) != null) &&
           (lVar3 = *(int64 *)(lVar3 + 144)) != null) {
          iVar1 = *(int *)(lVar3 + 24);
          while( true ) {
            do {
              do {
                iVar1 = iVar1 + -1;
                if (iVar1 < 0) {
                  plVar4 = (int64 *)Resources.Load("Sound/SoundEffect/PaperQuick",0);
                  plVar5 = (int64 *)0;
                  if ((plVar4 != (int64 *)0) && (*plVar4 == DAT_181daf348)) {
                    plVar5 = plVar4;
                  }
                  NGUITools.PlaySound(plVar5,0);
                  if (bVar2) {
                    MissionUIController.RefreshMailTable(this,0);
                  }
                  return;
                }
                lVar3 = FUN_18046c0a0(0);
                if ((((lVar3 == null) || (*(int64 *)(lVar3 + 32) == 0)) ||
                    (lVar3 = *(int64 *)(*(int64 *)(lVar3 + 32) + 144)) == null) ||
                   (lVar3 = FUN_180002f80(lVar3,iVar1,DAT_181d93808)) == null) throw; // [null/range check failed]
              } while (*(char *)(lVar3 + 41) != false);
              lVar3 = FUN_18046c0a0(0);
              if (((lVar3 == null) || (*(int64 *)(lVar3 + 32) == 0)) ||
                 ((lVar3 = *(int64 *)(*(int64 *)(lVar3 + 32) + 144), lVar3 == null ||
                  (lVar3 = FUN_180002f80(lVar3,iVar1,DAT_181d93808)) == null))) throw; // [null/range check failed]
            } while (*(char *)(lVar3 + 40) != false);
            lVar3 = FUN_18046c0a0(0);
            if ((((lVar3 == null) || (*(int64 *)(lVar3 + 32) == 0)) ||
                (lVar3 = *(int64 *)(*(int64 *)(lVar3 + 32) + 144)) == null) ||
               (lVar3 = FUN_180002f80(lVar3,iVar1,DAT_181d93808)) == null) break;
            *(uint8 *)(lVar3 + 41) = 1;
            bVar2 = true;
          }
        }
    }

    // Token : 0x6001938
    // RVA   : 0xE6C0F0   Offset: 0xE6B4F0   Length: 0x344
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
          lVar2 = **(int64 **)(DAT_181d72cc8 + 184);
          if (((lVar2 == null) || (*(int64 *)(lVar2 + 32) == 0)) ||
             (lVar1 = *(int64 *)(*(int64 *)(lVar2 + 32) + 144)) == null) throw; // [null/range check failed]
          if (*(int *)(lVar1 + 24) <= iVar5) break;
          lVar2 = FUN_18046c0a0(0);
          if ((((lVar2 == null) || (*(int64 *)(lVar2 + 32) == 0)) ||
              (lVar2 = *(int64 *)(*(int64 *)(lVar2 + 32) + 144)) == null) ||
             (lVar2 = FUN_180002f80(lVar2,iVar5)) == null) throw; // [null/range check failed]
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
                (lVar2 = GameObject.GetComponent(this.pigeon,DAT_181d735e0), lVar2 != null
                )) && ((lVar2 = SkeletonGraphic.get_AnimationState(lVar2,0), lVar2 != null &&
                       (lVar2 = AnimationState.GetCurrent(lVar2,0,0)) != null))) {
              *(uint32 *)(lVar2 + 144) = 0;
              if (((this.pigeon != null) &&
                  (lVar2 = GameObject.GetComponent(this.pigeon,DAT_181d735e0),
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
            uVar3 = Component.GetComponent(lVar2,DAT_181d96160);
            uVar4 = "⋯";
            if (local_res18[0] < 10) {
              uVar4 = Int32.ToString(local_res18,0);
            }
            LTLocalization.SetText(uVar3,uVar4,0);
            if (((this.pigeon != null) &&
                (lVar2 = GameObject.GetComponent(this.pigeon,DAT_181d735e0), lVar2 != null
                )) && (lVar2 = SkeletonGraphic.get_AnimationState(lVar2,0)) != null) {
              *(uint32 *)(lVar2 + 108) = 0x3f800000;
              return;
            }
          }
        }
    }

    // Token : 0x6001939
    // RVA   : 0xE6C440   Offset: 0xE6B840   Length: 0x6F1
    public void RefreshMailTable()
    {
        var pStatics = *(int64*)(DAT_181d72cc8 + 184);
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
            lVar5 = FUN_18046c0a0(0);
            if ((lVar5 == null) || (*(int64 *)(lVar5 + 32) == 0)) throw; // [null/range check failed]
            lVar5 = *(int64 *)(*(int64 *)(lVar5 + 32) + 144);
            if (((this.mailTable == null) ||
                (((lVar6 = GameObject.get_transform(this.mailTable,0), lVar6 == null ||
                  (lVar6 = Transform.GetChild(lVar6,iVar3,0)) == null) ||
                 (lVar6 = Component.GetComponent(lVar6,DAT_181d948e0)) == null))) || (lVar5 == null))
            throw; // [null/range check failed]
            cVar2 = FUN_18181e400(lVar5,*(uint64 *)(lVar6 + 24));
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
            if (((*pStatics == 0) ||
                (lVar5 = *(int64 *)(*pStatics + 32)) == null) ||
               (lVar5 = *(int64 *)(lVar5 + 144)) == null) throw; // [null/range check failed]
            if (*(int *)(lVar5 + 24) <= iVar3) break;
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
                lVar5 = GameObject.GetComponent(this.temp,DAT_181d72348);
                lVar6 = FUN_18046c0a0(0);
                if ((((lVar6 == null) || (*(int64 *)(lVar6 + 32) == 0)) ||
                    (lVar6 = *(int64 *)(*(int64 *)(lVar6 + 32) + 144)) == null) ||
                   (uVar7 = FUN_180002f80(lVar6,iVar3), lVar5 == null)) throw; // [null/range check failed]
                *(uint64 *)(lVar5 + 24) = uVar7;
                break;
              }
              if (((this.mailTable == null) ||
                  (lVar5 = GameObject.get_transform(this.mailTable,0)) == null) ||
                 ((lVar5 = Transform.GetChild(lVar5,iVar4,0), lVar5 == null ||
                  (lVar5 = Component.GetComponent(lVar5,DAT_181d948e0)) == null)))
              throw; // [null/range check failed]
              lVar5 = *(int64 *)(lVar5 + 24);
              lVar6 = FUN_18046c0a0(0);
              if (((lVar6 == null) || (*(int64 *)(lVar6 + 32) == 0)) ||
                 (*(int64 *)(*(int64 *)(lVar6 + 32) + 144) == 0)) throw; // [null/range check failed]
              lVar6 = FUN_180002f80();
            } while (lVar5 != lVar6);
            iVar3 = iVar3 + 1;
          }
          lVar5 = FUN_18046c0a0(0);
          if (((lVar5 != null) && (*(int64 *)(lVar5 + 32) != 0)) &&
             (lVar5 = *(int64 *)(*(int64 *)(lVar5 + 32) + 144)) != null) {
            lVar6 = this.mailTable;
            if (*(int *)(lVar5 + 24) == 0) {
              if ((((lVar6 != null) && (lVar5 = GameObject.get_transform(lVar6,0)) != null) &&
                  (lVar5 = Transform.Find(lVar5,"ClearMailButton",0)) != null) &&
                 (lVar5 = Component.GetComponent(lVar5,DAT_181d93760)) != null) {
                Selectable.set_interactable(lVar5,0,0);
                if (((this.mailTable != null) &&
                    (lVar5 = GameObject.get_transform(this.mailTable,0)) != null) &&
                   ((lVar5 = Transform.Find(lVar5,"ReadAllMailButton",0), lVar5 != null &&
                    (lVar5 = Component.GetComponent(lVar5,DAT_181d93760)) != null))) {
                  uVar7 = 0;
                  goto LAB_180e6caeb;
                }
              }
            }
            else if (((lVar6 != null) && (lVar5 = GameObject.get_transform(lVar6,0)) != null) &&
                    ((lVar5 = Transform.Find(lVar5,"ClearMailButton",0), lVar5 != null &&
                     (lVar5 = Component.GetComponent(lVar5,DAT_181d93760)) != null))) {
              Selectable.set_interactable(lVar5,1,0);
              if ((((this.mailTable != null) &&
                   (lVar5 = GameObject.get_transform(this.mailTable,0)) != null) &&
                  (lVar5 = Transform.Find(lVar5,"ReadAllMailButton",0)) != null) &&
                 (lVar5 = Component.GetComponent(lVar5,DAT_181d93760)) != null) {
                uVar7 = 1;
        LAB_180e6caeb:
                Selectable.set_interactable(lVar5,uVar7,0);
                MissionUIController.RefreshMailNewIcon(this,0);
                uVar7 = MissionUIController.RebuildMailTable(this,0);
                FUN_180d8c2e0(this,uVar7,0);
                return;
              }
            }
          }
        }
    }

    // Token : 0x600193A
    // RVA   : 0xE6CFF0   Offset: 0xE6C3F0   Length: 0x260
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
          lVar2 = **(int64 **)(DAT_181d72cc8 + 184);
          if (((lVar2 == null) || (*(int64 *)(lVar2 + 32) == 0)) ||
             (lVar1 = *(int64 *)(*(int64 *)(lVar2 + 32) + 128)) == null) throw; // [null/range check failed]
          if (*(int *)(lVar1 + 24) <= iVar5) break;
          lVar2 = FUN_18046c0a0(0);
          if ((((lVar2 == null) || (*(int64 *)(lVar2 + 32) == 0)) ||
              (lVar2 = *(int64 *)(*(int64 *)(lVar2 + 32) + 128)) == null) ||
             (lVar2 = FUN_180002f80(lVar2,iVar5)) == null) throw; // [null/range check failed]
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
            uVar3 = Component.GetComponent(lVar2,DAT_181d96160);
            uVar4 = "⋯";
            if (local_res18[0] < 10) {
              uVar4 = Int32.ToString(local_res18,0);
            }
            LTLocalization.SetText(uVar3,uVar4,0);
            return;
          }
        }
    }

    // Token : 0x600193B
    // RVA   : 0xE6D260   Offset: 0xE6C660   Length: 0x46E
    public void RefreshWorldEventTable()
    {
        var pStatics = *(int64*)(DAT_181d72cc8 + 184);
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
            lVar5 = FUN_18046c0a0(0);
            if ((lVar5 == null) || (*(int64 *)(lVar5 + 32) == 0)) throw; // [null/range check failed]
            lVar5 = *(int64 *)(*(int64 *)(lVar5 + 32) + 128);
            if (((this.worldEventTable == null) ||
                (((lVar6 = GameObject.get_transform(this.worldEventTable,0), lVar6 == null ||
                  (lVar6 = Transform.GetChild(lVar6,iVar3,0)) == null) ||
                 (lVar6 = Component.GetComponent(lVar6,DAT_181d97260)) == null))) || (lVar5 == null))
            throw; // [null/range check failed]
            cVar2 = FUN_18181e400(lVar5);
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
            if (((*pStatics == 0) ||
                (lVar5 = *(int64 *)(*pStatics + 32)) == null) ||
               (lVar5 = *(int64 *)(lVar5 + 128)) == null) break;
            if (*(int *)(lVar5 + 24) <= iVar3) {
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
                lVar5 = GameObject.GetComponent(this.temp,DAT_181d74cb8);
                lVar6 = FUN_18046c0a0(0);
                if ((((lVar6 == null) || (*(int64 *)(lVar6 + 32) == 0)) ||
                    (lVar6 = *(int64 *)(*(int64 *)(lVar6 + 32) + 128)) == null) ||
                   (uVar7 = FUN_180002f80(lVar6,iVar3), lVar5 == null)) throw; // [null/range check failed]
                *(uint64 *)(lVar5 + 24) = uVar7;
                break;
              }
              if (((this.worldEventTable == null) ||
                  (lVar5 = GameObject.get_transform(this.worldEventTable,0)) == null) ||
                 ((lVar5 = Transform.GetChild(lVar5,iVar4,0), lVar5 == null ||
                  (lVar5 = Component.GetComponent(lVar5,DAT_181d97260)) == null)))
              throw; // [null/range check failed]
              lVar5 = *(int64 *)(lVar5 + 24);
              lVar6 = FUN_18046c0a0(0);
              if (((lVar6 == null) || (*(int64 *)(lVar6 + 32) == 0)) ||
                 (*(int64 *)(*(int64 *)(lVar6 + 32) + 128) == 0)) throw; // [null/range check failed]
              lVar6 = FUN_180002f80();
            } while (lVar5 != lVar6);
            iVar3 = iVar3 + 1;
          }
        }
    }

    // Token : 0x600193C
    // RVA   : 0xE6CB40   Offset: 0xE6BF40   Length: 0x4A1
    public void RefreshMissionTable()
    {
        var pStatics = *(int64*)(DAT_181d72cc8 + 184);
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
            lVar5 = FUN_18046c0a0(0);
            if (((lVar5 == null) || (*(int64 *)(lVar5 + 32) == 0)) ||
               (lVar5 = WorldData.Player(*(int64 *)(lVar5 + 32),0)) == null) throw; // [null/range check failed]
            lVar5 = *(int64 *)(lVar5 + 0x2e8);
            if (((this.missionTable == null) ||
                (lVar6 = GameObject.get_transform(this.missionTable,0)) == null) ||
               ((lVar6 = Transform.GetChild(lVar6,iVar3,0), lVar6 == null ||
                ((lVar6 = Component.GetComponent(lVar6,DAT_181d94a60), lVar6 == null || (lVar5 == null))))))
            throw; // [null/range check failed]
            cVar2 = FUN_18181e400(lVar5);
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
            if ((((*pStatics == 0) ||
                 (lVar5 = *(int64 *)(*pStatics + 32)) == null) ||
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
                lVar5 = GameObject.GetComponent(this.temp,DAT_181d72568);
                lVar6 = FUN_18046c0a0(0);
                if ((((lVar6 == null) || (*(int64 *)(lVar6 + 32) == 0)) ||
                    (lVar6 = WorldData.Player(*(int64 *)(lVar6 + 32),0)) == null) ||
                   ((*(int64 *)(lVar6 + 0x2e8) == 0 ||
                    (uVar7 = FUN_180002f80(*(int64 *)(lVar6 + 0x2e8),iVar3), lVar5 == null))))
                throw; // [null/range check failed]
                *(uint64 *)(lVar5 + 24) = uVar7;
                break;
              }
              if (((this.missionTable == null) ||
                  (lVar5 = GameObject.get_transform(this.missionTable,0)) == null) ||
                 ((lVar5 = Transform.GetChild(lVar5,iVar4,0), lVar5 == null ||
                  (lVar5 = Component.GetComponent(lVar5,DAT_181d94a60)) == null)))
              throw; // [null/range check failed]
              lVar5 = *(int64 *)(lVar5 + 24);
              lVar6 = FUN_18046c0a0(0);
              if ((((lVar6 == null) || (*(int64 *)(lVar6 + 32) == 0)) ||
                  (lVar6 = WorldData.Player(*(int64 *)(lVar6 + 32),0)) == null) ||
                 (*(int64 *)(lVar6 + 0x2e8) == 0)) throw; // [null/range check failed]
              lVar6 = FUN_180002f80();
            } while (lVar5 != lVar6);
            iVar3 = iVar3 + 1;
          }
        }
    }

    // Token : 0x600193D
    // RVA   : 0x3A17B0   Offset: 0x3A0BB0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_18044ef50(this,0);
    }

    // Token : 0x600193E
    // RVA   : 0xE6DC80   Offset: 0xE6D080   Length: 0x1B3
    private void <PlayPigeonAnim>b__27_0()
    {
        long lVar1;
        ulong uVar2;
        if (this.pigeon != null) {
          lVar1 = GameObject.GetComponent(this.pigeon,DAT_181d735e0);
          if (lVar1 != null) {
            lVar1 = SkeletonGraphic.get_AnimationState(lVar1,0);
            if (lVar1 != null) {
              *(uint32 *)(lVar1 + 108) = 0x40000000;
              if (this.pigeon != null) {
                lVar1 = GameObject.GetComponent(this.pigeon,DAT_181d735e0);
                if (lVar1 != null) {
                  lVar1 = SkeletonGraphic.get_AnimationState(lVar1,0);
                  if (lVar1 != null) {
                    AnimationState.SetAnimation(lVar1,0,"fly",1,0);
                    if (this.pigeon != null) {
                      uVar2 = GameObject.get_transform(this.pigeon,0);
                      uVar2 = ShortcutExtensions.DOScale(uVar2,0x3f400000,0x3f400000,0);
                      uVar2 = TweenSettingsExtensions.SetLoops(uVar2,2,1,DAT_181dc1330);
                      TweenSettingsExtensions.SetEase(uVar2,7,DAT_181dc0f80);
                      plVar3 = (int64 *)Resources.Load("Sound/SoundEffect/鸽子",0);
                      plVar4 = (int64 *)0;
                      if ((plVar3 != (int64 *)0) && (*plVar3 == DAT_181daf348)) {
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

    // Token : 0x600193F
    // RVA   : 0xE6DE40   Offset: 0xE6D240   Length: 0x11C
    private void <PlayPigeonAnim>b__27_1()
    {
        long lVar1;
        uint local_18;
        uint uStack_14;
        uint uStack_10;
        uint32 uStack_c;
        if (this.pigeon != null) {
          lVar1 = GameObject.GetComponent(this.pigeon,DAT_181d735e0);
          if (lVar1 != null) {
            lVar1 = SkeletonGraphic.get_AnimationState(lVar1,0);
            if (lVar1 != null) {
              *(uint32 *)(lVar1 + 108) = 0x3f800000;
              if (this.pigeon != null) {
                lVar1 = GameObject.GetComponent(this.pigeon,DAT_181d735e0);
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
