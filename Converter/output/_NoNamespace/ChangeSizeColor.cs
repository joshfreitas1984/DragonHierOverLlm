// ============================================================
// Type  : ChangeSizeColor
// Token : 0x20003CC
// ============================================================

public class ChangeSizeColor
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001E76
    public Gradient color;

    // Token: 0x4001E77
    public Color m_changeColor;

    // Token: 0x4001E78
    public GameObject m_obj;

    // Token: 0x4001E79
    private Renderer[] m_rnds;

    // Token: 0x4001E7A
    private float color_Value;

    // Token: 0x4001E7B
    private bool isChangeColor;

    // Token: 0x4001E7C
    public Image m_ColorHandler;

    // Token: 0x4001E7D
    public Text m_intensityfactor;

    // Token: 0x4001E7E
    private float intensity;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6002412
    // RVA   : 0x993C60   Offset: 0x993060   Length: 0x35A
    private void Update()
    {
        long lVar2;
        long lVar3;
        uint uVar4;
        uint uVar5;
        uint uVar6;
        bool cVar7;
        ulong uVar9;
        long lVar10;
        uint uVar11;
        long lVar12;
        uint uVar13;
        uint local_58;
        uint uStack_54;
        uint uStack_50;
        uint32 uStack_4c;
        uint8 local_48 [16];
        uint8 local_38 [16];
        uint8 local_28 [16];
        if (this.color != null) {
          puVar8 = (uint32 *)
                   Gradient.Evaluate(&local_58,this.color,
                                      this.color_Value,0);
          plVar1 = this.m_ColorHandler;
          uVar4 = puVar8[1];
          uVar5 = puVar8[2];
          uVar6 = puVar8[3];
          this.m_changeColor = *puVar8;
          *(uint32 *)(this + 36) = uVar4;
          *(uint32 *)(this + 40) = uVar5;
          *(uint32 *)(this + 44) = uVar6;
          if (plVar1 != (int64 *)0) {
            local_58 = *puVar8;
            uStack_54 = puVar8[1];
            uStack_50 = puVar8[2];
            uStack_4c = puVar8[3];
            (**(code **)(*plVar1 + 0x2a8))(plVar1,&local_58,*(uint64 *)(*plVar1 + 0x2b0));
            if (this.isChangeColor) {
              uVar9 = this.m_obj;
              cVar7 = Object.op_Inequality(uVar9,0,0);
              if (cVar7) {
                if (this.m_obj != null) {
                  uVar9 = GameObject.GetComponentsInChildren
                                    (this.m_obj,1,DAT_181d75758);
                  this.m_rnds = uVar9;
                  lVar2 = this.m_rnds;
                  uVar13 = 0;
                  if (lVar2 != null) {
                    do {
                      if ((int)*(uint32 *)(lVar2 + 24) <= (int)uVar13) {
                        return;
                      }
                      if (*(uint32 *)(lVar2 + 24) <= uVar13) {
                        uVar9 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                        FUN_1800d65f0(uVar9,0);
                      }
                      uVar11 = 0;
                      lVar3 = lVar2[uVar13];
                      while( true ) {
                        if ((lVar3 == null) || (lVar10 = FUN_180d9dc90(lVar3)) == null)
                        throw; // [null/range check failed]
                        if (*(int *)(lVar10 + 24) <= (int)uVar11) break;
                        lVar10 = FUN_180d9dc90(lVar3,0);
                        if (lVar10 == null) throw; // [null/range check failed]
                        lVar12 = (int64)(int)uVar11;
                        if (*(uint32 *)(lVar10 + 24) <= uVar11) {
                          uVar9 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                          FUN_1800d65f0(uVar9,0);
                        }
                        local_58 = this.m_changeColor;
                        uStack_54 = *(uint32 *)(this + 36);
                        uStack_50 = *(uint32 *)(this + 40);
                        uStack_4c = *(uint32 *)(this + 44);
                        lVar10 = *(int64 *)(lVar10 + 32 + lVar12 * 8);
                        puVar8 = (uint32 *)
                                 FUN_1810d3e90(local_48,&local_58,this.intensity,0);
                        if (lVar10 == null) throw; // [null/range check failed]
                        local_58 = *puVar8;
                        uStack_54 = puVar8[1];
                        uStack_50 = puVar8[2];
                        uStack_4c = puVar8[3];
                        Material.SetColor(lVar10,"_TintColor",&local_58);
                        lVar10 = FUN_180d9dc90(lVar3,0);
                        if (lVar10 == null) throw; // [null/range check failed]
                        if (*(uint32 *)(lVar10 + 24) <= uVar11) {
                          uVar9 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                          FUN_1800d65f0(uVar9,0);
                        }
                        local_58 = this.m_changeColor;
                        uStack_54 = *(uint32 *)(this + 36);
                        uStack_50 = *(uint32 *)(this + 40);
                        uStack_4c = *(uint32 *)(this + 44);
                        lVar10 = *(int64 *)(lVar10 + 32 + lVar12 * 8);
                        puVar8 = (uint32 *)
                                 FUN_1810d3e90(local_38,&local_58,this.intensity,0);
                        if (lVar10 == null) throw; // [null/range check failed]
                        local_58 = *puVar8;
                        uStack_54 = puVar8[1];
                        uStack_50 = puVar8[2];
                        uStack_4c = puVar8[3];
                        Material.SetColor(lVar10,"_Color",&local_58);
                        lVar10 = FUN_180d9dc90(lVar3,0);
                        if (lVar10 == null) throw; // [null/range check failed]
                        if (*(uint32 *)(lVar10 + 24) <= uVar11) {
                          uVar9 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                          FUN_1800d65f0(uVar9,0);
                        }
                        local_58 = this.m_changeColor;
                        uStack_54 = *(uint32 *)(this + 36);
                        uStack_50 = *(uint32 *)(this + 40);
                        uStack_4c = *(uint32 *)(this + 44);
                        lVar10 = *(int64 *)(lVar10 + 32 + lVar12 * 8);
                        puVar8 = (uint32 *)
                                 FUN_1810d3e90(local_28,&local_58,this.intensity,0);
                        if (lVar10 == null) throw; // [null/range check failed]
                        local_58 = *puVar8;
                        uStack_54 = puVar8[1];
                        uStack_50 = puVar8[2];
                        uStack_4c = puVar8[3];
                        Material.SetColor(lVar10,"_RimColor",&local_58);
                        uVar11 = uVar11 + 1;
                      }
                      uVar13 = uVar13 + 1;
                    } while( true );
                  }
                }
                throw; // [null/range check failed]
              }
            }
            return;
          }
        }
    }

    // Token : 0x6002413
    // RVA   : 0x993BC0   Offset: 0x992FC0   Length: 0x6
    public void ChangeEffectColor(float value)
    {
        this.color_Value = value;
    }

    // Token : 0x6002414
    // RVA   : 0x993BE0   Offset: 0x992FE0   Length: 0x4
    public void CheckIsColorChange(bool value)
    {
        void FUN_180993be0(int64 this,uint8 value)
        {
        this.isChangeColor = value;
    }

    // Token : 0x6002415
    // RVA   : 0x993BD0   Offset: 0x992FD0   Length: 0xD
    public void CheckColorState()
    {
        void FUN_180993bd0(int64 this)
        {
        this.isChangeColor = !this.isChangeColor;
    }

    // Token : 0x6002416
    // RVA   : 0x993BF0   Offset: 0x992FF0   Length: 0x6A
    public void GetIntensityFactor()
    {
        ulong uVar2;
        float fVar3;
        plVar1 = this.m_intensityfactor;
        if (plVar1 != (int64 *)0) {
          plVar1 = (int64 *)(**(code **)(*plVar1 + 0x5d8))(plVar1,*(uint64 *)(*plVar1 + 0x5e0));
          if (plVar1 != (int64 *)0) {
            uVar2 = (**(code **)(*plVar1 + 0x168))(plVar1,*(uint64 *)(*plVar1 + 0x170));
            fVar3 = (float)Single.Parse(uVar2,0);
            if (fVar3 <= 0.0) {
              this.intensity = 0;
              return;
            }
            this.intensity = fVar3;
            return;
          }
        }
    }

    // Token : 0x6002417
    // RVA   : 0x993FC0   Offset: 0x9933C0   Length: 0xE
    public void /*ctor*/()
    {
        void FUN_180993fc0(int64 this)
        {
        this.intensity = 0x40000000;
        FUN_18044ef50(this,0);
    }

}
