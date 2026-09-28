// ============================================================
// Type  : MouseController
// Token : 0x200030B
// ============================================================

public class MouseController
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001913
    private static GameObject mRayHitObject;

    // Token: 0x4001914
    private static GameObject mHover;

    // Token: 0x4001915
    private static GameObject mSelected;

    // Token: 0x4001916
    public static Camera currentCamera;

    // Token: 0x4001917
    private static MouseOrTouch[] mMouse;

    // Token: 0x4001918
    public static MouseOrTouch controller;

    // Token: 0x4001919
    public static MouseOrTouch currentTouch;

    // Token: 0x400191A
    private static bool mInputFocus;

    // Token: 0x400191B
    private static Vector2 mLastPos;

    // Token: 0x400191C
    private float mNextRaycast;

    // Token: 0x400191D
    public static bool isDragging;

    // Token: 0x400191E
    public static GameObject hoveredUI;

    // Token: 0x400191F
    public static int currentTouchID;

    // Token: 0x4001920
    private static KeyCode mCurrentKey;

    // Token: 0x4001921
    public static Vector3 lastWorldPosition;

    // Token: 0x4001922
    public static Ray lastWorldRay;

    // Token: 0x4001923
    public static RaycastHit lastHit;

    // Token: 0x4001924
    private readonly List<RaycastResult> uiRaycastResults;

    // Token: 0x4001925
    private PointerEventData cachedPointerData;

    // Token: 0x4001926
    private bool cachedOverUI;

    // Token: 0x4001927
    private GameObject cachedTopUI;

    // Token: 0x4001928
    private static int mNotifying;

    // Token: 0x4001929
    private static RaycastHit[] mRayHits;

    // Token: 0x400192A
    private static Collider2D[] mOverlap;

    // Token: 0x400192B
    public float mouseDragThreshold;

    // Token: 0x400192C
    public float mouseClickThreshold;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6001949
    // RVA   : 0xDF3630   Offset: 0xDF2A30   Length: 0x7C
    public static MouseOrTouch get_mouse0()
    {
        long lVar1;
        ulong uVar2;
        lVar1 = *(int64 *)(*(int64 *)(DAT_181d8b790 + 184) + 32);
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
    // RVA   : 0xDF36B0   Offset: 0xDF2AB0   Length: 0x7C
    public static MouseOrTouch get_mouse1()
    {
        long lVar1;
        ulong uVar2;
        lVar1 = *(int64 *)(*(int64 *)(DAT_181d8b790 + 184) + 32);
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
    // RVA   : 0xDF3730   Offset: 0xDF2B30   Length: 0x7C
    public static MouseOrTouch get_mouse2()
    {
        long lVar1;
        ulong uVar2;
        lVar1 = *(int64 *)(*(int64 *)(DAT_181d8b790 + 184) + 32);
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
    // RVA   : 0xDF34D0   Offset: 0xDF28D0   Length: 0x15F
    public static GameObject get_hoveredObject()
    {
        var pStatics = *(int64*)(DAT_181d8b790 + 184);
        ulong uVar1;
        long lVar2;
        bool cVar3;
        uVar1 = *(uint64 *)(pStatics + 8);
        cVar3 = Object.op_Implicit(uVar1,0);
        if (cVar3) {
          lVar2 = *(int64 *)(pStatics + 8);
          if (lVar2 == null) {
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          cVar3 = GameObject.get_activeInHierarchy(lVar2,0);
          if (cVar3) {
            return *(uint64 *)(pStatics + 8);
          }
        }
        puVar4 = (uint64 *)(pStatics + 8);
        *puVar4 = 0;
        il2cpp_internal(puVar4,0);
        return 0;
    }

    // Token : 0x600194D
    // RVA   : 0xDF3840   Offset: 0xDF2C40   Length: 0x256
    public static void set_hoveredObject(GameObject value)
    {
        var pStatics = *(int64*)(DAT_181d8b790 + 184);
        ulong uVar1;
        bool cVar2;
        ulong uVar3;
        byte[] local_res8 = new byte[8];
        uVar1 = *(uint64 *)(pStatics + 8);
        cVar2 = Object.op_Equality(uVar1,value,0);
        if (!cVar2) {
          uVar1 = *(uint64 *)(pStatics + 8);
          cVar2 = Object.op_Implicit(uVar1,0);
          if (cVar2) {
            uVar1 = *(uint64 *)(pStatics + 8);
            local_res8[0] = 0;
            uVar3 = il2cpp_value_box(DAT_181db2ac8,local_res8);
            MouseController.Notify(uVar1,"OnHover",uVar3,0);
          }
          puVar4 = (uint64 *)(pStatics + 8);
          *puVar4 = value;
          il2cpp_internal(puVar4,value);
          uVar1 = *(uint64 *)(pStatics + 8);
          cVar2 = Object.op_Implicit(uVar1,0);
          if (cVar2) {
            uVar1 = *(uint64 *)(pStatics + 8);
            local_res8[0] = 1;
            uVar3 = il2cpp_value_box(DAT_181db2ac8,local_res8);
            MouseController.Notify(uVar1,"OnHover",uVar3,0);
          }
        }
    }

    // Token : 0x600194E
    // RVA   : 0xDF3470   Offset: 0xDF2870   Length: 0x57
    public static KeyCode get_currentKey()
    {
        return *(uint32 *)(*(int64 *)(DAT_181d8b790 + 184) + 84);
    }

    // Token : 0x600194F
    // RVA   : 0xDF37B0   Offset: 0xDF2BB0   Length: 0x83
    public static void set_currentKey(KeyCode value)
    {
        var pStatics = *(int64*)(DAT_181d8b790 + 184);
        if (*(int *)(pStatics + 84) != value) {
          *(int *)(pStatics + 84) = value;
        }
    }

    // Token : 0x6001950
    // RVA   : 0xDF3440   Offset: 0xDF2840   Length: 0x29
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
    // RVA   : 0xDF3050   Offset: 0xDF2450   Length: 0x29
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
    // RVA   : 0xDEF890   Offset: 0xDEEC90   Length: 0x13A
    public static void Notify(GameObject go, string funcName, object obj)
    {
        var pStatics = *(int64*)(DAT_181d8b790 + 184);
        bool cVar2;
        if (*(int *)(pStatics + 168) < 11) {
          cVar2 = Object.op_Implicit(go,0);
          if (cVar2) {
            if (go == null) {
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            cVar2 = GameObject.get_activeInHierarchy(go,0);
            if (cVar2) {
              piVar1 = (int *)(pStatics + 168);
              *piVar1 = *piVar1 + 1;
              GameObject.SendMessage(go,funcName,obj,1,0);
              piVar1 = (int *)(pStatics + 168);
              *piVar1 = *piVar1 + -1;
            }
          }
        }
    }

    // Token : 0x6001953
    // RVA   : 0xDF2C20   Offset: 0xDF2020   Length: 0x14F
    public static void Raycast(MouseOrTouch touch)
    {
        var pStatics = *(int64*)(DAT_181d8b790 + 184);
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
                      puVar8 = *(uint64 **)(DAT_181d8b790 + 184);
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
    // RVA   : 0xDF2950   Offset: 0xDF1D50   Length: 0x2CE
    public static bool Raycast(Vector3 inPos)
    {
        var pStatics = *(int64*)(DAT_181d8b790 + 184);
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
                      puVar8 = *(uint64 **)(DAT_181d8b790 + 184);
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
    // RVA   : 0xDF2D70   Offset: 0xDF2170   Length: 0x2DA
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
        LAB_180df3006:
          this.cachedOverUI = 0;
          this.cachedTopUI = 0;
          return false;
        }
        iVar4 = Application.get_platform(0);
        if ((iVar4 != 8) && (iVar4 = Application.get_platform(0), iVar4 != 11)) {
          if (lVar5 == null) throw; // [null/range check failed]
          cVar2 = EventSystem.IsPointerOverGameObject(lVar5,0);
          if (!cVar2) goto LAB_180df3006;
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
             (FUN_1812f9a10(this.uiRaycastResults,DAT_181d9e288), lVar5 != null)) {
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
    // RVA   : 0xDEF880   Offset: 0xDEEC80   Length: 0x7
    public bool IsPointerOverGameUI()
    {
        void FUN_180def880(uint64 this)
        {
        MouseController.UpdateUIHover(this,0);
    }

    // Token : 0x6001957
    // RVA   : 0xDEF9D0   Offset: 0xDEEDD0   Length: 0x484
    private void ProcessEvents()
    {
        var pStatics = *(int64*)(DAT_181d8b790 + 184);
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
          puVar7 = (uint64 *)(pStatics + 72);
          *puVar7 = 0;
          il2cpp_internal(puVar7,0);
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
          uVar3 = *(uint64 *)(pStatics + 8);
          cVar2 = Object.op_Inequality(uVar3,0,0);
          if ((cVar2) && (fVar9 = (float)Input.GetAxis("Mouse ScrollWheel",0), fVar9 != 0.0)) {
            uVar3 = *(uint64 *)(pStatics + 8);
            local_res18[0] = fVar9;
            uVar5 = il2cpp_value_box(DAT_181da22d8,local_res18);
            MouseController.Notify(uVar3,"OnScroll",uVar5,0);
          }
          *(uint32 *)(pStatics + 80) = 0xffffff9c;
          return;
        }
        uVar3 = this.cachedTopUI;
        uVar5 = *(uint64 *)(pStatics + 72);
        cVar2 = Object.op_Inequality(uVar5,uVar3,0);
        if (cVar2) {
          uVar3 = this.cachedTopUI;
          puVar7 = (uint64 *)(pStatics + 72);
          *puVar7 = uVar3;
          il2cpp_internal(puVar7,uVar3);
        }
        MouseController.set_hoveredObject(0,0);
        iVar8 = 0;
        while( true ) {
          plVar1 = *(int64 **)(pStatics + 32);
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
    // RVA   : 0xDEF640   Offset: 0xDEEA40   Length: 0xE4
    public void ClearMouse()
    {
        long lVar2;
        long lVar3;
        ulong uVar4;
        int iVar5;
        iVar5 = 0;
        do {
          plVar1 = *(int64 **)(*(int64 *)(DAT_181d8b790 + 184) + 32);
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
    // RVA   : 0xDEFE60   Offset: 0xDEF260   Length: 0xDFC
    public void ProcessMouse()
    {
        var pStatics = *(int64*)(DAT_181d8b790 + 184);
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
        lVar2 = *(int64 *)(pStatics + 32);
        if (lVar2 != null) {
          if (*(int *)(lVar2 + 24) == 0) {
            uVar14 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar14,0);
          }
          *(uint64 *)(pStatics + 48) = *(uint64 *)(lVar2 + 32);
          puVar13 = (uint64 *)Input.get_mousePosition(local_58,0);
          local_68 = *puVar13;
          local_60 = *(uint32 *)(puVar13 + 1);
          lVar2 = *(int64 *)(pStatics + 48);
          if (lVar2 != null) {
            local_78 = (float)local_68;
            local_68._4_4_ = (float)((uint64)local_68 >> 32);
            fVar19 = local_68._4_4_;
            if (*(int *)(lVar2 + 120) == 0) {
              lVar2 = *(int64 *)(pStatics + 48);
              if (lVar2 == null) throw; // [null/range check failed]
              *(float *)(lVar2 + 36) = local_78 - *(float *)(lVar2 + 20);
              *(float *)(lVar2 + 40) = fVar19 - *(float *)(lVar2 + 24);
            }
            else {
              lVar2 = *(int64 *)(pStatics + 48);
              if (lVar2 == null) throw; // [null/range check failed]
              piVar1 = (int *)(lVar2 + 120);
              *piVar1 = *piVar1 + -1;
              lVar2 = *(int64 *)(pStatics + 48);
              if (lVar2 == null) throw; // [null/range check failed]
              *(uint32 *)(lVar2 + 36) = 0;
              lVar2 = *(int64 *)(pStatics + 48);
              if (lVar2 == null) throw; // [null/range check failed]
              *(uint32 *)(lVar2 + 40) = 0;
            }
            lVar2 = *(int64 *)(pStatics + 48);
            if (lVar2 != null) {
              fVar18 = (float)Vector2.get_sqrMagnitude(lVar2 + 36,0);
              lVar2 = *(int64 *)(pStatics + 48);
              if (lVar2 != null) {
                *(float *)(lVar2 + 20) = local_78;
                uVar17 = 1;
                *(float *)(lVar2 + 24) = fVar19;
                lVar2 = pStatics;
                *(float *)(lVar2 + 60) = local_78;
                *(float *)(lVar2 + 64) = fVar19;
                bVar5 = 0.001 < fVar18;
                uVar16 = 1;
                do {
                  lVar2 = *(int64 *)(pStatics + 32);
                  if (lVar2 == null) throw; // [null/range check failed]
                  if (*(uint32 *)(lVar2 + 24) <= uVar16) {
                    uVar14 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                    FUN_1800d65f0(uVar14,0);
                  }
                  lVar3 = *(int64 *)(pStatics + 48);
                  if (lVar3 == null) throw; // [null/range check failed]
                  uVar20 = *(uint32 *)(lVar3 + 24);
                  lVar2 = lVar2[uVar16];
                  if (lVar2 == null) throw; // [null/range check failed]
                  *(uint32 *)(lVar2 + 20) = *(uint32 *)(lVar3 + 20);
                  *(uint32 *)(lVar2 + 24) = uVar20;
                  lVar2 = *(int64 *)(pStatics + 32);
                  if (lVar2 == null) throw; // [null/range check failed]
                  if (*(uint32 *)(lVar2 + 24) <= uVar16) {
                    uVar14 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                    FUN_1800d65f0(uVar14,0);
                  }
                  lVar3 = *(int64 *)(pStatics + 48);
                  if (lVar3 == null) throw; // [null/range check failed]
                  uVar20 = *(uint32 *)(lVar3 + 40);
                  lVar2 = lVar2[uVar16];
                  if (lVar2 == null) throw; // [null/range check failed]
                  uVar16 = uVar16 + 1;
                  *(uint32 *)(lVar2 + 36) = *(uint32 *)(lVar3 + 36);
                  *(uint32 *)(lVar2 + 40) = uVar20;
                } while ((int)uVar16 < 3);
                if ((bVar5 || bVar6) ||
                   (fVar19 = this.mNextRaycast, fVar18 = (float)RealTime.get_time(0),
                   fVar19 < fVar18)) {
                  fVar19 = (float)RealTime.get_time(0);
                  this.mNextRaycast = fVar19 + 0.02;
                  lVar2 = *(int64 *)(pStatics + 48);
                  if (lVar2 == null) throw; // [null/range check failed]
                  uVar14 = *(uint64 *)(lVar2 + 20);
                  local_60 = 0;
                  local_68 = uVar14;
                  cVar9 = MouseController.Raycast(&local_68,0);
                  if (!cVar9) {
                    puVar13 = *(uint64 **)(DAT_181d8b790 + 184);
                    *puVar13 = 0;
                    il2cpp_internal(puVar13,0);
                  }
                  *(uint64 *)(lVar2 + 64) = *(uint64 *)(lVar2 + 72);
                  *(uint64 *)(lVar2 + 72) = **(uint64 **)(DAT_181d8b790 + 184);
                  uVar20 = *(uint32 *)(lVar2 + 24);
                  lVar3 = pStatics;
                  *(uint32 *)(lVar3 + 60) = *(uint32 *)(lVar2 + 20);
                  *(uint32 *)(lVar3 + 64) = uVar20;
                  if (bVar6) {
                    bVar5 = true;
                    uVar16 = 1;
                    do {
                      lVar2 = *(int64 *)(pStatics + 32);
                      if (lVar2 == null) throw; // [null/range check failed]
                      if (*(uint32 *)(lVar2 + 24) <= uVar16) {
                        uVar14 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                        FUN_1800d65f0(uVar14,0);
                      }
                      lVar3 = *(int64 *)(pStatics + 48);
                      if (lVar3 == null) throw; // [null/range check failed]
                      lVar2 = lVar2[uVar16];
                      if (lVar2 == null) throw; // [null/range check failed]
                      *(uint64 *)(lVar2 + 72) = *(uint64 *)(lVar3 + 72);
                      uVar16 = uVar16 + 1;
                    } while ((int)uVar16 < 3);
                  }
                  else {
                    lVar2 = *(int64 *)(pStatics + 32);
                    if (lVar2 == null) throw; // [null/range check failed]
                    if (*(int *)(lVar2 + 24) == 0) {
                      uVar14 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                      FUN_1800d65f0(uVar14,0);
                    }
                    if (*(int64 *)(lVar2 + 32) == 0) throw; // [null/range check failed]
                    lVar3 = *(int64 *)(pStatics + 48);
                    uVar14 = *(uint64 *)(*(int64 *)(lVar2 + 32) + 72);
                    if (lVar3 == null) throw; // [null/range check failed]
                    uVar4 = *(uint64 *)(lVar3 + 72);
                    cVar9 = Object.op_Inequality(uVar14,uVar4,0);
                    if (cVar9) {
                      MouseController.set_currentKey(0x143,0);
                      bVar5 = true;
                      uVar16 = 1;
                      do {
                        lVar2 = *(int64 *)(pStatics + 32);
                        if (lVar2 == null) throw; // [null/range check failed]
                        if (*(uint32 *)(lVar2 + 24) <= uVar16) {
                          uVar14 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                          FUN_1800d65f0(uVar14,0);
                        }
                        lVar3 = *(int64 *)(pStatics + 48);
                        if (lVar3 == null) throw; // [null/range check failed]
                        lVar2 = lVar2[uVar16];
                        if (lVar2 == null) throw; // [null/range check failed]
                        *(uint64 *)(lVar2 + 72) = *(uint64 *)(lVar3 + 72);
                        uVar16 = uVar16 + 1;
                      } while ((int)uVar16 < 3);
                    }
                  }
                }
                lVar2 = *(int64 *)(pStatics + 48);
                if (lVar2 != null) {
                  uVar14 = *(uint64 *)(lVar2 + 64);
                  uVar4 = *(uint64 *)(lVar2 + 72);
                  cVar9 = Object.op_Inequality(uVar14,uVar4,0);
                  lVar2 = *(int64 *)(pStatics + 48);
                  if (lVar2 != null) {
                    cVar10 = Object.op_Inequality(*(uint64 *)(lVar2 + 80),0,0);
                    bVar8 = false;
                    if (!cVar10) {
                      bVar8 = bVar5;
                    }
                    if (bVar8) {
                      lVar2 = *(int64 *)(pStatics + 48);
                      if (lVar2 == null) throw; // [null/range check failed]
                      MouseController.set_hoveredObject(*(uint64 *)(lVar2 + 72),0);
                    }
                    *(uint32 *)(pStatics + 80) = 0xffffffff;
                    if (cVar9) {
                      if (*(int *)(pStatics + 84) != 0x143) {
                        *(uint32 *)(pStatics + 84) = 0x143;
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
                      lVar2 = *(int64 *)(pStatics + 32);
                      if (lVar2 == null) throw; // [null/range check failed]
                      if (*(uint32 *)(lVar2 + 24) <= uVar16) {
                        uVar14 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                        FUN_1800d65f0(uVar14,0);
                      }
                      *(uint64 *)(pStatics + 48) =
                           lVar2[uVar16];
                      il2cpp_internal();
                      *(uint32 *)(pStatics + 80) = ~uVar16;
                      MouseController.set_currentKey(uVar16 + 0x143,0);
                      if (!cVar10) {
                        lVar2 = *(int64 *)(pStatics + 48);
                        if (lVar2 == null) throw; // [null/range check failed]
                        uVar14 = *(uint64 *)(lVar2 + 80);
                        cVar12 = Object.op_Inequality(uVar14,0,0);
                        if (cVar12) {
                          lVar2 = *(int64 *)(pStatics + 48);
                          if (lVar2 == null) throw; // [null/range check failed]
                          *(uint64 *)(pStatics + 24) =
                               *(uint64 *)(lVar2 + 56);
                          il2cpp_internal();
                        }
                      }
                      else {
                        lVar2 = *(int64 *)(pStatics + 48);
                        uVar14 = Camera.get_main(0);
                        if (lVar2 == null) throw; // [null/range check failed]
                        puVar13 = (uint64 *)(lVar2 + 56);
                        *puVar13 = uVar14;
                        il2cpp_internal(puVar13,uVar14);
                        lVar2 = *(int64 *)(pStatics + 48);
                        uVar20 = RealTime.get_time(0);
                        if (lVar2 == null) throw; // [null/range check failed]
                        *(uint32 *)(lVar2 + 104) = uVar20;
                      }
                      MouseController.ProcessTouch(this,cVar10,cVar11,0);
                      uVar16 = uVar16 + 1;
                    } while ((int)uVar16 < 1);
                    cVar10 = false;
                    if (!bVar6) {
                      cVar10 = cVar9;
                    }
                    if (cVar10) {
                      lVar2 = *(int64 *)(pStatics + 32);
                      if (lVar2 == null) throw; // [null/range check failed]
                      if (*(int *)(lVar2 + 24) == 0) {
                        uVar14 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                        FUN_1800d65f0(uVar14,0);
                      }
                      *(uint64 *)(pStatics + 48) =
                           *(uint64 *)(lVar2 + 32);
                      il2cpp_internal();
                      *(uint32 *)(pStatics + 80) = 0xffffffff;
                      MouseController.set_currentKey(0x143,0);
                      lVar2 = *(int64 *)(pStatics + 48);
                      if (lVar2 == null) throw; // [null/range check failed]
                      MouseController.set_hoveredObject(*(uint64 *)(lVar2 + 72),0);
                    }
                    puVar13 = (uint64 *)(pStatics + 48);
                    *puVar13 = 0;
                    il2cpp_internal(puVar13,0);
                    lVar2 = *(int64 *)(pStatics + 32);
                    if (lVar2 != null) {
                      if (*(int *)(lVar2 + 24) == 0) {
                        uVar14 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                        FUN_1800d65f0(uVar14,0);
                      }
                      lVar2 = *(int64 *)(lVar2 + 32);
                      if (lVar2 != null) {
                        *(uint64 *)(lVar2 + 64) = *(uint64 *)(lVar2 + 72);
                        while( true ) {
                          lVar2 = *(int64 *)(pStatics + 32);
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
                          *(uint64 *)(lVar3 + 64) =
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
    // RVA   : 0xDF26A0   Offset: 0xDF1AA0   Length: 0x2AD
    public void ProcessTouch(bool pressed, bool released)
    {
        var pStatics = *(int64*)(DAT_181d8b790 + 184);
        long lVar1;
        ulong uVar2;
        ulong uVar3;
        bool cVar4;
        float fVar5;
        float fVar6;
        fVar5 = this.mouseDragThreshold * this.mouseDragThreshold;
        fVar6 = this.mouseClickThreshold * this.mouseClickThreshold;
        lVar1 = *(int64 *)(pStatics + 48);
        if (lVar1 != null) {
          uVar2 = *(uint64 *)(lVar1 + 80);
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
            lVar1 = *(int64 *)(pStatics + 48);
            if (lVar1 == null) throw; // [null/range check failed]
            fVar5 = (float)MouseOrTouch.get_deltaTime(lVar1,0);
            if (1.0 < fVar5) {
              lVar1 = *(int64 *)(pStatics + 48);
              if (lVar1 == null) throw; // [null/range check failed]
              uVar2 = *(uint64 *)(lVar1 + 80);
              uVar3 = *(uint64 *)(lVar1 + 72);
              cVar4 = Object.op_Equality(uVar2,uVar3,0);
              if (cVar4) {
                lVar1 = *(int64 *)(pStatics + 48);
                if (lVar1 == null) throw; // [null/range check failed]
                if (*(char *)(lVar1 + 118) == false) {
                  lVar1 = *(int64 *)(pStatics + 48);
                  if (lVar1 == null) throw; // [null/range check failed]
                  MouseController.Notify(*(uint64 *)(lVar1 + 72),"OnLongPress",0,0);
                }
              }
            }
          }
          return;
        }
    }

    // Token : 0x600195B
    // RVA   : 0xDF0C60   Offset: 0xDF0060   Length: 0x10A9
    private void ProcessPress(bool pressed, float click, float drag)
    {
        var pStatics = *(int64*)(DAT_181d8b790 + 184);
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
          lVar7 = *(int64 *)(pStatics + 48);
          if (lVar7 == null) goto LAB_180df1cfe;
          uVar8 = *(uint64 *)(lVar7 + 80);
          cVar4 = Object.op_Inequality(uVar8,0,0);
          if (!cVar4) {
            return;
          }
          lVar7 = *(int64 *)(pStatics + 48);
          if (lVar7 == null) goto LAB_180df1cfe;
          fVar11 = (float)Vector2.get_sqrMagnitude(lVar7 + 36,0);
          if (fVar11 == 0.0) {
            lVar7 = *(int64 *)(pStatics + 48);
            if (lVar7 == null) goto LAB_180df1cfe;
            uVar8 = *(uint64 *)(lVar7 + 72);
            uVar6 = *(uint64 *)(lVar7 + 64);
            cVar4 = Object.op_Inequality(uVar8,uVar6,0);
            if (!cVar4) {
              return;
            }
          }
          lVar7 = *(int64 *)(pStatics + 48);
          if (lVar7 == null) goto LAB_180df1cfe;
          *(float *)(lVar7 + 44) = *(float *)(lVar7 + 36) + *(float *)(lVar7 + 44);
          *(float *)(lVar7 + 48) = *(float *)(lVar7 + 48) + *(float *)(lVar7 + 40);
          lVar7 = *(int64 *)(pStatics + 48);
          if (lVar7 == null) goto LAB_180df1cfe;
          fVar11 = (float)Vector2.get_sqrMagnitude(lVar7 + 44,0);
          bVar3 = false;
          lVar7 = *(int64 *)(pStatics + 48);
          if (lVar7 == null) goto LAB_180df1cfe;
          if (*(char *)(lVar7 + 118) == false) {
            lVar7 = *(int64 *)(pStatics + 48);
            if (lVar7 == null) goto LAB_180df1cfe;
            uVar8 = *(uint64 *)(lVar7 + 64);
            uVar6 = *(uint64 *)(lVar7 + 72);
            cVar4 = Object.op_Inequality(uVar8,uVar6,0);
            if (!cVar4) goto LAB_180df10ba;
            lVar7 = *(int64 *)(pStatics + 48);
            if (lVar7 == null) goto LAB_180df1cfe;
            *(uint8 *)(lVar7 + 118) = 1;
            lVar7 = *(int64 *)(pStatics + 48);
            if (lVar7 == null) goto LAB_180df1cfe;
            *(uint32 *)(lVar7 + 36) = *(uint32 *)(lVar7 + 44);
            *(uint32 *)(lVar7 + 40) = *(uint32 *)(lVar7 + 48);
            lVar7 = *(int64 *)(pStatics + 48);
            if (lVar7 == null) goto LAB_180df1cfe;
            *(uint32 *)(lVar7 + 112) = 0;
            *(uint8 *)(pStatics + 68) = 1;
            lVar7 = *(int64 *)(pStatics + 48);
            if (lVar7 == null) goto LAB_180df1cfe;
            MouseController.Notify(*(uint64 *)(lVar7 + 88),"OnDragStart",0,0);
            lVar7 = *(int64 *)(pStatics + 48);
            if (lVar7 == null) goto LAB_180df1cfe;
            MouseController.Notify
                      (*(uint64 *)(lVar7 + 64),"OnDragOver",*(uint64 *)(lVar7 + 88),0);
            *(uint8 *)(pStatics + 68) = 0;
          }
          else {
        LAB_180df10ba:
            lVar7 = *(int64 *)(pStatics + 48);
            if (lVar7 == null) goto LAB_180df1cfe;
            bVar3 = false;
            if ((*(char *)(lVar7 + 118) == false) && (drag < fVar11)) {
              bVar3 = true;
              lVar7 = *(int64 *)(pStatics + 48);
              if (lVar7 == null) goto LAB_180df1cfe;
              *(uint8 *)(lVar7 + 118) = 1;
              lVar7 = *(int64 *)(pStatics + 48);
              if (lVar7 == null) goto LAB_180df1cfe;
              *(uint32 *)(lVar7 + 36) = *(uint32 *)(lVar7 + 44);
              *(uint32 *)(lVar7 + 40) = *(uint32 *)(lVar7 + 48);
            }
          }
          lVar7 = *(int64 *)(pStatics + 48);
          if (lVar7 == null) goto LAB_180df1cfe;
          if (*(char *)(lVar7 + 118) == false) {
            return;
          }
          *(uint8 *)(pStatics + 68) = 1;
          lVar7 = *(int64 *)(pStatics + 48);
          if (lVar7 == null) goto LAB_180df1cfe;
          iVar1 = *(int *)(lVar7 + 112);
          if (bVar3) {
            lVar7 = *(int64 *)(pStatics + 48);
            if (lVar7 == null) goto LAB_180df1cfe;
            uVar8 = 0;
            uVar6 = *(uint64 *)(lVar7 + 88);
            uVar10 = "OnDragStart";
        LAB_180df12e6:
            MouseController.Notify(uVar6,uVar10,uVar8,0);
            lVar7 = *(int64 *)(pStatics + 48);
            if (lVar7 == null) goto LAB_180df1cfe;
            MouseController.Notify
                      (*(uint64 *)(lVar7 + 72),"OnDragOver",*(uint64 *)(lVar7 + 88),0);
          }
          else {
            lVar7 = *(int64 *)(pStatics + 48);
            if (lVar7 == null) goto LAB_180df1cfe;
            uVar8 = *(uint64 *)(lVar7 + 64);
            uVar6 = *(uint64 *)(lVar7 + 72);
            cVar4 = Object.op_Inequality(uVar8,uVar6,0);
            if (cVar4) {
              lVar7 = *(int64 *)(pStatics + 48);
              if (lVar7 == null) goto LAB_180df1cfe;
              uVar8 = *(uint64 *)(lVar7 + 88);
              uVar6 = *(uint64 *)(lVar7 + 64);
              uVar10 = "OnDragOut";
              goto LAB_180df12e6;
            }
          }
          lVar7 = *(int64 *)(pStatics + 48);
          if (lVar7 == null) {
        LAB_180df1cf8:
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          uVar8 = *(uint64 *)(lVar7 + 88);
          local_58 = *(uint64 *)(lVar7 + 36);
          uVar6 = il2cpp_value_box(DAT_181db3950,&local_58);
          MouseController.Notify(uVar8,"OnDrag",uVar6,0);
          lVar7 = *(int64 *)(pStatics + 48);
          if (lVar7 == null) goto LAB_180df1cf8;
          *(uint64 *)(lVar7 + 64) = *(uint64 *)(lVar7 + 72);
          *(uint8 *)(pStatics + 68) = 0;
          if (iVar1 == 0) {
            lVar7 = pStatics;
          }
          else {
            lVar7 = *(int64 *)(pStatics + 48);
            if (lVar7 == null) goto LAB_180df1cfe;
            if (*(int *)(lVar7 + 112) != 2) {
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
          goto LAB_180df1cfe;
        }
        lVar7 = *(int64 *)(pStatics + 48);
        if (lVar7 == null) {
        LAB_180df1cf2:
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
        *(uint8 *)(lVar7 + 117) = 1;
        lVar7 = *(int64 *)(pStatics + 48);
        if (lVar7 == null) goto LAB_180df1cf2;
        uVar8 = *(uint64 *)(lVar7 + 80);
        local_res10[0] = 0;
        uVar6 = il2cpp_value_box(DAT_181db2ac8,local_res10);
        MouseController.Notify(uVar8,"OnPress",uVar6,0);
        uVar8 = *(uint64 *)(pStatics + 8);
        cVar4 = Object.op_Implicit(uVar8,0);
        if (!cVar4) {
        LAB_180df163a:
          uVar8 = 0;
          puVar9 = (uint64 *)(pStatics + 8);
          *puVar9 = 0;
          il2cpp_internal(puVar9,0);
        }
        else {
          lVar7 = *(int64 *)(pStatics + 8);
          if (lVar7 == null) goto LAB_180df1cf2;
          cVar4 = GameObject.get_activeInHierarchy(lVar7,0);
          if (!cVar4) goto LAB_180df163a;
          uVar8 = *(uint64 *)(pStatics + 8);
        }
        cVar4 = Object.op_Equality(uVar8,0,0);
        if (cVar4) {
          lVar7 = *(int64 *)(pStatics + 48);
          if (lVar7 == null) goto LAB_180df1cfe;
          uVar8 = *(uint64 *)(lVar7 + 72);
          cVar4 = Object.op_Inequality(uVar8,0,0);
          if (cVar4) {
            lVar7 = *(int64 *)(pStatics + 48);
            if (lVar7 == null) goto LAB_180df1cfe;
            MouseController.set_hoveredObject(*(uint64 *)(lVar7 + 72),0);
          }
        }
        lVar7 = *(int64 *)(pStatics + 48);
        if (lVar7 != null) {
          *(uint64 *)(lVar7 + 80) = *(uint64 *)(lVar7 + 72);
          lVar7 = *(int64 *)(pStatics + 48);
          if (lVar7 != null) {
            *(uint64 *)(lVar7 + 88) = *(uint64 *)(lVar7 + 72);
            lVar7 = *(int64 *)(pStatics + 48);
            if (lVar7 != null) {
              *(uint32 *)(lVar7 + 112) = 2;
              lVar7 = *(int64 *)(pStatics + 48);
              local_58 = Vector2.get_zero(0);
              if (lVar7 != null) {
                local_58._4_4_ = (uint32)((uint64)local_58 >> 32);
                *(uint32 *)(lVar7 + 44) = (uint32)local_58;
                *(uint32 *)(lVar7 + 48) = local_58._4_4_;
                lVar7 = *(int64 *)(pStatics + 48);
                if (lVar7 != null) {
                  *(uint8 *)(lVar7 + 118) = 0;
                  lVar7 = *(int64 *)(pStatics + 48);
                  if (lVar7 != null) {
                    uVar8 = *(uint64 *)(lVar7 + 80);
                    local_res10[0] = 1;
                    uVar6 = il2cpp_value_box(DAT_181db2ac8,local_res10);
                    MouseController.Notify(uVar8,"OnPress",uVar6,0);
                    lVar7 = *(int64 *)(pStatics + 48);
                    uVar8 = *(uint64 *)(pStatics + 16);
                    if (lVar7 != null) {
                      uVar6 = *(uint64 *)(lVar7 + 80);
                      cVar4 = Object.op_Inequality(uVar8,uVar6,0);
                      if (!cVar4) {
                        return;
                      }
                      *(uint8 *)(pStatics + 56) = 0;
                      uVar8 = *(uint64 *)(pStatics + 16);
                      cVar4 = Object.op_Implicit(uVar8,0);
                      if (cVar4) {
                        uVar8 = *(uint64 *)(pStatics + 16);
                        local_res10[0] = 0;
                        uVar6 = il2cpp_value_box(DAT_181db2ac8,local_res10);
                        MouseController.Notify(uVar8,"OnSelect",uVar6,0);
                      }
                      lVar7 = *(int64 *)(pStatics + 48);
                      if (lVar7 != null) {
                        *(uint64 *)(pStatics + 16) =
                             *(uint64 *)(lVar7 + 80);
                        il2cpp_internal();
                        lVar7 = *(int64 *)(pStatics + 48);
                        if (lVar7 != null) {
                          uVar8 = *(uint64 *)(lVar7 + 80);
                          cVar4 = Object.op_Inequality(uVar8,0,0);
                          if (cVar4) {
                            lVar7 = *(int64 *)(pStatics + 48);
                            if ((lVar7 == null) || (lVar7 = *(int64 *)(lVar7 + 80)) == null)
                            goto LAB_180df1cfe;
                            uVar8 = GameObject.GetComponent(lVar7,DAT_181d74a10);
                            cVar4 = Object.op_Inequality(uVar8,0,0);
                            if (cVar4) {
                              lVar7 = *(int64 *)(pStatics + 48);
                              lVar2 = *(int64 *)(pStatics + 40);
                              if ((lVar7 == null) || (lVar2 == null)) goto LAB_180df1cfe;
                              *(uint64 *)(lVar2 + 72) = *(uint64 *)(lVar7 + 80);
                            }
                          }
                          uVar8 = *(uint64 *)(pStatics + 16);
                          cVar4 = Object.op_Implicit(uVar8,0);
                          if (!cVar4) {
                            return;
                          }
                          lVar7 = *(int64 *)(pStatics + 16);
                          if (lVar7 != null) {
                            cVar4 = GameObject.get_activeInHierarchy(lVar7,0);
                            if (!cVar4) {
                              uVar5 = 0;
                            }
                            else {
                              lVar7 = *(int64 *)(pStatics + 16);
                              if (lVar7 == null) goto LAB_180df1cfe;
                              uVar8 = GameObject.GetComponent(lVar7,DAT_181d74988);
                              uVar5 = Object.op_Inequality(uVar8,0,0);
                            }
                            *(uint8 *)(pStatics + 56) = uVar5;
                            uVar8 = *(uint64 *)(pStatics + 16);
                            local_res10[0] = 1;
                            uVar6 = il2cpp_value_box(DAT_181db2ac8,local_res10);
                            MouseController.Notify(uVar8,"OnSelect",uVar6,0);
                            return;
                          }
                        }
                      }
        LAB_180df1cfe:
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
    // RVA   : 0xDF1D10   Offset: 0xDF1110   Length: 0x986
    private void ProcessRelease(float drag)
    {
        var pStatics = *(int64*)(DAT_181d8b790 + 184);
        ulong uVar1;
        bool cVar2;
        ulong uVar3;
        long lVar4;
        long lVar5;
        float fVar7;
        byte[] local_res20 = new byte[8];
        if (*(int64 *)(pStatics + 48) == 0) {
          return;
        }
        lVar5 = *(int64 *)(pStatics + 48);
        if (lVar5 == null) throw; // [null/range check failed]
        *(uint8 *)(lVar5 + 117) = 0;
        lVar5 = *(int64 *)(pStatics + 48);
        if (lVar5 == null) throw; // [null/range check failed]
        uVar1 = *(uint64 *)(lVar5 + 80);
        cVar2 = Object.op_Inequality(uVar1,0,0);
        if (cVar2) {
          lVar5 = *(int64 *)(pStatics + 48);
          if (lVar5 == null) throw; // [null/range check failed]
          if (*(char *)(lVar5 + 118) != false) {
            lVar5 = *(int64 *)(pStatics + 48);
            if (lVar5 == null) throw; // [null/range check failed]
            MouseController.Notify
                      (*(uint64 *)(lVar5 + 64),"OnDragOut",*(uint64 *)(lVar5 + 88),0);
            lVar5 = *(int64 *)(pStatics + 48);
            if (lVar5 == null) throw; // [null/range check failed]
            MouseController.Notify(*(uint64 *)(lVar5 + 88),"OnDragEnd",0,0);
          }
          lVar5 = *(int64 *)(pStatics + 48);
          if (lVar5 == null) {
        LAB_180df2691:
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          uVar1 = *(uint64 *)(lVar5 + 80);
          local_res20[0] = 0;
          uVar3 = il2cpp_value_box(DAT_181db2ac8,local_res20);
          MouseController.Notify(uVar1,"OnPress",uVar3,0);
          lVar5 = *(int64 *)(pStatics + 48);
          if (lVar5 == null) goto LAB_180df2691;
          lVar5 = *(int64 *)(lVar5 + 80);
          cVar2 = Object.op_Equality(lVar5,0,0);
          if (!cVar2) {
            if (lVar5 == null) goto LAB_180df2691;
            lVar4 = GameObject.GetComponent(lVar5,DAT_181dc80c8);
            cVar2 = Object.op_Inequality(lVar4,0,0);
            if (!cVar2) {
              lVar5 = GameObject.GetComponent(lVar5,DAT_181dc8150);
              cVar2 = Object.op_Inequality(lVar5,0,0);
              if (!cVar2) goto LAB_180df2196;
              if (lVar5 == null) goto LAB_180df2691;
              cVar2 = Behaviour.get_enabled(lVar5,0);
            }
            else {
              if (lVar4 == null) goto LAB_180df2691;
              cVar2 = Collider.get_enabled(lVar4,0);
            }
            if (cVar2) {
              lVar5 = *(int64 *)(pStatics + 48);
              uVar1 = *(uint64 *)(pStatics + 8);
              if (lVar5 == null) throw; // [null/range check failed]
              uVar3 = *(uint64 *)(lVar5 + 72);
              cVar2 = Object.op_Equality(uVar1,uVar3,0);
              if (!cVar2) {
                lVar5 = *(int64 *)(pStatics + 48);
                if (lVar5 == null) throw; // [null/range check failed]
                MouseController.set_hoveredObject(*(uint64 *)(lVar5 + 72),0);
              }
              else {
                lVar5 = *(int64 *)(pStatics + 48);
                if (lVar5 == null) {
                          // WARNING: Subroutine does not return
                  FUN_1800d6620();
                }
                uVar1 = *(uint64 *)(lVar5 + 72);
                local_res20[0] = 1;
                uVar3 = il2cpp_value_box(DAT_181db2ac8,local_res20);
                MouseController.Notify(uVar1,"OnHover",uVar3,0);
              }
            }
          }
        LAB_180df2196:
          lVar5 = *(int64 *)(pStatics + 48);
          if (lVar5 == null) throw; // [null/range check failed]
          uVar1 = *(uint64 *)(lVar5 + 88);
          uVar3 = *(uint64 *)(lVar5 + 72);
          cVar2 = Object.op_Equality(uVar1,uVar3,0);
          if (!cVar2) {
            lVar5 = *(int64 *)(pStatics + 48);
            if (lVar5 == null) throw; // [null/range check failed]
            if (*(int *)(lVar5 + 112) != 0) {
              lVar5 = *(int64 *)(pStatics + 48);
              if (lVar5 == null) throw; // [null/range check failed]
              fVar7 = (float)Vector2.get_sqrMagnitude(lVar5 + 44,0);
              if (fVar7 < drag) goto LAB_180df2429;
            }
            lVar5 = *(int64 *)(pStatics + 48);
            if (lVar5 == null) throw; // [null/range check failed]
            if (*(char *)(lVar5 + 118) != false) {
              lVar5 = *(int64 *)(pStatics + 48);
              if (lVar5 == null) throw; // [null/range check failed]
              MouseController.Notify
                        (*(uint64 *)(lVar5 + 72),"OnDrop",*(uint64 *)(lVar5 + 88),0);
            }
          }
          else {
        LAB_180df2429:
            lVar5 = *(int64 *)(pStatics + 48);
            if (lVar5 == null) throw; // [null/range check failed]
            if (*(int *)(lVar5 + 112) != 0) {
              lVar5 = *(int64 *)(pStatics + 48);
              if (lVar5 == null) throw; // [null/range check failed]
              uVar1 = *(uint64 *)(lVar5 + 80);
              uVar3 = *(uint64 *)(lVar5 + 72);
              cVar2 = Object.op_Equality(uVar1,uVar3,0);
              if (cVar2) {
                fVar7 = (float)RealTime.get_time(0);
                lVar5 = *(int64 *)(pStatics + 48);
                if (lVar5 == null) throw; // [null/range check failed]
                MouseController.Notify(*(uint64 *)(lVar5 + 80),"OnClick",0,0);
                lVar5 = *(int64 *)(pStatics + 48);
                if (lVar5 == null) throw; // [null/range check failed]
                if (fVar7 < *(float *)(lVar5 + 108) + 0.35) {
                  lVar5 = *(int64 *)(pStatics + 48);
                  if (lVar5 == null) throw; // [null/range check failed]
                  uVar1 = *(uint64 *)(lVar5 + 96);
                  uVar3 = *(uint64 *)(lVar5 + 80);
                  cVar2 = Object.op_Equality(uVar1,uVar3,0);
                  if (cVar2) {
                    lVar5 = *(int64 *)(pStatics + 48);
                    if (lVar5 == null) throw; // [null/range check failed]
                    MouseController.Notify(*(uint64 *)(lVar5 + 80),"OnDoubleClick",0,0);
                  }
                }
                lVar5 = *(int64 *)(pStatics + 48);
                if (lVar5 == null) throw; // [null/range check failed]
                *(uint64 *)(lVar5 + 96) = *(uint64 *)(lVar5 + 80);
                lVar5 = *(int64 *)(pStatics + 48);
                if (lVar5 == null) throw; // [null/range check failed]
                *(float *)(lVar5 + 108) = fVar7;
              }
            }
          }
        }
        lVar5 = *(int64 *)(pStatics + 48);
        if (lVar5 != null) {
          *(uint8 *)(lVar5 + 118) = 0;
          lVar5 = *(int64 *)(pStatics + 48);
          if (lVar5 != null) {
            puVar6 = (uint64 *)(lVar5 + 80);
            *puVar6 = 0;
            il2cpp_internal(puVar6,0);
            lVar5 = *(int64 *)(pStatics + 48);
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
    // RVA   : 0xDEF730   Offset: 0xDEEB30   Length: 0x14A
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
          lVar1 = GameObject.GetComponent(go,DAT_181dc80c8);
          cVar2 = Object.op_Inequality(lVar1,0,0);
          if (!cVar2) {
            lVar1 = GameObject.GetComponent(go,DAT_181dc8150);
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
    // RVA   : 0xDF33B0   Offset: 0xDF27B0   Length: 0x84
    public void /*ctor*/()
    {
        ulong uVar1;
        uVar1 = il2cpp_internal(DAT_181d965d0);
        FUN_18132faf0(uVar1,DAT_181d9e188);
        this.uiRaycastResults = uVar1;
        this.mouseDragThreshold = 0x40800000;
        this.mouseClickThreshold = 0x41200000;
        FUN_18044ef50(this,0);
    }

    // Token : 0x600195F
    // RVA   : 0xDF3080   Offset: 0xDF2480   Length: 0x325
    private static void /*cctor*/()
    {
        var pStatics = *(int64*)(DAT_181d8b790 + 184);
        long lVar2;
        long lVar3;
        ulong uVar4;
        uint local_res10;
        uint uStackX_14;
        byte[] local_18 = new byte[16];
        puVar5 = (uint64 *)(pStatics + 24);
        *puVar5 = 0;
        il2cpp_internal(puVar5,0);
        plVar1 = (int64 *)FUN_1800d60b0(DAT_181da88e0,3);
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
          puVar5 = (uint64 *)(pStatics + 32);
          *puVar5 = plVar1;
          il2cpp_internal(puVar5,plVar1);
          uVar4 = new MouseOrTouch(0);
          puVar5 = (uint64 *)(pStatics + 40);
          *puVar5 = uVar4;
          il2cpp_internal(puVar5,uVar4);
          puVar5 = (uint64 *)(pStatics + 48);
          *puVar5 = 0;
          il2cpp_internal(puVar5,0);
          *(uint8 *)(pStatics + 56) = 0;
          uVar4 = Vector2.get_zero(0);
          local_res10 = (uint32)uVar4;
          uStackX_14 = (uint32)((uint64)uVar4 >> 32);
          lVar2 = pStatics;
          *(uint32 *)(lVar2 + 60) = local_res10;
          *(uint32 *)(lVar2 + 64) = uStackX_14;
          *(uint8 *)(pStatics + 68) = 0;
          *(uint32 *)(pStatics + 80) = 0xffffff9c;
          *(uint32 *)(pStatics + 84) = 48;
          puVar5 = (uint64 *)Vector3.get_zero(local_18,0);
          lVar2 = pStatics;
          *(uint64 *)(lVar2 + 88) = *puVar5;
          *(uint32 *)(lVar2 + 96) = *(uint32 *)(puVar5 + 1);
          lVar2 = pStatics;
          *(uint64 *)(lVar2 + 100) = 0;
          *(uint64 *)(lVar2 + 108) = 0;
          *(uint64 *)(lVar2 + 116) = 0;
          *(uint32 *)(pStatics + 168) = 0;
          return;
        }
        uVar4 = il2cpp_internal();
    }

}
