// ============================================================
// Type  : ResourcePointUIController
// Token : 0x2000342
// ============================================================

public class ResourcePointUIController
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001A3C
    public ResourcePointData resourcePointData;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6002049
    // RVA   : 0xC66280   Offset: 0xC64A80   Length: 0x35F
    private void Start()
    {
        var pStatics = *(int64*)(DAT_181d86270 + 184);
        uint uVar1;
        long lVar2;
        long lVar3;
        ulong uVar6;
        long lVar7;
        uint local_18;
        uint uStack_14;
        uint uStack_10;
        uint32 uStack_c;
        if (this.resourcePointData != null) {
          lVar3 = ResourcePointData.GetArea(this.resourcePointData,0);
          if ((lVar3 != null) && (this.resourcePointData != null)) {
            if (*(int *)(lVar3 + 112) == this.resourcePointData.belongForceID) {
              lVar3 = Component.get_transform(this,0);
              if (lVar3 == null) throw; // [null/range check failed]
              lVar3 = Transform.Find(lVar3,"Circle",0);
              if (lVar3 == null) throw; // [null/range check failed]
              plVar4 = (int64 *)Component.GetComponent(lVar3,DAT_181d6bc40);
              puVar5 = (uint32 *)FUN_180d904c0(&local_18,0);
              if (plVar4 == (int64 *)0) throw; // [null/range check failed]
              local_18 = *puVar5;
              uStack_14 = puVar5[1];
              uStack_10 = puVar5[2];
              uStack_c = puVar5[3];
              (**(code **)(*plVar4 + 0x2a8))(plVar4,&local_18,*(uint64 *)(*plVar4 + 0x2b0));
            }
            else {
              lVar3 = Component.get_transform(this,0);
              if (lVar3 == null) throw; // [null/range check failed]
              lVar3 = Transform.Find(lVar3,"Circle",0);
              if (lVar3 == null) throw; // [null/range check failed]
              plVar4 = (int64 *)Component.GetComponent(lVar3,DAT_181d6bc40);
              lVar3 = *(int64 *)(DAT_181d4ef00 + 184);
              if (plVar4 == (int64 *)0) throw; // [null/range check failed]
              local_18 = *(uint32 *)(lVar3 + 0x2e8);
              uStack_14 = *(uint32 *)(lVar3 + 0x2ec);
              uStack_10 = *(uint32 *)(lVar3 + 0x2f0);
              uStack_c = *(uint32 *)(lVar3 + 0x2f4);
              (**(code **)(*plVar4 + 0x2a8))(plVar4,&local_18,*(uint64 *)(*plVar4 + 0x2b0));
            }
            lVar3 = Component.get_transform(this,0);
            if (lVar3 != null) {
              lVar3 = Transform.Find(lVar3,"Icon",0);
              if (lVar3 != null) {
                lVar3 = Component.GetComponent(lVar3,DAT_181d6bc40);
                lVar2 = *pStatics;
                if (this.resourcePointData != null) {
                  uVar6 = Int32.ToString(this.resourcePointData + 20,0);
                  if (lVar2 != null) {
                    uVar6 = TextureController.LoadAtlasSprite(lVar2,"ResourcePointAtlas",uVar6,0);
                    if (lVar3 != null) {
                      Image.set_sprite(lVar3,uVar6,0);
                      lVar3 = Component.get_transform(this,0);
                      if (lVar3 != null) {
                        lVar3 = Transform.Find(lVar3,"Force",0);
                        if (lVar3 != null) {
                          lVar3 = Component.GetComponent(lVar3,DAT_181d6bc40);
                          lVar2 = *pStatics;
                          if (this.resourcePointData != null) {
                            lVar7 = ResourcePointData.GetForce(this.resourcePointData,0);
                            if (lVar7 != null) {
                              uVar1 = *(uint32 *)(lVar7 + 16);
                              uVar6 = GlobalData.GetForceIconName(uVar1,0);
                              if (lVar2 != null) {
                                uVar6 = TextureController.LoadAtlasSprite(lVar2,"UIAtlas",uVar6,0);
                                if (lVar3 != null) {
                                  Image.set_sprite(lVar3,uVar6,0);
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
    }

    // Token : 0x600204A
    // RVA   : 0x3A17B0   Offset: 0x39FFB0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_18044ef50(this,0);
    }

}
