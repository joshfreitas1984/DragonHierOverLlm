// ============================================================
// Type  : HorseIconController
// Token : 0x20002D4
// ============================================================

public class HorseIconController
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x40016B7
    public ItemData targetHorseData;

    // Token: 0x40016B8
    public GameObject horseIcon;

    // Token: 0x40016B9
    public GameObject horseBack;

    // Token: 0x40016BA
    public GameObject horseFavorBar;

    // Token: 0x40016BB
    public GameObject horsePowerBar;

    // Token: 0x40016BC
    public GameObject horseSpringBar;

    // Token: 0x40016BD
    public GameObject bigmapColliderText;

    // Token: 0x40016BE
    public GameObject bigmapSpeedText;

    // Token: 0x40016BF
    public GameObject overWeightText;

    // Token: 0x40016C0
    public GameObject bigmapSpeEffText;

    // Token: 0x40016C1
    public GameObject quickButtonTips;

    // Token: 0x40016C2
    public bool horseMatchIcon;

    // Token: 0x40016C3
    private float freshTime;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60017DD
    // RVA   : 0xB40B00   Offset: 0xB3F300   Length: 0x29BE
    private void Update()
    {
        var pStatics_6270 = *(int64*)(DAT_181d86270 + 184);
        var pStatics_baa8 = *(int64*)(DAT_181d8baa8 + 184);
        var pStatics_bc28 = *(int64*)(DAT_181d8bc28 + 184);
        var pStatics_df90 = *(int64*)(DAT_181d4df90 + 184);
        var pStatics_ef00 = *(int64*)(DAT_181d4ef00 + 184);
        uint uVar2;
        bool cVar3;
        long lVar4;
        ulong uVar5;
        ulong uVar6;
        long lVar8;
        long lVar9;
        float fVar11;
        float fVar12;
        float[] local_res8 = new float[2];
        ulong local_78;
        uint uStack_70;
        uint32 uStack_6c;
        uint64 local_68;
        uint64 uStack_60;
        fVar11 = this.freshTime;
        local_res8[0] = 0.0;
        if (0.0 < fVar11) {
          fVar12 = (float)Time.get_deltaTime(0);
          this.freshTime = fVar11 - fVar12;
          return;
        }
        this.freshTime = 0x3dcccccd;
        if (!this.horseMatchIcon) {
          lVar4 = FUN_18046bbe0(0);
          if (lVar4 == null) goto LAB_180b434b9;
          uVar5 = lVar4.setName;
          cVar3 = Object.op_Inequality(uVar5,0,0);
          if (cVar3) {
            if (this.bigmapSpeedText == null) goto LAB_180b434b9;
            uVar5 = GameObject.GetComponent(this.bigmapSpeedText,DAT_181da1eb0);
            lVar4 = FUN_18046bbe0(0);
            if (((lVar4 == null) || (lVar4.setName == null)) ||
               (lVar4 = GameObject.GetComponent(lVar4.setName,DAT_181d9e910)) == null)
            goto LAB_180b434b9;
            local_res8[0] = (float)BigmapNpcController.GetBigMapTravelSpeed(lVar4,0);
        LAB_180b40f2e:
            local_res8[0] = local_res8[0] * 100.0;
            uVar6 = Single.ToString(local_res8,"f0",0);
            uVar6 = String.Concat("速度",uVar6,"%",0);
            LTLocalization.SetText(uVar5,uVar6,0);
          }
        }
        else {
          lVar4 = FUN_18046c260(0);
          if (lVar4 == null) goto LAB_180b434b9;
          uVar5 = lVar4.poisonNumDetected;
          cVar3 = Object.op_Inequality(uVar5,0,0);
          if (cVar3) {
            if (this.bigmapSpeedText == null) goto LAB_180b434b9;
            uVar5 = GameObject.GetComponent(this.bigmapSpeedText,DAT_181da1eb0);
            lVar4 = FUN_18046c260(0);
            if (((lVar4 == null) || (lVar4.poisonNumDetected == null)) ||
               (lVar4 = GameObject.GetComponent(lVar4.poisonNumDetected,DAT_181d9fdc8)) == null)
            goto LAB_180b434b9;
            local_res8[0] = (float)HorseMatchHeroController.GetFinalTravelSpeed(lVar4,0);
            goto LAB_180b40f2e;
          }
        }
        if (((this.bigmapSpeedText == null) ||
            (lVar4 = GameObject.get_transform(this.bigmapSpeedText,0)) == null) ||
           ((lVar4 = FUN_180da0f00(lVar4,0), lVar4 == null ||
            (lVar4 = Component.GetComponent(lVar4,DAT_181d6ccc0)) == null))) goto LAB_180b434b9;
        lVar4.subType = "基础 100%";
        if (((*pStatics_df90 == 0) ||
            (lVar4 = *(int64 *)(*pStatics_df90 + 32)) == null) ||
           (lVar4 = WorldData.Player(lVar4,0)) == null) goto LAB_180b434b9;
        fVar11 = (float)HeroData.GetHorseTravelSpeed(lVar4,0);
        if (fVar11 != 0.0) {
          if (((this.bigmapSpeedText == null) ||
              (lVar4 = GameObject.get_transform(this.bigmapSpeedText,0)) == null) ||
             ((lVar4 = FUN_180da0f00(lVar4,0), lVar4 == null ||
              (lVar4 = Component.GetComponent(lVar4,DAT_181d6ccc0)) == null))) goto LAB_180b434b9;
          uVar5 = lVar4.subType;
          lVar4 = FUN_18046c0a0(0);
          if (((lVar4 == null) || (lVar4.name == null)) ||
             (lVar4 = WorldData.Player(lVar4.name,0)) == null) goto LAB_180b434b9;
          local_res8[0] = (float)HeroData.GetHorseTravelSpeed(lVar4,0);
          local_res8[0] = local_res8[0] * 100.0;
          uVar6 = Single.ToString(local_res8,"+0;-0;0",0);
          uVar5 = String.Concat(uVar5,"\n马匹 ",uVar6,"%",0);
          *puVar10 = uVar5;
          il2cpp_internal(puVar10,uVar5);
        }
        if ((((*pStatics_df90 == 0) ||
             (lVar4 = *(int64 *)(*pStatics_df90 + 32)) == null) ||
            (lVar4 = WorldData.Player(lVar4,0)) == null) || (*(int64 *)(lVar4 + 0x2b8) == 0))
        goto LAB_180b434b9;
        fVar11 = (float)HeroSpeAddData.Get(*(int64 *)(lVar4 + 0x2b8),174,0);
        if (fVar11 != 0.0) {
          if (((this.bigmapSpeedText == null) ||
              (lVar4 = GameObject.get_transform(this.bigmapSpeedText,0)) == null) ||
             (lVar4 = FUN_180da0f00(lVar4,0)) == null) goto LAB_180b434b9;
          lVar4 = Component.GetComponent(lVar4,DAT_181d6ccc0);
          plVar7 = (int64 *)FUN_1800d60b0(DAT_181d80cc0,5);
          if (lVar4 == null) goto LAB_180b434b9;
          lVar9 = lVar4.subType;
          if (plVar7 == (int64 *)0) goto LAB_180b434b9;
          if ((lVar9 != null) &&
             (lVar8 = il2cpp_internal(lVar9,*(uint64 *)(*plVar7 + 64))) == null) {
            uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar5,0);
          }
          if ((int)plVar7[3] == 0) {
            uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar5,0);
          }
          plVar7[4] = lVar9;
          il2cpp_internal(plVar7 + 4,lVar9);
          if ((((this.bigmapSpeedText == null) ||
               (lVar9 = GameObject.get_transform(this.bigmapSpeedText,0)) == null) ||
              (lVar9 = FUN_180da0f00(lVar9,0)) == null) ||
             (lVar9 = Component.GetComponent(lVar9,DAT_181d6ccc0)) == null) goto LAB_180b434b9;
          cVar3 = FUN_1816fd990(*(uint64 *)(lVar9 + 24),"",0);
          lVar9 = "\n";
          if (cVar3) {
            lVar9 = "";
          }
          if ((lVar9 != null) &&
             (lVar8 = il2cpp_internal(lVar9,*(uint64 *)(*plVar7 + 64))) == null) {
            uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar5,0);
          }
          if (*(uint32 *)(plVar7 + 3) < 2) {
            uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar5,0);
          }
          plVar7[5] = lVar9;
          il2cpp_internal(plVar7 + 5,lVar9);
          if (("加成 " != 0) &&
             (lVar9 = il2cpp_internal("加成 ",*(uint64 *)(*plVar7 + 64))) == null) {
            uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar5,0);
          }
          lVar9 = "加成 ";
          if (*(uint32 *)(plVar7 + 3) < 3) {
            uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar5,0);
          }
          plVar7[6] = "加成 ";
          il2cpp_internal(plVar7 + 6,lVar9);
          lVar9 = FUN_18046c0a0(0);
          if ((((lVar9 == null) || (*(int64 *)(lVar9 + 32) == 0)) ||
              (lVar9 = WorldData.Player(*(int64 *)(lVar9 + 32),0)) == null) ||
             (*(int64 *)(lVar9 + 0x2b8) == 0)) goto LAB_180b434b9;
          local_res8[0] = (float)HeroSpeAddData.Get(*(int64 *)(lVar9 + 0x2b8),174,0);
          local_res8[0] = local_res8[0] * 100.0;
          lVar9 = Single.ToString(local_res8,"+0;-0;0",0);
          if ((lVar9 != null) &&
             (lVar8 = il2cpp_internal(lVar9,*(uint64 *)(*plVar7 + 64))) == null) {
            uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar5,0);
          }
          if (*(uint32 *)(plVar7 + 3) < 4) {
            uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar5,0);
          }
          plVar7[7] = lVar9;
          il2cpp_internal(plVar7 + 7,lVar9);
          if (("%" != 0) &&
             (lVar9 = il2cpp_internal("%",*(uint64 *)(*plVar7 + 64))) == null) {
            uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar5,0);
          }
          lVar9 = "%";
          if (*(uint32 *)(plVar7 + 3) < 5) {
            uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar5,0);
          }
          plVar7[8] = "%";
          il2cpp_internal(plVar7 + 8,lVar9);
          uVar5 = String.Concat(plVar7,0);
          lVar4.subType = uVar5;
        }
        if (((*pStatics_df90 == 0) ||
            (lVar4 = *(int64 *)(*pStatics_df90 + 32)) == null) ||
           (lVar4 = WorldData.Player(lVar4,0)) == null) goto LAB_180b434b9;
        fVar11 = (float)HeroData.GetWeighChangeTravelSpeed(lVar4,0);
        if (fVar11 != 1.0) {
          if (((this.bigmapSpeedText == null) ||
              (lVar4 = GameObject.get_transform(this.bigmapSpeedText,0)) == null) ||
             (lVar4 = FUN_180da0f00(lVar4,0)) == null) goto LAB_180b434b9;
          lVar4 = Component.GetComponent(lVar4,DAT_181d6ccc0);
          plVar7 = (int64 *)FUN_1800d60b0(DAT_181d80cc0,5);
          if (lVar4 == null) goto LAB_180b434b9;
          lVar9 = lVar4.subType;
          if (plVar7 == (int64 *)0) goto LAB_180b434b9;
          if ((lVar9 != null) &&
             (lVar8 = il2cpp_internal(lVar9,*(uint64 *)(*plVar7 + 64))) == null) {
            uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar5,0);
          }
          if ((int)plVar7[3] == 0) {
            uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar5,0);
          }
          plVar7[4] = lVar9;
          il2cpp_internal(plVar7 + 4,lVar9);
          if ((((this.bigmapSpeedText == null) ||
               (lVar9 = GameObject.get_transform(this.bigmapSpeedText,0)) == null) ||
              (lVar9 = FUN_180da0f00(lVar9,0)) == null) ||
             (lVar9 = Component.GetComponent(lVar9,DAT_181d6ccc0)) == null) goto LAB_180b434b9;
          cVar3 = FUN_1816fd990(*(uint64 *)(lVar9 + 24),"",0);
          lVar9 = "\n";
          if (cVar3) {
            lVar9 = "";
          }
          if ((lVar9 != null) &&
             (lVar8 = il2cpp_internal(lVar9,*(uint64 *)(*plVar7 + 64))) == null) {
            uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar5,0);
          }
          if (*(uint32 *)(plVar7 + 3) < 2) {
            uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar5,0);
          }
          plVar7[5] = lVar9;
          il2cpp_internal(plVar7 + 5,lVar9);
          if (("负重 x" != 0) &&
             (lVar9 = il2cpp_internal("负重 x",*(uint64 *)(*plVar7 + 64))) == null) {
            uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar5,0);
          }
          lVar9 = "负重 x";
          if (*(uint32 *)(plVar7 + 3) < 3) {
            uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar5,0);
          }
          plVar7[6] = "负重 x";
          il2cpp_internal(plVar7 + 6,lVar9);
          lVar9 = FUN_18046c0a0(0);
          if (((lVar9 == null) || (*(int64 *)(lVar9 + 32) == 0)) ||
             (lVar9 = WorldData.Player(*(int64 *)(lVar9 + 32),0)) == null) goto LAB_180b434b9;
          local_res8[0] = (float)HeroData.GetWeighChangeTravelSpeed(lVar9,0);
          local_res8[0] = local_res8[0] * 100.0;
          lVar9 = Single.ToString(local_res8,"f0",0);
          if ((lVar9 != null) &&
             (lVar8 = il2cpp_internal(lVar9,*(uint64 *)(*plVar7 + 64))) == null) {
            uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar5,0);
          }
          if (*(uint32 *)(plVar7 + 3) < 4) {
            uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar5,0);
          }
          plVar7[7] = lVar9;
          il2cpp_internal(plVar7 + 7,lVar9);
          if (("%" != 0) &&
             (lVar9 = il2cpp_internal("%",*(uint64 *)(*plVar7 + 64))) == null) {
            uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar5,0);
          }
          lVar9 = "%";
          if (*(uint32 *)(plVar7 + 3) < 5) {
            uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar5,0);
          }
          plVar7[8] = "%";
          il2cpp_internal(plVar7 + 8,lVar9);
          uVar5 = String.Concat(plVar7,0);
          lVar4.subType = uVar5;
        }
        if (((*pStatics_df90 == 0) ||
            (lVar4 = *(int64 *)(*pStatics_df90 + 32)) == null) ||
           (lVar4 = WorldData.Player(lVar4,0)) == null) goto LAB_180b434b9;
        fVar11 = (float)HeroData.GetWeatherChangeTravelSpeed(lVar4,0);
        if (fVar11 != 1.0) {
          if (((this.bigmapSpeedText == null) ||
              (lVar4 = GameObject.get_transform(this.bigmapSpeedText,0)) == null) ||
             (lVar4 = FUN_180da0f00(lVar4,0)) == null) goto LAB_180b434b9;
          lVar4 = Component.GetComponent(lVar4,DAT_181d6ccc0);
          plVar7 = (int64 *)FUN_1800d60b0(DAT_181d80cc0,5);
          if (lVar4 == null) goto LAB_180b434b9;
          lVar9 = lVar4.subType;
          if (plVar7 == (int64 *)0) goto LAB_180b434b9;
          if ((lVar9 != null) &&
             (lVar8 = il2cpp_internal(lVar9,*(uint64 *)(*plVar7 + 64))) == null) {
            uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar5,0);
          }
          if ((int)plVar7[3] == 0) {
            uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar5,0);
          }
          plVar7[4] = lVar9;
          il2cpp_internal(plVar7 + 4,lVar9);
          if ((((this.bigmapSpeedText == null) ||
               (lVar9 = GameObject.get_transform(this.bigmapSpeedText,0)) == null) ||
              (lVar9 = FUN_180da0f00(lVar9,0)) == null) ||
             (lVar9 = Component.GetComponent(lVar9,DAT_181d6ccc0)) == null) goto LAB_180b434b9;
          cVar3 = FUN_1816fd990(*(uint64 *)(lVar9 + 24),"",0);
          lVar9 = "\n";
          if (cVar3) {
            lVar9 = "";
          }
          if ((lVar9 != null) &&
             (lVar8 = il2cpp_internal(lVar9,*(uint64 *)(*plVar7 + 64))) == null) {
            uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar5,0);
          }
          if (*(uint32 *)(plVar7 + 3) < 2) {
            uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar5,0);
          }
          plVar7[5] = lVar9;
          il2cpp_internal(plVar7 + 5,lVar9);
          if (("天气 x" != 0) &&
             (lVar9 = il2cpp_internal("天气 x",*(uint64 *)(*plVar7 + 64))) == null) {
            uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar5,0);
          }
          lVar9 = "天气 x";
          if (*(uint32 *)(plVar7 + 3) < 3) {
            uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar5,0);
          }
          plVar7[6] = "天气 x";
          il2cpp_internal(plVar7 + 6,lVar9);
          lVar9 = FUN_18046c0a0(0);
          if (((lVar9 == null) || (*(int64 *)(lVar9 + 32) == 0)) ||
             (lVar9 = WorldData.Player(*(int64 *)(lVar9 + 32),0)) == null) goto LAB_180b434b9;
          local_res8[0] = (float)HeroData.GetWeatherChangeTravelSpeed(lVar9,0);
          local_res8[0] = local_res8[0] * 100.0;
          lVar9 = Single.ToString(local_res8,"f0",0);
          if ((lVar9 != null) &&
             (lVar8 = il2cpp_internal(lVar9,*(uint64 *)(*plVar7 + 64))) == null) {
            uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar5,0);
          }
          if (*(uint32 *)(plVar7 + 3) < 4) {
            uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar5,0);
          }
          plVar7[7] = lVar9;
          il2cpp_internal(plVar7 + 7,lVar9);
          if (("%" != 0) &&
             (lVar9 = il2cpp_internal("%",*(uint64 *)(*plVar7 + 64))) == null) {
            uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar5,0);
          }
          lVar9 = "%";
          if (*(uint32 *)(plVar7 + 3) < 5) {
            uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar5,0);
          }
          plVar7[8] = "%";
          il2cpp_internal(plVar7 + 8,lVar9);
          uVar5 = String.Concat(plVar7,0);
          lVar4.subType = uVar5;
        }
        if (((*pStatics_df90 == 0) ||
            (lVar4 = *(int64 *)(*pStatics_df90 + 32)) == null) ||
           (lVar4 = WorldData.Player(lVar4,0)) == null) goto LAB_180b434b9;
        fVar11 = (float)HeroData.GetTerrainChangeTravelSpeed(lVar4,0);
        if (fVar11 != 1.0) {
          if (((this.bigmapSpeedText == null) ||
              (lVar4 = GameObject.get_transform(this.bigmapSpeedText,0)) == null) ||
             (lVar4 = FUN_180da0f00(lVar4,0)) == null) goto LAB_180b434b9;
          lVar4 = Component.GetComponent(lVar4,DAT_181d6ccc0);
          plVar7 = (int64 *)FUN_1800d60b0(DAT_181d80cc0,5);
          if (lVar4 == null) goto LAB_180b434b9;
          lVar9 = lVar4.subType;
          if (plVar7 == (int64 *)0) goto LAB_180b434b9;
          if ((lVar9 != null) &&
             (lVar8 = il2cpp_internal(lVar9,*(uint64 *)(*plVar7 + 64))) == null) {
            uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar5,0);
          }
          if ((int)plVar7[3] == 0) {
            uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar5,0);
          }
          plVar7[4] = lVar9;
          il2cpp_internal(plVar7 + 4,lVar9);
          if ((((this.bigmapSpeedText == null) ||
               (lVar9 = GameObject.get_transform(this.bigmapSpeedText,0)) == null) ||
              (lVar9 = FUN_180da0f00(lVar9,0)) == null) ||
             (lVar9 = Component.GetComponent(lVar9,DAT_181d6ccc0)) == null) goto LAB_180b434b9;
          cVar3 = FUN_1816fd990(*(uint64 *)(lVar9 + 24),"",0);
          lVar9 = "\n";
          if (cVar3) {
            lVar9 = "";
          }
          if ((lVar9 != null) &&
             (lVar8 = il2cpp_internal(lVar9,*(uint64 *)(*plVar7 + 64))) == null) {
            uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar5,0);
          }
          if (*(uint32 *)(plVar7 + 3) < 2) {
            uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar5,0);
          }
          plVar7[5] = lVar9;
          il2cpp_internal(plVar7 + 5,lVar9);
          if (("地形 x" != 0) &&
             (lVar9 = il2cpp_internal("地形 x",*(uint64 *)(*plVar7 + 64))) == null) {
            uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar5,0);
          }
          lVar9 = "地形 x";
          if (*(uint32 *)(plVar7 + 3) < 3) {
            uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar5,0);
          }
          plVar7[6] = "地形 x";
          il2cpp_internal(plVar7 + 6,lVar9);
          lVar9 = FUN_18046c0a0(0);
          if (((lVar9 == null) || (*(int64 *)(lVar9 + 32) == 0)) ||
             (lVar9 = WorldData.Player(*(int64 *)(lVar9 + 32),0)) == null) goto LAB_180b434b9;
          local_res8[0] = (float)HeroData.GetTerrainChangeTravelSpeed(lVar9,0);
          local_res8[0] = local_res8[0] * 100.0;
          lVar9 = Single.ToString(local_res8,"f0",0);
          if ((lVar9 != null) &&
             (lVar8 = il2cpp_internal(lVar9,*(uint64 *)(*plVar7 + 64))) == null) {
            uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar5,0);
          }
          if (*(uint32 *)(plVar7 + 3) < 4) {
            uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar5,0);
          }
          plVar7[7] = lVar9;
          il2cpp_internal(plVar7 + 7,lVar9);
          if (("%" != 0) &&
             (lVar9 = il2cpp_internal("%",*(uint64 *)(*plVar7 + 64))) == null) {
            uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar5,0);
          }
          lVar9 = "%";
          if (*(uint32 *)(plVar7 + 3) < 5) {
            uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar5,0);
          }
          plVar7[8] = "%";
          il2cpp_internal(plVar7 + 8,lVar9);
          uVar5 = String.Concat(plVar7,0);
          lVar4.subType = uVar5;
        }
        lVar4 = this.targetHorseData;
        if (((*pStatics_df90 == 0) ||
            (lVar9 = *(int64 *)(*pStatics_df90 + 32)) == null) ||
           (lVar9 = WorldData.Player(lVar9,0)) == null) goto LAB_180b434b9;
        if (lVar4 != *(int64 *)(lVar9 + 0x208)) {
          lVar4 = FUN_18046c0a0(0);
          if (((lVar4 == null) || (lVar4.name == null)) ||
             (lVar4 = WorldData.Player(lVar4.name,0)) == null) goto LAB_180b434b9;
          this.targetHorseData = *(uint64 *)(lVar4 + 0x208);
          lVar4 = this.horseIcon;
          if (this.targetHorseData == null) {
            if (lVar4 == null) goto LAB_180b434b9;
            lVar4 = GameObject.GetComponent(lVar4,DAT_181d9fe50);
            if ((*pStatics_6270 == 0) ||
               (uVar5 = TextureController.LoadAtlasSprite
                                  (*pStatics_6270,"UIAtlas","马未装备",0),
               lVar4 == null)) goto LAB_180b434b9;
            Image.set_sprite(lVar4,uVar5,0);
            if (this.horsePowerBar == null) goto LAB_180b434b9;
            GameObject.SetActive(this.horsePowerBar,0,0);
            if (this.horseFavorBar == null) goto LAB_180b434b9;
            GameObject.SetActive(this.horseFavorBar,0,0);
            if (this.horseSpringBar == null) goto LAB_180b434b9;
            GameObject.SetActive(this.horseSpringBar,0,0);
            if (this.horseBack == null) goto LAB_180b434b9;
            GameObject.SetActive(this.horseBack,0,0);
            uVar5 = this.quickButtonTips;
            cVar3 = Object.op_Inequality(uVar5,0,0);
            if (cVar3) {
              lVar4 = this.quickButtonTips;
              if (lVar4 == null) goto LAB_180b434b9;
              uVar5 = 0;
              goto LAB_180b42222;
            }
          }
          else {
            if (lVar4 == null) goto LAB_180b434b9;
            lVar4 = GameObject.GetComponent(lVar4,DAT_181d9fe50);
            lVar9 = *pStatics_6270;
            if (((this.targetHorseData == null) ||
                (uVar5 = String.Concat(this.targetHorseData.name,
                                        "大",0), lVar9 == null)) ||
               (uVar5 = TextureController.LoadAtlasSprite(lVar9,"IconAtlas",uVar5,0), lVar4 == null))
            goto LAB_180b434b9;
            Image.set_sprite(lVar4,uVar5,0);
            if (this.horsePowerBar == null) goto LAB_180b434b9;
            GameObject.SetActive(this.horsePowerBar,1,0);
            if (this.horseFavorBar == null) goto LAB_180b434b9;
            GameObject.SetActive(this.horseFavorBar,1,0);
            if (this.horseSpringBar == null) goto LAB_180b434b9;
            GameObject.SetActive(this.horseSpringBar,1,0);
            if (this.horseBack == null) goto LAB_180b434b9;
            GameObject.SetActive(this.horseBack,1,0);
            uVar5 = this.quickButtonTips;
            cVar3 = Object.op_Inequality(uVar5,0,0);
            if (cVar3) {
              lVar4 = this.quickButtonTips;
              if (lVar4 == null) goto LAB_180b434b9;
              uVar5 = 1;
        LAB_180b42222:
              GameObject.SetActive(lVar4,uVar5,0);
            }
          }
        }
        if (this.targetHorseData != null) {
          if (((this.horsePowerBar == null) ||
              (lVar4 = GameObject.get_transform(this.horsePowerBar,0)) == null) ||
             (lVar4 = Transform.Find(lVar4,"PowerBar",0)) == null) goto LAB_180b434b9;
          lVar4 = Component.GetComponent(lVar4,DAT_181d6bc40);
          if ((this.targetHorseData == null) ||
             (lVar9 = this.targetHorseData.horseData) == null)
          goto LAB_180b434b9;
          fVar11 = *(float *)(lVar9 + 56);
          fVar12 = (float)HorseData.MaxPower(lVar9,0);
          if (lVar4 == null) goto LAB_180b434b9;
          Image.set_fillAmount(lVar4,fVar11 / fVar12,0);
          if (((this.horseFavorBar == null) ||
              (lVar4 = GameObject.get_transform(this.horseFavorBar,0)) == null) ||
             (lVar4 = Transform.Find(lVar4,"PowerBar",0)) == null) goto LAB_180b434b9;
          lVar4 = Component.GetComponent(lVar4,DAT_181d6bc40);
          if (((this.targetHorseData == null) ||
              (lVar9 = this.targetHorseData.horseData) == null) || (lVar4 == null))
          goto LAB_180b434b9;
          Image.set_fillAmount(lVar4,*(uint32 *)(lVar9 + 60),0);
          if ((this.targetHorseData == null) ||
             (lVar4 = this.targetHorseData.horseData) == null)
          goto LAB_180b434b9;
          lVar9 = this.horseSpringBar;
          if (0.0 < lVar4.rareLv) {
            if (((lVar9 == null) || (lVar4 = GameObject.get_transform(lVar9,0)) == null) ||
               (lVar4 = Transform.Find(lVar4,"PowerBar",0)) == null) {
        LAB_180b434ad:
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            plVar7 = (int64 *)Component.GetComponent(lVar4,DAT_181d6bc40);
            local_68 = 0;
            uStack_60 = 0;
            Color.ctor(&local_68,0x3f800000,0x3f000000,0,0);
            if (plVar7 == (int64 *)0) goto LAB_180b434ad;
            local_78 = local_68;
            uStack_70 = (uint32)uStack_60;
            uStack_6c = uStack_60._4_4_;
            (**(code **)(*plVar7 + 0x2a8))(plVar7,&local_78,*(uint64 *)(*plVar7 + 0x2b0));
            if (((this.horseSpringBar == null) ||
                (lVar4 = GameObject.get_transform(this.horseSpringBar,0)) == null) ||
               (lVar4 = Transform.Find(lVar4,"PowerBar",0)) == null) goto LAB_180b434ad;
            lVar4 = Component.GetComponent(lVar4,DAT_181d6bc40);
            if ((this.targetHorseData == null) ||
               (lVar9 = this.targetHorseData.horseData) == null)
            goto LAB_180b434ad;
            fVar11 = *(float *)(lVar9 + 64);
            if (lVar4 == null) goto LAB_180b434ad;
            fVar11 = fVar11 / *(float *)(pStatics_ef00 + 0x218);
          }
          else if (0.0 < lVar4.weight) {
            if (((lVar9 == null) || (lVar4 = GameObject.get_transform(lVar9,0)) == null) ||
               (lVar4 = Transform.Find(lVar4,"PowerBar",0)) == null) {
        LAB_180b434a7:
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            plVar7 = (int64 *)Component.GetComponent(lVar4,DAT_181d6bc40);
            local_68 = 0;
            uStack_60 = 0;
            Color.ctor(&local_68,0x3f000000,0x3f000000,0x3f000000,0);
            if (plVar7 == (int64 *)0) goto LAB_180b434a7;
            local_78 = local_68;
            uStack_70 = (uint32)uStack_60;
            uStack_6c = uStack_60._4_4_;
            (**(code **)(*plVar7 + 0x2a8))(plVar7,&local_78,*(uint64 *)(*plVar7 + 0x2b0));
            if (((this.horseSpringBar == null) ||
                (lVar4 = GameObject.get_transform(this.horseSpringBar,0)) == null) ||
               (lVar4 = Transform.Find(lVar4,"PowerBar",0)) == null) goto LAB_180b434a7;
            lVar4 = Component.GetComponent(lVar4,DAT_181d6bc40);
            if (((this.targetHorseData == null) ||
                (lVar9 = this.targetHorseData.horseData) == null) || (lVar4 == null)
               ) goto LAB_180b434a7;
            fVar11 = *(float *)(pStatics_ef00 + 0x21c);
            fVar11 = (fVar11 - *(float *)(lVar9 + 68)) / fVar11;
          }
          else {
            if (((lVar9 == null) || (lVar4 = GameObject.get_transform(lVar9,0)) == null) ||
               (lVar4 = Transform.Find(lVar4,"PowerBar",0)) == null) {
        LAB_180b434a1:
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            plVar7 = (int64 *)Component.GetComponent(lVar4,DAT_181d6bc40);
            local_68 = 0;
            uStack_60 = 0;
            Color.ctor(&local_68,0x3f000000,0x3e800000,0,0);
            if (plVar7 == (int64 *)0) goto LAB_180b434a1;
            local_78 = local_68;
            uStack_70 = (uint32)uStack_60;
            uStack_6c = uStack_60._4_4_;
            (**(code **)(*plVar7 + 0x2a8))(plVar7,&local_78,*(uint64 *)(*plVar7 + 0x2b0));
            if (((this.horseSpringBar == null) ||
                (lVar4 = GameObject.get_transform(this.horseSpringBar,0)) == null) ||
               ((lVar4 = Transform.Find(lVar4,"PowerBar",0), lVar4 == null ||
                (lVar4 = Component.GetComponent(lVar4,DAT_181d6bc40)) == null))) goto LAB_180b434a1;
            fVar11 = 1.0;
          }
          Image.set_fillAmount(lVar4,fVar11,0);
        }
        if (((*pStatics_df90 == 0) ||
            (lVar4 = *(int64 *)(*pStatics_df90 + 32)) == null) ||
           (lVar4 = WorldData.Player(lVar4,0)) == null) goto LAB_180b434b9;
        if (*(char *)(lVar4 + 0x388) == false) {
          lVar4 = FUN_18046c0a0(0);
          if (((lVar4 == null) || (lVar4.name == null)) ||
             (lVar4 = WorldData.Player(lVar4.name,0)) == null) goto LAB_180b434b9;
          if (*(char *)(lVar4 + 0x389) != false) {
            if (this.bigmapColliderText == null) goto LAB_180b434b9;
            lVar4 = GameObject.get_transform(this.bigmapColliderText,0);
            puVar10 = (uint64 *)Vector3.get_one(&local_68,0);
            if (lVar4 == null) goto LAB_180b434b9;
            uStack_70 = *(uint32 *)(puVar10 + 1);
            local_78 = *puVar10;
            Transform.set_localScale(lVar4,&local_78,0);
            if (((this.bigmapColliderText == null) ||
                (lVar4 = GameObject.get_transform(this.bigmapColliderText,0)) == null) ||
               (lVar4 = Transform.Find(lVar4,"Text",0)) == null) goto LAB_180b434b9;
            uVar5 = Component.GetComponent(lVar4,DAT_181d6d8c0);
            LTLocalization.SetText(uVar5,"山",0);
            if ((this.bigmapColliderText == null) ||
               (lVar4 = GameObject.get_transform(this.bigmapColliderText,0)) == null)
            goto LAB_180b434b9;
            lVar4 = Component.GetComponent(lVar4,DAT_181d6ccc0);
            lVar9 = FUN_18046c0a0(0);
            if (((lVar9 == null) || (*(int64 *)(lVar9 + 32) == 0)) ||
               (lVar9 = WorldData.Player(*(int64 *)(lVar9 + 32),0)) == null) goto LAB_180b434b9;
            local_res8[0] = (float)HeroData.GetTerrainChangeTravelSpeed(lVar9,0);
            local_res8[0] = local_res8[0] * 100.0;
            uVar6 = Single.ToString(local_res8,"f0",0);
            uVar5 = "山脉地形\n速度x{0}%";
            goto LAB_180b42cae;
          }
          lVar4 = FUN_18046c0a0(0);
          if (((lVar4 == null) || (lVar4.name == null)) ||
             (lVar4 = WorldData.Player(lVar4.name,0)) == null) goto LAB_180b434b9;
          lVar9 = this.bigmapColliderText;
          if (*(char *)(lVar4 + 0x38a) != false) {
            if (lVar9 == null) goto LAB_180b434b9;
            lVar4 = GameObject.get_transform(lVar9,0);
            puVar10 = (uint64 *)Vector3.get_one(&local_68,0);
            if (lVar4 == null) goto LAB_180b434b9;
            uStack_70 = *(uint32 *)(puVar10 + 1);
            local_78 = *puVar10;
            Transform.set_localScale(lVar4,&local_78,0);
            if (((this.bigmapColliderText == null) ||
                (lVar4 = GameObject.get_transform(this.bigmapColliderText,0)) == null) ||
               (lVar4 = Transform.Find(lVar4,"Text",0)) == null) throw; // [null/range check failed]
            uVar5 = Component.GetComponent(lVar4,DAT_181d6d8c0);
            LTLocalization.SetText(uVar5,"丘",0);
            if ((this.bigmapColliderText == null) ||
               (lVar4 = GameObject.get_transform(this.bigmapColliderText,0)) == null)
            throw; // [null/range check failed]
            lVar4 = Component.GetComponent(lVar4,DAT_181d6ccc0);
            lVar9 = FUN_18046c0a0(0);
            if (((lVar9 == null) || (*(int64 *)(lVar9 + 32) == 0)) ||
               (lVar9 = WorldData.Player(*(int64 *)(lVar9 + 32),0)) == null) throw; // [null/range check failed]
            local_res8[0] = (float)HeroData.GetTerrainChangeTravelSpeed(lVar9,0);
            local_res8[0] = local_res8[0] * 100.0;
            uVar5 = Single.ToString(local_res8,"f0",0);
            uVar5 = String.Format("丘陵地形\n速度x{0}%",uVar5,0);
            if (lVar4 == null) throw; // [null/range check failed]
            goto LAB_180b42cc2;
          }
          if (lVar9 == null) throw; // [null/range check failed]
          lVar4 = GameObject.get_transform(lVar9,0);
          puVar10 = (uint64 *)Vector3.get_zero(&local_68,0);
          if (lVar4 == null) throw; // [null/range check failed]
          uStack_70 = *(uint32 *)(puVar10 + 1);
          local_78 = *puVar10;
          Transform.set_localScale(lVar4,&local_78,0);
        }
        else {
          if (this.bigmapColliderText == null) goto LAB_180b434b9;
          lVar4 = GameObject.get_transform(this.bigmapColliderText,0);
          puVar10 = (uint64 *)Vector3.get_one(&local_68,0);
          if (lVar4 == null) goto LAB_180b434b9;
          uStack_70 = *(uint32 *)(puVar10 + 1);
          local_78 = *puVar10;
          Transform.set_localScale(lVar4,&local_78,0);
          if (((this.bigmapColliderText == null) ||
              (lVar4 = GameObject.get_transform(this.bigmapColliderText,0)) == null) ||
             (lVar4 = Transform.Find(lVar4,"Text",0)) == null) goto LAB_180b434b9;
          uVar5 = Component.GetComponent(lVar4,DAT_181d6d8c0);
          LTLocalization.SetText(uVar5,"水",0);
          if ((this.bigmapColliderText == null) ||
             (lVar4 = GameObject.get_transform(this.bigmapColliderText,0)) == null)
          goto LAB_180b434b9;
          lVar4 = Component.GetComponent(lVar4,DAT_181d6ccc0);
          lVar9 = FUN_18046c0a0(0);
          if (((lVar9 == null) || (*(int64 *)(lVar9 + 32) == 0)) ||
             (lVar9 = WorldData.Player(*(int64 *)(lVar9 + 32),0)) == null) goto LAB_180b434b9;
          local_res8[0] = (float)HeroData.GetTerrainChangeTravelSpeed(lVar9,0);
          local_res8[0] = local_res8[0] * 100.0;
          uVar6 = Single.ToString(local_res8,"f0",0);
          uVar5 = "水域地形\n速度x{0}%";
        LAB_180b42cae:
          uVar5 = String.Format(uVar5,uVar6,0);
          if (lVar4 == null) {
        LAB_180b434b9:
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
        LAB_180b42cc2:
          lVar4.subType = uVar5;
        }
        if ((((*pStatics_df90 != 0) &&
             (lVar4 = *(int64 *)(*pStatics_df90 + 32)) != null) &&
            (lVar4 = WorldData.Player(lVar4,0)) != null) && (*(int64 *)(lVar4 + 0x220) != 0)) {
          fVar11 = *(float *)(*(int64 *)(lVar4 + 0x220) + 28);
          if (((*pStatics_df90 != 0) &&
              (lVar4 = *(int64 *)(*pStatics_df90 + 32)) != null) &&
             ((lVar4 = WorldData.Player(lVar4,0), lVar4 != null && (*(int64 *)(lVar4 + 0x220) != 0)))) {
            pfVar1 = (float *)(*(int64 *)(lVar4 + 0x220) + 32);
            lVar4 = this.overWeightText;
            if (*pfVar1 <= fVar11 && fVar11 != *pfVar1) {
              if (lVar4 == null) throw; // [null/range check failed]
              lVar4 = GameObject.get_transform(lVar4,0);
              puVar10 = (uint64 *)Vector3.get_one(&local_68,0);
            }
            else {
              if (lVar4 == null) throw; // [null/range check failed]
              lVar4 = GameObject.get_transform(lVar4,0);
              puVar10 = (uint64 *)Vector3.get_zero(&local_68,0);
            }
            if (lVar4 != null) {
              uStack_70 = *(uint32 *)(puVar10 + 1);
              local_78 = *puVar10;
              Transform.set_localScale(lVar4,&local_78,0);
              uVar5 = this.bigmapSpeEffText;
              cVar3 = Object.op_Inequality(uVar5,0,0);
              if (!cVar3) {
                return;
              }
              lVar4 = FUN_18046bbe0(0);
              if (((lVar4 != null) && (lVar4.setName != null)) &&
                 (lVar4 = GameObject.GetComponent(lVar4.setName,DAT_181d9e910)) != null
                 ) {
                lVar9 = this.bigmapSpeEffText;
                if (*(int *)(lVar4 + 248) == -1) {
                  if (lVar9 != null) {
                    lVar4 = GameObject.get_transform(lVar9,0);
                    puVar10 = (uint64 *)Vector3.get_zero(&local_68,0);
                    if (lVar4 != null) {
                      uStack_70 = *(uint32 *)(puVar10 + 1);
                      local_78 = *puVar10;
                      Transform.set_localScale(lVar4,&local_78,0);
                      return;
                    }
                  }
                }
                else if (lVar9 != null) {
                  lVar4 = GameObject.get_transform(lVar9,0);
                  puVar10 = (uint64 *)Vector3.get_one(&local_68,0);
                  if (lVar4 != null) {
                    uStack_70 = *(uint32 *)(puVar10 + 1);
                    local_78 = *puVar10;
                    Transform.set_localScale(lVar4,&local_78,0);
                    if (((this.bigmapSpeEffText != null) &&
                        (lVar4 = GameObject.get_transform(this.bigmapSpeEffText,0)) != null)
                       && (lVar4 = Transform.Find(lVar4,"Text",0)) != null) {
                      uVar5 = Component.GetComponent(lVar4,DAT_181d6d8c0);
                      lVar4 = *pStatics_bc28;
                      lVar9 = *(int64 *)(pStatics_baa8 + 16);
                      if ((((lVar9 != null) && (lVar9 = *(int64 *)(lVar9 + 88)) != null) &&
                          (lVar9 = GameObject.GetComponent(lVar9,DAT_181d9e910)) != null) &&
                         (lVar4 != null)) {
                        uVar2 = *(uint32 *)(lVar9 + 248);
                        if (lVar4.subType <= uVar2) {
                          ThrowHelper.ThrowArgumentOutOfRangeException(0);
                        }
                        LTLocalization.SetText
                                  (uVar5,*(uint64 *)
                                          (lVar4.itemID + 32 + (int64)(int)uVar2 * 8),
                                   0);
                        if (this.bigmapSpeEffText != null) {
                          lVar9 = GameObject.GetComponent(this.bigmapSpeEffText,DAT_181da12b0);
                          lVar4 = *(int64 *)(pStatics_bc28 + 8);
                          lVar8 = *(int64 *)(pStatics_baa8 + 16);
                          if (((lVar8 != null) && (lVar8 = *(int64 *)(lVar8 + 88)) != null) &&
                             ((lVar8 = GameObject.GetComponent(lVar8,DAT_181d9e910), lVar8 != null &&
                              (lVar4 != null)))) {
                            uVar2 = *(uint32 *)(lVar8 + 248);
                            if (lVar4.subType <= uVar2) {
                              ThrowHelper.ThrowArgumentOutOfRangeException(0);
                            }
                            if (lVar9 != null) {
                              *(uint64 *)(lVar9 + 24) =
                                   *(uint64 *)
                                    (lVar4.itemID + 32 + (int64)(int)uVar2 * 8);
                              il2cpp_internal();
                              return;
                            }
                          }
                        }
                      }
                    }
                  }
                }
              }
            }
          }
        }
    }

    // Token : 0x60017DE
    // RVA   : 0xB40520   Offset: 0xB3ED20   Length: 0x2F2
    public void OnClick()
    {
        var pStatics = *(int64*)(DAT_181d4df90 + 184);
        int iVar1;
        long lVar2;
        if (this.targetHorseData == null) {
          if (*pStatics != 0) {
            GameController.ShowTextOnMouse(*pStatics,"未装备马匹",0);
            plVar3 = (int64 *)Resources.Load("Sound/SoundEffect/WrongClick",0);
            plVar4 = (int64 *)0;
            if ((plVar3 != (int64 *)0) && (*plVar3 == DAT_181d8a228)) {
              plVar4 = plVar3;
            }
            NGUITools.PlaySound(plVar4,0);
            return;
          }
        }
        else {
          ItemData.PlayItemSound(this.targetHorseData,0);
          lVar2 = *(int64 *)(*(int64 *)(DAT_181d51800 + 184) + 32);
          if (lVar2 != null) {
            iVar1 = *(int *)(lVar2 + 24);
            if (iVar1 == 0) {
        LAB_180b4063a:
              HorseIconController.SprintHorse(this,this.targetHorseData,0);
              return;
            }
            if (iVar1 - 3U < 2) {
              lVar2 = FUN_18046c260(0);
              if ((lVar2 != null) && (*(int64 *)(lVar2 + 80) != 0)) {
                lVar2 = GameObject.GetComponent(*(int64 *)(lVar2 + 80),DAT_181d9fdc8);
                if (lVar2 != null) {
                  if (*(char *)(lVar2 + 40) == false) goto LAB_180b4063a;
                  lVar2 = FUN_18046c0a0(0);
                  if (lVar2 != null) {
                    GameController.ShowTextOnMouse(lVar2,"比赛已结束",0);
                    return;
                  }
                }
              }
            }
            else {
              lVar2 = FUN_18046c0a0(0);
              if (lVar2 != null) {
                GameController.ShowTextOnMouse(lVar2,"比赛尚未开始",0);
                return;
              }
            }
          }
        }
    }

    // Token : 0x60017DF
    // RVA   : 0xB40820   Offset: 0xB3F020   Length: 0x2DB
    public void SprintHorse(ItemData itemData)
    {
        ulong uVar1;
        uint uVar2;
        long lVar3;
        long lVar4;
        ulong local_38;
        uint local_30;
        uint local_28;
        uint uStack_24;
        uint uStack_20;
        uint32 uStack_1c;
        if ((itemData != null) && (lVar3 = *(int64 *)(itemData + 136)) != null) {
          if (0.0 < *(float *)(lVar3 + 64)) {
            lVar3 = **(int64 **)(DAT_181d4df90 + 184);
            uVar1 = "冲刺中";
          }
          else {
            if (*(float *)(lVar3 + 68) <= 0.0) {
              lVar3 = FUN_18046c0a0(0);
              lVar4 = FUN_18046bbe0(0);
              if (((lVar4 != null) && (*(int64 *)(lVar4 + 88) != 0)) &&
                 (lVar4 = GameObject.get_transform(*(int64 *)(lVar4 + 88),0)) != null) {
                puVar5 = (uint64 *)Transform.get_position(&local_38,lVar4,0);
                uVar1 = *puVar5;
                uVar2 = *(uint32 *)(puVar5 + 1);
                puVar6 = (uint32 *)Color.get_green(&local_28,0);
                if (lVar3 != null) {
                  local_28 = *puVar6;
                  uStack_24 = puVar6[1];
                  uStack_20 = puVar6[2];
                  uStack_1c = puVar6[3];
                  local_38 = uVar1;
                  local_30 = uVar2;
                  GameController.ShowTextAtPos(lVar3,"冲刺",&local_38,20,&local_28,0);
                  if (*(int64 *)(itemData + 136) != 0) {
                    HorseData.StartSprint(*(int64 *)(itemData + 136),0);
                    plVar7 = (int64 *)Resources.Load("Sound/SoundEffect/SpeEffect/加速旋转",0);
                    plVar8 = (int64 *)0;
                    if ((plVar7 != (int64 *)0) && (*plVar7 == DAT_181d8a228)) {
                      plVar8 = plVar7;
                    }
                    NGUITools.PlaySound(plVar8,0);
                    return;
                  }
                }
              }
              throw; // [null/range check failed]
            }
            lVar3 = FUN_18046c0a0(0);
            uVar1 = "冷却中";
          }
          if (lVar3 != null) {
            GameController.ShowTextOnMouse(lVar3,uVar1,0);
            return;
          }
        }
    }

    // Token : 0x60017E0
    // RVA   : 0x3A17B0   Offset: 0x39FFB0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_18044ef50(this,0);
    }

}
