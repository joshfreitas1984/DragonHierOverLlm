// ============================================================
// Type  : TweenPosition
// Token : 0x20000C0
// ============================================================

public class TweenPosition
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4000486
    public Vector3 from;

    // Token: 0x4000487
    public Vector3 to;

    // Token: 0x4000488
    public bool worldSpace;

    // Token: 0x4000489
    private Transform mTrans;

    // Token: 0x400048A
    private UIRect mRect;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60005C4
    // RVA   : 0xA72240   Offset: 0xA70A40   Length: 0x9B
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

    // Token : 0x60005C5
    // RVA   : 0xA722E0   Offset: 0xA70AE0   Length: 0x74
    public Vector3 get_position()
    {
        uint uVar1;
        long lVar2;
        byte[] local_28 = new byte[16];
        byte[] local_18 = new byte[16];
        if (*(char *)(param_2 + 144) == false) {
          lVar2 = TweenPosition.get_cachedTransform(param_2,0);
          if (lVar2 == null) {
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          puVar3 = (uint64 *)Transform.get_localPosition(local_18,lVar2,0);
        }
        else {
          lVar2 = TweenPosition.get_cachedTransform(param_2,0);
          if (lVar2 == null) {
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          puVar3 = (uint64 *)Transform.get_position(local_28,lVar2,0);
        }
        uVar1 = *(uint32 *)(puVar3 + 1);
        *this = *puVar3;
        *(uint32 *)(this + 1) = uVar1;
        return this;
    }

    // Token : 0x60005C6
    // RVA   : 0xA723D0   Offset: 0xA70BD0   Length: 0x27
    public void set_position(Vector3 value)
    {
        ulong local_18;
        uint local_10;
        local_18 = *value;
        local_10 = *(uint32 *)(value + 1);
        TweenPosition.set_value(local_18,&local_18,0);
    }

    // Token : 0x60005C7
    // RVA   : 0xA72360   Offset: 0xA70B60   Length: 0x6E
    public Vector3 get_value()
    {
        uint uVar1;
        long lVar2;
        byte[] local_18 = new byte[16];
        if (*(char *)(param_2 + 144) == false) {
          lVar2 = TweenPosition.get_cachedTransform(param_2,0);
          if (lVar2 != null)
          {
            puVar3 = (uint64 *)Transform.get_localPosition(local_18,lVar2,0);
            }
            else {
            lVar2 = TweenPosition.get_cachedTransform(param_2,0);
            if (lVar2 == null) {
          }
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          puVar3 = (uint64 *)Transform.get_position(local_18,lVar2,0);
        }
        uVar1 = *(uint32 *)(puVar3 + 1);
        *this = *puVar3;
        *(uint32 *)(this + 1) = uVar1;
        return this;
    }

    // Token : 0x60005C8
    // RVA   : 0xA72400   Offset: 0xA70C00   Length: 0x1D2
    public void set_value(Vector3 value)
    {
        ulong uVar1;
        bool cVar2;
        long lVar3;
        float fVar5;
        ulong local_38;
        float local_30;
        float local_20;
        byte[] local_18 = new byte[16];
        uVar1 = this.mRect;
        cVar2 = Object.op_Equality(uVar1,0,0);
        if (!cVar2) {
          if (this.mRect == null) throw; // [null/range check failed]
          cVar2 = UIRect.get_isAnchored(this.mRect,0);
          if (!cVar2) goto LAB_180a72544;
          if (!this.worldSpace) {
            lVar3 = TweenPosition.get_cachedTransform(this,0);
            if (lVar3 != null) {
              puVar4 = (uint64 *)Transform.get_localPosition(local_18,lVar3,0);
              local_30 = *(float *)(puVar4 + 1);
              fVar5 = (float)((uint64)*value >> 32) - (float)((uint64)*puVar4 >> 32);
              local_20 = *(float *)(value + 1) - local_30;
              uVar1 = this.mRect;
              *value = CONCAT44(fVar5,(float)*value - (float)*puVar4);
              *(float *)(value + 1) = local_20;
              NGUIMath.MoveRect(uVar1,*(uint32 *)value,fVar5,0);
              return;
            }
            throw; // [null/range check failed]
          }
        }
        else {
        LAB_180a72544:
          if (!this.worldSpace) {
            lVar3 = TweenPosition.get_cachedTransform(this,0);
            if (lVar3 != null) {
              local_30 = *(float *)(value + 1);
              local_38 = *value;
              Transform.set_localPosition(lVar3,&local_38,0);
              return;
            }
            throw; // [null/range check failed]
          }
        }
        lVar3 = TweenPosition.get_cachedTransform(this,0);
        if (lVar3 != null) {
          local_30 = *(float *)(value + 1);
          local_38 = *value;
          Transform.set_position(lVar3,&local_38,0);
          return;
        }
    }

    // Token : 0x60005C9
    // RVA   : 0xA71D80   Offset: 0xA70580   Length: 0x4B
    private void Awake()
    {
        ulong uVar1;
        uVar1 = Component.GetComponent(this,DAT_181d6e440);
        this.mRect = uVar1;
    }

    // Token : 0x60005CA
    // RVA   : 0xA72020   Offset: 0xA70820   Length: 0xCB
    protected override void OnUpdate(float factor, bool isFinished)
    {
        float fVar1;
        float fVar2;
        ulong local_48;
        float local_40;
        float local_30;
        fVar1 = 1.0 - factor;
        fVar2 = (float)this.from * fVar1 +
                (float)this.to * factor;
        local_40 = *(float *)(this + 128) * fVar1 + *(float *)(this + 140) * factor;
        local_48 = CONCAT44((float)((uint64)this.from >> 32) * fVar1 +
                            (float)((uint64)this.to >> 32) * factor,fVar2);
        local_30 = local_40;
        TweenPosition.set_value(fVar2,&local_48,0);
    }

    // Token : 0x60005CB
    // RVA   : 0xA71F00   Offset: 0xA70700   Length: 0x116
    public static TweenPosition Begin(GameObject go, float duration, Vector3 pos)
    {
        uint uVar1;
        uint uVar2;
        long lVar3;
        long lVar4;
        byte[] local_48 = new byte[16];
        byte[] local_38 = new byte[48];
        lVar3 = UITweener.Begin(go,duration,0,DAT_181d9dae8);
        if (lVar3 != null) {
          *(char *)(lVar3 + 144) = param_4;
          lVar4 = TweenPosition.get_cachedTransform(lVar3,0);
          if (!param_4) {
            if (lVar4 == null) throw; // [null/range check failed]
            puVar5 = (uint64 *)Transform.get_localPosition(local_38,lVar4,0);
          }
          else {
            if (lVar4 == null) {
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            puVar5 = (uint64 *)Transform.get_position(local_48,lVar4,0);
          }
          uVar1 = *(uint32 *)(puVar5 + 1);
          uVar2 = *(uint32 *)(pos + 1);
          *(uint64 *)(lVar3 + 120) = *puVar5;
          *(uint64 *)(lVar3 + 132) = *pos;
          *(uint32 *)(lVar3 + 140) = uVar2;
          *(uint32 *)(lVar3 + 128) = uVar1;
          if (duration <= 0.0) {
            UITweener.Sample(lVar3,0x3f800000,1,0);
            Behaviour.set_enabled(lVar3,0,0);
          }
          return lVar3;
        }
    }

    // Token : 0x60005CC
    // RVA   : 0xA71DD0   Offset: 0xA705D0   Length: 0x123
    public static TweenPosition Begin(GameObject go, float duration, Vector3 pos, bool worldSpace)
    {
        uint uVar1;
        uint uVar2;
        long lVar3;
        long lVar4;
        byte[] local_48 = new byte[16];
        byte[] local_38 = new byte[48];
        lVar3 = UITweener.Begin(go,duration,0,DAT_181d9dae8);
        if (lVar3 != null) {
          *(char *)(lVar3 + 144) = worldSpace;
          lVar4 = TweenPosition.get_cachedTransform(lVar3,0);
          if (!worldSpace) {
            if (lVar4 == null) throw; // [null/range check failed]
            puVar5 = (uint64 *)Transform.get_localPosition(local_38,lVar4,0);
          }
          else {
            if (lVar4 == null) {
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            puVar5 = (uint64 *)Transform.get_position(local_48,lVar4,0);
          }
          uVar1 = *(uint32 *)(puVar5 + 1);
          uVar2 = *(uint32 *)(pos + 1);
          *(uint64 *)(lVar3 + 120) = *puVar5;
          *(uint64 *)(lVar3 + 132) = *pos;
          *(uint32 *)(lVar3 + 140) = uVar2;
          *(uint32 *)(lVar3 + 128) = uVar1;
          if (duration <= 0.0) {
            UITweener.Sample(lVar3,0x3f800000,1,0);
            Behaviour.set_enabled(lVar3,0,0);
          }
          return lVar3;
        }
    }

    // Token : 0x60005CD
    // RVA   : 0xA721C0   Offset: 0xA709C0   Length: 0x6C
    public override void SetStartToCurrentValue()
    {
        uint uVar1;
        long lVar2;
        byte[] local_28 = new byte[16];
        byte[] local_18 = new byte[16];
        if (!this.worldSpace) {
          lVar2 = TweenPosition.get_cachedTransform();
          if (lVar2 == null) {
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          puVar3 = (uint64 *)Transform.get_localPosition(local_18,lVar2,0);
        }
        else {
          lVar2 = TweenPosition.get_cachedTransform();
          if (lVar2 == null) {
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          puVar3 = (uint64 *)Transform.get_position(local_28,lVar2,0);
        }
        uVar1 = *(uint32 *)(puVar3 + 1);
        this.from = *puVar3;
        *(uint32 *)(this + 128) = uVar1;
    }

    // Token : 0x60005CE
    // RVA   : 0xA72150   Offset: 0xA70950   Length: 0x6F
    public override void SetEndToCurrentValue()
    {
        uint uVar1;
        long lVar2;
        byte[] local_28 = new byte[16];
        byte[] local_18 = new byte[16];
        if (!this.worldSpace) {
          lVar2 = TweenPosition.get_cachedTransform();
          if (lVar2 == null) {
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          puVar3 = (uint64 *)Transform.get_localPosition(local_18,lVar2,0);
        }
        else {
          lVar2 = TweenPosition.get_cachedTransform();
          if (lVar2 == null) {
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          puVar3 = (uint64 *)Transform.get_position(local_28,lVar2,0);
        }
        uVar1 = *(uint32 *)(puVar3 + 1);
        this.to = *puVar3;
        *(uint32 *)(this + 140) = uVar1;
    }

    // Token : 0x60005CF
    // RVA   : 0xA72120   Offset: 0xA70920   Length: 0x2B
    private void SetCurrentValueToStart()
    {
        ulong local_18;
        uint local_10;
        local_18 = this.from;
        local_10 = *(uint32 *)(this + 128);
        TweenPosition.set_value(local_18,&local_18,0);
    }

    // Token : 0x60005D0
    // RVA   : 0xA720F0   Offset: 0xA708F0   Length: 0x2E
    private void SetCurrentValueToEnd()
    {
        ulong local_18;
        uint local_10;
        local_18 = this.to;
        local_10 = *(uint32 *)(this + 140);
        TweenPosition.set_value(local_18,&local_18,0);
    }

    // Token : 0x60005D1
    // RVA   : 0xA72230   Offset: 0xA70A30   Length: 0x7
    public void /*ctor*/()
    {
        void FUN_180a72230(uint64 this)
        {
        UITweener.ctor(this,0);
    }

}
