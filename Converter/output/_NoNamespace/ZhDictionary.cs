// ============================================================
// Type  : ZhDictionary
// Token : 0x2000429
// ============================================================

public class ZhDictionary
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001FA2
    private static string _dictionaryDirectory;

    // Token: 0x4001FA3
    private static IDictionary<string, string> <STCharacters>k__BackingField;

    // Token: 0x4001FA4
    private static IDictionary<string, string> <STPhrases>k__BackingField;

    // Token: 0x4001FA5
    private static IDictionary<string, string> <TSCharacters>k__BackingField;

    // Token: 0x4001FA6
    private static IDictionary<string, string> <TSPhrases>k__BackingField;

    // Token: 0x4001FA7
    private static IDictionary<string, string> <TWVariants>k__BackingField;

    // Token: 0x4001FA8
    private static IDictionary<string, string> <TWPhrases>k__BackingField;

    // Token: 0x4001FA9
    private static IDictionary<string, string> <TWVariantsRev>k__BackingField;

    // Token: 0x4001FAA
    private static IDictionary<string, string> <TWVariantsRevPhrases>k__BackingField;

    // Token: 0x4001FAB
    private static IDictionary<string, string> <TWPhrasesRev>k__BackingField;

    // Token: 0x4001FAC
    private static IDictionary<string, string> <HKVariants>k__BackingField;

    // Token: 0x4001FAD
    private static IDictionary<string, string> <HKVariantsRev>k__BackingField;

    // Token: 0x4001FAE
    private static IDictionary<string, string> <HKVariantsRevPhrases>k__BackingField;

    // Token: 0x4001FAF
    private static IDictionary<string, string> <JPVariants>k__BackingField;

    // Token: 0x4001FB0
    private static IDictionary<string, string> <JPVariantsRev>k__BackingField;

    // Token: 0x4001FB1
    private static IDictionary<string, string> <JPShinjitaiCharacters>k__BackingField;

    // Token: 0x4001FB2
    private static IDictionary<string, string> <JPShinjitaiPhrases>k__BackingField;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x600257B
    // RVA   : 0xB1A130   Offset: 0xB18930   Length: 0x37
    public static IDictionary<string, string> get_STCharacters()
    {
        return *(uint64 *)(*(int64 *)(DAT_181d6c508 + 184) + 8);
    }

    // Token : 0x600257C
    // RVA   : 0xB1A5A0   Offset: 0xB18DA0   Length: 0x47
    public static void set_STCharacters(IDictionary<string, string> value)
    {
        puVar1 = (uint64 *)(*(int64 *)(DAT_181d6c508 + 184) + 8);
        *puVar1 = value;
        il2cpp_internal(puVar1,value);
    }

    // Token : 0x600257D
    // RVA   : 0xB1A170   Offset: 0xB18970   Length: 0x37
    public static IDictionary<string, string> get_STPhrases()
    {
        return *(uint64 *)(*(int64 *)(DAT_181d6c508 + 184) + 16);
    }

    // Token : 0x600257E
    // RVA   : 0xB1A5F0   Offset: 0xB18DF0   Length: 0x47
    public static void set_STPhrases(IDictionary<string, string> value)
    {
        puVar1 = (uint64 *)(*(int64 *)(DAT_181d6c508 + 184) + 16);
        *puVar1 = value;
        il2cpp_internal(puVar1,value);
    }

    // Token : 0x600257F
    // RVA   : 0xB1A1B0   Offset: 0xB189B0   Length: 0x37
    public static IDictionary<string, string> get_TSCharacters()
    {
        return *(uint64 *)(*(int64 *)(DAT_181d6c508 + 184) + 24);
    }

    // Token : 0x6002580
    // RVA   : 0xB1A640   Offset: 0xB18E40   Length: 0x47
    public static void set_TSCharacters(IDictionary<string, string> value)
    {
        puVar1 = (uint64 *)(*(int64 *)(DAT_181d6c508 + 184) + 24);
        *puVar1 = value;
        il2cpp_internal(puVar1,value);
    }

    // Token : 0x6002581
    // RVA   : 0xB1A1F0   Offset: 0xB189F0   Length: 0x37
    public static IDictionary<string, string> get_TSPhrases()
    {
        return *(uint64 *)(*(int64 *)(DAT_181d6c508 + 184) + 32);
    }

    // Token : 0x6002582
    // RVA   : 0xB1A690   Offset: 0xB18E90   Length: 0x47
    public static void set_TSPhrases(IDictionary<string, string> value)
    {
        puVar1 = (uint64 *)(*(int64 *)(DAT_181d6c508 + 184) + 32);
        *puVar1 = value;
        il2cpp_internal(puVar1,value);
    }

    // Token : 0x6002583
    // RVA   : 0xB1A330   Offset: 0xB18B30   Length: 0x37
    public static IDictionary<string, string> get_TWVariants()
    {
        return *(uint64 *)(*(int64 *)(DAT_181d6c508 + 184) + 40);
    }

    // Token : 0x6002584
    // RVA   : 0xB1A820   Offset: 0xB19020   Length: 0x47
    public static void set_TWVariants(IDictionary<string, string> value)
    {
        puVar1 = (uint64 *)(*(int64 *)(DAT_181d6c508 + 184) + 40);
        *puVar1 = value;
        il2cpp_internal(puVar1,value);
    }

    // Token : 0x6002585
    // RVA   : 0xB1A270   Offset: 0xB18A70   Length: 0x37
    public static IDictionary<string, string> get_TWPhrases()
    {
        return *(uint64 *)(*(int64 *)(DAT_181d6c508 + 184) + 48);
    }

    // Token : 0x6002586
    // RVA   : 0xB1A730   Offset: 0xB18F30   Length: 0x47
    public static void set_TWPhrases(IDictionary<string, string> value)
    {
        puVar1 = (uint64 *)(*(int64 *)(DAT_181d6c508 + 184) + 48);
        *puVar1 = value;
        il2cpp_internal(puVar1,value);
    }

    // Token : 0x6002587
    // RVA   : 0xB1A2F0   Offset: 0xB18AF0   Length: 0x37
    public static IDictionary<string, string> get_TWVariantsRev()
    {
        return *(uint64 *)(*(int64 *)(DAT_181d6c508 + 184) + 56);
    }

    // Token : 0x6002588
    // RVA   : 0xB1A7D0   Offset: 0xB18FD0   Length: 0x47
    public static void set_TWVariantsRev(IDictionary<string, string> value)
    {
        puVar1 = (uint64 *)(*(int64 *)(DAT_181d6c508 + 184) + 56);
        *puVar1 = value;
        il2cpp_internal(puVar1,value);
    }

    // Token : 0x6002589
    // RVA   : 0xB1A2B0   Offset: 0xB18AB0   Length: 0x37
    public static IDictionary<string, string> get_TWVariantsRevPhrases()
    {
        return *(uint64 *)(*(int64 *)(DAT_181d6c508 + 184) + 64);
    }

    // Token : 0x600258A
    // RVA   : 0xB1A780   Offset: 0xB18F80   Length: 0x47
    public static void set_TWVariantsRevPhrases(IDictionary<string, string> value)
    {
        puVar1 = (uint64 *)(*(int64 *)(DAT_181d6c508 + 184) + 64);
        *puVar1 = value;
        il2cpp_internal(puVar1,value);
    }

    // Token : 0x600258B
    // RVA   : 0xB1A230   Offset: 0xB18A30   Length: 0x37
    public static IDictionary<string, string> get_TWPhrasesRev()
    {
        return *(uint64 *)(*(int64 *)(DAT_181d6c508 + 184) + 72);
    }

    // Token : 0x600258C
    // RVA   : 0xB1A6E0   Offset: 0xB18EE0   Length: 0x47
    public static void set_TWPhrasesRev(IDictionary<string, string> value)
    {
        puVar1 = (uint64 *)(*(int64 *)(DAT_181d6c508 + 184) + 72);
        *puVar1 = value;
        il2cpp_internal(puVar1,value);
    }

    // Token : 0x600258D
    // RVA   : 0xB19FF0   Offset: 0xB187F0   Length: 0x37
    public static IDictionary<string, string> get_HKVariants()
    {
        return *(uint64 *)(*(int64 *)(DAT_181d6c508 + 184) + 80);
    }

    // Token : 0x600258E
    // RVA   : 0xB1A410   Offset: 0xB18C10   Length: 0x47
    public static void set_HKVariants(IDictionary<string, string> value)
    {
        puVar1 = (uint64 *)(*(int64 *)(DAT_181d6c508 + 184) + 80);
        *puVar1 = value;
        il2cpp_internal(puVar1,value);
    }

    // Token : 0x600258F
    // RVA   : 0xB19FB0   Offset: 0xB187B0   Length: 0x37
    public static IDictionary<string, string> get_HKVariantsRev()
    {
        return *(uint64 *)(*(int64 *)(DAT_181d6c508 + 184) + 88);
    }

    // Token : 0x6002590
    // RVA   : 0xB1A3C0   Offset: 0xB18BC0   Length: 0x47
    public static void set_HKVariantsRev(IDictionary<string, string> value)
    {
        puVar1 = (uint64 *)(*(int64 *)(DAT_181d6c508 + 184) + 88);
        *puVar1 = value;
        il2cpp_internal(puVar1,value);
    }

    // Token : 0x6002591
    // RVA   : 0xB19F70   Offset: 0xB18770   Length: 0x37
    public static IDictionary<string, string> get_HKVariantsRevPhrases()
    {
        return *(uint64 *)(*(int64 *)(DAT_181d6c508 + 184) + 96);
    }

    // Token : 0x6002592
    // RVA   : 0xB1A370   Offset: 0xB18B70   Length: 0x47
    public static void set_HKVariantsRevPhrases(IDictionary<string, string> value)
    {
        puVar1 = (uint64 *)(*(int64 *)(DAT_181d6c508 + 184) + 96);
        *puVar1 = value;
        il2cpp_internal(puVar1,value);
    }

    // Token : 0x6002593
    // RVA   : 0xB1A0F0   Offset: 0xB188F0   Length: 0x37
    public static IDictionary<string, string> get_JPVariants()
    {
        return *(uint64 *)(*(int64 *)(DAT_181d6c508 + 184) + 104);
    }

    // Token : 0x6002594
    // RVA   : 0xB1A550   Offset: 0xB18D50   Length: 0x47
    public static void set_JPVariants(IDictionary<string, string> value)
    {
        puVar1 = (uint64 *)(*(int64 *)(DAT_181d6c508 + 184) + 104);
        *puVar1 = value;
        il2cpp_internal(puVar1,value);
    }

    // Token : 0x6002595
    // RVA   : 0xB1A0B0   Offset: 0xB188B0   Length: 0x37
    public static IDictionary<string, string> get_JPVariantsRev()
    {
        return *(uint64 *)(*(int64 *)(DAT_181d6c508 + 184) + 112);
    }

    // Token : 0x6002596
    // RVA   : 0xB1A500   Offset: 0xB18D00   Length: 0x47
    public static void set_JPVariantsRev(IDictionary<string, string> value)
    {
        puVar1 = (uint64 *)(*(int64 *)(DAT_181d6c508 + 184) + 112);
        *puVar1 = value;
        il2cpp_internal(puVar1,value);
    }

    // Token : 0x6002597
    // RVA   : 0xB1A030   Offset: 0xB18830   Length: 0x37
    public static IDictionary<string, string> get_JPShinjitaiCharacters()
    {
        return *(uint64 *)(*(int64 *)(DAT_181d6c508 + 184) + 120);
    }

    // Token : 0x6002598
    // RVA   : 0xB1A460   Offset: 0xB18C60   Length: 0x47
    public static void set_JPShinjitaiCharacters(IDictionary<string, string> value)
    {
        puVar1 = (uint64 *)(*(int64 *)(DAT_181d6c508 + 184) + 120);
        *puVar1 = value;
        il2cpp_internal(puVar1,value);
    }

    // Token : 0x6002599
    // RVA   : 0xB1A070   Offset: 0xB18870   Length: 0x3A
    public static IDictionary<string, string> get_JPShinjitaiPhrases()
    {
        return *(uint64 *)(*(int64 *)(DAT_181d6c508 + 184) + 128);
    }

    // Token : 0x600259A
    // RVA   : 0xB1A4B0   Offset: 0xB18CB0   Length: 0x47
    public static void set_JPShinjitaiPhrases(IDictionary<string, string> value)
    {
        puVar1 = (uint64 *)(*(int64 *)(DAT_181d6c508 + 184) + 128);
        *puVar1 = value;
        il2cpp_internal(puVar1,value);
    }

    // Token : 0x600259B
    // RVA   : 0xB18950   Offset: 0xB17150   Length: 0xF00
    public static void Initialize(string dictionaryDirectory)
    {
        var pStatics = *(int64*)(DAT_181d6c508 + 184);
        long lVar2;
        ulong uVar3;
        puVar4 = *(uint64 **)(DAT_181d6c508 + 184);
        *puVar4 = dictionaryDirectory;
        il2cpp_internal(puVar4,dictionaryDirectory);
        plVar1 = (int64 *)FUN_1800d60b0(DAT_181d80cc0,1);
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
          puVar4 = (uint64 *)(pStatics + 8);
          *puVar4 = uVar3;
          il2cpp_internal(puVar4,uVar3);
          plVar1 = (int64 *)FUN_1800d60b0(DAT_181d80cc0,1);
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
            puVar4 = (uint64 *)(pStatics + 16);
            *puVar4 = uVar3;
            il2cpp_internal(puVar4,uVar3);
            plVar1 = (int64 *)FUN_1800d60b0(DAT_181d80cc0,1);
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
              puVar4 = (uint64 *)(pStatics + 24);
              *puVar4 = uVar3;
              il2cpp_internal(puVar4,uVar3);
              plVar1 = (int64 *)FUN_1800d60b0(DAT_181d80cc0,1);
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
                puVar4 = (uint64 *)(pStatics + 32);
                *puVar4 = uVar3;
                il2cpp_internal(puVar4,uVar3);
                plVar1 = (int64 *)FUN_1800d60b0(DAT_181d80cc0,1);
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
                  puVar4 = (uint64 *)(pStatics + 40);
                  *puVar4 = uVar3;
                  il2cpp_internal(puVar4,uVar3);
                  plVar1 = (int64 *)FUN_1800d60b0(DAT_181d80cc0,3);
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
                    puVar4 = (uint64 *)(pStatics + 48);
                    *puVar4 = uVar3;
                    il2cpp_internal(puVar4,uVar3);
                    plVar1 = (int64 *)FUN_1800d60b0(DAT_181d80cc0,1);
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
                      puVar4 = (uint64 *)(pStatics + 56);
                      *puVar4 = uVar3;
                      il2cpp_internal(puVar4,uVar3);
                      plVar1 = (int64 *)FUN_1800d60b0(DAT_181d80cc0,1);
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
                        puVar4 = (uint64 *)(pStatics + 64);
                        *puVar4 = uVar3;
                        il2cpp_internal(puVar4,uVar3);
                        plVar1 = (int64 *)FUN_1800d60b0(DAT_181d80cc0,3);
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
                          puVar4 = (uint64 *)(pStatics + 72);
                          *puVar4 = uVar3;
                          il2cpp_internal(puVar4,uVar3);
                          plVar1 = (int64 *)FUN_1800d60b0(DAT_181d80cc0,1);
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
                            puVar4 = (uint64 *)(pStatics + 80);
                            *puVar4 = uVar3;
                            il2cpp_internal(puVar4,uVar3);
                            plVar1 = (int64 *)FUN_1800d60b0(DAT_181d80cc0,1);
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
                              puVar4 = (uint64 *)(pStatics + 88);
                              *puVar4 = uVar3;
                              il2cpp_internal(puVar4,uVar3);
                              plVar1 = (int64 *)FUN_1800d60b0(DAT_181d80cc0,1);
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
                                puVar4 = (uint64 *)(pStatics + 96);
                                *puVar4 = uVar3;
                                il2cpp_internal(puVar4,uVar3);
                                plVar1 = (int64 *)FUN_1800d60b0(DAT_181d80cc0,1);
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
                                  puVar4 = (uint64 *)(pStatics + 104);
                                  *puVar4 = uVar3;
                                  il2cpp_internal(puVar4,uVar3);
                                  plVar1 = (int64 *)FUN_1800d60b0(DAT_181d80cc0,1);
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
                                    puVar4 = (uint64 *)(pStatics + 112);
                                    *puVar4 = uVar3;
                                    il2cpp_internal(puVar4,uVar3);
                                    plVar1 = (int64 *)FUN_1800d60b0(DAT_181d80cc0,1);
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
                                      puVar4 = (uint64 *)(pStatics + 120);
                                      *puVar4 = uVar3;
                                      il2cpp_internal(puVar4,uVar3);
                                      plVar1 = (int64 *)FUN_1800d60b0(DAT_181d80cc0,1);
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

    // Token : 0x600259C
    // RVA   : 0xB19E60   Offset: 0xB18660   Length: 0x110
    private static IDictionary<string, string> LoadDictionary(string[] dictionaryNames)
    {
        var pStatics = *(int64*)(DAT_181d6e288 + 184);
        ulong uVar1;
        long lVar2;
        lVar2 = *(int64 *)(pStatics + 8);
        if (lVar2 == null) {
          uVar1 = **(uint64 **)(DAT_181d6e288 + 184);
          lVar2 = new OnTooltipCB(uVar1,DAT_181d91a50,DAT_181d73688);
          plVar3 = (int64 *)(pStatics + 8);
          *plVar3 = lVar2;
          il2cpp_internal(plVar3,lVar2);
        }
        ZhDictionary.LoadDictionaryInternal(dictionaryNames,lVar2,0);
    }

    // Token : 0x600259D
    // RVA   : 0xB19D50   Offset: 0xB18550   Length: 0x110
    private static IDictionary<string, string> LoadDictionaryReversed(string[] dictionaryNames)
    {
        var pStatics = *(int64*)(DAT_181d6e288 + 184);
        ulong uVar1;
        long lVar2;
        lVar2 = *(int64 *)(pStatics + 16);
        if (lVar2 == null) {
          uVar1 = **(uint64 **)(DAT_181d6e288 + 184);
          lVar2 = new OnTooltipCB(uVar1,DAT_181d91b60,DAT_181d73688);
          plVar3 = (int64 *)(pStatics + 16);
          *plVar3 = lVar2;
          il2cpp_internal(plVar3,lVar2);
        }
        ZhDictionary.LoadDictionaryInternal(dictionaryNames,lVar2,0);
    }

    // Token : 0x600259E
    // RVA   : 0xB19860   Offset: 0xB18060   Length: 0x4E7
    private static IDictionary<string, string> LoadDictionaryInternal(IList<string> dictionaryNames, Action<IList<string>, Dictionary<string, string>> processLine)
    {
        var pStatics = *(int64*)(DAT_181d6e288 + 184);
        bool cVar1;
        ulong uVar2;
        long lVar3;
        ulong uVar5;
        long lVar6;
        long lVar7;
        ulong uVar8;
        ushort uVar9;
        uint uVar11;
        cVar1 = FUN_180d6ca90(**(uint64 **)(DAT_181d6c508 + 184),0);
        if (cVar1) {
          uVar2 = il2cpp_runtime_class_init(&DAT_181d5c878);
          uVar2 = il2cpp_internal(uVar2);
          uVar8 = il2cpp_internal(&"字典目录未初始化，请先调用Initialize方法");
          InvalidOperationException.ctor(uVar2,uVar8,0);
          uVar8 = il2cpp_runtime_class_init(&DAT_181d90f28);
                          // WARNING: Subroutine does not return
          FUN_1800d65f0(uVar2,uVar8);
        }
        uVar2 = il2cpp_internal(DAT_181d5e848);
        FUN_1808ae510(uVar2,10000,DAT_181d4f658);
        lVar3 = *(int64 *)(pStatics + 24);
        if (lVar3 == null) {
          uVar8 = **(uint64 **)(DAT_181d6e288 + 184);
          lVar3 = new OnTooltipCB(uVar8,DAT_181d91ad8,DAT_181d8bfb0);
          plVar10 = (int64 *)(pStatics + 24);
          *plVar10 = lVar3;
          il2cpp_internal(plVar10,lVar3);
        }
        plVar10 = (int64 *)FUN_18095fc20(dictionaryNames,lVar3,DAT_181d8b538);
        if (plVar10 == (int64 *)0) {
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
        lVar3 = *plVar10;
        uVar9 = 0;
        if (*(uint16 *)(lVar3 + 0x12a) != 0) {
          do {
            if (*(int64 *)(*(int64 *)(lVar3 + 176) + (uint64)uVar9 * 16) == DAT_181d680b8) {
              puVar4 = (uint64 *)
                       ((int64)*(int *)(*(int64 *)(lVar3 + 176) + 8 + (uint64)uVar9 * 16) *
                        16 + 0x138 + lVar3);
              goto LAB_180b19a8c;
            }
            uVar9 = uVar9 + 1;
          } while (uVar9 < *(uint16 *)(lVar3 + 0x12a));
        }
        puVar4 = (uint64 *)FUN_1800914f0(plVar10,DAT_181d680b8,0);
        LAB_180b19a8c:
        lVar3 = (*(code *)*puVar4)(plVar10,puVar4[1]);
        do {
          if (lVar3 == null) {
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          cVar1 = FUN_180002970(0,DAT_181d544d8,lVar3);
          if (!cVar1) {
            FUN_180002970(0,DAT_181d53c70,lVar3);
            return uVar2;
          }
          uVar5 = FUN_180002970(0,DAT_181d69438,lVar3);
          uVar8 = uVar5;
          cVar1 = File.Exists(uVar5,0);
          if (!cVar1) {
            uVar2 = il2cpp_internal(&"找不到字典文件：");
            uVar2 = String.Concat(uVar2,uVar5,0);
            uVar8 = il2cpp_runtime_class_init(&DAT_181da20a0);
            uVar8 = il2cpp_internal(uVar8);
            FileNotFoundException.ctor(uVar8,uVar2,0);
            uVar2 = il2cpp_runtime_class_init(&DAT_181d90f28);
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar8,uVar2);
          }
          lVar6 = File.ReadAllLines(uVar5,0);
          uVar11 = 0;
          while( true ) {
            if (lVar6 == null) {
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            if ((int)*(uint32 *)(lVar6 + 24) <= (int)uVar11) break;
            if (*(uint32 *)(lVar6 + 24) <= uVar11) {
              uVar2 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar2,0);
            }
            lVar7 = lVar6[uVar11];
            cVar1 = String.IsNullOrWhiteSpace();
            if (!cVar1) {
              if (lVar7 == null) {
                          // WARNING: Subroutine does not return
                FUN_1800d6620();
              }
              lVar7 = String.Split(lVar7,0,1,0,uVar8);
              if (lVar7 == null) {
                          // WARNING: Subroutine does not return
                FUN_1800d6620();
              }
              if (1 < *(int *)(lVar7 + 24)) {
                if (processLine == null) {
                          // WARNING: Subroutine does not return
                  FUN_1800d6620();
                }
                ObjectDelegate.Invoke(processLine,lVar7,uVar2);
              }
            }
            uVar11 = uVar11 + 1;
          }
        } while( true );
    }

}
