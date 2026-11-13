// ============================================================
// Type  : SelfDestroy
// Token : 0x200035A
// ============================================================

public class SelfDestroy
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001BC7
    public float lifeTime;

    // Token: 0x4001BC8
    public float fadeTime;

    // Token: 0x4001BC9
    public bool useRealTime;

    // Token: 0x4001BCA
    public bool disableAsDestroy;

    // Token: 0x4001BCB
    public bool destroyWhenDisable;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6002187
    // RVA   : 0x6A2DF0   Offset: 0x6A1BF0   Length: 0x351
    private void Update()
    {
        bool cVar1;
        ulong uVar2;
        ulong uVar3;
        float fVar4;
        float fVar5;
        fVar5 = this.lifeTime;
        if (0.0 < fVar5) {
          if (!this.useRealTime) {
            fVar4 = (float)Time.get_deltaTime();
          }
          else {
            fVar4 = (float)RealTime.get_deltaTime();
          }
          fVar5 = fVar5 - fVar4;
          this.lifeTime = fVar5;
          if (fVar5 <= 0.0) {
            if (this.fadeTime <= 0.0) {
              SelfDestroy.DestroySelf(this,0);
              return;
            }
            uVar2 = Component.GetComponent(this,DAT_181e76c38);
            cVar1 = Object.op_Inequality(uVar2,0,0);
            if (!cVar1) {
              uVar2 = Component.GetComponent(this,DAT_181e777b8);
              cVar1 = Object.op_Inequality(uVar2,0,0);
              if (!cVar1) {
                uVar2 = Component.GetComponent(this,DAT_181e79538);
                cVar1 = Object.op_Inequality(uVar2,0,0);
                if (!cVar1) {
                  uVar2 = Component.GetComponent(this,DAT_181e791b8);
                  cVar1 = Object.op_Inequality(uVar2,0,0);
                  if (!cVar1) {
                    SelfDestroy.DestroySelf(this,0);
                    return;
                  }
                  uVar2 = Component.GetComponent(this,DAT_181e791b8);
                  uVar2 = DOTweenModuleSprite.DOFade(uVar2,0,this.fadeTime,0);
                }
                else {
                  uVar2 = Component.GetComponent(this,DAT_181e79538);
                  uVar2 = DOTweenModuleUI.DOFade(uVar2,0,this.fadeTime,0);
                }
              }
              else {
                uVar2 = Component.GetComponent(this,DAT_181e777b8);
                uVar2 = DOTweenModuleUI.DOFade(uVar2,0,this.fadeTime,0);
              }
              uVar3 = new OnTooltipCB(this,DAT_181e88af8,0);
              uVar2 = TweenSettingsExtensions.OnComplete(uVar2,uVar3,DAT_181ea3ba0);
              uVar3 = DAT_181ea5848;
            }
            else {
              uVar2 = Component.GetComponent(this,DAT_181e76c38);
              uVar2 = DOTweenModuleUI.DOFade(uVar2,0,this.fadeTime,0);
              uVar3 = new OnTooltipCB(this,DAT_181e88af8,0);
              uVar2 = TweenSettingsExtensions.OnComplete(uVar2,uVar3,DAT_181ea3c28);
              uVar3 = DAT_181ea58d0;
            }
            TweenSettingsExtensions.SetUpdate(uVar2,this.useRealTime,uVar3);
          }
        }
    }

    // Token : 0x6002188
    // RVA   : 0x6A2D50   Offset: 0x6A1B50   Length: 0x85
    public void DestroySelf()
    {
        ulong uVar1;
        long lVar2;
        if (!this.disableAsDestroy) {
          uVar1 = Component.get_gameObject(this);
          Object.Destroy(uVar1,0);
          return;
        }
        lVar2 = Component.get_gameObject(this);
        if (lVar2 != null) {
          GameObject.SetActive(lVar2,0,0);
          return;
        }
    }

    // Token : 0x6002189
    // RVA   : 0x6A2DE0   Offset: 0x6A1BE0   Length: 0xE
    private void OnDisable()
    {
        void FUN_1806a2de0(int64 this)
        {
        if (this.destroyWhenDisable) {
          SelfDestroy.DestroySelf(this,0);
          return;
        }
    }

    // Token : 0x600218A
    // RVA   : 0x6A3150   Offset: 0x6A1F50   Length: 0xE
    public void /*ctor*/()
    {
        void FUN_1806a3150(int64 this)
        {
        this.lifeTime = 0xbf800000;
        FUN_180ae8740(this,0);
    }

}
