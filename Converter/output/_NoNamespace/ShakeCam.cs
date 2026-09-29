// ============================================================
// Type  : ShakeCam
// Token : 0x2000350
// ============================================================

public class ShakeCam
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001B66
    public Camera[] cam;

    // Token: 0x4001B67
    public Tweener[] camTweener;

    // Token: 0x4001B68
    public ShakeStrengthType shakeStrengthType;

    // Token: 0x4001B69
    private float shakeDelta;

    // Token: 0x4001B6A
    private float shakeTime;

    // Token: 0x4001B6B
    private static ShakeCam _instance;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60020FA
    // RVA   : 0x97E3F0   Offset: 0x97D7F0   Length: 0x36
    public static ShakeCam get_Instance()
    {
        return **(uint64 **)(DAT_181da1bf8 + 184);
    }

    // Token : 0x60020FB
    // RVA   : 0x97DFA0   Offset: 0x97D3A0   Length: 0x43
    private void Awake()
    {
        puVar1 = *(uint64 **)(DAT_181da1bf8 + 184);
        *puVar1 = this;
        il2cpp_internal(puVar1,this);
    }

    // Token : 0x60020FC
    // RVA   : 0x97DFF0   Offset: 0x97D3F0   Length: 0x3C2
    public void StartShake(ShakeStrengthType targetShakeStrength, bool shakeUI)
    {
        long lVar1;
        int iVar2;
        ulong uVar3;
        ulong uVar4;
        uint uVar5;
        lVar1 = *(int64 *)(*(int64 *)(DAT_181d72d50 + 184) + 8);
        if ((lVar1 != null) && (lVar1 = *(int64 *)(lVar1 + 16)) != null) {
          iVar2 = PlayerPrefDictionary.GetInt(lVar1,"noShake",0);
          if ((iVar2 == 1) || (targetShakeStrength < this.shakeStrengthType)) {
            return;
          }
          uVar5 = 0;
          lVar1 = this.cam;
          while (lVar1 != null) {
            if (*(int *)(lVar1 + 24) <= (int)uVar5) {
              lVar1 = BuildingUIController.PartyLvName;
              if ((lVar1 != null) && (lVar1 = *(int64 *)(lVar1 + 32)) != null) {
                uVar4 = GameObject.get_transform(lVar1,0);
                ShortcutExtensions.DOComplete(uVar4,0,0);
                this.shakeStrengthType = targetShakeStrength;
                if (targetShakeStrength == 1) {
                  this.shakeDelta = 0x3d23d70a;
                  this.shakeTime = 0x3dcccccd;
                }
                else if (targetShakeStrength == 2) {
                  this.shakeDelta = 0x3da3d70a;
                  this.shakeTime = 0x3e99999a;
                }
                else if (targetShakeStrength == 3) {
                  this.shakeDelta = 0x3e19999a;
                  this.shakeTime = 0x3ecccccd;
                }
                else if (targetShakeStrength == 4) {
                  this.shakeDelta = 0x3e4ccccd;
                  this.shakeTime = 0x3f000000;
                }
                lVar1 = this.cam;
                if (lVar1 != null) {
                  if (*(int *)(lVar1 + 24) == 0) {
                    uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                    FUN_1800d65f0(uVar4,0);
                  }
                  uVar4 = ShortcutExtensions.DOShakePosition
                                    (*(uint64 *)(lVar1 + 32),this.shakeTime,
                                     this.shakeDelta,30,0x42b40000,1,0);
                  uVar3 = new OnTooltipCB(this,DAT_181da7d38,0);
                  TweenSettingsExtensions.OnComplete(uVar4,uVar3,DAT_181dc0490);
                  if (!shakeUI) {
                    return;
                  }
                  lVar1 = BuildingUIController.PartyLvName;
                  if ((lVar1 != null) && (lVar1 = *(int64 *)(lVar1 + 32)) != null) {
                    uVar4 = GameObject.get_transform(lVar1,0);
                    ShortcutExtensions.DOShakePosition
                              (uVar4,this.shakeTime,this.shakeDelta * 400.0,
                               30,0x42b40000,0,1,0);
                    return;
                  }
                }
              }
              break;
            }
            if (lVar1 == null) break;
            if (*(uint32 *)(lVar1 + 24) <= uVar5) {
              uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar4,0);
            }
            ShortcutExtensions.DOComplete(lVar1[uVar5],0,0);
            uVar5 = uVar5 + 1;
            lVar1 = this.cam;
          }
        }
    }

    // Token : 0x60020FD
    // RVA   : 0x97E3D0   Offset: 0x97D7D0   Length: 0x15
    public void /*ctor*/()
    {
        void FUN_18097e3d0(int64 this)
        {
        this.shakeDelta = 0x3e19999a;
        this.shakeTime = 0x3dcccccd;
        FUN_18044ef50(this,0);
    }

    // Token : 0x60020FE
    // RVA   : 0x97E3C0   Offset: 0x97D7C0   Length: 0x8
    private void <StartShake>b__9_0()
    {
        void FUN_18097e3c0(int64 this)
        {
        this.shakeStrengthType = 0;
    }

}
