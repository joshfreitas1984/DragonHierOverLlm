// ============================================================
// Type  : InvAttachmentPoint
// Token : 0x200000A
// ============================================================

public class InvAttachmentPoint
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4000023
    public Slot slot;

    // Token: 0x4000024
    private GameObject mPrefab;

    // Token: 0x4000025
    private GameObject mChild;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000024
    // RVA   : 0xB71360   Offset: 0xB6FB60   Length: 0x2A6
    public GameObject Attach(GameObject prefab)
    {
        ulong uVar1;
        uint uVar2;
        bool cVar3;
        long lVar4;
        ulong uVar6;
        long lVar7;
        ulong local_48;
        uint local_40;
        ulong local_38;
        ulong uStack_30;
        uVar6 = this.mPrefab;
        cVar3 = Object.op_Inequality(uVar6,prefab,0);
        if (cVar3) {
          this.mPrefab = prefab;
          uVar6 = this.mChild;
          cVar3 = Object.op_Inequality(uVar6,0,0);
          if (cVar3) {
            uVar6 = this.mChild;
            Object.Destroy(uVar6,0);
          }
          uVar6 = this.mPrefab;
          cVar3 = Object.op_Inequality(uVar6,0,0);
          if (cVar3) {
            lVar4 = Component.get_transform(this,0);
            uVar6 = this.mPrefab;
            if (lVar4 != null) {
              puVar5 = (uint64 *)Transform.get_position(&local_48,lVar4,0);
              uVar1 = *puVar5;
              uVar2 = *(uint32 *)(puVar5 + 1);
              puVar5 = (uint64 *)Transform.get_rotation(&local_38,lVar4,0);
              local_38 = *puVar5;
              uStack_30 = puVar5[1];
              local_48 = uVar1;
              local_40 = uVar2;
              uVar6 = Object.Instantiate(uVar6,&local_48,&local_38,DAT_181d6a0f8);
              this.mChild = uVar6;
              if (this.mChild != null) {
                lVar7 = GameObject.get_transform(this.mChild,0);
                if (lVar7 != null) {
                  Transform.set_parent(lVar7,lVar4,0);
                  puVar5 = (uint64 *)Vector3.get_zero(&local_38,0);
                  local_48 = *puVar5;
                  local_40 = *(uint32 *)(puVar5 + 1);
                  Transform.set_localPosition(lVar7,&local_48,0);
                  puVar5 = (uint64 *)Quaternion.get_identity(&local_38,0);
                  local_38 = *puVar5;
                  uStack_30 = puVar5[1];
                  Transform.set_localRotation(lVar7,&local_38,0);
                  puVar5 = (uint64 *)Vector3.get_one(&local_38,0);
                  local_48 = *puVar5;
                  local_40 = *(uint32 *)(puVar5 + 1);
                  Transform.set_localScale(lVar7,&local_48,0);
                  goto LAB_180b715e7;
                }
              }
            }
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
        }
        LAB_180b715e7:
        return this.mChild;
    }

    // Token : 0x6000025
    // RVA   : 0x3A17B0   Offset: 0x39FFB0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_18044ef50(this,0);
    }

}
