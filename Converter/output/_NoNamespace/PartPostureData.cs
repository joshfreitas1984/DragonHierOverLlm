// ============================================================
// Type  : PartPostureData
// Token : 0x2000223
// ============================================================

public class PartPostureData
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x40010C0
    public List<float> partPosture;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6001249
    // RVA   : 0x474400   Offset: 0x472C00   Length: 0xFC
    public void /*ctor*/()
    {
        var plVar5 = *(int64*)(lVar5 + 184);
        long lVar2;
        long lVar3;
        bool cVar4;
        long lVar5;
        long lVar6;
        ulong uVar7;
        int iVar8;
        uint uVar9;
        ZhSegment.Initialize(this,0);
        lVar5 = il2cpp_internal(DAT_181d721b0);
        FUN_180f58a90(lVar5,DAT_181d79358);
        if (lVar5 != null) {
          FUN_181805690(lVar5,0,DAT_181d79458);
          FUN_181805690(lVar5,0,DAT_181d79458);
          FUN_181805690(lVar5,0,DAT_181d79458);
          FUN_181805690(lVar5,0,DAT_181d79458);
          FUN_181805690(lVar5,0,DAT_181d79458);
          FUN_181805690(lVar5,0,DAT_181d79458);
          this.partPosture = lVar5;
          lVar5 = FUN_1800d60b0(DAT_181d7c118,1);
          if (lVar5 != null) {
            if (*(int *)(lVar5 + 24) == 0) {
              uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar7,0);
            }
            *(uint16 *)(lVar5 + 32) = 59;
            if (param_2 != 0) {
              lVar6 = String.Split(param_2,lVar5,0);
              uVar9 = 0;
              lVar5 = DAT_181d4ef00;
              if (lVar6 != null) {
                do {
                  if (*(int *)(lVar6 + 24) <= (int)uVar9) {
                    return;
                  }
                  iVar8 = 0;
                  while( true ) {
                    if (((*(byte *)(lVar5 + 0x133) & 4) != 0) && (*(int *)(lVar5 + 224) == 0)) {
                      il2cpp_runtime_class_init();
                      lVar5 = DAT_181d4ef00;
                    }
                    lVar2 = *(int64 *)(plVar5 + 0x5e8);
                    if (lVar2 == null) throw; // [null/range check failed]
                    if (*(int *)(lVar2 + 24) <= iVar8) break;
                    if (*(uint32 *)(lVar6 + 24) <= uVar9) {
                      uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                      FUN_1800d65f0(uVar7,0);
                    }
                    lVar2 = lVar6[uVar9];
                    if (((*(byte *)(lVar5 + 0x133) & 4) != 0) && (*(int *)(lVar5 + 224) == 0)) {
                      il2cpp_runtime_class_init();
                      lVar5 = DAT_181d4ef00;
                    }
                    lVar5 = *(int64 *)(plVar5 + 0x5e8);
                    if ((lVar5 == null) || (uVar7 = FUN_180002f80(lVar5,iVar8,DAT_181d7c9c0), lVar2 == null))
                    throw; // [null/range check failed]
                    cVar4 = String.Contains(lVar2,uVar7,0);
                    if (cVar4) {
                      lVar5 = *plVar1;
                      if (*(uint32 *)(lVar6 + 24) <= uVar9) {
                        uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                        FUN_1800d65f0(uVar7,0);
                      }
                      lVar2 = lVar6[uVar9];
                      lVar3 = *(int64 *)(*(int64 *)(DAT_181d4ef00 + 184) + 0x5e8);
                      if ((lVar3 == null) || (uVar7 = FUN_180002f80(lVar3,iVar8,DAT_181d7c9c0), lVar2 == null))
                      throw; // [null/range check failed]
                      uVar7 = String.Replace(lVar2,uVar7,"",0);
                      Int32.Parse(uVar7,0);
                      if (lVar5 == null) throw; // [null/range check failed]
                      FUN_181814d10(lVar5,iVar8);
                    }
                    iVar8 = iVar8 + 1;
                    lVar5 = DAT_181d4ef00;
                  }
                  uVar9 = uVar9 + 1;
                } while( true );
              }
            }
          }
        }
    }

    // Token : 0x600124A
    // RVA   : 0x474500   Offset: 0x472D00   Length: 0x367
    public void /*ctor*/(string resource)
    {
        var plVar5 = *(int64*)(lVar5 + 184);
        long lVar2;
        long lVar3;
        bool cVar4;
        long lVar5;
        long lVar6;
        ulong uVar7;
        int iVar8;
        uint uVar9;
        ZhSegment.Initialize(this,0);
        lVar5 = il2cpp_internal(DAT_181d721b0);
        FUN_180f58a90(lVar5,DAT_181d79358);
        if (lVar5 != null) {
          FUN_181805690(lVar5,0,DAT_181d79458);
          FUN_181805690(lVar5,0,DAT_181d79458);
          FUN_181805690(lVar5,0,DAT_181d79458);
          FUN_181805690(lVar5,0,DAT_181d79458);
          FUN_181805690(lVar5,0,DAT_181d79458);
          FUN_181805690(lVar5,0,DAT_181d79458);
          this.partPosture = lVar5;
          lVar5 = FUN_1800d60b0(DAT_181d7c118,1);
          if (lVar5 != null) {
            if (*(int *)(lVar5 + 24) == 0) {
              uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar7,0);
            }
            *(uint16 *)(lVar5 + 32) = 59;
            if (resource != null) {
              lVar6 = String.Split(resource,lVar5,0);
              uVar9 = 0;
              lVar5 = DAT_181d4ef00;
              if (lVar6 != null) {
                do {
                  if (*(int *)(lVar6 + 24) <= (int)uVar9) {
                    return;
                  }
                  iVar8 = 0;
                  while( true ) {
                    if (((*(byte *)(lVar5 + 0x133) & 4) != 0) && (*(int *)(lVar5 + 224) == 0)) {
                      il2cpp_runtime_class_init();
                      lVar5 = DAT_181d4ef00;
                    }
                    lVar2 = *(int64 *)(plVar5 + 0x5e8);
                    if (lVar2 == null) throw; // [null/range check failed]
                    if (*(int *)(lVar2 + 24) <= iVar8) break;
                    if (*(uint32 *)(lVar6 + 24) <= uVar9) {
                      uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                      FUN_1800d65f0(uVar7,0);
                    }
                    lVar2 = lVar6[uVar9];
                    if (((*(byte *)(lVar5 + 0x133) & 4) != 0) && (*(int *)(lVar5 + 224) == 0)) {
                      il2cpp_runtime_class_init();
                      lVar5 = DAT_181d4ef00;
                    }
                    lVar5 = *(int64 *)(plVar5 + 0x5e8);
                    if ((lVar5 == null) || (uVar7 = FUN_180002f80(lVar5,iVar8,DAT_181d7c9c0), lVar2 == null))
                    throw; // [null/range check failed]
                    cVar4 = String.Contains(lVar2,uVar7,0);
                    if (cVar4) {
                      lVar5 = *plVar1;
                      if (*(uint32 *)(lVar6 + 24) <= uVar9) {
                        uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                        FUN_1800d65f0(uVar7,0);
                      }
                      lVar2 = lVar6[uVar9];
                      lVar3 = *(int64 *)(*(int64 *)(DAT_181d4ef00 + 184) + 0x5e8);
                      if ((lVar3 == null) || (uVar7 = FUN_180002f80(lVar3,iVar8,DAT_181d7c9c0), lVar2 == null))
                      throw; // [null/range check failed]
                      uVar7 = String.Replace(lVar2,uVar7,"",0);
                      Int32.Parse(uVar7,0);
                      if (lVar5 == null) throw; // [null/range check failed]
                      FUN_181814d10(lVar5,iVar8);
                    }
                    iVar8 = iVar8 + 1;
                    lVar5 = DAT_181d4ef00;
                  }
                  uVar9 = uVar9 + 1;
                } while( true );
              }
            }
          }
        }
    }

    // Token : 0x600124B
    // RVA   : 0x4737E0   Offset: 0x471FE0   Length: 0x9E
    public void ChangePosture(int id, float num)
    {
        long lVar1;
        uint uVar2;
        lVar1 = this.partPosture;
        if (lVar1 != null) {
          if (lVar1.Count <= id) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          uVar2 = FUN_1810a8ba0(*(float *)(lVar1._items + 32 + (int64)(int)id * 4
                                          ) + num,0,0x42c80000,0);
          FUN_181814d10(lVar1,id,uVar2,DAT_181d79758);
          return;
        }
    }

    // Token : 0x600124C
    // RVA   : 0x473760   Offset: 0x471F60   Length: 0x80
    public void ChangeMulti(float changeRate)
    {
        ulong uVar1;
        uVar1 = this.partPosture;
        uVar1 = GlobalData.ListMulti(uVar1,changeRate,0);
        this.partPosture = uVar1;
    }

    // Token : 0x600124D
    // RVA   : 0x4742F0   Offset: 0x472AF0   Length: 0xF2
    public void Reset()
    {
        long lVar1;
        lVar1 = il2cpp_internal(DAT_181d721b0);
        FUN_180f58a90(lVar1,DAT_181d79358);
        if (lVar1 != null) {
          FUN_181805690(lVar1,0,DAT_181d79458);
          FUN_181805690(lVar1,0,DAT_181d79458);
          FUN_181805690(lVar1,0,DAT_181d79458);
          FUN_181805690(lVar1,0,DAT_181d79458);
          FUN_181805690(lVar1,0,DAT_181d79458);
          FUN_181805690(lVar1,0,DAT_181d79458);
          this.partPosture = lVar1;
          return;
        }
    }

    // Token : 0x600124E
    // RVA   : 0x474220   Offset: 0x472A20   Length: 0xC1
    public bool IsEmpty()
    {
        long lVar1;
        long lVar2;
        uint uVar3;
        lVar1 = this.partPosture;
        uVar3 = 0;
        if (lVar1 != null) {
          lVar2 = 32;
          do {
            if (lVar1.Count <= (int)uVar3) {
              return CONCAT71((int7)((uint64)lVar1 >> 8),1);
            }
            if (lVar1 == null) break;
            if (lVar1.Count <= uVar3) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            if (*(float *)(lVar2 + lVar1._items) != 0.0) {
              return lVar1._items & 0xffffffffffffff00;
            }
            lVar1 = this.partPosture;
            uVar3 = uVar3 + 1;
            lVar2 = lVar2 + 4;
          } while (lVar1 != null);
        }
    }

    // Token : 0x600124F
    // RVA   : 0x474160   Offset: 0x472960   Length: 0xBF
    public bool HavePosture(float minPosture)
    {
        ulong uVar1;
        long lVar2;
        uint uVar3;
        uVar1 = this.partPosture;
        uVar3 = 0;
        if (uVar1 != 0) {
          lVar2 = 32;
          do {
            if (uVar1.Count <= (int)uVar3) {
              return uVar1 & 0xffffffffffffff00;
            }
            if (uVar1 == 0) break;
            if (uVar1.Count <= uVar3) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            if (minPosture <= *(float *)(lVar2 + uVar1._items)) {
              return CONCAT71((int7)((uint64)uVar1._items >> 8),1);
            }
            uVar1 = this.partPosture;
            uVar3 = uVar3 + 1;
            lVar2 = lVar2 + 4;
          } while (uVar1 != 0);
        }
    }

    // Token : 0x6001250
    // RVA   : 0x4743F0   Offset: 0x472BF0   Length: 0xB
    public float TotalNum()
    {
        Enumerable.Sum(this.partPosture,0);
    }

    // Token : 0x6001251
    // RVA   : 0x473A00   Offset: 0x472200   Length: 0x1BA
    public PartPostureData GetChangePartStateResult(PartPostureData changeData)
    {
        float fVar1;
        long lVar2;
        long lVar4;
        uint uVar5;
        long lVar6;
        uint uVar7;
        plVar3 = (int64 *)PartPostureData.Clone(this,0);
        uVar5 = 0;
        lVar4 = this.partPosture;
        if (lVar4 != null) {
          lVar6 = 32;
          while( true ) {
            if (lVar4.Count <= (int)uVar5) {
              return plVar3;
            }
            if ((plVar3 == (int64 *)0) || (lVar4 = plVar3[2]) == null) break;
            if (lVar4.Count <= uVar5) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            fVar1 = *(float *)(lVar6 + lVar4._items);
            if ((changeData == null) || (lVar2 = *(int64 *)(changeData + 16)) == null) break;
            if (*(uint32 *)(lVar2 + 24) <= uVar5) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            uVar7 = FUN_1810a8ba0(*(float *)(lVar6 + *(int64 *)(lVar2 + 16)) + fVar1,0,0x42c80000,0);
            FUN_181814d10(lVar4,uVar5,uVar7);
            lVar4 = this.partPosture;
            uVar5 = uVar5 + 1;
            lVar6 = lVar6 + 4;
            if (lVar4 == null) break;
          }
        }
    }

    // Token : 0x6001252
    // RVA   : 0x473BC0   Offset: 0x4723C0   Length: 0x1B3
    public PartPostureData GetDelta(PartPostureData changeData)
    {
        float fVar1;
        long lVar2;
        long lVar4;
        uint uVar5;
        long lVar6;
        uint uVar7;
        plVar3 = (int64 *)PartPostureData.Clone(this,0);
        uVar5 = 0;
        if (changeData == null) {
          return plVar3;
        }
        lVar4 = this.partPosture;
        if (lVar4 != null) {
          lVar6 = 32;
          do {
            if (lVar4.Count <= (int)uVar5) {
              return plVar3;
            }
            if ((plVar3 == (int64 *)0) || (lVar4 = plVar3[2]) == null) break;
            if (lVar4.Count <= uVar5) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            lVar2 = *(int64 *)(changeData + 16);
            fVar1 = *(float *)(lVar6 + lVar4._items);
            if (lVar2 == null) break;
            if (*(uint32 *)(lVar2 + 24) <= uVar5) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            uVar7 = FUN_1810a8ba0(fVar1 - *(float *)(lVar6 + *(int64 *)(lVar2 + 16)),0,0x42c80000,0);
            FUN_181814d10(lVar4,uVar5,uVar7);
            lVar4 = this.partPosture;
            uVar5 = uVar5 + 1;
            lVar6 = lVar6 + 4;
          } while (lVar4 != null);
        }
    }

    // Token : 0x6001253
    // RVA   : 0x473F80   Offset: 0x472780   Length: 0x1D6
    public string GetStateDescribe()
    {
        long lVar1;
        bool cVar2;
        ulong uVar3;
        ulong uVar4;
        ulong uVar5;
        ulong uVar6;
        int iVar7;
        float[] local_res8 = new float[2];
        lVar1 = this.partPosture;
        iVar7 = 0;
        local_res8[0] = 0.0;
        uVar5 = "";
        while (lVar1 != null) {
          if (lVar1.Count <= iVar7) {
            return uVar5;
          }
          cVar2 = FUN_1816fd990(uVar5,"",0);
          uVar6 = "";
          if ((!cVar2) && (uVar6 = "|", iVar7 == 3)) {
            uVar6 = "\n";
          }
          lVar1 = *(int64 *)(*(int64 *)(DAT_181d4ef00 + 184) + 0x5e8);
          if (lVar1 == null) break;
          uVar3 = FUN_180002f80(lVar1,iVar7,DAT_181d7c9c0);
          if (this.partPosture == null) break;
          local_res8[0] = (float)FUN_1800d6780(this.partPosture,iVar7,DAT_181d796d8);
          local_res8[0] = 100.0 - local_res8[0];
          uVar4 = Single.ToString(local_res8,"f0",0);
          uVar5 = String.Concat(uVar5,uVar6,uVar3,uVar4,0);
          iVar7 = iVar7 + 1;
          lVar1 = this.partPosture;
        }
    }

    // Token : 0x6001254
    // RVA   : 0x473D80   Offset: 0x472580   Length: 0x1F2
    public string GetSkillDescribe()
    {
        bool cVar1;
        long lVar2;
        ulong uVar3;
        ulong uVar4;
        ulong uVar5;
        uint uVar6;
        long lVar7;
        ulong uVar8;
        uint[] local_res8 = new uint[2];
        lVar2 = this.partPosture;
        uVar6 = 0;
        local_res8[0] = 0;
        if (lVar2 != null) {
          lVar7 = 32;
          uVar5 = "";
          do {
            if (lVar2.Count <= (int)uVar6) {
              return uVar5;
            }
            if (lVar2 == null) break;
            if (lVar2.Count <= uVar6) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            if (*(float *)(lVar7 + lVar2._items) != 0.0) {
              cVar1 = FUN_1816fd990(uVar5,"",0);
              uVar8 = "|";
              if (cVar1) {
                uVar8 = "";
              }
              lVar2 = *(int64 *)(*(int64 *)(DAT_181d4ef00 + 184) + 0x5e8);
              if (lVar2 == null) break;
              uVar3 = FUN_180002f80(lVar2,uVar6,DAT_181d7c9c0);
              if (this.partPosture == null) break;
              local_res8[0] = FUN_1800d6780(this.partPosture,uVar6,DAT_181d796d8);
              uVar4 = Single.ToString(local_res8,"f0",0);
              uVar5 = String.Concat(uVar5,uVar8,uVar3,uVar4,0);
            }
            lVar2 = this.partPosture;
            uVar6 = uVar6 + 1;
            lVar7 = lVar7 + 4;
          } while (lVar2 != null);
        }
    }

    // Token : 0x6001255
    // RVA   : 0x473880   Offset: 0x472080   Length: 0x175
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
        plVar1 = (int64 *)il2cpp_internal(DAT_181d63ff0);
        plVar4 = plVar1;
        MemoryStream.ctor(plVar1,1000,0);
        local_38 = 0;
        uStack_30 = 0;
        StreamingContext.ctor(&local_38,64,0);
        lVar2 = il2cpp_internal(DAT_181d8c5a8);
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
            FUN_180002970(0,DAT_181d53c70,plVar1);
            return uVar3;
          }
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
    }

}
