// ============================================================
// Type  : ExampleDragDropItem
// Token : 0x2000017
// ============================================================

public class ExampleDragDropItem
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x400006F
    public GameObject prefab;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000053
    // RVA   : 0x938AF0   Offset: 0x9372F0   Length: 0x337
    protected override void OnDragDropRelease(GameObject surface)
    {
        var pStatics = *(int64*)(DAT_181d8a458 + 184);
        bool cVar1;
        long lVar2;
        ulong uVar3;
        long lVar4;
        long lVar5;
        long lVar6;
        ulong uVar9;
        ulong local_48;
        ulong uStack_40;
        uint local_38;
        uint uStack_34;
        uint uStack_30;
        uint32 uStack_2c;
        uint8 local_28 [32];
        cVar1 = Object.op_Inequality(surface,0,0);
        if (!cVar1) {
        LAB_180938df6:
          UIDragDropItem.OnDragDropRelease(this,surface,0);
          return;
        }
        if (surface != null) {
          lVar2 = GameObject.GetComponent(surface,DAT_181d9f548);
          cVar1 = Object.op_Inequality(lVar2,0,0);
          if (!cVar1) goto LAB_180938df6;
          if (lVar2 != null) {
            uVar3 = Component.get_gameObject(lVar2,0);
            uVar9 = this.prefab;
            lVar4 = NGUITools.AddChild(uVar3,uVar9,0);
            if (lVar4 != null) {
              lVar5 = GameObject.get_transform(lVar4,0);
              lVar6 = Component.get_transform(lVar2,0);
              if ((lVar6 != null) &&
                 (puVar7 = (uint64 *)Transform.get_localScale(&local_38,lVar6,0), lVar5 != null)) {
                local_48 = *puVar7;
                uStack_40 = CONCAT44(uStack_40._4_4_,*(uint32 *)(puVar7 + 1));
                Transform.set_localScale(lVar5,&local_48,0);
                lVar4 = GameObject.get_transform(lVar4,0);
                if (lVar4 != null) {
                  local_48 = *(uint64 *)(pStatics + 100);
                  uStack_40 = CONCAT44(uStack_40._4_4_,
                                       *(uint32 *)(pStatics + 108));
                  Transform.set_position(lVar4,&local_48,0);
                  if (*(char *)(lVar2 + 24) != false) {
                    puVar7 = (uint64 *)
                             FUN_18045e080(&local_38,pStatics + 136,0);
                    local_48 = *puVar7;
                    uStack_40 = CONCAT44(uStack_40._4_4_,*(uint32 *)(puVar7 + 1));
                    puVar7 = (uint64 *)Quaternion.LookRotation(&local_38,&local_48,0);
                    uVar9 = *puVar7;
                    uVar3 = puVar7[1];
                    puVar8 = (uint32 *)Quaternion.Euler(&local_38,0x42b40000,0,0,0);
                    local_38 = *puVar8;
                    uStack_34 = puVar8[1];
                    uStack_30 = puVar8[2];
                    uStack_2c = puVar8[3];
                    local_48 = uVar9;
                    uStack_40 = uVar3;
                    puVar8 = (uint32 *)Quaternion.op_Multiply(local_28,&local_48,&local_38,0);
                    local_38 = *puVar8;
                    uStack_34 = puVar8[1];
                    uStack_30 = puVar8[2];
                    uStack_2c = puVar8[3];
                    Transform.set_rotation(lVar4,&local_38,0);
                  }
                  uVar9 = Component.get_gameObject(this,0);
                  NGUITools.Destroy(uVar9,0);
                  return;
                }
              }
            }
          }
        }
    }

    // Token : 0x6000054
    // RVA   : 0x938E30   Offset: 0x937630   Length: 0x52
    public void /*ctor*/()
    {
        UIDragDropItem.ctor(this,0);
    }

}
