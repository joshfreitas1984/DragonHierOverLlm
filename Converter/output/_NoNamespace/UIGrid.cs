// ============================================================
// Type  : UIGrid
// Token : 0x2000046
// ============================================================

public class UIGrid
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4000174
    public Arrangement arrangement;

    // Token: 0x4000175
    public Sorting sorting;

    // Token: 0x4000176
    public Pivot pivot;

    // Token: 0x4000177
    public int maxPerLine;

    // Token: 0x4000178
    public float cellWidth;

    // Token: 0x4000179
    public float cellHeight;

    // Token: 0x400017A
    public bool animateSmoothly;

    // Token: 0x400017B
    public bool hideInactive;

    // Token: 0x400017C
    public bool keepWithinPanel;

    // Token: 0x400017D
    public OnReposition onReposition;

    // Token: 0x400017E
    public Comparison<Transform> onCustomSort;

    // Token: 0x400017F
    private bool sorted;

    // Token: 0x4000180
    protected bool mReposition;

    // Token: 0x4000181
    protected UIPanel mPanel;

    // Token: 0x4000182
    protected bool mInitDone;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000151
    // RVA   : 0x10ECF20   Offset: 0x10EB720   Length: 0x13
    public void set_repositionNow(bool value)
    {
        if (value) {
          this.mReposition = 1;
          Behaviour.set_enabled(this,1,0);
          return;
        }
    }

    // Token : 0x6000152
    // RVA   : 0x10EC060   Offset: 0x10EA860   Length: 0x2B7
    public List<Transform> GetChildList()
    {
        bool cVar1;
        int iVar2;
        long lVar3;
        long lVar4;
        long lVar5;
        long lVar6;
        ulong uVar7;
        int iVar8;
        lVar3 = Component.get_transform(this,0);
        lVar4 = il2cpp_internal(DAT_181d734b0);
        FUN_180f58a90(lVar4,DAT_181d80278);
        iVar8 = 0;
        if (lVar3 == null) throw; // [null/range check failed]
        for (; iVar2 = Transform.get_childCount(lVar3,0), iVar8 < iVar2; iVar8 = iVar8 + 1) {
          lVar5 = Transform.GetChild(lVar3,iVar8,0);
          if (*(char *)((int64)this + 49) == false) {
        LAB_1810ec1d3:
            if (lVar5 == null) throw; // [null/range check failed]
            uVar7 = Component.get_gameObject(lVar5);
            cVar1 = UIDragDropItem.IsDragged(uVar7);
            if (!cVar1) {
              if (lVar4 == null) throw; // [null/range check failed]
              FUN_181827900(lVar4);
            }
          }
          else {
            cVar1 = Object.op_Implicit(lVar5);
            if (cVar1) {
              if ((lVar5 == null) || (lVar6 = Component.get_gameObject(lVar5)) == null)
              throw; // [null/range check failed]
              cVar1 = GameObject.get_activeSelf(lVar6);
              if (cVar1) goto LAB_1810ec1d3;
            }
          }
        }
        iVar8 = *(int *)((int64)this + 28);
        if (iVar8 == 0) {
          return lVar4;
        }
        if ((int)this[3] == 2) {
          return lVar4;
        }
        if (iVar8 == 1) {
          lVar3 = il2cpp_internal(DAT_181d59ac8);
          uVar7 = DAT_181d9c9e8;
        LAB_1810ec2cb:
          OnTooltipCB.ctor(lVar3,0,uVar7,DAT_181d86498);
        }
        else {
          if (iVar8 == 2) {
            lVar3 = il2cpp_internal(DAT_181d59ac8);
            uVar7 = DAT_181d9ca70;
            goto LAB_1810ec2cb;
          }
          if (iVar8 == 3) {
            lVar3 = il2cpp_internal(DAT_181d59ac8);
            uVar7 = DAT_181d9caf8;
            goto LAB_1810ec2cb;
          }
          lVar3 = this[8];
          if (lVar3 == null) {
            (**(code **)(*this + 0x1a8))(this,lVar4,*(uint64 *)(*this + 0x1b0));
            return lVar4;
          }
        }
        if (lVar4 != null) {
          List_1.Sort(lVar4,lVar3,DAT_181d805f8);
          return lVar4;
        }
    }

    // Token : 0x6000153
    // RVA   : 0x10EC320   Offset: 0x10EAB20   Length: 0x7E
    public Transform GetChild(int index)
    {
        long lVar1;
        lVar1 = UIGrid.GetChildList(this,0);
        if (lVar1 != null) {
          if ((int)index < (int)*(uint32 *)(lVar1 + 24)) {
            if (*(uint32 *)(lVar1 + 24) <= index) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            return lVar1[index];
          }
          return 0;
        }
    }

    // Token : 0x6000154
    // RVA   : 0x10EC3A0   Offset: 0x10EABA0   Length: 0x5C
    public int GetIndex(Transform trans)
    {
        long lVar1;
        lVar1 = UIGrid.GetChildList(this,0);
        if (lVar1 != null) {
          FUN_1817ff280(lVar1,trans,DAT_181d804f8);
          return;
        }
    }

    // Token : 0x6000155
    // RVA   : 0x10EBEA0   Offset: 0x10EA6A0   Length: 0xA9
    public void AddChild(Transform trans)
    {
        ulong uVar1;
        bool cVar2;
        cVar2 = Object.op_Inequality(trans,0,0);
        if (cVar2) {
          uVar1 = Component.get_transform(this,0);
          if (trans == null) {
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          Transform.set_parent(trans,uVar1,0);
          uVar1 = UIGrid.GetChildList(this,0);
          (**(code **)(*this + 0x1c8))(this,uVar1,*(uint64 *)(*this + 0x1d0));
        }
    }

    // Token : 0x6000156
    // RVA   : 0x10EBDF0   Offset: 0x10EA5F0   Length: 0xA9
    public void AddChild(Transform trans, bool sort)
    {
        ulong uVar1;
        bool cVar2;
        cVar2 = Object.op_Inequality(trans,0,0);
        if (cVar2) {
          uVar1 = Component.get_transform(this,0);
          if (trans == null) {
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          Transform.set_parent(trans,uVar1,0);
          uVar1 = UIGrid.GetChildList(this,0);
          (**(code **)(*this + 0x1c8))(this,uVar1,*(uint64 *)(*this + 0x1d0));
        }
    }

    // Token : 0x6000157
    // RVA   : 0x10EC510   Offset: 0x10EAD10   Length: 0x96
    public bool RemoveChild(Transform t)
    {
        bool cVar1;
        long lVar2;
        lVar2 = UIGrid.GetChildList(this,0);
        if (lVar2 != null) {
          cVar1 = FUN_181801c10(lVar2,t,DAT_181d80578);
          if (!cVar1) {
            return false;
          }
          (**(code **)(*this + 0x1c8))(this,lVar2,*(uint64 *)(*this + 0x1d0));
          return true;
        }
    }

    // Token : 0x6000158
    // RVA   : 0x10EC400   Offset: 0x10EAC00   Length: 0x8C
    protected virtual void Init()
    {
        ulong uVar1;
        this.mInitDone = 1;
        uVar1 = Component.get_gameObject(this,0);
        uVar1 = NGUITools.FindInParents(uVar1,DAT_181d66900);
        this.mPanel = uVar1;
    }

    // Token : 0x6000159
    // RVA   : 0x10ECE70   Offset: 0x10EB670   Length: 0x58
    protected virtual void Start()
    {
        long lVar1;
        if ((char)this[11] == false) {
          (**(code **)(*this + 0x178))(this,*(uint64 *)(*this + 0x180));
        }
        lVar1 = this[6];
        *(uint8 *)(this + 6) = 0;
        (**(code **)(*this + 0x1b8))(this,*(uint64 *)(*this + 0x1c0));
        *(char *)(this + 6) = (char)lVar1;
        Behaviour.set_enabled(this,0,0);
    }

    // Token : 0x600015A
    // RVA   : 0x10ECED0   Offset: 0x10EB6D0   Length: 0x2B
    protected virtual void Update()
    {
        (**(code **)(*this + 0x1b8))(this,*(uint64 *)(*this + 0x1c0));
        Behaviour.set_enabled(this,0,0);
    }

    // Token : 0x600015B
    // RVA   : 0x10EC490   Offset: 0x10EAC90   Length: 0x7B
    private void OnValidate()
    {
        bool cVar1;
        cVar1 = Application.get_isPlaying(0);
        if (!cVar1) {
          cVar1 = NGUITools.GetActive(this,0);
          if (cVar1) {
                          // WARNING: Could not recover jumptable at 0x0001810ec4fe. Too many branches
                          // WARNING: Treating indirect jump as call
            (**(code **)(*this + 0x1b8))(this,*(uint64 *)(*this + 0x1c0));
            return;
          }
        }
    }

    // Token : 0x600015C
    // RVA   : 0xA3CA90   Offset: 0xA3B290   Length: 0x48
    public static int SortByName(Transform a, Transform b)
    {
        ulong uVar1;
        ulong uVar2;
        if (a != null) {
          uVar1 = Object.get_name(a,0);
          if (b != null) {
            uVar2 = Object.get_name(b,0);
            String.Compare(uVar1,uVar2,0);
            return;
          }
        }
    }

    // Token : 0x600015D
    // RVA   : 0x10ECD90   Offset: 0x10EB590   Length: 0x60
    public static int SortHorizontal(Transform a, Transform b)
    {
        ulong local_28;
        uint local_20;
        byte[] local_18 = new byte[16];
        if (a != null) {
          puVar1 = (uint64 *)Transform.get_localPosition(local_18,a,0);
          local_28 = *puVar1;
          local_20 = *(uint32 *)(puVar1 + 1);
          if (b != null) {
            puVar2 = (uint32 *)Transform.get_localPosition(local_18,b,0);
            Single.CompareTo(&local_28,*puVar2,0);
            return;
          }
        }
    }

    // Token : 0x600015E
    // RVA   : 0x10ECE00   Offset: 0x10EB600   Length: 0x61
    public static int SortVertical(Transform a, Transform b)
    {
        long lVar2;
        byte[] local_18 = new byte[16];
        if (b != null) {
          puVar1 = (uint64 *)Transform.get_localPosition(local_18,b,0);
          if (a != null) {
            lVar2 = Transform.get_localPosition(local_18,a,0,param_4,*puVar1);
            Single.CompareTo(&stack0xffffffffffffffdc,*(uint32 *)(lVar2 + 4),0);
            return;
          }
        }
    }

    // Token : 0x600015F
    // RVA   : 0x245810   Offset: 0x244010   Length: 0x3
    protected virtual void Sort(List<Transform> list)
    {
    }

    // Token : 0x6000160
    // RVA   : 0x10EC5B0   Offset: 0x10EADB0   Length: 0x20D
    public virtual void Reposition()
    {
        long lVar1;
        bool cVar2;
        ulong uVar3;
        cVar2 = Application.get_isPlaying(0);
        if ((cVar2) && ((char)this[11] == false)) {
          uVar3 = Component.get_gameObject(this,0);
          cVar2 = NGUITools.GetActive(uVar3,0);
          if (cVar2) {
            (**(code **)(*this + 0x178))(this,*(uint64 *)(*this + 0x180));
          }
        }
        if ((char)this[9] != false) {
          *(uint8 *)(this + 9) = 0;
          if (*(int *)((int64)this + 28) == 0) {
            *(uint32 *)((int64)this + 28) = 1;
          }
          ZhSegment.Initialize(this,"last change",0);
        }
        uVar3 = UIGrid.GetChildList(this,0);
        (**(code **)(*this + 0x1c8))(this,uVar3,*(uint64 *)(*this + 0x1d0));
        if (*(char *)((int64)this + 50) != false) {
          lVar1 = this[10];
          cVar2 = Object.op_Inequality(lVar1,0,0);
          if (cVar2) {
            lVar1 = this[10];
            uVar3 = Component.get_transform(this,0);
            if (lVar1 != null) {
              UIPanel.ConstrainTargetToBounds(lVar1,uVar3,1,0);
              if (this[10] != 0) {
                plVar4 = (int64 *)Component.GetComponent(this[10],DAT_181d6e540);
                cVar2 = Object.op_Inequality(plVar4,0,0);
                if (cVar2) {
                  if (plVar4 == (int64 *)0) goto LAB_1810ec7b8;
                  (**(code **)(*plVar4 + 0x1b8))(plVar4,1,*(uint64 *)(*plVar4 + 0x1c0));
                }
                goto LAB_1810ec79d;
              }
            }
        LAB_1810ec7b8:
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
        }
        LAB_1810ec79d:
        if (this[7] != 0) {
          OnGeometryUpdated.Invoke(this[7],0);
        }
    }

    // Token : 0x6000161
    // RVA   : 0x10EBF50   Offset: 0x10EA750   Length: 0x101
    public void ConstrainWithinPanel()
    {
        long lVar1;
        bool cVar2;
        ulong uVar3;
        uVar3 = this.mPanel;
        cVar2 = Object.op_Inequality(uVar3,0,0);
        if (!cVar2) {
          return;
        }
        lVar1 = this.mPanel;
        uVar3 = Component.get_transform(this,0);
        if (lVar1 != null) {
          UIPanel.ConstrainTargetToBounds(lVar1,uVar3,1,0);
          if (this.mPanel != null) {
            plVar4 = (int64 *)Component.GetComponent(this.mPanel,DAT_181d6e540);
            cVar2 = Object.op_Inequality(plVar4,0,0);
            if (cVar2) {
              if (plVar4 == (int64 *)0) throw; // [null/range check failed]
              (**(code **)(*plVar4 + 0x1b8))(plVar4,1,*(uint64 *)(*plVar4 + 0x1c0));
            }
            return;
          }
        }
    }

    // Token : 0x6000162
    // RVA   : 0x10EC7C0   Offset: 0x10EAFC0   Length: 0x5CD
    protected virtual void ResetPosition(List<Transform> list)
    {
        bool cVar1;
        int iVar2;
        int iVar3;
        ulong uVar5;
        long lVar6;
        uint uVar7;
        long lVar8;
        int iVar9;
        int iVar10;
        float fVar11;
        float fVar12;
        float fVar13;
        float fVar14;
        int local_res8;
        int local_res20;
        ulong local_158;
        ulong local_148;
        float local_140;
        ulong local_138;
        long local_128;
        ulong local_120;
        ulong uStack_118;
        long local_110;
        long local_108;
        float local_f8;
        float local_e8;
        ulong local_d8;
        float local_d0;
        ulong local_c8;
        ulong uStack_c0;
        long local_b8;
        byte[] local_a8 = new byte[112];
        local_120 = 0;
        uStack_118 = 0;
        local_110 = 0;
        this.mReposition = 0;
        iVar9 = 0;
        iVar10 = 0;
        iVar2 = 0;
        local_res20 = 0;
        iVar3 = 0;
        local_res8 = 0;
        uVar7 = 0;
        if (list == null) {
        LAB_1810ecd88:
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
        if (0 < *(int *)(list + 24)) {
          local_128 = 0;
          lVar8 = 32;
          local_108 = (int64)*(int *)(list + 24);
          do {
            if (*(uint32 *)(list + 24) <= uVar7) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            lVar6 = *(int64 *)(*(int64 *)(list + 16) + lVar8);
            if (lVar6 == null) goto LAB_1810ecd88;
            puVar4 = (uint64 *)Transform.get_localPosition(local_a8,lVar6,0);
            local_158 = *puVar4;
            fVar13 = *(float *)(puVar4 + 1);
            fVar12 = this.cellWidth;
            local_f8 = fVar13;
            if (this.arrangement == 2) {
              fVar11 = (float)local_158;
              if (0.0 < fVar12) {
                fVar11 = (float)FUN_18000d7c0((float)local_158 / fVar12);
                fVar11 = this.cellWidth * fVar11;
                local_158._4_4_ = (float)((uint64)local_158 >> 32);
                local_158 = CONCAT44(local_158._4_4_,fVar11);
              }
              fVar14 = local_158._4_4_;
              if (0.0 < this.cellHeight) {
                fVar14 = (float)FUN_18000d7c0(local_158._4_4_ / this.cellHeight);
                fVar14 = this.cellHeight * fVar14;
                local_158 = CONCAT44(fVar14,(float)local_158);
              }
            }
            else {
              fVar11 = (float)iVar10;
              fVar14 = (float)iVar9;
              if (this.arrangement == null) {
                fVar14 = fVar11;
                fVar11 = (float)iVar9;
              }
              fVar11 = fVar12 * fVar11;
              fVar14 = -this.cellHeight * fVar14;
              local_158 = CONCAT44(fVar14,fVar11);
            }
            if ((!this.animateSmoothly) ||
               (cVar1 = Application.get_isPlaying(0), !cVar1)) {
        LAB_1810ecab4:
              local_148 = local_158;
              local_140 = fVar13;
              Transform.set_localPosition(lVar6,&local_148);
            }
            else {
              if (this.pivot == null) {
                puVar4 = (uint64 *)Transform.get_localPosition(&local_c8,lVar6,0);
                local_138 = *puVar4;
                local_e8 = *(float *)(puVar4 + 1);
                fVar11 = (float)local_138 - fVar11;
                fVar14 = (float)((uint64)local_138 >> 32) - fVar14;
                if (fVar11 * fVar11 + fVar14 * fVar14 + (local_e8 - fVar13) * (local_e8 - fVar13) < 0.0001
                   ) goto LAB_1810ecab4;
              }
              uVar5 = Component.get_gameObject(lVar6,0);
              local_d8 = local_158;
              local_d0 = fVar13;
              lVar6 = SpringPosition.Begin(uVar5,&local_d8,0x41700000);
              if (lVar6 == null) goto LAB_1810ecd88;
              *(uint16 *)(lVar6 + 41) = 0x101;
            }
            iVar2 = Mathf.Max(local_res20,iVar9);
            iVar3 = Mathf.Max(local_res8,iVar10);
            iVar9 = iVar9 + 1;
            if ((this.maxPerLine <= iVar9) && (0 < this.maxPerLine)) {
              iVar9 = 0;
              iVar10 = iVar10 + 1;
            }
            uVar7 = uVar7 + 1;
            local_128 = local_128 + 1;
            lVar8 = lVar8 + 8;
            local_res8 = iVar3;
            local_res20 = iVar2;
          } while (local_128 < local_108);
        }
        if (this.pivot != null) {
          NGUIMath.GetPivotOffset(this.pivot,0);
          if (this.arrangement == null) {
            fVar12 = (float)Mathf.Lerp();
          }
          else {
            fVar12 = (float)Mathf.Lerp();
            iVar3 = iVar2;
          }
          fVar13 = (float)Mathf.Lerp((float)-iVar3 * this.cellHeight);
          FUN_1817ff240(&local_c8,list,DAT_181d80478);
          local_120 = local_c8;
          uStack_118 = uStack_c0;
          local_110 = local_b8;
          while (cVar1 = FUN_180d197a0(&local_120,DAT_181d6c538), lVar8 = local_110, cVar1) {
            if (local_110 == 0) {
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            lVar6 = Component.GetComponent(local_110,DAT_181d6d4c0);
            cVar1 = Object.op_Inequality(lVar6,0,0);
            if (!cVar1) {
              puVar4 = (uint64 *)Transform.get_localPosition(&local_c8,lVar8);
              uVar5 = *puVar4;
              local_140 = *(float *)(puVar4 + 1);
              local_138._4_4_ = (float)((uint64)uVar5 >> 32);
              local_148 = CONCAT44(local_138._4_4_ - fVar13,(float)uVar5 - fVar12);
              local_138 = uVar5;
              Transform.set_localPosition(lVar8,&local_148);
            }
            else {
              if (lVar6 == null) {
                          // WARNING: Subroutine does not return
                FUN_1800d6620();
              }
              Behaviour.set_enabled(lVar6,0);
              *(float *)(lVar6 + 24) = *(float *)(lVar6 + 24) - fVar12;
              *(float *)(lVar6 + 28) = *(float *)(lVar6 + 28) - fVar13;
              Behaviour.set_enabled(lVar6,1);
            }
          }
          ZhSegment.Initialize(&local_120,DAT_181d6c4b8);
        }
    }

    // Token : 0x6000163
    // RVA   : 0x10ECF00   Offset: 0x10EB700   Length: 0x15
    public void /*ctor*/()
    {
        void FUN_1810ecf00(int64 this)
        {
        this.cellWidth = 0x43480000;
        this.cellHeight = 0x43480000;
        TrailRenderer_Base.ctor(this,0);
    }

}
