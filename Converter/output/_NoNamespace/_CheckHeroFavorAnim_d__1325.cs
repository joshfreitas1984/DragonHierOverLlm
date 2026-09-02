// ============================================================
// Type  : <CheckHeroFavorAnim>d__1325
// Token : 0x200031F
// ============================================================

public class <CheckHeroFavorAnim>d__1325
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x400193D
    private int <>1__state;

    // Token: 0x400193E
    private object <>2__current;

    // Token: 0x400193F
    public HeroData targetHero;

    // Token: 0x4001940
    public PlotController <>4__this;

    // Token: 0x4001941
    public float favorChange;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6001F4D
    // RVA   : 0x219070   Offset: 0x217870   Length: 0x24
    public void /*ctor*/(int <>1__state)
    {
        ZhSegment.Initialize(this,0);
        this.<>1__state = <>1__state;
    }

    // Token : 0x6001F4E
    // RVA   : 0x245810   Offset: 0x244010   Length: 0x3
    private virtual void System.IDisposable.Dispose()
    {
    }

    // Token : 0x6001F4F
    // RVA   : 0x8C7FC0   Offset: 0x8C67C0   Length: 0x4F6
    private virtual bool MoveNext()
    {
        uint uVar1;
        ulong uVar2;
        ulong uVar3;
        ulong uVar4;
        long lVar6;
        long lVar8;
        float fVar10;
        ulong uVar11;
        float fVar12;
        uint[] local_res8 = new uint[2];
        ulong local_b8;
        float local_b0;
        ulong local_a8;
        float local_a0;
        byte[] local_98 = new byte[16];
        byte[] local_88 = new byte[112];
        local_res8[0] = this.<>1__state;
        lVar8 = this.<>4__this;
        if (local_res8[0] == 0) {
          this.<>1__state = 0xffffffff;
          uVar3 = il2cpp_value_box(DAT_181d5b2f8,local_res8);
          this.<>2__current = uVar3;
          this.<>1__state = 1;
          return true;
        }
        if (local_res8[0] != 1) {
          return false;
        }
        this.<>1__state = 0xffffffff;
        if (lVar8 != null) {
          lVar6 = this.targetHero;
          if (lVar6 == *(int64 *)(lVar8 + 104)) {
            uVar3 = *(uint64 *)(lVar8 + 80);
            uVar4 = "好感上升";
            if (this.favorChange <= 0.0) {
              uVar4 = "好感下降";
            }
            uVar4 = String.Concat("SpeEffect/剧情/",uVar4,0);
            plVar5 = (int64 *)Resources.Load(uVar4,0);
            if ((((*(int64 *)(lVar8 + 32) == 0) ||
                 (lVar6 = GameObject.get_transform(*(int64 *)(lVar8 + 32),0)) == null) ||
                (lVar6 = Transform.Find(lVar6,"LeftFace",0)) == null) ||
               (lVar6 = Transform.Find(lVar6,"HeroFavor",0)) == null) throw; // [null/range check failed]
            puVar7 = (uint64 *)Transform.get_localPosition(local_98,lVar6,0);
            uVar4 = *puVar7;
            uVar1 = *(uint32 *)(puVar7 + 1);
            puVar7 = (uint64 *)Vector3.get_one(local_88,0);
            local_b0 = *(float *)(puVar7 + 1);
            local_a8 = *puVar7;
            fVar12 = (float)local_a8;
            uVar2 = (uint64)local_a8 >> 32;
            local_a0 = local_b0;
            uVar11 = Mathf.Max(0x3f800000,this.favorChange & 0x7fffffff,0);
            fVar10 = (float)Mathf.Log(uVar11,0x40000000,0);
            fVar10 = fVar10 * 0.2 + 1.0;
            local_b0 = local_a0 * 50.0 * fVar10;
            local_b8 = CONCAT44((float)uVar2 * 50.0 * fVar10,fVar12 * 50.0 * fVar10);
            local_a8 = local_b8;
            local_a0 = local_b0;
            plVar9 = (int64 *)0;
            if ((plVar5 != (int64 *)0) && (*plVar5 == DAT_181d4e110)) {
              plVar9 = plVar5;
            }
            local_b8 = uVar4;
            local_b0 = (float)uVar1;
            GlobalData.AddChild(uVar3,plVar9,&local_b8,&local_a8,0);
            lVar6 = this.targetHero;
          }
          if (lVar6 != *(int64 *)(lVar8 + 112)) {
            return false;
          }
          uVar3 = *(uint64 *)(lVar8 + 80);
          uVar4 = "好感上升";
          if (this.favorChange <= 0.0) {
            uVar4 = "好感下降";
          }
          uVar4 = String.Concat("SpeEffect/剧情/",uVar4,0);
          plVar5 = (int64 *)Resources.Load(uVar4,0);
          if ((((*(int64 *)(lVar8 + 32) != 0) &&
               (lVar8 = GameObject.get_transform(*(int64 *)(lVar8 + 32),0)) != null) &&
              (lVar8 = Transform.Find(lVar8,"RightFace",0)) != null) &&
             (lVar8 = Transform.Find(lVar8,"HeroFavor",0)) != null) {
            puVar7 = (uint64 *)Transform.get_localPosition(local_88,lVar8,0);
            uVar4 = *puVar7;
            uVar1 = *(uint32 *)(puVar7 + 1);
            puVar7 = (uint64 *)Vector3.get_one(local_88,0);
            local_a8 = *puVar7;
            fVar12 = (float)local_a8;
            uVar2 = (uint64)local_a8 >> 32;
            local_a0 = *(float *)(puVar7 + 1);
            uVar11 = Mathf.Max(0x3f800000,this.favorChange & 0x7fffffff,0);
            fVar10 = (float)Mathf.Log(uVar11,0x40000000,0);
            fVar10 = fVar10 * 0.2 + 1.0;
            local_b0 = local_a0 * 50.0 * fVar10;
            local_b8 = CONCAT44((float)uVar2 * 50.0 * fVar10,fVar12 * 50.0 * fVar10);
            local_a8 = local_b8;
            local_a0 = local_b0;
            plVar9 = (int64 *)0;
            if ((plVar5 != (int64 *)0) && (*plVar5 == DAT_181d4e110)) {
              plVar9 = plVar5;
            }
            local_b8 = uVar4;
            local_b0 = (float)uVar1;
            GlobalData.AddChild(uVar3,plVar9,&local_b8,&local_a8,0);
            return false;
          }
        }
    }

    // Token : 0x6001F50
    // RVA   : 0x20F140   Offset: 0x20D940   Length: 0x5
    private virtual object System.Collections.Generic.IEnumerator<System.object>.get_Current()
    {
        return this.<>2__current;
    }

    // Token : 0x6001F51
    // RVA   : 0x8C84C0   Offset: 0x8C6CC0   Length: 0x3E
    private virtual void System.Collections.IEnumerator.Reset()
    {
        ulong uVar1;
        ulong uVar2;
        uVar1 = il2cpp_runtime_class_init(&DAT_181d682e8);
        uVar1 = il2cpp_internal(uVar1);
        NotSupportedException.ctor(uVar1,0);
        uVar2 = il2cpp_runtime_class_init(&DAT_181d811a8);
    }

    // Token : 0x6001F52
    // RVA   : 0x20F140   Offset: 0x20D940   Length: 0x5
    private virtual object System.Collections.IEnumerator.get_Current()
    {
        return this.<>2__current;
    }

}
