// ============================================================
// Type  : AreaRoadData
// Token : 0x20001F1
// ============================================================

public class AreaRoadData
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4000DDA
    public int areaID;

    // Token: 0x4000DDB
    public int roadLv;

    // Token: 0x4000DDC
    public int upgradeTimeLeft;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000F87
    // RVA   : 0x7EDB60   Offset: 0x7ECF60   Length: 0x287
    public string GetUpgradeCostText()
    {
        int iVar1;
        long lVar2;
        ulong uVar3;
        ulong uVar4;
        float fVar5;
        float fVar6;
        uint[] local_res8 = new uint[2];
        iVar1 = this.roadLv;
        lVar2 = AreaRoadData.GetArea(this,0);
        if ((lVar2 != null) && (*(int64 *)(lVar2 + 176) != 0)) {
          fVar5 = (float)ForceSpeAddData.Get(*(int64 *)(lVar2 + 176),13);
          fVar5 = fVar5 + 1.0;
          lVar2 = AreaRoadData.GetArea(this,0);
          if (lVar2 != null) {
            if (*(int *)(lVar2 + 112) != -1) {
              lVar2 = AreaRoadData.GetArea(this,0);
              if (lVar2 == null) throw; // [null/range check failed]
              lVar2 = AreaData.GetForce(lVar2,0);
              if ((lVar2 == null) || (*(int64 *)(lVar2 + 0x148) == 0)) throw; // [null/range check failed]
              fVar6 = (float)ForceSpeAddData.Get(*(int64 *)(lVar2 + 0x148),12);
              fVar5 = fVar5 + fVar6;
            }
            local_res8[0] = Mathf.RoundToInt(((float)(iVar1 + 1) * 10.0) / fVar5,0);
            uVar3 = il2cpp_value_box(DAT_181d80430,local_res8);
            lVar2 = il2cpp_internal(DAT_181d96ee8);
            FUN_181330100(lVar2,DAT_181da0d10);
            if (lVar2 != null) {
              FUN_18181e420(lVar2);
              FUN_18181e420(lVar2);
              FUN_18181e420(lVar2);
              FUN_18181e420(lVar2);
              FUN_18181e420(lVar2);
              FUN_18181e420(lVar2);
              uVar4 = GlobalData.ListMulti(lVar2);
              uVar4 = GlobalData.GetResourceDescribe(uVar4,0);
              String.Format("消耗 ({0}天)\n{1}",uVar3,uVar4,0);
              return;
            }
          }
        }
    }

    // Token : 0x6000F88
    // RVA   : 0x7EDA30   Offset: 0x7ECE30   Length: 0x12F
    public List<float> GetUpgradeCostResource()
    {
        long lVar1;
        lVar1 = il2cpp_internal(DAT_181d96ee8);
        FUN_181330100(lVar1,DAT_181da0d10);
        if (lVar1 != null) {
          FUN_18181e420(lVar1);
          FUN_18181e420(lVar1);
          FUN_18181e420(lVar1);
          FUN_18181e420(lVar1);
          FUN_18181e420(lVar1);
          FUN_18181e420(lVar1);
          GlobalData.ListMulti(lVar1);
          return;
        }
    }

    // Token : 0x6000F89
    // RVA   : 0x7EDDF0   Offset: 0x7ED1F0   Length: 0xCC
    public int GetUpgradeTime()
    {
        int iVar1;
        long lVar2;
        float fVar3;
        float fVar4;
        iVar1 = this.roadLv;
        lVar2 = AreaRoadData.GetArea(this,0);
        if ((lVar2 != null) && (*(int64 *)(lVar2 + 176) != 0)) {
          fVar3 = (float)ForceSpeAddData.Get(*(int64 *)(lVar2 + 176),13);
          fVar3 = fVar3 + 1.0;
          lVar2 = AreaRoadData.GetArea(this,0);
          if (lVar2 != null) {
            if (*(int *)(lVar2 + 112) == -1) {
        LAB_1807ede8b:
              Mathf.RoundToInt(((float)(iVar1 + 1) * 10.0) / fVar3,0);
              return;
            }
            lVar2 = AreaRoadData.GetArea(this,0);
            if (lVar2 != null) {
              lVar2 = AreaData.GetForce(lVar2,0);
              if ((lVar2 != null) && (*(int64 *)(lVar2 + 0x148) != 0)) {
                fVar4 = (float)ForceSpeAddData.Get(*(int64 *)(lVar2 + 0x148),12);
                fVar3 = fVar3 + fVar4;
                goto LAB_1807ede8b;
              }
            }
          }
        }
    }

    // Token : 0x6000F8A
    // RVA   : 0x7ED740   Offset: 0x7ECB40   Length: 0xA3
    public float GetBuildSpeedRate()
    {
        long lVar1;
        float fVar2;
        float fVar3;
        lVar1 = AreaRoadData.GetArea(this,0);
        if ((lVar1 != null) && (*(int64 *)(lVar1 + 176) != 0)) {
          fVar2 = (float)ForceSpeAddData.Get(*(int64 *)(lVar1 + 176),13);
          lVar1 = AreaRoadData.GetArea(this,0);
          if (lVar1 != null) {
            if (*(int *)(lVar1 + 112) == -1) {
              return fVar2 + 1.0;
            }
            lVar1 = AreaRoadData.GetArea(this,0);
            if (((lVar1 != null) && (lVar1 = AreaData.GetForce(lVar1,0)) != null) &&
               (*(int64 *)(lVar1 + 0x148) != 0)) {
              fVar3 = (float)ForceSpeAddData.Get(*(int64 *)(lVar1 + 0x148),12);
              return fVar2 + 1.0 + fVar3;
            }
          }
        }
    }

    // Token : 0x6000F8B
    // RVA   : 0x7ED680   Offset: 0x7ECA80   Length: 0xBE
    public AreaData GetArea()
    {
        long lVar1;
        if ((GameController._instance != null) &&
           (lVar1 = GameController._instance.worldData) != null) {
          WorldData.GetArea(lVar1,this.areaID,0);
          return;
        }
    }

    // Token : 0x6000F8C
    // RVA   : 0x7ED7F0   Offset: 0x7ECBF0   Length: 0x11
    public float GetProduceRateChange()
    {
        return (float)this.roadLv * 0.05;
    }

    // Token : 0x6000F8D
    // RVA   : 0x7ED810   Offset: 0x7ECC10   Length: 0x213
    public string GetRoadDescribe()
    {
        uint uVar1;
        ulong uVar2;
        ulong uVar3;
        long lVar4;
        ulong uVar5;
        ulong uVar6;
        int[] local_res8 = new int[2];
        float[] local_res18 = new float[2];
        uVar1 = this.roadLv;
        local_res8[0] = 0;
        uVar2 = GlobalData.GetNumText(uVar1,0);
        uVar3 = String.Format("<size=17>道路 {0}级</size>",uVar2,0);
        lVar4 = AreaRoadData.GetArea(this,0);
        uVar2 = "\n\n每月产出\n{2}{0}</color>\n\n周边效率+{1}%";
        if (lVar4 == null) {
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
        if (*(int *)(lVar4 + 72) == 2) {
          uVar5 = Int32.ToString(this + 20,0);
          uVar6 = "威望+";
        }
        else {
          local_res8[0] = this.roadLv * 5;
          uVar5 = Int32.ToString(local_res8,0);
          uVar6 = "人口+";
        }
        uVar6 = String.Concat(uVar6,uVar5,0);
        local_res18[0] = (float)this.roadLv * 0.05 * 100.0;
        uVar5 = il2cpp_value_box(DAT_181da22f0,local_res18);
        uVar6 = String.Format(uVar2,uVar6,uVar5,
                               *(uint64 *)(*(int64 *)(DAT_181d73d40 + 184) + 0x268),0);
        uVar2 = "";
        if (0 < this.upgradeTimeLeft) {
          uVar2 = Int32.ToString(this + 24,0);
          uVar2 = String.Concat("\n\n升级中 ",uVar2,"天",0);
        }
        String.Concat(uVar3,uVar6,uVar2,0);
    }

    // Token : 0x6000F8E
    // RVA   : 0x248060   Offset: 0x247460   Length: 0x34
    public void /*ctor*/(int _areaID, int _roadLv)
    {
        ZhSegment.Initialize(this,0);
        this.areaID = _areaID;
        this.roadLv = _roadLv;
    }

    // Token : 0x6000F8F
    // RVA   : 0x7ED500   Offset: 0x7EC900   Length: 0x175
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
