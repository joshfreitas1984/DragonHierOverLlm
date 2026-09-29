// ============================================================
// Type  : DebateUIController
// Token : 0x2000261
// ============================================================

public class DebateUIController
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x400130F
    public DebateState debateState;

    // Token: 0x4001310
    public GameObject debateUIPanel;

    // Token: 0x4001311
    public GameObject giveUpButton;

    // Token: 0x4001312
    public GameObject refreshCardButton;

    // Token: 0x4001313
    public GameObject debateTopicPrefab;

    // Token: 0x4001314
    public GameObject debateCardPrefab;

    // Token: 0x4001315
    public HeroData enemyData;

    // Token: 0x4001316
    public GameObject playerIcon;

    // Token: 0x4001317
    public GameObject enemyIcon;

    // Token: 0x4001318
    public List<BaseAttriType> debateTopics;

    // Token: 0x4001319
    public BaseAttriType nextDebateTopic;

    // Token: 0x400131A
    public int lastTopic;

    // Token: 0x400131B
    public int nowTopic;

    // Token: 0x400131C
    public bool playerActiveRound;

    // Token: 0x400131D
    public float playerPatient;

    // Token: 0x400131E
    public int playerAngryRound;

    // Token: 0x400131F
    public float enemyPatient;

    // Token: 0x4001320
    public int enemyAngryRound;

    // Token: 0x4001321
    public bool cardUsed;

    // Token: 0x4001322
    public string fightEndCallFuc;

    // Token: 0x4001323
    public bool playerWin;

    // Token: 0x4001324
    public bool waitClick;

    // Token: 0x4001325
    private GameObject temp;

    // Token: 0x4001326
    public static List<string> ActiveTalkText;

    // Token: 0x4001327
    public static List<string> WinPassiveTalkText;

    // Token: 0x4001328
    public static List<string> LosePassiveTalkText;

    // Token: 0x4001329
    public static List<string> DrawPassiveTalkText;

    // Token: 0x400132A
    private static DebateUIController _instance;

    // Token: 0x400132B
    private float playerMaxPatient;

    // Token: 0x400132C
    private float enemyMaxPatient;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x600138A
    // RVA   : 0xA58930   Offset: 0xA57D30   Length: 0x58
    public static DebateUIController get_Instance()
    {
        return *(uint64 *)(*(int64 *)(DAT_181dbfc58 + 184) + 32);
    }

    // Token : 0x600138B
    // RVA   : 0xA50C50   Offset: 0xA50050   Length: 0x68
    private void Awake()
    {
        puVar1 = (uint64 *)(*(int64 *)(DAT_181dbfc58 + 184) + 32);
        *puVar1 = this;
        il2cpp_internal(puVar1,this);
    }

    // Token : 0x600138C
    // RVA   : 0xA56FB0   Offset: 0xA563B0   Length: 0xA99
    public void ShowDebateUI(HeroData _enemyData, string _fightEndCallFuc)
    {
        var pStatics_2ee8 = *(int64*)(DAT_181d72ee8 + 184);
        float fVar1;
        bool cVar2;
        uint uVar3;
        uint uVar4;
        long lVar5;
        ulong uVar6;
        long lVar7;
        ulong uVar8;
        long lVar10;
        int iVar11;
        float fVar13;
        uint[] local_res8 = new uint[2];
        local_res8[0] = 0;
        this.fightEndCallFuc = _fightEndCallFuc;
        if (this.debateUIPanel != null) {
          GameObject.SetActive(this.debateUIPanel,1,0);
          if ((((this.debateUIPanel != null) &&
               (lVar5 = GameObject.get_transform(this.debateUIPanel,0)) != null) &&
              (lVar5 = Transform.Find(lVar5,"Player",0)) != null) &&
             (lVar5 = Transform.Find(lVar5,"Icon",0)) != null) {
            uVar6 = Component.get_gameObject(lVar5,0);
            if (*pStatics_2ee8 != 0) {
              uVar8 = *(uint64 *)(*pStatics_2ee8 + 144);
              lVar5 = GlobalData.AddChild(uVar6,uVar8,0);
              this.temp = lVar5;
              if (*plVar9 != 0) {
                lVar5 = GameObject.GetComponent(*plVar9,DAT_181d71b50);
                if (((GameController._instance != null) &&
                    (lVar7 = GameController._instance.worldData) != null) &&
                   (uVar6 = WorldData.Player(lVar7,0), lVar5 != null)) {
                  lVar5.villageAreaID = uVar6;
                  if ((*plVar9 != 0) &&
                     (lVar5 = GameObject.GetComponent(*plVar9,DAT_181d71b50)) != null) {
                    lVar5.cityAreaID = 0;
                    if ((*plVar9 != 0) &&
                       (lVar5 = GameObject.GetComponent(*plVar9,DAT_181d71b50)) != null) {
                      lVar5.TempHeros = 1;
                      this.playerIcon = *plVar9;
                      this.enemyData = _enemyData;
                      if ((((this.debateUIPanel != null) &&
                           (lVar5 = GameObject.get_transform(this.debateUIPanel,0), lVar5 != null
                           )) && (lVar5 = Transform.Find(lVar5,"Enemy",0)) != null) &&
                         (lVar5 = Transform.Find(lVar5,"Icon",0)) != null) {
                        uVar6 = Component.get_gameObject(lVar5,0);
                        if (*pStatics_2ee8 != 0) {
                          lVar5 = GlobalData.AddChild
                                            (uVar6,*(uint64 *)
                                                    (*pStatics_2ee8 + 144),0);
                          *plVar9 = lVar5;
                          il2cpp_internal(plVar9,lVar5);
                          if (*plVar9 != 0) {
                            lVar5 = GameObject.GetComponent(*plVar9,DAT_181d71b50);
                            if (lVar5 != null) {
                              lVar5.villageAreaID = this.enemyData;
                              if ((*plVar9 != 0) &&
                                 (lVar5 = GameObject.GetComponent(*plVar9,DAT_181d71b50)) != null) {
                                lVar5.cityAreaID = 0;
                                if ((*plVar9 != 0) &&
                                   (lVar5 = GameObject.GetComponent(*plVar9,DAT_181d71b50)) != null)
                                {
                                  lVar5.TempHeros = 1;
                                  this.enemyIcon = *plVar9;
                                  if ((((GameController._instance != null) &&
                                       (lVar5 = *(int64 *)
                                                 (GameController._instance + 32),
                                       lVar5 != null)) && (lVar5 = WorldData.Player(lVar5,0)) != null)
                                     && (lVar5 = lVar5.showRoomChangeFame) != null) {
                                    if (lVar5.cityAreaID < 4) {
                                      ThrowHelper.ThrowArgumentOutOfRangeException(0);
                                    }
                                    fVar13 = (float)(int)*(float *)(lVar5.chapter + 44) +
                                             50.0;
                                    this.playerPatient = fVar13;
                                    if ((this.enemyData != null) &&
                                       (lVar5 = this.enemyData.totalLivingSkill,
                                       lVar5 != null)) {
                                      if (lVar5.cityAreaID < 4) {
                                        ThrowHelper.ThrowArgumentOutOfRangeException(0);
                                        fVar13 = this.playerPatient;
                                      }
                                      fVar1 = *(float *)(lVar5.chapter + 44);
                                      this.playerMaxPatient = fVar13;
                                      fVar13 = (float)(int)fVar1 + 50.0;
                                      this.enemyPatient = fVar13;
                                      this.enemyMaxPatient = fVar13;
                                      DebateUIController.RefreshPatientUI(this,0);
                                      lVar5 = il2cpp_internal(DAT_181d91378);
                                      FUN_181330100(lVar5,DAT_181d7e5e0);
                                      iVar11 = 15;
                                      while( true ) {
                                        uVar6 = DAT_181db47e8;
                                        uVar6 = Type.GetTypeFromHandle(uVar6,0);
                                        lVar7 = Enum.GetNames(uVar6,0);
                                        if (lVar7 == null) goto LAB_180a57a44;
                                        lVar10 = this.debateTopics;
                                        if (lVar7.Count <= iVar11) break;
                                        if (lVar10 == null) goto LAB_180a57a44;
                                        cVar2 = FUN_18182a9b0();
                                        if (!cVar2) {
                                          if (lVar5 == null) goto LAB_180a57a44;
                                          FUN_18182a6c0(lVar5);
                                        }
                                        iVar11 = iVar11 + 1;
                                      }
                                      if (lVar10 != null) goto LAB_180a57684;
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
        LAB_180a57a44:
                          // WARNING: Subroutine does not return
        FUN_1800d6620();
        LAB_180a57684:
        if (2 < lVar10.Count) {
          DebateUIController.GenerateNextTopic(this,0);
          DebateUIController.FullFillCard(this,1,0);
          DebateUIController.FullFillCard(this,0,0);
          if ((((GameController._instance != null) &&
               (lVar5 = GameController._instance.worldData) != null) &&
              (lVar5 = WorldData.Player(lVar5,0)) != null) &&
             (lVar5 = lVar5.showRoomChangeFame) != null) {
            if (lVar5.cityAreaID < 4) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            fVar13 = *(float *)(lVar5.chapter + 44);
            if ((this.enemyData != null) &&
               (lVar5 = this.enemyData.totalLivingSkill) != null) {
              if (lVar5.cityAreaID < 4) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              fVar1 = *(float *)(lVar5.chapter + 44);
              this.debateState = 1;
              this.playerActiveRound = fVar1 <= fVar13;
              DebateUIController.RefreshAllButtonState(this,0);
              MonoBehaviour.Invoke(this,"NextDebateRound",0x40000000,0);
              plVar9 = (int64 *)Resources.Load("Sound/SoundEffect/紧张",0);
              plVar12 = (int64 *)0;
              if ((plVar9 != (int64 *)0) && (*plVar9 == DAT_181daf360)) {
                plVar12 = plVar9;
              }
              NGUITools.PlaySound(plVar12);
              return;
            }
          }
          goto LAB_180a57a44;
        }
        if (lVar5 == null) goto LAB_180a57a44;
        uVar3 = FUN_180d96040(0,lVar5.cityAreaID,0);
        if (lVar5.cityAreaID <= uVar3) {
          ThrowHelper.ThrowArgumentOutOfRangeException(0);
        }
        if (lVar10 == null) goto LAB_180a57a44;
        FUN_18182a6c0(lVar10,*(uint32 *)
                              (lVar5.chapter + 32 + (int64)(int)uVar3 * 4),
                      DAT_181d7e660);
        lVar7 = this.debateTopics;
        if (lVar7 == null) goto LAB_180a57a44;
        uVar3 = lVar7.Count;
        if (uVar3 <= uVar3 - 1) {
          ThrowHelper.ThrowArgumentOutOfRangeException(0);
        }
        FUN_1817ef410(lVar5,*(uint32 *)(lVar7._items + 28 + (int64)(int)uVar3 * 4)
                      ,DAT_181d7e858);
        if (((this.debateUIPanel == null) ||
            (lVar7 = GameObject.get_transform(this.debateUIPanel,0)) == null) ||
           (lVar7 = Transform.Find(lVar7,"Topic",0)) == null) goto LAB_180a57a44;
        uVar8 = Component.get_gameObject(lVar7,0);
        uVar6 = this.debateTopicPrefab;
        lVar7 = GlobalData.AddChild(uVar8,uVar6,0);
        *plVar9 = lVar7;
        il2cpp_internal(plVar9,lVar7);
        lVar7 = this.debateTopics;
        lVar10 = *plVar9;
        if (lVar7 == null) goto LAB_180a57a44;
        local_res8[0] = FUN_1800d6760(lVar7,lVar7.Count + -1,DAT_181d7e958);
        uVar6 = Int32.ToString(local_res8,0);
        if (lVar10 == null) goto LAB_180a57a44;
        Object.set_name(lVar10,uVar6,0);
        if (((*plVar9 == 0) || (lVar7 = GameObject.get_transform(*plVar9,0)) == null) ||
           (lVar7 = Transform.Find(lVar7,"Text",0)) == null) goto LAB_180a57a44;
        uVar6 = Component.GetComponent(lVar7,DAT_181d96178);
        lVar7 = this.debateTopics;
        if (lVar7 == null) goto LAB_180a57a44;
        uVar4 = FUN_1800d6760(lVar7,lVar7.Count + -1);
        GlobalData.GetBaseAttriName(uVar4,0);
        LTLocalization.SetText(uVar6);
        lVar10 = this.debateTopics;
        if (lVar10 == null) goto LAB_180a57a44;
        goto LAB_180a57684;
    }

    // Token : 0x600138D
    // RVA   : 0xA521A0   Offset: 0xA515A0   Length: 0xBD9
    public GameObject GetAIUseCard()
    {
        int iVar1;
        int iVar2;
        uint uVar3;
        uint uVar4;
        long lVar5;
        long lVar6;
        long lVar7;
        long lVar8;
        ulong uVar9;
        int iVar11;
        int iVar12;
        uint uVar13;
        float fVar14;
        uint local_res18;
        lVar5 = il2cpp_internal(DAT_181d92f70);
        FUN_181330100(lVar5,DAT_181d892b0);
        lVar6 = il2cpp_internal(DAT_181d92f70);
        FUN_181330100(lVar6,DAT_181d892b0);
        iVar11 = 0;
        while( true ) {
          if ((((this.debateUIPanel == null) ||
               (lVar7 = GameObject.get_transform(this.debateUIPanel,0)) == null) ||
              (lVar7 = Transform.Find(lVar7,"Enemy",0)) == null) ||
             (lVar7 = Transform.Find(lVar7,"Card",0)) == null) throw; // [null/range check failed]
          iVar1 = Transform.get_childCount(lVar7,0);
          if (iVar1 <= iVar11) break;
          if ((((this.debateUIPanel == null) ||
               (lVar7 = GameObject.get_transform(this.debateUIPanel,0)) == null) ||
              ((lVar7 = Transform.Find(lVar7,"Enemy"), lVar7 == null ||
               (((lVar7 = Transform.Find(lVar7,"Card"), lVar7 == null ||
                 (lVar7 = Transform.GetChild(lVar7,iVar11)) == null) ||
                (lVar7 = Component.GetComponent(lVar7)) == null))))) ||
             (lVar7 = *(int64 *)(lVar7 + 24)) == null) throw; // [null/range check failed]
          if (*(char *)(lVar7 + 16) == false) {
            iVar1 = this.enemyAngryRound;
          }
          else {
            iVar1 = this.playerAngryRound;
          }
          if (iVar1 < 1) {
            if ((*(char *)(lVar7 + 17) != false) ||
               (((this.lastTopic == -1 || (*(int *)(lVar7 + 24) != this.lastTopic))
                && ((this.nowTopic == -1 ||
                    (*(int *)(lVar7 + 24) == this.nowTopic)))))) {
        LAB_180a5244b:
              if (((this.debateUIPanel == null) ||
                  (lVar7 = GameObject.get_transform(this.debateUIPanel,0)) == null) ||
                 ((lVar7 = Transform.Find(lVar7,"Enemy",0), lVar7 == null ||
                  ((((lVar7 = Transform.Find(lVar7,"Card",0), lVar7 == null ||
                     (lVar7 = Transform.GetChild(lVar7,iVar11,0)) == null) ||
                    (lVar7 = Component.GetComponent(lVar7,DAT_181d93cf8)) == null) ||
                   (*(int64 *)(lVar7 + 24) == 0)))))) throw; // [null/range check failed]
              if (*(char *)(*(int64 *)(lVar7 + 24) + 17) == false) {
                if ((((this.debateUIPanel == null) ||
                     (lVar7 = GameObject.get_transform(this.debateUIPanel,0)) == null) ||
                    (lVar7 = Transform.Find(lVar7,"Enemy",0)) == null) ||
                   ((lVar7 = Transform.Find(lVar7,"Card",0), lVar7 == null ||
                    (lVar7 = Transform.GetChild(lVar7,iVar11,0)) == null))) throw; // [null/range check failed]
                Component.get_gameObject(lVar7,0);
                lVar7 = lVar5;
              }
              else {
                if (((this.debateUIPanel == null) ||
                    (lVar7 = GameObject.get_transform(this.debateUIPanel,0)) == null) ||
                   ((lVar7 = Transform.Find(lVar7,"Enemy",0), lVar7 == null ||
                    ((lVar7 = Transform.Find(lVar7,"Card",0), lVar7 == null ||
                     (lVar7 = Transform.GetChild(lVar7,iVar11,0)) == null))))) throw; // [null/range check failed]
                Component.get_gameObject(lVar7,0);
                lVar7 = lVar6;
              }
              if (lVar7 == null) throw; // [null/range check failed]
              FUN_18181e6b0(lVar7);
            }
        LAB_180a5266d:
            iVar11 = iVar11 + 1;
          }
          else {
            if (*(char *)(lVar7 + 17) == false) goto LAB_180a5266d;
            if (*(int *)(lVar7 + 20) == 4) goto LAB_180a5244b;
            iVar11 = iVar11 + 1;
          }
        }
        if (this.debateState == 2) {
          if (this.playerAngryRound < 1) {
            uVar4 = 0xffffffff;
            iVar11 = -999999;
            local_res18 = 0xffffffff;
            if (lVar5 != null) {
              uVar3 = *(uint32 *)(lVar5 + 24);
              if ((int)uVar3 < 1) goto LAB_180a52cfc;
              lVar7 = 32;
              uVar3 = 0;
              uVar4 = 0xffffffff;
              goto LAB_180a52890;
            }
          }
          else if (lVar5 != null) {
            uVar3 = *(uint32 *)(lVar5 + 24);
            if ((int)uVar3 < 1) {
              uVar4 = 0xffffffff;
              iVar11 = -999999;
              goto LAB_180a52cfc;
            }
            uVar4 = FUN_180d96040(0,uVar3,0);
            if (*(uint32 *)(lVar5 + 24) <= uVar4) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            lVar5 = *(int64 *)(lVar5 + 16);
            goto LAB_180a5283f;
          }
        }
        else if (lVar5 != null) {
          if (0 < *(int *)(lVar5 + 24)) {
            lVar7 = DebateUIController.WinPassiveTalkText;
            if (lVar7 == null) {
              uVar9 = **(uint64 **)(DAT_181d72ad8 + 184);
              lVar7 = new OnTooltipCB(uVar9,DAT_181d9ff40,DAT_181dab1d0);
              DebateUIController.WinPassiveTalkText = lVar7;
            }
            List_1.Sort(lVar5,lVar7,DAT_181d89730);
          }
          lVar7 = DebateUIController.GetOutCard(this,1,0);
          if (lVar6 != null) {
            if (0 < *(int *)(lVar6 + 24)) {
              if (*(int *)(lVar5 + 24) < 1) goto LAB_180a52d24;
              if (*(int *)(lVar5 + 24) == 0) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              lVar8 = *(int64 *)(*(int64 *)(lVar5 + 16) + 32);
              if ((((lVar8 == null) || (lVar8 = GameObject.GetComponent(lVar8,DAT_181dc8278)) == null)
                  || (*(int64 *)(lVar8 + 24) == 0)) || (lVar7 == null)) throw; // [null/range check failed]
              if ((*(int *)(*(int64 *)(lVar8 + 24) + 28) <= *(int *)(lVar7 + 28)) ||
                 (fVar14 = (float)Random.get_value(0), fVar14 < 0.5)) goto LAB_180a52d24;
            }
            if (0 < *(int *)(lVar5 + 24)) {
              if (*(int *)(lVar5 + 24) == 0) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              return *(uint64 *)(*(int64 *)(lVar5 + 16) + 32);
            }
            goto LAB_180a52d6d;
          }
        }
        throw; // [null/range check failed]
        LAB_180a52890:
        uVar13 = uVar3;
        uVar3 = *(uint32 *)(lVar5 + 24);
        if ((int)uVar13 < (int)uVar3) {
          if (uVar3 <= uVar13) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          lVar8 = *(int64 *)(*(int64 *)(lVar5 + 16) + lVar7);
          if (((lVar8 == null) || (lVar8 = GameObject.GetComponent(lVar8,DAT_181dc8278)) == null) ||
             (*(int64 *)(lVar8 + 24) == 0)) throw; // [null/range check failed]
          if (*(char *)(*(int64 *)(lVar8 + 24) + 17) == false) {
            lVar8 = FUN_180002f80(lVar5,uVar13,DAT_181d89930);
            if (((lVar8 == null) || (lVar8 = GameObject.GetComponent(lVar8,DAT_181dc8278)) == null) ||
               (*(int64 *)(lVar8 + 24) == 0)) throw; // [null/range check failed]
            iVar1 = *(int *)(*(int64 *)(lVar8 + 24) + 28);
            iVar12 = 0;
            while( true ) {
              if ((((this.debateUIPanel == null) ||
                   (lVar8 = GameObject.get_transform(this.debateUIPanel,0)) == null) ||
                  (lVar8 = Transform.Find(lVar8,"Player",0)) == null) ||
                 (lVar8 = Transform.Find(lVar8,"Card",0)) == null) throw; // [null/range check failed]
              iVar2 = Transform.get_childCount(lVar8,0);
              if (iVar2 <= iVar12) break;
              if ((((this.debateUIPanel == null) ||
                   (lVar8 = GameObject.get_transform(this.debateUIPanel,0)) == null) ||
                  ((lVar8 = Transform.Find(lVar8,"Player",0), lVar8 == null ||
                   ((lVar8 = Transform.Find(lVar8,"Card",0), lVar8 == null ||
                    (lVar8 = Transform.GetChild(lVar8,iVar12,0)) == null))))) ||
                 ((lVar8 = Component.GetComponent(lVar8,DAT_181d93cf8), lVar8 == null ||
                  (*(int64 *)(lVar8 + 24) == 0)))) throw; // [null/range check failed]
              iVar2 = *(int *)(*(int64 *)(lVar8 + 24) + 24);
              lVar8 = FUN_180002f80(lVar5,uVar13);
              if (((lVar8 == null) || (lVar8 = GameObject.GetComponent(lVar8)) == null) ||
                 (*(int64 *)(lVar8 + 24) == 0)) throw; // [null/range check failed]
              if (iVar2 == *(int *)(*(int64 *)(lVar8 + 24) + 24)) {
                lVar8 = FUN_180002f80(lVar5,uVar13);
                if (((lVar8 == null) || (lVar8 = GameObject.GetComponent(lVar8,DAT_181dc8278)) == null)
                   || (*(int64 *)(lVar8 + 24) == 0)) throw; // [null/range check failed]
                iVar2 = *(int *)(*(int64 *)(lVar8 + 24) + 28);
                if (((this.debateUIPanel == null) ||
                    (lVar8 = GameObject.get_transform(this.debateUIPanel,0)) == null) ||
                   (((lVar8 = Transform.Find(lVar8,"Player"), lVar8 == null ||
                     (((lVar8 = Transform.Find(lVar8,"Card"), lVar8 == null ||
                       (lVar8 = Transform.GetChild(lVar8,iVar12)) == null) ||
                      (lVar8 = Component.GetComponent(lVar8)) == null))) ||
                    (*(int64 *)(lVar8 + 24) == 0)))) throw; // [null/range check failed]
                if (iVar2 - *(int *)(*(int64 *)(lVar8 + 24) + 28) < iVar1) {
                  lVar8 = FUN_180002f80(lVar5,uVar13);
                  if (((lVar8 == null) || (lVar8 = GameObject.GetComponent(lVar8,DAT_181dc8278)) == null
                      ) || (*(int64 *)(lVar8 + 24) == 0)) throw; // [null/range check failed]
                  iVar1 = *(int *)(*(int64 *)(lVar8 + 24) + 28);
                  if (((this.debateUIPanel == null) ||
                      (lVar8 = GameObject.get_transform(this.debateUIPanel,0)) == null) ||
                     ((lVar8 = Transform.Find(lVar8,"Player"), lVar8 == null ||
                      ((((lVar8 = Transform.Find(lVar8,"Card"), lVar8 == null ||
                         (lVar8 = Transform.GetChild(lVar8,iVar12)) == null) ||
                        (lVar8 = Component.GetComponent(lVar8)) == null) ||
                       (*(int64 *)(lVar8 + 24) == 0)))))) throw; // [null/range check failed]
                  iVar1 = iVar1 - *(int *)(*(int64 *)(lVar8 + 24) + 28);
                }
              }
              iVar12 = iVar12 + 1;
            }
            uVar4 = local_res18;
            if (iVar1 > iVar11)
            {
              lVar7 = lVar7 + 8;
              uVar3 = uVar13 + 1;
              iVar11 = iVar1;
              local_res18 = uVar13;
              uVar4 = uVar13;
              }
              else {
            }
            lVar7 = lVar7 + 8;
            uVar3 = uVar13 + 1;
          }
          goto LAB_180a52890;
        }
        LAB_180a52cfc:
        if (lVar6 != null) {
          if ((*(int *)(lVar6 + 24) < 1) ||
             (((0 < (int)uVar3 && (0 < iVar11)) && (fVar14 = (float)Random.get_value(0), 0.5 <= fVar14)))
             ) {
            if ((int)*(uint32 *)(lVar5 + 24) < 1) {
        LAB_180a52d6d:
              uVar9 = 0;
            }
            else {
              if (*(uint32 *)(lVar5 + 24) <= uVar4) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              uVar9 = lVar5[uVar4];
            }
          }
          else {
        LAB_180a52d24:
            uVar4 = FUN_180d96040(0,*(uint32 *)(lVar6 + 24),0);
            if (*(uint32 *)(lVar6 + 24) <= uVar4) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            lVar5 = *(int64 *)(lVar6 + 16);
        LAB_180a5283f:
            uVar9 = lVar5[uVar4];
          }
          return uVar9;
        }
    }

    // Token : 0x600138E
    // RVA   : 0xA52F40   Offset: 0xA52340   Length: 0x79
    public Transform GetOutCardRoot(bool isPlayer)
    {
        long lVar1;
        ulong uVar2;
        if (this.debateUIPanel != null) {
          lVar1 = GameObject.get_transform(this.debateUIPanel,0);
          uVar2 = "EnemyOutCard";
          if (isPlayer) {
            uVar2 = "PlayerOutCard";
          }
          if (lVar1 != null) {
            Transform.Find(lVar1,uVar2,0);
            return;
          }
        }
    }

    // Token : 0x600138F
    // RVA   : 0xA52EC0   Offset: 0xA522C0   Length: 0x76
    public GameObject GetOutCardObj(bool isPlayer)
    {
        int iVar1;
        long lVar2;
        ulong uVar3;
        lVar2 = DebateUIController.GetOutCardRoot(this,isPlayer,0);
        if (lVar2 != null) {
          iVar1 = Transform.get_childCount(lVar2,0);
          if (iVar1 < 1) {
            return false;
          }
          lVar2 = DebateUIController.GetOutCardRoot(this,isPlayer & 255,0);
          if (lVar2 != null) {
            lVar2 = Transform.GetChild(lVar2,0,0);
            if (lVar2 != null) {
              uVar3 = Component.get_gameObject(lVar2,0);
              return uVar3;
            }
          }
        }
    }

    // Token : 0x6001390
    // RVA   : 0xA52FC0   Offset: 0xA523C0   Length: 0xA7
    public DebateCardData GetOutCard(bool isPlayer)
    {
        int iVar1;
        long lVar2;
        lVar2 = DebateUIController.GetOutCardRoot(this,isPlayer,0);
        if (lVar2 != null) {
          iVar1 = Transform.get_childCount(lVar2,0);
          if (iVar1 < 1) {
            return false;
          }
          lVar2 = DebateUIController.GetOutCardRoot(this,isPlayer,0);
          if (lVar2 != null) {
            lVar2 = Transform.GetChild(lVar2,0,0);
            if (lVar2 != null) {
              lVar2 = Component.GetComponent(lVar2,DAT_181d93cf8);
              if (lVar2 != null) {
                return *(uint64 *)(lVar2 + 24);
              }
            }
          }
        }
    }

    // Token : 0x6001391
    // RVA   : 0xA561D0   Offset: 0xA555D0   Length: 0x1A5
    public void PlayAttackAnim(GameObject attackCard, GameObject targetObj)
    {
        long lVar2;
        ulong uVar3;
        ulong local_28;
        uint local_20;
        byte[] local_18 = new byte[16];
        plVar1 = (int64 *)Resources.Load("Sound/SoundEffect/AtkHit0",0);
        plVar5 = (int64 *)0;
        if ((plVar1 != (int64 *)0) && (*plVar1 == DAT_181daf360)) {
          plVar5 = plVar1;
        }
        NGUITools.PlaySound(plVar5,0);
        if (attackCard != null) {
          lVar2 = GameObject.get_transform(attackCard,0);
          if (lVar2 != null) {
            lVar2 = FUN_180daa030(lVar2,0);
            if (lVar2 != null) {
              Transform.SetAsLastSibling(lVar2,0);
              uVar3 = GameObject.get_transform(attackCard,0);
              uVar3 = ShortcutExtensions.DOScale(uVar3,0x3fc00000,0x3e800000,0);
              TweenSettingsExtensions.SetLoops(uVar3,2,1,DAT_181dc14d8);
              uVar3 = GameObject.get_transform(attackCard,0);
              if (targetObj != null) {
                lVar2 = GameObject.get_transform(targetObj,0);
                if (lVar2 != null) {
                  puVar4 = (uint64 *)Transform.get_position(local_18,lVar2,0);
                  local_28 = *puVar4;
                  local_20 = *(uint32 *)(puVar4 + 1);
                  uVar3 = ShortcutExtensions.DOMove(uVar3,&local_28,0x3e800000,0,0);
                  TweenSettingsExtensions.SetLoops(uVar3,2,1,DAT_181dc14d8);
                  return;
                }
              }
            }
          }
        }
    }

    // Token : 0x6001392
    // RVA   : 0xA56EC0   Offset: 0xA562C0   Length: 0xE0
    public void SetCardDark(GameObject targetCard)
    {
        ulong uVar1;
        bool cVar3;
        long lVar4;
        uint local_18;
        uint uStack_14;
        uint uStack_10;
        uint32 uStack_c;
        cVar3 = Object.op_Inequality(targetCard,0,0);
        if (!cVar3) {
          return;
        }
        if (((targetCard != null) && (lVar4 = GameObject.get_transform(targetCard,0)) != null) &&
           (lVar4 = Transform.Find(lVar4,"Back",0)) != null) {
          uVar1 = Component.GetComponent(lVar4,DAT_181d94478);
          puVar2 = (uint32 *)FUN_1810d3a00(&local_18,0);
          local_18 = *puVar2;
          uStack_14 = puVar2[1];
          uStack_10 = puVar2[2];
          uStack_c = puVar2[3];
          DOTweenModuleUI.DOColor(uVar1,&local_18,0x3f000000,0);
          return;
        }
    }

    // Token : 0x6001393
    // RVA   : 0xA536E0   Offset: 0xA52AE0   Length: 0x2AAC
    public void NextDebateRound()
    {
        var pStatics_dd10 = *(int64*)(DAT_181dadd10 + 184);
        float fVar4;
        bool cVar5;
        uint uVar6;
        int iVar7;
        long lVar8;
        long lVar11;
        ulong uVar13;
        ulong uVar14;
        ulong uVar15;
        ulong uVar16;
        ulong uVar18;
        long lVar19;
        long lVar20;
        int iVar22;
        float fVar25;
        float fVar26;
        long local_128;
        float local_120;
        uint local_118;
        uint uStack_114;
        uint uStack_110;
        uint32 uStack_10c;
        uint64 local_108;
        float local_100;
        int local_f8;
        uint64 local_e8;
        uint32 local_e0;
        uint64 local_d8;
        uint32 local_d0;
        uint64 local_c8;
        uint32 local_c0;
        uint8 local_b8 [16];
        uint8 local_a8 [16];
        uint8 local_98 [96];
        if (*pStatics_dd10 == 0) goto LAB_180a5617e;
        TutorialController.StartTutorial(*pStatics_dd10,"论战系统",0);
        this.debateState = this.debateState + 1;
        this.cardUsed = 0;
        switch(this.debateState) {
        case 2:
          if (!this.playerActiveRound) {
            uVar16 = DebateUIController.GetAIUseCard(this,0);
            DebateUIController.UseDebateCard(this,uVar16,0);
          }
          break;
        case 3:
          if (this.playerActiveRound) {
            uVar16 = DebateUIController.GetAIUseCard(this,0);
            DebateUIController.UseDebateCard(this,uVar16,0);
          }
          break;
        case 4:
          lVar19 = DebateUIController.GetOutCard(this,0x180000001,0);
          lVar20 = DebateUIController.GetOutCard(this,0,0);
          if (((this.debateUIPanel == null) ||
              (lVar8 = GameObject.get_transform(this.debateUIPanel,0)) == null) ||
             (lVar8 = Transform.Find(lVar8,"Player",0)) == null) goto LAB_180a5617e;
          uVar16 = Transform.Find(lVar8,"Result",0);
          plVar17 = (int64 *)Vector3.get_one(&local_128,0);
          local_100 = *(float *)(plVar17 + 1);
          local_108 = *plVar17;
          uVar16 = ShortcutExtensions.DOScale(uVar16,&local_108);
          uVar18 = new OnTooltipCB(this,DAT_181da9388,0);
          TweenSettingsExtensions.OnComplete(uVar16,uVar18,DAT_181dc0380);
          if (((this.debateUIPanel == null) ||
              (lVar8 = GameObject.get_transform(this.debateUIPanel,0)) == null) ||
             (lVar8 = Transform.Find(lVar8,"Enemy",0)) == null) goto LAB_180a5617e;
          uVar16 = Transform.Find(lVar8,"Result",0);
          puVar9 = (uint64 *)Vector3.get_one(&local_128,0);
          local_100 = *(float *)(puVar9 + 1);
          local_108 = *puVar9;
          ShortcutExtensions.DOScale(uVar16,&local_108);
          lVar8 = il2cpp_internal(DAT_181d97768);
          local_108 = lVar8;
          FUN_181330100(lVar8,DAT_181da3bf0);
          if (lVar8 == null) goto LAB_180a5617e;
          FUN_18181e6b0(lVar8,"这......",DAT_181da3d70);
          bVar1 = false;
          bVar23 = false;
          bVar2 = false;
          bVar3 = false;
          if (lVar19 == null) goto LAB_180a5617e;
          plVar17 = (int64 *)0;
          iVar7 = 0;
          if (*(char *)(lVar19 + 17) == false) {
            if (lVar20 == null) goto LAB_180a5617e;
            if (*(char *)(lVar20 + 17) != false) goto LAB_180a53c3d;
            goto LAB_180a54751;
          }
        LAB_180a53c3d:
          if (DebateCardData.SpeCardName == null) goto LAB_180a5617e;
          local_f8 = DebateCardData.SpeCardName.targetAttriID + -1;
          if (local_f8 < 0) {
        LAB_180a54751:
            if (*(char *)(lVar19 + 17) != false) goto LAB_180a5475b;
        LAB_180a54ad2:
            iVar22 = *(int *)(lVar19 + 28);
        LAB_180a54ad6:
            if (!bVar23) {
              if (lVar20 == null) goto LAB_180a5617e;
              if (*(char *)(lVar20 + 17) == false) {
                iVar7 = *(int *)(lVar20 + 28);
              }
            }
            if (iVar7 < iVar22) {
              if (!this.playerActiveRound) {
                lVar8 = PlotController.fightSkillIndexCache;
              }
              else {
                lVar8 = PlotController.livingSkillIndexCache;
              }
              DebateUIController.ChangePatient
                        (this,0,((float)(iVar22 - iVar7) * 0.025 + 1.0) * -10.0,0);
              uVar16 = DebateUIController.GetOutCardObj(this,1,0);
              DebateUIController.PlayAttackAnim(this,uVar16,this.enemyIcon,0);
              uVar16 = DebateUIController.GetOutCardObj(this,0,0);
              DebateUIController.SetCardDark(this,uVar16,0);
              if ((((this.debateUIPanel == null) ||
                   (lVar11 = GameObject.get_transform(this.debateUIPanel,0)) == null) ||
                  (lVar11 = Transform.Find(lVar11,"Player",0)) == null) ||
                 (lVar11 = Transform.Find(lVar11,"Result",0)) == null) goto LAB_180a5617e;
              uVar16 = Component.GetComponent(lVar11,DAT_181d96178);
              LTLocalization.SetText(uVar16,"胜",0);
              if (((this.debateUIPanel == null) ||
                  (lVar11 = GameObject.get_transform(this.debateUIPanel,0)) == null) ||
                 ((lVar11 = Transform.Find(lVar11,"Player",0), lVar11 == null ||
                  (lVar11 = Transform.Find(lVar11,"Result",0)) == null))) goto LAB_180a5617e;
              plVar17 = (int64 *)Component.GetComponent(lVar11,DAT_181d96178);
              puVar12 = (uint32 *)Color.get_green(&local_118,0);
              if (plVar17 == (int64 *)0) goto LAB_180a5617e;
              local_118 = *puVar12;
              uStack_114 = puVar12[1];
              uStack_110 = puVar12[2];
              uStack_10c = puVar12[3];
              (**(code **)(*plVar17 + 0x2a8))(plVar17,&local_118,*(uint64 *)(*plVar17 + 0x2b0));
              if ((((this.debateUIPanel == null) ||
                   (lVar11 = GameObject.get_transform(this.debateUIPanel,0)) == null) ||
                  (lVar11 = Transform.Find(lVar11,"Enemy",0)) == null) ||
                 (lVar11 = Transform.Find(lVar11,"Result",0)) == null) goto LAB_180a5617e;
              uVar16 = Component.GetComponent(lVar11,DAT_181d96178);
              LTLocalization.SetText(uVar16,"负",0);
              if (((this.debateUIPanel == null) ||
                  (lVar11 = GameObject.get_transform(this.debateUIPanel,0)) == null) ||
                 ((lVar11 = Transform.Find(lVar11,"Enemy",0), lVar11 == null ||
                  (lVar11 = Transform.Find(lVar11,"Result",0)) == null))) goto LAB_180a5617e;
              plVar17 = (int64 *)Component.GetComponent(lVar11,DAT_181d96178);
              puVar12 = (uint32 *)Color.get_red(&local_118,0);
        LAB_180a55520:
              if (plVar17 == (int64 *)0) {
        LAB_180a5617e:
                          // WARNING: Subroutine does not return
                FUN_1800d6620();
              }
            }
            else {
              if (iVar22 < iVar7) {
                if (!this.playerActiveRound) {
                  lVar8 = PlotController.livingSkillIndexCache;
                }
                else {
                  lVar8 = PlotController.fightSkillIndexCache;
                }
                DebateUIController.ChangePatient
                          (this,1,((float)(iVar7 - iVar22) * 0.025 + 1.0) * -10.0,0);
                uVar16 = DebateUIController.GetOutCardObj(this,0,0);
                DebateUIController.PlayAttackAnim(this,uVar16,this.playerIcon,0);
                uVar16 = DebateUIController.GetOutCardObj(this,1,0);
                DebateUIController.SetCardDark(this,uVar16,0);
                if ((((this.debateUIPanel == null) ||
                     (lVar11 = GameObject.get_transform(this.debateUIPanel,0)) == null)
                    || (lVar11 = Transform.Find(lVar11,"Player",0)) == null) ||
                   (lVar11 = Transform.Find(lVar11,"Result",0)) == null) goto LAB_180a5617e;
                uVar16 = Component.GetComponent(lVar11,DAT_181d96178);
                LTLocalization.SetText(uVar16,"负",0);
                if (((this.debateUIPanel == null) ||
                    (lVar11 = GameObject.get_transform(this.debateUIPanel,0)) == null) ||
                   ((lVar11 = Transform.Find(lVar11,"Player",0), lVar11 == null ||
                    (lVar11 = Transform.Find(lVar11,"Result",0)) == null))) goto LAB_180a5617e;
                plVar17 = (int64 *)Component.GetComponent(lVar11,DAT_181d96178);
                puVar12 = (uint32 *)Color.get_red(&local_118,0);
                if (plVar17 == (int64 *)0) goto LAB_180a5617e;
                local_118 = *puVar12;
                uStack_114 = puVar12[1];
                uStack_110 = puVar12[2];
                uStack_10c = puVar12[3];
                (**(code **)(*plVar17 + 0x2a8))(plVar17,&local_118,*(uint64 *)(*plVar17 + 0x2b0));
                if ((((this.debateUIPanel == null) ||
                     (lVar11 = GameObject.get_transform(this.debateUIPanel,0)) == null)
                    || (lVar11 = Transform.Find(lVar11,"Enemy",0)) == null) ||
                   (lVar11 = Transform.Find(lVar11,"Result",0)) == null) goto LAB_180a5617e;
                uVar16 = Component.GetComponent(lVar11,DAT_181d96178);
                LTLocalization.SetText(uVar16,"胜",0);
                if (((this.debateUIPanel == null) ||
                    (lVar11 = GameObject.get_transform(this.debateUIPanel,0)) == null) ||
                   ((lVar11 = Transform.Find(lVar11,"Enemy",0), lVar11 == null ||
                    (lVar11 = Transform.Find(lVar11,"Result",0)) == null))) goto LAB_180a5617e;
                plVar17 = (int64 *)Component.GetComponent(lVar11,DAT_181d96178);
                puVar12 = (uint32 *)Color.get_green(&local_118,0);
                goto LAB_180a55520;
              }
              lVar8 = PlotController._instance;
              uVar16 = DebateUIController.GetOutCardObj(this,1,0);
              DebateUIController.SetCardDark(this,uVar16,0);
              uVar16 = DebateUIController.GetOutCardObj(this,0,0);
              DebateUIController.SetCardDark(this,uVar16,0);
              if ((((this.debateUIPanel == null) ||
                   (lVar11 = GameObject.get_transform(this.debateUIPanel,0)) == null) ||
                  (lVar11 = Transform.Find(lVar11,"Player",0)) == null) ||
                 (lVar11 = Transform.Find(lVar11,"Result",0)) == null) goto LAB_180a5617e;
              uVar16 = Component.GetComponent(lVar11,DAT_181d96178);
              LTLocalization.SetText(uVar16,"平",0);
              if (((this.debateUIPanel == null) ||
                  (lVar11 = GameObject.get_transform(this.debateUIPanel,0)) == null) ||
                 ((lVar11 = Transform.Find(lVar11,"Player",0), lVar11 == null ||
                  (lVar11 = Transform.Find(lVar11,"Result",0)) == null))) goto LAB_180a5617e;
              plVar17 = (int64 *)Component.GetComponent(lVar11,DAT_181d96178);
              puVar12 = (uint32 *)FUN_1810d3a00(&local_118,0);
              if (plVar17 == (int64 *)0) goto LAB_180a5617e;
              local_118 = *puVar12;
              uStack_114 = puVar12[1];
              uStack_110 = puVar12[2];
              uStack_10c = puVar12[3];
              (**(code **)(*plVar17 + 0x2a8))(plVar17,&local_118,*(uint64 *)(*plVar17 + 0x2b0));
              if ((((this.debateUIPanel == null) ||
                   (lVar11 = GameObject.get_transform(this.debateUIPanel,0)) == null) ||
                  (lVar11 = Transform.Find(lVar11,"Enemy",0)) == null) ||
                 (lVar11 = Transform.Find(lVar11,"Result",0)) == null) goto LAB_180a5617e;
              uVar16 = Component.GetComponent(lVar11,DAT_181d96178);
              LTLocalization.SetText(uVar16,"平",0);
              if (((this.debateUIPanel == null) ||
                  (lVar11 = GameObject.get_transform(this.debateUIPanel,0)) == null) ||
                 ((lVar11 = Transform.Find(lVar11,"Enemy",0), lVar11 == null ||
                  (lVar11 = Transform.Find(lVar11,"Result",0)) == null))) goto LAB_180a5617e;
              plVar17 = (int64 *)Component.GetComponent(lVar11,DAT_181d96178);
              puVar12 = (uint32 *)FUN_1810d3a00(&local_118,0);
              fVar4 = local_120;
              if (plVar17 == (int64 *)0) goto LAB_180a56184;
            }
            local_118 = *puVar12;
            uStack_114 = puVar12[1];
            uStack_110 = puVar12[2];
            uStack_10c = puVar12[3];
            (**(code **)(*plVar17 + 0x2a8))(plVar17,&local_118,*(uint64 *)(*plVar17 + 0x2b0));
          }
          else {
            do {
              bVar24 = false;
              if (local_f8 == 0) {
                if (lVar19 == null) goto LAB_180a5617e;
                if (((*(char *)(lVar19 + 17) == false) || (*(int *)(lVar19 + 20) != 0)) || (bVar1)) {
                  if (lVar20 == null) goto LAB_180a5617e;
                }
                else {
                  DebateUIController.ChangePatient(this,0);
                  DebateUIController.GetOutCardObj(this,1,0);
                  DebateUIController.PlayAttackAnim(this);
                  if (lVar20 == null) goto LAB_180a5617e;
                  bVar24 = *(char *)(lVar20 + 17) == false;
                  plVar10 = (int64 *)Resources.Load("Sound/SoundEffect/SpeEffect/剑鸣");
                  plVar21 = plVar17;
                  if ((plVar10 != (int64 *)0) && (*plVar10 == DAT_181daf360)) {
                    plVar21 = plVar10;
                  }
                  NGUITools.PlaySound(plVar21);
                  bVar1 = bVar2;
                  bVar23 = bVar3;
                }
                if (((*(char *)(lVar20 + 17) != false) && (*(int *)(lVar20 + 20) == 0)) && (!bVar23)) {
                  DebateUIController.ChangePatient(this,1);
                  DebateUIController.GetOutCardObj(this,0,0);
                  DebateUIController.PlayAttackAnim(this);
                  bVar23 = *(char *)(lVar19 + 17) == false;
                  plVar10 = (int64 *)Resources.Load("Sound/SoundEffect/SpeEffect/剑鸣");
                  plVar21 = plVar17;
                  if ((plVar10 != (int64 *)0) && (*plVar10 == DAT_181daf360)) {
                    plVar21 = plVar10;
                  }
                  NGUITools.PlaySound(plVar21);
        LAB_180a5490a:
                  bVar1 = bVar2;
                  if (bVar23) {
        LAB_180a5490e:
                    bVar2 = true;
                    DebateUIController.GetOutCardObj(this,1);
                    DebateUIController.SetCardDark(this);
                    bVar1 = true;
                  }
                }
                goto LAB_180a5493f;
              }
              if (local_f8 == 1) {
                if (lVar19 == null) goto LAB_180a5617e;
                if (((*(char *)(lVar19 + 17) != false) && (*(int *)(lVar19 + 20) == 1)) && (!bVar1)) {
                  bVar23 = !DAT_181e9d9a2;
                  this.enemyAngryRound = 2;
                  if (bVar23) {
                    il2cpp_internal(&"Enemy");
                    il2cpp_internal(&"Player");
                    DAT_181e9d9a2 = true;
                  }
                  if (((this.debateUIPanel == null) ||
                      (lVar8 = GameObject.get_transform(this.debateUIPanel,0)) == null) ||
                     ((lVar8 = Transform.Find(lVar8,"Enemy",0), lVar8 == null ||
                      (lVar8 = Transform.Find(lVar8,"Angry",0)) == null))) goto LAB_180a5617e;
                  lVar8 = Component.get_gameObject(lVar8,0);
                  if (lVar8 == null) goto LAB_180a5617e;
                  GameObject.SetActive(lVar8,1,0);
                  if (((this.debateUIPanel == null) ||
                      (lVar8 = GameObject.get_transform(this.debateUIPanel,0)) == null) ||
                     (lVar8 = Transform.Find(lVar8,"Enemy",0)) == null) goto LAB_180a5617e;
                  lVar8 = Transform.Find(lVar8,"Angry",0);
                  puVar9 = (uint64 *)Vector3.get_one(local_98,0);
                  if (lVar8 == null) goto LAB_180a5617e;
                  local_e0 = *(uint32 *)(puVar9 + 1);
                  local_e8 = *puVar9;
                  Transform.set_localScale(lVar8,&local_e8,0);
                  if (((this.debateUIPanel == null) ||
                      (lVar8 = GameObject.get_transform(this.debateUIPanel,0)) == null) ||
                     (lVar8 = Transform.Find(lVar8,"Enemy",0)) == null) goto LAB_180a5617e;
                  uVar16 = Transform.Find(lVar8,"Angry",0);
                  uVar16 = ShortcutExtensions.DOScale(uVar16,0x3fa00000);
                  TweenSettingsExtensions.SetLoops(uVar16,0xffffffff,1);
                  DebateUIController.GetOutCardObj(this,1,0);
                  DebateUIController.PlayAttackAnim(this);
                  plVar10 = (int64 *)Resources.Load("Sound/SoundEffect/SpeEffect/吼叫");
                  plVar21 = plVar17;
                  if ((plVar10 != (int64 *)0) && (*plVar10 == DAT_181daf360)) {
                    plVar21 = plVar10;
                  }
                  NGUITools.PlaySound(plVar21);
                  bVar23 = bVar3;
                }
                if (lVar20 == null) goto LAB_180a5617e;
                if (((*(char *)(lVar20 + 17) != false) && (*(int *)(lVar20 + 20) == 1)) && (!bVar23)) {
                  bVar23 = !DAT_181e9d9a2;
                  this.playerAngryRound = 2;
                  if (bVar23) {
                    il2cpp_internal(&"Enemy");
                    il2cpp_internal(&"Player");
                    DAT_181e9d9a2 = true;
                  }
                  if (((this.debateUIPanel == null) ||
                      (lVar8 = GameObject.get_transform(this.debateUIPanel,0)) == null) ||
                     ((lVar8 = Transform.Find(lVar8,"Player",0), lVar8 == null ||
                      (lVar8 = Transform.Find(lVar8,"Angry",0)) == null))) goto LAB_180a5617e;
                  lVar8 = Component.get_gameObject(lVar8,0);
                  if (lVar8 == null) goto LAB_180a5617e;
                  GameObject.SetActive(lVar8,1,0);
                  if (((this.debateUIPanel == null) ||
                      (lVar8 = GameObject.get_transform(this.debateUIPanel,0)) == null) ||
                     (lVar8 = Transform.Find(lVar8,"Player",0)) == null) goto LAB_180a5617e;
                  lVar8 = Transform.Find(lVar8,"Angry",0);
                  plVar10 = (int64 *)Vector3.get_one(&local_118,0);
                  if (lVar8 == null) goto LAB_180a5617e;
                  local_120 = *(float *)(plVar10 + 1);
                  local_128 = *plVar10;
                  Transform.set_localScale(lVar8,&local_128,0);
                  if (((this.debateUIPanel == null) ||
                      (lVar8 = GameObject.get_transform(this.debateUIPanel,0)) == null) ||
                     (lVar8 = Transform.Find(lVar8,"Player",0)) == null) goto LAB_180a5617e;
                  uVar16 = Transform.Find(lVar8,"Angry",0);
                  uVar16 = ShortcutExtensions.DOScale(uVar16,0x3fa00000);
                  TweenSettingsExtensions.SetLoops(uVar16,0xffffffff,1);
                  DebateUIController.GetOutCardObj(this,0,0);
                  DebateUIController.PlayAttackAnim(this);
                  plVar10 = (int64 *)Resources.Load("Sound/SoundEffect/SpeEffect/吼叫");
                  plVar21 = plVar17;
                  if ((plVar10 != (int64 *)0) && (*plVar10 == DAT_181daf360)) {
                    plVar21 = plVar10;
                  }
                  NGUITools.PlaySound(plVar21);
                  bVar23 = bVar3;
                }
              }
              else if (local_f8 == 2) {
                if ((!bVar1) && (!bVar23)) {
                  if (lVar19 == null) goto LAB_180a5617e;
                  if ((*(char *)(lVar19 + 17) != false) && (*(int *)(lVar19 + 20) == 2)) {
                    if (lVar20 == null) goto LAB_180a5617e;
                    if ((*(char *)(lVar20 + 17) != false) && (*(int *)(lVar20 + 20) == 2)) {
                      lVar20 = DebateUIController.GetOutCardObj(this,0);
                      if (lVar20 != null) {
                        lVar20 = GameObject.get_transform(lVar20,0);
                        uVar16 = DebateUIController.GetOutCardRoot(this,1);
                        if (lVar20 != null) {
                          FUN_180daae30(lVar20,uVar16);
                          lVar20 = DebateUIController.GetOutCardObj(this,0);
                          if (lVar20 != null) {
                            uVar16 = GameObject.get_transform(lVar20,0);
                            puVar9 = (uint64 *)Vector3.get_zero(local_b8,0);
                            local_d0 = *(uint32 *)(puVar9 + 1);
                            local_d8 = *puVar9;
                            ShortcutExtensions.DOLocalMove(uVar16,&local_d8);
                            lVar20 = DebateUIController.GetOutCardObj(this,1);
                            if (lVar20 != null) {
                              lVar20 = GameObject.get_transform(lVar20,0);
                              uVar16 = DebateUIController.GetOutCardRoot(this,0);
                              if (lVar20 != null) {
                                FUN_180daae30(lVar20,uVar16);
                                lVar20 = DebateUIController.GetOutCardObj(this,1);
                                if (lVar20 != null) {
                                  uVar16 = GameObject.get_transform(lVar20,0);
                                  puVar9 = (uint64 *)Vector3.get_zero(local_a8,0);
                                  local_c0 = *(uint32 *)(puVar9 + 1);
                                  local_c8 = *puVar9;
                                  ShortcutExtensions.DOLocalMove(uVar16,&local_c8);
                                  lVar19 = DebateUIController.GetOutCard(this,1);
                                  lVar20 = DebateUIController.GetOutCard(this,0);
                                  bVar24 = true;
                                  uVar16 = "Sound/SoundEffect/SpeEffect/古筝";
                                  goto LAB_180a53e92;
                                }
                              }
                            }
                          }
                        }
                      }
                      goto LAB_180a5617e;
                    }
                    uVar16 = DebateUIController.GetOutCardObj(this,0);
                    this.temp = uVar16;
                    if (this.temp == null) goto LAB_180a5617e;
                    lVar19 = GameObject.get_transform(this.temp,0);
                    DebateUIController.GetOutCardRoot(this,1);
                    if (((lVar19 == null) || (FUN_180daae30(lVar19), this.temp == null)) ||
                       (lVar19 = GameObject.get_transform()) == null) goto LAB_180a5617e;
                    Transform.SetAsFirstSibling(lVar19);
                    bVar24 = true;
                    plVar10 = (int64 *)Resources.Load("Sound/SoundEffect/SpeEffect/古筝");
                    plVar21 = plVar17;
                    if ((plVar10 != (int64 *)0) && (*plVar10 == DAT_181daf360)) {
                      plVar21 = plVar10;
                    }
                    NGUITools.PlaySound(plVar21);
                    lVar19 = lVar20;
                  }
                  if (lVar20 != null) {
                    if ((*(char *)(lVar20 + 17) == false) || (*(int *)(lVar20 + 20) != 2))
                    goto LAB_180a5493f;
                    uVar16 = DebateUIController.GetOutCardObj(this,1);
                    this.temp = uVar16;
                    if (this.temp != null) {
                      lVar20 = GameObject.get_transform(this.temp,0);
                      uVar16 = DebateUIController.GetOutCardRoot(this,0);
                      if (lVar20 != null) {
                        FUN_180daae30(lVar20,uVar16);
                        if ((this.temp != null) &&
                           (lVar20 = GameObject.get_transform(this.temp,0),
                           lVar20 != null)) {
                          Transform.SetAsFirstSibling(lVar20,0);
                          uVar16 = "Sound/SoundEffect/SpeEffect/古筝";
                          lVar20 = lVar19;
                          goto LAB_180a53e92;
                        }
                      }
                    }
                  }
                  goto LAB_180a5617e;
                }
              }
              else if (local_f8 == 3) {
                if (lVar19 == null) goto LAB_180a5617e;
                if ((*(char *)(lVar19 + 17) != false) && (*(int *)(lVar19 + 20) == 3)) {
                  bVar24 = true;
                  plVar10 = (int64 *)Resources.Load("Sound/SoundEffect/SpeEffect/叹息");
                  plVar21 = plVar17;
                  if ((plVar10 != (int64 *)0) && (*plVar10 == DAT_181daf360)) {
                    plVar21 = plVar10;
                  }
                  NGUITools.PlaySound(plVar21);
                }
                if (lVar20 == null) goto LAB_180a5617e;
                if ((*(char *)(lVar20 + 17) != false) &&
                   (uVar16 = "Sound/SoundEffect/SpeEffect/叹息", *(int *)(lVar20 + 20) == 3)) {
        LAB_180a53e92:
                  plVar10 = (int64 *)Resources.Load(uVar16,0);
                  plVar21 = plVar17;
                  if ((plVar10 != (int64 *)0) && (*plVar10 == DAT_181daf360)) {
                    plVar21 = plVar10;
                  }
                  NGUITools.PlaySound(plVar21,0);
                  goto LAB_180a5490e;
                }
        LAB_180a5493f:
                bVar23 = bVar3;
                if (bVar24) {
                  bVar3 = true;
                  DebateUIController.GetOutCardObj(this,0);
                  DebateUIController.SetCardDark(this);
                  bVar23 = true;
                }
              }
              else if (local_f8 == 4) {
                if (lVar19 == null) goto LAB_180a5617e;
                if ((*(char *)(lVar19 + 17) == false) || (*(int *)(lVar19 + 20) != 4)) {
                  bVar23 = false;
                  if (lVar20 == null) goto LAB_180a5617e;
                }
                else {
                  DebateUIController.ChangePatient(this);
                  bVar23 = true;
                  if (lVar20 == null) goto LAB_180a5617e;
                  if (*(char *)(lVar20 + 17) != false) {
                    bVar24 = false;
                    if (*(int *)(lVar20 + 20) == 1) {
                      bVar24 = true;
                    }
                  }
                  plVar10 = (int64 *)Resources.Load("Sound/SoundEffect/SpeEffect/治疗");
                  plVar21 = plVar17;
                  if ((plVar10 != (int64 *)0) && (*plVar10 == DAT_181daf360)) {
                    plVar21 = plVar10;
                  }
                  NGUITools.PlaySound(plVar21);
                }
                if ((*(char *)(lVar20 + 17) != false) && (*(int *)(lVar20 + 20) == 4)) {
                  DebateUIController.ChangePatient(this);
                  bVar24 = true;
                  if ((*(char *)(lVar19 + 17) != false) && (*(int *)(lVar19 + 20) == 1)) {
                    bVar23 = true;
                  }
                  plVar10 = (int64 *)Resources.Load("Sound/SoundEffect/SpeEffect/治疗");
                  plVar21 = plVar17;
                  if ((plVar10 != (int64 *)0) && (*plVar10 == DAT_181daf360)) {
                    plVar21 = plVar10;
                  }
                  NGUITools.PlaySound(plVar21);
                }
                goto LAB_180a5490a;
              }
              local_f8 = local_f8 + -1;
            } while (-1 < local_f8);
            if (!bVar1) {
              if (lVar19 == null) goto LAB_180a5617e;
              goto LAB_180a54751;
            }
        LAB_180a5475b:
            if (!bVar23) {
              if (lVar20 == null) goto LAB_180a5617e;
              if (*(char *)(lVar20 + 17) == false) {
                bVar23 = false;
                iVar22 = iVar7;
                if (!bVar1) {
                  if (lVar19 == null) goto LAB_180a5617e;
                  if (*(char *)(lVar19 + 17) == false) goto LAB_180a54ad2;
                }
                goto LAB_180a54ad6;
              }
            }
            fVar4 = local_120;
            if (((this.debateUIPanel == null) ||
                (lVar8 = GameObject.get_transform(this.debateUIPanel,0), fVar4 = local_120,
                lVar8 == null)) ||
               ((lVar8 = Transform.Find(lVar8,"Player",0), fVar4 = local_120, lVar8 == null ||
                (lVar8 = Transform.Find(lVar8,"Result",0), fVar4 = local_120) == null)))
            goto LAB_180a56184;
            uVar16 = Component.GetComponent(lVar8,DAT_181d96178);
            LTLocalization.SetText(uVar16,"",0);
            fVar4 = local_120;
            if ((((this.debateUIPanel == null) ||
                 (lVar8 = GameObject.get_transform(this.debateUIPanel,0), fVar4 = local_120,
                 lVar8 == null)) ||
                (lVar8 = Transform.Find(lVar8,"Enemy",0), fVar4 = local_120) == null) ||
               (lVar8 = Transform.Find(lVar8,"Result",0), fVar4 = local_120) == null)
            goto LAB_180a56184;
            uVar16 = Component.GetComponent(lVar8,DAT_181d96178);
            LTLocalization.SetText(uVar16,"",0);
            lVar8 = local_108;
          }
          if (!this.playerActiveRound) {
            lVar20 = lVar19;
          }
          fVar4 = local_120;
          if (lVar20 == null) goto LAB_180a56184;
          if (*(char *)(lVar20 + 17) == false) {
            if ((**(int **)(DAT_181d73d40 + 184) != 2) && (*(int *)(lVar20 + 24) != -1)) {
              lVar19 = FUN_1807789e0(0);
              if (!this.playerActiveRound) {
                uVar16 = this.playerIcon;
              }
              else {
                uVar16 = this.enemyIcon;
              }
              fVar4 = local_120;
              if (lVar8 != null) {
                uVar6 = FUN_180d96040(0,lVar8.plotHappen,0);
                uVar18 = FUN_180002f80(lVar8,uVar6,DAT_181da4370);
                uVar6 = *(uint32 *)(lVar20 + 24);
                uVar13 = GlobalData.GetBaseAttriName(uVar6,0);
                if (!this.playerActiveRound) {
                  lVar20 = FUN_18046c0a0(0);
                  lVar8 = FUN_18046c0a0(0);
                  fVar4 = local_120;
                  if (((lVar8 == null) || (lVar8.plotPanel == null)) ||
                     (uVar15 = WorldData.Player(lVar8.plotPanel,0), fVar4 = local_120,
                     lVar20 == null)) goto LAB_180a56184;
                  uVar14 = this.enemyData;
                }
                else {
                  lVar20 = FUN_18046c0a0(0);
                  uVar15 = this.enemyData;
                  lVar8 = FUN_18046c0a0(0);
                  fVar4 = local_120;
                  if (((lVar8 == null) || (lVar8.plotPanel == null)) ||
                     (uVar14 = WorldData.Player(lVar8.plotPanel,0), fVar4 = local_120,
                     lVar20 == null)) goto LAB_180a56184;
                }
                uVar15 = GameController.GetHeroName(lVar20,uVar15,uVar14,0);
                uVar18 = String.Format(uVar18,uVar13,uVar15,0);
                fVar4 = local_120;
                if (lVar19 != null) {
                  HeroLittleTalkController.HeroTalk(lVar19,uVar16,uVar18,0x40a00000,0);
                  break;
                }
              }
              goto LAB_180a56184;
            }
          }
          else {
            lVar19 = FUN_1807789e0(0);
            if (!this.playerActiveRound) {
              uVar16 = this.playerIcon;
            }
            else {
              uVar16 = this.enemyIcon;
            }
            lVar8 = DebateCardData.SpeCardTalk;
            fVar4 = local_120;
            if ((lVar8 == null) ||
               (uVar18 = FUN_180002f80(lVar8,*(uint32 *)(lVar20 + 20),DAT_181da4370),
               fVar4 = local_120, lVar19 == null)) goto LAB_180a56184;
            HeroLittleTalkController.HeroTalk(lVar19,uVar16,uVar18,0x40a00000,0);
          }
          break;
        case 5:
          fVar4 = local_120;
          if (((this.debateUIPanel != null) &&
              (lVar20 = GameObject.get_transform(this.debateUIPanel,0), fVar4 = local_120,
              lVar20 != null)) &&
             (lVar20 = Transform.Find(lVar20,"Player",0), fVar4 = local_120) != null) {
            uVar16 = Transform.Find(lVar20,"Result",0);
            plVar17 = (int64 *)Vector3.get_zero(&local_118,0);
            local_120 = *(float *)(plVar17 + 1);
            local_128 = *plVar17;
            ShortcutExtensions.DOScale(uVar16,&local_128);
            fVar4 = local_120;
            if (((this.debateUIPanel != null) &&
                (lVar20 = GameObject.get_transform(this.debateUIPanel,0), fVar4 = local_120,
                lVar20 != null)) &&
               (lVar20 = Transform.Find(lVar20,"Enemy",0), fVar4 = local_120) != null) {
              uVar16 = Transform.Find(lVar20,"Result",0);
              plVar17 = (int64 *)Vector3.get_zero(&local_118,0);
              local_120 = *(float *)(plVar17 + 1);
              local_128 = *plVar17;
              uVar16 = ShortcutExtensions.DOScale(uVar16,&local_128);
              uVar18 = new OnTooltipCB(this,DAT_181da9408,0);
              TweenSettingsExtensions.OnComplete(uVar16,uVar18,DAT_181dc0380);
              if ((this.playerPatient <= 0.0) || (this.enemyPatient <= 0.0)) {
                this.playerWin = this.enemyPatient <= 0.0;
                fVar4 = local_120;
                if ((this.debateUIPanel == null) ||
                   ((lVar20 = GameObject.get_transform(this.debateUIPanel,0),
                    fVar4 = local_120, lVar20 == null ||
                    (lVar20 = Transform.Find(lVar20,"FinalResult",0), fVar4 = local_120) == null)))
                goto LAB_180a56184;
                lVar20 = Component.get_gameObject(lVar20,0);
                fVar4 = local_120;
                if (lVar20 == null) goto LAB_180a56184;
                GameObject.SetActive(lVar20,1,0);
                fVar4 = local_120;
                if (((this.debateUIPanel == null) ||
                    (lVar20 = GameObject.get_transform(this.debateUIPanel,0),
                    fVar4 = local_120, lVar20 == null)) ||
                   (lVar20 = Transform.Find(lVar20,"FinalResult",0), fVar4 = local_120) == null)
                goto LAB_180a56184;
                lVar20 = Component.GetComponent(lVar20,DAT_181d94478);
                if (!this.playerWin) {
                  lVar19 = FUN_18046bb80(0);
                  fVar4 = local_120;
                  if (lVar19 == null) goto LAB_180a56184;
                  uVar16 = *(uint64 *)(lVar19 + 0x278);
                }
                else {
                  lVar19 = FUN_18046bb80(0);
                  fVar4 = local_120;
                  if (lVar19 == null) goto LAB_180a56184;
                  uVar16 = *(uint64 *)(lVar19 + 0x270);
                }
                fVar4 = local_120;
                if (lVar20 == null) goto LAB_180a56184;
                Image.set_sprite(lVar20,uVar16,0);
                fVar4 = local_120;
                if ((this.debateUIPanel == null) ||
                   (lVar20 = GameObject.get_transform(this.debateUIPanel,0), fVar4 = local_120
                   , lVar20 == null)) goto LAB_180a56184;
                lVar20 = Transform.Find(lVar20,"FinalResult",0);
                plVar17 = (int64 *)Vector3.get_one(&local_118,0);
                local_128 = *plVar17;
                local_120 = *(float *)(plVar17 + 1) * 5.0;
                local_108 = CONCAT44((float)((uint64)local_128 >> 32) * 5.0,(float)local_128 * 5.0);
                fVar4 = *(float *)(plVar17 + 1);
                local_100 = local_120;
                if (lVar20 == null) goto LAB_180a56184;
                local_128 = local_108;
                Transform.set_localScale(lVar20,&local_128,0);
                fVar4 = local_120;
                if ((this.debateUIPanel == null) ||
                   (lVar20 = GameObject.get_transform(this.debateUIPanel,0), fVar4 = local_120
                   , lVar20 == null)) goto LAB_180a56184;
                uVar16 = Transform.Find(lVar20,"FinalResult",0);
                uVar16 = ShortcutExtensions.DOScale(uVar16,0x3f800000);
                uVar16 = TweenSettingsExtensions.SetDelay(uVar16,0x3dcccccd,DAT_181dc0e10);
                TweenSettingsExtensions.SetEase(uVar16,9,DAT_181dc1128);
                uVar16 = "FightWin";
                if (!this.playerWin) {
                  uVar16 = "FightLose";
                }
                uVar16 = String.Concat("Sound/SoundEffect/",uVar16,0);
                plVar17 = (int64 *)Resources.Load(uVar16,0);
                plVar10 = (int64 *)0;
                if ((plVar17 != (int64 *)0) && (*plVar17 == DAT_181daf360)) {
                  plVar10 = plVar17;
                }
                NGUITools.PlaySound(plVar10,0);
              }
              else {
                this.lastTopic = this.nowTopic;
                this.nowTopic = 0xffffffff;
                this.playerActiveRound = !this.playerActiveRound;
                this.debateState = 1;
                DebateUIController.ChangeNextDebateTopic(this,0);
                DebateUIController.FullFillCard(this,1,0);
                DebateUIController.FullFillCard(this,0,0);
              }
              lVar20 = DebateUIController.GetOutCardRoot(this,1,0);
              fVar4 = local_120;
              if (lVar20 != null) {
                uVar16 = Component.get_gameObject(lVar20,0);
                GlobalData.DeleteAllChild(uVar16,0);
                lVar20 = DebateUIController.GetOutCardRoot(this,0,0);
                fVar4 = local_120;
                if (lVar20 != null) {
                  uVar16 = Component.get_gameObject(lVar20,0);
                  GlobalData.DeleteAllChild(uVar16,0);
                  if ((0 < this.playerAngryRound) &&
                     (iVar7 = this.playerAngryRound + -1, this.playerAngryRound = iVar7, iVar7 < 1))
                  {
                    DebateUIController.SetCalmDown(this,1,0);
                    lVar20 = FUN_1807789e0(0);
                    fVar4 = local_120;
                    if (lVar20 == null) goto LAB_180a56184;
                    HeroLittleTalkController.HeroTalk
                              (lVar20,this.playerIcon,"总算冷静下来了...",0x40a00000,0);
                  }
                  if ((0 < this.enemyAngryRound) &&
                     (iVar7 = this.enemyAngryRound + -1, this.enemyAngryRound = iVar7, iVar7 < 1))
                  {
                    DebateUIController.SetCalmDown(this,0,0);
                    lVar20 = FUN_1807789e0(0);
                    fVar4 = local_120;
                    if (lVar20 == null) goto LAB_180a56184;
                    HeroLittleTalkController.HeroTalk
                              (lVar20,this.enemyIcon,"总算冷静下来了...",0x40a00000,0);
                  }
                  break;
                }
              }
            }
          }
          goto LAB_180a56184;
        case 6:
          this.waitClick = 1;
          lVar20 = FUN_18046c0a0(0);
          fVar4 = local_120;
          if ((lVar20 != null) && (*(int64 *)(lVar20 + 32) != 0)) {
            lVar20 = WorldData.Player(*(int64 *)(lVar20 + 32),0);
            if (!this.playerWin) {
              fVar26 = 0.5;
            }
            else {
              fVar26 = 1.0;
            }
            fVar4 = local_120;
            if (this.enemyData != null) {
              iVar7 = this.enemyData.heroForceLv;
              fVar25 = (float)Mathf.Max(0x3dcccccd,
                                         (this.playerPatient - this.enemyPatient) / 100.0
                                         + 1.0,0);
              fVar4 = local_120;
              if (lVar20 != null) {
                HeroData.ChangeLivingSkillExp
                          (lVar20,3,((float)iVar7 + 1.0) * fVar26 * 100.0 * fVar25,1,0);
                if (!this.playerWin) {
                  lVar20 = FUN_18046c0a0(0);
                  fVar4 = local_120;
                  if (((lVar20 != null) && (*(int64 *)(lVar20 + 32) != 0)) &&
                     (lVar20 = WorldData.Player(*(int64 *)(lVar20 + 32),0), fVar4 = local_120,
                     lVar20 != null)) {
                    HeroData.AddTag(lVar20,0x156);
                    fVar4 = local_120;
                    if (this.enemyData != null) {
                      HeroData.AddTag(this.enemyData,0x155);
                      break;
                    }
                  }
                }
                else {
                  lVar20 = *(int64 *)(*(int64 *)(DAT_181d72d50 + 184) + 32);
                  fVar4 = local_120;
                  if (lVar20 != null) {
                    GameDataController.ChangeAchStats(lVar20,2);
                    lVar20 = FUN_18046c0a0(0);
                    fVar4 = local_120;
                    if (((lVar20 != null) && (*(int64 *)(lVar20 + 32) != 0)) &&
                       (lVar20 = WorldData.Player(*(int64 *)(lVar20 + 32),0), fVar4 = local_120,
                       lVar20 != null)) {
                      cVar5 = HeroData.HaveForceFunction(lVar20,9);
                      if (!cVar5) {
                        lVar20 = FUN_18046c0a0(0);
                        fVar4 = local_120;
                        if (((lVar20 == null) || (*(int64 *)(lVar20 + 32) == 0)) ||
                           (lVar20 = WorldData.Player(*(int64 *)(lVar20 + 32),0), fVar4 = local_120,
                           lVar20 == null)) goto LAB_180a56184;
                        HeroData.AddTag(lVar20,0x155);
                      }
                      else {
                        lVar20 = FUN_18046c0a0(0);
                        fVar4 = local_120;
                        if ((lVar20 == null) || (*(int64 *)(lVar20 + 32) == 0)) goto LAB_180a56184;
                        lVar20 = WorldData.Player(*(int64 *)(lVar20 + 32),0);
                        fVar4 = local_120;
                        if ((this.enemyData == null) || (lVar20 == null)) goto LAB_180a56184;
                        HeroData.GetDebateSpeBuff
                                  (lVar20,this.enemyData.heroForceLv,0);
                      }
                      fVar4 = local_120;
                      if (this.enemyData != null) {
                        HeroData.AddTag(this.enemyData,0x156);
                        break;
                      }
                    }
                  }
                }
              }
            }
          }
        LAB_180a56184:
          local_120 = fVar4;
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        case 7:
          DebateUIController.HideDebateUI(this,0);
        }
        DebateUIController.RefreshNowTopic(this,0);
        DebateUIController.RefreshAllButtonState(this,0);
    }

    // Token : 0x6001394
    // RVA   : 0xA567B0   Offset: 0xA55BB0   Length: 0x1FD
    public void RefreshNowTopic()
    {
        bool cVar1;
        int iVar2;
        long lVar3;
        ulong uVar5;
        ulong uVar6;
        int iVar7;
        byte[] local_28 = new byte[16];
        byte[] local_18 = new byte[16];
        lVar3 = this.debateUIPanel;
        iVar7 = 0;
        if (lVar3 != null) {
          while ((lVar3 = GameObject.get_transform(lVar3,0), lVar3 != null &&
                 (lVar3 = Transform.Find(lVar3,"Topic",0)) != null)) {
            iVar2 = Transform.get_childCount(lVar3,0);
            if (iVar2 <= iVar7) {
              return;
            }
            if ((((this.debateUIPanel == null) ||
                 (lVar3 = GameObject.get_transform(this.debateUIPanel,0)) == null) ||
                (lVar3 = Transform.Find(lVar3,"Topic",0)) == null) ||
               ((lVar3 = Transform.GetChild(lVar3,iVar7,0), lVar3 == null ||
                (lVar3 = Transform.Find(lVar3,"HighLight",0)) == null))) break;
            plVar4 = (int64 *)Component.GetComponent(lVar3,DAT_181d94478);
            if (((this.debateUIPanel == null) ||
                ((lVar3 = GameObject.get_transform(this.debateUIPanel,0), lVar3 == null ||
                 (lVar3 = Transform.Find(lVar3,"Topic",0)) == null))) ||
               (lVar3 = Transform.GetChild(lVar3,iVar7,0)) == null) break;
            uVar5 = Object.get_name(lVar3,0);
            uVar6 = Int32.ToString(this + 112,0);
            cVar1 = FUN_18171eb50(uVar5,uVar6,0);
            if (!cVar1) {
              FUN_180d995f0(local_18,0);
            }
            else {
              FUN_1810d3b80(local_28);
            }
            if (plVar4 == (int64 *)0) break;
            (**(code **)(*plVar4 + 0x2a8))(plVar4);
            lVar3 = this.debateUIPanel;
            iVar7 = iVar7 + 1;
            if (lVar3 == null) break;
          }
        }
    }

    // Token : 0x6001395
    // RVA   : 0xA513A0   Offset: 0xA507A0   Length: 0x18D
    public void DeleteCard(Transform targetCard)
    {
        long lVar1;
        ulong uVar3;
        ulong uVar4;
        long lVar5;
        ulong local_28;
        uint local_20;
        byte[] local_18 = new byte[16];
        lVar1 = new c.DisplayClass9_0(0);
        if (lVar1 != null) {
          *(uint64 *)(lVar1 + 16) = targetCard;
          ShortcutExtensions.DOScale(*(uint64 *)(lVar1 + 16),0,0x3f000000,0);
          uVar3 = *(uint64 *)(lVar1 + 16);
          puVar2 = (uint64 *)Vector3.get_zero(local_18,0);
          local_28 = *puVar2;
          local_20 = *(uint32 *)(puVar2 + 1);
          uVar3 = ShortcutExtensions.DOMove(uVar3,&local_28,0x3f000000,0,0);
          uVar4 = new OnTooltipCB(lVar1,DAT_181d9ffc0,0);
          TweenSettingsExtensions.OnComplete(uVar3,uVar4,DAT_181dc0380);
          lVar1 = *(int64 *)(lVar1 + 16);
          if (this.debateUIPanel != null) {
            lVar5 = GameObject.get_transform(this.debateUIPanel,0);
            if (lVar5 != null) {
              uVar3 = Transform.Find(lVar5,"DeleteCard",0);
              if (lVar1 != null) {
                FUN_180daae30(lVar1,uVar3,0);
                return;
              }
            }
          }
        }
    }

    // Token : 0x6001396
    // RVA   : 0xA50D30   Offset: 0xA50130   Length: 0x407
    public void ChangeNextDebateTopic()
    {
        bool cVar1;
        int iVar2;
        long lVar3;
        ulong uVar4;
        long lVar5;
        int iVar6;
        int iVar7;
        if (this.lastTopic == -1) {
          return;
        }
        iVar7 = 0;
        iVar6 = 0;
        do {
          bVar8 = iVar6 == 0;
          lVar3 = DebateUIController.GetObjRoot(this,bVar8,0);
          if ((lVar3 == null) || (lVar3 = Transform.Find(lVar3,"Card")) == null)
          throw; // [null/range check failed]
          iVar2 = Transform.get_childCount(lVar3,0);
          while (iVar2 = iVar2 + -1, -1 < iVar2) {
            lVar3 = DebateUIController.GetObjRoot(this,bVar8,0);
            if ((((lVar3 == null) || (lVar3 = Transform.Find(lVar3,"Card")) == null) ||
                (lVar3 = Transform.GetChild(lVar3,iVar2)) == null) ||
               ((lVar3 = Component.GetComponent(lVar3,DAT_181d93cf8), lVar3 == null ||
                (*(int64 *)(lVar3 + 24) == 0)))) throw; // [null/range check failed]
            if (*(int *)(*(int64 *)(lVar3 + 24) + 24) == this.lastTopic) {
              lVar3 = DebateUIController.GetObjRoot(this,bVar8,0);
              if ((lVar3 == null) || (lVar3 = Transform.Find(lVar3,"Card")) == null)
              throw; // [null/range check failed]
              uVar4 = Transform.GetChild(lVar3,iVar2);
              DebateUIController.DeleteCard(this,uVar4);
            }
          }
          iVar6 = iVar6 + 1;
        } while (iVar6 < 2);
        if (this.debateTopics != null) {
          FUN_1817ef410(this.debateTopics,this.lastTopic,DAT_181d7e858);
          if (this.debateTopics != null) {
            FUN_18182a6c0(this.debateTopics,this.nextDebateTopic,DAT_181d7e660);
            lVar3 = this.debateUIPanel;
            if (lVar3 != null) {
              while( true ) {
                lVar3 = GameObject.get_transform(lVar3,0);
                if ((lVar3 == null) || (lVar3 = Transform.Find(lVar3,"Topic",0)) == null)
                throw; // [null/range check failed]
                iVar6 = Transform.get_childCount(lVar3,0);
                if (iVar6 <= iVar7) break;
                if ((((this.debateUIPanel == null) ||
                     (lVar3 = GameObject.get_transform(this.debateUIPanel,0)) == null) ||
                    (lVar3 = Transform.Find(lVar3,"Topic",0)) == null) ||
                   (lVar3 = Transform.GetChild(lVar3,iVar7)) == null) throw; // [null/range check failed]
                uVar4 = Object.get_name(lVar3,0);
                Int32.ToString(this + 108,0);
                cVar1 = FUN_18171eb50(uVar4);
                lVar3 = this.debateUIPanel;
                if (cVar1) {
                  if (((lVar3 != null) && (lVar3 = GameObject.get_transform(lVar3,0)) != null) &&
                     ((lVar3 = Transform.Find(lVar3,"Topic",0), lVar3 != null &&
                      (lVar3 = Transform.GetChild(lVar3,iVar7,0)) != null))) {
                    uVar4 = Component.get_gameObject(lVar3,0);
                    Object.Destroy(uVar4,0);
                    break;
                  }
                  throw; // [null/range check failed]
                }
                iVar7 = iVar7 + 1;
                if (lVar3 == null) throw; // [null/range check failed]
              }
              if (((this.debateUIPanel != null) &&
                  (lVar3 = GameObject.get_transform(this.debateUIPanel,0)) != null) &&
                 (lVar3 = Transform.Find(lVar3,"NextTopic",0)) != null) {
                lVar3 = Transform.GetChild(lVar3,0,0);
                if (((this.debateUIPanel != null) &&
                    (lVar5 = GameObject.get_transform(this.debateUIPanel,0)) != null) &&
                   (uVar4 = Transform.Find(lVar5,"Topic",0), lVar3 != null)) {
                  FUN_180daae30(lVar3,uVar4,0);
                  DebateUIController.GenerateNextTopic(this,0);
                  return;
                }
              }
            }
          }
        }
    }

    // Token : 0x6001397
    // RVA   : 0xA51E70   Offset: 0xA51270   Length: 0x32C
    public void GenerateNextTopic()
    {
        bool cVar1;
        uint uVar2;
        long lVar3;
        ulong uVar4;
        long lVar5;
        ulong uVar6;
        int iVar7;
        uint[] local_res18 = new uint[2];
        local_res18[0] = 0;
        lVar3 = il2cpp_internal(DAT_181d91378);
        FUN_181330100(lVar3,DAT_181d7e5e0);
        iVar7 = 15;
        while( true ) {
          uVar4 = DAT_181db47e8;
          uVar4 = Type.GetTypeFromHandle(uVar4,0);
          lVar5 = Enum.GetNames(uVar4,0);
          if (lVar5 == null) throw; // [null/range check failed]
          if (*(int *)(lVar5 + 24) <= iVar7) break;
          if (this.debateTopics == null) throw; // [null/range check failed]
          cVar1 = FUN_18182a9b0();
          if (!cVar1) {
            if (lVar3 == null) throw; // [null/range check failed]
            FUN_18182a6c0(lVar3);
          }
          iVar7 = iVar7 + 1;
        }
        if (lVar3 != null) {
          uVar2 = FUN_180d96040(0,*(uint32 *)(lVar3 + 24),0);
          if (*(uint32 *)(lVar3 + 24) <= uVar2) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          this.nextDebateTopic =
               lVar3[uVar2];
          if (this.debateUIPanel != null) {
            lVar3 = GameObject.get_transform(this.debateUIPanel,0);
            if (lVar3 != null) {
              lVar3 = Transform.Find(lVar3,"NextTopic",0);
              if (lVar3 != null) {
                uVar6 = Component.get_gameObject(lVar3,0);
                uVar4 = this.debateTopicPrefab;
                uVar4 = GlobalData.AddChild(uVar6,uVar4,0);
                this.temp = uVar4;
                local_res18[0] = this.nextDebateTopic;
                lVar3 = this.temp;
                uVar4 = Int32.ToString(local_res18,0);
                if (lVar3 != null) {
                  Object.set_name(lVar3,uVar4,0);
                  if (this.temp != null) {
                    lVar3 = GameObject.get_transform(this.temp,0);
                    if (lVar3 != null) {
                      lVar3 = Transform.Find(lVar3,"Text",0);
                      if (lVar3 != null) {
                        uVar4 = Component.GetComponent(lVar3,DAT_181d96178);
                        uVar6 = GlobalData.GetBaseAttriName(this.nextDebateTopic,0);
                        LTLocalization.SetText(uVar4,uVar6,0);
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

    // Token : 0x6001398
    // RVA   : 0xA56DC0   Offset: 0xA561C0   Length: 0xF7
    public void SetCalmDown(bool isPlayer)
    {
        long lVar1;
        ulong uVar2;
        lVar1 = DebateUIController.GetObjRoot(this,isPlayer,0);
        if (lVar1 != null) {
          lVar1 = Transform.Find(lVar1,"Angry",0);
          if (lVar1 != null) {
            lVar1 = Component.get_gameObject(lVar1,0);
            if (lVar1 != null) {
              GameObject.SetActive(lVar1,0,0);
              lVar1 = DebateUIController.GetObjRoot(this,isPlayer,0);
              if (lVar1 != null) {
                lVar1 = Transform.Find(lVar1,"Angry",0);
                if (lVar1 != null) {
                  uVar2 = Component.get_gameObject(lVar1,0);
                  DOTween.Kill(uVar2,0,0);
                  return;
                }
              }
            }
          }
        }
    }

    // Token : 0x6001399
    // RVA   : 0xA51380   Offset: 0xA50780   Length: 0x18
    public void DebateUIBackClicked()
    {
        void FUN_180a51380(int64 this)
        {
        if (this.waitClick) {
          this.waitClick = 0;
          DebateUIController.NextDebateRound(this,0);
          return;
        }
    }

    // Token : 0x600139A
    // RVA   : 0xA53070   Offset: 0xA52470   Length: 0xA
    public void GiveUpButtonClicked()
    {
        void FUN_180a53070(uint64 this)
        {
        DebateUIController.UseDebateCard(this,0,0);
    }

    // Token : 0x600139B
    // RVA   : 0xA565E0   Offset: 0xA559E0   Length: 0x1C0
    public void RefreshCardButtonClicked()
    {
        int iVar1;
        long lVar2;
        DebateUIController.ChangePatient(this,1,0xc1a00000,0);
        bVar3 = !DAT_181e9d9a2;
        this.debateState = 4;
        if (bVar3) {
          il2cpp_internal(&"Enemy");
          il2cpp_internal(&"Player");
          DAT_181e9d9a2 = true;
        }
        if ((((this.debateUIPanel != null) &&
             (lVar2 = GameObject.get_transform(this.debateUIPanel,0)) != null) &&
            (lVar2 = Transform.Find(lVar2,"Player",0)) != null) &&
           (lVar2 = Transform.Find(lVar2,"Card",0)) != null) {
          iVar1 = Transform.get_childCount(lVar2,0);
          while( true ) {
            iVar1 = iVar1 + -1;
            if (iVar1 < 0) {
              this.cardUsed = 1;
              DebateUIController.RefreshAllButtonState(this,0);
              DebateUIController.FullFillCard(this,1,0);
              MonoBehaviour.Invoke(this,"NextDebateRound",0x3f19999a,0);
              return;
            }
            if (((this.debateUIPanel == null) ||
                (lVar2 = GameObject.get_transform(this.debateUIPanel,0)) == null) ||
               ((lVar2 = Transform.Find(lVar2,"Player",0), lVar2 == null ||
                (lVar2 = Transform.Find(lVar2,"Card",0)) == null))) break;
            Transform.GetChild(lVar2,iVar1);
            DebateUIController.DeleteCard(this);
          }
        }
    }

    // Token : 0x600139C
    // RVA   : 0xA561B0   Offset: 0xA555B0   Length: 0x17
    public bool NotAngry(bool isPlayer)
    {
        bool FUN_180a561b0(int64 this,char isPlayer)
        {
        if (isPlayer) {
          return this.playerAngryRound < 1;
        }
        return this.enemyAngryRound < 1;
    }

    // Token : 0x600139D
    // RVA   : 0xA50CC0   Offset: 0xA500C0   Length: 0x63
    public bool CardCanUse(DebateCardData cardData)
    {
        int iVar1;
        if (cardData == null) {
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
        if (*(char *)(cardData + 16) == false) {
          iVar1 = this.enemyAngryRound;
        }
        else {
          iVar1 = this.playerAngryRound;
        }
        if (iVar1 < 1) {
          if (*(char *)(cardData + 17) == false) {
            if ((this.lastTopic != -1) && (*(int *)(cardData + 24) == this.lastTopic)
               ) {
              return false;
            }
            if (this.nowTopic != -1) {
              return *(int *)(cardData + 24) == this.nowTopic;
            }
          }
        }
        else if ((*(char *)(cardData + 17) == false) || (*(int *)(cardData + 20) != 4)) {
          return false;
        }
        return true;
    }

    // Token : 0x600139E
    // RVA   : 0xA57AE0   Offset: 0xA56EE0   Length: 0x826
    public void UseDebateCard(GameObject targetCard)
    {
        var pStatics = *(int64*)(DAT_181d761e8 + 184);
        uint uVar2;
        int iVar3;
        bool cVar4;
        uint uVar5;
        long lVar6;
        ulong uVar7;
        ulong uVar9;
        ulong uVar10;
        long lVar11;
        long lVar12;
        ulong uVar13;
        ulong uVar14;
        ulong local_48;
        uint local_40;
        byte[] local_38 = new byte[16];
        cVar4 = Object.op_Equality(targetCard,0,0);
        if (!cVar4) {
          if ((((targetCard == null) || (lVar6 = GameObject.get_transform(targetCard,0)) == null) ||
              (lVar6 = Transform.Find(lVar6,"Back",0)) == null) ||
             (lVar6 = Component.GetComponent(lVar6,DAT_181d93778)) == null) goto LAB_180a58301;
          Selectable.set_interactable(lVar6,0,0);
          lVar6 = GameObject.GetComponent(targetCard,DAT_181dc8278);
          if (lVar6 == null) goto LAB_180a58301;
          lVar11 = *(int64 *)(lVar6 + 24);
          if (this.nowTopic == -1) {
            if (lVar11 == null) goto LAB_180a58301;
            this.nowTopic = *(uint32 *)(lVar11 + 24);
            lVar6 = GameObject.get_transform(targetCard,0);
          }
          else {
            lVar6 = GameObject.get_transform(targetCard,0);
            if (lVar11 == null) goto LAB_180a58301;
          }
          uVar7 = DebateUIController.GetOutCardRoot(this,*(uint8 *)(lVar11 + 16),0);
          if (lVar6 == null) goto LAB_180a58301;
          FUN_180daae30(lVar6,uVar7,0);
          uVar7 = GameObject.get_transform(targetCard,0);
          ShortcutExtensions.DOScale(uVar7,0x3f800000,0x3f000000,0);
          uVar7 = GameObject.get_transform(targetCard,0);
          puVar8 = (uint64 *)Vector3.get_zero(local_38,0);
          local_40 = *(uint32 *)(puVar8 + 1);
          local_48 = *puVar8;
          uVar7 = ShortcutExtensions.DOLocalMove(uVar7,&local_48,0x3f000000,0,0);
          uVar9 = new OnTooltipCB(this,DAT_181da9408,0);
          TweenSettingsExtensions.OnComplete(uVar7,uVar9,DAT_181dc0380);
          if (this.debateState != 2) goto LAB_180a582c3;
          if (*(char *)(lVar11 + 17) == false) {
            if (**(int **)(DAT_181d73d40 + 184) == 2) goto LAB_180a582c3;
            lVar6 = *pStatics;
            if (*(char *)(lVar11 + 16) == false) {
              uVar7 = this.enemyIcon;
            }
            else {
              uVar7 = this.playerIcon;
            }
            lVar12 = PlotController.attriIndexCache;
            if (lVar12 == null) goto LAB_180a58301;
            uVar5 = FUN_180d96040(0,*(uint32 *)(lVar12 + 24),0);
            uVar9 = FUN_180002f80(lVar12,uVar5,DAT_181da4370);
            uVar5 = *(uint32 *)(lVar11 + 24);
            uVar10 = GlobalData.GetBaseAttriName(uVar5,0);
            if (*(char *)(lVar11 + 16) == false) {
              lVar11 = FUN_18046c0a0(0);
              uVar13 = this.enemyData;
              lVar12 = FUN_18046c0a0(0);
              if (((lVar12 == null) || (*(int64 *)(lVar12 + 32) == 0)) ||
                 (uVar14 = WorldData.Player(*(int64 *)(lVar12 + 32),0), lVar11 == null))
              goto LAB_180a58301;
            }
            else {
              lVar11 = FUN_18046c0a0(0);
              lVar12 = FUN_18046c0a0(0);
              if (((lVar12 == null) || (*(int64 *)(lVar12 + 32) == 0)) ||
                 (uVar13 = WorldData.Player(*(int64 *)(lVar12 + 32),0), lVar11 == null))
              goto LAB_180a58301;
              uVar14 = this.enemyData;
            }
            uVar13 = GameController.GetHeroName(lVar11,uVar13,uVar14,0);
            uVar9 = String.Format(uVar9,uVar10,uVar13,0);
            goto joined_r0x000180a582ac;
          }
          lVar6 = *pStatics;
          if (*(char *)(lVar11 + 16) == false) {
            uVar7 = this.enemyIcon;
          }
          else {
            uVar7 = this.playerIcon;
          }
          lVar12 = *(int64 *)(*(int64 *)(DAT_181dbfbd0 + 184) + 16);
          if (lVar12 == null) goto LAB_180a58301;
          uVar2 = *(uint32 *)(lVar11 + 20);
          if (*(uint32 *)(lVar12 + 24) <= uVar2) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          if (lVar6 == null) goto LAB_180a58301;
          uVar9 = lVar12[uVar2];
        }
        else {
          if (!this.playerActiveRound) {
            bVar15 = this.debateState == 3;
          }
          else {
            bVar15 = this.debateState == 2;
          }
          lVar6 = DebateUIController.GetOutCardRoot(this,bVar15,0);
          if (lVar6 == null) goto LAB_180a58301;
          uVar9 = Component.get_gameObject(lVar6,0);
          uVar7 = this.debateCardPrefab;
          lVar6 = GlobalData.AddChild(uVar9,uVar7,0);
          this.temp = lVar6;
          if (*plVar1 == 0) goto LAB_180a58301;
          lVar6 = GameObject.get_transform(*plVar1,0);
          puVar8 = (uint64 *)Vector3.get_zero(local_38,0);
          if (lVar6 == null) goto LAB_180a58301;
          local_40 = *(uint32 *)(puVar8 + 1);
          local_48 = *puVar8;
          Transform.set_localScale(lVar6,&local_48,0);
          if (*plVar1 == 0) goto LAB_180a58301;
          uVar7 = GameObject.get_transform(*plVar1,0);
          puVar8 = (uint64 *)Vector3.get_one(local_38,0);
          local_40 = *(uint32 *)(puVar8 + 1);
          local_48 = *puVar8;
          uVar7 = ShortcutExtensions.DOScale(uVar7,&local_48,0x3f000000,0);
          uVar9 = new OnTooltipCB(this,DAT_181da9408,0);
          TweenSettingsExtensions.OnComplete(uVar7,uVar9,DAT_181dc0380);
          if (*plVar1 == 0) goto LAB_180a58301;
          lVar6 = GameObject.GetComponent(*plVar1,DAT_181dc8278);
          if (!this.playerActiveRound) {
            bVar15 = this.debateState == 3;
          }
          else {
            bVar15 = this.debateState == 2;
          }
          lVar11 = new ZhSegment(0);
          *(bool *)(lVar11 + 16) = bVar15;
          *(uint8 *)(lVar11 + 17) = 0;
          *(uint32 *)(lVar11 + 20) = 0;
          *(uint32 *)(lVar11 + 24) = 0xffffffff;
          *(uint32 *)(lVar11 + 28) = 0;
          if (lVar6 == null) goto LAB_180a58301;
          *(int64 *)(lVar6 + 24) = lVar11;
          if ((*plVar1 == 0) || (lVar6 = GameObject.GetComponent(*plVar1,DAT_181dc8278)) == null)
          goto LAB_180a58301;
          DebateCardController.Init(lVar6,0);
          iVar3 = this.debateState;
          lVar6 = *pStatics;
          if (!this.playerActiveRound) {
            if (iVar3 == 3) goto LAB_180a58291;
        LAB_180a5826d:
            uVar7 = this.enemyIcon;
          }
          else {
            if (iVar3 != 2) goto LAB_180a5826d;
        LAB_180a58291:
            uVar7 = this.playerIcon;
          }
          if (!this.playerActiveRound) {
            if (iVar3 == 3) goto LAB_180a5829c;
        LAB_180a5827a:
            iVar3 = this.enemyAngryRound;
          }
          else {
            if (iVar3 != 2) goto LAB_180a5827a;
        LAB_180a5829c:
            iVar3 = this.playerAngryRound;
          }
          uVar9 = "怒不可遏！";
          if (iVar3 < 1) {
            uVar9 = "我竟无言以对...";
          }
        joined_r0x000180a582ac:
          if (lVar6 == null) {
        LAB_180a58301:
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
        }
        HeroLittleTalkController.HeroTalk(lVar6,uVar7,uVar9,0x40a00000,0);
        LAB_180a582c3:
        this.cardUsed = 1;
        DebateUIController.RefreshAllButtonState(this,0);
    }

    // Token : 0x600139F
    // RVA   : 0xA56400   Offset: 0xA55800   Length: 0x100
    public void RefreshAllButtonState()
    {
        bool cVar1;
        long lVar2;
        bVar3 = false;
        if (!this.cardUsed) {
          cVar1 = this.playerActiveRound;
          if (!cVar1) {
            if (this.debateState == 3) goto LAB_180a5644a;
          }
          else if (this.debateState == 2) goto LAB_180a5644a;
        }
        cVar1 = false;
        LAB_180a5644a:
        if (this.refreshCardButton != null) {
          GameObject.SetActive(this.refreshCardButton,cVar1,0);
          if ((this.refreshCardButton != null) &&
             (lVar2 = GameObject.GetComponent(this.refreshCardButton,DAT_181dc7c18)) != null)
          {
            Selectable.set_interactable(lVar2,20.0 <= this.playerPatient,0);
            if (!this.cardUsed) {
              if (!this.playerActiveRound) {
                bVar3 = this.debateState == 3;
              }
              else {
                bVar3 = this.debateState == 2;
              }
            }
            if (this.giveUpButton != null) {
              GameObject.SetActive(this.giveUpButton,bVar3,0);
              DebateUIController.RefreshAllCardButtonState(this,1,0);
              DebateUIController.RefreshAllCardButtonState(this,0,0);
              return;
            }
          }
        }
    }

    // Token : 0x60013A0
    // RVA   : 0xA536C0   Offset: 0xA52AC0   Length: 0x16
    public bool IsPlayerRound()
    {
        bool FUN_180a536c0(int64 this)
        {
        if (this.playerActiveRound) {
          return this.debateState == 2;
        }
        return this.debateState == 3;
    }

    // Token : 0x60013A1
    // RVA   : 0xA52E20   Offset: 0xA52220   Length: 0x9F
    public Transform GetObjRoot(bool isPlayer)
    {
        long lVar1;
        lVar1 = this.debateUIPanel;
        if (!isPlayer) {
          if (lVar1 != null) {
            lVar1 = GameObject.get_transform(lVar1,0);
            if (lVar1 != null) {
              Transform.Find(lVar1,"Enemy",0);
              return;
            }
          }
        }
        else if (lVar1 != null) {
          lVar1 = GameObject.get_transform(lVar1,0);
          if (lVar1 != null) {
            Transform.Find(lVar1,"Player",0);
            return;
          }
        }
    }

    // Token : 0x60013A2
    // RVA   : 0xA51140   Offset: 0xA50540   Length: 0x232
    public void ChangePatient(bool isPlayer, float num)
    {
        ulong uVar1;
        uint uVar2;
        long lVar3;
        ulong uVar4;
        long lVar5;
        ulong local_48;
        uint local_40;
        uint local_38;
        uint uStack_34;
        uint uStack_30;
        uint32 uStack_2c;
        if (!isPlayer) {
          this.enemyPatient = num + this.enemyPatient;
        }
        else {
          this.playerPatient = num + this.playerPatient;
        }
        lVar3 = GameController._instance;
        uVar4 = GlobalData.GenerateChangeColorText("",num,0);
        lVar5 = DebateUIController.GetObjRoot(this,isPlayer,0);
        if (lVar5 != null) {
          lVar5 = Transform.Find(lVar5,"Patient",0);
          if (lVar5 != null) {
            lVar5 = Transform.Find(lVar5,"Text",0);
            if (lVar5 != null) {
              puVar6 = (uint64 *)Transform.get_position(&local_48,lVar5,0);
              uVar1 = *puVar6;
              uVar2 = *(uint32 *)(puVar6 + 1);
              if (num <= 0.0) {
                puVar7 = (uint32 *)Color.get_red(&local_38,0);
              }
              else {
                puVar7 = (uint32 *)Color.get_green();
              }
              local_38 = *puVar7;
              uStack_34 = puVar7[1];
              uStack_30 = puVar7[2];
              uStack_2c = puVar7[3];
              if (lVar3 != null) {
                local_48 = uVar1;
                local_40 = uVar2;
                GameController.ShowTextAtPos(lVar3,uVar4,&local_48,30,&local_38,0);
                DebateUIController.RefreshPatientUI(this,0);
                return;
              }
            }
          }
        }
    }

    // Token : 0x60013A3
    // RVA   : 0xA569B0   Offset: 0xA55DB0   Length: 0x405
    public void RefreshPatientUI()
    {
        ulong uVar1;
        ulong uVar2;
        long lVar3;
        uint[] local_res18 = new uint[4];
        if (this.debateUIPanel != null) {
          lVar3 = GameObject.get_transform(this.debateUIPanel,0);
          if (lVar3 != null) {
            lVar3 = Transform.Find(lVar3,"Player",0);
            if (lVar3 != null) {
              lVar3 = Transform.Find(lVar3,"Patient",0);
              if (lVar3 != null) {
                lVar3 = Transform.Find(lVar3,"Text",0);
                if (lVar3 != null) {
                  uVar1 = Component.GetComponent(lVar3,DAT_181d96178);
                  local_res18[0] = Mathf.CeilToInt(this.playerPatient,0);
                  uVar2 = Int32.ToString(local_res18,0);
                  LTLocalization.SetText(uVar1,uVar2,0);
                  if (this.debateUIPanel != null) {
                    lVar3 = GameObject.get_transform(this.debateUIPanel,0);
                    if (lVar3 != null) {
                      lVar3 = Transform.Find(lVar3,"Player",0);
                      if (lVar3 != null) {
                        lVar3 = Transform.Find(lVar3,"Patient",0);
                        if (lVar3 != null) {
                          lVar3 = Transform.Find(lVar3,"BarBack",0);
                          if (lVar3 != null) {
                            lVar3 = Transform.Find(lVar3,"Bar",0);
                            if (lVar3 != null) {
                              lVar3 = Component.GetComponent(lVar3,DAT_181d94478);
                              if (lVar3 != null) {
                                Image.set_fillAmount
                                          (lVar3,this.playerPatient / this.playerMaxPatient,0
                                          );
                                if (this.debateUIPanel != null) {
                                  lVar3 = GameObject.get_transform(this.debateUIPanel,0);
                                  if (lVar3 != null) {
                                    lVar3 = Transform.Find(lVar3,"Enemy",0);
                                    if (lVar3 != null) {
                                      lVar3 = Transform.Find(lVar3,"Patient",0);
                                      if (lVar3 != null) {
                                        lVar3 = Transform.Find(lVar3,"Text",0);
                                        if (lVar3 != null) {
                                          uVar1 = Component.GetComponent(lVar3,DAT_181d96178);
                                          local_res18[0] =
                                               Mathf.CeilToInt(this.enemyPatient,0);
                                          uVar2 = Int32.ToString(local_res18,0);
                                          LTLocalization.SetText(uVar1,uVar2,0);
                                          if (this.debateUIPanel != null) {
                                            lVar3 = GameObject.get_transform
                                                              (this.debateUIPanel,0);
                                            if (lVar3 != null) {
                                              lVar3 = Transform.Find(lVar3,"Enemy",0);
                                              if (lVar3 != null) {
                                                lVar3 = Transform.Find(lVar3,"Patient",0);
                                                if (lVar3 != null) {
                                                  lVar3 = Transform.Find(lVar3,"BarBack",0);
                                                  if (lVar3 != null) {
                                                    lVar3 = Transform.Find(lVar3,"Bar",0);
                                                    if (lVar3 != null) {
                                                      lVar3 = Component.GetComponent(lVar3,DAT_181d94478)
                                                      ;
                                                      if (lVar3 != null) {
                                                        Image.set_fillAmount
                                                                  (lVar3,this.enemyPatient /
                                                                         this.enemyMaxPatient,0);
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
              }
            }
          }
        }
    }

    // Token : 0x60013A4
    // RVA   : 0xA56510   Offset: 0xA55910   Length: 0xC9
    public void RefreshAllCardButtonState(bool isPlayer)
    {
        int iVar1;
        long lVar2;
        long lVar3;
        int iVar4;
        lVar2 = DebateUIController.GetObjRoot(this,isPlayer,0);
        if (lVar2 != null) {
          lVar2 = Transform.Find(lVar2,"Card",0);
          iVar4 = 0;
          if (lVar2 != null) {
            while( true ) {
              iVar1 = Transform.get_childCount(lVar2,0);
              if (iVar1 <= iVar4) {
                return;
              }
              lVar3 = Transform.GetChild(lVar2,iVar4,0);
              if (lVar3 == null) break;
              lVar3 = Component.GetComponent(lVar3);
              if (lVar3 == null) break;
              DebateCardController.RefreshButtonState(lVar3);
              iVar4 = iVar4 + 1;
            }
          }
        }
    }

    // Token : 0x60013A5
    // RVA   : 0xA52D80   Offset: 0xA52180   Length: 0x97
    public int GetMaxCardNum(HeroData targetHero)
    {
        float fVar1;
        long lVar2;
        bool cVar3;
        if ((targetHero != null) && (lVar2 = *(int64 *)(targetHero + 0x168)) != null) {
          if (*(uint32 *)(lVar2 + 24) < 4) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          fVar1 = *(float *)(*(int64 *)(lVar2 + 16) + 44);
          cVar3 = HeroData.HaveForceFunction(targetHero,9);
          return (int)(fVar1 * 0.05 + 5.0) + (-(uint32)(cVar3) & 3);
        }
    }

    // Token : 0x60013A6
    // RVA   : 0xA51530   Offset: 0xA50930   Length: 0x93D
    public void FullFillCard(bool isPlayer)
    {
        bool cVar2;
        int iVar3;
        uint uVar4;
        long lVar5;
        long lVar6;
        ulong uVar7;
        long lVar8;
        long lVar9;
        ulong uVar11;
        int iVar12;
        float fVar13;
        float fVar14;
        int local_res20;
        uint local_108;
        uint local_104;
        uint local_100;
        ulong local_f8;
        uint local_f0;
        ulong local_e8;
        uint local_e0;
        byte[] local_d8 = new byte[16];
        byte[] local_c8 = new byte[144];
        iVar12 = 0;
        local_108 = 0;
        lVar5 = DebateUIController.GetObjRoot(this,isPlayer);
        if (lVar5 != null) {
          lVar5 = Transform.Find(lVar5,"Card");
          if (!isPlayer) {
            lVar6 = this.enemyData;
          }
          else {
            if ((GameController._instance == null) ||
               (lVar6 = GameController._instance.worldData) == null)
            throw; // [null/range check failed]
            lVar6 = WorldData.Player(lVar6,0);
          }
          local_res20 = 0;
          if (lVar5 != null) {
            while( true ) {
              iVar3 = Transform.get_childCount(lVar5,0);
              if ((lVar6 == null) || (lVar8 = lVar6.totalLivingSkill) == null) break;
              if (lVar8.Count < 4) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              fVar13 = *(float *)(lVar8._items + 44);
              cVar2 = HeroData.HaveForceFunction(lVar6,9);
              if ((int)((int)(fVar13 * 0.05 + 5.0) + (-(uint32)(cVar2) & 3)) <= iVar3)
              goto LAB_180a51ba6;
              uVar7 = Component.get_gameObject(lVar5,0);
              uVar11 = this.debateCardPrefab;
              lVar8 = GlobalData.AddChild(uVar7,uVar11,0);
              this.temp = lVar8;
              fVar13 = (float)Random.get_value(0);
              lVar8 = lVar6.totalLivingSkill;
              if (lVar8 == null) break;
              if (lVar8.Count < 3) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              if (fVar13 < *(float *)(lVar8._items + 40) * 0.001 + 0.05) {
                if (*plVar1 == 0) break;
                lVar8 = GameObject.GetComponent(*plVar1,DAT_181dc8278);
                if (DebateCardData.SpeCardName == null) break;
                lVar9 = lVar6.totalLivingSkill;
                uVar4 = DebateCardData.SpeCardName.targetAttriID;
                if (lVar9 == null) break;
                if (*(uint32 *)(lVar9 + 24) < 4) {
                  ThrowHelper.ThrowArgumentOutOfRangeException(0);
                }
                uVar4 = Mathf.Min(uVar4,1 - (int)(*(float *)(*(int64 *)(lVar9 + 16) + 44) * -0.05)
                                   ,0);
                uVar4 = FUN_180d96040(0,uVar4,0);
                lVar9 = new ZhSegment(0);
                *(char *)(lVar9 + 16) = isPlayer;
                *(uint8 *)(lVar9 + 17) = 1;
                *(uint32 *)(lVar9 + 20) = uVar4;
                *(uint64 *)(lVar9 + 24) = 0xffffffffffffffff;
              }
              else {
                if (lVar6.totalLivingSkill == null) break;
                if (*(uint32 *)(lVar6.totalLivingSkill + 24) < 3) {
                  ThrowHelper.ThrowArgumentOutOfRangeException(0);
                }
                iVar3 = DebateUIController.RandomCardRareLv(this);
                lVar8 = this.debateTopics;
                if (lVar8 == null) break;
                uVar4 = FUN_180d96040(0,lVar8.Count,0);
                uVar4 = FUN_1800d6760(lVar8,uVar4,DAT_181d7e958);
                local_104 = uVar4;
                fVar13 = (float)Random.Range(0);
                fVar14 = (float)HeroData.GetBaseAttriNum(lVar6,uVar4,0);
                uVar4 = Mathf.RoundToInt(((float)iVar3 * 0.2 + 0.5 + fVar13) * fVar14,0);
                local_100 = Mathf.Max(1,uVar4);
                if (*plVar1 == 0) break;
                lVar8 = GameObject.GetComponent(*plVar1,DAT_181dc8278);
                lVar9 = new ZhSegment(0);
                *(char *)(lVar9 + 16) = isPlayer;
                *(uint32 *)(lVar9 + 24) = local_104;
                *(uint32 *)(lVar9 + 28) = local_100;
                *(uint8 *)(lVar9 + 17) = 0;
                *(int *)(lVar9 + 20) = iVar3;
              }
              if (lVar8 == null) break;
              lVar8.Count = lVar9;
              if ((*plVar1 == 0) || (lVar8 = GameObject.GetComponent(*plVar1,DAT_181dc8278)) == null)
              break;
              DebateCardController.Init(lVar8,0);
              if (*plVar1 == 0) break;
              lVar8 = GameObject.get_transform(*plVar1,0);
              puVar10 = (uint64 *)Vector3.get_zero(local_d8,0);
              if (lVar8 == null) break;
              local_f0 = *(uint32 *)(puVar10 + 1);
              local_f8 = *puVar10;
              Transform.set_localScale(lVar8,&local_f8,0);
              if (*plVar1 == 0) break;
              uVar11 = GameObject.get_transform(*plVar1,0);
              puVar10 = (uint64 *)Vector3.get_one(local_c8,0);
              local_e0 = *(uint32 *)(puVar10 + 1);
              local_e8 = *puVar10;
              uVar11 = ShortcutExtensions.DOScale(uVar11,&local_e8,0x3f000000,0);
              TweenSettingsExtensions.SetDelay(uVar11,(float)local_res20 * 0.05);
              local_res20 = local_res20 + 1;
            }
          }
        }
        throw; // [null/range check failed]
        LAB_180a51ba6:
        iVar3 = Transform.get_childCount(lVar5,0);
        if (iVar3 <= iVar12) goto LAB_180a51d55;
        lVar6 = Transform.GetChild(lVar5,iVar12);
        if (((lVar6 == null) || (lVar6 = Component.GetComponent(lVar6,DAT_181d93cf8)) == null) ||
           (lVar6.summonLv == null)) throw; // [null/range check failed]
        if (*(char *)(lVar6.summonLv + 17) == false) {
          lVar6 = Transform.GetChild(lVar5,iVar12);
          lVar8 = this.debateTopics;
          lVar9 = Transform.GetChild(lVar5,iVar12,0);
          if (((lVar9 == null) || (lVar9 = Component.GetComponent(lVar9,DAT_181d93cf8)) == null) ||
             ((*(int64 *)(lVar9 + 24) == 0 || (lVar8 == null)))) throw; // [null/range check failed]
          local_108 = FUN_1817ebaf0(lVar8,*(uint32 *)(*(int64 *)(lVar9 + 24) + 24));
          uVar11 = Int32.ToString(&local_108,0);
          lVar8 = Transform.GetChild(lVar5,iVar12);
          if (((lVar8 == null) || (lVar8 = Component.GetComponent(lVar8,DAT_181d93cf8)) == null) ||
             (lVar8.Count == null)) throw; // [null/range check failed]
          uVar7 = Int32.ToString(lVar8.Count + 28,"000");
        }
        else {
          lVar6 = Transform.GetChild(lVar5,iVar12);
          lVar8 = Transform.GetChild(lVar5,iVar12);
          if (((lVar8 == null) || (lVar8 = Component.GetComponent(lVar8,DAT_181d93cf8)) == null) ||
             (lVar8.Count == null)) throw; // [null/range check failed]
          uVar7 = Int32.ToString(lVar8.Count + 20,0);
          uVar11 = "9999";
        }
        String.Concat(uVar11,uVar7);
        if (lVar6 == null) throw; // [null/range check failed]
        Object.set_name(lVar6);
        iVar12 = iVar12 + 1;
        goto LAB_180a51ba6;
        LAB_180a51d55:
        uVar11 = Component.get_gameObject(lVar5,0);
        GlobalData.SortChild(uVar11,0);
        lVar6 = new WarpText_d__8(0,0);
        if (lVar6 != null) {
          lVar6.summonControlable = lVar5;
          lVar6.summonSourceHero = isPlayer;
          FUN_180d8c8f0(this,lVar6,0);
          return;
        }
    }

    // Token : 0x60013A7
    // RVA   : 0xA57A50   Offset: 0xA56E50   Length: 0x7E
    public IEnumerator SortCardPosition(Transform targetCardGrid, bool isPlayer)
    {
        int64 DebateUIController.SortCardPosition
                         (uint64 this,uint64 targetCardGrid,uint8 isPlayer)
        {
        int64 lVar1;
        var lVar1 = new WarpText_d__8(0,0);
        if (lVar1 != null) {
          *(uint64 *)(lVar1 + 32) = targetCardGrid;
          *(uint8 *)(lVar1 + 40) = isPlayer;
          return lVar1;
        }
    }

    // Token : 0x60013A8
    // RVA   : 0xA56380   Offset: 0xA55780   Length: 0x71
    public int RandomCardRareLv(float speechSkill)
    {
        int iVar1;
        int iVar2;
        float fVar3;
        float fVar4;
        fVar3 = (float)Random.get_value();
        fVar4 = 0.0;
        iVar1 = 5;
        iVar2 = 0;
        do {
          fVar4 = fVar4 + (float)iVar2 * 0.05 + 0.05 + (speechSkill * 0.075) / 100.0;
          if (fVar3 <= fVar4) {
            return iVar1;
          }
          iVar1 = iVar1 + -1;
          iVar2 = iVar2 + 1;
        } while (iVar2 < 6);
        return 0;
    }

    // Token : 0x60013A9
    // RVA   : 0xA53080   Offset: 0xA52480   Length: 0x636
    public void HideDebateUI()
    {
        uint uVar1;
        ulong uVar2;
        bool cVar3;
        long lVar4;
        ulong uVar5;
        long lVar6;
        ulong uVar7;
        this.playerAngryRound = 0;
        this.lastTopic = 0xffffffffffffffff;
        DebateUIController.SetCalmDown(this,1,0);
        this.enemyAngryRound = 0;
        DebateUIController.SetCalmDown(this,0,0);
        this.debateState = 0;
        if (this.debateTopics != null) {
          FUN_1812fa020(this.debateTopics,DAT_181d7e6e0);
          if (this.debateUIPanel != null) {
            GameObject.SetActive(this.debateUIPanel,0,0);
            if (((this.debateUIPanel != null) &&
                (lVar4 = GameObject.get_transform(this.debateUIPanel,0)) != null) &&
               (lVar4 = Transform.Find(lVar4,"Topic",0)) != null) {
              uVar5 = Component.get_gameObject(lVar4,0);
              GlobalData.DeleteAllChild(uVar5,0);
              if (((this.debateUIPanel != null) &&
                  (lVar4 = GameObject.get_transform(this.debateUIPanel,0)) != null) &&
                 (lVar4 = Transform.Find(lVar4,"NextTopic",0)) != null) {
                uVar5 = Component.get_gameObject(lVar4,0);
                GlobalData.DeleteAllChild(uVar5,0);
                if ((((this.debateUIPanel != null) &&
                     (lVar4 = GameObject.get_transform(this.debateUIPanel,0)) != null) &&
                    (lVar4 = Transform.Find(lVar4,"Player",0)) != null) &&
                   (lVar4 = Transform.Find(lVar4,"Icon",0)) != null) {
                  uVar5 = Component.get_gameObject(lVar4,0);
                  GlobalData.DeleteAllChild(uVar5,0);
                  if (((this.debateUIPanel != null) &&
                      (lVar4 = GameObject.get_transform(this.debateUIPanel,0)) != null) &&
                     ((lVar4 = Transform.Find(lVar4,"Enemy",0), lVar4 != null &&
                      (lVar4 = Transform.Find(lVar4,"Icon",0)) != null))) {
                    uVar5 = Component.get_gameObject(lVar4,0);
                    GlobalData.DeleteAllChild(uVar5,0);
                    if (((this.debateUIPanel != null) &&
                        (lVar4 = GameObject.get_transform(this.debateUIPanel,0)) != null)
                       && ((lVar4 = Transform.Find(lVar4,"Player",0), lVar4 != null &&
                           (lVar4 = Transform.Find(lVar4,"Card",0)) != null))) {
                      uVar5 = Component.get_gameObject(lVar4,0);
                      GlobalData.DeleteAllChild(uVar5,0);
                      if ((((this.debateUIPanel != null) &&
                           (lVar4 = GameObject.get_transform(this.debateUIPanel,0), lVar4 != null
                           )) && (lVar4 = Transform.Find(lVar4,"Enemy",0)) != null) &&
                         (lVar4 = Transform.Find(lVar4,"Card",0)) != null) {
                        uVar5 = Component.get_gameObject(lVar4,0);
                        GlobalData.DeleteAllChild(uVar5,0);
                        if (((this.debateUIPanel != null) &&
                            (lVar4 = GameObject.get_transform(this.debateUIPanel,0),
                            lVar4 != null)) && (lVar4 = Transform.Find(lVar4,"DeleteCard",0)) != null)
                        {
                          uVar5 = Component.get_gameObject(lVar4,0);
                          GlobalData.DeleteAllChild(uVar5,0);
                          if (((this.debateUIPanel != null) &&
                              (lVar4 = GameObject.get_transform(this.debateUIPanel,0),
                              lVar4 != null)) &&
                             ((lVar4 = Transform.Find(lVar4,"FinalResult",0), lVar4 != null &&
                              (lVar4 = Component.get_gameObject(lVar4,0)) != null))) {
                            GameObject.SetActive(lVar4,0,0);
                            if ((this.fightEndCallFuc == null) ||
                               (cVar3 = String.op_Inequality
                                                  (this.fightEndCallFuc,"",0),
                               !cVar3)) {
                              return;
                            }
                            lVar4 = this.fightEndCallFuc;
                            lVar6 = FUN_1800d60b0(DAT_181da1058,1);
                            if (lVar6 != null) {
                              if (*(int *)(lVar6 + 24) == 0) {
                                uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                FUN_1800d65f0(uVar5,0);
                              }
                              *(uint16 *)(lVar6 + 32) = 45;
                              if (lVar4 != null) {
                                lVar4 = String.Split(lVar4,lVar6,0);
                                lVar6 = FUN_18046c400(0);
                                if (lVar4 != null) {
                                  uVar1 = *(uint32 *)(lVar4 + 24);
                                  if (uVar1 == 0) {
                                    uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                    FUN_1800d65f0(uVar5,0);
                                  }
                                  uVar5 = "false";
                                  if (this.playerWin) {
                                    uVar5 = "true";
                                  }
                                  uVar2 = *(uint64 *)(lVar4 + 32);
                                  uVar7 = "";
                                  if (1 < (int)uVar1) {
                                    if (uVar1 < 2) {
                                      uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                      FUN_1800d65f0(uVar5,0);
                                    }
                                    uVar7 = String.Concat("-",*(uint64 *)(lVar4 + 40),0);
                                  }
                                  uVar5 = String.Concat(uVar5,uVar7,0);
                                  if (lVar6 != null) {
                                    Component.SendMessage(lVar6,uVar2,uVar5,0);
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

    // Token : 0x60013AA
    // RVA   : 0xA58920   Offset: 0xA57D20   Length: 0xF
    public void /*ctor*/()
    {
        void FUN_180a58920(int64 this)
        {
        this.lastTopic = 0xffffffffffffffff;
        FUN_18044ef50(this,0);
    }

    // Token : 0x60013AB
    // RVA   : 0xA58310   Offset: 0xA57710   Length: 0x602
    private static void /*cctor*/()
    {
        var pStatics = *(int64*)(DAT_181dbfc58 + 184);
        long lVar1;
        lVar1 = il2cpp_internal(DAT_181d97768);
        FUN_181330100(lVar1,DAT_181da3bf0);
        if (lVar1 != null) {
          FUN_18181e6b0(lVar1,"对于“{0}”，\n我颇有几分见解",DAT_181da3d70);
          FUN_18181e6b0(lVar1,"“{0}”之道，博大精深",DAT_181da3d70);
          FUN_18181e6b0(lVar1,"不知对于“{0}”一事，\n{1}有何见地？",DAT_181da3d70);
          FUN_18181e6b0(lVar1,"这“{0}”的精要之处，\n我早已了然于胸",DAT_181da3d70);
          FUN_18181e6b0(lVar1,"{1}可知这“{0}”之妙？\n容我娓娓道来",DAT_181da3d70);
          FUN_18181e6b0(lVar1,"若不通晓“{0}”，\n功夫再高又有何用？",DAT_181da3d70);
          FUN_18181e6b0(lVar1,"“{0}”此事，可谓易学难精",DAT_181da3d70);
          FUN_18181e6b0(lVar1,"这“{0}”乃我得意之处，\n{1}可有应对？",DAT_181da3d70);
          FUN_18181e6b0(lVar1,"“{0}”者奥妙非常，\n非常人能够掌握",DAT_181da3d70);
          FUN_18181e6b0(lVar1,"不知{1}之“{0}”，\n与我相比孰强孰弱？",DAT_181da3d70);
          FUN_18181e6b0(lVar1,"便用这“{0}”，\n令你心服口服",DAT_181da3d70);
          plVar2 = pStatics;
          *plVar2 = lVar1;
          il2cpp_internal(plVar2,lVar1);
          lVar1 = il2cpp_internal(DAT_181d97768);
          FUN_181330100(lVar1,DAT_181da3bf0);
          if (lVar1 != null) {
            FUN_18181e6b0(lVar1,"{1}这番见解，\n不过老生常谈而已",DAT_181da3d70);
            FUN_18181e6b0(lVar1,"{1}“{0}”止步于此，\n与乡野村夫何异？",DAT_181da3d70);
            FUN_18181e6b0(lVar1,"{1}之理解颇为浅薄，\n还需多加学习才是",DAT_181da3d70);
            FUN_18181e6b0(lVar1,"我“{0}”修为远胜{1}，\n又何必班门弄斧？",DAT_181da3d70);
            FUN_18181e6b0(lVar1,"{1}言语中颇多纰漏之处，\n只恐贻笑大方",DAT_181da3d70);
            FUN_18181e6b0(lVar1,"{1}语焉不详，词不达意，\n令人哑然失笑",DAT_181da3d70);
            FUN_18181e6b0(lVar1,"看来{1}的“{0}”修为，\n不过平平而已",DAT_181da3d70);
            FUN_18181e6b0(lVar1,"{1}此言前后多有矛盾，\n还请三思",DAT_181da3d70);
            FUN_18181e6b0(lVar1,"{1}语无伦次，文不对题，\n需先理清思路，方可发言",DAT_181da3d70);
            FUN_18181e6b0(lVar1,"{1}“{0}”修为尚浅\n切勿自以为是",DAT_181da3d70);
            PlotController.fightSkillIndexCache = lVar1;
            lVar1 = il2cpp_internal(DAT_181d97768);
            FUN_181330100(lVar1,DAT_181da3bf0);
            if (lVar1 != null) {
              FUN_18181e6b0(lVar1,"这...只有心悦诚服",DAT_181da3d70);
              FUN_18181e6b0(lVar1,"{1}高论，是我技不如人",DAT_181da3d70);
              FUN_18181e6b0(lVar1,"“{0}”竟有这等境界...\n我不能及也",DAT_181da3d70);
              FUN_18181e6b0(lVar1,"{1}“{0}”之高，\n令我眼界大开",DAT_181da3d70);
              FUN_18181e6b0(lVar1,"比起{1}，\n我终究还是稍逊一筹",DAT_181da3d70);
              FUN_18181e6b0(lVar1,"{1}之“{0}”精妙非常，\n我还需多加学习",DAT_181da3d70);
              FUN_18181e6b0(lVar1,"今日听{1}一席高论，\n才知自己“{0}”之贫弱",DAT_181da3d70);
              FUN_18181e6b0(lVar1,"{1}一席话，\n令我茅塞顿开",DAT_181da3d70);
              FUN_18181e6b0(lVar1,"山外有山，人外有人，\n今日方知此言真意",DAT_181da3d70);
              FUN_18181e6b0(lVar1,"{1}辩才无双，佩服佩服！",DAT_181da3d70);
              FUN_18181e6b0(lVar1,"我之“{0}”竟远不及{1}，\n惭愧惭愧",DAT_181da3d70);
              PlotController.livingSkillIndexCache = lVar1;
              lVar1 = il2cpp_internal(DAT_181d97768);
              FUN_181330100(lVar1,DAT_181da3bf0);
              if (lVar1 != null) {
                FUN_18181e6b0(lVar1,"{1}的“{0}”，\n竟与我不相上下",DAT_181da3d70);
                FUN_18181e6b0(lVar1,"真是棋逢对手",DAT_181da3d70);
                FUN_18181e6b0(lVar1,"此局只能说难分高下",DAT_181da3d70);
                PlotController._instance = lVar1;
                return;
              }
            }
          }
        }
    }

    // Token : 0x60013AC
    // RVA   : 0xA57AD0   Offset: 0xA56ED0   Length: 0x8
    private void <NextDebateRound>b__40_0()
    {
        void FUN_180a57ad0(int64 this)
        {
        this.waitClick = 1;
    }

}
