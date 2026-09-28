// ============================================================
// Type  : UISliderColors
// Token : 0x2000026
// ============================================================

public class UISliderColors
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x40000B0
    public UISprite sprite;

    // Token: 0x40000B1
    public Color[] colors;

    // Token: 0x40000B2
    private UIProgressBar mBar;

    // Token: 0x40000B3
    private UIBasicSprite mSprite;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000096
    // RVA   : 0x1705860   Offset: 0x1704C60   Length: 0x7C
    private void Start()
    {
        ulong uVar1;
        uVar1 = Component.GetComponent(this,DAT_181d96c60);
        this.mBar = uVar1;
        uVar1 = Component.GetComponent(this,DAT_181d966e0);
        this.mSprite = uVar1;
        UISliderColors.Update(this,0);
    }

    // Token : 0x6000097
    // RVA   : 0x17058E0   Offset: 0x1704CE0   Length: 0x292
    private void Update()
    {
        int iVar1;
        uint uVar2;
        long lVar3;
        bool cVar4;
        uint uVar5;
        uint uVar6;
        ulong uVar8;
        long lVar9;
        float fVar10;
        ulong local_48;
        ulong uStack_40;
        ulong local_38;
        ulong uStack_30;
        byte[] local_28 = new byte[32];
        uVar8 = this.sprite;
        cVar4 = Object.op_Equality(uVar8,0,0);
        if (cVar4) {
          return;
        }
        if (this.colors != null) {
          if (*(int64 *)(this.colors + 24) == 0) {
            return;
          }
          uVar8 = this.mBar;
          cVar4 = Object.op_Inequality(uVar8,0,0);
          if (!cVar4) {
            if (this.mSprite == null) throw; // [null/range check failed]
            fVar10 = this.mSprite.mFillAmount;
          }
          else {
            lVar9 = this.mBar;
            if (lVar9 == null) throw; // [null/range check failed]
            fVar10 = *(float *)(lVar9 + 56);
            if (1 < *(int *)(lVar9 + 100)) {
              fVar10 = (float)FUN_18000d7c0((float)(*(int *)(lVar9 + 100) + -1) * fVar10);
              fVar10 = fVar10 / (float)(*(int *)(lVar9 + 100) + -1);
            }
          }
          if (this.colors != null) {
            iVar1 = *(int *)(this.colors + 24);
            uVar5 = Mathf.FloorToInt();
            lVar3 = this.colors;
            lVar9 = (int64)(int)uVar5;
            if (lVar3 != null) {
              uVar2 = *(uint32 *)(lVar3 + 24);
              if (uVar2 == 0) {
                uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar8,0);
              }
              local_48 = *(uint64 *)(lVar3 + 32);
              uStack_40 = *(uint64 *)(lVar3 + 40);
              if (-1 < (int)uVar5) {
                uVar6 = uVar5 + 1;
                if ((int)uVar6 < (int)uVar2) {
                  if (uVar2 <= uVar5) {
                    uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                    FUN_1800d65f0(uVar8,0);
                  }
                  if (uVar2 <= uVar6) {
                    uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                    FUN_1800d65f0(uVar8,0);
                  }
                  puVar7 = (uint64 *)(lVar3 + (lVar9 + 2) * 16);
                  local_38 = *puVar7;
                  uStack_30 = puVar7[1];
                  puVar7 = (uint64 *)(lVar3 + ((int64)(int)uVar6 + 2) * 16);
                  local_48 = *puVar7;
                  uStack_40 = puVar7[1];
                  puVar7 = (uint64 *)
                           Color.Lerp(local_28,&local_38,&local_48,
                                       (float)(iVar1 + -1) * fVar10 - (float)(int)uVar5,0);
                  local_48 = *puVar7;
                  uStack_40 = puVar7[1];
                }
                else {
                  if ((int)uVar5 < (int)uVar2) {
                    if (uVar2 <= uVar5) {
                      uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                      FUN_1800d65f0(uVar8,0);
                    }
                  }
                  else {
                    lVar9 = (int64)(int)uVar2 + -1;
                    if (uVar2 <= (uint32)lVar9) {
                      uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                      FUN_1800d65f0(uVar8,0);
                    }
                  }
                  puVar7 = (uint64 *)(lVar3 + (lVar9 + 2) * 16);
                  local_48 = *puVar7;
                  uStack_40 = puVar7[1];
                }
              }
              lVar9 = this.sprite;
              if (lVar9 != null) {
                local_38 = local_48;
                uStack_30 = CONCAT44(*(uint32 *)(lVar9 + 156),(int)uStack_40);
                UIWidget.set_color(lVar9,&local_38,0);
                return;
              }
            }
          }
        }
    }

    // Token : 0x6000098
    // RVA   : 0x1705B80   Offset: 0x1704F80   Length: 0xE5
    public void /*ctor*/()
    {
        uint uVar1;
        uint uVar2;
        uint uVar3;
        long lVar4;
        ulong uVar6;
        byte[] local_18 = new byte[16];
        lVar4 = FUN_1800d60b0(DAT_181da1140,3);
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
