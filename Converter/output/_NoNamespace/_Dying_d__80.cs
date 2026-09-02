// ============================================================
// Type  : <Dying>d__80
// Token : 0x200017A
// ============================================================

public class <Dying>d__80
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x40009D5
    private int <>1__state;

    // Token: 0x40009D6
    private object <>2__current;

    // Token: 0x40009D7
    public BattleUnit <>4__this;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000C50
    // RVA   : 0x219070   Offset: 0x217870   Length: 0x24
    public void /*ctor*/(int <>1__state)
    {
        ZhSegment.Initialize(this,0);
        this.<>1__state = <>1__state;
    }

    // Token : 0x6000C51
    // RVA   : 0x245810   Offset: 0x244010   Length: 0x3
    private virtual void System.IDisposable.Dispose()
    {
    }

    // Token : 0x6000C52
    // RVA   : 0x8C8D20   Offset: 0x8C7520   Length: 0x2E1
    private virtual bool MoveNext()
    {
        int iVar1;
        ulong uVar2;
        ulong uVar3;
        bool cVar4;
        ulong uVar5;
        long lVar6;
        long lVar8;
        uint uVar9;
        ulong local_48;
        ulong uStack_40;
        byte[] local_38 = new byte[48];
        iVar1 = this.<>1__state;
        lVar8 = this.<>4__this;
        if ((iVar1 == 0) || (iVar1 == 1)) {
          this.<>1__state = 0xffffffff;
          if ((lVar8 == null) || (*(int64 *)(lVar8 + 24) == 0)) goto LAB_1808c8ffc;
          lVar6 = SkeletonExtensions.GetColor
                            (&local_48,*(uint64 *)(*(int64 *)(lVar8 + 24) + 192),0);
          if (*(float *)(lVar6 + 12) <= 0.0) goto LAB_1808c8da4;
          if (*(int64 *)(lVar8 + 24) == 0) goto LAB_1808c8ffc;
          uVar5 = *(uint64 *)(*(int64 *)(lVar8 + 24) + 192);
          puVar7 = (uint64 *)SkeletonExtensions.GetColor(&local_48,uVar5,0);
          uVar2 = *puVar7;
          uVar3 = puVar7[1];
          if (*(int64 *)(lVar8 + 24) == 0) goto LAB_1808c8ffc;
          lVar8 = SkeletonExtensions.GetColor
                            (&local_48,*(uint64 *)(*(int64 *)(lVar8 + 24) + 192),0);
          uVar9 = Mathf.Max(0,*(float *)(lVar8 + 12) - 0.03,0);
          local_48 = uVar2;
          uStack_40 = uVar3;
          puVar7 = (uint64 *)GlobalData.SetColorAlpha(local_38,&local_48,uVar9,0);
          local_48 = *puVar7;
          uStack_40 = puVar7[1];
          SkeletonExtensions.SetColor(uVar5,&local_48,0);
          uVar5 = new WaitForSecondsRealtime(0x3d4ccccd,0);
          this.<>2__current = uVar5;
          this.<>1__state = 1;
        LAB_1808c8e97:
          uVar5 = 1;
        }
        else {
          if (iVar1 == 2) {
            this.<>1__state = 0xffffffff;
        LAB_1808c8da4:
            lVar6 = *(int64 *)(*(int64 *)(DAT_181d8b128 + 184) + 80);
            if (lVar6 == null) {
        LAB_1808c8ffc:
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            uVar5 = *(uint64 *)(lVar6 + 0x110);
            cVar4 = Object.op_Equality(uVar5,lVar8,0);
            if (cVar4) {
              uVar5 = new WaitForSecondsRealtime(0x3dcccccd,0);
              this.<>2__current = uVar5;
              this.<>1__state = 2;
              goto LAB_1808c8e97;
            }
            if (lVar8 == null) goto LAB_1808c8ffc;
            BattleUnit.DisactiveSelf(lVar8,0);
          }
          uVar5 = 0;
        }
        return uVar5;
    }

    // Token : 0x6000C53
    // RVA   : 0x20F140   Offset: 0x20D940   Length: 0x5
    private virtual object System.Collections.Generic.IEnumerator<System.object>.get_Current()
    {
        return this.<>2__current;
    }

    // Token : 0x6000C54
    // RVA   : 0x8C9010   Offset: 0x8C7810   Length: 0x3E
    private virtual void System.Collections.IEnumerator.Reset()
    {
        ulong uVar1;
        ulong uVar2;
        uVar1 = il2cpp_runtime_class_init(&DAT_181d682e8);
        uVar1 = il2cpp_internal(uVar1);
        NotSupportedException.ctor(uVar1,0);
        uVar2 = il2cpp_runtime_class_init(&DAT_181d6ef18);
    }

    // Token : 0x6000C55
    // RVA   : 0x20F140   Offset: 0x20D940   Length: 0x5
    private virtual object System.Collections.IEnumerator.get_Current()
    {
        return this.<>2__current;
    }

}
