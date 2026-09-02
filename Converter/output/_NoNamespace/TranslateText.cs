// ============================================================
// Type  : TranslateText
// Token : 0x200039F
// ============================================================

public class TranslateText
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001CAC
    private string keyText;

    // Token: 0x4001CAD
    private List<string> dropdownKeyText;

    // Token: 0x4001CAE
    private bool inited;

    // Token: 0x4001CAF
    private string nowLanguage;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6002293
    // RVA   : 0xA658E0   Offset: 0xA640E0   Length: 0x254
    private void Start()
    {
        bool cVar1;
        ulong uVar2;
        long lVar4;
        long lVar5;
        uint uVar6;
        long lVar7;
        uVar2 = Component.GetComponent(this,DAT_181d6d8c0);
        cVar1 = Object.op_Inequality(uVar2,0,0);
        if (cVar1) {
          plVar3 = (int64 *)Component.GetComponent(this,DAT_181d6d8c0);
          if (plVar3 == (int64 *)0) throw; // [null/range check failed]
          uVar2 = (**(code **)(*plVar3 + 0x5d8))(plVar3,*(uint64 *)(*plVar3 + 0x5e0));
          this.keyText = uVar2;
        }
        uVar2 = Component.GetComponent(this,DAT_181d6b540);
        cVar1 = Object.op_Inequality(uVar2,0,0);
        if (!cVar1) {
          return;
        }
        uVar2 = il2cpp_internal(DAT_181d72a30);
        FUN_180f58a90(uVar2,DAT_181d7c250);
        this.dropdownKeyText = uVar2;
        uVar6 = 0;
        lVar4 = Component.GetComponent(this,DAT_181d6b540);
        if (lVar4 != null) {
          lVar7 = 32;
          while (lVar4 = Dropdown.get_options(lVar4,0)) != null {
            if (lVar4.Count <= (int)uVar6) {
              return;
            }
            lVar4 = this.dropdownKeyText;
            lVar5 = Component.GetComponent(this,DAT_181d6b540);
            if ((lVar5 == null) || (lVar5 = Dropdown.get_options(lVar5,0)) == null) break;
            if (*(uint32 *)(lVar5 + 24) <= uVar6) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            lVar5 = *(int64 *)(lVar7 + *(int64 *)(lVar5 + 16));
            if ((lVar5 == null) || (lVar4 == null)) break;
            FUN_181827900(lVar4,*(uint64 *)(lVar5 + 16),DAT_181d7c3d0);
            uVar6 = uVar6 + 1;
            lVar7 = lVar7 + 8;
            lVar4 = Component.GetComponent(this);
            if (lVar4 == null) break;
          }
        }
    }

    // Token : 0x6002294
    // RVA   : 0xA65B40   Offset: 0xA64340   Length: 0x1A9
    private void Update()
    {
        var pStatics = *(int64*)(DAT_181d4e010 + 184);
        long lVar1;
        bool cVar2;
        ulong uVar3;
        ulong uVar4;
        uint[] local_res18 = new uint[4];
        local_res18[0] = SceneManager.GetActiveScene(0);
        uVar3 = Scene.get_name(local_res18,0);
        cVar2 = String.op_Inequality(uVar3,"TitleScene",0);
        if (!cVar2) {
          uVar3 = this.nowLanguage;
          lVar1 = *(int64 *)(pStatics + 8);
          if ((lVar1 == null) || (lVar1 = *(int64 *)(lVar1 + 16)) == null) {
        LAB_180a65ce4:
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          uVar4 = PlayerPrefDictionary.GetString(lVar1,"Language",0);
          cVar2 = String.op_Inequality(uVar3,uVar4,0);
          if (cVar2) {
            lVar1 = *(int64 *)(pStatics + 8);
            if ((lVar1 == null) || (lVar1 = *(int64 *)(lVar1 + 16)) == null) goto LAB_180a65ce4;
            uVar3 = PlayerPrefDictionary.GetString(lVar1,"Language",0);
            this.nowLanguage = uVar3;
            TranslateText.AutoTranslateText(this,0);
          }
        }
        else if (!this.inited) {
          this.inited = 1;
          TranslateText.AutoTranslateText(this,0);
          return;
        }
    }

    // Token : 0x6002295
    // RVA   : 0xA656C0   Offset: 0xA63EC0   Length: 0x21C
    private void AutoTranslateText()
    {
        long lVar2;
        bool cVar3;
        ulong uVar4;
        long lVar5;
        uint uVar6;
        long lVar7;
        uVar4 = Component.GetComponent(this,DAT_181d6d8c0);
        cVar3 = Object.op_Inequality(uVar4,0,0);
        if (cVar3) {
          uVar4 = Component.GetComponent(this,DAT_181d6d8c0);
          LTLocalization.SetText(uVar4,this.keyText,0);
        }
        uVar4 = Component.GetComponent(this,DAT_181d6b540);
        cVar3 = Object.op_Inequality(uVar4,0,0);
        if (!cVar3) {
          return;
        }
        uVar6 = 0;
        lVar5 = Component.GetComponent(this,DAT_181d6b540);
        if (lVar5 != null) {
          lVar7 = 32;
          while (lVar5 = Dropdown.get_options(lVar5,0)) != null {
            if (*(int *)(lVar5 + 24) <= (int)uVar6) {
              return;
            }
            lVar5 = Component.GetComponent(this,DAT_181d6b540);
            if ((lVar5 == null) || (lVar5 = Dropdown.get_options(lVar5,0)) == null) break;
            if (*(uint32 *)(lVar5 + 24) <= uVar6) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            lVar2 = this.dropdownKeyText;
            lVar5 = *(int64 *)(lVar7 + *(int64 *)(lVar5 + 16));
            if (lVar2 == null) break;
            if (lVar2.Count <= uVar6) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            uVar4 = LTLocalization.GetText(*(uint64 *)(lVar7 + lVar2._items),0,1,0);
            if (lVar5 == null) break;
            puVar1 = (uint64 *)(lVar5 + 16);
            *puVar1 = uVar4;
            il2cpp_internal(puVar1,uVar4);
            uVar6 = uVar6 + 1;
            lVar7 = lVar7 + 8;
            lVar5 = Component.GetComponent(this);
            if (lVar5 == null) break;
          }
        }
    }

    // Token : 0x6002296
    // RVA   : 0x3A17B0   Offset: 0x39FFB0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_18044ef50(this,0);
    }

}
