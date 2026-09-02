// ============================================================
// Type  : AreaMapRandomEventController
// Token : 0x2000143
// ============================================================

public class AreaMapRandomEventController
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4000803
    public EventData areaMapRandomEventData;

    // Token: 0x4000804
    public GameObject isNewIcon;

    // Token: 0x4000805
    public GameObject isMissionTarget;

    // Token: 0x4000806
    private float refreshTime;

    // Token: 0x4000807
    private bool inited;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000A7A
    // RVA   : 0x7EE920   Offset: 0x7ED120   Length: 0xB7
    private void Init()
    {
        long lVar1;
        uint uVar3;
        uint local_18;
        uint uStack_14;
        uint uStack_10;
        uint32 uStack_c;
        this.inited = 1;
        lVar1 = Component.GetComponent(this,DAT_181d6d540);
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

    // Token : 0x6000A7B
    // RVA   : 0x7EEEE0   Offset: 0x7ED6E0   Length: 0x2BA
    private void Update()
    {
        var pStatics = *(int64*)(DAT_181d87630 + 184);
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
          lVar2 = Component.GetComponent(this,DAT_181d6d540);
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
          lVar2 = *(int64 *)(pStatics + 56);
          if (lVar2 != null) {
            AreaController.DeleteEventButton(lVar2,this.areaMapRandomEventData,0);
            lVar2 = *(int64 *)(pStatics + 56);
            if (lVar2 != null) {
              lVar2 = *(int64 *)(lVar2 + 184);
              uVar4 = Component.get_gameObject(this,0);
              if (lVar2 != null) {
                FUN_181801c10(lVar2,uVar4,DAT_181d61e78);
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

    // Token : 0x6000A7C
    // RVA   : 0x7EEC60   Offset: 0x7ED460   Length: 0x27C
    public void RefreshColor()
    {
        var pStatics = *(int64*)(DAT_181d86270 + 184);
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
            lVar3 = GameObject.GetComponent(this.isMissionTarget,DAT_181da19b0);
            if ((*pStatics == 0) ||
               (uVar4 = TextureController.LoadAtlasSprite
                                  (*pStatics,"UIAtlas","任务目标",0),
               lVar3 == null)) throw; // [null/range check failed]
            SpriteRenderer.set_sprite(lVar3,uVar4,0);
            if (this.isMissionTarget == null) throw; // [null/range check failed]
            lVar3 = GameObject.GetComponent(this.isMissionTarget,DAT_181da19b0);
            puVar5 = (uint32 *)FUN_181098a50(&local_18,0);
            goto LAB_1807eee9d;
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
          lVar3 = GameObject.GetComponent(this.isMissionTarget,DAT_181da19b0);
          if ((*pStatics == 0) ||
             (uVar4 = TextureController.LoadAtlasSprite
                                (*pStatics,"UIAtlas","问号",0),
             lVar3 == null)) throw; // [null/range check failed]
          SpriteRenderer.set_sprite(lVar3,uVar4,0);
          if (this.isMissionTarget == null) throw; // [null/range check failed]
          lVar3 = GameObject.GetComponent(this.isMissionTarget,DAT_181da19b0);
          puVar5 = (uint32 *)Color.get_yellow(&local_18,0);
        LAB_1807eee9d:
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

    // Token : 0x6000A7D
    // RVA   : 0x7EE9E0   Offset: 0x7ED1E0   Length: 0x250
    public void OnClick()
    {
        var pStatics = *(int64*)(DAT_181d6c960 + 184);
        long lVar1;
        lVar1 = *(int64 *)(*(int64 *)(DAT_181d87338 + 184) + 16);
        if (lVar1 != null) {
          if (*(char *)(lVar1 + 48) != false) {
            plVar2 = (int64 *)Resources.Load("Sound/SoundEffect/WrongClick",0);
            plVar3 = (int64 *)0;
            if ((plVar2 != (int64 *)0) && (*plVar2 == DAT_181d8a228)) {
              plVar3 = plVar2;
            }
            NGUITools.PlaySound(plVar3,0);
            return;
          }
          if (*pStatics != 0) {
            PlotController.StartPlotEvent
                      (*pStatics,this.areaMapRandomEventData,0);
            lVar1 = *(int64 *)(*(int64 *)(DAT_181d87630 + 184) + 56);
            if (lVar1 != null) {
              *(uint8 *)(lVar1 + 225) = 1;
              return;
            }
          }
        }
    }

    // Token : 0x6000A7E
    // RVA   : 0x7EEC40   Offset: 0x7ED440   Length: 0x1B
    public void OnHover()
    {
        if (this.areaMapRandomEventData != null) {
          this.areaMapRandomEventData.hovered = 1;
          return;
        }
    }

    // Token : 0x6000A7F
    // RVA   : 0x7ECFE0   Offset: 0x7EB7E0   Length: 0xE
    public void /*ctor*/()
    {
        void FUN_1807ecfe0(int64 this)
        {
        this.refreshTime = 0x3e4ccccd;
        FUN_18044ef50(this,0);
    }

}
