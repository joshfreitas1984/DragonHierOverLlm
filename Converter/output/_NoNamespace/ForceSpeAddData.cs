// ============================================================
// Type  : ForceSpeAddData
// Token : 0x20001E5
// ============================================================

public class ForceSpeAddData
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4000D16
    public Dictionary<int, float> forceSpeAddData;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000F05
    // RVA   : 0x782FA0   Offset: 0x7817A0   Length: 0x76
    public void /*ctor*/()
    {
        ulong uVar1;
        ZhSegment.Initialize(this,0);
        uVar1 = il2cpp_internal(DAT_181d5cc48);
        FUN_1808ae540(uVar1,DAT_181d98210);
        this.forceSpeAddData = uVar1;
    }

    // Token : 0x6000F06
    // RVA   : 0x782DE0   Offset: 0x7815E0   Length: 0x94
    public void Reset()
    {
        ulong uVar1;
        if (this.forceSpeAddData != null) {
          Dictionary_2.Clear(this.forceSpeAddData,DAT_181d98430);
          return;
        }
        uVar1 = il2cpp_internal(DAT_181d5cc48);
        FUN_1808ae540(uVar1,DAT_181d98210);
        this.forceSpeAddData = uVar1;
    }

    // Token : 0x6000F07
    // RVA   : 0x782F90   Offset: 0x781790   Length: 0x8
    public ForceSpeAddData Set(ForceSpeAddDataType speAddDataType, float value)
    {
        long lVar1;
        bool cVar2;
        if (this.forceSpeAddData != null) {
          cVar2 = FUN_1808ab750(this.forceSpeAddData,speAddDataType,DAT_181d984b8);
          if (!cVar2) {
            if (value == null.0) {
              return this;
            }
            if (this.forceSpeAddData != null) {
              FUN_181772130(this.forceSpeAddData,speAddDataType,value,DAT_181d983a8);
              return this;
            }
          }
          else {
            lVar1 = this.forceSpeAddData;
            if (value == null.0) {
              if (lVar1 != null) {
                FUN_1813fed40(lVar1,speAddDataType,DAT_181d987e0);
                return this;
              }
            }
            else if (lVar1 != null) {
              FUN_181789b60(lVar1,speAddDataType,value,DAT_181d98b98);
              return this;
            }
          }
        }
    }

    // Token : 0x6000F08
    // RVA   : 0x782E80   Offset: 0x781680   Length: 0x10C
    public ForceSpeAddData Set(int speAddDataType, float value)
    {
        long lVar1;
        bool cVar2;
        if (this.forceSpeAddData != null) {
          cVar2 = FUN_1808ab750(this.forceSpeAddData,speAddDataType,DAT_181d984b8);
          if (!cVar2) {
            if (value == null.0) {
              return this;
            }
            if (this.forceSpeAddData != null) {
              FUN_181772130(this.forceSpeAddData,speAddDataType,value,DAT_181d983a8);
              return this;
            }
          }
          else {
            lVar1 = this.forceSpeAddData;
            if (value == null.0) {
              if (lVar1 != null) {
                FUN_1813fed40(lVar1,speAddDataType,DAT_181d987e0);
                return this;
              }
            }
            else if (lVar1 != null) {
              FUN_181789b60(lVar1,speAddDataType,value,DAT_181d98b98);
              return this;
            }
          }
        }
    }

    // Token : 0x6000F09
    // RVA   : 0x782D40   Offset: 0x781540   Length: 0x8
    public float Get(ForceSpeAddDataType speAddDataType)
    {
        bool cVar1;
        ulong uVar2;
        if (this.forceSpeAddData != null) {
          cVar1 = FUN_1808ab750(this.forceSpeAddData,speAddDataType,DAT_181d984b8);
          if (!cVar1) {
            return 0;
          }
          if (this.forceSpeAddData != null) {
            uVar2 = FUN_1817cc640(this.forceSpeAddData,speAddDataType,DAT_181d98a88);
            return uVar2;
          }
        }
    }

    // Token : 0x6000F0A
    // RVA   : 0x782D50   Offset: 0x781550   Length: 0x86
    public float Get(int speAddDataType)
    {
        bool cVar1;
        ulong uVar2;
        if (this.forceSpeAddData != null) {
          cVar1 = FUN_1808ab750(this.forceSpeAddData,speAddDataType,DAT_181d984b8);
          if (!cVar1) {
            return 0;
          }
          if (this.forceSpeAddData != null) {
            uVar2 = FUN_1817cc640(this.forceSpeAddData,speAddDataType,DAT_181d98a88);
            return uVar2;
          }
        }
    }

    // Token : 0x6000F0B
    // RVA   : 0x782500   Offset: 0x780D00   Length: 0x42
    public void Change(ForceSpeAddDataType speAddDataType, float delta)
    {
        float fVar1;
        fVar1 = (float)ForceSpeAddData.Get(this,speAddDataType,0);
        ForceSpeAddData.Set(this,speAddDataType & 0xffffffff,fVar1 + delta,0);
    }

    // Token : 0x6000F0C
    // RVA   : 0x782500   Offset: 0x780D00   Length: 0x42
    public void Change(int speAddDataType, float delta)
    {
        float fVar1;
        fVar1 = (float)ForceSpeAddData.Get(this,speAddDataType,0);
        ForceSpeAddData.Set(this,speAddDataType & 0xffffffff,fVar1 + delta,0);
    }

    // Token : 0x6000F0D
    // RVA   : 0x7824B0   Offset: 0x780CB0   Length: 0x42
    public void ChangeMulti(ForceSpeAddDataType speAddDataType, float multi)
    {
        float fVar1;
        fVar1 = (float)ForceSpeAddData.Get(this,speAddDataType,0);
        ForceSpeAddData.Set(this,speAddDataType & 0xffffffff,fVar1 * multi,0);
    }

    // Token : 0x6000F0E
    // RVA   : 0x7824B0   Offset: 0x780CB0   Length: 0x42
    public void ChangeMulti(int speAddDataType, float multi)
    {
        float fVar1;
        fVar1 = (float)ForceSpeAddData.Get(this,speAddDataType,0);
        ForceSpeAddData.Set(this,speAddDataType & 0xffffffff,fVar1 * multi,0);
    }

    // Token : 0x6000F0F
    // RVA   : 0x782CE0   Offset: 0x7814E0   Length: 0x5F
    public List<int> GetKeys()
    {
        ulong uVar1;
        if (this.forceSpeAddData != null) {
          uVar1 = Dictionary_2.get_Keys(this.forceSpeAddData,DAT_181d98b10);
          FUN_180961530(uVar1,DAT_181d8c638);
          return;
        }
    }

    // Token : 0x6000F10
    // RVA   : 0x783020   Offset: 0x781820   Length: 0x1D3
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
           (lVar2 = Dictionary_2.get_Keys(this.forceSpeAddData,DAT_181d98b10)) == null) {
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
        FUN_180ed4d30(&local_38,lVar2,DAT_181d9c570);
        local_50 = local_38;
        uStack_4c = uStack_34;
        uStack_48 = uStack_30;
        uStack_44 = uStack_2c;
        local_40 = local_28;
        do {
          cVar1 = FUN_1811d8280(&local_50,DAT_181d74c38);
          if (!cVar1) {
            aiStack_64[1] = 75;
            iVar4 = aiStack_64[3] + 1;
            aiStack_64[3] = iVar4;
            ZhSegment.Initialize(&local_50,DAT_181d74bb8);
            goto LAB_1807831b0;
          }
          if (this.forceSpeAddData == null) {
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          fVar5 = (float)FUN_1817cc640(this.forceSpeAddData,local_40 & 0xffffffff,DAT_181d98a88);
        } while (fVar5 == 0.0);
        aiStack_64[1] = 77;
        iVar4 = aiStack_64[3] + 1;
        aiStack_64[3] = iVar4;
        ZhSegment.Initialize(&local_50,DAT_181d74bb8);
        LAB_1807831b0:
        if ((iVar4 == 0) || (aiStack_64[iVar4] != 77)) {
          uVar3 = 1;
        }
        else {
          uVar3 = 0;
        }
        return uVar3;
    }

    // Token : 0x6000F11
    // RVA   : 0x783200   Offset: 0x781A00   Length: 0x2B4
    public static ForceSpeAddData op_Addition(ForceSpeAddData a, ForceSpeAddData b)
    {
        ulong uVar1;
        bool cVar2;
        long lVar4;
        float fVar5;
        float fVar6;
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
             (lVar4 = Dictionary_2.get_Keys(*(int64 *)(b + 16),DAT_181d98b10)) != null) {
            FUN_180ed4d30(&local_38,lVar4,DAT_181d9c570);
            local_50 = local_38;
            uStack_4c = uStack_34;
            uStack_48 = uStack_30;
            uStack_44 = uStack_2c;
            local_40 = local_28;
            while( true ) {
              cVar2 = FUN_1811d8280(&local_50,DAT_181d74c38);
              uVar1 = local_40;
              if (!cVar2) {
                ZhSegment.Initialize(&local_50,DAT_181d74bb8);
                return plVar3;
              }
              if (*(int64 *)(b + 16) == 0) {
                          // WARNING: Subroutine does not return
                FUN_1800d6620();
              }
              cVar2 = FUN_1808ab750(*(int64 *)(b + 16),uVar1 & 0xffffffff,DAT_181d984b8);
              if (!cVar2) {
                fVar6 = 0.0;
              }
              else {
                if (*(int64 *)(b + 16) == 0) {
                          // WARNING: Subroutine does not return
                  FUN_1800d6620();
                }
                fVar6 = (float)FUN_1817cc640(*(int64 *)(b + 16),uVar1 & 0xffffffff,
                                             DAT_181d98a88);
              }
              if (plVar3 == (int64 *)0) break;
              if (plVar3[2] == 0) {
                          // WARNING: Subroutine does not return
                FUN_1800d6620();
              }
              cVar2 = FUN_1808ab750(plVar3[2],uVar1 & 0xffffffff,DAT_181d984b8);
              if (!cVar2) {
                fVar5 = 0.0;
              }
              else {
                if (plVar3[2] == 0) {
                          // WARNING: Subroutine does not return
                  FUN_1800d6620();
                }
                fVar5 = (float)FUN_1817cc640(plVar3[2],uVar1 & 0xffffffff,DAT_181d98a88);
              }
              ForceSpeAddData.Set(plVar3,uVar1 & 0xffffffff,fVar5 + fVar6,0);
            }
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
        }
    }

    // Token : 0x6000F12
    // RVA   : 0x7836F0   Offset: 0x781EF0   Length: 0xF
    public static ForceSpeAddData op_Multiply(ForceSpeAddData a, int b)
    {
        ulong uVar1;
        bool cVar2;
        long lVar4;
        float fVar5;
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
          if ((*(int64 *)(a + 16) != 0) &&
             (lVar4 = Dictionary_2.get_Keys(*(int64 *)(a + 16),DAT_181d98b10)) != null) {
            FUN_180ed4d30(&local_38,lVar4,DAT_181d9c570);
            local_50 = local_38;
            uStack_4c = uStack_34;
            uStack_48 = uStack_30;
            uStack_44 = uStack_2c;
            local_40 = local_28;
            while( true ) {
              cVar2 = FUN_1811d8280(&local_50,DAT_181d74c38);
              uVar1 = local_40;
              if (!cVar2) {
                ZhSegment.Initialize(&local_50,DAT_181d74bb8);
                return plVar3;
              }
              if (plVar3 == (int64 *)0) break;
              if (plVar3[2] == 0) {
                          // WARNING: Subroutine does not return
                FUN_1800d6620();
              }
              cVar2 = FUN_1808ab750(plVar3[2],uVar1 & 0xffffffff,DAT_181d984b8);
              if (!cVar2) {
                fVar5 = 0.0;
              }
              else {
                if (plVar3[2] == 0) {
                          // WARNING: Subroutine does not return
                  FUN_1800d6620();
                }
                fVar5 = (float)FUN_1817cc640(plVar3[2],uVar1 & 0xffffffff,DAT_181d98a88);
              }
              ForceSpeAddData.Set(plVar3,uVar1 & 0xffffffff,fVar5 * b,0);
            }
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
        }
    }

    // Token : 0x6000F13
    // RVA   : 0x7834C0   Offset: 0x781CC0   Length: 0x22A
    public static ForceSpeAddData op_Multiply(ForceSpeAddData a, float b)
    {
        ulong uVar1;
        bool cVar2;
        long lVar4;
        float fVar5;
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
          if ((*(int64 *)(a + 16) != 0) &&
             (lVar4 = Dictionary_2.get_Keys(*(int64 *)(a + 16),DAT_181d98b10)) != null) {
            FUN_180ed4d30(&local_38,lVar4,DAT_181d9c570);
            local_50 = local_38;
            uStack_4c = uStack_34;
            uStack_48 = uStack_30;
            uStack_44 = uStack_2c;
            local_40 = local_28;
            while( true ) {
              cVar2 = FUN_1811d8280(&local_50,DAT_181d74c38);
              uVar1 = local_40;
              if (!cVar2) {
                ZhSegment.Initialize(&local_50,DAT_181d74bb8);
                return plVar3;
              }
              if (plVar3 == (int64 *)0) break;
              if (plVar3[2] == 0) {
                          // WARNING: Subroutine does not return
                FUN_1800d6620();
              }
              cVar2 = FUN_1808ab750(plVar3[2],uVar1 & 0xffffffff,DAT_181d984b8);
              if (!cVar2) {
                fVar5 = 0.0;
              }
              else {
                if (plVar3[2] == 0) {
                          // WARNING: Subroutine does not return
                  FUN_1800d6620();
                }
                fVar5 = (float)FUN_1817cc640(plVar3[2],uVar1 & 0xffffffff,DAT_181d98a88);
              }
              ForceSpeAddData.Set(plVar3,uVar1 & 0xffffffff,fVar5 * b,0);
            }
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
        }
    }

    // Token : 0x6000F14
    // RVA   : 0x783700   Offset: 0x781F00   Length: 0x2CF
    public static ForceSpeAddData op_Subtraction(ForceSpeAddData a, ForceSpeAddData b)
    {
        ulong uVar1;
        bool cVar2;
        long lVar4;
        float fVar5;
        float fVar6;
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
        if (a != null) {
          plVar3 = (int64 *)ForceSpeAddData.Clone(a,0);
          if (((b != null) && (*(int64 *)(b + 16) != 0)) &&
             (lVar4 = Dictionary_2.get_Keys(*(int64 *)(b + 16),DAT_181d98b10)) != null) {
            FUN_180ed4d30(&local_48,lVar4,DAT_181d9c570);
            local_60 = local_48;
            uStack_5c = uStack_44;
            uStack_58 = uStack_40;
            uStack_54 = uStack_3c;
            local_50 = local_38;
            while( true ) {
              cVar2 = FUN_1811d8280(&local_60,DAT_181d74c38);
              uVar1 = local_50;
              if (!cVar2) {
                ZhSegment.Initialize(&local_60,DAT_181d74bb8);
                return plVar3;
              }
              if (*(int64 *)(b + 16) == 0) {
                          // WARNING: Subroutine does not return
                FUN_1800d6620();
              }
              cVar2 = FUN_1808ab750(*(int64 *)(b + 16),uVar1 & 0xffffffff,DAT_181d984b8);
              if (!cVar2) {
                fVar6 = 0.0;
              }
              else {
                if (*(int64 *)(b + 16) == 0) {
                          // WARNING: Subroutine does not return
                  FUN_1800d6620();
                }
                fVar6 = (float)FUN_1817cc640(*(int64 *)(b + 16),uVar1 & 0xffffffff,
                                             DAT_181d98a88);
              }
              if (plVar3 == (int64 *)0) break;
              if (plVar3[2] == 0) {
                          // WARNING: Subroutine does not return
                FUN_1800d6620();
              }
              cVar2 = FUN_1808ab750(plVar3[2],uVar1 & 0xffffffff,DAT_181d984b8);
              if (!cVar2) {
                fVar5 = 0.0;
              }
              else {
                if (plVar3[2] == 0) {
                          // WARNING: Subroutine does not return
                  FUN_1800d6620();
                }
                fVar5 = (float)FUN_1817cc640(plVar3[2],uVar1 & 0xffffffff,DAT_181d98a88);
              }
              ForceSpeAddData.Set(plVar3,uVar1 & 0xffffffff,-fVar6 + fVar5,0);
            }
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
        }
    }

    // Token : 0x6000F15
    // RVA   : 0x782CD0   Offset: 0x7814D0   Length: 0xA
    public string GetDescribe()
    {
        var pStatics = *(int64*)(DAT_181d4ef00 + 184);
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
          uVar3 = DAT_181d94308;
          uVar3 = Type.GetTypeFromHandle(uVar3,0);
          lVar4 = Enum.GetValues(uVar3,0);
          if (lVar4 == null) goto LAB_180782c39;
          iVar2 = FUN_1812c5970(lVar4,0);
          if (iVar2 <= iVar8) {
            return lVar7;
          }
          fVar9 = (float)ForceSpeAddData.Get(this,iVar8,0);
          if (fVar9 != 0.0) {
            if (param_2) {
              local_48[0] = iVar8;
              plVar5 = (int64 *)il2cpp_value_box(DAT_181da2ea0,local_48);
              if (plVar5 == (int64 *)0) goto LAB_180782c39;
              lVar4 = (**(code **)(*plVar5 + 0x168))(plVar5,*(uint64 *)(*plVar5 + 0x170));
              piVar6 = (int *)il2cpp_object_unbox(plVar5);
              local_48[0] = *piVar6;
              if (lVar4 == null) goto LAB_180782c39;
              cVar1 = String.Contains(lVar4);
              if (cVar1) goto LAB_180782c09;
            }
            plVar5 = (int64 *)FUN_1800d60b0(DAT_181d80cc0,6);
            if (plVar5 == (int64 *)0) {
        LAB_180782c39:
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            if ((lVar7 != null) &&
               (lVar4 = il2cpp_internal(lVar7,*(uint64 *)(*plVar5 + 64))) == null) {
              uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar3,0);
            }
            if ((int)plVar5[3] == 0) {
              uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar3,0);
            }
            plVar5[4] = lVar7;
            il2cpp_internal(plVar5 + 4,lVar7);
            cVar1 = FUN_1816fd990(lVar7,"",0);
            lVar7 = "\n";
            if (cVar1) {
              lVar7 = "";
            }
            if ((lVar7 != null) &&
               (lVar4 = il2cpp_internal(lVar7,*(uint64 *)(*plVar5 + 64))) == null) {
              uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar3,0);
            }
            FUN_180002fd0(plVar5,1,lVar7);
            if (this.forceSpeAddData == null) goto LAB_180782c39;
            fVar9 = (float)FUN_1817cc640(this.forceSpeAddData,iVar8,DAT_181d98a88);
            if (fVar9 <= 0.0) {
              lVar7 = *(int64 *)(pStatics + 0x2c8);
            }
            else {
              lVar7 = *(int64 *)(pStatics + 0x260);
            }
            if ((lVar7 != null) &&
               (lVar4 = il2cpp_internal(lVar7,*(uint64 *)(*plVar5 + 64))) == null) {
              uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar3,0);
            }
            FUN_180002fd0(plVar5,2,lVar7);
            lVar7 = FUN_18046c100(0);
            if (((lVar7 == null) || (*(int64 *)(lVar7 + 152) == 0)) ||
               (lVar7 = FUN_180002f80(*(int64 *)(lVar7 + 152),iVar8,DAT_181d610f8)) == null)
            goto LAB_180782c39;
            lVar7 = *(int64 *)(lVar7 + 16);
            if ((lVar7 != null) &&
               (lVar4 = il2cpp_internal(lVar7,*(uint64 *)(*plVar5 + 64))) == null) {
              uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar3,0);
            }
            if (*(uint32 *)(plVar5 + 3) < 4) {
              uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar3,0);
            }
            plVar5[7] = lVar7;
            il2cpp_internal(plVar5 + 7,lVar7);
            lVar7 = FUN_18046c100(0);
            if (((lVar7 == null) || (*(int64 *)(lVar7 + 152) == 0)) ||
               (lVar7 = FUN_180002f80(*(int64 *)(lVar7 + 152),iVar8,DAT_181d610f8)) == null)
            goto LAB_180782c39;
            lVar4 = this.forceSpeAddData;
            if (*(char *)(lVar7 + 32) == false) {
              if (lVar4 == null) goto LAB_180782c39;
              local_res20[0] = (float)FUN_1817cc640(lVar4,iVar8,DAT_181d98a88);
              lVar7 = Single.ToString(local_res20,"+0.##;-0.##;0",0);
            }
            else {
              if (lVar4 == null) goto LAB_180782c39;
              local_res20[0] = (float)FUN_1817cc640(lVar4,iVar8,DAT_181d98a88);
              local_res20[0] = local_res20[0] * 100.0;
              uVar3 = Single.ToString(local_res20,"+0.##;-0.##;0",0);
              lVar7 = String.Concat(uVar3,"%",0);
            }
            if ((lVar7 != null) &&
               (lVar7 = il2cpp_internal(lVar7,*(uint64 *)(*plVar5 + 64))) == null) {
              uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar3,0);
            }
            FUN_180002fd0(plVar5,4);
            if (("</color>" != 0) &&
               (lVar7 = il2cpp_internal("</color>",*(uint64 *)(*plVar5 + 64))) == null) {
              uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar3,0);
            }
            if (*(uint32 *)(plVar5 + 3) < 6) {
              uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar3,0);
            }
            plVar5[9] = "</color>";
            il2cpp_internal();
            lVar7 = String.Concat(plVar5);
          }
        LAB_180782c09:
          iVar8 = iVar8 + 1;
        } while( true );
    }

    // Token : 0x6000F16
    // RVA   : 0x7826D0   Offset: 0x780ED0   Length: 0x5FE
    public string GetDescribe(bool noLocal)
    {
        var pStatics = *(int64*)(DAT_181d4ef00 + 184);
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
          uVar3 = DAT_181d94308;
          uVar3 = Type.GetTypeFromHandle(uVar3,0);
          lVar4 = Enum.GetValues(uVar3,0);
          if (lVar4 == null) goto LAB_180782c39;
          iVar2 = FUN_1812c5970(lVar4,0);
          if (iVar2 <= iVar8) {
            return lVar7;
          }
          fVar9 = (float)ForceSpeAddData.Get(this,iVar8,0);
          if (fVar9 != 0.0) {
            if (noLocal) {
              local_48[0] = iVar8;
              plVar5 = (int64 *)il2cpp_value_box(DAT_181da2ea0,local_48);
              if (plVar5 == (int64 *)0) goto LAB_180782c39;
              lVar4 = (**(code **)(*plVar5 + 0x168))(plVar5,*(uint64 *)(*plVar5 + 0x170));
              piVar6 = (int *)il2cpp_object_unbox(plVar5);
              local_48[0] = *piVar6;
              if (lVar4 == null) goto LAB_180782c39;
              cVar1 = String.Contains(lVar4);
              if (cVar1) goto LAB_180782c09;
            }
            plVar5 = (int64 *)FUN_1800d60b0(DAT_181d80cc0,6);
            if (plVar5 == (int64 *)0) {
        LAB_180782c39:
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            if ((lVar7 != null) &&
               (lVar4 = il2cpp_internal(lVar7,*(uint64 *)(*plVar5 + 64))) == null) {
              uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar3,0);
            }
            if ((int)plVar5[3] == 0) {
              uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar3,0);
            }
            plVar5[4] = lVar7;
            il2cpp_internal(plVar5 + 4,lVar7);
            cVar1 = FUN_1816fd990(lVar7,"",0);
            lVar7 = "\n";
            if (cVar1) {
              lVar7 = "";
            }
            if ((lVar7 != null) &&
               (lVar4 = il2cpp_internal(lVar7,*(uint64 *)(*plVar5 + 64))) == null) {
              uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar3,0);
            }
            FUN_180002fd0(plVar5,1,lVar7);
            if (this.forceSpeAddData == null) goto LAB_180782c39;
            fVar9 = (float)FUN_1817cc640(this.forceSpeAddData,iVar8,DAT_181d98a88);
            if (fVar9 <= 0.0) {
              lVar7 = *(int64 *)(pStatics + 0x2c8);
            }
            else {
              lVar7 = *(int64 *)(pStatics + 0x260);
            }
            if ((lVar7 != null) &&
               (lVar4 = il2cpp_internal(lVar7,*(uint64 *)(*plVar5 + 64))) == null) {
              uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar3,0);
            }
            FUN_180002fd0(plVar5,2,lVar7);
            lVar7 = FUN_18046c100(0);
            if (((lVar7 == null) || (*(int64 *)(lVar7 + 152) == 0)) ||
               (lVar7 = FUN_180002f80(*(int64 *)(lVar7 + 152),iVar8,DAT_181d610f8)) == null)
            goto LAB_180782c39;
            lVar7 = *(int64 *)(lVar7 + 16);
            if ((lVar7 != null) &&
               (lVar4 = il2cpp_internal(lVar7,*(uint64 *)(*plVar5 + 64))) == null) {
              uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar3,0);
            }
            if (*(uint32 *)(plVar5 + 3) < 4) {
              uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar3,0);
            }
            plVar5[7] = lVar7;
            il2cpp_internal(plVar5 + 7,lVar7);
            lVar7 = FUN_18046c100(0);
            if (((lVar7 == null) || (*(int64 *)(lVar7 + 152) == 0)) ||
               (lVar7 = FUN_180002f80(*(int64 *)(lVar7 + 152),iVar8,DAT_181d610f8)) == null)
            goto LAB_180782c39;
            lVar4 = this.forceSpeAddData;
            if (*(char *)(lVar7 + 32) == false) {
              if (lVar4 == null) goto LAB_180782c39;
              local_res20[0] = (float)FUN_1817cc640(lVar4,iVar8,DAT_181d98a88);
              lVar7 = Single.ToString(local_res20,"+0.##;-0.##;0",0);
            }
            else {
              if (lVar4 == null) goto LAB_180782c39;
              local_res20[0] = (float)FUN_1817cc640(lVar4,iVar8,DAT_181d98a88);
              local_res20[0] = local_res20[0] * 100.0;
              uVar3 = Single.ToString(local_res20,"+0.##;-0.##;0",0);
              lVar7 = String.Concat(uVar3,"%",0);
            }
            if ((lVar7 != null) &&
               (lVar7 = il2cpp_internal(lVar7,*(uint64 *)(*plVar5 + 64))) == null) {
              uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar3,0);
            }
            FUN_180002fd0(plVar5,4);
            if (("</color>" != 0) &&
               (lVar7 = il2cpp_internal("</color>",*(uint64 *)(*plVar5 + 64))) == null) {
              uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar3,0);
            }
            if (*(uint32 *)(plVar5 + 3) < 6) {
              uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar3,0);
            }
            plVar5[9] = "</color>";
            il2cpp_internal();
            lVar7 = String.Concat(plVar5);
          }
        LAB_180782c09:
          iVar8 = iVar8 + 1;
        } while( true );
    }

    // Token : 0x6000F17
    // RVA   : 0x782550   Offset: 0x780D50   Length: 0x175
    public virtual object Clone()
    {
        long lVar2;
        ulong uVar3;
        ulong local_38;
        ulong uStack_30;
        uint local_28;
        uint uStack_24;
        uint uStack_20;
        uint32 uStack_1c;
        plVar1 = (int64 *)il2cpp_internal(DAT_181d63ff0);
        plVar4 = plVar1;
        MemoryStream.ctor(plVar1,1000,0);
        local_38 = 0;
        uStack_30 = 0;
        StreamingContext.ctor(&local_38,64,0);
        lVar2 = il2cpp_internal(DAT_181d8c5a8);
        local_28 = (uint32)local_38;
        uStack_24 = local_38._4_4_;
        uStack_20 = (uint32)uStack_30;
        uStack_1c = uStack_30._4_4_;
        BinaryFormatter.ctor(lVar2,0,&local_28,0,plVar4);
        if (lVar2 != null) {
          BinaryFormatter.Serialize(lVar2,plVar1,this,0);
          if (plVar1 != (int64 *)0) {
            (**(code **)(*plVar1 + 0x2c8))(plVar1,0,0,*(uint64 *)(*plVar1 + 0x2d0));
            uVar3 = BinaryFormatter.Deserialize(lVar2,plVar1,0);
            (**(code **)(*plVar1 + 0x238))(plVar1,*(uint64 *)(*plVar1 + 0x240));
            FUN_180002970(0,DAT_181d53c70,plVar1);
            return uVar3;
          }
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
    }

}
