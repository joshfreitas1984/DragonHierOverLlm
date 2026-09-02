// ============================================================
// Type  : GameObjectController
// Token : 0x20002A3
// ============================================================

public class GameObjectController
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x40014B3
    public Material spineDefaultGraphicMaterial;

    // Token: 0x40014B4
    public GameObject bigMap;

    // Token: 0x40014B5
    public GameObject bigMapUIPanel;

    // Token: 0x40014B6
    public GameObject areaUIPanel;

    // Token: 0x40014B7
    public GameObject battleUIPanel;

    // Token: 0x40014B8
    public GameObject popInfoPanel;

    // Token: 0x40014B9
    public GameObject buildingUIPanel;

    // Token: 0x40014BA
    public GameObject screenBlack;

    // Token: 0x40014BB
    public GameObject areaIconPrefab;

    // Token: 0x40014BC
    public GameObject resourcePointPrefab;

    // Token: 0x40014BD
    public GameObject resourcePointUIPrefab;

    // Token: 0x40014BE
    public GameObject innIconPrefab;

    // Token: 0x40014BF
    public GameObject bigmapDecorationPrefab;

    // Token: 0x40014C0
    public GameObject bigmapRandomEventPrefab;

    // Token: 0x40014C1
    public GameObject bigmapNPCPrefab;

    // Token: 0x40014C2
    public GameObject heroIconPrefab;

    // Token: 0x40014C3
    public GameObject battleUnitPrefab;

    // Token: 0x40014C4
    public GameObject itemIconPrefab;

    // Token: 0x40014C5
    public GameObject skillIconPrefab;

    // Token: 0x40014C6
    public GameObject simpleTextPrefab;

    // Token: 0x40014C7
    public GameObject skillExpShowPrefab;

    // Token: 0x40014C8
    public GameObject areaTreasurePriceInfoPrefab;

    // Token: 0x40014C9
    public GameObject heroTagIconPrefab;

    // Token: 0x40014CA
    public List<GameObject> footstepParticlePrefab;

    // Token: 0x40014CB
    public List<Sprite> resourceSprites;

    // Token: 0x40014CC
    public Material spriteOutLineMaterial;

    // Token: 0x40014CD
    public Material skeletonGraphicDefault;

    // Token: 0x40014CE
    public List<AudioClip> humanFootStepSound;

    // Token: 0x40014CF
    public List<AudioClip> horseFootStepSound;

    // Token: 0x40014D0
    public List<AudioClip> waterFootStepSound;

    // Token: 0x40014D1
    private static GameObjectController _instance;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x600165C
    // RVA   : 0xA29BC0   Offset: 0xA283C0   Length: 0x36
    public static GameObjectController get_Instance()
    {
        return **(uint64 **)(DAT_181d4e188 + 184);
    }

    // Token : 0x600165D
    // RVA   : 0xA29AE0   Offset: 0xA282E0   Length: 0xD7
    private void Awake()
    {
        bool cVar2;
        ulong uVar3;
        uVar3 = **(uint64 **)(DAT_181d4e188 + 184);
        cVar2 = Object.op_Equality(uVar3,0,0);
        if (!cVar2) {
          uVar3 = Component.get_gameObject(this,0);
          Object.Destroy(uVar3,0);
          return;
        }
        puVar1 = *(uint64 **)(DAT_181d4e188 + 184);
        *puVar1 = this;
        il2cpp_internal(puVar1,this);
    }

    // Token : 0x600165E
    // RVA   : 0x3A17B0   Offset: 0x39FFB0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_18044ef50(this,0);
    }

}
