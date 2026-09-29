// ============================================================
// Type  : ForceSpeAddData
// Token : 0x20001EB
// ============================================================

public class ForceSpeAddData
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4000DA4
    public Dictionary<int, float> forceSpeAddData;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000F3A
    // RVA   : 0x77F8E0   Offset: 0x77ECE0   Length: 0x76
    public void /*ctor*/()
    {
        ulong uVar1;
        ZhSegment.Initialize(this,0);
        uVar1 = il2cpp_internal(DAT_181d81600);
        FUN_1808b1370(uVar1,DAT_181dbdbd0);
        this.forceSpeAddData = uVar1;
    }

    // Token : 0x6000F3B
    // RVA   : 0x77F720   Offset: 0x77EB20   Length: 0x94
    public void Reset()
    {
        ulong uVar1;
        if (this.forceSpeAddData != null) {
          Dictionary_2.Clear(this.forceSpeAddData,DAT_181dbddf0);
          return;
        }
        uVar1 = il2cpp_internal(DAT_181d81600);
        FUN_1808b1370(uVar1,DAT_181dbdbd0);
        this.forceSpeAddData = uVar1;
    }

    // Token : 0x6000F3C
    // RVA   : 0x77F8D0   Offset: 0x77ECD0   Length: 0x8
    public ForceSpeAddData Set(ForceSpeAddDataType speAddDataType, float value)
    {
        long lVar1;
        bool cVar2;
        if (this.forceSpeAddData != null) {
          cVar2 = FUN_1808ab490(this.forceSpeAddData,speAddDataType,DAT_181dbde78);
          if (!cVar2) {
            if (value == null.0) {
              return this;
            }
            if (this.forceSpeAddData != null) {
              FUN_1817afb00(this.forceSpeAddData,speAddDataType,value,DAT_181dbdd68);
              return this;
            }
          }
          else {
            lVar1 = this.forceSpeAddData;
            if (value == null.0) {
              if (lVar1 != null) {
                FUN_18145e460(lVar1,speAddDataType,DAT_181dbe1a0);
                return this;
              }
            }
            else if (lVar1 != null) {
              FUN_1817c6c30(lVar1,speAddDataType,value,DAT_181dbe558);
              return this;
            }
          }
        }
    }

    // Token : 0x6000F3D
    // RVA   : 0x77F7C0   Offset: 0x77EBC0   Length: 0x10C
    public ForceSpeAddData Set(int speAddDataType, float value)
    {
        long lVar1;
        bool cVar2;
        if (this.forceSpeAddData != null) {
          cVar2 = FUN_1808ab490(this.forceSpeAddData,speAddDataType,DAT_181dbde78);
          if (!cVar2) {
            if (value == null.0) {
              return this;
            }
            if (this.forceSpeAddData != null) {
              FUN_1817afb00(this.forceSpeAddData,speAddDataType,value,DAT_181dbdd68);
              return this;
            }
          }
          else {
            lVar1 = this.forceSpeAddData;
            if (value == null.0) {
              if (lVar1 != null) {
                FUN_18145e460(lVar1,speAddDataType,DAT_181dbe1a0);
                return this;
              }
            }
            else if (lVar1 != null) {
              FUN_1817c6c30(lVar1,speAddDataType,value,DAT_181dbe558);
              return this;
            }
          }
        }
    }

    // Token : 0x6000F3E
    // RVA   : 0x77F680   Offset: 0x77EA80   Length: 0x8
    public float Get(ForceSpeAddDataType speAddDataType)
    {
        bool cVar1;
        ulong uVar2;
        if (this.forceSpeAddData != null) {
          cVar1 = FUN_1808ab490(this.forceSpeAddData,speAddDataType,DAT_181dbde78);
          if (!cVar1) {
            return 0;
          }
          if (this.forceSpeAddData != null) {
            uVar2 = FUN_1817da2e0(this.forceSpeAddData,speAddDataType,DAT_181dbe448);
            return uVar2;
          }
        }
    }

    // Token : 0x6000F3F
    // RVA   : 0x77F690   Offset: 0x77EA90   Length: 0x86
    public float Get(int speAddDataType)
    {
        bool cVar1;
        ulong uVar2;
        if (this.forceSpeAddData != null) {
          cVar1 = FUN_1808ab490(this.forceSpeAddData,speAddDataType,DAT_181dbde78);
          if (!cVar1) {
            return 0;
          }
          if (this.forceSpeAddData != null) {
            uVar2 = FUN_1817da2e0(this.forceSpeAddData,speAddDataType,DAT_181dbe448);
            return uVar2;
          }
        }
    }

    // Token : 0x6000F40
    // RVA   : 0x77EE40   Offset: 0x77E240   Length: 0x42
    public void Change(ForceSpeAddDataType speAddDataType, float delta)
    {
        float fVar1;
        fVar1 = (float)ForceSpeAddData.Get(this,speAddDataType,0);
        ForceSpeAddData.Set(this,speAddDataType & 0xffffffff,fVar1 + delta,0);
    }

    // Token : 0x6000F41
    // RVA   : 0x77EE40   Offset: 0x77E240   Length: 0x42
    public void Change(int speAddDataType, float delta)
    {
        float fVar1;
        fVar1 = (float)ForceSpeAddData.Get(this,speAddDataType,0);
        ForceSpeAddData.Set(this,speAddDataType & 0xffffffff,fVar1 + delta,0);
    }

    // Token : 0x6000F42
    // RVA   : 0x77EDF0   Offset: 0x77E1F0   Length: 0x42
    public void ChangeMulti(ForceSpeAddDataType speAddDataType, float multi)
    {
        float fVar1;
        fVar1 = (float)ForceSpeAddData.Get(this,speAddDataType,0);
        ForceSpeAddData.Set(this,speAddDataType & 0xffffffff,fVar1 * multi,0);
    }

    // Token : 0x6000F43
    // RVA   : 0x77EDF0   Offset: 0x77E1F0   Length: 0x42
    public void ChangeMulti(int speAddDataType, float multi)
    {
        float fVar1;
        fVar1 = (float)ForceSpeAddData.Get(this,speAddDataType,0);
        ForceSpeAddData.Set(this,speAddDataType & 0xffffffff,fVar1 * multi,0);
    }

    // Token : 0x6000F44
    // RVA   : 0x77F620   Offset: 0x77EA20   Length: 0x5F
    public List<int> GetKeys()
    {
        ulong uVar1;
        if (this.forceSpeAddData != null) {
          uVar1 = Dictionary_2.get_Keys(this.forceSpeAddData,DAT_181dbe4d0);
          FUN_180972500(uVar1,DAT_181db53d8);
          return;
        }
    }

    // Token : 0x6000F45
    // RVA   : 0x77F960   Offset: 0x77ED60   Length: 0x1D3
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
           (lVar2 = Dictionary_2.get_Keys(this.forceSpeAddData,DAT_181dbe4d0)) == null) {
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
        FUN_180ecc540(&local_38,lVar2,DAT_181dc3708);
        local_50 = local_38;
        uStack_4c = uStack_34;
        uStack_48 = uStack_30;
        uStack_44 = uStack_2c;
        local_40 = local_28;
        do {
          cVar1 = FUN_1811c5570(&local_50,DAT_181d9b270);
          if (!cVar1) {
            aiStack_64[1] = 75;
            iVar4 = aiStack_64[3] + 1;
            aiStack_64[3] = iVar4;
            ZhSegment.Initialize(&local_50,DAT_181d9b1f0);
            goto LAB_18077faf0;
          }
          if (this.forceSpeAddData == null) {
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          fVar5 = (float)FUN_1817da2e0(this.forceSpeAddData,local_40 & 0xffffffff,DAT_181dbe448);
        } while (fVar5 == 0.0);
        aiStack_64[1] = 77;
        iVar4 = aiStack_64[3] + 1;
        aiStack_64[3] = iVar4;
        ZhSegment.Initialize(&local_50,DAT_181d9b1f0);
        LAB_18077faf0:
        if ((iVar4 == 0) || (aiStack_64[iVar4] != 77)) {
          uVar3 = 1;
        }
        else {
          uVar3 = 0;
        }
        return uVar3;
    }

    // Token : 0x6000F46
    // RVA   : 0x77FB40   Offset: 0x77EF40   Length: 0x2B4
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
             (lVar4 = Dictionary_2.get_Keys(*(int64 *)(b + 16),DAT_181dbe4d0)) != null) {
            FUN_180ecc540(&local_38,lVar4,DAT_181dc3708);
            local_50 = local_38;
            uStack_4c = uStack_34;
            uStack_48 = uStack_30;
            uStack_44 = uStack_2c;
            local_40 = local_28;
            while( true ) {
              cVar2 = FUN_1811c5570(&local_50,DAT_181d9b270);
              uVar1 = local_40;
              if (!cVar2) {
                ZhSegment.Initialize(&local_50,DAT_181d9b1f0);
                return plVar3;
              }
              if (*(int64 *)(b + 16) == 0) {
                          // WARNING: Subroutine does not return
                FUN_1800d6620();
              }
              cVar2 = FUN_1808ab490(*(int64 *)(b + 16),uVar1 & 0xffffffff,DAT_181dbde78);
              if (!cVar2) {
                fVar6 = 0.0;
              }
              else {
                if (*(int64 *)(b + 16) == 0) {
                          // WARNING: Subroutine does not return
                  FUN_1800d6620();
                }
                fVar6 = (float)FUN_1817da2e0(*(int64 *)(b + 16),uVar1 & 0xffffffff,
                                             DAT_181dbe448);
              }
              if (plVar3 == (int64 *)0) break;
              if (plVar3[2] == 0) {
                          // WARNING: Subroutine does not return
                FUN_1800d6620();
              }
              cVar2 = FUN_1808ab490(plVar3[2],uVar1 & 0xffffffff,DAT_181dbde78);
              if (!cVar2) {
                fVar5 = 0.0;
              }
              else {
                if (plVar3[2] == 0) {
                          // WARNING: Subroutine does not return
                  FUN_1800d6620();
                }
                fVar5 = (float)FUN_1817da2e0(plVar3[2],uVar1 & 0xffffffff,DAT_181dbe448);
              }
              ForceSpeAddData.Set(plVar3,uVar1 & 0xffffffff,fVar5 + fVar6,0);
            }
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
        }
    }

    // Token : 0x6000F47
    // RVA   : 0x780030   Offset: 0x77F430   Length: 0xF
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
             (lVar4 = Dictionary_2.get_Keys(*(int64 *)(a + 16),DAT_181dbe4d0)) != null) {
            FUN_180ecc540(&local_38,lVar4,DAT_181dc3708);
            local_50 = local_38;
            uStack_4c = uStack_34;
            uStack_48 = uStack_30;
            uStack_44 = uStack_2c;
            local_40 = local_28;
            while( true ) {
              cVar2 = FUN_1811c5570(&local_50,DAT_181d9b270);
              uVar1 = local_40;
              if (!cVar2) {
                ZhSegment.Initialize(&local_50,DAT_181d9b1f0);
                return plVar3;
              }
              if (plVar3 == (int64 *)0) break;
              if (plVar3[2] == 0) {
                          // WARNING: Subroutine does not return
                FUN_1800d6620();
              }
              cVar2 = FUN_1808ab490(plVar3[2],uVar1 & 0xffffffff,DAT_181dbde78);
              if (!cVar2) {
                fVar5 = 0.0;
              }
              else {
                if (plVar3[2] == 0) {
                          // WARNING: Subroutine does not return
                  FUN_1800d6620();
                }
                fVar5 = (float)FUN_1817da2e0(plVar3[2],uVar1 & 0xffffffff,DAT_181dbe448);
              }
              ForceSpeAddData.Set(plVar3,uVar1 & 0xffffffff,fVar5 * b,0);
            }
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
        }
    }

    // Token : 0x6000F48
    // RVA   : 0x77FE00   Offset: 0x77F200   Length: 0x22A
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
             (lVar4 = Dictionary_2.get_Keys(*(int64 *)(a + 16),DAT_181dbe4d0)) != null) {
            FUN_180ecc540(&local_38,lVar4,DAT_181dc3708);
            local_50 = local_38;
            uStack_4c = uStack_34;
            uStack_48 = uStack_30;
            uStack_44 = uStack_2c;
            local_40 = local_28;
            while( true ) {
              cVar2 = FUN_1811c5570(&local_50,DAT_181d9b270);
              uVar1 = local_40;
              if (!cVar2) {
                ZhSegment.Initialize(&local_50,DAT_181d9b1f0);
                return plVar3;
              }
              if (plVar3 == (int64 *)0) break;
              if (plVar3[2] == 0) {
                          // WARNING: Subroutine does not return
                FUN_1800d6620();
              }
              cVar2 = FUN_1808ab490(plVar3[2],uVar1 & 0xffffffff,DAT_181dbde78);
              if (!cVar2) {
                fVar5 = 0.0;
              }
              else {
                if (plVar3[2] == 0) {
                          // WARNING: Subroutine does not return
                  FUN_1800d6620();
                }
                fVar5 = (float)FUN_1817da2e0(plVar3[2],uVar1 & 0xffffffff,DAT_181dbe448);
              }
              ForceSpeAddData.Set(plVar3,uVar1 & 0xffffffff,fVar5 * b,0);
            }
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
        }
    }

    // Token : 0x6000F49
    // RVA   : 0x780040   Offset: 0x77F440   Length: 0x2CF
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
             (lVar4 = Dictionary_2.get_Keys(*(int64 *)(b + 16),DAT_181dbe4d0)) != null) {
            FUN_180ecc540(&local_48,lVar4,DAT_181dc3708);
            local_60 = local_48;
            uStack_5c = uStack_44;
            uStack_58 = uStack_40;
            uStack_54 = uStack_3c;
            local_50 = local_38;
            while( true ) {
              cVar2 = FUN_1811c5570(&local_60,DAT_181d9b270);
              uVar1 = local_50;
              if (!cVar2) {
                ZhSegment.Initialize(&local_60,DAT_181d9b1f0);
                return plVar3;
              }
              if (*(int64 *)(b + 16) == 0) {
                          // WARNING: Subroutine does not return
                FUN_1800d6620();
              }
              cVar2 = FUN_1808ab490(*(int64 *)(b + 16),uVar1 & 0xffffffff,DAT_181dbde78);
              if (!cVar2) {
                fVar6 = 0.0;
              }
              else {
                if (*(int64 *)(b + 16) == 0) {
                          // WARNING: Subroutine does not return
                  FUN_1800d6620();
                }
                fVar6 = (float)FUN_1817da2e0(*(int64 *)(b + 16),uVar1 & 0xffffffff,
                                             DAT_181dbe448);
              }
              if (plVar3 == (int64 *)0) break;
              if (plVar3[2] == 0) {
                          // WARNING: Subroutine does not return
                FUN_1800d6620();
              }
              cVar2 = FUN_1808ab490(plVar3[2],uVar1 & 0xffffffff,DAT_181dbde78);
              if (!cVar2) {
                fVar5 = 0.0;
              }
              else {
                if (plVar3[2] == 0) {
                          // WARNING: Subroutine does not return
                  FUN_1800d6620();
                }
                fVar5 = (float)FUN_1817da2e0(plVar3[2],uVar1 & 0xffffffff,DAT_181dbe448);
              }
              ForceSpeAddData.Set(plVar3,uVar1 & 0xffffffff,-fVar6 + fVar5,0);
            }
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
        }
    }

    // Token : 0x6000F4A
    // RVA   : 0x77F610   Offset: 0x77EA10   Length: 0xA
    public string GetDescribe()
    {
        var pStatics = *(int64*)(DAT_181d73d40 + 184);
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
          uVar3 = DAT_181db8bd0;
          uVar3 = Type.GetTypeFromHandle(uVar3,0);
          lVar4 = Enum.GetValues(uVar3,0);
          if (lVar4 == null) goto LAB_18077f579;
          iVar2 = FUN_1812fec90(lVar4,0);
          if (iVar2 <= iVar8) {
            return lVar7;
          }
          fVar9 = (float)ForceSpeAddData.Get(this,iVar8,0);
          if (fVar9 != 0.0) {
            if (param_2) {
              local_48[0] = iVar8;
              plVar5 = (int64 *)il2cpp_value_box(DAT_181dc8268,local_48);
              if (plVar5 == (int64 *)0) goto LAB_18077f579;
              lVar4 = (**(code **)(*plVar5 + 0x168))(plVar5,*(uint64 *)(*plVar5 + 0x170));
              piVar6 = (int *)il2cpp_object_unbox(plVar5);
              local_48[0] = *piVar6;
              if (lVar4 == null) goto LAB_18077f579;
              cVar1 = String.Contains(lVar4);
              if (cVar1) goto LAB_18077f549;
            }
            plVar5 = (int64 *)FUN_1800d60b0(DAT_181da5cf8,6);
            if (plVar5 == (int64 *)0) {
        LAB_18077f579:
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
            cVar1 = FUN_18171eb50(lVar7,"",0);
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
            if (this.forceSpeAddData == null) goto LAB_18077f579;
            fVar9 = (float)FUN_1817da2e0(this.forceSpeAddData,iVar8,DAT_181dbe448);
            if (fVar9 <= 0.0) {
              lVar7 = *(int64 *)(pStatics + 0x2d0);
            }
            else {
              lVar7 = *(int64 *)(pStatics + 0x268);
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
               (lVar7 = FUN_180002f80(*(int64 *)(lVar7 + 152),iVar8,DAT_181d888b0)) == null)
            goto LAB_18077f579;
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
               (lVar7 = FUN_180002f80(*(int64 *)(lVar7 + 152),iVar8,DAT_181d888b0)) == null)
            goto LAB_18077f579;
            lVar4 = this.forceSpeAddData;
            if (*(char *)(lVar7 + 32) == false) {
              if (lVar4 == null) goto LAB_18077f579;
              local_res20[0] = (float)FUN_1817da2e0(lVar4,iVar8,DAT_181dbe448);
              lVar7 = Single.ToString(local_res20,"+0.##;-0.##;0",0);
            }
            else {
              if (lVar4 == null) goto LAB_18077f579;
              local_res20[0] = (float)FUN_1817da2e0(lVar4,iVar8,DAT_181dbe448);
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
        LAB_18077f549:
          iVar8 = iVar8 + 1;
        } while( true );
    }

    // Token : 0x6000F4B
    // RVA   : 0x77F010   Offset: 0x77E410   Length: 0x5FE
    public string GetDescribe(bool noLocal)
    {
        var pStatics = *(int64*)(DAT_181d73d40 + 184);
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
          uVar3 = DAT_181db8bd0;
          uVar3 = Type.GetTypeFromHandle(uVar3,0);
          lVar4 = Enum.GetValues(uVar3,0);
          if (lVar4 == null) goto LAB_18077f579;
          iVar2 = FUN_1812fec90(lVar4,0);
          if (iVar2 <= iVar8) {
            return lVar7;
          }
          fVar9 = (float)ForceSpeAddData.Get(this,iVar8,0);
          if (fVar9 != 0.0) {
            if (noLocal) {
              local_48[0] = iVar8;
              plVar5 = (int64 *)il2cpp_value_box(DAT_181dc8268,local_48);
              if (plVar5 == (int64 *)0) goto LAB_18077f579;
              lVar4 = (**(code **)(*plVar5 + 0x168))(plVar5,*(uint64 *)(*plVar5 + 0x170));
              piVar6 = (int *)il2cpp_object_unbox(plVar5);
              local_48[0] = *piVar6;
              if (lVar4 == null) goto LAB_18077f579;
              cVar1 = String.Contains(lVar4);
              if (cVar1) goto LAB_18077f549;
            }
            plVar5 = (int64 *)FUN_1800d60b0(DAT_181da5cf8,6);
            if (plVar5 == (int64 *)0) {
        LAB_18077f579:
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
            cVar1 = FUN_18171eb50(lVar7,"",0);
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
            if (this.forceSpeAddData == null) goto LAB_18077f579;
            fVar9 = (float)FUN_1817da2e0(this.forceSpeAddData,iVar8,DAT_181dbe448);
            if (fVar9 <= 0.0) {
              lVar7 = *(int64 *)(pStatics + 0x2d0);
            }
            else {
              lVar7 = *(int64 *)(pStatics + 0x268);
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
               (lVar7 = FUN_180002f80(*(int64 *)(lVar7 + 152),iVar8,DAT_181d888b0)) == null)
            goto LAB_18077f579;
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
               (lVar7 = FUN_180002f80(*(int64 *)(lVar7 + 152),iVar8,DAT_181d888b0)) == null)
            goto LAB_18077f579;
            lVar4 = this.forceSpeAddData;
            if (*(char *)(lVar7 + 32) == false) {
              if (lVar4 == null) goto LAB_18077f579;
              local_res20[0] = (float)FUN_1817da2e0(lVar4,iVar8,DAT_181dbe448);
              lVar7 = Single.ToString(local_res20,"+0.##;-0.##;0",0);
            }
            else {
              if (lVar4 == null) goto LAB_18077f579;
              local_res20[0] = (float)FUN_1817da2e0(lVar4,iVar8,DAT_181dbe448);
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
        LAB_18077f549:
          iVar8 = iVar8 + 1;
        } while( true );
    }

    // Token : 0x6000F4C
    // RVA   : 0x77EE90   Offset: 0x77E290   Length: 0x175
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
        plVar1 = (int64 *)il2cpp_internal(DAT_181d89228);
        plVar4 = plVar1;
        MemoryStream.ctor(plVar1,1000,0);
        local_38 = 0;
        uStack_30 = 0;
        StreamingContext.ctor(&local_38,64,0);
        lVar2 = il2cpp_internal(DAT_181db1748);
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
            FUN_180002970(0,DAT_181d78db8,plVar1);
            return uVar3;
          }
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
    }

}
