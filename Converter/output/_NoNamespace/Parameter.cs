// ============================================================
// Type  : Parameter
// Token : 0x200007E
// ============================================================

public class Parameter
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x40002FD
    public object obj;

    // Token: 0x40002FE
    public string field;

    // Token: 0x40002FF
    private object mValue;

    // Token: 0x4000300
    public Type expectedType;

    // Token: 0x4000301
    public bool cached;

    // Token: 0x4000302
    public PropertyInfo propInfo;

    // Token: 0x4000303
    public FieldInfo fieldInfo;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000317
    // RVA   : 0x8C6D40   Offset: 0x8C5540   Length: 0x87
    public void /*ctor*/()
    {
        ulong uVar1;
        uVar1 = DAT_181da0250;
        uVar1 = Type.GetTypeFromHandle(uVar1,0);
        this.expectedType = uVar1;
        ZhSegment.Initialize(this,0);
        this.mValue = param_2;
    }

    // Token : 0x6000318
    // RVA   : 0x8C6BD0   Offset: 0x8C53D0   Length: 0xBF
    public void /*ctor*/(object obj, string field)
    {
        ulong uVar1;
        uVar1 = DAT_181da0250;
        uVar1 = Type.GetTypeFromHandle(uVar1,0);
        this.expectedType = uVar1;
        ZhSegment.Initialize(this,0);
        this.mValue = obj;
    }

    // Token : 0x6000319
    // RVA   : 0x8C6C90   Offset: 0x8C5490   Length: 0xA3
    public void /*ctor*/(object val)
    {
        ulong uVar1;
        uVar1 = DAT_181da0250;
        uVar1 = Type.GetTypeFromHandle(uVar1,0);
        this.expectedType = uVar1;
        ZhSegment.Initialize(this,0);
        this.mValue = val;
    }

    // Token : 0x600031A
    // RVA   : 0x8C6EB0   Offset: 0x8C56B0   Length: 0x27C
    public object get_value()
    {
        bool cVar2;
        long lVar3;
        ulong uVar4;
        lVar3 = this.mValue;
        if (lVar3 == null) {
          if (!this.cached) {
            this.cached = 1;
            this.fieldInfo = 0;
            this.propInfo = 0;
            uVar4 = this.obj;
            cVar2 = Object.op_Inequality(uVar4,0,0);
            if ((cVar2) &&
               (cVar2 = FUN_180d6ca90(this.field,0), !cVar2)) {
              if ((this.obj == null) ||
                 (lVar3 = Object.GetType(this.obj,0)) == null)
              goto LAB_1808c7127;
              uVar4 = Type.GetProperty(lVar3,this.field,0);
              this.propInfo = uVar4;
              cVar2 = FUN_18026b630(this.propInfo,0,0);
              if (cVar2) {
                uVar4 = Type.GetField(lVar3,this.field,0);
                this.fieldInfo = uVar4;
              }
            }
          }
          cVar2 = FUN_180303780(this.propInfo,0,0);
          if (!cVar2) {
            cVar2 = FUN_180303780(this.fieldInfo,0,0);
            uVar4 = this.obj;
            if (!cVar2) {
              cVar2 = Object.op_Inequality(uVar4,0,0);
              if (!cVar2) {
                uVar4 = this.expectedType;
                cVar2 = FUN_180295d80(uVar4,0,0);
                if (cVar2) {
                  if (this.expectedType == null) goto LAB_1808c7127;
                  cVar2 = FUN_180295af0(this.expectedType,0);
                  if (cVar2) {
                    return 0;
                  }
                }
                uVar4 = this.expectedType;
                lVar3 = Convert.ChangeType(0,uVar4,0);
              }
              else {
                lVar3 = this.obj;
              }
            }
            else {
              plVar1 = this.fieldInfo;
              if (plVar1 == (int64 *)0) goto LAB_1808c7127;
              lVar3 = (**(code **)(*plVar1 + 0x278))(plVar1,uVar4,*(uint64 *)(*plVar1 + 0x280));
            }
          }
          else {
            plVar1 = this.propInfo;
            if (plVar1 == (int64 *)0) {
        LAB_1808c7127:
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            lVar3 = (**(code **)(*plVar1 + 0x2e8))
                              (plVar1,this.obj,0,*(uint64 *)(*plVar1 + 0x2f0));
          }
        }
        return lVar3;
    }

    // Token : 0x600031B
    // RVA   : 0x22B3A0   Offset: 0x229BA0   Length: 0xC
    public void set_value(object value)
    {
        void FUN_18022b3a0(int64 this,uint64 value)
        {
        this.mValue = value;
    }

    // Token : 0x600031C
    // RVA   : 0x8C6DD0   Offset: 0x8C55D0   Length: 0xD3
    public Type get_type()
    {
        ulong uVar1;
        bool cVar2;
        long lVar3;
        lVar3 = this.mValue;
        if (lVar3 == null) {
          uVar1 = this.obj;
          cVar2 = Object.op_Equality(uVar1,0,0);
          uVar1 = DAT_181da0250;
          if (cVar2) {
            Type.GetTypeFromHandle(uVar1,0);
            return;
          }
          lVar3 = this.obj;
          if (lVar3 == null) {
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
        }
        Object.GetType(lVar3,0);
    }

}
