// ============================================================
// Type  : BigMapPos
// Token : 0x2000217
// ============================================================

public class BigMapPos
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4000F41
    public float x;

    // Token: 0x4000F42
    public float y;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6001066
    // RVA   : 0x210B70   Offset: 0x20FF70   Length: 0x7
    public void /*ctor*/()
    {
        ZhSegment.Initialize(this,0);
        this.x = (float)*param_2 * 100.0;
        this.y = *(float *)((int64)param_2 + 4) * 100.0;
    }

    // Token : 0x6001067
    // RVA   : 0xC7B8B0   Offset: 0xC7ACB0   Length: 0x45
    public void /*ctor*/(Vector3 source)
    {
        ZhSegment.Initialize(this,0);
        this.x = (float)*source * 100.0;
        this.y = *(float *)((int64)source + 4) * 100.0;
    }

    // Token : 0x6001068
    // RVA   : 0xC7B7A0   Offset: 0xC7ABA0   Length: 0x7
    public void Reset()
    {
        this.x = 0;
    }

    // Token : 0x6001069
    // RVA   : 0xC7B7B0   Offset: 0xC7ABB0   Length: 0x2C
    public void SetByVector3(Vector3 source)
    {
        this.x = *source * 100.0;
        this.y = source[1] * 100.0;
    }

    // Token : 0x600106A
    // RVA   : 0xC7B6D0   Offset: 0xC7AAD0   Length: 0x21
    public bool IsZero()
    {
        if ((this.x == null.0) && (this.y == null.0)) {
          return true;
        }
        return false;
    }

    // Token : 0x600106B
    // RVA   : 0xC7B590   Offset: 0xC7A990   Length: 0x8A
    public float Distance(BigMapPos target)
    {
        float fVar1;
        float fVar2;
        ulong uVar3;
        if (target == null) {
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
        fVar1 = (float)FUN_1801f8ab0(*(float *)(target + 20) - this.y,0x40000000);
        fVar2 = (float)FUN_1801f8ab0(*(float *)(target + 16) - this.x);
        fVar1 = fVar1 + fVar2;
        if (0.0 <= fVar1) {
          return (uint64)(uint32)SQRT(fVar1);
        }
        uVar3 = FUN_1801f9ff4(fVar1);
        return uVar3;
    }

    // Token : 0x600106C
    // RVA   : 0xC7B700   Offset: 0xC7AB00   Length: 0x93
    public int QuickTravelTime(BigMapPos target)
    {
        uint uVar1;
        float fVar2;
        float fVar3;
        if (target != null) {
          fVar2 = (float)FUN_1801f8ab0(*(float *)(target + 16) - this.x,0x40000000)
          ;
          fVar3 = (float)FUN_1801f8ab0(*(float *)(target + 20) - this.y);
          if (fVar3 + fVar2 < 0.0) {
            fVar2 = (float)FUN_1801f9ff4();
          }
          else {
            fVar2 = SQRT(fVar3 + fVar2);
          }
          uVar1 = Mathf.CeilToInt(fVar2 / 3300.0,0);
          Mathf.Max(1,uVar1);
          return;
        }
    }

    // Token : 0x600106D
    // RVA   : 0xC7B870   Offset: 0xC7AC70   Length: 0x40
    public Vector3 ToVector3()
    {
        *this = CONCAT44(param_3 * *(float *)(param_2 + 20),param_3 * *(float *)(param_2 + 16));
        *(float *)(this + 1) = param_3 * 0.0;
        return this;
    }

    // Token : 0x600106E
    // RVA   : 0xC7B830   Offset: 0xC7AC30   Length: 0x3A
    public Vector3 ToVector3(float multi)
    {
        *this = CONCAT44(param_3 * *(float *)(multi + 20),param_3 * *(float *)(multi + 16));
        *(float *)(this + 1) = param_3 * 0.0;
        return this;
    }

    // Token : 0x600106F
    // RVA   : 0xC7B800   Offset: 0xC7AC00   Length: 0x23
    public Vector2 ToVector2()
    {
        uint64 FUN_180c7b7e0(int64 this,float param_2)
        {
        return CONCAT44(this.y * param_2,param_2 * this.x);
    }

    // Token : 0x6001070
    // RVA   : 0xC7B7E0   Offset: 0xC7ABE0   Length: 0x1A
    public Vector2 ToVector2(float multi)
    {
        uint64 FUN_180c7b7e0(int64 this,float multi)
        {
        return CONCAT44(this.y * multi,multi * this.x);
    }

    // Token : 0x6001071
    // RVA   : 0xC7B620   Offset: 0xC7AA20   Length: 0xA3
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

    // Token : 0x6001072
    // RVA   : 0xC7B900   Offset: 0xC7AD00   Length: 0xB0
    public static BigMapPos op_Addition(BigMapPos a, BigMapPos b)
    {
        if (a != null) {
          plVar1 = (int64 *)BigMapPos.Clone(a,0);
          if (plVar1 != (int64 *)0) {
            if (b != null) {
              *(float *)(plVar1 + 2) = *(float *)(b + 16) + *(float *)(plVar1 + 2);
              *(float *)((int64)plVar1 + 20) =
                   *(float *)(b + 20) + *(float *)((int64)plVar1 + 20);
              return plVar1;
            }
          }
        }
    }

    // Token : 0x6001073
    // RVA   : 0xC7BA80   Offset: 0xC7AE80   Length: 0xB0
    public static BigMapPos op_Subtraction(BigMapPos a, BigMapPos b)
    {
        if (a != null) {
          plVar1 = (int64 *)BigMapPos.Clone(a,0);
          if (plVar1 != (int64 *)0) {
            if (b != null) {
              *(float *)(plVar1 + 2) = *(float *)(plVar1 + 2) - *(float *)(b + 16);
              *(float *)((int64)plVar1 + 20) =
                   *(float *)((int64)plVar1 + 20) - *(float *)(b + 20);
              return plVar1;
            }
          }
        }
    }

    // Token : 0x6001074
    // RVA   : 0xC7B9C0   Offset: 0xC7ADC0   Length: 0xF
    public static BigMapPos op_Multiply(BigMapPos a, int b)
    {
        if (a != null) {
          plVar1 = (int64 *)BigMapPos.Clone(a,0);
          if (plVar1 != (int64 *)0) {
            if ((*(byte *)(DAT_181db0cc8 + 300) <= *(byte *)(*plVar1 + 300)) &&
               (*(int64 *)
                 (*(int64 *)(*plVar1 + 200) + -8 + (uint64)*(byte *)(DAT_181db0cc8 + 300) * 8) ==
                DAT_181db0cc8)) {
              *(float *)(plVar1 + 2) = b * *(float *)(plVar1 + 2);
              *(float *)((int64)plVar1 + 20) = b * *(float *)((int64)plVar1 + 20);
              return plVar1;
            }
                          // WARNING: Subroutine does not return
            FUN_1800d6070(plVar1,DAT_181db0cc8);
          }
        }
    }

    // Token : 0x6001075
    // RVA   : 0xC7B9D0   Offset: 0xC7ADD0   Length: 0xA5
    public static BigMapPos op_Multiply(BigMapPos a, float b)
    {
        if (a != null) {
          plVar1 = (int64 *)BigMapPos.Clone(a,0);
          if (plVar1 != (int64 *)0) {
            if ((*(byte *)(DAT_181db0cc8 + 300) <= *(byte *)(*plVar1 + 300)) &&
               (*(int64 *)
                 (*(int64 *)(*plVar1 + 200) + -8 + (uint64)*(byte *)(DAT_181db0cc8 + 300) * 8) ==
                DAT_181db0cc8)) {
              *(float *)(plVar1 + 2) = b * *(float *)(plVar1 + 2);
              *(float *)((int64)plVar1 + 20) = b * *(float *)((int64)plVar1 + 20);
              return plVar1;
            }
                          // WARNING: Subroutine does not return
            FUN_1800d6070(plVar1,DAT_181db0cc8);
          }
        }
    }

    // Token : 0x6001076
    // RVA   : 0xC7B3B0   Offset: 0xC7A7B0   Length: 0x1DD
    public virtual object Clone()
    {
        long lVar2;
        ulong uVar3;
        ushort uVar5;
        ulong local_38;
        ulong uStack_30;
        uint local_28;
        uint uStack_24;
        uint uStack_20;
        uint32 uStack_1c;
        uint64 uVar6;
        uVar6 = 0;
        plVar1 = (int64 *)il2cpp_internal(DAT_181d89210);
        plVar7 = plVar1;
        MemoryStream.ctor(plVar1,1000,0);
        local_38 = 0;
        uStack_30 = 0;
        StreamingContext.ctor(&local_38,64,0);
        lVar2 = il2cpp_internal(DAT_181db1730);
        local_28 = (uint32)local_38;
        uStack_24 = local_38._4_4_;
        uStack_20 = (uint32)uStack_30;
        uStack_1c = uStack_30._4_4_;
        BinaryFormatter.ctor(lVar2,0,&local_28,0,plVar7);
        if (lVar2 == null) {
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
        BinaryFormatter.Serialize(lVar2,plVar1,this,0);
        if (plVar1 == (int64 *)0) {
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
        (**(code **)(*plVar1 + 0x2c8))(plVar1,0,0,*(uint64 *)(*plVar1 + 0x2d0));
        uVar3 = BinaryFormatter.Deserialize(lVar2,plVar1,0);
        (**(code **)(*plVar1 + 0x238))(plVar1,*(uint64 *)(*plVar1 + 0x240));
        lVar2 = *plVar1;
        if (*(uint16 *)(lVar2 + 0x12a) != 0) {
          do {
            if (*(int64 *)(*(int64 *)(lVar2 + 176) + uVar6 * 16) == DAT_181d78da0) {
              puVar4 = (uint64 *)
                       ((int64)*(int *)(*(int64 *)(lVar2 + 176) + 8 + uVar6 * 16) * 16 + 0x138
                       + lVar2);
              goto LAB_180c7b534;
            }
            uVar5 = (short)uVar6 + 1;
            uVar6 = (uint64)uVar5;
          } while (uVar5 < *(uint16 *)(lVar2 + 0x12a));
        }
        puVar4 = (uint64 *)FUN_1800914f0(plVar1,DAT_181d78da0,0);
        LAB_180c7b534:
        (*(code *)*puVar4)(plVar1,puVar4[1]);
        return uVar3;
    }

}
