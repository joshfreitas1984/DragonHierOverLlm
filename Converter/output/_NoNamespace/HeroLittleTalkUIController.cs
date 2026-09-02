// ============================================================
// Type  : HeroLittleTalkUIController
// Token : 0x20002CC
// ============================================================

public class HeroLittleTalkUIController
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001691
    public GameObject followTarget;

    // Token: 0x4001692
    public Vector3 offSet;

    // Token: 0x4001693
    public TalkTextPosType posType;

    // Token: 0x4001694
    public float lifeTime;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60017B0
    // RVA   : 0xB36D40   Offset: 0xB35540   Length: 0x4CB
    private void Update()
    {
        int iVar1;
        ulong uVar2;
        bool cVar3;
        int iVar4;
        ulong uVar5;
        ulong uVar7;
        long lVar8;
        long lVar9;
        float fVar12;
        float fVar13;
        float fVar14;
        float fVar15;
        float fVar16;
        ulong local_c8;
        float local_c0;
        ulong local_b8;
        float local_b0;
        byte[] local_a8 = new byte[16];
        byte[] local_98 = new byte[16];
        uint local_88;
        uint uStack_84;
        uint uStack_80;
        uint32 uStack_7c;
        fVar15 = this.lifeTime;
        if (0.0 < fVar15) {
          fVar12 = (float)RealTime.get_deltaTime(0);
          fVar15 = fVar15 - fVar12;
          this.lifeTime = fVar15;
          if (fVar15 <= 0.0) {
            uVar5 = Component.get_transform(this,0);
            puVar6 = (uint64 *)Vector3.get_zero(local_a8,0);
            local_c0 = *(float *)(puVar6 + 1);
            local_c8 = *puVar6;
            uVar5 = ShortcutExtensions.DOScale(uVar5,&local_c8,0x3e19999a,0);
            uVar7 = new OnTooltipCB(this,DAT_181d50410,0);
            TweenSettingsExtensions.OnComplete(uVar5,uVar7,DAT_181d96ee8);
          }
        }
        uVar5 = this.followTarget;
        cVar3 = Object.op_Inequality(uVar5,0,0);
        if (cVar3) {
          lVar8 = Component.get_transform(this,0);
          if (lVar8 != null) {
            lVar8 = Transform.GetChild(lVar8,0,0);
            if (this.posType == null) {
              local_b0 = 0.0;
              uVar5 = 0x4334000000000000;
              fVar15 = 0.0;
            }
            else {
              puVar6 = (uint64 *)Vector3.get_zero(local_a8,0);
              uVar5 = *puVar6;
              fVar15 = *(float *)(puVar6 + 1);
            }
            if (lVar8 != null) {
              local_c8 = uVar5;
              local_c0 = fVar15;
              Transform.set_eulerAngles(lVar8,&local_c8,0);
              lVar8 = Component.get_transform(this,0);
              if ((lVar8 != null) && (lVar8 = Transform.GetChild(lVar8,0,0)) != null) {
                lVar8 = Transform.GetChild(lVar8,0,0);
                puVar6 = (uint64 *)Vector3.get_zero(local_a8,0);
                if (lVar8 != null) {
                  local_c0 = *(float *)(puVar6 + 1);
                  local_c8 = *puVar6;
                  Transform.set_eulerAngles(lVar8,&local_c8,0);
                  lVar8 = Component.get_transform(this,0);
                  if ((this.followTarget != null) &&
                     (lVar9 = GameObject.get_transform(this.followTarget,0)) != null) {
                    local_b0 = *(float *)(this + 40);
                    uVar5 = this.offSet;
                    puVar6 = (uint64 *)Transform.get_position(local_98,lVar9,0);
                    local_c8 = *puVar6;
                    local_c0 = *(float *)(puVar6 + 1);
                    fVar15 = (float)local_c8;
                    uVar2 = (uint64)local_c8 >> 32;
                    fVar12 = local_c0 + local_b0;
                    local_b8 = uVar5;
                    lVar9 = Component.get_transform(this,0);
                    if ((lVar9 != null) && (lVar9 = Transform.Find(lVar9,"Back",0)) != null) {
                      pfVar10 = (float *)Transform.get_lossyScale(local_98,lVar9,0);
                      iVar1 = this.posType;
                      fVar16 = *pfVar10 * 0.5;
                      lVar9 = Component.get_transform(this,0);
                      if (((lVar9 != null) && (lVar9 = Transform.Find(lVar9,"Back",0)) != null)
                         && (lVar9 = Component.GetComponent(lVar9,DAT_181d6c740)) != null) {
                        puVar11 = (uint32 *)RectTransform.get_rect(local_98,lVar9,0);
                        local_88 = *puVar11;
                        uStack_84 = puVar11[1];
                        uStack_80 = puVar11[2];
                        uStack_7c = puVar11[3];
                        fVar13 = (float)FUN_180d90480(&local_88,0);
                        lVar9 = Component.get_transform(this,0);
                        if (((lVar9 != null) && (lVar9 = Transform.Find(lVar9,"Back",0)) != null)
                           && (lVar9 = Component.GetComponent(lVar9,DAT_181d6c740)) != null) {
                          puVar11 = (uint32 *)RectTransform.get_rect(local_98,lVar9,0);
                          local_88 = *puVar11;
                          uStack_84 = puVar11[1];
                          uStack_80 = puVar11[2];
                          uStack_7c = puVar11[3];
                          iVar4 = -1;
                          if (iVar1 != 0) {
                            iVar4 = 1;
                          }
                          fVar14 = (float)FUN_18044e2b0(&local_88,0);
                          local_c0 = fVar16 * 0.0 + fVar12;
                          local_c8 = CONCAT44(fVar16 * fVar14 +
                                              (float)uVar2 + (float)((uint64)uVar5 >> 32),
                                              fVar16 * (float)iVar4 * fVar13 + (float)uVar5 + fVar15);
                          if (lVar8 != null) {
                            local_b8 = local_c8;
                            local_b0 = local_c0;
                            Transform.set_position(lVar8,&local_b8,0);
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
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
    }

    // Token : 0x60017B1
    // RVA   : 0xB37210   Offset: 0xB35A10   Length: 0xE
    public void /*ctor*/()
    {
        void FUN_180b37210(int64 this)
        {
        this.lifeTime = 0xbf800000;
        FUN_18044ef50(this,0);
    }

    // Token : 0x60017B2
    // RVA   : 0xB36CE0   Offset: 0xB354E0   Length: 0x5F
    private void <Update>b__4_0()
    {
        ulong uVar1;
        uVar1 = Component.get_gameObject(this,0);
        Object.Destroy(uVar1,0);
    }

}
