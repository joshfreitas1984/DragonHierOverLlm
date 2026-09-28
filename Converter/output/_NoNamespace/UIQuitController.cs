// ============================================================
// Type  : UIQuitController
// Token : 0x20003AD
// ============================================================

public class UIQuitController
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001DD4
    public List<UIQuitTarget> QuitTargets;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6002365
    // RVA   : 0x16FCAB0   Offset: 0x16FBEB0   Length: 0x77
    private void Update()
    {
        var pStatics = *(int64*)(DAT_181dbb428 + 184);
        bool cVar1;
        cVar1 = FUN_1804625b0(27);
        if (!cVar1) {
          cVar1 = Input.GetMouseButtonDown(1);
          if (cVar1) {
            if (*pStatics == 0) {
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            if (*(int *)(*pStatics + 24) != 0)
            {
              }
              return;
              }
            }
        UIQuitController.OnExcapeButtonClicked(this,0);
    }

    // Token : 0x6002366
    // RVA   : 0x16FC6A0   Offset: 0x16FBAA0   Length: 0x40B
    public void OnExcapeButtonClicked()
    {
        var pStatics_2dd8 = *(int64*)(DAT_181d72dd8 + 184);
        bool cVar1;
        int iVar2;
        long lVar3;
        uint uVar5;
        ulong uVar6;
        long lVar8;
        lVar3 = this.QuitTargets;
        plVar7 = (int64 *)0;
        if (lVar3 != null) {
          lVar8 = 32;
          plVar4 = plVar7;
          while (uVar5 = (uint32)plVar4, (int)uVar5 < lVar3.Count) {
            if (lVar3 == null) throw; // [null/range check failed]
            if (lVar3.Count <= uVar5) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            lVar3 = *(int64 *)(lVar8 + lVar3._items);
            if (lVar3 == null) throw; // [null/range check failed]
            uVar6 = lVar3._items;
            cVar1 = Object.op_Inequality(uVar6,0);
            if (cVar1) {
              if (((this.QuitTargets == null) || (lVar3 = FUN_180002f80()) == null) ||
                 (lVar3._items == null)) throw; // [null/range check failed]
              cVar1 = GameObject.get_activeInHierarchy();
              if (cVar1) {
                if ((this.QuitTargets != null) &&
                   (lVar3 = FUN_180002f80(this.QuitTargets,plVar4,DAT_181daa418)) != null
                   ) {
                  if (lVar3.Count == null) {
                    return;
                  }
                  if (((this.QuitTargets != null) &&
                      (lVar3 = FUN_180002f80(this.QuitTargets,plVar4,DAT_181daa418),
                      lVar3 != null)) && (lVar3.Count != null)) {
                    iVar2 = UnityEventBase.GetPersistentEventCount(lVar3.Count,0);
                    if (iVar2 < 1) {
                      return;
                    }
                    if (((this.QuitTargets != null) &&
                        (lVar3 = FUN_180002f80(this.QuitTargets,plVar4,DAT_181daa418),
                        lVar3 != null)) && (lVar3.Count != null)) {
                      UnityEvent.Invoke(lVar3.Count,0);
                      uVar6 = "Sound/SoundEffect/Woosh";
                      goto LAB_1816fc9ea;
                    }
                  }
                }
                throw; // [null/range check failed]
              }
            }
            lVar3 = this.QuitTargets;
            plVar4 = (int64 *)(uint64)(uVar5 + 1);
            lVar8 = lVar8 + 8;
            if (lVar3 == null) throw; // [null/range check failed]
          }
          uVar6 = **(uint64 **)(DAT_181d72cc8 + 184);
          cVar1 = Object.op_Inequality(uVar6,0,0);
          if (!cVar1) {
            return;
          }
          if (GameController._instance != null) {
            cVar1 = GameController.CanSaveLoad(GameController._instance,1,0);
            uVar6 = "Sound/SoundEffect/WrongClick";
            if (!cVar1) {
        LAB_1816fc9ea:
              plVar4 = (int64 *)Resources.Load(uVar6,0);
              if ((plVar4 != (int64 *)0) && (*plVar4 == DAT_181daf348)) {
                plVar7 = plVar4;
              }
              NGUITools.PlaySound(plVar7,0);
              return;
            }
            if ((*pStatics_2dd8 != 0) &&
               (lVar3 = *(int64 *)(*pStatics_2dd8 + 24)) != null) {
              cVar1 = GameObject.get_activeSelf(lVar3,0);
              if (cVar1) {
                return;
              }
              lVar3 = FUN_18046c160(0);
              if (lVar3 != null) {
                GameMenuController.ShowGameMenu(lVar3,0);
                return;
              }
            }
          }
        }
    }

    // Token : 0x6002367
    // RVA   : 0x3A17B0   Offset: 0x3A0BB0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_18044ef50(this,0);
    }

}
