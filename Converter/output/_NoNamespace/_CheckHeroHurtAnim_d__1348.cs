// ============================================================
// Type  : <CheckHeroHurtAnim>d__1348
// Token : 0x2000320
// ============================================================

public class <CheckHeroHurtAnim>d__1348
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001942
    private int <>1__state;

    // Token: 0x4001943
    private object <>2__current;

    // Token: 0x4001944
    public HeroData targetHero;

    // Token: 0x4001945
    public PlotController <>4__this;

    // Token: 0x4001946
    public string speEffectName;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6001F53
    // RVA   : 0x219070   Offset: 0x217870   Length: 0x24
    public void /*ctor*/(int <>1__state)
    {
        ZhSegment.Initialize(this,0);
        this.<>1__state = <>1__state;
    }

    // Token : 0x6001F54
    // RVA   : 0x245810   Offset: 0x244010   Length: 0x3
    private virtual void System.IDisposable.Dispose()
    {
    }

    // Token : 0x6001F55
    // RVA   : 0x8C8500   Offset: 0x8C6D00   Length: 0x64F
    private virtual bool MoveNext()
    {
        float fVar1;
        ulong uVar2;
        ulong uVar3;
        long lVar4;
        long lVar5;
        ulong uVar7;
        long lVar10;
        uint[] local_res8 = new uint[2];
        ulong in_stack_ffffffffffffff38;
        uint uVar13;
        ulong local_a8;
        float local_a0;
        ulong local_98;
        float local_90;
        byte[] local_88 = new byte[16];
        uint local_78;
        uint uStack_74;
        uint uStack_70;
        uint32 uStack_6c;
        uVar13 = (uint32)((uint64)in_stack_ffffffffffffff38 >> 32);
        lVar10 = this.<>4__this;
        if (this.<>1__state == 0) {
          this.<>1__state = 0xffffffff;
          local_res8[0] = 0;
          uVar3 = il2cpp_value_box(DAT_181d5b2f8,local_res8);
          this.<>2__current = uVar3;
          uVar3 = 1;
          this.<>1__state = 1;
        }
        else {
          if (this.<>1__state == 1) {
            this.<>1__state = 0xffffffff;
            if (lVar10 == null) goto LAB_1808c8b4a;
            lVar5 = this.targetHero;
            plVar12 = (int64 *)0;
            if (lVar5 == *(int64 *)(lVar10 + 104)) {
              if (*(int64 *)(lVar10 + 32) == 0) goto LAB_1808c8b4a;
              lVar4 = GameObject.get_transform(*(int64 *)(lVar10 + 32),0);
              if (lVar4 == null) goto LAB_1808c8b4a;
              uVar3 = Transform.Find(lVar4,"LeftFace",0);
              if (lVar5 == null) goto LAB_1808c8b4a;
              lVar5 = HeroData.GetSkeletonGraphic(lVar5,uVar3,0);
              if (lVar5 == null) goto LAB_1808c8b4a;
              uVar3 = Component.get_transform(lVar5,0);
              local_a8 = 0x42200000;
              local_a0 = 0.0;
              ShortcutExtensions.DOShakePosition
                        (uVar3,0x3ecccccd,&local_a8,40,CONCAT44(uVar13,0x42b40000),0,1,0);
              DOTween.Complete(lVar5,0,0);
              puVar6 = (uint32 *)Color.get_red(&local_78,0);
              local_78 = *puVar6;
              uStack_74 = puVar6[1];
              uStack_70 = puVar6[2];
              uStack_6c = puVar6[3];
              uVar3 = DOTweenModuleUI.DOColor(lVar5,&local_78,0x3e4ccccd,0);
              uVar3 = TweenSettingsExtensions.SetLoops(uVar3,2,1,DAT_181d97f50);
              TweenSettingsExtensions.SetId(uVar3,"Hurt",DAT_181d97e40);
              uVar3 = *(uint64 *)(lVar10 + 80);
              uVar7 = String.Concat("SpeEffect/剧情/",this.speEffectName,0);
              plVar8 = (int64 *)Resources.Load(uVar7,0);
              lVar4 = Component.get_transform(lVar5,0);
              if (lVar4 == null) goto LAB_1808c8b4a;
              puVar6 = (uint32 *)Transform.get_localPosition(local_88,lVar4,0);
              uVar13 = *puVar6;
              lVar5 = Component.get_transform(lVar5,0);
              if (lVar5 == null) goto LAB_1808c8b4a;
              puVar9 = (uint64 *)Transform.get_localPosition(local_88,lVar5,0);
              local_98 = *puVar9;
              uVar2 = (uint64)local_98 >> 32;
              local_90 = *(float *)(puVar9 + 1);
              puVar9 = (uint64 *)Vector3.get_one(&local_78,0);
              local_98 = *puVar9;
              local_90 = *(float *)(puVar9 + 1);
              local_a0 = local_90 * 300.0;
              local_a8 = CONCAT44((float)((uint64)local_98 >> 32) * 300.0,(float)local_98 * 300.0);
              local_98 = local_a8;
              local_a8 = CONCAT44((float)uVar2 * 0.5,uVar13);
              local_90 = local_a0;
              local_a0 = 0.0;
              plVar11 = plVar12;
              if ((plVar8 != (int64 *)0) && (*plVar8 == DAT_181d4e110)) {
                plVar11 = plVar8;
              }
              uVar13 = 0;
              GlobalData.AddChild(uVar3,plVar11,&local_a8,&local_98,0);
              lVar5 = this.targetHero;
            }
            if (lVar5 == *(int64 *)(lVar10 + 112)) {
              if (*(int64 *)(lVar10 + 32) == 0) {
        LAB_1808c8b4a:
                          // WARNING: Subroutine does not return
                FUN_1800d6620();
              }
              lVar4 = GameObject.get_transform(*(int64 *)(lVar10 + 32),0);
              if (lVar4 == null) goto LAB_1808c8b4a;
              uVar3 = Transform.Find(lVar4,"RightFace",0);
              if (lVar5 == null) goto LAB_1808c8b4a;
              lVar5 = HeroData.GetSkeletonGraphic(lVar5,uVar3,0);
              if (lVar5 == null) goto LAB_1808c8b4a;
              uVar3 = Component.get_transform(lVar5,0);
              local_a8 = 0x42200000;
              local_a0 = 0.0;
              ShortcutExtensions.DOShakePosition
                        (uVar3,0x3ecccccd,&local_a8,40,CONCAT44(uVar13,0x42b40000),0,1,0);
              DOTween.Complete(lVar5,0,0);
              puVar6 = (uint32 *)Color.get_red(&local_78,0);
              local_78 = *puVar6;
              uStack_74 = puVar6[1];
              uStack_70 = puVar6[2];
              uStack_6c = puVar6[3];
              uVar3 = DOTweenModuleUI.DOColor(lVar5,&local_78,0x3e4ccccd,0);
              uVar3 = TweenSettingsExtensions.SetLoops(uVar3,2,1,DAT_181d97f50);
              TweenSettingsExtensions.SetId(uVar3,"Hurt",DAT_181d97e40);
              uVar3 = *(uint64 *)(lVar10 + 80);
              uVar7 = String.Concat("SpeEffect/剧情/",this.speEffectName,0);
              plVar8 = (int64 *)Resources.Load(uVar7,0);
              lVar10 = Component.get_transform(lVar5,0);
              if (lVar10 == null) goto LAB_1808c8b4a;
              puVar6 = (uint32 *)Transform.get_localPosition(&local_78,lVar10,0);
              uVar13 = *puVar6;
              lVar10 = Component.get_transform(lVar5,0);
              if (lVar10 == null) goto LAB_1808c8b4a;
              lVar10 = Transform.get_localPosition(&local_78,lVar10,0);
              fVar1 = *(float *)(lVar10 + 4);
              puVar9 = (uint64 *)Vector3.get_one(&local_78,0);
              local_98 = *puVar9;
              local_90 = *(float *)(puVar9 + 1);
              local_a0 = local_90 * 300.0;
              local_a8 = CONCAT44((float)((uint64)local_98 >> 32) * 300.0,(float)local_98 * 300.0);
              local_98 = local_a8;
              local_a8 = CONCAT44(fVar1 * 0.5,uVar13);
              local_90 = local_a0;
              local_a0 = 0.0;
              if ((plVar8 != (int64 *)0) && (*plVar8 == DAT_181d4e110)) {
                plVar12 = plVar8;
              }
              GlobalData.AddChild(uVar3,plVar12,&local_a8,&local_98,0);
            }
          }
          uVar3 = 0;
        }
        return uVar3;
    }

    // Token : 0x6001F56
    // RVA   : 0x20F140   Offset: 0x20D940   Length: 0x5
    private virtual object System.Collections.Generic.IEnumerator<System.object>.get_Current()
    {
        return this.<>2__current;
    }

    // Token : 0x6001F57
    // RVA   : 0x8C8B50   Offset: 0x8C7350   Length: 0x3E
    private virtual void System.Collections.IEnumerator.Reset()
    {
        ulong uVar1;
        ulong uVar2;
        uVar1 = il2cpp_runtime_class_init(&DAT_181d682e8);
        uVar1 = il2cpp_internal(uVar1);
        NotSupportedException.ctor(uVar1,0);
        uVar2 = il2cpp_runtime_class_init(&DAT_181d81228);
    }

    // Token : 0x6001F58
    // RVA   : 0x20F140   Offset: 0x20D940   Length: 0x5
    private virtual object System.Collections.IEnumerator.get_Current()
    {
        return this.<>2__current;
    }

}
