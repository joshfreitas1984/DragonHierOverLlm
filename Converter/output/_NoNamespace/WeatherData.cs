// ============================================================
// Type  : WeatherData
// Token : 0x20003B2
// ============================================================

public class WeatherData
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001DE1
    public string name;

    // Token: 0x4001DE2
    public float baseLastTime;

    // Token: 0x4001DE3
    public List<int> nextAvailableWeatherID;

    // Token: 0x4001DE4
    public GameObject weatherSpeObj;

    // Token: 0x4001DE5
    public List<GameObject> weatherSpeObjs;

    // Token: 0x4001DE6
    public List<float> weatherSpeObjOriginEmitRate;

    // Token: 0x4001DE7
    public WeatherSpeShowType weatherSpeShowType;

    // Token: 0x4001DE8
    public float weatherTravelSpeedRate;

    // Token: 0x4001DE9
    public float baseRandomRate;

    // Token: 0x4001DEA
    public int maxRateMonth;

    // Token: 0x4001DEB
    public bool generateThunder;

    // Token: 0x4001DEC
    public float maxVolumn;

    // Token: 0x4001DED
    public float cloudNumRate;

    // Token: 0x4001DEE
    public float cloudSpeedRate;

    // Token: 0x4001DEF
    public Color cloudColor;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x600237E
    // RVA   : 0x9C6C70   Offset: 0x9C6070   Length: 0x156
    public float GetRandomRate()
    {
        uint uVar1;
        int iVar2;
        uint uVar3;
        byte[] auVar4 = new byte[16];
        byte[] auVar5 = new byte[16];
        uint64 extraout_XMM0_Qb;
        if (this.maxRateMonth != null) {
          uVar1 = Mathf.Abs(this.maxRateMonth - param_2,0);
          iVar2 = Mathf.Abs(this.maxRateMonth - param_2,0);
          uVar3 = Mathf.Abs(12 - iVar2,0);
          Mathf.Min(uVar1,uVar3,0);
          auVar4._0_8_ = Mathf.Max();
          auVar4._8_8_ = extraout_XMM0_Qb;
          auVar5._4_12_ = auVar4._4_12_;
          auVar5._0_4_ = (float)auVar4._0_8_ * this.baseRandomRate;
          return auVar5._0_8_;
        }
        return (uint64)this.baseRandomRate;
    }

    // Token : 0x600237F
    // RVA   : 0x9C6DD0   Offset: 0x9C61D0   Length: 0x97
    public float GetRandomRate(int targetMonth)
    {
        uint uVar1;
        int iVar2;
        uint uVar3;
        byte[] auVar4 = new byte[16];
        byte[] auVar5 = new byte[16];
        uint64 extraout_XMM0_Qb;
        if (this.maxRateMonth != null) {
          uVar1 = Mathf.Abs(this.maxRateMonth - targetMonth,0);
          iVar2 = Mathf.Abs(this.maxRateMonth - targetMonth,0);
          uVar3 = Mathf.Abs(12 - iVar2,0);
          Mathf.Min(uVar1,uVar3,0);
          auVar4._0_8_ = Mathf.Max();
          auVar4._8_8_ = extraout_XMM0_Qb;
          auVar5._4_12_ = auVar4._4_12_;
          auVar5._0_4_ = (float)auVar4._0_8_ * this.baseRandomRate;
          return auVar5._0_8_;
        }
        return (uint64)this.baseRandomRate;
    }

    // Token : 0x6002380
    // RVA   : 0x9C6E70   Offset: 0x9C6270   Length: 0x39
    public void /*ctor*/()
    {
        uint uVar1;
        uint uVar2;
        uint uVar3;
        byte[] local_18 = new byte[16];
        this.cloudNumRate = 0x3f800000;
        this.cloudSpeedRate = 0x3f800000;
        puVar4 = (uint32 *)FUN_1810d3570(local_18,0);
        uVar1 = puVar4[1];
        uVar2 = puVar4[2];
        uVar3 = puVar4[3];
        this.cloudColor = *puVar4;
        *(uint32 *)(this + 100) = uVar1;
        *(uint32 *)(this + 104) = uVar2;
        *(uint32 *)(this + 108) = uVar3;
        ZhSegment.Initialize(this,0);
    }

}
