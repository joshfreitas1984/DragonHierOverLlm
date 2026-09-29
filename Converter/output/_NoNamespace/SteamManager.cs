// ============================================================
// Type  : SteamManager
// Token : 0x2000373
// ============================================================

public class SteamManager
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001C44
    protected static bool s_EverInitialized;

    // Token: 0x4001C45
    protected static SteamManager s_instance;

    // Token: 0x4001C46
    protected bool m_bInitialized;

    // Token: 0x4001C47
    protected SteamAPIWarningMessageHook_t m_SteamAPIWarningMessageHook;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60021F7
    // RVA   : 0xC6CFE0   Offset: 0xC6C3E0   Length: 0x12C
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
          uVar3 = GameObject.AddComponent(lVar2,DAT_181dc6320);
          return uVar3;
        }
    }

    // Token : 0x60021F8
    // RVA   : 0xC6CE60   Offset: 0xC6C260   Length: 0x176
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
          lVar3 = GameObject.AddComponent(lVar3,DAT_181dc6320);
        }
        if (lVar3 != null) {
          return lVar3.m_bInitialized;
        }
    }

    // Token : 0x60021F9
    // RVA   : 0xC6CDF0   Offset: 0xC6C1F0   Length: 0x52
    protected static void SteamAPIDebugTextHook(int nSeverity, StringBuilder pchDebugText)
    {
        Debug.LogWarning(pchDebugText,0);
    }

    // Token : 0x60021FA
    // RVA   : 0xC6CB20   Offset: 0xC6BF20   Length: 0x76
    private static void InitOnPlayMode()
    {
        **(uint8 **)(DAT_181da6e28 + 184) = 0;
        puVar1 = (uint64 *)(*(int64 *)(DAT_181da6e28 + 184) + 8);
        *puVar1 = 0;
        il2cpp_internal(puVar1,0);
    }

    // Token : 0x60021FB
    // RVA   : 0xC6C690   Offset: 0xC6BA90   Length: 0x48D
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
          if (**(int **)(DAT_181d73d40 + 184) == 0) {
            SteamManager.s_instance = this;
            if (**(char **)(DAT_181da6e28 + 184) != false) {
              uVar4 = il2cpp_runtime_class_init(&DAT_181dc54b8);
              uVar4 = il2cpp_internal(uVar4);
              uVar5 = il2cpp_internal(&"Tried to Initialize the SteamAPI twice in one session!");
              Exception.ctor(uVar4,uVar5,0);
              uVar5 = il2cpp_runtime_class_init(&DAT_181db3428);
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
            **(uint8 **)(DAT_181da6e28 + 184) = 1;
            return;
          }
        }
        uVar4 = Component.get_gameObject(this,0);
        Object.Destroy(uVar4,0);
    }

    // Token : 0x60021FC
    // RVA   : 0xC6CCA0   Offset: 0xC6C0A0   Length: 0x144
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
          uVar3 = new OnTooltipCB(0,DAT_181db34b0,0);
          *puVar1 = uVar3;
          il2cpp_internal(puVar1,uVar3);
          SteamClient.SetWarningMessageHook(*puVar1,0);
        }
    }

    // Token : 0x60021FD
    // RVA   : 0xC6CBA0   Offset: 0xC6BFA0   Length: 0xF1
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

    // Token : 0x60021FE
    // RVA   : 0xC6CE50   Offset: 0xC6C250   Length: 0xE
    protected virtual void Update()
    {
        void FUN_180c6ce50(int64 this)
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
