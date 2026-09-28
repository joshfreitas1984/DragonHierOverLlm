// ============================================================
// Type  : BattleTeamHeroIconController
// Token : 0x2000178
// ============================================================

public class BattleTeamHeroIconController
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4000A00
    public TeamMemPrepareData teamMemPrepareData;

    // Token: 0x4000A01
    public Toggle toggleButton;

    // Token: 0x4000A02
    private bool init;

    // Token: 0x4000A03
    private GameObject newObj;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000C40
    // RVA   : 0x8CCD50   Offset: 0x8CC150   Length: 0x3E
    private void Update()
    {
        if (!this.init) {
          BattleTeamHeroIconController.Init(this,0);
        }
        if ((this.teamMemPrepareData != null) && (this.toggleButton != null)) {
          Toggle.set_isOn(this.toggleButton,
                           this.teamMemPrepareData.enterBattle,0);
          return;
        }
    }

    // Token : 0x6000C41
    // RVA   : 0x8CC7C0   Offset: 0x8CBBC0   Length: 0x19E
    public void Init()
    {
        var pStatics = *(int64*)(DAT_181d72ee8 + 184);
        ulong uVar1;
        bool cVar2;
        long lVar3;
        ulong uVar4;
        this.init = 1;
        lVar3 = Component.get_transform(this,0);
        if (lVar3 != null) {
          lVar3 = Transform.Find(lVar3,"HeroIconPos",0);
          if (lVar3 != null) {
            uVar4 = Component.get_gameObject(lVar3,0);
            if (*pStatics != 0) {
              uVar1 = *(uint64 *)(*pStatics + 144);
              uVar4 = GlobalData.AddChild(uVar4,uVar1,0);
              this.newObj = uVar4;
              if (this.newObj != null) {
                lVar3 = GameObject.GetComponent(this.newObj,DAT_181d71b50);
                if ((this.teamMemPrepareData != null) && (lVar3 != null)) {
                  *(uint64 *)(lVar3 + 32) = this.teamMemPrepareData.heroData;
                  if (this.newObj != null) {
                    lVar3 = GameObject.GetComponent(this.newObj,DAT_181d71b50);
                    if (lVar3 != null) {
                      *(uint32 *)(lVar3 + 24) = 2;
                      if (this.teamMemPrepareData != null) {
                        cVar2 = TeamMemPrepareData.PrepareControlable(this.teamMemPrepareData,0);
                        lVar3 = this.toggleButton;
                        if (!cVar2) {
                          if (lVar3 == null) throw; // [null/range check failed]
                          uVar4 = 0;
                        }
                        else {
                          if (lVar3 == null) throw; // [null/range check failed]
                          uVar4 = 1;
                        }
                        Selectable.set_interactable(lVar3,uVar4,0);
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

    // Token : 0x6000C42
    // RVA   : 0x8CC960   Offset: 0x8CBD60   Length: 0x3E9
    public void ToggleButtonClicked()
    {
        uint uVar1;
        int iVar2;
        long lVar3;
        long lVar4;
        ulong uVar6;
        if (this.teamMemPrepareData == null) throw; // [null/range check failed]
        lVar3 = this.toggleButton;
        if (!this.teamMemPrepareData.enterBattle) {
          if (lVar3 == null) throw; // [null/range check failed]
          if (*(char *)(lVar3 + 0x118) != false) {
            lVar3 = FUN_18046bb80(0);
            if (lVar3 == null) throw; // [null/range check failed]
            if (0 < *(int *)(lVar3 + 52)) {
              lVar3 = FUN_18046bb80(0);
              if (((lVar3 == null) || (this.teamMemPrepareData == null)) ||
                 (lVar3 = *(int64 *)(lVar3 + 88)) == null) throw; // [null/range check failed]
              uVar1 = this.teamMemPrepareData.teamID;
              if (lVar3.heroData <= uVar1) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              iVar2 = lVar3.teamID[uVar1];
              lVar3 = FUN_18046bb80(0);
              if (lVar3 == null) throw; // [null/range check failed]
              if (*(int *)(lVar3 + 52) <= iVar2) {
                lVar3 = FUN_18046c0a0(0);
                uVar6 = "已达最大出战人数";
                goto joined_r0x0001808ccc69;
              }
            }
            lVar4 = FUN_18046bb80(0);
            lVar3 = this.teamMemPrepareData;
            if ((lVar3 == null) || (lVar4 == null)) throw; // [null/range check failed]
            BattleController.ChangeTeamMemJoinBattle
                      (lVar4,lVar3.teamID,lVar3.heroData,1,1,0);
            if ((this.teamMemPrepareData == null) ||
               (lVar3 = this.teamMemPrepareData.heroData) == null)
            throw; // [null/range check failed]
            uVar6 = HeroData.GetHeroMeetSound(lVar3,"Yes",0);
            HeroData.PlayHeroSound(lVar3,uVar6,0x3f4ccccd,0xbf800000,0);
          }
        }
        else {
          if (lVar3 == null) throw; // [null/range check failed]
          if (*(char *)(lVar3 + 0x118) == false) {
            lVar3 = FUN_18046bb80(0);
            if (((lVar3 == null) || (this.teamMemPrepareData == null)) ||
               (lVar3 = *(int64 *)(lVar3 + 88)) == null) throw; // [null/range check failed]
            uVar1 = this.teamMemPrepareData.teamID;
            if (lVar3.heroData <= uVar1) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            if (lVar3.teamID[uVar1] < 2) {
              lVar3 = FUN_18046c0a0(0);
              uVar6 = "出战人数最少为一人";
        joined_r0x0001808ccc69:
              if (lVar3 != null) {
                GameController.ShowTextOnMouse(lVar3,uVar6,0);
                plVar5 = (int64 *)Resources.Load("Sound/SoundEffect/WrongClick",0);
                plVar7 = (int64 *)0;
                if ((plVar5 != (int64 *)0) && (*plVar5 == DAT_181daf348)) {
                  plVar7 = plVar5;
                }
                NGUITools.PlaySound(plVar7,0);
                return;
              }
              throw; // [null/range check failed]
            }
            lVar4 = FUN_18046bb80(0);
            lVar3 = this.teamMemPrepareData;
            if ((lVar3 == null) || (lVar4 == null)) throw; // [null/range check failed]
            BattleController.ChangeTeamMemJoinBattle
                      (lVar4,lVar3.teamID,lVar3.heroData,0,1,0);
          }
        }
        if ((this.toggleButton != null) && (this.teamMemPrepareData != null)) {
          this.teamMemPrepareData.enterBattle =
               *(uint8 *)(this.toggleButton + 0x118);
          return;
        }
    }

    // Token : 0x6000C43
    // RVA   : 0x3A17B0   Offset: 0x3A0BB0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_18044ef50(this,0);
    }

}
