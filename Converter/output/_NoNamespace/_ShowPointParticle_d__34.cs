// ============================================================
// Type  : <ShowPointParticle>d__34
// Token : 0x2000384
// ============================================================

public class <ShowPointParticle>d__34
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001CD2
    private int <>1__state;

    // Token: 0x4001CD3
    private object <>2__current;

    // Token: 0x4001CD4
    public float delayTime;

    // Token: 0x4001CD5
    public StudyInternalPointController <>4__this;

    // Token: 0x4001CD6
    public GameObject targetParticle;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6002273
    // RVA   : 0x219070   Offset: 0x218470   Length: 0x24
    public void /*ctor*/(int <>1__state)
    {
        ZhSegment.Initialize(this,0);
        this.<>1__state = <>1__state;
    }

    // Token : 0x6002274
    // RVA   : 0x245810   Offset: 0x244C10   Length: 0x3
    private virtual void System.IDisposable.Dispose()
    {
    }

    // Token : 0x6002275
    // RVA   : 0x8F3320   Offset: 0x8F2720   Length: 0x2C2
    private virtual bool MoveNext()
    {
        uint uVar1;
        uint uVar2;
        long lVar3;
        ulong uVar4;
        long lVar5;
        ulong uVar6;
        long lVar8;
        ulong local_58;
        float local_50;
        ulong local_48;
        float local_40;
        byte[] local_38 = new byte[16];
        uint local_28;
        uint uStack_24;
        uint uStack_20;
        uint32 uStack_1c;
        lVar3 = this.<>4__this;
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
        this.<>1__state = 0xffffffff;
        if (lVar3 != null) {
          lVar5 = Component.get_transform(lVar3,0);
          if (lVar5 != null) {
            lVar5 = FUN_180da9a20(lVar5,0);
            if (lVar5 != null) {
              uVar6 = Component.get_gameObject(lVar5,0);
              uVar4 = this.targetParticle;
              lVar5 = Component.get_transform(lVar3,0);
              if (lVar5 != null) {
                puVar7 = (uint64 *)Transform.get_localPosition(local_38,lVar5,0);
                local_58 = *puVar7;
                local_50 = *(float *)(puVar7 + 1);
                lVar5 = GlobalData.AddChild(uVar6,uVar4,&local_58,0);
                if (lVar5 != null) {
                  lVar8 = GameObject.get_transform(lVar5,0);
                  puVar7 = (uint64 *)Vector3.get_one(&local_28,0);
                  local_48 = *puVar7;
                  local_40 = *(float *)(puVar7 + 1);
                  local_50 = local_40 * 0.003;
                  local_58 = CONCAT44((float)((uint64)local_48 >> 32) * 0.003,(float)local_48 * 0.003
                                     );
                  if (lVar8 != null) {
                    local_48 = local_58;
                    local_40 = local_50;
                    Transform.set_localScale(lVar8,&local_48,0);
                    lVar8 = FUN_18046c100(0);
                    if ((lVar8 != null) && (lVar8 = *(int64 *)(lVar8 + 56)) != null) {
                      uVar2 = *(uint32 *)(lVar3 + 36);
                      if (*(uint32 *)(lVar8 + 24) <= uVar2) {
                        ThrowHelper.ThrowArgumentOutOfRangeException(0);
                      }
                      lVar3 = lVar8[uVar2]
                      ;
                      if (lVar3 != null) {
                        local_28 = *(uint32 *)(lVar3 + 24);
                        uStack_24 = *(uint32 *)(lVar3 + 28);
                        uStack_20 = *(uint32 *)(lVar3 + 32);
                        uStack_1c = *(uint32 *)(lVar3 + 36);
                        GlobalData.SetParticleColor(lVar5,&local_28,0);
                        return false;
                      }
                    }
                  }
                }
              }
            }
          }
        }
    }

    // Token : 0x6002276
    // RVA   : 0x20F140   Offset: 0x20E540   Length: 0x5
    private virtual object System.Collections.Generic.IEnumerator<System.object>.get_Current()
    {
        return this.<>2__current;
    }

    // Token : 0x6002277
    // RVA   : 0x8F35F0   Offset: 0x8F29F0   Length: 0x3E
    private virtual void System.Collections.IEnumerator.Reset()
    {
        ulong uVar1;
        ulong uVar2;
        uVar1 = il2cpp_runtime_class_init(&DAT_181d8d510);
        uVar1 = il2cpp_internal(uVar1);
        NotSupportedException.ctor(uVar1,0);
        uVar2 = il2cpp_runtime_class_init(&DAT_181db4b18);
    }

    // Token : 0x6002278
    // RVA   : 0x20F140   Offset: 0x20E540   Length: 0x5
    private virtual object System.Collections.IEnumerator.get_Current()
    {
        return this.<>2__current;
    }

}
