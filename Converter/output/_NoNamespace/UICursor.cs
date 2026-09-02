// ============================================================
// Type  : UICursor
// Token : 0x2000005
// ============================================================

public class UICursor
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4000008
    public static UICursor instance;

    // Token: 0x4000009
    public Camera uiCamera;

    // Token: 0x400000A
    private Transform mTrans;

    // Token: 0x400000B
    private UISprite mSprite;

    // Token: 0x400000C
    private INGUIAtlas mAtlas;

    // Token: 0x400000D
    private string mSpriteName;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000009
    // RVA   : 0x13D4F40   Offset: 0x13D3740   Length: 0x43
    private void Awake()
    {
        puVar1 = *(uint64 **)(DAT_181d8a5d8 + 184);
        *puVar1 = this;
        il2cpp_internal(puVar1,this);
    }

    // Token : 0x600000A
    // RVA   : 0x13D5200   Offset: 0x13D3A00   Length: 0x40
    private void OnDestroy()
    {
        puVar1 = *(uint64 **)(DAT_181d8a5d8 + 184);
        *puVar1 = 0;
        il2cpp_internal(puVar1,0);
    }

    // Token : 0x600000B
    // RVA   : 0x13D53D0   Offset: 0x13D3BD0   Length: 0x1B2
    private void Start()
    {
        bool cVar1;
        uint uVar2;
        ulong uVar3;
        long lVar4;
        uVar3 = Component.get_transform(this,0);
        this.mTrans = uVar3;
        uVar3 = Component.GetComponentInChildren(this,DAT_181d6eec0);
        this.mSprite = uVar3;
        uVar3 = this.uiCamera;
        cVar1 = Object.op_Equality(uVar3,0,0);
        if (cVar1) {
          lVar4 = Component.get_gameObject(this,0);
          if (lVar4 == null) throw; // [null/range check failed]
          uVar2 = GameObject.get_layer(lVar4,0);
          uVar3 = NGUITools.FindCameraForLayer(uVar2,0);
          this.uiCamera = uVar3;
        }
        uVar3 = this.mSprite;
        cVar1 = Object.op_Inequality(uVar3,0,0);
        if (!cVar1) {
          return;
        }
        if (this.mSprite != null) {
          uVar3 = UISprite.get_atlas(this.mSprite,0);
          this.mAtlas = uVar3;
          if (this.mSprite != null) {
            this.mSpriteName = this.mSprite.mSpriteName;
            lVar4 = this.mSprite;
            if (lVar4 != null) {
              if (99 < *(int *)(lVar4 + 172)) {
                return;
              }
              UIWidget.set_depth(lVar4,100);
              return;
            }
          }
        }
    }

    // Token : 0x600000C
    // RVA   : 0x13D5590   Offset: 0x13D3D90   Length: 0x21D
    private void Update()
    {
        ulong uVar1;
        long lVar2;
        bool cVar3;
        int iVar4;
        uint uVar6;
        uint uVar7;
        float fVar8;
        float fVar9;
        ulong local_48;
        uint local_40;
        byte[] local_38 = new byte[48];
        puVar5 = (uint64 *)Input.get_mousePosition(local_38,0);
        uVar1 = this.uiCamera;
        local_48 = *puVar5;
        uVar6 = *(uint32 *)(puVar5 + 1);
        cVar3 = Object.op_Inequality(uVar1,0,0);
        if (!cVar3) {
          iVar4 = Screen.get_width();
          fVar9 = (float)local_48 - (float)iVar4 * 0.5;
          iVar4 = Screen.get_height(0);
          fVar8 = local_48._4_4_ - (float)iVar4 * 0.5;
          uVar7 = FUN_18000d7c0(fVar9);
          local_48 = CONCAT44(local_48._4_4_,uVar7);
          uVar7 = FUN_18000d7c0(fVar8);
        }
        else {
          iVar4 = Screen.get_width(0);
          uVar7 = Mathf.Clamp01((float)local_48 / (float)iVar4,0);
          local_48._0_4_ = (float)uVar7;
          iVar4 = Screen.get_height(0);
          uVar7 = Mathf.Clamp01(local_48._4_4_ / (float)iVar4,0);
          lVar2 = this.mTrans;
          local_48 = CONCAT44(uVar7,(float)local_48);
          if ((this.uiCamera == null) ||
             (local_40 = uVar6,
             puVar5 = (uint64 *)
                      Camera.ViewportToWorldPoint(local_38,this.uiCamera,&local_48,0),
             lVar2 == null)) throw; // [null/range check failed]
          local_48 = *puVar5;
          local_40 = *(uint32 *)(puVar5 + 1);
          Transform.set_position(lVar2,&local_48,0);
          if (this.uiCamera == null) throw; // [null/range check failed]
          cVar3 = Camera.get_orthographic(this.uiCamera,0);
          if (!cVar3) {
            return;
          }
          if (this.mTrans == null) throw; // [null/range check failed]
          puVar5 = (uint64 *)Transform.get_localPosition(local_38,this.mTrans,0);
          local_48 = *puVar5;
          uVar6 = *(uint32 *)(puVar5 + 1);
          uVar7 = FUN_18000d7c0(local_48);
          local_48 = CONCAT44(local_48._4_4_,uVar7);
          uVar7 = FUN_18000d7c0(local_48._4_4_);
        }
        local_48 = CONCAT44(uVar7,(float)local_48);
        if (this.mTrans != null) {
          local_40 = uVar6;
          Transform.set_localPosition(this.mTrans,&local_48,0);
          return;
        }
    }

    // Token : 0x600000D
    // RVA   : 0x13D4F90   Offset: 0x13D3790   Length: 0x266
    public static void Clear()
    {
        var pStatics = *(int64*)(DAT_181d8a5d8 + 184);
        ulong uVar1;
        long lVar2;
        ulong uVar3;
        ulong uVar4;
        bool cVar6;
        uVar1 = **(uint64 **)(DAT_181d8a5d8 + 184);
        cVar6 = Object.op_Inequality(uVar1,0,0);
        if (!cVar6) {
          return;
        }
        if (*pStatics != 0) {
          uVar1 = *(uint64 *)(*pStatics + 40);
          cVar6 = Object.op_Inequality(uVar1,0,0);
          if (!cVar6) {
            return;
          }
          lVar2 = *pStatics;
          if (lVar2 != null) {
            uVar1 = *(uint64 *)(lVar2 + 48);
            uVar3 = *(uint64 *)(lVar2 + 56);
            uVar4 = **(uint64 **)(DAT_181d8a5d8 + 184);
            cVar6 = Object.op_Inequality(uVar4,0,0);
            if (!cVar6) {
              return;
            }
            if (*pStatics != 0) {
              uVar4 = *(uint64 *)(*pStatics + 40);
              cVar6 = Object.op_Implicit(uVar4,0);
              if (!cVar6) {
                return;
              }
              if ((*pStatics != 0) &&
                 (lVar2 = *(int64 *)(*pStatics + 40)) != null) {
                UISprite.set_atlas(lVar2,uVar1,0);
                if ((*pStatics != 0) &&
                   (lVar2 = *(int64 *)(*pStatics + 40)) != null) {
                  UISprite.set_spriteName(lVar2,uVar3,0);
                  if ((*pStatics != 0) &&
                     (plVar5 = *(int64 **)(*pStatics + 40),
                     plVar5 != (int64 *)0)) {
                    (**(code **)(*plVar5 + 0x348))(plVar5,*(uint64 *)(*plVar5 + 0x350));
                    if (*pStatics != 0) {
                      UICursor.Update(*pStatics,0);
                      return;
                    }
                  }
                }
              }
            }
          }
        }
    }

    // Token : 0x600000E
    // RVA   : 0x13D5240   Offset: 0x13D3A40   Length: 0x18C
    public static void Set(INGUIAtlas atlas, string sprite)
    {
        var pStatics = *(int64*)(DAT_181d8a5d8 + 184);
        ulong uVar1;
        long lVar2;
        bool cVar4;
        uVar1 = **(uint64 **)(DAT_181d8a5d8 + 184);
        cVar4 = Object.op_Inequality(uVar1,0,0);
        if (!cVar4) {
          return;
        }
        if (*pStatics != 0) {
          uVar1 = *(uint64 *)(*pStatics + 40);
          cVar4 = Object.op_Implicit(uVar1,0);
          if (!cVar4) {
            return;
          }
          if ((*pStatics != 0) &&
             (lVar2 = *(int64 *)(*pStatics + 40)) != null) {
            UISprite.set_atlas(lVar2,atlas,0);
            if ((*pStatics != 0) &&
               (lVar2 = *(int64 *)(*pStatics + 40)) != null) {
              UISprite.set_spriteName(lVar2,sprite,0);
              if ((*pStatics != 0) &&
                 (plVar3 = *(int64 **)(*pStatics + 40),
                 plVar3 != (int64 *)0)) {
                (**(code **)(*plVar3 + 0x348))(plVar3,*(uint64 *)(*plVar3 + 0x350));
                if (*pStatics != 0) {
                  UICursor.Update(*pStatics,0);
                  return;
                }
              }
            }
          }
        }
    }

    // Token : 0x600000F
    // RVA   : 0x3A17B0   Offset: 0x39FFB0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_18044ef50(this,0);
    }

}
