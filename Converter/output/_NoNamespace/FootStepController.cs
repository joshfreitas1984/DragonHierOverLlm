// ============================================================
// Type  : FootStepController
// Token : 0x2000280
// ============================================================

public class FootStepController
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x400139F
    public SkeletonAnimation skeleton;

    // Token: 0x40013A0
    public List<float> volumn;

    // Token: 0x40013A1
    public bool inWater;

    // Token: 0x40013A2
    private Bone leftFootBone;

    // Token: 0x40013A3
    private Bone rightFootBone;

    // Token: 0x40013A4
    private List<Bone> horseFootBones;

    // Token: 0x40013A5
    private GameObject temp;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x600144C
    // RVA   : 0xBA6B00   Offset: 0xBA5300   Length: 0x2DF
    public void Init(SkeletonAnimation targetSkeleton)
    {
        var pStatics = *(int64*)(DAT_181d4ef00 + 184);
        long lVar1;
        ulong uVar2;
        long lVar3;
        long lVar4;
        int iVar5;
        this.skeleton = targetSkeleton;
        if (this.skeleton != null) {
          lVar3 = *(int64 *)(this.skeleton + 224);
          uVar2 = new OnTooltipCB(this,DAT_181d98358,0);
          if (lVar3 != null) {
            AnimationState.add_Event(lVar3,uVar2,0);
            if (this.skeleton != null) {
              lVar3 = Component.GetComponent(this.skeleton,DAT_181d6cd40);
              if (lVar3 != null) {
                lVar3 = *(int64 *)(lVar3 + 192);
                if (lVar3 != null) {
                  uVar2 = Skeleton.FindBone(lVar3,*(uint64 *)
                                                    (pStatics + 0x1b8),0);
                  this.leftFootBone = uVar2;
                  if (this.skeleton != null) {
                    lVar3 = Component.GetComponent(this.skeleton,DAT_181d6cd40);
                    if (lVar3 != null) {
                      if (*(int64 *)(lVar3 + 192) != 0) {
                        uVar2 = Skeleton.FindBone(*(int64 *)(lVar3 + 192),
                                                   *(uint64 *)
                                                    (pStatics + 0x1c0),0);
                        this.rightFootBone = uVar2;
                        iVar5 = 0;
                        while( true ) {
                          lVar3 = *(int64 *)(pStatics + 0x1d0);
                          if (lVar3 == null) break;
                          if (lVar3.Count <= iVar5) {
                            return;
                          }
                          lVar3 = this.horseFootBones;
                          if (this.skeleton == null) break;
                          lVar4 = Component.GetComponent(this.skeleton,DAT_181d6cd40);
                          if (lVar4 == null) break;
                          lVar4 = *(int64 *)(lVar4 + 192);
                          lVar1 = *(int64 *)(pStatics + 0x1d0);
                          if (lVar1 == null) break;
                          uVar2 = FUN_180002f80(lVar1,iVar5,DAT_181d7c9c0);
                          if (lVar4 == null) break;
                          uVar2 = Skeleton.FindBone(lVar4,uVar2,0);
                          if (lVar3 == null) break;
                          FUN_181827900(lVar3,uVar2,DAT_181d58818);
                          iVar5 = iVar5 + 1;
                        }
                      }
                    }
                  }
                }
              }
            }
          }
        }
    }

    // Token : 0x600144D
    // RVA   : 0xBA6EC0   Offset: 0xBA56C0   Length: 0x5C3
    private void PrintFootStep(Vector3 targetLocalPos, bool isHorseStep)
    {
        var pStatics = *(int64*)(DAT_181d4e188 + 184);
        ulong uVar1;
        uint uVar2;
        ulong uVar3;
        long lVar4;
        long lVar5;
        uint uVar6;
        float fVar7;
        float fVar8;
        ulong local_38;
        uint local_30;
        local_38 = *targetLocalPos;
        local_30 = *(uint32 *)(targetLocalPos + 1);
        uVar3 = 0;
        if (!isHorseStep) {
          if (!this.inWater) {
            uVar3 = 2;
          }
          FootStepController.GenerateFootStepParticle(this,uVar3,&local_38,0);
          lVar4 = this.volumn;
          if (lVar4 == null) throw; // [null/range check failed]
          if (lVar4.Count < 2) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          if (*(float *)(lVar4._items + 36) <= 0.0) {
            return;
          }
          if (*pStatics == 0) throw; // [null/range check failed]
          lVar4 = *(int64 *)(*pStatics + 240);
          if ((*pStatics == 0) ||
             (lVar5 = *(int64 *)(*pStatics + 240)) == null)
          throw; // [null/range check failed]
          uVar2 = FUN_180d8cf10(0,lVar5.Count,0);
          if (lVar4 == null) throw; // [null/range check failed]
          if (lVar4.Count <= uVar2) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          lVar5 = this.volumn;
          uVar3 = lVar4._items[uVar2];
          if (lVar5 == null) throw; // [null/range check failed]
          lVar4 = lVar5;
          if (lVar5.Count == null) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
            lVar4 = this.volumn;
          }
          uVar6 = *(uint32 *)(lVar5._items + 32);
          if (lVar4 == null) throw; // [null/range check failed]
          if (lVar4.Count < 2) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          uVar6 = Random.Range(uVar6,*(uint32 *)(lVar4._items + 36),0);
          NGUITools.PlaySound(uVar3,uVar6,0);
          if (!this.inWater) {
            return;
          }
          if (*pStatics == 0) throw; // [null/range check failed]
          lVar4 = *(int64 *)(*pStatics + 0x100);
          if (((*pStatics == 0) ||
              (lVar5 = *(int64 *)(*pStatics + 0x100)) == null) ||
             (uVar2 = FUN_180d8cf10(0,lVar5.Count,0), lVar4 == null)) throw; // [null/range check failed]
          if (lVar4.Count <= uVar2) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          uVar6 = 0x3ecccccd;
          uVar3 = 0x3e99999a;
        }
        else {
          FootStepController.GenerateFootStepParticle
                    (this,!this.inWater,&local_38,0);
          lVar4 = this.volumn;
          if (lVar4 == null) throw; // [null/range check failed]
          if (lVar4.Count < 2) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          if (*(float *)(lVar4._items + 36) <= 0.0) {
            return;
          }
          if (*pStatics == 0) throw; // [null/range check failed]
          lVar4 = *(int64 *)(*pStatics + 248);
          if ((*pStatics == 0) ||
             (lVar5 = *(int64 *)(*pStatics + 248)) == null)
          throw; // [null/range check failed]
          uVar2 = FUN_180d8cf10(0,lVar5.Count,0);
          if (lVar4 == null) throw; // [null/range check failed]
          if (lVar4.Count <= uVar2) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          uVar3 = lVar4._items[uVar2];
          fVar7 = (float)Random.Range(0x3ecccccd,0x3f19999a,0);
          lVar4 = this.volumn;
          if (lVar4 == null) throw; // [null/range check failed]
          lVar5 = lVar4;
          if (lVar4.Count == null) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
            lVar5 = this.volumn;
          }
          uVar6 = *(uint32 *)(lVar4._items + 32);
          if (lVar5 == null) throw; // [null/range check failed]
          if (lVar5.Count < 2) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          fVar8 = (float)Random.Range(uVar6,*(uint32 *)(lVar5._items + 36),0);
          NGUITools.PlaySound(uVar3,fVar8 * fVar7,0);
          if (!this.inWater) {
            return;
          }
          if (*pStatics == 0) throw; // [null/range check failed]
          lVar4 = *(int64 *)(*pStatics + 0x100);
          if (((*pStatics == 0) ||
              (lVar5 = *(int64 *)(*pStatics + 0x100)) == null) ||
             (uVar2 = FUN_180d8cf10(0,lVar5.Count,0), lVar4 == null)) throw; // [null/range check failed]
          if (lVar4.Count <= uVar2) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          uVar6 = 0x3f19999a;
          uVar3 = 0x3ecccccd;
        }
        uVar1 = lVar4._items[uVar2];
        fVar7 = (float)Random.Range(uVar3,uVar6,0);
        lVar4 = this.volumn;
        if (lVar4 != null) {
          lVar5 = lVar4;
          if (lVar4.Count == null) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
            lVar5 = this.volumn;
          }
          uVar6 = *(uint32 *)(lVar4._items + 32);
          if (lVar5 != null) {
            if (lVar5.Count < 2) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            fVar8 = (float)Random.Range(uVar6,*(uint32 *)(lVar5._items + 36),0);
            NGUITools.PlaySound(uVar1,fVar8 * fVar7,0);
            return;
          }
        }
    }

    // Token : 0x600144E
    // RVA   : 0xBA6220   Offset: 0xBA4A20   Length: 0x35C
    private void GenerateFootStepParticle(int particleID, Vector3 targetLocalPos)
    {
        var pStatics = *(int64*)(DAT_181d4e188 + 184);
        ulong uVar1;
        float fVar2;
        long lVar3;
        ulong uVar4;
        long lVar5;
        float fVar7;
        ulong local_b8;
        ulong local_a8;
        float local_a0;
        float local_90;
        ulong local_88;
        float local_80;
        byte[] local_78 = new byte[16];
        byte[] local_68 = new byte[80];
        lVar3 = Component.get_transform(this,0);
        fVar2 = local_80;
        if (lVar3 != null) {
          lVar3 = FUN_180da0f00(lVar3,0);
          fVar2 = local_80;
          if (lVar3 != null) {
            uVar4 = Component.get_gameObject(lVar3,0);
            fVar2 = local_80;
            if ((*pStatics != 0) &&
               (lVar3 = *(int64 *)(*pStatics + 208)) != null) {
              if (*(uint32 *)(lVar3 + 24) <= particleID) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              uVar1 = lVar3[particleID];
              uVar4 = GlobalData.AddChild(uVar4,uVar1,0);
              this.temp = uVar4;
              fVar2 = local_80;
              if (this.temp != null) {
                lVar3 = GameObject.get_transform(this.temp,0);
                fVar2 = local_80;
                if (this.skeleton != null) {
                  lVar5 = Component.get_transform(this.skeleton,0);
                  fVar2 = local_80;
                  if (lVar5 != null) {
                    puVar6 = (uint64 *)Transform.get_localScale(local_78,lVar5,0);
                    uVar4 = *puVar6;
                    local_a0 = *(float *)(puVar6 + 1);
                    fVar7 = (float)Random.Range(0x3f4ccccd,0x3f99999a,0);
                    local_b8 = CONCAT44((float)((uint64)uVar4 >> 32) * fVar7,(float)uVar4 * fVar7);
                    local_a8 = uVar4;
                    fVar2 = local_80;
                    if (lVar3 != null) {
                      local_a8 = local_b8;
                      local_a0 = local_a0 * fVar7;
                      Transform.set_localScale(lVar3,&local_a8,0);
                      fVar2 = local_80;
                      if (this.temp != null) {
                        lVar3 = GameObject.get_transform(this.temp,0);
                        lVar5 = Component.get_transform(this,0);
                        fVar2 = local_80;
                        if (lVar5 != null) {
                          uVar4 = *targetLocalPos;
                          puVar6 = (uint64 *)Transform.get_localPosition(&local_88,lVar5,0);
                          uVar1 = *puVar6;
                          local_a0 = *(float *)(puVar6 + 1);
                          local_90 = *(float *)(targetLocalPos + 1);
                          puVar6 = (uint64 *)Vector3.get_forward(local_68,0);
                          local_88 = *puVar6;
                          local_b8 = CONCAT44((float)((uint64)uVar1 >> 32) +
                                              (float)((uint64)uVar4 >> 32) +
                                              (float)((uint64)local_88 >> 32) * 0.05,
                                              (float)uVar4 + (float)uVar1 + (float)local_88 * 0.05);
                          local_80 = local_a0 + local_90 + *(float *)(puVar6 + 1) * 0.05;
                          fVar2 = *(float *)(puVar6 + 1);
                          if (lVar3 != null) {
                            local_88 = local_b8;
                            Transform.set_localPosition(lVar3,&local_88,0);
                            return;
                          }
                        }
                      }
                    }
                  }
                }
              }
            }
          }
        }
        local_80 = fVar2;
    }

    // Token : 0x600144F
    // RVA   : 0xBA6580   Offset: 0xBA4D80   Length: 0x570
    private void HandleEvent(TrackEntry trackEntry, Event e)
    {
        var pStatics_0f00 = *(int64*)(DAT_181d50f00 + 184);
        var pStatics_1200 = *(int64*)(DAT_181d51200 + 184);
        var pStatics_c960 = *(int64*)(DAT_181d6c960 + 184);
        var pStatics_e090 = *(int64*)(DAT_181d4e090 + 184);
        var pStatics_ede0 = *(int64*)(DAT_181d6ede0 + 184);
        var pStatics_ef00 = *(int64*)(DAT_181d4ef00 + 184);
        var pStatics_f230 = *(int64*)(DAT_181d7f230 + 184);
        long lVar1;
        bool cVar2;
        uint uVar3;
        long lVar4;
        ulong uVar6;
        ulong local_28;
        float local_20;
        byte[] local_18 = new byte[8];
        float local_10;
        if (*pStatics_c960 != 0) {
          if (*(char *)(*pStatics_c960 + 24) != false) {
            return;
          }
          if ((*pStatics_f230 == 0) ||
             (lVar4 = *(int64 *)(*pStatics_f230 + 40)) == null)
          throw; // [null/range check failed]
          cVar2 = GameObject.get_activeSelf(lVar4,0);
          if (cVar2) {
            return;
          }
          if ((*pStatics_0f00 == 0) ||
             (lVar4 = *(int64 *)(*pStatics_0f00 + 32)) == null)
          throw; // [null/range check failed]
          cVar2 = GameObject.get_activeSelf(lVar4,0);
          if (cVar2) {
            return;
          }
          if ((*pStatics_ede0 == 0) ||
             (lVar4 = *(int64 *)(*pStatics_ede0 + 32)) == null)
          throw; // [null/range check failed]
          cVar2 = GameObject.get_activeSelf(lVar4,0);
          if (cVar2) {
            return;
          }
          lVar4 = FUN_18077c180(0);
          if ((lVar4 == null) || (lVar4.Count == null)) throw; // [null/range check failed]
          cVar2 = GameObject.get_activeSelf(lVar4.Count,0);
          if (cVar2) {
            return;
          }
          if ((*pStatics_1200 == 0) ||
             (lVar4 = *(int64 *)(*pStatics_1200 + 24)) == null)
          throw; // [null/range check failed]
          cVar2 = GameObject.get_activeSelf(lVar4,0);
          if (cVar2) {
            return;
          }
          if ((*pStatics_e090 == 0) ||
             (lVar4 = *(int64 *)(*pStatics_e090 + 24)) == null)
          throw; // [null/range check failed]
          cVar2 = GameObject.get_activeSelf(lVar4,0);
          if (cVar2) {
            return;
          }
          if ((e == null) || (*(int64 *)(e + 16) == 0)) throw; // [null/range check failed]
          cVar2 = FUN_1816fd990(*(uint64 *)(*(int64 *)(e + 16) + 16),"leftfootstep",0);
          if (!cVar2) {
            if (*(int64 *)(e + 16) == 0) throw; // [null/range check failed]
            cVar2 = FUN_1816fd990(*(uint64 *)(*(int64 *)(e + 16) + 16),"rightfootstep",0);
            if (!cVar2) {
              lVar4 = *(int64 *)(pStatics_ef00 + 0x1c8);
              if ((*(int64 *)(e + 16) == 0) || (lVar4 == null)) throw; // [null/range check failed]
              cVar2 = FUN_1818279a0(lVar4,*(uint64 *)(*(int64 *)(e + 16) + 16),
                                    DAT_181d7c4d0);
              if (!cVar2) {
                return;
              }
              lVar4 = this.horseFootBones;
              lVar1 = *(int64 *)(pStatics_ef00 + 0x1c8);
              if ((*(int64 *)(e + 16) == 0) || (lVar1 == null)) throw; // [null/range check failed]
              uVar3 = FUN_1817ff280(lVar1,*(uint64 *)(*(int64 *)(e + 16) + 16),
                                    DAT_181d7c648);
              if (lVar4 == null) throw; // [null/range check failed]
              if (lVar4.Count <= uVar3) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              local_28 = SkeletonExtensions.GetLocalPosition
                                   (*(uint64 *)
                                     (lVar4._items + 32 + (int64)(int)uVar3 * 8),0);
              if ((this.skeleton == null) ||
                 (lVar4 = Component.get_transform(this.skeleton,0)) == null)
              throw; // [null/range check failed]
              pfVar5 = (float *)Transform.get_localScale(local_18,lVar4,0);
              local_10 = *pfVar5;
              local_28 = CONCAT44(local_28._4_4_ * local_10,(float)local_28 * local_10);
              uVar6 = 1;
              goto LAB_180ba6a4f;
            }
            uVar6 = this.rightFootBone;
          }
          else {
            uVar6 = this.leftFootBone;
          }
          local_28 = SkeletonExtensions.GetLocalPosition(uVar6,0);
          if ((this.skeleton != null) &&
             (lVar4 = Component.get_transform(this.skeleton,0)) != null) {
            pfVar5 = (float *)Transform.get_localScale(local_18,lVar4,0);
            local_10 = *pfVar5;
            local_28 = CONCAT44(local_28._4_4_ * local_10,(float)local_28 * local_10);
            uVar6 = 0;
        LAB_180ba6a4f:
            local_10 = local_10 * 0.0;
            local_20 = local_10;
            FootStepController.PrintFootStep(this,&local_28,uVar6,0);
            return;
          }
        }
    }

    // Token : 0x6001450
    // RVA   : 0xBA6DE0   Offset: 0xBA55E0   Length: 0xD5
    private void OnDestroy()
    {
        long lVar1;
        bool cVar2;
        ulong uVar3;
        uVar3 = this.skeleton;
        cVar2 = Object.op_Inequality(uVar3,0,0);
        if (cVar2) {
          if (this.skeleton == null) {
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          lVar1 = *(int64 *)(this.skeleton + 224);
          if (lVar1 != null) {
            uVar3 = new OnTooltipCB(this,DAT_181d98358,0);
            AnimationState.remove_Event(lVar1,uVar3,0);
          }
        }
    }

    // Token : 0x6001451
    // RVA   : 0xBA7490   Offset: 0xBA5C90   Length: 0xFF
    public void /*ctor*/()
    {
        long lVar1;
        ulong uVar2;
        lVar1 = il2cpp_internal(DAT_181d721b0);
        FUN_180f58a90(lVar1,DAT_181d79358);
        if (lVar1 != null) {
          FUN_181805690(lVar1,0x3f800000,DAT_181d79458);
          FUN_181805690(lVar1,0x3f800000,DAT_181d79458);
          this.volumn = lVar1;
          uVar2 = il2cpp_internal(DAT_181d6ca30);
          FUN_180f58a90(uVar2,DAT_181d58798);
          this.horseFootBones = uVar2;
          FUN_18044ef50(this,0);
          return;
        }
    }

}
