// ============================================================
// Type  : SelfDestroy
// Token : 0x2000346
// ============================================================

public class SelfDestroy
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001A47
    public float lifeTime;

    // Token: 0x4001A48
    public float fadeTime;

    // Token: 0x4001A49
    public bool useRealTime;

    // Token: 0x4001A4A
    public bool disableAsDestroy;

    // Token: 0x4001A4B
    public bool destroyWhenDisable;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x600205E
    // RVA   : 0x968810   Offset: 0x967010   Length: 0x351
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
            uVar2 = Component.GetComponent(this,DAT_181d6b0c0);
            cVar1 = Object.op_Inequality(uVar2,0,0);
            if (!cVar1) {
              uVar2 = Component.GetComponent(this,DAT_181d6bc40);
              cVar1 = Object.op_Inequality(uVar2,0,0);
              if (!cVar1) {
                uVar2 = Component.GetComponent(this,DAT_181d6d8c0);
                cVar1 = Object.op_Inequality(uVar2,0,0);
                if (!cVar1) {
                  uVar2 = Component.GetComponent(this,DAT_181d6d540);
                  cVar1 = Object.op_Inequality(uVar2,0,0);
                  if (!cVar1) {
                    SelfDestroy.DestroySelf(this,0);
                    return;
                  }
                  uVar2 = Component.GetComponent(this,DAT_181d6d540);
                  uVar2 = DOTweenModuleSprite.DOFade(uVar2,0,this.fadeTime,0);
                }
                else {
                  uVar2 = Component.GetComponent(this,DAT_181d6d8c0);
                  uVar2 = DOTweenModuleUI.DOFade(uVar2,0,this.fadeTime,0);
                }
              }
              else {
                uVar2 = Component.GetComponent(this,DAT_181d6bc40);
                uVar2 = DOTweenModuleUI.DOFade(uVar2,0,this.fadeTime,0);
              }
              uVar3 = new OnTooltipCB(this,DAT_181d7c550,0);
              uVar2 = TweenSettingsExtensions.OnComplete(uVar2,uVar3,DAT_181d96cc8);
              uVar3 = DAT_181d98958;
            }
            else {
              uVar2 = Component.GetComponent(this,DAT_181d6b0c0);
              uVar2 = DOTweenModuleUI.DOFade(uVar2,0,this.fadeTime,0);
              uVar3 = new OnTooltipCB(this,DAT_181d7c550,0);
              uVar2 = TweenSettingsExtensions.OnComplete(uVar2,uVar3,DAT_181d96d50);
              uVar3 = DAT_181d989e0;
            }
            TweenSettingsExtensions.SetUpdate(uVar2,this.useRealTime,uVar3);
          }
        }
    }

    // Token : 0x600205F
    // RVA   : 0x968770   Offset: 0x966F70   Length: 0x85
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

    // Token : 0x6002060
    // RVA   : 0x968800   Offset: 0x967000   Length: 0xE
    private void OnDisable()
    {
        void FUN_180968800(int64 this)
        {
        if (this.destroyWhenDisable) {
          SelfDestroy.DestroySelf(this,0);
          return;
        }
    }

    // Token : 0x6002061
    // RVA   : 0x968B70   Offset: 0x967370   Length: 0xE
    public void /*ctor*/()
    {
        void FUN_180968b70(int64 this)
        {
        this.lifeTime = 0xbf800000;
        FUN_18044ef50(this,0);
    }

}
