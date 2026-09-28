// ============================================================
// Type  : NGUIDebug
// Token : 0x2000085
// ============================================================

public class NGUIDebug
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x400032C
    private static bool mRayDebug;

    // Token: 0x400032D
    private static List<string> mLines;

    // Token: 0x400032E
    private static NGUIDebug mInstance;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000362
    // RVA   : 0xDF76C0   Offset: 0xDF6AC0   Length: 0x57
    public static bool get_debugRaycast()
    {
        return **(uint8 **)(DAT_181d8bc10 + 184);
    }

    // Token : 0x6000363
    // RVA   : 0xDF7720   Offset: 0xDF6B20   Length: 0x95
    public static void set_debugRaycast(bool value)
    {
        bool cVar1;
        **(char **)(DAT_181d8bc10 + 184) = value;
        if (value) {
          cVar1 = Application.get_isPlaying(0);
          if (cVar1) {
            NGUIDebug.CreateInstance(0);
            return;
          }
        }
    }

    // Token : 0x6000364
    // RVA   : 0xDF6340   Offset: 0xDF5740   Length: 0x171
    public static void CreateInstance()
    {
        var pStatics = *(int64*)(DAT_181d8bc10 + 184);
        bool cVar1;
        long lVar2;
        ulong uVar3;
        uVar3 = *(uint64 *)(pStatics + 16);
        cVar1 = Object.op_Equality(uVar3,0,0);
        if (cVar1) {
          lVar2 = new GameObject("_NGUI Debug",0);
          if (lVar2 != null) {
            uVar3 = GameObject.AddComponent(lVar2,DAT_181dc5758);
            puVar4 = (uint64 *)(pStatics + 16);
            *puVar4 = uVar3;
            il2cpp_internal(puVar4,uVar3);
            Object.DontDestroyOnLoad(lVar2,0);
            return;
          }
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
    }

    // Token : 0x6000365
    // RVA   : 0xDF67B0   Offset: 0xDF5BB0   Length: 0x15D
    private static void LogString(string text)
    {
        var pStatics = *(int64*)(DAT_181d8bc10 + 184);
        long lVar1;
        bool cVar2;
        cVar2 = Application.get_isPlaying(0);
        if (!cVar2) {
          Debug.Log(text,0);
          return;
        }
        lVar1 = *(int64 *)(pStatics + 8);
        if (lVar1 != null) {
          if (20 < *(int *)(lVar1 + 24)) {
            lVar1 = *(int64 *)(pStatics + 8);
            if (lVar1 == null) throw; // [null/range check failed]
            FUN_181823590(lVar1,0,DAT_181da4158);
          }
          lVar1 = *(int64 *)(pStatics + 8);
          if (lVar1 != null) {
            FUN_18181e0a0(lVar1,text,DAT_181da3d58);
            NGUIDebug.CreateInstance(0);
            return;
          }
        }
    }

    // Token : 0x6000366
    // RVA   : 0xDF6A30   Offset: 0xDF5E30   Length: 0x14D
    public static void Log(object[] objs)
    {
        bool cVar1;
        long lVar2;
        ulong uVar3;
        uint uVar4;
        cVar1 = FUN_180d755b0(objs,0);
        if (!cVar1) {
          lVar2 = FUN_1800d60b0(DAT_181da1040,1);
          if (lVar2 != null) {
            if (*(int *)(lVar2 + 24) == 0) {
              uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar3,0);
            }
            *(uint16 *)(lVar2 + 32) = 10;
            if (objs != null) {
              lVar2 = String.Split(objs,lVar2,0);
              uVar4 = 0;
              if (lVar2 != null) {
                while( true ) {
                  if ((int)*(uint32 *)(lVar2 + 24) <= (int)uVar4) {
                    return;
                  }
                  if (*(uint32 *)(lVar2 + 24) <= uVar4) break;
                  uVar3 = lVar2[uVar4];
                  NGUIDebug.LogString(uVar3,0);
                  uVar4 = uVar4 + 1;
                }
                uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar3,0);
              }
            }
          }
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
    }

    // Token : 0x6000367
    // RVA   : 0xDF6910   Offset: 0xDF5D10   Length: 0x116
    public static void Log(string s)
    {
        bool cVar1;
        long lVar2;
        ulong uVar3;
        uint uVar4;
        cVar1 = FUN_180d755b0(s,0);
        if (!cVar1) {
          lVar2 = FUN_1800d60b0(DAT_181da1040,1);
          if (lVar2 != null) {
            if (*(int *)(lVar2 + 24) == 0) {
              uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar3,0);
            }
            *(uint16 *)(lVar2 + 32) = 10;
            if (s != null) {
              lVar2 = String.Split(s,lVar2,0);
              uVar4 = 0;
              if (lVar2 != null) {
                while( true ) {
                  if ((int)*(uint32 *)(lVar2 + 24) <= (int)uVar4) {
                    return;
                  }
                  if (*(uint32 *)(lVar2 + 24) <= uVar4) break;
                  uVar3 = lVar2[uVar4];
                  NGUIDebug.LogString(uVar3,0);
                  uVar4 = uVar4 + 1;
                }
                uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar3,0);
              }
            }
          }
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
    }

    // Token : 0x6000368
    // RVA   : 0xDF62C0   Offset: 0xDF56C0   Length: 0x79
    public static void Clear()
    {
        long lVar1;
        lVar1 = *(int64 *)(*(int64 *)(DAT_181d8bc10 + 184) + 8);
        if (lVar1 != null) {
          FUN_1812f9a10(lVar1,DAT_181da3dd8);
          return;
        }
    }

    // Token : 0x6000369
    // RVA   : 0xDF64C0   Offset: 0xDF58C0   Length: 0x2E8
    public static void DrawBounds(Bounds b)
    {
        ulong uVar1;
        uint uVar2;
        float fVar4;
        float fVar5;
        float fVar6;
        float fVar7;
        ulong local_a8;
        uint local_a0;
        ulong local_98;
        uint local_90;
        ulong local_88;
        uint local_80;
        ulong local_78;
        ulong uStack_70;
        puVar3 = (uint64 *)FUN_18045e0a0(&local_88,b,0);
        local_a8 = *puVar3;
        local_a0 = *(uint32 *)(puVar3 + 1);
        puVar3 = (uint64 *)FUN_18045e0a0(&local_88,b,0);
        uVar1 = *puVar3;
        local_80 = *(uint32 *)(puVar3 + 1);
        puVar3 = (uint64 *)FUN_18045e080(&local_98,b,0);
        local_88 = *puVar3;
        local_80 = *(uint32 *)(puVar3 + 1);
        fVar6 = (float)uVar1 - (float)local_88;
        fVar4 = (float)((uint64)uVar1 >> 32) - (float)((uint64)local_88 >> 32);
        puVar3 = (uint64 *)FUN_18045e0a0(&local_88,b,0);
        uVar1 = *puVar3;
        local_80 = *(uint32 *)(puVar3 + 1);
        puVar3 = (uint64 *)FUN_18045e080(&local_98,b,0);
        uVar2 = local_a0;
        local_88 = *puVar3;
        local_80 = *(uint32 *)(puVar3 + 1);
        fVar7 = (float)uVar1 + (float)local_88;
        fVar5 = (float)((uint64)uVar1 >> 32) + (float)((uint64)local_88 >> 32);
        local_90 = local_a0;
        local_98 = CONCAT44(fVar4,fVar6);
        local_a8 = CONCAT44(fVar4,fVar7);
        puVar3 = (uint64 *)Color.get_red(&local_78,0);
        local_78 = *puVar3;
        uStack_70 = puVar3[1];
        local_88 = local_a8;
        local_80 = local_a0;
        local_a8 = local_98;
        local_a0 = local_90;
        Debug.DrawLine(&local_a8,&local_88,&local_78,0);
        local_90 = uVar2;
        local_a0 = uVar2;
        puVar3 = (uint64 *)Color.get_red(&local_78,0);
        local_88 = CONCAT44(fVar5,fVar6);
        local_78 = *puVar3;
        uStack_70 = puVar3[1];
        local_80 = local_90;
        local_98 = CONCAT44(fVar4,fVar6);
        local_90 = local_a0;
        Debug.DrawLine(&local_98,&local_88,&local_78,0);
        local_90 = uVar2;
        local_a0 = uVar2;
        puVar3 = (uint64 *)Color.get_red(&local_78,0);
        local_88 = CONCAT44(fVar5,fVar7);
        local_78 = *puVar3;
        uStack_70 = puVar3[1];
        local_80 = local_90;
        local_98 = CONCAT44(fVar4,fVar7);
        local_90 = local_a0;
        Debug.DrawLine(&local_98,&local_88,&local_78,0);
        local_90 = uVar2;
        local_a0 = uVar2;
        puVar3 = (uint64 *)Color.get_red(&local_78,0);
        local_88 = CONCAT44(fVar5,fVar7);
        local_78 = *puVar3;
        uStack_70 = puVar3[1];
        local_80 = local_90;
        local_98 = CONCAT44(fVar5,fVar6);
        local_90 = local_a0;
        Debug.DrawLine(&local_98,&local_88,&local_78,0);
    }

    // Token : 0x600036A
    // RVA   : 0xDF6B80   Offset: 0xDF5F80   Length: 0xA84
    private void OnGUI()
    {
        var pStatics = *(int64*)(DAT_181d8bc10 + 184);
        int iVar1;
        ulong uVar2;
        bool cVar3;
        ulong uVar5;
        long lVar8;
        ulong uVar9;
        int iVar10;
        float fVar11;
        uint[] local_res18 = new uint[2];
        uint[] local_res20 = new uint[2];
        ulong local_88;
        ulong uStack_80;
        ulong local_78;
        ulong uStack_70;
        byte[] local_68 = new byte[16];
        byte[] local_58 = new byte[64];
        iVar10 = 0;
        local_88 = 0;
        uStack_80 = 0;
        local_res18[0] = 0;
        local_res20[0] = 0;
        FUN_1809dc910(&local_88,0x40a00000,0x40a00000,0x447a0000,0x41b00000,0);
        if (**(char **)(DAT_181d8bc10 + 184) != false) {
          local_res18[0] = UICamera.get_currentScheme(0);
          plVar4 = (int64 *)il2cpp_value_box(DAT_181d8d2b8,local_res18);
          if (plVar4 == (int64 *)0) throw; // [null/range check failed]
          uVar5 = (**(code **)(*plVar4 + 0x168))(plVar4,*(uint64 *)(*plVar4 + 0x170));
          puVar6 = (uint32 *)il2cpp_object_unbox(plVar4);
          local_res18[0] = *puVar6;
          uVar5 = String.Concat("Scheme: ",uVar5,0);
          puVar7 = (uint64 *)Color.get_black(&local_78,0);
          local_78 = *puVar7;
          uStack_70 = puVar7[1];
          GUI.set_color(&local_78,0);
          local_78 = local_88;
          uStack_70 = uStack_80;
          GUI.Label(&local_78,uVar5,0);
          fVar11 = (float)FUN_18044df60(&local_88,0);
          FUN_18044f4b0(&local_88,fVar11 - 1.0,0);
          fVar11 = (float)FUN_180d98fc0(&local_88,0);
          FUN_18044f4c0(&local_88,fVar11 - 1.0,0);
          puVar7 = (uint64 *)FUN_1810d3570(&local_78,0);
          local_78 = *puVar7;
          uStack_70 = puVar7[1];
          GUI.set_color(&local_78,0);
          local_78 = local_88;
          uStack_70 = uStack_80;
          GUI.Label(&local_78,uVar5,0);
          fVar11 = (float)FUN_18044df60(&local_88,0);
          FUN_18044f4b0(&local_88,fVar11 + 18.0,0);
          fVar11 = (float)FUN_180d98fc0(&local_88,0);
          FUN_18044f4c0(&local_88,fVar11 + 1.0,0);
          uVar5 = UICamera.get_hoveredObject(0);
          lVar8 = NGUITools.GetHierarchy(uVar5,0);
          if (lVar8 == null) throw; // [null/range check failed]
          uVar5 = String.Replace(lVar8,"\"","",0);
          uVar5 = String.Concat("Hover: ",uVar5,0);
          puVar7 = (uint64 *)Color.get_black(&local_78,0);
          local_78 = *puVar7;
          uStack_70 = puVar7[1];
          GUI.set_color(&local_78,0);
          local_78 = local_88;
          uStack_70 = uStack_80;
          GUI.Label(&local_78,uVar5,0);
          fVar11 = (float)FUN_18044df60(&local_88,0);
          FUN_18044f4b0(&local_88,fVar11 - 1.0,0);
          fVar11 = (float)FUN_180d98fc0(&local_88,0);
          FUN_18044f4c0(&local_88,fVar11 - 1.0,0);
          puVar7 = (uint64 *)FUN_1810d3570(&local_78,0);
          local_78 = *puVar7;
          uStack_70 = puVar7[1];
          GUI.set_color(&local_78,0);
          local_78 = local_88;
          uStack_70 = uStack_80;
          GUI.Label(&local_78,uVar5,0);
          fVar11 = (float)FUN_18044df60(&local_88,0);
          FUN_18044f4b0(&local_88,fVar11 + 18.0,0);
          fVar11 = (float)FUN_180d98fc0(&local_88,0);
          FUN_18044f4c0(&local_88,fVar11 + 1.0,0);
          uVar5 = UICamera.get_selectedObject(0);
          lVar8 = NGUITools.GetHierarchy(uVar5,0);
          if (lVar8 == null) throw; // [null/range check failed]
          uVar5 = String.Replace(lVar8,"\"","",0);
          uVar5 = String.Concat("Selection: ",uVar5,0);
          puVar7 = (uint64 *)Color.get_black(&local_78,0);
          local_78 = *puVar7;
          uStack_70 = puVar7[1];
          GUI.set_color(&local_78,0);
          local_78 = local_88;
          uStack_70 = uStack_80;
          GUI.Label(&local_78,uVar5,0);
          fVar11 = (float)FUN_18044df60(&local_88,0);
          FUN_18044f4b0(&local_88,fVar11 - 1.0,0);
          fVar11 = (float)FUN_180d98fc0(&local_88,0);
          FUN_18044f4c0(&local_88,fVar11 - 1.0,0);
          puVar7 = (uint64 *)FUN_1810d3570(&local_78,0);
          local_78 = *puVar7;
          uStack_70 = puVar7[1];
          GUI.set_color(&local_78,0);
          local_78 = local_88;
          uStack_70 = uStack_80;
          GUI.Label(&local_78,uVar5,0);
          fVar11 = (float)FUN_18044df60(&local_88,0);
          FUN_18044f4b0(&local_88,fVar11 + 18.0,0);
          fVar11 = (float)FUN_180d98fc0(&local_88,0);
          FUN_18044f4c0(&local_88,fVar11 + 1.0,0);
          uVar5 = UICamera.get_controllerNavigationObject(0);
          lVar8 = NGUITools.GetHierarchy(uVar5,0);
          if (lVar8 == null) throw; // [null/range check failed]
          uVar5 = String.Replace(lVar8,"\"","",0);
          uVar5 = String.Concat("Controller: ",uVar5,0);
          puVar7 = (uint64 *)Color.get_black(&local_78,0);
          local_78 = *puVar7;
          uStack_70 = puVar7[1];
          GUI.set_color(&local_78,0);
          local_78 = local_88;
          uStack_70 = uStack_80;
          GUI.Label(&local_78,uVar5,0);
          fVar11 = (float)FUN_18044df60(&local_88,0);
          FUN_18044f4b0(&local_88,fVar11 - 1.0,0);
          fVar11 = (float)FUN_180d98fc0(&local_88,0);
          FUN_18044f4c0(&local_88,fVar11 - 1.0,0);
          puVar7 = (uint64 *)FUN_1810d3570(&local_78,0);
          local_78 = *puVar7;
          uStack_70 = puVar7[1];
          GUI.set_color(&local_78,0);
          local_78 = local_88;
          uStack_70 = uStack_80;
          GUI.Label(&local_78,uVar5,0);
          fVar11 = (float)FUN_18044df60(&local_88,0);
          FUN_18044f4b0(&local_88,fVar11 + 18.0,0);
          fVar11 = (float)FUN_180d98fc0(&local_88,0);
          FUN_18044f4c0(&local_88,fVar11 + 1.0,0);
          local_res20[0] = UICamera.CountInputSources(0);
          uVar5 = Int32.ToString(local_res20,0);
          uVar5 = String.Concat("Active events: ",uVar5,0);
          cVar3 = UICamera.get_disableController(0);
          if (cVar3) {
            uVar5 = String.Concat(uVar5,", disabled controller",0);
          }
          if (*(char *)(*(int64 *)(DAT_181daf678 + 184) + 90) != false) {
            uVar5 = String.Concat(uVar5,", ignore controller",0);
          }
          cVar3 = UICamera.get_inputHasFocus(0);
          if (cVar3) {
            uVar5 = String.Concat(uVar5,", input focus",0);
          }
          puVar7 = (uint64 *)Color.get_black(&local_78,0);
          uVar2 = *puVar7;
          uVar9 = puVar7[1];
          local_78 = uVar2;
          uStack_70 = uVar9;
          GUI.set_color(&local_78,0);
          local_78 = local_88;
          uStack_70 = uStack_80;
          GUI.Label(&local_78,uVar5,0);
          fVar11 = (float)FUN_18044df60(&local_88,0);
          FUN_18044f4b0(&local_88,fVar11 - 1.0,0);
          fVar11 = (float)FUN_180d98fc0(&local_88,0);
          FUN_18044f4c0(&local_88,fVar11 - 1.0,0);
          puVar7 = (uint64 *)FUN_1810d3570(&local_78,0);
          local_78 = *puVar7;
          uStack_70 = puVar7[1];
          GUI.set_color(&local_78,0);
          local_78 = local_88;
          uStack_70 = uStack_80;
          GUI.Label(&local_78,uVar5,0);
          fVar11 = (float)FUN_18044df60(&local_88,0);
          FUN_18044f4b0(&local_88,fVar11 + 18.0,0);
          fVar11 = (float)FUN_180d98fc0(&local_88,0);
          FUN_18044f4c0(&local_88,fVar11 + 1.0,0);
        }
        lVar8 = *(int64 *)(pStatics + 8);
        if (lVar8 != null) {
          iVar1 = *(int *)(lVar8 + 24);
          if (0 < iVar1) {
            do {
              puVar7 = (uint64 *)Color.get_black(local_68,0);
              uVar5 = *puVar7;
              uVar2 = puVar7[1];
              local_78 = uVar5;
              uStack_70 = uVar2;
              GUI.set_color(&local_78,0);
              uVar2 = uStack_80;
              uVar5 = local_88;
              lVar8 = *(int64 *)(pStatics + 8);
              if (lVar8 == null) throw; // [null/range check failed]
              uVar9 = FUN_180002f80(lVar8,iVar10,DAT_181da4358);
              local_78 = uVar5;
              uStack_70 = uVar2;
              GUI.Label(&local_78,uVar9,0);
              fVar11 = (float)FUN_18044df60(&local_88,0);
              FUN_18044f4b0(&local_88,fVar11 - 1.0,0);
              fVar11 = (float)FUN_180d98fc0(&local_88,0);
              FUN_18044f4c0(&local_88,fVar11 - 1.0,0);
              puVar7 = (uint64 *)FUN_1810d3570(local_58,0);
              local_78 = *puVar7;
              uStack_70 = puVar7[1];
              GUI.set_color(&local_78,0);
              uVar2 = uStack_80;
              uVar5 = local_88;
              lVar8 = *(int64 *)(pStatics + 8);
              if (lVar8 == null) throw; // [null/range check failed]
              uVar9 = FUN_180002f80(lVar8,iVar10,DAT_181da4358);
              local_78 = uVar5;
              uStack_70 = uVar2;
              GUI.Label(&local_78,uVar9,0);
              fVar11 = (float)FUN_18044df60(&local_88);
              FUN_18044f4b0(&local_88,fVar11 + 18.0,0);
              fVar11 = (float)FUN_180d98fc0(&local_88);
              FUN_18044f4c0(&local_88,fVar11 + 1.0,0);
              iVar10 = iVar10 + 1;
            } while (iVar10 < iVar1);
          }
          return;
        }
    }

    // Token : 0x600036B
    // RVA   : 0x3A17B0   Offset: 0x3A0BB0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_18044ef50(this,0);
    }

    // Token : 0x600036C
    // RVA   : 0xDF7610   Offset: 0xDF6A10   Length: 0xAB
    private static void /*cctor*/()
    {
        var pStatics = *(int64*)(DAT_181d8bc10 + 184);
        ulong uVar1;
        **(uint8 **)(DAT_181d8bc10 + 184) = 0;
        uVar1 = il2cpp_internal(DAT_181d97750);
        FUN_18132faf0(uVar1,DAT_181da3bd8);
        puVar2 = (uint64 *)(pStatics + 8);
        *puVar2 = uVar1;
        il2cpp_internal(puVar2,uVar1);
        puVar2 = (uint64 *)(pStatics + 16);
        *puVar2 = 0;
        il2cpp_internal(puVar2,0);
    }

}
