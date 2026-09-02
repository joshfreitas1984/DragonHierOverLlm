// ============================================================
// Type  : <InitToggleButton>d__14
// Token : 0x200033C
// ============================================================

public class <InitToggleButton>d__14
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001A1B
    private int <>1__state;

    // Token: 0x4001A1C
    private object <>2__current;

    // Token: 0x4001A1D
    public RecruitUIController <>4__this;

    // Token: 0x4001A1E
    public float recruitLv;

    // Token: 0x4001A1F
    public int heroNum;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6002025
    // RVA   : 0x219070   Offset: 0x217870   Length: 0x24
    public void /*ctor*/(int <>1__state)
    {
        ZhSegment.Initialize(this,0);
        this.<>1__state = <>1__state;
    }

    // Token : 0x6002026
    // RVA   : 0x245810   Offset: 0x244010   Length: 0x3
    private virtual void System.IDisposable.Dispose()
    {
    }

    // Token : 0x6002027
    // RVA   : 0x8CC830   Offset: 0x8CB030   Length: 0xC0D
    private virtual bool MoveNext()
    {
        var pStatics = *(int64*)(DAT_181d5d920 + 184);
        int iVar1;
        uint uVar2;
        long lVar3;
        long lVar5;
        ulong uVar7;
        ulong uVar8;
        ulong uVar9;
        long lVar10;
        long lVar11;
        long lVar12;
        int iVar14;
        uint uVar15;
        uint[] local_res8 = new uint[2];
        uint[] local_res18 = new uint[4];
        ulong in_stack_ffffffffffffff28;
        uint uVar16;
        uint local_98;
        uint uStack_94;
        uint uStack_90;
        byte[] local_88 = new byte[80];
        iVar1 = this.<>1__state;
        iVar14 = 0;
        lVar12 = this.<>4__this;
        local_res8[0] = 0;
        if (iVar1 == 0) {
          this.<>1__state = 0xffffffff;
          if ((lVar12 != null) && (*(int64 *)(lVar12 + 64) != 0)) {
            lVar3 = GameObject.get_transform(*(int64 *)(lVar12 + 64),0);
            puVar13 = (uint64 *)Vector3.get_zero(local_88,0);
            if (lVar3 != null) {
              uStack_90 = *(uint32 *)(puVar13 + 1);
              local_98 = (uint32)*puVar13;
              uStack_94 = (uint32)((uint64)*puVar13 >> 32);
              Transform.set_localScale(lVar3,&local_98,0);
              if (*(int64 *)(lVar12 + 72) != 0) {
                lVar12 = GameObject.get_transform(*(int64 *)(lVar12 + 72),0);
                puVar13 = (uint64 *)Vector3.get_zero(local_88,0);
                if (lVar12 != null) {
                  uStack_90 = *(uint32 *)(puVar13 + 1);
                  local_98 = (uint32)*puVar13;
                  uStack_94 = (uint32)((uint64)*puVar13 >> 32);
                  Transform.set_localScale(lVar12,&local_98,0);
                  local_res18[0] = 1;
                  uVar7 = il2cpp_value_box(DAT_181d5b2f8,local_res18);
                  this.<>2__current = uVar7;
                  this.<>1__state = 1;
                  return true;
                }
              }
            }
          }
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
        if (iVar1 == 1) {
          this.<>1__state = 0xffffffff;
          if (0 < this.heroNum) {
            do {
              uVar16 = (uint32)((uint64)in_stack_ffffffffffffff28 >> 32);
              if ((((lVar12 == null) || (*(int64 *)(lVar12 + 32) == 0)) ||
                  (lVar3 = GameObject.get_transform(*(int64 *)(lVar12 + 32),0)) == null) ||
                 (lVar3 = Transform.Find(lVar3,"ToggleGroup",0)) == null) goto LAB_1808cd438;
              uVar9 = Component.get_gameObject(lVar3,0);
              uVar7 = *(uint64 *)(lVar12 + 40);
              uVar7 = GlobalData.AddChild(uVar9,uVar7,0);
              *(uint64 *)(lVar12 + 80) = uVar7;
              if (*(int64 *)(lVar12 + 80) == 0) goto LAB_1808cd438;
              lVar3 = GameObject.get_transform(*(int64 *)(lVar12 + 80),0);
              puVar13 = (uint64 *)Vector3.get_zero(local_88,0);
              if (lVar3 == null) goto LAB_1808cd438;
              uStack_90 = *(uint32 *)(puVar13 + 1);
              local_98 = (uint32)*puVar13;
              uStack_94 = (uint32)((uint64)*puVar13 >> 32);
              Transform.set_localScale(lVar3,&local_98,0);
              if (*(int64 *)(lVar12 + 80) == 0) goto LAB_1808cd438;
              lVar3 = GameObject.GetComponent(*(int64 *)(lVar12 + 80),DAT_181da2130);
              if (((*(int64 *)(lVar12 + 80) == 0) ||
                  (lVar5 = GameObject.get_transform(*(int64 *)(lVar12 + 80),0)) == null) ||
                 ((lVar5 = FUN_180da0f00(lVar5,0), lVar5 == null ||
                  (uVar7 = Component.GetComponent(lVar5,DAT_181d6dac0), lVar3 == null))))
              goto LAB_1808cd438;
              Toggle.set_group(lVar3,uVar7,0);
              if ((*(int64 *)(lVar12 + 80) == 0) ||
                 (lVar3 = GameObject.GetComponent(*(int64 *)(lVar12 + 80),DAT_181da0b10), lVar3 == null
                 )) goto LAB_1808cd438;
              *(int *)(lVar3 + 24) = iVar14;
              if ((*(int64 *)(lVar12 + 80) == 0) ||
                 ((lVar3 = GameObject.get_transform(*(int64 *)(lVar12 + 80),0), lVar3 == null ||
                  (lVar3 = Transform.Find(lVar3,"HeroIcon",0)) == null))) goto LAB_1808cd438;
              uVar7 = Component.get_gameObject(lVar3,0);
              lVar3 = FUN_18046c1a0(0);
              if ((lVar3 == null) ||
                 (lVar3 = GlobalData.AddChild(uVar7,*(uint64 *)(lVar3 + 144),0)) == null)
              goto LAB_1808cd438;
              lVar5 = GameObject.GetComponent(lVar3,DAT_181d9fb20);
              lVar10 = FUN_18046c0a0(0);
              uVar15 = GlobalData.RandomRange
                                 (this.recruitLv * 0.45,this.recruitLv * 0.9,0,0);
              if (*(int *)(lVar12 + 24) == 0) {
                lVar11 = FUN_18046c0a0(0);
                if ((((lVar11 == null) || (*(int64 *)(lVar11 + 32) == 0)) ||
                    (lVar11 = WorldData.Player(*(int64 *)(lVar11 + 32),0)) == null) ||
                   (lVar11 = HeroData.GetForce(lVar11,0,0)) == null) goto LAB_1808cd438;
                uVar2 = ForceData.ForceSexLimit(lVar11,0);
              }
              else {
                uVar2 = 0;
              }
              if (lVar10 == null) goto LAB_1808cd438;
              in_stack_ffffffffffffff28 = CONCAT44(uVar16,uVar15);
              uVar7 = GameController.GenerateHeroData
                                (lVar10,0,0xffffffff,0xffffffff,in_stack_ffffffffffffff28,0,1,uVar2,0,0,0)
              ;
              if (lVar5 == null) goto LAB_1808cd438;
              *(uint64 *)(lVar5 + 32) = uVar7;
              lVar5 = FUN_18046c0a0(0);
              lVar10 = GameObject.GetComponent(lVar3,DAT_181d9fb20);
              if ((lVar10 == null) || (lVar5 == null)) goto LAB_1808cd438;
              GameController.CountHeroData(lVar5,*(uint64 *)(lVar10 + 32),0);
              lVar5 = GameObject.GetComponent(lVar3,DAT_181d9fb20);
              if (lVar5 == null) goto LAB_1808cd438;
              *(uint32 *)(lVar5 + 24) = 2;
              lVar5 = GameObject.GetComponent(lVar3,DAT_181d9fb20);
              if (lVar5 == null) goto LAB_1808cd438;
              HeroIconController.AutoSetName(lVar5,0);
              if (*(int64 *)(lVar12 + 48) == 0) goto LAB_1808cd438;
              FUN_181827900(*(int64 *)(lVar12 + 48),lVar3,DAT_181d61bf8);
              if (((*(int64 *)(lVar12 + 80) == 0) ||
                  (lVar3 = GameObject.get_transform(*(int64 *)(lVar12 + 80),0)) == null) ||
                 (lVar3 = Transform.Find(lVar3,"MoneyCost",0)) == null) goto LAB_1808cd438;
              uVar7 = Component.GetComponent(lVar3,DAT_181d6d8c0);
              if (((*(int64 *)(lVar12 + 48) == 0) ||
                  (lVar3 = FUN_180002f80(*(int64 *)(lVar12 + 48),iVar14,DAT_181d62178)) == null)
                 || ((lVar3 = GameObject.GetComponent(lVar3,DAT_181d9fb20), lVar3 == null ||
                     (*(int64 *)(lVar3 + 32) == 0)))) goto LAB_1808cd438;
              local_res8[0] =
                   HeroData.GetRecruitCost
                             (*(int64 *)(lVar3 + 32),*(int *)(lVar12 + 24) == 1,0x3f800000);
              uVar9 = Int32.ToString(local_res8,0);
              LTLocalization.SetText(uVar7,uVar9,0);
              if (((*(int64 *)(lVar12 + 80) == 0) ||
                  (lVar3 = GameObject.get_transform(*(int64 *)(lVar12 + 80),0)) == null) ||
                 (lVar3 = Transform.Find(lVar3,"FightScore",0)) == null) goto LAB_1808cd438;
              uVar7 = Component.GetComponent(lVar3,DAT_181d6d8c0);
              if ((((*(int64 *)(lVar12 + 48) == 0) ||
                   (lVar3 = FUN_180002f80(*(int64 *)(lVar12 + 48),iVar14)) == null) ||
                  (lVar3 = GameObject.GetComponent(lVar3,DAT_181d9fb20)) == null) ||
                 (*(int64 *)(lVar3 + 32) == 0)) goto LAB_1808cd438;
              Single.ToString(*(int64 *)(lVar3 + 32) + 0x38c,"f0");
              LTLocalization.SetText(uVar7);
              iVar14 = iVar14 + 1;
            } while (iVar14 < this.heroNum);
          }
          local_res18[0] = 1;
          uVar7 = il2cpp_value_box(DAT_181d5b2f8,local_res18);
          this.<>2__current = uVar7;
          uVar7 = 1;
          this.<>1__state = 2;
        }
        else {
          if (iVar1 == 2) {
            this.<>1__state = 0xffffffff;
            if (((lVar12 == null) || (*(int64 *)(lVar12 + 32) == 0)) ||
               ((lVar3 = GameObject.get_transform(*(int64 *)(lVar12 + 32),0), lVar3 == null ||
                ((lVar3 = Transform.Find(lVar3,"ToggleGroup",0), lVar3 == null ||
                 (plVar4 = (int64 *)Component.GetComponent(lVar3,DAT_181d6e0c0),
                 plVar4 == (int64 *)0)))))) {
        LAB_1808cd438:
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            (**(code **)(*plVar4 + 0x1b8))(plVar4,*(uint64 *)(*plVar4 + 0x1c0));
            if (0 < this.heroNum) {
              do {
                if (((*(int64 *)(lVar12 + 32) == 0) ||
                    (lVar3 = GameObject.get_transform(*(int64 *)(lVar12 + 32),0)) == null) ||
                   (lVar3 = Transform.Find(lVar3,"ToggleGroup",0)) == null) goto LAB_1808cd438;
                lVar3 = Transform.GetChild(lVar3,iVar14,0);
                if (((*(int64 *)(lVar12 + 32) == 0) ||
                    (lVar5 = GameObject.get_transform(*(int64 *)(lVar12 + 32),0)) == null) ||
                   ((lVar5 = Transform.Find(lVar5,"ToggleGroup",0), lVar5 == null ||
                    (lVar5 = Transform.GetChild(lVar5,iVar14,0)) == null))) goto LAB_1808cd438;
                puVar6 = (uint32 *)Transform.get_localPosition(local_88,lVar5,0);
                if (lVar3 == null) goto LAB_1808cd438;
                uStack_94 = 0x43480000;
                uStack_90 = 0;
                local_98 = *puVar6;
                Transform.set_localPosition(lVar3,&local_98,0);
                if (((*(int64 *)(lVar12 + 32) == 0) ||
                    (lVar3 = GameObject.get_transform(*(int64 *)(lVar12 + 32),0)) == null) ||
                   (lVar3 = Transform.Find(lVar3,"ToggleGroup",0)) == null) goto LAB_1808cd438;
                uVar7 = Transform.GetChild(lVar3,iVar14,0);
                uVar7 = ShortcutExtensions.DOLocalMoveY(uVar7);
                TweenSettingsExtensions.SetDelay(uVar7);
                if (((*(int64 *)(lVar12 + 32) == 0) ||
                    (lVar3 = GameObject.get_transform(*(int64 *)(lVar12 + 32),0)) == null) ||
                   (lVar3 = Transform.Find(lVar3,"ToggleGroup",0)) == null) goto LAB_1808cd438;
                uVar7 = Transform.GetChild(lVar3,iVar14,0);
                uVar7 = ShortcutExtensions.DOScale(uVar7);
                uVar7 = TweenSettingsExtensions.SetDelay(uVar7);
                if (*(int64 *)(pStatics + 8) == 0) {
                  uVar9 = **(uint64 **)(DAT_181d5d920 + 184);
                  uVar8 = new OnTooltipCB(uVar9,DAT_181d827a8);
                  puVar13 = (uint64 *)(pStatics + 8);
                  *puVar13 = uVar8;
                  il2cpp_internal(puVar13,uVar8);
                }
                TweenSettingsExtensions.OnStart(uVar7);
                iVar14 = iVar14 + 1;
              } while (iVar14 < this.heroNum);
            }
            if (*(int64 *)(lVar12 + 64) == 0) goto LAB_1808cd438;
            uVar7 = GameObject.get_transform(*(int64 *)(lVar12 + 64),0);
            uVar7 = ShortcutExtensions.DOScale(uVar7);
            TweenSettingsExtensions.SetDelay(uVar7,(float)this.heroNum * 0.5,DAT_181d97978);
            if (*(int64 *)(lVar12 + 72) == 0) goto LAB_1808cd438;
            uVar7 = GameObject.get_transform(*(int64 *)(lVar12 + 72),0);
            uVar7 = ShortcutExtensions.DOScale(uVar7);
            TweenSettingsExtensions.SetDelay(uVar7,(float)this.heroNum * 0.5,DAT_181d97978);
          }
          uVar7 = 0;
        }
        return uVar7;
    }

    // Token : 0x6002028
    // RVA   : 0x20F140   Offset: 0x20D940   Length: 0x5
    private virtual object System.Collections.Generic.IEnumerator<System.object>.get_Current()
    {
        return this.<>2__current;
    }

    // Token : 0x6002029
    // RVA   : 0x8CD440   Offset: 0x8CBC40   Length: 0x3E
    private virtual void System.Collections.IEnumerator.Reset()
    {
        ulong uVar1;
        ulong uVar2;
        uVar1 = il2cpp_runtime_class_init(&DAT_181d682e8);
        uVar1 = il2cpp_internal(uVar1);
        NotSupportedException.ctor(uVar1,0);
        uVar2 = il2cpp_runtime_class_init(&DAT_181d82828);
    }

    // Token : 0x600202A
    // RVA   : 0x20F140   Offset: 0x20D940   Length: 0x5
    private virtual object System.Collections.IEnumerator.get_Current()
    {
        return this.<>2__current;
    }

}
