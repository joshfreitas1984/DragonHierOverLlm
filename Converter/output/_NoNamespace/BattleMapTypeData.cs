// ============================================================
// Type  : BattleMapTypeData
// Token : 0x200015A
// ============================================================

public class BattleMapTypeData
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x40008B0
    public BattleMapType battleMapType;

    // Token: 0x40008B1
    public int column;

    // Token: 0x40008B2
    public int row;

    // Token: 0x40008B3
    public AttackAreaType attackAreaType;

    // Token: 0x40008B4
    public AreaData targetArea;

    // Token: 0x40008B5
    public int difficulty;

    // Token: 0x40008B6
    public float defenceHpRate;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000AD9
    // RVA   : 0x5EA1D0   Offset: 0x5E8FD0   Length: 0x3F6
    public void /*ctor*/(BattleMapType _battleMapType)
    {
        void BattleMapTypeData.ctor
                     (int64 this,uint32 _battleMapType,uint32 param_3,uint32 param_4)
        {
        this.defenceHpRate = 0x3f800000;
        ZhSegment.Initialize(this,0);
        this.battleMapType = _battleMapType;
        this.column = param_3;
        this.row = param_4;
    }

    // Token : 0x6000ADA
    // RVA   : 0x5E9F30   Offset: 0x5E8D30   Length: 0xEF
    public float GetTimeMapScaleRate()
    {
        long lVar1;
        float fVar2;
        if (((GameController._instance != null) &&
            (lVar1 = GameController._instance.worldData) != null) &&
           (lVar1 = lVar1.worldTime) != null) {
          fVar2 = (float)TimeData.GetExactYear(lVar1,0);
          fVar2 = (float)Mathf.Max(0,11.0 - fVar2,0);
          return 1.0 - fVar2 * 0.025;
        }
    }

    // Token : 0x6000ADB
    // RVA   : 0x5EA020   Offset: 0x5E8E20   Length: 0x1AF
    public void /*ctor*/(AttackAreaType _attackAreaType, int _difficulty)
    {
        void BattleMapTypeData.ctor
                     (int64 this,uint32 _attackAreaType,uint32 _difficulty,uint32 param_4)
        {
        this.defenceHpRate = 0x3f800000;
        ZhSegment.Initialize(this,0);
        this.battleMapType = _attackAreaType;
        this.column = _difficulty;
        this.row = param_4;
    }

    // Token : 0x6000ADC
    // RVA   : 0x5EA5D0   Offset: 0x5E93D0   Length: 0x4B
    public void /*ctor*/(BattleMapType _battleMapType, int _column, int _row)
    {
        void BattleMapTypeData.ctor
                     (int64 this,uint32 _battleMapType,uint32 _column,uint32 _row)
        {
        this.defenceHpRate = 0x3f800000;
        ZhSegment.Initialize(this,0);
        this.battleMapType = _battleMapType;
        this.column = _column;
        this.row = _row;
    }

}
