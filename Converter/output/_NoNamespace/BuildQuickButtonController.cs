// ============================================================
// Type  : BuildQuickButtonController
// Token : 0x20001B0
// ============================================================

public class BuildQuickButtonController
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4000BC6
    public AreaBuildingData targetBuildingData;

    // Token: 0x4000BC7
    public Image missionTarget;

    // Token: 0x4000BC8
    private bool onHover;

    // Token: 0x4000BC9
    private float hoverTime;

    // Token: 0x4000BCA
    private float refreshTime;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000DCB
    // RVA   : 0x918ED0   Offset: 0x917CD0   Length: 0x26B
    private void Update()
    {
        var pStatics = *(int64*)(DAT_181e8b8e8 + 184);
        long lVar2;
        ulong uVar3;
        float fVar5;
        float fVar6;
        uint local_28;
        uint uStack_24;
        uint uStack_20;
        uint32 uStack_1c;
        if (this.targetBuildingData != null) {
          fVar6 = this.refreshTime;
          fVar5 = (float)Time.get_deltaTime(0);
          fVar6 = fVar6 - fVar5;
          this.refreshTime = fVar6;
          if (fVar6 <= 0.0) {
            lVar2 = this.targetBuildingData;
            this.refreshTime = 0x3e4ccccd;
            if (lVar2 == null) goto LAB_180919136;
            plVar4 = this.missionTarget;
            if (lVar2.plotNumCount < 1) {
              if (lVar2.missionNumCount < 1) {
                puVar1 = (uint32 *)FUN_180af4e90(&local_28,0);
              }
              else {
                lVar2 = FUN_180210d00(0);
                if ((lVar2 == null) ||
                   (uVar3 = TextureController.LoadAtlasSprite(lVar2,"UIAtlas","任务目标",0),
                   plVar4 == (int64 *)0)) goto LAB_180919136;
                Image.set_sprite(plVar4,uVar3,0);
                plVar4 = this.missionTarget;
                puVar1 = (uint32 *)FUN_180f24d00(&local_28,0);
              }
            }
            else {
              if ((*pStatics == 0) ||
                 (uVar3 = TextureController.LoadAtlasSprite
                                    (*pStatics,"UIAtlas","问号",0),
                 plVar4 == (int64 *)0)) goto LAB_180919136;
              Image.set_sprite(plVar4,uVar3,0);
              plVar4 = this.missionTarget;
              puVar1 = (uint32 *)Color.get_yellow(&local_28,0);
            }
            if (plVar4 == (int64 *)0) goto LAB_180919136;
            local_28 = *puVar1;
            uStack_24 = puVar1[1];
            uStack_20 = puVar1[2];
            uStack_1c = puVar1[3];
            (**(code **)(*plVar4 + 0x2a8))(plVar4,&local_28,*(uint64 *)(*plVar4 + 0x2b0));
          }
          if (this.onHover) {
            fVar6 = this.hoverTime;
            fVar5 = (float)Time.get_deltaTime(0);
            fVar5 = fVar5 + fVar6;
            this.hoverTime = fVar5;
            if (0.3 <= fVar5) {
              lVar2 = FUN_180210060(0);
              uVar3 = BuildQuickButtonController.BuildingObj(this,0);
              if (lVar2 != null) {
                AreaController.FocusOnTarget
                          (lVar2,uVar3,*(uint32 *)(*(int64 *)(DAT_181e8c8b0 + 184) + 20),0);
                lVar2 = BuildQuickButtonController.BuildingObj(this,0);
                if ((lVar2 != null) && (lVar2 = GameObject.GetComponent(lVar2,DAT_181e53100)) != null) {
                  lVar2.enemyMonth = 1;
                  return;
                }
              }
        LAB_180919136:
                          // WARNING: Subroutine does not return
              FUN_1801e0300();
            }
          }
        }
    }

    // Token : 0x6000DCC
    // RVA   : 0x9185D0   Offset: 0x9173D0   Length: 0x239
    public void OnClick()
    {
        ulong uVar1;
        long lVar3;
        long lVar4;
        ulong local_28;
        uint local_20;
        byte[] local_18 = new byte[16];
        lVar3 = *(int64 *)(*(int64 *)(DAT_181e8c5b8 + 184) + 16);
        if (lVar3 != null) {
          if (*(char *)(lVar3 + 48) != false) {
            plVar2 = (int64 *)Resources.Load("Sound/SoundEffect/WrongClick",0);
            plVar6 = (int64 *)0;
            if ((plVar2 != (int64 *)0) && (*plVar2 == DAT_181e8f4a0)) {
              plVar6 = plVar2;
            }
            NGUITools.PlaySound(plVar6,0);
            return;
          }
          if (this.targetBuildingData == null) {
            lVar3 = FUN_180210060(0);
            if (lVar3 != null) {
              AreaController.ReturnBigMapButtonClicked(lVar3,0);
              return;
            }
          }
          else {
            lVar3 = FUN_1802102e0(0);
            uVar1 = this.targetBuildingData;
            lVar4 = BuildQuickButtonController.BuildingObj(this,0);
            if (lVar4 != null) {
              lVar4 = GameObject.get_transform(lVar4,0);
              if (lVar4 != null) {
                puVar5 = (uint64 *)Transform.get_position(local_18,lVar4,0);
                if (lVar3 != null) {
                  local_28 = *puVar5;
                  local_20 = *(uint32 *)(puVar5 + 1);
                  BuildingUIController.EnterBuilding(lVar3,uVar1,&local_28,0);
                  return;
                }
              }
            }
          }
        }
    }

    // Token : 0x6000DCD
    // RVA   : 0x918810   Offset: 0x917610   Length: 0xC
    public void OnPointerEnter()
    {
        void FUN_180918810(int64 this)
        {
        if (this.targetBuildingData != null) {
          this.onHover = 1;
        }
    }

    // Token : 0x6000DCE
    // RVA   : 0x918820   Offset: 0x917620   Length: 0x69
    public void OnPointerExit()
    {
        long lVar1;
        if (this.targetBuildingData == null) {
          return;
        }
        this.onHover = 0;
        this.hoverTime = 0;
        lVar1 = BuildQuickButtonController.BuildingObj(this,0);
        if ((lVar1 != null) && (lVar1 = GameObject.GetComponent(lVar1,DAT_181e53100)) != null) {
          *(uint8 *)(lVar1 + 80) = 0;
          return;
        }
    }

    // Token : 0x6000DCF
    // RVA   : 0x918510   Offset: 0x917310   Length: 0xB7
    public GameObject BuildingObj()
    {
        long lVar1;
        lVar1 = *(int64 *)(*(int64 *)(DAT_181e8c8b0 + 184) + 56);
        if (lVar1 != null) {
          AreaController.GetBuildingObj(lVar1,this.targetBuildingData,0);
          return;
        }
    }

    // Token : 0x6000DD0
    // RVA   : 0x918890   Offset: 0x917690   Length: 0x63C
    public void RefreshBuildingChoiceInfo()
    {
        uint uVar2;
        bool cVar3;
        byte uVar4;
        long lVar5;
        ulong uVar6;
        ulong uVar7;
        long lVar8;
        ulong uVar9;
        uint uVar10;
        long lVar11;
        uint[] local_res18 = new uint[2];
        ulong local_res20;
        lVar5 = Component.GetComponent(this,DAT_181e788b8);
        if (lVar5 != null) {
          lVar5.buildTimeLeft = "";
          if (this.targetBuildingData == null) {
            return;
          }
          lVar5 = Component.get_transform(this,0);
          if (((lVar5 != null) && (lVar5 = Transform.Find(lVar5,"LvBack",0)) != null) &&
             (lVar5 = Transform.Find(lVar5,"Lv",0)) != null) {
            uVar6 = Component.GetComponent(lVar5,DAT_181e79538);
            if (this.targetBuildingData != null) {
              uVar2 = this.targetBuildingData.lv;
              uVar7 = GlobalData.GetNumText(uVar2,0);
              LTLocalization.SetText(uVar6,uVar7,0);
              if (this.targetBuildingData != null) {
                cVar3 = AreaBuildingData.BuildingAvailable(this.targetBuildingData,0);
                if (!cVar3) {
                  lVar5 = Component.GetComponent(this,DAT_181e788b8);
                  uVar6 = *(uint64 *)(*(int64 *)(DAT_181e538e8 + 184) + 0x2d8);
                  if (this.targetBuildingData == null) {
        LAB_180918ec7:
                          // WARNING: Subroutine does not return
                    FUN_1801e0300();
                  }
                  local_res18[0] = this.targetBuildingData.enemyMonth;
                  uVar7 = il2cpp_value_box(DAT_181e60808,local_res18);
                  uVar6 = String.Format("{0}禁用{1}个月</color>",uVar6,uVar7,0);
                  if (lVar5 == null) goto LAB_180918ec7;
                  lVar5.buildTimeLeft = uVar6;
                }
                lVar5 = this.targetBuildingData;
                uVar10 = 0;
                if (lVar5 != null) {
                  lVar11 = 32;
                  while( true ) {
                    lVar5 = AreaBuildingData.DataBase(lVar5,0);
                    if ((lVar5 == null) || (lVar5.areaID == null)) throw; // [null/range check failed]
                    lVar8 = this.targetBuildingData;
                    if (*(int *)(lVar5.areaID + 24) <= (int)uVar10) break;
                    if (((lVar8 == null) || (lVar5 = AreaBuildingData.DataBase(lVar8,0)) == null) ||
                       (lVar5 = lVar5.areaID) == null) throw; // [null/range check failed]
                    if (lVar5.buildTimeLeft <= uVar10) {
                      ThrowHelper.ThrowArgumentOutOfRangeException(0);
                    }
                    lVar5 = *(int64 *)(lVar11 + lVar5.buildingID);
                    if (**(int **)(DAT_181e538e8 + 184) == 2) {
                      if ((lVar5 == null) || (*(int64 *)(*(int64 *)(DAT_181e942d8 + 184) + 16) == 0)
                         ) throw; // [null/range check failed]
                      cVar3 = FUN_18175e190();
                      if (!(!cVar3))
                      {
                        }
                        else {
                      }
                      if (lVar5 == null) throw; // [null/range check failed]
                      uVar6 = lVar5.shopItemList;
                      uVar4 = lVar5.destroyTimeLeft;
                      uVar7 = this.targetBuildingData;
                      cVar3 = GameController.MeetCondition(uVar6,uVar4,uVar7,0);
                      if (cVar3) {
                        lVar8 = Component.GetComponent(this,DAT_181e788b8);
                        if (lVar8 == null) throw; // [null/range check failed]
                        uVar6 = lVar8.buildTimeLeft;
                        lVar8 = Component.GetComponent(this,DAT_181e788b8);
                        if (lVar8 == null) throw; // [null/range check failed]
                        cVar3 = FUN_1816387f0(lVar8.buildTimeLeft,"",0);
                        uVar7 = "\n";
                        if (cVar3) {
                          uVar7 = "";
                        }
                        local_res20 = this.targetBuildingData;
                        uVar4 = lVar5.destroyTimeLeft;
                        uVar9 = lVar5.missionDatas;
                        local_res18[0] = CONCAT31(local_res18[0]._1_3_,uVar4);
                        if (((*(byte *)(DAT_181e52870 + 0x133) & 4) != 0) &&
                           (*(int *)(DAT_181e52870 + 224) == 0)) {
                          il2cpp_runtime_class_init();
                          uVar4 = (uint8)local_res18[0];
                        }
                        cVar3 = GameController.MeetCondition(uVar9,uVar4,local_res20,0);
                        uVar9 = "<color=grey>{0}</color>";
                        if (cVar3) {
                          uVar9 = "{0}";
                        }
                        uVar7 = String.Concat(uVar7,uVar9,0);
                        uVar9 = String.Concat("♦ ",lVar5.buildingID,0);
                        uVar7 = String.Format(uVar7,uVar9);
                        uVar6 = String.Concat(uVar6,uVar7,0);
                        *puVar1 = uVar6;
                        il2cpp_internal(puVar1);
                      }
                    }
                    lVar5 = this.targetBuildingData;
                    uVar10 = uVar10 + 1;
                    lVar11 = lVar11 + 8;
                    if (lVar5 == null) throw; // [null/range check failed]
                  }
                  if ((lVar8 != null) && (lVar5 = AreaBuildingData.DataBase(lVar8,0)) != null) {
                    if (*(char *)(lVar5 + 160) != false) {
                      lVar5 = Component.GetComponent(this,DAT_181e788b8);
                      if (lVar5 == null) throw; // [null/range check failed]
                      uVar6 = String.Concat(lVar5.buildTimeLeft,"\n♦ 盗窃",0);
                      lVar5.buildTimeLeft = uVar6;
                    }
                    if ((this.targetBuildingData != null) &&
                       (lVar5 = AreaBuildingData.DataBase(this.targetBuildingData,0)) != null)
                    {
                      if (*(char *)(lVar5 + 161) == false) {
                        return;
                      }
                      lVar5 = Component.GetComponent(this,DAT_181e788b8);
                      if (lVar5 != null) {
                        uVar6 = String.Concat(lVar5.buildTimeLeft,"\n♦ 抢劫",0);
                        lVar5.buildTimeLeft = uVar6;
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

    // Token : 0x6000DD1
    // RVA   : 0x51D200   Offset: 0x51C000   Length: 0xE
    public void /*ctor*/()
    {
        void FUN_18051d200(int64 this)
        {
        this.refreshTime = 0x3e4ccccd;
        FUN_180ae8740(this,0);
    }

}
