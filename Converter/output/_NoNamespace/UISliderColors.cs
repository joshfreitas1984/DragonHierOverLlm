// ============================================================
// Type  : UISliderColors
// Token : 0x2000025
// ============================================================

public class UISliderColors
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4000094
    public UISprite sprite;

    // Token: 0x4000095
    public Color[] colors;

    // Token: 0x4000096
    private UIProgressBar mBar;

    // Token: 0x4000097
    private UIBasicSprite mSprite;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x600007E
    // RVA   : 0x168DB70   Offset: 0x168C370   Length: 0x7C
    private void Start()
    {
        ulong uVar1;
        uVar1 = Component.GetComponent(this,DAT_181d6e3c0);
        this.mBar = uVar1;
        uVar1 = Component.GetComponent(this,DAT_181d6de40);
        this.mSprite = uVar1;
        UISliderColors.Update(this,0);
    }

    // Token : 0x600007F
    // RVA   : 0x168DBF0   Offset: 0x168C3F0   Length: 0x267
    private void Update()
    {
        int iVar2;
        uint uVar3;
        long lVar4;
        bool cVar5;
        uint uVar6;
        uint uVar7;
        ulong uVar9;
        long lVar10;
        float fVar11;
        ulong local_48;
        ulong uStack_40;
        uint local_38;
        uint uStack_34;
        uint uStack_30;
        uint32 uStack_2c;
        uint8 local_28 [32];
        uVar9 = this.sprite;
        cVar5 = Object.op_Equality(uVar9,0,0);
        if (cVar5) {
          return;
        }
        if (this.colors != null) {
          if (*(int64 *)(this.colors + 24) == 0) {
            return;
          }
          uVar9 = this.mBar;
          cVar5 = Object.op_Inequality(uVar9,0,0);
          if (!cVar5) {
            if (this.mSprite == null) throw; // [null/range check failed]
            fVar11 = this.mSprite.mFillAmount;
          }
          else {
            if (this.mBar == null) throw; // [null/range check failed]
            fVar11 = (float)UIProgressBar.get_value(this.mBar,0);
          }
          if (this.colors != null) {
            iVar2 = *(int *)(this.colors + 24);
            uVar6 = Mathf.FloorToInt();
            lVar4 = this.colors;
            lVar10 = (int64)(int)uVar6;
            if (lVar4 != null) {
              uVar3 = *(uint32 *)(lVar4 + 24);
              if (uVar3 == 0) {
                uVar9 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar9,0);
              }
              local_48 = *(uint64 *)(lVar4 + 32);
              uStack_40 = *(uint64 *)(lVar4 + 40);
              if (-1 < (int)uVar6) {
                uVar7 = uVar6 + 1;
                if ((int)uVar7 < (int)uVar3) {
                  if (uVar3 <= uVar6) {
                    uVar9 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                    FUN_1800d65f0(uVar9,0);
                  }
                  if (uVar3 <= uVar7) {
                    uVar9 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                    FUN_1800d65f0(uVar9,0);
                  }
                  puVar1 = (uint32 *)(lVar4 + (lVar10 + 2) * 16);
                  local_38 = *puVar1;
                  uStack_34 = puVar1[1];
                  uStack_30 = puVar1[2];
                  uStack_2c = puVar1[3];
                  puVar8 = (uint64 *)(lVar4 + ((int64)(int)uVar7 + 2) * 16);
                  local_48 = *puVar8;
                  uStack_40 = puVar8[1];
                  puVar8 = (uint64 *)
                           Color.Lerp(local_28,&local_38,&local_48,
                                       (float)(iVar2 + -1) * fVar11 - (float)(int)uVar6,0);
                  local_48 = *puVar8;
                  uStack_40 = puVar8[1];
                }
                else {
                  if ((int)uVar6 < (int)uVar3) {
                    if (uVar3 <= uVar6) {
                      uVar9 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                      FUN_1800d65f0(uVar9,0);
                    }
                  }
                  else {
                    lVar10 = (int64)(int)uVar3 + -1;
                    if (uVar3 <= (uint32)lVar10) {
                      uVar9 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                      FUN_1800d65f0(uVar9,0);
                    }
                  }
                  puVar8 = (uint64 *)(lVar4 + (lVar10 + 2) * 16);
                  local_48 = *puVar8;
                  uStack_40 = puVar8[1];
                }
              }
              lVar10 = this.sprite;
              if (lVar10 != null) {
                uStack_2c = *(uint32 *)(lVar10 + 156);
                local_38 = (uint32)local_48;
                uStack_34 = local_48._4_4_;
                uStack_30 = (uint32)uStack_40;
                UIWidget.set_color(lVar10,&local_38,0);
                return;
              }
            }
          }
        }
    }

    // Token : 0x6000080
    // RVA   : 0x168DE60   Offset: 0x168C660   Length: 0xE5
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
