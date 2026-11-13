// ============================================================
// Type  : QuickTravelResourcePointController
// Token : 0x200033B
// ============================================================

public class QuickTravelResourcePointController
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001AFB
    public ResourcePointData resourcePointData;

    // Token: 0x4001AFC
    public QuickTravelAreaIconType resourcePointIconType;

    // Token: 0x4001AFD
    private bool hightLight;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60020C6
    // RVA   : 0xA5A450   Offset: 0xA59250   Length: 0x348
    private void Update()
    {
        bool cVar1;
        ulong uVar2;
        long lVar3;
        this.hightLight = 0;
        uVar2 = MouseController.hoveredUI;
        cVar1 = Object.op_Inequality(uVar2,0,0);
        if (cVar1) {
          if (MouseController.hoveredUI == null) throw; // [null/range check failed]
          uVar2 = GameObject.GetComponent();
          cVar1 = Object.op_Inequality(uVar2,0,0);
          if (cVar1) {
            if ((MouseController.hoveredUI == null) ||
               (lVar3 = GameObject.GetComponent()) == null) throw; // [null/range check failed]
            if (*(int64 *)(lVar3 + 24) != 0) {
              if ((((MouseController.hoveredUI == null) ||
                   (lVar3 = GameObject.GetComponent()) == null) || (*(int64 *)(lVar3 + 24) == 0)
                  ) || (this.resourcePointData == null)) throw; // [null/range check failed]
              if (*(int *)(*(int64 *)(lVar3 + 24) + 60) ==
                  this.resourcePointData.resourcePointID) {
                this.hightLight = 1;
              }
            }
          }
        }
        if (!this.hightLight) {
          lVar3 = Component.get_transform(this);
          if (((lVar3 != null) && (lVar3 = Transform.Find(lVar3,"HighLight",0)) != null) &&
             (lVar3 = Component.get_gameObject(lVar3,0)) != null) {
            cVar1 = GameObject.get_activeSelf(lVar3,0);
            if (!cVar1) {
              return;
            }
            lVar3 = Component.get_transform(this,0);
            if (((lVar3 != null) && (lVar3 = Transform.Find(lVar3,"HighLight",0)) != null) &&
               (lVar3 = Component.get_gameObject(lVar3,0)) != null) {
              GameObject.SetActive(lVar3,0,0);
              return;
            }
          }
        }
        else {
          lVar3 = Component.get_transform(this);
          if (((lVar3 != null) && (lVar3 = Transform.Find(lVar3,"HighLight",0)) != null) &&
             (lVar3 = Component.get_gameObject(lVar3,0)) != null) {
            cVar1 = GameObject.get_activeSelf(lVar3,0);
            if (cVar1) {
              return;
            }
            lVar3 = Component.get_transform(this,0);
            if ((lVar3 != null) && (lVar3 = Transform.Find(lVar3,"HighLight",0)) != null) {
              lVar3 = Component.get_gameObject(lVar3,0);
              if (lVar3 != null) {
                GameObject.SetActive(lVar3,1,0);
                return;
              }
            }
          }
        }
    }

    // Token : 0x60020C7
    // RVA   : 0xA59F10   Offset: 0xA58D10   Length: 0x533
    public void RefreshState()
    {
        var pStatics_43e8 = *(int64*)(DAT_181e743e8 + 184);
        bool cVar1;
        long lVar3;
        ulong local_38;
        uint local_30;
        ulong local_28;
        ulong uStack_20;
        if (PlotController.fightSkillIndexCache == 1) {
          lVar3 = PlotController._instance;
          if ((this.resourcePointData == null) || (lVar3 == null)) throw; // [null/range check failed]
          cVar1 = FUN_18176a2d0(lVar3,this.resourcePointData.connectAreaID,DAT_181e71570)
          ;
          if (!(cVar1))
          {
            plVar2 = (int64 *)Component.GetComponent(this,DAT_181e777b8);
            if (plVar2 == (int64 *)0) throw; // [null/range check failed]
            (**(code **)(*plVar2 + 0x2c8))(plVar2,0,*(uint64 *)(*plVar2 + 0x2d0));
            }
            else {
          }
          plVar2 = (int64 *)Component.GetComponent(this,DAT_181e777b8);
          if ((*pStatics_43e8 == 0) || (plVar2 == (int64 *)0))
          throw; // [null/range check failed]
          (**(code **)(*plVar2 + 0x2c8))
                    (plVar2,*(uint8 *)(*pStatics_43e8 + 128),
                     *(uint64 *)(*plVar2 + 0x2d0));
        }
        plVar2 = (int64 *)Component.GetComponent(this,DAT_181e777b8);
        if (plVar2 == (int64 *)0) throw; // [null/range check failed]
        cVar1 = (**(code **)(*plVar2 + 0x2b8))(plVar2,*(uint64 *)(*plVar2 + 0x2c0));
        if (!cVar1) {
        LAB_180a5a2c2:
          lVar3 = Component.get_transform(this,0);
          if (lVar3 == null) throw; // [null/range check failed]
          lVar3 = Transform.Find(lVar3,"AreaNameBack",0);
          if (lVar3 == null) throw; // [null/range check failed]
          lVar3 = Component.get_gameObject(lVar3,0);
          if (lVar3 == null) throw; // [null/range check failed]
          cVar1 = GameObject.get_activeSelf(lVar3,0);
          if (cVar1) {
            lVar3 = Component.get_transform(this,0);
            if (lVar3 == null) throw; // [null/range check failed]
            lVar3 = Transform.Find(lVar3,"AreaNameBack",0);
            if (lVar3 == null) throw; // [null/range check failed]
            lVar3 = Component.get_gameObject(lVar3,0);
            if (lVar3 == null) throw; // [null/range check failed]
            GameObject.SetActive(lVar3,0,0);
          }
          plVar2 = (int64 *)Component.GetComponent(this,DAT_181e777b8);
          plVar4 = (int64 *)Component.GetComponent(this,DAT_181e777b8);
          if (plVar4 == (int64 *)0) throw; // [null/range check failed]
          puVar5 = (uint64 *)
                   (**(code **)(*plVar4 + 0x298))(&local_28,plVar4,*(uint64 *)(*plVar4 + 0x2a0));
          local_28 = *puVar5;
          uStack_20 = puVar5[1];
          puVar5 = (uint64 *)GlobalData.SetColorAlpha(&local_38,&local_28,0x3e19999a,0);
          if (plVar2 == (int64 *)0) throw; // [null/range check failed]
          local_28 = *puVar5;
          uStack_20 = puVar5[1];
          (**(code **)(*plVar2 + 0x2a8))(plVar2,&local_28,*(uint64 *)(*plVar2 + 0x2b0));
          lVar3 = Component.get_transform(this,0);
          if (lVar3 == null) throw; // [null/range check failed]
          lVar3 = Transform.Find(lVar3,"OutLine",0);
          puVar5 = (uint64 *)Vector3.get_zero(&local_28,0);
        }
        else {
          if (*pStatics_43e8 == 0) throw; // [null/range check failed]
          if (*(char *)(*pStatics_43e8 + 128) == false) goto LAB_180a5a2c2;
          lVar3 = Component.get_transform(this,0);
          if (lVar3 == null) throw; // [null/range check failed]
          lVar3 = Transform.Find(lVar3,"AreaNameBack",0);
          if (lVar3 == null) throw; // [null/range check failed]
          lVar3 = Component.get_gameObject(lVar3,0);
          if (lVar3 == null) throw; // [null/range check failed]
          cVar1 = GameObject.get_activeSelf(lVar3,0);
          if (!cVar1) {
            lVar3 = Component.get_transform(this,0);
            if (lVar3 == null) throw; // [null/range check failed]
            lVar3 = Transform.Find(lVar3,"AreaNameBack",0);
            if (lVar3 == null) throw; // [null/range check failed]
            lVar3 = Component.get_gameObject(lVar3,0);
            if (lVar3 == null) throw; // [null/range check failed]
            GameObject.SetActive(lVar3,1,0);
          }
          plVar2 = (int64 *)Component.GetComponent(this,DAT_181e777b8);
          plVar4 = (int64 *)Component.GetComponent(this,DAT_181e777b8);
          if (plVar4 == (int64 *)0) throw; // [null/range check failed]
          puVar5 = (uint64 *)
                   (**(code **)(*plVar4 + 0x298))(&local_28,plVar4,*(uint64 *)(*plVar4 + 0x2a0));
          local_28 = *puVar5;
          uStack_20 = puVar5[1];
          puVar5 = (uint64 *)GlobalData.SetColorAlpha(&local_38,&local_28,0x3f800000,0);
          if (plVar2 == (int64 *)0) throw; // [null/range check failed]
          local_28 = *puVar5;
          uStack_20 = puVar5[1];
          (**(code **)(*plVar2 + 0x2a8))(plVar2,&local_28,*(uint64 *)(*plVar2 + 0x2b0));
          lVar3 = Component.get_transform(this,0);
          if (lVar3 == null) throw; // [null/range check failed]
          lVar3 = Transform.Find(lVar3,"OutLine",0);
          puVar5 = (uint64 *)Vector3.get_one(&local_28,0);
        }
        if (lVar3 != null) {
          local_30 = *(uint32 *)(puVar5 + 1);
          local_38 = *puVar5;
          Transform.set_localScale(lVar3,&local_38,0);
          return;
        }
    }

    // Token : 0x60020C8
    // RVA   : 0xA59DF0   Offset: 0xA58BF0   Length: 0x118
    public void RefreshNameScale()
    {
        var pStatics = *(int64*)(DAT_181e743e8 + 184);
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

    // Token : 0x60020C9
    // RVA   : 0x8C6860   Offset: 0x8C5660   Length: 0x50
    public virtual void OnDrag(PointerEventData eventData)
    {
        var pStatics = *(int64*)(DAT_181e74368 + 184);
        if (*pStatics != 0) {
          QuickTravelBigMapSpriteController.OnDrag(*pStatics,eventData,0);
          return;
        }
    }

    // Token : 0x60020CA
    // RVA   : 0x8C68C0   Offset: 0x8C56C0   Length: 0x50
    public virtual void OnScroll(PointerEventData eventData)
    {
        var pStatics = *(int64*)(DAT_181e74368 + 184);
        if (*pStatics != 0) {
          QuickTravelBigMapSpriteController.OnScroll(*pStatics,eventData,0);
          return;
        }
    }

    // Token : 0x60020CB
    // RVA   : 0xA59C10   Offset: 0xA58A10   Length: 0x1D2
    public void OnClick()
    {
        long lVar1;
        long lVar2;
        long lVar3;
        ulong uVar4;
        ulong uVar5;
        if (this.resourcePointIconType != 2) {
          return;
        }
        lVar1 = this.resourcePointData;
        lVar2 = **(int64 **)(DAT_181e88b68 + 184);
        if (lVar1 != null) {
          if (((GameController._instance != null) &&
              (lVar3 = GameController._instance.worldData) != null) &&
             (lVar3 = WorldData.GetArea(lVar3,lVar1.connectAreaID,0)) != null) {
            uVar4 = AreaData.GetAreaName(lVar3,0);
            uVar4 = String.Concat(uVar4,lVar1.resourcePointName,0);
            uVar4 = String.Format("确认前往{0}吗？",uVar4,0);
            if ((this.resourcePointData != null) &&
               (uVar5 = Int32.ToString(this.resourcePointData + 16,0), lVar2 != null)) {
              SureMenu.CallSureMenu(lVar2,uVar4,"SetPlayerMoveTargetResourcePoint",uVar5,"BigMapController",1,0);
              return;
            }
          }
        }
    }

    // Token : 0x60020CC
    // RVA   : 0x2110A0   Offset: 0x20FEA0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_180ae8740(this,0);
    }

}
