// ============================================================
// Type  : HorseData
// Token : 0x200023D
// ============================================================

public class HorseData
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001170
    public bool equiped;

    // Token: 0x4001171
    public float speed;

    // Token: 0x4001172
    public float power;

    // Token: 0x4001173
    public float sprint;

    // Token: 0x4001174
    public float resist;

    // Token: 0x4001175
    public float speedAdd;

    // Token: 0x4001176
    public float powerAdd;

    // Token: 0x4001177
    public float sprintAdd;

    // Token: 0x4001178
    public float resistAdd;

    // Token: 0x4001179
    public float maxWeightAdd;

    // Token: 0x400117A
    public float nowPower;

    // Token: 0x400117B
    public float favorRate;

    // Token: 0x400117C
    public float sprintTimeLeft;

    // Token: 0x400117D
    public float sprintTimeCd;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60012B2
    // RVA   : 0x210B70   Offset: 0x20F370   Length: 0x7
    public void /*ctor*/()
    {
        uint uVar1;
        uint uVar2;
        long lVar3;
        long lVar4;
        int iVar5;
        ZhSegment.Initialize(this,0);
        lVar3 = il2cpp_internal(DAT_181d6f030);
        FUN_180f58a90(lVar3,DAT_181d678f8);
        iVar5 = 0;
        while( true ) {
          uVar1 = GlobalData.RandomRange(0,param_2 + 1,0,0);
          if (lVar3 == null) break;
          FUN_181814fa0(lVar3,uVar1);
          iVar5 = iVar5 + 1;
          if (2 < iVar5) {
            List_1.Sort(lVar3,DAT_181d67ff0);
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

    // Token : 0x60012B3
    // RVA   : 0xB40340   Offset: 0xB3EB40   Length: 0x1DB
    public void /*ctor*/(int totalNum)
    {
        uint uVar1;
        uint uVar2;
        long lVar3;
        long lVar4;
        int iVar5;
        ZhSegment.Initialize(this,0);
        lVar3 = il2cpp_internal(DAT_181d6f030);
        FUN_180f58a90(lVar3,DAT_181d678f8);
        iVar5 = 0;
        while( true ) {
          uVar1 = GlobalData.RandomRange(0,totalNum + 1,0,0);
          if (lVar3 == null) break;
          FUN_181814fa0(lVar3,uVar1);
          iVar5 = iVar5 + 1;
          if (2 < iVar5) {
            List_1.Sort(lVar3,DAT_181d67ff0);
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

    // Token : 0x60012B4
    // RVA   : 0xB402C0   Offset: 0xB3EAC0   Length: 0x7A
    public void StartSprint()
    {
        var pStatics = *(int64*)(DAT_181d4ef00 + 184);
        this.sprintTimeLeft = *(uint32 *)(pStatics + 0x218);
        this.sprintTimeCd = *(uint32 *)(pStatics + 0x21c);
    }

    // Token : 0x60012B5
    // RVA   : 0xB3F540   Offset: 0xB3DD40   Length: 0x30
    public void ChangeFavorRate(float delta)
    {
        uint uVar1;
        uVar1 = FUN_1810a8ba0(this.favorRate + delta,0,0x3f800000,0);
        this.favorRate = uVar1;
    }

    // Token : 0x60012B6
    // RVA   : 0xB401E0   Offset: 0xB3E9E0   Length: 0x63
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

    // Token : 0x60012B7
    // RVA   : 0xB40030   Offset: 0xB3E830   Length: 0x63
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

    // Token : 0x60012B8
    // RVA   : 0xB40250   Offset: 0xB3EA50   Length: 0x63
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

    // Token : 0x60012B9
    // RVA   : 0xB40170   Offset: 0xB3E970   Length: 0x63
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

    // Token : 0x60012BA
    // RVA   : 0xB3FFC0   Offset: 0xB3E7C0   Length: 0x6B
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

    // Token : 0x60012BB
    // RVA   : 0xB3F620   Offset: 0xB3DE20   Length: 0x6D
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

    // Token : 0x60012BC
    // RVA   : 0xB400A0   Offset: 0xB3E8A0   Length: 0x73
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

    // Token : 0x60012BD
    // RVA   : 0xB3F570   Offset: 0xB3DD70   Length: 0xA6
    public void ChangeNowPower(float delta)
    {
        uint uVar1;
        HorseData.GetHorseStateSpeAdd(this,this.power,0);
        uVar1 = FUN_1810a8ba0();
        this.nowPower = uVar1;
    }

    // Token : 0x60012BE
    // RVA   : 0xB3F4F0   Offset: 0xB3DCF0   Length: 0x4F
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

    // Token : 0x60012BF
    // RVA   : 0xB3F4A0   Offset: 0xB3DCA0   Length: 0x4F
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

    // Token : 0x60012C0
    // RVA   : 0xB40120   Offset: 0xB3E920   Length: 0x4F
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

    // Token : 0x60012C1
    // RVA   : 0xB3FDF0   Offset: 0xB3E5F0   Length: 0x1C9
    public int GetHorseStateSpeAdd(float originState)
    {
        var pStatics = *(int64*)(DAT_181d4df90 + 184);
        bool cVar1;
        long lVar2;
        if (!this.equiped) {
          return 0;
        }
        if (((*pStatics != 0) &&
            (lVar2 = *(int64 *)(*pStatics + 32)) != null) &&
           (lVar2 = WorldData.Player(lVar2,0)) != null) {
          if (*(int64 *)(lVar2 + 0x208) == 0) {
            return 0;
          }
          lVar2 = FUN_18046c0a0(0);
          if (((lVar2 != null) && (*(int64 *)(lVar2 + 32) != 0)) &&
             ((lVar2 = WorldData.Player(*(int64 *)(lVar2 + 32),0), lVar2 != null &&
              (*(int64 *)(lVar2 + 0x208) != 0)))) {
            if (*(int64 *)(*(int64 *)(lVar2 + 0x208) + 136) != this) {
              return 0;
            }
            lVar2 = FUN_18046c0a0(0);
            if (((lVar2 != null) && (*(int64 *)(lVar2 + 32) != 0)) &&
               (lVar2 = WorldData.Player(*(int64 *)(lVar2 + 32),0)) != null) {
              cVar1 = HeroData.HaveForceFunction(lVar2,4);
              if (!cVar1) {
                return 0;
              }
              return (int)(this.favorRate * 0.2 * originState);
            }
          }
        }
    }

    // Token : 0x60012C2
    // RVA   : 0xB3F690   Offset: 0xB3DE90   Length: 0x75E
    public string GetDescribe()
    {
        float fVar1;
        int iVar2;
        long lVar4;
        long lVar5;
        ulong uVar6;
        plVar3 = (int64 *)FUN_1800d60b0(DAT_181d80cc0,12);
        if (plVar3 == (int64 *)0) {
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
        if (("速度 " != 0) &&
           (lVar4 = il2cpp_internal("速度 ",*(uint64 *)(*plVar3 + 64))) == null) {
          uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
          FUN_1800d65f0(uVar6,0);
        }
        lVar4 = "速度 ";
        if ((int)plVar3[3] == 0) {
          uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
          FUN_1800d65f0(uVar6,0);
        }
        plVar3[4] = "速度 ";
        il2cpp_internal(plVar3 + 4,lVar4);
        lVar4 = Single.ToString(this + 20,0);
        if ((lVar4 != null) &&
           (lVar5 = il2cpp_internal(lVar4,*(uint64 *)(*plVar3 + 64))) == null) {
          uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
          FUN_1800d65f0(uVar6,0);
        }
        if (*(uint32 *)(plVar3 + 3) < 2) {
          uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
          FUN_1800d65f0(uVar6,0);
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
          FUN_1800d65f0(uVar6,0);
        }
        if (*(uint32 *)(plVar3 + 3) < 3) {
          uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
          FUN_1800d65f0(uVar6,0);
        }
        plVar3[6] = lVar4;
        il2cpp_internal(plVar3 + 6,lVar4);
        if (("\n冲刺 " != 0) &&
           (lVar4 = il2cpp_internal("\n冲刺 ",*(uint64 *)(*plVar3 + 64))) == null) {
          uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
          FUN_1800d65f0(uVar6,0);
        }
        lVar4 = "\n冲刺 ";
        if (*(uint32 *)(plVar3 + 3) < 4) {
          uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
          FUN_1800d65f0(uVar6,0);
        }
        plVar3[7] = "\n冲刺 ";
        il2cpp_internal(plVar3 + 7,lVar4);
        lVar4 = Single.ToString(this + 28,0);
        if ((lVar4 != null) &&
           (lVar5 = il2cpp_internal(lVar4,*(uint64 *)(*plVar3 + 64))) == null) {
          uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
          FUN_1800d65f0(uVar6,0);
        }
        if (*(uint32 *)(plVar3 + 3) < 5) {
          uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
          FUN_1800d65f0(uVar6,0);
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
          FUN_1800d65f0(uVar6,0);
        }
        if (*(uint32 *)(plVar3 + 3) < 6) {
          uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
          FUN_1800d65f0(uVar6,0);
        }
        plVar3[9] = lVar4;
        il2cpp_internal(plVar3 + 9,lVar4);
        if (("\n耐力 " != 0) &&
           (lVar4 = il2cpp_internal("\n耐力 ",*(uint64 *)(*plVar3 + 64))) == null) {
          uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
          FUN_1800d65f0(uVar6,0);
        }
        lVar4 = "\n耐力 ";
        if (*(uint32 *)(plVar3 + 3) < 7) {
          uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
          FUN_1800d65f0(uVar6,0);
        }
        plVar3[10] = "\n耐力 ";
        il2cpp_internal(plVar3 + 10,lVar4);
        lVar4 = Single.ToString(this + 24,0);
        if ((lVar4 != null) &&
           (lVar5 = il2cpp_internal(lVar4,*(uint64 *)(*plVar3 + 64))) == null) {
          uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
          FUN_1800d65f0(uVar6,0);
        }
        if (*(uint32 *)(plVar3 + 3) < 8) {
          uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
          FUN_1800d65f0(uVar6,0);
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
          FUN_1800d65f0(uVar6,0);
        }
        if (*(uint32 *)(plVar3 + 3) < 9) {
          uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
          FUN_1800d65f0(uVar6,0);
        }
        plVar3[12] = lVar4;
        il2cpp_internal(plVar3 + 12,lVar4);
        if (("\n坚韧 " != 0) &&
           (lVar4 = il2cpp_internal("\n坚韧 ",*(uint64 *)(*plVar3 + 64))) == null) {
          uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
          FUN_1800d65f0(uVar6,0);
        }
        lVar4 = "\n坚韧 ";
        if (*(uint32 *)(plVar3 + 3) < 10) {
          uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
          FUN_1800d65f0(uVar6,0);
        }
        plVar3[13] = "\n坚韧 ";
        il2cpp_internal(plVar3 + 13,lVar4);
        lVar4 = Single.ToString(this + 32,0);
        if ((lVar4 != null) &&
           (lVar5 = il2cpp_internal(lVar4,*(uint64 *)(*plVar3 + 64))) == null) {
          uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
          FUN_1800d65f0(uVar6,0);
        }
        if (*(uint32 *)(plVar3 + 3) < 11) {
          uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
          FUN_1800d65f0(uVar6,0);
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
          FUN_1800d65f0(uVar6,0);
        }
        if (11 < *(uint32 *)(plVar3 + 3)) {
          plVar3[15] = lVar4;
          il2cpp_internal(plVar3 + 15,lVar4);
          String.Concat(plVar3,0);
          return;
        }
        uVar6 = il2cpp_internal();
    }

}
