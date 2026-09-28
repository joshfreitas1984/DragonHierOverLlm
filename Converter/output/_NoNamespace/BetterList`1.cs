// ============================================================
// Type  : BetterList`1
// Token : 0x200007A
// ============================================================

public class BetterList`1
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4000305
    public T[] buffer;

    // Token: 0x4000306
    public int size;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60002EB
    // RVA   : 0xC73510   Offset: 0xC72910   Length: 0x85
    public IEnumerator<T> GetEnumerator()
    {
        long lVar2;
        lVar2 = **(int64 **)(*(int64 *)(param_2 + 24) + 192);
        if ((*(byte *)(lVar2 + 0x132) & 1) == 0) {
          FUN_18009a510(lVar2);
        }
        lVar2 = il2cpp_internal(lVar2);
        puVar1 = *(uint64 **)(*(int64 *)(*(int64 *)(param_2 + 24) + 192) + 8);
        (*(code *)*puVar1)(lVar2,0,puVar1);
        if (lVar2 != null) {
          *(uint64 *)(lVar2 + 40) = this;
          return lVar2;
        }
    }

    // Token : 0x60002EC
    // RVA   : 0x1587620   Offset: 0x1586A20   Length: 0x42
    public T get_Item(int i)
    {
        long lVar2;
        ulong uVar3;
        lVar2 = *(int64 *)(i + 16);
        if (lVar2 == null) {
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
        if (param_3 < *(uint32 *)(lVar2 + 24)) {
          puVar1 = (uint64 *)(lVar2 + ((int64)(int)param_3 + 2) * 16);
          uVar3 = puVar1[1];
          *this = *puVar1;
          this[1] = uVar3;
          return this;
        }
        uVar3 = il2cpp_internal();
    }

    // Token : 0x60002ED
    // RVA   : 0x1587710   Offset: 0x1586B10   Length: 0x40
    public void set_Item(int i, T value)
    {
        long lVar2;
        ulong uVar3;
        lVar2 = *(int64 *)(this + 16);
        if (lVar2 == null) {
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
        if (i < *(uint32 *)(lVar2 + 24)) {
          uVar3 = value[1];
          puVar1 = (uint64 *)(lVar2 + ((int64)(int)i + 2) * 16);
          *puVar1 = *value;
          puVar1[1] = uVar3;
          return;
        }
        uVar3 = il2cpp_internal();
    }

    // Token : 0x60002EE
    // RVA   : 0x1583F20   Offset: 0x1583320   Length: 0xCB
    private void AllocateMore()
    {
        uint uVar1;
        ulong uVar2;
        long lVar3;
        if (*(int64 *)(this + 16) == 0) {
          lVar3 = *(int64 *)(*(int64 *)(*(int64 *)(param_2 + 24) + 192) + 16);
          if ((*(byte *)(lVar3 + 0x132) & 1) == 0) {
            FUN_18009a510(lVar3);
          }
          uVar1 = 32;
        }
        else {
          uVar1 = Mathf.Max(*(int *)(*(int64 *)(this + 16) + 24) * 2,32);
          lVar3 = *(int64 *)(*(int64 *)(*(int64 *)(param_2 + 24) + 192) + 16);
          if ((*(byte *)(lVar3 + 0x132) & 1) == 0) {
            FUN_18009a510(lVar3);
          }
        }
        uVar2 = FUN_1800d60b0(lVar3,uVar1);
        if ((*(int64 *)(this + 16) != 0) && (0 < *(int *)(this + 24))) {
          Array.CopyTo(*(int64 *)(this + 16),uVar2,0,0);
        }
        *(uint64 *)(this + 16) = uVar2;
    }

    // Token : 0x60002EF
    // RVA   : 0x1587110   Offset: 0x1586510   Length: 0xF8
    private void Trim()
    {
        int iVar3;
        long lVar4;
        uint uVar5;
        uint uVar6;
        uint uVar7;
        uint uVar8;
        long lVar9;
        ulong uVar10;
        long lVar11;
        iVar3 = *(int *)(this + 24);
        if (iVar3 < 1) {
          lVar9 = 0;
          *(uint64 *)(this + 16) = 0;
        }
        else {
          if (*(int64 *)(this + 16) == 0) {
        LAB_1815871e3:
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          if (*(int *)(*(int64 *)(this + 16) + 24) <= iVar3) {
            return;
          }
          lVar9 = *(int64 *)(*(int64 *)(*(int64 *)(param_2 + 24) + 192) + 16);
          if ((*(byte *)(lVar9 + 0x132) & 1) == 0) {
            FUN_18009a510(lVar9);
          }
          lVar9 = FUN_1800d60b0(lVar9,iVar3);
          uVar8 = 0;
          if (0 < *(int *)(this + 24)) {
            do {
              lVar4 = *(int64 *)(this + 16);
              if (lVar4 == null) goto LAB_1815871e3;
              lVar11 = (int64)(int)uVar8;
              if (*(uint32 *)(lVar4 + 24) <= uVar8) {
                uVar10 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar10,0);
              }
              if (lVar9 == null) goto LAB_1815871e3;
              if (*(uint32 *)(lVar9 + 24) <= uVar8) {
                uVar10 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar10,0);
              }
              puVar1 = (uint32 *)(lVar4 + (lVar11 + 2) * 16);
              uVar5 = puVar1[1];
              uVar6 = puVar1[2];
              uVar7 = puVar1[3];
              uVar8 = uVar8 + 1;
              puVar2 = (uint32 *)(lVar9 + (lVar11 + 2) * 16);
              *puVar2 = *puVar1;
              puVar2[1] = uVar5;
              puVar2[2] = uVar6;
              puVar2[3] = uVar7;
            } while ((int)uVar8 < *(int *)(this + 24));
          }
          *(int64 *)(this + 16) = lVar9;
        }
        il2cpp_internal(this + 16,lVar9);
    }

    // Token : 0x60002F0
    // RVA   : 0x101AF10   Offset: 0x101A310   Length: 0x8
    public void Clear()
    {
        *(uint32 *)(this + 24) = 0;
    }

    // Token : 0x60002F1
    // RVA   : 0x1585650   Offset: 0x1584A50   Length: 0x13
    public void Release()
    {
        void FUN_181585650(int64 this)
        {
        *(uint32 *)(this + 24) = 0;
        *(uint64 *)(this + 16) = 0;
    }

    // Token : 0x60002F2
    // RVA   : 0x1583D00   Offset: 0x1583100   Length: 0x91
    public void Add(T item)
    {
        ulong uVar3;
        long lVar4;
        uint uVar5;
        lVar4 = *(int64 *)(this + 16);
        puVar1 = (uint32 *)(this + 24);
        if ((lVar4 == null) || (uVar5 = *puVar1, uVar5 == *(uint32 *)(lVar4 + 24))) {
          puVar2 = *(uint64 **)(*(int64 *)(*(int64 *)(param_3 + 24) + 192) + 24);
          (*(code *)*puVar2)(this,puVar2);
          lVar4 = *(int64 *)(this + 16);
          uVar5 = *puVar1;
        }
        *puVar1 = uVar5 + 1;
        if (lVar4 != null) {
          if (uVar5 < *(uint32 *)(lVar4 + 24)) {
            uVar3 = item[1];
            puVar2 = (uint64 *)(lVar4 + ((int64)(int)uVar5 + 2) * 16);
            *puVar2 = *item;
            puVar2[1] = uVar3;
            return;
          }
          uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
          FUN_1800d65f0(uVar3,0);
        }
    }

    // Token : 0x60002F3
    // RVA   : 0x1584DF0   Offset: 0x15841F0   Length: 0x12D
    public void Insert(int index, T item)
    {
        long lVar4;
        uint uVar5;
        uint uVar6;
        uint uVar7;
        ulong uVar8;
        uint uVar9;
        long lVar10;
        uint local_18;
        uint uStack_14;
        uint uStack_10;
        uint32 uStack_c;
        if ((*(int64 *)(this + 16) == 0) ||
           (*(int *)(this + 24) == *(int *)(*(int64 *)(this + 16) + 24))) {
          puVar3 = *(uint64 **)(*(int64 *)(*(int64 *)(param_4 + 24) + 192) + 24);
          (*(code *)*puVar3)(this,puVar3);
        }
        if (((int)index < 0) || (uVar9 = *(uint32 *)(this + 24), (int)uVar9 <= (int)index)) {
          local_18 = *(uint32 *)item;
          uStack_14 = *(uint32 *)((int64)item + 4);
          uStack_10 = *(uint32 *)(item + 1);
          uStack_c = *(uint32 *)((int64)item + 12);
          puVar3 = *(uint64 **)(*(int64 *)(*(int64 *)(param_4 + 24) + 192) + 32);
          (*(code *)*puVar3)(this,&local_18,puVar3);
        }
        else {
          do {
            lVar4 = *(int64 *)(this + 16);
            if (lVar4 == null) goto LAB_181584f18;
            lVar10 = (int64)(int)uVar9;
            if (*(uint32 *)(lVar4 + 24) <= uVar9 - 1) {
              uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar8,0);
            }
            if (*(uint32 *)(lVar4 + 24) <= uVar9) {
              uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar8,0);
            }
            puVar1 = (uint32 *)(lVar4 + (lVar10 + 1) * 16);
            uVar5 = puVar1[1];
            uVar6 = puVar1[2];
            uVar7 = puVar1[3];
            uVar9 = uVar9 - 1;
            puVar2 = (uint32 *)(lVar4 + (lVar10 + 2) * 16);
            *puVar2 = *puVar1;
            puVar2[1] = uVar5;
            puVar2[2] = uVar6;
            puVar2[3] = uVar7;
          } while ((int)index < (int)uVar9);
          lVar4 = *(int64 *)(this + 16);
          if (lVar4 == null) {
        LAB_181584f18:
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          if (*(uint32 *)(lVar4 + 24) <= index) {
            uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar8,0);
          }
          uVar8 = item[1];
          puVar3 = (uint64 *)(lVar4 + ((int64)(int)index + 2) * 16);
          *puVar3 = *item;
          puVar3[1] = uVar8;
          *(int *)(this + 24) = *(int *)(this + 24) + 1;
        }
    }

    // Token : 0x60002F4
    // RVA   : 0x1584400   Offset: 0x1583800   Length: 0xCC
    public bool Contains(T item)
    {
        long lVar1;
        long lVar2;
        bool cVar3;
        ulong uVar4;
        uint uVar5;
        uint local_28;
        uint uStack_24;
        uint uStack_20;
        uint32 uStack_1c;
        if ((*(int64 *)(this + 16) != 0) && (uVar5 = 0, 0 < *(int *)(this + 24))) {
          do {
            lVar1 = *(int64 *)(this + 16);
            if (lVar1 == null) {
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            local_28 = *item;
            uStack_24 = item[1];
            uStack_20 = item[2];
            uStack_1c = item[3];
            lVar2 = *(int64 *)(*(int64 *)(*(int64 *)(param_3 + 24) + 192) + 40);
            if ((*(byte *)(lVar2 + 0x132) & 1) == 0) {
              FUN_18009a510(lVar2);
            }
            uVar4 = il2cpp_value_box(lVar2,&local_28);
            if (*(uint32 *)(lVar1 + 24) <= uVar5) {
              uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar4,0);
            }
            cVar3 = Color.Equals(((int64)(int)uVar5 + 2) * 16 + lVar1,uVar4,0);
            if (cVar3) {
              return true;
            }
            uVar5 = uVar5 + 1;
          } while ((int)uVar5 < *(int *)(this + 24));
        }
        return false;
    }

    // Token : 0x60002F5
    // RVA   : 0x1584BD0   Offset: 0x1583FD0   Length: 0xD3
    public int IndexOf(T item)
    {
        long lVar1;
        long lVar2;
        bool cVar3;
        ulong uVar4;
        uint uVar5;
        uint local_28;
        uint uStack_24;
        uint uStack_20;
        uint32 uStack_1c;
        if ((*(int64 *)(this + 16) != 0) && (uVar5 = 0, 0 < *(int *)(this + 24))) {
          do {
            lVar1 = *(int64 *)(this + 16);
            if (lVar1 == null) {
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            local_28 = *item;
            uStack_24 = item[1];
            uStack_20 = item[2];
            uStack_1c = item[3];
            lVar2 = *(int64 *)(*(int64 *)(*(int64 *)(param_3 + 24) + 192) + 40);
            if ((*(byte *)(lVar2 + 0x132) & 1) == 0) {
              FUN_18009a510(lVar2);
            }
            uVar4 = il2cpp_value_box(lVar2,&local_28);
            if (*(uint32 *)(lVar1 + 24) <= uVar5) {
              uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar4,0);
            }
            cVar3 = Color.Equals(((int64)(int)uVar5 + 2) * 16 + lVar1,uVar4,0);
            if (cVar3) {
              return uVar5;
            }
            uVar5 = uVar5 + 1;
          } while ((int)uVar5 < *(int *)(this + 24));
        }
        return 0xffffffff;
    }

    // Token : 0x60002F6
    // RVA   : 0x1585E00   Offset: 0x1585200   Length: 0x1B2
    public bool Remove(T item)
    {
        long lVar4;
        uint uVar5;
        uint uVar6;
        uint uVar7;
        uint uVar8;
        ulong uVar10;
        uint uVar11;
        long lVar12;
        uint local_28;
        uint uStack_24;
        uint uStack_20;
        uint32 uStack_1c;
        uint32 local_18;
        uint32 uStack_14;
        uint32 uStack_10;
        uint32 uStack_c;
        if (*(int64 *)(this + 16) != 0) {
          puVar3 = *(uint64 **)(*(int64 *)(*(int64 *)(param_3 + 24) + 192) + 48);
          plVar9 = (int64 *)(*(code *)*puVar3)(puVar3);
          uVar11 = 0;
          in_RAX = plVar9;
          if (0 < *(int *)(this + 24)) {
            do {
              lVar4 = *(int64 *)(this + 16);
              if (lVar4 == null) throw; // [null/range check failed]
              if (*(uint32 *)(lVar4 + 24) <= uVar11) {
                uVar10 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar10,0);
              }
              if (plVar9 == (int64 *)0) throw; // [null/range check failed]
              puVar1 = (uint32 *)(lVar4 + ((int64)(int)uVar11 + 2) * 16);
              local_18 = *puVar1;
              uStack_14 = puVar1[1];
              uStack_10 = puVar1[2];
              uStack_c = puVar1[3];
              local_28 = *item;
              uStack_24 = item[1];
              uStack_20 = item[2];
              uStack_1c = item[3];
              in_RAX = (int64 *)
                       (**(code **)(*plVar9 + 0x1b8))
                                 (plVar9,&local_18,&local_28,*(uint64 *)(*plVar9 + 0x1c0));
              if ((char)in_RAX) {
                lVar4 = *(int64 *)(this + 16);
                *(int *)(this + 24) = *(int *)(this + 24) + -1;
                if (lVar4 == null) throw; // [null/range check failed]
                if (*(uint32 *)(lVar4 + 24) <= uVar11) {
                  uVar10 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1800d65f0(uVar10,0);
                }
                puVar3 = (uint64 *)(lVar4 + ((int64)(int)uVar11 + 2) * 16);
                *puVar3 = 0;
                puVar3[1] = 0;
                uVar8 = *(uint32 *)(this + 24);
                if ((int)uVar8 <= (int)uVar11) goto LAB_181585f3b;
                goto LAB_181585f00;
              }
              uVar11 = uVar11 + 1;
            } while ((int)uVar11 < *(int *)(this + 24));
          }
        }
        return (uint64)in_RAX & 0xffffffffffffff00;
        LAB_181585f00:
        do {
          lVar4 = *(int64 *)(this + 16);
          if (lVar4 == null) throw; // [null/range check failed]
          lVar12 = (int64)(int)uVar11;
          if (*(uint32 *)(lVar4 + 24) <= uVar11 + 1) {
            uVar10 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar10,0);
          }
          if (*(uint32 *)(lVar4 + 24) <= uVar11) {
            uVar10 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar10,0);
          }
          puVar1 = (uint32 *)(lVar4 + (lVar12 + 3) * 16);
          uVar5 = puVar1[1];
          uVar6 = puVar1[2];
          uVar7 = puVar1[3];
          uVar11 = uVar11 + 1;
          puVar2 = (uint32 *)(lVar4 + (lVar12 + 2) * 16);
          *puVar2 = *puVar1;
          puVar2[1] = uVar5;
          puVar2[2] = uVar6;
          puVar2[3] = uVar7;
          uVar8 = *(uint32 *)(this + 24);
        } while ((int)uVar11 < (int)uVar8);
        LAB_181585f3b:
        lVar4 = *(int64 *)(this + 16);
        if (lVar4 != null) {
          if (uVar8 < *(uint32 *)(lVar4 + 24)) {
            puVar3 = (uint64 *)(lVar4 + ((int64)(int)uVar8 + 2) * 16);
            *puVar3 = 0;
            puVar3[1] = 0;
            return CONCAT71((int7)((uint64)(((int64)(int)uVar8 + 2) * 2) >> 8),1);
          }
          uVar10 = il2cpp_internal();
                          // WARNING: Subroutine does not return
          FUN_1800d65f0(uVar10,0);
        }
    }

    // Token : 0x60002F7
    // RVA   : 0x15859D0   Offset: 0x1584DD0   Length: 0xF9
    public void RemoveAt(int index)
    {
        long lVar4;
        uint uVar5;
        uint uVar6;
        uint uVar7;
        uint uVar8;
        ulong uVar9;
        long lVar10;
        lVar4 = *(int64 *)(this + 16);
        if (((lVar4 != null) && (-1 < (int)index)) && ((int)index < *(int *)(this + 24))) {
          *(int *)(this + 24) = *(int *)(this + 24) + -1;
          if (*(uint32 *)(lVar4 + 24) <= index) {
            uVar9 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar9,0);
          }
          puVar1 = (uint64 *)(lVar4 + ((int64)(int)index + 2) * 16);
          *puVar1 = 0;
          puVar1[1] = 0;
          uVar8 = *(uint32 *)(this + 24);
          if ((int)index < (int)uVar8) {
            do {
              lVar4 = *(int64 *)(this + 16);
              if (lVar4 == null) goto LAB_181585a84;
              lVar10 = (int64)(int)index;
              if (*(uint32 *)(lVar4 + 24) <= index + 1) {
                uVar9 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar9,0);
              }
              if (*(uint32 *)(lVar4 + 24) <= index) {
                uVar9 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar9,0);
              }
              puVar2 = (uint32 *)(lVar4 + (lVar10 + 3) * 16);
              uVar5 = puVar2[1];
              uVar6 = puVar2[2];
              uVar7 = puVar2[3];
              index = index + 1;
              puVar3 = (uint32 *)(lVar4 + (lVar10 + 2) * 16);
              *puVar3 = *puVar2;
              puVar3[1] = uVar5;
              puVar3[2] = uVar6;
              puVar3[3] = uVar7;
              uVar8 = *(uint32 *)(this + 24);
            } while ((int)index < (int)uVar8);
          }
          lVar4 = *(int64 *)(this + 16);
          if (lVar4 == null) {
        LAB_181585a84:
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          if (*(uint32 *)(lVar4 + 24) <= uVar8) {
            uVar9 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar9,0);
          }
          puVar1 = (uint64 *)(lVar4 + ((int64)(int)uVar8 + 2) * 16);
          *puVar1 = 0;
          puVar1[1] = 0;
        }
    }

    // Token : 0x60002F8
    // RVA   : 0x1585580   Offset: 0x1584980   Length: 0x6A
    public T Pop()
    {
        int iVar2;
        long lVar3;
        ulong uVar4;
        lVar3 = *(int64 *)(param_2 + 16);
        if (lVar3 != null) {
          iVar2 = *(int *)(param_2 + 24);
          if (iVar2 != 0) {
            *(int *)(param_2 + 24) = iVar2 + -1;
            if (iVar2 - 1U < *(uint32 *)(lVar3 + 24)) {
              puVar1 = (uint64 *)(lVar3 + ((int64)iVar2 + 1) * 16);
              uVar4 = puVar1[1];
              *this = *puVar1;
              this[1] = uVar4;
              puVar1 = (uint64 *)(lVar3 + ((int64)iVar2 + 1) * 16);
              *puVar1 = 0;
              puVar1[1] = 0;
              return this;
            }
            uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar4,0);
          }
        }
        *this = 0;
        this[1] = 0;
        return this;
    }

    // Token : 0x60002F9
    // RVA   : 0x1586FD0   Offset: 0x15863D0   Length: 0x31
    public T[] ToArray()
    {
        if (this != 0) {
          puVar1 = *(uint64 **)(*(int64 *)(*(int64 *)(param_2 + 24) + 192) + 72);
          (*(code *)*puVar1)(this,puVar1);
          return *(uint64 *)(this + 16);
        }
    }

    // Token : 0x60002FA
    // RVA   : 0x1586C10   Offset: 0x1586010   Length: 0x196
    public void Sort(CompareFunc<T> comparer)
    {
        long lVar1;
        long lVar4;
        uint uVar6;
        uint uVar7;
        uint uVar8;
        uint uVar9;
        uint uVar10;
        uint uVar11;
        uint uVar12;
        int iVar14;
        ulong uVar15;
        uint uVar16;
        uint uVar17;
        uint uVar18;
        long lVar19;
        int iVar20;
        uint local_48;
        uint uStack_44;
        uint uStack_40;
        uint32 uStack_3c;
        uint32 local_38;
        uint32 uStack_34;
        uint32 uStack_30;
        uint32 uStack_2c;
        uVar17 = 0;
        iVar20 = *(int *)(this + 24) + -1;
        do {
          bVar13 = false;
          uVar16 = uVar17;
          if (iVar20 <= (int)uVar17) {
            return;
          }
          do {
            lVar4 = *(int64 *)(this + 16);
            if (lVar4 == null) {
        LAB_181586d51:
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            lVar19 = (int64)(int)uVar16;
            if (*(uint32 *)(lVar4 + 24) <= uVar16) {
              uVar15 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar15,0);
            }
            lVar1 = lVar19 + 2;
            uVar18 = uVar16 + 1;
            if (*(uint32 *)(lVar4 + 24) <= uVar18) {
              uVar15 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar15,0);
            }
            if (comparer == null) goto LAB_181586d51;
            puVar2 = (uint32 *)(lVar4 + (lVar19 + 3) * 16);
            local_48 = *puVar2;
            uStack_44 = puVar2[1];
            uStack_40 = puVar2[2];
            uStack_3c = puVar2[3];
            puVar2 = (uint32 *)(lVar4 + lVar1 * 16);
            local_38 = *puVar2;
            uStack_34 = puVar2[1];
            uStack_30 = puVar2[2];
            uStack_2c = puVar2[3];
            puVar5 = *(uint64 **)(*(int64 *)(*(int64 *)(param_3 + 24) + 192) + 80);
            iVar14 = (*(code *)*puVar5)(comparer,&local_38,&local_48,puVar5);
            if (iVar14 < 1) {
              if (!bVar13) {
                uVar17 = 0;
                if (uVar16 != 0) {
                  uVar17 = uVar16 - 1;
                }
              }
            }
            else {
              lVar4 = *(int64 *)(this + 16);
              if (lVar4 == null) goto LAB_181586d51;
              if (*(uint32 *)(lVar4 + 24) <= uVar16) {
                uVar15 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar15,0);
              }
              puVar2 = (uint32 *)(lVar4 + lVar1 * 16);
              uVar6 = *puVar2;
              uVar7 = puVar2[1];
              uVar8 = puVar2[2];
              uVar9 = puVar2[3];
              if (*(uint32 *)(lVar4 + 24) <= uVar18) {
                uVar15 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar15,0);
              }
              puVar2 = (uint32 *)(lVar4 + (lVar19 + 3) * 16);
              uVar10 = puVar2[1];
              uVar11 = puVar2[2];
              uVar12 = puVar2[3];
              puVar3 = (uint32 *)(lVar4 + lVar1 * 16);
              *puVar3 = *puVar2;
              puVar3[1] = uVar10;
              puVar3[2] = uVar11;
              puVar3[3] = uVar12;
              lVar4 = *(int64 *)(this + 16);
              if (lVar4 == null) goto LAB_181586d51;
              if (*(uint32 *)(lVar4 + 24) <= uVar18) {
                uVar15 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar15,0);
              }
              puVar2 = (uint32 *)(lVar4 + (lVar19 + 3) * 16);
              *puVar2 = uVar6;
              puVar2[1] = uVar7;
              puVar2[2] = uVar8;
              puVar2[3] = uVar9;
              bVar13 = true;
            }
            uVar16 = uVar16 + 1;
          } while ((int)uVar16 < iVar20);
          if (!bVar13) {
            return;
          }
        } while( true );
    }

    // Token : 0x60002FB
    // RVA   : 0x8B4920   Offset: 0x8B3D20   Length: 0x19
    public void /*ctor*/()
    {
        if (this != 0) {
          ZhSegment.Initialize(this,0);
          return;
        }
    }

}
