// ============================================================
// Type  : TimeScaleController
// Token : 0x200039E
// ============================================================

public class TimeScaleController
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001D7C
    public bool paused;

    // Token: 0x4001D7D
    public float nowSlowTimeScale;

    // Token: 0x4001D7E
    public List<SlowTimeData> slowTimeDatas;

    // Token: 0x4001D7F
    private static TimeScaleController _instance;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60022F6
    // RVA   : 0xAA5BE0   Offset: 0xAA4FE0   Length: 0x36
    public static TimeScaleController get_Instance()
    {
        return **(uint64 **)(DAT_181dabea0 + 184);
    }

    // Token : 0x60022F7
    // RVA   : 0xAA5870   Offset: 0xAA4C70   Length: 0x43
    private void Awake()
    {
        puVar1 = *(uint64 **)(DAT_181dabea0 + 184);
        *puVar1 = this;
        il2cpp_internal(puVar1,this);
    }

    // Token : 0x60022F8
    // RVA   : 0xAA5960   Offset: 0xAA4D60   Length: 0x1F9
    private void Update()
    {
        long lVar1;
        long lVar2;
        uint uVar3;
        long lVar4;
        float fVar5;
        float fVar6;
        float extraout_XMM0_Da;
        if (this.paused) {
          Time.set_timeScale(0,0);
          return;
        }
        lVar4 = this.slowTimeDatas;
        if (lVar4 != null) {
          if (lVar4.Count < 1) {
            fVar5 = (float)Time.get_timeScale(0);
            if (fVar5 < 1.0) {
              fVar5 = (float)Time.get_timeScale(0);
              fVar6 = (float)RealTime.get_deltaTime(0);
              fVar5 = (float)Mathf.Min(0x3f800000,fVar6 * 4.0 + fVar5,0);
            }
            else {
              fVar5 = 1.0;
            }
          }
          else {
            fVar5 = 1.0;
            this.nowSlowTimeScale = 0x3f800000;
            uVar3 = lVar4.Count - 1;
            if (-1 < (int)uVar3) {
              lVar4 = (int64)(int)uVar3 * 8 + 32;
              do {
                lVar2 = this.slowTimeDatas;
                if (lVar2 == null) throw; // [null/range check failed]
                if (lVar2.Count <= uVar3) {
                  ThrowHelper.ThrowArgumentOutOfRangeException(fVar5);
                }
                lVar2 = *(int64 *)(lVar4 + lVar2._items);
                if (lVar2 == null) throw; // [null/range check failed]
                fVar5 = lVar2._items;
                fVar6 = (float)RealTime.get_deltaTime(0);
                lVar2._items = fVar5 - fVar6;
                lVar2 = this.slowTimeDatas;
                if (lVar2 == null) throw; // [null/range check failed]
                if (lVar2.Count <= uVar3) {
                  ThrowHelper.ThrowArgumentOutOfRangeException(0);
                }
                lVar2 = *(int64 *)(lVar4 + lVar2._items);
                if (lVar2 == null) throw; // [null/range check failed]
                lVar1 = this.slowTimeDatas;
                if (lVar2._items <= 0.0) {
                  if (lVar1 == null) throw; // [null/range check failed]
                  fVar5 = (float)FUN_181823ba0(lVar1,uVar3,DAT_181da34f0);
                }
                else {
                  if (lVar1 == null) throw; // [null/range check failed]
                  lVar2 = FUN_180002f80(lVar1,uVar3,DAT_181da35f0);
                  if (lVar2 == null) throw; // [null/range check failed]
                  fVar5 = this.nowSlowTimeScale;
                  if (*(float *)(lVar2 + 20) <= fVar5 && fVar5 != *(float *)(lVar2 + 20)) {
                    if (this.slowTimeDatas == null) throw; // [null/range check failed]
                    lVar2 = FUN_180002f80(this.slowTimeDatas,uVar3,DAT_181da35f0);
                    if (lVar2 == null) throw; // [null/range check failed]
                    this.nowSlowTimeScale = *(uint32 *)(lVar2 + 20);
                    fVar5 = extraout_XMM0_Da;
                  }
                }
                lVar4 = lVar4 + -8;
                uVar3 = uVar3 - 1;
              } while (-1 < (int)uVar3);
              fVar5 = this.nowSlowTimeScale;
            }
          }
          Time.set_timeScale(fVar5,0);
          return;
        }
    }

    // Token : 0x60022F9
    // RVA   : 0xAA58C0   Offset: 0xAA4CC0   Length: 0x99
    public void SetSlowTime(float time, float scale)
    {
        long lVar1;
        ulong uVar2;
        lVar1 = this.slowTimeDatas;
        uVar2 = new SlowTimeData(time,scale,0);
        if (lVar1 != null) {
          FUN_18181e6b0(lVar1,uVar2,DAT_181da3470);
          return;
        }
    }

    // Token : 0x60022FA
    // RVA   : 0xAA5B60   Offset: 0xAA4F60   Length: 0x76
    public void /*ctor*/()
    {
        ulong uVar1;
        uVar1 = il2cpp_internal(DAT_181d975e8);
        FUN_181330100(uVar1,DAT_181da33f0);
        this.slowTimeDatas = uVar1;
        FUN_18044ef50(this,0);
    }

}
