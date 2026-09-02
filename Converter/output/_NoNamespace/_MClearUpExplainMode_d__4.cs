// ============================================================
// Type  : <MClearUpExplainMode>d__4
// Token : 0x2000394
// ============================================================

public class <MClearUpExplainMode>d__4
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001C69
    private int <>1__state;

    // Token: 0x4001C6A
    private object <>2__current;

    // Token: 0x4001C6B
    public Text _component;

    // Token: 0x4001C6C
    public string _text;

    // Token: 0x4001C6D
    public TextFit <>4__this;

    // Token: 0x4001C6E
    private StringBuilder <MExplainText>5__2;

    // Token: 0x4001C6F
    private int <i>5__3;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6002267
    // RVA   : 0x219070   Offset: 0x217870   Length: 0x24
    public void /*ctor*/(int <>1__state)
    {
        ZhSegment.Initialize(this,0);
        this.<>1__state = <>1__state;
    }

    // Token : 0x6002268
    // RVA   : 0x245810   Offset: 0x244010   Length: 0x3
    private virtual void System.IDisposable.Dispose()
    {
    }

    // Token : 0x6002269
    // RVA   : 0xB128F0   Offset: 0xB110F0   Length: 0x529
    private virtual bool MoveNext()
    {
        long lVar1;
        bool cVar3;
        uint uVar4;
        int iVar5;
        long lVar6;
        ulong uVar7;
        ulong uVar11;
        ushort uVar12;
        int iVar13;
        ushort[] local_res8 = new ushort[4];
        byte[] local_38 = new byte[16];
        byte[] local_28 = new byte[16];
        iVar13 = this.<>1__state;
        lVar1 = this.<>4__this;
        local_res8[0] = 0;
        if (iVar13 == 0) {
          plVar14 = this._component;
          this.<>1__state = 0xffffffff;
          if (plVar14 != (int64 *)0) {
            (**(code **)(*plVar14 + 0x5e8))
                      (plVar14,this._text,*(uint64 *)(*plVar14 + 0x5f0));
            uVar7 = new WaitForSeconds(0x3a83126f,0);
            this.<>2__current = uVar7;
            this.<>1__state = 1;
            return true;
          }
        }
        else {
          if (iVar13 == 1) {
            this.<>1__state = 0xffffffff;
            if (((this._component == null) ||
                (lVar6 = Text.get_cachedTextGenerator(this._component,0)) == null) ||
               (uVar7 = TextGenerator.get_lines(lVar6,0), lVar1 == null)) throw; // [null/range check failed]
            *(uint64 *)(lVar1 + 0x118) = uVar7;
            plVar14 = this._component;
            if (plVar14 == (int64 *)0) throw; // [null/range check failed]
            uVar7 = (**(code **)(*plVar14 + 0x5d8))(plVar14,*(uint64 *)(*plVar14 + 0x5e0));
            uVar11 = new StringBuilder(uVar7,0);
            this.<MExplainText>5__2 = uVar11;
            iVar13 = 1;
            this.<i>5__3 = 1;
          }
          else {
            if (iVar13 != 2) {
              return false;
            }
            this.<>1__state = 0xffffffff;
            if (((this._component == null) ||
                (lVar6 = Text.get_cachedTextGenerator(this._component,0)) == null) ||
               (uVar7 = TextGenerator.get_lines(lVar6,0), lVar1 == null)) throw; // [null/range check failed]
            *(uint64 *)(lVar1 + 0x118) = uVar7;
            uVar4 = Mathf.Max(this.<i>5__3 + -1,1,0);
            this.<i>5__3 = uVar4;
            this.<i>5__3 = this.<i>5__3 + 1;
            iVar13 = this.<i>5__3;
          }
          while (plVar14 = (int64 *)(lVar1 + 0x118), *plVar14 != 0) {
            iVar5 = FUN_180002970(0,DAT_181d67240);
            if (iVar5 <= iVar13) {
              plVar14 = this.<MExplainText>5__2;
              plVar2 = this._component;
              if ((plVar14 != (int64 *)0) &&
                 (uVar7 = (**(code **)(*plVar14 + 0x168))(plVar14,*(uint64 *)(*plVar14 + 0x170)),
                 plVar2 != (int64 *)0)) {
                (**(code **)(*plVar2 + 0x5e8))(plVar2,uVar7,*(uint64 *)(*plVar2 + 0x5f0));
                return false;
              }
              break;
            }
            plVar2 = (int64 *)*plVar14;
            uVar4 = this.<i>5__3;
            if (plVar2 == (int64 *)0) break;
            lVar6 = *plVar2;
            uVar12 = 0;
            if (*(uint16 *)(lVar6 + 0x12a) != 0) {
              do {
                if (*(int64 *)(*(int64 *)(lVar6 + 176) + (uint64)uVar12 * 16) == DAT_181d6a338
                   ) {
                  puVar8 = (uint64 *)
                           ((int64)*(int *)(*(int64 *)(lVar6 + 176) + 8 + (uint64)uVar12 * 16)
                            * 16 + 0x138 + lVar6);
                  goto LAB_180b12b19;
                }
                uVar12 = uVar12 + 1;
              } while (uVar12 < *(uint16 *)(lVar6 + 0x12a));
            }
            puVar8 = (uint64 *)FUN_1800914f0(plVar2,DAT_181d6a338,0);
        LAB_180b12b19:
            piVar9 = (int *)(*(code *)*puVar8)(local_38,plVar2,uVar4,puVar8[1]);
            iVar13 = *piVar9;
            if (this.<MExplainText>5__2 == 0) break;
            iVar5 = FUN_18123bdd0(this.<MExplainText>5__2,0);
            if (iVar13 < iVar5) {
              lVar6 = this.<MExplainText>5__2;
              if ((*plVar14 == 0) ||
                 (puVar10 = (uint32 *)
                            FUN_18014aa70(local_28,0,DAT_181d6a338,*plVar14,
                                          this.<i>5__3), lVar6 == null)) break;
              local_res8[0] = StringBuilder.get_Chars(lVar6,*puVar10,0);
              uVar11 = Char.ToString(local_res8,0);
              uVar7 = *(uint64 *)(lVar1 + 0x108);
              cVar3 = Regex.IsMatch(uVar11,uVar7,0);
              if (cVar3) {
                if (*plVar14 != 0) {
                  piVar9 = (int *)FUN_18014aa70(local_28,0,DAT_181d6a338,*plVar14,
                                                this.<i>5__3);
                  iVar13 = *piVar9 + -1;
                  iVar5 = iVar13;
                  goto joined_r0x000180b12c33;
                }
                break;
              }
            }
            this.<i>5__3 = this.<i>5__3 + 1;
            iVar13 = this.<i>5__3;
          }
        }
        throw; // [null/range check failed]
        joined_r0x000180b12c33:
        if (iVar5 < 1) goto LAB_180b12cb0;
        if (this.<MExplainText>5__2 == 0) throw; // [null/range check failed]
        local_res8[0] = StringBuilder.get_Chars(this.<MExplainText>5__2,iVar5,0);
        uVar11 = Char.ToString(local_res8,0);
        uVar7 = *(uint64 *)(lVar1 + 0x108);
        cVar3 = Regex.IsMatch(uVar11,uVar7);
        if (!cVar3) goto LAB_180b12cb0;
        iVar13 = iVar13 + -1;
        iVar5 = iVar5 + -1;
        goto joined_r0x000180b12c33;
        LAB_180b12cb0:
        if (this.<MExplainText>5__2 != 0) {
          StringBuilder.Insert(this.<MExplainText>5__2,iVar13,"\n",0);
          plVar14 = this.<MExplainText>5__2;
          plVar2 = this._component;
          if ((plVar14 != (int64 *)0) &&
             (uVar7 = (**(code **)(*plVar14 + 0x168))(plVar14,*(uint64 *)(*plVar14 + 0x170)),
             plVar2 != (int64 *)0)) {
            (**(code **)(*plVar2 + 0x5e8))(plVar2,uVar7,*(uint64 *)(*plVar2 + 0x5f0));
            uVar7 = new WaitForSeconds(0x3a83126f,0);
            this.<>2__current = uVar7;
            this.<>1__state = 2;
            return true;
          }
        }
    }

    // Token : 0x600226A
    // RVA   : 0x20F140   Offset: 0x20D940   Length: 0x5
    private virtual object System.Collections.Generic.IEnumerator<System.object>.get_Current()
    {
        return this.<>2__current;
    }

    // Token : 0x600226B
    // RVA   : 0xB12E20   Offset: 0xB11620   Length: 0x3E
    private virtual void System.Collections.IEnumerator.Reset()
    {
        ulong uVar1;
        ulong uVar2;
        uVar1 = il2cpp_runtime_class_init(&DAT_181d682e8);
        uVar1 = il2cpp_internal(uVar1);
        NotSupportedException.ctor(uVar1,0);
        uVar2 = il2cpp_runtime_class_init(&DAT_181d8ce68);
    }

    // Token : 0x600226C
    // RVA   : 0x20F140   Offset: 0x20D940   Length: 0x5
    private virtual object System.Collections.IEnumerator.get_Current()
    {
        return this.<>2__current;
    }

}
