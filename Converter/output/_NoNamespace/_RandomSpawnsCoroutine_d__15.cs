// ============================================================
// Type  : <RandomSpawnsCoroutine>d__15
// Token : 0x20003B4
// ============================================================

public class <RandomSpawnsCoroutine>d__15
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001D25
    private int <>1__state;

    // Token: 0x4001D26
    private object <>2__current;

    // Token: 0x4001D27
    public CFX_Demo <>4__this;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6002350
    // RVA   : 0x219070   Offset: 0x217870   Length: 0x24
    public void /*ctor*/(int <>1__state)
    {
        ZhSegment.Initialize(this,0);
        this.<>1__state = <>1__state;
    }

    // Token : 0x6002351
    // RVA   : 0x245810   Offset: 0x244010   Length: 0x3
    private virtual void System.IDisposable.Dispose()
    {
    }

    // Token : 0x6002352
    // RVA   : 0x8CF410   Offset: 0x8CDC10   Length: 0x31B
    private virtual bool MoveNext()
    {
        long lVar1;
        long lVar2;
        long lVar3;
        long lVar4;
        ulong uVar6;
        float fVar7;
        float fVar8;
        ulong uVar9;
        ulong local_78;
        float local_70;
        ulong local_68;
        float local_60;
        byte[] local_58 = new byte[80];
        lVar1 = this.<>4__this;
        if (1 < this.<>1__state) {
          return false;
        }
        this.<>1__state = 0xffffffff;
        if ((lVar1 != null) && (lVar2 = CFX_Demo.spawnParticle(lVar1)) != null) {
          if (*(char *)(lVar1 + 24) == false) {
            lVar3 = GameObject.get_transform(lVar2);
            lVar4 = Component.get_transform(lVar1,0);
            if (lVar4 != null) {
              puVar5 = (uint64 *)Transform.get_position(local_58,lVar4,0);
              uVar6 = *puVar5;
              local_60 = *(float *)(puVar5 + 1);
              fVar7 = (float)Random.Range(CONCAT44(0x80000000,*(uint32 *)(lVar1 + 32) ^ 0x80000000),
                                           *(uint32 *)(lVar1 + 32),0);
              fVar8 = (float)Random.Range(CONCAT44(0x80000000,*(uint32 *)(lVar1 + 32) ^ 0x80000000),
                                           *(uint32 *)(lVar1 + 32),0);
              fVar8 = local_60 + fVar8;
              local_68 = uVar6;
              lVar2 = GameObject.get_transform(lVar2,0);
              if (lVar2 != null) {
                puVar5 = (uint64 *)Transform.get_position(local_58,lVar2,0);
                local_70 = fVar8 + 0.0;
                local_68 = *puVar5;
                local_60 = *(float *)(puVar5 + 1);
                local_78 = CONCAT44((float)((uint64)local_68 >> 32) +
                                    (float)((uint64)uVar6 >> 32) + 0.0,(float)uVar6 + fVar7 + 0.0);
                if (lVar3 != null) {
                  local_68 = local_78;
                  local_60 = local_70;
                  Transform.set_position(lVar3,&local_68,0);
        LAB_1808cf6a1:
                  uVar9 = Single.Parse(*(uint64 *)(lVar1 + 80),0);
                  uVar6 = new WaitForSeconds(uVar9,0);
                  this.<>2__current = uVar6;
                  this.<>1__state = 1;
                  return true;
                }
              }
            }
          }
          else {
            lVar3 = GameObject.get_transform(lVar2);
            lVar4 = Component.get_transform(lVar1,0);
            if (lVar4 != null) {
              puVar5 = (uint64 *)Transform.get_position(local_58,lVar4,0);
              fVar7 = *(float *)(lVar1 + 36);
              local_78 = *puVar5;
              local_70 = *(float *)(puVar5 + 1);
              lVar2 = GameObject.get_transform(lVar2,0);
              if (lVar2 != null) {
                lVar2 = Transform.get_position(local_58,lVar2,0);
                local_60 = local_70 + 0.0;
                local_68 = CONCAT44(local_78._4_4_ + *(float *)(lVar2 + 4),(float)local_78 + fVar7);
                if (lVar3 != null) {
                  local_78 = local_68;
                  local_70 = local_60;
                  Transform.set_position(lVar3,&local_78,0);
                  fVar7 = *(float *)(lVar1 + 36) - *(float *)(lVar1 + 28);
                  *(float *)(lVar1 + 36) = fVar7;
                  if (fVar7 < -*(float *)(lVar1 + 32)) {
                    *(float *)(lVar1 + 36) = *(float *)(lVar1 + 32);
                  }
                  goto LAB_1808cf6a1;
                }
              }
            }
          }
        }
    }

    // Token : 0x6002353
    // RVA   : 0x20F140   Offset: 0x20D940   Length: 0x5
    private virtual object System.Collections.Generic.IEnumerator<System.object>.get_Current()
    {
        return this.<>2__current;
    }

    // Token : 0x6002354
    // RVA   : 0x8CF730   Offset: 0x8CDF30   Length: 0x3E
    private virtual void System.Collections.IEnumerator.Reset()
    {
        ulong uVar1;
        ulong uVar2;
        uVar1 = il2cpp_runtime_class_init(&DAT_181d682e8);
        uVar1 = il2cpp_internal(uVar1);
        NotSupportedException.ctor(uVar1,0);
        uVar2 = il2cpp_runtime_class_init(&DAT_181d6fd98);
    }

    // Token : 0x6002355
    // RVA   : 0x20F140   Offset: 0x20D940   Length: 0x5
    private virtual object System.Collections.IEnumerator.get_Current()
    {
        return this.<>2__current;
    }

}
