// ============================================================
// Type  : HeroAIData
// Token : 0x2000130
// ============================================================

public class HeroAIData
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x400076D
    public AIStuffType aiStuffType;

    // Token: 0x400076E
    public bool isPassiveTarget;

    // Token: 0x400076F
    public string aiStuffTarget;

    // Token: 0x4000770
    public int keepWorkingTimeLeft;

    // Token: 0x4000771
    public int keepWorkingTimeContine;

    // Token: 0x4000772
    public float leaveForceTime;

    // Token: 0x4000773
    public bool needCheckEquipment;

    // Token: 0x4000774
    public bool needCheckSkill;

    // Token: 0x4000775
    public bool needCheckSpeMed;

    // Token: 0x4000776
    public int bigMapTargetID;

    // Token: 0x4000777
    public BigMapPos bigMapTargetPos;

    // Token: 0x4000778
    public float bigmapWaitTime;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60009B9
    // RVA   : 0x877490   Offset: 0x875C90   Length: 0x6C
    public void /*ctor*/()
    {
                           uint8 param_5)
        {
        char cVar1;
        int iVar2;
        uint64 uVar3;
        int64 lVar4;
        int64 *plVar5;
        this.bigMapTargetID = 0xffffffff;
        this.bigMapTargetPos = new c.DisplayClass9_0(0);
        ZhSegment.Initialize(this,0);
        this.aiStuffType = param_2;
        if (((*(byte *)(DAT_181d84cc0 + 0x133) & 4) != 0) && (*(int *)(DAT_181d84cc0 + 224) == 0)) {
          il2cpp_runtime_class_init(DAT_181d84cc0);
          param_2 = this.aiStuffType;
        }
        lVar4 = *(int64 *)(*(int64 *)(DAT_181d84cc0 + 184) + 16);
        if (lVar4 == null) goto LAB_1808776f0;
        cVar1 = FUN_181815240(lVar4,param_2,DAT_181d53900);
        if (cVar1) {
          iVar2 = Int32.Parse(param_3,0);
          this.bigMapTargetID = iVar2;
          if (-1 < iVar2) {
            lVar4 = FUN_18046c0a0(0);
            if ((lVar4 != null) && (*(int64 *)(lVar4 + 32) != 0)) {
              lVar4 = WorldData.GetArea(*(int64 *)(lVar4 + 32),this.bigMapTargetID,0);
              if ((lVar4 != null) && (*(int64 *)(lVar4 + 64) != 0)) {
                plVar5 = (int64 *)BigMapPos.Clone();
                if (plVar5 == (int64 *)0) {
                  this.bigMapTargetPos = 0;
                }
                else {
                  this.bigMapTargetPos = plVar5;
                }
                goto LAB_18087760c;
              }
            }
        LAB_1808776f0:
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          HeroAIData.WandererLoseTarget(this,0);
        }
        LAB_18087760c:
        this.aiStuffTarget = param_3;
        this.isPassiveTarget = param_5;
        this.keepWorkingTimeLeft = param_4;
    }

    // Token : 0x60009BA
    // RVA   : 0x877200   Offset: 0x875A00   Length: 0x8C
    public void /*ctor*/(AIStuffType _aiStuffType, int _keepWorkingTimeLeft)
    {
                           uint8 param_5)
        {
        char cVar1;
        int iVar2;
        uint64 uVar3;
        int64 lVar4;
        int64 *plVar5;
        this.bigMapTargetID = 0xffffffff;
        this.bigMapTargetPos = new c.DisplayClass9_0(0);
        ZhSegment.Initialize(this,0);
        this.aiStuffType = _aiStuffType;
        if (((*(byte *)(DAT_181d84cc0 + 0x133) & 4) != 0) && (*(int *)(DAT_181d84cc0 + 224) == 0)) {
          il2cpp_runtime_class_init(DAT_181d84cc0);
          _aiStuffType = this.aiStuffType;
        }
        lVar4 = *(int64 *)(*(int64 *)(DAT_181d84cc0 + 184) + 16);
        if (lVar4 == null) goto LAB_1808776f0;
        cVar1 = FUN_181815240(lVar4,_aiStuffType,DAT_181d53900);
        if (cVar1) {
          iVar2 = Int32.Parse(_keepWorkingTimeLeft,0);
          this.bigMapTargetID = iVar2;
          if (-1 < iVar2) {
            lVar4 = FUN_18046c0a0(0);
            if ((lVar4 != null) && (*(int64 *)(lVar4 + 32) != 0)) {
              lVar4 = WorldData.GetArea(*(int64 *)(lVar4 + 32),this.bigMapTargetID,0);
              if ((lVar4 != null) && (*(int64 *)(lVar4 + 64) != 0)) {
                plVar5 = (int64 *)BigMapPos.Clone();
                if (plVar5 == (int64 *)0) {
                  this.bigMapTargetPos = 0;
                }
                else {
                  this.bigMapTargetPos = plVar5;
                }
                goto LAB_18087760c;
              }
            }
        LAB_1808776f0:
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          HeroAIData.WandererLoseTarget(this,0);
        }
        LAB_18087760c:
        this.aiStuffTarget = _keepWorkingTimeLeft;
        this.isPassiveTarget = param_5;
        this.keepWorkingTimeLeft = param_4;
    }

    // Token : 0x60009BB
    // RVA   : 0x877290   Offset: 0x875A90   Length: 0x1F6
    public void /*ctor*/(AIStuffType _aiStuffType, string _aiStuffTarget, int _keepWorkingTimeLeft)
    {
                           uint8 param_5)
        {
        char cVar1;
        int iVar2;
        uint64 uVar3;
        int64 lVar4;
        int64 *plVar5;
        this.bigMapTargetID = 0xffffffff;
        this.bigMapTargetPos = new c.DisplayClass9_0(0);
        ZhSegment.Initialize(this,0);
        this.aiStuffType = _aiStuffType;
        if (((*(byte *)(DAT_181d84cc0 + 0x133) & 4) != 0) && (*(int *)(DAT_181d84cc0 + 224) == 0)) {
          il2cpp_runtime_class_init(DAT_181d84cc0);
          _aiStuffType = this.aiStuffType;
        }
        lVar4 = *(int64 *)(*(int64 *)(DAT_181d84cc0 + 184) + 16);
        if (lVar4 == null) goto LAB_1808776f0;
        cVar1 = FUN_181815240(lVar4,_aiStuffType,DAT_181d53900);
        if (cVar1) {
          iVar2 = Int32.Parse(_aiStuffTarget,0);
          this.bigMapTargetID = iVar2;
          if (-1 < iVar2) {
            lVar4 = FUN_18046c0a0(0);
            if ((lVar4 != null) && (*(int64 *)(lVar4 + 32) != 0)) {
              lVar4 = WorldData.GetArea(*(int64 *)(lVar4 + 32),this.bigMapTargetID,0);
              if ((lVar4 != null) && (*(int64 *)(lVar4 + 64) != 0)) {
                plVar5 = (int64 *)BigMapPos.Clone();
                if (plVar5 == (int64 *)0) {
                  this.bigMapTargetPos = 0;
                }
                else {
                  this.bigMapTargetPos = plVar5;
                }
                goto LAB_18087760c;
              }
            }
        LAB_1808776f0:
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          HeroAIData.WandererLoseTarget(this,0);
        }
        LAB_18087760c:
        this.aiStuffTarget = _aiStuffTarget;
        this.isPassiveTarget = param_5;
        this.keepWorkingTimeLeft = _keepWorkingTimeLeft;
    }

    // Token : 0x60009BC
    // RVA   : 0x877500   Offset: 0x875D00   Length: 0x1FE
    public void /*ctor*/(AIStuffType _aiStuffType, string _aiStuffTarget, int _keepWorkingTimeLeft, bool _isPassiveTarget)
    {
                           uint8 _isPassiveTarget)
        {
        char cVar1;
        int iVar2;
        uint64 uVar3;
        int64 lVar4;
        int64 *plVar5;
        this.bigMapTargetID = 0xffffffff;
        this.bigMapTargetPos = new c.DisplayClass9_0(0);
        ZhSegment.Initialize(this,0);
        this.aiStuffType = _aiStuffType;
        if (((*(byte *)(DAT_181d84cc0 + 0x133) & 4) != 0) && (*(int *)(DAT_181d84cc0 + 224) == 0)) {
          il2cpp_runtime_class_init(DAT_181d84cc0);
          _aiStuffType = this.aiStuffType;
        }
        lVar4 = *(int64 *)(*(int64 *)(DAT_181d84cc0 + 184) + 16);
        if (lVar4 == null) goto LAB_1808776f0;
        cVar1 = FUN_181815240(lVar4,_aiStuffType,DAT_181d53900);
        if (cVar1) {
          iVar2 = Int32.Parse(_aiStuffTarget,0);
          this.bigMapTargetID = iVar2;
          if (-1 < iVar2) {
            lVar4 = FUN_18046c0a0(0);
            if ((lVar4 != null) && (*(int64 *)(lVar4 + 32) != 0)) {
              lVar4 = WorldData.GetArea(*(int64 *)(lVar4 + 32),this.bigMapTargetID,0);
              if ((lVar4 != null) && (*(int64 *)(lVar4 + 64) != 0)) {
                plVar5 = (int64 *)BigMapPos.Clone();
                if (plVar5 == (int64 *)0) {
                  this.bigMapTargetPos = 0;
                }
                else {
                  this.bigMapTargetPos = plVar5;
                }
                goto LAB_18087760c;
              }
            }
        LAB_1808776f0:
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          HeroAIData.WandererLoseTarget(this,0);
        }
        LAB_18087760c:
        this.aiStuffTarget = _aiStuffTarget;
        this.isPassiveTarget = _isPassiveTarget;
        this.keepWorkingTimeLeft = _keepWorkingTimeLeft;
    }

    // Token : 0x60009BD
    // RVA   : 0x8770A0   Offset: 0x8758A0   Length: 0x24
    public void ResetBigmapTarget()
    {
        this.bigMapTargetID = 0xffffffff;
        if (this.bigMapTargetPos != null) {
          BigMapPos.Reset(this.bigMapTargetPos,0);
          return;
        }
    }

    // Token : 0x60009BE
    // RVA   : 0x876CD0   Offset: 0x8754D0   Length: 0x398
    public string GetDescribe()
    {
        var pStatics = *(int64*)(DAT_181d4ef00 + 184);
        uint uVar1;
        long lVar2;
        ulong uVar3;
        ulong uVar4;
        uint uVar5;
        long lVar6;
        uVar5 = this.aiStuffType;
        lVar6 = (int64)(int)uVar5;
        lVar2 = **(int64 **)(DAT_181d84cc0 + 184);
        if (lVar2 == null) goto LAB_180877061;
        if (*(uint32 *)(lVar2 + 24) <= uVar5) {
          ThrowHelper.ThrowArgumentOutOfRangeException(0);
          uVar5 = this.aiStuffType;
        }
        uVar4 = *(uint64 *)(*(int64 *)(lVar2 + 16) + 32 + lVar6 * 8);
        switch(uVar5) {
        case 1:
          if (this.bigMapTargetID < 0) {
            if (this.bigmapWaitTime <= 0.0) {
              return "巡逻";
            }
            return "休息";
          }
          lVar2 = FUN_18046c0a0(0);
          if (((lVar2 == null) || (*(int64 *)(lVar2 + 32) == 0)) ||
             (lVar2 = WorldData.GetArea(*(int64 *)(lVar2 + 32),this.bigMapTargetID,0),
             lVar2 == null)) goto LAB_180877061;
          uVar3 = *(uint64 *)(lVar2 + 24);
          break;
        case 2:
        case 3:
        case 4:
        case 8:
        case 9:
        case 10:
          goto switchD_180876ddc_caseD_2;
        case 6:
          lVar2 = *(int64 *)(pStatics + 0x4a8);
          goto LAB_180876e91;
        case 7:
          lVar2 = *(int64 *)(pStatics + 0x430);
        LAB_180876e91:
          uVar1 = Int32.Parse(this.aiStuffTarget,0);
          if (lVar2 == null) goto LAB_180877061;
          uVar3 = FUN_180002f80(lVar2,uVar1,DAT_181d7c9c0);
          break;
        case 11:
        case 12:
        case 13:
          lVar2 = FUN_18046c0a0(0);
          if (lVar2 != null) {
            lVar2 = *(int64 *)(lVar2 + 32);
            uVar1 = Int32.Parse(this.aiStuffTarget,0);
            if (lVar2 != null) {
              lVar2 = WorldData.GetHero(lVar2,uVar1,0);
              uVar3 = "与";
              if (lVar2 == null) {
                uVar4 = String.Concat("与","他人",uVar4,0);
                return uVar4;
              }
              lVar2 = FUN_18046c0a0(0);
              if (lVar2 != null) {
                lVar2 = *(int64 *)(lVar2 + 32);
                uVar1 = Int32.Parse(this.aiStuffTarget,0);
                if ((lVar2 != null) && (lVar2 = WorldData.GetHero(lVar2,uVar1,0)) != null) {
                  uVar4 = String.Concat(uVar3,*(uint64 *)(lVar2 + 104),uVar4,0);
                  return uVar4;
                }
              }
            }
          }
          goto LAB_180877061;
        default:
          if (uVar5 != 18) {
            return uVar4;
          }
        case 5:
          lVar2 = FUN_18046c100(0);
          uVar1 = Int32.Parse(this.aiStuffTarget,0);
          if ((lVar2 == null) || (lVar2 = GameDataController.GetSkillDataBase(lVar2,uVar1,0)) == null) {
        LAB_180877061:
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          uVar3 = KungfuSkillData.Name(lVar2,1,0);
        }
        uVar4 = String.Concat(uVar4,uVar3,0);
        switchD_180876ddc_caseD_2:
        return uVar4;
    }

    // Token : 0x60009BF
    // RVA   : 0x877140   Offset: 0x875940   Length: 0xBF
    public void WandererLoseTarget()
    {
        int iVar1;
        float fVar2;
        double dVar3;
        dVar3 = (double)GlobalData.RandomRangeDouble(0,0);
        if (0.25 <= dVar3) {
          iVar1 = GlobalData.RandomRange(1,7,0);
          fVar2 = (float)iVar1;
        }
        else {
          fVar2 = 0.01;
        }
        if (this != 0) {
          this.bigmapWaitTime = fVar2;
          if (this.bigMapTargetPos != null) {
            BigMapPos.Reset(this.bigMapTargetPos,0);
            return;
          }
        }
    }

    // Token : 0x60009C0
    // RVA   : 0x8770D0   Offset: 0x8758D0   Length: 0x69
    public void ResetBigmapWaitTime()
    {
        uint uVar1;
        uVar1 = GlobalData.RandomRange(0x3f800000,0x41c00000,0,0);
        this.bigmapWaitTime = uVar1;
    }

    // Token : 0x60009C1
    // RVA   : 0x876B50   Offset: 0x875350   Length: 0x175
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
