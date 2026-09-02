// ============================================================
// Type  : TweenRotation
// Token : 0x20000C1
// ============================================================

public class TweenRotation
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x400048B
    public Vector3 from;

    // Token: 0x400048C
    public Vector3 to;

    // Token: 0x400048D
    public bool quaternionLerp;

    // Token: 0x400048E
    private Transform mTrans;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60005D2
    // RVA   : 0xA72A40   Offset: 0xA71240   Length: 0x9B
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

    // Token : 0x60005D3
    // RVA   : 0xA72AE0   Offset: 0xA712E0   Length: 0x3F
    public Quaternion get_rotation()
    {
        ulong uVar1;
        long lVar2;
        byte[] local_18 = new byte[16];
        lVar2 = TweenRotation.get_cachedTransform(param_2,0);
        if (lVar2 != null) {
          puVar3 = (uint64 *)Transform.get_localRotation(local_18,lVar2,0);
          uVar1 = puVar3[1];
          *this = *puVar3;
          this[1] = uVar1;
          return this;
        }
    }

    // Token : 0x60005D4
    // RVA   : 0xA72B20   Offset: 0xA71320   Length: 0x38
    public void set_rotation(Quaternion value)
    {
        long lVar1;
        uint local_18;
        uint uStack_14;
        uint uStack_10;
        uint32 uStack_c;
        lVar1 = TweenRotation.get_cachedTransform(this,0);
        if (lVar1 != null) {
          local_18 = *value;
          uStack_14 = value[1];
          uStack_10 = value[2];
          uStack_c = value[3];
          Transform.set_localRotation(lVar1,&local_18,0);
          return;
        }
    }

    // Token : 0x60005D5
    // RVA   : 0xA72AE0   Offset: 0xA712E0   Length: 0x3F
    public Quaternion get_value()
    {
        ulong uVar1;
        long lVar2;
        byte[] local_18 = new byte[16];
        lVar2 = TweenRotation.get_cachedTransform(param_2,0);
        if (lVar2 != null) {
          puVar3 = (uint64 *)Transform.get_localRotation(local_18,lVar2,0);
          uVar1 = puVar3[1];
          *this = *puVar3;
          this[1] = uVar1;
          return this;
        }
    }

    // Token : 0x60005D6
    // RVA   : 0xA72B20   Offset: 0xA71320   Length: 0x38
    public void set_value(Quaternion value)
    {
        long lVar1;
        uint local_18;
        uint uStack_14;
        uint uStack_10;
        uint32 uStack_c;
        lVar1 = TweenRotation.get_cachedTransform(this,0);
        if (lVar1 != null) {
          local_18 = *value;
          uStack_14 = value[1];
          uStack_10 = value[2];
          uStack_c = value[3];
          Transform.set_localRotation(lVar1,&local_18,0);
          return;
        }
    }

    // Token : 0x60005D7
    // RVA   : 0xA72700   Offset: 0xA70F00   Length: 0x187
    protected override void OnUpdate(float factor, bool isFinished)
    {
        ulong uVar1;
        ulong uVar2;
        long lVar4;
        uint uVar5;
        uint uVar6;
        uint uVar7;
        ulong local_68;
        ulong uStack_60;
        ulong local_58;
        ulong uStack_50;
        byte[] local_48 = new byte[64];
        if (!this.quaternionLerp) {
          uVar5 = Mathf.Lerp(this.from,this.to,factor,0);
          uVar6 = Mathf.Lerp(*(uint32 *)(this + 124),*(uint32 *)(this + 136),factor,0);
          uVar7 = Mathf.Lerp(*(uint32 *)(this + 128),*(uint32 *)(this + 140),factor,0);
          uStack_50 = CONCAT44(uStack_50._4_4_,uVar7);
          local_68 = CONCAT44(uVar6,uVar5);
          uStack_60 = CONCAT44(uStack_60._4_4_,uVar7);
          puVar3 = (uint64 *)Quaternion.Euler(local_48,&local_68,0);
        }
        else {
          local_68 = this.from;
          uStack_60._0_4_ = *(uint32 *)(this + 128);
          puVar3 = (uint64 *)Quaternion.Euler(&local_58,&local_68,0);
          local_68 = this.to;
          uVar1 = *puVar3;
          uVar2 = puVar3[1];
          uStack_60 = CONCAT44(uStack_60._4_4_,*(uint32 *)(this + 140));
          puVar3 = (uint64 *)Quaternion.Euler(&local_58,&local_68,0);
          local_58 = *puVar3;
          uStack_50 = puVar3[1];
          local_68 = uVar1;
          uStack_60 = uVar2;
          puVar3 = (uint64 *)Quaternion.Slerp(local_48,&local_68,&local_58,factor,0);
        }
        uVar1 = *puVar3;
        uVar2 = puVar3[1];
        lVar4 = TweenRotation.get_cachedTransform(this,0);
        if (lVar4 != null) {
          local_58 = uVar1;
          uStack_50 = uVar2;
          Transform.set_localRotation(lVar4,&local_58,0);
          return;
        }
    }

    // Token : 0x60005D8
    // RVA   : 0xA725E0   Offset: 0xA70DE0   Length: 0x116
    public static TweenRotation Begin(GameObject go, float duration, Quaternion rot)
    {
        long lVar1;
        long lVar2;
        byte[] local_48 = new byte[16];
        uint local_38;
        uint uStack_34;
        uint uStack_30;
        uint32 uStack_2c;
        lVar1 = UITweener.Begin(go,duration,0,DAT_181d9db70);
        if (lVar1 != null) {
          lVar2 = TweenRotation.get_cachedTransform(lVar1,0);
          if (lVar2 != null) {
            puVar3 = (uint32 *)Transform.get_localRotation(local_48,lVar2,0);
            local_38 = *puVar3;
            uStack_34 = puVar3[1];
            uStack_30 = puVar3[2];
            uStack_2c = puVar3[3];
            puVar4 = (uint64 *)Quaternion.get_eulerAngles(local_48,&local_38,0);
            *(uint64 *)(lVar1 + 120) = *puVar4;
            *(uint32 *)(lVar1 + 128) = *(uint32 *)(puVar4 + 1);
            puVar4 = (uint64 *)Quaternion.get_eulerAngles(local_48,rot,0);
            *(uint64 *)(lVar1 + 132) = *puVar4;
            *(uint32 *)(lVar1 + 140) = *(uint32 *)(puVar4 + 1);
            if (duration <= 0.0) {
              UITweener.Sample(lVar1,0x3f800000,1,0);
              Behaviour.set_enabled(lVar1,0,0);
            }
            return lVar1;
          }
        }
    }

    // Token : 0x60005D9
    // RVA   : 0xA729E0   Offset: 0xA711E0   Length: 0x5C
    public override void SetStartToCurrentValue()
    {
        long lVar1;
        byte[] local_28 = new byte[16];
        uint local_18;
        uint uStack_14;
        uint uStack_10;
        uint32 uStack_c;
        lVar1 = TweenRotation.get_cachedTransform(this,0);
        if (lVar1 != null) {
          puVar2 = (uint32 *)Transform.get_localRotation(local_28,lVar1,0);
          local_18 = *puVar2;
          uStack_14 = puVar2[1];
          uStack_10 = puVar2[2];
          uStack_c = puVar2[3];
          puVar3 = (uint64 *)Quaternion.get_eulerAngles(local_28,&local_18,0);
          this.from = *puVar3;
          *(uint32 *)(this + 128) = *(uint32 *)(puVar3 + 1);
          return;
        }
    }

    // Token : 0x60005DA
    // RVA   : 0xA72980   Offset: 0xA71180   Length: 0x5F
    public override void SetEndToCurrentValue()
    {
        long lVar1;
        byte[] local_28 = new byte[16];
        uint local_18;
        uint uStack_14;
        uint uStack_10;
        uint32 uStack_c;
        lVar1 = TweenRotation.get_cachedTransform(this,0);
        if (lVar1 != null) {
          puVar2 = (uint32 *)Transform.get_localRotation(local_28,lVar1,0);
          local_18 = *puVar2;
          uStack_14 = puVar2[1];
          uStack_10 = puVar2[2];
          uStack_c = puVar2[3];
          puVar3 = (uint64 *)Quaternion.get_eulerAngles(local_28,&local_18,0);
          this.to = *puVar3;
          *(uint32 *)(this + 140) = *(uint32 *)(puVar3 + 1);
          return;
        }
    }

    // Token : 0x60005DB
    // RVA   : 0xA72910   Offset: 0xA71110   Length: 0x6D
    private void SetCurrentValueToStart()
    {
        ulong uVar1;
        ulong uVar2;
        long lVar4;
        ulong local_38;
        ulong uStack_30;
        byte[] local_28 = new byte[32];
        local_38 = this.from;
        uStack_30 = CONCAT44(uStack_30._4_4_,*(uint32 *)(this + 128));
        puVar3 = (uint64 *)Quaternion.Euler(local_28,&local_38,0);
        uVar1 = *puVar3;
        uVar2 = puVar3[1];
        lVar4 = TweenRotation.get_cachedTransform(this,0);
        if (lVar4 != null) {
          local_38 = uVar1;
          uStack_30 = uVar2;
          Transform.set_localRotation(lVar4,&local_38,0);
          return;
        }
    }

    // Token : 0x60005DC
    // RVA   : 0xA72890   Offset: 0xA71090   Length: 0x70
    private void SetCurrentValueToEnd()
    {
        ulong uVar1;
        ulong uVar2;
        long lVar4;
        ulong local_38;
        ulong uStack_30;
        byte[] local_28 = new byte[32];
        local_38 = this.to;
        uStack_30 = CONCAT44(uStack_30._4_4_,*(uint32 *)(this + 140));
        puVar3 = (uint64 *)Quaternion.Euler(local_28,&local_38,0);
        uVar1 = *puVar3;
        uVar2 = puVar3[1];
        lVar4 = TweenRotation.get_cachedTransform(this,0);
        if (lVar4 != null) {
          local_38 = uVar1;
          uStack_30 = uVar2;
          Transform.set_localRotation(lVar4,&local_38,0);
          return;
        }
    }

    // Token : 0x60005DD
    // RVA   : 0xA72230   Offset: 0xA70A30   Length: 0x7
    public void /*ctor*/()
    {
        void FUN_180a72230(uint64 this)
        {
        UITweener.ctor(this,0);
    }

}
