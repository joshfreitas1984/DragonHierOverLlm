// ============================================================
// Type  : <AnimateProperties>d__6
// Token : 0x20003F0
// ============================================================

public class <AnimateProperties>d__6
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001E67
    private int <>1__state;

    // Token: 0x4001E68
    private object <>2__current;

    // Token: 0x4001E69
    public ShaderPropAnimator <>4__this;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x600242E
    // RVA   : 0x219070   Offset: 0x217870   Length: 0x24
    public void /*ctor*/(int <>1__state)
    {
        ZhSegment.Initialize(this,0);
        this.<>1__state = <>1__state;
    }

    // Token : 0x600242F
    // RVA   : 0x245810   Offset: 0x244010   Length: 0x3
    private virtual void System.IDisposable.Dispose()
    {
    }

    // Token : 0x6002430
    // RVA   : 0xB0A220   Offset: 0xB08A20   Length: 0x184
    private virtual bool MoveNext()
    {
        float fVar1;
        long lVar2;
        long lVar3;
        ulong uVar4;
        uint uVar5;
        float fVar6;
        float fVar7;
        lVar2 = this.<>4__this;
        if (this.<>1__state == 0) {
          this.<>1__state = 0xffffffff;
          uVar5 = Random.Range(0,0x3f800000,0);
          if (lVar2 == null) throw; // [null/range check failed]
          *(uint32 *)(lVar2 + 48) = uVar5;
        }
        else {
          if (this.<>1__state != 1) {
            return false;
          }
          this.<>1__state = 0xffffffff;
          if (lVar2 == null) throw; // [null/range check failed]
        }
        if (*(int64 *)(lVar2 + 40) != 0) {
          uVar5 = AnimationCurve.Evaluate(*(int64 *)(lVar2 + 40),*(uint32 *)(lVar2 + 48),0);
          lVar3 = *(int64 *)(lVar2 + 32);
          if (lVar3 != null) {
            FUN_1810a7430(lVar3,*(uint32 *)(*(int64 *)(DAT_181d7c938 + 184) + 124),uVar5,0);
            fVar1 = *(float *)(lVar2 + 48);
            fVar6 = (float)Time.get_deltaTime(0);
            fVar7 = (float)Random.Range(0x3e4ccccd,0x3e99999a,0);
            *(float *)(lVar2 + 48) = fVar7 * fVar6 + fVar1;
            uVar4 = new c.DisplayClass9_0(0);
            this.<>2__current = uVar4;
            this.<>1__state = 1;
            return true;
          }
        }
    }

    // Token : 0x6002431
    // RVA   : 0x20F140   Offset: 0x20D940   Length: 0x5
    private virtual object System.Collections.Generic.IEnumerator<System.object>.get_Current()
    {
        return this.<>2__current;
    }

    // Token : 0x6002432
    // RVA   : 0xB0A3B0   Offset: 0xB08BB0   Length: 0x3E
    private virtual void System.Collections.IEnumerator.Reset()
    {
        ulong uVar1;
        ulong uVar2;
        uVar1 = il2cpp_runtime_class_init(&DAT_181d682e8);
        uVar1 = il2cpp_internal(uVar1);
        NotSupportedException.ctor(uVar1,0);
        uVar2 = il2cpp_runtime_class_init(&DAT_181d83aa8);
    }

    // Token : 0x6002433
    // RVA   : 0x20F140   Offset: 0x20D940   Length: 0x5
    private virtual object System.Collections.IEnumerator.get_Current()
    {
        return this.<>2__current;
    }

}
