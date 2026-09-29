// ============================================================
// Type  : HeroDetailTabController
// Token : 0x20002C7
// ============================================================

public class HeroDetailTabController
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001712
    public HeroData heroData;

    // Token: 0x4001713
    private bool isOn;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60017BC
    // RVA   : 0xE21530   Offset: 0xE20930   Length: 0x39D
    private void Update()
    {
        var pStatics = *(int64*)(DAT_181d75f40 + 184);
        long lVar2;
        ulong local_28;
        ulong uStack_20;
        uint local_18;
        uint uStack_14;
        uint uStack_10;
        uint32 uStack_c;
        if (this.isOn) {
          if (*pStatics == 0) throw; // [null/range check failed]
          if (*(int64 *)(*pStatics + 96) != this.heroData
             ) {
            this.isOn = 0;
            plVar1 = (int64 *)Component.GetComponent(this,DAT_181d94478);
            local_28 = 0;
            uStack_20 = 0;
            FUN_1809dcfa0(&local_28,0,0,0,0x3ea0a0a1,0);
            if (plVar1 == (int64 *)0) {
        LAB_180e218c8:
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            local_18 = (uint32)local_28;
            uStack_14 = local_28._4_4_;
            uStack_10 = (uint32)uStack_20;
            uStack_c = uStack_20._4_4_;
            (**(code **)(*plVar1 + 0x2a8))(plVar1,&local_18,*(uint64 *)(*plVar1 + 0x2b0));
            lVar2 = Component.get_transform(this,0);
            if ((lVar2 == null) || (lVar2 = Transform.Find(lVar2,"Label",0)) == null)
            goto LAB_180e218c8;
            plVar1 = (int64 *)Component.GetComponent(lVar2,DAT_181d96178);
            puVar3 = (uint32 *)Color.get_black(&local_18,0);
            if (plVar1 == (int64 *)0) goto LAB_180e218c8;
            local_18 = *puVar3;
            uStack_14 = puVar3[1];
            uStack_10 = puVar3[2];
            uStack_c = puVar3[3];
            (**(code **)(*plVar1 + 0x2a8))(plVar1,&local_18,*(uint64 *)(*plVar1 + 0x2b0));
            lVar2 = Component.get_transform(this,0);
            if ((lVar2 == null) || (lVar2 = Transform.Find(lVar2,"Icon",0)) == null)
            goto LAB_180e218c8;
            plVar1 = (int64 *)Component.GetComponent(lVar2,DAT_181d94478);
            puVar3 = (uint32 *)FUN_180d995f0(&local_18,0);
            if (plVar1 == (int64 *)0) goto LAB_180e218c8;
            goto LAB_180e21896;
          }
          if (this.isOn) {
            return;
          }
        }
        if (*pStatics != 0) {
          if (*(int64 *)(*pStatics + 96) != this.heroData
             ) {
            return;
          }
          this.isOn = 1;
          plVar1 = (int64 *)Component.GetComponent(this,DAT_181d94478);
          puVar3 = (uint32 *)FUN_1810d3b80(&local_18,0);
          if (plVar1 != (int64 *)0) {
            local_18 = *puVar3;
            uStack_14 = puVar3[1];
            uStack_10 = puVar3[2];
            uStack_c = puVar3[3];
            (**(code **)(*plVar1 + 0x2a8))(plVar1,&local_18,*(uint64 *)(*plVar1 + 0x2b0));
            lVar2 = Component.get_transform(this,0);
            if ((lVar2 != null) && (lVar2 = Transform.Find(lVar2,"Label",0)) != null) {
              plVar1 = (int64 *)Component.GetComponent(lVar2,DAT_181d96178);
              lVar2 = *(int64 *)(DAT_181d73d40 + 184);
              if (plVar1 != (int64 *)0) {
                local_18 = *(uint32 *)(lVar2 + 0x378);
                uStack_14 = *(uint32 *)(lVar2 + 0x37c);
                uStack_10 = *(uint32 *)(lVar2 + 0x380);
                uStack_c = *(uint32 *)(lVar2 + 900);
                (**(code **)(*plVar1 + 0x2a8))(plVar1,&local_18,*(uint64 *)(*plVar1 + 0x2b0));
                lVar2 = Component.get_transform(this,0);
                if ((lVar2 != null) && (lVar2 = Transform.Find(lVar2,"Icon",0)) != null) {
                  plVar1 = (int64 *)Component.GetComponent(lVar2,DAT_181d94478);
                  puVar3 = (uint32 *)FUN_1810d3b80(&local_18,0);
                  if (plVar1 != (int64 *)0) {
        LAB_180e21896:
                    local_18 = *puVar3;
                    uStack_14 = puVar3[1];
                    uStack_10 = puVar3[2];
                    uStack_c = puVar3[3];
                    (**(code **)(*plVar1 + 0x2a8))(plVar1,&local_18,*(uint64 *)(*plVar1 + 0x2b0));
                    return;
                  }
                }
              }
            }
          }
        }
    }

    // Token : 0x60017BD
    // RVA   : 0xE21410   Offset: 0xE20810   Length: 0x117
    public void OnClick()
    {
        var pStatics = *(int64*)(DAT_181d75f40 + 184);
        plVar1 = (int64 *)Resources.Load("Sound/SoundEffect/Paper",0);
        plVar2 = (int64 *)0;
        if ((plVar1 != (int64 *)0) && (*plVar1 == DAT_181daf360)) {
          plVar2 = plVar1;
        }
        NGUITools.PlaySound(plVar2,0);
        if (*pStatics != 0) {
          if (*(int64 *)(*pStatics + 96) != this.heroData
             ) {
            if (*pStatics == 0) throw; // [null/range check failed]
            HeroDetailController.FreshNowHeroDetail
                      (*pStatics,this.heroData,1,0);
          }
          return;
        }
    }

    // Token : 0x60017BE
    // RVA   : 0x3A17B0   Offset: 0x3A0BB0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_18044ef50(this,0);
    }

}
