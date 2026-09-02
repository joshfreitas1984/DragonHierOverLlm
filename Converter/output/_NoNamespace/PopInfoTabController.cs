// ============================================================
// Type  : PopInfoTabController
// Token : 0x2000322
// ============================================================

public class PopInfoTabController
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x400194B
    public GameObject inkLine;

    // Token: 0x400194C
    public bool rightInfo;

    // Token: 0x400194D
    private bool destroying;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6001F5C
    // RVA   : 0xBD9E90   Offset: 0xBD8690   Length: 0xE6
    public void Start()
    {
        ulong uVar1;
        long lVar2;
        uint local_18;
        uint local_14;
        uint local_10;
        if (this.inkLine != null) {
          uVar1 = GameObject.get_transform(this.inkLine,0);
          if (!this.rightInfo) {
            local_18 = 0x41a00000;
          }
          else {
            local_18 = 0xc1a00000;
          }
          local_14 = 0x3f19999a;
          local_10 = 0x3f800000;
          ShortcutExtensions.DOScale(uVar1,&local_18,0x3ecccccd,0);
          lVar2 = Component.get_transform(this,0);
          if (lVar2 != null) {
            local_18 = 0x3f800000;
            local_14 = 0;
            local_10 = 0x3f800000;
            Transform.set_localScale(lVar2,&local_18,0);
            uVar1 = Component.get_transform(this,0);
            local_18 = 0x3f800000;
            local_14 = 0x3f800000;
            local_10 = 0x3f800000;
            ShortcutExtensions.DOScale(uVar1,&local_18,0x3ecccccd,0);
            return;
          }
        }
    }

    // Token : 0x6001F5D
    // RVA   : 0xBD9C10   Offset: 0xBD8410   Length: 0x278
    public void OnClick()
    {
        long lVar1;
        long lVar2;
        ulong uVar3;
        ulong uVar6;
        float fVar7;
        float fVar8;
        ulong local_58;
        uint local_50;
        byte[] local_48 = new byte[8];
        uint local_40;
        uint local_38;
        uint uStack_34;
        uint uStack_30;
        uint32 uStack_2c;
        if (this.destroying) {
          return;
        }
        this.destroying = 1;
        lVar1 = Component.GetComponent(this,DAT_181d6ca40);
        if (lVar1 != null) {
          *(uint32 *)(lVar1 + 24) = 0xbf800000;
          lVar1 = Component.get_transform(this,0);
          lVar2 = Component.get_transform(this,0);
          if (((lVar2 != null) && (lVar2 = FUN_180da0f00(lVar2,0)) != null) &&
             (uVar3 = FUN_180da0f00(lVar2,0), lVar1 != null)) {
            FUN_180da1d00(lVar1,uVar3,0);
            uVar3 = Component.get_transform(this,0);
            lVar1 = Component.get_transform(this,0);
            if (((lVar1 != null) && (lVar1 = Transform.Find(lVar1,"Back",0)) != null) &&
               (lVar1 = Component.GetComponent(lVar1,DAT_181d6c740)) != null) {
              puVar4 = (uint32 *)RectTransform.get_rect(local_48,lVar1,0);
              local_38 = *puVar4;
              uStack_34 = puVar4[1];
              uStack_30 = puVar4[2];
              uStack_2c = puVar4[3];
              fVar7 = (float)FUN_180d90480(&local_38,0);
              if (!this.rightInfo) {
                fVar8 = 1.0;
              }
              else {
                fVar8 = -1.0;
              }
              lVar1 = Component.get_transform(this,0);
              if (lVar1 != null) {
                puVar5 = (uint64 *)Transform.get_localPosition(local_48,lVar1,0);
                local_40 = 0;
                local_58 = CONCAT44((int)((uint64)*puVar5 >> 32),(-960.0 - fVar7) * fVar8);
                local_50 = 0;
                uVar3 = ShortcutExtensions.DOLocalMove(uVar3,&local_58,0x3e800000,0,0);
                uVar6 = new OnTooltipCB(this,DAT_181d6ecf0,0);
                TweenSettingsExtensions.OnComplete(uVar3,uVar6,DAT_181d96ee8);
                return;
              }
            }
          }
        }
    }

    // Token : 0x6001F5E
    // RVA   : 0x3A17B0   Offset: 0x39FFB0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_18044ef50(this,0);
    }

    // Token : 0x6001F5F
    // RVA   : 0xBD9F80   Offset: 0xBD8780   Length: 0x5F
    private void <OnClick>b__4_0()
    {
        ulong uVar1;
        uVar1 = Component.get_gameObject(this,0);
        Object.Destroy(uVar1,0);
    }

}
