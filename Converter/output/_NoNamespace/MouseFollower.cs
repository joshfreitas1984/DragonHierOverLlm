// ============================================================
// Type  : MouseFollower
// Token : 0x2000123
// ============================================================

public class MouseFollower
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x400073A
    public List<TrailRenderer_Base> Trails;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60009B1
    // RVA   : 0xDF3AA0   Offset: 0xDF2EA0   Length: 0x2F0
    private void Update()
    {
        var pStatics = *(int64*)(DAT_181d7ddf0 + 184);
        uint uVar1;
        ulong uVar2;
        bool cVar3;
        long lVar4;
        long lVar5;
        long lVar8;
        uint local_38;
        uint uStack_34;
        float local_30;
        ulong local_28;
        float local_20;
        cVar3 = Input.GetMouseButton(0,0);
        lVar5 = this.Trails;
        if (!cVar3) {
          lVar4 = *(int64 *)(pStatics + 16);
          if (lVar4 == null) {
            uVar2 = **(uint64 **)(DAT_181d7ddf0 + 184);
            lVar4 = new OnTooltipCB(uVar2,DAT_181da82c8,DAT_181d98728);
            plVar9 = (int64 *)(pStatics + 16);
            *plVar9 = lVar4;
            il2cpp_internal(plVar9,lVar4);
          }
          if (lVar5 != null) {
            FUN_18181f150(lVar5,lVar4,DAT_181da7b98);
            return;
          }
        }
        else {
          lVar4 = *(int64 *)(pStatics + 8);
          if (lVar4 == null) {
            uVar2 = **(uint64 **)(DAT_181d7ddf0 + 184);
            lVar4 = new OnTooltipCB(uVar2,DAT_181da8248,DAT_181d98728);
            plVar9 = (int64 *)(pStatics + 8);
            *plVar9 = lVar4;
            il2cpp_internal(plVar9,lVar4);
          }
          if (lVar5 != null) {
            FUN_18181f150(lVar5,lVar4,DAT_181da7b98);
            lVar5 = Component.get_transform(this,0);
            lVar4 = Camera.get_main(0);
            puVar6 = (uint32 *)Input.get_mousePosition(&local_28,0);
            uVar1 = *puVar6;
            puVar7 = (uint64 *)Input.get_mousePosition(&local_38,0);
            local_20 = *(float *)(puVar7 + 1);
            local_28 = *puVar7;
            lVar8 = Camera.get_main(0);
            if (lVar8 != null) {
              uStack_34 = local_28._4_4_;
              local_38 = uVar1;
              local_30 = (float)Camera.get_nearClipPlane(lVar8,0);
              local_30 = local_30 + 0.01;
              if (lVar4 != null) {
                local_28 = CONCAT44(uStack_34,local_38);
                local_20 = local_30;
                puVar7 = (uint64 *)Camera.ScreenToWorldPoint(&local_38,lVar4,&local_28,0);
                if (lVar5 != null) {
                  local_28 = *puVar7;
                  local_20 = *(float *)(puVar7 + 1);
                  Transform.set_position(lVar5,&local_28,0);
                  return;
                }
              }
            }
          }
        }
    }

    // Token : 0x60009B2
    // RVA   : 0x3A17B0   Offset: 0x3A0BB0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_18044ef50(this,0);
    }

}
