// ============================================================
// Type  : ShakeCam
// Token : 0x2000349
// ============================================================

public class ShakeCam
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001A64
    public Camera[] cam;

    // Token: 0x4001A65
    public Tweener[] camTweener;

    // Token: 0x4001A66
    public ShakeStrengthType shakeStrengthType;

    // Token: 0x4001A67
    private float shakeDelta;

    // Token: 0x4001A68
    private float shakeTime;

    // Token: 0x4001A69
    private static ShakeCam _instance;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6002079
    // RVA   : 0x96B3C0   Offset: 0x969BC0   Length: 0x36
    public static ShakeCam get_Instance()
    {
        return **(uint64 **)(DAT_181d7c9b8 + 184);
    }

    // Token : 0x600207A
    // RVA   : 0x96AF70   Offset: 0x969770   Length: 0x43
    private void Awake()
    {
        puVar1 = *(uint64 **)(DAT_181d7c9b8 + 184);
        *puVar1 = this;
        il2cpp_internal(puVar1,this);
    }

    // Token : 0x600207B
    // RVA   : 0x96AFC0   Offset: 0x9697C0   Length: 0x3C0
    public void StartShake(ShakeStrengthType targetShakeStrength, bool shakeUI)
    {
        var pStatics = *(int64*)(DAT_181d6c960 + 184);
        long lVar1;
        int iVar2;
        ulong uVar3;
        ulong uVar4;
        uint uVar5;
        lVar1 = *(int64 *)(*(int64 *)(DAT_181d4e010 + 184) + 8);
        if ((lVar1 != null) && (lVar1 = *(int64 *)(lVar1 + 16)) != null) {
          iVar2 = PlayerPrefDictionary.GetInt(lVar1,"noShake",0);
          if ((iVar2 == 1) || (targetShakeStrength < this.shakeStrengthType)) {
            return;
          }
          uVar5 = 0;
          lVar1 = this.cam;
          while (lVar1 != null) {
            if (*(int *)(lVar1 + 24) <= (int)uVar5) {
              if ((*pStatics != 0) &&
                 (lVar1 = *(int64 *)(*pStatics + 32)) != null) {
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
                  uVar3 = new OnTooltipCB(this,DAT_181d7ed40,0);
                  TweenSettingsExtensions.OnComplete(uVar4,uVar3,DAT_181d96ff8);
                  if (!shakeUI) {
                    return;
                  }
                  if ((*pStatics != 0) &&
                     (lVar1 = *(int64 *)(*pStatics + 32)) != null) {
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

    // Token : 0x600207C
    // RVA   : 0x96B3A0   Offset: 0x969BA0   Length: 0x15
    public void /*ctor*/()
    {
        void FUN_18096b3a0(int64 this)
        {
        this.shakeDelta = 0x3e19999a;
        this.shakeTime = 0x3dcccccd;
        FUN_18044ef50(this,0);
    }

    // Token : 0x600207D
    // RVA   : 0x96B390   Offset: 0x969B90   Length: 0x8
    private void <StartShake>b__9_0()
    {
        void FUN_18096b390(int64 this)
        {
        this.shakeStrengthType = 0;
    }

}
