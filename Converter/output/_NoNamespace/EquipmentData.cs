// ============================================================
// Type  : EquipmentData
// Token : 0x2000242
// ============================================================

public class EquipmentData
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001219
    public int enhanceLv;

    // Token: 0x400121A
    public int littleType;

    // Token: 0x400121B
    public int attriType;

    // Token: 0x400121C
    public HeroSpeAddData baseAddData;

    // Token: 0x400121D
    public HeroSpeAddData extraAddData;

    // Token: 0x400121E
    public bool equiped;

    // Token: 0x400121F
    public string animName;

    // Token: 0x4001220
    public EquipPoisonData equipPoisonData;

    // Token: 0x4001221
    public int speEnhanceLv;

    // Token: 0x4001222
    public int speWeightLv;

    // Token: 0x4001223
    private const float SecondAffixMinPoint;

    // Token: 0x4001224
    private const float SecondAffixMinPointTwoEffect;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6001305
    // RVA   : 0x68B2E0   Offset: 0x68A0E0   Length: 0x24
    public HeroSpeAddData GetBaseAddData()
    {
        HeroSpeAddData.op_Multiply
                  (this.baseAddData,(float)this.enhanceLv * 0.1 + 1.0,0);
    }

    // Token : 0x6001306
    // RVA   : 0x68B310   Offset: 0x68A110   Length: 0x470
    public string GetExtraAddName()
    {
        ulong uVar1;
        ulong uVar2;
        float fVar3;
        bool cVar4;
        ulong uVar5;
        ulong uVar6;
        long lVar7;
        ulong uVar8;
        int iVar9;
        ulong uVar10;
        int iVar11;
        float fVar12;
        float fVar13;
        float fVar14;
        float fVar15;
        ulong uVar16;
        ulong uVar17;
        float fStack_fc;
        uint64 local_f0;
        uint64 uStack_e8;
        uint64 local_e0;
        uint64 uStack_d8;
        uint64 local_d0;
        uint64 uStack_c8;
        uint64 local_c0;
        uint64 uStack_b8;
        uVar6 = "";
        uVar8 = "";
        if ((this.extraAddData != null) &&
           (lVar7 = this.extraAddData.heroSpeAddData) != null) {
          iVar11 = 0;
          uVar16 = "";
          FUN_18125c400(&local_d0,lVar7,DAT_181e9f778);
          local_f0 = local_d0;
          uStack_e8 = uStack_c8;
          local_e0 = local_c0;
          uStack_d8 = uStack_b8;
          uVar2 = uVar6;
          fVar12 = 0.0;
          fVar3 = 0.0;
          while (fVar15 = fVar3, fVar13 = fVar12, uVar8 = uVar2, uVar10 = uVar6,
                cVar4 = FUN_180dd5b00(&local_f0,DAT_181e7cd30), uVar1 = local_e0, cVar4) {
            fStack_fc = (float)(local_e0 >> 32);
            uVar6 = uVar10;
            uVar2 = uVar8;
            fVar12 = fVar13;
            fVar3 = fVar15;
            if (fStack_fc != 0.0) {
              iVar11 = iVar11 + 1;
              iVar9 = (int)local_e0;
              uVar5 = EquipmentData.GetAffixName(this,local_e0 & 0xffffffff,fStack_fc,0,uVar16);
              cVar4 = FUN_180ad1200(uVar5,0);
              if (!cVar4) {
                fVar14 = 1.0;
                uVar17 = uVar16;
                if (((*(byte *)(DAT_181e528f8 + 0x133) & 4) != 0) && (*(int *)(DAT_181e528f8 + 224) == 0)
                   ) {
                  il2cpp_runtime_class_init();
                  uVar17 = uVar16;
                }
                uVar6 = FUN_180210740(0);
                cVar4 = Object.op_Inequality(uVar6,0);
                if (cVar4) {
                  lVar7 = FUN_180210740(0);
                  if (lVar7 == null) {
                          // WARNING: Subroutine does not return
                    FUN_1801e0300();
                  }
                  if ((*(int64 *)(lVar7 + 144) != 0) && (-1 < iVar9)) {
                    lVar7 = FUN_180210740(0);
                    if (lVar7 == null) {
                          // WARNING: Subroutine does not return
                      FUN_1801e0300();
                    }
                    if (*(int64 *)(lVar7 + 144) == 0) {
                          // WARNING: Subroutine does not return
                      FUN_1801e0300();
                    }
                    if (iVar9 < *(int *)(*(int64 *)(lVar7 + 144) + 24)) {
                      lVar7 = FUN_180210740(0);
                      if (lVar7 == null) {
                          // WARNING: Subroutine does not return
                        FUN_1801e0300();
                      }
                      if (*(int64 *)(lVar7 + 144) == 0) {
                          // WARNING: Subroutine does not return
                        FUN_1801e0300();
                      }
                      lVar7 = FUN_1800024b0(*(int64 *)(lVar7 + 144),uVar1 & 0xffffffff);
                      if ((lVar7 != null) && (0.0 < *(float *)(lVar7 + 32))) {
                        fVar14 = *(float *)(lVar7 + 32);
                      }
                    }
                  }
                }
                fVar14 = ABS(fStack_fc) / fVar14;
                uVar6 = uVar8;
                uVar2 = uVar5;
                fVar12 = fVar15;
                fVar3 = fVar14;
                uVar16 = uVar5;
                if ((fVar14 <= fVar15) &&
                   (uVar6 = uVar10, uVar2 = uVar8, fVar12 = fVar13, fVar3 = fVar15, uVar16 = uVar17,
                   fVar13 < fVar14)) {
                  uVar6 = uVar5;
                  fVar12 = fVar14;
                }
              }
            }
          }
          ZhSegment.Initialize(&local_f0,DAT_181e7ccb0);
          if ((1 < iVar11) && (cVar4 = FUN_180ad1200(uVar10,0), !cVar4)) {
            if (iVar11 < 3) {
              fVar12 = 5.0;
            }
            else {
              fVar12 = 3.0;
            }
            iVar11 = Mathf.RoundToInt();
            if (fVar12 <= (float)iVar11) {
              uVar8 = String.Concat(uVar8,uVar10,0);
            }
          }
        }
        return uVar8;
    }

    // Token : 0x6001307
    // RVA   : 0x68B040   Offset: 0x689E40   Length: 0x294
    private string GetAffixName(int key, float value)
    {
        bool cVar1;
        long lVar2;
        ulong uVar3;
        uVar3 = GameController.ChangeAllAreaStateIDs;
        cVar1 = Object.op_Equality(uVar3,0,0);
        if (!cVar1) {
          lVar2 = GameController.ChangeAllAreaStateIDs;
          if (lVar2 == null) {
        LAB_18068b2cf:
                          // WARNING: Subroutine does not return
            FUN_1801e0300();
          }
          if ((*(int64 *)(lVar2 + 144) != 0) && (-1 < key)) {
            lVar2 = FUN_180210740(0);
            if ((lVar2 == null) || (*(int64 *)(lVar2 + 144) == 0)) goto LAB_18068b2cf;
            if (key < *(int *)(*(int64 *)(lVar2 + 144) + 24)) {
              lVar2 = FUN_180210740(0);
              if ((lVar2 == null) || (*(int64 *)(lVar2 + 144) == 0)) goto LAB_18068b2cf;
              lVar2 = FUN_1800024b0(*(int64 *)(lVar2 + 144),key,DAT_181e6e1f0);
              if (lVar2 != null) {
                if (value <= 0.0) {
                  uVar3 = *(uint64 *)(lVar2 + 48);
                }
                else {
                  uVar3 = *(uint64 *)(lVar2 + 40);
                }
                cVar1 = FUN_180ad1200(uVar3,0);
                if (!cVar1) {
                  cVar1 = FUN_1816387f0(uVar3,"无",0);
                  if (!cVar1) {
                    return uVar3;
                  }
                }
              }
            }
          }
        }
        return "";
    }

    // Token : 0x6001308
    // RVA   : 0x68B790   Offset: 0x68A590   Length: 0x10F
    public void /*ctor*/()
    {
        ulong uVar1;
        long lVar2;
        ZhSegment.Initialize(this,0);
        this.baseAddData = new HeroSpeAddData(0);
        this.extraAddData = new HeroSpeAddData(0);
        lVar2 = new ZhSegment(0);
        uVar1 = new HeroSpeAddData(0);
        *(uint64 *)(lVar2 + 24) = uVar1;
        this.equipPoisonData = lVar2;
    }

    // Token : 0x6001309
    // RVA   : 0x68AC50   Offset: 0x689A50   Length: 0x3E4
    public virtual object Clone()
    {
        long lVar1;
        ulong uVar2;
        long lVar3;
        long lVar5;
        lVar1 = new ZhSegment(0);
        uVar2 = new HeroSpeAddData(0);
        *(uint64 *)(lVar1 + 32) = uVar2;
        uVar2 = new HeroSpeAddData(0);
        *(uint64 *)(lVar1 + 40) = uVar2;
        lVar3 = new ZhSegment(0);
        uVar2 = new HeroSpeAddData(0);
        lVar3.poisonBuffData = uVar2;
        *(int64 *)(lVar1 + 64) = lVar3;
        *(uint32 *)(lVar1 + 16) = this.enhanceLv;
        *(uint32 *)(lVar1 + 20) = this.littleType;
        *(uint32 *)(lVar1 + 24) = this.attriType;
        *(uint8 *)(lVar1 + 48) = this.equiped;
        *(uint64 *)(lVar1 + 56) = this.animName;
        *(uint32 *)(lVar1 + 72) = this.speEnhanceLv;
        *(uint32 *)(lVar1 + 76) = this.speWeightLv;
        if (this.baseAddData == null) {
          plVar4 = (int64 *)0;
        }
        else {
          plVar4 = (int64 *)HeroSpeAddData.Clone(this.baseAddData,0);
        }
        plVar7 = (int64 *)0;
        *(int64 **)(lVar1 + 32) = plVar4;
        plVar4 = plVar7;
        if ((this.extraAddData != null) &&
           (plVar6 = (int64 *)HeroSpeAddData.Clone(this.extraAddData,0),
           plVar6 != (int64 *)0)) {
        }
        *(int64 **)(lVar1 + 40) = plVar4;
        lVar3 = this.equipPoisonData;
        plVar4 = plVar7;
        if (lVar3 != null) {
          plVar4 = (int64 *)il2cpp_internal(DAT_181ea4600);
          ZhSegment.Initialize(plVar4,0);
          lVar5 = new HeroSpeAddData(0);
          plVar4[3] = lVar5;
          il2cpp_internal(plVar4 + 3,lVar5);
          *(uint32 *)(plVar4 + 2) = lVar3.poisonNum;
          if ((lVar3.poisonBuffData != null) &&
             (plVar6 = (int64 *)HeroSpeAddData.Clone(lVar3.poisonBuffData,0),
             plVar6 != (int64 *)0)) {
          }
          plVar4[3] = (int64)plVar7;
          il2cpp_internal(plVar4 + 3);
          if (((*(byte *)(*plVar4 + 300) < *(byte *)(DAT_181ea4600 + 300)) ||
              (*(int64 *)
                (*(int64 *)(*plVar4 + 200) + -8 + (uint64)*(byte *)(DAT_181ea4600 + 300) * 8) !=
               DAT_181ea4600)) || (plVar4 == (int64 *)0)) {
                          // WARNING: Subroutine does not return
            FUN_1801dfd50(plVar4);
          }
        }
        *(int64 **)(lVar1 + 64) = plVar4;
        return lVar1;
    }

}
