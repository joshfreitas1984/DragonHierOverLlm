// ============================================================
// Type  : HeroSpeAddDataBase
// Token : 0x200021C
// ============================================================

public class HeroSpeAddDataBase
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001088
    public string name;

    // Token: 0x4001089
    public string describe;

    // Token: 0x400108A
    public float speValue;

    // Token: 0x400108B
    public string positiveName;

    // Token: 0x400108C
    public string negativeName;

    // Token: 0x400108D
    public bool showPercent;

    // Token: 0x400108E
    public bool noRandom;

    // Token: 0x400108F
    public bool randomNegative;

    // Token: 0x4001090
    public int lastTime;

    // Token: 0x4001091
    public bool selfBuff;

    // Token: 0x4001092
    public string fightValueType;

    // Token: 0x4001093
    public bool noAutoUpgrade;

    // Token: 0x4001094
    public int triggerType;

    // Token: 0x4001095
    public bool countFightScore;

    // Token: 0x4001096
    public bool needSpeDescribe;

    // Token: 0x4001097
    public bool stackable;

    // Token: 0x4001098
    private static List<string> triggerText;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60011F4
    // RVA   : 0xB39AE0   Offset: 0xB382E0   Length: 0x4DF
    public string GetDescribe()
    {
        int iVar1;
        uint uVar2;
        bool cVar3;
        long lVar5;
        long lVar6;
        ulong uVar7;
        int[] local_res8 = new int[2];
        plVar4 = (int64 *)FUN_1800d60b0(DAT_181d80cc0,7);
        lVar6 = this.name;
        if (plVar4 != (int64 *)0) {
          if ((lVar6 != null) &&
             (lVar5 = il2cpp_internal(lVar6,*(uint64 *)(*plVar4 + 64))) == null) {
            uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar7,0);
          }
          if ((int)plVar4[3] == 0) {
            uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar7,0);
          }
          plVar4[4] = lVar6;
          il2cpp_internal(plVar4 + 4,lVar6);
          if ((":" != 0) &&
             (lVar6 = il2cpp_internal(":",*(uint64 *)(*plVar4 + 64))) == null) {
            uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar7,0);
          }
          lVar6 = ":";
          if (*(uint32 *)(plVar4 + 3) < 2) {
            uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar7,0);
          }
          plVar4[5] = ":";
          il2cpp_internal(plVar4 + 5,lVar6);
          iVar1 = this.lastTime;
          lVar6 = "";
          if ((iVar1 != 0) && (lVar6 = "(内力)", -1 < iVar1)) {
            local_res8[0] = iVar1;
            uVar7 = il2cpp_value_box(DAT_181d5b2f8,local_res8);
            lVar6 = String.Format("({0}回合)",uVar7,0);
          }
          if ((lVar6 != null) &&
             (lVar5 = il2cpp_internal(lVar6,*(uint64 *)(*plVar4 + 64))) == null) {
            uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar7,0);
          }
          if (*(uint32 *)(plVar4 + 3) < 3) {
            uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar7,0);
          }
          plVar4[6] = lVar6;
          il2cpp_internal(plVar4 + 6,lVar6);
          if (("\n" != 0) &&
             (lVar6 = il2cpp_internal("\n",*(uint64 *)(*plVar4 + 64))) == null) {
            uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar7,0);
          }
          lVar6 = "\n";
          if (*(uint32 *)(plVar4 + 3) < 4) {
            uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar7,0);
          }
          plVar4[7] = "\n";
          il2cpp_internal(plVar4 + 7,lVar6);
          lVar6 = **(int64 **)(DAT_181d51300 + 184);
          if (lVar6 != null) {
            uVar2 = this.triggerType;
            if (*(uint32 *)(lVar6 + 24) <= uVar2) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            uVar7 = lVar6[uVar2];
            lVar6 = this.fightValueType;
            lVar5 = "";
            if (((lVar6 != null) &&
                (cVar3 = FUN_1816fd990(lVar6,"我方",0), lVar5 = "<color=green>[我]</color>", !cVar3)) &&
               (cVar3 = FUN_1816fd990(lVar6,"敌方",0), lVar5 = "<color=red>[敌]</color>", !cVar3)) {
              FUN_1816fd990(lVar6,"伤害",0);
              lVar5 = "";
            }
            lVar6 = String.Concat(uVar7,lVar5,0);
            if ((lVar6 != null) &&
               (lVar5 = il2cpp_internal(lVar6,*(uint64 *)(*plVar4 + 64))) == null) {
              uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar7,0);
            }
            if (*(uint32 *)(plVar4 + 3) < 5) {
              uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar7,0);
            }
            plVar4[8] = lVar6;
            il2cpp_internal(plVar4 + 8,lVar6);
            lVar6 = "";
            if (this.stackable) {
              lVar6 = "<color=magenta>[叠]</color>";
            }
            if ((lVar6 != null) &&
               (lVar5 = il2cpp_internal(lVar6,*(uint64 *)(*plVar4 + 64))) == null) {
              uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar7,0);
            }
            if (*(uint32 *)(plVar4 + 3) < 6) {
              uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar7,0);
            }
            plVar4[9] = lVar6;
            il2cpp_internal(plVar4 + 9,lVar6);
            lVar6 = this.describe;
            if ((lVar6 != null) &&
               (lVar5 = il2cpp_internal(lVar6,*(uint64 *)(*plVar4 + 64))) == null) {
              uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar7,0);
            }
            if (*(uint32 *)(plVar4 + 3) < 7) {
              uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar7,0);
            }
            plVar4[10] = lVar6;
            il2cpp_internal(plVar4 + 10,lVar6);
            String.Concat(plVar4,0);
            return;
          }
        }
    }

    // Token : 0x60011F5
    // RVA   : 0xB3A090   Offset: 0xB38890   Length: 0x165
    public string GetTriggerDescribe()
    {
        uint uVar1;
        long lVar2;
        ulong uVar3;
        bool cVar4;
        ulong uVar5;
        lVar2 = **(int64 **)(DAT_181d51300 + 184);
        if (lVar2 != null) {
          uVar1 = this.triggerType;
          if (*(uint32 *)(lVar2 + 24) <= uVar1) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          uVar3 = lVar2[uVar1];
          lVar2 = this.fightValueType;
          uVar5 = "";
          if (((lVar2 != null) &&
              (cVar4 = FUN_1816fd990(lVar2,"我方",0), uVar5 = "<color=green>[我]</color>", !cVar4)) &&
             (cVar4 = FUN_1816fd990(lVar2,"敌方",0), uVar5 = "<color=red>[敌]</color>", !cVar4)) {
            FUN_1816fd990(lVar2,"伤害",0);
            uVar5 = "";
          }
          String.Concat(uVar3,uVar5,0);
          return;
        }
    }

    // Token : 0x60011F6
    // RVA   : 0xB39FC0   Offset: 0xB387C0   Length: 0xCF
    public string GetTargetDescribe()
    {
        long lVar1;
        bool cVar2;
        lVar1 = this.fightValueType;
        if (lVar1 != null) {
          cVar2 = FUN_1816fd990(lVar1,"我方",0);
          if (cVar2) {
            return "<color=green>[我]</color>";
          }
          cVar2 = FUN_1816fd990(lVar1,"敌方",0);
          if (cVar2) {
            return "<color=red>[敌]</color>";
          }
          FUN_1816fd990(lVar1,"伤害",0);
        }
        return "";
    }

    // Token : 0x60011F7
    // RVA   : 0xB39960   Offset: 0xB38160   Length: 0x175
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

    // Token : 0x60011F8
    // RVA   : 0x210B70   Offset: 0x20F370   Length: 0x7
    public void /*ctor*/()
    {
        ZhSegment.Initialize(this,0);
    }

    // Token : 0x60011F9
    // RVA   : 0xB3A200   Offset: 0xB38A00   Length: 0xF2
    private static void /*cctor*/()
    {
        long lVar2;
        lVar2 = il2cpp_internal(DAT_181d72a30);
        FUN_180f58a90(lVar2,DAT_181d7c250);
        if (lVar2 != null) {
          FUN_181827900(lVar2,"",DAT_181d7c3d0);
          FUN_181827900(lVar2,"<color=orange>[攻]</color>",DAT_181d7c3d0);
          FUN_181827900(lVar2,"<color=darkblue>[守]</color>",DAT_181d7c3d0);
          plVar1 = *(int64 **)(DAT_181d51300 + 184);
          *plVar1 = lVar2;
          il2cpp_internal(plVar1,lVar2);
          return;
        }
    }

}
