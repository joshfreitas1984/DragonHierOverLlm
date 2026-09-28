// ============================================================
// Type  : UICamera
// Token : 0x20000D8
// ============================================================

public class UICamera
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4000531
    public static BetterList<UICamera> list;

    // Token: 0x4000532
    public static GetKeyStateFunc GetKeyDown;

    // Token: 0x4000533
    public static GetKeyStateFunc GetKeyUp;

    // Token: 0x4000534
    public static GetKeyStateFunc GetKey;

    // Token: 0x4000535
    public static GetAxisFunc GetAxis;

    // Token: 0x4000536
    public static GetAnyKeyFunc GetAnyKeyDown;

    // Token: 0x4000537
    public static GetMouseDelegate GetMouse;

    // Token: 0x4000538
    public static GetTouchDelegate GetTouch;

    // Token: 0x4000539
    public static RemoveTouchDelegate RemoveTouch;

    // Token: 0x400053A
    public static OnScreenResize onScreenResize;

    // Token: 0x400053B
    public EventType eventType;

    // Token: 0x400053C
    public bool eventsGoToColliders;

    // Token: 0x400053D
    public LayerMask eventReceiverMask;

    // Token: 0x400053E
    public ProcessEventsIn processEventsIn;

    // Token: 0x400053F
    public bool debug;

    // Token: 0x4000540
    public bool useMouse;

    // Token: 0x4000541
    public bool useTouch;

    // Token: 0x4000542
    public bool allowMultiTouch;

    // Token: 0x4000543
    public bool useKeyboard;

    // Token: 0x4000544
    public bool useController;

    // Token: 0x4000545
    public bool stickyTooltip;

    // Token: 0x4000546
    public float tooltipDelay;

    // Token: 0x4000547
    public bool longPressTooltip;

    // Token: 0x4000548
    public float mouseDragThreshold;

    // Token: 0x4000549
    public float mouseClickThreshold;

    // Token: 0x400054A
    public float touchDragThreshold;

    // Token: 0x400054B
    public float touchClickThreshold;

    // Token: 0x400054C
    public float rangeDistance;

    // Token: 0x400054D
    public string horizontalAxisName;

    // Token: 0x400054E
    public string verticalAxisName;

    // Token: 0x400054F
    public string horizontalPanAxisName;

    // Token: 0x4000550
    public string verticalPanAxisName;

    // Token: 0x4000551
    public string scrollAxisName;

    // Token: 0x4000552
    public bool commandClick;

    // Token: 0x4000553
    public KeyCode submitKey0;

    // Token: 0x4000554
    public KeyCode submitKey1;

    // Token: 0x4000555
    public KeyCode cancelKey0;

    // Token: 0x4000556
    public KeyCode cancelKey1;

    // Token: 0x4000557
    public bool autoHideCursor;

    // Token: 0x4000558
    public static OnCustomInput onCustomInput;

    // Token: 0x4000559
    public static bool showTooltips;

    // Token: 0x400055A
    public static bool ignoreAllEvents;

    // Token: 0x400055B
    public static bool ignoreControllerInput;

    // Token: 0x400055C
    private static bool mDisableController;

    // Token: 0x400055D
    private static Vector2 mLastPos;

    // Token: 0x400055E
    public static Vector3 lastWorldPosition;

    // Token: 0x400055F
    public static Ray lastWorldRay;

    // Token: 0x4000560
    public static RaycastHit lastHit;

    // Token: 0x4000561
    public static UICamera current;

    // Token: 0x4000562
    public static Camera currentCamera;

    // Token: 0x4000563
    public static OnSchemeChange onSchemeChange;

    // Token: 0x4000564
    private static ControlScheme mLastScheme;

    // Token: 0x4000565
    public static int currentTouchID;

    // Token: 0x4000566
    private static KeyCode mCurrentKey;

    // Token: 0x4000567
    public static MouseOrTouch currentTouch;

    // Token: 0x4000568
    private static bool mInputFocus;

    // Token: 0x4000569
    private static GameObject mGenericHandler;

    // Token: 0x400056A
    public static GameObject fallThrough;

    // Token: 0x400056B
    public static VoidDelegate onClick;

    // Token: 0x400056C
    public static VoidDelegate onDoubleClick;

    // Token: 0x400056D
    public static BoolDelegate onHover;

    // Token: 0x400056E
    public static BoolDelegate onPress;

    // Token: 0x400056F
    public static BoolDelegate onSelect;

    // Token: 0x4000570
    public static FloatDelegate onScroll;

    // Token: 0x4000571
    public static VectorDelegate onDrag;

    // Token: 0x4000572
    public static VoidDelegate onDragStart;

    // Token: 0x4000573
    public static ObjectDelegate onDragOver;

    // Token: 0x4000574
    public static ObjectDelegate onDragOut;

    // Token: 0x4000575
    public static VoidDelegate onDragEnd;

    // Token: 0x4000576
    public static ObjectDelegate onDrop;

    // Token: 0x4000577
    public static KeyCodeDelegate onKey;

    // Token: 0x4000578
    public static KeyCodeDelegate onNavigate;

    // Token: 0x4000579
    public static VectorDelegate onPan;

    // Token: 0x400057A
    public static BoolDelegate onTooltip;

    // Token: 0x400057B
    public static MoveDelegate onMouseMove;

    // Token: 0x400057C
    private static MouseOrTouch[] mMouse;

    // Token: 0x400057D
    public static MouseOrTouch controller;

    // Token: 0x400057E
    public static List<MouseOrTouch> activeTouches;

    // Token: 0x400057F
    private static List<int> mTouchIDs;

    // Token: 0x4000580
    private static int mWidth;

    // Token: 0x4000581
    private static int mHeight;

    // Token: 0x4000582
    private static GameObject mTooltip;

    // Token: 0x4000583
    private Camera mCam;

    // Token: 0x4000584
    private static float mTooltipTime;

    // Token: 0x4000585
    private float mNextRaycast;

    // Token: 0x4000586
    public static bool isDragging;

    // Token: 0x4000587
    private static int mLastInteractionCheck;

    // Token: 0x4000588
    private static bool mLastInteractionResult;

    // Token: 0x4000589
    private static int mLastFocusCheck;

    // Token: 0x400058A
    private static bool mLastFocusResult;

    // Token: 0x400058B
    private static int mLastOverCheck;

    // Token: 0x400058C
    private static bool mLastOverResult;

    // Token: 0x400058D
    private static GameObject mRayHitObject;

    // Token: 0x400058E
    private static GameObject mHover;

    // Token: 0x400058F
    private static GameObject mSelected;

    // Token: 0x4000590
    private static DepthEntry mHit;

    // Token: 0x4000591
    private static BetterList<DepthEntry> mHits;

    // Token: 0x4000592
    private static RaycastHit[] mRayHits;

    // Token: 0x4000593
    private static Collider2D[] mOverlap;

    // Token: 0x4000594
    private static Plane m2DPlane;

    // Token: 0x4000595
    private static float mNextEvent;

    // Token: 0x4000596
    private static int mNotifying;

    // Token: 0x4000597
    private static bool disableControllerCheck;

    // Token: 0x4000598
    private static bool mUsingTouchEvents;

    // Token: 0x4000599
    public static GetTouchCountCallback GetInputTouchCount;

    // Token: 0x400059A
    public static GetTouchCallback GetInputTouch;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60006F0
    // RVA   : 0x216180   Offset: 0x215580   Length: 0x3
    public bool get_stickyPress()
    {
        return true;
    }

    // Token : 0x60006F1
    // RVA   : 0x153F800   Offset: 0x153EC00   Length: 0x97
    public static bool get_disableController()
    {
        bool cVar1;
        if (*(char *)(*(int64 *)(DAT_181daf678 + 184) + 91) == false) {
          return false;
        }
        cVar1 = UIPopupList.get_isOpen(0);
        return !cVar1;
    }

    // Token : 0x60006F2
    // RVA   : 0x1541BC0   Offset: 0x1540FC0   Length: 0x5D
    public static void set_disableController(bool value)
    {
        *(uint8 *)(*(int64 *)(DAT_181daf678 + 184) + 91) = value;
    }

    // Token : 0x60006F3
    // RVA   : 0x1540BF0   Offset: 0x153FFF0   Length: 0x66
    public static Vector2 get_lastTouchPosition()
    {
        return *(uint64 *)(*(int64 *)(DAT_181daf678 + 184) + 92);
    }

    // Token : 0x60006F4
    // RVA   : 0x15426F0   Offset: 0x1541AF0   Length: 0x6F
    public static void set_lastTouchPosition(Vector2 value)
    {
        long lVar1;
        uint local_res18;
        uint32 uStackX_1c;
        lVar1 = *(int64 *)(DAT_181daf678 + 184);
        local_res18 = (uint32)value;
        uStackX_1c = (uint32)((uint64)value >> 32);
        *(uint32 *)(lVar1 + 92) = local_res18;
        *(uint32 *)(lVar1 + 96) = uStackX_1c;
    }

    // Token : 0x60006F5
    // RVA   : 0x1540A00   Offset: 0x153FE00   Length: 0x1E3
    public static Vector2 get_lastEventPosition()
    {
        bool cVar1;
        int iVar2;
        uint uVar3;
        long lVar4;
        ulong uVar5;
        ulong local_48;
        uint local_40;
        byte[] local_38 = new byte[24];
        uint local_20;
        uint32 uStack_1c;
        uint32 uStack_18;
        uint32 uStack_14;
        uint64 local_10;
        iVar2 = UICamera.get_currentScheme(0);
        if (iVar2 == 2) {
          lVar4 = UICamera.get_hoveredObject(0);
          cVar1 = Object.op_Inequality(lVar4,0,0);
          if (cVar1) {
            if (lVar4 != null) {
              uVar5 = GameObject.get_transform(lVar4,0);
              puVar6 = (uint32 *)NGUIMath.CalculateAbsoluteWidgetBounds(local_38,uVar5,0);
              local_20 = *puVar6;
              uStack_1c = puVar6[1];
              uStack_18 = puVar6[2];
              uStack_14 = puVar6[3];
              local_10 = *(uint64 *)(puVar6 + 4);
              uVar3 = GameObject.get_layer(lVar4,0);
              lVar4 = NGUITools.FindCameraForLayer(uVar3,0);
              puVar7 = (uint64 *)FUN_18045e0a0(local_38,&local_20,0);
              if (lVar4 != null) {
                local_40 = *(uint32 *)(puVar7 + 1);
                local_48 = *puVar7;
                puVar7 = (uint64 *)Camera.WorldToScreenPoint(local_38,lVar4,&local_48,0);
                return *puVar7;
              }
            }
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
        }
        return *(uint64 *)(*(int64 *)(DAT_181daf678 + 184) + 92);
    }

    // Token : 0x60006F6
    // RVA   : 0x1542680   Offset: 0x1541A80   Length: 0x6F
    public static void set_lastEventPosition(Vector2 value)
    {
        long lVar1;
        uint local_res18;
        uint32 uStackX_1c;
        lVar1 = *(int64 *)(DAT_181daf678 + 184);
        local_res18 = (uint32)value;
        uStackX_1c = (uint32)((uint64)value >> 32);
        *(uint32 *)(lVar1 + 92) = local_res18;
        *(uint32 *)(lVar1 + 96) = uStackX_1c;
    }

    // Token : 0x60006F7
    // RVA   : 0x153FCF0   Offset: 0x153F0F0   Length: 0xE6
    public static UICamera get_first()
    {
        var pStatics = *(int64*)(DAT_181daf678 + 184);
        long lVar1;
        ulong uVar2;
        if (*pStatics == 0) {
          return 0;
        }
        if (*pStatics != 0) {
          if (*(int *)(*pStatics + 24) == 0) {
            return 0;
          }
          if ((*pStatics != 0) &&
             (lVar1 = *(int64 *)(*pStatics + 16)) != null) {
            if (*(int *)(lVar1 + 24) == 0) {
              uVar2 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar2,0);
            }
            return *(uint64 *)(lVar1 + 32);
          }
        }
    }

    // Token : 0x60006F8
    // RVA   : 0x153F5A0   Offset: 0x153E9A0   Length: 0x251
    public static ControlScheme get_currentScheme()
    {
        var pStatics = *(int64*)(DAT_181daf678 + 184);
        ulong uVar1;
        long lVar2;
        bool cVar3;
        if (*(int *)(pStatics + 216) == 0) {
          return 1;
        }
        if (0x149 < *(int *)(pStatics + 216)) {
          return 2;
        }
        uVar1 = *(uint64 *)(pStatics + 184);
        cVar3 = Object.op_Inequality(uVar1,0,0);
        if (!cVar3) {
          return 0;
        }
        if (*(int *)(pStatics + 208) == 2) {
          lVar2 = *(int64 *)(pStatics + 184);
          if (lVar2 == null) throw; // [null/range check failed]
          if (*(int *)(pStatics + 216) == *(int *)(lVar2 + 124)) {
            return 2;
          }
          lVar2 = *(int64 *)(pStatics + 184);
          if (lVar2 == null) throw; // [null/range check failed]
          if (*(int *)(pStatics + 216) == *(int *)(lVar2 + 128)) {
            return 2;
          }
        }
        lVar2 = *(int64 *)(pStatics + 184);
        if (lVar2 != null) {
          if (*(char *)(lVar2 + 41) != false) {
            return 0;
          }
          lVar2 = *(int64 *)(pStatics + 184);
          if (lVar2 != null) {
            if (*(char *)(lVar2 + 42) != false) {
              return 1;
            }
            return 2;
          }
        }
    }

    // Token : 0x60006F9
    // RVA   : 0x1541AA0   Offset: 0x1540EA0   Length: 0x11F
    public static void set_currentScheme(ControlScheme value)
    {
        var pStatics = *(int64*)(DAT_181daf678 + 184);
        ulong uVar1;
        if (*(int *)(pStatics + 208) != value) {
          if (value == null) {
            uVar1 = 0x143;
          }
          else if (value == 2) {
            uVar1 = 0x14a;
          }
          else if (value == 1) {
            uVar1 = 0;
          }
          else {
            uVar1 = 48;
          }
          UICamera.set_currentKey(uVar1,0);
          *(int *)(pStatics + 208) = value;
        }
    }

    // Token : 0x60006FA
    // RVA   : 0x153F390   Offset: 0x153E790   Length: 0x5A
    public static KeyCode get_currentKey()
    {
        return *(uint32 *)(*(int64 *)(DAT_181daf678 + 184) + 216);
    }

    // Token : 0x60006FB
    // RVA   : 0x1541790   Offset: 0x1540B90   Length: 0x309
    public static void set_currentKey(KeyCode value)
    {
        var pStatics = *(int64*)(DAT_181daf678 + 184);
        int iVar1;
        long lVar2;
        bool cVar3;
        uint uVar4;
        ulong uVar5;
        if (*(int *)(pStatics + 216) != value) {
          iVar1 = *(int *)(pStatics + 208);
          *(int *)(pStatics + 216) = value;
          uVar4 = UICamera.get_currentScheme(0);
          *(uint32 *)(pStatics + 208) = uVar4;
          if (iVar1 == *(int *)(pStatics + 208)) {
            return;
          }
          UICamera.ShowTooltip(0,0);
          if (*(int *)(pStatics + 208) == 0) {
            Cursor.set_lockState(0,0);
            Cursor.set_visible(1,0);
          }
          else {
            uVar5 = *(uint64 *)(pStatics + 184);
            cVar3 = Object.op_Inequality(uVar5,0,0);
            if (cVar3) {
              lVar2 = *(int64 *)(pStatics + 184);
              if (lVar2 == null) goto LAB_181541a84;
              if (*(char *)(lVar2 + 140) != false) {
                Cursor.set_visible(0,0);
                Cursor.set_lockState(1);
                lVar2 = *(int64 *)(pStatics + 0x188);
                if (lVar2 == null) goto LAB_181541a84;
                if (*(int *)(lVar2 + 24) == 0) {
                  uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1800d65f0(uVar5,0);
                }
                if (*(int64 *)(lVar2 + 32) == 0) goto LAB_181541a84;
                *(uint32 *)(*(int64 *)(lVar2 + 32) + 120) = 2;
              }
            }
          }
          if (*(int64 *)(pStatics + 200) != 0) {
            lVar2 = *(int64 *)(pStatics + 200);
            if (lVar2 == null) {
        LAB_181541a84:
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            OnGeometryUpdated.Invoke(lVar2,0);
          }
        }
    }

    // Token : 0x60006FC
    // RVA   : 0x153F3F0   Offset: 0x153E7F0   Length: 0x1A7
    public static Ray get_currentRay()
    {
        var pStatics = *(int64*)(DAT_181daf678 + 184);
        ulong uVar1;
        long lVar2;
        long lVar3;
        ulong uVar4;
        bool cVar5;
        uint local_48;
        uint uStack_44;
        uint local_40;
        ulong local_28;
        uint local_20;
        uVar1 = *(uint64 *)(pStatics + 192);
        cVar5 = Object.op_Inequality(uVar1,0,0);
        if (cVar5) {
          if (*(int64 *)(pStatics + 224) != 0) {
            lVar2 = *(int64 *)(pStatics + 224);
            lVar3 = *(int64 *)(pStatics + 192);
            if (lVar2 != null) {
              local_48 = *(uint32 *)(lVar2 + 20);
              uStack_44 = *(uint32 *)(lVar2 + 24);
              local_28 = *(uint64 *)(lVar2 + 20);
              local_40 = 0;
              if (lVar3 != null) {
                local_20 = 0;
                puVar6 = (uint64 *)Camera.ScreenPointToRay(&local_48,lVar3,&local_28,0);
                uVar4 = puVar6[1];
                uVar1 = puVar6[2];
                *param_1 = *puVar6;
                param_1[1] = uVar4;
                param_1[2] = uVar1;
                return param_1;
              }
            }
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
        }
        *param_1 = 0;
        param_1[1] = 0;
        param_1[2] = 0;
        return param_1;
    }

    // Token : 0x60006FD
    // RVA   : 0x1540130   Offset: 0x153F530   Length: 0x120
    public static bool get_inputHasFocus()
    {
        var pStatics = *(int64*)(DAT_181daf678 + 184);
        ulong uVar1;
        long lVar2;
        bool cVar3;
        if (*(char *)(pStatics + 232) != false) {
          uVar1 = *(uint64 *)(pStatics + 0x1e8);
          cVar3 = Object.op_Implicit(uVar1,0);
          if (cVar3) {
            lVar2 = *(int64 *)(pStatics + 0x1e8);
            if (lVar2 == null) {
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            cVar3 = GameObject.get_activeInHierarchy(lVar2,0);
            if (cVar3) {
              return true;
            }
          }
        }
        return false;
    }

    // Token : 0x60006FE
    // RVA   : 0x153FDE0   Offset: 0x153F1E0   Length: 0x5B
    public static GameObject get_genericEventHandler()
    {
        return *(uint64 *)(*(int64 *)(DAT_181daf678 + 184) + 240);
    }

    // Token : 0x60006FF
    // RVA   : 0x1541C20   Offset: 0x1541020   Length: 0x6B
    public static void set_genericEventHandler(GameObject value)
    {
        puVar1 = (uint64 *)(*(int64 *)(DAT_181daf678 + 184) + 240);
        *puVar1 = value;
        il2cpp_internal(puVar1,value);
    }

    // Token : 0x6000700
    // RVA   : 0x1540D10   Offset: 0x1540110   Length: 0x7F
    public static MouseOrTouch get_mouse0()
    {
        long lVar1;
        ulong uVar2;
        lVar1 = *(int64 *)(*(int64 *)(DAT_181daf678 + 184) + 0x188);
        if (lVar1 != null) {
          if (*(int *)(lVar1 + 24) != 0) {
            return *(uint64 *)(lVar1 + 32);
          }
          uVar2 = il2cpp_internal();
                          // WARNING: Subroutine does not return
          FUN_1800d65f0(uVar2,0);
        }
    }

    // Token : 0x6000701
    // RVA   : 0x1540D90   Offset: 0x1540190   Length: 0x7F
    public static MouseOrTouch get_mouse1()
    {
        long lVar1;
        ulong uVar2;
        lVar1 = *(int64 *)(*(int64 *)(DAT_181daf678 + 184) + 0x188);
        if (lVar1 != null) {
          if (1 < *(uint32 *)(lVar1 + 24)) {
            return *(uint64 *)(lVar1 + 40);
          }
          uVar2 = il2cpp_internal();
                          // WARNING: Subroutine does not return
          FUN_1800d65f0(uVar2,0);
        }
    }

    // Token : 0x6000702
    // RVA   : 0x1540E10   Offset: 0x1540210   Length: 0x7F
    public static MouseOrTouch get_mouse2()
    {
        long lVar1;
        ulong uVar2;
        lVar1 = *(int64 *)(*(int64 *)(DAT_181daf678 + 184) + 0x188);
        if (lVar1 != null) {
          if (2 < *(uint32 *)(lVar1 + 24)) {
            return *(uint64 *)(lVar1 + 48);
          }
          uVar2 = il2cpp_internal();
                          // WARNING: Subroutine does not return
          FUN_1800d65f0(uVar2,0);
        }
    }

    // Token : 0x6000703
    // RVA   : 0x153FE40   Offset: 0x153F240   Length: 0x93
    private bool get_handlesEvents()
    {
        ulong uVar1;
        uVar1 = UICamera.get_eventHandler(0);
        Object.op_Equality(uVar1,this,0);
    }

    // Token : 0x6000704
    // RVA   : 0x153ECF0   Offset: 0x153E0F0   Length: 0xAC
    public Camera get_cachedCamera()
    {
        bool cVar1;
        ulong uVar2;
        uVar2 = this.mCam;
        cVar1 = Object.op_Equality(uVar2,0,0);
        if (cVar1) {
          uVar2 = Component.GetComponent(this,DAT_181d937e0);
          this.mCam = uVar2;
        }
        return this.mCam;
    }

    // Token : 0x6000705
    // RVA   : 0x1541000   Offset: 0x1540400   Length: 0x5B
    public static GameObject get_tooltipObject()
    {
        return *(uint64 *)(*(int64 *)(DAT_181daf678 + 184) + 0x1b0);
    }

    // Token : 0x6000706
    // RVA   : 0x1543100   Offset: 0x1542500   Length: 0x52
    public static void set_tooltipObject(GameObject value)
    {
        UICamera.ShowTooltip(value,0);
    }

    // Token : 0x6000707
    // RVA   : 0x15348D0   Offset: 0x1533CD0   Length: 0x154
    public static bool IsPartOfUI(GameObject go)
    {
        ulong uVar1;
        ulong uVar2;
        uVar1 = Object.op_Equality(go,0,0);
        if ((char)!uVar1) {
          uVar2 = *(uint64 *)(*(int64 *)(DAT_181daf678 + 184) + 248);
          uVar1 = Object.op_Equality(go,uVar2,0);
          if ((char)!uVar1) {
            uVar2 = NGUITools.FindInParents(go,DAT_181d8f820);
            uVar1 = Object.op_Inequality(uVar2,0,0);
            return uVar1;
          }
        }
        return uVar1 & 0xffffffffffffff00;
    }

    // Token : 0x6000708
    // RVA   : 0x1540580   Offset: 0x153F980   Length: 0x478
    public static bool get_isOverUI()
    {
        var pStatics = *(int64*)(DAT_181daf678 + 184);
        int iVar1;
        bool cVar2;
        byte uVar3;
        int iVar4;
        long lVar5;
        ulong uVar6;
        uint uVar7;
        iVar4 = Time.get_frameCount(0);
        if (*(int *)(pStatics + 0x1d0) == iVar4) {
        LAB_181540883:
          return *(uint8 *)(pStatics + 0x1d4);
        }
        *(int *)(pStatics + 0x1d0) = iVar4;
        if (*(int64 *)(pStatics + 224) == 0) {
          iVar4 = 0;
          lVar5 = *(int64 *)(pStatics + 0x198);
          if (lVar5 != null) {
            iVar1 = *(int *)(lVar5 + 24);
            if (0 < iVar1) {
              do {
                lVar5 = *(int64 *)(pStatics + 0x198);
                if ((lVar5 == null) || (lVar5 = FUN_180002f80(lVar5,iVar4,DAT_181db41d8)) == null)
                goto LAB_1815409e3;
                cVar2 = UICamera.IsPartOfUI(*(uint64 *)(lVar5 + 80),0);
                if (cVar2) goto LAB_181540798;
                iVar4 = iVar4 + 1;
              } while (iVar4 < iVar1);
            }
            uVar7 = 0;
            do {
              lVar5 = *(int64 *)(pStatics + 0x188);
              if (lVar5 == null) goto LAB_1815409e3;
              if (*(uint32 *)(lVar5 + 24) <= uVar7) {
                uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar6,0);
              }
              lVar5 = lVar5[uVar7];
              if (lVar5 == null) goto LAB_1815409e3;
              uVar6 = *(uint64 *)(lVar5 + 80);
              cVar2 = Object.op_Inequality(uVar6,0,0);
              if (!cVar2) {
                if (uVar7 == 0) {
                  uVar6 = *(uint64 *)(lVar5 + 72);
                }
                else {
                  uVar6 = 0;
                }
              }
              else {
                uVar6 = *(uint64 *)(lVar5 + 80);
              }
              cVar2 = UICamera.IsPartOfUI(uVar6);
              if (cVar2) goto LAB_181540798;
              uVar7 = uVar7 + 1;
            } while ((int)uVar7 < 3);
            lVar5 = *(int64 *)(pStatics + 400);
            if (lVar5 != null) {
              uVar3 = UICamera.IsPartOfUI(*(uint64 *)(lVar5 + 80),0);
              *(uint8 *)(pStatics + 0x1d4) = uVar3;
              goto LAB_181540883;
            }
          }
        }
        else {
          lVar5 = *(int64 *)(pStatics + 224);
          if (lVar5 != null) {
            uVar6 = *(uint64 *)(lVar5 + 80);
            cVar2 = Object.op_Inequality(uVar6,0,0);
            if (!cVar2) {
              lVar5 = *(int64 *)(pStatics + 224);
              if (lVar5 == null) goto LAB_1815409e3;
              uVar6 = *(uint64 *)(lVar5 + 72);
            }
            else {
              lVar5 = *(int64 *)(pStatics + 224);
              if (lVar5 == null) goto LAB_1815409e3;
              uVar6 = *(uint64 *)(lVar5 + 80);
            }
            uVar3 = UICamera.IsPartOfUI(uVar6,0);
            *(uint8 *)(pStatics + 0x1d4) = uVar3;
            goto LAB_1815409be;
          }
        }
        LAB_1815409e3:
                          // WARNING: Subroutine does not return
        FUN_1800d6620();
        LAB_181540798:
        *(uint8 *)(pStatics + 0x1d4) = 1;
        LAB_1815409be:
        return *(uint8 *)(pStatics + 0x1d4);
    }

    // Token : 0x6000709
    // RVA   : 0x15410B0   Offset: 0x15404B0   Length: 0x433
    public static bool get_uiHasFocus()
    {
        var pStatics = *(int64*)(DAT_181daf678 + 184);
        int iVar1;
        bool cVar2;
        byte uVar3;
        int iVar4;
        long lVar5;
        ulong uVar6;
        uint uVar7;
        iVar4 = Time.get_frameCount(0);
        if (*(int *)(pStatics + 0x1c8) == iVar4) {
        LAB_181541418:
          return *(uint8 *)(pStatics + 0x1cc);
        }
        *(int *)(pStatics + 0x1c8) = iVar4;
        cVar2 = UICamera.get_inputHasFocus(0);
        if (cVar2) goto LAB_181541290;
        if (*(int64 *)(pStatics + 224) == 0) {
          iVar4 = 0;
          lVar5 = *(int64 *)(pStatics + 0x198);
          if (lVar5 != null) {
            iVar1 = *(int *)(lVar5 + 24);
            if (0 < iVar1) {
              do {
                lVar5 = *(int64 *)(pStatics + 0x198);
                if (lVar5 == null) throw; // [null/range check failed]
                lVar5 = FUN_180002f80(lVar5,iVar4,DAT_181db41d8);
                if (lVar5 == null) throw; // [null/range check failed]
                cVar2 = UICamera.IsPartOfUI(*(uint64 *)(lVar5 + 80),0);
                if (cVar2) goto LAB_181541290;
                iVar4 = iVar4 + 1;
              } while (iVar4 < iVar1);
            }
            lVar5 = *(int64 *)(pStatics + 0x188);
            if (lVar5 != null) {
              if (*(int *)(lVar5 + 24) == 0) {
                uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar6,0);
              }
              lVar5 = *(int64 *)(lVar5 + 32);
              if (lVar5 != null) {
                cVar2 = UICamera.IsPartOfUI(*(uint64 *)(lVar5 + 80),0);
                if (!cVar2) {
                  uVar6 = *(uint64 *)(lVar5 + 72);
                  cVar2 = UICamera.IsPartOfUI(uVar6,0);
                  if (!cVar2) {
                    uVar7 = 1;
                    do {
                      lVar5 = *(int64 *)(pStatics + 0x188);
                      if (lVar5 == null) throw; // [null/range check failed]
                      if (*(uint32 *)(lVar5 + 24) <= uVar7) {
                        uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                        FUN_1800d65f0(uVar6,0);
                      }
                      lVar5 = lVar5[uVar7];
                      if (lVar5 == null) throw; // [null/range check failed]
                      cVar2 = UICamera.IsPartOfUI(*(uint64 *)(lVar5 + 80));
                      if (cVar2) goto LAB_181541290;
                      uVar7 = uVar7 + 1;
                    } while ((int)uVar7 < 3);
                    lVar5 = *(int64 *)(pStatics + 400);
                    if (lVar5 != null) {
                      uVar3 = UICamera.IsPartOfUI(*(uint64 *)(lVar5 + 80),0);
                      *(uint8 *)(pStatics + 0x1cc) = uVar3;
                      goto LAB_181541418;
                    }
                    throw; // [null/range check failed]
                  }
                }
        LAB_181541290:
                *(uint8 *)(pStatics + 0x1cc) = 1;
                return *(uint8 *)(pStatics + 0x1cc);
              }
            }
          }
        }
        else {
          lVar5 = *(int64 *)(pStatics + 224);
          if (lVar5 != null) {
            uVar3 = MouseOrTouch.get_isOverUI(lVar5,0);
            *(uint8 *)(pStatics + 0x1cc) = uVar3;
            return *(uint8 *)(pStatics + 0x1cc);
          }
        }
    }

    // Token : 0x600070A
    // RVA   : 0x1540260   Offset: 0x153F660   Length: 0x31C
    public static bool get_interactingWithUI()
    {
        var pStatics = *(int64*)(DAT_181daf678 + 184);
        int iVar1;
        bool cVar2;
        byte uVar3;
        int iVar4;
        long lVar5;
        ulong uVar6;
        uint uVar7;
        iVar4 = Time.get_frameCount(0);
        if (*(int *)(pStatics + 0x1c0) == iVar4) {
        LAB_181540508:
          return *(uint8 *)(pStatics + 0x1c4);
        }
        *(int *)(pStatics + 0x1c0) = iVar4;
        cVar2 = UICamera.get_inputHasFocus(0);
        if (cVar2) {
        LAB_181540547:
          if ((*(byte *)(DAT_181daf678 + 0x133) & 4) != 0) {
            iVar4 = *(int *)(DAT_181daf678 + 224);
        LAB_18154045f:
            if (iVar4 == 0) {
              il2cpp_runtime_class_init(DAT_181daf678);
            }
          }
        LAB_181540470:
          *(uint8 *)(pStatics + 0x1c4) = 1;
          return *(uint8 *)(pStatics + 0x1c4);
        }
        iVar4 = 0;
        lVar5 = *(int64 *)(pStatics + 0x198);
        if (lVar5 != null) {
          iVar1 = *(int *)(lVar5 + 24);
          uVar7 = 0;
          if (0 < iVar1) {
            do {
              lVar5 = *(int64 *)(pStatics + 0x198);
              if ((lVar5 == null) || (lVar5 = FUN_180002f80(lVar5,iVar4,DAT_181db41d8)) == null)
              throw; // [null/range check failed]
              cVar2 = UICamera.IsPartOfUI(*(uint64 *)(lVar5 + 80),0);
              if (cVar2) {
                if ((*(byte *)(DAT_181daf678 + 0x133) & 4) == 0) goto LAB_181540470;
                iVar4 = *(int *)(DAT_181daf678 + 224);
                goto LAB_18154045f;
              }
              iVar4 = iVar4 + 1;
              uVar7 = 0;
            } while (iVar4 < iVar1);
          }
          do {
            lVar5 = *(int64 *)(pStatics + 0x188);
            if (lVar5 == null) throw; // [null/range check failed]
            if (*(uint32 *)(lVar5 + 24) <= uVar7) {
              uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar6,0);
            }
            lVar5 = lVar5[uVar7];
            if (lVar5 == null) throw; // [null/range check failed]
            cVar2 = UICamera.IsPartOfUI(*(uint64 *)(lVar5 + 80));
            if (cVar2) goto LAB_181540547;
            uVar7 = uVar7 + 1;
          } while ((int)uVar7 < 3);
          lVar5 = *(int64 *)(pStatics + 400);
          if (lVar5 != null) {
            uVar3 = UICamera.IsPartOfUI(*(uint64 *)(lVar5 + 80),0);
            *(uint8 *)(pStatics + 0x1c4) = uVar3;
            goto LAB_181540508;
          }
        }
    }

    // Token : 0x600070B
    // RVA   : 0x153FEE0   Offset: 0x153F2E0   Length: 0x242
    public static GameObject get_hoveredObject()
    {
        var pStatics = *(int64*)(DAT_181daf678 + 184);
        long lVar1;
        ulong uVar2;
        bool cVar3;
        int iVar4;
        if (*(int64 *)(pStatics + 224) != 0) {
          iVar4 = UICamera.get_currentScheme(0);
          if (iVar4 == 0) {
            lVar1 = *(int64 *)(pStatics + 224);
            if (lVar1 == null) goto LAB_18154011d;
            if (*(char *)(lVar1 + 118) == false) goto LAB_18153ffe7;
          }
          lVar1 = *(int64 *)(pStatics + 224);
          if (lVar1 != null) {
            return *(uint64 *)(lVar1 + 72);
          }
        LAB_18154011d:
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
        LAB_18153ffe7:
        uVar2 = *(uint64 *)(pStatics + 0x1e0);
        cVar3 = Object.op_Implicit(uVar2,0);
        if (cVar3) {
          lVar1 = *(int64 *)(pStatics + 0x1e0);
          if (lVar1 == null) goto LAB_18154011d;
          cVar3 = GameObject.get_activeInHierarchy(lVar1,0);
          if (cVar3) {
            return *(uint64 *)(pStatics + 0x1e0);
          }
        }
        puVar5 = (uint64 *)(pStatics + 0x1e0);
        *puVar5 = 0;
        il2cpp_internal(puVar5,0);
        return 0;
    }

    // Token : 0x600070C
    // RVA   : 0x1541C90   Offset: 0x1541090   Length: 0x9ED
    public static void set_hoveredObject(GameObject value)
    {
        var pStatics = *(int64*)(DAT_181daf678 + 184);
        long lVar1;
        bool cVar3;
        int iVar4;
        uint uVar5;
        ulong uVar6;
        ulong uVar7;
        long lVar8;
        byte[] local_res8 = new byte[8];
        uVar7 = *(uint64 *)(pStatics + 0x1e0);
        cVar3 = Object.op_Equality(uVar7,value,0);
        if (!cVar3) {
          bVar2 = false;
          lVar1 = *(int64 *)(pStatics + 184);
          if (*(int64 *)(pStatics + 224) == 0) {
            bVar2 = true;
            *(uint32 *)(pStatics + 212) = 0xffffff9c;
            *(uint64 *)(pStatics + 224) =
                 *(uint64 *)(pStatics + 400);
            il2cpp_internal();
          }
          UICamera.ShowTooltip(0,0);
          uVar7 = *(uint64 *)(pStatics + 0x1e8);
          cVar3 = Object.op_Implicit(uVar7,0);
          if (cVar3) {
            iVar4 = UICamera.get_currentScheme(0);
            if (iVar4 == 2) {
              uVar7 = *(uint64 *)(pStatics + 0x1e8);
              local_res8[0] = 0;
              uVar6 = il2cpp_value_box(DAT_181db2ac8,local_res8);
              UICamera.Notify(uVar7,"OnSelect",uVar6,0);
              if (*(int64 *)(pStatics + 0x120) != 0) {
                lVar8 = *(int64 *)(pStatics + 0x120);
                if (lVar8 == null) goto LAB_181542668;
                OnTooltipCB.Invoke(lVar8,*(uint64 *)(pStatics + 0x1e8),0,0
                                   );
              }
              puVar9 = (uint64 *)(pStatics + 0x1e8);
              *puVar9 = 0;
              il2cpp_internal(puVar9,0);
            }
          }
          uVar7 = *(uint64 *)(pStatics + 0x1e0);
          cVar3 = Object.op_Implicit(uVar7,0);
          if (cVar3) {
            uVar7 = *(uint64 *)(pStatics + 0x1e0);
            local_res8[0] = 0;
            uVar6 = il2cpp_value_box(DAT_181db2ac8,local_res8);
            UICamera.Notify(uVar7,"OnHover",uVar6,0);
            if (*(int64 *)(pStatics + 0x110) != 0) {
              lVar8 = *(int64 *)(pStatics + 0x110);
              if (lVar8 == null) goto LAB_181542668;
              OnTooltipCB.Invoke(lVar8,*(uint64 *)(pStatics + 0x1e0),0,0);
            }
          }
          puVar9 = (uint64 *)(pStatics + 0x1e0);
          *puVar9 = value;
          il2cpp_internal(puVar9,value);
          lVar8 = *(int64 *)(pStatics + 224);
          if (lVar8 == null) {
        LAB_181542668:
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          *(uint32 *)(lVar8 + 112) = 0;
          uVar7 = *(uint64 *)(pStatics + 0x1e0);
          cVar3 = Object.op_Implicit(uVar7,0);
          if (cVar3) {
            lVar8 = *(int64 *)(pStatics + 400);
            uVar7 = *(uint64 *)(pStatics + 0x1e0);
            if (lVar8 == null) goto LAB_181542668;
            uVar6 = *(uint64 *)(lVar8 + 72);
            cVar3 = Object.op_Inequality(uVar7,uVar6,0);
            if (cVar3) {
              lVar8 = *(int64 *)(pStatics + 0x1e0);
              if (lVar8 == null) goto LAB_181542668;
              uVar7 = GameObject.GetComponent(lVar8,DAT_181d74a10);
              cVar3 = Object.op_Inequality(uVar7,0,0);
              if (cVar3) {
                lVar8 = *(int64 *)(pStatics + 400);
                if (lVar8 == null) goto LAB_181542668;
                *(uint64 *)(lVar8 + 72) =
                     *(uint64 *)(pStatics + 0x1e0);
                il2cpp_internal();
              }
            }
            if (bVar2) {
              uVar7 = *(uint64 *)(pStatics + 0x1e0);
              cVar3 = Object.op_Inequality(uVar7,0,0);
              if (!cVar3) {
                if ((*pStatics == 0) ||
                   (lVar8 = *(int64 *)(*pStatics + 16)) == null)
                goto LAB_181542668;
                if (*(int *)(lVar8 + 24) == 0) {
                  uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1800d65f0(uVar7,0);
                }
                lVar8 = *(int64 *)(lVar8 + 32);
              }
              else {
                lVar8 = *(int64 *)(pStatics + 0x1e0);
                if (lVar8 == null) goto LAB_181542668;
                uVar5 = GameObject.get_layer(lVar8,0);
                lVar8 = UICamera.FindCameraForLayer(uVar5,0);
              }
              cVar3 = Object.op_Inequality(lVar8,0,0);
              if (cVar3) {
                plVar10 = (int64 *)(pStatics + 184);
                *plVar10 = lVar8;
                il2cpp_internal(plVar10,lVar8);
                if (lVar8 == null) goto LAB_181542668;
                uVar7 = UICamera.get_cachedCamera(lVar8,0);
                puVar9 = (uint64 *)(pStatics + 192);
                *puVar9 = uVar7;
                il2cpp_internal(puVar9,uVar7);
              }
            }
            if (*(int64 *)(pStatics + 0x110) != 0) {
              lVar8 = *(int64 *)(pStatics + 0x110);
              if (lVar8 == null) goto LAB_181542668;
              OnTooltipCB.Invoke(lVar8,*(uint64 *)(pStatics + 0x1e0),1,0);
            }
            uVar7 = *(uint64 *)(pStatics + 0x1e0);
            local_res8[0] = 1;
            uVar6 = il2cpp_value_box(DAT_181db2ac8,local_res8);
            UICamera.Notify(uVar7,"OnHover",uVar6,0);
          }
          if (bVar2) {
            plVar10 = (int64 *)(pStatics + 184);
            *plVar10 = lVar1;
            il2cpp_internal(plVar10,lVar1);
            cVar3 = Object.op_Inequality(lVar1,0,0);
            if (!cVar3) {
              uVar7 = 0;
            }
            else {
              if (lVar1 == null) goto LAB_181542668;
              uVar7 = UICamera.get_cachedCamera(lVar1,0);
            }
            puVar9 = (uint64 *)(pStatics + 192);
            *puVar9 = uVar7;
            il2cpp_internal(puVar9,uVar7);
            puVar9 = (uint64 *)(pStatics + 224);
            *puVar9 = 0;
            il2cpp_internal(puVar9,0);
            *(uint32 *)(pStatics + 212) = 0xffffff9c;
          }
        }
    }

    // Token : 0x600070D
    // RVA   : 0x153EDA0   Offset: 0x153E1A0   Length: 0x5E9
    public static GameObject get_controllerNavigationObject()
    {
        var pStatics_f678 = *(int64*)(DAT_181daf678 + 184);
        var pStatics_fcf8 = *(int64*)(DAT_181dafcf8 + 184);
        bool cVar1;
        int iVar2;
        ulong uVar3;
        long lVar4;
        uint uVar6;
        lVar4 = *(int64 *)(pStatics_f678 + 400);
        if (lVar4 != null) {
          uVar3 = *(uint64 *)(lVar4 + 72);
          cVar1 = Object.op_Implicit(uVar3,0);
          if (cVar1) {
            lVar4 = *(int64 *)(pStatics_f678 + 400);
            if ((lVar4 == null) || (lVar4 = *(int64 *)(lVar4 + 72)) == null) throw; // [null/range check failed]
            cVar1 = GameObject.get_activeInHierarchy(lVar4,0);
            if (cVar1) {
              lVar4 = *(int64 *)(pStatics_f678 + 400);
              if (lVar4 != null) {
                return *(uint64 *)(lVar4 + 72);
              }
              throw; // [null/range check failed]
            }
          }
          iVar2 = UICamera.get_currentScheme(0);
          if (iVar2 == 2) {
            uVar3 = *(uint64 *)(pStatics_f678 + 184);
            cVar1 = Object.op_Inequality(uVar3,0,0);
            if (cVar1) {
              lVar4 = *(int64 *)(pStatics_f678 + 184);
              if (lVar4 == null) throw; // [null/range check failed]
              if (*(char *)(lVar4 + 45) != false) {
                if (*(char *)(pStatics_f678 + 90) == false) {
                  if (*pStatics_fcf8 == 0) throw; // [null/range check failed]
                  if (0 < *(int *)(*pStatics_fcf8 + 24)) {
                    uVar6 = 0;
                    do {
                      if (*pStatics_fcf8 == 0) throw; // [null/range check failed]
                      if (*(int *)(*pStatics_fcf8 + 24) <= (int)uVar6) {
                        uVar3 = *(uint64 *)(pStatics_f678 + 0x1e0);
                        cVar1 = Object.op_Equality(uVar3,0,0);
                        if (!cVar1) break;
                        uVar6 = 0;
                        goto LAB_18153f230;
                      }
                      if ((*pStatics_fcf8 == 0) ||
                         (lVar4 = *(int64 *)(*pStatics_fcf8 + 16)) == null
                         ) throw; // [null/range check failed]
                      if (*(uint32 *)(lVar4 + 24) <= uVar6) {
                        uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                        FUN_1800d65f0(uVar3,0);
                      }
                      lVar4 = lVar4[uVar6];
                      cVar1 = Object.op_Implicit(lVar4,0);
                      if (cVar1) {
                        if (lVar4 == null) throw; // [null/range check failed]
                        if ((*(int *)(lVar4 + 24) != 3) && (*(char *)(lVar4 + 80) != false))
                        goto LAB_18153f13b;
                      }
                      uVar6 = uVar6 + 1;
                    } while( true );
                  }
                }
              }
            }
          }
        LAB_18153f30d:
          lVar4 = *(int64 *)(pStatics_f678 + 400);
          if (lVar4 != null) {
            puVar5 = (uint64 *)(lVar4 + 72);
            *puVar5 = 0;
            il2cpp_internal(puVar5,0);
            return 0;
          }
        }
        throw; // [null/range check failed]
        LAB_18153f230:
        if (*pStatics_fcf8 == 0) throw; // [null/range check failed]
        if (*(int *)(*pStatics_fcf8 + 24) <= (int)uVar6) goto LAB_18153f30d;
        if ((*pStatics_fcf8 == 0) ||
           (lVar4 = *(int64 *)(*pStatics_fcf8 + 16)) == null)
        throw; // [null/range check failed]
        if (*(uint32 *)(lVar4 + 24) <= uVar6) {
          uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
          FUN_1800d65f0(uVar3,0);
        }
        lVar4 = lVar4[uVar6];
        cVar1 = Object.op_Implicit(lVar4,0);
        if (cVar1) {
          if (lVar4 == null) throw; // [null/range check failed]
          if (*(int *)(lVar4 + 24) != 3) goto LAB_18153f13b;
        }
        uVar6 = uVar6 + 1;
        goto LAB_18153f230;
        LAB_18153f13b:
        uVar3 = Component.get_gameObject(lVar4,0);
        UICamera.set_hoveredObject(uVar3,0);
        lVar4 = *(int64 *)(pStatics_f678 + 400);
        if (lVar4 != null) {
          *(uint64 *)(lVar4 + 72) = *(uint64 *)(pStatics_f678 + 0x1e0);
          return *(uint64 *)(pStatics_f678 + 0x1e0);
        }
    }

    // Token : 0x600070E
    // RVA   : 0x15414F0   Offset: 0x15408F0   Length: 0x299
    public static void set_controllerNavigationObject(GameObject value)
    {
        var pStatics = *(int64*)(DAT_181daf678 + 184);
        long lVar1;
        ulong uVar2;
        long lVar3;
        bool cVar4;
        ulong uVar5;
        byte[] local_res18 = new byte[16];
        lVar1 = *(int64 *)(pStatics + 400);
        if (lVar1 != null) {
          uVar2 = *(uint64 *)(lVar1 + 72);
          cVar4 = Object.op_Inequality(uVar2,value,0);
          if (cVar4) {
            lVar1 = *(int64 *)(pStatics + 400);
            if (lVar1 == null) throw; // [null/range check failed]
            uVar2 = *(uint64 *)(lVar1 + 72);
            cVar4 = Object.op_Implicit(uVar2,0);
            if (cVar4) {
              lVar1 = *(int64 *)(pStatics + 400);
              if (lVar1 == null) {
                          // WARNING: Subroutine does not return
                FUN_1800d6620();
              }
              uVar2 = *(uint64 *)(lVar1 + 72);
              local_res18[0] = 0;
              uVar5 = il2cpp_value_box(DAT_181db2ac8,local_res18);
              UICamera.Notify(uVar2,"OnHover",uVar5,0);
              if (*(int64 *)(pStatics + 0x110) != 0) {
                lVar1 = *(int64 *)(pStatics + 400);
                lVar3 = *(int64 *)(pStatics + 0x110);
                if ((lVar1 == null) || (lVar3 == null)) throw; // [null/range check failed]
                OnTooltipCB.Invoke(lVar3,*(uint64 *)(lVar1 + 72),0,0);
              }
              lVar1 = *(int64 *)(pStatics + 400);
              if (lVar1 == null) throw; // [null/range check failed]
              puVar6 = (uint64 *)(lVar1 + 72);
              *puVar6 = 0;
              il2cpp_internal(puVar6,0);
            }
          }
          UICamera.set_hoveredObject(value,0);
          return;
        }
    }

    // Token : 0x600070F
    // RVA   : 0x1540E90   Offset: 0x1540290   Length: 0x16B
    public static GameObject get_selectedObject()
    {
        var pStatics = *(int64*)(DAT_181daf678 + 184);
        ulong uVar1;
        long lVar2;
        bool cVar3;
        uVar1 = *(uint64 *)(pStatics + 0x1e8);
        cVar3 = Object.op_Implicit(uVar1,0);
        if (cVar3) {
          lVar2 = *(int64 *)(pStatics + 0x1e8);
          if (lVar2 == null) {
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          cVar3 = GameObject.get_activeInHierarchy(lVar2,0);
          if (cVar3) {
            return *(uint64 *)(pStatics + 0x1e8);
          }
        }
        puVar4 = (uint64 *)(pStatics + 0x1e8);
        *puVar4 = 0;
        il2cpp_internal(puVar4,0);
        return 0;
    }

    // Token : 0x6000710
    // RVA   : 0x1542760   Offset: 0x1541B60   Length: 0x997
    public static void set_selectedObject(GameObject value)
    {
        var pStatics = *(int64*)(DAT_181daf678 + 184);
        long lVar1;
        bool cVar2;
        byte uVar4;
        uint uVar5;
        ulong uVar6;
        ulong uVar7;
        long lVar8;
        byte[] local_res8 = new byte[8];
        uVar7 = *(uint64 *)(pStatics + 0x1e8);
        cVar2 = Object.op_Equality(uVar7,value,0);
        if (!cVar2) {
          UICamera.ShowTooltip(0,0);
          bVar11 = 0;
          lVar1 = *(int64 *)(pStatics + 184);
          if (*(int64 *)(pStatics + 224) == 0) {
            bVar11 = 1;
            *(uint32 *)(pStatics + 212) = 0xffffff9c;
            *(uint64 *)(pStatics + 224) =
                 *(uint64 *)(pStatics + 400);
            il2cpp_internal();
          }
          *(uint8 *)(pStatics + 232) = 0;
          uVar7 = *(uint64 *)(pStatics + 0x1e8);
          cVar2 = Object.op_Implicit(uVar7,0);
          if (cVar2) {
            uVar7 = *(uint64 *)(pStatics + 0x1e8);
            local_res8[0] = 0;
            uVar6 = il2cpp_value_box(DAT_181db2ac8,local_res8);
            UICamera.Notify(uVar7,"OnSelect",uVar6,0);
            if (*(int64 *)(pStatics + 0x120) != 0) {
              lVar8 = *(int64 *)(pStatics + 0x120);
              if (lVar8 == null) goto LAB_1815430e2;
              OnTooltipCB.Invoke(lVar8,*(uint64 *)(pStatics + 0x1e8),0,0);
            }
          }
          plVar9 = (int64 *)(pStatics + 0x1e8);
          *plVar9 = value;
          il2cpp_internal(plVar9,value);
          lVar8 = *(int64 *)(pStatics + 224);
          if (lVar8 == null) {
        LAB_1815430e2:
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          *(uint32 *)(lVar8 + 112) = 0;
          cVar2 = Object.op_Inequality(value,0,0);
          if (cVar2) {
            if (value == null) goto LAB_1815430e2;
            uVar7 = GameObject.GetComponent(value,DAT_181d74a10);
            cVar2 = Object.op_Inequality(uVar7,0,0);
            if (cVar2) {
              lVar8 = *(int64 *)(pStatics + 400);
              if (lVar8 == null) goto LAB_1815430e2;
              plVar9 = (int64 *)(lVar8 + 72);
              *plVar9 = value;
              il2cpp_internal(plVar9,value);
            }
          }
          uVar7 = *(uint64 *)(pStatics + 0x1e8);
          bVar3 = Object.op_Implicit(uVar7,0);
          if ((bVar11 & bVar3) != 0) {
            uVar7 = *(uint64 *)(pStatics + 0x1e8);
            cVar2 = Object.op_Inequality(uVar7,0,0);
            if (!cVar2) {
              if ((*pStatics == 0) ||
                 (lVar8 = *(int64 *)(*pStatics + 16)) == null)
              goto LAB_1815430e2;
              if (*(int *)(lVar8 + 24) == 0) {
                uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar7,0);
              }
              lVar8 = *(int64 *)(lVar8 + 32);
            }
            else {
              lVar8 = *(int64 *)(pStatics + 0x1e8);
              if (lVar8 == null) goto LAB_1815430e2;
              uVar5 = GameObject.get_layer(lVar8,0);
              lVar8 = UICamera.FindCameraForLayer(uVar5,0);
            }
            cVar2 = Object.op_Inequality(lVar8,0,0);
            if (cVar2) {
              plVar9 = (int64 *)(pStatics + 184);
              *plVar9 = lVar8;
              il2cpp_internal(plVar9,lVar8);
              if (lVar8 == null) goto LAB_1815430e2;
              uVar7 = UICamera.get_cachedCamera(lVar8,0);
              puVar10 = (uint64 *)(pStatics + 192);
              *puVar10 = uVar7;
              il2cpp_internal(puVar10,uVar7);
            }
          }
          uVar7 = *(uint64 *)(pStatics + 0x1e8);
          cVar2 = Object.op_Implicit(uVar7,0);
          if (cVar2) {
            lVar8 = *(int64 *)(pStatics + 0x1e8);
            if (lVar8 == null) goto LAB_1815430e2;
            cVar2 = GameObject.get_activeInHierarchy(lVar8,0);
            if (!cVar2) {
              uVar4 = 0;
            }
            else {
              lVar8 = *(int64 *)(pStatics + 0x1e8);
              if (lVar8 == null) goto LAB_1815430e2;
              uVar7 = GameObject.GetComponent(lVar8,DAT_181d74988);
              uVar4 = Object.op_Inequality(uVar7,0,0);
            }
            *(uint8 *)(pStatics + 232) = uVar4;
            if (*(int64 *)(pStatics + 0x120) != 0) {
              lVar8 = *(int64 *)(pStatics + 0x120);
              if (lVar8 == null) goto LAB_1815430e2;
              OnTooltipCB.Invoke(lVar8,*(uint64 *)(pStatics + 0x1e8),1,0);
            }
            uVar7 = *(uint64 *)(pStatics + 0x1e8);
            local_res8[0] = 1;
            uVar6 = il2cpp_value_box(DAT_181db2ac8,local_res8);
            UICamera.Notify(uVar7,"OnSelect",uVar6,0);
          }
          if (bVar11 != 0) {
            plVar9 = (int64 *)(pStatics + 184);
            *plVar9 = lVar1;
            il2cpp_internal(plVar9,lVar1);
            cVar2 = Object.op_Inequality(lVar1,0,0);
            if (!cVar2) {
              uVar7 = 0;
            }
            else {
              if (lVar1 == null) goto LAB_1815430e2;
              uVar7 = UICamera.get_cachedCamera(lVar1,0);
            }
            puVar10 = (uint64 *)(pStatics + 192);
            *puVar10 = uVar7;
            il2cpp_internal(puVar10,uVar7);
            puVar10 = (uint64 *)(pStatics + 224);
            *puVar10 = 0;
            il2cpp_internal(puVar10,0);
            *(uint32 *)(pStatics + 212) = 0xffffff9c;
          }
        }
        else {
          UICamera.set_hoveredObject(value,0);
          lVar1 = *(int64 *)(pStatics + 400);
          if (lVar1 == null) goto LAB_1815430e2;
          plVar9 = (int64 *)(lVar1 + 72);
          *plVar9 = value;
          il2cpp_internal(plVar9,value);
        }
    }

    // Token : 0x6000711
    // RVA   : 0x1534A30   Offset: 0x1533E30   Length: 0x268
    public static bool IsPressed(GameObject go)
    {
        var pStatics = *(int64*)(DAT_181daf678 + 184);
        int iVar1;
        bool cVar2;
        byte uVar3;
        long lVar4;
        ulong uVar5;
        uint uVar6;
        int iVar7;
        iVar7 = 0;
        uVar6 = 0;
        do {
          lVar4 = *(int64 *)(pStatics + 0x188);
          if (lVar4 == null) throw; // [null/range check failed]
          if (*(uint32 *)(lVar4 + 24) <= uVar6) {
            uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar5,0);
          }
          lVar4 = lVar4[uVar6];
          if (lVar4 == null) throw; // [null/range check failed]
          uVar5 = *(uint64 *)(lVar4 + 80);
          cVar2 = Object.op_Equality(uVar5,go,0);
          if (cVar2) goto LAB_181534c7f;
          uVar6 = uVar6 + 1;
        } while ((int)uVar6 < 3);
        lVar4 = *(int64 *)(pStatics + 0x198);
        if (lVar4 != null) {
          iVar1 = *(int *)(lVar4 + 24);
          if (0 < iVar1) {
            do {
              lVar4 = *(int64 *)(pStatics + 0x198);
              if (lVar4 == null) throw; // [null/range check failed]
              lVar4 = FUN_180002f80(lVar4,iVar7,DAT_181db41d8);
              if (lVar4 == null) throw; // [null/range check failed]
              uVar5 = *(uint64 *)(lVar4 + 80);
              cVar2 = Object.op_Equality(uVar5,go,0);
              if (cVar2) goto LAB_181534c7f;
              iVar7 = iVar7 + 1;
            } while (iVar7 < iVar1);
          }
          lVar4 = *(int64 *)(pStatics + 400);
          if (lVar4 != null) {
            uVar5 = *(uint64 *)(lVar4 + 80);
            cVar2 = Object.op_Equality(uVar5,go,0);
            uVar3 = 0;
            if (cVar2) {
        LAB_181534c7f:
              uVar3 = 1;
            }
            return uVar3;
          }
        }
    }

    // Token : 0x6000712
    // RVA   : 0x1541060   Offset: 0x1540460   Length: 0x49
    public static int get_touchCount()
    {
        UICamera.CountInputSources(0);
    }

    // Token : 0x6000713
    // RVA   : 0x1533A90   Offset: 0x1532E90   Length: 0x2A7
    public static int CountInputSources()
    {
        var pStatics = *(int64*)(DAT_181daf678 + 184);
        int iVar1;
        bool cVar2;
        long lVar3;
        ulong uVar4;
        uint uVar5;
        int iVar6;
        int iVar7;
        iVar7 = 0;
        iVar6 = 0;
        lVar3 = *(int64 *)(pStatics + 0x198);
        if (lVar3 != null) {
          iVar1 = *(int *)(lVar3 + 24);
          uVar5 = 0;
          if (0 < iVar1) {
            do {
              lVar3 = *(int64 *)(pStatics + 0x198);
              if ((lVar3 == null) || (lVar3 = FUN_180002f80(lVar3,iVar6,DAT_181db41d8)) == null)
              throw; // [null/range check failed]
              uVar4 = *(uint64 *)(lVar3 + 80);
              cVar2 = Object.op_Inequality(uVar4,0,0);
              if (cVar2) {
                iVar7 = iVar7 + 1;
              }
              iVar6 = iVar6 + 1;
              uVar5 = 0;
            } while (iVar6 < iVar1);
          }
          while( true ) {
            lVar3 = *(int64 *)(pStatics + 0x188);
            if (lVar3 == null) throw; // [null/range check failed]
            if (*(int *)(lVar3 + 24) <= (int)uVar5) break;
            lVar3 = *(int64 *)(pStatics + 0x188);
            if (lVar3 == null) throw; // [null/range check failed]
            if (*(uint32 *)(lVar3 + 24) <= uVar5) {
              uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar4,0);
            }
            lVar3 = lVar3[uVar5];
            if (lVar3 == null) throw; // [null/range check failed]
            uVar4 = *(uint64 *)(lVar3 + 80);
            cVar2 = Object.op_Inequality(uVar4,0,0);
            if (cVar2) {
              iVar7 = iVar7 + 1;
            }
            uVar5 = uVar5 + 1;
          }
          lVar3 = *(int64 *)(pStatics + 400);
          if (lVar3 != null) {
            uVar4 = *(uint64 *)(lVar3 + 80);
            cVar2 = Object.op_Inequality(uVar4,0,0);
            if (cVar2) {
              iVar7 = iVar7 + 1;
            }
            return iVar7;
          }
        }
    }

    // Token : 0x6000714
    // RVA   : 0x153F8A0   Offset: 0x153ECA0   Length: 0x2A7
    public static int get_dragCount()
    {
        var pStatics = *(int64*)(DAT_181daf678 + 184);
        int iVar1;
        bool cVar2;
        long lVar3;
        ulong uVar4;
        uint uVar5;
        int iVar6;
        int iVar7;
        iVar7 = 0;
        iVar6 = 0;
        lVar3 = *(int64 *)(pStatics + 0x198);
        if (lVar3 != null) {
          iVar1 = *(int *)(lVar3 + 24);
          uVar5 = 0;
          if (0 < iVar1) {
            do {
              lVar3 = *(int64 *)(pStatics + 0x198);
              if ((lVar3 == null) || (lVar3 = FUN_180002f80(lVar3,iVar6,DAT_181db41d8)) == null)
              throw; // [null/range check failed]
              uVar4 = *(uint64 *)(lVar3 + 88);
              cVar2 = Object.op_Inequality(uVar4,0,0);
              if (cVar2) {
                iVar7 = iVar7 + 1;
              }
              iVar6 = iVar6 + 1;
              uVar5 = 0;
            } while (iVar6 < iVar1);
          }
          while( true ) {
            lVar3 = *(int64 *)(pStatics + 0x188);
            if (lVar3 == null) throw; // [null/range check failed]
            if (*(int *)(lVar3 + 24) <= (int)uVar5) break;
            lVar3 = *(int64 *)(pStatics + 0x188);
            if (lVar3 == null) throw; // [null/range check failed]
            if (*(uint32 *)(lVar3 + 24) <= uVar5) {
              uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar4,0);
            }
            lVar3 = lVar3[uVar5];
            if (lVar3 == null) throw; // [null/range check failed]
            uVar4 = *(uint64 *)(lVar3 + 88);
            cVar2 = Object.op_Inequality(uVar4,0,0);
            if (cVar2) {
              iVar7 = iVar7 + 1;
            }
            uVar5 = uVar5 + 1;
          }
          lVar3 = *(int64 *)(pStatics + 400);
          if (lVar3 != null) {
            uVar4 = *(uint64 *)(lVar3 + 88);
            cVar2 = Object.op_Inequality(uVar4,0,0);
            if (cVar2) {
              iVar7 = iVar7 + 1;
            }
            return iVar7;
          }
        }
    }

    // Token : 0x6000715
    // RVA   : 0x1540C60   Offset: 0x1540060   Length: 0xA6
    public static Camera get_mainCamera()
    {
        bool cVar1;
        long lVar2;
        ulong uVar3;
        lVar2 = UICamera.get_eventHandler(0);
        cVar1 = Object.op_Inequality(lVar2,0,0);
        if (cVar1) {
          if (lVar2 != null) {
            uVar3 = UICamera.get_cachedCamera(lVar2,0);
            return uVar3;
          }
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
        return 0;
    }

    // Token : 0x6000716
    // RVA   : 0x153FB50   Offset: 0x153EF50   Length: 0x19C
    public static UICamera get_eventHandler()
    {
        var pStatics = *(int64*)(DAT_181daf678 + 184);
        long lVar1;
        bool cVar2;
        ulong uVar3;
        uint uVar4;
        uVar4 = 0;
        while( true ) {
          if (*pStatics == 0) break;
          if (*(int *)(*pStatics + 24) <= (int)uVar4) {
            return 0;
          }
          if ((*pStatics == 0) ||
             (lVar1 = *(int64 *)(*pStatics + 16)) == null) break;
          if (*(uint32 *)(lVar1 + 24) <= uVar4) {
            uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar3,0);
          }
          lVar1 = lVar1[uVar4];
          cVar2 = Object.op_Equality(lVar1,0,0);
          if (!cVar2) {
            if (lVar1 == null) break;
            cVar2 = Behaviour.get_enabled(lVar1,0);
            if (cVar2) {
              uVar3 = Component.get_gameObject(lVar1,0);
              cVar2 = NGUITools.GetActive(uVar3,0);
              if (cVar2) {
                return lVar1;
              }
            }
          }
          uVar4 = uVar4 + 1;
        }
    }

    // Token : 0x6000717
    // RVA   : 0x15339C0   Offset: 0x1532DC0   Length: 0xCB
    private static int CompareFunc(UICamera a, UICamera b)
    {
        long lVar1;
        float fVar2;
        float fVar3;
        if (a != null) {
          lVar1 = UICamera.get_cachedCamera(a,0);
          if (lVar1 != null) {
            fVar2 = (float)Camera.get_depth(lVar1,0);
            if (b != null) {
              lVar1 = UICamera.get_cachedCamera(b,0);
              if (lVar1 != null) {
                fVar3 = (float)Camera.get_depth(lVar1,0);
                if (fVar2 < fVar3) {
                  return 1;
                }
                lVar1 = UICamera.get_cachedCamera(a,0);
                if (lVar1 != null) {
                  fVar2 = (float)Camera.get_depth(lVar1,0);
                  lVar1 = UICamera.get_cachedCamera(b,0);
                  if (lVar1 != null) {
                    fVar3 = (float)Camera.get_depth(lVar1,0);
                    return (fVar2 <= fVar3) - 1;
                  }
                }
              }
            }
          }
        }
    }

    // Token : 0x6000718
    // RVA   : 0x1534000   Offset: 0x1533400   Length: 0x140
    private static Rigidbody FindRootRigidbody(Transform trans)
    {
        bool cVar1;
        ulong uVar2;
        while( true ) {
          cVar1 = Object.op_Inequality(trans,0,0);
          if (!cVar1) {
            return 0;
          }
          if (trans == null) {
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          uVar2 = Component.GetComponent(trans,DAT_181d96b60);
          cVar1 = Object.op_Inequality(uVar2,0,0);
          if (cVar1) break;
          uVar2 = Component.GetComponent(trans);
          cVar1 = Object.op_Inequality(uVar2,0,0);
          if (cVar1) {
            return uVar2;
          }
          trans = FUN_180da9a20(trans);
        }
        return 0;
    }

    // Token : 0x6000719
    // RVA   : 0x1533EB0   Offset: 0x15332B0   Length: 0x140
    private static Rigidbody2D FindRootRigidbody2D(Transform trans)
    {
        bool cVar1;
        ulong uVar2;
        while( true ) {
          cVar1 = Object.op_Inequality(trans,0,0);
          if (!cVar1) {
            return 0;
          }
          if (trans == null) {
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          uVar2 = Component.GetComponent(trans,DAT_181d96b60);
          cVar1 = Object.op_Inequality(uVar2,0,0);
          if (cVar1) break;
          uVar2 = Component.GetComponent(trans);
          cVar1 = Object.op_Inequality(uVar2,0,0);
          if (cVar1) {
            return uVar2;
          }
          trans = FUN_180da9a20(trans);
        }
        return 0;
    }

    // Token : 0x600071A
    // RVA   : 0x153B4D0   Offset: 0x153A8D0   Length: 0x214
    public static void Raycast(MouseOrTouch touch)
    {
        var pStatics_d1b8 = *(int64*)(DAT_181d8d1b8 + 184);
        var pStatics_f678 = *(int64*)(DAT_181daf678 + 184);
        long lVar1;
        ulong uVar2;
        bool cVar3;
        int iVar4;
        uint uVar5;
        uint uVar6;
        uint uVar7;
        ulong uVar8;
        long lVar9;
        long lVar10;
        ulong uVar11;
        long lVar12;
        uint uVar15;
        float fVar16;
        float fVar17;
        float[] local_res18 = new float[2];
        uint local_res20;
        uint uStackX_24;
        ulong local_368;
        ulong uStack_360;
        ulong local_358;
        uint local_350;
        uint32 uStack_34c;
        uint64 local_348;
        uint32 local_340;
        uint64 local_328;
        uint32 local_320;
        uint64 local_318;
        uint64 local_308;
        uint32 local_300;
        uint64 local_2f8;
        uint32 local_2f0;
        uint64 local_2e8;
        uint32 local_2e0;
        uint64 local_2d8;
        uint32 local_2d0;
        uint64 local_2c8;
        uint32 local_2c0;
        uint64 local_2b8;
        uint32 local_2b0;
        uint64 local_2a8;
        uint32 local_2a0;
        uint8 local_298 [16];
        uint32 local_288;
        uint32 uStack_284;
        uint32 uStack_280;
        uint32 uStack_27c;
        uint64 local_278;
        uint32 local_268;
        uint32 uStack_264;
        uint32 uStack_260;
        uint32 uStack_25c;
        uint64 local_258;
        uint64 local_248;
        uint64 uStack_240;
        uint64 local_238;
        uint64 local_228;
        uint64 uStack_220;
        uint64 local_218;
        uint8 local_208 [16];
        uint8 local_1f8 [16];
        uint8 local_1e8 [16];
        uint8 local_1d8 [16];
        uint8 local_1c8 [16];
        uint8 local_1b8 [16];
        uint64 local_1a8;
        uint64 uStack_1a0;
        uint64 local_198;
        uint64 uStack_190;
        uint64 local_188;
        uint64 uStack_180;
        uint64 local_178;
        uint64 uStack_170;
        uint64 local_168;
        uint64 local_158;
        uint64 uStack_150;
        uint64 local_148;
        uint64 uStack_140;
        uint64 local_138;
        uint64 uStack_130;
        uint64 local_128;
        uint64 uStack_120;
        uint64 local_118;
        uint8 local_c8 [144];
        uVar15 = 0;
        local_368 = 0;
        uStack_360 = 0;
        local_358 = 0;
        local_res18[0] = 0.0;
        LAB_18153b860:
        do {
          if (*pStatics_f678 == 0) goto LAB_18153d637;
          if (*(int *)(*pStatics_f678 + 24) <= (int)uVar15) {
            return 0;
          }
          if ((*pStatics_f678 == 0) ||
             (lVar9 = *(int64 *)(*pStatics_f678 + 16)) == null)
          goto LAB_18153d637;
          if (*(uint32 *)(lVar9 + 24) <= uVar15) {
            uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar8,0);
          }
          lVar9 = lVar9[uVar15];
          if (lVar9 == null) goto LAB_18153d637;
          cVar3 = Behaviour.get_enabled(lVar9,0);
          if (cVar3) {
            uVar8 = Component.get_gameObject(lVar9,0);
            cVar3 = NGUITools.GetActive(uVar8,0);
            if (!cVar3) goto LAB_18153d179;
            uVar8 = UICamera.get_cachedCamera(lVar9,0);
            puVar13 = (uint64 *)(pStatics_f678 + 192);
            *puVar13 = uVar8;
            il2cpp_internal(puVar13,uVar8);
            lVar10 = *(int64 *)(pStatics_f678 + 192);
            if (lVar10 == null) goto LAB_18153d637;
            iVar4 = Camera.get_targetDisplay(lVar10,0);
            if (iVar4 != 0) goto LAB_18153d179;
            lVar10 = *(int64 *)(pStatics_f678 + 192);
            if (lVar10 == null) goto LAB_18153d637;
            local_328 = *touch;
            local_320 = *(uint32 *)(touch + 1);
            puVar13 = (uint64 *)Camera.ScreenToViewportPoint(local_208,lVar10,&local_328,0);
            local_318 = *puVar13;
            fVar16 = (float)local_318;
            cVar3 = Single.IsNaN(fVar16,0);
            if (cVar3) goto LAB_18153d179;
            fVar17 = local_318._4_4_;
            cVar3 = Single.IsNaN(local_318._4_4_,0);
            if ((((cVar3) || (fVar16 < 0.0)) || (1.0 < fVar16)) ||
               ((fVar17 < 0.0 || (1.0 < fVar17)))) goto LAB_18153d179;
            lVar10 = *(int64 *)(pStatics_f678 + 192);
            if (lVar10 == null) goto LAB_18153d637;
            local_308 = *touch;
            local_300 = *(uint32 *)(touch + 1);
            puVar13 = (uint64 *)Camera.ScreenPointToRay(&local_348,lVar10,&local_308);
            local_368 = *puVar13;
            uStack_360 = puVar13[1];
            local_358 = puVar13[2];
            lVar10 = *(int64 *)(pStatics_f678 + 192);
            if (lVar10 == null) goto LAB_18153d637;
            uVar5 = Camera.get_cullingMask(lVar10,0);
            uVar6 = LayerMask.op_Implicit(*(uint32 *)(lVar9 + 32),0);
            fVar16 = *(float *)(lVar9 + 72);
            uVar6 = uVar6 & uVar5;
            if (fVar16 <= 0.0) {
              lVar10 = *(int64 *)(pStatics_f678 + 192);
              if (lVar10 == null) goto LAB_18153d637;
              fVar16 = (float)Camera.get_farClipPlane(lVar10,0);
              lVar10 = *(int64 *)(pStatics_f678 + 192);
              if (lVar10 == null) goto LAB_18153d637;
              fVar17 = (float)Camera.get_nearClipPlane(lVar10,0);
              fVar16 = fVar16 - fVar17;
            }
            uVar2 = local_358;
            uVar11 = uStack_360;
            uVar8 = local_368;
            iVar4 = *(int *)(lVar9 + 24);
            local_res18[0] = fVar16;
            if (iVar4 == 0) {
              lVar10 = pStatics_f678;
              *(uint64 *)(lVar10 + 112) = uVar8;
              *(uint64 *)(lVar10 + 120) = uVar11;
              *(uint64 *)(lVar10 + 128) = uVar2;
              local_228 = local_368;
              uStack_220 = uStack_360;
              local_218 = local_358;
              cVar3 = Physics.Raycast(&local_228,pStatics_f678 + 136,
                                       local_res18[0],uVar6,1,0);
              if (!cVar3) goto LAB_18153d179;
              puVar13 = (uint64 *)
                        FUN_18045e0a0(local_298,pStatics_f678 + 136,0);
              lVar10 = pStatics_f678;
              *(uint64 *)(lVar10 + 100) = *puVar13;
              *(uint32 *)(lVar10 + 108) = *(uint32 *)(puVar13 + 1);
              lVar10 = RaycastHit.get_collider(pStatics_f678 + 136,0);
              if (lVar10 != null) {
                uVar8 = Component.get_gameObject(lVar10,0);
                puVar13 = (uint64 *)(pStatics_f678 + 0x1d8);
                *puVar13 = uVar8;
                il2cpp_internal(puVar13,uVar8);
                if (*(char *)(lVar9 + 28) != false) {
                  return 1;
                }
                lVar9 = *(int64 *)(pStatics_f678 + 0x1d8);
                if ((lVar9 != null) && (lVar9 = FUN_180f92a00(lVar9,0)) != null) {
                  lVar9 = FUN_1809674e0(lVar9,DAT_181d74ed8);
        LAB_18153d5a5:
                  cVar3 = Object.op_Inequality(lVar9,0,0);
                  if (!cVar3) {
                    return 1;
                  }
                  if (lVar9 != null) {
                    uVar8 = Component.get_gameObject(lVar9,0);
                    puVar13 = (uint64 *)(pStatics_f678 + 0x1d8);
                    *puVar13 = uVar8;
                    il2cpp_internal(puVar13,uVar8);
                    return 1;
                  }
                }
              }
        LAB_18153d637:
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            if (iVar4 == 1) {
              if (*(int64 *)(pStatics_f678 + 0x240) == 0) {
                uVar8 = FUN_1800d60b0(DAT_181da4820,50);
                puVar13 = (uint64 *)(pStatics_f678 + 0x240);
                *puVar13 = uVar8;
                il2cpp_internal(puVar13,uVar8);
              }
              uVar2 = local_358;
              uVar11 = uStack_360;
              uVar8 = local_368;
              local_248 = uVar8;
              uStack_240 = uVar11;
              local_238 = uVar2;
              iVar4 = Physics.RaycastNonAlloc
                                (&local_248,*(uint64 *)(pStatics_f678 + 0x240),
                                 local_res18[0],uVar6,2,0);
              if (1 < iVar4) {
                uVar5 = 0;
        LAB_18153ca86:
                lVar9 = *(int64 *)(pStatics_f678 + 0x240);
                if (lVar9 == null) goto LAB_18153d637;
                if (*(uint32 *)(lVar9 + 24) <= uVar5) {
                  uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1800d65f0(uVar8,0);
                }
                lVar10 = (int64)(int)uVar5 * 44;
                lVar9 = RaycastHit.get_collider(lVar9 + 32 + lVar10,0);
                if ((lVar9 == null) || (lVar9 = Component.get_gameObject(lVar9,0)) == null)
                goto LAB_18153d637;
                plVar14 = (int64 *)GameObject.GetComponent(lVar9);
                cVar3 = Object.op_Inequality(plVar14,0,0);
                if (!cVar3) {
                  lVar12 = NGUITools.FindInParents(lVar9);
                  cVar3 = Object.op_Inequality(lVar12,0,0);
                  if (cVar3) {
                    if (lVar12 != null) {
                      if (*(float *)(lVar12 + 140) <= 0.001 && *(float *)(lVar12 + 140) != 0.001)
                      goto LAB_18153ceeb;
                      goto LAB_18153ccc0;
                    }
                    goto LAB_18153d637;
                  }
                }
                else {
                  if (plVar14 == (int64 *)0) goto LAB_18153d637;
                  cVar3 = UIWidget.get_isVisible(plVar14);
                  if (!cVar3) goto LAB_18153ceeb;
                  if (((*(byte *)(DAT_181db0378 + 300) <= *(byte *)(*plVar14 + 300)) &&
                      (*(int64 *)
                        (*(int64 *)(*plVar14 + 200) + -8 +
                        (uint64)*(byte *)(DAT_181db0378 + 300) * 8) == DAT_181db0378)) &&
                     (lVar12 = UISpriteCollection.GetCurrentSprite(local_c8),
                     (char)*(uint64 *)(lVar12 + 56) == false)) goto LAB_18153ceeb;
                  lVar12 = plVar14[28];
                  if (lVar12 != null) {
                    lVar1 = *(int64 *)(pStatics_f678 + 0x240);
                    if (lVar1 == null) goto LAB_18153d637;
                    if (*(uint32 *)(lVar1 + 24) <= uVar5) {
                      uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                      FUN_1800d65f0(uVar8,0);
                    }
                    puVar13 = (uint64 *)FUN_18045e0a0(local_1b8,lVar1 + 32 + lVar10);
                    local_2a8 = *puVar13;
                    local_2a0 = *(uint32 *)(puVar13 + 1);
                    cVar3 = HitCheck.Invoke(lVar12);
                    if (!cVar3) goto LAB_18153ceeb;
                  }
                }
        LAB_18153ccc0:
                uVar7 = NGUITools.CalculateRaycastDepth(lVar9,0);
                *(uint32 *)(pStatics_f678 + 0x1f0) = uVar7;
                if (*(int *)(pStatics_f678 + 0x1f0) != 0x7fffffff) {
                  lVar9 = pStatics_f678;
                  lVar12 = *(int64 *)(lVar9 + 0x240);
                  if (lVar12 == null) goto LAB_18153d637;
                  if (*(uint32 *)(lVar12 + 24) <= uVar5) {
                    uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                    FUN_1800d65f0(uVar8,0);
                  }
                  puVar13 = (uint64 *)(lVar10 + 32 + lVar12);
                  uVar8 = puVar13[1];
                  *(uint64 *)(lVar9 + 500) = *puVar13;
                  *(uint64 *)(lVar9 + 0x1fc) = uVar8;
                  puVar13 = (uint64 *)(lVar10 + 48 + lVar12);
                  uVar8 = puVar13[1];
                  *(uint64 *)(lVar9 + 0x204) = *puVar13;
                  *(uint64 *)(lVar9 + 0x20c) = uVar8;
                  *(uint64 *)(lVar9 + 0x214) = *(uint64 *)(lVar10 + 64 + lVar12);
                  *(uint32 *)(lVar9 + 0x21c) = *(uint32 *)(lVar10 + 72 + lVar12);
                  lVar9 = *(int64 *)(pStatics_f678 + 0x240);
                  if (lVar9 == null) goto LAB_18153d637;
                  if (*(uint32 *)(lVar9 + 24) <= uVar5) {
                    uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                    FUN_1800d65f0(uVar8,0);
                  }
                  puVar13 = (uint64 *)FUN_18045e0a0(local_298,lVar9 + 32 + lVar10,0);
                  lVar9 = pStatics_f678;
                  *(uint64 *)(lVar9 + 0x220) = *puVar13;
                  *(uint32 *)(lVar9 + 0x228) = *(uint32 *)(puVar13 + 1);
                  lVar9 = *(int64 *)(pStatics_f678 + 0x240);
                  if (lVar9 == null) goto LAB_18153d637;
                  if (*(uint32 *)(lVar9 + 24) <= uVar5) {
                    uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                    FUN_1800d65f0(uVar8,0);
                  }
                  lVar9 = RaycastHit.get_collider(lVar9 + 32 + lVar10,0);
                  if (lVar9 == null) goto LAB_18153d637;
                  uVar8 = Component.get_gameObject(lVar9,0);
                  puVar13 = (uint64 *)(pStatics_f678 + 0x230);
                  *puVar13 = uVar8;
                  il2cpp_internal(puVar13,uVar8);
                  lVar9 = pStatics_f678;
                  if (*(int64 *)(lVar9 + 0x238) == 0) goto LAB_18153d637;
                  local_158 = *(uint64 *)(lVar9 + 0x1f0);
                  uStack_150 = *(uint64 *)(lVar9 + 0x1f8);
                  local_148 = *(uint64 *)(lVar9 + 0x200);
                  uStack_140 = *(uint64 *)(lVar9 + 0x208);
                  local_138 = *(uint64 *)(lVar9 + 0x210);
                  uStack_130 = *(uint64 *)(lVar9 + 0x218);
                  local_128 = *(uint64 *)(lVar9 + 0x220);
                  uStack_120 = *(uint64 *)(lVar9 + 0x228);
                  local_118 = *(uint64 *)(lVar9 + 0x230);
                  FUN_181583da0();
                }
        LAB_18153ceeb:
                uVar5 = uVar5 + 1;
                if (iVar4 <= (int)uVar5) break;
                goto LAB_18153ca86;
              }
              if (iVar4 == 1) {
                lVar9 = *(int64 *)(pStatics_f678 + 0x240);
                if (lVar9 != null) {
                  if (*(int *)(lVar9 + 24) == 0) {
                    uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                    FUN_1800d65f0(uVar8,0);
                  }
                  lVar9 = RaycastHit.get_collider(lVar9 + 32,0);
                  if ((lVar9 != null) && (lVar9 = Component.get_gameObject(lVar9,0)) != null) {
                    lVar10 = GameObject.GetComponent(lVar9,DAT_181d74c30);
                    cVar3 = Object.op_Inequality(lVar10,0,0);
                    if (!cVar3) {
                      lVar9 = NGUITools.FindInParents(lVar9,DAT_181d8f720);
                      cVar3 = Object.op_Inequality(lVar9,0,0);
                      if (cVar3) {
                        if (lVar9 == null) goto LAB_18153d637;
                        if (*(float *)(lVar9 + 140) <= 0.001 && *(float *)(lVar9 + 140) != 0.001)
                        goto LAB_18153d179;
                      }
                    }
                    else {
                      if (lVar10 == null) goto LAB_18153d637;
                      cVar3 = UIWidget.get_isVisible(lVar10,0);
                      if (!cVar3) goto LAB_18153d179;
                      lVar9 = *(int64 *)(lVar10 + 224);
                      if (lVar9 != null) {
                        lVar10 = *(int64 *)(pStatics_f678 + 0x240);
                        if (lVar10 == null) goto LAB_18153d637;
                        if (*(int *)(lVar10 + 24) == 0) {
                          uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                          FUN_1800d65f0(uVar8,0);
                        }
                        puVar13 = (uint64 *)FUN_18045e0a0(local_1d8,lVar10 + 32,0);
                        local_2c8 = *puVar13;
                        local_2c0 = *(uint32 *)(puVar13 + 1);
                        cVar3 = HitCheck.Invoke(lVar9,&local_2c8,0);
                        if (!cVar3) goto LAB_18153d179;
                      }
                    }
                    lVar9 = *(int64 *)(pStatics_f678 + 0x240);
                    if (lVar9 != null) {
                      if (*(int *)(lVar9 + 24) == 0) {
                        uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                        FUN_1800d65f0(uVar8,0);
                      }
                      puVar13 = (uint64 *)FUN_18045e0a0(local_1c8,lVar9 + 32,0);
                      uVar8 = *puVar13;
                      uVar7 = *(uint32 *)(puVar13 + 1);
                      lVar9 = *(int64 *)(pStatics_f678 + 0x240);
                      if (lVar9 != null) {
                        if (*(int *)(lVar9 + 24) == 0) {
                          uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                          FUN_1800d65f0(uVar8,0);
                        }
                        lVar9 = RaycastHit.get_collider(lVar9 + 32,0);
                        if (lVar9 != null) {
                          uVar11 = Component.get_gameObject(lVar9,0);
                          local_2b8 = uVar8;
                          local_2b0 = uVar7;
                          cVar3 = UICamera.IsVisible(&local_2b8,uVar11,0);
                          if (!cVar3) goto LAB_18153d179;
                          lVar9 = pStatics_f678;
                          lVar10 = *(int64 *)(lVar9 + 0x240);
                          if (lVar10 != null) {
                            if (*(int *)(lVar10 + 24) == 0) {
                              uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                              FUN_1800d65f0(uVar8,0);
                            }
                            uVar8 = *(uint64 *)(lVar10 + 40);
                            *(uint64 *)(lVar9 + 136) = *(uint64 *)(lVar10 + 32);
                            *(uint64 *)(lVar9 + 144) = uVar8;
                            uVar8 = *(uint64 *)(lVar10 + 56);
                            *(uint64 *)(lVar9 + 152) = *(uint64 *)(lVar10 + 48);
                            *(uint64 *)(lVar9 + 160) = uVar8;
                            *(uint64 *)(lVar9 + 168) = *(uint64 *)(lVar10 + 64);
                            *(uint32 *)(lVar9 + 176) = *(uint32 *)(lVar10 + 72);
                            lVar9 = pStatics_f678;
                            *(uint32 *)(lVar9 + 112) = (uint32)local_368;
                            *(uint32 *)(lVar9 + 116) = local_368._4_4_;
                            *(uint32 *)(lVar9 + 120) = (uint32)uStack_360;
                            *(uint32 *)(lVar9 + 124) = uStack_360._4_4_;
                            *(uint64 *)(lVar9 + 128) = local_358;
                            lVar9 = *(int64 *)(pStatics_f678 + 0x240);
                            if (lVar9 != null) {
                              if (*(int *)(lVar9 + 24) == 0) {
                                uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                FUN_1800d65f0(uVar8,0);
                              }
                              puVar13 = (uint64 *)FUN_18045e0a0(local_298,lVar9 + 32,0);
                              lVar9 = pStatics_f678;
                              *(uint64 *)(lVar9 + 100) = *puVar13;
                              *(uint32 *)(lVar9 + 108) = *(uint32 *)(puVar13 + 1);
                              lVar9 = RaycastHit.get_collider
                                                (pStatics_f678 + 136,0);
                              if (lVar9 != null) {
                                uVar8 = Component.get_gameObject(lVar9,0);
                                puVar13 = (uint64 *)(pStatics_f678 + 0x1d8);
                                *puVar13 = uVar8;
                                il2cpp_internal(puVar13,uVar8);
                                return 1;
                              }
                            }
                          }
                        }
                      }
                    }
                  }
                }
                goto LAB_18153d637;
              }
            }
            else if (iVar4 == 2) {
              local_268 = (uint32)local_368;
              uStack_264 = local_368._4_4_;
              uStack_260 = (uint32)uStack_360;
              uStack_25c = uStack_360._4_4_;
              local_258 = local_358;
              cVar3 = Plane.Raycast(pStatics_f678 + 0x250,&local_268,local_res18);
              if (cVar3) {
                puVar13 = (uint64 *)Ray.GetPoint(local_1e8,&local_368,local_res18[0]);
                uVar7 = *(uint32 *)(puVar13 + 1);
                uVar8 = *puVar13;
                local_350 = (uint32)uVar8;
                uStack_34c = (uint32)((uint64)uVar8 >> 32);
                local_348 = uVar8;
                local_340 = uVar7;
                lVar10 = Physics2D.OverlapPoint(CONCAT44(uStack_34c,local_350),uVar6,0);
                cVar3 = Object.op_Implicit(lVar10,0);
                if (!cVar3) goto LAB_18153d179;
                lVar12 = pStatics_f678;
                *(uint64 *)(lVar12 + 100) = uVar8;
                *(uint32 *)(lVar12 + 108) = uVar7;
                if (lVar10 != null) {
                  uVar8 = Component.get_gameObject(lVar10,0);
                  puVar13 = (uint64 *)(pStatics_f678 + 0x1d8);
                  *puVar13 = uVar8;
                  il2cpp_internal(puVar13,uVar8);
                  if (*(char *)(lVar9 + 28) != false) {
                    return 1;
                  }
                  lVar9 = *(int64 *)(pStatics_f678 + 0x1d8);
                  if (lVar9 != null) {
                    uVar8 = GameObject.get_transform(lVar9,0);
                    lVar9 = UICamera.FindRootRigidbody2D(uVar8,0);
                    goto LAB_18153d5a5;
                  }
                }
                goto LAB_18153d637;
              }
            }
            else {
              if (iVar4 != 3) goto LAB_18153d179;
              local_288 = (uint32)local_368;
              uStack_284 = local_368._4_4_;
              uStack_280 = (uint32)uStack_360;
              uStack_27c = uStack_360._4_4_;
              local_278 = local_358;
              cVar3 = Plane.Raycast(pStatics_f678 + 0x250,&local_288,local_res18);
              if (!cVar3) goto LAB_18153d179;
              puVar13 = (uint64 *)Ray.GetPoint(local_1f8,&local_368,local_res18[0]);
              uVar8 = *puVar13;
              uVar7 = *(uint32 *)(puVar13 + 1);
              lVar9 = pStatics_f678;
              *(uint64 *)(lVar9 + 100) = uVar8;
              *(uint32 *)(lVar9 + 108) = uVar7;
              if (*(int64 *)(pStatics_f678 + 0x248) == 0) {
                uVar8 = FUN_1800d60b0(DAT_181da10c0,50);
                puVar13 = (uint64 *)(pStatics_f678 + 0x248);
                *puVar13 = uVar8;
                il2cpp_internal(puVar13,uVar8);
              }
              lVar9 = pStatics_f678;
              local_348 = *(uint64 *)(lVar9 + 100);
              local_res20 = (uint32)local_348;
              uStackX_24 = (uint32)((uint64)local_348 >> 32);
              local_340 = *(uint32 *)(lVar9 + 108);
              uVar8 = *(uint64 *)(lVar9 + 0x248);
              iVar4 = Physics2D.OverlapPointNonAlloc(CONCAT44(uStackX_24,local_res20),uVar8,uVar6);
              if (1 < iVar4) {
                uVar5 = 0;
                do {
                  lVar9 = *(int64 *)(pStatics_f678 + 0x248);
                  if (lVar9 == null) goto LAB_18153d637;
                  if (*(uint32 *)(lVar9 + 24) <= uVar5) {
                    uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                    FUN_1800d65f0(uVar8,0);
                  }
                  lVar9 = lVar9[uVar5];
                  if ((lVar9 == null) || (lVar9 = Component.get_gameObject(lVar9,0)) == null)
                  goto LAB_18153d637;
                  lVar10 = GameObject.GetComponent(lVar9);
                  cVar3 = Object.op_Inequality(lVar10,0,0);
                  if (!cVar3) {
                    lVar10 = NGUITools.FindInParents(lVar9);
                    cVar3 = Object.op_Inequality(lVar10,0,0);
                    if (cVar3) {
                      if (lVar10 == null) goto LAB_18153d637;
                      if (*(float *)(lVar10 + 140) <= 0.001 && *(float *)(lVar10 + 140) != 0.001)
                      goto LAB_18153c2ec;
                    }
        LAB_18153c199:
                    uVar7 = NGUITools.CalculateRaycastDepth(lVar9,0);
                    *(uint32 *)(pStatics_f678 + 0x1f0) = uVar7;
                    if (*(int *)(pStatics_f678 + 0x1f0) != 0x7fffffff) {
                      plVar14 = (int64 *)(pStatics_f678 + 0x230);
                      *plVar14 = lVar9;
                      il2cpp_internal(plVar14,lVar9);
                      lVar9 = pStatics_f678;
                      *(uint64 *)(lVar9 + 0x220) = *(uint64 *)(lVar9 + 100);
                      *(uint32 *)(lVar9 + 0x228) = *(uint32 *)(lVar9 + 108);
                      lVar9 = pStatics_f678;
                      if (*(int64 *)(lVar9 + 0x238) == 0) goto LAB_18153d637;
                      local_1a8 = *(uint64 *)(lVar9 + 0x1f0);
                      uStack_1a0 = *(uint64 *)(lVar9 + 0x1f8);
                      local_198 = *(uint64 *)(lVar9 + 0x200);
                      uStack_190 = *(uint64 *)(lVar9 + 0x208);
                      local_188 = *(uint64 *)(lVar9 + 0x210);
                      uStack_180 = *(uint64 *)(lVar9 + 0x218);
                      local_178 = *(uint64 *)(lVar9 + 0x220);
                      uStack_170 = *(uint64 *)(lVar9 + 0x228);
                      local_168 = *(uint64 *)(lVar9 + 0x230);
                      FUN_181583da0();
                    }
                  }
                  else {
                    if (lVar10 == null) goto LAB_18153d637;
                    cVar3 = UIWidget.get_isVisible(lVar10);
                    if (cVar3) {
                      lVar10 = *(int64 *)(lVar10 + 224);
                      if (lVar10 != null) {
                        local_2d0 = *(uint32 *)(pStatics_f678 + 108);
                        local_2d8 = *(uint64 *)(pStatics_f678 + 100);
                        cVar3 = HitCheck.Invoke(lVar10);
                        if (!cVar3) goto LAB_18153c2ec;
                      }
                      goto LAB_18153c199;
                    }
                  }
        LAB_18153c2ec:
                  uVar5 = uVar5 + 1;
                } while ((int)uVar5 < iVar4);
                lVar9 = *(int64 *)(pStatics_f678 + 0x238);
                lVar10 = *(int64 *)(pStatics_d1b8 + 16);
                if (lVar10 == null) {
                  uVar8 = **(uint64 **)(DAT_181d8d1b8 + 184);
                  lVar10 = new OnTooltipCB(uVar8,DAT_181db79c8);
                  plVar14 = (int64 *)(pStatics_d1b8 + 16);
                  *plVar14 = lVar10;
                  il2cpp_internal(plVar14,lVar10);
                }
                if (lVar9 != null) {
                  FUN_181586930(lVar9,lVar10,DAT_181da7b38);
                  uVar5 = 0;
                  while( true ) {
                    lVar9 = *(int64 *)(pStatics_f678 + 0x238);
                    if (lVar9 == null) goto LAB_18153d637;
                    if (*(int *)(lVar9 + 24) <= (int)uVar5) break;
                    lVar9 = *(int64 *)(pStatics_f678 + 0x238);
                    if ((lVar9 == null) || (lVar9 = *(int64 *)(lVar9 + 16)) == null)
                    goto LAB_18153d637;
                    if (*(uint32 *)(lVar9 + 24) <= uVar5) {
                      uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                      FUN_1800d65f0(uVar8,0);
                    }
                    cVar3 = UICamera.IsVisible(lVar9 + (int64)(int)uVar5 * 72 + 32,0);
                    if (cVar3) {
                      lVar9 = *(int64 *)(pStatics_f678 + 0x238);
                      if ((lVar9 != null) && (lVar9 = *(int64 *)(lVar9 + 16)) != null) {
                        if (*(uint32 *)(lVar9 + 24) <= uVar5) {
                          uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                          FUN_1800d65f0(uVar8,0);
                        }
                        *(uint64 *)(pStatics_f678 + 0x1d8) =
                             *(uint64 *)(lVar9 + 96 + (int64)(int)uVar5 * 72);
                        il2cpp_internal();
        LAB_18153d460:
                        lVar9 = *(int64 *)(pStatics_f678 + 0x238);
                        if (lVar9 != null) {
                          BetterList_1.Clear(lVar9,DAT_181da7ab8);
                          return 1;
                        }
                      }
                      goto LAB_18153d637;
                    }
                    uVar5 = uVar5 + 1;
                  }
                  goto LAB_18153d091;
                }
                goto LAB_18153d637;
              }
              if (iVar4 == 1) {
                lVar9 = *(int64 *)(pStatics_f678 + 0x248);
                if (lVar9 != null) {
                  if (*(int *)(lVar9 + 24) == 0) {
                    uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                    FUN_1800d65f0(uVar8,0);
                  }
                  if ((*(int64 *)(lVar9 + 32) != 0) &&
                     (lVar9 = Component.get_gameObject(*(int64 *)(lVar9 + 32),0)) != null) {
                    lVar10 = GameObject.GetComponent(lVar9,DAT_181d74c30);
                    cVar3 = Object.op_Inequality(lVar10,0,0);
                    if (!cVar3) {
                      lVar10 = NGUITools.FindInParents(lVar9,DAT_181d8f720);
                      cVar3 = Object.op_Inequality(lVar10,0,0);
                      if (cVar3) {
                        if (lVar10 == null) goto LAB_18153d637;
                        if (*(float *)(lVar10 + 140) <= 0.001 && *(float *)(lVar10 + 140) != 0.001)
                        goto LAB_18153d179;
                      }
                    }
                    else {
                      if (lVar10 == null) goto LAB_18153d637;
                      cVar3 = UIWidget.get_isVisible(lVar10,0);
                      if (!cVar3) goto LAB_18153d179;
                      lVar10 = *(int64 *)(lVar10 + 224);
                      if (lVar10 != null) {
                        local_2f0 = *(uint32 *)(pStatics_f678 + 108);
                        local_2f8 = *(uint64 *)(pStatics_f678 + 100);
                        cVar3 = HitCheck.Invoke(lVar10,&local_2f8,0);
                        if (!cVar3) goto LAB_18153d179;
                      }
                    }
                    local_2e8 = *(uint64 *)(pStatics_f678 + 100);
                    local_2e0 = *(uint32 *)(pStatics_f678 + 108);
                    cVar3 = UICamera.IsVisible(&local_2e8,lVar9,0);
                    if (cVar3) {
                      plVar14 = (int64 *)(pStatics_f678 + 0x1d8);
                      *plVar14 = lVar9;
                      il2cpp_internal(plVar14,lVar9);
                      return 1;
                    }
                    goto LAB_18153d179;
                  }
                }
                goto LAB_18153d637;
              }
            }
          }
        LAB_18153d179:
          uVar15 = uVar15 + 1;
        } while( true );
        lVar9 = *(int64 *)(pStatics_f678 + 0x238);
        lVar10 = *(int64 *)(pStatics_d1b8 + 8);
        if (lVar10 == null) {
          uVar8 = **(uint64 **)(DAT_181d8d1b8 + 184);
          lVar10 = new OnTooltipCB(uVar8,DAT_181db7940);
          plVar14 = (int64 *)(pStatics_d1b8 + 8);
          *plVar14 = lVar10;
          il2cpp_internal(plVar14,lVar10);
        }
        if (lVar9 == null) goto LAB_18153d637;
        FUN_181586930(lVar9,lVar10,DAT_181da7b38);
        uVar5 = 0;
        while( true ) {
          lVar9 = *(int64 *)(pStatics_f678 + 0x238);
          if (lVar9 == null) goto LAB_18153d637;
          if (*(int *)(lVar9 + 24) <= (int)uVar5) break;
          lVar9 = *(int64 *)(pStatics_f678 + 0x238);
          if ((lVar9 == null) || (lVar9 = *(int64 *)(lVar9 + 16)) == null) goto LAB_18153d637;
          lVar10 = (int64)(int)uVar5;
          if (*(uint32 *)(lVar9 + 24) <= uVar5) {
            uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar8,0);
          }
          cVar3 = UICamera.IsVisible(lVar9 + lVar10 * 72 + 32,0);
          if (cVar3) {
            lVar9 = pStatics_f678;
            if ((*(int64 *)(lVar9 + 0x238) == 0) ||
               (lVar12 = *(int64 *)(*(int64 *)(lVar9 + 0x238) + 16)) == null)
            goto LAB_18153d637;
            if (*(uint32 *)(lVar12 + 24) <= uVar5) {
              uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar8,0);
            }
            puVar13 = (uint64 *)(lVar12 + 36 + lVar10 * 72);
            uVar8 = puVar13[1];
            *(uint64 *)(lVar9 + 136) = *puVar13;
            *(uint64 *)(lVar9 + 144) = uVar8;
            puVar13 = (uint64 *)(lVar12 + 52 + lVar10 * 72);
            uVar8 = puVar13[1];
            *(uint64 *)(lVar9 + 152) = *puVar13;
            *(uint64 *)(lVar9 + 160) = uVar8;
            *(uint64 *)(lVar9 + 168) = *(uint64 *)(lVar12 + 68 + lVar10 * 72);
            *(uint32 *)(lVar9 + 176) = *(uint32 *)(lVar12 + 76 + lVar10 * 72);
            lVar9 = *(int64 *)(pStatics_f678 + 0x238);
            if ((lVar9 == null) || (lVar9 = *(int64 *)(lVar9 + 16)) == null) goto LAB_18153d637;
            if (*(uint32 *)(lVar9 + 24) <= uVar5) {
              uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar8,0);
            }
            *(uint64 *)(pStatics_f678 + 0x1d8) =
                 *(uint64 *)(lVar9 + 96 + lVar10 * 72);
            il2cpp_internal();
            lVar9 = pStatics_f678;
            *(uint32 *)(lVar9 + 112) = (uint32)local_368;
            *(uint32 *)(lVar9 + 116) = local_368._4_4_;
            *(uint32 *)(lVar9 + 120) = (uint32)uStack_360;
            *(uint32 *)(lVar9 + 124) = uStack_360._4_4_;
            *(uint64 *)(lVar9 + 128) = local_358;
            lVar9 = pStatics_f678;
            if ((*(int64 *)(lVar9 + 0x238) == 0) ||
               (lVar12 = *(int64 *)(*(int64 *)(lVar9 + 0x238) + 16)) == null)
            goto LAB_18153d637;
            if (*(uint32 *)(lVar12 + 24) <= uVar5) {
              uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar8,0);
            }
            *(uint64 *)(lVar9 + 100) = *(uint64 *)(lVar12 + 80 + lVar10 * 72);
            *(uint32 *)(lVar9 + 108) = *(uint32 *)(lVar12 + 88 + lVar10 * 72);
            goto LAB_18153d460;
          }
          uVar5 = uVar5 + 1;
        }
        LAB_18153d091:
        lVar9 = *(int64 *)(pStatics_f678 + 0x238);
        if (lVar9 == null) goto LAB_18153d637;
        BetterList_1.Clear(lVar9,DAT_181da7ab8);
        uVar15 = uVar15 + 1;
        goto LAB_18153b860;
    }

    // Token : 0x600071B
    // RVA   : 0x153B6F0   Offset: 0x153AAF0   Length: 0x208C
    public static bool Raycast(Vector3 inPos)
    {
        var pStatics_d1b8 = *(int64*)(DAT_181d8d1b8 + 184);
        var pStatics_f678 = *(int64*)(DAT_181daf678 + 184);
        long lVar1;
        ulong uVar2;
        bool cVar3;
        int iVar4;
        uint uVar5;
        uint uVar6;
        uint uVar7;
        ulong uVar8;
        long lVar9;
        long lVar10;
        ulong uVar11;
        long lVar12;
        uint uVar15;
        float fVar16;
        float fVar17;
        float[] local_res18 = new float[2];
        uint local_res20;
        uint uStackX_24;
        ulong local_368;
        ulong uStack_360;
        ulong local_358;
        uint local_350;
        uint32 uStack_34c;
        uint64 local_348;
        uint32 local_340;
        uint64 local_328;
        uint32 local_320;
        uint64 local_318;
        uint64 local_308;
        uint32 local_300;
        uint64 local_2f8;
        uint32 local_2f0;
        uint64 local_2e8;
        uint32 local_2e0;
        uint64 local_2d8;
        uint32 local_2d0;
        uint64 local_2c8;
        uint32 local_2c0;
        uint64 local_2b8;
        uint32 local_2b0;
        uint64 local_2a8;
        uint32 local_2a0;
        uint8 local_298 [16];
        uint32 local_288;
        uint32 uStack_284;
        uint32 uStack_280;
        uint32 uStack_27c;
        uint64 local_278;
        uint32 local_268;
        uint32 uStack_264;
        uint32 uStack_260;
        uint32 uStack_25c;
        uint64 local_258;
        uint64 local_248;
        uint64 uStack_240;
        uint64 local_238;
        uint64 local_228;
        uint64 uStack_220;
        uint64 local_218;
        uint8 local_208 [16];
        uint8 local_1f8 [16];
        uint8 local_1e8 [16];
        uint8 local_1d8 [16];
        uint8 local_1c8 [16];
        uint8 local_1b8 [16];
        uint64 local_1a8;
        uint64 uStack_1a0;
        uint64 local_198;
        uint64 uStack_190;
        uint64 local_188;
        uint64 uStack_180;
        uint64 local_178;
        uint64 uStack_170;
        uint64 local_168;
        uint64 local_158;
        uint64 uStack_150;
        uint64 local_148;
        uint64 uStack_140;
        uint64 local_138;
        uint64 uStack_130;
        uint64 local_128;
        uint64 uStack_120;
        uint64 local_118;
        uint8 local_c8 [144];
        uVar15 = 0;
        local_368 = 0;
        uStack_360 = 0;
        local_358 = 0;
        local_res18[0] = 0.0;
        LAB_18153b860:
        do {
          if (*pStatics_f678 == 0) goto LAB_18153d637;
          if (*(int *)(*pStatics_f678 + 24) <= (int)uVar15) {
            return false;
          }
          if ((*pStatics_f678 == 0) ||
             (lVar9 = *(int64 *)(*pStatics_f678 + 16)) == null)
          goto LAB_18153d637;
          if (*(uint32 *)(lVar9 + 24) <= uVar15) {
            uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar8,0);
          }
          lVar9 = lVar9[uVar15];
          if (lVar9 == null) goto LAB_18153d637;
          cVar3 = Behaviour.get_enabled(lVar9,0);
          if (cVar3) {
            uVar8 = Component.get_gameObject(lVar9,0);
            cVar3 = NGUITools.GetActive(uVar8,0);
            if (!cVar3) goto LAB_18153d179;
            uVar8 = UICamera.get_cachedCamera(lVar9,0);
            puVar13 = (uint64 *)(pStatics_f678 + 192);
            *puVar13 = uVar8;
            il2cpp_internal(puVar13,uVar8);
            lVar10 = *(int64 *)(pStatics_f678 + 192);
            if (lVar10 == null) goto LAB_18153d637;
            iVar4 = Camera.get_targetDisplay(lVar10,0);
            if (iVar4 != 0) goto LAB_18153d179;
            lVar10 = *(int64 *)(pStatics_f678 + 192);
            if (lVar10 == null) goto LAB_18153d637;
            local_328 = *inPos;
            local_320 = *(uint32 *)(inPos + 1);
            puVar13 = (uint64 *)Camera.ScreenToViewportPoint(local_208,lVar10,&local_328,0);
            local_318 = *puVar13;
            fVar16 = (float)local_318;
            cVar3 = Single.IsNaN(fVar16,0);
            if (cVar3) goto LAB_18153d179;
            fVar17 = local_318._4_4_;
            cVar3 = Single.IsNaN(local_318._4_4_,0);
            if ((((cVar3) || (fVar16 < 0.0)) || (1.0 < fVar16)) ||
               ((fVar17 < 0.0 || (1.0 < fVar17)))) goto LAB_18153d179;
            lVar10 = *(int64 *)(pStatics_f678 + 192);
            if (lVar10 == null) goto LAB_18153d637;
            local_308 = *inPos;
            local_300 = *(uint32 *)(inPos + 1);
            puVar13 = (uint64 *)Camera.ScreenPointToRay(&local_348,lVar10,&local_308);
            local_368 = *puVar13;
            uStack_360 = puVar13[1];
            local_358 = puVar13[2];
            lVar10 = *(int64 *)(pStatics_f678 + 192);
            if (lVar10 == null) goto LAB_18153d637;
            uVar5 = Camera.get_cullingMask(lVar10,0);
            uVar6 = LayerMask.op_Implicit(*(uint32 *)(lVar9 + 32),0);
            fVar16 = *(float *)(lVar9 + 72);
            uVar6 = uVar6 & uVar5;
            if (fVar16 <= 0.0) {
              lVar10 = *(int64 *)(pStatics_f678 + 192);
              if (lVar10 == null) goto LAB_18153d637;
              fVar16 = (float)Camera.get_farClipPlane(lVar10,0);
              lVar10 = *(int64 *)(pStatics_f678 + 192);
              if (lVar10 == null) goto LAB_18153d637;
              fVar17 = (float)Camera.get_nearClipPlane(lVar10,0);
              fVar16 = fVar16 - fVar17;
            }
            uVar2 = local_358;
            uVar11 = uStack_360;
            uVar8 = local_368;
            iVar4 = *(int *)(lVar9 + 24);
            local_res18[0] = fVar16;
            if (iVar4 == 0) {
              lVar10 = pStatics_f678;
              *(uint64 *)(lVar10 + 112) = uVar8;
              *(uint64 *)(lVar10 + 120) = uVar11;
              *(uint64 *)(lVar10 + 128) = uVar2;
              local_228 = local_368;
              uStack_220 = uStack_360;
              local_218 = local_358;
              cVar3 = Physics.Raycast(&local_228,pStatics_f678 + 136,
                                       local_res18[0],uVar6,1,0);
              if (!cVar3) goto LAB_18153d179;
              puVar13 = (uint64 *)
                        FUN_18045e0a0(local_298,pStatics_f678 + 136,0);
              lVar10 = pStatics_f678;
              *(uint64 *)(lVar10 + 100) = *puVar13;
              *(uint32 *)(lVar10 + 108) = *(uint32 *)(puVar13 + 1);
              lVar10 = RaycastHit.get_collider(pStatics_f678 + 136,0);
              if (lVar10 != null) {
                uVar8 = Component.get_gameObject(lVar10,0);
                puVar13 = (uint64 *)(pStatics_f678 + 0x1d8);
                *puVar13 = uVar8;
                il2cpp_internal(puVar13,uVar8);
                if (*(char *)(lVar9 + 28) != false) {
                  return true;
                }
                lVar9 = *(int64 *)(pStatics_f678 + 0x1d8);
                if ((lVar9 != null) && (lVar9 = FUN_180f92a00(lVar9,0)) != null) {
                  lVar9 = FUN_1809674e0(lVar9,DAT_181d74ed8);
        LAB_18153d5a5:
                  cVar3 = Object.op_Inequality(lVar9,0,0);
                  if (!cVar3) {
                    return true;
                  }
                  if (lVar9 != null) {
                    uVar8 = Component.get_gameObject(lVar9,0);
                    puVar13 = (uint64 *)(pStatics_f678 + 0x1d8);
                    *puVar13 = uVar8;
                    il2cpp_internal(puVar13,uVar8);
                    return true;
                  }
                }
              }
        LAB_18153d637:
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            if (iVar4 == 1) {
              if (*(int64 *)(pStatics_f678 + 0x240) == 0) {
                uVar8 = FUN_1800d60b0(DAT_181da4820,50);
                puVar13 = (uint64 *)(pStatics_f678 + 0x240);
                *puVar13 = uVar8;
                il2cpp_internal(puVar13,uVar8);
              }
              uVar2 = local_358;
              uVar11 = uStack_360;
              uVar8 = local_368;
              local_248 = uVar8;
              uStack_240 = uVar11;
              local_238 = uVar2;
              iVar4 = Physics.RaycastNonAlloc
                                (&local_248,*(uint64 *)(pStatics_f678 + 0x240),
                                 local_res18[0],uVar6,2,0);
              if (1 < iVar4) {
                uVar5 = 0;
        LAB_18153ca86:
                lVar9 = *(int64 *)(pStatics_f678 + 0x240);
                if (lVar9 == null) goto LAB_18153d637;
                if (*(uint32 *)(lVar9 + 24) <= uVar5) {
                  uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1800d65f0(uVar8,0);
                }
                lVar10 = (int64)(int)uVar5 * 44;
                lVar9 = RaycastHit.get_collider(lVar9 + 32 + lVar10,0);
                if ((lVar9 == null) || (lVar9 = Component.get_gameObject(lVar9,0)) == null)
                goto LAB_18153d637;
                plVar14 = (int64 *)GameObject.GetComponent(lVar9);
                cVar3 = Object.op_Inequality(plVar14,0,0);
                if (!cVar3) {
                  lVar12 = NGUITools.FindInParents(lVar9);
                  cVar3 = Object.op_Inequality(lVar12,0,0);
                  if (cVar3) {
                    if (lVar12 != null) {
                      if (*(float *)(lVar12 + 140) <= 0.001 && *(float *)(lVar12 + 140) != 0.001)
                      goto LAB_18153ceeb;
                      goto LAB_18153ccc0;
                    }
                    goto LAB_18153d637;
                  }
                }
                else {
                  if (plVar14 == (int64 *)0) goto LAB_18153d637;
                  cVar3 = UIWidget.get_isVisible(plVar14);
                  if (!cVar3) goto LAB_18153ceeb;
                  if (((*(byte *)(DAT_181db0378 + 300) <= *(byte *)(*plVar14 + 300)) &&
                      (*(int64 *)
                        (*(int64 *)(*plVar14 + 200) + -8 +
                        (uint64)*(byte *)(DAT_181db0378 + 300) * 8) == DAT_181db0378)) &&
                     (lVar12 = UISpriteCollection.GetCurrentSprite(local_c8),
                     (char)*(uint64 *)(lVar12 + 56) == false)) goto LAB_18153ceeb;
                  lVar12 = plVar14[28];
                  if (lVar12 != null) {
                    lVar1 = *(int64 *)(pStatics_f678 + 0x240);
                    if (lVar1 == null) goto LAB_18153d637;
                    if (*(uint32 *)(lVar1 + 24) <= uVar5) {
                      uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                      FUN_1800d65f0(uVar8,0);
                    }
                    puVar13 = (uint64 *)FUN_18045e0a0(local_1b8,lVar1 + 32 + lVar10);
                    local_2a8 = *puVar13;
                    local_2a0 = *(uint32 *)(puVar13 + 1);
                    cVar3 = HitCheck.Invoke(lVar12);
                    if (!cVar3) goto LAB_18153ceeb;
                  }
                }
        LAB_18153ccc0:
                uVar7 = NGUITools.CalculateRaycastDepth(lVar9,0);
                *(uint32 *)(pStatics_f678 + 0x1f0) = uVar7;
                if (*(int *)(pStatics_f678 + 0x1f0) != 0x7fffffff) {
                  lVar9 = pStatics_f678;
                  lVar12 = *(int64 *)(lVar9 + 0x240);
                  if (lVar12 == null) goto LAB_18153d637;
                  if (*(uint32 *)(lVar12 + 24) <= uVar5) {
                    uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                    FUN_1800d65f0(uVar8,0);
                  }
                  puVar13 = (uint64 *)(lVar10 + 32 + lVar12);
                  uVar8 = puVar13[1];
                  *(uint64 *)(lVar9 + 500) = *puVar13;
                  *(uint64 *)(lVar9 + 0x1fc) = uVar8;
                  puVar13 = (uint64 *)(lVar10 + 48 + lVar12);
                  uVar8 = puVar13[1];
                  *(uint64 *)(lVar9 + 0x204) = *puVar13;
                  *(uint64 *)(lVar9 + 0x20c) = uVar8;
                  *(uint64 *)(lVar9 + 0x214) = *(uint64 *)(lVar10 + 64 + lVar12);
                  *(uint32 *)(lVar9 + 0x21c) = *(uint32 *)(lVar10 + 72 + lVar12);
                  lVar9 = *(int64 *)(pStatics_f678 + 0x240);
                  if (lVar9 == null) goto LAB_18153d637;
                  if (*(uint32 *)(lVar9 + 24) <= uVar5) {
                    uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                    FUN_1800d65f0(uVar8,0);
                  }
                  puVar13 = (uint64 *)FUN_18045e0a0(local_298,lVar9 + 32 + lVar10,0);
                  lVar9 = pStatics_f678;
                  *(uint64 *)(lVar9 + 0x220) = *puVar13;
                  *(uint32 *)(lVar9 + 0x228) = *(uint32 *)(puVar13 + 1);
                  lVar9 = *(int64 *)(pStatics_f678 + 0x240);
                  if (lVar9 == null) goto LAB_18153d637;
                  if (*(uint32 *)(lVar9 + 24) <= uVar5) {
                    uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                    FUN_1800d65f0(uVar8,0);
                  }
                  lVar9 = RaycastHit.get_collider(lVar9 + 32 + lVar10,0);
                  if (lVar9 == null) goto LAB_18153d637;
                  uVar8 = Component.get_gameObject(lVar9,0);
                  puVar13 = (uint64 *)(pStatics_f678 + 0x230);
                  *puVar13 = uVar8;
                  il2cpp_internal(puVar13,uVar8);
                  lVar9 = pStatics_f678;
                  if (*(int64 *)(lVar9 + 0x238) == 0) goto LAB_18153d637;
                  local_158 = *(uint64 *)(lVar9 + 0x1f0);
                  uStack_150 = *(uint64 *)(lVar9 + 0x1f8);
                  local_148 = *(uint64 *)(lVar9 + 0x200);
                  uStack_140 = *(uint64 *)(lVar9 + 0x208);
                  local_138 = *(uint64 *)(lVar9 + 0x210);
                  uStack_130 = *(uint64 *)(lVar9 + 0x218);
                  local_128 = *(uint64 *)(lVar9 + 0x220);
                  uStack_120 = *(uint64 *)(lVar9 + 0x228);
                  local_118 = *(uint64 *)(lVar9 + 0x230);
                  FUN_181583da0();
                }
        LAB_18153ceeb:
                uVar5 = uVar5 + 1;
                if (iVar4 <= (int)uVar5) break;
                goto LAB_18153ca86;
              }
              if (iVar4 == 1) {
                lVar9 = *(int64 *)(pStatics_f678 + 0x240);
                if (lVar9 != null) {
                  if (*(int *)(lVar9 + 24) == 0) {
                    uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                    FUN_1800d65f0(uVar8,0);
                  }
                  lVar9 = RaycastHit.get_collider(lVar9 + 32,0);
                  if ((lVar9 != null) && (lVar9 = Component.get_gameObject(lVar9,0)) != null) {
                    lVar10 = GameObject.GetComponent(lVar9,DAT_181d74c30);
                    cVar3 = Object.op_Inequality(lVar10,0,0);
                    if (!cVar3) {
                      lVar9 = NGUITools.FindInParents(lVar9,DAT_181d8f720);
                      cVar3 = Object.op_Inequality(lVar9,0,0);
                      if (cVar3) {
                        if (lVar9 == null) goto LAB_18153d637;
                        if (*(float *)(lVar9 + 140) <= 0.001 && *(float *)(lVar9 + 140) != 0.001)
                        goto LAB_18153d179;
                      }
                    }
                    else {
                      if (lVar10 == null) goto LAB_18153d637;
                      cVar3 = UIWidget.get_isVisible(lVar10,0);
                      if (!cVar3) goto LAB_18153d179;
                      lVar9 = *(int64 *)(lVar10 + 224);
                      if (lVar9 != null) {
                        lVar10 = *(int64 *)(pStatics_f678 + 0x240);
                        if (lVar10 == null) goto LAB_18153d637;
                        if (*(int *)(lVar10 + 24) == 0) {
                          uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                          FUN_1800d65f0(uVar8,0);
                        }
                        puVar13 = (uint64 *)FUN_18045e0a0(local_1d8,lVar10 + 32,0);
                        local_2c8 = *puVar13;
                        local_2c0 = *(uint32 *)(puVar13 + 1);
                        cVar3 = HitCheck.Invoke(lVar9,&local_2c8,0);
                        if (!cVar3) goto LAB_18153d179;
                      }
                    }
                    lVar9 = *(int64 *)(pStatics_f678 + 0x240);
                    if (lVar9 != null) {
                      if (*(int *)(lVar9 + 24) == 0) {
                        uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                        FUN_1800d65f0(uVar8,0);
                      }
                      puVar13 = (uint64 *)FUN_18045e0a0(local_1c8,lVar9 + 32,0);
                      uVar8 = *puVar13;
                      uVar7 = *(uint32 *)(puVar13 + 1);
                      lVar9 = *(int64 *)(pStatics_f678 + 0x240);
                      if (lVar9 != null) {
                        if (*(int *)(lVar9 + 24) == 0) {
                          uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                          FUN_1800d65f0(uVar8,0);
                        }
                        lVar9 = RaycastHit.get_collider(lVar9 + 32,0);
                        if (lVar9 != null) {
                          uVar11 = Component.get_gameObject(lVar9,0);
                          local_2b8 = uVar8;
                          local_2b0 = uVar7;
                          cVar3 = UICamera.IsVisible(&local_2b8,uVar11,0);
                          if (!cVar3) goto LAB_18153d179;
                          lVar9 = pStatics_f678;
                          lVar10 = *(int64 *)(lVar9 + 0x240);
                          if (lVar10 != null) {
                            if (*(int *)(lVar10 + 24) == 0) {
                              uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                              FUN_1800d65f0(uVar8,0);
                            }
                            uVar8 = *(uint64 *)(lVar10 + 40);
                            *(uint64 *)(lVar9 + 136) = *(uint64 *)(lVar10 + 32);
                            *(uint64 *)(lVar9 + 144) = uVar8;
                            uVar8 = *(uint64 *)(lVar10 + 56);
                            *(uint64 *)(lVar9 + 152) = *(uint64 *)(lVar10 + 48);
                            *(uint64 *)(lVar9 + 160) = uVar8;
                            *(uint64 *)(lVar9 + 168) = *(uint64 *)(lVar10 + 64);
                            *(uint32 *)(lVar9 + 176) = *(uint32 *)(lVar10 + 72);
                            lVar9 = pStatics_f678;
                            *(uint32 *)(lVar9 + 112) = (uint32)local_368;
                            *(uint32 *)(lVar9 + 116) = local_368._4_4_;
                            *(uint32 *)(lVar9 + 120) = (uint32)uStack_360;
                            *(uint32 *)(lVar9 + 124) = uStack_360._4_4_;
                            *(uint64 *)(lVar9 + 128) = local_358;
                            lVar9 = *(int64 *)(pStatics_f678 + 0x240);
                            if (lVar9 != null) {
                              if (*(int *)(lVar9 + 24) == 0) {
                                uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                FUN_1800d65f0(uVar8,0);
                              }
                              puVar13 = (uint64 *)FUN_18045e0a0(local_298,lVar9 + 32,0);
                              lVar9 = pStatics_f678;
                              *(uint64 *)(lVar9 + 100) = *puVar13;
                              *(uint32 *)(lVar9 + 108) = *(uint32 *)(puVar13 + 1);
                              lVar9 = RaycastHit.get_collider
                                                (pStatics_f678 + 136,0);
                              if (lVar9 != null) {
                                uVar8 = Component.get_gameObject(lVar9,0);
                                puVar13 = (uint64 *)(pStatics_f678 + 0x1d8);
                                *puVar13 = uVar8;
                                il2cpp_internal(puVar13,uVar8);
                                return true;
                              }
                            }
                          }
                        }
                      }
                    }
                  }
                }
                goto LAB_18153d637;
              }
            }
            else if (iVar4 == 2) {
              local_268 = (uint32)local_368;
              uStack_264 = local_368._4_4_;
              uStack_260 = (uint32)uStack_360;
              uStack_25c = uStack_360._4_4_;
              local_258 = local_358;
              cVar3 = Plane.Raycast(pStatics_f678 + 0x250,&local_268,local_res18);
              if (cVar3) {
                puVar13 = (uint64 *)Ray.GetPoint(local_1e8,&local_368,local_res18[0]);
                uVar7 = *(uint32 *)(puVar13 + 1);
                uVar8 = *puVar13;
                local_350 = (uint32)uVar8;
                uStack_34c = (uint32)((uint64)uVar8 >> 32);
                local_348 = uVar8;
                local_340 = uVar7;
                lVar10 = Physics2D.OverlapPoint(CONCAT44(uStack_34c,local_350),uVar6,0);
                cVar3 = Object.op_Implicit(lVar10,0);
                if (!cVar3) goto LAB_18153d179;
                lVar12 = pStatics_f678;
                *(uint64 *)(lVar12 + 100) = uVar8;
                *(uint32 *)(lVar12 + 108) = uVar7;
                if (lVar10 != null) {
                  uVar8 = Component.get_gameObject(lVar10,0);
                  puVar13 = (uint64 *)(pStatics_f678 + 0x1d8);
                  *puVar13 = uVar8;
                  il2cpp_internal(puVar13,uVar8);
                  if (*(char *)(lVar9 + 28) != false) {
                    return true;
                  }
                  lVar9 = *(int64 *)(pStatics_f678 + 0x1d8);
                  if (lVar9 != null) {
                    uVar8 = GameObject.get_transform(lVar9,0);
                    lVar9 = UICamera.FindRootRigidbody2D(uVar8,0);
                    goto LAB_18153d5a5;
                  }
                }
                goto LAB_18153d637;
              }
            }
            else {
              if (iVar4 != 3) goto LAB_18153d179;
              local_288 = (uint32)local_368;
              uStack_284 = local_368._4_4_;
              uStack_280 = (uint32)uStack_360;
              uStack_27c = uStack_360._4_4_;
              local_278 = local_358;
              cVar3 = Plane.Raycast(pStatics_f678 + 0x250,&local_288,local_res18);
              if (!cVar3) goto LAB_18153d179;
              puVar13 = (uint64 *)Ray.GetPoint(local_1f8,&local_368,local_res18[0]);
              uVar8 = *puVar13;
              uVar7 = *(uint32 *)(puVar13 + 1);
              lVar9 = pStatics_f678;
              *(uint64 *)(lVar9 + 100) = uVar8;
              *(uint32 *)(lVar9 + 108) = uVar7;
              if (*(int64 *)(pStatics_f678 + 0x248) == 0) {
                uVar8 = FUN_1800d60b0(DAT_181da10c0,50);
                puVar13 = (uint64 *)(pStatics_f678 + 0x248);
                *puVar13 = uVar8;
                il2cpp_internal(puVar13,uVar8);
              }
              lVar9 = pStatics_f678;
              local_348 = *(uint64 *)(lVar9 + 100);
              local_res20 = (uint32)local_348;
              uStackX_24 = (uint32)((uint64)local_348 >> 32);
              local_340 = *(uint32 *)(lVar9 + 108);
              uVar8 = *(uint64 *)(lVar9 + 0x248);
              iVar4 = Physics2D.OverlapPointNonAlloc(CONCAT44(uStackX_24,local_res20),uVar8,uVar6);
              if (1 < iVar4) {
                uVar5 = 0;
                do {
                  lVar9 = *(int64 *)(pStatics_f678 + 0x248);
                  if (lVar9 == null) goto LAB_18153d637;
                  if (*(uint32 *)(lVar9 + 24) <= uVar5) {
                    uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                    FUN_1800d65f0(uVar8,0);
                  }
                  lVar9 = lVar9[uVar5];
                  if ((lVar9 == null) || (lVar9 = Component.get_gameObject(lVar9,0)) == null)
                  goto LAB_18153d637;
                  lVar10 = GameObject.GetComponent(lVar9);
                  cVar3 = Object.op_Inequality(lVar10,0,0);
                  if (!cVar3) {
                    lVar10 = NGUITools.FindInParents(lVar9);
                    cVar3 = Object.op_Inequality(lVar10,0,0);
                    if (cVar3) {
                      if (lVar10 == null) goto LAB_18153d637;
                      if (*(float *)(lVar10 + 140) <= 0.001 && *(float *)(lVar10 + 140) != 0.001)
                      goto LAB_18153c2ec;
                    }
        LAB_18153c199:
                    uVar7 = NGUITools.CalculateRaycastDepth(lVar9,0);
                    *(uint32 *)(pStatics_f678 + 0x1f0) = uVar7;
                    if (*(int *)(pStatics_f678 + 0x1f0) != 0x7fffffff) {
                      plVar14 = (int64 *)(pStatics_f678 + 0x230);
                      *plVar14 = lVar9;
                      il2cpp_internal(plVar14,lVar9);
                      lVar9 = pStatics_f678;
                      *(uint64 *)(lVar9 + 0x220) = *(uint64 *)(lVar9 + 100);
                      *(uint32 *)(lVar9 + 0x228) = *(uint32 *)(lVar9 + 108);
                      lVar9 = pStatics_f678;
                      if (*(int64 *)(lVar9 + 0x238) == 0) goto LAB_18153d637;
                      local_1a8 = *(uint64 *)(lVar9 + 0x1f0);
                      uStack_1a0 = *(uint64 *)(lVar9 + 0x1f8);
                      local_198 = *(uint64 *)(lVar9 + 0x200);
                      uStack_190 = *(uint64 *)(lVar9 + 0x208);
                      local_188 = *(uint64 *)(lVar9 + 0x210);
                      uStack_180 = *(uint64 *)(lVar9 + 0x218);
                      local_178 = *(uint64 *)(lVar9 + 0x220);
                      uStack_170 = *(uint64 *)(lVar9 + 0x228);
                      local_168 = *(uint64 *)(lVar9 + 0x230);
                      FUN_181583da0();
                    }
                  }
                  else {
                    if (lVar10 == null) goto LAB_18153d637;
                    cVar3 = UIWidget.get_isVisible(lVar10);
                    if (cVar3) {
                      lVar10 = *(int64 *)(lVar10 + 224);
                      if (lVar10 != null) {
                        local_2d0 = *(uint32 *)(pStatics_f678 + 108);
                        local_2d8 = *(uint64 *)(pStatics_f678 + 100);
                        cVar3 = HitCheck.Invoke(lVar10);
                        if (!cVar3) goto LAB_18153c2ec;
                      }
                      goto LAB_18153c199;
                    }
                  }
        LAB_18153c2ec:
                  uVar5 = uVar5 + 1;
                } while ((int)uVar5 < iVar4);
                lVar9 = *(int64 *)(pStatics_f678 + 0x238);
                lVar10 = *(int64 *)(pStatics_d1b8 + 16);
                if (lVar10 == null) {
                  uVar8 = **(uint64 **)(DAT_181d8d1b8 + 184);
                  lVar10 = new OnTooltipCB(uVar8,DAT_181db79c8);
                  plVar14 = (int64 *)(pStatics_d1b8 + 16);
                  *plVar14 = lVar10;
                  il2cpp_internal(plVar14,lVar10);
                }
                if (lVar9 != null) {
                  FUN_181586930(lVar9,lVar10,DAT_181da7b38);
                  uVar5 = 0;
                  while( true ) {
                    lVar9 = *(int64 *)(pStatics_f678 + 0x238);
                    if (lVar9 == null) goto LAB_18153d637;
                    if (*(int *)(lVar9 + 24) <= (int)uVar5) break;
                    lVar9 = *(int64 *)(pStatics_f678 + 0x238);
                    if ((lVar9 == null) || (lVar9 = *(int64 *)(lVar9 + 16)) == null)
                    goto LAB_18153d637;
                    if (*(uint32 *)(lVar9 + 24) <= uVar5) {
                      uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                      FUN_1800d65f0(uVar8,0);
                    }
                    cVar3 = UICamera.IsVisible(lVar9 + (int64)(int)uVar5 * 72 + 32,0);
                    if (cVar3) {
                      lVar9 = *(int64 *)(pStatics_f678 + 0x238);
                      if ((lVar9 != null) && (lVar9 = *(int64 *)(lVar9 + 16)) != null) {
                        if (*(uint32 *)(lVar9 + 24) <= uVar5) {
                          uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                          FUN_1800d65f0(uVar8,0);
                        }
                        *(uint64 *)(pStatics_f678 + 0x1d8) =
                             *(uint64 *)(lVar9 + 96 + (int64)(int)uVar5 * 72);
                        il2cpp_internal();
        LAB_18153d460:
                        lVar9 = *(int64 *)(pStatics_f678 + 0x238);
                        if (lVar9 != null) {
                          BetterList_1.Clear(lVar9,DAT_181da7ab8);
                          return true;
                        }
                      }
                      goto LAB_18153d637;
                    }
                    uVar5 = uVar5 + 1;
                  }
                  goto LAB_18153d091;
                }
                goto LAB_18153d637;
              }
              if (iVar4 == 1) {
                lVar9 = *(int64 *)(pStatics_f678 + 0x248);
                if (lVar9 != null) {
                  if (*(int *)(lVar9 + 24) == 0) {
                    uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                    FUN_1800d65f0(uVar8,0);
                  }
                  if ((*(int64 *)(lVar9 + 32) != 0) &&
                     (lVar9 = Component.get_gameObject(*(int64 *)(lVar9 + 32),0)) != null) {
                    lVar10 = GameObject.GetComponent(lVar9,DAT_181d74c30);
                    cVar3 = Object.op_Inequality(lVar10,0,0);
                    if (!cVar3) {
                      lVar10 = NGUITools.FindInParents(lVar9,DAT_181d8f720);
                      cVar3 = Object.op_Inequality(lVar10,0,0);
                      if (cVar3) {
                        if (lVar10 == null) goto LAB_18153d637;
                        if (*(float *)(lVar10 + 140) <= 0.001 && *(float *)(lVar10 + 140) != 0.001)
                        goto LAB_18153d179;
                      }
                    }
                    else {
                      if (lVar10 == null) goto LAB_18153d637;
                      cVar3 = UIWidget.get_isVisible(lVar10,0);
                      if (!cVar3) goto LAB_18153d179;
                      lVar10 = *(int64 *)(lVar10 + 224);
                      if (lVar10 != null) {
                        local_2f0 = *(uint32 *)(pStatics_f678 + 108);
                        local_2f8 = *(uint64 *)(pStatics_f678 + 100);
                        cVar3 = HitCheck.Invoke(lVar10,&local_2f8,0);
                        if (!cVar3) goto LAB_18153d179;
                      }
                    }
                    local_2e8 = *(uint64 *)(pStatics_f678 + 100);
                    local_2e0 = *(uint32 *)(pStatics_f678 + 108);
                    cVar3 = UICamera.IsVisible(&local_2e8,lVar9,0);
                    if (cVar3) {
                      plVar14 = (int64 *)(pStatics_f678 + 0x1d8);
                      *plVar14 = lVar9;
                      il2cpp_internal(plVar14,lVar9);
                      return true;
                    }
                    goto LAB_18153d179;
                  }
                }
                goto LAB_18153d637;
              }
            }
          }
        LAB_18153d179:
          uVar15 = uVar15 + 1;
        } while( true );
        lVar9 = *(int64 *)(pStatics_f678 + 0x238);
        lVar10 = *(int64 *)(pStatics_d1b8 + 8);
        if (lVar10 == null) {
          uVar8 = **(uint64 **)(DAT_181d8d1b8 + 184);
          lVar10 = new OnTooltipCB(uVar8,DAT_181db7940);
          plVar14 = (int64 *)(pStatics_d1b8 + 8);
          *plVar14 = lVar10;
          il2cpp_internal(plVar14,lVar10);
        }
        if (lVar9 == null) goto LAB_18153d637;
        FUN_181586930(lVar9,lVar10,DAT_181da7b38);
        uVar5 = 0;
        while( true ) {
          lVar9 = *(int64 *)(pStatics_f678 + 0x238);
          if (lVar9 == null) goto LAB_18153d637;
          if (*(int *)(lVar9 + 24) <= (int)uVar5) break;
          lVar9 = *(int64 *)(pStatics_f678 + 0x238);
          if ((lVar9 == null) || (lVar9 = *(int64 *)(lVar9 + 16)) == null) goto LAB_18153d637;
          lVar10 = (int64)(int)uVar5;
          if (*(uint32 *)(lVar9 + 24) <= uVar5) {
            uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar8,0);
          }
          cVar3 = UICamera.IsVisible(lVar9 + lVar10 * 72 + 32,0);
          if (cVar3) {
            lVar9 = pStatics_f678;
            if ((*(int64 *)(lVar9 + 0x238) == 0) ||
               (lVar12 = *(int64 *)(*(int64 *)(lVar9 + 0x238) + 16)) == null)
            goto LAB_18153d637;
            if (*(uint32 *)(lVar12 + 24) <= uVar5) {
              uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar8,0);
            }
            puVar13 = (uint64 *)(lVar12 + 36 + lVar10 * 72);
            uVar8 = puVar13[1];
            *(uint64 *)(lVar9 + 136) = *puVar13;
            *(uint64 *)(lVar9 + 144) = uVar8;
            puVar13 = (uint64 *)(lVar12 + 52 + lVar10 * 72);
            uVar8 = puVar13[1];
            *(uint64 *)(lVar9 + 152) = *puVar13;
            *(uint64 *)(lVar9 + 160) = uVar8;
            *(uint64 *)(lVar9 + 168) = *(uint64 *)(lVar12 + 68 + lVar10 * 72);
            *(uint32 *)(lVar9 + 176) = *(uint32 *)(lVar12 + 76 + lVar10 * 72);
            lVar9 = *(int64 *)(pStatics_f678 + 0x238);
            if ((lVar9 == null) || (lVar9 = *(int64 *)(lVar9 + 16)) == null) goto LAB_18153d637;
            if (*(uint32 *)(lVar9 + 24) <= uVar5) {
              uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar8,0);
            }
            *(uint64 *)(pStatics_f678 + 0x1d8) =
                 *(uint64 *)(lVar9 + 96 + lVar10 * 72);
            il2cpp_internal();
            lVar9 = pStatics_f678;
            *(uint32 *)(lVar9 + 112) = (uint32)local_368;
            *(uint32 *)(lVar9 + 116) = local_368._4_4_;
            *(uint32 *)(lVar9 + 120) = (uint32)uStack_360;
            *(uint32 *)(lVar9 + 124) = uStack_360._4_4_;
            *(uint64 *)(lVar9 + 128) = local_358;
            lVar9 = pStatics_f678;
            if ((*(int64 *)(lVar9 + 0x238) == 0) ||
               (lVar12 = *(int64 *)(*(int64 *)(lVar9 + 0x238) + 16)) == null)
            goto LAB_18153d637;
            if (*(uint32 *)(lVar12 + 24) <= uVar5) {
              uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar8,0);
            }
            *(uint64 *)(lVar9 + 100) = *(uint64 *)(lVar12 + 80 + lVar10 * 72);
            *(uint32 *)(lVar9 + 108) = *(uint32 *)(lVar12 + 88 + lVar10 * 72);
            goto LAB_18153d460;
          }
          uVar5 = uVar5 + 1;
        }
        LAB_18153d091:
        lVar9 = *(int64 *)(pStatics_f678 + 0x238);
        if (lVar9 == null) goto LAB_18153d637;
        BetterList_1.Clear(lVar9,DAT_181da7ab8);
        uVar15 = uVar15 + 1;
        goto LAB_18153b860;
    }

    // Token : 0x600071C
    // RVA   : 0x1534CA0   Offset: 0x15340A0   Length: 0x101
    private static bool IsVisible(Vector3 worldPoint, GameObject go)
    {
        ulong uVar1;
        bool cVar2;
        long lVar3;
        uVar1 = *(uint64 *)(worldPoint + 64);
        lVar3 = NGUITools.FindInParents(uVar1,DAT_181d8f620);
        while( true ) {
          cVar2 = Object.op_Inequality(lVar3,0,0);
          if (!cVar2) {
            return true;
          }
          if (lVar3 == null) {
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          cVar2 = UIPanel.IsVisible(lVar3);
          if (!cVar2) break;
          lVar3 = *(int64 *)(lVar3 + 400);
        }
        return false;
    }

    // Token : 0x600071D
    // RVA   : 0x1534DB0   Offset: 0x15341B0   Length: 0x102
    private static bool IsVisible(ref DepthEntry de)
    {
        ulong uVar1;
        bool cVar2;
        long lVar3;
        uVar1 = *(uint64 *)(de + 64);
        lVar3 = NGUITools.FindInParents(uVar1,DAT_181d8f620);
        while( true ) {
          cVar2 = Object.op_Inequality(lVar3,0,0);
          if (!cVar2) {
            return true;
          }
          if (lVar3 == null) {
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          cVar2 = UIPanel.IsVisible(lVar3);
          if (!cVar2) break;
          lVar3 = *(int64 *)(lVar3 + 400);
        }
        return false;
    }

    // Token : 0x600071E
    // RVA   : 0x1534830   Offset: 0x1533C30   Length: 0x93
    public static bool IsHighlighted(GameObject go)
    {
        ulong uVar1;
        uVar1 = UICamera.get_hoveredObject(0);
        Object.op_Equality(uVar1,go,0);
    }

    // Token : 0x600071F
    // RVA   : 0x1533D40   Offset: 0x1533140   Length: 0x16C
    public static UICamera FindCameraForLayer(int layer)
    {
        var pStatics = *(int64*)(DAT_181daf678 + 184);
        long lVar1;
        bool cVar2;
        uint uVar3;
        long lVar4;
        ulong uVar5;
        uint uVar6;
        uVar6 = 0;
        while( true ) {
          if (*pStatics == 0) break;
          if (*(int *)(*pStatics + 24) <= (int)uVar6) {
            return 0;
          }
          if ((*pStatics == 0) ||
             (lVar1 = *(int64 *)(*pStatics + 16)) == null) break;
          if (*(uint32 *)(lVar1 + 24) <= uVar6) {
            uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar5,0);
          }
          lVar1 = lVar1[uVar6];
          if (lVar1 == null) break;
          lVar4 = UICamera.get_cachedCamera(lVar1,0);
          cVar2 = Object.op_Inequality(lVar4,0,0);
          if (cVar2) {
            if (lVar4 == null) break;
            uVar3 = Camera.get_cullingMask(lVar4,0);
            if ((1 << (layer & 31) & uVar3) != 0) {
              return lVar1;
            }
          }
          uVar6 = uVar6 + 1;
        }
    }

    // Token : 0x6000720
    // RVA   : 0x1534150   Offset: 0x1533550   Length: 0x142
    private static int GetDirection(KeyCode up, KeyCode down)
    {
        var pStatics = *(int64*)(DAT_181daf678 + 184);
        long lVar2;
        bool cVar3;
        float fVar4;
        float fVar5;
        fVar4 = (float)RealTime.get_time(0);
        pfVar1 = (float *)(pStatics + 0x260);
        if (*pfVar1 <= fVar4 && fVar4 != *pfVar1) {
          cVar3 = FUN_180d755b0(up,0);
          if (!cVar3) {
            lVar2 = *(int64 *)(pStatics + 32);
            if (lVar2 == null) {
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            fVar5 = (float)GetAxisFunc.Invoke(lVar2,up,0);
            if (0.75 < fVar5) {
              UICamera.set_currentKey(0x14a,0);
              *(float *)(pStatics + 0x260) = fVar4 + 0.25;
              return 1;
            }
            if (fVar5 < -0.75) {
              UICamera.set_currentKey(0x14a,0);
              *(float *)(pStatics + 0x260) = fVar4 + 0.25;
              return 0xffffffff;
            }
          }
        }
        return 0;
    }

    // Token : 0x6000721
    // RVA   : 0x15342A0   Offset: 0x15336A0   Length: 0x237
    private static int GetDirection(KeyCode up0, KeyCode up1, KeyCode down0, KeyCode down1)
    {
        var pStatics = *(int64*)(DAT_181daf678 + 184);
        long lVar2;
        bool cVar3;
        float fVar4;
        float fVar5;
        fVar4 = (float)RealTime.get_time(0);
        pfVar1 = (float *)(pStatics + 0x260);
        if (*pfVar1 <= fVar4 && fVar4 != *pfVar1) {
          cVar3 = FUN_180d755b0(up0,0);
          if (!cVar3) {
            lVar2 = *(int64 *)(pStatics + 32);
            if (lVar2 == null) {
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            fVar5 = (float)GetAxisFunc.Invoke(lVar2,up0,0);
            if (0.75 < fVar5) {
              UICamera.set_currentKey(0x14a,0);
              *(float *)(pStatics + 0x260) = fVar4 + 0.25;
              return 1;
            }
            if (fVar5 < -0.75) {
              UICamera.set_currentKey(0x14a,0);
              *(float *)(pStatics + 0x260) = fVar4 + 0.25;
              return 0xffffffff;
            }
          }
        }
        return 0;
    }

    // Token : 0x6000722
    // RVA   : 0x15344E0   Offset: 0x15338E0   Length: 0x1A5
    private static int GetDirection(string axis)
    {
        var pStatics = *(int64*)(DAT_181daf678 + 184);
        long lVar2;
        bool cVar3;
        float fVar4;
        float fVar5;
        fVar4 = (float)RealTime.get_time(0);
        pfVar1 = (float *)(pStatics + 0x260);
        if (*pfVar1 <= fVar4 && fVar4 != *pfVar1) {
          cVar3 = FUN_180d755b0(axis,0);
          if (!cVar3) {
            lVar2 = *(int64 *)(pStatics + 32);
            if (lVar2 == null) {
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            fVar5 = (float)GetAxisFunc.Invoke(lVar2,axis,0);
            if (0.75 < fVar5) {
              UICamera.set_currentKey(0x14a,0);
              *(float *)(pStatics + 0x260) = fVar4 + 0.25;
              return 1;
            }
            if (fVar5 < -0.75) {
              UICamera.set_currentKey(0x14a,0);
              *(float *)(pStatics + 0x260) = fVar4 + 0.25;
              return 0xffffffff;
            }
          }
        }
        return 0;
    }

    // Token : 0x6000723
    // RVA   : 0x1535070   Offset: 0x1534470   Length: 0x3AD
    public static void Notify(GameObject go, string funcName, object obj)
    {
        var pStatics_f678 = *(int64*)(DAT_181daf678 + 184);
        var pStatics_fff8 = *(int64*)(DAT_181dafff8 + 184);
        ulong uVar2;
        long lVar3;
        bool cVar4;
        int iVar5;
        if (*(int *)(pStatics_f678 + 0x264) < 11) {
          iVar5 = UICamera.get_currentScheme(0);
          if (iVar5 == 2) {
            cVar4 = UIPopupList.get_isOpen(0);
            if (cVar4) {
              if (*pStatics_fff8 == 0) goto LAB_181535418;
              uVar2 = *(uint64 *)(*pStatics_fff8 + 0x160);
              cVar4 = Object.op_Equality(uVar2,go,0);
              if (cVar4) {
                cVar4 = UIPopupList.get_isOpen(0);
                if (cVar4) {
                  if (*pStatics_fff8 == 0) goto LAB_181535418;
                  go = Component.get_gameObject(*pStatics_fff8,0);
                }
              }
            }
          }
          cVar4 = Object.op_Implicit(go,0);
          if (cVar4) {
            if (go == null) {
        LAB_181535418:
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            cVar4 = GameObject.get_activeInHierarchy(go,0);
            if (cVar4) {
              piVar1 = (int *)(pStatics_f678 + 0x264);
              *piVar1 = *piVar1 + 1;
              GameObject.SendMessage(go,funcName,obj,1,0);
              uVar2 = *(uint64 *)(pStatics_f678 + 240);
              cVar4 = Object.op_Inequality(uVar2,0,0);
              if (cVar4) {
                uVar2 = *(uint64 *)(pStatics_f678 + 240);
                cVar4 = Object.op_Inequality(uVar2,go,0);
                if (cVar4) {
                  lVar3 = *(int64 *)(pStatics_f678 + 240);
                  if (lVar3 == null) goto LAB_181535418;
                  GameObject.SendMessage(lVar3,funcName,obj,1,0);
                }
              }
              piVar1 = (int *)(pStatics_f678 + 0x264);
              *piVar1 = *piVar1 + -1;
            }
          }
        }
    }

    // Token : 0x6000724
    // RVA   : 0x15333A0   Offset: 0x15327A0   Length: 0x5B6
    private void Awake()
    {
        var pStatics = *(int64*)(DAT_181daf678 + 184);
        long lVar1;
        bool cVar2;
        uint uVar3;
        int iVar4;
        long lVar6;
        ulong uVar7;
        uint uVar8;
        uint local_38;
        uint uStack_24;
        byte[] local_18 = new byte[16];
        uVar3 = Screen.get_width(0);
        *(uint32 *)(pStatics + 0x1a8) = uVar3;
        uVar3 = Screen.get_height(0);
        *(uint32 *)(pStatics + 0x1ac) = uVar3;
        iVar4 = Application.get_platform(0);
        if ((iVar4 == 25) || (iVar4 = Application.get_platform(0), iVar4 == 27)) {
          if (*(int *)(pStatics + 208) != 2) {
            UICamera.set_currentKey(0x14a,0);
            *(uint32 *)(pStatics + 208) = 2;
          }
        }
        lVar6 = *(int64 *)(pStatics + 0x188);
        if (lVar6 != null) {
          if (*(int *)(lVar6 + 24) == 0) {
            uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar7,0);
          }
          lVar6 = *(int64 *)(lVar6 + 32);
          puVar5 = (uint64 *)Input.get_mousePosition(local_18,0);
          if (lVar6 != null) {
            local_38 = (uint32)*puVar5;
            uStack_24 = (uint32)((uint64)*puVar5 >> 32);
            *(uint32 *)(lVar6 + 20) = local_38;
            *(uint32 *)(lVar6 + 24) = uStack_24;
            uVar8 = 1;
            do {
              lVar6 = *(int64 *)(pStatics + 0x188);
              if (lVar6 == null) throw; // [null/range check failed]
              if (*(uint32 *)(lVar6 + 24) <= uVar8) {
                uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar7,0);
              }
              if (*(uint32 *)(lVar6 + 24) == 0) {
                uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar7,0);
              }
              lVar1 = *(int64 *)(lVar6 + 32);
              if (lVar1 == null) throw; // [null/range check failed]
              uVar3 = *(uint32 *)(lVar1 + 24);
              lVar6 = lVar6[uVar8];
              if (lVar6 == null) throw; // [null/range check failed]
              *(uint32 *)(lVar6 + 20) = *(uint32 *)(lVar1 + 20);
              *(uint32 *)(lVar6 + 24) = uVar3;
              lVar6 = *(int64 *)(pStatics + 0x188);
              if (lVar6 == null) throw; // [null/range check failed]
              if (*(uint32 *)(lVar6 + 24) <= uVar8) {
                uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar7,0);
              }
              if (*(uint32 *)(lVar6 + 24) == 0) {
                uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar7,0);
              }
              lVar1 = *(int64 *)(lVar6 + 32);
              if (lVar1 == null) throw; // [null/range check failed]
              uVar3 = *(uint32 *)(lVar1 + 24);
              lVar6 = lVar6[uVar8];
              if (lVar6 == null) throw; // [null/range check failed]
              uVar8 = uVar8 + 1;
              *(uint32 *)(lVar6 + 28) = *(uint32 *)(lVar1 + 20);
              *(uint32 *)(lVar6 + 32) = uVar3;
            } while ((int)uVar8 < 3);
            lVar6 = pStatics;
            lVar1 = *(int64 *)(lVar6 + 0x188);
            if (lVar1 != null) {
              if (*(int *)(lVar1 + 24) == 0) {
                uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar7,0);
              }
              lVar1 = *(int64 *)(lVar1 + 32);
              if (lVar1 != null) {
                uVar3 = *(uint32 *)(lVar1 + 24);
                *(uint32 *)(lVar6 + 92) = *(uint32 *)(lVar1 + 20);
                *(uint32 *)(lVar6 + 96) = uVar3;
                lVar6 = Environment.GetCommandLineArgs(0);
                if (lVar6 != null) {
                  uVar8 = 0;
                  while ((int)uVar8 < (int)*(uint32 *)(lVar6 + 24)) {
                    if (*(uint32 *)(lVar6 + 24) <= uVar8) {
                      uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                      FUN_1800d65f0(uVar7,0);
                    }
                    uVar7 = lVar6[uVar8];
                    cVar2 = FUN_18171e540(uVar7,"-noMouse",0);
                    if (!cVar2) {
                      cVar2 = FUN_18171e540(uVar7,"-noTouch",0);
                      if (!cVar2) {
                        cVar2 = FUN_18171e540(uVar7,"-noController",0);
                        if ((!cVar2) &&
                           (cVar2 = FUN_18171e540(uVar7,"-noJoystick",0), !cVar2)) {
                          cVar2 = FUN_18171e540(uVar7,"-useMouse",0);
                          if (!cVar2) {
                            cVar2 = FUN_18171e540(uVar7,"-useTouch",0);
                            if (!cVar2) {
                              cVar2 = FUN_18171e540(uVar7,"-useController",0);
                              if ((!cVar2) &&
                                 (cVar2 = FUN_18171e540(uVar7,"-useJoystick",0), !cVar2))
                              goto LAB_1815338c5;
                              this.useController = 1;
                              uVar8 = uVar8 + 1;
                            }
                            else {
                              this.useTouch = 1;
                              uVar8 = uVar8 + 1;
                            }
                          }
                          else {
                            this.useMouse = 1;
                            uVar8 = uVar8 + 1;
                          }
                        }
                        else {
                          this.useController = 0;
                          uVar8 = uVar8 + 1;
                          *(uint8 *)(pStatics + 90) = 1;
                        }
                      }
                      else {
                        this.useTouch = 0;
                        uVar8 = uVar8 + 1;
                      }
                    }
                    else {
                      this.useMouse = 0;
        LAB_1815338c5:
                      uVar8 = uVar8 + 1;
                    }
                  }
                }
                return;
              }
            }
          }
        }
    }

    // Token : 0x6000725
    // RVA   : 0x15354B0   Offset: 0x15348B0   Length: 0x10A
    private void OnEnable()
    {
        var pStatics = *(int64*)(DAT_181daf678 + 184);
        long lVar1;
        ulong uVar2;
        if (*pStatics != 0) {
          FUN_181583c60(*pStatics,this,DAT_181da6738);
          lVar1 = *pStatics;
          uVar2 = new OnTooltipCB(0,DAT_181dc5ab8,DAT_181daab38);
          if (lVar1 != null) {
            FUN_181586650(lVar1,uVar2,DAT_181da6838);
            return;
          }
        }
    }

    // Token : 0x6000726
    // RVA   : 0x1535420   Offset: 0x1534820   Length: 0x81
    private void OnDisable()
    {
        var pStatics = *(int64*)(DAT_181daf678 + 184);
        if (*pStatics != 0) {
          FUN_181585c70(*pStatics,this,DAT_181da67b8);
          return;
        }
    }

    // Token : 0x6000727
    // RVA   : 0x153DBF0   Offset: 0x153CFF0   Length: 0x543
    private void Start()
    {
        var pStatics = *(int64*)(DAT_181daf678 + 184);
        bool cVar1;
        int iVar2;
        ulong uVar3;
        long lVar4;
        long lVar6;
        float fVar7;
        lVar4 = *pStatics;
        uVar3 = new OnTooltipCB(0,DAT_181dc5ab8,DAT_181daab38);
        if (lVar4 != null) {
          FUN_181586650(lVar4,uVar3,DAT_181da6838);
          if (this.eventType != null) {
            lVar4 = UICamera.get_cachedCamera(this,0);
            if (lVar4 == null) throw; // [null/range check failed]
            iVar2 = Camera.get_transparencySortMode(lVar4,0);
            if (iVar2 != 2) {
              lVar4 = UICamera.get_cachedCamera(this,0);
              if (lVar4 == null) throw; // [null/range check failed]
              Camera.set_transparencySortMode(lVar4,2);
            }
          }
          cVar1 = Application.get_isPlaying(0);
          if (!cVar1) {
            return;
          }
          uVar3 = *(uint64 *)(pStatics + 248);
          cVar1 = Object.op_Equality(uVar3,0,0);
          if (cVar1) {
            uVar3 = Component.get_gameObject(this,0);
            lVar4 = NGUITools.FindInParents(uVar3,DAT_181d8f820);
            cVar1 = Object.op_Inequality(lVar4,0,0);
            lVar6 = this;
            if ((cVar1) && (lVar6 = lVar4, lVar4 == null)) throw; // [null/range check failed]
            uVar3 = Component.get_gameObject(lVar6,0);
            puVar5 = (uint64 *)(pStatics + 248);
            *puVar5 = uVar3;
            il2cpp_internal(puVar5,uVar3);
          }
          lVar4 = UICamera.get_cachedCamera(this,0);
          if (lVar4 == null) throw; // [null/range check failed]
          Camera.set_eventMask(lVar4,0,0);
          if (*(char *)(pStatics + 90) != false) {
            return;
          }
          if (*(char *)(pStatics + 0x268) == false) {
            return;
          }
          if (!this.useController) {
            return;
          }
          cVar1 = UICamera.get_handlesEvents(this,0);
          if (!cVar1) {
            return;
          }
          *(uint8 *)(pStatics + 0x268) = 0;
          cVar1 = FUN_180d755b0(this.horizontalAxisName,0);
          if (!cVar1) {
            lVar4 = *(int64 *)(pStatics + 32);
            if (lVar4 == null) throw; // [null/range check failed]
            fVar7 = (float)GetAxisFunc.Invoke(lVar4,this.horizontalAxisName,0);
            if (0.1 < ABS(fVar7)) goto LAB_18153e0e1;
          }
          cVar1 = FUN_180d755b0(this.verticalAxisName,0);
          if (!cVar1) {
            lVar4 = *(int64 *)(pStatics + 32);
            if (lVar4 == null) throw; // [null/range check failed]
            fVar7 = (float)GetAxisFunc.Invoke(lVar4,this.verticalAxisName,0);
            if (0.1 < ABS(fVar7)) goto LAB_18153e0e1;
          }
          cVar1 = FUN_180d755b0(this.horizontalPanAxisName,0);
          if (!cVar1) {
            lVar4 = *(int64 *)(pStatics + 32);
            if (lVar4 == null) throw; // [null/range check failed]
            fVar7 = (float)GetAxisFunc.Invoke(lVar4,this.horizontalPanAxisName,0);
            if (0.1 < ABS(fVar7)) goto LAB_18153e0e1;
          }
          cVar1 = FUN_180d755b0(this.verticalPanAxisName,0);
          if (cVar1) {
            return;
          }
          lVar4 = *(int64 *)(pStatics + 32);
          if (lVar4 != null) {
            fVar7 = (float)GetAxisFunc.Invoke(lVar4,this.verticalPanAxisName,0);
            if (ABS(fVar7) <= 0.1) {
              return;
            }
        LAB_18153e0e1:
            *(uint8 *)(pStatics + 90) = 1;
            return;
          }
        }
    }

    // Token : 0x6000728
    // RVA   : 0x153DB90   Offset: 0x153CF90   Length: 0x58
    private void StartIgnoring()
    {
        *(uint8 *)(*(int64 *)(DAT_181daf678 + 184) + 89) = 1;
    }

    // Token : 0x6000729
    // RVA   : 0x153E140   Offset: 0x153D540   Length: 0x58
    private void StopIgnoring()
    {
        *(uint8 *)(*(int64 *)(DAT_181daf678 + 184) + 89) = 0;
    }

    // Token : 0x600072A
    // RVA   : 0x153E1A0   Offset: 0x153D5A0   Length: 0x83
    private void Update()
    {
        bool cVar1;
        if (*(char *)(*(int64 *)(DAT_181daf678 + 184) + 89) == false) {
          cVar1 = UICamera.get_handlesEvents(this,0);
          if ((cVar1) && (this.processEventsIn == null)) {
            UICamera.ProcessEvents(this,0);
            return;
          }
        }
    }

    // Token : 0x600072B
    // RVA   : 0x1534EC0   Offset: 0x15342C0   Length: 0x1A9
    private void LateUpdate()
    {
        var pStatics = *(int64*)(DAT_181daf678 + 184);
        long lVar1;
        bool cVar2;
        int iVar3;
        int iVar4;
        cVar2 = UICamera.get_handlesEvents(this,0);
        if (cVar2) {
          if (this.processEventsIn == 1) {
            UICamera.ProcessEvents(this,0);
          }
          iVar3 = Screen.get_width(0);
          iVar4 = Screen.get_height(0);
          if (iVar3 == *(int *)(pStatics + 0x1a8)) {
            if (iVar4 == *(int *)(pStatics + 0x1ac)) {
              return;
            }
          }
          *(int *)(pStatics + 0x1a8) = iVar3;
          *(int *)(pStatics + 0x1ac) = iVar4;
          UIRoot.Broadcast("UpdateAnchors",0);
          if (*(int64 *)(pStatics + 72) != 0) {
            lVar1 = *(int64 *)(pStatics + 72);
            if (lVar1 == null) {
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            OnGeometryUpdated.Invoke(lVar1,0);
          }
        }
    }

    // Token : 0x600072C
    // RVA   : 0x15355C0   Offset: 0x15349C0   Length: 0x7EE
    private void ProcessEvents()
    {
        var pStatics = *(int64*)(DAT_181daf678 + 184);
        byte uVar1;
        long lVar2;
        bool cVar3;
        int iVar4;
        ulong uVar5;
        ulong uVar6;
        float fVar9;
        float fVar10;
        float[] local_res8 = new float[2];
        plVar7 = (int64 *)(pStatics + 184);
        *plVar7 = this;
        il2cpp_internal(plVar7,this);
        uVar1 = this.debug;
        NGUIDebug.set_debugRaycast(uVar1,0);
        if (!this.useTouch) {
          if (this.useMouse) {
            UICamera.ProcessMouse(this,0);
          }
        }
        else {
          UICamera.ProcessTouches(this,0);
        }
        if (*(int64 *)(pStatics + 80) != 0) {
          lVar2 = *(int64 *)(pStatics + 80);
          if (lVar2 == null) goto LAB_181535d89;
          OnGeometryUpdated.Invoke(lVar2,0);
        }
        if ((this.useKeyboard) || (this.useController)) {
          cVar3 = UICamera.get_disableController(0);
          if (!cVar3) {
            if (*(char *)(pStatics + 90) == false) {
              UICamera.ProcessOthers(this,0);
            }
          }
        }
        if (this.useMouse) {
          uVar6 = *(uint64 *)(pStatics + 0x1e0);
          cVar3 = Object.op_Inequality(uVar6,0,0);
          if (!cVar3) goto LAB_181535c30;
          cVar3 = FUN_180d755b0(this.scrollAxisName,0);
          if (!cVar3) {
            lVar2 = *(int64 *)(pStatics + 32);
            if (lVar2 == null) goto LAB_181535d89;
            fVar9 = (float)GetAxisFunc.Invoke(lVar2,this.scrollAxisName,0);
            if (fVar9 != 0.0) {
              if (*(int64 *)(pStatics + 0x128) != 0) {
                lVar2 = *(int64 *)(pStatics + 0x128);
                if (lVar2 == null) goto LAB_181535d89;
                FloatDelegate.Invoke
                          (lVar2,*(uint64 *)(pStatics + 0x1e0),fVar9,0);
              }
              uVar6 = *(uint64 *)(pStatics + 0x1e0);
              local_res8[0] = fVar9;
              uVar5 = il2cpp_value_box(DAT_181da22d8,local_res8);
              UICamera.Notify(uVar6,"OnScroll",uVar5,0);
            }
          }
          iVar4 = UICamera.get_currentScheme(0);
          if (iVar4 == 0) {
            if (*(char *)(pStatics + 88) != false) {
              if (*(float *)(pStatics + 0x1b8) != 0.0) {
                cVar3 = UIPopupList.get_isOpen(0);
                if (!cVar3) {
                  lVar2 = *(int64 *)(pStatics + 0x188);
                  if (lVar2 != null) {
                    if (*(int *)(lVar2 + 24) == 0) {
                      uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                      FUN_1800d65f0(uVar6,0);
                    }
                    if (*(int64 *)(lVar2 + 32) != 0) {
                      uVar6 = *(uint64 *)(*(int64 *)(lVar2 + 32) + 88);
                      cVar3 = Object.op_Equality(uVar6,0,0);
                      if (!cVar3) goto LAB_181535c30;
                      fVar9 = *(float *)(pStatics + 0x1b8);
                      fVar10 = (float)Time.get_unscaledTime(0);
                      if (fVar10 <= fVar9) {
                        lVar2 = *(int64 *)(pStatics + 24);
                        if (lVar2 == null) goto LAB_181535d89;
                        cVar3 = GetKeyStateFunc.Invoke(lVar2,0x130,0);
                        if (!cVar3) {
                          lVar2 = *(int64 *)(pStatics + 24);
                          if (lVar2 == null) goto LAB_181535d89;
                          cVar3 = GetKeyStateFunc.Invoke(lVar2,0x12f,0);
                          if (!cVar3) goto LAB_181535c30;
                        }
                      }
                      lVar2 = *(int64 *)(pStatics + 0x188);
                      if (lVar2 != null) {
                        if (*(int *)(lVar2 + 24) == 0) {
                          uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                          FUN_1800d65f0(uVar6,0);
                        }
                        *(uint64 *)(pStatics + 224) =
                             *(uint64 *)(lVar2 + 32);
                        il2cpp_internal();
                        *(uint32 *)(pStatics + 212) = 0xffffffff;
                        UICamera.ShowTooltip
                                  (*(uint64 *)(pStatics + 0x1e0),0);
                        goto LAB_181535c30;
                      }
                    }
                  }
        LAB_181535d89:
                          // WARNING: Subroutine does not return
                  FUN_1800d6620();
                }
              }
            }
          }
        }
        LAB_181535c30:
        uVar6 = *(uint64 *)(pStatics + 0x1b0);
        cVar3 = Object.op_Inequality(uVar6,0,0);
        if (cVar3) {
          uVar6 = *(uint64 *)(pStatics + 0x1b0);
          cVar3 = NGUITools.GetActive(uVar6,0);
          if (!cVar3) {
            UICamera.ShowTooltip(0,0);
          }
        }
        puVar8 = (uint64 *)(pStatics + 184);
        *puVar8 = 0;
        il2cpp_internal(puVar8,0);
        *(uint32 *)(pStatics + 212) = 0xffffff9c;
    }

    // Token : 0x600072D
    // RVA   : 0x1536250   Offset: 0x1535650   Length: 0xFD7
    public void ProcessMouse()
    {
        var pStatics = *(int64*)(DAT_181daf678 + 184);
        long lVar2;
        long lVar3;
        ulong uVar4;
        bool cVar9;
        bool cVar11;
        bool cVar13;
        ulong uVar15;
        int iVar16;
        uint uVar17;
        uint uVar18;
        uint uVar19;
        float fVar20;
        float fVar21;
        uint uVar22;
        float local_98;
        float fStack_84;
        byte[] local_78 = new byte[64];
        bVar5 = false;
        bVar6 = false;
        iVar16 = 0;
        do {
          cVar9 = Input.GetMouseButtonDown(iVar16,0);
          if (!cVar9) {
            cVar9 = Input.GetMouseButton(iVar16);
            if (cVar9) {
              UICamera.set_currentKey(iVar16 + 0x143);
              bVar5 = true;
            }
          }
          else {
            UICamera.set_currentKey(iVar16 + 0x143);
            bVar6 = true;
            bVar5 = true;
          }
          iVar16 = iVar16 + 1;
        } while (iVar16 < 3);
        iVar16 = UICamera.get_currentScheme(0);
        if (iVar16 == 1) {
          lVar2 = *(int64 *)(pStatics + 0x198);
          if (lVar2 == null) throw; // [null/range check failed]
          if (0 < *(int *)(lVar2 + 24)) {
            return;
          }
        }
        lVar2 = *(int64 *)(pStatics + 0x188);
        if (lVar2 == null) throw; // [null/range check failed]
        if (*(int *)(lVar2 + 24) == 0) {
          uVar15 = il2cpp_internal();
                          // WARNING: Subroutine does not return
          FUN_1800d65f0(uVar15,0);
        }
        *(uint64 *)(pStatics + 224) = *(uint64 *)(lVar2 + 32);
        puVar14 = (uint64 *)Input.get_mousePosition(local_78,0);
        lVar2 = *(int64 *)(pStatics + 224);
        if (lVar2 == null) throw; // [null/range check failed]
        local_98 = (float)*puVar14;
        fStack_84 = (float)((uint64)*puVar14 >> 32);
        if (*(int *)(lVar2 + 120) == 0) {
          lVar2 = *(int64 *)(pStatics + 224);
          if (lVar2 == null) throw; // [null/range check failed]
          *(float *)(lVar2 + 36) = local_98 - *(float *)(lVar2 + 20);
          *(float *)(lVar2 + 40) = fStack_84 - *(float *)(lVar2 + 24);
        }
        else {
          lVar2 = *(int64 *)(pStatics + 224);
          if (lVar2 == null) throw; // [null/range check failed]
          piVar1 = (int *)(lVar2 + 120);
          *piVar1 = *piVar1 + -1;
          lVar2 = *(int64 *)(pStatics + 224);
          if (lVar2 == null) throw; // [null/range check failed]
          *(uint32 *)(lVar2 + 36) = 0;
          lVar2 = *(int64 *)(pStatics + 224);
          if (lVar2 == null) throw; // [null/range check failed]
          *(uint32 *)(lVar2 + 40) = 0;
        }
        lVar2 = *(int64 *)(pStatics + 224);
        if (lVar2 == null) throw; // [null/range check failed]
        fVar20 = (float)Vector2.get_sqrMagnitude(lVar2 + 36,0);
        lVar2 = *(int64 *)(pStatics + 224);
        if (lVar2 == null) throw; // [null/range check failed]
        *(float *)(lVar2 + 20) = local_98;
        bVar7 = false;
        *(float *)(lVar2 + 24) = fStack_84;
        lVar2 = pStatics;
        *(float *)(lVar2 + 92) = local_98;
        *(float *)(lVar2 + 96) = fStack_84;
        iVar16 = UICamera.get_currentScheme(0);
        if (iVar16 == 0) {
          if (0.001 >= fVar20)
          {
            }
            else {
            if (fVar20 < 0.001) {
            return;
            }
            UICamera.set_currentKey(0x143,0);
          }
          bVar7 = true;
        }
        uVar19 = 1;
        uVar18 = 1;
        uVar17 = 1;
        do {
          lVar2 = *(int64 *)(pStatics + 0x188);
          if (lVar2 == null) throw; // [null/range check failed]
          if (*(uint32 *)(lVar2 + 24) <= uVar17) {
            uVar15 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar15,0);
          }
          lVar3 = *(int64 *)(pStatics + 224);
          if (lVar3 == null) throw; // [null/range check failed]
          uVar22 = *(uint32 *)(lVar3 + 24);
          lVar2 = lVar2[uVar17];
          if (lVar2 == null) throw; // [null/range check failed]
          *(uint32 *)(lVar2 + 20) = *(uint32 *)(lVar3 + 20);
          *(uint32 *)(lVar2 + 24) = uVar22;
          lVar2 = *(int64 *)(pStatics + 0x188);
          if (lVar2 == null) throw; // [null/range check failed]
          if (*(uint32 *)(lVar2 + 24) <= uVar17) {
            uVar15 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar15,0);
          }
          lVar3 = *(int64 *)(pStatics + 224);
          if (lVar3 == null) throw; // [null/range check failed]
          uVar22 = *(uint32 *)(lVar3 + 40);
          lVar2 = lVar2[uVar17];
          if (lVar2 == null) throw; // [null/range check failed]
          uVar17 = uVar17 + 1;
          *(uint32 *)(lVar2 + 36) = *(uint32 *)(lVar3 + 36);
          *(uint32 *)(lVar2 + 40) = uVar22;
        } while ((int)uVar17 < 3);
        if ((bVar7 || bVar5) ||
           (fVar20 = this.mNextRaycast, fVar21 = (float)RealTime.get_time(0), fVar20 < fVar21))
        {
          fVar20 = (float)RealTime.get_time(0);
          this.mNextRaycast = fVar20 + 0.02;
          UICamera.Raycast(*(uint64 *)(pStatics + 224),0);
          if (bVar5) {
            bVar7 = true;
            do {
              lVar2 = *(int64 *)(pStatics + 0x188);
              if (lVar2 == null) throw; // [null/range check failed]
              if (*(uint32 *)(lVar2 + 24) <= uVar18) {
                uVar15 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar15,0);
              }
              lVar3 = *(int64 *)(pStatics + 224);
              if (lVar3 == null) throw; // [null/range check failed]
              lVar2 = lVar2[uVar18];
              if (lVar2 == null) throw; // [null/range check failed]
              *(uint64 *)(lVar2 + 72) = *(uint64 *)(lVar3 + 72);
              uVar18 = uVar18 + 1;
            } while ((int)uVar18 < 3);
          }
          else {
            lVar2 = *(int64 *)(pStatics + 0x188);
            if (lVar2 == null) throw; // [null/range check failed]
            if (*(int *)(lVar2 + 24) == 0) {
              uVar15 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar15,0);
            }
            if (*(int64 *)(lVar2 + 32) == 0) throw; // [null/range check failed]
            lVar3 = *(int64 *)(pStatics + 224);
            uVar15 = *(uint64 *)(*(int64 *)(lVar2 + 32) + 72);
            if (lVar3 == null) throw; // [null/range check failed]
            uVar4 = *(uint64 *)(lVar3 + 72);
            cVar9 = Object.op_Inequality(uVar15,uVar4,0);
            if (cVar9) {
              UICamera.set_currentKey(0x143,0);
              bVar7 = true;
              uVar17 = 1;
              do {
                lVar2 = *(int64 *)(pStatics + 0x188);
                if (lVar2 == null) throw; // [null/range check failed]
                if (*(uint32 *)(lVar2 + 24) <= uVar17) {
                  uVar15 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1800d65f0(uVar15,0);
                }
                lVar3 = *(int64 *)(pStatics + 224);
                if (lVar3 == null) throw; // [null/range check failed]
                lVar2 = lVar2[uVar17];
                if (lVar2 == null) throw; // [null/range check failed]
                *(uint64 *)(lVar2 + 72) = *(uint64 *)(lVar3 + 72);
                uVar17 = uVar17 + 1;
              } while ((int)uVar17 < 3);
            }
          }
        }
        lVar2 = *(int64 *)(pStatics + 224);
        if (lVar2 != null) {
          uVar15 = *(uint64 *)(lVar2 + 64);
          uVar4 = *(uint64 *)(lVar2 + 72);
          bVar10 = Object.op_Inequality(uVar15,uVar4,0);
          lVar2 = *(int64 *)(pStatics + 224);
          if (lVar2 != null) {
            cVar9 = Object.op_Inequality(*(uint64 *)(lVar2 + 80),0,0);
            bVar8 = false;
            if (!cVar9) {
              bVar8 = bVar7;
            }
            if (bVar8) {
              lVar2 = *(int64 *)(pStatics + 224);
              if (lVar2 == null) throw; // [null/range check failed]
              UICamera.set_hoveredObject(*(uint64 *)(lVar2 + 72),0);
            }
            *(uint32 *)(pStatics + 212) = 0xffffffff;
            if (bVar10 != 0) {
              UICamera.set_currentKey(0x143,0);
            }
            if ((bool)(bVar7 & !bVar5)) {
              if (*(float *)(pStatics + 0x1b8) == 0.0) {
                uVar15 = *(uint64 *)(pStatics + 0x1b0);
                cVar11 = Object.op_Inequality(uVar15,0,0);
                if (cVar11) {
                  bVar12 = bVar10;
                  if (!this.stickyTooltip) {
                    bVar12 = 1;
                  }
                  if (bVar12 != 0) {
                    UICamera.ShowTooltip(0,0);
                  }
                }
              }
              else {
                fVar21 = (float)Time.get_unscaledTime(0);
                fVar20 = this.tooltipDelay;
                *(float *)(pStatics + 0x1b8) = fVar20 + fVar21;
              }
            }
            if (bVar7) {
              if (*(int64 *)(pStatics + 0x180) != 0) {
                lVar2 = *(int64 *)(pStatics + 224);
                lVar3 = *(int64 *)(pStatics + 0x180);
                if ((lVar2 == null) || (lVar3 == null)) throw; // [null/range check failed]
                MoveDelegate.Invoke(lVar3,*(uint64 *)(lVar2 + 36),0);
                puVar14 = (uint64 *)(pStatics + 224);
                *puVar14 = 0;
                il2cpp_internal(puVar14,0);
              }
            }
            if ((bVar10 != 0) && ((bVar6 || ((cVar9 && (!bVar5)))))) {
              UICamera.set_hoveredObject(0,0);
            }
            uVar17 = 0;
            do {
              cVar9 = Input.GetMouseButtonDown(uVar17,0);
              cVar11 = Input.GetMouseButtonUp(uVar17,0);
              if (cVar11 || cVar9) {
                UICamera.set_currentKey(uVar17 + 0x143,0);
              }
              lVar2 = *(int64 *)(pStatics + 0x188);
              if (lVar2 == null) throw; // [null/range check failed]
              if (*(uint32 *)(lVar2 + 24) <= uVar17) {
                uVar15 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar15,0);
              }
              *(uint64 *)(pStatics + 224) =
                   lVar2[uVar17];
              il2cpp_internal();
              *(uint32 *)(pStatics + 212) = ~uVar17;
              UICamera.set_currentKey(uVar17 + 0x143,0);
              if (!cVar9) {
                lVar2 = *(int64 *)(pStatics + 224);
                if (lVar2 == null) throw; // [null/range check failed]
                uVar15 = *(uint64 *)(lVar2 + 80);
                cVar13 = Object.op_Inequality(uVar15,0,0);
                if (cVar13) {
                  lVar2 = *(int64 *)(pStatics + 224);
                  if (lVar2 == null) throw; // [null/range check failed]
                  *(uint64 *)(pStatics + 192) =
                       *(uint64 *)(lVar2 + 56);
                  il2cpp_internal();
                }
              }
              else {
                lVar2 = *(int64 *)(pStatics + 224);
                if (lVar2 == null) throw; // [null/range check failed]
                *(uint64 *)(lVar2 + 56) =
                     *(uint64 *)(pStatics + 192);
                il2cpp_internal();
                lVar2 = *(int64 *)(pStatics + 224);
                uVar22 = RealTime.get_time(0);
                if (lVar2 == null) throw; // [null/range check failed]
                *(uint32 *)(lVar2 + 104) = uVar22;
              }
              UICamera.ProcessTouch(this,cVar9,cVar11,0);
              uVar17 = uVar17 + 1;
            } while ((int)uVar17 < 3);
            if ((!bVar5 & bVar10) != 0) {
              lVar2 = *(int64 *)(pStatics + 0x188);
              if (lVar2 == null) throw; // [null/range check failed]
              if (*(int *)(lVar2 + 24) == 0) {
                uVar15 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar15,0);
              }
              *(uint64 *)(pStatics + 224) = *(uint64 *)(lVar2 + 32);
              fVar20 = (float)Time.get_unscaledTime(0);
              *(float *)(pStatics + 0x1b8) =
                   fVar20 + this.tooltipDelay;
              *(uint32 *)(pStatics + 212) = 0xffffffff;
              UICamera.set_currentKey(0x143,0);
              lVar2 = *(int64 *)(pStatics + 224);
              if (lVar2 == null) throw; // [null/range check failed]
              UICamera.set_hoveredObject(*(uint64 *)(lVar2 + 72),0);
            }
            puVar14 = (uint64 *)(pStatics + 224);
            *puVar14 = 0;
            il2cpp_internal(puVar14,0);
            lVar2 = *(int64 *)(pStatics + 0x188);
            if (lVar2 != null) {
              if (*(int *)(lVar2 + 24) == 0) {
                uVar15 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar15,0);
              }
              lVar2 = *(int64 *)(lVar2 + 32);
              if (lVar2 != null) {
                *(uint64 *)(lVar2 + 64) = *(uint64 *)(lVar2 + 72);
                while( true ) {
                  lVar2 = *(int64 *)(pStatics + 0x188);
                  if (lVar2 == null) break;
                  if (*(uint32 *)(lVar2 + 24) <= uVar19) {
                    uVar15 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                    FUN_1800d65f0(uVar15,0);
                  }
                  if (*(uint32 *)(lVar2 + 24) == 0) {
                    uVar15 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                    FUN_1800d65f0(uVar15,0);
                  }
                  if (*(int64 *)(lVar2 + 32) == 0) break;
                  lVar3 = lVar2[uVar19];
                  if (lVar3 == null) break;
                  *(uint64 *)(lVar3 + 64) = *(uint64 *)(*(int64 *)(lVar2 + 32) + 64);
                  uVar19 = uVar19 + 1;
                  if (2 < (int)uVar19) {
                    return;
                  }
                }
              }
            }
          }
        }
    }

    // Token : 0x600072E
    // RVA   : 0x153AD70   Offset: 0x153A170   Length: 0x75E
    public void ProcessTouches()
    {
        var pStatics = *(int64*)(DAT_181daf678 + 184);
        bool cVar1;
        int iVar2;
        int iVar3;
        int iVar4;
        long lVar5;
        ulong uVar6;
        uint uVar8;
        int iVar9;
        uint uVar12;
        float fVar13;
        float local_res18;
        ulong local_e8;
        ulong uStack_e0;
        ulong local_d8;
        ulong uStack_d0;
        ulong local_c8;
        ulong uStack_c0;
        ulong local_b8;
        ulong uStack_b0;
        uint local_a8;
        byte[] local_98 = new byte[112];
        local_e8 = 0;
        uStack_e0 = 0;
        local_a8 = 0;
        local_d8 = 0;
        uStack_d0 = 0;
        local_c8 = 0;
        uStack_c0 = 0;
        local_b8 = 0;
        uStack_b0 = 0;
        if (*(int64 *)(pStatics + 0x270) == 0) {
          iVar2 = Input.get_touchCount(0);
        }
        else {
          lVar5 = *(int64 *)(pStatics + 0x270);
          if (lVar5 == null) {
        LAB_18153b4c9:
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          iVar2 = GetTouchCountCallback.Invoke(lVar5,0);
        }
        iVar9 = 0;
        if (iVar2 < 1) {
          if (iVar2 == 0) {
            if (*(char *)(pStatics + 0x269) == false) {
              if (!this.useMouse) {
                return;
              }
              UICamera.ProcessMouse(this,0);
              return;
            }
            *(uint8 *)(pStatics + 0x269) = 0;
            return;
          }
        }
        else {
          do {
            if (*(int64 *)(pStatics + 0x278) == 0) {
              puVar7 = (uint64 *)Input.GetTouch(local_98,iVar9,0);
              local_e8 = *puVar7;
              uStack_e0 = puVar7[1];
              local_d8 = puVar7[2];
              uStack_d0 = puVar7[3];
              local_c8 = puVar7[4];
              uStack_c0 = puVar7[5];
              local_b8 = puVar7[6];
              uStack_b0 = puVar7[7];
              local_a8 = *(uint32 *)(puVar7 + 8);
              iVar3 = Touch.get_phase(&local_e8,0);
              uVar12 = FUN_18044e2c0(&local_e8,0);
              uVar6 = Touch.get_position(&local_e8,0);
              iVar4 = FUN_180464570(&local_e8,0);
              fVar13 = (float)((uint64)uVar6 >> 32);
              local_res18 = (float)uVar6;
            }
            else {
              lVar5 = *(int64 *)(pStatics + 0x278);
              if ((lVar5 == null) || (lVar5 = GetTouchCallback.Invoke(lVar5,iVar9,0)) == null)
              goto LAB_18153b4c9;
              iVar3 = *(int *)(lVar5 + 20);
              uVar12 = *(uint32 *)(lVar5 + 16);
              local_res18 = *(float *)(lVar5 + 24);
              fVar13 = *(float *)(lVar5 + 28);
              iVar4 = *(int *)(lVar5 + 32);
            }
            uVar8 = 1;
            if (this.allowMultiTouch) {
              uVar8 = uVar12;
            }
            *(uint32 *)(pStatics + 212) = uVar8;
            lVar5 = *(int64 *)(pStatics + 56);
            if (lVar5 == null) goto LAB_18153b4c9;
            uVar6 = GetTouchDelegate.Invoke
                              (lVar5,*(uint32 *)(pStatics + 212),1,0);
            puVar7 = (uint64 *)(pStatics + 224);
            *puVar7 = uVar6;
            il2cpp_internal(puVar7,uVar6);
            if (iVar3 == 0) {
              cVar1 = true;
              bVar11 = true;
        LAB_18153b05e:
              bVar10 = iVar3 == 3;
            }
            else {
              lVar5 = *(int64 *)(pStatics + 224);
              if (lVar5 == null) goto LAB_18153b4c9;
              cVar1 = *(char *)(lVar5 + 116);
              bVar11 = cVar1;
              if (iVar3 != 4) goto LAB_18153b05e;
              bVar10 = true;
            }
            lVar5 = *(int64 *)(pStatics + 224);
            if (lVar5 == null) goto LAB_18153b4c9;
            *(float *)(lVar5 + 36) = local_res18 - *(float *)(lVar5 + 20);
            *(float *)(lVar5 + 40) = fVar13 - *(float *)(lVar5 + 24);
            lVar5 = *(int64 *)(pStatics + 224);
            if (lVar5 == null) goto LAB_18153b4c9;
            *(float *)(lVar5 + 20) = local_res18;
            *(float *)(lVar5 + 24) = fVar13;
            UICamera.set_currentKey(0,0);
            UICamera.Raycast(*(uint64 *)(pStatics + 224),0);
            if (!cVar1) {
              lVar5 = *(int64 *)(pStatics + 224);
              if (lVar5 == null) goto LAB_18153b4c9;
              uVar6 = *(uint64 *)(lVar5 + 80);
              cVar1 = Object.op_Inequality(uVar6,0,0);
              if (cVar1) {
                lVar5 = *(int64 *)(pStatics + 224);
                if (lVar5 != null) {
                  uVar6 = *(uint64 *)(lVar5 + 56);
                  puVar7 = (uint64 *)(pStatics + 192);
                  goto LAB_18153b260;
                }
                goto LAB_18153b4c9;
              }
            }
            else {
              lVar5 = *(int64 *)(pStatics + 224);
              uVar6 = *(uint64 *)(pStatics + 192);
              if (lVar5 == null) goto LAB_18153b4c9;
              puVar7 = (uint64 *)(lVar5 + 56);
        LAB_18153b260:
              *puVar7 = uVar6;
              il2cpp_internal();
            }
            if (1 < iVar4) {
              lVar5 = *(int64 *)(pStatics + 224);
              uVar12 = RealTime.get_time(0);
              if (lVar5 == null) goto LAB_18153b4c9;
              *(uint32 *)(lVar5 + 108) = uVar12;
            }
            UICamera.ProcessTouch(this,bVar11);
            if (bVar10) {
              lVar5 = *(int64 *)(pStatics + 64);
              if (lVar5 == null) goto LAB_18153b4c9;
              RemoveTouchDelegate.Invoke
                        (lVar5,*(uint32 *)(pStatics + 212));
            }
            lVar5 = *(int64 *)(pStatics + 224);
            if (lVar5 == null) goto LAB_18153b4c9;
            *(uint8 *)(lVar5 + 116) = 0;
            lVar5 = *(int64 *)(pStatics + 224);
            if (lVar5 == null) goto LAB_18153b4c9;
            puVar7 = (uint64 *)(lVar5 + 64);
            *puVar7 = 0;
            il2cpp_internal(puVar7,0);
            puVar7 = (uint64 *)(pStatics + 224);
            *puVar7 = 0;
            il2cpp_internal(puVar7,0);
          } while ((this.allowMultiTouch) && (iVar9 = iVar9 + 1, iVar9 < iVar2));
        }
        *(uint8 *)(pStatics + 0x269) = 1;
    }

    // Token : 0x600072F
    // RVA   : 0x1535DB0   Offset: 0x15351B0   Length: 0x496
    private void ProcessFakeTouches()
    {
        var pStatics = *(int64*)(DAT_181daf678 + 184);
        long lVar1;
        bool cVar2;
        bool cVar3;
        bool cVar4;
        ulong uVar6;
        uint uVar7;
        float local_38;
        float fStack_24;
        byte[] local_18 = new byte[16];
        cVar2 = Input.GetMouseButtonDown(0,0);
        cVar3 = Input.GetMouseButtonUp(0,0);
        cVar4 = Input.GetMouseButton(0,0);
        if ((!cVar4 && !cVar3) && !cVar2) {
          return;
        }
        *(uint32 *)(pStatics + 212) = 1;
        lVar1 = *(int64 *)(pStatics + 0x188);
        if (lVar1 == null) throw; // [null/range check failed]
        if (*(int *)(lVar1 + 24) == 0) {
          uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
          FUN_1800d65f0(uVar6,0);
        }
        *(uint64 *)(pStatics + 224) = *(uint64 *)(lVar1 + 32);
        lVar1 = *(int64 *)(pStatics + 224);
        if (lVar1 == null) throw; // [null/range check failed]
        *(char *)(lVar1 + 116) = cVar2;
        if (cVar2) {
          lVar1 = *(int64 *)(pStatics + 224);
          uVar7 = RealTime.get_time(0);
          if (lVar1 == null) throw; // [null/range check failed]
          *(uint32 *)(lVar1 + 104) = uVar7;
          lVar1 = *(int64 *)(pStatics + 0x198);
          if (lVar1 == null) throw; // [null/range check failed]
          FUN_18181e0a0(lVar1,*(uint64 *)(pStatics + 224),DAT_181db3fb8);
        }
        puVar5 = (uint64 *)Input.get_mousePosition(local_18,0);
        uVar6 = *puVar5;
        lVar1 = *(int64 *)(pStatics + 224);
        if (lVar1 == null) throw; // [null/range check failed]
        local_38 = (float)uVar6;
        fStack_24 = (float)((uint64)uVar6 >> 32);
        *(float *)(lVar1 + 36) = local_38 - *(float *)(lVar1 + 20);
        *(float *)(lVar1 + 40) = fStack_24 - *(float *)(lVar1 + 24);
        lVar1 = *(int64 *)(pStatics + 224);
        if (lVar1 == null) throw; // [null/range check failed]
        *(float *)(lVar1 + 20) = local_38;
        *(float *)(lVar1 + 24) = fStack_24;
        UICamera.Raycast(*(uint64 *)(pStatics + 224),0);
        if (!cVar2) {
          lVar1 = *(int64 *)(pStatics + 224);
          if (lVar1 == null) throw; // [null/range check failed]
          uVar6 = *(uint64 *)(lVar1 + 80);
          cVar4 = Object.op_Inequality(uVar6,0,0);
          if (cVar4) {
            lVar1 = *(int64 *)(pStatics + 224);
            if (lVar1 == null) throw; // [null/range check failed]
            uVar6 = *(uint64 *)(lVar1 + 56);
            puVar5 = (uint64 *)(pStatics + 192);
            goto LAB_18153611a;
          }
        }
        else {
          lVar1 = *(int64 *)(pStatics + 224);
          uVar6 = *(uint64 *)(pStatics + 192);
          if (lVar1 == null) throw; // [null/range check failed]
          puVar5 = (uint64 *)(lVar1 + 56);
        LAB_18153611a:
          *puVar5 = uVar6;
          il2cpp_internal();
        }
        UICamera.set_currentKey(0,0);
        UICamera.ProcessTouch(this,cVar2,cVar3,0);
        if (cVar3) {
          lVar1 = *(int64 *)(pStatics + 0x198);
          if (lVar1 == null) throw; // [null/range check failed]
          FUN_1817eee00(lVar1,*(uint64 *)(pStatics + 224),DAT_181db4040);
        }
        lVar1 = *(int64 *)(pStatics + 224);
        if (lVar1 != null) {
          puVar5 = (uint64 *)(lVar1 + 64);
          *puVar5 = 0;
          il2cpp_internal(puVar5,0);
          puVar5 = (uint64 *)(pStatics + 224);
          *puVar5 = 0;
          il2cpp_internal(puVar5,0);
          return;
        }
    }

    // Token : 0x6000730
    // RVA   : 0x1537230   Offset: 0x1536630   Length: 0x1133
    public void ProcessOthers()
    {
        var plVar9 = *(int64*)(lVar9 + 184);
        var pStatics = *(int64*)(DAT_181daf678 + 184);
        int iVar1;
        long lVar2;
        bool cVar3;
        bool cVar4;
        int iVar5;
        int iVar6;
        ulong uVar7;
        ulong uVar8;
        long lVar9;
        long lVar11;
        uint uVar12;
        bool cVar13;
        uint uVar14;
        float fVar15;
        float fVar16;
        float fVar17;
        ulong local_res8;
        *(uint32 *)(pStatics + 212) = 0xffffff9c;
        *(uint64 *)(pStatics + 224) =
             *(uint64 *)(pStatics + 400);
        il2cpp_internal();
        iVar5 = this.submitKey0;
        cVar13 = false;
        cVar4 = false;
        if (iVar5 == 0) {
        LAB_181537389:
          iVar5 = this.submitKey1;
          if (iVar5 != 0) {
            if (((*(byte *)(DAT_181daf678 + 0x133) & 4) != 0) && (*(int *)(DAT_181daf678 + 224) == 0)) {
              il2cpp_runtime_class_init(DAT_181daf678);
              iVar5 = this.submitKey1;
            }
            lVar9 = *(int64 *)(pStatics + 8);
            if (lVar9 == null) goto LAB_181538336;
            cVar3 = GetKeyStateFunc.Invoke(lVar9,iVar5,0);
            if (!cVar3) goto LAB_1815373e9;
            uVar14 = this.submitKey1;
            goto LAB_181537448;
          }
        LAB_1815373e9:
          if ((this.submitKey0 == 13) || (this.submitKey1 == 13)) {
            lVar9 = *(int64 *)(pStatics + 8);
            if (lVar9 == null) goto LAB_181538336;
            cVar3 = GetKeyStateFunc.Invoke(lVar9,0x10f,0);
            if (cVar3) goto LAB_181537445;
          }
        }
        else {
          if (((*(byte *)(DAT_181daf678 + 0x133) & 4) != 0) && (*(int *)(DAT_181daf678 + 224) == 0)) {
            il2cpp_runtime_class_init(DAT_181daf678);
            iVar5 = this.submitKey0;
          }
          lVar9 = *(int64 *)(pStatics + 8);
          if (lVar9 == null) goto LAB_181538336;
          cVar3 = GetKeyStateFunc.Invoke(lVar9,iVar5,0);
          if (!cVar3) goto LAB_181537389;
        LAB_181537445:
          uVar14 = this.submitKey0;
        LAB_181537448:
          UICamera.set_currentKey(uVar14,0);
          cVar13 = true;
        }
        iVar5 = this.submitKey0;
        if (iVar5 == 0) {
        LAB_1815374c8:
          iVar5 = this.submitKey1;
          if (iVar5 != 0) {
            if (((*(byte *)(DAT_181daf678 + 0x133) & 4) != 0) && (*(int *)(DAT_181daf678 + 224) == 0)) {
              il2cpp_runtime_class_init(DAT_181daf678);
              iVar5 = this.submitKey1;
            }
            lVar9 = *(int64 *)(pStatics + 16);
            if (lVar9 == null) goto LAB_181538336;
            cVar3 = GetKeyStateFunc.Invoke(lVar9,iVar5,0);
            if (!cVar3) goto LAB_181537528;
            uVar14 = this.submitKey1;
            goto LAB_181537587;
          }
        LAB_181537528:
          if ((this.submitKey0 == 13) || (this.submitKey1 == 13)) {
            lVar9 = *(int64 *)(pStatics + 16);
            if (lVar9 == null) goto LAB_181538336;
            cVar3 = GetKeyStateFunc.Invoke(lVar9,0x10f,0);
            if (cVar3) goto LAB_181537584;
          }
        }
        else {
          if (((*(byte *)(DAT_181daf678 + 0x133) & 4) != 0) && (*(int *)(DAT_181daf678 + 224) == 0)) {
            il2cpp_runtime_class_init(DAT_181daf678);
            iVar5 = this.submitKey0;
          }
          lVar9 = *(int64 *)(pStatics + 16);
          if (lVar9 == null) goto LAB_181538336;
          cVar3 = GetKeyStateFunc.Invoke(lVar9,iVar5,0);
          if (!cVar3) goto LAB_1815374c8;
        LAB_181537584:
          uVar14 = this.submitKey0;
        LAB_181537587:
          UICamera.set_currentKey(uVar14,0);
          cVar4 = true;
        }
        if (cVar13) {
          lVar9 = *(int64 *)(pStatics + 224);
          uVar14 = RealTime.get_time(0);
          if (lVar9 == null) goto LAB_181538336;
          *(uint32 *)(lVar9 + 104) = uVar14;
        }
        if (cVar4 || cVar13) {
          iVar5 = UICamera.get_currentScheme(0);
          if (iVar5 == 2) {
            lVar9 = *(int64 *)(pStatics + 224);
            uVar7 = UICamera.get_controllerNavigationObject(0);
            if (lVar9 == null) goto LAB_181538336;
            puVar10 = (uint64 *)(lVar9 + 72);
            *puVar10 = uVar7;
            il2cpp_internal(puVar10,uVar7);
            UICamera.ProcessTouch(this,cVar13,cVar4,0);
            lVar9 = *(int64 *)(pStatics + 224);
            if (lVar9 == null) goto LAB_181538336;
            *(uint64 *)(lVar9 + 64) = *(uint64 *)(lVar9 + 72);
          }
        }
        iVar6 = 0;
        iVar5 = 0;
        if (this.useController) {
          iVar5 = 0;
          if (*(char *)(pStatics + 90) == false) {
            cVar4 = UICamera.get_disableController(0);
            if (!cVar4) {
              iVar5 = UICamera.get_currentScheme(0);
              if (iVar5 == 2) {
                lVar9 = *(int64 *)(pStatics + 224);
                if (lVar9 == null) goto LAB_181538336;
                uVar7 = *(uint64 *)(lVar9 + 72);
                cVar4 = Object.op_Equality(uVar7,0,0);
                if (!cVar4) {
                  lVar9 = *(int64 *)(pStatics + 224);
                  if ((lVar9 == null) || (lVar9 = *(int64 *)(lVar9 + 72)) == null)
                  goto LAB_181538336;
                  cVar4 = GameObject.get_activeInHierarchy(lVar9,0);
                  if (cVar4) goto LAB_181537887;
                }
                lVar9 = *(int64 *)(pStatics + 224);
                uVar7 = UICamera.get_controllerNavigationObject(0);
                if (lVar9 == null) goto LAB_181538336;
                puVar10 = (uint64 *)(lVar9 + 72);
                *puVar10 = uVar7;
                il2cpp_internal(puVar10,uVar7);
              }
            }
        LAB_181537887:
            cVar4 = FUN_180d755b0(this.verticalAxisName,0);
            iVar5 = iVar6;
            if (!cVar4) {
              uVar7 = this.verticalAxisName;
              iVar6 = UICamera.GetDirection(uVar7,0);
              if (iVar6 != 0) {
                UICamera.ShowTooltip(0,0);
                UICamera.set_currentScheme(2);
                lVar9 = *(int64 *)(pStatics + 224);
                uVar7 = UICamera.get_controllerNavigationObject(0);
                if (lVar9 == null) goto LAB_181538336;
                puVar10 = (uint64 *)(lVar9 + 72);
                *puVar10 = uVar7;
                il2cpp_internal(puVar10,uVar7);
                lVar9 = *(int64 *)(pStatics + 224);
                if (lVar9 == null) goto LAB_181538336;
                uVar7 = *(uint64 *)(lVar9 + 72);
                cVar4 = Object.op_Inequality(uVar7,0,0);
                if (cVar4) {
                  iVar5 = (iVar6 < 1) + 0x111;
                  if (*(int64 *)(pStatics + 0x168) != 0) {
                    lVar9 = *(int64 *)(pStatics + 224);
                    lVar11 = *(int64 *)(pStatics + 0x168);
                    if ((lVar9 == null) || (lVar11 == null)) goto LAB_181538336;
                    KeyCodeDelegate.Invoke(lVar11,*(uint64 *)(lVar9 + 72),iVar5,0);
                  }
                  lVar9 = *(int64 *)(pStatics + 224);
                  if (lVar9 == null) {
                          // WARNING: Subroutine does not return
                    FUN_1800d6620();
                  }
                  uVar7 = *(uint64 *)(lVar9 + 72);
                  local_res8 = CONCAT44(local_res8._4_4_,iVar5);
                  uVar8 = il2cpp_value_box(DAT_181d84298,&local_res8);
                  UICamera.Notify(uVar7,"OnNavigate",uVar8,0);
                }
              }
            }
            cVar4 = FUN_180d755b0(this.horizontalAxisName,0);
            if (!cVar4) {
              uVar7 = this.horizontalAxisName;
              iVar6 = UICamera.GetDirection(uVar7,0);
              if (iVar6 != 0) {
                UICamera.ShowTooltip(0,0);
                UICamera.set_currentScheme(2);
                lVar9 = *(int64 *)(pStatics + 224);
                uVar7 = UICamera.get_controllerNavigationObject(0);
                if (lVar9 == null) goto LAB_181538336;
                puVar10 = (uint64 *)(lVar9 + 72);
                *puVar10 = uVar7;
                il2cpp_internal(puVar10,uVar7);
                lVar9 = *(int64 *)(pStatics + 224);
                if (lVar9 == null) goto LAB_181538336;
                uVar7 = *(uint64 *)(lVar9 + 72);
                cVar4 = Object.op_Inequality(uVar7,0,0);
                if (cVar4) {
                  iVar5 = (iVar6 < 1) + 0x113;
                  if (*(int64 *)(pStatics + 0x168) != 0) {
                    lVar9 = *(int64 *)(pStatics + 224);
                    lVar11 = *(int64 *)(pStatics + 0x168);
                    if ((lVar9 == null) || (lVar11 == null)) goto LAB_181538336;
                    KeyCodeDelegate.Invoke(lVar11,*(uint64 *)(lVar9 + 72),iVar5,0);
                  }
                  lVar9 = *(int64 *)(pStatics + 224);
                  if (lVar9 == null) {
                          // WARNING: Subroutine does not return
                    FUN_1800d6620();
                  }
                  uVar7 = *(uint64 *)(lVar9 + 72);
                  local_res8 = CONCAT44(local_res8._4_4_,iVar5);
                  uVar8 = il2cpp_value_box(DAT_181d84298,&local_res8);
                  UICamera.Notify(uVar7,"OnNavigate",uVar8,0);
                }
              }
            }
            cVar4 = FUN_180d755b0(this.horizontalPanAxisName,0);
            if (!cVar4) {
              lVar9 = *(int64 *)(pStatics + 32);
              if (lVar9 == null) goto LAB_181538336;
              fVar15 = (float)GetAxisFunc.Invoke(lVar9,this.horizontalPanAxisName,0);
            }
            else {
              fVar15 = 0.0;
            }
            cVar4 = FUN_180d755b0(this.verticalPanAxisName,0);
            if (!cVar4) {
              lVar9 = *(int64 *)(pStatics + 32);
              if (lVar9 == null) goto LAB_181538336;
              fVar16 = (float)GetAxisFunc.Invoke(lVar9,this.verticalPanAxisName,0);
            }
            else {
              fVar16 = 0.0;
            }
            if ((fVar15 != 0.0) || (fVar16 != 0.0)) {
              UICamera.ShowTooltip(0,0);
              if (*(int *)(pStatics + 208) != 2) {
                UICamera.set_currentKey(0x14a,0);
                *(uint32 *)(pStatics + 208) = 2;
              }
              lVar9 = *(int64 *)(pStatics + 224);
              uVar7 = UICamera.get_controllerNavigationObject(0);
              if (lVar9 == null) goto LAB_181538336;
              puVar10 = (uint64 *)(lVar9 + 72);
              *puVar10 = uVar7;
              il2cpp_internal(puVar10,uVar7);
              lVar9 = *(int64 *)(pStatics + 224);
              if (lVar9 == null) goto LAB_181538336;
              uVar7 = *(uint64 *)(lVar9 + 72);
              cVar4 = Object.op_Inequality(uVar7,0,0);
              if (cVar4) {
                fVar17 = (float)Time.get_unscaledDeltaTime(0);
                local_res8 = CONCAT44(fVar17 * fVar16,fVar17 * fVar15);
                uVar7 = local_res8;
                if (*(int64 *)(pStatics + 0x170) != 0) {
                  lVar9 = *(int64 *)(pStatics + 224);
                  lVar11 = *(int64 *)(pStatics + 0x170);
                  if ((lVar9 == null) || (lVar11 == null)) goto LAB_181538336;
                  VectorDelegate.Invoke(lVar11,*(uint64 *)(lVar9 + 72),uVar7,0);
                }
                lVar9 = *(int64 *)(pStatics + 224);
                if (lVar9 == null) {
                          // WARNING: Subroutine does not return
                  FUN_1800d6620();
                }
                uVar8 = *(uint64 *)(lVar9 + 72);
                local_res8 = uVar7;
                uVar7 = il2cpp_value_box(DAT_181db3950,&local_res8);
                UICamera.Notify(uVar8,"OnPan",uVar7,0);
              }
            }
          }
        }
        if (*(int64 *)(pStatics + 40) == 0) {
          cVar4 = Input.get_anyKeyDown(0);
        }
        else {
          lVar9 = *(int64 *)(pStatics + 40);
          if (lVar9 == null) goto LAB_181538336;
          cVar4 = GetAnyKeyFunc.Invoke(lVar9,0);
        }
        lVar9 = DAT_181daf678;
        if (cVar4) {
          uVar12 = 0;
          lVar9 = *(int64 *)(*(int64 *)(DAT_181d8bd10 + 184) + 56);
          if (lVar9 == null) {
        LAB_181538336:
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          iVar6 = *(int *)(lVar9 + 24);
          lVar9 = DAT_181daf678;
          lVar11 = DAT_181d8bd10;
          if (0 < iVar6) {
            do {
              if (((*(byte *)(lVar11 + 0x133) & 4) != 0) && (*(int *)(lVar11 + 224) == 0)) {
                il2cpp_runtime_class_init(lVar11);
                lVar9 = DAT_181daf678;
                lVar11 = DAT_181d8bd10;
              }
              lVar2 = *(int64 *)(*(int64 *)(lVar11 + 184) + 56);
              if (lVar2 == null) goto LAB_181538336;
              if (*(uint32 *)(lVar2 + 24) <= uVar12) {
                uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar7,0);
              }
              iVar1 = lVar2[uVar12];
              if (iVar5 != iVar1) {
                if (((*(byte *)(lVar9 + 0x133) & 4) != 0) && (*(int *)(lVar9 + 224) == 0)) {
                  il2cpp_runtime_class_init();
                  lVar9 = DAT_181daf678;
                }
                lVar9 = *(int64 *)(plVar9 + 8);
                if (lVar9 == null) goto LAB_181538336;
                cVar4 = GetKeyStateFunc.Invoke(lVar9,iVar1,0);
                lVar9 = DAT_181daf678;
                lVar11 = DAT_181d8bd10;
                if ((cVar4) && ((this.useKeyboard || (0x142 < iVar1)))) {
                  if (!this.useController) {
        LAB_181538197:
                    lVar9 = DAT_181daf678;
                    lVar11 = DAT_181d8bd10;
                    if (0x149 < iVar1) goto LAB_1815382bc;
                  }
                  else {
                    if (*(char *)(pStatics + 90) != false) goto LAB_181538197;
                  }
                  if ((this.useMouse) ||
                     (lVar9 = DAT_181daf678, lVar11 = DAT_181d8bd10, 6 < iVar1 - 0x143U)) {
                    UICamera.set_currentKey(iVar1,0);
                    if (*(int64 *)(pStatics + 0x160) != 0) {
                      lVar9 = *(int64 *)(pStatics + 224);
                      lVar11 = *(int64 *)(pStatics + 0x160);
                      if ((lVar9 == null) || (lVar11 == null)) goto LAB_181538336;
                      KeyCodeDelegate.Invoke(lVar11,*(uint64 *)(lVar9 + 72),iVar1,0);
                    }
                    lVar9 = *(int64 *)(pStatics + 224);
                    if (lVar9 == null) {
                          // WARNING: Subroutine does not return
                      FUN_1800d6620();
                    }
                    uVar7 = *(uint64 *)(lVar9 + 72);
                    local_res8 = CONCAT44(local_res8._4_4_,iVar1);
                    uVar8 = il2cpp_value_box(DAT_181d84298,&local_res8);
                    UICamera.Notify(uVar7,"OnKey",uVar8);
                    lVar9 = DAT_181daf678;
                    lVar11 = DAT_181d8bd10;
                  }
                }
              }
        LAB_1815382bc:
              uVar12 = uVar12 + 1;
            } while ((int)uVar12 < iVar6);
          }
        }
        if (((*(byte *)(lVar9 + 0x133) & 4) != 0) && (*(int *)(lVar9 + 224) == 0)) {
          il2cpp_runtime_class_init();
          lVar9 = DAT_181daf678;
        }
        puVar10 = (uint64 *)(plVar9 + 224);
        *puVar10 = 0;
        il2cpp_internal(puVar10,0);
    }

    // Token : 0x6000731
    // RVA   : 0x1538370   Offset: 0x1537770   Length: 0x1794
    private void ProcessPress(bool pressed, float click, float drag)
    {
        var pStatics = *(int64*)(DAT_181daf678 + 184);
        long lVar1;
        bool cVar3;
        byte uVar4;
        int iVar5;
        ulong uVar6;
        long lVar7;
        ulong uVar8;
        ulong uVar9;
        float fVar10;
        float fVar11;
        byte[] local_res10 = new byte[8];
        ulong local_48;
        if (pressed) {
          uVar8 = *(uint64 *)(pStatics + 0x1b0);
          cVar3 = Object.op_Inequality(uVar8,0,0);
          if (cVar3) {
            UICamera.ShowTooltip(0,0);
          }
          fVar11 = (float)Time.get_unscaledTime(0);
          fVar10 = this.tooltipDelay;
          *(float *)(pStatics + 0x1b8) = fVar10 + fVar11;
          lVar7 = *(int64 *)(pStatics + 224);
          if (lVar7 != null) {
            *(uint8 *)(lVar7 + 117) = 1;
            if (*(int64 *)(pStatics + 0x118) != 0) {
              lVar7 = *(int64 *)(pStatics + 224);
              if (lVar7 == null) throw; // [null/range check failed]
              uVar8 = *(uint64 *)(lVar7 + 80);
              cVar3 = Object.op_Implicit(uVar8,0);
              if (cVar3) {
                lVar7 = *(int64 *)(pStatics + 224);
                lVar1 = *(int64 *)(pStatics + 0x118);
                if ((lVar7 == null) || (lVar1 == null)) throw; // [null/range check failed]
                OnTooltipCB.Invoke(lVar1,*(uint64 *)(lVar7 + 80),0,0);
              }
            }
            lVar7 = *(int64 *)(pStatics + 224);
            if (lVar7 == null) {
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            uVar8 = *(uint64 *)(lVar7 + 80);
            local_res10[0] = 0;
            uVar6 = il2cpp_value_box(DAT_181db2ac8,local_res10);
            UICamera.Notify(uVar8,"OnPress",uVar6,0);
            iVar5 = UICamera.get_currentScheme(0);
            if (iVar5 == 0) {
              uVar8 = UICamera.get_hoveredObject(0);
              cVar3 = Object.op_Equality(uVar8,0,0);
              if (cVar3) {
                lVar7 = *(int64 *)(pStatics + 224);
                if (lVar7 == null) throw; // [null/range check failed]
                uVar8 = *(uint64 *)(lVar7 + 72);
                cVar3 = Object.op_Inequality(uVar8,0,0);
                if (cVar3) {
                  lVar7 = *(int64 *)(pStatics + 224);
                  if (lVar7 == null) throw; // [null/range check failed]
                  UICamera.set_hoveredObject(*(uint64 *)(lVar7 + 72),0);
                }
              }
            }
            lVar7 = *(int64 *)(pStatics + 224);
            if (lVar7 != null) {
              *(uint64 *)(lVar7 + 80) = *(uint64 *)(lVar7 + 72);
              lVar7 = *(int64 *)(pStatics + 224);
              if (lVar7 != null) {
                *(uint64 *)(lVar7 + 88) = *(uint64 *)(lVar7 + 72);
                lVar7 = *(int64 *)(pStatics + 224);
                if (lVar7 != null) {
                  *(uint32 *)(lVar7 + 112) = 2;
                  lVar7 = *(int64 *)(pStatics + 224);
                  uVar8 = Vector2.get_zero(0);
                  local_48 = uVar8;
                  if (lVar7 != null) {
                    local_48._0_4_ = (uint32)uVar8;
                    local_48._4_4_ = (uint32)((uint64)uVar8 >> 32);
                    *(uint32 *)(lVar7 + 44) = (uint32)local_48;
                    *(uint32 *)(lVar7 + 48) = local_48._4_4_;
                    lVar7 = *(int64 *)(pStatics + 224);
                    if (lVar7 != null) {
                      *(uint8 *)(lVar7 + 118) = 0;
                      if (*(int64 *)(pStatics + 0x118) != 0) {
                        lVar7 = *(int64 *)(pStatics + 224);
                        if (lVar7 == null) throw; // [null/range check failed]
                        uVar8 = *(uint64 *)(lVar7 + 80);
                        cVar3 = Object.op_Implicit(uVar8,0);
                        if (cVar3) {
                          lVar7 = *(int64 *)(pStatics + 224);
                          lVar1 = *(int64 *)(pStatics + 0x118);
                          if ((lVar7 == null) || (lVar1 == null)) throw; // [null/range check failed]
                          OnTooltipCB.Invoke(lVar1,*(uint64 *)(lVar7 + 80),1,0);
                        }
                      }
                      lVar7 = *(int64 *)(pStatics + 224);
                      if (lVar7 != null) {
                        uVar8 = *(uint64 *)(lVar7 + 80);
                        local_res10[0] = 1;
                        uVar6 = il2cpp_value_box(DAT_181db2ac8,local_res10);
                        UICamera.Notify(uVar8,"OnPress",uVar6,0);
                        lVar7 = *(int64 *)(pStatics + 224);
                        uVar8 = *(uint64 *)(pStatics + 0x1e8);
                        if (lVar7 != null) {
                          uVar6 = *(uint64 *)(lVar7 + 80);
                          cVar3 = Object.op_Inequality(uVar8,uVar6,0);
                          if (!cVar3) {
                            return;
                          }
                          *(uint8 *)(pStatics + 232) = 0;
                          uVar8 = *(uint64 *)(pStatics + 0x1e8);
                          cVar3 = Object.op_Implicit(uVar8,0);
                          if (cVar3) {
                            uVar8 = *(uint64 *)(pStatics + 0x1e8);
                            local_res10[0] = 0;
                            uVar6 = il2cpp_value_box(DAT_181db2ac8,local_res10);
                            UICamera.Notify(uVar8,"OnSelect",uVar6,0);
                            if (*(int64 *)(pStatics + 0x120) != 0) {
                              lVar7 = *(int64 *)(pStatics + 0x120);
                              if (lVar7 == null) throw; // [null/range check failed]
                              OnTooltipCB.Invoke(lVar7,*(uint64 *)
                                                         (pStatics + 0x1e8),0,0
                                                 );
                            }
                          }
                          lVar7 = *(int64 *)(pStatics + 224);
                          if (lVar7 != null) {
                            *(uint64 *)(pStatics + 0x1e8) =
                                 *(uint64 *)(lVar7 + 80);
                            il2cpp_internal();
                            lVar7 = *(int64 *)(pStatics + 224);
                            if (lVar7 != null) {
                              uVar8 = *(uint64 *)(lVar7 + 80);
                              cVar3 = Object.op_Inequality(uVar8,0,0);
                              if (cVar3) {
                                lVar7 = *(int64 *)(pStatics + 224);
                                if ((lVar7 == null) || (lVar7 = *(int64 *)(lVar7 + 80)) == null)
                                throw; // [null/range check failed]
                                uVar8 = GameObject.GetComponent(lVar7,DAT_181d74a10);
                                cVar3 = Object.op_Inequality(uVar8,0,0);
                                if (cVar3) {
                                  lVar7 = *(int64 *)(pStatics + 224);
                                  lVar1 = *(int64 *)(pStatics + 400);
                                  if ((lVar7 == null) || (lVar1 == null)) throw; // [null/range check failed]
                                  *(uint64 *)(lVar1 + 72) = *(uint64 *)(lVar7 + 80);
                                }
                              }
                              uVar8 = *(uint64 *)(pStatics + 0x1e8);
                              cVar3 = Object.op_Implicit(uVar8,0);
                              if (!cVar3) {
                                return;
                              }
                              lVar7 = *(int64 *)(pStatics + 0x1e8);
                              if (lVar7 != null) {
                                cVar3 = GameObject.get_activeInHierarchy(lVar7,0);
                                if (!cVar3) {
                                  uVar4 = 0;
                                }
                                else {
                                  lVar7 = *(int64 *)(pStatics + 0x1e8);
                                  if (lVar7 == null) throw; // [null/range check failed]
                                  uVar8 = GameObject.GetComponent(lVar7,DAT_181d74988);
                                  uVar4 = Object.op_Inequality(uVar8,0,0);
                                }
                                *(uint8 *)(pStatics + 232) = uVar4;
                                if (*(int64 *)(pStatics + 0x120) != 0) {
                                  lVar7 = *(int64 *)(pStatics + 0x120);
                                  if (lVar7 == null) throw; // [null/range check failed]
                                  OnTooltipCB.Invoke(lVar7,*(uint64 *)
                                                             (pStatics + 0x1e8)
                                                      ,1,0);
                                }
                                uVar8 = *(uint64 *)(pStatics + 0x1e8);
                                local_res10[0] = 1;
                                uVar6 = il2cpp_value_box(DAT_181db2ac8,local_res10);
                                UICamera.Notify(uVar8,"OnSelect",uVar6,0);
                                return;
                              }
                            }
                          }
                          throw; // [null/range check failed]
                        }
                      }
                          // WARNING: Subroutine does not return
                      FUN_1800d6620();
                    }
                  }
                }
              }
            }
          }
          throw; // [null/range check failed]
        }
        lVar7 = *(int64 *)(pStatics + 224);
        if (lVar7 == null) throw; // [null/range check failed]
        uVar8 = *(uint64 *)(lVar7 + 80);
        cVar3 = Object.op_Inequality(uVar8,0,0);
        if (!cVar3) {
          return;
        }
        lVar7 = *(int64 *)(pStatics + 224);
        if (lVar7 == null) throw; // [null/range check failed]
        fVar10 = (float)Vector2.get_sqrMagnitude(lVar7 + 36,0);
        if (fVar10 == 0.0) {
          lVar7 = *(int64 *)(pStatics + 224);
          if (lVar7 == null) throw; // [null/range check failed]
          uVar8 = *(uint64 *)(lVar7 + 72);
          uVar6 = *(uint64 *)(lVar7 + 64);
          cVar3 = Object.op_Inequality(uVar8,uVar6,0);
          if (!cVar3) {
            return;
          }
        }
        lVar7 = *(int64 *)(pStatics + 224);
        if (lVar7 == null) throw; // [null/range check failed]
        *(float *)(lVar7 + 44) = *(float *)(lVar7 + 36) + *(float *)(lVar7 + 44);
        *(float *)(lVar7 + 48) = *(float *)(lVar7 + 40) + *(float *)(lVar7 + 48);
        lVar7 = *(int64 *)(pStatics + 224);
        if (lVar7 == null) throw; // [null/range check failed]
        fVar10 = (float)Vector2.get_sqrMagnitude(lVar7 + 44,0);
        bVar2 = false;
        lVar7 = *(int64 *)(pStatics + 224);
        if (lVar7 == null) throw; // [null/range check failed]
        if (*(char *)(lVar7 + 118) == false) {
          lVar7 = *(int64 *)(pStatics + 224);
          if (lVar7 == null) throw; // [null/range check failed]
          uVar8 = *(uint64 *)(lVar7 + 64);
          uVar6 = *(uint64 *)(lVar7 + 72);
          cVar3 = Object.op_Inequality(uVar8,uVar6,0);
          if (!cVar3) goto LAB_181538905;
          lVar7 = *(int64 *)(pStatics + 224);
          if (lVar7 == null) throw; // [null/range check failed]
          *(uint8 *)(lVar7 + 118) = 1;
          lVar7 = *(int64 *)(pStatics + 224);
          if (lVar7 == null) throw; // [null/range check failed]
          *(uint32 *)(lVar7 + 36) = *(uint32 *)(lVar7 + 44);
          *(uint32 *)(lVar7 + 40) = *(uint32 *)(lVar7 + 48);
          lVar7 = *(int64 *)(pStatics + 224);
          if (lVar7 == null) throw; // [null/range check failed]
          *(uint32 *)(lVar7 + 112) = 0;
          *(uint8 *)(pStatics + 0x1bc) = 1;
          if (*(int64 *)(pStatics + 0x138) != 0) {
            lVar7 = *(int64 *)(pStatics + 224);
            lVar1 = *(int64 *)(pStatics + 0x138);
            if ((lVar7 == null) || (lVar1 == null)) throw; // [null/range check failed]
            VoidDelegate.Invoke(lVar1,*(uint64 *)(lVar7 + 88),0);
          }
          lVar7 = *(int64 *)(pStatics + 224);
          if (lVar7 == null) throw; // [null/range check failed]
          UICamera.Notify(*(uint64 *)(lVar7 + 88),"OnDragStart",0,0);
          if (*(int64 *)(pStatics + 0x140) != 0) {
            lVar7 = *(int64 *)(pStatics + 224);
            lVar1 = *(int64 *)(pStatics + 0x140);
            if ((lVar7 == null) || (lVar1 == null)) throw; // [null/range check failed]
            ObjectDelegate.Invoke(lVar1,*(uint64 *)(lVar7 + 64),*(uint64 *)(lVar7 + 88),0);
          }
          lVar7 = *(int64 *)(pStatics + 224);
          if (lVar7 == null) throw; // [null/range check failed]
          UICamera.Notify(*(uint64 *)(lVar7 + 64),"OnDragOver",*(uint64 *)(lVar7 + 88),0);
          *(uint8 *)(pStatics + 0x1bc) = 0;
        }
        else {
        LAB_181538905:
          lVar7 = *(int64 *)(pStatics + 224);
          if (lVar7 == null) throw; // [null/range check failed]
          if ((*(char *)(lVar7 + 118) == false) && (drag < fVar10)) {
            bVar2 = true;
            lVar7 = *(int64 *)(pStatics + 224);
            if (lVar7 == null) throw; // [null/range check failed]
            *(uint8 *)(lVar7 + 118) = 1;
            lVar7 = *(int64 *)(pStatics + 224);
            if (lVar7 == null) throw; // [null/range check failed]
            *(uint32 *)(lVar7 + 36) = *(uint32 *)(lVar7 + 44);
            *(uint32 *)(lVar7 + 40) = *(uint32 *)(lVar7 + 48);
          }
        }
        lVar7 = *(int64 *)(pStatics + 224);
        if (lVar7 == null) throw; // [null/range check failed]
        if (*(char *)(lVar7 + 118) == false) {
          return;
        }
        uVar8 = *(uint64 *)(pStatics + 0x1b0);
        cVar3 = Object.op_Inequality(uVar8,0,0);
        if (cVar3) {
          UICamera.ShowTooltip(0,0);
        }
        *(uint8 *)(pStatics + 0x1bc) = 1;
        lVar7 = *(int64 *)(pStatics + 224);
        if (lVar7 == null) throw; // [null/range check failed]
        iVar5 = *(int *)(lVar7 + 112);
        if (bVar2) {
          if (*(int64 *)(pStatics + 0x138) != 0) {
            lVar7 = *(int64 *)(pStatics + 224);
            lVar1 = *(int64 *)(pStatics + 0x138);
            if ((lVar7 == null) || (lVar1 == null)) throw; // [null/range check failed]
            VoidDelegate.Invoke(lVar1,*(uint64 *)(lVar7 + 88),0);
          }
          lVar7 = *(int64 *)(pStatics + 224);
          if (lVar7 == null) throw; // [null/range check failed]
          uVar8 = 0;
          uVar6 = *(uint64 *)(lVar7 + 88);
          uVar9 = "OnDragStart";
        LAB_181538cf1:
          UICamera.Notify(uVar6,uVar9,uVar8,0);
          if (*(int64 *)(pStatics + 0x140) != 0) {
            lVar7 = *(int64 *)(pStatics + 224);
            lVar1 = *(int64 *)(pStatics + 0x140);
            if ((lVar7 == null) || (lVar1 == null)) throw; // [null/range check failed]
            ObjectDelegate.Invoke(lVar1,*(uint64 *)(lVar7 + 64),*(uint64 *)(lVar7 + 88),0);
          }
          lVar7 = *(int64 *)(pStatics + 224);
          if (lVar7 == null) throw; // [null/range check failed]
          UICamera.Notify(*(uint64 *)(lVar7 + 72),"OnDragOver",*(uint64 *)(lVar7 + 88),0);
        }
        else {
          lVar7 = *(int64 *)(pStatics + 224);
          if (lVar7 == null) throw; // [null/range check failed]
          uVar8 = *(uint64 *)(lVar7 + 64);
          uVar6 = *(uint64 *)(lVar7 + 72);
          cVar3 = Object.op_Inequality(uVar8,uVar6,0);
          if (cVar3) {
            if (*(int64 *)(pStatics + 0x148) != 0) {
              lVar7 = *(int64 *)(pStatics + 224);
              lVar1 = *(int64 *)(pStatics + 0x148);
              if ((lVar7 == null) || (lVar1 == null)) throw; // [null/range check failed]
              ObjectDelegate.Invoke(lVar1,*(uint64 *)(lVar7 + 64),*(uint64 *)(lVar7 + 88),0);
            }
            lVar7 = *(int64 *)(pStatics + 224);
            if (lVar7 == null) throw; // [null/range check failed]
            uVar8 = *(uint64 *)(lVar7 + 88);
            uVar6 = *(uint64 *)(lVar7 + 64);
            uVar9 = "OnDragOut";
            goto LAB_181538cf1;
          }
        }
        if (*(int64 *)(pStatics + 0x130) != 0) {
          lVar7 = *(int64 *)(pStatics + 224);
          lVar1 = *(int64 *)(pStatics + 0x130);
          if ((lVar7 == null) || (local_48 = *(uint64 *)(lVar7 + 36), lVar1 == null)) throw; // [null/range check failed]
          VectorDelegate.Invoke(lVar1,*(uint64 *)(lVar7 + 88),local_48,0);
        }
        lVar7 = *(int64 *)(pStatics + 224);
        if (lVar7 == null) {
        LAB_181539af3:
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
        uVar8 = *(uint64 *)(lVar7 + 88);
        local_48 = *(uint64 *)(lVar7 + 36);
        uVar6 = il2cpp_value_box(DAT_181db3950,&local_48);
        UICamera.Notify(uVar8,"OnDrag",uVar6,0);
        lVar7 = *(int64 *)(pStatics + 224);
        if (lVar7 == null) goto LAB_181539af3;
        *(uint64 *)(lVar7 + 64) = *(uint64 *)(lVar7 + 72);
        *(uint8 *)(pStatics + 0x1bc) = 0;
        if (iVar5 == 0) {
          lVar7 = pStatics;
        }
        else {
          lVar7 = *(int64 *)(pStatics + 224);
          if (lVar7 == null) throw; // [null/range check failed]
          if (*(int *)(lVar7 + 112) != 2) {
            return;
          }
          if (fVar10 <= click) {
            return;
          }
          lVar7 = pStatics;
        }
        if (*(int64 *)(lVar7 + 224) != 0) {
          *(uint32 *)(*(int64 *)(lVar7 + 224) + 112) = 0;
          return;
        }
    }

    // Token : 0x6000732
    // RVA   : 0x1539B10   Offset: 0x1538F10   Length: 0xE00
    private void ProcessRelease(bool isMouse, float drag)
    {
        var pStatics = *(int64*)(DAT_181daf678 + 184);
        ulong uVar1;
        bool cVar2;
        int iVar3;
        ulong uVar4;
        long lVar5;
        long lVar6;
        float fVar8;
        byte[] local_28 = new byte[32];
        if (*(int64 *)(pStatics + 224) == 0) {
          return;
        }
        lVar6 = *(int64 *)(pStatics + 224);
        if (lVar6 == null) throw; // [null/range check failed]
        *(uint8 *)(lVar6 + 117) = 0;
        lVar6 = *(int64 *)(pStatics + 224);
        if (lVar6 == null) throw; // [null/range check failed]
        uVar1 = *(uint64 *)(lVar6 + 80);
        cVar2 = Object.op_Inequality(uVar1,0,0);
        if (cVar2) {
          lVar6 = *(int64 *)(pStatics + 224);
          if (lVar6 == null) throw; // [null/range check failed]
          if (*(char *)(lVar6 + 118) != false) {
            if (*(int64 *)(pStatics + 0x148) != 0) {
              lVar6 = *(int64 *)(pStatics + 224);
              lVar5 = *(int64 *)(pStatics + 0x148);
              if ((lVar6 == null) || (lVar5 == null)) throw; // [null/range check failed]
              ObjectDelegate.Invoke(lVar5,*(uint64 *)(lVar6 + 64),*(uint64 *)(lVar6 + 88),0);
            }
            lVar6 = *(int64 *)(pStatics + 224);
            if (lVar6 == null) throw; // [null/range check failed]
            UICamera.Notify(*(uint64 *)(lVar6 + 64),"OnDragOut",*(uint64 *)(lVar6 + 88),0);
            if (*(int64 *)(pStatics + 0x150) != 0) {
              lVar6 = *(int64 *)(pStatics + 224);
              lVar5 = *(int64 *)(pStatics + 0x150);
              if ((lVar6 == null) || (lVar5 == null)) throw; // [null/range check failed]
              VoidDelegate.Invoke(lVar5,*(uint64 *)(lVar6 + 88),0);
            }
            lVar6 = *(int64 *)(pStatics + 224);
            if (lVar6 == null) throw; // [null/range check failed]
            UICamera.Notify(*(uint64 *)(lVar6 + 88),"OnDragEnd",0,0);
          }
          if (*(int64 *)(pStatics + 0x118) != 0) {
            lVar6 = *(int64 *)(pStatics + 224);
            lVar5 = *(int64 *)(pStatics + 0x118);
            if ((lVar6 == null) || (lVar5 == null)) throw; // [null/range check failed]
            OnTooltipCB.Invoke(lVar5,*(uint64 *)(lVar6 + 80),0,0);
          }
          lVar6 = *(int64 *)(pStatics + 224);
          if (lVar6 == null) {
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          uVar1 = *(uint64 *)(lVar6 + 80);
          local_28[0] = 0;
          uVar4 = il2cpp_value_box(DAT_181db2ac8,local_28);
          UICamera.Notify(uVar1,"OnPress",uVar4,0);
          if (isMouse) {
            lVar6 = *(int64 *)(pStatics + 224);
            if (lVar6 == null) throw; // [null/range check failed]
            lVar6 = *(int64 *)(lVar6 + 80);
            cVar2 = Object.op_Equality(lVar6,0,0);
            if (!cVar2) {
              if (lVar6 == null) throw; // [null/range check failed]
              lVar5 = GameObject.GetComponent(lVar6,DAT_181dc80c8);
              cVar2 = Object.op_Inequality(lVar5,0,0);
              if (!cVar2) {
                lVar6 = GameObject.GetComponent(lVar6,DAT_181dc8150);
                cVar2 = Object.op_Inequality(lVar6,0,0);
                if (!cVar2) goto LAB_18153a17d;
                if (lVar6 == null) throw; // [null/range check failed]
                cVar2 = Behaviour.get_enabled(lVar6,0);
              }
              else {
                if (lVar5 == null) throw; // [null/range check failed]
                cVar2 = Collider.get_enabled(lVar5,0);
              }
              if (cVar2) {
                lVar6 = *(int64 *)(pStatics + 224);
                uVar1 = *(uint64 *)(pStatics + 0x1e0);
                if (lVar6 == null) throw; // [null/range check failed]
                uVar4 = *(uint64 *)(lVar6 + 72);
                cVar2 = Object.op_Equality(uVar1,uVar4,0);
                if (!cVar2) {
                  lVar6 = *(int64 *)(pStatics + 224);
                  if (lVar6 == null) throw; // [null/range check failed]
                  UICamera.set_hoveredObject(*(uint64 *)(lVar6 + 72),0);
                }
                else {
                  if (*(int64 *)(pStatics + 0x110) != 0) {
                    lVar6 = *(int64 *)(pStatics + 224);
                    lVar5 = *(int64 *)(pStatics + 0x110);
                    if ((lVar6 == null) || (lVar5 == null)) throw; // [null/range check failed]
                    OnTooltipCB.Invoke(lVar5,*(uint64 *)(lVar6 + 72),1,0);
                  }
                  lVar6 = *(int64 *)(pStatics + 224);
                  if (lVar6 == null) {
                          // WARNING: Subroutine does not return
                    FUN_1800d6620();
                  }
                  uVar1 = *(uint64 *)(lVar6 + 72);
                  local_28[0] = 1;
                  uVar4 = il2cpp_value_box(DAT_181db2ac8,local_28);
                  UICamera.Notify(uVar1,"OnHover",uVar4,0);
                }
              }
            }
          }
        LAB_18153a17d:
          lVar6 = *(int64 *)(pStatics + 224);
          if (lVar6 == null) throw; // [null/range check failed]
          uVar1 = *(uint64 *)(lVar6 + 88);
          uVar4 = *(uint64 *)(lVar6 + 72);
          cVar2 = Object.op_Equality(uVar1,uVar4,0);
          if (!cVar2) {
            iVar3 = UICamera.get_currentScheme(0);
            if (iVar3 != 2) {
              lVar6 = *(int64 *)(pStatics + 224);
              if (lVar6 == null) throw; // [null/range check failed]
              if (*(int *)(lVar6 + 112) != 0) {
                lVar6 = *(int64 *)(pStatics + 224);
                if (lVar6 == null) throw; // [null/range check failed]
                fVar8 = (float)Vector2.get_sqrMagnitude(lVar6 + 44,0);
                if (fVar8 < drag) goto LAB_18153a572;
              }
            }
            lVar6 = *(int64 *)(pStatics + 224);
            if (lVar6 == null) throw; // [null/range check failed]
            if (*(char *)(lVar6 + 118) != false) {
              if (*(int64 *)(pStatics + 0x158) != 0) {
                lVar6 = *(int64 *)(pStatics + 224);
                lVar5 = *(int64 *)(pStatics + 0x158);
                if ((lVar6 == null) || (lVar5 == null)) throw; // [null/range check failed]
                ObjectDelegate.Invoke
                          (lVar5,*(uint64 *)(lVar6 + 72),*(uint64 *)(lVar6 + 88),0);
              }
              lVar6 = *(int64 *)(pStatics + 224);
              if (lVar6 == null) throw; // [null/range check failed]
              UICamera.Notify(*(uint64 *)(lVar6 + 72),"OnDrop",*(uint64 *)(lVar6 + 88),0
                              );
            }
          }
          else {
        LAB_18153a572:
            lVar6 = *(int64 *)(pStatics + 224);
            if (lVar6 == null) throw; // [null/range check failed]
            if (*(int *)(lVar6 + 112) != 0) {
              lVar6 = *(int64 *)(pStatics + 224);
              if (lVar6 == null) throw; // [null/range check failed]
              uVar1 = *(uint64 *)(lVar6 + 80);
              uVar4 = *(uint64 *)(lVar6 + 72);
              cVar2 = Object.op_Equality(uVar1,uVar4,0);
              if (cVar2) {
                UICamera.ShowTooltip(0,0);
                fVar8 = (float)RealTime.get_time(0);
                if (*(int64 *)(pStatics + 0x100) != 0) {
                  lVar6 = *(int64 *)(pStatics + 224);
                  lVar5 = *(int64 *)(pStatics + 0x100);
                  if ((lVar6 == null) || (lVar5 == null)) throw; // [null/range check failed]
                  VoidDelegate.Invoke(lVar5,*(uint64 *)(lVar6 + 80),0);
                }
                lVar6 = *(int64 *)(pStatics + 224);
                if (lVar6 == null) throw; // [null/range check failed]
                UICamera.Notify(*(uint64 *)(lVar6 + 80),"OnClick",0,0);
                lVar6 = *(int64 *)(pStatics + 224);
                if (lVar6 == null) throw; // [null/range check failed]
                if (fVar8 < *(float *)(lVar6 + 108) + 0.35) {
                  lVar6 = *(int64 *)(pStatics + 224);
                  if (lVar6 == null) throw; // [null/range check failed]
                  uVar1 = *(uint64 *)(lVar6 + 96);
                  uVar4 = *(uint64 *)(lVar6 + 80);
                  cVar2 = Object.op_Equality(uVar1,uVar4,0);
                  if (cVar2) {
                    if (*(int64 *)(pStatics + 0x108) != 0) {
                      lVar6 = *(int64 *)(pStatics + 224);
                      lVar5 = *(int64 *)(pStatics + 0x108);
                      if ((lVar6 == null) || (lVar5 == null)) throw; // [null/range check failed]
                      VoidDelegate.Invoke(lVar5,*(uint64 *)(lVar6 + 80),0);
                    }
                    lVar6 = *(int64 *)(pStatics + 224);
                    if (lVar6 == null) throw; // [null/range check failed]
                    UICamera.Notify(*(uint64 *)(lVar6 + 80),"OnDoubleClick",0,0);
                  }
                }
                lVar6 = *(int64 *)(pStatics + 224);
                if (lVar6 == null) throw; // [null/range check failed]
                *(uint64 *)(lVar6 + 96) = *(uint64 *)(lVar6 + 80);
                lVar6 = *(int64 *)(pStatics + 224);
                if (lVar6 == null) throw; // [null/range check failed]
                *(float *)(lVar6 + 108) = fVar8;
              }
            }
          }
        }
        lVar6 = *(int64 *)(pStatics + 224);
        if (lVar6 != null) {
          *(uint8 *)(lVar6 + 118) = 0;
          lVar6 = *(int64 *)(pStatics + 224);
          if (lVar6 != null) {
            puVar7 = (uint64 *)(lVar6 + 80);
            *puVar7 = 0;
            il2cpp_internal(puVar7,0);
            lVar6 = *(int64 *)(pStatics + 224);
            if (lVar6 != null) {
              puVar7 = (uint64 *)(lVar6 + 88);
              *puVar7 = 0;
              il2cpp_internal(puVar7,0);
              return;
            }
          }
        }
    }

    // Token : 0x6000733
    // RVA   : 0x1534690   Offset: 0x1533A90   Length: 0x14A
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

    // Token : 0x6000734
    // RVA   : 0x153A920   Offset: 0x1539D20   Length: 0x440
    public void ProcessTouch(bool pressed, bool released)
    {
        var pStatics = *(int64*)(DAT_181daf678 + 184);
        long lVar1;
        ulong uVar2;
        ulong uVar3;
        bool cVar4;
        int iVar5;
        float fVar7;
        float fVar8;
        if (released) {
          *(uint32 *)(pStatics + 0x1b8) = 0;
        }
        iVar5 = UICamera.get_currentScheme(0);
        bVar6 = iVar5 == 0;
        if (iVar5 == 0) {
          fVar7 = this.mouseDragThreshold;
          fVar8 = this.mouseClickThreshold;
        }
        else {
          fVar7 = this.touchDragThreshold;
          fVar8 = this.touchClickThreshold;
        }
        fVar7 = fVar7 * fVar7;
        lVar1 = *(int64 *)(pStatics + 224);
        if (lVar1 == null) goto LAB_18153ad5b;
        uVar2 = *(uint64 *)(lVar1 + 80);
        cVar4 = Object.op_Inequality(uVar2,0,0);
        if (!cVar4) {
          if (((bVar6 || pressed) || released) &&
             (UICamera.ProcessPress(this,pressed,fVar8 * fVar8,fVar7,0), released)) {
            UICamera.ProcessRelease(this,bVar6,fVar7,0);
          }
        }
        else {
          if (released) {
            UICamera.ProcessRelease(this,bVar6,fVar7,0);
          }
          UICamera.ProcessPress(this,pressed,fVar8 * fVar8,fVar7,0);
          if (this.tooltipDelay != null.0) {
            lVar1 = *(int64 *)(pStatics + 224);
            if (lVar1 == null) {
        LAB_18153ad5b:
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            fVar7 = (float)MouseOrTouch.get_deltaTime(lVar1,0);
            if (this.tooltipDelay <= fVar7 && fVar7 != this.tooltipDelay) {
              lVar1 = *(int64 *)(pStatics + 224);
              if (lVar1 == null) goto LAB_18153ad5b;
              uVar2 = *(uint64 *)(lVar1 + 80);
              uVar3 = *(uint64 *)(lVar1 + 72);
              cVar4 = Object.op_Equality(uVar2,uVar3,0);
              if (cVar4) {
                if (*(float *)(pStatics + 0x1b8) != 0.0) {
                  lVar1 = *(int64 *)(pStatics + 224);
                  if (lVar1 != null) {
                    if (*(char *)(lVar1 + 118) != false) {
                      return;
                    }
                    *(uint32 *)(pStatics + 0x1b8) = 0;
                    lVar1 = *(int64 *)(pStatics + 224);
                    if (lVar1 != null) {
                      *(uint32 *)(lVar1 + 112) = 0;
                      if (this.longPressTooltip) {
                        lVar1 = *(int64 *)(pStatics + 224);
                        if (lVar1 == null) goto LAB_18153ad5b;
                        UICamera.ShowTooltip(*(uint64 *)(lVar1 + 80),0);
                      }
                      lVar1 = *(int64 *)(pStatics + 224);
                      if (lVar1 != null) {
                        UICamera.Notify(*(uint64 *)(lVar1 + 72),"OnLongPress",0,0);
                        return;
                      }
                    }
                  }
                  goto LAB_18153ad5b;
                }
              }
            }
          }
        }
    }

    // Token : 0x6000735
    // RVA   : 0x1533960   Offset: 0x1532D60   Length: 0x5E
    public static void CancelNextTooltip()
    {
        *(uint32 *)(*(int64 *)(DAT_181daf678 + 184) + 0x1b8) = 0;
    }

    // Token : 0x6000736
    // RVA   : 0x153D800   Offset: 0x153CC00   Length: 0x38C
    public static bool ShowTooltip(GameObject go)
    {
        var pStatics = *(int64*)(DAT_181daf678 + 184);
        ulong uVar1;
        long lVar2;
        bool cVar3;
        ulong uVar4;
        byte[] local_res8 = new byte[8];
        uVar1 = *(uint64 *)(pStatics + 0x1b0);
        cVar3 = Object.op_Inequality(uVar1,go,0);
        if (!cVar3) {
          return false;
        }
        uVar1 = *(uint64 *)(pStatics + 0x1b0);
        cVar3 = Object.op_Inequality(uVar1,0,0);
        if (cVar3) {
          if (*(int64 *)(pStatics + 0x178) != 0) {
            lVar2 = *(int64 *)(pStatics + 0x178);
            if (lVar2 == null) goto LAB_18153db87;
            OnTooltipCB.Invoke(lVar2,*(uint64 *)(pStatics + 0x1b0),0,0);
          }
          uVar1 = *(uint64 *)(pStatics + 0x1b0);
          local_res8[0] = 0;
          uVar4 = il2cpp_value_box(DAT_181db2ac8,local_res8);
          UICamera.Notify(uVar1,"OnTooltip",uVar4,0);
        }
        puVar5 = (uint64 *)(pStatics + 0x1b0);
        *puVar5 = go;
        il2cpp_internal(puVar5,go);
        *(uint32 *)(pStatics + 0x1b8) = 0;
        uVar1 = *(uint64 *)(pStatics + 0x1b0);
        cVar3 = Object.op_Inequality(uVar1,0,0);
        if (cVar3) {
          if (*(int64 *)(pStatics + 0x178) != 0) {
            lVar2 = *(int64 *)(pStatics + 0x178);
            if (lVar2 == null) {
        LAB_18153db87:
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            OnTooltipCB.Invoke(lVar2,*(uint64 *)(pStatics + 0x1b0),1,0);
          }
          uVar1 = *(uint64 *)(pStatics + 0x1b0);
          local_res8[0] = 1;
          uVar4 = il2cpp_value_box(DAT_181db2ac8,local_res8);
          UICamera.Notify(uVar1,"OnTooltip",uVar4,0);
        }
        return true;
    }

    // Token : 0x6000737
    // RVA   : 0x15347E0   Offset: 0x1533BE0   Length: 0x4B
    public static bool HideTooltip()
    {
        UICamera.ShowTooltip(0,0);
    }

    // Token : 0x6000738
    // RVA   : 0x153D780   Offset: 0x153CB80   Length: 0x7A
    public static void ResetTooltip(float delay)
    {
        float fVar1;
        UICamera.ShowTooltip(0,0);
        fVar1 = (float)Time.get_unscaledTime(0);
        *(float *)(*(int64 *)(DAT_181daf678 + 184) + 0x1b8) = fVar1 + delay;
    }

    // Token : 0x6000739
    // RVA   : 0x153EBF0   Offset: 0x153DFF0   Length: 0x100
    public void /*ctor*/()
    {
        uint uVar1;
        this.eventType = 1;
        uVar1 = LayerMask.op_Implicit(0xffffffff);
        this.eventReceiverMask = uVar1;
        this.useMouse = 0x1010101;
        this.useController = 0x101;
        this.tooltipDelay = 0x3f800000;
        this.mouseDragThreshold = 0x40800000;
        this.mouseClickThreshold = 0x41200000;
        this.touchDragThreshold = 0x42200000;
        this.touchClickThreshold = 0x42200000;
        this.rangeDistance = 0xbf800000;
        this.horizontalAxisName = "Horizontal";
        this.verticalAxisName = "Vertical";
        this.scrollAxisName = "Mouse ScrollWheel";
        this.commandClick = 1;
        this.submitKey0 = 13;
        this.submitKey1 = 0x14a;
        this.cancelKey0 = 27;
        this.cancelKey1 = 0x14b;
        this.autoHideCursor = 1;
        FUN_18044ef50(this,0);
    }

    // Token : 0x600073A
    // RVA   : 0x153E230   Offset: 0x153D630   Length: 0x9B2
    private static void /*cctor*/()
    {
        var pStatics = *(int64*)(DAT_181daf678 + 184);
        ulong uVar1;
        ulong uVar2;
        long lVar4;
        long lVar5;
        uint local_res10;
        uint uStackX_14;
        ulong local_28;
        uint local_20;
        ulong local_18;
        ulong uStack_10;
        uVar1 = new BetterList_1(DAT_181da66b8);
        puVar6 = *(uint64 **)(DAT_181daf678 + 184);
        *puVar6 = uVar1;
        il2cpp_internal(puVar6,uVar1);
        uVar1 = **(uint64 **)(DAT_181d8d1b8 + 184);
        uVar2 = new OnTooltipCB(uVar1,DAT_181db7588,0);
        puVar6 = (uint64 *)(pStatics + 8);
        *puVar6 = uVar2;
        il2cpp_internal(puVar6,uVar2);
        uVar1 = **(uint64 **)(DAT_181d8d1b8 + 184);
        uVar2 = new OnTooltipCB(uVar1,DAT_181db7610,0);
        puVar6 = (uint64 *)(pStatics + 16);
        *puVar6 = uVar2;
        il2cpp_internal(puVar6,uVar2);
        uVar1 = **(uint64 **)(DAT_181d8d1b8 + 184);
        uVar2 = new OnTooltipCB(uVar1,DAT_181db7698,0);
        puVar6 = (uint64 *)(pStatics + 24);
        *puVar6 = uVar2;
        il2cpp_internal(puVar6,uVar2);
        uVar1 = **(uint64 **)(DAT_181d8d1b8 + 184);
        uVar2 = new OnTooltipCB(uVar1,DAT_181db7720,0);
        puVar6 = (uint64 *)(pStatics + 32);
        *puVar6 = uVar2;
        il2cpp_internal(puVar6,uVar2);
        uVar1 = **(uint64 **)(DAT_181d8d1b8 + 184);
        uVar2 = new OnTooltipCB(uVar1,DAT_181db77a8,0);
        puVar6 = (uint64 *)(pStatics + 48);
        *puVar6 = uVar2;
        il2cpp_internal(puVar6,uVar2);
        uVar1 = **(uint64 **)(DAT_181d8d1b8 + 184);
        uVar2 = new OnTooltipCB(uVar1,DAT_181db7830,0);
        puVar6 = (uint64 *)(pStatics + 56);
        *puVar6 = uVar2;
        il2cpp_internal(puVar6,uVar2);
        uVar1 = **(uint64 **)(DAT_181d8d1b8 + 184);
        uVar2 = new OnTooltipCB(uVar1,DAT_181db78b8,0);
        puVar6 = (uint64 *)(pStatics + 64);
        *puVar6 = uVar2;
        il2cpp_internal(puVar6,uVar2);
        *(uint8 *)(pStatics + 88) = 1;
        *(uint8 *)(pStatics + 89) = 0;
        *(uint8 *)(pStatics + 90) = 0;
        *(uint8 *)(pStatics + 91) = 0;
        uVar1 = Vector2.get_zero(0);
        local_res10 = (uint32)uVar1;
        uStackX_14 = (uint32)((uint64)uVar1 >> 32);
        lVar4 = pStatics;
        *(uint32 *)(lVar4 + 92) = local_res10;
        *(uint32 *)(lVar4 + 96) = uStackX_14;
        puVar6 = (uint64 *)Vector3.get_zero(&local_28,0);
        lVar4 = pStatics;
        *(uint64 *)(lVar4 + 100) = *puVar6;
        *(uint32 *)(lVar4 + 108) = *(uint32 *)(puVar6 + 1);
        lVar4 = pStatics;
        *(uint64 *)(lVar4 + 112) = 0;
        *(uint64 *)(lVar4 + 120) = 0;
        *(uint64 *)(lVar4 + 128) = 0;
        puVar6 = (uint64 *)(pStatics + 184);
        *puVar6 = 0;
        il2cpp_internal(puVar6,0);
        puVar6 = (uint64 *)(pStatics + 192);
        *puVar6 = 0;
        il2cpp_internal(puVar6,0);
        *(uint32 *)(pStatics + 208) = 0;
        *(uint32 *)(pStatics + 212) = 0xffffff9c;
        *(uint32 *)(pStatics + 216) = 48;
        puVar6 = (uint64 *)(pStatics + 224);
        *puVar6 = 0;
        il2cpp_internal(puVar6,0);
        *(uint8 *)(pStatics + 232) = 0;
        plVar3 = (int64 *)FUN_1800d60b0(DAT_181da88e0,3);
        lVar4 = new MouseOrTouch(0);
        if (plVar3 == (int64 *)0) {
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
        if (lVar4 != null) {
          lVar5 = il2cpp_internal(lVar4,*(uint64 *)(*plVar3 + 64));
          if (lVar5 == null) {
            uVar1 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar1,0);
          }
        }
        if ((int)plVar3[3] == 0) {
          uVar1 = il2cpp_internal();
                          // WARNING: Subroutine does not return
          FUN_1800d65f0(uVar1,0);
        }
        plVar3[4] = lVar4;
        il2cpp_internal(plVar3 + 4,lVar4);
        lVar4 = new MouseOrTouch(0);
        if (lVar4 != null) {
          lVar5 = il2cpp_internal(lVar4,*(uint64 *)(*plVar3 + 64));
          if (lVar5 == null) {
            uVar1 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar1,0);
          }
        }
        if (*(uint32 *)(plVar3 + 3) < 2) {
          uVar1 = il2cpp_internal();
                          // WARNING: Subroutine does not return
          FUN_1800d65f0(uVar1,0);
        }
        plVar3[5] = lVar4;
        il2cpp_internal(plVar3 + 5,lVar4);
        lVar4 = new MouseOrTouch(0);
        if (lVar4 != null) {
          lVar5 = il2cpp_internal(lVar4,*(uint64 *)(*plVar3 + 64));
          if (lVar5 == null) {
            uVar1 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar1,0);
          }
        }
        if (2 < *(uint32 *)(plVar3 + 3)) {
          plVar3[6] = lVar4;
          il2cpp_internal(plVar3 + 6,lVar4);
          puVar6 = (uint64 *)(pStatics + 0x188);
          *puVar6 = plVar3;
          il2cpp_internal(puVar6,plVar3);
          uVar1 = new MouseOrTouch(0);
          puVar6 = (uint64 *)(pStatics + 400);
          *puVar6 = uVar1;
          il2cpp_internal(puVar6,uVar1);
          uVar1 = il2cpp_internal(DAT_181d9a7d0);
          FUN_18132faf0(uVar1,DAT_181db3f30);
          puVar6 = (uint64 *)(pStatics + 0x198);
          *puVar6 = uVar1;
          il2cpp_internal(puVar6,uVar1);
          uVar1 = il2cpp_internal(DAT_181d93cd0);
          FUN_18132faf0(uVar1,DAT_181d8f098);
          puVar6 = (uint64 *)(pStatics + 0x1a0);
          *puVar6 = uVar1;
          il2cpp_internal(puVar6,uVar1);
          *(uint32 *)(pStatics + 0x1a8) = 0;
          *(uint32 *)(pStatics + 0x1ac) = 0;
          puVar6 = (uint64 *)(pStatics + 0x1b0);
          *puVar6 = 0;
          il2cpp_internal(puVar6,0);
          *(uint32 *)(pStatics + 0x1b8) = 0;
          *(uint8 *)(pStatics + 0x1bc) = 0;
          *(uint32 *)(pStatics + 0x1c0) = 0xffffffff;
          *(uint8 *)(pStatics + 0x1c4) = 0;
          *(uint32 *)(pStatics + 0x1c8) = 0xffffffff;
          *(uint8 *)(pStatics + 0x1cc) = 0;
          *(uint32 *)(pStatics + 0x1d0) = 0xffffffff;
          *(uint8 *)(pStatics + 0x1d4) = 0;
          lVar4 = pStatics;
          *(uint64 *)(lVar4 + 0x1f0) = 0;
          *(uint64 *)(lVar4 + 0x1f8) = 0;
          *(uint64 *)(lVar4 + 0x200) = 0;
          *(uint64 *)(lVar4 + 0x208) = 0;
          *(uint64 *)(lVar4 + 0x210) = 0;
          *(uint64 *)(lVar4 + 0x218) = 0;
          *(uint64 *)(lVar4 + 0x220) = 0;
          *(uint64 *)(lVar4 + 0x228) = 0;
          *(uint64 *)(lVar4 + 0x230) = 0;
          uVar1 = new BetterList_1(DAT_181da79b8);
          puVar6 = (uint64 *)(pStatics + 0x238);
          *puVar6 = uVar1;
          il2cpp_internal(puVar6,uVar1);
          puVar6 = (uint64 *)Vector3.get_back(&local_28,0);
          local_20 = *(uint32 *)(puVar6 + 1);
          local_28 = *puVar6;
          local_18 = 0;
          uStack_10 = 0;
          Plane.ctor(&local_18,&local_28,0,0);
          lVar4 = pStatics;
          *(uint64 *)(lVar4 + 0x250) = local_18;
          *(uint64 *)(lVar4 + 600) = uStack_10;
          *(uint32 *)(pStatics + 0x260) = 0;
          *(uint32 *)(pStatics + 0x264) = 0;
          *(uint8 *)(pStatics + 0x268) = 1;
          *(uint8 *)(pStatics + 0x269) = 1;
          return;
        }
        uVar1 = il2cpp_internal();
    }

}
