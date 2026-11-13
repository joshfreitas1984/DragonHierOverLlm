// ============================================================
// Type  : WeatherData
// Token : 0x20003BF
// ============================================================

public class WeatherData
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001E74
    public string name;

    // Token: 0x4001E75
    public float baseLastTime;

    // Token: 0x4001E76
    public List<int> nextAvailableWeatherID;

    // Token: 0x4001E77
    public GameObject weatherSpeObj;

    // Token: 0x4001E78
    public List<GameObject> weatherSpeObjs;

    // Token: 0x4001E79
    public List<float> weatherSpeObjOriginEmitRate;

    // Token: 0x4001E7A
    public WeatherSpeShowType weatherSpeShowType;

    // Token: 0x4001E7B
    public float weatherTravelSpeedRate;

    // Token: 0x4001E7C
    public float baseRandomRate;

    // Token: 0x4001E7D
    public int maxRateMonth;

    // Token: 0x4001E7E
    public bool generateThunder;

    // Token: 0x4001E7F
    public float maxVolumn;

    // Token: 0x4001E80
    public float cloudNumRate;

    // Token: 0x4001E81
    public float cloudSpeedRate;

    // Token: 0x4001E82
    public Color cloudColor;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6002428
    // RVA   : 0x711E10   Offset: 0x710C10   Length: 0x156
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

    // Token : 0x6002429
    // RVA   : 0x711F70   Offset: 0x710D70   Length: 0x97
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

    // Token : 0x600242A
    // RVA   : 0x712010   Offset: 0x710E10   Length: 0x39
    public void /*ctor*/()
    {
        uint uVar1;
        uint uVar2;
        uint uVar3;
        byte[] local_18 = new byte[16];
        this.cloudNumRate = 0x3f800000;
        this.cloudSpeedRate = 0x3f800000;
        puVar4 = (uint32 *)FUN_180f24d00(local_18,0);
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
