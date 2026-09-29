// ============================================================
// Type  : HeroAIData
// Token : 0x2000134
// ============================================================

public class HeroAIData
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x400078C
    public AIStuffType aiStuffType;

    // Token: 0x400078D
    public bool isPassiveTarget;

    // Token: 0x400078E
    public string aiStuffTarget;

    // Token: 0x400078F
    public int keepWorkingTimeLeft;

    // Token: 0x4000790
    public int keepWorkingTimeContine;

    // Token: 0x4000791
    public float leaveForceTime;

    // Token: 0x4000792
    public bool needCheckEquipment;

    // Token: 0x4000793
    public bool needCheckSkill;

    // Token: 0x4000794
    public bool needCheckSpeMed;

    // Token: 0x4000795
    public int bigMapTargetID;

    // Token: 0x4000796
    public BigMapPos bigMapTargetPos;

    // Token: 0x4000797
    public float bigmapWaitTime;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60009D9
    // RVA   : 0x8767A0   Offset: 0x875BA0   Length: 0x6C
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
        if (((*(byte *)(DAT_181da9df8 + 0x133) & 4) != 0) && (*(int *)(DAT_181da9df8 + 224) == 0)) {
          il2cpp_runtime_class_init(DAT_181da9df8);
          param_2 = this.aiStuffType;
        }
        lVar4 = *(int64 *)(*(int64 *)(DAT_181da9df8 + 184) + 16);
        if (lVar4 == null) goto LAB_180876a00;
        cVar1 = FUN_18182a9b0(lVar4,param_2,DAT_181d7aea0);
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
                goto LAB_18087691c;
              }
            }
        LAB_180876a00:
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          HeroAIData.WandererLoseTarget(this,0);
        }
        LAB_18087691c:
        this.aiStuffTarget = param_3;
        this.isPassiveTarget = param_5;
        this.keepWorkingTimeLeft = param_4;
    }

    // Token : 0x60009DA
    // RVA   : 0x876510   Offset: 0x875910   Length: 0x8C
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
        if (((*(byte *)(DAT_181da9df8 + 0x133) & 4) != 0) && (*(int *)(DAT_181da9df8 + 224) == 0)) {
          il2cpp_runtime_class_init(DAT_181da9df8);
          _aiStuffType = this.aiStuffType;
        }
        lVar4 = *(int64 *)(*(int64 *)(DAT_181da9df8 + 184) + 16);
        if (lVar4 == null) goto LAB_180876a00;
        cVar1 = FUN_18182a9b0(lVar4,_aiStuffType,DAT_181d7aea0);
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
                goto LAB_18087691c;
              }
            }
        LAB_180876a00:
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          HeroAIData.WandererLoseTarget(this,0);
        }
        LAB_18087691c:
        this.aiStuffTarget = _keepWorkingTimeLeft;
        this.isPassiveTarget = param_5;
        this.keepWorkingTimeLeft = param_4;
    }

    // Token : 0x60009DB
    // RVA   : 0x8765A0   Offset: 0x8759A0   Length: 0x1F6
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
        if (((*(byte *)(DAT_181da9df8 + 0x133) & 4) != 0) && (*(int *)(DAT_181da9df8 + 224) == 0)) {
          il2cpp_runtime_class_init(DAT_181da9df8);
          _aiStuffType = this.aiStuffType;
        }
        lVar4 = *(int64 *)(*(int64 *)(DAT_181da9df8 + 184) + 16);
        if (lVar4 == null) goto LAB_180876a00;
        cVar1 = FUN_18182a9b0(lVar4,_aiStuffType,DAT_181d7aea0);
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
                goto LAB_18087691c;
              }
            }
        LAB_180876a00:
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          HeroAIData.WandererLoseTarget(this,0);
        }
        LAB_18087691c:
        this.aiStuffTarget = _aiStuffTarget;
        this.isPassiveTarget = param_5;
        this.keepWorkingTimeLeft = _keepWorkingTimeLeft;
    }

    // Token : 0x60009DC
    // RVA   : 0x876810   Offset: 0x875C10   Length: 0x1FE
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
        if (((*(byte *)(DAT_181da9df8 + 0x133) & 4) != 0) && (*(int *)(DAT_181da9df8 + 224) == 0)) {
          il2cpp_runtime_class_init(DAT_181da9df8);
          _aiStuffType = this.aiStuffType;
        }
        lVar4 = *(int64 *)(*(int64 *)(DAT_181da9df8 + 184) + 16);
        if (lVar4 == null) goto LAB_180876a00;
        cVar1 = FUN_18182a9b0(lVar4,_aiStuffType,DAT_181d7aea0);
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
                goto LAB_18087691c;
              }
            }
        LAB_180876a00:
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          HeroAIData.WandererLoseTarget(this,0);
        }
        LAB_18087691c:
        this.aiStuffTarget = _aiStuffTarget;
        this.isPassiveTarget = _isPassiveTarget;
        this.keepWorkingTimeLeft = _keepWorkingTimeLeft;
    }

    // Token : 0x60009DD
    // RVA   : 0x8763B0   Offset: 0x8757B0   Length: 0x24
    public void ResetBigmapTarget()
    {
        this.bigMapTargetID = 0xffffffff;
        if (this.bigMapTargetPos != null) {
          BigMapPos.Reset(this.bigMapTargetPos,0);
          return;
        }
    }

    // Token : 0x60009DE
    // RVA   : 0x875FD0   Offset: 0x8753D0   Length: 0x3A0
    public string GetDescribe()
    {
        var pStatics = *(int64*)(DAT_181d73d40 + 184);
        uint uVar1;
        long lVar2;
        ulong uVar3;
        ulong uVar4;
        uint uVar5;
        long lVar6;
        uVar5 = this.aiStuffType;
        lVar6 = (int64)(int)uVar5;
        lVar2 = PlotController.attriIndexCache;
        if (lVar2 == null) goto LAB_180876367;
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
             lVar2 == null)) goto LAB_180876367;
          uVar3 = AreaData.GetAreaName(lVar2,0);
          break;
        case 2:
        case 3:
        case 4:
        case 8:
        case 9:
        case 10:
          goto switchD_1808760dc_caseD_2;
        case 6:
          lVar2 = *(int64 *)(pStatics + 0x4b0);
          goto LAB_180876197;
        case 7:
          lVar2 = *(int64 *)(pStatics + 0x438);
        LAB_180876197:
          uVar1 = Int32.Parse(this.aiStuffTarget,0);
          if (lVar2 == null) goto LAB_180876367;
          uVar3 = FUN_180002f80(lVar2,uVar1,DAT_181da4370);
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
          goto LAB_180876367;
        default:
          if (uVar5 != 18) {
            return uVar4;
          }
        case 5:
          lVar2 = FUN_18046c100(0);
          uVar1 = Int32.Parse(this.aiStuffTarget,0);
          if ((lVar2 == null) || (lVar2 = GameDataController.GetSkillDataBase(lVar2,uVar1,0)) == null) {
        LAB_180876367:
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          uVar3 = KungfuSkillData.Name(lVar2,1,0);
        }
        uVar4 = String.Concat(uVar4,uVar3,0);
        switchD_1808760dc_caseD_2:
        return uVar4;
    }

    // Token : 0x60009DF
    // RVA   : 0x876450   Offset: 0x875850   Length: 0xBF
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

    // Token : 0x60009E0
    // RVA   : 0x8763E0   Offset: 0x8757E0   Length: 0x69
    public void ResetBigmapWaitTime()
    {
        uint uVar1;
        uVar1 = GlobalData.RandomRange(0x3f800000,0x41c00000,0,0);
        this.bigmapWaitTime = uVar1;
    }

    // Token : 0x60009E1
    // RVA   : 0x875E50   Offset: 0x875250   Length: 0x175
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
        plVar1 = (int64 *)il2cpp_internal(DAT_181d89228);
        plVar4 = plVar1;
        MemoryStream.ctor(plVar1,1000,0);
        local_38 = 0;
        uStack_30 = 0;
        StreamingContext.ctor(&local_38,64,0);
        lVar2 = il2cpp_internal(DAT_181db1748);
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
            FUN_180002970(0,DAT_181d78db8,plVar1);
            return uVar3;
          }
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
    }

}
