// ============================================================
// Type  : GameObjectController
// Token : 0x20002A9
// ============================================================

public class GameObjectController
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001565
    public Material spineDefaultGraphicMaterial;

    // Token: 0x4001566
    public GameObject bigMap;

    // Token: 0x4001567
    public GameObject bigMapUIPanel;

    // Token: 0x4001568
    public GameObject areaUIPanel;

    // Token: 0x4001569
    public GameObject battleUIPanel;

    // Token: 0x400156A
    public GameObject popInfoPanel;

    // Token: 0x400156B
    public GameObject buildingUIPanel;

    // Token: 0x400156C
    public GameObject screenBlack;

    // Token: 0x400156D
    public GameObject areaIconPrefab;

    // Token: 0x400156E
    public GameObject resourcePointPrefab;

    // Token: 0x400156F
    public GameObject resourcePointUIPrefab;

    // Token: 0x4001570
    public GameObject innIconPrefab;

    // Token: 0x4001571
    public GameObject bigmapDecorationPrefab;

    // Token: 0x4001572
    public GameObject bigmapRandomEventPrefab;

    // Token: 0x4001573
    public GameObject bigmapNPCPrefab;

    // Token: 0x4001574
    public GameObject heroIconPrefab;

    // Token: 0x4001575
    public GameObject battleUnitPrefab;

    // Token: 0x4001576
    public GameObject itemIconPrefab;

    // Token: 0x4001577
    public GameObject skillIconPrefab;

    // Token: 0x4001578
    public GameObject simpleTextPrefab;

    // Token: 0x4001579
    public GameObject skillExpShowPrefab;

    // Token: 0x400157A
    public GameObject areaTreasurePriceInfoPrefab;

    // Token: 0x400157B
    public GameObject heroTagIconPrefab;

    // Token: 0x400157C
    public List<GameObject> footstepParticlePrefab;

    // Token: 0x400157D
    public List<Sprite> resourceSprites;

    // Token: 0x400157E
    public Material spriteOutLineMaterial;

    // Token: 0x400157F
    public Material skeletonGraphicDefault;

    // Token: 0x4001580
    public List<AudioClip> humanFootStepSound;

    // Token: 0x4001581
    public List<AudioClip> horseFootStepSound;

    // Token: 0x4001582
    public List<AudioClip> waterFootStepSound;

    // Token: 0x4001583
    private static GameObjectController _instance;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60016A0
    // RVA   : 0xA58570   Offset: 0xA57970   Length: 0x36
    public static GameObjectController get_Instance()
    {
        return **(uint64 **)(DAT_181d72ee8 + 184);
    }

    // Token : 0x60016A1
    // RVA   : 0xA58490   Offset: 0xA57890   Length: 0xD7
    private void Awake()
    {
        bool cVar2;
        ulong uVar3;
        uVar3 = **(uint64 **)(DAT_181d72ee8 + 184);
        cVar2 = Object.op_Equality(uVar3,0,0);
        if (!cVar2) {
          uVar3 = Component.get_gameObject(this,0);
          Object.Destroy(uVar3,0);
          return;
        }
        puVar1 = *(uint64 **)(DAT_181d72ee8 + 184);
        *puVar1 = this;
        il2cpp_internal(puVar1,this);
    }

    // Token : 0x60016A2
    // RVA   : 0x3A17B0   Offset: 0x3A0BB0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_18044ef50(this,0);
    }

}
