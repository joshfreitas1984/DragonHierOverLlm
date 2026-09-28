// ============================================================
// Type  : TweenScale
// Token : 0x20000C3
// ============================================================

public class TweenScale
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x40004AB
    public Vector3 from;

    // Token: 0x40004AC
    public Vector3 to;

    // Token: 0x40004AD
    public bool updateTable;

    // Token: 0x40004AE
    private Transform mTrans;

    // Token: 0x40004AF
    private UITable mTable;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60005F6
    // RVA   : 0xAECD10   Offset: 0xAEC110   Length: 0x9B
    public Transform get_cachedTransform()
    {
        bool cVar1;
        ulong uVar2;
        uVar2 = this.mTrans;
        cVar1 = Object.op_Equality(uVar2,0,0);
        if (cVar1) {
          uVar2 = Component.get_transform(this,0);
          this.mTrans = uVar2;
        }
        return this.mTrans;
    }

    // Token : 0x60005F7
    // RVA   : 0xAECDB0   Offset: 0xAEC1B0   Length: 0x47
    public Vector3 get_value()
    {
        uint uVar1;
        long lVar2;
        byte[] local_18 = new byte[16];
        lVar2 = TweenScale.get_cachedTransform(param_2,0);
        if (lVar2 != null) {
          puVar3 = (uint64 *)Transform.get_localScale(local_18,lVar2,0);
          uVar1 = *(uint32 *)(puVar3 + 1);
          *this = *puVar3;
          *(uint32 *)(this + 1) = uVar1;
          return this;
        }
    }

    // Token : 0x60005F8
    // RVA   : 0xAECE00   Offset: 0xAEC200   Length: 0x41
    public void set_value(Vector3 value)
    {
        long lVar1;
        ulong local_18;
        uint local_10;
        lVar1 = TweenScale.get_cachedTransform(this,0);
        if (lVar1 != null) {
          local_10 = *(uint32 *)(value + 1);
          local_18 = *value;
          Transform.set_localScale(lVar1,&local_18,0);
          return;
        }
    }

    // Token : 0x60005F9
    // RVA   : 0xAECDB0   Offset: 0xAEC1B0   Length: 0x47
    public Vector3 get_scale()
    {
        uint uVar1;
        long lVar2;
        byte[] local_18 = new byte[16];
        lVar2 = TweenScale.get_cachedTransform(param_2,0);
        if (lVar2 != null) {
          puVar3 = (uint64 *)Transform.get_localScale(local_18,lVar2,0);
          uVar1 = *(uint32 *)(puVar3 + 1);
          *this = *puVar3;
          *(uint32 *)(this + 1) = uVar1;
          return this;
        }
    }

    // Token : 0x60005FA
    // RVA   : 0xAECE00   Offset: 0xAEC200   Length: 0x41
    public void set_scale(Vector3 value)
    {
        long lVar1;
        ulong local_18;
        uint local_10;
        lVar1 = TweenScale.get_cachedTransform(this,0);
        if (lVar1 != null) {
          local_10 = *(uint32 *)(value + 1);
          local_18 = *value;
          Transform.set_localScale(lVar1,&local_18,0);
          return;
        }
    }

    // Token : 0x60005FB
    // RVA   : 0xAEC920   Offset: 0xAEBD20   Length: 0x235
    protected override void OnUpdate(float factor, bool isFinished)
    {
        bool cVar1;
        long lVar2;
        ulong uVar3;
        float fVar4;
        float fVar5;
        ulong local_38;
        float local_30;
        fVar4 = (float)this.from;
        fVar5 = 1.0 - factor;
        local_30 = *(float *)(this + 140);
        local_38 = this.to;
        uVar3 = CONCAT44((float)((uint64)this.from >> 32) * fVar5 +
                         (float)((uint64)local_38 >> 32) * factor,
                         (float)local_38 * factor + fVar4 * fVar5);
        fVar5 = *(float *)(this + 128) * fVar5 + local_30 * factor;
        lVar2 = TweenScale.get_cachedTransform(this,0,(float)local_38,fVar4,uVar3,fVar5);
        if (lVar2 == null) {
        LAB_180aecb50:
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
        local_38 = uVar3;
        local_30 = fVar5;
        Transform.set_localScale(lVar2,&local_38,0);
        if (this.updateTable) {
          uVar3 = this.mTable;
          cVar1 = Object.op_Equality(uVar3,0,0);
          if (cVar1) {
            uVar3 = Component.get_gameObject(this,0);
            uVar3 = NGUITools.FindInParents(uVar3,DAT_181d8fa20);
            this.mTable = uVar3;
            uVar3 = this.mTable;
            cVar1 = Object.op_Equality(uVar3,0,0);
            if (cVar1) {
              this.updateTable = 0;
              return;
            }
          }
          if (this.mTable == null) goto LAB_180aecb50;
          UITable.set_repositionNow(this.mTable,1,0);
        }
    }

    // Token : 0x60005FC
    // RVA   : 0xAEC830   Offset: 0xAEBC30   Length: 0xE8
    public static TweenScale Begin(GameObject go, float duration, Vector3 scale)
    {
        ulong uVar1;
        uint uVar2;
        long lVar3;
        long lVar4;
        byte[] local_38 = new byte[48];
        lVar3 = UITweener.Begin(go,duration,0,DAT_181dc6ee8);
        if (lVar3 != null) {
          lVar4 = TweenScale.get_cachedTransform(lVar3,0);
          if (lVar4 != null) {
            puVar5 = (uint64 *)Transform.get_localScale(local_38,lVar4,0);
            *(uint64 *)(lVar3 + 120) = *puVar5;
            uVar1 = *scale;
            *(uint32 *)(lVar3 + 128) = *(uint32 *)(puVar5 + 1);
            uVar2 = *(uint32 *)(scale + 1);
            *(uint64 *)(lVar3 + 132) = uVar1;
            *(uint32 *)(lVar3 + 140) = uVar2;
            if (duration <= 0.0) {
              UITweener.Sample(lVar3,0x3f800000,1,0);
              Behaviour.set_enabled(lVar3,0,0);
            }
            return lVar3;
          }
        }
    }

    // Token : 0x60005FD
    // RVA   : 0xAECC60   Offset: 0xAEC060   Length: 0x42
    public override void SetStartToCurrentValue()
    {
        long lVar1;
        byte[] local_18 = new byte[16];
        lVar1 = TweenScale.get_cachedTransform(this,0);
        if (lVar1 != null) {
          puVar2 = (uint64 *)Transform.get_localScale(local_18,lVar1,0);
          this.from = *puVar2;
          *(uint32 *)(this + 128) = *(uint32 *)(puVar2 + 1);
          return;
        }
    }

    // Token : 0x60005FE
    // RVA   : 0xAECC10   Offset: 0xAEC010   Length: 0x45
    public override void SetEndToCurrentValue()
    {
        long lVar1;
        byte[] local_18 = new byte[16];
        lVar1 = TweenScale.get_cachedTransform(this,0);
        if (lVar1 != null) {
          puVar2 = (uint64 *)Transform.get_localScale(local_18,lVar1,0);
          this.to = *puVar2;
          *(uint32 *)(this + 140) = *(uint32 *)(puVar2 + 1);
          return;
        }
    }

    // Token : 0x60005FF
    // RVA   : 0xAECBC0   Offset: 0xAEBFC0   Length: 0x4E
    private void SetCurrentValueToStart()
    {
        ulong uVar1;
        uint uVar2;
        long lVar3;
        ulong local_18;
        uint local_10;
        uVar1 = this.from;
        uVar2 = *(uint32 *)(this + 128);
        lVar3 = TweenScale.get_cachedTransform(uVar1,0);
        if (lVar3 != null) {
          local_18 = uVar1;
          local_10 = uVar2;
          Transform.set_localScale(lVar3,&local_18,0);
          return;
        }
    }

    // Token : 0x6000600
    // RVA   : 0xAECB60   Offset: 0xAEBF60   Length: 0x51
    private void SetCurrentValueToEnd()
    {
        ulong uVar1;
        uint uVar2;
        long lVar3;
        ulong local_18;
        uint local_10;
        uVar1 = this.to;
        uVar2 = *(uint32 *)(this + 140);
        lVar3 = TweenScale.get_cachedTransform(uVar1,0);
        if (lVar3 != null) {
          local_18 = uVar1;
          local_10 = uVar2;
          Transform.set_localScale(lVar3,&local_18,0);
          return;
        }
    }

    // Token : 0x6000601
    // RVA   : 0xAECCB0   Offset: 0xAEC0B0   Length: 0x57
    public void /*ctor*/()
    {
        byte[] local_18 = new byte[16];
        puVar1 = (uint64 *)Vector3.get_one(local_18,0);
        this.from = *puVar1;
        *(uint32 *)(this + 128) = *(uint32 *)(puVar1 + 1);
        puVar1 = (uint64 *)Vector3.get_one(local_18,0);
        this.to = *puVar1;
        *(uint32 *)(this + 140) = *(uint32 *)(puVar1 + 1);
        UITweener.ctor(this,0);
    }

}
