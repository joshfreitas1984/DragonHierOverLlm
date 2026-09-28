// ============================================================
// Type  : HeroSpeAddData
// Token : 0x2000223
// ============================================================

public class HeroSpeAddData
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x400113C
    public Dictionary<int, float> heroSpeAddData;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x600123A
    // RVA   : 0xAFCBF0   Offset: 0xAFBFF0   Length: 0x76
    public void /*ctor*/()
    {
        ulong uVar1;
        ZhSegment.Initialize(this,0);
        uVar1 = il2cpp_internal(DAT_181d815e8);
        FUN_1808b1370(uVar1,DAT_181dbdbb8);
        this.heroSpeAddData = uVar1;
    }

    // Token : 0x600123B
    // RVA   : 0xAFCA30   Offset: 0xAFBE30   Length: 0x94
    public void Reset()
    {
        ulong uVar1;
        if (this.heroSpeAddData != null) {
          Dictionary_2.Clear(this.heroSpeAddData,DAT_181dbddd8);
          return;
        }
        uVar1 = il2cpp_internal(DAT_181d815e8);
        FUN_1808b1370(uVar1,DAT_181dbdbb8);
        this.heroSpeAddData = uVar1;
    }

    // Token : 0x600123C
    // RVA   : 0xAFC810   Offset: 0xAFBC10   Length: 0x21F
    public void OverWriteHeroSpeAddData(HeroSpeAddData overWriteData)
    {
        ulong uVar1;
        bool cVar2;
        long lVar3;
        float fVar4;
        float fVar5;
        uint uVar6;
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
        if (((overWriteData == null) || (*(int64 *)(overWriteData + 16) == 0)) ||
           (lVar3 = Dictionary_2.get_Keys(*(int64 *)(overWriteData + 16),DAT_181dbe4b8)) == null) {
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
        FUN_180ecbf30(&local_48,lVar3,DAT_181dc36f0);
        local_60 = local_48;
        uStack_5c = uStack_44;
        uStack_58 = uStack_40;
        uStack_54 = uStack_3c;
        local_50 = local_38;
        LAB_180afc8e0:
        do {
          do {
            cVar2 = FUN_1811c4f60(&local_60,DAT_181d9b258);
            uVar1 = local_50;
            if (!cVar2) {
              ZhSegment.Initialize(&local_60,DAT_181d9b1d8);
              return;
            }
            if (*(int64 *)(overWriteData + 16) == 0) {
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            cVar2 = FUN_1808ab490(*(int64 *)(overWriteData + 16),uVar1 & 0xffffffff,DAT_181dbde60);
          } while (!cVar2);
          if (*(int64 *)(overWriteData + 16) == 0) {
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          fVar4 = (float)FUN_1817d9cd0(*(int64 *)(overWriteData + 16),uVar1 & 0xffffffff,DAT_181dbe430);
        } while (fVar4 == 0.0);
        fVar4 = (float)HeroSpeAddData.Get(this,uVar1 & 0xffffffff,0);
        if (fVar4 != 0.0) goto LAB_180afc97e;
        goto LAB_180afc9a4;
        LAB_180afc97e:
        fVar4 = (float)HeroSpeAddData.Get(overWriteData,uVar1 & 0xffffffff,0);
        fVar5 = (float)HeroSpeAddData.Get(this,uVar1 & 0xffffffff,0);
        if (fVar5 < fVar4) {
        LAB_180afc9a4:
          uVar6 = HeroSpeAddData.Get(overWriteData,uVar1 & 0xffffffff,0);
          HeroSpeAddData.Set(this,uVar1 & 0xffffffff,uVar6,0);
        }
        goto LAB_180afc8e0;
    }

    // Token : 0x600123D
    // RVA   : 0xAFCAD0   Offset: 0xAFBED0   Length: 0x8
    public HeroSpeAddData Set(HeroSpeAddDataType speAddDataType, float value)
    {
        long lVar1;
        bool cVar2;
        if (this.heroSpeAddData != null) {
          cVar2 = FUN_1808ab490(this.heroSpeAddData,speAddDataType,DAT_181dbde60);
          if (!cVar2) {
            if (value == null.0) {
              return this;
            }
            if (this.heroSpeAddData != null) {
              FUN_1817af4f0(this.heroSpeAddData,speAddDataType,value,DAT_181dbdd50);
              return this;
            }
          }
          else {
            lVar1 = this.heroSpeAddData;
            if (value == null.0) {
              if (lVar1 != null) {
                FUN_18145de50(lVar1,speAddDataType,DAT_181dbe188);
                return this;
              }
            }
            else if (lVar1 != null) {
              FUN_1817c6620(lVar1,speAddDataType,value,DAT_181dbe540);
              return this;
            }
          }
        }
    }

    // Token : 0x600123E
    // RVA   : 0xAFCAE0   Offset: 0xAFBEE0   Length: 0x10C
    public HeroSpeAddData Set(int speAddDataType, float value)
    {
        long lVar1;
        bool cVar2;
        if (this.heroSpeAddData != null) {
          cVar2 = FUN_1808ab490(this.heroSpeAddData,speAddDataType,DAT_181dbde60);
          if (!cVar2) {
            if (value == null.0) {
              return this;
            }
            if (this.heroSpeAddData != null) {
              FUN_1817af4f0(this.heroSpeAddData,speAddDataType,value,DAT_181dbdd50);
              return this;
            }
          }
          else {
            lVar1 = this.heroSpeAddData;
            if (value == null.0) {
              if (lVar1 != null) {
                FUN_18145de50(lVar1,speAddDataType,DAT_181dbe188);
                return this;
              }
            }
            else if (lVar1 != null) {
              FUN_1817c6620(lVar1,speAddDataType,value,DAT_181dbe540);
              return this;
            }
          }
        }
    }

    // Token : 0x600123F
    // RVA   : 0xAFC3B0   Offset: 0xAFB7B0   Length: 0x8
    public float Get(HeroSpeAddDataType speAddDataType)
    {
        bool cVar1;
        ulong uVar2;
        if (this.heroSpeAddData != null) {
          cVar1 = FUN_1808ab490(this.heroSpeAddData,speAddDataType,DAT_181dbde60);
          if (!cVar1) {
            return 0;
          }
          if (this.heroSpeAddData != null) {
            uVar2 = FUN_1817d9cd0(this.heroSpeAddData,speAddDataType,DAT_181dbe430);
            return uVar2;
          }
        }
    }

    // Token : 0x6001240
    // RVA   : 0xAFC3C0   Offset: 0xAFB7C0   Length: 0x86
    public float Get(int speAddDataType)
    {
        bool cVar1;
        ulong uVar2;
        if (this.heroSpeAddData != null) {
          cVar1 = FUN_1808ab490(this.heroSpeAddData,speAddDataType,DAT_181dbde60);
          if (!cVar1) {
            return 0;
          }
          if (this.heroSpeAddData != null) {
            uVar2 = FUN_1817d9cd0(this.heroSpeAddData,speAddDataType,DAT_181dbe430);
            return uVar2;
          }
        }
    }

    // Token : 0x6001241
    // RVA   : 0xAFB2B0   Offset: 0xAFA6B0   Length: 0x42
    public void Change(HeroSpeAddDataType speAddDataType, float delta)
    {
        float fVar1;
        fVar1 = (float)HeroSpeAddData.Get(this,speAddDataType,0);
        HeroSpeAddData.Set(this,speAddDataType & 0xffffffff,fVar1 + delta,0);
    }

    // Token : 0x6001242
    // RVA   : 0xAFB2B0   Offset: 0xAFA6B0   Length: 0x42
    public void Change(int speAddDataType, float delta)
    {
        float fVar1;
        fVar1 = (float)HeroSpeAddData.Get(this,speAddDataType,0);
        HeroSpeAddData.Set(this,speAddDataType & 0xffffffff,fVar1 + delta,0);
    }

    // Token : 0x6001243
    // RVA   : 0xAFB260   Offset: 0xAFA660   Length: 0x42
    public void ChangeMulti(HeroSpeAddDataType speAddDataType, float multi)
    {
        float fVar1;
        fVar1 = (float)HeroSpeAddData.Get(this,speAddDataType,0);
        HeroSpeAddData.Set(this,speAddDataType & 0xffffffff,fVar1 * multi,0);
    }

    // Token : 0x6001244
    // RVA   : 0xAFB260   Offset: 0xAFA660   Length: 0x42
    public void ChangeMulti(int speAddDataType, float multi)
    {
        float fVar1;
        fVar1 = (float)HeroSpeAddData.Get(this,speAddDataType,0);
        HeroSpeAddData.Set(this,speAddDataType & 0xffffffff,fVar1 * multi,0);
    }

    // Token : 0x6001245
    // RVA   : 0xAFC010   Offset: 0xAFB410   Length: 0x5F
    public List<int> GetKeys()
    {
        ulong uVar1;
        if (this.heroSpeAddData != null) {
          uVar1 = Dictionary_2.get_Keys(this.heroSpeAddData,DAT_181dbe4b8);
          FUN_180971e70(uVar1,DAT_181db53c0);
          return;
        }
    }

    // Token : 0x6001246
    // RVA   : 0xAFCC70   Offset: 0xAFC070   Length: 0x1D3
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
           (lVar2 = Dictionary_2.get_Keys(this.heroSpeAddData,DAT_181dbe4b8)) == null) {
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
        FUN_180ecbf30(&local_38,lVar2,DAT_181dc36f0);
        local_50 = local_38;
        uStack_4c = uStack_34;
        uStack_48 = uStack_30;
        uStack_44 = uStack_2c;
        local_40 = local_28;
        do {
          cVar1 = FUN_1811c4f60(&local_50,DAT_181d9b258);
          if (!cVar1) {
            aiStack_64[1] = 75;
            iVar4 = aiStack_64[3] + 1;
            aiStack_64[3] = iVar4;
            ZhSegment.Initialize(&local_50,DAT_181d9b1d8);
            goto LAB_180afce00;
          }
          if (this.heroSpeAddData == null) {
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          fVar5 = (float)FUN_1817d9cd0(this.heroSpeAddData,local_40 & 0xffffffff,DAT_181dbe430);
        } while (fVar5 == 0.0);
        aiStack_64[1] = 77;
        iVar4 = aiStack_64[3] + 1;
        aiStack_64[3] = iVar4;
        ZhSegment.Initialize(&local_50,DAT_181d9b1d8);
        LAB_180afce00:
        if ((iVar4 == 0) || (aiStack_64[iVar4] != 77)) {
          uVar3 = 1;
        }
        else {
          uVar3 = 0;
        }
        return uVar3;
    }

    // Token : 0x6001247
    // RVA   : 0xAFCE50   Offset: 0xAFC250   Length: 0x3E3
    public static HeroSpeAddData op_Addition(HeroSpeAddData a, HeroSpeAddData b)
    {
        ulong uVar1;
        bool cVar2;
        long lVar4;
        float fVar6;
        float fVar7;
        ulong local_58;
        ulong uStack_50;
        ulong local_48;
        byte[] local_40 = new byte[16];
        ulong local_30;
        local_58 = 0;
        uStack_50 = 0;
        local_48 = 0;
        plVar5 = (int64 *)0;
        if (a == null) {
          local_48 = 0;
          uStack_50 = 0;
          local_58 = 0;
          if (b == null) {
            plVar5 = (int64 *)il2cpp_internal(DAT_181d762f8);
            ZhSegment.Initialize(plVar5,0);
            lVar4 = il2cpp_internal(DAT_181d815e8);
            FUN_1808b1370(lVar4,DAT_181dbdbb8);
            plVar5[2] = lVar4;
            il2cpp_internal(plVar5 + 2,lVar4);
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
          if (((b == null) || (*(int64 *)(b + 16) == 0)) ||
             (lVar4 = Dictionary_2.get_Keys(*(int64 *)(b + 16),DAT_181dbe4b8)) == null) {
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          FUN_180ecbf30(local_40,lVar4,DAT_181dc36f0);
          local_48 = local_30;
          while (cVar2 = FUN_1811c4f60(&local_58,DAT_181d9b258), uVar1 = local_48, cVar2) {
            if (*(int64 *)(b + 16) == 0) {
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            cVar2 = FUN_1808ab490(*(int64 *)(b + 16),uVar1 & 0xffffffff,DAT_181dbde60);
            if (!cVar2) {
              fVar7 = 0.0;
            }
            else {
              if (*(int64 *)(b + 16) == 0) {
                          // WARNING: Subroutine does not return
                FUN_1800d6620();
              }
              fVar7 = (float)FUN_1817d9cd0(*(int64 *)(b + 16),uVar1 & 0xffffffff,DAT_181dbe430)
              ;
            }
            if (plVar5 == (int64 *)0) {
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            if (plVar5[2] == 0) {
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            cVar2 = FUN_1808ab490(plVar5[2],uVar1 & 0xffffffff,DAT_181dbde60);
            if (!cVar2) {
              fVar6 = 0.0;
            }
            else {
              if (plVar5[2] == 0) {
                          // WARNING: Subroutine does not return
                FUN_1800d6620();
              }
              fVar6 = (float)FUN_1817d9cd0(plVar5[2],uVar1 & 0xffffffff,DAT_181dbe430);
            }
            HeroSpeAddData.Set(plVar5,uVar1 & 0xffffffff,fVar6 + fVar7,0);
          }
          ZhSegment.Initialize(&local_58,DAT_181d9b1d8);
        }
        return plVar5;
    }

    // Token : 0x6001248
    // RVA   : 0xAFD480   Offset: 0xAFC880   Length: 0xF
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
             (lVar4 = Dictionary_2.get_Keys(*(int64 *)(a + 16),DAT_181dbe4b8)) != null) {
            FUN_180ecbf30(&local_38,lVar4,DAT_181dc36f0);
            local_50 = local_38;
            uStack_4c = uStack_34;
            uStack_48 = uStack_30;
            uStack_44 = uStack_2c;
            local_40 = local_28;
            while( true ) {
              cVar2 = FUN_1811c4f60(&local_50,DAT_181d9b258);
              uVar1 = local_40;
              if (!cVar2) {
                ZhSegment.Initialize(&local_50,DAT_181d9b1d8);
                return plVar3;
              }
              lVar4 = FUN_18046c100(0);
              if (lVar4 == null) {
                          // WARNING: Subroutine does not return
                FUN_1800d6620();
              }
              if (*(int64 *)(lVar4 + 144) == 0) {
                          // WARNING: Subroutine does not return
                FUN_1800d6620();
              }
              lVar4 = FUN_180002f80(*(int64 *)(lVar4 + 144),uVar1 & 0xffffffff,DAT_181d8c018);
              if (lVar4 == null) break;
              if (*(char *)(lVar4 + 80) == false) {
                if (plVar3 == (int64 *)0) {
                          // WARNING: Subroutine does not return
                  FUN_1800d6620();
                }
                HeroSpeAddData.ChangeMulti(plVar3,uVar1 & 0xffffffff,b,0);
              }
            }
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
        }
    }

    // Token : 0x6001249
    // RVA   : 0xAFD240   Offset: 0xAFC640   Length: 0x235
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
             (lVar4 = Dictionary_2.get_Keys(*(int64 *)(a + 16),DAT_181dbe4b8)) != null) {
            FUN_180ecbf30(&local_38,lVar4,DAT_181dc36f0);
            local_50 = local_38;
            uStack_4c = uStack_34;
            uStack_48 = uStack_30;
            uStack_44 = uStack_2c;
            local_40 = local_28;
            while( true ) {
              cVar2 = FUN_1811c4f60(&local_50,DAT_181d9b258);
              uVar1 = local_40;
              if (!cVar2) {
                ZhSegment.Initialize(&local_50,DAT_181d9b1d8);
                return plVar3;
              }
              lVar4 = FUN_18046c100(0);
              if (lVar4 == null) {
                          // WARNING: Subroutine does not return
                FUN_1800d6620();
              }
              if (*(int64 *)(lVar4 + 144) == 0) {
                          // WARNING: Subroutine does not return
                FUN_1800d6620();
              }
              lVar4 = FUN_180002f80(*(int64 *)(lVar4 + 144),uVar1 & 0xffffffff,DAT_181d8c018);
              if (lVar4 == null) break;
              if (*(char *)(lVar4 + 80) == false) {
                if (plVar3 == (int64 *)0) {
                          // WARNING: Subroutine does not return
                  FUN_1800d6620();
                }
                HeroSpeAddData.ChangeMulti(plVar3,uVar1 & 0xffffffff,b,0);
              }
            }
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
        }
    }

    // Token : 0x600124A
    // RVA   : 0xAFC5E0   Offset: 0xAFB9E0   Length: 0x225
    public HeroSpeAddData Multi(float b)
    {
        ulong uVar1;
        bool cVar2;
        long lVar4;
        float fVar5;
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
        plVar3 = (int64 *)HeroSpeAddData.Clone(this,0);
        if ((this.heroSpeAddData != null) &&
           (lVar4 = Dictionary_2.get_Keys(this.heroSpeAddData,DAT_181dbe4b8)) != null) {
          FUN_180ecbf30(&local_30,lVar4,DAT_181dc36f0);
          local_48 = local_30;
          uStack_44 = uStack_2c;
          uStack_40 = uStack_28;
          uStack_3c = uStack_24;
          local_38 = local_20;
          while( true ) {
            cVar2 = FUN_1811c4f60(&local_48,DAT_181d9b258);
            uVar1 = local_38;
            if (!cVar2) {
              ZhSegment.Initialize(&local_48,DAT_181d9b1d8);
              return plVar3;
            }
            if (plVar3 == (int64 *)0) break;
            if (plVar3[2] == 0) {
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            cVar2 = FUN_1808ab490(plVar3[2],uVar1 & 0xffffffff,DAT_181dbde60);
            if (!cVar2) {
              fVar5 = 0.0;
            }
            else {
              if (plVar3[2] == 0) {
                          // WARNING: Subroutine does not return
                FUN_1800d6620();
              }
              fVar5 = (float)FUN_1817d9cd0(plVar3[2],uVar1 & 0xffffffff,DAT_181dbe430);
            }
            HeroSpeAddData.Set(plVar3,uVar1 & 0xffffffff,fVar5 * b,0);
          }
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
    }

    // Token : 0x600124B
    // RVA   : 0xAFD490   Offset: 0xAFC890   Length: 0x2CF
    public static HeroSpeAddData op_Subtraction(HeroSpeAddData a, HeroSpeAddData b)
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
          plVar3 = (int64 *)HeroSpeAddData.Clone(a,0);
          if (((b != null) && (*(int64 *)(b + 16) != 0)) &&
             (lVar4 = Dictionary_2.get_Keys(*(int64 *)(b + 16),DAT_181dbe4b8)) != null) {
            FUN_180ecbf30(&local_48,lVar4,DAT_181dc36f0);
            local_60 = local_48;
            uStack_5c = uStack_44;
            uStack_58 = uStack_40;
            uStack_54 = uStack_3c;
            local_50 = local_38;
            while( true ) {
              cVar2 = FUN_1811c4f60(&local_60,DAT_181d9b258);
              uVar1 = local_50;
              if (!cVar2) {
                ZhSegment.Initialize(&local_60,DAT_181d9b1d8);
                return plVar3;
              }
              if (*(int64 *)(b + 16) == 0) {
                          // WARNING: Subroutine does not return
                FUN_1800d6620();
              }
              cVar2 = FUN_1808ab490(*(int64 *)(b + 16),uVar1 & 0xffffffff,DAT_181dbde60);
              if (!cVar2) {
                fVar6 = 0.0;
              }
              else {
                if (*(int64 *)(b + 16) == 0) {
                          // WARNING: Subroutine does not return
                  FUN_1800d6620();
                }
                fVar6 = (float)FUN_1817d9cd0(*(int64 *)(b + 16),uVar1 & 0xffffffff,
                                             DAT_181dbe430);
              }
              if (plVar3 == (int64 *)0) break;
              if (plVar3[2] == 0) {
                          // WARNING: Subroutine does not return
                FUN_1800d6620();
              }
              cVar2 = FUN_1808ab490(plVar3[2],uVar1 & 0xffffffff,DAT_181dbde60);
              if (!cVar2) {
                fVar5 = 0.0;
              }
              else {
                if (plVar3[2] == 0) {
                          // WARNING: Subroutine does not return
                  FUN_1800d6620();
                }
                fVar5 = (float)FUN_1817d9cd0(plVar3[2],uVar1 & 0xffffffff,DAT_181dbe430);
              }
              HeroSpeAddData.Set(plVar3,uVar1 & 0xffffffff,-fVar6 + fVar5,0);
            }
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
        }
    }

    // Token : 0x600124C
    // RVA   : 0xAFC1A0   Offset: 0xAFB5A0   Length: 0x200
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
          lVar3 = Dictionary_2.get_Keys(this.heroSpeAddData,DAT_181dbe4b8);
          if (lVar3 != null) {
            FUN_180ecbf30(&local_48,lVar3,DAT_181dc36f0);
            local_60 = local_48;
            uStack_5c = uStack_44;
            uStack_58 = uStack_40;
            uStack_54 = uStack_3c;
            local_50 = local_38;
            while( true ) {
              cVar2 = FUN_1811c4f60(&local_60,DAT_181d9b258);
              uVar1 = local_50;
              if (!cVar2) {
                ZhSegment.Initialize(&local_60,DAT_181d9b1d8);
                return fVar5;
              }
              if (this.heroSpeAddData == null) {
                          // WARNING: Subroutine does not return
                FUN_1800d6620();
              }
              fVar4 = (float)FUN_1817d9cd0(this.heroSpeAddData,local_50 & 0xffffffff,
                                           DAT_181dbe430);
              lVar3 = FUN_18046c100(0);
              if (lVar3 == null) {
                          // WARNING: Subroutine does not return
                FUN_1800d6620();
              }
              if (*(int64 *)(lVar3 + 144) == 0) {
                          // WARNING: Subroutine does not return
                FUN_1800d6620();
              }
              lVar3 = FUN_180002f80(*(int64 *)(lVar3 + 144),uVar1 & 0xffffffff,DAT_181d8c018);
              if (lVar3 == null) break;
              fVar5 = fVar5 + fVar4 / *(float *)(lVar3 + 32);
            }
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
        }
    }

    // Token : 0x600124D
    // RVA   : 0xAFC070   Offset: 0xAFB470   Length: 0x121
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
        LAB_180afc18c:
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            cVar2 = FUN_1808ab490(lVar1,start,DAT_181dbde60);
            if (!cVar2) {
              return uVar4;
            }
            if (this.heroSpeAddData == null) goto LAB_180afc18c;
            fVar3 = (float)FUN_1817d9cd0(this.heroSpeAddData,start,DAT_181dbe430);
            if (fVar3 == 0.0) {
              return uVar4;
            }
            if (this.heroSpeAddData == null) goto LAB_180afc18c;
            uVar4 = FUN_1817d9cd0(this.heroSpeAddData,start,DAT_181dbe430);
          }
          else {
            if (lVar1 == null) goto LAB_180afc18c;
            cVar2 = FUN_1808ab490(lVar1,start,DAT_181dbde60);
            if (!cVar2) {
              return 0;
            }
            if (this.heroSpeAddData == null) goto LAB_180afc18c;
            fVar3 = (float)FUN_1817d9cd0(this.heroSpeAddData,start,DAT_181dbe430);
            if ((float)uVar4 != fVar3) {
              return 0;
            }
          }
          start = start + 1;
        } while( true );
    }

    // Token : 0x600124E
    // RVA   : 0xAFBFD0   Offset: 0xAFB3D0   Length: 0x36
    public string GetDescribe(bool useColor, bool newLine, int digits, bool merge)
    {
        var pStatics = *(int64*)(DAT_181d73d40 + 184);
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
            cVar3 = FUN_18171e540(local_e8,"",0);
            uVar5 = "{0}全属性{1}{2}";
            lVar6 = "";
            if ((!cVar3) && (lVar6 = " ", merge)) {
              lVar6 = "\n";
            }
            lVar9 = "";
            if (digits) {
              if (fVar13 <= 0.0) {
                lVar9 = *(int64 *)(pStatics + 0x2d0);
              }
              else {
                lVar9 = *(int64 *)(pStatics + 0x268);
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
            cVar3 = FUN_18171e540(local_e8,"",0);
            uVar5 = "{0}全武学{1}{2}";
            lVar6 = "";
            if ((!cVar3) && (lVar6 = " ", merge)) {
              lVar6 = "\n";
            }
            lVar9 = "";
            if (digits) {
              if (fVar12 <= 0.0) {
                lVar9 = *(int64 *)(pStatics + 0x2d0);
              }
              else {
                lVar9 = *(int64 *)(pStatics + 0x268);
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
            cVar3 = FUN_18171e540(local_e8,"",0);
            uVar5 = "{0}全技艺{1}{2}";
            lVar6 = "";
            if ((!cVar3) && (lVar6 = " ", merge)) {
              lVar6 = "\n";
            }
            lVar9 = "";
            if (digits) {
              if (fVar11 <= 0.0) {
                lVar9 = *(int64 *)(pStatics + 0x2d0);
              }
              else {
                lVar9 = *(int64 *)(pStatics + 0x268);
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
           (lVar6 = Dictionary_2.get_Keys(this.heroSpeAddData,DAT_181dbe4b8)) == null) {
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
        FUN_180ecbf30(&local_b8,lVar6,DAT_181dc36f0);
        local_d0 = local_b8;
        uStack_cc = uStack_b4;
        uStack_c8 = uStack_b0;
        uStack_c4 = uStack_ac;
        local_c0 = local_a8;
        while( true ) {
          do {
            do {
              cVar3 = FUN_1811c4f60(&local_d0,DAT_181d9b258);
              uVar2 = local_c0;
              if (!cVar3) {
                ZhSegment.Initialize(&local_d0,DAT_181d9b1d8);
                return local_e8;
              }
              iVar1 = (int)local_c0;
            } while (((int)local_c0 < useColor) || (newLine < (int)local_c0));
            if (this.heroSpeAddData == null) {
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            fVar10 = (float)FUN_1817d9cd0(this.heroSpeAddData,local_c0 & 0xffffffff,
                                          DAT_181dbe430);
          } while ((((fVar10 == 0.0) || (((fVar13 != 0.0 && (-1 < iVar1)) && (iVar1 < 6)))) ||
                   (((fVar12 != 0.0 && (5 < iVar1)) && (iVar1 < 15)))) ||
                  (((fVar11 != 0.0 && (23 < iVar1)) && (iVar1 < 33))));
          cVar3 = FUN_18171e540(local_e8,"",0);
          lVar6 = "";
          if ((!cVar3) && (lVar6 = " ", merge)) {
            lVar6 = "\n";
          }
          plVar7 = (int64 *)FUN_1800d60b0(DAT_181da4120,4);
          uVar5 = "{0}{1}{2}{3}";
          lVar9 = "";
          if (local_res20) {
            if (this.heroSpeAddData == null) {
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            fVar10 = (float)FUN_1817d9cd0(this.heroSpeAddData,uVar2 & 0xffffffff,DAT_181dbe430);
            if (fVar10 <= 0.0) {
              lVar9 = *(int64 *)(pStatics + 0x2d0);
            }
            else {
              lVar9 = *(int64 *)(pStatics + 0x268);
            }
          }
          if (plVar7 == (int64 *)0) {
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          if ((lVar9 != null) &&
             (lVar8 = il2cpp_internal(lVar9,*(uint64 *)(*plVar7 + 64))) == null) {
            uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar5,0);
          }
          FUN_180002fd0(plVar7,0,lVar9);
          lVar9 = FUN_18046c100(0);
          if (lVar9 == null) {
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          if (*(int64 *)(lVar9 + 144) == 0) {
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          lVar9 = FUN_180002f80(*(int64 *)(lVar9 + 144),uVar2 & 0xffffffff,DAT_181d8c018);
          if (lVar9 == null) {
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          lVar9 = *(int64 *)(lVar9 + 16);
          if ((lVar9 != null) &&
             (lVar8 = il2cpp_internal(lVar9,*(uint64 *)(*plVar7 + 64))) == null) {
            uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar5,0);
          }
          if (*(uint32 *)(plVar7 + 3) < 2) {
            uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar5,0);
          }
          plVar7[5] = lVar9;
          il2cpp_internal(plVar7 + 5,lVar9);
          lVar9 = FUN_18046c100(0);
          if (lVar9 == null) break;
          if (*(int64 *)(lVar9 + 144) == 0) {
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          lVar9 = FUN_180002f80(*(int64 *)(lVar9 + 144),uVar2 & 0xffffffff,DAT_181d8c018);
          if (lVar9 == null) {
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          lVar8 = this.heroSpeAddData;
          if (*(char *)(lVar9 + 56) == false) {
            if (lVar8 == null) {
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            fVar10 = (float)FUN_1817d9cd0(lVar8,uVar2 & 0xffffffff,DAT_181dbe430);
            local_res8 = Math.Round(SUB84((double)fVar10,0),param_6,0);
            lVar9 = Double.ToString(&local_res8,"+0.##;-0.##;0",0);
          }
          else {
            if (lVar8 == null) {
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            fVar10 = (float)FUN_1817d9cd0(lVar8,uVar2 & 0xffffffff,DAT_181dbe430);
            local_res8 = Math.Round(SUB84((double)(fVar10 * 100.0),0),param_6,0);
            uVar4 = Double.ToString(&local_res8,"+0.##;-0.##;0",0);
            lVar9 = String.Concat(uVar4,"%",0);
          }
          if ((lVar9 != null) &&
             (lVar8 = il2cpp_internal(lVar9,*(uint64 *)(*plVar7 + 64))) == null) {
            uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar5,0);
          }
          FUN_180002fd0(plVar7,2,lVar9);
          lVar9 = "";
          if (local_res20) {
            lVar9 = "</color>";
          }
          if ((lVar9 != null) &&
             (lVar8 = il2cpp_internal(lVar9,*(uint64 *)(*plVar7 + 64))) == null) {
            uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar5,0);
          }
          FUN_180002fd0(plVar7,3,lVar9);
          uVar5 = String.Format(uVar5,plVar7,0);
          local_e8 = String.Concat(local_e8,lVar6,uVar5,0);
          newLine = local_res18;
          useColor = local_res10;
        }
    }

    // Token : 0x600124F
    // RVA   : 0xAFB480   Offset: 0xAFA880   Length: 0xB4B
    public string GetDescribe(int startID, int endID, bool useColor, bool newLine, int digits, bool merge)
    {
        var pStatics = *(int64*)(DAT_181d73d40 + 184);
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
            cVar3 = FUN_18171e540(local_e8,"",0);
            uVar5 = "{0}全属性{1}{2}";
            lVar6 = "";
            if ((!cVar3) && (lVar6 = " ", newLine)) {
              lVar6 = "\n";
            }
            lVar9 = "";
            if (useColor) {
              if (fVar13 <= 0.0) {
                lVar9 = *(int64 *)(pStatics + 0x2d0);
              }
              else {
                lVar9 = *(int64 *)(pStatics + 0x268);
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
            cVar3 = FUN_18171e540(local_e8,"",0);
            uVar5 = "{0}全武学{1}{2}";
            lVar6 = "";
            if ((!cVar3) && (lVar6 = " ", newLine)) {
              lVar6 = "\n";
            }
            lVar9 = "";
            if (useColor) {
              if (fVar12 <= 0.0) {
                lVar9 = *(int64 *)(pStatics + 0x2d0);
              }
              else {
                lVar9 = *(int64 *)(pStatics + 0x268);
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
            cVar3 = FUN_18171e540(local_e8,"",0);
            uVar5 = "{0}全技艺{1}{2}";
            lVar6 = "";
            if ((!cVar3) && (lVar6 = " ", newLine)) {
              lVar6 = "\n";
            }
            lVar9 = "";
            if (useColor) {
              if (fVar11 <= 0.0) {
                lVar9 = *(int64 *)(pStatics + 0x2d0);
              }
              else {
                lVar9 = *(int64 *)(pStatics + 0x268);
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
           (lVar6 = Dictionary_2.get_Keys(this.heroSpeAddData,DAT_181dbe4b8)) == null) {
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
        FUN_180ecbf30(&local_b8,lVar6,DAT_181dc36f0);
        local_d0 = local_b8;
        uStack_cc = uStack_b4;
        uStack_c8 = uStack_b0;
        uStack_c4 = uStack_ac;
        local_c0 = local_a8;
        while( true ) {
          do {
            do {
              cVar3 = FUN_1811c4f60(&local_d0,DAT_181d9b258);
              uVar2 = local_c0;
              if (!cVar3) {
                ZhSegment.Initialize(&local_d0,DAT_181d9b1d8);
                return local_e8;
              }
              iVar1 = (int)local_c0;
            } while (((int)local_c0 < startID) || (endID < (int)local_c0));
            if (this.heroSpeAddData == null) {
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            fVar10 = (float)FUN_1817d9cd0(this.heroSpeAddData,local_c0 & 0xffffffff,
                                          DAT_181dbe430);
          } while ((((fVar10 == 0.0) || (((fVar13 != 0.0 && (-1 < iVar1)) && (iVar1 < 6)))) ||
                   (((fVar12 != 0.0 && (5 < iVar1)) && (iVar1 < 15)))) ||
                  (((fVar11 != 0.0 && (23 < iVar1)) && (iVar1 < 33))));
          cVar3 = FUN_18171e540(local_e8,"",0);
          lVar6 = "";
          if ((!cVar3) && (lVar6 = " ", newLine)) {
            lVar6 = "\n";
          }
          plVar7 = (int64 *)FUN_1800d60b0(DAT_181da4120,4);
          uVar5 = "{0}{1}{2}{3}";
          lVar9 = "";
          if (local_res20) {
            if (this.heroSpeAddData == null) {
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            fVar10 = (float)FUN_1817d9cd0(this.heroSpeAddData,uVar2 & 0xffffffff,DAT_181dbe430);
            if (fVar10 <= 0.0) {
              lVar9 = *(int64 *)(pStatics + 0x2d0);
            }
            else {
              lVar9 = *(int64 *)(pStatics + 0x268);
            }
          }
          if (plVar7 == (int64 *)0) {
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          if ((lVar9 != null) &&
             (lVar8 = il2cpp_internal(lVar9,*(uint64 *)(*plVar7 + 64))) == null) {
            uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar5,0);
          }
          FUN_180002fd0(plVar7,0,lVar9);
          lVar9 = FUN_18046c100(0);
          if (lVar9 == null) {
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          if (*(int64 *)(lVar9 + 144) == 0) {
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          lVar9 = FUN_180002f80(*(int64 *)(lVar9 + 144),uVar2 & 0xffffffff,DAT_181d8c018);
          if (lVar9 == null) {
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          lVar9 = *(int64 *)(lVar9 + 16);
          if ((lVar9 != null) &&
             (lVar8 = il2cpp_internal(lVar9,*(uint64 *)(*plVar7 + 64))) == null) {
            uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar5,0);
          }
          if (*(uint32 *)(plVar7 + 3) < 2) {
            uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar5,0);
          }
          plVar7[5] = lVar9;
          il2cpp_internal(plVar7 + 5,lVar9);
          lVar9 = FUN_18046c100(0);
          if (lVar9 == null) break;
          if (*(int64 *)(lVar9 + 144) == 0) {
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          lVar9 = FUN_180002f80(*(int64 *)(lVar9 + 144),uVar2 & 0xffffffff,DAT_181d8c018);
          if (lVar9 == null) {
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          lVar8 = this.heroSpeAddData;
          if (*(char *)(lVar9 + 56) == false) {
            if (lVar8 == null) {
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            fVar10 = (float)FUN_1817d9cd0(lVar8,uVar2 & 0xffffffff,DAT_181dbe430);
            local_res8 = Math.Round(SUB84((double)fVar10,0),digits,0);
            lVar9 = Double.ToString(&local_res8,"+0.##;-0.##;0",0);
          }
          else {
            if (lVar8 == null) {
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            fVar10 = (float)FUN_1817d9cd0(lVar8,uVar2 & 0xffffffff,DAT_181dbe430);
            local_res8 = Math.Round(SUB84((double)(fVar10 * 100.0),0),digits,0);
            uVar4 = Double.ToString(&local_res8,"+0.##;-0.##;0",0);
            lVar9 = String.Concat(uVar4,"%",0);
          }
          if ((lVar9 != null) &&
             (lVar8 = il2cpp_internal(lVar9,*(uint64 *)(*plVar7 + 64))) == null) {
            uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar5,0);
          }
          FUN_180002fd0(plVar7,2,lVar9);
          lVar9 = "";
          if (local_res20) {
            lVar9 = "</color>";
          }
          if ((lVar9 != null) &&
             (lVar8 = il2cpp_internal(lVar9,*(uint64 *)(*plVar7 + 64))) == null) {
            uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar5,0);
          }
          FUN_180002fd0(plVar7,3,lVar9);
          uVar5 = String.Format(uVar5,plVar7,0);
          local_e8 = String.Concat(local_e8,lVar6,uVar5,0);
          endID = local_res18;
          startID = local_res10;
        }
    }

    // Token : 0x6001250
    // RVA   : 0xAFC450   Offset: 0xAFB850   Length: 0x181
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
        while ((lVar3 != null && (lVar3 = Dictionary_2.get_Keys(lVar3,DAT_181dbe4b8)) != null)) {
          iVar1 = FUN_180cd6140(lVar3,DAT_181dc3998);
          if (iVar1 <= iVar5) {
            return;
          }
          lVar3 = this.heroSpeAddData;
          if (lVar3 == null) break;
          uVar4 = Dictionary_2.get_Keys(lVar3,DAT_181dbe4b8);
          uVar2 = FUN_18096eb40(uVar4,iVar5,DAT_181db2e90);
          fVar7 = (float)FUN_1817d9cd0(lVar3,uVar2,DAT_181dbe430);
          if ((fVar7 != 0.0) && (iVar6 = iVar6 + 1, maxNum + 1 <= iVar6)) {
            lVar3 = this.heroSpeAddData;
            if (lVar3 == null) break;
            uVar4 = Dictionary_2.get_Keys(lVar3,DAT_181dbe4b8);
            uVar2 = FUN_18096eb40(uVar4,iVar5,DAT_181db2e90);
            FUN_18145de50(lVar3,uVar2,DAT_181dbe188);
            iVar5 = iVar5 + -1;
          }
          lVar3 = this.heroSpeAddData;
          iVar5 = iVar5 + 1;
        }
    }

    // Token : 0x6001251
    // RVA   : 0xAFB300   Offset: 0xAFA700   Length: 0x175
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
        plVar1 = (int64 *)il2cpp_internal(DAT_181d89210);
        plVar4 = plVar1;
        MemoryStream.ctor(plVar1,1000,0);
        local_38 = 0;
        uStack_30 = 0;
        StreamingContext.ctor(&local_38,64,0);
        lVar2 = il2cpp_internal(DAT_181db1730);
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
            FUN_180002970(0,DAT_181d78da0,plVar1);
            return uVar3;
          }
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
    }

}
