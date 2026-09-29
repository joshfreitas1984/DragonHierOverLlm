// ============================================================
// Type  : AreaMapRandomEventController
// Token : 0x2000147
// ============================================================

public class AreaMapRandomEventController
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x400082A
    public EventData areaMapRandomEventData;

    // Token: 0x400082B
    public GameObject isNewIcon;

    // Token: 0x400082C
    public GameObject isMissionTarget;

    // Token: 0x400082D
    private float refreshTime;

    // Token: 0x400082E
    private bool inited;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000A9D
    // RVA   : 0x7ECC80   Offset: 0x7EC080   Length: 0xB7
    private void Init()
    {
        long lVar1;
        uint uVar3;
        uint local_18;
        uint uStack_14;
        uint uStack_10;
        uint32 uStack_c;
        this.inited = 1;
        lVar1 = Component.GetComponent(this,DAT_181d95df8);
        if (this.areaMapRandomEventData != null) {
          uVar3 = EventData.GetEventRareLv(this.areaMapRandomEventData,0);
          puVar2 = (uint32 *)GlobalData.GetEventColor(&local_18,uVar3,0);
          if (lVar1 != null) {
            local_18 = *puVar2;
            uStack_14 = puVar2[1];
            uStack_10 = puVar2[2];
            uStack_c = puVar2[3];
            SpriteRenderer.set_color(lVar1,&local_18,0);
            return;
          }
        }
    }

    // Token : 0x6000A9E
    // RVA   : 0x7ED240   Offset: 0x7EC640   Length: 0x2BA
    private void Update()
    {
        uint uVar1;
        long lVar2;
        ulong uVar4;
        float fVar5;
        float fVar6;
        uint local_28;
        uint uStack_24;
        uint uStack_20;
        uint32 uStack_1c;
        if (!this.inited) {
          this.inited = 1;
          lVar2 = Component.GetComponent(this,DAT_181d95df8);
          if (this.areaMapRandomEventData == null) throw; // [null/range check failed]
          uVar1 = EventData.GetEventRareLv(this.areaMapRandomEventData,0);
          puVar3 = (uint32 *)GlobalData.GetEventColor(&local_28,uVar1,0);
          if (lVar2 == null) throw; // [null/range check failed]
          local_28 = *puVar3;
          uStack_24 = puVar3[1];
          uStack_20 = puVar3[2];
          uStack_1c = puVar3[3];
          SpriteRenderer.set_color(lVar2,&local_28,0);
        }
        if (this.areaMapRandomEventData != null) {
          if (!this.areaMapRandomEventData.happened) {
            fVar6 = this.refreshTime;
            fVar5 = (float)Time.get_deltaTime(0);
            fVar6 = fVar6 - fVar5;
            this.refreshTime = fVar6;
            if (fVar6 <= 0.0) {
              this.refreshTime = 0x3e4ccccd;
              AreaMapRandomEventController.RefreshColor(this,0);
            }
            return;
          }
          lVar2 = PlotController.SpringFestivelRewardLvTalkText;
          if (lVar2 != null) {
            AreaController.DeleteEventButton(lVar2,this.areaMapRandomEventData,0);
            lVar2 = PlotController.SpringFestivelRewardLvTalkText;
            if (lVar2 != null) {
              lVar2 = *(int64 *)(lVar2 + 184);
              uVar4 = Component.get_gameObject(this,0);
              if (lVar2 != null) {
                FUN_1817ef410(lVar2,uVar4,DAT_181d89630);
                lVar2 = Component.get_gameObject(this,0);
                if (lVar2 != null) {
                  GameObject.SetActive(lVar2,0,0);
                  uVar4 = Component.get_gameObject(this,0);
                  Object.Destroy(uVar4,0);
                  return;
                }
              }
            }
          }
        }
    }

    // Token : 0x6000A9F
    // RVA   : 0x7ECFC0   Offset: 0x7EC3C0   Length: 0x27C
    public void RefreshColor()
    {
        var pStatics = *(int64*)(DAT_181dab4a8 + 184);
        long lVar1;
        bool cVar2;
        long lVar3;
        ulong uVar4;
        uint local_18;
        uint uStack_14;
        uint uStack_10;
        uint32 uStack_c;
        lVar3 = this.areaMapRandomEventData;
        if (lVar3 == null) throw; // [null/range check failed]
        if (lVar3.plotTargetEvent == false) {
          if (lVar3.missionTargetEvent) {
            if (this.isMissionTarget == null) throw; // [null/range check failed]
            GameObject.SetActive(this.isMissionTarget,1,0);
            if (this.isMissionTarget == null) throw; // [null/range check failed]
            lVar3 = GameObject.GetComponent(this.isMissionTarget,DAT_181d73bb8);
            if ((*pStatics == 0) ||
               (uVar4 = TextureController.LoadAtlasSprite
                                  (*pStatics,"UIAtlas","任务目标",0),
               lVar3 == null)) throw; // [null/range check failed]
            SpriteRenderer.set_sprite(lVar3,uVar4,0);
            if (this.isMissionTarget == null) throw; // [null/range check failed]
            lVar3 = GameObject.GetComponent(this.isMissionTarget,DAT_181d73bb8);
            puVar5 = (uint32 *)FUN_1810d3b80(&local_18,0);
            goto LAB_1807ed1fd;
          }
          lVar1 = this.isNewIcon;
          if (lVar3.hovered == false) {
            if (lVar1 != null) {
              cVar2 = GameObject.get_activeSelf(lVar1,0);
              if (!cVar2) {
                if (this.isNewIcon == null) throw; // [null/range check failed]
                GameObject.SetActive(this.isNewIcon,1,0);
              }
              return;
            }
            throw; // [null/range check failed]
          }
          if (lVar1 == null) throw; // [null/range check failed]
          cVar2 = GameObject.get_activeSelf(lVar1,0);
          if (!cVar2) {
            return;
          }
        }
        else {
          if (this.isMissionTarget == null) throw; // [null/range check failed]
          GameObject.SetActive(this.isMissionTarget,1,0);
          if (this.isMissionTarget == null) throw; // [null/range check failed]
          lVar3 = GameObject.GetComponent(this.isMissionTarget,DAT_181d73bb8);
          if ((*pStatics == 0) ||
             (uVar4 = TextureController.LoadAtlasSprite
                                (*pStatics,"UIAtlas","问号",0),
             lVar3 == null)) throw; // [null/range check failed]
          SpriteRenderer.set_sprite(lVar3,uVar4,0);
          if (this.isMissionTarget == null) throw; // [null/range check failed]
          lVar3 = GameObject.GetComponent(this.isMissionTarget,DAT_181d73bb8);
          puVar5 = (uint32 *)Color.get_yellow(&local_18,0);
        LAB_1807ed1fd:
          if (lVar3 == null) throw; // [null/range check failed]
          local_18 = *puVar5;
          uStack_14 = puVar5[1];
          uStack_10 = puVar5[2];
          uStack_c = puVar5[3];
          SpriteRenderer.set_color(lVar3,&local_18,0);
        }
        if (this.isNewIcon != null) {
          GameObject.SetActive(this.isNewIcon,0,0);
          return;
        }
    }

    // Token : 0x6000AA0
    // RVA   : 0x7ECD40   Offset: 0x7EC140   Length: 0x251
    public void OnClick()
    {
        long lVar1;
        lVar1 = *(int64 *)(*(int64 *)(DAT_181dac470 + 184) + 16);
        if (lVar1 != null) {
          if (*(char *)(lVar1 + 48) != false) {
            plVar2 = (int64 *)Resources.Load("Sound/SoundEffect/WrongClick",0);
            plVar3 = (int64 *)0;
            if ((plVar2 != (int64 *)0) && (*plVar2 == DAT_181daf360)) {
              plVar3 = plVar2;
            }
            NGUITools.PlaySound(plVar3,0);
            return;
          }
          lVar1 = *(int64 *)(*(int64 *)(DAT_181d91ba0 + 184) + 24);
          if (lVar1 != null) {
            PlotController.StartPlotEvent(lVar1,this.areaMapRandomEventData,0);
            lVar1 = *(int64 *)(*(int64 *)(DAT_181dac770 + 184) + 56);
            if (lVar1 != null) {
              *(uint8 *)(lVar1 + 225) = 1;
              return;
            }
          }
        }
    }

    // Token : 0x6000AA1
    // RVA   : 0x7ECFA0   Offset: 0x7EC3A0   Length: 0x1B
    public void OnHover()
    {
        if (this.areaMapRandomEventData != null) {
          this.areaMapRandomEventData.hovered = 1;
          return;
        }
    }

    // Token : 0x6000AA2
    // RVA   : 0x7EAE90   Offset: 0x7EA290   Length: 0xE
    public void /*ctor*/()
    {
        void FUN_1807eae90(int64 this)
        {
        this.refreshTime = 0x3e4ccccd;
        FUN_18044ef50(this,0);
    }

}
