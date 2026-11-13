// ============================================================
// Type  : ReplaceForceHeroController
// Token : 0x200034E
// ============================================================

public class ReplaceForceHeroController
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001B92
    public HeroData targetHero;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x600214A
    // RVA   : 0xA6BCB0   Offset: 0xA6AAB0   Length: 0x147
    public void Init()
    {
        var pStatics = *(int64*)(DAT_181e52a90 + 184);
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
                lVar4 = GameObject.GetComponent(lVar2,DAT_181e54c18);
                if (lVar4 != null) {
                  *(uint64 *)(lVar4 + 32) = this.targetHero;
                  lVar2 = GameObject.GetComponent(lVar2,DAT_181e54c18);
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

    // Token : 0x600214B
    // RVA   : 0xA6BE00   Offset: 0xA6AC00   Length: 0x10D
    public void ToggleValueChanged(Toggle targetToggle)
    {
        var pStatics = *(int64*)(DAT_181e67d70 + 184);
        long lVar1;
        if (targetToggle != null) {
          if (*(char *)(targetToggle + 0x118) == false) {
            if (((*pStatics != 0) && (this.targetHero != null)) &&
               (lVar1 = *(int64 *)(*pStatics + 112)) != null) {
              FUN_181769fe0(lVar1,this.targetHero.heroID,DAT_181e713f0);
              return;
            }
          }
          else {
            if (((*pStatics != 0) && (this.targetHero != null)) &&
               (lVar1 = *(int64 *)(*pStatics + 112)) != null) {
              FUN_181665e90(lVar1,this.targetHero.heroID,DAT_181e717f0);
              return;
            }
          }
        }
    }

    // Token : 0x600214C
    // RVA   : 0x2110A0   Offset: 0x20FEA0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_180ae8740(this,0);
    }

}
