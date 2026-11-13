// ============================================================
// Type  : <SortHeroLittleTalk>d__13
// Token : 0x20002DA
// ============================================================

public class <SortHeroLittleTalk>d__13
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001797
    private int <>1__state;

    // Token: 0x4001798
    private object <>2__current;

    // Token: 0x4001799
    public LittleTalkData targetTalkData;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x600186A
    // RVA   : 0x608BA0   Offset: 0x6079A0   Length: 0x24
    public void /*ctor*/(int <>1__state)
    {
        ZhSegment.Initialize(this,0);
        this.<>1__state = <>1__state;
    }

    // Token : 0x600186B
    // RVA   : 0x51CF50   Offset: 0x51BD50   Length: 0x3
    private virtual void System.IDisposable.Dispose()
    {
    }

    // Token : 0x600186C
    // RVA   : 0x613C60   Offset: 0x612A60   Length: 0x509
    private virtual bool MoveNext()
    {
        bool cVar1;
        ulong uVar2;
        long lVar4;
        ulong uVar5;
        long lVar6;
        uint uVar7;
        uint uVar8;
        float fVar9;
        float fVar10;
        float fVar11;
        uint[] local_res8 = new uint[2];
        ulong local_a8;
        float local_a0;
        byte[] local_88 = new byte[8];
        float local_80;
        ulong local_68;
        ulong uStack_60;
        byte[] local_58 = new byte[64];
        uVar7 = this.<>1__state;
        uVar5 = (uint64)uVar7;
        local_68 = 0;
        uStack_60 = 0;
        if (uVar7 == 0) {
          this.<>1__state = 0xffffffff;
          local_res8[0] = 1;
          uVar2 = il2cpp_value_box(DAT_181e60808,local_res8);
          this.<>2__current = uVar2;
          this.<>1__state = 1;
          return true;
        }
        if (uVar7 != 1) goto LAB_180614118;
        this.<>1__state = 0xffffffff;
        puVar3 = (uint64 *)Vector3.get_zero(local_88,0);
        local_a8 = *puVar3;
        fVar11 = (float)local_a8;
        fVar9 = (float)((uint64)local_a8 >> 32);
        fVar10 = *(float *)(puVar3 + 1);
        if ((this.targetTalkData == null) ||
           (lVar4 = this.targetTalkData.littleTalks) == null) goto LAB_180614164;
        if (*(int *)(lVar4 + 24) < 1) {
        LAB_180613e60:
          uVar8 = 1;
        }
        else {
          if (*(int *)(lVar4 + 24) == 0) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          uVar2 = *(uint64 *)(*(int64 *)(lVar4 + 16) + 32);
          cVar1 = Object.op_Inequality(uVar2,0,0);
          if (!cVar1) goto LAB_180613e60;
          if ((this.targetTalkData == null) ||
             (lVar4 = this.targetTalkData.littleTalks) == null)
          goto LAB_180614164;
          if (*(int *)(lVar4 + 24) == 0) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          lVar4 = *(int64 *)(*(int64 *)(lVar4 + 16) + 32);
          if (lVar4 == null) goto LAB_180614164;
          lVar4 = GameObject.GetComponent(lVar4,DAT_181e54d28);
          if (lVar4 == null) goto LAB_180614164;
          uVar8 = *(uint32 *)(lVar4 + 44);
        }
        uVar5 = this.targetTalkData;
        if ((uVar5 == 0) || (uVar5.littleTalks == null)) {
        LAB_180614164:
                          // WARNING: Subroutine does not return
          FUN_1801e0300();
        }
        uVar7 = *(int *)(uVar5.littleTalks + 24) - 1;
        if (-1 < (int)uVar7) {
          lVar4 = (int64)(int)uVar7 * 8 + 32;
          local_a0 = fVar10;
          do {
            if ((this.targetTalkData == null) ||
               (lVar6 = this.targetTalkData.littleTalks) == null)
            goto LAB_180614164;
            if (lVar6.littleTalks <= uVar7) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            uVar2 = *(uint64 *)(lVar4 + lVar6.target);
            cVar1 = Object.op_Inequality(uVar2,0,0);
            lVar6 = this.targetTalkData;
            if (!cVar1) {
              if ((lVar6 == null) || (lVar6.littleTalks == null)) goto LAB_180614164;
              uVar5 = FUN_181763390();
            }
            else {
              if ((lVar6 == null) || (lVar6.littleTalks == null)) goto LAB_180614164;
              lVar6 = FUN_1800024b0(lVar6.littleTalks,uVar7,DAT_181e6bc70);
              if (lVar6 == null) goto LAB_180614164;
              lVar6 = GameObject.GetComponent(lVar6,DAT_181e54d28);
              if (lVar6 == null) goto LAB_180614164;
              *(uint32 *)(lVar6 + 44) = uVar8;
              if ((this.targetTalkData == null) ||
                 (lVar6 = this.targetTalkData.littleTalks) == null)
              goto LAB_180614164;
              lVar6 = FUN_1800024b0(lVar6,uVar7,DAT_181e6bc70);
              if (lVar6 == null) goto LAB_180614164;
              lVar6 = GameObject.GetComponent(lVar6,DAT_181e54d28);
              if (lVar6 == null) goto LAB_180614164;
              *(uint64 *)(lVar6 + 32) = CONCAT44(fVar9,fVar11);
              *(float *)(lVar6 + 40) = fVar10;
              if ((this.targetTalkData == null) ||
                 (lVar6 = this.targetTalkData.littleTalks) == null)
              goto LAB_180614164;
              lVar6 = FUN_1800024b0(lVar6,uVar7,DAT_181e6bc70);
              if (lVar6 == null) goto LAB_180614164;
              lVar6 = GameObject.get_transform(lVar6,0);
              if (lVar6 == null) goto LAB_180614164;
              lVar6 = Transform.Find(lVar6,"Back",0);
              if (lVar6 == null) goto LAB_180614164;
              lVar6 = Component.GetComponent(lVar6,DAT_181e782b8);
              if (lVar6 == null) goto LAB_180614164;
              puVar3 = (uint64 *)RectTransform.get_rect(local_58,lVar6,0);
              local_68 = *puVar3;
              uStack_60 = puVar3[1];
              fVar9 = (float)FUN_180af4db0(&local_68,0);
              if ((this.targetTalkData == null) ||
                 (lVar6 = this.targetTalkData.littleTalks) == null)
              goto LAB_180614164;
              lVar6 = FUN_1800024b0(lVar6,uVar7);
              if (lVar6 == null) goto LAB_180614164;
              lVar6 = GameObject.get_transform(lVar6,0);
              if (lVar6 == null) goto LAB_180614164;
              lVar6 = FUN_180b05920(lVar6,0);
              if (lVar6 == null) goto LAB_180614164;
              uVar5 = Transform.get_lossyScale();
              fVar10 = local_a0 + 0.0;
              fVar11 = (float)local_a8 + 0.0;
              fVar9 = (fVar9 - 6.0) * *(float *)(uVar5 + 4) + local_a8._4_4_;
              local_a8 = CONCAT44(fVar9,fVar11);
              local_a0 = fVar10;
              local_80 = fVar10;
            }
            lVar4 = lVar4 + -8;
            uVar7 = uVar7 - 1;
          } while (-1 < (int)uVar7);
        }
        LAB_180614118:
        return uVar5 & 0xffffffffffffff00;
    }

    // Token : 0x600186D
    // RVA   : 0x608B50   Offset: 0x607950   Length: 0x5
    private virtual object System.Collections.Generic.IEnumerator<System.object>.get_Current()
    {
        return this.<>2__current;
    }

    // Token : 0x600186E
    // RVA   : 0x614170   Offset: 0x612F70   Length: 0x3E
    private virtual void System.Collections.IEnumerator.Reset()
    {
        ulong uVar1;
        ulong uVar2;
        uVar1 = il2cpp_runtime_class_init(&DAT_181e6d8e8);
        uVar1 = il2cpp_internal(uVar1);
        NotSupportedException.ctor(uVar1,0);
        uVar2 = il2cpp_runtime_class_init(&DAT_181e893a0);
    }

    // Token : 0x600186F
    // RVA   : 0x608B50   Offset: 0x607950   Length: 0x5
    private virtual object System.Collections.IEnumerator.get_Current()
    {
        return this.<>2__current;
    }

}
