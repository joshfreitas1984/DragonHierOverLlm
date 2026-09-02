// ============================================================
// Type  : UIDragCamera
// Token : 0x200003A
// ============================================================

public class UIDragCamera
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4000108
    public UIDraggableCamera draggableCamera;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60000F3
    // RVA   : 0x13D57B0   Offset: 0x13D3FB0   Length: 0xD4
    private void Awake()
    {
        bool cVar2;
        ulong uVar3;
        uVar3 = this.draggableCamera;
        cVar2 = Object.op_Equality(uVar3,0,0);
        if (cVar2) {
          uVar3 = Component.get_gameObject(this,0);
          uVar3 = NGUITools.FindInParents(uVar3,DAT_181d66780);
          *puVar1 = uVar3;
          il2cpp_internal(puVar1,uVar3);
        }
    }

    // Token : 0x60000F4
    // RVA   : 0x13D5990   Offset: 0x13D4190   Length: 0xF9
    private void OnPress(bool isPressed)
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
        LAB_1813d5a84:
                          // WARNING: Subroutine does not return
                FUN_1800d6620();
              }
              cVar2 = Behaviour.get_enabled(this.draggableCamera,0);
              if (cVar2) {
                if (this.draggableCamera == null) goto LAB_1813d5a84;
                UIDraggableCamera.Press(this.draggableCamera,isPressed,0);
              }
            }
          }
        }
    }

    // Token : 0x60000F5
    // RVA   : 0x13D5890   Offset: 0x13D4090   Length: 0xFD
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
        LAB_1813d5988:
                          // WARNING: Subroutine does not return
                FUN_1800d6620();
              }
              cVar2 = Behaviour.get_enabled(this.draggableCamera,0);
              if (cVar2) {
                if (this.draggableCamera == null) goto LAB_1813d5988;
                UIDraggableCamera.Drag(this.draggableCamera,delta,0);
              }
            }
          }
        }
    }

    // Token : 0x60000F6
    // RVA   : 0x13D5A90   Offset: 0x13D4290   Length: 0xF9
    private void OnScroll(float delta)
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
        LAB_1813d5b84:
                          // WARNING: Subroutine does not return
                FUN_1800d6620();
              }
              cVar2 = Behaviour.get_enabled(this.draggableCamera,0);
              if (cVar2) {
                if (this.draggableCamera == null) goto LAB_1813d5b84;
                UIDraggableCamera.Scroll(this.draggableCamera,delta,0);
              }
            }
          }
        }
    }

    // Token : 0x60000F7
    // RVA   : 0x3A17B0   Offset: 0x39FFB0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_18044ef50(this,0);
    }

}
