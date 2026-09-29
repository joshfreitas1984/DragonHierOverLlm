// ============================================================
// Type  : _ObjectsMakeBase
// Token : 0x20003D4
// ============================================================

public class _ObjectsMakeBase
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001EB4
    public GameObject[] m_makeObjs;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6002433
    // RVA   : 0x9D94B0   Offset: 0x9D88B0   Length: 0x12
    public float GetRandomValue(float value)
    {
        void FUN_1809d94b0(uint64 this,uint32 value)
        {
        Random.Range(value ^ 0x80000000,value,0);
    }

    // Token : 0x6002434
    // RVA   : 0x9D94A0   Offset: 0x9D88A0   Length: 0xB
    public float GetRandomValue2(float value)
    {
        void FUN_1809d94a0(uint64 this,uint64 value)
        {
        Random.Range(0,value,0);
    }

    // Token : 0x6002435
    // RVA   : 0x9D9550   Offset: 0x9D8950   Length: 0xF3
    public Vector3 GetRandomVector(Vector3 value)
    {
        ulong uVar1;
        uint uVar2;
        uint uVar3;
        uVar3 = *param_3;
        *this = 0;
        *(uint32 *)(this + 1) = 0;
        uVar2 = Random.Range(uVar3 ^ 0x80000000,uVar3,0);
        uVar1 = *(uint64 *)param_3;
        *(uint32 *)this = uVar2;
        uVar3 = (uint32)((uint64)uVar1 >> 32);
        uVar2 = Random.Range(uVar3 ^ 0x80000000,CONCAT44(uVar3,uVar3),0);
        uVar3 = param_3[2];
        *(uint32 *)((int64)this + 4) = uVar2;
        uVar2 = Random.Range(uVar3 ^ 0x80000000,uVar3,0);
        *(uint32 *)(this + 1) = uVar2;
        return this;
    }

    // Token : 0x6002436
    // RVA   : 0x9D94D0   Offset: 0x9D88D0   Length: 0x72
    public Vector3 GetRandomVector2(Vector3 value)
    {
        uint64 *
        ObjectsMakeBase.GetRandomVector2(uint64 *this,uint64 value,uint32 *param_3)
        {
        uint32 uVar1;
        uint32 uVar2;
        *this = 0;
        *(uint32 *)(this + 1) = 0;
        uVar1 = Random.Range(0,*param_3,0);
        uVar2 = param_3[1];
        *(uint32 *)this = uVar1;
        uVar1 = Random.Range(0,uVar2,0);
        uVar2 = param_3[2];
        *(uint32 *)((int64)this + 4) = uVar1;
        uVar2 = Random.Range(0,uVar2,0);
        *(uint32 *)(this + 1) = uVar2;
        return this;
    }

    // Token : 0x6002437
    // RVA   : 0x3A17B0   Offset: 0x3A0BB0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_18044ef50(this,0);
    }

}
