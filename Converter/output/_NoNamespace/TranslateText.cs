// ============================================================
// Type  : TranslateText
// Token : 0x20003B3
// ============================================================

public class TranslateText
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001E44
    private string keyText;

    // Token: 0x4001E45
    private List<string> dropdownKeyText;

    // Token: 0x4001E46
    private bool inited;

    // Token: 0x4001E47
    private int nowLanguageVersion;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60023BF
    // RVA   : 0x834670   Offset: 0x833470   Length: 0x254
    private void Start()
    {
        bool cVar1;
        ulong uVar2;
        long lVar4;
        long lVar5;
        uint uVar6;
        long lVar7;
        uVar2 = Component.GetComponent(this,DAT_181e79538);
        cVar1 = Object.op_Inequality(uVar2,0,0);
        if (cVar1) {
          plVar3 = (int64 *)Component.GetComponent(this,DAT_181e79538);
          if (plVar3 == (int64 *)0) throw; // [null/range check failed]
          uVar2 = (**(code **)(*plVar3 + 0x5d8))(plVar3,*(uint64 *)(*plVar3 + 0x5e0));
          this.keyText = uVar2;
        }
        uVar2 = Component.GetComponent(this,DAT_181e770b8);
        cVar1 = Object.op_Inequality(uVar2,0,0);
        if (!cVar1) {
          return;
        }
        uVar2 = il2cpp_internal(DAT_181e77728);
        FUN_1810f3480(uVar2,DAT_181e861f0);
        this.dropdownKeyText = uVar2;
        uVar6 = 0;
        lVar4 = Component.GetComponent(this,DAT_181e770b8);
        if (lVar4 != null) {
          lVar7 = 32;
          while (lVar4 = Dropdown.get_options(lVar4,0)) != null {
            if (lVar4.Count <= (int)uVar6) {
              return;
            }
            lVar4 = this.dropdownKeyText;
            lVar5 = Component.GetComponent(this,DAT_181e770b8);
            if ((lVar5 == null) || (lVar5 = Dropdown.get_options(lVar5,0)) == null) break;
            if (*(uint32 *)(lVar5 + 24) <= uVar6) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            lVar5 = *(int64 *)(lVar7 + *(int64 *)(lVar5 + 16));
            if ((lVar5 == null) || (lVar4 == null)) break;
            FUN_18175de30(lVar4,*(uint64 *)(lVar5 + 16),DAT_181e86370);
            uVar6 = uVar6 + 1;
            lVar7 = lVar7 + 8;
            lVar4 = Component.GetComponent(this);
            if (lVar4 == null) break;
          }
        }
    }

    // Token : 0x60023C0
    // RVA   : 0x8348D0   Offset: 0x8336D0   Length: 0x1A5
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

    // Token : 0x60023C1
    // RVA   : 0x8343F0   Offset: 0x8331F0   Length: 0x271
    private void AutoTranslateText()
    {
        long lVar2;
        bool cVar3;
        ulong uVar4;
        ulong uVar5;
        long lVar6;
        uint uVar7;
        long lVar8;
        uVar4 = Component.GetComponent(this,DAT_181e79538);
        cVar3 = Object.op_Inequality(uVar4,0,0);
        if (cVar3) {
          uVar5 = Component.GetComponent(this,DAT_181e79538);
          uVar4 = this.keyText;
          LTLocalization.SetText(uVar5,uVar4,0);
        }
        uVar4 = Component.GetComponent(this,DAT_181e770b8);
        cVar3 = Object.op_Inequality(uVar4,0,0);
        if (!cVar3) {
          return;
        }
        uVar7 = 0;
        lVar6 = Component.GetComponent(this,DAT_181e770b8);
        if (lVar6 != null) {
          lVar8 = 32;
          while (lVar6 = Dropdown.get_options(lVar6,0)) != null {
            if (*(int *)(lVar6 + 24) <= (int)uVar7) {
              return;
            }
            lVar6 = Component.GetComponent(this,DAT_181e770b8);
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

    // Token : 0x60023C2
    // RVA   : 0x834A80   Offset: 0x833880   Length: 0xE
    public void /*ctor*/()
    {
        void FUN_180834a80(int64 this)
        {
        this.nowLanguageVersion = 0xffffffff;
        FUN_180ae8740(this,0);
    }

}
