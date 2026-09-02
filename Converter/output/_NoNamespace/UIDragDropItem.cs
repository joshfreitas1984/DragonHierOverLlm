// ============================================================
// Type  : UIDragDropItem
// Token : 0x200003C
// ============================================================

public class UIDragDropItem
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x400010A
    public Restriction restriction;

    // Token: 0x400010B
    public bool clickToDrag;

    // Token: 0x400010C
    public bool cloneOnDrag;

    // Token: 0x400010D
    public bool interactable;

    // Token: 0x400010E
    public float pressAndHoldDelay;

    // Token: 0x400010F
    protected Transform mTrans;

    // Token: 0x4000110
    protected Transform mParent;

    // Token: 0x4000111
    protected Collider mCollider;

    // Token: 0x4000112
    protected Collider2D mCollider2D;

    // Token: 0x4000113
    protected UIButton mButton;

    // Token: 0x4000114
    protected UIRoot mRoot;

    // Token: 0x4000115
    protected UIGrid mGrid;

    // Token: 0x4000116
    protected UITable mTable;

    // Token: 0x4000117
    protected float mDragStartTime;

    // Token: 0x4000118
    protected UIDragScrollView mDragScrollView;

    // Token: 0x4000119
    protected bool mPressed;

    // Token: 0x400011A
    protected bool mDragging;

    // Token: 0x400011B
    protected MouseOrTouch mTouch;

    // Token: 0x400011C
    public static List<UIDragDropItem> draggedItems;

    // Token: 0x400011D
    private static int mIgnoreClick;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60000FA
    // RVA   : 0x13D5DB0   Offset: 0x13D45B0   Length: 0x20B
    public static bool IsDragged(GameObject go)
    {
        var pStatics = *(int64*)(DAT_181d8a658 + 184);
        bool cVar1;
        ulong uVar2;
        ulong uVar3;
        int iVar4;
        int[] aiStack_64 = new int[5];
        uint local_50;
        uint32 uStack_4c;
        uint32 uStack_48;
        uint32 uStack_44;
        int64 local_40;
        uint32 local_38;
        uint32 uStack_34;
        uint32 uStack_30;
        uint32 uStack_2c;
        int64 local_28;
        bVar5 = 0;
        aiStack_64[3] = 0;
        if (*pStatics == 0) {
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
        FUN_1817ff240(&local_38,*pStatics,DAT_181d81b78);
        local_50 = local_38;
        uStack_4c = uStack_34;
        uStack_48 = uStack_30;
        uStack_44 = uStack_2c;
        local_40 = local_28;
        do {
          cVar1 = FUN_180d197a0(&local_50,DAT_181d6ccb8);
          if (!cVar1) {
            aiStack_64[1] = 62;
            iVar4 = aiStack_64[3] + 1;
            aiStack_64[3] = iVar4;
            uVar3 = ZhSegment.Initialize(&local_50,DAT_181d6cc38);
            goto LAB_1813d5f72;
          }
          if (local_40 == 0) {
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          uVar2 = Component.get_gameObject(local_40,0);
          cVar1 = Object.op_Equality(uVar2,go,0);
        } while (!cVar1);
        bVar5 = 1;
        aiStack_64[1] = 64;
        iVar4 = aiStack_64[3] + 1;
        aiStack_64[3] = iVar4;
        uVar3 = ZhSegment.Initialize(&local_50,DAT_181d6cc38);
        LAB_1813d5f72:
        if ((iVar4 != 0) && (aiStack_64[iVar4] == 64)) {
          return (uint64)bVar5;
        }
        return uVar3 & 0xffffffffffffff00;
    }

    // Token : 0x60000FB
    // RVA   : 0x13D5C20   Offset: 0x13D4420   Length: 0xAE
    protected virtual void Awake()
    {
        ulong uVar1;
        long lVar2;
        uVar1 = Component.get_transform(this,0);
        this.mTrans = uVar1;
        lVar2 = Component.get_gameObject(this,0);
        if (lVar2 != null) {
          uVar1 = GameObject.GetComponent(lVar2,DAT_181d9f328);
          this.mCollider = uVar1;
          lVar2 = Component.get_gameObject(this,0);
          if (lVar2 != null) {
            uVar1 = GameObject.GetComponent(lVar2,DAT_181d9f3b0);
            this.mCollider2D = uVar1;
            return;
          }
        }
    }

    // Token : 0x60000FC
    // RVA   : 0x245810   Offset: 0x244010   Length: 0x3
    protected virtual void OnEnable()
    {
    }

    // Token : 0x60000FD
    // RVA   : 0x13D63E0   Offset: 0x13D4BE0   Length: 0x275
    protected virtual void OnDisable()
    {
        var pStatics = *(int64*)(DAT_181d8a458 + 184);
        ulong uVar1;
        ulong uVar2;
        if (*(char *)((int64)this + 121) != false) {
          *(uint8 *)((int64)this + 121) = 0;
          (**(code **)(*this + 600))(this,0,*(uint64 *)(*this + 0x260));
          uVar1 = *(uint64 *)(pStatics + 0x118);
          uVar2 = new OnTooltipCB(this,DAT_181d9c960,0);
          plVar3 = (int64 *)Delegate.Remove(uVar1,uVar2,0);
          plVar6 = (int64 *)0;
          plVar4 = plVar6;
          if (plVar3 != (int64 *)0) {
            if (*plVar3 == DAT_181d67e90) {
              plVar4 = plVar3;
            }
            if (plVar4 == (int64 *)0) {
                          // WARNING: Subroutine does not return
              FUN_1800d6070(plVar3,DAT_181d67e90);
            }
          }
          *(int64 **)(pStatics + 0x118) = plVar4;
          uVar1 = *(uint64 *)(pStatics + 0x100);
          uVar2 = new OnTooltipCB(this,DAT_181d9c8d8,0);
          plVar3 = (int64 *)Delegate.Remove(uVar1,uVar2,0);
          plVar4 = plVar6;
          if (plVar3 != (int64 *)0) {
            if (*plVar3 == DAT_181d68490) {
              plVar4 = plVar3;
            }
            if (plVar4 == (int64 *)0) {
                          // WARNING: Subroutine does not return
              FUN_1800d6070(plVar3,DAT_181d68490);
            }
          }
          *(int64 **)(pStatics + 0x100) = plVar4;
          uVar1 = *(uint64 *)(pStatics + 0x180);
          uVar2 = new OnTooltipCB(this,*(uint64 *)(*this + 0x220),0);
          plVar4 = (int64 *)Delegate.Remove(uVar1,uVar2,0);
          if (plVar4 != (int64 *)0) {
            if (*plVar4 == DAT_181d68290) {
              plVar6 = plVar4;
            }
            if (plVar6 == (int64 *)0) {
                          // WARNING: Subroutine does not return
              FUN_1800d6070(plVar4);
            }
          }
          puVar5 = (uint64 *)(pStatics + 0x180);
          *puVar5 = plVar6;
          il2cpp_internal(puVar5,plVar6);
        }
    }

    // Token : 0x60000FE
    // RVA   : 0x13D84A0   Offset: 0x13D6CA0   Length: 0x72
    protected virtual void Start()
    {
        ulong uVar1;
        uVar1 = Component.GetComponent(this,DAT_181d6dec0);
        this.mButton = uVar1;
        uVar1 = Component.GetComponent(this,DAT_181d6e040);
        this.mDragScrollView = uVar1;
    }

    // Token : 0x60000FF
    // RVA   : 0x13D7CE0   Offset: 0x13D64E0   Length: 0x187
    protected virtual void OnPress(bool isPressed)
    {
        var pStatics = *(int64*)(DAT_181d8a458 + 184);
        long lVar1;
        float fVar2;
        if (this.interactable) {
          if (*(int *)(pStatics + 212) != -2) {
            if (*(int *)(pStatics + 212) != -3) {
              if (!isPressed) {
                if (this.mPressed) {
                  lVar1 = this.mTouch;
                  if ((lVar1 == *(int64 *)(pStatics + 224)) &&
                     ((this.mPressed = 0, !this.mDragging ||
                      (!this.clickToDrag)))) {
                    this.mTouch = 0;
                    return;
                  }
                }
              }
              else if (!this.mPressed) {
                this.mTouch =
                     *(uint64 *)(pStatics + 224);
                il2cpp_internal();
                fVar2 = (float)RealTime.get_time(0);
                this.mPressed = 1;
                this.mDragStartTime = fVar2 + this.pressAndHoldDelay;
              }
            }
          }
        }
    }

    // Token : 0x6000100
    // RVA   : 0x13D5FF0   Offset: 0x13D47F0   Length: 0x3E9
    protected virtual void OnClick()
    {
        var pStatics_a458 = *(int64*)(DAT_181d8a458 + 184);
        var pStatics_a658 = *(int64*)(DAT_181d8a658 + 184);
        int iVar1;
        ulong uVar2;
        bool cVar3;
        int iVar4;
        ulong uVar6;
        iVar1 = *(int *)(pStatics_a658 + 8);
        iVar4 = Time.get_frameCount(0);
        if (((iVar1 != iVar4) && (*(char *)((int64)this + 28) != false)) &&
           (*(char *)((int64)this + 121) == false)) {
          if (*(int *)(pStatics_a458 + 212) == -1) {
            if (*pStatics_a658 == 0) {
        LAB_1813d63b3:
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            if (*(int *)(*pStatics_a658 + 24) == 0) {
              this[16] = *(int64 *)(pStatics_a458 + 224);
              il2cpp_internal();
              plVar5 = (int64 *)
                       (**(code **)(*this + 0x1f8))(this,*(uint64 *)(*this + 0x200));
              if (*(char *)((int64)this + 28) != false) {
                cVar3 = Object.op_Inequality(plVar5,0,0);
                if (cVar3) {
                  uVar2 = *(uint64 *)(pStatics_a458 + 0x180);
                  uVar6 = il2cpp_internal(DAT_181d68290);
                  if (plVar5 == (int64 *)0) goto LAB_1813d63b3;
                  OnTooltipCB.ctor(uVar6,plVar5,*(uint64 *)(*plVar5 + 0x220),0);
                  plVar7 = (int64 *)Delegate.Combine(uVar2,uVar6,0);
                  plVar10 = (int64 *)0;
                  plVar9 = plVar10;
                  if (plVar7 != (int64 *)0) {
                    if (*plVar7 == DAT_181d68290) {
                      plVar9 = plVar7;
                    }
                    if (plVar9 == (int64 *)0) {
                          // WARNING: Subroutine does not return
                      FUN_1800d6070(plVar7,DAT_181d68290);
                    }
                  }
                  *(int64 **)(pStatics_a458 + 0x180) = plVar9;
                  uVar2 = *(uint64 *)(pStatics_a458 + 0x118);
                  uVar6 = new OnTooltipCB(plVar5,DAT_181d9c960,0);
                  plVar7 = (int64 *)Delegate.Combine(uVar2,uVar6,0);
                  plVar9 = plVar10;
                  if (plVar7 != (int64 *)0) {
                    if (*plVar7 == DAT_181d67e90) {
                      plVar9 = plVar7;
                    }
                    if (plVar9 == (int64 *)0) {
                          // WARNING: Subroutine does not return
                      FUN_1800d6070(plVar7,DAT_181d67e90);
                    }
                  }
                  *(int64 **)(pStatics_a458 + 0x118) = plVar9;
                  uVar2 = *(uint64 *)(pStatics_a458 + 0x100);
                  uVar6 = new OnTooltipCB(plVar5,DAT_181d9c8d8,0);
                  plVar5 = (int64 *)Delegate.Combine(uVar2,uVar6,0);
                  if (plVar5 != (int64 *)0) {
                    if (*plVar5 == DAT_181d68490) {
                      plVar10 = plVar5;
                    }
                    if (plVar10 == (int64 *)0) {
                          // WARNING: Subroutine does not return
                      FUN_1800d6070(plVar5);
                    }
                  }
                  puVar8 = (uint64 *)(pStatics_a458 + 0x100);
                  *puVar8 = plVar10;
                  il2cpp_internal(puVar8,plVar10);
                }
              }
            }
          }
        }
    }

    // Token : 0x6000101
    // RVA   : 0x13D79E0   Offset: 0x13D61E0   Length: 0x2FD
    protected void OnGlobalPress(GameObject go, bool state)
    {
        var pStatics = *(int64*)(DAT_181d8a458 + 184);
        ulong uVar1;
        uint uVar2;
        ulong uVar3;
        if (state) {
          if (*(int *)(pStatics + 212) != -1) {
            uVar2 = Time.get_frameCount(0);
            *(uint32 *)(*(int64 *)(DAT_181d8a658 + 184) + 8) = uVar2;
            if (*(char *)((int64)this + 121) != false) {
              *(uint8 *)((int64)this + 121) = 0;
              (**(code **)(*this + 600))(this,0,*(uint64 *)(*this + 0x260));
            }
            uVar1 = *(uint64 *)(pStatics + 0x118);
            uVar3 = new OnTooltipCB(this,DAT_181d9c960,0);
            plVar4 = (int64 *)Delegate.Remove(uVar1,uVar3,0);
            plVar7 = (int64 *)0;
            plVar5 = plVar7;
            if (plVar4 != (int64 *)0) {
              if (*plVar4 == DAT_181d67e90) {
                plVar5 = plVar4;
              }
              if (plVar5 == (int64 *)0) {
                          // WARNING: Subroutine does not return
                FUN_1800d6070(plVar4,DAT_181d67e90);
              }
            }
            *(int64 **)(pStatics + 0x118) = plVar5;
            uVar1 = *(uint64 *)(pStatics + 0x100);
            uVar3 = new OnTooltipCB(this,DAT_181d9c8d8,0);
            plVar4 = (int64 *)Delegate.Remove(uVar1,uVar3,0);
            plVar5 = plVar7;
            if (plVar4 != (int64 *)0) {
              if (*plVar4 == DAT_181d68490) {
                plVar5 = plVar4;
              }
              if (plVar5 == (int64 *)0) {
                          // WARNING: Subroutine does not return
                FUN_1800d6070(plVar4,DAT_181d68490);
              }
            }
            *(int64 **)(pStatics + 0x100) = plVar5;
            uVar1 = *(uint64 *)(pStatics + 0x180);
            uVar3 = new OnTooltipCB(this,*(uint64 *)(*this + 0x220),0);
            plVar5 = (int64 *)Delegate.Remove(uVar1,uVar3,0);
            if (plVar5 != (int64 *)0) {
              if (*plVar5 == DAT_181d68290) {
                plVar7 = plVar5;
              }
              if (plVar7 == (int64 *)0) {
                          // WARNING: Subroutine does not return
                FUN_1800d6070(plVar5);
              }
            }
            puVar6 = (uint64 *)(pStatics + 0x180);
            *puVar6 = plVar7;
            il2cpp_internal(puVar6,plVar7);
          }
        }
    }

    // Token : 0x6000102
    // RVA   : 0x13D76E0   Offset: 0x13D5EE0   Length: 0x2F4
    protected void OnGlobalClick(GameObject go)
    {
        var pStatics = *(int64*)(DAT_181d8a458 + 184);
        ulong uVar1;
        uint uVar2;
        ulong uVar3;
        uVar2 = Time.get_frameCount(0);
        *(uint32 *)(*(int64 *)(DAT_181d8a658 + 184) + 8) = uVar2;
        if (*(int *)(pStatics + 212) == -1) {
          if (*(char *)((int64)this + 121) == false) goto LAB_1813d77fa;
        }
        else {
          if (*(char *)((int64)this + 121) == false) goto LAB_1813d77fa;
          go = 0;
        }
        *(uint8 *)((int64)this + 121) = 0;
        (**(code **)(*this + 600))(this,go,*(uint64 *)(*this + 0x260));
        LAB_1813d77fa:
        uVar1 = *(uint64 *)(pStatics + 0x118);
        uVar3 = new OnTooltipCB(this,DAT_181d9c960,0);
        plVar4 = (int64 *)Delegate.Remove(uVar1,uVar3,0);
        plVar7 = (int64 *)0;
        plVar5 = plVar7;
        if (plVar4 != (int64 *)0) {
          if (*plVar4 == DAT_181d67e90) {
            plVar5 = plVar4;
          }
          if (plVar5 == (int64 *)0) {
                          // WARNING: Subroutine does not return
            FUN_1800d6070(plVar4,DAT_181d67e90);
          }
        }
        *(int64 **)(pStatics + 0x118) = plVar5;
        uVar1 = *(uint64 *)(pStatics + 0x100);
        uVar3 = new OnTooltipCB(this,DAT_181d9c8d8,0);
        plVar4 = (int64 *)Delegate.Remove(uVar1,uVar3,0);
        plVar5 = plVar7;
        if (plVar4 != (int64 *)0) {
          if (*plVar4 == DAT_181d68490) {
            plVar5 = plVar4;
          }
          if (plVar5 == (int64 *)0) {
                          // WARNING: Subroutine does not return
            FUN_1800d6070(plVar4,DAT_181d68490);
          }
        }
        *(int64 **)(pStatics + 0x100) = plVar5;
        uVar1 = *(uint64 *)(pStatics + 0x180);
        uVar3 = new OnTooltipCB(this,*(uint64 *)(*this + 0x220),0);
        plVar5 = (int64 *)Delegate.Remove(uVar1,uVar3,0);
        if (plVar5 != (int64 *)0) {
          if (*plVar5 == DAT_181d68290) {
            plVar7 = plVar5;
          }
          if (plVar7 == (int64 *)0) {
                          // WARNING: Subroutine does not return
            FUN_1800d6070(plVar5);
          }
        }
        puVar6 = (uint64 *)(pStatics + 0x180);
        *puVar6 = plVar7;
        il2cpp_internal(puVar6,plVar7);
    }

    // Token : 0x6000103
    // RVA   : 0x13D8540   Offset: 0x13D6D40   Length: 0x55
    protected virtual void Update()
    {
        float fVar1;
        float fVar2;
        if ((((int)this[3] == 3) && ((char)this[15] != false)) &&
           (*(char *)((int64)this + 121) == false)) {
          fVar1 = *(float *)(this + 13);
          fVar2 = (float)RealTime.get_time(0);
          if (fVar1 < fVar2) {
                          // WARNING: Could not recover jumptable at 0x0001813d8588. Too many branches
                          // WARNING: Treating indirect jump as call
            (**(code **)(*this + 0x1f8))(this,*(uint64 *)(*this + 0x200));
            return;
          }
        }
    }

    // Token : 0x6000104
    // RVA   : 0x13D7470   Offset: 0x13D5C70   Length: 0x11A
    protected virtual void OnDragStart()
    {
        int iVar1;
        long lVar2;
        bool cVar3;
        if ((*(char *)((int64)this + 30) != false) &&
           (cVar3 = Behaviour.get_enabled(this,0), cVar3)) {
          lVar2 = this[16];
          if (lVar2 == *(int64 *)(*(int64 *)(DAT_181d8a458 + 184) + 224)) {
            iVar1 = (int)this[3];
            if (iVar1 != 0) {
              if (iVar1 == 1) {
                lVar2 = this[16];
                if (lVar2 == null) {
        LAB_1813d7585:
                          // WARNING: Subroutine does not return
                  FUN_1800d6620();
                }
                if (ABS(*(float *)(lVar2 + 44)) < ABS(*(float *)(lVar2 + 48))) {
                  return;
                }
              }
              else if (iVar1 == 2) {
                lVar2 = this[16];
                if (lVar2 == null) goto LAB_1813d7585;
                if (ABS(*(float *)(lVar2 + 48)) < ABS(*(float *)(lVar2 + 44))) {
                  return;
                }
              }
              else if (iVar1 == 3) {
                return;
              }
            }
                          // WARNING: Could not recover jumptable at 0x0001813d751e. Too many branches
                          // WARNING: Treating indirect jump as call
            (**(code **)(*this + 0x1f8))(this,*(uint64 *)(*this + 0x200));
            return;
          }
        }
    }

    // Token : 0x6000105
    // RVA   : 0x13D7E70   Offset: 0x13D6670   Length: 0x625
    public virtual UIDragDropItem StartDragging()
    {
        var pStatics = *(int64*)(DAT_181d8a458 + 184);
        bool cVar1;
        ulong uVar2;
        long lVar3;
        ulong uVar4;
        long lVar5;
        long lVar6;
        byte[] local_res8 = new byte[8];
        byte[] local_res18 = new byte[8];
        ulong local_38;
        uint local_30;
        uint local_28;
        uint uStack_24;
        uint uStack_20;
        uint32 uStack_1c;
        if (*(char *)((int64)this + 30) != false) {
          uVar2 = Component.get_transform(this,0);
          cVar1 = Object.op_Implicit(uVar2,0);
          if (cVar1) {
            lVar3 = Component.get_transform(this,0);
            if (lVar3 != null) {
              uVar2 = FUN_180da0f00(lVar3,0);
              cVar1 = Object.op_Implicit(uVar2,0);
              if (!cVar1) {
                return (int64 *)0;
              }
              if (*(char *)((int64)this + 121) != false) {
                return (int64 *)0;
              }
              if (*(char *)((int64)this + 29) == false) {
                *(uint8 *)((int64)this + 121) = 1;
                (**(code **)(*this + 0x238))(this,*(uint64 *)(*this + 0x240));
                return this;
              }
              *(uint8 *)(this + 15) = 0;
              lVar3 = Component.get_transform(this,0);
              if ((lVar3 != null) && (lVar3 = FUN_180da0f00(lVar3,0)) != null) {
                uVar2 = Component.get_gameObject(lVar3,0);
                uVar4 = Component.get_gameObject(this,0);
                lVar3 = NGUITools.AddChild(uVar2,uVar4,0);
                if (lVar3 != null) {
                  lVar5 = GameObject.get_transform(lVar3,0);
                  lVar6 = Component.get_transform(this,0);
                  if ((lVar6 != null) &&
                     (puVar7 = (uint64 *)Transform.get_localPosition(&local_28,lVar6,0), lVar5 != null))
                  {
                    local_38 = *puVar7;
                    local_30 = *(uint32 *)(puVar7 + 1);
                    Transform.set_localPosition(lVar5,&local_38,0);
                    lVar5 = GameObject.get_transform(lVar3,0);
                    lVar6 = Component.get_transform(this,0);
                    if ((lVar6 != null) &&
                       (puVar8 = (uint32 *)Transform.get_localRotation(&local_28,lVar6,0), lVar5 != null
                       )) {
                      local_28 = *puVar8;
                      uStack_24 = puVar8[1];
                      uStack_20 = puVar8[2];
                      uStack_1c = puVar8[3];
                      Transform.set_localRotation(lVar5,&local_28,0);
                      lVar5 = GameObject.get_transform(lVar3,0);
                      lVar6 = Component.get_transform(this,0);
                      if ((lVar6 != null) &&
                         (puVar7 = (uint64 *)Transform.get_localScale(&local_28,lVar6,0), lVar5 != null)
                         ) {
                        local_38 = *puVar7;
                        local_30 = *(uint32 *)(puVar7 + 1);
                        Transform.set_localScale(lVar5,&local_38,0);
                        plVar9 = (int64 *)GameObject.GetComponent(lVar3,DAT_181da2430);
                        cVar1 = Object.op_Inequality(plVar9,0,0);
                        if (cVar1) {
                          plVar10 = (int64 *)Component.GetComponent(this,DAT_181d6df40);
                          if (plVar10 == (int64 *)0) goto LAB_1813d8490;
                          if (*(char *)((int64)plVar10 + 116) == false) {
                            (**(code **)(*plVar10 + 0x198))(plVar10,*(uint64 *)(*plVar10 + 0x1a0));
                          }
                          if (plVar9 == (int64 *)0) goto LAB_1813d8490;
                          local_28 = *(uint32 *)((int64)plVar10 + 100);
                          uStack_24 = (uint32)plVar10[13];
                          uStack_20 = *(uint32 *)((int64)plVar10 + 108);
                          uStack_1c = (uint32)plVar10[14];
                          if (*(char *)((int64)plVar9 + 116) == false) {
                            (**(code **)(*plVar9 + 0x198))(plVar9,*(uint64 *)(*plVar9 + 0x1a0));
                          }
                          lVar5 = plVar9[16];
                          *(uint32 *)((int64)plVar9 + 100) = local_28;
                          *(uint32 *)(plVar9 + 13) = uStack_24;
                          *(uint32 *)((int64)plVar9 + 108) = uStack_20;
                          *(uint32 *)(plVar9 + 14) = uStack_1c;
                          *(uint32 *)(plVar9 + 16) = 3;
                          (**(code **)(*plVar9 + 0x208))
                                    (plVar9,(int)lVar5,0,*(uint64 *)(*plVar9 + 0x210));
                        }
                        plVar9 = this + 16;
                        if (*plVar9 != 0) {
                          uVar2 = *(uint64 *)(*plVar9 + 80);
                          uVar4 = Component.get_gameObject(this,0);
                          cVar1 = Object.op_Equality(uVar2,uVar4,0);
                          if (cVar1) {
                            if (*plVar9 == 0) goto LAB_1813d8490;
                            plVar10 = (int64 *)(*plVar9 + 72);
                            *plVar10 = lVar3;
                            il2cpp_internal(plVar10,lVar3);
                            if (*plVar9 == 0) goto LAB_1813d8490;
                            plVar10 = (int64 *)(*plVar9 + 80);
                            *plVar10 = lVar3;
                            il2cpp_internal(plVar10,lVar3);
                            if (*plVar9 == 0) goto LAB_1813d8490;
                            plVar10 = (int64 *)(*plVar9 + 88);
                            *plVar10 = lVar3;
                            il2cpp_internal(plVar10,lVar3);
                            if (*plVar9 == 0) goto LAB_1813d8490;
                            plVar10 = (int64 *)(*plVar9 + 64);
                            *plVar10 = lVar3;
                            il2cpp_internal(plVar10,lVar3);
                          }
                        }
                        plVar10 = (int64 *)GameObject.GetComponent(lVar3,DAT_181da24b0);
                        if (plVar10 != (int64 *)0) {
                          plVar10[16] = *plVar9;
                          il2cpp_internal();
                          *(uint16 *)(plVar10 + 15) = 0x101;
                          (**(code **)(*plVar10 + 0x1a8))(plVar10,*(uint64 *)(*plVar10 + 0x1b0));
                          uVar2 = Component.get_gameObject(this,0);
                          (**(code **)(*plVar10 + 0x208))(plVar10,uVar2,*(uint64 *)(*plVar10 + 0x210))
                          ;
                          (**(code **)(*plVar10 + 0x238))(plVar10,*(uint64 *)(*plVar10 + 0x240));
                          if (*(int64 *)(pStatics + 224) == 0) {
                            lVar3 = *plVar9;
                            plVar11 = (int64 *)(pStatics + 224);
                            *plVar11 = lVar3;
                            il2cpp_internal(plVar11,lVar3);
                          }
                          *plVar9 = 0;
                          il2cpp_internal(plVar9,0);
                          uVar2 = Component.get_gameObject(this,0);
                          local_res8[0] = 0;
                          uVar4 = il2cpp_value_box(DAT_181d8d920,local_res8);
                          UICamera.Notify(uVar2,"OnPress",uVar4,0);
                          uVar2 = Component.get_gameObject(this,0);
                          local_res18[0] = 0;
                          uVar4 = il2cpp_value_box(DAT_181d8d920,local_res18);
                          UICamera.Notify(uVar2,"OnHover",uVar4,0);
                          return plVar10;
                        }
                      }
                    }
                  }
                }
              }
            }
        LAB_1813d8490:
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
        }
        return (int64 *)0;
    }

    // Token : 0x6000106
    // RVA   : 0x245810   Offset: 0x244010   Length: 0x3
    protected virtual void OnClone(GameObject original)
    {
    }

    // Token : 0x6000107
    // RVA   : 0x13D7590   Offset: 0x13D5D90   Length: 0x146
    protected virtual void OnDrag(Vector2 delta)
    {
        bool cVar1;
        long lVar2;
        ulong uVar3;
        float fVar4;
        float local_28;
        float fStack_24;
        if (((*(char *)((int64)this + 30) != false) &&
            (*(char *)((int64)this + 121) != false)) &&
           (cVar1 = Behaviour.get_enabled(this,0), cVar1)) {
          lVar2 = this[16];
          if (lVar2 == *(int64 *)(*(int64 *)(DAT_181d8a458 + 184) + 224)) {
            lVar2 = this[10];
            cVar1 = Object.op_Inequality(lVar2,0,0);
            if (!cVar1) {
              lVar2 = *this;
              uVar3 = *(uint64 *)(lVar2 + 0x250);
            }
            else {
              if (this[10] == 0) {
                          // WARNING: Subroutine does not return
                FUN_1800d6620();
              }
              fVar4 = (float)UIRoot.get_pixelSizeAdjustment(this[10],0);
              local_28 = (float)delta;
              fStack_24 = (float)((uint64)delta >> 32);
              lVar2 = *this;
              delta = CONCAT44(fStack_24 * fVar4,local_28 * fVar4);
              uVar3 = *(uint64 *)(lVar2 + 0x250);
            }
            (**(code **)(lVar2 + 0x248))(this,delta,uVar3);
          }
        }
    }

    // Token : 0x6000108
    // RVA   : 0x13D72F0   Offset: 0x13D5AF0   Length: 0x174
    protected virtual void OnDragEnd()
    {
        var pStatics = *(int64*)(DAT_181d8a458 + 184);
        bool cVar1;
        ulong uVar2;
        long lVar3;
        if ((*(char *)((int64)this + 30) != false) &&
           (cVar1 = Behaviour.get_enabled(this,0), cVar1)) {
          lVar3 = this[16];
          if (lVar3 == *(int64 *)(pStatics + 224)) {
            uVar2 = RaycastHit.get_collider(pStatics + 136,0);
            cVar1 = Object.op_Inequality(uVar2,0,0);
            if (!cVar1) {
              uVar2 = 0;
            }
            else {
              lVar3 = RaycastHit.get_collider(pStatics + 136,0);
              if (lVar3 == null) {
                          // WARNING: Subroutine does not return
                FUN_1800d6620();
              }
              uVar2 = Component.get_gameObject(lVar3,0);
            }
            if (*(char *)((int64)this + 121) != false) {
              *(uint8 *)((int64)this + 121) = 0;
              (**(code **)(*this + 600))(this,uVar2,*(uint64 *)(*this + 0x260));
            }
          }
        }
    }

    // Token : 0x6000109
    // RVA   : 0x13D8520   Offset: 0x13D6D20   Length: 0x1C
    public void StopDragging(GameObject go)
    {
        void FUN_1813d8520(int64 *this,uint64 go)
        {
        if (*(char *)((int64)this + 121) != false) {
          *(uint8 *)((int64)this + 121) = 0;
                          // WARNING: Could not recover jumptable at 0x0001813d8534. Too many branches
                          // WARNING: Treating indirect jump as call
          (**(code **)(*this + 600))(this,go,*(uint64 *)(*this + 0x260));
          return;
        }
    }

    // Token : 0x600010A
    // RVA   : 0x13D6D80   Offset: 0x13D5580   Length: 0x562
    protected virtual void OnDragDropStart()
    {
        var pStatics = *(int64*)(DAT_181d8a658 + 184);
        bool cVar3;
        ulong uVar4;
        long lVar5;
        ulong local_18;
        uint local_10;
        if (*pStatics != 0) {
          cVar3 = FUN_1818279a0(*pStatics,this,DAT_181d81af8);
          if (!cVar3) {
            if (*pStatics == 0) throw; // [null/range check failed]
            FUN_181827900(*pStatics,this,DAT_181d81a78);
          }
          uVar4 = this.mDragScrollView;
          cVar3 = Object.op_Inequality(uVar4,0,0);
          if (cVar3) {
            if (this.mDragScrollView == null) throw; // [null/range check failed]
            Behaviour.set_enabled(this.mDragScrollView,0,0);
          }
          uVar4 = this.mButton;
          cVar3 = Object.op_Inequality(uVar4,0,0);
          if (!cVar3) {
            uVar4 = this.mCollider;
            cVar3 = Object.op_Inequality(uVar4,0,0);
            if (!cVar3) {
              uVar4 = this.mCollider2D;
              cVar3 = Object.op_Inequality(uVar4,0,0);
              if (cVar3) {
                if (this.mCollider2D == null) throw; // [null/range check failed]
                Behaviour.set_enabled(this.mCollider2D,0,0);
              }
            }
            else {
              if (this.mCollider == null) throw; // [null/range check failed]
              Collider.set_enabled(this.mCollider,0,0);
            }
          }
          else {
            plVar1 = this.mButton;
            if (plVar1 == (int64 *)0) throw; // [null/range check failed]
            (**(code **)(*plVar1 + 0x188))(plVar1,0,*(uint64 *)(*plVar1 + 400));
          }
          if (this.mTrans != null) {
            uVar4 = FUN_180da0f00(this.mTrans,0);
            this.mParent = uVar4;
            uVar4 = this.mParent;
            uVar4 = NGUITools.FindInParents(uVar4,DAT_181d66b80);
            this.mRoot = uVar4;
            lVar5 = NGUITools.FindInParents(this.mParent,DAT_181d66800);
            this.mGrid = lVar5;
            lVar5 = NGUITools.FindInParents(this.mParent,DAT_181d66d80);
            this.mTable = lVar5;
            uVar4 = **(uint64 **)(DAT_181d8a6d8 + 184);
            cVar3 = Object.op_Inequality(uVar4,0,0);
            if (cVar3) {
              if (this.mTrans == null) throw; // [null/range check failed]
              Transform.set_parent
                        (this.mTrans,**(uint64 **)(DAT_181d8a6d8 + 184),0);
            }
            if (this.mTrans != null) {
              puVar6 = (uint64 *)
                       Transform.get_localPosition(&local_18,this.mTrans,0);
              if (this.mTrans != null) {
                local_10 = 0;
                local_18 = *puVar6;
                Transform.set_localPosition(this.mTrans,&local_18,0);
                lVar5 = Component.GetComponent(this,DAT_181d6dbc0);
                cVar3 = Object.op_Inequality(lVar5,0,0);
                if (cVar3) {
                  if (lVar5 == null) throw; // [null/range check failed]
                  Behaviour.set_enabled(lVar5,0,0);
                }
                lVar5 = Component.GetComponent(this,DAT_181d6d4c0);
                cVar3 = Object.op_Inequality(lVar5,0,0);
                if (cVar3) {
                  if (lVar5 == null) throw; // [null/range check failed]
                  Behaviour.set_enabled(lVar5,0,0);
                }
                uVar4 = Component.get_gameObject(this,0);
                NGUITools.MarkParentAsChanged(uVar4,0);
                lVar5 = *plVar2;
                cVar3 = Object.op_Inequality(lVar5,0,0);
                if (cVar3) {
                  if (*plVar2 == 0) throw; // [null/range check failed]
                  UITable.set_repositionNow(*plVar2,1,0);
                }
                lVar5 = *plVar1;
                cVar3 = Object.op_Inequality(lVar5,0,0);
                if (cVar3) {
                  if (*plVar1 == 0) throw; // [null/range check failed]
                  UIGrid.set_repositionNow(*plVar1,1,0);
                }
                return;
              }
            }
          }
        }
    }

    // Token : 0x600010B
    // RVA   : 0x13D6700   Offset: 0x13D4F00   Length: 0x14A
    protected virtual void OnDragDropMove(Vector2 delta)
    {
        void UIDragDropItem.OnDragDropMove
                     (int64 this,uint64 delta,uint64 param_3,uint64 param_4)
        {
        float fVar1;
        uint64 uVar2;
        int64 lVar3;
        char cVar4;
        uint64 *puVar5;
        float local_38;
        float fStack_34;
        uint64 local_28;
        float local_20;
        uint8 local_18 [16];
        uVar2 = this.mParent;
        cVar4 = Object.op_Inequality(uVar2,0,0);
        if (!cVar4) {
          return;
        }
        lVar3 = this.mTrans;
        if (lVar3 != null) {
          puVar5 = (uint64 *)Transform.get_localPosition(&local_28,lVar3,0);
          uVar2 = *puVar5;
          fVar1 = *(float *)(puVar5 + 1);
          if (this.mTrans != null) {
            local_20 = 0.0;
            local_28 = delta;
            puVar5 = (uint64 *)
                     Transform.InverseTransformDirection
                               (local_18,this.mTrans,&local_28,0);
            fStack_34 = (float)((uint64)uVar2 >> 32);
            local_38 = (float)uVar2;
            local_20 = fVar1 + *(float *)(puVar5 + 1);
            local_28 = CONCAT44(fStack_34 + (float)((uint64)*puVar5 >> 32),(float)*puVar5 + local_38)
            ;
            Transform.set_localPosition(lVar3,&local_28,0);
            return;
          }
        }
    }

    // Token : 0x600010C
    // RVA   : 0x13D6850   Offset: 0x13D5050   Length: 0x521
    protected virtual void OnDragDropRelease(GameObject surface)
    {
        long lVar1;
        bool cVar3;
        uint uVar4;
        long lVar5;
        ulong uVar6;
        ulong uVar8;
        ulong uVar9;
        ulong local_18;
        uint local_10;
        if (*(char *)((int64)this + 29) == false) {
          lVar5 = FUN_180956bf0(this,DAT_181d70040);
          uVar6 = 0;
          uVar9 = uVar6;
          if (lVar5 == null) goto LAB_1813d6d5c;
          while( true ) {
            uVar4 = (uint32)uVar9;
            if ((int)*(uint32 *)(lVar5 + 24) <= (int)uVar4) break;
            if (*(uint32 *)(lVar5 + 24) <= uVar4) {
              uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar8,0);
            }
            lVar1 = lVar5[uVar4];
            if (lVar1 == null) goto LAB_1813d6d5c;
            *(uint64 *)(lVar1 + 24) = 0;
            uVar9 = (uint64)(uVar4 + 1);
          }
          lVar5 = this[9];
          cVar3 = Object.op_Inequality(lVar5,0,0);
          if (!cVar3) {
            lVar5 = this[7];
            cVar3 = Object.op_Inequality(lVar5,0,0);
            if (!cVar3) {
              lVar5 = this[8];
              cVar3 = Object.op_Inequality(lVar5,0,0);
              if (cVar3) {
                if (this[8] == 0) goto LAB_1813d6d5c;
                Behaviour.set_enabled(this[8],1,0);
              }
            }
            else {
              if (this[7] == 0) goto LAB_1813d6d5c;
              Collider.set_enabled(this[7],1,0);
            }
          }
          else {
            plVar2 = (int64 *)this[9];
            if (plVar2 == (int64 *)0) goto LAB_1813d6d5c;
            (**(code **)(*plVar2 + 0x188))(plVar2,1,*(uint64 *)(*plVar2 + 400));
          }
          cVar3 = Object.op_Implicit(surface,0);
          if (cVar3) {
            uVar6 = NGUITools.FindInParents(surface,DAT_181d66700);
          }
          cVar3 = Object.op_Inequality(uVar6,0,0);
          lVar5 = this[5];
          if (!cVar3) {
            if (lVar5 == null) goto LAB_1813d6d5c;
            Transform.set_parent(lVar5,this[6],0);
          }
          else {
            if (uVar6 == 0) goto LAB_1813d6d5c;
            uVar8 = *(uint64 *)(uVar6 + 24);
            cVar3 = Object.op_Inequality(uVar8,0,0);
            if (!cVar3) {
              uVar8 = Component.get_transform(uVar6,0);
            }
            else {
              uVar8 = *(uint64 *)(uVar6 + 24);
            }
            if (lVar5 == null) goto LAB_1813d6d5c;
            Transform.set_parent(lVar5,uVar8,0);
            if (this[5] == 0) goto LAB_1813d6d5c;
            puVar7 = (uint64 *)Transform.get_localPosition(&local_18,this[5],0);
            if (this[5] == 0) goto LAB_1813d6d5c;
            local_10 = 0;
            local_18 = *puVar7;
            Transform.set_localPosition(this[5],&local_18,0);
          }
          if (this[5] == 0) {
        LAB_1813d6d5c:
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          lVar5 = FUN_180da0f00(this[5],0);
          this[6] = lVar5;
          il2cpp_internal(this + 6,lVar5);
          lVar5 = this[6];
          lVar5 = NGUITools.FindInParents(lVar5,DAT_181d66800);
          this[11] = lVar5;
          il2cpp_internal(this + 11,lVar5);
          lVar5 = NGUITools.FindInParents(this[6],DAT_181d66d80);
          this[12] = lVar5;
          il2cpp_internal(this + 12,lVar5);
          lVar5 = this[14];
          cVar3 = Object.op_Inequality(lVar5,0,0);
          if (cVar3) {
            MonoBehaviour.Invoke(this,"EnableDragScrollView",0x3a83126f,0);
          }
          uVar8 = Component.get_gameObject(this,0);
          NGUITools.MarkParentAsChanged(uVar8,0);
          lVar5 = this[12];
          cVar3 = Object.op_Inequality(lVar5,0,0);
          if (cVar3) {
            if (this[12] == 0) goto LAB_1813d6d5c;
            UITable.set_repositionNow(this[12],1,0);
          }
          lVar5 = this[11];
          cVar3 = Object.op_Inequality(lVar5,0,0);
          if (cVar3) {
            if (this[11] == 0) goto LAB_1813d6d5c;
            UIGrid.set_repositionNow(this[11],1,0);
          }
        }
        (**(code **)(*this + 0x278))(this,surface,*(uint64 *)(*this + 0x280));
        if (*(char *)((int64)this + 29) != false) {
          (**(code **)(*this + 0x268))(this,*(uint64 *)(*this + 0x270));
        }
    }

    // Token : 0x600010D
    // RVA   : 0x13D5CD0   Offset: 0x13D44D0   Length: 0x5F
    protected virtual void DestroySelf()
    {
        ulong uVar1;
        uVar1 = Component.get_gameObject(this,0);
        NGUITools.Destroy(uVar1,0);
    }

    // Token : 0x600010E
    // RVA   : 0x13D6660   Offset: 0x13D4E60   Length: 0x93
    protected virtual void OnDragDropEnd(GameObject surface)
    {
        var pStatics = *(int64*)(DAT_181d8a658 + 184);
        if (*pStatics != 0) {
          FUN_181801c10(*pStatics,this,DAT_181d81bf8);
          this.mParent = 0;
          return;
        }
    }

    // Token : 0x600010F
    // RVA   : 0x13D5D30   Offset: 0x13D4530   Length: 0x7F
    protected void EnableDragScrollView()
    {
        ulong uVar1;
        bool cVar2;
        uVar1 = this.mDragScrollView;
        cVar2 = Object.op_Inequality(uVar1,0,0);
        if (cVar2) {
          if (this.mDragScrollView == null) {
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          Behaviour.set_enabled(this.mDragScrollView,1,0);
        }
    }

    // Token : 0x6000110
    // RVA   : 0x13D5FC0   Offset: 0x13D47C0   Length: 0x27
    protected void OnApplicationFocus(bool focus)
    {
        if ((!focus) && (*(char *)((int64)this + 121) != false)) {
          *(uint8 *)((int64)this + 121) = 0;
          (**(code **)(*this + 600))(this,0,*(uint64 *)(*this + 0x260));
        }
    }

    // Token : 0x6000111
    // RVA   : 0x13D8630   Offset: 0x13D6E30   Length: 0x12
    public void /*ctor*/()
    {
        this.interactable = 1;
        this.pressAndHoldDelay = 0x3f800000;
        FUN_18044ef50(this,0);
    }

    // Token : 0x6000112
    // RVA   : 0x13D85A0   Offset: 0x13D6DA0   Length: 0x8C
    private static void /*cctor*/()
    {
        ulong uVar2;
        uVar2 = il2cpp_internal(DAT_181d73830);
        FUN_180f58a90(uVar2,DAT_181d819f8);
        puVar1 = *(uint64 **)(DAT_181d8a658 + 184);
        *puVar1 = uVar2;
        il2cpp_internal(puVar1,uVar2);
        *(uint32 *)(*(int64 *)(DAT_181d8a658 + 184) + 8) = 0;
    }

}
