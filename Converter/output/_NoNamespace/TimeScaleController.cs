// ============================================================
// Type  : TimeScaleController
// Token : 0x2000397
// ============================================================

public class TimeScaleController
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001C76
    public bool paused;

    // Token: 0x4001C77
    public float nowSlowTimeScale;

    // Token: 0x4001C78
    public List<SlowTimeData> slowTimeDatas;

    // Token: 0x4001C79
    private static TimeScaleController _instance;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6002274
    // RVA   : 0xAC5EA0   Offset: 0xAC46A0   Length: 0x36
    public static TimeScaleController get_Instance()
    {
        return **(uint64 **)(DAT_181d86c68 + 184);
    }

    // Token : 0x6002275
    // RVA   : 0xAC5B30   Offset: 0xAC4330   Length: 0x43
    private void Awake()
    {
        puVar1 = *(uint64 **)(DAT_181d86c68 + 184);
        *puVar1 = this;
        il2cpp_internal(puVar1,this);
    }

    // Token : 0x6002276
    // RVA   : 0xAC5C20   Offset: 0xAC4420   Length: 0x1F9
    private void Update()
    {
        long lVar1;
        long lVar2;
        uint uVar3;
        long lVar4;
        float fVar5;
        uint uVar6;
        float fVar7;
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
              fVar7 = (float)RealTime.get_deltaTime(0);
              uVar6 = Mathf.Min(0x3f800000,fVar7 * 4.0 + fVar5,0);
            }
            else {
              uVar6 = 0x3f800000;
            }
          }
          else {
            uVar6 = 0x3f800000;
            this.nowSlowTimeScale = 0x3f800000;
            uVar3 = lVar4.Count - 1;
            if (-1 < (int)uVar3) {
              lVar4 = (int64)(int)uVar3 * 8 + 32;
              do {
                lVar2 = this.slowTimeDatas;
                if (lVar2 == null) throw; // [null/range check failed]
                if (lVar2.Count <= uVar3) {
                  ThrowHelper.ThrowArgumentOutOfRangeException(0);
                }
                lVar2 = *(int64 *)(lVar4 + lVar2._items);
                if (lVar2 == null) throw; // [null/range check failed]
                fVar5 = lVar2._items;
                fVar7 = (float)RealTime.get_deltaTime(0);
                lVar2._items = fVar5 - fVar7;
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
                  FUN_18182b220(lVar1,uVar3,DAT_181d7bb58);
                }
                else {
                  if (lVar1 == null) throw; // [null/range check failed]
                  lVar2 = FUN_180002f80(lVar1,uVar3,DAT_181d7bc58);
                  if (lVar2 == null) throw; // [null/range check failed]
                  if (*(float *)(lVar2 + 20) <= this.nowSlowTimeScale &&
                      this.nowSlowTimeScale != *(float *)(lVar2 + 20)) {
                    if (this.slowTimeDatas == null) throw; // [null/range check failed]
                    lVar2 = FUN_180002f80(this.slowTimeDatas,uVar3,DAT_181d7bc58);
                    if (lVar2 == null) throw; // [null/range check failed]
                    this.nowSlowTimeScale = *(uint32 *)(lVar2 + 20);
                  }
                }
                lVar4 = lVar4 + -8;
                uVar3 = uVar3 - 1;
              } while (-1 < (int)uVar3);
              uVar6 = this.nowSlowTimeScale;
            }
          }
          Time.set_timeScale(uVar6,0);
          return;
        }
    }

    // Token : 0x6002277
    // RVA   : 0xAC5B80   Offset: 0xAC4380   Length: 0x99
    public void SetSlowTime(float time, float scale)
    {
        long lVar1;
        ulong uVar2;
        lVar1 = this.slowTimeDatas;
        uVar2 = new SlowTimeData(time,scale,0);
        if (lVar1 != null) {
          FUN_181827900(lVar1,uVar2,DAT_181d7bad8);
          return;
        }
    }

    // Token : 0x6002278
    // RVA   : 0xAC5E20   Offset: 0xAC4620   Length: 0x76
    public void /*ctor*/()
    {
        ulong uVar1;
        uVar1 = il2cpp_internal(DAT_181d728b0);
        FUN_180f58a90(uVar1,DAT_181d7ba58);
        this.slowTimeDatas = uVar1;
        FUN_18044ef50(this,0);
    }

}
