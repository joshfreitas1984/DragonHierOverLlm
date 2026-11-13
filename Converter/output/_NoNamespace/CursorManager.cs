// ============================================================
// Type  : CursorManager
// Token : 0x2000260
// ============================================================

public class CursorManager
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x40012FE
    public CursorType cursorType;

    // Token: 0x40012FF
    public Texture2D[] cursorTexture;

    // Token: 0x4001300
    private static CursorManager _instance;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60013A0
    // RVA   : 0x653530   Offset: 0x652330   Length: 0x36
    public static CursorManager get_Instance()
    {
        return **(uint64 **)(DAT_181e9b708 + 184);
    }

    // Token : 0x60013A1
    // RVA   : 0x6530E0   Offset: 0x651EE0   Length: 0x10C
    private void Awake()
    {
        bool cVar2;
        ulong uVar3;
        uVar3 = **(uint64 **)(DAT_181e9b708 + 184);
        cVar2 = Object.op_Equality(uVar3,0,0);
        if (!cVar2) {
          uVar3 = Component.get_gameObject(this,0);
          Object.Destroy(uVar3,0);
          return;
        }
        puVar1 = *(uint64 **)(DAT_181e9b708 + 184);
        *puVar1 = this;
        il2cpp_internal(puVar1,this);
        uVar3 = Component.get_gameObject(this,0);
        Object.DontDestroyOnLoad(uVar3,0);
    }

    // Token : 0x60013A2
    // RVA   : 0x653330   Offset: 0x652130   Length: 0x52
    private void Start()
    {
        long lVar1;
        ulong uVar2;
        ulong uVar3;
        lVar1 = this.cursorTexture;
        this.cursorType = 0;
        if (lVar1 == null) {
                          // WARNING: Subroutine does not return
          FUN_1801e0300();
        }
        if (*(int *)(lVar1 + 24) != 0) {
          uVar3 = *(uint64 *)(lVar1 + 32);
          uVar2 = Vector2.get_zero(0);
          Cursor.SetCursor(uVar3,uVar2,0,0);
          return;
        }
        uVar3 = il2cpp_internal();
    }

    // Token : 0x60013A3
    // RVA   : 0x653390   Offset: 0x652190   Length: 0x19D
    private void Update()
    {
        long lVar1;
        bool cVar2;
        ulong uVar3;
        ulong uVar4;
        if (this.cursorType != 1) {
          return;
        }
        cVar2 = Input.GetMouseButton(0,0);
        if (!cVar2) {
        LAB_1806534cd:
          cVar2 = Input.GetMouseButton(1);
          if (!cVar2) {
            return;
          }
        }
        else {
          uVar3 = MouseController.hoveredUI;
          cVar2 = Object.op_Equality(uVar3,0,0);
          if (!cVar2) {
            lVar1 = MouseController.hoveredUI;
            if (lVar1 == null) throw; // [null/range check failed]
            uVar3 = GameObject.GetComponent(lVar1,DAT_181e55168);
            cVar2 = Object.op_Equality(uVar3,0,0);
            if (!cVar2) goto LAB_1806534cd;
          }
        }
        this.cursorType = 0;
        lVar1 = this.cursorTexture;
        if (lVar1 != null) {
          if (*(int *)(lVar1 + 24) != 0) {
            uVar3 = *(uint64 *)(lVar1 + 32);
            uVar4 = Vector2.get_zero(0);
            Cursor.SetCursor(uVar3,uVar4,0,0);
            return;
          }
          uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
          FUN_1801e02d0(uVar3,0);
        }
    }

    // Token : 0x60013A4
    // RVA   : 0x653330   Offset: 0x652130   Length: 0x52
    public void Reset()
    {
        long lVar1;
        ulong uVar2;
        ulong uVar3;
        lVar1 = this.cursorTexture;
        this.cursorType = 0;
        if (lVar1 == null) {
                          // WARNING: Subroutine does not return
          FUN_1801e0300();
        }
        if (*(int *)(lVar1 + 24) != 0) {
          uVar3 = *(uint64 *)(lVar1 + 32);
          uVar2 = Vector2.get_zero(0);
          Cursor.SetCursor(uVar3,uVar2,0,0);
          return;
        }
        uVar3 = il2cpp_internal();
    }

    // Token : 0x60013A5
    // RVA   : 0x6531F0   Offset: 0x651FF0   Length: 0x8
    public void ChangeCursorType(CursorType changeType)
    {
        long lVar1;
        int iVar4;
        int iVar5;
        ulong uVar6;
        lVar1 = this.cursorTexture;
        this.cursorType = changeType;
        if (lVar1 != null) {
          if (*(uint32 *)(lVar1 + 24) <= changeType) {
            uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1801e02d0(uVar6,0);
          }
          plVar2 = lVar1[changeType];
          if (changeType == null) {
            uVar6 = Vector2.get_zero(0);
        LAB_1806532d9:
            Cursor.SetCursor(plVar2,uVar6,0,0);
            return;
          }
          if (plVar2 != (int64 *)0) {
            iVar4 = (**(code **)(*plVar2 + 0x178))(plVar2,*(uint64 *)(*plVar2 + 0x180));
            lVar1 = this.cursorTexture;
            if (lVar1 != null) {
              if (*(uint32 *)(lVar1 + 24) <= changeType) {
                uVar6 = il2cpp_internal(lVar1,iVar4);
                          // WARNING: Subroutine does not return
                FUN_1801e02d0(uVar6,0);
              }
              plVar3 = lVar1[changeType];
              if (plVar3 != (int64 *)0) {
                iVar5 = (**(code **)(*plVar3 + 0x198))(plVar3,*(uint64 *)(*plVar3 + 0x1a0));
                uVar6 = CONCAT44((float)iVar5 * 0.5,(float)iVar4 * 0.5);
                goto LAB_1806532d9;
              }
            }
          }
        }
    }

    // Token : 0x60013A6
    // RVA   : 0x653200   Offset: 0x652000   Length: 0x125
    public void ChangeCursorType(int changeType)
    {
        long lVar1;
        int iVar4;
        int iVar5;
        ulong uVar6;
        lVar1 = this.cursorTexture;
        this.cursorType = changeType;
        if (lVar1 != null) {
          if (*(uint32 *)(lVar1 + 24) <= changeType) {
            uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1801e02d0(uVar6,0);
          }
          plVar2 = lVar1[changeType];
          if (changeType == null) {
            uVar6 = Vector2.get_zero(0);
        LAB_1806532d9:
            Cursor.SetCursor(plVar2,uVar6,0,0);
            return;
          }
          if (plVar2 != (int64 *)0) {
            iVar4 = (**(code **)(*plVar2 + 0x178))(plVar2,*(uint64 *)(*plVar2 + 0x180));
            lVar1 = this.cursorTexture;
            if (lVar1 != null) {
              if (*(uint32 *)(lVar1 + 24) <= changeType) {
                uVar6 = il2cpp_internal(lVar1,iVar4);
                          // WARNING: Subroutine does not return
                FUN_1801e02d0(uVar6,0);
              }
              plVar3 = lVar1[changeType];
              if (plVar3 != (int64 *)0) {
                iVar5 = (**(code **)(*plVar3 + 0x198))(plVar3,*(uint64 *)(*plVar3 + 0x1a0));
                uVar6 = CONCAT44((float)iVar5 * 0.5,(float)iVar4 * 0.5);
                goto LAB_1806532d9;
              }
            }
          }
        }
    }

    // Token : 0x60013A7
    // RVA   : 0x2110A0   Offset: 0x20FEA0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_180ae8740(this,0);
    }

}
