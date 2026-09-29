// ============================================================
// Type  : UIDragCamera
// Token : 0x200003B
// ============================================================

public class UIDragCamera
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4000124
    public UIDraggableCamera draggableCamera;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x600010B
    // RVA   : 0x12B2120   Offset: 0x12B1520   Length: 0xD4
    private void Awake()
    {
        bool cVar2;
        ulong uVar3;
        uVar3 = this.draggableCamera;
        cVar2 = Object.op_Equality(uVar3,0,0);
        if (cVar2) {
          uVar3 = Component.get_gameObject(this,0);
          uVar3 = NGUITools.FindInParents(uVar3,DAT_181d8f338);
          *puVar1 = uVar3;
          il2cpp_internal(puVar1,uVar3);
        }
    }

    // Token : 0x600010C
    // RVA   : 0x12B2300   Offset: 0x12B1700   Length: 0x232
    private void OnPress(bool isPressed)
    {
        long lVar1;
        uint uVar2;
        uint uVar3;
        uint uVar4;
        bool cVar5;
        ulong uVar7;
        uint local_res20;
        uint uStackX_24;
        byte[] local_28 = new byte[32];
        cVar5 = Behaviour.get_enabled(this,0);
        if (cVar5) {
          uVar7 = Component.get_gameObject(this,0);
          cVar5 = NGUITools.GetActive(uVar7,0);
          if (cVar5) {
            uVar7 = this.draggableCamera;
            cVar5 = Object.op_Inequality(uVar7,0,0);
            if (cVar5) {
              if (this.draggableCamera == null) {
        LAB_1812b252d:
                          // WARNING: Subroutine does not return
                FUN_1800d6620();
              }
              cVar5 = Behaviour.get_enabled(this.draggableCamera,0);
              if (cVar5) {
                lVar1 = this.draggableCamera;
                if (lVar1 == null) goto LAB_1812b252d;
                if (isPressed) {
                  lVar1.mDragStarted = 0;
                }
                uVar7 = lVar1.rootForBounds;
                cVar5 = Object.op_Inequality(uVar7,0,0);
                if (cVar5) {
                  lVar1.mPressed = isPressed;
                  if (!isPressed) {
                    if (lVar1.dragEffect == 2) {
                      UIDraggableCamera.ConstrainToBounds(lVar1,0,0);
                    }
                  }
                  else {
                    puVar6 = (uint32 *)
                             NGUIMath.CalculateAbsoluteWidgetBounds
                                       (local_28,lVar1.rootForBounds,0);
                    uVar2 = puVar6[1];
                    uVar3 = puVar6[2];
                    uVar4 = puVar6[3];
                    lVar1.mBounds = *puVar6;
                    *(uint32 *)(lVar1 + 88) = uVar2;
                    *(uint32 *)(lVar1 + 92) = uVar3;
                    *(uint32 *)(lVar1 + 96) = uVar4;
                    *(uint64 *)(lVar1 + 100) = *(uint64 *)(puVar6 + 4);
                    uVar7 = Vector2.get_zero(0);
                    local_res20 = (uint32)uVar7;
                    uStackX_24 = (uint32)((uint64)uVar7 >> 32);
                    lVar1.mMomentum = local_res20;
                    *(uint32 *)(lVar1 + 80) = uStackX_24;
                    lVar1.mScroll = 0;
                    lVar1 = Component.GetComponent(lVar1,DAT_181d95d78);
                    cVar5 = Object.op_Inequality(lVar1,0,0);
                    if (cVar5) {
                      if (lVar1 != null) {
                        Behaviour.set_enabled(lVar1,0,0);
                        return;
                      }
                      goto LAB_1812b252d;
                    }
                  }
                }
              }
            }
          }
        }
    }

    // Token : 0x600010D
    // RVA   : 0x12B2200   Offset: 0x12B1600   Length: 0xFD
    private void OnDrag(Vector2 delta)
    {
        ulong uVar1;
        bool cVar2;
        cVar2 = Behaviour.get_enabled(this,0);
        if (cVar2) {
          uVar1 = Component.get_gameObject(this,0);
          cVar2 = NGUITools.GetActive(uVar1,0);
          if (cVar2) {
            uVar1 = this.draggableCamera;
            cVar2 = Object.op_Inequality(uVar1,0,0);
            if (cVar2) {
              if (this.draggableCamera == null) {
        LAB_1812b22f8:
                          // WARNING: Subroutine does not return
                FUN_1800d6620();
              }
              cVar2 = Behaviour.get_enabled(this.draggableCamera,0);
              if (cVar2) {
                if (this.draggableCamera == null) goto LAB_1812b22f8;
                UIDraggableCamera.Drag(this.draggableCamera,delta,0);
              }
            }
          }
        }
    }

    // Token : 0x600010E
    // RVA   : 0x12B2540   Offset: 0x12B1940   Length: 0x1A7
    private void OnScroll(float delta)
    {
        long lVar1;
        ulong uVar2;
        bool cVar3;
        float fVar4;
        float fVar5;
        cVar3 = Behaviour.get_enabled(this,0);
        if (cVar3) {
          uVar2 = Component.get_gameObject(this,0);
          cVar3 = NGUITools.GetActive(uVar2,0);
          if (cVar3) {
            uVar2 = this.draggableCamera;
            cVar3 = Object.op_Inequality(uVar2,0,0);
            if (cVar3) {
              if (this.draggableCamera == null) {
        LAB_1812b26e2:
                          // WARNING: Subroutine does not return
                FUN_1800d6620();
              }
              cVar3 = Behaviour.get_enabled(this.draggableCamera,0);
              if (cVar3) {
                lVar1 = this.draggableCamera;
                if (lVar1 == null) goto LAB_1812b26e2;
                cVar3 = Behaviour.get_enabled(lVar1,0);
                if (cVar3) {
                  uVar2 = Component.get_gameObject(lVar1,0);
                  cVar3 = NGUITools.GetActive(uVar2,0);
                  if (cVar3) {
                    fVar4 = (float)Mathf.Sign(lVar1.mScroll,0);
                    fVar5 = (float)Mathf.Sign(delta,0);
                    if (fVar4 == fVar5) {
                      fVar4 = lVar1.mScroll;
                    }
                    else {
                      fVar4 = 0.0;
                    }
                    lVar1.mScroll = delta * lVar1.scrollWheelFactor + fVar4;
                  }
                }
              }
            }
          }
        }
    }

    // Token : 0x600010F
    // RVA   : 0x3A17B0   Offset: 0x3A0BB0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_18044ef50(this,0);
    }

}
