// ============================================================
// Type  : UIWrapContent
// Token : 0x2000073
// ============================================================

public class UIWrapContent
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x40002B7
    public int itemSize;

    // Token: 0x40002B8
    public bool cullContent;

    // Token: 0x40002B9
    public int minIndex;

    // Token: 0x40002BA
    public int maxIndex;

    // Token: 0x40002BB
    public bool hideInactive;

    // Token: 0x40002BC
    public OnInitializeItem onInitializeItem;

    // Token: 0x40002BD
    protected Transform mTrans;

    // Token: 0x40002BE
    protected UIPanel mPanel;

    // Token: 0x40002BF
    protected UIScrollView mScroll;

    // Token: 0x40002C0
    protected bool mHorizontal;

    // Token: 0x40002C1
    protected bool mFirstTime;

    // Token: 0x40002C2
    protected List<Transform> mChildren;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000299
    // RVA   : 0x9DB430   Offset: 0x9D9C30   Length: 0x10E
    protected virtual void Start()
    {
        bool cVar1;
        long lVar2;
        ulong uVar3;
        (**(code **)(*this + 0x198))(this,*(uint64 *)(*this + 0x1a0));
        (**(code **)(*this + 0x1c8))(this,*(uint64 *)(*this + 0x1d0));
        lVar2 = this[9];
        cVar1 = Object.op_Inequality(lVar2,0,0);
        if (cVar1) {
          if (this[9] != 0) {
            lVar2 = Component.GetComponent(this[9],DAT_181d6e2c0);
            uVar3 = new OnTooltipCB(this,*(uint64 *)(*this + 400),0);
            if (lVar2 != null) {
              *(uint64 *)(lVar2 + 0x110) = uVar3;
              goto LAB_1809db525;
            }
          }
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
        LAB_1809db525:
        *(uint8 *)((int64)this + 81) = 0;
    }

    // Token : 0x600029A
    // RVA   : 0x372E70   Offset: 0x371670   Length: 0x11
    protected virtual void OnMove(UIPanel panel)
    {
        void FUN_180372e70(int64 *this)
        {
                          // WARNING: Could not recover jumptable at 0x000180372e7a. Too many branches
                          // WARNING: Treating indirect jump as call
        (**(code **)(*this + 0x1c8))(this,*(uint64 *)(*this + 0x1d0));
    }

    // Token : 0x600029B
    // RVA   : 0x9DB270   Offset: 0x9D9A70   Length: 0x1BB
    public virtual void SortBasedOnScrollMovement()
    {
        bool cVar1;
        int iVar2;
        long lVar3;
        ulong uVar4;
        int iVar5;
        ulong uVar6;
        cVar1 = UIWrapContent.CacheScrollView(this,0);
        if (!cVar1) {
          return;
        }
        if (this[11] != 0) {
          FUN_180f56130(this[11],DAT_181d803f8);
          lVar3 = this[7];
          iVar5 = 0;
          if (lVar3 != null) {
            while (iVar2 = Transform.get_childCount(lVar3,0), iVar5 < iVar2) {
              if (this[7] == 0) throw; // [null/range check failed]
              lVar3 = Transform.GetChild(this[7],iVar5,0);
              if ((char)this[5] == false) {
        LAB_1809db37b:
                if (this[11] == 0) throw; // [null/range check failed]
                FUN_181827900();
              }
              else {
                if ((lVar3 == null) || (lVar3 = Component.get_gameObject(lVar3)) == null)
                throw; // [null/range check failed]
                cVar1 = GameObject.get_activeInHierarchy(lVar3);
                if (cVar1) goto LAB_1809db37b;
              }
              lVar3 = this[7];
              iVar5 = iVar5 + 1;
              if (lVar3 == null) throw; // [null/range check failed]
            }
            lVar3 = this[11];
            if ((char)this[10] == false) {
              uVar4 = il2cpp_internal(DAT_181d59ac8);
              uVar6 = DAT_181d9caf8;
            }
            else {
              uVar4 = il2cpp_internal(DAT_181d59ac8);
              uVar6 = DAT_181d9ca70;
            }
            OnTooltipCB.ctor(uVar4,0,uVar6,DAT_181d86498);
            if (lVar3 != null) {
              List_1.Sort(lVar3,uVar4,DAT_181d805f8);
              (**(code **)(*this + 0x1b8))(this,*(uint64 *)(*this + 0x1c0));
              return;
            }
          }
        }
    }

    // Token : 0x600029C
    // RVA   : 0x9DB0C0   Offset: 0x9D98C0   Length: 0x1A0
    public virtual void SortAlphabetically()
    {
        bool cVar1;
        int iVar2;
        long lVar3;
        ulong uVar4;
        int iVar5;
        cVar1 = UIWrapContent.CacheScrollView(this,0);
        if (!cVar1) {
          return;
        }
        if (this[11] != 0) {
          FUN_180f56130(this[11],DAT_181d803f8);
          lVar3 = this[7];
          iVar5 = 0;
          if (lVar3 != null) {
            while (iVar2 = Transform.get_childCount(lVar3,0), iVar5 < iVar2) {
              if (this[7] == 0) throw; // [null/range check failed]
              lVar3 = Transform.GetChild(this[7],iVar5,0);
              if ((char)this[5] == false) {
        LAB_1809db1c8:
                if (this[11] == 0) throw; // [null/range check failed]
                FUN_181827900();
              }
              else {
                if ((lVar3 == null) || (lVar3 = Component.get_gameObject(lVar3)) == null)
                throw; // [null/range check failed]
                cVar1 = GameObject.get_activeInHierarchy(lVar3);
                if (cVar1) goto LAB_1809db1c8;
              }
              lVar3 = this[7];
              iVar5 = iVar5 + 1;
              if (lVar3 == null) throw; // [null/range check failed]
            }
            lVar3 = this[11];
            uVar4 = new OnTooltipCB(0,DAT_181d9c9e8,DAT_181d86498);
            if (lVar3 != null) {
              List_1.Sort(lVar3,uVar4,DAT_181d805f8);
              (**(code **)(*this + 0x1b8))(this,*(uint64 *)(*this + 0x1c0));
              return;
            }
          }
        }
    }

    // Token : 0x600029D
    // RVA   : 0x9DADF0   Offset: 0x9D95F0   Length: 0x15F
    protected bool CacheScrollView()
    {
        uint uVar1;
        ulong uVar2;
        ulong uVar3;
        uVar2 = Component.get_transform(this,0);
        this.mTrans = uVar2;
        uVar2 = Component.get_gameObject(this,0);
        uVar2 = NGUITools.FindInParents(uVar2,DAT_181d66900);
        this.mPanel = uVar2;
        if (this.mPanel != null) {
          uVar2 = Component.GetComponent(this.mPanel,DAT_181d6e540);
          this.mScroll = uVar2;
          uVar2 = this.mScroll;
          uVar3 = Object.op_Equality(uVar2,0,0);
          if ((char)!uVar3) {
            if (this.mScroll == null) throw; // [null/range check failed]
            uVar1 = this.mScroll.movement;
            uVar3 = (uint64)uVar1;
            if (uVar1 == 0) {
              this.mHorizontal = 1;
              return true;
            }
            if (uVar1 == 1) {
              this.mHorizontal = 0;
              return true;
            }
          }
          return uVar3 & 0xffffffffffffff00;
        }
    }

    // Token : 0x600029E
    // RVA   : 0x9DAF60   Offset: 0x9D9760   Length: 0x158
    protected virtual void ResetChildPositions()
    {
        long lVar1;
        int iVar2;
        ulong uVar3;
        uint uVar4;
        ulong uVar5;
        long lVar6;
        long lVar7;
        float fVar8;
        float fVar9;
        ulong local_58;
        uint local_50;
        uint local_40;
        uint local_30;
        uVar3 = 0;
        if (this[11] != 0) {
          lVar7 = (int64)*(int *)(this[11] + 24);
          if (0 < lVar7) {
            lVar6 = 32;
            uVar5 = uVar3;
            do {
              lVar1 = this[11];
              if (lVar1 == null) throw; // [null/range check failed]
              uVar4 = (uint32)uVar5;
              if (*(uint32 *)(lVar1 + 24) <= uVar4) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              lVar1 = *(int64 *)(lVar6 + *(int64 *)(lVar1 + 16));
              iVar2 = (int)this[3] * uVar4;
              if ((char)this[10] == false) {
                local_30 = 0;
                fVar8 = 0.0;
                fVar9 = (float)-iVar2;
              }
              else {
                fVar8 = (float)iVar2;
                local_40 = 0;
                fVar9 = 0.0;
              }
              if (lVar1 == null) throw; // [null/range check failed]
              local_58 = CONCAT44(fVar9,fVar8);
              local_50 = 0;
              Transform.set_localPosition(lVar1,&local_58,0);
              (**(code **)(*this + 0x1d8))(this,lVar1,uVar5,*(uint64 *)(*this + 0x1e0));
              uVar5 = (uint64)(uVar4 + 1);
              uVar3 = uVar3 + 1;
              lVar6 = lVar6 + 8;
            } while ((int64)uVar3 < lVar7);
          }
          return;
        }
    }

    // Token : 0x600029F
    // RVA   : 0x9DB620   Offset: 0x9D9E20   Length: 0x8C3
    public virtual void WrapContent()
    {
        float fVar1;
        ulong uVar2;
        uint uVar3;
        long lVar5;
        bool cVar7;
        int iVar8;
        long lVar9;
        long lVar10;
        long lVar12;
        ulong uVar13;
        uint uVar15;
        long lVar16;
        long lVar17;
        float fVar18;
        float fVar19;
        uint uVar20;
        float fVar21;
        float fVar22;
        float fVar23;
        float fVar24;
        float fVar25;
        ulong local_138;
        uint local_130;
        ulong local_128;
        uint local_120;
        ulong local_118;
        uint local_110;
        ulong local_108;
        uint local_100;
        byte[] local_f8 = new byte[16];
        byte[] local_e8 = new byte[16];
        byte[] local_d8 = new byte[16];
        byte[] local_c8 = new byte[16];
        byte[] local_b8 = new byte[144];
        if (this[11] != 0) {
          plVar4 = (int64 *)this[8];
          fVar24 = (float)(*(int *)(this[11] + 24) * (int)this[3]) * 0.5;
          if (plVar4 != (int64 *)0) {
            lVar9 = (**(code **)(*plVar4 + 0x1e8))(plVar4,*(uint64 *)(*plVar4 + 0x1f0));
            uVar15 = 0;
            do {
              if (lVar9 == null) throw; // [null/range check failed]
              lVar10 = (int64)(int)uVar15;
              if (*(uint32 *)(lVar9 + 24) <= uVar15) {
                uVar13 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar13,0);
              }
              if (this[7] == 0) throw; // [null/range check failed]
              local_138 = *(uint64 *)(lVar9 + 32 + lVar10 * 12);
              local_130 = *(uint32 *)(lVar9 + 40 + lVar10 * 12);
              puVar11 = (uint64 *)Transform.InverseTransformPoint(local_f8,this[7],&local_138,0);
              if (*(uint32 *)(lVar9 + 24) <= uVar15) {
                uVar13 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar13,0);
              }
              uVar15 = uVar15 + 1;
              *(uint64 *)(lVar9 + 32 + lVar10 * 12) = *puVar11;
              *(uint32 *)(lVar9 + 40 + lVar10 * 12) = *(uint32 *)(puVar11 + 1);
            } while ((int)uVar15 < 4);
            if (*(uint32 *)(lVar9 + 24) == 0) {
              uVar13 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar13,0);
            }
            if (*(uint32 *)(lVar9 + 24) < 3) {
              uVar13 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar13,0);
            }
            local_120 = *(uint32 *)(lVar9 + 64);
            uVar13 = *(uint64 *)(lVar9 + 56);
            uVar2 = *(uint64 *)(lVar9 + 32);
            local_130 = *(uint32 *)(lVar9 + 40);
            fVar18 = (float)Mathf.Clamp01(0x3f000000,0);
            local_138._4_4_ = (float)((uint64)uVar2 >> 32);
            fVar23 = ((float)((uint64)uVar13 >> 32) - local_138._4_4_) * fVar18 + local_138._4_4_;
            fVar18 = ((float)uVar13 - (float)uVar2) * fVar18 + (float)uVar2;
            bVar6 = true;
            uVar15 = *(uint32 *)(lVar9 + 24);
            fVar25 = fVar24 + fVar24;
            local_138 = uVar2;
            local_128 = uVar13;
            if ((char)this[10] == false) {
              if (uVar15 == 0) {
                uVar13 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar13,0);
              }
              lVar10 = this[3];
              fVar18 = *(float *)(lVar9 + 36);
              if (uVar15 < 3) {
                uVar13 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar13,0);
              }
              uVar15 = 0;
              fVar1 = *(float *)(lVar9 + 60);
              if (this[11] == 0) throw; // [null/range check failed]
              lVar9 = (int64)*(int *)(this[11] + 24);
              if (0 < lVar9) {
                lVar16 = 32;
                lVar17 = 0;
                bVar6 = true;
                do {
                  lVar5 = this[11];
                  if (lVar5 == null) throw; // [null/range check failed]
                  if (*(uint32 *)(lVar5 + 24) <= uVar15) {
                    ThrowHelper.ThrowArgumentOutOfRangeException(0);
                  }
                  lVar5 = *(int64 *)(lVar16 + *(int64 *)(lVar5 + 16));
                  if (lVar5 == null) throw; // [null/range check failed]
                  lVar12 = Transform.get_localPosition(local_e8,lVar5,0);
                  fVar22 = *(float *)(lVar12 + 4) - fVar23;
                  if (fVar22 < -fVar24) {
                    puVar11 = (uint64 *)Transform.get_localPosition(local_c8,lVar5,0);
                    uVar3 = *(uint32 *)(puVar11 + 1);
                    fVar21 = (float)((uint64)*puVar11 >> 32);
                    fVar19 = fVar21 + fVar25;
                    local_108 = CONCAT44(fVar19,(int)*puVar11);
                    fVar22 = fVar19 - fVar23;
                    iVar8 = Mathf.RoundToInt(CONCAT44(fVar21,fVar19 / (float)(int)this[3]),0);
                    if (((int)this[4] == *(int *)((int64)this + 36)) ||
                       (((int)this[4] <= iVar8 && (iVar8 <= *(int *)((int64)this + 36))))) {
                      puVar11 = &local_128;
                      local_128 = local_108;
                      local_120 = uVar3;
        LAB_1809db9f9:
                      Transform.set_localPosition(lVar5,puVar11,0);
        LAB_1809dba04:
                      (**(code **)(*this + 0x1d8))
                                (this,lVar5,uVar15,*(uint64 *)(*this + 0x1e0));
                    }
                    else {
                      bVar6 = false;
                    }
                  }
                  else if (fVar24 < fVar22) {
                    puVar11 = (uint64 *)Transform.get_localPosition(local_d8,lVar5,0);
                    uVar3 = *(uint32 *)(puVar11 + 1);
                    fVar21 = (float)((uint64)*puVar11 >> 32);
                    fVar19 = fVar21 - fVar25;
                    local_138 = CONCAT44(fVar19,(int)*puVar11);
                    fVar22 = fVar19 - fVar23;
                    iVar8 = Mathf.RoundToInt(CONCAT44(fVar21,fVar19 / (float)(int)this[3]),0);
                    if (((int)this[4] == *(int *)((int64)this + 36)) ||
                       (((int)this[4] <= iVar8 && (iVar8 <= *(int *)((int64)this + 36))))) {
                      puVar11 = &local_118;
                      local_118 = local_138;
                      local_110 = uVar3;
                      goto LAB_1809db9f9;
                    }
                    bVar6 = false;
                  }
                  else if (*(char *)((int64)this + 81) != false) goto LAB_1809dba04;
                  if (*(char *)((int64)this + 28) != false) {
                    if ((this[8] == 0) || (fVar19 = *(float *)(this[8] + 0x168), this[7] == 0))
                    throw; // [null/range check failed]
                    lVar12 = Transform.get_localPosition(local_b8);
                    fVar22 = fVar22 + (fVar19 - *(float *)(lVar12 + 4));
                    uVar13 = Component.get_gameObject(lVar5,0);
                    cVar7 = UICamera.IsPressed(uVar13,0);
                    if (!cVar7) {
                      uVar13 = Component.get_gameObject(lVar5,0);
                      NGUITools.SetActive
                                (uVar13,fVar18 - (float)(int)lVar10 < fVar22 &&
                                        fVar22 < (float)(int)lVar10 + fVar1,0,0);
                    }
                  }
                  uVar15 = uVar15 + 1;
                  lVar17 = lVar17 + 1;
                  lVar16 = lVar16 + 8;
                } while (lVar17 < lVar9);
              }
            }
            else {
              if (uVar15 == 0) {
                uVar13 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar13,0);
              }
              lVar10 = this[3];
              fVar23 = *(float *)(lVar9 + 32);
              if (uVar15 < 3) {
                uVar13 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar13,0);
              }
              uVar15 = 0;
              fVar1 = *(float *)(lVar9 + 56);
              if (this[11] == 0) throw; // [null/range check failed]
              lVar9 = (int64)*(int *)(this[11] + 24);
              if (0 < lVar9) {
                lVar16 = 32;
                lVar17 = 0;
                bVar6 = true;
                do {
                  lVar5 = this[11];
                  if (lVar5 == null) throw; // [null/range check failed]
                  if (*(uint32 *)(lVar5 + 24) <= uVar15) {
                    ThrowHelper.ThrowArgumentOutOfRangeException(0);
                  }
                  lVar5 = *(int64 *)(lVar16 + *(int64 *)(lVar5 + 16));
                  if (lVar5 == null) throw; // [null/range check failed]
                  pfVar14 = (float *)Transform.get_localPosition(local_b8,lVar5,0);
                  fVar22 = *pfVar14 - fVar18;
                  if (fVar22 < -fVar24) {
                    puVar11 = (uint64 *)Transform.get_localPosition(local_d8,lVar5,0);
                    uVar3 = *(uint32 *)(puVar11 + 1);
                    uVar20 = (uint32)((uint64)*puVar11 >> 32);
                    fVar19 = (float)*puVar11 + fVar25;
                    local_118 = CONCAT44(uVar20,fVar19);
                    fVar22 = fVar19 - fVar18;
                    iVar8 = Mathf.RoundToInt(CONCAT44(uVar20,fVar19 / (float)(int)this[3]),0);
                    if (((int)this[4] == *(int *)((int64)this + 36)) ||
                       (((int)this[4] <= iVar8 && (iVar8 <= *(int *)((int64)this + 36))))) {
                      puVar11 = &local_138;
                      local_138 = local_118;
                      local_130 = uVar3;
                      goto LAB_1809dbcb1;
                    }
        LAB_1809dbc94:
                    bVar6 = false;
                  }
                  else {
                    if (fVar24 < fVar22) {
                      puVar11 = (uint64 *)Transform.get_localPosition(local_c8,lVar5,0);
                      uVar3 = *(uint32 *)(puVar11 + 1);
                      uVar20 = (uint32)((uint64)*puVar11 >> 32);
                      fVar19 = (float)*puVar11 - fVar25;
                      local_128 = CONCAT44(uVar20,fVar19);
                      fVar22 = fVar19 - fVar18;
                      iVar8 = Mathf.RoundToInt(CONCAT44(uVar20,fVar19 / (float)(int)this[3]),0);
                      if ((int)this[4] != *(int *)((int64)this + 36)) {
                        if (iVar8 < (int)this[4]) goto LAB_1809dbc94;
                        if (*(int *)((int64)this + 36) < iVar8) {
                          bVar6 = false;
                          goto LAB_1809dbcd5;
                        }
                      }
                      puVar11 = &local_108;
                      local_108 = local_128;
                      local_100 = uVar3;
        LAB_1809dbcb1:
                      Transform.set_localPosition(lVar5,puVar11,0);
                    }
                    else if (*(char *)((int64)this + 81) == false) goto LAB_1809dbcd5;
                    (**(code **)(*this + 0x1d8))
                              (this,lVar5,uVar15,*(uint64 *)(*this + 0x1e0));
                  }
        LAB_1809dbcd5:
                  if (*(char *)((int64)this + 28) != false) {
                    if ((this[8] == 0) || (fVar19 = *(float *)(this[8] + 0x164), this[7] == 0))
                    throw; // [null/range check failed]
                    pfVar14 = (float *)Transform.get_localPosition(local_e8);
                    fVar22 = fVar22 + (fVar19 - *pfVar14);
                    uVar13 = Component.get_gameObject(lVar5,0);
                    cVar7 = UICamera.IsPressed(uVar13,0);
                    if (!cVar7) {
                      uVar13 = Component.get_gameObject(lVar5,0);
                      NGUITools.SetActive
                                (uVar13,fVar23 - (float)(int)lVar10 < fVar22 &&
                                        fVar22 < (float)(int)lVar10 + fVar1,0,0);
                    }
                  }
                  uVar15 = uVar15 + 1;
                  lVar17 = lVar17 + 1;
                  lVar16 = lVar16 + 8;
                } while (lVar17 < lVar9);
              }
            }
            if (this[9] != 0) {
              *(bool *)(this[9] + 32) = !bVar6;
              if (this[9] != 0) {
                UIScrollView.InvalidateBounds(this[9],0);
                return;
              }
            }
          }
        }
    }

    // Token : 0x60002A0
    // RVA   : 0x9DAF50   Offset: 0x9D9750   Length: 0xC
    private void OnValidate()
    {
        void FUN_1809daf50(int64 this)
        {
        if (this.maxIndex < this.minIndex) {
          this.maxIndex = this.minIndex;
        }
    }

    // Token : 0x60002A1
    // RVA   : 0x9DB540   Offset: 0x9D9D40   Length: 0xD2
    protected virtual void UpdateItem(Transform item, int index)
    {
        long lVar1;
        uint uVar2;
        ulong uVar3;
        byte[] local_18 = new byte[16];
        if (this.onInitializeItem == null) {
          return;
        }
        if ((this.mScroll != null) && (item != null)) {
          if (this.mScroll.movement == 1) {
            Transform.get_localPosition(local_18,item,0);
          }
          else {
            Transform.get_localPosition(local_18,item,0);
          }
          uVar2 = Mathf.RoundToInt();
          lVar1 = this.onInitializeItem;
          uVar3 = Component.get_gameObject(item,0);
          if (lVar1 != null) {
            OnInitializeItem.Invoke(lVar1,uVar3,index,uVar2,0);
            return;
          }
        }
    }

    // Token : 0x60002A2
    // RVA   : 0x9DBEF0   Offset: 0x9DA6F0   Length: 0x85
    public void /*ctor*/()
    {
        ulong uVar1;
        this.itemSize = 100;
        this.cullContent = 1;
        this.mFirstTime = 1;
        uVar1 = il2cpp_internal(DAT_181d734b0);
        FUN_180f58a90(uVar1,DAT_181d80278);
        this.mChildren = uVar1;
        FUN_18044ef50(this,0);
    }

}
