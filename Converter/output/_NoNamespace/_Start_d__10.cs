// ============================================================
// Type  : <Start>d__10
// Token : 0x20003E6
// ============================================================

public class <Start>d__10
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001E22
    private int <>1__state;

    // Token: 0x4001E23
    private object <>2__current;

    // Token: 0x4001E24
    public Benchmark01_UGUI <>4__this;

    // Token: 0x4001E25
    private int <i>5__2;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6002416
    // RVA   : 0x219070   Offset: 0x217870   Length: 0x24
    public void /*ctor*/(int <>1__state)
    {
        ZhSegment.Initialize(this,0);
        this.<>1__state = <>1__state;
    }

    // Token : 0x6002417
    // RVA   : 0x245810   Offset: 0x244010   Length: 0x3
    private virtual void System.IDisposable.Dispose()
    {
    }

    // Token : 0x6002418
    // RVA   : 0x8D2BC0   Offset: 0x8D13C0   Length: 0x4A8
    private virtual bool MoveNext()
    {
        int iVar1;
        long lVar2;
        bool cVar5;
        long lVar6;
        ulong uVar7;
        ulong uVar8;
        int iVar9;
        int[] local_res8 = new int[2];
        iVar1 = this.<>1__state;
        lVar2 = this.<>4__this;
        iVar9 = 0;
        local_res8[0] = 0;
        if (iVar1 == 0) {
          this.<>1__state = 0xffffffff;
          if (lVar2 == null) throw; // [null/range check failed]
          if (*(int *)(lVar2 + 24) == 0) {
            lVar6 = Component.get_gameObject(lVar2,0);
            if (lVar6 == null) throw; // [null/range check failed]
            uVar7 = GameObject.AddComponent(lVar6,DAT_181d9dab8);
            *(uint64 *)(lVar2 + 56) = uVar7;
            uVar7 = *(uint64 *)(lVar2 + 40);
            cVar5 = Object.op_Inequality(uVar7,0,0);
            if (cVar5) {
              if (*(int64 *)(lVar2 + 56) == 0) throw; // [null/range check failed]
              TMP_Text.set_font(*(int64 *)(lVar2 + 56),*(uint64 *)(lVar2 + 40),0);
            }
            if (*(int64 *)(lVar2 + 56) == 0) throw; // [null/range check failed]
            TMP_Text.set_fontSize(*(int64 *)(lVar2 + 56),0x42400000,0);
            if (*(int64 *)(lVar2 + 56) == 0) throw; // [null/range check failed]
            TMP_Text.set_alignment(*(int64 *)(lVar2 + 56),0x202,0);
            if (*(int64 *)(lVar2 + 56) == 0) throw; // [null/range check failed]
            TMP_Text.set_extraPadding(*(int64 *)(lVar2 + 56),1,0);
            if ((*(int64 *)(lVar2 + 56) == 0) ||
               (lVar6 = *(int64 *)(*(int64 *)(lVar2 + 56) + 248)) == null)
            throw; // [null/range check failed]
            *(uint64 *)(lVar2 + 72) = *(uint64 *)(lVar6 + 32);
            uVar7 = Resources.Load("Fonts & Materials/LiberationSans SDF - BEVEL",DAT_181d771e0);
            *(uint64 *)(lVar2 + 80) = uVar7;
          }
          else if (*(int *)(lVar2 + 24) == 1) {
            lVar6 = Component.get_gameObject(lVar2,0);
            if (lVar6 == null) throw; // [null/range check failed]
            uVar7 = GameObject.AddComponent(lVar6,DAT_181d9d898);
            *(uint64 *)(lVar2 + 64) = uVar7;
            uVar7 = *(uint64 *)(lVar2 + 48);
            cVar5 = Object.op_Inequality(uVar7,0,0);
            if (cVar5) {
              if (*(int64 *)(lVar2 + 64) == 0) throw; // [null/range check failed]
              Text.set_font(*(int64 *)(lVar2 + 64),*(uint64 *)(lVar2 + 48),0);
            }
            if (*(int64 *)(lVar2 + 64) == 0) throw; // [null/range check failed]
            Text.set_fontSize(*(int64 *)(lVar2 + 64),48);
            if (*(int64 *)(lVar2 + 64) == 0) throw; // [null/range check failed]
            Text.set_alignment(*(int64 *)(lVar2 + 64),4);
          }
          this.<i>5__2 = 0;
        }
        else {
          if (iVar1 != 1) {
            if (iVar1 == 2) {
              this.<>1__state = 0xffffffff;
              return false;
            }
            return false;
          }
          local_res8[0] = this.<i>5__2;
          this.<>1__state = 0xffffffff;
          iVar9 = local_res8[0] + 1;
          this.<i>5__2 = iVar9;
          if (1000000 < iVar9) {
            this.<>2__current = 0;
            this.<>1__state = 2;
            return true;
          }
          if (lVar2 == null) throw; // [null/range check failed]
        }
        if (*(int *)(lVar2 + 24) != 0) {
          if (*(int *)(lVar2 + 24) == 1) {
            plVar3 = *(int64 **)(lVar2 + 64);
            local_res8[0] = iVar9 % 1000;
            uVar7 = Int32.ToString(local_res8,0);
            uVar7 = String.Concat("The <color=#0050FF>count is: </color>",uVar7,0);
            if (plVar3 == (int64 *)0) throw; // [null/range check failed]
            (**(code **)(*plVar3 + 0x5e8))(plVar3,uVar7,*(uint64 *)(*plVar3 + 0x5f0));
          }
        LAB_1808d3049:
          this.<>2__current = 0;
          this.<>1__state = 1;
          return true;
        }
        plVar3 = *(int64 **)(lVar2 + 56);
        local_res8[0] = iVar9 % 1000;
        uVar7 = Int32.ToString(local_res8,0);
        uVar7 = String.Concat("The <#0050FF>count is: </color>",uVar7,0);
        if (plVar3 != (int64 *)0) {
          (**(code **)(*plVar3 + 0x558))(plVar3,uVar7,*(uint64 *)(*plVar3 + 0x560));
          if (this.<i>5__2 % 1000 != 999) goto LAB_1808d3049;
          plVar3 = *(int64 **)(lVar2 + 56);
          if (plVar3 != (int64 *)0) {
            uVar8 = (**(code **)(*plVar3 + 0x568))(plVar3,*(uint64 *)(*plVar3 + 0x570));
            uVar7 = *(uint64 *)(lVar2 + 72);
            cVar5 = Object.op_Equality(uVar8,uVar7,0);
            plVar4 = *(int64 **)(lVar2 + 56);
            if (!cVar5) {
              uVar7 = *(uint64 *)(lVar2 + 72);
            }
            else {
              uVar7 = *(uint64 *)(lVar2 + 80);
            }
            if (plVar4 != (int64 *)0) {
              (**(code **)(*plVar4 + 0x578))(plVar4,uVar7,*(uint64 *)(*plVar4 + 0x580));
              (**(code **)(*plVar3 + 0x578))(plVar3,uVar7,*(uint64 *)(*plVar3 + 0x580));
              goto LAB_1808d3049;
            }
          }
        }
    }

    // Token : 0x6002419
    // RVA   : 0x20F140   Offset: 0x20D940   Length: 0x5
    private virtual object System.Collections.Generic.IEnumerator<System.object>.get_Current()
    {
        return this.<>2__current;
    }

    // Token : 0x600241A
    // RVA   : 0x8D30B0   Offset: 0x8D18B0   Length: 0x3E
    private virtual void System.Collections.IEnumerator.Reset()
    {
        ulong uVar1;
        ulong uVar2;
        uVar1 = il2cpp_runtime_class_init(&DAT_181d682e8);
        uVar1 = il2cpp_internal(uVar1);
        NotSupportedException.ctor(uVar1,0);
        uVar2 = il2cpp_runtime_class_init(&DAT_181d6f098);
    }

    // Token : 0x600241B
    // RVA   : 0x20F140   Offset: 0x20D940   Length: 0x5
    private virtual object System.Collections.IEnumerator.get_Current()
    {
        return this.<>2__current;
    }

}
