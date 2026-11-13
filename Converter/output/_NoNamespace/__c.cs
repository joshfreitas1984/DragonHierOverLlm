// ============================================================
// Type  : <>c
// Token : 0x200043E
// ============================================================

public class <>c
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4002151
    public static readonly <>c <>9;

    // Token: 0x4002152
    public static Action<IList<string>, Dictionary<string, string>> <>9__66_0;

    // Token: 0x4002153
    public static Action<IList<string>, Dictionary<string, string>> <>9__67_0;

    // Token: 0x4002154
    public static Func<string, string> <>9__68_0;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60026CC
    // RVA   : 0x1784F20   Offset: 0x1783D20   Length: 0x59
    private static void /*cctor*/()
    {
        ulong uVar2;
        uVar2 = new ZhSegment(0);
        puVar1 = *(uint64 **)(DAT_181e73e10 + 184);
        *puVar1 = uVar2;
        il2cpp_internal(puVar1,uVar2);
    }

    // Token : 0x60026CD
    // RVA   : 0x42F150   Offset: 0x42DF50   Length: 0x7
    public void /*ctor*/()
    {
        ZhSegment.Initialize(this,0);
    }

    // Token : 0x60026CE
    // RVA   : 0x1784CF0   Offset: 0x1783AF0   Length: 0x9C
    internal void <LoadDictionary>b__66_0(IList<string> items, Dictionary<string, string> dictionary)
    {
        ulong uVar1;
        ulong uVar2;
        if (items != null) {
          uVar1 = FUN_180060020(0,DAT_181e6eb38,items,0);
          uVar2 = FUN_180060020(0,DAT_181e6eb38,items,1);
          if (dictionary != null) {
            FUN_1806e7630(dictionary,uVar1,uVar2,DAT_181e57110);
            return;
          }
        }
    }

    // Token : 0x60026CF
    // RVA   : 0x1784AD0   Offset: 0x17838D0   Length: 0x215
    internal void <LoadDictionaryReversed>b__67_0(IList<string> items, Dictionary<string, string> dictionary)
    {
        long lVar1;
        int iVar2;
        ulong uVar4;
        ulong uVar5;
        ulong uVar6;
        ushort uVar7;
        int iVar8;
        iVar8 = 1;
        if (items != (int64 *)0) {
          do {
            lVar1 = *items;
            if (*(uint16 *)(lVar1 + 0x12a) != 0) {
              uVar7 = 0;
              do {
                if (*(int64 *)(*(int64 *)(lVar1 + 176) + (uint64)uVar7 * 16) == DAT_181e6ba38)
                {
                  puVar3 = (uint64 *)
                           ((int64)*(int *)(*(int64 *)(lVar1 + 176) + 8 + (uint64)uVar7 * 16)
                            * 16 + 0x138 + lVar1);
                  goto LAB_181784b8c;
                }
                uVar7 = uVar7 + 1;
              } while (uVar7 < *(uint16 *)(lVar1 + 0x12a));
            }
            puVar3 = (uint64 *)FUN_18019b1f0(items,DAT_181e6ba38,0);
        LAB_181784b8c:
            iVar2 = (*(code *)*puVar3)(items,puVar3[1]);
            if (iVar2 <= iVar8) {
              return;
            }
            lVar1 = *items;
            uVar4 = 0;
            if (*(uint16 *)(lVar1 + 0x12a) != 0) {
              do {
                if (*(int64 *)(*(int64 *)(lVar1 + 176) + uVar4 * 16) == DAT_181e6eb38) {
                  puVar3 = (uint64 *)
                           ((int64)*(int *)(*(int64 *)(lVar1 + 176) + 8 + uVar4 * 16) * 16 +
                            0x138 + lVar1);
                  goto LAB_181784be9;
                }
                uVar7 = (short)uVar4 + 1;
                uVar4 = (uint64)uVar7;
              } while (uVar7 < *(uint16 *)(lVar1 + 0x12a));
            }
            puVar3 = (uint64 *)FUN_18019b1f0(items,DAT_181e6eb38,0);
        LAB_181784be9:
            uVar5 = (*(code *)*puVar3)(items,iVar8,puVar3[1]);
            lVar1 = *items;
            uVar4 = 0;
            if (*(uint16 *)(lVar1 + 0x12a) != 0) {
              do {
                if (*(int64 *)(*(int64 *)(lVar1 + 176) + uVar4 * 16) == DAT_181e6eb38) {
                  puVar3 = (uint64 *)
                           ((int64)*(int *)(*(int64 *)(lVar1 + 176) + 8 + uVar4 * 16) * 16 +
                            0x138 + lVar1);
                  goto LAB_181784c49;
                }
                uVar7 = (short)uVar4 + 1;
                uVar4 = (uint64)uVar7;
              } while (uVar7 < *(uint16 *)(lVar1 + 0x12a));
            }
            puVar3 = (uint64 *)FUN_18019b1f0(items,DAT_181e6eb38,0);
        LAB_181784c49:
            uVar6 = (*(code *)*puVar3)(items,0,puVar3[1]);
            if (dictionary == null) break;
            FUN_1806e7630(dictionary,uVar5,uVar6,DAT_181e57110);
            iVar8 = iVar8 + 1;
          } while( true );
        }
    }

    // Token : 0x60026D0
    // RVA   : 0x1784A10   Offset: 0x1783810   Length: 0xB4
    internal string <LoadDictionaryInternal>b__68_0(string name)
    {
        ulong uVar1;
        ulong uVar2;
        ulong uVar3;
        uVar2 = Application.get_streamingAssetsPath(0);
        uVar1 = **(uint64 **)(DAT_181e72090 + 184);
        uVar3 = String.Concat(name,".txt",0);
        Path.Combine(uVar2,uVar1,uVar3,0);
    }

}
