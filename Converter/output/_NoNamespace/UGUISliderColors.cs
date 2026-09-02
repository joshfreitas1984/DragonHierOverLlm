// ============================================================
// Type  : UGUISliderColors
// Token : 0x20003A3
// ============================================================

public class UGUISliderColors
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001CC8
    public Image image;

    // Token: 0x4001CC9
    public Color[] colors;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60022DD
    // RVA   : 0xA74F10   Offset: 0xA73710   Length: 0xE6
    private void Start()
    {
        bool cVar1;
        ulong uVar2;
        uVar2 = this.image;
        cVar1 = Object.op_Equality(uVar2,0,0);
        if (cVar1) {
          uVar2 = Component.GetComponent(this,DAT_181d6bc40);
          cVar1 = Object.op_Inequality(uVar2,0,0);
          if (cVar1) {
            uVar2 = Component.GetComponent(this,DAT_181d6bc40);
            this.image = uVar2;
          }
        }
        UGUISliderColors.Update(this,0);
    }

    // Token : 0x60022DE
    // RVA   : 0xA75000   Offset: 0xA73800   Length: 0x22E
    private void Update()
    {
        float fVar1;
        uint uVar2;
        long lVar3;
        bool cVar5;
        uint uVar6;
        uint uVar7;
        long lVar9;
        ulong uVar10;
        long lVar11;
        ulong local_48;
        ulong uStack_40;
        ulong local_38;
        ulong uStack_30;
        byte[] local_28 = new byte[32];
        uVar10 = this.image;
        cVar5 = Object.op_Equality(uVar10,0,0);
        if (cVar5) {
          return;
        }
        if (this.colors != null) {
          lVar9 = *(int64 *)(this.colors + 24);
          if (lVar9 == null) {
            return;
          }
          lVar11 = this.image;
          if (lVar11 != null) {
            fVar1 = *(float *)(lVar11 + 244);
            uVar6 = Mathf.FloorToInt(lVar11,0);
            lVar3 = this.colors;
            lVar11 = (int64)(int)uVar6;
            if (lVar3 != null) {
              uVar2 = *(uint32 *)(lVar3 + 24);
              if (uVar2 == 0) {
                uVar10 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar10,0);
              }
              local_48 = *(uint64 *)(lVar3 + 32);
              uStack_40 = *(uint64 *)(lVar3 + 40);
              if (-1 < (int)uVar6) {
                uVar7 = uVar6 + 1;
                if ((int)uVar7 < (int)uVar2) {
                  if (uVar2 <= uVar6) {
                    uVar10 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                    FUN_1800d65f0(uVar10,0);
                  }
                  if (uVar2 <= uVar7) {
                    uVar10 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                    FUN_1800d65f0(uVar10,0);
                  }
                  puVar8 = (uint64 *)(lVar3 + (lVar11 + 2) * 16);
                  local_38 = *puVar8;
                  uStack_30 = puVar8[1];
                  puVar8 = (uint64 *)(lVar3 + ((int64)(int)uVar7 + 2) * 16);
                  local_48 = *puVar8;
                  uStack_40 = puVar8[1];
                  puVar8 = (uint64 *)
                           Color.Lerp(local_28,&local_38,&local_48,
                                       (float)((int)lVar9 + -1) * fVar1 - (float)(int)uVar6,0);
                  local_48 = *puVar8;
                  uStack_40 = puVar8[1];
                }
                else {
                  if ((int)uVar6 < (int)uVar2) {
                    if (uVar2 <= uVar6) {
                      uVar10 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                      FUN_1800d65f0(uVar10,0);
                    }
                  }
                  else {
                    lVar11 = (int64)(int)uVar2 + -1;
                    if (uVar2 <= (uint32)lVar11) {
                      uVar10 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                      FUN_1800d65f0(uVar10,0);
                    }
                  }
                  puVar8 = (uint64 *)(lVar3 + (lVar11 + 2) * 16);
                  local_48 = *puVar8;
                  uStack_40 = puVar8[1];
                }
              }
              plVar4 = this.image;
              if (plVar4 != (int64 *)0) {
                lVar9 = (**(code **)(*plVar4 + 0x298))(local_28,plVar4,*(uint64 *)(*plVar4 + 0x2a0));
                plVar4 = this.image;
                uStack_40 = CONCAT44(*(uint32 *)(lVar9 + 12),(uint32)uStack_40);
                if (plVar4 != (int64 *)0) {
                  local_38 = local_48;
                  uStack_30 = uStack_40;
                  (**(code **)(*plVar4 + 0x2a8))(plVar4,&local_38,*(uint64 *)(*plVar4 + 0x2b0));
                  return;
                }
              }
            }
          }
        }
    }

    // Token : 0x60022DF
    // RVA   : 0xA75230   Offset: 0xA73A30   Length: 0xE5
    public void /*ctor*/()
    {
        uint uVar1;
        uint uVar2;
        uint uVar3;
        long lVar4;
        ulong uVar6;
        byte[] local_18 = new byte[16];
        lVar4 = FUN_1800d60b0(DAT_181d7c218,3);
        puVar5 = (uint32 *)Color.get_red(local_18,0);
        if (lVar4 == null) {
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
        if (*(int *)(lVar4 + 24) == 0) {
          uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
          FUN_1800d65f0(uVar6,0);
        }
        uVar1 = puVar5[1];
        uVar2 = puVar5[2];
        uVar3 = puVar5[3];
        *(uint32 *)(lVar4 + 32) = *puVar5;
        *(uint32 *)(lVar4 + 36) = uVar1;
        *(uint32 *)(lVar4 + 40) = uVar2;
        *(uint32 *)(lVar4 + 44) = uVar3;
        puVar5 = (uint32 *)Color.get_yellow(local_18,0);
        if (1 < *(uint32 *)(lVar4 + 24)) {
          uVar1 = puVar5[1];
          uVar2 = puVar5[2];
          uVar3 = puVar5[3];
          *(uint32 *)(lVar4 + 48) = *puVar5;
          *(uint32 *)(lVar4 + 52) = uVar1;
          *(uint32 *)(lVar4 + 56) = uVar2;
          *(uint32 *)(lVar4 + 60) = uVar3;
          puVar5 = (uint32 *)Color.get_green(local_18,0);
          if (2 < *(uint32 *)(lVar4 + 24)) {
            uVar1 = puVar5[1];
            uVar2 = puVar5[2];
            uVar3 = puVar5[3];
            *(uint32 *)(lVar4 + 64) = *puVar5;
            *(uint32 *)(lVar4 + 68) = uVar1;
            *(uint32 *)(lVar4 + 72) = uVar2;
            *(uint32 *)(lVar4 + 76) = uVar3;
            this.colors = lVar4;
            FUN_18044ef50(this,0);
            return;
          }
          uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
          FUN_1800d65f0(uVar6,0);
        }
        uVar6 = il2cpp_internal();
    }

}
