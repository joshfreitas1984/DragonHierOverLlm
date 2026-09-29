// ============================================================
// Type  : SelfDestroy
// Token : 0x200034D
// ============================================================

public class SelfDestroy
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001B49
    public float lifeTime;

    // Token: 0x4001B4A
    public float fadeTime;

    // Token: 0x4001B4B
    public bool useRealTime;

    // Token: 0x4001B4C
    public bool disableAsDestroy;

    // Token: 0x4001B4D
    public bool destroyWhenDisable;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60020DF
    // RVA   : 0x97B7F0   Offset: 0x97ABF0   Length: 0x351
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
            uVar2 = Component.GetComponent(this,DAT_181d938f8);
            cVar1 = Object.op_Inequality(uVar2,0,0);
            if (!cVar1) {
              uVar2 = Component.GetComponent(this,DAT_181d94478);
              cVar1 = Object.op_Inequality(uVar2,0,0);
              if (!cVar1) {
                uVar2 = Component.GetComponent(this,DAT_181d96178);
                cVar1 = Object.op_Inequality(uVar2,0,0);
                if (!cVar1) {
                  uVar2 = Component.GetComponent(this,DAT_181d95df8);
                  cVar1 = Object.op_Inequality(uVar2,0,0);
                  if (!cVar1) {
                    SelfDestroy.DestroySelf(this,0);
                    return;
                  }
                  uVar2 = Component.GetComponent(this,DAT_181d95df8);
                  uVar2 = DOTweenModuleSprite.DOFade(uVar2,0,this.fadeTime,0);
                }
                else {
                  uVar2 = Component.GetComponent(this,DAT_181d96178);
                  uVar2 = DOTweenModuleUI.DOFade(uVar2,0,this.fadeTime,0);
                }
              }
              else {
                uVar2 = Component.GetComponent(this,DAT_181d94478);
                uVar2 = DOTweenModuleUI.DOFade(uVar2,0,this.fadeTime,0);
              }
              uVar3 = new OnTooltipCB(this,DAT_181da5538,0);
              uVar2 = TweenSettingsExtensions.OnComplete(uVar2,uVar3,DAT_181dc0160);
              uVar3 = DAT_181dc1dc8;
            }
            else {
              uVar2 = Component.GetComponent(this,DAT_181d938f8);
              uVar2 = DOTweenModuleUI.DOFade(uVar2,0,this.fadeTime,0);
              uVar3 = new OnTooltipCB(this,DAT_181da5538,0);
              uVar2 = TweenSettingsExtensions.OnComplete(uVar2,uVar3,DAT_181dc01e8);
              uVar3 = DAT_181dc1e50;
            }
            TweenSettingsExtensions.SetUpdate(uVar2,this.useRealTime,uVar3);
          }
        }
    }

    // Token : 0x60020E0
    // RVA   : 0x97B750   Offset: 0x97AB50   Length: 0x85
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

    // Token : 0x60020E1
    // RVA   : 0x97B7E0   Offset: 0x97ABE0   Length: 0xE
    private void OnDisable()
    {
        void FUN_18097b7e0(int64 this)
        {
        if (this.destroyWhenDisable) {
          SelfDestroy.DestroySelf(this,0);
          return;
        }
    }

    // Token : 0x60020E2
    // RVA   : 0x97BB50   Offset: 0x97AF50   Length: 0xE
    public void /*ctor*/()
    {
        void FUN_18097bb50(int64 this)
        {
        this.lifeTime = 0xbf800000;
        FUN_18044ef50(this,0);
    }

}
