// ============================================================
// Type  : SpeBookStorageController
// Token : 0x200035B
// ============================================================

public class SpeBookStorageController
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001AC3
    public GameObject speBookStorageUI;

    // Token: 0x4001AC4
    public GameObject bookGrid;

    // Token: 0x4001AC5
    public GameObject speAddText;

    // Token: 0x4001AC6
    public bool needRefresh;

    // Token: 0x4001AC7
    private GameObject temp;

    // Token: 0x4001AC8
    private static SpeBookStorageController _instance;

    // Token: 0x4001AC9
    private static readonly List<float> bookAddSkillNum;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60020C1
    // RVA   : 0x97B8A0   Offset: 0x97A0A0   Length: 0x57
    public static SpeBookStorageController get_Instance()
    {
        return **(uint64 **)(DAT_181d7efb0 + 184);
    }

    // Token : 0x60020C2
    // RVA   : 0x97A620   Offset: 0x978E20   Length: 0x61
    private void Awake()
    {
        puVar1 = *(uint64 **)(DAT_181d7efb0 + 184);
        *puVar1 = this;
        il2cpp_internal(puVar1,this);
    }

    // Token : 0x60020C3
    // RVA   : 0x97B740   Offset: 0x979F40   Length: 0x3D
    private void Update()
    {
        bool cVar1;
        if (this.speBookStorageUI == null) {
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
        cVar1 = GameObject.get_activeSelf(this.speBookStorageUI,0);
        if ((cVar1) && (this.needRefresh)) {
          SpeBookStorageController.RefreshUI(this,0);
          return;
        }
    }

    // Token : 0x60020C4
    // RVA   : 0x790570   Offset: 0x78ED70   Length: 0x20
    public void HideSpeBookStorageUI()
    {
        if (this.speBookStorageUI != null) {
          GameObject.SetActive(this.speBookStorageUI,0,0);
          return;
        }
    }

    // Token : 0x60020C5
    // RVA   : 0x97B300   Offset: 0x979B00   Length: 0xAF
    public void ShowSpeBookStorageUI()
    {
        if (this.speBookStorageUI != null) {
          GameObject.SetActive(this.speBookStorageUI,1,0);
          SpeBookStorageController.RefreshUI(this,0);
          plVar1 = (int64 *)Resources.Load("Sound/SoundEffect/OpenBook",0);
          plVar2 = (int64 *)0;
          if ((plVar1 != (int64 *)0) && (*plVar1 == DAT_181d8a228)) {
            plVar2 = plVar1;
          }
          NGUITools.PlaySound(plVar2,0);
          return;
        }
    }

    // Token : 0x60020C6
    // RVA   : 0x97AF00   Offset: 0x979700   Length: 0x3F8
    public void RefreshUI()
    {
        var pStatics_df90 = *(int64*)(DAT_181d4df90 + 184);
        var pStatics_e188 = *(int64*)(DAT_181d4e188 + 184);
        ulong uVar1;
        long lVar2;
        long lVar3;
        ulong uVar4;
        int iVar5;
        uVar1 = this.bookGrid;
        this.needRefresh = 0;
        GlobalData.DeleteAllChild(uVar1,0);
        iVar5 = 0;
        while( true ) {
          if ((((*pStatics_df90 == 0) ||
               (lVar2 = *(int64 *)(*pStatics_df90 + 32)) == null) ||
              (lVar2 = *(int64 *)(lVar2 + 0x218)) == null) ||
             (lVar2 = *(int64 *)(lVar2 + 40)) == null) throw; // [null/range check failed]
          uVar1 = this.bookGrid;
          if (*(int *)(lVar2 + 24) <= iVar5) break;
          if (*pStatics_e188 == 0) throw; // [null/range check failed]
          uVar4 = *(uint64 *)(*pStatics_e188 + 160);
          uVar1 = GlobalData.AddChild(uVar1,uVar4,0);
          this.temp = uVar1;
          if (this.temp == null) throw; // [null/range check failed]
          lVar2 = GameObject.GetComponent(this.temp,DAT_181da0070);
          lVar3 = FUN_18046c0a0(0);
          if ((((lVar3 == null) || (*(int64 *)(lVar3 + 32) == 0)) ||
              (lVar3 = *(int64 *)(*(int64 *)(lVar3 + 32) + 0x218)) == null) ||
             (lVar3 = *(int64 *)(lVar3 + 40)) == null) throw; // [null/range check failed]
          uVar1 = FUN_180002f80(lVar3,iVar5);
          if (lVar2 == null) throw; // [null/range check failed]
          *(uint64 *)(lVar2 + 32) = uVar1;
          if (this.temp == null) throw; // [null/range check failed]
          lVar2 = GameObject.GetComponent(this.temp,DAT_181da0070);
          if (lVar2 == null) throw; // [null/range check failed]
          *(uint32 *)(lVar2 + 40) = 1;
          if (this.temp == null) throw; // [null/range check failed]
          lVar2 = GameObject.GetComponent(this.temp,DAT_181da0070);
          if (lVar2 == null) throw; // [null/range check failed]
          ItemIconController.AutoSetName(lVar2);
          iVar5 = iVar5 + 1;
        }
        GlobalData.SortChild(uVar1,0);
        if (this.speAddText != null) {
          uVar1 = GameObject.GetComponent(this.speAddText,DAT_181da1eb0);
          if (((*pStatics_df90 != 0) &&
              (lVar2 = *(int64 *)(*pStatics_df90 + 32)) != null) &&
             (lVar2 = *(int64 *)(lVar2 + 0x220)) != null) {
            uVar4 = HeroSpeAddData.GetDescribe(lVar2,1,1,2,0,0);
            LTLocalization.SetText(uVar1,uVar4,0);
            return;
          }
        }
    }

    // Token : 0x60020C7
    // RVA   : 0x97A8C0   Offset: 0x9790C0   Length: 0x169
    public void PutInBook()
    {
        long lVar1;
        long lVar2;
        ulong uVar3;
        uint[] local_res18 = new uint[2];
        uint[] local_res20 = new uint[2];
        lVar1 = **(int64 **)(DAT_181d92370 + 184);
        lVar2 = il2cpp_internal(DAT_181d701b0);
        FUN_180f58a90(lVar2,DAT_181d6dfe8);
        local_res18[0] = 0;
        uVar3 = il2cpp_value_box(DAT_181d5b2f8,local_res18);
        if (lVar2 != null) {
          FUN_181827900(lVar2,uVar3,DAT_181d6e0e8);
          local_res20[0] = 3;
          uVar3 = il2cpp_value_box(DAT_181d5b2f8,local_res20);
          FUN_181827900(lVar2,uVar3,DAT_181d6e0e8);
          uVar3 = Component.get_gameObject(this,0);
          if (lVar1 != null) {
            ChooseController.ShowChoosePanel(lVar1,1,lVar2,uVar3,"PutInBookChoosen",0,21,0,0,0);
            return;
          }
        }
    }

    // Token : 0x60020C8
    // RVA   : 0x97A690   Offset: 0x978E90   Length: 0x22B
    public void PutInBookChoosen()
    {
        var pStatics_2370 = *(int64*)(DAT_181d92370 + 184);
        var pStatics_df90 = *(int64*)(DAT_181d4df90 + 184);
        long lVar1;
        long lVar2;
        if ((*pStatics_df90 != 0) &&
           (lVar1 = *(int64 *)(*pStatics_df90 + 32)) != null) {
          lVar1 = WorldData.Player(lVar1,0);
          if ((*pStatics_2370 != 0) &&
             (lVar2 = *(int64 *)(*pStatics_2370 + 72)) != null) {
            lVar2 = GameObject.GetComponent(lVar2,DAT_181da0070);
            if ((lVar2 != null) && (lVar1 != null)) {
              HeroData.LoseItem(lVar1,*(uint64 *)(lVar2 + 32),1,0);
              if ((*pStatics_df90 != 0) &&
                 (lVar1 = *(int64 *)(*pStatics_df90 + 32)) != null) {
                lVar1 = *(int64 *)(lVar1 + 0x218);
                if ((*pStatics_2370 != 0) &&
                   (lVar2 = *(int64 *)(*pStatics_2370 + 72)) != null) {
                  lVar2 = GameObject.GetComponent(lVar2,DAT_181da0070);
                  if ((lVar2 != null) && (lVar1 != null)) {
                    ItemListData.GetItem(lVar1,*(uint64 *)(lVar2 + 32),0,0);
                    SpeBookStorageController.RefreshBookStorageSpeAdd(this,0);
                    this.needRefresh = 1;
                    return;
                  }
                }
              }
            }
          }
        }
    }

    // Token : 0x60020C9
    // RVA   : 0x97B600   Offset: 0x979E00   Length: 0x134
    public void TakeOutBook()
    {
        long lVar1;
        long lVar2;
        ulong uVar3;
        uint[] local_res18 = new uint[4];
        lVar1 = **(int64 **)(DAT_181d92370 + 184);
        lVar2 = il2cpp_internal(DAT_181d701b0);
        FUN_180f58a90(lVar2,DAT_181d6dfe8);
        local_res18[0] = 0xffffff98;
        uVar3 = il2cpp_value_box(DAT_181d5b2f8,local_res18);
        if (lVar2 != null) {
          FUN_181827900(lVar2,uVar3,DAT_181d6e0e8);
          uVar3 = Component.get_gameObject(this,0);
          if (lVar1 != null) {
            ChooseController.ShowChoosePanel(lVar1,1,lVar2,uVar3,"TakeOutBookChoosen",0,0,0,0,0);
            return;
          }
        }
    }

    // Token : 0x60020CA
    // RVA   : 0x97B3B0   Offset: 0x979BB0   Length: 0x241
    public void TakeOutBookChoosen()
    {
        var pStatics_2370 = *(int64*)(DAT_181d92370 + 184);
        var pStatics_df90 = *(int64*)(DAT_181d4df90 + 184);
        long lVar1;
        long lVar2;
        if ((*pStatics_df90 != 0) &&
           (lVar2 = *(int64 *)(*pStatics_df90 + 32)) != null) {
          lVar2 = *(int64 *)(lVar2 + 0x218);
          if ((*pStatics_2370 != 0) &&
             (lVar1 = *(int64 *)(*pStatics_2370 + 72)) != null) {
            lVar1 = GameObject.GetComponent(lVar1,DAT_181da0070);
            if ((lVar1 != null) && (lVar2 != null)) {
              ItemListData.LoseItem(lVar2,*(uint64 *)(lVar1 + 32),0,0);
              if ((*pStatics_df90 != 0) &&
                 (lVar2 = *(int64 *)(*pStatics_df90 + 32)) != null) {
                lVar2 = WorldData.Player(lVar2,0);
                if ((*pStatics_2370 != 0) &&
                   (lVar1 = *(int64 *)(*pStatics_2370 + 72)) != null) {
                  lVar1 = GameObject.GetComponent(lVar1,DAT_181da0070);
                  if ((lVar1 != null) && (lVar2 != null)) {
                    HeroData.GetItem(lVar2,*(uint64 *)(lVar1 + 32),1,0,0xffffffff,0,0);
                    SpeBookStorageController.RefreshBookStorageSpeAdd(this,0);
                    this.needRefresh = 1;
                    return;
                  }
                }
              }
            }
          }
        }
    }

    // Token : 0x60020CB
    // RVA   : 0x97AA30   Offset: 0x979230   Length: 0x4CA
    public void RefreshBookStorageSpeAdd()
    {
        var pStatics = *(int64*)(DAT_181d4df90 + 184);
        int iVar1;
        long lVar2;
        long lVar3;
        long lVar4;
        int iVar5;
        float fVar6;
        if (((*pStatics != 0) &&
            (lVar2 = *(int64 *)(*pStatics + 32)) != null) &&
           (lVar2 = *(int64 *)(lVar2 + 0x220)) != null) {
          HeroSpeAddData.Reset(lVar2,0);
          iVar5 = 0;
          while( true ) {
            if ((((*pStatics == 0) ||
                 (lVar2 = *(int64 *)(*pStatics + 32)) == null) ||
                (lVar2 = *(int64 *)(lVar2 + 0x218)) == null) ||
               (lVar2 = *(int64 *)(lVar2 + 40)) == null) throw; // [null/range check failed]
            if (*(int *)(lVar2 + 24) <= iVar5) break;
            lVar2 = FUN_18046c0a0(0);
            if ((lVar2 == null) || (*(int64 *)(lVar2 + 32) == 0)) throw; // [null/range check failed]
            lVar2 = *(int64 *)(*(int64 *)(lVar2 + 32) + 0x220);
            lVar3 = FUN_18046c0a0(0);
            if ((lVar3 == null) ||
               (((*(int64 *)(lVar3 + 32) == 0 ||
                 (lVar3 = *(int64 *)(*(int64 *)(lVar3 + 32) + 0x218)) == null) ||
                (lVar3 = *(int64 *)(lVar3 + 40)) == null))) throw; // [null/range check failed]
            lVar3 = FUN_180002f80(lVar3,iVar5,DAT_181d69770);
            if ((lVar3 == null) || (*(int64 *)(lVar3 + 112) == 0)) throw; // [null/range check failed]
            lVar3 = BookData.DataBase(*(int64 *)(lVar3 + 112),0);
            if (lVar3 == null) throw; // [null/range check failed]
            iVar1 = *(int *)(lVar3 + 48);
            lVar3 = *(int64 *)(*(int64 *)(DAT_181d7efb0 + 184) + 8);
            if ((((*pStatics == 0) ||
                 (lVar4 = *(int64 *)(*pStatics + 32)) == null) ||
                (lVar4 = *(int64 *)(lVar4 + 0x218)) == null) ||
               (lVar4 = *(int64 *)(lVar4 + 40)) == null) throw; // [null/range check failed]
            lVar4 = FUN_180002f80(lVar4,iVar5,DAT_181d69770);
            if ((lVar4 == null) || (*(int64 *)(lVar4 + 112) == 0)) throw; // [null/range check failed]
            lVar4 = BookData.DataBase(*(int64 *)(lVar4 + 112),0);
            if ((lVar4 == null) || (lVar3 == null)) throw; // [null/range check failed]
            fVar6 = (float)FUN_1800d6780(lVar3,*(uint32 *)(lVar4 + 52),DAT_181d796d8);
            lVar3 = FUN_18046c0a0(0);
            if ((((lVar3 == null) || (*(int64 *)(lVar3 + 32) == 0)) ||
                (lVar3 = *(int64 *)(*(int64 *)(lVar3 + 32) + 0x218)) == null) ||
               (lVar3 = *(int64 *)(lVar3 + 40)) == null) throw; // [null/range check failed]
            lVar3 = FUN_180002f80(lVar3,iVar5,DAT_181d69770);
            if ((lVar3 == null) || (lVar2 == null)) throw; // [null/range check failed]
            HeroSpeAddData.Change(lVar2,iVar1 + 6,((float)*(int *)(lVar3 + 64) * 0.2 + 1.0) * fVar6,0);
            iVar5 = iVar5 + 1;
          }
          if ((*pStatics != 0) &&
             (lVar2 = *(int64 *)(*pStatics + 32)) != null) {
            lVar2 = WorldData.Player(lVar2,0);
            if (lVar2 != null) {
              *(uint8 *)(lVar2 + 0x2d8) = 1;
              return;
            }
          }
        }
    }

    // Token : 0x60020CC
    // RVA   : 0x3A17B0   Offset: 0x39FFB0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_18044ef50(this,0);
    }

    // Token : 0x60020CD
    // RVA   : 0x97B780   Offset: 0x979F80   Length: 0x11E
    private static void /*cctor*/()
    {
        long lVar1;
        lVar1 = il2cpp_internal(DAT_181d721b0);
        FUN_180f58a90(lVar1,DAT_181d79358);
        if (lVar1 != null) {
          FUN_181805690(lVar1,0x3dcccccd,DAT_181d79458);
          FUN_181805690(lVar1,0x3e800000,DAT_181d79458);
          FUN_181805690(lVar1,0x3f000000,DAT_181d79458);
          FUN_181805690(lVar1,0x3f800000,DAT_181d79458);
          FUN_181805690(lVar1,0x40000000,DAT_181d79458);
          FUN_181805690(lVar1,0x40400000,DAT_181d79458);
          plVar2 = (int64 *)(*(int64 *)(DAT_181d7efb0 + 184) + 8);
          *plVar2 = lVar1;
          il2cpp_internal(plVar2,lVar1);
          return;
        }
    }

}
