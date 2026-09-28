// ============================================================
// Type  : UITweener
// Token : 0x20000C7
// ============================================================

public class UITweener
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x40004C1
    public static UITweener current;

    // Token: 0x40004C2
    public Method method;

    // Token: 0x40004C3
    public Style style;

    // Token: 0x40004C4
    public AnimationCurve animationCurve;

    // Token: 0x40004C5
    public bool ignoreTimeScale;

    // Token: 0x40004C6
    public float delay;

    // Token: 0x40004C7
    public float duration;

    // Token: 0x40004C8
    public bool steeperCurves;

    // Token: 0x40004C9
    public int tweenGroup;

    // Token: 0x40004CA
    public bool useFixedUpdate;

    // Token: 0x40004CB
    public List<EventDelegate> onFinished;

    // Token: 0x40004CC
    public GameObject eventReceiver;

    // Token: 0x40004CD
    public string callWhenFinished;

    // Token: 0x40004CE
    public float timeScale;

    // Token: 0x40004CF
    private bool mStarted;

    // Token: 0x40004D0
    private float mStartTime;

    // Token: 0x40004D1
    private float mDuration;

    // Token: 0x40004D2
    private float mAmountPerDelta;

    // Token: 0x40004D3
    private float mFactor;

    // Token: 0x40004D4
    private List<EventDelegate> mTemp;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x600061C
    // RVA   : 0xC097E0   Offset: 0xC08BE0   Length: 0x84
    public float get_amountPerDelta()
    {
        float fVar1;
        float fVar2;
        fVar1 = this.duration;
        if (fVar1 == 0.0) {
          return 1000.0;
        }
        if (*(float *)(this + 100) != fVar1) {
          *(float *)(this + 100) = fVar1;
          fVar2 = (float)Mathf.Sign(this.mAmountPerDelta,0);
          fVar2 = fVar2 * ABS(1.0 / fVar1);
          this.mAmountPerDelta = fVar2;
          return fVar2;
        }
        return this.mAmountPerDelta;
    }

    // Token : 0x600061D
    // RVA   : 0xC098A0   Offset: 0xC08CA0   Length: 0x6
    public float get_tweenFactor()
    {
        uint32 FUN_180c098a0(int64 this)
        {
        return this.mFactor;
    }

    // Token : 0x600061E
    // RVA   : 0xC098B0   Offset: 0xC08CB0   Length: 0x1E
    public void set_tweenFactor(float value)
    {
        uint uVar1;
        uVar1 = Mathf.Clamp01(value,0);
        this.mFactor = uVar1;
    }

    // Token : 0x600061F
    // RVA   : 0xC09870   Offset: 0xC08C70   Length: 0x23
    public Direction get_direction()
    {
        ulong uVar1;
        float fVar2;
        fVar2 = (float)UITweener.get_amountPerDelta(this,0);
        uVar1 = 1;
        if (fVar2 < 0.0) {
          uVar1 = 0xffffffff;
        }
        return uVar1;
    }

    // Token : 0x6000620
    // RVA   : 0xC092B0   Offset: 0xC086B0   Length: 0x3E
    private void Reset()
    {
        if (*(char *)((int64)this + 92) == false) {
          (**(code **)(*this + 0x1a8))(this,*(uint64 *)(*this + 0x1b0));
                          // WARNING: Could not recover jumptable at 0x000180c092e1. Too many branches
                          // WARNING: Treating indirect jump as call
          (**(code **)(*this + 0x1b8))(this,*(uint64 *)(*this + 0x1c0));
          return;
        }
    }

    // Token : 0x6000621
    // RVA   : 0xC09570   Offset: 0xC08970   Length: 0x7
    protected virtual void Start()
    {
        void FUN_180c09570(uint64 this)
        {
        UITweener.DoUpdate(this,0);
    }

    // Token : 0x6000622
    // RVA   : 0xC095D0   Offset: 0xC089D0   Length: 0xE
    protected void Update()
    {
        void FUN_180c095d0(int64 this)
        {
        if (!this.useFixedUpdate) {
          UITweener.DoUpdate(this,0);
          return;
        }
    }

    // Token : 0x6000623
    // RVA   : 0xC09130   Offset: 0xC08530   Length: 0xE
    protected void FixedUpdate()
    {
        void FUN_180c09130(int64 this)
        {
        if (this.useFixedUpdate) {
          UITweener.DoUpdate(this,0);
          return;
        }
    }

    // Token : 0x6000624
    // RVA   : 0xC08BF0   Offset: 0xC07FF0   Length: 0x4E9
    protected void DoUpdate()
    {
        var pStatics = *(int64*)(DAT_181db05f8 + 184);
        int iVar1;
        long lVar3;
        bool cVar4;
        ulong uVar5;
        long lVar6;
        uint uVar7;
        long lVar8;
        float fVar9;
        float fVar10;
        float fVar11;
        float fVar12;
        uint uVar13;
        if ((!this.ignoreTimeScale) || (this.useFixedUpdate)) {
          fVar9 = (float)Time.get_deltaTime(0);
        }
        else {
          fVar9 = (float)Time.get_unscaledDeltaTime(0);
        }
        if ((!this.ignoreTimeScale) || (this.useFixedUpdate)) {
          fVar10 = (float)Time.get_time(0);
        }
        else {
          fVar10 = (float)Time.get_unscaledTime(0);
        }
        if (!this.mStarted) {
          fVar11 = fVar10 + this.delay;
          fVar9 = 0.0;
          this.mStarted = 1;
          this.mStartTime = fVar11;
        }
        else {
          fVar11 = this.mStartTime;
        }
        if (fVar10 < fVar11) {
          return;
        }
        fVar10 = this.duration;
        fVar11 = this.mFactor;
        if (fVar10 == 0.0) {
          fVar9 = 1.0;
        }
        else {
          fVar12 = this.mAmountPerDelta;
          if (*(float *)(this + 100) != fVar10) {
            *(float *)(this + 100) = fVar10;
            fVar12 = (float)Mathf.Sign(fVar12,0);
            fVar12 = fVar12 * ABS(1.0 / fVar10);
            this.mAmountPerDelta = fVar12;
          }
          fVar9 = fVar12 * fVar9 * this.timeScale;
        }
        fVar11 = fVar11 + fVar9;
        this.mFactor = fVar11;
        iVar1 = this.style;
        if (iVar1 == 1) {
          if (fVar11 <= 1.0) goto LAB_180c090c1;
          fVar9 = floorf(fVar11);
          fVar11 = fVar11 - fVar9;
        }
        else {
          if (iVar1 != 2) {
            if ((iVar1 != 0) ||
               (((this.duration != null.0 && (fVar11 <= 1.0)) && (0.0 <= fVar11))))
            goto LAB_180c090c1;
            uVar13 = Mathf.Clamp01(fVar11,0);
            this.mFactor = uVar13;
            UITweener.Sample(this,uVar13,1,0);
            Behaviour.set_enabled(this,0,0);
            uVar5 = **(uint64 **)(DAT_181db05f8 + 184);
            cVar4 = Object.op_Inequality(uVar5,this,0);
            if (!cVar4) {
              return;
            }
            plVar2 = pStatics;
            lVar3 = *plVar2;
            *plVar2 = this;
            il2cpp_internal(plVar2,this);
            if (this.onFinished == null) {
        LAB_180c08fcd:
              uVar5 = this.eventReceiver;
              cVar4 = Object.op_Inequality(uVar5,0,0);
              if ((cVar4) &&
                 (cVar4 = FUN_180d755b0(this.callWhenFinished,0), !cVar4)) {
                if (this.eventReceiver == null) goto LAB_180c090d4;
                GameObject.SendMessage
                          (this.eventReceiver,this.callWhenFinished,this,1,0);
              }
              plVar2 = pStatics;
              *plVar2 = lVar3;
              il2cpp_internal(plVar2,lVar3);
              return;
            }
            this.mTemp = this.onFinished;
            uVar5 = il2cpp_internal(DAT_181d92658);
            FUN_18132faf0(uVar5,DAT_181d85ea0);
            this.onFinished = uVar5;
            uVar5 = this.mTemp;
            EventDelegate.Execute(uVar5,0);
            lVar6 = this.mTemp;
            uVar7 = 0;
            if (lVar6 != null) {
              lVar8 = 32;
              do {
                if (lVar6.Count <= (int)uVar7) {
                  this.mTemp = 0;
                  goto LAB_180c08fcd;
                }
                if (lVar6 == null) break;
                if (lVar6.Count <= uVar7) {
                  ThrowHelper.ThrowArgumentOutOfRangeException(0);
                }
                lVar6 = *(int64 *)(lVar8 + lVar6._items);
                if ((lVar6 != null) && (*(char *)(lVar6 + 40) == false)) {
                  uVar5 = this.onFinished;
                  EventDelegate.Add(uVar5,lVar6,0,0);
                }
                lVar6 = this.mTemp;
                uVar7 = uVar7 + 1;
                lVar8 = lVar8 + 8;
              } while (lVar6 != null);
            }
        LAB_180c090d4:
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          if (1.0 < fVar11) {
            fVar9 = floorf(fVar11);
            fVar11 = 1.0 - (fVar11 - fVar9);
          }
          else {
            if (0.0 <= fVar11) goto LAB_180c090c1;
            fVar9 = floorf(-fVar11);
            fVar11 = -fVar11 - fVar9;
          }
          this.mAmountPerDelta = this.mAmountPerDelta ^ 0x80000000;
        }
        this.mFactor = fVar11;
        LAB_180c090c1:
        UITweener.Sample(this,fVar11,0,0);
    }

    // Token : 0x6000625
    // RVA   : 0xC09490   Offset: 0xC08890   Length: 0x66
    public void SetOnFinished(Callback del)
    {
        ulong uVar1;
        uVar1 = this.onFinished;
        EventDelegate.Set(uVar1,del,0);
    }

    // Token : 0x6000626
    // RVA   : 0xC09500   Offset: 0xC08900   Length: 0x66
    public void SetOnFinished(EventDelegate del)
    {
        ulong uVar1;
        uVar1 = this.onFinished;
        EventDelegate.Set(uVar1,del,0);
    }

    // Token : 0x6000627
    // RVA   : 0xC08A70   Offset: 0xC07E70   Length: 0x66
    public void AddOnFinished(Callback del)
    {
        ulong uVar1;
        uVar1 = this.onFinished;
        EventDelegate.Add(uVar1,del,0);
    }

    // Token : 0x6000628
    // RVA   : 0xC08AE0   Offset: 0xC07EE0   Length: 0x66
    public void AddOnFinished(EventDelegate del)
    {
        ulong uVar1;
        uVar1 = this.onFinished;
        EventDelegate.Add(uVar1,del,0);
    }

    // Token : 0x6000629
    // RVA   : 0xC09200   Offset: 0xC08600   Length: 0x67
    public void RemoveOnFinished(EventDelegate del)
    {
        if (this.onFinished != null) {
          FUN_1817eee00(this.onFinished,del,DAT_181d86020);
        }
        if (this.mTemp != null) {
          FUN_1817eee00(this.mTemp,del,DAT_181d86020);
        }
    }

    // Token : 0x600062A
    // RVA   : 0xC09140   Offset: 0xC08540   Length: 0x5
    private void OnDisable()
    {
        void FUN_180c09140(int64 this)
        {
        this.mStarted = 0;
    }

    // Token : 0x600062B
    // RVA   : 0xC090E0   Offset: 0xC084E0   Length: 0x4F
    public void Finish()
    {
        bool cVar1;
        uint uVar2;
        cVar1 = Behaviour.get_enabled(this,0);
        if (cVar1) {
          uVar2 = 0;
          if (0.0 < this.mAmountPerDelta) {
            uVar2 = 0x3f800000;
          }
          UITweener.Sample(this,uVar2,1,0);
          Behaviour.set_enabled(this,0,0);
          return;
        }
    }

    // Token : 0x600062C
    // RVA   : 0xC092F0   Offset: 0xC086F0   Length: 0x1A0
    public void Sample(float factor, bool isFinished)
    {
        int iVar1;
        float fVar2;
        float fVar3;
        fVar2 = (float)Mathf.Clamp01(factor,0);
        iVar1 = (int)this[3];
        if (iVar1 == 1) {
          fVar2 = (float)FUN_1801e7e70((1.0 - fVar2) * 1.5707964);
          fVar2 = 1.0 - fVar2;
          if (*(char *)((int64)this + 52) != false) {
            fVar2 = fVar2 * fVar2;
          }
        }
        else if (iVar1 == 2) {
          fVar2 = (float)FUN_1801e7e70(fVar2 * 1.5707964);
          if (*(char *)((int64)this + 52) != false) {
            fVar2 = 1.0 - (1.0 - fVar2) * (1.0 - fVar2);
          }
        }
        else if (iVar1 == 3) {
          fVar3 = (float)FUN_1801e7e70(fVar2 * 6.2831855);
          fVar2 = fVar2 - fVar3 / 6.2831855;
          if (*(char *)((int64)this + 52) != false) {
            fVar3 = (fVar2 + fVar2) - 1.0;
            fVar2 = (float)Mathf.Sign(fVar3,0);
            fVar3 = 1.0 - ABS(fVar3);
            fVar2 = (1.0 - fVar3 * fVar3) * fVar2 * 0.5 + 0.5;
          }
        }
        else if (iVar1 == 4) {
          fVar2 = (float)UITweener.BounceLogic(this,fVar2,0);
        }
        else if (iVar1 == 5) {
          fVar2 = (float)UITweener.BounceLogic(this,1.0 - fVar2,0);
          fVar2 = 1.0 - fVar2;
        }
        if (this[4] != 0) {
          fVar2 = (float)AnimationCurve.Evaluate(this[4],fVar2,0);
        }
                          // WARNING: Could not recover jumptable at 0x000180c09489. Too many branches
                          // WARNING: Treating indirect jump as call
        (**(code **)(*this + 0x198))(this,fVar2,isFinished,*(uint64 *)(*this + 0x1a0));
    }

    // Token : 0x600062D
    // RVA   : 0xC08B50   Offset: 0xC07F50   Length: 0x9A
    private float BounceLogic(float val)
    {
        if (val < 0.363636) {
          return val * val * 7.5685;
        }
        if (0.727272 <= val) {
          if (0.90909 <= val) {
            return (val - 0.9545454) * 7.5625 * (val - 0.9545454) + 0.984375;
          }
          return (val - 0.818181) * 7.5625 * (val - 0.818181) + 0.9375;
        }
        return (val - 0.545454) * 7.5625 * (val - 0.545454) + 0.75;
    }

    // Token : 0x600062E
    // RVA   : 0xC09150   Offset: 0xC08550   Length: 0x13
    public void Play()
    {
        bool cVar1;
        uint uVar2;
        uVar2 = UITweener.get_amountPerDelta(this,0);
        this.mAmountPerDelta = uVar2 & 0x7fffffff;
        if (!param_2) {
          this.mAmountPerDelta = uVar2 & 0x7fffffff ^ 0x80000000;
        }
        cVar1 = Behaviour.get_enabled(this,0);
        if (!cVar1) {
          Behaviour.set_enabled(this,1,0);
          this.mStarted = 0;
        }
        UITweener.DoUpdate(this,0);
    }

    // Token : 0x600062F
    // RVA   : 0xC09150   Offset: 0xC08550   Length: 0x13
    public void PlayForward()
    {
                          // WARNING: Could not recover jumptable at 0x000180c0915c. Too many branches
                          // WARNING: Treating indirect jump as call
        (**(code **)(*this + 0x188))(this,1,*(uint64 *)(*this + 400));
    }

    // Token : 0x6000630
    // RVA   : 0xC09170   Offset: 0xC08570   Length: 0x13
    public void PlayReverse()
    {
                          // WARNING: Could not recover jumptable at 0x000180c0917c. Too many branches
                          // WARNING: Treating indirect jump as call
        (**(code **)(*this + 0x188))(this,0,*(uint64 *)(*this + 400));
    }

    // Token : 0x6000631
    // RVA   : 0xC09190   Offset: 0xC08590   Length: 0x66
    public virtual void Play(bool forward)
    {
        bool cVar1;
        uint uVar2;
        uVar2 = UITweener.get_amountPerDelta(this,0);
        this.mAmountPerDelta = uVar2 & 0x7fffffff;
        if (!forward) {
          this.mAmountPerDelta = uVar2 & 0x7fffffff ^ 0x80000000;
        }
        cVar1 = Behaviour.get_enabled(this,0);
        if (!cVar1) {
          Behaviour.set_enabled(this,1,0);
          this.mStarted = 0;
        }
        UITweener.DoUpdate(this,0);
    }

    // Token : 0x6000632
    // RVA   : 0xC09270   Offset: 0xC08670   Length: 0x3C
    public void ResetToBeginning()
    {
        float fVar1;
        uint uVar2;
        this.mStarted = 0;
        fVar1 = (float)UITweener.get_amountPerDelta(this,0);
        uVar2 = 0;
        if (fVar1 < 0.0) {
          uVar2 = 0x3f800000;
        }
        this.mFactor = uVar2;
        UITweener.Sample(this,uVar2,0,0);
    }

    // Token : 0x6000633
    // RVA   : 0xC09580   Offset: 0xC08980   Length: 0x49
    public void Toggle()
    {
        uint uVar1;
        if (0.0 < this.mFactor) {
          uVar1 = UITweener.get_amountPerDelta(0,0);
          uVar1 = uVar1 ^ 0x80000000;
        }
        else {
          uVar1 = UITweener.get_amountPerDelta(0,0);
          uVar1 = uVar1 & 0x7fffffff;
        }
        this.mAmountPerDelta = uVar1;
        Behaviour.set_enabled(this,1,0);
    }

    // Token : 0x6000634
    // (no native address)
    protected virtual void OnUpdate(float factor, bool isFinished)
    {
    }

    // Token : 0x6000635
    // RVA   : 0x15E4790   Offset: 0x15E3B90   Length: 0x533
    public static T Begin<T>(GameObject go, float duration, float delay)
    {
        int iVar1;
        bool cVar3;
        long lVar4;
        long lVar5;
        ulong uVar7;
        ulong uVar8;
        ulong uVar9;
        uint uVar10;
        ulong uVar11;
        float fVar12;
        ulong in_stack_ffffffffffffff68;
        uint uVar13;
        ulong local_88;
        ulong uStack_80;
        ulong local_78;
        uint local_70;
        ulong local_68;
        ulong uStack_60;
        ulong local_58;
        uint local_50;
        if (go != null) {
          lVar4 = (**(code **)**(uint64 **)(param_4 + 48))
                            (go,(uint64 *)**(uint64 **)(param_4 + 48));
          cVar3 = Object.op_Inequality(lVar4,0,0);
          uVar13 = (uint32)((uint64)in_stack_ffffffffffffff68 >> 32);
          uVar7 = 0;
          if (cVar3) {
            if (lVar4 == null) throw; // [null/range check failed]
            if (*(int *)(lVar4 + 56) != 0) {
              lVar4 = 0;
              puVar2 = *(uint64 **)(*(int64 *)(param_4 + 48) + 16);
              lVar5 = (*(code *)*puVar2)(go,puVar2);
              uVar13 = (uint32)((uint64)in_stack_ffffffffffffff68 >> 32);
              if (lVar5 == null) throw; // [null/range check failed]
              iVar1 = *(int *)(lVar5 + 24);
              uVar11 = uVar7;
              if (0 < iVar1) {
                do {
                  uVar10 = (uint32)uVar11;
                  if (*(uint32 *)(lVar5 + 24) <= uVar10) {
                    uVar9 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                    FUN_1800d65f0(uVar9,0);
                  }
                  lVar4 = lVar5[uVar10];
                  cVar3 = Object.op_Inequality(lVar4,0,0);
                  uVar13 = (uint32)((uint64)in_stack_ffffffffffffff68 >> 32);
                  if (cVar3) {
                    if (lVar4 == null) throw; // [null/range check failed]
                    if (*(int *)(lVar4 + 56) == 0) break;
                  }
                  uVar11 = (uint64)(uVar10 + 1);
                  lVar4 = 0;
                } while ((int)(uVar10 + 1) < iVar1);
              }
            }
          }
          cVar3 = Object.op_Equality(lVar4,0,0);
          if (cVar3) {
            puVar2 = *(uint64 **)(*(int64 *)(param_4 + 48) + 24);
            lVar4 = (*(code *)*puVar2)(go,puVar2);
            cVar3 = Object.op_Equality(lVar4,0,0);
            if (cVar3) {
              uVar9 = *(uint64 *)(*(int64 *)(param_4 + 48) + 32);
              plVar6 = (int64 *)Type.GetTypeFromHandle(uVar9,0);
              uVar9 = "Unable to add ";
              if (plVar6 != (int64 *)0) {
                uVar7 = (**(code **)(*plVar6 + 0x168))(plVar6,*(uint64 *)(*plVar6 + 0x170));
              }
              uVar8 = NGUITools.GetHierarchy(go,0);
              uVar9 = String.Concat(uVar9,uVar7," to ",uVar8,0);
              Debug.LogError(uVar9,go,0);
              return 0;
            }
          }
          if (lVar4 != null) {
            *(uint32 *)(lVar4 + 44) = delay;
            *(uint8 *)(lVar4 + 92) = 0;
            *(uint32 *)(lVar4 + 108) = 0;
            *(float *)(lVar4 + 48) = duration;
            *(float *)(lVar4 + 100) = duration;
            if (duration <= 0.0) {
              fVar12 = 1000.0;
            }
            else {
              fVar12 = ABS(1.0 / duration);
            }
            *(float *)(lVar4 + 104) = fVar12;
            *(uint32 *)(lVar4 + 28) = 0;
            lVar5 = FUN_1800d60b0(DAT_181da3ba0,2);
            uVar7 = CONCAT44(uVar13,0x3f800000);
            local_78 = 0;
            local_70 = 0;
            local_88 = 0;
            uStack_80 = 0;
            Keyframe.ctor(&local_88,0,0,0,uVar7,0);
            if (lVar5 != null) {
              if (*(int *)(lVar5 + 24) == 0) {
                uVar9 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar9,0);
              }
              *(uint64 *)(lVar5 + 32) = local_88;
              *(uint64 *)(lVar5 + 40) = uStack_80;
              *(uint64 *)(lVar5 + 48) = local_78;
              *(uint32 *)(lVar5 + 56) = local_70;
              local_58 = 0;
              local_50 = 0;
              local_68 = 0;
              uStack_60 = 0;
              Keyframe.ctor(&local_68,0x3f800000,0x3f800000,0x3f800000,uVar7 & 0xffffffff00000000,0);
              if (*(uint32 *)(lVar5 + 24) < 2) {
                uVar9 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar9,0);
              }
              *(uint32 *)(lVar5 + 60) = (uint32)local_68;
              *(uint32 *)(lVar5 + 64) = local_68._4_4_;
              *(uint32 *)(lVar5 + 68) = (uint32)uStack_60;
              *(uint32 *)(lVar5 + 72) = uStack_60._4_4_;
              *(uint64 *)(lVar5 + 76) = local_58;
              *(uint32 *)(lVar5 + 84) = local_50;
              uVar9 = new AnimationCurve(lVar5,0);
              *(uint64 *)(lVar4 + 32) = uVar9;
              *(uint64 *)(lVar4 + 72) = 0;
              *(uint64 *)(lVar4 + 80) = 0;
              if (*(int64 *)(lVar4 + 64) != 0) {
                FUN_1812f9a10(*(int64 *)(lVar4 + 64),DAT_181d85fa0);
                if (*(int64 *)(lVar4 + 112) != 0) {
                  FUN_1812f9a10(*(int64 *)(lVar4 + 112),DAT_181d85fa0);
                }
                Behaviour.set_enabled(lVar4,1,0);
                return lVar4;
              }
            }
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
        }
    }

    // Token : 0x6000636
    // RVA   : 0x245810   Offset: 0x244C10   Length: 0x3
    public virtual void SetStartToCurrentValue()
    {
    }

    // Token : 0x6000637
    // RVA   : 0x245810   Offset: 0x244C10   Length: 0x3
    public virtual void SetEndToCurrentValue()
    {
    }

    // Token : 0x6000638
    // RVA   : 0xC095E0   Offset: 0xC089E0   Length: 0x1F3
    protected void /*ctor*/()
    {
        long lVar1;
        ulong uVar2;
        ulong local_68;
        ulong uStack_60;
        ulong local_58;
        uint local_50;
        ulong local_48;
        ulong uStack_40;
        ulong local_38;
        uint local_30;
        lVar1 = FUN_1800d60b0(DAT_181da3ba0,2);
        local_58 = 0;
        local_50 = 0;
        local_68 = 0;
        uStack_60 = 0;
        Keyframe.ctor(&local_68,0,0,0,0x3f800000,0);
        if (lVar1 == null) {
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
        if (*(int *)(lVar1 + 24) == 0) {
          uVar2 = il2cpp_internal();
                          // WARNING: Subroutine does not return
          FUN_1800d65f0(uVar2,0);
        }
        *(uint64 *)(lVar1 + 32) = local_68;
        *(uint64 *)(lVar1 + 40) = uStack_60;
        *(uint64 *)(lVar1 + 48) = local_58;
        *(uint32 *)(lVar1 + 56) = local_50;
        local_38 = 0;
        local_30 = 0;
        local_48 = 0;
        uStack_40 = 0;
        Keyframe.ctor(&local_48,0x3f800000,0x3f800000,0x3f800000,0,0);
        if (1 < *(uint32 *)(lVar1 + 24)) {
          *(uint32 *)(lVar1 + 60) = (uint32)local_48;
          *(uint32 *)(lVar1 + 64) = local_48._4_4_;
          *(uint32 *)(lVar1 + 68) = (uint32)uStack_40;
          *(uint32 *)(lVar1 + 72) = uStack_40._4_4_;
          *(uint64 *)(lVar1 + 76) = local_38;
          *(uint32 *)(lVar1 + 84) = local_30;
          this.animationCurve = new AnimationCurve(lVar1,0);
          this.ignoreTimeScale = 1;
          this.duration = 0x3f800000;
          uVar2 = il2cpp_internal(DAT_181d92658);
          FUN_18132faf0(uVar2,DAT_181d85ea0);
          this.onFinished = uVar2;
          this.timeScale = 0x3f800000;
          this.mAmountPerDelta = 0x447a0000;
          FUN_18044ef50(this,0);
          return;
        }
        uVar2 = il2cpp_internal();
    }

}
