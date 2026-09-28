// ============================================================
// Type  : <StartBattle>d__153
// Token : 0x2000163
// ============================================================

public class <StartBattle>d__153
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x40009A4
    private int <>1__state;

    // Token: 0x40009A5
    private object <>2__current;

    // Token: 0x40009A6
    public BattleController <>4__this;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000BB0
    // RVA   : 0x219070   Offset: 0x218470   Length: 0x24
    public void /*ctor*/(int <>1__state)
    {
        ZhSegment.Initialize(this,0);
        this.<>1__state = <>1__state;
    }

    // Token : 0x6000BB1
    // RVA   : 0x245810   Offset: 0x244C10   Length: 0x3
    private virtual void System.IDisposable.Dispose()
    {
    }

    // Token : 0x6000BB2
    // RVA   : 0x9338C0   Offset: 0x932CC0   Length: 0xE07
    private virtual bool MoveNext()
    {
        var pStatics_3d40 = *(int64*)(DAT_181d73d40 + 184);
        var pStatics_6fb8 = *(int64*)(DAT_181dc6fb8 + 184);
        var pStatics_a860 = *(int64*)(DAT_181daa860 + 184);
        var pStatics_dcf8 = *(int64*)(DAT_181dadcf8 + 184);
        int iVar1;
        uint uVar2;
        bool cVar3;
        long lVar4;
        ulong uVar5;
        long lVar7;
        ulong uVar8;
        long lVar9;
        uint uVar10;
        uint uVar11;
        uint[] local_res8 = new uint[2];
        ulong local_38;
        uint local_30;
        byte[] local_28 = new byte[16];
        iVar1 = this.<>1__state;
        lVar9 = this.<>4__this;
        if (iVar1 != 0) {
          if (iVar1 != 1) {
            if (iVar1 == 2) {
              this.<>1__state = 0xffffffff;
              return false;
            }
            return false;
          }
          this.<>1__state = 0xffffffff;
          if (lVar9 == null) throw; // [null/range check failed]
          *(uint32 *)(lVar9 + 36) = 2;
          if (((*(int64 *)(lVar9 + 0x140) == 0) ||
              (lVar4 = GameObject.get_transform(*(int64 *)(lVar9 + 0x140),0)) == null) ||
             (lVar4 = Transform.Find(lVar4,"Text",0)) == null) throw; // [null/range check failed]
          lVar4 = Component.GetComponent(lVar4,DAT_181d95560);
          uVar5 = BattleController.GetWinConditionText(lVar9,0);
          if (lVar4 == null) throw; // [null/range check failed]
          *(uint64 *)(lVar4 + 24) = uVar5;
          if (*pStatics_dcf8 == 0) throw; // [null/range check failed]
          TutorialController.StartTutorial(*pStatics_dcf8,"战斗基础",0);
          if (*(char *)(lVar9 + 0x1ac) == false) {
            if ((*(char *)(lVar9 + 0x1d1) == false) && (*(int *)(lVar9 + 140) < 0)) {
              if (*(int64 *)(lVar9 + 0x178) == 0) throw; // [null/range check failed]
              GameObject.SetActive(*(int64 *)(lVar9 + 0x178),1,0);
              if (*(int64 *)(lVar9 + 0x178) == 0) throw; // [null/range check failed]
              lVar4 = GameObject.get_transform(*(int64 *)(lVar9 + 0x178),0);
              puVar6 = (uint64 *)Vector3.get_zero(local_28,0);
              if (lVar4 == null) throw; // [null/range check failed]
              local_30 = *(uint32 *)(puVar6 + 1);
              local_38 = *puVar6;
              Transform.set_localScale(lVar4,&local_38,0);
              if (*(int64 *)(lVar9 + 0x178) == 0) throw; // [null/range check failed]
              uVar5 = GameObject.get_transform(*(int64 *)(lVar9 + 0x178),0);
              puVar6 = (uint64 *)Vector3.get_one(local_28,0);
              local_30 = *(uint32 *)(puVar6 + 1);
              local_38 = *puVar6;
              uVar5 = ShortcutExtensions.DOScale(uVar5,&local_38,0x3e800000,0);
              TweenSettingsExtensions.SetEase(uVar5,27,DAT_181dc0f80);
              if (*(char *)(lVar9 + 0x1ac) != false) goto LAB_180933c24;
            }
            cVar3 = BattleController.HavePlayerControlUnit(lVar9,0);
            if (!cVar3) {
              lVar9 = *(int64 *)(lVar9 + 400);
              if (lVar9 == null) throw; // [null/range check failed]
              uVar5 = 0;
              goto LAB_180933c36;
            }
          }
        LAB_180933c24:
          lVar9 = *(int64 *)(lVar9 + 400);
          if (lVar9 != null) {
            uVar5 = 1;
        LAB_180933c36:
            GameObject.SetActive(lVar9,uVar5,0);
            this.<>2__current = 0;
            this.<>1__state = 2;
            return true;
          }
          throw; // [null/range check failed]
        }
        this.<>1__state = 0xffffffff;
        lVar4 = Camera.get_main(0);
        if ((((((lVar4 == null) || (lVar4 = Component.GetComponent(lVar4,DAT_181d94ce0)) == null) ||
              (lVar4 = PostProcessVolume.get_profile(lVar4,0)) == null) ||
             (((lVar4 = PostProcessProfile.GetSetting(lVar4,DAT_181d98410), lVar4 == null ||
               (*(int64 *)(lVar4 + 32) == 0)) ||
              ((*(uint8 *)(*(int64 *)(lVar4 + 32) + 24) = 1, lVar9 == null ||
               ((*(int64 *)(lVar9 + 0x140) == 0 ||
                (lVar4 = GameObject.get_transform(*(int64 *)(lVar9 + 0x140),0)) == null))))))) ||
            (lVar4 = Transform.Find(lVar4,"Text",0)) == null) ||
           (lVar4 = Component.GetComponent(lVar4,DAT_181d95560)) == null) {
        LAB_1809346bc:
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
        *(uint64 *)(lVar4 + 24) = "";
        if (((*pStatics_a860 == 0) ||
            (lVar4 = Component.get_transform(*pStatics_a860,0)) == null) ||
           (lVar4 = Transform.Find(lVar4,"BattleType",0)) == null) goto LAB_1809346bc;
        uVar5 = Component.GetComponent(lVar4,DAT_181d96160);
        lVar4 = *(int64 *)(pStatics_3d40 + 0x450);
        if (lVar4 == null) goto LAB_1809346bc;
        uVar2 = *(uint32 *)(lVar9 + 32);
        if (*(uint32 *)(lVar4 + 24) <= uVar2) {
          ThrowHelper.ThrowArgumentOutOfRangeException(0);
        }
        uVar8 = lVar4[uVar2];
        LTLocalization.SetText(uVar5,uVar8,0);
        if (((*pStatics_a860 == 0) ||
            (lVar4 = Component.get_transform(*pStatics_a860,0)) == null) ||
           (lVar4 = Transform.Find(lVar4,"BattleType",0)) == null) goto LAB_1809346bc;
        lVar7 = Component.GetComponent(lVar4,DAT_181d95560);
        lVar4 = *(int64 *)(pStatics_3d40 + 0x458);
        if (lVar4 == null) goto LAB_1809346bc;
        uVar2 = *(uint32 *)(lVar9 + 32);
        if (*(uint32 *)(lVar4 + 24) <= uVar2) {
          ThrowHelper.ThrowArgumentOutOfRangeException(0);
        }
        uVar5 = lVar4[uVar2];
        lVar4 = **(int64 **)(DAT_181db0248 + 184);
        if (lVar4 == null) goto LAB_1809346bc;
        uVar2 = *(uint32 *)(lVar9 + 32);
        if (*(uint32 *)(lVar4 + 24) <= uVar2) {
          ThrowHelper.ThrowArgumentOutOfRangeException(0);
        }
        local_res8[0] = lVar4[uVar2];
        uVar8 = il2cpp_value_box(DAT_181da22d8,local_res8);
        uVar5 = String.Format(uVar5,uVar8,0);
        if (lVar7 == null) goto LAB_1809346bc;
        *(uint64 *)(lVar7 + 24) = uVar5;
        if (((*pStatics_a860 == 0) ||
            (lVar4 = Component.get_transform(*pStatics_a860,0)) == null) ||
           (lVar4 = Transform.Find(lVar4,"TeamSpeAdd0",0)) == null) goto LAB_1809346bc;
        lVar7 = Component.get_gameObject(lVar4,0);
        lVar4 = *(int64 *)(lVar9 + 112);
        if (lVar4 == null) goto LAB_1809346bc;
        if (*(int *)(lVar4 + 24) == 0) {
          ThrowHelper.ThrowArgumentOutOfRangeException(0);
        }
        lVar4 = *(int64 *)(*(int64 *)(lVar4 + 16) + 32);
        if (((lVar4 == null) || (lVar4 = *(int64 *)(lVar4 + 48)) == null) ||
           (cVar3 = HeroSpeAddData.isEmpty(lVar4,0), lVar7 == null)) goto LAB_1809346bc;
        GameObject.SetActive(lVar7,!cVar3,0);
        if (((*pStatics_a860 == 0) ||
            (lVar4 = Component.get_transform(*pStatics_a860,0)) == null) ||
           (lVar4 = Transform.Find(lVar4,"TeamSpeAdd0",0)) == null) goto LAB_1809346bc;
        lVar7 = Component.GetComponent(lVar4,DAT_181d95560);
        lVar4 = *(int64 *)(lVar9 + 112);
        if (lVar4 == null) goto LAB_1809346bc;
        if (*(int *)(lVar4 + 24) == 0) {
          ThrowHelper.ThrowArgumentOutOfRangeException(0);
        }
        lVar4 = *(int64 *)(*(int64 *)(lVar4 + 16) + 32);
        if ((lVar4 == null) || (lVar4 = *(int64 *)(lVar4 + 48)) == null) goto LAB_1809346bc;
        uVar5 = HeroSpeAddData.GetDescribe(lVar4,1,1,1,0,0);
        uVar5 = String.Concat("绿方队伍加成:\n",uVar5,0);
        if (lVar7 == null) goto LAB_1809346bc;
        *(uint64 *)(lVar7 + 24) = uVar5;
        if (((*pStatics_a860 == 0) ||
            (lVar4 = Component.get_transform(*pStatics_a860,0)) == null) ||
           (lVar4 = Transform.Find(lVar4,"TeamSpeAdd1",0)) == null) goto LAB_1809346bc;
        lVar7 = Component.get_gameObject(lVar4,0);
        lVar4 = *(int64 *)(lVar9 + 112);
        if (lVar4 == null) goto LAB_1809346bc;
        if (*(uint32 *)(lVar4 + 24) < 2) {
          ThrowHelper.ThrowArgumentOutOfRangeException(0);
        }
        lVar4 = *(int64 *)(*(int64 *)(lVar4 + 16) + 40);
        if (((lVar4 == null) || (lVar4 = *(int64 *)(lVar4 + 48)) == null) ||
           (cVar3 = HeroSpeAddData.isEmpty(lVar4,0), lVar7 == null)) goto LAB_1809346bc;
        GameObject.SetActive(lVar7,!cVar3,0);
        if (((*pStatics_a860 == 0) ||
            (lVar4 = Component.get_transform(*pStatics_a860,0)) == null) ||
           (lVar4 = Transform.Find(lVar4,"TeamSpeAdd1",0)) == null) goto LAB_1809346bc;
        lVar7 = Component.GetComponent(lVar4,DAT_181d95560);
        lVar4 = *(int64 *)(lVar9 + 112);
        if (lVar4 == null) goto LAB_1809346bc;
        if (*(uint32 *)(lVar4 + 24) < 2) {
          ThrowHelper.ThrowArgumentOutOfRangeException(0);
        }
        lVar4 = *(int64 *)(*(int64 *)(lVar4 + 16) + 40);
        if ((lVar4 == null) || (lVar4 = *(int64 *)(lVar4 + 48)) == null) goto LAB_1809346bc;
        uVar5 = HeroSpeAddData.GetDescribe(lVar4,1,1,1,0,0);
        uVar5 = String.Concat("红方队伍加成:\n",uVar5,0);
        if (lVar7 == null) goto LAB_1809346bc;
        *(uint64 *)(lVar7 + 24) = uVar5;
        lVar4 = FUN_18046c0a0(0);
        if ((lVar4 == null) || (*(int64 *)(lVar4 + 32) == 0)) goto LAB_1809346bc;
        if (*(int *)(*(int64 *)(lVar4 + 32) + 156) == 0) {
          lVar4 = FUN_18046c0a0(0);
          if ((lVar4 == null) || (*(int64 *)(lVar4 + 32) == 0)) throw; // [null/range check failed]
          if (-1 < *(int *)(*(int64 *)(lVar4 + 32) + 16)) goto LAB_18093449d;
          if ((((*(int64 *)(lVar9 + 0x198) == 0) ||
               (lVar4 = GameObject.get_transform(*(int64 *)(lVar9 + 0x198),0)) == null) ||
              (lVar4 = Transform.Find(lVar4,"10",0)) == null) ||
             (lVar4 = Component.get_gameObject(lVar4,0)) == null) throw; // [null/range check failed]
          GameObject.SetActive(lVar4,0,0);
          if (((*(int64 *)(lVar9 + 0x198) == 0) ||
              (lVar4 = GameObject.get_transform(*(int64 *)(lVar9 + 0x198),0)) == null) ||
             ((lVar4 = Transform.Find(lVar4,"20",0), lVar4 == null ||
              (lVar4 = Component.get_gameObject(lVar4,0)) == null))) throw; // [null/range check failed]
          GameObject.SetActive(lVar4,0,0);
          lVar4 = FUN_18046c0a0(0);
          if (lVar4 == null) throw; // [null/range check failed]
          lVar4 = *(int64 *)(lVar4 + 32);
          lVar7 = FUN_18046c0a0(0);
          if ((lVar7 == null) || (*(int64 *)(lVar7 + 32) == 0)) throw; // [null/range check failed]
          uVar11 = 0x40a00000;
          uVar10 = *(uint32 *)(*(int64 *)(lVar7 + 32) + 0x1d8);
        }
        else {
        LAB_18093449d:
          if ((((*(int64 *)(lVar9 + 0x198) == 0) ||
               (lVar4 = GameObject.get_transform(*(int64 *)(lVar9 + 0x198),0)) == null) ||
              (lVar4 = Transform.Find(lVar4,"10",0)) == null) ||
             (lVar4 = Component.get_gameObject(lVar4,0)) == null) throw; // [null/range check failed]
          GameObject.SetActive(lVar4,1,0);
          if (((*(int64 *)(lVar9 + 0x198) == 0) ||
              (lVar4 = GameObject.get_transform(*(int64 *)(lVar9 + 0x198),0)) == null) ||
             ((lVar4 = Transform.Find(lVar4,"20",0), lVar4 == null ||
              (lVar4 = Component.get_gameObject(lVar4,0)) == null))) throw; // [null/range check failed]
          GameObject.SetActive(lVar4,1,0);
          lVar4 = FUN_18046c0a0(0);
          if (lVar4 == null) throw; // [null/range check failed]
          lVar4 = *(int64 *)(lVar4 + 32);
          lVar7 = FUN_18046c0a0(0);
          if ((lVar7 == null) || (*(int64 *)(lVar7 + 32) == 0)) throw; // [null/range check failed]
          uVar11 = 0x41a00000;
          uVar10 = *(uint32 *)(*(int64 *)(lVar7 + 32) + 0x1d8);
        }
        uVar10 = FUN_1810e36c0(uVar10,0x3f800000,uVar11,0);
        if (lVar4 != null) {
          *(uint32 *)(lVar4 + 0x1d8) = uVar10;
          if ((*pStatics_a860 != 0) &&
             (lVar4 = Component.get_gameObject(*pStatics_a860,0)) != null) {
            GameObject.SetActive(lVar4,1,0);
            BattleController.SetTimeScaleTab(lVar9,0);
            BattleController.SetPauseButtonInteractable(lVar9,1,0);
            if (*(int64 *)(lVar9 + 0x178) != 0) {
              GameObject.SetActive(*(int64 *)(lVar9 + 0x178),0,0);
              lVar4 = *pStatics_6fb8;
              if (lVar4 != null) {
                FightScoreBarController.RefreshFightScoreBar
                          (lVar4,CONCAT71((int7)((uint64)pStatics_6fb8 >> 8),1),
                           0);
                uVar5 = BattleController.TeamEnterBattleField(lVar9,*(uint64 *)(lVar9 + 80),0,0);
                this.<>2__current = uVar5;
                this.<>1__state = 1;
                return true;
              }
            }
          }
        }
    }

    // Token : 0x6000BB3
    // RVA   : 0x20F140   Offset: 0x20E540   Length: 0x5
    private virtual object System.Collections.Generic.IEnumerator<System.object>.get_Current()
    {
        return this.<>2__current;
    }

    // Token : 0x6000BB4
    // RVA   : 0x9346D0   Offset: 0x933AD0   Length: 0x3E
    private virtual void System.Collections.IEnumerator.Reset()
    {
        ulong uVar1;
        ulong uVar2;
        uVar1 = il2cpp_runtime_class_init(&DAT_181d8d510);
        uVar1 = il2cpp_internal(uVar1);
        NotSupportedException.ctor(uVar1,0);
        uVar2 = il2cpp_runtime_class_init(&DAT_181d97cb8);
    }

    // Token : 0x6000BB5
    // RVA   : 0x20F140   Offset: 0x20E540   Length: 0x5
    private virtual object System.Collections.IEnumerator.get_Current()
    {
        return this.<>2__current;
    }

}
