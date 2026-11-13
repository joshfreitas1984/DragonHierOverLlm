// ============================================================
// Type  : NGUIDebug
// Token : 0x2000084
// ============================================================

public class NGUIDebug
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x400030C
    private static bool mRayDebug;

    // Token: 0x400030D
    private static List<string> mLines;

    // Token: 0x400030E
    private static NGUIDebug mInstance;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000349
    // RVA   : 0x854560   Offset: 0x853360   Length: 0x57
    public static bool get_debugRaycast()
    {
        return **(uint8 **)(DAT_181e6bfe8 + 184);
    }

    // Token : 0x600034A
    // RVA   : 0x8545C0   Offset: 0x8533C0   Length: 0x95
    public static void set_debugRaycast(bool value)
    {
        bool cVar1;
        **(char **)(DAT_181e6bfe8 + 184) = value;
        if (value) {
          cVar1 = Application.get_isPlaying(0);
          if (cVar1) {
            NGUIDebug.CreateInstance(0);
            return;
          }
        }
    }

    // Token : 0x600034B
    // RVA   : 0x8531E0   Offset: 0x851FE0   Length: 0x171
    public static void CreateInstance()
    {
        bool cVar1;
        long lVar2;
        ulong uVar3;
        uVar3 = NGUIDebug.mInstance;
        cVar1 = Object.op_Equality(uVar3,0,0);
        if (cVar1) {
          lVar2 = new GameObject("_NGUI Debug",0);
          if (lVar2 != null) {
            uVar3 = GameObject.AddComponent(lVar2,DAT_181e51808);
            NGUIDebug.mInstance = uVar3;
            Object.DontDestroyOnLoad(lVar2,0);
            return;
          }
                          // WARNING: Subroutine does not return
          FUN_1801e0300();
        }
    }

    // Token : 0x600034C
    // RVA   : 0x853650   Offset: 0x852450   Length: 0x15D
    private static void LogString(string text)
    {
        long lVar1;
        bool cVar2;
        cVar2 = Application.get_isPlaying(0);
        if (!cVar2) {
          Debug.Log(text,0);
          return;
        }
        lVar1 = NGUIDebug.mLines;
        if (lVar1 != null) {
          if (20 < *(int *)(lVar1 + 24)) {
            lVar1 = NGUIDebug.mLines;
            if (lVar1 == null) throw; // [null/range check failed]
            FUN_181763390(lVar1,0,DAT_181e86770);
          }
          lVar1 = NGUIDebug.mLines;
          if (lVar1 != null) {
            FUN_18175de30(lVar1,text,DAT_181e86370);
            NGUIDebug.CreateInstance(0);
            return;
          }
        }
    }

    // Token : 0x600034D
    // RVA   : 0x8538D0   Offset: 0x8526D0   Length: 0x14D
    public static void Log(object[] objs)
    {
        bool cVar1;
        long lVar2;
        ulong uVar3;
        uint uVar4;
        cVar1 = FUN_180ad1200(objs,0);
        if (!cVar1) {
          lVar2 = FUN_1801dfd90(DAT_181e81128,1);
          if (lVar2 != null) {
            if (*(int *)(lVar2 + 24) == 0) {
              uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1801e02d0(uVar3,0);
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
                FUN_1801e02d0(uVar3,0);
              }
            }
          }
                          // WARNING: Subroutine does not return
          FUN_1801e0300();
        }
    }

    // Token : 0x600034E
    // RVA   : 0x8537B0   Offset: 0x8525B0   Length: 0x116
    public static void Log(string s)
    {
        bool cVar1;
        long lVar2;
        ulong uVar3;
        uint uVar4;
        cVar1 = FUN_180ad1200(s,0);
        if (!cVar1) {
          lVar2 = FUN_1801dfd90(DAT_181e81128,1);
          if (lVar2 != null) {
            if (*(int *)(lVar2 + 24) == 0) {
              uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1801e02d0(uVar3,0);
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
                FUN_1801e02d0(uVar3,0);
              }
            }
          }
                          // WARNING: Subroutine does not return
          FUN_1801e0300();
        }
    }

    // Token : 0x600034F
    // RVA   : 0x853160   Offset: 0x851F60   Length: 0x79
    public static void Clear()
    {
        long lVar1;
        lVar1 = *(int64 *)(*(int64 *)(DAT_181e6bfe8 + 184) + 8);
        if (lVar1 != null) {
          FUN_18115d8f0(lVar1,DAT_181e863f0);
          return;
        }
    }

    // Token : 0x6000350
    // RVA   : 0x853360   Offset: 0x852160   Length: 0x2E8
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
        puVar3 = (uint64 *)FUN_180af1d30(&local_88,b,0);
        local_a8 = *puVar3;
        local_a0 = *(uint32 *)(puVar3 + 1);
        puVar3 = (uint64 *)FUN_180af1d30(&local_88,b,0);
        uVar1 = *puVar3;
        local_80 = *(uint32 *)(puVar3 + 1);
        puVar3 = (uint64 *)FUN_180af1d10(&local_98,b,0);
        local_88 = *puVar3;
        local_80 = *(uint32 *)(puVar3 + 1);
        fVar6 = (float)uVar1 - (float)local_88;
        fVar4 = (float)((uint64)uVar1 >> 32) - (float)((uint64)local_88 >> 32);
        puVar3 = (uint64 *)FUN_180af1d30(&local_88,b,0);
        uVar1 = *puVar3;
        local_80 = *(uint32 *)(puVar3 + 1);
        puVar3 = (uint64 *)FUN_180af1d10(&local_98,b,0);
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

    // Token : 0x6000351
    // RVA   : 0x853A20   Offset: 0x852820   Length: 0xA84
    private void OnGUI()
    {
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
        FUN_1807282e0(&local_88,0x40a00000,0x40a00000,0x447a0000,0x41b00000,0);
        if (**(char **)(DAT_181e6bfe8 + 184) != false) {
          local_res18[0] = UICamera.get_currentScheme(0);
          plVar4 = (int64 *)il2cpp_value_box(DAT_181e6da90,local_res18);
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
          fVar11 = (float)FUN_180af4e80(&local_88,0);
          FUN_180728510(&local_88,fVar11 - 1.0,0);
          fVar11 = (float)FUN_180af4e60(&local_88,0);
          FUN_180728500(&local_88,fVar11 - 1.0,0);
          puVar7 = (uint64 *)FUN_180f24d00(&local_78,0);
          local_78 = *puVar7;
          uStack_70 = puVar7[1];
          GUI.set_color(&local_78,0);
          local_78 = local_88;
          uStack_70 = uStack_80;
          GUI.Label(&local_78,uVar5,0);
          fVar11 = (float)FUN_180af4e80(&local_88,0);
          FUN_180728510(&local_88,fVar11 + 18.0,0);
          fVar11 = (float)FUN_180af4e60(&local_88,0);
          FUN_180728500(&local_88,fVar11 + 1.0,0);
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
          fVar11 = (float)FUN_180af4e80(&local_88,0);
          FUN_180728510(&local_88,fVar11 - 1.0,0);
          fVar11 = (float)FUN_180af4e60(&local_88,0);
          FUN_180728500(&local_88,fVar11 - 1.0,0);
          puVar7 = (uint64 *)FUN_180f24d00(&local_78,0);
          local_78 = *puVar7;
          uStack_70 = puVar7[1];
          GUI.set_color(&local_78,0);
          local_78 = local_88;
          uStack_70 = uStack_80;
          GUI.Label(&local_78,uVar5,0);
          fVar11 = (float)FUN_180af4e80(&local_88,0);
          FUN_180728510(&local_88,fVar11 + 18.0,0);
          fVar11 = (float)FUN_180af4e60(&local_88,0);
          FUN_180728500(&local_88,fVar11 + 1.0,0);
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
          fVar11 = (float)FUN_180af4e80(&local_88,0);
          FUN_180728510(&local_88,fVar11 - 1.0,0);
          fVar11 = (float)FUN_180af4e60(&local_88,0);
          FUN_180728500(&local_88,fVar11 - 1.0,0);
          puVar7 = (uint64 *)FUN_180f24d00(&local_78,0);
          local_78 = *puVar7;
          uStack_70 = puVar7[1];
          GUI.set_color(&local_78,0);
          local_78 = local_88;
          uStack_70 = uStack_80;
          GUI.Label(&local_78,uVar5,0);
          fVar11 = (float)FUN_180af4e80(&local_88,0);
          FUN_180728510(&local_88,fVar11 + 18.0,0);
          fVar11 = (float)FUN_180af4e60(&local_88,0);
          FUN_180728500(&local_88,fVar11 + 1.0,0);
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
          fVar11 = (float)FUN_180af4e80(&local_88,0);
          FUN_180728510(&local_88,fVar11 - 1.0,0);
          fVar11 = (float)FUN_180af4e60(&local_88,0);
          FUN_180728500(&local_88,fVar11 - 1.0,0);
          puVar7 = (uint64 *)FUN_180f24d00(&local_78,0);
          local_78 = *puVar7;
          uStack_70 = puVar7[1];
          GUI.set_color(&local_78,0);
          local_78 = local_88;
          uStack_70 = uStack_80;
          GUI.Label(&local_78,uVar5,0);
          fVar11 = (float)FUN_180af4e80(&local_88,0);
          FUN_180728510(&local_88,fVar11 + 18.0,0);
          fVar11 = (float)FUN_180af4e60(&local_88,0);
          FUN_180728500(&local_88,fVar11 + 1.0,0);
          local_res20[0] = UICamera.CountInputSources(0);
          uVar5 = Int32.ToString(local_res20,0);
          uVar5 = String.Concat("Active events: ",uVar5,0);
          cVar3 = UICamera.get_disableController(0);
          if (cVar3) {
            uVar5 = String.Concat(uVar5,", disabled controller",0);
          }
          if (*(char *)(*(int64 *)(DAT_181e8fad0 + 184) + 90) != false) {
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
          fVar11 = (float)FUN_180af4e80(&local_88,0);
          FUN_180728510(&local_88,fVar11 - 1.0,0);
          fVar11 = (float)FUN_180af4e60(&local_88,0);
          FUN_180728500(&local_88,fVar11 - 1.0,0);
          puVar7 = (uint64 *)FUN_180f24d00(&local_78,0);
          local_78 = *puVar7;
          uStack_70 = puVar7[1];
          GUI.set_color(&local_78,0);
          local_78 = local_88;
          uStack_70 = uStack_80;
          GUI.Label(&local_78,uVar5,0);
          fVar11 = (float)FUN_180af4e80(&local_88,0);
          FUN_180728510(&local_88,fVar11 + 18.0,0);
          fVar11 = (float)FUN_180af4e60(&local_88,0);
          FUN_180728500(&local_88,fVar11 + 1.0,0);
        }
        lVar8 = NGUIDebug.mLines;
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
              lVar8 = NGUIDebug.mLines;
              if (lVar8 == null) throw; // [null/range check failed]
              uVar9 = FUN_1800024b0(lVar8,iVar10,DAT_181e86970);
              local_78 = uVar5;
              uStack_70 = uVar2;
              GUI.Label(&local_78,uVar9,0);
              fVar11 = (float)FUN_180af4e80(&local_88,0);
              FUN_180728510(&local_88,fVar11 - 1.0,0);
              fVar11 = (float)FUN_180af4e60(&local_88,0);
              FUN_180728500(&local_88,fVar11 - 1.0,0);
              puVar7 = (uint64 *)FUN_180f24d00(local_58,0);
              local_78 = *puVar7;
              uStack_70 = puVar7[1];
              GUI.set_color(&local_78,0);
              uVar2 = uStack_80;
              uVar5 = local_88;
              lVar8 = NGUIDebug.mLines;
              if (lVar8 == null) throw; // [null/range check failed]
              uVar9 = FUN_1800024b0(lVar8,iVar10,DAT_181e86970);
              local_78 = uVar5;
              uStack_70 = uVar2;
              GUI.Label(&local_78,uVar9,0);
              fVar11 = (float)FUN_180af4e80(&local_88);
              FUN_180728510(&local_88,fVar11 + 18.0,0);
              fVar11 = (float)FUN_180af4e60(&local_88);
              FUN_180728500(&local_88,fVar11 + 1.0,0);
              iVar10 = iVar10 + 1;
            } while (iVar10 < iVar1);
          }
          return;
        }
    }

    // Token : 0x6000352
    // RVA   : 0x2110A0   Offset: 0x20FEA0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_180ae8740(this,0);
    }

    // Token : 0x6000353
    // RVA   : 0x8544B0   Offset: 0x8532B0   Length: 0xAB
    private static void /*cctor*/()
    {
        ulong uVar1;
        **(uint8 **)(DAT_181e6bfe8 + 184) = 0;
        uVar1 = il2cpp_internal(DAT_181e77728);
        FUN_1810f3480(uVar1,DAT_181e861f0);
        NGUIDebug.mLines = uVar1;
        NGUIDebug.mInstance = 0;
    }

}
