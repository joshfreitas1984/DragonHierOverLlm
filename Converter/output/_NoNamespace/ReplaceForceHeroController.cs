// ============================================================
// Type  : ReplaceForceHeroController
// Token : 0x200012D
// ============================================================

public class ReplaceForceHeroController
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4000760
    public HeroData targetHero;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60009CD
    // RVA   : 0xD13050   Offset: 0xD12450   Length: 0x147
    public void Init()
    {
        var pStatics = *(int64*)(DAT_181d72ee8 + 184);
        ulong uVar1;
        long lVar2;
        ulong uVar3;
        long lVar4;
        lVar2 = Component.get_transform(this,0);
        if (lVar2 != null) {
          lVar2 = Transform.Find(lVar2,"HeroIconPos",0);
          if (lVar2 != null) {
            uVar3 = Component.get_gameObject(lVar2,0);
            if (*pStatics != 0) {
              uVar1 = *(uint64 *)(*pStatics + 144);
              lVar2 = GlobalData.AddChild(uVar3,uVar1,0);
              if (lVar2 != null) {
                lVar4 = GameObject.GetComponent(lVar2,DAT_181d71b50);
                if (lVar4 != null) {
                  *(uint64 *)(lVar4 + 32) = this.targetHero;
                  lVar2 = GameObject.GetComponent(lVar2,DAT_181d71b50);
                  if (lVar2 != null) {
                    *(uint32 *)(lVar2 + 24) = 2;
                    return;
                  }
                }
              }
            }
          }
        }
    }

    // Token : 0x60009CE
    // RVA   : 0xD131A0   Offset: 0xD125A0   Length: 0x10D
    public void ToggleValueChanged(Toggle targetToggle)
    {
        var pStatics = *(int64*)(DAT_181d879b0 + 184);
        long lVar1;
        if (targetToggle != null) {
          if (*(char *)(targetToggle + 0x118) == false) {
            if (((*pStatics != 0) && (this.targetHero != null)) &&
               (lVar1 = *(int64 *)(*pStatics + 112)) != null) {
              FUN_18182a6c0(lVar1,this.targetHero.heroID,DAT_181d8f230);
              return;
            }
          }
          else {
            if (((*pStatics != 0) && (this.targetHero != null)) &&
               (lVar1 = *(int64 *)(*pStatics + 112)) != null) {
              FUN_1817ef410(lVar1,this.targetHero.heroID,DAT_181d8f630);
              return;
            }
          }
        }
    }

    // Token : 0x60009CF
    // RVA   : 0x3A17B0   Offset: 0x3A0BB0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_18044ef50(this,0);
    }

}
