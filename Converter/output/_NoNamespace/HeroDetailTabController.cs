// ============================================================
// Type  : HeroDetailTabController
// Token : 0x20002D0
// ============================================================

public class HeroDetailTabController
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001766
    public HeroData heroData;

    // Token: 0x4001767
    private bool isOn;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6001838
    // RVA   : 0xB20800   Offset: 0xB1F600   Length: 0x39D
    private void Update()
    {
        var pStatics = *(int64*)(DAT_181e55ae8 + 184);
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
            plVar1 = (int64 *)Component.GetComponent(this,DAT_181e777b8);
            local_28 = 0;
            uStack_20 = 0;
            FUN_1807282e0(&local_28,0,0,0,0x3ea0a0a1,0);
            if (plVar1 == (int64 *)0) {
        LAB_180b20b98:
                          // WARNING: Subroutine does not return
              FUN_1801e0300();
            }
            local_18 = (uint32)local_28;
            uStack_14 = local_28._4_4_;
            uStack_10 = (uint32)uStack_20;
            uStack_c = uStack_20._4_4_;
            (**(code **)(*plVar1 + 0x2a8))(plVar1,&local_18,*(uint64 *)(*plVar1 + 0x2b0));
            lVar2 = Component.get_transform(this,0);
            if ((lVar2 == null) || (lVar2 = Transform.Find(lVar2,"Label",0)) == null)
            goto LAB_180b20b98;
            plVar1 = (int64 *)Component.GetComponent(lVar2,DAT_181e79538);
            puVar3 = (uint32 *)Color.get_black(&local_18,0);
            if (plVar1 == (int64 *)0) goto LAB_180b20b98;
            local_18 = *puVar3;
            uStack_14 = puVar3[1];
            uStack_10 = puVar3[2];
            uStack_c = puVar3[3];
            (**(code **)(*plVar1 + 0x2a8))(plVar1,&local_18,*(uint64 *)(*plVar1 + 0x2b0));
            lVar2 = Component.get_transform(this,0);
            if ((lVar2 == null) || (lVar2 = Transform.Find(lVar2,"Icon",0)) == null)
            goto LAB_180b20b98;
            plVar1 = (int64 *)Component.GetComponent(lVar2,DAT_181e777b8);
            puVar3 = (uint32 *)FUN_180af4e90(&local_18,0);
            if (plVar1 == (int64 *)0) goto LAB_180b20b98;
            goto LAB_180b20b66;
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
          plVar1 = (int64 *)Component.GetComponent(this,DAT_181e777b8);
          puVar3 = (uint32 *)FUN_180f24d00(&local_18,0);
          if (plVar1 != (int64 *)0) {
            local_18 = *puVar3;
            uStack_14 = puVar3[1];
            uStack_10 = puVar3[2];
            uStack_c = puVar3[3];
            (**(code **)(*plVar1 + 0x2a8))(plVar1,&local_18,*(uint64 *)(*plVar1 + 0x2b0));
            lVar2 = Component.get_transform(this,0);
            if ((lVar2 != null) && (lVar2 = Transform.Find(lVar2,"Label",0)) != null) {
              plVar1 = (int64 *)Component.GetComponent(lVar2,DAT_181e79538);
              lVar2 = *(int64 *)(DAT_181e538e8 + 184);
              if (plVar1 != (int64 *)0) {
                local_18 = *(uint32 *)(lVar2 + 0x380);
                uStack_14 = *(uint32 *)(lVar2 + 900);
                uStack_10 = *(uint32 *)(lVar2 + 0x388);
                uStack_c = *(uint32 *)(lVar2 + 0x38c);
                (**(code **)(*plVar1 + 0x2a8))(plVar1,&local_18,*(uint64 *)(*plVar1 + 0x2b0));
                lVar2 = Component.get_transform(this,0);
                if ((lVar2 != null) && (lVar2 = Transform.Find(lVar2,"Icon",0)) != null) {
                  plVar1 = (int64 *)Component.GetComponent(lVar2,DAT_181e777b8);
                  puVar3 = (uint32 *)FUN_180f24d00(&local_18,0);
                  if (plVar1 != (int64 *)0) {
        LAB_180b20b66:
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

    // Token : 0x6001839
    // RVA   : 0xB206E0   Offset: 0xB1F4E0   Length: 0x117
    public void OnClick()
    {
        var pStatics = *(int64*)(DAT_181e55ae8 + 184);
        plVar1 = (int64 *)Resources.Load("Sound/SoundEffect/Paper",0);
        plVar2 = (int64 *)0;
        if ((plVar1 != (int64 *)0) && (*plVar1 == DAT_181e8f4a0)) {
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

    // Token : 0x600183A
    // RVA   : 0x2110A0   Offset: 0x20FEA0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_180ae8740(this,0);
    }

}
