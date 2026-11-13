// ============================================================
// Type  : ChangeHeroStateData
// Token : 0x200023C
// ============================================================

public class ChangeHeroStateData
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x40011E8
    public float hp;

    // Token: 0x40011E9
    public float maxhp;

    // Token: 0x40011EA
    public float mana;

    // Token: 0x40011EB
    public float maxMana;

    // Token: 0x40011EC
    public float power;

    // Token: 0x40011ED
    public float maxPower;

    // Token: 0x40011EE
    public float externalInjury;

    // Token: 0x40011EF
    public float internalInjury;

    // Token: 0x40011F0
    public float poisonInjury;

    // Token: 0x40011F1
    public List<int> changeAttri;

    // Token: 0x40011F2
    public float charm;

    // Token: 0x40011F3
    public HeroSpeAddData buffData;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60012D0
    // RVA   : 0x6F23C0   Offset: 0x6F11C0   Length: 0xC3
    public static ChangeHeroStateData op_Multiply(ChangeHeroStateData a, float b)
    {
        if (a != null) {
          plVar1 = (int64 *)ChangeHeroStateData.Clone(a,0);
          if (plVar1 != (int64 *)0) {
            if ((*(byte *)(DAT_181e96ee0 + 300) <= *(byte *)(*plVar1 + 300)) &&
               (*(int64 *)
                 (*(int64 *)(*plVar1 + 200) + -8 + (uint64)*(byte *)(DAT_181e96ee0 + 300) * 8) ==
                DAT_181e96ee0)) {
              *(float *)(plVar1 + 2) = *(float *)(plVar1 + 2) * b;
              *(float *)((int64)plVar1 + 20) = *(float *)((int64)plVar1 + 20) * b;
              *(float *)(plVar1 + 3) = *(float *)(plVar1 + 3) * b;
              *(float *)((int64)plVar1 + 28) = *(float *)((int64)plVar1 + 28) * b;
              *(float *)(plVar1 + 4) = *(float *)(plVar1 + 4) * b;
              *(float *)((int64)plVar1 + 36) = *(float *)((int64)plVar1 + 36) * b;
              *(float *)(plVar1 + 5) = *(float *)(plVar1 + 5) * b;
              *(float *)((int64)plVar1 + 44) = *(float *)((int64)plVar1 + 44) * b;
              *(float *)(plVar1 + 6) = b * *(float *)(plVar1 + 6);
              *(float *)(plVar1 + 8) = b * *(float *)(plVar1 + 8);
              return plVar1;
            }
                          // WARNING: Subroutine does not return
            FUN_1801dfd50(plVar1,DAT_181e96ee0);
          }
        }
    }

    // Token : 0x60012D1
    // RVA   : 0x6F2310   Offset: 0x6F1110   Length: 0xAA
    public void /*ctor*/()
    {
        ulong uVar1;
        ZhSegment.Initialize(this,0);
        uVar1 = il2cpp_internal(DAT_181e73cb8);
        FUN_1810f3480(uVar1,DAT_181e71270);
        this.changeAttri = uVar1;
        this.buffData = new HeroSpeAddData(0);
    }

    // Token : 0x60012D2
    // RVA   : 0x6F22F0   Offset: 0x6F10F0   Length: 0xE
    public float GetMaxChangeMaxHp()
    {
        return this.maxhp * 10.0;
    }

    // Token : 0x60012D3
    // RVA   : 0x6F2300   Offset: 0x6F1100   Length: 0xE
    public float GetMaxChangeMaxMp()
    {
        return this.maxMana * 10.0;
    }

    // Token : 0x60012D4
    // RVA   : 0x6F1EC0   Offset: 0x6F0CC0   Length: 0x427
    public string GetDescribe()
    {
        bool cVar1;
        ulong uVar2;
        ulong uVar3;
        ulong uVar4;
        uVar3 = "";
        if (this.hp != null.0) {
          uVar2 = Single.ToString(this + 16,"+0;-0;0",0);
          uVar3 = String.Concat(uVar3,"生命",uVar2,0);
        }
        if (this.maxhp != null.0) {
          cVar1 = FUN_1816387f0(uVar3,"",0);
          uVar2 = "\n";
          if (cVar1) {
            uVar2 = "";
          }
          uVar4 = Single.ToString(this + 20,"+0;-0;0",0);
          uVar3 = String.Concat(uVar3,uVar2,"生命上限",uVar4,0);
        }
        if (this.mana != null.0) {
          cVar1 = FUN_1816387f0(uVar3,"",0);
          uVar2 = "\n";
          if (cVar1) {
            uVar2 = "";
          }
          uVar4 = Single.ToString(this + 24,"+0;-0;0",0);
          uVar3 = String.Concat(uVar3,uVar2,"内力",uVar4,0);
        }
        if (this.maxMana != null.0) {
          cVar1 = FUN_1816387f0(uVar3,"",0);
          uVar2 = "\n";
          if (cVar1) {
            uVar2 = "";
          }
          uVar4 = Single.ToString(this + 28,"+0;-0;0",0);
          uVar3 = String.Concat(uVar3,uVar2,"内力上限",uVar4,0);
        }
        if (this.power != null.0) {
          cVar1 = FUN_1816387f0(uVar3,"",0);
          uVar2 = "\n";
          if (cVar1) {
            uVar2 = "";
          }
          uVar4 = Single.ToString(this + 32,"+0;-0;0",0);
          uVar3 = String.Concat(uVar3,uVar2,"体力",uVar4,0);
        }
        if (this.maxPower != null.0) {
          cVar1 = FUN_1816387f0(uVar3,"",0);
          uVar2 = "\n";
          if (cVar1) {
            uVar2 = "";
          }
          uVar4 = Single.ToString(this + 36,"+0;-0;0",0);
          uVar3 = String.Concat(uVar3,uVar2,"体力上限",uVar4,0);
        }
        if (this.externalInjury != null.0) {
          cVar1 = FUN_1816387f0(uVar3,"",0);
          uVar2 = "\n";
          if (cVar1) {
            uVar2 = "";
          }
          uVar4 = Single.ToString(this + 40,"+0;-0;0",0);
          uVar3 = String.Concat(uVar3,uVar2,"外伤",uVar4,0);
        }
        if (this.internalInjury != null.0) {
          cVar1 = FUN_1816387f0(uVar3,"",0);
          uVar2 = "\n";
          if (cVar1) {
            uVar2 = "";
          }
          uVar4 = Single.ToString(this + 44,"+0;-0;0",0);
          uVar3 = String.Concat(uVar3,uVar2,"内伤",uVar4,0);
        }
        if (this.poisonInjury != null.0) {
          cVar1 = FUN_1816387f0(uVar3,"",0);
          uVar2 = "\n";
          if (cVar1) {
            uVar2 = "";
          }
          uVar4 = Single.ToString(this + 48,"+0;-0;0",0);
          uVar3 = String.Concat(uVar3,uVar2,"中毒",uVar4,0);
        }
        return uVar3;
    }

    // Token : 0x60012D5
    // RVA   : 0x6F1CC0   Offset: 0x6F0AC0   Length: 0x1FC
    public virtual object Clone()
    {
        long lVar1;
        long lVar2;
        ulong uVar3;
        lVar2 = new ZhSegment(0);
        uVar3 = il2cpp_internal(DAT_181e73cb8);
        FUN_1810f3480(uVar3,DAT_181e71270);
        *(uint64 *)(lVar2 + 56) = uVar3;
        uVar3 = new HeroSpeAddData(0);
        *(uint64 *)(lVar2 + 72) = uVar3;
        plVar5 = (int64 *)0;
        *(uint32 *)(lVar2 + 16) = this.hp;
        *(uint32 *)(lVar2 + 20) = this.maxhp;
        *(uint32 *)(lVar2 + 24) = this.mana;
        *(uint32 *)(lVar2 + 28) = this.maxMana;
        *(uint32 *)(lVar2 + 32) = this.power;
        *(uint32 *)(lVar2 + 36) = this.maxPower;
        *(uint32 *)(lVar2 + 40) = this.externalInjury;
        *(uint32 *)(lVar2 + 44) = this.internalInjury;
        *(uint32 *)(lVar2 + 48) = this.poisonInjury;
        *(uint32 *)(lVar2 + 64) = this.charm;
        lVar1 = this.changeAttri;
        plVar4 = plVar5;
        if (lVar1 != null) {
          plVar4 = (int64 *)il2cpp_internal(DAT_181e73cb8);
          FUN_18177a7d0(plVar4,lVar1,DAT_181e712f0);
        }
        *(int64 **)(lVar2 + 56) = plVar4;
        if ((this.buffData != null) &&
           (plVar4 = (int64 *)HeroSpeAddData.Clone(this.buffData,0),
           plVar4 != (int64 *)0)) {
        }
        *(int64 **)(lVar2 + 72) = plVar5;
        return lVar2;
    }

}
