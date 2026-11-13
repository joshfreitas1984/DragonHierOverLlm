// ============================================================
// Type  : TimeScaleController
// Token : 0x20003AB
// ============================================================

public class TimeScaleController
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001E0E
    public bool paused;

    // Token: 0x4001E0F
    public float nowSlowTimeScale;

    // Token: 0x4001E10
    public List<SlowTimeData> slowTimeDatas;

    // Token: 0x4001E11
    private static TimeScaleController _instance;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60023A0
    // RVA   : 0x814E20   Offset: 0x813C20   Length: 0x36
    public static TimeScaleController get_Instance()
    {
        return **(uint64 **)(DAT_181e8c2e8 + 184);
    }

    // Token : 0x60023A1
    // RVA   : 0x814AB0   Offset: 0x8138B0   Length: 0x43
    private void Awake()
    {
        puVar1 = *(uint64 **)(DAT_181e8c2e8 + 184);
        *puVar1 = this;
        il2cpp_internal(puVar1,this);
    }

    // Token : 0x60023A2
    // RVA   : 0x814BA0   Offset: 0x8139A0   Length: 0x1F9
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
                  FUN_181763390(lVar1,uVar3,DAT_181e85b00);
                }
                else {
                  if (lVar1 == null) throw; // [null/range check failed]
                  lVar2 = FUN_1800024b0(lVar1,uVar3,DAT_181e85bf0);
                  if (lVar2 == null) throw; // [null/range check failed]
                  if (*(float *)(lVar2 + 20) <= this.nowSlowTimeScale &&
                      this.nowSlowTimeScale != *(float *)(lVar2 + 20)) {
                    if (this.slowTimeDatas == null) throw; // [null/range check failed]
                    lVar2 = FUN_1800024b0(this.slowTimeDatas,uVar3,DAT_181e85bf0);
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

    // Token : 0x60023A3
    // RVA   : 0x814B00   Offset: 0x813900   Length: 0x99
    public void SetSlowTime(float time, float scale)
    {
        long lVar1;
        ulong uVar2;
        lVar1 = this.slowTimeDatas;
        uVar2 = new SlowTimeData(time,scale,0);
        if (lVar1 != null) {
          FUN_18175de30(lVar1,uVar2,DAT_181e85a88);
          return;
        }
    }

    // Token : 0x60023A4
    // RVA   : 0x814DA0   Offset: 0x813BA0   Length: 0x76
    public void /*ctor*/()
    {
        ulong uVar1;
        uVar1 = il2cpp_internal(DAT_181e775a8);
        FUN_1810f3480(uVar1,DAT_181e85a10);
        this.slowTimeDatas = uVar1;
        FUN_180ae8740(this,0);
    }

}
