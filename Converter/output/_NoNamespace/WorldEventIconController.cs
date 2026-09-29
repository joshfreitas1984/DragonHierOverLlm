// ============================================================
// Type  : WorldEventIconController
// Token : 0x20003B8
// ============================================================

public class WorldEventIconController
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001E20
    public EventData worldEventData;

    // Token: 0x4001E21
    public bool inited;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60023BF
    // RVA   : 0x9D2F90   Offset: 0x9D2390   Length: 0x669
    private void Update()
    {
        var pStatics = *(int64*)(DAT_181d8aba8 + 184);
        uint uVar1;
        bool cVar2;
        long lVar3;
        ulong uVar4;
        ulong uVar5;
        ulong uVar6;
        long lVar7;
        ulong local_38;
        uint local_30;
        uint local_28;
        uint uStack_24;
        uint uStack_20;
        uint32 uStack_1c;
        if (!this.inited) {
          this.inited = 1;
          lVar3 = Component.get_transform(this,0);
          if ((lVar3 == null) || (lVar3 = Transform.Find(lVar3,"Title",0)) == null)
          throw; // [null/range check failed]
          uVar4 = Component.GetComponent(lVar3,DAT_181d96178);
          lVar3 = this.worldEventData;
          if (lVar3 == null) throw; // [null/range check failed]
          uVar6 = lVar3.eventName;
          uVar5 = EventData.GetPosText(lVar3,0);
          uVar5 = String.Format("({0})",uVar5,0);
          uVar6 = String.Concat(uVar6,uVar5,0);
          LTLocalization.SetText(uVar4,uVar6,0);
          lVar3 = Component.get_transform(this,0);
          if (lVar3 == null) throw; // [null/range check failed]
          lVar7 = Component.GetComponent(lVar3,DAT_181d95578);
          lVar3 = this.worldEventData;
          if (lVar3 == null) throw; // [null/range check failed]
          uVar4 = "";
          if ((lVar3.plotTargetEvent != false) && (uVar4 = "<color=#D2691E><b>[重要剧情传闻]</b></color>\n", lVar3.notImportant)
             ) {
            uVar4 = "<color=grey><b>[次要剧情传闻]</b></color>\n";
          }
          uVar6 = EventData.GetDescribe(lVar3,1,0);
          uVar4 = String.Concat(uVar4,uVar6,0);
          if (lVar7 == null) throw; // [null/range check failed]
          *(uint64 *)(lVar7 + 24) = uVar4;
          lVar3 = Component.get_transform(this,0);
          if (lVar3 == null) throw; // [null/range check failed]
          lVar3 = Transform.Find(lVar3,"ImportantIcon",0);
          if (this.worldEventData == null) throw; // [null/range check failed]
          if (this.worldEventData.plotTargetEvent == false) {
            puVar8 = (uint64 *)Vector3.get_zero(&local_38);
          }
          else {
            puVar8 = (uint64 *)Vector3.get_one();
          }
          if (lVar3 == null) throw; // [null/range check failed]
          local_38 = *puVar8;
          local_30 = *(uint32 *)(puVar8 + 1);
          Transform.set_localScale(lVar3,&local_38,0);
          if (this.worldEventData == null) throw; // [null/range check failed]
          if (this.worldEventData.plotTargetEvent != false) {
            lVar3 = Component.get_transform(this,0);
            if ((lVar3 == null) || (lVar3 = Transform.Find(lVar3,"ImportantIcon",0)) == null)
            throw; // [null/range check failed]
            plVar9 = (int64 *)Component.GetComponent(lVar3);
            if (this.worldEventData == null) throw; // [null/range check failed]
            if (!this.worldEventData.notImportant) {
              puVar10 = (uint32 *)Color.get_yellow(&local_28);
            }
            else {
              puVar10 = (uint32 *)FUN_1810d3b80();
            }
            if (plVar9 == (int64 *)0) throw; // [null/range check failed]
            local_28 = *puVar10;
            uStack_24 = puVar10[1];
            uStack_20 = puVar10[2];
            uStack_1c = puVar10[3];
            (**(code **)(*plVar9 + 0x2a8))(plVar9,&local_28,*(uint64 *)(*plVar9 + 0x2b0));
          }
          lVar3 = Component.get_transform(this,0);
          if (lVar3 == null) throw; // [null/range check failed]
          lVar7 = Transform.Find(lVar3,"NoticeIcon",0);
          lVar3 = this.worldEventData;
          if (lVar3 == null) throw; // [null/range check failed]
          if ((lVar3.plotTargetEvent == false) && (!lVar3.noticed)) {
            puVar8 = (uint64 *)Vector3.get_one(&local_38,0);
          }
          else {
            puVar8 = (uint64 *)Vector3.get_zero(&local_38,0);
          }
          if (lVar7 == null) throw; // [null/range check failed]
          local_38 = *puVar8;
          local_30 = *(uint32 *)(puVar8 + 1);
          Transform.set_localScale(lVar7,&local_38,0);
          lVar3 = Component.get_transform(this,0);
          if ((lVar3 == null) || (lVar3 = Transform.Find(lVar3,"RareLv",0)) == null)
          throw; // [null/range check failed]
          plVar9 = (int64 *)Component.GetComponent(lVar3,DAT_181d94478);
          if (this.worldEventData == null) throw; // [null/range check failed]
          uVar1 = this.worldEventData.difficulty;
          puVar10 = (uint32 *)GlobalData.GetDifficultyColor(&local_28,uVar1,0);
          if (plVar9 == (int64 *)0) throw; // [null/range check failed]
          local_28 = *puVar10;
          uStack_24 = puVar10[1];
          uStack_20 = puVar10[2];
          uStack_1c = puVar10[3];
          (**(code **)(*plVar9 + 0x2a8))(plVar9,&local_28,*(uint64 *)(*plVar9 + 0x2b0));
        }
        lVar3 = Component.get_transform(this,0);
        if ((lVar3 != null) && (lVar3 = Transform.Find(lVar3,"LeftTime",0)) != null) {
          uVar4 = Component.GetComponent(lVar3,DAT_181d96178);
          if (this.worldEventData != null) {
            piVar11 = &this.worldEventData.leftTime;
            uVar6 = "";
            if (0 < this.worldEventData.leftTime) {
              uVar6 = Int32.ToString(piVar11,0);
              uVar6 = String.Format("{0}天",uVar6,0);
            }
            LTLocalization.SetText(uVar4,uVar6,0);
            uVar4 = *(uint64 *)(*(int64 *)(DAT_181d8b7a8 + 184) + 72);
            uVar6 = Component.get_gameObject(this,0);
            cVar2 = Object.op_Equality(uVar4,uVar6,0);
            if (!cVar2) {
              return;
            }
            lVar3 = this.worldEventData;
            if (lVar3 != null) {
              if (lVar3.noticed) {
                return;
              }
              lVar3.noticed = 1;
              lVar3 = Component.get_transform(this,0);
              if (lVar3 != null) {
                lVar3 = Transform.Find(lVar3,"NoticeIcon",0);
                puVar8 = (uint64 *)Vector3.get_zero(&local_28,0);
                if (lVar3 != null) {
                  local_30 = *(uint32 *)(puVar8 + 1);
                  local_38 = *puVar8;
                  Transform.set_localScale(lVar3,&local_38,0);
                  if (*pStatics != 0) {
                    MissionUIController.RefreshWorldEventNewIcon(*pStatics,0)
                    ;
                    return;
                  }
                }
              }
            }
          }
        }
    }

    // Token : 0x60023C0
    // RVA   : 0x9D2BA0   Offset: 0x9D1FA0   Length: 0x3EA
    public void OnClick()
    {
        var pStatics_2ee8 = *(int64*)(DAT_181d72ee8 + 184);
        uint uVar1;
        long lVar2;
        bool cVar3;
        long lVar4;
        long lVar5;
        uint local_38;
        uint uStack_34;
        uint local_28;
        uint uStack_24;
        byte[] local_18 = new byte[16];
        if (GameController._instance == null) goto LAB_1809d2f85;
        cVar3 = GameController.HaveSpeUI(GameController._instance,1,0);
        if (cVar3) {
          return;
        }
        if ((*pStatics_2ee8 == 0) ||
           (lVar4 = *(int64 *)(*pStatics_2ee8 + 32)) == null)
        goto LAB_1809d2f85;
        cVar3 = GameObject.get_activeSelf(lVar4,0);
        if (!cVar3) {
          return;
        }
        lVar4 = this.worldEventData;
        if ((lVar4 == null) || (lVar4.areaID == null)) goto LAB_1809d2f85;
        if (*(int *)(lVar4.areaID + 24) < 1) {
          if (lVar4.nearAreaID != -1) {
            lVar4 = FUN_18046bbe0(0);
            lVar5 = FUN_18046bbe0(0);
            if (((lVar5 == null) || (this.worldEventData == null)) ||
               (lVar5 = *(int64 *)(lVar5 + 96)) == null) goto LAB_1809d2f85;
            uVar1 = this.worldEventData.nearAreaID;
            goto LAB_1809d2ec1;
          }
          if (lVar4.resourcePointID < 0) goto LAB_1809d2f2a;
          lVar4 = FUN_18046bbe0(0);
          lVar5 = FUN_18046bbe0(0);
          if ((((lVar5 == null) || (this.worldEventData == null)) ||
              (*(int64 *)(lVar5 + 104) == 0)) ||
             ((lVar5 = FUN_1817da420(*(int64 *)(lVar5 + 104),
                                     this.worldEventData.resourcePointID,DAT_181db9ee8),
              lVar5 == null || (lVar5 = GameObject.get_transform(lVar5,0)) == null)))
          goto LAB_1809d2f85;
          puVar6 = (uint64 *)Transform.get_localPosition(local_18,lVar5,0);
          if (lVar4 == null) goto LAB_1809d2f85;
          local_38 = (uint32)*puVar6;
          uStack_24 = (uint32)((uint64)*puVar6 >> 32);
        }
        else {
          lVar4 = FUN_18046bbe0(0);
          lVar5 = FUN_18046bbe0(0);
          if (lVar5 == null) goto LAB_1809d2f85;
          lVar5 = *(int64 *)(lVar5 + 96);
          if ((this.worldEventData == null) ||
             (lVar2 = this.worldEventData.areaID) == null)
          goto LAB_1809d2f85;
          if (*(int *)(lVar2 + 24) == 0) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          if (lVar5 == null) goto LAB_1809d2f85;
          uVar1 = *(uint32 *)(*(int64 *)(lVar2 + 16) + 32);
        LAB_1809d2ec1:
          lVar5 = FUN_1817da420(lVar5,uVar1,DAT_181db9ee8);
          if ((lVar5 == null) || (lVar5 = GameObject.get_transform(lVar5,0)) == null) {
        LAB_1809d2f85:
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          puVar6 = (uint64 *)Transform.get_localPosition(local_18,lVar5,0);
          if (lVar4 == null) goto LAB_1809d2f85;
          uStack_34 = (uint32)((uint64)*puVar6 >> 32);
          local_28 = (uint32)*puVar6;
          uStack_24 = uStack_34;
          local_38 = local_28;
        }
        *(uint32 *)(lVar4 + 172) = uStack_24;
        *(uint32 *)(lVar4 + 168) = local_38;
        LAB_1809d2f2a:
        plVar7 = (int64 *)Resources.Load("Sound/SoundEffect/Woosh",0);
        plVar8 = (int64 *)0;
        if ((plVar7 != (int64 *)0) && (*plVar7 == DAT_181daf360)) {
          plVar8 = plVar7;
        }
        NGUITools.PlaySound(plVar8,0);
    }

    // Token : 0x60023C1
    // RVA   : 0x3A17B0   Offset: 0x3A0BB0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_18044ef50(this,0);
    }

}
