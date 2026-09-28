// ============================================================
// Type  : UIKeyNavigation
// Token : 0x200004F
// ============================================================

public class UIKeyNavigation
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x40001C0
    public static BetterList<UIKeyNavigation> list;

    // Token: 0x40001C1
    public Constraint constraint;

    // Token: 0x40001C2
    public GameObject onUp;

    // Token: 0x40001C3
    public GameObject onDown;

    // Token: 0x40001C4
    public GameObject onLeft;

    // Token: 0x40001C5
    public GameObject onRight;

    // Token: 0x40001C6
    public GameObject onClick;

    // Token: 0x40001C7
    public GameObject onTab;

    // Token: 0x40001C8
    public bool startsSelected;

    // Token: 0x40001C9
    private bool mStarted;

    // Token: 0x40001CA
    public static int mLastFrame;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x600019B
    // RVA   : 0x118F5E0   Offset: 0x118E9E0   Length: 0xB7
    public static UIKeyNavigation get_current()
    {
        bool cVar1;
        long lVar2;
        ulong uVar3;
        lVar2 = UICamera.get_hoveredObject(0);
        cVar1 = Object.op_Equality(lVar2,0,0);
        if (!cVar1) {
          if (lVar2 != null) {
            uVar3 = GameObject.GetComponent(lVar2,DAT_181d74a10);
            return uVar3;
          }
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
        return 0;
    }

    // Token : 0x600019C
    // RVA   : 0x118F6A0   Offset: 0x118EAA0   Length: 0x13F
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
          lVar3 = Component.GetComponent(this,DAT_181d93b60);
          cVar1 = Object.op_Inequality(lVar3,0,0);
          if (!cVar1) {
            lVar3 = Component.GetComponent(this,DAT_181d93be0);
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

    // Token : 0x600019D
    // RVA   : 0x118EE10   Offset: 0x118E210   Length: 0xB3
    protected virtual void OnEnable()
    {
        var pStatics = *(int64*)(DAT_181dafcf8 + 184);
        if (*pStatics != 0) {
          FUN_181583c60(*pStatics,this,DAT_181da6cb8);
          if (this.mStarted) {
            MonoBehaviour.Invoke(this,"Start",0x3a83126f,0);
            return;
          }
          return;
        }
    }

    // Token : 0x600019E
    // RVA   : 0x118F4D0   Offset: 0x118E8D0   Length: 0x7D
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

    // Token : 0x600019F
    // RVA   : 0x118ED80   Offset: 0x118E180   Length: 0x81
    protected virtual void OnDisable()
    {
        var pStatics = *(int64*)(DAT_181dafcf8 + 184);
        if (*pStatics != 0) {
          FUN_181585c70(*pStatics,this,DAT_181da6d38);
          return;
        }
    }

    // Token : 0x60001A0
    // RVA   : 0x118EB80   Offset: 0x118DF80   Length: 0x153
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

    // Token : 0x60001A1
    // RVA   : 0x118E430   Offset: 0x118D830   Length: 0xCF
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

    // Token : 0x60001A2
    // RVA   : 0x118E500   Offset: 0x118D900   Length: 0xCF
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

    // Token : 0x60001A3
    // RVA   : 0x118E5D0   Offset: 0x118D9D0   Length: 0xCE
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

    // Token : 0x60001A4
    // RVA   : 0x118E360   Offset: 0x118D760   Length: 0xCE
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

    // Token : 0x60001A5
    // RVA   : 0x118E6A0   Offset: 0x118DAA0   Length: 0x4D7
    public GameObject Get(Vector3 myDir, float x, float y)
    {
        var pStatics = *(int64*)(DAT_181dafcf8 + 184);
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
            if (*pStatics == 0) break;
            uVar12 = (uint32)uVar13;
            if (*(int *)(*pStatics + 24) <= (int)uVar12) {
              return uVar11;
            }
            if ((*pStatics == 0) ||
               (lVar3 = *(int64 *)(*pStatics + 16)) == null) break;
            if (*(uint32 *)(lVar3 + 24) <= uVar12) {
              uVar9 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar9,0);
            }
            lVar3 = lVar3[uVar12];
            cVar6 = Object.op_Equality(lVar3,this,0);
            if (!cVar6) {
              if (lVar3 == null) break;
              if ((*(int *)(lVar3 + 24) != 3) &&
                 (cVar6 = UIKeyNavigation.get_isColliderEnabled(lVar3,0), cVar6)) {
                plVar10 = (int64 *)Component.GetComponent(lVar3,DAT_181d97060);
                cVar6 = Object.op_Inequality(plVar10,0);
                if (cVar6) {
                  if (plVar10 == (int64 *)0) break;
                  fVar14 = (float)(**(code **)(*plVar10 + 0x1a8))
                                            (plVar10,*(uint64 *)(*plVar10 + 0x1b0));
                  if (fVar14 == 0.0) goto LAB_18118eade;
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
        LAB_18118eade:
            uVar13 = (uint64)(uVar12 + 1);
          }
        }
    }

    // Token : 0x60001A6
    // RVA   : 0x118DF80   Offset: 0x118D380   Length: 0x3D0
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
          plVar4 = (int64 *)GameObject.GetComponent(param_2,DAT_181d74c30);
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
        LAB_18118e0c3:
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
                FUN_1800d65f0(uVar8,0);
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
              FUN_1800d65f0(uVar8,0);
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
                  FUN_1800d65f0(uVar8,0);
                }
                if (*(uint32 *)(lVar7 + 24) < 3) {
                  uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1800d65f0(uVar8,0);
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
                goto LAB_18118e0c3;
              }
            }
          }
        }
    }

    // Token : 0x60001A7
    // RVA   : 0x118F320   Offset: 0x118E720   Length: 0x1AD
    public virtual void OnNavigate(KeyCode key)
    {
        var pStatics = *(int64*)(DAT_181dafcf8 + 184);
        int iVar1;
        bool cVar2;
        int iVar3;
        uint uVar4;
        ulong uVar5;
        cVar2 = UIPopupList.get_isOpen(0);
        if (!cVar2) {
          iVar1 = *(int *)(pStatics + 8);
          iVar3 = Time.get_frameCount(0);
          if (iVar1 != iVar3) {
            uVar4 = Time.get_frameCount(0);
            *(uint32 *)(pStatics + 8) = uVar4;
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

    // Token : 0x60001A8
    // RVA   : 0x118EED0   Offset: 0x118E2D0   Length: 0x442
    public virtual void OnKey(KeyCode key)
    {
        var pStatics_f678 = *(int64*)(DAT_181daf678 + 184);
        var pStatics_fcf8 = *(int64*)(DAT_181dafcf8 + 184);
        int iVar1;
        bool cVar2;
        int iVar3;
        uint uVar4;
        long lVar5;
        cVar2 = UIPopupList.get_isOpen(0);
        if (cVar2) {
          return;
        }
        iVar1 = *(int *)(pStatics_fcf8 + 8);
        iVar3 = Time.get_frameCount(0);
        if (iVar1 == iVar3) {
          return;
        }
        uVar4 = Time.get_frameCount(0);
        *(uint32 *)(pStatics_fcf8 + 8) = uVar4;
        if (key != 9) {
          return;
        }
        lVar5 = this.onTab;
        cVar2 = Object.op_Equality(lVar5,0,0);
        if (cVar2) {
          lVar5 = *(int64 *)(pStatics_f678 + 24);
          if (lVar5 == null) goto LAB_18118f30d;
          cVar2 = GetKeyStateFunc.Invoke(lVar5,0x130,0);
          if (!cVar2) {
            lVar5 = *(int64 *)(pStatics_f678 + 24);
            if (lVar5 == null) goto LAB_18118f30d;
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
              goto LAB_18118f240;
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
        LAB_18118f240:
        cVar2 = Object.op_Inequality(lVar5,0,0);
        if (cVar2) {
          UICamera.set_currentScheme(2);
          UICamera.set_hoveredObject(lVar5,0);
          if (lVar5 == null) {
        LAB_18118f30d:
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          lVar5 = GameObject.GetComponent(lVar5,DAT_181d74988);
          cVar2 = Object.op_Inequality(lVar5,0,0);
          if (cVar2) {
            if (lVar5 == null) goto LAB_18118f30d;
            UIInput.set_isSelected(lVar5,1,0);
          }
        }
    }

    // Token : 0x60001A9
    // RVA   : 0x118ECE0   Offset: 0x118E0E0   Length: 0x9C
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

    // Token : 0x60001AA
    // RVA   : 0x3A17B0   Offset: 0x3A0BB0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_18044ef50(this,0);
    }

    // Token : 0x60001AB
    // RVA   : 0x118F550   Offset: 0x118E950   Length: 0x8C
    private static void /*cctor*/()
    {
        ulong uVar2;
        uVar2 = new BetterList_1(DAT_181da6c38);
        puVar1 = *(uint64 **)(DAT_181dafcf8 + 184);
        *puVar1 = uVar2;
        il2cpp_internal(puVar1,uVar2);
        *(uint32 *)(*(int64 *)(DAT_181dafcf8 + 184) + 8) = 0;
    }

}
