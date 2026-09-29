// ============================================================
// Type  : GameModeButtonController
// Token : 0x20002A8
// ============================================================

public class GameModeButtonController
{
    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x600169D
    // RVA   : 0xA589F0   Offset: 0xA57DF0   Length: 0x67
    public virtual void OnPointerEnter(PointerEventData eventData)
    {
        ulong uVar1;
        uVar1 = Component.get_transform(this,0);
        uVar1 = ShortcutExtensions.DOScale(uVar1,0x3f8ccccd,0x40a00000,0);
        TweenSettingsExtensions.SetLoops(uVar1,0xffffffff,1,DAT_181dc14d8);
    }

    // Token : 0x600169E
    // RVA   : 0xA58A60   Offset: 0xA57E60   Length: 0xB0
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

    // Token : 0x600169F
    // RVA   : 0x3A17B0   Offset: 0x3A0BB0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_18044ef50(this,0);
    }

}
