// ============================================================
// Type  : InfoController
// Token : 0x20002E0
// ============================================================

public class InfoController
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001732
    public GameObject infoText;

    // Token: 0x4001733
    public GameObject popInfoTabPrefab;

    // Token: 0x4001734
    public GameObject rightPopInfoTabPrefab;

    // Token: 0x4001735
    public GameObject popInfoList;

    // Token: 0x4001736
    public GameObject rightPopInfoList;

    // Token: 0x4001737
    private bool inited;

    // Token: 0x4001738
    public List<MailData> newMailDatas;

    // Token: 0x4001739
    public List<InfoData> newInfoDatas;

    // Token: 0x400173A
    public List<InfoTabData> newInfoTabDatas;

    // Token: 0x400173B
    private static InfoController _instance;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6001811
    // RVA   : 0xB6E340   Offset: 0xB6CB40   Length: 0x36
    public static InfoController get_Instance()
    {
        return **(uint64 **)(DAT_181d5a578 + 184);
    }

    // Token : 0x6001812
    // RVA   : 0xB6D210   Offset: 0xB6BA10   Length: 0x43
    private void Awake()
    {
        puVar1 = *(uint64 **)(DAT_181d5a578 + 184);
        *puVar1 = this;
        il2cpp_internal(puVar1,this);
    }

    // Token : 0x6001813
    // RVA   : 0xB6DFD0   Offset: 0xB6C7D0   Length: 0x262
    private void Update()
    {
        long lVar1;
        ulong uVar2;
        int iVar3;
        uint uVar4;
        uint uVar5;
        long lVar6;
        long lVar7;
        if (!this.inited) {
          this.inited = 1;
          InfoController.BuildInfoList(this,0);
        }
        lVar1 = this.newMailDatas;
        if (lVar1 != null) {
          uVar5 = 0;
          if (lVar1.Count < 1) {
        LAB_180b6e136:
            lVar1 = this.newInfoDatas;
            if (lVar1 != null) {
              lVar6 = 32;
              if (lVar1.Count < 1) {
        LAB_180b6e1ad:
                lVar1 = this.newInfoTabDatas;
                if (lVar1 != null) {
                  if (lVar1.Count < 1) {
                    return;
                  }
                  do {
                    if (lVar1.Count <= (int)uVar5) {
                      FUN_180f56130(lVar1,DAT_181d67178);
                      return;
                    }
                    if (lVar1 == null) break;
                    if (lVar1.Count <= uVar5) {
                      ThrowHelper.ThrowArgumentOutOfRangeException(0);
                    }
                    InfoController.RealAddInfoTab
                              (this,*(uint64 *)(lVar1._items + lVar6),0);
                    lVar1 = this.newInfoTabDatas;
                    uVar5 = uVar5 + 1;
                    lVar6 = lVar6 + 8;
                  } while (lVar1 != null);
                }
              }
              else {
                uVar4 = 0;
                lVar7 = 32;
                do {
                  if (lVar1.Count <= (int)uVar4) {
                    FUN_180f56130(lVar1,DAT_181d66e78);
                    goto LAB_180b6e1ad;
                  }
                  if (lVar1 == null) break;
                  if (lVar1.Count <= uVar4) {
                    ThrowHelper.ThrowArgumentOutOfRangeException(0);
                  }
                  InfoController.RealAddInfo
                            (this,*(uint64 *)(lVar1._items + lVar7));
                  lVar1 = this.newInfoDatas;
                  uVar4 = uVar4 + 1;
                  lVar7 = lVar7 + 8;
                } while (lVar1 != null);
              }
            }
          }
          else {
            iVar3 = 0;
            do {
              if (lVar1.Count <= iVar3) {
                FUN_180f56130(lVar1,DAT_181d6bde8);
                goto LAB_180b6e136;
              }
              lVar1 = FUN_18046c0a0(0);
              if ((this.newMailDatas == null) ||
                 (uVar2 = FUN_180002f80(this.newMailDatas,iVar3,DAT_181d6c068), lVar1 == null))
              break;
              GameController.GetNewMail(lVar1,uVar2,0,0);
              lVar1 = this.newMailDatas;
              iVar3 = iVar3 + 1;
            } while (lVar1 != null);
          }
        }
    }

    // Token : 0x6001814
    // RVA   : 0xB6CD80   Offset: 0xB6B580   Length: 0x1BF
    public void AddInfoTab(string infoText, string atlasName, string infoPic, string soundName, float volumn, float lastTime, Color picColor)
    {
        void InfoController.AddInfoTab
                     (int64 this,uint64 infoText,uint64 atlasName,int64 infoPic,
                     uint64 soundName,uint32 volumn,uint32 lastTime,uint32 *picColor)
        {
        int64 lVar1;
        int64 lVar2;
        uint32 *puVar3;
        uint32 uVar4;
        uint32 uVar5;
        uint32 uVar6;
        char cVar7;
        uint32 local_38;
        uint32 uStack_34;
        uint32 uStack_30;
        uint32 uStack_2c;
        uint32 local_28;
        uint32 uStack_24;
        uint32 uStack_20;
        uint32 uStack_1c;
        lVar1 = this.newInfoTabDatas;
        lVar2 = il2cpp_internal(DAT_181d5a678);
        *(uint64 *)(lVar2 + 24) = "UIAtlas";
        *(uint64 *)(lVar2 + 56) = "Woosh";
        *(uint32 *)(lVar2 + 64) = 0x3f800000;
        *(uint32 *)(lVar2 + 68) = 0x40a00000;
        ZhSegment.Initialize(lVar2,0);
        *(uint64 *)(lVar2 + 16) = infoText;
        *(uint64 *)(lVar2 + 24) = atlasName;
        *(int64 *)(lVar2 + 32) = infoPic;
        *(uint64 *)(lVar2 + 56) = soundName;
        *(uint32 *)(lVar2 + 64) = volumn;
        *(uint32 *)(lVar2 + 68) = lastTime;
        uVar4 = picColor[1];
        uVar5 = picColor[2];
        uVar6 = picColor[3];
        *(uint32 *)(lVar2 + 40) = *picColor;
        *(uint32 *)(lVar2 + 44) = uVar4;
        *(uint32 *)(lVar2 + 48) = uVar5;
        *(uint32 *)(lVar2 + 52) = uVar6;
        if (infoPic != null) {
          puVar3 = (uint32 *)FUN_180d904c0(&local_28,0);
          local_28 = *picColor;
          uStack_24 = picColor[1];
          uStack_20 = picColor[2];
          uStack_1c = picColor[3];
          local_38 = *puVar3;
          uStack_34 = puVar3[1];
          uStack_30 = puVar3[2];
          uStack_2c = puVar3[3];
          cVar7 = Color.op_Equality(&local_28,&local_38,0);
          if (cVar7) {
            puVar3 = (uint32 *)FUN_181098a50(&local_28,0);
            uVar4 = puVar3[1];
            uVar5 = puVar3[2];
            uVar6 = puVar3[3];
            *(uint32 *)(lVar2 + 40) = *puVar3;
            *(uint32 *)(lVar2 + 44) = uVar4;
            *(uint32 *)(lVar2 + 48) = uVar5;
            *(uint32 *)(lVar2 + 52) = uVar6;
          }
        }
        if (lVar1 != null) {
          FUN_181827900(lVar1,lVar2,DAT_181d670f8);
          return;
        }
    }

    // Token : 0x6001815
    // RVA   : 0xB6D4A0   Offset: 0xB6BCA0   Length: 0x782
    public void RealAddInfoTab(InfoTabData newInfoTab)
    {
        var pStatics_6270 = *(int64*)(DAT_181d86270 + 184);
        var pStatics_e010 = *(int64*)(DAT_181d4e010 + 184);
        int iVar1;
        long lVar2;
        long lVar3;
        ulong uVar4;
        ulong uVar5;
        long lVar8;
        uint uVar10;
        float fVar11;
        float local_res20;
        float fStackX_24;
        uint local_48;
        uint uStack_44;
        uint uStack_40;
        uint local_38;
        uint uStack_34;
        uint uStack_30;
        uint32 uStack_2c;
        uint64 local_28;
        uint64 uStack_20;
        local_28 = 0;
        uStack_20 = 0;
        lVar2 = *(int64 *)(pStatics_e010 + 8);
        if ((lVar2 != null) && (lVar2 = *(int64 *)(lVar2 + 16)) != null) {
          iVar1 = PlayerPrefDictionary.GetInt(lVar2,"RightPopInfo",0);
          if (iVar1 == 1) {
            uVar4 = this.rightPopInfoList;
            uVar5 = this.rightPopInfoTabPrefab;
          }
          else {
            uVar4 = this.popInfoList;
            uVar5 = this.popInfoTabPrefab;
          }
          lVar2 = GlobalData.AddChild(uVar4,uVar5,0);
          if (lVar2 != null) {
            lVar3 = GameObject.get_transform(lVar2,0);
            if (lVar3 != null) {
              Transform.SetAsFirstSibling(lVar3,0);
              lVar3 = GameObject.get_transform(lVar2,0);
              if (lVar3 != null) {
                lVar3 = Transform.Find(lVar3,"Back",0);
                if (lVar3 != null) {
                  lVar3 = Transform.Find(lVar3,"Text",0);
                  if (lVar3 != null) {
                    uVar4 = Component.GetComponent(lVar3,DAT_181d6d8c0);
                    if (newInfoTab != null) {
                      uVar5 = *(uint64 *)(newInfoTab + 16);
                      uVar5 = GlobalData.ReplaceSpeString(uVar5,0xffffffff);
                      LTLocalization.SetText(uVar4,uVar5,0);
                      lVar3 = GameObject.get_transform(lVar2,0);
                      if (lVar3 != null) {
                        lVar3 = Transform.Find(lVar3,"Back",0);
                        lVar8 = *(int64 *)(pStatics_e010 + 8);
                        if ((lVar8 != null) && (lVar8 = *(int64 *)(lVar8 + 16)) != null) {
                          iVar1 = PlayerPrefDictionary.GetInt(lVar8,"RightPopInfo",0);
                          if (iVar1 == 1) {
                            uVar10 = 0x43fa0000;
                          }
                          else {
                            uVar10 = 0xc3fa0000;
                          }
                          if (lVar3 != null) {
                            uStack_44 = 0;
                            uStack_40 = 0;
                            local_48 = uVar10;
                            Transform.set_localPosition(lVar3,&local_48,0);
                            lVar3 = GameObject.get_transform(lVar2,0);
                            if (lVar3 != null) {
                              uVar4 = Transform.Find(lVar3,"Back",0);
                              puVar6 = (uint64 *)Vector3.get_zero(&local_38,0);
                              uStack_40 = *(uint32 *)(puVar6 + 1);
                              local_48 = (uint32)*puVar6;
                              uStack_44 = (uint32)((uint64)*puVar6 >> 32);
                              uVar4 = ShortcutExtensions.DOLocalMove(uVar4,&local_48,0x3e800000,0,0);
                              TweenSettingsExtensions.SetEase(uVar4,15,DAT_181d97ca8);
                              if (*(int64 *)(newInfoTab + 32) != 0) {
                                lVar3 = GameObject.get_transform(lVar2,0);
                                if (lVar3 == null) throw; // [null/range check failed]
                                lVar3 = Transform.Find(lVar3,"Back",0);
                                if (lVar3 == null) throw; // [null/range check failed]
                                lVar3 = Transform.Find(lVar3,"Pic",0);
                                if (lVar3 == null) throw; // [null/range check failed]
                                lVar3 = Component.get_gameObject(lVar3,0);
                                if (lVar3 == null) throw; // [null/range check failed]
                                GameObject.SetActive(lVar3,1,0);
                                lVar3 = GameObject.get_transform(lVar2,0);
                                if (lVar3 == null) throw; // [null/range check failed]
                                lVar3 = Transform.Find(lVar3,"Back",0);
                                if (lVar3 == null) throw; // [null/range check failed]
                                lVar3 = Transform.Find(lVar3,"Pic",0);
                                if (lVar3 == null) throw; // [null/range check failed]
                                lVar3 = Component.GetComponent(lVar3,DAT_181d6bc40);
                                if (*pStatics_6270 == 0) throw; // [null/range check failed]
                                uVar4 = TextureController.LoadAtlasSprite
                                                  (*pStatics_6270,
                                                   *(uint64 *)(newInfoTab + 24),
                                                   *(uint64 *)(newInfoTab + 32),0);
                                if (lVar3 == null) throw; // [null/range check failed]
                                Image.set_sprite(lVar3,uVar4,0);
                                lVar3 = GameObject.get_transform(lVar2,0);
                                if (lVar3 == null) throw; // [null/range check failed]
                                lVar3 = Transform.Find(lVar3,"Back",0);
                                if (lVar3 == null) throw; // [null/range check failed]
                                lVar3 = Transform.Find(lVar3,"Pic",0);
                                if (lVar3 == null) throw; // [null/range check failed]
                                plVar7 = (int64 *)Component.GetComponent(lVar3,DAT_181d6bc40);
                                if (plVar7 == (int64 *)0) throw; // [null/range check failed]
                                (**(code **)(*plVar7 + 0x408))(plVar7,*(uint64 *)(*plVar7 + 0x410));
                                lVar3 = GameObject.get_transform(lVar2,0);
                                if (lVar3 == null) throw; // [null/range check failed]
                                lVar3 = Transform.Find(lVar3,"Back",0);
                                if (lVar3 == null) throw; // [null/range check failed]
                                lVar3 = Transform.Find(lVar3,"Pic",0);
                                if (lVar3 == null) throw; // [null/range check failed]
                                lVar3 = Component.GetComponent(lVar3,DAT_181d6c740);
                                if (lVar3 == null) throw; // [null/range check failed]
                                uVar4 = RectTransform.get_sizeDelta(lVar3,0);
                                lVar8 = GameObject.get_transform(lVar2,0);
                                if (lVar8 == null) throw; // [null/range check failed]
                                lVar8 = Transform.Find(lVar8,"Back",0);
                                if (lVar8 == null) throw; // [null/range check failed]
                                lVar8 = Transform.Find(lVar8,"Pic",0);
                                if (lVar8 == null) throw; // [null/range check failed]
                                lVar8 = Component.GetComponent(lVar8,DAT_181d6c740);
                                if (lVar8 == null) throw; // [null/range check failed]
                                puVar6 = (uint64 *)RectTransform.get_rect(&local_38,lVar8,0);
                                local_28 = *puVar6;
                                uStack_20 = puVar6[1];
                                fVar11 = (float)FUN_18044e2b0(&local_28,0);
                                fStackX_24 = (float)((uint64)uVar4 >> 32);
                                local_res20 = (float)uVar4;
                                RectTransform.set_sizeDelta
                                          (lVar3,CONCAT44(fStackX_24 * (30.0 / fVar11),
                                                          local_res20 * (30.0 / fVar11)),0);
                                lVar3 = GameObject.get_transform(lVar2,0);
                                if (lVar3 == null) throw; // [null/range check failed]
                                lVar3 = Transform.Find(lVar3,"Back",0);
                                if (lVar3 == null) throw; // [null/range check failed]
                                lVar3 = Transform.Find(lVar3,"Pic",0);
                                if (lVar3 == null) throw; // [null/range check failed]
                                plVar7 = (int64 *)Component.GetComponent(lVar3,DAT_181d6bc40);
                                if (plVar7 == (int64 *)0) throw; // [null/range check failed]
                                local_38 = *(uint32 *)(newInfoTab + 40);
                                uStack_34 = *(uint32 *)(newInfoTab + 44);
                                uStack_30 = *(uint32 *)(newInfoTab + 48);
                                uStack_2c = *(uint32 *)(newInfoTab + 52);
                                (**(code **)(*plVar7 + 0x2a8))
                                          (plVar7,&local_38,*(uint64 *)(*plVar7 + 0x2b0));
                              }
                              lVar2 = GameObject.GetComponent(lVar2,DAT_181da10b0);
                              if (lVar2 != null) {
                                *(uint32 *)(lVar2 + 24) = *(uint32 *)(newInfoTab + 68);
                                uVar4 = String.Concat("Sound/SoundEffect/",*(uint64 *)(newInfoTab + 56),0);
                                plVar7 = (int64 *)Resources.Load(uVar4,0);
                                uVar10 = *(uint32 *)(newInfoTab + 64);
                                plVar9 = (int64 *)0;
                                if ((plVar7 != (int64 *)0) && (*plVar7 == DAT_181d8a228)) {
                                  plVar9 = plVar7;
                                }
                                NGUITools.PlaySound(plVar9,uVar10,0);
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

    // Token : 0x6001816
    // RVA   : 0xB6CFA0   Offset: 0xB6B7A0   Length: 0x202
    public void AddInfo(InfoType type, string text)
    {
        if (this.newInfoDatas != null) {
          FUN_181827900(this.newInfoDatas,type,DAT_181d66df8);
          return;
        }
    }

    // Token : 0x6001817
    // RVA   : 0xB6CF40   Offset: 0xB6B740   Length: 0x53
    public void AddInfo(InfoData newInfo)
    {
        if (this.newInfoDatas != null) {
          FUN_181827900(this.newInfoDatas,newInfo,DAT_181d66df8);
          return;
        }
    }

    // Token : 0x6001818
    // RVA   : 0xB6DC30   Offset: 0xB6C430   Length: 0x397
    public void RealAddInfo(InfoData newInfo)
    {
        var pStatics = *(int64*)(DAT_181d4df90 + 184);
        int iVar1;
        long lVar2;
        long lVar3;
        long lVar4;
        while( true ) {
          if (((*pStatics == 0) ||
              (lVar4 = *(int64 *)(*pStatics + 32)) == null) ||
             (lVar4 = *(int64 *)(lVar4 + 208)) == null) throw; // [null/range check failed]
          iVar1 = *(int *)(lVar4 + 24);
          if (iVar1 < **(int **)(DAT_181d5a6f8 + 184)) break;
          lVar4 = FUN_18046c0a0(0);
          if (((lVar4 == null) || (*(int64 *)(lVar4 + 32) == 0)) ||
             (lVar4 = *(int64 *)(*(int64 *)(lVar4 + 32) + 208)) == null) throw; // [null/range check failed]
          FUN_18182b220(lVar4,0,DAT_181d66ef8);
        }
        if (((*pStatics != 0) &&
            (lVar4 = *(int64 *)(*pStatics + 32)) != null) &&
           (lVar4 = *(int64 *)(lVar4 + 208)) != null) {
          FUN_181827900(lVar4,newInfo,DAT_181d66df8);
          if (this.infoText != null) {
            lVar4 = GameObject.GetComponent(this.infoText,DAT_181d9fed8);
            if ((*pStatics != 0) &&
               (lVar2 = *(int64 *)(*pStatics + 32)) != null) {
              lVar2 = *(int64 *)(lVar2 + 208);
              if ((((*pStatics != 0) &&
                   (lVar3 = *(int64 *)(*pStatics + 32)) != null) &&
                  (lVar3 = *(int64 *)(lVar3 + 208)) != null) && (lVar2 != null)) {
                iVar1 = *(int *)(lVar3 + 24);
                if (*(uint32 *)(lVar2 + 24) <= iVar1 - 1U) {
                  ThrowHelper.ThrowArgumentOutOfRangeException(0);
                }
                if ((lVar4 != null) &&
                   (lVar2 = *(int64 *)(*(int64 *)(lVar2 + 16) + 24 + (int64)iVar1 * 8),
                   lVar2 != null)) {
                  InfoTextList.Add(lVar4,*(uint32 *)(lVar2 + 16),*(uint64 *)(lVar2 + 24),
                                    *(uint64 *)(lVar2 + 32),1,0);
                  return;
                }
              }
            }
          }
        }
    }

    // Token : 0x6001819
    // RVA   : 0xB6D1B0   Offset: 0xB6B9B0   Length: 0x53
    public void AddMail(MailData newMail)
    {
        if (this.newMailDatas != null) {
          FUN_181827900(this.newMailDatas,newMail,DAT_181d6bd68);
          return;
        }
    }

    // Token : 0x600181A
    // RVA   : 0xB6D260   Offset: 0xB6BA60   Length: 0x237
    public void BuildInfoList()
    {
        var pStatics = *(int64*)(DAT_181d4df90 + 184);
        long lVar1;
        long lVar2;
        int iVar3;
        if (this.infoText != null) {
          lVar1 = GameObject.GetComponent(this.infoText,DAT_181d9fed8);
          if (lVar1 != null) {
            lVar1 = InfoTextList.get_paragraphs(lVar1,0);
            if (lVar1 != null) {
              BetterList_1.Clear(lVar1,DAT_181d82318);
              iVar3 = 0;
              while( true ) {
                if (((*pStatics == 0) ||
                    (lVar1 = *(int64 *)(*pStatics + 32)) == null) ||
                   (lVar1 = *(int64 *)(lVar1 + 208)) == null) throw; // [null/range check failed]
                lVar2 = this.infoText;
                if (*(int *)(lVar1 + 24) <= iVar3) break;
                if (lVar2 == null) throw; // [null/range check failed]
                lVar1 = GameObject.GetComponent(lVar2,DAT_181d9fed8);
                lVar2 = FUN_18046c0a0(0);
                if (((lVar2 == null) || (*(int64 *)(lVar2 + 32) == 0)) ||
                   (lVar2 = *(int64 *)(*(int64 *)(lVar2 + 32) + 208)) == null)
                throw; // [null/range check failed]
                lVar2 = FUN_180002f80(lVar2,iVar3,DAT_181d66ff8);
                if ((lVar1 == null) || (lVar2 == null)) throw; // [null/range check failed]
                InfoTextList.Add(lVar1,*(uint32 *)(lVar2 + 16),*(uint64 *)(lVar2 + 24),
                                  *(uint64 *)(lVar2 + 32),1,0);
                iVar3 = iVar3 + 1;
              }
              if (lVar2 != null) {
                lVar1 = GameObject.GetComponent(lVar2,DAT_181d9fed8);
                if (lVar1 != null) {
                  *(uint8 *)(lVar1 + 72) = 1;
                  return;
                }
              }
            }
          }
        }
    }

    // Token : 0x600181B
    // RVA   : 0xB6E240   Offset: 0xB6CA40   Length: 0x100
    public void /*ctor*/()
    {
        ulong uVar1;
        uVar1 = il2cpp_internal(DAT_181d6fbb0);
        FUN_180f58a90(uVar1,DAT_181d6bce8);
        this.newMailDatas = uVar1;
        uVar1 = il2cpp_internal(DAT_181d6ee30);
        FUN_180f58a90(uVar1,DAT_181d66d78);
        this.newInfoDatas = uVar1;
        uVar1 = il2cpp_internal(DAT_181d6eeb0);
        FUN_180f58a90(uVar1,DAT_181d67078);
        this.newInfoTabDatas = uVar1;
        FUN_18044ef50(this,0);
    }

}
