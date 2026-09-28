// ============================================================
// Type  : SpeBookStorageController
// Token : 0x2000362
// ============================================================

public class SpeBookStorageController
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001BC4
    public GameObject speBookStorageUI;

    // Token: 0x4001BC5
    public GameObject bookGrid;

    // Token: 0x4001BC6
    public GameObject speAddText;

    // Token: 0x4001BC7
    public bool needRefresh;

    // Token: 0x4001BC8
    private GameObject temp;

    // Token: 0x4001BC9
    private static SpeBookStorageController _instance;

    // Token: 0x4001BCA
    private static readonly List<float> bookAddSkillNum;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6002142
    // RVA   : 0x98E5F0   Offset: 0x98D9F0   Length: 0x57
    public static SpeBookStorageController get_Instance()
    {
        return **(uint64 **)(DAT_181da41d0 + 184);
    }

    // Token : 0x6002143
    // RVA   : 0x98D350   Offset: 0x98C750   Length: 0x61
    private void Awake()
    {
        puVar1 = *(uint64 **)(DAT_181da41d0 + 184);
        *puVar1 = this;
        il2cpp_internal(puVar1,this);
    }

    // Token : 0x6002144
    // RVA   : 0x98E490   Offset: 0x98D890   Length: 0x3D
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

    // Token : 0x6002145
    // RVA   : 0x78D070   Offset: 0x78C470   Length: 0x20
    public void HideSpeBookStorageUI()
    {
        if (this.speBookStorageUI != null) {
          GameObject.SetActive(this.speBookStorageUI,0,0);
          return;
        }
    }

    // Token : 0x6002146
    // RVA   : 0x98E050   Offset: 0x98D450   Length: 0xAF
    public void ShowSpeBookStorageUI()
    {
        if (this.speBookStorageUI != null) {
          GameObject.SetActive(this.speBookStorageUI,1,0);
          SpeBookStorageController.RefreshUI(this,0);
          plVar1 = (int64 *)Resources.Load("Sound/SoundEffect/OpenBook",0);
          plVar2 = (int64 *)0;
          if ((plVar1 != (int64 *)0) && (*plVar1 == DAT_181daf348)) {
            plVar2 = plVar1;
          }
          NGUITools.PlaySound(plVar2,0);
          return;
        }
    }

    // Token : 0x6002147
    // RVA   : 0x98DC30   Offset: 0x98D030   Length: 0x419
    public void RefreshUI()
    {
        var pStatics_2cc8 = *(int64*)(DAT_181d72cc8 + 184);
        var pStatics_2ee8 = *(int64*)(DAT_181d72ee8 + 184);
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
          if ((((*pStatics_2cc8 == 0) ||
               (lVar2 = *(int64 *)(*pStatics_2cc8 + 32)) == null) ||
              (lVar2 = *(int64 *)(lVar2 + 0x218)) == null) ||
             (lVar2 = *(int64 *)(lVar2 + 40)) == null) throw; // [null/range check failed]
          uVar1 = this.bookGrid;
          if (*(int *)(lVar2 + 24) <= iVar5) break;
          if (*pStatics_2ee8 == 0) throw; // [null/range check failed]
          uVar4 = *(uint64 *)(*pStatics_2ee8 + 160);
          uVar1 = GlobalData.AddChild(uVar1,uVar4,0);
          this.temp = uVar1;
          if (this.temp == null) throw; // [null/range check failed]
          lVar2 = GameObject.GetComponent(this.temp,DAT_181d720a0);
          lVar3 = FUN_18046c0a0(0);
          if ((((lVar3 == null) || (*(int64 *)(lVar3 + 32) == 0)) ||
              (lVar3 = *(int64 *)(*(int64 *)(lVar3 + 32) + 0x218)) == null) ||
             (lVar3 = *(int64 *)(lVar3 + 40)) == null) throw; // [null/range check failed]
          uVar1 = FUN_180002f80(lVar3,iVar5);
          if (lVar2 == null) throw; // [null/range check failed]
          *(uint64 *)(lVar2 + 32) = uVar1;
          if (this.temp == null) throw; // [null/range check failed]
          lVar2 = GameObject.GetComponent(this.temp,DAT_181d720a0);
          if (lVar2 == null) throw; // [null/range check failed]
          *(uint32 *)(lVar2 + 40) = 1;
          if (this.temp == null) throw; // [null/range check failed]
          lVar2 = GameObject.GetComponent(this.temp,DAT_181d720a0);
          if (lVar2 == null) throw; // [null/range check failed]
          ItemIconController.AutoSetName(lVar2);
          iVar5 = iVar5 + 1;
        }
        GlobalData.SortChild(uVar1,0);
        if (this.speAddText != null) {
          uVar1 = GameObject.GetComponent(this.speAddText,DAT_181d74108);
          if (((*pStatics_2cc8 != 0) &&
              (lVar2 = *(int64 *)(*pStatics_2cc8 + 32)) != null) &&
             (lVar2 = *(int64 *)(lVar2 + 0x220)) != null) {
            uVar4 = HeroSpeAddData.GetDescribe(lVar2,1,1,2,0,0);
            LTLocalization.SetText(uVar1,uVar4,0);
            return;
          }
        }
    }

    // Token : 0x6002148
    // RVA   : 0x98D5F0   Offset: 0x98C9F0   Length: 0x169
    public void PutInBook()
    {
        long lVar1;
        long lVar2;
        ulong uVar3;
        uint[] local_res18 = new uint[2];
        uint[] local_res20 = new uint[2];
        lVar1 = **(int64 **)(DAT_181db7518 + 184);
        lVar2 = il2cpp_internal(DAT_181d94e50);
        FUN_18132faf0(lVar2,DAT_181d95788);
        local_res18[0] = 0;
        uVar3 = il2cpp_value_box(DAT_181d80418,local_res18);
        if (lVar2 != null) {
          FUN_18181e0a0(lVar2,uVar3,DAT_181d95888);
          local_res20[0] = 3;
          uVar3 = il2cpp_value_box(DAT_181d80418,local_res20);
          FUN_18181e0a0(lVar2,uVar3,DAT_181d95888);
          uVar3 = Component.get_gameObject(this,0);
          if (lVar1 != null) {
            ChooseController.ShowChoosePanel(lVar1,1,lVar2,uVar3,"PutInBookChoosen",0,21,0,0,0);
            return;
          }
        }
    }

    // Token : 0x6002149
    // RVA   : 0x98D3C0   Offset: 0x98C7C0   Length: 0x22B
    public void PutInBookChoosen()
    {
        var pStatics_2cc8 = *(int64*)(DAT_181d72cc8 + 184);
        var pStatics_7518 = *(int64*)(DAT_181db7518 + 184);
        long lVar1;
        long lVar2;
        if ((*pStatics_2cc8 != 0) &&
           (lVar1 = *(int64 *)(*pStatics_2cc8 + 32)) != null) {
          lVar1 = WorldData.Player(lVar1,0);
          if ((*pStatics_7518 != 0) &&
             (lVar2 = *(int64 *)(*pStatics_7518 + 72)) != null) {
            lVar2 = GameObject.GetComponent(lVar2,DAT_181d720a0);
            if ((lVar2 != null) && (lVar1 != null)) {
              HeroData.LoseItem(lVar1,*(uint64 *)(lVar2 + 32),1,0);
              if ((*pStatics_2cc8 != 0) &&
                 (lVar1 = *(int64 *)(*pStatics_2cc8 + 32)) != null) {
                lVar1 = *(int64 *)(lVar1 + 0x218);
                if ((*pStatics_7518 != 0) &&
                   (lVar2 = *(int64 *)(*pStatics_7518 + 72)) != null) {
                  lVar2 = GameObject.GetComponent(lVar2,DAT_181d720a0);
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

    // Token : 0x600214A
    // RVA   : 0x98E350   Offset: 0x98D750   Length: 0x134
    public void TakeOutBook()
    {
        long lVar1;
        long lVar2;
        ulong uVar3;
        uint[] local_res18 = new uint[4];
        lVar1 = **(int64 **)(DAT_181db7518 + 184);
        lVar2 = il2cpp_internal(DAT_181d94e50);
        FUN_18132faf0(lVar2,DAT_181d95788);
        local_res18[0] = 0xffffff98;
        uVar3 = il2cpp_value_box(DAT_181d80418,local_res18);
        if (lVar2 != null) {
          FUN_18181e0a0(lVar2,uVar3,DAT_181d95888);
          uVar3 = Component.get_gameObject(this,0);
          if (lVar1 != null) {
            ChooseController.ShowChoosePanel(lVar1,1,lVar2,uVar3,"TakeOutBookChoosen",0,0,0,0,0);
            return;
          }
        }
    }

    // Token : 0x600214B
    // RVA   : 0x98E100   Offset: 0x98D500   Length: 0x241
    public void TakeOutBookChoosen()
    {
        var pStatics_2cc8 = *(int64*)(DAT_181d72cc8 + 184);
        var pStatics_7518 = *(int64*)(DAT_181db7518 + 184);
        long lVar1;
        long lVar2;
        if ((*pStatics_2cc8 != 0) &&
           (lVar2 = *(int64 *)(*pStatics_2cc8 + 32)) != null) {
          lVar2 = *(int64 *)(lVar2 + 0x218);
          if ((*pStatics_7518 != 0) &&
             (lVar1 = *(int64 *)(*pStatics_7518 + 72)) != null) {
            lVar1 = GameObject.GetComponent(lVar1,DAT_181d720a0);
            if ((lVar1 != null) && (lVar2 != null)) {
              ItemListData.LoseItem(lVar2,*(uint64 *)(lVar1 + 32),0,0);
              if ((*pStatics_2cc8 != 0) &&
                 (lVar2 = *(int64 *)(*pStatics_2cc8 + 32)) != null) {
                lVar2 = WorldData.Player(lVar2,0);
                if ((*pStatics_7518 != 0) &&
                   (lVar1 = *(int64 *)(*pStatics_7518 + 72)) != null) {
                  lVar1 = GameObject.GetComponent(lVar1,DAT_181d720a0);
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

    // Token : 0x600214C
    // RVA   : 0x98D760   Offset: 0x98CB60   Length: 0x4CA
    public void RefreshBookStorageSpeAdd()
    {
        var pStatics = *(int64*)(DAT_181d72cc8 + 184);
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
            lVar3 = FUN_180002f80(lVar3,iVar5,DAT_181d90f18);
            if ((lVar3 == null) || (*(int64 *)(lVar3 + 112) == 0)) throw; // [null/range check failed]
            lVar3 = BookData.DataBase(*(int64 *)(lVar3 + 112),0);
            if (lVar3 == null) throw; // [null/range check failed]
            iVar1 = *(int *)(lVar3 + 48);
            lVar3 = *(int64 *)(*(int64 *)(DAT_181da41d0 + 184) + 8);
            if ((((*pStatics == 0) ||
                 (lVar4 = *(int64 *)(*pStatics + 32)) == null) ||
                (lVar4 = *(int64 *)(lVar4 + 0x218)) == null) ||
               (lVar4 = *(int64 *)(lVar4 + 40)) == null) throw; // [null/range check failed]
            lVar4 = FUN_180002f80(lVar4,iVar5,DAT_181d90f18);
            if ((lVar4 == null) || (*(int64 *)(lVar4 + 112) == 0)) throw; // [null/range check failed]
            lVar4 = BookData.DataBase(*(int64 *)(lVar4 + 112),0);
            if ((lVar4 == null) || (lVar3 == null)) throw; // [null/range check failed]
            fVar6 = (float)FUN_1800d6790(lVar3,*(uint32 *)(lVar4 + 52),DAT_181da1078);
            lVar3 = FUN_18046c0a0(0);
            if ((((lVar3 == null) || (*(int64 *)(lVar3 + 32) == 0)) ||
                (lVar3 = *(int64 *)(*(int64 *)(lVar3 + 32) + 0x218)) == null) ||
               (lVar3 = *(int64 *)(lVar3 + 40)) == null) throw; // [null/range check failed]
            lVar3 = FUN_180002f80(lVar3,iVar5,DAT_181d90f18);
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

    // Token : 0x600214D
    // RVA   : 0x3A17B0   Offset: 0x3A0BB0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_18044ef50(this,0);
    }

    // Token : 0x600214E
    // RVA   : 0x98E4D0   Offset: 0x98D8D0   Length: 0x11E
    private static void /*cctor*/()
    {
        long lVar1;
        lVar1 = il2cpp_internal(DAT_181d96ed0);
        FUN_18132faf0(lVar1,DAT_181da0cf8);
        if (lVar1 != null) {
          FUN_18181de10(lVar1,0x3dcccccd,DAT_181da0df8);
          FUN_18181de10(lVar1,0x3e800000,DAT_181da0df8);
          FUN_18181de10(lVar1,0x3f000000,DAT_181da0df8);
          FUN_18181de10(lVar1,0x3f800000,DAT_181da0df8);
          FUN_18181de10(lVar1,0x40000000,DAT_181da0df8);
          FUN_18181de10(lVar1,0x40400000,DAT_181da0df8);
          plVar2 = (int64 *)(*(int64 *)(DAT_181da41d0 + 184) + 8);
          *plVar2 = lVar1;
          il2cpp_internal(plVar2,lVar1);
          return;
        }
    }

}
