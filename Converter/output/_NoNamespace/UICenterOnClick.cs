// ============================================================
// Type  : UICenterOnClick
// Token : 0x2000039
// ============================================================

public class UICenterOnClick
{
    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60000F1
    // RVA   : 0x13D2CE0   Offset: 0x13D14E0   Length: 0x47C
    private void OnClick()
    {
        ulong uVar1;
        bool cVar3;
        ulong uVar4;
        long lVar5;
        long lVar6;
        long lVar7;
        long lVar8;
        ulong local_38;
        float local_30;
        ulong local_28;
        float local_20;
        byte[] local_18 = new byte[8];
        float local_10;
        uVar4 = Component.get_gameObject(this,0);
        lVar5 = NGUITools.FindInParents(uVar4,DAT_181d66680);
        uVar4 = Component.get_gameObject(this,0);
        lVar6 = NGUITools.FindInParents(uVar4,DAT_181d66900);
        cVar3 = Object.op_Inequality(lVar5,0,0);
        if (!cVar3) {
          cVar3 = Object.op_Inequality(lVar6,0,0);
          if (!cVar3) {
            return;
          }
          if (lVar6 != null) {
            if (*(int *)(lVar6 + 0x134) == 0) {
              return;
            }
            lVar5 = Component.GetComponent(lVar6,DAT_181d6e540);
            lVar7 = UIRect.get_cachedTransform(lVar6,0);
            lVar8 = Component.get_transform(this,0);
            if ((lVar8 != null) &&
               (puVar9 = (uint64 *)Transform.get_position(local_18,lVar8,0), lVar7 != null)) {
              local_38 = *puVar9;
              local_30 = *(float *)(puVar9 + 1);
              puVar10 = (uint64 *)Transform.InverseTransformPoint(local_18,lVar7,&local_38,0);
              local_28 = *puVar10;
              local_20 = (float)puVar10[1];
              local_30 = (float)((uint32)local_20 ^ 0x80000000);
              local_38 = local_28 ^ 0x8000000080000000;
              if (lVar5 != null) {
                cVar3 = UIScrollView.get_canMoveHorizontally(lVar5,0);
                if (!cVar3) {
                  lVar7 = UIRect.get_cachedTransform(lVar6,0);
                  if (lVar7 == null) throw; // [null/range check failed]
                  puVar11 = (uint32 *)Transform.get_localPosition(local_18,lVar7,0);
                  local_38 = CONCAT44(local_38._4_4_,*puVar11);
                }
                cVar3 = UIScrollView.get_canMoveVertically(lVar5,0);
                if (!cVar3) {
                  lVar5 = UIRect.get_cachedTransform(lVar6,0);
                  if (lVar5 == null) throw; // [null/range check failed]
                  puVar10 = (uint64 *)Transform.get_localPosition(local_18,lVar5,0);
                  local_28 = *puVar10;
                  local_20 = (float)puVar10[1];
                  local_38 = CONCAT44((int)(local_28 >> 32),(uint32)local_38);
                }
                uVar4 = UIRect.get_cachedGameObject(lVar6,0);
                local_20 = local_30;
                local_28 = local_38;
                SpringPanel.Begin(uVar4,&local_28,0x40c00000,0);
                return;
              }
            }
          }
        }
        else if (lVar5 != null) {
          cVar3 = Behaviour.get_enabled(lVar5,0);
          if (cVar3) {
            uVar4 = Component.get_transform(this,0);
            uVar1 = *(uint64 *)(lVar5 + 48);
            cVar3 = Object.op_Inequality(uVar1,0,0);
            if (cVar3) {
              if (*(int64 *)(lVar5 + 48) != 0) {
                uVar1 = *(uint64 *)(*(int64 *)(lVar5 + 48) + 152);
                cVar3 = Object.op_Inequality(uVar1,0,0);
                if (!cVar3) {
                  return;
                }
                if (((*(int64 *)(lVar5 + 48) != 0) &&
                    (plVar2 = *(int64 **)(*(int64 *)(lVar5 + 48) + 152),
                    plVar2 != (int64 *)0)) &&
                   (lVar6 = (**(code **)(*plVar2 + 0x1e8))(plVar2,*(uint64 *)(*plVar2 + 0x1f0)),
                   lVar6 != null)) {
                  if (*(uint32 *)(lVar6 + 24) < 3) {
                    uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                    FUN_1800d65f0(uVar4,0);
                  }
                  local_30 = *(float *)(lVar6 + 40);
                  local_20 = (*(float *)(lVar6 + 64) + local_30) * 0.5;
                  local_28 = CONCAT44(((float)((uint64)*(uint64 *)(lVar6 + 56) >> 32) +
                                      (float)((uint64)*(uint64 *)(lVar6 + 32) >> 32)) * 0.5,
                                      ((float)*(uint64 *)(lVar6 + 32) +
                                      (float)*(uint64 *)(lVar6 + 56)) * 0.5);
                  local_10 = local_20;
                  UICenterOnChild.CenterOn(lVar5,uVar4,&local_28,0);
                  return;
                }
              }
              throw; // [null/range check failed]
            }
          }
          return;
        }
    }

    // Token : 0x60000F2
    // RVA   : 0x3A17B0   Offset: 0x39FFB0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_18044ef50(this,0);
    }

}
