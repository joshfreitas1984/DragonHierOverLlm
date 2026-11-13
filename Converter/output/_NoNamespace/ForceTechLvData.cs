// ============================================================
// Type  : ForceTechLvData
// Token : 0x20001EA
// ============================================================

public class ForceTechLvData
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4000D6F
    public int techID;

    // Token: 0x4000D70
    public int lv;

    // Token: 0x4000D71
    public float researchPercent;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000F36
    // RVA   : 0x608BA0   Offset: 0x6079A0   Length: 0x24
    public void /*ctor*/(int _techID)
    {
        ZhSegment.Initialize(this,0);
        this.techID = _techID;
    }

    // Token : 0x6000F37
    // RVA   : 0x1858BA0   Offset: 0x18579A0   Length: 0x50
    public float GetEachDayResearchPercent(float researchSpeed)
    {
        long lVar1;
        lVar1 = ForceTechLvData.Database(this,0);
        if (lVar1 != null) {
          return;
        }
    }

    // Token : 0x6000F38
    // RVA   : 0x1858D70   Offset: 0x1857B70   Length: 0x71
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

    // Token : 0x6000F39
    // RVA   : 0x1858C00   Offset: 0x1857A00   Length: 0x16A
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
            lVar6 = *(int64 *)(*(int64 *)(DAT_181e538e8 + 184) + 0x450);
            lVar7 = ForceTechLvData.Database(this,0);
            if ((lVar7 != null) && (lVar6 != null)) {
              uVar5 = *(uint32 *)(lVar7 + 60);
              if (*(uint32 *)(lVar6 + 24) <= uVar5) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              fVar2 = lVar6[uVar5];
              uVar8 = il2cpp_internal(DAT_181e7cad8);
              PlotChoiceRequirement.ctor
                        (uVar8,uVar3,(((float)iVar4 + 1.0) * fVar1 * 500.0 * costRate) / fVar2,0);
              return uVar8;
            }
          }
        }
    }

    // Token : 0x6000F3A
    // RVA   : 0x1858DF0   Offset: 0x1857BF0   Length: 0xB
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

    // Token : 0x6000F3B
    // RVA   : 0x1858E00   Offset: 0x1857C00   Length: 0x70
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

    // Token : 0x6000F3C
    // RVA   : 0x18590D0   Offset: 0x1857ED0   Length: 0xB
    public string GetSpeDescribe()
    {
        uint uVar1;
        long lVar2;
        ulong uVar3;
        long lVar4;
        ulong uVar5;
        float[] local_res20 = new float[2];
        lVar2 = GameController.ChangeAllAreaStateIDs;
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
              lVar2 = GameController.ChangeAllAreaStateIDs;
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

    // Token : 0x6000F3D
    // RVA   : 0x1858E80   Offset: 0x1857C80   Length: 0x24E
    public string GetSpeDescribe(int _lv)
    {
        uint uVar1;
        long lVar2;
        ulong uVar3;
        long lVar4;
        ulong uVar5;
        float[] local_res20 = new float[2];
        lVar2 = GameController.ChangeAllAreaStateIDs;
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
              lVar2 = GameController.ChangeAllAreaStateIDs;
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

    // Token : 0x6000F3E
    // RVA   : 0x1858AC0   Offset: 0x18578C0   Length: 0xD2
    public ForceTechDataBase Database()
    {
        long lVar1;
        lVar1 = *(int64 *)(*(int64 *)(DAT_181e528f8 + 184) + 32);
        if ((lVar1 != null) && (lVar1 = *(int64 *)(lVar1 + 160)) != null) {
          FUN_18171b450(lVar1,this.techID,DAT_181e9aff8);
          return;
        }
    }

    // Token : 0x6000F3F
    // RVA   : 0x1858940   Offset: 0x1857740   Length: 0x175
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
