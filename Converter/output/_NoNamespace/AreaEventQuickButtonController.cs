// ============================================================
// Type  : AreaEventQuickButtonController
// Token : 0x2000145
// ============================================================

public class AreaEventQuickButtonController
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4000812
    public EventData targetEventData;

    // Token: 0x4000813
    public Image isNew;

    // Token: 0x4000814
    public Image missionTarget;

    // Token: 0x4000815
    private float refreshTime;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000A8C
    // RVA   : 0x7EAE40   Offset: 0x7EA240   Length: 0x47
    private void Update()
    {
        float fVar1;
        float fVar2;
        fVar2 = this.refreshTime;
        fVar1 = (float)Time.get_deltaTime(0);
        fVar2 = fVar2 - fVar1;
        this.refreshTime = fVar2;
        if (fVar2 <= 0.0) {
          this.refreshTime = 0x3e4ccccd;
          AreaEventQuickButtonController.RefreshColor(this,0);
        }
    }

    // Token : 0x6000A8D
    // RVA   : 0x7EABF0   Offset: 0x7E9FF0   Length: 0x24F
    public void RefreshColor()
    {
        var pStatics = *(int64*)(DAT_181dab490 + 184);
        long lVar1;
        ulong uVar3;
        uint local_18;
        uint uStack_14;
        uint uStack_10;
        uint32 uStack_c;
        lVar1 = this.targetEventData;
        if (lVar1 == null) throw; // [null/range check failed]
        plVar4 = this.missionTarget;
        if (lVar1.plotTargetEvent == false) {
          if (!lVar1.missionTargetEvent) {
            puVar2 = (uint32 *)FUN_180d98fe0(&local_18,0);
            if (plVar4 != (int64 *)0) {
              local_18 = *puVar2;
              uStack_14 = puVar2[1];
              uStack_10 = puVar2[2];
              uStack_c = puVar2[3];
              (**(code **)(*plVar4 + 0x2a8))(plVar4,&local_18,*(uint64 *)(*plVar4 + 0x2b0));
              plVar4 = this.isNew;
              if (this.targetEventData != null) {
                if (this.targetEventData.hovered == false) {
                  puVar2 = (uint32 *)FUN_1810d3570(&local_18);
                }
                else {
                  puVar2 = (uint32 *)FUN_180d98fe0();
                }
                if (plVar4 != (int64 *)0) {
                  local_18 = *puVar2;
                  uStack_14 = puVar2[1];
                  uStack_10 = puVar2[2];
                  uStack_c = puVar2[3];
                  (**(code **)(*plVar4 + 0x2a8))(plVar4,&local_18,*(uint64 *)(*plVar4 + 0x2b0));
                  return;
                }
              }
            }
            throw; // [null/range check failed]
          }
          if (*pStatics == 0) throw; // [null/range check failed]
          uVar3 = TextureController.LoadAtlasSprite
                            (*pStatics,"UIAtlas","任务目标",0);
          if (plVar4 == (int64 *)0) throw; // [null/range check failed]
          Image.set_sprite(plVar4,uVar3,0);
          plVar4 = this.missionTarget;
          puVar2 = (uint32 *)FUN_1810d3570(&local_18,0);
        }
        else {
          if (*pStatics == 0) throw; // [null/range check failed]
          uVar3 = TextureController.LoadAtlasSprite
                            (*pStatics,"UIAtlas","问号",0);
          if (plVar4 == (int64 *)0) throw; // [null/range check failed]
          Image.set_sprite(plVar4,uVar3,0);
          plVar4 = this.missionTarget;
          puVar2 = (uint32 *)Color.get_yellow(&local_18,0);
        }
        if (plVar4 != (int64 *)0) {
          local_18 = *puVar2;
          uStack_14 = puVar2[1];
          uStack_10 = puVar2[2];
          uStack_c = puVar2[3];
          (**(code **)(*plVar4 + 0x2a8))(plVar4,&local_18,*(uint64 *)(*plVar4 + 0x2b0));
          plVar4 = this.isNew;
          puVar2 = (uint32 *)FUN_180d98fe0(&local_18,0);
          if (plVar4 != (int64 *)0) {
            local_18 = *puVar2;
            uStack_14 = puVar2[1];
            uStack_10 = puVar2[2];
            uStack_c = puVar2[3];
            (**(code **)(*plVar4 + 0x2a8))(plVar4,&local_18,*(uint64 *)(*plVar4 + 0x2b0));
            return;
          }
        }
    }

    // Token : 0x6000A8E
    // RVA   : 0x7EA810   Offset: 0x7E9C10   Length: 0x251
    public void OnClick()
    {
        long lVar1;
        lVar1 = *(int64 *)(*(int64 *)(DAT_181dac458 + 184) + 16);
        if (lVar1 != null) {
          if (*(char *)(lVar1 + 48) != false) {
            plVar2 = (int64 *)Resources.Load("Sound/SoundEffect/WrongClick",0);
            plVar3 = (int64 *)0;
            if ((plVar2 != (int64 *)0) && (*plVar2 == DAT_181daf348)) {
              plVar3 = plVar2;
            }
            NGUITools.PlaySound(plVar3,0);
            return;
          }
          lVar1 = *(int64 *)(*(int64 *)(DAT_181d91b88 + 184) + 24);
          if (lVar1 != null) {
            PlotController.StartPlotEvent(lVar1,this.targetEventData,0);
            lVar1 = *(int64 *)(*(int64 *)(DAT_181dac758 + 184) + 56);
            if (lVar1 != null) {
              *(uint8 *)(lVar1 + 225) = 1;
              return;
            }
          }
        }
    }

    // Token : 0x6000A8F
    // RVA   : 0x7EAA70   Offset: 0x7E9E70   Length: 0x17C
    public void OnPointerEnter()
    {
        var pStatics = *(int64*)(DAT_181dac758 + 184);
        long lVar1;
        long lVar2;
        ulong uVar3;
        lVar1 = PlotController.SpringFestivelRewardLvTalkText;
        lVar2 = PlotController.SpringFestivelRewardLvTalkText;
        if (lVar2 != null) {
          uVar3 = AreaController.GetEventObj(lVar2,this.targetEventData,0);
          if (lVar1 != null) {
            AreaController.FocusOnTarget
                      (lVar1,uVar3,*(uint32 *)(pStatics + 20),0);
            if (this.targetEventData != null) {
              this.targetEventData.hovered = 1;
              return;
            }
          }
        }
    }

    // Token : 0x6000A90
    // RVA   : 0x245810   Offset: 0x244C10   Length: 0x3
    public void OnPointerExit()
    {
    }

    // Token : 0x6000A91
    // RVA   : 0x7EA750   Offset: 0x7E9B50   Length: 0xB7
    public GameObject EventObj()
    {
        long lVar1;
        lVar1 = *(int64 *)(*(int64 *)(DAT_181dac758 + 184) + 56);
        if (lVar1 != null) {
          AreaController.GetEventObj(lVar1,this.targetEventData,0);
          return;
        }
    }

    // Token : 0x6000A92
    // RVA   : 0x7EAE90   Offset: 0x7EA290   Length: 0xE
    public void /*ctor*/()
    {
        void FUN_1807eae90(int64 this)
        {
        this.refreshTime = 0x3e4ccccd;
        FUN_18044ef50(this,0);
    }

}
