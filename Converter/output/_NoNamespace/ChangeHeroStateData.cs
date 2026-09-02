// ============================================================
// Type  : ChangeHeroStateData
// Token : 0x2000233
// ============================================================

public class ChangeHeroStateData
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x400112B
    public float hp;

    // Token: 0x400112C
    public float maxhp;

    // Token: 0x400112D
    public float mana;

    // Token: 0x400112E
    public float maxMana;

    // Token: 0x400112F
    public float power;

    // Token: 0x4001130
    public float maxPower;

    // Token: 0x4001131
    public float externalInjury;

    // Token: 0x4001132
    public float internalInjury;

    // Token: 0x4001133
    public float poisonInjury;

    // Token: 0x4001134
    public List<int> changeAttri;

    // Token: 0x4001135
    public float charm;

    // Token: 0x4001136
    public HeroSpeAddData buffData;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x600127C
    // RVA   : 0x9F0D60   Offset: 0x9EF560   Length: 0xC3
    public static ChangeHeroStateData op_Multiply(ChangeHeroStateData a, float b)
    {
        if (a != null) {
          plVar1 = (int64 *)ChangeHeroStateData.Clone(a,0);
          if (plVar1 != (int64 *)0) {
            if ((*(byte *)(DAT_181d91a68 + 300) <= *(byte *)(*plVar1 + 300)) &&
               (*(int64 *)
                 (*(int64 *)(*plVar1 + 200) + -8 + (uint64)*(byte *)(DAT_181d91a68 + 300) * 8) ==
                DAT_181d91a68)) {
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
            FUN_1800d6070(plVar1,DAT_181d91a68);
          }
        }
    }

    // Token : 0x600127D
    // RVA   : 0x9F0CB0   Offset: 0x9EF4B0   Length: 0xAA
    public void /*ctor*/()
    {
        ulong uVar1;
        ZhSegment.Initialize(this,0);
        uVar1 = il2cpp_internal(DAT_181d6f030);
        FUN_180f58a90(uVar1,DAT_181d678f8);
        this.changeAttri = uVar1;
        this.buffData = new HeroSpeAddData(0);
    }

    // Token : 0x600127E
    // RVA   : 0x9F0C90   Offset: 0x9EF490   Length: 0xE
    public float GetMaxChangeMaxHp()
    {
        return this.maxhp * 10.0;
    }

    // Token : 0x600127F
    // RVA   : 0x9F0CA0   Offset: 0x9EF4A0   Length: 0xE
    public float GetMaxChangeMaxMp()
    {
        return this.maxMana * 10.0;
    }

    // Token : 0x6001280
    // RVA   : 0x9F0860   Offset: 0x9EF060   Length: 0x427
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
          cVar1 = FUN_1816fd990(uVar3,"",0);
          uVar2 = "\n";
          if (cVar1) {
            uVar2 = "";
          }
          uVar4 = Single.ToString(this + 20,"+0;-0;0",0);
          uVar3 = String.Concat(uVar3,uVar2,"生命上限",uVar4,0);
        }
        if (this.mana != null.0) {
          cVar1 = FUN_1816fd990(uVar3,"",0);
          uVar2 = "\n";
          if (cVar1) {
            uVar2 = "";
          }
          uVar4 = Single.ToString(this + 24,"+0;-0;0",0);
          uVar3 = String.Concat(uVar3,uVar2,"内力",uVar4,0);
        }
        if (this.maxMana != null.0) {
          cVar1 = FUN_1816fd990(uVar3,"",0);
          uVar2 = "\n";
          if (cVar1) {
            uVar2 = "";
          }
          uVar4 = Single.ToString(this + 28,"+0;-0;0",0);
          uVar3 = String.Concat(uVar3,uVar2,"内力上限",uVar4,0);
        }
        if (this.power != null.0) {
          cVar1 = FUN_1816fd990(uVar3,"",0);
          uVar2 = "\n";
          if (cVar1) {
            uVar2 = "";
          }
          uVar4 = Single.ToString(this + 32,"+0;-0;0",0);
          uVar3 = String.Concat(uVar3,uVar2,"体力",uVar4,0);
        }
        if (this.maxPower != null.0) {
          cVar1 = FUN_1816fd990(uVar3,"",0);
          uVar2 = "\n";
          if (cVar1) {
            uVar2 = "";
          }
          uVar4 = Single.ToString(this + 36,"+0;-0;0",0);
          uVar3 = String.Concat(uVar3,uVar2,"体力上限",uVar4,0);
        }
        if (this.externalInjury != null.0) {
          cVar1 = FUN_1816fd990(uVar3,"",0);
          uVar2 = "\n";
          if (cVar1) {
            uVar2 = "";
          }
          uVar4 = Single.ToString(this + 40,"+0;-0;0",0);
          uVar3 = String.Concat(uVar3,uVar2,"外伤",uVar4,0);
        }
        if (this.internalInjury != null.0) {
          cVar1 = FUN_1816fd990(uVar3,"",0);
          uVar2 = "\n";
          if (cVar1) {
            uVar2 = "";
          }
          uVar4 = Single.ToString(this + 44,"+0;-0;0",0);
          uVar3 = String.Concat(uVar3,uVar2,"内伤",uVar4,0);
        }
        if (this.poisonInjury != null.0) {
          cVar1 = FUN_1816fd990(uVar3,"",0);
          uVar2 = "\n";
          if (cVar1) {
            uVar2 = "";
          }
          uVar4 = Single.ToString(this + 48,"+0;-0;0",0);
          uVar3 = String.Concat(uVar3,uVar2,"中毒",uVar4,0);
        }
        return uVar3;
    }

    // Token : 0x6001281
    // RVA   : 0x9F0680   Offset: 0x9EEE80   Length: 0x1DD
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
        plVar1 = (int64 *)il2cpp_internal(DAT_181d63ff0);
        plVar7 = plVar1;
        MemoryStream.ctor(plVar1,1000,0);
        local_38 = 0;
        uStack_30 = 0;
        StreamingContext.ctor(&local_38,64,0);
        lVar2 = il2cpp_internal(DAT_181d8c5a8);
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
            if (*(int64 *)(*(int64 *)(lVar2 + 176) + uVar6 * 16) == DAT_181d53c70) {
              puVar4 = (uint64 *)
                       ((int64)*(int *)(*(int64 *)(lVar2 + 176) + 8 + uVar6 * 16) * 16 + 0x138
                       + lVar2);
              goto LAB_1809f0804;
            }
            uVar5 = (short)uVar6 + 1;
            uVar6 = (uint64)uVar5;
          } while (uVar5 < *(uint16 *)(lVar2 + 0x12a));
        }
        puVar4 = (uint64 *)FUN_1800914f0(plVar1,DAT_181d53c70,0);
        LAB_1809f0804:
        (*(code *)*puVar4)(plVar1,puVar4[1]);
        return uVar3;
    }

}
