// ============================================================
// Type  : <FinishStudyDodgeSkill>d__40
// Token : 0x200037A
// ============================================================

public class <FinishStudyDodgeSkill>d__40
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001BAC
    private int <>1__state;

    // Token: 0x4001BAD
    private object <>2__current;

    // Token: 0x4001BAE
    public StudyDodgeSkillController <>4__this;

    // Token: 0x4001BAF
    public StudySkillResult studyDodgeResult;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60021D1
    // RVA   : 0x219070   Offset: 0x217870   Length: 0x24
    public void /*ctor*/(int <>1__state)
    {
        ZhSegment.Initialize(this,0);
        this.<>1__state = <>1__state;
    }

    // Token : 0x60021D2
    // RVA   : 0x245810   Offset: 0x244010   Length: 0x3
    private virtual void System.IDisposable.Dispose()
    {
    }

    // Token : 0x60021D3
    // RVA   : 0xB10670   Offset: 0xB0EE70   Length: 0x9CA
    private virtual bool MoveNext()
    {
        int iVar1;
        uint uVar2;
        long lVar3;
        long lVar4;
        long lVar5;
        ulong uVar8;
        uint uVar9;
        ulong uVar10;
        ulong local_48;
        uint local_40;
        uint local_38;
        uint uStack_34;
        uint uStack_30;
        uint32 uStack_2c;
        lVar3 = this.<>4__this;
        if (this.<>1__state == 0) {
          this.<>1__state = 0xffffffff;
          if (lVar3 != null) {
            if (*(char *)(lVar3 + 25) != false) {
              return false;
            }
            *(uint8 *)(lVar3 + 25) = 1;
            uVar9 = 0;
            iVar1 = this.studyDodgeResult;
            if (iVar1 == 0) {
              lVar4 = FUN_18046c0a0(0);
              lVar5 = FUN_180b04900(0);
              if ((lVar5 == null) || (lVar5 = Component.get_transform(lVar5,0)) == null)
              throw; // [null/range check failed]
              puVar6 = (uint64 *)Transform.get_position(&local_48,lVar5,0);
              uVar8 = *puVar6;
              uVar2 = *(uint32 *)(puVar6 + 1);
              puVar7 = (uint32 *)Color.get_red(&local_38,0);
              if (lVar4 == null) throw; // [null/range check failed]
              local_38 = *puVar7;
              uStack_34 = puVar7[1];
              uStack_30 = puVar7[2];
              uStack_2c = puVar7[3];
              puVar7 = &local_38;
              local_48 = uVar8;
              local_40 = uVar2;
              GameController.ShowTextAtPos(lVar4,"生命耗尽！",&local_48,25,puVar7,0);
              lVar4 = FUN_18046c0a0(0);
              if ((lVar4 == null) || (*(int64 *)(lVar4 + 32) == 0)) throw; // [null/range check failed]
              lVar4 = WorldData.Player(*(int64 *)(lVar4 + 32),0);
              if ((*(int64 *)(lVar3 + 56) == 0) ||
                 ((lVar5 = KungfuSkillLvData.DataBase(*(int64 *)(lVar3 + 56),0), lVar5 == null ||
                  (lVar4 == null)))) throw; // [null/range check failed]
              uVar10 = (uint64)puVar7 & 0xffffffffffffff00;
              HeroData.ChangeExternalInjury(lVar4,(float)*(int *)(lVar5 + 52) * 2.5 + 2.5,1,0,uVar10,0)
              ;
              lVar4 = FUN_18046c0a0(0);
              if ((lVar4 == null) || (*(int64 *)(lVar4 + 32) == 0)) throw; // [null/range check failed]
              lVar4 = WorldData.Player(*(int64 *)(lVar4 + 32),0);
              if (((*(int64 *)(lVar3 + 56) == 0) ||
                  (lVar5 = KungfuSkillLvData.DataBase(*(int64 *)(lVar3 + 56),0)) == null) ||
                 (lVar4 == null)) throw; // [null/range check failed]
              HeroData.ChangeInternalInjury
                        (lVar4,(float)*(int *)(lVar5 + 52) * 2.5 + 2.5,1,0,uVar10 & 0xffffffffffffff00,0
                        );
            }
            else if (iVar1 == 1) {
              lVar4 = FUN_18046c0a0(0);
              lVar5 = FUN_180b04900(0);
              if ((lVar5 == null) || (lVar5 = Component.get_transform(lVar5,0)) == null)
              throw; // [null/range check failed]
              puVar6 = (uint64 *)Transform.get_position(&local_48,lVar5,0);
              uVar8 = *puVar6;
              uVar2 = *(uint32 *)(puVar6 + 1);
              puVar7 = (uint32 *)Color.get_yellow(&local_38,0);
              if (lVar4 == null) throw; // [null/range check failed]
              local_38 = *puVar7;
              uStack_34 = puVar7[1];
              uStack_30 = puVar7[2];
              uStack_2c = puVar7[3];
              local_48 = uVar8;
              local_40 = uVar2;
              GameController.ShowTextAtPos(lVar4,"修炼终止！",&local_48,25,&local_38,0);
            }
            else if (iVar1 == 2) {
              iVar1 = *(int *)(lVar3 + 84);
              if (iVar1 < 1) {
                lVar4 = FUN_18046c0a0(0);
                lVar5 = FUN_180b04900(0);
                if ((lVar5 == null) || (lVar5 = Component.get_transform(lVar5,0)) == null)
                throw; // [null/range check failed]
                puVar6 = (uint64 *)Transform.get_position(&local_48,lVar5,0);
                uVar8 = *puVar6;
                uVar2 = *(uint32 *)(puVar6 + 1);
                puVar7 = (uint32 *)Color.get_green(&local_38,0);
                if (lVar4 == null) throw; // [null/range check failed]
                local_38 = *puVar7;
                uStack_34 = puVar7[1];
                uStack_30 = puVar7[2];
                uStack_2c = puVar7[3];
                local_48 = uVar8;
                local_40 = uVar2;
                GameController.ShowTextAtPos(lVar4,"表现完美！",&local_48,27,&local_38,0);
              }
              else if (iVar1 < 3) {
                lVar4 = FUN_18046c0a0(0);
                lVar5 = FUN_180b04900(0);
                if ((lVar5 == null) || (lVar5 = Component.get_transform(lVar5,0)) == null)
                throw; // [null/range check failed]
                puVar6 = (uint64 *)Transform.get_position(&local_48,lVar5,0);
                uVar8 = *puVar6;
                uVar2 = *(uint32 *)(puVar6 + 1);
                puVar7 = (uint32 *)Color.get_green(&local_38,0);
                if (lVar4 == null) throw; // [null/range check failed]
                local_38 = *puVar7;
                uStack_34 = puVar7[1];
                uStack_30 = puVar7[2];
                uStack_2c = puVar7[3];
                local_48 = uVar8;
                local_40 = uVar2;
                GameController.ShowTextAtPos(lVar4,"表现优秀！",&local_48,26,&local_38,0);
              }
              else if (iVar1 < 5) {
                lVar4 = FUN_18046c0a0(0);
                lVar5 = FUN_180b04900(0);
                if ((lVar5 == null) || (lVar5 = Component.get_transform(lVar5,0)) == null)
                throw; // [null/range check failed]
                puVar6 = (uint64 *)Transform.get_position(&local_48,lVar5,0);
                uVar8 = *puVar6;
                uVar2 = *(uint32 *)(puVar6 + 1);
                puVar7 = (uint32 *)Color.get_green(&local_38,0);
                if (lVar4 == null) throw; // [null/range check failed]
                local_38 = *puVar7;
                uStack_34 = puVar7[1];
                uStack_30 = puVar7[2];
                uStack_2c = puVar7[3];
                local_48 = uVar8;
                local_40 = uVar2;
                GameController.ShowTextAtPos(lVar4,"表现尚可！",&local_48,25,&local_38,0);
              }
              else if (iVar1 < 7) {
                lVar4 = FUN_18046c0a0(0);
                lVar5 = FUN_180b04900(0);
                if ((lVar5 == null) || (lVar5 = Component.get_transform(lVar5,0)) == null)
                throw; // [null/range check failed]
                puVar6 = (uint64 *)Transform.get_position(&local_48,lVar5,0);
                uVar8 = *puVar6;
                uVar2 = *(uint32 *)(puVar6 + 1);
                puVar7 = (uint32 *)Color.get_green(&local_38,0);
                if (lVar4 == null) throw; // [null/range check failed]
                local_38 = *puVar7;
                uStack_34 = puVar7[1];
                uStack_30 = puVar7[2];
                uStack_2c = puVar7[3];
                local_48 = uVar8;
                local_40 = uVar2;
                GameController.ShowTextAtPos(lVar4,"表现平平！",&local_48,25,&local_38,0);
              }
              else {
                lVar4 = FUN_18046c0a0(0);
                lVar5 = FUN_180b04900(0);
                if ((lVar5 == null) || (lVar5 = Component.get_transform(lVar5,0)) == null)
                throw; // [null/range check failed]
                puVar6 = (uint64 *)Transform.get_position(&local_48,lVar5,0);
                uVar8 = *puVar6;
                uVar2 = *(uint32 *)(puVar6 + 1);
                puVar7 = (uint32 *)Color.get_green(&local_38,0);
                if (lVar4 == null) throw; // [null/range check failed]
                local_38 = *puVar7;
                uStack_34 = puVar7[1];
                uStack_30 = puVar7[2];
                uStack_2c = puVar7[3];
                local_48 = uVar8;
                local_40 = uVar2;
                GameController.ShowTextAtPos(lVar4,"表现不佳！",&local_48,25,&local_38,0);
              }
            }
            uVar8 = *(uint64 *)(lVar3 + 112);
            GlobalData.DestroyAll(uVar8,0);
            if (**(int64 **)(DAT_181d82df0 + 184) != 0) {
              StudyDodgePlayer.SetShieldTime();
              lVar4 = 32;
              while (lVar5 = *(int64 *)(lVar3 + 104)) != null {
                if ((int)*(uint32 *)(lVar5 + 24) <= (int)uVar9) {
                  uVar8 = new WaitForSecondsRealtime();
                  this.<>2__current = uVar8;
                  this.<>1__state = 1;
                  return true;
                }
                if (*(uint32 *)(lVar5 + 24) <= uVar9) {
                  ThrowHelper.ThrowArgumentOutOfRangeException(0);
                }
                lVar5 = *(int64 *)(lVar4 + *(int64 *)(lVar5 + 16));
                if ((lVar5 == null) || (lVar5 = GameObject.GetComponent(lVar5,DAT_181da1bb0)) == null)
                break;
                *(uint8 *)(lVar5 + 32) = 0;
                lVar5 = *(int64 *)(lVar3 + 104);
                if (lVar5 == null) break;
                if (*(uint32 *)(lVar5 + 24) <= uVar9) {
                  ThrowHelper.ThrowArgumentOutOfRangeException(0);
                }
                lVar5 = *(int64 *)(lVar4 + *(int64 *)(lVar5 + 16));
                if ((lVar5 == null) || (lVar5 = GameObject.GetComponent(lVar5,DAT_181da1bb0)) == null)
                break;
                uVar9 = uVar9 + 1;
                *(uint8 *)(lVar5 + 44) = 0;
                lVar4 = lVar4 + 8;
              }
            }
          }
        }
        else {
          if (this.<>1__state != 1) {
            return false;
          }
          this.<>1__state = 0xffffffff;
          if (lVar3 != null) {
            *(uint16 *)(lVar3 + 24) = 0;
            if (*(int64 *)(lVar3 + 32) != 0) {
              GameObject.SetActive(*(int64 *)(lVar3 + 32),0,0);
              if (*(int64 *)(lVar3 + 40) != 0) {
                GameObject.SetActive(*(int64 *)(lVar3 + 40),0,0);
                uVar9 = 0;
                lVar4 = 32;
                while (lVar5 = *(int64 *)(lVar3 + 152)) != null {
                  if ((int)*(uint32 *)(lVar5 + 24) <= (int)uVar9) {
                    FUN_180f56130(lVar5,DAT_181d61c78);
                    if (**(int64 **)(DAT_181d82f70 + 184) != 0) {
                      StudySkillController.FinishStudySkill();
                      return false;
                    }
                    break;
                  }
                  if (*(uint32 *)(lVar5 + 24) <= uVar9) {
                    ThrowHelper.ThrowArgumentOutOfRangeException(0);
                  }
                  lVar5 = *(int64 *)(lVar4 + *(int64 *)(lVar5 + 16));
                  if (lVar5 == null) break;
                  GameObject.SetActive(lVar5,0);
                  uVar9 = uVar9 + 1;
                  lVar4 = lVar4 + 8;
                }
              }
            }
          }
        }
    }

    // Token : 0x60021D4
    // RVA   : 0x20F140   Offset: 0x20D940   Length: 0x5
    private virtual object System.Collections.Generic.IEnumerator<System.object>.get_Current()
    {
        return this.<>2__current;
    }

    // Token : 0x60021D5
    // RVA   : 0xB11040   Offset: 0xB0F840   Length: 0x3E
    private virtual void System.Collections.IEnumerator.Reset()
    {
        ulong uVar1;
        ulong uVar2;
        uVar1 = il2cpp_runtime_class_init(&DAT_181d682e8);
        uVar1 = il2cpp_internal(uVar1);
        NotSupportedException.ctor(uVar1,0);
        uVar2 = il2cpp_runtime_class_init(&DAT_181d8b790);
    }

    // Token : 0x60021D6
    // RVA   : 0x20F140   Offset: 0x20D940   Length: 0x5
    private virtual object System.Collections.IEnumerator.get_Current()
    {
        return this.<>2__current;
    }

}
