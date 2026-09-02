// ============================================================
// Type  : <>c__DisplayClass231_1
// Token : 0x200016A
// ============================================================

public class <>c__DisplayClass231_1
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x400095B
    public Vector3 startPos;

    // Token: 0x400095C
    public Vector3 endPos;

    // Token: 0x400095D
    public float height;

    // Token: 0x400095E
    public <>c__DisplayClass231_0 CS$<>8__locals1;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000BCB
    // RVA   : 0x210B70   Offset: 0x20F370   Length: 0x7
    public void /*ctor*/()
    {
        ZhSegment.Initialize(this,0);
    }

    // Token : 0x6000BCC
    // RVA   : 0xB283A0   Offset: 0xB26BA0   Length: 0x15C
    internal void <BattleUnitAttackHappen>b__1(float value)
    {
        uint uVar1;
        long lVar2;
        ulong local_78;
        uint local_70;
        ulong local_68;
        uint local_60;
        byte[] local_58 = new byte[80];
        if ((this.CS$<>8__locals1 != 0) &&
           (lVar2 = *(int64 *)(this.CS$<>8__locals1 + 16)) != null) {
          lVar2 = GameObject.get_transform(lVar2,0);
          local_68 = this.startPos;
          local_60 = *(uint32 *)(this + 24);
          local_78 = this.endPos;
          local_70 = *(uint32 *)(this + 36);
          uVar1 = this.height;
          puVar3 = (uint64 *)GlobalData.Parabola(local_58,&local_68,&local_78,uVar1,value,0);
          if (lVar2 != null) {
            local_68 = *puVar3;
            local_60 = *(uint32 *)(puVar3 + 1);
            Transform.set_localPosition(lVar2,&local_68,0);
            return;
          }
        }
    }

}
