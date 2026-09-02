// ============================================================
// Type  : EquipmentData
// Token : 0x2000238
// ============================================================

public class EquipmentData
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x400115A
    public int enhanceLv;

    // Token: 0x400115B
    public int littleType;

    // Token: 0x400115C
    public int attriType;

    // Token: 0x400115D
    public HeroSpeAddData baseAddData;

    // Token: 0x400115E
    public HeroSpeAddData extraAddData;

    // Token: 0x400115F
    public bool equiped;

    // Token: 0x4001160
    public string animName;

    // Token: 0x4001161
    public EquipPoisonData equipPoisonData;

    // Token: 0x4001162
    public int speEnhanceLv;

    // Token: 0x4001163
    public int speWeightLv;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60012A7
    // RVA   : 0x935460   Offset: 0x933C60   Length: 0x24
    public HeroSpeAddData GetBaseAddData()
    {
        HeroSpeAddData.op_Multiply
                  (this.baseAddData,(float)this.enhanceLv * 0.1 + 1.0,0);
    }

    // Token : 0x60012A8
    // RVA   : 0x935490   Offset: 0x933C90   Length: 0x2ED
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
           (lVar3 = Dictionary_2.get_Keys(lVar3,DAT_181d98b10)) == null) {
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
        FUN_180ed4d30(&local_48,lVar3,DAT_181d9c570);
        local_60 = local_48;
        uStack_5c = uStack_44;
        uStack_58 = uStack_40;
        uStack_54 = uStack_3c;
        local_50 = local_38;
        while( true ) {
          do {
            cVar2 = FUN_1811d8280(&local_60,DAT_181d74c38);
            uVar1 = local_50;
            if (!cVar2) {
              ZhSegment.Initialize(&local_60,DAT_181d74bb8);
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
            fVar7 = (float)FUN_1817cc640(lVar3,local_50 & 0xffffffff,DAT_181d98a88);
          } while (fVar7 == 0.0);
          if (this.extraAddData == null) {
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          lVar3 = this.extraAddData.heroSpeAddData;
          if (lVar3 == null) break;
          fVar7 = (float)FUN_1817cc640(lVar3,uVar1 & 0xffffffff,DAT_181d98a88);
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
            lVar3 = FUN_180002f80(*(int64 *)(lVar3 + 144),uVar1 & 0xffffffff,DAT_181d64878);
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
            lVar3 = FUN_180002f80(*(int64 *)(lVar3 + 144),uVar1 & 0xffffffff,DAT_181d64878);
            if (lVar3 == null) {
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            uVar5 = *(uint64 *)(lVar3 + 40);
          }
          uVar4 = String.Concat(uVar4,uVar5,0);
          iVar6 = iVar6 + 1;
          if (1 < iVar6) {
            ZhSegment.Initialize(&local_60,DAT_181d74bb8);
            return uVar4;
          }
        }
    }

    // Token : 0x60012A9
    // RVA   : 0x935780   Offset: 0x933F80   Length: 0x10F
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
