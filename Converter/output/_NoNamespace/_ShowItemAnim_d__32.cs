// ============================================================
// Type  : <ShowItemAnim>d__32
// Token : 0x2000361
// ============================================================

public class <ShowItemAnim>d__32
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001AF1
    private int <>1__state;

    // Token: 0x4001AF2
    private object <>2__current;

    // Token: 0x4001AF3
    public SpeShowController <>4__this;

    // Token: 0x4001AF4
    public float delayTime;

    // Token: 0x4001AF5
    private float <CountDelayTime>5__2;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6002110
    // RVA   : 0x219070   Offset: 0x217870   Length: 0x24
    public void /*ctor*/(int <>1__state)
    {
        ZhSegment.Initialize(this,0);
        this.<>1__state = <>1__state;
    }

    // Token : 0x6002111
    // RVA   : 0x245810   Offset: 0x244010   Length: 0x3
    private virtual void System.IDisposable.Dispose()
    {
    }

    // Token : 0x6002112
    // RVA   : 0xB13BB0   Offset: 0xB123B0   Length: 0x8A7
    private virtual bool MoveNext()
    {
        var pStatics_df90 = *(int64*)(DAT_181d4df90 + 184);
        var pStatics_f230 = *(int64*)(DAT_181d7f230 + 184);
        float fVar1;
        float fVar2;
        long lVar3;
        int iVar4;
        int iVar5;
        long lVar6;
        ulong uVar7;
        long lVar8;
        ulong uVar9;
        uint uVar10;
        float fVar11;
        ulong local_78;
        ulong uStack_70;
        lVar3 = this.<>4__this;
        if (this.<>1__state == 0) {
          this.<>1__state = 0xffffffff;
          if (((lVar3 != null) && (*(int64 *)(lVar3 + 64) != 0)) &&
             (lVar6 = GameObject.get_transform(*(int64 *)(lVar3 + 64),0)) != null) {
            Transform.get_childCount(lVar6,0);
            Mathf.Max();
            uVar10 = FUN_1810a8ba0();
            fVar11 = this.delayTime;
            this.<CountDelayTime>5__2 = uVar10;
            fVar1 = this.<CountDelayTime>5__2;
            fVar2 = *(float *)(pStatics_f230 + 8);
            if ((*(int64 *)(lVar3 + 64) != 0) &&
               (lVar6 = GameObject.get_transform(*(int64 *)(lVar3 + 64),0)) != null) {
              iVar4 = Transform.get_childCount(lVar6,0);
              *(float *)(lVar3 + 32) = (float)(iVar4 + -1) * fVar1 + fVar11 + 0.5 + fVar2;
              uVar7 = new WaitForSeconds();
              this.<>2__current = uVar7;
              this.<>1__state = 1;
              return true;
            }
          }
        }
        else {
          if (this.<>1__state != 1) {
            return false;
          }
          this.<>1__state = 0xffffffff;
          if (lVar3 != null) {
            iVar4 = 0;
            if (*(char *)(lVar3 + 24) != false) {
              lVar6 = **(int64 **)(DAT_181d5a578 + 184);
              if (((*pStatics_df90 == 0) ||
                  (lVar8 = *(int64 *)(*pStatics_df90 + 32)) == null) ||
                 (lVar8 = WorldData.Player(lVar8,0)) == null) throw; // [null/range check failed]
              uVar7 = HeroData.HeroName(lVar8,0,0);
              if ((*(int64 *)(lVar3 + 56) == 0) ||
                 (lVar8 = *(int64 *)(*(int64 *)(lVar3 + 56) + 48)) == null)
              throw; // [null/range check failed]
              uVar9 = ItemListData.GetItemName(lVar8,0);
              uVar7 = String.Format("{0}获得了 {1}",uVar7,uVar9,0);
              if ((*(int64 *)(lVar3 + 56) == 0) ||
                 ((lVar8 = *(int64 *)(*(int64 *)(lVar3 + 56) + 48), lVar8 == null ||
                  (lVar8 = *(int64 *)(lVar8 + 40)) == null))) throw; // [null/range check failed]
              if (*(int *)(lVar8 + 24) == 0) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              lVar8 = *(int64 *)(*(int64 *)(lVar8 + 16) + 32);
              if ((lVar8 == null) || (uVar9 = ItemData.GetItemIconName(lVar8,0), lVar6 == null))
              throw; // [null/range check failed]
              local_78 = 0;
              uStack_70 = 0;
              InfoController.AddInfoTab
                        (lVar6,uVar7,"IconAtlas",uVar9,"Woosh",0x3f800000,0x40a00000,&local_78,0);
            }
            while ((*(int64 *)(lVar3 + 64) != 0 &&
                   (lVar6 = GameObject.get_transform(*(int64 *)(lVar3 + 64),0)) != null)) {
              iVar5 = Transform.get_childCount(lVar6,0);
              if (iVar5 <= iVar4) {
                return false;
              }
              uVar7 = DOTween.Sequence(0);
              if ((*(int64 *)(lVar3 + 64) == 0) ||
                 (lVar6 = GameObject.get_transform(*(int64 *)(lVar3 + 64),0)) == null) break;
              uVar9 = Transform.GetChild(lVar6,iVar4,0);
              uVar9 = ShortcutExtensions.DOScale(uVar9);
              fVar11 = (float)iVar4;
              uVar9 = TweenSettingsExtensions.SetDelay
                                (uVar9,this.<CountDelayTime>5__2 * fVar11,DAT_181d97978);
              uVar9 = TweenSettingsExtensions.SetEase(uVar9,27,DAT_181d97ca8);
              TweenSettingsExtensions.Append(uVar7,uVar9,0);
              if ((*(int64 *)(lVar3 + 64) == 0) ||
                 (lVar6 = GameObject.get_transform(*(int64 *)(lVar3 + 64),0)) == null) break;
              uVar9 = Transform.GetChild(lVar6,iVar4,0);
              uVar9 = ShortcutExtensions.DOScale
                                (uVar9,pStatics_f230,
                                 *(float *)(pStatics_f230 + 8) * 0.2,0);
              uVar9 = TweenSettingsExtensions.SetEase(uVar9,4,DAT_181d97ca8);
              TweenSettingsExtensions.Append(uVar7,uVar9,0);
              if ((*(int64 *)(lVar3 + 64) == 0) ||
                 ((lVar6 = GameObject.get_transform(*(int64 *)(lVar3 + 64),0), lVar6 == null ||
                  (lVar6 = Transform.GetChild(lVar6,iVar4,0)) == null))) break;
              uVar7 = Component.get_gameObject(lVar6,0);
              uVar7 = SpeShowController.PlayItemSound(lVar3,uVar7,this.<CountDelayTime>5__2 * fVar11);
              FUN_180d837c0(lVar3,uVar7,0);
              uVar7 = *(uint64 *)(lVar3 + 128);
              if ((*(int64 *)(lVar3 + 64) == 0) ||
                 ((lVar6 = GameObject.get_transform(*(int64 *)(lVar3 + 64),0), lVar6 == null ||
                  (lVar6 = Transform.GetChild(lVar6,iVar4,0)) == null))) break;
              uVar9 = Component.get_gameObject(lVar6,0);
              uVar7 = SpeShowController.ShowItemParticle
                                (lVar3,uVar7,uVar9,this.<CountDelayTime>5__2 * fVar11,0);
              FUN_180d837c0(lVar3,uVar7,0);
              uVar7 = *(uint64 *)(lVar3 + 136);
              if ((*(int64 *)(lVar3 + 64) == 0) ||
                 ((lVar6 = GameObject.get_transform(*(int64 *)(lVar3 + 64),0), lVar6 == null ||
                  (lVar6 = Transform.GetChild(lVar6,iVar4,0)) == null))) break;
              uVar9 = Component.get_gameObject(lVar6,0);
              uVar7 = SpeShowController.ShowItemParticle
                                (lVar3,uVar7,uVar9,this.<CountDelayTime>5__2 * fVar11,0);
              FUN_180d837c0(lVar3,uVar7,0);
              uVar7 = *(uint64 *)(lVar3 + 152);
              if ((*(int64 *)(lVar3 + 64) == 0) ||
                 ((lVar6 = GameObject.get_transform(*(int64 *)(lVar3 + 64),0), lVar6 == null ||
                  (lVar6 = Transform.GetChild(lVar6,iVar4,0)) == null))) break;
              uVar9 = Component.get_gameObject(lVar6,0);
              uVar7 = SpeShowController.ShowItemParticle
                                (lVar3,uVar7,uVar9,
                                 this.<CountDelayTime>5__2 * fVar11 +
                                 *(float *)(pStatics_f230 + 8),0);
              FUN_180d837c0(lVar3,uVar7);
              if ((*(int64 *)(lVar3 + 64) == 0) ||
                 ((((lVar6 = GameObject.get_transform(*(int64 *)(lVar3 + 64),0), lVar6 == null ||
                    (lVar6 = Transform.GetChild(lVar6,iVar4,0)) == null) ||
                   (lVar6 = Component.GetComponent(lVar6)) == null) ||
                  (*(int64 *)(lVar6 + 32) == 0)))) break;
              if (4 < *(int *)(*(int64 *)(lVar6 + 32) + 64)) {
                uVar7 = *(uint64 *)(lVar3 + 144);
                if (((*(int64 *)(lVar3 + 64) == 0) ||
                    (lVar6 = GameObject.get_transform(*(int64 *)(lVar3 + 64),0)) == null) ||
                   (lVar6 = Transform.GetChild(lVar6,iVar4,0)) == null) break;
                uVar9 = Component.get_gameObject(lVar6,0);
                SpeShowController.ShowItemParticle
                          (lVar3,uVar7,uVar9,this.<CountDelayTime>5__2 * fVar11,0);
                FUN_180d837c0(lVar3);
              }
              iVar4 = iVar4 + 1;
            }
          }
        }
    }

    // Token : 0x6002113
    // RVA   : 0x20F140   Offset: 0x20D940   Length: 0x5
    private virtual object System.Collections.Generic.IEnumerator<System.object>.get_Current()
    {
        return this.<>2__current;
    }

    // Token : 0x6002114
    // RVA   : 0xB14460   Offset: 0xB12C60   Length: 0x3E
    private virtual void System.Collections.IEnumerator.Reset()
    {
        ulong uVar1;
        ulong uVar2;
        uVar1 = il2cpp_runtime_class_init(&DAT_181d682e8);
        uVar1 = il2cpp_internal(uVar1);
        NotSupportedException.ctor(uVar1,0);
        uVar2 = il2cpp_runtime_class_init(&DAT_181d8a890);
    }

    // Token : 0x6002115
    // RVA   : 0x20F140   Offset: 0x20D940   Length: 0x5
    private virtual object System.Collections.IEnumerator.get_Current()
    {
        return this.<>2__current;
    }

}
