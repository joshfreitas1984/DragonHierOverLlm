// ============================================================
// Type  : MouseController
// Token : 0x2000304
// ============================================================

public class MouseController
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001825
    private static GameObject mRayHitObject;

    // Token: 0x4001826
    private static GameObject mHover;

    // Token: 0x4001827
    private static GameObject mSelected;

    // Token: 0x4001828
    public static Camera currentCamera;

    // Token: 0x4001829
    private static MouseOrTouch[] mMouse;

    // Token: 0x400182A
    public static MouseOrTouch controller;

    // Token: 0x400182B
    public static MouseOrTouch currentTouch;

    // Token: 0x400182C
    private static bool mInputFocus;

    // Token: 0x400182D
    private static Vector2 mLastPos;

    // Token: 0x400182E
    private float mNextRaycast;

    // Token: 0x400182F
    public static bool isDragging;

    // Token: 0x4001830
    public static GameObject hoveredUI;

    // Token: 0x4001831
    public static int currentTouchID;

    // Token: 0x4001832
    private static KeyCode mCurrentKey;

    // Token: 0x4001833
    public static Vector3 lastWorldPosition;

    // Token: 0x4001834
    public static Ray lastWorldRay;

    // Token: 0x4001835
    public static RaycastHit lastHit;

    // Token: 0x4001836
    private static int mNotifying;

    // Token: 0x4001837
    private static RaycastHit[] mRayHits;

    // Token: 0x4001838
    private static Collider2D[] mOverlap;

    // Token: 0x4001839
    private PointerEventData eventDataCurrentPosition;

    // Token: 0x400183A
    public float mouseDragThreshold;

    // Token: 0x400183B
    public float mouseClickThreshold;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60018EC
    // RVA   : 0xAF8F80   Offset: 0xAF7780   Length: 0x7C
    public static MouseOrTouch get_mouse0()
    {
        long lVar1;
        ulong uVar2;
        lVar1 = MouseController.mMouse;
        if (lVar1 != null) {
          if (*(int *)(lVar1 + 24) != 0) {
            return *(uint64 *)(lVar1 + 32);
          }
          uVar2 = il2cpp_internal();
                          // WARNING: Subroutine does not return
          FUN_1800d65f0(uVar2,0);
        }
    }

    // Token : 0x60018ED
    // RVA   : 0xAF9000   Offset: 0xAF7800   Length: 0x7C
    public static MouseOrTouch get_mouse1()
    {
        long lVar1;
        ulong uVar2;
        lVar1 = MouseController.mMouse;
        if (lVar1 != null) {
          if (1 < *(uint32 *)(lVar1 + 24)) {
            return *(uint64 *)(lVar1 + 40);
          }
          uVar2 = il2cpp_internal();
                          // WARNING: Subroutine does not return
          FUN_1800d65f0(uVar2,0);
        }
    }

    // Token : 0x60018EE
    // RVA   : 0xAF9080   Offset: 0xAF7880   Length: 0x7C
    public static MouseOrTouch get_mouse2()
    {
        long lVar1;
        ulong uVar2;
        lVar1 = MouseController.mMouse;
        if (lVar1 != null) {
          if (2 < *(uint32 *)(lVar1 + 24)) {
            return *(uint64 *)(lVar1 + 48);
          }
          uVar2 = il2cpp_internal();
                          // WARNING: Subroutine does not return
          FUN_1800d65f0(uVar2,0);
        }
    }

    // Token : 0x60018EF
    // RVA   : 0xAF8E20   Offset: 0xAF7620   Length: 0x15F
    public static GameObject get_hoveredObject()
    {
        ulong uVar1;
        long lVar2;
        bool cVar3;
        uVar1 = MouseController.mHover;
        cVar3 = Object.op_Implicit(uVar1,0);
        if (cVar3) {
          lVar2 = MouseController.mHover;
          if (lVar2 == null) {
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          cVar3 = GameObject.get_activeInHierarchy(lVar2,0);
          if (cVar3) {
            return MouseController.mHover;
          }
        }
        MouseController.mHover = 0;
        return 0;
    }

    // Token : 0x60018F0
    // RVA   : 0xAF9190   Offset: 0xAF7990   Length: 0x256
    public static void set_hoveredObject(GameObject value)
    {
        ulong uVar1;
        bool cVar2;
        ulong uVar3;
        byte[] local_res8 = new byte[8];
        uVar1 = MouseController.mHover;
        cVar2 = Object.op_Equality(uVar1,value,0);
        if (!cVar2) {
          uVar1 = MouseController.mHover;
          cVar2 = Object.op_Implicit(uVar1,0);
          if (cVar2) {
            uVar1 = MouseController.mHover;
            local_res8[0] = 0;
            uVar3 = il2cpp_value_box(DAT_181d8d920,local_res8);
            MouseController.Notify(uVar1,"OnHover",uVar3,0);
          }
          MouseController.mHover = value;
          uVar1 = MouseController.mHover;
          cVar2 = Object.op_Implicit(uVar1,0);
          if (cVar2) {
            uVar1 = MouseController.mHover;
            local_res8[0] = 1;
            uVar3 = il2cpp_value_box(DAT_181d8d920,local_res8);
            MouseController.Notify(uVar1,"OnHover",uVar3,0);
          }
        }
    }

    // Token : 0x60018F1
    // RVA   : 0xAF8DC0   Offset: 0xAF75C0   Length: 0x57
    public static KeyCode get_currentKey()
    {
        return MouseController.mCurrentKey;
    }

    // Token : 0x60018F2
    // RVA   : 0xAF9100   Offset: 0xAF7900   Length: 0x83
    public static void set_currentKey(KeyCode value)
    {
        if (MouseController.mCurrentKey != value) {
          MouseController.mCurrentKey = value;
        }
    }

    // Token : 0x60018F3
    // RVA   : 0xAF8A40   Offset: 0xAF7240   Length: 0x29
    private void Update()
    {
        bool cVar1;
        cVar1 = Application.get_isFocused(0);
        if (cVar1) {
          MouseController.ProcessEvents(this,0);
          return;
        }
    }

    // Token : 0x60018F4
    // RVA   : 0xAF52D0   Offset: 0xAF3AD0   Length: 0x13A
    public static void Notify(GameObject go, string funcName, object obj)
    {
        bool cVar2;
        if (MouseController.mNotifying < 11) {
          cVar2 = Object.op_Implicit(go,0);
          if (cVar2) {
            if (go == null) {
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            cVar2 = GameObject.get_activeInHierarchy(go,0);
            if (cVar2) {
              MouseController.mNotifying = *piVar1 + 1;
              GameObject.SendMessage(go,funcName,obj,1,0);
              MouseController.mNotifying = *piVar1 + -1;
            }
          }
        }
    }

    // Token : 0x60018F5
    // RVA   : 0xAF88F0   Offset: 0xAF70F0   Length: 0x14F
    public static void Raycast(MouseOrTouch touch)
    {
        var pMouseController = *(int64*)(MouseController_StaticsPtr + 184);
        ulong uVar1;
        ulong uVar2;
        bool cVar3;
        int iVar4;
        uint uVar5;
        long lVar6;
        long lVar7;
        ulong uVar9;
        float fVar10;
        float fVar11;
        ulong local_68;
        uint local_60;
        ulong local_58;
        ulong uStack_50;
        ulong local_48;
        lVar6 = Camera.get_main(0);
        if (lVar6 != null) {
          cVar3 = Behaviour.get_enabled(lVar6,0);
          if (cVar3) {
            lVar7 = Component.get_gameObject(lVar6,0);
            if (lVar7 == null) throw; // [null/range check failed]
            cVar3 = GameObject.get_activeInHierarchy(lVar7,0);
            if ((cVar3) && (iVar4 = Camera.get_targetDisplay(lVar6,0)) == null) {
              local_68 = *touch;
              local_60 = *(uint32 *)(touch + 1);
              puVar8 = (uint64 *)Camera.ScreenToViewportPoint(&local_58,lVar6,&local_68,0);
              local_68 = *puVar8;
              fVar10 = (float)local_68;
              local_60 = *(uint32 *)(puVar8 + 1);
              cVar3 = Single.IsNaN(local_68,0);
              if (!cVar3) {
                fVar11 = local_68._4_4_;
                cVar3 = Single.IsNaN(local_68._4_4_,0);
                if ((((!cVar3) && (0.0 <= fVar10)) && (fVar10 <= 1.0)) &&
                   ((0.0 <= fVar11 && (fVar11 <= 1.0)))) {
                  local_68 = *touch;
                  local_60 = *(uint32 *)(touch + 1);
                  puVar8 = (uint64 *)Camera.ScreenPointToRay(&local_58,lVar6,&local_68,0);
                  uVar1 = *puVar8;
                  uVar2 = puVar8[1];
                  uVar9 = puVar8[2];
                  uVar5 = Camera.get_cullingMask(lVar6,0);
                  fVar10 = (float)Camera.get_farClipPlane(lVar6,0);
                  fVar11 = (float)Camera.get_nearClipPlane(lVar6,0);
                  lVar6 = pMouseController;
                  *(uint64 *)(lVar6 + 100) = uVar1;
                  *(uint64 *)(lVar6 + 108) = uVar2;
                  *(uint64 *)(lVar6 + 116) = uVar9;
                  local_58 = uVar1;
                  uStack_50 = uVar2;
                  local_48 = uVar9;
                  cVar3 = Physics.Raycast(&local_58,
                                           pMouseController + 124,
                                           fVar10 - fVar11,uVar5,1,0);
                  if (cVar3) {
                    puVar8 = (uint64 *)
                             FUN_18045e0a0(&local_58,
                                           pMouseController + 124,0);
                    lVar6 = pMouseController;
                    *(uint64 *)(lVar6 + 88) = *puVar8;
                    *(uint32 *)(lVar6 + 96) = *(uint32 *)(puVar8 + 1);
                    lVar6 = RaycastHit.get_collider
                                      (pMouseController + 124,0);
                    if (lVar6 != null) {
                      uVar9 = Component.get_gameObject(lVar6,0);
                      puVar8 = *(uint64 **)(MouseController_StaticsPtr + 184);
                      *puVar8 = uVar9;
                      il2cpp_internal(puVar8,uVar9);
                      return 1;
                    }
                    throw; // [null/range check failed]
                  }
                }
              }
            }
          }
          return 0;
        }
    }

    // Token : 0x60018F6
    // RVA   : 0xAF8620   Offset: 0xAF6E20   Length: 0x2CE
    public static bool Raycast(Vector3 inPos)
    {
        var pMouseController = *(int64*)(MouseController_StaticsPtr + 184);
        ulong uVar1;
        ulong uVar2;
        bool cVar3;
        int iVar4;
        uint uVar5;
        long lVar6;
        long lVar7;
        ulong uVar9;
        float fVar10;
        float fVar11;
        ulong local_68;
        uint local_60;
        ulong local_58;
        ulong uStack_50;
        ulong local_48;
        lVar6 = Camera.get_main(0);
        if (lVar6 != null) {
          cVar3 = Behaviour.get_enabled(lVar6,0);
          if (cVar3) {
            lVar7 = Component.get_gameObject(lVar6,0);
            if (lVar7 == null) throw; // [null/range check failed]
            cVar3 = GameObject.get_activeInHierarchy(lVar7,0);
            if ((cVar3) && (iVar4 = Camera.get_targetDisplay(lVar6,0)) == null) {
              local_68 = *inPos;
              local_60 = *(uint32 *)(inPos + 1);
              puVar8 = (uint64 *)Camera.ScreenToViewportPoint(&local_58,lVar6,&local_68,0);
              local_68 = *puVar8;
              fVar10 = (float)local_68;
              local_60 = *(uint32 *)(puVar8 + 1);
              cVar3 = Single.IsNaN(local_68,0);
              if (!cVar3) {
                fVar11 = local_68._4_4_;
                cVar3 = Single.IsNaN(local_68._4_4_,0);
                if ((((!cVar3) && (0.0 <= fVar10)) && (fVar10 <= 1.0)) &&
                   ((0.0 <= fVar11 && (fVar11 <= 1.0)))) {
                  local_68 = *inPos;
                  local_60 = *(uint32 *)(inPos + 1);
                  puVar8 = (uint64 *)Camera.ScreenPointToRay(&local_58,lVar6,&local_68,0);
                  uVar1 = *puVar8;
                  uVar2 = puVar8[1];
                  uVar9 = puVar8[2];
                  uVar5 = Camera.get_cullingMask(lVar6,0);
                  fVar10 = (float)Camera.get_farClipPlane(lVar6,0);
                  fVar11 = (float)Camera.get_nearClipPlane(lVar6,0);
                  lVar6 = pMouseController;
                  *(uint64 *)(lVar6 + 100) = uVar1;
                  *(uint64 *)(lVar6 + 108) = uVar2;
                  *(uint64 *)(lVar6 + 116) = uVar9;
                  local_58 = uVar1;
                  uStack_50 = uVar2;
                  local_48 = uVar9;
                  cVar3 = Physics.Raycast(&local_58,
                                           pMouseController + 124,
                                           fVar10 - fVar11,uVar5,1,0);
                  if (cVar3) {
                    puVar8 = (uint64 *)
                             FUN_18045e0a0(&local_58,
                                           pMouseController + 124,0);
                    lVar6 = pMouseController;
                    *(uint64 *)(lVar6 + 88) = *puVar8;
                    *(uint32 *)(lVar6 + 96) = *(uint32 *)(puVar8 + 1);
                    lVar6 = RaycastHit.get_collider
                                      (pMouseController + 124,0);
                    if (lVar6 != null) {
                      uVar9 = Component.get_gameObject(lVar6,0);
                      puVar8 = *(uint64 **)(MouseController_StaticsPtr + 184);
                      *puVar8 = uVar9;
                      il2cpp_internal(puVar8,uVar9);
                      return true;
                    }
                    throw; // [null/range check failed]
                  }
                }
              }
            }
          }
          return false;
        }
    }

    // Token : 0x60018F7
    // RVA   : 0xAF5120   Offset: 0xAF3920   Length: 0x1A8
    public bool IsPointerOverGameUI()
    {
        uint uVar1;
        ulong uVar2;
        byte uVar5;
        int iVar6;
        long lVar7;
        long lVar8;
        long lVar9;
        ulong local_38;
        byte[] local_28 = new byte[32];
        iVar6 = Application.get_platform(0);
        if (iVar6 != 8) {
          iVar6 = Application.get_platform(0);
          if (iVar6 != 11) {
            lVar7 = EventSystem.get_current(0);
            if (lVar7 != null) {
              uVar5 = EventSystem.IsPointerOverGameObject(lVar7,0);
              return uVar5;
            }
            throw; // [null/range check failed]
          }
        }
        uVar2 = EventSystem.get_current(0);
        lVar7 = new PointerEventData(uVar2,0);
        puVar3 = (uint32 *)Input.get_mousePosition(&local_38,0);
        uVar1 = *puVar3;
        puVar4 = (uint64 *)Input.get_mousePosition(local_28,0);
        local_38 = *puVar4;
        if (lVar7 != null) {
          local_38._4_4_ = (uint32)((uint64)local_38 >> 32);
          *(uint32 *)(lVar7 + 0x104) = local_38._4_4_;
          *(uint32 *)(lVar7 + 0x100) = uVar1;
          lVar8 = il2cpp_internal(DAT_181d718b0);
          FUN_180f58a90(lVar8,DAT_181d767d8);
          lVar9 = EventSystem.get_current(0);
          if (lVar9 != null) {
            EventSystem.RaycastAll(lVar9,lVar7,lVar8,0);
            if (lVar8 != null) {
              return 0 < *(int *)(lVar8 + 24);
            }
          }
        }
    }

    // Token : 0x60018F8
    // RVA   : 0xAF5410   Offset: 0xAF3C10   Length: 0x719
    private void ProcessEvents()
    {
        uint uVar1;
        bool cVar3;
        int iVar4;
        long lVar5;
        long lVar6;
        ulong uVar7;
        ulong uVar8;
        long lVar10;
        ulong uVar13;
        uint uVar14;
        ulong uVar15;
        float fVar16;
        float[] local_res18 = new float[4];
        ulong local_88;
        byte[] local_78 = new byte[16];
        uint local_68;
        uint uStack_64;
        uint uStack_60;
        uint32 uStack_5c;
        iVar4 = Application.get_platform(0);
        if ((iVar4 == 8) || (iVar4 = Application.get_platform(0), iVar4 == 11)) {
          uVar7 = EventSystem.get_current(0);
          lVar5 = new PointerEventData(uVar7,0);
          puVar9 = (uint32 *)Input.get_mousePosition(&local_88,0);
          uVar1 = *puVar9;
          puVar11 = (uint64 *)Input.get_mousePosition(local_78,0);
          local_88 = *puVar11;
          if (lVar5 == null) throw; // [null/range check failed]
          local_88._4_4_ = (uint32)((uint64)local_88 >> 32);
          *(uint32 *)(lVar5 + 0x104) = local_88._4_4_;
          *(uint32 *)(lVar5 + 0x100) = uVar1;
          lVar10 = il2cpp_internal(DAT_181d718b0);
          FUN_180f58a90(lVar10,DAT_181d767d8);
          lVar6 = EventSystem.get_current(0);
          if ((lVar6 == null) || (EventSystem.RaycastAll(lVar6,lVar5,lVar10,0), lVar10 == null))
          throw; // [null/range check failed]
          cVar3 = 0 < *(int *)(lVar10 + 24);
        }
        else {
          lVar5 = EventSystem.get_current(0);
          if (lVar5 == null) throw; // [null/range check failed]
          cVar3 = EventSystem.IsPointerOverGameObject(lVar5,0);
        }
        if (!cVar3) {
          MouseController.hoveredUI = 0;
          uVar7 = UICamera.get_hoveredObject(0);
          cVar3 = Object.op_Inequality(uVar7,0,0);
          if (cVar3) {
            lVar5 = UICamera.get_hoveredObject(0);
            if (lVar5 == null) throw; // [null/range check failed]
            uVar7 = Object.get_name(lVar5,0);
            cVar3 = String.op_Inequality(uVar7,"UI Root",0);
            if (cVar3) {
              MouseController.set_hoveredObject(0,0);
              return;
            }
          }
          MouseController.ProcessMouse(this,0);
          uVar7 = MouseController.mHover;
          cVar3 = Object.op_Inequality(uVar7,0,0);
          if ((cVar3) && (fVar16 = (float)Input.GetAxis("Mouse ScrollWheel",0), fVar16 != 0.0)) {
            uVar7 = MouseController.mHover;
            local_res18[0] = fVar16;
            uVar8 = il2cpp_value_box(DAT_181d7d0b8,local_res18);
            MouseController.Notify(uVar7,"OnScroll",uVar8,0);
          }
          MouseController.currentTouchID = 0xffffff9c;
          return;
        }
        uVar7 = EventSystem.get_current(0);
        this.eventDataCurrentPosition = new PointerEventData(uVar7,0);
        lVar5 = this.eventDataCurrentPosition;
        puVar9 = (uint32 *)Input.get_mousePosition(local_78,0);
        uVar1 = *puVar9;
        puVar11 = (uint64 *)Input.get_mousePosition(local_78,0);
        local_88 = *puVar11;
        if (lVar5 != null) {
          local_88._4_4_ = (uint32)((uint64)local_88 >> 32);
          *(uint32 *)(lVar5 + 0x104) = local_88._4_4_;
          *(uint32 *)(lVar5 + 0x100) = uVar1;
          lVar5 = il2cpp_internal(DAT_181d718b0);
          FUN_180f58a90(lVar5,DAT_181d767d8);
          lVar10 = EventSystem.get_current(0);
          if ((lVar10 != null) &&
             (EventSystem.RaycastAll(lVar10,this.eventDataCurrentPosition,lVar5,0), lVar5 != null)) {
            uVar15 = 0;
            if (*(int *)(lVar5 + 24) < 1) {
              MouseController.hoveredUI = 0;
              uVar13 = uVar15;
            }
            else {
              lVar5 = *(int64 *)(lVar5 + 16);
              local_68 = *(uint32 *)(lVar5 + 32);
              uStack_64 = *(uint32 *)(lVar5 + 36);
              uStack_60 = *(uint32 *)(lVar5 + 40);
              uStack_5c = *(uint32 *)(lVar5 + 44);
              uVar13 = CONCAT44(uStack_64,local_68);
              MouseController.hoveredUI = uVar13;
            }
            il2cpp_internal(puVar12,uVar13);
            MouseController.set_hoveredObject(0,0);
            while( true ) {
              plVar2 = MouseController.mMouse;
              lVar5 = new MouseOrTouch(0);
              if (plVar2 == (int64 *)0) break;
              if ((lVar5 != null) &&
                 (lVar10 = il2cpp_internal(lVar5,*(uint64 *)(*plVar2 + 64))) == null) {
                uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar7,0);
              }
              FUN_180002fd0(plVar2,(int64)(int)uVar15,lVar5);
              uVar14 = (int)uVar15 + 1;
              uVar15 = (uint64)uVar14;
              if (2 < (int)uVar14) {
                return;
              }
            }
          }
        }
    }

    // Token : 0x60018F9
    // RVA   : 0xAF4EE0   Offset: 0xAF36E0   Length: 0xE4
    public void ClearMouse()
    {
        long lVar2;
        long lVar3;
        ulong uVar4;
        int iVar5;
        iVar5 = 0;
        do {
          plVar1 = MouseController.mMouse;
          lVar2 = new MouseOrTouch(0);
          if (plVar1 == (int64 *)0) {
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          if (lVar2 != null) {
            lVar3 = il2cpp_internal(lVar2,*(uint64 *)(*plVar1 + 64));
            if (lVar3 == null) {
              uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar4,0);
            }
          }
          FUN_180002fd0(plVar1,(int64)iVar5,lVar2);
          iVar5 = iVar5 + 1;
        } while (iVar5 < 3);
    }

    // Token : 0x60018FA
    // RVA   : 0xAF5B30   Offset: 0xAF4330   Length: 0xDFC
    public void ProcessMouse()
    {
        var pMouseController = *(int64*)(MouseController_StaticsPtr + 184);
        long lVar2;
        long lVar3;
        ulong uVar4;
        bool cVar9;
        bool cVar10;
        bool cVar11;
        ulong uVar13;
        int iVar14;
        uint uVar15;
        uint uVar16;
        float fVar17;
        float fVar18;
        uint uVar19;
        float local_78;
        ulong local_68;
        uint local_60;
        byte[] local_58 = new byte[48];
        bVar6 = false;
        bVar7 = false;
        iVar14 = 0;
        do {
          cVar9 = Input.GetMouseButtonDown(iVar14,0);
          if (!cVar9) {
            cVar9 = Input.GetMouseButton(iVar14);
            if (cVar9) {
              MouseController.set_currentKey(iVar14 + 0x143);
              bVar6 = true;
            }
          }
          else {
            MouseController.set_currentKey(iVar14 + 0x143);
            bVar7 = true;
            bVar6 = true;
          }
          iVar14 = iVar14 + 1;
        } while (iVar14 < 3);
        lVar2 = MouseController.mMouse;
        if (lVar2 != null) {
          if (*(int *)(lVar2 + 24) == 0) {
            uVar13 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar13,0);
          }
          MouseController.currentTouch =
               *(uint64 *)(lVar2 + 32);
          il2cpp_internal();
          puVar12 = (uint64 *)Input.get_mousePosition(local_58,0);
          local_68 = *puVar12;
          local_60 = *(uint32 *)(puVar12 + 1);
          lVar2 = MouseController.currentTouch;
          if (lVar2 != null) {
            local_78 = (float)local_68;
            local_68._4_4_ = (float)((uint64)local_68 >> 32);
            fVar18 = local_68._4_4_;
            if (lVar2.ignoreDelta == null) {
              lVar2 = MouseController.currentTouch;
              if (lVar2 == null) throw; // [null/range check failed]
              lVar2.delta = local_78 - lVar2.pos;
              *(float *)(lVar2 + 40) = fVar18 - *(float *)(lVar2 + 24);
            }
            else {
              lVar2 = MouseController.currentTouch;
              if (lVar2 == null) throw; // [null/range check failed]
              piVar1 = (int *)(lVar2 + 120);
              *piVar1 = *piVar1 + -1;
              lVar2 = MouseController.currentTouch;
              if (lVar2 == null) throw; // [null/range check failed]
              lVar2.delta = 0;
              lVar2 = MouseController.currentTouch;
              if (lVar2 == null) throw; // [null/range check failed]
              *(uint32 *)(lVar2 + 40) = 0;
            }
            lVar2 = MouseController.currentTouch;
            if (lVar2 != null) {
              fVar17 = (float)Vector2.get_sqrMagnitude(lVar2 + 36,0);
              lVar2 = MouseController.currentTouch;
              if (lVar2 != null) {
                lVar2.pos = local_78;
                uVar16 = 1;
                *(float *)(lVar2 + 24) = fVar18;
                lVar2 = pMouseController;
                *(float *)(lVar2 + 60) = local_78;
                lVar2.last = fVar18;
                bVar5 = 0.001 < fVar17;
                uVar15 = 1;
                do {
                  lVar2 = MouseController.mMouse;
                  if (lVar2 == null) throw; // [null/range check failed]
                  if (*(uint32 *)(lVar2 + 24) <= uVar15) {
                    uVar13 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                    FUN_1800d65f0(uVar13,0);
                  }
                  lVar3 = MouseController.currentTouch;
                  if (lVar3 == null) throw; // [null/range check failed]
                  uVar19 = *(uint32 *)(lVar3 + 24);
                  lVar2 = lVar2[uVar15];
                  if (lVar2 == null) throw; // [null/range check failed]
                  lVar2.pos = lVar3.pos;
                  *(uint32 *)(lVar2 + 24) = uVar19;
                  lVar2 = MouseController.mMouse;
                  if (lVar2 == null) throw; // [null/range check failed]
                  if (*(uint32 *)(lVar2 + 24) <= uVar15) {
                    uVar13 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                    FUN_1800d65f0(uVar13,0);
                  }
                  lVar3 = MouseController.currentTouch;
                  if (lVar3 == null) throw; // [null/range check failed]
                  uVar19 = *(uint32 *)(lVar3 + 40);
                  lVar2 = lVar2[uVar15];
                  if (lVar2 == null) throw; // [null/range check failed]
                  uVar15 = uVar15 + 1;
                  lVar2.delta = lVar3.delta;
                  *(uint32 *)(lVar2 + 40) = uVar19;
                } while ((int)uVar15 < 3);
                if ((bVar5 || bVar6) ||
                   (fVar18 = this.mNextRaycast, fVar17 = (float)RealTime.get_time(0),
                   fVar18 < fVar17)) {
                  fVar18 = (float)RealTime.get_time(0);
                  this.mNextRaycast = fVar18 + 0.02;
                  lVar2 = MouseController.currentTouch;
                  if (lVar2 == null) throw; // [null/range check failed]
                  uVar13 = lVar2.pos;
                  local_60 = 0;
                  local_68 = uVar13;
                  cVar9 = MouseController.Raycast(&local_68,0);
                  if (!cVar9) {
                    puVar12 = *(uint64 **)(MouseController_StaticsPtr + 184);
                    *puVar12 = 0;
                    il2cpp_internal(puVar12,0);
                  }
                  lVar2.last = lVar2.current;
                  lVar2.current = MouseController.mRayHitObject;
                  uVar19 = *(uint32 *)(lVar2 + 24);
                  lVar3 = pMouseController;
                  *(uint32 *)(lVar3 + 60) = lVar2.pos;
                  lVar3.last = uVar19;
                  if (bVar6) {
                    bVar5 = true;
                    uVar15 = 1;
                    do {
                      lVar2 = MouseController.mMouse;
                      if (lVar2 == null) throw; // [null/range check failed]
                      if (*(uint32 *)(lVar2 + 24) <= uVar15) {
                        uVar13 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                        FUN_1800d65f0(uVar13,0);
                      }
                      lVar3 = MouseController.currentTouch;
                      if (lVar3 == null) throw; // [null/range check failed]
                      lVar2 = lVar2[uVar15];
                      if (lVar2 == null) throw; // [null/range check failed]
                      lVar2.current = lVar3.current;
                      uVar15 = uVar15 + 1;
                    } while ((int)uVar15 < 3);
                  }
                  else {
                    lVar2 = MouseController.mMouse;
                    if (lVar2 == null) throw; // [null/range check failed]
                    if (*(int *)(lVar2 + 24) == 0) {
                      uVar13 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                      FUN_1800d65f0(uVar13,0);
                    }
                    if (*(int64 *)(lVar2 + 32) == 0) throw; // [null/range check failed]
                    lVar3 = MouseController.currentTouch;
                    uVar13 = *(uint64 *)(*(int64 *)(lVar2 + 32) + 72);
                    if (lVar3 == null) throw; // [null/range check failed]
                    uVar4 = lVar3.current;
                    cVar9 = Object.op_Inequality(uVar13,uVar4,0);
                    if (cVar9) {
                      MouseController.set_currentKey(0x143,0);
                      bVar5 = true;
                      uVar15 = 1;
                      do {
                        lVar2 = MouseController.mMouse;
                        if (lVar2 == null) throw; // [null/range check failed]
                        if (*(uint32 *)(lVar2 + 24) <= uVar15) {
                          uVar13 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                          FUN_1800d65f0(uVar13,0);
                        }
                        lVar3 = MouseController.currentTouch;
                        if (lVar3 == null) throw; // [null/range check failed]
                        lVar2 = lVar2[uVar15];
                        if (lVar2 == null) throw; // [null/range check failed]
                        lVar2.current = lVar3.current;
                        uVar15 = uVar15 + 1;
                      } while ((int)uVar15 < 3);
                    }
                  }
                }
                lVar2 = MouseController.currentTouch;
                if (lVar2 != null) {
                  uVar13 = lVar2.last;
                  uVar4 = lVar2.current;
                  cVar9 = Object.op_Inequality(uVar13,uVar4,0);
                  lVar2 = MouseController.currentTouch;
                  if (lVar2 != null) {
                    cVar10 = Object.op_Inequality(lVar2.pressed,0,0);
                    bVar8 = false;
                    if (!cVar10) {
                      bVar8 = bVar5;
                    }
                    if (bVar8) {
                      lVar2 = MouseController.currentTouch;
                      if (lVar2 == null) throw; // [null/range check failed]
                      MouseController.set_hoveredObject(lVar2.current,0);
                    }
                    MouseController.currentTouchID = 0xffffffff;
                    if (cVar9) {
                      if (MouseController.mCurrentKey != 0x143) {
                        MouseController.mCurrentKey = 0x143;
                      }
                      if ((bVar7) || ((cVar10 && (!bVar6)))) {
                        MouseController.set_hoveredObject(0,0);
                      }
                    }
                    uVar15 = 0;
                    do {
                      cVar10 = Input.GetMouseButtonDown(uVar15,0);
                      cVar11 = Input.GetMouseButtonUp(uVar15,0);
                      if (cVar11 || cVar10) {
                        MouseController.set_currentKey(uVar15 + 0x143,0);
                      }
                      lVar2 = MouseController.mMouse;
                      if (lVar2 == null) throw; // [null/range check failed]
                      if (*(uint32 *)(lVar2 + 24) <= uVar15) {
                        uVar13 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                        FUN_1800d65f0(uVar13,0);
                      }
                      MouseController.currentTouch =
                           lVar2[uVar15];
                      il2cpp_internal();
                      MouseController.currentTouchID = ~uVar15;
                      MouseController.set_currentKey(uVar15 + 0x143,0);
                      if (!cVar10) {
                        lVar2 = MouseController.currentTouch;
                        if (lVar2 == null) throw; // [null/range check failed]
                        uVar13 = lVar2.pressed;
                        cVar10 = Object.op_Inequality(uVar13,0,0);
                        if (cVar10) {
                          lVar2 = MouseController.currentTouch;
                          if (lVar2 == null) throw; // [null/range check failed]
                          MouseController.currentCamera =
                               lVar2.pressedCam;
                          il2cpp_internal();
                        }
                      }
                      else {
                        lVar2 = MouseController.currentTouch;
                        uVar13 = Camera.get_main(0);
                        if (lVar2 == null) throw; // [null/range check failed]
                        puVar12 = (uint64 *)(lVar2 + 56);
                        *puVar12 = uVar13;
                        il2cpp_internal(puVar12,uVar13);
                        lVar2 = MouseController.currentTouch;
                        uVar19 = RealTime.get_time(0);
                        if (lVar2 == null) throw; // [null/range check failed]
                        lVar2.pressTime = uVar19;
                      }
                      MouseController.ProcessTouch();
                      uVar15 = uVar15 + 1;
                    } while ((int)uVar15 < 1);
                    cVar10 = false;
                    if (!bVar6) {
                      cVar10 = cVar9;
                    }
                    if (cVar10) {
                      lVar2 = MouseController.mMouse;
                      if (lVar2 == null) throw; // [null/range check failed]
                      if (*(int *)(lVar2 + 24) == 0) {
                        uVar13 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                        FUN_1800d65f0(uVar13,0);
                      }
                      MouseController.currentTouch =
                           *(uint64 *)(lVar2 + 32);
                      il2cpp_internal();
                      MouseController.currentTouchID =
                           0xffffffff;
                      MouseController.set_currentKey(0x143,0);
                      lVar2 = MouseController.currentTouch;
                      if (lVar2 == null) throw; // [null/range check failed]
                      MouseController.set_hoveredObject(lVar2.current,0);
                    }
                    MouseController.currentTouch = 0;
                    lVar2 = MouseController.mMouse;
                    if (lVar2 != null) {
                      if (*(int *)(lVar2 + 24) == 0) {
                        uVar13 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                        FUN_1800d65f0(uVar13,0);
                      }
                      lVar2 = *(int64 *)(lVar2 + 32);
                      if (lVar2 != null) {
                        lVar2.last = lVar2.current;
                        while( true ) {
                          lVar2 = MouseController.mMouse;
                          if (lVar2 == null) break;
                          if (*(uint32 *)(lVar2 + 24) <= uVar16) {
                            uVar13 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                            FUN_1800d65f0(uVar13,0);
                          }
                          if (*(uint32 *)(lVar2 + 24) == 0) {
                            uVar13 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                            FUN_1800d65f0(uVar13,0);
                          }
                          if (*(int64 *)(lVar2 + 32) == 0) break;
                          lVar3 = lVar2[uVar16];
                          if (lVar3 == null) break;
                          lVar3.last =
                               *(uint64 *)(*(int64 *)(lVar2 + 32) + 64);
                          il2cpp_internal();
                          uVar16 = uVar16 + 1;
                          if (2 < (int)uVar16) {
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

    // Token : 0x60018FB
    // RVA   : 0xAF8370   Offset: 0xAF6B70   Length: 0x2AD
    public void ProcessTouch(bool pressed, bool released)
    {
        long lVar1;
        ulong uVar2;
        ulong uVar3;
        bool cVar4;
        float fVar5;
        float fVar6;
        fVar5 = this.mouseDragThreshold * this.mouseDragThreshold;
        fVar6 = this.mouseClickThreshold * this.mouseClickThreshold;
        lVar1 = MouseController.currentTouch;
        if (lVar1 != null) {
          uVar2 = lVar1.pressed;
          cVar4 = Object.op_Inequality(uVar2,0,0);
          if (!cVar4) {
            MouseController.ProcessPress(this,pressed,fVar6,fVar5,0);
            if (released) {
              MouseController.ProcessRelease(this,fVar5,0);
            }
          }
          else {
            if (released) {
              MouseController.ProcessRelease(this,fVar5,0);
            }
            MouseController.ProcessPress(this,pressed,fVar6,fVar5,0);
            lVar1 = MouseController.currentTouch;
            if (lVar1 == null) throw; // [null/range check failed]
            fVar5 = (float)MouseOrTouch.get_deltaTime(lVar1,0);
            if (1.0 < fVar5) {
              lVar1 = MouseController.currentTouch;
              if (lVar1 == null) throw; // [null/range check failed]
              uVar2 = lVar1.pressed;
              uVar3 = lVar1.current;
              cVar4 = Object.op_Equality(uVar2,uVar3,0);
              if (cVar4) {
                lVar1 = MouseController.currentTouch;
                if (lVar1 == null) throw; // [null/range check failed]
                if (!lVar1.dragStarted) {
                  lVar1 = MouseController.currentTouch;
                  if (lVar1 == null) throw; // [null/range check failed]
                  MouseController.Notify(lVar1.current,"OnLongPress",0,0);
                }
              }
            }
          }
          return;
        }
    }

    // Token : 0x60018FC
    // RVA   : 0xAF6930   Offset: 0xAF5130   Length: 0x10A9
    private void ProcessPress(bool pressed, float click, float drag)
    {
        var pMouseController = *(int64*)(MouseController_StaticsPtr + 184);
        int iVar1;
        long lVar2;
        bool cVar4;
        byte uVar5;
        ulong uVar6;
        long lVar7;
        ulong uVar8;
        ulong uVar10;
        float fVar11;
        byte[] local_res10 = new byte[8];
        ulong local_58;
        if (!pressed) {
          lVar7 = MouseController.currentTouch;
          if (lVar7 == null) goto LAB_180af79ce;
          uVar8 = lVar7.pressed;
          cVar4 = Object.op_Inequality(uVar8,0,0);
          if (!cVar4) {
            return;
          }
          lVar7 = MouseController.currentTouch;
          if (lVar7 == null) goto LAB_180af79ce;
          fVar11 = (float)Vector2.get_sqrMagnitude(lVar7 + 36,0);
          if (fVar11 == 0.0) {
            lVar7 = MouseController.currentTouch;
            if (lVar7 == null) goto LAB_180af79ce;
            uVar8 = lVar7.current;
            uVar6 = lVar7.last;
            cVar4 = Object.op_Inequality(uVar8,uVar6,0);
            if (!cVar4) {
              return;
            }
          }
          lVar7 = MouseController.currentTouch;
          if (lVar7 == null) goto LAB_180af79ce;
          lVar7.totalDelta = lVar7.delta + lVar7.totalDelta;
          *(float *)(lVar7 + 48) = *(float *)(lVar7 + 48) + *(float *)(lVar7 + 40);
          lVar7 = MouseController.currentTouch;
          if (lVar7 == null) goto LAB_180af79ce;
          fVar11 = (float)Vector2.get_sqrMagnitude(lVar7 + 44,0);
          bVar3 = false;
          lVar7 = MouseController.currentTouch;
          if (lVar7 == null) goto LAB_180af79ce;
          if (!lVar7.dragStarted) {
            lVar7 = MouseController.currentTouch;
            if (lVar7 == null) goto LAB_180af79ce;
            uVar8 = lVar7.last;
            uVar6 = lVar7.current;
            cVar4 = Object.op_Inequality(uVar8,uVar6,0);
            if (!cVar4) goto LAB_180af6d8a;
            lVar7 = MouseController.currentTouch;
            if (lVar7 == null) goto LAB_180af79ce;
            lVar7.dragStarted = 1;
            lVar7 = MouseController.currentTouch;
            if (lVar7 == null) goto LAB_180af79ce;
            lVar7.delta = lVar7.totalDelta;
            *(uint32 *)(lVar7 + 40) = *(uint32 *)(lVar7 + 48);
            lVar7 = MouseController.currentTouch;
            if (lVar7 == null) goto LAB_180af79ce;
            lVar7.clickNotification = 0;
            MouseController.isDragging = 1;
            lVar7 = MouseController.currentTouch;
            if (lVar7 == null) goto LAB_180af79ce;
            MouseController.Notify(lVar7.dragged,"OnDragStart",0,0);
            lVar7 = MouseController.currentTouch;
            if (lVar7 == null) goto LAB_180af79ce;
            MouseController.Notify
                      (lVar7.last,"OnDragOver",lVar7.dragged,0);
            MouseController.isDragging = 0;
          }
          else {
        LAB_180af6d8a:
            lVar7 = MouseController.currentTouch;
            if (lVar7 == null) goto LAB_180af79ce;
            bVar3 = false;
            if ((!lVar7.dragStarted) && (drag < fVar11)) {
              bVar3 = true;
              lVar7 = MouseController.currentTouch;
              if (lVar7 == null) goto LAB_180af79ce;
              lVar7.dragStarted = 1;
              lVar7 = MouseController.currentTouch;
              if (lVar7 == null) goto LAB_180af79ce;
              lVar7.delta = lVar7.totalDelta;
              *(uint32 *)(lVar7 + 40) = *(uint32 *)(lVar7 + 48);
            }
          }
          lVar7 = MouseController.currentTouch;
          if (lVar7 == null) goto LAB_180af79ce;
          if (!lVar7.dragStarted) {
            return;
          }
          MouseController.isDragging = 1;
          lVar7 = MouseController.currentTouch;
          if (lVar7 == null) goto LAB_180af79ce;
          iVar1 = lVar7.clickNotification;
          if (bVar3) {
            lVar7 = MouseController.currentTouch;
            if (lVar7 == null) goto LAB_180af79ce;
            uVar8 = 0;
            uVar6 = lVar7.dragged;
            uVar10 = "OnDragStart";
        LAB_180af6fb6:
            MouseController.Notify(uVar6,uVar10,uVar8,0);
            lVar7 = MouseController.currentTouch;
            if (lVar7 == null) goto LAB_180af79ce;
            MouseController.Notify
                      (lVar7.current,"OnDragOver",lVar7.dragged,0);
          }
          else {
            lVar7 = MouseController.currentTouch;
            if (lVar7 == null) goto LAB_180af79ce;
            uVar8 = lVar7.last;
            uVar6 = lVar7.current;
            cVar4 = Object.op_Inequality(uVar8,uVar6,0);
            if (cVar4) {
              lVar7 = MouseController.currentTouch;
              if (lVar7 == null) goto LAB_180af79ce;
              uVar8 = lVar7.dragged;
              uVar6 = lVar7.last;
              uVar10 = "OnDragOut";
              goto LAB_180af6fb6;
            }
          }
          lVar7 = MouseController.currentTouch;
          if (lVar7 == null) {
        LAB_180af79c8:
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          uVar8 = lVar7.dragged;
          local_58 = lVar7.delta;
          uVar6 = il2cpp_value_box(DAT_181d8e698,&local_58);
          MouseController.Notify(uVar8,"OnDrag",uVar6,0);
          lVar7 = MouseController.currentTouch;
          if (lVar7 == null) goto LAB_180af79c8;
          lVar7.last = lVar7.current;
          MouseController.isDragging = 0;
          if (iVar1 == 0) {
            lVar7 = pMouseController;
          }
          else {
            lVar7 = MouseController.currentTouch;
            if (lVar7 == null) goto LAB_180af79ce;
            if (lVar7.clickNotification != 2) {
              return;
            }
            if (fVar11 <= click) {
              return;
            }
            lVar7 = pMouseController;
          }
          if (*(int64 *)(lVar7 + 48) != 0) {
            *(uint32 *)(*(int64 *)(lVar7 + 48) + 112) = 0;
            return;
          }
          goto LAB_180af79ce;
        }
        lVar7 = MouseController.currentTouch;
        if (lVar7 == null) {
        LAB_180af79c2:
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
        lVar7.pressStarted = 1;
        lVar7 = MouseController.currentTouch;
        if (lVar7 == null) goto LAB_180af79c2;
        uVar8 = lVar7.pressed;
        local_res10[0] = 0;
        uVar6 = il2cpp_value_box(DAT_181d8d920,local_res10);
        MouseController.Notify(uVar8,"OnPress",uVar6,0);
        uVar8 = MouseController.mHover;
        cVar4 = Object.op_Implicit(uVar8,0);
        if (!cVar4) {
        LAB_180af730a:
          uVar8 = 0;
          MouseController.mHover = 0;
        }
        else {
          lVar7 = MouseController.mHover;
          if (lVar7 == null) goto LAB_180af79c2;
          cVar4 = GameObject.get_activeInHierarchy(lVar7,0);
          if (!cVar4) goto LAB_180af730a;
          uVar8 = MouseController.mHover;
        }
        cVar4 = Object.op_Equality(uVar8,0,0);
        if (cVar4) {
          lVar7 = MouseController.currentTouch;
          if (lVar7 == null) goto LAB_180af79ce;
          uVar8 = lVar7.current;
          cVar4 = Object.op_Inequality(uVar8,0,0);
          if (cVar4) {
            lVar7 = MouseController.currentTouch;
            if (lVar7 == null) goto LAB_180af79ce;
            MouseController.set_hoveredObject(lVar7.current,0);
          }
        }
        lVar7 = MouseController.currentTouch;
        if (lVar7 != null) {
          lVar7.pressed = lVar7.current;
          lVar7 = MouseController.currentTouch;
          if (lVar7 != null) {
            lVar7.dragged = lVar7.current;
            lVar7 = MouseController.currentTouch;
            if (lVar7 != null) {
              lVar7.clickNotification = 2;
              lVar7 = MouseController.currentTouch;
              local_58 = Vector2.get_zero(0);
              if (lVar7 != null) {
                local_58._4_4_ = (uint32)((uint64)local_58 >> 32);
                lVar7.totalDelta = (uint32)local_58;
                *(uint32 *)(lVar7 + 48) = local_58._4_4_;
                lVar7 = MouseController.currentTouch;
                if (lVar7 != null) {
                  lVar7.dragStarted = 0;
                  lVar7 = MouseController.currentTouch;
                  if (lVar7 != null) {
                    uVar8 = lVar7.pressed;
                    local_res10[0] = 1;
                    uVar6 = il2cpp_value_box(DAT_181d8d920,local_res10);
                    MouseController.Notify(uVar8,"OnPress",uVar6,0);
                    lVar7 = MouseController.currentTouch;
                    uVar8 = MouseController.mSelected;
                    if (lVar7 != null) {
                      uVar6 = lVar7.pressed;
                      cVar4 = Object.op_Inequality(uVar8,uVar6,0);
                      if (!cVar4) {
                        return;
                      }
                      MouseController.mInputFocus = 0;
                      uVar8 = MouseController.mSelected;
                      cVar4 = Object.op_Implicit(uVar8,0);
                      if (cVar4) {
                        uVar8 = MouseController.mSelected;
                        local_res10[0] = 0;
                        uVar6 = il2cpp_value_box(DAT_181d8d920,local_res10);
                        MouseController.Notify(uVar8,"OnSelect",uVar6,0);
                      }
                      lVar7 = MouseController.currentTouch;
                      if (lVar7 != null) {
                        MouseController.mSelected =
                             lVar7.pressed;
                        il2cpp_internal();
                        lVar7 = MouseController.currentTouch;
                        if (lVar7 != null) {
                          uVar8 = lVar7.pressed;
                          cVar4 = Object.op_Inequality(uVar8,0,0);
                          if (cVar4) {
                            lVar7 = MouseController.currentTouch
                            ;
                            if ((lVar7 = lVar7?.pressed) == null)
                            goto LAB_180af79ce;
                            uVar8 = GameObject.GetComponent(lVar7,DAT_181da2730);
                            cVar4 = Object.op_Inequality(uVar8,0,0);
                            if (cVar4) {
                              lVar7 = *(int64 *)
                                       (pMouseController + 48);
                              lVar2 = *(int64 *)
                                       (pMouseController + 40);
                              if ((lVar7 == null) || (lVar2 == null)) goto LAB_180af79ce;
                              *(uint64 *)(lVar2 + 72) = lVar7.pressed;
                            }
                          }
                          uVar8 = MouseController.mSelected
                          ;
                          cVar4 = Object.op_Implicit(uVar8,0);
                          if (!cVar4) {
                            return;
                          }
                          lVar7 = MouseController.mSelected;
                          if (lVar7 != null) {
                            cVar4 = GameObject.get_activeInHierarchy(lVar7,0);
                            if (!cVar4) {
                              uVar5 = 0;
                            }
                            else {
                              lVar7 = *(int64 *)
                                       (pMouseController + 16);
                              if (lVar7 == null) goto LAB_180af79ce;
                              uVar8 = GameObject.GetComponent(lVar7,DAT_181da26b0);
                              uVar5 = Object.op_Inequality(uVar8,0,0);
                            }
                            MouseController.mInputFocus =
                                 uVar5;
                            uVar8 = *(uint64 *)
                                     (pMouseController + 16);
                            local_res10[0] = 1;
                            uVar6 = il2cpp_value_box(DAT_181d8d920,local_res10);
                            MouseController.Notify(uVar8,"OnSelect",uVar6,0);
                            return;
                          }
                        }
                      }
        LAB_180af79ce:
                          // WARNING: Subroutine does not return
                      FUN_1800d6620();
                    }
                  }
                }
              }
            }
          }
        }
    }

    // Token : 0x60018FD
    // RVA   : 0xAF79E0   Offset: 0xAF61E0   Length: 0x986
    private void ProcessRelease(float drag)
    {
        ulong uVar1;
        bool cVar2;
        ulong uVar3;
        long lVar4;
        long lVar5;
        float fVar7;
        byte[] local_res20 = new byte[8];
        if (MouseController.currentTouch == null) {
          return;
        }
        lVar5 = MouseController.currentTouch;
        if (lVar5 == null) throw; // [null/range check failed]
        lVar5.pressStarted = 0;
        lVar5 = MouseController.currentTouch;
        if (lVar5 == null) throw; // [null/range check failed]
        uVar1 = lVar5.pressed;
        cVar2 = Object.op_Inequality(uVar1,0,0);
        if (cVar2) {
          lVar5 = MouseController.currentTouch;
          if (lVar5 == null) throw; // [null/range check failed]
          if (lVar5.dragStarted) {
            lVar5 = MouseController.currentTouch;
            if (lVar5 == null) throw; // [null/range check failed]
            MouseController.Notify
                      (lVar5.last,"OnDragOut",lVar5.dragged,0);
            lVar5 = MouseController.currentTouch;
            if (lVar5 == null) throw; // [null/range check failed]
            MouseController.Notify(lVar5.dragged,"OnDragEnd",0,0);
          }
          lVar5 = MouseController.currentTouch;
          if (lVar5 == null) {
        LAB_180af8361:
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          uVar1 = lVar5.pressed;
          local_res20[0] = 0;
          uVar3 = il2cpp_value_box(DAT_181d8d920,local_res20);
          MouseController.Notify(uVar1,"OnPress",uVar3,0);
          lVar5 = MouseController.currentTouch;
          if (lVar5 == null) goto LAB_180af8361;
          lVar5 = lVar5.pressed;
          cVar2 = Object.op_Equality(lVar5,0,0);
          if (!cVar2) {
            if (lVar5 == null) goto LAB_180af8361;
            lVar4 = GameObject.GetComponent(lVar5,DAT_181d9f328);
            cVar2 = Object.op_Inequality(lVar4,0,0);
            if (!cVar2) {
              lVar5 = GameObject.GetComponent(lVar5,DAT_181d9f3b0);
              cVar2 = Object.op_Inequality(lVar5,0,0);
              if (!cVar2) goto LAB_180af7e66;
              if (lVar5 == null) goto LAB_180af8361;
              cVar2 = Behaviour.get_enabled(lVar5,0);
            }
            else {
              if (lVar4 == null) goto LAB_180af8361;
              cVar2 = Collider.get_enabled(lVar4,0);
            }
            if (cVar2) {
              lVar5 = MouseController.currentTouch;
              uVar1 = MouseController.mHover;
              if (lVar5 == null) throw; // [null/range check failed]
              uVar3 = lVar5.current;
              cVar2 = Object.op_Equality(uVar1,uVar3,0);
              if (!cVar2) {
                lVar5 = MouseController.currentTouch;
                if (lVar5 == null) throw; // [null/range check failed]
                MouseController.set_hoveredObject(lVar5.current,0);
              }
              else {
                lVar5 = MouseController.currentTouch;
                if (lVar5 == null) {
                          // WARNING: Subroutine does not return
                  FUN_1800d6620();
                }
                uVar1 = lVar5.current;
                local_res20[0] = 1;
                uVar3 = il2cpp_value_box(DAT_181d8d920,local_res20);
                MouseController.Notify(uVar1,"OnHover",uVar3,0);
              }
            }
          }
        LAB_180af7e66:
          lVar5 = MouseController.currentTouch;
          if (lVar5 == null) throw; // [null/range check failed]
          uVar1 = lVar5.dragged;
          uVar3 = lVar5.current;
          cVar2 = Object.op_Equality(uVar1,uVar3,0);
          if (!cVar2) {
            lVar5 = MouseController.currentTouch;
            if (lVar5 == null) throw; // [null/range check failed]
            if (lVar5.clickNotification != null) {
              lVar5 = MouseController.currentTouch;
              if (lVar5 == null) throw; // [null/range check failed]
              fVar7 = (float)Vector2.get_sqrMagnitude(lVar5 + 44,0);
              if (fVar7 < drag) goto LAB_180af80f9;
            }
            lVar5 = MouseController.currentTouch;
            if (lVar5 == null) throw; // [null/range check failed]
            if (lVar5.dragStarted) {
              lVar5 = MouseController.currentTouch;
              if (lVar5 == null) throw; // [null/range check failed]
              MouseController.Notify
                        (lVar5.current,"OnDrop",lVar5.dragged,0);
            }
          }
          else {
        LAB_180af80f9:
            lVar5 = MouseController.currentTouch;
            if (lVar5 == null) throw; // [null/range check failed]
            if (lVar5.clickNotification != null) {
              lVar5 = MouseController.currentTouch;
              if (lVar5 == null) throw; // [null/range check failed]
              uVar1 = lVar5.pressed;
              uVar3 = lVar5.current;
              cVar2 = Object.op_Equality(uVar1,uVar3,0);
              if (cVar2) {
                fVar7 = (float)RealTime.get_time(0);
                lVar5 = MouseController.currentTouch;
                if (lVar5 == null) throw; // [null/range check failed]
                MouseController.Notify(lVar5.pressed,"OnClick",0,0);
                lVar5 = MouseController.currentTouch;
                if (lVar5 == null) throw; // [null/range check failed]
                if (fVar7 < lVar5.clickTime + 0.35) {
                  lVar5 = MouseController.currentTouch;
                  if (lVar5 == null) throw; // [null/range check failed]
                  uVar1 = lVar5.lastClickGO;
                  uVar3 = lVar5.pressed;
                  cVar2 = Object.op_Equality(uVar1,uVar3,0);
                  if (cVar2) {
                    lVar5 = MouseController.currentTouch;
                    if (lVar5 == null) throw; // [null/range check failed]
                    MouseController.Notify(lVar5.pressed,"OnDoubleClick",0,0);
                  }
                }
                lVar5 = MouseController.currentTouch;
                if (lVar5 == null) throw; // [null/range check failed]
                lVar5.lastClickGO = lVar5.pressed;
                lVar5 = MouseController.currentTouch;
                if (lVar5 == null) throw; // [null/range check failed]
                lVar5.clickTime = fVar7;
              }
            }
          }
        }
        lVar5 = MouseController.currentTouch;
        if (lVar5 != null) {
          lVar5.dragStarted = 0;
          lVar5 = MouseController.currentTouch;
          if (lVar5 != null) {
            puVar6 = (uint64 *)(lVar5 + 80);
            *puVar6 = 0;
            il2cpp_internal(puVar6,0);
            lVar5 = MouseController.currentTouch;
            if (lVar5 != null) {
              puVar6 = (uint64 *)(lVar5 + 88);
              *puVar6 = 0;
              il2cpp_internal(puVar6,0);
              return;
            }
          }
        }
    }

    // Token : 0x60018FE
    // RVA   : 0xAF4FD0   Offset: 0xAF37D0   Length: 0x14A
    private bool HasCollider(GameObject go)
    {
        long lVar1;
        bool cVar2;
        byte uVar3;
        cVar2 = Object.op_Equality(go,0,0);
        if (cVar2) {
          return false;
        }
        if (go != null) {
          lVar1 = GameObject.GetComponent(go,DAT_181d9f328);
          cVar2 = Object.op_Inequality(lVar1,0,0);
          if (!cVar2) {
            lVar1 = GameObject.GetComponent(go,DAT_181d9f3b0);
            cVar2 = Object.op_Inequality(lVar1,0,0);
            if (!cVar2) {
              return false;
            }
            if (lVar1 != null) {
              uVar3 = Behaviour.get_enabled(lVar1,0);
              return uVar3;
            }
          }
          else if (lVar1 != null) {
            uVar3 = Collider.get_enabled(lVar1,0);
            return uVar3;
          }
        }
    }

    // Token : 0x60018FF
    // RVA   : 0xAF8DA0   Offset: 0xAF75A0   Length: 0x15
    public void /*ctor*/()
    {
        this.mouseDragThreshold = 0x40800000;
        this.mouseClickThreshold = 0x41200000;
        FUN_18044ef50(this,0);
    }

    // Token : 0x6001900
    // RVA   : 0xAF8A70   Offset: 0xAF7270   Length: 0x325
    private static void /*cctor*/()
    {
        var pMouseController = *(int64*)(MouseController_StaticsPtr + 184);
        long lVar2;
        long lVar3;
        ulong uVar4;
        uint local_res10;
        uint uStackX_14;
        byte[] local_18 = new byte[16];
        MouseController.currentCamera = 0;
        plVar1 = (int64 *)FUN_1800d60b0(DAT_181d837c0,3);
        lVar2 = new MouseOrTouch(0);
        if (plVar1 == (int64 *)0) {
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
        if (lVar2 != null) {
          lVar3 = il2cpp_internal(lVar2,*(uint64 *)(*plVar1 + 64));
          if (lVar3 == null) {
            uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar4,0);
          }
        }
        if ((int)plVar1[3] == 0) {
          uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
          FUN_1800d65f0(uVar4,0);
        }
        plVar1[4] = lVar2;
        il2cpp_internal(plVar1 + 4,lVar2);
        lVar2 = new MouseOrTouch(0);
        if (lVar2 != null) {
          lVar3 = il2cpp_internal(lVar2,*(uint64 *)(*plVar1 + 64));
          if (lVar3 == null) {
            uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar4,0);
          }
        }
        if (*(uint32 *)(plVar1 + 3) < 2) {
          uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
          FUN_1800d65f0(uVar4,0);
        }
        plVar1[5] = lVar2;
        il2cpp_internal(plVar1 + 5,lVar2);
        lVar2 = new MouseOrTouch(0);
        if (lVar2 != null) {
          lVar3 = il2cpp_internal(lVar2,*(uint64 *)(*plVar1 + 64));
          if (lVar3 == null) {
            uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar4,0);
          }
        }
        if (2 < *(uint32 *)(plVar1 + 3)) {
          plVar1[6] = lVar2;
          il2cpp_internal(plVar1 + 6,lVar2);
          MouseController.mMouse = plVar1;
          uVar4 = new MouseOrTouch(0);
          MouseController.controller = uVar4;
          MouseController.currentTouch = 0;
          MouseController.mInputFocus = 0;
          uVar4 = Vector2.get_zero(0);
          local_res10 = (uint32)uVar4;
          uStackX_14 = (uint32)((uint64)uVar4 >> 32);
          lVar2 = pMouseController;
          *(uint32 *)(lVar2 + 60) = local_res10;
          *(uint32 *)(lVar2 + 64) = uStackX_14;
          MouseController.isDragging = 0;
          MouseController.currentTouchID = 0xffffff9c;
          MouseController.mCurrentKey = 48;
          puVar5 = (uint64 *)Vector3.get_zero(local_18,0);
          lVar2 = pMouseController;
          *(uint64 *)(lVar2 + 88) = *puVar5;
          *(uint32 *)(lVar2 + 96) = *(uint32 *)(puVar5 + 1);
          lVar2 = pMouseController;
          *(uint64 *)(lVar2 + 100) = 0;
          *(uint64 *)(lVar2 + 108) = 0;
          *(uint64 *)(lVar2 + 116) = 0;
          MouseController.mNotifying = 0;
          return;
        }
        uVar4 = il2cpp_internal();
    }

}
