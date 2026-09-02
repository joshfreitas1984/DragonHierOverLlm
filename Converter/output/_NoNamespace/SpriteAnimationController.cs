// ============================================================
// Type  : SpriteAnimationController
// Token : 0x2000365
// ============================================================

public class SpriteAnimationController
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001B05
    public List<Sprite> spriteSheet;

    // Token: 0x4001B06
    public float framePerSecond;

    // Token: 0x4001B07
    public bool finishAutoDestroy;

    // Token: 0x4001B08
    public bool useRealTime;

    // Token: 0x4001B09
    private int nowSpriteID;

    // Token: 0x4001B0A
    private float nextTime;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x600212E
    // RVA   : 0xC6F430   Offset: 0xC6DC30   Length: 0x84
    private void Start()
    {
        long lVar1;
        long lVar2;
        lVar2 = Component.GetComponent(this,DAT_181d6d540);
        lVar1 = this.spriteSheet;
        if (lVar1 != null) {
          if (lVar1.Count == null) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          if (lVar2 != null) {
            SpriteRenderer.set_sprite(lVar2,*(uint64 *)(lVar1._items + 32),0);
            return;
          }
        }
    }

    // Token : 0x600212F
    // RVA   : 0xC6F4C0   Offset: 0xC6DCC0   Length: 0x154
    private void Update()
    {
        uint uVar1;
        long lVar2;
        int iVar3;
        long lVar4;
        ulong uVar5;
        float fVar6;
        float fVar7;
        fVar7 = this.nextTime;
        if (!this.useRealTime) {
          fVar6 = (float)Time.get_deltaTime();
        }
        else {
          fVar6 = (float)RealTime.get_deltaTime();
        }
        fVar7 = fVar7 + fVar6;
        this.nextTime = fVar7;
        fVar6 = 1.0 / this.framePerSecond;
        if (fVar7 < fVar6) {
          return;
        }
        iVar3 = this.nowSpriteID + 1;
        this.nowSpriteID = iVar3;
        this.nextTime = fVar7 - fVar6;
        if (this.spriteSheet != null) {
          if (this.spriteSheet.Count <= iVar3) {
            if (this.finishAutoDestroy) {
              uVar5 = Component.get_gameObject(this,0);
              Object.Destroy(uVar5,0);
              return;
            }
            this.nowSpriteID = 0;
          }
          lVar4 = Component.GetComponent(this,DAT_181d6d540);
          lVar2 = this.spriteSheet;
          if (lVar2 != null) {
            uVar1 = this.nowSpriteID;
            if (lVar2.Count <= uVar1) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            if (lVar4 != null) {
              SpriteRenderer.set_sprite
                        (lVar4,*(uint64 *)
                                (lVar2._items + 32 + (int64)(int)uVar1 * 8),0);
              return;
            }
          }
        }
    }

    // Token : 0x6002130
    // RVA   : 0x3A17B0   Offset: 0x39FFB0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_18044ef50(this,0);
    }

}
