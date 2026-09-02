// ============================================================
// Type  : BattleTeam
// Token : 0x2000172
// ============================================================

public class BattleTeam
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x400097F
    public int ID;

    // Token: 0x4000980
    public bool havePlayer;

    // Token: 0x4000981
    public List<BattleUnit> battleUnits;

    // Token: 0x4000982
    public List<BattleUnit> needProtectUnits;

    // Token: 0x4000983
    public bool needProtectUnitDestroyed;

    // Token: 0x4000984
    public HeroSpeAddData teamSpeAddData;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000C0F
    // RVA   : 0x8E20F0   Offset: 0x8E08F0   Length: 0xE7
    public void /*ctor*/(int teamID)
    {
        ulong uVar1;
        uVar1 = il2cpp_internal(DAT_181d6c930);
        FUN_180f58a90(uVar1,DAT_181d58128);
        this.battleUnits = uVar1;
        uVar1 = il2cpp_internal(DAT_181d6c930);
        FUN_180f58a90(uVar1,DAT_181d58128);
        this.needProtectUnits = uVar1;
        this.teamSpeAddData = new HeroSpeAddData(0);
        ZhSegment.Initialize(this,0);
        this.ID = teamID;
    }

    // Token : 0x6000C10
    // RVA   : 0x8E1CD0   Offset: 0x8E04D0   Length: 0x91
    public void AddNeedProtectUnit(BattleUnit battleUnit)
    {
        bool cVar1;
        if (this.needProtectUnits != null) {
          cVar1 = FUN_1818279a0(this.needProtectUnits,battleUnit,DAT_181d582a8);
          if (!cVar1) {
            if (this.needProtectUnits == null) throw; // [null/range check failed]
            FUN_181827900(this.needProtectUnits,battleUnit,DAT_181d581a8);
          }
          if ((battleUnit != null) && (*(int64 *)(battleUnit + 64) != 0)) {
            *(uint8 *)(*(int64 *)(battleUnit + 64) + 0x244) = 1;
            return;
          }
        }
    }

    // Token : 0x6000C11
    // RVA   : 0x8E1B20   Offset: 0x8E0320   Length: 0x1AF
    public void AddBattleUnit(BattleUnit battleUnit)
    {
        long lVar2;
        bool cVar3;
        cVar3 = Object.op_Equality(battleUnit,0,0);
        if (cVar3) {
          return;
        }
        if (battleUnit != null) {
          plVar1 = *(int64 **)(battleUnit + 88);
          if (plVar1 != (int64 *)0) {
            cVar3 = (**(code **)(*plVar1 + 0x138))(plVar1,this,*(uint64 *)(*plVar1 + 0x140));
            if (cVar3) {
              return;
            }
            Debug.LogError("Add battle unit failed.Battle unit already joined a team.",0);
            return;
          }
          if (this.battleUnits != null) {
            cVar3 = FUN_1818279a0(this.battleUnits,battleUnit,DAT_181d582a8);
            if (cVar3) {
              return;
            }
            if (this.battleUnits != null) {
              FUN_181827900(this.battleUnits,battleUnit,DAT_181d581a8);
              lVar2 = *(int64 *)(battleUnit + 64);
              if (lVar2 != null) {
                if (*(char *)(lVar2 + 0x244) != false) {
                  if (*(int64 *)(lVar2 + 0x2d0) == 0) throw; // [null/range check failed]
                  FUN_18181e970(*(int64 *)(lVar2 + 0x2d0),0,1,DAT_181d68370);
                  BattleTeam.AddNeedProtectUnit(this,battleUnit,0);
                }
                *(int64 *)(battleUnit + 88) = this;
                return;
              }
            }
          }
        }
    }

    // Token : 0x6000C12
    // RVA   : 0x8E2000   Offset: 0x8E0800   Length: 0xEC
    public void RemoveBattleUnit(BattleUnit battleUnit)
    {
        bool cVar2;
        if (battleUnit != null) {
          plVar1 = *(int64 **)(battleUnit + 88);
          if (plVar1 != (int64 *)0) {
            cVar2 = (**(code **)(*plVar1 + 0x138))(plVar1,this,*(uint64 *)(*plVar1 + 0x140));
            if (cVar2) {
              if (this.battleUnits != null) {
                FUN_181801c10(this.battleUnits,battleUnit,DAT_181d58328);
                *(uint64 *)(battleUnit + 88) = 0;
                return;
              }
              throw; // [null/range check failed]
            }
          }
          Debug.LogError("Remove battle unit failed.",0);
          return;
        }
    }

    // Token : 0x6000C13
    // RVA   : 0x8E1F50   Offset: 0x8E0750   Length: 0xAC
    public void LeaveBattleField()
    {
        long lVar1;
        long lVar2;
        uint uVar3;
        lVar1 = this.battleUnits;
        uVar3 = 0;
        if (lVar1 != null) {
          lVar2 = 32;
          do {
            if (lVar1.Count <= (int)uVar3) {
              return;
            }
            if (lVar1 == null) break;
            if (lVar1.Count <= uVar3) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            lVar1 = *(int64 *)(lVar2 + lVar1._items);
            if (lVar1 == null) break;
            BattleUnit.LeaveBattleField(lVar1,0);
            lVar1 = this.battleUnits;
            uVar3 = uVar3 + 1;
            lVar2 = lVar2 + 8;
          } while (lVar1 != null);
        }
    }

    // Token : 0x6000C14
    // RVA   : 0x8E1D70   Offset: 0x8E0570   Length: 0x12D
    public void DestroySelf()
    {
        ulong uVar1;
        bool cVar2;
        long lVar3;
        uint uVar4;
        long lVar5;
        lVar5 = this.battleUnits;
        if (lVar5 != null) {
          uVar4 = lVar5.Count - 1;
          if (-1 < (int)uVar4) {
            lVar5 = (int64)(int)uVar4 * 8 + 32;
            do {
              lVar3 = this.battleUnits;
              if (lVar3 == null) throw; // [null/range check failed]
              if (lVar3.Count <= uVar4) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              uVar1 = *(uint64 *)(lVar5 + lVar3._items);
              cVar2 = Object.op_Inequality(uVar1,0,0);
              if (cVar2) {
                if (this.battleUnits == null) throw; // [null/range check failed]
                lVar3 = FUN_180002f80();
                if (lVar3 == null) throw; // [null/range check failed]
                BattleUnit.DestroySelf();
              }
              lVar5 = lVar5 + -8;
              uVar4 = uVar4 - 1;
            } while (-1 < (int)uVar4);
            lVar5 = this.battleUnits;
            if (lVar5 == null) throw; // [null/range check failed]
          }
          FUN_180f56130(lVar5,DAT_181d58228);
          return;
        }
    }

    // Token : 0x6000C15
    // RVA   : 0x8E1EA0   Offset: 0x8E06A0   Length: 0xA6
    public override bool Equals(object obj)
    {
        long lVar1;
        ulong in_RAX;
        if (obj != (int64 *)0) {
          lVar1 = *obj;
          in_RAX = 0;
          if ((*(byte *)(DAT_181d8b5a8 + 300) <= *(byte *)(lVar1 + 300)) &&
             (in_RAX = *(uint64 *)(lVar1 + 200),
             *(int64 *)((in_RAX - 8) + (uint64)*(byte *)(DAT_181d8b5a8 + 300) * 8) == DAT_181d8b5a8)
             ) {
            if ((*(byte *)(DAT_181d8b5a8 + 300) <= *(byte *)(lVar1 + 300)) &&
               (*(int64 *)
                 (*(int64 *)(lVar1 + 200) + -8 + (uint64)*(byte *)(DAT_181d8b5a8 + 300) * 8) ==
                DAT_181d8b5a8)) {
              return CONCAT71((int7)((uint64)*(int64 *)(lVar1 + 200) >> 8),
                              this.ID == (int)obj[2]);
            }
                          // WARNING: Subroutine does not return
            FUN_1800d6070(obj);
          }
        }
        return in_RAX & 0xffffffffffffff00;
    }

}
