// ============================================================
// Type  : ByteReader
// Token : 0x200007C
// ============================================================

public class ByteReader
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x40002EF
    private byte[] mBuffer;

    // Token: 0x40002F0
    private int mOffset;

    // Token: 0x40002F1
    private static BetterList<string> mTemp;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60002EE
    // RVA   : 0x211180   Offset: 0x20F980   Length: 0x30
    public void /*ctor*/(byte[] bytes)
    {
        ulong uVar1;
        ZhSegment.Initialize(this,0);
        if (bytes != null) {
          uVar1 = TextAsset.get_bytes(bytes,0);
          this.mBuffer = uVar1;
          return;
        }
    }

    // Token : 0x60002EF
    // RVA   : 0xBD36E0   Offset: 0xBD1EE0   Length: 0x44
    public void /*ctor*/(TextAsset asset)
    {
        ulong uVar1;
        ZhSegment.Initialize(this,0);
        if (asset != null) {
          uVar1 = TextAsset.get_bytes(asset,0);
          this.mBuffer = uVar1;
          return;
        }
    }

    // Token : 0x60002F0
    // RVA   : 0xBD2CD0   Offset: 0xBD14D0   Length: 0x126
    public static ByteReader Open(string path)
    {
        uint uVar1;
        long lVar3;
        long lVar4;
        plVar2 = (int64 *)File.OpenRead(path,0);
        if (plVar2 == (int64 *)0) {
          return 0;
        }
        (**(code **)(*plVar2 + 0x2c8))(plVar2,0,2,*(uint64 *)(*plVar2 + 0x2d0));
        uVar1 = (**(code **)(*plVar2 + 0x1e8))(plVar2,*(uint64 *)(*plVar2 + 0x1f0));
        lVar3 = FUN_1800d60b0(DAT_181d7bda0,uVar1);
        (**(code **)(*plVar2 + 0x2c8))(plVar2,0,0,*(uint64 *)(*plVar2 + 0x2d0));
        if (lVar3 != null) {
          (**(code **)(*plVar2 + 0x2d8))
                    (plVar2,lVar3,0,*(uint32 *)(lVar3 + 24),*(uint64 *)(*plVar2 + 0x2e0));
          (**(code **)(*plVar2 + 0x238))(plVar2,*(uint64 *)(*plVar2 + 0x240));
          lVar4 = new ZhSegment(0);
          *(int64 *)(lVar4 + 16) = lVar3;
          return lVar4;
        }
    }

    // Token : 0x60002F1
    // RVA   : 0xBD3730   Offset: 0xBD1F30   Length: 0x14
    public bool get_canRead()
    {
        uint32 FUN_180bd3730(int64 this)
        {
        int iVar1;
        if (this.mBuffer == null) {
          return false;
        }
        iVar1 = *(int *)(this.mBuffer + 24);
        return CONCAT31((int3)((uint32)iVar1 >> 8),this.mOffset < iVar1);
    }

    // Token : 0x60002F2
    // RVA   : 0xBD3600   Offset: 0xBD1E00   Length: 0x5A
    private static string ReadLine(byte[] buffer, int start, int count)
    {
        bool cVar1;
        int iVar2;
        long lVar3;
        uint uVar4;
        ulong uVar6;
        uint uVar7;
        uint uVar8;
        lVar3 = *(int64 *)(buffer + 16);
        if (lVar3 == null) {
        LAB_180bd35cf:
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
        iVar2 = *(int *)(lVar3 + 24);
        if (start) {
          uVar4 = *(uint32 *)(buffer + 24);
          while ((int)uVar4 < iVar2) {
            if (*(uint32 *)(lVar3 + 24) <= uVar4) {
              uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar6,0);
            }
            if (31 < *(byte *)((int64)(int)uVar4 + 32 + lVar3)) break;
            uVar4 = uVar4 + 1;
            *(uint32 *)(buffer + 24) = uVar4;
          }
        }
        uVar4 = *(uint32 *)(buffer + 24);
        uVar8 = uVar4;
        if ((int)uVar4 < iVar2) {
          do {
            uVar7 = uVar8;
            uVar8 = uVar7 + 1;
            if (*(uint32 *)(lVar3 + 24) <= uVar7) {
              uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar6,0);
            }
            cVar1 = *(char *)((int64)(int)uVar7 + 32 + lVar3);
            if (!((cVar1 == '\n') || (cVar1 == '\r')))
            {
              } while ((int)uVar8 < iVar2);
              uVar8 = uVar7 + 2;
            }
          plVar5 = (int64 *)Encoding.get_UTF8(0);
          if (plVar5 == (int64 *)0) goto LAB_180bd35cf;
          uVar6 = (**(code **)(*plVar5 + 0x348))
                            (plVar5,lVar3,uVar4,(uVar8 - uVar4) + -1,*(uint64 *)(*plVar5 + 0x350));
          *(uint32 *)(buffer + 24) = uVar8;
        }
        else {
          *(int *)(buffer + 24) = iVar2;
          uVar6 = 0;
        }
        return uVar6;
    }

    // Token : 0x60002F3
    // RVA   : 0xBD34B0   Offset: 0xBD1CB0   Length: 0xA
    public string ReadLine()
    {
        bool cVar1;
        int iVar2;
        long lVar3;
        uint uVar4;
        ulong uVar6;
        uint uVar7;
        uint uVar8;
        lVar3 = this.mBuffer;
        if (lVar3 == null) {
        LAB_180bd35cf:
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
        iVar2 = *(int *)(lVar3 + 24);
        if (param_2) {
          uVar4 = this.mOffset;
          while ((int)uVar4 < iVar2) {
            if (*(uint32 *)(lVar3 + 24) <= uVar4) {
              uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar6,0);
            }
            if (31 < *(byte *)((int64)(int)uVar4 + 32 + lVar3)) break;
            uVar4 = uVar4 + 1;
            this.mOffset = uVar4;
          }
        }
        uVar4 = this.mOffset;
        uVar8 = uVar4;
        if ((int)uVar4 < iVar2) {
          do {
            uVar7 = uVar8;
            uVar8 = uVar7 + 1;
            if (*(uint32 *)(lVar3 + 24) <= uVar7) {
              uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar6,0);
            }
            cVar1 = *(char *)((int64)(int)uVar7 + 32 + lVar3);
            if (!((cVar1 == '\n') || (cVar1 == '\r')))
            {
              } while ((int)uVar8 < iVar2);
              uVar8 = uVar7 + 2;
            }
          plVar5 = (int64 *)Encoding.get_UTF8(0);
          if (plVar5 == (int64 *)0) goto LAB_180bd35cf;
          uVar6 = (**(code **)(*plVar5 + 0x348))
                            (plVar5,lVar3,uVar4,(uVar8 - uVar4) + -1,*(uint64 *)(*plVar5 + 0x350));
          this.mOffset = uVar8;
        }
        else {
          this.mOffset = iVar2;
          uVar6 = 0;
        }
        return uVar6;
    }

    // Token : 0x60002F4
    // RVA   : 0xBD34C0   Offset: 0xBD1CC0   Length: 0x134
    public string ReadLine(bool skipEmptyLines)
    {
        bool cVar1;
        int iVar2;
        long lVar3;
        uint uVar4;
        ulong uVar6;
        uint uVar7;
        uint uVar8;
        lVar3 = this.mBuffer;
        if (lVar3 == null) {
        LAB_180bd35cf:
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
        iVar2 = *(int *)(lVar3 + 24);
        if (skipEmptyLines) {
          uVar4 = this.mOffset;
          while ((int)uVar4 < iVar2) {
            if (*(uint32 *)(lVar3 + 24) <= uVar4) {
              uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar6,0);
            }
            if (31 < *(byte *)((int64)(int)uVar4 + 32 + lVar3)) break;
            uVar4 = uVar4 + 1;
            this.mOffset = uVar4;
          }
        }
        uVar4 = this.mOffset;
        uVar8 = uVar4;
        if ((int)uVar4 < iVar2) {
          do {
            uVar7 = uVar8;
            uVar8 = uVar7 + 1;
            if (*(uint32 *)(lVar3 + 24) <= uVar7) {
              uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar6,0);
            }
            cVar1 = *(char *)((int64)(int)uVar7 + 32 + lVar3);
            if (!((cVar1 == '\n') || (cVar1 == '\r')))
            {
              } while ((int)uVar8 < iVar2);
              uVar8 = uVar7 + 2;
            }
          plVar5 = (int64 *)Encoding.get_UTF8(0);
          if (plVar5 == (int64 *)0) goto LAB_180bd35cf;
          uVar6 = (**(code **)(*plVar5 + 0x348))
                            (plVar5,lVar3,uVar4,(uVar8 - uVar4) + -1,*(uint64 *)(*plVar5 + 0x350));
          this.mOffset = uVar8;
        }
        else {
          this.mOffset = iVar2;
          uVar6 = 0;
        }
        return uVar6;
    }

    // Token : 0x60002F5
    // RVA   : 0xBD32C0   Offset: 0xBD1AC0   Length: 0x1EF
    public Dictionary<string, string> ReadDictionary()
    {
        bool cVar1;
        long lVar2;
        long lVar3;
        long lVar4;
        ulong uVar5;
        ulong uVar6;
        lVar2 = il2cpp_internal(DAT_181d5e848);
        FUN_1808ae540(lVar2,DAT_181d4f5d8);
        lVar3 = FUN_1800d60b0(DAT_181d7c118,1);
        if (lVar3 != null) {
          if (*(int *)(lVar3 + 24) == 0) {
            uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar5,0);
          }
          *(uint16 *)(lVar3 + 32) = 61;
          while( true ) {
            do {
              do {
                if ((this.mBuffer == null) ||
                   (*(int *)(this.mBuffer + 24) <= this.mOffset)) {
                  return lVar2;
                }
                lVar4 = ByteReader.ReadLine(this,1,0);
                if (lVar4 == null) {
                  return lVar2;
                }
                cVar1 = String.StartsWith(lVar4,"//");
              } while (cVar1);
              lVar4 = String.Split(lVar4,lVar3,2,1,0);
              if (lVar4 == null) throw; // [null/range check failed]
            } while (*(int *)(lVar4 + 24) != 2);
            if (*(int64 *)(lVar4 + 32) == 0) break;
            uVar5 = String.Trim(*(int64 *)(lVar4 + 32),0);
            if (*(uint32 *)(lVar4 + 24) < 2) {
              uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar5,0);
            }
            if (((*(int64 *)(lVar4 + 40) == 0) ||
                (lVar4 = String.Trim(*(int64 *)(lVar4 + 40),0)) == null) ||
               (uVar6 = String.Replace(lVar4,"\\n","\n",0), lVar2 == null)) break;
            FUN_1808aec90(lVar2,uVar5,uVar6,DAT_181d4fbd8);
          }
        }
    }

    // Token : 0x60002F6
    // RVA   : 0xBD2E00   Offset: 0xBD1600   Length: 0x4B3
    public BetterList<string> ReadCSV()
    {
        var pStatics = *(int64*)(DAT_181d8f3b0 + 184);
        int iVar1;
        long lVar5;
        long lVar6;
        long lVar7;
        ulong uVar8;
        int iVar9;
        int iVar11;
        int iVar12;
        int iVar10;
        if (*pStatics != 0) {
          BetterList_1.Clear(*pStatics,DAT_181d81218);
          bVar2 = false;
          iVar11 = 0;
          lVar5 = "";
          do {
            if ((this.mBuffer == null) ||
               (*(int *)(this.mBuffer + 24) <= this.mOffset)) {
              return 0;
            }
            if (bVar2) {
              lVar6 = ByteReader.ReadLine(this,0,0);
              if (lVar6 == null) {
                return 0;
              }
              uVar8 = String.Replace(lVar6,"\\n","\n",0);
              lVar5 = String.Concat(lVar5,"\n",uVar8);
            }
            else {
              lVar5 = ByteReader.ReadLine(this,1,0);
              if (lVar5 == null) {
                return 0;
              }
              lVar5 = String.Replace(lVar5,"\\n","\n",0);
              iVar11 = 0;
            }
            if (lVar5 == null) throw; // [null/range check failed]
            iVar12 = *(int *)(lVar5 + 16);
            iVar9 = iVar11;
            bVar3 = bVar2;
            while (iVar9 < iVar12) {
              sVar4 = String.get_Chars(lVar5,iVar9,0);
              iVar10 = iVar9;
              if (sVar4 == 44) {
                if (!bVar3) {
                  lVar6 = *pStatics;
                  String.Substring(lVar5,iVar11,iVar9 - iVar11);
                  if (lVar6 == null) throw; // [null/range check failed]
                  FUN_18154cb60(lVar6);
                  iVar11 = iVar9 + 1;
                }
              }
              else if (sVar4 == 34) {
                iVar1 = iVar9 + 1;
                if (bVar3) {
                  if (iVar12 <= iVar1) {
                    lVar6 = *pStatics;
                    lVar5 = String.Substring(lVar5,iVar11,iVar9 - iVar11,0);
                    if ((lVar5 == null) ||
                       (uVar8 = String.Replace(lVar5,"\"\"","\"",0), lVar6 == null))
                    throw; // [null/range check failed]
                    FUN_18154cb60(lVar6,uVar8,DAT_181d81198);
                    goto LAB_180bd3200;
                  }
                  sVar4 = String.get_Chars(lVar5,iVar1,0);
                  iVar10 = iVar1;
                  if (sVar4 != 34) {
                    lVar6 = *pStatics;
                    lVar7 = String.Substring(lVar5,iVar11,iVar9 - iVar11);
                    if ((lVar7 == null) ||
                       (uVar8 = String.Replace(lVar7,"\"\"","\""), lVar6 == null))
                    throw; // [null/range check failed]
                    FUN_18154cb60(lVar6,uVar8);
                    bVar3 = false;
                    sVar4 = String.get_Chars(lVar5,iVar1,0);
                    iVar10 = iVar9;
                    if (sVar4 == 44) {
                      iVar11 = iVar9 + 2;
                      iVar10 = iVar1;
                    }
                  }
                }
                else {
                  bVar3 = true;
                  iVar11 = iVar1;
                }
              }
              iVar9 = iVar10 + 1;
            }
            iVar12 = *(int *)(lVar5 + 16);
            if (iVar12 <= iVar11) {
              lVar6 = *pStatics;
              lVar5 = "";
              goto joined_r0x000180bd3264;
            }
            bVar2 = true;
          } while (bVar3);
          if (((*(byte *)(DAT_181d8f3b0 + 0x133) & 4) != 0) && (*(int *)(DAT_181d8f3b0 + 224) == 0)) {
            il2cpp_runtime_class_init(DAT_181d8f3b0);
            iVar12 = *(int *)(lVar5 + 16);
          }
          lVar6 = *pStatics;
          lVar5 = String.Substring(lVar5,iVar11,iVar12 - iVar11,0);
        joined_r0x000180bd3264:
          if (lVar6 != null) {
            FUN_18154cb60(lVar6,lVar5,DAT_181d81198);
        LAB_180bd3200:
            return **(uint64 **)(DAT_181d8f3b0 + 184);
          }
        }
    }

    // Token : 0x60002F7
    // RVA   : 0xBD3660   Offset: 0xBD1E60   Length: 0x76
    private static void /*cctor*/()
    {
        ulong uVar2;
        uVar2 = new BetterList_1(DAT_181d81118);
        puVar1 = *(uint64 **)(DAT_181d8f3b0 + 184);
        *puVar1 = uVar2;
        il2cpp_internal(puVar1,uVar2);
    }

}
