// ============================================================
// Type  : <DisplayTextMeshFloatingText>d__16
// Token : 0x2000407
// ============================================================

public class <DisplayTextMeshFloatingText>d__16
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001EEC
    private int <>1__state;

    // Token: 0x4001EED
    private object <>2__current;

    // Token: 0x4001EEE
    public TextMeshProFloatingText <>4__this;

    // Token: 0x4001EEF
    private float <CountDuration>5__2;

    // Token: 0x4001EF0
    private float <starting_Count>5__3;

    // Token: 0x4001EF1
    private float <current_Count>5__4;

    // Token: 0x4001EF2
    private Vector3 <start_pos>5__5;

    // Token: 0x4001EF3
    private Color32 <start_color>5__6;

    // Token: 0x4001EF4
    private float <alpha>5__7;

    // Token: 0x4001EF5
    private float <fadeDuration>5__8;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6002494
    // RVA   : 0x219070   Offset: 0x217870   Length: 0x24
    public void /*ctor*/(int <>1__state)
    {
        ZhSegment.Initialize(this,0);
        this.<>1__state = <>1__state;
    }

    // Token : 0x6002495
    // RVA   : 0x245810   Offset: 0x244010   Length: 0x3
    private virtual void System.IDisposable.Dispose()
    {
    }

    // Token : 0x6002496
    // RVA   : 0xB0FAC0   Offset: 0xB0E2C0   Length: 0x582
    private virtual bool MoveNext()
    {
        ulong uVar1;
        int iVar2;
        long lVar3;
        long lVar4;
        uint uVar5;
        uint uVar6;
        bool cVar7;
        uint uVar8;
        ulong uVar9;
        float fVar13;
        uint uVar14;
        float fVar15;
        int[] local_res8 = new int[2];
        uint[] local_res18 = new uint[4];
        ulong local_88;
        float local_80;
        ulong local_78;
        ulong uStack_70;
        uint local_68;
        uint uStack_64;
        uint uStack_60;
        uint32 uStack_5c;
        iVar2 = this.<>1__state;
        lVar3 = this.<>4__this;
        local_res8[0] = 0;
        if (iVar2 == 0) {
          this.<>1__state = 0xffffffff;
          this.<CountDuration>5__2 = 0x40000000;
          uVar14 = Random.Range(0x40a00000,0x41a00000,0);
          this.<starting_Count>5__3 = uVar14;
          this.<current_Count>5__4 = uVar14;
          if ((lVar3 == null) || (*(int64 *)(lVar3 + 64) == 0)) throw; // [null/range check failed]
          puVar11 = (uint64 *)Transform.get_position(&local_68,*(int64 *)(lVar3 + 64),0);
          this.<start_pos>5__5 = *puVar11;
          *(uint32 *)(this + 60) = *(uint32 *)(puVar11 + 1);
          if (*(int64 *)(lVar3 + 48) == 0) throw; // [null/range check failed]
          puVar10 = (uint32 *)TextMesh.get_color(&local_68,*(int64 *)(lVar3 + 48),0);
          local_68 = *puVar10;
          uStack_64 = puVar10[1];
          uStack_60 = puVar10[2];
          uStack_5c = puVar10[3];
          uVar14 = Color32.op_Implicit(&local_68,0);
          this.<start_color>5__6 = uVar14;
          this.<alpha>5__7 = 0x437f0000;
          this.<fadeDuration>5__8 = (3.0 / this.<starting_Count>5__3) * this.<CountDuration>5__2;
        }
        else {
          if (iVar2 != 1) {
            if (iVar2 == 2) {
              this.<>1__state = 0xffffffff;
              if ((lVar3 == null) || (*(int64 *)(lVar3 + 64) == 0)) throw; // [null/range check failed]
              local_88 = this.<start_pos>5__5;
              local_80 = *(float *)(this + 60);
              Transform.set_position(*(int64 *)(lVar3 + 64),&local_88,0);
              uVar9 = TextMeshProFloatingText.DisplayTextMeshFloatingText(lVar3,0);
              FUN_180d837c0(lVar3,uVar9,0);
            }
            return false;
          }
          this.<>1__state = 0xffffffff;
        }
        fVar15 = this.<current_Count>5__4;
        if (fVar15 <= 0.0) {
          lVar3 = *(int64 *)(*(int64 *)(DAT_181d85df0 + 184) + 8);
          uVar8 = FUN_180d8cf10(0,20);
          if (lVar3 != null) {
            if (uVar8 < *(uint32 *)(lVar3 + 24)) {
              this.<>2__current = lVar3[uVar8];
              this.<>1__state = 2;
              return true;
            }
            uVar9 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar9,0);
          }
        }
        else {
          fVar13 = (float)Time.get_deltaTime(0);
          fVar15 = fVar15 - (fVar13 / this.<CountDuration>5__2) * this.<starting_Count>5__3;
          this.<current_Count>5__4 = fVar15;
          if (fVar15 <= 3.0) {
            fVar15 = this.<alpha>5__7;
            fVar13 = (float)Time.get_deltaTime(0);
            uVar14 = FUN_1810a8ba0(fVar15 - (fVar13 / this.<fadeDuration>5__8) * 255.0,0,0x437f0000,0);
            fVar15 = this.<current_Count>5__4;
            this.<alpha>5__7 = uVar14;
          }
          local_res8[0] = (int)fVar15;
          if (lVar3 == null) {
        LAB_180b1002d:
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          lVar4 = *(int64 *)(lVar3 + 48);
          uVar9 = Int32.ToString(local_res8,0);
          if (lVar4 == null) goto LAB_180b1002d;
          TextMesh.set_text(lVar4,uVar9,0);
          lVar4 = *(int64 *)(lVar3 + 48);
          local_res18[0] = 0;
          Color32.ctor(local_res18,this.<start_color>5__6,*(uint8 *)(this + 65),
                        *(uint8 *)(this + 66),(char)(int)this.<alpha>5__7,0);
          puVar10 = (uint32 *)Color32.op_Implicit(&local_68,local_res18[0],0);
          if (lVar4 == null) goto LAB_180b1002d;
          local_68 = *puVar10;
          uStack_64 = puVar10[1];
          uStack_60 = puVar10[2];
          uStack_5c = puVar10[3];
          TextMesh.set_color(lVar4,&local_68,0);
          lVar4 = *(int64 *)(lVar3 + 64);
          if (lVar4 == null) goto LAB_180b1002d;
          puVar11 = (uint64 *)Transform.get_position(&local_68,lVar4,0);
          fVar15 = this.<starting_Count>5__3;
          uVar9 = *puVar11;
          local_80 = *(float *)(puVar11 + 1);
          fVar13 = (float)Time.get_deltaTime(0);
          local_80 = local_80 + 0.0;
          uStack_70 = CONCAT44(uStack_70._4_4_,local_80);
          local_88 = CONCAT44(fVar13 * fVar15 + (float)((uint64)uVar9 >> 32),(float)uVar9 + 0.0);
          Transform.set_position(lVar4,&local_88,0);
          uVar1 = *(uint64 *)(lVar3 + 80);
          uVar14 = *(uint32 *)(lVar3 + 88);
          if (*(int64 *)(lVar3 + 72) == 0) goto LAB_180b1002d;
          puVar12 = (uint64 *)Transform.get_position(&local_68,*(int64 *)(lVar3 + 72),0);
          uStack_70 = CONCAT44(uStack_70._4_4_,uVar14);
          local_88 = *puVar12;
          local_80 = *(float *)(puVar12 + 1);
          local_78 = uVar1;
          cVar7 = TMPro_ExtensionMethods.Compare(&local_78,&local_88,1000,0);
          if (cVar7) {
            uVar1 = *(uint64 *)(lVar3 + 92);
            uVar9 = *(uint64 *)(lVar3 + 100);
            if (*(int64 *)(lVar3 + 72) == 0) throw; // [null/range check failed]
            puVar10 = (uint32 *)Transform.get_rotation(&local_68,*(int64 *)(lVar3 + 72),0);
            local_68 = *puVar10;
            uStack_64 = puVar10[1];
            uStack_60 = puVar10[2];
            uStack_5c = puVar10[3];
            local_78 = uVar1;
            uStack_70 = uVar9;
            cVar7 = TMPro_ExtensionMethods.Compare(&local_78,&local_68,1000,0);
            if (cVar7) goto LAB_180b0ff4c;
          }
          if (*(int64 *)(lVar3 + 72) != 0) {
            puVar11 = (uint64 *)Transform.get_position(&local_68,*(int64 *)(lVar3 + 72),0);
            *(uint64 *)(lVar3 + 80) = *puVar11;
            *(uint32 *)(lVar3 + 88) = *(uint32 *)(puVar11 + 1);
            if (*(int64 *)(lVar3 + 72) != 0) {
              puVar10 = (uint32 *)Transform.get_rotation(&local_68,*(int64 *)(lVar3 + 72),0);
              uVar14 = puVar10[1];
              uVar5 = puVar10[2];
              uVar6 = puVar10[3];
              *(uint32 *)(lVar3 + 92) = *puVar10;
              *(uint32 *)(lVar3 + 96) = uVar14;
              *(uint32 *)(lVar3 + 100) = uVar5;
              *(uint32 *)(lVar3 + 104) = uVar6;
              if (*(int64 *)(lVar3 + 64) != 0) {
                local_68 = *puVar10;
                uStack_64 = puVar10[1];
                uStack_60 = puVar10[2];
                uStack_5c = puVar10[3];
                Transform.set_rotation(*(int64 *)(lVar3 + 64),&local_68,0);
                if (*(int64 *)(lVar3 + 56) != 0) {
                  puVar12 = (uint64 *)Transform.get_position(&local_88,*(int64 *)(lVar3 + 56),0);
                  local_78 = *puVar12;
                  uStack_70 = CONCAT44(uStack_70._4_4_,*(float *)(puVar12 + 1));
                  local_80 = *(float *)(puVar12 + 1) - *(float *)(lVar3 + 88);
                  local_88 = (uint64)(uint32)((float)local_78 - (float)*(uint64 *)(lVar3 + 80));
                  if (*(int64 *)(lVar3 + 56) != 0) {
                    local_78 = local_88;
                    uStack_70 = CONCAT44(uStack_70._4_4_,local_80);
                    Transform.set_forward(*(int64 *)(lVar3 + 56),&local_78,0);
        LAB_180b0ff4c:
                    this.<>2__current = **(uint64 **)(DAT_181d85df0 + 184);
                    this.<>1__state = 1;
                    return true;
                  }
                }
              }
            }
          }
        }
    }

    // Token : 0x6002497
    // RVA   : 0x20F140   Offset: 0x20D940   Length: 0x5
    private virtual object System.Collections.Generic.IEnumerator<System.object>.get_Current()
    {
        return this.<>2__current;
    }

    // Token : 0x6002498
    // RVA   : 0xB10050   Offset: 0xB0E850   Length: 0x3E
    private virtual void System.Collections.IEnumerator.Reset()
    {
        ulong uVar1;
        ulong uVar2;
        uVar1 = il2cpp_runtime_class_init(&DAT_181d682e8);
        uVar1 = il2cpp_internal(uVar1);
        NotSupportedException.ctor(uVar1,0);
        uVar2 = il2cpp_runtime_class_init(&DAT_181d8cef0);
    }

    // Token : 0x6002499
    // RVA   : 0x20F140   Offset: 0x20D940   Length: 0x5
    private virtual object System.Collections.IEnumerator.get_Current()
    {
        return this.<>2__current;
    }

}
