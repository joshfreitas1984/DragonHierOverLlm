// ============================================================
// Type  : GridUnitData
// Token : 0x200018E
// ============================================================

public class GridUnitData
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4000AD7
    public int mapID;

    // Token: 0x4000AD8
    private GridType gridType;

    // Token: 0x4000AD9
    public BattleUnit battleUnit;

    // Token: 0x4000ADA
    public int passes;

    // Token: 0x4000ADB
    public int row;

    // Token: 0x4000ADC
    public int column;

    // Token: 0x4000ADD
    public ObstacleData obstale;

    // Token: 0x4000ADE
    public SpeGridObjData speGridObjData;

    // Token: 0x4000ADF
    public object tempRef;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000CAE
    // RVA   : 0x5ABFB0   Offset: 0x5AADB0   Length: 0xA0
    public void /*ctor*/(int mapID, int row, int column)
    {
        ulong uVar1;
        this.speGridObjData = new SpeGridObjData(0);
        ZhSegment.Initialize(this,0);
        this.row = row;
        this.column = column;
        this.gridType = 0;
        this.mapID = mapID;
    }

    // Token : 0x6000CAF
    // RVA   : 0x528F30   Offset: 0x527D30   Length: 0x4
    public GridType get_GridType()
    {
        return this.gridType;
    }

    // Token : 0x6000CB0
    // RVA   : 0x5AC3A0   Offset: 0x5AB1A0   Length: 0x21
    public void set_GridType(GridType value)
    {
        this.gridType = value;
        if ((value != null) && ((value == 1 || (value != 2)))) {
          this.passes = 15;
          return;
        }
        this.passes = 0;
    }

    // Token : 0x6000CB1
    // RVA   : 0x5AC050   Offset: 0x5AAE50   Length: 0x101
    public GameObject get_GridObj()
    {
        long lVar1;
        long lVar2;
        ulong uVar3;
        lVar1 = *(int64 *)(*(int64 *)(DAT_181e90420 + 184) + 80);
        if ((lVar1 == null) || (lVar1 = *(int64 *)(lVar1 + 0x100)) == null) {
                          // WARNING: Subroutine does not return
          FUN_1801e0300();
        }
        if (**(uint32 **)(lVar1 + 16) <= this.column) {
          uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
          FUN_1801e02d0(uVar3,0);
        }
        lVar2 = *(int64 *)(*(uint32 **)(lVar1 + 16) + 4);
        if (this.row < (uint32)lVar2) {
          return *(uint64 *)
                  (lVar1 + 32 +
                  ((int)this.column * lVar2 + (int64)(int)this.row) * 8)
          ;
        }
        uVar3 = il2cpp_internal();
    }

    // Token : 0x6000CB2
    // RVA   : 0x5AC160   Offset: 0x5AAF60   Length: 0x119
    public GridUnitController get_GridUnitController()
    {
        long lVar1;
        long lVar2;
        ulong uVar3;
        lVar1 = *(int64 *)(*(int64 *)(DAT_181e90420 + 184) + 80);
        if ((lVar1 != null) && (lVar1 = *(int64 *)(lVar1 + 0x100)) != null) {
          if (**(uint32 **)(lVar1 + 16) <= this.column) {
            uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1801e02d0(uVar3,0);
          }
          lVar2 = *(int64 *)(*(uint32 **)(lVar1 + 16) + 4);
          if ((uint32)lVar2 <= this.row) {
            uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1801e02d0(uVar3,0);
          }
          lVar1 = *(int64 *)
                   (lVar1 + 32 +
                   ((int)this.column * lVar2 + (int64)(int)this.row) * 8
                   );
          if (lVar1 != null) {
            GameObject.GetComponent(lVar1,DAT_181e548e8);
            return;
          }
        }
    }

    // Token : 0x6000CB3
    // RVA   : 0x5ABE20   Offset: 0x5AAC20   Length: 0x4D
    public int Distance(GridUnitData target)
    {
        int iVar1;
        int iVar2;
        if (target != null) {
          iVar1 = Mathf.Abs(*(int *)(target + 36) - this.row,0);
          iVar2 = Mathf.Abs(*(int *)(target + 40) - this.column,0);
          return iVar2 + iVar1;
        }
    }

    // Token : 0x6000CB4
    // RVA   : 0x5ABF30   Offset: 0x5AAD30   Length: 0x39
    public void OnEnter(BattleUnit battleUnit)
    {
        long lVar1;
        this.battleUnit = battleUnit;
        lVar1 = GridUnitData.get_GridUnitController(this,0);
        if (lVar1 != null) {
          GridUnitController.PlaySpeObjHitAnim(lVar1,0);
          return;
        }
    }

    // Token : 0x6000CB5
    // RVA   : 0x5ABF70   Offset: 0x5AAD70   Length: 0x3F
    public void OnLeave()
    {
        long lVar1;
        this.battleUnit = 0;
        lVar1 = GridUnitData.get_GridUnitController(this,0);
        if (lVar1 != null) {
          GridUnitController.PlaySpeObjHitAnim(lVar1,0);
          return;
        }
    }

    // Token : 0x6000CB6
    // RVA   : 0x5AC280   Offset: 0x5AB080   Length: 0x6E
    public bool isEmpty()
    {
        ulong uVar1;
        bool cVar2;
        if (this.gridType == 1) {
          uVar1 = this.battleUnit;
          cVar2 = Object.op_Equality(uVar1,0,0);
          if (cVar2) {
            if (!param_2) {
              return true;
            }
            if (this.speGridObjData != null) {
              return this.speGridObjData.speGridObjType == null;
            }
                          // WARNING: Subroutine does not return
            FUN_1801e0300();
          }
        }
        return false;
    }

    // Token : 0x6000CB7
    // RVA   : 0x5AC2F0   Offset: 0x5AB0F0   Length: 0xAE
    public bool isEmpty(bool includeSpeObj)
    {
        ulong uVar1;
        bool cVar2;
        if (this.gridType == 1) {
          uVar1 = this.battleUnit;
          cVar2 = Object.op_Equality(uVar1,0,0);
          if (cVar2) {
            if (!includeSpeObj) {
              return true;
            }
            if (this.speGridObjData != null) {
              return this.speGridObjData.speGridObjType == null;
            }
                          // WARNING: Subroutine does not return
            FUN_1801e0300();
          }
        }
        return false;
    }

    // Token : 0x6000CB8
    // RVA   : 0x5ABE70   Offset: 0x5AAC70   Length: 0xB4
    public override bool Equals(object obj)
    {
        long lVar1;
        ulong in_RAX;
        if (obj != (int64 *)0) {
          lVar1 = *obj;
          in_RAX = 0;
          if ((*(byte *)(DAT_181e54498 + 300) <= *(byte *)(lVar1 + 300)) &&
             (in_RAX = *(uint64 *)(lVar1 + 200),
             *(int64 *)((in_RAX - 8) + (uint64)*(byte *)(DAT_181e54498 + 300) * 8) == DAT_181e54498)
             ) {
            in_RAX = (uint64)this.mapID;
            if ((*(uint32 *)(obj + 2) == this.mapID) &&
               (in_RAX = (uint64)this.row,
               *(uint32 *)((int64)obj + 36) == this.row)) {
              return (uint64)
                     CONCAT31((int3)((uint32)this.column >> 8),
                              (int)obj[5] == this.column);
            }
          }
        }
        return in_RAX & 0xffffffffffffff00;
    }

}
