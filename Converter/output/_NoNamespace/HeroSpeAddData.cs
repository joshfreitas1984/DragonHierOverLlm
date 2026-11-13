// ============================================================
// Type  : HeroSpeAddData
// Token : 0x2000225
// ============================================================

public class HeroSpeAddData
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001152
    public Dictionary<int, float> heroSpeAddData;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6001247
    // RVA   : 0x89F600   Offset: 0x89E400   Length: 0x76
    public void /*ctor*/()
    {
        ulong uVar1;
        ZhSegment.Initialize(this,0);
        uVar1 = il2cpp_internal(DAT_181e613c8);
        FUN_1806e5bc0(uVar1,DAT_181e9f2b8);
        this.heroSpeAddData = uVar1;
    }

    // Token : 0x6001248
    // RVA   : 0x89F440   Offset: 0x89E240   Length: 0x94
    public void Reset()
    {
        ulong uVar1;
        if (this.heroSpeAddData != null) {
          Dictionary_2.Clear(this.heroSpeAddData,DAT_181e9f560);
          return;
        }
        uVar1 = il2cpp_internal(DAT_181e613c8);
        FUN_1806e5bc0(uVar1,DAT_181e9f2b8);
        this.heroSpeAddData = uVar1;
    }

    // Token : 0x6001249
    // RVA   : 0x89F240   Offset: 0x89E040   Length: 0x1F8
    public void OverWriteHeroSpeAddData(HeroSpeAddData overWriteData)
    {
        ulong uVar1;
        bool cVar2;
        long lVar3;
        float[] local_res10 = new float[2];
        float[] local_res20 = new float[2];
        uint local_48;
        uint uStack_44;
        uint uStack_40;
        uint32 uStack_3c;
        uint64 local_38;
        uint32 local_30;
        uint32 uStack_2c;
        uint32 uStack_28;
        uint32 uStack_24;
        uint64 local_20;
        local_res10[0] = 0.0;
        local_res20[0] = 0.0;
        if (((overWriteData != null) && (*(int64 *)(overWriteData + 16) != 0)) &&
           (lVar3 = Dictionary_2.get_Keys(*(int64 *)(overWriteData + 16),DAT_181e9fd50)) != null) {
          FUN_180b274e0(&local_30,lVar3,DAT_181ea5920);
          local_48 = local_30;
          uStack_44 = uStack_2c;
          uStack_40 = uStack_28;
          uStack_3c = uStack_24;
          local_38 = local_20;
          while( true ) {
            cVar2 = FUN_180dd6f80(&local_48,DAT_181e7d130);
            uVar1 = local_38;
            if (!cVar2) {
              ZhSegment.Initialize(&local_48,DAT_181e7d0b0);
              return;
            }
            if (*(int64 *)(overWriteData + 16) == 0) break;
            cVar2 = FUN_181691540(*(int64 *)(overWriteData + 16),local_38 & 0xffffffff,local_res10,
                                  DAT_181e9fb30);
            if ((cVar2) && (local_res10[0] != 0.0)) {
              if (this.heroSpeAddData == null) {
                          // WARNING: Subroutine does not return
                FUN_1801e0300();
              }
              cVar2 = FUN_181691540(this.heroSpeAddData,uVar1 & 0xffffffff,local_res20,
                                    DAT_181e9fb30);
              if (((!cVar2) || (local_res20[0] == 0.0)) || (local_res20[0] < local_res10[0])) {
                HeroSpeAddData.Set(this,uVar1 & 0xffffffff,local_res10[0],0);
              }
            }
          }
                          // WARNING: Subroutine does not return
          FUN_1801e0300();
        }
    }

    // Token : 0x600124A
    // RVA   : 0x89F4E0   Offset: 0x89E2E0   Length: 0x8
    public HeroSpeAddData Set(HeroSpeAddDataType speAddDataType, float value)
    {
        long lVar1;
        bool cVar2;
        if (this.heroSpeAddData != null) {
          cVar2 = FUN_1806da450(this.heroSpeAddData,speAddDataType,DAT_181e9f5e8);
          if (!cVar2) {
            if (value == null.0) {
              return this;
            }
            if (this.heroSpeAddData != null) {
              FUN_1816f1570(this.heroSpeAddData,speAddDataType,value,DAT_181e9f4d8);
              return this;
            }
          }
          else {
            lVar1 = this.heroSpeAddData;
            if (value == null.0) {
              if (lVar1 != null) {
                FUN_181687e20(lVar1,speAddDataType,DAT_181e9f998);
                return this;
              }
            }
            else if (lVar1 != null) {
              FUN_181707560(lVar1,speAddDataType,value,DAT_181e9fdd8);
              return this;
            }
          }
        }
    }

    // Token : 0x600124B
    // RVA   : 0x89F4F0   Offset: 0x89E2F0   Length: 0x10C
    public HeroSpeAddData Set(int speAddDataType, float value)
    {
        long lVar1;
        bool cVar2;
        if (this.heroSpeAddData != null) {
          cVar2 = FUN_1806da450(this.heroSpeAddData,speAddDataType,DAT_181e9f5e8);
          if (!cVar2) {
            if (value == null.0) {
              return this;
            }
            if (this.heroSpeAddData != null) {
              FUN_1816f1570(this.heroSpeAddData,speAddDataType,value,DAT_181e9f4d8);
              return this;
            }
          }
          else {
            lVar1 = this.heroSpeAddData;
            if (value == null.0) {
              if (lVar1 != null) {
                FUN_181687e20(lVar1,speAddDataType,DAT_181e9f998);
                return this;
              }
            }
            else if (lVar1 != null) {
              FUN_181707560(lVar1,speAddDataType,value,DAT_181e9fdd8);
              return this;
            }
          }
        }
    }

    // Token : 0x600124C
    // RVA   : 0x89EE70   Offset: 0x89DC70   Length: 0x8
    public float Get(HeroSpeAddDataType speAddDataType)
    {
        bool cVar1;
        uint[] local_res10 = new uint[6];
        local_res10[0] = 0;
        if (this.heroSpeAddData != null) {
          cVar1 = FUN_181691540(this.heroSpeAddData,speAddDataType,local_res10,DAT_181e9fb30);
          if (!cVar1) {
            return 0;
          }
          return local_res10[0];
        }
    }

    // Token : 0x600124D
    // RVA   : 0x89EE80   Offset: 0x89DC80   Length: 0x77
    public float Get(int speAddDataType)
    {
        bool cVar1;
        uint[] local_res10 = new uint[6];
        local_res10[0] = 0;
        if (this.heroSpeAddData != null) {
          cVar1 = FUN_181691540(this.heroSpeAddData,speAddDataType,local_res10,DAT_181e9fb30);
          if (!cVar1) {
            return 0;
          }
          return local_res10[0];
        }
    }

    // Token : 0x600124E
    // RVA   : 0x89DE70   Offset: 0x89CC70   Length: 0x8
    public void Change(HeroSpeAddDataType speAddDataType, float delta)
    {
        long lVar1;
        bool cVar2;
        float[] local_res10 = new float[6];
        local_res10[0] = 0.0;
        if (this.heroSpeAddData == null) goto LAB_18089de60;
        cVar2 = FUN_181691540(this.heroSpeAddData,speAddDataType,local_res10,DAT_181e9fb30);
        if (!cVar2) {
          if (delta != null.0) {
            if (this.heroSpeAddData == null) goto LAB_18089de60;
            FUN_1816f1570(this.heroSpeAddData,speAddDataType,delta,DAT_181e9f4d8);
          }
        }
        else {
          lVar1 = this.heroSpeAddData;
          if (local_res10[0] + delta == null.0) {
            if (lVar1 == null) {
        LAB_18089de60:
                          // WARNING: Subroutine does not return
              FUN_1801e0300();
            }
            FUN_181687e20(lVar1,speAddDataType,DAT_181e9f998);
          }
          else {
            if (lVar1 == null) goto LAB_18089de60;
            FUN_181707560(lVar1,speAddDataType,local_res10[0] + delta,DAT_181e9fdd8);
          }
        }
    }

    // Token : 0x600124F
    // RVA   : 0x89DD60   Offset: 0x89CB60   Length: 0x105
    public void Change(int speAddDataType, float delta)
    {
        long lVar1;
        bool cVar2;
        float[] local_res10 = new float[6];
        local_res10[0] = 0.0;
        if (this.heroSpeAddData == null) goto LAB_18089de60;
        cVar2 = FUN_181691540(this.heroSpeAddData,speAddDataType,local_res10,DAT_181e9fb30);
        if (!cVar2) {
          if (delta != null.0) {
            if (this.heroSpeAddData == null) goto LAB_18089de60;
            FUN_1816f1570(this.heroSpeAddData,speAddDataType,delta,DAT_181e9f4d8);
          }
        }
        else {
          lVar1 = this.heroSpeAddData;
          if (local_res10[0] + delta == null.0) {
            if (lVar1 == null) {
        LAB_18089de60:
                          // WARNING: Subroutine does not return
              FUN_1801e0300();
            }
            FUN_181687e20(lVar1,speAddDataType,DAT_181e9f998);
          }
          else {
            if (lVar1 == null) goto LAB_18089de60;
            FUN_181707560(lVar1,speAddDataType,local_res10[0] + delta,DAT_181e9fdd8);
          }
        }
    }

    // Token : 0x6001250
    // RVA   : 0x89DC40   Offset: 0x89CA40   Length: 0x8
    public void ChangeMulti(HeroSpeAddDataType speAddDataType, float multi)
    {
        long lVar1;
        bool cVar2;
        float[] local_res10 = new float[6];
        local_res10[0] = 0.0;
        if (this.heroSpeAddData == null) goto LAB_18089dd54;
        cVar2 = FUN_181691540(this.heroSpeAddData,speAddDataType,local_res10,DAT_181e9fb30);
        if (!cVar2) {
          if (multi * 0.0 != null.0) {
            if (this.heroSpeAddData == null) goto LAB_18089dd54;
            FUN_1816f1570(this.heroSpeAddData,speAddDataType,multi * 0.0,DAT_181e9f4d8);
          }
        }
        else {
          lVar1 = this.heroSpeAddData;
          if (local_res10[0] * multi == null.0) {
            if (lVar1 == null) {
        LAB_18089dd54:
                          // WARNING: Subroutine does not return
              FUN_1801e0300();
            }
            FUN_181687e20(lVar1,speAddDataType,DAT_181e9f998);
          }
          else {
            if (lVar1 == null) goto LAB_18089dd54;
            FUN_181707560(lVar1,speAddDataType,local_res10[0] * multi,DAT_181e9fdd8);
          }
        }
    }

    // Token : 0x6001251
    // RVA   : 0x89DC50   Offset: 0x89CA50   Length: 0x109
    public void ChangeMulti(int speAddDataType, float multi)
    {
        long lVar1;
        bool cVar2;
        float[] local_res10 = new float[6];
        local_res10[0] = 0.0;
        if (this.heroSpeAddData == null) goto LAB_18089dd54;
        cVar2 = FUN_181691540(this.heroSpeAddData,speAddDataType,local_res10,DAT_181e9fb30);
        if (!cVar2) {
          if (multi * 0.0 != null.0) {
            if (this.heroSpeAddData == null) goto LAB_18089dd54;
            FUN_1816f1570(this.heroSpeAddData,speAddDataType,multi * 0.0,DAT_181e9f4d8);
          }
        }
        else {
          lVar1 = this.heroSpeAddData;
          if (local_res10[0] * multi == null.0) {
            if (lVar1 == null) {
        LAB_18089dd54:
                          // WARNING: Subroutine does not return
              FUN_1801e0300();
            }
            FUN_181687e20(lVar1,speAddDataType,DAT_181e9f998);
          }
          else {
            if (lVar1 == null) goto LAB_18089dd54;
            FUN_181707560(lVar1,speAddDataType,local_res10[0] * multi,DAT_181e9fdd8);
          }
        }
    }

    // Token : 0x6001252
    // RVA   : 0x89D8C0   Offset: 0x89C6C0   Length: 0x37E
    public void AddAll(HeroSpeAddData other)
    {
        uint uVar1;
        long lVar2;
        ulong uVar3;
        bool cVar4;
        int iVar5;
        ulong uVar6;
        long lVar7;
        uint uVar8;
        long lVar9;
        float fVar10;
        float[] local_res10 = new float[2];
        float fStackX_24;
        uint local_70;
        uint32 uStack_6c;
        uint32 uStack_68;
        uint32 uStack_64;
        uint64 local_60;
        uint64 uStack_58;
        uint32 local_50;
        uint32 uStack_4c;
        uint32 uStack_48;
        uint32 uStack_44;
        uint64 local_40;
        uint64 uStack_38;
        local_res10[0] = 0.0;
        if (((other == null) || (*(int64 *)(other + 16) == 0)) ||
           (iVar5 = Dictionary_2.get_Count(*(int64 *)(other + 16),DAT_181e9fc40)) == null) {
          return;
        }
        if ((other == this) ||
           (lVar7 = *(int64 *)(other + 16), lVar7 == this.heroSpeAddData)) {
          if (this.heroSpeAddData != null) {
            uVar6 = Dictionary_2.get_Keys(this.heroSpeAddData,DAT_181e9fd50);
            lVar7 = il2cpp_internal(DAT_181e73cb8);
            FUN_18177a7d0(lVar7,uVar6,DAT_181e712f0);
            uVar8 = 0;
            if (lVar7 != null) {
              lVar9 = 32;
              while( true ) {
                while( true ) {
                  if ((int)lVar7.entries <= (int)uVar8) {
                    return;
                  }
                  if (lVar7.entries <= uVar8) {
                    ThrowHelper.ThrowArgumentOutOfRangeException(0);
                  }
                  uVar1 = *(uint32 *)(lVar9 + lVar7.buckets);
                  fVar10 = (float)HeroSpeAddData.Get(this,uVar1,0);
                  lVar2 = this.heroSpeAddData;
                  if (fVar10 + fVar10 == 0.0) break;
                  if (lVar2 == null) throw; // [null/range check failed]
                  FUN_181707560(lVar2,uVar1,fVar10 + fVar10,DAT_181e9fdd8);
                  uVar8 = uVar8 + 1;
                  lVar9 = lVar9 + 4;
                }
                if (lVar2 == null) break;
                FUN_181687e20(lVar2,uVar1);
                uVar8 = uVar8 + 1;
                lVar9 = lVar9 + 4;
              }
            }
          }
        }
        else if (lVar7 != null) {
          FUN_18125c400(&local_50,lVar7,DAT_181e9f778);
          local_70 = local_50;
          uStack_6c = uStack_4c;
          uStack_68 = uStack_48;
          uStack_64 = uStack_44;
          local_60 = local_40;
          uStack_58 = uStack_38;
          while( true ) {
            cVar4 = FUN_180dd5b00(&local_70,DAT_181e7cd30);
            uVar3 = local_60;
            if (!cVar4) {
              ZhSegment.Initialize(&local_70,DAT_181e7ccb0);
              return;
            }
            if (this.heroSpeAddData == null) break;
            cVar4 = FUN_181691540(this.heroSpeAddData,local_60 & 0xffffffff,local_res10,
                                  DAT_181e9fb30);
            fStackX_24 = (float)(uVar3 >> 32);
            if (!cVar4) {
              if (fStackX_24 != 0.0) {
                if (this.heroSpeAddData == null) {
                          // WARNING: Subroutine does not return
                  FUN_1801e0300();
                }
                FUN_1816f1570(this.heroSpeAddData,uVar3 & 0xffffffff,fStackX_24,DAT_181e9f4d8);
              }
            }
            else {
              lVar7 = this.heroSpeAddData;
              if (fStackX_24 + local_res10[0] == 0.0) {
                if (lVar7 == null) {
                          // WARNING: Subroutine does not return
                  FUN_1801e0300();
                }
                FUN_181687e20(lVar7,uVar3 & 0xffffffff,DAT_181e9f998);
              }
              else {
                if (lVar7 == null) {
                          // WARNING: Subroutine does not return
                  FUN_1801e0300();
                }
                FUN_181707560(lVar7,uVar3 & 0xffffffff,fStackX_24 + local_res10[0],DAT_181e9fdd8);
              }
            }
          }
                          // WARNING: Subroutine does not return
          FUN_1801e0300();
        }
    }

    // Token : 0x6001253
    // RVA   : 0x89EAD0   Offset: 0x89D8D0   Length: 0x5F
    public List<int> GetKeys()
    {
        ulong uVar1;
        if (this.heroSpeAddData != null) {
          uVar1 = Dictionary_2.get_Keys(this.heroSpeAddData,DAT_181e9fd50);
          FUN_18077cf20(uVar1,DAT_181e98ba0);
          return;
        }
    }

    // Token : 0x6001254
    // RVA   : 0x89F680   Offset: 0x89E480   Length: 0x1D3
    public bool isEmpty()
    {
        bool cVar1;
        long lVar2;
        ulong uVar3;
        int iVar4;
        float fVar5;
        int[] aiStack_64 = new int[5];
        uint local_50;
        uint32 uStack_4c;
        uint32 uStack_48;
        uint32 uStack_44;
        uint64 local_40;
        uint32 local_38;
        uint32 uStack_34;
        uint32 uStack_30;
        uint32 uStack_2c;
        uint64 local_28;
        aiStack_64[3] = 0;
        if ((this.heroSpeAddData == null) ||
           (lVar2 = Dictionary_2.get_Keys(this.heroSpeAddData,DAT_181e9fd50)) == null) {
                          // WARNING: Subroutine does not return
          FUN_1801e0300();
        }
        FUN_180b274e0(&local_38,lVar2,DAT_181ea5920);
        local_50 = local_38;
        uStack_4c = uStack_34;
        uStack_48 = uStack_30;
        uStack_44 = uStack_2c;
        local_40 = local_28;
        do {
          cVar1 = FUN_180dd6f80(&local_50,DAT_181e7d130);
          if (!cVar1) {
            aiStack_64[1] = 75;
            iVar4 = aiStack_64[3] + 1;
            aiStack_64[3] = iVar4;
            ZhSegment.Initialize(&local_50,DAT_181e7d0b0);
            goto LAB_18089f810;
          }
          if (this.heroSpeAddData == null) {
                          // WARNING: Subroutine does not return
            FUN_1801e0300();
          }
          fVar5 = (float)FUN_18171b3b0(this.heroSpeAddData,local_40 & 0xffffffff,DAT_181e9fcc8);
        } while (fVar5 == 0.0);
        aiStack_64[1] = 77;
        iVar4 = aiStack_64[3] + 1;
        aiStack_64[3] = iVar4;
        ZhSegment.Initialize(&local_50,DAT_181e7d0b0);
        LAB_18089f810:
        if ((iVar4 == 0) || (aiStack_64[iVar4] != 77)) {
          uVar3 = 1;
        }
        else {
          uVar3 = 0;
        }
        return uVar3;
    }

    // Token : 0x6001255
    // RVA   : 0x89F860   Offset: 0x89E660   Length: 0x299
    public static HeroSpeAddData op_Addition(HeroSpeAddData a, HeroSpeAddData b)
    {
        ulong uVar1;
        bool cVar2;
        long lVar4;
        uint uVar6;
        ulong local_48;
        ulong uStack_40;
        ulong local_38;
        byte[] local_30 = new byte[16];
        ulong local_20;
        local_48 = 0;
        uStack_40 = 0;
        local_38 = 0;
        plVar5 = (int64 *)0;
        if (a == null) {
          local_38 = 0;
          uStack_40 = 0;
          local_48 = 0;
          if (b == null) {
            plVar5 = (int64 *)il2cpp_internal(DAT_181e55ea0);
            HeroSpeAddData.ctor(plVar5,0);
          }
          else {
            plVar3 = (int64 *)HeroSpeAddData.Clone(b,0);
            if (plVar3 != (int64 *)0) {
            }
          }
        }
        else {
          plVar3 = (int64 *)HeroSpeAddData.Clone(a,0);
          if (plVar3 != (int64 *)0) {
          }
          if (b != null) {
            if ((*(int64 *)(b + 16) == 0) ||
               (lVar4 = Dictionary_2.get_Keys(*(int64 *)(b + 16),DAT_181e9fd50)) == null)
            {
                          // WARNING: Subroutine does not return
              FUN_1801e0300();
            }
            FUN_180b274e0(local_30,lVar4,DAT_181ea5920);
            local_38 = local_20;
            while (cVar2 = FUN_180dd6f80(&local_48,DAT_181e7d130), uVar1 = local_38, cVar2) {
              uVar6 = HeroSpeAddData.Get(b,local_38 & 0xffffffff,0);
              if (plVar5 == (int64 *)0) {
                          // WARNING: Subroutine does not return
                FUN_1801e0300();
              }
              HeroSpeAddData.Change(plVar5,uVar1 & 0xffffffff,uVar6,0);
            }
            ZhSegment.Initialize(&local_48,DAT_181e7d0b0);
          }
        }
        return plVar5;
    }

    // Token : 0x6001256
    // RVA   : 0x89FD40   Offset: 0x89EB40   Length: 0xF
    public static HeroSpeAddData op_Multiply(HeroSpeAddData a, int b)
    {
        ulong uVar1;
        bool cVar2;
        long lVar4;
        uint local_50;
        uint32 uStack_4c;
        uint32 uStack_48;
        uint32 uStack_44;
        uint64 local_40;
        uint32 local_38;
        uint32 uStack_34;
        uint32 uStack_30;
        uint32 uStack_2c;
        uint64 local_28;
        if (a != null) {
          plVar3 = (int64 *)HeroSpeAddData.Clone(a,0);
          if ((*(int64 *)(a + 16) != 0) &&
             (lVar4 = Dictionary_2.get_Keys(*(int64 *)(a + 16),DAT_181e9fd50)) != null) {
            FUN_180b274e0(&local_38,lVar4,DAT_181ea5920);
            local_50 = local_38;
            uStack_4c = uStack_34;
            uStack_48 = uStack_30;
            uStack_44 = uStack_2c;
            local_40 = local_28;
            while( true ) {
              cVar2 = FUN_180dd6f80(&local_50,DAT_181e7d130);
              uVar1 = local_40;
              if (!cVar2) {
                ZhSegment.Initialize(&local_50,DAT_181e7d0b0);
                return plVar3;
              }
              lVar4 = FUN_180210740(0);
              if (lVar4 == null) {
                          // WARNING: Subroutine does not return
                FUN_1801e0300();
              }
              if (*(int64 *)(lVar4 + 144) == 0) {
                          // WARNING: Subroutine does not return
                FUN_1801e0300();
              }
              lVar4 = FUN_1800024b0(*(int64 *)(lVar4 + 144),uVar1 & 0xffffffff,DAT_181e6e1f0);
              if (lVar4 == null) break;
              if (*(char *)(lVar4 + 80) == false) {
                if (plVar3 == (int64 *)0) {
                          // WARNING: Subroutine does not return
                  FUN_1801e0300();
                }
                HeroSpeAddData.ChangeMulti(plVar3,uVar1 & 0xffffffff,b,0);
              }
            }
                          // WARNING: Subroutine does not return
            FUN_1801e0300();
          }
        }
    }

    // Token : 0x6001257
    // RVA   : 0x89FB00   Offset: 0x89E900   Length: 0x235
    public static HeroSpeAddData op_Multiply(HeroSpeAddData a, float b)
    {
        ulong uVar1;
        bool cVar2;
        long lVar4;
        uint local_50;
        uint32 uStack_4c;
        uint32 uStack_48;
        uint32 uStack_44;
        uint64 local_40;
        uint32 local_38;
        uint32 uStack_34;
        uint32 uStack_30;
        uint32 uStack_2c;
        uint64 local_28;
        if (a != null) {
          plVar3 = (int64 *)HeroSpeAddData.Clone(a,0);
          if ((*(int64 *)(a + 16) != 0) &&
             (lVar4 = Dictionary_2.get_Keys(*(int64 *)(a + 16),DAT_181e9fd50)) != null) {
            FUN_180b274e0(&local_38,lVar4,DAT_181ea5920);
            local_50 = local_38;
            uStack_4c = uStack_34;
            uStack_48 = uStack_30;
            uStack_44 = uStack_2c;
            local_40 = local_28;
            while( true ) {
              cVar2 = FUN_180dd6f80(&local_50,DAT_181e7d130);
              uVar1 = local_40;
              if (!cVar2) {
                ZhSegment.Initialize(&local_50,DAT_181e7d0b0);
                return plVar3;
              }
              lVar4 = FUN_180210740(0);
              if (lVar4 == null) {
                          // WARNING: Subroutine does not return
                FUN_1801e0300();
              }
              if (*(int64 *)(lVar4 + 144) == 0) {
                          // WARNING: Subroutine does not return
                FUN_1801e0300();
              }
              lVar4 = FUN_1800024b0(*(int64 *)(lVar4 + 144),uVar1 & 0xffffffff,DAT_181e6e1f0);
              if (lVar4 == null) break;
              if (*(char *)(lVar4 + 80) == false) {
                if (plVar3 == (int64 *)0) {
                          // WARNING: Subroutine does not return
                  FUN_1801e0300();
                }
                HeroSpeAddData.ChangeMulti(plVar3,uVar1 & 0xffffffff,b,0);
              }
            }
                          // WARNING: Subroutine does not return
            FUN_1801e0300();
          }
        }
    }

    // Token : 0x6001258
    // RVA   : 0x89F090   Offset: 0x89DE90   Length: 0x1A6
    public HeroSpeAddData Multi(float b)
    {
        bool cVar1;
        long lVar3;
        uint local_48;
        uint uStack_44;
        uint uStack_40;
        uint32 uStack_3c;
        uint64 local_38;
        uint32 local_30;
        uint32 uStack_2c;
        uint32 uStack_28;
        uint32 uStack_24;
        uint64 local_20;
        plVar2 = (int64 *)HeroSpeAddData.Clone(this,0);
        if ((this.heroSpeAddData != null) &&
           (lVar3 = Dictionary_2.get_Keys(this.heroSpeAddData,DAT_181e9fd50)) != null) {
          FUN_180b274e0(&local_30,lVar3,DAT_181ea5920);
          local_48 = local_30;
          uStack_44 = uStack_2c;
          uStack_40 = uStack_28;
          uStack_3c = uStack_24;
          local_38 = local_20;
          while( true ) {
            cVar1 = FUN_180dd6f80(&local_48,DAT_181e7d130);
            if (!cVar1) {
              ZhSegment.Initialize(&local_48,DAT_181e7d0b0);
              return plVar2;
            }
            if (plVar2 == (int64 *)0) break;
            HeroSpeAddData.ChangeMulti(plVar2,local_38 & 0xffffffff,b,0);
          }
                          // WARNING: Subroutine does not return
          FUN_1801e0300();
        }
    }

    // Token : 0x6001259
    // RVA   : 0x89FD50   Offset: 0x89EB50   Length: 0x234
    public static HeroSpeAddData op_Subtraction(HeroSpeAddData a, HeroSpeAddData b)
    {
        ulong uVar1;
        bool cVar2;
        long lVar4;
        uint uVar5;
        uint[] local_res8 = new uint[2];
        uint local_50;
        uint32 uStack_4c;
        uint32 uStack_48;
        uint32 uStack_44;
        uint64 local_40;
        uint32 local_38;
        uint32 uStack_34;
        uint32 uStack_30;
        uint32 uStack_2c;
        uint64 local_28;
        if (a != null) {
          plVar3 = (int64 *)HeroSpeAddData.Clone(a,0);
          if (((b != null) && (*(int64 *)(b + 16) != 0)) &&
             (lVar4 = Dictionary_2.get_Keys(*(int64 *)(b + 16),DAT_181e9fd50)) != null) {
            FUN_180b274e0(&local_38,lVar4,DAT_181ea5920);
            local_50 = local_38;
            uStack_4c = uStack_34;
            uStack_48 = uStack_30;
            uStack_44 = uStack_2c;
            local_40 = local_28;
            while( true ) {
              cVar2 = FUN_180dd6f80(&local_50,DAT_181e7d130);
              uVar1 = local_40;
              if (!cVar2) {
                ZhSegment.Initialize(&local_50,DAT_181e7d0b0);
                return plVar3;
              }
              local_res8[0] = 0;
              if (*(int64 *)(b + 16) == 0) break;
              cVar2 = FUN_181691540(*(int64 *)(b + 16),uVar1 & 0xffffffff,local_res8,
                                    DAT_181e9fb30);
              uVar5 = local_res8[0];
              if (!cVar2) {
                uVar5 = 0;
              }
              if (plVar3 == (int64 *)0) {
                          // WARNING: Subroutine does not return
                FUN_1801e0300();
              }
              HeroSpeAddData.Change(plVar3,uVar1 & 0xffffffff,uVar5 ^ 0x80000000,0);
            }
                          // WARNING: Subroutine does not return
            FUN_1801e0300();
          }
        }
    }

    // Token : 0x600125A
    // RVA   : 0x89EC60   Offset: 0x89DA60   Length: 0x200
    public float GetValue()
    {
        ulong uVar1;
        bool cVar2;
        long lVar3;
        float fVar4;
        float fVar5;
        uint local_60;
        uint32 uStack_5c;
        uint32 uStack_58;
        uint32 uStack_54;
        uint64 local_50;
        uint32 local_48;
        uint32 uStack_44;
        uint32 uStack_40;
        uint32 uStack_3c;
        uint64 local_38;
        fVar5 = 0.0;
        if (this.heroSpeAddData != null) {
          lVar3 = Dictionary_2.get_Keys(this.heroSpeAddData,DAT_181e9fd50);
          if (lVar3 != null) {
            FUN_180b274e0(&local_48,lVar3,DAT_181ea5920);
            local_60 = local_48;
            uStack_5c = uStack_44;
            uStack_58 = uStack_40;
            uStack_54 = uStack_3c;
            local_50 = local_38;
            while( true ) {
              cVar2 = FUN_180dd6f80(&local_60,DAT_181e7d130);
              uVar1 = local_50;
              if (!cVar2) {
                ZhSegment.Initialize(&local_60,DAT_181e7d0b0);
                return fVar5;
              }
              if (this.heroSpeAddData == null) {
                          // WARNING: Subroutine does not return
                FUN_1801e0300();
              }
              fVar4 = (float)FUN_18171b3b0(this.heroSpeAddData,local_50 & 0xffffffff,
                                           DAT_181e9fcc8);
              lVar3 = FUN_180210740(0);
              if (lVar3 == null) {
                          // WARNING: Subroutine does not return
                FUN_1801e0300();
              }
              if (*(int64 *)(lVar3 + 144) == 0) {
                          // WARNING: Subroutine does not return
                FUN_1801e0300();
              }
              lVar3 = FUN_1800024b0(*(int64 *)(lVar3 + 144),uVar1 & 0xffffffff,DAT_181e6e1f0);
              if (lVar3 == null) break;
              fVar5 = fVar5 + fVar4 / *(float *)(lVar3 + 32);
            }
                          // WARNING: Subroutine does not return
            FUN_1801e0300();
          }
        }
    }

    // Token : 0x600125B
    // RVA   : 0x89EB30   Offset: 0x89D930   Length: 0x121
    public float GetMergeSpeAdd(int start, int end)
    {
        long lVar1;
        bool cVar2;
        float fVar3;
        ulong uVar4;
        uVar4 = 0;
        do {
          if (end < start) {
            return uVar4;
          }
          lVar1 = this.heroSpeAddData;
          if ((float)uVar4 == 0.0) {
            if (lVar1 == null) {
        LAB_18089ec4c:
                          // WARNING: Subroutine does not return
              FUN_1801e0300();
            }
            cVar2 = FUN_1806da450(lVar1,start,DAT_181e9f5e8);
            if (!cVar2) {
              return uVar4;
            }
            if (this.heroSpeAddData == null) goto LAB_18089ec4c;
            fVar3 = (float)FUN_18171b3b0(this.heroSpeAddData,start,DAT_181e9fcc8);
            if (fVar3 == 0.0) {
              return uVar4;
            }
            if (this.heroSpeAddData == null) goto LAB_18089ec4c;
            uVar4 = FUN_18171b3b0(this.heroSpeAddData,start,DAT_181e9fcc8);
          }
          else {
            if (lVar1 == null) goto LAB_18089ec4c;
            cVar2 = FUN_1806da450(lVar1,start,DAT_181e9f5e8);
            if (!cVar2) {
              return 0;
            }
            if (this.heroSpeAddData == null) goto LAB_18089ec4c;
            fVar3 = (float)FUN_18171b3b0(this.heroSpeAddData,start,DAT_181e9fcc8);
            if ((float)uVar4 != fVar3) {
              return 0;
            }
          }
          start = start + 1;
        } while( true );
    }

    // Token : 0x600125C
    // RVA   : 0x89EA90   Offset: 0x89D890   Length: 0x36
    public string GetDescribe(bool useColor, bool newLine, int digits, bool merge)
    {
        var pStatics = *(int64*)(DAT_181e538e8 + 184);
        int64 HeroSpeAddData.GetDescribe
                         (int64 this,int useColor,int newLine,char digits,char merge,
                         uint32 param_6,char param_7)
        {
        int iVar1;
        uint64 uVar2;
        char cVar3;
        uint64 uVar4;
        uint64 uVar5;
        int64 lVar6;
        int64 *plVar7;
        int64 lVar8;
        int64 lVar9;
        float fVar10;
        float fVar11;
        float fVar12;
        float fVar13;
        uint64 local_res8;
        int local_res10;
        int local_res18;
        char local_res20;
        int64 local_e8;
        uint32 local_d0;
        uint32 uStack_cc;
        uint32 uStack_c8;
        uint32 uStack_c4;
        uint64 local_c0;
        uint32 local_b8;
        uint32 uStack_b4;
        uint32 uStack_b0;
        uint32 uStack_ac;
        uint64 local_a8;
        local_res10 = useColor;
        local_res18 = newLine;
        local_res20 = digits;
        local_e8 = "";
        local_res8 = 0;
        fVar13 = 0.0;
        fVar12 = 0.0;
        fVar11 = 0.0;
        if (param_7) {
          fVar13 = (float)HeroSpeAddData.GetMergeSpeAdd(this,0,5);
          if (fVar13 != 0.0) {
            cVar3 = FUN_1816387f0(local_e8,"",0);
            uVar5 = "{0}全属性{1}{2}";
            lVar6 = "";
            if ((!cVar3) && (lVar6 = " ", merge)) {
              lVar6 = "\n";
            }
            lVar9 = "";
            if (digits) {
              if (fVar13 <= 0.0) {
                lVar9 = *(int64 *)(pStatics + 0x2d8);
              }
              else {
                lVar9 = *(int64 *)(pStatics + 0x270);
              }
            }
            local_res8 = Math.Round(SUB84((double)fVar13,0),param_6,0);
            uVar4 = Double.ToString(&local_res8,"+0.##;-0.##;0",0);
            lVar8 = "";
            if (digits) {
              lVar8 = "</color>";
            }
            uVar5 = String.Format(uVar5,lVar9,uVar4,lVar8,0);
            local_e8 = String.Concat(local_e8,lVar6,uVar5,0);
          }
          fVar12 = (float)HeroSpeAddData.GetMergeSpeAdd(this,6,14);
          if (fVar12 != 0.0) {
            cVar3 = FUN_1816387f0(local_e8,"",0);
            uVar5 = "{0}全武学{1}{2}";
            lVar6 = "";
            if ((!cVar3) && (lVar6 = " ", merge)) {
              lVar6 = "\n";
            }
            lVar9 = "";
            if (digits) {
              if (fVar12 <= 0.0) {
                lVar9 = *(int64 *)(pStatics + 0x2d8);
              }
              else {
                lVar9 = *(int64 *)(pStatics + 0x270);
              }
            }
            local_res8 = Math.Round(SUB84((double)fVar12,0),param_6,0);
            uVar4 = Double.ToString(&local_res8,"+0.##;-0.##;0",0);
            lVar8 = "";
            if (digits) {
              lVar8 = "</color>";
            }
            uVar5 = String.Format(uVar5,lVar9,uVar4,lVar8,0);
            local_e8 = String.Concat(local_e8,lVar6,uVar5,0);
          }
          fVar11 = (float)HeroSpeAddData.GetMergeSpeAdd(this,24,32);
          newLine = local_res18;
          useColor = local_res10;
          if (fVar11 != 0.0) {
            cVar3 = FUN_1816387f0(local_e8,"",0);
            uVar5 = "{0}全技艺{1}{2}";
            lVar6 = "";
            if ((!cVar3) && (lVar6 = " ", merge)) {
              lVar6 = "\n";
            }
            lVar9 = "";
            if (digits) {
              if (fVar11 <= 0.0) {
                lVar9 = *(int64 *)(pStatics + 0x2d8);
              }
              else {
                lVar9 = *(int64 *)(pStatics + 0x270);
              }
            }
            local_res8 = Math.Round(SUB84((double)fVar11,0),param_6,0);
            uVar4 = Double.ToString(&local_res8,"+0.##;-0.##;0",0);
            lVar8 = "";
            if (digits) {
              lVar8 = "</color>";
            }
            uVar5 = String.Format(uVar5,lVar9,uVar4,lVar8,0);
            local_e8 = String.Concat(local_e8,lVar6,uVar5,0);
            newLine = local_res18;
            useColor = local_res10;
          }
        }
        if ((this.heroSpeAddData == null) ||
           (lVar6 = Dictionary_2.get_Keys(this.heroSpeAddData,DAT_181e9fd50)) == null) {
                          // WARNING: Subroutine does not return
          FUN_1801e0300();
        }
        FUN_180b274e0(&local_b8,lVar6,DAT_181ea5920);
        local_d0 = local_b8;
        uStack_cc = uStack_b4;
        uStack_c8 = uStack_b0;
        uStack_c4 = uStack_ac;
        local_c0 = local_a8;
        while( true ) {
          do {
            do {
              cVar3 = FUN_180dd6f80(&local_d0,DAT_181e7d130);
              uVar2 = local_c0;
              if (!cVar3) {
                ZhSegment.Initialize(&local_d0,DAT_181e7d0b0);
                return local_e8;
              }
              iVar1 = (int)local_c0;
            } while (((int)local_c0 < useColor) || (newLine < (int)local_c0));
            if (this.heroSpeAddData == null) {
                          // WARNING: Subroutine does not return
              FUN_1801e0300();
            }
            fVar10 = (float)FUN_18171b3b0(this.heroSpeAddData,local_c0 & 0xffffffff,
                                          DAT_181e9fcc8);
          } while ((((fVar10 == 0.0) || (((fVar13 != 0.0 && (-1 < iVar1)) && (iVar1 < 6)))) ||
                   (((fVar12 != 0.0 && (5 < iVar1)) && (iVar1 < 15)))) ||
                  (((fVar11 != 0.0 && (23 < iVar1)) && (iVar1 < 33))));
          cVar3 = FUN_1816387f0(local_e8,"",0);
          lVar6 = "";
          if ((!cVar3) && (lVar6 = " ", merge)) {
            lVar6 = "\n";
          }
          plVar7 = (int64 *)FUN_1801dfd90(DAT_181e84278,4);
          uVar5 = "{0}{1}{2}{3}";
          lVar9 = "";
          if (local_res20) {
            if (this.heroSpeAddData == null) {
                          // WARNING: Subroutine does not return
              FUN_1801e0300();
            }
            fVar10 = (float)FUN_18171b3b0(this.heroSpeAddData,uVar2 & 0xffffffff,DAT_181e9fcc8);
            if (fVar10 <= 0.0) {
              lVar9 = *(int64 *)(pStatics + 0x2d8);
            }
            else {
              lVar9 = *(int64 *)(pStatics + 0x270);
            }
          }
          if (plVar7 == (int64 *)0) {
                          // WARNING: Subroutine does not return
            FUN_1801e0300();
          }
          if ((lVar9 != null) &&
             (lVar8 = il2cpp_internal(lVar9,*(uint64 *)(*plVar7 + 64))) == null) {
            uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1801e02d0(uVar5,0);
          }
          FUN_1800025b0(plVar7,0,lVar9);
          lVar9 = FUN_180210740(0);
          if (lVar9 == null) {
                          // WARNING: Subroutine does not return
            FUN_1801e0300();
          }
          if (*(int64 *)(lVar9 + 144) == 0) {
                          // WARNING: Subroutine does not return
            FUN_1801e0300();
          }
          lVar9 = FUN_1800024b0(*(int64 *)(lVar9 + 144),uVar2 & 0xffffffff,DAT_181e6e1f0);
          if (lVar9 == null) {
                          // WARNING: Subroutine does not return
            FUN_1801e0300();
          }
          lVar9 = *(int64 *)(lVar9 + 16);
          if ((lVar9 != null) &&
             (lVar8 = il2cpp_internal(lVar9,*(uint64 *)(*plVar7 + 64))) == null) {
            uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1801e02d0(uVar5,0);
          }
          if (*(uint32 *)(plVar7 + 3) < 2) {
            uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1801e02d0(uVar5,0);
          }
          plVar7[5] = lVar9;
          il2cpp_internal(plVar7 + 5,lVar9);
          lVar9 = FUN_180210740(0);
          if (lVar9 == null) break;
          if (*(int64 *)(lVar9 + 144) == 0) {
                          // WARNING: Subroutine does not return
            FUN_1801e0300();
          }
          lVar9 = FUN_1800024b0(*(int64 *)(lVar9 + 144),uVar2 & 0xffffffff,DAT_181e6e1f0);
          if (lVar9 == null) {
                          // WARNING: Subroutine does not return
            FUN_1801e0300();
          }
          lVar8 = this.heroSpeAddData;
          if (*(char *)(lVar9 + 56) == false) {
            if (lVar8 == null) {
                          // WARNING: Subroutine does not return
              FUN_1801e0300();
            }
            fVar10 = (float)FUN_18171b3b0(lVar8,uVar2 & 0xffffffff,DAT_181e9fcc8);
            local_res8 = Math.Round(SUB84((double)fVar10,0),param_6,0);
            lVar9 = Double.ToString(&local_res8,"+0.##;-0.##;0",0);
          }
          else {
            if (lVar8 == null) {
                          // WARNING: Subroutine does not return
              FUN_1801e0300();
            }
            fVar10 = (float)FUN_18171b3b0(lVar8,uVar2 & 0xffffffff,DAT_181e9fcc8);
            local_res8 = Math.Round(SUB84((double)(fVar10 * 100.0),0),param_6,0);
            uVar4 = Double.ToString(&local_res8,"+0.##;-0.##;0",0);
            lVar9 = String.Concat(uVar4,"%",0);
          }
          if ((lVar9 != null) &&
             (lVar8 = il2cpp_internal(lVar9,*(uint64 *)(*plVar7 + 64))) == null) {
            uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1801e02d0(uVar5,0);
          }
          FUN_1800025b0(plVar7,2,lVar9);
          lVar9 = "";
          if (local_res20) {
            lVar9 = "</color>";
          }
          if ((lVar9 != null) &&
             (lVar8 = il2cpp_internal(lVar9,*(uint64 *)(*plVar7 + 64))) == null) {
            uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1801e02d0(uVar5,0);
          }
          FUN_1800025b0(plVar7,3,lVar9);
          uVar5 = String.Format(uVar5,plVar7,0);
          local_e8 = String.Concat(local_e8,lVar6,uVar5,0);
          newLine = local_res18;
          useColor = local_res10;
        }
    }

    // Token : 0x600125D
    // RVA   : 0x89DF40   Offset: 0x89CD40   Length: 0xB4B
    public string GetDescribe(int startID, int endID, bool useColor, bool newLine, int digits, bool merge)
    {
        var pStatics = *(int64*)(DAT_181e538e8 + 184);
        int64 HeroSpeAddData.GetDescribe
                         (int64 this,int startID,int endID,char useColor,char newLine,
                         uint32 digits,char merge)
        {
        int iVar1;
        uint64 uVar2;
        char cVar3;
        uint64 uVar4;
        uint64 uVar5;
        int64 lVar6;
        int64 *plVar7;
        int64 lVar8;
        int64 lVar9;
        float fVar10;
        float fVar11;
        float fVar12;
        float fVar13;
        uint64 local_res8;
        int local_res10;
        int local_res18;
        char local_res20;
        int64 local_e8;
        uint32 local_d0;
        uint32 uStack_cc;
        uint32 uStack_c8;
        uint32 uStack_c4;
        uint64 local_c0;
        uint32 local_b8;
        uint32 uStack_b4;
        uint32 uStack_b0;
        uint32 uStack_ac;
        uint64 local_a8;
        local_res10 = startID;
        local_res18 = endID;
        local_res20 = useColor;
        local_e8 = "";
        local_res8 = 0;
        fVar13 = 0.0;
        fVar12 = 0.0;
        fVar11 = 0.0;
        if (merge) {
          fVar13 = (float)HeroSpeAddData.GetMergeSpeAdd(this,0,5);
          if (fVar13 != 0.0) {
            cVar3 = FUN_1816387f0(local_e8,"",0);
            uVar5 = "{0}全属性{1}{2}";
            lVar6 = "";
            if ((!cVar3) && (lVar6 = " ", newLine)) {
              lVar6 = "\n";
            }
            lVar9 = "";
            if (useColor) {
              if (fVar13 <= 0.0) {
                lVar9 = *(int64 *)(pStatics + 0x2d8);
              }
              else {
                lVar9 = *(int64 *)(pStatics + 0x270);
              }
            }
            local_res8 = Math.Round(SUB84((double)fVar13,0),digits,0);
            uVar4 = Double.ToString(&local_res8,"+0.##;-0.##;0",0);
            lVar8 = "";
            if (useColor) {
              lVar8 = "</color>";
            }
            uVar5 = String.Format(uVar5,lVar9,uVar4,lVar8,0);
            local_e8 = String.Concat(local_e8,lVar6,uVar5,0);
          }
          fVar12 = (float)HeroSpeAddData.GetMergeSpeAdd(this,6,14);
          if (fVar12 != 0.0) {
            cVar3 = FUN_1816387f0(local_e8,"",0);
            uVar5 = "{0}全武学{1}{2}";
            lVar6 = "";
            if ((!cVar3) && (lVar6 = " ", newLine)) {
              lVar6 = "\n";
            }
            lVar9 = "";
            if (useColor) {
              if (fVar12 <= 0.0) {
                lVar9 = *(int64 *)(pStatics + 0x2d8);
              }
              else {
                lVar9 = *(int64 *)(pStatics + 0x270);
              }
            }
            local_res8 = Math.Round(SUB84((double)fVar12,0),digits,0);
            uVar4 = Double.ToString(&local_res8,"+0.##;-0.##;0",0);
            lVar8 = "";
            if (useColor) {
              lVar8 = "</color>";
            }
            uVar5 = String.Format(uVar5,lVar9,uVar4,lVar8,0);
            local_e8 = String.Concat(local_e8,lVar6,uVar5,0);
          }
          fVar11 = (float)HeroSpeAddData.GetMergeSpeAdd(this,24,32);
          endID = local_res18;
          startID = local_res10;
          if (fVar11 != 0.0) {
            cVar3 = FUN_1816387f0(local_e8,"",0);
            uVar5 = "{0}全技艺{1}{2}";
            lVar6 = "";
            if ((!cVar3) && (lVar6 = " ", newLine)) {
              lVar6 = "\n";
            }
            lVar9 = "";
            if (useColor) {
              if (fVar11 <= 0.0) {
                lVar9 = *(int64 *)(pStatics + 0x2d8);
              }
              else {
                lVar9 = *(int64 *)(pStatics + 0x270);
              }
            }
            local_res8 = Math.Round(SUB84((double)fVar11,0),digits,0);
            uVar4 = Double.ToString(&local_res8,"+0.##;-0.##;0",0);
            lVar8 = "";
            if (useColor) {
              lVar8 = "</color>";
            }
            uVar5 = String.Format(uVar5,lVar9,uVar4,lVar8,0);
            local_e8 = String.Concat(local_e8,lVar6,uVar5,0);
            endID = local_res18;
            startID = local_res10;
          }
        }
        if ((this.heroSpeAddData == null) ||
           (lVar6 = Dictionary_2.get_Keys(this.heroSpeAddData,DAT_181e9fd50)) == null) {
                          // WARNING: Subroutine does not return
          FUN_1801e0300();
        }
        FUN_180b274e0(&local_b8,lVar6,DAT_181ea5920);
        local_d0 = local_b8;
        uStack_cc = uStack_b4;
        uStack_c8 = uStack_b0;
        uStack_c4 = uStack_ac;
        local_c0 = local_a8;
        while( true ) {
          do {
            do {
              cVar3 = FUN_180dd6f80(&local_d0,DAT_181e7d130);
              uVar2 = local_c0;
              if (!cVar3) {
                ZhSegment.Initialize(&local_d0,DAT_181e7d0b0);
                return local_e8;
              }
              iVar1 = (int)local_c0;
            } while (((int)local_c0 < startID) || (endID < (int)local_c0));
            if (this.heroSpeAddData == null) {
                          // WARNING: Subroutine does not return
              FUN_1801e0300();
            }
            fVar10 = (float)FUN_18171b3b0(this.heroSpeAddData,local_c0 & 0xffffffff,
                                          DAT_181e9fcc8);
          } while ((((fVar10 == 0.0) || (((fVar13 != 0.0 && (-1 < iVar1)) && (iVar1 < 6)))) ||
                   (((fVar12 != 0.0 && (5 < iVar1)) && (iVar1 < 15)))) ||
                  (((fVar11 != 0.0 && (23 < iVar1)) && (iVar1 < 33))));
          cVar3 = FUN_1816387f0(local_e8,"",0);
          lVar6 = "";
          if ((!cVar3) && (lVar6 = " ", newLine)) {
            lVar6 = "\n";
          }
          plVar7 = (int64 *)FUN_1801dfd90(DAT_181e84278,4);
          uVar5 = "{0}{1}{2}{3}";
          lVar9 = "";
          if (local_res20) {
            if (this.heroSpeAddData == null) {
                          // WARNING: Subroutine does not return
              FUN_1801e0300();
            }
            fVar10 = (float)FUN_18171b3b0(this.heroSpeAddData,uVar2 & 0xffffffff,DAT_181e9fcc8);
            if (fVar10 <= 0.0) {
              lVar9 = *(int64 *)(pStatics + 0x2d8);
            }
            else {
              lVar9 = *(int64 *)(pStatics + 0x270);
            }
          }
          if (plVar7 == (int64 *)0) {
                          // WARNING: Subroutine does not return
            FUN_1801e0300();
          }
          if ((lVar9 != null) &&
             (lVar8 = il2cpp_internal(lVar9,*(uint64 *)(*plVar7 + 64))) == null) {
            uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1801e02d0(uVar5,0);
          }
          FUN_1800025b0(plVar7,0,lVar9);
          lVar9 = FUN_180210740(0);
          if (lVar9 == null) {
                          // WARNING: Subroutine does not return
            FUN_1801e0300();
          }
          if (*(int64 *)(lVar9 + 144) == 0) {
                          // WARNING: Subroutine does not return
            FUN_1801e0300();
          }
          lVar9 = FUN_1800024b0(*(int64 *)(lVar9 + 144),uVar2 & 0xffffffff,DAT_181e6e1f0);
          if (lVar9 == null) {
                          // WARNING: Subroutine does not return
            FUN_1801e0300();
          }
          lVar9 = *(int64 *)(lVar9 + 16);
          if ((lVar9 != null) &&
             (lVar8 = il2cpp_internal(lVar9,*(uint64 *)(*plVar7 + 64))) == null) {
            uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1801e02d0(uVar5,0);
          }
          if (*(uint32 *)(plVar7 + 3) < 2) {
            uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1801e02d0(uVar5,0);
          }
          plVar7[5] = lVar9;
          il2cpp_internal(plVar7 + 5,lVar9);
          lVar9 = FUN_180210740(0);
          if (lVar9 == null) break;
          if (*(int64 *)(lVar9 + 144) == 0) {
                          // WARNING: Subroutine does not return
            FUN_1801e0300();
          }
          lVar9 = FUN_1800024b0(*(int64 *)(lVar9 + 144),uVar2 & 0xffffffff,DAT_181e6e1f0);
          if (lVar9 == null) {
                          // WARNING: Subroutine does not return
            FUN_1801e0300();
          }
          lVar8 = this.heroSpeAddData;
          if (*(char *)(lVar9 + 56) == false) {
            if (lVar8 == null) {
                          // WARNING: Subroutine does not return
              FUN_1801e0300();
            }
            fVar10 = (float)FUN_18171b3b0(lVar8,uVar2 & 0xffffffff,DAT_181e9fcc8);
            local_res8 = Math.Round(SUB84((double)fVar10,0),digits,0);
            lVar9 = Double.ToString(&local_res8,"+0.##;-0.##;0",0);
          }
          else {
            if (lVar8 == null) {
                          // WARNING: Subroutine does not return
              FUN_1801e0300();
            }
            fVar10 = (float)FUN_18171b3b0(lVar8,uVar2 & 0xffffffff,DAT_181e9fcc8);
            local_res8 = Math.Round(SUB84((double)(fVar10 * 100.0),0),digits,0);
            uVar4 = Double.ToString(&local_res8,"+0.##;-0.##;0",0);
            lVar9 = String.Concat(uVar4,"%",0);
          }
          if ((lVar9 != null) &&
             (lVar8 = il2cpp_internal(lVar9,*(uint64 *)(*plVar7 + 64))) == null) {
            uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1801e02d0(uVar5,0);
          }
          FUN_1800025b0(plVar7,2,lVar9);
          lVar9 = "";
          if (local_res20) {
            lVar9 = "</color>";
          }
          if ((lVar9 != null) &&
             (lVar8 = il2cpp_internal(lVar9,*(uint64 *)(*plVar7 + 64))) == null) {
            uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1801e02d0(uVar5,0);
          }
          FUN_1800025b0(plVar7,3,lVar9);
          uVar5 = String.Format(uVar5,plVar7,0);
          local_e8 = String.Concat(local_e8,lVar6,uVar5,0);
          endID = local_res18;
          startID = local_res10;
        }
    }

    // Token : 0x600125E
    // RVA   : 0x89EF00   Offset: 0x89DD00   Length: 0x181
    public void LimitMaxNum(int maxNum)
    {
        int iVar1;
        uint uVar2;
        long lVar3;
        ulong uVar4;
        int iVar5;
        int iVar6;
        float fVar7;
        lVar3 = this.heroSpeAddData;
        iVar6 = 0;
        iVar5 = 0;
        while ((lVar3 != null && (lVar3 = Dictionary_2.get_Keys(lVar3,DAT_181e9fd50)) != null)) {
          iVar1 = FUN_180b34300(lVar3,DAT_181ea5bc8);
          if (iVar1 <= iVar5) {
            return;
          }
          lVar3 = this.heroSpeAddData;
          if (lVar3 == null) break;
          uVar4 = Dictionary_2.get_Keys(lVar3,DAT_181e9fd50);
          uVar2 = FUN_180779bf0(uVar4,iVar5,DAT_181e96680);
          fVar7 = (float)FUN_18171b3b0(lVar3,uVar2,DAT_181e9fcc8);
          if ((fVar7 != 0.0) && (iVar6 = iVar6 + 1, maxNum + 1 <= iVar6)) {
            lVar3 = this.heroSpeAddData;
            if (lVar3 == null) break;
            uVar4 = Dictionary_2.get_Keys(lVar3,DAT_181e9fd50);
            uVar2 = FUN_180779bf0(uVar4,iVar5,DAT_181e96680);
            FUN_181687e20(lVar3,uVar2,DAT_181e9f998);
            iVar5 = iVar5 + -1;
          }
          lVar3 = this.heroSpeAddData;
          iVar5 = iVar5 + 1;
        }
    }

    // Token : 0x600125F
    // RVA   : 0x89DE80   Offset: 0x89CC80   Length: 0xB9
    public virtual object Clone()
    {
        long lVar1;
        long lVar2;
        ulong uVar3;
        lVar2 = new HeroSpeAddData(0);
        lVar1 = this.heroSpeAddData;
        if (lVar1 == null) {
          uVar3 = 0;
        }
        else {
          uVar3 = new Dictionary_2(lVar1,DAT_181e9f340);
        }
        if (lVar2 != null) {
          *(uint64 *)(lVar2 + 16) = uVar3;
          return lVar2;
        }
    }

}
