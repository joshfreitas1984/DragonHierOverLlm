// ============================================================
// Type  : LTLocalization
// Token : 0x20002F2
// ============================================================

public class LTLocalization
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x40017A6
    public const string LANGUAGE_ENGLISH;

    // Token: 0x40017A7
    public const string LANGUAGE_CHINESE;

    // Token: 0x40017A8
    public const string LANGUAGE_TCHINESE;

    // Token: 0x40017A9
    public const string LANGUAGE_JAPANESE;

    // Token: 0x40017AA
    public const string LANGUAGE_GERMAN;

    // Token: 0x40017AB
    public const string LANGUAGE_RUSSIA;

    // Token: 0x40017AC
    public const string LANGUAGE_PORTUGUESE;

    // Token: 0x40017AD
    private const string FILE_PATH;

    // Token: 0x40017AE
    private Dictionary<string, string> textData;

    // Token: 0x40017AF
    public static LTLocalization mInstance;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6001868
    // RVA   : 0xA84150   Offset: 0xA82950   Length: 0x76
    private void /*ctor*/()
    {
        ulong uVar1;
        uVar1 = il2cpp_internal(DAT_181d5e848);
        FUN_1808ae540(uVar1,DAT_181d4f5d8);
        this.textData = uVar1;
        ZhSegment.Initialize(this,0);
    }

    // Token : 0x6001869
    // RVA   : 0xA82E40   Offset: 0xA81640   Length: 0xF0
    public static SystemLanguage GetNowSystemLanguage()
    {
        bool cVar1;
        long lVar2;
        lVar2 = *(int64 *)(*(int64 *)(DAT_181d4e010 + 184) + 8);
        if ((lVar2 != null) && (lVar2 = *(int64 *)(lVar2 + 16)) != null) {
          lVar2 = PlayerPrefDictionary.GetString(lVar2,"Language",0);
          if (lVar2 != null) {
            cVar1 = FUN_1816fd990(lVar2,"CN",0);
            if (!cVar1) {
              cVar1 = FUN_1816fd990(lVar2,"TC",0);
              if (cVar1) {
                return 41;
              }
            }
          }
          return 40;
        }
    }

    // Token : 0x600186A
    // RVA   : 0xA82DF0   Offset: 0xA815F0   Length: 0x48
    public static string GetLanguageAB(SystemLanguage language)
    {
        ulong uVar1;
        uVar1 = "CN";
        if (language == 41) {
          uVar1 = "TC";
        }
        return uVar1;
    }

    // Token : 0x600186B
    // RVA   : 0xA83910   Offset: 0xA82110   Length: 0x6FB
    private void ReadData()
    {
        var pStatics = *(int64*)(DAT_181d4e010 + 184);
        int iVar1;
        long lVar2;
        bool cVar3;
        ulong uVar4;
        long lVar6;
        ulong uVar7;
        long lVar8;
        int iVar9;
        int iVar10;
        lVar6 = *(int64 *)(pStatics + 8);
        if ((lVar6 != null) && (lVar6 = *(int64 *)(lVar6 + 16)) != null) {
          uVar4 = PlayerPrefDictionary.GetString(lVar6,"Language",0);
          cVar3 = FUN_1816fd990(uVar4,"CN",0);
          if (cVar3) {
            return;
          }
          if (this.textData != null) {
            Dictionary_2.Clear(this.textData,DAT_181d4f7d8);
            uVar4 = DAT_181d9e518;
            uVar4 = Type.GetTypeFromHandle(uVar4,0);
            plVar5 = (int64 *)Resources.Load("LTLocalization/localization",uVar4,0);
            if (plVar5 != (int64 *)0) {
              iVar10 = 0;
              uVar4 = FUN_180d9c290(plVar5,0);
              lVar6 = new ZhSegment(0);
              if (lVar6 != null) {
                uVar7 = new StringReader(uVar4,0);
                *(uint64 *)(lVar6 + 16) = uVar7;
                uVar4 = il2cpp_internal(DAT_181d6b7b0);
                FUN_180f58a90(uVar4,DAT_181d51c88);
                *(uint64 *)(lVar6 + 32) = uVar4;
                cVar3 = LTCSVLoader.readCSVNextRecord(lVar6,0);
                if (cVar3) {
                  lVar2 = *(int64 *)(lVar6 + 24);
                  while (lVar2 != null) {
                    lVar8 = il2cpp_internal(DAT_181d72a30);
                    FUN_180f58a90(lVar8,DAT_181d7c250);
                    iVar9 = 0;
                    while( true ) {
                      if (lVar2 == null) throw; // [null/range check failed]
                      if (lVar2.entries <= iVar9) break;
                      uVar4 = FUN_180002f80(lVar2,iVar9,DAT_181d7c9c0);
                      if (lVar8 == null) throw; // [null/range check failed]
                      FUN_181827900(lVar8,uVar4,DAT_181d7c3d0);
                      iVar9 = iVar9 + 1;
                    }
                    if (*(int64 *)(lVar6 + 32) == 0) throw; // [null/range check failed]
                    FUN_181827900(*(int64 *)(lVar6 + 32),lVar8,DAT_181d51d08);
                    cVar3 = LTCSVLoader.readCSVNextRecord(lVar6,0);
                    if (!cVar3) break;
                    lVar2 = *(int64 *)(lVar6 + 24);
                  }
                }

                if ((lVar2 = *(int64 *)(pStatics + 8)?.buckets) != null) {
                  uVar4 = PlayerPrefDictionary.GetString(lVar2,"Language",0);
                  iVar9 = LTCSVLoader.GetFirstIndexAtRow(lVar6,uVar4,0,0);
                  if (iVar9 == -1) {
                    lVar6 = *(int64 *)(pStatics + 8);
                    if ((lVar6 != null) && (lVar6 = *(int64 *)(lVar6 + 16)) != null) {
                      uVar4 = PlayerPrefDictionary.GetString(lVar6,"Language",0);
                      uVar4 = String.Concat("未读取到",uVar4,"任何数据，请检查配置表",0);
                      Debug.LogError(uVar4,0);
                      return;
                    }
                  }
                  else {

                    if ((lVar2 = *(int64 *)(pStatics + 8)?.buckets) != null) {
                      uVar4 = PlayerPrefDictionary.GetString(lVar2,"Language",0);
                      uVar4 = String.Concat("[Language]",uVar4,"翻译文件已读取",0);
                      Debug.Log(uVar4,0);
                      if (*(int64 *)(lVar6 + 32) == 0) {
                        uVar4 = il2cpp_runtime_class_init(&DAT_181da0308);
                        uVar4 = il2cpp_internal(uVar4);
                        uVar7 = il2cpp_internal(&"table尚未初始化,请检查是否成功读取");
                        Exception.ctor(uVar4,uVar7,0);
                        uVar7 = il2cpp_runtime_class_init(&DAT_181d5d308);
                          // WARNING: Subroutine does not return
                        FUN_1800d65f0(uVar4,uVar7);
                      }
                      iVar1 = *(int *)(*(int64 *)(lVar6 + 32) + 24);
                      if (0 < iVar1) {
                        do {
                          lVar2 = this.textData;
                          uVar4 = LTCSVLoader.GetValueAt(lVar6,0,iVar10,0);
                          if (lVar2 == null) throw; // [null/range check failed]
                          cVar3 = FUN_1808ab750(lVar2,uVar4,DAT_181d4f858);
                          if (!cVar3) {
                            lVar2 = this.textData;
                            uVar4 = LTCSVLoader.GetValueAt(lVar6,0,iVar10,0);
                            uVar7 = LTCSVLoader.GetValueAt(lVar6,iVar9,iVar10,0);
                            if (lVar2 == null) throw; // [null/range check failed]
                            FUN_1808ab680(lVar2,uVar4,uVar7);
                          }
                          else {
                            uVar4 = LTCSVLoader.GetValueAt(lVar6,0,iVar10,0);
                            uVar4 = String.Concat("重复key",uVar4,0);
                            Debug.LogWarning(uVar4);
                          }
                          iVar10 = iVar10 + 1;
                        } while (iVar10 < iVar1);
                      }
                      return;
                    }
                  }
                }
              }
            }
          }
        }
    }

    // Token : 0x600186C
    // RVA   : 0xA84010   Offset: 0xA82810   Length: 0xE4
    private void SetLanguage(SystemLanguage language)
    {
        long lVar1;
        ulong uVar2;
        lVar1 = *(int64 *)(*(int64 *)(DAT_181d4e010 + 184) + 8);
        if (lVar1 != null) {
          lVar1 = *(int64 *)(lVar1 + 16);
          uVar2 = "CN";
          if (((language != 6) && (language != 40)) && (language == 41)) {
            uVar2 = "TC";
          }
          if (lVar1 != null) {
            PlayerPrefDictionary.SetKey(lVar1,"Language",uVar2,0);
            return;
          }
        }
    }

    // Token : 0x600186D
    // RVA   : 0xA834C0   Offset: 0xA81CC0   Length: 0x2B1
    public static void Init()
    {
        var pStatics_e010 = *(int64*)(DAT_181d4e010 + 184);
        var pStatics_f6f8 = *(int64*)(DAT_181d5f6f8 + 184);
        bool cVar2;
        int iVar3;
        uint uVar4;
        ulong uVar5;
        long lVar6;
        uVar5 = new LTLocalization(0);
        puVar1 = *(uint64 **)(DAT_181d5f6f8 + 184);
        *puVar1 = uVar5;
        il2cpp_internal(puVar1,uVar5);
        if (**(int **)(DAT_181d4ef00 + 184) == 2) {
          lVar6 = *pStatics_f6f8;
          if (lVar6 == null) throw; // [null/range check failed]
          uVar4 = 40;
        LAB_180a8370b:
          LTLocalization.SetLanguage(lVar6,uVar4,0);
        }
        else {
          lVar6 = *(int64 *)(pStatics_e010 + 8);
          if ((lVar6 == null) || (lVar6 = *(int64 *)(lVar6 + 16)) == null) throw; // [null/range check failed]
          cVar2 = PlayerPrefDictionary.ContainsKey(lVar6,"Language",0);
          if (!cVar2) {
            iVar3 = Application.get_systemLanguage(0);
            if (iVar3 != 42) {
              lVar6 = *pStatics_f6f8;
              uVar4 = Application.get_systemLanguage(0);
              if (lVar6 == null) throw; // [null/range check failed]
              goto LAB_180a8370b;
            }
            if (*pStatics_f6f8 == 0) throw; // [null/range check failed]
            lVar6 = *(int64 *)(pStatics_e010 + 8);
            if (lVar6 == null) throw; // [null/range check failed]
            lVar6 = *(int64 *)(lVar6 + 16);
            if (lVar6 == null) throw; // [null/range check failed]
            PlayerPrefDictionary.SetKey(lVar6,"Language","CN",0);
          }
        }
        if (*pStatics_f6f8 != 0) {
          LTLocalization.ReadData(*pStatics_f6f8,0);
          ZhConverter.Initialize("Dictionary","JiebaResource",0,0);
          return;
        }
    }

    // Token : 0x600186E
    // RVA   : 0xA83780   Offset: 0xA81F80   Length: 0x184
    public static void ManualSetLanguage(SystemLanguage setLanguage)
    {
        var pStatics = *(int64*)(DAT_181d5f6f8 + 184);
        long lVar2;
        bool cVar3;
        ulong uVar4;
        ulong uVar5;
        if (*pStatics == 0) {
          uVar4 = il2cpp_internal();
          LTLocalization.ctor(uVar4,0);
          puVar1 = *(uint64 **)(DAT_181d5f6f8 + 184);
          *puVar1 = uVar4;
          il2cpp_internal(puVar1,uVar4);
        }
        lVar2 = *(int64 *)(*(int64 *)(DAT_181d4e010 + 184) + 8);
        if ((lVar2 != null) && (lVar2 = *(int64 *)(lVar2 + 16)) != null) {
          uVar4 = PlayerPrefDictionary.GetString(lVar2,"Language",0);
          uVar5 = "CN";
          if (((setLanguage != 6) && (setLanguage != 40)) && (setLanguage == 41)) {
            uVar5 = "TC";
          }
          cVar3 = String.op_Inequality(uVar4,uVar5,0);
          if (!cVar3) {
            return;
          }
          if (*pStatics != 0) {
            LTLocalization.SetLanguage(*pStatics,setLanguage,0);
            if (*pStatics != 0) {
              LTLocalization.ReadData(*pStatics,0);
              return;
            }
          }
        }
    }

    // Token : 0x600186F
    // RVA   : 0xA84100   Offset: 0xA82900   Length: 0x4C
    public static void SetText(Text targetText, string targetValue)
    {
        ulong uVar1;
        uVar1 = LTLocalization.GetText(targetValue,0,1,0);
        if (targetText != (int64 *)0) {
          (**(code **)(*targetText + 0x5e8))(targetText,uVar1,*(uint64 *)(*targetText + 0x5f0));
          LTLocalization.CheckTextFont(targetText,0);
          return;
        }
    }

    // Token : 0x6001870
    // RVA   : 0xA82A80   Offset: 0xA81280   Length: 0x76
    public static void AddText(Text targetText, string targetValue)
    {
        ulong uVar1;
        ulong uVar2;
        if (targetText != (int64 *)0) {
          uVar1 = (**(code **)(*targetText + 0x5d8))(targetText,*(uint64 *)(*targetText + 0x5e0));
          uVar2 = LTLocalization.GetText(targetValue,0,1,0);
          uVar1 = String.Concat(uVar1,uVar2,0);
                          // WARNING: Could not recover jumptable at 0x000180a82aea. Too many branches
                          // WARNING: Treating indirect jump as call
          (**(code **)(*targetText + 0x5e8))(targetText,uVar1,*(uint64 *)(*targetText + 0x5f0));
          return;
        }
    }

    // Token : 0x6001871
    // RVA   : 0xA82B00   Offset: 0xA81300   Length: 0x2EA
    public static void CheckTextFont(Text targetText)
    {
        var pStatics = *(int64*)(DAT_181d4ef00 + 184);
        bool cVar1;
        ulong uVar2;
        long lVar3;
        ulong uVar4;
        int iVar5;
        float fVar6;
        if (targetText != (int64 *)0) {
          uVar2 = (**(code **)(*targetText + 0x5d8))(targetText,*(uint64 *)(*targetText + 0x5e0));
          cVar1 = FUN_180d6ca90(uVar2,0);
          if (cVar1) {
            return;
          }
          lVar3 = *(int64 *)(*(int64 *)(DAT_181d4e010 + 184) + 8);
          if ((lVar3 != null) && (lVar3 = *(int64 *)(lVar3 + 16)) != null) {
            uVar2 = PlayerPrefDictionary.GetString(lVar3,"Language",0);
            cVar1 = FUN_1816fd990(uVar2,"TC",0);
            if (!cVar1) {
              return;
            }
            iVar5 = 0;
            while( true ) {
              lVar3 = *(int64 *)(pStatics + 224);
              if (lVar3 == null) throw; // [null/range check failed]
              if (*(int *)(lVar3 + 24) <= iVar5) {
                return;
              }
              lVar3 = *(int64 *)(pStatics + 224);
              if ((lVar3 == null) || (lVar3 = FUN_180002f80(lVar3,iVar5,DAT_181d51e08)) == null)
              throw; // [null/range check failed]
              if (*(int *)(lVar3 + 24) == 0) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              uVar2 = *(uint64 *)(*(int64 *)(lVar3 + 16) + 32);
              lVar3 = Text.get_font(targetText,0);
              if (lVar3 == null) throw; // [null/range check failed]
              uVar4 = Object.get_name(lVar3,0);
              cVar1 = FUN_1816fd990(uVar2,uVar4,0);
              if (cVar1) break;
              iVar5 = iVar5 + 1;
            }
            lVar3 = *(int64 *)(pStatics + 224);
            if ((lVar3 != null) && (lVar3 = FUN_180002f80(lVar3,iVar5,DAT_181d51e08)) != null) {
              if (*(uint32 *)(lVar3 + 24) < 2) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              uVar2 = String.Concat("Font/",*(uint64 *)(*(int64 *)(lVar3 + 16) + 40),0);
              uVar2 = Resources.Load(uVar2,DAT_181d77160);
              Text.set_font(targetText,uVar2,0);
              fVar6 = (float)Text.get_lineSpacing(targetText,0);
              Text.set_lineSpacing(targetText,fVar6 * 0.8,0);
              return;
            }
          }
        }
    }

    // Token : 0x6001872
    // RVA   : 0xA82F40   Offset: 0xA81740   Length: 0x104
    public static List<string> GetTextList(List<string> keyList, bool justReplace)
    {
        long lVar1;
        ulong uVar2;
        uint uVar3;
        long lVar4;
        lVar1 = il2cpp_internal(DAT_181d72a30);
        FUN_180f58a90(lVar1,DAT_181d7c250);
        uVar3 = 0;
        if (keyList != null) {
          lVar4 = 32;
          while( true ) {
            if ((int)*(uint32 *)(keyList + 24) <= (int)uVar3) {
              return lVar1;
            }
            if (*(uint32 *)(keyList + 24) <= uVar3) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            uVar2 = LTLocalization.GetText
                              (*(uint64 *)(lVar4 + *(int64 *)(keyList + 16)),justReplace,1,0);
            if (lVar1 == null) break;
            FUN_181827900(lVar1,uVar2,DAT_181d7c3d0);
            uVar3 = uVar3 + 1;
            lVar4 = lVar4 + 8;
          }
        }
    }

    // Token : 0x6001873
    // RVA   : 0xA83050   Offset: 0xA81850   Length: 0x461
    public static string GetText(string key, bool justReplace, bool needCheckReplace)
    {
        var pStatics = *(int64*)(DAT_181d85f70 + 184);
        long lVar1;
        bool cVar2;
        long lVar3;
        ulong uVar4;
        uint uVar5;
        uint uVar6;
        if (**(int64 **)(DAT_181d5f6f8 + 184) == 0) {
          LTLocalization.Init(0);
        }
        cVar2 = FUN_1816fd990(key,"",0);
        if ((cVar2) || (key == null)) {
          return key;
        }
        cVar2 = GlobalData.IsCheckVersion(1,0);
        lVar3 = key;
        if (!cVar2) {
          if (*(char *)(*(int64 *)(DAT_181d4ef00 + 184) + 4) == false) {
        LAB_180a8333f:
            if (justReplace) {
              return lVar3;
            }
            lVar1 = *(int64 *)(*(int64 *)(DAT_181d4e010 + 184) + 8);
            if ((lVar1 != null) && (lVar1 = *(int64 *)(lVar1 + 16)) != null) {
              uVar4 = PlayerPrefDictionary.GetString(lVar1,"Language",0);
              cVar2 = FUN_1816fd990(uVar4,"CN",0);
              if (cVar2) {
                return lVar3;
              }
              cVar2 = Regex.IsMatch(lVar3,"[\\u4e00-\\u9fa5]",0);
              if (!cVar2) {
                return key;
              }
              lVar3 = ZhConverter.HansToHant(lVar3,0);
              return lVar3;
            }
            throw; // [null/range check failed]
          }
        }
        uVar5 = 0;
        if (!needCheckReplace) {
        LAB_180a83280:
          do {
            if (*pStatics == 0) throw; // [null/range check failed]
            if (*(int *)(*pStatics + 24) <= (int)uVar5) goto LAB_180a8333f;
            lVar1 = *pStatics;
            if (lVar1 == null) throw; // [null/range check failed]
            if (*(uint32 *)(lVar1 + 24) <= uVar5) {
              uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar4,0);
            }
            lVar1 = lVar1[uVar5];
            if (lVar1 == null) throw; // [null/range check failed]
            if (*(uint32 *)(lVar1 + 24) == 0) {
              uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar4,0);
            }
            if (*(uint32 *)(lVar1 + 24) < 2) {
              uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar4,0);
            }
            if (lVar3 == null) throw; // [null/range check failed]
            lVar3 = String.Replace(lVar3,*(uint64 *)(lVar1 + 32),*(uint64 *)(lVar1 + 40),0);
            uVar5 = uVar5 + 1;
          } while( true );
        }
        uVar6 = 0;
        while( true ) {
          lVar1 = *(int64 *)(pStatics + 8);
          if (lVar1 == null) break;
          if (*(int *)(lVar1 + 24) <= (int)uVar6) goto LAB_180a83280;
          lVar1 = *(int64 *)(pStatics + 8);
          if (lVar1 == null) break;
          if (*(uint32 *)(lVar1 + 24) <= uVar6) {
            uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar4,0);
          }
          lVar1 = lVar1[uVar6];
          if (lVar1 == null) break;
          if (*(uint32 *)(lVar1 + 24) == 0) {
            uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar4,0);
          }
          if (*(uint32 *)(lVar1 + 24) < 2) {
            uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar4,0);
          }
          if (lVar3 == null) break;
          lVar3 = String.Replace(lVar3,*(uint64 *)(lVar1 + 32),*(uint64 *)(lVar1 + 40),0);
          uVar6 = uVar6 + 1;
        }
    }

}
