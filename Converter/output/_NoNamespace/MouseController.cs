// ============================================================
// Type  : MouseController
// Token : 0x200030B
// ============================================================

public class MouseController
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001914
    private static GameObject mRayHitObject;

    // Token: 0x4001915
    private static GameObject mHover;

    // Token: 0x4001916
    private static GameObject mSelected;

    // Token: 0x4001917
    public static Camera currentCamera;

    // Token: 0x4001918
    private static MouseOrTouch[] mMouse;

    // Token: 0x4001919
    public static MouseOrTouch controller;

    // Token: 0x400191A
    public static MouseOrTouch currentTouch;

    // Token: 0x400191B
    private static bool mInputFocus;

    // Token: 0x400191C
    private static Vector2 mLastPos;

    // Token: 0x400191D
    private float mNextRaycast;

    // Token: 0x400191E
    public static bool isDragging;

    // Token: 0x400191F
    public static GameObject hoveredUI;

    // Token: 0x4001920
    public static int currentTouchID;

    // Token: 0x4001921
    private static KeyCode mCurrentKey;

    // Token: 0x4001922
    public static Vector3 lastWorldPosition;

    // Token: 0x4001923
    public static Ray lastWorldRay;

    // Token: 0x4001924
    public static RaycastHit lastHit;

    // Token: 0x4001925
    private readonly List<RaycastResult> uiRaycastResults;

    // Token: 0x4001926
    private PointerEventData cachedPointerData;

    // Token: 0x4001927
    private bool cachedOverUI;

    // Token: 0x4001928
    private GameObject cachedTopUI;

    // Token: 0x4001929
    private static int mNotifying;

    // Token: 0x400192A
    private static RaycastHit[] mRayHits;

    // Token: 0x400192B
    private static Collider2D[] mOverlap;

    // Token: 0x400192C
    public float mouseDragThreshold;

    // Token: 0x400192D
    public float mouseClickThreshold;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6001949
    // RVA   : 0xDF3C40   Offset: 0xDF3040   Length: 0x7C
    public static MouseOrTouch get_mouse0()
    {
        long lVar1;
        ulong uVar2;
        lVar1 = *(int64 *)(*(int64 *)(DAT_181d8b7a8 + 184) + 32);
        if (lVar1 != null) {
          if (*(int *)(lVar1 + 24) != 0) {
            return *(uint64 *)(lVar1 + 32);
          }
          uVar2 = il2cpp_internal();
                          // WARNING: Subroutine does not return
          FUN_1800d65f0(uVar2,0);
        }
    }

    // Token : 0x600194A
    // RVA   : 0xDF3CC0   Offset: 0xDF30C0   Length: 0x7C
    public static MouseOrTouch get_mouse1()
    {
        long lVar1;
        ulong uVar2;
        lVar1 = *(int64 *)(*(int64 *)(DAT_181d8b7a8 + 184) + 32);
        if (lVar1 != null) {
          if (1 < *(uint32 *)(lVar1 + 24)) {
            return *(uint64 *)(lVar1 + 40);
          }
          uVar2 = il2cpp_internal();
                          // WARNING: Subroutine does not return
          FUN_1800d65f0(uVar2,0);
        }
    }

    // Token : 0x600194B
    // RVA   : 0xDF3D40   Offset: 0xDF3140   Length: 0x7C
    public static MouseOrTouch get_mouse2()
    {
        long lVar1;
        ulong uVar2;
        lVar1 = *(int64 *)(*(int64 *)(DAT_181d8b7a8 + 184) + 32);
        if (lVar1 != null) {
          if (2 < *(uint32 *)(lVar1 + 24)) {
            return *(uint64 *)(lVar1 + 48);
          }
          uVar2 = il2cpp_internal();
                          // WARNING: Subroutine does not return
          FUN_1800d65f0(uVar2,0);
        }
    }

    // Token : 0x600194C
    // RVA   : 0xDF3AE0   Offset: 0xDF2EE0   Length: 0x15F
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

    // Token : 0x600194D
    // RVA   : 0xDF3E50   Offset: 0xDF3250   Length: 0x256
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
            uVar3 = il2cpp_value_box(DAT_181db2ae0,local_res8);
            MouseController.Notify(uVar1,"OnHover",uVar3,0);
          }
          MouseController.mHover = value;
          uVar1 = MouseController.mHover;
          cVar2 = Object.op_Implicit(uVar1,0);
          if (cVar2) {
            uVar1 = MouseController.mHover;
            local_res8[0] = 1;
            uVar3 = il2cpp_value_box(DAT_181db2ae0,local_res8);
            MouseController.Notify(uVar1,"OnHover",uVar3,0);
          }
        }
    }

    // Token : 0x600194E
    // RVA   : 0xDF3A80   Offset: 0xDF2E80   Length: 0x57
    public static KeyCode get_currentKey()
    {
        return *(uint32 *)(*(int64 *)(DAT_181d8b7a8 + 184) + 84);
    }

    // Token : 0x600194F
    // RVA   : 0xDF3DC0   Offset: 0xDF31C0   Length: 0x83
    public static void set_currentKey(KeyCode value)
    {
        if (MouseController.mCurrentKey != value) {
          MouseController.mCurrentKey = value;
        }
    }

    // Token : 0x6001950
    // RVA   : 0xDF3A50   Offset: 0xDF2E50   Length: 0x29
    private static bool get_IsMobilePlatform()
    {
        int iVar1;
        iVar1 = Application.get_platform(0);
        if (iVar1 == 8) {
          return true;
        }
        iVar1 = Application.get_platform(0);
        return iVar1 == 11;
    }

    // Token : 0x6001951
    // RVA   : 0xDF3660   Offset: 0xDF2A60   Length: 0x29
    private void Update()
    {
        bool cVar1;
        cVar1 = Application.get_isFocused(0);
        if (cVar1) {
          MouseController.ProcessEvents(this,0);
          return;
        }
    }

    // Token : 0x6001952
    // RVA   : 0xDEFEA0   Offset: 0xDEF2A0   Length: 0x13A
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

    // Token : 0x6001953
    // RVA   : 0xDF3230   Offset: 0xDF2630   Length: 0x14F
    public static void Raycast(MouseOrTouch touch)
    {
        var pStatics = *(int64*)(DAT_181d8b7a8 + 184);
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
                  lVar6 = pStatics;
                  *(uint64 *)(lVar6 + 100) = uVar1;
                  *(uint64 *)(lVar6 + 108) = uVar2;
                  *(uint64 *)(lVar6 + 116) = uVar9;
                  local_58 = uVar1;
                  uStack_50 = uVar2;
                  local_48 = uVar9;
                  cVar3 = Physics.Raycast(&local_58,pStatics + 124,
                                           fVar10 - fVar11,uVar5,1,0);
                  if (cVar3) {
                    puVar8 = (uint64 *)
                             FUN_18045e0a0(&local_58,pStatics + 124,0);
                    lVar6 = pStatics;
                    *(uint64 *)(lVar6 + 88) = *puVar8;
                    *(uint32 *)(lVar6 + 96) = *(uint32 *)(puVar8 + 1);
                    lVar6 = RaycastHit.get_collider(pStatics + 124,0);
                    if (lVar6 != null) {
                      uVar9 = Component.get_gameObject(lVar6,0);
                      puVar8 = *(uint64 **)(DAT_181d8b7a8 + 184);
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

    // Token : 0x6001954
    // RVA   : 0xDF2F60   Offset: 0xDF2360   Length: 0x2CE
    public static bool Raycast(Vector3 inPos)
    {
        var pStatics = *(int64*)(DAT_181d8b7a8 + 184);
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
                  lVar6 = pStatics;
                  *(uint64 *)(lVar6 + 100) = uVar1;
                  *(uint64 *)(lVar6 + 108) = uVar2;
                  *(uint64 *)(lVar6 + 116) = uVar9;
                  local_58 = uVar1;
                  uStack_50 = uVar2;
                  local_48 = uVar9;
                  cVar3 = Physics.Raycast(&local_58,pStatics + 124,
                                           fVar10 - fVar11,uVar5,1,0);
                  if (cVar3) {
                    puVar8 = (uint64 *)
                             FUN_18045e0a0(&local_58,pStatics + 124,0);
                    lVar6 = pStatics;
                    *(uint64 *)(lVar6 + 88) = *puVar8;
                    *(uint32 *)(lVar6 + 96) = *(uint32 *)(puVar8 + 1);
                    lVar6 = RaycastHit.get_collider(pStatics + 124,0);
                    if (lVar6 != null) {
                      uVar9 = Component.get_gameObject(lVar6,0);
                      puVar8 = *(uint64 **)(DAT_181d8b7a8 + 184);
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

    // Token : 0x6001955
    // RVA   : 0xDF3380   Offset: 0xDF2780   Length: 0x2DA
    private bool UpdateUIHover()
    {
        uint uVar1;
        bool cVar2;
        byte uVar3;
        int iVar4;
        long lVar5;
        ulong uVar6;
        long lVar9;
        ulong local_88;
        byte[] local_78 = new byte[112];
        lVar5 = EventSystem.get_current(0);
        cVar2 = Object.op_Equality(lVar5,0,0);
        if (cVar2) {
        LAB_180df3616:
          this.cachedOverUI = 0;
          this.cachedTopUI = 0;
          return false;
        }
        iVar4 = Application.get_platform(0);
        if ((iVar4 != 8) && (iVar4 = Application.get_platform(0), iVar4 != 11)) {
          if (lVar5 == null) throw; // [null/range check failed]
          cVar2 = EventSystem.IsPointerOverGameObject(lVar5,0);
          if (!cVar2) goto LAB_180df3616;
        }
        lVar9 = this.cachedPointerData;
        if (lVar9 == null) {
          this.cachedPointerData = new PointerEventData(lVar5,0);
          lVar9 = this.cachedPointerData;
        }
        puVar7 = (uint32 *)Input.get_mousePosition(&local_88,0);
        uVar1 = *puVar7;
        puVar8 = (uint64 *)Input.get_mousePosition(local_78,0);
        local_88 = *puVar8;
        if (lVar9 != null) {
          local_88._4_4_ = (uint32)((uint64)local_88 >> 32);
          *(uint32 *)(lVar9 + 0x104) = local_88._4_4_;
          *(uint32 *)(lVar9 + 0x100) = uVar1;
          if ((this.uiRaycastResults != null) &&
             (FUN_1812fa020(this.uiRaycastResults,DAT_181d9e2a0), lVar5 != null)) {
            EventSystem.RaycastAll
                      (lVar5,this.cachedPointerData,this.uiRaycastResults,0);
            lVar5 = this.uiRaycastResults;
            if (lVar5 != null) {
              if (lVar5.Count < 1) {
                uVar6 = 0;
              }
              else {
                if (lVar5.Count == null) {
                  ThrowHelper.ThrowArgumentOutOfRangeException(0);
                }
                uVar6 = *(uint64 *)(lVar5._items + 32);
              }
              this.cachedTopUI = uVar6;
              iVar4 = Application.get_platform(0);
              if ((iVar4 != 8) && (iVar4 = Application.get_platform(0), iVar4 != 11)) {
                this.cachedOverUI = 1;
                return true;
              }
              uVar6 = this.cachedTopUI;
              uVar3 = Object.op_Inequality(uVar6,0,0);
              this.cachedOverUI = uVar3;
              return uVar3;
            }
          }
        }
    }

    // Token : 0x6001956
    // RVA   : 0xDEFE90   Offset: 0xDEF290   Length: 0x7
    public bool IsPointerOverGameUI()
    {
        void FUN_180defe90(uint64 this)
        {
        MouseController.UpdateUIHover(this,0);
    }

    // Token : 0x6001957
    // RVA   : 0xDEFFE0   Offset: 0xDEF3E0   Length: 0x484
    private void ProcessEvents()
    {
        bool cVar2;
        ulong uVar3;
        long lVar4;
        ulong uVar5;
        long lVar6;
        int iVar8;
        float fVar9;
        float[] local_res18 = new float[4];
        cVar2 = MouseController.UpdateUIHover(this,0);
        if (!cVar2) {
          MouseController.hoveredUI = 0;
          uVar3 = UICamera.get_hoveredObject(0);
          cVar2 = Object.op_Inequality(uVar3,0,0);
          if (cVar2) {
            lVar4 = UICamera.get_hoveredObject(0);
            if (lVar4 == null) throw; // [null/range check failed]
            uVar3 = Object.get_name(lVar4,0);
            cVar2 = String.op_Inequality(uVar3,"UI Root",0);
            if (cVar2) {
              MouseController.set_hoveredObject(0,0);
              return;
            }
          }
          MouseController.ProcessMouse(this,0);
          uVar3 = MouseController.mHover;
          cVar2 = Object.op_Inequality(uVar3,0,0);
          if ((cVar2) && (fVar9 = (float)Input.GetAxis("Mouse ScrollWheel",0), fVar9 != 0.0)) {
            uVar3 = MouseController.mHover;
            local_res18[0] = fVar9;
            uVar5 = il2cpp_value_box(DAT_181da22f0,local_res18);
            MouseController.Notify(uVar3,"OnScroll",uVar5,0);
          }
          MouseController.currentTouchID = 0xffffff9c;
          return;
        }
        uVar3 = this.cachedTopUI;
        uVar5 = MouseController.hoveredUI;
        cVar2 = Object.op_Inequality(uVar5,uVar3,0);
        if (cVar2) {
          uVar3 = this.cachedTopUI;
          MouseController.hoveredUI = uVar3;
        }
        MouseController.set_hoveredObject(0,0);
        iVar8 = 0;
        while( true ) {
          plVar1 = MouseController.mMouse;
          lVar4 = new MouseOrTouch(0);
          if (plVar1 == (int64 *)0) break;
          if ((lVar4 != null) &&
             (lVar6 = il2cpp_internal(lVar4,*(uint64 *)(*plVar1 + 64))) == null) {
            uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar3,0);
          }
          FUN_180002fd0(plVar1,(int64)iVar8,lVar4);
          iVar8 = iVar8 + 1;
          if (2 < iVar8) {
            return;
          }
        }
    }

    // Token : 0x6001958
    // RVA   : 0xDEFC50   Offset: 0xDEF050   Length: 0xE4
    public void ClearMouse()
    {
        long lVar2;
        long lVar3;
        ulong uVar4;
        int iVar5;
        iVar5 = 0;
        do {
          plVar1 = *(int64 **)(*(int64 *)(DAT_181d8b7a8 + 184) + 32);
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

    // Token : 0x6001959
    // RVA   : 0xDF0470   Offset: 0xDEF870   Length: 0xDFC
    public void ProcessMouse()
    {
        var pStatics = *(int64*)(DAT_181d8b7a8 + 184);
        long lVar2;
        long lVar3;
        ulong uVar4;
        bool cVar9;
        bool cVar10;
        bool cVar11;
        bool cVar12;
        ulong uVar14;
        int iVar15;
        uint uVar16;
        uint uVar17;
        float fVar18;
        float fVar19;
        uint uVar20;
        float local_78;
        ulong local_68;
        uint local_60;
        byte[] local_58 = new byte[48];
        bVar6 = false;
        bVar7 = false;
        iVar15 = 0;
        do {
          cVar9 = Input.GetMouseButtonDown(iVar15,0);
          if (!cVar9) {
            cVar9 = Input.GetMouseButton(iVar15);
            if (cVar9) {
              MouseController.set_currentKey(iVar15 + 0x143);
              bVar6 = true;
            }
          }
          else {
            MouseController.set_currentKey(iVar15 + 0x143);
            bVar7 = true;
            bVar6 = true;
          }
          iVar15 = iVar15 + 1;
        } while (iVar15 < 3);
        lVar2 = MouseController.mMouse;
        if (lVar2 != null) {
          if (*(int *)(lVar2 + 24) == 0) {
            uVar14 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar14,0);
          }
          MouseController.currentTouch = *(uint64 *)(lVar2 + 32);
          puVar13 = (uint64 *)Input.get_mousePosition(local_58,0);
          local_68 = *puVar13;
          local_60 = *(uint32 *)(puVar13 + 1);
          lVar2 = MouseController.currentTouch;
          if (lVar2 != null) {
            local_78 = (float)local_68;
            local_68._4_4_ = (float)((uint64)local_68 >> 32);
            fVar19 = local_68._4_4_;
            if (lVar2.ignoreDelta == null) {
              lVar2 = MouseController.currentTouch;
              if (lVar2 == null) throw; // [null/range check failed]
              lVar2.delta = local_78 - lVar2.pos;
              *(float *)(lVar2 + 40) = fVar19 - *(float *)(lVar2 + 24);
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
              fVar18 = (float)Vector2.get_sqrMagnitude(lVar2 + 36,0);
              lVar2 = MouseController.currentTouch;
              if (lVar2 != null) {
                lVar2.pos = local_78;
                uVar17 = 1;
                *(float *)(lVar2 + 24) = fVar19;
                lVar2 = pStatics;
                *(float *)(lVar2 + 60) = local_78;
                lVar2.last = fVar19;
                bVar5 = 0.001 < fVar18;
                uVar16 = 1;
                do {
                  lVar2 = MouseController.mMouse;
                  if (lVar2 == null) throw; // [null/range check failed]
                  if (*(uint32 *)(lVar2 + 24) <= uVar16) {
                    uVar14 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                    FUN_1800d65f0(uVar14,0);
                  }
                  lVar3 = MouseController.currentTouch;
                  if (lVar3 == null) throw; // [null/range check failed]
                  uVar20 = *(uint32 *)(lVar3 + 24);
                  lVar2 = lVar2[uVar16];
                  if (lVar2 == null) throw; // [null/range check failed]
                  lVar2.pos = lVar3.pos;
                  *(uint32 *)(lVar2 + 24) = uVar20;
                  lVar2 = MouseController.mMouse;
                  if (lVar2 == null) throw; // [null/range check failed]
                  if (*(uint32 *)(lVar2 + 24) <= uVar16) {
                    uVar14 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                    FUN_1800d65f0(uVar14,0);
                  }
                  lVar3 = MouseController.currentTouch;
                  if (lVar3 == null) throw; // [null/range check failed]
                  uVar20 = *(uint32 *)(lVar3 + 40);
                  lVar2 = lVar2[uVar16];
                  if (lVar2 == null) throw; // [null/range check failed]
                  uVar16 = uVar16 + 1;
                  lVar2.delta = lVar3.delta;
                  *(uint32 *)(lVar2 + 40) = uVar20;
                } while ((int)uVar16 < 3);
                if ((bVar5 || bVar6) ||
                   (fVar19 = this.mNextRaycast, fVar18 = (float)RealTime.get_time(0),
                   fVar19 < fVar18)) {
                  fVar19 = (float)RealTime.get_time(0);
                  this.mNextRaycast = fVar19 + 0.02;
                  lVar2 = MouseController.currentTouch;
                  if (lVar2 == null) throw; // [null/range check failed]
                  uVar14 = lVar2.pos;
                  local_60 = 0;
                  local_68 = uVar14;
                  cVar9 = MouseController.Raycast(&local_68,0);
                  if (!cVar9) {
                    puVar13 = *(uint64 **)(DAT_181d8b7a8 + 184);
                    *puVar13 = 0;
                    il2cpp_internal(puVar13,0);
                  }
                  lVar2.last = lVar2.current;
                  lVar2.current = **(uint64 **)(DAT_181d8b7a8 + 184);
                  uVar20 = *(uint32 *)(lVar2 + 24);
                  lVar3 = pStatics;
                  *(uint32 *)(lVar3 + 60) = lVar2.pos;
                  lVar3.last = uVar20;
                  if (bVar6) {
                    bVar5 = true;
                    uVar16 = 1;
                    do {
                      lVar2 = MouseController.mMouse;
                      if (lVar2 == null) throw; // [null/range check failed]
                      if (*(uint32 *)(lVar2 + 24) <= uVar16) {
                        uVar14 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                        FUN_1800d65f0(uVar14,0);
                      }
                      lVar3 = MouseController.currentTouch;
                      if (lVar3 == null) throw; // [null/range check failed]
                      lVar2 = lVar2[uVar16];
                      if (lVar2 == null) throw; // [null/range check failed]
                      lVar2.current = lVar3.current;
                      uVar16 = uVar16 + 1;
                    } while ((int)uVar16 < 3);
                  }
                  else {
                    lVar2 = MouseController.mMouse;
                    if (lVar2 == null) throw; // [null/range check failed]
                    if (*(int *)(lVar2 + 24) == 0) {
                      uVar14 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                      FUN_1800d65f0(uVar14,0);
                    }
                    if (*(int64 *)(lVar2 + 32) == 0) throw; // [null/range check failed]
                    lVar3 = MouseController.currentTouch;
                    uVar14 = *(uint64 *)(*(int64 *)(lVar2 + 32) + 72);
                    if (lVar3 == null) throw; // [null/range check failed]
                    uVar4 = lVar3.current;
                    cVar9 = Object.op_Inequality(uVar14,uVar4,0);
                    if (cVar9) {
                      MouseController.set_currentKey(0x143,0);
                      bVar5 = true;
                      uVar16 = 1;
                      do {
                        lVar2 = MouseController.mMouse;
                        if (lVar2 == null) throw; // [null/range check failed]
                        if (*(uint32 *)(lVar2 + 24) <= uVar16) {
                          uVar14 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                          FUN_1800d65f0(uVar14,0);
                        }
                        lVar3 = MouseController.currentTouch;
                        if (lVar3 == null) throw; // [null/range check failed]
                        lVar2 = lVar2[uVar16];
                        if (lVar2 == null) throw; // [null/range check failed]
                        lVar2.current = lVar3.current;
                        uVar16 = uVar16 + 1;
                      } while ((int)uVar16 < 3);
                    }
                  }
                }
                lVar2 = MouseController.currentTouch;
                if (lVar2 != null) {
                  uVar14 = lVar2.last;
                  uVar4 = lVar2.current;
                  cVar9 = Object.op_Inequality(uVar14,uVar4,0);
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
                    uVar16 = 0;
                    do {
                      cVar10 = Input.GetMouseButtonDown(uVar16,0);
                      cVar11 = Input.GetMouseButtonUp(uVar16,0);
                      if (cVar11 || cVar10) {
                        MouseController.set_currentKey(uVar16 + 0x143,0);
                      }
                      lVar2 = MouseController.mMouse;
                      if (lVar2 == null) throw; // [null/range check failed]
                      if (*(uint32 *)(lVar2 + 24) <= uVar16) {
                        uVar14 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                        FUN_1800d65f0(uVar14,0);
                      }
                      MouseController.currentTouch =
                           lVar2[uVar16];
                      il2cpp_internal();
                      MouseController.currentTouchID = ~uVar16;
                      MouseController.set_currentKey(uVar16 + 0x143,0);
                      if (!cVar10) {
                        lVar2 = MouseController.currentTouch;
                        if (lVar2 == null) throw; // [null/range check failed]
                        uVar14 = lVar2.pressed;
                        cVar12 = Object.op_Inequality(uVar14,0,0);
                        if (cVar12) {
                          lVar2 = MouseController.currentTouch;
                          if (lVar2 == null) throw; // [null/range check failed]
                          MouseController.currentCamera =
                               lVar2.pressedCam;
                          il2cpp_internal();
                        }
                      }
                      else {
                        lVar2 = MouseController.currentTouch;
                        uVar14 = Camera.get_main(0);
                        if (lVar2 == null) throw; // [null/range check failed]
                        puVar13 = (uint64 *)(lVar2 + 56);
                        *puVar13 = uVar14;
                        il2cpp_internal(puVar13,uVar14);
                        lVar2 = MouseController.currentTouch;
                        uVar20 = RealTime.get_time(0);
                        if (lVar2 == null) throw; // [null/range check failed]
                        lVar2.pressTime = uVar20;
                      }
                      MouseController.ProcessTouch(this,cVar10,cVar11,0);
                      uVar16 = uVar16 + 1;
                    } while ((int)uVar16 < 1);
                    cVar10 = false;
                    if (!bVar6) {
                      cVar10 = cVar9;
                    }
                    if (cVar10) {
                      lVar2 = MouseController.mMouse;
                      if (lVar2 == null) throw; // [null/range check failed]
                      if (*(int *)(lVar2 + 24) == 0) {
                        uVar14 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                        FUN_1800d65f0(uVar14,0);
                      }
                      MouseController.currentTouch =
                           *(uint64 *)(lVar2 + 32);
                      il2cpp_internal();
                      MouseController.currentTouchID = 0xffffffff;
                      MouseController.set_currentKey(0x143,0);
                      lVar2 = MouseController.currentTouch;
                      if (lVar2 == null) throw; // [null/range check failed]
                      MouseController.set_hoveredObject(lVar2.current,0);
                    }
                    MouseController.currentTouch = 0;
                    lVar2 = MouseController.mMouse;
                    if (lVar2 != null) {
                      if (*(int *)(lVar2 + 24) == 0) {
                        uVar14 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                        FUN_1800d65f0(uVar14,0);
                      }
                      lVar2 = *(int64 *)(lVar2 + 32);
                      if (lVar2 != null) {
                        lVar2.last = lVar2.current;
                        while( true ) {
                          lVar2 = MouseController.mMouse;
                          if (lVar2 == null) break;
                          if (*(uint32 *)(lVar2 + 24) <= uVar17) {
                            uVar14 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                            FUN_1800d65f0(uVar14,0);
                          }
                          if (*(uint32 *)(lVar2 + 24) == 0) {
                            uVar14 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                            FUN_1800d65f0(uVar14,0);
                          }
                          if (*(int64 *)(lVar2 + 32) == 0) break;
                          lVar3 = lVar2[uVar17];
                          if (lVar3 == null) break;
                          lVar3.last =
                               *(uint64 *)(*(int64 *)(lVar2 + 32) + 64);
                          il2cpp_internal();
                          uVar17 = uVar17 + 1;
                          if (2 < (int)uVar17) {
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

    // Token : 0x600195A
    // RVA   : 0xDF2CB0   Offset: 0xDF20B0   Length: 0x2AD
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

    // Token : 0x600195B
    // RVA   : 0xDF1270   Offset: 0xDF0670   Length: 0x10A9
    private void ProcessPress(bool pressed, float click, float drag)
    {
        var pStatics = *(int64*)(DAT_181d8b7a8 + 184);
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
          if (lVar7 == null) goto LAB_180df230e;
          uVar8 = lVar7.pressed;
          cVar4 = Object.op_Inequality(uVar8,0,0);
          if (!cVar4) {
            return;
          }
          lVar7 = MouseController.currentTouch;
          if (lVar7 == null) goto LAB_180df230e;
          fVar11 = (float)Vector2.get_sqrMagnitude(lVar7 + 36,0);
          if (fVar11 == 0.0) {
            lVar7 = MouseController.currentTouch;
            if (lVar7 == null) goto LAB_180df230e;
            uVar8 = lVar7.current;
            uVar6 = lVar7.last;
            cVar4 = Object.op_Inequality(uVar8,uVar6,0);
            if (!cVar4) {
              return;
            }
          }
          lVar7 = MouseController.currentTouch;
          if (lVar7 == null) goto LAB_180df230e;
          lVar7.totalDelta = lVar7.delta + lVar7.totalDelta;
          *(float *)(lVar7 + 48) = *(float *)(lVar7 + 48) + *(float *)(lVar7 + 40);
          lVar7 = MouseController.currentTouch;
          if (lVar7 == null) goto LAB_180df230e;
          fVar11 = (float)Vector2.get_sqrMagnitude(lVar7 + 44,0);
          bVar3 = false;
          lVar7 = MouseController.currentTouch;
          if (lVar7 == null) goto LAB_180df230e;
          if (!lVar7.dragStarted) {
            lVar7 = MouseController.currentTouch;
            if (lVar7 == null) goto LAB_180df230e;
            uVar8 = lVar7.last;
            uVar6 = lVar7.current;
            cVar4 = Object.op_Inequality(uVar8,uVar6,0);
            if (!cVar4) goto LAB_180df16ca;
            lVar7 = MouseController.currentTouch;
            if (lVar7 == null) goto LAB_180df230e;
            lVar7.dragStarted = 1;
            lVar7 = MouseController.currentTouch;
            if (lVar7 == null) goto LAB_180df230e;
            lVar7.delta = lVar7.totalDelta;
            *(uint32 *)(lVar7 + 40) = *(uint32 *)(lVar7 + 48);
            lVar7 = MouseController.currentTouch;
            if (lVar7 == null) goto LAB_180df230e;
            lVar7.clickNotification = 0;
            MouseController.isDragging = 1;
            lVar7 = MouseController.currentTouch;
            if (lVar7 == null) goto LAB_180df230e;
            MouseController.Notify(lVar7.dragged,"OnDragStart",0,0);
            lVar7 = MouseController.currentTouch;
            if (lVar7 == null) goto LAB_180df230e;
            MouseController.Notify
                      (lVar7.last,"OnDragOver",lVar7.dragged,0);
            MouseController.isDragging = 0;
          }
          else {
        LAB_180df16ca:
            lVar7 = MouseController.currentTouch;
            if (lVar7 == null) goto LAB_180df230e;
            bVar3 = false;
            if ((!lVar7.dragStarted) && (drag < fVar11)) {
              bVar3 = true;
              lVar7 = MouseController.currentTouch;
              if (lVar7 == null) goto LAB_180df230e;
              lVar7.dragStarted = 1;
              lVar7 = MouseController.currentTouch;
              if (lVar7 == null) goto LAB_180df230e;
              lVar7.delta = lVar7.totalDelta;
              *(uint32 *)(lVar7 + 40) = *(uint32 *)(lVar7 + 48);
            }
          }
          lVar7 = MouseController.currentTouch;
          if (lVar7 == null) goto LAB_180df230e;
          if (!lVar7.dragStarted) {
            return;
          }
          MouseController.isDragging = 1;
          lVar7 = MouseController.currentTouch;
          if (lVar7 == null) goto LAB_180df230e;
          iVar1 = lVar7.clickNotification;
          if (bVar3) {
            lVar7 = MouseController.currentTouch;
            if (lVar7 == null) goto LAB_180df230e;
            uVar8 = 0;
            uVar6 = lVar7.dragged;
            uVar10 = "OnDragStart";
        LAB_180df18f6:
            MouseController.Notify(uVar6,uVar10,uVar8,0);
            lVar7 = MouseController.currentTouch;
            if (lVar7 == null) goto LAB_180df230e;
            MouseController.Notify
                      (lVar7.current,"OnDragOver",lVar7.dragged,0);
          }
          else {
            lVar7 = MouseController.currentTouch;
            if (lVar7 == null) goto LAB_180df230e;
            uVar8 = lVar7.last;
            uVar6 = lVar7.current;
            cVar4 = Object.op_Inequality(uVar8,uVar6,0);
            if (cVar4) {
              lVar7 = MouseController.currentTouch;
              if (lVar7 == null) goto LAB_180df230e;
              uVar8 = lVar7.dragged;
              uVar6 = lVar7.last;
              uVar10 = "OnDragOut";
              goto LAB_180df18f6;
            }
          }
          lVar7 = MouseController.currentTouch;
          if (lVar7 == null) {
        LAB_180df2308:
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          uVar8 = lVar7.dragged;
          local_58 = lVar7.delta;
          uVar6 = il2cpp_value_box(DAT_181db3968,&local_58);
          MouseController.Notify(uVar8,"OnDrag",uVar6,0);
          lVar7 = MouseController.currentTouch;
          if (lVar7 == null) goto LAB_180df2308;
          lVar7.last = lVar7.current;
          MouseController.isDragging = 0;
          if (iVar1 == 0) {
            lVar7 = pStatics;
          }
          else {
            lVar7 = MouseController.currentTouch;
            if (lVar7 == null) goto LAB_180df230e;
            if (lVar7.clickNotification != 2) {
              return;
            }
            if (fVar11 <= click) {
              return;
            }
            lVar7 = pStatics;
          }
          if (*(int64 *)(lVar7 + 48) != 0) {
            *(uint32 *)(*(int64 *)(lVar7 + 48) + 112) = 0;
            return;
          }
          goto LAB_180df230e;
        }
        lVar7 = MouseController.currentTouch;
        if (lVar7 == null) {
        LAB_180df2302:
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
        lVar7.pressStarted = 1;
        lVar7 = MouseController.currentTouch;
        if (lVar7 == null) goto LAB_180df2302;
        uVar8 = lVar7.pressed;
        local_res10[0] = 0;
        uVar6 = il2cpp_value_box(DAT_181db2ae0,local_res10);
        MouseController.Notify(uVar8,"OnPress",uVar6,0);
        uVar8 = MouseController.mHover;
        cVar4 = Object.op_Implicit(uVar8,0);
        if (!cVar4) {
        LAB_180df1c4a:
          uVar8 = 0;
          MouseController.mHover = 0;
        }
        else {
          lVar7 = MouseController.mHover;
          if (lVar7 == null) goto LAB_180df2302;
          cVar4 = GameObject.get_activeInHierarchy(lVar7,0);
          if (!cVar4) goto LAB_180df1c4a;
          uVar8 = MouseController.mHover;
        }
        cVar4 = Object.op_Equality(uVar8,0,0);
        if (cVar4) {
          lVar7 = MouseController.currentTouch;
          if (lVar7 == null) goto LAB_180df230e;
          uVar8 = lVar7.current;
          cVar4 = Object.op_Inequality(uVar8,0,0);
          if (cVar4) {
            lVar7 = MouseController.currentTouch;
            if (lVar7 == null) goto LAB_180df230e;
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
                    uVar6 = il2cpp_value_box(DAT_181db2ae0,local_res10);
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
                        uVar6 = il2cpp_value_box(DAT_181db2ae0,local_res10);
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

                            if ((lVar7 = MouseController.currentTouch?.pressed) == null)
                            goto LAB_180df230e;
                            uVar8 = GameObject.GetComponent(lVar7,DAT_181d74a10);
                            cVar4 = Object.op_Inequality(uVar8,0,0);
                            if (cVar4) {
                              lVar7 = MouseController.currentTouch;
                              lVar2 = MouseController.controller;
                              if ((lVar7 == null) || (lVar2 == null)) goto LAB_180df230e;
                              lVar2.current = lVar7.pressed;
                            }
                          }
                          uVar8 = MouseController.mSelected;
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
                              lVar7 = MouseController.mSelected;
                              if (lVar7 == null) goto LAB_180df230e;
                              uVar8 = GameObject.GetComponent(lVar7,DAT_181d74988);
                              uVar5 = Object.op_Inequality(uVar8,0,0);
                            }
                            MouseController.mInputFocus = uVar5;
                            uVar8 = MouseController.mSelected;
                            local_res10[0] = 1;
                            uVar6 = il2cpp_value_box(DAT_181db2ae0,local_res10);
                            MouseController.Notify(uVar8,"OnSelect",uVar6,0);
                            return;
                          }
                        }
                      }
        LAB_180df230e:
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

    // Token : 0x600195C
    // RVA   : 0xDF2320   Offset: 0xDF1720   Length: 0x986
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
        LAB_180df2ca1:
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          uVar1 = lVar5.pressed;
          local_res20[0] = 0;
          uVar3 = il2cpp_value_box(DAT_181db2ae0,local_res20);
          MouseController.Notify(uVar1,"OnPress",uVar3,0);
          lVar5 = MouseController.currentTouch;
          if (lVar5 == null) goto LAB_180df2ca1;
          lVar5 = lVar5.pressed;
          cVar2 = Object.op_Equality(lVar5,0,0);
          if (!cVar2) {
            if (lVar5 == null) goto LAB_180df2ca1;
            lVar4 = GameObject.GetComponent(lVar5,DAT_181dc80e0);
            cVar2 = Object.op_Inequality(lVar4,0,0);
            if (!cVar2) {
              lVar5 = GameObject.GetComponent(lVar5,DAT_181dc8168);
              cVar2 = Object.op_Inequality(lVar5,0,0);
              if (!cVar2) goto LAB_180df27a6;
              if (lVar5 == null) goto LAB_180df2ca1;
              cVar2 = Behaviour.get_enabled(lVar5,0);
            }
            else {
              if (lVar4 == null) goto LAB_180df2ca1;
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
                uVar3 = il2cpp_value_box(DAT_181db2ae0,local_res20);
                MouseController.Notify(uVar1,"OnHover",uVar3,0);
              }
            }
          }
        LAB_180df27a6:
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
              if (fVar7 < drag) goto LAB_180df2a39;
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
        LAB_180df2a39:
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

    // Token : 0x600195D
    // RVA   : 0xDEFD40   Offset: 0xDEF140   Length: 0x14A
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
          lVar1 = GameObject.GetComponent(go,DAT_181dc80e0);
          cVar2 = Object.op_Inequality(lVar1,0,0);
          if (!cVar2) {
            lVar1 = GameObject.GetComponent(go,DAT_181dc8168);
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

    // Token : 0x600195E
    // RVA   : 0xDF39C0   Offset: 0xDF2DC0   Length: 0x84
    public void /*ctor*/()
    {
        ulong uVar1;
        uVar1 = il2cpp_internal(DAT_181d965e8);
        FUN_181330100(uVar1,DAT_181d9e1a0);
        this.uiRaycastResults = uVar1;
        this.mouseDragThreshold = 0x40800000;
        this.mouseClickThreshold = 0x41200000;
        FUN_18044ef50(this,0);
    }

    // Token : 0x600195F
    // RVA   : 0xDF3690   Offset: 0xDF2A90   Length: 0x325
    private static void /*cctor*/()
    {
        var pStatics = *(int64*)(DAT_181d8b7a8 + 184);
        long lVar2;
        long lVar3;
        ulong uVar4;
        uint local_res10;
        uint uStackX_14;
        byte[] local_18 = new byte[16];
        MouseController.currentCamera = 0;
        plVar1 = (int64 *)FUN_1800d60b0(DAT_181da88f8,3);
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
          lVar2 = pStatics;
          *(uint32 *)(lVar2 + 60) = local_res10;
          *(uint32 *)(lVar2 + 64) = uStackX_14;
          MouseController.isDragging = 0;
          MouseController.currentTouchID = 0xffffff9c;
          MouseController.mCurrentKey = 48;
          puVar5 = (uint64 *)Vector3.get_zero(local_18,0);
          lVar2 = pStatics;
          *(uint64 *)(lVar2 + 88) = *puVar5;
          *(uint32 *)(lVar2 + 96) = *(uint32 *)(puVar5 + 1);
          lVar2 = pStatics;
          *(uint64 *)(lVar2 + 100) = 0;
          *(uint64 *)(lVar2 + 108) = 0;
          *(uint64 *)(lVar2 + 116) = 0;
          MouseController.mNotifying = 0;
          return;
        }
        uVar4 = il2cpp_internal();
    }

}
