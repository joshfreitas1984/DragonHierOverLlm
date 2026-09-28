// ============================================================
// Type  : QuickTravelInnIconController
// Token : 0x2000330
// ============================================================

public class QuickTravelInnIconController
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001A7C
    public InnData innData;

    // Token: 0x4001A7D
    public QuickTravelAreaIconType innIconType;

    // Token: 0x4001A7E
    public Image missionTarget;

    // Token: 0x4001A7F
    private bool hightLight;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x600201F
    // RVA   : 0xD00370   Offset: 0xCFF770   Length: 0x7F
    private void Start()
    {
        long lVar1;
        ulong uVar2;
        lVar1 = Component.get_transform(this,0);
        if (lVar1 != null) {
          lVar1 = Transform.Find(lVar1,"MissionTarget",0);
          if (lVar1 != null) {
            uVar2 = Component.GetComponent(lVar1,DAT_181d94460);
            this.missionTarget = uVar2;
            return;
          }
        }
    }

    // Token : 0x6002020
    // RVA   : 0xD003F0   Offset: 0xCFF7F0   Length: 0x5A2
    public void Update()
    {
        var pStatics_b490 = *(int64*)(DAT_181dab490 + 184);
        bool cVar1;
        ulong uVar2;
        long lVar3;
        ulong uVar4;
        uint local_18;
        uint uStack_14;
        uint uStack_10;
        uint32 uStack_c;
        this.hightLight = 0;
        uVar2 = MouseController.hoveredUI;
        cVar1 = Object.op_Inequality(uVar2,0,0);
        if (cVar1) {
          if (MouseController.hoveredUI == null) goto LAB_180d0098d;
          uVar2 = GameObject.GetComponent();
          cVar1 = Object.op_Inequality(uVar2,0,0);
          if (cVar1) {
            if (MouseController.hoveredUI == null) goto LAB_180d0098d;
            lVar3 = GameObject.GetComponent();
            if (lVar3 == null) goto LAB_180d0098d;
            if (lVar3.innName != null) {
              if (MouseController.hoveredUI == null) goto LAB_180d0098d;
              lVar3 = GameObject.GetComponent();
              if (((lVar3 == null) || (lVar3.innName == null)) ||
                 (lVar3 = *(int64 *)(lVar3.innName + 120)) == null)
              goto LAB_180d0098d;
              if (lVar3.innName == null) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              lVar3 = *(int64 *)(lVar3.id + 32);
              if (lVar3 == null) goto LAB_180d0098d;
              if (lVar3.shopItemList == 6) {
                lVar3 = MouseController.hoveredUI;
                if (lVar3 == null) goto LAB_180d0098d;
                lVar3 = GameObject.GetComponent(lVar3,DAT_181d72568);
                if (((lVar3 == null) || (lVar3.innName == null)) ||
                   (lVar3 = *(int64 *)(lVar3.innName + 120)) == null)
                goto LAB_180d0098d;
                if (lVar3.innName == null) {
                  ThrowHelper.ThrowArgumentOutOfRangeException(0);
                }
                lVar3 = *(int64 *)(lVar3.id + 32);
                if (lVar3 == null) goto LAB_180d0098d;
                uVar2 = lVar3.bigMapPos;
                if (this.innData == null) goto LAB_180d0098d;
                uVar4 = Int32.ToString(this.innData + 16,0);
                cVar1 = FUN_18171e540(uVar2,uVar4,0);
                if (cVar1) {
                  this.hightLight = 1;
                }
              }
            }
          }
        }
        if (!this.hightLight) {
          lVar3 = Component.get_transform(this);
          if (lVar3 == null) goto LAB_180d0098d;
          lVar3 = Transform.Find(lVar3,"HighLight",0);
          if (lVar3 == null) goto LAB_180d0098d;
          lVar3 = Component.get_gameObject(lVar3,0);
          if (lVar3 == null) goto LAB_180d0098d;
          cVar1 = GameObject.get_activeSelf(lVar3,0);
          if (cVar1) {
            lVar3 = Component.get_transform(this,0);
            if (lVar3 == null) goto LAB_180d0098d;
            lVar3 = Transform.Find(lVar3,"HighLight",0);
            if (lVar3 == null) goto LAB_180d0098d;
            lVar3 = Component.get_gameObject(lVar3,0);
            if (lVar3 == null) goto LAB_180d0098d;
            uVar2 = 0;
        LAB_180d00830:
            GameObject.SetActive(lVar3,uVar2,0);
          }
        }
        else {
          lVar3 = Component.get_transform(this);
          if (lVar3 == null) goto LAB_180d0098d;
          lVar3 = Transform.Find(lVar3,"HighLight",0);
          if (lVar3 == null) goto LAB_180d0098d;
          lVar3 = Component.get_gameObject(lVar3,0);
          if (lVar3 == null) goto LAB_180d0098d;
          cVar1 = GameObject.get_activeSelf(lVar3,0);
          if (!cVar1) {
            lVar3 = Component.get_transform(this,0);
            if (lVar3 == null) goto LAB_180d0098d;
            lVar3 = Transform.Find(lVar3,"HighLight",0);
            if (lVar3 == null) goto LAB_180d0098d;
            lVar3 = Component.get_gameObject(lVar3,0);
            if (lVar3 == null) goto LAB_180d0098d;
            uVar2 = 1;
            goto LAB_180d00830;
          }
        }
        lVar3 = this.innData;
        if (lVar3 == null) goto LAB_180d0098d;
        plVar6 = this.missionTarget;
        if (lVar3.plotNumCount < 1) {
          if (lVar3.missionNumCount < 1) {
            puVar5 = (uint32 *)FUN_180d98fe0(&local_18,0);
            if (plVar6 == (int64 *)0) goto LAB_180d0098d;
            lVar3 = *plVar6;
            goto LAB_180d00967;
          }
          if (*pStatics_b490 == 0) goto LAB_180d0098d;
          uVar2 = TextureController.LoadAtlasSprite
                            (*pStatics_b490,"UIAtlas","任务目标",0);
          if (plVar6 == (int64 *)0) goto LAB_180d0098d;
          Image.set_sprite(plVar6,uVar2,0);
          plVar6 = this.missionTarget;
          puVar5 = (uint32 *)FUN_1810d3570(&local_18,0);
        }
        else {
          if (*pStatics_b490 == 0) goto LAB_180d0098d;
          uVar2 = TextureController.LoadAtlasSprite
                            (*pStatics_b490,"UIAtlas","问号",0);
          if (plVar6 == (int64 *)0) goto LAB_180d0098d;
          Image.set_sprite(plVar6,uVar2,0);
          plVar6 = this.missionTarget;
          puVar5 = (uint32 *)Color.get_yellow(&local_18,0);
        }
        if (plVar6 == (int64 *)0) {
        LAB_180d0098d:
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
        lVar3 = *plVar6;
        LAB_180d00967:
        local_18 = *puVar5;
        uStack_14 = puVar5[1];
        uStack_10 = puVar5[2];
        uStack_c = puVar5[3];
        (**(code **)(lVar3 + 0x2a8))(plVar6,&local_18,*(uint64 *)(lVar3 + 0x2b0));
    }

    // Token : 0x6002021
    // RVA   : 0xCFFF10   Offset: 0xCFF310   Length: 0x453
    public void RefreshState()
    {
        var pStatics_3d40 = *(int64*)(DAT_181d73d40 + 184);
        var pStatics_4000 = *(int64*)(DAT_181d94000 + 184);
        bool cVar1;
        long lVar3;
        uint uVar6;
        uint local_38;
        uint uStack_34;
        uint uStack_30;
        uint32 uStack_2c;
        uint8 local_28 [32];
        if (PlotController.fightSkillIndexCache == 1) {
          lVar3 = *(int64 *)(pStatics_3d40 + 40);
          if ((this.innData == null) || (lVar3 == null)) throw; // [null/range check failed]
          cVar1 = FUN_18182a3a0(lVar3,this.innData.id,DAT_181d8f398)
          ;
          if (!(cVar1))
          {
            plVar2 = (int64 *)Component.GetComponent(this,DAT_181d94460);
            if (plVar2 == (int64 *)0) throw; // [null/range check failed]
            (**(code **)(*plVar2 + 0x2c8))(plVar2,0,*(uint64 *)(*plVar2 + 0x2d0));
            }
            else {
          }
          plVar2 = (int64 *)Component.GetComponent(this,DAT_181d94460);
          if ((*pStatics_4000 == 0) || (plVar2 == (int64 *)0))
          throw; // [null/range check failed]
          (**(code **)(*plVar2 + 0x2c8))
                    (plVar2,*(uint8 *)(*pStatics_4000 + 129),
                     *(uint64 *)(*plVar2 + 0x2d0));
        }
        plVar2 = (int64 *)Component.GetComponent(this,DAT_181d94460);
        if (plVar2 == (int64 *)0) throw; // [null/range check failed]
        cVar1 = (**(code **)(*plVar2 + 0x2b8))(plVar2,*(uint64 *)(*plVar2 + 0x2c0));
        if (!cVar1) {
        LAB_180d00258:
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
          plVar2 = (int64 *)Component.GetComponent(this,DAT_181d94460);
          plVar4 = (int64 *)Component.GetComponent(this,DAT_181d94460);
          if (plVar4 == (int64 *)0) throw; // [null/range check failed]
          puVar5 = (uint32 *)
                   (**(code **)(*plVar4 + 0x298))(local_28,plVar4,*(uint64 *)(*plVar4 + 0x2a0));
          local_38 = *puVar5;
          uStack_34 = puVar5[1];
          uStack_30 = puVar5[2];
          uStack_2c = puVar5[3];
          uVar6 = 0x3e19999a;
        }
        else {
          if (*pStatics_4000 == 0) throw; // [null/range check failed]
          if (*(char *)(*pStatics_4000 + 129) == false) goto LAB_180d00258;
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
          plVar2 = (int64 *)Component.GetComponent(this,DAT_181d94460);
          plVar4 = (int64 *)Component.GetComponent(this,DAT_181d94460);
          if (plVar4 == (int64 *)0) throw; // [null/range check failed]
          puVar5 = (uint32 *)
                   (**(code **)(*plVar4 + 0x298))(&local_38,plVar4,*(uint64 *)(*plVar4 + 0x2a0));
          local_38 = *puVar5;
          uStack_34 = puVar5[1];
          uStack_30 = puVar5[2];
          uStack_2c = puVar5[3];
          uVar6 = 0x3f800000;
        }
        puVar5 = (uint32 *)GlobalData.SetColorAlpha(local_28,&local_38,uVar6,0);
        if (plVar2 != (int64 *)0) {
          local_38 = *puVar5;
          uStack_34 = puVar5[1];
          uStack_30 = puVar5[2];
          uStack_2c = puVar5[3];
          (**(code **)(*plVar2 + 0x2a8))(plVar2,&local_38,*(uint64 *)(*plVar2 + 0x2b0));
          return;
        }
    }

    // Token : 0x6002022
    // RVA   : 0xCFFDF0   Offset: 0xCFF1F0   Length: 0x118
    public void RefreshNameScale()
    {
        var pStatics = *(int64*)(DAT_181d94000 + 184);
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

    // Token : 0x6002023
    // RVA   : 0xB23BF0   Offset: 0xB22FF0   Length: 0x50
    public virtual void OnDrag(PointerEventData eventData)
    {
        var pStatics = *(int64*)(DAT_181d93f80 + 184);
        if (*pStatics != 0) {
          QuickTravelBigMapSpriteController.OnDrag(*pStatics,eventData,0);
          return;
        }
    }

    // Token : 0x6002024
    // RVA   : 0xB23C50   Offset: 0xB23050   Length: 0x50
    public virtual void OnScroll(PointerEventData eventData)
    {
        var pStatics = *(int64*)(DAT_181d93f80 + 184);
        if (*pStatics != 0) {
          QuickTravelBigMapSpriteController.OnScroll(*pStatics,eventData,0);
          return;
        }
    }

    // Token : 0x6002025
    // RVA   : 0xCFFCF0   Offset: 0xCFF0F0   Length: 0xFA
    public void OnClick()
    {
        long lVar1;
        ulong uVar2;
        ulong uVar3;
        if (this.innIconType != 2) {
          return;
        }
        lVar1 = **(int64 **)(DAT_181da8710 + 184);
        if (this.innData != null) {
          uVar2 = String.Format("确认前往{0}吗？",this.innData.innName,0);
          if ((this.innData != null) &&
             (uVar3 = Int32.ToString(this.innData + 16,0), lVar1 != null)) {
            SureMenu.CallSureMenu(lVar1,uVar2,"SetPlayerMoveTargetInn",uVar3,"BigMapController",1,0);
            return;
          }
        }
    }

    // Token : 0x6002026
    // RVA   : 0x3A17B0   Offset: 0x3A0BB0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_18044ef50(this,0);
    }

}
