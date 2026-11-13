// ============================================================
// Type  : InvAttachmentPoint
// Token : 0x200000A
// ============================================================

public class InvAttachmentPoint
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x400001F
    public Slot slot;

    // Token: 0x4000020
    private GameObject mPrefab;

    // Token: 0x4000021
    private GameObject mChild;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000023
    // RVA   : 0xA1D530   Offset: 0xA1C330   Length: 0x2A6
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
              uVar6 = Object.Instantiate(uVar6,&local_48,&local_38,DAT_181e762f8);
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
                  goto LAB_180a1d7b7;
                }
              }
            }
                          // WARNING: Subroutine does not return
            FUN_1801e0300();
          }
        }
        LAB_180a1d7b7:
        return this.mChild;
    }

    // Token : 0x6000024
    // RVA   : 0x2110A0   Offset: 0x20FEA0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_180ae8740(this,0);
    }

}
