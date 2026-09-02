// ============================================================
// Type  : Localization
// Token : 0x2000080
// ============================================================

public class Localization
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4000304
    public static LoadFunction loadFunction;

    // Token: 0x4000305
    public static OnLocalizeNotification onLocalize;

    // Token: 0x4000306
    public static bool localizationHasBeenSet;

    // Token: 0x4000307
    private static string[] mLanguages;

    // Token: 0x4000308
    private static Dictionary<string, string> mOldDictionary;

    // Token: 0x4000309
    private static Dictionary<string, string[]> mDictionary;

    // Token: 0x400030A
    private static Dictionary<string, string> mReplacement;

    // Token: 0x400030B
    private static int mLanguageIndex;

    // Token: 0x400030C
    private static string mLanguage;

    // Token: 0x400030D
    private static bool mMerging;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000321
    // RVA   : 0xA8AD80   Offset: 0xA89580   Length: 0xFD
    public static Dictionary<string, string[]> get_dictionary()
    {
        var pStatics = *(int64*)(DAT_181d61a70 + 184);
        ulong uVar1;
        if (*(char *)(pStatics + 16) == false) {
          uVar1 = PlayerPrefs.GetString("Language","English",0);
          Localization.LoadDictionary(uVar1,0,0);
        }
        if (((*(byte *)(DAT_181d61a70 + 0x133) & 4) != 0) && (*(int *)(DAT_181d61a70 + 224) == 0)) {
          il2cpp_runtime_class_init();
          return *(uint64 *)(pStatics + 40);
        }
        return *(uint64 *)(pStatics + 40);
    }

    // Token : 0x6000322
    // RVA   : 0xA8B0B0   Offset: 0xA898B0   Length: 0x7F
    public static void set_dictionary(Dictionary<string, string[]> value)
    {
        var pStatics = *(int64*)(DAT_181d61a70 + 184);
        *(bool *)(pStatics + 16) = value != null;
        plVar1 = (int64 *)(pStatics + 40);
        *plVar1 = value;
        il2cpp_internal(plVar1,value);
    }

    // Token : 0x6000323
    // RVA   : 0xA8AE80   Offset: 0xA89680   Length: 0xFD
    public static string[] get_knownLanguages()
    {
        var pStatics = *(int64*)(DAT_181d61a70 + 184);
        ulong uVar1;
        if (*(char *)(pStatics + 16) == false) {
          uVar1 = PlayerPrefs.GetString("Language","English",0);
          Localization.LoadDictionary(uVar1,0,0);
        }
        if (((*(byte *)(DAT_181d61a70 + 0x133) & 4) != 0) && (*(int *)(DAT_181d61a70 + 224) == 0)) {
          il2cpp_runtime_class_init();
          return *(uint64 *)(pStatics + 24);
        }
        return *(uint64 *)(pStatics + 24);
    }

    // Token : 0x6000324
    // RVA   : 0xA8AF80   Offset: 0xA89780   Length: 0x125
    public static string get_language()
    {
        var pStatics = *(int64*)(DAT_181d61a70 + 184);
        bool cVar1;
        ulong uVar2;
        cVar1 = FUN_180d6ca90(*(uint64 *)(pStatics + 64),0);
        if (cVar1) {
          uVar2 = PlayerPrefs.GetString("Language","English",0);
          puVar3 = (uint64 *)(pStatics + 64);
          *puVar3 = uVar2;
          il2cpp_internal(puVar3,uVar2);
          Localization.LoadAndSelect(*(uint64 *)(pStatics + 64),0);
        }
        return *(uint64 *)(pStatics + 64);
    }

    // Token : 0x6000325
    // RVA   : 0xA8B130   Offset: 0xA89930   Length: 0xBA
    public static void set_language(string value)
    {
        var pStatics = *(int64*)(DAT_181d61a70 + 184);
        bool cVar1;
        cVar1 = String.op_Inequality
                          (*(uint64 *)(pStatics + 64),value,0);
        if (cVar1) {
          puVar2 = (uint64 *)(pStatics + 64);
          *puVar2 = value;
          il2cpp_internal(puVar2,value);
          Localization.LoadAndSelect(value,0);
          return;
        }
    }

    // Token : 0x6000326
    // RVA   : 0xA89A80   Offset: 0xA88280   Length: 0x136
    public static bool Reload()
    {
        var pStatics = *(int64*)(DAT_181d61a70 + 184);
        long lVar1;
        bool cVar2;
        *(uint8 *)(pStatics + 16) = 0;
        cVar2 = Localization.LoadDictionary
                          (*(uint64 *)(pStatics + 64),1,0);
        if (cVar2) {
          if (*(int64 *)(pStatics + 8) != 0) {
            lVar1 = *(int64 *)(pStatics + 8);
            if (lVar1 == null) {
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            OnGeometryUpdated.Invoke(lVar1,0);
          }
          UIRoot.Broadcast("OnLocalize",0);
          return true;
        }
        return false;
    }

    // Token : 0x6000327
    // RVA   : 0xA89570   Offset: 0xA87D70   Length: 0x3E3
    private static bool LoadDictionary(string value, bool merge)
    {
        var pStatics = *(int64*)(DAT_181d61a70 + 184);
        bool cVar1;
        long lVar2;
        long lVar3;
        ulong uVar4;
        lVar2 = 0;
        if (*(char *)(pStatics + 16) == false) {
          if (*pStatics == 0) {
            lVar3 = Resources.Load("Localization",DAT_181d77460);
            cVar1 = Object.op_Inequality(lVar3,0,0);
            if (cVar1) {
              if (lVar3 == null) goto LAB_180a8994e;
              lVar2 = TextAsset.get_bytes(lVar3,0);
            }
          }
          else {
            if (*pStatics == 0) goto LAB_180a8994e;
            lVar2 = LoadFunction.Invoke(*pStatics,"Localization",0);
          }
          *(uint8 *)(pStatics + 16) = 1;
        }
        cVar1 = Localization.LoadCSV(lVar2,0,merge,0);
        if (!cVar1) {
          cVar1 = FUN_180d6ca90(value,0);
          if (cVar1) {
            value = *(uint64 *)(pStatics + 64);
          }
          cVar1 = FUN_180d6ca90(value,0);
          if (!cVar1) {
            if (*pStatics == 0) {
              lVar3 = Resources.Load(value,DAT_181d77460);
              cVar1 = Object.op_Inequality(lVar3,0,0);
              if (cVar1) {
                if (lVar3 == null) goto LAB_180a8994e;
                lVar2 = TextAsset.get_bytes(lVar3,0);
              }
            }
            else {
              if (*pStatics == 0) goto LAB_180a8994e;
              lVar2 = LoadFunction.Invoke(*pStatics,value,0);
            }
            if (lVar2 != null) {
              lVar3 = new ByteReader(lVar2,0);
              if (lVar3 == null) {
        LAB_180a8994e:
                          // WARNING: Subroutine does not return
                FUN_1800d6620();
              }
              uVar4 = ByteReader.ReadDictionary(lVar3,0);
              Localization.Set(value,uVar4,0);
              goto LAB_180a89933;
            }
          }
          uVar4 = 0;
        }
        else {
        LAB_180a89933:
          uVar4 = 1;
        }
        return uVar4;
    }

    // Token : 0x6000328
    // RVA   : 0xA885E0   Offset: 0xA86DE0   Length: 0x209
    private static bool LoadAndSelect(string value)
    {
        var pStatics = *(int64*)(DAT_181d61a70 + 184);
        long lVar1;
        bool cVar2;
        int iVar3;
        cVar2 = FUN_180d6ca90(value,0);
        if (!cVar2) {
          lVar1 = *(int64 *)(pStatics + 40);
          if (lVar1 == null) throw; // [null/range check failed]
          iVar3 = Dictionary_2.get_Count(lVar1,DAT_181da2c78);
          if (iVar3 == 0) {
            cVar2 = Localization.LoadDictionary(value,0,0);
            if (!cVar2) {
              return false;
            }
          }
          cVar2 = Localization.SelectLanguage(value,0);
          if (cVar2) {
            return true;
          }
        }
        lVar1 = *(int64 *)(pStatics + 32);
        if (lVar1 != null) {
          iVar3 = Dictionary_2.get_Count(lVar1,DAT_181d4fa58);
          if (0 < iVar3) {
            return true;
          }
          lVar1 = *(int64 *)(pStatics + 32);
          if (lVar1 != null) {
            Dictionary_2.Clear(lVar1,DAT_181d4f7d8);
            lVar1 = *(int64 *)(pStatics + 40);
            if (lVar1 != null) {
              Dictionary_2.Clear(lVar1,DAT_181da2a78);
              cVar2 = FUN_180d6ca90(value,0);
              if (cVar2) {
                PlayerPrefs.DeleteKey("Language",0);
              }
              return false;
            }
          }
        }
    }

    // Token : 0x6000329
    // RVA   : 0xA89960   Offset: 0xA88160   Length: 0xB1
    public static void Load(TextAsset asset)
    {
        long lVar1;
        ulong uVar2;
        ulong uVar3;
        lVar1 = new ByteReader(asset,0);
        if (asset != null) {
          uVar2 = Object.get_name(asset,0);
          if (lVar1 != null) {
            uVar3 = ByteReader.ReadDictionary(lVar1,0);
            Localization.Set(uVar2,uVar3,0);
            return;
          }
        }
    }

    // Token : 0x600032A
    // RVA   : 0xA8AB60   Offset: 0xA89360   Length: 0xAC
    public static void Set(string languageName, byte[] bytes)
    {
        var pStatics = *(int64*)(DAT_181d61a70 + 184);
        bool cVar1;
        long lVar2;
        long lVar4;
        long lVar5;
        long lVar6;
        ulong uVar7;
        uint uVar9;
        int iVar10;
        uint local_b0;
        long local_a8;
        ulong local_a0;
        long local_90;
        ulong local_88;
        ulong uStack_80;
        ulong local_78;
        ulong local_68;
        ulong local_58;
        ulong uStack_50;
        ulong local_48;
        ulong local_38;
        uVar9 = 0;
        local_c0 = (int64 *)0;
        local_c8 = (int64 *)0;
        local_88 = 0;
        uStack_80 = 0;
        local_78 = 0;
        plStack_70 = (int64 *)0;
        local_68 = 0;
        local_b8 = (int64 *)0;
        lVar2 = Localization.get_knownLanguages(0);
        if (lVar2 == null) {
          local_a8 = lVar2;
          plVar3 = (int64 *)FUN_1800d60b0(DAT_181d80cc0,1);
          if (plVar3 == (int64 *)0) throw; // [null/range check failed]
          if ((languageName != null) &&
             (lVar2 = il2cpp_internal(languageName,*(uint64 *)(*plVar3 + 64))) == null) {
            uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar7,0);
          }
          if ((int)plVar3[3] == 0) {
            uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar7,0);
          }
          plVar3[4] = languageName;
          il2cpp_internal(plVar3 + 4,languageName);
          puVar8 = (uint64 *)(pStatics + 24);
          *puVar8 = plVar3;
          il2cpp_internal(puVar8,plVar3);
          lVar2 = *(int64 *)(pStatics + 24);
        }
        local_a8 = lVar2;
        if (lVar2 != null) {
          iVar10 = *(int *)(lVar2 + 24);
          if (0 < iVar10) {
            do {
              if (*(uint32 *)(lVar2 + 24) <= uVar9) {
                uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar7,0);
              }
              cVar1 = FUN_1816fd990(lVar2[uVar9],languageName,0);
              if (cVar1) {
                lVar4 = *(int64 *)(pStatics + 40);
                if (lVar4 == null) throw; // [null/range check failed]
                cVar1 = FUN_1808addd0(lVar4,bytes,&local_c8,DAT_181da2bf8);
                if (!cVar1) {
                  local_c8 = (int64 *)FUN_1800d60b0(DAT_181d80cc0,*(uint32 *)(lVar2 + 24));
                  lVar2 = *(int64 *)(pStatics + 40);
                  if ((lVar2 == null) ||
                     (FUN_1808aec90(lVar2,bytes,local_c8,DAT_181da2cf8), plVar3 = local_c8,
                     local_c8 == (int64 *)0)) throw; // [null/range check failed]
                  if ((param_3 != 0) &&
                     (lVar2 = il2cpp_internal(param_3,*(uint64 *)(*local_c8 + 64))) == null)
                  {
                    uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                    FUN_1800d65f0(uVar7,0);
                  }
                  if ((int)plVar3[3] == 0) {
                    uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                    FUN_1800d65f0(uVar7,0);
                  }
                  plVar3 = plVar3 + 4;
                  *plVar3 = param_3;
                  il2cpp_internal(plVar3,param_3);
                }
                plVar3 = local_c8;
                if (local_c8 != (int64 *)0) {
                  if ((param_3 != 0) &&
                     (lVar2 = il2cpp_internal(param_3,*(uint64 *)(*local_c8 + 64))) == null)
                  {
                    uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                    FUN_1800d65f0(uVar7,0);
                  }
                  FUN_180002fd0(plVar3,(int64)(int)uVar9,param_3);
                  return;
                }
                throw; // [null/range check failed]
              }
              uVar9 = uVar9 + 1;
            } while ((int)uVar9 < iVar10);
          }
          plVar3 = (int64 *)(pStatics + 24);
          lVar4 = *plVar3;
          if (lVar4 != null) {
            uVar9 = *(uint32 *)(lVar4 + 24);
            iVar10 = uVar9 + 1;
            local_b0 = uVar9;
            Array.Resize(plVar3,iVar10,DAT_181d54838);
            plVar3 = *(int64 **)(pStatics + 24);
            if (plVar3 != (int64 *)0) {
              if ((languageName != null) &&
                 (lVar4 = il2cpp_internal(languageName,*(uint64 *)(*plVar3 + 64))) == null) {
                uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar7,0);
              }
              if (*(uint32 *)(plVar3 + 3) <= uVar9) {
                uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar7,0);
              }
              plVar3[(int64)iVar10 + 3] = languageName;
              il2cpp_internal(plVar3 + (int64)iVar10 + 3,languageName);
              lVar5 = il2cpp_internal(DAT_181d5de48);
              FUN_1808ae540(lVar5,DAT_181da2978);
              lVar4 = *(int64 *)(pStatics + 40);
              local_90 = lVar5;
              if (lVar4 != null) {
                FUN_1808abcf0(&local_58,lVar4,DAT_181da2b78);
                local_88 = local_58;
                uStack_80 = uStack_50;
                local_78 = local_48;
                plStack_70 = plStack_40;
                local_68 = local_38;
                while (cVar1 = FUN_1811d8ad0(&local_88,DAT_181d7a528), cVar1) {
                  local_a0 = local_78;
                  plStack_98 = plStack_70;
                  local_b8 = plStack_70;
                  Array.Resize(&local_b8,iVar10,DAT_181d54838);
                  plVar3 = local_b8;
                  if (local_b8 == (int64 *)0) {
                          // WARNING: Subroutine does not return
                    FUN_1800d6620();
                  }
                  if ((int)local_b8[3] == 0) {
                    uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                    FUN_1800d65f0(uVar7,0);
                  }
                  lVar4 = local_b8[4];
                  if ((lVar4 != null) &&
                     (lVar6 = il2cpp_internal(lVar4,*(uint64 *)(*local_b8 + 64))) == null) {
                    uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                    FUN_1800d65f0(uVar7,0);
                  }
                  if (*(uint32 *)(plVar3 + 3) <= uVar9) {
                    uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                    FUN_1800d65f0(uVar7,0);
                  }
                  plVar3 = plVar3 + (int64)(int)uVar9 + 4;
                  *plVar3 = lVar4;
                  il2cpp_internal(plVar3,lVar4);
                  if (lVar5 == null) {
                          // WARNING: Subroutine does not return
                    FUN_1800d6620();
                  }
                  FUN_1808ab680(lVar5,local_a0,local_b8,DAT_181da29f8);
                }
                ZhSegment.Initialize(&local_88,DAT_181d7a4a8);
                plVar3 = (int64 *)(pStatics + 40);
                *plVar3 = lVar5;
                il2cpp_internal(plVar3,lVar5);
                lVar4 = *(int64 *)(pStatics + 40);
                if (lVar4 != null) {
                  cVar1 = FUN_1808addd0(lVar4,bytes,&local_c0,DAT_181da2bf8);
                  if (!cVar1) {
                    local_c0 = (int64 *)FUN_1800d60b0(DAT_181d80cc0,*(uint32 *)(lVar2 + 24));
                    lVar2 = *(int64 *)(pStatics + 40);
                    if ((lVar2 == null) ||
                       (FUN_1808aec90(lVar2,bytes,local_c0,DAT_181da2cf8), plVar3 = local_c0,
                       local_c0 == (int64 *)0)) throw; // [null/range check failed]
                    if ((param_3 != 0) &&
                       (lVar2 = il2cpp_internal(param_3,*(uint64 *)(*local_c0 + 64)), lVar2 == null
                       )) {
                      uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                      FUN_1800d65f0(uVar7,0);
                    }
                    if ((int)plVar3[3] == 0) {
                      uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                      FUN_1800d65f0(uVar7,0);
                    }
                    plVar3 = plVar3 + 4;
                    *plVar3 = param_3;
                    il2cpp_internal(plVar3,param_3);
                  }
                  plVar3 = local_c0;
                  if (local_c0 != (int64 *)0) {
                    if ((param_3 != 0) &&
                       (lVar2 = il2cpp_internal(param_3,*(uint64 *)(*local_c0 + 64)), lVar2 == null
                       )) {
                      uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                      FUN_1800d65f0(uVar7,0);
                    }
                    if (uVar9 < *(uint32 *)(plVar3 + 3)) {
                      plVar3 = plVar3 + (int64)(int)uVar9 + 4;
                      *plVar3 = param_3;
                      il2cpp_internal(plVar3,param_3);
                      return;
                    }
                    uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                    FUN_1800d65f0(uVar7,0);
                  }
                }
              }
            }
          }
        }
    }

    // Token : 0x600032B
    // RVA   : 0xA89BC0   Offset: 0xA883C0   Length: 0xF5
    public static void ReplaceKey(string key, string val)
    {
        var pStatics = *(int64*)(DAT_181d61a70 + 184);
        long lVar1;
        bool cVar2;
        cVar2 = FUN_180d6ca90(val,0);
        if (!cVar2) {
          lVar1 = *(int64 *)(pStatics + 48);
          if (lVar1 != null) {
            FUN_1808aec90(lVar1,key,val,DAT_181d4fbd8);
            return;
          }
        }
        else {
          lVar1 = *(int64 *)(pStatics + 48);
          if (lVar1 != null) {
            FUN_18177a010(lVar1,key,DAT_181d4f958);
            return;
          }
        }
    }

    // Token : 0x600032C
    // RVA   : 0xA86980   Offset: 0xA85180   Length: 0x79
    public static void ClearReplacements()
    {
        long lVar1;
        lVar1 = *(int64 *)(*(int64 *)(DAT_181d61a70 + 184) + 48);
        if (lVar1 != null) {
          Dictionary_2.Clear(lVar1,DAT_181d4f7d8);
          return;
        }
    }

    // Token : 0x600032D
    // RVA   : 0xA894E0   Offset: 0xA87CE0   Length: 0x87
    public static bool LoadCSV(TextAsset asset, bool merge)
    {
        var pStatics = *(int64*)(DAT_181d61a70 + 184);
        int iVar1;
        bool cVar2;
        long lVar3;
        long lVar4;
        long lVar6;
        long lVar7;
        long lVar8;
        ulong uVar9;
        uint uVar11;
        long local_c0;
        long local_b0;
        long local_a8;
        long local_a0;
        long local_98;
        ulong local_90;
        ulong uStack_88;
        ulong local_80;
        ulong local_70;
        ulong local_60;
        ulong local_50;
        ulong uStack_48;
        ulong local_40;
        ulong local_30;
        local_90 = 0;
        uStack_88 = 0;
        local_80 = 0;
        plStack_78 = (int64 *)0;
        local_70 = 0;
        local_c8 = (int64 *)0;
        local_c0 = 0;
        if (asset == null) {
          return false;
        }
        lVar3 = il2cpp_internal(DAT_181d8f3b0);
        local_b0 = lVar3;
        ByteReader.ctor(lVar3,asset,0);
        local_a8 = lVar3;
        if ((lVar3 == null) || (lVar4 = ByteReader.ReadCSV(lVar3,0), local_a0 = lVar4) == null)
        goto LAB_180a89464;
        if (*(int *)(lVar4 + 24) < 2) {
          return false;
        }
        FUN_18154e570(lVar4,0,DAT_181d81298);
        cVar2 = FUN_180d6ca90(*(uint64 *)(pStatics + 64),0);
        if (cVar2) {
          *(uint8 *)(pStatics + 16) = 0;
        }
        if (*(char *)(pStatics + 16) == false) {
        LAB_180a88e66:
          lVar6 = *(int64 *)(pStatics + 40);
          if (lVar6 == null) goto LAB_180a89464;
          Dictionary_2.Clear(lVar6,DAT_181da2a78);
          uVar9 = FUN_1800d60b0(DAT_181d80cc0,*(uint32 *)(lVar4 + 24));
          puVar10 = (uint64 *)(pStatics + 24);
          *puVar10 = uVar9;
          il2cpp_internal(puVar10,uVar9);
          if (*(char *)(pStatics + 16) == false) {
            lVar6 = *(int64 *)(lVar4 + 16);
            if (lVar6 == null) goto LAB_180a89464;
            if (*(int *)(lVar6 + 24) == 0) {
              uVar9 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar9,0);
            }
            uVar9 = PlayerPrefs.GetString("Language",*(uint64 *)(lVar6 + 32),0);
            puVar10 = (uint64 *)(pStatics + 64);
            *puVar10 = uVar9;
            il2cpp_internal(puVar10,uVar9);
            *(uint8 *)(pStatics + 16) = 1;
          }
          for (uVar11 = 0; plVar5 = (int64 *)0, (int)uVar11 < *(int *)(lVar4 + 24);
              uVar11 = uVar11 + 1) {
            plVar5 = *(int64 **)(pStatics + 24);
            lVar6 = *(int64 *)(lVar4 + 16);
            if (lVar6 == null) goto LAB_180a89464;
            lVar7 = (int64)(int)uVar11;
            if (*(uint32 *)(lVar6 + 24) <= uVar11) {
              uVar9 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar9,0);
            }
            lVar6 = *(int64 *)(lVar6 + 32 + lVar7 * 8);
            if (plVar5 == (int64 *)0) goto LAB_180a89464;
            if ((lVar6 != null) &&
               (lVar8 = il2cpp_internal(lVar6,*(uint64 *)(*plVar5 + 64))) == null) {
              uVar9 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar9,0);
            }
            FUN_180002fd0(plVar5,lVar7,lVar6);
            lVar6 = *(int64 *)(pStatics + 24);
            if (lVar6 == null) goto LAB_180a89464;
            if (*(uint32 *)(lVar6 + 24) <= uVar11) {
              uVar9 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar9,0);
            }
            cVar2 = FUN_1816fd990(*(uint64 *)(lVar6 + 32 + lVar7 * 8),
                                  *(uint64 *)(pStatics + 64),0);
            if (cVar2) {
              *(uint32 *)(pStatics + 56) = uVar11;
            }
          }
        }
        else {
          if (!param_3) {
            if (*(char *)(pStatics + 72) == false) goto LAB_180a88e66;
          }
          if (*(int64 *)(pStatics + 24) == 0) goto LAB_180a88e66;
          lVar6 = *(int64 *)(pStatics + 24);
          if (lVar6 == null) goto LAB_180a89464;
          if (*(int64 *)(lVar6 + 24) == 0) goto LAB_180a88e66;
          plVar5 = (int64 *)FUN_1800d60b0(DAT_181d80cc0,*(uint32 *)(lVar4 + 24));
          local_b8 = plVar5;
          for (uVar11 = 0; (int)uVar11 < *(int *)(lVar4 + 24); uVar11 = uVar11 + 1) {
            lVar3 = *(int64 *)(lVar4 + 16);
            if (lVar3 == null) goto LAB_180a89464;
            if (*(uint32 *)(lVar3 + 24) <= uVar11) {
              uVar9 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar9,0);
            }
            lVar3 = lVar3[uVar11];
            if (plVar5 == (int64 *)0) goto LAB_180a89464;
            if ((lVar3 != null) &&
               (lVar6 = il2cpp_internal(lVar3,*(uint64 *)(*plVar5 + 64))) == null) {
              uVar9 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar9,0);
            }
            if (*(uint32 *)(plVar5 + 3) <= uVar11) {
              uVar9 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar9,0);
            }
            plVar5[(int64)(int)uVar11 + 4] = lVar3;
            il2cpp_internal();
          }
          for (uVar11 = 0; plVar5 = local_b8, lVar3 = local_b0, (int)uVar11 < *(int *)(lVar4 + 24);
              uVar11 = uVar11 + 1) {
            lVar3 = *(int64 *)(lVar4 + 16);
            if (lVar3 == null) goto LAB_180a89464;
            if (*(uint32 *)(lVar3 + 24) <= uVar11) {
              uVar9 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar9,0);
            }
            lVar6 = (int64)(int)uVar11 * 8 + 32;
            uVar9 = *(uint64 *)(lVar6 + lVar3);
            cVar2 = Localization.HasLanguage(uVar9);
            if (!cVar2) {
              plVar5 = (int64 *)(pStatics + 24);
              lVar3 = *plVar5;
              if (lVar3 == null) goto LAB_180a89464;
              iVar1 = *(int *)(lVar3 + 24);
              Array.Resize(plVar5,iVar1 + 1,DAT_181d54838);
              plVar5 = *(int64 **)(pStatics + 24);
              lVar3 = *(int64 *)(lVar4 + 16);
              if (lVar3 == null) goto LAB_180a89464;
              if (*(uint32 *)(lVar3 + 24) <= uVar11) {
                uVar9 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar9,0);
              }
              lVar3 = *(int64 *)(lVar6 + lVar3);
              if (plVar5 == (int64 *)0) goto LAB_180a89464;
              if ((lVar3 != null) &&
                 (lVar6 = il2cpp_internal(lVar3,*(uint64 *)(*plVar5 + 64))) == null) {
                uVar9 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar9,0);
              }
              FUN_180002fd0(plVar5,(int64)iVar1,lVar3);
              lVar6 = il2cpp_internal(DAT_181d5de48);
              FUN_1808ae540(lVar6,DAT_181da2978);
              lVar3 = *(int64 *)(pStatics + 40);
              local_98 = lVar6;
              if (lVar3 == null) goto LAB_180a89464;
              FUN_1808abcf0(&local_50,lVar3,DAT_181da2b78);
              local_90 = local_50;
              uStack_88 = uStack_48;
              local_80 = local_40;
              plStack_78 = plStack_38;
              local_70 = local_30;
              while (cVar2 = FUN_1811d8ad0(&local_90,DAT_181d7a528), lVar3 = local_c0, cVar2) {
                local_60 = local_80;
                plStack_58 = plStack_78;
                local_c8 = plStack_78;
                Array.Resize(&local_c8,iVar1 + 1,DAT_181d54838);
                plVar5 = local_c8;
                if (local_c8 == (int64 *)0) {
                          // WARNING: Subroutine does not return
                  FUN_1800d6620();
                }
                if ((int)local_c8[3] == 0) {
                  uVar9 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1800d65f0(uVar9,0);
                }
                lVar3 = local_c8[4];
                if ((lVar3 != null) &&
                   (lVar7 = il2cpp_internal(lVar3,*(uint64 *)(*local_c8 + 64))) == null) {
                  uVar9 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1800d65f0(uVar9,0);
                }
                FUN_180002fd0(plVar5,(int64)iVar1,lVar3);
                if (lVar6 == null) {
                          // WARNING: Subroutine does not return
                  FUN_1800d6620();
                }
                FUN_1808ab680(lVar6,local_60,local_c8);
              }
              ZhSegment.Initialize(&local_90,DAT_181d7a4a8);
              if (lVar3 != null) {
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(lVar3,0);
              }
              *(int64 *)(pStatics + 40) = lVar6;
            }
          }
        }
        lVar4 = il2cpp_internal(DAT_181d5e248);
        FUN_1808ae540(lVar4,DAT_181d4d968);
        uVar11 = 0;
        while( true ) {
          lVar6 = *(int64 *)(pStatics + 24);
          if (lVar6 == null) break;
          if (*(int *)(lVar6 + 24) <= (int)uVar11) goto LAB_180a89143;
          lVar6 = *(int64 *)(pStatics + 24);
          if (lVar6 == null) break;
          if (*(uint32 *)(lVar6 + 24) <= uVar11) {
            uVar9 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar9,0);
          }
          if (lVar4 == null) break;
          FUN_1808ab680(lVar4,lVar6[uVar11],uVar11);
          uVar11 = uVar11 + 1;
        }
        LAB_180a89464:
                          // WARNING: Subroutine does not return
        FUN_1800d6620();
        LAB_180a89143:
        lVar6 = ByteReader.ReadCSV(lVar3,0);
        if ((lVar6 == null) || (*(int *)(lVar6 + 24) == 0)) goto LAB_180a891b2;
        lVar7 = *(int64 *)(lVar6 + 16);
        if (lVar7 == null) goto LAB_180a89464;
        if (*(int *)(lVar7 + 24) == 0) {
          uVar9 = il2cpp_internal();
                          // WARNING: Subroutine does not return
          FUN_1800d65f0(uVar9,0);
        }
        cVar2 = FUN_180d6ca90(*(uint64 *)(lVar7 + 32));
        if (!cVar2) {
          Localization.AddCSV(lVar6,plVar5,lVar4,0);
        }
        goto LAB_180a89143;
        LAB_180a891b2:
        if (*(char *)(pStatics + 72) == false) {
          if (*(int64 *)(pStatics + 8) != 0) {
            *(uint8 *)(pStatics + 72) = 1;
            plVar5 = (int64 *)(pStatics + 8);
            lVar3 = *plVar5;
            *plVar5 = 0;
            il2cpp_internal(plVar5,0);
            if (lVar3 == null) goto LAB_180a89464;
            OnGeometryUpdated.Invoke(lVar3,0);
            plVar5 = (int64 *)(pStatics + 8);
            *plVar5 = lVar3;
            il2cpp_internal(plVar5,lVar3);
            *(uint8 *)(pStatics + 72) = 0;
          }
        }
        if (param_3) {
          if (*(int64 *)(pStatics + 8) != 0) {
            lVar3 = *(int64 *)(pStatics + 8);
            if (lVar3 == null) goto LAB_180a89464;
            OnGeometryUpdated.Invoke(lVar3,0);
          }
          UIRoot.Broadcast("OnLocalize",0);
        }
        return true;
    }

    // Token : 0x600032E
    // RVA   : 0xA89470   Offset: 0xA87C70   Length: 0x65
    public static bool LoadCSV(byte[] bytes, bool merge)
    {
        var pStatics = *(int64*)(DAT_181d61a70 + 184);
        int iVar1;
        bool cVar2;
        long lVar3;
        long lVar4;
        long lVar6;
        long lVar7;
        long lVar8;
        ulong uVar9;
        uint uVar11;
        long local_c0;
        long local_b0;
        long local_a8;
        long local_a0;
        long local_98;
        ulong local_90;
        ulong uStack_88;
        ulong local_80;
        ulong local_70;
        ulong local_60;
        ulong local_50;
        ulong uStack_48;
        ulong local_40;
        ulong local_30;
        local_90 = 0;
        uStack_88 = 0;
        local_80 = 0;
        plStack_78 = (int64 *)0;
        local_70 = 0;
        local_c8 = (int64 *)0;
        local_c0 = 0;
        if (bytes == null) {
          return false;
        }
        lVar3 = il2cpp_internal(DAT_181d8f3b0);
        local_b0 = lVar3;
        ByteReader.ctor(lVar3,bytes,0);
        local_a8 = lVar3;
        if ((lVar3 == null) || (lVar4 = ByteReader.ReadCSV(lVar3,0), local_a0 = lVar4) == null)
        goto LAB_180a89464;
        if (*(int *)(lVar4 + 24) < 2) {
          return false;
        }
        FUN_18154e570(lVar4,0,DAT_181d81298);
        cVar2 = FUN_180d6ca90(*(uint64 *)(pStatics + 64),0);
        if (cVar2) {
          *(uint8 *)(pStatics + 16) = 0;
        }
        if (*(char *)(pStatics + 16) == false) {
        LAB_180a88e66:
          lVar6 = *(int64 *)(pStatics + 40);
          if (lVar6 == null) goto LAB_180a89464;
          Dictionary_2.Clear(lVar6,DAT_181da2a78);
          uVar9 = FUN_1800d60b0(DAT_181d80cc0,*(uint32 *)(lVar4 + 24));
          puVar10 = (uint64 *)(pStatics + 24);
          *puVar10 = uVar9;
          il2cpp_internal(puVar10,uVar9);
          if (*(char *)(pStatics + 16) == false) {
            lVar6 = *(int64 *)(lVar4 + 16);
            if (lVar6 == null) goto LAB_180a89464;
            if (*(int *)(lVar6 + 24) == 0) {
              uVar9 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar9,0);
            }
            uVar9 = PlayerPrefs.GetString("Language",*(uint64 *)(lVar6 + 32),0);
            puVar10 = (uint64 *)(pStatics + 64);
            *puVar10 = uVar9;
            il2cpp_internal(puVar10,uVar9);
            *(uint8 *)(pStatics + 16) = 1;
          }
          for (uVar11 = 0; plVar5 = (int64 *)0, (int)uVar11 < *(int *)(lVar4 + 24);
              uVar11 = uVar11 + 1) {
            plVar5 = *(int64 **)(pStatics + 24);
            lVar6 = *(int64 *)(lVar4 + 16);
            if (lVar6 == null) goto LAB_180a89464;
            lVar7 = (int64)(int)uVar11;
            if (*(uint32 *)(lVar6 + 24) <= uVar11) {
              uVar9 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar9,0);
            }
            lVar6 = *(int64 *)(lVar6 + 32 + lVar7 * 8);
            if (plVar5 == (int64 *)0) goto LAB_180a89464;
            if ((lVar6 != null) &&
               (lVar8 = il2cpp_internal(lVar6,*(uint64 *)(*plVar5 + 64))) == null) {
              uVar9 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar9,0);
            }
            FUN_180002fd0(plVar5,lVar7,lVar6);
            lVar6 = *(int64 *)(pStatics + 24);
            if (lVar6 == null) goto LAB_180a89464;
            if (*(uint32 *)(lVar6 + 24) <= uVar11) {
              uVar9 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar9,0);
            }
            cVar2 = FUN_1816fd990(*(uint64 *)(lVar6 + 32 + lVar7 * 8),
                                  *(uint64 *)(pStatics + 64),0);
            if (cVar2) {
              *(uint32 *)(pStatics + 56) = uVar11;
            }
          }
        }
        else {
          if (!param_3) {
            if (*(char *)(pStatics + 72) == false) goto LAB_180a88e66;
          }
          if (*(int64 *)(pStatics + 24) == 0) goto LAB_180a88e66;
          lVar6 = *(int64 *)(pStatics + 24);
          if (lVar6 == null) goto LAB_180a89464;
          if (*(int64 *)(lVar6 + 24) == 0) goto LAB_180a88e66;
          plVar5 = (int64 *)FUN_1800d60b0(DAT_181d80cc0,*(uint32 *)(lVar4 + 24));
          local_b8 = plVar5;
          for (uVar11 = 0; (int)uVar11 < *(int *)(lVar4 + 24); uVar11 = uVar11 + 1) {
            lVar3 = *(int64 *)(lVar4 + 16);
            if (lVar3 == null) goto LAB_180a89464;
            if (*(uint32 *)(lVar3 + 24) <= uVar11) {
              uVar9 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar9,0);
            }
            lVar3 = lVar3[uVar11];
            if (plVar5 == (int64 *)0) goto LAB_180a89464;
            if ((lVar3 != null) &&
               (lVar6 = il2cpp_internal(lVar3,*(uint64 *)(*plVar5 + 64))) == null) {
              uVar9 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar9,0);
            }
            if (*(uint32 *)(plVar5 + 3) <= uVar11) {
              uVar9 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar9,0);
            }
            plVar5[(int64)(int)uVar11 + 4] = lVar3;
            il2cpp_internal();
          }
          for (uVar11 = 0; plVar5 = local_b8, lVar3 = local_b0, (int)uVar11 < *(int *)(lVar4 + 24);
              uVar11 = uVar11 + 1) {
            lVar3 = *(int64 *)(lVar4 + 16);
            if (lVar3 == null) goto LAB_180a89464;
            if (*(uint32 *)(lVar3 + 24) <= uVar11) {
              uVar9 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar9,0);
            }
            lVar6 = (int64)(int)uVar11 * 8 + 32;
            uVar9 = *(uint64 *)(lVar6 + lVar3);
            cVar2 = Localization.HasLanguage(uVar9);
            if (!cVar2) {
              plVar5 = (int64 *)(pStatics + 24);
              lVar3 = *plVar5;
              if (lVar3 == null) goto LAB_180a89464;
              iVar1 = *(int *)(lVar3 + 24);
              Array.Resize(plVar5,iVar1 + 1,DAT_181d54838);
              plVar5 = *(int64 **)(pStatics + 24);
              lVar3 = *(int64 *)(lVar4 + 16);
              if (lVar3 == null) goto LAB_180a89464;
              if (*(uint32 *)(lVar3 + 24) <= uVar11) {
                uVar9 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar9,0);
              }
              lVar3 = *(int64 *)(lVar6 + lVar3);
              if (plVar5 == (int64 *)0) goto LAB_180a89464;
              if ((lVar3 != null) &&
                 (lVar6 = il2cpp_internal(lVar3,*(uint64 *)(*plVar5 + 64))) == null) {
                uVar9 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar9,0);
              }
              FUN_180002fd0(plVar5,(int64)iVar1,lVar3);
              lVar6 = il2cpp_internal(DAT_181d5de48);
              FUN_1808ae540(lVar6,DAT_181da2978);
              lVar3 = *(int64 *)(pStatics + 40);
              local_98 = lVar6;
              if (lVar3 == null) goto LAB_180a89464;
              FUN_1808abcf0(&local_50,lVar3,DAT_181da2b78);
              local_90 = local_50;
              uStack_88 = uStack_48;
              local_80 = local_40;
              plStack_78 = plStack_38;
              local_70 = local_30;
              while (cVar2 = FUN_1811d8ad0(&local_90,DAT_181d7a528), lVar3 = local_c0, cVar2) {
                local_60 = local_80;
                plStack_58 = plStack_78;
                local_c8 = plStack_78;
                Array.Resize(&local_c8,iVar1 + 1,DAT_181d54838);
                plVar5 = local_c8;
                if (local_c8 == (int64 *)0) {
                          // WARNING: Subroutine does not return
                  FUN_1800d6620();
                }
                if ((int)local_c8[3] == 0) {
                  uVar9 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1800d65f0(uVar9,0);
                }
                lVar3 = local_c8[4];
                if ((lVar3 != null) &&
                   (lVar7 = il2cpp_internal(lVar3,*(uint64 *)(*local_c8 + 64))) == null) {
                  uVar9 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1800d65f0(uVar9,0);
                }
                FUN_180002fd0(plVar5,(int64)iVar1,lVar3);
                if (lVar6 == null) {
                          // WARNING: Subroutine does not return
                  FUN_1800d6620();
                }
                FUN_1808ab680(lVar6,local_60,local_c8);
              }
              ZhSegment.Initialize(&local_90,DAT_181d7a4a8);
              if (lVar3 != null) {
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(lVar3,0);
              }
              *(int64 *)(pStatics + 40) = lVar6;
            }
          }
        }
        lVar4 = il2cpp_internal(DAT_181d5e248);
        FUN_1808ae540(lVar4,DAT_181d4d968);
        uVar11 = 0;
        while( true ) {
          lVar6 = *(int64 *)(pStatics + 24);
          if (lVar6 == null) break;
          if (*(int *)(lVar6 + 24) <= (int)uVar11) goto LAB_180a89143;
          lVar6 = *(int64 *)(pStatics + 24);
          if (lVar6 == null) break;
          if (*(uint32 *)(lVar6 + 24) <= uVar11) {
            uVar9 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar9,0);
          }
          if (lVar4 == null) break;
          FUN_1808ab680(lVar4,lVar6[uVar11],uVar11);
          uVar11 = uVar11 + 1;
        }
        LAB_180a89464:
                          // WARNING: Subroutine does not return
        FUN_1800d6620();
        LAB_180a89143:
        lVar6 = ByteReader.ReadCSV(lVar3,0);
        if ((lVar6 == null) || (*(int *)(lVar6 + 24) == 0)) goto LAB_180a891b2;
        lVar7 = *(int64 *)(lVar6 + 16);
        if (lVar7 == null) goto LAB_180a89464;
        if (*(int *)(lVar7 + 24) == 0) {
          uVar9 = il2cpp_internal();
                          // WARNING: Subroutine does not return
          FUN_1800d65f0(uVar9,0);
        }
        cVar2 = FUN_180d6ca90(*(uint64 *)(lVar7 + 32));
        if (!cVar2) {
          Localization.AddCSV(lVar6,plVar5,lVar4,0);
        }
        goto LAB_180a89143;
        LAB_180a891b2:
        if (*(char *)(pStatics + 72) == false) {
          if (*(int64 *)(pStatics + 8) != 0) {
            *(uint8 *)(pStatics + 72) = 1;
            plVar5 = (int64 *)(pStatics + 8);
            lVar3 = *plVar5;
            *plVar5 = 0;
            il2cpp_internal(plVar5,0);
            if (lVar3 == null) goto LAB_180a89464;
            OnGeometryUpdated.Invoke(lVar3,0);
            plVar5 = (int64 *)(pStatics + 8);
            *plVar5 = lVar3;
            il2cpp_internal(plVar5,lVar3);
            *(uint8 *)(pStatics + 72) = 0;
          }
        }
        if (param_3) {
          if (*(int64 *)(pStatics + 8) != 0) {
            lVar3 = *(int64 *)(pStatics + 8);
            if (lVar3 == null) goto LAB_180a89464;
            OnGeometryUpdated.Invoke(lVar3,0);
          }
          UIRoot.Broadcast("OnLocalize",0);
        }
        return true;
    }

    // Token : 0x600032F
    // RVA   : 0xA87DF0   Offset: 0xA865F0   Length: 0x102
    private static bool HasLanguage(string languageName)
    {
        var pStatics = *(int64*)(DAT_181d61a70 + 184);
        int iVar1;
        long lVar2;
        bool cVar3;
        ulong uVar4;
        uint uVar5;
        uVar5 = 0;
        lVar2 = *(int64 *)(pStatics + 24);
        if (lVar2 == null) {
        LAB_180a87edd:
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
        iVar1 = *(int *)(lVar2 + 24);
        if (0 < iVar1) {
          do {
            lVar2 = *(int64 *)(pStatics + 24);
            if (lVar2 == null) goto LAB_180a87edd;
            if (*(uint32 *)(lVar2 + 24) <= uVar5) {
              uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar4,0);
            }
            cVar3 = FUN_1816fd990(lVar2[uVar5],languageName,0);
            if (cVar3) {
              return true;
            }
            uVar5 = uVar5 + 1;
          } while ((int)uVar5 < iVar1);
        }
        return false;
    }

    // Token : 0x6000330
    // RVA   : 0xA887F0   Offset: 0xA86FF0   Length: 0xC79
    private static bool LoadCSV(byte[] bytes, TextAsset asset, bool merge)
    {
        var pStatics = *(int64*)(DAT_181d61a70 + 184);
        int iVar1;
        bool cVar2;
        long lVar3;
        long lVar4;
        long lVar6;
        long lVar7;
        long lVar8;
        ulong uVar9;
        uint uVar11;
        long local_c0;
        long local_b0;
        long local_a8;
        long local_a0;
        long local_98;
        ulong local_90;
        ulong uStack_88;
        ulong local_80;
        ulong local_70;
        ulong local_60;
        ulong local_50;
        ulong uStack_48;
        ulong local_40;
        ulong local_30;
        local_90 = 0;
        uStack_88 = 0;
        local_80 = 0;
        plStack_78 = (int64 *)0;
        local_70 = 0;
        local_c8 = (int64 *)0;
        local_c0 = 0;
        if (bytes == null) {
          return false;
        }
        lVar3 = il2cpp_internal(DAT_181d8f3b0);
        local_b0 = lVar3;
        ByteReader.ctor(lVar3,bytes,0);
        local_a8 = lVar3;
        if ((lVar3 == null) || (lVar4 = ByteReader.ReadCSV(lVar3,0), local_a0 = lVar4) == null)
        goto LAB_180a89464;
        if (*(int *)(lVar4 + 24) < 2) {
          return false;
        }
        FUN_18154e570(lVar4,0,DAT_181d81298);
        cVar2 = FUN_180d6ca90(*(uint64 *)(pStatics + 64),0);
        if (cVar2) {
          *(uint8 *)(pStatics + 16) = 0;
        }
        if (*(char *)(pStatics + 16) == false) {
        LAB_180a88e66:
          lVar6 = *(int64 *)(pStatics + 40);
          if (lVar6 == null) goto LAB_180a89464;
          Dictionary_2.Clear(lVar6,DAT_181da2a78);
          uVar9 = FUN_1800d60b0(DAT_181d80cc0,*(uint32 *)(lVar4 + 24));
          puVar10 = (uint64 *)(pStatics + 24);
          *puVar10 = uVar9;
          il2cpp_internal(puVar10,uVar9);
          if (*(char *)(pStatics + 16) == false) {
            lVar6 = *(int64 *)(lVar4 + 16);
            if (lVar6 == null) goto LAB_180a89464;
            if (*(int *)(lVar6 + 24) == 0) {
              uVar9 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar9,0);
            }
            uVar9 = PlayerPrefs.GetString("Language",*(uint64 *)(lVar6 + 32),0);
            puVar10 = (uint64 *)(pStatics + 64);
            *puVar10 = uVar9;
            il2cpp_internal(puVar10,uVar9);
            *(uint8 *)(pStatics + 16) = 1;
          }
          for (uVar11 = 0; plVar5 = (int64 *)0, (int)uVar11 < *(int *)(lVar4 + 24);
              uVar11 = uVar11 + 1) {
            plVar5 = *(int64 **)(pStatics + 24);
            lVar6 = *(int64 *)(lVar4 + 16);
            if (lVar6 == null) goto LAB_180a89464;
            lVar7 = (int64)(int)uVar11;
            if (*(uint32 *)(lVar6 + 24) <= uVar11) {
              uVar9 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar9,0);
            }
            lVar6 = *(int64 *)(lVar6 + 32 + lVar7 * 8);
            if (plVar5 == (int64 *)0) goto LAB_180a89464;
            if ((lVar6 != null) &&
               (lVar8 = il2cpp_internal(lVar6,*(uint64 *)(*plVar5 + 64))) == null) {
              uVar9 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar9,0);
            }
            FUN_180002fd0(plVar5,lVar7,lVar6);
            lVar6 = *(int64 *)(pStatics + 24);
            if (lVar6 == null) goto LAB_180a89464;
            if (*(uint32 *)(lVar6 + 24) <= uVar11) {
              uVar9 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar9,0);
            }
            cVar2 = FUN_1816fd990(*(uint64 *)(lVar6 + 32 + lVar7 * 8),
                                  *(uint64 *)(pStatics + 64),0);
            if (cVar2) {
              *(uint32 *)(pStatics + 56) = uVar11;
            }
          }
        }
        else {
          if (!merge) {
            if (*(char *)(pStatics + 72) == false) goto LAB_180a88e66;
          }
          if (*(int64 *)(pStatics + 24) == 0) goto LAB_180a88e66;
          lVar6 = *(int64 *)(pStatics + 24);
          if (lVar6 == null) goto LAB_180a89464;
          if (*(int64 *)(lVar6 + 24) == 0) goto LAB_180a88e66;
          plVar5 = (int64 *)FUN_1800d60b0(DAT_181d80cc0,*(uint32 *)(lVar4 + 24));
          local_b8 = plVar5;
          for (uVar11 = 0; (int)uVar11 < *(int *)(lVar4 + 24); uVar11 = uVar11 + 1) {
            lVar3 = *(int64 *)(lVar4 + 16);
            if (lVar3 == null) goto LAB_180a89464;
            if (*(uint32 *)(lVar3 + 24) <= uVar11) {
              uVar9 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar9,0);
            }
            lVar3 = lVar3[uVar11];
            if (plVar5 == (int64 *)0) goto LAB_180a89464;
            if ((lVar3 != null) &&
               (lVar6 = il2cpp_internal(lVar3,*(uint64 *)(*plVar5 + 64))) == null) {
              uVar9 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar9,0);
            }
            if (*(uint32 *)(plVar5 + 3) <= uVar11) {
              uVar9 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar9,0);
            }
            plVar5[(int64)(int)uVar11 + 4] = lVar3;
            il2cpp_internal();
          }
          for (uVar11 = 0; plVar5 = local_b8, lVar3 = local_b0, (int)uVar11 < *(int *)(lVar4 + 24);
              uVar11 = uVar11 + 1) {
            lVar3 = *(int64 *)(lVar4 + 16);
            if (lVar3 == null) goto LAB_180a89464;
            if (*(uint32 *)(lVar3 + 24) <= uVar11) {
              uVar9 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar9,0);
            }
            lVar6 = (int64)(int)uVar11 * 8 + 32;
            uVar9 = *(uint64 *)(lVar6 + lVar3);
            cVar2 = Localization.HasLanguage(uVar9);
            if (!cVar2) {
              plVar5 = (int64 *)(pStatics + 24);
              lVar3 = *plVar5;
              if (lVar3 == null) goto LAB_180a89464;
              iVar1 = *(int *)(lVar3 + 24);
              Array.Resize(plVar5,iVar1 + 1,DAT_181d54838);
              plVar5 = *(int64 **)(pStatics + 24);
              lVar3 = *(int64 *)(lVar4 + 16);
              if (lVar3 == null) goto LAB_180a89464;
              if (*(uint32 *)(lVar3 + 24) <= uVar11) {
                uVar9 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar9,0);
              }
              lVar3 = *(int64 *)(lVar6 + lVar3);
              if (plVar5 == (int64 *)0) goto LAB_180a89464;
              if ((lVar3 != null) &&
                 (lVar6 = il2cpp_internal(lVar3,*(uint64 *)(*plVar5 + 64))) == null) {
                uVar9 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar9,0);
              }
              FUN_180002fd0(plVar5,(int64)iVar1,lVar3);
              lVar6 = il2cpp_internal(DAT_181d5de48);
              FUN_1808ae540(lVar6,DAT_181da2978);
              lVar3 = *(int64 *)(pStatics + 40);
              local_98 = lVar6;
              if (lVar3 == null) goto LAB_180a89464;
              FUN_1808abcf0(&local_50,lVar3,DAT_181da2b78);
              local_90 = local_50;
              uStack_88 = uStack_48;
              local_80 = local_40;
              plStack_78 = plStack_38;
              local_70 = local_30;
              while (cVar2 = FUN_1811d8ad0(&local_90,DAT_181d7a528), lVar3 = local_c0, cVar2) {
                local_60 = local_80;
                plStack_58 = plStack_78;
                local_c8 = plStack_78;
                Array.Resize(&local_c8,iVar1 + 1,DAT_181d54838);
                plVar5 = local_c8;
                if (local_c8 == (int64 *)0) {
                          // WARNING: Subroutine does not return
                  FUN_1800d6620();
                }
                if ((int)local_c8[3] == 0) {
                  uVar9 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1800d65f0(uVar9,0);
                }
                lVar3 = local_c8[4];
                if ((lVar3 != null) &&
                   (lVar7 = il2cpp_internal(lVar3,*(uint64 *)(*local_c8 + 64))) == null) {
                  uVar9 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1800d65f0(uVar9,0);
                }
                FUN_180002fd0(plVar5,(int64)iVar1,lVar3);
                if (lVar6 == null) {
                          // WARNING: Subroutine does not return
                  FUN_1800d6620();
                }
                FUN_1808ab680(lVar6,local_60,local_c8);
              }
              ZhSegment.Initialize(&local_90,DAT_181d7a4a8);
              if (lVar3 != null) {
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(lVar3,0);
              }
              *(int64 *)(pStatics + 40) = lVar6;
            }
          }
        }
        lVar4 = il2cpp_internal(DAT_181d5e248);
        FUN_1808ae540(lVar4,DAT_181d4d968);
        uVar11 = 0;
        while( true ) {
          lVar6 = *(int64 *)(pStatics + 24);
          if (lVar6 == null) break;
          if (*(int *)(lVar6 + 24) <= (int)uVar11) goto LAB_180a89143;
          lVar6 = *(int64 *)(pStatics + 24);
          if (lVar6 == null) break;
          if (*(uint32 *)(lVar6 + 24) <= uVar11) {
            uVar9 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar9,0);
          }
          if (lVar4 == null) break;
          FUN_1808ab680(lVar4,lVar6[uVar11],uVar11);
          uVar11 = uVar11 + 1;
        }
        LAB_180a89464:
                          // WARNING: Subroutine does not return
        FUN_1800d6620();
        LAB_180a89143:
        lVar6 = ByteReader.ReadCSV(lVar3,0);
        if ((lVar6 == null) || (*(int *)(lVar6 + 24) == 0)) goto LAB_180a891b2;
        lVar7 = *(int64 *)(lVar6 + 16);
        if (lVar7 == null) goto LAB_180a89464;
        if (*(int *)(lVar7 + 24) == 0) {
          uVar9 = il2cpp_internal();
                          // WARNING: Subroutine does not return
          FUN_1800d65f0(uVar9,0);
        }
        cVar2 = FUN_180d6ca90(*(uint64 *)(lVar7 + 32));
        if (!cVar2) {
          Localization.AddCSV(lVar6,plVar5,lVar4,0);
        }
        goto LAB_180a89143;
        LAB_180a891b2:
        if (*(char *)(pStatics + 72) == false) {
          if (*(int64 *)(pStatics + 8) != 0) {
            *(uint8 *)(pStatics + 72) = 1;
            plVar5 = (int64 *)(pStatics + 8);
            lVar3 = *plVar5;
            *plVar5 = 0;
            il2cpp_internal(plVar5,0);
            if (lVar3 == null) goto LAB_180a89464;
            OnGeometryUpdated.Invoke(lVar3,0);
            plVar5 = (int64 *)(pStatics + 8);
            *plVar5 = lVar3;
            il2cpp_internal(plVar5,lVar3);
            *(uint8 *)(pStatics + 72) = 0;
          }
        }
        if (merge) {
          if (*(int64 *)(pStatics + 8) != 0) {
            lVar3 = *(int64 *)(pStatics + 8);
            if (lVar3 == null) goto LAB_180a89464;
            OnGeometryUpdated.Invoke(lVar3,0);
          }
          UIRoot.Broadcast("OnLocalize",0);
        }
        return true;
    }

    // Token : 0x6000331
    // RVA   : 0xA86690   Offset: 0xA84E90   Length: 0x2EB
    private static void AddCSV(BetterList<string> newValues, string[] newLanguages, Dictionary<string, int> languageIndices)
    {
        var pStatics = *(int64*)(DAT_181d61a70 + 184);
        long lVar1;
        bool cVar2;
        ulong uVar3;
        ulong uVar4;
        if (newValues != null) {
          if (1 < *(int *)(newValues + 24)) {
            lVar1 = *(int64 *)(newValues + 16);
            if (lVar1 == null) throw; // [null/range check failed]
            if (*(int *)(lVar1 + 24) == 0) {
              uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar4,0);
            }
            uVar4 = *(uint64 *)(lVar1 + 32);
            cVar2 = FUN_180d6ca90(uVar4,0);
            if (!cVar2) {
              uVar3 = Localization.ExtractStrings(newValues,newLanguages,languageIndices,0);
              lVar1 = *(int64 *)(pStatics + 40);
              if (lVar1 == null) throw; // [null/range check failed]
              cVar2 = FUN_1808ab750(lVar1,uVar4,DAT_181da2af8);
              if (!cVar2) {
                lVar1 = *(int64 *)(pStatics + 40);
                if (lVar1 == null) {
                          // WARNING: Subroutine does not return
                  FUN_1800d6620();
                }
                FUN_1808ab680(lVar1,uVar4,uVar3,DAT_181da29f8);
              }
              else {
                lVar1 = *(int64 *)(pStatics + 40);
                if (lVar1 == null) throw; // [null/range check failed]
                FUN_1808aec90(lVar1,uVar4,uVar3,DAT_181da2cf8);
                if (newLanguages == null) {
                  uVar4 = String.Concat("Localization key '",uVar4,"' is already present",0);
                  Debug.LogWarning(uVar4,0);
                }
              }
            }
          }
          return;
        }
    }

    // Token : 0x6000332
    // RVA   : 0xA86C20   Offset: 0xA85420   Length: 0x37A
    private static string[] ExtractStrings(BetterList<string> added, string[] newLanguages, Dictionary<string, int> languageIndices)
    {
        var pStatics = *(int64*)(DAT_181d61a70 + 184);
        long lVar1;
        bool cVar2;
        uint uVar3;
        int iVar4;
        ulong uVar6;
        long lVar7;
        uint uVar8;
        uVar8 = 0;
        local_res10 = (int64 *)0;
        if (newLanguages == null) {
          lVar1 = *(int64 *)(pStatics + 24);
          if (lVar1 != null) {
            plVar5 = (int64 *)FUN_1800d60b0(DAT_181d80cc0,*(uint32 *)(lVar1 + 24));
            uVar8 = 1;
            if ((added != null) && (plVar5 != (int64 *)0)) {
              iVar4 = Mathf.Min(*(uint32 *)(added + 24),(int)plVar5[3] + 1,0);
              if (iVar4 < 2) {
                return plVar5;
              }
              while (lVar1 = *(int64 *)(added + 16)) != null {
                if (*(uint32 *)(lVar1 + 24) <= uVar8) {
                  uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1800d65f0(uVar6,0);
                }
                lVar1 = lVar1[uVar8];
                if ((lVar1 != null) &&
                   (lVar7 = il2cpp_internal(lVar1,*(uint64 *)(*plVar5 + 64))) == null) {
                  uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1800d65f0(uVar6,0);
                }
                if (*(uint32 *)(plVar5 + 3) <= uVar8 - 1) {
                  uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1800d65f0(uVar6,0);
                }
                plVar5[(int64)(int)uVar8 + 3] = lVar1;
                il2cpp_internal();
                uVar8 = uVar8 + 1;
                if (iVar4 <= (int)uVar8) {
                  return plVar5;
                }
              }
            }
          }
        }
        else if ((added != null) && (lVar1 = *(int64 *)(added + 16)) != null) {
          if (*(int *)(lVar1 + 24) == 0) {
            uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar6,0);
          }
          uVar6 = *(uint64 *)(lVar1 + 32);
          lVar1 = *(int64 *)(pStatics + 40);
          if (lVar1 != null) {
            cVar2 = FUN_1808addd0(lVar1,uVar6,&local_res10,DAT_181da2bf8);
            if (!cVar2) {
              lVar1 = *(int64 *)(pStatics + 24);
              if (lVar1 == null) throw; // [null/range check failed]
              local_res10 = (int64 *)FUN_1800d60b0(DAT_181d80cc0,*(uint32 *)(lVar1 + 24));
            }
            iVar4 = *(int *)(newLanguages + 24);
            if (0 < iVar4) {
              do {
                if (*(uint32 *)(newLanguages + 24) <= uVar8) {
                  uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1800d65f0(uVar6,0);
                }
                if (languageIndices == null) throw; // [null/range check failed]
                uVar3 = FUN_181789700(languageIndices,newLanguages[uVar8],
                                      DAT_181d4de68);
                plVar5 = local_res10;
                lVar1 = *(int64 *)(added + 16);
                if (lVar1 == null) throw; // [null/range check failed]
                lVar7 = (int64)(int)uVar8 + 1;
                if (*(uint32 *)(lVar1 + 24) <= (uint32)lVar7) {
                  uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1800d65f0(uVar6,0);
                }
                lVar1 = *(int64 *)(lVar1 + 32 + lVar7 * 8);
                if (local_res10 == (int64 *)0) throw; // [null/range check failed]
                if ((lVar1 != null) &&
                   (lVar7 = il2cpp_internal(lVar1,*(uint64 *)(*local_res10 + 64))) == null)
                {
                  uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1800d65f0(uVar6,0);
                }
                if (*(uint32 *)(plVar5 + 3) <= uVar3) {
                  uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1800d65f0(uVar6,0);
                }
                plVar5[(int64)(int)uVar3 + 4] = lVar1;
                il2cpp_internal();
                uVar8 = uVar8 + 1;
              } while ((int)uVar8 < iVar4);
            }
            return local_res10;
          }
        }
    }

    // Token : 0x6000333
    // RVA   : 0xA89CC0   Offset: 0xA884C0   Length: 0x2C0
    private static bool SelectLanguage(string language)
    {
        var pStatics = *(int64*)(DAT_181d61a70 + 184);
        long lVar1;
        bool cVar2;
        int iVar3;
        ulong uVar4;
        uint uVar6;
        *(uint32 *)(pStatics + 56) = 0xffffffff;
        lVar1 = *(int64 *)(pStatics + 40);
        if (lVar1 == null) {
        LAB_180a89f6b:
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
        iVar3 = Dictionary_2.get_Count(lVar1,DAT_181da2c78);
        if (iVar3 != 0) {
          uVar6 = 0;
          lVar1 = *(int64 *)(pStatics + 24);
          if (lVar1 == null) goto LAB_180a89f6b;
          iVar3 = *(int *)(lVar1 + 24);
          if (0 < iVar3) {
            do {
              lVar1 = *(int64 *)(pStatics + 24);
              if (lVar1 == null) goto LAB_180a89f6b;
              if (*(uint32 *)(lVar1 + 24) <= uVar6) {
                uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar4,0);
              }
              cVar2 = FUN_1816fd990(lVar1[uVar6],language,0);
              if (cVar2) {
                lVar1 = *(int64 *)(pStatics + 32);
                if (lVar1 == null) goto LAB_180a89f6b;
                Dictionary_2.Clear(lVar1,DAT_181d4f7d8);
                *(uint32 *)(pStatics + 56) = uVar6;
                puVar5 = (uint64 *)(pStatics + 64);
                *puVar5 = language;
                il2cpp_internal(puVar5,language);
                PlayerPrefs.SetString
                          ("Language",*(uint64 *)(pStatics + 64),0);
                if (*(int64 *)(pStatics + 8) != 0) {
                  lVar1 = *(int64 *)(pStatics + 8);
                  if (lVar1 == null) goto LAB_180a89f6b;
                  OnGeometryUpdated.Invoke(lVar1,0);
                }
                UIRoot.Broadcast("OnLocalize",0);
                return true;
              }
              uVar6 = uVar6 + 1;
            } while ((int)uVar6 < iVar3);
          }
        }
        return false;
    }

    // Token : 0x6000334
    // RVA   : 0xA89F90   Offset: 0xA88790   Length: 0x214
    public static void Set(string languageName, Dictionary<string, string> dictionary)
    {
        var pStatics = *(int64*)(DAT_181d61a70 + 184);
        bool cVar1;
        long lVar2;
        long lVar4;
        long lVar5;
        long lVar6;
        ulong uVar7;
        uint uVar9;
        int iVar10;
        uint local_b0;
        long local_a8;
        ulong local_a0;
        long local_90;
        ulong local_88;
        ulong uStack_80;
        ulong local_78;
        ulong local_68;
        ulong local_58;
        ulong uStack_50;
        ulong local_48;
        ulong local_38;
        uVar9 = 0;
        local_c0 = (int64 *)0;
        local_c8 = (int64 *)0;
        local_88 = 0;
        uStack_80 = 0;
        local_78 = 0;
        plStack_70 = (int64 *)0;
        local_68 = 0;
        local_b8 = (int64 *)0;
        lVar2 = Localization.get_knownLanguages(0);
        if (lVar2 == null) {
          local_a8 = lVar2;
          plVar3 = (int64 *)FUN_1800d60b0(DAT_181d80cc0,1);
          if (plVar3 == (int64 *)0) throw; // [null/range check failed]
          if ((languageName != null) &&
             (lVar2 = il2cpp_internal(languageName,*(uint64 *)(*plVar3 + 64))) == null) {
            uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar7,0);
          }
          if ((int)plVar3[3] == 0) {
            uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar7,0);
          }
          plVar3[4] = languageName;
          il2cpp_internal(plVar3 + 4,languageName);
          puVar8 = (uint64 *)(pStatics + 24);
          *puVar8 = plVar3;
          il2cpp_internal(puVar8,plVar3);
          lVar2 = *(int64 *)(pStatics + 24);
        }
        local_a8 = lVar2;
        if (lVar2 != null) {
          iVar10 = *(int *)(lVar2 + 24);
          if (0 < iVar10) {
            do {
              if (*(uint32 *)(lVar2 + 24) <= uVar9) {
                uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar7,0);
              }
              cVar1 = FUN_1816fd990(lVar2[uVar9],languageName,0);
              if (cVar1) {
                lVar4 = *(int64 *)(pStatics + 40);
                if (lVar4 == null) throw; // [null/range check failed]
                cVar1 = FUN_1808addd0(lVar4,dictionary,&local_c8,DAT_181da2bf8);
                if (!cVar1) {
                  local_c8 = (int64 *)FUN_1800d60b0(DAT_181d80cc0,*(uint32 *)(lVar2 + 24));
                  lVar2 = *(int64 *)(pStatics + 40);
                  if ((lVar2 == null) ||
                     (FUN_1808aec90(lVar2,dictionary,local_c8,DAT_181da2cf8), plVar3 = local_c8,
                     local_c8 == (int64 *)0)) throw; // [null/range check failed]
                  if ((param_3 != 0) &&
                     (lVar2 = il2cpp_internal(param_3,*(uint64 *)(*local_c8 + 64))) == null)
                  {
                    uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                    FUN_1800d65f0(uVar7,0);
                  }
                  if ((int)plVar3[3] == 0) {
                    uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                    FUN_1800d65f0(uVar7,0);
                  }
                  plVar3 = plVar3 + 4;
                  *plVar3 = param_3;
                  il2cpp_internal(plVar3,param_3);
                }
                plVar3 = local_c8;
                if (local_c8 != (int64 *)0) {
                  if ((param_3 != 0) &&
                     (lVar2 = il2cpp_internal(param_3,*(uint64 *)(*local_c8 + 64))) == null)
                  {
                    uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                    FUN_1800d65f0(uVar7,0);
                  }
                  FUN_180002fd0(plVar3,(int64)(int)uVar9,param_3);
                  return;
                }
                throw; // [null/range check failed]
              }
              uVar9 = uVar9 + 1;
            } while ((int)uVar9 < iVar10);
          }
          plVar3 = (int64 *)(pStatics + 24);
          lVar4 = *plVar3;
          if (lVar4 != null) {
            uVar9 = *(uint32 *)(lVar4 + 24);
            iVar10 = uVar9 + 1;
            local_b0 = uVar9;
            Array.Resize(plVar3,iVar10,DAT_181d54838);
            plVar3 = *(int64 **)(pStatics + 24);
            if (plVar3 != (int64 *)0) {
              if ((languageName != null) &&
                 (lVar4 = il2cpp_internal(languageName,*(uint64 *)(*plVar3 + 64))) == null) {
                uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar7,0);
              }
              if (*(uint32 *)(plVar3 + 3) <= uVar9) {
                uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar7,0);
              }
              plVar3[(int64)iVar10 + 3] = languageName;
              il2cpp_internal(plVar3 + (int64)iVar10 + 3,languageName);
              lVar5 = il2cpp_internal(DAT_181d5de48);
              FUN_1808ae540(lVar5,DAT_181da2978);
              lVar4 = *(int64 *)(pStatics + 40);
              local_90 = lVar5;
              if (lVar4 != null) {
                FUN_1808abcf0(&local_58,lVar4,DAT_181da2b78);
                local_88 = local_58;
                uStack_80 = uStack_50;
                local_78 = local_48;
                plStack_70 = plStack_40;
                local_68 = local_38;
                while (cVar1 = FUN_1811d8ad0(&local_88,DAT_181d7a528), cVar1) {
                  local_a0 = local_78;
                  plStack_98 = plStack_70;
                  local_b8 = plStack_70;
                  Array.Resize(&local_b8,iVar10,DAT_181d54838);
                  plVar3 = local_b8;
                  if (local_b8 == (int64 *)0) {
                          // WARNING: Subroutine does not return
                    FUN_1800d6620();
                  }
                  if ((int)local_b8[3] == 0) {
                    uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                    FUN_1800d65f0(uVar7,0);
                  }
                  lVar4 = local_b8[4];
                  if ((lVar4 != null) &&
                     (lVar6 = il2cpp_internal(lVar4,*(uint64 *)(*local_b8 + 64))) == null) {
                    uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                    FUN_1800d65f0(uVar7,0);
                  }
                  if (*(uint32 *)(plVar3 + 3) <= uVar9) {
                    uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                    FUN_1800d65f0(uVar7,0);
                  }
                  plVar3 = plVar3 + (int64)(int)uVar9 + 4;
                  *plVar3 = lVar4;
                  il2cpp_internal(plVar3,lVar4);
                  if (lVar5 == null) {
                          // WARNING: Subroutine does not return
                    FUN_1800d6620();
                  }
                  FUN_1808ab680(lVar5,local_a0,local_b8,DAT_181da29f8);
                }
                ZhSegment.Initialize(&local_88,DAT_181d7a4a8);
                plVar3 = (int64 *)(pStatics + 40);
                *plVar3 = lVar5;
                il2cpp_internal(plVar3,lVar5);
                lVar4 = *(int64 *)(pStatics + 40);
                if (lVar4 != null) {
                  cVar1 = FUN_1808addd0(lVar4,dictionary,&local_c0,DAT_181da2bf8);
                  if (!cVar1) {
                    local_c0 = (int64 *)FUN_1800d60b0(DAT_181d80cc0,*(uint32 *)(lVar2 + 24));
                    lVar2 = *(int64 *)(pStatics + 40);
                    if ((lVar2 == null) ||
                       (FUN_1808aec90(lVar2,dictionary,local_c0,DAT_181da2cf8), plVar3 = local_c0,
                       local_c0 == (int64 *)0)) throw; // [null/range check failed]
                    if ((param_3 != 0) &&
                       (lVar2 = il2cpp_internal(param_3,*(uint64 *)(*local_c0 + 64)), lVar2 == null
                       )) {
                      uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                      FUN_1800d65f0(uVar7,0);
                    }
                    if ((int)plVar3[3] == 0) {
                      uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                      FUN_1800d65f0(uVar7,0);
                    }
                    plVar3 = plVar3 + 4;
                    *plVar3 = param_3;
                    il2cpp_internal(plVar3,param_3);
                  }
                  plVar3 = local_c0;
                  if (local_c0 != (int64 *)0) {
                    if ((param_3 != 0) &&
                       (lVar2 = il2cpp_internal(param_3,*(uint64 *)(*local_c0 + 64)), lVar2 == null
                       )) {
                      uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                      FUN_1800d65f0(uVar7,0);
                    }
                    if (uVar9 < *(uint32 *)(plVar3 + 3)) {
                      plVar3 = plVar3 + (int64)(int)uVar9 + 4;
                      *plVar3 = param_3;
                      il2cpp_internal(plVar3,param_3);
                      return;
                    }
                    uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                    FUN_1800d65f0(uVar7,0);
                  }
                }
              }
            }
          }
        }
    }

    // Token : 0x6000335
    // RVA   : 0xA8A1B0   Offset: 0xA889B0   Length: 0x145
    public static void Set(string key, string value)
    {
        var pStatics = *(int64*)(DAT_181d61a70 + 184);
        bool cVar1;
        long lVar2;
        long lVar4;
        long lVar5;
        long lVar6;
        ulong uVar7;
        uint uVar9;
        int iVar10;
        uint local_b0;
        long local_a8;
        ulong local_a0;
        long local_90;
        ulong local_88;
        ulong uStack_80;
        ulong local_78;
        ulong local_68;
        ulong local_58;
        ulong uStack_50;
        ulong local_48;
        ulong local_38;
        uVar9 = 0;
        local_c0 = (int64 *)0;
        local_c8 = (int64 *)0;
        local_88 = 0;
        uStack_80 = 0;
        local_78 = 0;
        plStack_70 = (int64 *)0;
        local_68 = 0;
        local_b8 = (int64 *)0;
        lVar2 = Localization.get_knownLanguages(0);
        if (lVar2 == null) {
          local_a8 = lVar2;
          plVar3 = (int64 *)FUN_1800d60b0(DAT_181d80cc0,1);
          if (plVar3 == (int64 *)0) throw; // [null/range check failed]
          if ((key != null) &&
             (lVar2 = il2cpp_internal(key,*(uint64 *)(*plVar3 + 64))) == null) {
            uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar7,0);
          }
          if ((int)plVar3[3] == 0) {
            uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar7,0);
          }
          plVar3[4] = key;
          il2cpp_internal(plVar3 + 4,key);
          puVar8 = (uint64 *)(pStatics + 24);
          *puVar8 = plVar3;
          il2cpp_internal(puVar8,plVar3);
          lVar2 = *(int64 *)(pStatics + 24);
        }
        local_a8 = lVar2;
        if (lVar2 != null) {
          iVar10 = *(int *)(lVar2 + 24);
          if (0 < iVar10) {
            do {
              if (*(uint32 *)(lVar2 + 24) <= uVar9) {
                uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar7,0);
              }
              cVar1 = FUN_1816fd990(lVar2[uVar9],key,0);
              if (cVar1) {
                lVar4 = *(int64 *)(pStatics + 40);
                if (lVar4 == null) throw; // [null/range check failed]
                cVar1 = FUN_1808addd0(lVar4,value,&local_c8,DAT_181da2bf8);
                if (!cVar1) {
                  local_c8 = (int64 *)FUN_1800d60b0(DAT_181d80cc0,*(uint32 *)(lVar2 + 24));
                  lVar2 = *(int64 *)(pStatics + 40);
                  if ((lVar2 == null) ||
                     (FUN_1808aec90(lVar2,value,local_c8,DAT_181da2cf8), plVar3 = local_c8,
                     local_c8 == (int64 *)0)) throw; // [null/range check failed]
                  if ((param_3 != 0) &&
                     (lVar2 = il2cpp_internal(param_3,*(uint64 *)(*local_c8 + 64))) == null)
                  {
                    uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                    FUN_1800d65f0(uVar7,0);
                  }
                  if ((int)plVar3[3] == 0) {
                    uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                    FUN_1800d65f0(uVar7,0);
                  }
                  plVar3 = plVar3 + 4;
                  *plVar3 = param_3;
                  il2cpp_internal(plVar3,param_3);
                }
                plVar3 = local_c8;
                if (local_c8 != (int64 *)0) {
                  if ((param_3 != 0) &&
                     (lVar2 = il2cpp_internal(param_3,*(uint64 *)(*local_c8 + 64))) == null)
                  {
                    uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                    FUN_1800d65f0(uVar7,0);
                  }
                  FUN_180002fd0(plVar3,(int64)(int)uVar9,param_3);
                  return;
                }
                throw; // [null/range check failed]
              }
              uVar9 = uVar9 + 1;
            } while ((int)uVar9 < iVar10);
          }
          plVar3 = (int64 *)(pStatics + 24);
          lVar4 = *plVar3;
          if (lVar4 != null) {
            uVar9 = *(uint32 *)(lVar4 + 24);
            iVar10 = uVar9 + 1;
            local_b0 = uVar9;
            Array.Resize(plVar3,iVar10,DAT_181d54838);
            plVar3 = *(int64 **)(pStatics + 24);
            if (plVar3 != (int64 *)0) {
              if ((key != null) &&
                 (lVar4 = il2cpp_internal(key,*(uint64 *)(*plVar3 + 64))) == null) {
                uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar7,0);
              }
              if (*(uint32 *)(plVar3 + 3) <= uVar9) {
                uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar7,0);
              }
              plVar3[(int64)iVar10 + 3] = key;
              il2cpp_internal(plVar3 + (int64)iVar10 + 3,key);
              lVar5 = il2cpp_internal(DAT_181d5de48);
              FUN_1808ae540(lVar5,DAT_181da2978);
              lVar4 = *(int64 *)(pStatics + 40);
              local_90 = lVar5;
              if (lVar4 != null) {
                FUN_1808abcf0(&local_58,lVar4,DAT_181da2b78);
                local_88 = local_58;
                uStack_80 = uStack_50;
                local_78 = local_48;
                plStack_70 = plStack_40;
                local_68 = local_38;
                while (cVar1 = FUN_1811d8ad0(&local_88,DAT_181d7a528), cVar1) {
                  local_a0 = local_78;
                  plStack_98 = plStack_70;
                  local_b8 = plStack_70;
                  Array.Resize(&local_b8,iVar10,DAT_181d54838);
                  plVar3 = local_b8;
                  if (local_b8 == (int64 *)0) {
                          // WARNING: Subroutine does not return
                    FUN_1800d6620();
                  }
                  if ((int)local_b8[3] == 0) {
                    uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                    FUN_1800d65f0(uVar7,0);
                  }
                  lVar4 = local_b8[4];
                  if ((lVar4 != null) &&
                     (lVar6 = il2cpp_internal(lVar4,*(uint64 *)(*local_b8 + 64))) == null) {
                    uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                    FUN_1800d65f0(uVar7,0);
                  }
                  if (*(uint32 *)(plVar3 + 3) <= uVar9) {
                    uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                    FUN_1800d65f0(uVar7,0);
                  }
                  plVar3 = plVar3 + (int64)(int)uVar9 + 4;
                  *plVar3 = lVar4;
                  il2cpp_internal(plVar3,lVar4);
                  if (lVar5 == null) {
                          // WARNING: Subroutine does not return
                    FUN_1800d6620();
                  }
                  FUN_1808ab680(lVar5,local_a0,local_b8,DAT_181da29f8);
                }
                ZhSegment.Initialize(&local_88,DAT_181d7a4a8);
                plVar3 = (int64 *)(pStatics + 40);
                *plVar3 = lVar5;
                il2cpp_internal(plVar3,lVar5);
                lVar4 = *(int64 *)(pStatics + 40);
                if (lVar4 != null) {
                  cVar1 = FUN_1808addd0(lVar4,value,&local_c0,DAT_181da2bf8);
                  if (!cVar1) {
                    local_c0 = (int64 *)FUN_1800d60b0(DAT_181d80cc0,*(uint32 *)(lVar2 + 24));
                    lVar2 = *(int64 *)(pStatics + 40);
                    if ((lVar2 == null) ||
                       (FUN_1808aec90(lVar2,value,local_c0,DAT_181da2cf8), plVar3 = local_c0,
                       local_c0 == (int64 *)0)) throw; // [null/range check failed]
                    if ((param_3 != 0) &&
                       (lVar2 = il2cpp_internal(param_3,*(uint64 *)(*local_c0 + 64)), lVar2 == null
                       )) {
                      uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                      FUN_1800d65f0(uVar7,0);
                    }
                    if ((int)plVar3[3] == 0) {
                      uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                      FUN_1800d65f0(uVar7,0);
                    }
                    plVar3 = plVar3 + 4;
                    *plVar3 = param_3;
                    il2cpp_internal(plVar3,param_3);
                  }
                  plVar3 = local_c0;
                  if (local_c0 != (int64 *)0) {
                    if ((param_3 != 0) &&
                       (lVar2 = il2cpp_internal(param_3,*(uint64 *)(*local_c0 + 64)), lVar2 == null
                       )) {
                      uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                      FUN_1800d65f0(uVar7,0);
                    }
                    if (uVar9 < *(uint32 *)(plVar3 + 3)) {
                      plVar3 = plVar3 + (int64)(int)uVar9 + 4;
                      *plVar3 = param_3;
                      il2cpp_internal(plVar3,param_3);
                      return;
                    }
                    uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                    FUN_1800d65f0(uVar7,0);
                  }
                }
              }
            }
          }
        }
    }

    // Token : 0x6000336
    // RVA   : 0xA87F00   Offset: 0xA86700   Length: 0x6DD
    public static bool Has(string key)
    {
        var pStatics = *(int64*)(DAT_181d61a70 + 184);
        long lVar1;
        bool cVar2;
        int iVar3;
        ulong uVar4;
        uint uVar5;
        cVar2 = FUN_180d6ca90(key,0);
        if (cVar2) {
          return false;
        }
        if (*(char *)(pStatics + 16) == false) {
          uVar4 = PlayerPrefs.GetString("Language","English",0);
          Localization.LoadDictionary(uVar4,0,0);
        }
        if (*(int64 *)(pStatics + 24) == 0) {
          return false;
        }
        uVar4 = Localization.get_language(0);
        if (*(int *)(pStatics + 56) == -1) {
          uVar5 = 0;
          while( true ) {
            lVar1 = *(int64 *)(pStatics + 24);
            if (lVar1 == null) goto LAB_180a885d8;
            if (*(int *)(lVar1 + 24) <= (int)uVar5) goto LAB_180a88154;
            lVar1 = *(int64 *)(pStatics + 24);
            if (lVar1 == null) goto LAB_180a885d8;
            if (*(uint32 *)(lVar1 + 24) <= uVar5) {
              uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar4,0);
            }
            cVar2 = FUN_1816fd990(lVar1[uVar5],uVar4,0);
            if (cVar2) break;
            uVar5 = uVar5 + 1;
          }
          *(uint32 *)(pStatics + 56) = uVar5;
        }
        LAB_180a88154:
        if (*(int *)(pStatics + 56) == -1) {
          *(uint32 *)(pStatics + 56) = 0;
          lVar1 = *(int64 *)(pStatics + 24);
          if (lVar1 == null) goto LAB_180a885d8;
          if (*(int *)(lVar1 + 24) == 0) {
            uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar4,0);
          }
          *(uint64 *)(pStatics + 64) = *(uint64 *)(lVar1 + 32);
        }
        iVar3 = UICamera.get_currentScheme(0);
        if (iVar3 == 1) {
          uVar4 = String.Concat(key," Mobile",0);
          lVar1 = *(int64 *)(pStatics + 48);
          if (lVar1 == null) goto LAB_180a885d8;
          cVar2 = FUN_1808ab750(lVar1,uVar4,DAT_181d4f858);
          if (cVar2) {
            return true;
          }
          if (*(int *)(pStatics + 56) != -1) {
            lVar1 = *(int64 *)(pStatics + 40);
            if (lVar1 == null) goto LAB_180a885d8;
            cVar2 = FUN_1808ab750(lVar1,uVar4,DAT_181da2af8);
            if (cVar2) {
              return true;
            }
          }
          lVar1 = *(int64 *)(pStatics + 32);
          if (lVar1 == null) goto LAB_180a885d8;
          cVar2 = FUN_1808ab750(lVar1,uVar4,DAT_181d4f858);
        joined_r0x000180a8847b:
          if (cVar2) {
            return true;
          }
        }
        else if (iVar3 == 2) {
          uVar4 = String.Concat(key," Controller",0);
          lVar1 = *(int64 *)(pStatics + 48);
          if (lVar1 == null) goto LAB_180a885d8;
          cVar2 = FUN_1808ab750(lVar1,uVar4,DAT_181d4f858);
          if (cVar2) {
            return true;
          }
          if (*(int *)(pStatics + 56) != -1) {
            lVar1 = *(int64 *)(pStatics + 40);
            if (lVar1 == null) goto LAB_180a885d8;
            cVar2 = FUN_1808ab750(lVar1,uVar4,DAT_181da2af8);
            if (cVar2) {
              return true;
            }
          }
          lVar1 = *(int64 *)(pStatics + 32);
          if (lVar1 == null) goto LAB_180a885d8;
          cVar2 = FUN_1808ab750(lVar1,uVar4,DAT_181d4f858);
          goto joined_r0x000180a8847b;
        }
        lVar1 = *(int64 *)(pStatics + 48);
        if (lVar1 == null) {
        LAB_180a885d8:
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
        cVar2 = FUN_1808ab750(lVar1,key,DAT_181d4f858);
        if (!cVar2) {
          if (*(int *)(pStatics + 56) != -1) {
            lVar1 = *(int64 *)(pStatics + 40);
            if (lVar1 == null) goto LAB_180a885d8;
            cVar2 = FUN_1808ab750(lVar1,key,DAT_181da2af8);
            if (cVar2) {
              return true;
            }
          }
          lVar1 = *(int64 *)(pStatics + 32);
          if (lVar1 == null) goto LAB_180a885d8;
          cVar2 = FUN_1808ab750(lVar1,key,DAT_181d4f858);
          if (!cVar2) {
            return false;
          }
        }
        return true;
    }

    // Token : 0x6000337
    // RVA   : 0xA873D0   Offset: 0xA85BD0   Length: 0xA18
    public static string Get(string key, bool warnIfMissing)
    {
        var pStatics = *(int64*)(DAT_181d61a70 + 184);
        bool cVar1;
        int iVar2;
        ulong uVar3;
        uint uVar4;
        long lVar5;
        long local_res8;
        ulong local_res20;
        local_res20 = 0;
        local_res8 = 0;
        cVar1 = FUN_180d6ca90(key,0);
        if (cVar1) {
          return false;
        }
        if (*(char *)(pStatics + 16) == false) {
          uVar3 = PlayerPrefs.GetString("Language","English",0);
          Localization.LoadDictionary(uVar3,0,0);
        }
        if (*(int64 *)(pStatics + 24) == 0) {
          Debug.LogError("No localization data present",0);
          return false;
        }
        uVar3 = Localization.get_language(0);
        if (*(int *)(pStatics + 56) == -1) {
          uVar4 = 0;
          while( true ) {
            lVar5 = *(int64 *)(pStatics + 24);
            if (lVar5 == null) goto LAB_180a87de3;
            if (*(int *)(lVar5 + 24) <= (int)uVar4) goto LAB_180a8765b;
            lVar5 = *(int64 *)(pStatics + 24);
            if (lVar5 == null) goto LAB_180a87de3;
            if (*(uint32 *)(lVar5 + 24) <= uVar4) {
              uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar3,0);
            }
            cVar1 = FUN_1816fd990(lVar5[uVar4],uVar3,0);
            if (cVar1) break;
            uVar4 = uVar4 + 1;
          }
          *(uint32 *)(pStatics + 56) = uVar4;
        }
        LAB_180a8765b:
        if (*(int *)(pStatics + 56) == -1) {
          *(uint32 *)(pStatics + 56) = 0;
          lVar5 = *(int64 *)(pStatics + 24);
          if (lVar5 == null) goto LAB_180a87de3;
          if (*(int *)(lVar5 + 24) == 0) {
            uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar3,0);
          }
          *(uint64 *)(pStatics + 64) = *(uint64 *)(lVar5 + 32);
          uVar3 = String.Concat("Language not found: ",uVar3,0);
          Debug.LogWarning(uVar3,0);
        }
        iVar2 = UICamera.get_currentScheme(0);
        if (iVar2 == 1) {
          uVar3 = String.Concat(key," Mobile",0);
          lVar5 = *(int64 *)(pStatics + 48);
          if (lVar5 == null) goto LAB_180a87de3;
          cVar1 = FUN_1808addd0(lVar5,uVar3,&local_res20,DAT_181d4f9d8);
          if (cVar1) {
            return local_res20;
          }
          if (*(int *)(pStatics + 56) != -1) {
            lVar5 = *(int64 *)(pStatics + 40);
            if (lVar5 == null) goto LAB_180a87de3;
            cVar1 = FUN_1808addd0(lVar5,uVar3,&local_res8,DAT_181da2bf8);
            if (cVar1) {
              lVar5 = local_res8;
              if (local_res8 == 0) goto LAB_180a87de3;
              if (*(int *)(pStatics + 56) < *(int *)(local_res8 + 24)) {
                if (lVar5 != null) {
                  uVar4 = *(uint32 *)(pStatics + 56);
                  if (*(uint32 *)(lVar5 + 24) <= uVar4) {
                    uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                    FUN_1800d65f0(uVar3,0);
                  }
        LAB_180a87ab4:
                  return lVar5[uVar4];
                }
                goto LAB_180a87de3;
              }
            }
          }
          lVar5 = *(int64 *)(pStatics + 32);
          if (lVar5 == null) goto LAB_180a87de3;
          cVar1 = FUN_1808addd0(lVar5,uVar3,&local_res20,DAT_181d4f9d8);
        joined_r0x000180a87b14:
          if (cVar1) {
            return local_res20;
          }
        }
        else if (iVar2 == 2) {
          uVar3 = String.Concat(key," Controller",0);
          lVar5 = *(int64 *)(pStatics + 48);
          if (lVar5 == null) goto LAB_180a87de3;
          cVar1 = FUN_1808addd0(lVar5,uVar3,&local_res20,DAT_181d4f9d8);
          if (cVar1) {
            return local_res20;
          }
          if (*(int *)(pStatics + 56) != -1) {
            lVar5 = *(int64 *)(pStatics + 40);
            if (lVar5 == null) goto LAB_180a87de3;
            cVar1 = FUN_1808addd0(lVar5,uVar3,&local_res8,DAT_181da2bf8);
            if (cVar1) {
              lVar5 = local_res8;
              if (local_res8 == 0) goto LAB_180a87de3;
              if (*(int *)(pStatics + 56) < *(int *)(local_res8 + 24)) {
                if (lVar5 != null) {
                  uVar4 = *(uint32 *)(pStatics + 56);
                  if (*(uint32 *)(lVar5 + 24) <= uVar4) {
                    uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                    FUN_1800d65f0(uVar3,0);
                  }
                  goto LAB_180a87ab4;
                }
                goto LAB_180a87de3;
              }
            }
          }
          lVar5 = *(int64 *)(pStatics + 32);
          if (lVar5 == null) goto LAB_180a87de3;
          cVar1 = FUN_1808addd0(lVar5,uVar3,&local_res20,DAT_181d4f9d8);
          goto joined_r0x000180a87b14;
        }
        lVar5 = *(int64 *)(pStatics + 48);
        if (lVar5 == null) goto LAB_180a87de3;
        cVar1 = FUN_1808addd0(lVar5,key,&local_res20,DAT_181d4f9d8);
        if (!cVar1) {
          if (*(int *)(pStatics + 56) != -1) {
            lVar5 = *(int64 *)(pStatics + 40);
            if (lVar5 == null) goto LAB_180a87de3;
            cVar1 = FUN_1808addd0(lVar5,key,&local_res8,DAT_181da2bf8);
            if (cVar1) {
              lVar5 = local_res8;
              if (local_res8 != 0) {
                if (*(int *)(local_res8 + 24) <= *(int *)(pStatics + 56)) {
                  if (*(int *)(local_res8 + 24) == 0) {
                    uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                    FUN_1800d65f0(uVar3,0);
                  }
                  return *(uint64 *)(local_res8 + 32);
                }
                if (lVar5 != null) {
                  uVar4 = *(uint32 *)(pStatics + 56);
                  if (*(uint32 *)(lVar5 + 24) <= uVar4) {
                    uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                    FUN_1800d65f0(uVar3,0);
                  }
                  uVar3 = lVar5[uVar4];
                  cVar1 = FUN_180d6ca90(uVar3,0);
                  if (cVar1) {
                    if (local_res8 == 0) goto LAB_180a87de3;
                    if (*(int *)(local_res8 + 24) == 0) {
                      uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                      FUN_1800d65f0(uVar3,0);
                    }
                    uVar3 = *(uint64 *)(local_res8 + 32);
                  }
                  return uVar3;
                }
              }
              goto LAB_180a87de3;
            }
          }
          lVar5 = *(int64 *)(pStatics + 32);
          if (lVar5 == null) {
        LAB_180a87de3:
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          cVar1 = FUN_1808addd0(lVar5,key,&local_res20,DAT_181d4f9d8);
          if (!cVar1) {
            return key;
          }
        }
        return local_res20;
    }

    // Token : 0x6000338
    // RVA   : 0xA871B0   Offset: 0xA859B0   Length: 0xE7
    public static string Format(string key, object parameter)
    {
        ulong uVar1;
        uVar1 = Localization.Get(key,1,0);
        uVar1 = String.Format(uVar1,parameter,0);
        return uVar1;
    }

    // Token : 0x6000339
    // RVA   : 0xA870B0   Offset: 0xA858B0   Length: 0xF7
    public static string Format(string key, object arg0, object arg1)
    {
        ulong uVar1;
        uVar1 = Localization.Get(key,1,0);
        uVar1 = String.Format(uVar1,arg0,0);
        return uVar1;
    }

    // Token : 0x600033A
    // RVA   : 0xA86FA0   Offset: 0xA857A0   Length: 0x10F
    public static string Format(string key, object arg0, object arg1, object arg2)
    {
        ulong uVar1;
        uVar1 = Localization.Get(key,1,0);
        uVar1 = String.Format(uVar1,arg0,0);
        return uVar1;
    }

    // Token : 0x600033B
    // RVA   : 0xA872A0   Offset: 0xA85AA0   Length: 0x12D
    public static string Format(string key, object[] parameters)
    {
        ulong uVar1;
        uVar1 = Localization.Get(key,1,0);
        uVar1 = String.Format(uVar1,parameters,0);
        return uVar1;
    }

    // Token : 0x600033C
    // RVA   : 0x216180   Offset: 0x214980   Length: 0x3
    public static bool get_isActive()
    {
        return true;
    }

    // Token : 0x600033D
    // RVA   : 0xA89A20   Offset: 0xA88220   Length: 0x55
    public static string Localize(string key)
    {
        Localization.Get(key,1,0);
    }

    // Token : 0x600033E
    // RVA   : 0xA86A00   Offset: 0xA85200   Length: 0x21D
    public static bool Exists(string key)
    {
        var pStatics = *(int64*)(DAT_181d61a70 + 184);
        long lVar1;
        bool cVar2;
        ulong uVar3;
        if (*(char *)(pStatics + 16) == false) {
          uVar3 = PlayerPrefs.GetString("Language","English",0);
          cVar2 = String.op_Inequality
                            (*(uint64 *)(pStatics + 64),uVar3,0);
          if (cVar2) {
            puVar4 = (uint64 *)(pStatics + 64);
            *puVar4 = uVar3;
            il2cpp_internal(puVar4,uVar3);
            Localization.LoadAndSelect(uVar3,0);
          }
        }
        lVar1 = *(int64 *)(pStatics + 40);
        if (lVar1 != null) {
          cVar2 = FUN_1808ab750(lVar1,key,DAT_181da2af8);
          if (cVar2) {
            return true;
          }
          lVar1 = *(int64 *)(pStatics + 32);
          if (lVar1 != null) {
            uVar3 = FUN_1808ab750(lVar1,key,DAT_181d4f858);
            return uVar3;
          }
        }
    }

    // Token : 0x600033F
    // RVA   : 0xA8A300   Offset: 0xA88B00   Length: 0x854
    public static void Set(string language, string key, string text)
    {
        var pStatics = *(int64*)(DAT_181d61a70 + 184);
        bool cVar1;
        long lVar2;
        long lVar4;
        long lVar5;
        long lVar6;
        ulong uVar7;
        uint uVar9;
        int iVar10;
        uint local_b0;
        long local_a8;
        ulong local_a0;
        long local_90;
        ulong local_88;
        ulong uStack_80;
        ulong local_78;
        ulong local_68;
        ulong local_58;
        ulong uStack_50;
        ulong local_48;
        ulong local_38;
        uVar9 = 0;
        local_c0 = (int64 *)0;
        local_c8 = (int64 *)0;
        local_88 = 0;
        uStack_80 = 0;
        local_78 = 0;
        plStack_70 = (int64 *)0;
        local_68 = 0;
        local_b8 = (int64 *)0;
        lVar2 = Localization.get_knownLanguages(0);
        if (lVar2 == null) {
          local_a8 = lVar2;
          plVar3 = (int64 *)FUN_1800d60b0(DAT_181d80cc0,1);
          if (plVar3 == (int64 *)0) throw; // [null/range check failed]
          if ((language != null) &&
             (lVar2 = il2cpp_internal(language,*(uint64 *)(*plVar3 + 64))) == null) {
            uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar7,0);
          }
          if ((int)plVar3[3] == 0) {
            uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar7,0);
          }
          plVar3[4] = language;
          il2cpp_internal(plVar3 + 4,language);
          puVar8 = (uint64 *)(pStatics + 24);
          *puVar8 = plVar3;
          il2cpp_internal(puVar8,plVar3);
          lVar2 = *(int64 *)(pStatics + 24);
        }
        local_a8 = lVar2;
        if (lVar2 != null) {
          iVar10 = *(int *)(lVar2 + 24);
          if (0 < iVar10) {
            do {
              if (*(uint32 *)(lVar2 + 24) <= uVar9) {
                uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar7,0);
              }
              cVar1 = FUN_1816fd990(lVar2[uVar9],language,0);
              if (cVar1) {
                lVar4 = *(int64 *)(pStatics + 40);
                if (lVar4 == null) throw; // [null/range check failed]
                cVar1 = FUN_1808addd0(lVar4,key,&local_c8,DAT_181da2bf8);
                if (!cVar1) {
                  local_c8 = (int64 *)FUN_1800d60b0(DAT_181d80cc0,*(uint32 *)(lVar2 + 24));
                  lVar2 = *(int64 *)(pStatics + 40);
                  if ((lVar2 == null) ||
                     (FUN_1808aec90(lVar2,key,local_c8,DAT_181da2cf8), plVar3 = local_c8,
                     local_c8 == (int64 *)0)) throw; // [null/range check failed]
                  if ((text != null) &&
                     (lVar2 = il2cpp_internal(text,*(uint64 *)(*local_c8 + 64))) == null)
                  {
                    uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                    FUN_1800d65f0(uVar7,0);
                  }
                  if ((int)plVar3[3] == 0) {
                    uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                    FUN_1800d65f0(uVar7,0);
                  }
                  plVar3 = plVar3 + 4;
                  *plVar3 = text;
                  il2cpp_internal(plVar3,text);
                }
                plVar3 = local_c8;
                if (local_c8 != (int64 *)0) {
                  if ((text != null) &&
                     (lVar2 = il2cpp_internal(text,*(uint64 *)(*local_c8 + 64))) == null)
                  {
                    uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                    FUN_1800d65f0(uVar7,0);
                  }
                  FUN_180002fd0(plVar3,(int64)(int)uVar9,text);
                  return;
                }
                throw; // [null/range check failed]
              }
              uVar9 = uVar9 + 1;
            } while ((int)uVar9 < iVar10);
          }
          plVar3 = (int64 *)(pStatics + 24);
          lVar4 = *plVar3;
          if (lVar4 != null) {
            uVar9 = *(uint32 *)(lVar4 + 24);
            iVar10 = uVar9 + 1;
            local_b0 = uVar9;
            Array.Resize(plVar3,iVar10,DAT_181d54838);
            plVar3 = *(int64 **)(pStatics + 24);
            if (plVar3 != (int64 *)0) {
              if ((language != null) &&
                 (lVar4 = il2cpp_internal(language,*(uint64 *)(*plVar3 + 64))) == null) {
                uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar7,0);
              }
              if (*(uint32 *)(plVar3 + 3) <= uVar9) {
                uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar7,0);
              }
              plVar3[(int64)iVar10 + 3] = language;
              il2cpp_internal(plVar3 + (int64)iVar10 + 3,language);
              lVar5 = il2cpp_internal(DAT_181d5de48);
              FUN_1808ae540(lVar5,DAT_181da2978);
              lVar4 = *(int64 *)(pStatics + 40);
              local_90 = lVar5;
              if (lVar4 != null) {
                FUN_1808abcf0(&local_58,lVar4,DAT_181da2b78);
                local_88 = local_58;
                uStack_80 = uStack_50;
                local_78 = local_48;
                plStack_70 = plStack_40;
                local_68 = local_38;
                while (cVar1 = FUN_1811d8ad0(&local_88,DAT_181d7a528), cVar1) {
                  local_a0 = local_78;
                  plStack_98 = plStack_70;
                  local_b8 = plStack_70;
                  Array.Resize(&local_b8,iVar10,DAT_181d54838);
                  plVar3 = local_b8;
                  if (local_b8 == (int64 *)0) {
                          // WARNING: Subroutine does not return
                    FUN_1800d6620();
                  }
                  if ((int)local_b8[3] == 0) {
                    uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                    FUN_1800d65f0(uVar7,0);
                  }
                  lVar4 = local_b8[4];
                  if ((lVar4 != null) &&
                     (lVar6 = il2cpp_internal(lVar4,*(uint64 *)(*local_b8 + 64))) == null) {
                    uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                    FUN_1800d65f0(uVar7,0);
                  }
                  if (*(uint32 *)(plVar3 + 3) <= uVar9) {
                    uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                    FUN_1800d65f0(uVar7,0);
                  }
                  plVar3 = plVar3 + (int64)(int)uVar9 + 4;
                  *plVar3 = lVar4;
                  il2cpp_internal(plVar3,lVar4);
                  if (lVar5 == null) {
                          // WARNING: Subroutine does not return
                    FUN_1800d6620();
                  }
                  FUN_1808ab680(lVar5,local_a0,local_b8,DAT_181da29f8);
                }
                ZhSegment.Initialize(&local_88,DAT_181d7a4a8);
                plVar3 = (int64 *)(pStatics + 40);
                *plVar3 = lVar5;
                il2cpp_internal(plVar3,lVar5);
                lVar4 = *(int64 *)(pStatics + 40);
                if (lVar4 != null) {
                  cVar1 = FUN_1808addd0(lVar4,key,&local_c0,DAT_181da2bf8);
                  if (!cVar1) {
                    local_c0 = (int64 *)FUN_1800d60b0(DAT_181d80cc0,*(uint32 *)(lVar2 + 24));
                    lVar2 = *(int64 *)(pStatics + 40);
                    if ((lVar2 == null) ||
                       (FUN_1808aec90(lVar2,key,local_c0,DAT_181da2cf8), plVar3 = local_c0,
                       local_c0 == (int64 *)0)) throw; // [null/range check failed]
                    if ((text != null) &&
                       (lVar2 = il2cpp_internal(text,*(uint64 *)(*local_c0 + 64)), lVar2 == null
                       )) {
                      uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                      FUN_1800d65f0(uVar7,0);
                    }
                    if ((int)plVar3[3] == 0) {
                      uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                      FUN_1800d65f0(uVar7,0);
                    }
                    plVar3 = plVar3 + 4;
                    *plVar3 = text;
                    il2cpp_internal(plVar3,text);
                  }
                  plVar3 = local_c0;
                  if (local_c0 != (int64 *)0) {
                    if ((text != null) &&
                       (lVar2 = il2cpp_internal(text,*(uint64 *)(*local_c0 + 64)), lVar2 == null
                       )) {
                      uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                      FUN_1800d65f0(uVar7,0);
                    }
                    if (uVar9 < *(uint32 *)(plVar3 + 3)) {
                      plVar3 = plVar3 + (int64)(int)uVar9 + 4;
                      *plVar3 = text;
                      il2cpp_internal(plVar3,text);
                      return;
                    }
                    uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                    FUN_1800d65f0(uVar7,0);
                  }
                }
              }
            }
          }
        }
    }

    // Token : 0x6000340
    // RVA   : 0xA8AC10   Offset: 0xA89410   Length: 0x162
    private static void /*cctor*/()
    {
        var pStatics = *(int64*)(DAT_181d61a70 + 184);
        ulong uVar1;
        *(uint8 *)(pStatics + 16) = 0;
        puVar2 = (uint64 *)(pStatics + 24);
        *puVar2 = 0;
        il2cpp_internal(puVar2,0);
        uVar1 = il2cpp_internal(DAT_181d5e848);
        FUN_1808ae540(uVar1,DAT_181d4f5d8);
        puVar2 = (uint64 *)(pStatics + 32);
        *puVar2 = uVar1;
        il2cpp_internal(puVar2,uVar1);
        uVar1 = il2cpp_internal(DAT_181d5de48);
        FUN_1808ae540(uVar1,DAT_181da2978);
        puVar2 = (uint64 *)(pStatics + 40);
        *puVar2 = uVar1;
        il2cpp_internal(puVar2,uVar1);
        uVar1 = il2cpp_internal(DAT_181d5e848);
        FUN_1808ae540(uVar1,DAT_181d4f5d8);
        puVar2 = (uint64 *)(pStatics + 48);
        *puVar2 = uVar1;
        il2cpp_internal(puVar2,uVar1);
        *(uint32 *)(pStatics + 56) = 0xffffffff;
        *(uint8 *)(pStatics + 72) = 0;
    }

}
