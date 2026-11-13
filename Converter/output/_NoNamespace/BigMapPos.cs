// ============================================================
// Type  : BigMapPos
// Token : 0x2000219
// ============================================================

public class BigMapPos
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4000F55
    public float x;

    // Token: 0x4000F56
    public float y;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6001070
    // RVA   : 0x42F150   Offset: 0x42DF50   Length: 0x7
    public void /*ctor*/()
    {
        ZhSegment.Initialize(this,0);
        this.x = (float)*param_2 * 100.0;
        this.y = *(float *)((int64)param_2 + 4) * 100.0;
    }

    // Token : 0x6001071
    // RVA   : 0x9E4960   Offset: 0x9E3760   Length: 0x45
    public void /*ctor*/(Vector3 source)
    {
        ZhSegment.Initialize(this,0);
        this.x = (float)*source * 100.0;
        this.y = *(float *)((int64)source + 4) * 100.0;
    }

    // Token : 0x6001072
    // RVA   : 0x9E4850   Offset: 0x9E3650   Length: 0x7
    public void Reset()
    {
        this.x = 0;
    }

    // Token : 0x6001073
    // RVA   : 0x9E4860   Offset: 0x9E3660   Length: 0x2C
    public void SetByVector3(Vector3 source)
    {
        this.x = *source * 100.0;
        this.y = source[1] * 100.0;
    }

    // Token : 0x6001074
    // RVA   : 0x9E4780   Offset: 0x9E3580   Length: 0x21
    public bool IsZero()
    {
        if ((this.x == null.0) && (this.y == null.0)) {
          return true;
        }
        return false;
    }

    // Token : 0x6001075
    // RVA   : 0x9E4640   Offset: 0x9E3440   Length: 0x8A
    public float Distance(BigMapPos target)
    {
        float fVar1;
        float fVar2;
        ulong uVar3;
        if (target == null) {
                          // WARNING: Subroutine does not return
          FUN_1801e0300();
        }
        fVar1 = (float)FUN_1801e6830(*(float *)(target + 20) - this.y,0x40000000);
        fVar2 = (float)FUN_1801e6830(*(float *)(target + 16) - this.x);
        fVar1 = fVar1 + fVar2;
        if (0.0 <= fVar1) {
          return (uint64)(uint32)SQRT(fVar1);
        }
        uVar3 = FUN_1801e8bb8(fVar1);
        return uVar3;
    }

    // Token : 0x6001076
    // RVA   : 0x9E47B0   Offset: 0x9E35B0   Length: 0x93
    public int QuickTravelTime(BigMapPos target)
    {
        uint uVar1;
        float fVar2;
        float fVar3;
        if (target != null) {
          fVar2 = (float)FUN_1801e6830(*(float *)(target + 16) - this.x,0x40000000)
          ;
          fVar3 = (float)FUN_1801e6830(*(float *)(target + 20) - this.y);
          if (fVar3 + fVar2 < 0.0) {
            fVar2 = (float)FUN_1801e8bb8();
          }
          else {
            fVar2 = SQRT(fVar3 + fVar2);
          }
          uVar1 = Mathf.CeilToInt(fVar2 / 3300.0,0);
          Mathf.Max(1,uVar1);
          return;
        }
    }

    // Token : 0x6001077
    // RVA   : 0x9E4920   Offset: 0x9E3720   Length: 0x40
    public Vector3 ToVector3()
    {
        *this = CONCAT44(param_3 * *(float *)(param_2 + 20),param_3 * *(float *)(param_2 + 16));
        *(float *)(this + 1) = param_3 * 0.0;
        return this;
    }

    // Token : 0x6001078
    // RVA   : 0x9E48E0   Offset: 0x9E36E0   Length: 0x3A
    public Vector3 ToVector3(float multi)
    {
        *this = CONCAT44(param_3 * *(float *)(multi + 20),param_3 * *(float *)(multi + 16));
        *(float *)(this + 1) = param_3 * 0.0;
        return this;
    }

    // Token : 0x6001079
    // RVA   : 0x9E48B0   Offset: 0x9E36B0   Length: 0x23
    public Vector2 ToVector2()
    {
        uint64 FUN_1809e4890(int64 this,float param_2)
        {
        return CONCAT44(this.y * param_2,param_2 * this.x);
    }

    // Token : 0x600107A
    // RVA   : 0x9E4890   Offset: 0x9E3690   Length: 0x1A
    public Vector2 ToVector2(float multi)
    {
        uint64 FUN_1809e4890(int64 this,float multi)
        {
        return CONCAT44(this.y * multi,multi * this.x);
    }

    // Token : 0x600107B
    // RVA   : 0x9E46D0   Offset: 0x9E34D0   Length: 0xA3
    public string GetDescribe(bool haveBrakets)
    {
        ulong uVar1;
        ulong uVar2;
        ulong uVar3;
        uVar3 = "{0},{1}";
        if (haveBrakets) {
          uVar3 = "({0},{1})";
        }
        uVar1 = Single.ToString(this + 16,"f0",0);
        uVar2 = Single.ToString(this + 20,"f0",0);
        String.Format(uVar3,uVar1,uVar2,0);
    }

    // Token : 0x600107C
    // RVA   : 0x9E49B0   Offset: 0x9E37B0   Length: 0xEB
    public static BigMapPos op_Addition(BigMapPos a, BigMapPos b)
    {
        if (a != null) {
          plVar1 = (int64 *)il2cpp_internal(DAT_181e90f60);
          ZhSegment.Initialize(plVar1,0);
          if (plVar1 != (int64 *)0) {
            *(uint32 *)(plVar1 + 2) = *(uint32 *)(a + 16);
            *(uint32 *)((int64)plVar1 + 20) = *(uint32 *)(a + 20);
            if (b != null) {
              *(float *)(plVar1 + 2) = *(float *)(b + 16) + *(float *)(plVar1 + 2);
              *(float *)((int64)plVar1 + 20) =
                   *(float *)(b + 20) + *(float *)((int64)plVar1 + 20);
              return plVar1;
            }
          }
        }
    }

    // Token : 0x600107D
    // RVA   : 0x9E4BA0   Offset: 0x9E39A0   Length: 0xEB
    public static BigMapPos op_Subtraction(BigMapPos a, BigMapPos b)
    {
        if (a != null) {
          plVar1 = (int64 *)il2cpp_internal(DAT_181e90f60);
          ZhSegment.Initialize(plVar1,0);
          if (plVar1 != (int64 *)0) {
            *(uint32 *)(plVar1 + 2) = *(uint32 *)(a + 16);
            *(uint32 *)((int64)plVar1 + 20) = *(uint32 *)(a + 20);
            if (b != null) {
              *(float *)(plVar1 + 2) = *(float *)(plVar1 + 2) - *(float *)(b + 16);
              *(float *)((int64)plVar1 + 20) =
                   *(float *)((int64)plVar1 + 20) - *(float *)(b + 20);
              return plVar1;
            }
          }
        }
    }

    // Token : 0x600107E
    // RVA   : 0x9E4AA0   Offset: 0x9E38A0   Length: 0xF
    public static BigMapPos op_Multiply(BigMapPos a, int b)
    {
        if (a != null) {
          plVar1 = (int64 *)il2cpp_internal(DAT_181e90f60);
          ZhSegment.Initialize(plVar1,0);
          if (plVar1 != (int64 *)0) {
            *(uint32 *)(plVar1 + 2) = *(uint32 *)(a + 16);
            *(uint32 *)((int64)plVar1 + 20) = *(uint32 *)(a + 20);
            if ((*(byte *)(DAT_181e90f60 + 300) <= *(byte *)(*plVar1 + 300)) &&
               (*(int64 *)
                 (*(int64 *)(*plVar1 + 200) + -8 + (uint64)*(byte *)(DAT_181e90f60 + 300) * 8) ==
                DAT_181e90f60)) {
              *(float *)(plVar1 + 2) = b * *(float *)(plVar1 + 2);
              *(float *)((int64)plVar1 + 20) = b * *(float *)((int64)plVar1 + 20);
              return plVar1;
            }
                          // WARNING: Subroutine does not return
            FUN_1801dfd50(plVar1);
          }
        }
    }

    // Token : 0x600107F
    // RVA   : 0x9E4AB0   Offset: 0x9E38B0   Length: 0xE0
    public static BigMapPos op_Multiply(BigMapPos a, float b)
    {
        if (a != null) {
          plVar1 = (int64 *)il2cpp_internal(DAT_181e90f60);
          ZhSegment.Initialize(plVar1,0);
          if (plVar1 != (int64 *)0) {
            *(uint32 *)(plVar1 + 2) = *(uint32 *)(a + 16);
            *(uint32 *)((int64)plVar1 + 20) = *(uint32 *)(a + 20);
            if ((*(byte *)(DAT_181e90f60 + 300) <= *(byte *)(*plVar1 + 300)) &&
               (*(int64 *)
                 (*(int64 *)(*plVar1 + 200) + -8 + (uint64)*(byte *)(DAT_181e90f60 + 300) * 8) ==
                DAT_181e90f60)) {
              *(float *)(plVar1 + 2) = b * *(float *)(plVar1 + 2);
              *(float *)((int64)plVar1 + 20) = b * *(float *)((int64)plVar1 + 20);
              return plVar1;
            }
                          // WARNING: Subroutine does not return
            FUN_1801dfd50(plVar1);
          }
        }
    }

    // Token : 0x6001080
    // RVA   : 0x9E45D0   Offset: 0x9E33D0   Length: 0x66
    public virtual object Clone()
    {
        long lVar1;
        lVar1 = new ZhSegment(0);
        if (lVar1 != null) {
          *(uint32 *)(lVar1 + 16) = this.x;
          *(uint32 *)(lVar1 + 20) = this.y;
          return lVar1;
        }
    }

}
