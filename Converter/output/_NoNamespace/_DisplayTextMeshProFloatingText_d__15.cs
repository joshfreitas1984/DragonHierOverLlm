// ============================================================
// Type  : <DisplayTextMeshProFloatingText>d__15
// Token : 0x2000406
// ============================================================

public class <DisplayTextMeshProFloatingText>d__15
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001EE2
    private int <>1__state;

    // Token: 0x4001EE3
    private object <>2__current;

    // Token: 0x4001EE4
    public TextMeshProFloatingText <>4__this;

    // Token: 0x4001EE5
    private float <CountDuration>5__2;

    // Token: 0x4001EE6
    private float <starting_Count>5__3;

    // Token: 0x4001EE7
    private float <current_Count>5__4;

    // Token: 0x4001EE8
    private Vector3 <start_pos>5__5;

    // Token: 0x4001EE9
    private Color32 <start_color>5__6;

    // Token: 0x4001EEA
    private float <alpha>5__7;

    // Token: 0x4001EEB
    private float <fadeDuration>5__8;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x600248E
    // RVA   : 0x219070   Offset: 0x217870   Length: 0x24
    public void /*ctor*/(int <>1__state)
    {
        ZhSegment.Initialize(this,0);
        this.<>1__state = <>1__state;
    }

    // Token : 0x600248F
    // RVA   : 0x245810   Offset: 0x244010   Length: 0x3
    private virtual void System.IDisposable.Dispose()
    {
    }

    // Token : 0x6002490
    // RVA   : 0xB10090   Offset: 0xB0E890   Length: 0x59C
    private virtual bool MoveNext()
    {
        ulong uVar1;
        int iVar2;
        long lVar3;
        long lVar5;
        uint uVar6;
        uint uVar7;
        bool cVar8;
        uint uVar9;
        ulong uVar10;
        float fVar14;
        uint uVar15;
        float fVar16;
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
          uVar15 = Random.Range(0x40a00000,0x41a00000,0);
          this.<starting_Count>5__3 = uVar15;
          this.<current_Count>5__4 = uVar15;
          if ((lVar3 == null) || (*(int64 *)(lVar3 + 64) == 0)) throw; // [null/range check failed]
          puVar12 = (uint64 *)Transform.get_position(&local_68,*(int64 *)(lVar3 + 64),0);
          this.<start_pos>5__5 = *puVar12;
          *(uint32 *)(this + 60) = *(uint32 *)(puVar12 + 1);
          plVar4 = *(int64 **)(lVar3 + 40);
          if (plVar4 == (int64 *)0) throw; // [null/range check failed]
          puVar11 = (uint32 *)
                    (**(code **)(*plVar4 + 0x298))(&local_68,plVar4,*(uint64 *)(*plVar4 + 0x2a0));
          local_68 = *puVar11;
          uStack_64 = puVar11[1];
          uStack_60 = puVar11[2];
          uStack_5c = puVar11[3];
          uVar15 = Color32.op_Implicit(&local_68,0);
          this.<start_color>5__6 = uVar15;
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
              uVar10 = TextMeshProFloatingText.DisplayTextMeshProFloatingText(lVar3,0);
              FUN_180d837c0(lVar3,uVar10,0);
            }
            return false;
          }
          this.<>1__state = 0xffffffff;
        }
        fVar16 = this.<current_Count>5__4;
        if (fVar16 <= 0.0) {
          lVar3 = *(int64 *)(*(int64 *)(DAT_181d85df0 + 184) + 8);
          uVar9 = FUN_180d8cf10(0,19);
          if (lVar3 != null) {
            if (uVar9 < *(uint32 *)(lVar3 + 24)) {
              this.<>2__current = lVar3[uVar9];
              this.<>1__state = 2;
              return true;
            }
            uVar10 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar10,0);
          }
        }
        else {
          fVar14 = (float)Time.get_deltaTime(0);
          fVar16 = fVar16 - (fVar14 / this.<CountDuration>5__2) * this.<starting_Count>5__3;
          this.<current_Count>5__4 = fVar16;
          if (fVar16 <= 3.0) {
            fVar16 = this.<alpha>5__7;
            fVar14 = (float)Time.get_deltaTime(0);
            uVar15 = FUN_1810a8ba0(fVar16 - (fVar14 / this.<fadeDuration>5__8) * 255.0,0,0x437f0000,0);
            fVar16 = this.<current_Count>5__4;
            this.<alpha>5__7 = uVar15;
          }
          local_res8[0] = (int)fVar16;
          if (lVar3 == null) {
        LAB_180b10617:
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          plVar4 = *(int64 **)(lVar3 + 40);
          uVar10 = Int32.ToString(local_res8,0);
          if (plVar4 == (int64 *)0) goto LAB_180b10617;
          (**(code **)(*plVar4 + 0x558))(plVar4,uVar10,*(uint64 *)(*plVar4 + 0x560));
          plVar4 = *(int64 **)(lVar3 + 40);
          local_res18[0] = 0;
          Color32.ctor(local_res18,this.<start_color>5__6,*(uint8 *)(this + 65),
                        *(uint8 *)(this + 66),(char)(int)this.<alpha>5__7,0);
          puVar11 = (uint32 *)Color32.op_Implicit(&local_68,local_res18[0],0);
          if (plVar4 == (int64 *)0) goto LAB_180b10617;
          local_68 = *puVar11;
          uStack_64 = puVar11[1];
          uStack_60 = puVar11[2];
          uStack_5c = puVar11[3];
          (**(code **)(*plVar4 + 0x2a8))(plVar4,&local_68,*(uint64 *)(*plVar4 + 0x2b0));
          lVar5 = *(int64 *)(lVar3 + 64);
          if (lVar5 == null) goto LAB_180b10617;
          puVar12 = (uint64 *)Transform.get_position(&local_68,lVar5,0);
          fVar16 = this.<starting_Count>5__3;
          uVar10 = *puVar12;
          local_80 = *(float *)(puVar12 + 1);
          fVar14 = (float)Time.get_deltaTime(0);
          local_80 = local_80 + 0.0;
          uStack_70 = CONCAT44(uStack_70._4_4_,local_80);
          local_88 = CONCAT44(fVar14 * fVar16 + (float)((uint64)uVar10 >> 32),(float)uVar10 + 0.0);
          Transform.set_position(lVar5,&local_88,0);
          uVar1 = *(uint64 *)(lVar3 + 80);
          uVar15 = *(uint32 *)(lVar3 + 88);
          if (*(int64 *)(lVar3 + 72) == 0) goto LAB_180b10617;
          puVar13 = (uint64 *)Transform.get_position(&local_68,*(int64 *)(lVar3 + 72),0);
          uStack_70 = CONCAT44(uStack_70._4_4_,uVar15);
          local_88 = *puVar13;
          local_80 = *(float *)(puVar13 + 1);
          local_78 = uVar1;
          cVar8 = TMPro_ExtensionMethods.Compare(&local_78,&local_88,1000,0);
          if (cVar8) {
            uVar1 = *(uint64 *)(lVar3 + 92);
            uVar10 = *(uint64 *)(lVar3 + 100);
            if (*(int64 *)(lVar3 + 72) == 0) throw; // [null/range check failed]
            puVar11 = (uint32 *)Transform.get_rotation(&local_68,*(int64 *)(lVar3 + 72),0);
            local_68 = *puVar11;
            uStack_64 = puVar11[1];
            uStack_60 = puVar11[2];
            uStack_5c = puVar11[3];
            local_78 = uVar1;
            uStack_70 = uVar10;
            cVar8 = TMPro_ExtensionMethods.Compare(&local_78,&local_68,1000,0);
            if (cVar8) goto LAB_180b10536;
          }
          if (*(int64 *)(lVar3 + 72) != 0) {
            puVar12 = (uint64 *)Transform.get_position(&local_68,*(int64 *)(lVar3 + 72),0);
            *(uint64 *)(lVar3 + 80) = *puVar12;
            *(uint32 *)(lVar3 + 88) = *(uint32 *)(puVar12 + 1);
            if (*(int64 *)(lVar3 + 72) != 0) {
              puVar11 = (uint32 *)Transform.get_rotation(&local_68,*(int64 *)(lVar3 + 72),0);
              uVar15 = puVar11[1];
              uVar6 = puVar11[2];
              uVar7 = puVar11[3];
              *(uint32 *)(lVar3 + 92) = *puVar11;
              *(uint32 *)(lVar3 + 96) = uVar15;
              *(uint32 *)(lVar3 + 100) = uVar6;
              *(uint32 *)(lVar3 + 104) = uVar7;
              if (*(int64 *)(lVar3 + 64) != 0) {
                local_68 = *puVar11;
                uStack_64 = puVar11[1];
                uStack_60 = puVar11[2];
                uStack_5c = puVar11[3];
                Transform.set_rotation(*(int64 *)(lVar3 + 64),&local_68,0);
                if (*(int64 *)(lVar3 + 56) != 0) {
                  puVar13 = (uint64 *)Transform.get_position(&local_88,*(int64 *)(lVar3 + 56),0);
                  local_78 = *puVar13;
                  uStack_70 = CONCAT44(uStack_70._4_4_,*(float *)(puVar13 + 1));
                  local_80 = *(float *)(puVar13 + 1) - *(float *)(lVar3 + 88);
                  local_88 = (uint64)(uint32)((float)local_78 - (float)*(uint64 *)(lVar3 + 80));
                  if (*(int64 *)(lVar3 + 56) != 0) {
                    local_78 = local_88;
                    uStack_70 = CONCAT44(uStack_70._4_4_,local_80);
                    Transform.set_forward(*(int64 *)(lVar3 + 56),&local_78,0);
        LAB_180b10536:
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

    // Token : 0x6002491
    // RVA   : 0x20F140   Offset: 0x20D940   Length: 0x5
    private virtual object System.Collections.Generic.IEnumerator<System.object>.get_Current()
    {
        return this.<>2__current;
    }

    // Token : 0x6002492
    // RVA   : 0xB10630   Offset: 0xB0EE30   Length: 0x3E
    private virtual void System.Collections.IEnumerator.Reset()
    {
        ulong uVar1;
        ulong uVar2;
        uVar1 = il2cpp_runtime_class_init(&DAT_181d682e8);
        uVar1 = il2cpp_internal(uVar1);
        NotSupportedException.ctor(uVar1,0);
        uVar2 = il2cpp_runtime_class_init(&DAT_181d8cf78);
    }

    // Token : 0x6002493
    // RVA   : 0x20F140   Offset: 0x20D940   Length: 0x5
    private virtual object System.Collections.IEnumerator.get_Current()
    {
        return this.<>2__current;
    }

}
