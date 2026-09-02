// ============================================================
// Type  : <FinishStudyFightSkill>d__28
// Token : 0x2000373
// ============================================================

public class <FinishStudyFightSkill>d__28
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001B76
    private int <>1__state;

    // Token: 0x4001B77
    private object <>2__current;

    // Token: 0x4001B78
    public StudyAttackSkillController <>4__this;

    // Token: 0x4001B79
    public StudySkillResult studyDodgeResult;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60021A3
    // RVA   : 0x219070   Offset: 0x217870   Length: 0x24
    public void /*ctor*/(int <>1__state)
    {
        ZhSegment.Initialize(this,0);
        this.<>1__state = <>1__state;
    }

    // Token : 0x60021A4
    // RVA   : 0x245810   Offset: 0x244010   Length: 0x3
    private virtual void System.IDisposable.Dispose()
    {
    }

    // Token : 0x60021A5
    // RVA   : 0xB11080   Offset: 0xB0F880   Length: 0x5D7
    private virtual bool MoveNext()
    {
        int iVar1;
        long lVar2;
        long lVar3;
        long lVar6;
        ulong uVar7;
        ulong uVar8;
        uint uVar9;
        uint uVar10;
        uint uVar11;
        ulong local_38;
        uint local_30;
        uint local_28;
        uint uStack_24;
        uint uStack_20;
        uint32 uStack_1c;
        lVar6 = this.<>4__this;
        if (this.<>1__state != 0) {
          if (this.<>1__state != 1) {
            return false;
          }
          this.<>1__state = 0xffffffff;
          if (lVar6 != null) {
            *(uint16 *)(lVar6 + 24) = 0;
            if (*(int64 *)(lVar6 + 64) != 0) {
              GameObject.SetActive(*(int64 *)(lVar6 + 64),0,0);
              lVar2 = FUN_18046c660(0);
              if (lVar2 != null) {
                StudySkillController.FinishStudySkill(lVar2,*(uint32 *)(lVar6 + 28),0);
                return false;
              }
            }
          }
          throw; // [null/range check failed]
        }
        this.<>1__state = 0xffffffff;
        if (lVar6 == null) throw; // [null/range check failed]
        if (*(char *)(lVar6 + 25) != false) {
          return false;
        }
        *(uint8 *)(lVar6 + 25) = 1;
        iVar1 = this.studyDodgeResult;
        if (iVar1 == 0) {
          lVar2 = FUN_18046c0a0(0);
          if ((*(int64 *)(lVar6 + 80) == 0) ||
             (lVar3 = GameObject.get_transform(*(int64 *)(lVar6 + 80),0)) == null)
          throw; // [null/range check failed]
          puVar4 = (uint64 *)Transform.get_position(&local_38,lVar3,0);
          uVar10 = (uint32)*puVar4;
          uVar11 = (uint32)((uint64)*puVar4 >> 32);
          uVar9 = *(uint32 *)(puVar4 + 1);
          puVar5 = (uint32 *)Color.get_red(&local_28,0);
          uVar7 = "生命耗尽！";
        joined_r0x000180b114f2:
          if (lVar2 == null) throw; // [null/range check failed]
          uVar8 = 25;
        LAB_180b11505:
          local_28 = *puVar5;
          uStack_24 = puVar5[1];
          uStack_20 = puVar5[2];
          uStack_1c = puVar5[3];
          local_38 = CONCAT44(uVar11,uVar10);
          local_30 = uVar9;
          GameController.ShowTextAtPos(lVar2,uVar7,&local_38,uVar8,&local_28,0);
        }
        else {
          if (iVar1 == 1) {
            lVar2 = FUN_18046c0a0(0);
            if ((*(int64 *)(lVar6 + 80) == 0) ||
               (lVar3 = GameObject.get_transform(*(int64 *)(lVar6 + 80),0)) == null)
            throw; // [null/range check failed]
            puVar4 = (uint64 *)Transform.get_position(&local_38,lVar3,0);
            uVar10 = (uint32)*puVar4;
            uVar11 = (uint32)((uint64)*puVar4 >> 32);
            uVar9 = *(uint32 *)(puVar4 + 1);
            puVar5 = (uint32 *)Color.get_yellow(&local_28,0);
            uVar7 = "修炼终止！";
            goto joined_r0x000180b114f2;
          }
          if (iVar1 == 2) {
            iVar1 = *(int *)(lVar6 + 36);
            if (iVar1 < 1) {
              lVar2 = FUN_18046c0a0(0);
              if ((*(int64 *)(lVar6 + 80) == 0) ||
                 (lVar3 = GameObject.get_transform(*(int64 *)(lVar6 + 80),0)) == null)
              throw; // [null/range check failed]
              puVar4 = (uint64 *)Transform.get_position(&local_38,lVar3,0);
              uVar10 = (uint32)*puVar4;
              uVar11 = (uint32)((uint64)*puVar4 >> 32);
              uVar9 = *(uint32 *)(puVar4 + 1);
              puVar5 = (uint32 *)Color.get_green(&local_28,0);
              if (lVar2 == null) throw; // [null/range check failed]
              uVar8 = 27;
              uVar7 = "表现完美！";
            }
            else {
              if (2 < iVar1) {
                if (iVar1 < 5) {
                  lVar2 = FUN_18046c0a0(0);
                  if ((*(int64 *)(lVar6 + 80) == 0) ||
                     (lVar3 = GameObject.get_transform(*(int64 *)(lVar6 + 80),0)) == null)
                  throw; // [null/range check failed]
                  puVar4 = (uint64 *)Transform.get_position(&local_38,lVar3,0);
                  uVar10 = (uint32)*puVar4;
                  uVar11 = (uint32)((uint64)*puVar4 >> 32);
                  uVar9 = *(uint32 *)(puVar4 + 1);
                  puVar5 = (uint32 *)Color.get_green(&local_28,0);
                  uVar7 = "表现尚可！";
                }
                else if (iVar1 < 7) {
                  lVar2 = FUN_18046c0a0(0);
                  if ((*(int64 *)(lVar6 + 80) == 0) ||
                     (lVar3 = GameObject.get_transform(*(int64 *)(lVar6 + 80),0)) == null)
                  throw; // [null/range check failed]
                  puVar4 = (uint64 *)Transform.get_position(&local_38,lVar3,0);
                  uVar10 = (uint32)*puVar4;
                  uVar11 = (uint32)((uint64)*puVar4 >> 32);
                  uVar9 = *(uint32 *)(puVar4 + 1);
                  puVar5 = (uint32 *)Color.get_green(&local_28,0);
                  uVar7 = "表现平平！";
                }
                else {
                  lVar2 = FUN_18046c0a0(0);
                  if ((*(int64 *)(lVar6 + 80) == 0) ||
                     (lVar3 = GameObject.get_transform(*(int64 *)(lVar6 + 80),0)) == null)
                  throw; // [null/range check failed]
                  puVar4 = (uint64 *)Transform.get_position(&local_38,lVar3,0);
                  uVar10 = (uint32)*puVar4;
                  uVar11 = (uint32)((uint64)*puVar4 >> 32);
                  uVar9 = *(uint32 *)(puVar4 + 1);
                  puVar5 = (uint32 *)Color.get_green(&local_28,0);
                  uVar7 = "表现不佳！";
                }
                goto joined_r0x000180b114f2;
              }
              lVar2 = FUN_18046c0a0(0);
              if ((*(int64 *)(lVar6 + 80) == 0) ||
                 (lVar3 = GameObject.get_transform(*(int64 *)(lVar6 + 80),0)) == null)
              throw; // [null/range check failed]
              puVar4 = (uint64 *)Transform.get_position(&local_38,lVar3,0);
              uVar10 = (uint32)*puVar4;
              uVar11 = (uint32)((uint64)*puVar4 >> 32);
              uVar9 = *(uint32 *)(puVar4 + 1);
              puVar5 = (uint32 *)Color.get_green(&local_28,0);
              if (lVar2 == null) throw; // [null/range check failed]
              uVar8 = 26;
              uVar7 = "表现优秀！";
            }
            goto LAB_180b11505;
          }
        }
        uVar7 = *(uint64 *)(lVar6 + 72);
        GlobalData.DeleteAllChild(uVar7,0);
        if ((*(int64 *)(lVar6 + 80) != 0) &&
           (lVar6 = GameObject.GetComponent(*(int64 *)(lVar6 + 80),DAT_181da1ab0)) != null) {
          StudyAttackPlayer.SetShieldTime(lVar6,0,0);
          uVar7 = new WaitForSecondsRealtime(0x40400000,0);
          this.<>2__current = uVar7;
          this.<>1__state = 1;
          return true;
        }
    }

    // Token : 0x60021A6
    // RVA   : 0x20F140   Offset: 0x20D940   Length: 0x5
    private virtual object System.Collections.Generic.IEnumerator<System.object>.get_Current()
    {
        return this.<>2__current;
    }

    // Token : 0x60021A7
    // RVA   : 0xB11660   Offset: 0xB0FE60   Length: 0x3E
    private virtual void System.Collections.IEnumerator.Reset()
    {
        ulong uVar1;
        ulong uVar2;
        uVar1 = il2cpp_runtime_class_init(&DAT_181d682e8);
        uVar1 = il2cpp_internal(uVar1);
        NotSupportedException.ctor(uVar1,0);
        uVar2 = il2cpp_runtime_class_init(&DAT_181d8b590);
    }

    // Token : 0x60021A8
    // RVA   : 0x20F140   Offset: 0x20D940   Length: 0x5
    private virtual object System.Collections.IEnumerator.get_Current()
    {
        return this.<>2__current;
    }

}
