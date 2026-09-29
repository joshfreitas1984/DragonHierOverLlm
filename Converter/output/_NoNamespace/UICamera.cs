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
    // RVA   : 0x153FE10   Offset: 0x153F210   Length: 0x97
    public static bool get_disableController()
    {
        bool cVar1;
        if (*(char *)(*(int64 *)(DAT_181daf690 + 184) + 91) == false) {
          return false;
        }
        cVar1 = UIPopupList.get_isOpen(0);
        return !cVar1;
    }

    // Token : 0x60006F2
    // RVA   : 0x15421D0   Offset: 0x15415D0   Length: 0x5D
    public static void set_disableController(bool value)
    {
        *(uint8 *)(*(int64 *)(DAT_181daf690 + 184) + 91) = value;
    }

    // Token : 0x60006F3
    // RVA   : 0x1541200   Offset: 0x1540600   Length: 0x66
    public static Vector2 get_lastTouchPosition()
    {
        return *(uint64 *)(*(int64 *)(DAT_181daf690 + 184) + 92);
    }

    // Token : 0x60006F4
    // RVA   : 0x1542D00   Offset: 0x1542100   Length: 0x6F
    public static void set_lastTouchPosition(Vector2 value)
    {
        long lVar1;
        uint local_res18;
        uint32 uStackX_1c;
        lVar1 = *(int64 *)(DAT_181daf690 + 184);
        local_res18 = (uint32)value;
        uStackX_1c = (uint32)((uint64)value >> 32);
        *(uint32 *)(lVar1 + 92) = local_res18;
        *(uint32 *)(lVar1 + 96) = uStackX_1c;
    }

    // Token : 0x60006F5
    // RVA   : 0x1541010   Offset: 0x1540410   Length: 0x1E3
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
        return *(uint64 *)(*(int64 *)(DAT_181daf690 + 184) + 92);
    }

    // Token : 0x60006F6
    // RVA   : 0x1542C90   Offset: 0x1542090   Length: 0x6F
    public static void set_lastEventPosition(Vector2 value)
    {
        long lVar1;
        uint local_res18;
        uint32 uStackX_1c;
        lVar1 = *(int64 *)(DAT_181daf690 + 184);
        local_res18 = (uint32)value;
        uStackX_1c = (uint32)((uint64)value >> 32);
        *(uint32 *)(lVar1 + 92) = local_res18;
        *(uint32 *)(lVar1 + 96) = uStackX_1c;
    }

    // Token : 0x60006F7
    // RVA   : 0x1540300   Offset: 0x153F700   Length: 0xE6
    public static UICamera get_first()
    {
        long lVar1;
        ulong uVar2;
        if (UICamera.list == null) {
          return 0;
        }
        if (UICamera.list != null) {
          if (UICamera.list.eventType == null) {
            return 0;
          }
          if ((UICamera.list != null) &&
             (lVar1 = *(int64 *)(UICamera.list + 16)) != null) {
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
    // RVA   : 0x153FBB0   Offset: 0x153EFB0   Length: 0x251
    public static ControlScheme get_currentScheme()
    {
        ulong uVar1;
        long lVar2;
        bool cVar3;
        if (UICamera.mCurrentKey == null) {
          return 1;
        }
        if (0x149 < UICamera.mCurrentKey) {
          return 2;
        }
        uVar1 = UICamera.current;
        cVar3 = Object.op_Inequality(uVar1,0,0);
        if (!cVar3) {
          return 0;
        }
        if (UICamera.mLastScheme == 2) {
          lVar2 = UICamera.current;
          if (lVar2 == null) throw; // [null/range check failed]
          if (UICamera.mCurrentKey == lVar2.submitKey0) {
            return 2;
          }
          lVar2 = UICamera.current;
          if (lVar2 == null) throw; // [null/range check failed]
          if (UICamera.mCurrentKey == lVar2.submitKey1) {
            return 2;
          }
        }
        lVar2 = UICamera.current;
        if (lVar2 != null) {
          if (lVar2.useMouse) {
            return 0;
          }
          lVar2 = UICamera.current;
          if (lVar2 != null) {
            if (lVar2.useTouch) {
              return 1;
            }
            return 2;
          }
        }
    }

    // Token : 0x60006F9
    // RVA   : 0x15420B0   Offset: 0x15414B0   Length: 0x11F
    public static void set_currentScheme(ControlScheme value)
    {
        ulong uVar1;
        if (UICamera.mLastScheme != value) {
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
          UICamera.mLastScheme = value;
        }
    }

    // Token : 0x60006FA
    // RVA   : 0x153F9A0   Offset: 0x153EDA0   Length: 0x5A
    public static KeyCode get_currentKey()
    {
        return *(uint32 *)(*(int64 *)(DAT_181daf690 + 184) + 216);
    }

    // Token : 0x60006FB
    // RVA   : 0x1541DA0   Offset: 0x15411A0   Length: 0x309
    public static void set_currentKey(KeyCode value)
    {
        int iVar1;
        long lVar2;
        bool cVar3;
        uint uVar4;
        ulong uVar5;
        if (UICamera.mCurrentKey != value) {
          iVar1 = UICamera.mLastScheme;
          UICamera.mCurrentKey = value;
          uVar4 = UICamera.get_currentScheme(0);
          UICamera.mLastScheme = uVar4;
          if (iVar1 == UICamera.mLastScheme) {
            return;
          }
          UICamera.ShowTooltip(0,0);
          if (UICamera.mLastScheme == null) {
            Cursor.set_lockState(0,0);
            Cursor.set_visible(1,0);
          }
          else {
            uVar5 = UICamera.current;
            cVar3 = Object.op_Inequality(uVar5,0,0);
            if (cVar3) {
              lVar2 = UICamera.current;
              if (lVar2 == null) goto LAB_181542094;
              if (lVar2.autoHideCursor) {
                Cursor.set_visible(0,0);
                Cursor.set_lockState(1);
                lVar2 = UICamera.mMouse;
                if (lVar2 == null) goto LAB_181542094;
                if (lVar2.eventType == null) {
                  uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1800d65f0(uVar5,0);
                }
                if (lVar2.eventReceiverMask == null) goto LAB_181542094;
                *(uint32 *)(lVar2.eventReceiverMask + 120) = 2;
              }
            }
          }
          if (UICamera.onSchemeChange != null) {
            lVar2 = UICamera.onSchemeChange;
            if (lVar2 == null) {
        LAB_181542094:
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            OnGeometryUpdated.Invoke(lVar2,0);
          }
        }
    }

    // Token : 0x60006FC
    // RVA   : 0x153FA00   Offset: 0x153EE00   Length: 0x1A7
    public static Ray get_currentRay()
    {
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
        uVar1 = UICamera.currentCamera;
        cVar5 = Object.op_Inequality(uVar1,0,0);
        if (cVar5) {
          if (UICamera.currentTouch != null) {
            lVar2 = UICamera.currentTouch;
            lVar3 = UICamera.currentCamera;
            if (lVar2 != null) {
              local_48 = lVar2.pos;
              uStack_44 = *(uint32 *)(lVar2 + 24);
              local_28 = lVar2.pos;
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
    // RVA   : 0x1540740   Offset: 0x153FB40   Length: 0x120
    public static bool get_inputHasFocus()
    {
        ulong uVar1;
        long lVar2;
        bool cVar3;
        if (UICamera.mInputFocus) {
          uVar1 = UICamera.mSelected;
          cVar3 = Object.op_Implicit(uVar1,0);
          if (cVar3) {
            lVar2 = UICamera.mSelected;
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
    // RVA   : 0x15403F0   Offset: 0x153F7F0   Length: 0x5B
    public static GameObject get_genericEventHandler()
    {
        return *(uint64 *)(*(int64 *)(DAT_181daf690 + 184) + 240);
    }

    // Token : 0x60006FF
    // RVA   : 0x1542230   Offset: 0x1541630   Length: 0x6B
    public static void set_genericEventHandler(GameObject value)
    {
        puVar1 = (uint64 *)(*(int64 *)(DAT_181daf690 + 184) + 240);
        *puVar1 = value;
        il2cpp_internal(puVar1,value);
    }

    // Token : 0x6000700
    // RVA   : 0x1541320   Offset: 0x1540720   Length: 0x7F
    public static MouseOrTouch get_mouse0()
    {
        long lVar1;
        ulong uVar2;
        lVar1 = *(int64 *)(*(int64 *)(DAT_181daf690 + 184) + 0x188);
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
    // RVA   : 0x15413A0   Offset: 0x15407A0   Length: 0x7F
    public static MouseOrTouch get_mouse1()
    {
        long lVar1;
        ulong uVar2;
        lVar1 = *(int64 *)(*(int64 *)(DAT_181daf690 + 184) + 0x188);
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
    // RVA   : 0x1541420   Offset: 0x1540820   Length: 0x7F
    public static MouseOrTouch get_mouse2()
    {
        long lVar1;
        ulong uVar2;
        lVar1 = *(int64 *)(*(int64 *)(DAT_181daf690 + 184) + 0x188);
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
    // RVA   : 0x1540450   Offset: 0x153F850   Length: 0x93
    private bool get_handlesEvents()
    {
        ulong uVar1;
        uVar1 = UICamera.get_eventHandler(0);
        Object.op_Equality(uVar1,this,0);
    }

    // Token : 0x6000704
    // RVA   : 0x153F300   Offset: 0x153E700   Length: 0xAC
    public Camera get_cachedCamera()
    {
        bool cVar1;
        ulong uVar2;
        uVar2 = this.mCam;
        cVar1 = Object.op_Equality(uVar2,0,0);
        if (cVar1) {
          uVar2 = Component.GetComponent(this,DAT_181d937f8);
          this.mCam = uVar2;
        }
        return this.mCam;
    }

    // Token : 0x6000705
    // RVA   : 0x1541610   Offset: 0x1540A10   Length: 0x5B
    public static GameObject get_tooltipObject()
    {
        return *(uint64 *)(*(int64 *)(DAT_181daf690 + 184) + 0x1b0);
    }

    // Token : 0x6000706
    // RVA   : 0x1543710   Offset: 0x1542B10   Length: 0x52
    public static void set_tooltipObject(GameObject value)
    {
        UICamera.ShowTooltip(value,0);
    }

    // Token : 0x6000707
    // RVA   : 0x1534EE0   Offset: 0x15342E0   Length: 0x154
    public static bool IsPartOfUI(GameObject go)
    {
        ulong uVar1;
        ulong uVar2;
        uVar1 = Object.op_Equality(go,0,0);
        if ((char)!uVar1) {
          uVar2 = *(uint64 *)(*(int64 *)(DAT_181daf690 + 184) + 248);
          uVar1 = Object.op_Equality(go,uVar2,0);
          if ((char)!uVar1) {
            uVar2 = NGUITools.FindInParents(go,DAT_181d8f6b8);
            uVar1 = Object.op_Inequality(uVar2,0,0);
            return uVar1;
          }
        }
        return uVar1 & 0xffffffffffffff00;
    }

    // Token : 0x6000708
    // RVA   : 0x1540B90   Offset: 0x153FF90   Length: 0x478
    public static bool get_isOverUI()
    {
        int iVar1;
        bool cVar2;
        byte uVar3;
        int iVar4;
        long lVar5;
        ulong uVar6;
        uint uVar7;
        iVar4 = Time.get_frameCount(0);
        if (UICamera.mLastOverCheck == iVar4) {
        LAB_181540e93:
          return UICamera.mLastOverResult;
        }
        UICamera.mLastOverCheck = iVar4;
        if (UICamera.currentTouch == null) {
          iVar4 = 0;
          lVar5 = UICamera.activeTouches;
          if (lVar5 != null) {
            iVar1 = *(int *)(lVar5 + 24);
            if (0 < iVar1) {
              do {
                lVar5 = UICamera.activeTouches;
                if ((lVar5 == null) || (lVar5 = FUN_180002f80(lVar5,iVar4,DAT_181db41f0)) == null)
                goto LAB_181540ff3;
                cVar2 = UICamera.IsPartOfUI(lVar5.pressed,0);
                if (cVar2) goto LAB_181540da8;
                iVar4 = iVar4 + 1;
              } while (iVar4 < iVar1);
            }
            uVar7 = 0;
            do {
              lVar5 = UICamera.mMouse;
              if (lVar5 == null) goto LAB_181540ff3;
              if (*(uint32 *)(lVar5 + 24) <= uVar7) {
                uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar6,0);
              }
              lVar5 = lVar5[uVar7];
              if (lVar5 == null) goto LAB_181540ff3;
              uVar6 = lVar5.pressed;
              cVar2 = Object.op_Inequality(uVar6,0,0);
              if (!cVar2) {
                if (uVar7 == 0) {
                  uVar6 = lVar5.current;
                }
                else {
                  uVar6 = 0;
                }
              }
              else {
                uVar6 = lVar5.pressed;
              }
              cVar2 = UICamera.IsPartOfUI(uVar6);
              if (cVar2) goto LAB_181540da8;
              uVar7 = uVar7 + 1;
            } while ((int)uVar7 < 3);
            lVar5 = UICamera.controller;
            if (lVar5 != null) {
              uVar3 = UICamera.IsPartOfUI(lVar5.pressed,0);
              UICamera.mLastOverResult = uVar3;
              goto LAB_181540e93;
            }
          }
        }
        else {
          lVar5 = UICamera.currentTouch;
          if (lVar5 != null) {
            uVar6 = lVar5.pressed;
            cVar2 = Object.op_Inequality(uVar6,0,0);
            if (!cVar2) {
              lVar5 = UICamera.currentTouch;
              if (lVar5 == null) goto LAB_181540ff3;
              uVar6 = lVar5.current;
            }
            else {
              lVar5 = UICamera.currentTouch;
              if (lVar5 == null) goto LAB_181540ff3;
              uVar6 = lVar5.pressed;
            }
            uVar3 = UICamera.IsPartOfUI(uVar6,0);
            UICamera.mLastOverResult = uVar3;
            goto LAB_181540fce;
          }
        }
        LAB_181540ff3:
                          // WARNING: Subroutine does not return
        FUN_1800d6620();
        LAB_181540da8:
        UICamera.mLastOverResult = 1;
        LAB_181540fce:
        return UICamera.mLastOverResult;
    }

    // Token : 0x6000709
    // RVA   : 0x15416C0   Offset: 0x1540AC0   Length: 0x433
    public static bool get_uiHasFocus()
    {
        int iVar1;
        bool cVar2;
        byte uVar3;
        int iVar4;
        long lVar5;
        ulong uVar6;
        uint uVar7;
        iVar4 = Time.get_frameCount(0);
        if (UICamera.mLastFocusCheck == iVar4) {
        LAB_181541a28:
          return UICamera.mLastFocusResult;
        }
        UICamera.mLastFocusCheck = iVar4;
        cVar2 = UICamera.get_inputHasFocus(0);
        if (cVar2) goto LAB_1815418a0;
        if (UICamera.currentTouch == null) {
          iVar4 = 0;
          lVar5 = UICamera.activeTouches;
          if (lVar5 != null) {
            iVar1 = *(int *)(lVar5 + 24);
            if (0 < iVar1) {
              do {
                lVar5 = UICamera.activeTouches;
                if (lVar5 == null) throw; // [null/range check failed]
                lVar5 = FUN_180002f80(lVar5,iVar4,DAT_181db41f0);
                if (lVar5 == null) throw; // [null/range check failed]
                cVar2 = UICamera.IsPartOfUI(lVar5.pressed,0);
                if (cVar2) goto LAB_1815418a0;
                iVar4 = iVar4 + 1;
              } while (iVar4 < iVar1);
            }
            lVar5 = UICamera.mMouse;
            if (lVar5 != null) {
              if (*(int *)(lVar5 + 24) == 0) {
                uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar6,0);
              }
              lVar5 = *(int64 *)(lVar5 + 32);
              if (lVar5 != null) {
                cVar2 = UICamera.IsPartOfUI(lVar5.pressed,0);
                if (!cVar2) {
                  uVar6 = lVar5.current;
                  cVar2 = UICamera.IsPartOfUI(uVar6,0);
                  if (!cVar2) {
                    uVar7 = 1;
                    do {
                      lVar5 = UICamera.mMouse;
                      if (lVar5 == null) throw; // [null/range check failed]
                      if (*(uint32 *)(lVar5 + 24) <= uVar7) {
                        uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                        FUN_1800d65f0(uVar6,0);
                      }
                      lVar5 = lVar5[uVar7];
                      if (lVar5 == null) throw; // [null/range check failed]
                      cVar2 = UICamera.IsPartOfUI(lVar5.pressed);
                      if (cVar2) goto LAB_1815418a0;
                      uVar7 = uVar7 + 1;
                    } while ((int)uVar7 < 3);
                    lVar5 = UICamera.controller;
                    if (lVar5 != null) {
                      uVar3 = UICamera.IsPartOfUI(lVar5.pressed,0);
                      UICamera.mLastFocusResult = uVar3;
                      goto LAB_181541a28;
                    }
                    throw; // [null/range check failed]
                  }
                }
        LAB_1815418a0:
                UICamera.mLastFocusResult = 1;
                return UICamera.mLastFocusResult;
              }
            }
          }
        }
        else {
          lVar5 = UICamera.currentTouch;
          if (lVar5 != null) {
            uVar3 = MouseOrTouch.get_isOverUI(lVar5,0);
            UICamera.mLastFocusResult = uVar3;
            return UICamera.mLastFocusResult;
          }
        }
    }

    // Token : 0x600070A
    // RVA   : 0x1540870   Offset: 0x153FC70   Length: 0x31C
    public static bool get_interactingWithUI()
    {
        int iVar1;
        bool cVar2;
        byte uVar3;
        int iVar4;
        long lVar5;
        ulong uVar6;
        uint uVar7;
        iVar4 = Time.get_frameCount(0);
        if (UICamera.mLastInteractionCheck == iVar4) {
        LAB_181540b18:
          return UICamera.mLastInteractionResult;
        }
        UICamera.mLastInteractionCheck = iVar4;
        cVar2 = UICamera.get_inputHasFocus(0);
        if (cVar2) {
        LAB_181540b57:
          if ((*(byte *)(DAT_181daf690 + 0x133) & 4) != 0) {
            iVar4 = *(int *)(DAT_181daf690 + 224);
        LAB_181540a6f:
            if (iVar4 == 0) {
              il2cpp_runtime_class_init(DAT_181daf690);
            }
          }
        LAB_181540a80:
          UICamera.mLastInteractionResult = 1;
          return UICamera.mLastInteractionResult;
        }
        iVar4 = 0;
        lVar5 = UICamera.activeTouches;
        if (lVar5 != null) {
          iVar1 = *(int *)(lVar5 + 24);
          uVar7 = 0;
          if (0 < iVar1) {
            do {
              lVar5 = UICamera.activeTouches;
              if ((lVar5 == null) || (lVar5 = FUN_180002f80(lVar5,iVar4,DAT_181db41f0)) == null)
              throw; // [null/range check failed]
              cVar2 = UICamera.IsPartOfUI(lVar5.pressed,0);
              if (cVar2) {
                if ((*(byte *)(DAT_181daf690 + 0x133) & 4) == 0) goto LAB_181540a80;
                iVar4 = *(int *)(DAT_181daf690 + 224);
                goto LAB_181540a6f;
              }
              iVar4 = iVar4 + 1;
              uVar7 = 0;
            } while (iVar4 < iVar1);
          }
          do {
            lVar5 = UICamera.mMouse;
            if (lVar5 == null) throw; // [null/range check failed]
            if (*(uint32 *)(lVar5 + 24) <= uVar7) {
              uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar6,0);
            }
            lVar5 = lVar5[uVar7];
            if (lVar5 == null) throw; // [null/range check failed]
            cVar2 = UICamera.IsPartOfUI(lVar5.pressed);
            if (cVar2) goto LAB_181540b57;
            uVar7 = uVar7 + 1;
          } while ((int)uVar7 < 3);
          lVar5 = UICamera.controller;
          if (lVar5 != null) {
            uVar3 = UICamera.IsPartOfUI(lVar5.pressed,0);
            UICamera.mLastInteractionResult = uVar3;
            goto LAB_181540b18;
          }
        }
    }

    // Token : 0x600070B
    // RVA   : 0x15404F0   Offset: 0x153F8F0   Length: 0x242
    public static GameObject get_hoveredObject()
    {
        long lVar1;
        ulong uVar2;
        bool cVar3;
        int iVar4;
        if (UICamera.currentTouch != null) {
          iVar4 = UICamera.get_currentScheme(0);
          if (iVar4 == 0) {
            lVar1 = UICamera.currentTouch;
            if (lVar1 == null) goto LAB_18154072d;
            if (!lVar1.dragStarted) goto LAB_1815405f7;
          }
          lVar1 = UICamera.currentTouch;
          if (lVar1 != null) {
            return lVar1.current;
          }
        LAB_18154072d:
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
        LAB_1815405f7:
        uVar2 = UICamera.mHover;
        cVar3 = Object.op_Implicit(uVar2,0);
        if (cVar3) {
          lVar1 = UICamera.mHover;
          if (lVar1 == null) goto LAB_18154072d;
          cVar3 = GameObject.get_activeInHierarchy(lVar1,0);
          if (cVar3) {
            return UICamera.mHover;
          }
        }
        UICamera.mHover = 0;
        return 0;
    }

    // Token : 0x600070C
    // RVA   : 0x15422A0   Offset: 0x15416A0   Length: 0x9ED
    public static void set_hoveredObject(GameObject value)
    {
        long lVar1;
        bool cVar3;
        int iVar4;
        uint uVar5;
        ulong uVar6;
        ulong uVar7;
        long lVar8;
        byte[] local_res8 = new byte[8];
        uVar7 = UICamera.mHover;
        cVar3 = Object.op_Equality(uVar7,value,0);
        if (!cVar3) {
          bVar2 = false;
          lVar1 = UICamera.current;
          if (UICamera.currentTouch == null) {
            bVar2 = true;
            UICamera.currentTouchID = 0xffffff9c;
            UICamera.currentTouch =
                 UICamera.controller;
            il2cpp_internal();
          }
          UICamera.ShowTooltip(0,0);
          uVar7 = UICamera.mSelected;
          cVar3 = Object.op_Implicit(uVar7,0);
          if (cVar3) {
            iVar4 = UICamera.get_currentScheme(0);
            if (iVar4 == 2) {
              uVar7 = UICamera.mSelected;
              local_res8[0] = 0;
              uVar6 = il2cpp_value_box(DAT_181db2ae0,local_res8);
              UICamera.Notify(uVar7,"OnSelect",uVar6,0);
              if (UICamera.onSelect != null) {
                lVar8 = UICamera.onSelect;
                if (lVar8 == null) goto LAB_181542c78;
                OnTooltipCB.Invoke(lVar8,UICamera.mSelected,0,0
                                   );
              }
              UICamera.mSelected = 0;
            }
          }
          uVar7 = UICamera.mHover;
          cVar3 = Object.op_Implicit(uVar7,0);
          if (cVar3) {
            uVar7 = UICamera.mHover;
            local_res8[0] = 0;
            uVar6 = il2cpp_value_box(DAT_181db2ae0,local_res8);
            UICamera.Notify(uVar7,"OnHover",uVar6,0);
            if (UICamera.onHover != null) {
              lVar8 = UICamera.onHover;
              if (lVar8 == null) goto LAB_181542c78;
              OnTooltipCB.Invoke(lVar8,UICamera.mHover,0,0);
            }
          }
          UICamera.mHover = value;
          lVar8 = UICamera.currentTouch;
          if (lVar8 == null) {
        LAB_181542c78:
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          lVar8.clickNotification = 0;
          uVar7 = UICamera.mHover;
          cVar3 = Object.op_Implicit(uVar7,0);
          if (cVar3) {
            lVar8 = UICamera.controller;
            uVar7 = UICamera.mHover;
            if (lVar8 == null) goto LAB_181542c78;
            uVar6 = lVar8.current;
            cVar3 = Object.op_Inequality(uVar7,uVar6,0);
            if (cVar3) {
              lVar8 = UICamera.mHover;
              if (lVar8 == null) goto LAB_181542c78;
              uVar7 = GameObject.GetComponent(lVar8,DAT_181d74a10);
              cVar3 = Object.op_Inequality(uVar7,0,0);
              if (cVar3) {
                lVar8 = UICamera.controller;
                if (lVar8 == null) goto LAB_181542c78;
                lVar8.current =
                     UICamera.mHover;
                il2cpp_internal();
              }
            }
            if (bVar2) {
              uVar7 = UICamera.mHover;
              cVar3 = Object.op_Inequality(uVar7,0,0);
              if (!cVar3) {
                if ((UICamera.list == null) ||
                   (lVar8 = *(int64 *)(UICamera.list + 16)) == null)
                goto LAB_181542c78;
                if (*(int *)(lVar8 + 24) == 0) {
                  uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1800d65f0(uVar7,0);
                }
                lVar8 = *(int64 *)(lVar8 + 32);
              }
              else {
                lVar8 = UICamera.mHover;
                if (lVar8 == null) goto LAB_181542c78;
                uVar5 = GameObject.get_layer(lVar8,0);
                lVar8 = UICamera.FindCameraForLayer(uVar5,0);
              }
              cVar3 = Object.op_Inequality(lVar8,0,0);
              if (cVar3) {
                UICamera.current = lVar8;
                if (lVar8 == null) goto LAB_181542c78;
                uVar7 = UICamera.get_cachedCamera(lVar8,0);
                UICamera.currentCamera = uVar7;
              }
            }
            if (UICamera.onHover != null) {
              lVar8 = UICamera.onHover;
              if (lVar8 == null) goto LAB_181542c78;
              OnTooltipCB.Invoke(lVar8,UICamera.mHover,1,0);
            }
            uVar7 = UICamera.mHover;
            local_res8[0] = 1;
            uVar6 = il2cpp_value_box(DAT_181db2ae0,local_res8);
            UICamera.Notify(uVar7,"OnHover",uVar6,0);
          }
          if (bVar2) {
            UICamera.current = lVar1;
            cVar3 = Object.op_Inequality(lVar1,0,0);
            if (!cVar3) {
              uVar7 = 0;
            }
            else {
              if (lVar1 == null) goto LAB_181542c78;
              uVar7 = UICamera.get_cachedCamera(lVar1,0);
            }
            UICamera.currentCamera = uVar7;
            UICamera.currentTouch = 0;
            UICamera.currentTouchID = 0xffffff9c;
          }
        }
    }

    // Token : 0x600070D
    // RVA   : 0x153F3B0   Offset: 0x153E7B0   Length: 0x5E9
    public static GameObject get_controllerNavigationObject()
    {
        bool cVar1;
        int iVar2;
        ulong uVar3;
        long lVar4;
        uint uVar6;
        lVar4 = UICamera.controller;
        if (lVar4 != null) {
          uVar3 = lVar4.current;
          cVar1 = Object.op_Implicit(uVar3,0);
          if (cVar1) {

            if ((lVar4 = UICamera.controller?.current) == null) throw; // [null/range check failed]
            cVar1 = GameObject.get_activeInHierarchy(lVar4,0);
            if (cVar1) {
              lVar4 = UICamera.controller;
              if (lVar4 != null) {
                return lVar4.current;
              }
              throw; // [null/range check failed]
            }
          }
          iVar2 = UICamera.get_currentScheme(0);
          if (iVar2 == 2) {
            uVar3 = UICamera.current;
            cVar1 = Object.op_Inequality(uVar3,0,0);
            if (cVar1) {
              lVar4 = UICamera.current;
              if (lVar4 == null) throw; // [null/range check failed]
              if (*(char *)(lVar4 + 45) != false) {
                if (!UICamera.ignoreControllerInput) {
                  if (UIKeyNavigation.list == null) throw; // [null/range check failed]
                  if (0 < UIKeyNavigation.list.constraint) {
                    uVar6 = 0;
                    do {
                      if (UIKeyNavigation.list == null) throw; // [null/range check failed]
                      if (UIKeyNavigation.list.constraint <= (int)uVar6) {
                        uVar3 = UICamera.mHover;
                        cVar1 = Object.op_Equality(uVar3,0,0);
                        if (!cVar1) break;
                        uVar6 = 0;
                        goto LAB_18153f840;
                      }
                      if ((UIKeyNavigation.list == null) ||
                         (lVar4 = *(int64 *)(UIKeyNavigation.list + 16)) == null
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
                        if ((*(int *)(lVar4 + 24) != 3) && (lVar4.pressed))
                        goto LAB_18153f74b;
                      }
                      uVar6 = uVar6 + 1;
                    } while( true );
                  }
                }
              }
            }
          }
        LAB_18153f91d:
          lVar4 = UICamera.controller;
          if (lVar4 != null) {
            puVar5 = (uint64 *)(lVar4 + 72);
            *puVar5 = 0;
            il2cpp_internal(puVar5,0);
            return 0;
          }
        }
        throw; // [null/range check failed]
        LAB_18153f840:
        if (UIKeyNavigation.list == null) throw; // [null/range check failed]
        if (UIKeyNavigation.list.constraint <= (int)uVar6) goto LAB_18153f91d;
        if ((UIKeyNavigation.list == null) ||
           (lVar4 = *(int64 *)(UIKeyNavigation.list + 16)) == null)
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
          if (*(int *)(lVar4 + 24) != 3) goto LAB_18153f74b;
        }
        uVar6 = uVar6 + 1;
        goto LAB_18153f840;
        LAB_18153f74b:
        uVar3 = Component.get_gameObject(lVar4,0);
        UICamera.set_hoveredObject(uVar3,0);
        lVar4 = UICamera.controller;
        if (lVar4 != null) {
          lVar4.current = UICamera.mHover;
          return UICamera.mHover;
        }
    }

    // Token : 0x600070E
    // RVA   : 0x1541B00   Offset: 0x1540F00   Length: 0x299
    public static void set_controllerNavigationObject(GameObject value)
    {
        long lVar1;
        ulong uVar2;
        long lVar3;
        bool cVar4;
        ulong uVar5;
        byte[] local_res18 = new byte[16];
        lVar1 = UICamera.controller;
        if (lVar1 != null) {
          uVar2 = lVar1.current;
          cVar4 = Object.op_Inequality(uVar2,value,0);
          if (cVar4) {
            lVar1 = UICamera.controller;
            if (lVar1 == null) throw; // [null/range check failed]
            uVar2 = lVar1.current;
            cVar4 = Object.op_Implicit(uVar2,0);
            if (cVar4) {
              lVar1 = UICamera.controller;
              if (lVar1 == null) {
                          // WARNING: Subroutine does not return
                FUN_1800d6620();
              }
              uVar2 = lVar1.current;
              local_res18[0] = 0;
              uVar5 = il2cpp_value_box(DAT_181db2ae0,local_res18);
              UICamera.Notify(uVar2,"OnHover",uVar5,0);
              if (UICamera.onHover != null) {
                lVar1 = UICamera.controller;
                lVar3 = UICamera.onHover;
                if ((lVar1 == null) || (lVar3 == null)) throw; // [null/range check failed]
                OnTooltipCB.Invoke(lVar3,lVar1.current,0,0);
              }
              lVar1 = UICamera.controller;
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
    // RVA   : 0x15414A0   Offset: 0x15408A0   Length: 0x16B
    public static GameObject get_selectedObject()
    {
        ulong uVar1;
        long lVar2;
        bool cVar3;
        uVar1 = UICamera.mSelected;
        cVar3 = Object.op_Implicit(uVar1,0);
        if (cVar3) {
          lVar2 = UICamera.mSelected;
          if (lVar2 == null) {
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          cVar3 = GameObject.get_activeInHierarchy(lVar2,0);
          if (cVar3) {
            return UICamera.mSelected;
          }
        }
        UICamera.mSelected = 0;
        return 0;
    }

    // Token : 0x6000710
    // RVA   : 0x1542D70   Offset: 0x1542170   Length: 0x997
    public static void set_selectedObject(GameObject value)
    {
        long lVar1;
        bool cVar2;
        byte uVar4;
        uint uVar5;
        ulong uVar6;
        ulong uVar7;
        long lVar8;
        byte[] local_res8 = new byte[8];
        uVar7 = UICamera.mSelected;
        cVar2 = Object.op_Equality(uVar7,value,0);
        if (!cVar2) {
          UICamera.ShowTooltip(0,0);
          bVar11 = 0;
          lVar1 = UICamera.current;
          if (UICamera.currentTouch == null) {
            bVar11 = 1;
            UICamera.currentTouchID = 0xffffff9c;
            UICamera.currentTouch =
                 UICamera.controller;
            il2cpp_internal();
          }
          UICamera.mInputFocus = 0;
          uVar7 = UICamera.mSelected;
          cVar2 = Object.op_Implicit(uVar7,0);
          if (cVar2) {
            uVar7 = UICamera.mSelected;
            local_res8[0] = 0;
            uVar6 = il2cpp_value_box(DAT_181db2ae0,local_res8);
            UICamera.Notify(uVar7,"OnSelect",uVar6,0);
            if (UICamera.onSelect != null) {
              lVar8 = UICamera.onSelect;
              if (lVar8 == null) goto LAB_1815436f2;
              OnTooltipCB.Invoke(lVar8,UICamera.mSelected,0,0);
            }
          }
          UICamera.mSelected = value;
          lVar8 = UICamera.currentTouch;
          if (lVar8 == null) {
        LAB_1815436f2:
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          lVar8.clickNotification = 0;
          cVar2 = Object.op_Inequality(value,0,0);
          if (cVar2) {
            if (value == null) goto LAB_1815436f2;
            uVar7 = GameObject.GetComponent(value,DAT_181d74a10);
            cVar2 = Object.op_Inequality(uVar7,0,0);
            if (cVar2) {
              lVar8 = UICamera.controller;
              if (lVar8 == null) goto LAB_1815436f2;
              plVar9 = (int64 *)(lVar8 + 72);
              *plVar9 = value;
              il2cpp_internal(plVar9,value);
            }
          }
          uVar7 = UICamera.mSelected;
          bVar3 = Object.op_Implicit(uVar7,0);
          if ((bVar11 & bVar3) != 0) {
            uVar7 = UICamera.mSelected;
            cVar2 = Object.op_Inequality(uVar7,0,0);
            if (!cVar2) {
              if ((UICamera.list == null) ||
                 (lVar8 = *(int64 *)(UICamera.list + 16)) == null)
              goto LAB_1815436f2;
              if (*(int *)(lVar8 + 24) == 0) {
                uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar7,0);
              }
              lVar8 = *(int64 *)(lVar8 + 32);
            }
            else {
              lVar8 = UICamera.mSelected;
              if (lVar8 == null) goto LAB_1815436f2;
              uVar5 = GameObject.get_layer(lVar8,0);
              lVar8 = UICamera.FindCameraForLayer(uVar5,0);
            }
            cVar2 = Object.op_Inequality(lVar8,0,0);
            if (cVar2) {
              UICamera.current = lVar8;
              if (lVar8 == null) goto LAB_1815436f2;
              uVar7 = UICamera.get_cachedCamera(lVar8,0);
              UICamera.currentCamera = uVar7;
            }
          }
          uVar7 = UICamera.mSelected;
          cVar2 = Object.op_Implicit(uVar7,0);
          if (cVar2) {
            lVar8 = UICamera.mSelected;
            if (lVar8 == null) goto LAB_1815436f2;
            cVar2 = GameObject.get_activeInHierarchy(lVar8,0);
            if (!cVar2) {
              uVar4 = 0;
            }
            else {
              lVar8 = UICamera.mSelected;
              if (lVar8 == null) goto LAB_1815436f2;
              uVar7 = GameObject.GetComponent(lVar8,DAT_181d74988);
              uVar4 = Object.op_Inequality(uVar7,0,0);
            }
            UICamera.mInputFocus = uVar4;
            if (UICamera.onSelect != null) {
              lVar8 = UICamera.onSelect;
              if (lVar8 == null) goto LAB_1815436f2;
              OnTooltipCB.Invoke(lVar8,UICamera.mSelected,1,0);
            }
            uVar7 = UICamera.mSelected;
            local_res8[0] = 1;
            uVar6 = il2cpp_value_box(DAT_181db2ae0,local_res8);
            UICamera.Notify(uVar7,"OnSelect",uVar6,0);
          }
          if (bVar11 != 0) {
            UICamera.current = lVar1;
            cVar2 = Object.op_Inequality(lVar1,0,0);
            if (!cVar2) {
              uVar7 = 0;
            }
            else {
              if (lVar1 == null) goto LAB_1815436f2;
              uVar7 = UICamera.get_cachedCamera(lVar1,0);
            }
            UICamera.currentCamera = uVar7;
            UICamera.currentTouch = 0;
            UICamera.currentTouchID = 0xffffff9c;
          }
        }
        else {
          UICamera.set_hoveredObject(value,0);
          lVar1 = UICamera.controller;
          if (lVar1 == null) goto LAB_1815436f2;
          plVar9 = (int64 *)(lVar1 + 72);
          *plVar9 = value;
          il2cpp_internal(plVar9,value);
        }
    }

    // Token : 0x6000711
    // RVA   : 0x1535040   Offset: 0x1534440   Length: 0x268
    public static bool IsPressed(GameObject go)
    {
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
          lVar4 = UICamera.mMouse;
          if (lVar4 == null) throw; // [null/range check failed]
          if (*(uint32 *)(lVar4 + 24) <= uVar6) {
            uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar5,0);
          }
          lVar4 = lVar4[uVar6];
          if (lVar4 == null) throw; // [null/range check failed]
          uVar5 = lVar4.pressed;
          cVar2 = Object.op_Equality(uVar5,go,0);
          if (cVar2) goto LAB_18153528f;
          uVar6 = uVar6 + 1;
        } while ((int)uVar6 < 3);
        lVar4 = UICamera.activeTouches;
        if (lVar4 != null) {
          iVar1 = *(int *)(lVar4 + 24);
          if (0 < iVar1) {
            do {
              lVar4 = UICamera.activeTouches;
              if (lVar4 == null) throw; // [null/range check failed]
              lVar4 = FUN_180002f80(lVar4,iVar7,DAT_181db41f0);
              if (lVar4 == null) throw; // [null/range check failed]
              uVar5 = lVar4.pressed;
              cVar2 = Object.op_Equality(uVar5,go,0);
              if (cVar2) goto LAB_18153528f;
              iVar7 = iVar7 + 1;
            } while (iVar7 < iVar1);
          }
          lVar4 = UICamera.controller;
          if (lVar4 != null) {
            uVar5 = lVar4.pressed;
            cVar2 = Object.op_Equality(uVar5,go,0);
            uVar3 = 0;
            if (cVar2) {
        LAB_18153528f:
              uVar3 = 1;
            }
            return uVar3;
          }
        }
    }

    // Token : 0x6000712
    // RVA   : 0x1541670   Offset: 0x1540A70   Length: 0x49
    public static int get_touchCount()
    {
        UICamera.CountInputSources(0);
    }

    // Token : 0x6000713
    // RVA   : 0x15340A0   Offset: 0x15334A0   Length: 0x2A7
    public static int CountInputSources()
    {
        int iVar1;
        bool cVar2;
        long lVar3;
        ulong uVar4;
        uint uVar5;
        int iVar6;
        int iVar7;
        iVar7 = 0;
        iVar6 = 0;
        lVar3 = UICamera.activeTouches;
        if (lVar3 != null) {
          iVar1 = *(int *)(lVar3 + 24);
          uVar5 = 0;
          if (0 < iVar1) {
            do {
              lVar3 = UICamera.activeTouches;
              if ((lVar3 == null) || (lVar3 = FUN_180002f80(lVar3,iVar6,DAT_181db41f0)) == null)
              throw; // [null/range check failed]
              uVar4 = lVar3.pressed;
              cVar2 = Object.op_Inequality(uVar4,0,0);
              if (cVar2) {
                iVar7 = iVar7 + 1;
              }
              iVar6 = iVar6 + 1;
              uVar5 = 0;
            } while (iVar6 < iVar1);
          }
          while( true ) {
            lVar3 = UICamera.mMouse;
            if (lVar3 == null) throw; // [null/range check failed]
            if (*(int *)(lVar3 + 24) <= (int)uVar5) break;
            lVar3 = UICamera.mMouse;
            if (lVar3 == null) throw; // [null/range check failed]
            if (*(uint32 *)(lVar3 + 24) <= uVar5) {
              uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar4,0);
            }
            lVar3 = lVar3[uVar5];
            if (lVar3 == null) throw; // [null/range check failed]
            uVar4 = lVar3.pressed;
            cVar2 = Object.op_Inequality(uVar4,0,0);
            if (cVar2) {
              iVar7 = iVar7 + 1;
            }
            uVar5 = uVar5 + 1;
          }
          lVar3 = UICamera.controller;
          if (lVar3 != null) {
            uVar4 = lVar3.pressed;
            cVar2 = Object.op_Inequality(uVar4,0,0);
            if (cVar2) {
              iVar7 = iVar7 + 1;
            }
            return iVar7;
          }
        }
    }

    // Token : 0x6000714
    // RVA   : 0x153FEB0   Offset: 0x153F2B0   Length: 0x2A7
    public static int get_dragCount()
    {
        int iVar1;
        bool cVar2;
        long lVar3;
        ulong uVar4;
        uint uVar5;
        int iVar6;
        int iVar7;
        iVar7 = 0;
        iVar6 = 0;
        lVar3 = UICamera.activeTouches;
        if (lVar3 != null) {
          iVar1 = *(int *)(lVar3 + 24);
          uVar5 = 0;
          if (0 < iVar1) {
            do {
              lVar3 = UICamera.activeTouches;
              if ((lVar3 == null) || (lVar3 = FUN_180002f80(lVar3,iVar6,DAT_181db41f0)) == null)
              throw; // [null/range check failed]
              uVar4 = lVar3.dragged;
              cVar2 = Object.op_Inequality(uVar4,0,0);
              if (cVar2) {
                iVar7 = iVar7 + 1;
              }
              iVar6 = iVar6 + 1;
              uVar5 = 0;
            } while (iVar6 < iVar1);
          }
          while( true ) {
            lVar3 = UICamera.mMouse;
            if (lVar3 == null) throw; // [null/range check failed]
            if (*(int *)(lVar3 + 24) <= (int)uVar5) break;
            lVar3 = UICamera.mMouse;
            if (lVar3 == null) throw; // [null/range check failed]
            if (*(uint32 *)(lVar3 + 24) <= uVar5) {
              uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar4,0);
            }
            lVar3 = lVar3[uVar5];
            if (lVar3 == null) throw; // [null/range check failed]
            uVar4 = lVar3.dragged;
            cVar2 = Object.op_Inequality(uVar4,0,0);
            if (cVar2) {
              iVar7 = iVar7 + 1;
            }
            uVar5 = uVar5 + 1;
          }
          lVar3 = UICamera.controller;
          if (lVar3 != null) {
            uVar4 = lVar3.dragged;
            cVar2 = Object.op_Inequality(uVar4,0,0);
            if (cVar2) {
              iVar7 = iVar7 + 1;
            }
            return iVar7;
          }
        }
    }

    // Token : 0x6000715
    // RVA   : 0x1541270   Offset: 0x1540670   Length: 0xA6
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
    // RVA   : 0x1540160   Offset: 0x153F560   Length: 0x19C
    public static UICamera get_eventHandler()
    {
        long lVar1;
        bool cVar2;
        ulong uVar3;
        uint uVar4;
        uVar4 = 0;
        while( true ) {
          if (UICamera.list == null) break;
          if (UICamera.list.eventType <= (int)uVar4) {
            return 0;
          }
          if ((UICamera.list == null) ||
             (lVar1 = *(int64 *)(UICamera.list + 16)) == null) break;
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
    // RVA   : 0x1533FD0   Offset: 0x15333D0   Length: 0xCB
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
    // RVA   : 0x1534610   Offset: 0x1533A10   Length: 0x140
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
          uVar2 = Component.GetComponent(trans,DAT_181d96b78);
          cVar1 = Object.op_Inequality(uVar2,0,0);
          if (cVar1) break;
          uVar2 = Component.GetComponent(trans);
          cVar1 = Object.op_Inequality(uVar2,0,0);
          if (cVar1) {
            return uVar2;
          }
          trans = FUN_180daa030(trans);
        }
        return 0;
    }

    // Token : 0x6000719
    // RVA   : 0x15344C0   Offset: 0x15338C0   Length: 0x140
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
          uVar2 = Component.GetComponent(trans,DAT_181d96b78);
          cVar1 = Object.op_Inequality(uVar2,0,0);
          if (cVar1) break;
          uVar2 = Component.GetComponent(trans);
          cVar1 = Object.op_Inequality(uVar2,0,0);
          if (cVar1) {
            return uVar2;
          }
          trans = FUN_180daa030(trans);
        }
        return 0;
    }

    // Token : 0x600071A
    // RVA   : 0x153BAE0   Offset: 0x153AEE0   Length: 0x214
    public static void Raycast(MouseOrTouch touch)
    {
        var pStatics_f690 = *(int64*)(DAT_181daf690 + 184);
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
        LAB_18153be70:
        do {
          if (UICamera.list == null) goto LAB_18153dc47;
          if (UICamera.list.eventType <= (int)uVar15) {
            return 0;
          }
          if ((UICamera.list == null) ||
             (lVar9 = *(int64 *)(UICamera.list + 16)) == null)
          goto LAB_18153dc47;
          if (*(uint32 *)(lVar9 + 24) <= uVar15) {
            uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar8,0);
          }
          lVar9 = lVar9[uVar15];
          if (lVar9 == null) goto LAB_18153dc47;
          cVar3 = Behaviour.get_enabled(lVar9,0);
          if (cVar3) {
            uVar8 = Component.get_gameObject(lVar9,0);
            cVar3 = NGUITools.GetActive(uVar8,0);
            if (!cVar3) goto LAB_18153d789;
            uVar8 = UICamera.get_cachedCamera(lVar9,0);
            UICamera.currentCamera = uVar8;
            lVar10 = UICamera.currentCamera;
            if (lVar10 == null) goto LAB_18153dc47;
            iVar4 = Camera.get_targetDisplay(lVar10,0);
            if (iVar4 != 0) goto LAB_18153d789;
            lVar10 = UICamera.currentCamera;
            if (lVar10 == null) goto LAB_18153dc47;
            local_328 = *touch;
            local_320 = *(uint32 *)(touch + 1);
            puVar13 = (uint64 *)Camera.ScreenToViewportPoint(local_208,lVar10,&local_328,0);
            local_318 = *puVar13;
            fVar16 = (float)local_318;
            cVar3 = Single.IsNaN(fVar16,0);
            if (cVar3) goto LAB_18153d789;
            fVar17 = local_318._4_4_;
            cVar3 = Single.IsNaN(local_318._4_4_,0);
            if ((((cVar3) || (fVar16 < 0.0)) || (1.0 < fVar16)) ||
               ((fVar17 < 0.0 || (1.0 < fVar17)))) goto LAB_18153d789;
            lVar10 = UICamera.currentCamera;
            if (lVar10 == null) goto LAB_18153dc47;
            local_308 = *touch;
            local_300 = *(uint32 *)(touch + 1);
            puVar13 = (uint64 *)Camera.ScreenPointToRay(&local_348,lVar10,&local_308);
            local_368 = *puVar13;
            uStack_360 = puVar13[1];
            local_358 = puVar13[2];
            lVar10 = UICamera.currentCamera;
            if (lVar10 == null) goto LAB_18153dc47;
            uVar5 = Camera.get_cullingMask(lVar10,0);
            uVar6 = LayerMask.op_Implicit(*(uint32 *)(lVar9 + 32),0);
            fVar16 = *(float *)(lVar9 + 72);
            uVar6 = uVar6 & uVar5;
            if (fVar16 <= 0.0) {
              lVar10 = UICamera.currentCamera;
              if (lVar10 == null) goto LAB_18153dc47;
              fVar16 = (float)Camera.get_farClipPlane(lVar10,0);
              lVar10 = UICamera.currentCamera;
              if (lVar10 == null) goto LAB_18153dc47;
              fVar17 = (float)Camera.get_nearClipPlane(lVar10,0);
              fVar16 = fVar16 - fVar17;
            }
            uVar2 = local_358;
            uVar11 = uStack_360;
            uVar8 = local_368;
            iVar4 = *(int *)(lVar9 + 24);
            local_res18[0] = fVar16;
            if (iVar4 == 0) {
              lVar10 = pStatics_f690;
              *(uint64 *)(lVar10 + 112) = uVar8;
              *(uint64 *)(lVar10 + 120) = uVar11;
              *(uint64 *)(lVar10 + 128) = uVar2;
              local_228 = local_368;
              uStack_220 = uStack_360;
              local_218 = local_358;
              cVar3 = Physics.Raycast(&local_228,pStatics_f690 + 136,
                                       local_res18[0],uVar6,1,0);
              if (!cVar3) goto LAB_18153d789;
              puVar13 = (uint64 *)
                        FUN_18045e0a0(local_298,pStatics_f690 + 136,0);
              lVar10 = pStatics_f690;
              *(uint64 *)(lVar10 + 100) = *puVar13;
              *(uint32 *)(lVar10 + 108) = *(uint32 *)(puVar13 + 1);
              lVar10 = RaycastHit.get_collider(pStatics_f690 + 136,0);
              if (lVar10 != null) {
                uVar8 = Component.get_gameObject(lVar10,0);
                UICamera.mRayHitObject = uVar8;
                if (*(char *)(lVar9 + 28) != false) {
                  return 1;
                }
                lVar9 = UICamera.mRayHitObject;
                if ((lVar9 != null) && (lVar9 = FUN_180f93010(lVar9,0)) != null) {
                  lVar9 = FUN_180967b70(lVar9,DAT_181d74ed8);
        LAB_18153dbb5:
                  cVar3 = Object.op_Inequality(lVar9,0,0);
                  if (!cVar3) {
                    return 1;
                  }
                  if (lVar9 != null) {
                    uVar8 = Component.get_gameObject(lVar9,0);
                    UICamera.mRayHitObject = uVar8;
                    return 1;
                  }
                }
              }
        LAB_18153dc47:
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            if (iVar4 == 1) {
              if (UICamera.mRayHits == null) {
                uVar8 = FUN_1800d60b0(DAT_181da4838,50);
                UICamera.mRayHits = uVar8;
              }
              uVar2 = local_358;
              uVar11 = uStack_360;
              uVar8 = local_368;
              local_248 = uVar8;
              uStack_240 = uVar11;
              local_238 = uVar2;
              iVar4 = Physics.RaycastNonAlloc
                                (&local_248,UICamera.mRayHits,
                                 local_res18[0],uVar6,2,0);
              if (1 < iVar4) {
                uVar5 = 0;
        LAB_18153d096:
                lVar9 = UICamera.mRayHits;
                if (lVar9 == null) goto LAB_18153dc47;
                if (*(uint32 *)(lVar9 + 24) <= uVar5) {
                  uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1800d65f0(uVar8,0);
                }
                lVar10 = (int64)(int)uVar5 * 44;
                lVar9 = RaycastHit.get_collider(lVar9 + 32 + lVar10,0);
                if ((lVar9 == null) || (lVar9 = Component.get_gameObject(lVar9,0)) == null)
                goto LAB_18153dc47;
                plVar14 = (int64 *)GameObject.GetComponent(lVar9);
                cVar3 = Object.op_Inequality(plVar14,0,0);
                if (!cVar3) {
                  lVar12 = NGUITools.FindInParents(lVar9);
                  cVar3 = Object.op_Inequality(lVar12,0,0);
                  if (cVar3) {
                    if (lVar12 != null) {
                      if (*(float *)(lVar12 + 140) <= 0.001 && *(float *)(lVar12 + 140) != 0.001)
                      goto LAB_18153d4fb;
                      goto LAB_18153d2d0;
                    }
                    goto LAB_18153dc47;
                  }
                }
                else {
                  if (plVar14 == (int64 *)0) goto LAB_18153dc47;
                  cVar3 = UIWidget.get_isVisible(plVar14);
                  if (!cVar3) goto LAB_18153d4fb;
                  if (((*(byte *)(DAT_181db0390 + 300) <= *(byte *)(*plVar14 + 300)) &&
                      (*(int64 *)
                        (*(int64 *)(*plVar14 + 200) + -8 +
                        (uint64)*(byte *)(DAT_181db0390 + 300) * 8) == DAT_181db0390)) &&
                     (lVar12 = UISpriteCollection.GetCurrentSprite(local_c8),
                     (char)*(uint64 *)(lVar12 + 56) == false)) goto LAB_18153d4fb;
                  lVar12 = plVar14[28];
                  if (lVar12 != null) {
                    lVar1 = UICamera.mRayHits;
                    if (lVar1 == null) goto LAB_18153dc47;
                    if (*(uint32 *)(lVar1 + 24) <= uVar5) {
                      uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                      FUN_1800d65f0(uVar8,0);
                    }
                    puVar13 = (uint64 *)FUN_18045e0a0(local_1b8,lVar1 + 32 + lVar10);
                    local_2a8 = *puVar13;
                    local_2a0 = *(uint32 *)(puVar13 + 1);
                    cVar3 = HitCheck.Invoke(lVar12);
                    if (!cVar3) goto LAB_18153d4fb;
                  }
                }
        LAB_18153d2d0:
                uVar7 = NGUITools.CalculateRaycastDepth(lVar9,0);
                UICamera.mHit = uVar7;
                if (UICamera.mHit != 0x7fffffff) {
                  lVar9 = pStatics_f690;
                  lVar12 = *(int64 *)(lVar9 + 0x240);
                  if (lVar12 == null) goto LAB_18153dc47;
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
                  lVar9 = UICamera.mRayHits;
                  if (lVar9 == null) goto LAB_18153dc47;
                  if (*(uint32 *)(lVar9 + 24) <= uVar5) {
                    uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                    FUN_1800d65f0(uVar8,0);
                  }
                  puVar13 = (uint64 *)FUN_18045e0a0(local_298,lVar9 + 32 + lVar10,0);
                  lVar9 = pStatics_f690;
                  *(uint64 *)(lVar9 + 0x220) = *puVar13;
                  *(uint32 *)(lVar9 + 0x228) = *(uint32 *)(puVar13 + 1);
                  lVar9 = UICamera.mRayHits;
                  if (lVar9 == null) goto LAB_18153dc47;
                  if (*(uint32 *)(lVar9 + 24) <= uVar5) {
                    uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                    FUN_1800d65f0(uVar8,0);
                  }
                  lVar9 = RaycastHit.get_collider(lVar9 + 32 + lVar10,0);
                  if (lVar9 == null) goto LAB_18153dc47;
                  uVar8 = Component.get_gameObject(lVar9,0);
                  puVar13 = (uint64 *)(pStatics_f690 + 0x230);
                  *puVar13 = uVar8;
                  il2cpp_internal(puVar13,uVar8);
                  lVar9 = pStatics_f690;
                  if (*(int64 *)(lVar9 + 0x238) == 0) goto LAB_18153dc47;
                  local_158 = *(uint64 *)(lVar9 + 0x1f0);
                  uStack_150 = *(uint64 *)(lVar9 + 0x1f8);
                  local_148 = *(uint64 *)(lVar9 + 0x200);
                  uStack_140 = *(uint64 *)(lVar9 + 0x208);
                  local_138 = *(uint64 *)(lVar9 + 0x210);
                  uStack_130 = *(uint64 *)(lVar9 + 0x218);
                  local_128 = *(uint64 *)(lVar9 + 0x220);
                  uStack_120 = *(uint64 *)(lVar9 + 0x228);
                  local_118 = *(uint64 *)(lVar9 + 0x230);
                  FUN_1815843b0();
                }
        LAB_18153d4fb:
                uVar5 = uVar5 + 1;
                if (iVar4 <= (int)uVar5) break;
                goto LAB_18153d096;
              }
              if (iVar4 == 1) {
                lVar9 = UICamera.mRayHits;
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
                      lVar9 = NGUITools.FindInParents(lVar9,DAT_181d8f5b8);
                      cVar3 = Object.op_Inequality(lVar9,0,0);
                      if (cVar3) {
                        if (lVar9 == null) goto LAB_18153dc47;
                        if (*(float *)(lVar9 + 140) <= 0.001 && *(float *)(lVar9 + 140) != 0.001)
                        goto LAB_18153d789;
                      }
                    }
                    else {
                      if (lVar10 == null) goto LAB_18153dc47;
                      cVar3 = UIWidget.get_isVisible(lVar10,0);
                      if (!cVar3) goto LAB_18153d789;
                      lVar9 = *(int64 *)(lVar10 + 224);
                      if (lVar9 != null) {
                        lVar10 = UICamera.mRayHits;
                        if (lVar10 == null) goto LAB_18153dc47;
                        if (*(int *)(lVar10 + 24) == 0) {
                          uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                          FUN_1800d65f0(uVar8,0);
                        }
                        puVar13 = (uint64 *)FUN_18045e0a0(local_1d8,lVar10 + 32,0);
                        local_2c8 = *puVar13;
                        local_2c0 = *(uint32 *)(puVar13 + 1);
                        cVar3 = HitCheck.Invoke(lVar9,&local_2c8,0);
                        if (!cVar3) goto LAB_18153d789;
                      }
                    }
                    lVar9 = UICamera.mRayHits;
                    if (lVar9 != null) {
                      if (*(int *)(lVar9 + 24) == 0) {
                        uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                        FUN_1800d65f0(uVar8,0);
                      }
                      puVar13 = (uint64 *)FUN_18045e0a0(local_1c8,lVar9 + 32,0);
                      uVar8 = *puVar13;
                      uVar7 = *(uint32 *)(puVar13 + 1);
                      lVar9 = UICamera.mRayHits;
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
                          if (!cVar3) goto LAB_18153d789;
                          lVar9 = pStatics_f690;
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
                            lVar9 = pStatics_f690;
                            *(uint32 *)(lVar9 + 112) = (uint32)local_368;
                            *(uint32 *)(lVar9 + 116) = local_368._4_4_;
                            *(uint32 *)(lVar9 + 120) = (uint32)uStack_360;
                            *(uint32 *)(lVar9 + 124) = uStack_360._4_4_;
                            *(uint64 *)(lVar9 + 128) = local_358;
                            lVar9 = UICamera.mRayHits;
                            if (lVar9 != null) {
                              if (*(int *)(lVar9 + 24) == 0) {
                                uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                FUN_1800d65f0(uVar8,0);
                              }
                              puVar13 = (uint64 *)FUN_18045e0a0(local_298,lVar9 + 32,0);
                              lVar9 = pStatics_f690;
                              *(uint64 *)(lVar9 + 100) = *puVar13;
                              *(uint32 *)(lVar9 + 108) = *(uint32 *)(puVar13 + 1);
                              lVar9 = RaycastHit.get_collider
                                                (pStatics_f690 + 136,0);
                              if (lVar9 != null) {
                                uVar8 = Component.get_gameObject(lVar9,0);
                                UICamera.mRayHitObject = uVar8;
                                return 1;
                              }
                            }
                          }
                        }
                      }
                    }
                  }
                }
                goto LAB_18153dc47;
              }
            }
            else if (iVar4 == 2) {
              local_268 = (uint32)local_368;
              uStack_264 = local_368._4_4_;
              uStack_260 = (uint32)uStack_360;
              uStack_25c = uStack_360._4_4_;
              local_258 = local_358;
              cVar3 = Plane.Raycast(pStatics_f690 + 0x250,&local_268,local_res18);
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
                if (!cVar3) goto LAB_18153d789;
                lVar12 = pStatics_f690;
                *(uint64 *)(lVar12 + 100) = uVar8;
                *(uint32 *)(lVar12 + 108) = uVar7;
                if (lVar10 != null) {
                  uVar8 = Component.get_gameObject(lVar10,0);
                  UICamera.mRayHitObject = uVar8;
                  if (*(char *)(lVar9 + 28) != false) {
                    return 1;
                  }
                  lVar9 = UICamera.mRayHitObject;
                  if (lVar9 != null) {
                    uVar8 = GameObject.get_transform(lVar9,0);
                    lVar9 = UICamera.FindRootRigidbody2D(uVar8,0);
                    goto LAB_18153dbb5;
                  }
                }
                goto LAB_18153dc47;
              }
            }
            else {
              if (iVar4 != 3) goto LAB_18153d789;
              local_288 = (uint32)local_368;
              uStack_284 = local_368._4_4_;
              uStack_280 = (uint32)uStack_360;
              uStack_27c = uStack_360._4_4_;
              local_278 = local_358;
              cVar3 = Plane.Raycast(pStatics_f690 + 0x250,&local_288,local_res18);
              if (!cVar3) goto LAB_18153d789;
              puVar13 = (uint64 *)Ray.GetPoint(local_1f8,&local_368,local_res18[0]);
              uVar8 = *puVar13;
              uVar7 = *(uint32 *)(puVar13 + 1);
              lVar9 = pStatics_f690;
              *(uint64 *)(lVar9 + 100) = uVar8;
              *(uint32 *)(lVar9 + 108) = uVar7;
              if (UICamera.mOverlap == null) {
                uVar8 = FUN_1800d60b0(DAT_181da10d8,50);
                UICamera.mOverlap = uVar8;
              }
              lVar9 = pStatics_f690;
              local_348 = *(uint64 *)(lVar9 + 100);
              local_res20 = (uint32)local_348;
              uStackX_24 = (uint32)((uint64)local_348 >> 32);
              local_340 = *(uint32 *)(lVar9 + 108);
              uVar8 = *(uint64 *)(lVar9 + 0x248);
              iVar4 = Physics2D.OverlapPointNonAlloc(CONCAT44(uStackX_24,local_res20),uVar8,uVar6);
              if (1 < iVar4) {
                uVar5 = 0;
                do {
                  lVar9 = UICamera.mOverlap;
                  if (lVar9 == null) goto LAB_18153dc47;
                  if (*(uint32 *)(lVar9 + 24) <= uVar5) {
                    uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                    FUN_1800d65f0(uVar8,0);
                  }
                  lVar9 = lVar9[uVar5];
                  if ((lVar9 == null) || (lVar9 = Component.get_gameObject(lVar9,0)) == null)
                  goto LAB_18153dc47;
                  lVar10 = GameObject.GetComponent(lVar9);
                  cVar3 = Object.op_Inequality(lVar10,0,0);
                  if (!cVar3) {
                    lVar10 = NGUITools.FindInParents(lVar9);
                    cVar3 = Object.op_Inequality(lVar10,0,0);
                    if (cVar3) {
                      if (lVar10 == null) goto LAB_18153dc47;
                      if (*(float *)(lVar10 + 140) <= 0.001 && *(float *)(lVar10 + 140) != 0.001)
                      goto LAB_18153c8fc;
                    }
        LAB_18153c7a9:
                    uVar7 = NGUITools.CalculateRaycastDepth(lVar9,0);
                    UICamera.mHit = uVar7;
                    if (UICamera.mHit != 0x7fffffff) {
                      plVar14 = (int64 *)(pStatics_f690 + 0x230);
                      *plVar14 = lVar9;
                      il2cpp_internal(plVar14,lVar9);
                      lVar9 = pStatics_f690;
                      *(uint64 *)(lVar9 + 0x220) = *(uint64 *)(lVar9 + 100);
                      *(uint32 *)(lVar9 + 0x228) = *(uint32 *)(lVar9 + 108);
                      lVar9 = pStatics_f690;
                      if (*(int64 *)(lVar9 + 0x238) == 0) goto LAB_18153dc47;
                      local_1a8 = *(uint64 *)(lVar9 + 0x1f0);
                      uStack_1a0 = *(uint64 *)(lVar9 + 0x1f8);
                      local_198 = *(uint64 *)(lVar9 + 0x200);
                      uStack_190 = *(uint64 *)(lVar9 + 0x208);
                      local_188 = *(uint64 *)(lVar9 + 0x210);
                      uStack_180 = *(uint64 *)(lVar9 + 0x218);
                      local_178 = *(uint64 *)(lVar9 + 0x220);
                      uStack_170 = *(uint64 *)(lVar9 + 0x228);
                      local_168 = *(uint64 *)(lVar9 + 0x230);
                      FUN_1815843b0();
                    }
                  }
                  else {
                    if (lVar10 == null) goto LAB_18153dc47;
                    cVar3 = UIWidget.get_isVisible(lVar10);
                    if (cVar3) {
                      lVar10 = *(int64 *)(lVar10 + 224);
                      if (lVar10 != null) {
                        local_2d0 = *(uint32 *)(pStatics_f690 + 108);
                        local_2d8 = UICamera.lastWorldPosition;
                        cVar3 = HitCheck.Invoke(lVar10);
                        if (!cVar3) goto LAB_18153c8fc;
                      }
                      goto LAB_18153c7a9;
                    }
                  }
        LAB_18153c8fc:
                  uVar5 = uVar5 + 1;
                } while ((int)uVar5 < iVar4);
                lVar9 = UICamera.mHits;
                lVar10 = UICamera.GetKeyUp;
                if (lVar10 == null) {
                  uVar8 = **(uint64 **)(DAT_181d8d1d0 + 184);
                  lVar10 = new OnTooltipCB(uVar8,DAT_181db7b78);
                  UICamera.GetKeyUp = lVar10;
                }
                if (lVar9 != null) {
                  FUN_181586f40(lVar9,lVar10,DAT_181da7b50);
                  uVar5 = 0;
                  while( true ) {
                    lVar9 = UICamera.mHits;
                    if (lVar9 == null) goto LAB_18153dc47;
                    if (*(int *)(lVar9 + 24) <= (int)uVar5) break;
                    lVar9 = UICamera.mHits;
                    if ((lVar9 == null) || (lVar9 = *(int64 *)(lVar9 + 16)) == null)
                    goto LAB_18153dc47;
                    if (*(uint32 *)(lVar9 + 24) <= uVar5) {
                      uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                      FUN_1800d65f0(uVar8,0);
                    }
                    cVar3 = UICamera.IsVisible(lVar9 + (int64)(int)uVar5 * 72 + 32,0);
                    if (cVar3) {
                      lVar9 = UICamera.mHits;
                      if ((lVar9 != null) && (lVar9 = *(int64 *)(lVar9 + 16)) != null) {
                        if (*(uint32 *)(lVar9 + 24) <= uVar5) {
                          uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                          FUN_1800d65f0(uVar8,0);
                        }
                        UICamera.mRayHitObject =
                             *(uint64 *)(lVar9 + 96 + (int64)(int)uVar5 * 72);
                        il2cpp_internal();
        LAB_18153da70:
                        lVar9 = UICamera.mHits;
                        if (lVar9 != null) {
                          BetterList_1.Clear(lVar9,DAT_181da7ad0);
                          return 1;
                        }
                      }
                      goto LAB_18153dc47;
                    }
                    uVar5 = uVar5 + 1;
                  }
                  goto LAB_18153d6a1;
                }
                goto LAB_18153dc47;
              }
              if (iVar4 == 1) {
                lVar9 = UICamera.mOverlap;
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
                      lVar10 = NGUITools.FindInParents(lVar9,DAT_181d8f5b8);
                      cVar3 = Object.op_Inequality(lVar10,0,0);
                      if (cVar3) {
                        if (lVar10 == null) goto LAB_18153dc47;
                        if (*(float *)(lVar10 + 140) <= 0.001 && *(float *)(lVar10 + 140) != 0.001)
                        goto LAB_18153d789;
                      }
                    }
                    else {
                      if (lVar10 == null) goto LAB_18153dc47;
                      cVar3 = UIWidget.get_isVisible(lVar10,0);
                      if (!cVar3) goto LAB_18153d789;
                      lVar10 = *(int64 *)(lVar10 + 224);
                      if (lVar10 != null) {
                        local_2f0 = *(uint32 *)(pStatics_f690 + 108);
                        local_2f8 = UICamera.lastWorldPosition;
                        cVar3 = HitCheck.Invoke(lVar10,&local_2f8,0);
                        if (!cVar3) goto LAB_18153d789;
                      }
                    }
                    local_2e8 = UICamera.lastWorldPosition;
                    local_2e0 = *(uint32 *)(pStatics_f690 + 108);
                    cVar3 = UICamera.IsVisible(&local_2e8,lVar9,0);
                    if (cVar3) {
                      UICamera.mRayHitObject = lVar9;
                      return 1;
                    }
                    goto LAB_18153d789;
                  }
                }
                goto LAB_18153dc47;
              }
            }
          }
        LAB_18153d789:
          uVar15 = uVar15 + 1;
        } while( true );
        lVar9 = UICamera.mHits;
        lVar10 = UICamera.GetKeyDown;
        if (lVar10 == null) {
          uVar8 = **(uint64 **)(DAT_181d8d1d0 + 184);
          lVar10 = new OnTooltipCB(uVar8,DAT_181db7af0);
          UICamera.GetKeyDown = lVar10;
        }
        if (lVar9 == null) goto LAB_18153dc47;
        FUN_181586f40(lVar9,lVar10,DAT_181da7b50);
        uVar5 = 0;
        while( true ) {
          lVar9 = UICamera.mHits;
          if (lVar9 == null) goto LAB_18153dc47;
          if (*(int *)(lVar9 + 24) <= (int)uVar5) break;
          lVar9 = UICamera.mHits;
          if ((lVar9 == null) || (lVar9 = *(int64 *)(lVar9 + 16)) == null) goto LAB_18153dc47;
          lVar10 = (int64)(int)uVar5;
          if (*(uint32 *)(lVar9 + 24) <= uVar5) {
            uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar8,0);
          }
          cVar3 = UICamera.IsVisible(lVar9 + lVar10 * 72 + 32,0);
          if (cVar3) {
            lVar9 = pStatics_f690;
            if ((*(int64 *)(lVar9 + 0x238) == 0) ||
               (lVar12 = *(int64 *)(*(int64 *)(lVar9 + 0x238) + 16)) == null)
            goto LAB_18153dc47;
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
            lVar9 = UICamera.mHits;
            if ((lVar9 == null) || (lVar9 = *(int64 *)(lVar9 + 16)) == null) goto LAB_18153dc47;
            if (*(uint32 *)(lVar9 + 24) <= uVar5) {
              uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar8,0);
            }
            UICamera.mRayHitObject =
                 *(uint64 *)(lVar9 + 96 + lVar10 * 72);
            il2cpp_internal();
            lVar9 = pStatics_f690;
            *(uint32 *)(lVar9 + 112) = (uint32)local_368;
            *(uint32 *)(lVar9 + 116) = local_368._4_4_;
            *(uint32 *)(lVar9 + 120) = (uint32)uStack_360;
            *(uint32 *)(lVar9 + 124) = uStack_360._4_4_;
            *(uint64 *)(lVar9 + 128) = local_358;
            lVar9 = pStatics_f690;
            if ((*(int64 *)(lVar9 + 0x238) == 0) ||
               (lVar12 = *(int64 *)(*(int64 *)(lVar9 + 0x238) + 16)) == null)
            goto LAB_18153dc47;
            if (*(uint32 *)(lVar12 + 24) <= uVar5) {
              uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar8,0);
            }
            *(uint64 *)(lVar9 + 100) = *(uint64 *)(lVar12 + 80 + lVar10 * 72);
            *(uint32 *)(lVar9 + 108) = *(uint32 *)(lVar12 + 88 + lVar10 * 72);
            goto LAB_18153da70;
          }
          uVar5 = uVar5 + 1;
        }
        LAB_18153d6a1:
        lVar9 = UICamera.mHits;
        if (lVar9 == null) goto LAB_18153dc47;
        BetterList_1.Clear(lVar9,DAT_181da7ad0);
        uVar15 = uVar15 + 1;
        goto LAB_18153be70;
    }

    // Token : 0x600071B
    // RVA   : 0x153BD00   Offset: 0x153B100   Length: 0x208C
    public static bool Raycast(Vector3 inPos)
    {
        var pStatics_f690 = *(int64*)(DAT_181daf690 + 184);
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
        LAB_18153be70:
        do {
          if (UICamera.list == null) goto LAB_18153dc47;
          if (UICamera.list.eventType <= (int)uVar15) {
            return false;
          }
          if ((UICamera.list == null) ||
             (lVar9 = *(int64 *)(UICamera.list + 16)) == null)
          goto LAB_18153dc47;
          if (*(uint32 *)(lVar9 + 24) <= uVar15) {
            uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar8,0);
          }
          lVar9 = lVar9[uVar15];
          if (lVar9 == null) goto LAB_18153dc47;
          cVar3 = Behaviour.get_enabled(lVar9,0);
          if (cVar3) {
            uVar8 = Component.get_gameObject(lVar9,0);
            cVar3 = NGUITools.GetActive(uVar8,0);
            if (!cVar3) goto LAB_18153d789;
            uVar8 = UICamera.get_cachedCamera(lVar9,0);
            UICamera.currentCamera = uVar8;
            lVar10 = UICamera.currentCamera;
            if (lVar10 == null) goto LAB_18153dc47;
            iVar4 = Camera.get_targetDisplay(lVar10,0);
            if (iVar4 != 0) goto LAB_18153d789;
            lVar10 = UICamera.currentCamera;
            if (lVar10 == null) goto LAB_18153dc47;
            local_328 = *inPos;
            local_320 = *(uint32 *)(inPos + 1);
            puVar13 = (uint64 *)Camera.ScreenToViewportPoint(local_208,lVar10,&local_328,0);
            local_318 = *puVar13;
            fVar16 = (float)local_318;
            cVar3 = Single.IsNaN(fVar16,0);
            if (cVar3) goto LAB_18153d789;
            fVar17 = local_318._4_4_;
            cVar3 = Single.IsNaN(local_318._4_4_,0);
            if ((((cVar3) || (fVar16 < 0.0)) || (1.0 < fVar16)) ||
               ((fVar17 < 0.0 || (1.0 < fVar17)))) goto LAB_18153d789;
            lVar10 = UICamera.currentCamera;
            if (lVar10 == null) goto LAB_18153dc47;
            local_308 = *inPos;
            local_300 = *(uint32 *)(inPos + 1);
            puVar13 = (uint64 *)Camera.ScreenPointToRay(&local_348,lVar10,&local_308);
            local_368 = *puVar13;
            uStack_360 = puVar13[1];
            local_358 = puVar13[2];
            lVar10 = UICamera.currentCamera;
            if (lVar10 == null) goto LAB_18153dc47;
            uVar5 = Camera.get_cullingMask(lVar10,0);
            uVar6 = LayerMask.op_Implicit(*(uint32 *)(lVar9 + 32),0);
            fVar16 = *(float *)(lVar9 + 72);
            uVar6 = uVar6 & uVar5;
            if (fVar16 <= 0.0) {
              lVar10 = UICamera.currentCamera;
              if (lVar10 == null) goto LAB_18153dc47;
              fVar16 = (float)Camera.get_farClipPlane(lVar10,0);
              lVar10 = UICamera.currentCamera;
              if (lVar10 == null) goto LAB_18153dc47;
              fVar17 = (float)Camera.get_nearClipPlane(lVar10,0);
              fVar16 = fVar16 - fVar17;
            }
            uVar2 = local_358;
            uVar11 = uStack_360;
            uVar8 = local_368;
            iVar4 = *(int *)(lVar9 + 24);
            local_res18[0] = fVar16;
            if (iVar4 == 0) {
              lVar10 = pStatics_f690;
              *(uint64 *)(lVar10 + 112) = uVar8;
              *(uint64 *)(lVar10 + 120) = uVar11;
              *(uint64 *)(lVar10 + 128) = uVar2;
              local_228 = local_368;
              uStack_220 = uStack_360;
              local_218 = local_358;
              cVar3 = Physics.Raycast(&local_228,pStatics_f690 + 136,
                                       local_res18[0],uVar6,1,0);
              if (!cVar3) goto LAB_18153d789;
              puVar13 = (uint64 *)
                        FUN_18045e0a0(local_298,pStatics_f690 + 136,0);
              lVar10 = pStatics_f690;
              *(uint64 *)(lVar10 + 100) = *puVar13;
              *(uint32 *)(lVar10 + 108) = *(uint32 *)(puVar13 + 1);
              lVar10 = RaycastHit.get_collider(pStatics_f690 + 136,0);
              if (lVar10 != null) {
                uVar8 = Component.get_gameObject(lVar10,0);
                UICamera.mRayHitObject = uVar8;
                if (*(char *)(lVar9 + 28) != false) {
                  return true;
                }
                lVar9 = UICamera.mRayHitObject;
                if ((lVar9 != null) && (lVar9 = FUN_180f93010(lVar9,0)) != null) {
                  lVar9 = FUN_180967b70(lVar9,DAT_181d74ed8);
        LAB_18153dbb5:
                  cVar3 = Object.op_Inequality(lVar9,0,0);
                  if (!cVar3) {
                    return true;
                  }
                  if (lVar9 != null) {
                    uVar8 = Component.get_gameObject(lVar9,0);
                    UICamera.mRayHitObject = uVar8;
                    return true;
                  }
                }
              }
        LAB_18153dc47:
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            if (iVar4 == 1) {
              if (UICamera.mRayHits == null) {
                uVar8 = FUN_1800d60b0(DAT_181da4838,50);
                UICamera.mRayHits = uVar8;
              }
              uVar2 = local_358;
              uVar11 = uStack_360;
              uVar8 = local_368;
              local_248 = uVar8;
              uStack_240 = uVar11;
              local_238 = uVar2;
              iVar4 = Physics.RaycastNonAlloc
                                (&local_248,UICamera.mRayHits,
                                 local_res18[0],uVar6,2,0);
              if (1 < iVar4) {
                uVar5 = 0;
        LAB_18153d096:
                lVar9 = UICamera.mRayHits;
                if (lVar9 == null) goto LAB_18153dc47;
                if (*(uint32 *)(lVar9 + 24) <= uVar5) {
                  uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1800d65f0(uVar8,0);
                }
                lVar10 = (int64)(int)uVar5 * 44;
                lVar9 = RaycastHit.get_collider(lVar9 + 32 + lVar10,0);
                if ((lVar9 == null) || (lVar9 = Component.get_gameObject(lVar9,0)) == null)
                goto LAB_18153dc47;
                plVar14 = (int64 *)GameObject.GetComponent(lVar9);
                cVar3 = Object.op_Inequality(plVar14,0,0);
                if (!cVar3) {
                  lVar12 = NGUITools.FindInParents(lVar9);
                  cVar3 = Object.op_Inequality(lVar12,0,0);
                  if (cVar3) {
                    if (lVar12 != null) {
                      if (*(float *)(lVar12 + 140) <= 0.001 && *(float *)(lVar12 + 140) != 0.001)
                      goto LAB_18153d4fb;
                      goto LAB_18153d2d0;
                    }
                    goto LAB_18153dc47;
                  }
                }
                else {
                  if (plVar14 == (int64 *)0) goto LAB_18153dc47;
                  cVar3 = UIWidget.get_isVisible(plVar14);
                  if (!cVar3) goto LAB_18153d4fb;
                  if (((*(byte *)(DAT_181db0390 + 300) <= *(byte *)(*plVar14 + 300)) &&
                      (*(int64 *)
                        (*(int64 *)(*plVar14 + 200) + -8 +
                        (uint64)*(byte *)(DAT_181db0390 + 300) * 8) == DAT_181db0390)) &&
                     (lVar12 = UISpriteCollection.GetCurrentSprite(local_c8),
                     (char)*(uint64 *)(lVar12 + 56) == false)) goto LAB_18153d4fb;
                  lVar12 = plVar14[28];
                  if (lVar12 != null) {
                    lVar1 = UICamera.mRayHits;
                    if (lVar1 == null) goto LAB_18153dc47;
                    if (*(uint32 *)(lVar1 + 24) <= uVar5) {
                      uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                      FUN_1800d65f0(uVar8,0);
                    }
                    puVar13 = (uint64 *)FUN_18045e0a0(local_1b8,lVar1 + 32 + lVar10);
                    local_2a8 = *puVar13;
                    local_2a0 = *(uint32 *)(puVar13 + 1);
                    cVar3 = HitCheck.Invoke(lVar12);
                    if (!cVar3) goto LAB_18153d4fb;
                  }
                }
        LAB_18153d2d0:
                uVar7 = NGUITools.CalculateRaycastDepth(lVar9,0);
                UICamera.mHit = uVar7;
                if (UICamera.mHit != 0x7fffffff) {
                  lVar9 = pStatics_f690;
                  lVar12 = *(int64 *)(lVar9 + 0x240);
                  if (lVar12 == null) goto LAB_18153dc47;
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
                  lVar9 = UICamera.mRayHits;
                  if (lVar9 == null) goto LAB_18153dc47;
                  if (*(uint32 *)(lVar9 + 24) <= uVar5) {
                    uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                    FUN_1800d65f0(uVar8,0);
                  }
                  puVar13 = (uint64 *)FUN_18045e0a0(local_298,lVar9 + 32 + lVar10,0);
                  lVar9 = pStatics_f690;
                  *(uint64 *)(lVar9 + 0x220) = *puVar13;
                  *(uint32 *)(lVar9 + 0x228) = *(uint32 *)(puVar13 + 1);
                  lVar9 = UICamera.mRayHits;
                  if (lVar9 == null) goto LAB_18153dc47;
                  if (*(uint32 *)(lVar9 + 24) <= uVar5) {
                    uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                    FUN_1800d65f0(uVar8,0);
                  }
                  lVar9 = RaycastHit.get_collider(lVar9 + 32 + lVar10,0);
                  if (lVar9 == null) goto LAB_18153dc47;
                  uVar8 = Component.get_gameObject(lVar9,0);
                  puVar13 = (uint64 *)(pStatics_f690 + 0x230);
                  *puVar13 = uVar8;
                  il2cpp_internal(puVar13,uVar8);
                  lVar9 = pStatics_f690;
                  if (*(int64 *)(lVar9 + 0x238) == 0) goto LAB_18153dc47;
                  local_158 = *(uint64 *)(lVar9 + 0x1f0);
                  uStack_150 = *(uint64 *)(lVar9 + 0x1f8);
                  local_148 = *(uint64 *)(lVar9 + 0x200);
                  uStack_140 = *(uint64 *)(lVar9 + 0x208);
                  local_138 = *(uint64 *)(lVar9 + 0x210);
                  uStack_130 = *(uint64 *)(lVar9 + 0x218);
                  local_128 = *(uint64 *)(lVar9 + 0x220);
                  uStack_120 = *(uint64 *)(lVar9 + 0x228);
                  local_118 = *(uint64 *)(lVar9 + 0x230);
                  FUN_1815843b0();
                }
        LAB_18153d4fb:
                uVar5 = uVar5 + 1;
                if (iVar4 <= (int)uVar5) break;
                goto LAB_18153d096;
              }
              if (iVar4 == 1) {
                lVar9 = UICamera.mRayHits;
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
                      lVar9 = NGUITools.FindInParents(lVar9,DAT_181d8f5b8);
                      cVar3 = Object.op_Inequality(lVar9,0,0);
                      if (cVar3) {
                        if (lVar9 == null) goto LAB_18153dc47;
                        if (*(float *)(lVar9 + 140) <= 0.001 && *(float *)(lVar9 + 140) != 0.001)
                        goto LAB_18153d789;
                      }
                    }
                    else {
                      if (lVar10 == null) goto LAB_18153dc47;
                      cVar3 = UIWidget.get_isVisible(lVar10,0);
                      if (!cVar3) goto LAB_18153d789;
                      lVar9 = *(int64 *)(lVar10 + 224);
                      if (lVar9 != null) {
                        lVar10 = UICamera.mRayHits;
                        if (lVar10 == null) goto LAB_18153dc47;
                        if (*(int *)(lVar10 + 24) == 0) {
                          uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                          FUN_1800d65f0(uVar8,0);
                        }
                        puVar13 = (uint64 *)FUN_18045e0a0(local_1d8,lVar10 + 32,0);
                        local_2c8 = *puVar13;
                        local_2c0 = *(uint32 *)(puVar13 + 1);
                        cVar3 = HitCheck.Invoke(lVar9,&local_2c8,0);
                        if (!cVar3) goto LAB_18153d789;
                      }
                    }
                    lVar9 = UICamera.mRayHits;
                    if (lVar9 != null) {
                      if (*(int *)(lVar9 + 24) == 0) {
                        uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                        FUN_1800d65f0(uVar8,0);
                      }
                      puVar13 = (uint64 *)FUN_18045e0a0(local_1c8,lVar9 + 32,0);
                      uVar8 = *puVar13;
                      uVar7 = *(uint32 *)(puVar13 + 1);
                      lVar9 = UICamera.mRayHits;
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
                          if (!cVar3) goto LAB_18153d789;
                          lVar9 = pStatics_f690;
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
                            lVar9 = pStatics_f690;
                            *(uint32 *)(lVar9 + 112) = (uint32)local_368;
                            *(uint32 *)(lVar9 + 116) = local_368._4_4_;
                            *(uint32 *)(lVar9 + 120) = (uint32)uStack_360;
                            *(uint32 *)(lVar9 + 124) = uStack_360._4_4_;
                            *(uint64 *)(lVar9 + 128) = local_358;
                            lVar9 = UICamera.mRayHits;
                            if (lVar9 != null) {
                              if (*(int *)(lVar9 + 24) == 0) {
                                uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                FUN_1800d65f0(uVar8,0);
                              }
                              puVar13 = (uint64 *)FUN_18045e0a0(local_298,lVar9 + 32,0);
                              lVar9 = pStatics_f690;
                              *(uint64 *)(lVar9 + 100) = *puVar13;
                              *(uint32 *)(lVar9 + 108) = *(uint32 *)(puVar13 + 1);
                              lVar9 = RaycastHit.get_collider
                                                (pStatics_f690 + 136,0);
                              if (lVar9 != null) {
                                uVar8 = Component.get_gameObject(lVar9,0);
                                UICamera.mRayHitObject = uVar8;
                                return true;
                              }
                            }
                          }
                        }
                      }
                    }
                  }
                }
                goto LAB_18153dc47;
              }
            }
            else if (iVar4 == 2) {
              local_268 = (uint32)local_368;
              uStack_264 = local_368._4_4_;
              uStack_260 = (uint32)uStack_360;
              uStack_25c = uStack_360._4_4_;
              local_258 = local_358;
              cVar3 = Plane.Raycast(pStatics_f690 + 0x250,&local_268,local_res18);
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
                if (!cVar3) goto LAB_18153d789;
                lVar12 = pStatics_f690;
                *(uint64 *)(lVar12 + 100) = uVar8;
                *(uint32 *)(lVar12 + 108) = uVar7;
                if (lVar10 != null) {
                  uVar8 = Component.get_gameObject(lVar10,0);
                  UICamera.mRayHitObject = uVar8;
                  if (*(char *)(lVar9 + 28) != false) {
                    return true;
                  }
                  lVar9 = UICamera.mRayHitObject;
                  if (lVar9 != null) {
                    uVar8 = GameObject.get_transform(lVar9,0);
                    lVar9 = UICamera.FindRootRigidbody2D(uVar8,0);
                    goto LAB_18153dbb5;
                  }
                }
                goto LAB_18153dc47;
              }
            }
            else {
              if (iVar4 != 3) goto LAB_18153d789;
              local_288 = (uint32)local_368;
              uStack_284 = local_368._4_4_;
              uStack_280 = (uint32)uStack_360;
              uStack_27c = uStack_360._4_4_;
              local_278 = local_358;
              cVar3 = Plane.Raycast(pStatics_f690 + 0x250,&local_288,local_res18);
              if (!cVar3) goto LAB_18153d789;
              puVar13 = (uint64 *)Ray.GetPoint(local_1f8,&local_368,local_res18[0]);
              uVar8 = *puVar13;
              uVar7 = *(uint32 *)(puVar13 + 1);
              lVar9 = pStatics_f690;
              *(uint64 *)(lVar9 + 100) = uVar8;
              *(uint32 *)(lVar9 + 108) = uVar7;
              if (UICamera.mOverlap == null) {
                uVar8 = FUN_1800d60b0(DAT_181da10d8,50);
                UICamera.mOverlap = uVar8;
              }
              lVar9 = pStatics_f690;
              local_348 = *(uint64 *)(lVar9 + 100);
              local_res20 = (uint32)local_348;
              uStackX_24 = (uint32)((uint64)local_348 >> 32);
              local_340 = *(uint32 *)(lVar9 + 108);
              uVar8 = *(uint64 *)(lVar9 + 0x248);
              iVar4 = Physics2D.OverlapPointNonAlloc(CONCAT44(uStackX_24,local_res20),uVar8,uVar6);
              if (1 < iVar4) {
                uVar5 = 0;
                do {
                  lVar9 = UICamera.mOverlap;
                  if (lVar9 == null) goto LAB_18153dc47;
                  if (*(uint32 *)(lVar9 + 24) <= uVar5) {
                    uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                    FUN_1800d65f0(uVar8,0);
                  }
                  lVar9 = lVar9[uVar5];
                  if ((lVar9 == null) || (lVar9 = Component.get_gameObject(lVar9,0)) == null)
                  goto LAB_18153dc47;
                  lVar10 = GameObject.GetComponent(lVar9);
                  cVar3 = Object.op_Inequality(lVar10,0,0);
                  if (!cVar3) {
                    lVar10 = NGUITools.FindInParents(lVar9);
                    cVar3 = Object.op_Inequality(lVar10,0,0);
                    if (cVar3) {
                      if (lVar10 == null) goto LAB_18153dc47;
                      if (*(float *)(lVar10 + 140) <= 0.001 && *(float *)(lVar10 + 140) != 0.001)
                      goto LAB_18153c8fc;
                    }
        LAB_18153c7a9:
                    uVar7 = NGUITools.CalculateRaycastDepth(lVar9,0);
                    UICamera.mHit = uVar7;
                    if (UICamera.mHit != 0x7fffffff) {
                      plVar14 = (int64 *)(pStatics_f690 + 0x230);
                      *plVar14 = lVar9;
                      il2cpp_internal(plVar14,lVar9);
                      lVar9 = pStatics_f690;
                      *(uint64 *)(lVar9 + 0x220) = *(uint64 *)(lVar9 + 100);
                      *(uint32 *)(lVar9 + 0x228) = *(uint32 *)(lVar9 + 108);
                      lVar9 = pStatics_f690;
                      if (*(int64 *)(lVar9 + 0x238) == 0) goto LAB_18153dc47;
                      local_1a8 = *(uint64 *)(lVar9 + 0x1f0);
                      uStack_1a0 = *(uint64 *)(lVar9 + 0x1f8);
                      local_198 = *(uint64 *)(lVar9 + 0x200);
                      uStack_190 = *(uint64 *)(lVar9 + 0x208);
                      local_188 = *(uint64 *)(lVar9 + 0x210);
                      uStack_180 = *(uint64 *)(lVar9 + 0x218);
                      local_178 = *(uint64 *)(lVar9 + 0x220);
                      uStack_170 = *(uint64 *)(lVar9 + 0x228);
                      local_168 = *(uint64 *)(lVar9 + 0x230);
                      FUN_1815843b0();
                    }
                  }
                  else {
                    if (lVar10 == null) goto LAB_18153dc47;
                    cVar3 = UIWidget.get_isVisible(lVar10);
                    if (cVar3) {
                      lVar10 = *(int64 *)(lVar10 + 224);
                      if (lVar10 != null) {
                        local_2d0 = *(uint32 *)(pStatics_f690 + 108);
                        local_2d8 = UICamera.lastWorldPosition;
                        cVar3 = HitCheck.Invoke(lVar10);
                        if (!cVar3) goto LAB_18153c8fc;
                      }
                      goto LAB_18153c7a9;
                    }
                  }
        LAB_18153c8fc:
                  uVar5 = uVar5 + 1;
                } while ((int)uVar5 < iVar4);
                lVar9 = UICamera.mHits;
                lVar10 = UICamera.GetKeyUp;
                if (lVar10 == null) {
                  uVar8 = **(uint64 **)(DAT_181d8d1d0 + 184);
                  lVar10 = new OnTooltipCB(uVar8,DAT_181db7b78);
                  UICamera.GetKeyUp = lVar10;
                }
                if (lVar9 != null) {
                  FUN_181586f40(lVar9,lVar10,DAT_181da7b50);
                  uVar5 = 0;
                  while( true ) {
                    lVar9 = UICamera.mHits;
                    if (lVar9 == null) goto LAB_18153dc47;
                    if (*(int *)(lVar9 + 24) <= (int)uVar5) break;
                    lVar9 = UICamera.mHits;
                    if ((lVar9 == null) || (lVar9 = *(int64 *)(lVar9 + 16)) == null)
                    goto LAB_18153dc47;
                    if (*(uint32 *)(lVar9 + 24) <= uVar5) {
                      uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                      FUN_1800d65f0(uVar8,0);
                    }
                    cVar3 = UICamera.IsVisible(lVar9 + (int64)(int)uVar5 * 72 + 32,0);
                    if (cVar3) {
                      lVar9 = UICamera.mHits;
                      if ((lVar9 != null) && (lVar9 = *(int64 *)(lVar9 + 16)) != null) {
                        if (*(uint32 *)(lVar9 + 24) <= uVar5) {
                          uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                          FUN_1800d65f0(uVar8,0);
                        }
                        UICamera.mRayHitObject =
                             *(uint64 *)(lVar9 + 96 + (int64)(int)uVar5 * 72);
                        il2cpp_internal();
        LAB_18153da70:
                        lVar9 = UICamera.mHits;
                        if (lVar9 != null) {
                          BetterList_1.Clear(lVar9,DAT_181da7ad0);
                          return true;
                        }
                      }
                      goto LAB_18153dc47;
                    }
                    uVar5 = uVar5 + 1;
                  }
                  goto LAB_18153d6a1;
                }
                goto LAB_18153dc47;
              }
              if (iVar4 == 1) {
                lVar9 = UICamera.mOverlap;
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
                      lVar10 = NGUITools.FindInParents(lVar9,DAT_181d8f5b8);
                      cVar3 = Object.op_Inequality(lVar10,0,0);
                      if (cVar3) {
                        if (lVar10 == null) goto LAB_18153dc47;
                        if (*(float *)(lVar10 + 140) <= 0.001 && *(float *)(lVar10 + 140) != 0.001)
                        goto LAB_18153d789;
                      }
                    }
                    else {
                      if (lVar10 == null) goto LAB_18153dc47;
                      cVar3 = UIWidget.get_isVisible(lVar10,0);
                      if (!cVar3) goto LAB_18153d789;
                      lVar10 = *(int64 *)(lVar10 + 224);
                      if (lVar10 != null) {
                        local_2f0 = *(uint32 *)(pStatics_f690 + 108);
                        local_2f8 = UICamera.lastWorldPosition;
                        cVar3 = HitCheck.Invoke(lVar10,&local_2f8,0);
                        if (!cVar3) goto LAB_18153d789;
                      }
                    }
                    local_2e8 = UICamera.lastWorldPosition;
                    local_2e0 = *(uint32 *)(pStatics_f690 + 108);
                    cVar3 = UICamera.IsVisible(&local_2e8,lVar9,0);
                    if (cVar3) {
                      UICamera.mRayHitObject = lVar9;
                      return true;
                    }
                    goto LAB_18153d789;
                  }
                }
                goto LAB_18153dc47;
              }
            }
          }
        LAB_18153d789:
          uVar15 = uVar15 + 1;
        } while( true );
        lVar9 = UICamera.mHits;
        lVar10 = UICamera.GetKeyDown;
        if (lVar10 == null) {
          uVar8 = **(uint64 **)(DAT_181d8d1d0 + 184);
          lVar10 = new OnTooltipCB(uVar8,DAT_181db7af0);
          UICamera.GetKeyDown = lVar10;
        }
        if (lVar9 == null) goto LAB_18153dc47;
        FUN_181586f40(lVar9,lVar10,DAT_181da7b50);
        uVar5 = 0;
        while( true ) {
          lVar9 = UICamera.mHits;
          if (lVar9 == null) goto LAB_18153dc47;
          if (*(int *)(lVar9 + 24) <= (int)uVar5) break;
          lVar9 = UICamera.mHits;
          if ((lVar9 == null) || (lVar9 = *(int64 *)(lVar9 + 16)) == null) goto LAB_18153dc47;
          lVar10 = (int64)(int)uVar5;
          if (*(uint32 *)(lVar9 + 24) <= uVar5) {
            uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar8,0);
          }
          cVar3 = UICamera.IsVisible(lVar9 + lVar10 * 72 + 32,0);
          if (cVar3) {
            lVar9 = pStatics_f690;
            if ((*(int64 *)(lVar9 + 0x238) == 0) ||
               (lVar12 = *(int64 *)(*(int64 *)(lVar9 + 0x238) + 16)) == null)
            goto LAB_18153dc47;
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
            lVar9 = UICamera.mHits;
            if ((lVar9 == null) || (lVar9 = *(int64 *)(lVar9 + 16)) == null) goto LAB_18153dc47;
            if (*(uint32 *)(lVar9 + 24) <= uVar5) {
              uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar8,0);
            }
            UICamera.mRayHitObject =
                 *(uint64 *)(lVar9 + 96 + lVar10 * 72);
            il2cpp_internal();
            lVar9 = pStatics_f690;
            *(uint32 *)(lVar9 + 112) = (uint32)local_368;
            *(uint32 *)(lVar9 + 116) = local_368._4_4_;
            *(uint32 *)(lVar9 + 120) = (uint32)uStack_360;
            *(uint32 *)(lVar9 + 124) = uStack_360._4_4_;
            *(uint64 *)(lVar9 + 128) = local_358;
            lVar9 = pStatics_f690;
            if ((*(int64 *)(lVar9 + 0x238) == 0) ||
               (lVar12 = *(int64 *)(*(int64 *)(lVar9 + 0x238) + 16)) == null)
            goto LAB_18153dc47;
            if (*(uint32 *)(lVar12 + 24) <= uVar5) {
              uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar8,0);
            }
            *(uint64 *)(lVar9 + 100) = *(uint64 *)(lVar12 + 80 + lVar10 * 72);
            *(uint32 *)(lVar9 + 108) = *(uint32 *)(lVar12 + 88 + lVar10 * 72);
            goto LAB_18153da70;
          }
          uVar5 = uVar5 + 1;
        }
        LAB_18153d6a1:
        lVar9 = UICamera.mHits;
        if (lVar9 == null) goto LAB_18153dc47;
        BetterList_1.Clear(lVar9,DAT_181da7ad0);
        uVar15 = uVar15 + 1;
        goto LAB_18153be70;
    }

    // Token : 0x600071C
    // RVA   : 0x15352B0   Offset: 0x15346B0   Length: 0x101
    private static bool IsVisible(Vector3 worldPoint, GameObject go)
    {
        ulong uVar1;
        bool cVar2;
        long lVar3;
        uVar1 = *(uint64 *)(worldPoint + 64);
        lVar3 = NGUITools.FindInParents(uVar1,DAT_181d8f4b8);
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
    // RVA   : 0x15353C0   Offset: 0x15347C0   Length: 0x102
    private static bool IsVisible(ref DepthEntry de)
    {
        ulong uVar1;
        bool cVar2;
        long lVar3;
        uVar1 = *(uint64 *)(de + 64);
        lVar3 = NGUITools.FindInParents(uVar1,DAT_181d8f4b8);
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
    // RVA   : 0x1534E40   Offset: 0x1534240   Length: 0x93
    public static bool IsHighlighted(GameObject go)
    {
        ulong uVar1;
        uVar1 = UICamera.get_hoveredObject(0);
        Object.op_Equality(uVar1,go,0);
    }

    // Token : 0x600071F
    // RVA   : 0x1534350   Offset: 0x1533750   Length: 0x16C
    public static UICamera FindCameraForLayer(int layer)
    {
        long lVar1;
        bool cVar2;
        uint uVar3;
        long lVar4;
        ulong uVar5;
        uint uVar6;
        uVar6 = 0;
        while( true ) {
          if (UICamera.list == null) break;
          if (UICamera.list.eventType <= (int)uVar6) {
            return 0;
          }
          if ((UICamera.list == null) ||
             (lVar1 = *(int64 *)(UICamera.list + 16)) == null) break;
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
    // RVA   : 0x1534760   Offset: 0x1533B60   Length: 0x142
    private static int GetDirection(KeyCode up, KeyCode down)
    {
        long lVar2;
        bool cVar3;
        float fVar4;
        float fVar5;
        fVar4 = (float)RealTime.get_time(0);
        pfVar1 = &UICamera.mNextEvent;
        if (*pfVar1 <= fVar4 && fVar4 != *pfVar1) {
          cVar3 = FUN_180d75bc0(up,0);
          if (!cVar3) {
            lVar2 = UICamera.GetAxis;
            if (lVar2 == null) {
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            fVar5 = (float)GetAxisFunc.Invoke(lVar2,up,0);
            if (0.75 < fVar5) {
              UICamera.set_currentKey(0x14a,0);
              UICamera.mNextEvent = fVar4 + 0.25;
              return 1;
            }
            if (fVar5 < -0.75) {
              UICamera.set_currentKey(0x14a,0);
              UICamera.mNextEvent = fVar4 + 0.25;
              return 0xffffffff;
            }
          }
        }
        return 0;
    }

    // Token : 0x6000721
    // RVA   : 0x15348B0   Offset: 0x1533CB0   Length: 0x237
    private static int GetDirection(KeyCode up0, KeyCode up1, KeyCode down0, KeyCode down1)
    {
        long lVar2;
        bool cVar3;
        float fVar4;
        float fVar5;
        fVar4 = (float)RealTime.get_time(0);
        pfVar1 = &UICamera.mNextEvent;
        if (*pfVar1 <= fVar4 && fVar4 != *pfVar1) {
          cVar3 = FUN_180d75bc0(up0,0);
          if (!cVar3) {
            lVar2 = UICamera.GetAxis;
            if (lVar2 == null) {
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            fVar5 = (float)GetAxisFunc.Invoke(lVar2,up0,0);
            if (0.75 < fVar5) {
              UICamera.set_currentKey(0x14a,0);
              UICamera.mNextEvent = fVar4 + 0.25;
              return 1;
            }
            if (fVar5 < -0.75) {
              UICamera.set_currentKey(0x14a,0);
              UICamera.mNextEvent = fVar4 + 0.25;
              return 0xffffffff;
            }
          }
        }
        return 0;
    }

    // Token : 0x6000722
    // RVA   : 0x1534AF0   Offset: 0x1533EF0   Length: 0x1A5
    private static int GetDirection(string axis)
    {
        long lVar2;
        bool cVar3;
        float fVar4;
        float fVar5;
        fVar4 = (float)RealTime.get_time(0);
        pfVar1 = &UICamera.mNextEvent;
        if (*pfVar1 <= fVar4 && fVar4 != *pfVar1) {
          cVar3 = FUN_180d75bc0(axis,0);
          if (!cVar3) {
            lVar2 = UICamera.GetAxis;
            if (lVar2 == null) {
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            fVar5 = (float)GetAxisFunc.Invoke(lVar2,axis,0);
            if (0.75 < fVar5) {
              UICamera.set_currentKey(0x14a,0);
              UICamera.mNextEvent = fVar4 + 0.25;
              return 1;
            }
            if (fVar5 < -0.75) {
              UICamera.set_currentKey(0x14a,0);
              UICamera.mNextEvent = fVar4 + 0.25;
              return 0xffffffff;
            }
          }
        }
        return 0;
    }

    // Token : 0x6000723
    // RVA   : 0x1535680   Offset: 0x1534A80   Length: 0x3AD
    public static void Notify(GameObject go, string funcName, object obj)
    {
        ulong uVar2;
        long lVar3;
        bool cVar4;
        int iVar5;
        if (UICamera.mNotifying < 11) {
          iVar5 = UICamera.get_currentScheme(0);
          if (iVar5 == 2) {
            cVar4 = UIPopupList.get_isOpen(0);
            if (cVar4) {
              if (UIPopupList.current == null) goto LAB_181535a28;
              uVar2 = UIPopupList.current.source;
              cVar4 = Object.op_Equality(uVar2,go,0);
              if (cVar4) {
                cVar4 = UIPopupList.get_isOpen(0);
                if (cVar4) {
                  if (UIPopupList.current == null) goto LAB_181535a28;
                  go = Component.get_gameObject(UIPopupList.current,0);
                }
              }
            }
          }
          cVar4 = Object.op_Implicit(go,0);
          if (cVar4) {
            if (go == null) {
        LAB_181535a28:
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            cVar4 = GameObject.get_activeInHierarchy(go,0);
            if (cVar4) {
              UICamera.mNotifying = *piVar1 + 1;
              GameObject.SendMessage(go,funcName,obj,1,0);
              uVar2 = UICamera.mGenericHandler;
              cVar4 = Object.op_Inequality(uVar2,0,0);
              if (cVar4) {
                uVar2 = UICamera.mGenericHandler;
                cVar4 = Object.op_Inequality(uVar2,go,0);
                if (cVar4) {
                  lVar3 = UICamera.mGenericHandler;
                  if (lVar3 == null) goto LAB_181535a28;
                  GameObject.SendMessage(lVar3,funcName,obj,1,0);
                }
              }
              UICamera.mNotifying = *piVar1 + -1;
            }
          }
        }
    }

    // Token : 0x6000724
    // RVA   : 0x15339B0   Offset: 0x1532DB0   Length: 0x5B6
    private void Awake()
    {
        var pStatics = *(int64*)(DAT_181daf690 + 184);
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
        UICamera.mWidth = uVar3;
        uVar3 = Screen.get_height(0);
        UICamera.mHeight = uVar3;
        iVar4 = Application.get_platform(0);
        if ((iVar4 == 25) || (iVar4 = Application.get_platform(0), iVar4 == 27)) {
          if (UICamera.mLastScheme != 2) {
            UICamera.set_currentKey(0x14a,0);
            UICamera.mLastScheme = 2;
          }
        }
        lVar6 = UICamera.mMouse;
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
              lVar6 = UICamera.mMouse;
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
              lVar6 = UICamera.mMouse;
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
                    cVar2 = FUN_18171eb50(uVar7,"-noMouse",0);
                    if (!cVar2) {
                      cVar2 = FUN_18171eb50(uVar7,"-noTouch",0);
                      if (!cVar2) {
                        cVar2 = FUN_18171eb50(uVar7,"-noController",0);
                        if ((!cVar2) &&
                           (cVar2 = FUN_18171eb50(uVar7,"-noJoystick",0), !cVar2)) {
                          cVar2 = FUN_18171eb50(uVar7,"-useMouse",0);
                          if (!cVar2) {
                            cVar2 = FUN_18171eb50(uVar7,"-useTouch",0);
                            if (!cVar2) {
                              cVar2 = FUN_18171eb50(uVar7,"-useController",0);
                              if ((!cVar2) &&
                                 (cVar2 = FUN_18171eb50(uVar7,"-useJoystick",0), !cVar2))
                              goto LAB_181533ed5;
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
                          UICamera.ignoreControllerInput = 1;
                        }
                      }
                      else {
                        this.useTouch = 0;
                        uVar8 = uVar8 + 1;
                      }
                    }
                    else {
                      this.useMouse = 0;
        LAB_181533ed5:
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
    // RVA   : 0x1535AC0   Offset: 0x1534EC0   Length: 0x10A
    private void OnEnable()
    {
        long lVar1;
        ulong uVar2;
        if (UICamera.list != null) {
          FUN_181584270(UICamera.list,this,DAT_181da6750);
          lVar1 = UICamera.list;
          uVar2 = new OnTooltipCB(0,DAT_181dc5c68,DAT_181daab50);
          if (lVar1 != null) {
            FUN_181586c60(lVar1,uVar2,DAT_181da6850);
            return;
          }
        }
    }

    // Token : 0x6000726
    // RVA   : 0x1535A30   Offset: 0x1534E30   Length: 0x81
    private void OnDisable()
    {
        if (UICamera.list != null) {
          FUN_181586280(UICamera.list,this,DAT_181da67d0);
          return;
        }
    }

    // Token : 0x6000727
    // RVA   : 0x153E200   Offset: 0x153D600   Length: 0x543
    private void Start()
    {
        bool cVar1;
        int iVar2;
        ulong uVar3;
        long lVar4;
        long lVar6;
        float fVar7;
        lVar4 = UICamera.list;
        uVar3 = new OnTooltipCB(0,DAT_181dc5c68,DAT_181daab50);
        if (lVar4 != null) {
          FUN_181586c60(lVar4,uVar3,DAT_181da6850);
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
          uVar3 = UICamera.fallThrough;
          cVar1 = Object.op_Equality(uVar3,0,0);
          if (cVar1) {
            uVar3 = Component.get_gameObject(this,0);
            lVar4 = NGUITools.FindInParents(uVar3,DAT_181d8f6b8);
            cVar1 = Object.op_Inequality(lVar4,0,0);
            lVar6 = this;
            if ((cVar1) && (lVar6 = lVar4, lVar4 == null)) throw; // [null/range check failed]
            uVar3 = Component.get_gameObject(lVar6,0);
            UICamera.fallThrough = uVar3;
          }
          lVar4 = UICamera.get_cachedCamera(this,0);
          if (lVar4 == null) throw; // [null/range check failed]
          Camera.set_eventMask(lVar4,0,0);
          if (UICamera.ignoreControllerInput) {
            return;
          }
          if (!UICamera.disableControllerCheck) {
            return;
          }
          if (!this.useController) {
            return;
          }
          cVar1 = UICamera.get_handlesEvents(this,0);
          if (!cVar1) {
            return;
          }
          UICamera.disableControllerCheck = 0;
          cVar1 = FUN_180d75bc0(this.horizontalAxisName,0);
          if (!cVar1) {
            lVar4 = UICamera.GetAxis;
            if (lVar4 == null) throw; // [null/range check failed]
            fVar7 = (float)GetAxisFunc.Invoke(lVar4,this.horizontalAxisName,0);
            if (0.1 < ABS(fVar7)) goto LAB_18153e6f1;
          }
          cVar1 = FUN_180d75bc0(this.verticalAxisName,0);
          if (!cVar1) {
            lVar4 = UICamera.GetAxis;
            if (lVar4 == null) throw; // [null/range check failed]
            fVar7 = (float)GetAxisFunc.Invoke(lVar4,this.verticalAxisName,0);
            if (0.1 < ABS(fVar7)) goto LAB_18153e6f1;
          }
          cVar1 = FUN_180d75bc0(this.horizontalPanAxisName,0);
          if (!cVar1) {
            lVar4 = UICamera.GetAxis;
            if (lVar4 == null) throw; // [null/range check failed]
            fVar7 = (float)GetAxisFunc.Invoke(lVar4,this.horizontalPanAxisName,0);
            if (0.1 < ABS(fVar7)) goto LAB_18153e6f1;
          }
          cVar1 = FUN_180d75bc0(this.verticalPanAxisName,0);
          if (cVar1) {
            return;
          }
          lVar4 = UICamera.GetAxis;
          if (lVar4 != null) {
            fVar7 = (float)GetAxisFunc.Invoke(lVar4,this.verticalPanAxisName,0);
            if (ABS(fVar7) <= 0.1) {
              return;
            }
        LAB_18153e6f1:
            UICamera.ignoreControllerInput = 1;
            return;
          }
        }
    }

    // Token : 0x6000728
    // RVA   : 0x153E1A0   Offset: 0x153D5A0   Length: 0x58
    private void StartIgnoring()
    {
        *(uint8 *)(*(int64 *)(DAT_181daf690 + 184) + 89) = 1;
    }

    // Token : 0x6000729
    // RVA   : 0x153E750   Offset: 0x153DB50   Length: 0x58
    private void StopIgnoring()
    {
        *(uint8 *)(*(int64 *)(DAT_181daf690 + 184) + 89) = 0;
    }

    // Token : 0x600072A
    // RVA   : 0x153E7B0   Offset: 0x153DBB0   Length: 0x83
    private void Update()
    {
        bool cVar1;
        if (*(char *)(*(int64 *)(DAT_181daf690 + 184) + 89) == false) {
          cVar1 = UICamera.get_handlesEvents(this,0);
          if ((cVar1) && (this.processEventsIn == null)) {
            UICamera.ProcessEvents(this,0);
            return;
          }
        }
    }

    // Token : 0x600072B
    // RVA   : 0x15354D0   Offset: 0x15348D0   Length: 0x1A9
    private void LateUpdate()
    {
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
          if (iVar3 == UICamera.mWidth) {
            if (iVar4 == UICamera.mHeight) {
              return;
            }
          }
          UICamera.mWidth = iVar3;
          UICamera.mHeight = iVar4;
          UIRoot.Broadcast("UpdateAnchors",0);
          if (UICamera.onScreenResize != null) {
            lVar1 = UICamera.onScreenResize;
            if (lVar1 == null) {
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            OnGeometryUpdated.Invoke(lVar1,0);
          }
        }
    }

    // Token : 0x600072C
    // RVA   : 0x1535BD0   Offset: 0x1534FD0   Length: 0x7EE
    private void ProcessEvents()
    {
        byte uVar1;
        long lVar2;
        bool cVar3;
        int iVar4;
        ulong uVar5;
        ulong uVar6;
        float fVar9;
        float fVar10;
        float[] local_res8 = new float[2];
        UICamera.current = this;
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
        if (UICamera.onCustomInput != null) {
          lVar2 = UICamera.onCustomInput;
          if (lVar2 == null) goto LAB_181536399;
          OnGeometryUpdated.Invoke(lVar2,0);
        }
        if ((this.useKeyboard) || (this.useController)) {
          cVar3 = UICamera.get_disableController(0);
          if (!cVar3) {
            if (!UICamera.ignoreControllerInput) {
              UICamera.ProcessOthers(this,0);
            }
          }
        }
        if (this.useMouse) {
          uVar6 = UICamera.mHover;
          cVar3 = Object.op_Inequality(uVar6,0,0);
          if (!cVar3) goto LAB_181536240;
          cVar3 = FUN_180d75bc0(this.scrollAxisName,0);
          if (!cVar3) {
            lVar2 = UICamera.GetAxis;
            if (lVar2 == null) goto LAB_181536399;
            fVar9 = (float)GetAxisFunc.Invoke(lVar2,this.scrollAxisName,0);
            if (fVar9 != 0.0) {
              if (UICamera.onScroll != null) {
                lVar2 = UICamera.onScroll;
                if (lVar2 == null) goto LAB_181536399;
                FloatDelegate.Invoke
                          (lVar2,UICamera.mHover,fVar9,0);
              }
              uVar6 = UICamera.mHover;
              local_res8[0] = fVar9;
              uVar5 = il2cpp_value_box(DAT_181da22f0,local_res8);
              UICamera.Notify(uVar6,"OnScroll",uVar5,0);
            }
          }
          iVar4 = UICamera.get_currentScheme(0);
          if (iVar4 == 0) {
            if (UICamera.showTooltips) {
              if (UICamera.mTooltipTime != null.0) {
                cVar3 = UIPopupList.get_isOpen(0);
                if (!cVar3) {
                  lVar2 = UICamera.mMouse;
                  if (lVar2 != null) {
                    if (*(int *)(lVar2 + 24) == 0) {
                      uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                      FUN_1800d65f0(uVar6,0);
                    }
                    if (*(int64 *)(lVar2 + 32) != 0) {
                      uVar6 = *(uint64 *)(*(int64 *)(lVar2 + 32) + 88);
                      cVar3 = Object.op_Equality(uVar6,0,0);
                      if (!cVar3) goto LAB_181536240;
                      fVar9 = UICamera.mTooltipTime;
                      fVar10 = (float)Time.get_unscaledTime(0);
                      if (fVar10 <= fVar9) {
                        lVar2 = UICamera.GetKey;
                        if (lVar2 == null) goto LAB_181536399;
                        cVar3 = GetKeyStateFunc.Invoke(lVar2,0x130,0);
                        if (!cVar3) {
                          lVar2 = UICamera.GetKey;
                          if (lVar2 == null) goto LAB_181536399;
                          cVar3 = GetKeyStateFunc.Invoke(lVar2,0x12f,0);
                          if (!cVar3) goto LAB_181536240;
                        }
                      }
                      lVar2 = UICamera.mMouse;
                      if (lVar2 != null) {
                        if (*(int *)(lVar2 + 24) == 0) {
                          uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                          FUN_1800d65f0(uVar6,0);
                        }
                        UICamera.currentTouch =
                             *(uint64 *)(lVar2 + 32);
                        il2cpp_internal();
                        UICamera.currentTouchID = 0xffffffff;
                        UICamera.ShowTooltip
                                  (UICamera.mHover,0);
                        goto LAB_181536240;
                      }
                    }
                  }
        LAB_181536399:
                          // WARNING: Subroutine does not return
                  FUN_1800d6620();
                }
              }
            }
          }
        }
        LAB_181536240:
        uVar6 = UICamera.mTooltip;
        cVar3 = Object.op_Inequality(uVar6,0,0);
        if (cVar3) {
          uVar6 = UICamera.mTooltip;
          cVar3 = NGUITools.GetActive(uVar6,0);
          if (!cVar3) {
            UICamera.ShowTooltip(0,0);
          }
        }
        UICamera.current = 0;
        UICamera.currentTouchID = 0xffffff9c;
    }

    // Token : 0x600072D
    // RVA   : 0x1536860   Offset: 0x1535C60   Length: 0xFD7
    public void ProcessMouse()
    {
        var pStatics = *(int64*)(DAT_181daf690 + 184);
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
          lVar2 = UICamera.activeTouches;
          if (lVar2 == null) throw; // [null/range check failed]
          if (0 < *(int *)(lVar2 + 24)) {
            return;
          }
        }
        lVar2 = UICamera.mMouse;
        if (lVar2 == null) throw; // [null/range check failed]
        if (*(int *)(lVar2 + 24) == 0) {
          uVar15 = il2cpp_internal();
                          // WARNING: Subroutine does not return
          FUN_1800d65f0(uVar15,0);
        }
        UICamera.currentTouch = *(uint64 *)(lVar2 + 32);
        puVar14 = (uint64 *)Input.get_mousePosition(local_78,0);
        lVar2 = UICamera.currentTouch;
        if (lVar2 == null) throw; // [null/range check failed]
        local_98 = (float)*puVar14;
        fStack_84 = (float)((uint64)*puVar14 >> 32);
        if (lVar2.ignoreDelta == null) {
          lVar2 = UICamera.currentTouch;
          if (lVar2 == null) throw; // [null/range check failed]
          lVar2.delta = local_98 - lVar2.pos;
          *(float *)(lVar2 + 40) = fStack_84 - *(float *)(lVar2 + 24);
        }
        else {
          lVar2 = UICamera.currentTouch;
          if (lVar2 == null) throw; // [null/range check failed]
          piVar1 = (int *)(lVar2 + 120);
          *piVar1 = *piVar1 + -1;
          lVar2 = UICamera.currentTouch;
          if (lVar2 == null) throw; // [null/range check failed]
          lVar2.delta = 0;
          lVar2 = UICamera.currentTouch;
          if (lVar2 == null) throw; // [null/range check failed]
          *(uint32 *)(lVar2 + 40) = 0;
        }
        lVar2 = UICamera.currentTouch;
        if (lVar2 == null) throw; // [null/range check failed]
        fVar20 = (float)Vector2.get_sqrMagnitude(lVar2 + 36,0);
        lVar2 = UICamera.currentTouch;
        if (lVar2 == null) throw; // [null/range check failed]
        lVar2.pos = local_98;
        bVar7 = false;
        *(float *)(lVar2 + 24) = fStack_84;
        lVar2 = pStatics;
        *(float *)(lVar2 + 92) = local_98;
        lVar2.lastClickGO = fStack_84;
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
          lVar2 = UICamera.mMouse;
          if (lVar2 == null) throw; // [null/range check failed]
          if (*(uint32 *)(lVar2 + 24) <= uVar17) {
            uVar15 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar15,0);
          }
          lVar3 = UICamera.currentTouch;
          if (lVar3 == null) throw; // [null/range check failed]
          uVar22 = *(uint32 *)(lVar3 + 24);
          lVar2 = lVar2[uVar17];
          if (lVar2 == null) throw; // [null/range check failed]
          lVar2.pos = lVar3.pos;
          *(uint32 *)(lVar2 + 24) = uVar22;
          lVar2 = UICamera.mMouse;
          if (lVar2 == null) throw; // [null/range check failed]
          if (*(uint32 *)(lVar2 + 24) <= uVar17) {
            uVar15 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar15,0);
          }
          lVar3 = UICamera.currentTouch;
          if (lVar3 == null) throw; // [null/range check failed]
          uVar22 = *(uint32 *)(lVar3 + 40);
          lVar2 = lVar2[uVar17];
          if (lVar2 == null) throw; // [null/range check failed]
          uVar17 = uVar17 + 1;
          lVar2.delta = lVar3.delta;
          *(uint32 *)(lVar2 + 40) = uVar22;
        } while ((int)uVar17 < 3);
        if ((bVar7 || bVar5) ||
           (fVar20 = this.mNextRaycast, fVar21 = (float)RealTime.get_time(0), fVar20 < fVar21))
        {
          fVar20 = (float)RealTime.get_time(0);
          this.mNextRaycast = fVar20 + 0.02;
          UICamera.Raycast(UICamera.currentTouch,0);
          if (bVar5) {
            bVar7 = true;
            do {
              lVar2 = UICamera.mMouse;
              if (lVar2 == null) throw; // [null/range check failed]
              if (*(uint32 *)(lVar2 + 24) <= uVar18) {
                uVar15 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar15,0);
              }
              lVar3 = UICamera.currentTouch;
              if (lVar3 == null) throw; // [null/range check failed]
              lVar2 = lVar2[uVar18];
              if (lVar2 == null) throw; // [null/range check failed]
              lVar2.current = lVar3.current;
              uVar18 = uVar18 + 1;
            } while ((int)uVar18 < 3);
          }
          else {
            lVar2 = UICamera.mMouse;
            if (lVar2 == null) throw; // [null/range check failed]
            if (*(int *)(lVar2 + 24) == 0) {
              uVar15 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar15,0);
            }
            if (*(int64 *)(lVar2 + 32) == 0) throw; // [null/range check failed]
            lVar3 = UICamera.currentTouch;
            uVar15 = *(uint64 *)(*(int64 *)(lVar2 + 32) + 72);
            if (lVar3 == null) throw; // [null/range check failed]
            uVar4 = lVar3.current;
            cVar9 = Object.op_Inequality(uVar15,uVar4,0);
            if (cVar9) {
              UICamera.set_currentKey(0x143,0);
              bVar7 = true;
              uVar17 = 1;
              do {
                lVar2 = UICamera.mMouse;
                if (lVar2 == null) throw; // [null/range check failed]
                if (*(uint32 *)(lVar2 + 24) <= uVar17) {
                  uVar15 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1800d65f0(uVar15,0);
                }
                lVar3 = UICamera.currentTouch;
                if (lVar3 == null) throw; // [null/range check failed]
                lVar2 = lVar2[uVar17];
                if (lVar2 == null) throw; // [null/range check failed]
                lVar2.current = lVar3.current;
                uVar17 = uVar17 + 1;
              } while ((int)uVar17 < 3);
            }
          }
        }
        lVar2 = UICamera.currentTouch;
        if (lVar2 != null) {
          uVar15 = lVar2.last;
          uVar4 = lVar2.current;
          bVar10 = Object.op_Inequality(uVar15,uVar4,0);
          lVar2 = UICamera.currentTouch;
          if (lVar2 != null) {
            cVar9 = Object.op_Inequality(lVar2.pressed,0,0);
            bVar8 = false;
            if (!cVar9) {
              bVar8 = bVar7;
            }
            if (bVar8) {
              lVar2 = UICamera.currentTouch;
              if (lVar2 == null) throw; // [null/range check failed]
              UICamera.set_hoveredObject(lVar2.current,0);
            }
            UICamera.currentTouchID = 0xffffffff;
            if (bVar10 != 0) {
              UICamera.set_currentKey(0x143,0);
            }
            if ((bool)(bVar7 & !bVar5)) {
              if (UICamera.mTooltipTime == null.0) {
                uVar15 = UICamera.mTooltip;
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
                UICamera.mTooltipTime = fVar20 + fVar21;
              }
            }
            if (bVar7) {
              if (UICamera.onMouseMove != null) {
                lVar2 = UICamera.currentTouch;
                lVar3 = UICamera.onMouseMove;
                if ((lVar2 == null) || (lVar3 == null)) throw; // [null/range check failed]
                MoveDelegate.Invoke(lVar3,lVar2.delta,0);
                UICamera.currentTouch = 0;
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
              lVar2 = UICamera.mMouse;
              if (lVar2 == null) throw; // [null/range check failed]
              if (*(uint32 *)(lVar2 + 24) <= uVar17) {
                uVar15 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar15,0);
              }
              UICamera.currentTouch =
                   lVar2[uVar17];
              il2cpp_internal();
              UICamera.currentTouchID = ~uVar17;
              UICamera.set_currentKey(uVar17 + 0x143,0);
              if (!cVar9) {
                lVar2 = UICamera.currentTouch;
                if (lVar2 == null) throw; // [null/range check failed]
                uVar15 = lVar2.pressed;
                cVar13 = Object.op_Inequality(uVar15,0,0);
                if (cVar13) {
                  lVar2 = UICamera.currentTouch;
                  if (lVar2 == null) throw; // [null/range check failed]
                  UICamera.currentCamera =
                       lVar2.pressedCam;
                  il2cpp_internal();
                }
              }
              else {
                lVar2 = UICamera.currentTouch;
                if (lVar2 == null) throw; // [null/range check failed]
                lVar2.pressedCam =
                     UICamera.currentCamera;
                il2cpp_internal();
                lVar2 = UICamera.currentTouch;
                uVar22 = RealTime.get_time(0);
                if (lVar2 == null) throw; // [null/range check failed]
                lVar2.pressTime = uVar22;
              }
              UICamera.ProcessTouch(this,cVar9,cVar11,0);
              uVar17 = uVar17 + 1;
            } while ((int)uVar17 < 3);
            if ((!bVar5 & bVar10) != 0) {
              lVar2 = UICamera.mMouse;
              if (lVar2 == null) throw; // [null/range check failed]
              if (*(int *)(lVar2 + 24) == 0) {
                uVar15 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar15,0);
              }
              UICamera.currentTouch = *(uint64 *)(lVar2 + 32);
              fVar20 = (float)Time.get_unscaledTime(0);
              UICamera.mTooltipTime =
                   fVar20 + this.tooltipDelay;
              UICamera.currentTouchID = 0xffffffff;
              UICamera.set_currentKey(0x143,0);
              lVar2 = UICamera.currentTouch;
              if (lVar2 == null) throw; // [null/range check failed]
              UICamera.set_hoveredObject(lVar2.current,0);
            }
            UICamera.currentTouch = 0;
            lVar2 = UICamera.mMouse;
            if (lVar2 != null) {
              if (*(int *)(lVar2 + 24) == 0) {
                uVar15 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar15,0);
              }
              lVar2 = *(int64 *)(lVar2 + 32);
              if (lVar2 != null) {
                lVar2.last = lVar2.current;
                while( true ) {
                  lVar2 = UICamera.mMouse;
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
                  lVar3.last = *(uint64 *)(*(int64 *)(lVar2 + 32) + 64);
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
    // RVA   : 0x153B380   Offset: 0x153A780   Length: 0x75E
    public void ProcessTouches()
    {
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
        if (UICamera.GetInputTouchCount == null) {
          iVar2 = Input.get_touchCount(0);
        }
        else {
          lVar5 = UICamera.GetInputTouchCount;
          if (lVar5 == null) {
        LAB_18153bad9:
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          iVar2 = GetTouchCountCallback.Invoke(lVar5,0);
        }
        iVar9 = 0;
        if (iVar2 < 1) {
          if (iVar2 == 0) {
            if (!UICamera.mUsingTouchEvents) {
              if (!this.useMouse) {
                return;
              }
              UICamera.ProcessMouse(this,0);
              return;
            }
            UICamera.mUsingTouchEvents = 0;
            return;
          }
        }
        else {
          do {
            if (UICamera.GetInputTouch == null) {
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
              lVar5 = UICamera.GetInputTouch;
              if ((lVar5 == null) || (lVar5 = GetTouchCallback.Invoke(lVar5,iVar9,0)) == null)
              goto LAB_18153bad9;
              iVar3 = lVar5.pos;
              uVar12 = lVar5.key;
              local_res18 = *(float *)(lVar5 + 24);
              fVar13 = lVar5.lastPos;
              iVar4 = *(int *)(lVar5 + 32);
            }
            uVar8 = 1;
            if (this.allowMultiTouch) {
              uVar8 = uVar12;
            }
            UICamera.currentTouchID = uVar8;
            lVar5 = UICamera.GetTouch;
            if (lVar5 == null) goto LAB_18153bad9;
            uVar6 = GetTouchDelegate.Invoke
                              (lVar5,UICamera.currentTouchID,1,0);
            UICamera.currentTouch = uVar6;
            if (iVar3 == 0) {
              cVar1 = true;
              bVar11 = true;
        LAB_18153b66e:
              bVar10 = iVar3 == 3;
            }
            else {
              lVar5 = UICamera.currentTouch;
              if (lVar5 == null) goto LAB_18153bad9;
              cVar1 = lVar5.touchBegan;
              bVar11 = cVar1;
              if (iVar3 != 4) goto LAB_18153b66e;
              bVar10 = true;
            }
            lVar5 = UICamera.currentTouch;
            if (lVar5 == null) goto LAB_18153bad9;
            lVar5.delta = local_res18 - lVar5.pos;
            *(float *)(lVar5 + 40) = fVar13 - *(float *)(lVar5 + 24);
            lVar5 = UICamera.currentTouch;
            if (lVar5 == null) goto LAB_18153bad9;
            lVar5.pos = local_res18;
            *(float *)(lVar5 + 24) = fVar13;
            UICamera.set_currentKey(0,0);
            UICamera.Raycast(UICamera.currentTouch,0);
            if (!cVar1) {
              lVar5 = UICamera.currentTouch;
              if (lVar5 == null) goto LAB_18153bad9;
              uVar6 = lVar5.pressed;
              cVar1 = Object.op_Inequality(uVar6,0,0);
              if (cVar1) {
                lVar5 = UICamera.currentTouch;
                if (lVar5 != null) {
                  uVar6 = lVar5.pressedCam;
                  puVar7 = &UICamera.currentCamera;
                  goto LAB_18153b870;
                }
                goto LAB_18153bad9;
              }
            }
            else {
              lVar5 = UICamera.currentTouch;
              uVar6 = UICamera.currentCamera;
              if (lVar5 == null) goto LAB_18153bad9;
              puVar7 = (uint64 *)(lVar5 + 56);
        LAB_18153b870:
              *puVar7 = uVar6;
              il2cpp_internal();
            }
            if (1 < iVar4) {
              lVar5 = UICamera.currentTouch;
              uVar12 = RealTime.get_time(0);
              if (lVar5 == null) goto LAB_18153bad9;
              lVar5.clickTime = uVar12;
            }
            UICamera.ProcessTouch(this,bVar11);
            if (bVar10) {
              lVar5 = UICamera.RemoveTouch;
              if (lVar5 == null) goto LAB_18153bad9;
              RemoveTouchDelegate.Invoke
                        (lVar5,UICamera.currentTouchID);
            }
            lVar5 = UICamera.currentTouch;
            if (lVar5 == null) goto LAB_18153bad9;
            lVar5.touchBegan = 0;
            lVar5 = UICamera.currentTouch;
            if (lVar5 == null) goto LAB_18153bad9;
            puVar7 = (uint64 *)(lVar5 + 64);
            *puVar7 = 0;
            il2cpp_internal(puVar7,0);
            UICamera.currentTouch = 0;
          } while ((this.allowMultiTouch) && (iVar9 = iVar9 + 1, iVar9 < iVar2));
        }
        UICamera.mUsingTouchEvents = 1;
    }

    // Token : 0x600072F
    // RVA   : 0x15363C0   Offset: 0x15357C0   Length: 0x496
    private void ProcessFakeTouches()
    {
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
        UICamera.currentTouchID = 1;
        lVar1 = UICamera.mMouse;
        if (lVar1 == null) throw; // [null/range check failed]
        if (*(int *)(lVar1 + 24) == 0) {
          uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
          FUN_1800d65f0(uVar6,0);
        }
        UICamera.currentTouch = *(uint64 *)(lVar1 + 32);
        lVar1 = UICamera.currentTouch;
        if (lVar1 == null) throw; // [null/range check failed]
        lVar1.touchBegan = cVar2;
        if (cVar2) {
          lVar1 = UICamera.currentTouch;
          uVar7 = RealTime.get_time(0);
          if (lVar1 == null) throw; // [null/range check failed]
          lVar1.pressTime = uVar7;
          lVar1 = UICamera.activeTouches;
          if (lVar1 == null) throw; // [null/range check failed]
          FUN_18181e6b0(lVar1,UICamera.currentTouch,DAT_181db3fd0);
        }
        puVar5 = (uint64 *)Input.get_mousePosition(local_18,0);
        uVar6 = *puVar5;
        lVar1 = UICamera.currentTouch;
        if (lVar1 == null) throw; // [null/range check failed]
        local_38 = (float)uVar6;
        fStack_24 = (float)((uint64)uVar6 >> 32);
        lVar1.delta = local_38 - lVar1.pos;
        *(float *)(lVar1 + 40) = fStack_24 - *(float *)(lVar1 + 24);
        lVar1 = UICamera.currentTouch;
        if (lVar1 == null) throw; // [null/range check failed]
        lVar1.pos = local_38;
        *(float *)(lVar1 + 24) = fStack_24;
        UICamera.Raycast(UICamera.currentTouch,0);
        if (!cVar2) {
          lVar1 = UICamera.currentTouch;
          if (lVar1 == null) throw; // [null/range check failed]
          uVar6 = lVar1.pressed;
          cVar4 = Object.op_Inequality(uVar6,0,0);
          if (cVar4) {
            lVar1 = UICamera.currentTouch;
            if (lVar1 == null) throw; // [null/range check failed]
            uVar6 = lVar1.pressedCam;
            puVar5 = &UICamera.currentCamera;
            goto LAB_18153672a;
          }
        }
        else {
          lVar1 = UICamera.currentTouch;
          uVar6 = UICamera.currentCamera;
          if (lVar1 == null) throw; // [null/range check failed]
          puVar5 = (uint64 *)(lVar1 + 56);
        LAB_18153672a:
          *puVar5 = uVar6;
          il2cpp_internal();
        }
        UICamera.set_currentKey(0,0);
        UICamera.ProcessTouch(this,cVar2,cVar3,0);
        if (cVar3) {
          lVar1 = UICamera.activeTouches;
          if (lVar1 == null) throw; // [null/range check failed]
          FUN_1817ef410(lVar1,UICamera.currentTouch,DAT_181db4058);
        }
        lVar1 = UICamera.currentTouch;
        if (lVar1 != null) {
          puVar5 = (uint64 *)(lVar1 + 64);
          *puVar5 = 0;
          il2cpp_internal(puVar5,0);
          UICamera.currentTouch = 0;
          return;
        }
    }

    // Token : 0x6000730
    // RVA   : 0x1537840   Offset: 0x1536C40   Length: 0x1133
    public void ProcessOthers()
    {
        var plVar9 = *(int64*)(lVar9 + 184);
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
        UICamera.currentTouchID = 0xffffff9c;
        UICamera.currentTouch =
             UICamera.controller;
        il2cpp_internal();
        iVar5 = this.submitKey0;
        cVar13 = false;
        cVar4 = false;
        if (iVar5 == 0) {
        LAB_181537999:
          iVar5 = this.submitKey1;
          if (iVar5 != 0) {
            if (((*(byte *)(DAT_181daf690 + 0x133) & 4) != 0) && (*(int *)(DAT_181daf690 + 224) == 0)) {
              il2cpp_runtime_class_init(DAT_181daf690);
              iVar5 = this.submitKey1;
            }
            lVar9 = UICamera.GetKeyDown;
            if (lVar9 == null) goto LAB_181538946;
            cVar3 = GetKeyStateFunc.Invoke(lVar9,iVar5,0);
            if (!cVar3) goto LAB_1815379f9;
            uVar14 = this.submitKey1;
            goto LAB_181537a58;
          }
        LAB_1815379f9:
          if ((this.submitKey0 == 13) || (this.submitKey1 == 13)) {
            lVar9 = UICamera.GetKeyDown;
            if (lVar9 == null) goto LAB_181538946;
            cVar3 = GetKeyStateFunc.Invoke(lVar9,0x10f,0);
            if (cVar3) goto LAB_181537a55;
          }
        }
        else {
          if (((*(byte *)(DAT_181daf690 + 0x133) & 4) != 0) && (*(int *)(DAT_181daf690 + 224) == 0)) {
            il2cpp_runtime_class_init(DAT_181daf690);
            iVar5 = this.submitKey0;
          }
          lVar9 = UICamera.GetKeyDown;
          if (lVar9 == null) goto LAB_181538946;
          cVar3 = GetKeyStateFunc.Invoke(lVar9,iVar5,0);
          if (!cVar3) goto LAB_181537999;
        LAB_181537a55:
          uVar14 = this.submitKey0;
        LAB_181537a58:
          UICamera.set_currentKey(uVar14,0);
          cVar13 = true;
        }
        iVar5 = this.submitKey0;
        if (iVar5 == 0) {
        LAB_181537ad8:
          iVar5 = this.submitKey1;
          if (iVar5 != 0) {
            if (((*(byte *)(DAT_181daf690 + 0x133) & 4) != 0) && (*(int *)(DAT_181daf690 + 224) == 0)) {
              il2cpp_runtime_class_init(DAT_181daf690);
              iVar5 = this.submitKey1;
            }
            lVar9 = UICamera.GetKeyUp;
            if (lVar9 == null) goto LAB_181538946;
            cVar3 = GetKeyStateFunc.Invoke(lVar9,iVar5,0);
            if (!cVar3) goto LAB_181537b38;
            uVar14 = this.submitKey1;
            goto LAB_181537b97;
          }
        LAB_181537b38:
          if ((this.submitKey0 == 13) || (this.submitKey1 == 13)) {
            lVar9 = UICamera.GetKeyUp;
            if (lVar9 == null) goto LAB_181538946;
            cVar3 = GetKeyStateFunc.Invoke(lVar9,0x10f,0);
            if (cVar3) goto LAB_181537b94;
          }
        }
        else {
          if (((*(byte *)(DAT_181daf690 + 0x133) & 4) != 0) && (*(int *)(DAT_181daf690 + 224) == 0)) {
            il2cpp_runtime_class_init(DAT_181daf690);
            iVar5 = this.submitKey0;
          }
          lVar9 = UICamera.GetKeyUp;
          if (lVar9 == null) goto LAB_181538946;
          cVar3 = GetKeyStateFunc.Invoke(lVar9,iVar5,0);
          if (!cVar3) goto LAB_181537ad8;
        LAB_181537b94:
          uVar14 = this.submitKey0;
        LAB_181537b97:
          UICamera.set_currentKey(uVar14,0);
          cVar4 = true;
        }
        if (cVar13) {
          lVar9 = UICamera.currentTouch;
          uVar14 = RealTime.get_time(0);
          if (lVar9 == null) goto LAB_181538946;
          lVar9.pressTime = uVar14;
        }
        if (cVar4 || cVar13) {
          iVar5 = UICamera.get_currentScheme(0);
          if (iVar5 == 2) {
            lVar9 = UICamera.currentTouch;
            uVar7 = UICamera.get_controllerNavigationObject(0);
            if (lVar9 == null) goto LAB_181538946;
            puVar10 = (uint64 *)(lVar9 + 72);
            *puVar10 = uVar7;
            il2cpp_internal(puVar10,uVar7);
            UICamera.ProcessTouch(this,cVar13,cVar4,0);
            lVar9 = UICamera.currentTouch;
            if (lVar9 == null) goto LAB_181538946;
            lVar9.last = lVar9.current;
          }
        }
        iVar6 = 0;
        iVar5 = 0;
        if (this.useController) {
          iVar5 = 0;
          if (!UICamera.ignoreControllerInput) {
            cVar4 = UICamera.get_disableController(0);
            if (!cVar4) {
              iVar5 = UICamera.get_currentScheme(0);
              if (iVar5 == 2) {
                lVar9 = UICamera.currentTouch;
                if (lVar9 == null) goto LAB_181538946;
                uVar7 = lVar9.current;
                cVar4 = Object.op_Equality(uVar7,0,0);
                if (!cVar4) {

                  if ((lVar9 = UICamera.currentTouch?.current) == null)
                  goto LAB_181538946;
                  cVar4 = GameObject.get_activeInHierarchy(lVar9,0);
                  if (cVar4) goto LAB_181537e97;
                }
                lVar9 = UICamera.currentTouch;
                uVar7 = UICamera.get_controllerNavigationObject(0);
                if (lVar9 == null) goto LAB_181538946;
                puVar10 = (uint64 *)(lVar9 + 72);
                *puVar10 = uVar7;
                il2cpp_internal(puVar10,uVar7);
              }
            }
        LAB_181537e97:
            cVar4 = FUN_180d75bc0(this.verticalAxisName,0);
            iVar5 = iVar6;
            if (!cVar4) {
              uVar7 = this.verticalAxisName;
              iVar6 = UICamera.GetDirection(uVar7,0);
              if (iVar6 != 0) {
                UICamera.ShowTooltip(0,0);
                UICamera.set_currentScheme(2);
                lVar9 = UICamera.currentTouch;
                uVar7 = UICamera.get_controllerNavigationObject(0);
                if (lVar9 == null) goto LAB_181538946;
                puVar10 = (uint64 *)(lVar9 + 72);
                *puVar10 = uVar7;
                il2cpp_internal(puVar10,uVar7);
                lVar9 = UICamera.currentTouch;
                if (lVar9 == null) goto LAB_181538946;
                uVar7 = lVar9.current;
                cVar4 = Object.op_Inequality(uVar7,0,0);
                if (cVar4) {
                  iVar5 = (iVar6 < 1) + 0x111;
                  if (UICamera.onNavigate != null) {
                    lVar9 = UICamera.currentTouch;
                    lVar11 = UICamera.onNavigate;
                    if ((lVar9 == null) || (lVar11 == null)) goto LAB_181538946;
                    KeyCodeDelegate.Invoke(lVar11,lVar9.current,iVar5,0);
                  }
                  lVar9 = UICamera.currentTouch;
                  if (lVar9 == null) {
                          // WARNING: Subroutine does not return
                    FUN_1800d6620();
                  }
                  uVar7 = lVar9.current;
                  local_res8 = CONCAT44(local_res8._4_4_,iVar5);
                  uVar8 = il2cpp_value_box(DAT_181d842b0,&local_res8);
                  UICamera.Notify(uVar7,"OnNavigate",uVar8,0);
                }
              }
            }
            cVar4 = FUN_180d75bc0(this.horizontalAxisName,0);
            if (!cVar4) {
              uVar7 = this.horizontalAxisName;
              iVar6 = UICamera.GetDirection(uVar7,0);
              if (iVar6 != 0) {
                UICamera.ShowTooltip(0,0);
                UICamera.set_currentScheme(2);
                lVar9 = UICamera.currentTouch;
                uVar7 = UICamera.get_controllerNavigationObject(0);
                if (lVar9 == null) goto LAB_181538946;
                puVar10 = (uint64 *)(lVar9 + 72);
                *puVar10 = uVar7;
                il2cpp_internal(puVar10,uVar7);
                lVar9 = UICamera.currentTouch;
                if (lVar9 == null) goto LAB_181538946;
                uVar7 = lVar9.current;
                cVar4 = Object.op_Inequality(uVar7,0,0);
                if (cVar4) {
                  iVar5 = (iVar6 < 1) + 0x113;
                  if (UICamera.onNavigate != null) {
                    lVar9 = UICamera.currentTouch;
                    lVar11 = UICamera.onNavigate;
                    if ((lVar9 == null) || (lVar11 == null)) goto LAB_181538946;
                    KeyCodeDelegate.Invoke(lVar11,lVar9.current,iVar5,0);
                  }
                  lVar9 = UICamera.currentTouch;
                  if (lVar9 == null) {
                          // WARNING: Subroutine does not return
                    FUN_1800d6620();
                  }
                  uVar7 = lVar9.current;
                  local_res8 = CONCAT44(local_res8._4_4_,iVar5);
                  uVar8 = il2cpp_value_box(DAT_181d842b0,&local_res8);
                  UICamera.Notify(uVar7,"OnNavigate",uVar8,0);
                }
              }
            }
            cVar4 = FUN_180d75bc0(this.horizontalPanAxisName,0);
            if (!cVar4) {
              lVar9 = UICamera.GetAxis;
              if (lVar9 == null) goto LAB_181538946;
              fVar15 = (float)GetAxisFunc.Invoke(lVar9,this.horizontalPanAxisName,0);
            }
            else {
              fVar15 = 0.0;
            }
            cVar4 = FUN_180d75bc0(this.verticalPanAxisName,0);
            if (!cVar4) {
              lVar9 = UICamera.GetAxis;
              if (lVar9 == null) goto LAB_181538946;
              fVar16 = (float)GetAxisFunc.Invoke(lVar9,this.verticalPanAxisName,0);
            }
            else {
              fVar16 = 0.0;
            }
            if ((fVar15 != 0.0) || (fVar16 != 0.0)) {
              UICamera.ShowTooltip(0,0);
              if (UICamera.mLastScheme != 2) {
                UICamera.set_currentKey(0x14a,0);
                UICamera.mLastScheme = 2;
              }
              lVar9 = UICamera.currentTouch;
              uVar7 = UICamera.get_controllerNavigationObject(0);
              if (lVar9 == null) goto LAB_181538946;
              puVar10 = (uint64 *)(lVar9 + 72);
              *puVar10 = uVar7;
              il2cpp_internal(puVar10,uVar7);
              lVar9 = UICamera.currentTouch;
              if (lVar9 == null) goto LAB_181538946;
              uVar7 = lVar9.current;
              cVar4 = Object.op_Inequality(uVar7,0,0);
              if (cVar4) {
                fVar17 = (float)Time.get_unscaledDeltaTime(0);
                local_res8 = CONCAT44(fVar17 * fVar16,fVar17 * fVar15);
                uVar7 = local_res8;
                if (UICamera.onPan != null) {
                  lVar9 = UICamera.currentTouch;
                  lVar11 = UICamera.onPan;
                  if ((lVar9 == null) || (lVar11 == null)) goto LAB_181538946;
                  VectorDelegate.Invoke(lVar11,lVar9.current,uVar7,0);
                }
                lVar9 = UICamera.currentTouch;
                if (lVar9 == null) {
                          // WARNING: Subroutine does not return
                  FUN_1800d6620();
                }
                uVar8 = lVar9.current;
                local_res8 = uVar7;
                uVar7 = il2cpp_value_box(DAT_181db3968,&local_res8);
                UICamera.Notify(uVar8,"OnPan",uVar7,0);
              }
            }
          }
        }
        if (UICamera.GetAnyKeyDown == null) {
          cVar4 = Input.get_anyKeyDown(0);
        }
        else {
          lVar9 = UICamera.GetAnyKeyDown;
          if (lVar9 == null) goto LAB_181538946;
          cVar4 = GetAnyKeyFunc.Invoke(lVar9,0);
        }
        lVar9 = DAT_181daf690;
        if (cVar4) {
          uVar12 = 0;
          lVar9 = *(int64 *)(*(int64 *)(DAT_181d8bd28 + 184) + 56);
          if (lVar9 == null) {
        LAB_181538946:
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          iVar6 = *(int *)(lVar9 + 24);
          lVar9 = DAT_181daf690;
          lVar11 = DAT_181d8bd28;
          if (0 < iVar6) {
            do {
              if (((*(byte *)(lVar11 + 0x133) & 4) != 0) && (*(int *)(lVar11 + 224) == 0)) {
                il2cpp_runtime_class_init(lVar11);
                lVar9 = DAT_181daf690;
                lVar11 = DAT_181d8bd28;
              }
              lVar2 = *(int64 *)(*(int64 *)(lVar11 + 184) + 56);
              if (lVar2 == null) goto LAB_181538946;
              if (*(uint32 *)(lVar2 + 24) <= uVar12) {
                uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar7,0);
              }
              iVar1 = lVar2[uVar12];
              if (iVar5 != iVar1) {
                if (((*(byte *)(lVar9 + 0x133) & 4) != 0) && (*(int *)(lVar9 + 224) == 0)) {
                  il2cpp_runtime_class_init();
                  lVar9 = DAT_181daf690;
                }
                lVar9 = *(int64 *)(plVar9 + 8);
                if (lVar9 == null) goto LAB_181538946;
                cVar4 = GetKeyStateFunc.Invoke(lVar9,iVar1,0);
                lVar9 = DAT_181daf690;
                lVar11 = DAT_181d8bd28;
                if ((cVar4) && ((this.useKeyboard || (0x142 < iVar1)))) {
                  if (!this.useController) {
        LAB_1815387a7:
                    lVar9 = DAT_181daf690;
                    lVar11 = DAT_181d8bd28;
                    if (0x149 < iVar1) goto LAB_1815388cc;
                  }
                  else {
                    if (UICamera.ignoreControllerInput) goto LAB_1815387a7;
                  }
                  if ((this.useMouse) ||
                     (lVar9 = DAT_181daf690, lVar11 = DAT_181d8bd28, 6 < iVar1 - 0x143U)) {
                    UICamera.set_currentKey(iVar1,0);
                    if (UICamera.onKey != null) {
                      lVar9 = UICamera.currentTouch;
                      lVar11 = UICamera.onKey;
                      if ((lVar9 == null) || (lVar11 == null)) goto LAB_181538946;
                      KeyCodeDelegate.Invoke(lVar11,lVar9.current,iVar1,0);
                    }
                    lVar9 = UICamera.currentTouch;
                    if (lVar9 == null) {
                          // WARNING: Subroutine does not return
                      FUN_1800d6620();
                    }
                    uVar7 = lVar9.current;
                    local_res8 = CONCAT44(local_res8._4_4_,iVar1);
                    uVar8 = il2cpp_value_box(DAT_181d842b0,&local_res8);
                    UICamera.Notify(uVar7,"OnKey",uVar8);
                    lVar9 = DAT_181daf690;
                    lVar11 = DAT_181d8bd28;
                  }
                }
              }
        LAB_1815388cc:
              uVar12 = uVar12 + 1;
            } while ((int)uVar12 < iVar6);
          }
        }
        if (((*(byte *)(lVar9 + 0x133) & 4) != 0) && (*(int *)(lVar9 + 224) == 0)) {
          il2cpp_runtime_class_init();
          lVar9 = DAT_181daf690;
        }
        puVar10 = (uint64 *)(plVar9 + 224);
        *puVar10 = 0;
        il2cpp_internal(puVar10,0);
    }

    // Token : 0x6000731
    // RVA   : 0x1538980   Offset: 0x1537D80   Length: 0x1794
    private void ProcessPress(bool pressed, float click, float drag)
    {
        var pStatics = *(int64*)(DAT_181daf690 + 184);
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
          uVar8 = UICamera.mTooltip;
          cVar3 = Object.op_Inequality(uVar8,0,0);
          if (cVar3) {
            UICamera.ShowTooltip(0,0);
          }
          fVar11 = (float)Time.get_unscaledTime(0);
          fVar10 = this.tooltipDelay;
          UICamera.mTooltipTime = fVar10 + fVar11;
          lVar7 = UICamera.currentTouch;
          if (lVar7 != null) {
            lVar7.pressStarted = 1;
            if (UICamera.onPress != null) {
              lVar7 = UICamera.currentTouch;
              if (lVar7 == null) throw; // [null/range check failed]
              uVar8 = lVar7.pressed;
              cVar3 = Object.op_Implicit(uVar8,0);
              if (cVar3) {
                lVar7 = UICamera.currentTouch;
                lVar1 = UICamera.onPress;
                if ((lVar7 == null) || (lVar1 == null)) throw; // [null/range check failed]
                OnTooltipCB.Invoke(lVar1,lVar7.pressed,0,0);
              }
            }
            lVar7 = UICamera.currentTouch;
            if (lVar7 == null) {
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            uVar8 = lVar7.pressed;
            local_res10[0] = 0;
            uVar6 = il2cpp_value_box(DAT_181db2ae0,local_res10);
            UICamera.Notify(uVar8,"OnPress",uVar6,0);
            iVar5 = UICamera.get_currentScheme(0);
            if (iVar5 == 0) {
              uVar8 = UICamera.get_hoveredObject(0);
              cVar3 = Object.op_Equality(uVar8,0,0);
              if (cVar3) {
                lVar7 = UICamera.currentTouch;
                if (lVar7 == null) throw; // [null/range check failed]
                uVar8 = lVar7.current;
                cVar3 = Object.op_Inequality(uVar8,0,0);
                if (cVar3) {
                  lVar7 = UICamera.currentTouch;
                  if (lVar7 == null) throw; // [null/range check failed]
                  UICamera.set_hoveredObject(lVar7.current,0);
                }
              }
            }
            lVar7 = UICamera.currentTouch;
            if (lVar7 != null) {
              lVar7.pressed = lVar7.current;
              lVar7 = UICamera.currentTouch;
              if (lVar7 != null) {
                lVar7.dragged = lVar7.current;
                lVar7 = UICamera.currentTouch;
                if (lVar7 != null) {
                  lVar7.clickNotification = 2;
                  lVar7 = UICamera.currentTouch;
                  uVar8 = Vector2.get_zero(0);
                  local_48 = uVar8;
                  if (lVar7 != null) {
                    local_48._0_4_ = (uint32)uVar8;
                    local_48._4_4_ = (uint32)((uint64)uVar8 >> 32);
                    lVar7.totalDelta = (uint32)local_48;
                    *(uint32 *)(lVar7 + 48) = local_48._4_4_;
                    lVar7 = UICamera.currentTouch;
                    if (lVar7 != null) {
                      lVar7.dragStarted = 0;
                      if (UICamera.onPress != null) {
                        lVar7 = UICamera.currentTouch;
                        if (lVar7 == null) throw; // [null/range check failed]
                        uVar8 = lVar7.pressed;
                        cVar3 = Object.op_Implicit(uVar8,0);
                        if (cVar3) {
                          lVar7 = UICamera.currentTouch;
                          lVar1 = UICamera.onPress;
                          if ((lVar7 == null) || (lVar1 == null)) throw; // [null/range check failed]
                          OnTooltipCB.Invoke(lVar1,lVar7.pressed,1,0);
                        }
                      }
                      lVar7 = UICamera.currentTouch;
                      if (lVar7 != null) {
                        uVar8 = lVar7.pressed;
                        local_res10[0] = 1;
                        uVar6 = il2cpp_value_box(DAT_181db2ae0,local_res10);
                        UICamera.Notify(uVar8,"OnPress",uVar6,0);
                        lVar7 = UICamera.currentTouch;
                        uVar8 = UICamera.mSelected;
                        if (lVar7 != null) {
                          uVar6 = lVar7.pressed;
                          cVar3 = Object.op_Inequality(uVar8,uVar6,0);
                          if (!cVar3) {
                            return;
                          }
                          UICamera.mInputFocus = 0;
                          uVar8 = UICamera.mSelected;
                          cVar3 = Object.op_Implicit(uVar8,0);
                          if (cVar3) {
                            uVar8 = UICamera.mSelected;
                            local_res10[0] = 0;
                            uVar6 = il2cpp_value_box(DAT_181db2ae0,local_res10);
                            UICamera.Notify(uVar8,"OnSelect",uVar6,0);
                            if (UICamera.onSelect != null) {
                              lVar7 = UICamera.onSelect;
                              if (lVar7 == null) throw; // [null/range check failed]
                              OnTooltipCB.Invoke(lVar7,*(uint64 *)
                                                         (pStatics + 0x1e8),0,0
                                                 );
                            }
                          }
                          lVar7 = UICamera.currentTouch;
                          if (lVar7 != null) {
                            UICamera.mSelected =
                                 lVar7.pressed;
                            il2cpp_internal();
                            lVar7 = UICamera.currentTouch;
                            if (lVar7 != null) {
                              uVar8 = lVar7.pressed;
                              cVar3 = Object.op_Inequality(uVar8,0,0);
                              if (cVar3) {

                                if ((lVar7 = UICamera.currentTouch?.pressed) == null)
                                throw; // [null/range check failed]
                                uVar8 = GameObject.GetComponent(lVar7,DAT_181d74a10);
                                cVar3 = Object.op_Inequality(uVar8,0,0);
                                if (cVar3) {
                                  lVar7 = UICamera.currentTouch;
                                  lVar1 = UICamera.controller;
                                  if ((lVar7 == null) || (lVar1 == null)) throw; // [null/range check failed]
                                  lVar1.current = lVar7.pressed;
                                }
                              }
                              uVar8 = UICamera.mSelected;
                              cVar3 = Object.op_Implicit(uVar8,0);
                              if (!cVar3) {
                                return;
                              }
                              lVar7 = UICamera.mSelected;
                              if (lVar7 != null) {
                                cVar3 = GameObject.get_activeInHierarchy(lVar7,0);
                                if (!cVar3) {
                                  uVar4 = 0;
                                }
                                else {
                                  lVar7 = UICamera.mSelected;
                                  if (lVar7 == null) throw; // [null/range check failed]
                                  uVar8 = GameObject.GetComponent(lVar7,DAT_181d74988);
                                  uVar4 = Object.op_Inequality(uVar8,0,0);
                                }
                                UICamera.mInputFocus = uVar4;
                                if (UICamera.onSelect != null) {
                                  lVar7 = UICamera.onSelect;
                                  if (lVar7 == null) throw; // [null/range check failed]
                                  OnTooltipCB.Invoke(lVar7,*(uint64 *)
                                                             (pStatics + 0x1e8)
                                                      ,1,0);
                                }
                                uVar8 = UICamera.mSelected;
                                local_res10[0] = 1;
                                uVar6 = il2cpp_value_box(DAT_181db2ae0,local_res10);
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
        lVar7 = UICamera.currentTouch;
        if (lVar7 == null) throw; // [null/range check failed]
        uVar8 = lVar7.pressed;
        cVar3 = Object.op_Inequality(uVar8,0,0);
        if (!cVar3) {
          return;
        }
        lVar7 = UICamera.currentTouch;
        if (lVar7 == null) throw; // [null/range check failed]
        fVar10 = (float)Vector2.get_sqrMagnitude(lVar7 + 36,0);
        if (fVar10 == 0.0) {
          lVar7 = UICamera.currentTouch;
          if (lVar7 == null) throw; // [null/range check failed]
          uVar8 = lVar7.current;
          uVar6 = lVar7.last;
          cVar3 = Object.op_Inequality(uVar8,uVar6,0);
          if (!cVar3) {
            return;
          }
        }
        lVar7 = UICamera.currentTouch;
        if (lVar7 == null) throw; // [null/range check failed]
        lVar7.totalDelta = lVar7.delta + lVar7.totalDelta;
        *(float *)(lVar7 + 48) = *(float *)(lVar7 + 40) + *(float *)(lVar7 + 48);
        lVar7 = UICamera.currentTouch;
        if (lVar7 == null) throw; // [null/range check failed]
        fVar10 = (float)Vector2.get_sqrMagnitude(lVar7 + 44,0);
        bVar2 = false;
        lVar7 = UICamera.currentTouch;
        if (lVar7 == null) throw; // [null/range check failed]
        if (!lVar7.dragStarted) {
          lVar7 = UICamera.currentTouch;
          if (lVar7 == null) throw; // [null/range check failed]
          uVar8 = lVar7.last;
          uVar6 = lVar7.current;
          cVar3 = Object.op_Inequality(uVar8,uVar6,0);
          if (!cVar3) goto LAB_181538f15;
          lVar7 = UICamera.currentTouch;
          if (lVar7 == null) throw; // [null/range check failed]
          lVar7.dragStarted = 1;
          lVar7 = UICamera.currentTouch;
          if (lVar7 == null) throw; // [null/range check failed]
          lVar7.delta = lVar7.totalDelta;
          *(uint32 *)(lVar7 + 40) = *(uint32 *)(lVar7 + 48);
          lVar7 = UICamera.currentTouch;
          if (lVar7 == null) throw; // [null/range check failed]
          lVar7.clickNotification = 0;
          UICamera.isDragging = 1;
          if (UICamera.onDragStart != null) {
            lVar7 = UICamera.currentTouch;
            lVar1 = UICamera.onDragStart;
            if ((lVar7 == null) || (lVar1 == null)) throw; // [null/range check failed]
            VoidDelegate.Invoke(lVar1,lVar7.dragged,0);
          }
          lVar7 = UICamera.currentTouch;
          if (lVar7 == null) throw; // [null/range check failed]
          UICamera.Notify(lVar7.dragged,"OnDragStart",0,0);
          if (UICamera.onDragOver != null) {
            lVar7 = UICamera.currentTouch;
            lVar1 = UICamera.onDragOver;
            if ((lVar7 == null) || (lVar1 == null)) throw; // [null/range check failed]
            ObjectDelegate.Invoke(lVar1,lVar7.last,lVar7.dragged,0);
          }
          lVar7 = UICamera.currentTouch;
          if (lVar7 == null) throw; // [null/range check failed]
          UICamera.Notify(lVar7.last,"OnDragOver",lVar7.dragged,0);
          UICamera.isDragging = 0;
        }
        else {
        LAB_181538f15:
          lVar7 = UICamera.currentTouch;
          if (lVar7 == null) throw; // [null/range check failed]
          if ((!lVar7.dragStarted) && (drag < fVar10)) {
            bVar2 = true;
            lVar7 = UICamera.currentTouch;
            if (lVar7 == null) throw; // [null/range check failed]
            lVar7.dragStarted = 1;
            lVar7 = UICamera.currentTouch;
            if (lVar7 == null) throw; // [null/range check failed]
            lVar7.delta = lVar7.totalDelta;
            *(uint32 *)(lVar7 + 40) = *(uint32 *)(lVar7 + 48);
          }
        }
        lVar7 = UICamera.currentTouch;
        if (lVar7 == null) throw; // [null/range check failed]
        if (!lVar7.dragStarted) {
          return;
        }
        uVar8 = UICamera.mTooltip;
        cVar3 = Object.op_Inequality(uVar8,0,0);
        if (cVar3) {
          UICamera.ShowTooltip(0,0);
        }
        UICamera.isDragging = 1;
        lVar7 = UICamera.currentTouch;
        if (lVar7 == null) throw; // [null/range check failed]
        iVar5 = lVar7.clickNotification;
        if (bVar2) {
          if (UICamera.onDragStart != null) {
            lVar7 = UICamera.currentTouch;
            lVar1 = UICamera.onDragStart;
            if ((lVar7 == null) || (lVar1 == null)) throw; // [null/range check failed]
            VoidDelegate.Invoke(lVar1,lVar7.dragged,0);
          }
          lVar7 = UICamera.currentTouch;
          if (lVar7 == null) throw; // [null/range check failed]
          uVar8 = 0;
          uVar6 = lVar7.dragged;
          uVar9 = "OnDragStart";
        LAB_181539301:
          UICamera.Notify(uVar6,uVar9,uVar8,0);
          if (UICamera.onDragOver != null) {
            lVar7 = UICamera.currentTouch;
            lVar1 = UICamera.onDragOver;
            if ((lVar7 == null) || (lVar1 == null)) throw; // [null/range check failed]
            ObjectDelegate.Invoke(lVar1,lVar7.last,lVar7.dragged,0);
          }
          lVar7 = UICamera.currentTouch;
          if (lVar7 == null) throw; // [null/range check failed]
          UICamera.Notify(lVar7.current,"OnDragOver",lVar7.dragged,0);
        }
        else {
          lVar7 = UICamera.currentTouch;
          if (lVar7 == null) throw; // [null/range check failed]
          uVar8 = lVar7.last;
          uVar6 = lVar7.current;
          cVar3 = Object.op_Inequality(uVar8,uVar6,0);
          if (cVar3) {
            if (UICamera.onDragOut != null) {
              lVar7 = UICamera.currentTouch;
              lVar1 = UICamera.onDragOut;
              if ((lVar7 == null) || (lVar1 == null)) throw; // [null/range check failed]
              ObjectDelegate.Invoke(lVar1,lVar7.last,lVar7.dragged,0);
            }
            lVar7 = UICamera.currentTouch;
            if (lVar7 == null) throw; // [null/range check failed]
            uVar8 = lVar7.dragged;
            uVar6 = lVar7.last;
            uVar9 = "OnDragOut";
            goto LAB_181539301;
          }
        }
        if (UICamera.onDrag != null) {
          lVar7 = UICamera.currentTouch;
          lVar1 = UICamera.onDrag;
          if ((lVar7 == null) || (local_48 = lVar7.delta, lVar1 == null)) throw; // [null/range check failed]
          VectorDelegate.Invoke(lVar1,lVar7.dragged,local_48,0);
        }
        lVar7 = UICamera.currentTouch;
        if (lVar7 == null) {
        LAB_18153a103:
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
        uVar8 = lVar7.dragged;
        local_48 = lVar7.delta;
        uVar6 = il2cpp_value_box(DAT_181db3968,&local_48);
        UICamera.Notify(uVar8,"OnDrag",uVar6,0);
        lVar7 = UICamera.currentTouch;
        if (lVar7 == null) goto LAB_18153a103;
        lVar7.last = lVar7.current;
        UICamera.isDragging = 0;
        if (iVar5 == 0) {
          lVar7 = pStatics;
        }
        else {
          lVar7 = UICamera.currentTouch;
          if (lVar7 == null) throw; // [null/range check failed]
          if (lVar7.clickNotification != 2) {
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
    // RVA   : 0x153A120   Offset: 0x1539520   Length: 0xE00
    private void ProcessRelease(bool isMouse, float drag)
    {
        ulong uVar1;
        bool cVar2;
        int iVar3;
        ulong uVar4;
        long lVar5;
        long lVar6;
        float fVar8;
        byte[] local_28 = new byte[32];
        if (UICamera.currentTouch == null) {
          return;
        }
        lVar6 = UICamera.currentTouch;
        if (lVar6 == null) throw; // [null/range check failed]
        lVar6.pressStarted = 0;
        lVar6 = UICamera.currentTouch;
        if (lVar6 == null) throw; // [null/range check failed]
        uVar1 = lVar6.pressed;
        cVar2 = Object.op_Inequality(uVar1,0,0);
        if (cVar2) {
          lVar6 = UICamera.currentTouch;
          if (lVar6 == null) throw; // [null/range check failed]
          if (lVar6.dragStarted) {
            if (UICamera.onDragOut != null) {
              lVar6 = UICamera.currentTouch;
              lVar5 = UICamera.onDragOut;
              if ((lVar6 == null) || (lVar5 == null)) throw; // [null/range check failed]
              ObjectDelegate.Invoke(lVar5,lVar6.last,lVar6.dragged,0);
            }
            lVar6 = UICamera.currentTouch;
            if (lVar6 == null) throw; // [null/range check failed]
            UICamera.Notify(lVar6.last,"OnDragOut",lVar6.dragged,0);
            if (UICamera.onDragEnd != null) {
              lVar6 = UICamera.currentTouch;
              lVar5 = UICamera.onDragEnd;
              if ((lVar6 == null) || (lVar5 == null)) throw; // [null/range check failed]
              VoidDelegate.Invoke(lVar5,lVar6.dragged,0);
            }
            lVar6 = UICamera.currentTouch;
            if (lVar6 == null) throw; // [null/range check failed]
            UICamera.Notify(lVar6.dragged,"OnDragEnd",0,0);
          }
          if (UICamera.onPress != null) {
            lVar6 = UICamera.currentTouch;
            lVar5 = UICamera.onPress;
            if ((lVar6 == null) || (lVar5 == null)) throw; // [null/range check failed]
            OnTooltipCB.Invoke(lVar5,lVar6.pressed,0,0);
          }
          lVar6 = UICamera.currentTouch;
          if (lVar6 == null) {
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          uVar1 = lVar6.pressed;
          local_28[0] = 0;
          uVar4 = il2cpp_value_box(DAT_181db2ae0,local_28);
          UICamera.Notify(uVar1,"OnPress",uVar4,0);
          if (isMouse) {
            lVar6 = UICamera.currentTouch;
            if (lVar6 == null) throw; // [null/range check failed]
            lVar6 = lVar6.pressed;
            cVar2 = Object.op_Equality(lVar6,0,0);
            if (!cVar2) {
              if (lVar6 == null) throw; // [null/range check failed]
              lVar5 = GameObject.GetComponent(lVar6,DAT_181dc80e0);
              cVar2 = Object.op_Inequality(lVar5,0,0);
              if (!cVar2) {
                lVar6 = GameObject.GetComponent(lVar6,DAT_181dc8168);
                cVar2 = Object.op_Inequality(lVar6,0,0);
                if (!cVar2) goto LAB_18153a78d;
                if (lVar6 == null) throw; // [null/range check failed]
                cVar2 = Behaviour.get_enabled(lVar6,0);
              }
              else {
                if (lVar5 == null) throw; // [null/range check failed]
                cVar2 = Collider.get_enabled(lVar5,0);
              }
              if (cVar2) {
                lVar6 = UICamera.currentTouch;
                uVar1 = UICamera.mHover;
                if (lVar6 == null) throw; // [null/range check failed]
                uVar4 = lVar6.current;
                cVar2 = Object.op_Equality(uVar1,uVar4,0);
                if (!cVar2) {
                  lVar6 = UICamera.currentTouch;
                  if (lVar6 == null) throw; // [null/range check failed]
                  UICamera.set_hoveredObject(lVar6.current,0);
                }
                else {
                  if (UICamera.onHover != null) {
                    lVar6 = UICamera.currentTouch;
                    lVar5 = UICamera.onHover;
                    if ((lVar6 == null) || (lVar5 == null)) throw; // [null/range check failed]
                    OnTooltipCB.Invoke(lVar5,lVar6.current,1,0);
                  }
                  lVar6 = UICamera.currentTouch;
                  if (lVar6 == null) {
                          // WARNING: Subroutine does not return
                    FUN_1800d6620();
                  }
                  uVar1 = lVar6.current;
                  local_28[0] = 1;
                  uVar4 = il2cpp_value_box(DAT_181db2ae0,local_28);
                  UICamera.Notify(uVar1,"OnHover",uVar4,0);
                }
              }
            }
          }
        LAB_18153a78d:
          lVar6 = UICamera.currentTouch;
          if (lVar6 == null) throw; // [null/range check failed]
          uVar1 = lVar6.dragged;
          uVar4 = lVar6.current;
          cVar2 = Object.op_Equality(uVar1,uVar4,0);
          if (!cVar2) {
            iVar3 = UICamera.get_currentScheme(0);
            if (iVar3 != 2) {
              lVar6 = UICamera.currentTouch;
              if (lVar6 == null) throw; // [null/range check failed]
              if (lVar6.clickNotification != null) {
                lVar6 = UICamera.currentTouch;
                if (lVar6 == null) throw; // [null/range check failed]
                fVar8 = (float)Vector2.get_sqrMagnitude(lVar6 + 44,0);
                if (fVar8 < drag) goto LAB_18153ab82;
              }
            }
            lVar6 = UICamera.currentTouch;
            if (lVar6 == null) throw; // [null/range check failed]
            if (lVar6.dragStarted) {
              if (UICamera.onDrop != null) {
                lVar6 = UICamera.currentTouch;
                lVar5 = UICamera.onDrop;
                if ((lVar6 == null) || (lVar5 == null)) throw; // [null/range check failed]
                ObjectDelegate.Invoke
                          (lVar5,lVar6.current,lVar6.dragged,0);
              }
              lVar6 = UICamera.currentTouch;
              if (lVar6 == null) throw; // [null/range check failed]
              UICamera.Notify(lVar6.current,"OnDrop",lVar6.dragged,0
                              );
            }
          }
          else {
        LAB_18153ab82:
            lVar6 = UICamera.currentTouch;
            if (lVar6 == null) throw; // [null/range check failed]
            if (lVar6.clickNotification != null) {
              lVar6 = UICamera.currentTouch;
              if (lVar6 == null) throw; // [null/range check failed]
              uVar1 = lVar6.pressed;
              uVar4 = lVar6.current;
              cVar2 = Object.op_Equality(uVar1,uVar4,0);
              if (cVar2) {
                UICamera.ShowTooltip(0,0);
                fVar8 = (float)RealTime.get_time(0);
                if (UICamera.onClick != null) {
                  lVar6 = UICamera.currentTouch;
                  lVar5 = UICamera.onClick;
                  if ((lVar6 == null) || (lVar5 == null)) throw; // [null/range check failed]
                  VoidDelegate.Invoke(lVar5,lVar6.pressed,0);
                }
                lVar6 = UICamera.currentTouch;
                if (lVar6 == null) throw; // [null/range check failed]
                UICamera.Notify(lVar6.pressed,"OnClick",0,0);
                lVar6 = UICamera.currentTouch;
                if (lVar6 == null) throw; // [null/range check failed]
                if (fVar8 < lVar6.clickTime + 0.35) {
                  lVar6 = UICamera.currentTouch;
                  if (lVar6 == null) throw; // [null/range check failed]
                  uVar1 = lVar6.lastClickGO;
                  uVar4 = lVar6.pressed;
                  cVar2 = Object.op_Equality(uVar1,uVar4,0);
                  if (cVar2) {
                    if (UICamera.onDoubleClick != null) {
                      lVar6 = UICamera.currentTouch;
                      lVar5 = UICamera.onDoubleClick;
                      if ((lVar6 == null) || (lVar5 == null)) throw; // [null/range check failed]
                      VoidDelegate.Invoke(lVar5,lVar6.pressed,0);
                    }
                    lVar6 = UICamera.currentTouch;
                    if (lVar6 == null) throw; // [null/range check failed]
                    UICamera.Notify(lVar6.pressed,"OnDoubleClick",0,0);
                  }
                }
                lVar6 = UICamera.currentTouch;
                if (lVar6 == null) throw; // [null/range check failed]
                lVar6.lastClickGO = lVar6.pressed;
                lVar6 = UICamera.currentTouch;
                if (lVar6 == null) throw; // [null/range check failed]
                lVar6.clickTime = fVar8;
              }
            }
          }
        }
        lVar6 = UICamera.currentTouch;
        if (lVar6 != null) {
          lVar6.dragStarted = 0;
          lVar6 = UICamera.currentTouch;
          if (lVar6 != null) {
            puVar7 = (uint64 *)(lVar6 + 80);
            *puVar7 = 0;
            il2cpp_internal(puVar7,0);
            lVar6 = UICamera.currentTouch;
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
    // RVA   : 0x1534CA0   Offset: 0x15340A0   Length: 0x14A
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

    // Token : 0x6000734
    // RVA   : 0x153AF30   Offset: 0x153A330   Length: 0x440
    public void ProcessTouch(bool pressed, bool released)
    {
        long lVar1;
        ulong uVar2;
        ulong uVar3;
        bool cVar4;
        int iVar5;
        float fVar7;
        float fVar8;
        if (released) {
          UICamera.mTooltipTime = 0;
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
        lVar1 = UICamera.currentTouch;
        if (lVar1 == null) goto LAB_18153b36b;
        uVar2 = lVar1.pressed;
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
            lVar1 = UICamera.currentTouch;
            if (lVar1 == null) {
        LAB_18153b36b:
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            fVar7 = (float)MouseOrTouch.get_deltaTime(lVar1,0);
            if (this.tooltipDelay <= fVar7 && fVar7 != this.tooltipDelay) {
              lVar1 = UICamera.currentTouch;
              if (lVar1 == null) goto LAB_18153b36b;
              uVar2 = lVar1.pressed;
              uVar3 = lVar1.current;
              cVar4 = Object.op_Equality(uVar2,uVar3,0);
              if (cVar4) {
                if (UICamera.mTooltipTime != null.0) {
                  lVar1 = UICamera.currentTouch;
                  if (lVar1 != null) {
                    if (lVar1.dragStarted) {
                      return;
                    }
                    UICamera.mTooltipTime = 0;
                    lVar1 = UICamera.currentTouch;
                    if (lVar1 != null) {
                      lVar1.clickNotification = 0;
                      if (this.longPressTooltip) {
                        lVar1 = UICamera.currentTouch;
                        if (lVar1 == null) goto LAB_18153b36b;
                        UICamera.ShowTooltip(lVar1.pressed,0);
                      }
                      lVar1 = UICamera.currentTouch;
                      if (lVar1 != null) {
                        UICamera.Notify(lVar1.current,"OnLongPress",0,0);
                        return;
                      }
                    }
                  }
                  goto LAB_18153b36b;
                }
              }
            }
          }
        }
    }

    // Token : 0x6000735
    // RVA   : 0x1533F70   Offset: 0x1533370   Length: 0x5E
    public static void CancelNextTooltip()
    {
        *(uint32 *)(*(int64 *)(DAT_181daf690 + 184) + 0x1b8) = 0;
    }

    // Token : 0x6000736
    // RVA   : 0x153DE10   Offset: 0x153D210   Length: 0x38C
    public static bool ShowTooltip(GameObject go)
    {
        ulong uVar1;
        long lVar2;
        bool cVar3;
        ulong uVar4;
        byte[] local_res8 = new byte[8];
        uVar1 = UICamera.mTooltip;
        cVar3 = Object.op_Inequality(uVar1,go,0);
        if (!cVar3) {
          return false;
        }
        uVar1 = UICamera.mTooltip;
        cVar3 = Object.op_Inequality(uVar1,0,0);
        if (cVar3) {
          if (UICamera.onTooltip != null) {
            lVar2 = UICamera.onTooltip;
            if (lVar2 == null) goto LAB_18153e197;
            OnTooltipCB.Invoke(lVar2,UICamera.mTooltip,0,0);
          }
          uVar1 = UICamera.mTooltip;
          local_res8[0] = 0;
          uVar4 = il2cpp_value_box(DAT_181db2ae0,local_res8);
          UICamera.Notify(uVar1,"OnTooltip",uVar4,0);
        }
        UICamera.mTooltip = go;
        UICamera.mTooltipTime = 0;
        uVar1 = UICamera.mTooltip;
        cVar3 = Object.op_Inequality(uVar1,0,0);
        if (cVar3) {
          if (UICamera.onTooltip != null) {
            lVar2 = UICamera.onTooltip;
            if (lVar2 == null) {
        LAB_18153e197:
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            OnTooltipCB.Invoke(lVar2,UICamera.mTooltip,1,0);
          }
          uVar1 = UICamera.mTooltip;
          local_res8[0] = 1;
          uVar4 = il2cpp_value_box(DAT_181db2ae0,local_res8);
          UICamera.Notify(uVar1,"OnTooltip",uVar4,0);
        }
        return true;
    }

    // Token : 0x6000737
    // RVA   : 0x1534DF0   Offset: 0x15341F0   Length: 0x4B
    public static bool HideTooltip()
    {
        UICamera.ShowTooltip(0,0);
    }

    // Token : 0x6000738
    // RVA   : 0x153DD90   Offset: 0x153D190   Length: 0x7A
    public static void ResetTooltip(float delay)
    {
        float fVar1;
        UICamera.ShowTooltip(0,0);
        fVar1 = (float)Time.get_unscaledTime(0);
        *(float *)(*(int64 *)(DAT_181daf690 + 184) + 0x1b8) = fVar1 + delay;
    }

    // Token : 0x6000739
    // RVA   : 0x153F200   Offset: 0x153E600   Length: 0x100
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
    // RVA   : 0x153E840   Offset: 0x153DC40   Length: 0x9B2
    private static void /*cctor*/()
    {
        var pStatics = *(int64*)(DAT_181daf690 + 184);
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
        uVar1 = new BetterList_1(DAT_181da66d0);
        puVar6 = *(uint64 **)(DAT_181daf690 + 184);
        *puVar6 = uVar1;
        il2cpp_internal(puVar6,uVar1);
        uVar1 = **(uint64 **)(DAT_181d8d1d0 + 184);
        uVar2 = new OnTooltipCB(uVar1,DAT_181db7738,0);
        UICamera.GetKeyDown = uVar2;
        uVar1 = **(uint64 **)(DAT_181d8d1d0 + 184);
        uVar2 = new OnTooltipCB(uVar1,DAT_181db77c0,0);
        UICamera.GetKeyUp = uVar2;
        uVar1 = **(uint64 **)(DAT_181d8d1d0 + 184);
        uVar2 = new OnTooltipCB(uVar1,DAT_181db7848,0);
        UICamera.GetKey = uVar2;
        uVar1 = **(uint64 **)(DAT_181d8d1d0 + 184);
        uVar2 = new OnTooltipCB(uVar1,DAT_181db78d0,0);
        UICamera.GetAxis = uVar2;
        uVar1 = **(uint64 **)(DAT_181d8d1d0 + 184);
        uVar2 = new OnTooltipCB(uVar1,DAT_181db7958,0);
        UICamera.GetMouse = uVar2;
        uVar1 = **(uint64 **)(DAT_181d8d1d0 + 184);
        uVar2 = new OnTooltipCB(uVar1,DAT_181db79e0,0);
        UICamera.GetTouch = uVar2;
        uVar1 = **(uint64 **)(DAT_181d8d1d0 + 184);
        uVar2 = new OnTooltipCB(uVar1,DAT_181db7a68,0);
        UICamera.RemoveTouch = uVar2;
        UICamera.showTooltips = 1;
        UICamera.ignoreAllEvents = 0;
        UICamera.ignoreControllerInput = 0;
        UICamera.mDisableController = 0;
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
        UICamera.current = 0;
        UICamera.currentCamera = 0;
        UICamera.mLastScheme = 0;
        UICamera.currentTouchID = 0xffffff9c;
        UICamera.mCurrentKey = 48;
        UICamera.currentTouch = 0;
        UICamera.mInputFocus = 0;
        plVar3 = (int64 *)FUN_1800d60b0(DAT_181da88f8,3);
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
          UICamera.mMouse = plVar3;
          uVar1 = new MouseOrTouch(0);
          UICamera.controller = uVar1;
          uVar1 = il2cpp_internal(DAT_181d9a7e8);
          FUN_181330100(uVar1,DAT_181db3f48);
          UICamera.activeTouches = uVar1;
          uVar1 = il2cpp_internal(DAT_181d93ce8);
          FUN_181330100(uVar1,DAT_181d8f0b0);
          UICamera.mTouchIDs = uVar1;
          UICamera.mWidth = 0;
          UICamera.mHeight = 0;
          UICamera.mTooltip = 0;
          UICamera.mTooltipTime = 0;
          UICamera.isDragging = 0;
          UICamera.mLastInteractionCheck = 0xffffffff;
          UICamera.mLastInteractionResult = 0;
          UICamera.mLastFocusCheck = 0xffffffff;
          UICamera.mLastFocusResult = 0;
          UICamera.mLastOverCheck = 0xffffffff;
          UICamera.mLastOverResult = 0;
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
          uVar1 = new BetterList_1(DAT_181da79d0);
          UICamera.mHits = uVar1;
          puVar6 = (uint64 *)Vector3.get_back(&local_28,0);
          local_20 = *(uint32 *)(puVar6 + 1);
          local_28 = *puVar6;
          local_18 = 0;
          uStack_10 = 0;
          Plane.ctor(&local_18,&local_28,0,0);
          lVar4 = pStatics;
          *(uint64 *)(lVar4 + 0x250) = local_18;
          *(uint64 *)(lVar4 + 600) = uStack_10;
          UICamera.mNextEvent = 0;
          UICamera.mNotifying = 0;
          UICamera.disableControllerCheck = 1;
          UICamera.mUsingTouchEvents = 1;
          return;
        }
        uVar1 = il2cpp_internal();
    }

}
