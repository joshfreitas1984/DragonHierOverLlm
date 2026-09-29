// ============================================================
// Type  : HorseIconController
// Token : 0x20002DA
// ============================================================

public class HorseIconController
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x400176B
    public ItemData targetHorseData;

    // Token: 0x400176C
    public GameObject horseIcon;

    // Token: 0x400176D
    public GameObject horseBack;

    // Token: 0x400176E
    public GameObject horseFavorBar;

    // Token: 0x400176F
    public GameObject horsePowerBar;

    // Token: 0x4001770
    public GameObject horseSpringBar;

    // Token: 0x4001771
    public GameObject bigmapColliderText;

    // Token: 0x4001772
    public GameObject bigmapSpeedText;

    // Token: 0x4001773
    public GameObject overWeightText;

    // Token: 0x4001774
    public GameObject bigmapSpeEffText;

    // Token: 0x4001775
    public GameObject quickButtonTips;

    // Token: 0x4001776
    public bool horseMatchIcon;

    // Token: 0x4001777
    private float freshTime;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6001821
    // RVA   : 0xB02170   Offset: 0xB01570   Length: 0x2A6F
    private void Update()
    {
        var pStatics_3d40 = *(int64*)(DAT_181d73d40 + 184);
        var pStatics_b4a8 = *(int64*)(DAT_181dab4a8 + 184);
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
          if (lVar4 == null) goto LAB_180b04bda;
          uVar5 = lVar4.setName;
          cVar3 = Object.op_Inequality(uVar5,0,0);
          if (cVar3) {
            if (this.bigmapSpeedText == null) goto LAB_180b04bda;
            uVar5 = GameObject.GetComponent(this.bigmapSpeedText,DAT_181d74108);
            lVar4 = FUN_18046bbe0(0);
            if (((lVar4 == null) || (lVar4.setName == null)) ||
               (lVar4 = GameObject.GetComponent(lVar4.setName,DAT_181dc76c8)) == null)
            goto LAB_180b04bda;
            local_res8[0] = (float)BigmapNpcController.GetBigMapTravelSpeed(lVar4,0);
        LAB_180b025aa:
            local_res8[0] = local_res8[0] * 100.0;
            uVar6 = Single.ToString(local_res8,"f0",0);
            uVar6 = String.Concat("速度",uVar6,"%",0);
            LTLocalization.SetText(uVar5,uVar6,0);
          }
        }
        else {
          lVar4 = FUN_18046c220(0);
          if (lVar4 == null) goto LAB_180b04bda;
          uVar5 = lVar4.poisonNumDetected;
          cVar3 = Object.op_Inequality(uVar5,0,0);
          if (cVar3) {
            if (this.bigmapSpeedText == null) goto LAB_180b04bda;
            uVar5 = GameObject.GetComponent(this.bigmapSpeedText,DAT_181d74108);
            lVar4 = FUN_18046c220(0);
            if (((lVar4 == null) || (lVar4.poisonNumDetected == null)) ||
               (lVar4 = GameObject.GetComponent(lVar4.poisonNumDetected,DAT_181d71df8)) == null)
            goto LAB_180b04bda;
            local_res8[0] = (float)HorseMatchHeroController.GetFinalTravelSpeed(lVar4,0);
            goto LAB_180b025aa;
          }
        }
        if (((this.bigmapSpeedText == null) ||
            (lVar4 = GameObject.get_transform(this.bigmapSpeedText,0)) == null) ||
           ((lVar4 = FUN_180daa030(lVar4,0), lVar4 == null ||
            (lVar4 = Component.GetComponent(lVar4,DAT_181d95578)) == null))) goto LAB_180b04bda;
        lVar4.subType = "基础 100%";
        if (((GameController._instance == null) ||
            (lVar4 = GameController._instance.worldData) == null) ||
           (lVar4 = WorldData.Player(lVar4,0)) == null) goto LAB_180b04bda;
        fVar11 = (float)HeroData.GetHorseTravelSpeed(lVar4,0);
        if (fVar11 != 0.0) {
          if (((this.bigmapSpeedText == null) ||
              (lVar4 = GameObject.get_transform(this.bigmapSpeedText,0)) == null) ||
             ((lVar4 = FUN_180daa030(lVar4,0), lVar4 == null ||
              (lVar4 = Component.GetComponent(lVar4,DAT_181d95578)) == null))) goto LAB_180b04bda;
          uVar5 = lVar4.subType;
          lVar4 = FUN_18046c0a0(0);
          if (((lVar4 == null) || (lVar4.name == null)) ||
             (lVar4 = WorldData.Player(lVar4.name,0)) == null) goto LAB_180b04bda;
          local_res8[0] = (float)HeroData.GetHorseTravelSpeed(lVar4,0);
          local_res8[0] = local_res8[0] * 100.0;
          uVar6 = Single.ToString(local_res8,"+0;-0;0",0);
          uVar5 = String.Concat(uVar5,"\n马匹 ",uVar6,"%",0);
          *puVar10 = uVar5;
          il2cpp_internal(puVar10,uVar5);
        }
        if ((((GameController._instance == null) ||
             (lVar4 = GameController._instance.worldData) == null) ||
            (lVar4 = WorldData.Player(lVar4,0)) == null) || (*(int64 *)(lVar4 + 0x2b8) == 0))
        goto LAB_180b04bda;
        fVar11 = (float)HeroSpeAddData.Get(*(int64 *)(lVar4 + 0x2b8),174,0);
        if (fVar11 != 0.0) {
          if (((this.bigmapSpeedText == null) ||
              (lVar4 = GameObject.get_transform(this.bigmapSpeedText,0)) == null) ||
             (lVar4 = FUN_180daa030(lVar4,0)) == null) goto LAB_180b04bda;
          lVar4 = Component.GetComponent(lVar4,DAT_181d95578);
          plVar7 = (int64 *)FUN_1800d60b0(DAT_181da5cf8,5);
          if (lVar4 == null) goto LAB_180b04bda;
          lVar9 = lVar4.subType;
          if (plVar7 == (int64 *)0) goto LAB_180b04bda;
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
              (lVar9 = FUN_180daa030(lVar9,0)) == null) ||
             (lVar9 = Component.GetComponent(lVar9,DAT_181d95578)) == null) goto LAB_180b04bda;
          cVar3 = FUN_18171eb50(lVar9.cityAreaID,"",0);
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
          if ((((lVar9 == null) || (lVar9.villageAreaID == null)) ||
              (lVar9 = WorldData.Player(lVar9.villageAreaID,0)) == null) ||
             (*(int64 *)(lVar9 + 0x2b8) == 0)) goto LAB_180b04bda;
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
        if (((GameController._instance == null) ||
            (lVar4 = GameController._instance.worldData) == null) ||
           (lVar4 = WorldData.Player(lVar4,0)) == null) goto LAB_180b04bda;
        fVar11 = (float)HeroData.GetWeighChangeTravelSpeed(lVar4,0);
        if (fVar11 != 1.0) {
          if (((this.bigmapSpeedText == null) ||
              (lVar4 = GameObject.get_transform(this.bigmapSpeedText,0)) == null) ||
             (lVar4 = FUN_180daa030(lVar4,0)) == null) goto LAB_180b04bda;
          lVar4 = Component.GetComponent(lVar4,DAT_181d95578);
          plVar7 = (int64 *)FUN_1800d60b0(DAT_181da5cf8,5);
          if (lVar4 == null) goto LAB_180b04bda;
          lVar9 = lVar4.subType;
          if (plVar7 == (int64 *)0) goto LAB_180b04bda;
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
              (lVar9 = FUN_180daa030(lVar9,0)) == null) ||
             (lVar9 = Component.GetComponent(lVar9,DAT_181d95578)) == null) goto LAB_180b04bda;
          cVar3 = FUN_18171eb50(lVar9.cityAreaID,"",0);
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
          if (((lVar9 == null) || (lVar9.villageAreaID == null)) ||
             (lVar9 = WorldData.Player(lVar9.villageAreaID,0)) == null) goto LAB_180b04bda;
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
        if (((GameController._instance == null) ||
            (lVar4 = GameController._instance.worldData) == null) ||
           (lVar4 = WorldData.Player(lVar4,0)) == null) goto LAB_180b04bda;
        fVar11 = (float)HeroData.GetWeatherChangeTravelSpeed(lVar4,0);
        if (fVar11 != 1.0) {
          if (((this.bigmapSpeedText == null) ||
              (lVar4 = GameObject.get_transform(this.bigmapSpeedText,0)) == null) ||
             (lVar4 = FUN_180daa030(lVar4,0)) == null) goto LAB_180b04bda;
          lVar4 = Component.GetComponent(lVar4,DAT_181d95578);
          plVar7 = (int64 *)FUN_1800d60b0(DAT_181da5cf8,5);
          if (lVar4 == null) goto LAB_180b04bda;
          lVar9 = lVar4.subType;
          if (plVar7 == (int64 *)0) goto LAB_180b04bda;
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
              (lVar9 = FUN_180daa030(lVar9,0)) == null) ||
             (lVar9 = Component.GetComponent(lVar9,DAT_181d95578)) == null) goto LAB_180b04bda;
          cVar3 = FUN_18171eb50(lVar9.cityAreaID,"",0);
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
          if (((lVar9 == null) || (lVar9.villageAreaID == null)) ||
             (lVar9 = WorldData.Player(lVar9.villageAreaID,0)) == null) goto LAB_180b04bda;
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
        if (((GameController._instance == null) ||
            (lVar4 = GameController._instance.worldData) == null) ||
           (lVar4 = WorldData.Player(lVar4,0)) == null) goto LAB_180b04bda;
        fVar11 = (float)HeroData.GetTerrainChangeTravelSpeed(lVar4,0);
        if (fVar11 != 1.0) {
          if (((this.bigmapSpeedText == null) ||
              (lVar4 = GameObject.get_transform(this.bigmapSpeedText,0)) == null) ||
             (lVar4 = FUN_180daa030(lVar4,0)) == null) goto LAB_180b04bda;
          lVar4 = Component.GetComponent(lVar4,DAT_181d95578);
          plVar7 = (int64 *)FUN_1800d60b0(DAT_181da5cf8,5);
          if (lVar4 == null) goto LAB_180b04bda;
          lVar9 = lVar4.subType;
          if (plVar7 == (int64 *)0) goto LAB_180b04bda;
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
              (lVar9 = FUN_180daa030(lVar9,0)) == null) ||
             (lVar9 = Component.GetComponent(lVar9,DAT_181d95578)) == null) goto LAB_180b04bda;
          cVar3 = FUN_18171eb50(lVar9.cityAreaID,"",0);
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
          if (((lVar9 == null) || (lVar9.villageAreaID == null)) ||
             (lVar9 = WorldData.Player(lVar9.villageAreaID,0)) == null) goto LAB_180b04bda;
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
        if (((GameController._instance == null) ||
            (lVar9 = GameController._instance.worldData) == null) ||
           (lVar9 = WorldData.Player(lVar9,0)) == null) goto LAB_180b04bda;
        if (lVar4 != lVar9.getSpePoisonData) {
          lVar4 = FUN_18046c0a0(0);
          if (((lVar4 == null) || (lVar4.name == null)) ||
             (lVar4 = WorldData.Player(lVar4.name,0)) == null) goto LAB_180b04bda;
          this.targetHorseData = lVar4.getSpePoisonData;
          lVar4 = this.horseIcon;
          if (this.targetHorseData == null) {
            if (lVar4 == null) goto LAB_180b04bda;
            lVar4 = GameObject.GetComponent(lVar4,DAT_181d71e80);
            if ((*pStatics_b4a8 == 0) ||
               (uVar5 = TextureController.LoadAtlasSprite
                                  (*pStatics_b4a8,"UIAtlas","马未装备",0),
               lVar4 == null)) goto LAB_180b04bda;
            Image.set_sprite(lVar4,uVar5,0);
            if (this.horsePowerBar == null) goto LAB_180b04bda;
            GameObject.SetActive(this.horsePowerBar,0,0);
            if (this.horseFavorBar == null) goto LAB_180b04bda;
            GameObject.SetActive(this.horseFavorBar,0,0);
            if (this.horseSpringBar == null) goto LAB_180b04bda;
            GameObject.SetActive(this.horseSpringBar,0,0);
            if (this.horseBack == null) goto LAB_180b04bda;
            GameObject.SetActive(this.horseBack,0,0);
            uVar5 = this.quickButtonTips;
            cVar3 = Object.op_Inequality(uVar5,0,0);
            if (cVar3) {
              lVar4 = this.quickButtonTips;
              if (lVar4 == null) goto LAB_180b04bda;
              uVar5 = 0;
              goto LAB_180b038bf;
            }
          }
          else {
            if (lVar4 == null) goto LAB_180b04bda;
            lVar4 = GameObject.GetComponent(lVar4,DAT_181d71e80);
            lVar9 = *pStatics_b4a8;
            if (((this.targetHorseData == null) ||
                (uVar5 = String.Concat(this.targetHorseData.name,
                                        "大",0), lVar9 == null)) ||
               (uVar5 = TextureController.LoadAtlasSprite(lVar9,"IconAtlas",uVar5,0), lVar4 == null))
            goto LAB_180b04bda;
            Image.set_sprite(lVar4,uVar5,0);
            if (this.horsePowerBar == null) goto LAB_180b04bda;
            GameObject.SetActive(this.horsePowerBar,1,0);
            if (this.horseFavorBar == null) goto LAB_180b04bda;
            GameObject.SetActive(this.horseFavorBar,1,0);
            if (this.horseSpringBar == null) goto LAB_180b04bda;
            GameObject.SetActive(this.horseSpringBar,1,0);
            if (this.horseBack == null) goto LAB_180b04bda;
            GameObject.SetActive(this.horseBack,1,0);
            uVar5 = this.quickButtonTips;
            cVar3 = Object.op_Inequality(uVar5,0,0);
            if (cVar3) {
              lVar4 = this.quickButtonTips;
              if (lVar4 == null) goto LAB_180b04bda;
              uVar5 = 1;
        LAB_180b038bf:
              GameObject.SetActive(lVar4,uVar5,0);
            }
          }
        }
        if (this.targetHorseData != null) {
          if (((this.horsePowerBar == null) ||
              (lVar4 = GameObject.get_transform(this.horsePowerBar,0)) == null) ||
             (lVar4 = Transform.Find(lVar4,"PowerBar",0)) == null) goto LAB_180b04bda;
          lVar4 = Component.GetComponent(lVar4,DAT_181d94478);
          if ((this.targetHorseData == null) ||
             (lVar9 = this.targetHorseData.horseData) == null)
          goto LAB_180b04bda;
          fVar11 = lVar9.Inns;
          fVar12 = (float)HorseData.MaxPower(lVar9,0);
          if (lVar4 == null) goto LAB_180b04bda;
          Image.set_fillAmount(lVar4,fVar11 / fVar12,0);
          if (((this.horseFavorBar == null) ||
              (lVar4 = GameObject.get_transform(this.horseFavorBar,0)) == null) ||
             (lVar4 = Transform.Find(lVar4,"PowerBar",0)) == null) goto LAB_180b04bda;
          lVar4 = Component.GetComponent(lVar4,DAT_181d94478);
          if (((this.targetHorseData == null) ||
              (lVar9 = this.targetHorseData.horseData) == null) || (lVar4 == null))
          goto LAB_180b04bda;
          Image.set_fillAmount(lVar4,*(uint32 *)(lVar9 + 60),0);
          if ((this.targetHorseData == null) ||
             (lVar4 = this.targetHorseData.horseData) == null)
          goto LAB_180b04bda;
          lVar9 = this.horseSpringBar;
          if (0.0 < lVar4.rareLv) {
            if (((lVar9 == null) || (lVar4 = GameObject.get_transform(lVar9,0)) == null) ||
               (lVar4 = Transform.Find(lVar4,"PowerBar",0)) == null) {
        LAB_180b04bce:
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            plVar7 = (int64 *)Component.GetComponent(lVar4,DAT_181d94478);
            local_68 = 0;
            uStack_60 = 0;
            Color.ctor(&local_68,0x3f800000,0x3f000000,0,0);
            if (plVar7 == (int64 *)0) goto LAB_180b04bce;
            local_78 = local_68;
            uStack_70 = (uint32)uStack_60;
            uStack_6c = uStack_60._4_4_;
            (**(code **)(*plVar7 + 0x2a8))(plVar7,&local_78,*(uint64 *)(*plVar7 + 0x2b0));
            if (((this.horseSpringBar == null) ||
                (lVar4 = GameObject.get_transform(this.horseSpringBar,0)) == null) ||
               (lVar4 = Transform.Find(lVar4,"PowerBar",0)) == null) goto LAB_180b04bce;
            lVar4 = Component.GetComponent(lVar4,DAT_181d94478);
            if ((this.targetHorseData == null) ||
               (lVar9 = this.targetHorseData.horseData) == null)
            goto LAB_180b04bce;
            fVar11 = lVar9.ResourcePoints;
            if (lVar4 == null) goto LAB_180b04bce;
            fVar11 = fVar11 / *(float *)(pStatics_3d40 + 0x220);
          }
          else if (0.0 < lVar4.weight) {
            if (((lVar9 == null) || (lVar4 = GameObject.get_transform(lVar9,0)) == null) ||
               (lVar4 = Transform.Find(lVar4,"PowerBar",0)) == null) {
        LAB_180b04bc8:
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            plVar7 = (int64 *)Component.GetComponent(lVar4,DAT_181d94478);
            local_68 = 0;
            uStack_60 = 0;
            Color.ctor(&local_68,0x3f000000,0x3f000000,0x3f000000,0);
            if (plVar7 == (int64 *)0) goto LAB_180b04bc8;
            local_78 = local_68;
            uStack_70 = (uint32)uStack_60;
            uStack_6c = uStack_60._4_4_;
            (**(code **)(*plVar7 + 0x2a8))(plVar7,&local_78,*(uint64 *)(*plVar7 + 0x2b0));
            if (((this.horseSpringBar == null) ||
                (lVar4 = GameObject.get_transform(this.horseSpringBar,0)) == null) ||
               (lVar4 = Transform.Find(lVar4,"PowerBar",0)) == null) goto LAB_180b04bc8;
            lVar4 = Component.GetComponent(lVar4,DAT_181d94478);
            if (((this.targetHorseData == null) ||
                (lVar9 = this.targetHorseData.horseData) == null) || (lVar4 == null)
               ) goto LAB_180b04bc8;
            fVar11 = *(float *)(pStatics_3d40 + 0x224);
            fVar11 = (fVar11 - *(float *)(lVar9 + 68)) / fVar11;
          }
          else {
            if (((lVar9 == null) || (lVar4 = GameObject.get_transform(lVar9,0)) == null) ||
               (lVar4 = Transform.Find(lVar4,"PowerBar",0)) == null) {
        LAB_180b04bc2:
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            plVar7 = (int64 *)Component.GetComponent(lVar4,DAT_181d94478);
            local_68 = 0;
            uStack_60 = 0;
            Color.ctor(&local_68,0x3f000000,0x3e800000,0,0);
            if (plVar7 == (int64 *)0) goto LAB_180b04bc2;
            local_78 = local_68;
            uStack_70 = (uint32)uStack_60;
            uStack_6c = uStack_60._4_4_;
            (**(code **)(*plVar7 + 0x2a8))(plVar7,&local_78,*(uint64 *)(*plVar7 + 0x2b0));
            if (((this.horseSpringBar == null) ||
                (lVar4 = GameObject.get_transform(this.horseSpringBar,0)) == null) ||
               ((lVar4 = Transform.Find(lVar4,"PowerBar",0), lVar4 == null ||
                (lVar4 = Component.GetComponent(lVar4,DAT_181d94478)) == null))) goto LAB_180b04bc2;
            fVar11 = 1.0;
          }
          Image.set_fillAmount(lVar4,fVar11,0);
        }
        if (((GameController._instance == null) ||
            (lVar4 = GameController._instance.worldData) == null) ||
           (lVar4 = WorldData.Player(lVar4,0)) == null) goto LAB_180b04bda;
        if (*(char *)(lVar4 + 0x3cf) == false) {
          lVar4 = FUN_18046c0a0(0);
          if (((lVar4 == null) || (lVar4.name == null)) ||
             (lVar4 = WorldData.Player(lVar4.name,0)) == null) goto LAB_180b04bda;
          if (*(char *)(lVar4 + 0x3d0) != false) {
            if (this.bigmapColliderText == null) goto LAB_180b04bda;
            lVar4 = GameObject.get_transform(this.bigmapColliderText,0);
            puVar10 = (uint64 *)Vector3.get_one(&local_68,0);
            if (lVar4 == null) goto LAB_180b04bda;
            uStack_70 = *(uint32 *)(puVar10 + 1);
            local_78 = *puVar10;
            Transform.set_localScale(lVar4,&local_78,0);
            if (((this.bigmapColliderText == null) ||
                (lVar4 = GameObject.get_transform(this.bigmapColliderText,0)) == null) ||
               (lVar4 = Transform.Find(lVar4,"Text",0)) == null) goto LAB_180b04bda;
            uVar5 = Component.GetComponent(lVar4,DAT_181d96178);
            LTLocalization.SetText(uVar5,"山",0);
            if ((this.bigmapColliderText == null) ||
               (lVar4 = GameObject.get_transform(this.bigmapColliderText,0)) == null)
            goto LAB_180b04bda;
            lVar4 = Component.GetComponent(lVar4,DAT_181d95578);
            lVar9 = FUN_18046c0a0(0);
            if (((lVar9 == null) || (lVar9.villageAreaID == null)) ||
               (lVar9 = WorldData.Player(lVar9.villageAreaID,0)) == null) goto LAB_180b04bda;
            local_res8[0] = (float)HeroData.GetTerrainChangeTravelSpeed(lVar9,0);
            local_res8[0] = local_res8[0] * 100.0;
            uVar6 = Single.ToString(local_res8,"f0",0);
            uVar5 = "山脉地形\n速度x{0}%";
            goto LAB_180b043ae;
          }
          lVar4 = FUN_18046c0a0(0);
          if (((lVar4 == null) || (lVar4.name == null)) ||
             (lVar4 = WorldData.Player(lVar4.name,0)) == null) goto LAB_180b04bda;
          lVar9 = this.bigmapColliderText;
          if (*(char *)(lVar4 + 0x3d1) != false) {
            if (lVar9 == null) goto LAB_180b04bda;
            lVar4 = GameObject.get_transform(lVar9,0);
            puVar10 = (uint64 *)Vector3.get_one(&local_68,0);
            if (lVar4 == null) goto LAB_180b04bda;
            uStack_70 = *(uint32 *)(puVar10 + 1);
            local_78 = *puVar10;
            Transform.set_localScale(lVar4,&local_78,0);
            if (((this.bigmapColliderText == null) ||
                (lVar4 = GameObject.get_transform(this.bigmapColliderText,0)) == null) ||
               (lVar4 = Transform.Find(lVar4,"Text",0)) == null) throw; // [null/range check failed]
            uVar5 = Component.GetComponent(lVar4,DAT_181d96178);
            LTLocalization.SetText(uVar5,"丘",0);
            if ((this.bigmapColliderText == null) ||
               (lVar4 = GameObject.get_transform(this.bigmapColliderText,0)) == null)
            throw; // [null/range check failed]
            lVar4 = Component.GetComponent(lVar4,DAT_181d95578);
            lVar9 = FUN_18046c0a0(0);
            if (((lVar9 == null) || (lVar9.villageAreaID == null)) ||
               (lVar9 = WorldData.Player(lVar9.villageAreaID,0)) == null) throw; // [null/range check failed]
            local_res8[0] = (float)HeroData.GetTerrainChangeTravelSpeed(lVar9,0);
            local_res8[0] = local_res8[0] * 100.0;
            uVar5 = Single.ToString(local_res8,"f0",0);
            uVar5 = String.Format("丘陵地形\n速度x{0}%",uVar5,0);
            if (lVar4 == null) throw; // [null/range check failed]
            goto LAB_180b043c2;
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
          if (this.bigmapColliderText == null) goto LAB_180b04bda;
          lVar4 = GameObject.get_transform(this.bigmapColliderText,0);
          puVar10 = (uint64 *)Vector3.get_one(&local_68,0);
          if (lVar4 == null) goto LAB_180b04bda;
          uStack_70 = *(uint32 *)(puVar10 + 1);
          local_78 = *puVar10;
          Transform.set_localScale(lVar4,&local_78,0);
          if (((this.bigmapColliderText == null) ||
              (lVar4 = GameObject.get_transform(this.bigmapColliderText,0)) == null) ||
             (lVar4 = Transform.Find(lVar4,"Text",0)) == null) goto LAB_180b04bda;
          uVar5 = Component.GetComponent(lVar4,DAT_181d96178);
          LTLocalization.SetText(uVar5,"水",0);
          if ((this.bigmapColliderText == null) ||
             (lVar4 = GameObject.get_transform(this.bigmapColliderText,0)) == null)
          goto LAB_180b04bda;
          lVar4 = Component.GetComponent(lVar4,DAT_181d95578);
          lVar9 = FUN_18046c0a0(0);
          if (((lVar9 == null) || (lVar9.villageAreaID == null)) ||
             (lVar9 = WorldData.Player(lVar9.villageAreaID,0)) == null) goto LAB_180b04bda;
          local_res8[0] = (float)HeroData.GetTerrainChangeTravelSpeed(lVar9,0);
          local_res8[0] = local_res8[0] * 100.0;
          uVar6 = Single.ToString(local_res8,"f0",0);
          uVar5 = "水域地形\n速度x{0}%";
        LAB_180b043ae:
          uVar5 = String.Format(uVar5,uVar6,0);
          if (lVar4 == null) {
        LAB_180b04bda:
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
        LAB_180b043c2:
          lVar4.subType = uVar5;
        }
        if ((((GameController._instance != null) &&
             (lVar4 = GameController._instance.worldData) != null) &&
            (lVar4 = WorldData.Player(lVar4,0)) != null) && (lVar4.speBookStorageSpeAdd != null)) {
          fVar11 = *(float *)(lVar4.speBookStorageSpeAdd + 28);
          if (((GameController._instance != null) &&
              (lVar4 = GameController._instance.worldData) != null) &&
             ((lVar4 = WorldData.Player(lVar4,0), lVar4 != null && (lVar4.speBookStorageSpeAdd != null)))) {
            pfVar1 = (float *)(lVar4.speBookStorageSpeAdd + 32);
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
                 (lVar4 = GameObject.GetComponent(lVar4.setName,DAT_181dc76c8)) != null
                 ) {
                lVar9 = this.bigmapSpeEffText;
                if (lVar4.worldPlotEventStartTime == -1) {
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
                      uVar5 = Component.GetComponent(lVar4,DAT_181d96178);
                      lVar4 = BigMapSpeEffectController.bigMapSpeEffectTypeName;

                      if ((((lVar9 = GameController.CheckShowSpeHero?.TempHeros) != null) &&
                          (lVar9 = GameObject.GetComponent(lVar9,DAT_181dc76c8)) != null) &&
                         (lVar4 != null)) {
                        uVar2 = lVar9.worldPlotEventStartTime;
                        if (lVar4.subType <= uVar2) {
                          ThrowHelper.ThrowArgumentOutOfRangeException(0);
                        }
                        uVar6 = *(uint64 *)
                                 (lVar4.itemID + 32 + (int64)(int)uVar2 * 8);
                        LTLocalization.SetText(uVar5,uVar6,0);
                        if (this.bigmapSpeEffText != null) {
                          lVar9 = GameObject.GetComponent(this.bigmapSpeEffText,DAT_181d73448);
                          lVar4 = BigMapSpeEffectController.bigMapSpeEffectTypeDescribe;
                          lVar8 = GameController.CheckShowSpeHero;
                          if ((((lVar8 != null) && (lVar8 = *(int64 *)(lVar8 + 88)) != null) &&
                              (lVar8 = GameObject.GetComponent(lVar8,DAT_181dc76c8)) != null) &&
                             (lVar4 != null)) {
                            uVar2 = *(uint32 *)(lVar8 + 248);
                            if (lVar4.subType <= uVar2) {
                              ThrowHelper.ThrowArgumentOutOfRangeException(0);
                            }
                            if (lVar9 != null) {
                              lVar9.cityAreaID =
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

    // Token : 0x6001822
    // RVA   : 0xB01B90   Offset: 0xB00F90   Length: 0x2F2
    public void OnClick()
    {
        int iVar1;
        long lVar2;
        if (this.targetHorseData == null) {
          if (GameController._instance != null) {
            GameController.ShowTextOnMouse(GameController._instance,"未装备马匹",0);
            plVar3 = (int64 *)Resources.Load("Sound/SoundEffect/WrongClick",0);
            plVar4 = (int64 *)0;
            if ((plVar3 != (int64 *)0) && (*plVar3 == DAT_181daf360)) {
              plVar4 = plVar3;
            }
            NGUITools.PlaySound(plVar4,0);
            return;
          }
        }
        else {
          ItemData.PlayItemSound(this.targetHorseData,0);
          lVar2 = *(int64 *)(*(int64 *)(DAT_181d768d0 + 184) + 32);
          if (lVar2 != null) {
            iVar1 = *(int *)(lVar2 + 24);
            if (iVar1 == 0) {
        LAB_180b01caa:
              HorseIconController.SprintHorse(this,this.targetHorseData,0);
              return;
            }
            if (iVar1 - 3U < 2) {
              lVar2 = FUN_18046c220(0);
              if ((lVar2 != null) && (*(int64 *)(lVar2 + 80) != 0)) {
                lVar2 = GameObject.GetComponent(*(int64 *)(lVar2 + 80),DAT_181d71df8);
                if (lVar2 != null) {
                  if (*(char *)(lVar2 + 40) == false) goto LAB_180b01caa;
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

    // Token : 0x6001823
    // RVA   : 0xB01E90   Offset: 0xB01290   Length: 0x2DB
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
          if (0.0 < lVar3.enterAreaEnemyForceAttackHero) {
            lVar3 = GameController._instance;
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
                    if ((plVar7 != (int64 *)0) && (*plVar7 == DAT_181daf360)) {
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

    // Token : 0x6001824
    // RVA   : 0x3A17B0   Offset: 0x3A0BB0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_18044ef50(this,0);
    }

}
