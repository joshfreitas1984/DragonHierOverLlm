// ============================================================
// Type  : EventDelegate
// Token : 0x200007D
// ============================================================

public class EventDelegate
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x40002F2
    private MonoBehaviour mTarget;

    // Token: 0x40002F3
    private string mMethodName;

    // Token: 0x40002F4
    private Parameter[] mParameters;

    // Token: 0x40002F5
    public bool oneShot;

    // Token: 0x40002F6
    private Callback mCachedCallback;

    // Token: 0x40002F7
    private bool mRawDelegate;

    // Token: 0x40002F8
    private bool mCached;

    // Token: 0x40002F9
    private MethodInfo mMethod;

    // Token: 0x40002FA
    private ParameterInfo[] mParameterInfos;

    // Token: 0x40002FB
    private object[] mArgs;

    // Token: 0x40002FC
    private static int s_Hash;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60002F8
    // RVA   : 0x20F050   Offset: 0x20D850   Length: 0x5
    public MonoBehaviour get_target()
    {
        return this.mTarget;
    }

    // Token : 0x60002F9
    // RVA   : 0x938A80   Offset: 0x937280   Length: 0x62
    public void set_target(MonoBehaviour value)
    {
        this.mTarget = value;
        this.mCachedCallback = 0;
        this.mMethod = 0;
        this.mRawDelegate = 0;
        this.mParameterInfos = 0;
        this.mParameters = 0;
    }

    // Token : 0x60002FA
    // RVA   : 0x20F140   Offset: 0x20D940   Length: 0x5
    public string get_methodName()
    {
        return this.mMethodName;
    }

    // Token : 0x60002FB
    // RVA   : 0x938A10   Offset: 0x937210   Length: 0x62
    public void set_methodName(string value)
    {
        this.mMethodName = value;
        this.mCachedCallback = 0;
        this.mMethod = 0;
        this.mRawDelegate = 0;
        this.mParameterInfos = 0;
        this.mParameters = 0;
    }

    // Token : 0x60002FC
    // RVA   : 0x9389E0   Offset: 0x9371E0   Length: 0x2A
    public Parameter[] get_parameters()
    {
        if (!this.mCached) {
          EventDelegate.Cache(this,0);
          return this.mParameters;
        }
        return this.mParameters;
    }

    // Token : 0x60002FD
    // RVA   : 0x938930   Offset: 0x937130   Length: 0xA3
    public bool get_isValid()
    {
        ulong uVar1;
        bool cVar2;
        if (!this.mCached) {
          EventDelegate.Cache(this,0);
        }
        if ((this.mRawDelegate) && (this.mCachedCallback != null)) {
          return true;
        }
        uVar1 = this.mTarget;
        cVar2 = Object.op_Inequality(uVar1,0,0);
        if (!cVar2) {
          return false;
        }
        cVar2 = FUN_180d6ca90(this.mMethodName,0);
        return !cVar2;
    }

    // Token : 0x60002FE
    // RVA   : 0x938850   Offset: 0x937050   Length: 0xDB
    public bool get_isEnabled()
    {
        ulong uVar1;
        long lVar2;
        bool cVar3;
        byte uVar4;
        if (!this.mCached) {
          EventDelegate.Cache(this,0);
        }
        if ((!this.mRawDelegate) || (this.mCachedCallback == null)) {
          uVar1 = this.mTarget;
          cVar3 = Object.op_Equality(uVar1,0,0);
          if (cVar3) {
            return false;
          }
          lVar2 = this.mTarget;
          cVar3 = Object.op_Equality(lVar2,0,0);
          if (!cVar3) {
            if (lVar2 != null) {
              uVar4 = Behaviour.get_enabled(lVar2,0);
              return uVar4;
            }
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
        }
        return true;
    }

    // Token : 0x60002FF
    // RVA   : 0x210B70   Offset: 0x20F370   Length: 0x7
    public void /*ctor*/()
    {
        ZhSegment.Initialize(this,0);
        EventDelegate.Clear(this,0);
        this.mTarget = param_2;
        this.mMethodName = param_3;
    }

    // Token : 0x6000300
    // RVA   : 0x9387C0   Offset: 0x936FC0   Length: 0x2F
    public void /*ctor*/(Callback call)
    {
        ZhSegment.Initialize(this,0);
        EventDelegate.Clear(this,0);
        this.mTarget = call;
        this.mMethodName = param_3;
    }

    // Token : 0x6000301
    // RVA   : 0x9387F0   Offset: 0x936FF0   Length: 0x56
    public void /*ctor*/(MonoBehaviour target, string methodName)
    {
        ZhSegment.Initialize(this,0);
        EventDelegate.Clear(this,0);
        this.mTarget = target;
        this.mMethodName = methodName;
    }

    // Token : 0x6000302
    // RVA   : 0x937FB0   Offset: 0x9367B0   Length: 0x32
    private static string GetMethodName(Callback callback)
    {
        if (callback != null) {
          plVar1 = (int64 *)FUN_180f43200(callback,0);
          if (plVar1 != (int64 *)0) {
                          // WARNING: Could not recover jumptable at 0x000180937fd6. Too many branches
                          // WARNING: Treating indirect jump as call
            (**(code **)(*plVar1 + 0x1b8))(plVar1,*(uint64 *)(*plVar1 + 0x1c0));
            return;
          }
        }
    }

    // Token : 0x6000303
    // RVA   : 0x9380B0   Offset: 0x9368B0   Length: 0x28
    private static bool IsValid(Callback callback)
    {
        int iVar1;
        long lVar2;
        bool cVar3;
        uint uVar4;
        long lVar5;
        long lVar6;
        if (callback != null) {
          iVar1 = *(int *)(callback + 24);
          uVar4 = 0;
          if (0 < iVar1) {
            lVar5 = 32;
            lVar6 = 0;
            do {
              if (*(uint32 *)(callback + 24) <= uVar4) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              lVar2 = *(int64 *)(lVar5 + *(int64 *)(callback + 16));
              if ((lVar2 != null) && (cVar3 = EventDelegate.get_isValid(lVar2,0), cVar3)) {
                return true;
              }
              uVar4 = uVar4 + 1;
              lVar6 = lVar6 + 1;
              lVar5 = lVar5 + 8;
            } while (lVar6 < iVar1);
          }
        }
        return false;
    }

    // Token : 0x6000304
    // RVA   : 0x9373B0   Offset: 0x935BB0   Length: 0x22B
    public override bool Equals(object obj)
    {
        bool cVar3;
        byte uVar4;
        long lVar6;
        ulong uVar7;
        if (obj == (int64 *)0) {
          cVar3 = EventDelegate.get_isValid(this,0);
          return !cVar3;
        }
        lVar6 = *obj;
        plVar5 = (int64 *)0;
        plVar8 = plVar5;
        if (lVar6 == DAT_181d50fa8) {
          plVar8 = obj;
        }
        if (plVar8 == (int64 *)0) {
          if ((*(byte *)(DAT_181d9f758 + 300) <= *(byte *)(lVar6 + 300)) &&
             (*(int64 *)
               (*(int64 *)(lVar6 + 200) + -8 + (uint64)*(byte *)(DAT_181d9f758 + 300) * 8) ==
              DAT_181d9f758)) {
            uVar7 = this.mTarget;
            lVar6 = obj[2];
            cVar3 = Object.op_Equality(uVar7,lVar6,0);
            if (cVar3) {
              lVar6 = obj[3];
              uVar7 = this.mMethodName;
              goto LAB_1809374a5;
            }
          }
        }
        else {
          cVar3 = (**(code **)(*plVar8 + 0x138))
                            (plVar8,this.mCachedCallback,*(uint64 *)(*plVar8 + 0x140));
          if (cVar3) {
            return true;
          }
          plVar1 = (int64 *)plVar8[4];
          if (plVar1 != (int64 *)0) {
            if ((*(byte *)(*plVar1 + 300) < *(byte *)(DAT_181d65bf0 + 300)) ||
               (*(int64 *)
                 (*(int64 *)(*plVar1 + 200) + -8 + (uint64)*(byte *)(DAT_181d65bf0 + 300) * 8) !=
                DAT_181d65bf0)) {
              bVar2 = false;
            }
            else {
              bVar2 = true;
            }
            if (bVar2) {
              plVar5 = plVar1;
            }
          }
          uVar7 = this.mTarget;
          cVar3 = Object.op_Equality(uVar7,plVar5,0);
          if (cVar3) {
            uVar7 = this.mMethodName;
            plVar5 = (int64 *)FUN_180f43200(plVar8,0);
            if (plVar5 == (int64 *)0) {
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            lVar6 = (**(code **)(*plVar5 + 0x1b8))(plVar5,*(uint64 *)(*plVar5 + 0x1c0));
        LAB_1809374a5:
            uVar4 = FUN_1816fd990(uVar7,lVar6,0);
            return (bool)uVar4;
          }
        }
        return false;
    }

    // Token : 0x6000305
    // RVA   : 0x937F50   Offset: 0x936750   Length: 0x56
    public override int GetHashCode()
    {
        return **(uint32 **)(DAT_181d9f758 + 184);
    }

    // Token : 0x6000306
    // RVA   : 0x9382C0   Offset: 0x936AC0   Length: 0x1B4
    private void Set(Callback call)
    {
        if (this != 0) {
          FUN_180f56130(this,DAT_181d5e800);
          FUN_181827900(this,call,DAT_181d5e780);
        }
    }

    // Token : 0x6000307
    // RVA   : 0x9385B0   Offset: 0x936DB0   Length: 0x4C
    public void Set(MonoBehaviour target, string methodName)
    {
        if (this != 0) {
          FUN_180f56130(this,DAT_181d5e800);
          FUN_181827900(this,target,DAT_181d5e780);
        }
    }

    // Token : 0x6000308
    // RVA   : 0x936BE0   Offset: 0x9353E0   Length: 0x733
    private void Cache()
    {
        int iVar1;
        bool cVar4;
        ulong uVar6;
        ulong uVar8;
        long lVar9;
        long lVar10;
        uint uVar12;
        this.mCached = 1;
        if (this.mRawDelegate) {
          return;
        }
        if (this.mCachedCallback != null) {
          plVar5 = *(int64 **)(this.mCachedCallback + 32);
          uVar6 = this.mTarget;
          if (plVar5 == (int64 *)0) {
            plVar7 = (int64 *)0;
          }
          else {
            plVar7 = plVar5;
          }
          cVar4 = Object.op_Inequality(plVar7,uVar6,0);
          if (!cVar4) {
            lVar9 = this.mCachedCallback;
            if ((lVar9 == null) || (plVar5 = (int64 *)FUN_180f43200(lVar9,0), plVar5 == (int64 *)0))
            throw; // [null/range check failed]
            uVar6 = (**(code **)(*plVar5 + 0x1b8))(plVar5,*(uint64 *)(*plVar5 + 0x1c0));
            cVar4 = String.op_Inequality(uVar6,this.mMethodName,0);
            if (!cVar4) {
              return;
            }
          }
        }
        plVar5 = (int64 *)0;
        uVar6 = this.mTarget;
        cVar4 = Object.op_Inequality(uVar6,0,0);
        if (!cVar4) {
          return;
        }
        cVar4 = FUN_180d6ca90(this.mMethodName,0);
        if (cVar4) {
          return;
        }
        if (this.mTarget == null) throw; // [null/range check failed]
        plVar7 = (int64 *)Object.GetType(this.mTarget,0);
        this.mMethod = 0;
        while( true ) {
          cVar4 = FUN_180295d80(plVar7,0,0);
          if (!cVar4) break;
          if (plVar7 == (int64 *)0) {
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          uVar6 = Type.GetMethod(plVar7,this.mMethodName);
          this.mMethod = uVar6;
          cVar4 = MethodInfo.op_Inequality(this.mMethod,0);
          if (cVar4) break;
          plVar7 = (int64 *)(**(code **)(*plVar7 + 0x318))(plVar7);
        }
        cVar4 = MethodInfo.op_Equality(this.mMethod,0,0);
        if (cVar4) {
          uVar6 = this.mMethodName;
          if (this.mTarget != null) {
            plVar11 = (int64 *)Object.GetType(this.mTarget,0);
            uVar8 = "' on ";
            plVar7 = "Could not find method '";
            if (plVar11 != (int64 *)0) {
              plVar5 = (int64 *)
                       (**(code **)(*plVar11 + 0x168))(plVar11,*(uint64 *)(*plVar11 + 0x170));
            }
        LAB_180937270:
            uVar8 = String.Concat(plVar7,uVar6,uVar8,plVar5,0);
            uVar6 = this.mTarget;
            Debug.LogError(uVar8,uVar6,0);
            return;
          }
          throw; // [null/range check failed]
        }
        plVar7 = this.mMethod;
        if (plVar7 == (int64 *)0) throw; // [null/range check failed]
        uVar8 = (**(code **)(*plVar7 + 0x3c8))(plVar7,*(uint64 *)(*plVar7 + 0x3d0));
        uVar6 = DAT_181da0250;
        uVar6 = Type.GetTypeFromHandle(uVar6,0);
        cVar4 = FUN_180295d80(uVar8,uVar6,0);
        if (cVar4) {
          if (this.mTarget != null) {
            plVar7 = (int64 *)Object.GetType(this.mTarget,0);
            if (plVar7 != (int64 *)0) {
              plVar5 = (int64 *)(**(code **)(*plVar7 + 0x168))(plVar7,*(uint64 *)(*plVar7 + 0x170))
              ;
            }
            uVar8 = this.mMethodName;
            plVar7 = plVar5;
            uVar6 = ".";
            plVar5 = " must have a 'void' return type.";
            goto LAB_180937270;
          }
          throw; // [null/range check failed]
        }
        plVar7 = this.mMethod;
        if (plVar7 == (int64 *)0) throw; // [null/range check failed]
        lVar9 = (**(code **)(*plVar7 + 600))(plVar7,*(uint64 *)(*plVar7 + 0x260));
        this.mParameterInfos = lVar9;
        uVar6 = DAT_181d4f050;
        if (*plVar7 == 0) throw; // [null/range check failed]
        if (*(int64 *)(*plVar7 + 24) == 0) {
          uVar6 = Type.GetTypeFromHandle(uVar6,0);
          plVar7 = (int64 *)
                   Delegate.CreateDelegate
                             (uVar6,this.mTarget,this.mMethodName,0);
          if (plVar7 != (int64 *)0) {
            if (*plVar7 == DAT_181d50fa8) {
              plVar5 = plVar7;
            }
            if (plVar5 == (int64 *)0) {
                          // WARNING: Subroutine does not return
              FUN_1800d6070(plVar7,DAT_181d50fa8);
            }
          }
          this.mCachedCallback = plVar5;
          this.mArgs = 0;
          this.mParameters = 0;
          return;
        }
        this.mCachedCallback = 0;
        lVar9 = this.mParameters;
        lVar10 = *plVar7;
        if (lVar9 == null) {
          if (lVar10 == null) throw; // [null/range check failed]
        LAB_180936ff8:
          lVar9 = FUN_1800d60b0(DAT_181d82c40,*(uint32 *)(lVar10 + 24));
          *plVar11 = lVar9;
          il2cpp_internal(plVar11,lVar9);
          lVar9 = *plVar11;
          if (lVar9 == null) throw; // [null/range check failed]
          iVar1 = *(int *)(lVar9 + 24);
          plVar13 = plVar5;
          if (0 < iVar1) {
            do {
              plVar2 = (int64 *)*plVar11;
              lVar9 = new Parameter(0);
              if (plVar2 == (int64 *)0) throw; // [null/range check failed]
              if ((lVar9 != null) &&
                 (lVar10 = il2cpp_internal(lVar9,*(uint64 *)(*plVar2 + 64))) == null) {
                uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar6,0);
              }
              uVar12 = (uint32)plVar13;
              if (*(uint32 *)(plVar2 + 3) <= uVar12) {
                uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar6,0);
              }
              plVar2[(int64)(int)uVar12 + 4] = lVar9;
              il2cpp_internal();
              plVar13 = (int64 *)(uint64)(uVar12 + 1);
            } while ((int)(uVar12 + 1) < iVar1);
            lVar9 = this.mParameters;
          }
        }
        else {
          if (lVar10 == null) throw; // [null/range check failed]
          if (*(int *)(lVar9 + 24) != *(int *)(lVar10 + 24)) {
            lVar10 = *plVar7;
            goto LAB_180936ff8;
          }
        }
        if (lVar9 != null) {
          iVar1 = *(int *)(lVar9 + 24);
          if (iVar1 < 1) {
            return;
          }
          while (lVar9 = *plVar11) != null {
            uVar12 = (uint32)plVar5;
            if (*(uint32 *)(lVar9 + 24) <= uVar12) {
              uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar6,0);
            }
            lVar9 = lVar9[uVar12];
            lVar10 = *plVar7;
            if (lVar10 == null) break;
            if (*(uint32 *)(lVar10 + 24) <= uVar12) {
              uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar6,0);
            }
            plVar5 = lVar10[uVar12];
            if ((plVar5 == (int64 *)0) ||
               (uVar6 = (**(code **)(*plVar5 + 0x1b8))(plVar5,*(uint64 *)(*plVar5 + 0x1c0)),
               lVar9 == null)) break;
            *(uint64 *)(lVar9 + 40) = uVar6;
            plVar5 = (int64 *)(uint64)(uVar12 + 1);
            if (iVar1 <= (int)(uVar12 + 1)) {
              return;
            }
          }
        }
    }

    // Token : 0x6000309
    // RVA   : 0x937740   Offset: 0x935F40   Length: 0x80C
    public bool Execute()
    {
        long lVar1;
        long lVar2;
        uint uVar3;
        uVar3 = 0;
        if (this == 0) {
          return;
        }
        LAB_180937636:
        if ((int)this.mMethodName <= (int)uVar3) {
          return;
        }
        if (this.mMethodName <= uVar3) {
          ThrowHelper.ThrowArgumentOutOfRangeException(0);
        }
        lVar1 = this.mTarget[uVar3];
        if (lVar1 != null) goto code_r0x000180937662;
        goto LAB_180937727;
        code_r0x000180937662:
        EventDelegate.Execute(lVar1,0);
        if (this.mMethodName <= (int)uVar3) {
          return;
        }
        lVar2 = FUN_180002f80(this,uVar3,DAT_181d5ea00);
        if (lVar2 == lVar1) {
          if (*(char *)(lVar1 + 40) == false) {
        LAB_180937727:
            uVar3 = uVar3 + 1;
          }
          else {
            FUN_18182b220(this,uVar3,DAT_181d5e900);
          }
        }
        goto LAB_180937636;
    }

    // Token : 0x600030A
    // RVA   : 0x937320   Offset: 0x935B20   Length: 0x83
    public void Clear()
    {
        this.mTarget = 0;
        this.mMethodName = 0;
        this.mCachedCallback = 0;
        this.mRawDelegate = 0;
        this.mParameters = 0;
        this.mMethod = 0;
        this.mCached = 0;
        this.mParameterInfos = 0;
        this.mArgs = 0;
    }

    // Token : 0x600030B
    // RVA   : 0x938600   Offset: 0x936E00   Length: 0x143
    public override string ToString()
    {
        bool cVar1;
        int iVar2;
        long lVar4;
        ulong uVar5;
        uVar5 = this.mTarget;
        cVar1 = Object.op_Inequality(uVar5,0,0);
        if (!cVar1) {
          uVar5 = 0;
          if (this.mRawDelegate) {
            uVar5 = "[delegate]";
          }
          return uVar5;
        }
        if (this.mTarget != null) {
          plVar3 = (int64 *)Object.GetType(this.mTarget,0);
          if (plVar3 != (int64 *)0) {
            lVar4 = (**(code **)(*plVar3 + 0x168))(plVar3,*(uint64 *)(*plVar3 + 0x170));
            if (lVar4 != null) {
              iVar2 = String.LastIndexOf(lVar4,46,0);
              if (0 < iVar2) {
                lVar4 = String.Substring(lVar4,iVar2 + 1,0);
              }
              cVar1 = FUN_180d6ca90(this.mMethodName,0);
              if (cVar1) {
                uVar5 = String.Concat(lVar4,"/[delegate]",0);
                return uVar5;
              }
              uVar5 = String.Concat(lVar4,"/",this.mMethodName,0);
              return uVar5;
            }
          }
        }
    }

    // Token : 0x600030C
    // RVA   : 0x9375E0   Offset: 0x935DE0   Length: 0x15B
    public static void Execute(List<EventDelegate> list)
    {
        long lVar1;
        long lVar2;
        uint uVar3;
        uVar3 = 0;
        if (list == null) {
          return;
        }
        LAB_180937636:
        if ((int)*(uint32 *)(list + 24) <= (int)uVar3) {
          return;
        }
        if (*(uint32 *)(list + 24) <= uVar3) {
          ThrowHelper.ThrowArgumentOutOfRangeException(0);
        }
        lVar1 = list[uVar3];
        if (lVar1 != null) goto code_r0x000180937662;
        goto LAB_180937727;
        code_r0x000180937662:
        EventDelegate.Execute(lVar1,0);
        if (*(int *)(list + 24) <= (int)uVar3) {
          return;
        }
        lVar2 = FUN_180002f80(list,uVar3,DAT_181d5ea00);
        if (lVar2 == lVar1) {
          if (*(char *)(lVar1 + 40) == false) {
        LAB_180937727:
            uVar3 = uVar3 + 1;
          }
          else {
            FUN_18182b220(list,uVar3,DAT_181d5e900);
          }
        }
        goto LAB_180937636;
    }

    // Token : 0x600030D
    // RVA   : 0x937FF0   Offset: 0x9367F0   Length: 0xB2
    public static bool IsValid(List<EventDelegate> list)
    {
        int iVar1;
        long lVar2;
        bool cVar3;
        uint uVar4;
        long lVar5;
        long lVar6;
        if (list != null) {
          iVar1 = *(int *)(list + 24);
          uVar4 = 0;
          if (0 < iVar1) {
            lVar5 = 32;
            lVar6 = 0;
            do {
              if (*(uint32 *)(list + 24) <= uVar4) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              lVar2 = *(int64 *)(lVar5 + *(int64 *)(list + 16));
              if ((lVar2 != null) && (cVar3 = EventDelegate.get_isValid(lVar2,0), cVar3)) {
                return true;
              }
              uVar4 = uVar4 + 1;
              lVar6 = lVar6 + 1;
              lVar5 = lVar5 + 8;
            } while (lVar6 < iVar1);
          }
        }
        return false;
    }

    // Token : 0x600030E
    // RVA   : 0x9384F0   Offset: 0x936CF0   Length: 0xB6
    public static EventDelegate Set(List<EventDelegate> list, Callback callback)
    {
        if (list != null) {
          FUN_180f56130(list,DAT_181d5e800);
          FUN_181827900(list,callback,DAT_181d5e780);
        }
    }

    // Token : 0x600030F
    // RVA   : 0x938480   Offset: 0x936C80   Length: 0x69
    public static void Set(List<EventDelegate> list, EventDelegate del)
    {
        if (list != null) {
          FUN_180f56130(list,DAT_181d5e800);
          FUN_181827900(list,del,DAT_181d5e780);
        }
    }

    // Token : 0x6000310
    // RVA   : 0x9369E0   Offset: 0x9351E0   Length: 0x65
    public static EventDelegate Add(List<EventDelegate> list, Callback callback)
    {
        int iVar1;
        ulong uVar3;
        ulong uVar4;
        bool cVar5;
        ulong uVar6;
        long lVar7;
        uint uVar8;
        uint uVar9;
        long lVar10;
        long lVar11;
        if (callback == null) {
        LAB_180936926:
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
        if (*(char *)(callback + 56) == false) {
          uVar6 = *(uint64 *)(callback + 16);
          cVar5 = Object.op_Equality(uVar6,0,0);
          if ((!cVar5) && (cVar5 = FUN_180d6ca90(*(uint64 *)(callback + 24),0), !cVar5)
             ) {
            if (list == null) {
              Debug.LogWarning("Attempting to add a callback to a list that's null",0);
              return;
            }
            iVar1 = *(int *)(list + 24);
            uVar9 = 0;
            uVar8 = 0;
            if (0 < iVar1) {
              lVar11 = 32;
              lVar10 = 0;
              do {
                if (*(uint32 *)(list + 24) <= uVar8) {
                  ThrowHelper.ThrowArgumentOutOfRangeException(0);
                }
                plVar2 = *(int64 **)(lVar11 + *(int64 *)(list + 16));
                if ((plVar2 != (int64 *)0) &&
                   (cVar5 = (**(code **)(*plVar2 + 0x138))
                                      (plVar2,callback,*(uint64 *)(*plVar2 + 0x140)), cVar5)) {
                  return;
                }
                uVar8 = uVar8 + 1;
                lVar10 = lVar10 + 1;
                lVar11 = lVar11 + 8;
              } while (lVar10 < iVar1);
            }
            uVar6 = *(uint64 *)(callback + 16);
            uVar3 = *(uint64 *)(callback + 24);
            lVar10 = new ZhSegment(0);
            EventDelegate.Clear(lVar10,0);
            *(uint64 *)(lVar10 + 16) = uVar6;
            *(uint64 *)(lVar10 + 24) = uVar3;
            *(uint8 *)(lVar10 + 40) = param_3;
            if ((*(int64 *)(callback + 32) == 0) ||
               (uVar4 = *(uint64 *)(*(int64 *)(callback + 32) + 24)) == null) {
        LAB_1809368d6:
              FUN_181827900(list,lVar10,DAT_181d5e780);
              return;
            }
            uVar6 = FUN_1800d60b0(DAT_181d82c40,uVar4 & 0xffffffff);
            *(uint64 *)(lVar10 + 32) = uVar6;
            while (lVar11 = *(int64 *)(callback + 32)) != null {
              if ((int)*(uint32 *)(lVar11 + 24) <= (int)uVar9) goto LAB_1809368d6;
              plVar2 = *(int64 **)(lVar10 + 32);
              if (*(uint32 *)(lVar11 + 24) <= uVar9) {
                uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar6,0);
              }
              lVar11 = lVar11[uVar9];
              if (plVar2 == (int64 *)0) break;
              if ((lVar11 != null) &&
                 (lVar7 = il2cpp_internal(lVar11,*(uint64 *)(*plVar2 + 64))) == null) {
                uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar6,0);
              }
              if (*(uint32 *)(plVar2 + 3) <= uVar9) {
                uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar6,0);
              }
              plVar2[(int64)(int)uVar9 + 4] = lVar11;
              il2cpp_internal();
              uVar9 = uVar9 + 1;
            }
            goto LAB_180936926;
          }
        }
        uVar6 = *(uint64 *)(callback + 48);
        EventDelegate.Add(list,uVar6,param_3,0);
    }

    // Token : 0x6000311
    // RVA   : 0x936A50   Offset: 0x935250   Length: 0x187
    public static EventDelegate Add(List<EventDelegate> list, Callback callback, bool oneShot)
    {
        int iVar1;
        ulong uVar3;
        ulong uVar4;
        bool cVar5;
        ulong uVar6;
        long lVar7;
        uint uVar8;
        uint uVar9;
        long lVar10;
        long lVar11;
        if (callback == null) {
        LAB_180936926:
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
        if (*(char *)(callback + 56) == false) {
          uVar6 = *(uint64 *)(callback + 16);
          cVar5 = Object.op_Equality(uVar6,0,0);
          if ((!cVar5) && (cVar5 = FUN_180d6ca90(*(uint64 *)(callback + 24),0), !cVar5)
             ) {
            if (list == null) {
              Debug.LogWarning("Attempting to add a callback to a list that's null",0);
              return;
            }
            iVar1 = *(int *)(list + 24);
            uVar9 = 0;
            uVar8 = 0;
            if (0 < iVar1) {
              lVar11 = 32;
              lVar10 = 0;
              do {
                if (*(uint32 *)(list + 24) <= uVar8) {
                  ThrowHelper.ThrowArgumentOutOfRangeException(0);
                }
                plVar2 = *(int64 **)(lVar11 + *(int64 *)(list + 16));
                if ((plVar2 != (int64 *)0) &&
                   (cVar5 = (**(code **)(*plVar2 + 0x138))
                                      (plVar2,callback,*(uint64 *)(*plVar2 + 0x140)), cVar5)) {
                  return;
                }
                uVar8 = uVar8 + 1;
                lVar10 = lVar10 + 1;
                lVar11 = lVar11 + 8;
              } while (lVar10 < iVar1);
            }
            uVar6 = *(uint64 *)(callback + 16);
            uVar3 = *(uint64 *)(callback + 24);
            lVar10 = new ZhSegment(0);
            EventDelegate.Clear(lVar10,0);
            *(uint64 *)(lVar10 + 16) = uVar6;
            *(uint64 *)(lVar10 + 24) = uVar3;
            *(uint8 *)(lVar10 + 40) = oneShot;
            if ((*(int64 *)(callback + 32) == 0) ||
               (uVar4 = *(uint64 *)(*(int64 *)(callback + 32) + 24)) == null) {
        LAB_1809368d6:
              FUN_181827900(list,lVar10,DAT_181d5e780);
              return;
            }
            uVar6 = FUN_1800d60b0(DAT_181d82c40,uVar4 & 0xffffffff);
            *(uint64 *)(lVar10 + 32) = uVar6;
            while (lVar11 = *(int64 *)(callback + 32)) != null {
              if ((int)*(uint32 *)(lVar11 + 24) <= (int)uVar9) goto LAB_1809368d6;
              plVar2 = *(int64 **)(lVar10 + 32);
              if (*(uint32 *)(lVar11 + 24) <= uVar9) {
                uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar6,0);
              }
              lVar11 = lVar11[uVar9];
              if (plVar2 == (int64 *)0) break;
              if ((lVar11 != null) &&
                 (lVar7 = il2cpp_internal(lVar11,*(uint64 *)(*plVar2 + 64))) == null) {
                uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar6,0);
              }
              if (*(uint32 *)(plVar2 + 3) <= uVar9) {
                uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar6,0);
              }
              plVar2[(int64)(int)uVar9 + 4] = lVar11;
              il2cpp_internal();
              uVar9 = uVar9 + 1;
            }
            goto LAB_180936926;
          }
        }
        uVar6 = *(uint64 *)(callback + 48);
        EventDelegate.Add(list,uVar6,oneShot,0);
    }

    // Token : 0x6000312
    // RVA   : 0x936960   Offset: 0x935160   Length: 0x7E
    public static void Add(List<EventDelegate> list, EventDelegate ev)
    {
        int iVar1;
        ulong uVar3;
        ulong uVar4;
        bool cVar5;
        ulong uVar6;
        long lVar7;
        uint uVar8;
        uint uVar9;
        long lVar10;
        long lVar11;
        if (ev == null) {
        LAB_180936926:
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
        if (*(char *)(ev + 56) == false) {
          uVar6 = *(uint64 *)(ev + 16);
          cVar5 = Object.op_Equality(uVar6,0,0);
          if ((!cVar5) && (cVar5 = FUN_180d6ca90(*(uint64 *)(ev + 24),0), !cVar5)
             ) {
            if (list == null) {
              Debug.LogWarning("Attempting to add a callback to a list that's null",0);
              return;
            }
            iVar1 = *(int *)(list + 24);
            uVar9 = 0;
            uVar8 = 0;
            if (0 < iVar1) {
              lVar11 = 32;
              lVar10 = 0;
              do {
                if (*(uint32 *)(list + 24) <= uVar8) {
                  ThrowHelper.ThrowArgumentOutOfRangeException(0);
                }
                plVar2 = *(int64 **)(lVar11 + *(int64 *)(list + 16));
                if ((plVar2 != (int64 *)0) &&
                   (cVar5 = (**(code **)(*plVar2 + 0x138))
                                      (plVar2,ev,*(uint64 *)(*plVar2 + 0x140)), cVar5)) {
                  return;
                }
                uVar8 = uVar8 + 1;
                lVar10 = lVar10 + 1;
                lVar11 = lVar11 + 8;
              } while (lVar10 < iVar1);
            }
            uVar6 = *(uint64 *)(ev + 16);
            uVar3 = *(uint64 *)(ev + 24);
            lVar10 = new ZhSegment(0);
            EventDelegate.Clear(lVar10,0);
            *(uint64 *)(lVar10 + 16) = uVar6;
            *(uint64 *)(lVar10 + 24) = uVar3;
            *(uint8 *)(lVar10 + 40) = param_3;
            if ((*(int64 *)(ev + 32) == 0) ||
               (uVar4 = *(uint64 *)(*(int64 *)(ev + 32) + 24)) == null) {
        LAB_1809368d6:
              FUN_181827900(list,lVar10,DAT_181d5e780);
              return;
            }
            uVar6 = FUN_1800d60b0(DAT_181d82c40,uVar4 & 0xffffffff);
            *(uint64 *)(lVar10 + 32) = uVar6;
            while (lVar11 = *(int64 *)(ev + 32)) != null {
              if ((int)*(uint32 *)(lVar11 + 24) <= (int)uVar9) goto LAB_1809368d6;
              plVar2 = *(int64 **)(lVar10 + 32);
              if (*(uint32 *)(lVar11 + 24) <= uVar9) {
                uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar6,0);
              }
              lVar11 = lVar11[uVar9];
              if (plVar2 == (int64 *)0) break;
              if ((lVar11 != null) &&
                 (lVar7 = il2cpp_internal(lVar11,*(uint64 *)(*plVar2 + 64))) == null) {
                uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar6,0);
              }
              if (*(uint32 *)(plVar2 + 3) <= uVar9) {
                uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar6,0);
              }
              plVar2[(int64)(int)uVar9 + 4] = lVar11;
              il2cpp_internal();
              uVar9 = uVar9 + 1;
            }
            goto LAB_180936926;
          }
        }
        uVar6 = *(uint64 *)(ev + 48);
        EventDelegate.Add(list,uVar6,param_3,0);
    }

    // Token : 0x6000313
    // RVA   : 0x936640   Offset: 0x934E40   Length: 0x31B
    public static void Add(List<EventDelegate> list, EventDelegate ev, bool oneShot)
    {
        int iVar1;
        ulong uVar3;
        ulong uVar4;
        bool cVar5;
        ulong uVar6;
        long lVar7;
        uint uVar8;
        uint uVar9;
        long lVar10;
        long lVar11;
        if (ev == null) {
        LAB_180936926:
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
        if (*(char *)(ev + 56) == false) {
          uVar6 = *(uint64 *)(ev + 16);
          cVar5 = Object.op_Equality(uVar6,0,0);
          if ((!cVar5) && (cVar5 = FUN_180d6ca90(*(uint64 *)(ev + 24),0), !cVar5)
             ) {
            if (list == null) {
              Debug.LogWarning("Attempting to add a callback to a list that's null",0);
              return;
            }
            iVar1 = *(int *)(list + 24);
            uVar9 = 0;
            uVar8 = 0;
            if (0 < iVar1) {
              lVar11 = 32;
              lVar10 = 0;
              do {
                if (*(uint32 *)(list + 24) <= uVar8) {
                  ThrowHelper.ThrowArgumentOutOfRangeException(0);
                }
                plVar2 = *(int64 **)(lVar11 + *(int64 *)(list + 16));
                if ((plVar2 != (int64 *)0) &&
                   (cVar5 = (**(code **)(*plVar2 + 0x138))
                                      (plVar2,ev,*(uint64 *)(*plVar2 + 0x140)), cVar5)) {
                  return;
                }
                uVar8 = uVar8 + 1;
                lVar10 = lVar10 + 1;
                lVar11 = lVar11 + 8;
              } while (lVar10 < iVar1);
            }
            uVar6 = *(uint64 *)(ev + 16);
            uVar3 = *(uint64 *)(ev + 24);
            lVar10 = new ZhSegment(0);
            EventDelegate.Clear(lVar10,0);
            *(uint64 *)(lVar10 + 16) = uVar6;
            *(uint64 *)(lVar10 + 24) = uVar3;
            *(uint8 *)(lVar10 + 40) = oneShot;
            if ((*(int64 *)(ev + 32) == 0) ||
               (uVar4 = *(uint64 *)(*(int64 *)(ev + 32) + 24)) == null) {
        LAB_1809368d6:
              FUN_181827900(list,lVar10,DAT_181d5e780);
              return;
            }
            uVar6 = FUN_1800d60b0(DAT_181d82c40,uVar4 & 0xffffffff);
            *(uint64 *)(lVar10 + 32) = uVar6;
            while (lVar11 = *(int64 *)(ev + 32)) != null {
              if ((int)*(uint32 *)(lVar11 + 24) <= (int)uVar9) goto LAB_1809368d6;
              plVar2 = *(int64 **)(lVar10 + 32);
              if (*(uint32 *)(lVar11 + 24) <= uVar9) {
                uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar6,0);
              }
              lVar11 = lVar11[uVar9];
              if (plVar2 == (int64 *)0) break;
              if ((lVar11 != null) &&
                 (lVar7 = il2cpp_internal(lVar11,*(uint64 *)(*plVar2 + 64))) == null) {
                uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar6,0);
              }
              if (*(uint32 *)(plVar2 + 3) <= uVar9) {
                uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar6,0);
              }
              plVar2[(int64)(int)uVar9 + 4] = lVar11;
              il2cpp_internal();
              uVar9 = uVar9 + 1;
            }
            goto LAB_180936926;
          }
        }
        uVar6 = *(uint64 *)(ev + 48);
        EventDelegate.Add(list,uVar6,oneShot,0);
    }

    // Token : 0x6000314
    // RVA   : 0x9381D0   Offset: 0x9369D0   Length: 0xE1
    public static bool Remove(List<EventDelegate> list, Callback callback)
    {
        int iVar1;
        bool cVar3;
        uint uVar4;
        long lVar5;
        long lVar6;
        if (list != null) {
          iVar1 = *(int *)(list + 24);
          uVar4 = 0;
          if (0 < iVar1) {
            lVar6 = 32;
            lVar5 = 0;
            do {
              if (*(uint32 *)(list + 24) <= uVar4) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              plVar2 = *(int64 **)(lVar6 + *(int64 *)(list + 16));
              if ((plVar2 != (int64 *)0) &&
                 (cVar3 = (**(code **)(*plVar2 + 0x138))(plVar2,callback,*(uint64 *)(*plVar2 + 0x140)),
                 cVar3)) {
                FUN_18182b220(list,uVar4,DAT_181d5e900);
                return true;
              }
              uVar4 = uVar4 + 1;
              lVar5 = lVar5 + 1;
              lVar6 = lVar6 + 8;
            } while (lVar5 < iVar1);
          }
        }
        return false;
    }

    // Token : 0x6000315
    // RVA   : 0x9380E0   Offset: 0x9368E0   Length: 0xE1
    public static bool Remove(List<EventDelegate> list, EventDelegate ev)
    {
        int iVar1;
        bool cVar3;
        uint uVar4;
        long lVar5;
        long lVar6;
        if (list != null) {
          iVar1 = *(int *)(list + 24);
          uVar4 = 0;
          if (0 < iVar1) {
            lVar6 = 32;
            lVar5 = 0;
            do {
              if (*(uint32 *)(list + 24) <= uVar4) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              plVar2 = *(int64 **)(lVar6 + *(int64 *)(list + 16));
              if ((plVar2 != (int64 *)0) &&
                 (cVar3 = (**(code **)(*plVar2 + 0x138))(plVar2,ev,*(uint64 *)(*plVar2 + 0x140)),
                 cVar3)) {
                FUN_18182b220(list,uVar4,DAT_181d5e900);
                return true;
              }
              uVar4 = uVar4 + 1;
              lVar5 = lVar5 + 1;
              lVar6 = lVar6 + 8;
            } while (lVar5 < iVar1);
          }
        }
        return false;
    }

    // Token : 0x6000316
    // RVA   : 0x938750   Offset: 0x936F50   Length: 0x62
    private static void /*cctor*/()
    {
        uint uVar1;
        if ("EventDelegate" != (int64 *)0) {
          uVar1 = (**(code **)(*"EventDelegate" + 0x158))
                            ("EventDelegate",*(uint64 *)(*"EventDelegate" + 0x160));
          **(uint32 **)(DAT_181d9f758 + 184) = uVar1;
          return;
        }
    }

}
