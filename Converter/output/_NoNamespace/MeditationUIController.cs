// ============================================================
// Type  : MeditationUIController
// Token : 0x2000302
// ============================================================

public class MeditationUIController
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x40018C2
    public GameObject meditationUI;

    // Token: 0x40018C3
    public GameObject treasureIcon;

    // Token: 0x40018C4
    public GameObject medIcon;

    // Token: 0x40018C5
    public GameObject foodIcon;

    // Token: 0x40018C6
    public bool needRefresh;

    // Token: 0x40018C7
    private static MeditationUIController _instance;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60018F2
    // RVA   : 0xA93810   Offset: 0xA92C10   Length: 0x36
    public static MeditationUIController get_Instance()
    {
        return **(uint64 **)(DAT_181d88990 + 184);
    }

    // Token : 0x60018F3
    // RVA   : 0xA8E500   Offset: 0xA8D900   Length: 0x43
    private void Awake()
    {
        puVar1 = *(uint64 **)(DAT_181d88990 + 184);
        *puVar1 = this;
        il2cpp_internal(puVar1,this);
    }

    // Token : 0x60018F4
    // RVA   : 0xA937D0   Offset: 0xA92BD0   Length: 0x3D
    private void Update()
    {
        bool cVar1;
        if (this.meditationUI == null) {
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
        cVar1 = GameObject.get_activeSelf(this.meditationUI,0);
        if ((cVar1) && (this.needRefresh)) {
          MeditationUIController.RefreshUI(this,0);
          return;
        }
    }

    // Token : 0x60018F5
    // RVA   : 0xA8F060   Offset: 0xA8E460   Length: 0x1EF
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

    // Token : 0x60018F6
    // RVA   : 0xA924C0   Offset: 0xA918C0   Length: 0x2A1
    public void ShowMeditationUI()
    {
        var pStatics = *(int64*)(DAT_181d72cc8 + 184);
        long lVar1;
        ulong uVar3;
        if (this.meditationUI != null) {
          GameObject.SetActive(this.meditationUI,1,0);
          if (this.meditationUI != null) {
            lVar1 = GameObject.get_transform(this.meditationUI,0);
            if (lVar1 != null) {
              lVar1 = Transform.Find(lVar1,"Title",0);
              if (lVar1 != null) {
                plVar2 = (int64 *)Component.GetComponent(lVar1,DAT_181d96160);
                if ((*pStatics != 0) &&
                   (lVar1 = *(int64 *)(*pStatics + 32)) != null) {
                  lVar1 = WorldData.Player(lVar1,0);
                  if (lVar1 != null) {
                    uVar3 = HeroData.GetMeditationTopic(lVar1,0);
                    uVar3 = String.Concat(uVar3,"修行",0);
                    uVar3 = LTLocalization.GetText(uVar3,0,1,0);
                    if (plVar2 != (int64 *)0) {
                      (**(code **)(*plVar2 + 0x5e8))(plVar2,uVar3,*(uint64 *)(*plVar2 + 0x5f0));
                      LTLocalization.CheckTextFont(plVar2,0);
                      MeditationUIController.RefreshUI(this,0);
                      plVar2 = (int64 *)Resources.Load("Sound/SoundEffect/OpenBook",0);
                      plVar4 = (int64 *)0;
                      if ((plVar2 != (int64 *)0) && (*plVar2 == DAT_181daf348)) {
                        plVar4 = plVar2;
                      }
                      NGUITools.PlaySound(plVar4,0);
                      return;
                    }
                  }
                }
              }
            }
          }
        }
    }

    // Token : 0x60018F7
    // RVA   : 0xA8FA10   Offset: 0xA8EE10   Length: 0x2AA3
    public void RefreshUI()
    {
        var pStatics_2cc8 = *(int64*)(DAT_181d72cc8 + 184);
        var pStatics_3d40 = *(int64*)(DAT_181d73d40 + 184);
        int iVar1;
        long lVar2;
        bool cVar3;
        byte uVar4;
        long lVar5;
        ulong uVar7;
        ulong uVar8;
        float fVar10;
        float fVar11;
        float fVar12;
        float[] local_res8 = new float[4];
        int[] local_res18 = new int[2];
        float[] local_res20 = new float[2];
        uint[] local_88 = new uint[4];
        ulong local_78;
        ulong uStack_70;
        this.needRefresh = 0;
        if (((this.meditationUI == null) ||
            (lVar5 = GameObject.get_transform(this.meditationUI,0)) == null) ||
           (lVar5 = Transform.Find(lVar5,"MeditationLv",0)) == null) {
        LAB_180a924a2:
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
        plVar6 = (int64 *)Component.GetComponent(lVar5,DAT_181d96160);
        if (((*pStatics_2cc8 == 0) ||
            (lVar5 = *(int64 *)(*pStatics_2cc8 + 32)) == null) ||
           (lVar5 = WorldData.Player(lVar5,0)) == null) goto LAB_180a924a2;
        uVar7 = HeroData.GetMeditationTopic(lVar5,0);
        if (((*pStatics_2cc8 == 0) ||
            (lVar5 = *(int64 *)(*pStatics_2cc8 + 32)) == null) ||
           (lVar5 = *(int64 *)(lVar5 + 0x1f0)) == null) goto LAB_180a924a2;
        uVar8 = Int32.ToString(lVar5 + 16,0);
        uVar7 = String.Concat(uVar7,"等级",uVar8,0);
        uVar7 = LTLocalization.GetText(uVar7,0,1,0);
        if (plVar6 == (int64 *)0) goto LAB_180a924a2;
        (**(code **)(*plVar6 + 0x5e8))(plVar6,uVar7,*(uint64 *)(*plVar6 + 0x5f0));
        LTLocalization.CheckTextFont(plVar6,0);
        if (((this.meditationUI == null) ||
            (lVar5 = GameObject.get_transform(this.meditationUI,0)) == null) ||
           (lVar5 = Transform.Find(lVar5,"MeditationLvAdd",0)) == null) goto LAB_180a924a2;
        plVar6 = (int64 *)Component.GetComponent(lVar5,DAT_181d96160);
        if (((*pStatics_2cc8 == 0) ||
            (lVar5 = *(int64 *)(*pStatics_2cc8 + 32)) == null) ||
           (lVar5 = WorldData.Player(lVar5,0)) == null) goto LAB_180a924a2;
        lVar5 = HeroData.GetForce(lVar5,0,0);
        if (lVar5 == null) goto LAB_180a924a2;
        uVar7 = ForceData.GetForceName(lVar5,1,0);
        if (((*pStatics_2cc8 == 0) ||
            (lVar5 = *(int64 *)(*pStatics_2cc8 + 32)) == null) ||
           (lVar5 = *(int64 *)(lVar5 + 0x1f0)) == null) goto LAB_180a924a2;
        local_res18[0] = *(int *)(lVar5 + 16) * 2;
        uVar8 = il2cpp_value_box(DAT_181d80418,local_res18);
        uVar7 = String.Format("等级加成\n{0}武学威力+{1}%",uVar7,uVar8,0);
        uVar7 = LTLocalization.GetText(uVar7,0,1,0);
        if (plVar6 == (int64 *)0) goto LAB_180a924a2;
        (**(code **)(*plVar6 + 0x5e8))(plVar6,uVar7,*(uint64 *)(*plVar6 + 0x5f0));
        LTLocalization.CheckTextFont(plVar6,0);
        if (((this.meditationUI == null) ||
            (lVar5 = GameObject.get_transform(this.meditationUI,0)) == null) ||
           ((lVar5 = Transform.Find(lVar5,"ExpBarBack",0), lVar5 == null ||
            (lVar5 = Transform.Find(lVar5,"ExpText",0)) == null))) goto LAB_180a924a2;
        plVar6 = (int64 *)Component.GetComponent(lVar5,DAT_181d96160);
        if (((*pStatics_2cc8 == 0) ||
            (lVar5 = *(int64 *)(*pStatics_2cc8 + 32)) == null) ||
           (lVar5 = *(int64 *)(lVar5 + 0x1f0)) == null) goto LAB_180a924a2;
        uVar7 = Single.ToString(lVar5 + 20,"f0",0);
        if (((*pStatics_2cc8 == 0) ||
            (lVar5 = *(int64 *)(*pStatics_2cc8 + 32)) == null) ||
           (lVar5 = *(int64 *)(lVar5 + 0x1f0)) == null) goto LAB_180a924a2;
        iVar1 = *(int *)(lVar5 + 16);
        local_res20[0] = (float)((iVar1 + 2) * (iVar1 + 1)) * 50.0;
        uVar8 = il2cpp_value_box(DAT_181da22d8,local_res20);
        uVar7 = String.Format("{0}/{1}",uVar7,uVar8,0);
        uVar7 = LTLocalization.GetText(uVar7,0,1,0);
        if (plVar6 == (int64 *)0) goto LAB_180a924a2;
        (**(code **)(*plVar6 + 0x5e8))(plVar6,uVar7,*(uint64 *)(*plVar6 + 0x5f0));
        LTLocalization.CheckTextFont(plVar6,0);
        if ((((this.meditationUI == null) ||
             (lVar5 = GameObject.get_transform(this.meditationUI,0)) == null) ||
            (lVar5 = Transform.Find(lVar5,"ExpBarBack",0)) == null) ||
           (lVar5 = Transform.Find(lVar5,"ExpBar",0)) == null) goto LAB_180a924a2;
        lVar5 = Component.GetComponent(lVar5,DAT_181d94460);
        if (((*pStatics_2cc8 == 0) ||
            (lVar2 = *(int64 *)(*pStatics_2cc8 + 32)) == null) ||
           (*(int64 *)(lVar2 + 0x1f0) == 0)) goto LAB_180a924a2;
        if ((((*pStatics_2cc8 == 0) ||
             (lVar2 = *(int64 *)(*pStatics_2cc8 + 32)) == null) ||
            (*(int64 *)(lVar2 + 0x1f0) == 0)) || (lVar5 == null)) goto LAB_180a924a2;
        Image.set_fillAmount(lVar5);
        if (((this.meditationUI == null) ||
            (lVar5 = GameObject.get_transform(this.meditationUI,0)) == null) ||
           (lVar5 = Transform.Find(lVar5,"MeditationText",0)) == null) goto LAB_180a924a2;
        plVar6 = (int64 *)Component.GetComponent(lVar5,DAT_181d96160);
        if (((*pStatics_2cc8 == 0) ||
            (lVar5 = *(int64 *)(*pStatics_2cc8 + 32)) == null) ||
           (lVar5 = *(int64 *)(lVar5 + 0x1f0)) == null) goto LAB_180a924a2;
        local_res8[0] = (float)MeditationData.MeditationExpRate(lVar5,0);
        local_res8[0] = local_res8[0] * 100.0;
        uVar7 = Single.ToString(local_res8,"f0",0);
        if (((*pStatics_2cc8 == 0) ||
            (lVar5 = *(int64 *)(*pStatics_2cc8 + 32)) == null) ||
           (lVar5 = *(int64 *)(lVar5 + 0x1f0)) == null) goto LAB_180a924a2;
        fVar10 = 0.0;
        if (*(int *)(lVar5 + 48) < 1) {
          fVar12 = 0.0;
        }
        else if (*(int64 *)(lVar5 + 32) == 0) {
          fVar12 = 0.0;
        }
        else {
          fVar12 = (float)Mathf.Max();
        }
        if (*(int *)(lVar5 + 72) < 1) {
          fVar11 = 0.0;
        }
        else if (*(int64 *)(lVar5 + 56) == 0) {
          fVar11 = 0.0;
        }
        else {
          fVar11 = (float)Mathf.Max();
        }
        if ((0 < *(int *)(lVar5 + 96)) && (*(int64 *)(lVar5 + 80) != 0)) {
          fVar10 = (float)Mathf.Max();
        }
        local_res8[0] = fVar11 + fVar12 + fVar10;
        uVar8 = Single.ToString(local_res8,"f0",0);
        uVar7 = String.Format("每日经验 <b>{1}</b>\n修行效率 <b>{0}%</b>",uVar7,uVar8,0);
        uVar7 = LTLocalization.GetText(uVar7,0,1,0);
        if (plVar6 == (int64 *)0) goto LAB_180a924a2;
        (**(code **)(*plVar6 + 0x5e8))(plVar6,uVar7,*(uint64 *)(*plVar6 + 0x5f0));
        LTLocalization.CheckTextFont(plVar6,0);
        if (((this.meditationUI == null) ||
            (lVar5 = GameObject.get_transform(this.meditationUI,0)) == null) ||
           (lVar5 = Transform.Find(lVar5,"StartMeditationButton",0)) == null) goto LAB_180a924a2;
        lVar5 = Component.GetComponent(lVar5,DAT_181d95560);
        if (((*pStatics_2cc8 == 0) ||
            (lVar2 = *(int64 *)(*pStatics_2cc8 + 32)) == null) ||
           (lVar2 = *(int64 *)(lVar2 + 0x1f0)) == null) goto LAB_180a924a2;
        local_88[0] = *(uint32 *)(lVar2 + 24);
        uVar7 = il2cpp_value_box(DAT_181d80418,local_88);
        uVar7 = String.Format("本月已修行{0}日\n每修行一日，本月修行效率都会下降20%",uVar7,0);
        if (lVar5 == null) goto LAB_180a924a2;
        *(uint64 *)(lVar5 + 24) = uVar7;
        if (((*pStatics_2cc8 == 0) ||
            (lVar5 = *(int64 *)(*pStatics_2cc8 + 32)) == null) ||
           (lVar5 = *(int64 *)(lVar5 + 0x1f0)) == null) goto LAB_180a924a2;
        if (*(int *)(lVar5 + 48) < 1) {
          if (((this.meditationUI == null) ||
              (lVar5 = GameObject.get_transform(this.meditationUI,0)) == null) ||
             (lVar5 = Transform.Find(lVar5,"TreasureSureButton",0)) == null) goto LAB_180a924ae;
          lVar5 = Component.GetComponent(lVar5,DAT_181d93760);
          uVar7 = this.treasureIcon;
          uVar4 = Object.op_Inequality(uVar7,0,0);
          if (lVar5 == null) goto LAB_180a924ae;
          Selectable.set_interactable(lVar5,uVar4,0);
          if (((this.meditationUI == null) ||
              (lVar5 = GameObject.get_transform(this.meditationUI,0)) == null) ||
             (lVar5 = Transform.Find(lVar5,"TreasureSureButton",0)) == null) goto LAB_180a924ae;
          lVar5 = Transform.Find(lVar5,"Text",0);
          if (lVar5 == null) goto LAB_180a924ae;
          plVar6 = (int64 *)Component.GetComponent(lVar5,DAT_181d96160);
          uVar7 = "供奉";
          uVar7 = LTLocalization.GetText(uVar7,0,1,0);
          if (plVar6 == (int64 *)0) goto LAB_180a924ae;
          (**(code **)(*plVar6 + 0x5e8))(plVar6,uVar7,*(uint64 *)(*plVar6 + 0x5f0));
          LTLocalization.CheckTextFont(plVar6,0);
          if ((((this.meditationUI == null) ||
               (lVar5 = GameObject.get_transform(this.meditationUI,0)) == null) ||
              (lVar5 = Transform.Find(lVar5,"TreasureSureButton",0)) == null) ||
             (lVar5 = Transform.Find(lVar5,"Text",0)) == null) goto LAB_180a924ae;
          plVar6 = (int64 *)Component.GetComponent(lVar5,DAT_181d96160);
          puVar9 = (uint64 *)Color.get_black(&local_78,0);
          if (plVar6 == (int64 *)0) goto LAB_180a924ae;
          local_78 = *puVar9;
          uStack_70 = puVar9[1];
          (**(code **)(*plVar6 + 0x2a8))(plVar6,&local_78,*(uint64 *)(*plVar6 + 0x2b0));
          if (((this.meditationUI == null) ||
              (lVar5 = GameObject.get_transform(this.meditationUI,0)) == null) ||
             (lVar5 = Transform.Find(lVar5,"ClearTreasureButton",0)) == null) goto LAB_180a924ae;
          lVar5 = Component.get_gameObject(lVar5,0);
          uVar4 = Object.op_Inequality(this.treasureIcon,0,0);
          if (lVar5 == null) goto LAB_180a924ae;
          GameObject.SetActive(lVar5,uVar4,0);
          if ((this.meditationUI == null) ||
             (lVar5 = GameObject.get_transform(this.meditationUI,0)) == null)
          goto LAB_180a924ae;
          lVar5 = Transform.Find(lVar5,"TreasureAddText",0);
          if (lVar5 == null) goto LAB_180a924ae;
          plVar6 = (int64 *)Component.GetComponent(lVar5,DAT_181d96160);
          uVar7 = "";
        }
        else {
          uVar7 = this.treasureIcon;
          cVar3 = Object.op_Equality(uVar7,0,0);
          if (cVar3) {
            if (((this.meditationUI == null) ||
                (lVar5 = GameObject.get_transform(this.meditationUI,0)) == null) ||
               (lVar5 = Transform.Find(lVar5,"Treasure",0)) == null) goto LAB_180a924ae;
            uVar7 = Component.get_gameObject(lVar5,0);
            lVar5 = FUN_18046c0a0(0);
            if (((lVar5 == null) || (*(int64 *)(lVar5 + 32) == 0)) ||
               (lVar5 = *(int64 *)(*(int64 *)(lVar5 + 32) + 0x1f0)) == null)
            goto LAB_180a924ae;
            uVar7 = MeditationUIController.CreateMeditationItemIcon
                              (this,uVar7,*(uint64 *)(lVar5 + 32),0);
            *puVar9 = uVar7;
            il2cpp_internal(puVar9,uVar7);
          }
          if ((((this.meditationUI == null) ||
               (lVar5 = GameObject.get_transform(this.meditationUI,0)) == null) ||
              (lVar5 = Transform.Find(lVar5,"TreasureSureButton",0)) == null) ||
             (lVar5 = Component.GetComponent(lVar5,DAT_181d93760)) == null) goto LAB_180a924ae;
          Selectable.set_interactable(lVar5,0,0);
          if (((this.meditationUI == null) ||
              (lVar5 = GameObject.get_transform(this.meditationUI,0)) == null) ||
             ((lVar5 = Transform.Find(lVar5,"TreasureSureButton",0), lVar5 == null ||
              (lVar5 = Transform.Find(lVar5,"Text",0)) == null))) goto LAB_180a924ae;
          plVar6 = (int64 *)Component.GetComponent(lVar5,DAT_181d96160);
          if (((*pStatics_2cc8 == 0) ||
              (lVar5 = *(int64 *)(*pStatics_2cc8 + 32)) == null) ||
             (lVar5 = *(int64 *)(lVar5 + 0x1f0)) == null) goto LAB_180a924ae;
          uVar7 = Int32.ToString(lVar5 + 48,0);
          uVar7 = String.Concat(uVar7,"日",0);
          uVar7 = LTLocalization.GetText(uVar7,0,1,0);
          if (plVar6 == (int64 *)0) goto LAB_180a924ae;
          (**(code **)(*plVar6 + 0x5e8))(plVar6,uVar7,*(uint64 *)(*plVar6 + 0x5f0));
          LTLocalization.CheckTextFont(plVar6,0);
          if ((((this.meditationUI == null) ||
               (lVar5 = GameObject.get_transform(this.meditationUI,0)) == null) ||
              (lVar5 = Transform.Find(lVar5,"TreasureSureButton",0)) == null) ||
             (lVar5 = Transform.Find(lVar5,"Text",0)) == null) goto LAB_180a924ae;
          plVar6 = (int64 *)Component.GetComponent(lVar5,DAT_181d96160);
          if (plVar6 == (int64 *)0) goto LAB_180a924ae;
          local_78 = *(uint64 *)(pStatics_3d40 + 0x378);
          uStack_70 = *(uint64 *)(pStatics_3d40 + 0x380);
          (**(code **)(*plVar6 + 0x2a8))(plVar6,&local_78,*(uint64 *)(*plVar6 + 0x2b0));
          if (((this.meditationUI == null) ||
              (lVar5 = GameObject.get_transform(this.meditationUI,0)) == null) ||
             ((lVar5 = Transform.Find(lVar5,"ClearTreasureButton",0), lVar5 == null ||
              (lVar5 = Component.get_gameObject(lVar5,0)) == null))) goto LAB_180a924ae;
          GameObject.SetActive(lVar5,0,0);
          if (((this.meditationUI == null) ||
              (lVar5 = GameObject.get_transform(this.meditationUI,0)) == null) ||
             (lVar5 = Transform.Find(lVar5,"TreasureAddText",0)) == null) goto LAB_180a924ae;
          plVar6 = (int64 *)Component.GetComponent(lVar5,DAT_181d96160);
          if (((*pStatics_2cc8 == 0) ||
              (lVar5 = *(int64 *)(*pStatics_2cc8 + 32)) == null) ||
             ((lVar5 = *(int64 *)(lVar5 + 0x1f0), lVar5 == null ||
              (lVar5 = *(int64 *)(lVar5 + 40)) == null))) goto LAB_180a924ae;
          uVar7 = HeroSpeAddData.GetDescribe(lVar5,1,1,1,0,0);
        }
        uVar7 = LTLocalization.GetText(uVar7,0,1,0);
        if (plVar6 == (int64 *)0) {
        LAB_180a924ae:
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
        (**(code **)(*plVar6 + 0x5e8))(plVar6,uVar7,*(uint64 *)(*plVar6 + 0x5f0));
        LTLocalization.CheckTextFont(plVar6,0);
        if (((*pStatics_2cc8 == 0) ||
            (lVar5 = *(int64 *)(*pStatics_2cc8 + 32)) == null) ||
           (lVar5 = *(int64 *)(lVar5 + 0x1f0)) == null) goto LAB_180a924ae;
        if (*(int *)(lVar5 + 72) < 1) {
          if (((this.meditationUI == null) ||
              (lVar5 = GameObject.get_transform(this.meditationUI,0)) == null) ||
             (lVar5 = Transform.Find(lVar5,"FoodSureButton",0)) == null) goto LAB_180a924ae;
          lVar5 = Component.GetComponent(lVar5,DAT_181d93760);
          uVar7 = this.foodIcon;
          uVar4 = Object.op_Inequality(uVar7,0,0);
          if (lVar5 == null) goto LAB_180a924ae;
          Selectable.set_interactable(lVar5,uVar4,0);
          if (((this.meditationUI == null) ||
              (lVar5 = GameObject.get_transform(this.meditationUI,0)) == null) ||
             (lVar5 = Transform.Find(lVar5,"FoodSureButton",0)) == null) goto LAB_180a924ae;
          lVar5 = Transform.Find(lVar5,"Text",0);
          if (lVar5 == null) goto LAB_180a924ae;
          plVar6 = (int64 *)Component.GetComponent(lVar5,DAT_181d96160);
          uVar7 = "供奉";
          uVar7 = LTLocalization.GetText(uVar7,0,1,0);
          if (plVar6 == (int64 *)0) goto LAB_180a924ae;
          (**(code **)(*plVar6 + 0x5e8))(plVar6,uVar7,*(uint64 *)(*plVar6 + 0x5f0));
          LTLocalization.CheckTextFont(plVar6,0);
          if ((((this.meditationUI == null) ||
               (lVar5 = GameObject.get_transform(this.meditationUI,0)) == null) ||
              (lVar5 = Transform.Find(lVar5,"FoodSureButton",0)) == null) ||
             (lVar5 = Transform.Find(lVar5,"Text",0)) == null) goto LAB_180a924ae;
          plVar6 = (int64 *)Component.GetComponent(lVar5,DAT_181d96160);
          puVar9 = (uint64 *)Color.get_black(&local_78,0);
          if (plVar6 == (int64 *)0) goto LAB_180a924ae;
          local_78 = *puVar9;
          uStack_70 = puVar9[1];
          (**(code **)(*plVar6 + 0x2a8))(plVar6,&local_78,*(uint64 *)(*plVar6 + 0x2b0));
          if (((this.meditationUI == null) ||
              (lVar5 = GameObject.get_transform(this.meditationUI,0)) == null) ||
             (lVar5 = Transform.Find(lVar5,"ClearFoodButton",0)) == null) goto LAB_180a924ae;
          lVar5 = Component.get_gameObject(lVar5,0);
          uVar4 = Object.op_Inequality(this.foodIcon,0,0);
          if (lVar5 == null) goto LAB_180a924ae;
          GameObject.SetActive(lVar5,uVar4,0);
          if ((this.meditationUI == null) ||
             (lVar5 = GameObject.get_transform(this.meditationUI,0)) == null)
          goto LAB_180a924ae;
          lVar5 = Transform.Find(lVar5,"FoodAddText",0);
          if (lVar5 == null) goto LAB_180a924ae;
          plVar6 = (int64 *)Component.GetComponent(lVar5,DAT_181d96160);
          uVar7 = "";
        }
        else {
          uVar7 = this.foodIcon;
          cVar3 = Object.op_Equality(uVar7,0,0);
          if (cVar3) {
            if (((this.meditationUI == null) ||
                (lVar5 = GameObject.get_transform(this.meditationUI,0)) == null) ||
               (lVar5 = Transform.Find(lVar5,"Food",0)) == null) goto LAB_180a924ae;
            uVar7 = Component.get_gameObject(lVar5,0);
            lVar5 = FUN_18046c0a0(0);
            if (((lVar5 == null) || (*(int64 *)(lVar5 + 32) == 0)) ||
               (lVar5 = *(int64 *)(*(int64 *)(lVar5 + 32) + 0x1f0)) == null)
            goto LAB_180a924ae;
            uVar7 = MeditationUIController.CreateMeditationItemIcon
                              (this,uVar7,*(uint64 *)(lVar5 + 56),0);
            *puVar9 = uVar7;
            il2cpp_internal(puVar9,uVar7);
          }
          if ((((this.meditationUI == null) ||
               (lVar5 = GameObject.get_transform(this.meditationUI,0)) == null) ||
              (lVar5 = Transform.Find(lVar5,"FoodSureButton",0)) == null) ||
             (lVar5 = Component.GetComponent(lVar5,DAT_181d93760)) == null) goto LAB_180a924ae;
          Selectable.set_interactable(lVar5,0,0);
          if (((this.meditationUI == null) ||
              (lVar5 = GameObject.get_transform(this.meditationUI,0)) == null) ||
             ((lVar5 = Transform.Find(lVar5,"FoodSureButton",0), lVar5 == null ||
              (lVar5 = Transform.Find(lVar5,"Text",0)) == null))) goto LAB_180a924ae;
          plVar6 = (int64 *)Component.GetComponent(lVar5,DAT_181d96160);
          if (((*pStatics_2cc8 == 0) ||
              (lVar5 = *(int64 *)(*pStatics_2cc8 + 32)) == null) ||
             (lVar5 = *(int64 *)(lVar5 + 0x1f0)) == null) goto LAB_180a924ae;
          uVar7 = Int32.ToString(lVar5 + 72,0);
          uVar7 = String.Concat(uVar7,"日",0);
          uVar7 = LTLocalization.GetText(uVar7,0,1,0);
          if (plVar6 == (int64 *)0) goto LAB_180a924ae;
          (**(code **)(*plVar6 + 0x5e8))(plVar6,uVar7,*(uint64 *)(*plVar6 + 0x5f0));
          LTLocalization.CheckTextFont(plVar6,0);
          if ((((this.meditationUI == null) ||
               (lVar5 = GameObject.get_transform(this.meditationUI,0)) == null) ||
              (lVar5 = Transform.Find(lVar5,"FoodSureButton",0)) == null) ||
             (lVar5 = Transform.Find(lVar5,"Text",0)) == null) goto LAB_180a924ae;
          plVar6 = (int64 *)Component.GetComponent(lVar5,DAT_181d96160);
          if (plVar6 == (int64 *)0) goto LAB_180a924ae;
          local_78 = *(uint64 *)(pStatics_3d40 + 0x378);
          uStack_70 = *(uint64 *)(pStatics_3d40 + 0x380);
          (**(code **)(*plVar6 + 0x2a8))(plVar6,&local_78,*(uint64 *)(*plVar6 + 0x2b0));
          if (((this.meditationUI == null) ||
              (lVar5 = GameObject.get_transform(this.meditationUI,0)) == null) ||
             ((lVar5 = Transform.Find(lVar5,"ClearFoodButton",0), lVar5 == null ||
              (lVar5 = Component.get_gameObject(lVar5,0)) == null))) goto LAB_180a924ae;
          GameObject.SetActive(lVar5,0,0);
          if (((this.meditationUI == null) ||
              (lVar5 = GameObject.get_transform(this.meditationUI,0)) == null) ||
             (lVar5 = Transform.Find(lVar5,"FoodAddText",0)) == null) goto LAB_180a924ae;
          plVar6 = (int64 *)Component.GetComponent(lVar5,DAT_181d96160);
          if (((*pStatics_2cc8 == 0) ||
              (lVar5 = *(int64 *)(*pStatics_2cc8 + 32)) == null) ||
             ((lVar5 = *(int64 *)(lVar5 + 0x1f0), lVar5 == null ||
              (lVar5 = *(int64 *)(lVar5 + 64)) == null))) goto LAB_180a924ae;
          uVar7 = HeroSpeAddData.GetDescribe(lVar5,1,1,1,0,0);
        }
        uVar7 = LTLocalization.GetText(uVar7,0,1,0);
        if (plVar6 == (int64 *)0) goto LAB_180a924ae;
        (**(code **)(*plVar6 + 0x5e8))(plVar6,uVar7,*(uint64 *)(*plVar6 + 0x5f0));
        LTLocalization.CheckTextFont(plVar6,0);
        if (((*pStatics_2cc8 == 0) ||
            (lVar5 = *(int64 *)(*pStatics_2cc8 + 32)) == null) ||
           (lVar5 = *(int64 *)(lVar5 + 0x1f0)) == null) goto LAB_180a924ae;
        if (*(int *)(lVar5 + 96) < 1) {
          if (((this.meditationUI == null) ||
              (lVar5 = GameObject.get_transform(this.meditationUI,0)) == null) ||
             (lVar5 = Transform.Find(lVar5,"MedSureButton",0)) == null) goto LAB_180a924ae;
          lVar5 = Component.GetComponent(lVar5,DAT_181d93760);
          uVar7 = this.medIcon;
          uVar4 = Object.op_Inequality(uVar7,0,0);
          if (lVar5 == null) goto LAB_180a924ae;
          Selectable.set_interactable(lVar5,uVar4,0);
          if (((this.meditationUI == null) ||
              (lVar5 = GameObject.get_transform(this.meditationUI,0)) == null) ||
             (lVar5 = Transform.Find(lVar5,"MedSureButton",0)) == null) goto LAB_180a924ae;
          lVar5 = Transform.Find(lVar5,"Text",0);
          if (lVar5 == null) goto LAB_180a924ae;
          plVar6 = (int64 *)Component.GetComponent(lVar5,DAT_181d96160);
          uVar7 = "供奉";
          uVar7 = LTLocalization.GetText(uVar7,0,1,0);
          if (plVar6 == (int64 *)0) goto LAB_180a924ae;
          (**(code **)(*plVar6 + 0x5e8))(plVar6,uVar7,*(uint64 *)(*plVar6 + 0x5f0));
          LTLocalization.CheckTextFont(plVar6,0);
          if ((((this.meditationUI == null) ||
               (lVar5 = GameObject.get_transform(this.meditationUI,0)) == null) ||
              (lVar5 = Transform.Find(lVar5,"MedSureButton",0)) == null) ||
             (lVar5 = Transform.Find(lVar5,"Text",0)) == null) goto LAB_180a924ae;
          plVar6 = (int64 *)Component.GetComponent(lVar5,DAT_181d96160);
          puVar9 = (uint64 *)Color.get_black(&local_78,0);
          if (plVar6 == (int64 *)0) goto LAB_180a924ae;
          local_78 = *puVar9;
          uStack_70 = puVar9[1];
          (**(code **)(*plVar6 + 0x2a8))(plVar6,&local_78,*(uint64 *)(*plVar6 + 0x2b0));
          if (((this.meditationUI == null) ||
              (lVar5 = GameObject.get_transform(this.meditationUI,0)) == null) ||
             (lVar5 = Transform.Find(lVar5,"ClearMedButton",0)) == null) goto LAB_180a924ae;
          lVar5 = Component.get_gameObject(lVar5,0);
          uVar4 = Object.op_Inequality(this.medIcon,0,0);
          if (lVar5 == null) goto LAB_180a924ae;
          GameObject.SetActive(lVar5,uVar4,0);
          if ((this.meditationUI == null) ||
             (lVar5 = GameObject.get_transform(this.meditationUI,0)) == null)
          goto LAB_180a924ae;
          lVar5 = Transform.Find(lVar5,"MedAddText",0);
          if (lVar5 == null) goto LAB_180a924ae;
          plVar6 = (int64 *)Component.GetComponent(lVar5,DAT_181d96160);
          uVar7 = "";
          uVar7 = LTLocalization.GetText(uVar7,0,1,0);
          if (plVar6 == (int64 *)0) goto LAB_180a924ae;
        }
        else {
          uVar7 = this.medIcon;
          cVar3 = Object.op_Equality(uVar7,0,0);
          if (cVar3) {
            if (((this.meditationUI == null) ||
                (lVar5 = GameObject.get_transform(this.meditationUI,0)) == null) ||
               (lVar5 = Transform.Find(lVar5,"Med",0)) == null) goto LAB_180a924ae;
            uVar7 = Component.get_gameObject(lVar5,0);
            lVar5 = FUN_18046c0a0(0);
            if (((lVar5 == null) || (*(int64 *)(lVar5 + 32) == 0)) ||
               (lVar5 = *(int64 *)(*(int64 *)(lVar5 + 32) + 0x1f0)) == null)
            goto LAB_180a924ae;
            uVar7 = MeditationUIController.CreateMeditationItemIcon
                              (this,uVar7,*(uint64 *)(lVar5 + 80),0);
            *puVar9 = uVar7;
            il2cpp_internal(puVar9,uVar7);
          }
          if ((((this.meditationUI == null) ||
               (lVar5 = GameObject.get_transform(this.meditationUI,0)) == null) ||
              (lVar5 = Transform.Find(lVar5,"MedSureButton",0)) == null) ||
             (lVar5 = Component.GetComponent(lVar5,DAT_181d93760)) == null) throw; // [null/range check failed]
          Selectable.set_interactable(lVar5,0,0);
          if (((this.meditationUI == null) ||
              (lVar5 = GameObject.get_transform(this.meditationUI,0)) == null) ||
             ((lVar5 = Transform.Find(lVar5,"MedSureButton",0), lVar5 == null ||
              (lVar5 = Transform.Find(lVar5,"Text",0)) == null))) throw; // [null/range check failed]
          plVar6 = (int64 *)Component.GetComponent(lVar5,DAT_181d96160);
          if (((*pStatics_2cc8 == 0) ||
              (lVar5 = *(int64 *)(*pStatics_2cc8 + 32)) == null) ||
             (lVar5 = *(int64 *)(lVar5 + 0x1f0)) == null) throw; // [null/range check failed]
          uVar7 = Int32.ToString(lVar5 + 96,0);
          uVar7 = String.Concat(uVar7,"日",0);
          uVar7 = LTLocalization.GetText(uVar7,0,1,0);
          if (plVar6 == (int64 *)0) throw; // [null/range check failed]
          (**(code **)(*plVar6 + 0x5e8))(plVar6,uVar7,*(uint64 *)(*plVar6 + 0x5f0));
          LTLocalization.CheckTextFont(plVar6,0);
          if ((((this.meditationUI == null) ||
               (lVar5 = GameObject.get_transform(this.meditationUI,0)) == null) ||
              (lVar5 = Transform.Find(lVar5,"MedSureButton",0)) == null) ||
             (lVar5 = Transform.Find(lVar5,"Text",0)) == null) throw; // [null/range check failed]
          plVar6 = (int64 *)Component.GetComponent(lVar5,DAT_181d96160);
          if (plVar6 == (int64 *)0) throw; // [null/range check failed]
          local_78 = *(uint64 *)(pStatics_3d40 + 0x378);
          uStack_70 = *(uint64 *)(pStatics_3d40 + 0x380);
          (**(code **)(*plVar6 + 0x2a8))(plVar6,&local_78,*(uint64 *)(*plVar6 + 0x2b0));
          if (((this.meditationUI == null) ||
              (lVar5 = GameObject.get_transform(this.meditationUI,0)) == null) ||
             ((lVar5 = Transform.Find(lVar5,"ClearMedButton",0), lVar5 == null ||
              (lVar5 = Component.get_gameObject(lVar5,0)) == null))) throw; // [null/range check failed]
          GameObject.SetActive(lVar5,0,0);
          if (((this.meditationUI == null) ||
              (lVar5 = GameObject.get_transform(this.meditationUI,0)) == null) ||
             (lVar5 = Transform.Find(lVar5,"MedAddText",0)) == null) throw; // [null/range check failed]
          plVar6 = (int64 *)Component.GetComponent(lVar5,DAT_181d96160);
          if (((*pStatics_2cc8 == 0) ||
              (lVar5 = *(int64 *)(*pStatics_2cc8 + 32)) == null) ||
             ((lVar5 = *(int64 *)(lVar5 + 0x1f0), lVar5 == null ||
              (lVar5 = *(int64 *)(lVar5 + 88)) == null))) throw; // [null/range check failed]
          uVar7 = HeroSpeAddData.GetDescribe(lVar5,1,1,1,0,0);
          uVar7 = LTLocalization.GetText(uVar7,0,1,0);
          if (plVar6 == (int64 *)0) throw; // [null/range check failed]
        }
        (**(code **)(*plVar6 + 0x5e8))(plVar6,uVar7,*(uint64 *)(*plVar6 + 0x5f0));
        LTLocalization.CheckTextFont(plVar6,0);
        if (((this.meditationUI != null) &&
            (lVar5 = GameObject.get_transform(this.meditationUI,0)) != null) &&
           (lVar5 = Transform.Find(lVar5,"TreasureSureButton",0)) != null) {
          lVar5 = Component.GetComponent(lVar5,DAT_181d95560);
          uVar7 = MeditationUIController.GetItemMeditationEffectDescribe
                            (this,this.treasureIcon,0);
          if (lVar5 != null) {
            *(uint64 *)(lVar5 + 24) = uVar7;
            if (((this.meditationUI != null) &&
                (lVar5 = GameObject.get_transform(this.meditationUI,0)) != null) &&
               (lVar5 = Transform.Find(lVar5,"FoodSureButton",0)) != null) {
              lVar5 = Component.GetComponent(lVar5,DAT_181d95560);
              uVar7 = MeditationUIController.GetItemMeditationEffectDescribe
                                (this,this.foodIcon,0);
              if (lVar5 != null) {
                *(uint64 *)(lVar5 + 24) = uVar7;
                if (((this.meditationUI != null) &&
                    (lVar5 = GameObject.get_transform(this.meditationUI,0)) != null) &&
                   (lVar5 = Transform.Find(lVar5,"MedSureButton",0)) != null) {
                  lVar5 = Component.GetComponent(lVar5,DAT_181d95560);
                  uVar7 = MeditationUIController.GetItemMeditationEffectDescribe
                                    (this,this.medIcon,0);
                  if (lVar5 != null) {
                    *(uint64 *)(lVar5 + 24) = uVar7;
                    return;
                  }
                }
              }
            }
          }
        }
    }

    // Token : 0x60018F8
    // RVA   : 0xA8ED80   Offset: 0xA8E180   Length: 0x2D7
    public string GetItemMeditationEffectDescribe(GameObject itemIcon)
    {
        var pStatics = *(int64*)(DAT_181d72cc8 + 184);
        uint64
        MeditationUIController.GetItemMeditationEffectDescribe(uint64 this,int64 itemIcon)
        {
        int64 lVar1;
        char cVar2;
        int64 lVar3;
        uint64 uVar4;
        uint64 uVar5;
        float fVar6;
        float fVar7;
        float local_res10 [2];
        cVar2 = Object.op_Equality(itemIcon,0,0);
        if (cVar2) {
          return "";
        }
        if (((*pStatics != 0) &&
            (lVar1 = *(int64 *)(*pStatics + 32)) != null) &&
           (lVar1 = *(int64 *)(lVar1 + 0x1f0), itemIcon != null)) {
          lVar3 = GameObject.GetComponent(itemIcon,DAT_181d720a0);
          if ((lVar3 != null) && (lVar1 != null)) {
            fVar7 = 0.0;
            if (*(int64 *)(lVar3 + 32) == 0) {
              local_res10[0] = 0.0;
            }
            else {
              fVar6 = (float)*(int *)(*(int64 *)(lVar3 + 32) + 56);
              Mathf.Log((fVar6 + fVar6) * 0.01);
              local_res10[0] = (float)Mathf.Max();
            }
            local_res10[0] = local_res10[0] * 100.0;
            uVar4 = Single.ToString(local_res10,"f0",0);
            if ((*pStatics != 0) &&
               (lVar1 = *(int64 *)(*pStatics + 32)) != null) {
              lVar1 = *(int64 *)(lVar1 + 0x1f0);
              lVar3 = GameObject.GetComponent(itemIcon,DAT_181d720a0);
              if ((lVar3 != null) && (lVar1 != null)) {
                if (*(int64 *)(lVar3 + 32) != 0) {
                  fVar7 = (float)Mathf.Max();
                }
                local_res10[0] = fVar7;
                uVar5 = Single.ToString(local_res10,"f0",0);
                uVar4 = String.Format("每日经验+{1}\n修行效率+{0}%",uVar4,uVar5,0);
                return uVar4;
              }
            }
          }
        }
    }

    // Token : 0x60018F9
    // RVA   : 0xA8E790   Offset: 0xA8DB90   Length: 0x12A
    public GameObject CreateMeditationItemIcon(GameObject parent, ItemData targetItemData)
    {
        var pStatics = *(int64*)(DAT_181d72ee8 + 184);
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
            lVar3 = GameObject.GetComponent(lVar2,DAT_181d720a0);
            if (lVar3 != null) {
              *(uint64 *)(lVar3 + 32) = targetItemData;
              lVar3 = GameObject.GetComponent(lVar2,DAT_181d720a0);
              if (lVar3 != null) {
                *(uint32 *)(lVar3 + 40) = 1;
                lVar3 = GameObject.GetComponent(lVar2,DAT_181d720a0);
                if (lVar3 != null) {
                  ItemIconController.AutoSetName(lVar3,1,0);
                  return lVar2;
                }
              }
            }
          }
        }
    }

    // Token : 0x60018FA
    // RVA   : 0xA93310   Offset: 0xA92710   Length: 0x1AA
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
        lVar1 = **(int64 **)(DAT_181db7518 + 184);
        lVar3 = il2cpp_internal(DAT_181d94e50);
        FUN_18132faf0(lVar3,DAT_181d95788);
        local_res8[0] = 0;
        uVar4 = il2cpp_value_box(DAT_181d80418,local_res8);
        if (lVar3 != null) {
          FUN_18181e0a0(lVar3,uVar4,DAT_181d95888);
          local_res18[0] = 4;
          uVar4 = il2cpp_value_box(DAT_181d80418,local_res18);
          FUN_18181e0a0(lVar3,uVar4,DAT_181d95888);
          uVar4 = Component.get_gameObject(this,0);
          if (lVar1 != null) {
            ChooseController.ShowChoosePanel(lVar1,1,lVar3,uVar4,"MeditationTreasureChoosen",0,0,0,0,0);
            return;
          }
        }
    }

    // Token : 0x60018FB
    // RVA   : 0xA8F910   Offset: 0xA8ED10   Length: 0xFC
    public void MeditationTreasureChoosen()
    {
        var pStatics = *(int64*)(DAT_181db7518 + 184);
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
                lVar1 = GameObject.GetComponent(lVar1,DAT_181d720a0);
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

    // Token : 0x60018FC
    // RVA   : 0xA8E6D0   Offset: 0xA8DAD0   Length: 0xB4
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

    // Token : 0x60018FD
    // RVA   : 0xA8E8C0   Offset: 0xA8DCC0   Length: 0x1AA
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
        lVar1 = **(int64 **)(DAT_181db7518 + 184);
        lVar3 = il2cpp_internal(DAT_181d94e50);
        FUN_18132faf0(lVar3,DAT_181d95788);
        local_res8[0] = 0;
        uVar4 = il2cpp_value_box(DAT_181d80418,local_res8);
        if (lVar3 != null) {
          FUN_18181e0a0(lVar3,uVar4,DAT_181d95888);
          local_res18[0] = 2;
          uVar4 = il2cpp_value_box(DAT_181d80418,local_res18);
          FUN_18181e0a0(lVar3,uVar4,DAT_181d95888);
          uVar4 = Component.get_gameObject(this,0);
          if (lVar1 != null) {
            ChooseController.ShowChoosePanel(lVar1,1,lVar3,uVar4,"MeditationFoodChoosen",0,0,0,0,0);
            return;
          }
        }
    }

    // Token : 0x60018FE
    // RVA   : 0xA8F710   Offset: 0xA8EB10   Length: 0xFC
    public void MeditationFoodChoosen()
    {
        var pStatics = *(int64*)(DAT_181db7518 + 184);
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
                lVar1 = GameObject.GetComponent(lVar1,DAT_181d720a0);
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

    // Token : 0x60018FF
    // RVA   : 0xA8E550   Offset: 0xA8D950   Length: 0xB4
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

    // Token : 0x6001900
    // RVA   : 0xA8F250   Offset: 0xA8E650   Length: 0x1AA
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
        lVar1 = **(int64 **)(DAT_181db7518 + 184);
        lVar3 = il2cpp_internal(DAT_181d94e50);
        FUN_18132faf0(lVar3,DAT_181d95788);
        local_res8[0] = 0;
        uVar4 = il2cpp_value_box(DAT_181d80418,local_res8);
        if (lVar3 != null) {
          FUN_18181e0a0(lVar3,uVar4,DAT_181d95888);
          local_res18[0] = 1;
          uVar4 = il2cpp_value_box(DAT_181d80418,local_res18);
          FUN_18181e0a0(lVar3,uVar4,DAT_181d95888);
          uVar4 = Component.get_gameObject(this,0);
          if (lVar1 != null) {
            ChooseController.ShowChoosePanel(lVar1,1,lVar3,uVar4,"MeditationMedChoosen",0,0,0,0,0);
            return;
          }
        }
    }

    // Token : 0x6001901
    // RVA   : 0xA8F810   Offset: 0xA8EC10   Length: 0xFC
    public void MeditationMedChoosen()
    {
        var pStatics = *(int64*)(DAT_181db7518 + 184);
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
                lVar1 = GameObject.GetComponent(lVar1,DAT_181d720a0);
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

    // Token : 0x6001902
    // RVA   : 0xA8E610   Offset: 0xA8DA10   Length: 0xB4
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

    // Token : 0x6001903
    // RVA   : 0xA934C0   Offset: 0xA928C0   Length: 0x306
    public void TreasureSureButtonClicked()
    {
        var pStatics = *(int64*)(DAT_181d72cc8 + 184);
        long lVar1;
        long lVar2;
        if ((*pStatics != 0) &&
           (lVar2 = *(int64 *)(*pStatics + 32)) != null) {
          lVar2 = *(int64 *)(lVar2 + 0x1f0);
          if (this.treasureIcon != null) {
            lVar1 = GameObject.GetComponent(this.treasureIcon,DAT_181d720a0);
            if ((lVar1 != null) && (lVar2 != null)) {
              *(uint64 *)(lVar2 + 32) = *(uint64 *)(lVar1 + 32);
              if (((*pStatics != 0) &&
                  (lVar2 = *(int64 *)(*pStatics + 32)) != null) &&
                 (lVar2 = *(int64 *)(lVar2 + 0x1f0)) != null) {
                *(uint32 *)(lVar2 + 48) = 30;
                this.needRefresh = 1;
                if ((*pStatics != 0) &&
                   (lVar2 = *(int64 *)(*pStatics + 32)) != null) {
                  lVar2 = WorldData.Player(lVar2,0);
                  if ((((*pStatics != 0) &&
                       (lVar1 = *(int64 *)(*pStatics + 32)) != null)
                      && (lVar1 = *(int64 *)(lVar1 + 0x1f0)) != null) && (lVar2 != null)) {
                    HeroData.LoseItem(lVar2,*(uint64 *)(lVar1 + 32),1,0);
                    if (((*pStatics != 0) &&
                        (lVar2 = *(int64 *)(*pStatics + 32)) != null)
                       && (lVar2 = *(int64 *)(lVar2 + 0x1f0)) != null) {
                      MeditationUIController.StartMeditationItemPlot
                                (this,*(uint64 *)(lVar2 + 32),0);
                      return;
                    }
                  }
                }
              }
            }
          }
        }
    }

    // Token : 0x6001904
    // RVA   : 0xA8EA70   Offset: 0xA8DE70   Length: 0x306
    public void FoodSureButtonClicked()
    {
        var pStatics = *(int64*)(DAT_181d72cc8 + 184);
        long lVar1;
        long lVar2;
        if ((*pStatics != 0) &&
           (lVar2 = *(int64 *)(*pStatics + 32)) != null) {
          lVar2 = *(int64 *)(lVar2 + 0x1f0);
          if (this.foodIcon != null) {
            lVar1 = GameObject.GetComponent(this.foodIcon,DAT_181d720a0);
            if ((lVar1 != null) && (lVar2 != null)) {
              *(uint64 *)(lVar2 + 56) = *(uint64 *)(lVar1 + 32);
              if (((*pStatics != 0) &&
                  (lVar2 = *(int64 *)(*pStatics + 32)) != null) &&
                 (lVar2 = *(int64 *)(lVar2 + 0x1f0)) != null) {
                *(uint32 *)(lVar2 + 72) = 30;
                this.needRefresh = 1;
                if ((*pStatics != 0) &&
                   (lVar2 = *(int64 *)(*pStatics + 32)) != null) {
                  lVar2 = WorldData.Player(lVar2,0);
                  if ((((*pStatics != 0) &&
                       (lVar1 = *(int64 *)(*pStatics + 32)) != null)
                      && (lVar1 = *(int64 *)(lVar1 + 0x1f0)) != null) && (lVar2 != null)) {
                    HeroData.LoseItem(lVar2,*(uint64 *)(lVar1 + 56),1,0);
                    if (((*pStatics != 0) &&
                        (lVar2 = *(int64 *)(*pStatics + 32)) != null)
                       && (lVar2 = *(int64 *)(lVar2 + 0x1f0)) != null) {
                      MeditationUIController.StartMeditationItemPlot
                                (this,*(uint64 *)(lVar2 + 56),0);
                      return;
                    }
                  }
                }
              }
            }
          }
        }
    }

    // Token : 0x6001905
    // RVA   : 0xA8F400   Offset: 0xA8E800   Length: 0x306
    public void MedSureButtonClicked()
    {
        var pStatics = *(int64*)(DAT_181d72cc8 + 184);
        long lVar1;
        long lVar2;
        if ((*pStatics != 0) &&
           (lVar2 = *(int64 *)(*pStatics + 32)) != null) {
          lVar2 = *(int64 *)(lVar2 + 0x1f0);
          if (this.medIcon != null) {
            lVar1 = GameObject.GetComponent(this.medIcon,DAT_181d720a0);
            if ((lVar1 != null) && (lVar2 != null)) {
              *(uint64 *)(lVar2 + 80) = *(uint64 *)(lVar1 + 32);
              if (((*pStatics != 0) &&
                  (lVar2 = *(int64 *)(*pStatics + 32)) != null) &&
                 (lVar2 = *(int64 *)(lVar2 + 0x1f0)) != null) {
                *(uint32 *)(lVar2 + 96) = 30;
                this.needRefresh = 1;
                if ((*pStatics != 0) &&
                   (lVar2 = *(int64 *)(*pStatics + 32)) != null) {
                  lVar2 = WorldData.Player(lVar2,0);
                  if ((((*pStatics != 0) &&
                       (lVar1 = *(int64 *)(*pStatics + 32)) != null)
                      && (lVar1 = *(int64 *)(lVar1 + 0x1f0)) != null) && (lVar2 != null)) {
                    HeroData.LoseItem(lVar2,*(uint64 *)(lVar1 + 80),1,0);
                    if (((*pStatics != 0) &&
                        (lVar2 = *(int64 *)(*pStatics + 32)) != null)
                       && (lVar2 = *(int64 *)(lVar2 + 0x1f0)) != null) {
                      MeditationUIController.StartMeditationItemPlot
                                (this,*(uint64 *)(lVar2 + 80),0);
                      return;
                    }
                  }
                }
              }
            }
          }
        }
    }

    // Token : 0x6001906
    // RVA   : 0xA92C00   Offset: 0xA92000   Length: 0x705
    public void StartMeditationItemPlot(ItemData targetItem)
    {
        var pStatics = *(int64*)(DAT_181d91b88 + 184);
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
        lVar2 = *(int64 *)(pStatics + 24);
        if (lVar2 != null) {
          PlotController.SetPlotItem(lVar2,targetItem,1,0);
          lVar2 = new HeroSpeAddData(0);
          lVar3 = il2cpp_internal(DAT_181d97750);
          FUN_18132faf0(lVar3,DAT_181da3bd8);
          iVar9 = 0;
          do {
            if (lVar2 == null) {
        LAB_180a93300:
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            HeroSpeAddData.Reset(lVar2,0);
            lVar4 = FUN_18046c0a0(0);
            if ((targetItem == null) || (lVar4 == null)) goto LAB_180a93300;
            in_stack_ffffffffffffff98 = in_stack_ffffffffffffff98 & 0xffffffff00000000;
            GameController.GenerateSpeAddByValue
                      (lVar4,*(int *)(targetItem + 60) + 1,lVar2,1,in_stack_ffffffffffffff98,0);
            lVar4 = HeroSpeAddData.GetKeys(lVar2,0);
            if (lVar4 == null) goto LAB_180a93300;
            if (*(int *)(lVar4 + 24) == 0) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            uVar1 = *(uint32 *)(*(int64 *)(lVar4 + 16) + 32);
            plVar5 = (int64 *)FUN_1800d60b0(DAT_181da4120,4);
            local_res10[0] = uVar1;
            lVar4 = il2cpp_value_box(DAT_181d80418,local_res10);
            if (plVar5 == (int64 *)0) goto LAB_180a93300;
            if ((lVar4 != null) &&
               (lVar6 = il2cpp_internal(lVar4,*(uint64 *)(*plVar5 + 64))) == null) {
              uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar7,0);
            }
            if ((int)plVar5[3] == 0) {
              uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar7,0);
            }
            plVar5[4] = lVar4;
            il2cpp_internal(plVar5 + 4,lVar4);
            local_res20[0] = HeroSpeAddData.Get(lVar2,uVar1,0);
            lVar4 = il2cpp_value_box(DAT_181da22d8,local_res20);
            if ((lVar4 != null) &&
               (lVar6 = il2cpp_internal(lVar4,*(uint64 *)(*plVar5 + 64))) == null) {
              uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar7,0);
            }
            if (*(uint32 *)(plVar5 + 3) < 2) {
              uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar7,0);
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
              FUN_1800d65f0(uVar7,0);
            }
            if (*(uint32 *)(plVar5 + 3) < 3) {
              uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar7,0);
            }
            plVar5[6] = lVar4;
            il2cpp_internal(plVar5 + 6,lVar4);
            lVar4 = FUN_18046c100(0);
            if (((lVar4 == null) || (*(int64 *)(lVar4 + 144) == 0)) ||
               (lVar4 = FUN_180002f80(*(int64 *)(lVar4 + 144),uVar1,DAT_181d8c018),
               uVar7 = "{2};ChooseMeditationItemSpeAdd;{0}-{1};;{3}", lVar4 == null)) goto LAB_180a93300;
            lVar6 = "";
            if (*(char *)(lVar4 + 89) != false) {
              lVar4 = FUN_18046c100(0);
              if (((lVar4 == null) || (*(int64 *)(lVar4 + 144) == 0)) ||
                 (lVar4 = FUN_180002f80(*(int64 *)(lVar4 + 144),uVar1,DAT_181d8c018)) == null)
              throw; // [null/range check failed]
              lVar6 = HeroSpeAddDataBase.GetDescribe(lVar4,0);
            }
            if ((lVar6 != null) &&
               (lVar4 = il2cpp_internal(lVar6,*(uint64 *)(*plVar5 + 64))) == null) {
              uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar7,0);
            }
            FUN_180002fd0(plVar5,3,lVar6);
            uVar7 = String.Format(uVar7,plVar5,0);
            if (lVar3 == null) throw; // [null/range check failed]
            FUN_18181e0a0(lVar3,uVar7,DAT_181da3d58);
            iVar9 = iVar9 + 1;
          } while (iVar9 < 5);
          lVar6 = DAT_181d8b140;
          lVar2 = *(int64 *)(pStatics + 24);
          plVar5 = *(int64 **)(DAT_181d8b140 + 48);
          lVar4 = *plVar5;
          if ((*(byte *)(lVar4 + 0x132) & 1) == 0) {
            FUN_18009a510(lVar4);
            plVar5 = *(int64 **)(lVar6 + 48);
          }
          if ((*(byte *)(lVar4 + 0x133) & 4) != 0) {
            lVar4 = *plVar5;
            if ((*(byte *)(lVar4 + 0x132) & 1) == 0) {
              FUN_18009a510(lVar4);
              plVar5 = *(int64 **)(lVar6 + 48);
            }
            if (*(int *)(lVar4 + 224) == 0) {
              lVar4 = *plVar5;
              if ((*(byte *)(lVar4 + 0x132) & 1) == 0) {
                FUN_18009a510(lVar4);
              }
              il2cpp_runtime_class_init(lVar4);
            }
          }
          lVar4 = **(int64 **)(lVar6 + 48);
          if ((*(byte *)(lVar4 + 0x132) & 1) == 0) {
            FUN_18009a510(lVar4);
          }
          uVar7 = String.Format("在供奉这#PlotInteractItemName#之时，\n忽觉一阵灵光乍现，恍然间似乎有所领悟......",**(uint64 **)(lVar4 + 184),0);
          uVar8 = new SinglePlotData(uVar7,lVar3,1,0,CONCAT44(uVar10,3),"0",1,0,0);
          if (lVar2 != null) {
            PlotController.ChangePlot(lVar2,uVar8,0);
            return;
          }
        }
    }

    // Token : 0x6001907
    // RVA   : 0xA92770   Offset: 0xA91B70   Length: 0x480
    public void StartMeditationButtonClicked()
    {
        var pStatics = *(int64*)(DAT_181d72cc8 + 184);
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
        lVar2 = il2cpp_internal(DAT_181d97750);
        FUN_18132faf0(lVar2,DAT_181da3bd8);
        iVar7 = 1;
        while( true ) {
          uVar3 = GlobalData.GetNumText(iVar7,0);
          local_res20[0] = iVar7;
          uVar4 = il2cpp_value_box(DAT_181d80418,local_res20);
          uVar3 = String.Format("{0}日;StartMeditationWork;{1}",uVar3,uVar4,0);
          if (lVar2 == null) break;
          FUN_18181e0a0(lVar2,uVar3,DAT_181da3d58);
          iVar7 = iVar7 + 1;
          if (5 < iVar7) {
            FUN_18181e0a0(lVar2,"还是算了;HideInteractUI",DAT_181da3d58);
            lVar1 = *(int64 *)(*(int64 *)(DAT_181d91b88 + 184) + 24);
            if ((*pStatics != 0) &&
               (lVar5 = *(int64 *)(*pStatics + 32)) != null) {
              lVar5 = WorldData.Player(lVar5,0);
              if (lVar5 != null) {
                uVar3 = HeroData.GetMeditationTopic(lVar5,0);
                if (((*pStatics != 0) &&
                    (lVar5 = *(int64 *)(*pStatics + 32)) != null) &&
                   (lVar5 = *(int64 *)(lVar5 + 0x1f0)) != null) {
                  local_res20[0] = *(int *)(lVar5 + 24);
                  uVar4 = il2cpp_value_box(DAT_181d80418,local_res20);
                  if (((*pStatics != 0) &&
                      (lVar5 = *(int64 *)(*pStatics + 32)) != null)
                     && (lVar5 = *(int64 *)(lVar5 + 0x1f0)) != null) {
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
            FUN_1800d6620();
          }
        }
    }

    // Token : 0x6001908
    // RVA   : 0x3A17B0   Offset: 0x3A0BB0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_18044ef50(this,0);
    }

}
