// ============================================================
// Type  : GameModeButtonController
// Token : 0x20002A2
// ============================================================

public class GameModeButtonController
{
    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6001659
    // RVA   : 0xA299B0   Offset: 0xA281B0   Length: 0x67
    public virtual void OnPointerEnter(PointerEventData eventData)
    {
        ulong uVar1;
        uVar1 = Component.get_transform(this,0);
        uVar1 = ShortcutExtensions.DOScale(uVar1,0x3f8ccccd,0x40a00000,0);
        TweenSettingsExtensions.SetLoops(uVar1,0xffffffff,1,DAT_181d98060);
    }

    // Token : 0x600165A
    // RVA   : 0xA29A20   Offset: 0xA28220   Length: 0xB0
    public virtual void OnPointerExit(PointerEventData eventData)
    {
        ulong uVar1;
        long lVar2;
        ulong local_28;
        uint local_20;
        byte[] local_18 = new byte[16];
        uVar1 = Component.get_transform(this,0);
        DOTween.Kill(uVar1,0,0);
        lVar2 = Component.get_transform(this,0);
        puVar3 = (uint64 *)Vector3.get_one(local_18,0);
        if (lVar2 != null) {
          local_20 = *(uint32 *)(puVar3 + 1);
          local_28 = *puVar3;
          Transform.set_localScale(lVar2,&local_28,0);
          return;
        }
    }

    // Token : 0x600165B
    // RVA   : 0x3A17B0   Offset: 0x39FFB0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_18044ef50(this,0);
    }

}
