// ============================================================
// Type  : ZhDictionary
// Token : 0x2000430
// ============================================================

public class ZhDictionary
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x40020AD
    private static string _dictionaryDirectory;

    // Token: 0x40020AE
    private static IDictionary<string, string> <STCharacters>k__BackingField;

    // Token: 0x40020AF
    private static IDictionary<string, string> <STPhrases>k__BackingField;

    // Token: 0x40020B0
    private static IDictionary<string, string> <TSCharacters>k__BackingField;

    // Token: 0x40020B1
    private static IDictionary<string, string> <TSPhrases>k__BackingField;

    // Token: 0x40020B2
    private static IDictionary<string, string> <TWVariants>k__BackingField;

    // Token: 0x40020B3
    private static IDictionary<string, string> <TWPhrases>k__BackingField;

    // Token: 0x40020B4
    private static IDictionary<string, string> <TWVariantsRev>k__BackingField;

    // Token: 0x40020B5
    private static IDictionary<string, string> <TWVariantsRevPhrases>k__BackingField;

    // Token: 0x40020B6
    private static IDictionary<string, string> <TWPhrasesRev>k__BackingField;

    // Token: 0x40020B7
    private static IDictionary<string, string> <HKVariants>k__BackingField;

    // Token: 0x40020B8
    private static IDictionary<string, string> <HKVariantsRev>k__BackingField;

    // Token: 0x40020B9
    private static IDictionary<string, string> <HKVariantsRevPhrases>k__BackingField;

    // Token: 0x40020BA
    private static IDictionary<string, string> <JPVariants>k__BackingField;

    // Token: 0x40020BB
    private static IDictionary<string, string> <JPVariantsRev>k__BackingField;

    // Token: 0x40020BC
    private static IDictionary<string, string> <JPShinjitaiCharacters>k__BackingField;

    // Token: 0x40020BD
    private static IDictionary<string, string> <JPShinjitaiPhrases>k__BackingField;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60025FE
    // RVA   : 0x1846210   Offset: 0x1845610   Length: 0x37
    public static IDictionary<string, string> get_STCharacters()
    {
        return *(uint64 *)(*(int64 *)(DAT_181d918c8 + 184) + 8);
    }

    // Token : 0x60025FF
    // RVA   : 0x1846680   Offset: 0x1845A80   Length: 0x47
    public static void set_STCharacters(IDictionary<string, string> value)
    {
        puVar1 = (uint64 *)(*(int64 *)(DAT_181d918c8 + 184) + 8);
        *puVar1 = value;
        il2cpp_internal(puVar1,value);
    }

    // Token : 0x6002600
    // RVA   : 0x1846250   Offset: 0x1845650   Length: 0x37
    public static IDictionary<string, string> get_STPhrases()
    {
        return *(uint64 *)(*(int64 *)(DAT_181d918c8 + 184) + 16);
    }

    // Token : 0x6002601
    // RVA   : 0x18466D0   Offset: 0x1845AD0   Length: 0x47
    public static void set_STPhrases(IDictionary<string, string> value)
    {
        puVar1 = (uint64 *)(*(int64 *)(DAT_181d918c8 + 184) + 16);
        *puVar1 = value;
        il2cpp_internal(puVar1,value);
    }

    // Token : 0x6002602
    // RVA   : 0x1846290   Offset: 0x1845690   Length: 0x37
    public static IDictionary<string, string> get_TSCharacters()
    {
        return *(uint64 *)(*(int64 *)(DAT_181d918c8 + 184) + 24);
    }

    // Token : 0x6002603
    // RVA   : 0x1846720   Offset: 0x1845B20   Length: 0x47
    public static void set_TSCharacters(IDictionary<string, string> value)
    {
        puVar1 = (uint64 *)(*(int64 *)(DAT_181d918c8 + 184) + 24);
        *puVar1 = value;
        il2cpp_internal(puVar1,value);
    }

    // Token : 0x6002604
    // RVA   : 0x18462D0   Offset: 0x18456D0   Length: 0x37
    public static IDictionary<string, string> get_TSPhrases()
    {
        return *(uint64 *)(*(int64 *)(DAT_181d918c8 + 184) + 32);
    }

    // Token : 0x6002605
    // RVA   : 0x1846770   Offset: 0x1845B70   Length: 0x47
    public static void set_TSPhrases(IDictionary<string, string> value)
    {
        puVar1 = (uint64 *)(*(int64 *)(DAT_181d918c8 + 184) + 32);
        *puVar1 = value;
        il2cpp_internal(puVar1,value);
    }

    // Token : 0x6002606
    // RVA   : 0x1846410   Offset: 0x1845810   Length: 0x37
    public static IDictionary<string, string> get_TWVariants()
    {
        return *(uint64 *)(*(int64 *)(DAT_181d918c8 + 184) + 40);
    }

    // Token : 0x6002607
    // RVA   : 0x1846900   Offset: 0x1845D00   Length: 0x47
    public static void set_TWVariants(IDictionary<string, string> value)
    {
        puVar1 = (uint64 *)(*(int64 *)(DAT_181d918c8 + 184) + 40);
        *puVar1 = value;
        il2cpp_internal(puVar1,value);
    }

    // Token : 0x6002608
    // RVA   : 0x1846350   Offset: 0x1845750   Length: 0x37
    public static IDictionary<string, string> get_TWPhrases()
    {
        return *(uint64 *)(*(int64 *)(DAT_181d918c8 + 184) + 48);
    }

    // Token : 0x6002609
    // RVA   : 0x1846810   Offset: 0x1845C10   Length: 0x47
    public static void set_TWPhrases(IDictionary<string, string> value)
    {
        puVar1 = (uint64 *)(*(int64 *)(DAT_181d918c8 + 184) + 48);
        *puVar1 = value;
        il2cpp_internal(puVar1,value);
    }

    // Token : 0x600260A
    // RVA   : 0x18463D0   Offset: 0x18457D0   Length: 0x37
    public static IDictionary<string, string> get_TWVariantsRev()
    {
        return *(uint64 *)(*(int64 *)(DAT_181d918c8 + 184) + 56);
    }

    // Token : 0x600260B
    // RVA   : 0x18468B0   Offset: 0x1845CB0   Length: 0x47
    public static void set_TWVariantsRev(IDictionary<string, string> value)
    {
        puVar1 = (uint64 *)(*(int64 *)(DAT_181d918c8 + 184) + 56);
        *puVar1 = value;
        il2cpp_internal(puVar1,value);
    }

    // Token : 0x600260C
    // RVA   : 0x1846390   Offset: 0x1845790   Length: 0x37
    public static IDictionary<string, string> get_TWVariantsRevPhrases()
    {
        return *(uint64 *)(*(int64 *)(DAT_181d918c8 + 184) + 64);
    }

    // Token : 0x600260D
    // RVA   : 0x1846860   Offset: 0x1845C60   Length: 0x47
    public static void set_TWVariantsRevPhrases(IDictionary<string, string> value)
    {
        puVar1 = (uint64 *)(*(int64 *)(DAT_181d918c8 + 184) + 64);
        *puVar1 = value;
        il2cpp_internal(puVar1,value);
    }

    // Token : 0x600260E
    // RVA   : 0x1846310   Offset: 0x1845710   Length: 0x37
    public static IDictionary<string, string> get_TWPhrasesRev()
    {
        return *(uint64 *)(*(int64 *)(DAT_181d918c8 + 184) + 72);
    }

    // Token : 0x600260F
    // RVA   : 0x18467C0   Offset: 0x1845BC0   Length: 0x47
    public static void set_TWPhrasesRev(IDictionary<string, string> value)
    {
        puVar1 = (uint64 *)(*(int64 *)(DAT_181d918c8 + 184) + 72);
        *puVar1 = value;
        il2cpp_internal(puVar1,value);
    }

    // Token : 0x6002610
    // RVA   : 0x18460D0   Offset: 0x18454D0   Length: 0x37
    public static IDictionary<string, string> get_HKVariants()
    {
        return *(uint64 *)(*(int64 *)(DAT_181d918c8 + 184) + 80);
    }

    // Token : 0x6002611
    // RVA   : 0x18464F0   Offset: 0x18458F0   Length: 0x47
    public static void set_HKVariants(IDictionary<string, string> value)
    {
        puVar1 = (uint64 *)(*(int64 *)(DAT_181d918c8 + 184) + 80);
        *puVar1 = value;
        il2cpp_internal(puVar1,value);
    }

    // Token : 0x6002612
    // RVA   : 0x1846090   Offset: 0x1845490   Length: 0x37
    public static IDictionary<string, string> get_HKVariantsRev()
    {
        return *(uint64 *)(*(int64 *)(DAT_181d918c8 + 184) + 88);
    }

    // Token : 0x6002613
    // RVA   : 0x18464A0   Offset: 0x18458A0   Length: 0x47
    public static void set_HKVariantsRev(IDictionary<string, string> value)
    {
        puVar1 = (uint64 *)(*(int64 *)(DAT_181d918c8 + 184) + 88);
        *puVar1 = value;
        il2cpp_internal(puVar1,value);
    }

    // Token : 0x6002614
    // RVA   : 0x1846050   Offset: 0x1845450   Length: 0x37
    public static IDictionary<string, string> get_HKVariantsRevPhrases()
    {
        return *(uint64 *)(*(int64 *)(DAT_181d918c8 + 184) + 96);
    }

    // Token : 0x6002615
    // RVA   : 0x1846450   Offset: 0x1845850   Length: 0x47
    public static void set_HKVariantsRevPhrases(IDictionary<string, string> value)
    {
        puVar1 = (uint64 *)(*(int64 *)(DAT_181d918c8 + 184) + 96);
        *puVar1 = value;
        il2cpp_internal(puVar1,value);
    }

    // Token : 0x6002616
    // RVA   : 0x18461D0   Offset: 0x18455D0   Length: 0x37
    public static IDictionary<string, string> get_JPVariants()
    {
        return *(uint64 *)(*(int64 *)(DAT_181d918c8 + 184) + 104);
    }

    // Token : 0x6002617
    // RVA   : 0x1846630   Offset: 0x1845A30   Length: 0x47
    public static void set_JPVariants(IDictionary<string, string> value)
    {
        puVar1 = (uint64 *)(*(int64 *)(DAT_181d918c8 + 184) + 104);
        *puVar1 = value;
        il2cpp_internal(puVar1,value);
    }

    // Token : 0x6002618
    // RVA   : 0x1846190   Offset: 0x1845590   Length: 0x37
    public static IDictionary<string, string> get_JPVariantsRev()
    {
        return *(uint64 *)(*(int64 *)(DAT_181d918c8 + 184) + 112);
    }

    // Token : 0x6002619
    // RVA   : 0x18465E0   Offset: 0x18459E0   Length: 0x47
    public static void set_JPVariantsRev(IDictionary<string, string> value)
    {
        puVar1 = (uint64 *)(*(int64 *)(DAT_181d918c8 + 184) + 112);
        *puVar1 = value;
        il2cpp_internal(puVar1,value);
    }

    // Token : 0x600261A
    // RVA   : 0x1846110   Offset: 0x1845510   Length: 0x37
    public static IDictionary<string, string> get_JPShinjitaiCharacters()
    {
        return *(uint64 *)(*(int64 *)(DAT_181d918c8 + 184) + 120);
    }

    // Token : 0x600261B
    // RVA   : 0x1846540   Offset: 0x1845940   Length: 0x47
    public static void set_JPShinjitaiCharacters(IDictionary<string, string> value)
    {
        puVar1 = (uint64 *)(*(int64 *)(DAT_181d918c8 + 184) + 120);
        *puVar1 = value;
        il2cpp_internal(puVar1,value);
    }

    // Token : 0x600261C
    // RVA   : 0x1846150   Offset: 0x1845550   Length: 0x3A
    public static IDictionary<string, string> get_JPShinjitaiPhrases()
    {
        return *(uint64 *)(*(int64 *)(DAT_181d918c8 + 184) + 128);
    }

    // Token : 0x600261D
    // RVA   : 0x1846590   Offset: 0x1845990   Length: 0x47
    public static void set_JPShinjitaiPhrases(IDictionary<string, string> value)
    {
        puVar1 = (uint64 *)(*(int64 *)(DAT_181d918c8 + 184) + 128);
        *puVar1 = value;
        il2cpp_internal(puVar1,value);
    }

    // Token : 0x600261E
    // RVA   : 0x1844970   Offset: 0x1843D70   Length: 0xF00
    public static void Initialize(string dictionaryDirectory)
    {
        var pStatics = *(int64*)(DAT_181d918c8 + 184);
        long lVar2;
        ulong uVar3;
        puVar4 = *(uint64 **)(DAT_181d918c8 + 184);
        *puVar4 = dictionaryDirectory;
        il2cpp_internal(puVar4,dictionaryDirectory);
        plVar1 = (int64 *)FUN_1800d60b0(DAT_181da5cf8,1);
        if (plVar1 != (int64 *)0) {
          if (("STCharacters" != 0) &&
             (lVar2 = il2cpp_internal("STCharacters",*(uint64 *)(*plVar1 + 64))) == null) {
            uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar3,0);
          }
          lVar2 = "STCharacters";
          if ((int)plVar1[3] == 0) {
            uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar3,0);
          }
          plVar1[4] = "STCharacters";
          il2cpp_internal(plVar1 + 4,lVar2);
          uVar3 = ZhDictionary.LoadDictionary(plVar1,0);
          ZhDictionary.<STCharacters>k.BackingField = uVar3;
          plVar1 = (int64 *)FUN_1800d60b0(DAT_181da5cf8,1);
          if (plVar1 != (int64 *)0) {
            if (("STPhrases" != 0) &&
               (lVar2 = il2cpp_internal("STPhrases",*(uint64 *)(*plVar1 + 64))) == null) {
              uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar3,0);
            }
            lVar2 = "STPhrases";
            if ((int)plVar1[3] == 0) {
              uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar3,0);
            }
            plVar1[4] = "STPhrases";
            il2cpp_internal(plVar1 + 4,lVar2);
            uVar3 = ZhDictionary.LoadDictionary(plVar1,0);
            ZhDictionary.<STPhrases>k.BackingField = uVar3;
            plVar1 = (int64 *)FUN_1800d60b0(DAT_181da5cf8,1);
            if (plVar1 != (int64 *)0) {
              if (("TSCharacters" != 0) &&
                 (lVar2 = il2cpp_internal("TSCharacters",*(uint64 *)(*plVar1 + 64))) == null)
              {
                uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar3,0);
              }
              lVar2 = "TSCharacters";
              if ((int)plVar1[3] == 0) {
                uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar3,0);
              }
              plVar1[4] = "TSCharacters";
              il2cpp_internal(plVar1 + 4,lVar2);
              uVar3 = ZhDictionary.LoadDictionary(plVar1,0);
              ZhDictionary.<TSCharacters>k.BackingField = uVar3;
              plVar1 = (int64 *)FUN_1800d60b0(DAT_181da5cf8,1);
              if (plVar1 != (int64 *)0) {
                if (("TSPhrases" != 0) &&
                   (lVar2 = il2cpp_internal("TSPhrases",*(uint64 *)(*plVar1 + 64)), lVar2 == null
                   )) {
                  uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1800d65f0(uVar3,0);
                }
                lVar2 = "TSPhrases";
                if ((int)plVar1[3] == 0) {
                  uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1800d65f0(uVar3,0);
                }
                plVar1[4] = "TSPhrases";
                il2cpp_internal(plVar1 + 4,lVar2);
                uVar3 = ZhDictionary.LoadDictionary(plVar1,0);
                ZhDictionary.<TSPhrases>k.BackingField = uVar3;
                plVar1 = (int64 *)FUN_1800d60b0(DAT_181da5cf8,1);
                if (plVar1 != (int64 *)0) {
                  if (("TWVariants" != 0) &&
                     (lVar2 = il2cpp_internal("TWVariants",*(uint64 *)(*plVar1 + 64)),
                     lVar2 == null)) {
                    uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                    FUN_1800d65f0(uVar3,0);
                  }
                  lVar2 = "TWVariants";
                  if ((int)plVar1[3] == 0) {
                    uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                    FUN_1800d65f0(uVar3,0);
                  }
                  plVar1[4] = "TWVariants";
                  il2cpp_internal(plVar1 + 4,lVar2);
                  uVar3 = ZhDictionary.LoadDictionary(plVar1,0);
                  ZhDictionary.<TWVariants>k.BackingField = uVar3;
                  plVar1 = (int64 *)FUN_1800d60b0(DAT_181da5cf8,3);
                  if (plVar1 != (int64 *)0) {
                    if (("TWPhrasesIT" != 0) &&
                       (lVar2 = il2cpp_internal("TWPhrasesIT",*(uint64 *)(*plVar1 + 64)),
                       lVar2 == null)) {
                      uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                      FUN_1800d65f0(uVar3,0);
                    }
                    lVar2 = "TWPhrasesIT";
                    if ((int)plVar1[3] == 0) {
                      uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                      FUN_1800d65f0(uVar3,0);
                    }
                    plVar1[4] = "TWPhrasesIT";
                    il2cpp_internal(plVar1 + 4,lVar2);
                    if (("TWPhrasesName" != 0) &&
                       (lVar2 = il2cpp_internal("TWPhrasesName",*(uint64 *)(*plVar1 + 64)),
                       lVar2 == null)) {
                      uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                      FUN_1800d65f0(uVar3,0);
                    }
                    lVar2 = "TWPhrasesName";
                    if (*(uint32 *)(plVar1 + 3) < 2) {
                      uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                      FUN_1800d65f0(uVar3,0);
                    }
                    plVar1[5] = "TWPhrasesName";
                    il2cpp_internal(plVar1 + 5,lVar2);
                    if (("TWPhrasesOther" != 0) &&
                       (lVar2 = il2cpp_internal("TWPhrasesOther",*(uint64 *)(*plVar1 + 64)),
                       lVar2 == null)) {
                      uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                      FUN_1800d65f0(uVar3,0);
                    }
                    lVar2 = "TWPhrasesOther";
                    if (*(uint32 *)(plVar1 + 3) < 3) {
                      uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                      FUN_1800d65f0(uVar3,0);
                    }
                    plVar1[6] = "TWPhrasesOther";
                    il2cpp_internal(plVar1 + 6,lVar2);
                    uVar3 = ZhDictionary.LoadDictionary(plVar1,0);
                    ZhDictionary.<TWPhrases>k.BackingField = uVar3;
                    plVar1 = (int64 *)FUN_1800d60b0(DAT_181da5cf8,1);
                    if (plVar1 != (int64 *)0) {
                      if (("TWVariants" != 0) &&
                         (lVar2 = il2cpp_internal("TWVariants",*(uint64 *)(*plVar1 + 64)),
                         lVar2 == null)) {
                        uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                        FUN_1800d65f0(uVar3,0);
                      }
                      lVar2 = "TWVariants";
                      if ((int)plVar1[3] == 0) {
                        uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                        FUN_1800d65f0(uVar3,0);
                      }
                      plVar1[4] = "TWVariants";
                      il2cpp_internal(plVar1 + 4,lVar2);
                      uVar3 = ZhDictionary.LoadDictionaryReversed(plVar1,0);
                      ZhDictionary.<TWVariantsRev>k.BackingField = uVar3;
                      plVar1 = (int64 *)FUN_1800d60b0(DAT_181da5cf8,1);
                      if (plVar1 != (int64 *)0) {
                        if (("TWVariantsRevPhrases" != 0) &&
                           (lVar2 = il2cpp_internal("TWVariantsRevPhrases",*(uint64 *)(*plVar1 + 64)),
                           lVar2 == null)) {
                          uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                          FUN_1800d65f0(uVar3,0);
                        }
                        lVar2 = "TWVariantsRevPhrases";
                        if ((int)plVar1[3] == 0) {
                          uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                          FUN_1800d65f0(uVar3,0);
                        }
                        plVar1[4] = "TWVariantsRevPhrases";
                        il2cpp_internal(plVar1 + 4,lVar2);
                        uVar3 = ZhDictionary.LoadDictionary(plVar1,0);
                        ZhDictionary.<TWVariantsRevPhrases>k.BackingField = uVar3;
                        plVar1 = (int64 *)FUN_1800d60b0(DAT_181da5cf8,3);
                        if (plVar1 != (int64 *)0) {
                          if (("TWPhrasesIT" != 0) &&
                             (lVar2 = il2cpp_internal("TWPhrasesIT",*(uint64 *)(*plVar1 + 64)),
                             lVar2 == null)) {
                            uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                            FUN_1800d65f0(uVar3,0);
                          }
                          lVar2 = "TWPhrasesIT";
                          if ((int)plVar1[3] == 0) {
                            uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                            FUN_1800d65f0(uVar3,0);
                          }
                          plVar1[4] = "TWPhrasesIT";
                          il2cpp_internal(plVar1 + 4,lVar2);
                          if (("TWPhrasesName" != 0) &&
                             (lVar2 = il2cpp_internal("TWPhrasesName",*(uint64 *)(*plVar1 + 64)),
                             lVar2 == null)) {
                            uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                            FUN_1800d65f0(uVar3,0);
                          }
                          lVar2 = "TWPhrasesName";
                          if (*(uint32 *)(plVar1 + 3) < 2) {
                            uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                            FUN_1800d65f0(uVar3,0);
                          }
                          plVar1[5] = "TWPhrasesName";
                          il2cpp_internal(plVar1 + 5,lVar2);
                          if (("TWPhrasesOther" != 0) &&
                             (lVar2 = il2cpp_internal("TWPhrasesOther",*(uint64 *)(*plVar1 + 64)),
                             lVar2 == null)) {
                            uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                            FUN_1800d65f0(uVar3,0);
                          }
                          lVar2 = "TWPhrasesOther";
                          if (*(uint32 *)(plVar1 + 3) < 3) {
                            uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                            FUN_1800d65f0(uVar3,0);
                          }
                          plVar1[6] = "TWPhrasesOther";
                          il2cpp_internal(plVar1 + 6,lVar2);
                          uVar3 = ZhDictionary.LoadDictionaryReversed(plVar1,0);
                          ZhDictionary.<TWPhrasesRev>k.BackingField = uVar3;
                          plVar1 = (int64 *)FUN_1800d60b0(DAT_181da5cf8,1);
                          if (plVar1 != (int64 *)0) {
                            if (("HKVariants" != 0) &&
                               (lVar2 = il2cpp_internal("HKVariants",*(uint64 *)(*plVar1 + 64))
                               , lVar2 == null)) {
                              uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                              FUN_1800d65f0(uVar3,0);
                            }
                            lVar2 = "HKVariants";
                            if ((int)plVar1[3] == 0) {
                              uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                              FUN_1800d65f0(uVar3,0);
                            }
                            plVar1[4] = "HKVariants";
                            il2cpp_internal(plVar1 + 4,lVar2);
                            uVar3 = ZhDictionary.LoadDictionary(plVar1,0);
                            ZhDictionary.<HKVariants>k.BackingField = uVar3;
                            plVar1 = (int64 *)FUN_1800d60b0(DAT_181da5cf8,1);
                            if (plVar1 != (int64 *)0) {
                              if (("HKVariants" != 0) &&
                                 (lVar2 = il2cpp_internal("HKVariants",
                                                              *(uint64 *)(*plVar1 + 64)), lVar2 == null
                                 )) {
                                uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                FUN_1800d65f0(uVar3,0);
                              }
                              lVar2 = "HKVariants";
                              if ((int)plVar1[3] == 0) {
                                uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                FUN_1800d65f0(uVar3,0);
                              }
                              plVar1[4] = "HKVariants";
                              il2cpp_internal(plVar1 + 4,lVar2);
                              uVar3 = ZhDictionary.LoadDictionaryReversed(plVar1,0);
                              ZhDictionary.<HKVariantsRev>k.BackingField = uVar3;
                              plVar1 = (int64 *)FUN_1800d60b0(DAT_181da5cf8,1);
                              if (plVar1 != (int64 *)0) {
                                if (("HKVariantsRevPhrases" != 0) &&
                                   (lVar2 = il2cpp_internal("HKVariantsRevPhrases",
                                                                *(uint64 *)(*plVar1 + 64)),
                                   lVar2 == null)) {
                                  uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                  FUN_1800d65f0(uVar3,0);
                                }
                                lVar2 = "HKVariantsRevPhrases";
                                if ((int)plVar1[3] == 0) {
                                  uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                  FUN_1800d65f0(uVar3,0);
                                }
                                plVar1[4] = "HKVariantsRevPhrases";
                                il2cpp_internal(plVar1 + 4,lVar2);
                                uVar3 = ZhDictionary.LoadDictionary(plVar1,0);
                                ZhDictionary.<HKVariantsRevPhrases>k.BackingField = uVar3;
                                plVar1 = (int64 *)FUN_1800d60b0(DAT_181da5cf8,1);
                                if (plVar1 != (int64 *)0) {
                                  if (("JPVariants" != 0) &&
                                     (lVar2 = il2cpp_internal("JPVariants",
                                                                  *(uint64 *)(*plVar1 + 64)),
                                     lVar2 == null)) {
                                    uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                    FUN_1800d65f0(uVar3,0);
                                  }
                                  lVar2 = "JPVariants";
                                  if ((int)plVar1[3] == 0) {
                                    uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                    FUN_1800d65f0(uVar3,0);
                                  }
                                  plVar1[4] = "JPVariants";
                                  il2cpp_internal(plVar1 + 4,lVar2);
                                  uVar3 = ZhDictionary.LoadDictionary(plVar1,0);
                                  ZhDictionary.<JPVariants>k.BackingField = uVar3;
                                  plVar1 = (int64 *)FUN_1800d60b0(DAT_181da5cf8,1);
                                  if (plVar1 != (int64 *)0) {
                                    if (("JPVariants" != 0) &&
                                       (lVar2 = il2cpp_internal("JPVariants",
                                                                    *(uint64 *)(*plVar1 + 64)),
                                       lVar2 == null)) {
                                      uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                      FUN_1800d65f0(uVar3,0);
                                    }
                                    lVar2 = "JPVariants";
                                    if ((int)plVar1[3] == 0) {
                                      uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                      FUN_1800d65f0(uVar3,0);
                                    }
                                    plVar1[4] = "JPVariants";
                                    il2cpp_internal(plVar1 + 4,lVar2);
                                    uVar3 = ZhDictionary.LoadDictionaryReversed(plVar1,0);
                                    ZhDictionary.<JPVariantsRev>k.BackingField = uVar3;
                                    plVar1 = (int64 *)FUN_1800d60b0(DAT_181da5cf8,1);
                                    if (plVar1 != (int64 *)0) {
                                      if (("JPShinjitaiCharacters" != 0) &&
                                         (lVar2 = il2cpp_internal("JPShinjitaiCharacters",
                                                                      *(uint64 *)(*plVar1 + 64)),
                                         lVar2 == null)) {
                                        uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                        FUN_1800d65f0(uVar3,0);
                                      }
                                      lVar2 = "JPShinjitaiCharacters";
                                      if ((int)plVar1[3] == 0) {
                                        uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                        FUN_1800d65f0(uVar3,0);
                                      }
                                      plVar1[4] = "JPShinjitaiCharacters";
                                      il2cpp_internal(plVar1 + 4,lVar2);
                                      uVar3 = ZhDictionary.LoadDictionary(plVar1,0);
                                      ZhDictionary.<JPShinjitaiCharacters>k.BackingField = uVar3;
                                      plVar1 = (int64 *)FUN_1800d60b0(DAT_181da5cf8,1);
                                      if (plVar1 != (int64 *)0) {
                                        if (("JPShinjitaiPhrases" != 0) &&
                                           (lVar2 = il2cpp_internal("JPShinjitaiPhrases",
                                                                        *(uint64 *)(*plVar1 + 64)),
                                           lVar2 == null)) {
                                          uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                          FUN_1800d65f0(uVar3,0);
                                        }
                                        lVar2 = "JPShinjitaiPhrases";
                                        if ((int)plVar1[3] == 0) {
                                          uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                          FUN_1800d65f0(uVar3,0);
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

    // Token : 0x600261F
    // RVA   : 0x1845F40   Offset: 0x1845340   Length: 0x110
    private static IDictionary<string, string> LoadDictionary(string[] dictionaryNames)
    {
        ulong uVar1;
        long lVar2;
        lVar2 = ZhDictionary.<STCharacters>k.BackingField;
        if (lVar2 == null) {
          uVar1 = **(uint64 **)(DAT_181d93640 + 184);
          lVar2 = new OnTooltipCB(uVar1,DAT_181dbaf68,DAT_181d98a40);
          ZhDictionary.<STCharacters>k.BackingField = lVar2;
        }
        ZhDictionary.LoadDictionaryInternal(dictionaryNames,lVar2,0);
    }

    // Token : 0x6002620
    // RVA   : 0x1845E30   Offset: 0x1845230   Length: 0x110
    private static IDictionary<string, string> LoadDictionaryReversed(string[] dictionaryNames)
    {
        ulong uVar1;
        long lVar2;
        lVar2 = ZhDictionary.<STPhrases>k.BackingField;
        if (lVar2 == null) {
          uVar1 = **(uint64 **)(DAT_181d93640 + 184);
          lVar2 = new OnTooltipCB(uVar1,DAT_181dbb078,DAT_181d98a40);
          ZhDictionary.<STPhrases>k.BackingField = lVar2;
        }
        ZhDictionary.LoadDictionaryInternal(dictionaryNames,lVar2,0);
    }

    // Token : 0x6002621
    // RVA   : 0x1845880   Offset: 0x1844C80   Length: 0x5AB
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
        cVar1 = FUN_180d75bc0(**(uint64 **)(DAT_181d918c8 + 184),0);
        if (cVar1) {
          uVar2 = il2cpp_runtime_class_init(&DAT_181d819b0);
          uVar2 = il2cpp_internal(uVar2);
          uVar7 = il2cpp_internal(&"字典目录未初始化，请先调用Initialize方法");
          InvalidOperationException.ctor(uVar2,uVar7,0);
          uVar7 = il2cpp_runtime_class_init(&DAT_181dba448);
                          // WARNING: Subroutine does not return
          FUN_1800d65f0(uVar2,uVar7);
        }
        uVar2 = il2cpp_internal(DAT_181d83380);
        FUN_1808b1490(uVar2,10000,DAT_181d758b8);
        lVar3 = ZhDictionary.<TSCharacters>k.BackingField;
        if (lVar3 == null) {
          uVar7 = **(uint64 **)(DAT_181d93640 + 184);
          lVar3 = new OnTooltipCB(uVar7,DAT_181dbaff0,DAT_181db2d90);
          ZhDictionary.<TSCharacters>k.BackingField = lVar3;
        }
        plVar9 = (int64 *)FUN_180970bf0(dictionaryNames,lVar3,DAT_181db41c8);
        if (plVar9 == (int64 *)0) {
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
        lVar3 = *plVar9;
        uVar11 = 0;
        if (*(uint16 *)(lVar3 + 0x12a) != 0) {
          uVar8 = uVar11;
          do {
            if (*(int64 *)(*(int64 *)(lVar3 + 176) + (uint64)uVar8 * 16) == DAT_181d8cc78) {
              puVar4 = (uint64 *)
                       ((int64)*(int *)(*(int64 *)(lVar3 + 176) + 8 + (uint64)uVar8 * 16) *
                        16 + 0x138 + lVar3);
              goto LAB_181845aac;
            }
            uVar8 = uVar8 + 1;
          } while (uVar8 < *(uint16 *)(lVar3 + 0x12a));
        }
        puVar4 = (uint64 *)FUN_1800914f0(plVar9,DAT_181d8cc78,0);
        LAB_181845aac:
        plVar9 = (int64 *)(*(code *)*puVar4)(plVar9,puVar4[1]);
        do {
          if (plVar9 == (int64 *)0) {
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          lVar3 = *plVar9;
          if (*(uint16 *)(lVar3 + 0x12a) != 0) {
            uVar8 = uVar11;
            do {
              if (*(int64 *)(*(int64 *)(lVar3 + 176) + (uint64)uVar8 * 16) == DAT_181d79638) {
                puVar4 = (uint64 *)
                         ((int64)*(int *)(*(int64 *)(lVar3 + 176) + 8 + (uint64)uVar8 * 16) *
                          16 + 0x138 + lVar3);
                goto LAB_181845b19;
              }
              uVar8 = uVar8 + 1;
            } while (uVar8 < *(uint16 *)(lVar3 + 0x12a));
          }
          puVar4 = (uint64 *)FUN_1800914f0(plVar9,DAT_181d79638,0);
        LAB_181845b19:
          cVar1 = (*(code *)*puVar4)(plVar9,puVar4[1]);
          if (!cVar1) {
            FUN_180002970(0,DAT_181d78db8,plVar9);
            return uVar2;
          }
          lVar3 = *plVar9;
          if (*(uint16 *)(lVar3 + 0x12a) != 0) {
            uVar8 = uVar11;
            do {
              if (*(int64 *)(*(int64 *)(lVar3 + 176) + (uint64)uVar8 * 16) == DAT_181d8dff8) {
                puVar4 = (uint64 *)
                         ((int64)*(int *)(*(int64 *)(lVar3 + 176) + 8 + (uint64)uVar8 * 16) *
                          16 + 0x138 + lVar3);
                goto LAB_181845b79;
              }
              uVar8 = uVar8 + 1;
            } while (uVar8 < *(uint16 *)(lVar3 + 0x12a));
          }
          puVar4 = (uint64 *)FUN_1800914f0(plVar9,DAT_181d8dff8,0);
        LAB_181845b79:
          uVar5 = (*(code *)*puVar4)(plVar9,puVar4[1]);
          uVar7 = uVar5;
          cVar1 = File.Exists(uVar5,0);
          if (!cVar1) {
            uVar2 = il2cpp_internal(&"找不到字典文件：");
            uVar2 = String.Concat(uVar2,uVar5,0);
            uVar7 = il2cpp_runtime_class_init(&DAT_181dc7388);
            uVar7 = il2cpp_internal(uVar7);
            FileNotFoundException.ctor(uVar7,uVar2,0);
            uVar2 = il2cpp_runtime_class_init(&DAT_181dba448);
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar7,uVar2);
          }
          lVar3 = File.ReadAllLines(uVar5,0);
          uVar10 = 0;
          while( true ) {
            if (lVar3 == null) {
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            if ((int)*(uint32 *)(lVar3 + 24) <= (int)uVar10) break;
            if (*(uint32 *)(lVar3 + 24) <= uVar10) {
              uVar2 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar2,0);
            }
            lVar6 = lVar3[uVar10];
            cVar1 = String.IsNullOrWhiteSpace(lVar6);
            if (!cVar1) {
              if (lVar6 == null) {
                          // WARNING: Subroutine does not return
                FUN_1800d6620();
              }
              lVar6 = String.Split(lVar6,0,1,0,uVar7);
              if (lVar6 == null) {
                          // WARNING: Subroutine does not return
                FUN_1800d6620();
              }
              if (1 < *(int *)(lVar6 + 24)) {
                if (processLine == null) {
                          // WARNING: Subroutine does not return
                  FUN_1800d6620();
                }
                ObjectDelegate.Invoke(processLine,lVar6,uVar2);
              }
            }
            uVar10 = uVar10 + 1;
          }
        } while( true );
    }

}
