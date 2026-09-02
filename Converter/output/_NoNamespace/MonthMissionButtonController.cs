// ============================================================
// Type  : MonthMissionButtonController
// Token : 0x2000303
// ============================================================

public class MonthMissionButtonController
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001823
    public MissionData targetMission;

    // Token: 0x4001824
    private bool inited;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60018E9
    // RVA   : 0xAF4220   Offset: 0xAF2A20   Length: 0xCBA
    private void Update()
    {
        var pStatics_df90 = *(int64*)(DAT_181d4df90 + 184);
        var pStatics_ef00 = *(int64*)(DAT_181d4ef00 + 184);
        uint uVar1;
        int iVar2;
        bool cVar3;
        uint uVar4;
        long lVar5;
        long lVar6;
        ulong uVar7;
        ulong uVar8;
        ulong uVar11;
        ulong uVar12;
        long lVar13;
        ulong uVar14;
        float fVar16;
        float fVar17;
        uint[] local_res8 = new uint[2];
        uint[] local_res18 = new uint[4];
        ulong in_stack_ffffffffffffff78;
        ulong local_78;
        ulong local_68;
        float local_60;
        byte[] local_48 = new byte[32];
        if (this.inited) {
          return;
        }
        this.inited = 1;
        fVar17 = local_60;
        if ((*pStatics_df90 == 0) ||
           (lVar5 = *(int64 *)(*pStatics_df90 + 32)) == null)
        goto LAB_180af4ecf;
        if (*(int *)(lVar5 + 156) == 0) {
          lVar5 = FUN_18046c0a0(0);
          fVar17 = local_60;
          if ((lVar5 == null) || (lVar5.speMissionID == null)) goto LAB_180af4ecf;
          if (0 < *(int *)(lVar5.speMissionID + 0x188)) goto LAB_180af45a4;
          lVar5 = Component.GetComponent(this,DAT_181d6af40);
          fVar17 = local_60;
          if ((this.targetMission == null) ||
             (lVar6 = this.targetMission.missionTargetDatas) == null)
          goto LAB_180af4ecf;
          if (*(int *)(lVar6 + 24) == 0) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          lVar6 = *(int64 *)(*(int64 *)(lVar6 + 16) + 32);
          fVar17 = local_60;
          if ((lVar6 == null) || (lVar6 = *(int64 *)(lVar6 + 56)) == null) goto LAB_180af4ecf;
          if (*(int *)(lVar6 + 24) == 0) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          lVar6 = *(int64 *)(*(int64 *)(lVar6 + 16) + 32);
          fVar17 = local_60;
          if (lVar6 == null) goto LAB_180af4ecf;
          if (*(int *)(lVar6 + 16) == 2) {
            if ((this.targetMission == null) ||
               (lVar6 = this.targetMission.missionTargetDatas) == null)
            goto LAB_180af4ecf;
            if (*(int *)(lVar6 + 24) == 0) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            lVar6 = *(int64 *)(*(int64 *)(lVar6 + 16) + 32);
            fVar17 = local_60;
            if ((lVar6 == null) || (lVar6 = *(int64 *)(lVar6 + 56)) == null) goto LAB_180af4ecf;
            if (*(int *)(lVar6 + 24) == 0) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            lVar6 = *(int64 *)(*(int64 *)(lVar6 + 16) + 32);
            fVar17 = local_60;
            if (lVar6 == null) goto LAB_180af4ecf;
            bVar15 = *(int *)(lVar6 + 32) == 0;
          }
          else {
            bVar15 = false;
          }
          fVar17 = local_60;
          if (lVar5 == null) goto LAB_180af4ecf;
          Selectable.set_interactable(lVar5,bVar15,0);
          lVar5 = Component.GetComponent(this,DAT_181d6af40);
          fVar17 = local_60;
          if (lVar5 == null) goto LAB_180af4ecf;
          if (*(char *)(lVar5 + 208) == false) {
            lVar5 = Component.GetComponent(this,DAT_181d6ccc0);
            uVar8 = "完成一次门派任务才能选择";
            fVar17 = local_60;
            if (lVar5 == null) goto LAB_180af4ecf;
            lVar5.name = "完成一次门派任务才能选择";
            goto LAB_180af4b37;
          }
        }
        else {
        LAB_180af45a4:
          lVar5 = Component.GetComponent(this,DAT_181d6af40);
          fVar17 = local_60;
          if ((((*pStatics_df90 == 0) ||
               (lVar6 = *(int64 *)(*pStatics_df90 + 32)) == null) ||
              (lVar6 = WorldData.Player(lVar6,0), fVar17 = local_60) == null) ||
             ((this.targetMission == null || (lVar5 == null)))) goto LAB_180af4ecf;
          iVar2 = this.targetMission.minForceLv;
          Selectable.set_interactable
                    (lVar5,CONCAT31((int3)((uint32)iVar2 >> 8),iVar2 <= *(int *)(lVar6 + 184)),0);
          lVar5 = Component.GetComponent(this,DAT_181d6ccc0);
          fVar17 = local_60;
          if ((((*pStatics_df90 == 0) ||
               (lVar6 = *(int64 *)(*pStatics_df90 + 32)) == null) ||
              (lVar6 = WorldData.Player(lVar6,0), fVar17 = local_60) == null) ||
             (lVar13 = this.targetMission) == null) goto LAB_180af4ecf;
          uVar8 = "";
          if (*(int *)(lVar6 + 184) < lVar13.minForceLv) {
            if (((*(byte *)(DAT_181d4ef00 + 0x133) & 4) != 0) && (*(int *)(DAT_181d4ef00 + 224) == 0)) {
              il2cpp_runtime_class_init(DAT_181d4ef00);
              lVar13 = this.targetMission;
            }
            lVar6 = *(int64 *)(pStatics_ef00 + 0x3d0);
            fVar17 = local_60;
            if (lVar13 == null) goto LAB_180af4ecf;
            uVar1 = lVar13.minForceLv;
            if (lVar6 == null) goto LAB_180af4ecf;
            if (*(uint32 *)(lVar6 + 24) <= uVar1) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
              lVar13 = this.targetMission;
            }
            fVar17 = local_60;
            if (lVar13 == null) goto LAB_180af4ecf;
            uVar8 = GlobalData.GenerateRareLvColorText
                              (*(uint64 *)
                                (*(int64 *)(lVar6 + 16) + 32 + (int64)(int)uVar1 * 8),
                               lVar13.minForceLv,0);
            uVar8 = String.Concat("需要 ",uVar8,0);
          }
          fVar17 = local_60;
          if (lVar5 == null) goto LAB_180af4ecf;
          lVar5.name = uVar8;
          fVar17 = local_60;
          if ((this.targetMission == null) ||
             (lVar5 = this.targetMission.missionTargetDatas) == null)
          goto LAB_180af4ecf;
          if (lVar5.name == null) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          lVar5 = *(int64 *)(lVar5.id + 32);
          fVar17 = local_60;
          if ((lVar5 = lVar5?.treasureLv) == null) goto LAB_180af4ecf;
          if (lVar5.name == null) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          lVar5 = *(int64 *)(lVar5.id + 32);
          fVar17 = local_60;
          if (lVar5 == null) goto LAB_180af4ecf;
          if (lVar5.id == 12) {
            lVar5 = FUN_18046c0a0(0);
            fVar17 = local_60;
            if (lVar5 == null) goto LAB_180af4ecf;
            lVar5 = lVar5.speMissionID;
            if ((this.targetMission == null) ||
               (lVar6 = this.targetMission.missionTargetDatas) == null)
            goto LAB_180af4ecf;
            if (*(int *)(lVar6 + 24) == 0) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            lVar6 = *(int64 *)(*(int64 *)(lVar6 + 16) + 32);
            fVar17 = local_60;
            if ((lVar6 == null) || (lVar6 = *(int64 *)(lVar6 + 56)) == null) goto LAB_180af4ecf;
            if (*(int *)(lVar6 + 24) == 0) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            lVar6 = *(int64 *)(*(int64 *)(lVar6 + 16) + 32);
            fVar17 = local_60;
            if (((lVar6 == null) ||
                (uVar4 = Int32.Parse(*(uint64 *)(lVar6 + 24),0), fVar17 = local_60, lVar5 == null)) ||
               (lVar5 = WorldData.GetHero(lVar5,uVar4,0), fVar17 = local_60) == null)
            goto LAB_180af4ecf;
            fVar16 = (float)HeroData.Favor(lVar5,0,0);
            lVar5 = Component.GetComponent(this,DAT_181d6ccc0);
            fVar17 = local_60;
            if (lVar5 == null) goto LAB_180af4ecf;
            uVar8 = lVar5.name;
            lVar5 = Component.GetComponent(this,DAT_181d6ccc0);
            fVar17 = local_60;
            if (lVar5 == null) goto LAB_180af4ecf;
            cVar3 = FUN_1816fd990(lVar5.name,"",0);
            uVar11 = "\n";
            if (cVar3) {
              uVar11 = "";
            }
            local_res8[0] = Mathf.FloorToInt();
            uVar7 = il2cpp_value_box(DAT_181d5b2f8,local_res8);
            uVar12 = "对方好感 60{1}(当前{0})</color>";
            if (fVar16 < 60.0) {
              uVar14 = *(uint64 *)(pStatics_ef00 + 0x2c8);
            }
            else {
              uVar14 = *(uint64 *)(pStatics_ef00 + 0x260);
            }
            uVar12 = String.Format(uVar12,uVar7,uVar14,0);
            uVar8 = String.Concat(uVar8,uVar11,uVar12,0);
            *puVar10 = uVar8;
            il2cpp_internal(puVar10,uVar8);
          }
          lVar5 = Component.GetComponent(this,DAT_181d6ccc0);
          fVar17 = local_60;
          if (lVar5 == null) goto LAB_180af4ecf;
          uVar8 = lVar5.name;
          puVar10 = &lVar5.name;
          if (this.targetMission == null) goto LAB_180af4ecf;
          uVar11 = "";
          if (0 < this.targetMission.missionFunds) {
            lVar5 = Component.GetComponent(this,DAT_181d6ccc0);
            fVar17 = local_60;
            if (lVar5 == null) goto LAB_180af4ecf;
            cVar3 = FUN_1816fd990(lVar5.name,"",0);
            uVar11 = "\n";
            if (cVar3) {
              uVar11 = "";
            }
            if (this.targetMission == null) {
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            local_res8[0] = this.targetMission.missionFunds;
            uVar12 = il2cpp_value_box(DAT_181d5b2f8,local_res8);
            uVar12 = String.Format("任务经费 {0}两",uVar12,0);
            uVar11 = String.Concat(uVar11,uVar12,0);
          }
          uVar8 = String.Concat(uVar8,uVar11,0);
          lVar5.name = uVar8;
        LAB_180af4b37:
          il2cpp_internal(puVar10,uVar8);
        }
        lVar5 = Component.get_transform(this,0);
        fVar17 = local_60;
        if ((lVar5 != null) &&
           (lVar5 = Transform.Find(lVar5,"RareLv",0), fVar17 = local_60) != null) {
          lVar5 = Component.GetComponent(lVar5,DAT_181d6bc40);
          lVar6 = **(int64 **)(DAT_181d86270 + 184);
          fVar17 = local_60;
          if (this.targetMission != null) {
            uVar8 = Int32.ToString(this.targetMission + 72,0);
            uVar8 = String.Concat("门派等级令牌",uVar8,0);
            fVar17 = local_60;
            if ((lVar6 != null) &&
               (uVar8 = TextureController.LoadAtlasSprite(lVar6,"UIAtlas",uVar8,0), fVar17 = local_60
               , lVar5 != null)) {
              Image.set_sprite(lVar5,uVar8,0);
              lVar5 = Component.get_transform(this,0);
              fVar17 = local_60;
              if ((lVar5 != null) &&
                 ((lVar5 = Transform.Find(lVar5,"RareLv",0), fVar17 = local_60, lVar5 != null &&
                  (plVar9 = (int64 *)Component.GetComponent(lVar5,DAT_181d6bc40), fVar17 = local_60,
                  plVar9 != (int64 *)0)))) {
                (**(code **)(*plVar9 + 0x408))(plVar9,*(uint64 *)(*plVar9 + 0x410));
                lVar5 = Component.get_transform(this,0);
                fVar17 = local_60;
                if (lVar5 != null) {
                  lVar5 = Transform.Find(lVar5,"RareLv",0);
                  fVar17 = local_60;
                  if (this.targetMission != null) {
                    iVar2 = this.targetMission.minForceLv;
                    puVar10 = (uint64 *)Vector3.get_one(local_48,0);
                    local_68 = *puVar10;
                    fVar17 = 0.45 - (float)iVar2 * 0.03;
                    local_60 = *(float *)(puVar10 + 1) * fVar17;
                    local_78 = CONCAT44((float)((uint64)local_68 >> 32) * fVar17,
                                        (float)local_68 * fVar17);
                    fVar17 = *(float *)(puVar10 + 1);
                    if (lVar5 != null) {
                      local_68 = local_78;
                      Transform.set_localScale(lVar5,&local_68,0);
                      lVar5 = Component.get_transform(this,0);
                      fVar17 = local_60;
                      if ((lVar5 != null) &&
                         (lVar5 = Transform.Find(lVar5,"Text",0), fVar17 = local_60) != null)
                      {
                        uVar8 = Component.GetComponent(lVar5,DAT_181d6d8c0);
                        lVar5 = this.targetMission;
                        fVar17 = local_60;
                        if (lVar5 != null) {
                          uVar11 = MissionData.GetMissionBaseDescribe(lVar5,0,0);
                          uVar12 = MissionData.GetMissionExtraDescribe
                                             (lVar5,0,0,0,in_stack_ffffffffffffff78 & 0xffffffffffffff00,0
                                             );
                          uVar11 = String.Concat(uVar11,uVar12,0);
                          LTLocalization.SetText(uVar8,uVar11,0);
                          lVar5 = Component.get_transform(this,0);
                          fVar17 = local_60;
                          if (((lVar5 != null) &&
                              (lVar5 = Transform.Find(lVar5,"ExtraInfo",0), fVar17 = local_60,
                              lVar5 != null)) &&
                             (uVar8 = Component.GetComponent(lVar5,DAT_181d6d8c0), fVar17 = local_60,
                             this.targetMission != null)) {
                            uVar11 = GlobalData.GetDifficultyStarString();
                            fVar17 = local_60;
                            if (this.targetMission != null) {
                              local_res18[0] = Mathf.RoundToInt(this.targetMission,0);
                              uVar12 = Int32.ToString(local_res18,0);
                              uVar11 = String.Concat("难度 ",uVar11,"   功绩 ",uVar12,0);
                              LTLocalization.SetText(uVar8,uVar11,0);
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
        LAB_180af4ecf:
        local_60 = fVar17;
    }

    // Token : 0x60018EA
    // RVA   : 0xAF4150   Offset: 0xAF2950   Length: 0xCC
    public void OnClick()
    {
        long lVar1;
        ulong uVar2;
        lVar1 = *(int64 *)(*(int64 *)(DAT_181d637f0 + 184) + 16);
        uVar2 = Component.get_gameObject(this,0);
        if (lVar1 != null) {
          MeetingController.MonthMissionButtonClicked(lVar1,uVar2,0);
          return;
        }
    }

    // Token : 0x60018EB
    // RVA   : 0x3A17B0   Offset: 0x39FFB0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_18044ef50(this,0);
    }

}
