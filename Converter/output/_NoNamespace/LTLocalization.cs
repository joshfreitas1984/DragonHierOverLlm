// ============================================================
// Type  : LTLocalization
// Token : 0x2000302
// ============================================================

public class LTLocalization
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x40018E7
    public const string LANGUAGE_ENGLISH;

    // Token: 0x40018E8
    public const string LANGUAGE_CHINESE;

    // Token: 0x40018E9
    public const string LANGUAGE_TCHINESE;

    // Token: 0x40018EA
    public const string LANGUAGE_JAPANESE;

    // Token: 0x40018EB
    public const string LANGUAGE_GERMAN;

    // Token: 0x40018EC
    public const string LANGUAGE_RUSSIA;

    // Token: 0x40018ED
    public const string LANGUAGE_PORTUGUESE;

    // Token: 0x40018EE
    private const string FILE_PATH;

    // Token: 0x40018EF
    private Dictionary<string, string> textData;

    // Token: 0x40018F0
    private static string cachedLanguage;

    // Token: 0x40018F1
    private static int languageVersion;

    // Token: 0x40018F2
    public static LTLocalization mInstance;

    // Token: 0x40018F3
    private static readonly Dictionary<string, Font> replaceFontCache;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x600193A
    // RVA   : 0x7C39B0   Offset: 0x7C27B0   Length: 0xB3
    public static string get_CurrentLanguage()
    {
        if (LTLocalization.LANGUAGE_ENGLISH == null) {
          LTLocalization.RefreshLanguageCache(0);
        }
        if (((*(byte *)(DAT_181e64c70 + 0x133) & 4) != 0) && (*(int *)(DAT_181e64c70 + 224) == 0)) {
          il2cpp_runtime_class_init();
          return **(uint64 **)(DAT_181e64c70 + 184);
        }
        return **(uint64 **)(DAT_181e64c70 + 184);
    }

    // Token : 0x600193B
    // RVA   : 0x7C3A70   Offset: 0x7C2870   Length: 0x67
    public static bool get_IsChinese()
    {
        ulong uVar1;
        uVar1 = LTLocalization.get_CurrentLanguage(0);
        FUN_1816387f0(uVar1,"CN",0);
    }

    // Token : 0x600193C
    // RVA   : 0x7C3AE0   Offset: 0x7C28E0   Length: 0x67
    public static bool get_IsTraditionalChinese()
    {
        ulong uVar1;
        uVar1 = LTLocalization.get_CurrentLanguage(0);
        FUN_1816387f0(uVar1,"TC",0);
    }

    // Token : 0x600193D
    // RVA   : 0x7C3B50   Offset: 0x7C2950   Length: 0x57
    public static int get_LanguageVersion()
    {
        return *(uint32 *)(*(int64 *)(DAT_181e64c70 + 184) + 8);
    }

    // Token : 0x600193E
    // RVA   : 0x7C3610   Offset: 0x7C2410   Length: 0xE7
    public static void RefreshLanguageCache()
    {
        long lVar2;
        ulong uVar4;
        lVar2 = *(int64 *)(*(int64 *)(DAT_181e528f8 + 184) + 8);
        if ((lVar2 != null) && (lVar2 = *(int64 *)(lVar2 + 16)) != null) {
          uVar4 = PlayerPrefDictionary.GetString(lVar2,"Language",0);
          puVar3 = *(uint64 **)(DAT_181e64c70 + 184);
          *puVar3 = uVar4;
          il2cpp_internal(puVar3,uVar4);
          piVar1 = (int *)(*(int64 *)(DAT_181e64c70 + 184) + 8);
          *piVar1 = *piVar1 + 1;
          return;
        }
    }

    // Token : 0x600193F
    // RVA   : 0x7C3930   Offset: 0x7C2730   Length: 0x76
    private void /*ctor*/()
    {
        ulong uVar1;
        uVar1 = il2cpp_internal(DAT_181e631c0);
        FUN_1806e5bc0(uVar1,DAT_181e56ab0);
        this.textData = uVar1;
        ZhSegment.Initialize(this,0);
    }

    // Token : 0x6001940
    // RVA   : 0x7C2370   Offset: 0x7C1170   Length: 0xF0
    public static SystemLanguage GetNowSystemLanguage()
    {
        bool cVar1;
        long lVar2;
        lVar2 = *(int64 *)(*(int64 *)(DAT_181e528f8 + 184) + 8);
        if ((lVar2 != null) && (lVar2 = *(int64 *)(lVar2 + 16)) != null) {
          lVar2 = PlayerPrefDictionary.GetString(lVar2,"Language",0);
          if (lVar2 != null) {
            cVar1 = FUN_1816387f0(lVar2,"CN",0);
            if (!cVar1) {
              cVar1 = FUN_1816387f0(lVar2,"TC",0);
              if (cVar1) {
                return 41;
              }
            }
          }
          return 40;
        }
    }

    // Token : 0x6001941
    // RVA   : 0x7C2320   Offset: 0x7C1120   Length: 0x48
    public static string GetLanguageAB(SystemLanguage language)
    {
        ulong uVar1;
        uVar1 = "CN";
        if (language == 41) {
          uVar1 = "TC";
        }
        return uVar1;
    }

    // Token : 0x6001942
    // RVA   : 0x7C2FE0   Offset: 0x7C1DE0   Length: 0x621
    private void ReadData()
    {
        int iVar1;
        long lVar2;
        bool cVar3;
        ulong uVar4;
        long lVar6;
        ulong uVar7;
        long lVar8;
        int iVar9;
        int iVar10;
        LTLocalization.RefreshLanguageCache(0);
        uVar4 = LTLocalization.get_CurrentLanguage(0);
        cVar3 = FUN_1816387f0(uVar4,"CN",0);
        if (cVar3) {
          return;
        }
        if (this.textData != null) {
          Dictionary_2.Clear(this.textData,DAT_181e56cd0);
          uVar4 = DAT_181ea28c0;
          uVar4 = Type.GetTypeFromHandle(uVar4,0);
          plVar5 = (int64 *)Resources.Load("LTLocalization/localization",uVar4,0);
          if (plVar5 != (int64 *)0) {
            iVar10 = 0;
            uVar4 = FUN_180b00cb0(plVar5,0);
            lVar6 = new ZhSegment(0);
            if (lVar6 != null) {
              uVar7 = new StringReader(uVar4,0);
              *(uint64 *)(lVar6 + 16) = uVar7;
              uVar4 = il2cpp_internal(DAT_181e70238);
              FUN_1810f3480(uVar4,DAT_181e5add0);
              *(uint64 *)(lVar6 + 32) = uVar4;
              cVar3 = LTCSVLoader.readCSVNextRecord(lVar6,0);
              if (cVar3) {
                lVar2 = *(int64 *)(lVar6 + 24);
                while (lVar2 != null) {
                  lVar8 = il2cpp_internal(DAT_181e77728);
                  FUN_1810f3480(lVar8,DAT_181e861f0);
                  iVar9 = 0;
                  while( true ) {
                    if (lVar2 == null) throw; // [null/range check failed]
                    if (lVar2.entries <= iVar9) break;
                    uVar4 = FUN_1800024b0(lVar2,iVar9,DAT_181e86970);
                    if (lVar8 == null) throw; // [null/range check failed]
                    FUN_18175de30(lVar8,uVar4,DAT_181e86370);
                    iVar9 = iVar9 + 1;
                  }
                  if (*(int64 *)(lVar6 + 32) == 0) throw; // [null/range check failed]
                  FUN_18175de30(*(int64 *)(lVar6 + 32),lVar8,DAT_181e5ae58);
                  cVar3 = LTCSVLoader.readCSVNextRecord(lVar6,0);
                  if (!cVar3) break;
                  lVar2 = *(int64 *)(lVar6 + 24);
                }
              }
              uVar4 = LTLocalization.get_CurrentLanguage(0);
              iVar9 = LTCSVLoader.GetFirstIndexAtRow(lVar6,uVar4,0,0);
              if (iVar9 == -1) {
                uVar4 = LTLocalization.get_CurrentLanguage(0);
                uVar4 = String.Concat("未读取到",uVar4,"任何数据，请检查配置表",0);
                Debug.LogError(uVar4,0);
                return;
              }
              uVar4 = LTLocalization.get_CurrentLanguage(0);
              uVar4 = String.Concat("[Language]",uVar4,"翻译文件已读取",0);
              Debug.Log(uVar4,0);
              if (*(int64 *)(lVar6 + 32) == 0) {
                uVar4 = il2cpp_runtime_class_init(&DAT_181ea59a0);
                uVar4 = il2cpp_internal(uVar4);
                uVar7 = il2cpp_internal(&"table尚未初始化,请检查是否成功读取");
                Exception.ctor(uVar4,uVar7,0);
                uVar7 = il2cpp_runtime_class_init(&DAT_181e69480);
                          // WARNING: Subroutine does not return
                FUN_1801e02d0(uVar4,uVar7);
              }
              iVar1 = *(int *)(*(int64 *)(lVar6 + 32) + 24);
              if (iVar1 < 1) {
                return;
              }
              while( true ) {
                lVar2 = this.textData;
                uVar4 = LTCSVLoader.GetValueAt(lVar6,0,iVar10,0);
                if (lVar2 == null) break;
                cVar3 = FUN_1806da450(lVar2,uVar4,DAT_181e56d58);
                if (!cVar3) {
                  lVar2 = this.textData;
                  uVar4 = LTCSVLoader.GetValueAt(lVar6,0,iVar10,0);
                  uVar7 = LTCSVLoader.GetValueAt(lVar6,iVar9,iVar10,0);
                  if (lVar2 == null) break;
                  FUN_1806da2f0(lVar2,uVar4,uVar7);
                }
                else {
                  uVar4 = LTCSVLoader.GetValueAt(lVar6,0,iVar10,0);
                  uVar4 = String.Concat("重复key",uVar4,0);
                  Debug.LogWarning(uVar4);
                }
                iVar10 = iVar10 + 1;
                if (iVar1 <= iVar10) {
                  return;
                }
              }
            }
          }
        }
    }

    // Token : 0x6001943
    // RVA   : 0x7C3700   Offset: 0x7C2500   Length: 0x119
    private void SetLanguage(SystemLanguage language)
    {
        long lVar1;
        ulong uVar2;
        lVar1 = *(int64 *)(*(int64 *)(DAT_181e528f8 + 184) + 8);
        if (lVar1 != null) {
          lVar1 = *(int64 *)(lVar1 + 16);
          uVar2 = "CN";
          if (((language != 6) && (language != 40)) && (language == 41)) {
            uVar2 = "TC";
          }
          if (lVar1 != null) {
            PlayerPrefDictionary.SetKey(lVar1,"Language",uVar2,0);
            LTLocalization.RefreshLanguageCache(0);
            return;
          }
        }
    }

    // Token : 0x6001944
    // RVA   : 0x7C2B80   Offset: 0x7C1980   Length: 0x2B4
    public static void Init()
    {
        bool cVar1;
        int iVar2;
        uint uVar3;
        ulong uVar4;
        long lVar6;
        uVar4 = new LTLocalization(0);
        LTLocalization.mInstance = uVar4;
        if (**(int **)(DAT_181e538e8 + 184) == 2) {
          lVar6 = LTLocalization.mInstance;
          if (lVar6 == null) throw; // [null/range check failed]
          uVar3 = 40;
        LAB_1807c2dac:
          LTLocalization.SetLanguage(lVar6,uVar3,0);
        }
        else {

          if ((lVar6 = *(int64 *)(*(int64 *)(DAT_181e528f8 + 184) + 8)?.textData) == null) throw; // [null/range check failed]
          cVar1 = PlayerPrefDictionary.ContainsKey(lVar6,"Language",0);
          if (!cVar1) {
            iVar2 = Application.get_systemLanguage(0);
            if (iVar2 == 42) {
              lVar6 = LTLocalization.mInstance;
              if (lVar6 == null) throw; // [null/range check failed]
              uVar3 = 10;
            }
            else {
              lVar6 = LTLocalization.mInstance;
              uVar3 = Application.get_systemLanguage(0);
              if (lVar6 == null) throw; // [null/range check failed]
            }
            goto LAB_1807c2dac;
          }
        }
        lVar6 = LTLocalization.mInstance;
        if (lVar6 != null) {
          LTLocalization.ReadData(lVar6,0);
          ZhConverter.Initialize("Dictionary","JiebaResource",0,0);
          return;
        }
    }

    // Token : 0x6001945
    // RVA   : 0x7C2E40   Offset: 0x7C1C40   Length: 0x19F
    public static void ManualSetLanguage(SystemLanguage setLanguage)
    {
        long lVar1;
        bool cVar2;
        ulong uVar3;
        ulong uVar5;
        if (LTLocalization.mInstance == null) {
          uVar3 = il2cpp_internal();
          LTLocalization.ctor(uVar3,0);
          LTLocalization.mInstance = uVar3;
        }
        uVar3 = LTLocalization.get_CurrentLanguage(0);
        uVar5 = "CN";
        if (((setLanguage != 6) && (setLanguage != 40)) && (setLanguage == 41)) {
          uVar5 = "TC";
        }
        cVar2 = String.op_Inequality(uVar3,uVar5,0);
        if (cVar2) {
          lVar1 = LTLocalization.mInstance;
          if (lVar1 != null) {
            LTLocalization.SetLanguage(lVar1,setLanguage,0);
            lVar1 = LTLocalization.mInstance;
            if (lVar1 != null) {
              LTLocalization.ReadData(lVar1,0);
              return;
            }
          }
                          // WARNING: Subroutine does not return
          FUN_1801e0300();
        }
    }

    // Token : 0x6001946
    // RVA   : 0x7C3820   Offset: 0x7C2620   Length: 0x8F
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

    // Token : 0x6001947
    // RVA   : 0x7C1F30   Offset: 0x7C0D30   Length: 0xB3
    public static void AddText(Text targetText, string targetValue)
    {
        ulong uVar1;
        ulong uVar2;
        if (targetText != (int64 *)0) {
          uVar1 = (**(code **)(*targetText + 0x5d8))(targetText,*(uint64 *)(*targetText + 0x5e0));
          uVar2 = LTLocalization.GetText(targetValue,0,1,0);
          uVar1 = String.Concat(uVar1,uVar2,0);
                          // WARNING: Could not recover jumptable at 0x0001807c1fd7. Too many branches
                          // WARNING: Treating indirect jump as call
          (**(code **)(*targetText + 0x5e8))(targetText,uVar1,*(uint64 *)(*targetText + 0x5f0));
          return;
        }
    }

    // Token : 0x6001948
    // RVA   : 0x7C1FF0   Offset: 0x7C0DF0   Length: 0x32D
    public static void CheckTextFont(Text targetText)
    {
        var pStatics = *(int64*)(DAT_181e538e8 + 184);
        bool cVar1;
        ulong uVar2;
        long lVar3;
        ulong uVar4;
        ulong uVar5;
        float fVar6;
        uVar2 = LTLocalization.get_CurrentLanguage(0);
        cVar1 = FUN_1816387f0(uVar2,"TC",0);
        if (cVar1) {
          if (targetText == (int64 *)0) {
        LAB_1807c2318:
                          // WARNING: Subroutine does not return
            FUN_1801e0300();
          }
          uVar2 = (**(code **)(*targetText + 0x5d8))(targetText,*(uint64 *)(*targetText + 0x5e0));
          cVar1 = FUN_180ad1200(uVar2,0);
          if (!cVar1) {
            uVar2 = Text.get_font(targetText,0);
            cVar1 = Object.op_Inequality(uVar2,0,0);
            uVar5 = 0;
            uVar4 = uVar5;
            if (cVar1) {
              lVar3 = Text.get_font(targetText,0);
              if (lVar3 == null) goto LAB_1807c2318;
              uVar4 = Object.get_name(lVar3,0);
            }
            while( true ) {
              lVar3 = *(int64 *)(pStatics + 224);
              if (lVar3 == null) goto LAB_1807c2318;
              if (*(int *)(lVar3 + 24) <= (int)uVar5) {
                return;
              }
              lVar3 = *(int64 *)(pStatics + 224);
              if ((lVar3 == null) || (lVar3 = FUN_1800024b0(lVar3,uVar5,DAT_181e5af68)) == null)
              goto LAB_1807c2318;
              if (*(int *)(lVar3 + 24) == 0) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              cVar1 = FUN_1816387f0(*(uint64 *)(*(int64 *)(lVar3 + 16) + 32),uVar4,0);
              if (cVar1) break;
              uVar5 = (uint64)((int)uVar5 + 1);
            }
            lVar3 = *(int64 *)(pStatics + 224);
            if ((lVar3 == null) || (lVar3 = FUN_1800024b0(lVar3,uVar5,DAT_181e5af68)) == null)
            goto LAB_1807c2318;
            if (*(uint32 *)(lVar3 + 24) < 2) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            uVar2 = *(uint64 *)(*(int64 *)(lVar3 + 16) + 40);
            uVar2 = LTLocalization.GetReplaceFont(uVar2,0);
            Text.set_font(targetText,uVar2,0);
            fVar6 = (float)Text.get_lineSpacing(targetText,0);
            Text.set_lineSpacing(targetText,fVar6 * 0.8,0);
          }
        }
    }

    // Token : 0x6001949
    // RVA   : 0x7C2470   Offset: 0x7C1270   Length: 0x137
    private static Font GetReplaceFont(string fontName)
    {
        long lVar1;
        bool cVar2;
        ulong uVar3;
        ulong[] local_res8 = new ulong[4];
        local_res8[0] = 0;
        lVar1 = LTLocalization.replaceFontCache;
        if (lVar1 != null) {
          cVar2 = FUN_1806e3f90(lVar1,fontName,local_res8,DAT_181e543e8);
          if (!cVar2) {
            uVar3 = String.Concat("Font/",fontName,0);
            local_res8[0] = Resources.Load(uVar3,DAT_181e834b8);
            lVar1 = LTLocalization.replaceFontCache;
            if (lVar1 == null) throw; // [null/range check failed]
            FUN_1806e7630(lVar1,fontName,local_res8[0],DAT_181e54470);
          }
          return local_res8[0];
        }
    }

    // Token : 0x600194A
    // RVA   : 0x7C25B0   Offset: 0x7C13B0   Length: 0x12F
    public static List<string> GetTextList(List<string> keyList, bool justReplace)
    {
        long lVar1;
        ulong uVar2;
        uint uVar3;
        long lVar4;
        lVar1 = il2cpp_internal(DAT_181e77728);
        FUN_1810f3480(lVar1,DAT_181e861f0);
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
            uVar2 = *(uint64 *)(lVar4 + *(int64 *)(keyList + 16));
            uVar2 = LTLocalization.GetText(uVar2,justReplace,1,0);
            if (lVar1 == null) break;
            FUN_18175de30(lVar1,uVar2,DAT_181e86370);
            uVar3 = uVar3 + 1;
            lVar4 = lVar4 + 8;
          }
        }
    }

    // Token : 0x600194B
    // RVA   : 0x7C26E0   Offset: 0x7C14E0   Length: 0x49B
    public static string GetText(string key, bool justReplace, bool needCheckReplace)
    {
        bool cVar1;
        long lVar2;
        long lVar3;
        ulong uVar4;
        uint uVar5;
        uint uVar6;
        if (*(int64 *)(*(int64 *)(DAT_181e64c70 + 184) + 16) == 0) {
          LTLocalization.Init(0);
        }
        cVar1 = FUN_1816387f0(key,"",0);
        if ((cVar1) || (key == null)) {
          return key;
        }
        cVar1 = GlobalData.IsCheckVersion(1,0);
        lVar2 = key;
        if (!cVar1) {
          if (*(char *)(*(int64 *)(DAT_181e538e8 + 184) + 4) == false) {
        LAB_1807c29ef:
            lVar3 = lVar2;
            if (!justReplace) {
              uVar4 = LTLocalization.get_CurrentLanguage(0);
              cVar1 = FUN_1816387f0(uVar4,"CN",0);
              if (!cVar1) {
                cVar1 = Regex.IsMatch(lVar2,"[\\u4e00-\\u9fa5]",0);
                lVar3 = key;
                if (cVar1) {
                  lVar3 = ZhConverter.HansToHant(lVar2,0);
                }
              }
            }
            return lVar3;
          }
        }
        uVar5 = 0;
        if (needCheckReplace) {
          uVar6 = 0;
          while( true ) {
            lVar3 = TextReplaceData.ReplaceTexts;
            if (lVar3 == null) break;
            if (*(int *)(lVar3 + 24) <= (int)uVar6) goto LAB_1807c2930;
            lVar3 = TextReplaceData.ReplaceTexts;
            if (lVar3 == null) break;
            if (*(uint32 *)(lVar3 + 24) <= uVar6) {
              uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1801e02d0(uVar4,0);
            }
            lVar3 = lVar3[uVar6];
            if (lVar3 == null) break;
            if (*(uint32 *)(lVar3 + 24) == 0) {
              uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1801e02d0(uVar4,0);
            }
            if (*(uint32 *)(lVar3 + 24) < 2) {
              uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1801e02d0(uVar4,0);
            }
            if (lVar2 == null) break;
            lVar2 = String.Replace(lVar2,*(uint64 *)(lVar3 + 32),*(uint64 *)(lVar3 + 40),0);
            uVar6 = uVar6 + 1;
          }
        LAB_1807c2b76:
                          // WARNING: Subroutine does not return
          FUN_1801e0300();
        }
        LAB_1807c2930:
        do {
          if (TextReplaceData.ForceReplaceTexts == null) goto LAB_1807c2b76;
          if (*(int *)(TextReplaceData.ForceReplaceTexts + 24) <= (int)uVar5) goto LAB_1807c29ef;
          lVar3 = TextReplaceData.ForceReplaceTexts;
          if (lVar3 == null) goto LAB_1807c2b76;
          if (*(uint32 *)(lVar3 + 24) <= uVar5) {
            uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1801e02d0(uVar4,0);
          }
          lVar3 = lVar3[uVar5];
          if (lVar3 == null) goto LAB_1807c2b76;
          if (*(uint32 *)(lVar3 + 24) == 0) {
            uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1801e02d0(uVar4,0);
          }
          if (*(uint32 *)(lVar3 + 24) < 2) {
            uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1801e02d0(uVar4,0);
          }
          if (lVar2 == null) goto LAB_1807c2b76;
          lVar2 = String.Replace(lVar2,*(uint64 *)(lVar3 + 32),*(uint64 *)(lVar3 + 40),0);
          uVar5 = uVar5 + 1;
        } while( true );
    }

    // Token : 0x600194C
    // RVA   : 0x7C38B0   Offset: 0x7C26B0   Length: 0x7A
    private static void /*cctor*/()
    {
        ulong uVar1;
        uVar1 = il2cpp_internal(DAT_181e62a40);
        FUN_1806e5bc0(uVar1,DAT_181e54360);
        puVar2 = (uint64 *)(*(int64 *)(DAT_181e64c70 + 184) + 24);
        *puVar2 = uVar1;
        il2cpp_internal(puVar2,uVar1);
    }

}
