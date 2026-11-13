// ============================================================
// Type  : <Dying>d__85
// Token : 0x2000181
// ============================================================

public class <Dying>d__85
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4000A62
    private int <>1__state;

    // Token: 0x4000A63
    private object <>2__current;

    // Token: 0x4000A64
    public BattleUnit <>4__this;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000C79
    // RVA   : 0x608BA0   Offset: 0x6079A0   Length: 0x24
    public void /*ctor*/(int <>1__state)
    {
        ZhSegment.Initialize(this,0);
        this.<>1__state = <>1__state;
    }

    // Token : 0x6000C7A
    // RVA   : 0x51CF50   Offset: 0x51BD50   Length: 0x3
    private virtual void System.IDisposable.Dispose()
    {
    }

    // Token : 0x6000C7B
    // RVA   : 0x674470   Offset: 0x673270   Length: 0x2E1
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
          if ((lVar8 == null) || (*(int64 *)(lVar8 + 24) == 0)) goto LAB_18067474c;
          lVar6 = SkeletonExtensions.GetColor
                            (&local_48,*(uint64 *)(*(int64 *)(lVar8 + 24) + 192),0);
          if (*(float *)(lVar6 + 12) <= 0.0) goto LAB_1806744f4;
          if (*(int64 *)(lVar8 + 24) == 0) goto LAB_18067474c;
          uVar5 = *(uint64 *)(*(int64 *)(lVar8 + 24) + 192);
          puVar7 = (uint64 *)SkeletonExtensions.GetColor(&local_48,uVar5,0);
          uVar2 = *puVar7;
          uVar3 = puVar7[1];
          if (*(int64 *)(lVar8 + 24) == 0) goto LAB_18067474c;
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
        LAB_1806745e7:
          uVar5 = 1;
        }
        else {
          if (iVar1 == 2) {
            this.<>1__state = 0xffffffff;
        LAB_1806744f4:
            lVar6 = *(int64 *)(*(int64 *)(DAT_181e90420 + 184) + 80);
            if (lVar6 == null) {
        LAB_18067474c:
                          // WARNING: Subroutine does not return
              FUN_1801e0300();
            }
            uVar5 = *(uint64 *)(lVar6 + 0x110);
            cVar4 = Object.op_Equality(uVar5,lVar8,0);
            if (cVar4) {
              uVar5 = new WaitForSecondsRealtime(0x3dcccccd,0);
              this.<>2__current = uVar5;
              this.<>1__state = 2;
              goto LAB_1806745e7;
            }
            if (lVar8 == null) goto LAB_18067474c;
            BattleUnit.DisactiveSelf(lVar8,0);
          }
          uVar5 = 0;
        }
        return uVar5;
    }

    // Token : 0x6000C7C
    // RVA   : 0x608B50   Offset: 0x607950   Length: 0x5
    private virtual object System.Collections.Generic.IEnumerator<System.object>.get_Current()
    {
        return this.<>2__current;
    }

    // Token : 0x6000C7D
    // RVA   : 0x674760   Offset: 0x673560   Length: 0x3E
    private virtual void System.Collections.IEnumerator.Reset()
    {
        ulong uVar1;
        ulong uVar2;
        uVar1 = il2cpp_runtime_class_init(&DAT_181e6d8e8);
        uVar1 = il2cpp_internal(uVar1);
        NotSupportedException.ctor(uVar1,0);
        uVar2 = il2cpp_runtime_class_init(&DAT_181e7b690);
    }

    // Token : 0x6000C7E
    // RVA   : 0x608B50   Offset: 0x607950   Length: 0x5
    private virtual object System.Collections.IEnumerator.get_Current()
    {
        return this.<>2__current;
    }

}
