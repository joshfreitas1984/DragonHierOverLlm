// ============================================================
// Type  : ForceSpeAddData
// Token : 0x20001ED
// ============================================================

public class ForceSpeAddData
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4000DB8
    public Dictionary<int, float> forceSpeAddData;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000F43
    // RVA   : 0x1854E90   Offset: 0x1853C90   Length: 0x76
    public void /*ctor*/()
    {
        ulong uVar1;
        ZhSegment.Initialize(this,0);
        uVar1 = il2cpp_internal(DAT_181e613c8);
        FUN_1806e5bc0(uVar1,DAT_181e9f2b8);
        this.forceSpeAddData = uVar1;
    }

    // Token : 0x6000F44
    // RVA   : 0x1854CD0   Offset: 0x1853AD0   Length: 0x94
    public void Reset()
    {
        ulong uVar1;
        if (this.forceSpeAddData != null) {
          Dictionary_2.Clear(this.forceSpeAddData,DAT_181e9f560);
          return;
        }
        uVar1 = il2cpp_internal(DAT_181e613c8);
        FUN_1806e5bc0(uVar1,DAT_181e9f2b8);
        this.forceSpeAddData = uVar1;
    }

    // Token : 0x6000F45
    // RVA   : 0x1854E80   Offset: 0x1853C80   Length: 0x8
    public ForceSpeAddData Set(ForceSpeAddDataType speAddDataType, float value)
    {
        long lVar1;
        bool cVar2;
        if (this.forceSpeAddData != null) {
          cVar2 = FUN_1806da450(this.forceSpeAddData,speAddDataType,DAT_181e9f5e8);
          if (!cVar2) {
            if (value == null.0) {
              return this;
            }
            if (this.forceSpeAddData != null) {
              FUN_1816f1570(this.forceSpeAddData,speAddDataType,value,DAT_181e9f4d8);
              return this;
            }
          }
          else {
            lVar1 = this.forceSpeAddData;
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

    // Token : 0x6000F46
    // RVA   : 0x1854D70   Offset: 0x1853B70   Length: 0x10C
    public ForceSpeAddData Set(int speAddDataType, float value)
    {
        long lVar1;
        bool cVar2;
        if (this.forceSpeAddData != null) {
          cVar2 = FUN_1806da450(this.forceSpeAddData,speAddDataType,DAT_181e9f5e8);
          if (!cVar2) {
            if (value == null.0) {
              return this;
            }
            if (this.forceSpeAddData != null) {
              FUN_1816f1570(this.forceSpeAddData,speAddDataType,value,DAT_181e9f4d8);
              return this;
            }
          }
          else {
            lVar1 = this.forceSpeAddData;
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

    // Token : 0x6000F47
    // RVA   : 0x1854C40   Offset: 0x1853A40   Length: 0x8
    public float Get(ForceSpeAddDataType speAddDataType)
    {
        bool cVar1;
        uint[] local_res10 = new uint[6];
        local_res10[0] = 0;
        if (this.forceSpeAddData != null) {
          cVar1 = FUN_181691540(this.forceSpeAddData,speAddDataType,local_res10,DAT_181e9fb30);
          if (!cVar1) {
            return 0;
          }
          return local_res10[0];
        }
    }

    // Token : 0x6000F48
    // RVA   : 0x1854C50   Offset: 0x1853A50   Length: 0x77
    public float Get(int speAddDataType)
    {
        bool cVar1;
        uint[] local_res10 = new uint[6];
        local_res10[0] = 0;
        if (this.forceSpeAddData != null) {
          cVar1 = FUN_181691540(this.forceSpeAddData,speAddDataType,local_res10,DAT_181e9fb30);
          if (!cVar1) {
            return 0;
          }
          return local_res10[0];
        }
    }

    // Token : 0x6000F49
    // RVA   : 0x1854500   Offset: 0x1853300   Length: 0x8
    public void Change(ForceSpeAddDataType speAddDataType, float delta)
    {
        long lVar1;
        bool cVar2;
        float[] local_res10 = new float[6];
        local_res10[0] = 0.0;
        if (this.forceSpeAddData == null) goto LAB_1818544f0;
        cVar2 = FUN_181691540(this.forceSpeAddData,speAddDataType,local_res10,DAT_181e9fb30);
        if (!cVar2) {
          if (delta != null.0) {
            if (this.forceSpeAddData == null) goto LAB_1818544f0;
            FUN_1816f1570(this.forceSpeAddData,speAddDataType,delta,DAT_181e9f4d8);
          }
        }
        else {
          lVar1 = this.forceSpeAddData;
          if (local_res10[0] + delta == null.0) {
            if (lVar1 == null) {
        LAB_1818544f0:
                          // WARNING: Subroutine does not return
              FUN_1801e0300();
            }
            FUN_181687e20(lVar1,speAddDataType,DAT_181e9f998);
          }
          else {
            if (lVar1 == null) goto LAB_1818544f0;
            FUN_181707560(lVar1,speAddDataType,local_res10[0] + delta,DAT_181e9fdd8);
          }
        }
    }

    // Token : 0x6000F4A
    // RVA   : 0x18543F0   Offset: 0x18531F0   Length: 0x105
    public void Change(int speAddDataType, float delta)
    {
        long lVar1;
        bool cVar2;
        float[] local_res10 = new float[6];
        local_res10[0] = 0.0;
        if (this.forceSpeAddData == null) goto LAB_1818544f0;
        cVar2 = FUN_181691540(this.forceSpeAddData,speAddDataType,local_res10,DAT_181e9fb30);
        if (!cVar2) {
          if (delta != null.0) {
            if (this.forceSpeAddData == null) goto LAB_1818544f0;
            FUN_1816f1570(this.forceSpeAddData,speAddDataType,delta,DAT_181e9f4d8);
          }
        }
        else {
          lVar1 = this.forceSpeAddData;
          if (local_res10[0] + delta == null.0) {
            if (lVar1 == null) {
        LAB_1818544f0:
                          // WARNING: Subroutine does not return
              FUN_1801e0300();
            }
            FUN_181687e20(lVar1,speAddDataType,DAT_181e9f998);
          }
          else {
            if (lVar1 == null) goto LAB_1818544f0;
            FUN_181707560(lVar1,speAddDataType,local_res10[0] + delta,DAT_181e9fdd8);
          }
        }
    }

    // Token : 0x6000F4B
    // RVA   : 0x18542D0   Offset: 0x18530D0   Length: 0x8
    public void ChangeMulti(ForceSpeAddDataType speAddDataType, float multi)
    {
        long lVar1;
        bool cVar2;
        float[] local_res10 = new float[6];
        local_res10[0] = 0.0;
        if (this.forceSpeAddData == null) goto LAB_1818543e4;
        cVar2 = FUN_181691540(this.forceSpeAddData,speAddDataType,local_res10,DAT_181e9fb30);
        if (!cVar2) {
          if (multi * 0.0 != null.0) {
            if (this.forceSpeAddData == null) goto LAB_1818543e4;
            FUN_1816f1570(this.forceSpeAddData,speAddDataType,multi * 0.0,DAT_181e9f4d8);
          }
        }
        else {
          lVar1 = this.forceSpeAddData;
          if (local_res10[0] * multi == null.0) {
            if (lVar1 == null) {
        LAB_1818543e4:
                          // WARNING: Subroutine does not return
              FUN_1801e0300();
            }
            FUN_181687e20(lVar1,speAddDataType,DAT_181e9f998);
          }
          else {
            if (lVar1 == null) goto LAB_1818543e4;
            FUN_181707560(lVar1,speAddDataType,local_res10[0] * multi,DAT_181e9fdd8);
          }
        }
    }

    // Token : 0x6000F4C
    // RVA   : 0x18542E0   Offset: 0x18530E0   Length: 0x109
    public void ChangeMulti(int speAddDataType, float multi)
    {
        long lVar1;
        bool cVar2;
        float[] local_res10 = new float[6];
        local_res10[0] = 0.0;
        if (this.forceSpeAddData == null) goto LAB_1818543e4;
        cVar2 = FUN_181691540(this.forceSpeAddData,speAddDataType,local_res10,DAT_181e9fb30);
        if (!cVar2) {
          if (multi * 0.0 != null.0) {
            if (this.forceSpeAddData == null) goto LAB_1818543e4;
            FUN_1816f1570(this.forceSpeAddData,speAddDataType,multi * 0.0,DAT_181e9f4d8);
          }
        }
        else {
          lVar1 = this.forceSpeAddData;
          if (local_res10[0] * multi == null.0) {
            if (lVar1 == null) {
        LAB_1818543e4:
                          // WARNING: Subroutine does not return
              FUN_1801e0300();
            }
            FUN_181687e20(lVar1,speAddDataType,DAT_181e9f998);
          }
          else {
            if (lVar1 == null) goto LAB_1818543e4;
            FUN_181707560(lVar1,speAddDataType,local_res10[0] * multi,DAT_181e9fdd8);
          }
        }
    }

    // Token : 0x6000F4D
    // RVA   : 0x1854BE0   Offset: 0x18539E0   Length: 0x5F
    public List<int> GetKeys()
    {
        ulong uVar1;
        if (this.forceSpeAddData != null) {
          uVar1 = Dictionary_2.get_Keys(this.forceSpeAddData,DAT_181e9fd50);
          FUN_18077cf20(uVar1,DAT_181e98ba0);
          return;
        }
    }

    // Token : 0x6000F4E
    // RVA   : 0x1854F10   Offset: 0x1853D10   Length: 0x1D3
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
        if ((this.forceSpeAddData == null) ||
           (lVar2 = Dictionary_2.get_Keys(this.forceSpeAddData,DAT_181e9fd50)) == null) {
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
            goto LAB_1818550a0;
          }
          if (this.forceSpeAddData == null) {
                          // WARNING: Subroutine does not return
            FUN_1801e0300();
          }
          fVar5 = (float)FUN_18171b3b0(this.forceSpeAddData,local_40 & 0xffffffff,DAT_181e9fcc8);
        } while (fVar5 == 0.0);
        aiStack_64[1] = 77;
        iVar4 = aiStack_64[3] + 1;
        aiStack_64[3] = iVar4;
        ZhSegment.Initialize(&local_50,DAT_181e7d0b0);
        LAB_1818550a0:
        if ((iVar4 == 0) || (aiStack_64[iVar4] != 77)) {
          uVar3 = 1;
        }
        else {
          uVar3 = 0;
        }
        return uVar3;
    }

    // Token : 0x6000F4F
    // RVA   : 0x18550F0   Offset: 0x1853EF0   Length: 0x20E
    public static ForceSpeAddData op_Addition(ForceSpeAddData a, ForceSpeAddData b)
    {
        ulong uVar1;
        bool cVar2;
        long lVar4;
        uint uVar5;
        uint[] local_res8 = new uint[2];
        uint local_40;
        uint32 uStack_3c;
        uint32 uStack_38;
        uint32 uStack_34;
        uint64 local_30;
        uint32 local_28;
        uint32 uStack_24;
        uint32 uStack_20;
        uint32 uStack_1c;
        uint64 local_18;
        if (a != null) {
          plVar3 = (int64 *)ForceSpeAddData.Clone(a,0);
          if (((b != null) && (*(int64 *)(b + 16) != 0)) &&
             (lVar4 = Dictionary_2.get_Keys(*(int64 *)(b + 16),DAT_181e9fd50)) != null) {
            FUN_180b274e0(&local_28,lVar4,DAT_181ea5920);
            local_40 = local_28;
            uStack_3c = uStack_24;
            uStack_38 = uStack_20;
            uStack_34 = uStack_1c;
            local_30 = local_18;
            while( true ) {
              cVar2 = FUN_180dd6f80(&local_40,DAT_181e7d130);
              uVar1 = local_30;
              if (!cVar2) {
                ZhSegment.Initialize(&local_40,DAT_181e7d0b0);
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
              ForceSpeAddData.Change(plVar3,uVar1 & 0xffffffff,uVar5,0);
            }
                          // WARNING: Subroutine does not return
            FUN_1801e0300();
          }
        }
    }

    // Token : 0x6000F50
    // RVA   : 0x18554B0   Offset: 0x18542B0   Length: 0xF
    public static ForceSpeAddData op_Multiply(ForceSpeAddData a, int b)
    {
        bool cVar1;
        long lVar3;
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
          plVar2 = (int64 *)ForceSpeAddData.Clone(a,0);
          if ((*(int64 *)(a + 16) != 0) &&
             (lVar3 = Dictionary_2.get_Keys(*(int64 *)(a + 16),DAT_181e9fd50)) != null) {
            FUN_180b274e0(&local_38,lVar3,DAT_181ea5920);
            local_50 = local_38;
            uStack_4c = uStack_34;
            uStack_48 = uStack_30;
            uStack_44 = uStack_2c;
            local_40 = local_28;
            while( true ) {
              cVar1 = FUN_180dd6f80(&local_50,DAT_181e7d130);
              if (!cVar1) {
                ZhSegment.Initialize(&local_50,DAT_181e7d0b0);
                return plVar2;
              }
              if (plVar2 == (int64 *)0) break;
              ForceSpeAddData.ChangeMulti(plVar2,local_40 & 0xffffffff,b,0);
            }
                          // WARNING: Subroutine does not return
            FUN_1801e0300();
          }
        }
    }

    // Token : 0x6000F51
    // RVA   : 0x1855300   Offset: 0x1854100   Length: 0x1AB
    public static ForceSpeAddData op_Multiply(ForceSpeAddData a, float b)
    {
        bool cVar1;
        long lVar3;
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
          plVar2 = (int64 *)ForceSpeAddData.Clone(a,0);
          if ((*(int64 *)(a + 16) != 0) &&
             (lVar3 = Dictionary_2.get_Keys(*(int64 *)(a + 16),DAT_181e9fd50)) != null) {
            FUN_180b274e0(&local_38,lVar3,DAT_181ea5920);
            local_50 = local_38;
            uStack_4c = uStack_34;
            uStack_48 = uStack_30;
            uStack_44 = uStack_2c;
            local_40 = local_28;
            while( true ) {
              cVar1 = FUN_180dd6f80(&local_50,DAT_181e7d130);
              if (!cVar1) {
                ZhSegment.Initialize(&local_50,DAT_181e7d0b0);
                return plVar2;
              }
              if (plVar2 == (int64 *)0) break;
              ForceSpeAddData.ChangeMulti(plVar2,local_40 & 0xffffffff,b,0);
            }
                          // WARNING: Subroutine does not return
            FUN_1801e0300();
          }
        }
    }

    // Token : 0x6000F52
    // RVA   : 0x18554C0   Offset: 0x18542C0   Length: 0x234
    public static ForceSpeAddData op_Subtraction(ForceSpeAddData a, ForceSpeAddData b)
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
          plVar3 = (int64 *)ForceSpeAddData.Clone(a,0);
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
              ForceSpeAddData.Change(plVar3,uVar1 & 0xffffffff,uVar5 ^ 0x80000000,0);
            }
                          // WARNING: Subroutine does not return
            FUN_1801e0300();
          }
        }
    }

    // Token : 0x6000F53
    // RVA   : 0x1854BD0   Offset: 0x18539D0   Length: 0xA
    public string GetDescribe()
    {
        var pStatics = *(int64*)(DAT_181e538e8 + 184);
        bool cVar1;
        int iVar2;
        ulong uVar3;
        long lVar4;
        long lVar7;
        int iVar8;
        float fVar9;
        float[] local_res20 = new float[2];
        int[] local_48 = new int[12];
        iVar8 = 0;
        local_48[0] = 0;
        local_res20[0] = 0.0;
        lVar7 = "";
        do {
          uVar3 = DAT_181e98698;
          uVar3 = Type.GetTypeFromHandle(uVar3,0);
          lVar4 = Enum.GetValues(uVar3,0);
          if (lVar4 == null) goto LAB_181854b39;
          iVar2 = FUN_181162560(lVar4,0);
          if (iVar2 <= iVar8) {
            return lVar7;
          }
          fVar9 = (float)ForceSpeAddData.Get(this,iVar8,0);
          if (fVar9 != 0.0) {
            if (param_2) {
              local_48[0] = iVar8;
              plVar5 = (int64 *)il2cpp_value_box(DAT_181e50f78,local_48);
              if (plVar5 == (int64 *)0) goto LAB_181854b39;
              lVar4 = (**(code **)(*plVar5 + 0x168))(plVar5,*(uint64 *)(*plVar5 + 0x170));
              piVar6 = (int *)il2cpp_object_unbox(plVar5);
              local_48[0] = *piVar6;
              if (lVar4 == null) goto LAB_181854b39;
              cVar1 = String.Contains(lVar4);
              if (cVar1) goto LAB_181854b09;
            }
            plVar5 = (int64 *)FUN_1801dfd90(DAT_181e85e38,6);
            if (plVar5 == (int64 *)0) {
        LAB_181854b39:
                          // WARNING: Subroutine does not return
              FUN_1801e0300();
            }
            if ((lVar7 != null) &&
               (lVar4 = il2cpp_internal(lVar7,*(uint64 *)(*plVar5 + 64))) == null) {
              uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1801e02d0(uVar3,0);
            }
            if ((int)plVar5[3] == 0) {
              uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1801e02d0(uVar3,0);
            }
            plVar5[4] = lVar7;
            il2cpp_internal(plVar5 + 4,lVar7);
            cVar1 = FUN_1816387f0(lVar7,"",0);
            lVar7 = "\n";
            if (cVar1) {
              lVar7 = "";
            }
            if ((lVar7 != null) &&
               (lVar4 = il2cpp_internal(lVar7,*(uint64 *)(*plVar5 + 64))) == null) {
              uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1801e02d0(uVar3,0);
            }
            FUN_1800025b0(plVar5,1,lVar7);
            if (this.forceSpeAddData == null) goto LAB_181854b39;
            fVar9 = (float)FUN_18171b3b0(this.forceSpeAddData,iVar8,DAT_181e9fcc8);
            if (fVar9 <= 0.0) {
              lVar7 = *(int64 *)(pStatics + 0x2d8);
            }
            else {
              lVar7 = *(int64 *)(pStatics + 0x270);
            }
            if ((lVar7 != null) &&
               (lVar4 = il2cpp_internal(lVar7,*(uint64 *)(*plVar5 + 64))) == null) {
              uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1801e02d0(uVar3,0);
            }
            FUN_1800025b0(plVar5,2,lVar7);
            lVar7 = FUN_180210740(0);
            if (((lVar7 == null) || (*(int64 *)(lVar7 + 152) == 0)) ||
               (lVar7 = FUN_1800024b0(*(int64 *)(lVar7 + 152),iVar8,DAT_181e6abf8)) == null)
            goto LAB_181854b39;
            lVar7 = *(int64 *)(lVar7 + 16);
            if ((lVar7 != null) &&
               (lVar4 = il2cpp_internal(lVar7,*(uint64 *)(*plVar5 + 64))) == null) {
              uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1801e02d0(uVar3,0);
            }
            if (*(uint32 *)(plVar5 + 3) < 4) {
              uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1801e02d0(uVar3,0);
            }
            plVar5[7] = lVar7;
            il2cpp_internal(plVar5 + 7,lVar7);
            lVar7 = FUN_180210740(0);
            if (((lVar7 == null) || (*(int64 *)(lVar7 + 152) == 0)) ||
               (lVar7 = FUN_1800024b0(*(int64 *)(lVar7 + 152),iVar8,DAT_181e6abf8)) == null)
            goto LAB_181854b39;
            lVar4 = this.forceSpeAddData;
            if (*(char *)(lVar7 + 32) == false) {
              if (lVar4 == null) goto LAB_181854b39;
              local_res20[0] = (float)FUN_18171b3b0(lVar4,iVar8,DAT_181e9fcc8);
              lVar7 = Single.ToString(local_res20,"+0.##;-0.##;0",0);
            }
            else {
              if (lVar4 == null) goto LAB_181854b39;
              local_res20[0] = (float)FUN_18171b3b0(lVar4,iVar8,DAT_181e9fcc8);
              local_res20[0] = local_res20[0] * 100.0;
              uVar3 = Single.ToString(local_res20,"+0.##;-0.##;0",0);
              lVar7 = String.Concat(uVar3,"%",0);
            }
            if ((lVar7 != null) &&
               (lVar7 = il2cpp_internal(lVar7,*(uint64 *)(*plVar5 + 64))) == null) {
              uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1801e02d0(uVar3,0);
            }
            FUN_1800025b0(plVar5,4);
            if (("</color>" != 0) &&
               (lVar7 = il2cpp_internal("</color>",*(uint64 *)(*plVar5 + 64))) == null) {
              uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1801e02d0(uVar3,0);
            }
            if (*(uint32 *)(plVar5 + 3) < 6) {
              uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1801e02d0(uVar3,0);
            }
            plVar5[9] = "</color>";
            il2cpp_internal();
            lVar7 = String.Concat(plVar5);
          }
        LAB_181854b09:
          iVar8 = iVar8 + 1;
        } while( true );
    }

    // Token : 0x6000F54
    // RVA   : 0x18545D0   Offset: 0x18533D0   Length: 0x5FE
    public string GetDescribe(bool noLocal)
    {
        var pStatics = *(int64*)(DAT_181e538e8 + 184);
        bool cVar1;
        int iVar2;
        ulong uVar3;
        long lVar4;
        long lVar7;
        int iVar8;
        float fVar9;
        float[] local_res20 = new float[2];
        int[] local_48 = new int[12];
        iVar8 = 0;
        local_48[0] = 0;
        local_res20[0] = 0.0;
        lVar7 = "";
        do {
          uVar3 = DAT_181e98698;
          uVar3 = Type.GetTypeFromHandle(uVar3,0);
          lVar4 = Enum.GetValues(uVar3,0);
          if (lVar4 == null) goto LAB_181854b39;
          iVar2 = FUN_181162560(lVar4,0);
          if (iVar2 <= iVar8) {
            return lVar7;
          }
          fVar9 = (float)ForceSpeAddData.Get(this,iVar8,0);
          if (fVar9 != 0.0) {
            if (noLocal) {
              local_48[0] = iVar8;
              plVar5 = (int64 *)il2cpp_value_box(DAT_181e50f78,local_48);
              if (plVar5 == (int64 *)0) goto LAB_181854b39;
              lVar4 = (**(code **)(*plVar5 + 0x168))(plVar5,*(uint64 *)(*plVar5 + 0x170));
              piVar6 = (int *)il2cpp_object_unbox(plVar5);
              local_48[0] = *piVar6;
              if (lVar4 == null) goto LAB_181854b39;
              cVar1 = String.Contains(lVar4);
              if (cVar1) goto LAB_181854b09;
            }
            plVar5 = (int64 *)FUN_1801dfd90(DAT_181e85e38,6);
            if (plVar5 == (int64 *)0) {
        LAB_181854b39:
                          // WARNING: Subroutine does not return
              FUN_1801e0300();
            }
            if ((lVar7 != null) &&
               (lVar4 = il2cpp_internal(lVar7,*(uint64 *)(*plVar5 + 64))) == null) {
              uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1801e02d0(uVar3,0);
            }
            if ((int)plVar5[3] == 0) {
              uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1801e02d0(uVar3,0);
            }
            plVar5[4] = lVar7;
            il2cpp_internal(plVar5 + 4,lVar7);
            cVar1 = FUN_1816387f0(lVar7,"",0);
            lVar7 = "\n";
            if (cVar1) {
              lVar7 = "";
            }
            if ((lVar7 != null) &&
               (lVar4 = il2cpp_internal(lVar7,*(uint64 *)(*plVar5 + 64))) == null) {
              uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1801e02d0(uVar3,0);
            }
            FUN_1800025b0(plVar5,1,lVar7);
            if (this.forceSpeAddData == null) goto LAB_181854b39;
            fVar9 = (float)FUN_18171b3b0(this.forceSpeAddData,iVar8,DAT_181e9fcc8);
            if (fVar9 <= 0.0) {
              lVar7 = *(int64 *)(pStatics + 0x2d8);
            }
            else {
              lVar7 = *(int64 *)(pStatics + 0x270);
            }
            if ((lVar7 != null) &&
               (lVar4 = il2cpp_internal(lVar7,*(uint64 *)(*plVar5 + 64))) == null) {
              uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1801e02d0(uVar3,0);
            }
            FUN_1800025b0(plVar5,2,lVar7);
            lVar7 = FUN_180210740(0);
            if (((lVar7 == null) || (*(int64 *)(lVar7 + 152) == 0)) ||
               (lVar7 = FUN_1800024b0(*(int64 *)(lVar7 + 152),iVar8,DAT_181e6abf8)) == null)
            goto LAB_181854b39;
            lVar7 = *(int64 *)(lVar7 + 16);
            if ((lVar7 != null) &&
               (lVar4 = il2cpp_internal(lVar7,*(uint64 *)(*plVar5 + 64))) == null) {
              uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1801e02d0(uVar3,0);
            }
            if (*(uint32 *)(plVar5 + 3) < 4) {
              uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1801e02d0(uVar3,0);
            }
            plVar5[7] = lVar7;
            il2cpp_internal(plVar5 + 7,lVar7);
            lVar7 = FUN_180210740(0);
            if (((lVar7 == null) || (*(int64 *)(lVar7 + 152) == 0)) ||
               (lVar7 = FUN_1800024b0(*(int64 *)(lVar7 + 152),iVar8,DAT_181e6abf8)) == null)
            goto LAB_181854b39;
            lVar4 = this.forceSpeAddData;
            if (*(char *)(lVar7 + 32) == false) {
              if (lVar4 == null) goto LAB_181854b39;
              local_res20[0] = (float)FUN_18171b3b0(lVar4,iVar8,DAT_181e9fcc8);
              lVar7 = Single.ToString(local_res20,"+0.##;-0.##;0",0);
            }
            else {
              if (lVar4 == null) goto LAB_181854b39;
              local_res20[0] = (float)FUN_18171b3b0(lVar4,iVar8,DAT_181e9fcc8);
              local_res20[0] = local_res20[0] * 100.0;
              uVar3 = Single.ToString(local_res20,"+0.##;-0.##;0",0);
              lVar7 = String.Concat(uVar3,"%",0);
            }
            if ((lVar7 != null) &&
               (lVar7 = il2cpp_internal(lVar7,*(uint64 *)(*plVar5 + 64))) == null) {
              uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1801e02d0(uVar3,0);
            }
            FUN_1800025b0(plVar5,4);
            if (("</color>" != 0) &&
               (lVar7 = il2cpp_internal("</color>",*(uint64 *)(*plVar5 + 64))) == null) {
              uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1801e02d0(uVar3,0);
            }
            if (*(uint32 *)(plVar5 + 3) < 6) {
              uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1801e02d0(uVar3,0);
            }
            plVar5[9] = "</color>";
            il2cpp_internal();
            lVar7 = String.Concat(plVar5);
          }
        LAB_181854b09:
          iVar8 = iVar8 + 1;
        } while( true );
    }

    // Token : 0x6000F55
    // RVA   : 0x1854510   Offset: 0x1853310   Length: 0xB9
    public virtual object Clone()
    {
        long lVar1;
        long lVar2;
        ulong uVar3;
        lVar2 = new ForceSpeAddData(0);
        lVar1 = this.forceSpeAddData;
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
