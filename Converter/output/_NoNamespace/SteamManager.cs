// ============================================================
// Type  : SteamManager
// Token : 0x2000380
// ============================================================

public class SteamManager
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001CD6
    protected static bool s_EverInitialized;

    // Token: 0x4001CD7
    protected static SteamManager s_instance;

    // Token: 0x4001CD8
    protected bool m_bInitialized;

    // Token: 0x4001CD9
    protected SteamAPIWarningMessageHook_t m_SteamAPIWarningMessageHook;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60022A1
    // RVA   : 0xA16200   Offset: 0xA15000   Length: 0x12C
    protected static SteamManager get_Instance()
    {
        bool cVar1;
        long lVar2;
        ulong uVar3;
        uVar3 = SteamManager.s_instance;
        cVar1 = Object.op_Equality(uVar3,0,0);
        if (!cVar1) {
          return SteamManager.s_instance;
        }
        lVar2 = new GameObject("SteamManager",0);
        if (lVar2 != null) {
          uVar3 = GameObject.AddComponent(lVar2,DAT_181e523b8);
          return uVar3;
        }
    }

    // Token : 0x60022A2
    // RVA   : 0xA16080   Offset: 0xA14E80   Length: 0x176
    public static bool get_Initialized()
    {
        ulong uVar1;
        bool cVar2;
        long lVar3;
        uVar1 = SteamManager.s_instance;
        cVar2 = Object.op_Equality(uVar1,0,0);
        if (!cVar2) {
          lVar3 = SteamManager.s_instance;
        }
        else {
          lVar3 = new GameObject("SteamManager",0);
          if (lVar3 == null) throw; // [null/range check failed]
          lVar3 = GameObject.AddComponent(lVar3,DAT_181e523b8);
        }
        if (lVar3 != null) {
          return lVar3.m_bInitialized;
        }
    }

    // Token : 0x60022A3
    // RVA   : 0xA16010   Offset: 0xA14E10   Length: 0x52
    protected static void SteamAPIDebugTextHook(int nSeverity, StringBuilder pchDebugText)
    {
        Debug.LogWarning(pchDebugText,0);
    }

    // Token : 0x60022A4
    // RVA   : 0xA15D40   Offset: 0xA14B40   Length: 0x76
    private static void InitOnPlayMode()
    {
        **(uint8 **)(DAT_181e87268 + 184) = 0;
        puVar1 = (uint64 *)(*(int64 *)(DAT_181e87268 + 184) + 8);
        *puVar1 = 0;
        il2cpp_internal(puVar1,0);
    }

    // Token : 0x60022A5
    // RVA   : 0xA158B0   Offset: 0xA146B0   Length: 0x48D
    protected virtual void Awake()
    {
        ulong uVar1;
        bool cVar2;
        uint uVar3;
        ulong uVar4;
        ulong uVar5;
        uVar4 = SteamManager.s_instance;
        cVar2 = Object.op_Inequality(uVar4,0,0);
        if (!cVar2) {
          if (**(int **)(DAT_181e538e8 + 184) == 0) {
            SteamManager.s_instance = this;
            if (**(char **)(DAT_181e87268 + 184) != false) {
              uVar4 = il2cpp_runtime_class_init(&DAT_181ea59a0);
              uVar4 = il2cpp_internal(uVar4);
              uVar5 = il2cpp_internal(&"Tried to Initialize the SteamAPI twice in one session!");
              Exception.ctor(uVar4,uVar5,0);
              uVar5 = il2cpp_runtime_class_init(&DAT_181e96d90);
                          // WARNING: Subroutine does not return
              FUN_1801e02d0(uVar4,uVar5);
            }
            uVar4 = Component.get_gameObject(this,0);
            Object.DontDestroyOnLoad(uVar4,0);
            cVar2 = Packsize.Test(0);
            if (!cVar2) {
              Debug.LogError("[Steamworks.NET] Packsize Test returned false, the wrong version of Steamworks.NET is being run in this platform.",this,0);
            }
            cVar2 = PlotController.CheckPlotAvailable(0);
            if (!cVar2) {
              Debug.LogError("[Steamworks.NET] DllCheck Test returned false, One or more of the Steamworks binaries seems to be the wrong version.",this,0);
            }
            uVar1 = *(uint64 *)(*(int64 *)(DAT_181e538e8 + 184) + 48);
            uVar3 = FUN_18055d730(uVar1 & 0xffffffff,0);
            cVar2 = FUN_18058d8b0(uVar3,0);
            if (cVar2) {
              Debug.Log("[Steamworks.NET] Shutting down because RestartAppIfNecessary returned true. Steam will restart the application.",0);
              Application.Quit(0);
              return;
            }
            cVar2 = SteamAPI.Init(0);
            this.m_bInitialized = cVar2;
            if (!cVar2) {
              Debug.LogError("[Steamworks.NET] SteamAPI_Init() failed. Refer to Valve's documentation or the comment above this line for more information.",this,0);
              return;
            }
            **(uint8 **)(DAT_181e87268 + 184) = 1;
            return;
          }
        }
        uVar4 = Component.get_gameObject(this,0);
        Object.Destroy(uVar4,0);
    }

    // Token : 0x60022A6
    // RVA   : 0xA15EC0   Offset: 0xA14CC0   Length: 0x144
    protected virtual void OnEnable()
    {
        bool cVar2;
        ulong uVar3;
        uVar3 = SteamManager.s_instance;
        cVar2 = Object.op_Equality(uVar3,0,0);
        if (cVar2) {
          SteamManager.s_instance = this;
        }
        if ((this.m_bInitialized) &&
           (puVar1 = (uint64 *)(this + 32), this.m_SteamAPIWarningMessageHook == null)) {
          uVar3 = new OnTooltipCB(0,DAT_181e96e10,0);
          *puVar1 = uVar3;
          il2cpp_internal(puVar1,uVar3);
          SteamClient.SetWarningMessageHook(*puVar1,0);
        }
    }

    // Token : 0x60022A7
    // RVA   : 0xA15DC0   Offset: 0xA14BC0   Length: 0xF1
    protected virtual void OnDestroy()
    {
        ulong uVar1;
        bool cVar2;
        uVar1 = SteamManager.s_instance;
        cVar2 = Object.op_Inequality(uVar1,this,0);
        if (!cVar2) {
          SteamManager.s_instance = 0;
          if (this.m_bInitialized) {
            SteamAPI.Shutdown(0);
          }
        }
    }

    // Token : 0x60022A8
    // RVA   : 0xA16070   Offset: 0xA14E70   Length: 0xE
    protected virtual void Update()
    {
        void FUN_180a16070(int64 this)
        {
        if (this.m_bInitialized) {
          SteamAPI.RunCallbacks(0);
          return;
        }
    }

    // Token : 0x60022A9
    // RVA   : 0x2110A0   Offset: 0x20FEA0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_180ae8740(this,0);
    }

    // Token : 0x60022AA
    // RVA   : 0x51CF50   Offset: 0x51BD50   Length: 0x3
    private static void /*cctor*/()
    {
    }

}
