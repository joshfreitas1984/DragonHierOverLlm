// ============================================================
// Type  : Utils
// Token : 0x2000450
// ============================================================

public class Utils
{
    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6002644
    // RVA   : 0x8D8B50   Offset: 0x8D7350   Length: 0x2BD
    public static Vector2 SwitchToRectTransform(RectTransform from, RectTransform to)
    {
        ulong uVar3;
        float fVar4;
        float fVar5;
        float fVar6;
        float fVar7;
        ulong local_res8;
        float local_res20;
        float fStackX_24;
        ulong local_78;
        uint local_70;
        uint local_68;
        uint uStack_64;
        uint uStack_60;
        uint32 uStack_5c;
        local_res8 = 0;
        if (from != null) {
          puVar1 = (uint32 *)RectTransform.get_rect(&local_78,from,0);
          local_68 = *puVar1;
          uStack_64 = puVar1[1];
          uStack_60 = puVar1[2];
          uStack_5c = puVar1[3];
          fVar4 = (float)FUN_180d90480(&local_68,0);
          puVar1 = (uint32 *)RectTransform.get_rect(&local_78,from,0);
          local_68 = *puVar1;
          uStack_64 = puVar1[1];
          uStack_60 = puVar1[2];
          uStack_5c = puVar1[3];
          fVar5 = (float)FUN_180d904a0(&local_68,0);
          puVar1 = (uint32 *)RectTransform.get_rect(&local_78,from,0);
          local_68 = *puVar1;
          uStack_64 = puVar1[1];
          uStack_60 = puVar1[2];
          uStack_5c = puVar1[3];
          fVar6 = (float)FUN_18044e2b0(&local_68,0);
          puVar1 = (uint32 *)RectTransform.get_rect(&local_78,from,0);
          local_68 = *puVar1;
          uStack_64 = puVar1[1];
          uStack_60 = puVar1[2];
          uStack_5c = puVar1[3];
          fVar7 = (float)FUN_18044df60(&local_68,0);
          puVar2 = (uint64 *)Transform.get_position(&local_78,from,0);
          local_78 = *puVar2;
          local_70 = *(uint32 *)(puVar2 + 1);
          uVar3 = RectTransformUtility.WorldToScreenPoint(0,&local_78,0);
          fStackX_24 = (float)((uint64)uVar3 >> 32);
          local_res20 = (float)uVar3;
          RectTransformUtility.ScreenPointToLocalPointInRectangle
                    (to,CONCAT44(fStackX_24 + fVar7 + fVar6 * 0.5,fVar4 * 0.5 + fVar5 + local_res20),
                     0,&local_res8,0);
          if (to != null) {
            puVar1 = (uint32 *)RectTransform.get_rect(&local_78,to,0);
            local_68 = *puVar1;
            uStack_64 = puVar1[1];
            uStack_60 = puVar1[2];
            uStack_5c = puVar1[3];
            fVar4 = (float)FUN_180d90480(&local_68,0);
            puVar1 = (uint32 *)RectTransform.get_rect(&local_78,to,0);
            local_68 = *puVar1;
            uStack_64 = puVar1[1];
            uStack_60 = puVar1[2];
            uStack_5c = puVar1[3];
            fVar5 = (float)FUN_180d904a0(&local_68,0);
            puVar1 = (uint32 *)RectTransform.get_rect(&local_78,to,0);
            local_68 = *puVar1;
            uStack_64 = puVar1[1];
            uStack_60 = puVar1[2];
            uStack_5c = puVar1[3];
            fVar6 = (float)FUN_18044e2b0(&local_68,0);
            puVar1 = (uint32 *)RectTransform.get_rect(&local_78,to,0);
            local_68 = *puVar1;
            uStack_64 = puVar1[1];
            uStack_60 = puVar1[2];
            uStack_5c = puVar1[3];
            fVar7 = (float)FUN_18044df60(&local_68,0);
            uVar3 = RectTransform.get_anchoredPosition(to,0);
            local_res20 = (float)uVar3;
            fStackX_24 = (float)((uint64)uVar3 >> 32);
            return CONCAT44((local_res8._4_4_ + fStackX_24) - (fVar7 + fVar6 * 0.5),
                            ((float)local_res8 + local_res20) - (fVar4 * 0.5 + fVar5));
          }
        }
    }

}
