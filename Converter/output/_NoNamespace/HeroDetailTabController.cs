// ============================================================
// Type  : HeroDetailTabController
// Token : 0x20002C1
// ============================================================

public class HeroDetailTabController
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x400165E
    public HeroData heroData;

    // Token: 0x400165F
    private bool isOn;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6001778
    // RVA   : 0xEC5D30   Offset: 0xEC4530   Length: 0x39D
    private void Update()
    {
        var pStatics = *(int64*)(DAT_181d50f00 + 184);
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
            plVar1 = (int64 *)Component.GetComponent(this,DAT_181d6bc40);
            local_28 = 0;
            uStack_20 = 0;
            FUN_1809981e0(&local_28,0,0,0,0x3ea0a0a1,0);
            if (plVar1 == (int64 *)0) {
        LAB_180ec60c8:
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
            goto LAB_180ec60c8;
            plVar1 = (int64 *)Component.GetComponent(lVar2,DAT_181d6d8c0);
            puVar3 = (uint32 *)Color.get_black(&local_18,0);
            if (plVar1 == (int64 *)0) goto LAB_180ec60c8;
            local_18 = *puVar3;
            uStack_14 = puVar3[1];
            uStack_10 = puVar3[2];
            uStack_c = puVar3[3];
            (**(code **)(*plVar1 + 0x2a8))(plVar1,&local_18,*(uint64 *)(*plVar1 + 0x2b0));
            lVar2 = Component.get_transform(this,0);
            if ((lVar2 == null) || (lVar2 = Transform.Find(lVar2,"Icon",0)) == null)
            goto LAB_180ec60c8;
            plVar1 = (int64 *)Component.GetComponent(lVar2,DAT_181d6bc40);
            puVar3 = (uint32 *)FUN_180d904c0(&local_18,0);
            if (plVar1 == (int64 *)0) goto LAB_180ec60c8;
            goto LAB_180ec6096;
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
          plVar1 = (int64 *)Component.GetComponent(this,DAT_181d6bc40);
          puVar3 = (uint32 *)FUN_181098a50(&local_18,0);
          if (plVar1 != (int64 *)0) {
            local_18 = *puVar3;
            uStack_14 = puVar3[1];
            uStack_10 = puVar3[2];
            uStack_c = puVar3[3];
            (**(code **)(*plVar1 + 0x2a8))(plVar1,&local_18,*(uint64 *)(*plVar1 + 0x2b0));
            lVar2 = Component.get_transform(this,0);
            if ((lVar2 != null) && (lVar2 = Transform.Find(lVar2,"Label",0)) != null) {
              plVar1 = (int64 *)Component.GetComponent(lVar2,DAT_181d6d8c0);
              lVar2 = *(int64 *)(DAT_181d4ef00 + 184);
              if (plVar1 != (int64 *)0) {
                local_18 = *(uint32 *)(lVar2 + 0x370);
                uStack_14 = *(uint32 *)(lVar2 + 0x374);
                uStack_10 = *(uint32 *)(lVar2 + 0x378);
                uStack_c = *(uint32 *)(lVar2 + 0x37c);
                (**(code **)(*plVar1 + 0x2a8))(plVar1,&local_18,*(uint64 *)(*plVar1 + 0x2b0));
                lVar2 = Component.get_transform(this,0);
                if ((lVar2 != null) && (lVar2 = Transform.Find(lVar2,"Icon",0)) != null) {
                  plVar1 = (int64 *)Component.GetComponent(lVar2,DAT_181d6bc40);
                  puVar3 = (uint32 *)FUN_181098a50(&local_18,0);
                  if (plVar1 != (int64 *)0) {
        LAB_180ec6096:
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

    // Token : 0x6001779
    // RVA   : 0xEC5C10   Offset: 0xEC4410   Length: 0x117
    public void OnClick()
    {
        var pStatics = *(int64*)(DAT_181d50f00 + 184);
        plVar1 = (int64 *)Resources.Load("Sound/SoundEffect/Paper",0);
        plVar2 = (int64 *)0;
        if ((plVar1 != (int64 *)0) && (*plVar1 == DAT_181d8a228)) {
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

    // Token : 0x600177A
    // RVA   : 0x3A17B0   Offset: 0x39FFB0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_18044ef50(this,0);
    }

}
