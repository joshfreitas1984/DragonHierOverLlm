// ============================================================
// Type  : HeroEquipmentData
// Token : 0x2000222
// ============================================================

public class HeroEquipmentData
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001059
    public float equipmentWeight;

    // Token: 0x400105A
    public int maxWeaponCount;

    // Token: 0x400105B
    public List<int> weaponSaveRecord;

    // Token: 0x400105C
    public List<ItemData> weapon;

    // Token: 0x400105D
    public int maxArmorCount;

    // Token: 0x400105E
    public List<int> armorSaveRecord;

    // Token: 0x400105F
    public List<ItemData> armor;

    // Token: 0x4001060
    public int maxHelmetCount;

    // Token: 0x4001061
    public List<int> helmetSaveRecord;

    // Token: 0x4001062
    public List<ItemData> helmet;

    // Token: 0x4001063
    public int maxShoesCount;

    // Token: 0x4001064
    public List<int> shoesSaveRecord;

    // Token: 0x4001065
    public List<ItemData> shoes;

    // Token: 0x4001066
    public int maxDecorationCount;

    // Token: 0x4001067
    public List<int> decorationSaveRecord;

    // Token: 0x4001068
    public List<ItemData> decoration;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x600123D
    // RVA   : 0x894A60   Offset: 0x893860   Length: 0x1CF
    public void /*ctor*/()
    {
        ulong uVar1;
        ulong uVar2;
        this.maxWeaponCount = 1;
        this.maxArmorCount = 1;
        this.maxHelmetCount = 1;
        this.maxShoesCount = 1;
        this.maxDecorationCount = 2;
        ZhSegment.Initialize(this,0);
        uVar1 = FUN_1801dfd90(DAT_181e83a78,this.maxWeaponCount);
        uVar2 = il2cpp_internal(DAT_181e740b8);
        FUN_1817673a0(uVar2,uVar1,DAT_181e72bf0);
        this.weapon = uVar2;
        uVar1 = FUN_1801dfd90(DAT_181e83a78,this.maxArmorCount);
        uVar2 = il2cpp_internal(DAT_181e740b8);
        FUN_1817673a0(uVar2,uVar1,DAT_181e72bf0);
        this.armor = uVar2;
        uVar1 = FUN_1801dfd90(DAT_181e83a78,this.maxHelmetCount);
        uVar2 = il2cpp_internal(DAT_181e740b8);
        FUN_1817673a0(uVar2,uVar1,DAT_181e72bf0);
        this.helmet = uVar2;
        uVar1 = FUN_1801dfd90(DAT_181e83a78,this.maxShoesCount);
        uVar2 = il2cpp_internal(DAT_181e740b8);
        FUN_1817673a0(uVar2,uVar1,DAT_181e72bf0);
        this.shoes = uVar2;
        uVar1 = FUN_1801dfd90(DAT_181e83a78,this.maxDecorationCount);
        uVar2 = il2cpp_internal(DAT_181e740b8);
        FUN_1817673a0(uVar2,uVar1,DAT_181e72bf0);
        this.decoration = uVar2;
    }

    // Token : 0x600123E
    // RVA   : 0x894740   Offset: 0x893540   Length: 0x319
    public void RecountEquipWeight()
    {
        float fVar1;
        long lVar2;
        uint uVar3;
        uint uVar4;
        long lVar5;
        long lVar6;
        lVar2 = this.weapon;
        uVar3 = 0;
        this.equipmentWeight = 0;
        if (lVar2 != null) {
          lVar6 = 32;
          lVar5 = 32;
          uVar4 = uVar3;
          while ((int)uVar4 < lVar2.Count) {
            if (lVar2 == null) throw; // [null/range check failed]
            if (lVar2.Count <= uVar4) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            if (*(int64 *)(lVar5 + lVar2._items) != 0) {
              fVar1 = this.equipmentWeight;
              if ((this.weapon == null) ||
                 (lVar2 = FUN_1800024b0(this.weapon,uVar4,DAT_181e73170)) == null)
              throw; // [null/range check failed]
              this.equipmentWeight = fVar1 + *(float *)(lVar2 + 68);
            }
            lVar2 = this.weapon;
            uVar4 = uVar4 + 1;
            lVar5 = lVar5 + 8;
            if (lVar2 == null) throw; // [null/range check failed]
          }
          lVar2 = this.armor;
          if (lVar2 != null) {
            lVar5 = 32;
            uVar4 = uVar3;
            goto LAB_180894837;
          }
        }
        throw; // [null/range check failed]
        LAB_180894837:
        if (lVar2.Count <= (int)uVar4) {
          lVar2 = this.helmet;
          if (lVar2 != null) {
            lVar5 = 32;
            uVar4 = uVar3;
            goto LAB_1808948c0;
          }
          throw; // [null/range check failed]
        }
        if (lVar2 == null) throw; // [null/range check failed]
        if (lVar2.Count <= uVar4) {
          ThrowHelper.ThrowArgumentOutOfRangeException(0);
        }
        if (*(int64 *)(lVar5 + lVar2._items) != 0) {
          fVar1 = this.equipmentWeight;
          if ((this.armor == null) ||
             (lVar2 = FUN_1800024b0(this.armor,uVar4,DAT_181e73170)) == null)
          throw; // [null/range check failed]
          this.equipmentWeight = fVar1 + *(float *)(lVar2 + 68);
        }
        lVar2 = this.armor;
        uVar4 = uVar4 + 1;
        lVar5 = lVar5 + 8;
        if (lVar2 == null) throw; // [null/range check failed]
        goto LAB_180894837;
        LAB_1808948c0:
        if (lVar2.Count <= (int)uVar4) {
          lVar2 = this.shoes;
          if (lVar2 != null) {
            lVar5 = 32;
            uVar4 = uVar3;
            goto LAB_180894947;
          }
          throw; // [null/range check failed]
        }
        if (lVar2 == null) throw; // [null/range check failed]
        if (lVar2.Count <= uVar4) {
          ThrowHelper.ThrowArgumentOutOfRangeException(0);
        }
        if (*(int64 *)(lVar5 + lVar2._items) != 0) {
          fVar1 = this.equipmentWeight;
          if ((this.helmet == null) ||
             (lVar2 = FUN_1800024b0(this.helmet,uVar4,DAT_181e73170)) == null)
          throw; // [null/range check failed]
          this.equipmentWeight = fVar1 + *(float *)(lVar2 + 68);
        }
        lVar2 = this.helmet;
        uVar4 = uVar4 + 1;
        lVar5 = lVar5 + 8;
        if (lVar2 == null) throw; // [null/range check failed]
        goto LAB_1808948c0;
        LAB_180894947:
        if (lVar2.Count <= (int)uVar4) {
          lVar2 = this.decoration;
          if (lVar2 != null) goto LAB_1808949d0;
          throw; // [null/range check failed]
        }
        if (lVar2 == null) throw; // [null/range check failed]
        if (lVar2.Count <= uVar4) {
          ThrowHelper.ThrowArgumentOutOfRangeException(0);
        }
        if (*(int64 *)(lVar5 + lVar2._items) != 0) {
          fVar1 = this.equipmentWeight;
          if ((this.shoes == null) ||
             (lVar2 = FUN_1800024b0(this.shoes,uVar4,DAT_181e73170)) == null)
          throw; // [null/range check failed]
          this.equipmentWeight = fVar1 + *(float *)(lVar2 + 68);
        }
        lVar2 = this.shoes;
        uVar4 = uVar4 + 1;
        lVar5 = lVar5 + 8;
        if (lVar2 == null) throw; // [null/range check failed]
        goto LAB_180894947;
        while( true ) {
          if (lVar2.Count <= uVar3) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          if (*(int64 *)(lVar6 + lVar2._items) != 0) {
            fVar1 = this.equipmentWeight;
            if ((this.decoration == null) ||
               (lVar2 = FUN_1800024b0(this.decoration,uVar3,DAT_181e73170)) == null)
            break;
            this.equipmentWeight = fVar1 + *(float *)(lVar2 + 68);
          }
          lVar2 = this.decoration;
          uVar3 = uVar3 + 1;
          lVar6 = lVar6 + 8;
          if (lVar2 == null) break;
        LAB_1808949d0:
          if (lVar2.Count <= (int)uVar3) {
            return;
          }
          if (lVar2 == null) break;
        }
    }

    // Token : 0x600123F
    // RVA   : 0x894520   Offset: 0x893320   Length: 0x21D
    public bool HaveEmptyEquipment()
    {
        ulong uVar1;
        long lVar2;
        long lVar3;
        uint uVar4;
        uint uVar5;
        long lVar6;
        lVar2 = this.weapon;
        uVar5 = 0;
        if (lVar2 != null) {
          lVar6 = 32;
          lVar3 = 32;
          uVar4 = uVar5;
          do {
            if (lVar2.Count <= (int)uVar4) {
              lVar2 = this.armor;
              if (lVar2 != null) {
                lVar3 = 32;
                uVar4 = uVar5;
                goto LAB_1808945e0;
              }
              break;
            }
            if (lVar2 == null) break;
            if (lVar2.Count <= uVar4) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            lVar2 = lVar2._items;
            if (*(int64 *)(lVar2 + lVar3) == 0) goto LAB_18089471a;
            lVar2 = this.weapon;
            uVar4 = uVar4 + 1;
            lVar3 = lVar3 + 8;
          } while (lVar2 != null);
        }
        throw; // [null/range check failed]
        while( true ) {
          if (lVar2 == null) break;
          if (lVar2.Count <= uVar4) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          lVar2 = lVar2._items;
          if (*(int64 *)(lVar2 + lVar3) == 0) goto LAB_18089471a;
          lVar2 = this.armor;
          uVar4 = uVar4 + 1;
          lVar3 = lVar3 + 8;
          if (lVar2 == null) break;
        LAB_1808945e0:
          if (lVar2.Count <= (int)uVar4) {
            lVar2 = this.helmet;
            if (lVar2 != null) {
              lVar3 = 32;
              uVar4 = uVar5;
              goto LAB_180894638;
            }
            break;
          }
        }
        throw; // [null/range check failed]
        while( true ) {
          if (lVar2 == null) break;
          if (lVar2.Count <= uVar4) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          lVar2 = lVar2._items;
          if (*(int64 *)(lVar2 + lVar3) == 0) goto LAB_18089471a;
          lVar2 = this.helmet;
          uVar4 = uVar4 + 1;
          lVar3 = lVar3 + 8;
          if (lVar2 == null) break;
        LAB_180894638:
          if (lVar2.Count <= (int)uVar4) {
            lVar2 = this.shoes;
            if (lVar2 != null) {
              lVar3 = 32;
              uVar4 = uVar5;
              goto LAB_180894690;
            }
            break;
          }
        }
        throw; // [null/range check failed]
        joined_r0x0001808946d6:
        if (uVar1 == 0) throw; // [null/range check failed]
        if (uVar1.Count <= (int)uVar5) {
          return uVar1 & 0xffffffffffffff00;
        }
        if (uVar1 == 0) throw; // [null/range check failed]
        if (uVar1.Count <= uVar5) {
          ThrowHelper.ThrowArgumentOutOfRangeException(0);
        }
        lVar2 = uVar1._items;
        if (*(int64 *)(lVar6 + lVar2) == 0) {
        LAB_18089471a:
          return CONCAT71((int7)((uint64)lVar2 >> 8),1);
        }
        uVar1 = this.decoration;
        uVar5 = uVar5 + 1;
        lVar6 = lVar6 + 8;
        goto joined_r0x0001808946d6;
        while( true ) {
          if (lVar2.Count <= uVar4) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          lVar2 = lVar2._items;
          if (*(int64 *)(lVar2 + lVar3) == 0) goto LAB_18089471a;
          lVar2 = this.shoes;
          uVar4 = uVar4 + 1;
          lVar3 = lVar3 + 8;
          if (lVar2 == null) break;
        LAB_180894690:
          if (lVar2.Count <= (int)uVar4) {
            uVar1 = this.decoration;
            goto joined_r0x0001808946d6;
          }
          if (lVar2 == null) break;
        }
    }

    // Token : 0x6001240
    // RVA   : 0x8943A0   Offset: 0x8931A0   Length: 0x175
    public virtual object Clone()
    {
        long lVar2;
        ulong uVar3;
        ulong local_38;
        ulong uStack_30;
        uint local_28;
        uint uStack_24;
        uint uStack_20;
        uint32 uStack_1c;
        plVar1 = (int64 *)il2cpp_internal(DAT_181e695f0);
        plVar4 = plVar1;
        MemoryStream.ctor(plVar1,1000,0);
        local_38 = 0;
        uStack_30 = 0;
        StreamingContext.ctor(&local_38,64,0);
        lVar2 = il2cpp_internal(DAT_181e91a00);
        local_28 = (uint32)local_38;
        uStack_24 = local_38._4_4_;
        uStack_20 = (uint32)uStack_30;
        uStack_1c = uStack_30._4_4_;
        BinaryFormatter.ctor(lVar2,0,&local_28,0,plVar4);
        if (lVar2 != null) {
          BinaryFormatter.Serialize(lVar2,plVar1,this,0);
          if (plVar1 != (int64 *)0) {
            (**(code **)(*plVar1 + 0x2c8))(plVar1,0,0,*(uint64 *)(*plVar1 + 0x2d0));
            uVar3 = BinaryFormatter.Deserialize(lVar2,plVar1,0);
            (**(code **)(*plVar1 + 0x238))(plVar1,*(uint64 *)(*plVar1 + 0x240));
            FUN_180002280(0,DAT_181e58ab8,plVar1);
            return uVar3;
          }
                          // WARNING: Subroutine does not return
          FUN_1801e0300();
        }
    }

}
