// ============================================================
// Type  : GameObjectController
// Token : 0x20002B2
// ============================================================

public class GameObjectController
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x40015B5
    public Material spineDefaultGraphicMaterial;

    // Token: 0x40015B6
    public GameObject bigMap;

    // Token: 0x40015B7
    public GameObject bigMapUIPanel;

    // Token: 0x40015B8
    public GameObject areaUIPanel;

    // Token: 0x40015B9
    public GameObject battleUIPanel;

    // Token: 0x40015BA
    public GameObject popInfoPanel;

    // Token: 0x40015BB
    public GameObject buildingUIPanel;

    // Token: 0x40015BC
    public GameObject screenBlack;

    // Token: 0x40015BD
    public GameObject areaIconPrefab;

    // Token: 0x40015BE
    public GameObject resourcePointPrefab;

    // Token: 0x40015BF
    public GameObject resourcePointUIPrefab;

    // Token: 0x40015C0
    public GameObject innIconPrefab;

    // Token: 0x40015C1
    public GameObject bigmapDecorationPrefab;

    // Token: 0x40015C2
    public GameObject bigmapRandomEventPrefab;

    // Token: 0x40015C3
    public GameObject bigmapNPCPrefab;

    // Token: 0x40015C4
    public GameObject heroIconPrefab;

    // Token: 0x40015C5
    public GameObject battleUnitPrefab;

    // Token: 0x40015C6
    public GameObject itemIconPrefab;

    // Token: 0x40015C7
    public GameObject skillIconPrefab;

    // Token: 0x40015C8
    public GameObject simpleTextPrefab;

    // Token: 0x40015C9
    public GameObject skillExpShowPrefab;

    // Token: 0x40015CA
    public GameObject areaTreasurePriceInfoPrefab;

    // Token: 0x40015CB
    public GameObject heroTagIconPrefab;

    // Token: 0x40015CC
    public List<GameObject> footstepParticlePrefab;

    // Token: 0x40015CD
    public List<Sprite> resourceSprites;

    // Token: 0x40015CE
    public Material spriteOutLineMaterial;

    // Token: 0x40015CF
    public Material skeletonGraphicDefault;

    // Token: 0x40015D0
    public List<AudioClip> humanFootStepSound;

    // Token: 0x40015D1
    public List<AudioClip> horseFootStepSound;

    // Token: 0x40015D2
    public List<AudioClip> waterFootStepSound;

    // Token: 0x40015D3
    private static GameObjectController _instance;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x600171C
    // RVA   : 0x6BA950   Offset: 0x6B9750   Length: 0x36
    public static GameObjectController get_Instance()
    {
        return **(uint64 **)(DAT_181e52a90 + 184);
    }

    // Token : 0x600171D
    // RVA   : 0x6BA870   Offset: 0x6B9670   Length: 0xD7
    private void Awake()
    {
        bool cVar2;
        ulong uVar3;
        uVar3 = **(uint64 **)(DAT_181e52a90 + 184);
        cVar2 = Object.op_Equality(uVar3,0,0);
        if (!cVar2) {
          uVar3 = Component.get_gameObject(this,0);
          Object.Destroy(uVar3,0);
          return;
        }
        puVar1 = *(uint64 **)(DAT_181e52a90 + 184);
        *puVar1 = this;
        il2cpp_internal(puVar1,this);
    }

    // Token : 0x600171E
    // RVA   : 0x2110A0   Offset: 0x20FEA0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_180ae8740(this,0);
    }

}
