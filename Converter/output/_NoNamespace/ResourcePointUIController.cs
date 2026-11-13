// ============================================================
// Type  : ResourcePointUIController
// Token : 0x2000355
// ============================================================

public class ResourcePointUIController
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001BBA
    public ResourcePointData resourcePointData;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x600216E
    // RVA   : 0x69FD90   Offset: 0x69EB90   Length: 0x2E4
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
              plVar2 = (int64 *)Component.GetComponent(lVar1,DAT_181e777b8);
              puVar3 = (uint32 *)FUN_180af4e90(&local_18,0);
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
              plVar2 = (int64 *)Component.GetComponent(lVar1,DAT_181e777b8);
              lVar1 = *(int64 *)(DAT_181e538e8 + 184);
              if (plVar2 == (int64 *)0) throw; // [null/range check failed]
              local_18 = *(uint32 *)(lVar1 + 0x2f8);
              uStack_14 = *(uint32 *)(lVar1 + 0x2fc);
              uStack_10 = *(uint32 *)(lVar1 + 0x300);
              uStack_c = *(uint32 *)(lVar1 + 0x304);
              (**(code **)(*plVar2 + 0x2a8))(plVar2,&local_18,*(uint64 *)(*plVar2 + 0x2b0));
            }
            lVar1 = Component.get_transform(this,0);
            if (lVar1 != null) {
              lVar1 = Transform.Find(lVar1,"Icon",0);
              if (lVar1 != null) {
                lVar1 = Component.GetComponent(lVar1,DAT_181e777b8);
                lVar5 = **(int64 **)(DAT_181e8b8e8 + 184);
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
                          lVar1 = Component.GetComponent(lVar1,DAT_181e777b8);
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

    // Token : 0x600216F
    // RVA   : 0x2110A0   Offset: 0x20FEA0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_180ae8740(this,0);
    }

}
