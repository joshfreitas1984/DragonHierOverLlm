// ============================================================
// Type  : HeroAIData
// Token : 0x2000130
// ============================================================

public class HeroAIData
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4000769
    public AIStuffType aiStuffType;

    // Token: 0x400076A
    public bool isPassiveTarget;

    // Token: 0x400076B
    public string aiStuffTarget;

    // Token: 0x400076C
    public int keepWorkingTimeLeft;

    // Token: 0x400076D
    public int keepWorkingTimeContine;

    // Token: 0x400076E
    public float leaveForceTime;

    // Token: 0x400076F
    public bool needCheckEquipment;

    // Token: 0x4000770
    public bool needCheckSkill;

    // Token: 0x4000771
    public bool needCheckSpeMed;

    // Token: 0x4000772
    public int bigMapTargetID;

    // Token: 0x4000773
    public BigMapPos bigMapTargetPos;

    // Token: 0x4000774
    public float bigmapWaitTime;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60009B8
    // RVA   : 0x5AEBA0   Offset: 0x5AD9A0   Length: 0x6C
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
        if (((*(byte *)(DAT_181e89f38 + 0x133) & 4) != 0) && (*(int *)(DAT_181e89f38 + 224) == 0)) {
          il2cpp_runtime_class_init(DAT_181e89f38);
          param_2 = this.aiStuffType;
        }
        lVar4 = *(int64 *)(*(int64 *)(DAT_181e89f38 + 184) + 16);
        if (lVar4 == null) goto LAB_1805aee00;
        cVar1 = FUN_18176a2d0(lVar4,param_2,DAT_181e5cbe8);
        if (cVar1) {
          iVar2 = Int32.Parse(param_3,0);
          this.bigMapTargetID = iVar2;
          if (-1 < iVar2) {
            lVar4 = FUN_1802106e0(0);
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
                goto LAB_1805aed1c;
              }
            }
        LAB_1805aee00:
                          // WARNING: Subroutine does not return
            FUN_1801e0300();
          }
          HeroAIData.WandererLoseTarget(this,0);
        }
        LAB_1805aed1c:
        this.aiStuffTarget = param_3;
        this.isPassiveTarget = param_5;
        this.keepWorkingTimeLeft = param_4;
    }

    // Token : 0x60009B9
    // RVA   : 0x5AE910   Offset: 0x5AD710   Length: 0x8C
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
        if (((*(byte *)(DAT_181e89f38 + 0x133) & 4) != 0) && (*(int *)(DAT_181e89f38 + 224) == 0)) {
          il2cpp_runtime_class_init(DAT_181e89f38);
          _aiStuffType = this.aiStuffType;
        }
        lVar4 = *(int64 *)(*(int64 *)(DAT_181e89f38 + 184) + 16);
        if (lVar4 == null) goto LAB_1805aee00;
        cVar1 = FUN_18176a2d0(lVar4,_aiStuffType,DAT_181e5cbe8);
        if (cVar1) {
          iVar2 = Int32.Parse(_keepWorkingTimeLeft,0);
          this.bigMapTargetID = iVar2;
          if (-1 < iVar2) {
            lVar4 = FUN_1802106e0(0);
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
                goto LAB_1805aed1c;
              }
            }
        LAB_1805aee00:
                          // WARNING: Subroutine does not return
            FUN_1801e0300();
          }
          HeroAIData.WandererLoseTarget(this,0);
        }
        LAB_1805aed1c:
        this.aiStuffTarget = _keepWorkingTimeLeft;
        this.isPassiveTarget = param_5;
        this.keepWorkingTimeLeft = param_4;
    }

    // Token : 0x60009BA
    // RVA   : 0x5AE9A0   Offset: 0x5AD7A0   Length: 0x1F6
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
        if (((*(byte *)(DAT_181e89f38 + 0x133) & 4) != 0) && (*(int *)(DAT_181e89f38 + 224) == 0)) {
          il2cpp_runtime_class_init(DAT_181e89f38);
          _aiStuffType = this.aiStuffType;
        }
        lVar4 = *(int64 *)(*(int64 *)(DAT_181e89f38 + 184) + 16);
        if (lVar4 == null) goto LAB_1805aee00;
        cVar1 = FUN_18176a2d0(lVar4,_aiStuffType,DAT_181e5cbe8);
        if (cVar1) {
          iVar2 = Int32.Parse(_aiStuffTarget,0);
          this.bigMapTargetID = iVar2;
          if (-1 < iVar2) {
            lVar4 = FUN_1802106e0(0);
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
                goto LAB_1805aed1c;
              }
            }
        LAB_1805aee00:
                          // WARNING: Subroutine does not return
            FUN_1801e0300();
          }
          HeroAIData.WandererLoseTarget(this,0);
        }
        LAB_1805aed1c:
        this.aiStuffTarget = _aiStuffTarget;
        this.isPassiveTarget = param_5;
        this.keepWorkingTimeLeft = _keepWorkingTimeLeft;
    }

    // Token : 0x60009BB
    // RVA   : 0x5AEC10   Offset: 0x5ADA10   Length: 0x1FE
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
        if (((*(byte *)(DAT_181e89f38 + 0x133) & 4) != 0) && (*(int *)(DAT_181e89f38 + 224) == 0)) {
          il2cpp_runtime_class_init(DAT_181e89f38);
          _aiStuffType = this.aiStuffType;
        }
        lVar4 = *(int64 *)(*(int64 *)(DAT_181e89f38 + 184) + 16);
        if (lVar4 == null) goto LAB_1805aee00;
        cVar1 = FUN_18176a2d0(lVar4,_aiStuffType,DAT_181e5cbe8);
        if (cVar1) {
          iVar2 = Int32.Parse(_aiStuffTarget,0);
          this.bigMapTargetID = iVar2;
          if (-1 < iVar2) {
            lVar4 = FUN_1802106e0(0);
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
                goto LAB_1805aed1c;
              }
            }
        LAB_1805aee00:
                          // WARNING: Subroutine does not return
            FUN_1801e0300();
          }
          HeroAIData.WandererLoseTarget(this,0);
        }
        LAB_1805aed1c:
        this.aiStuffTarget = _aiStuffTarget;
        this.isPassiveTarget = _isPassiveTarget;
        this.keepWorkingTimeLeft = _keepWorkingTimeLeft;
    }

    // Token : 0x60009BC
    // RVA   : 0x5AE7B0   Offset: 0x5AD5B0   Length: 0x24
    public void ResetBigmapTarget()
    {
        this.bigMapTargetID = 0xffffffff;
        if (this.bigMapTargetPos != null) {
          BigMapPos.Reset(this.bigMapTargetPos,0);
          return;
        }
    }

    // Token : 0x60009BD
    // RVA   : 0x5AE3D0   Offset: 0x5AD1D0   Length: 0x3A0
    public string GetDescribe()
    {
        var pStatics = *(int64*)(DAT_181e538e8 + 184);
        uint uVar1;
        long lVar2;
        ulong uVar3;
        ulong uVar4;
        uint uVar5;
        long lVar6;
        uVar5 = this.aiStuffType;
        lVar6 = (int64)(int)uVar5;
        lVar2 = PlotController.attriIndexCache;
        if (lVar2 == null) goto LAB_1805ae767;
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
          lVar2 = FUN_1802106e0(0);
          if (((lVar2 == null) || (*(int64 *)(lVar2 + 32) == 0)) ||
             (lVar2 = WorldData.GetArea(*(int64 *)(lVar2 + 32),this.bigMapTargetID,0),
             lVar2 == null)) goto LAB_1805ae767;
          uVar3 = AreaData.GetAreaName(lVar2,0);
          break;
        case 2:
        case 3:
        case 4:
        case 8:
        case 9:
        case 10:
          goto switchD_1805ae4dc_caseD_2;
        case 6:
          lVar2 = *(int64 *)(pStatics + 0x4b8);
          goto LAB_1805ae597;
        case 7:
          lVar2 = *(int64 *)(pStatics + 0x440);
        LAB_1805ae597:
          uVar1 = Int32.Parse(this.aiStuffTarget,0);
          if (lVar2 == null) goto LAB_1805ae767;
          uVar3 = FUN_1800024b0(lVar2,uVar1,DAT_181e86970);
          break;
        case 11:
        case 12:
        case 13:
          lVar2 = FUN_1802106e0(0);
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
              lVar2 = FUN_1802106e0(0);
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
          goto LAB_1805ae767;
        default:
          if (uVar5 != 18) {
            return uVar4;
          }
        case 5:
          lVar2 = FUN_180210740(0);
          uVar1 = Int32.Parse(this.aiStuffTarget,0);
          if ((lVar2 == null) || (lVar2 = GameDataController.GetSkillDataBase(lVar2,uVar1,0)) == null) {
        LAB_1805ae767:
                          // WARNING: Subroutine does not return
            FUN_1801e0300();
          }
          uVar3 = KungfuSkillData.Name(lVar2,1,0);
        }
        uVar4 = String.Concat(uVar4,uVar3,0);
        switchD_1805ae4dc_caseD_2:
        return uVar4;
    }

    // Token : 0x60009BE
    // RVA   : 0x5AE850   Offset: 0x5AD650   Length: 0xBF
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

    // Token : 0x60009BF
    // RVA   : 0x5AE7E0   Offset: 0x5AD5E0   Length: 0x69
    public void ResetBigmapWaitTime()
    {
        uint uVar1;
        uVar1 = GlobalData.RandomRange(0x3f800000,0x41c00000,0,0);
        this.bigmapWaitTime = uVar1;
    }

    // Token : 0x60009C0
    // RVA   : 0x5AE260   Offset: 0x5AD060   Length: 0x16A
    public virtual object Clone()
    {
        long lVar1;
        ulong uVar2;
        long lVar3;
        lVar1 = il2cpp_internal(DAT_181e55950);
        *(uint32 *)(lVar1 + 48) = 0xffffffff;
        uVar2 = new c.DisplayClass9_0(0);
        *(uint64 *)(lVar1 + 56) = uVar2;
        ZhSegment.Initialize(lVar1,0);
        *(uint32 *)(lVar1 + 16) = this.aiStuffType;
        *(uint8 *)(lVar1 + 20) = this.isPassiveTarget;
        *(uint64 *)(lVar1 + 24) = this.aiStuffTarget;
        *(uint32 *)(lVar1 + 32) = this.keepWorkingTimeLeft;
        *(uint32 *)(lVar1 + 36) = this.keepWorkingTimeContine;
        *(uint32 *)(lVar1 + 40) = this.leaveForceTime;
        *(uint8 *)(lVar1 + 44) = this.needCheckEquipment;
        *(uint8 *)(lVar1 + 45) = this.needCheckSkill;
        *(uint8 *)(lVar1 + 46) = this.needCheckSpeMed;
        *(uint32 *)(lVar1 + 48) = this.bigMapTargetID;
        if (this.bigMapTargetPos == null) {
          lVar3 = 0;
        LAB_1805ae396:
          *(int64 *)(lVar1 + 56) = lVar3;
          *(uint32 *)(lVar1 + 64) = this.bigmapWaitTime;
          return lVar1;
        }
        lVar3 = new c.DisplayClass9_0(0);
        if ((this.bigMapTargetPos != null) && (lVar3 != null)) {
          *(uint32 *)(lVar3 + 16) = this.bigMapTargetPos.x;
          if (this.bigMapTargetPos != null) {
            *(uint32 *)(lVar3 + 20) = this.bigMapTargetPos.y;
            goto LAB_1805ae396;
          }
        }
    }

}
