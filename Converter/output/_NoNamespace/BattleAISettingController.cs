// ============================================================
// Type  : BattleAISettingController
// Token : 0x2000189
// ============================================================

public class BattleAISettingController
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4000A56
    public BattleUnit targetBattleUnit;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000C93
    // RVA   : 0x7F92F0   Offset: 0x7F7AF0   Length: 0xA20
    public void Init()
    {
        var pStatics_b128 = *(int64*)(DAT_181d8b128 + 184);
        var pStatics_e188 = *(int64*)(DAT_181d4e188 + 184);
        uint uVar1;
        ulong uVar2;
        long lVar3;
        bool cVar4;
        int iVar5;
        long lVar6;
        ulong uVar7;
        long lVar8;
        ulong uVar10;
        uint[] local_res18 = new uint[2];
        uint[] local_res20 = new uint[2];
        ulong local_58;
        uint local_50;
        ulong local_48;
        uint local_40;
        byte[] local_38 = new byte[16];
        byte[] local_28 = new byte[16];
        lVar6 = Component.get_transform(this,0);
        if ((lVar6 == null) || (lVar6 = Transform.Find(lVar6,"HeroIcon",0)) == null)
        throw; // [null/range check failed]
        uVar7 = Component.get_gameObject(lVar6,0);
        if (*pStatics_e188 == 0) throw; // [null/range check failed]
        uVar2 = *(uint64 *)(*pStatics_e188 + 144);
        lVar6 = GlobalData.AddChild(uVar7,uVar2,0);
        if (lVar6 == null) throw; // [null/range check failed]
        lVar8 = GameObject.GetComponent(lVar6,DAT_181d9fb20);
        if ((this.targetBattleUnit == null) || (lVar8 == null)) throw; // [null/range check failed]
        lVar8.hipPos = this.targetBattleUnit.heroData;
        lVar6 = GameObject.GetComponent(lVar6,DAT_181d9fb20);
        if (lVar6 == null) throw; // [null/range check failed]
        lVar6.skeleton = 0;
        lVar6 = Component.get_transform(this,0);
        if ((lVar6 == null) || (lVar6 = Transform.Find(lVar6,"Auto",0)) == null)
        throw; // [null/range check failed]
        lVar6 = Component.get_gameObject(lVar6,0);
        lVar8 = this.targetBattleUnit;
        uVar10 = *(uint64 *)(pStatics_b128 + 80);
        if (((uVar10 == 0) || (lVar8 == null)) || (lVar3 = lVar8.heroData) == null)
        throw; // [null/range check failed]
        if ((*(int *)(lVar3 + 88) == 0) || (*(char *)(lVar3 + 0x246) != false)) {
        LAB_1807f95b8:
          uVar10 = CONCAT71((int7)(uVar10 >> 8),1);
        }
        else {
          uVar1 = *(uint32 *)(uVar10 + 140);
          uVar10 = (uint64)uVar1;
          if (-1 < (int)uVar1) {
            if (lVar8.battleTeam == null) throw; // [null/range check failed]
            if (uVar1 == *(uint32 *)(lVar8.battleTeam + 16)) goto LAB_1807f95b8;
          }
          uVar10 = 0;
          cVar4 = HeroData.BattleControlable(lVar3,0);
          if (!cVar4) {
            uVar10 = uVar10 & 0xffffffffffffff00;
          }
          else {
            if (lVar8.battleTeam == null) throw; // [null/range check failed]
            uVar10 = (uint64)*(byte *)(lVar8.battleTeam + 20);
          }
        }
        if (lVar6 == null) throw; // [null/range check failed]
        GameObject.SetActive(lVar6,uVar10,0);
        lVar6 = Component.get_transform(this,0);
        local_res18[0] = 5;
        uVar7 = Int32.ToString(local_res18,0);
        if ((lVar6 == null) || (lVar6 = Transform.Find(lVar6,uVar7,0)) == null) throw; // [null/range check failed]
        lVar6 = Component.get_gameObject(lVar6,0);
        lVar8 = this.targetBattleUnit;
        uVar10 = *(uint64 *)(pStatics_b128 + 80);
        if (((uVar10 == 0) || (lVar8 == null)) || (lVar3 = lVar8.heroData) == null)
        throw; // [null/range check failed]
        if ((*(int *)(lVar3 + 88) == 0) || (*(char *)(lVar3 + 0x246) != false)) {
        LAB_1807f96d9:
          uVar10 = CONCAT71((int7)(uVar10 >> 8),1);
        }
        else {
          uVar1 = *(uint32 *)(uVar10 + 140);
          uVar10 = (uint64)uVar1;
          if (-1 < (int)uVar1) {
            if (lVar8.battleTeam == null) throw; // [null/range check failed]
            if (uVar1 == *(uint32 *)(lVar8.battleTeam + 16)) goto LAB_1807f96d9;
          }
          uVar10 = 0;
          cVar4 = HeroData.BattleControlable(lVar3,0);
          if (!cVar4) {
            uVar10 = uVar10 & 0xffffffffffffff00;
          }
          else {
            if (lVar8.battleTeam == null) throw; // [null/range check failed]
            uVar10 = (uint64)*(byte *)(lVar8.battleTeam + 20);
          }
        }
        if (lVar6 == null) throw; // [null/range check failed]
        GameObject.SetActive(lVar6,uVar10,0);
        lVar6 = Component.get_transform(this,0);
        if ((lVar6 == null) || (lVar6 = Transform.Find(lVar6,"Auto",0)) == null)
        throw; // [null/range check failed]
        lVar6 = Component.GetComponent(lVar6,DAT_181d6da40);
        if ((this.targetBattleUnit == null) || (lVar6 == null)) throw; // [null/range check failed]
        Toggle.set_isOn(lVar6,this.targetBattleUnit.autoFight,0);
        lVar6 = Component.get_transform(this,0);
        if (lVar6 == null) throw; // [null/range check failed]
        lVar6 = Transform.Find(lVar6,"MoveTabGrid",0);
        if (((this.targetBattleUnit == null) ||
            (lVar8 = this.targetBattleUnit.heroData) == null) ||
           (lVar8 = *(int64 *)(lVar8 + 0x2d0)) == null) throw; // [null/range check failed]
        if (lVar8.skeleton == null) {
          ThrowHelper.ThrowArgumentOutOfRangeException(0);
        }
        local_res18[0] = *(uint32 *)(*(int64 *)(lVar8 + 16) + 32);
        uVar7 = Int32.ToString(local_res18,0);
        if (((lVar6 == null) || (lVar6 = Transform.Find(lVar6,uVar7,0)) == null) ||
           (lVar6 = Component.GetComponent(lVar6,DAT_181d6da40)) == null) throw; // [null/range check failed]
        Toggle.set_isOn(lVar6,1,0);
        if ((this.targetBattleUnit == null) ||
           (lVar6 = this.targetBattleUnit.heroData) == null) throw; // [null/range check failed]
        if (lVar6.battleTeam == null) {
        LAB_1807f98c0:
          lVar6 = Component.get_transform(this,0);
          if (lVar6 == null) throw; // [null/range check failed]
          lVar6 = Transform.Find(lVar6,"MoveTabGrid",0);
          local_res18[0] = 3;
          uVar7 = Int32.ToString(local_res18,0);
          if (((lVar6 == null) || (lVar6 = Transform.Find(lVar6,uVar7,0)) == null) ||
             (lVar6 = Component.GetComponent(lVar6,DAT_181d6da40)) == null) throw; // [null/range check failed]
          Selectable.set_interactable(lVar6,0,0);
          lVar6 = Component.get_transform(this,0);
          if (lVar6 == null) throw; // [null/range check failed]
          lVar6 = Transform.Find(lVar6,"MoveTabGrid",0);
          local_res18[0] = 4;
          uVar7 = Int32.ToString(local_res18,0);
          if (((lVar6 == null) || (lVar6 = Transform.Find(lVar6,uVar7,0)) == null) ||
             (lVar6 = Component.GetComponent(lVar6,DAT_181d6da40)) == null) throw; // [null/range check failed]
          Selectable.set_interactable(lVar6,0,0);
        }
        else {
          lVar6 = *(int64 *)(pStatics_b128 + 80);
          if (lVar6 == null) throw; // [null/range check failed]
          cVar4 = BattleController.HavePlayerUnit(lVar6,0);
          if (!cVar4) goto LAB_1807f98c0;
        }
        lVar6 = Component.get_transform(this,0);
        if (lVar6 != null) {
          lVar6 = Transform.Find(lVar6,"AttackTabGrid",0);
          if (((this.targetBattleUnit != null) &&
              (lVar8 = this.targetBattleUnit.heroData) != null) &&
             (lVar8 = *(int64 *)(lVar8 + 0x2d0)) != null) {
            if (lVar8.skeleton < 2) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            local_res18[0] = *(uint32 *)(*(int64 *)(lVar8 + 16) + 36);
            uVar7 = Int32.ToString(local_res18,0);
            if (((lVar6 != null) && (lVar6 = Transform.Find(lVar6,uVar7,0)) != null) &&
               (lVar6 = Component.GetComponent(lVar6,DAT_181d6da40)) != null) {
              Toggle.set_isOn(lVar6,1,0);
              lVar6 = this.targetBattleUnit;
              local_res20[0] = 2;
              if (lVar6 != null) {
                while ((lVar6.heroData != null &&
                       (lVar6 = *(int64 *)(lVar6.heroData + 0x2d0)) != null)) {
                  if (lVar6.skeleton <= (int)local_res20[0]) {
                    return;
                  }
                  if (local_res20[0] == 3) {
                    lVar6 = FUN_18046bb80(0);
                    if (lVar6 == null) break;
                    if (lVar6.hipPos != null) goto LAB_1807f9b4e;
                    lVar6 = Component.get_transform(this,0);
                    uVar7 = Int32.ToString(local_res20,0);
                    if (lVar6 == null) break;
                    lVar6 = Transform.Find(lVar6,uVar7,0);
                    puVar9 = (uint64 *)Vector3.get_zero(local_38,0);
                    if (lVar6 == null) break;
                    local_58 = *puVar9;
                    puVar11 = &local_58;
                    local_50 = *(uint32 *)(puVar9 + 1);
                  }
                  else {
        LAB_1807f9b4e:
                    lVar6 = Component.get_transform(this,0);
                    uVar7 = Int32.ToString(local_res20,0);
                    if (lVar6 == null) break;
                    lVar6 = Transform.Find(lVar6,uVar7,0);
                    puVar9 = (uint64 *)Vector3.get_one(local_28,0);
                    if (lVar6 == null) break;
                    local_48 = *puVar9;
                    puVar11 = &local_48;
                    local_40 = *(uint32 *)(puVar9 + 1);
                  }
                  Transform.set_localScale(lVar6,puVar11,0);
                  lVar6 = Component.get_transform(this,0);
                  uVar7 = Int32.ToString(local_res20,0);
                  if (((lVar6 == null) || (lVar6 = Transform.Find(lVar6,uVar7,0)) == null) ||
                     (lVar6 = Component.GetComponent(lVar6,DAT_181d6da40)) == null) break;
                  cVar4 = *(char *)(lVar6 + 0x118);
                  if (((this.targetBattleUnit == null) ||
                      (lVar6 = this.targetBattleUnit.heroData) == null) ||
                     (lVar6 = *(int64 *)(lVar6 + 0x2d0)) == null) break;
                  iVar5 = FUN_1800d6750(lVar6,local_res20[0]);
                  if ((bool)cVar4 != (iVar5 == 1)) {
                    lVar6 = Component.get_transform(this,0);
                    uVar7 = Int32.ToString(local_res20,0);
                    if ((lVar6 == null) || (lVar6 = Transform.Find(lVar6,uVar7,0)) == null) break;
                    lVar6 = Component.GetComponent(lVar6,DAT_181d6da40);
                    if ((this.targetBattleUnit == null) ||
                       ((lVar8 = this.targetBattleUnit.heroData, lVar8 == null ||
                        (lVar8 = *(int64 *)(lVar8 + 0x2d0)) == null))) break;
                    iVar5 = FUN_1800d6750(lVar8,local_res20[0]);
                    if (lVar6 == null) break;
                    Toggle.set_isOn(lVar6,iVar5 == 1);
                  }
                  lVar6 = this.targetBattleUnit;
                  local_res20[0] = local_res20[0] + 1;
                  if (lVar6 == null) break;
                }
              }
            }
          }
        }
    }

    // Token : 0x6000C94
    // RVA   : 0x7F9010   Offset: 0x7F7810   Length: 0x99
    public void AutoButtonClicked()
    {
        long lVar1;
        long lVar2;
        lVar1 = this.targetBattleUnit;
        lVar2 = Component.get_transform(this,0);
        if (lVar2 != null) {
          lVar2 = Transform.Find(lVar2,"Auto",0);
          if (lVar2 != null) {
            lVar2 = Component.GetComponent(lVar2,DAT_181d6da40);
            if ((lVar2 != null) && (lVar1 != null)) {
              BattleUnit.ChangeAutoType(lVar1,*(uint8 *)(lVar2 + 0x118),0);
              return;
            }
          }
        }
    }

    // Token : 0x6000C95
    // RVA   : 0x7F9D20   Offset: 0x7F8520   Length: 0x1D2
    public void MoveTabGridChanged(GameObject buttonChanged)
    {
        ulong uVar1;
        bool cVar2;
        uint uVar3;
        long lVar4;
        ulong uVar5;
        if ((buttonChanged != null) && (lVar4 = GameObject.GetComponent(buttonChanged,DAT_181da2130)) != null) {
          if (*(char *)(lVar4 + 0x118) == false) {
            return;
          }
          if ((this.targetBattleUnit != null) &&
             (lVar4 = this.targetBattleUnit.heroData) != null) {
            lVar4 = *(int64 *)(lVar4 + 0x2d0);
            uVar5 = Object.get_name(buttonChanged,0);
            uVar3 = Int32.Parse(uVar5,0);
            if (lVar4 != null) {
              FUN_18181e970(lVar4,0,uVar3,DAT_181d68370);
              uVar5 = this.targetBattleUnit;
              lVar4 = *(int64 *)(*(int64 *)(DAT_181d8b128 + 184) + 80);
              if (lVar4 != null) {
                uVar1 = *(uint64 *)(lVar4 + 0x110);
                cVar2 = Object.op_Equality(uVar5,uVar1,0);
                if (cVar2) {
                  lVar4 = FUN_18046bb80(0);
                  if (lVar4 == null) throw; // [null/range check failed]
                  *(uint8 *)(lVar4 + 0x290) = 1;
                }
                return;
              }
            }
          }
        }
    }

    // Token : 0x6000C96
    // RVA   : 0x7F8E30   Offset: 0x7F7630   Length: 0x1D5
    public void AttackTabGridChanged(GameObject buttonChanged)
    {
        ulong uVar1;
        bool cVar2;
        uint uVar3;
        long lVar4;
        ulong uVar5;
        if ((buttonChanged != null) && (lVar4 = GameObject.GetComponent(buttonChanged,DAT_181da2130)) != null) {
          if (*(char *)(lVar4 + 0x118) == false) {
            return;
          }
          if ((this.targetBattleUnit != null) &&
             (lVar4 = this.targetBattleUnit.heroData) != null) {
            lVar4 = *(int64 *)(lVar4 + 0x2d0);
            uVar5 = Object.get_name(buttonChanged,0);
            uVar3 = Int32.Parse(uVar5,0);
            if (lVar4 != null) {
              FUN_18181e970(lVar4,1,uVar3,DAT_181d68370);
              uVar5 = this.targetBattleUnit;
              lVar4 = *(int64 *)(*(int64 *)(DAT_181d8b128 + 184) + 80);
              if (lVar4 != null) {
                uVar1 = *(uint64 *)(lVar4 + 0x110);
                cVar2 = Object.op_Equality(uVar5,uVar1,0);
                if (cVar2) {
                  lVar4 = FUN_18046bb80(0);
                  if (lVar4 == null) throw; // [null/range check failed]
                  *(uint8 *)(lVar4 + 0x290) = 1;
                }
                return;
              }
            }
          }
        }
    }

    // Token : 0x6000C97
    // RVA   : 0x7F90B0   Offset: 0x7F78B0   Length: 0x236
    public void AutoSettingButtonClicked(GameObject buttonClicked)
    {
        var pStatics = *(int64*)(DAT_181d8b128 + 184);
        long lVar1;
        ulong uVar2;
        bool cVar3;
        uint uVar4;
        ulong uVar5;
        long lVar6;
        if (((this.targetBattleUnit != null) &&
            (lVar1 = this.targetBattleUnit.heroData) != null) &&
           (lVar1 = *(int64 *)(lVar1 + 0x2d0), buttonClicked != null)) {
          uVar5 = Object.get_name(buttonClicked,0);
          uVar4 = Int32.Parse(uVar5,0);
          lVar6 = GameObject.GetComponent(buttonClicked,DAT_181da2130);
          if ((lVar6 != null) && (lVar1 != null)) {
            FUN_18181e970(lVar1,uVar4,*(char *)(lVar6 + 0x118) != false,DAT_181d68370);
            uVar5 = this.targetBattleUnit;
            lVar1 = *(int64 *)(pStatics + 80);
            if (lVar1 != null) {
              uVar2 = *(uint64 *)(lVar1 + 0x110);
              cVar3 = Object.op_Equality(uVar5,uVar2,0);
              if (cVar3) {
                lVar1 = *(int64 *)(pStatics + 80);
                if (lVar1 == null) throw; // [null/range check failed]
                *(uint8 *)(lVar1 + 0x290) = 1;
              }
              return;
            }
          }
        }
    }

    // Token : 0x6000C98
    // RVA   : 0x3A17B0   Offset: 0x39FFB0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_18044ef50(this,0);
    }

}
