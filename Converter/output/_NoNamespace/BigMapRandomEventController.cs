// ============================================================
// Type  : BigMapRandomEventController
// Token : 0x2000190
// ============================================================

public class BigMapRandomEventController
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4000A93
    public EventData bigMapRandomEventData;

    // Token: 0x4000A94
    public GameObject isNewIcon;

    // Token: 0x4000A95
    public GameObject isMissionTarget;

    // Token: 0x4000A96
    private bool showed;

    // Token: 0x4000A97
    private bool inited;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000CEC
    // RVA   : 0xCD6550   Offset: 0xCD4D50   Length: 0x4A3
    private void Update()
    {
        bool cVar1;
        uint uVar2;
        long lVar3;
        long lVar5;
        ulong uVar7;
        float fVar8;
        ulong local_38;
        float local_30;
        float local_28;
        float fStack_24;
        float fStack_20;
        float fStack_1c;
        lVar3 = this.bigMapRandomEventData;
        if (lVar3 != null) {
          if (!lVar3.happened) {
            if (!lVar3.seen) {
              lVar3 = Component.GetComponent(this,DAT_181d6d540);
              pfVar6 = (float *)FUN_180d904c0(&local_28,0);
              if (lVar3 != null) {
                local_28 = *pfVar6;
                fStack_24 = pfVar6[1];
                fStack_20 = pfVar6[2];
                fStack_1c = pfVar6[3];
                SpriteRenderer.set_color(lVar3,&local_28,0);
                lVar3 = Component.GetComponent(this,DAT_181d6adc0);
                if (lVar3 != null) {
                  Collider.set_enabled(lVar3,0,0);
                  lVar3 = Component.get_transform(this,0);
                  if (((lVar3 != null) && (lVar3 = Transform.Find(lVar3,"Smoke",0)) != null) &&
                     (lVar3 = Component.get_gameObject(lVar3,0)) != null) {
                    cVar1 = GameObject.get_activeSelf(lVar3,0);
                    if (!cVar1) {
                      return;
                    }
                    lVar3 = Component.get_transform(this,0);
                    if (((lVar3 != null) && (lVar3 = Transform.Find(lVar3,"Smoke",0)) != null) &&
                       (lVar3 = Component.get_gameObject(lVar3,0)) != null) {
                      GameObject.SetActive(lVar3,0,0);
                      return;
                    }
                  }
                }
              }
            }
            else {
              lVar3 = Component.get_transform(this,0);
              puVar4 = (uint64 *)Vector3.get_one(&local_28,0);
              local_30 = *(float *)(puVar4 + 1);
              local_38 = *puVar4;
              lVar5 = FUN_18046bbe0(0);
              if (lVar5 != null) {
                fVar8 = (float)BigMapController.BigMapNowScale(lVar5,0);
                fStack_20 = (float)Mathf.Max(1.0 / ((fVar8 * 9.0 + 1.0) * 0.1),0x3f800000,0);
                local_28 = (float)local_38 * fStack_20;
                fStack_24 = local_38._4_4_ * fStack_20;
                fStack_20 = local_30 * fStack_20;
                if (lVar3 != null) {
                  local_38 = CONCAT44(fStack_24,local_28);
                  local_30 = fStack_20;
                  Transform.set_localScale(lVar3,&local_38,0);
                  if (this.showed) {
        LAB_180cd6864:
                    if (!this.inited) {
                      BigMapRandomEventController.Init(this,0);
                    }
                    return;
                  }
                  this.showed = 1;
                  lVar3 = Component.GetComponent(this,DAT_181d6d540);
                  if (this.bigMapRandomEventData != null) {
                    uVar2 = EventData.GetEventRareLv(this.bigMapRandomEventData,0);
                    pfVar6 = (float *)GlobalData.GetEventColor(&local_28,uVar2,0);
                    local_28 = *pfVar6;
                    fStack_24 = pfVar6[1];
                    fStack_20 = pfVar6[2];
                    fStack_1c = pfVar6[3];
                    pfVar6 = (float *)GlobalData.SetColorAlpha(&local_38,&local_28,0,0);
                    if (lVar3 != null) {
                      local_28 = *pfVar6;
                      fStack_24 = pfVar6[1];
                      fStack_20 = pfVar6[2];
                      fStack_1c = pfVar6[3];
                      SpriteRenderer.set_color(lVar3,&local_28,0);
                      uVar7 = Component.GetComponent(this,DAT_181d6d540);
                      DOTweenModuleSprite.DOFade(uVar7,0x3f800000,0x3f800000,0);
                      lVar3 = Component.GetComponent(this,DAT_181d6adc0);
                      if (lVar3 != null) {
                        Collider.set_enabled(lVar3,1,0);
                        lVar3 = Component.get_transform(this,0);
                        if ((lVar3 != null) && (lVar3 = Transform.Find(lVar3,"Smoke",0)) != null)
                        {
                          lVar3 = Component.get_gameObject(lVar3,0);
                          if (lVar3 != null) {
                            GameObject.SetActive(lVar3,1,0);
                            lVar3 = Component.get_transform(this,0);
                            if (((lVar3 != null) &&
                                (lVar3 = Transform.Find(lVar3,"SeeRange",0)) != null) &&
                               (lVar3 = Component.get_gameObject(lVar3,0)) != null) {
                              GameObject.SetActive(lVar3,0,0);
                              goto LAB_180cd6864;
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
          else {
            lVar3 = Component.get_gameObject(this,0);
            if (lVar3 != null) {
              GameObject.SetActive(lVar3,0,0);
              uVar7 = Component.get_gameObject(this,0);
              Object.Destroy(uVar7,0);
              return;
            }
          }
        }
    }

    // Token : 0x6000CED
    // RVA   : 0xCD6100   Offset: 0xCD4900   Length: 0x34A
    public void Init()
    {
        var pStatics = *(int64*)(DAT_181d86270 + 184);
        long lVar1;
        float fVar2;
        bool cVar3;
        long lVar4;
        ulong uVar5;
        ulong local_48;
        ulong local_38;
        float local_30;
        uint local_18;
        uint uStack_14;
        uint uStack_10;
        uint32 uStack_c;
        lVar4 = this.bigMapRandomEventData;
        this.inited = 1;
        fVar2 = local_30;
        if (lVar4 == null) goto LAB_180cd6445;
        if (lVar4.plotTargetEvent == false) {
          if (!lVar4.missionTargetEvent) {
            lVar1 = this.isNewIcon;
            if (lVar4.hovered == false) {
              if (lVar1 != null) {
                cVar3 = GameObject.get_activeSelf(lVar1,0);
                if (!cVar3) {
                  fVar2 = local_30;
                  if (this.isNewIcon == null) goto LAB_180cd6445;
                  GameObject.SetActive(this.isNewIcon,1,0);
                }
                return;
              }
              goto LAB_180cd6445;
            }
            if (lVar1 == null) goto LAB_180cd6445;
            cVar3 = GameObject.get_activeSelf(lVar1,0);
            if (!cVar3) {
              return;
            }
          }
          else {
            if (this.isMissionTarget == null) goto LAB_180cd6445;
            GameObject.SetActive(this.isMissionTarget,1,0);
            fVar2 = local_30;
            if (this.isMissionTarget == null) goto LAB_180cd6445;
            lVar4 = GameObject.GetComponent(this.isMissionTarget,DAT_181da19b0);
            fVar2 = local_30;
            if ((*pStatics == 0) ||
               (uVar5 = TextureController.LoadAtlasSprite
                                  (*pStatics,"BigMapAtlas","任务目标",0),
               fVar2 = local_30, lVar4 == null)) goto LAB_180cd6445;
            SpriteRenderer.set_sprite(lVar4,uVar5,0);
            fVar2 = local_30;
            if (this.isMissionTarget == null) goto LAB_180cd6445;
            lVar4 = GameObject.GetComponent(this.isMissionTarget,DAT_181da19b0);
            puVar6 = (uint32 *)FUN_181098a50(&local_18,0);
            fVar2 = local_30;
            if (lVar4 == null) goto LAB_180cd6445;
            local_18 = *puVar6;
            uStack_14 = puVar6[1];
            uStack_10 = puVar6[2];
            uStack_c = puVar6[3];
            SpriteRenderer.set_color(lVar4,&local_18,0);
          }
        }
        else {
          if (this.isMissionTarget == null) goto LAB_180cd6445;
          GameObject.SetActive(this.isMissionTarget,1,0);
          fVar2 = local_30;
          if (this.isMissionTarget == null) goto LAB_180cd6445;
          lVar4 = GameObject.GetComponent(this.isMissionTarget,DAT_181da19b0);
          fVar2 = local_30;
          if ((*pStatics == 0) ||
             (uVar5 = TextureController.LoadAtlasSprite
                                (*pStatics,"BigMapAtlas","问号",0),
             fVar2 = local_30, lVar4 == null)) goto LAB_180cd6445;
          SpriteRenderer.set_sprite(lVar4,uVar5,0);
          fVar2 = local_30;
          if (this.isMissionTarget == null) goto LAB_180cd6445;
          lVar4 = GameObject.GetComponent(this.isMissionTarget,DAT_181da19b0);
          puVar6 = (uint32 *)Color.get_yellow(&local_18,0);
          fVar2 = local_30;
          if (lVar4 == null) goto LAB_180cd6445;
          local_18 = *puVar6;
          uStack_14 = puVar6[1];
          uStack_10 = puVar6[2];
          uStack_c = puVar6[3];
          SpriteRenderer.set_color(lVar4,&local_18,0);
          fVar2 = local_30;
          if (this.isMissionTarget == null) goto LAB_180cd6445;
          lVar4 = GameObject.get_transform(this.isMissionTarget,0);
          puVar7 = (uint64 *)Vector3.get_one(&local_18,0);
          local_38 = *puVar7;
          local_30 = *(float *)(puVar7 + 1) * 0.4;
          local_48 = CONCAT44((float)((uint64)local_38 >> 32) * 0.4,(float)local_38 * 0.4);
          fVar2 = *(float *)(puVar7 + 1);
          if (lVar4 == null) goto LAB_180cd6445;
          local_38 = local_48;
          Transform.set_localScale(lVar4,&local_38,0);
        }
        fVar2 = local_30;
        if (this.isNewIcon != null) {
          GameObject.SetActive(this.isNewIcon,0,0);
          return;
        }
        LAB_180cd6445:
        local_30 = fVar2;
    }

    // Token : 0x6000CEE
    // RVA   : 0xCD6450   Offset: 0xCD4C50   Length: 0xCC
    public void OnClick()
    {
        long lVar1;
        ulong uVar2;
        lVar1 = *(int64 *)(*(int64 *)(DAT_181d8baa8 + 184) + 16);
        uVar2 = Component.get_gameObject(this,0);
        if (lVar1 != null) {
          BigMapController.SetPlayerMoveTargetArea(lVar1,uVar2,0);
          return;
        }
    }

    // Token : 0x6000CEF
    // RVA   : 0x7ED860   Offset: 0x7EC060   Length: 0x5B
    public void OnDrag(Vector2 delta)
    {
        var pStatics = *(int64*)(DAT_181d8bca8 + 184);
        if (*pStatics != 0) {
          BigMapSpriteController.OnDrag(*pStatics,delta,0);
          return;
        }
    }

    // Token : 0x6000CF0
    // RVA   : 0x7ED8C0   Offset: 0x7EC0C0   Length: 0x57
    public void OnScroll(float delta)
    {
        var pStatics = *(int64*)(DAT_181d8bca8 + 184);
        if (*pStatics != 0) {
          BigMapSpriteController.OnScroll(*pStatics,delta,0);
          return;
        }
    }

    // Token : 0x6000CF1
    // RVA   : 0xCD6520   Offset: 0xCD4D20   Length: 0x2D
    public void OnHover()
    {
        if (this.bigMapRandomEventData != null) {
          this.bigMapRandomEventData.hovered = 1;
          if (this.isNewIcon != null) {
            GameObject.SetActive(this.isNewIcon,0,0);
            return;
          }
        }
    }

    // Token : 0x6000CF2
    // RVA   : 0x3A17B0   Offset: 0x39FFB0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_18044ef50(this,0);
    }

}
