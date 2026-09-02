// ============================================================
// Type  : ReadBookController
// Token : 0x2000331
// ============================================================

public class ReadBookController
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x40019D1
    public List<ReadBookTextTypeData> readBookTextTypeDataBase;

    // Token: 0x40019D2
    public GameObject readBookTextPrefab;

    // Token: 0x40019D3
    public GameObject readBookGridRoot;

    // Token: 0x40019D4
    public GameObject readBookUIPanel;

    // Token: 0x40019D5
    public List<Color> ScrollRareColor;

    // Token: 0x40019D6
    public List<Sprite> RareIconSprite;

    // Token: 0x40019D7
    public GameObject[] gridUnits;

    // Token: 0x40019D8
    public List<GameObject> gridPool;

    // Token: 0x40019D9
    public List<GameObject> actingGrid;

    // Token: 0x40019DA
    public bool reading;

    // Token: 0x40019DB
    public ItemData targetBook;

    // Token: 0x40019DC
    public int mapWidth;

    // Token: 0x40019DD
    public int mapHeight;

    // Token: 0x40019DE
    public float totalExp;

    // Token: 0x40019DF
    public int patientNum;

    // Token: 0x40019E0
    public int inspirationNum;

    // Token: 0x40019E1
    public int textReaded;

    // Token: 0x40019E2
    public GameObject readTextExpIcon;

    // Token: 0x40019E3
    private GameObject newObj;

    // Token: 0x40019E4
    private bool inited;

    // Token: 0x40019E5
    private int maxWidth;

    // Token: 0x40019E6
    private int maxHeight;

    // Token: 0x40019E7
    private HeroData targetHero;

    // Token: 0x40019E8
    private SkillMaxPracticeExpData targetPracticeExpData;

    // Token: 0x40019E9
    private KungfuSkillLvData targetSkill;

    // Token: 0x40019EA
    private static ReadBookController _instance;

    // Token: 0x40019EB
    private ItemData tempBookData;

    // Token: 0x40019EC
    private bool costContribution;

    // Token: 0x40019ED
    private bool costMoeny;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6001FE1
    // RVA   : 0xC5C8F0   Offset: 0xC5B0F0   Length: 0x36
    public static ReadBookController get_Instance()
    {
        return **(uint64 **)(DAT_181d74a60 + 184);
    }

    // Token : 0x6001FE2
    // RVA   : 0xC582C0   Offset: 0xC56AC0   Length: 0xD7
    private void Awake()
    {
        bool cVar2;
        ulong uVar3;
        uVar3 = **(uint64 **)(DAT_181d74a60 + 184);
        cVar2 = Object.op_Equality(uVar3,0,0);
        if (!cVar2) {
          uVar3 = Component.get_gameObject(this,0);
          Object.Destroy(uVar3,0);
          return;
        }
        puVar1 = *(uint64 **)(DAT_181d74a60 + 184);
        *puVar1 = this;
        il2cpp_internal(puVar1,this);
    }

    // Token : 0x6001FE3
    // RVA   : 0xC5C6F0   Offset: 0xC5AEF0   Length: 0x168
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
          uVar2 = Component.GetComponent(lVar1,DAT_181d6d8c0);
          uVar3 = Single.ToString(this + 120,"+0;-0;0",0);
          LTLocalization.SetText(uVar2,uVar3,0);
          if (((this.readBookUIPanel != null) &&
              (lVar1 = GameObject.get_transform(this.readBookUIPanel,0)) != null) &&
             ((lVar1 = Transform.Find(lVar1,"Patient",0), lVar1 != null &&
              (lVar1 = Transform.Find(lVar1,"Text",0)) != null))) {
            uVar2 = Component.GetComponent(lVar1,DAT_181d6d8c0);
            uVar3 = Int32.ToString(this + 124,0);
            LTLocalization.SetText(uVar2,uVar3,0);
            return;
          }
        }
    }

    // Token : 0x6001FE4
    // RVA   : 0xC59700   Offset: 0xC57F00   Length: 0x480
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
        uVar1 = FUN_1800d6020(DAT_181d848c0,&local_98);
        this.gridUnits = uVar1;
        uVar1 = il2cpp_internal(DAT_181d6e2b0);
        FUN_180f58a90(uVar1,DAT_181d61af8);
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
        LAB_180c59b7b:
                          // WARNING: Subroutine does not return
                  FUN_1800d6620();
                }
                lVar8 = (int64)iVar9;
                lVar7 = (int64)iVar6;
                FUN_180127fe0(lVar2,lVar7,lVar8,uVar1);
                if ((this.gridUnits == null) ||
                   (lVar2 = FUN_180127f50(this.gridUnits,lVar7,lVar8)) == null)
                goto LAB_180c59b7b;
                lVar2 = GameObject.get_transform(lVar2,0);
                puVar3 = (uint64 *)Vector3.get_one(&local_98,0);
                if (lVar2 == null) goto LAB_180c59b7b;
                local_a0 = *(uint32 *)(puVar3 + 1);
                local_a8 = *puVar3;
                Transform.set_localScale(lVar2,&local_a8,0);
                if ((this.gridUnits == null) ||
                   (lVar2 = FUN_180127f50(this.gridUnits,lVar7,lVar8)) == null)
                goto LAB_180c59b7b;
                lVar2 = GameObject.get_transform(lVar2,0);
                if ((this.readBookTextPrefab == null) ||
                   (lVar4 = GameObject.GetComponent(this.readBookTextPrefab,DAT_181da0b98),
                   lVar4 == null)) goto LAB_180c59b7b;
                puVar3 = (uint64 *)RectTransform.get_rect(local_78,lVar4,0);
                local_88 = *puVar3;
                uStack_80 = puVar3[1];
                fVar10 = (float)FUN_180d90480(&local_88,0);
                if ((this.readBookTextPrefab == null) ||
                   (lVar4 = GameObject.GetComponent(this.readBookTextPrefab,DAT_181da0b98),
                   lVar4 == null)) goto LAB_180c59b7b;
                puVar3 = (uint64 *)RectTransform.get_rect(local_68,lVar4,0);
                local_88 = *puVar3;
                uStack_80 = puVar3[1];
                fVar11 = (float)FUN_18044e2b0(&local_88,0);
                if (lVar2 == null) goto LAB_180c59b7b;
                local_b0 = 0;
                local_b8 = (float)iVar6 * fVar10;
                local_b4 = fVar11 * (float)iVar9;
                Transform.set_localPosition(lVar2,&local_b8,0);
                if (this.gridUnits == null) goto LAB_180c59b7b;
                lVar2 = FUN_180127f50(this.gridUnits,lVar7,lVar8);
                local_res8[0] = iVar9;
                uVar1 = il2cpp_value_box(DAT_181d5b2f8,local_res8);
                local_res18[0] = iVar6;
                uVar5 = il2cpp_value_box(DAT_181d5b2f8,local_res18);
                uVar1 = String.Format("{0}_{1}",uVar1,uVar5,0);
                if (lVar2 == null) goto LAB_180c59b7b;
                Object.set_name(lVar2,uVar1,0);
                if ((this.gridUnits == null) ||
                   (lVar2 = FUN_180127f50(this.gridUnits,lVar7,lVar8)) == null)
                goto LAB_180c59b7b;
                GameObject.SetActive(lVar2,0,0);
                if ((this.gridUnits == null) ||
                   ((lVar2 = FUN_180127f50(this.gridUnits,lVar7,lVar8), lVar2 == null ||
                    (lVar2 = GameObject.GetComponent(lVar2,DAT_181da0a88)) == null)))
                goto LAB_180c59b7b;
                *(int *)(lVar2 + 24) = iVar6;
                if ((this.gridUnits == null) ||
                   ((lVar2 = FUN_180127f50(this.gridUnits,lVar7), lVar2 == null ||
                    (lVar2 = GameObject.GetComponent(lVar2,DAT_181da0a88)) == null)))
                goto LAB_180c59b7b;
                iVar6 = iVar6 + 1;
                *(int *)(lVar2 + 28) = iVar9;
              } while (iVar6 < this.maxWidth);
            }
            iVar9 = iVar9 + 1;
          } while (iVar9 < this.maxHeight);
        }
    }

    // Token : 0x6001FE5
    // RVA   : 0xC5A5C0   Offset: 0xC58DC0   Length: 0xB72
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
                                      plVar6 = (int64 *)Component.GetComponent(lVar4,DAT_181d6bc40);
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
                                                  uVar7 = Component.GetComponent(lVar4,DAT_181d6d8c0);
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
                                                                              (lVar4,DAT_181d6d8c0);
                                                            lVar4 = *(int64 *)
                                                                     (*(int64 *)(DAT_181d4ef00 + 184)
                                                                     + 0x4f8);
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
                                                                                  (lVar4,DAT_181d6bc40);
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
                                                                     (*(int64 *)(DAT_181d8ee60 + 184)
                                                                     + 8);
                                                            if (lVar4 != null) {
                                                              if (*(int64 *)(lVar4 + 24) == 0) {
                                                                iVar3 = 0;
                                                              }
                                                              else {
                                                                if (((*(byte *)(DAT_181d8ee60 + 0x133) & 4
                                                                     ) != 0) &&
                                                                   (*(int *)(DAT_181d8ee60 + 224) == 0))
                                                                {
                                                                  il2cpp_runtime_class_init();
                                                                }
                                                                if (((*(byte *)(DAT_181d8ee60 + 0x133) & 4
                                                                     ) != 0) &&
                                                                   (*(int *)(DAT_181d8ee60 + 224) == 0))
                                                                {
                                                                  il2cpp_runtime_class_init();
                                                                }
                                                                lVar4 = *(int64 *)
                                                                         (*(int64 *)
                                                                           (DAT_181d8ee60 + 184) + 8);
                                                                if ((lVar4 == null) ||
                                                                   (lVar4 = *(int64 *)(lVar4 + 24),
                                                                   lVar4 == null)) throw; // [null/range check failed]
                                                                iVar3 = *(int *)(lVar4 + 20) * 5;
                                                              }
                                                              if (((*(byte *)(DAT_181d4df90 + 0x133) & 4)
                                                                   != 0) &&
                                                                 (*(int *)(DAT_181d4df90 + 224) == 0)) {
                                                                il2cpp_runtime_class_init(DAT_181d4df90);
                                                              }
                                                              if (((*(byte *)(DAT_181d4df90 + 0x133) & 4)
                                                                   != 0) &&
                                                                 (*(int *)(DAT_181d4df90 + 224) == 0)) {
                                                                il2cpp_runtime_class_init(DAT_181d4df90);
                                                              }
                                                              if ((**(int64 **)(DAT_181d4df90 + 184)
                                                                   != 0) &&
                                                                 (lVar4 = *(int64 *)
                                                                           (**(int64 **)
                                                                              (DAT_181d4df90 + 184) +
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
                                                                                (uVar7,15,DAT_181d97ca8);
                                                              uVar7 = TweenSettingsExtensions.SetDelay
                                                                                (uVar7,0x3e4ccccd,
                                                                                 DAT_181d97978);
                                                              if (((*(byte *)(DAT_181d5d6a0 + 0x133) & 4)
                                                                   != 0) &&
                                                                 (*(int *)(DAT_181d5d6a0 + 224) == 0)) {
                                                                il2cpp_runtime_class_init(DAT_181d5d6a0);
                                                              }
                                                              lVar4 = *(int64 *)
                                                                       (*(int64 *)
                                                                         (DAT_181d5d6a0 + 184) + 8);
                                                              if (lVar4 == null) {
                                                                if (((*(byte *)(DAT_181d5d6a0 + 0x133) & 4
                                                                     ) != 0) &&
                                                                   (*(int *)(DAT_181d5d6a0 + 224) == 0))
                                                                {
                                                                  il2cpp_runtime_class_init(DAT_181d5d6a0)
                                                                  ;
                                                                }
                                                                uVar8 = **(uint64 **)
                                                                          (DAT_181d5d6a0 + 184);
                                                                lVar4 = il2cpp_internal(DAT_181d88bd8)
                                                                ;
                                                                OnTooltipCB.ctor(lVar4,uVar8,
                                                                                  DAT_181d824a8,0);
                                                                plVar6 = (int64 *)
                                                                         (*(int64 *)
                                                                           (DAT_181d5d6a0 + 184) + 8);
                                                                *plVar6 = lVar4;
                                                                il2cpp_internal(plVar6,lVar4);
                                                              }
                                                              TweenSettingsExtensions.OnStart
                                                                        (uVar7,lVar4,DAT_181d97210);
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
                                                                          (uVar7,15,DAT_181d97ca8);
                                                        uVar7 = TweenSettingsExtensions.SetDelay
                                                                          (uVar7,0x3e4ccccd,DAT_181d97978)
                                                        ;
                                                        uVar8 = new OnTooltipCB(this,DAT_181d72370,0);
                                                        TweenSettingsExtensions.OnComplete
                                                                  (uVar7,uVar8,DAT_181d96ee8);
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

    // Token : 0x6001FE6
    // RVA   : 0xC5B950   Offset: 0xC5A150   Length: 0x6C
    public IEnumerator StartShowText()
    {
        long lVar1;
        lVar1 = new WarpText_d__8(0,0);
        if (lVar1 != null) {
          *(uint64 *)(lVar1 + 32) = this;
          return lVar1;
        }
    }

    // Token : 0x6001FE7
    // RVA   : 0xC5A4F0   Offset: 0xC58CF0   Length: 0xC6
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
                lVar1 = FUN_180127f50(this.gridUnits,
                                      (int64)(*(int *)(targetText + 24) + iVar4),(int64)iVar3);
                if (lVar1 == null) throw; // [null/range check failed]
                lVar1 = GameObject.GetComponent(lVar1,DAT_181da0a88);
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

    // Token : 0x6001FE8
    // RVA   : 0xC583A0   Offset: 0xC56BA0   Length: 0x4
    public void ChangePatient(int changeNum)
    {
        void FUN_180c583a0(int64 this,int changeNum)
        {
        this.patientNum = this.patientNum + changeNum;
    }

    // Token : 0x6001FE9
    // RVA   : 0xC583B0   Offset: 0xC56BB0   Length: 0xB
    public void ChangeTotalExp(float changeExp)
    {
        void FUN_180c583b0(int64 this,float changeExp)
        {
        this.totalExp = changeExp + this.totalExp;
    }

    // Token : 0x6001FEA
    // RVA   : 0xC58460   Offset: 0xC56C60   Length: 0xA43
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
        if ((plVar4 != (int64 *)0) && (plVar13 = (int64 *)0, *plVar4 == DAT_181d8a228)) {
          plVar13 = plVar4;
        }
        NGUITools.PlaySound(plVar13,0);
        if (this.gridPool != null) {
          FUN_180f56130(this.gridPool,DAT_181d61c78);
          if (this.actingGrid != null) {
            FUN_180f56130(this.actingGrid,DAT_181d61c78);
            if (this.readBookGridRoot != null) {
              lVar5 = GameObject.get_transform(this.readBookGridRoot,0);
              if ((this.readBookTextPrefab != null) &&
                 (lVar6 = GameObject.GetComponent(this.readBookTextPrefab,DAT_181da0b98),
                 lVar6 != null)) {
                puVar7 = (uint64 *)RectTransform.get_rect(local_f8,lVar6,0);
                local_108 = *puVar7;
                uStack_100 = puVar7[1];
                fVar18 = (float)FUN_180d90480(&local_108,0);
                iVar3 = this.mapWidth;
                if ((this.readBookTextPrefab != null) &&
                   (lVar6 = GameObject.GetComponent(this.readBookTextPrefab,DAT_181da0b98),
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
                            lVar5 = FUN_180127f50(this.gridUnits,(int64)(int)plVar13,
                                                  (int64)(int)plVar4);
                            if ((lVar5 == null) || (lVar6 = FUN_180fa1260(lVar5,0)) == null)
                            throw; // [null/range check failed]
                            GameObject.SetActive(lVar6,1,0);
                            lVar8 = GameObject.GetComponent(lVar5,DAT_181da0a88);
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
                            FUN_181827900(this.gridPool,lVar5,DAT_181d61bf8);
                            uVar17 = (int)plVar13 + 1;
                            plVar13 = (int64 *)(uint64)uVar17;
                          } while ((int)uVar17 < this.mapWidth);
                        }
                        uVar17 = (int)plVar4 + 1;
                        plVar4 = (int64 *)(uint64)uVar17;
                      } while ((int)uVar17 < this.mapHeight);
                    }
                    lVar6 = il2cpp_internal(DAT_181d6f030);
                    FUN_180f58a90(lVar6,DAT_181d678f8);
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
                             (lVar5 = FUN_180002f80(this.readBookTextTypeDataBase,uVar17,DAT_181d76b58),
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
                              FUN_181814fa0(lVar6,uVar17);
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
                      lVar8 = il2cpp_internal(DAT_181d6f030);
                      FUN_180f58a90(lVar8,DAT_181d678f8);
                      lVar5 = this.gridPool;
                      plVar4 = plVar16;
                      if (lVar5 != null) goto LAB_180c58c84;
                    }
                  }
                }
              }
            }
          }
        }
        throw; // [null/range check failed]
        LAB_180c58cc1:
        if (*(int *)(lVar8 + 24) < 1) {
          return;
        }
        if (lVar6 == null) throw; // [null/range check failed]
        if (lVar6.Count < 1) {
          return;
        }
        uVar17 = FUN_180d8cf10(0,*(int *)(lVar8 + 24),0);
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
        lVar12 = GameObject.GetComponent(lVar5,DAT_181da0a88);
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
        FUN_181801c10(lVar8,uVar17,DAT_181d67e70);
        FUN_18180c7d0(lVar6,0);
        goto LAB_180c58cc1;
        while( true ) {
          if (lVar8 == null) break;
          FUN_181814fa0(lVar8,plVar4);
          lVar5 = this.gridPool;
          plVar4 = (int64 *)(uint64)((int)plVar4 + 1);
          if (lVar5 == null) break;
        LAB_180c58c84:
          if (lVar5.Count <= (int)plVar4) {
            if (lVar8 != null) goto LAB_180c58cc1;
            break;
          }
        }
    }

    // Token : 0x6001FEB
    // RVA   : 0xC5A330   Offset: 0xC58B30   Length: 0x12E
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
              FUN_180f56130(lVar1,DAT_181d61c78);
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

    // Token : 0x6001FEC
    // RVA   : 0xC583C0   Offset: 0xC56BC0   Length: 0x9F
    public void FinishRead()
    {
        var pStatics = *(int64*)(DAT_181d834f0 + 184);
        if (*pStatics != 0) {
          SureMenu.CallSureMenu
                    (*pStatics,"确认结束阅读吗？","SureFinishRead",0,"ReadBookController",0);
          return;
        }
    }

    // Token : 0x6001FED
    // RVA   : 0xC5B9C0   Offset: 0xC5A1C0   Length: 0x91C
    public void SureFinishRead()
    {
        var pStatics_c960 = *(int64*)(DAT_181d6c960 + 184);
        var pStatics_df90 = *(int64*)(DAT_181d4df90 + 184);
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
        if ((plVar3 != (int64 *)0) && (plVar10 = (int64 *)0, *plVar3 == DAT_181d8a228)) {
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
          FUN_181814d10(lVar7,this.targetBook.rareLv,
                        this.totalExp,DAT_181d79758);
          if (((*pStatics_df90 == 0) ||
              (lVar7 = *(int64 *)(*pStatics_df90 + 32)) == null) ||
             (lVar7 = WorldData.Player(lVar7,0)) == null) throw; // [null/range check failed]
          HeroData.AddSkillMaxPracticeExp(lVar7,this.targetPracticeExpData,0);
        LAB_180c5bd41:
          lVar7 = **(int64 **)(DAT_181d5a578 + 184);
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
            FUN_181814d10(lVar7,this.targetBook.rareLv,fVar14,DAT_181d79758
                         );
            goto LAB_180c5bd41;
          }
        }
        pfVar11 = &this.totalExp;
        if ((*pStatics_c960 != 0) &&
           (lVar7 = PlotController.GetAreaAvailableHelpHero(*pStatics_c960,0),
           lVar7 != null)) {
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
                lVar13 = *(int64 *)(lVar7 + 0x150);
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
                  lVar8 = FUN_18046c440(0);
                  lVar13 = *(int64 *)(lVar7 + 0x150);
                  if (((this.targetSkill != null) &&
                      (lVar9 = KungfuSkillLvData.DataBase(this.targetSkill,0)) != null)
                     && (lVar13 != null)) {
                    uVar2 = *(uint32 *)(lVar9 + 48);
                    if (*(uint32 *)(lVar13 + 24) <= uVar2) {
                      ThrowHelper.ThrowArgumentOutOfRangeException(0);
                    }
                    local_res8[0] =
                         lVar13[uVar2];
                    uVar4 = il2cpp_value_box(DAT_181d7d0b8,local_res8);
                    lVar13 = *(int64 *)(*(int64 *)(DAT_181d4ef00 + 184) + 0x498);
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
                      uVar6 = il2cpp_value_box(DAT_181d7d0b8,local_res18);
                      uVar4 = String.Format("这秘籍中有些晦涩难懂之处，我来给#PlayerName#讲解讲解好了。\n(对方{0}点{1}技能，经验额外增加{2}%)",uVar4,uVar5,uVar6,0);
                      uVar5 = Int32.ToString(lVar7 + 88,0);
                      uVar6 = il2cpp_internal(DAT_181d7d2b0);
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
                FUN_180f56130(lVar7,DAT_181d61c78);
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

    // Token : 0x6001FEE
    // RVA   : 0xC595C0   Offset: 0xC57DC0   Length: 0x13B
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
              FUN_180f56130(lVar1,DAT_181d61c78);
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

    // Token : 0x6001FEF
    // RVA   : 0xC58EB0   Offset: 0xC576B0   Length: 0x70B
    public void GetReadExp(float targetExp)
    {
        var pStatics_c960 = *(int64*)(DAT_181d6c960 + 184);
        var pStatics_df90 = *(int64*)(DAT_181d4df90 + 184);
        long lVar1;
        bool cVar2;
        int iVar3;
        long lVar4;
        ulong uVar5;
        long lVar6;
        int iVar7;
        lVar6 = **(int64 **)(DAT_181d7f230 + 184);
        if ((*pStatics_df90 == 0) ||
           (lVar4 = *(int64 *)(*pStatics_df90 + 32)) == null)
        throw; // [null/range check failed]
        lVar4 = WorldData.Player(lVar4,0);
        if ((this.targetBook == null) ||
           ((lVar1 = this.targetBook.bookData, lVar1 == null || (lVar4 == null))))
        throw; // [null/range check failed]
        uVar5 = HeroData.FindSkill(lVar4,*(uint32 *)(lVar1 + 16),0);
        if (lVar6 == null) throw; // [null/range check failed]
        SpeShowController.ShowGetSkillExp(lVar6,uVar5);
        lVar6 = *pStatics_df90;
        if ((this.targetBook == null) ||
           (lVar4 = this.targetBook.bookData) == null) throw; // [null/range check failed]
        uVar5 = Int32.ToString(lVar4 + 16,0);
        if (lVar6 == null) throw; // [null/range check failed]
        GameController.CheckPlotTrigger(lVar6,6,uVar5,999999,0);
        if (*pStatics_c960 == 0) throw; // [null/range check failed]
        cVar2 = PlotController.HaveNoPlotWait(*pStatics_c960,0);
        if (cVar2) {
          iVar7 = 0;
          do {
            if ((*pStatics_df90 == 0) ||
               (lVar6 = *(int64 *)(*pStatics_df90 + 32)) == null)
            throw; // [null/range check failed]
            lVar6 = WorldData.Player(lVar6,0);
            if ((lVar6 == null) || (*(int64 *)(lVar6 + 0x2e8) == 0)) throw; // [null/range check failed]
            if (*(int *)(*(int64 *)(lVar6 + 0x2e8) + 24) <= iVar7) break;
            lVar6 = FUN_18046c0a0(0);
            if ((lVar6 == null) || (*(int64 *)(lVar6 + 32) == 0)) throw; // [null/range check failed]
            lVar6 = WorldData.Player(*(int64 *)(lVar6 + 32),0);
            if ((lVar6 == null) || (*(int64 *)(lVar6 + 0x2e8) == 0)) throw; // [null/range check failed]
            lVar6 = FUN_180002f80(*(int64 *)(lVar6 + 0x2e8),iVar7,DAT_181d6d4e8);
            if ((lVar6 == null) || (lVar6 = *(int64 *)(lVar6 + 120)) == null) throw; // [null/range check failed]
            if (*(int *)(lVar6 + 24) == 0) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            lVar6 = *(int64 *)(*(int64 *)(lVar6 + 16) + 32);
            if (lVar6 == null) throw; // [null/range check failed]
            if (*(int *)(lVar6 + 40) == 7) {
              lVar6 = FUN_18046c0a0(0);
              if ((lVar6 == null) || (*(int64 *)(lVar6 + 32) == 0)) throw; // [null/range check failed]
              lVar6 = WorldData.Player(*(int64 *)(lVar6 + 32),0);
              if ((lVar6 == null) || (*(int64 *)(lVar6 + 0x2e8) == 0)) throw; // [null/range check failed]
              lVar6 = FUN_180002f80(*(int64 *)(lVar6 + 0x2e8),iVar7,DAT_181d6d4e8);
              if ((lVar6 == null) || (lVar6 = *(int64 *)(lVar6 + 120)) == null) throw; // [null/range check failed]
              if (*(int *)(lVar6 + 24) == 0) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              lVar6 = *(int64 *)(*(int64 *)(lVar6 + 16) + 32);
              if (lVar6 == null) throw; // [null/range check failed]
              iVar3 = Int32.Parse(*(uint64 *)(lVar6 + 48));
              if ((this.targetBook == null) ||
                 (lVar6 = this.targetBook.bookData) == null)
              throw; // [null/range check failed]
              if (iVar3 == *(int *)(lVar6 + 16)) goto LAB_180c593da;
            }
            iVar7 = iVar7 + 1;
          } while( true );
        }
        goto LAB_180c594b7;
        LAB_180c593da:
        lVar6 = FUN_18046c440(0);
        lVar4 = FUN_18046c0a0(0);
        if ((lVar4 == null) || (*(int64 *)(lVar4 + 32) == 0)) throw; // [null/range check failed]
        lVar4 = WorldData.Player(*(int64 *)(lVar4 + 32),0);
        if ((lVar4 == null) || (*(int64 *)(lVar4 + 0x2e8) == 0)) throw; // [null/range check failed]
        lVar4 = FUN_180002f80(*(int64 *)(lVar4 + 0x2e8),iVar7,DAT_181d6d4e8);
        if ((lVar4 == null) || (lVar4 = *(int64 *)(lVar4 + 120)) == null) throw; // [null/range check failed]
        if (*(int *)(lVar4 + 24) == 0) {
          ThrowHelper.ThrowArgumentOutOfRangeException(0);
        }
        lVar4 = *(int64 *)(*(int64 *)(lVar4 + 16) + 32);
        if ((lVar4 == null) || (lVar6 == null)) throw; // [null/range check failed]
        PlotController.AddPlotEvent(lVar6,*(uint64 *)(lVar4 + 32),0);
        LAB_180c594b7:
        if ((*pStatics_df90 != 0) &&
           (lVar6 = *(int64 *)(*pStatics_df90 + 32)) != null) {
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

    // Token : 0x6001FF0
    // RVA   : 0xC5A460   Offset: 0xC58C60   Length: 0x88
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

    // Token : 0x6001FF1
    // RVA   : 0xC5B140   Offset: 0xC59940   Length: 0x80F
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
        LAB_180c5b4d2:
              lVar6 = **(int64 **)(DAT_181d834f0 + 184);
              plVar7 = (int64 *)FUN_1800d60b0(DAT_181d7f180,5);
              if ((*plVar12 == 0) || (lVar8 = ItemData.Name(*plVar12,1,0), plVar7 == (int64 *)0)) {
        LAB_180c5b94a:
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
              if (*plVar12 == 0) goto LAB_180c5b94a;
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
              goto LAB_180c5b94a;
              local_38 = BookData.ReadDayCost(lVar8,0);
              lVar8 = il2cpp_value_box(DAT_181d5b2f8,&local_38);
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
                uVar10 = il2cpp_value_box(DAT_181d5b2f8,local_34);
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
                if ((plVar7 != (int64 *)0) && (*plVar7 == DAT_181d8a228)) {
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
              lVar8 = *(int64 *)(*(int64 *)(DAT_181d4ef00 + 184) + 0x3d0);
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
              goto LAB_180c5b4d2;
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
          lVar6 = **(int64 **)(DAT_181d4df90 + 184);
          uVar11 = "队友无法阅读秘籍！";
        }
        if (lVar6 != null) {
          GameController.ShowTextOnMouse(lVar6,uVar11,0);
          return;
        }
    }

    // Token : 0x6001FF2
    // RVA   : 0xC5C2E0   Offset: 0xC5AAE0   Length: 0x388
    public void SureStartReadBook()
    {
        var pStatics = *(int64*)(DAT_181d4df90 + 184);
        long lVar1;
        int iVar2;
        int iVar3;
        uint uVar4;
        long lVar5;
        ulong uVar7;
        if (this.costMoeny) {
          if ((*pStatics == 0) ||
             (lVar5 = *(int64 *)(*pStatics + 32)) == null)
          throw; // [null/range check failed]
          lVar5 = WorldData.Player(lVar5,0);
          if ((lVar5 == null) || (*(int64 *)(lVar5 + 0x220) == 0)) throw; // [null/range check failed]
          iVar3 = *(int *)(*(int64 *)(lVar5 + 0x220) + 24);
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
              if ((plVar6 != (int64 *)0) && (*plVar6 == DAT_181d8a228)) {
                plVar8 = plVar6;
              }
              NGUITools.PlaySound(plVar8,0);
              return;
            }
            throw; // [null/range check failed]
          }
          lVar5 = FUN_18046c0a0(0);
          if ((lVar5 == null) || (*(int64 *)(lVar5 + 32) == 0)) throw; // [null/range check failed]
          lVar5 = WorldData.Player(*(int64 *)(lVar5 + 32),0);
          if ((this.tempBookData == null) ||
             (lVar1 = this.tempBookData.bookData) == null)
          throw; // [null/range check failed]
          iVar3 = BookData.ReadMoneyCost(lVar1,0);
          if (lVar5 == null) throw; // [null/range check failed]
          HeroData.ChangeMoney(lVar5,-iVar3,1,0);
        }
        lVar5 = *(int64 *)(*(int64 *)(DAT_181d90b30 + 184) + 8);
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

    // Token : 0x6001FF3
    // RVA   : 0xC59B90   Offset: 0xC58390   Length: 0x79D
    public void RealStartReadBook()
    {
        var pStatics_df90 = *(int64*)(DAT_181d4df90 + 184);
        var pStatics_ef00 = *(int64*)(DAT_181d4ef00 + 184);
        uint uVar1;
        uint uVar2;
        long lVar3;
        ulong uVar4;
        long lVar6;
        long lVar7;
        float[] local_res18 = new float[2];
        float[] local_res20 = new float[2];
        lVar3 = *(int64 *)(*(int64 *)(DAT_181d90b30 + 184) + 8);
        if (lVar3 != null) {
          if (!lVar3.activeTimeLeft) {
            return;
          }
          if (((*pStatics_df90 != 0) &&
              (lVar3 = *(int64 *)(*pStatics_df90 + 32)) != null) &&
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
                  lVar3 = **(int64 **)(DAT_181d834f0 + 184);
                  plVar5 = (int64 *)FUN_1800d60b0(DAT_181d7f180,5);
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
                      local_res20[0] = *(float *)(pStatics_ef00 + 0x160) * 100.0;
                      lVar6 = il2cpp_value_box(DAT_181d7d0b8,local_res20);
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
                             *(float *)(pStatics_ef00 + 0x160);
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

    // Token : 0x6001FF4
    // RVA   : 0xC581C0   Offset: 0xC569C0   Length: 0xF1
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
                    (this,fVar1 * *(float *)(*(int64 *)(DAT_181d4ef00 + 184) + 0x160),0);
          return;
        }
    }

    // Token : 0x6001FF5
    // RVA   : 0xC5C860   Offset: 0xC5B060   Length: 0x8A
    public void /*ctor*/()
    {
        ulong uVar1;
        uVar1 = il2cpp_internal(DAT_181d6e2b0);
        FUN_180f58a90(uVar1,DAT_181d61af8);
        this.actingGrid = uVar1;
        this.maxWidth = 17;
        this.maxHeight = 11;
        FUN_18044ef50(this,0);
    }

    // Token : 0x6001FF6
    // RVA   : 0xC5C670   Offset: 0xC5AE70   Length: 0x7D
    private void <ShowReadBookPanel>b__31_1()
    {
        long lVar1;
        ReadBookController.GenerateReadBookPanel(this,0);
        lVar1 = new WarpText_d__8(0,0);
        if (lVar1 != null) {
          *(uint64 *)(lVar1 + 32) = this;
          FUN_180d837c0(this,lVar1,0);
          return;
        }
    }

}
