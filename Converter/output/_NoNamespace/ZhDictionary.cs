// ============================================================
// Type  : ZhDictionary
// Token : 0x200043D
// ============================================================

public class ZhDictionary
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4002140
    private static string _dictionaryDirectory;

    // Token: 0x4002141
    private static IDictionary<string, string> <STCharacters>k__BackingField;

    // Token: 0x4002142
    private static IDictionary<string, string> <STPhrases>k__BackingField;

    // Token: 0x4002143
    private static IDictionary<string, string> <TSCharacters>k__BackingField;

    // Token: 0x4002144
    private static IDictionary<string, string> <TSPhrases>k__BackingField;

    // Token: 0x4002145
    private static IDictionary<string, string> <TWVariants>k__BackingField;

    // Token: 0x4002146
    private static IDictionary<string, string> <TWPhrases>k__BackingField;

    // Token: 0x4002147
    private static IDictionary<string, string> <TWVariantsRev>k__BackingField;

    // Token: 0x4002148
    private static IDictionary<string, string> <TWVariantsRevPhrases>k__BackingField;

    // Token: 0x4002149
    private static IDictionary<string, string> <TWPhrasesRev>k__BackingField;

    // Token: 0x400214A
    private static IDictionary<string, string> <HKVariants>k__BackingField;

    // Token: 0x400214B
    private static IDictionary<string, string> <HKVariantsRev>k__BackingField;

    // Token: 0x400214C
    private static IDictionary<string, string> <HKVariantsRevPhrases>k__BackingField;

    // Token: 0x400214D
    private static IDictionary<string, string> <JPVariants>k__BackingField;

    // Token: 0x400214E
    private static IDictionary<string, string> <JPVariantsRev>k__BackingField;

    // Token: 0x400214F
    private static IDictionary<string, string> <JPShinjitaiCharacters>k__BackingField;

    // Token: 0x4002150
    private static IDictionary<string, string> <JPShinjitaiPhrases>k__BackingField;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60026A8
    // RVA   : 0x1787670   Offset: 0x1786470   Length: 0x37
    public static IDictionary<string, string> get_STCharacters()
    {
        return *(uint64 *)(*(int64 *)(DAT_181e72090 + 184) + 8);
    }

    // Token : 0x60026A9
    // RVA   : 0x1787AE0   Offset: 0x17868E0   Length: 0x47
    public static void set_STCharacters(IDictionary<string, string> value)
    {
        puVar1 = (uint64 *)(*(int64 *)(DAT_181e72090 + 184) + 8);
        *puVar1 = value;
        il2cpp_internal(puVar1,value);
    }

    // Token : 0x60026AA
    // RVA   : 0x17876B0   Offset: 0x17864B0   Length: 0x37
    public static IDictionary<string, string> get_STPhrases()
    {
        return *(uint64 *)(*(int64 *)(DAT_181e72090 + 184) + 16);
    }

    // Token : 0x60026AB
    // RVA   : 0x1787B30   Offset: 0x1786930   Length: 0x47
    public static void set_STPhrases(IDictionary<string, string> value)
    {
        puVar1 = (uint64 *)(*(int64 *)(DAT_181e72090 + 184) + 16);
        *puVar1 = value;
        il2cpp_internal(puVar1,value);
    }

    // Token : 0x60026AC
    // RVA   : 0x17876F0   Offset: 0x17864F0   Length: 0x37
    public static IDictionary<string, string> get_TSCharacters()
    {
        return *(uint64 *)(*(int64 *)(DAT_181e72090 + 184) + 24);
    }

    // Token : 0x60026AD
    // RVA   : 0x1787B80   Offset: 0x1786980   Length: 0x47
    public static void set_TSCharacters(IDictionary<string, string> value)
    {
        puVar1 = (uint64 *)(*(int64 *)(DAT_181e72090 + 184) + 24);
        *puVar1 = value;
        il2cpp_internal(puVar1,value);
    }

    // Token : 0x60026AE
    // RVA   : 0x1787730   Offset: 0x1786530   Length: 0x37
    public static IDictionary<string, string> get_TSPhrases()
    {
        return *(uint64 *)(*(int64 *)(DAT_181e72090 + 184) + 32);
    }

    // Token : 0x60026AF
    // RVA   : 0x1787BD0   Offset: 0x17869D0   Length: 0x47
    public static void set_TSPhrases(IDictionary<string, string> value)
    {
        puVar1 = (uint64 *)(*(int64 *)(DAT_181e72090 + 184) + 32);
        *puVar1 = value;
        il2cpp_internal(puVar1,value);
    }

    // Token : 0x60026B0
    // RVA   : 0x1787870   Offset: 0x1786670   Length: 0x37
    public static IDictionary<string, string> get_TWVariants()
    {
        return *(uint64 *)(*(int64 *)(DAT_181e72090 + 184) + 40);
    }

    // Token : 0x60026B1
    // RVA   : 0x1787D60   Offset: 0x1786B60   Length: 0x47
    public static void set_TWVariants(IDictionary<string, string> value)
    {
        puVar1 = (uint64 *)(*(int64 *)(DAT_181e72090 + 184) + 40);
        *puVar1 = value;
        il2cpp_internal(puVar1,value);
    }

    // Token : 0x60026B2
    // RVA   : 0x17877B0   Offset: 0x17865B0   Length: 0x37
    public static IDictionary<string, string> get_TWPhrases()
    {
        return *(uint64 *)(*(int64 *)(DAT_181e72090 + 184) + 48);
    }

    // Token : 0x60026B3
    // RVA   : 0x1787C70   Offset: 0x1786A70   Length: 0x47
    public static void set_TWPhrases(IDictionary<string, string> value)
    {
        puVar1 = (uint64 *)(*(int64 *)(DAT_181e72090 + 184) + 48);
        *puVar1 = value;
        il2cpp_internal(puVar1,value);
    }

    // Token : 0x60026B4
    // RVA   : 0x1787830   Offset: 0x1786630   Length: 0x37
    public static IDictionary<string, string> get_TWVariantsRev()
    {
        return *(uint64 *)(*(int64 *)(DAT_181e72090 + 184) + 56);
    }

    // Token : 0x60026B5
    // RVA   : 0x1787D10   Offset: 0x1786B10   Length: 0x47
    public static void set_TWVariantsRev(IDictionary<string, string> value)
    {
        puVar1 = (uint64 *)(*(int64 *)(DAT_181e72090 + 184) + 56);
        *puVar1 = value;
        il2cpp_internal(puVar1,value);
    }

    // Token : 0x60026B6
    // RVA   : 0x17877F0   Offset: 0x17865F0   Length: 0x37
    public static IDictionary<string, string> get_TWVariantsRevPhrases()
    {
        return *(uint64 *)(*(int64 *)(DAT_181e72090 + 184) + 64);
    }

    // Token : 0x60026B7
    // RVA   : 0x1787CC0   Offset: 0x1786AC0   Length: 0x47
    public static void set_TWVariantsRevPhrases(IDictionary<string, string> value)
    {
        puVar1 = (uint64 *)(*(int64 *)(DAT_181e72090 + 184) + 64);
        *puVar1 = value;
        il2cpp_internal(puVar1,value);
    }

    // Token : 0x60026B8
    // RVA   : 0x1787770   Offset: 0x1786570   Length: 0x37
    public static IDictionary<string, string> get_TWPhrasesRev()
    {
        return *(uint64 *)(*(int64 *)(DAT_181e72090 + 184) + 72);
    }

    // Token : 0x60026B9
    // RVA   : 0x1787C20   Offset: 0x1786A20   Length: 0x47
    public static void set_TWPhrasesRev(IDictionary<string, string> value)
    {
        puVar1 = (uint64 *)(*(int64 *)(DAT_181e72090 + 184) + 72);
        *puVar1 = value;
        il2cpp_internal(puVar1,value);
    }

    // Token : 0x60026BA
    // RVA   : 0x1787530   Offset: 0x1786330   Length: 0x37
    public static IDictionary<string, string> get_HKVariants()
    {
        return *(uint64 *)(*(int64 *)(DAT_181e72090 + 184) + 80);
    }

    // Token : 0x60026BB
    // RVA   : 0x1787950   Offset: 0x1786750   Length: 0x47
    public static void set_HKVariants(IDictionary<string, string> value)
    {
        puVar1 = (uint64 *)(*(int64 *)(DAT_181e72090 + 184) + 80);
        *puVar1 = value;
        il2cpp_internal(puVar1,value);
    }

    // Token : 0x60026BC
    // RVA   : 0x17874F0   Offset: 0x17862F0   Length: 0x37
    public static IDictionary<string, string> get_HKVariantsRev()
    {
        return *(uint64 *)(*(int64 *)(DAT_181e72090 + 184) + 88);
    }

    // Token : 0x60026BD
    // RVA   : 0x1787900   Offset: 0x1786700   Length: 0x47
    public static void set_HKVariantsRev(IDictionary<string, string> value)
    {
        puVar1 = (uint64 *)(*(int64 *)(DAT_181e72090 + 184) + 88);
        *puVar1 = value;
        il2cpp_internal(puVar1,value);
    }

    // Token : 0x60026BE
    // RVA   : 0x17874B0   Offset: 0x17862B0   Length: 0x37
    public static IDictionary<string, string> get_HKVariantsRevPhrases()
    {
        return *(uint64 *)(*(int64 *)(DAT_181e72090 + 184) + 96);
    }

    // Token : 0x60026BF
    // RVA   : 0x17878B0   Offset: 0x17866B0   Length: 0x47
    public static void set_HKVariantsRevPhrases(IDictionary<string, string> value)
    {
        puVar1 = (uint64 *)(*(int64 *)(DAT_181e72090 + 184) + 96);
        *puVar1 = value;
        il2cpp_internal(puVar1,value);
    }

    // Token : 0x60026C0
    // RVA   : 0x1787630   Offset: 0x1786430   Length: 0x37
    public static IDictionary<string, string> get_JPVariants()
    {
        return *(uint64 *)(*(int64 *)(DAT_181e72090 + 184) + 104);
    }

    // Token : 0x60026C1
    // RVA   : 0x1787A90   Offset: 0x1786890   Length: 0x47
    public static void set_JPVariants(IDictionary<string, string> value)
    {
        puVar1 = (uint64 *)(*(int64 *)(DAT_181e72090 + 184) + 104);
        *puVar1 = value;
        il2cpp_internal(puVar1,value);
    }

    // Token : 0x60026C2
    // RVA   : 0x17875F0   Offset: 0x17863F0   Length: 0x37
    public static IDictionary<string, string> get_JPVariantsRev()
    {
        return *(uint64 *)(*(int64 *)(DAT_181e72090 + 184) + 112);
    }

    // Token : 0x60026C3
    // RVA   : 0x1787A40   Offset: 0x1786840   Length: 0x47
    public static void set_JPVariantsRev(IDictionary<string, string> value)
    {
        puVar1 = (uint64 *)(*(int64 *)(DAT_181e72090 + 184) + 112);
        *puVar1 = value;
        il2cpp_internal(puVar1,value);
    }

    // Token : 0x60026C4
    // RVA   : 0x1787570   Offset: 0x1786370   Length: 0x37
    public static IDictionary<string, string> get_JPShinjitaiCharacters()
    {
        return *(uint64 *)(*(int64 *)(DAT_181e72090 + 184) + 120);
    }

    // Token : 0x60026C5
    // RVA   : 0x17879A0   Offset: 0x17867A0   Length: 0x47
    public static void set_JPShinjitaiCharacters(IDictionary<string, string> value)
    {
        puVar1 = (uint64 *)(*(int64 *)(DAT_181e72090 + 184) + 120);
        *puVar1 = value;
        il2cpp_internal(puVar1,value);
    }

    // Token : 0x60026C6
    // RVA   : 0x17875B0   Offset: 0x17863B0   Length: 0x3A
    public static IDictionary<string, string> get_JPShinjitaiPhrases()
    {
        return *(uint64 *)(*(int64 *)(DAT_181e72090 + 184) + 128);
    }

    // Token : 0x60026C7
    // RVA   : 0x17879F0   Offset: 0x17867F0   Length: 0x47
    public static void set_JPShinjitaiPhrases(IDictionary<string, string> value)
    {
        puVar1 = (uint64 *)(*(int64 *)(DAT_181e72090 + 184) + 128);
        *puVar1 = value;
        il2cpp_internal(puVar1,value);
    }

    // Token : 0x60026C8
    // RVA   : 0x1785DD0   Offset: 0x1784BD0   Length: 0xF00
    public static void Initialize(string dictionaryDirectory)
    {
        var pStatics = *(int64*)(DAT_181e72090 + 184);
        long lVar2;
        ulong uVar3;
        puVar4 = *(uint64 **)(DAT_181e72090 + 184);
        *puVar4 = dictionaryDirectory;
        il2cpp_internal(puVar4,dictionaryDirectory);
        plVar1 = (int64 *)FUN_1801dfd90(DAT_181e85e38,1);
        if (plVar1 != (int64 *)0) {
          if (("STCharacters" != 0) &&
             (lVar2 = il2cpp_internal("STCharacters",*(uint64 *)(*plVar1 + 64))) == null) {
            uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1801e02d0(uVar3,0);
          }
          lVar2 = "STCharacters";
          if ((int)plVar1[3] == 0) {
            uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1801e02d0(uVar3,0);
          }
          plVar1[4] = "STCharacters";
          il2cpp_internal(plVar1 + 4,lVar2);
          uVar3 = ZhDictionary.LoadDictionary(plVar1,0);
          ZhDictionary.<STCharacters>k.BackingField = uVar3;
          plVar1 = (int64 *)FUN_1801dfd90(DAT_181e85e38,1);
          if (plVar1 != (int64 *)0) {
            if (("STPhrases" != 0) &&
               (lVar2 = il2cpp_internal("STPhrases",*(uint64 *)(*plVar1 + 64))) == null) {
              uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1801e02d0(uVar3,0);
            }
            lVar2 = "STPhrases";
            if ((int)plVar1[3] == 0) {
              uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1801e02d0(uVar3,0);
            }
            plVar1[4] = "STPhrases";
            il2cpp_internal(plVar1 + 4,lVar2);
            uVar3 = ZhDictionary.LoadDictionary(plVar1,0);
            ZhDictionary.<STPhrases>k.BackingField = uVar3;
            plVar1 = (int64 *)FUN_1801dfd90(DAT_181e85e38,1);
            if (plVar1 != (int64 *)0) {
              if (("TSCharacters" != 0) &&
                 (lVar2 = il2cpp_internal("TSCharacters",*(uint64 *)(*plVar1 + 64))) == null)
              {
                uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1801e02d0(uVar3,0);
              }
              lVar2 = "TSCharacters";
              if ((int)plVar1[3] == 0) {
                uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1801e02d0(uVar3,0);
              }
              plVar1[4] = "TSCharacters";
              il2cpp_internal(plVar1 + 4,lVar2);
              uVar3 = ZhDictionary.LoadDictionary(plVar1,0);
              ZhDictionary.<TSCharacters>k.BackingField = uVar3;
              plVar1 = (int64 *)FUN_1801dfd90(DAT_181e85e38,1);
              if (plVar1 != (int64 *)0) {
                if (("TSPhrases" != 0) &&
                   (lVar2 = il2cpp_internal("TSPhrases",*(uint64 *)(*plVar1 + 64)), lVar2 == null
                   )) {
                  uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1801e02d0(uVar3,0);
                }
                lVar2 = "TSPhrases";
                if ((int)plVar1[3] == 0) {
                  uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1801e02d0(uVar3,0);
                }
                plVar1[4] = "TSPhrases";
                il2cpp_internal(plVar1 + 4,lVar2);
                uVar3 = ZhDictionary.LoadDictionary(plVar1,0);
                ZhDictionary.<TSPhrases>k.BackingField = uVar3;
                plVar1 = (int64 *)FUN_1801dfd90(DAT_181e85e38,1);
                if (plVar1 != (int64 *)0) {
                  if (("TWVariants" != 0) &&
                     (lVar2 = il2cpp_internal("TWVariants",*(uint64 *)(*plVar1 + 64)),
                     lVar2 == null)) {
                    uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                    FUN_1801e02d0(uVar3,0);
                  }
                  lVar2 = "TWVariants";
                  if ((int)plVar1[3] == 0) {
                    uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                    FUN_1801e02d0(uVar3,0);
                  }
                  plVar1[4] = "TWVariants";
                  il2cpp_internal(plVar1 + 4,lVar2);
                  uVar3 = ZhDictionary.LoadDictionary(plVar1,0);
                  ZhDictionary.<TWVariants>k.BackingField = uVar3;
                  plVar1 = (int64 *)FUN_1801dfd90(DAT_181e85e38,3);
                  if (plVar1 != (int64 *)0) {
                    if (("TWPhrasesIT" != 0) &&
                       (lVar2 = il2cpp_internal("TWPhrasesIT",*(uint64 *)(*plVar1 + 64)),
                       lVar2 == null)) {
                      uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                      FUN_1801e02d0(uVar3,0);
                    }
                    lVar2 = "TWPhrasesIT";
                    if ((int)plVar1[3] == 0) {
                      uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                      FUN_1801e02d0(uVar3,0);
                    }
                    plVar1[4] = "TWPhrasesIT";
                    il2cpp_internal(plVar1 + 4,lVar2);
                    if (("TWPhrasesName" != 0) &&
                       (lVar2 = il2cpp_internal("TWPhrasesName",*(uint64 *)(*plVar1 + 64)),
                       lVar2 == null)) {
                      uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                      FUN_1801e02d0(uVar3,0);
                    }
                    lVar2 = "TWPhrasesName";
                    if (*(uint32 *)(plVar1 + 3) < 2) {
                      uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                      FUN_1801e02d0(uVar3,0);
                    }
                    plVar1[5] = "TWPhrasesName";
                    il2cpp_internal(plVar1 + 5,lVar2);
                    if (("TWPhrasesOther" != 0) &&
                       (lVar2 = il2cpp_internal("TWPhrasesOther",*(uint64 *)(*plVar1 + 64)),
                       lVar2 == null)) {
                      uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                      FUN_1801e02d0(uVar3,0);
                    }
                    lVar2 = "TWPhrasesOther";
                    if (*(uint32 *)(plVar1 + 3) < 3) {
                      uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                      FUN_1801e02d0(uVar3,0);
                    }
                    plVar1[6] = "TWPhrasesOther";
                    il2cpp_internal(plVar1 + 6,lVar2);
                    uVar3 = ZhDictionary.LoadDictionary(plVar1,0);
                    ZhDictionary.<TWPhrases>k.BackingField = uVar3;
                    plVar1 = (int64 *)FUN_1801dfd90(DAT_181e85e38,1);
                    if (plVar1 != (int64 *)0) {
                      if (("TWVariants" != 0) &&
                         (lVar2 = il2cpp_internal("TWVariants",*(uint64 *)(*plVar1 + 64)),
                         lVar2 == null)) {
                        uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                        FUN_1801e02d0(uVar3,0);
                      }
                      lVar2 = "TWVariants";
                      if ((int)plVar1[3] == 0) {
                        uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                        FUN_1801e02d0(uVar3,0);
                      }
                      plVar1[4] = "TWVariants";
                      il2cpp_internal(plVar1 + 4,lVar2);
                      uVar3 = ZhDictionary.LoadDictionaryReversed(plVar1,0);
                      ZhDictionary.<TWVariantsRev>k.BackingField = uVar3;
                      plVar1 = (int64 *)FUN_1801dfd90(DAT_181e85e38,1);
                      if (plVar1 != (int64 *)0) {
                        if (("TWVariantsRevPhrases" != 0) &&
                           (lVar2 = il2cpp_internal("TWVariantsRevPhrases",*(uint64 *)(*plVar1 + 64)),
                           lVar2 == null)) {
                          uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                          FUN_1801e02d0(uVar3,0);
                        }
                        lVar2 = "TWVariantsRevPhrases";
                        if ((int)plVar1[3] == 0) {
                          uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                          FUN_1801e02d0(uVar3,0);
                        }
                        plVar1[4] = "TWVariantsRevPhrases";
                        il2cpp_internal(plVar1 + 4,lVar2);
                        uVar3 = ZhDictionary.LoadDictionary(plVar1,0);
                        ZhDictionary.<TWVariantsRevPhrases>k.BackingField = uVar3;
                        plVar1 = (int64 *)FUN_1801dfd90(DAT_181e85e38,3);
                        if (plVar1 != (int64 *)0) {
                          if (("TWPhrasesIT" != 0) &&
                             (lVar2 = il2cpp_internal("TWPhrasesIT",*(uint64 *)(*plVar1 + 64)),
                             lVar2 == null)) {
                            uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                            FUN_1801e02d0(uVar3,0);
                          }
                          lVar2 = "TWPhrasesIT";
                          if ((int)plVar1[3] == 0) {
                            uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                            FUN_1801e02d0(uVar3,0);
                          }
                          plVar1[4] = "TWPhrasesIT";
                          il2cpp_internal(plVar1 + 4,lVar2);
                          if (("TWPhrasesName" != 0) &&
                             (lVar2 = il2cpp_internal("TWPhrasesName",*(uint64 *)(*plVar1 + 64)),
                             lVar2 == null)) {
                            uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                            FUN_1801e02d0(uVar3,0);
                          }
                          lVar2 = "TWPhrasesName";
                          if (*(uint32 *)(plVar1 + 3) < 2) {
                            uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                            FUN_1801e02d0(uVar3,0);
                          }
                          plVar1[5] = "TWPhrasesName";
                          il2cpp_internal(plVar1 + 5,lVar2);
                          if (("TWPhrasesOther" != 0) &&
                             (lVar2 = il2cpp_internal("TWPhrasesOther",*(uint64 *)(*plVar1 + 64)),
                             lVar2 == null)) {
                            uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                            FUN_1801e02d0(uVar3,0);
                          }
                          lVar2 = "TWPhrasesOther";
                          if (*(uint32 *)(plVar1 + 3) < 3) {
                            uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                            FUN_1801e02d0(uVar3,0);
                          }
                          plVar1[6] = "TWPhrasesOther";
                          il2cpp_internal(plVar1 + 6,lVar2);
                          uVar3 = ZhDictionary.LoadDictionaryReversed(plVar1,0);
                          ZhDictionary.<TWPhrasesRev>k.BackingField = uVar3;
                          plVar1 = (int64 *)FUN_1801dfd90(DAT_181e85e38,1);
                          if (plVar1 != (int64 *)0) {
                            if (("HKVariants" != 0) &&
                               (lVar2 = il2cpp_internal("HKVariants",*(uint64 *)(*plVar1 + 64))
                               , lVar2 == null)) {
                              uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                              FUN_1801e02d0(uVar3,0);
                            }
                            lVar2 = "HKVariants";
                            if ((int)plVar1[3] == 0) {
                              uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                              FUN_1801e02d0(uVar3,0);
                            }
                            plVar1[4] = "HKVariants";
                            il2cpp_internal(plVar1 + 4,lVar2);
                            uVar3 = ZhDictionary.LoadDictionary(plVar1,0);
                            ZhDictionary.<HKVariants>k.BackingField = uVar3;
                            plVar1 = (int64 *)FUN_1801dfd90(DAT_181e85e38,1);
                            if (plVar1 != (int64 *)0) {
                              if (("HKVariants" != 0) &&
                                 (lVar2 = il2cpp_internal("HKVariants",
                                                              *(uint64 *)(*plVar1 + 64)), lVar2 == null
                                 )) {
                                uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                FUN_1801e02d0(uVar3,0);
                              }
                              lVar2 = "HKVariants";
                              if ((int)plVar1[3] == 0) {
                                uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                FUN_1801e02d0(uVar3,0);
                              }
                              plVar1[4] = "HKVariants";
                              il2cpp_internal(plVar1 + 4,lVar2);
                              uVar3 = ZhDictionary.LoadDictionaryReversed(plVar1,0);
                              ZhDictionary.<HKVariantsRev>k.BackingField = uVar3;
                              plVar1 = (int64 *)FUN_1801dfd90(DAT_181e85e38,1);
                              if (plVar1 != (int64 *)0) {
                                if (("HKVariantsRevPhrases" != 0) &&
                                   (lVar2 = il2cpp_internal("HKVariantsRevPhrases",
                                                                *(uint64 *)(*plVar1 + 64)),
                                   lVar2 == null)) {
                                  uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                  FUN_1801e02d0(uVar3,0);
                                }
                                lVar2 = "HKVariantsRevPhrases";
                                if ((int)plVar1[3] == 0) {
                                  uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                  FUN_1801e02d0(uVar3,0);
                                }
                                plVar1[4] = "HKVariantsRevPhrases";
                                il2cpp_internal(plVar1 + 4,lVar2);
                                uVar3 = ZhDictionary.LoadDictionary(plVar1,0);
                                ZhDictionary.<HKVariantsRevPhrases>k.BackingField = uVar3;
                                plVar1 = (int64 *)FUN_1801dfd90(DAT_181e85e38,1);
                                if (plVar1 != (int64 *)0) {
                                  if (("JPVariants" != 0) &&
                                     (lVar2 = il2cpp_internal("JPVariants",
                                                                  *(uint64 *)(*plVar1 + 64)),
                                     lVar2 == null)) {
                                    uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                    FUN_1801e02d0(uVar3,0);
                                  }
                                  lVar2 = "JPVariants";
                                  if ((int)plVar1[3] == 0) {
                                    uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                    FUN_1801e02d0(uVar3,0);
                                  }
                                  plVar1[4] = "JPVariants";
                                  il2cpp_internal(plVar1 + 4,lVar2);
                                  uVar3 = ZhDictionary.LoadDictionary(plVar1,0);
                                  ZhDictionary.<JPVariants>k.BackingField = uVar3;
                                  plVar1 = (int64 *)FUN_1801dfd90(DAT_181e85e38,1);
                                  if (plVar1 != (int64 *)0) {
                                    if (("JPVariants" != 0) &&
                                       (lVar2 = il2cpp_internal("JPVariants",
                                                                    *(uint64 *)(*plVar1 + 64)),
                                       lVar2 == null)) {
                                      uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                      FUN_1801e02d0(uVar3,0);
                                    }
                                    lVar2 = "JPVariants";
                                    if ((int)plVar1[3] == 0) {
                                      uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                      FUN_1801e02d0(uVar3,0);
                                    }
                                    plVar1[4] = "JPVariants";
                                    il2cpp_internal(plVar1 + 4,lVar2);
                                    uVar3 = ZhDictionary.LoadDictionaryReversed(plVar1,0);
                                    ZhDictionary.<JPVariantsRev>k.BackingField = uVar3;
                                    plVar1 = (int64 *)FUN_1801dfd90(DAT_181e85e38,1);
                                    if (plVar1 != (int64 *)0) {
                                      if (("JPShinjitaiCharacters" != 0) &&
                                         (lVar2 = il2cpp_internal("JPShinjitaiCharacters",
                                                                      *(uint64 *)(*plVar1 + 64)),
                                         lVar2 == null)) {
                                        uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                        FUN_1801e02d0(uVar3,0);
                                      }
                                      lVar2 = "JPShinjitaiCharacters";
                                      if ((int)plVar1[3] == 0) {
                                        uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                        FUN_1801e02d0(uVar3,0);
                                      }
                                      plVar1[4] = "JPShinjitaiCharacters";
                                      il2cpp_internal(plVar1 + 4,lVar2);
                                      uVar3 = ZhDictionary.LoadDictionary(plVar1,0);
                                      ZhDictionary.<JPShinjitaiCharacters>k.BackingField = uVar3;
                                      plVar1 = (int64 *)FUN_1801dfd90(DAT_181e85e38,1);
                                      if (plVar1 != (int64 *)0) {
                                        if (("JPShinjitaiPhrases" != 0) &&
                                           (lVar2 = il2cpp_internal("JPShinjitaiPhrases",
                                                                        *(uint64 *)(*plVar1 + 64)),
                                           lVar2 == null)) {
                                          uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                          FUN_1801e02d0(uVar3,0);
                                        }
                                        lVar2 = "JPShinjitaiPhrases";
                                        if ((int)plVar1[3] == 0) {
                                          uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                          FUN_1801e02d0(uVar3,0);
                                        }
                                        plVar1[4] = "JPShinjitaiPhrases";
                                        il2cpp_internal(plVar1 + 4,lVar2);
                                        uVar3 = ZhDictionary.LoadDictionary(plVar1,0);
                                        puVar4 = (uint64 *)
                                                 (pStatics + 128);
                                        *puVar4 = uVar3;
                                        il2cpp_internal(puVar4,uVar3);
                                        return;
                                      }
                                    }
                                  }
                                }
                              }
                            }
                          }
                        }
                      }
                    }
                  }
                }
              }
            }
          }
        }
    }

    // Token : 0x60026C9
    // RVA   : 0x17873A0   Offset: 0x17861A0   Length: 0x110
    private static IDictionary<string, string> LoadDictionary(string[] dictionaryNames)
    {
        ulong uVar1;
        long lVar2;
        lVar2 = ZhDictionary.<STCharacters>k.BackingField;
        if (lVar2 == null) {
          uVar1 = **(uint64 **)(DAT_181e73e10 + 184);
          lVar2 = new OnTooltipCB(uVar1,DAT_181e9ecf0,DAT_181e79300);
          ZhDictionary.<STCharacters>k.BackingField = lVar2;
        }
        ZhDictionary.LoadDictionaryInternal(dictionaryNames,lVar2,0);
    }

    // Token : 0x60026CA
    // RVA   : 0x1787290   Offset: 0x1786090   Length: 0x110
    private static IDictionary<string, string> LoadDictionaryReversed(string[] dictionaryNames)
    {
        ulong uVar1;
        long lVar2;
        lVar2 = ZhDictionary.<STPhrases>k.BackingField;
        if (lVar2 == null) {
          uVar1 = **(uint64 **)(DAT_181e73e10 + 184);
          lVar2 = new OnTooltipCB(uVar1,DAT_181e9ee00,DAT_181e79300);
          ZhDictionary.<STPhrases>k.BackingField = lVar2;
        }
        ZhDictionary.LoadDictionaryInternal(dictionaryNames,lVar2,0);
    }

    // Token : 0x60026CB
    // RVA   : 0x1786CE0   Offset: 0x1785AE0   Length: 0x5AB
    private static IDictionary<string, string> LoadDictionaryInternal(IList<string> dictionaryNames, Action<IList<string>, Dictionary<string, string>> processLine)
    {
        bool cVar1;
        ulong uVar2;
        long lVar3;
        ulong uVar5;
        long lVar6;
        ulong uVar7;
        ushort uVar8;
        uint uVar10;
        ushort uVar11;
        cVar1 = FUN_180ad1200(**(uint64 **)(DAT_181e72090 + 184),0);
        if (cVar1) {
          uVar2 = il2cpp_runtime_class_init(&DAT_181e61d70);
          uVar2 = il2cpp_internal(uVar2);
          uVar7 = il2cpp_internal(&"字典目录未初始化，请先调用Initialize方法");
          InvalidOperationException.ctor(uVar2,uVar7,0);
          uVar7 = il2cpp_runtime_class_init(&DAT_181e9e1c8);
                          // WARNING: Subroutine does not return
          FUN_1801e02d0(uVar2,uVar7);
        }
        uVar2 = il2cpp_internal(DAT_181e631c0);
        FUN_1806e5e00(uVar2,10000,DAT_181e56b38);
        lVar3 = ZhDictionary.<TSCharacters>k.BackingField;
        if (lVar3 == null) {
          uVar7 = **(uint64 **)(DAT_181e73e10 + 184);
          lVar3 = new OnTooltipCB(uVar7,DAT_181e9ed78,DAT_181e94e90);
          ZhDictionary.<TSCharacters>k.BackingField = lVar3;
        }
        plVar9 = (int64 *)FUN_18077b610(dictionaryNames,lVar3,DAT_181e97990);
        if (plVar9 == (int64 *)0) {
                          // WARNING: Subroutine does not return
          FUN_1801e0300();
        }
        lVar3 = *plVar9;
        uVar11 = 0;
        if (*(uint16 *)(lVar3 + 0x12a) != 0) {
          uVar8 = uVar11;
          do {
            if (*(int64 *)(*(int64 *)(lVar3 + 176) + (uint64)uVar8 * 16) == DAT_181e6cab8) {
              puVar4 = (uint64 *)
                       ((int64)*(int *)(*(int64 *)(lVar3 + 176) + 8 + (uint64)uVar8 * 16) *
                        16 + 0x138 + lVar3);
              goto LAB_181786f0c;
            }
            uVar8 = uVar8 + 1;
          } while (uVar8 < *(uint16 *)(lVar3 + 0x12a));
        }
        puVar4 = (uint64 *)FUN_18019b1f0(plVar9,DAT_181e6cab8,0);
        LAB_181786f0c:
        plVar9 = (int64 *)(*(code *)*puVar4)(plVar9,puVar4[1]);
        do {
          if (plVar9 == (int64 *)0) {
                          // WARNING: Subroutine does not return
            FUN_1801e0300();
          }
          lVar3 = *plVar9;
          if (*(uint16 *)(lVar3 + 0x12a) != 0) {
            uVar8 = uVar11;
            do {
              if (*(int64 *)(*(int64 *)(lVar3 + 176) + (uint64)uVar8 * 16) == DAT_181e593c0) {
                puVar4 = (uint64 *)
                         ((int64)*(int *)(*(int64 *)(lVar3 + 176) + 8 + (uint64)uVar8 * 16) *
                          16 + 0x138 + lVar3);
                goto LAB_181786f79;
              }
              uVar8 = uVar8 + 1;
            } while (uVar8 < *(uint16 *)(lVar3 + 0x12a));
          }
          puVar4 = (uint64 *)FUN_18019b1f0(plVar9,DAT_181e593c0,0);
        LAB_181786f79:
          cVar1 = (*(code *)*puVar4)(plVar9,puVar4[1]);
          if (!cVar1) {
            FUN_180002280(0,DAT_181e58ab8,plVar9);
            return uVar2;
          }
          lVar3 = *plVar9;
          if (*(uint16 *)(lVar3 + 0x12a) != 0) {
            uVar8 = uVar11;
            do {
              if (*(int64 *)(*(int64 *)(lVar3 + 176) + (uint64)uVar8 * 16) == DAT_181e6de38) {
                puVar4 = (uint64 *)
                         ((int64)*(int *)(*(int64 *)(lVar3 + 176) + 8 + (uint64)uVar8 * 16) *
                          16 + 0x138 + lVar3);
                goto LAB_181786fd9;
              }
              uVar8 = uVar8 + 1;
            } while (uVar8 < *(uint16 *)(lVar3 + 0x12a));
          }
          puVar4 = (uint64 *)FUN_18019b1f0(plVar9,DAT_181e6de38,0);
        LAB_181786fd9:
          uVar5 = (*(code *)*puVar4)(plVar9,puVar4[1]);
          uVar7 = uVar5;
          cVar1 = File.Exists(uVar5,0);
          if (!cVar1) {
            uVar2 = il2cpp_internal(&"找不到字典文件：");
            uVar2 = String.Concat(uVar2,uVar5,0);
            uVar7 = il2cpp_runtime_class_init(&DAT_181ea7868);
            uVar7 = il2cpp_internal(uVar7);
            FileNotFoundException.ctor(uVar7,uVar2,0);
            uVar2 = il2cpp_runtime_class_init(&DAT_181e9e1c8);
                          // WARNING: Subroutine does not return
            FUN_1801e02d0(uVar7,uVar2);
          }
          lVar3 = File.ReadAllLines(uVar5,0);
          uVar10 = 0;
          while( true ) {
            if (lVar3 == null) {
                          // WARNING: Subroutine does not return
              FUN_1801e0300();
            }
            if ((int)*(uint32 *)(lVar3 + 24) <= (int)uVar10) break;
            if (*(uint32 *)(lVar3 + 24) <= uVar10) {
              uVar2 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1801e02d0(uVar2,0);
            }
            lVar6 = lVar3[uVar10];
            cVar1 = String.IsNullOrWhiteSpace(lVar6);
            if (!cVar1) {
              if (lVar6 == null) {
                          // WARNING: Subroutine does not return
                FUN_1801e0300();
              }
              lVar6 = String.Split(lVar6,0,1,0,uVar7);
              if (lVar6 == null) {
                          // WARNING: Subroutine does not return
                FUN_1801e0300();
              }
              if (1 < *(int *)(lVar6 + 24)) {
                if (processLine == null) {
                          // WARNING: Subroutine does not return
                  FUN_1801e0300();
                }
                Action_2.Invoke(processLine,lVar6,uVar2);
              }
            }
            uVar10 = uVar10 + 1;
          }
        } while( true );
    }

}
