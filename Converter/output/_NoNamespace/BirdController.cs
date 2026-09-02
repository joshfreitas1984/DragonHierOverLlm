// ============================================================
// Type  : BirdController
// Token : 0x2000198
// ============================================================

public class BirdController
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4000AD5
    public SkyObjType skyObjType;

    // Token: 0x4000AD6
    public bool moveRight;

    // Token: 0x4000AD7
    public float moveSpeed;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000D24
    // RVA   : 0xCDD350   Offset: 0xCDBB50   Length: 0x398
    private void Update()
    {
        var pStatics = *(int64*)(DAT_181d7e3b0 + 184);
        ulong uVar1;
        long lVar2;
        long lVar4;
        ulong uVar6;
        float fVar7;
        uint uVar8;
        float fVar9;
        ulong local_48;
        float local_40;
        ulong local_38;
        ulong uStack_30;
        lVar2 = Component.get_transform(this,0);
        if (lVar2 != null) {
          puVar3 = (uint64 *)Transform.get_localPosition(&local_38,lVar2,0);
          uVar6 = *puVar3;
          fVar7 = *(float *)(puVar3 + 1);
          if (!this.moveRight) {
            puVar3 = (uint64 *)Vector3.get_left(&local_38);
          }
          else {
            puVar3 = (uint64 *)Vector3.get_right();
          }
          local_48 = *puVar3;
          local_40 = *(float *)(puVar3 + 1);
          fVar9 = this.moveSpeed;
          local_38 = uVar6;
          uStack_30._0_4_ = fVar7;
          fVar7 = (float)Time.get_deltaTime(0);
          local_40 = local_40 * fVar9 * fVar7 + (float)uStack_30;
          uStack_30 = CONCAT44(uStack_30._4_4_,local_40);
          local_38 = CONCAT44(local_48._4_4_ * fVar9 * fVar7 + local_38._4_4_,
                              (float)local_48 * fVar9 * fVar7 + (float)local_38);
          Transform.set_localPosition(lVar2,&local_38,0);
          lVar2 = Component.GetComponent(this,DAT_181d6d540);
          lVar4 = Component.GetComponent(this,DAT_181d6d540);
          if (lVar4 != null) {
            puVar3 = (uint64 *)SpriteRenderer.get_color(&local_38,lVar4,0);
            uVar6 = *puVar3;
            uVar1 = puVar3[1];
            if (*pStatics != 0) {
              uVar8 = SkyController.GetScaleAlphaPercent
                                (*pStatics,this.skyObjType,0);
              local_38 = uVar6;
              uStack_30 = uVar1;
              puVar3 = (uint64 *)GlobalData.SetColorAlpha(&local_48,&local_38,uVar8,0);
              if (lVar2 != null) {
                local_38 = *puVar3;
                uStack_30 = puVar3[1];
                SpriteRenderer.set_color(lVar2,&local_38,0);
                lVar2 = Component.get_transform(this,0);
                if (lVar2 != null) {
                  pfVar5 = (float *)Transform.get_localPosition(&local_38,lVar2,0);
                  fVar7 = *pfVar5;
                  if (*pStatics != 0) {
                    fVar9 = (float)SkyController.GetMapSize
                                             (*pStatics,
                                              this.skyObjType,1,0);
                    if (fVar9 * -0.5 - 0.2 < fVar7) {
                      lVar2 = Component.get_transform(this,0);
                      if (lVar2 == null) throw; // [null/range check failed]
                      pfVar5 = (float *)Transform.get_localPosition(&local_38,lVar2,0);
                      fVar7 = *pfVar5;
                      if (*pStatics == 0) throw; // [null/range check failed]
                      fVar9 = (float)SkyController.GetMapSize
                                               (*pStatics,
                                                this.skyObjType,1,0);
                      if (fVar7 < fVar9 * 0.5 + 0.2) {
                        return;
                      }
                    }
                    lVar2 = *pStatics;
                    uVar6 = Component.get_gameObject(this,0);
                    if (lVar2 != null) {
                      SkyController.DestroyBird(lVar2,uVar6,0);
                      if (*pStatics != 0) {
                        SkyController.GenerateBird
                                  (*pStatics,this.skyObjType,1
                                   ,0);
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

    // Token : 0x6000D25
    // RVA   : 0x3A17B0   Offset: 0x39FFB0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_18044ef50(this,0);
    }

}
