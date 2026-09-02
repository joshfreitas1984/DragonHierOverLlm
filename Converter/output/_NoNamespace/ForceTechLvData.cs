// ============================================================
// Type  : ForceTechLvData
// Token : 0x20001E2
// ============================================================

public class ForceTechLvData
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4000CCD
    public int techID;

    // Token: 0x4000CCE
    public int lv;

    // Token: 0x4000CCF
    public float researchPercent;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000EF8
    // RVA   : 0x219070   Offset: 0x217870   Length: 0x24
    public void /*ctor*/(int _techID)
    {
        ZhSegment.Initialize(this,0);
        this.techID = _techID;
    }

    // Token : 0x6000EF9
    // RVA   : 0x786DB0   Offset: 0x7855B0   Length: 0x50
    public float GetEachDayResearchPercent(float researchSpeed)
    {
        long lVar1;
        lVar1 = ForceTechLvData.Database(this,0);
        if (lVar1 != null) {
          return;
        }
    }

    // Token : 0x6000EFA
    // RVA   : 0x786F80   Offset: 0x785780   Length: 0x71
    public int GetResearchLeftDay(float researchSpeed)
    {
        float fVar1;
        int iVar2;
        long lVar3;
        iVar2 = this.lv;
        fVar1 = this.researchPercent;
        lVar3 = ForceTechLvData.Database(this,0);
        if (lVar3 != null) {
          Mathf.CeilToInt((1.0 - fVar1) /
                           ((researchSpeed * 0.05) / (((float)iVar2 + 1.0) * *(float *)(lVar3 + 56))),0);
          return;
        }
    }

    // Token : 0x6000EFB
    // RVA   : 0x786E10   Offset: 0x785610   Length: 0x16A
    public ResourceData GetResearchCostResource(float costRate)
    {
        float fVar1;
        float fVar2;
        uint uVar3;
        int iVar4;
        uint uVar5;
        long lVar6;
        long lVar7;
        ulong uVar8;
        lVar6 = ForceTechLvData.Database(this,0);
        if (lVar6 != null) {
          uVar3 = *(uint32 *)(lVar6 + 60);
          iVar4 = this.lv;
          lVar6 = ForceTechLvData.Database(this,0);
          if (lVar6 != null) {
            fVar1 = *(float *)(lVar6 + 56);
            lVar6 = *(int64 *)(*(int64 *)(DAT_181d4ef00 + 184) + 0x440);
            lVar7 = ForceTechLvData.Database(this,0);
            if ((lVar7 != null) && (lVar6 != null)) {
              uVar5 = *(uint32 *)(lVar7 + 60);
              if (*(uint32 *)(lVar6 + 24) <= uVar5) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              fVar2 = lVar6[uVar5];
              uVar8 = il2cpp_internal(DAT_181d774d0);
              PlotChoiceRequirement.ctor
                        (uVar8,uVar3,(((float)iVar4 + 1.0) * fVar1 * 500.0 * costRate) / fVar2,0);
              return uVar8;
            }
          }
        }
    }

    // Token : 0x6000EFC
    // RVA   : 0x787000   Offset: 0x785800   Length: 0xB
    public float GetSpeAddNum()
    {
        long lVar1;
        float fVar2;
        lVar1 = ForceTechLvData.Database(this,0);
        if (lVar1 != null) {
          if (*(char *)(lVar1 + 52) == false) {
            fVar2 = (float)((param_2 + 1) * param_2) * 0.5;
          }
          else {
            fVar2 = (float)param_2;
          }
          lVar1 = ForceTechLvData.Database(this,0);
          if (lVar1 != null) {
            return fVar2 * *(float *)(lVar1 + 48);
          }
        }
    }

    // Token : 0x6000EFD
    // RVA   : 0x787010   Offset: 0x785810   Length: 0x70
    public float GetSpeAddNum(int _lv)
    {
        long lVar1;
        float fVar2;
        lVar1 = ForceTechLvData.Database(this,0);
        if (lVar1 != null) {
          if (*(char *)(lVar1 + 52) == false) {
            fVar2 = (float)((_lv + 1) * _lv) * 0.5;
          }
          else {
            fVar2 = (float)_lv;
          }
          lVar1 = ForceTechLvData.Database(this,0);
          if (lVar1 != null) {
            return fVar2 * *(float *)(lVar1 + 48);
          }
        }
    }

    // Token : 0x6000EFE
    // RVA   : 0x7872E0   Offset: 0x785AE0   Length: 0xB
    public string GetSpeDescribe()
    {
        var pStatics = *(int64*)(DAT_181d4e010 + 184);
        uint uVar1;
        long lVar2;
        ulong uVar3;
        long lVar4;
        ulong uVar5;
        float[] local_res20 = new float[2];
        lVar2 = *(int64 *)(pStatics + 32);
        if (lVar2 != null) {
          lVar2 = *(int64 *)(lVar2 + 152);
          lVar4 = ForceTechLvData.Database(this,0);
          if ((lVar4 != null) && (lVar2 != null)) {
            uVar1 = *(uint32 *)(lVar4 + 44);
            if (*(uint32 *)(lVar2 + 24) <= uVar1) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            lVar2 = lVar2[uVar1];
            if (lVar2 != null) {
              uVar3 = *(uint64 *)(lVar2 + 16);
              lVar2 = *(int64 *)(pStatics + 32);
              if (lVar2 != null) {
                lVar2 = *(int64 *)(lVar2 + 152);
                lVar4 = ForceTechLvData.Database(this,0);
                if ((lVar4 != null) && (lVar2 != null)) {
                  uVar1 = *(uint32 *)(lVar4 + 44);
                  if (*(uint32 *)(lVar2 + 24) <= uVar1) {
                    ThrowHelper.ThrowArgumentOutOfRangeException(0);
                  }
                  lVar2 = lVar2[uVar1];
                  if (lVar2 != null) {
                    if (*(char *)(lVar2 + 32) == false) {
                      local_res20[0] = (float)ForceTechLvData.GetSpeAddNum(this,param_2);
                      uVar5 = Single.ToString(local_res20,"+0;-0;+0",0);
                    }
                    else {
                      local_res20[0] = (float)ForceTechLvData.GetSpeAddNum(this,param_2);
                      local_res20[0] = local_res20[0] * 100.0;
                      uVar5 = Single.ToString(local_res20,"+0;-0;+0",0);
                      uVar5 = String.Concat(uVar5,"%",0);
                    }
                    String.Concat(uVar3,uVar5,0);
                    return;
                  }
                }
              }
            }
          }
        }
    }

    // Token : 0x6000EFF
    // RVA   : 0x787090   Offset: 0x785890   Length: 0x24E
    public string GetSpeDescribe(int _lv)
    {
        var pStatics = *(int64*)(DAT_181d4e010 + 184);
        uint uVar1;
        long lVar2;
        ulong uVar3;
        long lVar4;
        ulong uVar5;
        float[] local_res20 = new float[2];
        lVar2 = *(int64 *)(pStatics + 32);
        if (lVar2 != null) {
          lVar2 = *(int64 *)(lVar2 + 152);
          lVar4 = ForceTechLvData.Database(this,0);
          if ((lVar4 != null) && (lVar2 != null)) {
            uVar1 = *(uint32 *)(lVar4 + 44);
            if (*(uint32 *)(lVar2 + 24) <= uVar1) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            lVar2 = lVar2[uVar1];
            if (lVar2 != null) {
              uVar3 = *(uint64 *)(lVar2 + 16);
              lVar2 = *(int64 *)(pStatics + 32);
              if (lVar2 != null) {
                lVar2 = *(int64 *)(lVar2 + 152);
                lVar4 = ForceTechLvData.Database(this,0);
                if ((lVar4 != null) && (lVar2 != null)) {
                  uVar1 = *(uint32 *)(lVar4 + 44);
                  if (*(uint32 *)(lVar2 + 24) <= uVar1) {
                    ThrowHelper.ThrowArgumentOutOfRangeException(0);
                  }
                  lVar2 = lVar2[uVar1];
                  if (lVar2 != null) {
                    if (*(char *)(lVar2 + 32) == false) {
                      local_res20[0] = (float)ForceTechLvData.GetSpeAddNum(this,_lv);
                      uVar5 = Single.ToString(local_res20,"+0;-0;+0",0);
                    }
                    else {
                      local_res20[0] = (float)ForceTechLvData.GetSpeAddNum(this,_lv);
                      local_res20[0] = local_res20[0] * 100.0;
                      uVar5 = Single.ToString(local_res20,"+0;-0;+0",0);
                      uVar5 = String.Concat(uVar5,"%",0);
                    }
                    String.Concat(uVar3,uVar5,0);
                    return;
                  }
                }
              }
            }
          }
        }
    }

    // Token : 0x6000F00
    // RVA   : 0x786CD0   Offset: 0x7854D0   Length: 0xD2
    public ForceTechDataBase Database()
    {
        long lVar1;
        lVar1 = *(int64 *)(*(int64 *)(DAT_181d4e010 + 184) + 32);
        if ((lVar1 != null) && (lVar1 = *(int64 *)(lVar1 + 160)) != null) {
          FUN_1817cc780(lVar1,this.techID,DAT_181d94420);
          return;
        }
    }

    // Token : 0x6000F01
    // RVA   : 0x786B50   Offset: 0x785350   Length: 0x175
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
