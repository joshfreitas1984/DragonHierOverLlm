// ============================================================
// Type  : <FinishStudyUniqueSkill>d__34
// Token : 0x200038F
// ============================================================

public class <FinishStudyUniqueSkill>d__34
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001C54
    private int <>1__state;

    // Token: 0x4001C55
    private object <>2__current;

    // Token: 0x4001C56
    public StudyUniqueSkillController <>4__this;

    // Token: 0x4001C57
    public StudySkillResult studyUniqueResult;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6002244
    // RVA   : 0x219070   Offset: 0x217870   Length: 0x24
    public void /*ctor*/(int <>1__state)
    {
        ZhSegment.Initialize(this,0);
        this.<>1__state = <>1__state;
    }

    // Token : 0x6002245
    // RVA   : 0x245810   Offset: 0x244010   Length: 0x3
    private virtual void System.IDisposable.Dispose()
    {
    }

    // Token : 0x6002246
    // RVA   : 0xB12210   Offset: 0xB10A10   Length: 0x692
    private virtual bool MoveNext()
    {
        int iVar1;
        uint uVar2;
        long lVar3;
        long lVar6;
        ulong uVar7;
        long lVar8;
        ulong local_38;
        uint local_30;
        uint local_28;
        uint uStack_24;
        uint uStack_20;
        uint32 uStack_1c;
        lVar8 = this.<>4__this;
        if (this.<>1__state == 0) {
          this.<>1__state = 0xffffffff;
          if (lVar8 != null) {
            if (*(char *)(lVar8 + 25) != false) {
              return false;
            }
            *(uint8 *)(lVar8 + 25) = 1;
            iVar1 = this.studyUniqueResult;
            if (iVar1 == 0) {
              lVar3 = FUN_18046c0a0(0);
              puVar4 = (uint64 *)Vector3.get_zero(&local_38,0);
              uVar7 = *puVar4;
              uVar2 = *(uint32 *)(puVar4 + 1);
              puVar5 = (uint32 *)Color.get_red(&local_28,0);
              if (lVar3 == null) throw; // [null/range check failed]
              local_28 = *puVar5;
              uStack_24 = puVar5[1];
              uStack_20 = puVar5[2];
              uStack_1c = puVar5[3];
              puVar5 = &local_28;
              local_38 = uVar7;
              local_30 = uVar2;
              GameController.ShowTextAtPos(lVar3,"生命耗尽！",&local_38,25,puVar5,0);
              lVar3 = FUN_18046c0a0(0);
              if ((lVar3 == null) || (*(int64 *)(lVar3 + 32) == 0)) throw; // [null/range check failed]
              lVar3 = WorldData.Player(*(int64 *)(lVar3 + 32),0);
              if ((*(int64 *)(lVar8 + 64) == 0) ||
                 ((lVar6 = KungfuSkillLvData.DataBase(*(int64 *)(lVar8 + 64),0), lVar6 == null ||
                  (lVar3 == null)))) throw; // [null/range check failed]
              HeroData.ChangeExternalInjury
                        (lVar3,(float)*(int *)(lVar6 + 52) * 5.0 + 5.0,1,0,
                         (uint64)puVar5 & 0xffffffffffffff00,0);
            }
            else if (iVar1 == 1) {
              lVar3 = FUN_18046c0a0(0);
              puVar4 = (uint64 *)Vector3.get_zero(&local_38,0);
              uVar7 = *puVar4;
              uVar2 = *(uint32 *)(puVar4 + 1);
              puVar5 = (uint32 *)Color.get_yellow(&local_28,0);
              if (lVar3 == null) throw; // [null/range check failed]
              local_28 = *puVar5;
              uStack_24 = puVar5[1];
              uStack_20 = puVar5[2];
              uStack_1c = puVar5[3];
              local_38 = uVar7;
              local_30 = uVar2;
              GameController.ShowTextAtPos(lVar3,"修炼终止！",&local_38,25,&local_28,0);
            }
            else if (iVar1 == 2) {
              iVar1 = *(int *)(lVar8 + 36);
              if (iVar1 < 1) {
                lVar3 = FUN_18046c0a0(0);
                puVar4 = (uint64 *)Vector3.get_zero(&local_38,0);
                uVar7 = *puVar4;
                uVar2 = *(uint32 *)(puVar4 + 1);
                puVar5 = (uint32 *)Color.get_green(&local_28,0);
                if (lVar3 == null) throw; // [null/range check failed]
                local_28 = *puVar5;
                uStack_24 = puVar5[1];
                uStack_20 = puVar5[2];
                uStack_1c = puVar5[3];
                local_38 = uVar7;
                local_30 = uVar2;
                GameController.ShowTextAtPos(lVar3,"表现完美！",&local_38,27,&local_28,0);
              }
              else if (iVar1 < 3) {
                lVar3 = FUN_18046c0a0(0);
                puVar4 = (uint64 *)Vector3.get_zero(&local_38,0);
                uVar7 = *puVar4;
                uVar2 = *(uint32 *)(puVar4 + 1);
                puVar5 = (uint32 *)Color.get_green(&local_28,0);
                if (lVar3 == null) throw; // [null/range check failed]
                local_28 = *puVar5;
                uStack_24 = puVar5[1];
                uStack_20 = puVar5[2];
                uStack_1c = puVar5[3];
                local_38 = uVar7;
                local_30 = uVar2;
                GameController.ShowTextAtPos(lVar3,"表现优秀！",&local_38,26,&local_28,0);
              }
              else if (iVar1 < 5) {
                lVar3 = FUN_18046c0a0(0);
                puVar4 = (uint64 *)Vector3.get_zero(&local_38,0);
                uVar7 = *puVar4;
                uVar2 = *(uint32 *)(puVar4 + 1);
                puVar5 = (uint32 *)Color.get_green(&local_28,0);
                if (lVar3 == null) throw; // [null/range check failed]
                local_28 = *puVar5;
                uStack_24 = puVar5[1];
                uStack_20 = puVar5[2];
                uStack_1c = puVar5[3];
                local_38 = uVar7;
                local_30 = uVar2;
                GameController.ShowTextAtPos(lVar3,"表现尚可！",&local_38,25,&local_28,0);
              }
              else if (iVar1 < 7) {
                lVar3 = FUN_18046c0a0(0);
                puVar4 = (uint64 *)Vector3.get_zero(&local_38,0);
                uVar7 = *puVar4;
                uVar2 = *(uint32 *)(puVar4 + 1);
                puVar5 = (uint32 *)Color.get_green(&local_28,0);
                if (lVar3 == null) throw; // [null/range check failed]
                local_28 = *puVar5;
                uStack_24 = puVar5[1];
                uStack_20 = puVar5[2];
                uStack_1c = puVar5[3];
                local_38 = uVar7;
                local_30 = uVar2;
                GameController.ShowTextAtPos(lVar3,"表现平平！",&local_38,25,&local_28,0);
              }
              else {
                lVar3 = FUN_18046c0a0(0);
                puVar4 = (uint64 *)Vector3.get_zero(&local_38,0);
                uVar7 = *puVar4;
                uVar2 = *(uint32 *)(puVar4 + 1);
                puVar5 = (uint32 *)Color.get_green(&local_28,0);
                if (lVar3 == null) throw; // [null/range check failed]
                local_28 = *puVar5;
                uStack_24 = puVar5[1];
                uStack_20 = puVar5[2];
                uStack_1c = puVar5[3];
                local_38 = uVar7;
                local_30 = uVar2;
                GameController.ShowTextAtPos(lVar3,"表现不佳！",&local_38,25,&local_28,0);
              }
            }
            uVar7 = *(uint64 *)(lVar8 + 96);
            GlobalData.DeleteAllChild(uVar7,0);
            if (**(int64 **)(DAT_181d82ff0 + 184) != 0) {
              StudyUniquePlayer.SetShieldTime();
              uVar7 = new WaitForSecondsRealtime();
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
          if (lVar8 != null) {
            *(uint16 *)(lVar8 + 24) = 0;
            if (*(int64 *)(lVar8 + 72) != 0) {
              GameObject.SetActive(*(int64 *)(lVar8 + 72),0,0);
              if (*(int64 *)(lVar8 + 80) != 0) {
                GameObject.SetActive(*(int64 *)(lVar8 + 80),0,0);
                lVar8 = FUN_18046c660(0);
                if (lVar8 != null) {
                  StudySkillController.FinishStudySkill(lVar8);
                  return false;
                }
              }
            }
          }
        }
    }

    // Token : 0x6002247
    // RVA   : 0x20F140   Offset: 0x20D940   Length: 0x5
    private virtual object System.Collections.Generic.IEnumerator<System.object>.get_Current()
    {
        return this.<>2__current;
    }

    // Token : 0x6002248
    // RVA   : 0xB128B0   Offset: 0xB110B0   Length: 0x3E
    private virtual void System.Collections.IEnumerator.Reset()
    {
        ulong uVar1;
        ulong uVar2;
        uVar1 = il2cpp_runtime_class_init(&DAT_181d682e8);
        uVar1 = il2cpp_internal(uVar1);
        NotSupportedException.ctor(uVar1,0);
        uVar2 = il2cpp_runtime_class_init(&DAT_181d8ba90);
    }

    // Token : 0x6002249
    // RVA   : 0x20F140   Offset: 0x20D940   Length: 0x5
    private virtual object System.Collections.IEnumerator.get_Current()
    {
        return this.<>2__current;
    }

}
