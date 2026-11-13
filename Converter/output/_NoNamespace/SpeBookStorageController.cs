// ============================================================
// Type  : SpeBookStorageController
// Token : 0x200036F
// ============================================================

public class SpeBookStorageController
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001C57
    public GameObject speBookStorageUI;

    // Token: 0x4001C58
    public GameObject bookGrid;

    // Token: 0x4001C59
    public GameObject speAddText;

    // Token: 0x4001C5A
    public bool needRefresh;

    // Token: 0x4001C5B
    private GameObject temp;

    // Token: 0x4001C5C
    private static SpeBookStorageController _instance;

    // Token: 0x4001C5D
    private static readonly List<float> bookAddSkillNum;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60021EC
    // RVA   : 0x6B63F0   Offset: 0x6B51F0   Length: 0x57
    public static SpeBookStorageController get_Instance()
    {
        return **(uint64 **)(DAT_181e84628 + 184);
    }

    // Token : 0x60021ED
    // RVA   : 0x6B5150   Offset: 0x6B3F50   Length: 0x61
    private void Awake()
    {
        puVar1 = *(uint64 **)(DAT_181e84628 + 184);
        *puVar1 = this;
        il2cpp_internal(puVar1,this);
    }

    // Token : 0x60021EE
    // RVA   : 0x6B6290   Offset: 0x6B5090   Length: 0x3D
    private void Update()
    {
        bool cVar1;
        if (this.speBookStorageUI == null) {
                          // WARNING: Subroutine does not return
          FUN_1801e0300();
        }
        cVar1 = GameObject.get_activeSelf(this.speBookStorageUI,0);
        if ((cVar1) && (this.needRefresh)) {
          SpeBookStorageController.RefreshUI(this,0);
          return;
        }
    }

    // Token : 0x60021EF
    // RVA   : 0x52B140   Offset: 0x529F40   Length: 0x20
    public void HideSpeBookStorageUI()
    {
        if (this.speBookStorageUI != null) {
          GameObject.SetActive(this.speBookStorageUI,0,0);
          return;
        }
    }

    // Token : 0x60021F0
    // RVA   : 0x6B5E50   Offset: 0x6B4C50   Length: 0xAF
    public void ShowSpeBookStorageUI()
    {
        if (this.speBookStorageUI != null) {
          GameObject.SetActive(this.speBookStorageUI,1,0);
          SpeBookStorageController.RefreshUI(this,0);
          plVar1 = (int64 *)Resources.Load("Sound/SoundEffect/OpenBook",0);
          plVar2 = (int64 *)0;
          if ((plVar1 != (int64 *)0) && (*plVar1 == DAT_181e8f4a0)) {
            plVar2 = plVar1;
          }
          NGUITools.PlaySound(plVar2,0);
          return;
        }
    }

    // Token : 0x60021F1
    // RVA   : 0x6B5A30   Offset: 0x6B4830   Length: 0x419
    public void RefreshUI()
    {
        var pStatics_2a90 = *(int64*)(DAT_181e52a90 + 184);
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
          if ((((GameController._instance == null) ||
               (lVar2 = GameController._instance.worldData) == null) ||
              (lVar2 = lVar2.speBookStorage) == null) ||
             (lVar2 = lVar2.forceAreaID) == null) throw; // [null/range check failed]
          uVar1 = this.bookGrid;
          if (lVar2.cityAreaID <= iVar5) break;
          if (*pStatics_2a90 == 0) throw; // [null/range check failed]
          uVar4 = *(uint64 *)(*pStatics_2a90 + 160);
          uVar1 = GlobalData.AddChild(uVar1,uVar4,0);
          this.temp = uVar1;
          if (this.temp == null) throw; // [null/range check failed]
          lVar2 = GameObject.GetComponent(this.temp,DAT_181e55168);
          lVar3 = FUN_1802106e0(0);
          if ((((lVar3 == null) || (*(int64 *)(lVar3 + 32) == 0)) ||
              (lVar3 = *(int64 *)(*(int64 *)(lVar3 + 32) + 0x218)) == null) ||
             (lVar3 = *(int64 *)(lVar3 + 40)) == null) throw; // [null/range check failed]
          uVar1 = FUN_1800024b0(lVar3,iVar5);
          if (lVar2 == null) throw; // [null/range check failed]
          lVar2.villageAreaID = uVar1;
          if (this.temp == null) throw; // [null/range check failed]
          lVar2 = GameObject.GetComponent(this.temp,DAT_181e55168);
          if (lVar2 == null) throw; // [null/range check failed]
          lVar2.forceAreaID = 1;
          if (this.temp == null) throw; // [null/range check failed]
          lVar2 = GameObject.GetComponent(this.temp,DAT_181e55168);
          if (lVar2 == null) throw; // [null/range check failed]
          ItemIconController.AutoSetName(lVar2);
          iVar5 = iVar5 + 1;
        }
        GlobalData.SortChild(uVar1,0);
        if (this.speAddText != null) {
          uVar1 = GameObject.GetComponent(this.speAddText,DAT_181e571d0);
          if (((GameController._instance != null) &&
              (lVar2 = GameController._instance.worldData) != null) &&
             (lVar2 = lVar2.speBookStorageSpeAdd) != null) {
            uVar4 = HeroSpeAddData.GetDescribe(lVar2,1,1,2,0,0);
            LTLocalization.SetText(uVar1,uVar4,0);
            return;
          }
        }
    }

    // Token : 0x60021F2
    // RVA   : 0x6B53F0   Offset: 0x6B41F0   Length: 0x169
    public void PutInBook()
    {
        long lVar1;
        long lVar2;
        ulong uVar3;
        uint[] local_res18 = new uint[2];
        uint[] local_res20 = new uint[2];
        lVar1 = **(int64 **)(DAT_181e977e8 + 184);
        lVar2 = il2cpp_internal(DAT_181e74e38);
        FUN_1810f3480(lVar2,DAT_181e77ae0);
        local_res18[0] = 0;
        uVar3 = il2cpp_value_box(DAT_181e60808,local_res18);
        if (lVar2 != null) {
          FUN_18175de30(lVar2,uVar3,DAT_181e77be0);
          local_res20[0] = 3;
          uVar3 = il2cpp_value_box(DAT_181e60808,local_res20);
          FUN_18175de30(lVar2,uVar3,DAT_181e77be0);
          uVar3 = Component.get_gameObject(this,0);
          if (lVar1 != null) {
            ChooseController.ShowChoosePanel(lVar1,1,lVar2,uVar3,"PutInBookChoosen",0,21,0,0,0);
            return;
          }
        }
    }

    // Token : 0x60021F3
    // RVA   : 0x6B51C0   Offset: 0x6B3FC0   Length: 0x22B
    public void PutInBookChoosen()
    {
        var pStatics_77e8 = *(int64*)(DAT_181e977e8 + 184);
        long lVar1;
        long lVar2;
        if ((GameController._instance != null) &&
           (lVar1 = GameController._instance.worldData) != null) {
          lVar1 = WorldData.Player(lVar1,0);
          if ((*pStatics_77e8 != 0) &&
             (lVar2 = *(int64 *)(*pStatics_77e8 + 72)) != null) {
            lVar2 = GameObject.GetComponent(lVar2,DAT_181e55168);
            if ((lVar2 != null) && (lVar1 != null)) {
              HeroData.LoseItem(lVar1,*(uint64 *)(lVar2 + 32),1,0);
              if ((GameController._instance != null) &&
                 (lVar1 = GameController._instance.worldData) != null) {
                lVar1 = lVar1.speBookStorage;
                if ((*pStatics_77e8 != 0) &&
                   (lVar2 = *(int64 *)(*pStatics_77e8 + 72)) != null) {
                  lVar2 = GameObject.GetComponent(lVar2,DAT_181e55168);
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

    // Token : 0x60021F4
    // RVA   : 0x6B6150   Offset: 0x6B4F50   Length: 0x134
    public void TakeOutBook()
    {
        long lVar1;
        long lVar2;
        ulong uVar3;
        uint[] local_res18 = new uint[4];
        lVar1 = **(int64 **)(DAT_181e977e8 + 184);
        lVar2 = il2cpp_internal(DAT_181e74e38);
        FUN_1810f3480(lVar2,DAT_181e77ae0);
        local_res18[0] = 0xffffff98;
        uVar3 = il2cpp_value_box(DAT_181e60808,local_res18);
        if (lVar2 != null) {
          FUN_18175de30(lVar2,uVar3,DAT_181e77be0);
          uVar3 = Component.get_gameObject(this,0);
          if (lVar1 != null) {
            ChooseController.ShowChoosePanel(lVar1,1,lVar2,uVar3,"TakeOutBookChoosen",0,0,0,0,0);
            return;
          }
        }
    }

    // Token : 0x60021F5
    // RVA   : 0x6B5F00   Offset: 0x6B4D00   Length: 0x241
    public void TakeOutBookChoosen()
    {
        var pStatics_77e8 = *(int64*)(DAT_181e977e8 + 184);
        long lVar1;
        long lVar2;
        if ((GameController._instance != null) &&
           (lVar2 = GameController._instance.worldData) != null) {
          lVar2 = lVar2.speBookStorage;
          if ((*pStatics_77e8 != 0) &&
             (lVar1 = *(int64 *)(*pStatics_77e8 + 72)) != null) {
            lVar1 = GameObject.GetComponent(lVar1,DAT_181e55168);
            if ((lVar1 != null) && (lVar2 != null)) {
              ItemListData.LoseItem(lVar2,*(uint64 *)(lVar1 + 32),0,0);
              if ((GameController._instance != null) &&
                 (lVar2 = GameController._instance.worldData) != null) {
                lVar2 = WorldData.Player(lVar2,0);
                if ((*pStatics_77e8 != 0) &&
                   (lVar1 = *(int64 *)(*pStatics_77e8 + 72)) != null) {
                  lVar1 = GameObject.GetComponent(lVar1,DAT_181e55168);
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

    // Token : 0x60021F6
    // RVA   : 0x6B5560   Offset: 0x6B4360   Length: 0x4CA
    public void RefreshBookStorageSpeAdd()
    {
        int iVar1;
        long lVar2;
        long lVar3;
        long lVar4;
        int iVar5;
        float fVar6;
        if (((GameController._instance != null) &&
            (lVar2 = GameController._instance.worldData) != null) &&
           (lVar2 = lVar2.speBookStorageSpeAdd) != null) {
          HeroSpeAddData.Reset(lVar2,0);
          iVar5 = 0;
          while( true ) {
            if ((((GameController._instance == null) ||
                 (lVar2 = GameController._instance.worldData) == null) ||
                (lVar2 = lVar2.speBookStorage) == null) ||
               (lVar2 = lVar2.forceAreaID) == null) throw; // [null/range check failed]
            if (lVar2.cityAreaID <= iVar5) break;
            lVar2 = FUN_1802106e0(0);
            if ((lVar2 == null) || (lVar2.villageAreaID == null)) throw; // [null/range check failed]
            lVar2 = *(int64 *)(lVar2.villageAreaID + 0x220);
            lVar3 = FUN_1802106e0(0);
            if ((lVar3 == null) ||
               (((*(int64 *)(lVar3 + 32) == 0 ||
                 (lVar3 = *(int64 *)(*(int64 *)(lVar3 + 32) + 0x218)) == null) ||
                (lVar3 = *(int64 *)(lVar3 + 40)) == null))) throw; // [null/range check failed]
            lVar3 = FUN_1800024b0(lVar3,iVar5,DAT_181e73170);
            if ((lVar3 == null) || (*(int64 *)(lVar3 + 112) == 0)) throw; // [null/range check failed]
            lVar3 = BookData.DataBase(*(int64 *)(lVar3 + 112),0);
            if (lVar3 == null) throw; // [null/range check failed]
            iVar1 = *(int *)(lVar3 + 48);
            lVar3 = *(int64 *)(*(int64 *)(DAT_181e84628 + 184) + 8);
            if ((((GameController._instance == null) ||
                 (lVar4 = GameController._instance.worldData) == null) ||
                (lVar4 = lVar4.speBookStorage) == null) ||
               (lVar4 = lVar4.forceAreaID) == null) throw; // [null/range check failed]
            lVar4 = FUN_1800024b0(lVar4,iVar5,DAT_181e73170);
            if ((lVar4 == null) || (lVar4.lastRandomWorldEventDay == null)) throw; // [null/range check failed]
            lVar4 = BookData.DataBase(lVar4.lastRandomWorldEventDay,0);
            if ((lVar4 == null) || (lVar3 == null)) throw; // [null/range check failed]
            fVar6 = (float)FUN_1800024e0(lVar3,*(uint32 *)(lVar4 + 52),DAT_181e83530);
            lVar3 = FUN_1802106e0(0);
            if ((((lVar3 == null) || (*(int64 *)(lVar3 + 32) == 0)) ||
                (lVar3 = *(int64 *)(*(int64 *)(lVar3 + 32) + 0x218)) == null) ||
               (lVar3 = *(int64 *)(lVar3 + 40)) == null) throw; // [null/range check failed]
            lVar3 = FUN_1800024b0(lVar3,iVar5,DAT_181e73170);
            if ((lVar3 == null) || (lVar2 == null)) throw; // [null/range check failed]
            HeroSpeAddData.Change(lVar2,iVar1 + 6,((float)*(int *)(lVar3 + 64) * 0.2 + 1.0) * fVar6,0);
            iVar5 = iVar5 + 1;
          }
          if ((GameController._instance != null) &&
             (lVar2 = GameController._instance.worldData) != null) {
            lVar2 = WorldData.Player(lVar2,0);
            if (lVar2 != null) {
              *(uint8 *)(lVar2 + 0x2d8) = 1;
              return;
            }
          }
        }
    }

    // Token : 0x60021F7
    // RVA   : 0x2110A0   Offset: 0x20FEA0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_180ae8740(this,0);
    }

    // Token : 0x60021F8
    // RVA   : 0x6B62D0   Offset: 0x6B50D0   Length: 0x11E
    private static void /*cctor*/()
    {
        long lVar1;
        lVar1 = il2cpp_internal(DAT_181e76ea8);
        FUN_1810f3480(lVar1,DAT_181e83230);
        if (lVar1 != null) {
          FUN_18175dba0(lVar1,0x3dcccccd,DAT_181e83330);
          FUN_18175dba0(lVar1,0x3e800000,DAT_181e83330);
          FUN_18175dba0(lVar1,0x3f000000,DAT_181e83330);
          FUN_18175dba0(lVar1,0x3f800000,DAT_181e83330);
          FUN_18175dba0(lVar1,0x40000000,DAT_181e83330);
          FUN_18175dba0(lVar1,0x40400000,DAT_181e83330);
          plVar2 = (int64 *)(*(int64 *)(DAT_181e84628 + 184) + 8);
          *plVar2 = lVar1;
          il2cpp_internal(plVar2,lVar1);
          return;
        }
    }

}
