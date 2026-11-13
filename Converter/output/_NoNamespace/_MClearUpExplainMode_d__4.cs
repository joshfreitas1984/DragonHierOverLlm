// ============================================================
// Type  : <MClearUpExplainMode>d__4
// Token : 0x20003A8
// ============================================================

public class <MClearUpExplainMode>d__4
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001E01
    private int <>1__state;

    // Token: 0x4001E02
    private object <>2__current;

    // Token: 0x4001E03
    public Text _component;

    // Token: 0x4001E04
    public string _text;

    // Token: 0x4001E05
    public TextFit <>4__this;

    // Token: 0x4001E06
    private StringBuilder <MExplainText>5__2;

    // Token: 0x4001E07
    private int <i>5__3;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6002393
    // RVA   : 0x608BA0   Offset: 0x6079A0   Length: 0x24
    public void /*ctor*/(int <>1__state)
    {
        ZhSegment.Initialize(this,0);
        this.<>1__state = <>1__state;
    }

    // Token : 0x6002394
    // RVA   : 0x51CF50   Offset: 0x51BD50   Length: 0x3
    private virtual void System.IDisposable.Dispose()
    {
    }

    // Token : 0x6002395
    // RVA   : 0x610420   Offset: 0x60F220   Length: 0x529
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
            iVar5 = FUN_180002280(0,DAT_181e6bc38);
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
                if (*(int64 *)(*(int64 *)(lVar6 + 176) + (uint64)uVar12 * 16) == DAT_181e6ed38
                   ) {
                  puVar8 = (uint64 *)
                           ((int64)*(int *)(*(int64 *)(lVar6 + 176) + 8 + (uint64)uVar12 * 16)
                            * 16 + 0x138 + lVar6);
                  goto LAB_180610649;
                }
                uVar12 = uVar12 + 1;
              } while (uVar12 < *(uint16 *)(lVar6 + 0x12a));
            }
            puVar8 = (uint64 *)FUN_18019b1f0(plVar2,DAT_181e6ed38,0);
        LAB_180610649:
            piVar9 = (int *)(*(code *)*puVar8)(local_38,plVar2,uVar4,puVar8[1]);
            iVar13 = *piVar9;
            if (this.<MExplainText>5__2 == 0) break;
            iVar5 = FUN_181032940(this.<MExplainText>5__2,0);
            if (iVar13 < iVar5) {
              lVar6 = this.<MExplainText>5__2;
              if ((*plVar14 == 0) ||
                 (puVar10 = (uint32 *)
                            FUN_18005ff70(local_28,0,DAT_181e6ed38,*plVar14,
                                          this.<i>5__3), lVar6 == null)) break;
              local_res8[0] = StringBuilder.get_Chars(lVar6,*puVar10,0);
              uVar11 = Char.ToString(local_res8,0);
              uVar7 = *(uint64 *)(lVar1 + 0x108);
              cVar3 = Regex.IsMatch(uVar11,uVar7,0);
              if (cVar3) {
                if (*plVar14 != 0) {
                  piVar9 = (int *)FUN_18005ff70(local_28,0,DAT_181e6ed38,*plVar14,
                                                this.<i>5__3);
                  iVar13 = *piVar9 + -1;
                  iVar5 = iVar13;
                  goto joined_r0x000180610763;
                }
                break;
              }
            }
            this.<i>5__3 = this.<i>5__3 + 1;
            iVar13 = this.<i>5__3;
          }
        }
        throw; // [null/range check failed]
        joined_r0x000180610763:
        if (iVar5 < 1) goto LAB_1806107e0;
        if (this.<MExplainText>5__2 == 0) throw; // [null/range check failed]
        local_res8[0] = StringBuilder.get_Chars(this.<MExplainText>5__2,iVar5,0);
        uVar11 = Char.ToString(local_res8,0);
        uVar7 = *(uint64 *)(lVar1 + 0x108);
        cVar3 = Regex.IsMatch(uVar11,uVar7);
        if (!cVar3) goto LAB_1806107e0;
        iVar13 = iVar13 + -1;
        iVar5 = iVar5 + -1;
        goto joined_r0x000180610763;
        LAB_1806107e0:
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

    // Token : 0x6002396
    // RVA   : 0x608B50   Offset: 0x607950   Length: 0x5
    private virtual object System.Collections.Generic.IEnumerator<System.object>.get_Current()
    {
        return this.<>2__current;
    }

    // Token : 0x6002397
    // RVA   : 0x610950   Offset: 0x60F750   Length: 0x3E
    private virtual void System.Collections.IEnumerator.Reset()
    {
        ulong uVar1;
        ulong uVar2;
        uVar1 = il2cpp_runtime_class_init(&DAT_181e6d8e8);
        uVar1 = il2cpp_internal(uVar1);
        NotSupportedException.ctor(uVar1,0);
        uVar2 = il2cpp_runtime_class_init(&DAT_181e9a130);
    }

    // Token : 0x6002398
    // RVA   : 0x608B50   Offset: 0x607950   Length: 0x5
    private virtual object System.Collections.IEnumerator.get_Current()
    {
        return this.<>2__current;
    }

}
