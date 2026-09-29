// ============================================================
// Type  : AchMenuController
// Token : 0x200013B
// ============================================================

public class AchMenuController
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x40007AD
    public GameObject achMenu;

    // Token: 0x40007AE
    public GameObject achPrefab;

    // Token: 0x40007AF
    public GameObject achGrid;

    // Token: 0x40007B0
    private bool inited;

    // Token: 0x40007B1
    private GameObject temp;

    // Token: 0x40007B2
    private static AchMenuController _instance;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000A1E
    // RVA   : 0xA1BE80   Offset: 0xA1B280   Length: 0x36
    public static AchMenuController get_Instance()
    {
        return **(uint64 **)(DAT_181daa678 + 184);
    }

    // Token : 0x6000A1F
    // RVA   : 0xA1AB20   Offset: 0xA19F20   Length: 0x99
    private void Awake()
    {
        ulong uVar1;
        bool cVar3;
        uVar1 = **(uint64 **)(DAT_181daa678 + 184);
        cVar3 = Object.op_Equality(uVar1,0,0);
        if (cVar3) {
          puVar2 = *(uint64 **)(DAT_181daa678 + 184);
          *puVar2 = this;
          il2cpp_internal(puVar2,this);
        }
    }

    // Token : 0x6000A20
    // RVA   : 0xA1ABC0   Offset: 0xA19FC0   Length: 0x1089
    public void ShowAchMenu()
    {
        bool cVar1;
        int iVar2;
        long lVar4;
        ulong uVar7;
        ulong uVar8;
        ulong uVar9;
        long lVar10;
        uint[] local_res8 = new uint[4];
        uint[] local_res18 = new uint[2];
        uint[] local_res20 = new uint[2];
        uint[] local_98 = new uint[4];
        ulong local_88;
        uint local_80;
        byte[] local_78 = new byte[16];
        ulong local_68;
        ulong uStack_60;
        byte[] local_58 = new byte[32];
        if (this.achMenu != null) {
          GameObject.SetActive(this.achMenu,1,0);
          plVar3 = (int64 *)Resources.Load("Sound/SoundEffect/Paper",0);
          plVar11 = (int64 *)0;
          plVar5 = plVar11;
          if ((plVar3 != (int64 *)0) && (plVar5 = (int64 *)0, *plVar3 == DAT_181daf360)) {
            plVar5 = plVar3;
          }
          NGUITools.PlaySound(plVar5,0);
          if (((this.achMenu != null) &&
              (lVar4 = GameObject.get_transform(this.achMenu,0)) != null) &&
             (lVar4 = Transform.Find(lVar4,"BlackBackground",0)) != null) {
            plVar3 = (int64 *)Component.GetComponent(lVar4,DAT_181d94478);
            if (((this.achMenu != null) &&
                (lVar4 = GameObject.get_transform(this.achMenu,0)) != null) &&
               ((lVar4 = Transform.Find(lVar4,"BlackBackground",0), lVar4 != null &&
                (plVar5 = (int64 *)Component.GetComponent(lVar4,DAT_181d94478),
                plVar5 != (int64 *)0)))) {
              puVar6 = (uint64 *)
                       (**(code **)(*plVar5 + 0x298))(&local_68,plVar5,*(uint64 *)(*plVar5 + 0x2a0));
              local_68 = *puVar6;
              uStack_60 = puVar6[1];
              puVar6 = (uint64 *)GlobalData.SetColorAlpha(local_78,&local_68,0,0);
              if (plVar3 != (int64 *)0) {
                local_68 = *puVar6;
                uStack_60 = puVar6[1];
                (**(code **)(*plVar3 + 0x2a8))(plVar3,&local_68,*(uint64 *)(*plVar3 + 0x2b0));
                if (((this.achMenu != null) &&
                    (lVar4 = GameObject.get_transform(this.achMenu,0)) != null) &&
                   (lVar4 = Transform.Find(lVar4,"BlackBackground",0)) != null) {
                  uVar7 = Component.GetComponent(lVar4,DAT_181d94478);
                  uVar7 = DOTweenModuleUI.DOFade(uVar7);
                  TweenSettingsExtensions.SetUpdate(uVar7,1,DAT_181dc1dc8);
                  if (((this.achMenu != null) &&
                      (lVar4 = GameObject.get_transform(this.achMenu,0)) != null) &&
                     (lVar4 = Transform.Find(lVar4,"AchRoot",0)) != null) {
                    local_88 = 0x3f80000000000000;
                    local_80 = 0x3f800000;
                    Transform.set_localScale(lVar4,&local_88,0);
                    if ((this.achMenu != null) &&
                       (lVar4 = GameObject.get_transform(this.achMenu,0)) != null) {
                      uVar7 = Transform.Find(lVar4,"AchRoot",0);
                      uVar7 = ShortcutExtensions.DOScale(uVar7);
                      TweenSettingsExtensions.SetUpdate(uVar7,1,DAT_181dc1f60);
                      if ((this.achMenu != null) &&
                         (((lVar4 = GameObject.get_transform(this.achMenu,0), lVar4 != null
                           && (lVar4 = Transform.Find(lVar4,"AchRoot",0)) != null) &&
                          (lVar4 = Transform.Find(lVar4,"FinishCount",0)) != null))) {
                        uVar7 = Component.GetComponent(lVar4,DAT_181d96178);
                        lVar4 = GameController.lockObj;
                        if (lVar4 != null) {
                          local_res18[0] = GameDataController.GetAchFinishedCount(lVar4,0);
                          uVar8 = il2cpp_value_box(DAT_181d80430,local_res18);
                          lVar4 = GameController.lockObj;
                          if ((lVar4 != null) && (lVar4 = *(int64 *)(lVar4 + 0x1c0)) != null) {
                            local_res20[0] = *(uint32 *)(lVar4 + 24);
                            uVar9 = il2cpp_value_box(DAT_181d80430,local_res20);
                            uVar8 = String.Format("{0}/{1}",uVar8,uVar9,0);
                            LTLocalization.SetText(uVar7,uVar8,0);
                            if ((((this.achMenu != null) &&
                                 (lVar4 = GameObject.get_transform(this.achMenu,0),
                                 lVar4 != null)) &&
                                (lVar4 = Transform.Find(lVar4,"AchRoot",0)) != null) &&
                               (lVar4 = Transform.Find(lVar4,"ExtraTagPoint",0)) != null) {
                              uVar7 = Component.GetComponent(lVar4,DAT_181d96178);
                              lVar4 = GameController.difficultyExtraPoint;
                              if ((lVar4 != null) && (lVar4 = *(int64 *)(lVar4 + 16)) != null) {
                                local_98[0] = PlayerPrefDictionary.GetInt(lVar4,"AchTagPoint",0);
                                uVar8 = il2cpp_value_box(DAT_181d80430,local_98);
                                uVar8 = String.Format("已获得初始天赋点 {0}",uVar8,0);
                                LTLocalization.SetText(uVar7,uVar8,0);
                                if (this.inited) {
                                  return;
                                }
                                this.inited = 1;
                                local_res8[0] = 0;
                                plVar3 = plVar11;
                                do {
                                  lVar4 = GameController.lockObj;
                                  if ((lVar4 == null) || (lVar4 = *(int64 *)(lVar4 + 0x1c0)) == null)
                                  {
        LAB_180a1bc3e:
                          // WARNING: Subroutine does not return
                                    FUN_1800d6620();
                                  }
                                  if (*(int *)(lVar4 + 24) <= (int)plVar3) {
                                    return;
                                  }
                                  uVar7 = this.achGrid;
                                  uVar8 = this.achPrefab;
                                  uVar7 = GlobalData.AddChild(uVar7,uVar8,0);
                                  this.temp = uVar7;
                                  if (((this.temp == null) ||
                                      (lVar4 = GameObject.get_transform(this.temp,0),
                                      lVar4 == null)) ||
                                     (lVar4 = Transform.Find(lVar4,"Icon",0)) == null)
                                  goto LAB_180a1bc3e;
                                  lVar4 = Component.GetComponent(lVar4,DAT_181d94478);
                                  uVar7 = Int32.ToString(local_res8,0);
                                  lVar10 = GameController.difficultyExtraPoint;
                                  if (lVar10 == null) goto LAB_180a1bc3e;
                                  lVar10 = *(int64 *)(lVar10 + 16);
                                  uVar8 = Int32.ToString(local_res8,0);
                                  uVar8 = String.Concat("AchFinished",uVar8,0);
                                  if (lVar10 == null) goto LAB_180a1bc3e;
                                  uVar8 = PlayerPrefDictionary.GetString(lVar10,uVar8,0);
                                  cVar1 = FUN_18171eb50(uVar8,"true",0);
                                  uVar8 = "";
                                  if (!cVar1) {
                                    uVar8 = "_lock";
                                  }
                                  uVar8 = String.Concat("Textures/Ach/ach",uVar7,uVar8,0);
                                  uVar7 = DAT_181dc1928;
                                  uVar7 = Type.GetTypeFromHandle(uVar7,0);
                                  plVar3 = (int64 *)Resources.Load(uVar8,uVar7,0);
                                  if (lVar4 == null) goto LAB_180a1bc3e;
                                  plVar5 = plVar11;
                                  if ((plVar3 != (int64 *)0) && (*plVar3 == DAT_181da4be8)) {
                                    plVar5 = plVar3;
                                  }
                                  Image.set_sprite(lVar4,plVar5,0);
                                  if (this.temp == null) goto LAB_180a1bc3e;
                                  plVar3 = (int64 *)
                                           GameObject.GetComponent
                                                     (this.temp,DAT_181d71e80);
                                  lVar4 = GameController.difficultyExtraPoint;
                                  if (lVar4 == null) goto LAB_180a1bc3e;
                                  lVar4 = *(int64 *)(lVar4 + 16);
                                  uVar7 = Int32.ToString(local_res8,0);
                                  uVar7 = String.Concat("AchFinished",uVar7,0);
                                  if (lVar4 == null) goto LAB_180a1bc3e;
                                  uVar7 = PlayerPrefDictionary.GetString(lVar4,uVar7,0);
                                  cVar1 = FUN_18171eb50(uVar7,"true",0);
                                  if (!cVar1) {
                                    local_68 = 0;
                                    uStack_60 = 0;
                                    Color.ctor(&local_68);
                                    uVar7 = local_68;
                                    uVar8 = uStack_60;
                                  }
                                  else {
                                    puVar6 = (uint64 *)FUN_1810d3b80(local_58,0);
                                    uVar7 = *puVar6;
                                    uVar8 = puVar6[1];
                                  }
                                  if (plVar3 == (int64 *)0) {
        LAB_180a1bc38:
                          // WARNING: Subroutine does not return
                                    FUN_1800d6620();
                                  }
                                  local_68 = uVar7;
                                  uStack_60 = uVar8;
                                  (**(code **)(*plVar3 + 0x2a8))
                                            (plVar3,&local_68,*(uint64 *)(*plVar3 + 0x2b0));
                                  if (((this.temp == null) ||
                                      (lVar4 = GameObject.get_transform(this.temp,0),
                                      lVar4 == null)) ||
                                     (lVar4 = Transform.Find(lVar4,"Title",0)) == null)
                                  goto LAB_180a1bc38;
                                  uVar7 = Component.GetComponent(lVar4,DAT_181d96178);
                                  lVar4 = FUN_18046c100(0);
                                  if (((lVar4 == null) || (*(int64 *)(lVar4 + 0x1c0) == 0)) ||
                                     (lVar4 = FUN_180002f80(*(int64 *)(lVar4 + 0x1c0),local_res8[0],
                                                            DAT_181d7b1a0), lVar4 == null))
                                  goto LAB_180a1bc38;
                                  uVar8 = *(uint64 *)(lVar4 + 16);
                                  LTLocalization.SetText(uVar7,uVar8,0);
                                  if (((this.temp == null) ||
                                      (lVar4 = GameObject.get_transform(this.temp,0),
                                      lVar4 == null)) ||
                                     (lVar4 = Transform.Find(lVar4,"Describe",0)) == null)
                                  goto LAB_180a1bc38;
                                  uVar7 = Component.GetComponent(lVar4,DAT_181d96178);
                                  lVar4 = FUN_18046c100(0);
                                  if (((lVar4 == null) || (*(int64 *)(lVar4 + 0x1c0) == 0)) ||
                                     (lVar4 = FUN_180002f80(*(int64 *)(lVar4 + 0x1c0),local_res8[0],
                                                            DAT_181d7b1a0), lVar4 == null))
                                  goto LAB_180a1bc38;
                                  LTLocalization.SetText(uVar7,*(uint64 *)(lVar4 + 24),0);
                                  if (((this.temp == null) ||
                                      (lVar4 = GameObject.get_transform(this.temp,0),
                                      lVar4 == null)) ||
                                     (lVar4 = Transform.Find(lVar4,"Percent",0)) == null)
                                  goto LAB_180a1bc38;
                                  uVar7 = Component.GetComponent(lVar4,DAT_181d96178);
                                  lVar4 = GameController.difficultyExtraPoint;
                                  if (lVar4 == null) goto LAB_180a1bc38;
                                  lVar4 = *(int64 *)(lVar4 + 16);
                                  uVar8 = Int32.ToString(local_res8,0);
                                  uVar8 = String.Concat("AchData",uVar8,0);
                                  if (lVar4 == null) goto LAB_180a1bc38;
                                  PlayerPrefDictionary.GetInt(lVar4,uVar8,0);
                                  lVar4 = FUN_18046c100(0);
                                  if (((lVar4 == null) || (*(int64 *)(lVar4 + 0x1c0) == 0)) ||
                                     (lVar4 = FUN_180002f80(*(int64 *)(lVar4 + 0x1c0),local_res8[0],
                                                            DAT_181d7b1a0), lVar4 == null))
                                  goto LAB_180a1bc38;
                                  local_res18[0] = Mathf.Min();
                                  uVar8 = il2cpp_value_box(DAT_181da22f0,local_res18);
                                  lVar4 = FUN_18046c100(0);
                                  if (((lVar4 == null) || (*(int64 *)(lVar4 + 0x1c0) == 0)) ||
                                     (lVar4 = FUN_180002f80(*(int64 *)(lVar4 + 0x1c0),local_res8[0],
                                                            DAT_181d7b1a0), lVar4 == null))
                                  goto LAB_180a1bc38;
                                  local_res20[0] = *(uint32 *)(lVar4 + 36);
                                  uVar9 = il2cpp_value_box(DAT_181da22f0,local_res20);
                                  uVar8 = String.Format("{0}/{1}",uVar8,uVar9);
                                  LTLocalization.SetText(uVar7,uVar8,0);
                                  if (((this.temp == null) ||
                                      (lVar4 = GameObject.get_transform(this.temp,0),
                                      lVar4 == null)) ||
                                     ((lVar4 = Transform.Find(lVar4,"BarBack",0), lVar4 == null ||
                                      (lVar4 = Transform.Find(lVar4,"Bar",0)) == null)))
                                  goto LAB_180a1bc38;
                                  lVar10 = Component.GetComponent(lVar4,DAT_181d94478);
                                  lVar4 = GameController.difficultyExtraPoint;
                                  if (lVar4 == null) goto LAB_180a1bc38;
                                  lVar4 = *(int64 *)(lVar4 + 16);
                                  uVar7 = Int32.ToString(local_res8,0);
                                  uVar7 = String.Concat("AchData",uVar7,0);
                                  if (lVar4 == null) goto LAB_180a1bc38;
                                  iVar2 = PlayerPrefDictionary.GetInt(lVar4,uVar7,0);
                                  lVar4 = FUN_18046c100(0);
                                  if ((((lVar4 == null) || (*(int64 *)(lVar4 + 0x1c0) == 0)) ||
                                      (lVar4 = FUN_180002f80(*(int64 *)(lVar4 + 0x1c0),local_res8[0],
                                                             DAT_181d7b1a0), lVar4 == null)) || (lVar10 == null)
                                     ) goto LAB_180a1bc38;
                                  Image.set_fillAmount(lVar10,(float)iVar2 / *(float *)(lVar4 + 36),0);
                                  lVar4 = FUN_18046c100(0);
                                  if (((lVar4 == null) || (*(int64 *)(lVar4 + 0x1c0) == 0)) ||
                                     (lVar4 = FUN_180002f80(*(int64 *)(lVar4 + 0x1c0),local_res8[0]),
                                     lVar4 == null)) goto LAB_180a1bc38;
                                  cVar1 = FUN_180d75bc0(*(uint64 *)(lVar4 + 40),0);
                                  if (!cVar1) {
                                    if ((this.temp == null) ||
                                       (lVar4 = GameObject.get_transform(this.temp,0)
                                       , lVar4 == null)) goto LAB_180a1bc3e;
                                    lVar4 = Transform.Find(lVar4,"Tips",0);
                                    puVar6 = (uint64 *)Vector3.get_one(local_78,0);
                                    if (lVar4 == null) goto LAB_180a1bc3e;
                                    local_80 = *(uint32 *)(puVar6 + 1);
                                    local_88 = *puVar6;
                                    Transform.set_localScale(lVar4,&local_88,0);
                                    if (((this.temp == null) ||
                                        (lVar4 = GameObject.get_transform
                                                           (this.temp,0), lVar4 == null))
                                       || (lVar4 = Transform.Find(lVar4,"Tips",0)) == null)
                                    goto LAB_180a1bc3e;
                                    lVar4 = Component.GetComponent(lVar4,DAT_181d95578);
                                    lVar10 = FUN_18046c100(0);
                                    if (((lVar10 == null) || (*(int64 *)(lVar10 + 0x1c0) == 0)) ||
                                       ((lVar10 = FUN_180002f80(*(int64 *)(lVar10 + 0x1c0),
                                                                local_res8[0]), lVar10 == null ||
                                        (uVar7 = String.Concat("达成条件:\n",
                                                                *(uint64 *)(lVar10 + 40)),
                                        lVar4 == null)))) goto LAB_180a1bc3e;
                                    *(uint64 *)(lVar4 + 24) = uVar7;
                                  }
                                  local_res8[0] = local_res8[0] + 1;
                                  plVar3 = (int64 *)(uint64)local_res8[0];
                                } while( true );
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

    // Token : 0x6000A21
    // RVA   : 0xA1BC50   Offset: 0xA1B050   Length: 0x220
    public void UnshowAchMenu()
    {
        long lVar2;
        ulong uVar3;
        ulong uVar4;
        uint local_18;
        uint local_14;
        uint local_10;
        plVar1 = (int64 *)Resources.Load("Sound/SoundEffect/PaperQuick",0);
        plVar5 = (int64 *)0;
        if ((plVar1 != (int64 *)0) && (*plVar1 == DAT_181daf360)) {
          plVar5 = plVar1;
        }
        NGUITools.PlaySound(plVar5,0);
        if (this.achMenu != null) {
          lVar2 = GameObject.get_transform(this.achMenu,0);
          if (lVar2 != null) {
            lVar2 = Transform.Find(lVar2,"BlackBackground",0);
            if (lVar2 != null) {
              uVar3 = Component.GetComponent(lVar2,DAT_181d94478);
              uVar3 = DOTweenModuleUI.DOFade(uVar3,0,0x3e4ccccd,0);
              TweenSettingsExtensions.SetUpdate(uVar3,1,DAT_181dc1dc8);
              if (this.achMenu != null) {
                lVar2 = GameObject.get_transform(this.achMenu,0);
                if (lVar2 != null) {
                  uVar3 = Transform.Find(lVar2,"AchRoot",0);
                  local_18 = 0;
                  local_14 = 0x3f800000;
                  local_10 = 0x3f800000;
                  uVar3 = ShortcutExtensions.DOScale(uVar3,&local_18,0x3e4ccccd,0);
                  uVar3 = TweenSettingsExtensions.SetUpdate(uVar3,1,DAT_181dc1f60);
                  uVar4 = new OnTooltipCB(this,DAT_181d872e0,0);
                  TweenSettingsExtensions.OnComplete(uVar3,uVar4,DAT_181dc0380);
                  return;
                }
              }
            }
          }
        }
    }

    // Token : 0x6000A22
    // RVA   : 0x3A17B0   Offset: 0x3A0BB0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_18044ef50(this,0);
    }

    // Token : 0x6000A23
    // RVA   : 0x78D070   Offset: 0x78C470   Length: 0x20
    private void <UnshowAchMenu>b__10_0()
    {
        if (this.achMenu != null) {
          GameObject.SetActive(this.achMenu,0,0);
          return;
        }
    }

}
