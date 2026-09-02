// ============================================================
// Type  : BattleMapTypeData
// Token : 0x200015A
// ============================================================

public class BattleMapTypeData
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x40008A8
    public BattleMapType battleMapType;

    // Token: 0x40008A9
    public int column;

    // Token: 0x40008AA
    public int row;

    // Token: 0x40008AB
    public AttackAreaType attackAreaType;

    // Token: 0x40008AC
    public AreaData targetArea;

    // Token: 0x40008AD
    public int difficulty;

    // Token: 0x40008AE
    public float defenceHpRate;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000AD7
    // RVA   : 0x8DF320   Offset: 0x8DDB20   Length: 0x3F6
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

    // Token : 0x6000AD8
    // RVA   : 0x8DF080   Offset: 0x8DD880   Length: 0xEF
    public float GetTimeMapScaleRate()
    {
        var pStatics = *(int64*)(DAT_181d4df90 + 184);
        long lVar1;
        float fVar2;
        if (((*pStatics != 0) &&
            (lVar1 = *(int64 *)(*pStatics + 32)) != null) &&
           (lVar1 = *(int64 *)(lVar1 + 168)) != null) {
          fVar2 = (float)TimeData.GetExactYear(lVar1,0);
          fVar2 = (float)Mathf.Max(0,11.0 - fVar2,0);
          return 1.0 - fVar2 * 0.025;
        }
    }

    // Token : 0x6000AD9
    // RVA   : 0x8DF170   Offset: 0x8DD970   Length: 0x1AF
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

    // Token : 0x6000ADA
    // RVA   : 0x8DF720   Offset: 0x8DDF20   Length: 0x4B
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
