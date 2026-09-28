// ============================================================
// Type  : SaveLoadMenuController
// Token : 0x200034B
// ============================================================

public class SaveLoadMenuController
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001B41
    public SaveLoadType saveLoadType;

    // Token: 0x4001B42
    public GameObject saveLoadMenu;

    // Token: 0x4001B43
    public List<Sprite> seasonSprite;

    // Token: 0x4001B44
    private GameObject saveSlot;

    // Token: 0x4001B45
    public static int saveSlotNum;

    // Token: 0x4001B46
    private static SaveLoadMenuController _instance;

    // Token: 0x4001B47
    private bool showing;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60020CC
    // RVA   : 0x97ADD0   Offset: 0x97A1D0   Length: 0x58
    public static SaveLoadMenuController get_Instance()
    {
        return *(uint64 *)(*(int64 *)(DAT_181d9ecf0 + 184) + 8);
    }

    // Token : 0x60020CD
    // RVA   : 0x978590   Offset: 0x977990   Length: 0xE0
    private void Awake()
    {
        ulong uVar1;
        bool cVar2;
        uVar1 = SaveLoadMenuController._instance;
        cVar2 = Object.op_Equality(uVar1,0,0);
        if (cVar2) {
          SaveLoadMenuController._instance = this;
        }
    }

    // Token : 0x60020CE
    // RVA   : 0x978D80   Offset: 0x978180   Length: 0xE2B
    public void RefreshSlot(int slotID)
    {
        bool cVar1;
        int iVar2;
        long lVar3;
        ulong uVar4;
        long lVar7;
        ulong uVar8;
        long lVar9;
        uint[] local_res10 = new uint[2];
        ulong local_38;
        uint local_30;
        ulong local_28;
        ulong uStack_20;
        local_res10[0] = slotID;
        lVar3 = GameController.lockObj;
        if (lVar3 == null) throw; // [null/range check failed]
        cVar1 = GameDataController.HaveSave(lVar3,local_res10[0],0);
        if (!cVar1) {
          if (this.saveSlot == null) throw; // [null/range check failed]
          lVar3 = GameObject.get_transform(this.saveSlot,0);
          uVar4 = Int32.ToString(local_res10,0);
          if (((lVar3 == null) || (lVar3 = Transform.Find(lVar3,uVar4,0)) == null) ||
             (lVar3 = Transform.Find(lVar3,"Name",0)) == null) throw; // [null/range check failed]
          uVar4 = Component.GetComponent(lVar3,DAT_181d96160);
          LTLocalization.SetText(uVar4,"空",0);
          if (this.saveSlot == null) throw; // [null/range check failed]
          lVar3 = GameObject.get_transform(this.saveSlot,0);
          uVar4 = Int32.ToString(local_res10,0);
          if (((lVar3 == null) || (lVar3 = Transform.Find(lVar3,uVar4,0)) == null) ||
             (lVar3 = Transform.Find(lVar3,"Info",0)) == null) throw; // [null/range check failed]
          uVar4 = Component.GetComponent(lVar3,DAT_181d96160);
          LTLocalization.SetText(uVar4,"",0);
          if (this.saveSlot == null) throw; // [null/range check failed]
          lVar3 = GameObject.get_transform(this.saveSlot,0);
          uVar4 = Int32.ToString(local_res10,0);
          if (((lVar3 == null) || (lVar3 = Transform.Find(lVar3,uVar4,0)) == null) ||
             (lVar3 = Transform.Find(lVar3,"Mode",0)) == null) throw; // [null/range check failed]
          uVar4 = Component.GetComponent(lVar3,DAT_181d96160);
          LTLocalization.SetText(uVar4,"",0);
          if (this.saveSlot == null) throw; // [null/range check failed]
          lVar3 = GameObject.get_transform(this.saveSlot,0);
          uVar4 = Int32.ToString(local_res10,0);
          if (((lVar3 == null) || (lVar3 = Transform.Find(lVar3,uVar4,0)) == null) ||
             (lVar3 = Transform.Find(lVar3,"ForceLv",0)) == null) throw; // [null/range check failed]
          uVar4 = Component.GetComponent(lVar3,DAT_181d96160);
          LTLocalization.SetText(uVar4,"",0);
          if (this.saveSlot == null) throw; // [null/range check failed]
          lVar3 = GameObject.get_transform(this.saveSlot,0);
          uVar4 = Int32.ToString(local_res10,0);
          if (((lVar3 == null) || (lVar3 = Transform.Find(lVar3,uVar4,0)) == null) ||
             (lVar3 = Transform.Find(lVar3,"Difficulty",0)) == null) throw; // [null/range check failed]
          uVar4 = Component.GetComponent(lVar3,DAT_181d96160);
          LTLocalization.SetText(uVar4,"",0);
          if (this.saveSlot == null) throw; // [null/range check failed]
          lVar3 = GameObject.get_transform(this.saveSlot,0);
          uVar4 = Int32.ToString(local_res10,0);
          if (((lVar3 == null) || (lVar3 = Transform.Find(lVar3,uVar4,0)) == null) ||
             (lVar3 = Transform.Find(lVar3,"Time",0)) == null) throw; // [null/range check failed]
          uVar4 = Component.GetComponent(lVar3,DAT_181d96160);
          LTLocalization.SetText(uVar4,"",0);
          if (this.saveSlot == null) throw; // [null/range check failed]
          lVar3 = GameObject.get_transform(this.saveSlot,0);
          uVar4 = Int32.ToString(local_res10,0);
          if (((lVar3 == null) || (lVar3 = Transform.Find(lVar3,uVar4,0)) == null) ||
             (lVar3 = Transform.Find(lVar3,"Season",0)) == null) throw; // [null/range check failed]
          plVar5 = (int64 *)Component.GetComponent(lVar3,DAT_181d94460);
          puVar6 = (uint64 *)FUN_180d98fe0(&local_28,0);
          if (plVar5 == (int64 *)0) throw; // [null/range check failed]
          local_28 = *puVar6;
          uStack_20 = puVar6[1];
          (**(code **)(*plVar5 + 0x2a8))(plVar5,&local_28,*(uint64 *)(*plVar5 + 0x2b0));
          if (this.saveSlot == null) throw; // [null/range check failed]
          lVar3 = GameObject.get_transform(this.saveSlot,0);
          uVar4 = Int32.ToString(local_res10,0);
          if ((lVar3 == null) || (lVar3 = Transform.Find(lVar3,uVar4,0)) == null) throw; // [null/range check failed]
          lVar3 = Transform.Find(lVar3,"Delete",0);
          puVar6 = (uint64 *)Vector3.get_zero(&local_28,0);
        }
        else {
          lVar3 = GameController.lockObj;
          if ((lVar3 == null) ||
             (lVar3 = GameDataController.GetSaveInfo(lVar3,local_res10[0],0)) == null)
          throw; // [null/range check failed]
          lVar9 = lVar3.Count;
          lVar7 = FUN_1800d60b0(DAT_181da1040,1);
          if (lVar7 == null) throw; // [null/range check failed]
          if (*(int *)(lVar7 + 24) == 0) {
            uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar4,0);
          }
          *(uint16 *)(lVar7 + 32) = 10;
          if (lVar9 == null) throw; // [null/range check failed]
          uVar4 = String.Split(lVar9,lVar7,0);
          uVar8 = il2cpp_internal(DAT_181d97750);
          FUN_181827480(uVar8,uVar4,DAT_181da3c58);
          lVar9 = GlobalData.RemoveEmptyString(uVar8,0);
          if (this.saveSlot == null) throw; // [null/range check failed]
          lVar7 = GameObject.get_transform(this.saveSlot,0);
          uVar4 = Int32.ToString(local_res10,0);
          if ((((lVar7 == null) || (lVar7 = Transform.Find(lVar7,uVar4,0)) == null) ||
              (lVar7 = Transform.Find(lVar7,"Name",0)) == null) ||
             (uVar4 = Component.GetComponent(lVar7,DAT_181d96160), lVar9 == null)) throw; // [null/range check failed]
          if (*(int *)(lVar9 + 24) == 0) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          uVar8 = *(uint64 *)(*(int64 *)(lVar9 + 16) + 32);
          LTLocalization.SetText(uVar4,uVar8,0);
          if (this.saveSlot == null) throw; // [null/range check failed]
          lVar7 = GameObject.get_transform(this.saveSlot,0);
          uVar4 = Int32.ToString(local_res10,0);
          if (((lVar7 == null) || (lVar7 = Transform.Find(lVar7,uVar4,0)) == null) ||
             (lVar7 = Transform.Find(lVar7,"Info",0)) == null) throw; // [null/range check failed]
          uVar4 = Component.GetComponent(lVar7,DAT_181d96160);
          if (*(uint32 *)(lVar9 + 24) < 2) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          LTLocalization.SetText(uVar4,*(uint64 *)(*(int64 *)(lVar9 + 16) + 40),0);
          if (this.saveSlot == null) throw; // [null/range check failed]
          lVar7 = GameObject.get_transform(this.saveSlot,0);
          uVar4 = Int32.ToString(local_res10,0);
          if (((lVar7 == null) || (lVar7 = Transform.Find(lVar7,uVar4,0)) == null) ||
             (lVar7 = Transform.Find(lVar7,"Mode",0)) == null) throw; // [null/range check failed]
          uVar8 = Component.GetComponent(lVar7,DAT_181d96160);
          uVar4 = "";
          if (2 < (int)*(uint32 *)(lVar9 + 24)) {
            if (*(uint32 *)(lVar9 + 24) < 3) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            uVar4 = *(uint64 *)(*(int64 *)(lVar9 + 16) + 48);
          }
          LTLocalization.SetText(uVar8,uVar4,0);
          if (this.saveSlot == null) throw; // [null/range check failed]
          lVar7 = GameObject.get_transform(this.saveSlot,0);
          uVar4 = Int32.ToString(local_res10,0);
          if (((lVar7 == null) || (lVar7 = Transform.Find(lVar7,uVar4,0)) == null) ||
             (lVar7 = Transform.Find(lVar7,"ForceLv",0)) == null) throw; // [null/range check failed]
          uVar8 = Component.GetComponent(lVar7,DAT_181d96160);
          uVar4 = "";
          if (3 < (int)*(uint32 *)(lVar9 + 24)) {
            if (*(uint32 *)(lVar9 + 24) < 4) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            uVar4 = *(uint64 *)(*(int64 *)(lVar9 + 16) + 56);
          }
          LTLocalization.SetText(uVar8,uVar4,0);
          if (this.saveSlot == null) throw; // [null/range check failed]
          lVar7 = GameObject.get_transform(this.saveSlot,0);
          uVar4 = Int32.ToString(local_res10,0);
          if (((lVar7 == null) || (lVar7 = Transform.Find(lVar7,uVar4,0)) == null) ||
             (lVar7 = Transform.Find(lVar7,"Difficulty",0)) == null) throw; // [null/range check failed]
          uVar8 = Component.GetComponent(lVar7,DAT_181d96160);
          uVar4 = "";
          if (4 < (int)*(uint32 *)(lVar9 + 24)) {
            if (*(uint32 *)(lVar9 + 24) < 5) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            uVar4 = *(uint64 *)(*(int64 *)(lVar9 + 16) + 64);
          }
          LTLocalization.SetText(uVar8,uVar4,0);
          if (this.saveSlot == null) throw; // [null/range check failed]
          lVar7 = GameObject.get_transform(this.saveSlot,0);
          uVar4 = Int32.ToString(local_res10,0);
          if (((lVar7 == null) || (lVar7 = Transform.Find(lVar7,uVar4,0)) == null) ||
             (lVar7 = Transform.Find(lVar7,"Time",0)) == null) throw; // [null/range check failed]
          uVar4 = Component.GetComponent(lVar7,DAT_181d96160);
          LTLocalization.SetText(uVar4,*(uint64 *)(lVar3 + 32),0);
          if (this.saveSlot == null) throw; // [null/range check failed]
          lVar3 = GameObject.get_transform(this.saveSlot,0);
          uVar4 = Int32.ToString(local_res10,0);
          if (((lVar3 == null) || (lVar3 = Transform.Find(lVar3,uVar4,0)) == null) ||
             (lVar3 = Transform.Find(lVar3,"Season",0)) == null) throw; // [null/range check failed]
          plVar5 = (int64 *)Component.GetComponent(lVar3,DAT_181d94460);
          puVar6 = (uint64 *)FUN_1810d3570(&local_28,0);
          if (plVar5 == (int64 *)0) throw; // [null/range check failed]
          local_28 = *puVar6;
          uStack_20 = puVar6[1];
          (**(code **)(*plVar5 + 0x2a8))(plVar5,&local_28,*(uint64 *)(*plVar5 + 0x2b0));
          if (*(uint32 *)(lVar9 + 24) < 2) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          lVar3 = *(int64 *)(*(int64 *)(lVar9 + 16) + 40);
          lVar9 = FUN_1800d60b0(DAT_181da1040,1);
          if (lVar9 == null) throw; // [null/range check failed]
          if (*(int *)(lVar9 + 24) == 0) {
            uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar4,0);
          }
          *(uint16 *)(lVar9 + 32) = 0x5e74;
          if ((lVar3 == null) || (lVar3 = String.Split(lVar3,lVar9,0)) == null) throw; // [null/range check failed]
          if (lVar3.Count < 2) {
            uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar4,0);
          }
          lVar3 = *(int64 *)(lVar3 + 40);
          lVar9 = FUN_1800d60b0(DAT_181da1040,1);
          if (lVar9 == null) throw; // [null/range check failed]
          if (*(int *)(lVar9 + 24) == 0) {
            uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar4,0);
          }
          *(uint16 *)(lVar9 + 32) = 0x6708;
          if ((lVar3 == null) || (lVar3 = String.Split(lVar3,lVar9,0)) == null) throw; // [null/range check failed]
          if (lVar3.Count == null) {
            uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar4,0);
          }
          iVar2 = Int32.Parse(*(uint64 *)(lVar3 + 32),0);
          if (this.saveSlot == null) throw; // [null/range check failed]
          lVar3 = GameObject.get_transform(this.saveSlot,0);
          uVar4 = Int32.ToString(local_res10,0);
          if (((lVar3 == null) || (lVar3 = Transform.Find(lVar3,uVar4,0)) == null) ||
             (lVar3 = Transform.Find(lVar3,"Season",0)) == null) throw; // [null/range check failed]
          lVar9 = Component.GetComponent(lVar3,DAT_181d94460);
          lVar3 = this.seasonSprite;
          iVar2 = Mathf.CeilToInt((float)iVar2 / 3.0,0);
          if (lVar3 == null) throw; // [null/range check failed]
          if (lVar3.Count <= iVar2 - 1U) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          if (lVar9 == null) throw; // [null/range check failed]
          Image.set_sprite(lVar9,*(uint64 *)
                                   (lVar3._items + 32 + (int64)(int)(iVar2 - 1U) * 8),
                            0);
          if (this.saveSlot == null) throw; // [null/range check failed]
          lVar3 = GameObject.get_transform(this.saveSlot,0);
          uVar4 = Int32.ToString(local_res10,0);
          if ((lVar3 == null) || (lVar3 = Transform.Find(lVar3,uVar4,0)) == null) throw; // [null/range check failed]
          lVar3 = Transform.Find(lVar3,"Delete",0);
          puVar6 = (uint64 *)Vector3.get_one(&local_28,0);
        }
        if (lVar3 != null) {
          local_30 = *(uint32 *)(puVar6 + 1);
          local_38 = *puVar6;
          Transform.set_localScale(lVar3,&local_38,0);
          return;
        }
    }

    // Token : 0x60020CF
    // RVA   : 0x97A010   Offset: 0x979410   Length: 0x889
    public void ShowLoadMenu(SaveLoadType _saveLoadType)
    {
        int iVar1;
        long lVar2;
        ulong uVar3;
        ulong uVar7;
        int iVar8;
        int[] local_res20 = new int[2];
        ulong local_88;
        ulong uStack_80;
        uint local_70;
        byte[] local_68 = new byte[64];
        iVar8 = 0;
        local_70 = 0;
        if (this.saveLoadMenu != null) {
          GameObject.SetActive(this.saveLoadMenu,1,0);
          if (this.saveLoadMenu != null) {
            lVar2 = GameObject.get_transform(this.saveLoadMenu,0);
            if (lVar2 != null) {
              lVar2 = Transform.Find(lVar2,"SaveLoadRoot",0);
              if (lVar2 != null) {
                lVar2 = Transform.Find(lVar2,"SaveSlot",0);
                if (lVar2 != null) {
                  uVar3 = Component.get_gameObject(lVar2,0);
                  this.saveSlot = uVar3;
                  this.showing = 1;
                  if (this.saveLoadMenu != null) {
                    lVar2 = GameObject.get_transform(this.saveLoadMenu,0);
                    if (lVar2 != null) {
                      lVar2 = Transform.Find(lVar2,"BlackBackground",0);
                      if (lVar2 != null) {
                        plVar4 = (int64 *)Component.GetComponent(lVar2,DAT_181d94460);
                        if (this.saveLoadMenu != null) {
                          lVar2 = GameObject.get_transform(this.saveLoadMenu,0);
                          if (lVar2 != null) {
                            lVar2 = Transform.Find(lVar2,"BlackBackground",0);
                            if (lVar2 != null) {
                              plVar5 = (int64 *)Component.GetComponent(lVar2,DAT_181d94460);
                              if (plVar5 != (int64 *)0) {
                                puVar6 = (uint64 *)
                                         (**(code **)(*plVar5 + 0x298))
                                                   (&local_88,plVar5,*(uint64 *)(*plVar5 + 0x2a0));
                                local_88 = *puVar6;
                                uStack_80 = puVar6[1];
                                puVar6 = (uint64 *)GlobalData.SetColorAlpha(local_68,&local_88,0,0);
                                if (plVar4 != (int64 *)0) {
                                  local_88 = *puVar6;
                                  uStack_80 = puVar6[1];
                                  (**(code **)(*plVar4 + 0x2a8))
                                            (plVar4,&local_88,*(uint64 *)(*plVar4 + 0x2b0));
                                  if (this.saveLoadMenu != null) {
                                    lVar2 = GameObject.get_transform(this.saveLoadMenu,0);
                                    if (lVar2 != null) {
                                      lVar2 = Transform.Find(lVar2,"BlackBackground",0);
                                      if (lVar2 != null) {
                                        uVar3 = Component.GetComponent(lVar2,DAT_181d94460);
                                        uVar3 = DOTweenModuleUI.DOFade(uVar3);
                                        TweenSettingsExtensions.SetUpdate(uVar3,1,DAT_181dc1c20);
                                        if (this.saveLoadMenu != null) {
                                          lVar2 = GameObject.get_transform
                                                            (this.saveLoadMenu,0);
                                          if (lVar2 != null) {
                                            lVar2 = Transform.Find(lVar2,"SaveLoadRoot",0);
                                            if (lVar2 != null) {
                                              local_88 = 0x3f80000000000000;
                                              uStack_80 = CONCAT44(uStack_80._4_4_,0x3f800000);
                                              Transform.set_localScale(lVar2,&local_88,0);
                                              if (this.saveLoadMenu != null) {
                                                lVar2 = GameObject.get_transform
                                                                  (this.saveLoadMenu,0);
                                                if (lVar2 != null) {
                                                  uVar3 = Transform.Find(lVar2,"SaveLoadRoot",0);
                                                  uVar3 = ShortcutExtensions.DOScale(uVar3);
                                                  TweenSettingsExtensions.SetUpdate
                                                            (uVar3,1,DAT_181dc1db0);
                                                  local_res20[0] = 0;
                                                  while( true ) {
                                                    iVar1 = local_res20[0];
                                                    if (**(int **)(DAT_181d9ecf0 + 184) <= iVar1) break;
                                                    if (this.saveSlot == null)
                                                    throw; // [null/range check failed]
                                                    lVar2 = GameObject.get_transform
                                                                      (this.saveSlot,0);
                                                    uVar3 = Int32.ToString(local_res20,0);
                                                    if (lVar2 == null) throw; // [null/range check failed]
                                                    uVar3 = Transform.Find(lVar2,uVar3,0);
                                                    DOTween.Kill(uVar3,0,0);
                                                    if (this.saveSlot == null)
                                                    throw; // [null/range check failed]
                                                    lVar2 = GameObject.get_transform
                                                                      (this.saveSlot,0);
                                                    uVar3 = Int32.ToString(local_res20,0);
                                                    if (lVar2 == null) throw; // [null/range check failed]
                                                    lVar2 = Transform.Find(lVar2,uVar3,0);
                                                    if (lVar2 == null) throw; // [null/range check failed]
                                                    local_88 = 0x3f800000;
                                                    uStack_80 = CONCAT44(uStack_80._4_4_,0x3f800000);
                                                    Transform.set_localScale(lVar2,&local_88,0);
                                                    iVar1 = local_res20[0];
                                                    lVar2 = this.saveSlot;
                                                    if (iVar1 == **(int **)(DAT_181d9ecf0 + 184) + -1) {
                                                      if (lVar2 == null) throw; // [null/range check failed]
                                                      lVar2 = GameObject.get_transform(lVar2,0);
                                                      uVar3 = Int32.ToString(local_res20,0);
                                                      if (lVar2 == null) throw; // [null/range check failed]
                                                      uVar3 = Transform.Find(lVar2,uVar3,0);
                                                      uVar3 = ShortcutExtensions.DOScale(uVar3);
                                                      uVar3 = TweenSettingsExtensions.SetDelay
                                                                        (uVar3,(float)local_res20[0] *
                                                                               0.03 + 0.1,DAT_181dc0c60);
                                                      uVar7 = new OnTooltipCB(this,DAT_181da4260);
                                                      TweenSettingsExtensions.OnComplete(uVar3);
                                                      local_res20[0] = local_res20[0] + 1;
                                                    }
                                                    else {
                                                      if (lVar2 == null) throw; // [null/range check failed]
                                                      lVar2 = GameObject.get_transform(lVar2,0);
                                                      uVar3 = Int32.ToString(local_res20,0);
                                                      if (lVar2 == null) throw; // [null/range check failed]
                                                      uVar3 = Transform.Find(lVar2,uVar3,0);
                                                      uVar3 = ShortcutExtensions.DOScale(uVar3);
                                                      TweenSettingsExtensions.SetDelay
                                                                (uVar3,(float)local_res20[0] * 0.03 + 0.1)
                                                      ;
                                                      local_res20[0] = local_res20[0] + 1;
                                                    }
                                                  }
                                                  this.saveLoadType = _saveLoadType;
                                                  if (this.saveLoadMenu != null) {
                                                    lVar2 = GameObject.get_transform
                                                                      (this.saveLoadMenu,0);
                                                    if (lVar2 != null) {
                                                      lVar2 = Transform.Find(lVar2,"SaveLoadRoot",0);
                                                      if (lVar2 != null) {
                                                        lVar2 = Transform.Find(lVar2,"Title",0);
                                                        if (lVar2 != null) {
                                                          uVar7 = Component.GetComponent
                                                                            (lVar2,DAT_181d96160);
                                                          uVar3 = "读取";
                                                          if (this.saveLoadType == null) {
                                                            uVar3 = "存档";
                                                          }
                                                          LTLocalization.SetText(uVar7,uVar3,0);
                                                          while( true ) {
                                                            if (**(int **)(DAT_181d9ecf0 + 184) <= iVar8)
                                                            break;
                                                            SaveLoadMenuController.RefreshSlot
                                                                      (this,iVar8,0);
                                                            iVar8 = iVar8 + 1;
                                                          }
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

    // Token : 0x60020D0
    // RVA   : 0x97AB60   Offset: 0x979F60   Length: 0x224
    public void UnshowLoadMenu()
    {
        long lVar2;
        ulong uVar3;
        ulong uVar4;
        uint local_18;
        uint local_14;
        uint local_10;
        this.showing = 1;
        plVar1 = (int64 *)Resources.Load("Sound/SoundEffect/PaperQuick",0);
        plVar5 = (int64 *)0;
        if ((plVar1 != (int64 *)0) && (*plVar1 == DAT_181daf348)) {
          plVar5 = plVar1;
        }
        NGUITools.PlaySound(plVar5,0);
        if (this.saveLoadMenu != null) {
          lVar2 = GameObject.get_transform(this.saveLoadMenu,0);
          if (lVar2 != null) {
            lVar2 = Transform.Find(lVar2,"BlackBackground",0);
            if (lVar2 != null) {
              uVar3 = Component.GetComponent(lVar2,DAT_181d94460);
              uVar3 = DOTweenModuleUI.DOFade(uVar3,0,0x3e4ccccd,0);
              TweenSettingsExtensions.SetUpdate(uVar3,1,DAT_181dc1c20);
              if (this.saveLoadMenu != null) {
                lVar2 = GameObject.get_transform(this.saveLoadMenu,0);
                if (lVar2 != null) {
                  uVar3 = Transform.Find(lVar2,"SaveLoadRoot",0);
                  local_18 = 0;
                  local_14 = 0x3f800000;
                  local_10 = 0x3f800000;
                  uVar3 = ShortcutExtensions.DOScale(uVar3,&local_18,0x3e4ccccd,0);
                  uVar3 = TweenSettingsExtensions.SetUpdate(uVar3,1,DAT_181dc1db0);
                  uVar4 = new OnTooltipCB(this,DAT_181da42e0,0);
                  TweenSettingsExtensions.OnComplete(uVar3,uVar4,DAT_181dc01d0);
                  return;
                }
              }
            }
          }
        }
    }

    // Token : 0x60020D1
    // RVA   : 0x979BB0   Offset: 0x978FB0   Length: 0x45A
    public void SaveSlotButtonClicked(int saveID)
    {
        var pStatics = *(int64*)(DAT_181d72dd8 + 184);
        int iVar1;
        bool cVar2;
        uint uVar3;
        long lVar5;
        ulong uVar6;
        long lVar7;
        ulong uVar8;
        uint uVar9;
        long lVar11;
        int[] local_res10 = new int[2];
        local_res10[0] = saveID;
        iVar1 = local_res10[0];
        if (!this.showing) {
          if (this.saveLoadType == null) {
            if (local_res10[0] == 0) {
              plVar4 = (int64 *)Resources.Load("Sound/SoundEffect/WrongClick",0);
              plVar10 = (int64 *)0;
              if ((plVar4 != (int64 *)0) && (*plVar4 == DAT_181daf348)) {
                plVar10 = plVar4;
              }
              NGUITools.PlaySound(plVar10,0);
              return;
            }
            lVar5 = FUN_18046c100(0);
            if (lVar5 != null) {
              cVar2 = GameDataController.HaveSave(lVar5,local_res10[0],0);
              if (!cVar2) {
                uVar6 = Int32.ToString(local_res10,0);
                uVar3 = Int32.Parse(uVar6,0);
                lVar5 = *(int64 *)(*(int64 *)(DAT_181d72d50 + 184) + 32);
                if (lVar5 != null) {
                  GameDataController.Save(lVar5,uVar3,0);
                  SaveLoadMenuController.UnshowLoadMenu(this,0);
                  if (*pStatics != 0) {
                    GameMenuController.UnshowGameMenu(*pStatics,0);
                    return;
                  }
                }
              }
              else {
                lVar5 = FUN_18046c100(0);
                if (lVar5 != null) {
                  lVar5 = GameDataController.GetSaveInfo(lVar5,local_res10[0],0);
                  if (lVar5 != null) {
                    lVar5 = *(int64 *)(lVar5 + 24);
                    lVar7 = FUN_1800d60b0(DAT_181da1040,1);
                    if (lVar7 != null) {
                      if (*(int *)(lVar7 + 24) == 0) {
                        uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                        FUN_1800d65f0(uVar6,0);
                      }
                      *(uint16 *)(lVar7 + 32) = 10;
                      if (lVar5 != null) {
                        uVar6 = String.Split(lVar5,lVar7,0);
                        uVar8 = il2cpp_internal(DAT_181d97750);
                        FUN_181827480(uVar8,uVar6,DAT_181da3c58);
                        lVar5 = GlobalData.RemoveEmptyString(uVar8,0);
                        lVar7 = FUN_180778ae0(0);
                        if (lVar5 != null) {
                          uVar9 = *(uint32 *)(lVar5 + 24);
                          if (uVar9 == 0) {
                            ThrowHelper.ThrowArgumentOutOfRangeException(0);
                            uVar9 = *(uint32 *)(lVar5 + 24);
                          }
                          lVar11 = *(int64 *)(lVar5 + 16);
                          uVar6 = *(uint64 *)(lVar11 + 32);
                          if (uVar9 < 2) {
                            ThrowHelper.ThrowArgumentOutOfRangeException(0);
                            lVar11 = *(int64 *)(lVar5 + 16);
                          }
                          uVar6 = String.Format("确认要覆盖该存档吗？\n(覆盖对象 <b>{0} {1}</b>)\n<color=red>(存档一经覆盖无法恢复，请谨慎选择)</color>",uVar6,*(uint64 *)(lVar11 + 40),0);
                          uVar8 = Int32.ToString(local_res10,0);
                          if (lVar7 != null) {
                            SureMenu.CallSureMenu(lVar7,uVar6,"SureSave",uVar8,"SaveLoadMenu",0);
                            return;
                          }
                        }
                      }
                    }
                  }
                }
              }
            }
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          if (this.saveLoadType == 1) {
            SaveLoadMenuController.LoadGame(iVar1,0);
          }
        }
    }

    // Token : 0x60020D2
    // RVA   : 0x97AA00   Offset: 0x979E00   Length: 0x110
    public void SureSave(string param)
    {
        var pStatics = *(int64*)(DAT_181d72dd8 + 184);
        long lVar1;
        uint uVar2;
        uVar2 = Int32.Parse(param,0);
        lVar1 = *(int64 *)(*(int64 *)(DAT_181d72d50 + 184) + 32);
        if (lVar1 != null) {
          GameDataController.Save(lVar1,uVar2,0);
          SaveLoadMenuController.UnshowLoadMenu(this,0);
          if (*pStatics != 0) {
            GameMenuController.UnshowGameMenu(*pStatics,0);
            return;
          }
        }
    }

    // Token : 0x60020D3
    // RVA   : 0x9787A0   Offset: 0x977BA0   Length: 0x107
    public string GetRecentSaveSlotDescribe()
    {
        int iVar1;
        long lVar2;
        ulong uVar3;
        iVar1 = SaveLoadMenuController.GetRecentSaveSlotID(this,0);
        if (iVar1 == -1) {
          return "";
        }
        lVar2 = *(int64 *)(*(int64 *)(DAT_181d72d50 + 184) + 32);
        if (lVar2 != null) {
          lVar2 = GameDataController.GetSaveInfo(lVar2,iVar1,0);
          if (lVar2 != null) {
            uVar3 = String.Concat(*(uint64 *)(lVar2 + 24),"\n",
                                   *(uint64 *)(lVar2 + 32),0);
            return uVar3;
          }
        }
    }

    // Token : 0x60020D4
    // RVA   : 0x9788B0   Offset: 0x977CB0   Length: 0x1AF
    public int GetRecentSaveSlotID()
    {
        bool cVar1;
        long lVar2;
        ulong uVar3;
        int iVar4;
        int iVar5;
        ulong uVar6;
        iVar4 = -1;
        iVar5 = 0;
        uVar6 = *(uint64 *)(*(int64 *)(DAT_181dbf3c0 + 184) + 16);
        do {
          if (**(int **)(DAT_181d9ecf0 + 184) <= iVar5) {
            return iVar4;
          }
          lVar2 = FUN_18046c100(0);
          if (lVar2 == null) goto LAB_180978a5a;
          cVar1 = GameDataController.HaveSave(lVar2,iVar5,0);
          if (cVar1) {
            lVar2 = FUN_18046c100(0);
            if (lVar2 == null) {
        LAB_180978a5a:
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            lVar2 = GameDataController.GetSaveInfo(lVar2,iVar5);
            if (lVar2 == null) goto LAB_180978a5a;
            uVar3 = *(uint64 *)(lVar2 + 32);
            uVar3 = DateTime.Parse(uVar3,0);
            cVar1 = DateTime.op_GreaterThan(uVar3,uVar6);
            if (cVar1) {
              uVar6 = uVar3;
              iVar4 = iVar5;
            }
          }
          iVar5 = iVar5 + 1;
        } while( true );
    }

    // Token : 0x60020D5
    // RVA   : 0x978D20   Offset: 0x978120   Length: 0x5D
    public void LoadRecentGame()
    {
        uint uVar1;
        uVar1 = SaveLoadMenuController.GetRecentSaveSlotID(this,0);
        SaveLoadMenuController.LoadGame(uVar1,0);
    }

    // Token : 0x60020D6
    // RVA   : 0x978A60   Offset: 0x977E60   Length: 0x2BE
    public static void LoadGame(int saveID)
    {
        var pStatics = *(int64*)(DAT_181da6790 + 184);
        bool cVar1;
        long lVar3;
        ulong uVar4;
        uint[] local_res8 = new uint[8];
        local_res8[0] = saveID;
        lVar3 = *(int64 *)(*(int64 *)(DAT_181d72d50 + 184) + 32);
        if (lVar3 != null) {
          cVar1 = GameDataController.HaveSave(lVar3,local_res8[0],0);
          if (!cVar1) {
            plVar2 = (int64 *)Resources.Load("Sound/SoundEffect/WrongClick",0);
            plVar5 = (int64 *)0;
            if ((plVar2 != (int64 *)0) && (*plVar2 == DAT_181daf348)) {
              plVar5 = plVar2;
            }
            NGUITools.PlaySound(plVar5,0);
            return;
          }
          lVar3 = new GameObject(0);
          uVar4 = Int32.ToString(local_res8,0);
          if (lVar3 != null) {
            Object.set_name(lVar3,uVar4,0);
            GameObject.set_tag(lVar3,"LoadSaveIDTag",0);
            Object.DontDestroyOnLoad(lVar3,0);
            cVar1 = Object.op_Inequality(**(uint64 **)(DAT_181da6790 + 184),0,0);
            if (cVar1) {
              if (*pStatics == 0) throw; // [null/range check failed]
              uVar4 = Component.get_gameObject(*pStatics,0);
              Object.Destroy(uVar4,0);
            }
            SceneManager.LoadScene("LoadScene",0);
            return;
          }
        }
    }

    // Token : 0x60020D7
    // RVA   : 0x978670   Offset: 0x977A70   Length: 0x123
    public void DeleteButtonClicked(int saveID)
    {
        long lVar1;
        ulong uVar3;
        uint[] local_res10 = new uint[6];
        local_res10[0] = saveID;
        plVar2 = (int64 *)Resources.Load("Sound/SoundEffect/PaperQuick",0);
        plVar4 = (int64 *)0;
        if ((plVar2 != (int64 *)0) && (*plVar2 == DAT_181daf348)) {
          plVar4 = plVar2;
        }
        NGUITools.PlaySound(plVar4,0);
        lVar1 = **(int64 **)(DAT_181da8710 + 184);
        uVar3 = Int32.ToString(local_res10,0);
        if (lVar1 != null) {
          SureMenu.CallSureMenu(lVar1,"确认要删除该存档吗？\n<color=red>(存档一经删除无法恢复，请谨慎选择)</color>","SureDeleteSave",uVar3,"SaveLoadMenu",0);
          return;
        }
    }

    // Token : 0x60020D8
    // RVA   : 0x97A8A0   Offset: 0x979CA0   Length: 0x153
    public void SureDeleteSave(string param)
    {
        long lVar1;
        uint uVar2;
        plVar3 = (int64 *)Resources.Load("Sound/SoundEffect/Med",0);
        plVar4 = (int64 *)0;
        if ((plVar3 != (int64 *)0) && (*plVar3 == DAT_181daf348)) {
          plVar4 = plVar3;
        }
        NGUITools.PlaySound(plVar4,0);
        uVar2 = Int32.Parse(param,0);
        lVar1 = *(int64 *)(*(int64 *)(DAT_181d72d50 + 184) + 32);
        if (lVar1 != null) {
          GameDataController.DeleteSave(lVar1,uVar2,0);
          SaveLoadMenuController.RefreshSlot(this,uVar2,0);
          return;
        }
    }

    // Token : 0x60020D9
    // RVA   : 0x3A17B0   Offset: 0x3A0BB0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_18044ef50(this,0);
    }

    // Token : 0x60020DA
    // RVA   : 0x97AD90   Offset: 0x97A190   Length: 0x39
    private static void /*cctor*/()
    {
        **(uint32 **)(DAT_181d9ecf0 + 184) = 11;
    }

    // Token : 0x60020DB
    // RVA   : 0x97AB20   Offset: 0x979F20   Length: 0x5
    private void <ShowLoadMenu>b__11_0()
    {
        void FUN_18097ab20(int64 this)
        {
        this.showing = 0;
    }

    // Token : 0x60020DC
    // RVA   : 0x97AB30   Offset: 0x979F30   Length: 0x2B
    private void <UnshowLoadMenu>b__12_0()
    {
        if (this.saveLoadMenu != null) {
          GameObject.SetActive(this.saveLoadMenu,0,0);
          this.showing = 0;
          return;
        }
    }

}
