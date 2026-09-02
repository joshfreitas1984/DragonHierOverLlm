// ============================================================
// Type  : PlayIdleAnimations
// Token : 0x2000020
// ============================================================

public class PlayIdleAnimations
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4000087
    private Animation mAnim;

    // Token: 0x4000088
    private AnimationClip mIdle;

    // Token: 0x4000089
    private List<AnimationClip> mBreaks;

    // Token: 0x400008A
    private float mNextBreak;

    // Token: 0x400008B
    private int mLastIndex;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x600006F
    // RVA   : 0x478950   Offset: 0x477150   Length: 0x49D
    private void Start()
    {
        int iVar1;
        bool cVar2;
        ulong uVar3;
        long lVar7;
        ushort uVar8;
        ushort uVar9;
        uVar3 = Component.GetComponentInChildren(this,DAT_181d6ea40);
        this.mAnim = uVar3;
        uVar3 = this.mAnim;
        cVar2 = Object.op_Equality(uVar3,0,0);
        if (cVar2) {
          uVar3 = Component.get_gameObject(this,0);
          uVar3 = NGUITools.GetHierarchy(uVar3,0);
          uVar3 = String.Concat(uVar3," has no Animation component",0);
          Debug.LogWarning(uVar3,0);
          if ((*(byte *)(DAT_181d68fe8 + 0x133) & 4) != 0) {
            iVar1 = *(int *)(DAT_181d68fe8 + 224);
        LAB_180478d8e:
            if (iVar1 == 0) {
              il2cpp_runtime_class_init();
            }
          }
        LAB_180478d95:
          Object.Destroy(this,0);
          return;
        }
        if (this.mAnim == null) {
        LAB_180478de8:
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
        plVar4 = (int64 *)Animation.GetEnumerator(this.mAnim,0);
        do {
          if (plVar4 == (int64 *)0) {
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          lVar7 = *plVar4;
          uVar9 = 0;
          if (*(uint16 *)(lVar7 + 0x12a) != 0) {
            uVar8 = uVar9;
            do {
              if (*(int64 *)(*(int64 *)(lVar7 + 176) + (uint64)uVar8 * 16) == DAT_181d544d8) {
                puVar5 = (uint64 *)
                         ((int64)*(int *)(*(int64 *)(lVar7 + 176) + 8 + (uint64)uVar8 * 16) *
                          16 + 0x138 + lVar7);
                goto LAB_180478ac9;
              }
              uVar8 = uVar8 + 1;
            } while (uVar8 < *(uint16 *)(lVar7 + 0x12a));
          }
          puVar5 = (uint64 *)FUN_1800914f0(plVar4,DAT_181d544d8,0);
        LAB_180478ac9:
          cVar2 = (*(code *)*puVar5)(plVar4,puVar5[1]);
          if (!cVar2) {
            lVar7 = il2cpp_internal(plVar4,DAT_181d53c70);
            if (lVar7 != null) {
              FUN_180002970(0,DAT_181d53c70,lVar7);
            }
            if (this.mBreaks == null) goto LAB_180478de8;
            if (this.mBreaks.Count != null) {
              return;
            }
            if ((*(byte *)(DAT_181d68fe8 + 0x133) & 4) == 0) goto LAB_180478d95;
            iVar1 = *(int *)(DAT_181d68fe8 + 224);
            goto LAB_180478d8e;
          }
          lVar7 = *plVar4;
          if (*(uint16 *)(lVar7 + 0x12a) != 0) {
            do {
              if (*(int64 *)(*(int64 *)(lVar7 + 176) + (uint64)uVar9 * 16) == DAT_181d544d8) {
                puVar5 = (uint64 *)
                         ((int64)*(int *)(*(int64 *)(lVar7 + 176) + 8 + (uint64)uVar9 * 16) *
                          16 + 0x148 + lVar7);
                goto LAB_180478b28;
              }
              uVar9 = uVar9 + 1;
            } while (uVar9 < *(uint16 *)(lVar7 + 0x12a));
          }
          puVar5 = (uint64 *)FUN_1800914f0(plVar4,DAT_181d544d8,1);
        LAB_180478b28:
          plVar6 = (int64 *)(*(code *)*puVar5)(plVar4,puVar5[1]);
          if (plVar6 == (int64 *)0) {
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          plVar10 = (int64 *)0;
          if (*plVar6 == DAT_181d86d38) {
            plVar10 = plVar6;
          }
          if (plVar10 == (int64 *)0) {
                          // WARNING: Subroutine does not return
            FUN_1800d6070(plVar6);
          }
          lVar7 = AnimationState.get_clip(plVar10,0);
          if (lVar7 == null) {
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          uVar3 = Object.get_name(lVar7,0);
          cVar2 = FUN_1816fd990(uVar3,"idle",0);
          if (!cVar2) {
            lVar7 = AnimationState.get_clip(plVar10,0);
            if (lVar7 == null) {
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            lVar7 = Object.get_name(lVar7,0);
            if (lVar7 == null) {
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            cVar2 = String.StartsWith(lVar7,"idle",0);
            if (cVar2) {
              AnimationState.set_layer(plVar10,1);
              lVar7 = this.mBreaks;
              uVar3 = AnimationState.get_clip(plVar10,0);
              if (lVar7 == null) {
                          // WARNING: Subroutine does not return
                FUN_1800d6620();
              }
              FUN_181827900(lVar7,uVar3,DAT_181d54460);
            }
          }
          else {
            AnimationState.set_layer(plVar10,0,0);
            uVar3 = AnimationState.get_clip(plVar10,0);
            this.mIdle = uVar3;
            lVar7 = this.mAnim;
            if (this.mIdle == null) {
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            uVar3 = Object.get_name(this.mIdle,0);
            if (lVar7 == null) {
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            Animation.Play(lVar7,uVar3,0);
          }
        } while( true );
    }

    // Token : 0x6000070
    // RVA   : 0x478DF0   Offset: 0x4775F0   Length: 0x180
    private void Update()
    {
        long lVar1;
        uint uVar2;
        ulong uVar3;
        long lVar4;
        float fVar5;
        float fVar6;
        uint uVar7;
        float fVar8;
        uint uVar9;
        fVar6 = this.mNextBreak;
        fVar5 = (float)Time.get_time();
        if (fVar6 < fVar5) {
          lVar4 = this.mBreaks;
          if (lVar4 == null) goto LAB_180478f6b;
          if (lVar4.Count == 1) {
            lVar4 = *(int64 *)(lVar4._items + 32);
            fVar6 = (float)Time.get_time(0);
            if (lVar4 == null) goto LAB_180478f6b;
            fVar5 = (float)AnimationClip.get_length(lVar4,0);
            uVar9 = 0x41700000;
            uVar7 = 0x40a00000;
          }
          else {
            uVar2 = FUN_180d8cf10(0,lVar4.Count + -1,0);
            if (this.mLastIndex == uVar2) {
              uVar2 = uVar2 + 1;
              if (this.mBreaks == null) goto LAB_180478f6b;
              if (this.mBreaks.Count <= (int)uVar2) {
                uVar2 = 0;
              }
            }
            lVar4 = this.mBreaks;
            this.mLastIndex = uVar2;
            if (lVar4 == null) goto LAB_180478f6b;
            if (lVar4.Count <= uVar2) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            lVar4 = lVar4._items[uVar2];
            fVar6 = (float)Time.get_time(0);
            if (lVar4 == null) goto LAB_180478f6b;
            fVar5 = (float)AnimationClip.get_length(lVar4,0);
            uVar9 = 0x41000000;
            uVar7 = 0x40000000;
          }
          fVar8 = (float)Random.Range(uVar7,uVar9,0);
          this.mNextBreak = fVar8 + fVar5 + fVar6;
          lVar1 = this.mAnim;
          uVar3 = Object.get_name(lVar4,0);
          if (lVar1 == null) {
        LAB_180478f6b:
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          Animation.CrossFade(lVar1,uVar3,0);
        }
    }

    // Token : 0x6000071
    // RVA   : 0x478F80   Offset: 0x477780   Length: 0x76
    public void /*ctor*/()
    {
        ulong uVar1;
        uVar1 = il2cpp_internal(DAT_181d6bf30);
        FUN_180f58a90(uVar1,DAT_181d543e8);
        this.mBreaks = uVar1;
        FUN_18044ef50(this,0);
    }

}
