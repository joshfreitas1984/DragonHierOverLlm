// ============================================================
// Type  : HeroEquipmentData
// Token : 0x2000220
// ============================================================

public class HeroEquipmentData
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001043
    public float equipmentWeight;

    // Token: 0x4001044
    public int maxWeaponCount;

    // Token: 0x4001045
    public List<int> weaponSaveRecord;

    // Token: 0x4001046
    public List<ItemData> weapon;

    // Token: 0x4001047
    public int maxArmorCount;

    // Token: 0x4001048
    public List<int> armorSaveRecord;

    // Token: 0x4001049
    public List<ItemData> armor;

    // Token: 0x400104A
    public int maxHelmetCount;

    // Token: 0x400104B
    public List<int> helmetSaveRecord;

    // Token: 0x400104C
    public List<ItemData> helmet;

    // Token: 0x400104D
    public int maxShoesCount;

    // Token: 0x400104E
    public List<int> shoesSaveRecord;

    // Token: 0x400104F
    public List<ItemData> shoes;

    // Token: 0x4001050
    public int maxDecorationCount;

    // Token: 0x4001051
    public List<int> decorationSaveRecord;

    // Token: 0x4001052
    public List<ItemData> decoration;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6001230
    // RVA   : 0xAF23C0   Offset: 0xAF17C0   Length: 0x1CF
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
        uVar1 = FUN_1800d60b0(DAT_181da3920,this.maxWeaponCount);
        uVar2 = il2cpp_internal(DAT_181d940d0);
        FUN_181827480(uVar2,uVar1,DAT_181d90a18);
        this.weapon = uVar2;
        uVar1 = FUN_1800d60b0(DAT_181da3920,this.maxArmorCount);
        uVar2 = il2cpp_internal(DAT_181d940d0);
        FUN_181827480(uVar2,uVar1,DAT_181d90a18);
        this.armor = uVar2;
        uVar1 = FUN_1800d60b0(DAT_181da3920,this.maxHelmetCount);
        uVar2 = il2cpp_internal(DAT_181d940d0);
        FUN_181827480(uVar2,uVar1,DAT_181d90a18);
        this.helmet = uVar2;
        uVar1 = FUN_1800d60b0(DAT_181da3920,this.maxShoesCount);
        uVar2 = il2cpp_internal(DAT_181d940d0);
        FUN_181827480(uVar2,uVar1,DAT_181d90a18);
        this.shoes = uVar2;
        uVar1 = FUN_1800d60b0(DAT_181da3920,this.maxDecorationCount);
        uVar2 = il2cpp_internal(DAT_181d940d0);
        FUN_181827480(uVar2,uVar1,DAT_181d90a18);
        this.decoration = uVar2;
    }

    // Token : 0x6001231
    // RVA   : 0xAF20A0   Offset: 0xAF14A0   Length: 0x319
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
                 (lVar2 = FUN_180002f80(this.weapon,uVar4,DAT_181d90f18)) == null)
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
            goto LAB_180af2197;
          }
        }
        throw; // [null/range check failed]
        LAB_180af2197:
        if (lVar2.Count <= (int)uVar4) {
          lVar2 = this.helmet;
          if (lVar2 != null) {
            lVar5 = 32;
            uVar4 = uVar3;
            goto LAB_180af2220;
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
             (lVar2 = FUN_180002f80(this.armor,uVar4,DAT_181d90f18)) == null)
          throw; // [null/range check failed]
          this.equipmentWeight = fVar1 + *(float *)(lVar2 + 68);
        }
        lVar2 = this.armor;
        uVar4 = uVar4 + 1;
        lVar5 = lVar5 + 8;
        if (lVar2 == null) throw; // [null/range check failed]
        goto LAB_180af2197;
        LAB_180af2220:
        if (lVar2.Count <= (int)uVar4) {
          lVar2 = this.shoes;
          if (lVar2 != null) {
            lVar5 = 32;
            uVar4 = uVar3;
            goto LAB_180af22a7;
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
             (lVar2 = FUN_180002f80(this.helmet,uVar4,DAT_181d90f18)) == null)
          throw; // [null/range check failed]
          this.equipmentWeight = fVar1 + *(float *)(lVar2 + 68);
        }
        lVar2 = this.helmet;
        uVar4 = uVar4 + 1;
        lVar5 = lVar5 + 8;
        if (lVar2 == null) throw; // [null/range check failed]
        goto LAB_180af2220;
        LAB_180af22a7:
        if (lVar2.Count <= (int)uVar4) {
          lVar2 = this.decoration;
          if (lVar2 != null) goto LAB_180af2330;
          throw; // [null/range check failed]
        }
        if (lVar2 == null) throw; // [null/range check failed]
        if (lVar2.Count <= uVar4) {
          ThrowHelper.ThrowArgumentOutOfRangeException(0);
        }
        if (*(int64 *)(lVar5 + lVar2._items) != 0) {
          fVar1 = this.equipmentWeight;
          if ((this.shoes == null) ||
             (lVar2 = FUN_180002f80(this.shoes,uVar4,DAT_181d90f18)) == null)
          throw; // [null/range check failed]
          this.equipmentWeight = fVar1 + *(float *)(lVar2 + 68);
        }
        lVar2 = this.shoes;
        uVar4 = uVar4 + 1;
        lVar5 = lVar5 + 8;
        if (lVar2 == null) throw; // [null/range check failed]
        goto LAB_180af22a7;
        while( true ) {
          if (lVar2.Count <= uVar3) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          if (*(int64 *)(lVar6 + lVar2._items) != 0) {
            fVar1 = this.equipmentWeight;
            if ((this.decoration == null) ||
               (lVar2 = FUN_180002f80(this.decoration,uVar3,DAT_181d90f18)) == null)
            break;
            this.equipmentWeight = fVar1 + *(float *)(lVar2 + 68);
          }
          lVar2 = this.decoration;
          uVar3 = uVar3 + 1;
          lVar6 = lVar6 + 8;
          if (lVar2 == null) break;
        LAB_180af2330:
          if (lVar2.Count <= (int)uVar3) {
            return;
          }
          if (lVar2 == null) break;
        }
    }

    // Token : 0x6001232
    // RVA   : 0xAF1E80   Offset: 0xAF1280   Length: 0x21D
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
                goto LAB_180af1f40;
              }
              break;
            }
            if (lVar2 == null) break;
            if (lVar2.Count <= uVar4) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            lVar2 = lVar2._items;
            if (*(int64 *)(lVar2 + lVar3) == 0) goto LAB_180af207a;
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
          if (*(int64 *)(lVar2 + lVar3) == 0) goto LAB_180af207a;
          lVar2 = this.armor;
          uVar4 = uVar4 + 1;
          lVar3 = lVar3 + 8;
          if (lVar2 == null) break;
        LAB_180af1f40:
          if (lVar2.Count <= (int)uVar4) {
            lVar2 = this.helmet;
            if (lVar2 != null) {
              lVar3 = 32;
              uVar4 = uVar5;
              goto LAB_180af1f98;
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
          if (*(int64 *)(lVar2 + lVar3) == 0) goto LAB_180af207a;
          lVar2 = this.helmet;
          uVar4 = uVar4 + 1;
          lVar3 = lVar3 + 8;
          if (lVar2 == null) break;
        LAB_180af1f98:
          if (lVar2.Count <= (int)uVar4) {
            lVar2 = this.shoes;
            if (lVar2 != null) {
              lVar3 = 32;
              uVar4 = uVar5;
              goto LAB_180af1ff0;
            }
            break;
          }
        }
        throw; // [null/range check failed]
        joined_r0x000180af2036:
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
        LAB_180af207a:
          return CONCAT71((int7)((uint64)lVar2 >> 8),1);
        }
        uVar1 = this.decoration;
        uVar5 = uVar5 + 1;
        lVar6 = lVar6 + 8;
        goto joined_r0x000180af2036;
        while( true ) {
          if (lVar2.Count <= uVar4) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          lVar2 = lVar2._items;
          if (*(int64 *)(lVar2 + lVar3) == 0) goto LAB_180af207a;
          lVar2 = this.shoes;
          uVar4 = uVar4 + 1;
          lVar3 = lVar3 + 8;
          if (lVar2 == null) break;
        LAB_180af1ff0:
          if (lVar2.Count <= (int)uVar4) {
            uVar1 = this.decoration;
            goto joined_r0x000180af2036;
          }
          if (lVar2 == null) break;
        }
    }

    // Token : 0x6001233
    // RVA   : 0xAF1D00   Offset: 0xAF1100   Length: 0x175
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
        plVar1 = (int64 *)il2cpp_internal(DAT_181d89210);
        plVar4 = plVar1;
        MemoryStream.ctor(plVar1,1000,0);
        local_38 = 0;
        uStack_30 = 0;
        StreamingContext.ctor(&local_38,64,0);
        lVar2 = il2cpp_internal(DAT_181db1730);
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
            FUN_180002970(0,DAT_181d78da0,plVar1);
            return uVar3;
          }
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
    }

}
