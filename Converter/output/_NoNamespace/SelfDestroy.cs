// ============================================================
// Type  : SelfDestroy
// Token : 0x200034D
// ============================================================

public class SelfDestroy
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001B48
    public float lifeTime;

    // Token: 0x4001B49
    public float fadeTime;

    // Token: 0x4001B4A
    public bool useRealTime;

    // Token: 0x4001B4B
    public bool disableAsDestroy;

    // Token: 0x4001B4C
    public bool destroyWhenDisable;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60020DF
    // RVA   : 0x97B160   Offset: 0x97A560   Length: 0x351
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
            uVar2 = Component.GetComponent(this,DAT_181d938e0);
            cVar1 = Object.op_Inequality(uVar2,0,0);
            if (!cVar1) {
              uVar2 = Component.GetComponent(this,DAT_181d94460);
              cVar1 = Object.op_Inequality(uVar2,0,0);
              if (!cVar1) {
                uVar2 = Component.GetComponent(this,DAT_181d96160);
                cVar1 = Object.op_Inequality(uVar2,0,0);
                if (!cVar1) {
                  uVar2 = Component.GetComponent(this,DAT_181d95de0);
                  cVar1 = Object.op_Inequality(uVar2,0,0);
                  if (!cVar1) {
                    SelfDestroy.DestroySelf(this,0);
                    return;
                  }
                  uVar2 = Component.GetComponent(this,DAT_181d95de0);
                  uVar2 = DOTweenModuleSprite.DOFade(uVar2,0,this.fadeTime,0);
                }
                else {
                  uVar2 = Component.GetComponent(this,DAT_181d96160);
                  uVar2 = DOTweenModuleUI.DOFade(uVar2,0,this.fadeTime,0);
                }
              }
              else {
                uVar2 = Component.GetComponent(this,DAT_181d94460);
                uVar2 = DOTweenModuleUI.DOFade(uVar2,0,this.fadeTime,0);
              }
              uVar3 = new OnTooltipCB(this,DAT_181da53a0,0);
              uVar2 = TweenSettingsExtensions.OnComplete(uVar2,uVar3,DAT_181dbffb0);
              uVar3 = DAT_181dc1c20;
            }
            else {
              uVar2 = Component.GetComponent(this,DAT_181d938e0);
              uVar2 = DOTweenModuleUI.DOFade(uVar2,0,this.fadeTime,0);
              uVar3 = new OnTooltipCB(this,DAT_181da53a0,0);
              uVar2 = TweenSettingsExtensions.OnComplete(uVar2,uVar3,DAT_181dc0038);
              uVar3 = DAT_181dc1ca8;
            }
            TweenSettingsExtensions.SetUpdate(uVar2,this.useRealTime,uVar3);
          }
        }
    }

    // Token : 0x60020E0
    // RVA   : 0x97B0C0   Offset: 0x97A4C0   Length: 0x85
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
    // RVA   : 0x97B150   Offset: 0x97A550   Length: 0xE
    private void OnDisable()
    {
        void FUN_18097b150(int64 this)
        {
        if (this.destroyWhenDisable) {
          SelfDestroy.DestroySelf(this,0);
          return;
        }
    }

    // Token : 0x60020E2
    // RVA   : 0x97B4C0   Offset: 0x97A8C0   Length: 0xE
    public void /*ctor*/()
    {
        void FUN_18097b4c0(int64 this)
        {
        this.lifeTime = 0xbf800000;
        FUN_18044ef50(this,0);
    }

}
