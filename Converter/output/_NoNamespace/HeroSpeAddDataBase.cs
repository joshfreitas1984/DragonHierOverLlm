// ============================================================
// Type  : HeroSpeAddDataBase
// Token : 0x2000224
// ============================================================

public class HeroSpeAddDataBase
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001141
    public string name;

    // Token: 0x4001142
    public string describe;

    // Token: 0x4001143
    public float speValue;

    // Token: 0x4001144
    public string positiveName;

    // Token: 0x4001145
    public string negativeName;

    // Token: 0x4001146
    public bool showPercent;

    // Token: 0x4001147
    public bool noRandom;

    // Token: 0x4001148
    public bool randomNegative;

    // Token: 0x4001149
    public int lastTime;

    // Token: 0x400114A
    public bool selfBuff;

    // Token: 0x400114B
    public string fightValueType;

    // Token: 0x400114C
    public bool noAutoUpgrade;

    // Token: 0x400114D
    public int triggerType;

    // Token: 0x400114E
    public bool countFightScore;

    // Token: 0x400114F
    public bool needSpeDescribe;

    // Token: 0x4001150
    public bool stackable;

    // Token: 0x4001151
    private static List<string> triggerText;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6001241
    // RVA   : 0x89D0A0   Offset: 0x89BEA0   Length: 0x4DF
    public string GetDescribe()
    {
        int iVar1;
        uint uVar2;
        bool cVar3;
        long lVar5;
        long lVar6;
        ulong uVar7;
        int[] local_res8 = new int[2];
        plVar4 = (int64 *)FUN_1801dfd90(DAT_181e85e38,7);
        lVar6 = this.name;
        if (plVar4 != (int64 *)0) {
          if ((lVar6 != null) &&
             (lVar5 = il2cpp_internal(lVar6,*(uint64 *)(*plVar4 + 64))) == null) {
            uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1801e02d0(uVar7,0);
          }
          if ((int)plVar4[3] == 0) {
            uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1801e02d0(uVar7,0);
          }
          plVar4[4] = lVar6;
          il2cpp_internal(plVar4 + 4,lVar6);
          if ((":" != 0) &&
             (lVar6 = il2cpp_internal(":",*(uint64 *)(*plVar4 + 64))) == null) {
            uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1801e02d0(uVar7,0);
          }
          lVar6 = ":";
          if (*(uint32 *)(plVar4 + 3) < 2) {
            uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1801e02d0(uVar7,0);
          }
          plVar4[5] = ":";
          il2cpp_internal(plVar4 + 5,lVar6);
          iVar1 = this.lastTime;
          lVar6 = "";
          if ((iVar1 != 0) && (lVar6 = "(内力)", -1 < iVar1)) {
            local_res8[0] = iVar1;
            uVar7 = il2cpp_value_box(DAT_181e60808,local_res8);
            lVar6 = String.Format("({0}回合)",uVar7,0);
          }
          if ((lVar6 != null) &&
             (lVar5 = il2cpp_internal(lVar6,*(uint64 *)(*plVar4 + 64))) == null) {
            uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1801e02d0(uVar7,0);
          }
          if (*(uint32 *)(plVar4 + 3) < 3) {
            uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1801e02d0(uVar7,0);
          }
          plVar4[6] = lVar6;
          il2cpp_internal(plVar4 + 6,lVar6);
          if (("\n" != 0) &&
             (lVar6 = il2cpp_internal("\n",*(uint64 *)(*plVar4 + 64))) == null) {
            uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1801e02d0(uVar7,0);
          }
          lVar6 = "\n";
          if (*(uint32 *)(plVar4 + 3) < 4) {
            uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1801e02d0(uVar7,0);
          }
          plVar4[7] = "\n";
          il2cpp_internal(plVar4 + 7,lVar6);
          lVar6 = **(int64 **)(DAT_181e55f28 + 184);
          if (lVar6 != null) {
            uVar2 = this.triggerType;
            if (*(uint32 *)(lVar6 + 24) <= uVar2) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            uVar7 = lVar6[uVar2];
            lVar6 = this.fightValueType;
            lVar5 = "";
            if (((lVar6 != null) &&
                (cVar3 = FUN_1816387f0(lVar6,"我方",0), lVar5 = "<color=green>[我]</color>", !cVar3)) &&
               (cVar3 = FUN_1816387f0(lVar6,"敌方",0), lVar5 = "<color=red>[敌]</color>", !cVar3)) {
              FUN_1816387f0(lVar6,"伤害",0);
              lVar5 = "";
            }
            lVar6 = String.Concat(uVar7,lVar5,0);
            if ((lVar6 != null) &&
               (lVar5 = il2cpp_internal(lVar6,*(uint64 *)(*plVar4 + 64))) == null) {
              uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1801e02d0(uVar7,0);
            }
            if (*(uint32 *)(plVar4 + 3) < 5) {
              uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1801e02d0(uVar7,0);
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
              FUN_1801e02d0(uVar7,0);
            }
            if (*(uint32 *)(plVar4 + 3) < 6) {
              uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1801e02d0(uVar7,0);
            }
            plVar4[9] = lVar6;
            il2cpp_internal(plVar4 + 9,lVar6);
            lVar6 = this.describe;
            if ((lVar6 != null) &&
               (lVar5 = il2cpp_internal(lVar6,*(uint64 *)(*plVar4 + 64))) == null) {
              uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1801e02d0(uVar7,0);
            }
            if (*(uint32 *)(plVar4 + 3) < 7) {
              uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1801e02d0(uVar7,0);
            }
            plVar4[10] = lVar6;
            il2cpp_internal(plVar4 + 10,lVar6);
            String.Concat(plVar4,0);
            return;
          }
        }
    }

    // Token : 0x6001242
    // RVA   : 0x89D650   Offset: 0x89C450   Length: 0x165
    public string GetTriggerDescribe()
    {
        uint uVar1;
        long lVar2;
        ulong uVar3;
        bool cVar4;
        ulong uVar5;
        lVar2 = **(int64 **)(DAT_181e55f28 + 184);
        if (lVar2 != null) {
          uVar1 = this.triggerType;
          if (*(uint32 *)(lVar2 + 24) <= uVar1) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          uVar3 = lVar2[uVar1];
          lVar2 = this.fightValueType;
          uVar5 = "";
          if (((lVar2 != null) &&
              (cVar4 = FUN_1816387f0(lVar2,"我方",0), uVar5 = "<color=green>[我]</color>", !cVar4)) &&
             (cVar4 = FUN_1816387f0(lVar2,"敌方",0), uVar5 = "<color=red>[敌]</color>", !cVar4)) {
            FUN_1816387f0(lVar2,"伤害",0);
            uVar5 = "";
          }
          String.Concat(uVar3,uVar5,0);
          return;
        }
    }

    // Token : 0x6001243
    // RVA   : 0x89D580   Offset: 0x89C380   Length: 0xCF
    public string GetTargetDescribe()
    {
        long lVar1;
        bool cVar2;
        lVar1 = this.fightValueType;
        if (lVar1 != null) {
          cVar2 = FUN_1816387f0(lVar1,"我方",0);
          if (cVar2) {
            return "<color=green>[我]</color>";
          }
          cVar2 = FUN_1816387f0(lVar1,"敌方",0);
          if (cVar2) {
            return "<color=red>[敌]</color>";
          }
          FUN_1816387f0(lVar1,"伤害",0);
        }
        return "";
    }

    // Token : 0x6001244
    // RVA   : 0x89CF20   Offset: 0x89BD20   Length: 0x175
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
        plVar1 = (int64 *)il2cpp_internal(DAT_181e695f0);
        plVar4 = plVar1;
        MemoryStream.ctor(plVar1,1000,0);
        local_38 = 0;
        uStack_30 = 0;
        StreamingContext.ctor(&local_38,64,0);
        lVar2 = il2cpp_internal(DAT_181e91a00);
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
            FUN_180002280(0,DAT_181e58ab8,plVar1);
            return uVar3;
          }
                          // WARNING: Subroutine does not return
          FUN_1801e0300();
        }
    }

    // Token : 0x6001245
    // RVA   : 0x42F150   Offset: 0x42DF50   Length: 0x7
    public void /*ctor*/()
    {
        ZhSegment.Initialize(this,0);
    }

    // Token : 0x6001246
    // RVA   : 0x89D7C0   Offset: 0x89C5C0   Length: 0xF2
    private static void /*cctor*/()
    {
        long lVar2;
        lVar2 = il2cpp_internal(DAT_181e77728);
        FUN_1810f3480(lVar2,DAT_181e861f0);
        if (lVar2 != null) {
          FUN_18175de30(lVar2,"",DAT_181e86370);
          FUN_18175de30(lVar2,"<color=orange>[攻]</color>",DAT_181e86370);
          FUN_18175de30(lVar2,"<color=darkblue>[守]</color>",DAT_181e86370);
          plVar1 = *(int64 **)(DAT_181e55f28 + 184);
          *plVar1 = lVar2;
          il2cpp_internal(plVar1,lVar2);
          return;
        }
    }

}
