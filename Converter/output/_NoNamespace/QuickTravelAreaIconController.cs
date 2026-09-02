// ============================================================
// Type  : QuickTravelAreaIconController
// Token : 0x2000327
// ============================================================

public class QuickTravelAreaIconController
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001980
    public AreaData areaData;

    // Token: 0x4001981
    public QuickTravelAreaIconType quickTravelAreaIconType;

    // Token: 0x4001982
    public Image missionTarget;

    // Token: 0x4001983
    private bool hightLight;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6001F92
    // RVA   : 0xBEF180   Offset: 0xBED980   Length: 0x7F
    private void Start()
    {
        long lVar1;
        ulong uVar2;
        lVar1 = Component.get_transform(this,0);
        if (lVar1 != null) {
          lVar1 = Transform.Find(lVar1,"MissionTarget",0);
          if (lVar1 != null) {
            uVar2 = Component.GetComponent(lVar1,DAT_181d6bc40);
            this.missionTarget = uVar2;
            return;
          }
        }
    }

    // Token : 0x6001F93
    // RVA   : 0xBEF200   Offset: 0xBEDA00   Length: 0x922
    private void Update()
    {
        var pStatics_6270 = *(int64*)(DAT_181d86270 + 184);
        var pStatics_6570 = *(int64*)(DAT_181d66570 + 184);
        bool cVar1;
        ulong uVar2;
        long lVar3;
        uint local_18;
        uint uStack_14;
        uint uStack_10;
        uint32 uStack_c;
        this.hightLight = 0;
        uVar2 = *(uint64 *)(pStatics_6570 + 72);
        cVar1 = Object.op_Inequality(uVar2,0,0);
        if (cVar1) {
          lVar3 = *(int64 *)(pStatics_6570 + 72);
          if (lVar3 == null) goto LAB_180befb1d;
          uVar2 = GameObject.GetComponent(lVar3,DAT_181da05c0);
          cVar1 = Object.op_Inequality(uVar2,0,0);
          if (cVar1) {
            lVar3 = *(int64 *)(pStatics_6570 + 72);
            if (lVar3 == null) goto LAB_180befb1d;
            lVar3 = GameObject.GetComponent(lVar3,DAT_181da05c0);
            if (lVar3 == null) goto LAB_180befb1d;
            if (lVar3.areaName == null) goto LAB_180bef4d6;
            lVar3 = *(int64 *)(pStatics_6570 + 72);
            if (lVar3 == null) goto LAB_180befb1d;
            lVar3 = GameObject.GetComponent(lVar3,DAT_181da05c0);
            if ((lVar3 == null) || (lVar3.areaName == null)) goto LAB_180befb1d;
            if (*(char *)(lVar3.areaName + 97) != false) goto LAB_180bef4d6;
            lVar3 = *(int64 *)(pStatics_6570 + 72);
            if (lVar3 == null) goto LAB_180befb1d;
            lVar3 = GameObject.GetComponent(lVar3,DAT_181da05c0);
            if ((lVar3 == null) || (lVar3.areaName == null)) goto LAB_180befb1d;
            lVar3 = MissionData.GetTargetAreaID(lVar3.areaName,0);
            if ((this.areaData == null) || (lVar3 == null)) goto LAB_180befb1d;
            cVar1 = FUN_181815240(lVar3,this.areaData.areaID,
                                  DAT_181d67bf8);
            if (!cVar1) goto LAB_180bef4d6;
            goto LAB_180bef885;
          }
        LAB_180bef4d6:
          lVar3 = *(int64 *)(pStatics_6570 + 72);
          if (lVar3 == null) goto LAB_180befb1d;
          uVar2 = GameObject.GetComponent(lVar3,DAT_181da0538);
          cVar1 = Object.op_Inequality(uVar2,0,0);
          if (cVar1) {
            lVar3 = *(int64 *)(pStatics_6570 + 72);
            if (lVar3 == null) goto LAB_180befb1d;
            lVar3 = GameObject.GetComponent(lVar3,DAT_181da0538);
            if (lVar3 == null) goto LAB_180befb1d;
            if (lVar3.areaName != null) {
              lVar3 = *(int64 *)(pStatics_6570 + 72);
              if (lVar3 == null) goto LAB_180befb1d;
              lVar3 = GameObject.GetComponent(lVar3,DAT_181da0538);
              if ((lVar3 == null) || (lVar3.areaName == null)) goto LAB_180befb1d;
              if (*(char *)(lVar3.areaName + 97) == false) {
                lVar3 = *(int64 *)(pStatics_6570 + 72);
                if (lVar3 == null) goto LAB_180befb1d;
                lVar3 = GameObject.GetComponent(lVar3,DAT_181da0538);
                if ((lVar3 == null) || (lVar3.areaName == null)) goto LAB_180befb1d;
                lVar3 = MissionData.GetTargetAreaID(lVar3.areaName,0);
                if ((this.areaData == null) || (lVar3 == null)) goto LAB_180befb1d;
                cVar1 = FUN_181815240(lVar3,this.areaData.areaID,
                                      DAT_181d67bf8);
                if (cVar1) goto LAB_180bef885;
              }
            }
          }
          if (*(int64 *)(pStatics_6570 + 72) == 0) goto LAB_180befb1d;
          uVar2 = GameObject.GetComponent();
          cVar1 = Object.op_Inequality(uVar2,0,0);
          if (cVar1) {
            if (*(int64 *)(pStatics_6570 + 72) == 0) goto LAB_180befb1d;
            lVar3 = GameObject.GetComponent();
            if (lVar3 == null) goto LAB_180befb1d;
            if (lVar3.areaName != null) {
              lVar3 = *(int64 *)(pStatics_6570 + 72);
              if (lVar3 == null) goto LAB_180befb1d;
              lVar3 = GameObject.GetComponent(lVar3,DAT_181da29b0);
              if ((((lVar3 == null) || (lVar3.areaName == null)) ||
                  (this.areaData == null)) ||
                 (lVar3 = *(int64 *)(lVar3.areaName + 64)) == null)
              goto LAB_180befb1d;
              cVar1 = FUN_181815240(lVar3,this.areaData.areaID,
                                    DAT_181d67bf8);
              if (!cVar1) {
                if (*(int64 *)(pStatics_6570 + 72) == 0) goto LAB_180befb1d;
                lVar3 = GameObject.GetComponent();
                if (((lVar3 == null) || (lVar3.areaName == null)) ||
                   (this.areaData == null)) goto LAB_180befb1d;
                if (*(int *)(lVar3.areaName + 88) !=
                    this.areaData.areaID) goto LAB_180bef889;
              }
        LAB_180bef885:
              this.hightLight = 1;
            }
          }
        }
        LAB_180bef889:
        if (!this.hightLight) {
          lVar3 = Component.get_transform(this);
          if (lVar3 == null) goto LAB_180befb1d;
          lVar3 = Transform.Find(lVar3,"HighLight",0);
          if (lVar3 == null) goto LAB_180befb1d;
          lVar3 = Component.get_gameObject(lVar3,0);
          if (lVar3 == null) goto LAB_180befb1d;
          cVar1 = GameObject.get_activeSelf(lVar3,0);
          if (cVar1) {
            lVar3 = Component.get_transform(this,0);
            if (lVar3 == null) goto LAB_180befb1d;
            lVar3 = Transform.Find(lVar3,"HighLight",0);
            if (lVar3 == null) goto LAB_180befb1d;
            lVar3 = Component.get_gameObject(lVar3,0);
            if (lVar3 == null) goto LAB_180befb1d;
            uVar2 = 0;
        LAB_180bef9ba:
            GameObject.SetActive(lVar3,uVar2,0);
          }
        }
        else {
          lVar3 = Component.get_transform(this);
          if (lVar3 == null) goto LAB_180befb1d;
          lVar3 = Transform.Find(lVar3,"HighLight",0);
          if (lVar3 == null) goto LAB_180befb1d;
          lVar3 = Component.get_gameObject(lVar3,0);
          if (lVar3 == null) goto LAB_180befb1d;
          cVar1 = GameObject.get_activeSelf(lVar3,0);
          if (!cVar1) {
            lVar3 = Component.get_transform(this,0);
            if (lVar3 == null) goto LAB_180befb1d;
            lVar3 = Transform.Find(lVar3,"HighLight",0);
            if (lVar3 == null) goto LAB_180befb1d;
            lVar3 = Component.get_gameObject(lVar3,0);
            if (lVar3 == null) goto LAB_180befb1d;
            uVar2 = 1;
            goto LAB_180bef9ba;
          }
        }
        lVar3 = this.areaData;
        if (lVar3 == null) goto LAB_180befb1d;
        plVar5 = this.missionTarget;
        if (lVar3.plotNumCount < 1) {
          if (lVar3.missionNumCount < 1) {
            puVar4 = (uint32 *)FUN_180d904c0(&local_18,0);
            if (plVar5 == (int64 *)0) goto LAB_180befb1d;
            lVar3 = *plVar5;
            goto LAB_180befaf7;
          }
          if (*pStatics_6270 == 0) goto LAB_180befb1d;
          uVar2 = TextureController.LoadAtlasSprite
                            (*pStatics_6270,"WorldMapAtlas","任务目标",0);
          if (plVar5 == (int64 *)0) goto LAB_180befb1d;
          Image.set_sprite(plVar5,uVar2,0);
          plVar5 = this.missionTarget;
          puVar4 = (uint32 *)FUN_181098a50(&local_18,0);
        }
        else {
          if (*pStatics_6270 == 0) goto LAB_180befb1d;
          uVar2 = TextureController.LoadAtlasSprite
                            (*pStatics_6270,"WorldMapAtlas","问号",0);
          if (plVar5 == (int64 *)0) goto LAB_180befb1d;
          Image.set_sprite(plVar5,uVar2,0);
          plVar5 = this.missionTarget;
          puVar4 = (uint32 *)Color.get_yellow(&local_18,0);
        }
        if (plVar5 == (int64 *)0) {
        LAB_180befb1d:
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
        lVar3 = *plVar5;
        LAB_180befaf7:
        local_18 = *puVar4;
        uStack_14 = puVar4[1];
        uStack_10 = puVar4[2];
        uStack_c = puVar4[3];
        (**(code **)(lVar3 + 0x2a8))(plVar5,&local_18,*(uint64 *)(lVar3 + 0x2b0));
    }

    // Token : 0x6001F94
    // RVA   : 0xBEEC30   Offset: 0xBED430   Length: 0x50
    public virtual void OnDrag(PointerEventData eventData)
    {
        var pStatics = *(int64*)(DAT_181d6ed60 + 184);
        if (*pStatics != 0) {
          QuickTravelBigMapSpriteController.OnDrag(*pStatics,eventData,0);
          return;
        }
    }

    // Token : 0x6001F95
    // RVA   : 0xBEEC90   Offset: 0xBED490   Length: 0x50
    public virtual void OnScroll(PointerEventData eventData)
    {
        var pStatics = *(int64*)(DAT_181d6ed60 + 184);
        if (*pStatics != 0) {
          QuickTravelBigMapSpriteController.OnScroll(*pStatics,eventData,0);
          return;
        }
    }

    // Token : 0x6001F96
    // RVA   : 0xBEEE10   Offset: 0xBED610   Length: 0x369
    public void RefreshState()
    {
        var pStatics = *(int64*)(DAT_181d6ede0 + 184);
        uint uVar1;
        bool cVar2;
        long lVar4;
        uint uVar7;
        uint local_38;
        uint uStack_34;
        uint uStack_30;
        uint32 uStack_2c;
        uint8 local_28 [32];
        plVar3 = (int64 *)Component.GetComponent(this,DAT_181d6bc40);
        if (plVar3 == (int64 *)0) throw; // [null/range check failed]
        cVar2 = (**(code **)(*plVar3 + 0x2b8))(plVar3,*(uint64 *)(*plVar3 + 0x2c0));
        if (!cVar2) {
        LAB_180bef06e:
          lVar4 = Component.get_transform(this,0);
          if (lVar4 == null) throw; // [null/range check failed]
          lVar4 = Transform.Find(lVar4,"AreaNameBack",0);
          if (lVar4 == null) throw; // [null/range check failed]
          lVar4 = Component.get_gameObject(lVar4,0);
          if (lVar4 == null) throw; // [null/range check failed]
          cVar2 = GameObject.get_activeSelf(lVar4,0);
          if (cVar2) {
            lVar4 = Component.get_transform(this,0);
            if (lVar4 == null) throw; // [null/range check failed]
            lVar4 = Transform.Find(lVar4,"AreaNameBack",0);
            if (lVar4 == null) throw; // [null/range check failed]
            lVar4 = Component.get_gameObject(lVar4,0);
            if (lVar4 == null) throw; // [null/range check failed]
            GameObject.SetActive(lVar4,0,0);
          }
          plVar3 = (int64 *)Component.GetComponent(this,DAT_181d6bc40);
          plVar5 = (int64 *)Component.GetComponent(this,DAT_181d6bc40);
          if (plVar5 == (int64 *)0) throw; // [null/range check failed]
          puVar6 = (uint32 *)
                   (**(code **)(*plVar5 + 0x298))(local_28,plVar5,*(uint64 *)(*plVar5 + 0x2a0));
          local_38 = *puVar6;
          uStack_34 = puVar6[1];
          uStack_30 = puVar6[2];
          uStack_2c = puVar6[3];
          uVar7 = 0x3e19999a;
        }
        else {
          if (((*pStatics == 0) || (this.areaData == null)) ||
             (lVar4 = *(int64 *)(*pStatics + 120)) == null)
          throw; // [null/range check failed]
          uVar1 = this.areaData.areaType;
          if (*(uint32 *)(lVar4 + 24) <= uVar1) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          if (*(char *)(*(int64 *)(lVar4 + 16) + 32 + (int64)(int)uVar1) == false)
          goto LAB_180bef06e;
          lVar4 = Component.get_transform(this,0);
          if (lVar4 == null) throw; // [null/range check failed]
          lVar4 = Transform.Find(lVar4,"AreaNameBack",0);
          if (lVar4 == null) throw; // [null/range check failed]
          lVar4 = Component.get_gameObject(lVar4,0);
          if (lVar4 == null) throw; // [null/range check failed]
          cVar2 = GameObject.get_activeSelf(lVar4,0);
          if (!cVar2) {
            lVar4 = Component.get_transform(this,0);
            if (lVar4 == null) throw; // [null/range check failed]
            lVar4 = Transform.Find(lVar4,"AreaNameBack",0);
            if (lVar4 == null) throw; // [null/range check failed]
            lVar4 = Component.get_gameObject(lVar4,0);
            if (lVar4 == null) throw; // [null/range check failed]
            GameObject.SetActive(lVar4,1,0);
          }
          plVar3 = (int64 *)Component.GetComponent(this,DAT_181d6bc40);
          plVar5 = (int64 *)Component.GetComponent(this,DAT_181d6bc40);
          if (plVar5 == (int64 *)0) throw; // [null/range check failed]
          puVar6 = (uint32 *)
                   (**(code **)(*plVar5 + 0x298))(&local_38,plVar5,*(uint64 *)(*plVar5 + 0x2a0));
          local_38 = *puVar6;
          uStack_34 = puVar6[1];
          uStack_30 = puVar6[2];
          uStack_2c = puVar6[3];
          uVar7 = 0x3f800000;
        }
        puVar6 = (uint32 *)GlobalData.SetColorAlpha(local_28,&local_38,uVar7,0);
        if (plVar3 != (int64 *)0) {
          local_38 = *puVar6;
          uStack_34 = puVar6[1];
          uStack_30 = puVar6[2];
          uStack_2c = puVar6[3];
          (**(code **)(*plVar3 + 0x2a8))(plVar3,&local_38,*(uint64 *)(*plVar3 + 0x2b0));
          return;
        }
    }

    // Token : 0x6001F97
    // RVA   : 0xBEECF0   Offset: 0xBED4F0   Length: 0x118
    public void RefreshNameScale()
    {
        var pStatics = *(int64*)(DAT_181d6ede0 + 184);
        long lVar1;
        ulong local_28;
        float local_20;
        float local_18;
        float fStack_14;
        float local_10;
        lVar1 = Component.get_transform(this,0);
        if (lVar1 != null) {
          lVar1 = Transform.Find(lVar1,"AreaNameBack",0);
          puVar2 = (uint64 *)Vector3.get_one(&local_18,0);
          local_28 = *puVar2;
          local_20 = *(float *)(puVar2 + 1);
          if (*pStatics != 0) {
            local_10 = *(float *)(*pStatics + 192) * 0.5 + 0.5;
            local_18 = (float)local_28 / local_10;
            fStack_14 = local_28._4_4_ / local_10;
            local_10 = local_20 / local_10;
            if (lVar1 != null) {
              local_28 = CONCAT44(fStack_14,local_18);
              local_20 = local_10;
              Transform.set_localScale(lVar1,&local_28,0);
              return;
            }
          }
        }
    }

    // Token : 0x6001F98
    // RVA   : 0xBEE060   Offset: 0xBEC860   Length: 0xBB4
    public void OnClick()
    {
        int iVar1;
        bool cVar2;
        int iVar3;
        long lVar4;
        long lVar5;
        ulong uVar6;
        ulong uVar7;
        ulong uVar8;
        long lVar10;
        int[] local_res8 = new int[2];
        int[] local_res18 = new int[2];
        switch(this.quickTravelAreaIconType) {
        case 0:
          lVar10 = FUN_18046c500(0);
          if (lVar10 != null) {
            if (*(int *)(lVar10 + 28) != 1) {
              return;
            }
            lVar10 = FUN_18046c0a0(0);
            if (lVar10 != null) {
              GameController.ShowTextOnMouse(lVar10,"马车只能前往城市区域！",0);
              plVar9 = (int64 *)Resources.Load("Sound/SoundEffect/WrongClick",0);
              plVar11 = (int64 *)0;
              if ((plVar9 != (int64 *)0) && (*plVar9 == DAT_181d8a228)) {
                plVar11 = plVar9;
              }
              NGUITools.PlaySound(plVar11,0);
              return;
            }
          }
          break;
        case 1:
          lVar10 = FUN_18046c0a0(0);
          if ((((lVar10 != null) && (lVar10.areaStartLv != null)) &&
              (lVar10 = WorldData.Player(lVar10.areaStartLv,0)) != null) &&
             (*(int64 *)(lVar10 + 0x220) != 0)) {
            iVar1 = *(int *)(*(int64 *)(lVar10 + 0x220) + 24);
            if (this.areaData != null) {
              lVar10 = this.areaData.bigMapPos;
              lVar4 = FUN_18046c0a0(0);
              if (((lVar4 != null) && (*(int64 *)(lVar4 + 32) != 0)) &&
                 ((lVar4 = WorldData.Player(*(int64 *)(lVar4 + 32),0), lVar4 != null && (lVar10 != null)))
                 ) {
                iVar3 = BigMapPos.QuickTravelTime(lVar10,*(uint64 *)(lVar4 + 200),0);
                if (iVar1 < iVar3 * 10) {
                  lVar10 = FUN_18046c0a0(0);
                  if (this.areaData != null) {
                    lVar4 = this.areaData.bigMapPos;
                    lVar5 = FUN_18046c0a0(0);
                    if ((((lVar5 != null) && (*(int64 *)(lVar5 + 32) != 0)) &&
                        (lVar5 = WorldData.Player(*(int64 *)(lVar5 + 32),0)) != null) &&
                       (lVar4 != null)) {
                      local_res8[0] = BigMapPos.QuickTravelTime(lVar4,*(uint64 *)(lVar5 + 200),0);
                      local_res8[0] = local_res8[0] * 10;
                      uVar7 = il2cpp_value_box(DAT_181d5b2f8,local_res8);
                      uVar7 = String.Format("需支付车费{0}银两",uVar7,0);
                      if (lVar10 != null) {
                        GameController.ShowTextOnMouse(lVar10,uVar7,0);
                        return;
                      }
                    }
                  }
                          // WARNING: Subroutine does not return
                  FUN_1800d6620();
                }
                lVar4 = FUN_18077c2c0(0);
                lVar10 = this.areaData;
                if (lVar10 != null) {
                  uVar7 = lVar10.areaName;
                  lVar10 = lVar10.bigMapPos;
                  lVar5 = FUN_18046c0a0(0);
                  if ((((lVar5 != null) && (*(int64 *)(lVar5 + 32) != 0)) &&
                      (lVar5 = WorldData.Player(*(int64 *)(lVar5 + 32),0)) != null) &&
                     (lVar10 != null)) {
                    local_res8[0] = BigMapPos.QuickTravelTime(lVar10,*(uint64 *)(lVar5 + 200),0);
                    uVar8 = il2cpp_value_box(DAT_181d5b2f8,local_res8);
                    if (this.areaData != null) {
                      lVar10 = this.areaData.bigMapPos;
                      lVar5 = FUN_18046c0a0(0);
                      if (((lVar5 != null) && (*(int64 *)(lVar5 + 32) != 0)) &&
                         ((lVar5 = WorldData.Player(*(int64 *)(lVar5 + 32),0), lVar5 != null &&
                          (lVar10 != null)))) {
                        local_res18[0] = BigMapPos.QuickTravelTime(lVar10,*(uint64 *)(lVar5 + 200),0)
                        ;
                        local_res18[0] = local_res18[0] * 10;
                        uVar6 = il2cpp_value_box(DAT_181d5b2f8,local_res18);
                        uVar7 = String.Format("乘坐马车前往{0}吗？\n耗时{1}天，车费{2}银两",uVar7,uVar8,uVar6,0);
                        if ((this.areaData != null) &&
                           (uVar8 = Int32.ToString(this.areaData + 16,0), lVar4 != null))
                        {
                          SureMenu.CallSureMenu(lVar4,uVar7,"PlayerQuickTravel",uVar8,0);
                          return;
                        }
                      }
                    }
                  }
                }
                          // WARNING: Subroutine does not return
                FUN_1800d6620();
              }
            }
          }
          break;
        case 2:
          lVar10 = FUN_18077c2c0(0);
          if (this.areaData != null) {
            uVar7 = String.Format("确认前往{0}吗？",this.areaData.areaName,0);
            if ((this.areaData != null) &&
               (uVar8 = Int32.ToString(this.areaData + 16,0), lVar10 != null)) {
              SureMenu.CallSureMenu(lVar10,uVar7,"SetPlayerMoveTargetArea",uVar8,"BigMapController",1,0);
              return;
            }
          }
          break;
        case 3:
          if ((this.areaData == null) ||
             (lVar10 = AreaData.GetForce(this.areaData,0)) == null) break;
          iVar1 = lVar10.xScale;
          lVar10 = FUN_18046c0a0(0);
          if (((lVar10 == null) || (lVar10.areaStartLv == null)) ||
             (lVar10 = WorldData.Player(lVar10.areaStartLv,0)) == null) break;
          if (iVar1 == *(int *)(lVar10 + 132)) {
            lVar10 = FUN_18046c0a0(0);
            if (lVar10 != null) {
              GameController.ShowTextOnMouse(lVar10,"无法进攻附庸门派！",0);
              plVar9 = (int64 *)Resources.Load("Sound/SoundEffect/WrongClick",0);
              plVar11 = (int64 *)0;
              if ((plVar9 != (int64 *)0) && (*plVar9 == DAT_181d8a228)) {
                plVar11 = plVar9;
              }
              NGUITools.PlaySound(plVar11,0);
              return;
            }
            break;
          }
          lVar10 = FUN_18046c0a0(0);
          if ((lVar10 == null) || (lVar10.areaStartLv == null)) break;
          if (*(char *)(lVar10.areaStartLv + 0x10c) == false) {
            if (this.areaData == null) break;
            if (this.areaData.areaType == 2) {
              lVar10 = FUN_18046c0a0(0);
              if (lVar10 != null) {
                GameController.ShowTextOnMouse(lVar10,"当前不可进攻门派总舵！",0);
                plVar9 = (int64 *)Resources.Load("Sound/SoundEffect/WrongClick",0);
                plVar11 = (int64 *)0;
                if ((plVar9 != (int64 *)0) && (*plVar9 == DAT_181d8a228)) {
                  plVar11 = plVar9;
                }
                NGUITools.PlaySound(plVar11,0);
                return;
              }
              break;
            }
          }
          lVar10 = FUN_18046c0a0(0);
          if ((lVar10 == null) || (lVar10.areaStartLv == null)) break;
          if (*(char *)(lVar10.areaStartLv + 0x10c) == false) {
            lVar10 = this.areaData;
            if (lVar10 == null) break;
            if (lVar10.areaID == null) {
              lVar10 = FUN_18046c0a0(0);
              if (lVar10 != null) {
                GameController.ShowTextOnMouse(lVar10,"当前不可进攻京城！",0);
                plVar9 = (int64 *)Resources.Load("Sound/SoundEffect/WrongClick",0);
                plVar11 = (int64 *)0;
                if ((plVar9 != (int64 *)0) && (*plVar9 == DAT_181d8a228)) {
                  plVar11 = plVar9;
                }
                NGUITools.PlaySound(plVar11,0);
                return;
              }
              break;
            }
          }
          else {
            lVar10 = this.areaData;
            if (lVar10 == null) break;
          }
          lVar10 = AreaData.GetForce(lVar10,0);
          if ((lVar10 == null) || (lVar4 = this.areaData) == null) break;
          if (lVar10.backgroundSkinID == *(int *)(lVar4 + 16)) {
            lVar10 = AreaData.GetForce(lVar4,0);
            if ((lVar10 == null) || (lVar10.changeAreaState == null)) break;
            if (1 < *(int *)(lVar10.changeAreaState + 24)) {
              lVar10 = FUN_18046c0a0(0);
              if (lVar10 != null) {
                GameController.ShowTextOnMouse(lVar10,"无法进攻有其他据点的门派！",0);
                plVar9 = (int64 *)Resources.Load("Sound/SoundEffect/WrongClick",0);
                plVar11 = (int64 *)0;
                if ((plVar9 != (int64 *)0) && (*plVar9 == DAT_181d8a228)) {
                  plVar11 = plVar9;
                }
                NGUITools.PlaySound(plVar11,0);
                return;
              }
              break;
            }
          }
          lVar10 = FUN_18046c0a0(0);
          if ((((lVar10 == null) || (lVar10.areaStartLv == null)) ||
              (lVar10 = WorldData.Player(lVar10.areaStartLv,0)) == null) ||
             (lVar10 = HeroData.GetForce(lVar10,0,0)) == null) break;
          cVar2 = ForceData.AreaNotFull(lVar10,0);
          if (!cVar2) {
            if (this.areaData == null) break;
            if (this.areaData.areaType != 2) {
              lVar10 = FUN_18046c0a0(0);
              if (lVar10 != null) {
                GameController.ShowTextOnMouse(lVar10,"门派占领区域已达上限！",0);
                plVar9 = (int64 *)Resources.Load("Sound/SoundEffect/WrongClick",0);
                plVar11 = (int64 *)0;
                if ((plVar9 != (int64 *)0) && (*plVar9 == DAT_181d8a228)) {
                  plVar11 = plVar9;
                }
                NGUITools.PlaySound(plVar11,0);
                return;
              }
              break;
            }
          }
          lVar10 = FUN_18046c3a0(0);
          if (lVar10 == null) break;
          if (lVar10.areaStartLv != null) {
            lVar10 = FUN_18046c3a0(0);
            if ((this.areaData != null) && (lVar10 != null)) {
              MeetingController.AttackAreaAdviseChoosen
                        (lVar10,this.areaData.areaID,0);
              return;
            }
            break;
          }
          lVar10 = FUN_18046c440(0);
          if (lVar10 == null) break;
          PlotController.ForceAttackAreaChoosen(lVar10,this.areaData,0);
          goto LAB_180beebe5;
        case 4:
        case 5:
          lVar10 = FUN_18046c440(0);
          if (((lVar10 == null) || (this.areaData == null)) ||
             (*(int64 *)(lVar10 + 0x1d8) == 0)) break;
          AISettingTabController.SetFocus
                    (*(int64 *)(lVar10 + 0x1d8),this.areaData.areaID,0
                    );
        LAB_180beebe5:
          lVar10 = FUN_18046c500(0);
          if (lVar10 != null) {
            QuickTravelUIController.HideQuickTravelUI(lVar10,0);
        switchD_180bee19a_default:
            return;
          }
          break;
        default:
          goto switchD_180bee19a_default;
        }
    }

    // Token : 0x6001F99
    // RVA   : 0x3A17B0   Offset: 0x39FFB0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_18044ef50(this,0);
    }

}
