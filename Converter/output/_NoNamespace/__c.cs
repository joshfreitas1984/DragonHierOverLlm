// ============================================================
// Type  : <>c
// Token : 0x2000431
// ============================================================

public class <>c
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x40020BE
    public static readonly <>c <>9;

    // Token: 0x40020BF
    public static Action<IList<string>, Dictionary<string, string>> <>9__66_0;

    // Token: 0x40020C0
    public static Action<IList<string>, Dictionary<string, string>> <>9__67_0;

    // Token: 0x40020C1
    public static Func<string, string> <>9__68_0;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6002622
    // RVA   : 0x1843AC0   Offset: 0x1842EC0   Length: 0x59
    private static void /*cctor*/()
    {
        ulong uVar2;
        uVar2 = new ZhSegment(0);
        puVar1 = *(uint64 **)(DAT_181d93640 + 184);
        *puVar1 = uVar2;
        il2cpp_internal(puVar1,uVar2);
    }

    // Token : 0x6002623
    // RVA   : 0x210B70   Offset: 0x20FF70   Length: 0x7
    public void /*ctor*/()
    {
        ZhSegment.Initialize(this,0);
    }

    // Token : 0x6002624
    // RVA   : 0x1843890   Offset: 0x1842C90   Length: 0x9C
    internal void <LoadDictionary>b__66_0(IList<string> items, Dictionary<string, string> dictionary)
    {
        ulong uVar1;
        ulong uVar2;
        if (items != null) {
          uVar1 = FUN_180002a00(0,DAT_181d8ecf8,items,0);
          uVar2 = FUN_180002a00(0,DAT_181d8ecf8,items,1);
          if (dictionary != null) {
            FUN_1808b2160(dictionary,uVar1,uVar2,DAT_181d75e90);
            return;
          }
        }
    }

    // Token : 0x6002625
    // RVA   : 0x1843670   Offset: 0x1842A70   Length: 0x215
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
                if (*(int64 *)(*(int64 *)(lVar1 + 176) + (uint64)uVar7 * 16) == DAT_181d8bbf8)
                {
                  puVar3 = (uint64 *)
                           ((int64)*(int *)(*(int64 *)(lVar1 + 176) + 8 + (uint64)uVar7 * 16)
                            * 16 + 0x138 + lVar1);
                  goto LAB_18184372c;
                }
                uVar7 = uVar7 + 1;
              } while (uVar7 < *(uint16 *)(lVar1 + 0x12a));
            }
            puVar3 = (uint64 *)FUN_1800914f0(items,DAT_181d8bbf8,0);
        LAB_18184372c:
            iVar2 = (*(code *)*puVar3)(items,puVar3[1]);
            if (iVar2 <= iVar8) {
              return;
            }
            lVar1 = *items;
            uVar4 = 0;
            if (*(uint16 *)(lVar1 + 0x12a) != 0) {
              do {
                if (*(int64 *)(*(int64 *)(lVar1 + 176) + uVar4 * 16) == DAT_181d8ecf8) {
                  puVar3 = (uint64 *)
                           ((int64)*(int *)(*(int64 *)(lVar1 + 176) + 8 + uVar4 * 16) * 16 +
                            0x138 + lVar1);
                  goto LAB_181843789;
                }
                uVar7 = (short)uVar4 + 1;
                uVar4 = (uint64)uVar7;
              } while (uVar7 < *(uint16 *)(lVar1 + 0x12a));
            }
            puVar3 = (uint64 *)FUN_1800914f0(items,DAT_181d8ecf8,0);
        LAB_181843789:
            uVar5 = (*(code *)*puVar3)(items,iVar8,puVar3[1]);
            lVar1 = *items;
            uVar4 = 0;
            if (*(uint16 *)(lVar1 + 0x12a) != 0) {
              do {
                if (*(int64 *)(*(int64 *)(lVar1 + 176) + uVar4 * 16) == DAT_181d8ecf8) {
                  puVar3 = (uint64 *)
                           ((int64)*(int *)(*(int64 *)(lVar1 + 176) + 8 + uVar4 * 16) * 16 +
                            0x138 + lVar1);
                  goto LAB_1818437e9;
                }
                uVar7 = (short)uVar4 + 1;
                uVar4 = (uint64)uVar7;
              } while (uVar7 < *(uint16 *)(lVar1 + 0x12a));
            }
            puVar3 = (uint64 *)FUN_1800914f0(items,DAT_181d8ecf8,0);
        LAB_1818437e9:
            uVar6 = (*(code *)*puVar3)(items,0,puVar3[1]);
            if (dictionary == null) break;
            FUN_1808b2160(dictionary,uVar5,uVar6,DAT_181d75e90);
            iVar8 = iVar8 + 1;
          } while( true );
        }
    }

    // Token : 0x6002626
    // RVA   : 0x18435B0   Offset: 0x18429B0   Length: 0xB4
    internal string <LoadDictionaryInternal>b__68_0(string name)
    {
        ulong uVar1;
        ulong uVar2;
        ulong uVar3;
        uVar2 = Application.get_streamingAssetsPath(0);
        uVar1 = **(uint64 **)(DAT_181d918c8 + 184);
        uVar3 = String.Concat(name,".txt",0);
        Path.Combine(uVar2,uVar1,uVar3,0);
    }

}
