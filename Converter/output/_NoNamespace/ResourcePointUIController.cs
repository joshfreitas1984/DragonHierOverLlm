// ============================================================
// Type  : ResourcePointUIController
// Token : 0x2000349
// ============================================================

public class ResourcePointUIController
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001B3E
    public ResourcePointData resourcePointData;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60020CA
    // RVA   : 0x978880   Offset: 0x977C80   Length: 0x2E4
    private void Start()
    {
        long lVar1;
        ulong uVar4;
        long lVar5;
        uint local_18;
        uint uStack_14;
        uint uStack_10;
        uint32 uStack_c;
        if (this.resourcePointData != null) {
          lVar1 = ResourcePointData.GetArea(this.resourcePointData,0);
          if ((lVar1 != null) && (this.resourcePointData != null)) {
            if (*(int *)(lVar1 + 112) == this.resourcePointData.belongForceID) {
              lVar1 = Component.get_transform(this,0);
              if (lVar1 == null) throw; // [null/range check failed]
              lVar1 = Transform.Find(lVar1,"Circle",0);
              if (lVar1 == null) throw; // [null/range check failed]
              plVar2 = (int64 *)Component.GetComponent(lVar1,DAT_181d94478);
              puVar3 = (uint32 *)FUN_180d995f0(&local_18,0);
              if (plVar2 == (int64 *)0) throw; // [null/range check failed]
              local_18 = *puVar3;
              uStack_14 = puVar3[1];
              uStack_10 = puVar3[2];
              uStack_c = puVar3[3];
              (**(code **)(*plVar2 + 0x2a8))(plVar2,&local_18,*(uint64 *)(*plVar2 + 0x2b0));
            }
            else {
              lVar1 = Component.get_transform(this,0);
              if (lVar1 == null) throw; // [null/range check failed]
              lVar1 = Transform.Find(lVar1,"Circle",0);
              if (lVar1 == null) throw; // [null/range check failed]
              plVar2 = (int64 *)Component.GetComponent(lVar1,DAT_181d94478);
              lVar1 = *(int64 *)(DAT_181d73d40 + 184);
              if (plVar2 == (int64 *)0) throw; // [null/range check failed]
              local_18 = *(uint32 *)(lVar1 + 0x2f0);
              uStack_14 = *(uint32 *)(lVar1 + 0x2f4);
              uStack_10 = *(uint32 *)(lVar1 + 0x2f8);
              uStack_c = *(uint32 *)(lVar1 + 0x2fc);
              (**(code **)(*plVar2 + 0x2a8))(plVar2,&local_18,*(uint64 *)(*plVar2 + 0x2b0));
            }
            lVar1 = Component.get_transform(this,0);
            if (lVar1 != null) {
              lVar1 = Transform.Find(lVar1,"Icon",0);
              if (lVar1 != null) {
                lVar1 = Component.GetComponent(lVar1,DAT_181d94478);
                lVar5 = **(int64 **)(DAT_181dab4a8 + 184);
                if (this.resourcePointData != null) {
                  uVar4 = Int32.ToString(this.resourcePointData + 20,0);
                  if (lVar5 != null) {
                    uVar4 = TextureController.LoadAtlasSprite(lVar5,"ResourcePointAtlas",uVar4,0);
                    if (lVar1 != null) {
                      Image.set_sprite(lVar1,uVar4,0);
                      lVar1 = Component.get_transform(this,0);
                      if (lVar1 != null) {
                        lVar1 = Transform.Find(lVar1,"Force",0);
                        if (lVar1 != null) {
                          lVar1 = Component.GetComponent(lVar1,DAT_181d94478);
                          if (this.resourcePointData != null) {
                            lVar5 = ResourcePointData.GetForce(this.resourcePointData,0);
                            if (lVar5 != null) {
                              uVar4 = ForceData.GetForceIcon(lVar5,0);
                              if (lVar1 != null) {
                                Image.set_sprite(lVar1,uVar4,0);
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
            }
          }
        }
    }

    // Token : 0x60020CB
    // RVA   : 0x3A17B0   Offset: 0x3A0BB0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_18044ef50(this,0);
    }

}
