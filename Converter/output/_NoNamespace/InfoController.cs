// ============================================================
// Type  : InfoController
// Token : 0x20002E6
// ============================================================

public class InfoController
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x40017E6
    public GameObject infoText;

    // Token: 0x40017E7
    public GameObject popInfoTabPrefab;

    // Token: 0x40017E8
    public GameObject rightPopInfoTabPrefab;

    // Token: 0x40017E9
    public GameObject popInfoList;

    // Token: 0x40017EA
    public GameObject rightPopInfoList;

    // Token: 0x40017EB
    private bool inited;

    // Token: 0x40017EC
    public List<MailData> newMailDatas;

    // Token: 0x40017ED
    public List<InfoData> newInfoDatas;

    // Token: 0x40017EE
    public List<InfoTabData> newInfoTabDatas;

    // Token: 0x40017EF
    private static InfoController _instance;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6001855
    // RVA   : 0xC98750   Offset: 0xC97B50   Length: 0x36
    public static InfoController get_Instance()
    {
        return **(uint64 **)(DAT_181d7f6c0 + 184);
    }

    // Token : 0x6001856
    // RVA   : 0xC97600   Offset: 0xC96A00   Length: 0x43
    private void Awake()
    {
        puVar1 = *(uint64 **)(DAT_181d7f6c0 + 184);
        *puVar1 = this;
        il2cpp_internal(puVar1,this);
    }

    // Token : 0x6001857
    // RVA   : 0xC983E0   Offset: 0xC977E0   Length: 0x262
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
        LAB_180c98546:
            lVar1 = this.newInfoDatas;
            if (lVar1 != null) {
              lVar6 = 32;
              if (lVar1.Count < 1) {
        LAB_180c985bd:
                lVar1 = this.newInfoTabDatas;
                if (lVar1 != null) {
                  if (lVar1.Count < 1) {
                    return;
                  }
                  do {
                    if (lVar1.Count <= (int)uVar5) {
                      FUN_1812fa020(lVar1,DAT_181d8e930);
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
                    FUN_1812fa020(lVar1,DAT_181d8e630);
                    goto LAB_180c985bd;
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
                FUN_1812fa020(lVar1,DAT_181d935a0);
                goto LAB_180c98546;
              }
              lVar1 = FUN_18046c0a0(0);
              if ((this.newMailDatas == null) ||
                 (uVar2 = FUN_180002f80(this.newMailDatas,iVar3,DAT_181d93820), lVar1 == null))
              break;
              GameController.GetNewMail(lVar1,uVar2,0,0);
              lVar1 = this.newMailDatas;
              iVar3 = iVar3 + 1;
            } while (lVar1 != null);
          }
        }
    }

    // Token : 0x6001858
    // RVA   : 0xC97170   Offset: 0xC96570   Length: 0x1BF
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
        lVar2 = il2cpp_internal(DAT_181d7f7c0);
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
          puVar3 = (uint32 *)FUN_180d995f0(&local_28,0);
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
            puVar3 = (uint32 *)FUN_1810d3b80(&local_28,0);
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
          FUN_18181e6b0(lVar1,lVar2,DAT_181d8e8b0);
          return;
        }
    }

    // Token : 0x6001859
    // RVA   : 0xC97890   Offset: 0xC96C90   Length: 0x7AF
    public void RealAddInfoTab(InfoTabData newInfoTab)
    {
        var pStatics_b4a8 = *(int64*)(DAT_181dab4a8 + 184);
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
        lVar2 = GameController.difficultyExtraPoint;
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
                    uVar4 = Component.GetComponent(lVar3,DAT_181d96178);
                    if (newInfoTab != null) {
                      uVar5 = *(uint64 *)(newInfoTab + 16);
                      uVar5 = GlobalData.ReplaceSpeString(uVar5,0xffffffff);
                      LTLocalization.SetText(uVar4,uVar5,0);
                      lVar3 = GameObject.get_transform(lVar2,0);
                      if (lVar3 != null) {
                        lVar3 = Transform.Find(lVar3,"Back",0);
                        lVar8 = GameController.difficultyExtraPoint;
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
                              TweenSettingsExtensions.SetEase(uVar4,15,DAT_181dc1128);
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
                                lVar3 = Component.GetComponent(lVar3,DAT_181d94478);
                                if (*pStatics_b4a8 == 0) throw; // [null/range check failed]
                                uVar4 = TextureController.LoadAtlasSprite
                                                  (*pStatics_b4a8,
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
                                plVar7 = (int64 *)Component.GetComponent(lVar3,DAT_181d94478);
                                if (plVar7 == (int64 *)0) throw; // [null/range check failed]
                                (**(code **)(*plVar7 + 0x408))(plVar7,*(uint64 *)(*plVar7 + 0x410));
                                lVar3 = GameObject.get_transform(lVar2,0);
                                if (lVar3 == null) throw; // [null/range check failed]
                                lVar3 = Transform.Find(lVar3,"Back",0);
                                if (lVar3 == null) throw; // [null/range check failed]
                                lVar3 = Transform.Find(lVar3,"Pic",0);
                                if (lVar3 == null) throw; // [null/range check failed]
                                lVar3 = Component.GetComponent(lVar3,DAT_181d94f78);
                                if (lVar3 == null) throw; // [null/range check failed]
                                uVar4 = RectTransform.get_sizeDelta(lVar3,0);
                                lVar8 = GameObject.get_transform(lVar2,0);
                                if (lVar8 == null) throw; // [null/range check failed]
                                lVar8 = Transform.Find(lVar8,"Back",0);
                                if (lVar8 == null) throw; // [null/range check failed]
                                lVar8 = Transform.Find(lVar8,"Pic",0);
                                if (lVar8 == null) throw; // [null/range check failed]
                                lVar8 = Component.GetComponent(lVar8,DAT_181d94f78);
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
                                plVar7 = (int64 *)Component.GetComponent(lVar3,DAT_181d94478);
                                if (plVar7 == (int64 *)0) throw; // [null/range check failed]
                                local_38 = *(uint32 *)(newInfoTab + 40);
                                uStack_34 = *(uint32 *)(newInfoTab + 44);
                                uStack_30 = *(uint32 *)(newInfoTab + 48);
                                uStack_2c = *(uint32 *)(newInfoTab + 52);
                                (**(code **)(*plVar7 + 0x2a8))
                                          (plVar7,&local_38,*(uint64 *)(*plVar7 + 0x2b0));
                              }
                              lVar2 = GameObject.GetComponent(lVar2,DAT_181d73228);
                              if (lVar2 != null) {
                                *(uint32 *)(lVar2 + 24) = *(uint32 *)(newInfoTab + 68);
                                uVar4 = String.Concat("Sound/SoundEffect/",*(uint64 *)(newInfoTab + 56),0);
                                plVar7 = (int64 *)Resources.Load(uVar4,0);
                                uVar10 = *(uint32 *)(newInfoTab + 64);
                                plVar9 = (int64 *)0;
                                if ((plVar7 != (int64 *)0) && (*plVar7 == DAT_181daf360)) {
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

    // Token : 0x600185A
    // RVA   : 0xC97390   Offset: 0xC96790   Length: 0x202
    public void AddInfo(InfoType type, string text)
    {
        if (this.newInfoDatas != null) {
          FUN_18181e6b0(this.newInfoDatas,type,DAT_181d8e5b0);
          return;
        }
    }

    // Token : 0x600185B
    // RVA   : 0xC97330   Offset: 0xC96730   Length: 0x53
    public void AddInfo(InfoData newInfo)
    {
        if (this.newInfoDatas != null) {
          FUN_18181e6b0(this.newInfoDatas,newInfo,DAT_181d8e5b0);
          return;
        }
    }

    // Token : 0x600185C
    // RVA   : 0xC98040   Offset: 0xC97440   Length: 0x397
    public void RealAddInfo(InfoData newInfo)
    {
        int iVar1;
        long lVar2;
        long lVar3;
        long lVar4;
        while( true ) {
          if (((GameController._instance == null) ||
              (lVar4 = GameController._instance.worldData) == null) ||
             (lVar4 = lVar4.infos) == null) throw; // [null/range check failed]
          iVar1 = lVar4.cityAreaID;
          if (iVar1 < **(int **)(DAT_181d7f840 + 184)) break;
          lVar4 = FUN_18046c0a0(0);
          if (((lVar4 == null) || (lVar4.villageAreaID == null)) ||
             (lVar4 = *(int64 *)(lVar4.villageAreaID + 208)) == null) throw; // [null/range check failed]
          FUN_181823ba0(lVar4,0,DAT_181d8e6b0);
        }
        if (((GameController._instance != null) &&
            (lVar4 = GameController._instance.worldData) != null) &&
           (lVar4 = lVar4.infos) != null) {
          FUN_18181e6b0(lVar4,newInfo,DAT_181d8e5b0);
          if (this.infoText != null) {
            lVar4 = GameObject.GetComponent(this.infoText,DAT_181d71f08);
            if ((GameController._instance != null) &&
               (lVar2 = GameController._instance.worldData) != null) {
              lVar2 = lVar2.infos;
              if ((((GameController._instance != null) &&
                   (lVar3 = GameController._instance.worldData) != null) &&
                  (lVar3 = lVar3.infos) != null) && (lVar2 != null)) {
                iVar1 = lVar3.cityAreaID;
                if (lVar2.cityAreaID <= iVar1 - 1U) {
                  ThrowHelper.ThrowArgumentOutOfRangeException(0);
                }
                if ((lVar4 != null) &&
                   (lVar2 = *(int64 *)(lVar2.chapter + 24 + (int64)iVar1 * 8),
                   lVar2 != null)) {
                  InfoTextList.Add(lVar4,lVar2.chapter,lVar2.cityAreaID,
                                    lVar2.villageAreaID,1,0);
                  return;
                }
              }
            }
          }
        }
    }

    // Token : 0x600185D
    // RVA   : 0xC975A0   Offset: 0xC969A0   Length: 0x53
    public void AddMail(MailData newMail)
    {
        if (this.newMailDatas != null) {
          FUN_18181e6b0(this.newMailDatas,newMail,DAT_181d93520);
          return;
        }
    }

    // Token : 0x600185E
    // RVA   : 0xC97650   Offset: 0xC96A50   Length: 0x237
    public void BuildInfoList()
    {
        long lVar1;
        long lVar2;
        int iVar3;
        if (this.infoText != null) {
          lVar1 = GameObject.GetComponent(this.infoText,DAT_181d71f08);
          if (lVar1 != null) {
            lVar1 = InfoTextList.get_paragraphs(lVar1,0);
            if (lVar1 != null) {
              BetterList_1.Clear(lVar1,DAT_181da76d0);
              iVar3 = 0;
              while( true ) {
                if (((GameController._instance == null) ||
                    (lVar1 = GameController._instance.worldData) == null) ||
                   (lVar1 = lVar1.infos) == null) throw; // [null/range check failed]
                lVar2 = this.infoText;
                if (lVar1.cityAreaID <= iVar3) break;
                if (lVar2 == null) throw; // [null/range check failed]
                lVar1 = GameObject.GetComponent(lVar2,DAT_181d71f08);
                lVar2 = FUN_18046c0a0(0);
                if (((lVar2 == null) || (*(int64 *)(lVar2 + 32) == 0)) ||
                   (lVar2 = *(int64 *)(*(int64 *)(lVar2 + 32) + 208)) == null)
                throw; // [null/range check failed]
                lVar2 = FUN_180002f80(lVar2,iVar3,DAT_181d8e7b0);
                if ((lVar1 == null) || (lVar2 == null)) throw; // [null/range check failed]
                InfoTextList.Add(lVar1,*(uint32 *)(lVar2 + 16),*(uint64 *)(lVar2 + 24),
                                  *(uint64 *)(lVar2 + 32),1,0);
                iVar3 = iVar3 + 1;
              }
              if (lVar2 != null) {
                lVar1 = GameObject.GetComponent(lVar2,DAT_181d71f08);
                if (lVar1 != null) {
                  lVar1.Forces = 1;
                  return;
                }
              }
            }
          }
        }
    }

    // Token : 0x600185F
    // RVA   : 0xC98650   Offset: 0xC97A50   Length: 0x100
    public void /*ctor*/()
    {
        ulong uVar1;
        uVar1 = il2cpp_internal(DAT_181d94868);
        FUN_181330100(uVar1,DAT_181d934a0);
        this.newMailDatas = uVar1;
        uVar1 = il2cpp_internal(DAT_181d93ae8);
        FUN_181330100(uVar1,DAT_181d8e530);
        this.newInfoDatas = uVar1;
        uVar1 = il2cpp_internal(DAT_181d93b68);
        FUN_181330100(uVar1,DAT_181d8e830);
        this.newInfoTabDatas = uVar1;
        FUN_18044ef50(this,0);
    }

}
