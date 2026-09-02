// ============================================================
// Type  : SureStartButtonController
// Token : 0x2000391
// ============================================================

public class SureStartButtonController
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001C61
    private Image cover;

    // Token: 0x4001C62
    private bool pointerDown;

    // Token: 0x4001C63
    private bool gameStart;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x600225C
    // RVA   : 0xB9B9C0   Offset: 0xB9A1C0   Length: 0x7F
    private void Start()
    {
        long lVar1;
        ulong uVar2;
        lVar1 = Component.get_transform(this,0);
        if (lVar1 != null) {
          lVar1 = Transform.Find(lVar1,"Cover",0);
          if (lVar1 != null) {
            uVar2 = Component.GetComponent(lVar1,DAT_181d6bc40);
            this.cover = uVar2;
            return;
          }
        }
    }

    // Token : 0x600225D
    // RVA   : 0xB9BA40   Offset: 0xB9A240   Length: 0x634
    private void Update()
    {
        var pStatics_15f0 = *(int64*)(DAT_181d815f0 + 184);
        var pStatics_4e18 = *(int64*)(DAT_181d64e18 + 184);
        ulong uVar1;
        bool cVar2;
        int iVar3;
        ulong uVar4;
        long lVar5;
        float fVar9;
        float fVar10;
        ulong local_78;
        ulong local_68;
        float local_60;
        uint local_48;
        uint uStack_44;
        uint uStack_40;
        uint32 uStack_3c;
        uint64 local_38;
        uint64 uStack_30;
        if (!this.gameStart) {
          lVar5 = this.cover;
          if (!this.pointerDown) {
            if (lVar5 == null) goto LAB_180b9c069;
            fVar10 = *(float *)(lVar5 + 244);
            fVar9 = (float)Time.get_deltaTime(0);
            Image.set_fillAmount(lVar5,fVar10 - fVar9,0);
          }
          else {
            if (lVar5 == null) goto LAB_180b9c069;
            fVar10 = *(float *)(lVar5 + 244);
            fVar9 = (float)Time.get_deltaTime(0);
            Image.set_fillAmount(lVar5,fVar9 + fVar10,0);
            if (this.cover == null) goto LAB_180b9c069;
            if (1.0 <= *(float *)(this.cover + 244)) {
              this.gameStart = 1;
              plVar7 = (int64 *)Resources.Load("Sound/SoundEffect/SpeEffect/水滴",0);
              plVar8 = (int64 *)0;
              if ((plVar7 != (int64 *)0) && (*plVar7 == DAT_181d8a228)) {
                plVar8 = plVar7;
              }
              NGUITools.PlaySound(plVar8,0);
              if (this.cover == null) goto LAB_180b9c069;
              uVar4 = Component.get_transform(this.cover,0);
              uVar4 = ShortcutExtensions.DOScale(uVar4,0x41f00000,0x3f800000,0);
              lVar5 = *(int64 *)(pStatics_4e18 + 8);
              if (lVar5 == null) {
                uVar1 = **(uint64 **)(DAT_181d64e18 + 184);
                lVar5 = new OnTooltipCB(uVar1,DAT_181d8be10,0);
                plVar7 = (int64 *)(pStatics_4e18 + 8);
                *plVar7 = lVar5;
                il2cpp_internal(plVar7,lVar5);
              }
              uVar4 = TweenSettingsExtensions.OnComplete(uVar4,lVar5,DAT_181d96ee8);
              TweenSettingsExtensions.SetEase(uVar4,3,DAT_181d97ca8);
              lVar5 = Component.get_transform(this,0);
              if ((lVar5 == null) || (lVar5 = Transform.Find(lVar5,"Text",0)) == null)
              goto LAB_180b9c069;
              uVar4 = Component.GetComponent(lVar5,DAT_181d6d8c0);
              DOTweenModuleUI.DOFade(uVar4,0,0x3f000000,0);
              lVar5 = *(int64 *)(*(int64 *)(DAT_181d4e010 + 184) + 8);
              if ((lVar5 == null) || (lVar5 = *(int64 *)(lVar5 + 16)) == null) goto LAB_180b9c069;
              iVar3 = PlayerPrefDictionary.GetInt(lVar5,"NewGameTime",0);
              PlayerPrefDictionary.SetKey(lVar5,"NewGameTime",iVar3 + 1,0);
            }
          }
          if ((*pStatics_15f0 == 0) ||
             (lVar5 = *(int64 *)(*pStatics_15f0 + 48)) == null) {
        LAB_180b9c069:
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          uVar4 = GameObject.get_transform(lVar5,0);
          cVar2 = DOTween.IsTweening(uVar4,0,0);
          if (!cVar2) {
            lVar5 = FUN_1807e86e0(0);
            fVar10 = local_60;
            if ((lVar5 != null) && (*(int64 *)(lVar5 + 48) != 0)) {
              lVar5 = GameObject.get_transform(*(int64 *)(lVar5 + 48),0);
              fVar10 = local_60;
              if (this.cover != null) {
                fVar10 = *(float *)(this.cover + 244);
                puVar6 = (uint64 *)Vector3.get_one(&local_48,0);
                local_68 = *puVar6;
                fVar10 = fVar10 * 0.5 + 1.7;
                local_60 = *(float *)(puVar6 + 1) * fVar10;
                local_78 = CONCAT44((float)((uint64)local_68 >> 32) * fVar10,(float)local_68 * fVar10
                                   );
                fVar10 = *(float *)(puVar6 + 1);
                if (lVar5 != null) {
                  local_68 = local_78;
                  Transform.set_localScale(lVar5,&local_68,0);
                  lVar5 = FUN_1807e86e0(0);
                  fVar10 = local_60;
                  if ((lVar5 != null) && (*(int64 *)(lVar5 + 48) != 0)) {
                    plVar7 = (int64 *)
                             GameObject.GetComponent(*(int64 *)(lVar5 + 48),DAT_181d9fe50);
                    fVar10 = local_60;
                    if (this.cover != null) {
                      local_38 = 0;
                      uStack_30 = 0;
                      FUN_1809981e0(&local_38,0x3f800000,0x3f800000,0x3f800000,
                                    (*(float *)(this.cover + 244) * 80.0 + 150.0) /
                                    255.0,0);
                      fVar10 = local_60;
                      if (plVar7 != (int64 *)0) {
                        local_48 = (uint32)local_38;
                        uStack_44 = local_38._4_4_;
                        uStack_40 = (uint32)uStack_30;
                        uStack_3c = uStack_30._4_4_;
                        (**(code **)(*plVar7 + 0x2a8))(plVar7,&local_48,*(uint64 *)(*plVar7 + 0x2b0));
                        return;
                      }
                    }
                  }
                }
              }
            }
            local_60 = fVar10;
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
        }
    }

    // Token : 0x600225E
    // RVA   : 0xB9B690   Offset: 0xB99E90   Length: 0x2C7
    public virtual void OnPointerDown(PointerEventData eventData)
    {
        var pStatics = *(int64*)(DAT_181d815f0 + 184);
        bool cVar1;
        long lVar2;
        if ((*pStatics == 0) ||
           (lVar2 = *(int64 *)(*pStatics + 72)) == null)
        throw; // [null/range check failed]
        cVar1 = FUN_1816fd990(*(uint64 *)(lVar2 + 0x170),"",0);
        if (!cVar1) {
          if ((*pStatics == 0) ||
             (lVar2 = *(int64 *)(*pStatics + 80)) == null)
          throw; // [null/range check failed]
          cVar1 = FUN_1816fd990(*(uint64 *)(lVar2 + 0x170),"",0);
          if (!cVar1) {
            this.pointerDown = 1;
            lVar2 = Component.GetComponent(this,DAT_181d6ab40);
            if (lVar2 != null) {
              AudioSource.Play(lVar2,0);
              return;
            }
            throw; // [null/range check failed]
          }
        }
        if (*pStatics != 0) {
          StartMenuController.ShowTextOnMouse(*pStatics,"请完整设置角色姓名！",0);
          plVar3 = (int64 *)Resources.Load("Sound/SoundEffect/WrongClick",0);
          plVar4 = (int64 *)0;
          if ((plVar3 != (int64 *)0) && (*plVar3 == DAT_181d8a228)) {
            plVar4 = plVar3;
          }
          NGUITools.PlaySound(plVar4,0);
          return;
        }
    }

    // Token : 0x600225F
    // RVA   : 0xB9B960   Offset: 0xB9A160   Length: 0x5D
    public virtual void OnPointerUp(PointerEventData eventData)
    {
        long lVar1;
        if (!this.gameStart) {
          this.pointerDown = 0;
          lVar1 = Component.GetComponent(this,DAT_181d6ab40);
          if (lVar1 != null) {
            AudioSource.Stop(lVar1,0);
            return;
          }
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
    }

    // Token : 0x6002260
    // RVA   : 0x3A17B0   Offset: 0x39FFB0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_18044ef50(this,0);
    }

}
