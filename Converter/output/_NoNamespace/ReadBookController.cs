// ============================================================
// Type  : ReadBookController
// Token : 0x2000338
// ============================================================

public class ReadBookController
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001AC9
    public List<ReadBookTextTypeData> readBookTextTypeDataBase;

    // Token: 0x4001ACA
    public GameObject readBookTextPrefab;

    // Token: 0x4001ACB
    public GameObject readBookGridRoot;

    // Token: 0x4001ACC
    public GameObject readBookUIPanel;

    // Token: 0x4001ACD
    public List<Color> ScrollRareColor;

    // Token: 0x4001ACE
    public List<Sprite> RareIconSprite;

    // Token: 0x4001ACF
    public GameObject[] gridUnits;

    // Token: 0x4001AD0
    public List<GameObject> gridPool;

    // Token: 0x4001AD1
    public List<GameObject> actingGrid;

    // Token: 0x4001AD2
    public bool reading;

    // Token: 0x4001AD3
    public ItemData targetBook;

    // Token: 0x4001AD4
    public int mapWidth;

    // Token: 0x4001AD5
    public int mapHeight;

    // Token: 0x4001AD6
    public float totalExp;

    // Token: 0x4001AD7
    public int patientNum;

    // Token: 0x4001AD8
    public int inspirationNum;

    // Token: 0x4001AD9
    public int textReaded;

    // Token: 0x4001ADA
    public GameObject readTextExpIcon;

    // Token: 0x4001ADB
    private GameObject newObj;

    // Token: 0x4001ADC
    private bool inited;

    // Token: 0x4001ADD
    private int maxWidth;

    // Token: 0x4001ADE
    private int maxHeight;

    // Token: 0x4001ADF
    private HeroData targetHero;

    // Token: 0x4001AE0
    private SkillMaxPracticeExpData targetPracticeExpData;

    // Token: 0x4001AE1
    private KungfuSkillLvData targetSkill;

    // Token: 0x4001AE2
    private static ReadBookController _instance;

    // Token: 0x4001AE3
    private ItemData tempBookData;

    // Token: 0x4001AE4
    private bool costContribution;

    // Token: 0x4001AE5
    private bool costMoeny;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6002061
    // RVA   : 0xD0DFE0   Offset: 0xD0D3E0   Length: 0x36
    public static ReadBookController get_Instance()
    {
        return **(uint64 **)(DAT_181d99c98 + 184);
    }

    // Token : 0x6002062
    // RVA   : 0xD09960   Offset: 0xD08D60   Length: 0xD7
    private void Awake()
    {
        bool cVar2;
        ulong uVar3;
        uVar3 = **(uint64 **)(DAT_181d99c98 + 184);
        cVar2 = Object.op_Equality(uVar3,0,0);
        if (!cVar2) {
          uVar3 = Component.get_gameObject(this,0);
          Object.Destroy(uVar3,0);
          return;
        }
        puVar1 = *(uint64 **)(DAT_181d99c98 + 184);
        *puVar1 = this;
        il2cpp_internal(puVar1,this);
    }

    // Token : 0x6002063
    // RVA   : 0xD0DDB0   Offset: 0xD0D1B0   Length: 0x19F
    private void Update()
    {
        long lVar1;
        ulong uVar2;
        ulong uVar3;
        if (!this.reading) {
          return;
        }
        if ((((this.readBookUIPanel != null) &&
             (lVar1 = GameObject.get_transform(this.readBookUIPanel,0)) != null) &&
            (lVar1 = Transform.Find(lVar1,"TotalExp",0)) != null) &&
           (lVar1 = Transform.Find(lVar1,"Text",0)) != null) {
          uVar2 = Component.GetComponent(lVar1,DAT_181d96178);
          uVar3 = Single.ToString(this + 120,"+0;-0;0",0);
          LTLocalization.SetText(uVar2,uVar3,0);
          if (((this.readBookUIPanel != null) &&
              (lVar1 = GameObject.get_transform(this.readBookUIPanel,0)) != null) &&
             ((lVar1 = Transform.Find(lVar1,"Patient",0), lVar1 != null &&
              (lVar1 = Transform.Find(lVar1,"Text",0)) != null))) {
            uVar2 = Component.GetComponent(lVar1,DAT_181d96178);
            uVar3 = Int32.ToString(this + 124,0);
            LTLocalization.SetText(uVar2,uVar3,0);
            return;
          }
        }
    }

    // Token : 0x6002064
    // RVA   : 0xD0ADA0   Offset: 0xD0A1A0   Length: 0x480
    private void InitReadBookText()
    {
        ulong uVar1;
        long lVar2;
        long lVar4;
        ulong uVar5;
        int iVar6;
        long lVar7;
        long lVar8;
        int iVar9;
        float fVar10;
        float fVar11;
        int[] local_res8 = new int[2];
        int[] local_res18 = new int[4];
        float local_b8;
        float local_b4;
        uint local_b0;
        ulong local_a8;
        uint local_a0;
        long local_98;
        long local_90;
        ulong local_88;
        ulong uStack_80;
        byte[] local_78 = new byte[16];
        byte[] local_68 = new byte[48];
        local_98 = (int64)this.maxWidth;
        local_90 = (int64)this.maxHeight;
        local_88 = 0;
        uStack_80 = 0;
        uVar1 = FUN_1800d6020(DAT_181da99f8,&local_98);
        this.gridUnits = uVar1;
        uVar1 = il2cpp_internal(DAT_181d92f70);
        FUN_181330100(uVar1,DAT_181d892b0);
        this.gridPool = uVar1;
        iVar9 = 0;
        if (0 < this.maxHeight) {
          do {
            iVar6 = 0;
            if (0 < this.maxWidth) {
              do {
                lVar2 = this.gridUnits;
                uVar1 = this.readBookGridRoot;
                uVar5 = this.readBookTextPrefab;
                uVar1 = GlobalData.AddChild(uVar1,uVar5,0);
                if (lVar2 == null) {
        LAB_180d0b21b:
                          // WARNING: Subroutine does not return
                  FUN_1800d6620();
                }
                lVar8 = (int64)iVar9;
                lVar7 = (int64)iVar6;
                FUN_180128020(lVar2,lVar7,lVar8,uVar1);
                if ((this.gridUnits == null) ||
                   (lVar2 = FUN_180127f90(this.gridUnits,lVar7,lVar8)) == null)
                goto LAB_180d0b21b;
                lVar2 = GameObject.get_transform(lVar2,0);
                puVar3 = (uint64 *)Vector3.get_one(&local_98,0);
                if (lVar2 == null) goto LAB_180d0b21b;
                local_a0 = *(uint32 *)(puVar3 + 1);
                local_a8 = *puVar3;
                Transform.set_localScale(lVar2,&local_a8,0);
                if ((this.gridUnits == null) ||
                   (lVar2 = FUN_180127f90(this.gridUnits,lVar7,lVar8)) == null)
                goto LAB_180d0b21b;
                lVar2 = GameObject.get_transform(lVar2,0);
                if ((this.readBookTextPrefab == null) ||
                   (lVar4 = GameObject.GetComponent(this.readBookTextPrefab,DAT_181d72bc8),
                   lVar4 == null)) goto LAB_180d0b21b;
                puVar3 = (uint64 *)RectTransform.get_rect(local_78,lVar4,0);
                local_88 = *puVar3;
                uStack_80 = puVar3[1];
                fVar10 = (float)FUN_180d995b0(&local_88,0);
                if ((this.readBookTextPrefab == null) ||
                   (lVar4 = GameObject.GetComponent(this.readBookTextPrefab,DAT_181d72bc8),
                   lVar4 == null)) goto LAB_180d0b21b;
                puVar3 = (uint64 *)RectTransform.get_rect(local_68,lVar4,0);
                local_88 = *puVar3;
                uStack_80 = puVar3[1];
                fVar11 = (float)FUN_18044e2b0(&local_88,0);
                if (lVar2 == null) goto LAB_180d0b21b;
                local_b0 = 0;
                local_b8 = (float)iVar6 * fVar10;
                local_b4 = fVar11 * (float)iVar9;
                Transform.set_localPosition(lVar2,&local_b8,0);
                if (this.gridUnits == null) goto LAB_180d0b21b;
                lVar2 = FUN_180127f90(this.gridUnits,lVar7,lVar8);
                local_res8[0] = iVar9;
                uVar1 = il2cpp_value_box(DAT_181d80430,local_res8);
                local_res18[0] = iVar6;
                uVar5 = il2cpp_value_box(DAT_181d80430,local_res18);
                uVar1 = String.Format("{0}_{1}",uVar1,uVar5,0);
                if (lVar2 == null) goto LAB_180d0b21b;
                Object.set_name(lVar2,uVar1,0);
                if ((this.gridUnits == null) ||
                   (lVar2 = FUN_180127f90(this.gridUnits,lVar7,lVar8)) == null)
                goto LAB_180d0b21b;
                GameObject.SetActive(lVar2,0,0);
                if ((this.gridUnits == null) ||
                   ((lVar2 = FUN_180127f90(this.gridUnits,lVar7,lVar8), lVar2 == null ||
                    (lVar2 = GameObject.GetComponent(lVar2,DAT_181d72ab8)) == null)))
                goto LAB_180d0b21b;
                *(int *)(lVar2 + 24) = iVar6;
                if ((this.gridUnits == null) ||
                   ((lVar2 = FUN_180127f90(this.gridUnits,lVar7), lVar2 == null ||
                    (lVar2 = GameObject.GetComponent(lVar2,DAT_181d72ab8)) == null)))
                goto LAB_180d0b21b;
                iVar6 = iVar6 + 1;
                *(int *)(lVar2 + 28) = iVar9;
              } while (iVar6 < this.maxWidth);
            }
            iVar9 = iVar9 + 1;
          } while (iVar9 < this.maxHeight);
        }
    }

    // Token : 0x6002065
    // RVA   : 0xD0BC60   Offset: 0xD0B060   Length: 0xB9F
    public void ShowReadBookPanel()
    {
        float fVar1;
        uint uVar2;
        int iVar3;
        long lVar4;
        ulong uVar7;
        ulong uVar8;
        long lVar9;
        ulong local_48;
        uint local_40;
        ulong local_38;
        ulong uStack_30;
        if (!this.inited) {
          ReadBookController.InitReadBookText(this,0);
          this.inited = 1;
        }
        this.targetBook = this.tempBookData;
        if (this.readBookUIPanel != null) {
          lVar4 = GameObject.get_transform(this.readBookUIPanel,0);
          if (lVar4 != null) {
            lVar4 = Transform.Find(lVar4,"FinishReadButton",0);
            puVar5 = (uint64 *)Vector3.get_zero(&local_38,0);
            if (lVar4 != null) {
              local_40 = *(uint32 *)(puVar5 + 1);
              local_48 = *puVar5;
              Transform.set_localScale(lVar4,&local_48,0);
              if (this.readBookUIPanel != null) {
                lVar4 = GameObject.get_transform(this.readBookUIPanel,0);
                if (lVar4 != null) {
                  lVar4 = Transform.Find(lVar4,"TotalExp",0);
                  puVar5 = (uint64 *)Vector3.get_zero(&local_38,0);
                  if (lVar4 != null) {
                    local_40 = *(uint32 *)(puVar5 + 1);
                    local_48 = *puVar5;
                    Transform.set_localScale(lVar4,&local_48,0);
                    if (this.readBookUIPanel != null) {
                      lVar4 = GameObject.get_transform(this.readBookUIPanel,0);
                      if (lVar4 != null) {
                        lVar4 = Transform.Find(lVar4,"Patient",0);
                        puVar5 = (uint64 *)Vector3.get_zero(&local_38,0);
                        if (lVar4 != null) {
                          local_40 = *(uint32 *)(puVar5 + 1);
                          local_48 = *puVar5;
                          Transform.set_localScale(lVar4,&local_48,0);
                          if (this.readBookUIPanel != null) {
                            lVar4 = GameObject.get_transform(this.readBookUIPanel,0);
                            if (lVar4 != null) {
                              lVar4 = Transform.Find(lVar4,"Question",0);
                              puVar5 = (uint64 *)Vector3.get_zero(&local_38,0);
                              if (lVar4 != null) {
                                local_40 = *(uint32 *)(puVar5 + 1);
                                local_48 = *puVar5;
                                Transform.set_localScale(lVar4,&local_48,0);
                                if (this.readBookUIPanel != null) {
                                  lVar4 = GameObject.get_transform(this.readBookUIPanel,0);
                                  if (lVar4 != null) {
                                    lVar4 = Transform.Find(lVar4,"Scroll",0);
                                    if (lVar4 != null) {
                                      plVar6 = (int64 *)Component.GetComponent(lVar4,DAT_181d94478);
                                      if ((this.targetBook != null) &&
                                         (lVar4 = this.ScrollRareColor) != null) {
                                        uVar2 = this.targetBook.itemLv;
                                        if (*(uint32 *)(lVar4 + 24) <= uVar2) {
                                          ThrowHelper.ThrowArgumentOutOfRangeException(0);
                                        }
                                        if (plVar6 != (int64 *)0) {
                                          puVar5 = (uint64 *)
                                                   (*(int64 *)(lVar4 + 16) +
                                                   ((int64)(int)uVar2 + 2) * 16);
                                          local_38 = *puVar5;
                                          uStack_30 = puVar5[1];
                                          (**(code **)(*plVar6 + 0x2a8))
                                                    (plVar6,&local_38,*(uint64 *)(*plVar6 + 0x2b0));
                                          if (this.readBookUIPanel != null) {
                                            lVar4 = GameObject.get_transform
                                                              (this.readBookUIPanel,0);
                                            if (lVar4 != null) {
                                              lVar4 = Transform.Find(lVar4,"Scroll",0);
                                              if (lVar4 != null) {
                                                lVar4 = Transform.Find(lVar4,"BookName",0);
                                                if (lVar4 != null) {
                                                  uVar7 = Component.GetComponent(lVar4,DAT_181d96178);
                                                  if (this.targetBook != null) {
                                                    uVar8 = ItemData.Name(this.targetBook,0
                                                                           ,0);
                                                    LTLocalization.SetText(uVar7,uVar8,0);
                                                    if (this.readBookUIPanel != null) {
                                                      lVar4 = GameObject.get_transform
                                                                        (this.readBookUIPanel,0);
                                                      if (lVar4 != null) {
                                                        lVar4 = Transform.Find(lVar4,"Scroll",0);
                                                        if (lVar4 != null) {
                                                          lVar4 = Transform.Find(lVar4,"BookRare",0);
                                                          if (lVar4 != null) {
                                                            uVar7 = Component.GetComponent
                                                                              (lVar4,DAT_181d96178);
                                                            lVar4 = *(int64 *)
                                                                     (*(int64 *)(DAT_181d73d40 + 184)
                                                                     + 0x500);
                                                            if ((this.targetBook != null) &&
                                                               (lVar4 != null)) {
                                                              uVar2 = *(uint32 *)(*(int64 *)
                                                                                 (this + 104) + 64);
                                                              if (*(uint32 *)(lVar4 + 24) <= uVar2) {

                                                        ThrowHelper.ThrowArgumentOutOfRangeException(0);
                                                        }
                                                        LTLocalization.SetText
                                                                  (uVar7,*(uint64 *)
                                                                          (*(int64 *)(lVar4 + 16) +
                                                                           32 + (int64)(int)uVar2 * 8
                                                                          ),0);
                                                        if (this.readBookUIPanel != null) {
                                                          lVar4 = GameObject.get_transform
                                                                            (this.readBookUIPanel
                                                                             ,0);
                                                          if (lVar4 != null) {
                                                            lVar4 = Transform.Find(lVar4,"Scroll",0)
                                                            ;
                                                            if (lVar4 != null) {
                                                              lVar4 = Transform.Find(lVar4,"RareIcon",
                                                                                      0);
                                                              if (lVar4 != null) {
                                                                lVar4 = Component.GetComponent
                                                                                  (lVar4,DAT_181d94478);
                                                                if ((this.targetBook != null)
                                                                   && (lVar9 = *(int64 *)
                                                                                (this + 64),
                                                                      lVar9 != null)) {
                                                                  uVar2 = *(uint32 *)(*(int64 *)
                                                                                     (this + 104) +
                                                                                   64);
                                                                  if (*(uint32 *)(lVar9 + 24) <= uVar2) {

                                                        ThrowHelper.ThrowArgumentOutOfRangeException(0);
                                                        }
                                                        if (lVar4 != null) {
                                                          Image.set_sprite(lVar4,*(uint64 *)
                                                                                   (*(int64 *)
                                                                                     (lVar9 + 16) + 32
                                                                                   + (int64)(int)uVar2
                                                                                     * 8),0);
                                                          if (this.readBookUIPanel != null) {
                                                            GameObject.SetActive
                                                                      (this.readBookUIPanel,1,0);
                                                            this.reading = 1;
                                                            lVar4 = *(int64 *)
                                                                     (*(int64 *)(DAT_181db4020 + 184)
                                                                     + 8);
                                                            if (lVar4 != null) {
                                                              if (*(int64 *)(lVar4 + 24) == 0) {
                                                                iVar3 = 0;
                                                              }
                                                              else {
                                                                if (((*(byte *)(DAT_181db4020 + 0x133) & 4
                                                                     ) != 0) &&
                                                                   (*(int *)(DAT_181db4020 + 224) == 0))
                                                                {
                                                                  il2cpp_runtime_class_init();
                                                                }
                                                                if (((*(byte *)(DAT_181db4020 + 0x133) & 4
                                                                     ) != 0) &&
                                                                   (*(int *)(DAT_181db4020 + 224) == 0))
                                                                {
                                                                  il2cpp_runtime_class_init();
                                                                }
                                                                lVar4 = *(int64 *)
                                                                         (*(int64 *)
                                                                           (DAT_181db4020 + 184) + 8);
                                                                if ((lVar4 == null) ||
                                                                   (lVar4 = *(int64 *)(lVar4 + 24),
                                                                   lVar4 == null)) throw; // [null/range check failed]
                                                                iVar3 = *(int *)(lVar4 + 20) * 5;
                                                              }
                                                              if (((*(byte *)(DAT_181d72cc8 + 0x133) & 4)
                                                                   != 0) &&
                                                                 (*(int *)(DAT_181d72cc8 + 224) == 0)) {
                                                                il2cpp_runtime_class_init(DAT_181d72cc8);
                                                              }
                                                              if (((*(byte *)(DAT_181d72cc8 + 0x133) & 4)
                                                                   != 0) &&
                                                                 (*(int *)(DAT_181d72cc8 + 224) == 0)) {
                                                                il2cpp_runtime_class_init(DAT_181d72cc8);
                                                              }
                                                              if ((GameController._instance
                                                                   != 0) &&
                                                                 (lVar4 = *(int64 *)
                                                                           (**(int64 **)
                                                                              (DAT_181d72cc8 + 184) +
                                                                           32), lVar4 != null)) {
                                                                lVar4 = WorldData.Player(lVar4,0);
                                                                if (lVar4 != null) {
                                                                  lVar4 = *(int64 *)(lVar4 + 0x150);
                                                                  if (this.targetSkill != null)
                                                                  {
                                                                    lVar9 = KungfuSkillLvData.DataBase
                                                                                      (*(int64 *)
                                                                                        (this + 184),0
                                                                                      );
                                                                    if ((lVar9 != null) && (lVar4 != null)) {
                                                                      uVar2 = *(uint32 *)(lVar9 + 48);
                                                                      if (*(uint32 *)(lVar4 + 24) <= uVar2
                                                                         ) {

                                                        ThrowHelper.ThrowArgumentOutOfRangeException(0);
                                                        }
                                                        fVar1 = *(float *)(*(int64 *)(lVar4 + 16) +
                                                                           32 + (int64)(int)uVar2 * 4
                                                                          );
                                                        if (this.targetSkill != null) {
                                                          lVar4 = KungfuSkillLvData.DataBase
                                                                            (this.targetSkill
                                                                             ,0);
                                                          if (lVar4 != null) {
                                                            this.patientNum =
                                                                 (int)fVar1 + iVar3 +
                                                                 (5 - *(int *)(lVar4 + 52)) * 20;
                                                            this.inspirationNum = 0;
                                                            if (this.targetBook != null) {
                                                              iVar3 = Mathf.CeilToInt((float)*(int *)(*(
                                                        int64 *)(this + 104) + 60) * 0.5,0);
                                                        this.mapWidth = iVar3 * 2 + 11;
                                                        if (this.targetBook != null) {
                                                          iVar3 = Mathf.FloorToInt((float)*(int *)(*(
                                                        int64 *)(this + 104) + 60) * 0.5,0);
                                                        this.mapHeight = iVar3 * 2 + 7;
                                                        if (this.readBookUIPanel != null) {
                                                          lVar4 = GameObject.get_transform
                                                                            (this.readBookUIPanel
                                                                             ,0);
                                                          if (lVar4 != null) {
                                                            lVar4 = Transform.Find(lVar4,"Scroll",0)
                                                            ;
                                                            if (lVar4 != null) {
                                                              lVar4 = Component.get_transform(lVar4,0);
                                                              puVar5 = (uint64 *)
                                                                       Vector3.get_zero(&local_38,0);
                                                              if (lVar4 != null) {
                                                                local_40 = *(uint32 *)(puVar5 + 1);
                                                                local_48 = *puVar5;
                                                                Transform.set_localPosition
                                                                          (lVar4,&local_48,0);
                                                                if (this.readBookUIPanel != null) {
                                                                  lVar4 = GameObject.get_transform
                                                                                    (*(int64 *)
                                                                                      (this + 48),0);
                                                                  if (lVar4 != null) {
                                                                    lVar4 = Transform.Find(lVar4,
                                                        "Paper",0);
                                                        if (lVar4 != null) {
                                                          local_48 = 0x3f80000000000000;
                                                          local_40 = 0x3f800000;
                                                          Transform.set_localScale(lVar4,&local_48,0);
                                                          if (this.readBookUIPanel != null) {
                                                            lVar4 = GameObject.get_transform
                                                                              (*(int64 *)
                                                                                (this + 48),0);
                                                            if (lVar4 != null) {
                                                              uVar7 = Transform.Find(lVar4,"Scroll",
                                                                                      0);
                                                              uVar7 = ShortcutExtensions.DOLocalMoveX
                                                                                (uVar7,0xc402c000,
                                                                                 0x3f800000,0,0);
                                                              uVar7 = TweenSettingsExtensions.SetEase
                                                                                (uVar7,15,DAT_181dc1128);
                                                              uVar7 = TweenSettingsExtensions.SetDelay
                                                                                (uVar7,0x3e4ccccd,
                                                                                 DAT_181dc0e10);
                                                              if (((*(byte *)(DAT_181d82a58 + 0x133) & 4)
                                                                   != 0) &&
                                                                 (*(int *)(DAT_181d82a58 + 224) == 0)) {
                                                                il2cpp_runtime_class_init(DAT_181d82a58);
                                                              }
                                                              lVar4 = *(int64 *)
                                                                       (*(int64 *)
                                                                         (DAT_181d82a58 + 184) + 8);
                                                              if (lVar4 == null) {
                                                                if (((*(byte *)(DAT_181d82a58 + 0x133) & 4
                                                                     ) != 0) &&
                                                                   (*(int *)(DAT_181d82a58 + 224) == 0))
                                                                {
                                                                  il2cpp_runtime_class_init(DAT_181d82a58)
                                                                  ;
                                                                }
                                                                uVar8 = **(uint64 **)
                                                                          (DAT_181d82a58 + 184);
                                                                lVar4 = il2cpp_internal(DAT_181dade10)
                                                                ;
                                                                OnTooltipCB.ctor(lVar4,uVar8,
                                                                                  DAT_181dab560,0);
                                                                plVar6 = (int64 *)
                                                                         (*(int64 *)
                                                                           (DAT_181d82a58 + 184) + 8);
                                                                *plVar6 = lVar4;
                                                                il2cpp_internal(plVar6,lVar4);
                                                              }
                                                              TweenSettingsExtensions.OnStart
                                                                        (uVar7,lVar4,DAT_181dc06b0);
                                                              if (this.readBookUIPanel != null) {
                                                                lVar4 = GameObject.get_transform
                                                                                  (*(int64 *)
                                                                                    (this + 48),0);
                                                                if (lVar4 != null) {
                                                                  uVar7 = Transform.Find(lVar4,
                                                        "Paper",0);
                                                        uVar7 = ShortcutExtensions.DOScaleX
                                                                          (uVar7,0x3f800000,0x3f800000,0);
                                                        uVar7 = TweenSettingsExtensions.SetEase
                                                                          (uVar7,15,DAT_181dc1128);
                                                        uVar7 = TweenSettingsExtensions.SetDelay
                                                                          (uVar7,0x3e4ccccd,DAT_181dc0e10)
                                                        ;
                                                        uVar8 = new OnTooltipCB(this,DAT_181d9b0a8,0);
                                                        TweenSettingsExtensions.OnComplete
                                                                  (uVar7,uVar8,DAT_181dc0380);
                                                        return;
                                                        }
                                                        }
                                                        }
                                                        }
                                                        }
                                                        }
                                                        }
                                                        }
                                                        }
                                                        }
                                                        }
                                                        }
                                                        }
                                                        }
                                                        }
                                                        }
                                                        }
                                                        }
                                                        }
                                                        }
                                                        }
                                                        }
                                                        }
                                                        }
                                                        }
                                                        }
                                                        }
                                                        }
                                                        }
                                                        }
                                                      }
                                                    }
                                                  }
                                                }
                                              }
                                            }
                                          }
                                        }
                                      }
                                    }
                                  }
                                }
                              }
                            }
                          }
                        }
                      }
                    }
                  }
                }
              }
            }
          }
        }
    }

    // Token : 0x6002066
    // RVA   : 0xD0D010   Offset: 0xD0C410   Length: 0x6C
    public IEnumerator StartShowText()
    {
        long lVar1;
        lVar1 = new WarpText_d__8(0,0);
        if (lVar1 != null) {
          *(uint64 *)(lVar1 + 32) = this;
          return lVar1;
        }
    }

    // Token : 0x6002067
    // RVA   : 0xD0BB90   Offset: 0xD0AF90   Length: 0xC6
    public void ShowNearText(ReadBookTextController targetText)
    {
        long lVar1;
        int iVar2;
        int iVar3;
        int iVar4;
        iVar4 = -1;
        while (targetText != null) {
          iVar2 = *(int *)(targetText + 24) + iVar4;
          if ((-1 < iVar2) && (iVar2 < this.mapWidth)) {
            iVar2 = -1;
            do {
              iVar3 = *(int *)(targetText + 28) + iVar2;
              if ((-1 < iVar3) && (iVar3 < this.mapHeight)) {
                if (this.gridUnits == null) throw; // [null/range check failed]
                lVar1 = FUN_180127f90(this.gridUnits,
                                      (int64)(*(int *)(targetText + 24) + iVar4),(int64)iVar3);
                if (lVar1 == null) throw; // [null/range check failed]
                lVar1 = GameObject.GetComponent(lVar1,DAT_181d72ab8);
                if (lVar1 == null) throw; // [null/range check failed]
                ReadBookTextController.SeeText(lVar1,0);
              }
              iVar2 = iVar2 + 1;
            } while (iVar2 < 2);
          }
          iVar4 = iVar4 + 1;
          if (1 < iVar4) {
            return;
          }
        }
    }

    // Token : 0x6002068
    // RVA   : 0xD09A40   Offset: 0xD08E40   Length: 0x4
    public void ChangePatient(int changeNum)
    {
        void FUN_180d09a40(int64 this,int changeNum)
        {
        this.patientNum = this.patientNum + changeNum;
    }

    // Token : 0x6002069
    // RVA   : 0xD09A50   Offset: 0xD08E50   Length: 0xB
    public void ChangeTotalExp(float changeExp)
    {
        void FUN_180d09a50(int64 this,float changeExp)
        {
        this.totalExp = changeExp + this.totalExp;
    }

    // Token : 0x600206A
    // RVA   : 0xD09B00   Offset: 0xD08F00   Length: 0xA43
    public void GenerateReadBookPanel()
    {
        int iVar1;
        uint uVar2;
        int iVar3;
        long lVar5;
        long lVar6;
        long lVar8;
        ulong uVar10;
        ulong uVar11;
        long lVar12;
        uint uVar15;
        uint uVar17;
        float fVar18;
        float fVar19;
        float fVar20;
        ulong local_168;
        uint local_160;
        float local_140;
        float local_130;
        ulong local_128;
        float local_120;
        ulong local_118;
        uint local_110;
        ulong local_108;
        ulong uStack_100;
        byte[] local_f8 = new byte[24];
        float local_e0;
        byte[] local_d8 = new byte[16];
        byte[] local_c8 = new byte[16];
        byte[] local_b8 = new byte[144];
        plVar4 = (int64 *)Resources.Load("Sound/SoundEffect/BigSkill0",0);
        plVar16 = (int64 *)0;
        plVar13 = plVar16;
        if ((plVar4 != (int64 *)0) && (plVar13 = (int64 *)0, *plVar4 == DAT_181daf360)) {
          plVar13 = plVar4;
        }
        NGUITools.PlaySound(plVar13,0);
        if (this.gridPool != null) {
          FUN_1812fa020(this.gridPool,DAT_181d89430);
          if (this.actingGrid != null) {
            FUN_1812fa020(this.actingGrid,DAT_181d89430);
            if (this.readBookGridRoot != null) {
              lVar5 = GameObject.get_transform(this.readBookGridRoot,0);
              if ((this.readBookTextPrefab != null) &&
                 (lVar6 = GameObject.GetComponent(this.readBookTextPrefab,DAT_181d72bc8),
                 lVar6 != null)) {
                puVar7 = (uint64 *)RectTransform.get_rect(local_f8,lVar6,0);
                local_108 = *puVar7;
                uStack_100 = puVar7[1];
                fVar18 = (float)FUN_180d995b0(&local_108,0);
                iVar3 = this.mapWidth;
                if ((this.readBookTextPrefab != null) &&
                   (lVar6 = GameObject.GetComponent(this.readBookTextPrefab,DAT_181d72bc8),
                   lVar6 != null)) {
                  puVar7 = (uint64 *)RectTransform.get_rect(local_f8,lVar6,0);
                  local_108 = *puVar7;
                  uStack_100 = puVar7[1];
                  fVar19 = (float)FUN_18044e2b0(&local_108,0);
                  if (lVar5 != null) {
                    local_168 = CONCAT44((float)(this.mapHeight + -1) * fVar19 * -0.5,
                                         (float)(iVar3 + -1) * fVar18 * -0.5);
                    local_160 = 0;
                    Transform.set_localPosition(lVar5,&local_168,0);
                    plVar4 = plVar16;
                    if (0 < this.mapHeight) {
                      do {
                        plVar13 = plVar16;
                        if (0 < this.mapWidth) {
                          do {
                            if (this.gridUnits == null) throw; // [null/range check failed]
                            lVar5 = FUN_180127f90(this.gridUnits,(int64)(int)plVar13,
                                                  (int64)(int)plVar4);
                            if ((lVar5 == null) || (lVar6 = FUN_180f93010(lVar5,0)) == null)
                            throw; // [null/range check failed]
                            GameObject.SetActive(lVar6,1,0);
                            lVar8 = GameObject.GetComponent(lVar5,DAT_181d72ab8);
                            lVar6 = this.readBookTextTypeDataBase;
                            if (lVar6 == null) throw; // [null/range check failed]
                            if (lVar6.Count == null) {
                              ThrowHelper.ThrowArgumentOutOfRangeException(0);
                            }
                            lVar6 = *(int64 *)(lVar6._items + 32);
                            if ((lVar6 == null) ||
                               (plVar9 = (int64 *)ReadBookTextTypeData.Clone(lVar6,0), lVar8 == null))
                            throw; // [null/range check failed]
                            plVar14 = plVar16;
                            if (plVar9 != (int64 *)0) {
                            }
                            *(int64 **)(lVar8 + 32) = plVar14;
                            Random.Range();
                            lVar6 = GameObject.get_transform(lVar5,0);
                            puVar7 = (uint64 *)Vector3.get_zero(local_d8,0);
                            if (lVar6 == null) throw; // [null/range check failed]
                            local_160 = *(uint32 *)(puVar7 + 1);
                            local_168 = *puVar7;
                            Transform.set_localScale(lVar6,&local_168,0);
                            uVar10 = GameObject.get_transform(lVar5,0);
                            uVar10 = ShortcutExtensions.DOScale(uVar10);
                            TweenSettingsExtensions.SetDelay(uVar10);
                            lVar6 = GameObject.get_transform(lVar5,0);
                            if (lVar6 == null) throw; // [null/range check failed]
                            puVar7 = (uint64 *)Transform.get_localPosition(local_c8,lVar6,0);
                            uVar10 = *puVar7;
                            uVar2 = *(uint32 *)(puVar7 + 1);
                            lVar6 = GameObject.get_transform(lVar5,0);
                            if (lVar6 == null) throw; // [null/range check failed]
                            puVar7 = (uint64 *)Transform.get_localPosition(local_b8,lVar6,0);
                            local_130 = *(float *)(puVar7 + 1);
                            uVar11 = *puVar7;
                            puVar7 = (uint64 *)Vector3.get_up(local_f8,0);
                            local_140 = *(float *)(puVar7 + 1);
                            local_120 = local_140 * 200.0 + local_130;
                            local_128 = CONCAT44((float)((uint64)*puVar7 >> 32) * 200.0 +
                                                 (float)((uint64)uVar11 >> 32),
                                                 (float)*puVar7 * 200.0 + (float)uVar11);
                            local_e0 = local_120;
                            Transform.set_localPosition(lVar6,&local_128,0);
                            uVar11 = GameObject.get_transform(lVar5,0);
                            local_118 = uVar10;
                            local_110 = uVar2;
                            uVar10 = ShortcutExtensions.DOLocalMove(uVar11,&local_118);
                            TweenSettingsExtensions.SetDelay(uVar10);
                            if (this.gridPool == null) throw; // [null/range check failed]
                            FUN_18181e6b0(this.gridPool,lVar5,DAT_181d893b0);
                            uVar17 = (int)plVar13 + 1;
                            plVar13 = (int64 *)(uint64)uVar17;
                          } while ((int)uVar17 < this.mapWidth);
                        }
                        uVar17 = (int)plVar4 + 1;
                        plVar4 = (int64 *)(uint64)uVar17;
                      } while ((int)uVar17 < this.mapHeight);
                    }
                    lVar6 = il2cpp_internal(DAT_181d93ce8);
                    FUN_181330100(lVar6,DAT_181d8f0b0);
                    lVar5 = this.readBookTextTypeDataBase;
                    uVar17 = 1;
                    if (lVar5 != null) {
                      lVar8 = 40;
                      while ((int)uVar17 < lVar5.Count) {
                        if ((this.targetBook == null) ||
                           (iVar3 = this.targetBook.itemLv, lVar5 == null))
                        throw; // [null/range check failed]
                        if (lVar5.Count <= uVar17) {
                          ThrowHelper.ThrowArgumentOutOfRangeException(0);
                        }
                        lVar5 = *(int64 *)(lVar5._items + lVar8);
                        if (lVar5 == null) throw; // [null/range check failed]
                        if (*(int *)(lVar5 + 44) <= iVar3) {
                          if ((this.readBookTextTypeDataBase == null) ||
                             (lVar5 = FUN_180002f80(this.readBookTextTypeDataBase,uVar17,DAT_181d9e520),
                             lVar5 == null)) throw; // [null/range check failed]
                          fVar18 = *(float *)(lVar5 + 64);
                          iVar3 = this.mapHeight;
                          iVar1 = this.mapWidth;
                          fVar19 = (float)Random.Range();
                          if ((this.readBookTextTypeDataBase == null) ||
                             (lVar5 = FUN_180002f80(this.readBookTextTypeDataBase,uVar17)) == null)
                          throw; // [null/range check failed]
                          lVar12 = this.targetBook;
                          if (*(char *)(lVar5 + 41) == false) {
                            if (lVar12 == null) throw; // [null/range check failed]
                            fVar20 = (float)lVar12.rareLv * 0.2 + 0.5;
                            fVar18 = (float)iVar3 * fVar18 * (float)iVar1;
                          }
                          else {
                            if (lVar12 == null) throw; // [null/range check failed]
                            fVar20 = (float)lVar12.rareLv * -0.2 + 1.5;
                            fVar18 = (float)iVar3 * fVar18 * (float)iVar1;
                          }
                          uVar2 = Mathf.RoundToInt(lVar12,0,fVar18 * fVar19 * fVar20);
                          iVar3 = Mathf.Max(1,uVar2);
                          plVar4 = plVar16;
                          if (0 < iVar3) {
                            do {
                              if (lVar6 == null) throw; // [null/range check failed]
                              FUN_18182a6c0(lVar6,uVar17);
                              uVar15 = (int)plVar4 + 1;
                              plVar4 = (int64 *)(uint64)uVar15;
                            } while ((int)uVar15 < iVar3);
                          }
                        }
                        lVar5 = this.readBookTextTypeDataBase;
                        uVar17 = uVar17 + 1;
                        lVar8 = lVar8 + 8;
                        if (lVar5 == null) throw; // [null/range check failed]
                      }
                      lVar8 = il2cpp_internal(DAT_181d93ce8);
                      FUN_181330100(lVar8,DAT_181d8f0b0);
                      lVar5 = this.gridPool;
                      plVar4 = plVar16;
                      if (lVar5 != null) goto LAB_180d0a324;
                    }
                  }
                }
              }
            }
          }
        }
        throw; // [null/range check failed]
        LAB_180d0a361:
        if (*(int *)(lVar8 + 24) < 1) {
          return;
        }
        if (lVar6 == null) throw; // [null/range check failed]
        if (lVar6.Count < 1) {
          return;
        }
        uVar17 = FUN_180d96040(0,*(int *)(lVar8 + 24),0);
        if (*(uint32 *)(lVar8 + 24) <= uVar17) {
          ThrowHelper.ThrowArgumentOutOfRangeException(0);
        }
        uVar17 = lVar8[uVar17];
        lVar5 = this.gridPool;
        if (lVar5 == null) throw; // [null/range check failed]
        if (lVar5.Count <= uVar17) {
          ThrowHelper.ThrowArgumentOutOfRangeException(0);
        }
        lVar5 = lVar5._items[uVar17];
        if (lVar5 == null) throw; // [null/range check failed]
        lVar12 = GameObject.GetComponent(lVar5,DAT_181d72ab8);
        lVar5 = this.readBookTextTypeDataBase;
        if (lVar6.Count == null) {
          ThrowHelper.ThrowArgumentOutOfRangeException(0);
        }
        if (lVar5 == null) throw; // [null/range check failed]
        uVar15 = *(uint32 *)(lVar6._items + 32);
        if (lVar5.Count <= uVar15) {
          ThrowHelper.ThrowArgumentOutOfRangeException(0);
        }
        lVar5 = lVar5._items[uVar15];
        if ((lVar5 == null) || (plVar4 = (int64 *)ReadBookTextTypeData.Clone(lVar5,0), lVar12 == null))
        throw; // [null/range check failed]
        plVar13 = plVar16;
        if (plVar4 != (int64 *)0) {
        }
        lVar12.name = plVar13;
        FUN_1817ef410(lVar8,uVar17,DAT_181d8f630);
        FUN_1817ef380(lVar6,0);
        goto LAB_180d0a361;
        while( true ) {
          if (lVar8 == null) break;
          FUN_18182a6c0(lVar8,plVar4);
          lVar5 = this.gridPool;
          plVar4 = (int64 *)(uint64)((int)plVar4 + 1);
          if (lVar5 == null) break;
        LAB_180d0a324:
          if (lVar5.Count <= (int)plVar4) {
            if (lVar8 != null) goto LAB_180d0a361;
            break;
          }
        }
    }

    // Token : 0x600206B
    // RVA   : 0xD0B9D0   Offset: 0xD0ADD0   Length: 0x12E
    public void ResetAll()
    {
        long lVar1;
        long lVar2;
        uint uVar3;
        lVar1 = this.gridPool;
        uVar3 = 0;
        this.totalExp = 0;
        this.textReaded = 0;
        if (lVar1 != null) {
          lVar2 = 32;
          while( true ) {
            if (lVar1.Count <= (int)uVar3) {
              FUN_1812fa020(lVar1,DAT_181d89430);
              return;
            }
            if (lVar1 == null) break;
            if (lVar1.Count <= uVar3) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            lVar1 = *(int64 *)(lVar2 + lVar1._items);
            if (lVar1 == null) break;
            GameObject.SetActive(lVar1,0,0);
            lVar1 = this.gridPool;
            if (lVar1 == null) break;
            if (lVar1.Count <= uVar3) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            if ((*(int64 *)(lVar2 + lVar1._items) == 0) ||
               (lVar1 = GameObject.GetComponent()) == null) break;
            ReadBookTextController.Reset(lVar1);
            lVar1 = this.gridPool;
            uVar3 = uVar3 + 1;
            lVar2 = lVar2 + 8;
            if (lVar1 == null) break;
          }
        }
    }

    // Token : 0x600206C
    // RVA   : 0xD09A60   Offset: 0xD08E60   Length: 0x9F
    public void FinishRead()
    {
        var pStatics = *(int64*)(DAT_181da8728 + 184);
        if (*pStatics != 0) {
          SureMenu.CallSureMenu
                    (*pStatics,"确认结束阅读吗？","SureFinishRead",0,"ReadBookController",0);
          return;
        }
    }

    // Token : 0x600206D
    // RVA   : 0xD0D080   Offset: 0xD0C480   Length: 0x91D
    public void SureFinishRead()
    {
        uint uVar1;
        uint uVar2;
        ulong uVar4;
        ulong uVar5;
        ulong uVar6;
        long lVar7;
        long lVar8;
        long lVar9;
        long lVar13;
        float fVar14;
        float fVar15;
        uint[] local_res8 = new uint[2];
        float[] local_res18 = new float[2];
        ulong in_stack_ffffffffffffff58;
        uint uVar16;
        ulong local_58;
        ulong uStack_50;
        uVar16 = (uint32)((uint64)in_stack_ffffffffffffff58 >> 32);
        this.reading = 0;
        if (this.readBookUIPanel == null) throw; // [null/range check failed]
        GameObject.SetActive(this.readBookUIPanel,0,0);
        plVar3 = (int64 *)Resources.Load("Sound/SoundEffect/OpenBook",0);
        plVar12 = (int64 *)0;
        plVar10 = plVar12;
        if ((plVar3 != (int64 *)0) && (plVar10 = (int64 *)0, *plVar3 == DAT_181daf360)) {
          plVar10 = plVar3;
        }
        NGUITools.PlaySound(plVar10,0);
        plVar3 = &this.targetPracticeExpData;
        if (this.targetPracticeExpData == null) {
          if (this.targetSkill == null) throw; // [null/range check failed]
          uVar1 = this.targetSkill.skillID;
          this.targetPracticeExpData = new SkillMaxPracticeExpData(uVar1,0);
          il2cpp_internal(plVar3,lVar7);
          if (((this.targetPracticeExpData == null) || (this.targetBook == null)) ||
             (lVar7 = this.targetPracticeExpData.maxReadExp) == null) throw; // [null/range check failed]
          FUN_18182a350(lVar7,this.targetBook.rareLv,
                        this.totalExp,DAT_181da1110);
          if (((GameController._instance == null) ||
              (lVar7 = GameController._instance.worldData) == null) ||
             (lVar7 = WorldData.Player(lVar7,0)) == null) throw; // [null/range check failed]
          HeroData.AddSkillMaxPracticeExp(lVar7,this.targetPracticeExpData,0);
        LAB_180d0d401:
          lVar7 = **(int64 **)(DAT_181d7f6c0 + 184);
          if (this.targetBook == null) throw; // [null/range check failed]
          uVar4 = ItemData.Name(this.targetBook,1,0);
          uVar5 = Single.ToString(this + 120,"f0",0);
          if (this.targetBook == null) throw; // [null/range check failed]
          uVar6 = ItemData.GetBookRareLvName(this.targetBook,0);
          uVar4 = String.Format("《{0}》新的{2}阅读最高纪录：{1}点",uVar4,uVar5,uVar6,0);
          if (lVar7 == null) throw; // [null/range check failed]
          in_stack_ffffffffffffff60 = &local_58;
          local_58 = 0;
          uStack_50 = 0;
          InfoController.AddInfoTab
                    (lVar7,uVar4,"UIAtlas","从事工作_学习","PencilWriting",0x3f800000,
                     CONCAT44(uVar16,0x40a00000),in_stack_ffffffffffffff60,0);
        }
        else {
          if ((this.targetBook == null) || (lVar7 = this.targetPracticeExpData.maxReadExp) == null)
          throw; // [null/range check failed]
          uVar2 = this.targetBook.rareLv;
          if (lVar7.Count <= uVar2) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          fVar14 = this.totalExp;
          pfVar11 = (float *)(lVar7._items + 32 + (int64)(int)uVar2 * 4);
          if (*pfVar11 <= fVar14 && fVar14 != *pfVar11) {
            if (((this.targetPracticeExpData == null) || (this.targetBook == null)) ||
               (lVar7 = this.targetPracticeExpData.maxReadExp) == null) throw; // [null/range check failed]
            FUN_18182a350(lVar7,this.targetBook.rareLv,fVar14,DAT_181da1110
                         );
            goto LAB_180d0d401;
          }
        }
        pfVar11 = &this.totalExp;
        lVar7 = *(int64 *)(*(int64 *)(DAT_181d91ba0 + 184) + 24);
        if ((lVar7 != null) && (lVar7 = PlotController.GetAreaAvailableHelpHero(lVar7,0)) != null) {
          if (0 < lVar7.Count) {
            fVar14 = (float)Random.get_value(0);
            fVar15 = (float)Mathf.Min(0x3e800000,(float)lVar7.Count * 0.025 + 0.05,0);
            if (fVar14 <= fVar15) {
              uVar16 = lVar7.Count;
              uVar2 = GlobalData.RandomRange(0,uVar16,0,0);
              if (lVar7.Count <= uVar2) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              lVar7 = lVar7._items[uVar2];
              if (lVar7 != null) {
                lVar13 = lVar7.monthFreshBountyTime;
                if (((this.targetSkill != null) &&
                    (lVar8 = KungfuSkillLvData.DataBase(this.targetSkill,0)) != null) &&
                   (lVar13 != null)) {
                  uVar2 = *(uint32 *)(lVar8 + 48);
                  if (*(uint32 *)(lVar13 + 24) <= uVar2) {
                    ThrowHelper.ThrowArgumentOutOfRangeException(0);
                  }
                  fVar14 = lVar13[uVar2] *
                           0.01;
                  this.totalExp = (fVar14 + 1.0) * this.totalExp;
                  lVar8 = FUN_18046c400(0);
                  lVar13 = lVar7.monthFreshBountyTime;
                  if (((this.targetSkill != null) &&
                      (lVar9 = KungfuSkillLvData.DataBase(this.targetSkill,0)) != null)
                     && (lVar13 != null)) {
                    uVar2 = *(uint32 *)(lVar9 + 48);
                    if (*(uint32 *)(lVar13 + 24) <= uVar2) {
                      ThrowHelper.ThrowArgumentOutOfRangeException(0);
                    }
                    local_res8[0] =
                         lVar13[uVar2];
                    uVar4 = il2cpp_value_box(DAT_181da22f0,local_res8);
                    lVar13 = *(int64 *)(*(int64 *)(DAT_181d73d40 + 184) + 0x4a0);
                    if (((this.targetSkill != null) &&
                        (lVar9 = KungfuSkillLvData.DataBase(this.targetSkill,0)) != null
                        ) && (lVar13 != null)) {
                      uVar2 = *(uint32 *)(lVar9 + 48);
                      if (*(uint32 *)(lVar13 + 24) <= uVar2) {
                        ThrowHelper.ThrowArgumentOutOfRangeException(0);
                      }
                      local_res18[0] = fVar14 * 100.0;
                      uVar5 = *(uint64 *)
                               (*(int64 *)(lVar13 + 16) + 32 + (int64)(int)uVar2 * 8);
                      uVar6 = il2cpp_value_box(DAT_181da22f0,local_res18);
                      uVar4 = String.Format("这秘籍中有些晦涩难懂之处，我来给#PlayerName#讲解讲解好了。\n(对方{0}点{1}技能，经验额外增加{2}%)",uVar4,uVar5,uVar6,0);
                      uVar5 = Int32.ToString(lVar7 + 88,0);
                      uVar6 = il2cpp_internal(DAT_181da24f0);
                      SinglePlotData.ctor
                                (uVar6,uVar4,0,3,uVar5,3,"0",
                                 (uint64)in_stack_ffffffffffffff60 & 0xffffffff00000000,"PlotGetReadTotalExp",0
                                 ,0,0,0,0,0);
                      if (lVar8 != null) {
                        PlotController.AddPlot(lVar8,uVar6,0);
                        return;
                      }
                    }
                  }
                }
              }
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
          }
          ReadBookController.GetReadExp(this);
          lVar7 = this.gridPool;
          this.totalExp = 0.0;
          this.textReaded = 0;
          if (lVar7 != null) {
            lVar13 = 32;
            while( true ) {
              uVar2 = (uint32)plVar12;
              if (lVar7.Count <= (int)uVar2) {
                FUN_1812fa020(lVar7,DAT_181d89430);
                return;
              }
              if (lVar7 == null) break;
              if (lVar7.Count <= uVar2) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              lVar7 = *(int64 *)(lVar13 + lVar7._items);
              if (lVar7 == null) break;
              GameObject.SetActive(lVar7,0,0);
              lVar7 = this.gridPool;
              if (lVar7 == null) break;
              if (lVar7.Count <= uVar2) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              if ((*(int64 *)(lVar13 + lVar7._items) == 0) ||
                 (lVar7 = GameObject.GetComponent()) == null) break;
              ReadBookTextController.Reset(lVar7);
              lVar7 = this.gridPool;
              plVar12 = (int64 *)(uint64)(uVar2 + 1);
              lVar13 = lVar13 + 8;
              if (lVar7 == null) break;
            }
          }
        }
    }

    // Token : 0x600206E
    // RVA   : 0xD0AC60   Offset: 0xD0A060   Length: 0x13B
    public void GetTotalExp()
    {
        long lVar1;
        long lVar2;
        uint uVar3;
        ReadBookController.GetReadExp(this,this.totalExp,0);
        lVar1 = this.gridPool;
        uVar3 = 0;
        this.totalExp = 0;
        this.textReaded = 0;
        if (lVar1 != null) {
          lVar2 = 32;
          while( true ) {
            if (lVar1.Count <= (int)uVar3) {
              FUN_1812fa020(lVar1,DAT_181d89430);
              return;
            }
            if (lVar1 == null) break;
            if (lVar1.Count <= uVar3) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            lVar1 = *(int64 *)(lVar2 + lVar1._items);
            if (lVar1 == null) break;
            GameObject.SetActive(lVar1,0,0);
            lVar1 = this.gridPool;
            if (lVar1 == null) break;
            if (lVar1.Count <= uVar3) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            if ((*(int64 *)(lVar2 + lVar1._items) == 0) ||
               (lVar1 = GameObject.GetComponent()) == null) break;
            ReadBookTextController.Reset(lVar1);
            lVar1 = this.gridPool;
            uVar3 = uVar3 + 1;
            lVar2 = lVar2 + 8;
            if (lVar1 == null) break;
          }
        }
    }

    // Token : 0x600206F
    // RVA   : 0xD0A550   Offset: 0xD09950   Length: 0x70F
    public void GetReadExp(float targetExp)
    {
        long lVar1;
        bool cVar2;
        int iVar3;
        long lVar4;
        ulong uVar5;
        long lVar6;
        int iVar7;
        lVar6 = **(int64 **)(DAT_181da4468 + 184);
        if ((GameController._instance == null) ||
           (lVar4 = GameController._instance.worldData) == null)
        throw; // [null/range check failed]
        lVar4 = WorldData.Player(lVar4,0);
        if ((this.targetBook == null) ||
           ((lVar1 = this.targetBook.bookData, lVar1 == null || (lVar4 == null))))
        throw; // [null/range check failed]
        uVar5 = HeroData.FindSkill(lVar4,*(uint32 *)(lVar1 + 16),0);
        if (lVar6 == null) throw; // [null/range check failed]
        SpeShowController.ShowGetSkillExp(lVar6,uVar5);
        lVar6 = GameController._instance;
        if ((this.targetBook == null) ||
           (lVar4 = this.targetBook.bookData) == null) throw; // [null/range check failed]
        uVar5 = Int32.ToString(lVar4 + 16,0);
        if (lVar6 == null) throw; // [null/range check failed]
        GameController.CheckPlotTrigger(lVar6,6,uVar5,999999,0);
        lVar6 = *(int64 *)(*(int64 *)(DAT_181d91ba0 + 184) + 24);
        if (lVar6 == null) throw; // [null/range check failed]
        cVar2 = PlotController.HaveNoPlotWait(lVar6,0);
        if (cVar2) {
          iVar7 = 0;
          do {
            if ((GameController._instance == null) ||
               (lVar6 = GameController._instance.worldData) == null)
            throw; // [null/range check failed]
            lVar6 = WorldData.Player(lVar6,0);
            if ((lVar6 == null) || (*(int64 *)(lVar6 + 0x2e8) == 0)) throw; // [null/range check failed]
            if (*(int *)(*(int64 *)(lVar6 + 0x2e8) + 24) <= iVar7) break;
            lVar6 = FUN_18046c0a0(0);
            if ((lVar6 == null) || (lVar6.villageAreaID == null)) throw; // [null/range check failed]
            lVar6 = WorldData.Player(lVar6.villageAreaID,0);
            if ((lVar6 == null) || (*(int64 *)(lVar6 + 0x2e8) == 0)) throw; // [null/range check failed]
            lVar6 = FUN_180002f80(*(int64 *)(lVar6 + 0x2e8),iVar7,DAT_181d94ca0);
            if ((lVar6 = lVar6?.WorldEventDatasSaveRecord) == null) throw; // [null/range check failed]
            if (lVar6.cityAreaID == null) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            lVar6 = *(int64 *)(lVar6.chapter + 32);
            if (lVar6 == null) throw; // [null/range check failed]
            if (lVar6.forceAreaID == 7) {
              lVar6 = FUN_18046c0a0(0);
              if ((lVar6 == null) || (lVar6.villageAreaID == null)) throw; // [null/range check failed]
              lVar6 = WorldData.Player(lVar6.villageAreaID,0);
              if ((lVar6 == null) || (*(int64 *)(lVar6 + 0x2e8) == 0)) throw; // [null/range check failed]
              lVar6 = FUN_180002f80(*(int64 *)(lVar6 + 0x2e8),iVar7,DAT_181d94ca0);
              if ((lVar6 = lVar6?.WorldEventDatasSaveRecord) == null) throw; // [null/range check failed]
              if (lVar6.cityAreaID == null) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              lVar6 = *(int64 *)(lVar6.chapter + 32);
              if (lVar6 == null) throw; // [null/range check failed]
              iVar3 = Int32.Parse(lVar6.Areas);
              if ((this.targetBook == null) ||
                 (lVar6 = this.targetBook.bookData) == null)
              throw; // [null/range check failed]
              if (iVar3 == lVar6.chapter) goto LAB_180d0aa7a;
            }
            iVar7 = iVar7 + 1;
          } while( true );
        }
        goto LAB_180d0ab57;
        LAB_180d0aa7a:
        lVar6 = FUN_18046c400(0);
        lVar4 = FUN_18046c0a0(0);
        if ((lVar4 == null) || (lVar4.villageAreaID == null)) throw; // [null/range check failed]
        lVar4 = WorldData.Player(lVar4.villageAreaID,0);
        if ((lVar4 == null) || (*(int64 *)(lVar4 + 0x2e8) == 0)) throw; // [null/range check failed]
        lVar4 = FUN_180002f80(*(int64 *)(lVar4 + 0x2e8),iVar7,DAT_181d94ca0);
        if ((lVar4 = lVar4?.WorldEventDatasSaveRecord) == null) throw; // [null/range check failed]
        if (lVar4.cityAreaID == null) {
          ThrowHelper.ThrowArgumentOutOfRangeException(0);
        }
        lVar4 = *(int64 *)(lVar4.chapter + 32);
        if ((lVar4 == null) || (lVar6 == null)) throw; // [null/range check failed]
        PlotController.AddPlotEvent(lVar6,lVar4.villageAreaID,0);
        LAB_180d0ab57:
        if ((GameController._instance != null) &&
           (lVar6 = GameController._instance.worldData) != null) {
          lVar6 = WorldData.Player(lVar6,0);
          if ((this.targetBook != null) &&
             (lVar4 = this.targetBook.bookData) != null) {
            lVar4 = BookData.DataBase(lVar4,0);
            if ((lVar4 != null) && (lVar6 != null)) {
              HeroData.AddTag(lVar6,0x162);
              return;
            }
          }
        }
    }

    // Token : 0x6002070
    // RVA   : 0xD0BB00   Offset: 0xD0AF00   Length: 0x88
    public IEnumerator SeeAndReadText(GameObject target)
    {
        long lVar1;
        lVar1 = new WarpText_d__8(0,0);
        if (lVar1 != null) {
          *(uint64 *)(lVar1 + 40) = this;
          *(uint64 *)(lVar1 + 32) = target;
          return lVar1;
        }
    }

    // Token : 0x6002071
    // RVA   : 0xD0C800   Offset: 0xD0BC00   Length: 0x80F
    public void StartReadBook(HeroData _targetHero, ItemData _targetBookData, bool targetCostContribution, bool readCostMoney)
    {
        void ReadBookController.StartReadBook
                     (int64 this,int64 _targetHero,int64 _targetBookData,uint8 targetCostContribution,
                     uint8 readCostMoney)
        {
        int64 *plVar1;
        float fVar2;
        uint32 uVar3;
        char cVar4;
        int iVar5;
        int64 lVar6;
        int64 *plVar7;
        int64 lVar8;
        int64 lVar9;
        uint64 uVar10;
        uint64 uVar11;
        int64 *plVar12;
        float local_res10 [2];
        uint32 local_38;
        uint32 local_34 [7];
        local_res10[0] = 0.0;
        if (_targetHero == null) throw; // [null/range check failed]
        if (*(int *)(_targetHero + 88) == 0) {
          this.targetHero = _targetHero;
          this.tempBookData = _targetBookData;
          this.costMoeny = readCostMoney;
          *(uint8 *)(this + 200) = targetCostContribution;
          if (((*plVar12 == 0) || (lVar6 = *(int64 *)(*plVar12 + 112)) == null) || (*plVar7 == 0))
          throw; // [null/range check failed]
          lVar6 = HeroData.FindSkill(*plVar7,*(uint32 *)(lVar6 + 16),0);
          this.targetSkill = lVar6;
          lVar6 = *plVar1;
          if ((lVar6 == null) || (*(int *)(lVar6 + 20) < 10)) {
            if (*(char *)(this + 200) == false) {
        LAB_180d0cb92:
              lVar6 = **(int64 **)(DAT_181da8728 + 184);
              plVar7 = (int64 *)FUN_1800d60b0(DAT_181da4138,5);
              if ((*plVar12 == 0) || (lVar8 = ItemData.Name(*plVar12,1,0), plVar7 == (int64 *)0)) {
        LAB_180d0d00a:
                          // WARNING: Subroutine does not return
                FUN_1800d6620();
              }
              if ((lVar8 != null) &&
                 (lVar9 = il2cpp_internal(lVar8,*(uint64 *)(*plVar7 + 64))) == null) {
                uVar11 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar11,0);
              }
              if ((int)plVar7[3] == 0) {
                uVar11 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar11,0);
              }
              plVar7[4] = lVar8;
              il2cpp_internal(plVar7 + 4,lVar8);
              if (*plVar12 == 0) goto LAB_180d0d00a;
              lVar8 = ItemData.GetBookRareLvName(*plVar12,0);
              if ((lVar8 != null) &&
                 (lVar9 = il2cpp_internal(lVar8,*(uint64 *)(*plVar7 + 64))) == null) {
                uVar11 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar11,0);
              }
              if (*(uint32 *)(plVar7 + 3) < 2) {
                uVar11 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar11,0);
              }
              plVar7[5] = lVar8;
              il2cpp_internal(plVar7 + 5,lVar8);
              if ((*plVar12 == 0) || (lVar8 = *(int64 *)(*plVar12 + 112)) == null)
              goto LAB_180d0d00a;
              local_38 = BookData.ReadDayCost(lVar8,0);
              lVar8 = il2cpp_value_box(DAT_181d80430,&local_38);
              if ((lVar8 != null) &&
                 (lVar9 = il2cpp_internal(lVar8,*(uint64 *)(*plVar7 + 64))) == null) {
                uVar11 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar11,0);
              }
              if (*(uint32 *)(plVar7 + 3) < 3) {
                uVar11 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar11,0);
              }
              plVar7[6] = lVar8;
              il2cpp_internal(plVar7 + 6,lVar8);
              uVar11 = "确认阅读《{0}{1}》？\n(消耗{2}天{3}){4}";
              lVar8 = "";
              if (this.costMoeny) {
                if ((*plVar12 == 0) || (lVar8 = *(int64 *)(*plVar12 + 112)) == null) {
                          // WARNING: Subroutine does not return
                  FUN_1800d6620();
                }
                local_34[0] = BookData.ReadMoneyCost(lVar8,0);
                uVar10 = il2cpp_value_box(DAT_181d80430,local_34);
                lVar8 = String.Format("和{0}银钱",uVar10,0);
              }
              if ((lVar8 != null) &&
                 (lVar9 = il2cpp_internal(lVar8,*(uint64 *)(*plVar7 + 64))) == null) {
                uVar11 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar11,0);
              }
              if (*(uint32 *)(plVar7 + 3) < 4) {
                uVar11 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar11,0);
              }
              plVar7[7] = lVar8;
              il2cpp_internal(plVar7 + 7,lVar8);
              lVar8 = "";
              if ((*plVar1 != 0) &&
                 (cVar4 = KungfuSkillLvData.BookExpFull(*plVar1,0), lVar8 = "", cVar4)
                 ) {
                if (*plVar1 == 0) throw; // [null/range check failed]
                cVar4 = KungfuSkillLvData.FightExpFull(*plVar1,0);
                lVar8 = "\n(武功经验已满，需在闭关室进行突破！)";
                if (!cVar4) {
                  if (*plVar1 == 0) throw; // [null/range check failed]
                  local_res10[0] = (float)KungfuSkillLvData.GetSkillExpExchangeRate(*plVar1,0);
                  local_res10[0] = local_res10[0] * 100.0;
                  uVar10 = Single.ToString(local_res10,"f0",0);
                  lVar8 = String.Format("\n(武功理论经验已满，将以{0}%比例转化为实战经验)",uVar10,0);
                }
              }
              if ((lVar8 != null) &&
                 (lVar9 = il2cpp_internal(lVar8,*(uint64 *)(*plVar7 + 64))) == null) {
                uVar11 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar11,0);
              }
              if (*(uint32 *)(plVar7 + 3) < 5) {
                uVar11 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar11,0);
              }
              plVar7[8] = lVar8;
              il2cpp_internal(plVar7 + 8,lVar8);
              uVar11 = String.Format(uVar11,plVar7,0);
              if (lVar6 != null) {
                SureMenu.CallSureMenu(lVar6,uVar11,"SureStartReadBook",0,"ReadBookController",1,0);
                plVar7 = (int64 *)Resources.Load("Sound/SoundEffect/OpenBook",0);
                plVar12 = (int64 *)0;
                if ((plVar7 != (int64 *)0) && (*plVar7 == DAT_181daf360)) {
                  plVar12 = plVar7;
                }
                NGUITools.PlaySound(plVar12,0);
                return;
              }
              throw; // [null/range check failed]
            }
            lVar8 = *plVar7;
            if ((lVar8 == null) || (lVar9 = *plVar12) == null) throw; // [null/range check failed]
            if (*(int *)(lVar8 + 184) < *(int *)(lVar9 + 60)) {
              lVar6 = FUN_18046c0a0(0);
              lVar8 = *(int64 *)(*(int64 *)(DAT_181d73d40 + 184) + 0x3d8);
              if ((*plVar7 == 0) || (lVar8 == null)) throw; // [null/range check failed]
              uVar3 = *(uint32 *)(*plVar7 + 184);
              if (*(uint32 *)(lVar8 + 24) <= uVar3) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              uVar11 = String.Format("{0}无权参阅",
                                      *(uint64 *)
                                       (*(int64 *)(lVar8 + 16) + 32 + (int64)(int)uVar3 * 8),0);
            }
            else {
              if ((lVar6 != null) ||
                 (fVar2 = *(float *)(lVar8 + 0x1c0),
                 iVar5 = ItemData.GetReadBookContributionCost(lVar9,0), (float)iVar5 <= fVar2))
              goto LAB_180d0cb92;
              lVar6 = FUN_18046c0a0(0);
              uVar11 = "功绩不足！";
            }
          }
          else {
            lVar6 = FUN_18046c0a0(0);
            uVar11 = "武学等级已满！";
          }
        }
        else {
          lVar6 = GameController._instance;
          uVar11 = "队友无法阅读秘籍！";
        }
        if (lVar6 != null) {
          GameController.ShowTextOnMouse(lVar6,uVar11,0);
          return;
        }
    }

    // Token : 0x6002072
    // RVA   : 0xD0D9A0   Offset: 0xD0CDA0   Length: 0x388
    public void SureStartReadBook()
    {
        long lVar1;
        int iVar2;
        int iVar3;
        uint uVar4;
        long lVar5;
        ulong uVar7;
        if (this.costMoeny) {
          if ((GameController._instance == null) ||
             (lVar5 = GameController._instance.worldData) == null)
          throw; // [null/range check failed]
          lVar5 = WorldData.Player(lVar5,0);
          if ((lVar5 == null) || (lVar5.speBookStorageSpeAdd == null)) throw; // [null/range check failed]
          iVar3 = *(int *)(lVar5.speBookStorageSpeAdd + 24);
          if ((this.tempBookData == null) ||
             (lVar5 = this.tempBookData.bookData) == null)
          throw; // [null/range check failed]
          iVar2 = BookData.ReadMoneyCost(lVar5,0);
          if (iVar3 < iVar2) {
            lVar5 = FUN_18046c0a0(0);
            if (lVar5 != null) {
              GameController.ShowTextOnMouse(lVar5,"银钱不足！",0);
              plVar6 = (int64 *)Resources.Load("Sound/SoundEffect/WrongClick",0);
              plVar8 = (int64 *)0;
              if ((plVar6 != (int64 *)0) && (*plVar6 == DAT_181daf360)) {
                plVar8 = plVar6;
              }
              NGUITools.PlaySound(plVar8,0);
              return;
            }
            throw; // [null/range check failed]
          }
          lVar5 = FUN_18046c0a0(0);
          if ((lVar5 == null) || (lVar5.villageAreaID == null)) throw; // [null/range check failed]
          lVar5 = WorldData.Player(lVar5.villageAreaID,0);
          if ((this.tempBookData == null) ||
             (lVar1 = this.tempBookData.bookData) == null)
          throw; // [null/range check failed]
          iVar3 = BookData.ReadMoneyCost(lVar1,0);
          if (lVar5 == null) throw; // [null/range check failed]
          HeroData.ChangeMoney(lVar5,-iVar3,1,0);
        }
        lVar5 = *(int64 *)(*(int64 *)(DAT_181db5e00 + 184) + 8);
        if (this.tempBookData != null) {
          uVar7 = ItemData.Name(this.tempBookData,1,0);
          uVar7 = String.Format("阅读《{0}》",uVar7,0);
          if ((this.tempBookData != null) &&
             (lVar1 = this.tempBookData.bookData) != null) {
            uVar4 = BookData.ReadDayCost(lVar1,0);
            if (lVar5 != null) {
              WorkingUIController.StartWorking(lVar5,uVar7,uVar4,0,0,"RealStartReadBook",0,0);
              return;
            }
          }
        }
    }

    // Token : 0x6002073
    // RVA   : 0xD0B230   Offset: 0xD0A630   Length: 0x79D
    public void RealStartReadBook()
    {
        var pStatics_3d40 = *(int64*)(DAT_181d73d40 + 184);
        uint uVar1;
        uint uVar2;
        long lVar3;
        ulong uVar4;
        long lVar6;
        long lVar7;
        float[] local_res18 = new float[2];
        float[] local_res20 = new float[2];
        lVar3 = *(int64 *)(*(int64 *)(DAT_181db5e00 + 184) + 8);
        if (lVar3 != null) {
          if (!lVar3.activeTimeLeft) {
            return;
          }
          if (((GameController._instance != null) &&
              (lVar3 = GameController._instance.worldData) != null) &&
             (lVar3 = WorldData.Player(lVar3,0)) != null) {
            HeroData.ManageGetItemPoison(lVar3,this.tempBookData,1,0x3fc00000,1,0);
            lVar3 = this.targetSkill;
            if (lVar3 == null) {
              if (*(char *)(this + 200) != false) {
                lVar3 = this.targetHero;
                if ((this.tempBookData == null) ||
                   (ItemData.GetReadBookContributionCost(this.tempBookData,0,0), lVar3 == null))
                throw; // [null/range check failed]
                HeroData.ChangeForceContribution(lVar3);
              }
              if ((this.tempBookData == null) ||
                 (lVar3 = this.tempBookData.bookData) == null)
              throw; // [null/range check failed]
              uVar1 = lVar3.skillID;
              this.targetSkill = new KungfuSkillLvData(uVar1,0);
              if (this.targetHero == null) throw; // [null/range check failed]
              HeroData.GetSkill(this.targetHero,this.targetSkill,1,0,0);
              lVar3 = this.targetSkill;
              if (lVar3 == null) throw; // [null/range check failed]
            }
            if (this.targetHero != null) {
              uVar4 = HeroData.GetSkillMaxPracticeExp
                                (this.targetHero,lVar3.skillID,0);
              this.targetPracticeExpData = uVar4;
              if (this.targetPracticeExpData != null) {
                if ((this.tempBookData == null) ||
                   (lVar3 = this.targetPracticeExpData.maxReadExp) == null)
                throw; // [null/range check failed]
                uVar2 = this.tempBookData.rareLv;
                if (lVar3.fightExp <= uVar2) {
                  ThrowHelper.ThrowArgumentOutOfRangeException(0);
                }
                if (0.0 < lVar3.skillID[uVar2]) {
                  lVar3 = **(int64 **)(DAT_181da8728 + 184);
                  plVar5 = (int64 *)FUN_1800d60b0(DAT_181da4138,5);
                  if ((this.tempBookData != null) &&
                     (lVar6 = ItemData.Name(this.tempBookData,1,0), plVar5 != (int64 *)0
                     )) {
                    if ((lVar6 != null) &&
                       (lVar7 = il2cpp_internal(lVar6,*(uint64 *)(*plVar5 + 64))) == null) {
                      uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                      FUN_1800d65f0(uVar4,0);
                    }
                    if ((int)plVar5[3] == 0) {
                      uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                      FUN_1800d65f0(uVar4,0);
                    }
                    plVar5[4] = lVar6;
                    il2cpp_internal(plVar5 + 4,lVar6);
                    if (((this.targetPracticeExpData != null) && (this.tempBookData != null)) &&
                       (lVar6 = this.targetPracticeExpData.maxReadExp) != null) {
                      uVar2 = this.tempBookData.rareLv;
                      if (*(uint32 *)(lVar6 + 24) <= uVar2) {
                        ThrowHelper.ThrowArgumentOutOfRangeException(0);
                      }
                      local_res18[0] =
                           lVar6[uVar2];
                      lVar6 = Single.ToString(local_res18,"f0",0);
                      if ((lVar6 != null) &&
                         (lVar7 = il2cpp_internal(lVar6,*(uint64 *)(*plVar5 + 64))) == null)
                      {
                        uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                        FUN_1800d65f0(uVar4,0);
                      }
                      if (*(uint32 *)(plVar5 + 3) < 2) {
                        uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                        FUN_1800d65f0(uVar4,0);
                      }
                      plVar5[5] = lVar6;
                      il2cpp_internal(plVar5 + 5,lVar6);
                      local_res20[0] = *(float *)(pStatics_3d40 + 0x160) * 100.0;
                      lVar6 = il2cpp_value_box(DAT_181da22f0,local_res20);
                      if ((lVar6 != null) &&
                         (lVar7 = il2cpp_internal(lVar6,*(uint64 *)(*plVar5 + 64))) == null)
                      {
                        uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                        FUN_1800d65f0(uVar4,0);
                      }
                      if (*(uint32 *)(plVar5 + 3) < 3) {
                        uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                        FUN_1800d65f0(uVar4,0);
                      }
                      plVar5[6] = lVar6;
                      il2cpp_internal(plVar5 + 6,lVar6);
                      if (((this.targetPracticeExpData != null) && (this.tempBookData != null))
                         && (lVar6 = this.targetPracticeExpData.maxReadExp) != null) {
                        uVar2 = this.tempBookData.rareLv;
                        if (*(uint32 *)(lVar6 + 24) <= uVar2) {
                          ThrowHelper.ThrowArgumentOutOfRangeException(0);
                        }
                        local_res18[0] =
                             lVar6[uVar2] *
                             *(float *)(pStatics_3d40 + 0x160);
                        lVar6 = Single.ToString(local_res18,"f0",0);
                        if ((lVar6 != null) &&
                           (lVar7 = il2cpp_internal(lVar6,*(uint64 *)(*plVar5 + 64)), lVar7 == null
                           )) {
                          uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                          FUN_1800d65f0(uVar4,0);
                        }
                        if (*(uint32 *)(plVar5 + 3) < 4) {
                          uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                          FUN_1800d65f0(uVar4,0);
                        }
                        plVar5[7] = lVar6;
                        il2cpp_internal(plVar5 + 7,lVar6);
                        if (this.tempBookData != null) {
                          lVar6 = ItemData.GetBookRareLvName(this.tempBookData,0);
                          if ((lVar6 != null) &&
                             (lVar7 = il2cpp_internal(lVar6,*(uint64 *)(*plVar5 + 64)),
                             lVar7 == null)) {
                            uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                            FUN_1800d65f0(uVar4,0);
                          }
                          if (*(uint32 *)(plVar5 + 3) < 5) {
                            uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                            FUN_1800d65f0(uVar4,0);
                          }
                          plVar5[8] = lVar6;
                          il2cpp_internal(plVar5 + 8,lVar6);
                          uVar4 = String.Format("是否自动阅读《{0}》？\n当前{4}最高经验纪录{1}点\n自动练习可得{2}%({3}点)",plVar5,0);
                          if (lVar3 != null) {
                            SureMenu.CallSureMenu
                                      (lVar3,uVar4,"AutoReadBook",0,"ReadBookController",1,0,"ShowReadBookPanel",0,0);
                            return;
                          }
                        }
                      }
                    }
                  }
                          // WARNING: Subroutine does not return
                  FUN_1800d6620();
                }
              }
              ReadBookController.ShowReadBookPanel(this,0);
              return;
            }
          }
        }
    }

    // Token : 0x6002074
    // RVA   : 0xD09860   Offset: 0xD08C60   Length: 0xF1
    public void AutoReadBook()
    {
        float fVar1;
        uint uVar2;
        long lVar3;
        this.targetBook = this.tempBookData;
        if (((this.targetPracticeExpData != null) && (this.targetBook != null)) &&
           (lVar3 = this.targetPracticeExpData.maxReadExp) != null) {
          uVar2 = this.targetBook.rareLv;
          if (*(uint32 *)(lVar3 + 24) <= uVar2) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          fVar1 = lVar3[uVar2];
          ReadBookController.GetReadExp
                    (this,fVar1 * *(float *)(*(int64 *)(DAT_181d73d40 + 184) + 0x160),0);
          return;
        }
    }

    // Token : 0x6002075
    // RVA   : 0xD0DF50   Offset: 0xD0D350   Length: 0x8A
    public void /*ctor*/()
    {
        ulong uVar1;
        uVar1 = il2cpp_internal(DAT_181d92f70);
        FUN_181330100(uVar1,DAT_181d892b0);
        this.actingGrid = uVar1;
        this.maxWidth = 17;
        this.maxHeight = 11;
        FUN_18044ef50(this,0);
    }

    // Token : 0x6002076
    // RVA   : 0xD0DD30   Offset: 0xD0D130   Length: 0x7D
    private void <ShowReadBookPanel>b__31_1()
    {
        long lVar1;
        ReadBookController.GenerateReadBookPanel(this,0);
        lVar1 = new WarpText_d__8(0,0);
        if (lVar1 != null) {
          *(uint64 *)(lVar1 + 32) = this;
          FUN_180d8c8f0(this,lVar1,0);
          return;
        }
    }

}
