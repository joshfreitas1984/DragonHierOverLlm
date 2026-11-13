// ============================================================
// Type  : <InitToggleButton>d__14
// Token : 0x200034D
// ============================================================

public class <InitToggleButton>d__14
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001B8D
    private int <>1__state;

    // Token: 0x4001B8E
    private object <>2__current;

    // Token: 0x4001B8F
    public RecruitUIController <>4__this;

    // Token: 0x4001B90
    public float recruitLv;

    // Token: 0x4001B91
    public int heroNum;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6002144
    // RVA   : 0x608BA0   Offset: 0x6079A0   Length: 0x24
    public void /*ctor*/(int <>1__state)
    {
        ZhSegment.Initialize(this,0);
        this.<>1__state = <>1__state;
    }

    // Token : 0x6002145
    // RVA   : 0x51CF50   Offset: 0x51BD50   Length: 0x3
    private virtual void System.IDisposable.Dispose()
    {
    }

    // Token : 0x6002146
    // RVA   : 0x60F670   Offset: 0x60E470   Length: 0xC43
    private virtual bool MoveNext()
    {
        var pStatics = *(int64*)(DAT_181e63418 + 184);
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
                  uVar7 = il2cpp_value_box(DAT_181e60808,local_res18);
                  this.<>2__current = uVar7;
                  this.<>1__state = 1;
                  return true;
                }
              }
            }
          }
                          // WARNING: Subroutine does not return
          FUN_1801e0300();
        }
        if (iVar1 == 1) {
          this.<>1__state = 0xffffffff;
          if (0 < this.heroNum) {
            do {
              uVar16 = (uint32)((uint64)in_stack_ffffffffffffff28 >> 32);
              if ((((lVar12 == null) || (*(int64 *)(lVar12 + 32) == 0)) ||
                  (lVar3 = GameObject.get_transform(*(int64 *)(lVar12 + 32),0)) == null) ||
                 (lVar3 = Transform.Find(lVar3,"ToggleGroup",0)) == null) goto LAB_1806102ae;
              uVar9 = Component.get_gameObject(lVar3,0);
              uVar7 = *(uint64 *)(lVar12 + 40);
              uVar7 = GlobalData.AddChild(uVar9,uVar7,0);
              *(uint64 *)(lVar12 + 80) = uVar7;
              if (*(int64 *)(lVar12 + 80) == 0) goto LAB_1806102ae;
              lVar3 = GameObject.get_transform(*(int64 *)(lVar12 + 80),0);
              puVar13 = (uint64 *)Vector3.get_zero(local_88,0);
              if (lVar3 == null) goto LAB_1806102ae;
              uStack_90 = *(uint32 *)(puVar13 + 1);
              local_98 = (uint32)*puVar13;
              uStack_94 = (uint32)((uint64)*puVar13 >> 32);
              Transform.set_localScale(lVar3,&local_98,0);
              if (*(int64 *)(lVar12 + 80) == 0) goto LAB_1806102ae;
              lVar3 = GameObject.GetComponent(*(int64 *)(lVar12 + 80),DAT_181e57478);
              if (((*(int64 *)(lVar12 + 80) == 0) ||
                  (lVar5 = GameObject.get_transform(*(int64 *)(lVar12 + 80),0)) == null) ||
                 ((lVar5 = FUN_180b05920(lVar5,0), lVar5 == null ||
                  (uVar7 = Component.GetComponent(lVar5,DAT_181e79738), lVar3 == null))))
              goto LAB_1806102ae;
              Toggle.set_group(lVar3,uVar7,0);
              if ((*(int64 *)(lVar12 + 80) == 0) ||
                 (lVar3 = GameObject.GetComponent(*(int64 *)(lVar12 + 80),DAT_181e55c08), lVar3 == null
                 )) goto LAB_1806102ae;
              *(int *)(lVar3 + 24) = iVar14;
              if ((*(int64 *)(lVar12 + 80) == 0) ||
                 ((lVar3 = GameObject.get_transform(*(int64 *)(lVar12 + 80),0), lVar3 == null ||
                  (lVar3 = Transform.Find(lVar3,"HeroIcon",0)) == null))) goto LAB_1806102ae;
              uVar7 = Component.get_gameObject(lVar3,0);
              lVar3 = FUN_1802107e0(0);
              if ((lVar3 == null) ||
                 (lVar3 = GlobalData.AddChild(uVar7,*(uint64 *)(lVar3 + 144),0)) == null)
              goto LAB_1806102ae;
              lVar5 = GameObject.GetComponent(lVar3,DAT_181e54c18);
              lVar10 = FUN_1802106e0(0);
              uVar15 = GlobalData.RandomRange
                                 (this.recruitLv * 0.45,this.recruitLv * 0.9,0,0);
              if (*(int *)(lVar12 + 24) == 0) {
                lVar11 = FUN_1802106e0(0);
                if ((((lVar11 == null) || (*(int64 *)(lVar11 + 32) == 0)) ||
                    (lVar11 = WorldData.Player(*(int64 *)(lVar11 + 32),0)) == null) ||
                   (lVar11 = HeroData.GetForce(lVar11,0,0)) == null) goto LAB_1806102ae;
                uVar2 = ForceData.ForceSexLimit(lVar11,0);
              }
              else {
                uVar2 = 0;
              }
              if (lVar10 == null) goto LAB_1806102ae;
              in_stack_ffffffffffffff28 = CONCAT44(uVar16,uVar15);
              uVar7 = GameController.GenerateHeroData
                                (lVar10,0,0xffffffff,0xffffffff,in_stack_ffffffffffffff28,0,1,uVar2,0,0,0)
              ;
              if (lVar5 == null) goto LAB_1806102ae;
              *(uint64 *)(lVar5 + 32) = uVar7;
              lVar5 = FUN_1802106e0(0);
              lVar10 = GameObject.GetComponent(lVar3,DAT_181e54c18);
              if ((lVar10 == null) || (lVar5 == null)) goto LAB_1806102ae;
              GameController.CountHeroData(lVar5,*(uint64 *)(lVar10 + 32),1);
              lVar5 = GameObject.GetComponent(lVar3,DAT_181e54c18);
              if (lVar5 == null) goto LAB_1806102ae;
              *(uint32 *)(lVar5 + 24) = 2;
              lVar5 = GameObject.GetComponent(lVar3,DAT_181e54c18);
              if (lVar5 == null) goto LAB_1806102ae;
              HeroIconController.AutoSetName(lVar5,0);
              if (*(int64 *)(lVar12 + 48) == 0) goto LAB_1806102ae;
              FUN_18175de30(*(int64 *)(lVar12 + 48),lVar3,DAT_181e6b6f8);
              if (((*(int64 *)(lVar12 + 80) == 0) ||
                  (lVar3 = GameObject.get_transform(*(int64 *)(lVar12 + 80),0)) == null) ||
                 (lVar3 = Transform.Find(lVar3,"MoneyCost",0)) == null) goto LAB_1806102ae;
              uVar7 = Component.GetComponent(lVar3,DAT_181e79538);
              if (((*(int64 *)(lVar12 + 48) == 0) ||
                  (lVar3 = FUN_1800024b0(*(int64 *)(lVar12 + 48),iVar14,DAT_181e6bc70)) == null)
                 || ((lVar3 = GameObject.GetComponent(lVar3,DAT_181e54c18), lVar3 == null ||
                     (*(int64 *)(lVar3 + 32) == 0)))) goto LAB_1806102ae;
              local_res8[0] =
                   HeroData.GetRecruitCost
                             (*(int64 *)(lVar3 + 32),*(int *)(lVar12 + 24) == 1,0x3f800000);
              uVar9 = Int32.ToString(local_res8,0);
              LTLocalization.SetText(uVar7,uVar9,0);
              if (((*(int64 *)(lVar12 + 80) == 0) ||
                  (lVar3 = GameObject.get_transform(*(int64 *)(lVar12 + 80),0)) == null) ||
                 (lVar3 = Transform.Find(lVar3,"FightScore",0)) == null) goto LAB_1806102ae;
              uVar7 = Component.GetComponent(lVar3,DAT_181e79538);
              if (((*(int64 *)(lVar12 + 48) == 0) ||
                  (lVar3 = FUN_1800024b0(*(int64 *)(lVar12 + 48),iVar14)) == null) ||
                 ((lVar3 = GameObject.GetComponent(lVar3,DAT_181e54c18), lVar3 == null ||
                  (*(int64 *)(lVar3 + 32) == 0)))) goto LAB_1806102ae;
              Single.ToString(*(int64 *)(lVar3 + 32) + 0x388,"f0");
              LTLocalization.SetText(uVar7);
              iVar14 = iVar14 + 1;
            } while (iVar14 < this.heroNum);
          }
          local_res18[0] = 1;
          uVar7 = il2cpp_value_box(DAT_181e60808,local_res18);
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
                 (plVar4 = (int64 *)Component.GetComponent(lVar3,DAT_181e79d38),
                 plVar4 == (int64 *)0)))))) {
        LAB_1806102ae:
                          // WARNING: Subroutine does not return
              FUN_1801e0300();
            }
            (**(code **)(*plVar4 + 0x1b8))(plVar4,*(uint64 *)(*plVar4 + 0x1c0));
            if (0 < this.heroNum) {
              do {
                if (((*(int64 *)(lVar12 + 32) == 0) ||
                    (lVar3 = GameObject.get_transform(*(int64 *)(lVar12 + 32),0)) == null) ||
                   (lVar3 = Transform.Find(lVar3,"ToggleGroup",0)) == null) goto LAB_1806102ae;
                lVar3 = Transform.GetChild(lVar3,iVar14,0);
                if (((*(int64 *)(lVar12 + 32) == 0) ||
                    (lVar5 = GameObject.get_transform(*(int64 *)(lVar12 + 32),0)) == null) ||
                   ((lVar5 = Transform.Find(lVar5,"ToggleGroup",0), lVar5 == null ||
                    (lVar5 = Transform.GetChild(lVar5,iVar14,0)) == null))) goto LAB_1806102ae;
                puVar6 = (uint32 *)Transform.get_localPosition(local_88,lVar5,0);
                if (lVar3 == null) goto LAB_1806102ae;
                uStack_94 = 0x43480000;
                uStack_90 = 0;
                local_98 = *puVar6;
                Transform.set_localPosition(lVar3,&local_98,0);
                if (((*(int64 *)(lVar12 + 32) == 0) ||
                    (lVar3 = GameObject.get_transform(*(int64 *)(lVar12 + 32),0)) == null) ||
                   (lVar3 = Transform.Find(lVar3,"ToggleGroup",0)) == null) goto LAB_1806102ae;
                uVar7 = Transform.GetChild(lVar3,iVar14,0);
                uVar7 = ShortcutExtensions.DOLocalMoveY(uVar7);
                TweenSettingsExtensions.SetDelay(uVar7);
                if (((*(int64 *)(lVar12 + 32) == 0) ||
                    (lVar3 = GameObject.get_transform(*(int64 *)(lVar12 + 32),0)) == null) ||
                   (lVar3 = Transform.Find(lVar3,"ToggleGroup",0)) == null) goto LAB_1806102ae;
                uVar7 = Transform.GetChild(lVar3,iVar14,0);
                uVar7 = ShortcutExtensions.DOScale(uVar7);
                uVar7 = TweenSettingsExtensions.SetDelay(uVar7);
                if (*(int64 *)(pStatics + 8) == 0) {
                  uVar9 = **(uint64 **)(DAT_181e63418 + 184);
                  uVar8 = new OnTooltipCB(uVar9,DAT_181e8f208);
                  puVar13 = (uint64 *)(pStatics + 8);
                  *puVar13 = uVar8;
                  il2cpp_internal(puVar13,uVar8);
                }
                TweenSettingsExtensions.OnStart(uVar7);
                iVar14 = iVar14 + 1;
              } while (iVar14 < this.heroNum);
            }
            if (*(int64 *)(lVar12 + 64) == 0) goto LAB_1806102ae;
            uVar7 = GameObject.get_transform(*(int64 *)(lVar12 + 64),0);
            uVar7 = ShortcutExtensions.DOScale(uVar7);
            TweenSettingsExtensions.SetDelay(uVar7,(float)this.heroNum * 0.5,DAT_181ea4858);
            if (*(int64 *)(lVar12 + 72) == 0) goto LAB_1806102ae;
            uVar7 = GameObject.get_transform(*(int64 *)(lVar12 + 72),0);
            uVar7 = ShortcutExtensions.DOScale(uVar7);
            TweenSettingsExtensions.SetDelay(uVar7,(float)this.heroNum * 0.5,DAT_181ea4858);
          }
          uVar7 = 0;
        }
        return uVar7;
    }

    // Token : 0x6002147
    // RVA   : 0x608B50   Offset: 0x607950   Length: 0x5
    private virtual object System.Collections.Generic.IEnumerator<System.object>.get_Current()
    {
        return this.<>2__current;
    }

    // Token : 0x6002148
    // RVA   : 0x6102C0   Offset: 0x60F0C0   Length: 0x3E
    private virtual void System.Collections.IEnumerator.Reset()
    {
        ulong uVar1;
        ulong uVar2;
        uVar1 = il2cpp_runtime_class_init(&DAT_181e6d8e8);
        uVar1 = il2cpp_internal(uVar1);
        NotSupportedException.ctor(uVar1,0);
        uVar2 = il2cpp_runtime_class_init(&DAT_181e8f288);
    }

    // Token : 0x6002149
    // RVA   : 0x608B50   Offset: 0x607950   Length: 0x5
    private virtual object System.Collections.IEnumerator.get_Current()
    {
        return this.<>2__current;
    }

}
