// ============================================================
// Type  : <TweenLine>d__39
// Token : 0x200037E
// ============================================================

public class <TweenLine>d__39
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001BD2
    private int <>1__state;

    // Token: 0x4001BD3
    private object <>2__current;

    // Token: 0x4001BD4
    public LineRenderer targetRenderer;

    // Token: 0x4001BD5
    public StudyInternalPointController <>4__this;

    // Token: 0x4001BD6
    public GameObject targetPoint;

    // Token: 0x4001BD7
    private int <i>5__2;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60021F7
    // RVA   : 0x219070   Offset: 0x217870   Length: 0x24
    public void /*ctor*/(int <>1__state)
    {
        ZhSegment.Initialize(this,0);
        this.<>1__state = <>1__state;
    }

    // Token : 0x60021F8
    // RVA   : 0x245810   Offset: 0x244010   Length: 0x3
    private virtual void System.IDisposable.Dispose()
    {
    }

    // Token : 0x60021F9
    // RVA   : 0xB14DA0   Offset: 0xB135A0   Length: 0x3F0
    private virtual bool MoveNext()
    {
        ulong uVar1;
        float fVar2;
        float fVar3;
        long lVar4;
        long lVar6;
        ulong uVar7;
        long lVar8;
        float fVar9;
        float local_78;
        float fStack_74;
        float local_68;
        float fStack_64;
        ulong local_58;
        float local_50;
        ulong local_48;
        float local_40;
        byte[] local_38 = new byte[16];
        byte[] local_28 = new byte[32];
        lVar6 = this.<>4__this;
        if (this.<>1__state == 0) {
          this.<>1__state = 0xffffffff;
          if (this.targetRenderer == null) throw; // [null/range check failed]
          LineRenderer.set_positionCount(this.targetRenderer,2,0);
          lVar8 = this.targetRenderer;
          if ((lVar6 == null) || (lVar4 = Component.get_transform(lVar6,0)) == null) throw; // [null/range check failed]
          puVar5 = (uint64 *)Transform.get_position(local_38,lVar4,0);
          local_58 = *puVar5;
          local_50 = *(float *)(puVar5 + 1);
          puVar5 = (uint64 *)GlobalData.SetZToZero(local_38,&local_58,0);
          if (lVar8 == null) throw; // [null/range check failed]
          local_58 = *puVar5;
          local_50 = *(float *)(puVar5 + 1);
          LineRenderer.SetPosition(lVar8,0,&local_58,0);
          lVar8 = this.targetRenderer;
          lVar4 = Component.get_transform(lVar6,0);
          if (lVar4 == null) throw; // [null/range check failed]
          puVar5 = (uint64 *)Transform.get_position(local_38,lVar4,0);
          local_58 = *puVar5;
          local_50 = *(float *)(puVar5 + 1);
          puVar5 = (uint64 *)GlobalData.SetZToZero(local_38,&local_58,0);
          if (lVar8 == null) throw; // [null/range check failed]
          local_58 = *puVar5;
          local_50 = *(float *)(puVar5 + 1);
          LineRenderer.SetPosition(lVar8,1,&local_58);
          lVar8 = this.targetRenderer;
          this.<i>5__2 = 0;
        }
        else {
          if (this.<>1__state != 1) {
            return false;
          }
          this.<i>5__2 = this.<i>5__2 + 1;
          this.<>1__state = 0xffffffff;
          if (100 < this.<i>5__2) {
            return false;
          }
          lVar8 = this.targetRenderer;
          if (lVar6 == null) throw; // [null/range check failed]
        }
        lVar4 = Component.get_transform(lVar6,0);
        if (lVar4 != null) {
          puVar5 = (uint64 *)Transform.get_position(local_38,lVar4,0);
          uVar7 = *puVar5;
          fVar2 = *(float *)(puVar5 + 1);
          local_58 = uVar7;
          local_50 = fVar2;
          puVar5 = (uint64 *)GlobalData.SetZToZero(local_38,&local_58,0);
          uVar7 = *puVar5;
          fVar2 = *(float *)(puVar5 + 1);
          if ((this.targetPoint != null) &&
             (lVar4 = GameObject.get_transform(this.targetPoint,0)) != null) {
            puVar5 = (uint64 *)Transform.get_position(local_38,lVar4,0);
            local_58 = *puVar5;
            local_50 = *(float *)(puVar5 + 1);
            puVar5 = (uint64 *)GlobalData.SetZToZero(local_38,&local_58,0);
            uVar1 = *puVar5;
            fVar3 = *(float *)(puVar5 + 1);
            lVar6 = Component.get_transform(lVar6,0);
            if (lVar6 != null) {
              puVar5 = (uint64 *)Transform.get_position(local_38,lVar6,0);
              local_58 = *puVar5;
              local_50 = *(float *)(puVar5 + 1);
              puVar5 = (uint64 *)GlobalData.SetZToZero(local_28,&local_58,0);
              local_40 = *(float *)(puVar5 + 1);
              local_48 = *puVar5;
              fVar9 = (float)this.<i>5__2;
              local_78 = (float)uVar1;
              fStack_74 = (float)((uint64)uVar1 >> 32);
              local_68 = (float)uVar7;
              fStack_64 = (float)((uint64)uVar7 >> 32);
              local_50 = ((fVar3 - local_40) * fVar9) / 100.0 + fVar2;
              local_58 = CONCAT44(((fStack_74 - (float)((uint64)local_48 >> 32)) * fVar9) / 100.0 +
                                  fStack_64,((local_78 - (float)local_48) * fVar9) / 100.0 + local_68);
              if (lVar8 != null) {
                local_48 = local_58;
                local_40 = local_50;
                LineRenderer.SetPosition(lVar8,1,&local_48);
                uVar7 = new WaitForSecondsRealtime(0x3c23d70a,0);
                this.<>2__current = uVar7;
                this.<>1__state = 1;
                return true;
              }
            }
          }
        }
    }

    // Token : 0x60021FA
    // RVA   : 0x20F140   Offset: 0x20D940   Length: 0x5
    private virtual object System.Collections.Generic.IEnumerator<System.object>.get_Current()
    {
        return this.<>2__current;
    }

    // Token : 0x60021FB
    // RVA   : 0xB151A0   Offset: 0xB139A0   Length: 0x3E
    private virtual void System.Collections.IEnumerator.Reset()
    {
        ulong uVar1;
        ulong uVar2;
        uVar1 = il2cpp_runtime_class_init(&DAT_181d682e8);
        uVar1 = il2cpp_internal(uVar1);
        NotSupportedException.ctor(uVar1,0);
        uVar2 = il2cpp_runtime_class_init(&DAT_181d8b910);
    }

    // Token : 0x60021FC
    // RVA   : 0x20F140   Offset: 0x20D940   Length: 0x5
    private virtual object System.Collections.IEnumerator.get_Current()
    {
        return this.<>2__current;
    }

}
