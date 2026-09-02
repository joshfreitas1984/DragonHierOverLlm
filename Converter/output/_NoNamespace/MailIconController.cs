// ============================================================
// Type  : MailIconController
// Token : 0x20002F9
// ============================================================

public class MailIconController
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x40017CA
    public MailData mailData;

    // Token: 0x40017CB
    public bool inited;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6001885
    // RVA   : 0xA8B8C0   Offset: 0xA8A0C0   Length: 0x451
    private void Update()
    {
        long lVar1;
        long lVar2;
        ulong uVar5;
        ulong local_18;
        uint uStack_10;
        uint32 uStack_c;
        if (this.inited) {
          return;
        }
        this.inited = 1;
        MailIconController.RefreshNoticeText(this,0);
        lVar1 = Component.get_transform(this,0);
        if ((lVar1 != null) && (lVar1 = Transform.Find(lVar1,"Title",0)) != null) {
          lVar1 = Component.GetComponent(lVar1,DAT_181d6b840);
          if ((this.mailData != null) && (lVar1 != null)) {
            lVar1.mailText = this.mailData.mailTitle;
            lVar1 = Component.get_transform(this,0);
            if (((lVar1 != null) && (lVar1 = Transform.Find(lVar1,"Title",0)) != null) &&
               (lVar1 = Transform.Find(lVar1,"Important",0)) != null) {
              lVar2 = Component.GetComponent(lVar1,DAT_181d6ccc0);
              lVar1 = this.mailData;
              if (lVar1 != null) {
                uVar5 = "";
                if ((lVar1.important) &&
                   (uVar5 = "<color=#D2691E><b>重要剧情信件</b></color>", lVar1.notImportant)) {
                  uVar5 = "<color=grey><b>次要剧情信件</b></color>";
                }
                if (lVar2 != null) {
                  *(uint64 *)(lVar2 + 24) = uVar5;
                  lVar1 = Component.get_transform(this,0);
                  if ((lVar1 != null) && (lVar1 = Transform.Find(lVar1,"Title",0)) != null) {
                    lVar1 = Transform.Find(lVar1,"Important",0);
                    if (this.mailData != null) {
                      if (!this.mailData.important) {
                        puVar3 = (uint64 *)Vector3.get_zero(&local_18);
                      }
                      else {
                        puVar3 = (uint64 *)Vector3.get_one();
                      }
                      if (lVar1 != null) {
                        local_18 = *puVar3;
                        uStack_10 = *(uint32 *)(puVar3 + 1);
                        Transform.set_localScale(lVar1,&local_18,0);
                        if (this.mailData != null) {
                          if (this.mailData.important) {
                            lVar1 = Component.get_transform(this,0);
                            if (((lVar1 == null) ||
                                (lVar1 = Transform.Find(lVar1,"Title",0)) == null) ||
                               (lVar1 = Transform.Find(lVar1,"Important",0)) == null)
                            throw; // [null/range check failed]
                            plVar4 = (int64 *)Component.GetComponent(lVar1);
                            if (this.mailData == null) throw; // [null/range check failed]
                            if (!this.mailData.notImportant) {
                              puVar3 = (uint64 *)Color.get_yellow(&local_18);
                            }
                            else {
                              puVar3 = (uint64 *)FUN_181098a50();
                            }
                            if (plVar4 == (int64 *)0) throw; // [null/range check failed]
                            local_18 = *puVar3;
                            uStack_10 = *(uint32 *)(puVar3 + 1);
                            uStack_c = *(uint32 *)((int64)puVar3 + 12);
                            (**(code **)(*plVar4 + 0x2a8))
                                      (plVar4,&local_18,*(uint64 *)(*plVar4 + 0x2b0));
                          }
                          lVar1 = Component.get_transform(this,0);
                          if ((lVar1 != null) && (lVar1 = Transform.Find(lVar1,"Text",0)) != null
                             ) {
                            plVar4 = (int64 *)Component.GetComponent(lVar1,DAT_181d6d8c0);
                            if ((this.mailData != null) &&
                               (uVar5 = LTLocalization.GetText
                                                  (this.mailData.mailText,0
                                                   ,1,0), plVar4 != (int64 *)0)) {
                              (**(code **)(*plVar4 + 0x5e8))
                                        (plVar4,uVar5,*(uint64 *)(*plVar4 + 0x5f0));
                              LTLocalization.CheckTextFont(plVar4,0);
                              lVar1 = Component.get_transform(this,0);
                              if ((lVar1 != null) &&
                                 (lVar1 = Transform.Find(lVar1,"Time",0)) != null) {
                                plVar4 = (int64 *)Component.GetComponent(lVar1,DAT_181d6d8c0);
                                if ((this.mailData != null) &&
                                   (lVar1 = this.mailData.mailTime,
                                   lVar1 != null)) {
                                  uVar5 = TimeData.GetDescribe(lVar1,0);
                                  uVar5 = String.Concat("                                                                          ",uVar5,0);
                                  uVar5 = LTLocalization.GetText(uVar5,0,1,0);
                                  if (plVar4 != (int64 *)0) {
                                    (**(code **)(*plVar4 + 0x5e8))
                                              (plVar4,uVar5,*(uint64 *)(*plVar4 + 0x5f0));
                                    LTLocalization.CheckTextFont(plVar4,0);
                                    return;
                                  }
                                }
                              }
                            }
                          }
                        }
                      }
                    }
                  }
                }
              }
            }
          }
        }
    }

    // Token : 0x6001886
    // RVA   : 0xA8B590   Offset: 0xA89D90   Length: 0x214
    public void OnClick()
    {
        var pStatics_5970 = *(int64*)(DAT_181d65970 + 184);
        var pStatics_df90 = *(int64*)(DAT_181d4df90 + 184);
        long lVar1;
        bool cVar2;
        ulong uVar4;
        cVar2 = FUN_1804625f0(0x130,0);
        if (!cVar2) {
          lVar1 = this.mailData;
          if (lVar1 != null) {
            lVar1.noticed = !lVar1.noticed;
            MailIconController.RefreshNoticeText(this,0);
            if (*pStatics_5970 != 0) {
              MissionUIController.RefreshMailNewIcon(*pStatics_5970,0);
              uVar4 = "Sound/SoundEffect/Paper";
        LAB_180a8b756:
              plVar3 = (int64 *)Resources.Load(uVar4,0);
              plVar5 = (int64 *)0;
              if ((plVar3 != (int64 *)0) && (*plVar3 == DAT_181d8a228)) {
                plVar5 = plVar3;
              }
              NGUITools.PlaySound(plVar5,0);
              return;
            }
          }
        }
        else {
          if (((*pStatics_df90 != 0) &&
              (lVar1 = *(int64 *)(*pStatics_df90 + 32)) != null) &&
             (lVar1 = *(int64 *)(lVar1 + 144)) != null) {
            FUN_181801c10(lVar1,this.mailData,DAT_181d6bee8);
            if (*pStatics_5970 != 0) {
              MissionUIController.RefreshMailTable(*pStatics_5970,0);
              uVar4 = "Sound/SoundEffect/PaperQuick";
              goto LAB_180a8b756;
            }
          }
        }
    }

    // Token : 0x6001887
    // RVA   : 0xA8B7B0   Offset: 0xA89FB0   Length: 0x10F
    public void RefreshNoticeText()
    {
        long lVar1;
        ulong uVar3;
        lVar1 = Component.get_transform(this,0);
        if (lVar1 != null) {
          lVar1 = Transform.Find(lVar1,"Title",0);
          if (lVar1 != null) {
            plVar2 = (int64 *)Component.GetComponent(lVar1,DAT_181d6d8c0);
            lVar1 = this.mailData;
            if (lVar1 != null) {
              uVar3 = " <color=grey>(已读)</color>";
              if (!lVar1.noticed) {
                uVar3 = " <color=red>(未读)</color>";
              }
              uVar3 = String.Concat(lVar1.mailTitle,":",uVar3,0);
              uVar3 = LTLocalization.GetText(uVar3,0,1,0);
              if (plVar2 != (int64 *)0) {
                (**(code **)(*plVar2 + 0x5e8))(plVar2,uVar3,*(uint64 *)(*plVar2 + 0x5f0));
                LTLocalization.CheckTextFont(plVar2,0);
                return;
              }
            }
          }
        }
    }

    // Token : 0x6001888
    // RVA   : 0x3A17B0   Offset: 0x39FFB0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_18044ef50(this,0);
    }

}
