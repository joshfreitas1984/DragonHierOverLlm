// ============================================================
// Type  : HorseData
// Token : 0x2000247
// ============================================================

public class HorseData
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001231
    public bool equiped;

    // Token: 0x4001232
    public float speed;

    // Token: 0x4001233
    public float power;

    // Token: 0x4001234
    public float sprint;

    // Token: 0x4001235
    public float resist;

    // Token: 0x4001236
    public float speedAdd;

    // Token: 0x4001237
    public float powerAdd;

    // Token: 0x4001238
    public float sprintAdd;

    // Token: 0x4001239
    public float resistAdd;

    // Token: 0x400123A
    public float maxWeightAdd;

    // Token: 0x400123B
    public float nowPower;

    // Token: 0x400123C
    public float favorRate;

    // Token: 0x400123D
    public float sprintTimeLeft;

    // Token: 0x400123E
    public float sprintTimeCd;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6001316
    // RVA   : 0x42F150   Offset: 0x42DF50   Length: 0x7
    public void /*ctor*/()
    {
        uint uVar1;
        uint uVar2;
        long lVar3;
        long lVar4;
        int iVar5;
        ZhSegment.Initialize(this,0);
        lVar3 = il2cpp_internal(DAT_181e73cb8);
        FUN_1810f3480(lVar3,DAT_181e71270);
        iVar5 = 0;
        while( true ) {
          uVar1 = GlobalData.RandomRange(0,param_2 + 1,0,0);
          if (lVar3 == null) break;
          FUN_181769fe0(lVar3,uVar1);
          iVar5 = iVar5 + 1;
          if (2 < iVar5) {
            List_1.Sort(lVar3,DAT_181e71970);
            if (*(int *)(lVar3 + 24) == 0) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            this.speed = (float)*(int *)(*(int64 *)(lVar3 + 16) + 32);
            uVar2 = *(uint32 *)(lVar3 + 24);
            if (uVar2 < 2) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
              uVar2 = *(uint32 *)(lVar3 + 24);
            }
            lVar4 = *(int64 *)(lVar3 + 16);
            iVar5 = *(int *)(lVar4 + 36);
            if (uVar2 == 0) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
              lVar4 = *(int64 *)(lVar3 + 16);
            }
            this.power = (float)(iVar5 - *(int *)(lVar4 + 32));
            uVar2 = *(uint32 *)(lVar3 + 24);
            if (uVar2 < 3) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
              uVar2 = *(uint32 *)(lVar3 + 24);
            }
            lVar4 = *(int64 *)(lVar3 + 16);
            iVar5 = *(int *)(lVar4 + 40);
            if (uVar2 < 2) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
              lVar4 = *(int64 *)(lVar3 + 16);
            }
            this.sprint = (float)(iVar5 - *(int *)(lVar4 + 36));
            if (*(uint32 *)(lVar3 + 24) < 3) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            this.resist = (float)(param_2 - *(int *)(*(int64 *)(lVar3 + 16) + 40));
            return;
          }
        }
    }

    // Token : 0x6001317
    // RVA   : 0x8A3BD0   Offset: 0x8A29D0   Length: 0x1DB
    public void /*ctor*/(int totalNum)
    {
        uint uVar1;
        uint uVar2;
        long lVar3;
        long lVar4;
        int iVar5;
        ZhSegment.Initialize(this,0);
        lVar3 = il2cpp_internal(DAT_181e73cb8);
        FUN_1810f3480(lVar3,DAT_181e71270);
        iVar5 = 0;
        while( true ) {
          uVar1 = GlobalData.RandomRange(0,totalNum + 1,0,0);
          if (lVar3 == null) break;
          FUN_181769fe0(lVar3,uVar1);
          iVar5 = iVar5 + 1;
          if (2 < iVar5) {
            List_1.Sort(lVar3,DAT_181e71970);
            if (*(int *)(lVar3 + 24) == 0) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            this.speed = (float)*(int *)(*(int64 *)(lVar3 + 16) + 32);
            uVar2 = *(uint32 *)(lVar3 + 24);
            if (uVar2 < 2) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
              uVar2 = *(uint32 *)(lVar3 + 24);
            }
            lVar4 = *(int64 *)(lVar3 + 16);
            iVar5 = *(int *)(lVar4 + 36);
            if (uVar2 == 0) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
              lVar4 = *(int64 *)(lVar3 + 16);
            }
            this.power = (float)(iVar5 - *(int *)(lVar4 + 32));
            uVar2 = *(uint32 *)(lVar3 + 24);
            if (uVar2 < 3) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
              uVar2 = *(uint32 *)(lVar3 + 24);
            }
            lVar4 = *(int64 *)(lVar3 + 16);
            iVar5 = *(int *)(lVar4 + 40);
            if (uVar2 < 2) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
              lVar4 = *(int64 *)(lVar3 + 16);
            }
            this.sprint = (float)(iVar5 - *(int *)(lVar4 + 36));
            if (*(uint32 *)(lVar3 + 24) < 3) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            this.resist = (float)(totalNum - *(int *)(*(int64 *)(lVar3 + 16) + 40));
            return;
          }
        }
    }

    // Token : 0x6001318
    // RVA   : 0x8A3B50   Offset: 0x8A2950   Length: 0x7A
    public void StartSprint()
    {
        var pStatics = *(int64*)(DAT_181e538e8 + 184);
        this.sprintTimeLeft = *(uint32 *)(pStatics + 0x228);
        this.sprintTimeCd = *(uint32 *)(pStatics + 0x22c);
    }

    // Token : 0x6001319
    // RVA   : 0x8A2D20   Offset: 0x8A1B20   Length: 0x30
    public void ChangeFavorRate(float delta)
    {
        uint uVar1;
        uVar1 = FUN_180f34e60(this.favorRate + delta,0,0x3f800000,0);
        this.favorRate = uVar1;
    }

    // Token : 0x600131A
    // RVA   : 0x8A3A70   Offset: 0x8A2870   Length: 0x63
    public float Speed()
    {
        float fVar1;
        float fVar2;
        int iVar3;
        fVar1 = this.speedAdd;
        fVar2 = this.speed;
        iVar3 = HorseData.GetHorseStateSpeAdd();
        return (fVar2 + fVar1 + (float)iVar3) * (this.favorRate * 0.5 + 0.5);
    }

    // Token : 0x600131B
    // RVA   : 0x8A38C0   Offset: 0x8A26C0   Length: 0x63
    public float Power()
    {
        float fVar1;
        float fVar2;
        int iVar3;
        fVar1 = this.powerAdd;
        fVar2 = this.power;
        iVar3 = HorseData.GetHorseStateSpeAdd();
        return (fVar2 + fVar1 + (float)iVar3) * (this.favorRate * 0.5 + 0.5);
    }

    // Token : 0x600131C
    // RVA   : 0x8A3AE0   Offset: 0x8A28E0   Length: 0x63
    public float Sprint()
    {
        float fVar1;
        float fVar2;
        int iVar3;
        fVar1 = this.sprintAdd;
        fVar2 = this.sprint;
        iVar3 = HorseData.GetHorseStateSpeAdd();
        return (fVar2 + fVar1 + (float)iVar3) * (this.favorRate * 0.5 + 0.5);
    }

    // Token : 0x600131D
    // RVA   : 0x8A3A00   Offset: 0x8A2800   Length: 0x63
    public float Resist()
    {
        float fVar1;
        float fVar2;
        int iVar3;
        fVar1 = this.resistAdd;
        fVar2 = this.resist;
        iVar3 = HorseData.GetHorseStateSpeAdd();
        return (fVar2 + fVar1 + (float)iVar3) * (this.favorRate * 0.5 + 0.5);
    }

    // Token : 0x600131E
    // RVA   : 0x8A3850   Offset: 0x8A2650   Length: 0x6B
    public float MaxPower()
    {
        float fVar1;
        float fVar2;
        int iVar3;
        fVar1 = this.powerAdd;
        fVar2 = this.power;
        iVar3 = HorseData.GetHorseStateSpeAdd();
        return (fVar2 + fVar1 + (float)iVar3) * (this.favorRate * 0.5 + 0.5) + 50.0;
    }

    // Token : 0x600131F
    // RVA   : 0x8A2EB0   Offset: 0x8A1CB0   Length: 0x6D
    public void FullFillPower()
    {
        float fVar1;
        float fVar2;
        int iVar3;
        fVar1 = this.powerAdd;
        fVar2 = this.power;
        iVar3 = HorseData.GetHorseStateSpeAdd(this,fVar2,0);
        this.nowPower =
             (fVar2 + fVar1 + (float)iVar3) * (this.favorRate * 0.5 + 0.5) + 50.0;
    }

    // Token : 0x6001320
    // RVA   : 0x8A3930   Offset: 0x8A2730   Length: 0x73
    public void RefreshState()
    {
        float fVar1;
        float fVar2;
        int iVar3;
        fVar1 = this.powerAdd;
        fVar2 = this.power;
        iVar3 = HorseData.GetHorseStateSpeAdd(this,fVar2,0);
        this.sprintTimeLeft = 0;
        this.nowPower =
             (fVar2 + fVar1 + (float)iVar3) * (this.favorRate * 0.5 + 0.5) + 50.0;
    }

    // Token : 0x6001321
    // RVA   : 0x8A2D50   Offset: 0x8A1B50   Length: 0xA6
    public void ChangeNowPower(float delta)
    {
        uint uVar1;
        HorseData.GetHorseStateSpeAdd(this,this.power,0);
        uVar1 = FUN_180f34e60();
        this.nowPower = uVar1;
    }

    // Token : 0x6001322
    // RVA   : 0x8A2CD0   Offset: 0x8A1AD0   Length: 0x4F
    public void Add(HorseData target)
    {
        if (target != null) {
          this.speed = *(float *)(target + 20) + this.speed;
          this.power = *(float *)(target + 24) + this.power;
          this.sprint = *(float *)(target + 28) + this.sprint;
          this.resist = *(float *)(target + 32) + this.resist;
          return;
        }
    }

    // Token : 0x6001323
    // RVA   : 0x8A2C80   Offset: 0x8A1A80   Length: 0x4F
    public void AddHorseArmor(HorseData target)
    {
        if (target != null) {
          this.speedAdd = *(float *)(target + 20) + this.speedAdd;
          this.powerAdd = *(float *)(target + 24) + this.powerAdd;
          this.sprintAdd = *(float *)(target + 28) + this.sprintAdd;
          this.resistAdd = *(float *)(target + 32) + this.resistAdd;
          return;
        }
    }

    // Token : 0x6001324
    // RVA   : 0x8A39B0   Offset: 0x8A27B0   Length: 0x4F
    public void RemoveHorseArmor(HorseData target)
    {
        if (target != null) {
          this.speedAdd = this.speedAdd - *(float *)(target + 20);
          this.powerAdd = this.powerAdd - *(float *)(target + 24);
          this.sprintAdd = this.sprintAdd - *(float *)(target + 28);
          this.resistAdd = this.resistAdd - *(float *)(target + 32);
          return;
        }
    }

    // Token : 0x6001325
    // RVA   : 0x8A3680   Offset: 0x8A2480   Length: 0x1C9
    public int GetHorseStateSpeAdd(float originState)
    {
        bool cVar1;
        long lVar2;
        if (!this.equiped) {
          return 0;
        }
        if (((GameController._instance != null) &&
            (lVar2 = GameController._instance.worldData) != null) &&
           (lVar2 = WorldData.Player(lVar2,0)) != null) {
          if (lVar2.getSpePoisonData == null) {
            return 0;
          }
          lVar2 = FUN_1802106e0(0);
          if (((lVar2 != null) && (lVar2.villageAreaID != null)) &&
             ((lVar2 = WorldData.Player(lVar2.villageAreaID,0), lVar2 != null &&
              (lVar2.getSpePoisonData != null)))) {
            if (*(int64 *)(lVar2.getSpePoisonData + 136) != this) {
              return 0;
            }
            lVar2 = FUN_1802106e0(0);
            if (((lVar2 != null) && (lVar2.villageAreaID != null)) &&
               (lVar2 = WorldData.Player(lVar2.villageAreaID,0)) != null) {
              cVar1 = HeroData.HaveForceFunction(lVar2,4);
              if (!cVar1) {
                return 0;
              }
              return (int)(this.favorRate * 0.2 * originState);
            }
          }
        }
    }

    // Token : 0x6001326
    // RVA   : 0x8A2F20   Offset: 0x8A1D20   Length: 0x75E
    public string GetDescribe()
    {
        float fVar1;
        int iVar2;
        long lVar4;
        long lVar5;
        ulong uVar6;
        plVar3 = (int64 *)FUN_1801dfd90(DAT_181e85e38,12);
        if (plVar3 == (int64 *)0) {
                          // WARNING: Subroutine does not return
          FUN_1801e0300();
        }
        if (("速度 " != 0) &&
           (lVar4 = il2cpp_internal("速度 ",*(uint64 *)(*plVar3 + 64))) == null) {
          uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
          FUN_1801e02d0(uVar6,0);
        }
        lVar4 = "速度 ";
        if ((int)plVar3[3] == 0) {
          uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
          FUN_1801e02d0(uVar6,0);
        }
        plVar3[4] = "速度 ";
        il2cpp_internal(plVar3 + 4,lVar4);
        lVar4 = Single.ToString(this + 20,0);
        if ((lVar4 != null) &&
           (lVar5 = il2cpp_internal(lVar4,*(uint64 *)(*plVar3 + 64))) == null) {
          uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
          FUN_1801e02d0(uVar6,0);
        }
        if (*(uint32 *)(plVar3 + 3) < 2) {
          uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
          FUN_1801e02d0(uVar6,0);
        }
        plVar3[5] = lVar4;
        il2cpp_internal(plVar3 + 5,lVar4);
        fVar1 = this.speedAdd;
        iVar2 = HorseData.GetHorseStateSpeAdd(this);
        lVar4 = "";
        if ((float)iVar2 + fVar1 != 0.0) {
          fVar1 = this.speedAdd;
          iVar2 = HorseData.GetHorseStateSpeAdd(this);
          lVar4 = GlobalData.GenerateChangeColorText(" ",(float)iVar2 + fVar1,0);
        }
        if ((lVar4 != null) &&
           (lVar5 = il2cpp_internal(lVar4,*(uint64 *)(*plVar3 + 64))) == null) {
          uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
          FUN_1801e02d0(uVar6,0);
        }
        if (*(uint32 *)(plVar3 + 3) < 3) {
          uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
          FUN_1801e02d0(uVar6,0);
        }
        plVar3[6] = lVar4;
        il2cpp_internal(plVar3 + 6,lVar4);
        if (("\n冲刺 " != 0) &&
           (lVar4 = il2cpp_internal("\n冲刺 ",*(uint64 *)(*plVar3 + 64))) == null) {
          uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
          FUN_1801e02d0(uVar6,0);
        }
        lVar4 = "\n冲刺 ";
        if (*(uint32 *)(plVar3 + 3) < 4) {
          uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
          FUN_1801e02d0(uVar6,0);
        }
        plVar3[7] = "\n冲刺 ";
        il2cpp_internal(plVar3 + 7,lVar4);
        lVar4 = Single.ToString(this + 28,0);
        if ((lVar4 != null) &&
           (lVar5 = il2cpp_internal(lVar4,*(uint64 *)(*plVar3 + 64))) == null) {
          uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
          FUN_1801e02d0(uVar6,0);
        }
        if (*(uint32 *)(plVar3 + 3) < 5) {
          uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
          FUN_1801e02d0(uVar6,0);
        }
        plVar3[8] = lVar4;
        il2cpp_internal(plVar3 + 8,lVar4);
        fVar1 = this.sprintAdd;
        iVar2 = HorseData.GetHorseStateSpeAdd(this);
        lVar4 = "";
        if ((float)iVar2 + fVar1 != 0.0) {
          fVar1 = this.sprintAdd;
          iVar2 = HorseData.GetHorseStateSpeAdd(this);
          lVar4 = GlobalData.GenerateChangeColorText(" ",(float)iVar2 + fVar1,0);
        }
        if ((lVar4 != null) &&
           (lVar5 = il2cpp_internal(lVar4,*(uint64 *)(*plVar3 + 64))) == null) {
          uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
          FUN_1801e02d0(uVar6,0);
        }
        if (*(uint32 *)(plVar3 + 3) < 6) {
          uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
          FUN_1801e02d0(uVar6,0);
        }
        plVar3[9] = lVar4;
        il2cpp_internal(plVar3 + 9,lVar4);
        if (("\n耐力 " != 0) &&
           (lVar4 = il2cpp_internal("\n耐力 ",*(uint64 *)(*plVar3 + 64))) == null) {
          uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
          FUN_1801e02d0(uVar6,0);
        }
        lVar4 = "\n耐力 ";
        if (*(uint32 *)(plVar3 + 3) < 7) {
          uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
          FUN_1801e02d0(uVar6,0);
        }
        plVar3[10] = "\n耐力 ";
        il2cpp_internal(plVar3 + 10,lVar4);
        lVar4 = Single.ToString(this + 24,0);
        if ((lVar4 != null) &&
           (lVar5 = il2cpp_internal(lVar4,*(uint64 *)(*plVar3 + 64))) == null) {
          uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
          FUN_1801e02d0(uVar6,0);
        }
        if (*(uint32 *)(plVar3 + 3) < 8) {
          uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
          FUN_1801e02d0(uVar6,0);
        }
        plVar3[11] = lVar4;
        il2cpp_internal(plVar3 + 11,lVar4);
        fVar1 = this.powerAdd;
        iVar2 = HorseData.GetHorseStateSpeAdd(this);
        lVar4 = "";
        if ((float)iVar2 + fVar1 != 0.0) {
          fVar1 = this.powerAdd;
          iVar2 = HorseData.GetHorseStateSpeAdd(this);
          lVar4 = GlobalData.GenerateChangeColorText(" ",(float)iVar2 + fVar1,0);
        }
        if ((lVar4 != null) &&
           (lVar5 = il2cpp_internal(lVar4,*(uint64 *)(*plVar3 + 64))) == null) {
          uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
          FUN_1801e02d0(uVar6,0);
        }
        if (*(uint32 *)(plVar3 + 3) < 9) {
          uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
          FUN_1801e02d0(uVar6,0);
        }
        plVar3[12] = lVar4;
        il2cpp_internal(plVar3 + 12,lVar4);
        if (("\n坚韧 " != 0) &&
           (lVar4 = il2cpp_internal("\n坚韧 ",*(uint64 *)(*plVar3 + 64))) == null) {
          uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
          FUN_1801e02d0(uVar6,0);
        }
        lVar4 = "\n坚韧 ";
        if (*(uint32 *)(plVar3 + 3) < 10) {
          uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
          FUN_1801e02d0(uVar6,0);
        }
        plVar3[13] = "\n坚韧 ";
        il2cpp_internal(plVar3 + 13,lVar4);
        lVar4 = Single.ToString(this + 32,0);
        if ((lVar4 != null) &&
           (lVar5 = il2cpp_internal(lVar4,*(uint64 *)(*plVar3 + 64))) == null) {
          uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
          FUN_1801e02d0(uVar6,0);
        }
        if (*(uint32 *)(plVar3 + 3) < 11) {
          uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
          FUN_1801e02d0(uVar6,0);
        }
        plVar3[14] = lVar4;
        il2cpp_internal(plVar3 + 14,lVar4);
        fVar1 = this.resistAdd;
        iVar2 = HorseData.GetHorseStateSpeAdd(this);
        lVar4 = "";
        if ((float)iVar2 + fVar1 != 0.0) {
          fVar1 = this.resistAdd;
          iVar2 = HorseData.GetHorseStateSpeAdd(this);
          lVar4 = GlobalData.GenerateChangeColorText(" ",(float)iVar2 + fVar1,0);
        }
        if ((lVar4 != null) &&
           (lVar5 = il2cpp_internal(lVar4,*(uint64 *)(*plVar3 + 64))) == null) {
          uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
          FUN_1801e02d0(uVar6,0);
        }
        if (11 < *(uint32 *)(plVar3 + 3)) {
          plVar3[15] = lVar4;
          il2cpp_internal(plVar3 + 15,lVar4);
          String.Concat(plVar3,0);
          return;
        }
        uVar6 = il2cpp_internal();
    }

    // Token : 0x6001327
    // RVA   : 0x8A2E00   Offset: 0x8A1C00   Length: 0xAF
    public virtual object Clone()
    {
        long lVar1;
        lVar1 = new ZhSegment(0);
        if (lVar1 != null) {
          *(uint8 *)(lVar1 + 16) = this.equiped;
          *(uint32 *)(lVar1 + 20) = this.speed;
          *(uint32 *)(lVar1 + 24) = this.power;
          *(uint32 *)(lVar1 + 28) = this.sprint;
          *(uint32 *)(lVar1 + 32) = this.resist;
          *(uint32 *)(lVar1 + 36) = this.speedAdd;
          *(uint32 *)(lVar1 + 40) = this.powerAdd;
          *(uint32 *)(lVar1 + 44) = this.sprintAdd;
          *(uint32 *)(lVar1 + 48) = this.resistAdd;
          *(uint32 *)(lVar1 + 52) = this.maxWeightAdd;
          *(uint32 *)(lVar1 + 56) = this.nowPower;
          *(uint32 *)(lVar1 + 60) = this.favorRate;
          *(uint32 *)(lVar1 + 64) = this.sprintTimeLeft;
          *(uint32 *)(lVar1 + 68) = this.sprintTimeCd;
          return lVar1;
        }
    }

}
