// ============================================================
// Type  : <ShowItemParticle>d__54
// Token : 0x20001AB
// ============================================================

public class <ShowItemParticle>d__54
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4000BAD
    private int <>1__state;

    // Token: 0x4000BAE
    private object <>2__current;

    // Token: 0x4000BAF
    public float delayTime;

    // Token: 0x4000BB0
    public GameObject targetItemIcon;

    // Token: 0x4000BB1
    public GameObject targetParticle;

    // Token: 0x4000BB2
    public float scale;

    // Token: 0x4000BB3
    public int rareLv;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000DBE
    // RVA   : 0x219070   Offset: 0x218470   Length: 0x24
    public void /*ctor*/(int <>1__state)
    {
        ZhSegment.Initialize(this,0);
        this.<>1__state = <>1__state;
    }

    // Token : 0x6000DBF
    // RVA   : 0x245810   Offset: 0x244C10   Length: 0x3
    private virtual void System.IDisposable.Dispose()
    {
    }

    // Token : 0x6000DC0
    // RVA   : 0x932FE0   Offset: 0x9323E0   Length: 0x2CE
    private virtual bool MoveNext()
    {
        uint uVar1;
        float fVar2;
        ulong uVar3;
        ulong uVar4;
        long lVar6;
        long lVar7;
        long lVar8;
        uint uVar9;
        ulong local_58;
        float local_50;
        ulong local_48;
        float local_40;
        byte[] local_38 = new byte[16];
        ulong local_28;
        ulong uStack_20;
        if (this.<>1__state == 0) {
          uVar1 = this.delayTime;
          this.<>1__state = 0xffffffff;
          uVar4 = new WaitForSeconds(uVar1,0);
          this.<>2__current = uVar4;
          this.<>1__state = 1;
          return true;
        }
        if (this.<>1__state != 1) {
          return false;
        }
        uVar4 = this.targetItemIcon;
        uVar3 = this.targetParticle;
        this.<>1__state = 0xffffffff;
        puVar5 = (uint64 *)Vector3.get_zero(local_38,0);
        local_58 = *puVar5;
        local_50 = *(float *)(puVar5 + 1);
        lVar6 = GlobalData.AddChild(uVar4,uVar3,&local_58,0);
        if (lVar6 != null) {
          lVar7 = GameObject.get_transform(lVar6,0);
          fVar2 = this.scale;
          puVar5 = (uint64 *)Vector3.get_one(&local_28,0);
          local_48 = *puVar5;
          local_40 = *(float *)(puVar5 + 1);
          local_50 = local_40 * fVar2;
          local_58 = CONCAT44((float)((uint64)local_48 >> 32) * fVar2,(float)local_48 * fVar2);
          if (lVar7 != null) {
            local_48 = local_58;
            local_40 = local_50;
            Transform.set_localScale(lVar7,&local_48,0);
            lVar7 = FUN_18046c100(0);
            if (lVar7 != null) {
              uVar9 = this.rareLv;
              lVar7 = *(int64 *)(lVar7 + 56);
              if ((int)uVar9 < 0) {
                if (this.targetItemIcon == null) throw; // [null/range check failed]
                lVar8 = GameObject.GetComponent(this.targetItemIcon,DAT_181dc79e0);
                if (lVar8 == null) throw; // [null/range check failed]
                uVar9 = *(uint32 *)(lVar8 + 32);
              }
              if (lVar7 != null) {
                if (*(uint32 *)(lVar7 + 24) <= uVar9) {
                  ThrowHelper.ThrowArgumentOutOfRangeException(0);
                }
                lVar7 = lVar7[uVar9];
                if (lVar7 != null) {
                  uVar4 = *(uint64 *)(lVar7 + 24);
                  uVar3 = *(uint64 *)(lVar7 + 32);
                  local_28 = uVar4;
                  uStack_20 = uVar3;
                  GlobalData.SetParticleColor(lVar6,&local_28,0);
                  return false;
                }
              }
            }
          }
        }
    }

    // Token : 0x6000DC1
    // RVA   : 0x20F140   Offset: 0x20E540   Length: 0x5
    private virtual object System.Collections.Generic.IEnumerator<System.object>.get_Current()
    {
        return this.<>2__current;
    }

    // Token : 0x6000DC2
    // RVA   : 0x9332B0   Offset: 0x9326B0   Length: 0x3E
    private virtual void System.Collections.IEnumerator.Reset()
    {
        ulong uVar1;
        ulong uVar2;
        uVar1 = il2cpp_runtime_class_init(&DAT_181d8d510);
        uVar1 = il2cpp_internal(uVar1);
        NotSupportedException.ctor(uVar1,0);
        uVar2 = il2cpp_runtime_class_init(&DAT_181d988b8);
    }

    // Token : 0x6000DC3
    // RVA   : 0x20F140   Offset: 0x20E540   Length: 0x5
    private virtual object System.Collections.IEnumerator.get_Current()
    {
        return this.<>2__current;
    }

}
