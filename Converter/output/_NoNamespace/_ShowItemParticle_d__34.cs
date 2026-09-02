// ============================================================
// Type  : <ShowItemParticle>d__34
// Token : 0x2000363
// ============================================================

public class <ShowItemParticle>d__34
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001AFA
    private int <>1__state;

    // Token: 0x4001AFB
    private object <>2__current;

    // Token: 0x4001AFC
    public float delayTime;

    // Token: 0x4001AFD
    public SpeShowController <>4__this;

    // Token: 0x4001AFE
    public GameObject targetParticle;

    // Token: 0x4001AFF
    public GameObject targetItemIcon;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x600211C
    // RVA   : 0x219070   Offset: 0x217870   Length: 0x24
    public void /*ctor*/(int <>1__state)
    {
        ZhSegment.Initialize(this,0);
        this.<>1__state = <>1__state;
    }

    // Token : 0x600211D
    // RVA   : 0x245810   Offset: 0x244010   Length: 0x3
    private virtual void System.IDisposable.Dispose()
    {
    }

    // Token : 0x600211E
    // RVA   : 0xB144A0   Offset: 0xB12CA0   Length: 0x2C8
    private virtual bool MoveNext()
    {
        uint uVar1;
        ulong uVar2;
        ulong uVar3;
        ulong uVar4;
        long lVar5;
        long lVar7;
        uint uVar8;
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
        this.<>1__state = 0xffffffff;
        if (this.<>4__this == 0) throw; // [null/range check failed]
        uVar4 = *(uint64 *)(this.<>4__this + 64);
        uVar2 = this.targetParticle;
        if (this.targetItemIcon == null) throw; // [null/range check failed]
        lVar5 = GameObject.get_transform(this.targetItemIcon,0);
        if (lVar5 == null) throw; // [null/range check failed]
        puVar6 = (uint64 *)Transform.get_localPosition(&local_28,lVar5,0);
        local_28 = *puVar6;
        uVar1 = *(uint32 *)(puVar6 + 1);
        uStack_20 = CONCAT44(uStack_20._4_4_,uVar1);
        uVar4 = GlobalData.AddChild(uVar4,uVar2,&local_28,0);
        lVar5 = FUN_18046c100(0);
        if (lVar5 == null) throw; // [null/range check failed]
        lVar5 = *(int64 *)(lVar5 + 56);
        if (this.targetItemIcon == null) throw; // [null/range check failed]
        lVar7 = GameObject.GetComponent(this.targetItemIcon,DAT_181da0070);
        if ((lVar7 == null) || (*(int64 *)(lVar7 + 32) == 0)) throw; // [null/range check failed]
        if (*(int *)(*(int64 *)(lVar7 + 32) + 20) == 4) {
          if (this.targetItemIcon == null) throw; // [null/range check failed]
          lVar7 = GameObject.GetComponent(this.targetItemIcon,DAT_181da0070);
          if (((lVar7 == null) || (*(int64 *)(lVar7 + 32) == 0)) ||
             (lVar7 = *(int64 *)(*(int64 *)(lVar7 + 32) + 120)) == null) throw; // [null/range check failed]
          if (*(char *)(lVar7 + 16) == false)
          {
            uVar8 = 0;
            }
            else {
          }
          if (this.targetItemIcon == null) throw; // [null/range check failed]
          lVar7 = GameObject.GetComponent(this.targetItemIcon,DAT_181da0070);
          if ((lVar7 == null) || (*(int64 *)(lVar7 + 32) == 0)) throw; // [null/range check failed]
          uVar8 = *(uint32 *)(*(int64 *)(lVar7 + 32) + 64);
        }
        if (lVar5 != null) {
          if (*(uint32 *)(lVar5 + 24) <= uVar8) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          lVar5 = lVar5[uVar8];
          if (lVar5 != null) {
            uVar2 = *(uint64 *)(lVar5 + 24);
            uVar3 = *(uint64 *)(lVar5 + 32);
            local_28 = uVar2;
            uStack_20 = uVar3;
            GlobalData.SetParticleColor(uVar4,&local_28,0);
            return false;
          }
        }
    }

    // Token : 0x600211F
    // RVA   : 0x20F140   Offset: 0x20D940   Length: 0x5
    private virtual object System.Collections.Generic.IEnumerator<System.object>.get_Current()
    {
        return this.<>2__current;
    }

    // Token : 0x6002120
    // RVA   : 0xB14770   Offset: 0xB12F70   Length: 0x3E
    private virtual void System.Collections.IEnumerator.Reset()
    {
        ulong uVar1;
        ulong uVar2;
        uVar1 = il2cpp_runtime_class_init(&DAT_181d682e8);
        uVar1 = il2cpp_internal(uVar1);
        NotSupportedException.ctor(uVar1,0);
        uVar2 = il2cpp_runtime_class_init(&DAT_181d8a910);
    }

    // Token : 0x6002121
    // RVA   : 0x20F140   Offset: 0x20D940   Length: 0x5
    private virtual object System.Collections.IEnumerator.get_Current()
    {
        return this.<>2__current;
    }

}
