// ============================================================
// Type  : UIDragDropItem
// Token : 0x200003D
// ============================================================

public class UIDragDropItem
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4000126
    public Restriction restriction;

    // Token: 0x4000127
    public bool clickToDrag;

    // Token: 0x4000128
    public bool cloneOnDrag;

    // Token: 0x4000129
    public bool interactable;

    // Token: 0x400012A
    public float pressAndHoldDelay;

    // Token: 0x400012B
    protected Transform mTrans;

    // Token: 0x400012C
    protected Transform mParent;

    // Token: 0x400012D
    protected Collider mCollider;

    // Token: 0x400012E
    protected Collider2D mCollider2D;

    // Token: 0x400012F
    protected UIButton mButton;

    // Token: 0x4000130
    protected UIRoot mRoot;

    // Token: 0x4000131
    protected UIGrid mGrid;

    // Token: 0x4000132
    protected UITable mTable;

    // Token: 0x4000133
    protected float mDragStartTime;

    // Token: 0x4000134
    protected UIDragScrollView mDragScrollView;

    // Token: 0x4000135
    protected bool mPressed;

    // Token: 0x4000136
    protected bool mDragging;

    // Token: 0x4000137
    protected MouseOrTouch mTouch;

    // Token: 0x4000138
    public static List<UIDragDropItem> draggedItems;

    // Token: 0x4000139
    private static int mIgnoreClick;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000112
    // RVA   : 0x12B2300   Offset: 0x12B1700   Length: 0x20B
    public static bool IsDragged(GameObject go)
    {
        var pStatics = *(int64*)(DAT_181daf878 + 184);
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
        FUN_1817eb420(&local_38,*pStatics,DAT_181da9518);
        local_50 = local_38;
        uStack_4c = uStack_34;
        uStack_48 = uStack_30;
        uStack_44 = uStack_2c;
        local_40 = local_28;
        do {
          cVar1 = FUN_180c74f00(&local_50,DAT_181d93160);
          if (!cVar1) {
            aiStack_64[1] = 62;
            iVar4 = aiStack_64[3] + 1;
            aiStack_64[3] = iVar4;
            uVar3 = ZhSegment.Initialize(&local_50,DAT_181d930e0);
            goto LAB_1812b24c2;
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
        uVar3 = ZhSegment.Initialize(&local_50,DAT_181d930e0);
        LAB_1812b24c2:
        if ((iVar4 != 0) && (aiStack_64[iVar4] == 64)) {
          return (uint64)bVar5;
        }
        return uVar3 & 0xffffffffffffff00;
    }

    // Token : 0x6000113
    // RVA   : 0x12B2170   Offset: 0x12B1570   Length: 0xAE
    protected virtual void Awake()
    {
        ulong uVar1;
        long lVar2;
        uVar1 = Component.get_transform(this,0);
        this.mTrans = uVar1;
        lVar2 = Component.get_gameObject(this,0);
        if (lVar2 != null) {
          uVar1 = GameObject.GetComponent(lVar2,DAT_181dc80c8);
          this.mCollider = uVar1;
          lVar2 = Component.get_gameObject(this,0);
          if (lVar2 != null) {
            uVar1 = GameObject.GetComponent(lVar2,DAT_181dc8150);
            this.mCollider2D = uVar1;
            return;
          }
        }
    }

    // Token : 0x6000114
    // RVA   : 0x245810   Offset: 0x244C10   Length: 0x3
    protected virtual void OnEnable()
    {
    }

    // Token : 0x6000115
    // RVA   : 0x12B2930   Offset: 0x12B1D30   Length: 0x275
    protected virtual void OnDisable()
    {
        var pStatics = *(int64*)(DAT_181daf678 + 184);
        ulong uVar1;
        ulong uVar2;
        if (*(char *)((int64)this + 121) != false) {
          *(uint8 *)((int64)this + 121) = 0;
          (**(code **)(*this + 600))(this,0,*(uint64 *)(*this + 0x260));
          uVar1 = *(uint64 *)(pStatics + 0x118);
          uVar2 = new OnTooltipCB(this,DAT_181dc5c50,0);
          plVar3 = (int64 *)Delegate.Remove(uVar1,uVar2,0);
          plVar6 = (int64 *)0;
          plVar4 = plVar6;
          if (plVar3 != (int64 *)0) {
            if (*plVar3 == DAT_181d8d238) {
              plVar4 = plVar3;
            }
            if (plVar4 == (int64 *)0) {
                          // WARNING: Subroutine does not return
              FUN_1800d6070(plVar3,DAT_181d8d238);
            }
          }
          *(int64 **)(pStatics + 0x118) = plVar4;
          uVar1 = *(uint64 *)(pStatics + 0x100);
          uVar2 = new OnTooltipCB(this,DAT_181dc5bc8,0);
          plVar3 = (int64 *)Delegate.Remove(uVar1,uVar2,0);
          plVar4 = plVar6;
          if (plVar3 != (int64 *)0) {
            if (*plVar3 == DAT_181d8d838) {
              plVar4 = plVar3;
            }
            if (plVar4 == (int64 *)0) {
                          // WARNING: Subroutine does not return
              FUN_1800d6070(plVar3,DAT_181d8d838);
            }
          }
          *(int64 **)(pStatics + 0x100) = plVar4;
          uVar1 = *(uint64 *)(pStatics + 0x180);
          uVar2 = new OnTooltipCB(this,*(uint64 *)(*this + 0x220),0);
          plVar4 = (int64 *)Delegate.Remove(uVar1,uVar2,0);
          if (plVar4 != (int64 *)0) {
            if (*plVar4 == DAT_181d8d638) {
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

    // Token : 0x6000116
    // RVA   : 0x12B49A0   Offset: 0x12B3DA0   Length: 0x72
    protected virtual void Start()
    {
        ulong uVar1;
        uVar1 = Component.GetComponent(this,DAT_181d96760);
        this.mButton = uVar1;
        uVar1 = Component.GetComponent(this,DAT_181d968e0);
        this.mDragScrollView = uVar1;
    }

    // Token : 0x6000117
    // RVA   : 0x12B4230   Offset: 0x12B3630   Length: 0x187
    protected virtual void OnPress(bool isPressed)
    {
        var pStatics = *(int64*)(DAT_181daf678 + 184);
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

    // Token : 0x6000118
    // RVA   : 0x12B2540   Offset: 0x12B1940   Length: 0x3E9
    protected virtual void OnClick()
    {
        var pStatics_f678 = *(int64*)(DAT_181daf678 + 184);
        var pStatics_f878 = *(int64*)(DAT_181daf878 + 184);
        int iVar1;
        ulong uVar2;
        bool cVar3;
        int iVar4;
        ulong uVar6;
        iVar1 = *(int *)(pStatics_f878 + 8);
        iVar4 = Time.get_frameCount(0);
        if (((iVar1 != iVar4) && (*(char *)((int64)this + 28) != false)) &&
           (*(char *)((int64)this + 121) == false)) {
          if (*(int *)(pStatics_f678 + 212) == -1) {
            if (*pStatics_f878 == 0) {
        LAB_1812b2903:
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            if (*(int *)(*pStatics_f878 + 24) == 0) {
              this[16] = *(int64 *)(pStatics_f678 + 224);
              il2cpp_internal();
              plVar5 = (int64 *)
                       (**(code **)(*this + 0x1f8))(this,*(uint64 *)(*this + 0x200));
              if (*(char *)((int64)this + 28) != false) {
                cVar3 = Object.op_Inequality(plVar5,0,0);
                if (cVar3) {
                  uVar2 = *(uint64 *)(pStatics_f678 + 0x180);
                  uVar6 = il2cpp_internal(DAT_181d8d638);
                  if (plVar5 == (int64 *)0) goto LAB_1812b2903;
                  OnTooltipCB.ctor(uVar6,plVar5,*(uint64 *)(*plVar5 + 0x220),0);
                  plVar7 = (int64 *)Delegate.Combine(uVar2,uVar6,0);
                  plVar10 = (int64 *)0;
                  plVar9 = plVar10;
                  if (plVar7 != (int64 *)0) {
                    if (*plVar7 == DAT_181d8d638) {
                      plVar9 = plVar7;
                    }
                    if (plVar9 == (int64 *)0) {
                          // WARNING: Subroutine does not return
                      FUN_1800d6070(plVar7,DAT_181d8d638);
                    }
                  }
                  *(int64 **)(pStatics_f678 + 0x180) = plVar9;
                  uVar2 = *(uint64 *)(pStatics_f678 + 0x118);
                  uVar6 = new OnTooltipCB(plVar5,DAT_181dc5c50,0);
                  plVar7 = (int64 *)Delegate.Combine(uVar2,uVar6,0);
                  plVar9 = plVar10;
                  if (plVar7 != (int64 *)0) {
                    if (*plVar7 == DAT_181d8d238) {
                      plVar9 = plVar7;
                    }
                    if (plVar9 == (int64 *)0) {
                          // WARNING: Subroutine does not return
                      FUN_1800d6070(plVar7,DAT_181d8d238);
                    }
                  }
                  *(int64 **)(pStatics_f678 + 0x118) = plVar9;
                  uVar2 = *(uint64 *)(pStatics_f678 + 0x100);
                  uVar6 = new OnTooltipCB(plVar5,DAT_181dc5bc8,0);
                  plVar5 = (int64 *)Delegate.Combine(uVar2,uVar6,0);
                  if (plVar5 != (int64 *)0) {
                    if (*plVar5 == DAT_181d8d838) {
                      plVar10 = plVar5;
                    }
                    if (plVar10 == (int64 *)0) {
                          // WARNING: Subroutine does not return
                      FUN_1800d6070(plVar5);
                    }
                  }
                  puVar8 = (uint64 *)(pStatics_f678 + 0x100);
                  *puVar8 = plVar10;
                  il2cpp_internal(puVar8,plVar10);
                }
              }
            }
          }
        }
    }

    // Token : 0x6000119
    // RVA   : 0x12B3F30   Offset: 0x12B3330   Length: 0x2FD
    protected void OnGlobalPress(GameObject go, bool state)
    {
        var pStatics = *(int64*)(DAT_181daf678 + 184);
        ulong uVar1;
        uint uVar2;
        ulong uVar3;
        if (state) {
          if (*(int *)(pStatics + 212) != -1) {
            uVar2 = Time.get_frameCount(0);
            *(uint32 *)(*(int64 *)(DAT_181daf878 + 184) + 8) = uVar2;
            if (*(char *)((int64)this + 121) != false) {
              *(uint8 *)((int64)this + 121) = 0;
              (**(code **)(*this + 600))(this,0,*(uint64 *)(*this + 0x260));
            }
            uVar1 = *(uint64 *)(pStatics + 0x118);
            uVar3 = new OnTooltipCB(this,DAT_181dc5c50,0);
            plVar4 = (int64 *)Delegate.Remove(uVar1,uVar3,0);
            plVar7 = (int64 *)0;
            plVar5 = plVar7;
            if (plVar4 != (int64 *)0) {
              if (*plVar4 == DAT_181d8d238) {
                plVar5 = plVar4;
              }
              if (plVar5 == (int64 *)0) {
                          // WARNING: Subroutine does not return
                FUN_1800d6070(plVar4,DAT_181d8d238);
              }
            }
            *(int64 **)(pStatics + 0x118) = plVar5;
            uVar1 = *(uint64 *)(pStatics + 0x100);
            uVar3 = new OnTooltipCB(this,DAT_181dc5bc8,0);
            plVar4 = (int64 *)Delegate.Remove(uVar1,uVar3,0);
            plVar5 = plVar7;
            if (plVar4 != (int64 *)0) {
              if (*plVar4 == DAT_181d8d838) {
                plVar5 = plVar4;
              }
              if (plVar5 == (int64 *)0) {
                          // WARNING: Subroutine does not return
                FUN_1800d6070(plVar4,DAT_181d8d838);
              }
            }
            *(int64 **)(pStatics + 0x100) = plVar5;
            uVar1 = *(uint64 *)(pStatics + 0x180);
            uVar3 = new OnTooltipCB(this,*(uint64 *)(*this + 0x220),0);
            plVar5 = (int64 *)Delegate.Remove(uVar1,uVar3,0);
            if (plVar5 != (int64 *)0) {
              if (*plVar5 == DAT_181d8d638) {
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

    // Token : 0x600011A
    // RVA   : 0x12B3C30   Offset: 0x12B3030   Length: 0x2F4
    protected void OnGlobalClick(GameObject go)
    {
        var pStatics = *(int64*)(DAT_181daf678 + 184);
        ulong uVar1;
        uint uVar2;
        ulong uVar3;
        uVar2 = Time.get_frameCount(0);
        *(uint32 *)(*(int64 *)(DAT_181daf878 + 184) + 8) = uVar2;
        if (*(int *)(pStatics + 212) == -1) {
          if (*(char *)((int64)this + 121) == false) goto LAB_1812b3d4a;
        }
        else {
          if (*(char *)((int64)this + 121) == false) goto LAB_1812b3d4a;
          go = 0;
        }
        *(uint8 *)((int64)this + 121) = 0;
        (**(code **)(*this + 600))(this,go,*(uint64 *)(*this + 0x260));
        LAB_1812b3d4a:
        uVar1 = *(uint64 *)(pStatics + 0x118);
        uVar3 = new OnTooltipCB(this,DAT_181dc5c50,0);
        plVar4 = (int64 *)Delegate.Remove(uVar1,uVar3,0);
        plVar7 = (int64 *)0;
        plVar5 = plVar7;
        if (plVar4 != (int64 *)0) {
          if (*plVar4 == DAT_181d8d238) {
            plVar5 = plVar4;
          }
          if (plVar5 == (int64 *)0) {
                          // WARNING: Subroutine does not return
            FUN_1800d6070(plVar4,DAT_181d8d238);
          }
        }
        *(int64 **)(pStatics + 0x118) = plVar5;
        uVar1 = *(uint64 *)(pStatics + 0x100);
        uVar3 = new OnTooltipCB(this,DAT_181dc5bc8,0);
        plVar4 = (int64 *)Delegate.Remove(uVar1,uVar3,0);
        plVar5 = plVar7;
        if (plVar4 != (int64 *)0) {
          if (*plVar4 == DAT_181d8d838) {
            plVar5 = plVar4;
          }
          if (plVar5 == (int64 *)0) {
                          // WARNING: Subroutine does not return
            FUN_1800d6070(plVar4,DAT_181d8d838);
          }
        }
        *(int64 **)(pStatics + 0x100) = plVar5;
        uVar1 = *(uint64 *)(pStatics + 0x180);
        uVar3 = new OnTooltipCB(this,*(uint64 *)(*this + 0x220),0);
        plVar5 = (int64 *)Delegate.Remove(uVar1,uVar3,0);
        if (plVar5 != (int64 *)0) {
          if (*plVar5 == DAT_181d8d638) {
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

    // Token : 0x600011B
    // RVA   : 0x12B4A40   Offset: 0x12B3E40   Length: 0x55
    protected virtual void Update()
    {
        float fVar1;
        float fVar2;
        if ((((int)this[3] == 3) && ((char)this[15] != false)) &&
           (*(char *)((int64)this + 121) == false)) {
          fVar1 = *(float *)(this + 13);
          fVar2 = (float)RealTime.get_time(0);
          if (fVar1 < fVar2) {
                          // WARNING: Could not recover jumptable at 0x0001812b4a88. Too many branches
                          // WARNING: Treating indirect jump as call
            (**(code **)(*this + 0x1f8))(this,*(uint64 *)(*this + 0x200));
            return;
          }
        }
    }

    // Token : 0x600011C
    // RVA   : 0x12B39C0   Offset: 0x12B2DC0   Length: 0x11A
    protected virtual void OnDragStart()
    {
        int iVar1;
        long lVar2;
        bool cVar3;
        if ((*(char *)((int64)this + 30) != false) &&
           (cVar3 = Behaviour.get_enabled(this,0), cVar3)) {
          lVar2 = this[16];
          if (lVar2 == *(int64 *)(*(int64 *)(DAT_181daf678 + 184) + 224)) {
            iVar1 = (int)this[3];
            if (iVar1 != 0) {
              if (iVar1 == 1) {
                lVar2 = this[16];
                if (lVar2 == null) {
        LAB_1812b3ad5:
                          // WARNING: Subroutine does not return
                  FUN_1800d6620();
                }
                if (ABS(*(float *)(lVar2 + 44)) < ABS(*(float *)(lVar2 + 48))) {
                  return;
                }
              }
              else if (iVar1 == 2) {
                lVar2 = this[16];
                if (lVar2 == null) goto LAB_1812b3ad5;
                if (ABS(*(float *)(lVar2 + 48)) < ABS(*(float *)(lVar2 + 44))) {
                  return;
                }
              }
              else if (iVar1 == 3) {
                return;
              }
            }
                          // WARNING: Could not recover jumptable at 0x0001812b3a6e. Too many branches
                          // WARNING: Treating indirect jump as call
            (**(code **)(*this + 0x1f8))(this,*(uint64 *)(*this + 0x200));
            return;
          }
        }
    }

    // Token : 0x600011D
    // RVA   : 0x12B43C0   Offset: 0x12B37C0   Length: 0x5DA
    public virtual UIDragDropItem StartDragging()
    {
        var pStatics = *(int64*)(DAT_181daf678 + 184);
        bool cVar2;
        ulong uVar3;
        long lVar4;
        ulong uVar5;
        long lVar6;
        long lVar7;
        byte[] local_res8 = new byte[8];
        byte[] local_res18 = new byte[8];
        ulong local_38;
        uint local_30;
        uint local_28;
        uint uStack_24;
        uint uStack_20;
        uint32 uStack_1c;
        if (*(char *)((int64)this + 30) != false) {
          uVar3 = Component.get_transform(this,0);
          cVar2 = Object.op_Implicit(uVar3,0);
          if (cVar2) {
            lVar4 = Component.get_transform(this,0);
            if (lVar4 != null) {
              uVar3 = FUN_180da9a20(lVar4,0);
              cVar2 = Object.op_Implicit(uVar3,0);
              if (!cVar2) {
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
              lVar4 = Component.get_transform(this,0);
              if ((lVar4 != null) && (lVar4 = FUN_180da9a20(lVar4,0)) != null) {
                uVar3 = Component.get_gameObject(lVar4,0);
                uVar5 = Component.get_gameObject(this,0);
                lVar4 = NGUITools.AddChild(uVar3,uVar5,0);
                if (lVar4 != null) {
                  lVar6 = GameObject.get_transform(lVar4,0);
                  lVar7 = Component.get_transform(this,0);
                  if ((lVar7 != null) &&
                     (puVar8 = (uint64 *)Transform.get_localPosition(&local_28,lVar7,0), lVar6 != null))
                  {
                    local_38 = *puVar8;
                    local_30 = *(uint32 *)(puVar8 + 1);
                    Transform.set_localPosition(lVar6,&local_38,0);
                    lVar6 = GameObject.get_transform(lVar4,0);
                    lVar7 = Component.get_transform(this,0);
                    if ((lVar7 != null) &&
                       (puVar9 = (uint32 *)Transform.get_localRotation(&local_28,lVar7,0), lVar6 != null
                       )) {
                      local_28 = *puVar9;
                      uStack_24 = puVar9[1];
                      uStack_20 = puVar9[2];
                      uStack_1c = puVar9[3];
                      Transform.set_localRotation(lVar6,&local_28,0);
                      lVar6 = GameObject.get_transform(lVar4,0);
                      lVar7 = Component.get_transform(this,0);
                      if ((lVar7 != null) &&
                         (puVar8 = (uint64 *)Transform.get_localScale(&local_28,lVar7,0), lVar6 != null)
                         ) {
                        local_38 = *puVar8;
                        local_30 = *(uint32 *)(puVar8 + 1);
                        Transform.set_localScale(lVar6,&local_38,0);
                        lVar6 = GameObject.GetComponent(lVar4,DAT_181d746e0);
                        cVar2 = Object.op_Inequality(lVar6,0,0);
                        if (cVar2) {
                          lVar7 = Component.GetComponent(this,DAT_181d967e0);
                          if ((lVar7 == null) ||
                             (puVar9 = (uint32 *)UIButtonColor.get_defaultColor(&local_28,lVar7,0),
                             lVar6 == null)) goto LAB_1812b4995;
                          local_28 = *puVar9;
                          uStack_24 = puVar9[1];
                          uStack_20 = puVar9[2];
                          uStack_1c = puVar9[3];
                          UIButtonColor.set_defaultColor(lVar6,&local_28,0);
                        }
                        plVar1 = this + 16;
                        if (*plVar1 != 0) {
                          uVar3 = *(uint64 *)(*plVar1 + 80);
                          uVar5 = Component.get_gameObject(this,0);
                          cVar2 = Object.op_Equality(uVar3,uVar5,0);
                          if (cVar2) {
                            if (*plVar1 == 0) goto LAB_1812b4995;
                            plVar10 = (int64 *)(*plVar1 + 72);
                            *plVar10 = lVar4;
                            il2cpp_internal(plVar10,lVar4);
                            if (*plVar1 == 0) goto LAB_1812b4995;
                            plVar10 = (int64 *)(*plVar1 + 80);
                            *plVar10 = lVar4;
                            il2cpp_internal(plVar10,lVar4);
                            if (*plVar1 == 0) goto LAB_1812b4995;
                            plVar10 = (int64 *)(*plVar1 + 88);
                            *plVar10 = lVar4;
                            il2cpp_internal(plVar10,lVar4);
                            if (*plVar1 == 0) goto LAB_1812b4995;
                            plVar10 = (int64 *)(*plVar1 + 64);
                            *plVar10 = lVar4;
                            il2cpp_internal(plVar10,lVar4);
                          }
                        }
                        plVar10 = (int64 *)GameObject.GetComponent(lVar4,DAT_181d74768);
                        if (plVar10 != (int64 *)0) {
                          plVar10[16] = *plVar1;
                          il2cpp_internal();
                          *(uint16 *)(plVar10 + 15) = 0x101;
                          (**(code **)(*plVar10 + 0x1a8))(plVar10,*(uint64 *)(*plVar10 + 0x1b0));
                          uVar3 = Component.get_gameObject(this,0);
                          (**(code **)(*plVar10 + 0x208))(plVar10,uVar3,*(uint64 *)(*plVar10 + 0x210))
                          ;
                          (**(code **)(*plVar10 + 0x238))(plVar10,*(uint64 *)(*plVar10 + 0x240));
                          if (*(int64 *)(pStatics + 224) == 0) {
                            lVar4 = *plVar1;
                            plVar11 = (int64 *)(pStatics + 224);
                            *plVar11 = lVar4;
                            il2cpp_internal(plVar11,lVar4);
                          }
                          *plVar1 = 0;
                          il2cpp_internal(plVar1,0);
                          uVar3 = Component.get_gameObject(this,0);
                          local_res8[0] = 0;
                          uVar5 = il2cpp_value_box(DAT_181db2ac8,local_res8);
                          UICamera.Notify(uVar3,"OnPress",uVar5,0);
                          uVar3 = Component.get_gameObject(this,0);
                          local_res18[0] = 0;
                          uVar5 = il2cpp_value_box(DAT_181db2ac8,local_res18);
                          UICamera.Notify(uVar3,"OnHover",uVar5,0);
                          return plVar10;
                        }
                      }
                    }
                  }
                }
              }
            }
        LAB_1812b4995:
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
        }
        return (int64 *)0;
    }

    // Token : 0x600011E
    // RVA   : 0x245810   Offset: 0x244C10   Length: 0x3
    protected virtual void OnClone(GameObject original)
    {
    }

    // Token : 0x600011F
    // RVA   : 0x12B3AE0   Offset: 0x12B2EE0   Length: 0x146
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
          if (lVar2 == *(int64 *)(*(int64 *)(DAT_181daf678 + 184) + 224)) {
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

    // Token : 0x6000120
    // RVA   : 0x12B3840   Offset: 0x12B2C40   Length: 0x174
    protected virtual void OnDragEnd()
    {
        var pStatics = *(int64*)(DAT_181daf678 + 184);
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

    // Token : 0x6000121
    // RVA   : 0x12B4A20   Offset: 0x12B3E20   Length: 0x1C
    public void StopDragging(GameObject go)
    {
        void FUN_1812b4a20(int64 *this,uint64 go)
        {
        if (*(char *)((int64)this + 121) != false) {
          *(uint8 *)((int64)this + 121) = 0;
                          // WARNING: Could not recover jumptable at 0x0001812b4a34. Too many branches
                          // WARNING: Treating indirect jump as call
          (**(code **)(*this + 600))(this,go,*(uint64 *)(*this + 0x260));
          return;
        }
    }

    // Token : 0x6000122
    // RVA   : 0x12B32D0   Offset: 0x12B26D0   Length: 0x566
    protected virtual void OnDragDropStart()
    {
        var pStatics = *(int64*)(DAT_181daf878 + 184);
        bool cVar3;
        ulong uVar4;
        long lVar5;
        ulong local_18;
        uint local_10;
        if (*pStatics != 0) {
          cVar3 = FUN_18181e400(*pStatics,this,DAT_181da9498);
          if (!cVar3) {
            if (*pStatics == 0) throw; // [null/range check failed]
            FUN_18181e0a0(*pStatics,this,DAT_181da9418);
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
            uVar4 = FUN_180da9a20(this.mTrans,0);
            this.mParent = uVar4;
            uVar4 = this.mParent;
            uVar4 = NGUITools.FindInParents(uVar4,DAT_181d8f8a0);
            this.mRoot = uVar4;
            lVar5 = NGUITools.FindInParents(this.mParent,DAT_181d8f520);
            this.mGrid = lVar5;
            lVar5 = NGUITools.FindInParents(this.mParent,DAT_181d8faa0);
            this.mTable = lVar5;
            uVar4 = **(uint64 **)(DAT_181daf8f8 + 184);
            cVar3 = Object.op_Inequality(uVar4,0,0);
            if (cVar3) {
              if (this.mTrans == null) throw; // [null/range check failed]
              Transform.set_parent
                        (this.mTrans,**(uint64 **)(DAT_181daf8f8 + 184),0);
            }
            if (this.mTrans != null) {
              puVar6 = (uint64 *)
                       Transform.get_localPosition(&local_18,this.mTrans,0);
              if (this.mTrans != null) {
                local_10 = 0;
                local_18 = *puVar6;
                Transform.set_localPosition(this.mTrans,&local_18,0);
                lVar5 = Component.GetComponent(this,DAT_181d96460);
                cVar3 = Object.op_Inequality(lVar5,0,0);
                if (cVar3) {
                  if (lVar5 == null) throw; // [null/range check failed]
                  Behaviour.set_enabled(lVar5,0,0);
                }
                lVar5 = Component.GetComponent(this,DAT_181d95d60);
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
                  lVar5 = *plVar1;
                  if (lVar5 == null) throw; // [null/range check failed]
                  *(uint8 *)(lVar5 + 73) = 1;
                  Behaviour.set_enabled(lVar5,1,0);
                }
                return;
              }
            }
          }
        }
    }

    // Token : 0x6000123
    // RVA   : 0x12B2C50   Offset: 0x12B2050   Length: 0x14A
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

    // Token : 0x6000124
    // RVA   : 0x12B2DA0   Offset: 0x12B21A0   Length: 0x525
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
          lVar5 = FUN_1809674e0(this,DAT_181d98960);
          uVar6 = 0;
          uVar9 = uVar6;
          if (lVar5 == null) goto LAB_1812b32b0;
          while( true ) {
            uVar4 = (uint32)uVar9;
            if ((int)*(uint32 *)(lVar5 + 24) <= (int)uVar4) break;
            if (*(uint32 *)(lVar5 + 24) <= uVar4) {
              uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar8,0);
            }
            lVar1 = lVar5[uVar4];
            if (lVar1 == null) goto LAB_1812b32b0;
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
                if (this[8] == 0) goto LAB_1812b32b0;
                Behaviour.set_enabled(this[8],1,0);
              }
            }
            else {
              if (this[7] == 0) goto LAB_1812b32b0;
              Collider.set_enabled(this[7],1,0);
            }
          }
          else {
            plVar2 = (int64 *)this[9];
            if (plVar2 == (int64 *)0) goto LAB_1812b32b0;
            (**(code **)(*plVar2 + 0x188))(plVar2,1,*(uint64 *)(*plVar2 + 400));
          }
          cVar3 = Object.op_Implicit(surface,0);
          if (cVar3) {
            uVar6 = NGUITools.FindInParents(surface,DAT_181d8f420);
          }
          cVar3 = Object.op_Inequality(uVar6,0,0);
          lVar5 = this[5];
          if (!cVar3) {
            if (lVar5 == null) goto LAB_1812b32b0;
            Transform.set_parent(lVar5,this[6],0);
          }
          else {
            if (uVar6 == 0) goto LAB_1812b32b0;
            uVar8 = *(uint64 *)(uVar6 + 24);
            cVar3 = Object.op_Inequality(uVar8,0,0);
            if (!cVar3) {
              uVar8 = Component.get_transform(uVar6,0);
            }
            else {
              uVar8 = *(uint64 *)(uVar6 + 24);
            }
            if (lVar5 == null) goto LAB_1812b32b0;
            Transform.set_parent(lVar5,uVar8,0);
            if (this[5] == 0) goto LAB_1812b32b0;
            puVar7 = (uint64 *)Transform.get_localPosition(&local_18,this[5],0);
            if (this[5] == 0) goto LAB_1812b32b0;
            local_10 = 0;
            local_18 = *puVar7;
            Transform.set_localPosition(this[5],&local_18,0);
          }
          if (this[5] == 0) {
        LAB_1812b32b0:
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          lVar5 = FUN_180da9a20(this[5],0);
          this[6] = lVar5;
          il2cpp_internal(this + 6,lVar5);
          lVar5 = this[6];
          lVar5 = NGUITools.FindInParents(lVar5,DAT_181d8f520);
          this[11] = lVar5;
          il2cpp_internal(this + 11,lVar5);
          lVar5 = NGUITools.FindInParents(this[6],DAT_181d8faa0);
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
            if (this[12] == 0) goto LAB_1812b32b0;
            UITable.set_repositionNow(this[12],1,0);
          }
          lVar5 = this[11];
          cVar3 = Object.op_Inequality(lVar5,0,0);
          if (cVar3) {
            lVar5 = this[11];
            if (lVar5 == null) goto LAB_1812b32b0;
            *(uint8 *)(lVar5 + 73) = 1;
            Behaviour.set_enabled(lVar5,1,0);
          }
        }
        (**(code **)(*this + 0x278))(this,surface,*(uint64 *)(*this + 0x280));
        if (*(char *)((int64)this + 29) != false) {
          (**(code **)(*this + 0x268))(this,*(uint64 *)(*this + 0x270));
        }
    }

    // Token : 0x6000125
    // RVA   : 0x12B2220   Offset: 0x12B1620   Length: 0x5F
    protected virtual void DestroySelf()
    {
        ulong uVar1;
        uVar1 = Component.get_gameObject(this,0);
        NGUITools.Destroy(uVar1,0);
    }

    // Token : 0x6000126
    // RVA   : 0x12B2BB0   Offset: 0x12B1FB0   Length: 0x93
    protected virtual void OnDragDropEnd(GameObject surface)
    {
        var pStatics = *(int64*)(DAT_181daf878 + 184);
        if (*pStatics != 0) {
          FUN_1817eee00(*pStatics,this,DAT_181da9598);
          this.mParent = 0;
          return;
        }
    }

    // Token : 0x6000127
    // RVA   : 0x12B2280   Offset: 0x12B1680   Length: 0x7F
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

    // Token : 0x6000128
    // RVA   : 0x12B2510   Offset: 0x12B1910   Length: 0x27
    protected void OnApplicationFocus(bool focus)
    {
        if ((!focus) && (*(char *)((int64)this + 121) != false)) {
          *(uint8 *)((int64)this + 121) = 0;
          (**(code **)(*this + 600))(this,0,*(uint64 *)(*this + 0x260));
        }
    }

    // Token : 0x6000129
    // RVA   : 0x12B4B30   Offset: 0x12B3F30   Length: 0x12
    public void /*ctor*/()
    {
        this.interactable = 1;
        this.pressAndHoldDelay = 0x3f800000;
        FUN_18044ef50(this,0);
    }

    // Token : 0x600012A
    // RVA   : 0x12B4AA0   Offset: 0x12B3EA0   Length: 0x8C
    private static void /*cctor*/()
    {
        ulong uVar2;
        uVar2 = il2cpp_internal(DAT_181d98550);
        FUN_18132faf0(uVar2,DAT_181da9398);
        puVar1 = *(uint64 **)(DAT_181daf878 + 184);
        *puVar1 = uVar2;
        il2cpp_internal(puVar1,uVar2);
        *(uint32 *)(*(int64 *)(DAT_181daf878 + 184) + 8) = 0;
    }

}
