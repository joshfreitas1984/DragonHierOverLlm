// ============================================================
// Type  : LTCSVLoader
// Token : 0x20002F0
// ============================================================

public class LTCSVLoader
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x400179F
    private TextReader inStream;

    // Token: 0x40017A0
    private List<string> vContent;

    // Token: 0x40017A1
    private List<List<string>> table;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6001855
    // RVA   : 0xA81B70   Offset: 0xA80370   Length: 0x1E9
    private void ReadFile(string fileName)
    {
        long lVar1;
        bool cVar2;
        ulong uVar3;
        ulong uVar4;
        long lVar5;
        int iVar6;
        uVar4 = Encoding.GetEncoding("GBK",0);
        this.inStream = new StreamReader(fileName,uVar4,0);
        uVar4 = il2cpp_internal(DAT_181d6b7b0);
        FUN_180f58a90(uVar4,DAT_181d51c88);
        this.table = uVar4;
        cVar2 = LTCSVLoader.readCSVNextRecord(this,0);
        if (cVar2) {
          lVar1 = this.vContent;
          while (lVar1 != null) {
            lVar5 = il2cpp_internal(DAT_181d72a30);
            FUN_180f58a90(lVar5,DAT_181d7c250);
            iVar6 = 0;
            while( true ) {
              if (lVar1 == null) goto LAB_180a81d54;
              if (lVar1.Count <= iVar6) break;
              uVar4 = FUN_180002f80(lVar1,iVar6,DAT_181d7c9c0);
              if (lVar5 == null) goto LAB_180a81d54;
              FUN_181827900(lVar5,uVar4,DAT_181d7c3d0);
              iVar6 = iVar6 + 1;
            }
            if (this.table == null) {
        LAB_180a81d54:
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            FUN_181827900(this.table,lVar5,DAT_181d51d08);
            cVar2 = LTCSVLoader.readCSVNextRecord(this,0);
            if (!cVar2) {
              return;
            }
            lVar1 = this.vContent;
          }
        }
    }

    // Token : 0x6001856
    // RVA   : 0xA81D60   Offset: 0xA80560   Length: 0x1C9
    public void ReadMultiLine(string str)
    {
        long lVar1;
        bool cVar2;
        ulong uVar3;
        long lVar4;
        int iVar5;
        this.inStream = new StringReader(str,0);
        uVar3 = il2cpp_internal(DAT_181d6b7b0);
        FUN_180f58a90(uVar3,DAT_181d51c88);
        this.table = uVar3;
        cVar2 = LTCSVLoader.readCSVNextRecord(this,0);
        if (cVar2) {
          lVar1 = this.vContent;
          while (lVar1 != null) {
            lVar4 = il2cpp_internal(DAT_181d72a30);
            FUN_180f58a90(lVar4,DAT_181d7c250);
            iVar5 = 0;
            while( true ) {
              if (lVar1 == null) goto LAB_180a81f24;
              if (lVar1.Count <= iVar5) break;
              uVar3 = FUN_180002f80(lVar1,iVar5,DAT_181d7c9c0);
              if (lVar4 == null) goto LAB_180a81f24;
              FUN_181827900(lVar4,uVar3,DAT_181d7c3d0);
              iVar5 = iVar5 + 1;
            }
            if (this.table == null) {
        LAB_180a81f24:
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            FUN_181827900(this.table,lVar4,DAT_181d51d08);
            cVar2 = LTCSVLoader.readCSVNextRecord(this,0);
            if (!cVar2) {
              return;
            }
            lVar1 = this.vContent;
          }
        }
    }

    // Token : 0x6001857
    // RVA   : 0xA81F30   Offset: 0xA80730   Length: 0xB8
    private int containsNumber(string parentStr, string parameter)
    {
        bool cVar1;
        int iVar2;
        int iVar3;
        iVar3 = 0;
        if ((((parentStr != null) && (cVar1 = String.Equals(parentStr,"",0), !cVar1)) &&
            (parameter != null)) && (cVar1 = String.Equals(parameter,"",0), !cVar1)) {
          iVar2 = 0;
          while( true ) {
            if (*(int *)(parentStr + 16) <= iVar2) {
              return iVar3;
            }
            iVar2 = String.IndexOf(parentStr,parameter,iVar2,0);
            if (iVar2 < 0) break;
            iVar3 = iVar3 + 1;
            iVar2 = iVar2 + *(int *)(parameter + 16);
          }
          return iVar3;
        }
        return 0;
    }

    // Token : 0x6001858
    // RVA   : 0xA82020   Offset: 0xA80820   Length: 0x9B
    private bool isQuoteAdjacent(string p_String)
    {
        int iVar1;
        long lVar2;
        if ((p_String != null) && (lVar2 = String.Replace(p_String,"\"\"","",0)) != null
           ) {
          iVar1 = String.IndexOf(lVar2,"\"",0);
          return iVar1 == -1;
        }
    }

    // Token : 0x6001859
    // RVA   : 0xA820C0   Offset: 0xA808C0   Length: 0x8F
    private bool isQuoteContained(string p_String)
    {
        uint uVar1;
        ulong in_RAX;
        if ((p_String != null) && (in_RAX = String.Equals(p_String,"",0), (char)!in_RAX)) {
          uVar1 = String.IndexOf(p_String,"\"",0);
          return (uint64)(uVar1 < 0x80000000);
        }
        return in_RAX & 0xffffffffffffff00;
    }

    // Token : 0x600185A
    // RVA   : 0xA82150   Offset: 0xA80950   Length: 0x54E
    private string[] readAtomString(string lineStr)
    {
        bool cVar1;
        uint uVar2;
        int iVar3;
        uint uVar4;
        long lVar6;
        long lVar7;
        ulong uVar8;
        ulong uVar9;
        long lVar10;
        uint uVar11;
        lVar7 = "";
        plVar5 = (int64 *)FUN_1800d60b0(DAT_181d80cc0,2);
        lVar6 = FUN_1800d60b0(DAT_181d7c118,1);
        if (lVar6 != null) {
          if (*(int *)(lVar6 + 24) == 0) {
            uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar8,0);
          }
          *(uint16 *)(lVar6 + 32) = 44;
          if (lineStr != null) {
            lVar6 = String.Split(lineStr,lVar6,0);
        LAB_180a82230:
            uVar11 = 0;
        LAB_180a82232:
            if (lVar6 == null) throw; // [null/range check failed]
            if ((int)*(uint32 *)(lVar6 + 24) <= (int)uVar11) goto LAB_180a82230;
            if (*(uint32 *)(lVar6 + 24) <= uVar11) {
              uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar8,0);
            }
            uVar8 = lVar6[uVar11];
            if (lVar7 == null) throw; // [null/range check failed]
            cVar1 = String.Equals(lVar7,"",0);
            if (!cVar1) {
              lVar7 = String.Concat(lVar7,",");
            }
            lVar7 = String.Concat(lVar7,uVar8);
            cVar1 = LTCSVLoader.isQuoteContained(this,lVar7);
            lVar10 = lVar7;
            if (!cVar1) {
        LAB_180a8253e:
              if (lVar7 != null) {
                lVar6 = "";
                if (*(int *)(lVar7 + 16) < *(int *)(lineStr + 16)) {
                  lVar6 = String.Substring(lineStr,*(int *)(lVar7 + 16),0);
                }
                if (lVar6 != null) {
                  cVar1 = String.StartsWith(lVar6,",",0);
                  lVar7 = lVar6;
                  if ((cVar1) && (lVar7 = "", 1 < *(int *)(lVar6 + 16))) {
                    lVar7 = String.Substring(lVar6,1);
                  }
                  if (plVar5 != (int64 *)0) {
                    if ((lVar10 != null) &&
                       (lVar6 = il2cpp_internal(lVar10,*(uint64 *)(*plVar5 + 64))) == null)
                    {
                      uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                      FUN_1800d65f0(uVar8,0);
                    }
                    if ((int)plVar5[3] == 0) {
                      uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                      FUN_1800d65f0(uVar8,0);
                    }
                    plVar5[4] = lVar10;
                    il2cpp_internal(plVar5 + 4,lVar10);
                    if ((lVar7 != null) &&
                       (lVar6 = il2cpp_internal(lVar7,*(uint64 *)(*plVar5 + 64))) == null) {
                      uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                      FUN_1800d65f0(uVar8,0);
                    }
                    if (*(uint32 *)(plVar5 + 3) < 2) {
                      uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                      FUN_1800d65f0(uVar8,0);
                    }
                    plVar5[5] = lVar7;
                    il2cpp_internal(plVar5 + 5,lVar7);
                    return plVar5;
                  }
                }
              }
              throw; // [null/range check failed]
            }
            if (lVar7 == null) throw; // [null/range check failed]
            cVar1 = String.StartsWith(lVar7,"\"");
            if (!cVar1) goto LAB_180a8253e;
            cVar1 = String.StartsWith(lVar7);
            if (cVar1) {
              uVar2 = LTCSVLoader.containsNumber(this,lVar7,"\"",0);
              uVar2 = uVar2 & 0x80000001;
              if ((int)uVar2 < 0) {
                uVar2 = (uVar2 - 1 | 0xfffffffe) + 1;
              }
              if (uVar2 == 0) {
                cVar1 = String.EndsWith(lVar7);
                if (!cVar1) {
                  uVar4 = String.IndexOf(lVar7,34,1);
                  uVar8 = String.Substring(lVar7,1,uVar4);
                  iVar3 = String.IndexOf(lVar7,34,1,0);
                  lVar6 = lVar7;
        LAB_180a82396:
                  uVar9 = String.Substring(lVar6,iVar3 + 1,0);
                  lVar10 = String.Concat(uVar8,uVar9,0);
                }
                else {
                  lVar6 = String.Replace(lVar7,"\"\"","");
                  if (lVar6 == null) throw; // [null/range check failed]
                  cVar1 = String.Equals(lVar6,"",0);
                  lVar10 = "";
                  if (!cVar1) {
                    uVar4 = String.LastIndexOf(lVar6,"\"",0);
                    lVar6 = String.Substring(lVar6,1,uVar4);
                    if (lVar6 == null) throw; // [null/range check failed]
                    uVar11 = String.IndexOf(lVar6,"\"",0);
                    if (0x7fffffff < uVar11) {
                      uVar4 = String.LastIndexOf(lVar7,"\"");
                      lVar6 = String.Substring(lVar7,1,uVar4);
                      if (lVar6 != null) {
                        lVar10 = String.Replace(lVar6,"\"\"","\"",0);
                        goto LAB_180a8253e;
                      }
                      throw; // [null/range check failed]
                    }
                    lVar6 = String.Substring(lVar7,1,0);
                    if (lVar6 == null) throw; // [null/range check failed]
                    uVar4 = String.IndexOf(lVar6,"\"",0);
                    uVar8 = String.Substring(lVar6,0,uVar4,0);
                    iVar3 = String.IndexOf(lVar6,"\"",0);
                    uVar9 = String.Substring(lVar6,iVar3 + 1,0);
                    lVar10 = String.Concat(uVar8,uVar9,0);
                  }
                }
                goto LAB_180a8253e;
              }
              cVar1 = String.Equals(lVar7,"\"",0);
              if (!cVar1) {
                String.Substring(lVar7,1);
                cVar1 = LTCSVLoader.isQuoteAdjacent(this);
                if (!cVar1) {
                  lVar6 = String.Substring(lVar7,1);
                  if (lVar6 != null) {
                    iVar3 = String.IndexOf(lVar6,"\"",0);
                    uVar8 = String.Substring(lVar6,0,iVar3,0);
                    goto LAB_180a82396;
                  }
                  throw; // [null/range check failed]
                }
              }
            }
            uVar11 = uVar11 + 1;
            goto LAB_180a82232;
          }
        }
    }

    // Token : 0x600185B
    // RVA   : 0xA826A0   Offset: 0xA80EA0   Length: 0x3DC
    private bool readCSVNextRecord()
    {
        bool cVar2;
        int iVar4;
        uint uVar5;
        ulong uVar6;
        long lVar8;
        long lVar9;
        if (this.inStream == null) {
        LAB_180a82a40:
          uVar6 = 0;
        }
        else {
          lVar8 = this.vContent;
          if (lVar8 == null) {
            uVar6 = il2cpp_internal(DAT_181d72a30);
            FUN_180f58a90(uVar6,DAT_181d7c250);
            this.vContent = uVar6;
            lVar8 = this.vContent;
            if (lVar8 == null) goto LAB_180a82a57;
          }
          FUN_180f56130(lVar8,DAT_181d7c450);
          plVar7 = (int64 *)il2cpp_internal(DAT_181d824f0);
          StringBuilder.ctor(plVar7,0);
          do {
            do {
              while( true ) {
                plVar1 = this.inStream;
                if (plVar1 == (int64 *)0) goto LAB_180a82a57;
                lVar8 = (**(code **)(*plVar1 + 0x208))(plVar1,*(uint64 *)(*plVar1 + 0x210));
                if (lVar8 == null) {
                  this.vContent = 0;
                  goto LAB_180a82a40;
                }
                if ((plVar7 == (int64 *)0) ||
                   (lVar9 = (**(code **)(*plVar7 + 0x168))(plVar7,*(uint64 *)(*plVar7 + 0x170)),
                   lVar9 == null)) goto LAB_180a82a57;
                cVar2 = String.Equals(lVar9,"",0);
                if (!cVar2) {
                  StringBuilder.Append(plVar7,"\n",0);
                }
                StringBuilder.Append(plVar7,lVar8,0);
                lVar8 = (**(code **)(*plVar7 + 0x168))(plVar7,*(uint64 *)(*plVar7 + 0x170));
                if (lVar8 == null) goto LAB_180a82a57;
                iVar4 = String.IndexOf(lVar8,",",0);
                if (iVar4 == -1) break;
                lVar8 = String.Replace(lVar8,"\"\"","");
                if (lVar8 == null) goto LAB_180a82a57;
                iVar4 = String.LastIndexOf(lVar8,"\"",0);
                if (iVar4 != 0) {
                  if (iVar4 == -1) goto LAB_180a829ad;
                  lVar8 = String.Replace(lVar8,"\",\"","");
                  if (lVar8 == null) goto LAB_180a82a57;
                  iVar4 = String.LastIndexOf(lVar8,"\"",0);
                  if ((iVar4 != 0) && (sVar3 = String.get_Chars(lVar8,iVar4 + -1,0), sVar3 != 44))
                  goto LAB_180a829ad;
                }
              }
              uVar5 = LTCSVLoader.containsNumber(this,lVar8,"\"",0);
              uVar5 = uVar5 & 0x80000001;
              if ((int)uVar5 < 0) {
                uVar5 = (uVar5 - 1 | 0xfffffffe) + 1;
              }
              if (uVar5 == 0) goto LAB_180a829ad;
              cVar2 = String.StartsWith(lVar8,"\"",0);
            } while ((!cVar2) || (cVar2 = String.Equals(lVar8,"\"",0), cVar2));
            uVar6 = String.Substring(lVar8,1);
            cVar2 = LTCSVLoader.isQuoteAdjacent(this,uVar6,0);
          } while (cVar2);
        LAB_180a829ad:
          lVar8 = (**(code **)(*plVar7 + 0x168))(plVar7,*(uint64 *)(*plVar7 + 0x170));
          if (lVar8 != null) {
            while( true ) {
              cVar2 = String.Equals(lVar8,"",0);
              if (cVar2) goto LAB_180a82a29;
              lVar9 = LTCSVLoader.readAtomString(this,lVar8,0);
              if (lVar9 == null) break;
              if (*(uint32 *)(lVar9 + 24) == 0) {
                uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar6,0);
              }
              if (*(uint32 *)(lVar9 + 24) < 2) {
                uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar6,0);
              }
              lVar8 = *(int64 *)(lVar9 + 40);
              if ((this.vContent == null) ||
                 (FUN_181827900(this.vContent,*(uint64 *)(lVar9 + 32)), lVar8 == null))
              break;
            }
        LAB_180a82a57:
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
        LAB_180a82a29:
          uVar6 = 1;
        }
        return uVar6;
    }

    // Token : 0x600185C
    // RVA   : 0xA81FF0   Offset: 0xA807F0   Length: 0x26
    private List<string> getLineContentVector()
    {
        bool cVar1;
        cVar1 = LTCSVLoader.readCSVNextRecord(this,0);
        if (!cVar1) {
          return 0;
        }
        return this.vContent;
    }

    // Token : 0x600185D
    // RVA   : 0x20F140   Offset: 0x20D940   Length: 0x5
    private List<string> getVContent()
    {
        return this.vContent;
    }

    // Token : 0x600185E
    // RVA   : 0xA818D0   Offset: 0xA800D0   Length: 0x7F
    public int GetRow()
    {
        ulong uVar1;
        ulong uVar2;
        if (this.table != null) {
          return this.table.Count;
        }
        uVar1 = il2cpp_runtime_class_init(&DAT_181da0308);
        uVar1 = il2cpp_internal(uVar1);
        uVar2 = il2cpp_internal(&"table尚未初始化,请检查是否成功读取");
        Exception.ctor(uVar1,uVar2,0);
        uVar2 = il2cpp_runtime_class_init(&DAT_181d5d308);
    }

    // Token : 0x600185F
    // RVA   : 0xA80E00   Offset: 0xA7F600   Length: 0xFA
    public int GetCol()
    {
        long lVar1;
        ulong uVar2;
        ulong uVar3;
        lVar1 = this.table;
        if (lVar1 == null) {
          uVar2 = il2cpp_runtime_class_init(&DAT_181da0308);
          uVar2 = il2cpp_internal(uVar2);
          uVar3 = il2cpp_internal(&"table尚未初始化,请检查是否成功读取");
          Exception.ctor(uVar2,uVar3,0);
          uVar3 = il2cpp_runtime_class_init(&DAT_181d5d088);
                          // WARNING: Subroutine does not return
          FUN_1800d65f0(uVar2,uVar3);
        }
        if (lVar1.Count == null) {
          uVar2 = il2cpp_runtime_class_init(&DAT_181da0308);
          uVar2 = il2cpp_internal(uVar2);
          uVar3 = il2cpp_internal(&"table内容为空");
          Exception.ctor(uVar2,uVar3,0);
          uVar3 = il2cpp_runtime_class_init(&DAT_181d5d088);
                          // WARNING: Subroutine does not return
          FUN_1800d65f0(uVar2,uVar3);
        }
        lVar1 = *(int64 *)(lVar1._items + 32);
        if (lVar1 != null) {
          return lVar1.Count;
        }
    }

    // Token : 0x6001860
    // RVA   : 0xA80F00   Offset: 0xA7F700   Length: 0x229
    public int GetFirstIndexAtCol(string str, int col)
    {
        bool cVar1;
        long lVar2;
        ulong uVar3;
        ulong uVar4;
        long lVar5;
        uint uVar6;
        lVar2 = this.table;
        if (lVar2 == null) {
          uVar3 = il2cpp_runtime_class_init(&DAT_181da0308);
          uVar3 = il2cpp_internal(uVar3);
          uVar4 = il2cpp_internal(&"table尚未初始化,请检查是否成功读取");
          Exception.ctor(uVar3,uVar4,0);
          uVar4 = il2cpp_runtime_class_init(&DAT_181d5d108);
                          // WARNING: Subroutine does not return
          FUN_1800d65f0(uVar3,uVar4);
        }
        if (lVar2.Count == null) {
          uVar3 = il2cpp_runtime_class_init(&DAT_181da0308);
          uVar3 = il2cpp_internal(uVar3);
          uVar4 = il2cpp_internal(&"table内容为空");
          Exception.ctor(uVar3,uVar4,0);
          uVar4 = il2cpp_runtime_class_init(&DAT_181d5d108);
                          // WARNING: Subroutine does not return
          FUN_1800d65f0(uVar3,uVar4);
        }
        lVar5 = *(int64 *)(lVar2._items + 32);
        if (lVar5 != null) {
          if (*(int *)(lVar5 + 24) <= (int)col) {
            uVar3 = il2cpp_runtime_class_init(&DAT_181da0308);
            uVar3 = il2cpp_internal(uVar3);
            uVar4 = il2cpp_internal(&"参数错误：col大于最大列");
            Exception.ctor(uVar3,uVar4,0);
            uVar4 = il2cpp_runtime_class_init(&DAT_181d5d108);
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar3,uVar4);
          }
          uVar6 = 0;
          if (lVar2 != null) {
            lVar5 = 32;
            do {
              if (lVar2.Count <= (int)uVar6) {
                return 0xffffffff;
              }
              if (lVar2 == null) break;
              if (lVar2.Count <= uVar6) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              lVar2 = *(int64 *)(lVar5 + lVar2._items);
              if (lVar2 == null) break;
              if (lVar2.Count <= col) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              lVar2 = lVar2._items[col];
              if (lVar2 == null) break;
              cVar1 = String.Equals(lVar2,str,0);
              if (cVar1) {
                return uVar6;
              }
              lVar2 = this.table;
              uVar6 = uVar6 + 1;
              lVar5 = lVar5 + 8;
            } while (lVar2 != null);
          }
        }
    }

    // Token : 0x6001861
    // RVA   : 0xA81130   Offset: 0xA7F930   Length: 0x232
    public int GetFirstIndexAtRow(string str, int row)
    {
        int iVar1;
        long lVar2;
        bool cVar3;
        ulong uVar4;
        ulong uVar5;
        long lVar6;
        uint uVar7;
        long lVar8;
        lVar6 = this.table;
        if (lVar6 == null) {
          uVar4 = il2cpp_runtime_class_init(&DAT_181da0308);
          uVar4 = il2cpp_internal(uVar4);
          uVar5 = il2cpp_internal(&"table尚未初始化,请检查是否成功读取");
          Exception.ctor(uVar4,uVar5,0);
          uVar5 = il2cpp_runtime_class_init(&DAT_181d5d188);
                          // WARNING: Subroutine does not return
          FUN_1800d65f0(uVar4,uVar5);
        }
        iVar1 = lVar6.Count;
        if (iVar1 == 0) {
          uVar4 = il2cpp_runtime_class_init(&DAT_181da0308);
          uVar4 = il2cpp_internal(uVar4);
          uVar5 = il2cpp_internal(&"table内容为空");
          Exception.ctor(uVar4,uVar5,0);
          uVar5 = il2cpp_runtime_class_init(&DAT_181d5d188);
                          // WARNING: Subroutine does not return
          FUN_1800d65f0(uVar4,uVar5);
        }
        if (iVar1 <= (int)row) {
          uVar4 = il2cpp_runtime_class_init(&DAT_181da0308);
          uVar4 = il2cpp_internal(uVar4);
          uVar5 = il2cpp_internal(&"参数错误：row大于最大行");
          Exception.ctor(uVar4,uVar5,0);
          uVar5 = il2cpp_runtime_class_init(&DAT_181d5d188);
                          // WARNING: Subroutine does not return
          FUN_1800d65f0(uVar4,uVar5);
        }
        if (iVar1 == 0) {
          ThrowHelper.ThrowArgumentOutOfRangeException(0);
        }
        lVar6 = *(int64 *)(lVar6._items + 32);
        if (lVar6 != null) {
          iVar1 = lVar6.Count;
          uVar7 = 0;
          if (0 < iVar1) {
            lVar8 = 32;
            lVar6 = 0;
            do {
              lVar2 = this.table;
              if (lVar2 == null) throw; // [null/range check failed]
              if (lVar2.Count <= row) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              lVar2 = lVar2._items[row];
              if (lVar2 == null) throw; // [null/range check failed]
              if (lVar2.Count <= uVar7) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              lVar2 = *(int64 *)(lVar8 + lVar2._items);
              if (lVar2 == null) throw; // [null/range check failed]
              cVar3 = String.Equals(lVar2,str,0);
              if (cVar3) {
                return uVar7;
              }
              uVar7 = uVar7 + 1;
              lVar6 = lVar6 + 1;
              lVar8 = lVar8 + 8;
            } while (lVar6 < iVar1);
          }
          return 0xffffffff;
        }
    }

    // Token : 0x6001862
    // RVA   : 0xA81370   Offset: 0xA7FB70   Length: 0x2A5
    public int[] GetIndexsAtCol(string str, int col)
    {
        bool cVar1;
        long lVar2;
        ulong uVar3;
        ulong uVar4;
        long lVar5;
        uint uVar6;
        long lVar7;
        lVar5 = this.table;
        if (lVar5 == null) {
          uVar3 = il2cpp_runtime_class_init(&DAT_181da0308);
          uVar3 = il2cpp_internal(uVar3);
          uVar4 = il2cpp_internal(&"table尚未初始化,请检查是否成功读取");
          Exception.ctor(uVar3,uVar4,0);
          uVar4 = il2cpp_runtime_class_init(&DAT_181d5d208);
                          // WARNING: Subroutine does not return
          FUN_1800d65f0(uVar3,uVar4);
        }
        if (lVar5.Count == null) {
          uVar3 = il2cpp_runtime_class_init(&DAT_181da0308);
          uVar3 = il2cpp_internal(uVar3);
          uVar4 = il2cpp_internal(&"table内容为空");
          Exception.ctor(uVar3,uVar4,0);
          uVar4 = il2cpp_runtime_class_init(&DAT_181d5d208);
                          // WARNING: Subroutine does not return
          FUN_1800d65f0(uVar3,uVar4);
        }
        lVar5 = *(int64 *)(lVar5._items + 32);
        if (lVar5 != null) {
          if (lVar5.Count <= (int)col) {
            uVar3 = il2cpp_runtime_class_init(&DAT_181da0308);
            uVar3 = il2cpp_internal(uVar3);
            uVar4 = il2cpp_internal(&"参数错误：col大于最大列");
            Exception.ctor(uVar3,uVar4,0);
            uVar4 = il2cpp_runtime_class_init(&DAT_181d5d208);
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar3,uVar4);
          }
          lVar2 = il2cpp_internal(DAT_181d6f030);
          FUN_180f58a90(lVar2,DAT_181d678f8);
          lVar5 = this.table;
          uVar6 = 0;
          if (lVar5 != null) {
            lVar7 = 32;
            do {
              if (lVar5.Count <= (int)uVar6) {
                if (lVar2 != null) {
                  FUN_180f582c0(lVar2,DAT_181d680f0);
                  return;
                }
                break;
              }
              if (lVar5 == null) break;
              if (lVar5.Count <= uVar6) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              lVar5 = *(int64 *)(lVar7 + lVar5._items);
              if (lVar5 == null) break;
              if (lVar5.Count <= col) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              lVar5 = lVar5._items[col];
              if (lVar5 == null) break;
              cVar1 = String.Equals(lVar5,str,0);
              if (cVar1) {
                if (lVar2 == null) break;
                FUN_181814fa0(lVar2,uVar6);
              }
              lVar5 = this.table;
              uVar6 = uVar6 + 1;
              lVar7 = lVar7 + 8;
            } while (lVar5 != null);
          }
        }
    }

    // Token : 0x6001863
    // RVA   : 0xA81620   Offset: 0xA7FE20   Length: 0x2AC
    public int[] GetIndexsAtRow(string str, int row)
    {
        int iVar1;
        long lVar2;
        bool cVar3;
        long lVar4;
        ulong uVar5;
        ulong uVar6;
        long lVar7;
        uint uVar8;
        long lVar9;
        lVar4 = this.table;
        if (lVar4 == null) {
          uVar5 = il2cpp_runtime_class_init(&DAT_181da0308);
          uVar5 = il2cpp_internal(uVar5);
          uVar6 = il2cpp_internal(&"table尚未初始化,请检查是否成功读取");
          Exception.ctor(uVar5,uVar6,0);
          uVar6 = il2cpp_runtime_class_init(&DAT_181d5d288);
                          // WARNING: Subroutine does not return
          FUN_1800d65f0(uVar5,uVar6);
        }
        iVar1 = lVar4.Count;
        if (iVar1 == 0) {
          uVar5 = il2cpp_runtime_class_init(&DAT_181da0308);
          uVar5 = il2cpp_internal(uVar5);
          uVar6 = il2cpp_internal(&"table内容为空");
          Exception.ctor(uVar5,uVar6,0);
          uVar6 = il2cpp_runtime_class_init(&DAT_181d5d288);
                          // WARNING: Subroutine does not return
          FUN_1800d65f0(uVar5,uVar6);
        }
        if (iVar1 <= (int)row) {
          uVar5 = il2cpp_runtime_class_init(&DAT_181da0308);
          uVar5 = il2cpp_internal(uVar5);
          uVar6 = il2cpp_internal(&"参数错误：row大于最大行");
          Exception.ctor(uVar5,uVar6,0);
          uVar6 = il2cpp_runtime_class_init(&DAT_181d5d288);
                          // WARNING: Subroutine does not return
          FUN_1800d65f0(uVar5,uVar6);
        }
        if (iVar1 == 0) {
          ThrowHelper.ThrowArgumentOutOfRangeException(0);
        }
        lVar4 = *(int64 *)(lVar4._items + 32);
        if (lVar4 != null) {
          iVar1 = lVar4.Count;
          lVar4 = il2cpp_internal(DAT_181d6f030);
          FUN_180f58a90(lVar4,DAT_181d678f8);
          uVar8 = 0;
          if (0 < iVar1) {
            lVar9 = 32;
            lVar7 = 0;
            do {
              lVar2 = this.table;
              if (lVar2 == null) throw; // [null/range check failed]
              if (lVar2.Count <= row) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              lVar2 = lVar2._items[row];
              if (lVar2 == null) throw; // [null/range check failed]
              if (lVar2.Count <= uVar8) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              lVar2 = *(int64 *)(lVar9 + lVar2._items);
              if (lVar2 == null) throw; // [null/range check failed]
              cVar3 = String.Equals(lVar2,str,0);
              if (cVar3) {
                if (lVar4 == null) throw; // [null/range check failed]
                FUN_181814fa0(lVar4,uVar8);
              }
              uVar8 = uVar8 + 1;
              lVar7 = lVar7 + 1;
              lVar9 = lVar9 + 8;
            } while (lVar7 < iVar1);
          }
          if (lVar4 != null) {
            FUN_180f582c0(lVar4,DAT_181d680f0);
            return;
          }
        }
    }

    // Token : 0x6001864
    // RVA   : 0xA81950   Offset: 0xA80150   Length: 0x213
    public string GetValueAt(int col, int row)
    {
        int iVar1;
        long lVar2;
        ulong uVar3;
        ulong uVar4;
        lVar2 = this.table;
        if (lVar2 == null) {
          uVar3 = il2cpp_runtime_class_init(&DAT_181da0308);
          uVar3 = il2cpp_internal(uVar3);
          uVar4 = il2cpp_internal(&"table尚未初始化,请检查是否成功读取");
          Exception.ctor(uVar3,uVar4,0);
          uVar4 = il2cpp_runtime_class_init(&DAT_181d5d388);
                          // WARNING: Subroutine does not return
          FUN_1800d65f0(uVar3,uVar4);
        }
        iVar1 = lVar2.Count;
        if (iVar1 == 0) {
          uVar3 = il2cpp_runtime_class_init(&DAT_181da0308);
          uVar3 = il2cpp_internal(uVar3);
          uVar4 = il2cpp_internal(&"table内容为空");
          Exception.ctor(uVar3,uVar4,0);
          uVar4 = il2cpp_runtime_class_init(&DAT_181d5d388);
                          // WARNING: Subroutine does not return
          FUN_1800d65f0(uVar3,uVar4);
        }
        if (row < iVar1) {
          if (iVar1 == 0) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          lVar2 = *(int64 *)(lVar2._items + 32);
          if (lVar2 != null) {
            if (lVar2.Count <= col) {
              uVar3 = il2cpp_runtime_class_init(&DAT_181da0308);
              uVar3 = il2cpp_internal(uVar3);
              uVar4 = il2cpp_internal(&"参数错误：col大于最大列");
              Exception.ctor(uVar3,uVar4,0);
              uVar4 = il2cpp_runtime_class_init(&DAT_181d5d388);
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar3,uVar4);
            }
            if (this.table != null) {
              lVar2 = FUN_180002f80(this.table,row,DAT_181d51e08);
              if (lVar2 != null) {
                FUN_180002f80(lVar2,col,DAT_181d7c9c0);
                return;
              }
            }
          }
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
        uVar3 = il2cpp_runtime_class_init(&DAT_181da0308);
        uVar3 = il2cpp_internal(uVar3);
        uVar4 = il2cpp_internal(&"参数错误：row大于最大行");
        Exception.ctor(uVar3,uVar4,0);
        uVar4 = il2cpp_runtime_class_init(&DAT_181d5d388);
    }

    // Token : 0x6001865
    // RVA   : 0x210B70   Offset: 0x20F370   Length: 0x7
    public void /*ctor*/()
    {
        ZhSegment.Initialize(this,0);
    }

}
