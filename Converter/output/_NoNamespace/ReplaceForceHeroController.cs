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
    // RVA   : 0xD12A40   Offset: 0xD11E40   Length: 0x147
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
    // RVA   : 0xD12B90   Offset: 0xD11F90   Length: 0x10D
    public void ToggleValueChanged(Toggle targetToggle)
    {
        var pStatics = *(int64*)(DAT_181d87998 + 184);
        long lVar1;
        if (targetToggle != null) {
          if (*(char *)(targetToggle + 0x118) == false) {
            if (((*pStatics != 0) && (this.targetHero != null)) &&
               (lVar1 = *(int64 *)(*pStatics + 112)) != null) {
              FUN_18182a0b0(lVar1,this.targetHero.heroID,DAT_181d8f218);
              return;
            }
          }
          else {
            if (((*pStatics != 0) && (this.targetHero != null)) &&
               (lVar1 = *(int64 *)(*pStatics + 112)) != null) {
              FUN_1817eee00(lVar1,this.targetHero.heroID,DAT_181d8f618);
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
