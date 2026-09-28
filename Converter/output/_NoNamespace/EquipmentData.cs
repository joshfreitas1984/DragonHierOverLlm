// ============================================================
// Type  : EquipmentData
// Token : 0x200023E
// ============================================================

public class EquipmentData
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x40011FD
    public int enhanceLv;

    // Token: 0x40011FE
    public int littleType;

    // Token: 0x40011FF
    public int attriType;

    // Token: 0x4001200
    public HeroSpeAddData baseAddData;

    // Token: 0x4001201
    public HeroSpeAddData extraAddData;

    // Token: 0x4001202
    public bool equiped;

    // Token: 0x4001203
    public string animName;

    // Token: 0x4001204
    public EquipPoisonData equipPoisonData;

    // Token: 0x4001205
    public int speEnhanceLv;

    // Token: 0x4001206
    public int speWeightLv;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60012E8
    // RVA   : 0x944EE0   Offset: 0x9442E0   Length: 0x24
    public HeroSpeAddData GetBaseAddData()
    {
        HeroSpeAddData.op_Multiply
                  (this.baseAddData,(float)this.enhanceLv * 0.1 + 1.0,0);
    }

    // Token : 0x60012E9
    // RVA   : 0x944F10   Offset: 0x944310   Length: 0x2ED
    public string GetExtraAddName()
    {
        ulong uVar1;
        bool cVar2;
        long lVar3;
        ulong uVar4;
        ulong uVar5;
        int iVar6;
        float fVar7;
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
        uVar4 = "";
        iVar6 = 0;
        if (((this.extraAddData == null) ||
            (lVar3 = this.extraAddData.heroSpeAddData) == null) ||
           (lVar3 = Dictionary_2.get_Keys(lVar3,DAT_181dbe4b8)) == null) {
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
        FUN_180ecbf30(&local_48,lVar3,DAT_181dc36f0);
        local_60 = local_48;
        uStack_5c = uStack_44;
        uStack_58 = uStack_40;
        uStack_54 = uStack_3c;
        local_50 = local_38;
        while( true ) {
          do {
            cVar2 = FUN_1811c4f60(&local_60,DAT_181d9b258);
            uVar1 = local_50;
            if (!cVar2) {
              ZhSegment.Initialize(&local_60,DAT_181d9b1d8);
              return uVar4;
            }
            if (this.extraAddData == null) {
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            lVar3 = this.extraAddData.heroSpeAddData;
            if (lVar3 == null) {
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            fVar7 = (float)FUN_1817d9cd0(lVar3,local_50 & 0xffffffff,DAT_181dbe430);
          } while (fVar7 == 0.0);
          if (this.extraAddData == null) {
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          lVar3 = this.extraAddData.heroSpeAddData;
          if (lVar3 == null) break;
          fVar7 = (float)FUN_1817d9cd0(lVar3,uVar1 & 0xffffffff,DAT_181dbe430);
          if (fVar7 <= 0.0) {
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
            if (lVar3 == null) {
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            uVar5 = *(uint64 *)(lVar3 + 48);
          }
          else {
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
            if (lVar3 == null) {
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            uVar5 = *(uint64 *)(lVar3 + 40);
          }
          uVar4 = String.Concat(uVar4,uVar5,0);
          iVar6 = iVar6 + 1;
          if (1 < iVar6) {
            ZhSegment.Initialize(&local_60,DAT_181d9b1d8);
            return uVar4;
          }
        }
    }

    // Token : 0x60012EA
    // RVA   : 0x945200   Offset: 0x944600   Length: 0x10F
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

}
