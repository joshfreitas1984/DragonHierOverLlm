// ============================================================
// Type  : PartPostureData
// Token : 0x200022B
// ============================================================

public class PartPostureData
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001179
    public List<float> partPosture;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x600129A
    // RVA   : 0x913C10   Offset: 0x912A10   Length: 0xFC
    public void /*ctor*/()
    {
        var pStatics = *(int64*)(DAT_181e538e8 + 184);
        bool cVar2;
        long lVar3;
        long lVar4;
        long lVar5;
        ulong uVar6;
        long lVar8;
        int iVar9;
        uint uVar10;
        int iVar11;
        uint[] local_38 = new uint[4];
        local_38[0] = 0;
        ZhSegment.Initialize(this,0);
        lVar3 = il2cpp_internal(DAT_181e76ea8);
        FUN_1810f3480(lVar3,DAT_181e83230);
        if (lVar3 != null) {
          FUN_18175dba0(lVar3,0,DAT_181e83330);
          FUN_18175dba0(lVar3,0,DAT_181e83330);
          FUN_18175dba0(lVar3,0,DAT_181e83330);
          FUN_18175dba0(lVar3,0,DAT_181e83330);
          FUN_18175dba0(lVar3,0,DAT_181e83330);
          FUN_18175dba0(lVar3,0,DAT_181e83330);
          this.partPosture = lVar3;
          cVar2 = FUN_180ad1200(param_2,0);
          if (cVar2) {
            return;
          }
          cVar2 = FUN_180ad1200(param_3,0);
          lVar3 = "";
          if (!cVar2) {
            lVar3 = String.Format("（来源：{0}）",param_3,0);
          }
          lVar4 = FUN_1801dfd90(DAT_181e81128,1);
          if (lVar4 != null) {
            if (*(int *)(lVar4 + 24) == 0) {
              uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1801e02d0(uVar6,0);
            }
            *(uint16 *)(lVar4 + 32) = 59;
            if (param_2 != 0) {
              lVar4 = String.Split(param_2,lVar4,0);
              uVar10 = 0;
              if (lVar4 != null) {
        LAB_180913f60:
                do {
                  if ((int)*(uint32 *)(lVar4 + 24) <= (int)uVar10) {
                    return;
                  }
                  if (*(uint32 *)(lVar4 + 24) <= uVar10) {
                    uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                    FUN_1801e02d0(uVar6,0);
                  }
                  lVar5 = lVar4[uVar10];
                  if (lVar5 == null) break;
                  lVar5 = String.Trim(lVar5,0);
                  cVar2 = FUN_1816387f0(lVar5,"",0);
                  if (!cVar2) {
                    iVar11 = -1;
                    iVar9 = 0;
                    while( true ) {
                      lVar8 = *(int64 *)(pStatics + 0x610);
                      if (lVar8 == null) throw; // [null/range check failed]
                      if (*(int *)(lVar8 + 24) <= iVar9) break;
                      lVar8 = *(int64 *)(pStatics + 0x610);
                      if ((lVar8 == null) || (uVar6 = FUN_1800024b0(lVar8,iVar9), lVar5 == null))
                      throw; // [null/range check failed]
                      cVar2 = String.Contains(lVar5,uVar6);
                      if ((cVar2) &&
                         (bVar12 = iVar11 != -1, uVar6 = "PartPostureData Error: 词条部位歧义“{0}”（完整配置：“{1}”）{2}", iVar11 = iVar9, bVar12))
                      goto LAB_180914274;
                      iVar9 = iVar9 + 1;
                    }
                    uVar6 = "PartPostureData Error: 词条部位歧义“{0}”（完整配置：“{1}”）{2}";
                    if (iVar11 != -2) {
                      if (iVar11 == -1) {
                        plVar7 = (int64 *)FUN_1801dfd90(DAT_181e84278,4);
                        if (plVar7 == (int64 *)0) break;
                        if ((lVar5 != null) &&
                           (lVar8 = il2cpp_internal(lVar5,*(uint64 *)(*plVar7 + 64)), lVar8 == null
                           )) {
                          uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                          FUN_1801e02d0(uVar6,0);
                        }
                        if ((int)plVar7[3] == 0) {
                          uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                          FUN_1801e02d0(uVar6,0);
                        }
                        plVar7[4] = lVar5;
                        il2cpp_internal(plVar7 + 4,lVar5);
                        lVar5 = String.Join("/",
                                             *(uint64 *)(pStatics + 0x610))
                        ;
                        if ((lVar5 != null) &&
                           (lVar8 = il2cpp_internal(lVar5,*(uint64 *)(*plVar7 + 64)), lVar8 == null
                           )) {
                          uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                          FUN_1801e02d0(uVar6,0);
                        }
                        if (*(uint32 *)(plVar7 + 3) < 2) {
                          uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                          FUN_1801e02d0(uVar6,0);
                        }
                        plVar7[5] = lVar5;
                        il2cpp_internal(plVar7 + 5,lVar5);
                        lVar5 = il2cpp_internal(param_2,*(uint64 *)(*plVar7 + 64));
                        if (lVar5 == null) {
                          uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                          FUN_1801e02d0(uVar6,0);
                        }
                        if (*(uint32 *)(plVar7 + 3) < 3) {
                          uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                          FUN_1801e02d0(uVar6,0);
                        }
                        plVar7[6] = param_2;
                        il2cpp_internal(plVar7 + 6,param_2);
                        if ((lVar3 != null) &&
                           (lVar5 = il2cpp_internal(lVar3,*(uint64 *)(*plVar7 + 64)), lVar5 == null
                           )) {
                          uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                          FUN_1801e02d0(uVar6,0);
                        }
                        if (*(uint32 *)(plVar7 + 3) < 4) {
                          uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                          FUN_1801e02d0(uVar6,0);
                        }
                        plVar7[7] = lVar3;
                        il2cpp_internal(plVar7 + 7,lVar3);
                        uVar6 = String.Format("PartPostureData Error: 部位名无法识别“{0}”（合法部位：{1}；完整配置：“{2}”）{3}",plVar7);
                        goto LAB_18091428b;
                      }
                      lVar8 = *(int64 *)(pStatics + 0x610);
                      if ((lVar8 == null) || (uVar6 = FUN_1800024b0(lVar8,iVar11,DAT_181e86970), lVar5 == null))
                      break;
                      uVar6 = String.Replace(lVar5,uVar6,"",0);
                      cVar2 = Int32.TryParse(uVar6,local_38);
                      uVar6 = "PartPostureData Error: 数值解析失败“{0}”（完整配置：“{1}”）{2}";
                      if (cVar2) {
                        if (*plVar1 == 0) break;
                        FUN_181769c70(*plVar1,iVar11);
                        uVar10 = uVar10 + 1;
                        goto LAB_180913f60;
                      }
                    }
        LAB_180914274:
                    uVar6 = String.Format(uVar6,lVar5,param_2,lVar3,0);
        LAB_18091428b:
                    Debug.LogError(uVar6,0);
                  }
                  uVar10 = uVar10 + 1;
                } while( true );
              }
            }
          }
        }
    }

    // Token : 0x600129B
    // RVA   : 0x913D10   Offset: 0x912B10   Length: 0x675
    public void /*ctor*/(string resource, string debugContext)
    {
        var pStatics = *(int64*)(DAT_181e538e8 + 184);
        bool cVar2;
        long lVar3;
        long lVar4;
        long lVar5;
        ulong uVar6;
        long lVar8;
        int iVar9;
        uint uVar10;
        int iVar11;
        uint[] local_38 = new uint[4];
        local_38[0] = 0;
        ZhSegment.Initialize(this,0);
        lVar3 = il2cpp_internal(DAT_181e76ea8);
        FUN_1810f3480(lVar3,DAT_181e83230);
        if (lVar3 != null) {
          FUN_18175dba0(lVar3,0,DAT_181e83330);
          FUN_18175dba0(lVar3,0,DAT_181e83330);
          FUN_18175dba0(lVar3,0,DAT_181e83330);
          FUN_18175dba0(lVar3,0,DAT_181e83330);
          FUN_18175dba0(lVar3,0,DAT_181e83330);
          FUN_18175dba0(lVar3,0,DAT_181e83330);
          this.partPosture = lVar3;
          cVar2 = FUN_180ad1200(resource,0);
          if (cVar2) {
            return;
          }
          cVar2 = FUN_180ad1200(debugContext,0);
          lVar3 = "";
          if (!cVar2) {
            lVar3 = String.Format("（来源：{0}）",debugContext,0);
          }
          lVar4 = FUN_1801dfd90(DAT_181e81128,1);
          if (lVar4 != null) {
            if (*(int *)(lVar4 + 24) == 0) {
              uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1801e02d0(uVar6,0);
            }
            *(uint16 *)(lVar4 + 32) = 59;
            if (resource != null) {
              lVar4 = String.Split(resource,lVar4,0);
              uVar10 = 0;
              if (lVar4 != null) {
        LAB_180913f60:
                do {
                  if ((int)*(uint32 *)(lVar4 + 24) <= (int)uVar10) {
                    return;
                  }
                  if (*(uint32 *)(lVar4 + 24) <= uVar10) {
                    uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                    FUN_1801e02d0(uVar6,0);
                  }
                  lVar5 = lVar4[uVar10];
                  if (lVar5 == null) break;
                  lVar5 = String.Trim(lVar5,0);
                  cVar2 = FUN_1816387f0(lVar5,"",0);
                  if (!cVar2) {
                    iVar11 = -1;
                    iVar9 = 0;
                    while( true ) {
                      lVar8 = *(int64 *)(pStatics + 0x610);
                      if (lVar8 == null) throw; // [null/range check failed]
                      if (*(int *)(lVar8 + 24) <= iVar9) break;
                      lVar8 = *(int64 *)(pStatics + 0x610);
                      if ((lVar8 == null) || (uVar6 = FUN_1800024b0(lVar8,iVar9), lVar5 == null))
                      throw; // [null/range check failed]
                      cVar2 = String.Contains(lVar5,uVar6);
                      if ((cVar2) &&
                         (bVar12 = iVar11 != -1, uVar6 = "PartPostureData Error: 词条部位歧义“{0}”（完整配置：“{1}”）{2}", iVar11 = iVar9, bVar12))
                      goto LAB_180914274;
                      iVar9 = iVar9 + 1;
                    }
                    uVar6 = "PartPostureData Error: 词条部位歧义“{0}”（完整配置：“{1}”）{2}";
                    if (iVar11 != -2) {
                      if (iVar11 == -1) {
                        plVar7 = (int64 *)FUN_1801dfd90(DAT_181e84278,4);
                        if (plVar7 == (int64 *)0) break;
                        if ((lVar5 != null) &&
                           (lVar8 = il2cpp_internal(lVar5,*(uint64 *)(*plVar7 + 64)), lVar8 == null
                           )) {
                          uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                          FUN_1801e02d0(uVar6,0);
                        }
                        if ((int)plVar7[3] == 0) {
                          uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                          FUN_1801e02d0(uVar6,0);
                        }
                        plVar7[4] = lVar5;
                        il2cpp_internal(plVar7 + 4,lVar5);
                        lVar5 = String.Join("/",
                                             *(uint64 *)(pStatics + 0x610))
                        ;
                        if ((lVar5 != null) &&
                           (lVar8 = il2cpp_internal(lVar5,*(uint64 *)(*plVar7 + 64)), lVar8 == null
                           )) {
                          uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                          FUN_1801e02d0(uVar6,0);
                        }
                        if (*(uint32 *)(plVar7 + 3) < 2) {
                          uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                          FUN_1801e02d0(uVar6,0);
                        }
                        plVar7[5] = lVar5;
                        il2cpp_internal(plVar7 + 5,lVar5);
                        lVar5 = il2cpp_internal(resource,*(uint64 *)(*plVar7 + 64));
                        if (lVar5 == null) {
                          uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                          FUN_1801e02d0(uVar6,0);
                        }
                        if (*(uint32 *)(plVar7 + 3) < 3) {
                          uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                          FUN_1801e02d0(uVar6,0);
                        }
                        plVar7[6] = resource;
                        il2cpp_internal(plVar7 + 6,resource);
                        if ((lVar3 != null) &&
                           (lVar5 = il2cpp_internal(lVar3,*(uint64 *)(*plVar7 + 64)), lVar5 == null
                           )) {
                          uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                          FUN_1801e02d0(uVar6,0);
                        }
                        if (*(uint32 *)(plVar7 + 3) < 4) {
                          uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                          FUN_1801e02d0(uVar6,0);
                        }
                        plVar7[7] = lVar3;
                        il2cpp_internal(plVar7 + 7,lVar3);
                        uVar6 = String.Format("PartPostureData Error: 部位名无法识别“{0}”（合法部位：{1}；完整配置：“{2}”）{3}",plVar7);
                        goto LAB_18091428b;
                      }
                      lVar8 = *(int64 *)(pStatics + 0x610);
                      if ((lVar8 == null) || (uVar6 = FUN_1800024b0(lVar8,iVar11,DAT_181e86970), lVar5 == null))
                      break;
                      uVar6 = String.Replace(lVar5,uVar6,"",0);
                      cVar2 = Int32.TryParse(uVar6,local_38);
                      uVar6 = "PartPostureData Error: 数值解析失败“{0}”（完整配置：“{1}”）{2}";
                      if (cVar2) {
                        if (*plVar1 == 0) break;
                        FUN_181769c70(*plVar1,iVar11);
                        uVar10 = uVar10 + 1;
                        goto LAB_180913f60;
                      }
                    }
        LAB_180914274:
                    uVar6 = String.Format(uVar6,lVar5,resource,lVar3,0);
        LAB_18091428b:
                    Debug.LogError(uVar6,0);
                  }
                  uVar10 = uVar10 + 1;
                } while( true );
              }
            }
          }
        }
    }

    // Token : 0x600129C
    // RVA   : 0x912FD0   Offset: 0x911DD0   Length: 0x9E
    public void ChangePosture(int id, float num)
    {
        long lVar1;
        uint uVar2;
        lVar1 = this.partPosture;
        if (lVar1 != null) {
          if (lVar1.Count <= id) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          uVar2 = FUN_180f34e60(*(float *)(lVar1._items + 32 + (int64)(int)id * 4
                                          ) + num,0,0x42c80000,0);
          FUN_181769c70(lVar1,id,uVar2,DAT_181e835b0);
          return;
        }
    }

    // Token : 0x600129D
    // RVA   : 0x912F50   Offset: 0x911D50   Length: 0x80
    public void ChangeMulti(float changeRate)
    {
        ulong uVar1;
        uVar1 = this.partPosture;
        uVar1 = GlobalData.ListMulti(uVar1,changeRate,0);
        this.partPosture = uVar1;
    }

    // Token : 0x600129E
    // RVA   : 0x913B00   Offset: 0x912900   Length: 0xF2
    public void Reset()
    {
        long lVar1;
        lVar1 = il2cpp_internal(DAT_181e76ea8);
        FUN_1810f3480(lVar1,DAT_181e83230);
        if (lVar1 != null) {
          FUN_18175dba0(lVar1,0,DAT_181e83330);
          FUN_18175dba0(lVar1,0,DAT_181e83330);
          FUN_18175dba0(lVar1,0,DAT_181e83330);
          FUN_18175dba0(lVar1,0,DAT_181e83330);
          FUN_18175dba0(lVar1,0,DAT_181e83330);
          FUN_18175dba0(lVar1,0,DAT_181e83330);
          this.partPosture = lVar1;
          return;
        }
    }

    // Token : 0x600129F
    // RVA   : 0x913A30   Offset: 0x912830   Length: 0xC1
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

    // Token : 0x60012A0
    // RVA   : 0x913970   Offset: 0x912770   Length: 0xBF
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

    // Token : 0x60012A1
    // RVA   : 0x913C00   Offset: 0x912A00   Length: 0xB
    public float TotalNum()
    {
        Enumerable.Sum(this.partPosture,0);
    }

    // Token : 0x60012A2
    // RVA   : 0x913210   Offset: 0x912010   Length: 0x1BA
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
            uVar7 = FUN_180f34e60(*(float *)(lVar6 + *(int64 *)(lVar2 + 16)) + fVar1,0,0x42c80000,0);
            FUN_181769c70(lVar4,uVar5,uVar7);
            lVar4 = this.partPosture;
            uVar5 = uVar5 + 1;
            lVar6 = lVar6 + 4;
            if (lVar4 == null) break;
          }
        }
    }

    // Token : 0x60012A3
    // RVA   : 0x9133D0   Offset: 0x9121D0   Length: 0x1B3
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
            uVar7 = FUN_180f34e60(fVar1 - *(float *)(lVar6 + *(int64 *)(lVar2 + 16)),0,0x42c80000,0);
            FUN_181769c70(lVar4,uVar5,uVar7);
            lVar4 = this.partPosture;
            uVar5 = uVar5 + 1;
            lVar6 = lVar6 + 4;
          } while (lVar4 != null);
        }
    }

    // Token : 0x60012A4
    // RVA   : 0x913790   Offset: 0x912590   Length: 0x1D6
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
          cVar2 = FUN_1816387f0(uVar5,"",0);
          uVar6 = "";
          if ((!cVar2) && (uVar6 = "|", iVar7 == 3)) {
            uVar6 = "\n";
          }
          lVar1 = *(int64 *)(*(int64 *)(DAT_181e538e8 + 184) + 0x610);
          if (lVar1 == null) break;
          uVar3 = FUN_1800024b0(lVar1,iVar7,DAT_181e86970);
          if (this.partPosture == null) break;
          local_res8[0] = (float)FUN_1800024e0(this.partPosture,iVar7,DAT_181e83530);
          local_res8[0] = 100.0 - local_res8[0];
          uVar4 = Single.ToString(local_res8,"f0",0);
          uVar5 = String.Concat(uVar5,uVar6,uVar3,uVar4,0);
          iVar7 = iVar7 + 1;
          lVar1 = this.partPosture;
        }
    }

    // Token : 0x60012A5
    // RVA   : 0x913590   Offset: 0x912390   Length: 0x1F2
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
              cVar1 = FUN_1816387f0(uVar5,"",0);
              uVar8 = "|";
              if (cVar1) {
                uVar8 = "";
              }
              lVar2 = *(int64 *)(*(int64 *)(DAT_181e538e8 + 184) + 0x610);
              if (lVar2 == null) break;
              uVar3 = FUN_1800024b0(lVar2,uVar6,DAT_181e86970);
              if (this.partPosture == null) break;
              local_res8[0] = FUN_1800024e0(this.partPosture,uVar6,DAT_181e83530);
              uVar4 = Single.ToString(local_res8,"f0",0);
              uVar5 = String.Concat(uVar5,uVar8,uVar3,uVar4,0);
            }
            lVar2 = this.partPosture;
            uVar6 = uVar6 + 1;
            lVar7 = lVar7 + 4;
          } while (lVar2 != null);
        }
    }

    // Token : 0x60012A6
    // RVA   : 0x913070   Offset: 0x911E70   Length: 0x196
    public virtual object Clone()
    {
        long lVar1;
        long lVar2;
        ulong uVar3;
        lVar1 = new ZhSegment(0);
        lVar2 = il2cpp_internal(DAT_181e76ea8);
        FUN_1810f3480(lVar2,DAT_181e83230);
        if (lVar2 != null) {
          FUN_18175dba0(lVar2,0,DAT_181e83330);
          FUN_18175dba0(lVar2,0,DAT_181e83330);
          FUN_18175dba0(lVar2,0,DAT_181e83330);
          FUN_18175dba0(lVar2,0,DAT_181e83330);
          FUN_18175dba0(lVar2,0,DAT_181e83330);
          FUN_18175dba0(lVar2,0,DAT_181e83330);
          *(int64 *)(lVar1 + 16) = lVar2;
          lVar2 = this.partPosture;
          if (lVar2 == null) {
            uVar3 = 0;
          }
          else {
            uVar3 = il2cpp_internal(DAT_181e76ea8);
            FUN_181768070(uVar3,lVar2,DAT_181e832b0);
          }
          *(uint64 *)(lVar1 + 16) = uVar3;
          return lVar1;
        }
    }

}
