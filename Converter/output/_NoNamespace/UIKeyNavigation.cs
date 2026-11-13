// ============================================================
// Type  : UIKeyNavigation
// Token : 0x200004E
// ============================================================

public class UIKeyNavigation
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x40001A0
    public static BetterList<UIKeyNavigation> list;

    // Token: 0x40001A1
    public Constraint constraint;

    // Token: 0x40001A2
    public GameObject onUp;

    // Token: 0x40001A3
    public GameObject onDown;

    // Token: 0x40001A4
    public GameObject onLeft;

    // Token: 0x40001A5
    public GameObject onRight;

    // Token: 0x40001A6
    public GameObject onClick;

    // Token: 0x40001A7
    public GameObject onTab;

    // Token: 0x40001A8
    public bool startsSelected;

    // Token: 0x40001A9
    private bool mStarted;

    // Token: 0x40001AA
    public static int mLastFrame;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000182
    // RVA   : 0xF8D0B0   Offset: 0xF8BEB0   Length: 0xB7
    public static UIKeyNavigation get_current()
    {
        bool cVar1;
        long lVar2;
        ulong uVar3;
        lVar2 = UICamera.get_hoveredObject(0);
        cVar1 = Object.op_Equality(lVar2,0,0);
        if (!cVar1) {
          if (lVar2 != null) {
            uVar3 = GameObject.GetComponent(lVar2,DAT_181e57ad8);
            return uVar3;
          }
                          // WARNING: Subroutine does not return
          FUN_1801e0300();
        }
        return 0;
    }

    // Token : 0x6000183
    // RVA   : 0xF8D170   Offset: 0xF8BF70   Length: 0x13F
    public bool get_isColliderEnabled()
    {
        bool cVar1;
        byte uVar2;
        long lVar3;
        cVar1 = Behaviour.get_enabled(this,0);
        if (!cVar1) {
          return false;
        }
        lVar3 = Component.get_gameObject(this,0);
        if (lVar3 != null) {
          cVar1 = GameObject.get_activeInHierarchy(lVar3,0);
          if (!cVar1) {
            return false;
          }
          lVar3 = Component.GetComponent(this,DAT_181e76eb8);
          cVar1 = Object.op_Inequality(lVar3,0,0);
          if (!cVar1) {
            lVar3 = Component.GetComponent(this,DAT_181e76f38);
            cVar1 = Object.op_Inequality(lVar3,0,0);
            if (!cVar1) {
              return false;
            }
            if (lVar3 != null) {
              uVar2 = Behaviour.get_enabled(lVar3,0);
              return uVar2;
            }
          }
          else if (lVar3 != null) {
            uVar2 = Collider.get_enabled(lVar3,0);
            return uVar2;
          }
        }
    }

    // Token : 0x6000184
    // RVA   : 0xF8C8E0   Offset: 0xF8B6E0   Length: 0xB3
    protected virtual void OnEnable()
    {
        if (UIKeyNavigation.list != null) {
          FUN_181623290(UIKeyNavigation.list,this,DAT_181e87690);
          if (this.mStarted) {
            MonoBehaviour.Invoke(this,"Start",0x3a83126f,0);
            return;
          }
          return;
        }
    }

    // Token : 0x6000185
    // RVA   : 0xF8CFA0   Offset: 0xF8BDA0   Length: 0x7D
    private void Start()
    {
        ulong uVar1;
        bool cVar2;
        this.mStarted = 1;
        if (this.startsSelected) {
          cVar2 = UIKeyNavigation.get_isColliderEnabled(this,0);
          if (cVar2) {
            uVar1 = Component.get_gameObject(this,0);
            UICamera.set_selectedObject(uVar1,0);
            return;
          }
        }
    }

    // Token : 0x6000186
    // RVA   : 0xF8C850   Offset: 0xF8B650   Length: 0x81
    protected virtual void OnDisable()
    {
        if (UIKeyNavigation.list != null) {
          FUN_1816252a0(UIKeyNavigation.list,this,DAT_181e87710);
          return;
        }
    }

    // Token : 0x6000187
    // RVA   : 0xF8C650   Offset: 0xF8B450   Length: 0x153
    private static bool IsActive(GameObject go)
    {
        long lVar1;
        bool cVar2;
        byte uVar3;
        cVar2 = Object.op_Implicit(go,0);
        if (!cVar2) {
          return false;
        }
        if (go != null) {
          cVar2 = GameObject.get_activeInHierarchy(go,0);
          if (!cVar2) {
            return false;
          }
          lVar1 = GameObject.GetComponent(go,DAT_181e54178);
          cVar2 = Object.op_Inequality(lVar1,0,0);
          if (!cVar2) {
            lVar1 = GameObject.GetComponent(go,DAT_181e54200);
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

    // Token : 0x6000188
    // RVA   : 0xF8BF00   Offset: 0xF8AD00   Length: 0xCF
    public GameObject GetLeft()
    {
        bool cVar1;
        ulong uVar3;
        ulong local_28;
        uint local_20;
        byte[] local_18 = new byte[16];
        uVar3 = this.onLeft;
        cVar1 = UIKeyNavigation.IsActive(uVar3,0);
        if (!cVar1) {
          if ((this.constraint - 1U & 0xfffffffd) != 0) {
            puVar2 = (uint64 *)Vector3.get_left(local_18,0);
            local_28 = *puVar2;
            local_20 = *(uint32 *)(puVar2 + 1);
            uVar3 = UIKeyNavigation.Get(this,&local_28,0x3f800000,0x40000000,0);
            return uVar3;
          }
          return 0;
        }
        return this.onLeft;
    }

    // Token : 0x6000189
    // RVA   : 0xF8BFD0   Offset: 0xF8ADD0   Length: 0xCF
    public GameObject GetRight()
    {
        bool cVar1;
        ulong uVar3;
        ulong local_28;
        uint local_20;
        byte[] local_18 = new byte[16];
        uVar3 = this.onRight;
        cVar1 = UIKeyNavigation.IsActive(uVar3,0);
        if (!cVar1) {
          if ((this.constraint - 1U & 0xfffffffd) != 0) {
            puVar2 = (uint64 *)Vector3.get_right(local_18,0);
            local_28 = *puVar2;
            local_20 = *(uint32 *)(puVar2 + 1);
            uVar3 = UIKeyNavigation.Get(this,&local_28,0x3f800000,0x40000000,0);
            return uVar3;
          }
          return 0;
        }
        return this.onRight;
    }

    // Token : 0x600018A
    // RVA   : 0xF8C0A0   Offset: 0xF8AEA0   Length: 0xCE
    public GameObject GetUp()
    {
        bool cVar1;
        ulong uVar3;
        ulong local_28;
        uint local_20;
        byte[] local_18 = new byte[16];
        uVar3 = this.onUp;
        cVar1 = UIKeyNavigation.IsActive(uVar3,0);
        if (!cVar1) {
          if (1 < this.constraint - 2U) {
            puVar2 = (uint64 *)Vector3.get_up(local_18,0);
            local_28 = *puVar2;
            local_20 = *(uint32 *)(puVar2 + 1);
            uVar3 = UIKeyNavigation.Get(this,&local_28,0x40000000,0x3f800000,0);
            return uVar3;
          }
          return 0;
        }
        return this.onUp;
    }

    // Token : 0x600018B
    // RVA   : 0xF8BE30   Offset: 0xF8AC30   Length: 0xCE
    public GameObject GetDown()
    {
        bool cVar1;
        ulong uVar3;
        ulong local_28;
        uint local_20;
        byte[] local_18 = new byte[16];
        uVar3 = this.onDown;
        cVar1 = UIKeyNavigation.IsActive(uVar3,0);
        if (!cVar1) {
          if (1 < this.constraint - 2U) {
            puVar2 = (uint64 *)Vector3.get_down(local_18,0);
            local_28 = *puVar2;
            local_20 = *(uint32 *)(puVar2 + 1);
            uVar3 = UIKeyNavigation.Get(this,&local_28,0x40000000,0x3f800000,0);
            return uVar3;
          }
          return 0;
        }
        return this.onDown;
    }

    // Token : 0x600018C
    // RVA   : 0xF8C170   Offset: 0xF8AF70   Length: 0x4D7
    public GameObject Get(Vector3 myDir, float x, float y)
    {
        uint uVar1;
        float fVar2;
        long lVar3;
        float fVar4;
        float fVar5;
        bool cVar6;
        long lVar7;
        ulong uVar9;
        ulong uVar11;
        uint uVar12;
        ulong uVar13;
        float fVar14;
        float fVar15;
        ulong local_148;
        float local_140;
        byte[] local_138 = new byte[16];
        ulong local_128;
        float local_120;
        float local_110;
        float local_100;
        ulong local_f8;
        float local_f0;
        byte[] local_e8 = new byte[16];
        byte[] local_d8 = new byte[16];
        byte[] local_c8 = new byte[160];
        local_148 = 0;
        local_140 = 0.0;
        lVar7 = Component.get_transform(this,0);
        if (lVar7 != null) {
          local_120 = *(float *)(myDir + 1);
          local_128 = *myDir;
          puVar8 = (uint64 *)Transform.TransformDirection(local_138,lVar7,&local_128,0);
          uVar1 = *(uint32 *)(puVar8 + 1);
          *myDir = *puVar8;
          *(uint32 *)(myDir + 1) = uVar1;
          uVar9 = Component.get_gameObject(this,0);
          puVar8 = (uint64 *)UIKeyNavigation.GetCenter(local_138,uVar9,0);
          fVar15 = 3.4028235e+38;
          uVar13 = 0;
          uVar9 = *puVar8;
          fVar2 = *(float *)(puVar8 + 1);
          local_128._4_4_ = (float)((uint64)uVar9 >> 32);
          fVar5 = local_128._4_4_;
          local_128._0_4_ = (float)uVar9;
          fVar4 = (float)local_128;
          uVar11 = uVar13;
          local_128 = uVar9;
          local_120 = fVar2;
          while( true ) {
            if (UIKeyNavigation.list == null) break;
            uVar12 = (uint32)uVar13;
            if (UIKeyNavigation.list.constraint <= (int)uVar12) {
              return uVar11;
            }
            if ((UIKeyNavigation.list == null) ||
               (lVar3 = *(int64 *)(UIKeyNavigation.list + 16)) == null) break;
            if (*(uint32 *)(lVar3 + 24) <= uVar12) {
              uVar9 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1801e02d0(uVar9,0);
            }
            lVar3 = lVar3[uVar12];
            cVar6 = Object.op_Equality(lVar3,this,0);
            if (!cVar6) {
              if (lVar3 == null) break;
              if ((*(int *)(lVar3 + 24) != 3) &&
                 (cVar6 = UIKeyNavigation.get_isColliderEnabled(lVar3,0), cVar6)) {
                plVar10 = (int64 *)Component.GetComponent(lVar3,DAT_181e7a438);
                cVar6 = Object.op_Inequality(plVar10,0);
                if (cVar6) {
                  if (plVar10 == (int64 *)0) break;
                  fVar14 = (float)(**(code **)(*plVar10 + 0x1a8))
                                            (plVar10,*(uint64 *)(*plVar10 + 0x1b0));
                  if (fVar14 == 0.0) goto LAB_180f8c5ae;
                }
                uVar9 = Component.get_gameObject(lVar3,0);
                puVar8 = (uint64 *)UIKeyNavigation.GetCenter(local_e8,uVar9);
                local_120 = *(float *)(puVar8 + 1);
                local_148 = CONCAT44((float)((uint64)*puVar8 >> 32) - fVar5,(float)*puVar8 - fVar4);
                local_140 = local_120 - fVar2;
                puVar8 = (uint64 *)Vector3.get_normalized(local_d8,&local_148);
                local_110 = *(float *)(myDir + 1);
                local_100 = *(float *)(puVar8 + 1);
                if (0.707 <= (float)((uint64)*myDir >> 32) * (float)((uint64)*puVar8 >> 32) +
                             (float)*puVar8 * (float)*myDir + local_110 * local_100) {
                  local_f8 = local_148;
                  local_f0 = local_140;
                  puVar8 = (uint64 *)Transform.InverseTransformDirection(local_c8,lVar7,&local_f8,0);
                  local_140 = *(float *)(puVar8 + 1);
                  local_148._0_4_ = (float)*puVar8;
                  local_148._4_4_ = (float)((uint64)*puVar8 >> 32);
                  local_148 = CONCAT44(local_148._4_4_ * y,(float)local_148 * x);
                  fVar14 = (float)Vector3.get_sqrMagnitude(&local_148,0);
                  if (fVar14 <= fVar15) {
                    uVar11 = Component.get_gameObject(lVar3,0);
                    fVar15 = fVar14;
                  }
                }
              }
            }
        LAB_180f8c5ae:
            uVar13 = (uint64)(uVar12 + 1);
          }
        }
    }

    // Token : 0x600018D
    // RVA   : 0xF8BA50   Offset: 0xF8A850   Length: 0x3D0
    protected static Vector3 GetCenter(GameObject go)
    {
        ulong uVar1;
        bool cVar2;
        uint uVar3;
        long lVar5;
        long lVar7;
        ulong uVar8;
        float fVar9;
        float fVar10;
        float fVar11;
        float local_50;
        ulong local_38;
        float local_30;
        ulong local_28;
        uint local_20;
        if (param_2 != 0) {
          plVar4 = (int64 *)GameObject.GetComponent(param_2,DAT_181e57cf8);
          uVar3 = GameObject.get_layer(param_2,0);
          lVar5 = UICamera.FindCameraForLayer(uVar3,0);
          cVar2 = Object.op_Inequality(lVar5,0,0);
          if (!cVar2) {
            cVar2 = Object.op_Inequality(plVar4,0,0);
            if (!cVar2) {
              lVar5 = GameObject.get_transform(param_2,0);
              if (lVar5 != null) {
                puVar6 = (uint64 *)Transform.get_position(&local_28,lVar5,0);
                local_50 = *(float *)(puVar6 + 1);
                *(uint64 *)go = *puVar6;
        LAB_180f8bb93:
                go[2] = local_50;
                return go;
              }
            }
            else if ((plVar4 != (int64 *)0) &&
                    (lVar5 = (**(code **)(*plVar4 + 0x1e8))(plVar4,*(uint64 *)(*plVar4 + 0x1f0)),
                    lVar5 != null)) {
              if (*(uint32 *)(lVar5 + 24) == 0) {
                uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1801e02d0(uVar8,0);
              }
              if (2 < *(uint32 *)(lVar5 + 24)) {
                fVar9 = *(float *)(lVar5 + 40);
                uVar8 = *(uint64 *)(lVar5 + 56);
                uVar1 = *(uint64 *)(lVar5 + 32);
                fVar10 = *(float *)(lVar5 + 64);
                *go = ((float)uVar8 + (float)uVar1) * 0.5;
                go[1] = ((float)((uint64)uVar1 >> 32) + (float)((uint64)uVar8 >> 32)) * 0.5
                ;
                go[2] = (fVar9 + fVar10) * 0.5;
                return go;
              }
              uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1801e02d0(uVar8,0);
            }
          }
          else {
            lVar7 = GameObject.get_transform(param_2,0);
            if (lVar7 != null) {
              puVar6 = (uint64 *)Transform.get_position(&local_28,lVar7,0);
              uVar8 = *puVar6;
              fVar11 = (float)uVar8;
              fVar10 = (float)((uint64)uVar8 >> 32);
              fVar9 = *(float *)(puVar6 + 1);
              cVar2 = Object.op_Inequality(plVar4,0,0);
              if (cVar2) {
                if ((plVar4 == (int64 *)0) ||
                   (lVar7 = (**(code **)(*plVar4 + 0x1e8))(plVar4,*(uint64 *)(*plVar4 + 0x1f0)),
                   lVar7 == null)) throw; // [null/range check failed]
                if (*(uint32 *)(lVar7 + 24) == 0) {
                  uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1801e02d0(uVar8,0);
                }
                if (*(uint32 *)(lVar7 + 24) < 3) {
                  uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1801e02d0(uVar8,0);
                }
                local_38 = *(uint64 *)(lVar7 + 56);
                local_20 = *(uint32 *)(lVar7 + 64);
                local_30 = *(float *)(lVar7 + 64);
                fVar11 = ((float)local_38 + (float)*(uint64 *)(lVar7 + 32)) * 0.5;
                fVar10 = ((float)((uint64)*(uint64 *)(lVar7 + 32) >> 32) +
                         (float)((uint64)local_38 >> 32)) * 0.5;
                fVar9 = (*(float *)(lVar7 + 40) + local_30) * 0.5;
                local_28 = local_38;
              }
              if ((lVar5 != null) && (lVar5 = UICamera.get_cachedCamera(lVar5,0)) != null) {
                local_38 = CONCAT44(fVar10,fVar11);
                local_30 = fVar9;
                puVar6 = (uint64 *)Camera.WorldToScreenPoint(&local_28,lVar5,&local_38,0,uVar8);
                local_50 = 0.0;
                *(uint64 *)go = *puVar6;
                goto LAB_180f8bb93;
              }
            }
          }
        }
    }

    // Token : 0x600018E
    // RVA   : 0xF8CDF0   Offset: 0xF8BBF0   Length: 0x1AD
    public virtual void OnNavigate(KeyCode key)
    {
        int iVar1;
        bool cVar2;
        int iVar3;
        uint uVar4;
        ulong uVar5;
        cVar2 = UIPopupList.get_isOpen(0);
        if (!cVar2) {
          iVar1 = UIKeyNavigation.mLastFrame;
          iVar3 = Time.get_frameCount(0);
          if (iVar1 != iVar3) {
            uVar4 = Time.get_frameCount(0);
            UIKeyNavigation.mLastFrame = uVar4;
            uVar5 = 0;
            if (key == 0x111) {
              uVar5 = UIKeyNavigation.GetUp(this,0);
            }
            else if (key == 0x112) {
              uVar5 = UIKeyNavigation.GetDown(this,0);
            }
            else if (key == 0x113) {
              uVar5 = UIKeyNavigation.GetRight(this,0);
            }
            else if (key == 0x114) {
              uVar5 = UIKeyNavigation.GetLeft(this,0);
            }
            cVar2 = Object.op_Inequality(uVar5,0,0);
            if (cVar2) {
              UICamera.set_hoveredObject(uVar5,0);
            }
          }
        }
    }

    // Token : 0x600018F
    // RVA   : 0xF8C9A0   Offset: 0xF8B7A0   Length: 0x442
    public virtual void OnKey(KeyCode key)
    {
        int iVar1;
        bool cVar2;
        int iVar3;
        uint uVar4;
        long lVar5;
        cVar2 = UIPopupList.get_isOpen(0);
        if (cVar2) {
          return;
        }
        iVar1 = UIKeyNavigation.mLastFrame;
        iVar3 = Time.get_frameCount(0);
        if (iVar1 == iVar3) {
          return;
        }
        uVar4 = Time.get_frameCount(0);
        UIKeyNavigation.mLastFrame = uVar4;
        if (key != 9) {
          return;
        }
        lVar5 = this.onTab;
        cVar2 = Object.op_Equality(lVar5,0,0);
        if (cVar2) {
          lVar5 = UICamera.GetKey;
          if (lVar5 == null) goto LAB_180f8cddd;
          cVar2 = GetKeyStateFunc.Invoke(lVar5,0x130,0);
          if (!cVar2) {
            lVar5 = UICamera.GetKey;
            if (lVar5 == null) goto LAB_180f8cddd;
            cVar2 = GetKeyStateFunc.Invoke(lVar5,0x12f,0);
            if (!cVar2) {
              lVar5 = UIKeyNavigation.GetRight(this,0);
              cVar2 = Object.op_Equality(lVar5,0,0);
              if (cVar2) {
                lVar5 = UIKeyNavigation.GetDown(this,0);
              }
              cVar2 = Object.op_Equality(lVar5,0,0);
              if (cVar2) {
                lVar5 = UIKeyNavigation.GetUp(this,0);
              }
              cVar2 = Object.op_Equality(lVar5,0,0);
              if (cVar2) {
                lVar5 = UIKeyNavigation.GetLeft(this,0);
              }
              goto LAB_180f8cd10;
            }
          }
          lVar5 = UIKeyNavigation.GetLeft(this,0);
          cVar2 = Object.op_Equality(lVar5,0,0);
          if (cVar2) {
            lVar5 = UIKeyNavigation.GetUp(this,0);
          }
          cVar2 = Object.op_Equality(lVar5,0,0);
          if (cVar2) {
            lVar5 = UIKeyNavigation.GetDown(this,0);
          }
          cVar2 = Object.op_Equality(lVar5,0,0);
          if (cVar2) {
            lVar5 = UIKeyNavigation.GetRight(this,0);
          }
        }
        LAB_180f8cd10:
        cVar2 = Object.op_Inequality(lVar5,0,0);
        if (cVar2) {
          UICamera.set_currentScheme(2);
          UICamera.set_hoveredObject(lVar5,0);
          if (lVar5 == null) {
        LAB_180f8cddd:
                          // WARNING: Subroutine does not return
            FUN_1801e0300();
          }
          lVar5 = GameObject.GetComponent(lVar5,DAT_181e57a50);
          cVar2 = Object.op_Inequality(lVar5,0,0);
          if (cVar2) {
            if (lVar5 == null) goto LAB_180f8cddd;
            UIInput.set_isSelected(lVar5,1,0);
          }
        }
    }

    // Token : 0x6000190
    // RVA   : 0xF8C7B0   Offset: 0xF8B5B0   Length: 0x9C
    protected virtual void OnClick()
    {
        ulong uVar1;
        bool cVar2;
        uVar1 = this.onClick;
        cVar2 = NGUITools.GetActive(uVar1,0);
        if (cVar2) {
          uVar1 = this.onClick;
          UICamera.set_hoveredObject(uVar1,0);
        }
    }

    // Token : 0x6000191
    // RVA   : 0x2110A0   Offset: 0x20FEA0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_180ae8740(this,0);
    }

    // Token : 0x6000192
    // RVA   : 0xF8D020   Offset: 0xF8BE20   Length: 0x8C
    private static void /*cctor*/()
    {
        ulong uVar2;
        uVar2 = new BetterList_1(DAT_181e87610);
        puVar1 = *(uint64 **)(DAT_181e90150 + 184);
        *puVar1 = uVar2;
        il2cpp_internal(puVar1,uVar2);
        *(uint32 *)(*(int64 *)(DAT_181e90150 + 184) + 8) = 0;
    }

}
