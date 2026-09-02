// ============================================================
// Type  : <FinishStudyInternalSkill>d__48
// Token : 0x2000384
// ============================================================

public class <FinishStudyInternalSkill>d__48
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001C0B
    private int <>1__state;

    // Token: 0x4001C0C
    private object <>2__current;

    // Token: 0x4001C0D
    public StudyInternalResult studyInternalResult;

    // Token: 0x4001C0E
    public StudyInternalSkillController <>4__this;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6002216
    // RVA   : 0x219070   Offset: 0x217870   Length: 0x24
    public void /*ctor*/(int <>1__state)
    {
        ZhSegment.Initialize(this,0);
        this.<>1__state = <>1__state;
    }

    // Token : 0x6002217
    // RVA   : 0x245810   Offset: 0x244010   Length: 0x3
    private virtual void System.IDisposable.Dispose()
    {
    }

    // Token : 0x6002218
    // RVA   : 0xB116A0   Offset: 0xB0FEA0   Length: 0xB27
    private virtual bool MoveNext()
    {
        var plVar3 = *(int64*)(lVar3 + 184);
        int iVar1;
        uint uVar2;
        long lVar3;
        long lVar4;
        ulong uVar5;
        ulong uVar6;
        long lVar10;
        uint uVar13;
        float fVar14;
        ulong local_58;
        uint local_50;
        uint local_48;
        uint uStack_44;
        uint uStack_40;
        uint32 uStack_3c;
        lVar3 = this.<>4__this;
        if (this.<>1__state != 0) {
          if (this.<>1__state != 1) {
            return false;
          }
          this.<>1__state = 0xffffffff;
          if (lVar3 != null) {
            uVar13 = 0;
            *(uint64 *)(lVar3 + 120) = 0;
            StudyInternalSkillController.SetCrashingPoint(lVar3,0,0);
            if (*(int64 *)(lVar3 + 72) != 0) {
              GameObject.SetActive(*(int64 *)(lVar3 + 72),0,0);
              if (*(int64 *)(lVar3 + 88) != 0) {
                GameObject.SetActive(*(int64 *)(lVar3 + 88),0,0);
                lVar4 = 32;
                while (lVar10 = plVar3) != null {
                  if ((int)*(uint32 *)(lVar10 + 24) <= (int)uVar13) {
                    FUN_180f56130(lVar10,DAT_181d61c78);
                    if (**(int64 **)(DAT_181d82f70 + 184) != 0) {
                      StudySkillController.FinishStudySkill();
                      return false;
                    }
                    break;
                  }
                  if (*(uint32 *)(lVar10 + 24) <= uVar13) {
                    ThrowHelper.ThrowArgumentOutOfRangeException(0);
                  }
                  lVar10 = *(int64 *)(lVar4 + *(int64 *)(lVar10 + 16));
                  if (lVar10 == null) break;
                  GameObject.SetActive(lVar10,0);
                  uVar13 = uVar13 + 1;
                  lVar4 = lVar4 + 8;
                }
              }
            }
          }
          throw; // [null/range check failed]
        }
        iVar1 = this.studyInternalResult;
        fVar14 = 1.0;
        this.<>1__state = 0xffffffff;
        if (iVar1 == 0) {
          lVar4 = FUN_18046c0a0(0);
          puVar7 = (uint64 *)Vector3.get_zero(&local_58,0);
          uVar5 = *puVar7;
          uVar2 = *(uint32 *)(puVar7 + 1);
          puVar8 = (uint32 *)Color.get_red(&local_48,0);
          if (lVar4 == null) throw; // [null/range check failed]
          local_48 = *puVar8;
          uStack_44 = puVar8[1];
          uStack_40 = puVar8[2];
          uStack_3c = puVar8[3];
          puVar8 = &local_48;
          local_58 = uVar5;
          local_50 = uVar2;
          GameController.ShowTextAtPos(lVar4,"内力耗尽！",&local_58,23,puVar8,0);
          lVar4 = FUN_18046c0a0(0);
          if (((((lVar4 == null) || (*(int64 *)(lVar4 + 32) == 0)) ||
               (lVar4 = WorldData.Player(*(int64 *)(lVar4 + 32),0), lVar3 == null)) ||
              ((*(int64 *)(lVar3 + 40) == 0 ||
               (lVar10 = KungfuSkillLvData.DataBase(*(int64 *)(lVar3 + 40),0)) == null))) ||
             (lVar4 == null)) throw; // [null/range check failed]
          HeroData.ChangeInternalInjury
                    (lVar4,(float)*(int *)(lVar10 + 52) * 5.0 + 5.0,1,0,
                     (uint64)puVar8 & 0xffffffffffffff00,0);
          plVar9 = (int64 *)Resources.Load("Sound/SoundEffect/BigFail",0);
          plVar11 = (int64 *)0;
          if ((plVar9 != (int64 *)0) && (*plVar9 == DAT_181d8a228)) {
            plVar11 = plVar9;
          }
          NGUITools.PlaySound(plVar11,0);
        }
        else {
          plVar9 = (int64 *)0;
          if (iVar1 == 1) {
            lVar4 = FUN_18046c0a0(0);
            puVar7 = (uint64 *)Vector3.get_zero(&local_58,0);
            uVar5 = *puVar7;
            uVar2 = *(uint32 *)(puVar7 + 1);
            puVar8 = (uint32 *)Color.get_yellow(&local_48,0);
            if (lVar4 == null) throw; // [null/range check failed]
            local_48 = *puVar8;
            uStack_44 = puVar8[1];
            uStack_40 = puVar8[2];
            uStack_3c = puVar8[3];
            local_58 = uVar5;
            local_50 = uVar2;
            GameController.ShowTextAtPos(lVar4,"修炼终止！",&local_58,23,&local_48,0);
            plVar11 = (int64 *)Resources.Load("Sound/SoundEffect/Fail",0);
            if ((plVar11 != (int64 *)0) && (*plVar11 == DAT_181d8a228)) {
              plVar9 = plVar11;
            }
            NGUITools.PlaySound(plVar9,0);
          }
          else if (iVar1 == 2) {
            lVar4 = FUN_18046c0a0(0);
            uVar5 = FUN_180004500(DAT_181d63120);
            uVar6 = String.Format("打通周天\n经验+50%",uVar5,0);
            puVar7 = (uint64 *)Vector3.get_zero(&local_58,0);
            uVar5 = *puVar7;
            uVar2 = *(uint32 *)(puVar7 + 1);
            puVar8 = (uint32 *)Color.get_green(&local_48,0);
            if (lVar4 == null) throw; // [null/range check failed]
            local_48 = *puVar8;
            uStack_44 = puVar8[1];
            uStack_40 = puVar8[2];
            uStack_3c = puVar8[3];
            local_58 = uVar5;
            local_50 = uVar2;
            GameController.ShowTextAtPos(lVar4,uVar6,&local_58,23,&local_48,0);
            plVar11 = (int64 *)Resources.Load("Sound/SoundEffect/Success",0);
            if ((plVar11 != (int64 *)0) && (*plVar11 == DAT_181d8a228)) {
              plVar9 = plVar11;
            }
            NGUITools.PlaySound(plVar9,0);
            fVar14 = 1.5;
          }
          else if (iVar1 == 3) {
            lVar4 = FUN_18046c0a0(0);
            uVar5 = FUN_180004500(DAT_181d63120);
            uVar6 = String.Format("打通小周天\n经验+100%",uVar5,0);
            puVar7 = (uint64 *)Vector3.get_zero(&local_58,0);
            uVar5 = *puVar7;
            uVar2 = *(uint32 *)(puVar7 + 1);
            puVar8 = (uint32 *)Color.get_green(&local_48,0);
            if (lVar4 == null) throw; // [null/range check failed]
            local_48 = *puVar8;
            uStack_44 = puVar8[1];
            uStack_40 = puVar8[2];
            uStack_3c = puVar8[3];
            local_58 = uVar5;
            local_50 = uVar2;
            GameController.ShowTextAtPos(lVar4,uVar6,&local_58,24,&local_48,0);
            plVar11 = (int64 *)Resources.Load("Sound/SoundEffect/Success",0);
            if ((plVar11 != (int64 *)0) && (*plVar11 == DAT_181d8a228)) {
              plVar9 = plVar11;
            }
            NGUITools.PlaySound(plVar9,0);
            fVar14 = 2.0;
          }
          else if (iVar1 == 4) {
            lVar4 = FUN_18046c0a0(0);
            uVar5 = FUN_180004500(DAT_181d63120);
            uVar6 = String.Format("打通大周天\n经验+150%",uVar5,0);
            puVar7 = (uint64 *)Vector3.get_zero(&local_58,0);
            uVar5 = *puVar7;
            uVar2 = *(uint32 *)(puVar7 + 1);
            puVar8 = (uint32 *)Color.get_green(&local_48,0);
            if (lVar4 == null) throw; // [null/range check failed]
            local_48 = *puVar8;
            uStack_44 = puVar8[1];
            uStack_40 = puVar8[2];
            uStack_3c = puVar8[3];
            plVar11 = (int64 *)0;
            local_58 = uVar5;
            local_50 = uVar2;
            GameController.ShowTextAtPos(lVar4,uVar6,&local_58,26,&local_48,0);
            plVar9 = (int64 *)Resources.Load("Sound/SoundEffect/BigSuccess",0);
            plVar12 = plVar11;
            if ((plVar9 != (int64 *)0) && (*plVar9 == DAT_181d8a228)) {
              plVar12 = plVar9;
            }
            NGUITools.PlaySound(plVar12,0);
            if ((lVar3 == null) || (*(int64 *)(lVar3 + 40) == 0)) throw; // [null/range check failed]
            if (*(char *)(*(int64 *)(lVar3 + 40) + 109) == false) {
              lVar4 = 32;
              while (lVar10 = plVar3) != null {
                uVar13 = (uint32)plVar11;
                if ((int)*(uint32 *)(lVar10 + 24) <= (int)uVar13) {
                  lVar4 = FUN_18046c0a0(0);
                  if ((lVar4 != null) && (*(int64 *)(lVar4 + 32) != 0)) {
                    lVar4 = WorldData.Player(*(int64 *)(lVar4 + 32),0);
                    if ((*(int64 *)(lVar3 + 40) != 0) &&
                       ((lVar10 = KungfuSkillLvData.DataBase(*(int64 *)(lVar3 + 40),0), lVar10 != null
                        && (lVar4 != null)))) {
                      FUN_1801f7f00(0x40000000);
                      HeroData.ChangeMaxMana(lVar4);
                      if (*(int64 *)(lVar3 + 40) != 0) {
                        *(uint8 *)(*(int64 *)(lVar3 + 40) + 109) = 1;
                        goto LAB_180b11acd;
                      }
                    }
                  }
                  break;
                }
                if (*(uint32 *)(lVar10 + 24) <= uVar13) {
                  ThrowHelper.ThrowArgumentOutOfRangeException(0);
                }
                if ((*(int64 *)(lVar4 + *(int64 *)(lVar10 + 16)) == 0) ||
                   (lVar10 = GameObject.GetComponent()) == null) break;
                if (*(int *)(lVar10 + 52) != 0) {
                  if (((plVar3 == 0) ||
                      (lVar10 = FUN_180002f80(plVar3,plVar11,DAT_181d62178),
                      lVar10 == null)) || (lVar10 = GameObject.GetComponent(lVar10)) == null) break;
                  if (*(char *)(lVar10 + 45) == false) goto LAB_180b11acd;
                }
                plVar11 = (int64 *)(uint64)(uVar13 + 1);
                lVar4 = lVar4 + 8;
              }
              throw; // [null/range check failed]
            }
        LAB_180b11acd:
            fVar14 = 2.5;
            goto LAB_180b11f01;
          }
          if (lVar3 == null) throw; // [null/range check failed]
        }
        LAB_180b11f01:
        *(float *)(lVar3 + 28) = fVar14 * *(float *)(lVar3 + 28);
        if (((*(int64 *)(lVar3 + 88) != 0) &&
            (lVar4 = GameObject.get_transform(*(int64 *)(lVar3 + 88),0)) != null) &&
           (lVar4 = Transform.Find(lVar4,"Exp",0)) != null) {
          uVar5 = Component.GetComponent(lVar4,DAT_181d6d8c0);
          uVar6 = Single.ToString(lVar3 + 28,"f0",0);
          uVar6 = String.Concat("经验 ",uVar6,0);
          LTLocalization.SetText(uVar5,uVar6,0);
          if ((*(int64 *)(lVar3 + 88) != 0) &&
             (lVar4 = GameObject.get_transform(*(int64 *)(lVar3 + 88),0)) != null) {
            uVar5 = Transform.Find(lVar4,"Exp",0);
            uVar5 = ShortcutExtensions.DOScale(uVar5);
            TweenSettingsExtensions.SetLoops(uVar5,2,1,DAT_181d98060);
            *(uint16 *)(lVar3 + 128) = 0;
            *(uint8 *)(lVar3 + 24) = 0;
            *(uint32 *)(lVar3 + 192) = 0;
            uVar5 = new WaitForSecondsRealtime();
            this.<>2__current = uVar5;
            this.<>1__state = 1;
            return true;
          }
        }
    }

    // Token : 0x6002219
    // RVA   : 0x20F140   Offset: 0x20D940   Length: 0x5
    private virtual object System.Collections.Generic.IEnumerator<System.object>.get_Current()
    {
        return this.<>2__current;
    }

    // Token : 0x600221A
    // RVA   : 0xB121D0   Offset: 0xB109D0   Length: 0x3E
    private virtual void System.Collections.IEnumerator.Reset()
    {
        ulong uVar1;
        ulong uVar2;
        uVar1 = il2cpp_runtime_class_init(&DAT_181d682e8);
        uVar1 = il2cpp_internal(uVar1);
        NotSupportedException.ctor(uVar1,0);
        uVar2 = il2cpp_runtime_class_init(&DAT_181d8b990);
    }

    // Token : 0x600221B
    // RVA   : 0x20F140   Offset: 0x20D940   Length: 0x5
    private virtual object System.Collections.IEnumerator.get_Current()
    {
        return this.<>2__current;
    }

}
