// ============================================================
// Type  : PopInfoTabController
// Token : 0x2000329
// ============================================================

public class PopInfoTabController
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001A43
    public GameObject inkLine;

    // Token: 0x4001A44
    public bool rightInfo;

    // Token: 0x4001A45
    private bool destroying;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6001FDC
    // RVA   : 0xB0E9D0   Offset: 0xB0DDD0   Length: 0xE6
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

    // Token : 0x6001FDD
    // RVA   : 0xB0E750   Offset: 0xB0DB50   Length: 0x278
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
        lVar1 = Component.GetComponent(this,DAT_181d952f8);
        if (lVar1 != null) {
          *(uint32 *)(lVar1 + 24) = 0xbf800000;
          lVar1 = Component.get_transform(this,0);
          lVar2 = Component.get_transform(this,0);
          if (((lVar2 != null) && (lVar2 = FUN_180daa030(lVar2,0)) != null) &&
             (uVar3 = FUN_180daa030(lVar2,0), lVar1 != null)) {
            FUN_180daae30(lVar1,uVar3,0);
            uVar3 = Component.get_transform(this,0);
            lVar1 = Component.get_transform(this,0);
            if (((lVar1 != null) && (lVar1 = Transform.Find(lVar1,"Back",0)) != null) &&
               (lVar1 = Component.GetComponent(lVar1,DAT_181d94f78)) != null) {
              puVar4 = (uint32 *)RectTransform.get_rect(local_48,lVar1,0);
              local_38 = *puVar4;
              uStack_34 = puVar4[1];
              uStack_30 = puVar4[2];
              uStack_2c = puVar4[3];
              fVar7 = (float)FUN_180d995b0(&local_38,0);
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
                uVar6 = new OnTooltipCB(this,DAT_181d97a28,0);
                TweenSettingsExtensions.OnComplete(uVar3,uVar6,DAT_181dc0380);
                return;
              }
            }
          }
        }
    }

    // Token : 0x6001FDE
    // RVA   : 0x3A17B0   Offset: 0x3A0BB0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_18044ef50(this,0);
    }

    // Token : 0x6001FDF
    // RVA   : 0xB0EAC0   Offset: 0xB0DEC0   Length: 0x5F
    private void <OnClick>b__4_0()
    {
        ulong uVar1;
        uVar1 = Component.get_gameObject(this,0);
        Object.Destroy(uVar1,0);
    }

}
