// ============================================================
// Type  : ActiveAnimation
// Token : 0x2000075
// ============================================================

public class ActiveAnimation
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x40002C3
    public static ActiveAnimation current;

    // Token: 0x40002C4
    public List<EventDelegate> onFinished;

    // Token: 0x40002C5
    public GameObject eventReceiver;

    // Token: 0x40002C6
    public string callWhenFinished;

    // Token: 0x40002C7
    private Animation mAnim;

    // Token: 0x40002C8
    private Direction mLastDirection;

    // Token: 0x40002C9
    private Direction mDisableDirection;

    // Token: 0x40002CA
    private bool mNotify;

    // Token: 0x40002CB
    private Animator mAnimator;

    // Token: 0x40002CC
    private string mClip;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60002A7
    // RVA   : 0xA0C890   Offset: 0xA0B090   Length: 0x52
    private float get_playbackTime()
    {
        uint uVar2;
        uint local_58;
        uint uStack_54;
        uint uStack_50;
        uint32 uStack_4c;
        uint32 local_48;
        uint32 uStack_44;
        uint32 uStack_40;
        uint32 uStack_3c;
        uint32 local_38;
        uint8 local_30 [48];
        if (this.mAnimator != null) {
          puVar1 = (uint32 *)
                   Animator.GetCurrentAnimatorStateInfo(local_30,this.mAnimator,0,0);
          local_58 = *puVar1;
          uStack_54 = puVar1[1];
          uStack_50 = puVar1[2];
          uStack_4c = puVar1[3];
          local_48 = puVar1[4];
          uStack_44 = puVar1[5];
          uStack_40 = puVar1[6];
          uStack_3c = puVar1[7];
          local_38 = puVar1[8];
          uVar2 = FUN_18044e2b0(&local_58,0);
          Mathf.Clamp01(uVar2,0);
          return;
        }
    }

    // Token : 0x60002A8
    // RVA   : 0xA0C510   Offset: 0xA0AD10   Length: 0x37A
    public bool get_isPlaying()
    {
        long lVar1;
        int iVar2;
        bool cVar3;
        long lVar4;
        ulong uVar6;
        byte uVar9;
        float fVar11;
        float fVar12;
        float extraout_XMM0_Da;
        uint32 uVar13;
        float extraout_XMM0_Da_00;
        int local_a0 [4];
        int local_90;
        int iStack_8c;
        int iStack_88;
        int iStack_84;
        int local_80;
        uint8 local_78 [80];
        uVar9 = 0;
        local_90 = 0;
        uVar6 = this.mAnim;
        cVar3 = Object.op_Equality(uVar6,0,0);
        if (!cVar3) {
          if (this.mAnim == null) {
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          lVar4 = Animation.GetEnumerator(this.mAnim,0);
          do {
            while( true ) {
              do {
                if (lVar4 == null) {
                          // WARNING: Subroutine does not return
                  FUN_1800d6620();
                }
                cVar3 = FUN_180002970(0,DAT_181d544d8,lVar4);
                if (!cVar3) {
                  local_a0[0] = 200;
                  local_90 = local_90 + 1;
                  goto LAB_180a0c743;
                }
                plVar5 = (int64 *)FUN_180002970(1,DAT_181d544d8,lVar4);
                if (plVar5 == (int64 *)0) {
                          // WARNING: Subroutine does not return
                  FUN_1800d6620();
                }
                plVar8 = (int64 *)0;
                if (*plVar5 == DAT_181d86d38) {
                  plVar8 = plVar5;
                }
                if (plVar8 == (int64 *)0) {
                          // WARNING: Subroutine does not return
                  FUN_1800d6070(plVar5);
                }
                lVar1 = this.mAnim;
                uVar6 = AnimationState.get_name(plVar8,0);
                if (lVar1 == null) {
                          // WARNING: Subroutine does not return
                  FUN_1800d6620();
                }
                cVar3 = Animation.IsPlaying(lVar1,uVar6,0);
              } while (!cVar3);
              if (this.mLastDirection == 1) break;
              if (this.mLastDirection != -1) {
                uVar9 = 1;
                local_a0[0] = 202;
                local_90 = local_90 + 1;
                goto LAB_180a0c743;
              }
              fVar11 = (float)AnimationState.get_time(plVar8,0);
              if (0.0 < fVar11) {
                uVar9 = 1;
                local_a0[0] = 202;
                local_90 = local_90 + 1;
                goto LAB_180a0c743;
              }
            }
            fVar11 = (float)AnimationState.get_time(plVar8,0);
            fVar12 = (float)AnimationState.get_length(plVar8,0);
          } while (fVar12 <= fVar11);
          uVar9 = 1;
          local_a0[0] = 202;
          local_90 = local_90 + 1;
        LAB_180a0c743:
          iVar2 = local_90;
          lVar4 = il2cpp_internal(lVar4,DAT_181d53c70);
          if (lVar4 != null) {
            FUN_180002970(0,DAT_181d53c70,lVar4);
          }
          if ((iVar2 != 0) && (local_a0[iVar2 + -1] == 202)) {
            return uVar9;
          }
        }
        else {
          uVar6 = this.mAnimator;
          cVar3 = Object.op_Inequality(uVar6,0,0);
          if (cVar3) {
            if (this.mLastDirection == -1) {
              if (this.mAnimator == null) {
                          // WARNING: Subroutine does not return
                FUN_1800d6620();
              }
              piVar7 = (int *)Animator.GetCurrentAnimatorStateInfo
                                        (local_78,this.mAnimator,0,0);
              local_a0[0] = *piVar7;
              local_a0[1] = piVar7[1];
              local_a0[2] = piVar7[2];
              local_a0[3] = piVar7[3];
              local_90 = piVar7[4];
              iStack_8c = piVar7[5];
              iStack_88 = piVar7[6];
              iStack_84 = piVar7[7];
              local_80 = piVar7[8];
              uVar13 = FUN_18044e2b0(local_a0,0);
              Mathf.Clamp01(uVar13,0);
              bVar10 = extraout_XMM0_Da_00 == 0.0;
              fVar11 = extraout_XMM0_Da_00;
            }
            else {
              ActiveAnimation.get_playbackTime(this,0);
              bVar10 = extraout_XMM0_Da == 1.0;
              fVar11 = extraout_XMM0_Da;
            }
            if ((NAN(fVar11)) || (!bVar10)) {
              return true;
            }
          }
        }
        return false;
    }

    // Token : 0x60002A9
    // RVA   : 0xA0AE80   Offset: 0xA09680   Length: 0x29C
    public void Finish()
    {
        ulong uVar1;
        bool cVar2;
        long lVar6;
        ushort uVar7;
        uint uVar9;
        uVar1 = this.mAnim;
        cVar2 = Object.op_Inequality(uVar1,0,0);
        if (cVar2) {
          if (this.mAnim != null) {
            plVar3 = (int64 *)Animation.GetEnumerator(this.mAnim,0);
            while( true ) {
              if (plVar3 == (int64 *)0) {
                          // WARNING: Subroutine does not return
                FUN_1800d6620();
              }
              cVar2 = FUN_180002970(0,DAT_181d544d8,plVar3);
              if (!cVar2) break;
              lVar6 = *plVar3;
              uVar7 = 0;
              if (*(uint16 *)(lVar6 + 0x12a) != 0) {
                do {
                  if (*(int64 *)(*(int64 *)(lVar6 + 176) + (uint64)uVar7 * 16) ==
                      DAT_181d544d8) {
                    puVar4 = (uint64 *)
                             ((int64)
                              *(int *)(*(int64 *)(lVar6 + 176) + 8 + (uint64)uVar7 * 16) * 16 +
                              0x148 + lVar6);
                    goto LAB_180a0b008;
                  }
                  uVar7 = uVar7 + 1;
                } while (uVar7 < *(uint16 *)(lVar6 + 0x12a));
              }
              puVar4 = (uint64 *)FUN_1800914f0(plVar3,DAT_181d544d8,1);
        LAB_180a0b008:
              plVar5 = (int64 *)(*(code *)*puVar4)(plVar3,puVar4[1]);
              plVar8 = (int64 *)0;
              if (plVar5 != (int64 *)0) {
                if (*plVar5 == DAT_181d86d38) {
                  plVar8 = plVar5;
                }
                if (plVar8 == (int64 *)0) {
                          // WARNING: Subroutine does not return
                  FUN_1800d6070(plVar5);
                }
              }
              if (this.mLastDirection == 1) {
                if (plVar8 == (int64 *)0) {
                          // WARNING: Subroutine does not return
                  FUN_1800d6620();
                }
                uVar9 = AnimationState.get_length(plVar8,0);
                AnimationState.set_time(plVar8,uVar9,0);
              }
              else if (this.mLastDirection == -1) {
                if (plVar8 == (int64 *)0) {
                          // WARNING: Subroutine does not return
                  FUN_1800d6620();
                }
                AnimationState.set_time(plVar8,0,0);
              }
            }
            lVar6 = il2cpp_internal(plVar3,DAT_181d53c70);
            if (lVar6 != null) {
              FUN_180002970(0,DAT_181d53c70,lVar6);
            }
            if (this.mAnim != null) {
              Animation.Sample(this.mAnim,0);
              return;
            }
          }
        LAB_180a0b0f3:
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
        uVar1 = this.mAnimator;
        cVar2 = Object.op_Inequality(uVar1,0,0);
        if (cVar2) {
          if (this.mLastDirection == 1) {
            uVar9 = 0x3f800000;
          }
          else {
            uVar9 = 0;
          }
          if (this.mAnimator == null) goto LAB_180a0b0f3;
          Animator.Play(this.mAnimator,this.mClip,0,uVar9,0);
        }
    }

    // Token : 0x60002AA
    // RVA   : 0xA0BBC0   Offset: 0xA0A3C0   Length: 0x2FE
    public void Reset()
    {
        ulong uVar1;
        int iVar2;
        bool cVar3;
        long lVar7;
        ushort uVar8;
        int iVar9;
        uint uVar11;
        int[] aiStackX_18 = new int[2];
        aiStackX_18[1] = 0;
        uVar1 = this.mAnim;
        cVar3 = Object.op_Inequality(uVar1,0,0);
        if (cVar3) {
          if (this.mAnim == null) throw; // [null/range check failed]
          plVar4 = (int64 *)Animation.GetEnumerator(this.mAnim,0);
          local_res20 = plVar4;
          while( true ) {
            if (plVar4 == (int64 *)0) {
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            cVar3 = FUN_180002970(0,DAT_181d544d8,plVar4);
            iVar2 = aiStackX_18[1];
            if (!cVar3) break;
            lVar7 = *plVar4;
            uVar8 = 0;
            if (*(uint16 *)(lVar7 + 0x12a) != 0) {
              do {
                if (*(int64 *)(*(int64 *)(lVar7 + 176) + (uint64)uVar8 * 16) == DAT_181d544d8)
                {
                  puVar5 = (uint64 *)
                           ((int64)*(int *)(*(int64 *)(lVar7 + 176) + 8 + (uint64)uVar8 * 16)
                            * 16 + 0x148 + lVar7);
                  goto LAB_180a0bcf8;
                }
                uVar8 = uVar8 + 1;
              } while (uVar8 < *(uint16 *)(lVar7 + 0x12a));
            }
            puVar5 = (uint64 *)FUN_1800914f0(plVar4,DAT_181d544d8,1);
        LAB_180a0bcf8:
            plVar6 = (int64 *)(*(code *)*puVar5)(plVar4,puVar5[1]);
            plVar10 = (int64 *)0;
            if (plVar6 != (int64 *)0) {
              if (*plVar6 == DAT_181d86d38) {
                plVar10 = plVar6;
              }
              if (plVar10 == (int64 *)0) {
                          // WARNING: Subroutine does not return
                FUN_1800d6070(plVar6);
              }
            }
            if (this.mLastDirection == -1) {
              if (plVar10 == (int64 *)0) {
                          // WARNING: Subroutine does not return
                FUN_1800d6620();
              }
              uVar11 = AnimationState.get_length(plVar10,0);
              AnimationState.set_time(plVar10,uVar11,0);
            }
            else if (this.mLastDirection == 1) {
              if (plVar10 == (int64 *)0) {
                          // WARNING: Subroutine does not return
                FUN_1800d6620();
              }
              AnimationState.set_time(plVar10,0,0);
            }
          }
          aiStackX_18[0] = 163;
          iVar9 = aiStackX_18[1] + 1;
          aiStackX_18[1] = iVar9;
          lVar7 = il2cpp_internal(plVar4,DAT_181d53c70);
          if (lVar7 != null) {
            FUN_180002970(0,DAT_181d53c70,lVar7);
          }
          if ((iVar9 != 0) && (aiStackX_18[iVar2] == 163)) {
            return;
          }
        }
        uVar11 = 0;
        uVar1 = this.mAnimator;
        cVar3 = Object.op_Inequality(uVar1,0,0);
        if (!cVar3) {
          return;
        }
        if (this.mLastDirection == -1) {
          uVar11 = 0x3f800000;
        }
        if (this.mAnimator != null) {
          Animator.Play(this.mAnimator,this.mClip,0,uVar11,0);
          return;
        }
    }

    // Token : 0x60002AB
    // RVA   : 0xA0BEC0   Offset: 0xA0A6C0   Length: 0xCC
    private void Start()
    {
        ulong uVar1;
        bool cVar2;
        uVar1 = this.eventReceiver;
        cVar2 = Object.op_Inequality(uVar1,0,0);
        if (cVar2) {
          uVar1 = this.onFinished;
          cVar2 = EventDelegate.IsValid(uVar1,0);
          if (cVar2) {
            this.eventReceiver = 0;
            this.callWhenFinished = 0;
          }
        }
    }

    // Token : 0x60002AC
    // RVA   : 0xA0BF90   Offset: 0xA0A790   Length: 0x4DE
    private void Update()
    {
        long lVar1;
        bool cVar4;
        long lVar5;
        ulong uVar7;
        float fVar9;
        float fVar10;
        float fVar11;
        uint uVar12;
        fVar9 = (float)RealTime.get_deltaTime(0);
        if (fVar9 != 0.0) {
          uVar7 = this.mAnimator;
          cVar4 = Object.op_Inequality(uVar7,0,0);
          if (!cVar4) {
            uVar7 = this.mAnim;
            cVar4 = Object.op_Inequality(uVar7,0,0);
            if (cVar4) {
              bVar3 = false;
              if (this.mAnim != null) {
                lVar5 = Animation.GetEnumerator(this.mAnim,0);
        LAB_180a0c100:
                do {
                  if (lVar5 == null) {
                          // WARNING: Subroutine does not return
                    FUN_1800d6620();
                  }
                  cVar4 = FUN_180002970(0,DAT_181d544d8,lVar5);
                  if (!cVar4) {
                    lVar5 = il2cpp_internal(lVar5,DAT_181d53c70);
                    if (lVar5 != null) {
                      FUN_180002970(0,DAT_181d53c70,lVar5);
                    }
                    if (this.mAnim == null) goto LAB_180a0c446;
                    Animation.Sample(this.mAnim,0);
                    if (bVar3) {
                      return;
                    }
                    goto LAB_180a0c2da;
                  }
                  plVar6 = (int64 *)FUN_180002970(1,DAT_181d544d8,lVar5);
                  if (plVar6 == (int64 *)0) {
                          // WARNING: Subroutine does not return
                    FUN_1800d6620();
                  }
                  plVar8 = (int64 *)0;
                  if (*plVar6 == DAT_181d86d38) {
                    plVar8 = plVar6;
                  }
                  if (plVar8 == (int64 *)0) {
                          // WARNING: Subroutine does not return
                    FUN_1800d6070(plVar6);
                  }
                  lVar1 = this.mAnim;
                  uVar7 = AnimationState.get_name(plVar8,0);
                  if (lVar1 == null) {
                          // WARNING: Subroutine does not return
                    FUN_1800d6620();
                  }
                  cVar4 = Animation.IsPlaying(lVar1,uVar7,0);
                } while (!cVar4);
                fVar10 = (float)AnimationState.get_speed(plVar8,0);
                fVar11 = (float)AnimationState.get_time(plVar8,0);
                AnimationState.set_time(plVar8,fVar11 + fVar10 * fVar9,0);
                fVar11 = (float)AnimationState.get_time(plVar8,0);
                if (fVar10 * fVar9 < 0.0) {
                  if (fVar11 <= 0.0) {
                    AnimationState.set_time(plVar8,0,0);
                    goto LAB_180a0c100;
                  }
                }
                else {
                  fVar10 = (float)AnimationState.get_length(plVar8,0);
                  if (fVar10 <= fVar11) {
                    uVar12 = AnimationState.get_length(plVar8,0);
                    AnimationState.set_time(plVar8,uVar12,0);
                    goto LAB_180a0c100;
                  }
                }
                bVar3 = true;
                goto LAB_180a0c100;
              }
        LAB_180a0c446:
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            Behaviour.set_enabled(this,0,0);
          }
          else {
            if (this.mLastDirection == -1) {
              fVar9 = -fVar9;
            }
            if (this.mAnimator == null) goto LAB_180a0c446;
            Animator.Update(this.mAnimator,fVar9,0);
            cVar4 = ActiveAnimation.get_isPlaying(this,0);
            if (!cVar4) {
              if (this.mAnimator == null) goto LAB_180a0c446;
              Behaviour.set_enabled(this.mAnimator,0,0);
        LAB_180a0c2da:
              Behaviour.set_enabled(this,0,0);
              if (this.mNotify) {
                this.mNotify = 0;
                uVar7 = **(uint64 **)(DAT_181d85940 + 184);
                cVar4 = Object.op_Equality(uVar7,0,0);
                if (cVar4) {
                  plVar6 = *(int64 **)(DAT_181d85940 + 184);
                  *plVar6 = this;
                  il2cpp_internal(plVar6,this);
                  uVar7 = this.onFinished;
                  EventDelegate.Execute(uVar7,0);
                  uVar7 = this.eventReceiver;
                  cVar4 = Object.op_Inequality(uVar7,0,0);
                  if ((cVar4) &&
                     (cVar4 = FUN_180d6ca90(this.callWhenFinished,0), !cVar4)) {
                    if (this.eventReceiver == null) goto LAB_180a0c446;
                    GameObject.SendMessage
                              (this.eventReceiver,this.callWhenFinished,1);
                  }
                  puVar2 = *(uint64 **)(DAT_181d85940 + 184);
                  *puVar2 = 0;
                  il2cpp_internal(puVar2,0);
                }
                if ((this.mDisableDirection != null) &&
                   (this.mLastDirection == this.mDisableDirection)) {
                  uVar7 = Component.get_gameObject(this,0);
                  NGUITools.SetActive(uVar7,0,0);
                }
              }
            }
          }
        }
    }

    // Token : 0x60002AD
    // RVA   : 0xA0B730   Offset: 0xA09F30   Length: 0x488
    private void Play(string clipName, Direction playDirection)
    {
        int64 ActiveAnimation.Play
                         (int64 this,uint64 clipName,uint32 playDirection,int param_4,
                         uint32 param_5)
        {
        int iVar1;
        char cVar2;
        uint64 uVar3;
        int64 lVar4;
        uint32 uVar5;
        if (this == 0) throw; // [null/range check failed]
        if (param_4 != 2) {
          uVar3 = Component.get_gameObject(this,0);
          cVar2 = NGUITools.GetActive(uVar3,0);
          if (!cVar2) {
            if (param_4 != 1) {
              return 0;
            }
            uVar3 = Component.get_gameObject(this,0);
            NGUITools.SetActive(uVar3,1,0);
            lVar4 = Component.get_gameObject(this,0);
            if (lVar4 == null) throw; // [null/range check failed]
            lVar4 = FUN_180956bf0(lVar4,DAT_181da30b0);
            uVar5 = 0;
            if (lVar4 == null) throw; // [null/range check failed]
            iVar1 = *(int *)(lVar4 + 24);
            if (0 < iVar1) {
              do {
                if (*(uint32 *)(lVar4 + 24) <= uVar5) {
                  uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1800d65f0(uVar3,0);
                }
                if (lVar4[uVar5] == 0) throw; // [null/range check failed]
                UIPanel.Refresh();
                uVar5 = uVar5 + 1;
              } while ((int)uVar5 < iVar1);
            }
          }
        }
        lVar4 = Component.GetComponent(this,DAT_181d6a8c0);
        cVar2 = Object.op_Equality(lVar4,0,0);
        if (cVar2) {
          lVar4 = Component.get_gameObject(this,0);
          if (lVar4 == null) throw; // [null/range check failed]
          lVar4 = GameObject.AddComponent(lVar4,DAT_181d9bd80);
        }
        if (lVar4 != null) {
          *(int64 *)(lVar4 + 72) = this;
          *(uint32 *)(lVar4 + 60) = param_5;
          if (*(int64 *)(lVar4 + 24) != 0) {
            FUN_180f56130(*(int64 *)(lVar4 + 24),DAT_181d5e800);
            ActiveAnimation.Play(lVar4,clipName,playDirection,0);
            uVar3 = *(uint64 *)(lVar4 + 48);
            cVar2 = Object.op_Inequality(uVar3,0,0);
            if (!cVar2) {
              uVar3 = *(uint64 *)(lVar4 + 72);
              cVar2 = Object.op_Inequality(uVar3,0,0);
              if (cVar2) {
                if (*(int64 *)(lVar4 + 72) == 0) throw; // [null/range check failed]
                Animator.Update(*(int64 *)(lVar4 + 72),0,0);
              }
            }
            else {
              if (*(int64 *)(lVar4 + 48) == 0) throw; // [null/range check failed]
              Animation.Sample(*(int64 *)(lVar4 + 48),0);
            }
            return lVar4;
          }
        }
    }

    // Token : 0x60002AE
    // RVA   : 0xA0B120   Offset: 0xA09920   Length: 0x2DB
    public static ActiveAnimation Play(Animation anim, string clipName, Direction playDirection, EnableCondition enableBeforePlay, DisableCondition disableCondition)
    {
        int64 ActiveAnimation.Play
                         (int64 anim,uint64 clipName,uint32 playDirection,int enableBeforePlay,
                         uint32 disableCondition)
        {
        int iVar1;
        char cVar2;
        uint64 uVar3;
        int64 lVar4;
        uint32 uVar5;
        if (anim == null) throw; // [null/range check failed]
        if (enableBeforePlay != 2) {
          uVar3 = Component.get_gameObject(anim,0);
          cVar2 = NGUITools.GetActive(uVar3,0);
          if (!cVar2) {
            if (enableBeforePlay != 1) {
              return 0;
            }
            uVar3 = Component.get_gameObject(anim,0);
            NGUITools.SetActive(uVar3,1,0);
            lVar4 = Component.get_gameObject(anim,0);
            if (lVar4 == null) throw; // [null/range check failed]
            lVar4 = FUN_180956bf0(lVar4,DAT_181da30b0);
            uVar5 = 0;
            if (lVar4 == null) throw; // [null/range check failed]
            iVar1 = *(int *)(lVar4 + 24);
            if (0 < iVar1) {
              do {
                if (*(uint32 *)(lVar4 + 24) <= uVar5) {
                  uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1800d65f0(uVar3,0);
                }
                if (lVar4[uVar5] == 0) throw; // [null/range check failed]
                UIPanel.Refresh();
                uVar5 = uVar5 + 1;
              } while ((int)uVar5 < iVar1);
            }
          }
        }
        lVar4 = Component.GetComponent(anim,DAT_181d6a8c0);
        cVar2 = Object.op_Equality(lVar4,0,0);
        if (cVar2) {
          lVar4 = Component.get_gameObject(anim,0);
          if (lVar4 == null) throw; // [null/range check failed]
          lVar4 = GameObject.AddComponent(lVar4,DAT_181d9bd80);
        }
        if (lVar4 != null) {
          *(int64 *)(lVar4 + 72) = anim;
          *(uint32 *)(lVar4 + 60) = disableCondition;
          if (*(int64 *)(lVar4 + 24) != 0) {
            FUN_180f56130(*(int64 *)(lVar4 + 24),DAT_181d5e800);
            ActiveAnimation.Play(lVar4,clipName,playDirection,0);
            uVar3 = *(uint64 *)(lVar4 + 48);
            cVar2 = Object.op_Inequality(uVar3,0,0);
            if (!cVar2) {
              uVar3 = *(uint64 *)(lVar4 + 72);
              cVar2 = Object.op_Inequality(uVar3,0,0);
              if (cVar2) {
                if (*(int64 *)(lVar4 + 72) == 0) throw; // [null/range check failed]
                Animator.Update(*(int64 *)(lVar4 + 72),0,0);
              }
            }
            else {
              if (*(int64 *)(lVar4 + 48) == 0) throw; // [null/range check failed]
              Animation.Sample(*(int64 *)(lVar4 + 48),0);
            }
            return lVar4;
          }
        }
    }

    // Token : 0x60002AF
    // RVA   : 0xA0B710   Offset: 0xA09F10   Length: 0x1C
    public static ActiveAnimation Play(Animation anim, string clipName, Direction playDirection)
    {
        int64 ActiveAnimation.Play
                         (int64 anim,uint64 clipName,uint32 playDirection,int param_4,
                         uint32 param_5)
        {
        int iVar1;
        char cVar2;
        uint64 uVar3;
        int64 lVar4;
        uint32 uVar5;
        if (anim == null) throw; // [null/range check failed]
        if (param_4 != 2) {
          uVar3 = Component.get_gameObject(anim,0);
          cVar2 = NGUITools.GetActive(uVar3,0);
          if (!cVar2) {
            if (param_4 != 1) {
              return 0;
            }
            uVar3 = Component.get_gameObject(anim,0);
            NGUITools.SetActive(uVar3,1,0);
            lVar4 = Component.get_gameObject(anim,0);
            if (lVar4 == null) throw; // [null/range check failed]
            lVar4 = FUN_180956bf0(lVar4,DAT_181da30b0);
            uVar5 = 0;
            if (lVar4 == null) throw; // [null/range check failed]
            iVar1 = *(int *)(lVar4 + 24);
            if (0 < iVar1) {
              do {
                if (*(uint32 *)(lVar4 + 24) <= uVar5) {
                  uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1800d65f0(uVar3,0);
                }
                if (lVar4[uVar5] == 0) throw; // [null/range check failed]
                UIPanel.Refresh();
                uVar5 = uVar5 + 1;
              } while ((int)uVar5 < iVar1);
            }
          }
        }
        lVar4 = Component.GetComponent(anim,DAT_181d6a8c0);
        cVar2 = Object.op_Equality(lVar4,0,0);
        if (cVar2) {
          lVar4 = Component.get_gameObject(anim,0);
          if (lVar4 == null) throw; // [null/range check failed]
          lVar4 = GameObject.AddComponent(lVar4,DAT_181d9bd80);
        }
        if (lVar4 != null) {
          *(int64 *)(lVar4 + 72) = anim;
          *(uint32 *)(lVar4 + 60) = param_5;
          if (*(int64 *)(lVar4 + 24) != 0) {
            FUN_180f56130(*(int64 *)(lVar4 + 24),DAT_181d5e800);
            ActiveAnimation.Play(lVar4,clipName,playDirection,0);
            uVar3 = *(uint64 *)(lVar4 + 48);
            cVar2 = Object.op_Inequality(uVar3,0,0);
            if (!cVar2) {
              uVar3 = *(uint64 *)(lVar4 + 72);
              cVar2 = Object.op_Inequality(uVar3,0,0);
              if (cVar2) {
                if (*(int64 *)(lVar4 + 72) == 0) throw; // [null/range check failed]
                Animator.Update(*(int64 *)(lVar4 + 72),0,0);
              }
            }
            else {
              if (*(int64 *)(lVar4 + 48) == 0) throw; // [null/range check failed]
              Animation.Sample(*(int64 *)(lVar4 + 48),0);
            }
            return lVar4;
          }
        }
    }

    // Token : 0x60002B0
    // RVA   : 0xA0B400   Offset: 0xA09C00   Length: 0x21
    public static ActiveAnimation Play(Animation anim, Direction playDirection)
    {
        int64 ActiveAnimation.Play
                         (int64 anim,uint64 playDirection,uint32 param_3,int param_4,
                         uint32 param_5)
        {
        int iVar1;
        char cVar2;
        uint64 uVar3;
        int64 lVar4;
        uint32 uVar5;
        if (anim == null) throw; // [null/range check failed]
        if (param_4 != 2) {
          uVar3 = Component.get_gameObject(anim,0);
          cVar2 = NGUITools.GetActive(uVar3,0);
          if (!cVar2) {
            if (param_4 != 1) {
              return 0;
            }
            uVar3 = Component.get_gameObject(anim,0);
            NGUITools.SetActive(uVar3,1,0);
            lVar4 = Component.get_gameObject(anim,0);
            if (lVar4 == null) throw; // [null/range check failed]
            lVar4 = FUN_180956bf0(lVar4,DAT_181da30b0);
            uVar5 = 0;
            if (lVar4 == null) throw; // [null/range check failed]
            iVar1 = *(int *)(lVar4 + 24);
            if (0 < iVar1) {
              do {
                if (*(uint32 *)(lVar4 + 24) <= uVar5) {
                  uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1800d65f0(uVar3,0);
                }
                if (lVar4[uVar5] == 0) throw; // [null/range check failed]
                UIPanel.Refresh();
                uVar5 = uVar5 + 1;
              } while ((int)uVar5 < iVar1);
            }
          }
        }
        lVar4 = Component.GetComponent(anim,DAT_181d6a8c0);
        cVar2 = Object.op_Equality(lVar4,0,0);
        if (cVar2) {
          lVar4 = Component.get_gameObject(anim,0);
          if (lVar4 == null) throw; // [null/range check failed]
          lVar4 = GameObject.AddComponent(lVar4,DAT_181d9bd80);
        }
        if (lVar4 != null) {
          *(int64 *)(lVar4 + 72) = anim;
          *(uint32 *)(lVar4 + 60) = param_5;
          if (*(int64 *)(lVar4 + 24) != 0) {
            FUN_180f56130(*(int64 *)(lVar4 + 24),DAT_181d5e800);
            ActiveAnimation.Play(lVar4,playDirection,param_3,0);
            uVar3 = *(uint64 *)(lVar4 + 48);
            cVar2 = Object.op_Inequality(uVar3,0,0);
            if (!cVar2) {
              uVar3 = *(uint64 *)(lVar4 + 72);
              cVar2 = Object.op_Inequality(uVar3,0,0);
              if (cVar2) {
                if (*(int64 *)(lVar4 + 72) == 0) throw; // [null/range check failed]
                Animator.Update(*(int64 *)(lVar4 + 72),0,0);
              }
            }
            else {
              if (*(int64 *)(lVar4 + 48) == 0) throw; // [null/range check failed]
              Animation.Sample(*(int64 *)(lVar4 + 48),0);
            }
            return lVar4;
          }
        }
    }

    // Token : 0x60002B1
    // RVA   : 0xA0B430   Offset: 0xA09C30   Length: 0x2DE
    public static ActiveAnimation Play(Animator anim, string clipName, Direction playDirection, EnableCondition enableBeforePlay, DisableCondition disableCondition)
    {
        int64 ActiveAnimation.Play
                         (int64 anim,uint64 clipName,uint32 playDirection,int enableBeforePlay,
                         uint32 disableCondition)
        {
        int iVar1;
        char cVar2;
        uint64 uVar3;
        int64 lVar4;
        uint32 uVar5;
        if (anim == null) throw; // [null/range check failed]
        if (enableBeforePlay != 2) {
          uVar3 = Component.get_gameObject(anim,0);
          cVar2 = NGUITools.GetActive(uVar3,0);
          if (!cVar2) {
            if (enableBeforePlay != 1) {
              return 0;
            }
            uVar3 = Component.get_gameObject(anim,0);
            NGUITools.SetActive(uVar3,1,0);
            lVar4 = Component.get_gameObject(anim,0);
            if (lVar4 == null) throw; // [null/range check failed]
            lVar4 = FUN_180956bf0(lVar4,DAT_181da30b0);
            uVar5 = 0;
            if (lVar4 == null) throw; // [null/range check failed]
            iVar1 = *(int *)(lVar4 + 24);
            if (0 < iVar1) {
              do {
                if (*(uint32 *)(lVar4 + 24) <= uVar5) {
                  uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1800d65f0(uVar3,0);
                }
                if (lVar4[uVar5] == 0) throw; // [null/range check failed]
                UIPanel.Refresh();
                uVar5 = uVar5 + 1;
              } while ((int)uVar5 < iVar1);
            }
          }
        }
        lVar4 = Component.GetComponent(anim,DAT_181d6a8c0);
        cVar2 = Object.op_Equality(lVar4,0,0);
        if (cVar2) {
          lVar4 = Component.get_gameObject(anim,0);
          if (lVar4 == null) throw; // [null/range check failed]
          lVar4 = GameObject.AddComponent(lVar4,DAT_181d9bd80);
        }
        if (lVar4 != null) {
          *(int64 *)(lVar4 + 72) = anim;
          *(uint32 *)(lVar4 + 60) = disableCondition;
          if (*(int64 *)(lVar4 + 24) != 0) {
            FUN_180f56130(*(int64 *)(lVar4 + 24),DAT_181d5e800);
            ActiveAnimation.Play(lVar4,clipName,playDirection,0);
            uVar3 = *(uint64 *)(lVar4 + 48);
            cVar2 = Object.op_Inequality(uVar3,0,0);
            if (!cVar2) {
              uVar3 = *(uint64 *)(lVar4 + 72);
              cVar2 = Object.op_Inequality(uVar3,0,0);
              if (cVar2) {
                if (*(int64 *)(lVar4 + 72) == 0) throw; // [null/range check failed]
                Animator.Update(*(int64 *)(lVar4 + 72),0,0);
              }
            }
            else {
              if (*(int64 *)(lVar4 + 48) == 0) throw; // [null/range check failed]
              Animation.Sample(*(int64 *)(lVar4 + 48),0);
            }
            return lVar4;
          }
        }
    }

    // Token : 0x60002B2
    // RVA   : 0xA0C470   Offset: 0xA0AC70   Length: 0x95
    public void /*ctor*/()
    {
        ulong uVar1;
        uVar1 = il2cpp_internal(DAT_181d6d9b0);
        FUN_180f58a90(uVar1,DAT_181d5e700);
        this.onFinished = uVar1;
        this.mClip = "";
        FUN_18044ef50(this,0);
    }

}
