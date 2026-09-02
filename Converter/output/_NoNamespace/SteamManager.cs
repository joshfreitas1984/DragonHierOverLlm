// ============================================================
// Type  : SteamManager
// Token : 0x200036C
// ============================================================

public class SteamManager
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001B42
    protected static bool s_EverInitialized;

    // Token: 0x4001B43
    protected static SteamManager s_instance;

    // Token: 0x4001B44
    protected bool m_bInitialized;

    // Token: 0x4001B45
    protected SteamAPIWarningMessageHook_t m_SteamAPIWarningMessageHook;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6002176
    // RVA   : 0xC7D160   Offset: 0xC7B960   Length: 0x12C
    protected static SteamManager get_Instance()
    {
        var pStatics = *(int64*)(DAT_181d81bf0 + 184);
        bool cVar1;
        long lVar2;
        ulong uVar3;
        uVar3 = *(uint64 *)(pStatics + 8);
        cVar1 = Object.op_Equality(uVar3,0,0);
        if (!cVar1) {
          return *(uint64 *)(pStatics + 8);
        }
        lVar2 = new GameObject("SteamManager",0);
        if (lVar2 != null) {
          uVar3 = GameObject.AddComponent(lVar2,DAT_181d9d568);
          return uVar3;
        }
    }

    // Token : 0x6002177
    // RVA   : 0xC7CFE0   Offset: 0xC7B7E0   Length: 0x176
    public static bool get_Initialized()
    {
        var pStatics = *(int64*)(DAT_181d81bf0 + 184);
        ulong uVar1;
        bool cVar2;
        long lVar3;
        uVar1 = *(uint64 *)(pStatics + 8);
        cVar2 = Object.op_Equality(uVar1,0,0);
        if (!cVar2) {
          lVar3 = *(int64 *)(pStatics + 8);
        }
        else {
          lVar3 = new GameObject("SteamManager",0);
          if (lVar3 == null) throw; // [null/range check failed]
          lVar3 = GameObject.AddComponent(lVar3,DAT_181d9d568);
        }
        if (lVar3 != null) {
          return *(uint8 *)(lVar3 + 24);
        }
    }

    // Token : 0x6002178
    // RVA   : 0xC7CF70   Offset: 0xC7B770   Length: 0x52
    protected static void SteamAPIDebugTextHook(int nSeverity, StringBuilder pchDebugText)
    {
        Debug.LogWarning(pchDebugText,0);
    }

    // Token : 0x6002179
    // RVA   : 0xC7CCA0   Offset: 0xC7B4A0   Length: 0x76
    private static void InitOnPlayMode()
    {
        **(uint8 **)(DAT_181d81bf0 + 184) = 0;
        puVar1 = (uint64 *)(*(int64 *)(DAT_181d81bf0 + 184) + 8);
        *puVar1 = 0;
        il2cpp_internal(puVar1,0);
    }

    // Token : 0x600217A
    // RVA   : 0xC7C810   Offset: 0xC7B010   Length: 0x48D
    protected virtual void Awake()
    {
        var pStatics = *(int64*)(DAT_181d81bf0 + 184);
        ulong uVar1;
        bool cVar2;
        uint uVar3;
        ulong uVar4;
        ulong uVar5;
        uVar4 = *(uint64 *)(pStatics + 8);
        cVar2 = Object.op_Inequality(uVar4,0,0);
        if (!cVar2) {
          if (**(int **)(DAT_181d4ef00 + 184) == 0) {
            plVar6 = (int64 *)(pStatics + 8);
            *plVar6 = this;
            il2cpp_internal(plVar6,this);
            if (**(char **)(DAT_181d81bf0 + 184) != false) {
              uVar4 = il2cpp_runtime_class_init(&DAT_181da0308);
              uVar4 = il2cpp_internal(uVar4);
              uVar5 = il2cpp_internal(&"Tried to Initialize the SteamAPI twice in one session!");
              Exception.ctor(uVar4,uVar5,0);
              uVar5 = il2cpp_runtime_class_init(&DAT_181d8a1e8);
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar4,uVar5);
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
            uVar1 = *(uint64 *)(*(int64 *)(DAT_181d4ef00 + 184) + 48);
            uVar3 = FUN_180826e00(uVar1 & 0xffffffff,0);
            cVar2 = FUN_180856e40(uVar3,0);
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
            **(uint8 **)(DAT_181d81bf0 + 184) = 1;
            return;
          }
        }
        uVar4 = Component.get_gameObject(this,0);
        Object.Destroy(uVar4,0);
    }

    // Token : 0x600217B
    // RVA   : 0xC7CE20   Offset: 0xC7B620   Length: 0x144
    protected virtual void OnEnable()
    {
        var pStatics = *(int64*)(DAT_181d81bf0 + 184);
        bool cVar2;
        ulong uVar3;
        uVar3 = *(uint64 *)(pStatics + 8);
        cVar2 = Object.op_Equality(uVar3,0,0);
        if (cVar2) {
          plVar4 = (int64 *)(pStatics + 8);
          *plVar4 = this;
          il2cpp_internal(plVar4,this);
        }
        if ((this.m_bInitialized) &&
           (puVar1 = (uint64 *)(this + 32), this.m_SteamAPIWarningMessageHook == null)) {
          uVar3 = new OnTooltipCB(0,DAT_181d8a268,0);
          *puVar1 = uVar3;
          il2cpp_internal(puVar1,uVar3);
          SteamClient.SetWarningMessageHook(*puVar1,0);
        }
    }

    // Token : 0x600217C
    // RVA   : 0xC7CD20   Offset: 0xC7B520   Length: 0xF1
    protected virtual void OnDestroy()
    {
        var pStatics = *(int64*)(DAT_181d81bf0 + 184);
        ulong uVar1;
        bool cVar2;
        uVar1 = *(uint64 *)(pStatics + 8);
        cVar2 = Object.op_Inequality(uVar1,this,0);
        if (!cVar2) {
          puVar3 = (uint64 *)(pStatics + 8);
          *puVar3 = 0;
          il2cpp_internal(puVar3,0);
          if (this.m_bInitialized) {
            SteamAPI.Shutdown(0);
          }
        }
    }

    // Token : 0x600217D
    // RVA   : 0xC7CFD0   Offset: 0xC7B7D0   Length: 0xE
    protected virtual void Update()
    {
        void FUN_180c7cfd0(int64 this)
        {
        if (this.m_bInitialized) {
          SteamAPI.RunCallbacks(0);
          return;
        }
    }

    // Token : 0x600217E
    // RVA   : 0x3A17B0   Offset: 0x39FFB0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_18044ef50(this,0);
    }

    // Token : 0x600217F
    // RVA   : 0x245810   Offset: 0x244010   Length: 0x3
    private static void /*cctor*/()
    {
    }

}
