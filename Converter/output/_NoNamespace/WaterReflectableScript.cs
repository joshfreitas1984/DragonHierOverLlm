// ============================================================
// Type  : WaterReflectableScript
// Token : 0x20003D9
// ============================================================

public class WaterReflectableScript
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001DEB
    public Vector3 localPosition;

    // Token: 0x4001DEC
    public Vector3 localRotation;

    // Token: 0x4001DED
    public Sprite sprite;

    // Token: 0x4001DEE
    public string spriteLayer;

    // Token: 0x4001DEF
    public int spriteLayerOrder;

    // Token: 0x4001DF0
    private SpriteRenderer spriteSource;

    // Token: 0x4001DF1
    private SpriteRenderer spriteRenderer;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60023DF
    // RVA   : 0x9DF440   Offset: 0x9DDC40   Length: 0x28C
    private void Awake()
    {
        uint uVar1;
        long lVar2;
        long lVar3;
        ulong uVar4;
        long lVar6;
        ulong local_48;
        uint local_40;
        ulong local_38;
        ulong local_28;
        uint uStack_20;
        uint32 uStack_1c;
        lVar2 = new GameObject("Water Reflect",0);
        if (lVar2 != null) {
          lVar3 = GameObject.get_transform(lVar2,0);
          uVar4 = Component.get_transform(this,0);
          if (lVar3 != null) {
            Transform.set_parent(lVar3,uVar4,0);
            lVar3 = GameObject.get_transform(lVar2,0);
            if (lVar3 != null) {
              local_40 = *(uint32 *)(this + 32);
              local_48 = this.localPosition;
              Transform.set_localPosition(lVar3,&local_48,0);
              lVar3 = GameObject.get_transform(lVar2,0);
              local_40 = *(uint32 *)(this + 44);
              local_48 = this.localRotation;
              puVar5 = (uint64 *)Quaternion.Euler(&local_28,&local_48,0);
              if (lVar3 != null) {
                local_28 = *puVar5;
                uStack_20 = *(uint32 *)(puVar5 + 1);
                uStack_1c = *(uint32 *)((int64)puVar5 + 12);
                Transform.set_localRotation(lVar3,&local_28,0);
                lVar3 = GameObject.get_transform(lVar2,0);
                lVar6 = GameObject.get_transform(lVar2,0);
                if (lVar6 != null) {
                  puVar7 = (uint32 *)Transform.get_localScale(&local_28,lVar6,0);
                  uVar1 = *puVar7;
                  lVar6 = GameObject.get_transform(lVar2,0);
                  if (lVar6 != null) {
                    puVar5 = (uint64 *)Transform.get_localScale(&local_28,lVar6,0);
                    local_38 = *puVar5;
                    lVar6 = GameObject.get_transform(lVar2,0);
                    if (lVar6 != null) {
                      puVar5 = (uint64 *)Transform.get_localScale(&local_48,lVar6,0);
                      local_28 = *puVar5;
                      local_40 = *(uint32 *)(puVar5 + 1);
                      local_48 = CONCAT44((int)((uint64)local_38 >> 32),uVar1);
                      uStack_20 = local_40;
                      if (lVar3 != null) {
                        local_28 = local_48;
                        Transform.set_localScale(lVar3,&local_28,0);
                        uVar4 = GameObject.AddComponent(lVar2,DAT_181d9d4e0);
                        this.spriteRenderer = uVar4;
                        if (this.spriteRenderer != null) {
                          Renderer.set_sortingLayerName
                                    (this.spriteRenderer,this.spriteLayer,0);
                          if (this.spriteRenderer != null) {
                            Renderer.set_sortingOrder
                                      (this.spriteRenderer,this.spriteLayerOrder,0);
                            uVar4 = Component.GetComponent(this,DAT_181d6d540);
                            this.spriteSource = uVar4;
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

    // Token : 0x60023E0
    // RVA   : 0x9DF840   Offset: 0x9DE040   Length: 0xA7
    private void OnDestroy()
    {
        ulong uVar1;
        bool cVar2;
        uVar1 = this.spriteRenderer;
        cVar2 = Object.op_Inequality(uVar1,0,0);
        if (cVar2) {
          if (this.spriteRenderer == null) {
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          uVar1 = Component.get_gameObject(this.spriteRenderer,0);
          Object.Destroy(uVar1,0);
        }
    }

    // Token : 0x60023E1
    // RVA   : 0x9DF6D0   Offset: 0x9DDED0   Length: 0x16A
    private void LateUpdate()
    {
        long lVar1;
        bool cVar2;
        byte uVar3;
        ulong uVar4;
        uint local_18;
        uint uStack_14;
        uint uStack_10;
        uint32 uStack_c;
        uVar4 = this.spriteSource;
        cVar2 = Object.op_Inequality(uVar4,0,0);
        if (!cVar2) {
          return;
        }
        uVar4 = this.sprite;
        cVar2 = Object.op_Equality(uVar4,0,0);
        lVar1 = this.spriteRenderer;
        if (!cVar2) {
          if (lVar1 == null) throw; // [null/range check failed]
          uVar4 = this.sprite;
        }
        else if ((this.spriteSource == null) ||
                (uVar4 = SpriteRenderer.get_sprite(this.spriteSource,0), lVar1 == null))
        throw; // [null/range check failed]
        SpriteRenderer.set_sprite(lVar1,uVar4,0);
        lVar1 = this.spriteRenderer;
        if ((this.spriteSource != null) &&
           (uVar3 = SpriteRenderer.get_flipX(this.spriteSource,0), lVar1 != null)) {
          SpriteRenderer.set_flipX(lVar1,uVar3,0);
          lVar1 = this.spriteRenderer;
          if ((this.spriteSource != null) &&
             (uVar3 = SpriteRenderer.get_flipY(this.spriteSource,0), lVar1 != null)) {
            SpriteRenderer.set_flipY(lVar1,uVar3,0);
            lVar1 = this.spriteRenderer;
            if ((this.spriteSource != null) &&
               (puVar5 = (uint32 *)
                         SpriteRenderer.get_color(&local_18,this.spriteSource,0), lVar1 != null)
               ) {
              local_18 = *puVar5;
              uStack_14 = puVar5[1];
              uStack_10 = puVar5[2];
              uStack_c = puVar5[3];
              SpriteRenderer.set_color(lVar1,&local_18,0);
              return;
            }
          }
        }
    }

    // Token : 0x60023E2
    // RVA   : 0x9DF8F0   Offset: 0x9DE0F0   Length: 0x93
    public void /*ctor*/()
    {
        this.localPosition = 0xbe80000000000000;
        *(uint32 *)(this + 32) = 0;
        this.localRotation = 0;
        *(uint32 *)(this + 44) = 0xc3340000;
        this.spriteLayer = "Default";
        this.spriteLayerOrder = 0xfffffffb;
        FUN_18044ef50(this,0);
    }

}
