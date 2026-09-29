// ============================================================
// Type  : <ShowItemParticle>d__55
// Token : 0x2000259
// ============================================================

public class <ShowItemParticle>d__55
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x40012CF
    private int <>1__state;

    // Token: 0x40012D0
    private object <>2__current;

    // Token: 0x40012D1
    public float delayTime;

    // Token: 0x40012D2
    public GameObject targetItemIcon;

    // Token: 0x40012D3
    public GameObject targetParticle;

    // Token: 0x40012D4
    public float scale;

    // Token: 0x40012D5
    public int rareLv;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6001370
    // RVA   : 0x219070   Offset: 0x218470   Length: 0x24
    public void /*ctor*/(int <>1__state)
    {
        ZhSegment.Initialize(this,0);
        this.<>1__state = <>1__state;
    }

    // Token : 0x6001371
    // RVA   : 0x245810   Offset: 0x244C10   Length: 0x3
    private virtual void System.IDisposable.Dispose()
    {
    }

    // Token : 0x6001372
    // RVA   : 0x933950   Offset: 0x932D50   Length: 0x2DB
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
                lVar8 = GameObject.GetComponent(this.targetItemIcon,DAT_181d720a0);
                if ((lVar8 == null) || (*(int64 *)(lVar8 + 32) == 0)) throw; // [null/range check failed]
                uVar9 = *(uint32 *)(*(int64 *)(lVar8 + 32) + 64);
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

    // Token : 0x6001373
    // RVA   : 0x20F140   Offset: 0x20E540   Length: 0x5
    private virtual object System.Collections.Generic.IEnumerator<System.object>.get_Current()
    {
        return this.<>2__current;
    }

    // Token : 0x6001374
    // RVA   : 0x933C30   Offset: 0x933030   Length: 0x3E
    private virtual void System.Collections.IEnumerator.Reset()
    {
        ulong uVar1;
        ulong uVar2;
        uVar1 = il2cpp_runtime_class_init(&DAT_181d8d528);
        uVar1 = il2cpp_internal(uVar1);
        NotSupportedException.ctor(uVar1,0);
        uVar2 = il2cpp_runtime_class_init(&DAT_181d9a850);
    }

    // Token : 0x6001375
    // RVA   : 0x20F140   Offset: 0x20E540   Length: 0x5
    private virtual object System.Collections.IEnumerator.get_Current()
    {
        return this.<>2__current;
    }

}
