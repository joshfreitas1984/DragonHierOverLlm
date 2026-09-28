// ============================================================
// Type  : TranslateText
// Token : 0x20003A6
// ============================================================

public class TranslateText
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001DB1
    private string keyText;

    // Token: 0x4001DB2
    private List<string> dropdownKeyText;

    // Token: 0x4001DB3
    private bool inited;

    // Token: 0x4001DB4
    private int nowLanguageVersion;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6002315
    // RVA   : 0xADF530   Offset: 0xADE930   Length: 0x254
    private void Start()
    {
        bool cVar1;
        ulong uVar2;
        long lVar4;
        long lVar5;
        uint uVar6;
        long lVar7;
        uVar2 = Component.GetComponent(this,DAT_181d96160);
        cVar1 = Object.op_Inequality(uVar2,0,0);
        if (cVar1) {
          plVar3 = (int64 *)Component.GetComponent(this,DAT_181d96160);
          if (plVar3 == (int64 *)0) throw; // [null/range check failed]
          uVar2 = (**(code **)(*plVar3 + 0x5d8))(plVar3,*(uint64 *)(*plVar3 + 0x5e0));
          this.keyText = uVar2;
        }
        uVar2 = Component.GetComponent(this,DAT_181d93d60);
        cVar1 = Object.op_Inequality(uVar2,0,0);
        if (!cVar1) {
          return;
        }
        uVar2 = il2cpp_internal(DAT_181d97750);
        FUN_18132faf0(uVar2,DAT_181da3bd8);
        this.dropdownKeyText = uVar2;
        uVar6 = 0;
        lVar4 = Component.GetComponent(this,DAT_181d93d60);
        if (lVar4 != null) {
          lVar7 = 32;
          while (lVar4 = Dropdown.get_options(lVar4,0)) != null {
            if (lVar4.Count <= (int)uVar6) {
              return;
            }
            lVar4 = this.dropdownKeyText;
            lVar5 = Component.GetComponent(this,DAT_181d93d60);
            if ((lVar5 == null) || (lVar5 = Dropdown.get_options(lVar5,0)) == null) break;
            if (*(uint32 *)(lVar5 + 24) <= uVar6) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            lVar5 = *(int64 *)(lVar7 + *(int64 *)(lVar5 + 16));
            if ((lVar5 == null) || (lVar4 == null)) break;
            FUN_18181e0a0(lVar4,*(uint64 *)(lVar5 + 16),DAT_181da3d58);
            uVar6 = uVar6 + 1;
            lVar7 = lVar7 + 8;
            lVar4 = Component.GetComponent(this);
            if (lVar4 == null) break;
          }
        }
    }

    // Token : 0x6002316
    // RVA   : 0xADF790   Offset: 0xADEB90   Length: 0x1A5
    private void Update()
    {
        int iVar1;
        bool cVar2;
        ulong uVar3;
        uint[] local_res18 = new uint[4];
        local_res18[0] = SceneManager.GetActiveScene(0);
        uVar3 = Scene.get_name(local_res18,0);
        cVar2 = String.op_Inequality(uVar3,"TitleScene",0);
        if (!cVar2) {
          iVar1 = this.nowLanguageVersion;
          if (iVar1 != LTLocalization.languageVersion) {
            this.nowLanguageVersion = LTLocalization.languageVersion;
            TranslateText.AutoTranslateText(this,0);
            return;
          }
        }
        else if (!this.inited) {
          this.inited = 1;
          TranslateText.AutoTranslateText(this,0);
        }
    }

    // Token : 0x6002317
    // RVA   : 0xADF2B0   Offset: 0xADE6B0   Length: 0x271
    private void AutoTranslateText()
    {
        long lVar2;
        bool cVar3;
        ulong uVar4;
        ulong uVar5;
        long lVar6;
        uint uVar7;
        long lVar8;
        uVar4 = Component.GetComponent(this,DAT_181d96160);
        cVar3 = Object.op_Inequality(uVar4,0,0);
        if (cVar3) {
          uVar5 = Component.GetComponent(this,DAT_181d96160);
          uVar4 = this.keyText;
          LTLocalization.SetText(uVar5,uVar4,0);
        }
        uVar4 = Component.GetComponent(this,DAT_181d93d60);
        cVar3 = Object.op_Inequality(uVar4,0,0);
        if (!cVar3) {
          return;
        }
        uVar7 = 0;
        lVar6 = Component.GetComponent(this,DAT_181d93d60);
        if (lVar6 != null) {
          lVar8 = 32;
          while (lVar6 = Dropdown.get_options(lVar6,0)) != null {
            if (*(int *)(lVar6 + 24) <= (int)uVar7) {
              return;
            }
            lVar6 = Component.GetComponent(this,DAT_181d93d60);
            if ((lVar6 == null) || (lVar6 = Dropdown.get_options(lVar6,0)) == null) break;
            if (*(uint32 *)(lVar6 + 24) <= uVar7) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            lVar2 = this.dropdownKeyText;
            lVar6 = *(int64 *)(lVar8 + *(int64 *)(lVar6 + 16));
            if (lVar2 == null) break;
            if (lVar2.Count <= uVar7) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            uVar4 = *(uint64 *)(lVar8 + lVar2._items);
            uVar4 = LTLocalization.GetText(uVar4,0,1,0);
            if (lVar6 == null) break;
            puVar1 = (uint64 *)(lVar6 + 16);
            *puVar1 = uVar4;
            il2cpp_internal(puVar1,uVar4);
            uVar7 = uVar7 + 1;
            lVar8 = lVar8 + 8;
            lVar6 = Component.GetComponent(this);
            if (lVar6 == null) break;
          }
        }
    }

    // Token : 0x6002318
    // RVA   : 0xADF940   Offset: 0xADED40   Length: 0xE
    public void /*ctor*/()
    {
        void FUN_180adf940(int64 this)
        {
        this.nowLanguageVersion = 0xffffffff;
        FUN_18044ef50(this,0);
    }

}
