// ============================================================
// Type  : NGUITools
// Token : 0x200008B
// ============================================================

public class NGUITools
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x400034B
    private static AudioListener mListener;

    // Token: 0x400034C
    public static AudioSource audioSource;

    // Token: 0x400034D
    private static bool mLoaded;

    // Token: 0x400034E
    private static float mGlobalVolume;

    // Token: 0x400034F
    private static float mLastTimestamp;

    // Token: 0x4000350
    private static AudioClip mLastClip;

    // Token: 0x4000351
    private static Dictionary<Type, string> mTypeNames;

    // Token: 0x4000352
    private static Vector3[] mSides;

    // Token: 0x4000353
    public static KeyCode[] keys;

    // Token: 0x4000354
    private static Dictionary<string, UIWidget> mWidgets;

    // Token: 0x4000355
    private static UIPanel mRoot;

    // Token: 0x4000356
    private static GameObject mGo;

    // Token: 0x4000357
    private static ColorSpace mColorSpace;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60003B2
    // RVA   : 0x159E220   Offset: 0x159CA20   Length: 0xF8
    public static float get_soundVolume()
    {
        var pStatics = *(int64*)(DAT_181d66af0 + 184);
        uint uVar1;
        if (*(char *)(pStatics + 16) == false) {
          *(uint8 *)(pStatics + 16) = 1;
          uVar1 = PlayerPrefs.GetFloat("Sound",0x3f800000,0);
          *(uint32 *)(pStatics + 20) = uVar1;
        }
        if (((*(byte *)(DAT_181d66af0 + 0x133) & 4) != 0) && (*(int *)(DAT_181d66af0 + 224) == 0)) {
          il2cpp_runtime_class_init();
          return *(uint32 *)(pStatics + 20);
        }
        return *(uint32 *)(pStatics + 20);
    }

    // Token : 0x60003B3
    // RVA   : 0x159E3A0   Offset: 0x159CBA0   Length: 0xC4
    public static void set_soundVolume(float value)
    {
        var pStatics = *(int64*)(DAT_181d66af0 + 184);
        if (*(float *)(pStatics + 20) != value) {
          *(uint8 *)(pStatics + 16) = 1;
          *(float *)(pStatics + 20) = value;
          PlayerPrefs.SetFloat("Sound",value,0);
        }
    }

    // Token : 0x60003B4
    // RVA   : 0x159E1C0   Offset: 0x159C9C0   Length: 0x16
    public static bool get_fileAccess()
    {
        int iVar1;
        iVar1 = Application.get_platform(0);
        return iVar1 != 17;
    }

    // Token : 0x60003B5
    // RVA   : 0x159BAA0   Offset: 0x159A2A0   Length: 0x5E
    public static AudioSource PlaySound(AudioClip clip)
    {
        var pStatics = *(int64*)(DAT_181d66af0 + 184);
        bool cVar1;
        ulong uVar2;
        long lVar3;
        uint uVar7;
        float fVar8;
        fVar8 = (float)RealTime.get_time(0);
        uVar2 = *(uint64 *)(pStatics + 32);
        cVar1 = Object.op_Equality(uVar2,clip,0);
        if (cVar1) {
          if (fVar8 < *(float *)(pStatics + 24) + 0.1) {
            return 0;
          }
        }
        puVar6 = (uint64 *)(pStatics + 32);
        *puVar6 = clip;
        il2cpp_internal(puVar6,clip);
        *(float *)(pStatics + 24) = fVar8;
        param_2 = param_2 * *(float *)(*(int64 *)(DAT_181d4e010 + 184) + 16);
        cVar1 = Object.op_Inequality(clip,0,0);
        if (!cVar1) {
          return 0;
        }
        if (param_2 <= 0.01) {
          return 0;
        }
        uVar2 = **(uint64 **)(DAT_181d66af0 + 184);
        cVar1 = Object.op_Equality(uVar2,0,0);
        if (!cVar1) {
          cVar1 = NGUITools.GetActive(**(uint64 **)(DAT_181d66af0 + 184),0);
          if (!(!cVar1))
          {
            }
            else {
          }
          uVar2 = DAT_181d8fd98;
          uVar2 = Type.GetTypeFromHandle(uVar2,0);
          uVar2 = Object.FindObjectsOfType(uVar2,0);
          lVar3 = il2cpp_internal(uVar2);
          if (lVar3 != null) {
            for (uVar7 = 0; (int)uVar7 < (int)*(uint32 *)(lVar3 + 24); uVar7 = uVar7 + 1) {
              if (*(uint32 *)(lVar3 + 24) <= uVar7) {
                uVar2 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar2,0);
              }
              uVar2 = lVar3[uVar7];
              cVar1 = NGUITools.GetActive(uVar2,0);
              if (cVar1) {
                if (*(uint32 *)(lVar3 + 24) <= uVar7) {
                  uVar2 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1800d65f0(uVar2,0);
                }
                uVar2 = lVar3[uVar7];
                puVar6 = *(uint64 **)(DAT_181d66af0 + 184);
                *puVar6 = uVar2;
                il2cpp_internal(puVar6,uVar2);
                break;
              }
            }
          }
          uVar2 = **(uint64 **)(DAT_181d66af0 + 184);
          cVar1 = Object.op_Equality(uVar2,0,0);
          if (cVar1) {
            plVar4 = (int64 *)Camera.get_main(0);
            cVar1 = Object.op_Equality(plVar4,0,0);
            uVar2 = DAT_181d90be0;
            if (cVar1) {
              uVar2 = Type.GetTypeFromHandle(uVar2,0);
              plVar5 = (int64 *)Object.FindObjectOfType(uVar2,0);
              plVar4 = (int64 *)0;
              if ((plVar5 != (int64 *)0) && (*plVar5 == DAT_181d90e30)) {
                plVar4 = plVar5;
              }
            }
            cVar1 = Object.op_Inequality(plVar4,0,0);
            if (cVar1) {
              if ((plVar4 == (int64 *)0) || (lVar3 = Component.get_gameObject(plVar4,0)) == null
                 ) throw; // [null/range check failed]
              uVar2 = GameObject.AddComponent(lVar3,DAT_181d9be90);
              puVar6 = *(uint64 **)(DAT_181d66af0 + 184);
              *puVar6 = uVar2;
              il2cpp_internal(puVar6,uVar2);
            }
          }
        }
        uVar2 = **(uint64 **)(DAT_181d66af0 + 184);
        cVar1 = Object.op_Inequality(uVar2,0,0);
        if (!cVar1) {
          return 0;
        }
        if (*pStatics != 0) {
          cVar1 = Behaviour.get_enabled(*pStatics,0);
          if (!cVar1) {
            return 0;
          }
          if (*pStatics != 0) {
            lVar3 = Component.get_gameObject(*pStatics,0);
            cVar1 = Object.op_Implicit(lVar3,0);
            if (!cVar1) {
              return 0;
            }
            if (lVar3 != null) {
              cVar1 = GameObject.get_activeInHierarchy(lVar3,0);
              if (!cVar1) {
                return 0;
              }
              uVar2 = *(uint64 *)(pStatics + 8);
              cVar1 = Object.op_Implicit(uVar2,0);
              if (!cVar1) {
                if (*pStatics == 0) throw; // [null/range check failed]
                uVar2 = Component.GetComponent(*pStatics,DAT_181d6ab40);
                puVar6 = (uint64 *)(pStatics + 8);
                *puVar6 = uVar2;
                il2cpp_internal(puVar6,uVar2);
                uVar2 = *(uint64 *)(pStatics + 8);
                cVar1 = Object.op_Equality(uVar2,0,0);
                if (cVar1) {
                  if ((*pStatics == 0) ||
                     (lVar3 = Component.get_gameObject(*pStatics,0),
                     lVar3 == null)) throw; // [null/range check failed]
                  uVar2 = GameObject.AddComponent(lVar3,DAT_181d9bf18);
                  puVar6 = (uint64 *)(pStatics + 8);
                  *puVar6 = uVar2;
                  il2cpp_internal(puVar6,uVar2);
                }
              }
              lVar3 = *(int64 *)(pStatics + 8);
              if (lVar3 != null) {
                AudioSource.set_priority(lVar3,50);
                lVar3 = *(int64 *)(pStatics + 8);
                if (lVar3 != null) {
                  FUN_180467590(lVar3,param_3,0);
                  lVar3 = *(int64 *)(pStatics + 8);
                  if (lVar3 != null) {
                    AudioSource.PlayOneShot(lVar3,clip,param_2,0);
                    return *(uint64 *)(pStatics + 8);
                  }
                }
              }
            }
          }
        }
    }

    // Token : 0x60003B6
    // RVA   : 0x159B0D0   Offset: 0x15998D0   Length: 0x6B
    public static AudioSource PlaySound(AudioClip clip, float volume)
    {
        var pStatics = *(int64*)(DAT_181d66af0 + 184);
        bool cVar1;
        ulong uVar2;
        long lVar3;
        uint uVar7;
        float fVar8;
        fVar8 = (float)RealTime.get_time(0);
        uVar2 = *(uint64 *)(pStatics + 32);
        cVar1 = Object.op_Equality(uVar2,clip,0);
        if (cVar1) {
          if (fVar8 < *(float *)(pStatics + 24) + 0.1) {
            return 0;
          }
        }
        puVar6 = (uint64 *)(pStatics + 32);
        *puVar6 = clip;
        il2cpp_internal(puVar6,clip);
        *(float *)(pStatics + 24) = fVar8;
        volume = volume * *(float *)(*(int64 *)(DAT_181d4e010 + 184) + 16);
        cVar1 = Object.op_Inequality(clip,0,0);
        if (!cVar1) {
          return 0;
        }
        if (volume <= 0.01) {
          return 0;
        }
        uVar2 = **(uint64 **)(DAT_181d66af0 + 184);
        cVar1 = Object.op_Equality(uVar2,0,0);
        if (!cVar1) {
          cVar1 = NGUITools.GetActive(**(uint64 **)(DAT_181d66af0 + 184),0);
          if (!(!cVar1))
          {
            }
            else {
          }
          uVar2 = DAT_181d8fd98;
          uVar2 = Type.GetTypeFromHandle(uVar2,0);
          uVar2 = Object.FindObjectsOfType(uVar2,0);
          lVar3 = il2cpp_internal(uVar2);
          if (lVar3 != null) {
            for (uVar7 = 0; (int)uVar7 < (int)*(uint32 *)(lVar3 + 24); uVar7 = uVar7 + 1) {
              if (*(uint32 *)(lVar3 + 24) <= uVar7) {
                uVar2 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar2,0);
              }
              uVar2 = lVar3[uVar7];
              cVar1 = NGUITools.GetActive(uVar2,0);
              if (cVar1) {
                if (*(uint32 *)(lVar3 + 24) <= uVar7) {
                  uVar2 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1800d65f0(uVar2,0);
                }
                uVar2 = lVar3[uVar7];
                puVar6 = *(uint64 **)(DAT_181d66af0 + 184);
                *puVar6 = uVar2;
                il2cpp_internal(puVar6,uVar2);
                break;
              }
            }
          }
          uVar2 = **(uint64 **)(DAT_181d66af0 + 184);
          cVar1 = Object.op_Equality(uVar2,0,0);
          if (cVar1) {
            plVar4 = (int64 *)Camera.get_main(0);
            cVar1 = Object.op_Equality(plVar4,0,0);
            uVar2 = DAT_181d90be0;
            if (cVar1) {
              uVar2 = Type.GetTypeFromHandle(uVar2,0);
              plVar5 = (int64 *)Object.FindObjectOfType(uVar2,0);
              plVar4 = (int64 *)0;
              if ((plVar5 != (int64 *)0) && (*plVar5 == DAT_181d90e30)) {
                plVar4 = plVar5;
              }
            }
            cVar1 = Object.op_Inequality(plVar4,0,0);
            if (cVar1) {
              if ((plVar4 == (int64 *)0) || (lVar3 = Component.get_gameObject(plVar4,0)) == null
                 ) throw; // [null/range check failed]
              uVar2 = GameObject.AddComponent(lVar3,DAT_181d9be90);
              puVar6 = *(uint64 **)(DAT_181d66af0 + 184);
              *puVar6 = uVar2;
              il2cpp_internal(puVar6,uVar2);
            }
          }
        }
        uVar2 = **(uint64 **)(DAT_181d66af0 + 184);
        cVar1 = Object.op_Inequality(uVar2,0,0);
        if (!cVar1) {
          return 0;
        }
        if (*pStatics != 0) {
          cVar1 = Behaviour.get_enabled(*pStatics,0);
          if (!cVar1) {
            return 0;
          }
          if (*pStatics != 0) {
            lVar3 = Component.get_gameObject(*pStatics,0);
            cVar1 = Object.op_Implicit(lVar3,0);
            if (!cVar1) {
              return 0;
            }
            if (lVar3 != null) {
              cVar1 = GameObject.get_activeInHierarchy(lVar3,0);
              if (!cVar1) {
                return 0;
              }
              uVar2 = *(uint64 *)(pStatics + 8);
              cVar1 = Object.op_Implicit(uVar2,0);
              if (!cVar1) {
                if (*pStatics == 0) throw; // [null/range check failed]
                uVar2 = Component.GetComponent(*pStatics,DAT_181d6ab40);
                puVar6 = (uint64 *)(pStatics + 8);
                *puVar6 = uVar2;
                il2cpp_internal(puVar6,uVar2);
                uVar2 = *(uint64 *)(pStatics + 8);
                cVar1 = Object.op_Equality(uVar2,0,0);
                if (cVar1) {
                  if ((*pStatics == 0) ||
                     (lVar3 = Component.get_gameObject(*pStatics,0),
                     lVar3 == null)) throw; // [null/range check failed]
                  uVar2 = GameObject.AddComponent(lVar3,DAT_181d9bf18);
                  puVar6 = (uint64 *)(pStatics + 8);
                  *puVar6 = uVar2;
                  il2cpp_internal(puVar6,uVar2);
                }
              }
              lVar3 = *(int64 *)(pStatics + 8);
              if (lVar3 != null) {
                AudioSource.set_priority(lVar3,50);
                lVar3 = *(int64 *)(pStatics + 8);
                if (lVar3 != null) {
                  FUN_180467590(lVar3,param_3,0);
                  lVar3 = *(int64 *)(pStatics + 8);
                  if (lVar3 != null) {
                    AudioSource.PlayOneShot(lVar3,clip,volume,0);
                    return *(uint64 *)(pStatics + 8);
                  }
                }
              }
            }
          }
        }
    }

    // Token : 0x60003B7
    // RVA   : 0x159B140   Offset: 0x1599940   Length: 0x95B
    public static AudioSource PlaySound(AudioClip clip, float volume, float pitch)
    {
        var pStatics = *(int64*)(DAT_181d66af0 + 184);
        bool cVar1;
        ulong uVar2;
        long lVar3;
        uint uVar7;
        float fVar8;
        fVar8 = (float)RealTime.get_time(0);
        uVar2 = *(uint64 *)(pStatics + 32);
        cVar1 = Object.op_Equality(uVar2,clip,0);
        if (cVar1) {
          if (fVar8 < *(float *)(pStatics + 24) + 0.1) {
            return 0;
          }
        }
        puVar6 = (uint64 *)(pStatics + 32);
        *puVar6 = clip;
        il2cpp_internal(puVar6,clip);
        *(float *)(pStatics + 24) = fVar8;
        volume = volume * *(float *)(*(int64 *)(DAT_181d4e010 + 184) + 16);
        cVar1 = Object.op_Inequality(clip,0,0);
        if (!cVar1) {
          return 0;
        }
        if (volume <= 0.01) {
          return 0;
        }
        uVar2 = **(uint64 **)(DAT_181d66af0 + 184);
        cVar1 = Object.op_Equality(uVar2,0,0);
        if (!cVar1) {
          cVar1 = NGUITools.GetActive(**(uint64 **)(DAT_181d66af0 + 184),0);
          if (!(!cVar1))
          {
            }
            else {
          }
          uVar2 = DAT_181d8fd98;
          uVar2 = Type.GetTypeFromHandle(uVar2,0);
          uVar2 = Object.FindObjectsOfType(uVar2,0);
          lVar3 = il2cpp_internal(uVar2);
          if (lVar3 != null) {
            for (uVar7 = 0; (int)uVar7 < (int)*(uint32 *)(lVar3 + 24); uVar7 = uVar7 + 1) {
              if (*(uint32 *)(lVar3 + 24) <= uVar7) {
                uVar2 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar2,0);
              }
              uVar2 = lVar3[uVar7];
              cVar1 = NGUITools.GetActive(uVar2,0);
              if (cVar1) {
                if (*(uint32 *)(lVar3 + 24) <= uVar7) {
                  uVar2 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1800d65f0(uVar2,0);
                }
                uVar2 = lVar3[uVar7];
                puVar6 = *(uint64 **)(DAT_181d66af0 + 184);
                *puVar6 = uVar2;
                il2cpp_internal(puVar6,uVar2);
                break;
              }
            }
          }
          uVar2 = **(uint64 **)(DAT_181d66af0 + 184);
          cVar1 = Object.op_Equality(uVar2,0,0);
          if (cVar1) {
            plVar4 = (int64 *)Camera.get_main(0);
            cVar1 = Object.op_Equality(plVar4,0,0);
            uVar2 = DAT_181d90be0;
            if (cVar1) {
              uVar2 = Type.GetTypeFromHandle(uVar2,0);
              plVar5 = (int64 *)Object.FindObjectOfType(uVar2,0);
              plVar4 = (int64 *)0;
              if ((plVar5 != (int64 *)0) && (*plVar5 == DAT_181d90e30)) {
                plVar4 = plVar5;
              }
            }
            cVar1 = Object.op_Inequality(plVar4,0,0);
            if (cVar1) {
              if ((plVar4 == (int64 *)0) || (lVar3 = Component.get_gameObject(plVar4,0)) == null
                 ) throw; // [null/range check failed]
              uVar2 = GameObject.AddComponent(lVar3,DAT_181d9be90);
              puVar6 = *(uint64 **)(DAT_181d66af0 + 184);
              *puVar6 = uVar2;
              il2cpp_internal(puVar6,uVar2);
            }
          }
        }
        uVar2 = **(uint64 **)(DAT_181d66af0 + 184);
        cVar1 = Object.op_Inequality(uVar2,0,0);
        if (!cVar1) {
          return 0;
        }
        if (*pStatics != 0) {
          cVar1 = Behaviour.get_enabled(*pStatics,0);
          if (!cVar1) {
            return 0;
          }
          if (*pStatics != 0) {
            lVar3 = Component.get_gameObject(*pStatics,0);
            cVar1 = Object.op_Implicit(lVar3,0);
            if (!cVar1) {
              return 0;
            }
            if (lVar3 != null) {
              cVar1 = GameObject.get_activeInHierarchy(lVar3,0);
              if (!cVar1) {
                return 0;
              }
              uVar2 = *(uint64 *)(pStatics + 8);
              cVar1 = Object.op_Implicit(uVar2,0);
              if (!cVar1) {
                if (*pStatics == 0) throw; // [null/range check failed]
                uVar2 = Component.GetComponent(*pStatics,DAT_181d6ab40);
                puVar6 = (uint64 *)(pStatics + 8);
                *puVar6 = uVar2;
                il2cpp_internal(puVar6,uVar2);
                uVar2 = *(uint64 *)(pStatics + 8);
                cVar1 = Object.op_Equality(uVar2,0,0);
                if (cVar1) {
                  if ((*pStatics == 0) ||
                     (lVar3 = Component.get_gameObject(*pStatics,0),
                     lVar3 == null)) throw; // [null/range check failed]
                  uVar2 = GameObject.AddComponent(lVar3,DAT_181d9bf18);
                  puVar6 = (uint64 *)(pStatics + 8);
                  *puVar6 = uVar2;
                  il2cpp_internal(puVar6,uVar2);
                }
              }
              lVar3 = *(int64 *)(pStatics + 8);
              if (lVar3 != null) {
                AudioSource.set_priority(lVar3,50);
                lVar3 = *(int64 *)(pStatics + 8);
                if (lVar3 != null) {
                  FUN_180467590(lVar3,pitch,0);
                  lVar3 = *(int64 *)(pStatics + 8);
                  if (lVar3 != null) {
                    AudioSource.PlayOneShot(lVar3,clip,volume,0);
                    return *(uint64 *)(pStatics + 8);
                  }
                }
              }
            }
          }
        }
    }

    // Token : 0x60003B8
    // RVA   : 0x159BBC0   Offset: 0x159A3C0   Length: 0x11
    public static int RandomRange(int min, int max)
    {
        ulong uVar1;
        if (min != max) {
          uVar1 = FUN_180d8cf10(min,max + 1,0);
          return uVar1;
        }
        return (uint64)min;
    }

    // Token : 0x60003B9
    // RVA   : 0x15979C0   Offset: 0x15961C0   Length: 0x158
    public static string GetHierarchy(GameObject obj)
    {
        bool cVar1;
        ulong uVar2;
        long lVar3;
        ulong uVar4;
        cVar1 = Object.op_Equality(obj,0,0);
        if (cVar1) {
          return "";
        }
        if (obj != null) {
          uVar2 = Object.get_name(obj,0);
          while( true ) {
            lVar3 = GameObject.get_transform(obj,0);
            if (lVar3 == null) break;
            uVar4 = FUN_180da0f00(lVar3,0);
            cVar1 = Object.op_Inequality(uVar4,0,0);
            if (!cVar1) {
              return uVar2;
            }
            lVar3 = GameObject.get_transform(obj,0);
            if (lVar3 == null) break;
            lVar3 = FUN_180da0f00(lVar3,0);
            if (lVar3 == null) break;
            obj = Component.get_gameObject(lVar3,0);
            if (obj == null) break;
            uVar4 = Object.get_name(obj,0);
            uVar2 = String.Concat(uVar4,"\\",uVar2,0);
          }
        }
    }

    // Token : 0x60003BA
    // RVA   : 0xDC42A0   Offset: 0xDC2AA0   Length: 0xCA
    public static T[] FindActive<T>()
    {
        long lVar1;
        ulong uVar2;
        uVar2 = **(uint64 **)(param_1 + 48);
        uVar2 = Type.GetTypeFromHandle(uVar2,0);
        uVar2 = Object.FindObjectsOfType(uVar2,0);
        lVar1 = *(int64 *)(*(int64 *)(param_1 + 48) + 8);
        if ((*(byte *)(lVar1 + 0x132) & 1) == 0) {
          FUN_18009a510(lVar1);
        }
        il2cpp_internal(uVar2,lVar1);
    }

    // Token : 0x60003BB
    // RVA   : 0x1596B40   Offset: 0x1595340   Length: 0x277
    public static Camera FindCameraForLayer(int layer)
    {
        var pStatics = *(int64*)(DAT_181d8a458 + 184);
        long lVar1;
        bool cVar2;
        uint uVar3;
        uint uVar4;
        int iVar5;
        long lVar6;
        ulong uVar7;
        uint uVar8;
        uint uVar9;
        uint uVar10;
        uVar9 = 1 << (layer & 31);
        uVar10 = 0;
        uVar8 = 0;
        while( true ) {
          if (*pStatics == 0) goto LAB_181596d92;
          if (*(int *)(*pStatics + 24) <= (int)uVar8) break;
          if ((*pStatics == 0) ||
             (lVar6 = *(int64 *)(*pStatics + 16)) == null)
          goto LAB_181596d92;
          if (*(uint32 *)(lVar6 + 24) <= uVar8) {
            uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar7,0);
          }
          lVar6 = lVar6[uVar8];
          if (lVar6 == null) goto LAB_181596d92;
          lVar6 = UICamera.get_cachedCamera(lVar6,0);
          cVar2 = Object.op_Implicit(lVar6,0);
          if (cVar2) {
            if (lVar6 == null) goto LAB_181596d92;
            uVar3 = Camera.get_cullingMask(lVar6,0);
            if ((uVar9 & uVar3) != 0) {
              return lVar6;
            }
          }
          uVar8 = uVar8 + 1;
        }
        lVar6 = Camera.get_main(0);
        cVar2 = Object.op_Implicit(lVar6,0);
        if (cVar2) {
          if (lVar6 == null) {
        LAB_181596d92:
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          uVar8 = Camera.get_cullingMask(lVar6,0);
          if ((uVar9 & uVar8) != 0) {
            return lVar6;
          }
        }
        uVar4 = FUN_181095430(0);
        lVar6 = FUN_1800d60b0(DAT_181d7bf98,uVar4);
        iVar5 = Camera.GetAllCameras(lVar6,0);
        if (0 < iVar5) {
          do {
            if (lVar6 == null) goto LAB_181596d92;
            if (*(uint32 *)(lVar6 + 24) <= uVar10) {
              uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar7,0);
            }
            lVar1 = lVar6[uVar10];
            cVar2 = Object.op_Implicit(lVar1);
            if (cVar2) {
              if (lVar1 == null) goto LAB_181596d92;
              cVar2 = Behaviour.get_enabled(lVar1);
              if ((cVar2) && (uVar8 = Camera.get_cullingMask(lVar1), (uVar9 & uVar8) != 0)) {
                return lVar1;
              }
            }
            uVar10 = uVar10 + 1;
          } while ((int)uVar10 < iVar5);
        }
        return 0;
    }

    // Token : 0x60003BC
    // RVA   : 0x15928A0   Offset: 0x15910A0   Length: 0x55
    public static void AddWidgetCollider(GameObject go)
    {
        bool cVar2;
        uint uVar3;
        ulong uVar5;
        long lVar6;
        long lVar7;
        cVar2 = Object.op_Inequality(go,0,0);
        if (!cVar2) {
          return;
        }
        if (go == null) goto LAB_181592d0d;
        plVar4 = (int64 *)GameObject.GetComponent(go,DAT_181d9f328);
        if (plVar4 == (int64 *)0) {
          plVar8 = (int64 *)0;
        }
        else {
          plVar8 = plVar4;
        }
        cVar2 = Object.op_Inequality(plVar8,0,0);
        if (!cVar2) {
          cVar2 = Object.op_Inequality(plVar4,0,0);
          if (cVar2) {
            return;
          }
          uVar5 = GameObject.GetComponent(go,DAT_181d9eb30);
          cVar2 = Object.op_Inequality(uVar5,0,0);
          if (cVar2) {
            NGUITools.UpdateWidgetCollider(uVar5,param_2,0);
            return;
          }
          uVar3 = GameObject.get_layer(go,0);
          lVar6 = UICamera.FindCameraForLayer(uVar3,0);
          cVar2 = Object.op_Inequality(lVar6,0,0);
          if (cVar2) {
            if (lVar6 == null) goto LAB_181592d0d;
            if (*(int *)(lVar6 + 24) - 2U < 2) {
              lVar6 = GameObject.AddComponent(go,DAT_181d9c0b0);
              if (lVar6 != null) {
                Collider2D.set_isTrigger(lVar6,1,0);
                lVar7 = GameObject.GetComponent(go,DAT_181da2930);
                cVar2 = Object.op_Inequality(lVar7,0,0);
                if (cVar2) {
                  if (lVar7 == null) goto LAB_181592d0d;
                  *(uint8 *)(lVar7 + 208) = 1;
                }
                NGUITools.UpdateWidgetCollider(lVar6,param_2,0);
                return;
              }
              goto LAB_181592d0d;
            }
          }
          plVar8 = (int64 *)GameObject.AddComponent(go,DAT_181d9c028);
          if (plVar8 == (int64 *)0) {
        LAB_181592d0d:
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          Collider.set_isTrigger(plVar8,1,0);
          lVar6 = GameObject.GetComponent(go,DAT_181da2930);
          cVar2 = Object.op_Inequality(lVar6,0,0);
          if (cVar2) {
            if (lVar6 == null) goto LAB_181592d0d;
            *(uint8 *)(lVar6 + 208) = 1;
          }
        }
        else if (((*(byte *)(DAT_181d66af0 + 0x133) & 4) != 0) && (*(int *)(DAT_181d66af0 + 224) == 0)) {
          il2cpp_runtime_class_init();
        }
        NGUITools.UpdateWidgetCollider(plVar8,param_2,0);
    }

    // Token : 0x60003BD
    // RVA   : 0x1592900   Offset: 0x1591100   Length: 0x412
    public static void AddWidgetCollider(GameObject go, bool considerInactive)
    {
        bool cVar2;
        uint uVar3;
        ulong uVar5;
        long lVar6;
        long lVar7;
        cVar2 = Object.op_Inequality(go,0,0);
        if (!cVar2) {
          return;
        }
        if (go == null) goto LAB_181592d0d;
        plVar4 = (int64 *)GameObject.GetComponent(go,DAT_181d9f328);
        if (plVar4 == (int64 *)0) {
          plVar8 = (int64 *)0;
        }
        else {
          plVar8 = plVar4;
        }
        cVar2 = Object.op_Inequality(plVar8,0,0);
        if (!cVar2) {
          cVar2 = Object.op_Inequality(plVar4,0,0);
          if (cVar2) {
            return;
          }
          uVar5 = GameObject.GetComponent(go,DAT_181d9eb30);
          cVar2 = Object.op_Inequality(uVar5,0,0);
          if (cVar2) {
            NGUITools.UpdateWidgetCollider(uVar5,considerInactive,0);
            return;
          }
          uVar3 = GameObject.get_layer(go,0);
          lVar6 = UICamera.FindCameraForLayer(uVar3,0);
          cVar2 = Object.op_Inequality(lVar6,0,0);
          if (cVar2) {
            if (lVar6 == null) goto LAB_181592d0d;
            if (*(int *)(lVar6 + 24) - 2U < 2) {
              lVar6 = GameObject.AddComponent(go,DAT_181d9c0b0);
              if (lVar6 != null) {
                Collider2D.set_isTrigger(lVar6,1,0);
                lVar7 = GameObject.GetComponent(go,DAT_181da2930);
                cVar2 = Object.op_Inequality(lVar7,0,0);
                if (cVar2) {
                  if (lVar7 == null) goto LAB_181592d0d;
                  *(uint8 *)(lVar7 + 208) = 1;
                }
                NGUITools.UpdateWidgetCollider(lVar6,considerInactive,0);
                return;
              }
              goto LAB_181592d0d;
            }
          }
          plVar8 = (int64 *)GameObject.AddComponent(go,DAT_181d9c028);
          if (plVar8 == (int64 *)0) {
        LAB_181592d0d:
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          Collider.set_isTrigger(plVar8,1,0);
          lVar6 = GameObject.GetComponent(go,DAT_181da2930);
          cVar2 = Object.op_Inequality(lVar6,0,0);
          if (cVar2) {
            if (lVar6 == null) goto LAB_181592d0d;
            *(uint8 *)(lVar6 + 208) = 1;
          }
        }
        else if (((*(byte *)(DAT_181d66af0 + 0x133) & 4) != 0) && (*(int *)(DAT_181d66af0 + 224) == 0)) {
          il2cpp_runtime_class_init();
        }
        NGUITools.UpdateWidgetCollider(plVar8,considerInactive,0);
    }

    // Token : 0x60003BE
    // RVA   : 0x159D800   Offset: 0x159C000   Length: 0x1B6
    public static void UpdateWidgetCollider(GameObject go)
    {
        uint uVar1;
        byte[] auVar2 = new byte[16];
        bool cVar3;
        long lVar4;
        ulong uVar6;
        ulong uVar9;
        uint8 (*pauVar10) [16];
        float fVar11;
        float fVar12;
        float fVar13;
        float fVar14;
        float local_res8;
        float fStackX_c;
        float local_res20;
        float fStackX_24;
        uint64 uVar15;
        float local_98;
        float fStack_94;
        float fStack_90;
        float fStack_8c;
        uint32 local_80;
        uint32 uStack_7c;
        uint32 uStack_78;
        uint32 uStack_74;
        uint64 local_70;
        cVar3 = Object.op_Inequality(go,0,0);
        if (cVar3) {
          if ((go == null) || (lVar4 = Component.get_gameObject(go,0)) == null) {
        LAB_18159d1fa:
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          plVar5 = (int64 *)GameObject.GetComponent(lVar4,DAT_181da2930);
          cVar3 = Object.op_Inequality(plVar5,0,0);
          if (!cVar3) {
            uVar6 = GameObject.get_transform(lVar4,0);
            puVar7 = (uint32 *)NGUIMath.CalculateRelativeWidgetBounds(&local_98,uVar6,param_2,0);
            local_80 = *puVar7;
            uStack_7c = puVar7[1];
            uStack_78 = puVar7[2];
            uStack_74 = puVar7[3];
            local_70 = *(uint64 *)(puVar7 + 4);
            puVar8 = (uint64 *)FUN_18045e0a0(&local_98,&local_80,0);
            Collider2D.set_offset(go,*puVar8,0);
            puVar7 = (uint32 *)Bounds.get_size(&local_98,&local_80,0);
            uVar1 = *puVar7;
            lVar4 = Bounds.get_size(&local_98,&local_80,0);
            BoxCollider2D.set_size(go,CONCAT44(*(uint32 *)(lVar4 + 4),uVar1),0);
          }
          else {
            if (plVar5 == (int64 *)0) goto LAB_18159d1fa;
            local_98 = *(float *)((int64)plVar5 + 252);
            fStack_94 = *(float *)(plVar5 + 32);
            fStack_90 = *(float *)((int64)plVar5 + 0x104);
            fStack_8c = *(float *)(plVar5 + 33);
            if ((((local_98 == 0.0) && (fStack_94 == 0.0)) && (fStack_90 == 1.0)) && (fStack_8c == 1.0)) {
              lVar4 = (**(code **)(*plVar5 + 0x1d8))(plVar5,*(uint64 *)(*plVar5 + 0x1e0));
              if (lVar4 == null) goto LAB_18159d1fa;
              if (*(uint32 *)(lVar4 + 24) == 0) {
                uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar6,0);
              }
              if (*(uint32 *)(lVar4 + 24) < 3) {
                uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar6,0);
              }
              uVar6 = Vector2.Lerp(*(uint64 *)(lVar4 + 32),*(uint64 *)(lVar4 + 56),0x3f000000
                                    ,0,*(uint64 *)(lVar4 + 56));
              if (*(uint32 *)(lVar4 + 24) < 3) {
                uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar6,0);
              }
              fVar12 = (float)*(uint64 *)(lVar4 + 56) - (float)*(uint64 *)(lVar4 + 32);
              fVar11 = (float)((uint64)*(uint64 *)(lVar4 + 56) >> 32) -
                       (float)((uint64)*(uint64 *)(lVar4 + 32) >> 32);
              uVar15 = CONCAT44(fVar11,fVar12);
              uVar9 = Collider2D.get_offset(go,0);
              local_res8 = (float)uVar6;
              fStackX_c = (float)((uint64)uVar6 >> 32);
              local_res20 = (float)uVar9;
              fStackX_24 = (float)((uint64)uVar9 >> 32);
              if ((fStackX_c - fStackX_24) * (fStackX_c - fStackX_24) +
                  (local_res8 - local_res20) * (local_res8 - local_res20) < 9.9999994e-11) {
                uVar9 = BoxCollider2D.get_size(go,0);
                local_res8 = (float)uVar9;
                fVar12 = fVar12 - local_res8;
                fStackX_c = (float)((uint64)uVar9 >> 32);
                fVar11 = fVar11 - fStackX_c;
                if (fVar11 * fVar11 + fVar12 * fVar12 < 9.9999994e-11) {
                  return;
                }
              }
              Collider2D.set_offset(go,uVar6,0);
              BoxCollider2D.set_size(go,uVar15,0);
            }
            else {
              pauVar10 = (uint8 (*) [16])
                         (**(code **)(*plVar5 + 0x2b8))(&local_98,plVar5,*(uint64 *)(*plVar5 + 0x2c0))
              ;
              auVar2 = *pauVar10;
              fVar11 = auVar2._8_4_ - auVar2._0_4_;
              fVar12 = auVar2._12_4_ - auVar2._4_4_;
              fVar13 = (auVar2._8_4_ + auVar2._0_4_) * 0.5;
              fVar14 = (auVar2._4_4_ + auVar2._12_4_) * 0.5;
              uVar6 = Collider2D.get_offset(go,0);
              local_res8 = (float)uVar6;
              local_res8 = fVar13 - local_res8;
              fStackX_c = (float)((uint64)uVar6 >> 32);
              fStackX_c = fVar14 - fStackX_c;
              if (fStackX_c * fStackX_c + local_res8 * local_res8 < 9.9999994e-11) {
                uVar6 = BoxCollider2D.get_size(go,0);
                local_res8 = (float)uVar6;
                local_res8 = fVar11 - local_res8;
                fStackX_c = (float)((uint64)uVar6 >> 32);
                fStackX_c = fVar12 - fStackX_c;
                if (fStackX_c * fStackX_c + local_res8 * local_res8 < 9.9999994e-11) {
                  return;
                }
              }
              Collider2D.set_offset(go,CONCAT44(fVar14,fVar13),0);
              BoxCollider2D.set_size(go,CONCAT44(fVar12,fVar11),0);
            }
          }
        }
    }

    // Token : 0x60003BF
    // RVA   : 0x159D230   Offset: 0x159BA30   Length: 0x191
    public static void UpdateWidgetCollider(GameObject go, bool considerInactive)
    {
        uint uVar1;
        byte[] auVar2 = new byte[16];
        bool cVar3;
        long lVar4;
        ulong uVar6;
        ulong uVar9;
        uint8 (*pauVar10) [16];
        float fVar11;
        float fVar12;
        float fVar13;
        float fVar14;
        float local_res8;
        float fStackX_c;
        float local_res20;
        float fStackX_24;
        uint64 uVar15;
        float local_98;
        float fStack_94;
        float fStack_90;
        float fStack_8c;
        uint32 local_80;
        uint32 uStack_7c;
        uint32 uStack_78;
        uint32 uStack_74;
        uint64 local_70;
        cVar3 = Object.op_Inequality(go,0,0);
        if (cVar3) {
          if ((go == null) || (lVar4 = Component.get_gameObject(go,0)) == null) {
        LAB_18159d1fa:
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          plVar5 = (int64 *)GameObject.GetComponent(lVar4,DAT_181da2930);
          cVar3 = Object.op_Inequality(plVar5,0,0);
          if (!cVar3) {
            uVar6 = GameObject.get_transform(lVar4,0);
            puVar7 = (uint32 *)NGUIMath.CalculateRelativeWidgetBounds(&local_98,uVar6,considerInactive,0);
            local_80 = *puVar7;
            uStack_7c = puVar7[1];
            uStack_78 = puVar7[2];
            uStack_74 = puVar7[3];
            local_70 = *(uint64 *)(puVar7 + 4);
            puVar8 = (uint64 *)FUN_18045e0a0(&local_98,&local_80,0);
            Collider2D.set_offset(go,*puVar8,0);
            puVar7 = (uint32 *)Bounds.get_size(&local_98,&local_80,0);
            uVar1 = *puVar7;
            lVar4 = Bounds.get_size(&local_98,&local_80,0);
            BoxCollider2D.set_size(go,CONCAT44(*(uint32 *)(lVar4 + 4),uVar1),0);
          }
          else {
            if (plVar5 == (int64 *)0) goto LAB_18159d1fa;
            local_98 = *(float *)((int64)plVar5 + 252);
            fStack_94 = *(float *)(plVar5 + 32);
            fStack_90 = *(float *)((int64)plVar5 + 0x104);
            fStack_8c = *(float *)(plVar5 + 33);
            if ((((local_98 == 0.0) && (fStack_94 == 0.0)) && (fStack_90 == 1.0)) && (fStack_8c == 1.0)) {
              lVar4 = (**(code **)(*plVar5 + 0x1d8))(plVar5,*(uint64 *)(*plVar5 + 0x1e0));
              if (lVar4 == null) goto LAB_18159d1fa;
              if (*(uint32 *)(lVar4 + 24) == 0) {
                uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar6,0);
              }
              if (*(uint32 *)(lVar4 + 24) < 3) {
                uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar6,0);
              }
              uVar6 = Vector2.Lerp(*(uint64 *)(lVar4 + 32),*(uint64 *)(lVar4 + 56),0x3f000000
                                    ,0,*(uint64 *)(lVar4 + 56));
              if (*(uint32 *)(lVar4 + 24) < 3) {
                uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar6,0);
              }
              fVar12 = (float)*(uint64 *)(lVar4 + 56) - (float)*(uint64 *)(lVar4 + 32);
              fVar11 = (float)((uint64)*(uint64 *)(lVar4 + 56) >> 32) -
                       (float)((uint64)*(uint64 *)(lVar4 + 32) >> 32);
              uVar15 = CONCAT44(fVar11,fVar12);
              uVar9 = Collider2D.get_offset(go,0);
              local_res8 = (float)uVar6;
              fStackX_c = (float)((uint64)uVar6 >> 32);
              local_res20 = (float)uVar9;
              fStackX_24 = (float)((uint64)uVar9 >> 32);
              if ((fStackX_c - fStackX_24) * (fStackX_c - fStackX_24) +
                  (local_res8 - local_res20) * (local_res8 - local_res20) < 9.9999994e-11) {
                uVar9 = BoxCollider2D.get_size(go,0);
                local_res8 = (float)uVar9;
                fVar12 = fVar12 - local_res8;
                fStackX_c = (float)((uint64)uVar9 >> 32);
                fVar11 = fVar11 - fStackX_c;
                if (fVar11 * fVar11 + fVar12 * fVar12 < 9.9999994e-11) {
                  return;
                }
              }
              Collider2D.set_offset(go,uVar6,0);
              BoxCollider2D.set_size(go,uVar15,0);
            }
            else {
              pauVar10 = (uint8 (*) [16])
                         (**(code **)(*plVar5 + 0x2b8))(&local_98,plVar5,*(uint64 *)(*plVar5 + 0x2c0))
              ;
              auVar2 = *pauVar10;
              fVar11 = auVar2._8_4_ - auVar2._0_4_;
              fVar12 = auVar2._12_4_ - auVar2._4_4_;
              fVar13 = (auVar2._8_4_ + auVar2._0_4_) * 0.5;
              fVar14 = (auVar2._4_4_ + auVar2._12_4_) * 0.5;
              uVar6 = Collider2D.get_offset(go,0);
              local_res8 = (float)uVar6;
              local_res8 = fVar13 - local_res8;
              fStackX_c = (float)((uint64)uVar6 >> 32);
              fStackX_c = fVar14 - fStackX_c;
              if (fStackX_c * fStackX_c + local_res8 * local_res8 < 9.9999994e-11) {
                uVar6 = BoxCollider2D.get_size(go,0);
                local_res8 = (float)uVar6;
                local_res8 = fVar11 - local_res8;
                fStackX_c = (float)((uint64)uVar6 >> 32);
                fStackX_c = fVar12 - fStackX_c;
                if (fStackX_c * fStackX_c + local_res8 * local_res8 < 9.9999994e-11) {
                  return;
                }
              }
              Collider2D.set_offset(go,CONCAT44(fVar14,fVar13),0);
              BoxCollider2D.set_size(go,CONCAT44(fVar12,fVar11),0);
            }
          }
        }
    }

    // Token : 0x60003C0
    // RVA   : 0x159D9C0   Offset: 0x159C1C0   Length: 0x48D
    public static void UpdateWidgetCollider(BoxCollider box, bool considerInactive)
    {
        uint uVar1;
        byte[] auVar2 = new byte[16];
        bool cVar3;
        long lVar4;
        ulong uVar6;
        ulong uVar9;
        uint8 (*pauVar10) [16];
        float fVar11;
        float fVar12;
        float fVar13;
        float fVar14;
        float local_res8;
        float fStackX_c;
        float local_res20;
        float fStackX_24;
        uint64 uVar15;
        float local_98;
        float fStack_94;
        float fStack_90;
        float fStack_8c;
        uint32 local_80;
        uint32 uStack_7c;
        uint32 uStack_78;
        uint32 uStack_74;
        uint64 local_70;
        cVar3 = Object.op_Inequality(box,0,0);
        if (cVar3) {
          if ((box == null) || (lVar4 = Component.get_gameObject(box,0)) == null) {
        LAB_18159d1fa:
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          plVar5 = (int64 *)GameObject.GetComponent(lVar4,DAT_181da2930);
          cVar3 = Object.op_Inequality(plVar5,0,0);
          if (!cVar3) {
            uVar6 = GameObject.get_transform(lVar4,0);
            puVar7 = (uint32 *)NGUIMath.CalculateRelativeWidgetBounds(&local_98,uVar6,considerInactive,0);
            local_80 = *puVar7;
            uStack_7c = puVar7[1];
            uStack_78 = puVar7[2];
            uStack_74 = puVar7[3];
            local_70 = *(uint64 *)(puVar7 + 4);
            puVar8 = (uint64 *)FUN_18045e0a0(&local_98,&local_80,0);
            Collider2D.set_offset(box,*puVar8,0);
            puVar7 = (uint32 *)Bounds.get_size(&local_98,&local_80,0);
            uVar1 = *puVar7;
            lVar4 = Bounds.get_size(&local_98,&local_80,0);
            BoxCollider2D.set_size(box,CONCAT44(*(uint32 *)(lVar4 + 4),uVar1),0);
          }
          else {
            if (plVar5 == (int64 *)0) goto LAB_18159d1fa;
            local_98 = *(float *)((int64)plVar5 + 252);
            fStack_94 = *(float *)(plVar5 + 32);
            fStack_90 = *(float *)((int64)plVar5 + 0x104);
            fStack_8c = *(float *)(plVar5 + 33);
            if ((((local_98 == 0.0) && (fStack_94 == 0.0)) && (fStack_90 == 1.0)) && (fStack_8c == 1.0)) {
              lVar4 = (**(code **)(*plVar5 + 0x1d8))(plVar5,*(uint64 *)(*plVar5 + 0x1e0));
              if (lVar4 == null) goto LAB_18159d1fa;
              if (*(uint32 *)(lVar4 + 24) == 0) {
                uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar6,0);
              }
              if (*(uint32 *)(lVar4 + 24) < 3) {
                uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar6,0);
              }
              uVar6 = Vector2.Lerp(*(uint64 *)(lVar4 + 32),*(uint64 *)(lVar4 + 56),0x3f000000
                                    ,0,*(uint64 *)(lVar4 + 56));
              if (*(uint32 *)(lVar4 + 24) < 3) {
                uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar6,0);
              }
              fVar12 = (float)*(uint64 *)(lVar4 + 56) - (float)*(uint64 *)(lVar4 + 32);
              fVar11 = (float)((uint64)*(uint64 *)(lVar4 + 56) >> 32) -
                       (float)((uint64)*(uint64 *)(lVar4 + 32) >> 32);
              uVar15 = CONCAT44(fVar11,fVar12);
              uVar9 = Collider2D.get_offset(box,0);
              local_res8 = (float)uVar6;
              fStackX_c = (float)((uint64)uVar6 >> 32);
              local_res20 = (float)uVar9;
              fStackX_24 = (float)((uint64)uVar9 >> 32);
              if ((fStackX_c - fStackX_24) * (fStackX_c - fStackX_24) +
                  (local_res8 - local_res20) * (local_res8 - local_res20) < 9.9999994e-11) {
                uVar9 = BoxCollider2D.get_size(box,0);
                local_res8 = (float)uVar9;
                fVar12 = fVar12 - local_res8;
                fStackX_c = (float)((uint64)uVar9 >> 32);
                fVar11 = fVar11 - fStackX_c;
                if (fVar11 * fVar11 + fVar12 * fVar12 < 9.9999994e-11) {
                  return;
                }
              }
              Collider2D.set_offset(box,uVar6,0);
              BoxCollider2D.set_size(box,uVar15,0);
            }
            else {
              pauVar10 = (uint8 (*) [16])
                         (**(code **)(*plVar5 + 0x2b8))(&local_98,plVar5,*(uint64 *)(*plVar5 + 0x2c0))
              ;
              auVar2 = *pauVar10;
              fVar11 = auVar2._8_4_ - auVar2._0_4_;
              fVar12 = auVar2._12_4_ - auVar2._4_4_;
              fVar13 = (auVar2._8_4_ + auVar2._0_4_) * 0.5;
              fVar14 = (auVar2._4_4_ + auVar2._12_4_) * 0.5;
              uVar6 = Collider2D.get_offset(box,0);
              local_res8 = (float)uVar6;
              local_res8 = fVar13 - local_res8;
              fStackX_c = (float)((uint64)uVar6 >> 32);
              fStackX_c = fVar14 - fStackX_c;
              if (fStackX_c * fStackX_c + local_res8 * local_res8 < 9.9999994e-11) {
                uVar6 = BoxCollider2D.get_size(box,0);
                local_res8 = (float)uVar6;
                local_res8 = fVar11 - local_res8;
                fStackX_c = (float)((uint64)uVar6 >> 32);
                fStackX_c = fVar12 - fStackX_c;
                if (fStackX_c * fStackX_c + local_res8 * local_res8 < 9.9999994e-11) {
                  return;
                }
              }
              Collider2D.set_offset(box,CONCAT44(fVar14,fVar13),0);
              BoxCollider2D.set_size(box,CONCAT44(fVar12,fVar11),0);
            }
          }
        }
    }

    // Token : 0x60003C1
    // RVA   : 0x159DE50   Offset: 0x159C650   Length: 0x14F
    public static void UpdateWidgetCollider(UIWidget w)
    {
        uint uVar1;
        byte[] auVar2 = new byte[16];
        bool cVar3;
        long lVar4;
        ulong uVar6;
        ulong uVar9;
        uint8 (*pauVar10) [16];
        float fVar11;
        float fVar12;
        float fVar13;
        float fVar14;
        float local_res8;
        float fStackX_c;
        float local_res20;
        float fStackX_24;
        uint64 uVar15;
        float local_98;
        float fStack_94;
        float fStack_90;
        float fStack_8c;
        uint32 local_80;
        uint32 uStack_7c;
        uint32 uStack_78;
        uint32 uStack_74;
        uint64 local_70;
        cVar3 = Object.op_Inequality(w,0,0);
        if (cVar3) {
          if ((w == null) || (lVar4 = Component.get_gameObject(w,0)) == null) {
        LAB_18159d1fa:
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          plVar5 = (int64 *)GameObject.GetComponent(lVar4,DAT_181da2930);
          cVar3 = Object.op_Inequality(plVar5,0,0);
          if (!cVar3) {
            uVar6 = GameObject.get_transform(lVar4,0);
            puVar7 = (uint32 *)NGUIMath.CalculateRelativeWidgetBounds(&local_98,uVar6,param_2,0);
            local_80 = *puVar7;
            uStack_7c = puVar7[1];
            uStack_78 = puVar7[2];
            uStack_74 = puVar7[3];
            local_70 = *(uint64 *)(puVar7 + 4);
            puVar8 = (uint64 *)FUN_18045e0a0(&local_98,&local_80,0);
            Collider2D.set_offset(w,*puVar8,0);
            puVar7 = (uint32 *)Bounds.get_size(&local_98,&local_80,0);
            uVar1 = *puVar7;
            lVar4 = Bounds.get_size(&local_98,&local_80,0);
            BoxCollider2D.set_size(w,CONCAT44(*(uint32 *)(lVar4 + 4),uVar1),0);
          }
          else {
            if (plVar5 == (int64 *)0) goto LAB_18159d1fa;
            local_98 = *(float *)((int64)plVar5 + 252);
            fStack_94 = *(float *)(plVar5 + 32);
            fStack_90 = *(float *)((int64)plVar5 + 0x104);
            fStack_8c = *(float *)(plVar5 + 33);
            if ((((local_98 == 0.0) && (fStack_94 == 0.0)) && (fStack_90 == 1.0)) && (fStack_8c == 1.0)) {
              lVar4 = (**(code **)(*plVar5 + 0x1d8))(plVar5,*(uint64 *)(*plVar5 + 0x1e0));
              if (lVar4 == null) goto LAB_18159d1fa;
              if (*(uint32 *)(lVar4 + 24) == 0) {
                uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar6,0);
              }
              if (*(uint32 *)(lVar4 + 24) < 3) {
                uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar6,0);
              }
              uVar6 = Vector2.Lerp(*(uint64 *)(lVar4 + 32),*(uint64 *)(lVar4 + 56),0x3f000000
                                    ,0,*(uint64 *)(lVar4 + 56));
              if (*(uint32 *)(lVar4 + 24) < 3) {
                uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar6,0);
              }
              fVar12 = (float)*(uint64 *)(lVar4 + 56) - (float)*(uint64 *)(lVar4 + 32);
              fVar11 = (float)((uint64)*(uint64 *)(lVar4 + 56) >> 32) -
                       (float)((uint64)*(uint64 *)(lVar4 + 32) >> 32);
              uVar15 = CONCAT44(fVar11,fVar12);
              uVar9 = Collider2D.get_offset(w,0);
              local_res8 = (float)uVar6;
              fStackX_c = (float)((uint64)uVar6 >> 32);
              local_res20 = (float)uVar9;
              fStackX_24 = (float)((uint64)uVar9 >> 32);
              if ((fStackX_c - fStackX_24) * (fStackX_c - fStackX_24) +
                  (local_res8 - local_res20) * (local_res8 - local_res20) < 9.9999994e-11) {
                uVar9 = BoxCollider2D.get_size(w,0);
                local_res8 = (float)uVar9;
                fVar12 = fVar12 - local_res8;
                fStackX_c = (float)((uint64)uVar9 >> 32);
                fVar11 = fVar11 - fStackX_c;
                if (fVar11 * fVar11 + fVar12 * fVar12 < 9.9999994e-11) {
                  return;
                }
              }
              Collider2D.set_offset(w,uVar6,0);
              BoxCollider2D.set_size(w,uVar15,0);
            }
            else {
              pauVar10 = (uint8 (*) [16])
                         (**(code **)(*plVar5 + 0x2b8))(&local_98,plVar5,*(uint64 *)(*plVar5 + 0x2c0))
              ;
              auVar2 = *pauVar10;
              fVar11 = auVar2._8_4_ - auVar2._0_4_;
              fVar12 = auVar2._12_4_ - auVar2._4_4_;
              fVar13 = (auVar2._8_4_ + auVar2._0_4_) * 0.5;
              fVar14 = (auVar2._4_4_ + auVar2._12_4_) * 0.5;
              uVar6 = Collider2D.get_offset(w,0);
              local_res8 = (float)uVar6;
              local_res8 = fVar13 - local_res8;
              fStackX_c = (float)((uint64)uVar6 >> 32);
              fStackX_c = fVar14 - fStackX_c;
              if (fStackX_c * fStackX_c + local_res8 * local_res8 < 9.9999994e-11) {
                uVar6 = BoxCollider2D.get_size(w,0);
                local_res8 = (float)uVar6;
                local_res8 = fVar11 - local_res8;
                fStackX_c = (float)((uint64)uVar6 >> 32);
                fStackX_c = fVar12 - fStackX_c;
                if (fStackX_c * fStackX_c + local_res8 * local_res8 < 9.9999994e-11) {
                  return;
                }
              }
              Collider2D.set_offset(w,CONCAT44(fVar14,fVar13),0);
              BoxCollider2D.set_size(w,CONCAT44(fVar12,fVar11),0);
            }
          }
        }
    }

    // Token : 0x60003C2
    // RVA   : 0x159C870   Offset: 0x159B070   Length: 0x466
    public static void UpdateWidgetCollider(UIWidget w, BoxCollider box)
    {
        uint uVar1;
        byte[] auVar2 = new byte[16];
        bool cVar3;
        long lVar4;
        ulong uVar6;
        ulong uVar9;
        uint8 (*pauVar10) [16];
        float fVar11;
        float fVar12;
        float fVar13;
        float fVar14;
        float local_res8;
        float fStackX_c;
        float local_res20;
        float fStackX_24;
        uint64 uVar15;
        float local_98;
        float fStack_94;
        float fStack_90;
        float fStack_8c;
        uint32 local_80;
        uint32 uStack_7c;
        uint32 uStack_78;
        uint32 uStack_74;
        uint64 local_70;
        cVar3 = Object.op_Inequality(w,0,0);
        if (cVar3) {
          if ((w == null) || (lVar4 = Component.get_gameObject(w,0)) == null) {
        LAB_18159d1fa:
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          plVar5 = (int64 *)GameObject.GetComponent(lVar4,DAT_181da2930);
          cVar3 = Object.op_Inequality(plVar5,0,0);
          if (!cVar3) {
            uVar6 = GameObject.get_transform(lVar4,0);
            puVar7 = (uint32 *)NGUIMath.CalculateRelativeWidgetBounds(&local_98,uVar6,box,0);
            local_80 = *puVar7;
            uStack_7c = puVar7[1];
            uStack_78 = puVar7[2];
            uStack_74 = puVar7[3];
            local_70 = *(uint64 *)(puVar7 + 4);
            puVar8 = (uint64 *)FUN_18045e0a0(&local_98,&local_80,0);
            Collider2D.set_offset(w,*puVar8,0);
            puVar7 = (uint32 *)Bounds.get_size(&local_98,&local_80,0);
            uVar1 = *puVar7;
            lVar4 = Bounds.get_size(&local_98,&local_80,0);
            BoxCollider2D.set_size(w,CONCAT44(*(uint32 *)(lVar4 + 4),uVar1),0);
          }
          else {
            if (plVar5 == (int64 *)0) goto LAB_18159d1fa;
            local_98 = *(float *)((int64)plVar5 + 252);
            fStack_94 = *(float *)(plVar5 + 32);
            fStack_90 = *(float *)((int64)plVar5 + 0x104);
            fStack_8c = *(float *)(plVar5 + 33);
            if ((((local_98 == 0.0) && (fStack_94 == 0.0)) && (fStack_90 == 1.0)) && (fStack_8c == 1.0)) {
              lVar4 = (**(code **)(*plVar5 + 0x1d8))(plVar5,*(uint64 *)(*plVar5 + 0x1e0));
              if (lVar4 == null) goto LAB_18159d1fa;
              if (*(uint32 *)(lVar4 + 24) == 0) {
                uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar6,0);
              }
              if (*(uint32 *)(lVar4 + 24) < 3) {
                uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar6,0);
              }
              uVar6 = Vector2.Lerp(*(uint64 *)(lVar4 + 32),*(uint64 *)(lVar4 + 56),0x3f000000
                                    ,0,*(uint64 *)(lVar4 + 56));
              if (*(uint32 *)(lVar4 + 24) < 3) {
                uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar6,0);
              }
              fVar12 = (float)*(uint64 *)(lVar4 + 56) - (float)*(uint64 *)(lVar4 + 32);
              fVar11 = (float)((uint64)*(uint64 *)(lVar4 + 56) >> 32) -
                       (float)((uint64)*(uint64 *)(lVar4 + 32) >> 32);
              uVar15 = CONCAT44(fVar11,fVar12);
              uVar9 = Collider2D.get_offset(w,0);
              local_res8 = (float)uVar6;
              fStackX_c = (float)((uint64)uVar6 >> 32);
              local_res20 = (float)uVar9;
              fStackX_24 = (float)((uint64)uVar9 >> 32);
              if ((fStackX_c - fStackX_24) * (fStackX_c - fStackX_24) +
                  (local_res8 - local_res20) * (local_res8 - local_res20) < 9.9999994e-11) {
                uVar9 = BoxCollider2D.get_size(w,0);
                local_res8 = (float)uVar9;
                fVar12 = fVar12 - local_res8;
                fStackX_c = (float)((uint64)uVar9 >> 32);
                fVar11 = fVar11 - fStackX_c;
                if (fVar11 * fVar11 + fVar12 * fVar12 < 9.9999994e-11) {
                  return;
                }
              }
              Collider2D.set_offset(w,uVar6,0);
              BoxCollider2D.set_size(w,uVar15,0);
            }
            else {
              pauVar10 = (uint8 (*) [16])
                         (**(code **)(*plVar5 + 0x2b8))(&local_98,plVar5,*(uint64 *)(*plVar5 + 0x2c0))
              ;
              auVar2 = *pauVar10;
              fVar11 = auVar2._8_4_ - auVar2._0_4_;
              fVar12 = auVar2._12_4_ - auVar2._4_4_;
              fVar13 = (auVar2._8_4_ + auVar2._0_4_) * 0.5;
              fVar14 = (auVar2._4_4_ + auVar2._12_4_) * 0.5;
              uVar6 = Collider2D.get_offset(w,0);
              local_res8 = (float)uVar6;
              local_res8 = fVar13 - local_res8;
              fStackX_c = (float)((uint64)uVar6 >> 32);
              fStackX_c = fVar14 - fStackX_c;
              if (fStackX_c * fStackX_c + local_res8 * local_res8 < 9.9999994e-11) {
                uVar6 = BoxCollider2D.get_size(w,0);
                local_res8 = (float)uVar6;
                local_res8 = fVar11 - local_res8;
                fStackX_c = (float)((uint64)uVar6 >> 32);
                fStackX_c = fVar12 - fStackX_c;
                if (fStackX_c * fStackX_c + local_res8 * local_res8 < 9.9999994e-11) {
                  return;
                }
              }
              Collider2D.set_offset(w,CONCAT44(fVar14,fVar13),0);
              BoxCollider2D.set_size(w,CONCAT44(fVar12,fVar11),0);
            }
          }
        }
    }

    // Token : 0x60003C3
    // RVA   : 0x159D3D0   Offset: 0x159BBD0   Length: 0x429
    public static void UpdateWidgetCollider(UIWidget w, BoxCollider2D box)
    {
        uint uVar1;
        byte[] auVar2 = new byte[16];
        bool cVar3;
        long lVar4;
        ulong uVar6;
        ulong uVar9;
        uint8 (*pauVar10) [16];
        float fVar11;
        float fVar12;
        float fVar13;
        float fVar14;
        float local_res8;
        float fStackX_c;
        float local_res20;
        float fStackX_24;
        uint64 uVar15;
        float local_98;
        float fStack_94;
        float fStack_90;
        float fStack_8c;
        uint32 local_80;
        uint32 uStack_7c;
        uint32 uStack_78;
        uint32 uStack_74;
        uint64 local_70;
        cVar3 = Object.op_Inequality(w,0,0);
        if (cVar3) {
          if ((w == null) || (lVar4 = Component.get_gameObject(w,0)) == null) {
        LAB_18159d1fa:
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          plVar5 = (int64 *)GameObject.GetComponent(lVar4,DAT_181da2930);
          cVar3 = Object.op_Inequality(plVar5,0,0);
          if (!cVar3) {
            uVar6 = GameObject.get_transform(lVar4,0);
            puVar7 = (uint32 *)NGUIMath.CalculateRelativeWidgetBounds(&local_98,uVar6,box,0);
            local_80 = *puVar7;
            uStack_7c = puVar7[1];
            uStack_78 = puVar7[2];
            uStack_74 = puVar7[3];
            local_70 = *(uint64 *)(puVar7 + 4);
            puVar8 = (uint64 *)FUN_18045e0a0(&local_98,&local_80,0);
            Collider2D.set_offset(w,*puVar8,0);
            puVar7 = (uint32 *)Bounds.get_size(&local_98,&local_80,0);
            uVar1 = *puVar7;
            lVar4 = Bounds.get_size(&local_98,&local_80,0);
            BoxCollider2D.set_size(w,CONCAT44(*(uint32 *)(lVar4 + 4),uVar1),0);
          }
          else {
            if (plVar5 == (int64 *)0) goto LAB_18159d1fa;
            local_98 = *(float *)((int64)plVar5 + 252);
            fStack_94 = *(float *)(plVar5 + 32);
            fStack_90 = *(float *)((int64)plVar5 + 0x104);
            fStack_8c = *(float *)(plVar5 + 33);
            if ((((local_98 == 0.0) && (fStack_94 == 0.0)) && (fStack_90 == 1.0)) && (fStack_8c == 1.0)) {
              lVar4 = (**(code **)(*plVar5 + 0x1d8))(plVar5,*(uint64 *)(*plVar5 + 0x1e0));
              if (lVar4 == null) goto LAB_18159d1fa;
              if (*(uint32 *)(lVar4 + 24) == 0) {
                uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar6,0);
              }
              if (*(uint32 *)(lVar4 + 24) < 3) {
                uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar6,0);
              }
              uVar6 = Vector2.Lerp(*(uint64 *)(lVar4 + 32),*(uint64 *)(lVar4 + 56),0x3f000000
                                    ,0,*(uint64 *)(lVar4 + 56));
              if (*(uint32 *)(lVar4 + 24) < 3) {
                uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar6,0);
              }
              fVar12 = (float)*(uint64 *)(lVar4 + 56) - (float)*(uint64 *)(lVar4 + 32);
              fVar11 = (float)((uint64)*(uint64 *)(lVar4 + 56) >> 32) -
                       (float)((uint64)*(uint64 *)(lVar4 + 32) >> 32);
              uVar15 = CONCAT44(fVar11,fVar12);
              uVar9 = Collider2D.get_offset(w,0);
              local_res8 = (float)uVar6;
              fStackX_c = (float)((uint64)uVar6 >> 32);
              local_res20 = (float)uVar9;
              fStackX_24 = (float)((uint64)uVar9 >> 32);
              if ((fStackX_c - fStackX_24) * (fStackX_c - fStackX_24) +
                  (local_res8 - local_res20) * (local_res8 - local_res20) < 9.9999994e-11) {
                uVar9 = BoxCollider2D.get_size(w,0);
                local_res8 = (float)uVar9;
                fVar12 = fVar12 - local_res8;
                fStackX_c = (float)((uint64)uVar9 >> 32);
                fVar11 = fVar11 - fStackX_c;
                if (fVar11 * fVar11 + fVar12 * fVar12 < 9.9999994e-11) {
                  return;
                }
              }
              Collider2D.set_offset(w,uVar6,0);
              BoxCollider2D.set_size(w,uVar15,0);
            }
            else {
              pauVar10 = (uint8 (*) [16])
                         (**(code **)(*plVar5 + 0x2b8))(&local_98,plVar5,*(uint64 *)(*plVar5 + 0x2c0))
              ;
              auVar2 = *pauVar10;
              fVar11 = auVar2._8_4_ - auVar2._0_4_;
              fVar12 = auVar2._12_4_ - auVar2._4_4_;
              fVar13 = (auVar2._8_4_ + auVar2._0_4_) * 0.5;
              fVar14 = (auVar2._4_4_ + auVar2._12_4_) * 0.5;
              uVar6 = Collider2D.get_offset(w,0);
              local_res8 = (float)uVar6;
              local_res8 = fVar13 - local_res8;
              fStackX_c = (float)((uint64)uVar6 >> 32);
              fStackX_c = fVar14 - fStackX_c;
              if (fStackX_c * fStackX_c + local_res8 * local_res8 < 9.9999994e-11) {
                uVar6 = BoxCollider2D.get_size(w,0);
                local_res8 = (float)uVar6;
                local_res8 = fVar11 - local_res8;
                fStackX_c = (float)((uint64)uVar6 >> 32);
                fStackX_c = fVar12 - fStackX_c;
                if (fStackX_c * fStackX_c + local_res8 * local_res8 < 9.9999994e-11) {
                  return;
                }
              }
              Collider2D.set_offset(w,CONCAT44(fVar14,fVar13),0);
              BoxCollider2D.set_size(w,CONCAT44(fVar12,fVar11),0);
            }
          }
        }
    }

    // Token : 0x60003C4
    // RVA   : 0x159CCE0   Offset: 0x159B4E0   Length: 0x54F
    public static void UpdateWidgetCollider(BoxCollider2D box, bool considerInactive)
    {
        uint uVar1;
        byte[] auVar2 = new byte[16];
        bool cVar3;
        long lVar4;
        ulong uVar6;
        ulong uVar9;
        uint8 (*pauVar10) [16];
        float fVar11;
        float fVar12;
        float fVar13;
        float fVar14;
        float local_res8;
        float fStackX_c;
        float local_res20;
        float fStackX_24;
        uint64 uVar15;
        float local_98;
        float fStack_94;
        float fStack_90;
        float fStack_8c;
        uint32 local_80;
        uint32 uStack_7c;
        uint32 uStack_78;
        uint32 uStack_74;
        uint64 local_70;
        cVar3 = Object.op_Inequality(box,0,0);
        if (cVar3) {
          if ((box == null) || (lVar4 = Component.get_gameObject(box,0)) == null) {
        LAB_18159d1fa:
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          plVar5 = (int64 *)GameObject.GetComponent(lVar4,DAT_181da2930);
          cVar3 = Object.op_Inequality(plVar5,0,0);
          if (!cVar3) {
            uVar6 = GameObject.get_transform(lVar4,0);
            puVar7 = (uint32 *)NGUIMath.CalculateRelativeWidgetBounds(&local_98,uVar6,considerInactive,0);
            local_80 = *puVar7;
            uStack_7c = puVar7[1];
            uStack_78 = puVar7[2];
            uStack_74 = puVar7[3];
            local_70 = *(uint64 *)(puVar7 + 4);
            puVar8 = (uint64 *)FUN_18045e0a0(&local_98,&local_80,0);
            Collider2D.set_offset(box,*puVar8,0);
            puVar7 = (uint32 *)Bounds.get_size(&local_98,&local_80,0);
            uVar1 = *puVar7;
            lVar4 = Bounds.get_size(&local_98,&local_80,0);
            BoxCollider2D.set_size(box,CONCAT44(*(uint32 *)(lVar4 + 4),uVar1),0);
          }
          else {
            if (plVar5 == (int64 *)0) goto LAB_18159d1fa;
            local_98 = *(float *)((int64)plVar5 + 252);
            fStack_94 = *(float *)(plVar5 + 32);
            fStack_90 = *(float *)((int64)plVar5 + 0x104);
            fStack_8c = *(float *)(plVar5 + 33);
            if ((((local_98 == 0.0) && (fStack_94 == 0.0)) && (fStack_90 == 1.0)) && (fStack_8c == 1.0)) {
              lVar4 = (**(code **)(*plVar5 + 0x1d8))(plVar5,*(uint64 *)(*plVar5 + 0x1e0));
              if (lVar4 == null) goto LAB_18159d1fa;
              if (*(uint32 *)(lVar4 + 24) == 0) {
                uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar6,0);
              }
              if (*(uint32 *)(lVar4 + 24) < 3) {
                uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar6,0);
              }
              uVar6 = Vector2.Lerp(*(uint64 *)(lVar4 + 32),*(uint64 *)(lVar4 + 56),0x3f000000
                                    ,0,*(uint64 *)(lVar4 + 56));
              if (*(uint32 *)(lVar4 + 24) < 3) {
                uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar6,0);
              }
              fVar12 = (float)*(uint64 *)(lVar4 + 56) - (float)*(uint64 *)(lVar4 + 32);
              fVar11 = (float)((uint64)*(uint64 *)(lVar4 + 56) >> 32) -
                       (float)((uint64)*(uint64 *)(lVar4 + 32) >> 32);
              uVar15 = CONCAT44(fVar11,fVar12);
              uVar9 = Collider2D.get_offset(box,0);
              local_res8 = (float)uVar6;
              fStackX_c = (float)((uint64)uVar6 >> 32);
              local_res20 = (float)uVar9;
              fStackX_24 = (float)((uint64)uVar9 >> 32);
              if ((fStackX_c - fStackX_24) * (fStackX_c - fStackX_24) +
                  (local_res8 - local_res20) * (local_res8 - local_res20) < 9.9999994e-11) {
                uVar9 = BoxCollider2D.get_size(box,0);
                local_res8 = (float)uVar9;
                fVar12 = fVar12 - local_res8;
                fStackX_c = (float)((uint64)uVar9 >> 32);
                fVar11 = fVar11 - fStackX_c;
                if (fVar11 * fVar11 + fVar12 * fVar12 < 9.9999994e-11) {
                  return;
                }
              }
              Collider2D.set_offset(box,uVar6,0);
              BoxCollider2D.set_size(box,uVar15,0);
            }
            else {
              pauVar10 = (uint8 (*) [16])
                         (**(code **)(*plVar5 + 0x2b8))(&local_98,plVar5,*(uint64 *)(*plVar5 + 0x2c0))
              ;
              auVar2 = *pauVar10;
              fVar11 = auVar2._8_4_ - auVar2._0_4_;
              fVar12 = auVar2._12_4_ - auVar2._4_4_;
              fVar13 = (auVar2._8_4_ + auVar2._0_4_) * 0.5;
              fVar14 = (auVar2._4_4_ + auVar2._12_4_) * 0.5;
              uVar6 = Collider2D.get_offset(box,0);
              local_res8 = (float)uVar6;
              local_res8 = fVar13 - local_res8;
              fStackX_c = (float)((uint64)uVar6 >> 32);
              fStackX_c = fVar14 - fStackX_c;
              if (fStackX_c * fStackX_c + local_res8 * local_res8 < 9.9999994e-11) {
                uVar6 = BoxCollider2D.get_size(box,0);
                local_res8 = (float)uVar6;
                local_res8 = fVar11 - local_res8;
                fStackX_c = (float)((uint64)uVar6 >> 32);
                fStackX_c = fVar12 - fStackX_c;
                if (fStackX_c * fStackX_c + local_res8 * local_res8 < 9.9999994e-11) {
                  return;
                }
              }
              Collider2D.set_offset(box,CONCAT44(fVar14,fVar13),0);
              BoxCollider2D.set_size(box,CONCAT44(fVar12,fVar11),0);
            }
          }
        }
    }

    // Token : 0x60003C5
    // RVA   : 0xDC4490   Offset: 0xDC2C90   Length: 0xEC
    public static string GetTypeName<T>()
    {
        bool cVar1;
        long lVar3;
        cVar1 = Object.op_Equality(param_1,0,0);
        if (!cVar1) {
          if (param_1 != 0) {
            plVar2 = (int64 *)Object.GetType(param_1,0);
            if (plVar2 != (int64 *)0) {
              lVar3 = (**(code **)(*plVar2 + 0x168))(plVar2,*(uint64 *)(*plVar2 + 0x170));
              if (lVar3 != null) {
                cVar1 = String.StartsWith(lVar3,"UI",0);
                if (!cVar1) {
                  cVar1 = String.StartsWith(lVar3,"UnityEngine.");
                  if (cVar1) {
                    lVar3 = String.Substring(lVar3,12);
                    return lVar3;
                  }
                }
                else {
                  lVar3 = String.Substring(lVar3,2,0);
                }
                return lVar3;
              }
            }
          }
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
        return "Null";
    }

    // Token : 0x60003C6
    // RVA   : 0x1598680   Offset: 0x1596E80   Length: 0x120
    public static string GetTypeName(object obj)
    {
        bool cVar1;
        long lVar3;
        cVar1 = Object.op_Equality(obj,0,0);
        if (!cVar1) {
          if (obj != null) {
            plVar2 = (int64 *)Object.GetType(obj,0);
            if (plVar2 != (int64 *)0) {
              lVar3 = (**(code **)(*plVar2 + 0x168))(plVar2,*(uint64 *)(*plVar2 + 0x170));
              if (lVar3 != null) {
                cVar1 = String.StartsWith(lVar3,"UI",0);
                if (!cVar1) {
                  cVar1 = String.StartsWith(lVar3,"UnityEngine.");
                  if (cVar1) {
                    lVar3 = String.Substring(lVar3,12);
                    return lVar3;
                  }
                }
                else {
                  lVar3 = String.Substring(lVar3,2,0);
                }
                return lVar3;
              }
            }
          }
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
        return "Null";
    }

    // Token : 0x60003C7
    // RVA   : 0x245810   Offset: 0x244010   Length: 0x3
    public static void RegisterUndo(object obj, string name)
    {
    }

    // Token : 0x60003C8
    // RVA   : 0x245810   Offset: 0x244010   Length: 0x3
    public static void SetDirty(object obj, string undoName)
    {
    }

    // Token : 0x60003C9
    // RVA   : 0x245810   Offset: 0x244010   Length: 0x3
    public static void CheckForPrefabStage(GameObject gameObject)
    {
    }

    // Token : 0x60003CA
    // RVA   : 0x1592630   Offset: 0x1590E30   Length: 0x59
    public static GameObject AddChild(GameObject parent)
    {
        var pStatics = *(int64*)(DAT_181d66af0 + 184);
        long lVar1;
        bool cVar3;
        long lVar4;
        ulong uVar5;
        long local_res8;
        local_res8 = 0;
        lVar4 = NGUITools.AddChild(parent,param_2,0);
        uVar5 = **(uint64 **)(param_3 + 48);
        lVar1 = *(int64 *)(pStatics + 40);
        uVar5 = Type.GetTypeFromHandle(uVar5,0);
        if (lVar1 != null) {
          cVar3 = FUN_1808addd0(lVar1,uVar5,&local_res8,DAT_181d531d0);
          if ((!cVar3) || (local_res8 == 0)) {
            puVar2 = *(uint64 **)(*(int64 *)(param_3 + 48) + 8);
            local_res8 = (*(code *)*puVar2)(puVar2);
            uVar5 = **(uint64 **)(param_3 + 48);
            lVar1 = *(int64 *)(pStatics + 40);
            uVar5 = Type.GetTypeFromHandle(uVar5,0);
            if (lVar1 == null) throw; // [null/range check failed]
            FUN_1808aec90(lVar1,uVar5,local_res8,DAT_181d53250);
          }
          if (lVar4 != null) {
            Object.set_name(lVar4,local_res8,0);
            puVar2 = *(uint64 **)(*(int64 *)(param_3 + 48) + 16);
            (*(code *)*puVar2)(lVar4,puVar2);
            return;
          }
        }
    }

    // Token : 0x60003CB
    // RVA   : 0x1592690   Offset: 0x1590E90   Length: 0x63
    public static GameObject AddChild(GameObject parent, int layer)
    {
        var pStatics = *(int64*)(DAT_181d66af0 + 184);
        long lVar1;
        bool cVar3;
        long lVar4;
        ulong uVar5;
        long local_res8;
        local_res8 = 0;
        lVar4 = NGUITools.AddChild(parent,layer,0);
        uVar5 = **(uint64 **)(param_3 + 48);
        lVar1 = *(int64 *)(pStatics + 40);
        uVar5 = Type.GetTypeFromHandle(uVar5,0);
        if (lVar1 != null) {
          cVar3 = FUN_1808addd0(lVar1,uVar5,&local_res8,DAT_181d531d0);
          if ((!cVar3) || (local_res8 == 0)) {
            puVar2 = *(uint64 **)(*(int64 *)(param_3 + 48) + 8);
            local_res8 = (*(code *)*puVar2)(puVar2);
            uVar5 = **(uint64 **)(param_3 + 48);
            lVar1 = *(int64 *)(pStatics + 40);
            uVar5 = Type.GetTypeFromHandle(uVar5,0);
            if (lVar1 == null) throw; // [null/range check failed]
            FUN_1808aec90(lVar1,uVar5,local_res8,DAT_181d53250);
          }
          if (lVar4 != null) {
            Object.set_name(lVar4,local_res8,0);
            puVar2 = *(uint64 **)(*(int64 *)(param_3 + 48) + 16);
            (*(code *)*puVar2)(lVar4,puVar2);
            return;
          }
        }
    }

    // Token : 0x60003CC
    // RVA   : 0x1592550   Offset: 0x1590D50   Length: 0x66
    public static GameObject AddChild(GameObject parent, bool undo)
    {
        var pStatics = *(int64*)(DAT_181d66af0 + 184);
        long lVar1;
        bool cVar3;
        long lVar4;
        ulong uVar5;
        long local_res8;
        local_res8 = 0;
        lVar4 = NGUITools.AddChild(parent,undo,0);
        uVar5 = **(uint64 **)(param_3 + 48);
        lVar1 = *(int64 *)(pStatics + 40);
        uVar5 = Type.GetTypeFromHandle(uVar5,0);
        if (lVar1 != null) {
          cVar3 = FUN_1808addd0(lVar1,uVar5,&local_res8,DAT_181d531d0);
          if ((!cVar3) || (local_res8 == 0)) {
            puVar2 = *(uint64 **)(*(int64 *)(param_3 + 48) + 8);
            local_res8 = (*(code *)*puVar2)(puVar2);
            uVar5 = **(uint64 **)(param_3 + 48);
            lVar1 = *(int64 *)(pStatics + 40);
            uVar5 = Type.GetTypeFromHandle(uVar5,0);
            if (lVar1 == null) throw; // [null/range check failed]
            FUN_1808aec90(lVar1,uVar5,local_res8,DAT_181d53250);
          }
          if (lVar4 != null) {
            Object.set_name(lVar4,local_res8,0);
            puVar2 = *(uint64 **)(*(int64 *)(param_3 + 48) + 16);
            (*(code *)*puVar2)(lVar4,puVar2);
            return;
          }
        }
    }

    // Token : 0x60003CD
    // RVA   : 0x1592060   Offset: 0x1590860   Length: 0x191
    public static GameObject AddChild(GameObject parent, bool undo, int layer)
    {
        var pStatics = *(int64*)(DAT_181d66af0 + 184);
        long lVar1;
        bool cVar3;
        long lVar4;
        ulong uVar5;
        long local_res8;
        local_res8 = 0;
        lVar4 = NGUITools.AddChild(parent,undo,0);
        uVar5 = **(uint64 **)(layer + 48);
        lVar1 = *(int64 *)(pStatics + 40);
        uVar5 = Type.GetTypeFromHandle(uVar5,0);
        if (lVar1 != null) {
          cVar3 = FUN_1808addd0(lVar1,uVar5,&local_res8,DAT_181d531d0);
          if ((!cVar3) || (local_res8 == 0)) {
            puVar2 = *(uint64 **)(*(int64 *)(layer + 48) + 8);
            local_res8 = (*(code *)*puVar2)(puVar2);
            uVar5 = **(uint64 **)(layer + 48);
            lVar1 = *(int64 *)(pStatics + 40);
            uVar5 = Type.GetTypeFromHandle(uVar5,0);
            if (lVar1 == null) throw; // [null/range check failed]
            FUN_1808aec90(lVar1,uVar5,local_res8,DAT_181d53250);
          }
          if (lVar4 != null) {
            Object.set_name(lVar4,local_res8,0);
            puVar2 = *(uint64 **)(*(int64 *)(layer + 48) + 16);
            (*(code *)*puVar2)(lVar4,puVar2);
            return;
          }
        }
    }

    // Token : 0x60003CE
    // RVA   : 0x1592200   Offset: 0x1590A00   Length: 0x156
    public static GameObject AddChild(Transform parent, GameObject prefab)
    {
        var pStatics = *(int64*)(DAT_181d66af0 + 184);
        long lVar1;
        bool cVar3;
        long lVar4;
        ulong uVar5;
        long local_res8;
        local_res8 = 0;
        lVar4 = NGUITools.AddChild(parent,prefab,0);
        uVar5 = **(uint64 **)(param_3 + 48);
        lVar1 = *(int64 *)(pStatics + 40);
        uVar5 = Type.GetTypeFromHandle(uVar5,0);
        if (lVar1 != null) {
          cVar3 = FUN_1808addd0(lVar1,uVar5,&local_res8,DAT_181d531d0);
          if ((!cVar3) || (local_res8 == 0)) {
            puVar2 = *(uint64 **)(*(int64 *)(param_3 + 48) + 8);
            local_res8 = (*(code *)*puVar2)(puVar2);
            uVar5 = **(uint64 **)(param_3 + 48);
            lVar1 = *(int64 *)(pStatics + 40);
            uVar5 = Type.GetTypeFromHandle(uVar5,0);
            if (lVar1 == null) throw; // [null/range check failed]
            FUN_1808aec90(lVar1,uVar5,local_res8,DAT_181d53250);
          }
          if (lVar4 != null) {
            Object.set_name(lVar4,local_res8,0);
            puVar2 = *(uint64 **)(*(int64 *)(param_3 + 48) + 16);
            (*(code *)*puVar2)(lVar4,puVar2);
            return;
          }
        }
    }

    // Token : 0x60003CF
    // RVA   : 0x15925C0   Offset: 0x1590DC0   Length: 0x66
    public static GameObject AddChild(GameObject parent, GameObject prefab)
    {
        var pStatics = *(int64*)(DAT_181d66af0 + 184);
        long lVar1;
        bool cVar3;
        long lVar4;
        ulong uVar5;
        long local_res8;
        local_res8 = 0;
        lVar4 = NGUITools.AddChild(parent,prefab,0);
        uVar5 = **(uint64 **)(param_3 + 48);
        lVar1 = *(int64 *)(pStatics + 40);
        uVar5 = Type.GetTypeFromHandle(uVar5,0);
        if (lVar1 != null) {
          cVar3 = FUN_1808addd0(lVar1,uVar5,&local_res8,DAT_181d531d0);
          if ((!cVar3) || (local_res8 == 0)) {
            puVar2 = *(uint64 **)(*(int64 *)(param_3 + 48) + 8);
            local_res8 = (*(code *)*puVar2)(puVar2);
            uVar5 = **(uint64 **)(param_3 + 48);
            lVar1 = *(int64 *)(pStatics + 40);
            uVar5 = Type.GetTypeFromHandle(uVar5,0);
            if (lVar1 == null) throw; // [null/range check failed]
            FUN_1808aec90(lVar1,uVar5,local_res8,DAT_181d53250);
          }
          if (lVar4 != null) {
            Object.set_name(lVar4,local_res8,0);
            puVar2 = *(uint64 **)(*(int64 *)(param_3 + 48) + 16);
            (*(code *)*puVar2)(lVar4,puVar2);
            return;
          }
        }
    }

    // Token : 0x60003D0
    // RVA   : 0x1592360   Offset: 0x1590B60   Length: 0x1E9
    public static GameObject AddChild(GameObject parent, GameObject prefab, int layer)
    {
        var pStatics = *(int64*)(DAT_181d66af0 + 184);
        long lVar1;
        bool cVar3;
        long lVar4;
        ulong uVar5;
        long local_res8;
        local_res8 = 0;
        lVar4 = NGUITools.AddChild(parent,prefab,0);
        uVar5 = **(uint64 **)(layer + 48);
        lVar1 = *(int64 *)(pStatics + 40);
        uVar5 = Type.GetTypeFromHandle(uVar5,0);
        if (lVar1 != null) {
          cVar3 = FUN_1808addd0(lVar1,uVar5,&local_res8,DAT_181d531d0);
          if ((!cVar3) || (local_res8 == 0)) {
            puVar2 = *(uint64 **)(*(int64 *)(layer + 48) + 8);
            local_res8 = (*(code *)*puVar2)(puVar2);
            uVar5 = **(uint64 **)(layer + 48);
            lVar1 = *(int64 *)(pStatics + 40);
            uVar5 = Type.GetTypeFromHandle(uVar5,0);
            if (lVar1 == null) throw; // [null/range check failed]
            FUN_1808aec90(lVar1,uVar5,local_res8,DAT_181d53250);
          }
          if (lVar4 != null) {
            Object.set_name(lVar4,local_res8,0);
            puVar2 = *(uint64 **)(*(int64 *)(layer + 48) + 16);
            (*(code *)*puVar2)(lVar4,puVar2);
            return;
          }
        }
    }

    // Token : 0x60003D1
    // RVA   : 0x1593770   Offset: 0x1591F70   Length: 0x174
    public static int CalculateRaycastDepth(GameObject go)
    {
        long lVar1;
        bool cVar2;
        uint uVar3;
        uint uVar4;
        long lVar5;
        ulong uVar6;
        uint uVar7;
        int iVar8;
        ulong uVar9;
        if (go != null) {
          lVar5 = GameObject.GetComponent(go,DAT_181da2930);
          cVar2 = Object.op_Inequality(lVar5,0,0);
          if (!cVar2) {
            lVar5 = FUN_180956bf0(go,DAT_181da3230);
            if (lVar5 != null) {
              if (*(int64 *)(lVar5 + 24) == 0) {
                uVar9 = 0;
              }
              else {
                uVar7 = 0;
                uVar9 = 0x7fffffff;
                iVar8 = (int)*(int64 *)(lVar5 + 24);
                if (0 < iVar8) {
                  do {
                    if (*(uint32 *)(lVar5 + 24) <= uVar7) {
                      uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                      FUN_1800d65f0(uVar6,0);
                    }
                    if (lVar5[uVar7] == 0) throw; // [null/range check failed]
                    cVar2 = Behaviour.get_enabled();
                    if (cVar2) {
                      if (*(uint32 *)(lVar5 + 24) <= uVar7) {
                        uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                        FUN_1800d65f0(uVar6,0);
                      }
                      lVar1 = lVar5[uVar7];
                      if (lVar1 == null) throw; // [null/range check failed]
                      uVar3 = UIWidget.get_raycastDepth(lVar1,0);
                      uVar4 = Mathf.Min(uVar9,uVar3,0);
                      uVar9 = (uint64)uVar4;
                    }
                    uVar7 = uVar7 + 1;
                  } while ((int)uVar7 < iVar8);
                }
              }
              return uVar9;
            }
          }
          else if (lVar5 != null) {
            uVar9 = UIWidget.get_raycastDepth(lVar5,0);
            return uVar9;
          }
        }
    }

    // Token : 0x60003D2
    // RVA   : 0x1593360   Offset: 0x1591B60   Length: 0xF7
    public static int CalculateNextDepth(GameObject go)
    {
        int iVar1;
        long lVar2;
        bool cVar4;
        int iVar5;
        int iVar6;
        long lVar7;
        ulong uVar8;
        uint uVar9;
        bVar3 = Object.op_Implicit(go,0);
        if ((param_2 & bVar3) == 0) {
          cVar4 = Object.op_Implicit(go,0);
          if (!cVar4) {
            return 0;
          }
          iVar6 = -1;
          iVar5 = -1;
          if (go != null) {
            lVar7 = FUN_180956bf0(go,DAT_181da3230);
            uVar9 = 0;
            if (lVar7 != null) {
              iVar1 = *(int *)(lVar7 + 24);
              if (0 < iVar1) {
                do {
                  if (*(uint32 *)(lVar7 + 24) <= uVar9) {
                    uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                    FUN_1800d65f0(uVar8,0);
                  }
                  lVar2 = lVar7[uVar9];
                  if (lVar2 == null) throw; // [null/range check failed]
                  iVar5 = Mathf.Max(iVar6,*(uint32 *)(lVar2 + 172),0);
                  uVar9 = uVar9 + 1;
                  iVar6 = iVar5;
                } while ((int)uVar9 < iVar1);
              }
              return iVar5 + 1;
            }
          }
        }
        else {
          iVar6 = -1;
          if (go != null) {
            lVar7 = FUN_180956bf0(go,DAT_181da3230);
            uVar9 = 0;
            if (lVar7 != null) {
              iVar5 = *(int *)(lVar7 + 24);
              iVar1 = -1;
              if (0 < iVar5) {
                do {
                  iVar6 = iVar1;
                  if (*(uint32 *)(lVar7 + 24) <= uVar9) {
                    uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                    FUN_1800d65f0(uVar8,0);
                  }
                  lVar2 = lVar7[uVar9];
                  if (lVar2 == null) throw; // [null/range check failed]
                  uVar8 = UIRect.get_cachedGameObject(lVar2,0);
                  cVar4 = Object.op_Inequality(uVar8,go,0);
                  if (!cVar4) {
        LAB_18159371d:
                    iVar6 = Mathf.Max(iVar6);
                  }
                  else {
                    uVar8 = Component.GetComponent(lVar2);
                    cVar4 = Object.op_Inequality(uVar8,0,0);
                    if (!cVar4) {
                      uVar8 = Component.GetComponent(lVar2);
                      cVar4 = Object.op_Inequality(uVar8,0,0);
                      if (!cVar4) goto LAB_18159371d;
                    }
                  }
                  uVar9 = uVar9 + 1;
                  iVar1 = iVar6;
                } while ((int)uVar9 < iVar5);
              }
              return iVar6 + 1;
            }
          }
        }
    }

    // Token : 0x60003D3
    // RVA   : 0x1593460   Offset: 0x1591C60   Length: 0x307
    public static int CalculateNextDepth(GameObject go, bool ignoreChildrenWithColliders)
    {
        int iVar1;
        long lVar2;
        bool cVar4;
        int iVar5;
        int iVar6;
        long lVar7;
        ulong uVar8;
        uint uVar9;
        bVar3 = Object.op_Implicit(go,0);
        if ((ignoreChildrenWithColliders & bVar3) == 0) {
          cVar4 = Object.op_Implicit(go,0);
          if (!cVar4) {
            return false;
          }
          iVar6 = -1;
          iVar5 = -1;
          if (go != null) {
            lVar7 = FUN_180956bf0(go,DAT_181da3230);
            uVar9 = 0;
            if (lVar7 != null) {
              iVar1 = *(int *)(lVar7 + 24);
              if (0 < iVar1) {
                do {
                  if (*(uint32 *)(lVar7 + 24) <= uVar9) {
                    uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                    FUN_1800d65f0(uVar8,0);
                  }
                  lVar2 = lVar7[uVar9];
                  if (lVar2 == null) throw; // [null/range check failed]
                  iVar5 = Mathf.Max(iVar6,*(uint32 *)(lVar2 + 172),0);
                  uVar9 = uVar9 + 1;
                  iVar6 = iVar5;
                } while ((int)uVar9 < iVar1);
              }
              return iVar5 + 1;
            }
          }
        }
        else {
          iVar6 = -1;
          if (go != null) {
            lVar7 = FUN_180956bf0(go,DAT_181da3230);
            uVar9 = 0;
            if (lVar7 != null) {
              iVar5 = *(int *)(lVar7 + 24);
              iVar1 = -1;
              if (0 < iVar5) {
                do {
                  iVar6 = iVar1;
                  if (*(uint32 *)(lVar7 + 24) <= uVar9) {
                    uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                    FUN_1800d65f0(uVar8,0);
                  }
                  lVar2 = lVar7[uVar9];
                  if (lVar2 == null) throw; // [null/range check failed]
                  uVar8 = UIRect.get_cachedGameObject(lVar2,0);
                  cVar4 = Object.op_Inequality(uVar8,go,0);
                  if (!cVar4) {
        LAB_18159371d:
                    iVar6 = Mathf.Max(iVar6);
                  }
                  else {
                    uVar8 = Component.GetComponent(lVar2);
                    cVar4 = Object.op_Inequality(uVar8,0,0);
                    if (!cVar4) {
                      uVar8 = Component.GetComponent(lVar2);
                      cVar4 = Object.op_Inequality(uVar8,0,0);
                      if (!cVar4) goto LAB_18159371d;
                    }
                  }
                  uVar9 = uVar9 + 1;
                  iVar1 = iVar6;
                } while ((int)uVar9 < iVar5);
              }
              return iVar6 + 1;
            }
          }
        }
    }

    // Token : 0x60003D4
    // RVA   : 0x1592D20   Offset: 0x1591520   Length: 0x29F
    public static int AdjustDepth(GameObject go, int adjustment)
    {
        int iVar1;
        long lVar2;
        ulong uVar3;
        bool cVar4;
        ulong uVar5;
        long lVar6;
        uint uVar7;
        cVar4 = Object.op_Inequality(go,0,0);
        if (!cVar4) {
          return 0;
        }
        if (go != null) {
          uVar5 = GameObject.GetComponent(go,DAT_181da2830);
          cVar4 = Object.op_Inequality(uVar5,0,0);
          if (!cVar4) {
            uVar5 = NGUITools.FindInParents(go,DAT_181d66900);
            cVar4 = Object.op_Equality(uVar5,0,0);
            if (!cVar4) {
              lVar6 = GameObject.GetComponentsInChildren(go,1,DAT_181da34b0);
              uVar7 = 0;
              if (lVar6 == null) throw; // [null/range check failed]
              iVar1 = *(int *)(lVar6 + 24);
              if (0 < iVar1) {
                do {
                  if (*(uint32 *)(lVar6 + 24) <= uVar7) {
                    uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                    FUN_1800d65f0(uVar5,0);
                  }
                  lVar2 = lVar6[uVar7];
                  if (lVar2 == null) throw; // [null/range check failed]
                  uVar3 = *(uint64 *)(lVar2 + 232);
                  cVar4 = Object.op_Inequality(uVar3,uVar5,0);
                  if (!cVar4) {
                    UIWidget.set_depth(lVar2);
                  }
                  uVar7 = uVar7 + 1;
                } while ((int)uVar7 < iVar1);
              }
              uVar5 = 2;
            }
            else {
              uVar5 = 0;
            }
          }
          else {
            lVar6 = GameObject.GetComponentsInChildren(go,1,DAT_181da3430);
            uVar7 = 0;
            if (lVar6 == null) throw; // [null/range check failed]
            while( true ) {
              if ((int)*(uint32 *)(lVar6 + 24) <= (int)uVar7) break;
              if (*(uint32 *)(lVar6 + 24) <= uVar7) {
                uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar5,0);
              }
              lVar2 = lVar6[uVar7];
              if (lVar2 == null) throw; // [null/range check failed]
              UIPanel.set_depth(lVar2,*(int *)(lVar2 + 0x150) + adjustment,0);
              uVar7 = uVar7 + 1;
            }
            uVar5 = 1;
          }
          return uVar5;
        }
    }

    // Token : 0x60003D5
    // RVA   : 0x1593030   Offset: 0x1591830   Length: 0xB7
    public static void BringForward(GameObject go)
    {
        int iVar1;
        iVar1 = NGUITools.AdjustDepth(go,1000,0);
        if (iVar1 != 1) {
          if (iVar1 == 2) {
            NGUITools.NormalizeWidgetDepths(0);
            return;
          }
          return;
        }
        NGUITools.NormalizePanelDepths(0);
    }

    // Token : 0x60003D6
    // RVA   : 0x159BB00   Offset: 0x159A300   Length: 0xB7
    public static void PushBack(GameObject go)
    {
        int iVar1;
        iVar1 = NGUITools.AdjustDepth(go,0xfffffc18,0);
        if (iVar1 != 1) {
          if (iVar1 == 2) {
            NGUITools.NormalizeWidgetDepths(0);
            return;
          }
          return;
        }
        NGUITools.NormalizePanelDepths(0);
    }

    // Token : 0x60003D7
    // RVA   : 0x159AB70   Offset: 0x1599370   Length: 0xAC
    public static void NormalizeDepths()
    {
        ulong uVar1;
        uVar1 = NGUITools.FindActive(DAT_181d66580);
        NGUITools.NormalizeWidgetDepths(uVar1,0);
        NGUITools.NormalizePanelDepths(0);
    }

    // Token : 0x60003D8
    // RVA   : 0x159AF60   Offset: 0x1599760   Length: 0x64
    public static void NormalizeWidgetDepths()
    {
        int iVar1;
        int iVar2;
        long lVar3;
        int iVar4;
        int iVar5;
        ulong uVar6;
        uint uVar7;
        int iVar8;
        int iVar9;
        if (param_1 != 0) {
          iVar1 = *(int *)(param_1 + 24);
          if (0 < iVar1) {
            uVar6 = new OnTooltipCB(0,DAT_181d9de18,DAT_181d86618);
            FUN_18094ed60(param_1,uVar6,DAT_181d57618);
            iVar9 = 0;
            if (*(int *)(param_1 + 24) == 0) {
              uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar6,0);
            }
            if (*(int64 *)(param_1 + 32) == 0) throw; // [null/range check failed]
            uVar7 = 0;
            iVar8 = *(int *)(*(int64 *)(param_1 + 32) + 172);
            do {
              if (*(uint32 *)(param_1 + 24) <= uVar7) {
                uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar6,0);
              }
              lVar3 = param_1[uVar7];
              if (lVar3 == null) throw; // [null/range check failed]
              iVar2 = *(int *)(lVar3 + 172);
              iVar5 = iVar9 + 1;
              iVar4 = iVar2;
              if (iVar2 == iVar8) {
                iVar5 = iVar9;
                iVar4 = iVar8;
              }
              UIWidget.set_depth(lVar3,iVar5,0);
              uVar7 = uVar7 + 1;
              iVar5 = iVar9 + 1;
              if (iVar2 == iVar8) {
                iVar5 = iVar9;
              }
              iVar9 = iVar5;
              iVar8 = iVar4;
            } while ((int)uVar7 < iVar1);
          }
          return;
        }
    }

    // Token : 0x60003D9
    // RVA   : 0x159AFD0   Offset: 0x15997D0   Length: 0x7A
    public static void NormalizeWidgetDepths(GameObject go)
    {
        int iVar1;
        int iVar2;
        long lVar3;
        int iVar4;
        int iVar5;
        ulong uVar6;
        uint uVar7;
        int iVar8;
        int iVar9;
        if (go != null) {
          iVar1 = *(int *)(go + 24);
          if (0 < iVar1) {
            uVar6 = new OnTooltipCB(0,DAT_181d9de18,DAT_181d86618);
            FUN_18094ed60(go,uVar6,DAT_181d57618);
            iVar9 = 0;
            if (*(int *)(go + 24) == 0) {
              uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar6,0);
            }
            if (*(int64 *)(go + 32) == 0) throw; // [null/range check failed]
            uVar7 = 0;
            iVar8 = *(int *)(*(int64 *)(go + 32) + 172);
            do {
              if (*(uint32 *)(go + 24) <= uVar7) {
                uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar6,0);
              }
              lVar3 = go[uVar7];
              if (lVar3 == null) throw; // [null/range check failed]
              iVar2 = *(int *)(lVar3 + 172);
              iVar5 = iVar9 + 1;
              iVar4 = iVar2;
              if (iVar2 == iVar8) {
                iVar5 = iVar9;
                iVar4 = iVar8;
              }
              UIWidget.set_depth(lVar3,iVar5,0);
              uVar7 = uVar7 + 1;
              iVar5 = iVar9 + 1;
              if (iVar2 == iVar8) {
                iVar5 = iVar9;
              }
              iVar9 = iVar5;
              iVar8 = iVar4;
            } while ((int)uVar7 < iVar1);
          }
          return;
        }
    }

    // Token : 0x60003DA
    // RVA   : 0x159ADE0   Offset: 0x15995E0   Length: 0x178
    public static void NormalizeWidgetDepths(UIWidget[] list)
    {
        int iVar1;
        int iVar2;
        long lVar3;
        int iVar4;
        int iVar5;
        ulong uVar6;
        uint uVar7;
        int iVar8;
        int iVar9;
        if (list != null) {
          iVar1 = *(int *)(list + 24);
          if (0 < iVar1) {
            uVar6 = new OnTooltipCB(0,DAT_181d9de18,DAT_181d86618);
            FUN_18094ed60(list,uVar6,DAT_181d57618);
            iVar9 = 0;
            if (*(int *)(list + 24) == 0) {
              uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar6,0);
            }
            if (*(int64 *)(list + 32) == 0) throw; // [null/range check failed]
            uVar7 = 0;
            iVar8 = *(int *)(*(int64 *)(list + 32) + 172);
            do {
              if (*(uint32 *)(list + 24) <= uVar7) {
                uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar6,0);
              }
              lVar3 = list[uVar7];
              if (lVar3 == null) throw; // [null/range check failed]
              iVar2 = *(int *)(lVar3 + 172);
              iVar5 = iVar9 + 1;
              iVar4 = iVar2;
              if (iVar2 == iVar8) {
                iVar5 = iVar9;
                iVar4 = iVar8;
              }
              UIWidget.set_depth(lVar3,iVar5,0);
              uVar7 = uVar7 + 1;
              iVar5 = iVar9 + 1;
              if (iVar2 == iVar8) {
                iVar5 = iVar9;
              }
              iVar9 = iVar5;
              iVar8 = iVar4;
            } while ((int)uVar7 < iVar1);
          }
          return;
        }
    }

    // Token : 0x60003DB
    // RVA   : 0x159AC20   Offset: 0x1599420   Length: 0x1B8
    public static void NormalizePanelDepths()
    {
        int iVar1;
        int iVar2;
        long lVar3;
        int iVar4;
        int iVar5;
        long lVar6;
        ulong uVar7;
        uint uVar8;
        int iVar9;
        int iVar10;
        lVar6 = NGUITools.FindActive(DAT_181d66480);
        if (lVar6 != null) {
          iVar1 = *(int *)(lVar6 + 24);
          if (0 < iVar1) {
            uVar7 = new OnTooltipCB(0,DAT_181d9cc90,DAT_181d86518);
            FUN_18094ed60(lVar6,uVar7,DAT_181d57598);
            iVar10 = 0;
            if (*(int *)(lVar6 + 24) == 0) {
              uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar7,0);
            }
            if (*(int64 *)(lVar6 + 32) == 0) throw; // [null/range check failed]
            uVar8 = 0;
            iVar9 = *(int *)(*(int64 *)(lVar6 + 32) + 0x150);
            do {
              if (*(uint32 *)(lVar6 + 24) <= uVar8) {
                uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar7,0);
              }
              lVar3 = lVar6[uVar8];
              if (lVar3 == null) throw; // [null/range check failed]
              iVar2 = *(int *)(lVar3 + 0x150);
              iVar5 = iVar10 + 1;
              iVar4 = iVar2;
              if (iVar2 == iVar9) {
                iVar5 = iVar10;
                iVar4 = iVar9;
              }
              UIPanel.set_depth(lVar3,iVar5,0);
              uVar8 = uVar8 + 1;
              iVar5 = iVar10 + 1;
              if (iVar2 == iVar9) {
                iVar5 = iVar10;
              }
              iVar10 = iVar5;
              iVar9 = iVar4;
            } while ((int)uVar8 < iVar1);
          }
          return;
        }
    }

    // Token : 0x60003DC
    // RVA   : 0x1596630   Offset: 0x1594E30   Length: 0x59
    public static UIPanel CreateUI(bool advanced3D)
    {
        var pStatics_ac58 = *(int64*)(DAT_181d8ac58 + 184);
        var pStatics_af58 = *(int64*)(DAT_181d8af58 + 184);
        bool cVar1;
        int iVar3;
        int iVar4;
        uint uVar5;
        uint uVar6;
        ulong uVar7;
        long lVar8;
        long lVar9;
        long lVar10;
        int iVar12;
        float fVar13;
        long[] local_98 = new long[2];
        ulong local_88;
        uint uStack_80;
        uint32 uStack_7c;
        int64 local_78;
        uint64 local_60;
        uint64 uStack_58;
        int64 local_50;
        local_60 = 0;
        uStack_58 = 0;
        local_50 = 0;
        cVar1 = Object.op_Inequality(advanced3D,0,0);
        if (!cVar1) {
          lVar8 = 0;
        }
        else {
          if (advanced3D == null) throw; // [null/range check failed]
          uVar7 = Component.get_gameObject(advanced3D,0);
          lVar8 = NGUITools.FindInParents(uVar7,DAT_181d66b00);
        }
        iVar12 = 0;
        local_98[0] = lVar8;
        cVar1 = Object.op_Equality(lVar8,0,0);
        if (cVar1) {
          if (*pStatics_af58 == 0) throw; // [null/range check failed]
          if (0 < *(int *)(*pStatics_af58 + 24)) {
            if (*pStatics_af58 == 0) throw; // [null/range check failed]
            FUN_1817ff240(&local_88,*pStatics_af58,DAT_181d82bf8);
            local_60 = local_88;
            uStack_58 = CONCAT44(uStack_7c,uStack_80);
            local_50 = local_78;
            do {
              cVar1 = FUN_180d197a0(&local_60,DAT_181d6ce38);
              lVar10 = local_50;
              if (!cVar1) {
                ZhSegment.Initialize(&local_60,DAT_181d6cdb8);
                goto LAB_181595c5a;
              }
              if (local_50 == 0) {
                          // WARNING: Subroutine does not return
                FUN_1800d6620();
              }
              lVar9 = Component.get_gameObject(local_50,0);
              if (lVar9 == null) {
                          // WARNING: Subroutine does not return
                FUN_1800d6620();
              }
              iVar3 = GameObject.get_layer(lVar9,0);
            } while (iVar3 != param_3);
            local_98[0] = lVar10;
            ZhSegment.Initialize(&local_60,DAT_181d6cdb8);
            lVar8 = lVar10;
          }
        }
        LAB_181595c5a:
        cVar1 = Object.op_Equality(lVar8,0,0);
        if (cVar1) {
          if (*pStatics_ac58 == 0) throw; // [null/range check failed]
          iVar3 = *(int *)(*pStatics_ac58 + 24);
          if (0 < iVar3) {
            do {
              if (((*pStatics_ac58 == 0) ||
                  (lVar10 = FUN_180002f80(*pStatics_ac58,iVar12,DAT_181d82978),
                  lVar10 == null)) || (lVar9 = Component.get_gameObject(lVar10,0)) == null)
              throw; // [null/range check failed]
              iVar4 = Object.get_hideFlags(lVar9,0);
              if ((iVar4 == 0) && (iVar4 = GameObject.get_layer(lVar9,0), iVar4 == param_3)) {
                uVar7 = Component.get_transform(lVar10,0);
                if (advanced3D != null) {
                  Transform.set_parent(advanced3D,uVar7,0);
                  puVar11 = (uint64 *)Vector3.get_one(local_98,0);
                  local_88 = *puVar11;
                  uStack_80 = *(uint32 *)(puVar11 + 1);
                  Transform.set_localScale(advanced3D,&local_88,0);
                  return lVar10;
                }
                throw; // [null/range check failed]
              }
              iVar12 = iVar12 + 1;
            } while (iVar12 < iVar3);
          }
        }
        cVar1 = Object.op_Inequality(lVar8,0,0);
        if (cVar1) {
          if (lVar8 == null) throw; // [null/range check failed]
          lVar10 = Component.GetComponentInChildren(lVar8,DAT_181d6ec40);
          cVar1 = Object.op_Inequality(lVar10,0,0);
          if (cVar1) {
            if ((lVar10 == null) || (lVar10 = Component.GetComponent(lVar10,DAT_181d6afc0)) == null)
            throw; // [null/range check failed]
            cVar1 = Camera.get_orthographic(lVar10,0);
            if (cVar1 == param_2) {
              advanced3D = 0;
              lVar8 = 0;
            }
          }
        }
        cVar1 = Object.op_Equality(lVar8,0,0);
        if (cVar1) {
          lVar10 = new GameObject(0);
          cVar1 = Object.op_Inequality(0,0,0);
          if (lVar10 == null) throw; // [null/range check failed]
          if (cVar1) {
            GameObject.get_transform(lVar10,0);
            throw; // [null/range check failed]
          }
          lVar8 = GameObject.AddComponent(lVar10,DAT_181d9def8);
          if ((param_3 == -1) && (param_3 = LayerMask.NameToLayer("UI",0), param_3 == -1)) {
            param_3 = LayerMask.NameToLayer("2D UI",0);
          }
          GameObject.set_layer(lVar10,param_3,0);
          if (!param_2) {
            Object.set_name(lVar10,"UI Root",0);
            if (lVar8 == null) throw; // [null/range check failed]
            uVar6 = 0;
          }
          else {
            Object.set_name(lVar10,"UI Root (3D)",0);
            if (lVar8 == null) throw; // [null/range check failed]
            uVar6 = 1;
          }
          *(uint32 *)(lVar8 + 24) = uVar6;
          UIRoot.UpdateScale(lVar8,1,0);
        }
        if (lVar8 == null) throw; // [null/range check failed]
        lVar10 = Component.GetComponentInChildren(lVar8,DAT_181d6edc0);
        cVar1 = Object.op_Equality(lVar10,0,0);
        if (cVar1) {
          lVar10 = NGUITools.FindActive(DAT_181d66300);
          fVar13 = -1.0;
          cVar1 = false;
          lVar9 = Component.get_gameObject(lVar8,0);
          if (lVar9 == null) throw; // [null/range check failed]
          bVar2 = GameObject.get_layer(lVar9,0);
          uVar5 = 0;
          if (lVar10 == null) throw; // [null/range check failed]
          for (; (int)uVar5 < (int)*(uint32 *)(lVar10 + 24); uVar5 = uVar5 + 1) {
            if (*(uint32 *)(lVar10 + 24) <= uVar5) {
              uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar7,0);
            }
            lVar9 = lVar10[uVar5];
            if (lVar9 == null) throw; // [null/range check failed]
            iVar12 = Camera.get_clearFlags(lVar9,0);
            if ((iVar12 == 2) || (iVar12 = Camera.get_clearFlags(lVar9,0), iVar12 == 1)) {
              cVar1 = true;
            }
            uVar7 = Camera.get_depth(lVar9,0);
            fVar13 = (float)Mathf.Max(fVar13,uVar7,0);
            Camera.get_cullingMask(lVar9,0);
            Camera.set_cullingMask(lVar9);
          }
          uVar7 = Component.get_gameObject(lVar8,0);
          lVar10 = NGUITools.AddChild(uVar7,0);
          if ((lVar10 == null) || (lVar9 = Component.get_gameObject(lVar10,0)) == null)
          throw; // [null/range check failed]
          GameObject.AddComponent(lVar9,DAT_181d9dbc8);
          Camera.set_clearFlags(lVar10,cVar1 + '\x02');
          puVar11 = (uint64 *)FUN_1810988d0(&local_88,0);
          local_88 = *puVar11;
          uStack_80 = *(uint32 *)(puVar11 + 1);
          uStack_7c = *(uint32 *)((int64)puVar11 + 12);
          Camera.set_backgroundColor(lVar10,&local_88);
          Camera.set_cullingMask(lVar10,1 << (bVar2 & 31));
          Camera.set_depth(lVar10,fVar13 + 1.0);
          if (!param_2) {
            Camera.set_orthographic(lVar10,1);
            Camera.set_orthographicSize(lVar10,0x3f800000,0);
            Camera.set_nearClipPlane(lVar10,0xc1200000,0);
            Camera.set_farClipPlane(lVar10,0x41200000,0);
          }
          else {
            Camera.set_nearClipPlane(lVar10,0x3dcccccd);
            Camera.set_farClipPlane(lVar10,0x40800000,0);
            lVar9 = Component.get_transform(lVar10,0);
            if (lVar9 == null) throw; // [null/range check failed]
            local_88 = 0;
            uStack_80 = 0xc42f0000;
            Transform.set_localPosition(lVar9,&local_88,0);
          }
          lVar9 = NGUITools.FindActive(DAT_181d66280);
          if ((lVar9 == null) || (*(int64 *)(lVar9 + 24) == 0)) {
            lVar10 = Component.get_gameObject(lVar10,0);
            if (lVar10 == null) throw; // [null/range check failed]
            GameObject.AddComponent(lVar10,DAT_181d9be90);
          }
          lVar8 = Component.get_gameObject(lVar8,0);
          if (lVar8 == null) throw; // [null/range check failed]
          lVar10 = GameObject.AddComponent(lVar8,DAT_181d9de70);
        }
        cVar1 = Object.op_Inequality(advanced3D,0,0);
        if (!cVar1) {
          return lVar10;
        }
        if (advanced3D != null) {
          while( true ) {
            uVar7 = FUN_180da0f00(advanced3D,0);
            cVar1 = Object.op_Inequality(uVar7,0,0);
            if (!cVar1) break;
            if ((advanced3D == null) || (advanced3D = FUN_180da0f00(advanced3D)) == null) throw; // [null/range check failed]
          }
          if (lVar10 != null) {
            lVar8 = Component.get_transform(lVar10,0);
            if (lVar8 != null) {
              cVar1 = Transform.IsChildOf(lVar8,advanced3D,0);
              if (!cVar1) {
                uVar7 = Component.get_transform(lVar10,0);
                if (advanced3D != null) {
                  Transform.set_parent(advanced3D,uVar7,0);
                  puVar11 = (uint64 *)Vector3.get_one(local_98,0);
                  local_88 = *puVar11;
                  uStack_80 = *(uint32 *)(puVar11 + 1);
                  Transform.set_localScale(advanced3D,&local_88,0);
                  puVar11 = (uint64 *)Vector3.get_zero(local_98,0);
                  local_88 = *puVar11;
                  uStack_80 = *(uint32 *)(puVar11 + 1);
                  Transform.set_localPosition(advanced3D,&local_88,0);
                  uVar7 = UIRect.get_cachedTransform(lVar10,0);
                  lVar8 = UIRect.get_cachedGameObject(lVar10,0);
                  if (lVar8 != null) {
                    uVar6 = GameObject.get_layer(lVar8,0);
                    NGUITools.SetChildLayer(uVar7,uVar6,0);
                    return lVar10;
                  }
                }
              }
              else if ((advanced3D != null) && (lVar8 = Component.get_gameObject(advanced3D,0)) != null) {
                lVar8 = GameObject.AddComponent(lVar8,DAT_181d9de70);
                return lVar8;
              }
            }
          }
        }
    }

    // Token : 0x60003DD
    // RVA   : 0x15965C0   Offset: 0x1594DC0   Length: 0x64
    public static UIPanel CreateUI(bool advanced3D, int layer)
    {
        var pStatics_ac58 = *(int64*)(DAT_181d8ac58 + 184);
        var pStatics_af58 = *(int64*)(DAT_181d8af58 + 184);
        bool cVar1;
        int iVar3;
        int iVar4;
        uint uVar5;
        uint uVar6;
        ulong uVar7;
        long lVar8;
        long lVar9;
        long lVar10;
        int iVar12;
        float fVar13;
        long[] local_98 = new long[2];
        ulong local_88;
        uint uStack_80;
        uint32 uStack_7c;
        int64 local_78;
        uint64 local_60;
        uint64 uStack_58;
        int64 local_50;
        local_60 = 0;
        uStack_58 = 0;
        local_50 = 0;
        cVar1 = Object.op_Inequality(advanced3D,0,0);
        if (!cVar1) {
          lVar8 = 0;
        }
        else {
          if (advanced3D == null) throw; // [null/range check failed]
          uVar7 = Component.get_gameObject(advanced3D,0);
          lVar8 = NGUITools.FindInParents(uVar7,DAT_181d66b00);
        }
        iVar12 = 0;
        local_98[0] = lVar8;
        cVar1 = Object.op_Equality(lVar8,0,0);
        if (cVar1) {
          if (*pStatics_af58 == 0) throw; // [null/range check failed]
          if (0 < *(int *)(*pStatics_af58 + 24)) {
            if (*pStatics_af58 == 0) throw; // [null/range check failed]
            FUN_1817ff240(&local_88,*pStatics_af58,DAT_181d82bf8);
            local_60 = local_88;
            uStack_58 = CONCAT44(uStack_7c,uStack_80);
            local_50 = local_78;
            do {
              cVar1 = FUN_180d197a0(&local_60,DAT_181d6ce38);
              lVar10 = local_50;
              if (!cVar1) {
                ZhSegment.Initialize(&local_60,DAT_181d6cdb8);
                goto LAB_181595c5a;
              }
              if (local_50 == 0) {
                          // WARNING: Subroutine does not return
                FUN_1800d6620();
              }
              lVar9 = Component.get_gameObject(local_50,0);
              if (lVar9 == null) {
                          // WARNING: Subroutine does not return
                FUN_1800d6620();
              }
              iVar3 = GameObject.get_layer(lVar9,0);
            } while (iVar3 != param_3);
            local_98[0] = lVar10;
            ZhSegment.Initialize(&local_60,DAT_181d6cdb8);
            lVar8 = lVar10;
          }
        }
        LAB_181595c5a:
        cVar1 = Object.op_Equality(lVar8,0,0);
        if (cVar1) {
          if (*pStatics_ac58 == 0) throw; // [null/range check failed]
          iVar3 = *(int *)(*pStatics_ac58 + 24);
          if (0 < iVar3) {
            do {
              if (((*pStatics_ac58 == 0) ||
                  (lVar10 = FUN_180002f80(*pStatics_ac58,iVar12,DAT_181d82978),
                  lVar10 == null)) || (lVar9 = Component.get_gameObject(lVar10,0)) == null)
              throw; // [null/range check failed]
              iVar4 = Object.get_hideFlags(lVar9,0);
              if ((iVar4 == 0) && (iVar4 = GameObject.get_layer(lVar9,0), iVar4 == param_3)) {
                uVar7 = Component.get_transform(lVar10,0);
                if (advanced3D != null) {
                  Transform.set_parent(advanced3D,uVar7,0);
                  puVar11 = (uint64 *)Vector3.get_one(local_98,0);
                  local_88 = *puVar11;
                  uStack_80 = *(uint32 *)(puVar11 + 1);
                  Transform.set_localScale(advanced3D,&local_88,0);
                  return lVar10;
                }
                throw; // [null/range check failed]
              }
              iVar12 = iVar12 + 1;
            } while (iVar12 < iVar3);
          }
        }
        cVar1 = Object.op_Inequality(lVar8,0,0);
        if (cVar1) {
          if (lVar8 == null) throw; // [null/range check failed]
          lVar10 = Component.GetComponentInChildren(lVar8,DAT_181d6ec40);
          cVar1 = Object.op_Inequality(lVar10,0,0);
          if (cVar1) {
            if ((lVar10 == null) || (lVar10 = Component.GetComponent(lVar10,DAT_181d6afc0)) == null)
            throw; // [null/range check failed]
            cVar1 = Camera.get_orthographic(lVar10,0);
            if (cVar1 == layer) {
              advanced3D = 0;
              lVar8 = 0;
            }
          }
        }
        cVar1 = Object.op_Equality(lVar8,0,0);
        if (cVar1) {
          lVar10 = new GameObject(0);
          cVar1 = Object.op_Inequality(0,0,0);
          if (lVar10 == null) throw; // [null/range check failed]
          if (cVar1) {
            GameObject.get_transform(lVar10,0);
            throw; // [null/range check failed]
          }
          lVar8 = GameObject.AddComponent(lVar10,DAT_181d9def8);
          if ((param_3 == -1) && (param_3 = LayerMask.NameToLayer("UI",0), param_3 == -1)) {
            param_3 = LayerMask.NameToLayer("2D UI",0);
          }
          GameObject.set_layer(lVar10,param_3,0);
          if (!layer) {
            Object.set_name(lVar10,"UI Root",0);
            if (lVar8 == null) throw; // [null/range check failed]
            uVar6 = 0;
          }
          else {
            Object.set_name(lVar10,"UI Root (3D)",0);
            if (lVar8 == null) throw; // [null/range check failed]
            uVar6 = 1;
          }
          *(uint32 *)(lVar8 + 24) = uVar6;
          UIRoot.UpdateScale(lVar8,1,0);
        }
        if (lVar8 == null) throw; // [null/range check failed]
        lVar10 = Component.GetComponentInChildren(lVar8,DAT_181d6edc0);
        cVar1 = Object.op_Equality(lVar10,0,0);
        if (cVar1) {
          lVar10 = NGUITools.FindActive(DAT_181d66300);
          fVar13 = -1.0;
          cVar1 = false;
          lVar9 = Component.get_gameObject(lVar8,0);
          if (lVar9 == null) throw; // [null/range check failed]
          bVar2 = GameObject.get_layer(lVar9,0);
          uVar5 = 0;
          if (lVar10 == null) throw; // [null/range check failed]
          for (; (int)uVar5 < (int)*(uint32 *)(lVar10 + 24); uVar5 = uVar5 + 1) {
            if (*(uint32 *)(lVar10 + 24) <= uVar5) {
              uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar7,0);
            }
            lVar9 = lVar10[uVar5];
            if (lVar9 == null) throw; // [null/range check failed]
            iVar12 = Camera.get_clearFlags(lVar9,0);
            if ((iVar12 == 2) || (iVar12 = Camera.get_clearFlags(lVar9,0), iVar12 == 1)) {
              cVar1 = true;
            }
            uVar7 = Camera.get_depth(lVar9,0);
            fVar13 = (float)Mathf.Max(fVar13,uVar7,0);
            Camera.get_cullingMask(lVar9,0);
            Camera.set_cullingMask(lVar9);
          }
          uVar7 = Component.get_gameObject(lVar8,0);
          lVar10 = NGUITools.AddChild(uVar7,0);
          if ((lVar10 == null) || (lVar9 = Component.get_gameObject(lVar10,0)) == null)
          throw; // [null/range check failed]
          GameObject.AddComponent(lVar9,DAT_181d9dbc8);
          Camera.set_clearFlags(lVar10,cVar1 + '\x02');
          puVar11 = (uint64 *)FUN_1810988d0(&local_88,0);
          local_88 = *puVar11;
          uStack_80 = *(uint32 *)(puVar11 + 1);
          uStack_7c = *(uint32 *)((int64)puVar11 + 12);
          Camera.set_backgroundColor(lVar10,&local_88);
          Camera.set_cullingMask(lVar10,1 << (bVar2 & 31));
          Camera.set_depth(lVar10,fVar13 + 1.0);
          if (!layer) {
            Camera.set_orthographic(lVar10,1);
            Camera.set_orthographicSize(lVar10,0x3f800000,0);
            Camera.set_nearClipPlane(lVar10,0xc1200000,0);
            Camera.set_farClipPlane(lVar10,0x41200000,0);
          }
          else {
            Camera.set_nearClipPlane(lVar10,0x3dcccccd);
            Camera.set_farClipPlane(lVar10,0x40800000,0);
            lVar9 = Component.get_transform(lVar10,0);
            if (lVar9 == null) throw; // [null/range check failed]
            local_88 = 0;
            uStack_80 = 0xc42f0000;
            Transform.set_localPosition(lVar9,&local_88,0);
          }
          lVar9 = NGUITools.FindActive(DAT_181d66280);
          if ((lVar9 == null) || (*(int64 *)(lVar9 + 24) == 0)) {
            lVar10 = Component.get_gameObject(lVar10,0);
            if (lVar10 == null) throw; // [null/range check failed]
            GameObject.AddComponent(lVar10,DAT_181d9be90);
          }
          lVar8 = Component.get_gameObject(lVar8,0);
          if (lVar8 == null) throw; // [null/range check failed]
          lVar10 = GameObject.AddComponent(lVar8,DAT_181d9de70);
        }
        cVar1 = Object.op_Inequality(advanced3D,0,0);
        if (!cVar1) {
          return lVar10;
        }
        if (advanced3D != null) {
          while( true ) {
            uVar7 = FUN_180da0f00(advanced3D,0);
            cVar1 = Object.op_Inequality(uVar7,0,0);
            if (!cVar1) break;
            if ((advanced3D == null) || (advanced3D = FUN_180da0f00(advanced3D)) == null) throw; // [null/range check failed]
          }
          if (lVar10 != null) {
            lVar8 = Component.get_transform(lVar10,0);
            if (lVar8 != null) {
              cVar1 = Transform.IsChildOf(lVar8,advanced3D,0);
              if (!cVar1) {
                uVar7 = Component.get_transform(lVar10,0);
                if (advanced3D != null) {
                  Transform.set_parent(advanced3D,uVar7,0);
                  puVar11 = (uint64 *)Vector3.get_one(local_98,0);
                  local_88 = *puVar11;
                  uStack_80 = *(uint32 *)(puVar11 + 1);
                  Transform.set_localScale(advanced3D,&local_88,0);
                  puVar11 = (uint64 *)Vector3.get_zero(local_98,0);
                  local_88 = *puVar11;
                  uStack_80 = *(uint32 *)(puVar11 + 1);
                  Transform.set_localPosition(advanced3D,&local_88,0);
                  uVar7 = UIRect.get_cachedTransform(lVar10,0);
                  lVar8 = UIRect.get_cachedGameObject(lVar10,0);
                  if (lVar8 != null) {
                    uVar6 = GameObject.get_layer(lVar8,0);
                    NGUITools.SetChildLayer(uVar7,uVar6,0);
                    return lVar10;
                  }
                }
              }
              else if ((advanced3D != null) && (lVar8 = Component.get_gameObject(advanced3D,0)) != null) {
                lVar8 = GameObject.AddComponent(lVar8,DAT_181d9de70);
                return lVar8;
              }
            }
          }
        }
    }

    // Token : 0x60003DE
    // RVA   : 0x15958D0   Offset: 0x15940D0   Length: 0xCE7
    public static UIPanel CreateUI(Transform trans, bool advanced3D, int layer)
    {
        var pStatics_ac58 = *(int64*)(DAT_181d8ac58 + 184);
        var pStatics_af58 = *(int64*)(DAT_181d8af58 + 184);
        bool cVar1;
        int iVar3;
        int iVar4;
        uint uVar5;
        uint uVar6;
        ulong uVar7;
        long lVar8;
        long lVar9;
        long lVar10;
        int iVar12;
        float fVar13;
        long[] local_98 = new long[2];
        ulong local_88;
        uint uStack_80;
        uint32 uStack_7c;
        int64 local_78;
        uint64 local_60;
        uint64 uStack_58;
        int64 local_50;
        local_60 = 0;
        uStack_58 = 0;
        local_50 = 0;
        cVar1 = Object.op_Inequality(trans,0,0);
        if (!cVar1) {
          lVar8 = 0;
        }
        else {
          if (trans == null) throw; // [null/range check failed]
          uVar7 = Component.get_gameObject(trans,0);
          lVar8 = NGUITools.FindInParents(uVar7,DAT_181d66b00);
        }
        iVar12 = 0;
        local_98[0] = lVar8;
        cVar1 = Object.op_Equality(lVar8,0,0);
        if (cVar1) {
          if (*pStatics_af58 == 0) throw; // [null/range check failed]
          if (0 < *(int *)(*pStatics_af58 + 24)) {
            if (*pStatics_af58 == 0) throw; // [null/range check failed]
            FUN_1817ff240(&local_88,*pStatics_af58,DAT_181d82bf8);
            local_60 = local_88;
            uStack_58 = CONCAT44(uStack_7c,uStack_80);
            local_50 = local_78;
            do {
              cVar1 = FUN_180d197a0(&local_60,DAT_181d6ce38);
              lVar10 = local_50;
              if (!cVar1) {
                ZhSegment.Initialize(&local_60,DAT_181d6cdb8);
                goto LAB_181595c5a;
              }
              if (local_50 == 0) {
                          // WARNING: Subroutine does not return
                FUN_1800d6620();
              }
              lVar9 = Component.get_gameObject(local_50,0);
              if (lVar9 == null) {
                          // WARNING: Subroutine does not return
                FUN_1800d6620();
              }
              iVar3 = GameObject.get_layer(lVar9,0);
            } while (iVar3 != layer);
            local_98[0] = lVar10;
            ZhSegment.Initialize(&local_60,DAT_181d6cdb8);
            lVar8 = lVar10;
          }
        }
        LAB_181595c5a:
        cVar1 = Object.op_Equality(lVar8,0,0);
        if (cVar1) {
          if (*pStatics_ac58 == 0) throw; // [null/range check failed]
          iVar3 = *(int *)(*pStatics_ac58 + 24);
          if (0 < iVar3) {
            do {
              if (((*pStatics_ac58 == 0) ||
                  (lVar10 = FUN_180002f80(*pStatics_ac58,iVar12,DAT_181d82978),
                  lVar10 == null)) || (lVar9 = Component.get_gameObject(lVar10,0)) == null)
              throw; // [null/range check failed]
              iVar4 = Object.get_hideFlags(lVar9,0);
              if ((iVar4 == 0) && (iVar4 = GameObject.get_layer(lVar9,0), iVar4 == layer)) {
                uVar7 = Component.get_transform(lVar10,0);
                if (trans != null) {
                  Transform.set_parent(trans,uVar7,0);
                  puVar11 = (uint64 *)Vector3.get_one(local_98,0);
                  local_88 = *puVar11;
                  uStack_80 = *(uint32 *)(puVar11 + 1);
                  Transform.set_localScale(trans,&local_88,0);
                  return lVar10;
                }
                throw; // [null/range check failed]
              }
              iVar12 = iVar12 + 1;
            } while (iVar12 < iVar3);
          }
        }
        cVar1 = Object.op_Inequality(lVar8,0,0);
        if (cVar1) {
          if (lVar8 == null) throw; // [null/range check failed]
          lVar10 = Component.GetComponentInChildren(lVar8,DAT_181d6ec40);
          cVar1 = Object.op_Inequality(lVar10,0,0);
          if (cVar1) {
            if ((lVar10 == null) || (lVar10 = Component.GetComponent(lVar10,DAT_181d6afc0)) == null)
            throw; // [null/range check failed]
            cVar1 = Camera.get_orthographic(lVar10,0);
            if (cVar1 == advanced3D) {
              trans = 0;
              lVar8 = 0;
            }
          }
        }
        cVar1 = Object.op_Equality(lVar8,0,0);
        if (cVar1) {
          lVar10 = new GameObject(0);
          cVar1 = Object.op_Inequality(0,0,0);
          if (lVar10 == null) throw; // [null/range check failed]
          if (cVar1) {
            GameObject.get_transform(lVar10,0);
            throw; // [null/range check failed]
          }
          lVar8 = GameObject.AddComponent(lVar10,DAT_181d9def8);
          if ((layer == -1) && (layer = LayerMask.NameToLayer("UI",0), layer == -1)) {
            layer = LayerMask.NameToLayer("2D UI",0);
          }
          GameObject.set_layer(lVar10,layer,0);
          if (!advanced3D) {
            Object.set_name(lVar10,"UI Root",0);
            if (lVar8 == null) throw; // [null/range check failed]
            uVar6 = 0;
          }
          else {
            Object.set_name(lVar10,"UI Root (3D)",0);
            if (lVar8 == null) throw; // [null/range check failed]
            uVar6 = 1;
          }
          *(uint32 *)(lVar8 + 24) = uVar6;
          UIRoot.UpdateScale(lVar8,1,0);
        }
        if (lVar8 == null) throw; // [null/range check failed]
        lVar10 = Component.GetComponentInChildren(lVar8,DAT_181d6edc0);
        cVar1 = Object.op_Equality(lVar10,0,0);
        if (cVar1) {
          lVar10 = NGUITools.FindActive(DAT_181d66300);
          fVar13 = -1.0;
          cVar1 = false;
          lVar9 = Component.get_gameObject(lVar8,0);
          if (lVar9 == null) throw; // [null/range check failed]
          bVar2 = GameObject.get_layer(lVar9,0);
          uVar5 = 0;
          if (lVar10 == null) throw; // [null/range check failed]
          for (; (int)uVar5 < (int)*(uint32 *)(lVar10 + 24); uVar5 = uVar5 + 1) {
            if (*(uint32 *)(lVar10 + 24) <= uVar5) {
              uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar7,0);
            }
            lVar9 = lVar10[uVar5];
            if (lVar9 == null) throw; // [null/range check failed]
            iVar12 = Camera.get_clearFlags(lVar9,0);
            if ((iVar12 == 2) || (iVar12 = Camera.get_clearFlags(lVar9,0), iVar12 == 1)) {
              cVar1 = true;
            }
            uVar7 = Camera.get_depth(lVar9,0);
            fVar13 = (float)Mathf.Max(fVar13,uVar7,0);
            Camera.get_cullingMask(lVar9,0);
            Camera.set_cullingMask(lVar9);
          }
          uVar7 = Component.get_gameObject(lVar8,0);
          lVar10 = NGUITools.AddChild(uVar7,0);
          if ((lVar10 == null) || (lVar9 = Component.get_gameObject(lVar10,0)) == null)
          throw; // [null/range check failed]
          GameObject.AddComponent(lVar9,DAT_181d9dbc8);
          Camera.set_clearFlags(lVar10,cVar1 + '\x02');
          puVar11 = (uint64 *)FUN_1810988d0(&local_88,0);
          local_88 = *puVar11;
          uStack_80 = *(uint32 *)(puVar11 + 1);
          uStack_7c = *(uint32 *)((int64)puVar11 + 12);
          Camera.set_backgroundColor(lVar10,&local_88);
          Camera.set_cullingMask(lVar10,1 << (bVar2 & 31));
          Camera.set_depth(lVar10,fVar13 + 1.0);
          if (!advanced3D) {
            Camera.set_orthographic(lVar10,1);
            Camera.set_orthographicSize(lVar10,0x3f800000,0);
            Camera.set_nearClipPlane(lVar10,0xc1200000,0);
            Camera.set_farClipPlane(lVar10,0x41200000,0);
          }
          else {
            Camera.set_nearClipPlane(lVar10,0x3dcccccd);
            Camera.set_farClipPlane(lVar10,0x40800000,0);
            lVar9 = Component.get_transform(lVar10,0);
            if (lVar9 == null) throw; // [null/range check failed]
            local_88 = 0;
            uStack_80 = 0xc42f0000;
            Transform.set_localPosition(lVar9,&local_88,0);
          }
          lVar9 = NGUITools.FindActive(DAT_181d66280);
          if ((lVar9 == null) || (*(int64 *)(lVar9 + 24) == 0)) {
            lVar10 = Component.get_gameObject(lVar10,0);
            if (lVar10 == null) throw; // [null/range check failed]
            GameObject.AddComponent(lVar10,DAT_181d9be90);
          }
          lVar8 = Component.get_gameObject(lVar8,0);
          if (lVar8 == null) throw; // [null/range check failed]
          lVar10 = GameObject.AddComponent(lVar8,DAT_181d9de70);
        }
        cVar1 = Object.op_Inequality(trans,0,0);
        if (!cVar1) {
          return lVar10;
        }
        if (trans != null) {
          while( true ) {
            uVar7 = FUN_180da0f00(trans,0);
            cVar1 = Object.op_Inequality(uVar7,0,0);
            if (!cVar1) break;
            if ((trans == null) || (trans = FUN_180da0f00(trans)) == null) throw; // [null/range check failed]
          }
          if (lVar10 != null) {
            lVar8 = Component.get_transform(lVar10,0);
            if (lVar8 != null) {
              cVar1 = Transform.IsChildOf(lVar8,trans,0);
              if (!cVar1) {
                uVar7 = Component.get_transform(lVar10,0);
                if (trans != null) {
                  Transform.set_parent(trans,uVar7,0);
                  puVar11 = (uint64 *)Vector3.get_one(local_98,0);
                  local_88 = *puVar11;
                  uStack_80 = *(uint32 *)(puVar11 + 1);
                  Transform.set_localScale(trans,&local_88,0);
                  puVar11 = (uint64 *)Vector3.get_zero(local_98,0);
                  local_88 = *puVar11;
                  uStack_80 = *(uint32 *)(puVar11 + 1);
                  Transform.set_localPosition(trans,&local_88,0);
                  uVar7 = UIRect.get_cachedTransform(lVar10,0);
                  lVar8 = UIRect.get_cachedGameObject(lVar10,0);
                  if (lVar8 != null) {
                    uVar6 = GameObject.get_layer(lVar8,0);
                    NGUITools.SetChildLayer(uVar7,uVar6,0);
                    return lVar10;
                  }
                }
              }
              else if ((trans != null) && (lVar8 = Component.get_gameObject(trans,0)) != null) {
                lVar8 = GameObject.AddComponent(lVar8,DAT_181d9de70);
                return lVar8;
              }
            }
          }
        }
    }

    // Token : 0x60003DF
    // RVA   : 0x159C500   Offset: 0x159AD00   Length: 0xCC
    public static void SetChildLayer(Transform t, int layer)
    {
        int iVar1;
        long lVar2;
        long lVar3;
        int iVar4;
        iVar4 = 0;
        if (t != null) {
          while( true ) {
            iVar1 = Transform.get_childCount(t,0);
            if (iVar1 <= iVar4) {
              return;
            }
            lVar2 = Transform.GetChild(t,iVar4,0);
            if (lVar2 == null) break;
            lVar3 = Component.get_gameObject(lVar2,0);
            if (lVar3 == null) break;
            GameObject.set_layer(lVar3,layer);
            NGUITools.SetChildLayer(lVar2);
            iVar4 = iVar4 + 1;
          }
        }
    }

    // Token : 0x60003E0
    // RVA   : 0xDC36E0   Offset: 0xDC1EE0   Length: 0x1CE
    public static T AddChild<T>(GameObject parent)
    {
        var pStatics = *(int64*)(DAT_181d66af0 + 184);
        long lVar1;
        bool cVar3;
        long lVar4;
        ulong uVar5;
        long local_res8;
        local_res8 = 0;
        lVar4 = NGUITools.AddChild(parent,param_2,0);
        uVar5 = **(uint64 **)(param_3 + 48);
        lVar1 = *(int64 *)(pStatics + 40);
        uVar5 = Type.GetTypeFromHandle(uVar5,0);
        if (lVar1 != null) {
          cVar3 = FUN_1808addd0(lVar1,uVar5,&local_res8,DAT_181d531d0);
          if ((!cVar3) || (local_res8 == 0)) {
            puVar2 = *(uint64 **)(*(int64 *)(param_3 + 48) + 8);
            local_res8 = (*(code *)*puVar2)(puVar2);
            uVar5 = **(uint64 **)(param_3 + 48);
            lVar1 = *(int64 *)(pStatics + 40);
            uVar5 = Type.GetTypeFromHandle(uVar5,0);
            if (lVar1 == null) throw; // [null/range check failed]
            FUN_1808aec90(lVar1,uVar5,local_res8,DAT_181d53250);
          }
          if (lVar4 != null) {
            Object.set_name(lVar4,local_res8,0);
            puVar2 = *(uint64 **)(*(int64 *)(param_3 + 48) + 16);
            (*(code *)*puVar2)(lVar4,puVar2);
            return;
          }
        }
    }

    // Token : 0x60003E1
    // RVA   : 0xDC3500   Offset: 0xDC1D00   Length: 0x1D5
    public static T AddChild<T>(GameObject parent, bool undo)
    {
        var pStatics = *(int64*)(DAT_181d66af0 + 184);
        long lVar1;
        bool cVar3;
        long lVar4;
        ulong uVar5;
        long local_res8;
        local_res8 = 0;
        lVar4 = NGUITools.AddChild(parent,undo,0);
        uVar5 = **(uint64 **)(param_3 + 48);
        lVar1 = *(int64 *)(pStatics + 40);
        uVar5 = Type.GetTypeFromHandle(uVar5,0);
        if (lVar1 != null) {
          cVar3 = FUN_1808addd0(lVar1,uVar5,&local_res8,DAT_181d531d0);
          if ((!cVar3) || (local_res8 == 0)) {
            puVar2 = *(uint64 **)(*(int64 *)(param_3 + 48) + 8);
            local_res8 = (*(code *)*puVar2)(puVar2);
            uVar5 = **(uint64 **)(param_3 + 48);
            lVar1 = *(int64 *)(pStatics + 40);
            uVar5 = Type.GetTypeFromHandle(uVar5,0);
            if (lVar1 == null) throw; // [null/range check failed]
            FUN_1808aec90(lVar1,uVar5,local_res8,DAT_181d53250);
          }
          if (lVar4 != null) {
            Object.set_name(lVar4,local_res8,0);
            puVar2 = *(uint64 **)(*(int64 *)(param_3 + 48) + 16);
            (*(code *)*puVar2)(lVar4,puVar2);
            return;
          }
        }
    }

    // Token : 0x60003E2
    // RVA   : 0xDC3960   Offset: 0xDC2160   Length: 0xDE
    public static T AddWidget<T>(GameObject go, int depth)
    {
        long lVar1;
        if (depth == 0x7fffffff) {
          depth = NGUITools.CalculateNextDepth(go,0);
        }
        lVar1 = (**(code **)**(uint64 **)(param_3 + 48))
                          (go,(uint64 *)**(uint64 **)(param_3 + 48));
        if (lVar1 != null) {
          UIWidget.set_width(lVar1,100);
          UIWidget.set_height(lVar1,100);
          UIWidget.set_depth(lVar1,depth,0);
          return lVar1;
        }
    }

    // Token : 0x60003E3
    // RVA   : 0x1592700   Offset: 0x1590F00   Length: 0x192
    public static UISprite AddSprite(GameObject go, INGUIAtlas atlas, string spriteName, int depth)
    {
        int64 *
        NGUITools.AddSprite(uint64 go,int64 *atlas,uint64 spriteName,uint32 depth)
        {
        char cVar1;
        uint64 *puVar2;
        int64 lVar3;
        int64 *plVar4;
        uint16 uVar5;
        uint64 uVar6;
        uVar6 = 0;
        if (atlas == (int64 *)0) {
          lVar3 = 0;
        }
        else {
          lVar3 = *atlas;
          uVar5 = 0;
          if (*(uint16 *)(lVar3 + 0x12a) != 0) {
            do {
              if (*(int64 *)(*(int64 *)(lVar3 + 176) + (uint64)uVar5 * 16) == DAT_181d55650) {
                puVar2 = (uint64 *)
                         ((int64)*(int *)(*(int64 *)(lVar3 + 176) + 8 + (uint64)uVar5 * 16) *
                          16 + 0x1d8 + lVar3);
                lVar3 = (*(code *)*puVar2)(atlas,spriteName,puVar2[1]);
                goto LAB_1815927f2;
              }
              uVar5 = uVar5 + 1;
            } while (uVar5 < *(uint16 *)(lVar3 + 0x12a));
          }
          puVar2 = (uint64 *)FUN_1800914f0(atlas,DAT_181d55650,10);
          lVar3 = (*(code *)*puVar2)(atlas,spriteName,puVar2[1]);
        }
        LAB_1815927f2:
        plVar4 = (int64 *)NGUITools.AddWidget(go,depth,DAT_181d66080);
        if (lVar3 != null) {
          cVar1 = UISpriteData.get_hasBorder(lVar3,0);
          if (cVar1) {
            uVar6 = 1;
          }
        }
        if (plVar4 != (int64 *)0) {
          (**(code **)(*plVar4 + 0x3b8))(plVar4,uVar6,*(uint64 *)(*plVar4 + 0x3c0));
          UISprite.set_atlas(plVar4,atlas,0);
          UISprite.set_spriteName(plVar4,spriteName,0);
          return plVar4;
        }
    }

    // Token : 0x60003E4
    // RVA   : 0x1597B20   Offset: 0x1596320   Length: 0xA5
    public static GameObject GetRoot(GameObject go)
    {
        long lVar1;
        bool cVar2;
        long lVar3;
        if (go != null) {
          lVar3 = GameObject.get_transform(go,0);
          do {
            lVar1 = lVar3;
            if (lVar1 == null) throw; // [null/range check failed]
            lVar3 = FUN_180da0f00(lVar1,0);
            cVar2 = Object.op_Equality(lVar3,0,0);
          } while (!cVar2);
          if (lVar1 != null) {
            Component.get_gameObject(lVar1,0);
            return;
          }
        }
    }

    // Token : 0x60003E5
    // RVA   : 0xDC4400   Offset: 0xDC2C00   Length: 0x8C
    public static T FindInParents<T>(GameObject go)
    {
        bool cVar1;
        ulong uVar2;
        cVar1 = Object.op_Equality(go,0,0);
        if (!cVar1) {
          if (go != null) {
                          // WARNING: Could not recover jumptable at 0x000180dc43e7. Too many branches
                          // WARNING: Treating indirect jump as call
            uVar2 = (**(code **)**(uint64 **)(param_2 + 48))
                              (go,(uint64 *)**(uint64 **)(param_2 + 48));
            return uVar2;
          }
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
        return 0;
    }

    // Token : 0x60003E6
    // RVA   : 0xDC4370   Offset: 0xDC2B70   Length: 0x8C
    public static T FindInParents<T>(Transform trans)
    {
        bool cVar1;
        ulong uVar2;
        cVar1 = Object.op_Equality(trans,0,0);
        if (!cVar1) {
          if (trans != null) {
                          // WARNING: Could not recover jumptable at 0x000180dc43e7. Too many branches
                          // WARNING: Treating indirect jump as call
            uVar2 = (**(code **)**(uint64 **)(param_2 + 48))
                              (trans,(uint64 *)**(uint64 **)(param_2 + 48));
            return uVar2;
          }
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
        return 0;
    }

    // Token : 0x60003E7
    // RVA   : 0x15968D0   Offset: 0x15950D0   Length: 0x1F3
    public static void Destroy(object obj)
    {
        long lVar1;
        bool cVar2;
        cVar2 = Object.op_Implicit(obj,0);
        if (cVar2) {
          if (obj != (int64 *)0) {
            lVar1 = *obj;
            if ((*(byte *)(DAT_181d88258 + 300) <= *(byte *)(lVar1 + 300)) &&
               (*(int64 *)
                 (*(int64 *)(lVar1 + 200) + -8 + (uint64)*(byte *)(DAT_181d88258 + 300) * 8) ==
                DAT_181d88258)) {
              plVar3 = (int64 *)Component.get_gameObject(obj,0);
              cVar2 = Application.get_isPlaying(0);
              if (!cVar2) {
        LAB_181596a0c:
                Object.DestroyImmediate(plVar3,0);
                return;
              }
              if (plVar3 == (int64 *)0) {
        LAB_181596abe:
                          // WARNING: Subroutine does not return
                FUN_1800d6620();
              }
              GameObject.SetActive(plVar3,0,0);
        LAB_1815969a3:
              Transform.set_parent(obj,0,0);
              Object.Destroy(plVar3,0);
              return;
            }
            plVar3 = (int64 *)0;
            if (lVar1 == DAT_181d4e110) {
              plVar3 = obj;
            }
            if (plVar3 != (int64 *)0) {
              obj = (int64 *)GameObject.get_transform(plVar3,0);
              cVar2 = Application.get_isPlaying(0);
              if (!cVar2) goto LAB_181596a0c;
              GameObject.SetActive(plVar3,0,0);
              if (obj == (int64 *)0) goto LAB_181596abe;
              goto LAB_1815969a3;
            }
          }
          cVar2 = Application.get_isPlaying(0);
          if (!cVar2) {
            Object.DestroyImmediate(obj,0);
            return;
          }
          Object.Destroy(obj,0);
        }
    }

    // Token : 0x60003E8
    // RVA   : 0x1596710   Offset: 0x1594F10   Length: 0xFF
    public static void DestroyChildren(Transform t)
    {
        ulong uVar1;
        bool cVar2;
        int iVar3;
        long lVar4;
        cVar2 = Application.get_isPlaying(0);
        if (t != null) {
          while( true ) {
            iVar3 = Transform.get_childCount(t,0);
            if (iVar3 == 0) {
              return;
            }
            lVar4 = Transform.GetChild(t,0,0);
            if (lVar4 == null) break;
            if (!cVar2) {
              uVar1 = Component.get_gameObject();
              Object.DestroyImmediate(uVar1);
            }
            else {
              Transform.set_parent(lVar4);
              uVar1 = Component.get_gameObject(lVar4);
              Object.Destroy(uVar1);
            }
          }
        }
    }

    // Token : 0x60003E9
    // RVA   : 0x1596810   Offset: 0x1595010   Length: 0xB8
    public static void DestroyImmediate(object obj)
    {
        bool cVar1;
        cVar1 = Object.op_Inequality(obj,0,0);
        if (cVar1) {
          cVar1 = FUN_180448d60(0);
          if (!cVar1) {
            Object.Destroy(obj,0);
            return;
          }
          Object.DestroyImmediate(obj,0);
          return;
        }
    }

    // Token : 0x60003EA
    // RVA   : 0x15930F0   Offset: 0x15918F0   Length: 0x122
    public static void Broadcast(string funcName)
    {
        int iVar1;
        long lVar2;
        ulong uVar3;
        long lVar4;
        uint uVar5;
        uVar3 = DAT_181d94f40;
        uVar3 = Type.GetTypeFromHandle(uVar3,0);
        uVar3 = Object.FindObjectsOfType(uVar3,0);
        lVar4 = il2cpp_internal(uVar3,DAT_181d7db00);
        uVar5 = 0;
        if (lVar4 != null) {
          iVar1 = *(int *)(lVar4 + 24);
          if (0 < iVar1) {
            do {
              if (*(uint32 *)(lVar4 + 24) <= uVar5) {
                uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar3,0);
              }
              lVar2 = lVar4[uVar5];
              if (lVar2 == null) throw; // [null/range check failed]
              GameObject.SendMessage(lVar2,funcName,param_2,1,0);
              uVar5 = uVar5 + 1;
            } while ((int)uVar5 < iVar1);
          }
          return;
        }
    }

    // Token : 0x60003EB
    // RVA   : 0x1593220   Offset: 0x1591A20   Length: 0x13C
    public static void Broadcast(string funcName, object param)
    {
        int iVar1;
        long lVar2;
        ulong uVar3;
        long lVar4;
        uint uVar5;
        uVar3 = DAT_181d94f40;
        uVar3 = Type.GetTypeFromHandle(uVar3,0);
        uVar3 = Object.FindObjectsOfType(uVar3,0);
        lVar4 = il2cpp_internal(uVar3,DAT_181d7db00);
        uVar5 = 0;
        if (lVar4 != null) {
          iVar1 = *(int *)(lVar4 + 24);
          if (0 < iVar1) {
            do {
              if (*(uint32 *)(lVar4 + 24) <= uVar5) {
                uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar3,0);
              }
              lVar2 = lVar4[uVar5];
              if (lVar2 == null) throw; // [null/range check failed]
              GameObject.SendMessage(lVar2,funcName,param,1,0);
              uVar5 = uVar5 + 1;
            } while ((int)uVar5 < iVar1);
          }
          return;
        }
    }

    // Token : 0x60003EC
    // RVA   : 0x1599390   Offset: 0x1597B90   Length: 0x23
    public static bool IsChild(Transform parent, Transform child)
    {
        if (child != null) {
          Transform.IsChildOf(child,parent,0);
          return;
        }
    }

    // Token : 0x60003ED
    // RVA   : 0x1591E50   Offset: 0x1590650   Length: 0xB5
    private static void Activate(Transform t)
    {
        ulong uVar1;
        bool cVar2;
        int iVar3;
        long lVar4;
        int iVar5;
        int iVar6;
        if (t != null) {
          lVar4 = Component.get_gameObject(t,0);
          if (lVar4 != null) {
            GameObject.SetActive(lVar4,1,0);
            if (param_2) {
              iVar6 = 0;
              iVar5 = 0;
              iVar3 = Transform.get_childCount(t,0);
              if (0 < iVar3) {
                do {
                  lVar4 = Transform.GetChild(t,iVar5,0);
                  if ((lVar4 == null) || (lVar4 = Component.get_gameObject(lVar4,0)) == null)
                  throw; // [null/range check failed]
                  cVar2 = GameObject.get_activeSelf(lVar4,0);
                  if (cVar2) {
                    return;
                  }
                  iVar5 = iVar5 + 1;
                } while (iVar5 < iVar3);
              }
              iVar3 = Transform.get_childCount(t,0);
              if (0 < iVar3) {
                do {
                  uVar1 = Transform.GetChild(t,iVar6,0);
                  NGUITools.Activate(uVar1,1);
                  iVar6 = iVar6 + 1;
                } while (iVar6 < iVar3);
              }
            }
            return;
          }
        }
    }

    // Token : 0x60003EE
    // RVA   : 0x1591F10   Offset: 0x1590710   Length: 0x14B
    private static void Activate(Transform t, bool compatibilityMode)
    {
        ulong uVar1;
        bool cVar2;
        int iVar3;
        long lVar4;
        int iVar5;
        int iVar6;
        if (t != null) {
          lVar4 = Component.get_gameObject(t,0);
          if (lVar4 != null) {
            GameObject.SetActive(lVar4,1,0);
            if (compatibilityMode) {
              iVar6 = 0;
              iVar5 = 0;
              iVar3 = Transform.get_childCount(t,0);
              if (0 < iVar3) {
                do {
                  lVar4 = Transform.GetChild(t,iVar5,0);
                  if ((lVar4 == null) || (lVar4 = Component.get_gameObject(lVar4,0)) == null)
                  throw; // [null/range check failed]
                  cVar2 = GameObject.get_activeSelf(lVar4,0);
                  if (cVar2) {
                    return;
                  }
                  iVar5 = iVar5 + 1;
                } while (iVar5 < iVar3);
              }
              iVar3 = Transform.get_childCount(t,0);
              if (0 < iVar3) {
                do {
                  uVar1 = Transform.GetChild(t,iVar6,0);
                  NGUITools.Activate(uVar1,1);
                  iVar6 = iVar6 + 1;
                } while (iVar6 < iVar3);
              }
            }
            return;
          }
        }
    }

    // Token : 0x60003EF
    // RVA   : 0x1596690   Offset: 0x1594E90   Length: 0x71
    private static void Deactivate(Transform t)
    {
        long lVar1;
        if (t != null) {
          lVar1 = Component.get_gameObject(t,0);
          if (lVar1 != null) {
            GameObject.SetActive(lVar1,0,0);
            return;
          }
        }
    }

    // Token : 0x60003F0
    // RVA   : 0x159C360   Offset: 0x159AB60   Length: 0x196
    public static void SetActive(GameObject go, bool state)
    {
        ulong uVar1;
        bool cVar2;
        long lVar3;
        cVar2 = Object.op_Implicit(go,0);
        if (!cVar2) {
          return;
        }
        if (go != null) {
          lVar3 = GameObject.get_transform(go,0);
          if (state) {
            NGUITools.Activate(lVar3,param_3,0);
            uVar1 = GameObject.get_transform(go,0);
            NGUITools.CallCreatePanel(uVar1,0);
            return;
          }
          if (lVar3 != null) {
            lVar3 = Component.get_gameObject(lVar3,0);
            if (lVar3 != null) {
              GameObject.SetActive(lVar3,0,0);
              return;
            }
          }
        }
    }

    // Token : 0x60003F1
    // RVA   : 0x159C1E0   Offset: 0x159A9E0   Length: 0x171
    public static void SetActive(GameObject go, bool state, bool compatibilityMode)
    {
        ulong uVar1;
        bool cVar2;
        long lVar3;
        cVar2 = Object.op_Implicit(go,0);
        if (!cVar2) {
          return;
        }
        if (go != null) {
          lVar3 = GameObject.get_transform(go,0);
          if (state) {
            NGUITools.Activate(lVar3,compatibilityMode,0);
            uVar1 = GameObject.get_transform(go,0);
            NGUITools.CallCreatePanel(uVar1,0);
            return;
          }
          if (lVar3 != null) {
            lVar3 = Component.get_gameObject(lVar3,0);
            if (lVar3 != null) {
              GameObject.SetActive(lVar3,0,0);
              return;
            }
          }
        }
    }

    // Token : 0x60003F2
    // RVA   : 0x15938F0   Offset: 0x15920F0   Length: 0x118
    private static void CallCreatePanel(Transform t)
    {
        long lVar1;
        ulong uVar2;
        bool cVar3;
        int iVar4;
        int iVar5;
        if (t == null) {
        LAB_181593a03:
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
        lVar1 = Component.GetComponent(t,DAT_181d6e7c0);
        cVar3 = Object.op_Inequality(lVar1,0,0);
        if (cVar3) {
          if (lVar1 == null) goto LAB_181593a03;
          UIWidget.CreatePanel(lVar1,0);
        }
        iVar5 = 0;
        iVar4 = Transform.get_childCount(t,0);
        if (0 < iVar4) {
          do {
            uVar2 = Transform.GetChild(t,iVar5,0);
            NGUITools.CallCreatePanel(uVar2,0);
            iVar5 = iVar5 + 1;
          } while (iVar5 < iVar4);
        }
    }

    // Token : 0x60003F3
    // RVA   : 0x159C090   Offset: 0x159A890   Length: 0x125
    public static void SetActiveChildren(GameObject go, bool state)
    {
        ulong uVar1;
        int iVar2;
        long lVar3;
        int iVar4;
        if (go != null) {
          lVar3 = GameObject.get_transform(go,0);
          iVar4 = 0;
          if (!state) {
            if (lVar3 != null) {
              iVar2 = Transform.get_childCount(lVar3,0);
              if (0 < iVar2) {
                do {
                  uVar1 = Transform.GetChild(lVar3,iVar4,0);
                  NGUITools.Deactivate(uVar1,0);
                  iVar4 = iVar4 + 1;
                } while (iVar4 < iVar2);
              }
              return;
            }
          }
          else if (lVar3 != null) {
            iVar2 = Transform.get_childCount(lVar3,0);
            if (iVar2 < 1) {
              return;
            }
            do {
              uVar1 = Transform.GetChild(lVar3,iVar4,0);
              NGUITools.Activate(uVar1,0);
              iVar4 = iVar4 + 1;
            } while (iVar4 < iVar2);
            return;
          }
        }
    }

    // Token : 0x60003F4
    // RVA   : 0x15992F0   Offset: 0x1597AF0   Length: 0x92
    public static bool IsActive(Behaviour mb)
    {
        bool cVar1;
        byte uVar2;
        long lVar3;
        cVar1 = Object.op_Inequality(mb,0,0);
        if (!cVar1) {
          return false;
        }
        if (mb != null) {
          cVar1 = Behaviour.get_enabled(mb,0);
          if (!cVar1) {
            return false;
          }
          lVar3 = Component.get_gameObject(mb,0);
          if (lVar3 != null) {
            uVar2 = GameObject.get_activeInHierarchy(lVar3,0);
            return uVar2;
          }
        }
    }

    // Token : 0x60003F5
    // RVA   : 0x15977C0   Offset: 0x1595FC0   Length: 0x8F
    public static bool GetActive(Behaviour mb)
    {
        bool cVar1;
        cVar1 = Object.op_Implicit(mb,0);
        if (!cVar1) {
          return;
        }
        if (mb != null) {
          GameObject.get_activeInHierarchy(mb,0);
          return;
        }
    }

    // Token : 0x60003F6
    // RVA   : 0x1597850   Offset: 0x1596050   Length: 0x70
    public static bool GetActive(GameObject go)
    {
        bool cVar1;
        cVar1 = Object.op_Implicit(go,0);
        if (!cVar1) {
          return;
        }
        if (go != null) {
          GameObject.get_activeInHierarchy(go,0);
          return;
        }
    }

    // Token : 0x60003F7
    // RVA   : 0x159C1C0   Offset: 0x159A9C0   Length: 0x1A
    public static void SetActiveSelf(GameObject go, bool state)
    {
        if (go != null) {
          GameObject.SetActive(go,state,0);
          return;
        }
    }

    // Token : 0x60003F8
    // RVA   : 0x159C5D0   Offset: 0x159ADD0   Length: 0xF1
    public static void SetLayer(GameObject go, int layer)
    {
        ulong uVar1;
        int iVar2;
        long lVar3;
        long lVar4;
        int iVar5;
        if (go != null) {
          GameObject.set_layer(go,layer,0);
          lVar3 = GameObject.get_transform(go,0);
          iVar5 = 0;
          if (lVar3 != null) {
            iVar2 = Transform.get_childCount(lVar3,0);
            if (0 < iVar2) {
              do {
                lVar4 = Transform.GetChild(lVar3,iVar5,0);
                if (lVar4 == null) throw; // [null/range check failed]
                uVar1 = Component.get_gameObject(lVar4,0);
                NGUITools.SetLayer(uVar1,layer);
                iVar5 = iVar5 + 1;
              } while (iVar5 < iVar2);
            }
            return;
          }
        }
    }

    // Token : 0x60003F9
    // RVA   : 0x159BE80   Offset: 0x159A680   Length: 0x7F
    public static Vector3 Round(Vector3 v)
    {
        uint uVar1;
        uint uVar2;
        uVar1 = FUN_18000d7c0(*(uint32 *)param_2);
        uVar2 = (uint32)((uint64)*param_2 >> 32);
        *param_2 = CONCAT44(uVar2,uVar1);
        uVar1 = FUN_18000d7c0(CONCAT44(uVar2,uVar2));
        *param_2 = CONCAT44(uVar1,(int)*param_2);
        uVar1 = FUN_18000d7c0(*(uint32 *)(param_2 + 1));
        *(uint32 *)(param_2 + 1) = uVar1;
        uVar1 = *(uint32 *)(param_2 + 1);
        *v = *param_2;
        *(uint32 *)(v + 1) = uVar1;
        return v;
    }

    // Token : 0x60003FA
    // RVA   : 0x159A7E0   Offset: 0x1598FE0   Length: 0x2DB
    public static void MakePixelPerfect(Transform t)
    {
        bool cVar1;
        int iVar2;
        ulong uVar4;
        int iVar7;
        uint uVar8;
        uint uVar9;
        ulong local_48;
        uint local_40;
        ulong local_38;
        uint local_30;
        if (t == null) {
        LAB_18159aab6:
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
        plVar3 = (int64 *)Component.GetComponent(t,DAT_181d6e7c0);
        cVar1 = Object.op_Inequality(plVar3,0,0);
        if (cVar1) {
          if (plVar3 == (int64 *)0) goto LAB_18159aab6;
          (**(code **)(*plVar3 + 0x348))(plVar3,*(uint64 *)(*plVar3 + 0x350));
        }
        uVar4 = Component.GetComponent(t,DAT_181d6ddc0);
        cVar1 = Object.op_Equality(uVar4,0,0);
        if (cVar1) {
          uVar4 = Component.GetComponent(t,DAT_181d6e4c0);
          cVar1 = Object.op_Equality(uVar4,0,0);
          if (cVar1) {
            puVar5 = (uint64 *)Transform.get_localPosition(&local_38,t,0);
            local_48 = *puVar5;
            local_40 = (uint32)puVar5[1];
            uVar8 = FUN_18000d7c0(local_48 & 0xffffffff);
            uVar9 = FUN_18000d7c0(local_48._4_4_);
            local_40 = FUN_18000d7c0(local_40);
            local_48 = CONCAT44(uVar9,uVar8);
            local_30 = local_40;
            Transform.set_localPosition(t,&local_48,0);
            puVar6 = (uint64 *)Transform.get_localScale(&local_38,t,0);
            local_48 = *puVar6;
            local_40 = *(uint32 *)(puVar6 + 1);
            uVar8 = FUN_18000d7c0(local_48);
            uVar9 = FUN_18000d7c0(local_48._4_4_);
            local_40 = FUN_18000d7c0(local_40);
            local_38 = CONCAT44(uVar9,uVar8);
            local_30 = local_40;
            Transform.set_localScale(t,&local_38,0);
          }
        }
        iVar7 = 0;
        iVar2 = Transform.get_childCount(t,0);
        if (0 < iVar2) {
          do {
            uVar4 = Transform.GetChild(t,iVar7,0);
            NGUITools.MakePixelPerfect(uVar4,0);
            iVar7 = iVar7 + 1;
          } while (iVar7 < iVar2);
        }
    }

    // Token : 0x60003FB
    // RVA   : 0x1596E90   Offset: 0x1595690   Length: 0x27C
    public static void FitOnScreen(Camera cam, Transform t, bool considerInactive, bool considerChildren)
    {
        void NGUITools.FitOnScreen
                     (int64 cam,int64 t,uint64 considerInactive,float *considerChildren,
                     uint64 *param_5,uint8 param_6)
        {
        uint64 uVar1;
        uint64 uVar2;
        char cVar3;
        int iVar4;
        uint64 *puVar5;
        int64 lVar6;
        uint32 uVar7;
        uint8 auVar8 [16];
        uint8 auVar9 [16];
        float fVar10;
        float fVar11;
        float fVar12;
        uint64 local_98;
        float local_90;
        uint8 local_88 [128];
        puVar5 = (uint64 *)
                 NGUIMath.CalculateRelativeWidgetBounds(local_88,t,considerInactive,param_6,1,0);
        uVar2 = puVar5[1];
        uVar1 = puVar5[2];
        *param_5 = *puVar5;
        param_5[1] = uVar2;
        param_5[2] = uVar1;
        puVar5 = (uint64 *)Bounds.get_min(&local_98,param_5,0);
        uVar1 = *puVar5;
        local_90 = *(float *)(puVar5 + 1);
        puVar5 = (uint64 *)Bounds.get_max(&local_98,param_5,0);
        uVar2 = *puVar5;
        local_90 = *(float *)(puVar5 + 1);
        puVar5 = (uint64 *)Bounds.get_size(&local_98,param_5,0);
        local_90 = *(float *)(puVar5 + 1);
        fVar12 = (float)*puVar5 + (float)uVar1;
        fVar11 = (float)((uint64)*puVar5 >> 32) - (float)((uint64)uVar2 >> 32);
        local_98 = uVar2;
        fVar10 = *considerChildren;
        cVar3 = Object.op_Inequality(cam,0,0);
        if (!cVar3) {
          iVar4 = Screen.get_width();
          if ((float)iVar4 < fVar12 + fVar10) {
            iVar4 = Screen.get_width(0);
            fVar10 = (float)iVar4 - fVar12;
            *considerChildren = fVar10;
          }
          local_98 = *(uint64 *)considerChildren;
          local_90 = considerChildren[2];
          if ((float)((uint64)local_98 >> 32) - fVar11 < 0.0) {
            considerChildren[1] = fVar11;
          }
          iVar4 = Screen.get_width(0);
          *considerChildren = fVar10 - (float)iVar4 * 0.5;
          iVar4 = Screen.get_height(0);
          considerChildren[1] = considerChildren[1] - (float)iVar4 * 0.5;
          if (t != null) {
        LAB_1815974e9:
            local_98 = *(uint64 *)considerChildren;
            local_90 = considerChildren[2];
            Transform.set_localPosition(t,&local_98,0);
            return;
          }
        }
        else {
          Screen.get_width(0);
          uVar7 = Mathf.Clamp01();
          fVar11 = (float)((uint64)*(uint64 *)considerChildren >> 32);
          *(uint64 *)considerChildren = CONCAT44(fVar11,uVar7);
          local_90 = considerChildren[2];
          iVar4 = Screen.get_height(0);
          local_98 = CONCAT44(fVar11,uVar7);
          auVar8._4_4_ = fVar11;
          auVar8._0_4_ = fVar11;
          auVar8._8_4_ = fVar11;
          auVar8._12_4_ = fVar11;
          auVar9._4_12_ = auVar8._4_12_;
          auVar9._0_4_ = fVar11 / (float)iVar4;
          fVar11 = (float)Mathf.Clamp01(auVar9._0_8_,0);
          considerChildren[1] = fVar11;
          if (((cam != null) && (Camera.get_orthographicSize(cam,0), t != null)) &&
             (lVar6 = FUN_180da0f00(t,0)) != null) {
            puVar5 = (uint64 *)Transform.get_lossyScale(&local_98,lVar6,0);
            uVar1 = *puVar5;
            local_90 = *(float *)(puVar5 + 1);
            Screen.get_height(0);
            local_98 = uVar1;
            Screen.get_width(0);
            Screen.get_height(0);
            uVar7 = Mathf.Min();
            local_98 = CONCAT44((int)((uint64)*(uint64 *)considerChildren >> 32),uVar7);
            *(uint64 *)considerChildren = local_98;
            local_90 = considerChildren[2];
            fVar11 = (float)Mathf.Max();
            considerChildren[1] = fVar11;
            local_98 = *(uint64 *)considerChildren;
            local_90 = considerChildren[2];
            puVar5 = (uint64 *)Camera.ViewportToWorldPoint(local_88,cam,&local_98,0);
            local_98 = *puVar5;
            local_90 = *(float *)(puVar5 + 1);
            Transform.set_position(t,&local_98,0);
            puVar5 = (uint64 *)Transform.get_localPosition(local_88,t,0);
            fVar11 = *(float *)(puVar5 + 1);
            *(uint64 *)considerChildren = *puVar5;
            considerChildren[2] = fVar11;
            uVar7 = FUN_18000d7c0();
            local_98 = CONCAT44((int)((uint64)*(uint64 *)considerChildren >> 32),uVar7);
            *(uint64 *)considerChildren = local_98;
            local_90 = considerChildren[2];
            fVar11 = (float)FUN_18000d7c0();
            considerChildren[1] = fVar11;
            goto LAB_1815974e9;
          }
        }
    }

    // Token : 0x60003FC
    // RVA   : 0x1597550   Offset: 0x1595D50   Length: 0xEF
    public static void FitOnScreen(Camera cam, Transform transform, Vector3 pos)
    {
        void NGUITools.FitOnScreen
                     (int64 cam,int64 transform,uint64 pos,float *param_4,
                     uint64 *param_5,uint8 param_6)
        {
        uint64 uVar1;
        uint64 uVar2;
        char cVar3;
        int iVar4;
        uint64 *puVar5;
        int64 lVar6;
        uint32 uVar7;
        uint8 auVar8 [16];
        uint8 auVar9 [16];
        float fVar10;
        float fVar11;
        float fVar12;
        uint64 local_98;
        float local_90;
        uint8 local_88 [128];
        puVar5 = (uint64 *)
                 NGUIMath.CalculateRelativeWidgetBounds(local_88,transform,pos,param_6,1,0);
        uVar2 = puVar5[1];
        uVar1 = puVar5[2];
        *param_5 = *puVar5;
        param_5[1] = uVar2;
        param_5[2] = uVar1;
        puVar5 = (uint64 *)Bounds.get_min(&local_98,param_5,0);
        uVar1 = *puVar5;
        local_90 = *(float *)(puVar5 + 1);
        puVar5 = (uint64 *)Bounds.get_max(&local_98,param_5,0);
        uVar2 = *puVar5;
        local_90 = *(float *)(puVar5 + 1);
        puVar5 = (uint64 *)Bounds.get_size(&local_98,param_5,0);
        local_90 = *(float *)(puVar5 + 1);
        fVar12 = (float)*puVar5 + (float)uVar1;
        fVar11 = (float)((uint64)*puVar5 >> 32) - (float)((uint64)uVar2 >> 32);
        local_98 = uVar2;
        fVar10 = *param_4;
        cVar3 = Object.op_Inequality(cam,0,0);
        if (!cVar3) {
          iVar4 = Screen.get_width();
          if ((float)iVar4 < fVar12 + fVar10) {
            iVar4 = Screen.get_width(0);
            fVar10 = (float)iVar4 - fVar12;
            *param_4 = fVar10;
          }
          local_98 = *(uint64 *)param_4;
          local_90 = param_4[2];
          if ((float)((uint64)local_98 >> 32) - fVar11 < 0.0) {
            param_4[1] = fVar11;
          }
          iVar4 = Screen.get_width(0);
          *param_4 = fVar10 - (float)iVar4 * 0.5;
          iVar4 = Screen.get_height(0);
          param_4[1] = param_4[1] - (float)iVar4 * 0.5;
          if (transform != null) {
        LAB_1815974e9:
            local_98 = *(uint64 *)param_4;
            local_90 = param_4[2];
            Transform.set_localPosition(transform,&local_98,0);
            return;
          }
        }
        else {
          Screen.get_width(0);
          uVar7 = Mathf.Clamp01();
          fVar11 = (float)((uint64)*(uint64 *)param_4 >> 32);
          *(uint64 *)param_4 = CONCAT44(fVar11,uVar7);
          local_90 = param_4[2];
          iVar4 = Screen.get_height(0);
          local_98 = CONCAT44(fVar11,uVar7);
          auVar8._4_4_ = fVar11;
          auVar8._0_4_ = fVar11;
          auVar8._8_4_ = fVar11;
          auVar8._12_4_ = fVar11;
          auVar9._4_12_ = auVar8._4_12_;
          auVar9._0_4_ = fVar11 / (float)iVar4;
          fVar11 = (float)Mathf.Clamp01(auVar9._0_8_,0);
          param_4[1] = fVar11;
          if (((cam != null) && (Camera.get_orthographicSize(cam,0), transform != null)) &&
             (lVar6 = FUN_180da0f00(transform,0)) != null) {
            puVar5 = (uint64 *)Transform.get_lossyScale(&local_98,lVar6,0);
            uVar1 = *puVar5;
            local_90 = *(float *)(puVar5 + 1);
            Screen.get_height(0);
            local_98 = uVar1;
            Screen.get_width(0);
            Screen.get_height(0);
            uVar7 = Mathf.Min();
            local_98 = CONCAT44((int)((uint64)*(uint64 *)param_4 >> 32),uVar7);
            *(uint64 *)param_4 = local_98;
            local_90 = param_4[2];
            fVar11 = (float)Mathf.Max();
            param_4[1] = fVar11;
            local_98 = *(uint64 *)param_4;
            local_90 = param_4[2];
            puVar5 = (uint64 *)Camera.ViewportToWorldPoint(local_88,cam,&local_98,0);
            local_98 = *puVar5;
            local_90 = *(float *)(puVar5 + 1);
            Transform.set_position(transform,&local_98,0);
            puVar5 = (uint64 *)Transform.get_localPosition(local_88,transform,0);
            fVar11 = *(float *)(puVar5 + 1);
            *(uint64 *)param_4 = *puVar5;
            param_4[2] = fVar11;
            uVar7 = FUN_18000d7c0();
            local_98 = CONCAT44((int)((uint64)*(uint64 *)param_4 >> 32),uVar7);
            *(uint64 *)param_4 = local_98;
            local_90 = param_4[2];
            fVar11 = (float)FUN_18000d7c0();
            param_4[1] = fVar11;
            goto LAB_1815974e9;
          }
        }
    }

    // Token : 0x60003FD
    // RVA   : 0x1596DC0   Offset: 0x15955C0   Length: 0xC1
    public static void FitOnScreen(Camera cam, Transform transform, Transform content, Vector3 pos, bool considerInactive)
    {
        void NGUITools.FitOnScreen
                     (int64 cam,int64 transform,uint64 content,float *pos,
                     uint64 *considerInactive,uint8 param_6)
        {
        uint64 uVar1;
        uint64 uVar2;
        char cVar3;
        int iVar4;
        uint64 *puVar5;
        int64 lVar6;
        uint32 uVar7;
        uint8 auVar8 [16];
        uint8 auVar9 [16];
        float fVar10;
        float fVar11;
        float fVar12;
        uint64 local_98;
        float local_90;
        uint8 local_88 [128];
        puVar5 = (uint64 *)
                 NGUIMath.CalculateRelativeWidgetBounds(local_88,transform,content,param_6,1,0);
        uVar2 = puVar5[1];
        uVar1 = puVar5[2];
        *considerInactive = *puVar5;
        considerInactive[1] = uVar2;
        considerInactive[2] = uVar1;
        puVar5 = (uint64 *)Bounds.get_min(&local_98,considerInactive,0);
        uVar1 = *puVar5;
        local_90 = *(float *)(puVar5 + 1);
        puVar5 = (uint64 *)Bounds.get_max(&local_98,considerInactive,0);
        uVar2 = *puVar5;
        local_90 = *(float *)(puVar5 + 1);
        puVar5 = (uint64 *)Bounds.get_size(&local_98,considerInactive,0);
        local_90 = *(float *)(puVar5 + 1);
        fVar12 = (float)*puVar5 + (float)uVar1;
        fVar11 = (float)((uint64)*puVar5 >> 32) - (float)((uint64)uVar2 >> 32);
        local_98 = uVar2;
        fVar10 = *pos;
        cVar3 = Object.op_Inequality(cam,0,0);
        if (!cVar3) {
          iVar4 = Screen.get_width();
          if ((float)iVar4 < fVar12 + fVar10) {
            iVar4 = Screen.get_width(0);
            fVar10 = (float)iVar4 - fVar12;
            *pos = fVar10;
          }
          local_98 = *(uint64 *)pos;
          local_90 = pos[2];
          if ((float)((uint64)local_98 >> 32) - fVar11 < 0.0) {
            pos[1] = fVar11;
          }
          iVar4 = Screen.get_width(0);
          *pos = fVar10 - (float)iVar4 * 0.5;
          iVar4 = Screen.get_height(0);
          pos[1] = pos[1] - (float)iVar4 * 0.5;
          if (transform != null) {
        LAB_1815974e9:
            local_98 = *(uint64 *)pos;
            local_90 = pos[2];
            Transform.set_localPosition(transform,&local_98,0);
            return;
          }
        }
        else {
          Screen.get_width(0);
          uVar7 = Mathf.Clamp01();
          fVar11 = (float)((uint64)*(uint64 *)pos >> 32);
          *(uint64 *)pos = CONCAT44(fVar11,uVar7);
          local_90 = pos[2];
          iVar4 = Screen.get_height(0);
          local_98 = CONCAT44(fVar11,uVar7);
          auVar8._4_4_ = fVar11;
          auVar8._0_4_ = fVar11;
          auVar8._8_4_ = fVar11;
          auVar8._12_4_ = fVar11;
          auVar9._4_12_ = auVar8._4_12_;
          auVar9._0_4_ = fVar11 / (float)iVar4;
          fVar11 = (float)Mathf.Clamp01(auVar9._0_8_,0);
          pos[1] = fVar11;
          if (((cam != null) && (Camera.get_orthographicSize(cam,0), transform != null)) &&
             (lVar6 = FUN_180da0f00(transform,0)) != null) {
            puVar5 = (uint64 *)Transform.get_lossyScale(&local_98,lVar6,0);
            uVar1 = *puVar5;
            local_90 = *(float *)(puVar5 + 1);
            Screen.get_height(0);
            local_98 = uVar1;
            Screen.get_width(0);
            Screen.get_height(0);
            uVar7 = Mathf.Min();
            local_98 = CONCAT44((int)((uint64)*(uint64 *)pos >> 32),uVar7);
            *(uint64 *)pos = local_98;
            local_90 = pos[2];
            fVar11 = (float)Mathf.Max();
            pos[1] = fVar11;
            local_98 = *(uint64 *)pos;
            local_90 = pos[2];
            puVar5 = (uint64 *)Camera.ViewportToWorldPoint(local_88,cam,&local_98,0);
            local_98 = *puVar5;
            local_90 = *(float *)(puVar5 + 1);
            Transform.set_position(transform,&local_98,0);
            puVar5 = (uint64 *)Transform.get_localPosition(local_88,transform,0);
            fVar11 = *(float *)(puVar5 + 1);
            *(uint64 *)pos = *puVar5;
            pos[2] = fVar11;
            uVar7 = FUN_18000d7c0();
            local_98 = CONCAT44((int)((uint64)*(uint64 *)pos >> 32),uVar7);
            *(uint64 *)pos = local_98;
            local_90 = pos[2];
            fVar11 = (float)FUN_18000d7c0();
            pos[1] = fVar11;
            goto LAB_1815974e9;
          }
        }
    }

    // Token : 0x60003FE
    // RVA   : 0x1597110   Offset: 0x1595910   Length: 0x435
    public static void FitOnScreen(Camera cam, Transform transform, Transform content, Vector3 pos, ref Bounds bounds, bool considerInactive)
    {
        void NGUITools.FitOnScreen
                     (int64 cam,int64 transform,uint64 content,float *pos,
                     uint64 *bounds,uint8 considerInactive)
        {
        uint64 uVar1;
        uint64 uVar2;
        char cVar3;
        int iVar4;
        uint64 *puVar5;
        int64 lVar6;
        uint32 uVar7;
        uint8 auVar8 [16];
        uint8 auVar9 [16];
        float fVar10;
        float fVar11;
        float fVar12;
        uint64 local_98;
        float local_90;
        uint8 local_88 [128];
        puVar5 = (uint64 *)
                 NGUIMath.CalculateRelativeWidgetBounds(local_88,transform,content,considerInactive,1,0);
        uVar2 = puVar5[1];
        uVar1 = puVar5[2];
        *bounds = *puVar5;
        bounds[1] = uVar2;
        bounds[2] = uVar1;
        puVar5 = (uint64 *)Bounds.get_min(&local_98,bounds,0);
        uVar1 = *puVar5;
        local_90 = *(float *)(puVar5 + 1);
        puVar5 = (uint64 *)Bounds.get_max(&local_98,bounds,0);
        uVar2 = *puVar5;
        local_90 = *(float *)(puVar5 + 1);
        puVar5 = (uint64 *)Bounds.get_size(&local_98,bounds,0);
        local_90 = *(float *)(puVar5 + 1);
        fVar12 = (float)*puVar5 + (float)uVar1;
        fVar11 = (float)((uint64)*puVar5 >> 32) - (float)((uint64)uVar2 >> 32);
        local_98 = uVar2;
        fVar10 = *pos;
        cVar3 = Object.op_Inequality(cam,0,0);
        if (!cVar3) {
          iVar4 = Screen.get_width();
          if ((float)iVar4 < fVar12 + fVar10) {
            iVar4 = Screen.get_width(0);
            fVar10 = (float)iVar4 - fVar12;
            *pos = fVar10;
          }
          local_98 = *(uint64 *)pos;
          local_90 = pos[2];
          if ((float)((uint64)local_98 >> 32) - fVar11 < 0.0) {
            pos[1] = fVar11;
          }
          iVar4 = Screen.get_width(0);
          *pos = fVar10 - (float)iVar4 * 0.5;
          iVar4 = Screen.get_height(0);
          pos[1] = pos[1] - (float)iVar4 * 0.5;
          if (transform != null) {
        LAB_1815974e9:
            local_98 = *(uint64 *)pos;
            local_90 = pos[2];
            Transform.set_localPosition(transform,&local_98,0);
            return;
          }
        }
        else {
          Screen.get_width(0);
          uVar7 = Mathf.Clamp01();
          fVar11 = (float)((uint64)*(uint64 *)pos >> 32);
          *(uint64 *)pos = CONCAT44(fVar11,uVar7);
          local_90 = pos[2];
          iVar4 = Screen.get_height(0);
          local_98 = CONCAT44(fVar11,uVar7);
          auVar8._4_4_ = fVar11;
          auVar8._0_4_ = fVar11;
          auVar8._8_4_ = fVar11;
          auVar8._12_4_ = fVar11;
          auVar9._4_12_ = auVar8._4_12_;
          auVar9._0_4_ = fVar11 / (float)iVar4;
          fVar11 = (float)Mathf.Clamp01(auVar9._0_8_,0);
          pos[1] = fVar11;
          if (((cam != null) && (Camera.get_orthographicSize(cam,0), transform != null)) &&
             (lVar6 = FUN_180da0f00(transform,0)) != null) {
            puVar5 = (uint64 *)Transform.get_lossyScale(&local_98,lVar6,0);
            uVar1 = *puVar5;
            local_90 = *(float *)(puVar5 + 1);
            Screen.get_height(0);
            local_98 = uVar1;
            Screen.get_width(0);
            Screen.get_height(0);
            uVar7 = Mathf.Min();
            local_98 = CONCAT44((int)((uint64)*(uint64 *)pos >> 32),uVar7);
            *(uint64 *)pos = local_98;
            local_90 = pos[2];
            fVar11 = (float)Mathf.Max();
            pos[1] = fVar11;
            local_98 = *(uint64 *)pos;
            local_90 = pos[2];
            puVar5 = (uint64 *)Camera.ViewportToWorldPoint(local_88,cam,&local_98,0);
            local_98 = *puVar5;
            local_90 = *(float *)(puVar5 + 1);
            Transform.set_position(transform,&local_98,0);
            puVar5 = (uint64 *)Transform.get_localPosition(local_88,transform,0);
            fVar11 = *(float *)(puVar5 + 1);
            *(uint64 *)pos = *puVar5;
            pos[2] = fVar11;
            uVar7 = FUN_18000d7c0();
            local_98 = CONCAT44((int)((uint64)*(uint64 *)pos >> 32),uVar7);
            *(uint64 *)pos = local_98;
            local_90 = pos[2];
            fVar11 = (float)FUN_18000d7c0();
            pos[1] = fVar11;
            goto LAB_1815974e9;
          }
        }
    }

    // Token : 0x60003FF
    // RVA   : 0x159BF00   Offset: 0x159A700   Length: 0x187
    public static bool Save(string fileName, byte[] bytes)
    {
        bool cVar1;
        int iVar2;
        ulong uVar3;
        iVar2 = Application.get_platform(0);
        if (iVar2 == 17) {
          return false;
        }
        uVar3 = Application.get_persistentDataPath(0);
        uVar3 = String.Concat(uVar3,"/",fileName,0);
        if (bytes == null) {
          cVar1 = File.Exists(uVar3,0);
          if (cVar1) {
            File.Delete(uVar3,0);
          }
          return true;
        }
        plVar4 = (int64 *)File.Create(uVar3,0);
        if (plVar4 != (int64 *)0) {
          (**(code **)(*plVar4 + 0x2f8))
                    (plVar4,bytes,0,*(uint32 *)(bytes + 24),*(uint64 *)(*plVar4 + 0x300));
          (**(code **)(*plVar4 + 0x238))(plVar4,*(uint64 *)(*plVar4 + 0x240));
          return true;
        }
    }

    // Token : 0x6000400
    // RVA   : 0x159A740   Offset: 0x1598F40   Length: 0x9F
    public static byte[] Load(string fileName)
    {
        bool cVar1;
        int iVar2;
        ulong uVar3;
        iVar2 = Application.get_platform(0);
        if (iVar2 != 17) {
          uVar3 = Application.get_persistentDataPath(0);
          uVar3 = String.Concat(uVar3,"/",fileName,0);
          cVar1 = File.Exists(uVar3,0);
          if (cVar1) {
            uVar3 = File.ReadAllBytes(uVar3,0);
            return uVar3;
          }
        }
        return 0;
    }

    // Token : 0x6000401
    // RVA   : 0x1592FC0   Offset: 0x15917C0   Length: 0x62
    public static Color ApplyPMA(Color c)
    {
        float fVar1;
        float fVar2;
        ulong uVar3;
        if (param_2[3] != 1.0) {
          fVar1 = param_2[2];
          fVar2 = param_2[3];
          *param_2 = param_2[3] * *param_2;
          param_2[1] = fVar2 * param_2[1];
          param_2[2] = fVar1;
          param_2[3] = fVar2;
          param_2[2] = fVar2 * fVar1;
        }
        uVar3 = *(uint64 *)(param_2 + 2);
        *c = *(uint64 *)param_2;
        c[1] = uVar3;
        return c;
    }

    // Token : 0x6000402
    // RVA   : 0x159AAC0   Offset: 0x15992C0   Length: 0xA1
    public static void MarkParentAsChanged(GameObject go)
    {
        int iVar1;
        long lVar3;
        ulong uVar4;
        uint uVar5;
        if (go != null) {
          lVar3 = FUN_180956bf0(go,DAT_181da3130);
          uVar5 = 0;
          if (lVar3 != null) {
            iVar1 = *(int *)(lVar3 + 24);
            if (0 < iVar1) {
              do {
                if (*(uint32 *)(lVar3 + 24) <= uVar5) {
                  uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1800d65f0(uVar4,0);
                }
                plVar2 = lVar3[uVar5];
                if (plVar2 == (int64 *)0) throw; // [null/range check failed]
                (**(code **)(*plVar2 + 0x278))();
                uVar5 = uVar5 + 1;
              } while ((int)uVar5 < iVar1);
            }
            return;
          }
        }
    }

    // Token : 0x6000403
    // RVA   : 0x159E160   Offset: 0x159C960   Length: 0x5E
    public static string get_clipboard()
    {
        long lVar1;
        lVar1 = new TextEditor(0);
        if (lVar1 != null) {
          TextEditor.Paste(lVar1,0);
          TextEditor.get_text(lVar1,0);
          return;
        }
    }

    // Token : 0x6000404
    // RVA   : 0x159E320   Offset: 0x159CB20   Length: 0x78
    public static void set_clipboard(string value)
    {
        long lVar1;
        lVar1 = new TextEditor(0);
        if (lVar1 != null) {
          TextEditor.set_text(lVar1,value,0);
          TextEditor.OnFocus(lVar1,0);
          TextEditor.Copy(lVar1,0);
          return;
        }
    }

    // Token : 0x6000405
    // RVA   : 0x1596AD0   Offset: 0x15952D0   Length: 0x6D
    public static string EncodeColor(Color c)
    {
        int iVar1;
        uint local_18;
        uint uStack_14;
        uint uStack_10;
        uint32 uStack_c;
        local_18 = *c;
        uStack_14 = c[1];
        uStack_10 = c[2];
        uStack_c = c[3];
        iVar1 = NGUIMath.ColorToInt(&local_18,0);
        NGUIMath.DecimalToHex24(iVar1 >> 8 & 0xffffff,0);
    }

    // Token : 0x6000406
    // RVA   : 0x159B050   Offset: 0x1599850   Length: 0x7E
    public static Color ParseColor(string text, int offset)
    {
        ulong uVar1;
        byte[] local_18 = new byte[16];
        puVar2 = (uint64 *)NGUIText.ParseColor24(local_18,offset,param_3,0);
        uVar1 = puVar2[1];
        *text = *puVar2;
        text[1] = uVar1;
        return text;
    }

    // Token : 0x6000407
    // RVA   : 0x159C6D0   Offset: 0x159AED0   Length: 0x19E
    public static string StripSymbols(string text)
    {
        bool cVar1;
        int iVar3;
        int iVar4;
        byte[] local_res8 = new byte[8];
        byte[] local_res18 = new byte[8];
        byte[] local_res20 = new byte[8];
        byte local_28;
        byte[] local_27 = new byte[3];
        int[] local_24 = new int[3];
        if (text != null) {
          iVar4 = *(int *)(text + 16);
          iVar3 = 0;
          if (0 < iVar4) {
            do {
              sVar2 = String.get_Chars(text,iVar3,0);
              if (sVar2 == 91) {
                local_24[1] = 0;
                local_27[0] = 0;
                local_28 = 0;
                local_res20[0] = 0;
                local_res18[0] = 0;
                local_res8[0] = 0;
                local_24[0] = iVar3;
                cVar1 = NGUIText.ParseSymbol
                                  (text,local_24,0,0,local_24 + 1,local_27,&local_28,local_res20,
                                   local_res18,local_res8,0);
                if (!(!cVar1))
                {
                  text = String.Remove(text,iVar3);
                  if (text == null) {
                  // WARNING: Subroutine does not return
                  FUN_1800d6620();
                  }
                  iVar4 = *(int *)(text + 16);
                  }
                  else {
                }
                iVar3 = iVar3 + 1;
              }
            } while (iVar3 < iVar4);
          }
        }
        return text;
    }

    // Token : 0x6000408
    // RVA   : 0xDC38B0   Offset: 0xDC20B0   Length: 0xA4
    public static T AddMissingComponent<T>(GameObject go)
    {
        bool cVar2;
        ulong uVar3;
        if (go != null) {
          uVar3 = (**(code **)**(uint64 **)(param_2 + 48))
                            (go,(uint64 *)**(uint64 **)(param_2 + 48));
          cVar2 = Object.op_Equality(uVar3,0,0);
          if (cVar2) {
            puVar1 = *(uint64 **)(*(int64 *)(param_2 + 48) + 16);
            uVar3 = (*(code *)*puVar1)(go,puVar1);
          }
          return uVar3;
        }
    }

    // Token : 0x6000409
    // RVA   : 0x1597BD0   Offset: 0x15963D0   Length: 0x9D
    public static Vector3[] GetSides(Camera cam)
    {
        var pStatics = *(int64*)(DAT_181d66af0 + 184);
        ulong uVar1;
        ulong uVar2;
        bool cVar3;
        int iVar4;
        long lVar6;
        ulong uVar7;
        long lVar8;
        ulong uVar9;
        uint uVar10;
        float fVar11;
        float fVar12;
        float fVar13;
        float fVar14;
        float fVar15;
        float local_f8;
        float fStack_f4;
        ulong local_e8;
        float local_e0;
        ulong local_d8;
        float local_d0;
        ulong local_c8;
        ulong uStack_c0;
        byte[] local_b8 = new byte[16];
        ulong local_a8;
        ulong uStack_a0;
        local_a8 = 0;
        uStack_a0 = 0;
        if (cam != null) {
          cVar3 = Camera.get_orthographic(cam,0);
          if (!cVar3) {
            local_e8 = 0x3f00000000000000;
            lVar6 = *(int64 *)(pStatics + 48);
            local_e0 = param_2;
            puVar5 = (uint64 *)Camera.ViewportToWorldPoint(&local_c8,cam,&local_e8,0);
            if (lVar6 != null) {
              if (*(int *)(lVar6 + 24) == 0) {
                uVar9 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar9,0);
              }
              *(uint64 *)(lVar6 + 32) = *puVar5;
              *(uint32 *)(lVar6 + 40) = *(uint32 *)(puVar5 + 1);
              local_e8 = 0x3f8000003f000000;
              lVar6 = *(int64 *)(pStatics + 48);
              local_e0 = param_2;
              puVar5 = (uint64 *)Camera.ViewportToWorldPoint(&local_c8,cam,&local_e8,0);
              if (lVar6 != null) {
                if (*(uint32 *)(lVar6 + 24) < 2) {
                  uVar9 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1800d65f0(uVar9,0);
                }
                *(uint64 *)(lVar6 + 44) = *puVar5;
                *(uint32 *)(lVar6 + 52) = *(uint32 *)(puVar5 + 1);
                local_e8 = 0x3f0000003f800000;
                lVar6 = *(int64 *)(pStatics + 48);
                local_e0 = param_2;
                puVar5 = (uint64 *)Camera.ViewportToWorldPoint(&local_c8,cam,&local_e8,0);
                if (lVar6 != null) {
                  if (*(uint32 *)(lVar6 + 24) < 3) {
                    uVar9 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                    FUN_1800d65f0(uVar9,0);
                  }
                  *(uint64 *)(lVar6 + 56) = *puVar5;
                  *(uint32 *)(lVar6 + 64) = *(uint32 *)(puVar5 + 1);
                  local_e8 = 0x3f000000;
                  lVar6 = *(int64 *)(pStatics + 48);
                  local_e0 = param_2;
                  puVar5 = (uint64 *)Camera.ViewportToWorldPoint(&local_c8,cam,&local_e8,0);
                  if (lVar6 != null) {
                    if (*(uint32 *)(lVar6 + 24) < 4) {
                      uVar9 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                      FUN_1800d65f0(uVar9,0);
                    }
                    *(uint64 *)(lVar6 + 68) = *puVar5;
                    *(uint32 *)(lVar6 + 76) = *(uint32 *)(puVar5 + 1);
        LAB_181598450:
                    cVar3 = Object.op_Inequality(param_3,0,0);
                    if (cVar3) {
                      uVar10 = 0;
                      do {
                        lVar6 = *(int64 *)(pStatics + 48);
                        if (lVar6 == null) throw; // [null/range check failed]
                        lVar8 = (int64)(int)uVar10;
                        if (*(uint32 *)(lVar6 + 24) <= uVar10) {
                          uVar9 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                          FUN_1800d65f0(uVar9,0);
                        }
                        if (param_3 == 0) throw; // [null/range check failed]
                        local_d8 = *(uint64 *)(lVar6 + 32 + lVar8 * 12);
                        local_d0 = *(float *)(lVar6 + 40 + lVar8 * 12);
                        puVar5 = (uint64 *)
                                 Transform.InverseTransformPoint(local_b8,param_3,&local_d8,0);
                        if (*(uint32 *)(lVar6 + 24) <= uVar10) {
                          uVar9 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                          FUN_1800d65f0(uVar9,0);
                        }
                        uVar10 = uVar10 + 1;
                        *(uint64 *)(lVar6 + 32 + lVar8 * 12) = *puVar5;
                        *(uint32 *)(lVar6 + 40 + lVar8 * 12) = *(uint32 *)(puVar5 + 1);
                      } while ((int)uVar10 < 4);
                    }
                    return *(uint64 *)(pStatics + 48);
                  }
                }
              }
            }
          }
          else {
            fVar11 = (float)Camera.get_orthographicSize(cam,0);
            puVar5 = (uint64 *)Camera.get_rect(local_b8,cam,0);
            local_a8 = *puVar5;
            uStack_a0 = puVar5[1];
            iVar4 = Screen.get_width(0);
            fVar14 = (float)iVar4;
            iVar4 = Screen.get_height(0);
            fVar15 = (float)iVar4;
            fVar12 = (float)FUN_180d90480(&local_a8,0);
            fVar13 = (float)FUN_18044e2b0(&local_a8,0);
            fVar12 = (fVar12 / fVar13) * (fVar14 / fVar15);
            lVar6 = Component.get_transform(cam,0);
            if (lVar6 != null) {
              puVar5 = (uint64 *)Transform.get_rotation(local_b8,lVar6,0);
              uVar1 = *puVar5;
              uVar2 = puVar5[1];
              puVar5 = (uint64 *)Transform.get_position(&local_c8,lVar6,0);
              uVar9 = *puVar5;
              fVar13 = *(float *)(puVar5 + 1);
              uVar10 = Mathf.RoundToInt(fVar14,0);
              uVar7 = Mathf.RoundToInt(fVar15,0);
              local_f8 = (float)uVar9;
              if ((uVar10 & 1) != 0) {
                local_f8 = local_f8 - 1.0 / fVar14;
              }
              fStack_f4 = (float)((uint64)uVar9 >> 32);
              if ((uVar7 & 1) != 0) {
                fStack_f4 = 1.0 / fVar15 + fStack_f4;
              }
              local_e8 = (uint64)(uint32)(fVar12 * -fVar11);
              lVar6 = *(int64 *)(pStatics + 48);
              local_e0 = param_2;
              local_c8 = uVar1;
              uStack_c0 = uVar2;
              puVar5 = (uint64 *)Quaternion.op_Multiply(local_b8,&local_c8,&local_e8,0);
              local_d8 = *puVar5;
              local_d0 = *(float *)(puVar5 + 1);
              local_e0 = fVar13 + local_d0;
              uStack_c0 = CONCAT44(uStack_c0._4_4_,local_d0);
              local_e8 = CONCAT44(fStack_f4 + (float)((uint64)local_d8 >> 32),
                                  local_f8 + (float)local_d8);
              local_c8 = local_d8;
              if (lVar6 != null) {
                if (*(int *)(lVar6 + 24) == 0) {
                  uVar9 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1800d65f0(uVar9,0);
                }
                *(uint64 *)(lVar6 + 32) = local_e8;
                *(float *)(lVar6 + 40) = local_e0;
                local_e8 = (uint64)(uint32)fVar11 << 32;
                lVar6 = *(int64 *)(pStatics + 48);
                local_e0 = param_2;
                local_c8 = uVar1;
                uStack_c0 = uVar2;
                puVar5 = (uint64 *)Quaternion.op_Multiply(local_b8,&local_c8,&local_e8,0);
                local_d8 = *puVar5;
                local_d0 = *(float *)(puVar5 + 1);
                local_e0 = fVar13 + local_d0;
                uStack_c0 = CONCAT44((int)((uint64)uStack_c0 >> 32),local_d0);
                local_e8 = CONCAT44(fStack_f4 + (float)((uint64)local_d8 >> 32),
                                    local_f8 + (float)local_d8);
                local_c8 = local_d8;
                if (lVar6 != null) {
                  if (*(uint32 *)(lVar6 + 24) < 2) {
                    uVar9 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                    FUN_1800d65f0(uVar9,0);
                  }
                  *(uint64 *)(lVar6 + 44) = local_e8;
                  *(float *)(lVar6 + 52) = local_e0;
                  local_e8 = (uint64)(uint32)(fVar11 * fVar12);
                  lVar6 = *(int64 *)(pStatics + 48);
                  local_e0 = param_2;
                  local_c8 = uVar1;
                  uStack_c0 = uVar2;
                  puVar5 = (uint64 *)Quaternion.op_Multiply(local_b8,&local_c8,&local_e8,0);
                  local_d8 = *puVar5;
                  local_d0 = *(float *)(puVar5 + 1);
                  local_e0 = fVar13 + local_d0;
                  uStack_c0 = CONCAT44((int)((uint64)uStack_c0 >> 32),local_d0);
                  local_e8 = CONCAT44(fStack_f4 + (float)((uint64)local_d8 >> 32),
                                      local_f8 + (float)local_d8);
                  local_c8 = local_d8;
                  if (lVar6 != null) {
                    if (*(uint32 *)(lVar6 + 24) < 3) {
                      uVar9 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                      FUN_1800d65f0(uVar9,0);
                    }
                    *(uint64 *)(lVar6 + 56) = local_e8;
                    *(float *)(lVar6 + 64) = local_e0;
                    local_e8 = (uint64)(uint32)-fVar11 << 32;
                    lVar6 = *(int64 *)(pStatics + 48);
                    local_e0 = param_2;
                    local_c8 = uVar1;
                    uStack_c0 = uVar2;
                    puVar5 = (uint64 *)Quaternion.op_Multiply(local_b8,&local_c8,&local_e8,0);
                    local_d8 = *puVar5;
                    local_d0 = *(float *)(puVar5 + 1);
                    local_e0 = fVar13 + local_d0;
                    local_e8 = CONCAT44(fStack_f4 + (float)((uint64)local_d8 >> 32),
                                        local_f8 + (float)local_d8);
                    if (lVar6 != null) {
                      if (*(uint32 *)(lVar6 + 24) < 4) {
                        uVar9 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                        FUN_1800d65f0(uVar9,0);
                      }
                      *(uint64 *)(lVar6 + 68) = local_e8;
                      *(float *)(lVar6 + 76) = local_e0;
                      goto LAB_181598450;
                    }
                  }
                }
              }
            }
          }
        }
    }

    // Token : 0x600040A
    // RVA   : 0x1597D20   Offset: 0x1596520   Length: 0x66
    public static Vector3[] GetSides(Camera cam, float depth)
    {
        var pStatics = *(int64*)(DAT_181d66af0 + 184);
        ulong uVar1;
        ulong uVar2;
        bool cVar3;
        int iVar4;
        long lVar6;
        ulong uVar7;
        long lVar8;
        ulong uVar9;
        uint uVar10;
        float fVar11;
        float fVar12;
        float fVar13;
        float fVar14;
        float fVar15;
        float local_f8;
        float fStack_f4;
        ulong local_e8;
        float local_e0;
        ulong local_d8;
        float local_d0;
        ulong local_c8;
        ulong uStack_c0;
        byte[] local_b8 = new byte[16];
        ulong local_a8;
        ulong uStack_a0;
        local_a8 = 0;
        uStack_a0 = 0;
        if (cam != null) {
          cVar3 = Camera.get_orthographic(cam,0);
          if (!cVar3) {
            local_e8 = 0x3f00000000000000;
            lVar6 = *(int64 *)(pStatics + 48);
            local_e0 = depth;
            puVar5 = (uint64 *)Camera.ViewportToWorldPoint(&local_c8,cam,&local_e8,0);
            if (lVar6 != null) {
              if (*(int *)(lVar6 + 24) == 0) {
                uVar9 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar9,0);
              }
              *(uint64 *)(lVar6 + 32) = *puVar5;
              *(uint32 *)(lVar6 + 40) = *(uint32 *)(puVar5 + 1);
              local_e8 = 0x3f8000003f000000;
              lVar6 = *(int64 *)(pStatics + 48);
              local_e0 = depth;
              puVar5 = (uint64 *)Camera.ViewportToWorldPoint(&local_c8,cam,&local_e8,0);
              if (lVar6 != null) {
                if (*(uint32 *)(lVar6 + 24) < 2) {
                  uVar9 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1800d65f0(uVar9,0);
                }
                *(uint64 *)(lVar6 + 44) = *puVar5;
                *(uint32 *)(lVar6 + 52) = *(uint32 *)(puVar5 + 1);
                local_e8 = 0x3f0000003f800000;
                lVar6 = *(int64 *)(pStatics + 48);
                local_e0 = depth;
                puVar5 = (uint64 *)Camera.ViewportToWorldPoint(&local_c8,cam,&local_e8,0);
                if (lVar6 != null) {
                  if (*(uint32 *)(lVar6 + 24) < 3) {
                    uVar9 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                    FUN_1800d65f0(uVar9,0);
                  }
                  *(uint64 *)(lVar6 + 56) = *puVar5;
                  *(uint32 *)(lVar6 + 64) = *(uint32 *)(puVar5 + 1);
                  local_e8 = 0x3f000000;
                  lVar6 = *(int64 *)(pStatics + 48);
                  local_e0 = depth;
                  puVar5 = (uint64 *)Camera.ViewportToWorldPoint(&local_c8,cam,&local_e8,0);
                  if (lVar6 != null) {
                    if (*(uint32 *)(lVar6 + 24) < 4) {
                      uVar9 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                      FUN_1800d65f0(uVar9,0);
                    }
                    *(uint64 *)(lVar6 + 68) = *puVar5;
                    *(uint32 *)(lVar6 + 76) = *(uint32 *)(puVar5 + 1);
        LAB_181598450:
                    cVar3 = Object.op_Inequality(param_3,0,0);
                    if (cVar3) {
                      uVar10 = 0;
                      do {
                        lVar6 = *(int64 *)(pStatics + 48);
                        if (lVar6 == null) throw; // [null/range check failed]
                        lVar8 = (int64)(int)uVar10;
                        if (*(uint32 *)(lVar6 + 24) <= uVar10) {
                          uVar9 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                          FUN_1800d65f0(uVar9,0);
                        }
                        if (param_3 == 0) throw; // [null/range check failed]
                        local_d8 = *(uint64 *)(lVar6 + 32 + lVar8 * 12);
                        local_d0 = *(float *)(lVar6 + 40 + lVar8 * 12);
                        puVar5 = (uint64 *)
                                 Transform.InverseTransformPoint(local_b8,param_3,&local_d8,0);
                        if (*(uint32 *)(lVar6 + 24) <= uVar10) {
                          uVar9 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                          FUN_1800d65f0(uVar9,0);
                        }
                        uVar10 = uVar10 + 1;
                        *(uint64 *)(lVar6 + 32 + lVar8 * 12) = *puVar5;
                        *(uint32 *)(lVar6 + 40 + lVar8 * 12) = *(uint32 *)(puVar5 + 1);
                      } while ((int)uVar10 < 4);
                    }
                    return *(uint64 *)(pStatics + 48);
                  }
                }
              }
            }
          }
          else {
            fVar11 = (float)Camera.get_orthographicSize(cam,0);
            puVar5 = (uint64 *)Camera.get_rect(local_b8,cam,0);
            local_a8 = *puVar5;
            uStack_a0 = puVar5[1];
            iVar4 = Screen.get_width(0);
            fVar14 = (float)iVar4;
            iVar4 = Screen.get_height(0);
            fVar15 = (float)iVar4;
            fVar12 = (float)FUN_180d90480(&local_a8,0);
            fVar13 = (float)FUN_18044e2b0(&local_a8,0);
            fVar12 = (fVar12 / fVar13) * (fVar14 / fVar15);
            lVar6 = Component.get_transform(cam,0);
            if (lVar6 != null) {
              puVar5 = (uint64 *)Transform.get_rotation(local_b8,lVar6,0);
              uVar1 = *puVar5;
              uVar2 = puVar5[1];
              puVar5 = (uint64 *)Transform.get_position(&local_c8,lVar6,0);
              uVar9 = *puVar5;
              fVar13 = *(float *)(puVar5 + 1);
              uVar10 = Mathf.RoundToInt(fVar14,0);
              uVar7 = Mathf.RoundToInt(fVar15,0);
              local_f8 = (float)uVar9;
              if ((uVar10 & 1) != 0) {
                local_f8 = local_f8 - 1.0 / fVar14;
              }
              fStack_f4 = (float)((uint64)uVar9 >> 32);
              if ((uVar7 & 1) != 0) {
                fStack_f4 = 1.0 / fVar15 + fStack_f4;
              }
              local_e8 = (uint64)(uint32)(fVar12 * -fVar11);
              lVar6 = *(int64 *)(pStatics + 48);
              local_e0 = depth;
              local_c8 = uVar1;
              uStack_c0 = uVar2;
              puVar5 = (uint64 *)Quaternion.op_Multiply(local_b8,&local_c8,&local_e8,0);
              local_d8 = *puVar5;
              local_d0 = *(float *)(puVar5 + 1);
              local_e0 = fVar13 + local_d0;
              uStack_c0 = CONCAT44(uStack_c0._4_4_,local_d0);
              local_e8 = CONCAT44(fStack_f4 + (float)((uint64)local_d8 >> 32),
                                  local_f8 + (float)local_d8);
              local_c8 = local_d8;
              if (lVar6 != null) {
                if (*(int *)(lVar6 + 24) == 0) {
                  uVar9 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1800d65f0(uVar9,0);
                }
                *(uint64 *)(lVar6 + 32) = local_e8;
                *(float *)(lVar6 + 40) = local_e0;
                local_e8 = (uint64)(uint32)fVar11 << 32;
                lVar6 = *(int64 *)(pStatics + 48);
                local_e0 = depth;
                local_c8 = uVar1;
                uStack_c0 = uVar2;
                puVar5 = (uint64 *)Quaternion.op_Multiply(local_b8,&local_c8,&local_e8,0);
                local_d8 = *puVar5;
                local_d0 = *(float *)(puVar5 + 1);
                local_e0 = fVar13 + local_d0;
                uStack_c0 = CONCAT44((int)((uint64)uStack_c0 >> 32),local_d0);
                local_e8 = CONCAT44(fStack_f4 + (float)((uint64)local_d8 >> 32),
                                    local_f8 + (float)local_d8);
                local_c8 = local_d8;
                if (lVar6 != null) {
                  if (*(uint32 *)(lVar6 + 24) < 2) {
                    uVar9 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                    FUN_1800d65f0(uVar9,0);
                  }
                  *(uint64 *)(lVar6 + 44) = local_e8;
                  *(float *)(lVar6 + 52) = local_e0;
                  local_e8 = (uint64)(uint32)(fVar11 * fVar12);
                  lVar6 = *(int64 *)(pStatics + 48);
                  local_e0 = depth;
                  local_c8 = uVar1;
                  uStack_c0 = uVar2;
                  puVar5 = (uint64 *)Quaternion.op_Multiply(local_b8,&local_c8,&local_e8,0);
                  local_d8 = *puVar5;
                  local_d0 = *(float *)(puVar5 + 1);
                  local_e0 = fVar13 + local_d0;
                  uStack_c0 = CONCAT44((int)((uint64)uStack_c0 >> 32),local_d0);
                  local_e8 = CONCAT44(fStack_f4 + (float)((uint64)local_d8 >> 32),
                                      local_f8 + (float)local_d8);
                  local_c8 = local_d8;
                  if (lVar6 != null) {
                    if (*(uint32 *)(lVar6 + 24) < 3) {
                      uVar9 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                      FUN_1800d65f0(uVar9,0);
                    }
                    *(uint64 *)(lVar6 + 56) = local_e8;
                    *(float *)(lVar6 + 64) = local_e0;
                    local_e8 = (uint64)(uint32)-fVar11 << 32;
                    lVar6 = *(int64 *)(pStatics + 48);
                    local_e0 = depth;
                    local_c8 = uVar1;
                    uStack_c0 = uVar2;
                    puVar5 = (uint64 *)Quaternion.op_Multiply(local_b8,&local_c8,&local_e8,0);
                    local_d8 = *puVar5;
                    local_d0 = *(float *)(puVar5 + 1);
                    local_e0 = fVar13 + local_d0;
                    local_e8 = CONCAT44(fStack_f4 + (float)((uint64)local_d8 >> 32),
                                        local_f8 + (float)local_d8);
                    if (lVar6 != null) {
                      if (*(uint32 *)(lVar6 + 24) < 4) {
                        uVar9 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                        FUN_1800d65f0(uVar9,0);
                      }
                      *(uint64 *)(lVar6 + 68) = local_e8;
                      *(float *)(lVar6 + 76) = local_e0;
                      goto LAB_181598450;
                    }
                  }
                }
              }
            }
          }
        }
    }

    // Token : 0x600040B
    // RVA   : 0x1597C70   Offset: 0x1596470   Length: 0xA9
    public static Vector3[] GetSides(Camera cam, Transform relativeTo)
    {
        var pStatics = *(int64*)(DAT_181d66af0 + 184);
        ulong uVar1;
        ulong uVar2;
        bool cVar3;
        int iVar4;
        long lVar6;
        ulong uVar7;
        long lVar8;
        ulong uVar9;
        uint uVar10;
        float fVar11;
        float fVar12;
        float fVar13;
        float fVar14;
        float fVar15;
        float local_f8;
        float fStack_f4;
        ulong local_e8;
        float local_e0;
        ulong local_d8;
        float local_d0;
        ulong local_c8;
        ulong uStack_c0;
        byte[] local_b8 = new byte[16];
        ulong local_a8;
        ulong uStack_a0;
        local_a8 = 0;
        uStack_a0 = 0;
        if (cam != null) {
          cVar3 = Camera.get_orthographic(cam,0);
          if (!cVar3) {
            local_e8 = 0x3f00000000000000;
            lVar6 = *(int64 *)(pStatics + 48);
            local_e0 = relativeTo;
            puVar5 = (uint64 *)Camera.ViewportToWorldPoint(&local_c8,cam,&local_e8,0);
            if (lVar6 != null) {
              if (*(int *)(lVar6 + 24) == 0) {
                uVar9 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar9,0);
              }
              *(uint64 *)(lVar6 + 32) = *puVar5;
              *(uint32 *)(lVar6 + 40) = *(uint32 *)(puVar5 + 1);
              local_e8 = 0x3f8000003f000000;
              lVar6 = *(int64 *)(pStatics + 48);
              local_e0 = relativeTo;
              puVar5 = (uint64 *)Camera.ViewportToWorldPoint(&local_c8,cam,&local_e8,0);
              if (lVar6 != null) {
                if (*(uint32 *)(lVar6 + 24) < 2) {
                  uVar9 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1800d65f0(uVar9,0);
                }
                *(uint64 *)(lVar6 + 44) = *puVar5;
                *(uint32 *)(lVar6 + 52) = *(uint32 *)(puVar5 + 1);
                local_e8 = 0x3f0000003f800000;
                lVar6 = *(int64 *)(pStatics + 48);
                local_e0 = relativeTo;
                puVar5 = (uint64 *)Camera.ViewportToWorldPoint(&local_c8,cam,&local_e8,0);
                if (lVar6 != null) {
                  if (*(uint32 *)(lVar6 + 24) < 3) {
                    uVar9 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                    FUN_1800d65f0(uVar9,0);
                  }
                  *(uint64 *)(lVar6 + 56) = *puVar5;
                  *(uint32 *)(lVar6 + 64) = *(uint32 *)(puVar5 + 1);
                  local_e8 = 0x3f000000;
                  lVar6 = *(int64 *)(pStatics + 48);
                  local_e0 = relativeTo;
                  puVar5 = (uint64 *)Camera.ViewportToWorldPoint(&local_c8,cam,&local_e8,0);
                  if (lVar6 != null) {
                    if (*(uint32 *)(lVar6 + 24) < 4) {
                      uVar9 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                      FUN_1800d65f0(uVar9,0);
                    }
                    *(uint64 *)(lVar6 + 68) = *puVar5;
                    *(uint32 *)(lVar6 + 76) = *(uint32 *)(puVar5 + 1);
        LAB_181598450:
                    cVar3 = Object.op_Inequality(param_3,0,0);
                    if (cVar3) {
                      uVar10 = 0;
                      do {
                        lVar6 = *(int64 *)(pStatics + 48);
                        if (lVar6 == null) throw; // [null/range check failed]
                        lVar8 = (int64)(int)uVar10;
                        if (*(uint32 *)(lVar6 + 24) <= uVar10) {
                          uVar9 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                          FUN_1800d65f0(uVar9,0);
                        }
                        if (param_3 == 0) throw; // [null/range check failed]
                        local_d8 = *(uint64 *)(lVar6 + 32 + lVar8 * 12);
                        local_d0 = *(float *)(lVar6 + 40 + lVar8 * 12);
                        puVar5 = (uint64 *)
                                 Transform.InverseTransformPoint(local_b8,param_3,&local_d8,0);
                        if (*(uint32 *)(lVar6 + 24) <= uVar10) {
                          uVar9 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                          FUN_1800d65f0(uVar9,0);
                        }
                        uVar10 = uVar10 + 1;
                        *(uint64 *)(lVar6 + 32 + lVar8 * 12) = *puVar5;
                        *(uint32 *)(lVar6 + 40 + lVar8 * 12) = *(uint32 *)(puVar5 + 1);
                      } while ((int)uVar10 < 4);
                    }
                    return *(uint64 *)(pStatics + 48);
                  }
                }
              }
            }
          }
          else {
            fVar11 = (float)Camera.get_orthographicSize(cam,0);
            puVar5 = (uint64 *)Camera.get_rect(local_b8,cam,0);
            local_a8 = *puVar5;
            uStack_a0 = puVar5[1];
            iVar4 = Screen.get_width(0);
            fVar14 = (float)iVar4;
            iVar4 = Screen.get_height(0);
            fVar15 = (float)iVar4;
            fVar12 = (float)FUN_180d90480(&local_a8,0);
            fVar13 = (float)FUN_18044e2b0(&local_a8,0);
            fVar12 = (fVar12 / fVar13) * (fVar14 / fVar15);
            lVar6 = Component.get_transform(cam,0);
            if (lVar6 != null) {
              puVar5 = (uint64 *)Transform.get_rotation(local_b8,lVar6,0);
              uVar1 = *puVar5;
              uVar2 = puVar5[1];
              puVar5 = (uint64 *)Transform.get_position(&local_c8,lVar6,0);
              uVar9 = *puVar5;
              fVar13 = *(float *)(puVar5 + 1);
              uVar10 = Mathf.RoundToInt(fVar14,0);
              uVar7 = Mathf.RoundToInt(fVar15,0);
              local_f8 = (float)uVar9;
              if ((uVar10 & 1) != 0) {
                local_f8 = local_f8 - 1.0 / fVar14;
              }
              fStack_f4 = (float)((uint64)uVar9 >> 32);
              if ((uVar7 & 1) != 0) {
                fStack_f4 = 1.0 / fVar15 + fStack_f4;
              }
              local_e8 = (uint64)(uint32)(fVar12 * -fVar11);
              lVar6 = *(int64 *)(pStatics + 48);
              local_e0 = relativeTo;
              local_c8 = uVar1;
              uStack_c0 = uVar2;
              puVar5 = (uint64 *)Quaternion.op_Multiply(local_b8,&local_c8,&local_e8,0);
              local_d8 = *puVar5;
              local_d0 = *(float *)(puVar5 + 1);
              local_e0 = fVar13 + local_d0;
              uStack_c0 = CONCAT44(uStack_c0._4_4_,local_d0);
              local_e8 = CONCAT44(fStack_f4 + (float)((uint64)local_d8 >> 32),
                                  local_f8 + (float)local_d8);
              local_c8 = local_d8;
              if (lVar6 != null) {
                if (*(int *)(lVar6 + 24) == 0) {
                  uVar9 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1800d65f0(uVar9,0);
                }
                *(uint64 *)(lVar6 + 32) = local_e8;
                *(float *)(lVar6 + 40) = local_e0;
                local_e8 = (uint64)(uint32)fVar11 << 32;
                lVar6 = *(int64 *)(pStatics + 48);
                local_e0 = relativeTo;
                local_c8 = uVar1;
                uStack_c0 = uVar2;
                puVar5 = (uint64 *)Quaternion.op_Multiply(local_b8,&local_c8,&local_e8,0);
                local_d8 = *puVar5;
                local_d0 = *(float *)(puVar5 + 1);
                local_e0 = fVar13 + local_d0;
                uStack_c0 = CONCAT44((int)((uint64)uStack_c0 >> 32),local_d0);
                local_e8 = CONCAT44(fStack_f4 + (float)((uint64)local_d8 >> 32),
                                    local_f8 + (float)local_d8);
                local_c8 = local_d8;
                if (lVar6 != null) {
                  if (*(uint32 *)(lVar6 + 24) < 2) {
                    uVar9 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                    FUN_1800d65f0(uVar9,0);
                  }
                  *(uint64 *)(lVar6 + 44) = local_e8;
                  *(float *)(lVar6 + 52) = local_e0;
                  local_e8 = (uint64)(uint32)(fVar11 * fVar12);
                  lVar6 = *(int64 *)(pStatics + 48);
                  local_e0 = relativeTo;
                  local_c8 = uVar1;
                  uStack_c0 = uVar2;
                  puVar5 = (uint64 *)Quaternion.op_Multiply(local_b8,&local_c8,&local_e8,0);
                  local_d8 = *puVar5;
                  local_d0 = *(float *)(puVar5 + 1);
                  local_e0 = fVar13 + local_d0;
                  uStack_c0 = CONCAT44((int)((uint64)uStack_c0 >> 32),local_d0);
                  local_e8 = CONCAT44(fStack_f4 + (float)((uint64)local_d8 >> 32),
                                      local_f8 + (float)local_d8);
                  local_c8 = local_d8;
                  if (lVar6 != null) {
                    if (*(uint32 *)(lVar6 + 24) < 3) {
                      uVar9 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                      FUN_1800d65f0(uVar9,0);
                    }
                    *(uint64 *)(lVar6 + 56) = local_e8;
                    *(float *)(lVar6 + 64) = local_e0;
                    local_e8 = (uint64)(uint32)-fVar11 << 32;
                    lVar6 = *(int64 *)(pStatics + 48);
                    local_e0 = relativeTo;
                    local_c8 = uVar1;
                    uStack_c0 = uVar2;
                    puVar5 = (uint64 *)Quaternion.op_Multiply(local_b8,&local_c8,&local_e8,0);
                    local_d8 = *puVar5;
                    local_d0 = *(float *)(puVar5 + 1);
                    local_e0 = fVar13 + local_d0;
                    local_e8 = CONCAT44(fStack_f4 + (float)((uint64)local_d8 >> 32),
                                        local_f8 + (float)local_d8);
                    if (lVar6 != null) {
                      if (*(uint32 *)(lVar6 + 24) < 4) {
                        uVar9 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                        FUN_1800d65f0(uVar9,0);
                      }
                      *(uint64 *)(lVar6 + 68) = local_e8;
                      *(float *)(lVar6 + 76) = local_e0;
                      goto LAB_181598450;
                    }
                  }
                }
              }
            }
          }
        }
    }

    // Token : 0x600040C
    // RVA   : 0x1597D90   Offset: 0x1596590   Length: 0x8EB
    public static Vector3[] GetSides(Camera cam, float depth, Transform relativeTo)
    {
        var pStatics = *(int64*)(DAT_181d66af0 + 184);
        ulong uVar1;
        ulong uVar2;
        bool cVar3;
        int iVar4;
        long lVar6;
        ulong uVar7;
        long lVar8;
        ulong uVar9;
        uint uVar10;
        float fVar11;
        float fVar12;
        float fVar13;
        float fVar14;
        float fVar15;
        float local_f8;
        float fStack_f4;
        ulong local_e8;
        float local_e0;
        ulong local_d8;
        float local_d0;
        ulong local_c8;
        ulong uStack_c0;
        byte[] local_b8 = new byte[16];
        ulong local_a8;
        ulong uStack_a0;
        local_a8 = 0;
        uStack_a0 = 0;
        if (cam != null) {
          cVar3 = Camera.get_orthographic(cam,0);
          if (!cVar3) {
            local_e8 = 0x3f00000000000000;
            lVar6 = *(int64 *)(pStatics + 48);
            local_e0 = depth;
            puVar5 = (uint64 *)Camera.ViewportToWorldPoint(&local_c8,cam,&local_e8,0);
            if (lVar6 != null) {
              if (*(int *)(lVar6 + 24) == 0) {
                uVar9 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar9,0);
              }
              *(uint64 *)(lVar6 + 32) = *puVar5;
              *(uint32 *)(lVar6 + 40) = *(uint32 *)(puVar5 + 1);
              local_e8 = 0x3f8000003f000000;
              lVar6 = *(int64 *)(pStatics + 48);
              local_e0 = depth;
              puVar5 = (uint64 *)Camera.ViewportToWorldPoint(&local_c8,cam,&local_e8,0);
              if (lVar6 != null) {
                if (*(uint32 *)(lVar6 + 24) < 2) {
                  uVar9 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1800d65f0(uVar9,0);
                }
                *(uint64 *)(lVar6 + 44) = *puVar5;
                *(uint32 *)(lVar6 + 52) = *(uint32 *)(puVar5 + 1);
                local_e8 = 0x3f0000003f800000;
                lVar6 = *(int64 *)(pStatics + 48);
                local_e0 = depth;
                puVar5 = (uint64 *)Camera.ViewportToWorldPoint(&local_c8,cam,&local_e8,0);
                if (lVar6 != null) {
                  if (*(uint32 *)(lVar6 + 24) < 3) {
                    uVar9 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                    FUN_1800d65f0(uVar9,0);
                  }
                  *(uint64 *)(lVar6 + 56) = *puVar5;
                  *(uint32 *)(lVar6 + 64) = *(uint32 *)(puVar5 + 1);
                  local_e8 = 0x3f000000;
                  lVar6 = *(int64 *)(pStatics + 48);
                  local_e0 = depth;
                  puVar5 = (uint64 *)Camera.ViewportToWorldPoint(&local_c8,cam,&local_e8,0);
                  if (lVar6 != null) {
                    if (*(uint32 *)(lVar6 + 24) < 4) {
                      uVar9 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                      FUN_1800d65f0(uVar9,0);
                    }
                    *(uint64 *)(lVar6 + 68) = *puVar5;
                    *(uint32 *)(lVar6 + 76) = *(uint32 *)(puVar5 + 1);
        LAB_181598450:
                    cVar3 = Object.op_Inequality(relativeTo,0,0);
                    if (cVar3) {
                      uVar10 = 0;
                      do {
                        lVar6 = *(int64 *)(pStatics + 48);
                        if (lVar6 == null) throw; // [null/range check failed]
                        lVar8 = (int64)(int)uVar10;
                        if (*(uint32 *)(lVar6 + 24) <= uVar10) {
                          uVar9 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                          FUN_1800d65f0(uVar9,0);
                        }
                        if (relativeTo == null) throw; // [null/range check failed]
                        local_d8 = *(uint64 *)(lVar6 + 32 + lVar8 * 12);
                        local_d0 = *(float *)(lVar6 + 40 + lVar8 * 12);
                        puVar5 = (uint64 *)
                                 Transform.InverseTransformPoint(local_b8,relativeTo,&local_d8,0);
                        if (*(uint32 *)(lVar6 + 24) <= uVar10) {
                          uVar9 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                          FUN_1800d65f0(uVar9,0);
                        }
                        uVar10 = uVar10 + 1;
                        *(uint64 *)(lVar6 + 32 + lVar8 * 12) = *puVar5;
                        *(uint32 *)(lVar6 + 40 + lVar8 * 12) = *(uint32 *)(puVar5 + 1);
                      } while ((int)uVar10 < 4);
                    }
                    return *(uint64 *)(pStatics + 48);
                  }
                }
              }
            }
          }
          else {
            fVar11 = (float)Camera.get_orthographicSize(cam,0);
            puVar5 = (uint64 *)Camera.get_rect(local_b8,cam,0);
            local_a8 = *puVar5;
            uStack_a0 = puVar5[1];
            iVar4 = Screen.get_width(0);
            fVar14 = (float)iVar4;
            iVar4 = Screen.get_height(0);
            fVar15 = (float)iVar4;
            fVar12 = (float)FUN_180d90480(&local_a8,0);
            fVar13 = (float)FUN_18044e2b0(&local_a8,0);
            fVar12 = (fVar12 / fVar13) * (fVar14 / fVar15);
            lVar6 = Component.get_transform(cam,0);
            if (lVar6 != null) {
              puVar5 = (uint64 *)Transform.get_rotation(local_b8,lVar6,0);
              uVar1 = *puVar5;
              uVar2 = puVar5[1];
              puVar5 = (uint64 *)Transform.get_position(&local_c8,lVar6,0);
              uVar9 = *puVar5;
              fVar13 = *(float *)(puVar5 + 1);
              uVar10 = Mathf.RoundToInt(fVar14,0);
              uVar7 = Mathf.RoundToInt(fVar15,0);
              local_f8 = (float)uVar9;
              if ((uVar10 & 1) != 0) {
                local_f8 = local_f8 - 1.0 / fVar14;
              }
              fStack_f4 = (float)((uint64)uVar9 >> 32);
              if ((uVar7 & 1) != 0) {
                fStack_f4 = 1.0 / fVar15 + fStack_f4;
              }
              local_e8 = (uint64)(uint32)(fVar12 * -fVar11);
              lVar6 = *(int64 *)(pStatics + 48);
              local_e0 = depth;
              local_c8 = uVar1;
              uStack_c0 = uVar2;
              puVar5 = (uint64 *)Quaternion.op_Multiply(local_b8,&local_c8,&local_e8,0);
              local_d8 = *puVar5;
              local_d0 = *(float *)(puVar5 + 1);
              local_e0 = fVar13 + local_d0;
              uStack_c0 = CONCAT44(uStack_c0._4_4_,local_d0);
              local_e8 = CONCAT44(fStack_f4 + (float)((uint64)local_d8 >> 32),
                                  local_f8 + (float)local_d8);
              local_c8 = local_d8;
              if (lVar6 != null) {
                if (*(int *)(lVar6 + 24) == 0) {
                  uVar9 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1800d65f0(uVar9,0);
                }
                *(uint64 *)(lVar6 + 32) = local_e8;
                *(float *)(lVar6 + 40) = local_e0;
                local_e8 = (uint64)(uint32)fVar11 << 32;
                lVar6 = *(int64 *)(pStatics + 48);
                local_e0 = depth;
                local_c8 = uVar1;
                uStack_c0 = uVar2;
                puVar5 = (uint64 *)Quaternion.op_Multiply(local_b8,&local_c8,&local_e8,0);
                local_d8 = *puVar5;
                local_d0 = *(float *)(puVar5 + 1);
                local_e0 = fVar13 + local_d0;
                uStack_c0 = CONCAT44((int)((uint64)uStack_c0 >> 32),local_d0);
                local_e8 = CONCAT44(fStack_f4 + (float)((uint64)local_d8 >> 32),
                                    local_f8 + (float)local_d8);
                local_c8 = local_d8;
                if (lVar6 != null) {
                  if (*(uint32 *)(lVar6 + 24) < 2) {
                    uVar9 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                    FUN_1800d65f0(uVar9,0);
                  }
                  *(uint64 *)(lVar6 + 44) = local_e8;
                  *(float *)(lVar6 + 52) = local_e0;
                  local_e8 = (uint64)(uint32)(fVar11 * fVar12);
                  lVar6 = *(int64 *)(pStatics + 48);
                  local_e0 = depth;
                  local_c8 = uVar1;
                  uStack_c0 = uVar2;
                  puVar5 = (uint64 *)Quaternion.op_Multiply(local_b8,&local_c8,&local_e8,0);
                  local_d8 = *puVar5;
                  local_d0 = *(float *)(puVar5 + 1);
                  local_e0 = fVar13 + local_d0;
                  uStack_c0 = CONCAT44((int)((uint64)uStack_c0 >> 32),local_d0);
                  local_e8 = CONCAT44(fStack_f4 + (float)((uint64)local_d8 >> 32),
                                      local_f8 + (float)local_d8);
                  local_c8 = local_d8;
                  if (lVar6 != null) {
                    if (*(uint32 *)(lVar6 + 24) < 3) {
                      uVar9 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                      FUN_1800d65f0(uVar9,0);
                    }
                    *(uint64 *)(lVar6 + 56) = local_e8;
                    *(float *)(lVar6 + 64) = local_e0;
                    local_e8 = (uint64)(uint32)-fVar11 << 32;
                    lVar6 = *(int64 *)(pStatics + 48);
                    local_e0 = depth;
                    local_c8 = uVar1;
                    uStack_c0 = uVar2;
                    puVar5 = (uint64 *)Quaternion.op_Multiply(local_b8,&local_c8,&local_e8,0);
                    local_d8 = *puVar5;
                    local_d0 = *(float *)(puVar5 + 1);
                    local_e0 = fVar13 + local_d0;
                    local_e8 = CONCAT44(fStack_f4 + (float)((uint64)local_d8 >> 32),
                                        local_f8 + (float)local_d8);
                    if (lVar6 != null) {
                      if (*(uint32 *)(lVar6 + 24) < 4) {
                        uVar9 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                        FUN_1800d65f0(uVar9,0);
                      }
                      *(uint64 *)(lVar6 + 68) = local_e8;
                      *(float *)(lVar6 + 76) = local_e0;
                      goto LAB_181598450;
                    }
                  }
                }
              }
            }
          }
        }
    }

    // Token : 0x600040D
    // RVA   : 0x15987B0   Offset: 0x1596FB0   Length: 0x9D
    public static Vector3[] GetWorldCorners(Camera cam)
    {
        var pStatics = *(int64*)(DAT_181d66af0 + 184);
        ulong uVar1;
        ulong uVar2;
        float fVar3;
        float fVar4;
        bool cVar5;
        int iVar6;
        int iVar7;
        long lVar9;
        long lVar10;
        ulong uVar11;
        uint uVar12;
        float fVar13;
        float fVar14;
        float fVar15;
        float fVar16;
        ulong local_f8;
        float local_f0;
        ulong local_e8;
        float local_e0;
        ulong local_d8;
        ulong uStack_d0;
        ulong local_c8;
        float local_c0;
        ulong local_b8;
        ulong uStack_b0;
        byte[] local_a8 = new byte[16];
        ulong local_98;
        ulong uStack_90;
        local_98 = 0;
        uStack_90 = 0;
        if (cam != null) {
          cVar5 = Camera.get_orthographic(cam,0);
          if (!cVar5) {
            local_e8 = 0;
            lVar9 = *(int64 *)(pStatics + 48);
            local_e0 = param_2;
            puVar8 = (uint64 *)Camera.ViewportToWorldPoint(&local_b8,cam,&local_e8,0);
            if (lVar9 != null) {
              if (*(int *)(lVar9 + 24) == 0) {
                uVar11 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar11,0);
              }
              *(uint64 *)(lVar9 + 32) = *puVar8;
              *(uint32 *)(lVar9 + 40) = *(uint32 *)(puVar8 + 1);
              local_e8 = 0x3f80000000000000;
              lVar9 = *(int64 *)(pStatics + 48);
              local_e0 = param_2;
              puVar8 = (uint64 *)Camera.ViewportToWorldPoint(&local_b8,cam,&local_e8,0);
              if (lVar9 != null) {
                if (*(uint32 *)(lVar9 + 24) < 2) {
                  uVar11 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1800d65f0(uVar11,0);
                }
                *(uint64 *)(lVar9 + 44) = *puVar8;
                *(uint32 *)(lVar9 + 52) = *(uint32 *)(puVar8 + 1);
                local_e8 = 0x3f8000003f800000;
                lVar9 = *(int64 *)(pStatics + 48);
                local_e0 = param_2;
                puVar8 = (uint64 *)Camera.ViewportToWorldPoint(&local_b8,cam,&local_e8,0);
                if (lVar9 != null) {
                  if (*(uint32 *)(lVar9 + 24) < 3) {
                    uVar11 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                    FUN_1800d65f0(uVar11,0);
                  }
                  *(uint64 *)(lVar9 + 56) = *puVar8;
                  *(uint32 *)(lVar9 + 64) = *(uint32 *)(puVar8 + 1);
                  local_e8 = 0x3f800000;
                  lVar9 = *(int64 *)(pStatics + 48);
                  local_e0 = param_2;
                  puVar8 = (uint64 *)Camera.ViewportToWorldPoint(&local_b8,cam,&local_e8,0);
                  if (lVar9 != null) {
                    if (*(uint32 *)(lVar9 + 24) < 4) {
                      uVar11 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                      FUN_1800d65f0(uVar11,0);
                    }
                    *(uint64 *)(lVar9 + 68) = *puVar8;
                    *(uint32 *)(lVar9 + 76) = *(uint32 *)(puVar8 + 1);
        LAB_181598fc0:
                    cVar5 = Object.op_Inequality(param_3,0,0);
                    if (cVar5) {
                      uVar12 = 0;
                      do {
                        lVar9 = *(int64 *)(pStatics + 48);
                        if (lVar9 == null) throw; // [null/range check failed]
                        lVar10 = (int64)(int)uVar12;
                        if (*(uint32 *)(lVar9 + 24) <= uVar12) {
                          uVar11 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                          FUN_1800d65f0(uVar11,0);
                        }
                        if (param_3 == 0) throw; // [null/range check failed]
                        local_c8 = *(uint64 *)(lVar9 + 32 + lVar10 * 12);
                        local_c0 = *(float *)(lVar9 + 40 + lVar10 * 12);
                        puVar8 = (uint64 *)
                                 Transform.InverseTransformPoint(local_a8,param_3,&local_c8,0);
                        if (*(uint32 *)(lVar9 + 24) <= uVar12) {
                          uVar11 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                          FUN_1800d65f0(uVar11,0);
                        }
                        uVar12 = uVar12 + 1;
                        *(uint64 *)(lVar9 + 32 + lVar10 * 12) = *puVar8;
                        *(uint32 *)(lVar9 + 40 + lVar10 * 12) = *(uint32 *)(puVar8 + 1);
                      } while ((int)uVar12 < 4);
                    }
                    return *(uint64 *)(pStatics + 48);
                  }
                }
              }
            }
          }
          else {
            fVar13 = (float)Camera.get_orthographicSize(cam,0);
            fVar16 = -fVar13;
            puVar8 = (uint64 *)Camera.get_rect(local_a8,cam,0);
            local_98 = *puVar8;
            uStack_90 = puVar8[1];
            iVar6 = Screen.get_width(0);
            iVar7 = Screen.get_height(0);
            fVar14 = (float)FUN_180d90480(&local_98,0);
            fVar15 = (float)FUN_18044e2b0(&local_98,0);
            fVar14 = (fVar14 / fVar15) * ((float)iVar6 / (float)iVar7);
            fVar15 = fVar13 * fVar14;
            fVar14 = fVar14 * fVar16;
            lVar9 = Component.get_transform(cam,0);
            if (lVar9 != null) {
              puVar8 = (uint64 *)Transform.get_rotation(local_a8,lVar9,0);
              uVar1 = *puVar8;
              uVar2 = puVar8[1];
              puVar8 = (uint64 *)Transform.get_position(&local_b8,lVar9,0);
              local_f8 = CONCAT44(fVar16,fVar14);
              local_e0 = *(float *)(puVar8 + 1);
              uVar11 = *puVar8;
              local_c0 = *(float *)(puVar8 + 1);
              lVar9 = *(int64 *)(pStatics + 48);
              local_f0 = param_2;
              local_e8 = uVar11;
              local_d8 = uVar1;
              uStack_d0 = uVar2;
              puVar8 = (uint64 *)Quaternion.op_Multiply(local_a8,&local_d8,&local_f8,0);
              local_b8 = *puVar8;
              local_f0 = *(float *)(puVar8 + 1);
              uStack_d0 = CONCAT44(uStack_d0._4_4_,local_f0);
              uStack_b0 = CONCAT44(uStack_b0._4_4_,local_f0);
              local_f0 = local_f0 + local_c0;
              local_f8 = CONCAT44((float)((uint64)local_b8 >> 32) +
                                  (float)((uint64)uVar11 >> 32),(float)uVar11 + (float)local_b8);
              local_c8 = uVar11;
              if (lVar9 != null) {
                if (*(int *)(lVar9 + 24) == 0) {
                  uVar11 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1800d65f0(uVar11,0);
                }
                *(uint64 *)(lVar9 + 32) = local_f8;
                *(float *)(lVar9 + 40) = local_f0;
                local_f8 = CONCAT44(fVar13,fVar14);
                lVar9 = *(int64 *)(pStatics + 48);
                local_f0 = param_2;
                local_b8 = uVar1;
                uStack_b0 = uVar2;
                puVar8 = (uint64 *)Quaternion.op_Multiply(local_a8,&local_b8,&local_f8,0);
                fVar4 = local_e0;
                fVar14 = (float)local_e8;
                fVar3 = local_e8._4_4_;
                local_c8 = *puVar8;
                local_c0 = *(float *)(puVar8 + 1);
                uStack_b0 = CONCAT44((int)((uint64)uStack_b0 >> 32),local_c0);
                local_f0 = local_e0 + local_c0;
                local_f8 = CONCAT44(local_e8._4_4_ + (float)((uint64)local_c8 >> 32),
                                    (float)local_e8 + (float)local_c8);
                local_b8 = local_c8;
                if (lVar9 != null) {
                  if (*(uint32 *)(lVar9 + 24) < 2) {
                    uVar11 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                    FUN_1800d65f0(uVar11,0);
                  }
                  *(uint64 *)(lVar9 + 44) = local_f8;
                  *(float *)(lVar9 + 52) = local_f0;
                  local_e8 = CONCAT44(fVar13,fVar15);
                  lVar9 = *(int64 *)(pStatics + 48);
                  local_e0 = param_2;
                  local_b8 = uVar1;
                  uStack_b0 = uVar2;
                  puVar8 = (uint64 *)Quaternion.op_Multiply(local_a8,&local_b8,&local_e8,0);
                  local_c8 = *puVar8;
                  local_c0 = *(float *)(puVar8 + 1);
                  local_e0 = fVar4 + local_c0;
                  uStack_b0 = CONCAT44((int)((uint64)uStack_b0 >> 32),local_c0);
                  local_e8 = CONCAT44(fVar3 + (float)((uint64)local_c8 >> 32),
                                      fVar14 + (float)local_c8);
                  local_b8 = local_c8;
                  if (lVar9 != null) {
                    if (*(uint32 *)(lVar9 + 24) < 3) {
                      uVar11 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                      FUN_1800d65f0(uVar11,0);
                    }
                    *(uint64 *)(lVar9 + 56) = local_e8;
                    *(float *)(lVar9 + 64) = local_e0;
                    local_e8 = CONCAT44(fVar16,fVar15);
                    lVar9 = *(int64 *)(pStatics + 48);
                    local_e0 = param_2;
                    local_b8 = uVar1;
                    uStack_b0 = uVar2;
                    puVar8 = (uint64 *)Quaternion.op_Multiply(local_a8,&local_b8,&local_e8,0);
                    local_c8 = *puVar8;
                    local_c0 = *(float *)(puVar8 + 1);
                    local_e0 = fVar4 + local_c0;
                    local_e8 = CONCAT44(fVar3 + (float)((uint64)local_c8 >> 32),
                                        fVar14 + (float)local_c8);
                    if (lVar9 != null) {
                      if (*(uint32 *)(lVar9 + 24) < 4) {
                        uVar11 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                        FUN_1800d65f0(uVar11,0);
                      }
                      *(uint64 *)(lVar9 + 68) = local_e8;
                      *(float *)(lVar9 + 76) = local_e0;
                      goto LAB_181598fc0;
                    }
                  }
                }
              }
            }
          }
        }
    }

    // Token : 0x600040E
    // RVA   : 0x1598850   Offset: 0x1597050   Length: 0x66
    public static Vector3[] GetWorldCorners(Camera cam, float depth)
    {
        var pStatics = *(int64*)(DAT_181d66af0 + 184);
        ulong uVar1;
        ulong uVar2;
        float fVar3;
        float fVar4;
        bool cVar5;
        int iVar6;
        int iVar7;
        long lVar9;
        long lVar10;
        ulong uVar11;
        uint uVar12;
        float fVar13;
        float fVar14;
        float fVar15;
        float fVar16;
        ulong local_f8;
        float local_f0;
        ulong local_e8;
        float local_e0;
        ulong local_d8;
        ulong uStack_d0;
        ulong local_c8;
        float local_c0;
        ulong local_b8;
        ulong uStack_b0;
        byte[] local_a8 = new byte[16];
        ulong local_98;
        ulong uStack_90;
        local_98 = 0;
        uStack_90 = 0;
        if (cam != null) {
          cVar5 = Camera.get_orthographic(cam,0);
          if (!cVar5) {
            local_e8 = 0;
            lVar9 = *(int64 *)(pStatics + 48);
            local_e0 = depth;
            puVar8 = (uint64 *)Camera.ViewportToWorldPoint(&local_b8,cam,&local_e8,0);
            if (lVar9 != null) {
              if (*(int *)(lVar9 + 24) == 0) {
                uVar11 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar11,0);
              }
              *(uint64 *)(lVar9 + 32) = *puVar8;
              *(uint32 *)(lVar9 + 40) = *(uint32 *)(puVar8 + 1);
              local_e8 = 0x3f80000000000000;
              lVar9 = *(int64 *)(pStatics + 48);
              local_e0 = depth;
              puVar8 = (uint64 *)Camera.ViewportToWorldPoint(&local_b8,cam,&local_e8,0);
              if (lVar9 != null) {
                if (*(uint32 *)(lVar9 + 24) < 2) {
                  uVar11 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1800d65f0(uVar11,0);
                }
                *(uint64 *)(lVar9 + 44) = *puVar8;
                *(uint32 *)(lVar9 + 52) = *(uint32 *)(puVar8 + 1);
                local_e8 = 0x3f8000003f800000;
                lVar9 = *(int64 *)(pStatics + 48);
                local_e0 = depth;
                puVar8 = (uint64 *)Camera.ViewportToWorldPoint(&local_b8,cam,&local_e8,0);
                if (lVar9 != null) {
                  if (*(uint32 *)(lVar9 + 24) < 3) {
                    uVar11 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                    FUN_1800d65f0(uVar11,0);
                  }
                  *(uint64 *)(lVar9 + 56) = *puVar8;
                  *(uint32 *)(lVar9 + 64) = *(uint32 *)(puVar8 + 1);
                  local_e8 = 0x3f800000;
                  lVar9 = *(int64 *)(pStatics + 48);
                  local_e0 = depth;
                  puVar8 = (uint64 *)Camera.ViewportToWorldPoint(&local_b8,cam,&local_e8,0);
                  if (lVar9 != null) {
                    if (*(uint32 *)(lVar9 + 24) < 4) {
                      uVar11 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                      FUN_1800d65f0(uVar11,0);
                    }
                    *(uint64 *)(lVar9 + 68) = *puVar8;
                    *(uint32 *)(lVar9 + 76) = *(uint32 *)(puVar8 + 1);
        LAB_181598fc0:
                    cVar5 = Object.op_Inequality(param_3,0,0);
                    if (cVar5) {
                      uVar12 = 0;
                      do {
                        lVar9 = *(int64 *)(pStatics + 48);
                        if (lVar9 == null) throw; // [null/range check failed]
                        lVar10 = (int64)(int)uVar12;
                        if (*(uint32 *)(lVar9 + 24) <= uVar12) {
                          uVar11 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                          FUN_1800d65f0(uVar11,0);
                        }
                        if (param_3 == 0) throw; // [null/range check failed]
                        local_c8 = *(uint64 *)(lVar9 + 32 + lVar10 * 12);
                        local_c0 = *(float *)(lVar9 + 40 + lVar10 * 12);
                        puVar8 = (uint64 *)
                                 Transform.InverseTransformPoint(local_a8,param_3,&local_c8,0);
                        if (*(uint32 *)(lVar9 + 24) <= uVar12) {
                          uVar11 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                          FUN_1800d65f0(uVar11,0);
                        }
                        uVar12 = uVar12 + 1;
                        *(uint64 *)(lVar9 + 32 + lVar10 * 12) = *puVar8;
                        *(uint32 *)(lVar9 + 40 + lVar10 * 12) = *(uint32 *)(puVar8 + 1);
                      } while ((int)uVar12 < 4);
                    }
                    return *(uint64 *)(pStatics + 48);
                  }
                }
              }
            }
          }
          else {
            fVar13 = (float)Camera.get_orthographicSize(cam,0);
            fVar16 = -fVar13;
            puVar8 = (uint64 *)Camera.get_rect(local_a8,cam,0);
            local_98 = *puVar8;
            uStack_90 = puVar8[1];
            iVar6 = Screen.get_width(0);
            iVar7 = Screen.get_height(0);
            fVar14 = (float)FUN_180d90480(&local_98,0);
            fVar15 = (float)FUN_18044e2b0(&local_98,0);
            fVar14 = (fVar14 / fVar15) * ((float)iVar6 / (float)iVar7);
            fVar15 = fVar13 * fVar14;
            fVar14 = fVar14 * fVar16;
            lVar9 = Component.get_transform(cam,0);
            if (lVar9 != null) {
              puVar8 = (uint64 *)Transform.get_rotation(local_a8,lVar9,0);
              uVar1 = *puVar8;
              uVar2 = puVar8[1];
              puVar8 = (uint64 *)Transform.get_position(&local_b8,lVar9,0);
              local_f8 = CONCAT44(fVar16,fVar14);
              local_e0 = *(float *)(puVar8 + 1);
              uVar11 = *puVar8;
              local_c0 = *(float *)(puVar8 + 1);
              lVar9 = *(int64 *)(pStatics + 48);
              local_f0 = depth;
              local_e8 = uVar11;
              local_d8 = uVar1;
              uStack_d0 = uVar2;
              puVar8 = (uint64 *)Quaternion.op_Multiply(local_a8,&local_d8,&local_f8,0);
              local_b8 = *puVar8;
              local_f0 = *(float *)(puVar8 + 1);
              uStack_d0 = CONCAT44(uStack_d0._4_4_,local_f0);
              uStack_b0 = CONCAT44(uStack_b0._4_4_,local_f0);
              local_f0 = local_f0 + local_c0;
              local_f8 = CONCAT44((float)((uint64)local_b8 >> 32) +
                                  (float)((uint64)uVar11 >> 32),(float)uVar11 + (float)local_b8);
              local_c8 = uVar11;
              if (lVar9 != null) {
                if (*(int *)(lVar9 + 24) == 0) {
                  uVar11 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1800d65f0(uVar11,0);
                }
                *(uint64 *)(lVar9 + 32) = local_f8;
                *(float *)(lVar9 + 40) = local_f0;
                local_f8 = CONCAT44(fVar13,fVar14);
                lVar9 = *(int64 *)(pStatics + 48);
                local_f0 = depth;
                local_b8 = uVar1;
                uStack_b0 = uVar2;
                puVar8 = (uint64 *)Quaternion.op_Multiply(local_a8,&local_b8,&local_f8,0);
                fVar4 = local_e0;
                fVar14 = (float)local_e8;
                fVar3 = local_e8._4_4_;
                local_c8 = *puVar8;
                local_c0 = *(float *)(puVar8 + 1);
                uStack_b0 = CONCAT44((int)((uint64)uStack_b0 >> 32),local_c0);
                local_f0 = local_e0 + local_c0;
                local_f8 = CONCAT44(local_e8._4_4_ + (float)((uint64)local_c8 >> 32),
                                    (float)local_e8 + (float)local_c8);
                local_b8 = local_c8;
                if (lVar9 != null) {
                  if (*(uint32 *)(lVar9 + 24) < 2) {
                    uVar11 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                    FUN_1800d65f0(uVar11,0);
                  }
                  *(uint64 *)(lVar9 + 44) = local_f8;
                  *(float *)(lVar9 + 52) = local_f0;
                  local_e8 = CONCAT44(fVar13,fVar15);
                  lVar9 = *(int64 *)(pStatics + 48);
                  local_e0 = depth;
                  local_b8 = uVar1;
                  uStack_b0 = uVar2;
                  puVar8 = (uint64 *)Quaternion.op_Multiply(local_a8,&local_b8,&local_e8,0);
                  local_c8 = *puVar8;
                  local_c0 = *(float *)(puVar8 + 1);
                  local_e0 = fVar4 + local_c0;
                  uStack_b0 = CONCAT44((int)((uint64)uStack_b0 >> 32),local_c0);
                  local_e8 = CONCAT44(fVar3 + (float)((uint64)local_c8 >> 32),
                                      fVar14 + (float)local_c8);
                  local_b8 = local_c8;
                  if (lVar9 != null) {
                    if (*(uint32 *)(lVar9 + 24) < 3) {
                      uVar11 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                      FUN_1800d65f0(uVar11,0);
                    }
                    *(uint64 *)(lVar9 + 56) = local_e8;
                    *(float *)(lVar9 + 64) = local_e0;
                    local_e8 = CONCAT44(fVar16,fVar15);
                    lVar9 = *(int64 *)(pStatics + 48);
                    local_e0 = depth;
                    local_b8 = uVar1;
                    uStack_b0 = uVar2;
                    puVar8 = (uint64 *)Quaternion.op_Multiply(local_a8,&local_b8,&local_e8,0);
                    local_c8 = *puVar8;
                    local_c0 = *(float *)(puVar8 + 1);
                    local_e0 = fVar4 + local_c0;
                    local_e8 = CONCAT44(fVar3 + (float)((uint64)local_c8 >> 32),
                                        fVar14 + (float)local_c8);
                    if (lVar9 != null) {
                      if (*(uint32 *)(lVar9 + 24) < 4) {
                        uVar11 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                        FUN_1800d65f0(uVar11,0);
                      }
                      *(uint64 *)(lVar9 + 68) = local_e8;
                      *(float *)(lVar9 + 76) = local_e0;
                      goto LAB_181598fc0;
                    }
                  }
                }
              }
            }
          }
        }
    }

    // Token : 0x600040F
    // RVA   : 0x15988C0   Offset: 0x15970C0   Length: 0xA9
    public static Vector3[] GetWorldCorners(Camera cam, Transform relativeTo)
    {
        var pStatics = *(int64*)(DAT_181d66af0 + 184);
        ulong uVar1;
        ulong uVar2;
        float fVar3;
        float fVar4;
        bool cVar5;
        int iVar6;
        int iVar7;
        long lVar9;
        long lVar10;
        ulong uVar11;
        uint uVar12;
        float fVar13;
        float fVar14;
        float fVar15;
        float fVar16;
        ulong local_f8;
        float local_f0;
        ulong local_e8;
        float local_e0;
        ulong local_d8;
        ulong uStack_d0;
        ulong local_c8;
        float local_c0;
        ulong local_b8;
        ulong uStack_b0;
        byte[] local_a8 = new byte[16];
        ulong local_98;
        ulong uStack_90;
        local_98 = 0;
        uStack_90 = 0;
        if (cam != null) {
          cVar5 = Camera.get_orthographic(cam,0);
          if (!cVar5) {
            local_e8 = 0;
            lVar9 = *(int64 *)(pStatics + 48);
            local_e0 = relativeTo;
            puVar8 = (uint64 *)Camera.ViewportToWorldPoint(&local_b8,cam,&local_e8,0);
            if (lVar9 != null) {
              if (*(int *)(lVar9 + 24) == 0) {
                uVar11 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar11,0);
              }
              *(uint64 *)(lVar9 + 32) = *puVar8;
              *(uint32 *)(lVar9 + 40) = *(uint32 *)(puVar8 + 1);
              local_e8 = 0x3f80000000000000;
              lVar9 = *(int64 *)(pStatics + 48);
              local_e0 = relativeTo;
              puVar8 = (uint64 *)Camera.ViewportToWorldPoint(&local_b8,cam,&local_e8,0);
              if (lVar9 != null) {
                if (*(uint32 *)(lVar9 + 24) < 2) {
                  uVar11 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1800d65f0(uVar11,0);
                }
                *(uint64 *)(lVar9 + 44) = *puVar8;
                *(uint32 *)(lVar9 + 52) = *(uint32 *)(puVar8 + 1);
                local_e8 = 0x3f8000003f800000;
                lVar9 = *(int64 *)(pStatics + 48);
                local_e0 = relativeTo;
                puVar8 = (uint64 *)Camera.ViewportToWorldPoint(&local_b8,cam,&local_e8,0);
                if (lVar9 != null) {
                  if (*(uint32 *)(lVar9 + 24) < 3) {
                    uVar11 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                    FUN_1800d65f0(uVar11,0);
                  }
                  *(uint64 *)(lVar9 + 56) = *puVar8;
                  *(uint32 *)(lVar9 + 64) = *(uint32 *)(puVar8 + 1);
                  local_e8 = 0x3f800000;
                  lVar9 = *(int64 *)(pStatics + 48);
                  local_e0 = relativeTo;
                  puVar8 = (uint64 *)Camera.ViewportToWorldPoint(&local_b8,cam,&local_e8,0);
                  if (lVar9 != null) {
                    if (*(uint32 *)(lVar9 + 24) < 4) {
                      uVar11 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                      FUN_1800d65f0(uVar11,0);
                    }
                    *(uint64 *)(lVar9 + 68) = *puVar8;
                    *(uint32 *)(lVar9 + 76) = *(uint32 *)(puVar8 + 1);
        LAB_181598fc0:
                    cVar5 = Object.op_Inequality(param_3,0,0);
                    if (cVar5) {
                      uVar12 = 0;
                      do {
                        lVar9 = *(int64 *)(pStatics + 48);
                        if (lVar9 == null) throw; // [null/range check failed]
                        lVar10 = (int64)(int)uVar12;
                        if (*(uint32 *)(lVar9 + 24) <= uVar12) {
                          uVar11 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                          FUN_1800d65f0(uVar11,0);
                        }
                        if (param_3 == 0) throw; // [null/range check failed]
                        local_c8 = *(uint64 *)(lVar9 + 32 + lVar10 * 12);
                        local_c0 = *(float *)(lVar9 + 40 + lVar10 * 12);
                        puVar8 = (uint64 *)
                                 Transform.InverseTransformPoint(local_a8,param_3,&local_c8,0);
                        if (*(uint32 *)(lVar9 + 24) <= uVar12) {
                          uVar11 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                          FUN_1800d65f0(uVar11,0);
                        }
                        uVar12 = uVar12 + 1;
                        *(uint64 *)(lVar9 + 32 + lVar10 * 12) = *puVar8;
                        *(uint32 *)(lVar9 + 40 + lVar10 * 12) = *(uint32 *)(puVar8 + 1);
                      } while ((int)uVar12 < 4);
                    }
                    return *(uint64 *)(pStatics + 48);
                  }
                }
              }
            }
          }
          else {
            fVar13 = (float)Camera.get_orthographicSize(cam,0);
            fVar16 = -fVar13;
            puVar8 = (uint64 *)Camera.get_rect(local_a8,cam,0);
            local_98 = *puVar8;
            uStack_90 = puVar8[1];
            iVar6 = Screen.get_width(0);
            iVar7 = Screen.get_height(0);
            fVar14 = (float)FUN_180d90480(&local_98,0);
            fVar15 = (float)FUN_18044e2b0(&local_98,0);
            fVar14 = (fVar14 / fVar15) * ((float)iVar6 / (float)iVar7);
            fVar15 = fVar13 * fVar14;
            fVar14 = fVar14 * fVar16;
            lVar9 = Component.get_transform(cam,0);
            if (lVar9 != null) {
              puVar8 = (uint64 *)Transform.get_rotation(local_a8,lVar9,0);
              uVar1 = *puVar8;
              uVar2 = puVar8[1];
              puVar8 = (uint64 *)Transform.get_position(&local_b8,lVar9,0);
              local_f8 = CONCAT44(fVar16,fVar14);
              local_e0 = *(float *)(puVar8 + 1);
              uVar11 = *puVar8;
              local_c0 = *(float *)(puVar8 + 1);
              lVar9 = *(int64 *)(pStatics + 48);
              local_f0 = relativeTo;
              local_e8 = uVar11;
              local_d8 = uVar1;
              uStack_d0 = uVar2;
              puVar8 = (uint64 *)Quaternion.op_Multiply(local_a8,&local_d8,&local_f8,0);
              local_b8 = *puVar8;
              local_f0 = *(float *)(puVar8 + 1);
              uStack_d0 = CONCAT44(uStack_d0._4_4_,local_f0);
              uStack_b0 = CONCAT44(uStack_b0._4_4_,local_f0);
              local_f0 = local_f0 + local_c0;
              local_f8 = CONCAT44((float)((uint64)local_b8 >> 32) +
                                  (float)((uint64)uVar11 >> 32),(float)uVar11 + (float)local_b8);
              local_c8 = uVar11;
              if (lVar9 != null) {
                if (*(int *)(lVar9 + 24) == 0) {
                  uVar11 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1800d65f0(uVar11,0);
                }
                *(uint64 *)(lVar9 + 32) = local_f8;
                *(float *)(lVar9 + 40) = local_f0;
                local_f8 = CONCAT44(fVar13,fVar14);
                lVar9 = *(int64 *)(pStatics + 48);
                local_f0 = relativeTo;
                local_b8 = uVar1;
                uStack_b0 = uVar2;
                puVar8 = (uint64 *)Quaternion.op_Multiply(local_a8,&local_b8,&local_f8,0);
                fVar4 = local_e0;
                fVar14 = (float)local_e8;
                fVar3 = local_e8._4_4_;
                local_c8 = *puVar8;
                local_c0 = *(float *)(puVar8 + 1);
                uStack_b0 = CONCAT44((int)((uint64)uStack_b0 >> 32),local_c0);
                local_f0 = local_e0 + local_c0;
                local_f8 = CONCAT44(local_e8._4_4_ + (float)((uint64)local_c8 >> 32),
                                    (float)local_e8 + (float)local_c8);
                local_b8 = local_c8;
                if (lVar9 != null) {
                  if (*(uint32 *)(lVar9 + 24) < 2) {
                    uVar11 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                    FUN_1800d65f0(uVar11,0);
                  }
                  *(uint64 *)(lVar9 + 44) = local_f8;
                  *(float *)(lVar9 + 52) = local_f0;
                  local_e8 = CONCAT44(fVar13,fVar15);
                  lVar9 = *(int64 *)(pStatics + 48);
                  local_e0 = relativeTo;
                  local_b8 = uVar1;
                  uStack_b0 = uVar2;
                  puVar8 = (uint64 *)Quaternion.op_Multiply(local_a8,&local_b8,&local_e8,0);
                  local_c8 = *puVar8;
                  local_c0 = *(float *)(puVar8 + 1);
                  local_e0 = fVar4 + local_c0;
                  uStack_b0 = CONCAT44((int)((uint64)uStack_b0 >> 32),local_c0);
                  local_e8 = CONCAT44(fVar3 + (float)((uint64)local_c8 >> 32),
                                      fVar14 + (float)local_c8);
                  local_b8 = local_c8;
                  if (lVar9 != null) {
                    if (*(uint32 *)(lVar9 + 24) < 3) {
                      uVar11 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                      FUN_1800d65f0(uVar11,0);
                    }
                    *(uint64 *)(lVar9 + 56) = local_e8;
                    *(float *)(lVar9 + 64) = local_e0;
                    local_e8 = CONCAT44(fVar16,fVar15);
                    lVar9 = *(int64 *)(pStatics + 48);
                    local_e0 = relativeTo;
                    local_b8 = uVar1;
                    uStack_b0 = uVar2;
                    puVar8 = (uint64 *)Quaternion.op_Multiply(local_a8,&local_b8,&local_e8,0);
                    local_c8 = *puVar8;
                    local_c0 = *(float *)(puVar8 + 1);
                    local_e0 = fVar4 + local_c0;
                    local_e8 = CONCAT44(fVar3 + (float)((uint64)local_c8 >> 32),
                                        fVar14 + (float)local_c8);
                    if (lVar9 != null) {
                      if (*(uint32 *)(lVar9 + 24) < 4) {
                        uVar11 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                        FUN_1800d65f0(uVar11,0);
                      }
                      *(uint64 *)(lVar9 + 68) = local_e8;
                      *(float *)(lVar9 + 76) = local_e0;
                      goto LAB_181598fc0;
                    }
                  }
                }
              }
            }
          }
        }
    }

    // Token : 0x6000410
    // RVA   : 0x1598970   Offset: 0x1597170   Length: 0x872
    public static Vector3[] GetWorldCorners(Camera cam, float depth, Transform relativeTo)
    {
        var pStatics = *(int64*)(DAT_181d66af0 + 184);
        ulong uVar1;
        ulong uVar2;
        float fVar3;
        float fVar4;
        bool cVar5;
        int iVar6;
        int iVar7;
        long lVar9;
        long lVar10;
        ulong uVar11;
        uint uVar12;
        float fVar13;
        float fVar14;
        float fVar15;
        float fVar16;
        ulong local_f8;
        float local_f0;
        ulong local_e8;
        float local_e0;
        ulong local_d8;
        ulong uStack_d0;
        ulong local_c8;
        float local_c0;
        ulong local_b8;
        ulong uStack_b0;
        byte[] local_a8 = new byte[16];
        ulong local_98;
        ulong uStack_90;
        local_98 = 0;
        uStack_90 = 0;
        if (cam != null) {
          cVar5 = Camera.get_orthographic(cam,0);
          if (!cVar5) {
            local_e8 = 0;
            lVar9 = *(int64 *)(pStatics + 48);
            local_e0 = depth;
            puVar8 = (uint64 *)Camera.ViewportToWorldPoint(&local_b8,cam,&local_e8,0);
            if (lVar9 != null) {
              if (*(int *)(lVar9 + 24) == 0) {
                uVar11 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar11,0);
              }
              *(uint64 *)(lVar9 + 32) = *puVar8;
              *(uint32 *)(lVar9 + 40) = *(uint32 *)(puVar8 + 1);
              local_e8 = 0x3f80000000000000;
              lVar9 = *(int64 *)(pStatics + 48);
              local_e0 = depth;
              puVar8 = (uint64 *)Camera.ViewportToWorldPoint(&local_b8,cam,&local_e8,0);
              if (lVar9 != null) {
                if (*(uint32 *)(lVar9 + 24) < 2) {
                  uVar11 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1800d65f0(uVar11,0);
                }
                *(uint64 *)(lVar9 + 44) = *puVar8;
                *(uint32 *)(lVar9 + 52) = *(uint32 *)(puVar8 + 1);
                local_e8 = 0x3f8000003f800000;
                lVar9 = *(int64 *)(pStatics + 48);
                local_e0 = depth;
                puVar8 = (uint64 *)Camera.ViewportToWorldPoint(&local_b8,cam,&local_e8,0);
                if (lVar9 != null) {
                  if (*(uint32 *)(lVar9 + 24) < 3) {
                    uVar11 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                    FUN_1800d65f0(uVar11,0);
                  }
                  *(uint64 *)(lVar9 + 56) = *puVar8;
                  *(uint32 *)(lVar9 + 64) = *(uint32 *)(puVar8 + 1);
                  local_e8 = 0x3f800000;
                  lVar9 = *(int64 *)(pStatics + 48);
                  local_e0 = depth;
                  puVar8 = (uint64 *)Camera.ViewportToWorldPoint(&local_b8,cam,&local_e8,0);
                  if (lVar9 != null) {
                    if (*(uint32 *)(lVar9 + 24) < 4) {
                      uVar11 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                      FUN_1800d65f0(uVar11,0);
                    }
                    *(uint64 *)(lVar9 + 68) = *puVar8;
                    *(uint32 *)(lVar9 + 76) = *(uint32 *)(puVar8 + 1);
        LAB_181598fc0:
                    cVar5 = Object.op_Inequality(relativeTo,0,0);
                    if (cVar5) {
                      uVar12 = 0;
                      do {
                        lVar9 = *(int64 *)(pStatics + 48);
                        if (lVar9 == null) throw; // [null/range check failed]
                        lVar10 = (int64)(int)uVar12;
                        if (*(uint32 *)(lVar9 + 24) <= uVar12) {
                          uVar11 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                          FUN_1800d65f0(uVar11,0);
                        }
                        if (relativeTo == null) throw; // [null/range check failed]
                        local_c8 = *(uint64 *)(lVar9 + 32 + lVar10 * 12);
                        local_c0 = *(float *)(lVar9 + 40 + lVar10 * 12);
                        puVar8 = (uint64 *)
                                 Transform.InverseTransformPoint(local_a8,relativeTo,&local_c8,0);
                        if (*(uint32 *)(lVar9 + 24) <= uVar12) {
                          uVar11 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                          FUN_1800d65f0(uVar11,0);
                        }
                        uVar12 = uVar12 + 1;
                        *(uint64 *)(lVar9 + 32 + lVar10 * 12) = *puVar8;
                        *(uint32 *)(lVar9 + 40 + lVar10 * 12) = *(uint32 *)(puVar8 + 1);
                      } while ((int)uVar12 < 4);
                    }
                    return *(uint64 *)(pStatics + 48);
                  }
                }
              }
            }
          }
          else {
            fVar13 = (float)Camera.get_orthographicSize(cam,0);
            fVar16 = -fVar13;
            puVar8 = (uint64 *)Camera.get_rect(local_a8,cam,0);
            local_98 = *puVar8;
            uStack_90 = puVar8[1];
            iVar6 = Screen.get_width(0);
            iVar7 = Screen.get_height(0);
            fVar14 = (float)FUN_180d90480(&local_98,0);
            fVar15 = (float)FUN_18044e2b0(&local_98,0);
            fVar14 = (fVar14 / fVar15) * ((float)iVar6 / (float)iVar7);
            fVar15 = fVar13 * fVar14;
            fVar14 = fVar14 * fVar16;
            lVar9 = Component.get_transform(cam,0);
            if (lVar9 != null) {
              puVar8 = (uint64 *)Transform.get_rotation(local_a8,lVar9,0);
              uVar1 = *puVar8;
              uVar2 = puVar8[1];
              puVar8 = (uint64 *)Transform.get_position(&local_b8,lVar9,0);
              local_f8 = CONCAT44(fVar16,fVar14);
              local_e0 = *(float *)(puVar8 + 1);
              uVar11 = *puVar8;
              local_c0 = *(float *)(puVar8 + 1);
              lVar9 = *(int64 *)(pStatics + 48);
              local_f0 = depth;
              local_e8 = uVar11;
              local_d8 = uVar1;
              uStack_d0 = uVar2;
              puVar8 = (uint64 *)Quaternion.op_Multiply(local_a8,&local_d8,&local_f8,0);
              local_b8 = *puVar8;
              local_f0 = *(float *)(puVar8 + 1);
              uStack_d0 = CONCAT44(uStack_d0._4_4_,local_f0);
              uStack_b0 = CONCAT44(uStack_b0._4_4_,local_f0);
              local_f0 = local_f0 + local_c0;
              local_f8 = CONCAT44((float)((uint64)local_b8 >> 32) +
                                  (float)((uint64)uVar11 >> 32),(float)uVar11 + (float)local_b8);
              local_c8 = uVar11;
              if (lVar9 != null) {
                if (*(int *)(lVar9 + 24) == 0) {
                  uVar11 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1800d65f0(uVar11,0);
                }
                *(uint64 *)(lVar9 + 32) = local_f8;
                *(float *)(lVar9 + 40) = local_f0;
                local_f8 = CONCAT44(fVar13,fVar14);
                lVar9 = *(int64 *)(pStatics + 48);
                local_f0 = depth;
                local_b8 = uVar1;
                uStack_b0 = uVar2;
                puVar8 = (uint64 *)Quaternion.op_Multiply(local_a8,&local_b8,&local_f8,0);
                fVar4 = local_e0;
                fVar14 = (float)local_e8;
                fVar3 = local_e8._4_4_;
                local_c8 = *puVar8;
                local_c0 = *(float *)(puVar8 + 1);
                uStack_b0 = CONCAT44((int)((uint64)uStack_b0 >> 32),local_c0);
                local_f0 = local_e0 + local_c0;
                local_f8 = CONCAT44(local_e8._4_4_ + (float)((uint64)local_c8 >> 32),
                                    (float)local_e8 + (float)local_c8);
                local_b8 = local_c8;
                if (lVar9 != null) {
                  if (*(uint32 *)(lVar9 + 24) < 2) {
                    uVar11 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                    FUN_1800d65f0(uVar11,0);
                  }
                  *(uint64 *)(lVar9 + 44) = local_f8;
                  *(float *)(lVar9 + 52) = local_f0;
                  local_e8 = CONCAT44(fVar13,fVar15);
                  lVar9 = *(int64 *)(pStatics + 48);
                  local_e0 = depth;
                  local_b8 = uVar1;
                  uStack_b0 = uVar2;
                  puVar8 = (uint64 *)Quaternion.op_Multiply(local_a8,&local_b8,&local_e8,0);
                  local_c8 = *puVar8;
                  local_c0 = *(float *)(puVar8 + 1);
                  local_e0 = fVar4 + local_c0;
                  uStack_b0 = CONCAT44((int)((uint64)uStack_b0 >> 32),local_c0);
                  local_e8 = CONCAT44(fVar3 + (float)((uint64)local_c8 >> 32),
                                      fVar14 + (float)local_c8);
                  local_b8 = local_c8;
                  if (lVar9 != null) {
                    if (*(uint32 *)(lVar9 + 24) < 3) {
                      uVar11 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                      FUN_1800d65f0(uVar11,0);
                    }
                    *(uint64 *)(lVar9 + 56) = local_e8;
                    *(float *)(lVar9 + 64) = local_e0;
                    local_e8 = CONCAT44(fVar16,fVar15);
                    lVar9 = *(int64 *)(pStatics + 48);
                    local_e0 = depth;
                    local_b8 = uVar1;
                    uStack_b0 = uVar2;
                    puVar8 = (uint64 *)Quaternion.op_Multiply(local_a8,&local_b8,&local_e8,0);
                    local_c8 = *puVar8;
                    local_c0 = *(float *)(puVar8 + 1);
                    local_e0 = fVar4 + local_c0;
                    local_e8 = CONCAT44(fVar3 + (float)((uint64)local_c8 >> 32),
                                        fVar14 + (float)local_c8);
                    if (lVar9 != null) {
                      if (*(uint32 *)(lVar9 + 24) < 4) {
                        uVar11 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                        FUN_1800d65f0(uVar11,0);
                      }
                      *(uint64 *)(lVar9 + 68) = local_e8;
                      *(float *)(lVar9 + 76) = local_e0;
                      goto LAB_181598fc0;
                    }
                  }
                }
              }
            }
          }
        }
    }

    // Token : 0x6000411
    // RVA   : 0x15978D0   Offset: 0x15960D0   Length: 0xE7
    public static string GetFuncName(object obj, string method)
    {
        bool cVar1;
        int iVar2;
        long lVar4;
        if (obj == null) {
          return "<null>";
        }
        plVar3 = (int64 *)Object.GetType(obj,0);
        if (plVar3 != (int64 *)0) {
          lVar4 = (**(code **)(*plVar3 + 0x168))(plVar3,*(uint64 *)(*plVar3 + 0x170));
          if (lVar4 != null) {
            iVar2 = String.LastIndexOf(lVar4,47,0);
            if (0 < iVar2) {
              lVar4 = String.Substring(lVar4,iVar2 + 1,0);
            }
            cVar1 = FUN_180d6ca90(method,0);
            if (cVar1) {
              return lVar4;
            }
            lVar4 = String.Concat(lVar4,"/",method,0);
            return lVar4;
          }
        }
    }

    // Token : 0x6000412
    // RVA   : 0xDC41B0   Offset: 0xDC29B0   Length: 0xE3
    public static void Execute<T>(GameObject go, string funcName)
    {
        long lVar1;
        bool cVar2;
        long lVar3;
        long lVar4;
        ulong uVar5;
        uint uVar6;
        if (go != null) {
          lVar3 = (**(code **)**(uint64 **)(param_3 + 48))
                            (go,(uint64 *)**(uint64 **)(param_3 + 48));
          uVar6 = 0;
          if (lVar3 != null) {
            while( true ) {
              if ((int)*(uint32 *)(lVar3 + 24) <= (int)uVar6) {
                return;
              }
              if (*(uint32 *)(lVar3 + 24) <= uVar6) {
                uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar5,0);
              }
              lVar1 = lVar3[uVar6];
              if (lVar1 == null) break;
              lVar4 = Object.GetType(lVar1,0);
              if (lVar4 == null) break;
              lVar4 = Type.GetMethod(lVar4,funcName,52);
              cVar2 = MethodInfo.op_Inequality(lVar4,0,0);
              if (cVar2) {
                if (lVar4 == null) break;
                MethodBase.Invoke(lVar4,lVar1,0);
              }
              uVar6 = uVar6 + 1;
            }
          }
        }
    }

    // Token : 0x6000413
    // RVA   : 0xDC4090   Offset: 0xDC2890   Length: 0x115
    public static void ExecuteAll<T>(GameObject root, string funcName)
    {
        int iVar1;
        long lVar2;
        long lVar3;
        ulong uVar4;
        int iVar5;
        (**(code **)**(uint64 **)(param_3 + 48))
                  (root,funcName,(uint64 *)**(uint64 **)(param_3 + 48));
        if (root != null) {
          lVar2 = GameObject.get_transform(root,0);
          iVar5 = 0;
          if (lVar2 != null) {
            iVar1 = Transform.get_childCount(lVar2,0);
            if (0 < iVar1) {
              do {
                lVar3 = Transform.GetChild(lVar2,iVar5,0);
                if (lVar3 == null) throw; // [null/range check failed]
                uVar4 = Component.get_gameObject(lVar3,0);
                (*(code *)**(uint64 **)(*(int64 *)(param_3 + 48) + 8))(uVar4,funcName);
                iVar5 = iVar5 + 1;
              } while (iVar5 < iVar1);
            }
            return;
          }
        }
    }

    // Token : 0x6000414
    // RVA   : 0x15991F0   Offset: 0x15979F0   Length: 0xF2
    public static void ImmediatelyCreateDrawCalls(GameObject root)
    {
        NGUITools.ExecuteAll(root,"Start",DAT_181d66200);
        NGUITools.ExecuteAll(root,"Start",DAT_181d66180);
        NGUITools.ExecuteAll(root,"Update",DAT_181d66200);
        NGUITools.ExecuteAll(root,"Update",DAT_181d66180);
        NGUITools.ExecuteAll(root,"LateUpdate",DAT_181d66180);
    }

    // Token : 0x6000415
    // RVA   : 0x159E1E0   Offset: 0x159C9E0   Length: 0x3A
    public static Vector2 get_screenSize()
    {
        int iVar1;
        int iVar2;
        iVar1 = Screen.get_width(0);
        iVar2 = Screen.get_height(0);
        return CONCAT44((float)iVar2,(float)iVar1);
    }

    // Token : 0x6000416
    // RVA   : 0x15993C0   Offset: 0x1597BC0   Length: 0x728
    public static string KeyToCaption(KeyCode key)
    {
        switch(key) {
        case 0:
        case 1:
        case 2:
        case 3:
        case 4:
        case 5:
        case 6:
        case 7:
        case 10:
        case 11:
        case 14:
        case 15:
        case 16:
        case 17:
        case 18:
        case 20:
        case 21:
        case 22:
        case 23:
        case 24:
        case 25:
        case 26:
        case 28:
        case 29:
        case 30:
        case 31:
        case 37:
        case 65:
        case 66:
        case 67:
        case 68:
        case 69:
        case 70:
        case 71:
        case 72:
        case 73:
        case 74:
        case 75:
        case 76:
        case 77:
        case 78:
        case 79:
        case 80:
        case 81:
        case 82:
        case 83:
        case 84:
        case 85:
        case 86:
        case 87:
        case 88:
        case 89:
        case 90:
        case 123:
        case 124:
        case 125:
        case 126:
          goto switchD_181599aef_caseD_0;
        case 8:
          return "Backspace";
        case 9:
          return "Tab";
        case 12:
          return "Clear";
        case 13:
          return "Return";
        case 19:
          return "PS";
        case 27:
          return "Esc";
        case 32:
          return "Space";
        case 33:
          return "!";
        case 34:
          return "''";
        case 35:
          return "#";
        case 36:
          return "$";
        case 38:
          return "&";
        case 39:
          return "'";
        case 40:
          return "(";
        case 41:
          return ")";
        case 42:
          return "*";
        case 43:
          return "+";
        case 44:
          return ",";
        case 45:
          return "-";
        case 46:
          return ".";
        case 47:
          return "/";
        case 48:
          return "0";
        case 49:
          return "1";
        case 50:
          return "2";
        case 51:
          return "3";
        case 52:
          return "4";
        case 53:
          return "5";
        case 54:
          return "6";
        case 55:
          return "7";
        case 56:
          return "8";
        case 57:
          return "9";
        case 58:
          return ":";
        case 59:
          return ";";
        case 60:
          return "<";
        case 61:
          return "=";
        case 62:
          return ">";
        case 63:
          return "?";
        case 64:
          return "@";
        case 91:
          return "[";
        case 92:
          return "\\";
        case 93:
          return "]";
        case 94:
          return "^";
        case 95:
          return "_";
        case 96:
          return "`";
        case 97:
          return "A";
        case 98:
          return "B";
        case 99:
          return "C";
        case 100:
          return "D";
        case 101:
          return "E";
        case 102:
          return "F";
        case 103:
          return "G";
        case 104:
          return "H";
        case 105:
          return "I";
        case 106:
          return "J";
        case 107:
          return "K";
        case 108:
          return "L";
        case 109:
          return "M";
        case 110:
          return "N";
        case 111:
          return "O";
        case 112:
          return "P";
        case 113:
          return "Q";
        case 114:
          return "R";
        case 115:
          return "S";
        case 116:
          return "T";
        case 117:
          return "U";
        case 118:
          return "V";
        case 119:
          return "W";
        case 120:
          return "X";
        case 121:
          return "Y";
        case 122:
          return "Z";
        case 127:
          return "Del";
        default:
          switch(key) {
          case 0x100:
            return "K0";
          case 0x101:
            return "K1";
          case 0x102:
            return "K2";
          case 0x103:
            return "K3";
          case 0x104:
            return "K4";
          case 0x105:
            return "K5";
          case 0x106:
            return "K6";
          case 0x107:
            return "K7";
          case 0x108:
            return "K8";
          case 0x109:
            return "K9";
          case 0x10a:
            return "K.";
          case 0x10b:
            return "K/";
          case 0x10c:
            return "K*";
          case 0x10d:
            return "K-";
          case 0x10e:
            return "K+";
          case 0x10f:
            return "KE";
          case 0x110:
            return "KQ";
          case 0x111:
            return "UP";
          case 0x112:
            return "DN";
          case 0x113:
            return "LT";
          case 0x114:
            return "RT";
          case 0x115:
            return "Ins";
          case 0x116:
            return "Home";
          case 0x117:
            return "End";
          case 0x118:
            return "PU";
          case 0x119:
            return "PD";
          case 0x11a:
            return "F1";
          case 0x11b:
            return "F2";
          case 0x11c:
            return "F3";
          case 0x11d:
            return "F4";
          case 0x11e:
            return "F5";
          case 0x11f:
            return "F6";
          case 0x120:
            return "F7";
          case 0x121:
            return "F8";
          case 0x122:
            return "F9";
          case 0x123:
            return "F10";
          case 0x124:
            return "F11";
          case 0x125:
            return "F12";
          case 0x126:
            return "F13";
          case 0x127:
            return "F14";
          case 0x128:
            return "F15";
          case 300:
            return "Num";
          case 0x12d:
            return "Cap";
          case 0x12e:
            return "Scr";
          case 0x12f:
            return "RS";
          case 0x130:
            return "LS";
          case 0x131:
            return "RC";
          case 0x132:
            return "LC";
          case 0x133:
            return "RA";
          case 0x134:
            return "LA";
          case 0x143:
            return "M0";
          case 0x144:
            return "M1";
          case 0x145:
            return "M2";
          case 0x146:
            return "M3";
          case 0x147:
            return "M4";
          case 0x148:
            return "M5";
          case 0x149:
            return "M6";
          case 0x14a:
            return "(A)";
          case 0x14b:
            return "(B)";
          case 0x14c:
            return "(X)";
          case 0x14d:
            return "(Y)";
          case 0x14e:
            return "(RB)";
          case 0x14f:
            return "(LB)";
          case 0x150:
            return "(Back)";
          case 0x151:
            return "(Start)";
          case 0x152:
            return "(LS)";
          case 0x153:
            return "(RS)";
          case 0x154:
            return "J10";
          case 0x155:
            return "J11";
          case 0x156:
            return "J12";
          case 0x157:
            return "J13";
          case 0x158:
            return "J14";
          case 0x159:
            return "J15";
          case 0x15a:
            return "J16";
          case 0x15b:
            return "J17";
          case 0x15c:
            return "J18";
          case 0x15d:
            return "J19";
          }
        switchD_181599aef_caseD_0:
          return 0;
        }
    }

    // Token : 0x6000417
    // RVA   : 0x1593A10   Offset: 0x1592210   Length: 0x1C7B
    public static KeyCode CaptionToKey(string caption)
    {
        bool cVar1;
        cVar1 = FUN_180d6ca90(caption,0);
        if (cVar1) {
          return 0;
        }
        cVar1 = FUN_1816fd990(caption,"Backspace",0);
        if (cVar1) {
          return 8;
        }
        cVar1 = FUN_1816fd990(caption,"Tab",0);
        if (cVar1) {
          return 9;
        }
        cVar1 = FUN_1816fd990(caption,"Clear",0);
        if (cVar1) {
          return 12;
        }
        cVar1 = FUN_1816fd990(caption,"Return",0);
        if (cVar1) {
          return 13;
        }
        cVar1 = FUN_1816fd990(caption,"Pause",0);
        if (cVar1) {
          return 19;
        }
        cVar1 = FUN_1816fd990(caption,"Esc",0);
        if (cVar1) {
          return 27;
        }
        cVar1 = FUN_1816fd990(caption,"Space",0);
        if (cVar1) {
          return 32;
        }
        cVar1 = FUN_1816fd990(caption,"!",0);
        if (cVar1) {
          return 33;
        }
        cVar1 = FUN_1816fd990(caption,"''",0);
        if (cVar1) {
          return 34;
        }
        cVar1 = FUN_1816fd990(caption,"#",0);
        if (cVar1) {
          return 35;
        }
        cVar1 = FUN_1816fd990(caption,"$",0);
        if (cVar1) {
          return 36;
        }
        cVar1 = FUN_1816fd990(caption,"&",0);
        if (cVar1) {
          return 38;
        }
        cVar1 = FUN_1816fd990(caption,"'",0);
        if (cVar1) {
          return 39;
        }
        cVar1 = FUN_1816fd990(caption,"(",0);
        if (cVar1) {
          return 40;
        }
        cVar1 = FUN_1816fd990(caption,")",0);
        if (cVar1) {
          return 41;
        }
        cVar1 = FUN_1816fd990(caption,"*",0);
        if (cVar1) {
          return 42;
        }
        cVar1 = FUN_1816fd990(caption,"+",0);
        if (cVar1) {
          return 43;
        }
        cVar1 = FUN_1816fd990(caption,",",0);
        if (cVar1) {
          return 44;
        }
        cVar1 = FUN_1816fd990(caption,"-",0);
        if (cVar1) {
          return 45;
        }
        cVar1 = FUN_1816fd990(caption,".",0);
        if (cVar1) {
          return 46;
        }
        cVar1 = FUN_1816fd990(caption,"/",0);
        if (cVar1) {
          return 47;
        }
        cVar1 = FUN_1816fd990(caption,"0",0);
        if (cVar1) {
          return 48;
        }
        cVar1 = FUN_1816fd990(caption,"1",0);
        if (cVar1) {
          return 49;
        }
        cVar1 = FUN_1816fd990(caption,"2",0);
        if (cVar1) {
          return 50;
        }
        cVar1 = FUN_1816fd990(caption,"3",0);
        if (cVar1) {
          return 51;
        }
        cVar1 = FUN_1816fd990(caption,"4",0);
        if (cVar1) {
          return 52;
        }
        cVar1 = FUN_1816fd990(caption,"5",0);
        if (cVar1) {
          return 53;
        }
        cVar1 = FUN_1816fd990(caption,"6",0);
        if (cVar1) {
          return 54;
        }
        cVar1 = FUN_1816fd990(caption,"7",0);
        if (cVar1) {
          return 55;
        }
        cVar1 = FUN_1816fd990(caption,"8",0);
        if (cVar1) {
          return 56;
        }
        cVar1 = FUN_1816fd990(caption,"9",0);
        if (cVar1) {
          return 57;
        }
        cVar1 = FUN_1816fd990(caption,";//",0);
        if (cVar1) {
          return 58;
        }
        cVar1 = FUN_1816fd990(caption,";",0);
        if (cVar1) {
          return 59;
        }
        cVar1 = FUN_1816fd990(caption,"<",0);
        if (cVar1) {
          return 60;
        }
        cVar1 = FUN_1816fd990(caption,"=",0);
        if (cVar1) {
          return 61;
        }
        cVar1 = FUN_1816fd990(caption,">",0);
        if (cVar1) {
          return 62;
        }
        cVar1 = FUN_1816fd990(caption,"?",0);
        if (cVar1) {
          return 63;
        }
        cVar1 = FUN_1816fd990(caption,"@",0);
        if (cVar1) {
          return 64;
        }
        cVar1 = FUN_1816fd990(caption,"[",0);
        if (cVar1) {
          return 91;
        }
        cVar1 = FUN_1816fd990(caption,"\\",0);
        if (cVar1) {
          return 92;
        }
        cVar1 = FUN_1816fd990(caption,"]",0);
        if (cVar1) {
          return 93;
        }
        cVar1 = FUN_1816fd990(caption,"^",0);
        if (cVar1) {
          return 94;
        }
        cVar1 = FUN_1816fd990(caption,"_",0);
        if (cVar1) {
          return 95;
        }
        cVar1 = FUN_1816fd990(caption,"`",0);
        if (cVar1) {
          return 96;
        }
        cVar1 = FUN_1816fd990(caption,"A",0);
        if (cVar1) {
          return 97;
        }
        cVar1 = FUN_1816fd990(caption,"B",0);
        if (cVar1) {
          return 98;
        }
        cVar1 = FUN_1816fd990(caption,"C",0);
        if (cVar1) {
          return 99;
        }
        cVar1 = FUN_1816fd990(caption,"D",0);
        if (cVar1) {
          return 100;
        }
        cVar1 = FUN_1816fd990(caption,"E",0);
        if (cVar1) {
          return 101;
        }
        cVar1 = FUN_1816fd990(caption,"F",0);
        if (cVar1) {
          return 102;
        }
        cVar1 = FUN_1816fd990(caption,"G",0);
        if (cVar1) {
          return 103;
        }
        cVar1 = FUN_1816fd990(caption,"H",0);
        if (cVar1) {
          return 104;
        }
        cVar1 = FUN_1816fd990(caption,"I",0);
        if (cVar1) {
          return 105;
        }
        cVar1 = FUN_1816fd990(caption,"J",0);
        if (cVar1) {
          return 106;
        }
        cVar1 = FUN_1816fd990(caption,"K",0);
        if (cVar1) {
          return 107;
        }
        cVar1 = FUN_1816fd990(caption,"L",0);
        if (cVar1) {
          return 108;
        }
        cVar1 = FUN_1816fd990(caption,"M",0);
        if (cVar1) {
          return 109;
        }
        cVar1 = FUN_1816fd990(caption,"N",0);
        if (cVar1) {
          return 110;
        }
        cVar1 = FUN_1816fd990(caption,"O",0);
        if (cVar1) {
          return 111;
        }
        cVar1 = FUN_1816fd990(caption,"P",0);
        if (cVar1) {
          return 112;
        }
        cVar1 = FUN_1816fd990(caption,"Q",0);
        if (cVar1) {
          return 113;
        }
        cVar1 = FUN_1816fd990(caption,"R",0);
        if (cVar1) {
          return 114;
        }
        cVar1 = FUN_1816fd990(caption,"S",0);
        if (cVar1) {
          return 115;
        }
        cVar1 = FUN_1816fd990(caption,"T",0);
        if (cVar1) {
          return 116;
        }
        cVar1 = FUN_1816fd990(caption,"U",0);
        if (cVar1) {
          return 117;
        }
        cVar1 = FUN_1816fd990(caption,"V",0);
        if (cVar1) {
          return 118;
        }
        cVar1 = FUN_1816fd990(caption,"W",0);
        if (cVar1) {
          return 119;
        }
        cVar1 = FUN_1816fd990(caption,"X",0);
        if (cVar1) {
          return 120;
        }
        cVar1 = FUN_1816fd990(caption,"Y",0);
        if (cVar1) {
          return 121;
        }
        cVar1 = FUN_1816fd990(caption,"Z",0);
        if (cVar1) {
          return 122;
        }
        cVar1 = FUN_1816fd990(caption,"Del",0);
        if (cVar1) {
          return 127;
        }
        cVar1 = FUN_1816fd990(caption,"K0",0);
        if (cVar1) {
          return 0x100;
        }
        cVar1 = FUN_1816fd990(caption,"K1",0);
        if (cVar1) {
          return 0x101;
        }
        cVar1 = FUN_1816fd990(caption,"K2",0);
        if (cVar1) {
          return 0x102;
        }
        cVar1 = FUN_1816fd990(caption,"K3",0);
        if (cVar1) {
          return 0x103;
        }
        cVar1 = FUN_1816fd990(caption,"K4",0);
        if (cVar1) {
          return 0x104;
        }
        cVar1 = FUN_1816fd990(caption,"K5",0);
        if (cVar1) {
          return 0x105;
        }
        cVar1 = FUN_1816fd990(caption,"K6",0);
        if (cVar1) {
          return 0x106;
        }
        cVar1 = FUN_1816fd990(caption,"K7",0);
        if (cVar1) {
          return 0x107;
        }
        cVar1 = FUN_1816fd990(caption,"K8",0);
        if (cVar1) {
          return 0x108;
        }
        cVar1 = FUN_1816fd990(caption,"K9",0);
        if (cVar1) {
          return 0x109;
        }
        cVar1 = FUN_1816fd990(caption,"K.",0);
        if (cVar1) {
          return 0x10a;
        }
        cVar1 = FUN_1816fd990(caption,"K/",0);
        if (cVar1) {
          return 0x10b;
        }
        cVar1 = FUN_1816fd990(caption,"K*",0);
        if (cVar1) {
          return 0x10c;
        }
        cVar1 = FUN_1816fd990(caption,"K-",0);
        if (cVar1) {
          return 0x10d;
        }
        cVar1 = FUN_1816fd990(caption,"K+",0);
        if (cVar1) {
          return 0x10e;
        }
        cVar1 = FUN_1816fd990(caption,"KE",0);
        if (cVar1) {
          return 0x10f;
        }
        cVar1 = FUN_1816fd990(caption,"KQ",0);
        if (cVar1) {
          return 0x110;
        }
        cVar1 = FUN_1816fd990(caption,"UP",0);
        if (cVar1) {
          return 0x111;
        }
        cVar1 = FUN_1816fd990(caption,"DN",0);
        if (cVar1) {
          return 0x112;
        }
        cVar1 = FUN_1816fd990(caption,"LT",0);
        if (cVar1) {
          return 0x113;
        }
        cVar1 = FUN_1816fd990(caption,"RT",0);
        if (cVar1) {
          return 0x114;
        }
        cVar1 = FUN_1816fd990(caption,"Ins",0);
        if (cVar1) {
          return 0x115;
        }
        cVar1 = FUN_1816fd990(caption,"Home",0);
        if (cVar1) {
          return 0x116;
        }
        cVar1 = FUN_1816fd990(caption,"End",0);
        if (cVar1) {
          return 0x117;
        }
        cVar1 = FUN_1816fd990(caption,"PU",0);
        if (cVar1) {
          return 0x118;
        }
        cVar1 = FUN_1816fd990(caption,"PD",0);
        if (cVar1) {
          return 0x119;
        }
        cVar1 = FUN_1816fd990(caption,"F1",0);
        if (cVar1) {
          return 0x11a;
        }
        cVar1 = FUN_1816fd990(caption,"F2",0);
        if (cVar1) {
          return 0x11b;
        }
        cVar1 = FUN_1816fd990(caption,"F3",0);
        if (cVar1) {
          return 0x11c;
        }
        cVar1 = FUN_1816fd990(caption,"F4",0);
        if (cVar1) {
          return 0x11d;
        }
        cVar1 = FUN_1816fd990(caption,"F5",0);
        if (cVar1) {
          return 0x11e;
        }
        cVar1 = FUN_1816fd990(caption,"F6",0);
        if (cVar1) {
          return 0x11f;
        }
        cVar1 = FUN_1816fd990(caption,"F7",0);
        if (cVar1) {
          return 0x120;
        }
        cVar1 = FUN_1816fd990(caption,"F8",0);
        if (cVar1) {
          return 0x121;
        }
        cVar1 = FUN_1816fd990(caption,"F9",0);
        if (cVar1) {
          return 0x122;
        }
        cVar1 = FUN_1816fd990(caption,"F10",0);
        if (cVar1) {
          return 0x123;
        }
        cVar1 = FUN_1816fd990(caption,"F11",0);
        if (cVar1) {
          return 0x124;
        }
        cVar1 = FUN_1816fd990(caption,"F12",0);
        if (cVar1) {
          return 0x125;
        }
        cVar1 = FUN_1816fd990(caption,"F13",0);
        if (cVar1) {
          return 0x126;
        }
        cVar1 = FUN_1816fd990(caption,"F14",0);
        if (cVar1) {
          return 0x127;
        }
        cVar1 = FUN_1816fd990(caption,"F15",0);
        if (cVar1) {
          return 0x128;
        }
        cVar1 = FUN_1816fd990(caption,"Num",0);
        if (cVar1) {
          return 300;
        }
        cVar1 = FUN_1816fd990(caption,"Cap",0);
        if (cVar1) {
          return 0x12d;
        }
        cVar1 = FUN_1816fd990(caption,"Scr",0);
        if (cVar1) {
          return 0x12e;
        }
        cVar1 = FUN_1816fd990(caption,"RS",0);
        if (cVar1) {
          return 0x12f;
        }
        cVar1 = FUN_1816fd990(caption,"LS",0);
        if (cVar1) {
          return 0x130;
        }
        cVar1 = FUN_1816fd990(caption,"RC",0);
        if (cVar1) {
          return 0x131;
        }
        cVar1 = FUN_1816fd990(caption,"LC",0);
        if (cVar1) {
          return 0x132;
        }
        cVar1 = FUN_1816fd990(caption,"RA",0);
        if (cVar1) {
          return 0x133;
        }
        cVar1 = FUN_1816fd990(caption,"LA",0);
        if (cVar1) {
          return 0x134;
        }
        cVar1 = FUN_1816fd990(caption,"M0",0);
        if (cVar1) {
          return 0x143;
        }
        cVar1 = FUN_1816fd990(caption,"M1",0);
        if (cVar1) {
          return 0x144;
        }
        cVar1 = FUN_1816fd990(caption,"M2",0);
        if (cVar1) {
          return 0x145;
        }
        cVar1 = FUN_1816fd990(caption,"M3",0);
        if (cVar1) {
          return 0x146;
        }
        cVar1 = FUN_1816fd990(caption,"M4",0);
        if (!cVar1) {
          cVar1 = FUN_1816fd990(caption,"M5",0);
          if (cVar1) {
            return 0x148;
          }
          cVar1 = FUN_1816fd990(caption,"M6",0);
          if (cVar1) {
            return 0x149;
          }
          cVar1 = FUN_1816fd990(caption,"(A)",0);
          if (cVar1) {
            return 0x14a;
          }
          cVar1 = FUN_1816fd990(caption,"(B)",0);
          if (cVar1) {
            return 0x14b;
          }
          cVar1 = FUN_1816fd990(caption,"(X)",0);
          if (cVar1) {
            return 0x14c;
          }
          cVar1 = FUN_1816fd990(caption,"(Y)",0);
          if (cVar1) {
            return 0x14d;
          }
          cVar1 = FUN_1816fd990(caption,"(RB)",0);
          if (cVar1) {
            return 0x14e;
          }
          cVar1 = FUN_1816fd990(caption,"(LB)",0);
          if (cVar1) {
            return 0x14f;
          }
          cVar1 = FUN_1816fd990(caption,"(Back)",0);
          if (cVar1) {
            return 0x150;
          }
          cVar1 = FUN_1816fd990(caption,"(Start)",0);
          if (cVar1) {
            return 0x151;
          }
          cVar1 = FUN_1816fd990(caption,"(LS)",0);
          if (cVar1) {
            return 0x152;
          }
          cVar1 = FUN_1816fd990(caption,"(RS)",0);
          if (cVar1) {
            return 0x153;
          }
          cVar1 = FUN_1816fd990(caption,"J10",0);
          if (cVar1) {
            return 0x154;
          }
          cVar1 = FUN_1816fd990(caption,"J11",0);
          if (cVar1) {
            return 0x155;
          }
          cVar1 = FUN_1816fd990(caption,"J12",0);
          if (cVar1) {
            return 0x156;
          }
          cVar1 = FUN_1816fd990(caption,"J13",0);
          if (!cVar1) {
            cVar1 = FUN_1816fd990(caption,"J14",0);
            if (cVar1) {
              return 0x158;
            }
            cVar1 = FUN_1816fd990(caption,"J15",0);
            if (cVar1) {
              return 0x159;
            }
            cVar1 = FUN_1816fd990(caption,"J16",0);
            if (cVar1) {
              return 0x15a;
            }
            cVar1 = FUN_1816fd990(caption,"J17",0);
            if (!cVar1) {
              cVar1 = FUN_1816fd990(caption,"J18",0);
              if (!cVar1) {
                cVar1 = FUN_1816fd990(caption,"J19",0);
                return -(uint32)(cVar1) & 0x15d;
              }
              return 0x15c;
            }
            return 0x15b;
          }
          return 0x157;
        }
        return 0x147;
    }

    // Token : 0x6000418
    // RVA   : 0xDC3A40   Offset: 0xDC2240   Length: 0x648
    public static T Draw<T>(string id, OnInitFunc<T> onInit)
    {
        var pStatics_6af0 = *(int64*)(DAT_181d66af0 + 184);
        var pStatics_af58 = *(int64*)(DAT_181d8af58 + 184);
        long lVar1;
        bool cVar2;
        uint uVar3;
        ulong uVar4;
        ulong uVar5;
        long lVar6;
        ulong uVar7;
        ulong uVar8;
        ulong uVar9;
        long local_res8;
        long local_res10;
        local_res10 = onInit;
        uVar4 = 0;
        local_res8 = 0;
        lVar6 = *(int64 *)(pStatics_6af0 + 64);
        if (lVar6 == null) throw; // [null/range check failed]
        cVar2 = FUN_1808addd0(lVar6,id,&local_res8,DAT_181d501d8);
        lVar6 = local_res8;
        if (cVar2) {
          cVar2 = Object.op_Implicit(lVar6,0);
          lVar6 = local_res8;
          if (cVar2) {
            lVar1 = **(int64 **)(param_3 + 48);
            if ((*(byte *)(lVar1 + 0x132) & 1) == 0) {
              FUN_18009a510(lVar1);
            }
            if (lVar6 == null) {
              return 0;
            }
            uVar4 = il2cpp_internal(lVar6,lVar1);
            if (uVar4 != 0) {
              return uVar4;
            }
                          // WARNING: Subroutine does not return
            FUN_1800d6070(lVar6,lVar1);
          }
        }
        uVar8 = *(uint64 *)(pStatics_6af0 + 72);
        cVar2 = Object.op_Equality(uVar8,0,0);
        uVar9 = uVar4;
        if (cVar2) {
          while( true ) {
            if (*pStatics_af58 == 0) throw; // [null/range check failed]
            uVar5 = uVar4;
            uVar7 = uVar4;
            if (*(int *)(*pStatics_af58 + 24) <= (int)uVar9) break;
            if (*pStatics_af58 == 0) throw; // [null/range check failed]
            uVar5 = FUN_180002f80(*pStatics_af58,uVar9,DAT_181d82d78);
            cVar2 = Object.op_Implicit(uVar5,0);
            if (cVar2) {
              if ((uVar5 == 0) || (lVar6 = Component.get_gameObject(uVar5,0)) == null)
              throw; // [null/range check failed]
              uVar3 = GameObject.get_layer(lVar6,0);
              uVar7 = UICamera.FindCameraForLayer(uVar3,0);
              cVar2 = Object.op_Implicit(uVar7,0);
              if (cVar2) {
                if ((uVar7 == 0) || (lVar6 = UICamera.get_cachedCamera(uVar7,0)) == null)
                throw; // [null/range check failed]
                cVar2 = Camera.get_orthographic(lVar6,0);
                if (cVar2) break;
              }
            }
            uVar9 = (uint64)((int)uVar9 + 1);
          }
          cVar2 = Object.op_Equality(uVar7,0,0);
          if (!cVar2) {
            if (uVar5 == 0) throw; // [null/range check failed]
            uVar8 = Component.get_gameObject(uVar5,0);
            uVar8 = NGUITools.AddChild(uVar8,DAT_181d65e80);
          }
          else {
            uVar3 = LayerMask.NameToLayer("UI",0);
            uVar8 = NGUITools.CreateUI(0,uVar3,0);
          }
          *(uint64 *)(pStatics_6af0 + 72) = uVar8;
          lVar6 = *(int64 *)(pStatics_6af0 + 72);
          if (lVar6 == null) throw; // [null/range check failed]
          UIPanel.set_depth(lVar6,100000,0);
          lVar6 = *(int64 *)(pStatics_6af0 + 72);
          if (lVar6 == null) throw; // [null/range check failed]
          uVar8 = Component.get_gameObject(lVar6,0);
          puVar10 = (uint64 *)(pStatics_6af0 + 80);
          *puVar10 = uVar8;
          il2cpp_internal(puVar10,uVar8);
          lVar6 = *(int64 *)(pStatics_6af0 + 80);
          if (lVar6 == null) throw; // [null/range check failed]
          Object.set_name(lVar6,"Immediate Mode GUI",0);
          onInit = local_res10;
        }
        puVar10 = *(uint64 **)(*(int64 *)(param_3 + 48) + 8);
        local_res8 = (*(code *)*puVar10)(*(uint64 *)(pStatics_6af0 + 80),
                                         0x7fffffff,puVar10);
        if (local_res8 != 0) {
          Object.set_name(local_res8,id,0);
          lVar6 = *(int64 *)(pStatics_6af0 + 64);
          if (lVar6 != null) {
            FUN_1808aec90(lVar6,id,local_res8,DAT_181d50258);
            lVar6 = local_res8;
            if (onInit != null) {
              lVar1 = **(int64 **)(param_3 + 48);
              if ((*(byte *)(lVar1 + 0x132) & 1) == 0) {
                FUN_18009a510(lVar1);
              }
              uVar9 = uVar4;
              if ((lVar6 != null) && (uVar9 = il2cpp_internal(lVar6,lVar1)) == null) {
                          // WARNING: Subroutine does not return
                FUN_1800d6070(lVar6,lVar1);
              }
              puVar10 = *(uint64 **)(*(int64 *)(param_3 + 48) + 16);
              (*(code *)*puVar10)(onInit,uVar9,puVar10);
            }
            lVar1 = local_res8;
            lVar6 = **(int64 **)(param_3 + 48);
            if ((*(byte *)(lVar6 + 0x132) & 1) == 0) {
              FUN_18009a510(lVar6);
            }
            if ((lVar1 != null) && (uVar4 = il2cpp_internal(lVar1,lVar6)) == null) {
                          // WARNING: Subroutine does not return
              FUN_1800d6070(lVar1,lVar6);
            }
            return uVar4;
          }
        }
    }

    // Token : 0x6000419
    // RVA   : 0x1597640   Offset: 0x1595E40   Length: 0x174
    public static Color GammaToLinearSpace(Color c)
    {
        var pStatics = *(int64*)(DAT_181d66af0 + 184);
        ulong uVar1;
        uint uVar2;
        uint uVar3;
        uint uVar4;
        uint uVar5;
        if (*(int *)(pStatics + 88) == -1) {
          uVar2 = QualitySettings.get_activeColorSpace(0);
          *(uint32 *)(pStatics + 88) = uVar2;
        }
        if (*(int *)(pStatics + 88) != 1) {
          uVar1 = param_2[1];
          *c = *param_2;
          c[1] = uVar1;
          return c;
        }
        uVar2 = Mathf.GammaToLinearSpace(*(uint32 *)param_2,0);
        uVar3 = Mathf.GammaToLinearSpace(*(uint32 *)((int64)param_2 + 4),0);
        uVar4 = Mathf.GammaToLinearSpace(*(uint32 *)(param_2 + 1),0);
        uVar5 = Mathf.GammaToLinearSpace(*(uint32 *)((int64)param_2 + 12),0);
        *c = 0;
        c[1] = 0;
        FUN_1809981e0(c,uVar2,uVar3,uVar4,uVar5,0);
        return c;
    }

    // Token : 0x600041A
    // RVA   : 0x159A5C0   Offset: 0x1598DC0   Length: 0x174
    public static Color LinearToGammaSpace(Color c)
    {
        var pStatics = *(int64*)(DAT_181d66af0 + 184);
        ulong uVar1;
        uint uVar2;
        uint uVar3;
        uint uVar4;
        uint uVar5;
        if (*(int *)(pStatics + 88) == -1) {
          uVar2 = QualitySettings.get_activeColorSpace(0);
          *(uint32 *)(pStatics + 88) = uVar2;
        }
        if (*(int *)(pStatics + 88) != 1) {
          uVar1 = param_2[1];
          *c = *param_2;
          c[1] = uVar1;
          return c;
        }
        uVar2 = Mathf.LinearToGammaSpace(*(uint32 *)param_2,0);
        uVar3 = Mathf.LinearToGammaSpace(*(uint32 *)((int64)param_2 + 4),0);
        uVar4 = Mathf.LinearToGammaSpace(*(uint32 *)(param_2 + 1),0);
        uVar5 = Mathf.LinearToGammaSpace(*(uint32 *)((int64)param_2 + 12),0);
        *c = 0;
        c[1] = 0;
        FUN_1809981e0(c,uVar2,uVar3,uVar4,uVar5,0);
        return c;
    }

    // Token : 0x600041B
    // RVA   : 0x1595690   Offset: 0x1593E90   Length: 0x91
    public static bool CheckIfRelated(INGUIAtlas a, INGUIAtlas b)
    {
        ulong uVar1;
        bool cVar2;
        byte uVar3;
        long lVar4;
        if ((a == null) || (b == null)) {
          return false;
        }
        cVar2 = FUN_180002970(28,DAT_181d556d0,a);
        if ((cVar2) && (cVar2 = FUN_180002970(28,DAT_181d556d0,b), cVar2)) {
          lVar4 = FUN_180002970(29,DAT_181d556d0,a);
          if ((lVar4 != null) && (lVar4 = Font.get_fontNames(lVar4,0)) != null) {
            if (*(int *)(lVar4 + 24) == 0) {
              uVar1 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar1,0);
            }
            uVar1 = *(uint64 *)(lVar4 + 32);
            lVar4 = FUN_180002970(29,DAT_181d556d0,b);
            if ((lVar4 != null) && (lVar4 = Font.get_fontNames(lVar4,0)) != null) {
              if (*(int *)(lVar4 + 24) == 0) {
                uVar1 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar1,0);
              }
              cVar2 = FUN_1816fd990(uVar1,*(uint64 *)(lVar4 + 32),0);
              if (cVar2) {
                return true;
              }
              goto LAB_181595848;
            }
          }
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
        LAB_181595848:
        if ((a != b) &&
           (cVar2 = FUN_180002aa0(33,DAT_181d556d0,a,b), !cVar2)) {
          uVar3 = FUN_180002aa0(33,DAT_181d556d0,b,a);
          return uVar3;
        }
        return true;
    }

    // Token : 0x600041C
    // RVA   : 0x159BBE0   Offset: 0x159A3E0   Length: 0x29B
    public static void Replace(INGUIAtlas before, INGUIAtlas after)
    {
        int iVar1;
        long lVar2;
        long lVar3;
        long lVar4;
        ulong uVar5;
        uint uVar6;
        uint uVar7;
        lVar3 = NGUITools.FindActive(DAT_181d66500);
        uVar7 = 0;
        uVar6 = 0;
        if (lVar3 != null) {
          iVar1 = *(int *)(lVar3 + 24);
          if (0 < iVar1) {
            do {
              if (*(uint32 *)(lVar3 + 24) <= uVar6) {
                uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar5,0);
              }
              lVar2 = lVar3[uVar6];
              if (lVar2 == null) throw; // [null/range check failed]
              lVar4 = UISprite.get_atlas(lVar2);
              if (lVar4 == before) {
                UISprite.set_atlas(lVar2,after,0);
              }
              uVar6 = uVar6 + 1;
            } while ((int)uVar6 < iVar1);
          }
          lVar3 = Resources.FindObjectsOfTypeAll(DAT_181d76fe0);
          uVar6 = 0;
          if (lVar3 != null) {
            iVar1 = *(int *)(lVar3 + 24);
            if (0 < iVar1) {
              do {
                if (*(uint32 *)(lVar3 + 24) <= uVar6) {
                  uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1800d65f0(uVar5,0);
                }
                lVar2 = lVar3[uVar6];
                if (lVar2 == null) throw; // [null/range check failed]
                lVar4 = UIFont.get_atlas(lVar2);
                if (lVar4 == before) {
                  UIFont.set_atlas(lVar2,after,0);
                }
                uVar6 = uVar6 + 1;
              } while ((int)uVar6 < iVar1);
            }
            lVar3 = Resources.FindObjectsOfTypeAll(DAT_181d76f60);
            uVar6 = 0;
            if (lVar3 != null) {
              iVar1 = *(int *)(lVar3 + 24);
              if (0 < iVar1) {
                do {
                  if (*(uint32 *)(lVar3 + 24) <= uVar6) {
                    uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                    FUN_1800d65f0(uVar5,0);
                  }
                  lVar2 = lVar3[uVar6];
                  if (lVar2 == null) throw; // [null/range check failed]
                  lVar4 = NGUIFont.get_atlas(lVar2);
                  if (lVar4 == before) {
                    NGUIFont.set_atlas(lVar2,after,0);
                  }
                  uVar6 = uVar6 + 1;
                } while ((int)uVar6 < iVar1);
              }
              lVar3 = NGUITools.FindActive(DAT_181d66400);
              if (lVar3 != null) {
                iVar1 = *(int *)(lVar3 + 24);
                if (0 < iVar1) {
                  do {
                    if (*(uint32 *)(lVar3 + 24) <= uVar7) {
                      uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                      FUN_1800d65f0(uVar5,0);
                    }
                    lVar2 = lVar3[uVar7];
                    if (lVar2 == null) throw; // [null/range check failed]
                    lVar4 = UILabel.get_bitmapFont(lVar2);
                    if ((lVar4 != null) && (lVar4 = UILabel.get_atlas(lVar2), lVar4 == before)) {
                      UILabel.set_atlas(lVar2,after,0);
                    }
                    uVar7 = uVar7 + 1;
                  } while ((int)uVar7 < iVar1);
                }
                return;
              }
            }
          }
        }
    }

    // Token : 0x600041D
    // RVA   : 0x1595730   Offset: 0x1593F30   Length: 0x190
    public static bool CheckIfRelated(INGUIFont a, INGUIFont b)
    {
        ulong uVar1;
        bool cVar2;
        byte uVar3;
        long lVar4;
        if ((a == null) || (b == null)) {
          return false;
        }
        cVar2 = FUN_180002970(28,DAT_181d556d0,a);
        if ((cVar2) && (cVar2 = FUN_180002970(28,DAT_181d556d0,b), cVar2)) {
          lVar4 = FUN_180002970(29,DAT_181d556d0,a);
          if ((lVar4 != null) && (lVar4 = Font.get_fontNames(lVar4,0)) != null) {
            if (*(int *)(lVar4 + 24) == 0) {
              uVar1 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar1,0);
            }
            uVar1 = *(uint64 *)(lVar4 + 32);
            lVar4 = FUN_180002970(29,DAT_181d556d0,b);
            if ((lVar4 != null) && (lVar4 = Font.get_fontNames(lVar4,0)) != null) {
              if (*(int *)(lVar4 + 24) == 0) {
                uVar1 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar1,0);
              }
              cVar2 = FUN_1816fd990(uVar1,*(uint64 *)(lVar4 + 32),0);
              if (cVar2) {
                return true;
              }
              goto LAB_181595848;
            }
          }
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
        LAB_181595848:
        if ((a != b) &&
           (cVar2 = FUN_180002aa0(33,DAT_181d556d0,a,b), !cVar2)) {
          uVar3 = FUN_180002aa0(33,DAT_181d556d0,b,a);
          return uVar3;
        }
        return true;
    }

    // Token : 0x600041E
    // RVA   : 0x159DFA0   Offset: 0x159C7A0   Length: 0x1B4
    private static void /*cctor*/()
    {
        var pStatics = *(int64*)(DAT_181d66af0 + 184);
        ulong uVar1;
        *(uint8 *)(pStatics + 16) = 0;
        *(uint32 *)(pStatics + 20) = 0x3f800000;
        *(uint32 *)(pStatics + 24) = 0;
        uVar1 = il2cpp_internal(DAT_181d5f4c8);
        FUN_1808ae540(uVar1,DAT_181d53150);
        puVar2 = (uint64 *)(pStatics + 40);
        *puVar2 = uVar1;
        il2cpp_internal(puVar2,uVar1);
        uVar1 = FUN_1800d60b0(DAT_181d81c40,4);
        puVar2 = (uint64 *)(pStatics + 48);
        *puVar2 = uVar1;
        il2cpp_internal(puVar2,uVar1);
        uVar1 = FUN_1800d60b0(DAT_181d7eb00,145);
        RuntimeHelpers.InitializeArray(uVar1,DAT_181d91cf8,0);
        puVar2 = (uint64 *)(pStatics + 56);
        *puVar2 = uVar1;
        il2cpp_internal(puVar2,uVar1);
        uVar1 = il2cpp_internal(DAT_181d5e9c8);
        FUN_1808ae540(uVar1,DAT_181d50158);
        puVar2 = (uint64 *)(pStatics + 64);
        *puVar2 = uVar1;
        il2cpp_internal(puVar2,uVar1);
        *(uint32 *)(pStatics + 88) = 0xffffffff;
    }

}
