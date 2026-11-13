// ============================================================
// Type  : MeditationUIController
// Token : 0x200030C
// ============================================================

public class MeditationUIController
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001935
    public GameObject meditationUI;

    // Token: 0x4001936
    public GameObject treasureIcon;

    // Token: 0x4001937
    public GameObject medIcon;

    // Token: 0x4001938
    public GameObject foodIcon;

    // Token: 0x4001939
    public bool needRefresh;

    // Token: 0x400193A
    private static MeditationUIController _instance;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6001986
    // RVA   : 0xE87440   Offset: 0xE86240   Length: 0x36
    public static MeditationUIController get_Instance()
    {
        return **(uint64 **)(DAT_181e68d70 + 184);
    }

    // Token : 0x6001987
    // RVA   : 0xE82970   Offset: 0xE81770   Length: 0x43
    private void Awake()
    {
        puVar1 = *(uint64 **)(DAT_181e68d70 + 184);
        *puVar1 = this;
        il2cpp_internal(puVar1,this);
    }

    // Token : 0x6001988
    // RVA   : 0xE87400   Offset: 0xE86200   Length: 0x3D
    private void Update()
    {
        bool cVar1;
        if (this.meditationUI == null) {
                          // WARNING: Subroutine does not return
          FUN_1801e0300();
        }
        cVar1 = GameObject.get_activeSelf(this.meditationUI,0);
        if ((cVar1) && (this.needRefresh)) {
          MeditationUIController.RefreshUI(this,0);
          return;
        }
    }

    // Token : 0x6001989
    // RVA   : 0xE83460   Offset: 0xE82260   Length: 0x1EF
    public void HideMeditationUI()
    {
        ulong uVar1;
        bool cVar2;
        uVar1 = this.treasureIcon;
        cVar2 = Object.op_Inequality(uVar1,0,0);
        if (cVar2) {
          uVar1 = this.treasureIcon;
          Object.Destroy(uVar1,0);
          this.treasureIcon = 0;
          this.needRefresh = 1;
        }
        uVar1 = this.foodIcon;
        cVar2 = Object.op_Inequality(uVar1,0,0);
        if (cVar2) {
          uVar1 = this.foodIcon;
          Object.Destroy(uVar1,0);
          this.foodIcon = 0;
          this.needRefresh = 1;
        }
        uVar1 = this.medIcon;
        cVar2 = Object.op_Inequality(uVar1,0,0);
        if (cVar2) {
          uVar1 = this.medIcon;
          Object.Destroy(uVar1,0);
          this.medIcon = 0;
        }
        this.needRefresh = 0;
        if (this.meditationUI != null) {
          GameObject.SetActive(this.meditationUI,0,0);
          return;
        }
    }

    // Token : 0x600198A
    // RVA   : 0xE861E0   Offset: 0xE84FE0   Length: 0x234
    public void ShowMeditationUI()
    {
        long lVar1;
        ulong uVar2;
        ulong uVar3;
        if (this.meditationUI != null) {
          GameObject.SetActive(this.meditationUI,1,0);
          if (this.meditationUI != null) {
            lVar1 = GameObject.get_transform(this.meditationUI,0);
            if (lVar1 != null) {
              lVar1 = Transform.Find(lVar1,"Title",0);
              if (lVar1 != null) {
                uVar2 = Component.GetComponent(lVar1,DAT_181e79538);
                if ((GameController._instance != null) &&
                   (lVar1 = GameController._instance.worldData) != null) {
                  lVar1 = WorldData.Player(lVar1,0);
                  if (lVar1 != null) {
                    uVar3 = HeroData.GetMeditationTopic(lVar1,0);
                    uVar3 = String.Concat(uVar3,"修行",0);
                    LTLocalization.SetText(uVar2,uVar3,0);
                    MeditationUIController.RefreshUI(this,0);
                    plVar4 = (int64 *)Resources.Load("Sound/SoundEffect/OpenBook",0);
                    plVar5 = (int64 *)0;
                    if ((plVar4 != (int64 *)0) && (*plVar4 == DAT_181e8f4a0)) {
                      plVar5 = plVar4;
                    }
                    NGUITools.PlaySound(plVar5,0);
                    return;
                  }
                }
              }
            }
          }
        }
    }

    // Token : 0x600198B
    // RVA   : 0xE83E10   Offset: 0xE82C10   Length: 0x23CC
    public void RefreshUI()
    {
        var pStatics_38e8 = *(int64*)(DAT_181e538e8 + 184);
        float fVar2;
        long lVar3;
        bool cVar4;
        byte uVar5;
        long lVar6;
        ulong uVar7;
        ulong uVar8;
        ulong uVar9;
        float fVar12;
        float[] local_res8 = new float[4];
        int[] local_res18 = new int[2];
        uint[] local_res20 = new uint[2];
        uint[] local_68 = new uint[4];
        uint local_58;
        uint uStack_54;
        uint uStack_50;
        uint32 uStack_4c;
        this.needRefresh = 0;
        if (this.meditationUI == null) {
        LAB_180e861cb:
                          // WARNING: Subroutine does not return
          FUN_1801e0300();
        }
        lVar6 = GameObject.get_transform(this.meditationUI,0);
        if (lVar6 == null) goto LAB_180e861cb;
        lVar6 = Transform.Find(lVar6,"MeditationLv",0);
        if (lVar6 == null) goto LAB_180e861cb;
        uVar7 = Component.GetComponent(lVar6,DAT_181e79538);
        if ((GameController._instance == null) ||
           (lVar6 = GameController._instance.worldData) == null)
        goto LAB_180e861cb;
        lVar6 = WorldData.Player(lVar6,0);
        if (lVar6 == null) goto LAB_180e861cb;
        uVar8 = HeroData.GetMeditationTopic(lVar6,0);
        if (((GameController._instance == null) ||
            (lVar6 = GameController._instance.worldData) == null) ||
           (lVar6 = lVar6.meditationData) == null) goto LAB_180e861cb;
        uVar9 = Int32.ToString(lVar6 + 16,0);
        uVar8 = String.Concat(uVar8,"等级",uVar9,0);
        LTLocalization.SetText(uVar7,uVar8,0);
        if (this.meditationUI == null) goto LAB_180e861cb;
        lVar6 = GameObject.get_transform(this.meditationUI,0);
        if (lVar6 == null) goto LAB_180e861cb;
        lVar6 = Transform.Find(lVar6,"MeditationLvAdd",0);
        if (lVar6 == null) goto LAB_180e861cb;
        uVar7 = Component.GetComponent(lVar6,DAT_181e79538);
        if ((GameController._instance == null) ||
           (lVar6 = GameController._instance.worldData) == null)
        goto LAB_180e861cb;
        lVar6 = WorldData.Player(lVar6,0);
        if (lVar6 == null) goto LAB_180e861cb;
        lVar6 = HeroData.GetForce(lVar6,0,0);
        if (lVar6 == null) goto LAB_180e861cb;
        uVar8 = ForceData.GetForceName(lVar6,1,0);
        if (((GameController._instance == null) ||
            (lVar6 = GameController._instance.worldData) == null) ||
           (lVar6 = lVar6.meditationData) == null) goto LAB_180e861cb;
        local_res18[0] = lVar6.chapter * 2;
        uVar9 = il2cpp_value_box(DAT_181e60808,local_res18);
        uVar8 = String.Format("等级加成\n{0}武学威力+{1}%",uVar8,uVar9,0);
        LTLocalization.SetText(uVar7,uVar8,0);
        if (this.meditationUI == null) goto LAB_180e861cb;
        lVar6 = GameObject.get_transform(this.meditationUI,0);
        if (lVar6 == null) goto LAB_180e861cb;
        lVar6 = Transform.Find(lVar6,"ExpBarBack",0);
        if (lVar6 == null) goto LAB_180e861cb;
        lVar6 = Transform.Find(lVar6,"ExpText",0);
        if (lVar6 == null) goto LAB_180e861cb;
        uVar7 = Component.GetComponent(lVar6,DAT_181e79538);
        if (((GameController._instance == null) ||
            (lVar6 = GameController._instance.worldData) == null) ||
           (lVar6 = lVar6.meditationData) == null) goto LAB_180e861cb;
        uVar8 = Single.ToString(lVar6 + 20,"f0",0);
        if (((GameController._instance == null) ||
            (lVar6 = GameController._instance.worldData) == null) ||
           (lVar6 = lVar6.meditationData) == null) goto LAB_180e861cb;
        local_res20[0] = MeditationData.GetMaxExp(lVar6,0);
        uVar9 = il2cpp_value_box(DAT_181e82730,local_res20);
        uVar8 = String.Format("{0}/{1}",uVar8,uVar9,0);
        LTLocalization.SetText(uVar7,uVar8,0);
        if (this.meditationUI == null) goto LAB_180e861cb;
        lVar6 = GameObject.get_transform(this.meditationUI,0);
        if (lVar6 == null) goto LAB_180e861cb;
        lVar6 = Transform.Find(lVar6,"ExpBarBack",0);
        if (lVar6 == null) goto LAB_180e861cb;
        lVar6 = Transform.Find(lVar6,"ExpBar",0);
        if (lVar6 == null) goto LAB_180e861cb;
        lVar6 = Component.GetComponent(lVar6,DAT_181e777b8);
        if (((GameController._instance == null) ||
            (lVar3 = GameController._instance.worldData) == null) ||
           (lVar3 = lVar3.meditationData) == null) goto LAB_180e861cb;
        fVar2 = *(float *)(lVar3 + 20);
        if (((GameController._instance == null) ||
            (lVar3 = GameController._instance.worldData) == null) ||
           (lVar3 = lVar3.meditationData) == null) goto LAB_180e861cb;
        fVar12 = (float)MeditationData.GetMaxExp(lVar3,0);
        if (lVar6 == null) goto LAB_180e861cb;
        Image.set_fillAmount(lVar6,fVar2 / fVar12,0);
        if (this.meditationUI == null) goto LAB_180e861cb;
        lVar6 = GameObject.get_transform(this.meditationUI,0);
        if (lVar6 == null) goto LAB_180e861cb;
        lVar6 = Transform.Find(lVar6,"MeditationText",0);
        if (lVar6 == null) goto LAB_180e861cb;
        uVar7 = Component.GetComponent(lVar6,DAT_181e79538);
        if (((GameController._instance == null) ||
            (lVar6 = GameController._instance.worldData) == null) ||
           (lVar6 = lVar6.meditationData) == null) goto LAB_180e861cb;
        local_res8[0] = (float)MeditationData.MeditationExpRate(lVar6,0);
        local_res8[0] = local_res8[0] * 100.0;
        uVar8 = Single.ToString(local_res8,"f0",0);
        if (((GameController._instance == null) ||
            (lVar6 = GameController._instance.worldData) == null) ||
           (lVar6 = lVar6.meditationData) == null) goto LAB_180e861cb;
        local_res8[0] = (float)MeditationData.MeditationExpNum(lVar6,0);
        uVar9 = Single.ToString(local_res8,"f0",0);
        uVar8 = String.Format("每日经验 <b>{1}</b>\n修行效率 <b>{0}%</b>",uVar8,uVar9,0);
        LTLocalization.SetText(uVar7,uVar8,0);
        if (this.meditationUI == null) goto LAB_180e861cb;
        lVar6 = GameObject.get_transform(this.meditationUI,0);
        if (lVar6 == null) goto LAB_180e861cb;
        lVar6 = Transform.Find(lVar6,"StartMeditationButton",0);
        if (lVar6 == null) goto LAB_180e861cb;
        lVar6 = Component.GetComponent(lVar6,DAT_181e788b8);
        if (((GameController._instance == null) ||
            (lVar3 = GameController._instance.worldData) == null) ||
           (lVar3 = lVar3.meditationData) == null) goto LAB_180e861cb;
        local_68[0] = lVar3.cityAreaID;
        uVar7 = il2cpp_value_box(DAT_181e60808,local_68);
        uVar7 = String.Format("本月已修行{0}日\n每修行一日，本月修行效率都会下降20%",uVar7,0);
        if (lVar6 == null) goto LAB_180e861cb;
        lVar6.cityAreaID = uVar7;
        if (((GameController._instance == null) ||
            (lVar6 = GameController._instance.worldData) == null) ||
           (lVar6 = lVar6.meditationData) == null) goto LAB_180e861cb;
        if (lVar6.Areas < 1) {
          if (this.meditationUI == null) throw; // [null/range check failed]
          lVar6 = GameObject.get_transform(this.meditationUI,0);
          if (lVar6 == null) throw; // [null/range check failed]
          lVar6 = Transform.Find(lVar6,"TreasureSureButton",0);
          if (lVar6 == null) throw; // [null/range check failed]
          lVar6 = Component.GetComponent(lVar6,DAT_181e76ab8);
          uVar7 = this.treasureIcon;
          uVar5 = Object.op_Inequality(uVar7,0,0);
          if (lVar6 == null) throw; // [null/range check failed]
          Selectable.set_interactable(lVar6,uVar5,0);
          if (this.meditationUI == null) throw; // [null/range check failed]
          lVar6 = GameObject.get_transform(this.meditationUI,0);
          if (lVar6 == null) throw; // [null/range check failed]
          lVar6 = Transform.Find(lVar6,"TreasureSureButton",0);
          if (lVar6 == null) throw; // [null/range check failed]
          lVar6 = Transform.Find(lVar6,"Text",0);
          if (lVar6 == null) throw; // [null/range check failed]
          uVar7 = Component.GetComponent(lVar6,DAT_181e79538);
          LTLocalization.SetText(uVar7,"供奉",0);
          if (this.meditationUI == null) throw; // [null/range check failed]
          lVar6 = GameObject.get_transform(this.meditationUI,0);
          if (lVar6 == null) throw; // [null/range check failed]
          lVar6 = Transform.Find(lVar6,"TreasureSureButton",0);
          if (lVar6 == null) throw; // [null/range check failed]
          lVar6 = Transform.Find(lVar6,"Text",0);
          if (lVar6 == null) throw; // [null/range check failed]
          plVar10 = (int64 *)Component.GetComponent(lVar6,DAT_181e79538);
          puVar11 = (uint32 *)Color.get_black(&local_58,0);
          if (plVar10 == (int64 *)0) throw; // [null/range check failed]
          local_58 = *puVar11;
          uStack_54 = puVar11[1];
          uStack_50 = puVar11[2];
          uStack_4c = puVar11[3];
          (**(code **)(*plVar10 + 0x2a8))(plVar10,&local_58,*(uint64 *)(*plVar10 + 0x2b0));
          if (this.meditationUI == null) throw; // [null/range check failed]
          lVar6 = GameObject.get_transform(this.meditationUI,0);
          if (lVar6 == null) throw; // [null/range check failed]
          lVar6 = Transform.Find(lVar6,"ClearTreasureButton",0);
          if (lVar6 == null) throw; // [null/range check failed]
          lVar6 = Component.get_gameObject(lVar6,0);
          uVar5 = Object.op_Inequality(this.treasureIcon,0,0);
          if (lVar6 == null) throw; // [null/range check failed]
          GameObject.SetActive(lVar6,uVar5,0);
          if (this.meditationUI == null) throw; // [null/range check failed]
          lVar6 = GameObject.get_transform(this.meditationUI,0);
          if (lVar6 == null) throw; // [null/range check failed]
          lVar6 = Transform.Find(lVar6,"TreasureAddText",0);
          if (lVar6 == null) throw; // [null/range check failed]
          uVar8 = Component.GetComponent(lVar6,DAT_181e79538);
          uVar7 = "";
        }
        else {
          uVar7 = this.treasureIcon;
          cVar4 = Object.op_Equality(uVar7,0,0);
          if (cVar4) {
            if (this.meditationUI == null) throw; // [null/range check failed]
            lVar6 = GameObject.get_transform(this.meditationUI,0);
            if (lVar6 == null) throw; // [null/range check failed]
            lVar6 = Transform.Find(lVar6,"Treasure",0);
            if (lVar6 == null) throw; // [null/range check failed]
            uVar7 = Component.get_gameObject(lVar6,0);
            lVar6 = FUN_1802106e0(0);
            if (((lVar6 == null) || (lVar6.villageAreaID == null)) ||
               (lVar6 = *(int64 *)(lVar6.villageAreaID + 0x1f0)) == null)
            throw; // [null/range check failed]
            uVar7 = MeditationUIController.CreateMeditationItemIcon
                              (this,uVar7,lVar6.villageAreaID,0);
            *puVar1 = uVar7;
            il2cpp_internal(puVar1,uVar7);
          }
          if (this.meditationUI == null) throw; // [null/range check failed]
          lVar6 = GameObject.get_transform(this.meditationUI,0);
          if (lVar6 == null) throw; // [null/range check failed]
          lVar6 = Transform.Find(lVar6,"TreasureSureButton",0);
          if (lVar6 == null) throw; // [null/range check failed]
          lVar6 = Component.GetComponent(lVar6,DAT_181e76ab8);
          if (lVar6 == null) throw; // [null/range check failed]
          Selectable.set_interactable(lVar6,0,0);
          if (this.meditationUI == null) throw; // [null/range check failed]
          lVar6 = GameObject.get_transform(this.meditationUI,0);
          if (lVar6 == null) throw; // [null/range check failed]
          lVar6 = Transform.Find(lVar6,"TreasureSureButton",0);
          if (lVar6 == null) throw; // [null/range check failed]
          lVar6 = Transform.Find(lVar6,"Text",0);
          if (lVar6 == null) throw; // [null/range check failed]
          uVar7 = Component.GetComponent(lVar6,DAT_181e79538);
          if (((GameController._instance == null) ||
              (lVar6 = GameController._instance.worldData) == null) ||
             (lVar6 = lVar6.meditationData) == null) throw; // [null/range check failed]
          uVar8 = Int32.ToString(lVar6 + 48,0);
          uVar8 = String.Concat(uVar8,"日",0);
          LTLocalization.SetText(uVar7,uVar8,0);
          if (this.meditationUI == null) throw; // [null/range check failed]
          lVar6 = GameObject.get_transform(this.meditationUI,0);
          if (lVar6 == null) throw; // [null/range check failed]
          lVar6 = Transform.Find(lVar6,"TreasureSureButton",0);
          if (lVar6 == null) throw; // [null/range check failed]
          lVar6 = Transform.Find(lVar6,"Text",0);
          if (lVar6 == null) throw; // [null/range check failed]
          plVar10 = (int64 *)Component.GetComponent(lVar6,DAT_181e79538);
          lVar6 = pStatics_38e8;
          if (plVar10 == (int64 *)0) throw; // [null/range check failed]
          local_58 = *(uint32 *)(lVar6 + 0x380);
          uStack_54 = *(uint32 *)(lVar6 + 900);
          uStack_50 = *(uint32 *)(lVar6 + 0x388);
          uStack_4c = *(uint32 *)(lVar6 + 0x38c);
          (**(code **)(*plVar10 + 0x2a8))(plVar10,&local_58,*(uint64 *)(*plVar10 + 0x2b0));
          if (this.meditationUI == null) throw; // [null/range check failed]
          lVar6 = GameObject.get_transform(this.meditationUI,0);
          if (lVar6 == null) throw; // [null/range check failed]
          lVar6 = Transform.Find(lVar6,"ClearTreasureButton",0);
          if (lVar6 == null) throw; // [null/range check failed]
          lVar6 = Component.get_gameObject(lVar6,0);
          if (lVar6 == null) throw; // [null/range check failed]
          GameObject.SetActive(lVar6,0,0);
          if (this.meditationUI == null) throw; // [null/range check failed]
          lVar6 = GameObject.get_transform(this.meditationUI,0);
          if (lVar6 == null) throw; // [null/range check failed]
          lVar6 = Transform.Find(lVar6,"TreasureAddText",0);
          if (lVar6 == null) throw; // [null/range check failed]
          uVar8 = Component.GetComponent(lVar6,DAT_181e79538);
          if ((((GameController._instance == null) ||
               (lVar6 = GameController._instance.worldData) == null) ||
              (lVar6 = lVar6.meditationData) == null) ||
             (lVar6 = lVar6.forceAreaID) == null) throw; // [null/range check failed]
          uVar7 = HeroSpeAddData.GetDescribe(lVar6,1,1,1,0,0);
        }
        LTLocalization.SetText(uVar8,uVar7,0);
        if (((GameController._instance == null) ||
            (lVar6 = GameController._instance.worldData) == null) ||
           (lVar6 = lVar6.meditationData) == null) throw; // [null/range check failed]
        if (lVar6.Forces < 1) {
          if (this.meditationUI == null) throw; // [null/range check failed]
          lVar6 = GameObject.get_transform(this.meditationUI,0);
          if (lVar6 == null) throw; // [null/range check failed]
          lVar6 = Transform.Find(lVar6,"FoodSureButton",0);
          if (lVar6 == null) throw; // [null/range check failed]
          lVar6 = Component.GetComponent(lVar6,DAT_181e76ab8);
          uVar7 = this.foodIcon;
          uVar5 = Object.op_Inequality(uVar7,0,0);
          if (lVar6 == null) throw; // [null/range check failed]
          Selectable.set_interactable(lVar6,uVar5,0);
          if (this.meditationUI == null) throw; // [null/range check failed]
          lVar6 = GameObject.get_transform(this.meditationUI,0);
          if (lVar6 == null) throw; // [null/range check failed]
          lVar6 = Transform.Find(lVar6,"FoodSureButton",0);
          if (lVar6 == null) throw; // [null/range check failed]
          lVar6 = Transform.Find(lVar6,"Text",0);
          if (lVar6 == null) throw; // [null/range check failed]
          uVar7 = Component.GetComponent(lVar6,DAT_181e79538);
          LTLocalization.SetText(uVar7,"供奉",0);
          if (this.meditationUI == null) throw; // [null/range check failed]
          lVar6 = GameObject.get_transform(this.meditationUI,0);
          if (lVar6 == null) throw; // [null/range check failed]
          lVar6 = Transform.Find(lVar6,"FoodSureButton",0);
          if (lVar6 == null) throw; // [null/range check failed]
          lVar6 = Transform.Find(lVar6,"Text",0);
          if (lVar6 == null) throw; // [null/range check failed]
          plVar10 = (int64 *)Component.GetComponent(lVar6,DAT_181e79538);
          puVar11 = (uint32 *)Color.get_black(&local_58,0);
          if (plVar10 == (int64 *)0) throw; // [null/range check failed]
          local_58 = *puVar11;
          uStack_54 = puVar11[1];
          uStack_50 = puVar11[2];
          uStack_4c = puVar11[3];
          (**(code **)(*plVar10 + 0x2a8))(plVar10,&local_58,*(uint64 *)(*plVar10 + 0x2b0));
          if (this.meditationUI == null) throw; // [null/range check failed]
          lVar6 = GameObject.get_transform(this.meditationUI,0);
          if (lVar6 == null) throw; // [null/range check failed]
          lVar6 = Transform.Find(lVar6,"ClearFoodButton",0);
          if (lVar6 == null) throw; // [null/range check failed]
          lVar6 = Component.get_gameObject(lVar6,0);
          uVar5 = Object.op_Inequality(this.foodIcon,0,0);
          if (lVar6 == null) throw; // [null/range check failed]
          GameObject.SetActive(lVar6,uVar5,0);
          if (this.meditationUI == null) throw; // [null/range check failed]
          lVar6 = GameObject.get_transform(this.meditationUI,0);
          if (lVar6 == null) throw; // [null/range check failed]
          lVar6 = Transform.Find(lVar6,"FoodAddText",0);
          if (lVar6 == null) throw; // [null/range check failed]
          uVar8 = Component.GetComponent(lVar6,DAT_181e79538);
          uVar7 = "";
        }
        else {
          uVar7 = this.foodIcon;
          cVar4 = Object.op_Equality(uVar7,0,0);
          if (cVar4) {
            if (this.meditationUI == null) throw; // [null/range check failed]
            lVar6 = GameObject.get_transform(this.meditationUI,0);
            if (lVar6 == null) throw; // [null/range check failed]
            lVar6 = Transform.Find(lVar6,"Food",0);
            if (lVar6 == null) throw; // [null/range check failed]
            uVar7 = Component.get_gameObject(lVar6,0);
            lVar6 = FUN_1802106e0(0);
            if (((lVar6 == null) || (lVar6.villageAreaID == null)) ||
               (lVar6 = *(int64 *)(lVar6.villageAreaID + 0x1f0)) == null)
            throw; // [null/range check failed]
            uVar7 = MeditationUIController.CreateMeditationItemIcon
                              (this,uVar7,lVar6.Inns,0);
            *puVar1 = uVar7;
            il2cpp_internal(puVar1,uVar7);
          }
          if (this.meditationUI == null) throw; // [null/range check failed]
          lVar6 = GameObject.get_transform(this.meditationUI,0);
          if (lVar6 == null) throw; // [null/range check failed]
          lVar6 = Transform.Find(lVar6,"FoodSureButton",0);
          if (lVar6 == null) throw; // [null/range check failed]
          lVar6 = Component.GetComponent(lVar6,DAT_181e76ab8);
          if (lVar6 == null) throw; // [null/range check failed]
          Selectable.set_interactable(lVar6,0,0);
          if (this.meditationUI == null) throw; // [null/range check failed]
          lVar6 = GameObject.get_transform(this.meditationUI,0);
          if (lVar6 == null) throw; // [null/range check failed]
          lVar6 = Transform.Find(lVar6,"FoodSureButton",0);
          if (lVar6 == null) throw; // [null/range check failed]
          lVar6 = Transform.Find(lVar6,"Text",0);
          if (lVar6 == null) throw; // [null/range check failed]
          uVar7 = Component.GetComponent(lVar6,DAT_181e79538);
          if (((GameController._instance == null) ||
              (lVar6 = GameController._instance.worldData) == null) ||
             (lVar6 = lVar6.meditationData) == null) throw; // [null/range check failed]
          uVar8 = Int32.ToString(lVar6 + 72,0);
          uVar8 = String.Concat(uVar8,"日",0);
          LTLocalization.SetText(uVar7,uVar8,0);
          if (this.meditationUI == null) throw; // [null/range check failed]
          lVar6 = GameObject.get_transform(this.meditationUI,0);
          if (lVar6 == null) throw; // [null/range check failed]
          lVar6 = Transform.Find(lVar6,"FoodSureButton",0);
          if (lVar6 == null) throw; // [null/range check failed]
          lVar6 = Transform.Find(lVar6,"Text",0);
          if (lVar6 == null) throw; // [null/range check failed]
          plVar10 = (int64 *)Component.GetComponent(lVar6,DAT_181e79538);
          lVar6 = pStatics_38e8;
          if (plVar10 == (int64 *)0) throw; // [null/range check failed]
          local_58 = *(uint32 *)(lVar6 + 0x380);
          uStack_54 = *(uint32 *)(lVar6 + 900);
          uStack_50 = *(uint32 *)(lVar6 + 0x388);
          uStack_4c = *(uint32 *)(lVar6 + 0x38c);
          (**(code **)(*plVar10 + 0x2a8))(plVar10,&local_58,*(uint64 *)(*plVar10 + 0x2b0));
          if (this.meditationUI == null) throw; // [null/range check failed]
          lVar6 = GameObject.get_transform(this.meditationUI,0);
          if (lVar6 == null) throw; // [null/range check failed]
          lVar6 = Transform.Find(lVar6,"ClearFoodButton",0);
          if (lVar6 == null) throw; // [null/range check failed]
          lVar6 = Component.get_gameObject(lVar6,0);
          if (lVar6 == null) throw; // [null/range check failed]
          GameObject.SetActive(lVar6,0,0);
          if (this.meditationUI == null) throw; // [null/range check failed]
          lVar6 = GameObject.get_transform(this.meditationUI,0);
          if (lVar6 == null) throw; // [null/range check failed]
          lVar6 = Transform.Find(lVar6,"FoodAddText",0);
          if (lVar6 == null) throw; // [null/range check failed]
          uVar8 = Component.GetComponent(lVar6,DAT_181e79538);
          if ((((GameController._instance == null) ||
               (lVar6 = GameController._instance.worldData) == null) ||
              (lVar6 = lVar6.meditationData) == null) ||
             (lVar6 = lVar6.ResourcePoints) == null) throw; // [null/range check failed]
          uVar7 = HeroSpeAddData.GetDescribe(lVar6,1,1,1,0,0);
        }
        LTLocalization.SetText(uVar8,uVar7,0);
        if (((GameController._instance == null) ||
            (lVar6 = GameController._instance.worldData) == null) ||
           (lVar6 = lVar6.meditationData) == null) throw; // [null/range check failed]
        if (lVar6.BigMapRandomEventDatas < 1) {
          if (this.meditationUI != null) {
            lVar6 = GameObject.get_transform(this.meditationUI,0);
            if (lVar6 != null) {
              lVar6 = Transform.Find(lVar6,"MedSureButton",0);
              if (lVar6 == null) throw; // [null/range check failed]
              lVar6 = Component.GetComponent(lVar6,DAT_181e76ab8);
              uVar7 = this.medIcon;
              uVar5 = Object.op_Inequality(uVar7,0,0);
              if (lVar6 == null) throw; // [null/range check failed]
              Selectable.set_interactable(lVar6,uVar5,0);
              if (this.meditationUI == null) throw; // [null/range check failed]
              lVar6 = GameObject.get_transform(this.meditationUI,0);
              if (lVar6 == null) throw; // [null/range check failed]
              lVar6 = Transform.Find(lVar6,"MedSureButton",0);
              if (lVar6 == null) throw; // [null/range check failed]
              lVar6 = Transform.Find(lVar6,"Text",0);
              if (lVar6 == null) throw; // [null/range check failed]
              uVar7 = Component.GetComponent(lVar6,DAT_181e79538);
              LTLocalization.SetText(uVar7,"供奉",0);
              if (this.meditationUI == null) throw; // [null/range check failed]
              lVar6 = GameObject.get_transform(this.meditationUI,0);
              if (lVar6 == null) throw; // [null/range check failed]
              lVar6 = Transform.Find(lVar6,"MedSureButton",0);
              if (lVar6 == null) throw; // [null/range check failed]
              lVar6 = Transform.Find(lVar6,"Text",0);
              if (lVar6 == null) throw; // [null/range check failed]
              plVar10 = (int64 *)Component.GetComponent(lVar6,DAT_181e79538);
              puVar11 = (uint32 *)Color.get_black(&local_58,0);
              if (plVar10 == (int64 *)0) throw; // [null/range check failed]
              local_58 = *puVar11;
              uStack_54 = puVar11[1];
              uStack_50 = puVar11[2];
              uStack_4c = puVar11[3];
              (**(code **)(*plVar10 + 0x2a8))(plVar10,&local_58,*(uint64 *)(*plVar10 + 0x2b0));
              if (this.meditationUI == null) throw; // [null/range check failed]
              lVar6 = GameObject.get_transform(this.meditationUI,0);
              if (lVar6 == null) throw; // [null/range check failed]
              lVar6 = Transform.Find(lVar6,"ClearMedButton",0);
              if (lVar6 == null) throw; // [null/range check failed]
              lVar6 = Component.get_gameObject(lVar6,0);
              uVar5 = Object.op_Inequality(this.medIcon,0,0);
              if (lVar6 == null) throw; // [null/range check failed]
              GameObject.SetActive(lVar6,uVar5,0);
              if (this.meditationUI == null) throw; // [null/range check failed]
              lVar6 = GameObject.get_transform(this.meditationUI,0);
              if (lVar6 == null) throw; // [null/range check failed]
              lVar6 = Transform.Find(lVar6,"MedAddText",0);
              if (lVar6 == null) throw; // [null/range check failed]
              uVar8 = Component.GetComponent(lVar6,DAT_181e79538);
              uVar7 = "";
        LAB_180e86053:
              LTLocalization.SetText(uVar8,uVar7,0);
              if (this.meditationUI != null) {
                lVar6 = GameObject.get_transform(this.meditationUI,0);
                if (lVar6 != null) {
                  lVar6 = Transform.Find(lVar6,"TreasureSureButton",0);
                  if (lVar6 != null) {
                    lVar6 = Component.GetComponent(lVar6,DAT_181e788b8);
                    uVar7 = MeditationUIController.GetItemMeditationEffectDescribe
                                      (this,this.treasureIcon,0);
                    if (lVar6 != null) {
                      lVar6.cityAreaID = uVar7;
                      if (this.meditationUI != null) {
                        lVar6 = GameObject.get_transform(this.meditationUI,0);
                        if (lVar6 != null) {
                          lVar6 = Transform.Find(lVar6,"FoodSureButton",0);
                          if (lVar6 != null) {
                            lVar6 = Component.GetComponent(lVar6,DAT_181e788b8);
                            uVar7 = MeditationUIController.GetItemMeditationEffectDescribe
                                              (this,this.foodIcon,0);
                            if (lVar6 != null) {
                              lVar6.cityAreaID = uVar7;
                              if (this.meditationUI != null) {
                                lVar6 = GameObject.get_transform(this.meditationUI,0);
                                if (lVar6 != null) {
                                  lVar6 = Transform.Find(lVar6,"MedSureButton",0);
                                  if (lVar6 != null) {
                                    lVar6 = Component.GetComponent(lVar6,DAT_181e788b8);
                                    uVar7 = MeditationUIController.GetItemMeditationEffectDescribe
                                                      (this,this.medIcon,0);
                                    if (lVar6 != null) {
                                      lVar6.cityAreaID = uVar7;
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
                          // WARNING: Subroutine does not return
              FUN_1801e0300();
            }
          }
        }
        else {
          uVar7 = this.medIcon;
          cVar4 = Object.op_Equality(uVar7,0,0);
          if (cVar4) {
            if (this.meditationUI == null) throw; // [null/range check failed]
            lVar6 = GameObject.get_transform(this.meditationUI,0);
            if (lVar6 == null) throw; // [null/range check failed]
            lVar6 = Transform.Find(lVar6,"Med",0);
            if (lVar6 == null) throw; // [null/range check failed]
            uVar7 = Component.get_gameObject(lVar6,0);
            lVar6 = FUN_1802106e0(0);
            if (((lVar6 == null) || (lVar6.villageAreaID == null)) ||
               (lVar6 = *(int64 *)(lVar6.villageAreaID + 0x1f0)) == null)
            throw; // [null/range check failed]
            uVar7 = MeditationUIController.CreateMeditationItemIcon
                              (this,uVar7,lVar6.Heros,0);
            *puVar1 = uVar7;
            il2cpp_internal(puVar1,uVar7);
          }
          if (this.meditationUI != null) {
            lVar6 = GameObject.get_transform(this.meditationUI,0);
            if (lVar6 != null) {
              lVar6 = Transform.Find(lVar6,"MedSureButton",0);
              if (lVar6 != null) {
                lVar6 = Component.GetComponent(lVar6,DAT_181e76ab8);
                if (lVar6 != null) {
                  Selectable.set_interactable(lVar6,0,0);
                  if (this.meditationUI != null) {
                    lVar6 = GameObject.get_transform(this.meditationUI,0);
                    if (lVar6 != null) {
                      lVar6 = Transform.Find(lVar6,"MedSureButton",0);
                      if (lVar6 != null) {
                        lVar6 = Transform.Find(lVar6,"Text",0);
                        if (lVar6 != null) {
                          uVar7 = Component.GetComponent(lVar6,DAT_181e79538);
                          if (((GameController._instance != null) &&
                              (lVar6 = GameController._instance.worldData,
                              lVar6 != null)) && (lVar6 = lVar6.meditationData) != null) {
                            uVar8 = Int32.ToString(lVar6 + 96,0);
                            uVar8 = String.Concat(uVar8,"日",0);
                            LTLocalization.SetText(uVar7,uVar8,0);
                            if (this.meditationUI != null) {
                              lVar6 = GameObject.get_transform(this.meditationUI,0);
                              if (lVar6 != null) {
                                lVar6 = Transform.Find(lVar6,"MedSureButton",0);
                                if (lVar6 != null) {
                                  lVar6 = Transform.Find(lVar6,"Text",0);
                                  if (lVar6 != null) {
                                    plVar10 = (int64 *)Component.GetComponent(lVar6,DAT_181e79538);
                                    lVar6 = pStatics_38e8;
                                    if (plVar10 != (int64 *)0) {
                                      local_58 = *(uint32 *)(lVar6 + 0x380);
                                      uStack_54 = *(uint32 *)(lVar6 + 900);
                                      uStack_50 = *(uint32 *)(lVar6 + 0x388);
                                      uStack_4c = *(uint32 *)(lVar6 + 0x38c);
                                      (**(code **)(*plVar10 + 0x2a8))
                                                (plVar10,&local_58,*(uint64 *)(*plVar10 + 0x2b0));
                                      if (this.meditationUI != null) {
                                        lVar6 = GameObject.get_transform(this.meditationUI,0)
                                        ;
                                        if (lVar6 != null) {
                                          lVar6 = Transform.Find(lVar6,"ClearMedButton",0);
                                          if (lVar6 != null) {
                                            lVar6 = Component.get_gameObject(lVar6,0);
                                            if (lVar6 != null) {
                                              GameObject.SetActive(lVar6,0,0);
                                              if (this.meditationUI != null) {
                                                lVar6 = GameObject.get_transform
                                                                  (this.meditationUI,0);
                                                if (lVar6 != null) {
                                                  lVar6 = Transform.Find(lVar6,"MedAddText",0);
                                                  if (lVar6 != null) {
                                                    uVar8 = Component.GetComponent(lVar6,DAT_181e79538);
                                                    if ((((GameController._instance != null) &&
                                                         (lVar6 = *(int64 *)
                                                                   (GameController._instance
                                                                   + 32), lVar6 != null)) &&
                                                        (lVar6 = lVar6.meditationData) != null
                                                        ) && (lVar6 = lVar6.TempHeros,
                                                             lVar6 != null)) {
                                                      uVar7 = HeroSpeAddData.GetDescribe(lVar6,1,1,1,0,0)
                                                      ;
                                                      goto LAB_180e86053;
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

    // Token : 0x600198C
    // RVA   : 0xE831F0   Offset: 0xE81FF0   Length: 0x267
    public string GetItemMeditationEffectDescribe(GameObject itemIcon)
    {
        uint64
        MeditationUIController.GetItemMeditationEffectDescribe(uint64 this,int64 itemIcon)
        {
        int64 lVar1;
        char cVar2;
        int64 lVar3;
        uint64 uVar4;
        uint64 uVar5;
        float local_res10 [2];
        cVar2 = Object.op_Equality(itemIcon,0,0);
        if (cVar2) {
          return "";
        }
        if (((GameController._instance != null) &&
            (lVar1 = GameController._instance.worldData) != null) &&
           (lVar1 = lVar1.meditationData, itemIcon != null)) {
          lVar3 = GameObject.GetComponent(itemIcon,DAT_181e55168);
          if ((lVar3 != null) && (lVar1 != null)) {
            local_res10[0] = (float)MeditationData.GetItemExpRate(lVar1,*(uint64 *)(lVar3 + 32),0);
            local_res10[0] = local_res10[0] * 100.0;
            uVar4 = Single.ToString(local_res10,"f0",0);
            if ((GameController._instance != null) &&
               (lVar1 = GameController._instance.worldData) != null) {
              lVar1 = lVar1.meditationData;
              lVar3 = GameObject.GetComponent(itemIcon,DAT_181e55168);
              if ((lVar3 != null) && (lVar1 != null)) {
                local_res10[0] =
                     (float)MeditationData.GetItemExpNum(lVar1,*(uint64 *)(lVar3 + 32),0);
                uVar5 = Single.ToString(local_res10,"f0",0);
                uVar4 = String.Format("每日经验+{1}\n修行效率+{0}%",uVar4,uVar5,0);
                return uVar4;
              }
            }
          }
        }
    }

    // Token : 0x600198D
    // RVA   : 0xE82C00   Offset: 0xE81A00   Length: 0x12A
    public GameObject CreateMeditationItemIcon(GameObject parent, ItemData targetItemData)
    {
        var pStatics = *(int64*)(DAT_181e52a90 + 184);
        int64 MeditationUIController.CreateMeditationItemIcon
                         (uint64 this,uint64 parent,uint64 targetItemData)
        {
        uint64 uVar1;
        int64 lVar2;
        int64 lVar3;
        if (*pStatics != 0) {
          uVar1 = *(uint64 *)(*pStatics + 160);
          lVar2 = GlobalData.AddChild(parent,uVar1,0);
          if (lVar2 != null) {
            lVar3 = GameObject.GetComponent(lVar2,DAT_181e55168);
            if (lVar3 != null) {
              *(uint64 *)(lVar3 + 32) = targetItemData;
              lVar3 = GameObject.GetComponent(lVar2,DAT_181e55168);
              if (lVar3 != null) {
                *(uint32 *)(lVar3 + 40) = 1;
                lVar3 = GameObject.GetComponent(lVar2,DAT_181e55168);
                if (lVar3 != null) {
                  ItemIconController.AutoSetName(lVar3,1,0);
                  return lVar2;
                }
              }
            }
          }
        }
    }

    // Token : 0x600198E
    // RVA   : 0xE86F40   Offset: 0xE85D40   Length: 0x1AA
    public void TreasureIconButtonClicked()
    {
        long lVar1;
        bool cVar2;
        long lVar3;
        ulong uVar4;
        uint[] local_res8 = new uint[2];
        uint[] local_res18 = new uint[4];
        uVar4 = this.treasureIcon;
        cVar2 = Object.op_Inequality(uVar4,0,0);
        if (cVar2) {
          return;
        }
        lVar1 = **(int64 **)(DAT_181e977e8 + 184);
        lVar3 = il2cpp_internal(DAT_181e74e38);
        FUN_1810f3480(lVar3,DAT_181e77ae0);
        local_res8[0] = 0;
        uVar4 = il2cpp_value_box(DAT_181e60808,local_res8);
        if (lVar3 != null) {
          FUN_18175de30(lVar3,uVar4,DAT_181e77be0);
          local_res18[0] = 4;
          uVar4 = il2cpp_value_box(DAT_181e60808,local_res18);
          FUN_18175de30(lVar3,uVar4,DAT_181e77be0);
          uVar4 = Component.get_gameObject(this,0);
          if (lVar1 != null) {
            ChooseController.ShowChoosePanel(lVar1,1,lVar3,uVar4,"MeditationTreasureChoosen",0,0,0,0,0);
            return;
          }
        }
    }

    // Token : 0x600198F
    // RVA   : 0xE83D10   Offset: 0xE82B10   Length: 0xFC
    public void MeditationTreasureChoosen()
    {
        var pStatics = *(int64*)(DAT_181e977e8 + 184);
        long lVar1;
        ulong uVar2;
        if (this.meditationUI != null) {
          lVar1 = GameObject.get_transform(this.meditationUI,0);
          if (lVar1 != null) {
            lVar1 = Transform.Find(lVar1,"Treasure",0);
            if (lVar1 != null) {
              uVar2 = Component.get_gameObject(lVar1,0);
              if ((*pStatics != 0) &&
                 (lVar1 = *(int64 *)(*pStatics + 72)) != null) {
                lVar1 = GameObject.GetComponent(lVar1,DAT_181e55168);
                if (lVar1 != null) {
                  uVar2 = MeditationUIController.CreateMeditationItemIcon
                                    (this,uVar2,*(uint64 *)(lVar1 + 32),0);
                  this.treasureIcon = uVar2;
                  this.needRefresh = 1;
                  return;
                }
              }
            }
          }
        }
    }

    // Token : 0x6001990
    // RVA   : 0xE82B40   Offset: 0xE81940   Length: 0xB4
    public void ClearTreasureIcon()
    {
        ulong uVar1;
        bool cVar2;
        uVar1 = this.treasureIcon;
        cVar2 = Object.op_Inequality(uVar1,0,0);
        if (cVar2) {
          uVar1 = this.treasureIcon;
          Object.Destroy(uVar1,0);
          this.treasureIcon = 0;
          this.needRefresh = 1;
        }
    }

    // Token : 0x6001991
    // RVA   : 0xE82D30   Offset: 0xE81B30   Length: 0x1AA
    public void FoodIconButtonClicked()
    {
        long lVar1;
        bool cVar2;
        long lVar3;
        ulong uVar4;
        uint[] local_res8 = new uint[2];
        uint[] local_res18 = new uint[4];
        uVar4 = this.foodIcon;
        cVar2 = Object.op_Inequality(uVar4,0,0);
        if (cVar2) {
          return;
        }
        lVar1 = **(int64 **)(DAT_181e977e8 + 184);
        lVar3 = il2cpp_internal(DAT_181e74e38);
        FUN_1810f3480(lVar3,DAT_181e77ae0);
        local_res8[0] = 0;
        uVar4 = il2cpp_value_box(DAT_181e60808,local_res8);
        if (lVar3 != null) {
          FUN_18175de30(lVar3,uVar4,DAT_181e77be0);
          local_res18[0] = 2;
          uVar4 = il2cpp_value_box(DAT_181e60808,local_res18);
          FUN_18175de30(lVar3,uVar4,DAT_181e77be0);
          uVar4 = Component.get_gameObject(this,0);
          if (lVar1 != null) {
            ChooseController.ShowChoosePanel(lVar1,1,lVar3,uVar4,"MeditationFoodChoosen",0,0,0,0,0);
            return;
          }
        }
    }

    // Token : 0x6001992
    // RVA   : 0xE83B10   Offset: 0xE82910   Length: 0xFC
    public void MeditationFoodChoosen()
    {
        var pStatics = *(int64*)(DAT_181e977e8 + 184);
        long lVar1;
        ulong uVar2;
        if (this.meditationUI != null) {
          lVar1 = GameObject.get_transform(this.meditationUI,0);
          if (lVar1 != null) {
            lVar1 = Transform.Find(lVar1,"Food",0);
            if (lVar1 != null) {
              uVar2 = Component.get_gameObject(lVar1,0);
              if ((*pStatics != 0) &&
                 (lVar1 = *(int64 *)(*pStatics + 72)) != null) {
                lVar1 = GameObject.GetComponent(lVar1,DAT_181e55168);
                if (lVar1 != null) {
                  uVar2 = MeditationUIController.CreateMeditationItemIcon
                                    (this,uVar2,*(uint64 *)(lVar1 + 32),0);
                  this.foodIcon = uVar2;
                  this.needRefresh = 1;
                  return;
                }
              }
            }
          }
        }
    }

    // Token : 0x6001993
    // RVA   : 0xE829C0   Offset: 0xE817C0   Length: 0xB4
    public void ClearFoodIcon()
    {
        ulong uVar1;
        bool cVar2;
        uVar1 = this.foodIcon;
        cVar2 = Object.op_Inequality(uVar1,0,0);
        if (cVar2) {
          uVar1 = this.foodIcon;
          Object.Destroy(uVar1,0);
          this.foodIcon = 0;
          this.needRefresh = 1;
        }
    }

    // Token : 0x6001994
    // RVA   : 0xE83650   Offset: 0xE82450   Length: 0x1AA
    public void MedIconButtonClicked()
    {
        long lVar1;
        bool cVar2;
        long lVar3;
        ulong uVar4;
        uint[] local_res8 = new uint[2];
        uint[] local_res18 = new uint[4];
        uVar4 = this.medIcon;
        cVar2 = Object.op_Inequality(uVar4,0,0);
        if (cVar2) {
          return;
        }
        lVar1 = **(int64 **)(DAT_181e977e8 + 184);
        lVar3 = il2cpp_internal(DAT_181e74e38);
        FUN_1810f3480(lVar3,DAT_181e77ae0);
        local_res8[0] = 0;
        uVar4 = il2cpp_value_box(DAT_181e60808,local_res8);
        if (lVar3 != null) {
          FUN_18175de30(lVar3,uVar4,DAT_181e77be0);
          local_res18[0] = 1;
          uVar4 = il2cpp_value_box(DAT_181e60808,local_res18);
          FUN_18175de30(lVar3,uVar4,DAT_181e77be0);
          uVar4 = Component.get_gameObject(this,0);
          if (lVar1 != null) {
            ChooseController.ShowChoosePanel(lVar1,1,lVar3,uVar4,"MeditationMedChoosen",0,0,0,0,0);
            return;
          }
        }
    }

    // Token : 0x6001995
    // RVA   : 0xE83C10   Offset: 0xE82A10   Length: 0xFC
    public void MeditationMedChoosen()
    {
        var pStatics = *(int64*)(DAT_181e977e8 + 184);
        long lVar1;
        ulong uVar2;
        if (this.meditationUI != null) {
          lVar1 = GameObject.get_transform(this.meditationUI,0);
          if (lVar1 != null) {
            lVar1 = Transform.Find(lVar1,"Med",0);
            if (lVar1 != null) {
              uVar2 = Component.get_gameObject(lVar1,0);
              if ((*pStatics != 0) &&
                 (lVar1 = *(int64 *)(*pStatics + 72)) != null) {
                lVar1 = GameObject.GetComponent(lVar1,DAT_181e55168);
                if (lVar1 != null) {
                  uVar2 = MeditationUIController.CreateMeditationItemIcon
                                    (this,uVar2,*(uint64 *)(lVar1 + 32),0);
                  this.medIcon = uVar2;
                  this.needRefresh = 1;
                  return;
                }
              }
            }
          }
        }
    }

    // Token : 0x6001996
    // RVA   : 0xE82A80   Offset: 0xE81880   Length: 0xB4
    public void ClearMedIcon()
    {
        ulong uVar1;
        bool cVar2;
        uVar1 = this.medIcon;
        cVar2 = Object.op_Inequality(uVar1,0,0);
        if (cVar2) {
          uVar1 = this.medIcon;
          Object.Destroy(uVar1,0);
          this.medIcon = 0;
          this.needRefresh = 1;
        }
    }

    // Token : 0x6001997
    // RVA   : 0xE870F0   Offset: 0xE85EF0   Length: 0x306
    public void TreasureSureButtonClicked()
    {
        long lVar1;
        long lVar2;
        if ((GameController._instance != null) &&
           (lVar2 = GameController._instance.worldData) != null) {
          lVar2 = lVar2.meditationData;
          if (this.treasureIcon != null) {
            lVar1 = GameObject.GetComponent(this.treasureIcon,DAT_181e55168);
            if ((lVar1 != null) && (lVar2 != null)) {
              lVar2.villageAreaID = lVar1.villageAreaID;
              if (((GameController._instance != null) &&
                  (lVar2 = GameController._instance.worldData) != null) &&
                 (lVar2 = lVar2.meditationData) != null) {
                lVar2.Areas = 30;
                this.needRefresh = 1;
                if ((GameController._instance != null) &&
                   (lVar2 = GameController._instance.worldData) != null) {
                  lVar2 = WorldData.Player(lVar2,0);
                  if ((((GameController._instance != null) &&
                       (lVar1 = GameController._instance.worldData) != null)
                      && (lVar1 = lVar1.meditationData) != null) && (lVar2 != null)) {
                    HeroData.LoseItem(lVar2,lVar1.villageAreaID,1,0);
                    if (((GameController._instance != null) &&
                        (lVar2 = GameController._instance.worldData) != null)
                       && (lVar2 = lVar2.meditationData) != null) {
                      MeditationUIController.StartMeditationItemPlot
                                (this,lVar2.villageAreaID,0);
                      return;
                    }
                  }
                }
              }
            }
          }
        }
    }

    // Token : 0x6001998
    // RVA   : 0xE82EE0   Offset: 0xE81CE0   Length: 0x306
    public void FoodSureButtonClicked()
    {
        long lVar1;
        long lVar2;
        if ((GameController._instance != null) &&
           (lVar2 = GameController._instance.worldData) != null) {
          lVar2 = lVar2.meditationData;
          if (this.foodIcon != null) {
            lVar1 = GameObject.GetComponent(this.foodIcon,DAT_181e55168);
            if ((lVar1 != null) && (lVar2 != null)) {
              lVar2.Inns = lVar1.villageAreaID;
              if (((GameController._instance != null) &&
                  (lVar2 = GameController._instance.worldData) != null) &&
                 (lVar2 = lVar2.meditationData) != null) {
                lVar2.Forces = 30;
                this.needRefresh = 1;
                if ((GameController._instance != null) &&
                   (lVar2 = GameController._instance.worldData) != null) {
                  lVar2 = WorldData.Player(lVar2,0);
                  if ((((GameController._instance != null) &&
                       (lVar1 = GameController._instance.worldData) != null)
                      && (lVar1 = lVar1.meditationData) != null) && (lVar2 != null)) {
                    HeroData.LoseItem(lVar2,lVar1.Inns,1,0);
                    if (((GameController._instance != null) &&
                        (lVar2 = GameController._instance.worldData) != null)
                       && (lVar2 = lVar2.meditationData) != null) {
                      MeditationUIController.StartMeditationItemPlot
                                (this,lVar2.Inns,0);
                      return;
                    }
                  }
                }
              }
            }
          }
        }
    }

    // Token : 0x6001999
    // RVA   : 0xE83800   Offset: 0xE82600   Length: 0x306
    public void MedSureButtonClicked()
    {
        long lVar1;
        long lVar2;
        if ((GameController._instance != null) &&
           (lVar2 = GameController._instance.worldData) != null) {
          lVar2 = lVar2.meditationData;
          if (this.medIcon != null) {
            lVar1 = GameObject.GetComponent(this.medIcon,DAT_181e55168);
            if ((lVar1 != null) && (lVar2 != null)) {
              lVar2.Heros = lVar1.villageAreaID;
              if (((GameController._instance != null) &&
                  (lVar2 = GameController._instance.worldData) != null) &&
                 (lVar2 = lVar2.meditationData) != null) {
                lVar2.BigMapRandomEventDatas = 30;
                this.needRefresh = 1;
                if ((GameController._instance != null) &&
                   (lVar2 = GameController._instance.worldData) != null) {
                  lVar2 = WorldData.Player(lVar2,0);
                  if ((((GameController._instance != null) &&
                       (lVar1 = GameController._instance.worldData) != null)
                      && (lVar1 = lVar1.meditationData) != null) && (lVar2 != null)) {
                    HeroData.LoseItem(lVar2,lVar1.Heros,1,0);
                    if (((GameController._instance != null) &&
                        (lVar2 = GameController._instance.worldData) != null)
                       && (lVar2 = lVar2.meditationData) != null) {
                      MeditationUIController.StartMeditationItemPlot
                                (this,lVar2.Heros,0);
                      return;
                    }
                  }
                }
              }
            }
          }
        }
    }

    // Token : 0x600199A
    // RVA   : 0xE868B0   Offset: 0xE856B0   Length: 0x689
    public void StartMeditationItemPlot(ItemData targetItem)
    {
        uint uVar1;
        long lVar2;
        long lVar3;
        long lVar4;
        long lVar6;
        ulong uVar7;
        ulong uVar8;
        int iVar9;
        uint[] local_res10 = new uint[4];
        uint[] local_res20 = new uint[2];
        ulong in_stack_ffffffffffffff98;
        uint uVar10;
        lVar2 = BuildingUIController.PartyLvName;
        if (lVar2 != null) {
          PlotController.SetPlotItem(lVar2,targetItem,1,0);
          lVar2 = new HeroSpeAddData(0);
          lVar3 = il2cpp_internal(DAT_181e77728);
          FUN_1810f3480(lVar3,DAT_181e861f0);
          iVar9 = 0;
          do {
            if (lVar2 == null) {
        LAB_180e86f34:
                          // WARNING: Subroutine does not return
              FUN_1801e0300();
            }
            HeroSpeAddData.Reset(lVar2,0);
            lVar4 = FUN_1802106e0(0);
            if ((targetItem == null) || (lVar4 == null)) goto LAB_180e86f34;
            in_stack_ffffffffffffff98 = in_stack_ffffffffffffff98 & 0xffffffff00000000;
            GameController.GenerateSpeAddByValue
                      (lVar4,*(int *)(targetItem + 60) + 1,lVar2,1,in_stack_ffffffffffffff98,0);
            lVar4 = HeroSpeAddData.GetKeys(lVar2,0);
            if (lVar4 == null) goto LAB_180e86f34;
            if (*(int *)(lVar4 + 24) == 0) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            uVar1 = *(uint32 *)(*(int64 *)(lVar4 + 16) + 32);
            plVar5 = (int64 *)FUN_1801dfd90(DAT_181e84278,4);
            local_res10[0] = uVar1;
            lVar4 = il2cpp_value_box(DAT_181e60808,local_res10);
            if (plVar5 == (int64 *)0) goto LAB_180e86f34;
            if ((lVar4 != null) &&
               (lVar6 = il2cpp_internal(lVar4,*(uint64 *)(*plVar5 + 64))) == null) {
              uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1801e02d0(uVar7,0);
            }
            if ((int)plVar5[3] == 0) {
              uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1801e02d0(uVar7,0);
            }
            plVar5[4] = lVar4;
            il2cpp_internal(plVar5 + 4,lVar4);
            local_res20[0] = HeroSpeAddData.Get(lVar2,uVar1,0);
            lVar4 = il2cpp_value_box(DAT_181e82730,local_res20);
            if ((lVar4 != null) &&
               (lVar6 = il2cpp_internal(lVar4,*(uint64 *)(*plVar5 + 64))) == null) {
              uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1801e02d0(uVar7,0);
            }
            if (*(uint32 *)(plVar5 + 3) < 2) {
              uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1801e02d0(uVar7,0);
            }
            plVar5[5] = lVar4;
            il2cpp_internal(plVar5 + 5,lVar4);
            uVar10 = 0;
            in_stack_ffffffffffffff98 = in_stack_ffffffffffffff98 & 0xffffffffffffff00;
            lVar4 = HeroSpeAddData.GetDescribe(lVar2,1,1,1,in_stack_ffffffffffffff98,0);
            if ((lVar4 != null) &&
               (lVar6 = il2cpp_internal(lVar4,*(uint64 *)(*plVar5 + 64))) == null) {
              uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1801e02d0(uVar7,0);
            }
            if (*(uint32 *)(plVar5 + 3) < 3) {
              uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1801e02d0(uVar7,0);
            }
            plVar5[6] = lVar4;
            il2cpp_internal(plVar5 + 6,lVar4);
            lVar4 = FUN_180210740(0);
            if (((lVar4 == null) || (*(int64 *)(lVar4 + 144) == 0)) ||
               (lVar4 = FUN_1800024b0(*(int64 *)(lVar4 + 144),uVar1,DAT_181e6e1f0),
               uVar7 = "{2};ChooseMeditationItemSpeAdd;{0}-{1};;{3}", lVar4 == null)) goto LAB_180e86f34;
            lVar6 = "";
            if (*(char *)(lVar4 + 89) != false) {
              lVar4 = FUN_180210740(0);
              if (((lVar4 == null) || (*(int64 *)(lVar4 + 144) == 0)) ||
                 (lVar4 = FUN_1800024b0(*(int64 *)(lVar4 + 144),uVar1,DAT_181e6e1f0)) == null)
              throw; // [null/range check failed]
              lVar6 = HeroSpeAddDataBase.GetDescribe(lVar4,0);
            }
            if ((lVar6 != null) &&
               (lVar4 = il2cpp_internal(lVar6,*(uint64 *)(*plVar5 + 64))) == null) {
              uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1801e02d0(uVar7,0);
            }
            FUN_1800025b0(plVar5,3,lVar6);
            uVar7 = String.Format(uVar7,plVar5,0);
            if (lVar3 == null) throw; // [null/range check failed]
            FUN_18175de30(lVar3,uVar7,DAT_181e86370);
            iVar9 = iVar9 + 1;
          } while (iVar9 < 5);
          lVar2 = BuildingUIController.PartyLvName;
          uVar7 = FUN_1800020e0(DAT_181e6dc98);
          uVar7 = String.Format("在供奉这#PlotInteractItemName#之时，\n忽觉一阵灵光乍现，恍然间似乎有所领悟......",uVar7,0);
          uVar8 = new SinglePlotData(uVar7,lVar3,1,0,CONCAT44(uVar10,3),"0",1,0,0);
          if (lVar2 != null) {
            PlotController.ChangePlot(lVar2,uVar8,0);
            return;
          }
        }
    }

    // Token : 0x600199B
    // RVA   : 0xE86420   Offset: 0xE85220   Length: 0x480
    public void StartMeditationButtonClicked()
    {
        long lVar1;
        long lVar2;
        ulong uVar3;
        ulong uVar4;
        long lVar5;
        ulong uVar6;
        int iVar7;
        float[] local_res18 = new float[2];
        int[] local_res20 = new int[2];
        local_res18[0] = 0.0;
        lVar2 = il2cpp_internal(DAT_181e77728);
        FUN_1810f3480(lVar2,DAT_181e861f0);
        iVar7 = 1;
        while( true ) {
          uVar3 = GlobalData.GetNumText(iVar7,0);
          local_res20[0] = iVar7;
          uVar4 = il2cpp_value_box(DAT_181e60808,local_res20);
          uVar3 = String.Format("{0}日;StartMeditationWork;{1}",uVar3,uVar4,0);
          if (lVar2 == null) break;
          FUN_18175de30(lVar2,uVar3,DAT_181e86370);
          iVar7 = iVar7 + 1;
          if (5 < iVar7) {
            FUN_18175de30(lVar2,"还是算了;HideInteractUI",DAT_181e86370);
            lVar1 = *(int64 *)(*(int64 *)(DAT_181e71f68 + 184) + 24);
            if ((GameController._instance != null) &&
               (lVar5 = GameController._instance.worldData) != null) {
              lVar5 = WorldData.Player(lVar5,0);
              if (lVar5 != null) {
                uVar3 = HeroData.GetMeditationTopic(lVar5,0);
                if (((GameController._instance != null) &&
                    (lVar5 = GameController._instance.worldData) != null) &&
                   (lVar5 = lVar5.meditationData) != null) {
                  local_res20[0] = lVar5.cityAreaID;
                  uVar4 = il2cpp_value_box(DAT_181e60808,local_res20);
                  if (((GameController._instance != null) &&
                      (lVar5 = GameController._instance.worldData) != null)
                     && (lVar5 = lVar5.meditationData) != null) {
                    local_res18[0] = (float)MeditationData.MeditationExpRate(lVar5,0);
                    local_res18[0] = local_res18[0] * 100.0;
                    uVar6 = Single.ToString(local_res18,"f0",0);
                    uVar3 = String.Format("在此处修行可以快速提升我的{0}修为，要在此处修行几日？\n（当前修行效率{2}%，预计每日可获取修行经验{2}）",uVar3,uVar4,uVar6,0);
                    uVar4 = new SinglePlotData(uVar3,lVar2,1,0,3,"0",1,0,0);
                    if (lVar1 != null) {
                      PlotController.ChangePlot(lVar1,uVar4,0);
                      return;
                    }
                  }
                }
              }
            }
                          // WARNING: Subroutine does not return
            FUN_1801e0300();
          }
        }
    }

    // Token : 0x600199C
    // RVA   : 0x2110A0   Offset: 0x20FEA0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_180ae8740(this,0);
    }

}
