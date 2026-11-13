// ============================================================
// Type  : AreaBuildingDataBase
// Token : 0x20001F0
// ============================================================

public class AreaBuildingDataBase
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4000DC3
    public int id;

    // Token: 0x4000DC4
    public string name;

    // Token: 0x4000DC5
    public string spriteName;

    // Token: 0x4000DC6
    public string describe;

    // Token: 0x4000DC7
    public int buildingType;

    // Token: 0x4000DC8
    public bool onlyOne;

    // Token: 0x4000DC9
    public bool forceCenter;

    // Token: 0x4000DCA
    public int randomPos;

    // Token: 0x4000DCB
    public List<AreaBuildingChoice> areaBuildingChoices;

    // Token: 0x4000DCC
    public List<float> changeResource;

    // Token: 0x4000DCD
    public List<float> upgradeResource;

    // Token: 0x4000DCE
    public float buildCostTime;

    // Token: 0x4000DCF
    public float changeMaxPeople;

    // Token: 0x4000DD0
    public List<float> changeAreaState;

    // Token: 0x4000DD1
    public List<float> changeAllAreaState;

    // Token: 0x4000DD2
    public List<AreaBuildingRateChange> aroundBuildingRateChange;

    // Token: 0x4000DD3
    public int areaTypeLimit;

    // Token: 0x4000DD4
    public ForceSpeAddData buildingSpeAddData;

    // Token: 0x4000DD5
    public AreaBuildingShopData areaBuildingShopData;

    // Token: 0x4000DD6
    public int environmentSoundClip;

    // Token: 0x4000DD7
    public string enterSoundClip;

    // Token: 0x4000DD8
    public bool stealAble;

    // Token: 0x4000DD9
    public bool robAble;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000F58
    // RVA   : 0x78F550   Offset: 0x78E350   Length: 0x35B
    public void /*ctor*/()
    {
        ulong uVar1;
        long lVar2;
        ZhSegment.Initialize(this,0);
        uVar1 = il2cpp_internal(DAT_181e70ab8);
        FUN_1810f3480(uVar1,DAT_181e5dcc8);
        this.areaBuildingChoices = uVar1;
        lVar2 = il2cpp_internal(DAT_181e76ea8);
        FUN_1810f3480(lVar2,DAT_181e83230);
        if (lVar2 != null) {
          FUN_18175dba0(lVar2,0,DAT_181e83330);
          FUN_18175dba0(lVar2,0,DAT_181e83330);
          FUN_18175dba0(lVar2,0,DAT_181e83330);
          FUN_18175dba0(lVar2,0,DAT_181e83330);
          FUN_18175dba0(lVar2,0,DAT_181e83330);
          FUN_18175dba0(lVar2,0,DAT_181e83330);
          this.changeResource = lVar2;
          lVar2 = il2cpp_internal(DAT_181e76ea8);
          FUN_1810f3480(lVar2,DAT_181e83230);
          if (lVar2 != null) {
            FUN_18175dba0(lVar2,0,DAT_181e83330);
            FUN_18175dba0(lVar2,0,DAT_181e83330);
            FUN_18175dba0(lVar2,0,DAT_181e83330);
            FUN_18175dba0(lVar2,0,DAT_181e83330);
            FUN_18175dba0(lVar2,0,DAT_181e83330);
            FUN_18175dba0(lVar2,0,DAT_181e83330);
            this.upgradeResource = lVar2;
            lVar2 = il2cpp_internal(DAT_181e76ea8);
            FUN_1810f3480(lVar2,DAT_181e83230);
            if (lVar2 != null) {
              FUN_18175dba0(lVar2,0,DAT_181e83330);
              FUN_18175dba0(lVar2,0,DAT_181e83330);
              FUN_18175dba0(lVar2,0,DAT_181e83330);
              FUN_18175dba0(lVar2,0,DAT_181e83330);
              this.changeAreaState = lVar2;
              lVar2 = il2cpp_internal(DAT_181e76ea8);
              FUN_1810f3480(lVar2,DAT_181e83230);
              if (lVar2 != null) {
                FUN_18175dba0(lVar2,0,DAT_181e83330);
                FUN_18175dba0(lVar2,0,DAT_181e83330);
                FUN_18175dba0(lVar2,0,DAT_181e83330);
                FUN_18175dba0(lVar2,0,DAT_181e83330);
                this.changeAllAreaState = lVar2;
                uVar1 = il2cpp_internal(DAT_181e70bb8);
                FUN_1810f3480(uVar1,DAT_181e5e218);
                this.aroundBuildingRateChange = uVar1;
                this.buildingSpeAddData = new ForceSpeAddData(0);
                return;
              }
            }
          }
        }
    }

    // Token : 0x6000F59
    // RVA   : 0x78E270   Offset: 0x78D070   Length: 0x67
    public List<float> GetBuildCostResource(float rate)
    {
        ulong uVar1;
        uVar1 = this.upgradeResource;
        GlobalData.ListMulti(uVar1,rate,0);
    }

    // Token : 0x6000F5A
    // RVA   : 0x78E430   Offset: 0x78D230   Length: 0x8D
    public ForceSpeAddData GetBuildingSpeAddData(int targetLv)
    {
        ulong uVar1;
        uVar1 = this.buildingSpeAddData;
        ForceSpeAddData.op_Multiply
                  (uVar1,(float)targetLv * *(float *)(*(int64 *)(DAT_181e538e8 + 184) + 300) + 1.0,0);
    }

    // Token : 0x6000F5B
    // RVA   : 0x78E4C0   Offset: 0x78D2C0   Length: 0xDA0
    public string GetBuildingText(int targetLv, bool detail, bool showBuildCost, float produceRate, bool showBuildingName, AreaData targetArea)
    {
        var pStatics = *(int64*)(DAT_181e538e8 + 184);
        int64 AreaBuildingDataBase.GetBuildingText
                         (int64 this,int targetLv,char detail,char showBuildCost,uint32 produceRate,
                         uint32 showBuildingName,int64 targetArea)
        {
        int64 lVar1;
        char cVar2;
        int64 *plVar3;
        int64 lVar4;
        int64 lVar5;
        uint64 uVar6;
        int64 lVar7;
        uint64 uVar8;
        int iVar9;
        int64 lVar10;
        uint32 uVar11;
        float fVar12;
        uint32 uVar13;
        float local_78 [2];
        int64 local_70;
        local_78[0] = 0.0;
        lVar4 = "";
        if ((char)showBuildingName) {
          plVar3 = (int64 *)FUN_1801dfd90(DAT_181e85e38,5);
          if (plVar3 == (int64 *)0) goto LAB_18078f115;
          if (("<size=17>" != 0) &&
             (lVar4 = il2cpp_internal("<size=17>",*(uint64 *)(*plVar3 + 64))) == null) {
            uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1801e02d0(uVar6,0);
          }
          lVar4 = "<size=17>";
          if ((int)plVar3[3] == 0) {
            uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1801e02d0(uVar6,0);
          }
          plVar3[4] = "<size=17>";
          il2cpp_internal(plVar3 + 4,lVar4);
          lVar4 = this.name;
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
          if ((" " != 0) &&
             (lVar4 = il2cpp_internal(" ",*(uint64 *)(*plVar3 + 64))) == null) {
            uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1801e02d0(uVar6,0);
          }
          lVar4 = " ";
          if (*(uint32 *)(plVar3 + 3) < 3) {
            uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1801e02d0(uVar6,0);
          }
          plVar3[6] = " ";
          il2cpp_internal(plVar3 + 6,lVar4);
          lVar4 = GlobalData.GetNumText(targetLv,0);
          if ((lVar4 != null) &&
             (lVar5 = il2cpp_internal(lVar4,*(uint64 *)(*plVar3 + 64))) == null) {
            uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1801e02d0(uVar6,0);
          }
          if (*(uint32 *)(plVar3 + 3) < 4) {
            uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1801e02d0(uVar6,0);
          }
          plVar3[7] = lVar4;
          il2cpp_internal(plVar3 + 7,lVar4);
          if (("级</size>" != 0) &&
             (lVar4 = il2cpp_internal("级</size>",*(uint64 *)(*plVar3 + 64))) == null) {
            uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1801e02d0(uVar6,0);
          }
          lVar4 = "级</size>";
          if (*(uint32 *)(plVar3 + 3) < 5) {
            uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1801e02d0(uVar6,0);
          }
          plVar3[8] = "级</size>";
          il2cpp_internal(plVar3 + 8,lVar4);
          lVar4 = String.Concat(plVar3,0);
        }
        if (this.buildingType == 6) {
          lVar4 = String.Concat(lVar4,"\n<color=#D96200><b>特殊建筑</b></color>",0);
        }
        lVar5 = AreaBuildingDataBase.GetTotalChangeResource(this,targetLv,produceRate,0);
        uVar11 = 0;
        if (lVar5 != null) {
          local_70 = "";
          lVar10 = 32;
          lVar7 = "";
        LAB_18078e830:
          do {
            if ((int)*(uint32 *)(lVar5 + 24) <= (int)uVar11) goto LAB_18078e99e;
            if (*(uint32 *)(lVar5 + 24) <= uVar11) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            if (0.0 < *(float *)(*(int64 *)(lVar5 + 16) + lVar10)) {
              lVar1 = *(int64 *)(pStatics + 0x440);
              if (lVar1 == null) break;
              uVar6 = FUN_1800024b0(lVar1,uVar11,DAT_181e86970);
              uVar13 = FUN_1800024e0(lVar5,uVar11,DAT_181e83530);
              GlobalData.GenerateChangeColorText(uVar6,uVar13,0);
              lVar7 = String.Concat(lVar7,"\n");
            }
            else {
              fVar12 = (float)FUN_1800024e0(lVar5,uVar11);
              if (fVar12 < 0.0) {
                lVar1 = *(int64 *)(pStatics + 0x440);
                if (lVar1 == null) break;
                uVar6 = FUN_1800024b0(lVar1,uVar11,DAT_181e86970);
                uVar13 = FUN_1800024e0(lVar5,uVar11,DAT_181e83530);
                GlobalData.GenerateChangeColorText(uVar6,uVar13,0);
                local_70 = String.Concat(local_70,"\n");
                uVar11 = uVar11 + 1;
                lVar10 = lVar10 + 4;
                goto LAB_18078e830;
              }
            }
            uVar11 = uVar11 + 1;
            lVar10 = lVar10 + 4;
          } while( true );
        }
        LAB_18078f115:
                          // WARNING: Subroutine does not return
        FUN_1801e0300();
        LAB_18078e99e:
        iVar9 = 0;
        lVar5 = local_70;
        LAB_18078e9b0:
        do {
          lVar10 = *(int64 *)(pStatics + 0x628);
          if (lVar10 == null) goto LAB_18078f115;
          if (*(int *)(lVar10 + 24) <= iVar9) {
            cVar2 = String.op_Inequality(lVar7,"",0);
            if (cVar2) {
              lVar4 = String.Concat(lVar4,"\n\n每月产出",lVar7,0);
            }
            lVar7 = "";
            if (this.changeMaxPeople != null.0) {
              plVar3 = (int64 *)FUN_1801dfd90(DAT_181e85e38,5);
              if (plVar3 == (int64 *)0) goto LAB_18078f115;
              if ((lVar7 != null) &&
                 (lVar10 = il2cpp_internal(lVar7,*(uint64 *)(*plVar3 + 64))) == null) {
                uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1801e02d0(uVar6,0);
              }
              if ((int)plVar3[3] == 0) {
                uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1801e02d0(uVar6,0);
              }
              plVar3[4] = lVar7;
              il2cpp_internal(plVar3 + 4,lVar7);
              if (this.changeMaxPeople <= 0.0) {
                lVar7 = *(int64 *)(pStatics + 0x2d8);
              }
              else {
                lVar7 = *(int64 *)(pStatics + 0x270);
              }
              if ((lVar7 != null) &&
                 (lVar10 = il2cpp_internal(lVar7,*(uint64 *)(*plVar3 + 64))) == null) {
                uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1801e02d0(uVar6,0);
              }
              if (*(uint32 *)(plVar3 + 3) < 2) {
                uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1801e02d0(uVar6,0);
              }
              plVar3[5] = lVar7;
              il2cpp_internal(plVar3 + 5,lVar7);
              if (("人口上限+" != 0) &&
                 (lVar7 = il2cpp_internal("人口上限+",*(uint64 *)(*plVar3 + 64))) == null)
              {
                uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1801e02d0(uVar6,0);
              }
              lVar7 = "人口上限+";
              if (*(uint32 *)(plVar3 + 3) < 3) {
                uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1801e02d0(uVar6,0);
              }
              plVar3[6] = "人口上限+";
              il2cpp_internal(plVar3 + 6,lVar7);
              local_78[0] = (float)(targetLv + 1) * this.changeMaxPeople;
              lVar7 = Single.ToString(local_78,0);
              if ((lVar7 != null) &&
                 (lVar10 = il2cpp_internal(lVar7,*(uint64 *)(*plVar3 + 64))) == null) {
                uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1801e02d0(uVar6,0);
              }
              if (*(uint32 *)(plVar3 + 3) < 4) {
                uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1801e02d0(uVar6,0);
              }
              plVar3[7] = lVar7;
              il2cpp_internal(plVar3 + 7,lVar7);
              if (("</color>" != 0) &&
                 (lVar7 = il2cpp_internal("</color>",*(uint64 *)(*plVar3 + 64))) == null)
              {
                uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1801e02d0(uVar6,0);
              }
              lVar7 = "</color>";
              if (*(uint32 *)(plVar3 + 3) < 5) {
                uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1801e02d0(uVar6,0);
              }
              plVar3[8] = "</color>";
              il2cpp_internal(plVar3 + 8,lVar7);
              lVar7 = String.Concat(plVar3,0);
            }
            lVar10 = AreaBuildingDataBase.GetBuildingSpeAddData(this,targetLv,0);
            if (lVar10 != null) {
              uVar6 = ForceSpeAddData.GetDescribe(lVar10,0);
              cVar2 = String.op_Inequality(uVar6,"",0);
              if (cVar2) {
                cVar2 = FUN_1816387f0(lVar7,"",0);
                lVar10 = "\n";
                if (cVar2) {
                  lVar10 = "";
                }
                lVar7 = String.Concat(lVar7,lVar10,uVar6,0);
              }
              cVar2 = String.op_Inequality(lVar7,"",0);
              if (cVar2) {
                lVar4 = String.Concat(lVar4,"\n\n特殊效果\n",lVar7,0);
              }
              cVar2 = String.op_Inequality(lVar5,"",0);
              if (cVar2) {
                lVar4 = String.Concat(lVar4,"\n\n每月维护",lVar5,0);
              }
              if (detail) {
                uVar6 = AreaBuildingDataBase.GetAreaBuildingRateChange(this,targetLv,0);
                uVar6 = AreaBuildingDataBase.GetAreaBuildRateChangeText(this,uVar6,0);
                cVar2 = String.op_Inequality(uVar6,"",0);
                if (cVar2) {
                  lVar4 = String.Concat(lVar4,"\n\n周边效率\n",uVar6,0);
                }
              }
              lVar5 = targetArea;
              if (showBuildCost) {
                if (targetArea != null) {
                  if (*(int64 *)(targetArea + 176) == 0) {
        LAB_18078f25b:
                          // WARNING: Subroutine does not return
                    FUN_1801e0300();
                  }
                  ForceSpeAddData.Get(*(int64 *)(targetArea + 176),13);
                  cVar2 = AreaData.HaveForce(lVar5,0);
                  if (cVar2) {
                    lVar5 = AreaData.GetForce(lVar5,0);
                    if ((lVar5 == null) || (*(int64 *)(lVar5 + 0x148) == 0)) goto LAB_18078f25b;
                    ForceSpeAddData.Get(*(int64 *)(lVar5 + 0x148),12);
                  }
                }
                showBuildingName = Mathf.RoundToInt();
                uVar6 = il2cpp_value_box(DAT_181e60808,&showBuildingName);
                uVar8 = AreaBuildingDataBase.GetBuildCostResource(this,0x3f800000,0);
                uVar8 = GlobalData.GetResourceDescribe(uVar8,0);
                uVar6 = String.Format("\n\n建造消耗 ({0}天)\n{1}",uVar6,uVar8,0);
                lVar4 = String.Concat(lVar4,uVar6,0);
              }
              return lVar4;
            }
            goto LAB_18078f115;
          }
          fVar12 = (float)AreaBuildingDataBase.GetChangeAreaState(this,iVar9,targetLv,produceRate,0);
          if (0.0 < fVar12) {
            lVar10 = *(int64 *)(pStatics + 0x628);
            if (lVar10 == null) goto LAB_18078f115;
            uVar6 = FUN_1800024b0(lVar10,iVar9,DAT_181e86970);
            uVar6 = GlobalData.GenerateChangeColorText(uVar6,fVar12,0);
            lVar7 = String.Concat(lVar7,"\n",uVar6);
          }
          else if (fVar12 < 0.0) {
            lVar10 = *(int64 *)(pStatics + 0x628);
            if (lVar10 == null) goto LAB_18078f115;
            uVar6 = FUN_1800024b0(lVar10,iVar9,DAT_181e86970);
            uVar6 = GlobalData.GenerateChangeColorText(uVar6,fVar12,0);
            lVar5 = String.Concat(lVar5,"\n",uVar6);
          }
          fVar12 = (float)AreaBuildingDataBase.GetChangeAllAreaState(this,iVar9,targetLv,produceRate,0);
          if (0.0 < fVar12) {
            lVar10 = *(int64 *)(pStatics + 0x628);
            if (lVar10 == null) goto LAB_18078f115;
            uVar6 = FUN_1800024b0(lVar10,iVar9,DAT_181e86970);
            uVar6 = String.Concat("全域",uVar6,0);
            GlobalData.GenerateChangeColorText(uVar6,fVar12,0);
            lVar7 = String.Concat(lVar7,"\n");
          }
          else if (fVar12 < 0.0) {
            lVar10 = *(int64 *)(pStatics + 0x628);
            if (lVar10 == null) goto LAB_18078f115;
            uVar6 = FUN_1800024b0(lVar10,iVar9,DAT_181e86970);
            uVar6 = String.Concat("全域",uVar6,0);
            GlobalData.GenerateChangeColorText(uVar6,fVar12,0);
            lVar5 = String.Concat(lVar5,"\n");
            iVar9 = iVar9 + 1;
            goto LAB_18078e9b0;
          }
          iVar9 = iVar9 + 1;
        } while( true );
    }

    // Token : 0x6000F5C
    // RVA   : 0x78E380   Offset: 0x78D180   Length: 0xA5
    public int GetBuildTime(AreaData targetArea)
    {
        float fVar1;
        bool cVar2;
        long lVar3;
        float fVar4;
        float fVar5;
        fVar1 = this.buildCostTime;
        if (targetArea == null) {
          fVar4 = 1.0;
        }
        else {
          if (*(int64 *)(targetArea + 176) == 0) {
        LAB_18078e420:
                          // WARNING: Subroutine does not return
            FUN_1801e0300();
          }
          fVar4 = (float)ForceSpeAddData.Get(*(int64 *)(targetArea + 176),13);
          fVar4 = fVar4 + 1.0;
          cVar2 = AreaData.HaveForce(targetArea,0);
          if (cVar2) {
            lVar3 = AreaData.GetForce(targetArea,0);
            if ((lVar3 == null) || (*(int64 *)(lVar3 + 0x148) == 0)) goto LAB_18078e420;
            fVar5 = (float)ForceSpeAddData.Get(*(int64 *)(lVar3 + 0x148),12);
            fVar4 = fVar4 + fVar5;
          }
        }
        Mathf.RoundToInt(fVar1 / fVar4,0);
    }

    // Token : 0x6000F5D
    // RVA   : 0x78E2E0   Offset: 0x78D0E0   Length: 0x90
    public float GetBuildSpeedRate(AreaData targetArea)
    {
        bool cVar1;
        long lVar2;
        float fVar3;
        float fVar4;
        if (targetArea == null) {
          return 1.0;
        }
        if (*(int64 *)(targetArea + 176) != 0) {
          fVar3 = (float)ForceSpeAddData.Get(*(int64 *)(targetArea + 176),13);
          fVar3 = fVar3 + 1.0;
          cVar1 = AreaData.HaveForce(targetArea,0);
          if (cVar1) {
            lVar2 = AreaData.GetForce(targetArea,0);
            if ((lVar2 == null) || (*(int64 *)(lVar2 + 0x148) == 0)) throw; // [null/range check failed]
            fVar4 = (float)ForceSpeAddData.Get(*(int64 *)(lVar2 + 0x148),12);
            fVar3 = fVar3 + fVar4;
          }
          return fVar3;
        }
    }

    // Token : 0x6000F5E
    // RVA   : 0x78DD90   Offset: 0x78CB90   Length: 0x327
    public string GetAreaBuildRateChangeText(List<AreaBuildingRateChange> target)
    {
        bool cVar1;
        long lVar3;
        long lVar4;
        ulong uVar5;
        int iVar6;
        float[] local_res10 = new float[2];
        iVar6 = 0;
        local_res10[0] = 0.0;
        lVar4 = "";
        if (target != null) {
          while( true ) {
            if (*(int *)(target + 24) <= iVar6) {
              return lVar4;
            }
            plVar2 = (int64 *)FUN_1801dfd90(DAT_181e85e38,5);
            if (plVar2 == (int64 *)0) break;
            if ((lVar4 != null) &&
               (lVar3 = il2cpp_internal(lVar4,*(uint64 *)(*plVar2 + 64))) == null) {
              uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1801e02d0(uVar5,0);
            }
            if ((int)plVar2[3] == 0) {
              uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1801e02d0(uVar5,0);
            }
            plVar2[4] = lVar4;
            il2cpp_internal(plVar2 + 4,lVar4);
            cVar1 = FUN_1816387f0(lVar4,"",0);
            lVar4 = "\n";
            if (cVar1) {
              lVar4 = "";
            }
            if ((lVar4 != null) &&
               (lVar3 = il2cpp_internal(lVar4,*(uint64 *)(*plVar2 + 64))) == null) {
              uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1801e02d0(uVar5,0);
            }
            FUN_1800025b0(plVar2,1,lVar4);
            lVar4 = FUN_1800024b0(target,iVar6,DAT_181e5e3b0);
            if (lVar4 == null) break;
            lVar4 = *(int64 *)(lVar4 + 16);
            if ((lVar4 != null) &&
               (lVar3 = il2cpp_internal(lVar4,*(uint64 *)(*plVar2 + 64))) == null) {
              uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1801e02d0(uVar5,0);
            }
            if (*(uint32 *)(plVar2 + 3) < 3) {
              uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1801e02d0(uVar5,0);
            }
            plVar2[6] = lVar4;
            il2cpp_internal(plVar2 + 6,lVar4);
            lVar4 = FUN_1800024b0(target,iVar6);
            if (lVar4 == null) break;
            local_res10[0] = *(float *)(lVar4 + 24) * 100.0;
            lVar4 = Single.ToString(local_res10,"+0;-0;0");
            if ((lVar4 != null) &&
               (lVar3 = il2cpp_internal(lVar4,*(uint64 *)(*plVar2 + 64))) == null) {
              uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1801e02d0(uVar5,0);
            }
            if (*(uint32 *)(plVar2 + 3) < 4) {
              uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1801e02d0(uVar5,0);
            }
            plVar2[7] = lVar4;
            il2cpp_internal(plVar2 + 7,lVar4);
            if (("%" != 0) &&
               (lVar4 = il2cpp_internal("%",*(uint64 *)(*plVar2 + 64))) == null) {
              uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1801e02d0(uVar5,0);
            }
            lVar4 = "%";
            if (*(uint32 *)(plVar2 + 3) < 5) {
              uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1801e02d0(uVar5,0);
            }
            plVar2[8] = "%";
            il2cpp_internal(plVar2 + 8,lVar4);
            lVar4 = String.Concat(plVar2,0);
            iVar6 = iVar6 + 1;
          }
        }
    }

    // Token : 0x6000F5F
    // RVA   : 0x78E0C0   Offset: 0x78CEC0   Length: 0x1AE
    public List<AreaBuildingRateChange> GetAreaBuildingRateChange(int lv)
    {
        float fVar1;
        long lVar2;
        ulong uVar3;
        long lVar4;
        long lVar5;
        long lVar6;
        uint uVar7;
        lVar4 = il2cpp_internal(DAT_181e70bb8);
        FUN_1810f3480(lVar4,DAT_181e5e218);
        lVar5 = this.aroundBuildingRateChange;
        uVar7 = 0;
        if (lVar5 != null) {
          lVar6 = 32;
          do {
            if (lVar5.Count <= (int)uVar7) {
              return lVar4;
            }
            if (lVar5 == null) break;
            if (lVar5.Count <= uVar7) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            lVar5 = *(int64 *)(lVar6 + lVar5._items);
            if (lVar5 == null) break;
            lVar2 = this.aroundBuildingRateChange;
            uVar3 = lVar5._items;
            if (lVar2 == null) break;
            if (lVar2.Count <= uVar7) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            lVar5 = *(int64 *)(lVar6 + lVar2._items);
            if (lVar5 == null) break;
            fVar1 = lVar5.Count;
            lVar5 = new ZhSegment(0);
            lVar5._items = uVar3;
            lVar5.Count = (float)(lv + 1) * fVar1;
            if (lVar4 == null) break;
            FUN_18175de30(lVar4,lVar5,DAT_181e5e2a0);
            lVar5 = this.aroundBuildingRateChange;
            uVar7 = uVar7 + 1;
            lVar6 = lVar6 + 8;
          } while (lVar5 != null);
        }
    }

    // Token : 0x6000F60
    // RVA   : 0x78F430   Offset: 0x78E230   Length: 0x10
    public float GetChangeMaxPeople(int lv)
    {
        float FUN_18078f430(int64 this,int lv)
        {
        return (float)(lv + 1) * this.changeMaxPeople;
    }

    // Token : 0x6000F61
    // RVA   : 0x78F350   Offset: 0x78E150   Length: 0xDD
    public float GetChangeAreaState(AreaStateType areaStateType, int lv, float produceRate)
    {
        float AreaBuildingDataBase.GetChangeAreaState
                      (int64 this,uint32 areaStateType,int lv,float produceRate)
        {
        float fVar1;
        int64 lVar2;
        lVar2 = this.changeAreaState;
        if (lVar2 != null) {
          if (lVar2.Count <= areaStateType) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          fVar1 = lVar2._items[areaStateType];
          return ((float)lv * *(float *)(*(int64 *)(DAT_181e538e8 + 184) + 300) + 1.0) * fVar1 *
                 produceRate;
        }
    }

    // Token : 0x6000F62
    // RVA   : 0x78F270   Offset: 0x78E070   Length: 0xDD
    public float GetChangeAllAreaState(AreaStateType areaStateType, int lv, float produceRate)
    {
        float AreaBuildingDataBase.GetChangeAllAreaState
                      (int64 this,uint32 areaStateType,int lv,float produceRate)
        {
        float fVar1;
        int64 lVar2;
        lVar2 = this.changeAllAreaState;
        if (lVar2 != null) {
          if (lVar2.Count <= areaStateType) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          fVar1 = lVar2._items[areaStateType];
          return ((float)lv * *(float *)(*(int64 *)(DAT_181e538e8 + 184) + 300) + 1.0) * fVar1 *
                 produceRate;
        }
    }

    // Token : 0x6000F63
    // RVA   : 0x78F440   Offset: 0x78E240   Length: 0x9B
    public List<float> GetTotalChangeResource(int lv, float produceRate)
    {
        ulong uVar1;
        uVar1 = this.changeResource;
        GlobalData.ListMulti
                  (uVar1,((float)lv * *(float *)(*(int64 *)(DAT_181e538e8 + 184) + 300) + 1.0) *
                         produceRate,0);
    }

    // Token : 0x6000F64
    // RVA   : 0x78F4E0   Offset: 0x78E2E0   Length: 0x6C
    public List<float> GetUpgradeCostResource(int lv)
    {
        ulong uVar1;
        uVar1 = this.upgradeResource;
        GlobalData.ListMulti(uVar1);
    }

    // Token : 0x6000F65
    // RVA   : 0x78DC10   Offset: 0x78CA10   Length: 0x175
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

}
