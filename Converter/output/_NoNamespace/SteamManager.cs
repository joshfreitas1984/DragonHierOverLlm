// ============================================================
// Type  : SteamManager
// Token : 0x2000373
// ============================================================

public class SteamManager
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001C43
    protected static bool s_EverInitialized;

    // Token: 0x4001C44
    protected static SteamManager s_instance;

    // Token: 0x4001C45
    protected bool m_bInitialized;

    // Token: 0x4001C46
    protected SteamAPIWarningMessageHook_t m_SteamAPIWarningMessageHook;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60021F7
    // RVA   : 0xC6C9D0   Offset: 0xC6BDD0   Length: 0x12C
    protected static SteamManager get_Instance()
    {
        var pStatics = *(int64*)(DAT_181da6e10 + 184);
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
          uVar3 = GameObject.AddComponent(lVar2,DAT_181dc6308);
          return uVar3;
        }
    }

    // Token : 0x60021F8
    // RVA   : 0xC6C850   Offset: 0xC6BC50   Length: 0x176
    public static bool get_Initialized()
    {
        var pStatics = *(int64*)(DAT_181da6e10 + 184);
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
          lVar3 = GameObject.AddComponent(lVar3,DAT_181dc6308);
        }
        if (lVar3 != null) {
          return *(uint8 *)(lVar3 + 24);
        }
    }

    // Token : 0x60021F9
    // RVA   : 0xC6C7E0   Offset: 0xC6BBE0   Length: 0x52
    protected static void SteamAPIDebugTextHook(int nSeverity, StringBuilder pchDebugText)
    {
        Debug.LogWarning(pchDebugText,0);
    }

    // Token : 0x60021FA
    // RVA   : 0xC6C510   Offset: 0xC6B910   Length: 0x76
    private static void InitOnPlayMode()
    {
        **(uint8 **)(DAT_181da6e10 + 184) = 0;
        puVar1 = (uint64 *)(*(int64 *)(DAT_181da6e10 + 184) + 8);
        *puVar1 = 0;
        il2cpp_internal(puVar1,0);
    }

    // Token : 0x60021FB
    // RVA   : 0xC6C080   Offset: 0xC6B480   Length: 0x48D
    protected virtual void Awake()
    {
        var pStatics = *(int64*)(DAT_181da6e10 + 184);
        ulong uVar1;
        bool cVar2;
        uint uVar3;
        ulong uVar4;
        ulong uVar5;
        uVar4 = *(uint64 *)(pStatics + 8);
        cVar2 = Object.op_Inequality(uVar4,0,0);
        if (!cVar2) {
          if (**(int **)(DAT_181d73d40 + 184) == 0) {
            plVar6 = (int64 *)(pStatics + 8);
            *plVar6 = this;
            il2cpp_internal(plVar6,this);
            if (**(char **)(DAT_181da6e10 + 184) != false) {
              uVar4 = il2cpp_runtime_class_init(&DAT_181dc54a0);
              uVar4 = il2cpp_internal(uVar4);
              uVar5 = il2cpp_internal(&"Tried to Initialize the SteamAPI twice in one session!");
              Exception.ctor(uVar4,uVar5,0);
              uVar5 = il2cpp_runtime_class_init(&DAT_181db3278);
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
            uVar1 = *(uint64 *)(*(int64 *)(DAT_181d73d40 + 184) + 48);
            uVar3 = FUN_1808256f0(uVar1 & 0xffffffff,0);
            cVar2 = FUN_180855730(uVar3,0);
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
            **(uint8 **)(DAT_181da6e10 + 184) = 1;
            return;
          }
        }
        uVar4 = Component.get_gameObject(this,0);
        Object.Destroy(uVar4,0);
    }

    // Token : 0x60021FC
    // RVA   : 0xC6C690   Offset: 0xC6BA90   Length: 0x144
    protected virtual void OnEnable()
    {
        var pStatics = *(int64*)(DAT_181da6e10 + 184);
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
          uVar3 = new OnTooltipCB(0,DAT_181db3300,0);
          *puVar1 = uVar3;
          il2cpp_internal(puVar1,uVar3);
          SteamClient.SetWarningMessageHook(*puVar1,0);
        }
    }

    // Token : 0x60021FD
    // RVA   : 0xC6C590   Offset: 0xC6B990   Length: 0xF1
    protected virtual void OnDestroy()
    {
        var pStatics = *(int64*)(DAT_181da6e10 + 184);
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

    // Token : 0x60021FE
    // RVA   : 0xC6C840   Offset: 0xC6BC40   Length: 0xE
    protected virtual void Update()
    {
        void FUN_180c6c840(int64 this)
        {
        if (this.m_bInitialized) {
          SteamAPI.RunCallbacks(0);
          return;
        }
    }

    // Token : 0x60021FF
    // RVA   : 0x3A17B0   Offset: 0x3A0BB0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_18044ef50(this,0);
    }

    // Token : 0x6002200
    // RVA   : 0x245810   Offset: 0x244C10   Length: 0x3
    private static void /*cctor*/()
    {
    }

}
