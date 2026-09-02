// ============================================================
// Type  : PropertyReference
// Token : 0x2000090
// ============================================================

public class PropertyReference
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4000367
    private Component mTarget;

    // Token: 0x4000368
    private string mName;

    // Token: 0x4000369
    private FieldInfo mField;

    // Token: 0x400036A
    private PropertyInfo mProperty;

    // Token: 0x400036B
    private static int s_Hash;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x600042A
    // RVA   : 0x20F050   Offset: 0x20D850   Length: 0x5
    public Component get_target()
    {
        return this.mTarget;
    }

    // Token : 0x600042B
    // RVA   : 0xBDF2F0   Offset: 0xBDDAF0   Length: 0x3F
    public void set_target(Component value)
    {
        this.mTarget = value;
        this.mProperty = 0;
        this.mField = 0;
    }

    // Token : 0x600042C
    // RVA   : 0x20F140   Offset: 0x20D940   Length: 0x5
    public string get_name()
    {
        return this.mName;
    }

    // Token : 0x600042D
    // RVA   : 0xBDF2B0   Offset: 0xBDDAB0   Length: 0x3F
    public void set_name(string value)
    {
        this.mName = value;
        this.mProperty = 0;
        this.mField = 0;
    }

    // Token : 0x600042E
    // RVA   : 0xBDF220   Offset: 0xBDDA20   Length: 0x82
    public bool get_isValid()
    {
        ulong uVar1;
        bool cVar2;
        uVar1 = this.mTarget;
        cVar2 = Object.op_Inequality(uVar1,0,0);
        if (!cVar2) {
          return false;
        }
        cVar2 = FUN_180d6ca90(this.mName,0);
        return !cVar2;
    }

    // Token : 0x600042F
    // RVA   : 0xBDF100   Offset: 0xBDD900   Length: 0x116
    public bool get_isEnabled()
    {
        bool cVar3;
        ulong uVar4;
        uVar4 = this.mTarget;
        cVar3 = Object.op_Equality(uVar4,0,0);
        if (cVar3) {
          return false;
        }
        plVar1 = this.mTarget;
        if (plVar1 == (int64 *)0) {
          plVar5 = (int64 *)0;
        }
        else {
          plVar5 = plVar1;
        }
        cVar3 = Object.op_Equality(plVar5,0,0);
        if (cVar3) {
          return true;
        }
        if (plVar5 != (int64 *)0) {
          uVar4 = Behaviour.get_enabled(plVar5,0);
          return uVar4;
        }
    }

    // Token : 0x6000430
    // RVA   : 0x210B70   Offset: 0x20F370   Length: 0x7
    public void /*ctor*/()
    {
        ZhSegment.Initialize(this,0);
        this.mTarget = param_2;
        this.mName = param_3;
    }

    // Token : 0x6000431
    // RVA   : 0x20FA30   Offset: 0x20E230   Length: 0x4C
    public void /*ctor*/(Component target, string fieldName)
    {
        ZhSegment.Initialize(this,0);
        this.mTarget = target;
        this.mName = fieldName;
    }

    // Token : 0x6000432
    // RVA   : 0xBDE7C0   Offset: 0xBDCFC0   Length: 0x108
    public Type GetPropertyType()
    {
        ulong uVar2;
        bool cVar3;
        cVar3 = FUN_18026b630(this.mProperty,0,0);
        if (cVar3) {
          cVar3 = FUN_18026b630(this.mField,0,0);
          if (cVar3) {
            cVar3 = PropertyReference.get_isValid(this,0);
            if (cVar3) {
              PropertyReference.Cache(this,0);
            }
          }
        }
        cVar3 = FUN_180303780(this.mProperty,0,0);
        if (!cVar3) {
          cVar3 = FUN_180303780(this.mField,0,0);
          uVar2 = DAT_181da0250;
          if (!cVar3) {
            Type.GetTypeFromHandle(uVar2,0);
            return;
          }
          plVar1 = this.mField;
          if (plVar1 != (int64 *)0) {
                          // WARNING: Could not recover jumptable at 0x000180bde89d. Too many branches
                          // WARNING: Treating indirect jump as call
            (**(code **)(*plVar1 + 0x268))(plVar1,*(uint64 *)(*plVar1 + 0x270));
            return;
          }
        }
        else {
          plVar1 = this.mProperty;
          if (plVar1 != (int64 *)0) {
                          // WARNING: Could not recover jumptable at 0x000180bde8bc. Too many branches
                          // WARNING: Treating indirect jump as call
            (**(code **)(*plVar1 + 0x278))(plVar1,*(uint64 *)(*plVar1 + 0x280));
            return;
          }
        }
    }

    // Token : 0x6000433
    // RVA   : 0xBDE660   Offset: 0xBDCE60   Length: 0xF8
    public override bool Equals(object obj)
    {
        long lVar1;
        ulong uVar2;
        bool cVar3;
        byte uVar4;
        if (obj == (int64 *)0) {
          cVar3 = PropertyReference.get_isValid(this,0);
          return !cVar3;
        }
        if (*(byte *)(DAT_181d6e060 + 300) <= *(byte *)(*obj + 300)) {
          if (*(int64 *)
               (*(int64 *)(*obj + 200) + -8 + (uint64)*(byte *)(DAT_181d6e060 + 300) * 8) ==
              DAT_181d6e060) {
            lVar1 = obj[2];
            uVar2 = this.mTarget;
            cVar3 = Object.op_Equality(uVar2,lVar1,0);
            if (cVar3) {
              uVar4 = FUN_1816fd990(this.mName,obj[3],0);
              return (bool)uVar4;
            }
          }
        }
        return false;
    }

    // Token : 0x6000434
    // RVA   : 0xBDE760   Offset: 0xBDCF60   Length: 0x56
    public override int GetHashCode()
    {
        return **(uint32 **)(DAT_181d6e060 + 184);
    }

    // Token : 0x6000435
    // RVA   : 0xBDEDB0   Offset: 0xBDD5B0   Length: 0x36
    public void Set(Component target, string methodName)
    {
        ulong uVar1;
        bool cVar2;
        long lVar3;
        long lVar4;
        ulong uVar6;
        ulong uVar7;
        ulong uVar8;
        long local_res10;
        local_res10 = target;
        cVar2 = FUN_18026b630(this.mProperty,0,0);
        if (((cVar2) &&
            (cVar2 = FUN_18026b630(this.mField,0,0), cVar2)) &&
           (cVar2 = PropertyReference.get_isValid(this,0), cVar2)) {
          PropertyReference.Cache(this,0);
        }
        cVar2 = FUN_18026b630(this.mProperty,0,0);
        if ((cVar2) && (cVar2 = FUN_18026b630(this.mField,0,0), cVar2)
           ) {
          return 0;
        }
        if (local_res10 == 0) {
          cVar2 = FUN_180303780(this.mProperty,0,0);
          if (!cVar2) {
            if (this.mField == null) {
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            FieldInfo.SetValue(this.mField,this.mTarget,0,0);
            return 1;
          }
          plVar5 = this.mProperty;
          if (plVar5 == (int64 *)0) {
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          cVar2 = (**(code **)(*plVar5 + 0x268))(plVar5,*(uint64 *)(*plVar5 + 0x270));
          if (cVar2) {
            plVar5 = this.mProperty;
            if (plVar5 == (int64 *)0) {
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            (**(code **)(*plVar5 + 0x308))
                      (plVar5,this.mTarget,0,0,*(uint64 *)(*plVar5 + 0x310));
            return 1;
          }
        }
        uVar8 = this.mTarget;
        cVar2 = Object.op_Equality(uVar8,0,0);
        if (!cVar2) {
          lVar3 = PropertyReference.GetPropertyType(this,0);
          if (local_res10 == 0) {
            if (lVar3 == null) throw; // [null/range check failed]
            cVar2 = Type.get_IsClass(lVar3,0);
            lVar4 = lVar3;
            if (!cVar2) goto LAB_180bdecbe;
          }
          else {
            lVar4 = Object.GetType(local_res10,0);
          }
          cVar2 = PropertyReference.Convert(&local_res10,lVar4,lVar3,0);
          if (cVar2) {
            cVar2 = FUN_180303780(this.mField,0,0);
            if (!cVar2) {
              plVar5 = this.mProperty;
              if (plVar5 != (int64 *)0) {
                cVar2 = (**(code **)(*plVar5 + 0x268))(plVar5,*(uint64 *)(*plVar5 + 0x270));
                if (!cVar2) {
                  return 0;
                }
                if (this.mProperty != null) {
                  FUN_180004880(29,this.mProperty,this.mTarget,
                                local_res10,0);
                  return 1;
                }
              }
            }
            else if (this.mField != null) {
              FieldInfo.SetValue(this.mField,this.mTarget,
                                  local_res10,0);
              return 1;
            }
            throw; // [null/range check failed]
          }
        }
        LAB_180bdecbe:
        cVar2 = Application.get_isPlaying(0);
        if (!cVar2) {
          return 0;
        }
        if (local_res10 != 0) {
          plVar5 = (int64 *)Object.GetType(local_res10,0);
          uVar8 = "Unable to convert ";
          if (plVar5 == (int64 *)0) {
            uVar6 = 0;
          }
          else {
            uVar6 = (**(code **)(*plVar5 + 0x168))(plVar5,*(uint64 *)(*plVar5 + 0x170));
          }
          plVar5 = (int64 *)PropertyReference.GetPropertyType(this,0);
          uVar1 = " to ";
          uVar7 = 0;
          if (plVar5 != (int64 *)0) {
            uVar7 = (**(code **)(*plVar5 + 0x168))(plVar5,*(uint64 *)(*plVar5 + 0x170));
          }
          uVar8 = String.Concat(uVar8,uVar6,uVar1,uVar7,0);
          Debug.LogError(uVar8,0);
          return 0;
        }
    }

    // Token : 0x6000436
    // RVA   : 0xBDDB50   Offset: 0xBDC350   Length: 0x33
    public void Clear()
    {
        this.mTarget = 0;
        this.mName = 0;
    }

    // Token : 0x6000437
    // RVA   : 0xBDE9B0   Offset: 0xBDD1B0   Length: 0x33
    public void Reset()
    {
        this.mField = 0;
        this.mProperty = 0;
    }

    // Token : 0x6000438
    // RVA   : 0xBDEDF0   Offset: 0xBDD5F0   Length: 0x167
    public override string ToString()
    {
        bool cVar1;
        int iVar2;
        long lVar4;
        ulong uVar5;
        cVar1 = Object.op_Inequality(this,0,0);
        if (!cVar1) {
          return 0;
        }
        if (this != 0) {
          plVar3 = (int64 *)Object.GetType(this,0);
          if (plVar3 != (int64 *)0) {
            lVar4 = (**(code **)(*plVar3 + 0x168))(plVar3,*(uint64 *)(*plVar3 + 0x170));
            if (lVar4 != null) {
              iVar2 = String.LastIndexOf(lVar4,46,0);
              if (0 < iVar2) {
                lVar4 = String.Substring(lVar4,iVar2 + 1,0);
              }
              cVar1 = FUN_180d6ca90(param_2,0);
              if (cVar1) {
                uVar5 = String.Concat(lVar4,".[property]",0);
                return uVar5;
              }
              uVar5 = String.Concat(lVar4,".",param_2,0);
              return uVar5;
            }
          }
        }
    }

    // Token : 0x6000439
    // RVA   : 0xBDEF60   Offset: 0xBDD760   Length: 0x128
    public static string ToString(Component comp, string property)
    {
        bool cVar1;
        int iVar2;
        long lVar4;
        ulong uVar5;
        cVar1 = Object.op_Inequality(comp,0,0);
        if (!cVar1) {
          return 0;
        }
        if (comp != null) {
          plVar3 = (int64 *)Object.GetType(comp,0);
          if (plVar3 != (int64 *)0) {
            lVar4 = (**(code **)(*plVar3 + 0x168))(plVar3,*(uint64 *)(*plVar3 + 0x170));
            if (lVar4 != null) {
              iVar2 = String.LastIndexOf(lVar4,46,0);
              if (0 < iVar2) {
                lVar4 = String.Substring(lVar4,iVar2 + 1,0);
              }
              cVar1 = FUN_180d6ca90(property,0);
              if (cVar1) {
                uVar5 = String.Concat(lVar4,".[property]",0);
                return uVar5;
              }
              uVar5 = String.Concat(lVar4,".",property,0);
              return uVar5;
            }
          }
        }
    }

    // Token : 0x600043A
    // RVA   : 0xBDE8D0   Offset: 0xBDD0D0   Length: 0xDC
    public object Get()
    {
        bool cVar2;
        ulong uVar3;
        cVar2 = FUN_18026b630(this.mProperty,0,0);
        if (((cVar2) &&
            (cVar2 = FUN_18026b630(this.mField,0,0), cVar2)) &&
           (cVar2 = PropertyReference.get_isValid(this,0), cVar2)) {
          PropertyReference.Cache(this,0);
        }
        cVar2 = FUN_180303780(this.mProperty,0,0);
        if (!cVar2) {
          cVar2 = FUN_180303780(this.mField,0,0);
          if (!cVar2) {
            return 0;
          }
          plVar1 = this.mField;
          if (plVar1 != (int64 *)0) {
                          // WARNING: Could not recover jumptable at 0x000180bde955. Too many branches
                          // WARNING: Treating indirect jump as call
            uVar3 = (**(code **)(*plVar1 + 0x278))
                              (plVar1,this.mTarget,*(uint64 *)(*plVar1 + 0x280));
            return uVar3;
          }
        }
        else {
          plVar1 = this.mProperty;
          if (plVar1 != (int64 *)0) {
            cVar2 = (**(code **)(*plVar1 + 600))(plVar1,*(uint64 *)(*plVar1 + 0x260));
            if (!cVar2) {
              return 0;
            }
            plVar1 = this.mProperty;
            if (plVar1 != (int64 *)0) {
                          // WARNING: Could not recover jumptable at 0x000180bde9a0. Too many branches
                          // WARNING: Treating indirect jump as call
              uVar3 = (**(code **)(*plVar1 + 0x2e8))
                                (plVar1,this.mTarget,0,*(uint64 *)(*plVar1 + 0x2f0)
                                );
              return uVar3;
            }
          }
        }
    }

    // Token : 0x600043B
    // RVA   : 0xBDE9F0   Offset: 0xBDD1F0   Length: 0x3B0
    public bool Set(object value)
    {
        ulong uVar1;
        bool cVar2;
        long lVar3;
        long lVar4;
        ulong uVar6;
        ulong uVar7;
        ulong uVar8;
        long local_res10;
        local_res10 = value;
        cVar2 = FUN_18026b630(this.mProperty,0,0);
        if (((cVar2) &&
            (cVar2 = FUN_18026b630(this.mField,0,0), cVar2)) &&
           (cVar2 = PropertyReference.get_isValid(this,0), cVar2)) {
          PropertyReference.Cache(this,0);
        }
        cVar2 = FUN_18026b630(this.mProperty,0,0);
        if ((cVar2) && (cVar2 = FUN_18026b630(this.mField,0,0), cVar2)
           ) {
          return false;
        }
        if (local_res10 == 0) {
          cVar2 = FUN_180303780(this.mProperty,0,0);
          if (!cVar2) {
            if (this.mField == null) {
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            FieldInfo.SetValue(this.mField,this.mTarget,0,0);
            return true;
          }
          plVar5 = this.mProperty;
          if (plVar5 == (int64 *)0) {
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          cVar2 = (**(code **)(*plVar5 + 0x268))(plVar5,*(uint64 *)(*plVar5 + 0x270));
          if (cVar2) {
            plVar5 = this.mProperty;
            if (plVar5 == (int64 *)0) {
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            (**(code **)(*plVar5 + 0x308))
                      (plVar5,this.mTarget,0,0,*(uint64 *)(*plVar5 + 0x310));
            return true;
          }
        }
        uVar8 = this.mTarget;
        cVar2 = Object.op_Equality(uVar8,0,0);
        if (!cVar2) {
          lVar3 = PropertyReference.GetPropertyType(this,0);
          if (local_res10 == 0) {
            if (lVar3 == null) throw; // [null/range check failed]
            cVar2 = Type.get_IsClass(lVar3,0);
            lVar4 = lVar3;
            if (!cVar2) goto LAB_180bdecbe;
          }
          else {
            lVar4 = Object.GetType(local_res10,0);
          }
          cVar2 = PropertyReference.Convert(&local_res10,lVar4,lVar3,0);
          if (cVar2) {
            cVar2 = FUN_180303780(this.mField,0,0);
            if (!cVar2) {
              plVar5 = this.mProperty;
              if (plVar5 != (int64 *)0) {
                cVar2 = (**(code **)(*plVar5 + 0x268))(plVar5,*(uint64 *)(*plVar5 + 0x270));
                if (!cVar2) {
                  return false;
                }
                if (this.mProperty != null) {
                  FUN_180004880(29,this.mProperty,this.mTarget,
                                local_res10,0);
                  return true;
                }
              }
            }
            else if (this.mField != null) {
              FieldInfo.SetValue(this.mField,this.mTarget,
                                  local_res10,0);
              return true;
            }
            throw; // [null/range check failed]
          }
        }
        LAB_180bdecbe:
        cVar2 = Application.get_isPlaying(0);
        if (!cVar2) {
          return false;
        }
        if (local_res10 != 0) {
          plVar5 = (int64 *)Object.GetType(local_res10,0);
          uVar8 = "Unable to convert ";
          if (plVar5 == (int64 *)0) {
            uVar6 = 0;
          }
          else {
            uVar6 = (**(code **)(*plVar5 + 0x168))(plVar5,*(uint64 *)(*plVar5 + 0x170));
          }
          plVar5 = (int64 *)PropertyReference.GetPropertyType(this,0);
          uVar1 = " to ";
          uVar7 = 0;
          if (plVar5 != (int64 *)0) {
            uVar7 = (**(code **)(*plVar5 + 0x168))(plVar5,*(uint64 *)(*plVar5 + 0x170));
          }
          uVar8 = String.Concat(uVar8,uVar6,uVar1,uVar7,0);
          Debug.LogError(uVar8,0);
          return false;
        }
    }

    // Token : 0x600043C
    // RVA   : 0xBDDA20   Offset: 0xBDC220   Length: 0x12D
    private bool Cache()
    {
        bool cVar1;
        byte uVar2;
        long lVar3;
        ulong uVar4;
        uVar4 = this.mTarget;
        cVar1 = Object.op_Inequality(uVar4,0,0);
        if (cVar1) {
          cVar1 = FUN_180d6ca90(this.mName,0);
          if (!cVar1) {
            if (this.mTarget == null) {
        LAB_180bddb48:
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            lVar3 = Object.GetType(this.mTarget,0);
            if (lVar3 == null) goto LAB_180bddb48;
            uVar4 = Type.GetField(lVar3,this.mName,0);
            this.mField = uVar4;
            uVar4 = Type.GetProperty(lVar3,this.mName,0);
            goto LAB_180bddaf8;
          }
        }
        uVar4 = 0;
        this.mField = 0;
        LAB_180bddaf8:
        this.mProperty = uVar4;
        cVar1 = FUN_180303780(this.mField,0,0);
        if (cVar1) {
          return true;
        }
        uVar2 = FUN_180303780(this.mProperty,0,0);
        return uVar2;
    }

    // Token : 0x600043D
    // RVA   : 0xBDE4E0   Offset: 0xBDCCE0   Length: 0xFC
    private bool Convert(ref object value)
    {
        double dVar1;
        ulong uVar3;
        bool cVar4;
        ulong uVar5;
        long lVar7;
        double dVar11;
        float[] local_res10 = new float[2];
        float[] local_res18 = new float[4];
        float[] local_68 = new float[2];
        double local_60;
        double[] local_58 = new double[6];
        plVar10 = (int64 *)0;
        local_res10[0] = 0.0;
        local_58[0] = 0.0;
        local_res18[0] = 0.0;
        if (param_3 == (int64 *)0) {
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
        cVar4 = (**(code **)(*param_3 + 0x868))(param_3,value,*(uint64 *)(*param_3 + 0x870));
        uVar5 = DAT_181d9de30;
        if (cVar4) {
          return true;
        }
        uVar5 = Type.GetTypeFromHandle(uVar5,0);
        cVar4 = FUN_180295d70(param_3,uVar5,0);
        uVar5 = DAT_181d97908;
        plVar2 = (int64 *)*this;
        if (!cVar4) {
          if (plVar2 == (int64 *)0) goto LAB_180bddec1;
          uVar5 = Type.GetTypeFromHandle(uVar5,0);
          cVar4 = FUN_180295d70(param_3,uVar5,0);
          uVar3 = DAT_181d9de30;
          uVar5 = DAT_181d9c538;
          if (!cVar4) {
            uVar5 = Type.GetTypeFromHandle(uVar5,0);
            cVar4 = FUN_180295d70(param_3,uVar5,0);
            uVar3 = DAT_181d9de30;
            uVar5 = DAT_181d92e68;
            if (!cVar4) {
              uVar5 = Type.GetTypeFromHandle(uVar5,0);
              cVar4 = FUN_180295d70(param_3,uVar5,0);
              uVar5 = DAT_181d9de30;
              if (cVar4) {
                uVar5 = Type.GetTypeFromHandle(uVar5,0);
                cVar4 = FUN_180295d70(value,uVar5,0);
                uVar5 = DAT_181d9c538;
                if (!cVar4) {
                  uVar5 = Type.GetTypeFromHandle(uVar5,0);
                  cVar4 = FUN_180295d70(value,uVar5,0);
                  uVar5 = DAT_181d97908;
                  if (!cVar4) {
                    uVar5 = Type.GetTypeFromHandle(uVar5,0);
                    cVar4 = FUN_180295d70(value,uVar5,0);
                    if (!cVar4) goto LAB_180bddec1;
                    plVar10 = (int64 *)*this;
                    if (plVar10 == (int64 *)0) {
                          // WARNING: Subroutine does not return
                      FUN_1800d6620();
                    }
                    if (*(int64 *)(*plVar10 + 64) != *(int64 *)(DAT_181d5b2f8 + 64)) {
                          // WARNING: Subroutine does not return
                      FUN_1800d6070(plVar10,DAT_181d5b2f8);
                    }
                    piVar6 = (int *)il2cpp_object_unbox();
                    local_60 = (double)*piVar6;
                  }
                  else {
                    plVar10 = (int64 *)*this;
                    if (plVar10 == (int64 *)0) {
                          // WARNING: Subroutine does not return
                      FUN_1800d6620();
                    }
                    if (*(int64 *)(*plVar10 + 64) != *(int64 *)(DAT_181d7d0b8 + 64)) {
                          // WARNING: Subroutine does not return
                      FUN_1800d6070(plVar10,DAT_181d7d0b8);
                    }
                    pfVar8 = (float *)il2cpp_object_unbox();
                    local_60 = (double)*pfVar8;
                  }
                  pdVar9 = &local_60;
                  lVar7 = DAT_181d9cef8;
                  goto LAB_180bddeae;
                }
                plVar2 = (int64 *)*this;
                if (plVar2 != (int64 *)0) {
                  if (*plVar2 == DAT_181d82470) {
                    plVar10 = plVar2;
                  }
                  if (plVar10 == (int64 *)0) {
                          // WARNING: Subroutine does not return
                    FUN_1800d6070(plVar2);
                  }
                }
                cVar4 = Double.TryParse(plVar10,local_58,0);
                if (cVar4) {
                  local_60 = local_58[0];
                  lVar7 = il2cpp_value_box(DAT_181d9cef8,&local_60);
                  goto LAB_180bde372;
                }
              }
            }
            else {
              uVar5 = Type.GetTypeFromHandle(uVar3,0);
              cVar4 = FUN_180295d70(value,uVar5,0);
              uVar5 = DAT_181d92e68;
              if (!cVar4) {
                uVar5 = Type.GetTypeFromHandle(uVar5,0);
                cVar4 = FUN_180295d70(value,uVar5,0);
                uVar5 = DAT_181d97908;
                if (!cVar4) {
                  uVar5 = Type.GetTypeFromHandle(uVar5,0);
                  cVar4 = FUN_180295d70(value,uVar5,0);
                  if (!cVar4) goto LAB_180bddec1;
                  plVar10 = (int64 *)*this;
                  if (plVar10 == (int64 *)0) {
                          // WARNING: Subroutine does not return
                    FUN_1800d6620();
                  }
                  if (*(int64 *)(*plVar10 + 64) != *(int64 *)(DAT_181d5b2f8 + 64)) {
                          // WARNING: Subroutine does not return
                    FUN_1800d6070(plVar10,DAT_181d5b2f8);
                  }
                  piVar6 = (int *)il2cpp_object_unbox();
                  local_68[0] = (float)*piVar6;
                }
                else {
                  plVar10 = (int64 *)*this;
                  if (plVar10 == (int64 *)0) {
                          // WARNING: Subroutine does not return
                    FUN_1800d6620();
                  }
                  if (*(int64 *)(*plVar10 + 64) != *(int64 *)(DAT_181d9cef8 + 64)) {
                          // WARNING: Subroutine does not return
                    FUN_1800d6070(plVar10,DAT_181d9cef8);
                  }
                  pdVar9 = (double *)il2cpp_object_unbox();
                  local_68[0] = (float)*pdVar9;
                }
                pdVar9 = (double *)local_68;
                lVar7 = DAT_181d7d0b8;
        LAB_180bddeae:
                lVar7 = il2cpp_value_box(lVar7,pdVar9);
                *this = lVar7;
                il2cpp_internal(this,lVar7);
              }
              else {
                plVar2 = (int64 *)*this;
                if (plVar2 != (int64 *)0) {
                  if (*plVar2 == DAT_181d82470) {
                    plVar10 = plVar2;
                  }
                  if (plVar10 == (int64 *)0) {
                          // WARNING: Subroutine does not return
                    FUN_1800d6070();
                  }
                }
                cVar4 = Single.TryParse(plVar10,local_res10,0);
                if (cVar4) {
                  local_68[0] = local_res10[0];
                  lVar7 = il2cpp_value_box(DAT_181d7d0b8,local_68);
                  goto LAB_180bde372;
                }
              }
            }
          }
          else {
            uVar5 = Type.GetTypeFromHandle(uVar3,0);
            cVar4 = FUN_180295d70(value,uVar5,0);
            uVar5 = DAT_181d9c538;
            if (!cVar4) {
              uVar5 = Type.GetTypeFromHandle(uVar5,0);
              cVar4 = FUN_180295d70(value,uVar5,0);
              uVar5 = DAT_181d92e68;
              if (cVar4) {
                plVar10 = (int64 *)*this;
                if (plVar10 == (int64 *)0) {
                          // WARNING: Subroutine does not return
                  FUN_1800d6620();
                }
                if (*(int64 *)(*plVar10 + 64) != *(int64 *)(DAT_181d7d0b8 + 64)) {
                          // WARNING: Subroutine does not return
                  FUN_1800d6070(plVar10,DAT_181d7d0b8);
                }
                il2cpp_object_unbox();
                local_68[0] = (float)Mathf.RoundToInt();
        LAB_180bde33f:
                lVar7 = il2cpp_value_box(DAT_181d5b2f8,local_68);
                goto LAB_180bde372;
              }
              uVar5 = Type.GetTypeFromHandle(uVar5,0);
              cVar4 = FUN_180295d70(value,uVar5,0);
              if (cVar4) {
                plVar10 = (int64 *)*this;
                if (plVar10 == (int64 *)0) {
                          // WARNING: Subroutine does not return
                  FUN_1800d6620();
                }
                if (*(int64 *)(*plVar10 + 64) != *(int64 *)(DAT_181d9cef8 + 64)) {
                          // WARNING: Subroutine does not return
                  FUN_1800d6070(plVar10,DAT_181d9cef8);
                }
                pdVar9 = (double *)il2cpp_object_unbox(plVar10);
                dVar1 = *pdVar9;
                dVar11 = (double)FUN_1801e52d8();
                if (dVar1 < 0.0) {
                  if (dVar11 == -0.5) {
                    if (((int64)local_60 & 1U) != 0) {
                      local_60 = local_60 - 1.0;
                    }
                  }
                  else {
                    local_60 = ceil(dVar1 - 0.5);
                  }
                }
                else if (dVar11 == 0.5) {
                  if (((int64)local_60 & 1U) != 0) {
                    local_60 = local_60 + 1.0;
                  }
                }
                else {
                  local_60 = floor(dVar1 + 0.5);
                }
                local_68[0] = (float)(int)local_60;
                lVar7 = il2cpp_value_box(DAT_181d5b2f8,local_68);
                *this = lVar7;
                il2cpp_internal(this,lVar7);
              }
            }
            else {
              plVar2 = (int64 *)*this;
              if (plVar2 != (int64 *)0) {
                if (*plVar2 == DAT_181d82470) {
                  plVar10 = plVar2;
                }
                if (plVar10 == (int64 *)0) {
                          // WARNING: Subroutine does not return
                  FUN_1800d6070();
                }
              }
              cVar4 = Int32.TryParse(plVar10,local_res18,0);
              local_68[0] = local_res18[0];
              if (cVar4) goto LAB_180bde33f;
            }
          }
        LAB_180bddec1:
          uVar5 = 0;
        }
        else {
          lVar7 = "null";
          if (plVar2 != (int64 *)0) {
            lVar7 = (**(code **)(*plVar2 + 0x168))(plVar2,*(uint64 *)(*plVar2 + 0x170));
          }
        LAB_180bde372:
          *this = lVar7;
          il2cpp_internal(this,lVar7);
          uVar5 = 1;
        }
        return uVar5;
    }

    // Token : 0x600043E
    // RVA   : 0xBDE5E0   Offset: 0xBDCDE0   Length: 0x71
    public static bool Convert(Type from, Type to)
    {
        double dVar1;
        ulong uVar3;
        bool cVar4;
        ulong uVar5;
        long lVar7;
        double dVar11;
        float[] local_res10 = new float[2];
        float[] local_res18 = new float[4];
        float[] local_68 = new float[2];
        double local_60;
        double[] local_58 = new double[6];
        plVar10 = (int64 *)0;
        local_res10[0] = 0.0;
        local_58[0] = 0.0;
        local_res18[0] = 0.0;
        if (param_3 == (int64 *)0) {
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
        cVar4 = (**(code **)(*param_3 + 0x868))(param_3,to,*(uint64 *)(*param_3 + 0x870));
        uVar5 = DAT_181d9de30;
        if (cVar4) {
          return true;
        }
        uVar5 = Type.GetTypeFromHandle(uVar5,0);
        cVar4 = FUN_180295d70(param_3,uVar5,0);
        uVar5 = DAT_181d97908;
        plVar2 = (int64 *)*from;
        if (!cVar4) {
          if (plVar2 == (int64 *)0) goto LAB_180bddec1;
          uVar5 = Type.GetTypeFromHandle(uVar5,0);
          cVar4 = FUN_180295d70(param_3,uVar5,0);
          uVar3 = DAT_181d9de30;
          uVar5 = DAT_181d9c538;
          if (!cVar4) {
            uVar5 = Type.GetTypeFromHandle(uVar5,0);
            cVar4 = FUN_180295d70(param_3,uVar5,0);
            uVar3 = DAT_181d9de30;
            uVar5 = DAT_181d92e68;
            if (!cVar4) {
              uVar5 = Type.GetTypeFromHandle(uVar5,0);
              cVar4 = FUN_180295d70(param_3,uVar5,0);
              uVar5 = DAT_181d9de30;
              if (cVar4) {
                uVar5 = Type.GetTypeFromHandle(uVar5,0);
                cVar4 = FUN_180295d70(to,uVar5,0);
                uVar5 = DAT_181d9c538;
                if (!cVar4) {
                  uVar5 = Type.GetTypeFromHandle(uVar5,0);
                  cVar4 = FUN_180295d70(to,uVar5,0);
                  uVar5 = DAT_181d97908;
                  if (!cVar4) {
                    uVar5 = Type.GetTypeFromHandle(uVar5,0);
                    cVar4 = FUN_180295d70(to,uVar5,0);
                    if (!cVar4) goto LAB_180bddec1;
                    plVar10 = (int64 *)*from;
                    if (plVar10 == (int64 *)0) {
                          // WARNING: Subroutine does not return
                      FUN_1800d6620();
                    }
                    if (*(int64 *)(*plVar10 + 64) != *(int64 *)(DAT_181d5b2f8 + 64)) {
                          // WARNING: Subroutine does not return
                      FUN_1800d6070(plVar10,DAT_181d5b2f8);
                    }
                    piVar6 = (int *)il2cpp_object_unbox();
                    local_60 = (double)*piVar6;
                  }
                  else {
                    plVar10 = (int64 *)*from;
                    if (plVar10 == (int64 *)0) {
                          // WARNING: Subroutine does not return
                      FUN_1800d6620();
                    }
                    if (*(int64 *)(*plVar10 + 64) != *(int64 *)(DAT_181d7d0b8 + 64)) {
                          // WARNING: Subroutine does not return
                      FUN_1800d6070(plVar10,DAT_181d7d0b8);
                    }
                    pfVar8 = (float *)il2cpp_object_unbox();
                    local_60 = (double)*pfVar8;
                  }
                  pdVar9 = &local_60;
                  lVar7 = DAT_181d9cef8;
                  goto LAB_180bddeae;
                }
                plVar2 = (int64 *)*from;
                if (plVar2 != (int64 *)0) {
                  if (*plVar2 == DAT_181d82470) {
                    plVar10 = plVar2;
                  }
                  if (plVar10 == (int64 *)0) {
                          // WARNING: Subroutine does not return
                    FUN_1800d6070(plVar2);
                  }
                }
                cVar4 = Double.TryParse(plVar10,local_58,0);
                if (cVar4) {
                  local_60 = local_58[0];
                  lVar7 = il2cpp_value_box(DAT_181d9cef8,&local_60);
                  goto LAB_180bde372;
                }
              }
            }
            else {
              uVar5 = Type.GetTypeFromHandle(uVar3,0);
              cVar4 = FUN_180295d70(to,uVar5,0);
              uVar5 = DAT_181d92e68;
              if (!cVar4) {
                uVar5 = Type.GetTypeFromHandle(uVar5,0);
                cVar4 = FUN_180295d70(to,uVar5,0);
                uVar5 = DAT_181d97908;
                if (!cVar4) {
                  uVar5 = Type.GetTypeFromHandle(uVar5,0);
                  cVar4 = FUN_180295d70(to,uVar5,0);
                  if (!cVar4) goto LAB_180bddec1;
                  plVar10 = (int64 *)*from;
                  if (plVar10 == (int64 *)0) {
                          // WARNING: Subroutine does not return
                    FUN_1800d6620();
                  }
                  if (*(int64 *)(*plVar10 + 64) != *(int64 *)(DAT_181d5b2f8 + 64)) {
                          // WARNING: Subroutine does not return
                    FUN_1800d6070(plVar10,DAT_181d5b2f8);
                  }
                  piVar6 = (int *)il2cpp_object_unbox();
                  local_68[0] = (float)*piVar6;
                }
                else {
                  plVar10 = (int64 *)*from;
                  if (plVar10 == (int64 *)0) {
                          // WARNING: Subroutine does not return
                    FUN_1800d6620();
                  }
                  if (*(int64 *)(*plVar10 + 64) != *(int64 *)(DAT_181d9cef8 + 64)) {
                          // WARNING: Subroutine does not return
                    FUN_1800d6070(plVar10,DAT_181d9cef8);
                  }
                  pdVar9 = (double *)il2cpp_object_unbox();
                  local_68[0] = (float)*pdVar9;
                }
                pdVar9 = (double *)local_68;
                lVar7 = DAT_181d7d0b8;
        LAB_180bddeae:
                lVar7 = il2cpp_value_box(lVar7,pdVar9);
                *from = lVar7;
                il2cpp_internal(from,lVar7);
              }
              else {
                plVar2 = (int64 *)*from;
                if (plVar2 != (int64 *)0) {
                  if (*plVar2 == DAT_181d82470) {
                    plVar10 = plVar2;
                  }
                  if (plVar10 == (int64 *)0) {
                          // WARNING: Subroutine does not return
                    FUN_1800d6070();
                  }
                }
                cVar4 = Single.TryParse(plVar10,local_res10,0);
                if (cVar4) {
                  local_68[0] = local_res10[0];
                  lVar7 = il2cpp_value_box(DAT_181d7d0b8,local_68);
                  goto LAB_180bde372;
                }
              }
            }
          }
          else {
            uVar5 = Type.GetTypeFromHandle(uVar3,0);
            cVar4 = FUN_180295d70(to,uVar5,0);
            uVar5 = DAT_181d9c538;
            if (!cVar4) {
              uVar5 = Type.GetTypeFromHandle(uVar5,0);
              cVar4 = FUN_180295d70(to,uVar5,0);
              uVar5 = DAT_181d92e68;
              if (cVar4) {
                plVar10 = (int64 *)*from;
                if (plVar10 == (int64 *)0) {
                          // WARNING: Subroutine does not return
                  FUN_1800d6620();
                }
                if (*(int64 *)(*plVar10 + 64) != *(int64 *)(DAT_181d7d0b8 + 64)) {
                          // WARNING: Subroutine does not return
                  FUN_1800d6070(plVar10,DAT_181d7d0b8);
                }
                il2cpp_object_unbox();
                local_68[0] = (float)Mathf.RoundToInt();
        LAB_180bde33f:
                lVar7 = il2cpp_value_box(DAT_181d5b2f8,local_68);
                goto LAB_180bde372;
              }
              uVar5 = Type.GetTypeFromHandle(uVar5,0);
              cVar4 = FUN_180295d70(to,uVar5,0);
              if (cVar4) {
                plVar10 = (int64 *)*from;
                if (plVar10 == (int64 *)0) {
                          // WARNING: Subroutine does not return
                  FUN_1800d6620();
                }
                if (*(int64 *)(*plVar10 + 64) != *(int64 *)(DAT_181d9cef8 + 64)) {
                          // WARNING: Subroutine does not return
                  FUN_1800d6070(plVar10,DAT_181d9cef8);
                }
                pdVar9 = (double *)il2cpp_object_unbox(plVar10);
                dVar1 = *pdVar9;
                dVar11 = (double)FUN_1801e52d8();
                if (dVar1 < 0.0) {
                  if (dVar11 == -0.5) {
                    if (((int64)local_60 & 1U) != 0) {
                      local_60 = local_60 - 1.0;
                    }
                  }
                  else {
                    local_60 = ceil(dVar1 - 0.5);
                  }
                }
                else if (dVar11 == 0.5) {
                  if (((int64)local_60 & 1U) != 0) {
                    local_60 = local_60 + 1.0;
                  }
                }
                else {
                  local_60 = floor(dVar1 + 0.5);
                }
                local_68[0] = (float)(int)local_60;
                lVar7 = il2cpp_value_box(DAT_181d5b2f8,local_68);
                *from = lVar7;
                il2cpp_internal(from,lVar7);
              }
            }
            else {
              plVar2 = (int64 *)*from;
              if (plVar2 != (int64 *)0) {
                if (*plVar2 == DAT_181d82470) {
                  plVar10 = plVar2;
                }
                if (plVar10 == (int64 *)0) {
                          // WARNING: Subroutine does not return
                  FUN_1800d6070();
                }
              }
              cVar4 = Int32.TryParse(plVar10,local_res18,0);
              local_68[0] = local_res18[0];
              if (cVar4) goto LAB_180bde33f;
            }
          }
        LAB_180bddec1:
          uVar5 = 0;
        }
        else {
          lVar7 = "null";
          if (plVar2 != (int64 *)0) {
            lVar7 = (**(code **)(*plVar2 + 0x168))(plVar2,*(uint64 *)(*plVar2 + 0x170));
          }
        LAB_180bde372:
          *from = lVar7;
          il2cpp_internal(from,lVar7);
          uVar5 = 1;
        }
        return uVar5;
    }

    // Token : 0x600043F
    // RVA   : 0xBDE420   Offset: 0xBDCC20   Length: 0xBE
    public static bool Convert(object value, Type to)
    {
        double dVar1;
        ulong uVar3;
        bool cVar4;
        ulong uVar5;
        long lVar7;
        double dVar11;
        float[] local_res10 = new float[2];
        float[] local_res18 = new float[4];
        float[] local_68 = new float[2];
        double local_60;
        double[] local_58 = new double[6];
        plVar10 = (int64 *)0;
        local_res10[0] = 0.0;
        local_58[0] = 0.0;
        local_res18[0] = 0.0;
        if (param_3 == (int64 *)0) {
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
        cVar4 = (**(code **)(*param_3 + 0x868))(param_3,to,*(uint64 *)(*param_3 + 0x870));
        uVar5 = DAT_181d9de30;
        if (cVar4) {
          return true;
        }
        uVar5 = Type.GetTypeFromHandle(uVar5,0);
        cVar4 = FUN_180295d70(param_3,uVar5,0);
        uVar5 = DAT_181d97908;
        plVar2 = (int64 *)*value;
        if (!cVar4) {
          if (plVar2 == (int64 *)0) goto LAB_180bddec1;
          uVar5 = Type.GetTypeFromHandle(uVar5,0);
          cVar4 = FUN_180295d70(param_3,uVar5,0);
          uVar3 = DAT_181d9de30;
          uVar5 = DAT_181d9c538;
          if (!cVar4) {
            uVar5 = Type.GetTypeFromHandle(uVar5,0);
            cVar4 = FUN_180295d70(param_3,uVar5,0);
            uVar3 = DAT_181d9de30;
            uVar5 = DAT_181d92e68;
            if (!cVar4) {
              uVar5 = Type.GetTypeFromHandle(uVar5,0);
              cVar4 = FUN_180295d70(param_3,uVar5,0);
              uVar5 = DAT_181d9de30;
              if (cVar4) {
                uVar5 = Type.GetTypeFromHandle(uVar5,0);
                cVar4 = FUN_180295d70(to,uVar5,0);
                uVar5 = DAT_181d9c538;
                if (!cVar4) {
                  uVar5 = Type.GetTypeFromHandle(uVar5,0);
                  cVar4 = FUN_180295d70(to,uVar5,0);
                  uVar5 = DAT_181d97908;
                  if (!cVar4) {
                    uVar5 = Type.GetTypeFromHandle(uVar5,0);
                    cVar4 = FUN_180295d70(to,uVar5,0);
                    if (!cVar4) goto LAB_180bddec1;
                    plVar10 = (int64 *)*value;
                    if (plVar10 == (int64 *)0) {
                          // WARNING: Subroutine does not return
                      FUN_1800d6620();
                    }
                    if (*(int64 *)(*plVar10 + 64) != *(int64 *)(DAT_181d5b2f8 + 64)) {
                          // WARNING: Subroutine does not return
                      FUN_1800d6070(plVar10,DAT_181d5b2f8);
                    }
                    piVar6 = (int *)il2cpp_object_unbox();
                    local_60 = (double)*piVar6;
                  }
                  else {
                    plVar10 = (int64 *)*value;
                    if (plVar10 == (int64 *)0) {
                          // WARNING: Subroutine does not return
                      FUN_1800d6620();
                    }
                    if (*(int64 *)(*plVar10 + 64) != *(int64 *)(DAT_181d7d0b8 + 64)) {
                          // WARNING: Subroutine does not return
                      FUN_1800d6070(plVar10,DAT_181d7d0b8);
                    }
                    pfVar8 = (float *)il2cpp_object_unbox();
                    local_60 = (double)*pfVar8;
                  }
                  pdVar9 = &local_60;
                  lVar7 = DAT_181d9cef8;
                  goto LAB_180bddeae;
                }
                plVar2 = (int64 *)*value;
                if (plVar2 != (int64 *)0) {
                  if (*plVar2 == DAT_181d82470) {
                    plVar10 = plVar2;
                  }
                  if (plVar10 == (int64 *)0) {
                          // WARNING: Subroutine does not return
                    FUN_1800d6070(plVar2);
                  }
                }
                cVar4 = Double.TryParse(plVar10,local_58,0);
                if (cVar4) {
                  local_60 = local_58[0];
                  lVar7 = il2cpp_value_box(DAT_181d9cef8,&local_60);
                  goto LAB_180bde372;
                }
              }
            }
            else {
              uVar5 = Type.GetTypeFromHandle(uVar3,0);
              cVar4 = FUN_180295d70(to,uVar5,0);
              uVar5 = DAT_181d92e68;
              if (!cVar4) {
                uVar5 = Type.GetTypeFromHandle(uVar5,0);
                cVar4 = FUN_180295d70(to,uVar5,0);
                uVar5 = DAT_181d97908;
                if (!cVar4) {
                  uVar5 = Type.GetTypeFromHandle(uVar5,0);
                  cVar4 = FUN_180295d70(to,uVar5,0);
                  if (!cVar4) goto LAB_180bddec1;
                  plVar10 = (int64 *)*value;
                  if (plVar10 == (int64 *)0) {
                          // WARNING: Subroutine does not return
                    FUN_1800d6620();
                  }
                  if (*(int64 *)(*plVar10 + 64) != *(int64 *)(DAT_181d5b2f8 + 64)) {
                          // WARNING: Subroutine does not return
                    FUN_1800d6070(plVar10,DAT_181d5b2f8);
                  }
                  piVar6 = (int *)il2cpp_object_unbox();
                  local_68[0] = (float)*piVar6;
                }
                else {
                  plVar10 = (int64 *)*value;
                  if (plVar10 == (int64 *)0) {
                          // WARNING: Subroutine does not return
                    FUN_1800d6620();
                  }
                  if (*(int64 *)(*plVar10 + 64) != *(int64 *)(DAT_181d9cef8 + 64)) {
                          // WARNING: Subroutine does not return
                    FUN_1800d6070(plVar10,DAT_181d9cef8);
                  }
                  pdVar9 = (double *)il2cpp_object_unbox();
                  local_68[0] = (float)*pdVar9;
                }
                pdVar9 = (double *)local_68;
                lVar7 = DAT_181d7d0b8;
        LAB_180bddeae:
                lVar7 = il2cpp_value_box(lVar7,pdVar9);
                *value = lVar7;
                il2cpp_internal(value,lVar7);
              }
              else {
                plVar2 = (int64 *)*value;
                if (plVar2 != (int64 *)0) {
                  if (*plVar2 == DAT_181d82470) {
                    plVar10 = plVar2;
                  }
                  if (plVar10 == (int64 *)0) {
                          // WARNING: Subroutine does not return
                    FUN_1800d6070();
                  }
                }
                cVar4 = Single.TryParse(plVar10,local_res10,0);
                if (cVar4) {
                  local_68[0] = local_res10[0];
                  lVar7 = il2cpp_value_box(DAT_181d7d0b8,local_68);
                  goto LAB_180bde372;
                }
              }
            }
          }
          else {
            uVar5 = Type.GetTypeFromHandle(uVar3,0);
            cVar4 = FUN_180295d70(to,uVar5,0);
            uVar5 = DAT_181d9c538;
            if (!cVar4) {
              uVar5 = Type.GetTypeFromHandle(uVar5,0);
              cVar4 = FUN_180295d70(to,uVar5,0);
              uVar5 = DAT_181d92e68;
              if (cVar4) {
                plVar10 = (int64 *)*value;
                if (plVar10 == (int64 *)0) {
                          // WARNING: Subroutine does not return
                  FUN_1800d6620();
                }
                if (*(int64 *)(*plVar10 + 64) != *(int64 *)(DAT_181d7d0b8 + 64)) {
                          // WARNING: Subroutine does not return
                  FUN_1800d6070(plVar10,DAT_181d7d0b8);
                }
                il2cpp_object_unbox();
                local_68[0] = (float)Mathf.RoundToInt();
        LAB_180bde33f:
                lVar7 = il2cpp_value_box(DAT_181d5b2f8,local_68);
                goto LAB_180bde372;
              }
              uVar5 = Type.GetTypeFromHandle(uVar5,0);
              cVar4 = FUN_180295d70(to,uVar5,0);
              if (cVar4) {
                plVar10 = (int64 *)*value;
                if (plVar10 == (int64 *)0) {
                          // WARNING: Subroutine does not return
                  FUN_1800d6620();
                }
                if (*(int64 *)(*plVar10 + 64) != *(int64 *)(DAT_181d9cef8 + 64)) {
                          // WARNING: Subroutine does not return
                  FUN_1800d6070(plVar10,DAT_181d9cef8);
                }
                pdVar9 = (double *)il2cpp_object_unbox(plVar10);
                dVar1 = *pdVar9;
                dVar11 = (double)FUN_1801e52d8();
                if (dVar1 < 0.0) {
                  if (dVar11 == -0.5) {
                    if (((int64)local_60 & 1U) != 0) {
                      local_60 = local_60 - 1.0;
                    }
                  }
                  else {
                    local_60 = ceil(dVar1 - 0.5);
                  }
                }
                else if (dVar11 == 0.5) {
                  if (((int64)local_60 & 1U) != 0) {
                    local_60 = local_60 + 1.0;
                  }
                }
                else {
                  local_60 = floor(dVar1 + 0.5);
                }
                local_68[0] = (float)(int)local_60;
                lVar7 = il2cpp_value_box(DAT_181d5b2f8,local_68);
                *value = lVar7;
                il2cpp_internal(value,lVar7);
              }
            }
            else {
              plVar2 = (int64 *)*value;
              if (plVar2 != (int64 *)0) {
                if (*plVar2 == DAT_181d82470) {
                  plVar10 = plVar2;
                }
                if (plVar10 == (int64 *)0) {
                          // WARNING: Subroutine does not return
                  FUN_1800d6070();
                }
              }
              cVar4 = Int32.TryParse(plVar10,local_res18,0);
              local_68[0] = local_res18[0];
              if (cVar4) goto LAB_180bde33f;
            }
          }
        LAB_180bddec1:
          uVar5 = 0;
        }
        else {
          lVar7 = "null";
          if (plVar2 != (int64 *)0) {
            lVar7 = (**(code **)(*plVar2 + 0x168))(plVar2,*(uint64 *)(*plVar2 + 0x170));
          }
        LAB_180bde372:
          *value = lVar7;
          il2cpp_internal(value,lVar7);
          uVar5 = 1;
        }
        return uVar5;
    }

    // Token : 0x6000440
    // RVA   : 0xBDDB90   Offset: 0xBDC390   Length: 0x881
    public static bool Convert(ref object value, Type from, Type to)
    {
        double dVar1;
        ulong uVar3;
        bool cVar4;
        ulong uVar5;
        long lVar7;
        double dVar11;
        float[] local_res10 = new float[2];
        float[] local_res18 = new float[4];
        float[] local_68 = new float[2];
        double local_60;
        double[] local_58 = new double[6];
        plVar10 = (int64 *)0;
        local_res10[0] = 0.0;
        local_58[0] = 0.0;
        local_res18[0] = 0.0;
        if (to == (int64 *)0) {
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
        cVar4 = (**(code **)(*to + 0x868))(to,from,*(uint64 *)(*to + 0x870));
        uVar5 = DAT_181d9de30;
        if (cVar4) {
          return true;
        }
        uVar5 = Type.GetTypeFromHandle(uVar5,0);
        cVar4 = FUN_180295d70(to,uVar5,0);
        uVar5 = DAT_181d97908;
        plVar2 = (int64 *)*value;
        if (!cVar4) {
          if (plVar2 == (int64 *)0) goto LAB_180bddec1;
          uVar5 = Type.GetTypeFromHandle(uVar5,0);
          cVar4 = FUN_180295d70(to,uVar5,0);
          uVar3 = DAT_181d9de30;
          uVar5 = DAT_181d9c538;
          if (!cVar4) {
            uVar5 = Type.GetTypeFromHandle(uVar5,0);
            cVar4 = FUN_180295d70(to,uVar5,0);
            uVar3 = DAT_181d9de30;
            uVar5 = DAT_181d92e68;
            if (!cVar4) {
              uVar5 = Type.GetTypeFromHandle(uVar5,0);
              cVar4 = FUN_180295d70(to,uVar5,0);
              uVar5 = DAT_181d9de30;
              if (cVar4) {
                uVar5 = Type.GetTypeFromHandle(uVar5,0);
                cVar4 = FUN_180295d70(from,uVar5,0);
                uVar5 = DAT_181d9c538;
                if (!cVar4) {
                  uVar5 = Type.GetTypeFromHandle(uVar5,0);
                  cVar4 = FUN_180295d70(from,uVar5,0);
                  uVar5 = DAT_181d97908;
                  if (!cVar4) {
                    uVar5 = Type.GetTypeFromHandle(uVar5,0);
                    cVar4 = FUN_180295d70(from,uVar5,0);
                    if (!cVar4) goto LAB_180bddec1;
                    plVar10 = (int64 *)*value;
                    if (plVar10 == (int64 *)0) {
                          // WARNING: Subroutine does not return
                      FUN_1800d6620();
                    }
                    if (*(int64 *)(*plVar10 + 64) != *(int64 *)(DAT_181d5b2f8 + 64)) {
                          // WARNING: Subroutine does not return
                      FUN_1800d6070(plVar10,DAT_181d5b2f8);
                    }
                    piVar6 = (int *)il2cpp_object_unbox();
                    local_60 = (double)*piVar6;
                  }
                  else {
                    plVar10 = (int64 *)*value;
                    if (plVar10 == (int64 *)0) {
                          // WARNING: Subroutine does not return
                      FUN_1800d6620();
                    }
                    if (*(int64 *)(*plVar10 + 64) != *(int64 *)(DAT_181d7d0b8 + 64)) {
                          // WARNING: Subroutine does not return
                      FUN_1800d6070(plVar10,DAT_181d7d0b8);
                    }
                    pfVar8 = (float *)il2cpp_object_unbox();
                    local_60 = (double)*pfVar8;
                  }
                  pdVar9 = &local_60;
                  lVar7 = DAT_181d9cef8;
                  goto LAB_180bddeae;
                }
                plVar2 = (int64 *)*value;
                if (plVar2 != (int64 *)0) {
                  if (*plVar2 == DAT_181d82470) {
                    plVar10 = plVar2;
                  }
                  if (plVar10 == (int64 *)0) {
                          // WARNING: Subroutine does not return
                    FUN_1800d6070(plVar2);
                  }
                }
                cVar4 = Double.TryParse(plVar10,local_58,0);
                if (cVar4) {
                  local_60 = local_58[0];
                  lVar7 = il2cpp_value_box(DAT_181d9cef8,&local_60);
                  goto LAB_180bde372;
                }
              }
            }
            else {
              uVar5 = Type.GetTypeFromHandle(uVar3,0);
              cVar4 = FUN_180295d70(from,uVar5,0);
              uVar5 = DAT_181d92e68;
              if (!cVar4) {
                uVar5 = Type.GetTypeFromHandle(uVar5,0);
                cVar4 = FUN_180295d70(from,uVar5,0);
                uVar5 = DAT_181d97908;
                if (!cVar4) {
                  uVar5 = Type.GetTypeFromHandle(uVar5,0);
                  cVar4 = FUN_180295d70(from,uVar5,0);
                  if (!cVar4) goto LAB_180bddec1;
                  plVar10 = (int64 *)*value;
                  if (plVar10 == (int64 *)0) {
                          // WARNING: Subroutine does not return
                    FUN_1800d6620();
                  }
                  if (*(int64 *)(*plVar10 + 64) != *(int64 *)(DAT_181d5b2f8 + 64)) {
                          // WARNING: Subroutine does not return
                    FUN_1800d6070(plVar10,DAT_181d5b2f8);
                  }
                  piVar6 = (int *)il2cpp_object_unbox();
                  local_68[0] = (float)*piVar6;
                }
                else {
                  plVar10 = (int64 *)*value;
                  if (plVar10 == (int64 *)0) {
                          // WARNING: Subroutine does not return
                    FUN_1800d6620();
                  }
                  if (*(int64 *)(*plVar10 + 64) != *(int64 *)(DAT_181d9cef8 + 64)) {
                          // WARNING: Subroutine does not return
                    FUN_1800d6070(plVar10,DAT_181d9cef8);
                  }
                  pdVar9 = (double *)il2cpp_object_unbox();
                  local_68[0] = (float)*pdVar9;
                }
                pdVar9 = (double *)local_68;
                lVar7 = DAT_181d7d0b8;
        LAB_180bddeae:
                lVar7 = il2cpp_value_box(lVar7,pdVar9);
                *value = lVar7;
                il2cpp_internal(value,lVar7);
              }
              else {
                plVar2 = (int64 *)*value;
                if (plVar2 != (int64 *)0) {
                  if (*plVar2 == DAT_181d82470) {
                    plVar10 = plVar2;
                  }
                  if (plVar10 == (int64 *)0) {
                          // WARNING: Subroutine does not return
                    FUN_1800d6070();
                  }
                }
                cVar4 = Single.TryParse(plVar10,local_res10,0);
                if (cVar4) {
                  local_68[0] = local_res10[0];
                  lVar7 = il2cpp_value_box(DAT_181d7d0b8,local_68);
                  goto LAB_180bde372;
                }
              }
            }
          }
          else {
            uVar5 = Type.GetTypeFromHandle(uVar3,0);
            cVar4 = FUN_180295d70(from,uVar5,0);
            uVar5 = DAT_181d9c538;
            if (!cVar4) {
              uVar5 = Type.GetTypeFromHandle(uVar5,0);
              cVar4 = FUN_180295d70(from,uVar5,0);
              uVar5 = DAT_181d92e68;
              if (cVar4) {
                plVar10 = (int64 *)*value;
                if (plVar10 == (int64 *)0) {
                          // WARNING: Subroutine does not return
                  FUN_1800d6620();
                }
                if (*(int64 *)(*plVar10 + 64) != *(int64 *)(DAT_181d7d0b8 + 64)) {
                          // WARNING: Subroutine does not return
                  FUN_1800d6070(plVar10,DAT_181d7d0b8);
                }
                il2cpp_object_unbox();
                local_68[0] = (float)Mathf.RoundToInt();
        LAB_180bde33f:
                lVar7 = il2cpp_value_box(DAT_181d5b2f8,local_68);
                goto LAB_180bde372;
              }
              uVar5 = Type.GetTypeFromHandle(uVar5,0);
              cVar4 = FUN_180295d70(from,uVar5,0);
              if (cVar4) {
                plVar10 = (int64 *)*value;
                if (plVar10 == (int64 *)0) {
                          // WARNING: Subroutine does not return
                  FUN_1800d6620();
                }
                if (*(int64 *)(*plVar10 + 64) != *(int64 *)(DAT_181d9cef8 + 64)) {
                          // WARNING: Subroutine does not return
                  FUN_1800d6070(plVar10,DAT_181d9cef8);
                }
                pdVar9 = (double *)il2cpp_object_unbox(plVar10);
                dVar1 = *pdVar9;
                dVar11 = (double)FUN_1801e52d8();
                if (dVar1 < 0.0) {
                  if (dVar11 == -0.5) {
                    if (((int64)local_60 & 1U) != 0) {
                      local_60 = local_60 - 1.0;
                    }
                  }
                  else {
                    local_60 = ceil(dVar1 - 0.5);
                  }
                }
                else if (dVar11 == 0.5) {
                  if (((int64)local_60 & 1U) != 0) {
                    local_60 = local_60 + 1.0;
                  }
                }
                else {
                  local_60 = floor(dVar1 + 0.5);
                }
                local_68[0] = (float)(int)local_60;
                lVar7 = il2cpp_value_box(DAT_181d5b2f8,local_68);
                *value = lVar7;
                il2cpp_internal(value,lVar7);
              }
            }
            else {
              plVar2 = (int64 *)*value;
              if (plVar2 != (int64 *)0) {
                if (*plVar2 == DAT_181d82470) {
                  plVar10 = plVar2;
                }
                if (plVar10 == (int64 *)0) {
                          // WARNING: Subroutine does not return
                  FUN_1800d6070();
                }
              }
              cVar4 = Int32.TryParse(plVar10,local_res18,0);
              local_68[0] = local_res18[0];
              if (cVar4) goto LAB_180bde33f;
            }
          }
        LAB_180bddec1:
          uVar5 = 0;
        }
        else {
          lVar7 = "null";
          if (plVar2 != (int64 *)0) {
            lVar7 = (**(code **)(*plVar2 + 0x168))(plVar2,*(uint64 *)(*plVar2 + 0x170));
          }
        LAB_180bde372:
          *value = lVar7;
          il2cpp_internal(value,lVar7);
          uVar5 = 1;
        }
        return uVar5;
    }

    // Token : 0x6000441
    // RVA   : 0xBDF090   Offset: 0xBDD890   Length: 0x62
    private static void /*cctor*/()
    {
        uint uVar1;
        if ("PropertyBinding" != (int64 *)0) {
          uVar1 = (**(code **)(*"PropertyBinding" + 0x158))
                            ("PropertyBinding",*(uint64 *)(*"PropertyBinding" + 0x160));
          **(uint32 **)(DAT_181d6e060 + 184) = uVar1;
          return;
        }
    }

}
