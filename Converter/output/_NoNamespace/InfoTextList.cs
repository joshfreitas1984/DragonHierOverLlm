// ============================================================
// Type  : InfoTextList
// Token : 0x20002F1
// ============================================================

public class InfoTextList
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001846
    public List<bool> hideInfoType;

    // Token: 0x4001847
    public Text textLabel;

    // Token: 0x4001848
    public Scrollbar scrollBar;

    // Token: 0x4001849
    public Style style;

    // Token: 0x400184A
    public static int paragraphHistory;

    // Token: 0x400184B
    protected char[] mSeparator;

    // Token: 0x400184C
    private BetterList<Paragraph> mParagraphs;

    // Token: 0x400184D
    private static Dictionary<string, BetterList<Paragraph>> mHistory;

    // Token: 0x400184E
    public bool needRebuild;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60018E0
    // RVA   : 0xA1BC50   Offset: 0xA1AA50   Length: 0x16C
    protected BetterList<Paragraph> get_paragraphs()
    {
        long lVar1;
        bool cVar2;
        ulong uVar3;
        if (this.mParagraphs == null) {
          lVar1 = InfoTextList.mHistory;
          uVar3 = Object.get_name(this,0);
          if (lVar1 == null) {
        LAB_180a1bdb7:
                          // WARNING: Subroutine does not return
            FUN_1801e0300();
          }
          cVar2 = FUN_1806e3f90(lVar1,uVar3,this + 64,DAT_181e526b0);
          if (!cVar2) {
            this.mParagraphs = new BetterList_1(DAT_181e87f90);
            lVar1 = InfoTextList.mHistory;
            uVar3 = Object.get_name(this,0);
            if (lVar1 == null) goto LAB_180a1bdb7;
            FUN_1806da2f0(lVar1,uVar3,this.mParagraphs,DAT_181e52628);
          }
        }
        return this.mParagraphs;
    }

    // Token : 0x60018E1
    // RVA   : 0xA1BC30   Offset: 0xA1AA30   Length: 0x1D
    public int get_paragraphCount()
    {
        long lVar1;
        lVar1 = InfoTextList.get_paragraphs(this,0);
        if (lVar1 != null) {
          return *(uint32 *)(lVar1 + 24);
        }
    }

    // Token : 0x60018E2
    // RVA   : 0xA1BBD0   Offset: 0xA1A9D0   Length: 0x59
    public bool get_isValid()
    {
        ulong uVar1;
        uVar1 = this.textLabel;
        Object.op_Inequality(uVar1,0,0);
    }

    // Token : 0x60018E3
    // RVA   : 0xA1B5B0   Offset: 0xA1A3B0   Length: 0x4D
    public void Clear()
    {
        long lVar1;
        lVar1 = InfoTextList.get_paragraphs(this,0);
        if (lVar1 != null) {
          BetterList_1.Clear(lVar1,DAT_181e88090);
          return;
        }
    }

    // Token : 0x60018E4
    // RVA   : 0xA1BAA0   Offset: 0xA1A8A0   Length: 0x20
    private void Update()
    {
        if (this.needRebuild) {
          InfoTextList.Rebuild(this,0);
          this.needRebuild = 0;
        }
    }

    // Token : 0x60018E5
    // RVA   : 0xA1B000   Offset: 0xA19E00   Length: 0x144
    public void Add(int type, string text)
    {
        int iVar1;
        long lVar2;
        long lVar4;
        long lVar5;
        ulong uVar6;
        lVar2 = InfoTextList.get_paragraphs(this,0);
        if (lVar2 != null) {
          iVar1 = *(int *)(lVar2 + 24);
          if (iVar1 < **(int **)(DAT_181e5fbf8 + 184)) {
            lVar2 = new c.DisplayClass9_0(0);
          }
          else {
            lVar5 = this.mParagraphs;
            if ((lVar5 == null) || (lVar2 = lVar5.buffer) == null) throw; // [null/range check failed]
            if (*(int *)(lVar2 + 24) == 0) {
              uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1801e02d0(uVar6,0);
            }
            lVar2 = *(int64 *)(lVar2 + 32);
            FUN_181624ca0(lVar5,0,DAT_181e88110);
          }
          if (lVar2 != null) {
            *(int64 *)(lVar2 + 40) = text;
            *(uint32 *)(lVar2 + 32) = type;
            plVar3 = (int64 *)FUN_1801dfd90(DAT_181e84278,5);
            lVar5 = *(int64 *)(*(int64 *)(DAT_181e538e8 + 184) + 0x428);
            if (lVar5 != null) {
              if (lVar5.size <= type) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              lVar5 = lVar5.buffer[type];
              if (plVar3 != (int64 *)0) {
                if (lVar5 != null) {
                  lVar4 = il2cpp_internal(lVar5,*(uint64 *)(*plVar3 + 64));
                  if (lVar4 == null) {
                    uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                    FUN_1801e02d0(uVar6,0);
                  }
                }
                if ((int)plVar3[3] == 0) {
                  uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1801e02d0(uVar6,0);
                }
                plVar3[4] = lVar5;
                il2cpp_internal(plVar3 + 4,lVar5);
                if (text != null) {
                  lVar5 = Int32.ToString(text + 16,0);
                  if (lVar5 != null) {
                    lVar4 = il2cpp_internal(lVar5,*(uint64 *)(*plVar3 + 64));
                    if (lVar4 == null) {
                      uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                      FUN_1801e02d0(uVar6,0);
                    }
                  }
                  if (*(uint32 *)(plVar3 + 3) < 2) {
                    uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                    FUN_1801e02d0(uVar6,0);
                  }
                  plVar3[5] = lVar5;
                  il2cpp_internal(plVar3 + 5,lVar5);
                  lVar5 = Int32.ToString(text + 20,0);
                  if (lVar5 != null) {
                    lVar4 = il2cpp_internal(lVar5,*(uint64 *)(*plVar3 + 64));
                    if (lVar4 == null) {
                      uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                      FUN_1801e02d0(uVar6,0);
                    }
                  }
                  if (*(uint32 *)(plVar3 + 3) < 3) {
                    uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                    FUN_1801e02d0(uVar6,0);
                  }
                  plVar3[6] = lVar5;
                  il2cpp_internal(plVar3 + 6,lVar5);
                  lVar5 = Int32.ToString(text + 24,0);
                  if (lVar5 != null) {
                    lVar4 = il2cpp_internal(lVar5,*(uint64 *)(*plVar3 + 64));
                    if (lVar4 == null) {
                      uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                      FUN_1801e02d0(uVar6,0);
                    }
                  }
                  if (*(uint32 *)(plVar3 + 3) < 4) {
                    uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                    FUN_1801e02d0(uVar6,0);
                  }
                  plVar3[7] = lVar5;
                  il2cpp_internal(plVar3 + 7,lVar5);
                  if (param_4 != 0) {
                    lVar5 = il2cpp_internal(param_4,*(uint64 *)(*plVar3 + 64));
                    if (lVar5 == null) {
                      uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                      FUN_1801e02d0(uVar6,0);
                    }
                  }
                  if (*(uint32 *)(plVar3 + 3) < 5) {
                    uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                    FUN_1801e02d0(uVar6,0);
                  }
                  plVar3[8] = param_4;
                  il2cpp_internal(plVar3 + 8,param_4);
                  uVar6 = String.Format("[{0}{1}.{2}.{3}]{4}",plVar3,0);
                  *(uint64 *)(lVar2 + 16) = uVar6;
                  if (this.mParagraphs != null) {
                    FUN_181623290(this.mParagraphs,lVar2,DAT_181e88010);
                    this.needRebuild = 1;
                    return;
                  }
                }
              }
            }
          }
        }
    }

    // Token : 0x60018E6
    // RVA   : 0xA1B570   Offset: 0xA1A370   Length: 0x31
    public void Add(InfoData info)
    {
        int iVar1;
        long lVar2;
        long lVar4;
        long lVar5;
        ulong uVar6;
        lVar2 = InfoTextList.get_paragraphs(this,0);
        if (lVar2 != null) {
          iVar1 = *(int *)(lVar2 + 24);
          if (iVar1 < **(int **)(DAT_181e5fbf8 + 184)) {
            lVar2 = new c.DisplayClass9_0(0);
          }
          else {
            lVar5 = this.mParagraphs;
            if ((lVar5 == null) || (lVar2 = lVar5.buffer) == null) throw; // [null/range check failed]
            if (*(int *)(lVar2 + 24) == 0) {
              uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1801e02d0(uVar6,0);
            }
            lVar2 = *(int64 *)(lVar2 + 32);
            FUN_181624ca0(lVar5,0,DAT_181e88110);
          }
          if (lVar2 != null) {
            *(int64 *)(lVar2 + 40) = param_3;
            *(uint32 *)(lVar2 + 32) = info;
            plVar3 = (int64 *)FUN_1801dfd90(DAT_181e84278,5);
            lVar5 = *(int64 *)(*(int64 *)(DAT_181e538e8 + 184) + 0x428);
            if (lVar5 != null) {
              if (lVar5.size <= info) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              lVar5 = lVar5.buffer[info];
              if (plVar3 != (int64 *)0) {
                if (lVar5 != null) {
                  lVar4 = il2cpp_internal(lVar5,*(uint64 *)(*plVar3 + 64));
                  if (lVar4 == null) {
                    uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                    FUN_1801e02d0(uVar6,0);
                  }
                }
                if ((int)plVar3[3] == 0) {
                  uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1801e02d0(uVar6,0);
                }
                plVar3[4] = lVar5;
                il2cpp_internal(plVar3 + 4,lVar5);
                if (param_3 != 0) {
                  lVar5 = Int32.ToString(param_3 + 16,0);
                  if (lVar5 != null) {
                    lVar4 = il2cpp_internal(lVar5,*(uint64 *)(*plVar3 + 64));
                    if (lVar4 == null) {
                      uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                      FUN_1801e02d0(uVar6,0);
                    }
                  }
                  if (*(uint32 *)(plVar3 + 3) < 2) {
                    uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                    FUN_1801e02d0(uVar6,0);
                  }
                  plVar3[5] = lVar5;
                  il2cpp_internal(plVar3 + 5,lVar5);
                  lVar5 = Int32.ToString(param_3 + 20,0);
                  if (lVar5 != null) {
                    lVar4 = il2cpp_internal(lVar5,*(uint64 *)(*plVar3 + 64));
                    if (lVar4 == null) {
                      uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                      FUN_1801e02d0(uVar6,0);
                    }
                  }
                  if (*(uint32 *)(plVar3 + 3) < 3) {
                    uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                    FUN_1801e02d0(uVar6,0);
                  }
                  plVar3[6] = lVar5;
                  il2cpp_internal(plVar3 + 6,lVar5);
                  lVar5 = Int32.ToString(param_3 + 24,0);
                  if (lVar5 != null) {
                    lVar4 = il2cpp_internal(lVar5,*(uint64 *)(*plVar3 + 64));
                    if (lVar4 == null) {
                      uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                      FUN_1801e02d0(uVar6,0);
                    }
                  }
                  if (*(uint32 *)(plVar3 + 3) < 4) {
                    uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                    FUN_1801e02d0(uVar6,0);
                  }
                  plVar3[7] = lVar5;
                  il2cpp_internal(plVar3 + 7,lVar5);
                  if (param_4 != 0) {
                    lVar5 = il2cpp_internal(param_4,*(uint64 *)(*plVar3 + 64));
                    if (lVar5 == null) {
                      uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                      FUN_1801e02d0(uVar6,0);
                    }
                  }
                  if (*(uint32 *)(plVar3 + 3) < 5) {
                    uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                    FUN_1801e02d0(uVar6,0);
                  }
                  plVar3[8] = param_4;
                  il2cpp_internal(plVar3 + 8,param_4);
                  uVar6 = String.Format("[{0}{1}.{2}.{3}]{4}",plVar3,0);
                  *(uint64 *)(lVar2 + 16) = uVar6;
                  if (this.mParagraphs != null) {
                    FUN_181623290(this.mParagraphs,lVar2,DAT_181e88010);
                    this.needRebuild = 1;
                    return;
                  }
                }
              }
            }
          }
        }
    }

    // Token : 0x60018E7
    // RVA   : 0xA1B150   Offset: 0xA19F50   Length: 0x412
    protected void Add(int type, TimeData time, string text, bool updateVisible)
    {
        int iVar1;
        long lVar2;
        long lVar4;
        long lVar5;
        ulong uVar6;
        lVar2 = InfoTextList.get_paragraphs(this,0);
        if (lVar2 != null) {
          iVar1 = *(int *)(lVar2 + 24);
          if (iVar1 < **(int **)(DAT_181e5fbf8 + 184)) {
            lVar2 = new c.DisplayClass9_0(0);
          }
          else {
            lVar5 = this.mParagraphs;
            if ((lVar5 == null) || (lVar2 = lVar5.buffer) == null) throw; // [null/range check failed]
            if (*(int *)(lVar2 + 24) == 0) {
              uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1801e02d0(uVar6,0);
            }
            lVar2 = *(int64 *)(lVar2 + 32);
            FUN_181624ca0(lVar5,0,DAT_181e88110);
          }
          if (lVar2 != null) {
            *(int64 *)(lVar2 + 40) = time;
            *(uint32 *)(lVar2 + 32) = type;
            plVar3 = (int64 *)FUN_1801dfd90(DAT_181e84278,5);
            lVar5 = *(int64 *)(*(int64 *)(DAT_181e538e8 + 184) + 0x428);
            if (lVar5 != null) {
              if (lVar5.size <= type) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              lVar5 = lVar5.buffer[type];
              if (plVar3 != (int64 *)0) {
                if (lVar5 != null) {
                  lVar4 = il2cpp_internal(lVar5,*(uint64 *)(*plVar3 + 64));
                  if (lVar4 == null) {
                    uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                    FUN_1801e02d0(uVar6,0);
                  }
                }
                if ((int)plVar3[3] == 0) {
                  uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1801e02d0(uVar6,0);
                }
                plVar3[4] = lVar5;
                il2cpp_internal(plVar3 + 4,lVar5);
                if (time != null) {
                  lVar5 = Int32.ToString(time + 16,0);
                  if (lVar5 != null) {
                    lVar4 = il2cpp_internal(lVar5,*(uint64 *)(*plVar3 + 64));
                    if (lVar4 == null) {
                      uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                      FUN_1801e02d0(uVar6,0);
                    }
                  }
                  if (*(uint32 *)(plVar3 + 3) < 2) {
                    uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                    FUN_1801e02d0(uVar6,0);
                  }
                  plVar3[5] = lVar5;
                  il2cpp_internal(plVar3 + 5,lVar5);
                  lVar5 = Int32.ToString(time + 20,0);
                  if (lVar5 != null) {
                    lVar4 = il2cpp_internal(lVar5,*(uint64 *)(*plVar3 + 64));
                    if (lVar4 == null) {
                      uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                      FUN_1801e02d0(uVar6,0);
                    }
                  }
                  if (*(uint32 *)(plVar3 + 3) < 3) {
                    uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                    FUN_1801e02d0(uVar6,0);
                  }
                  plVar3[6] = lVar5;
                  il2cpp_internal(plVar3 + 6,lVar5);
                  lVar5 = Int32.ToString(time + 24,0);
                  if (lVar5 != null) {
                    lVar4 = il2cpp_internal(lVar5,*(uint64 *)(*plVar3 + 64));
                    if (lVar4 == null) {
                      uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                      FUN_1801e02d0(uVar6,0);
                    }
                  }
                  if (*(uint32 *)(plVar3 + 3) < 4) {
                    uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                    FUN_1801e02d0(uVar6,0);
                  }
                  plVar3[7] = lVar5;
                  il2cpp_internal(plVar3 + 7,lVar5);
                  if (text != null) {
                    lVar5 = il2cpp_internal(text,*(uint64 *)(*plVar3 + 64));
                    if (lVar5 == null) {
                      uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                      FUN_1801e02d0(uVar6,0);
                    }
                  }
                  if (*(uint32 *)(plVar3 + 3) < 5) {
                    uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                    FUN_1801e02d0(uVar6,0);
                  }
                  plVar3[8] = text;
                  il2cpp_internal(plVar3 + 8,text);
                  uVar6 = String.Format("[{0}{1}.{2}.{3}]{4}",plVar3,0);
                  *(uint64 *)(lVar2 + 16) = uVar6;
                  if (this.mParagraphs != null) {
                    FUN_181623290(this.mParagraphs,lVar2,DAT_181e88010);
                    this.needRebuild = 1;
                    return;
                  }
                }
              }
            }
          }
        }
    }

    // Token : 0x60018E8
    // RVA   : 0xA1B600   Offset: 0xA1A400   Length: 0x21E
    protected void Rebuild()
    {
        long lVar1;
        uint uVar2;
        uint uVar3;
        long lVar4;
        bool cVar5;
        long lVar6;
        ulong uVar7;
        ulong uVar8;
        uVar7 = this.textLabel;
        cVar5 = Object.op_Inequality(uVar7,0,0);
        uVar7 = "";
        if (cVar5) {
          lVar6 = InfoTextList.get_paragraphs(this,0);
          if (lVar6 == null) {
        LAB_180a1b7f9:
                          // WARNING: Subroutine does not return
            FUN_1801e0300();
          }
          uVar2 = *(uint32 *)(lVar6 + 24);
          while (uVar2 = uVar2 - 1, -1 < (int)uVar2) {
            if ((this.mParagraphs == null) ||
               (lVar6 = this.mParagraphs.buffer) == null)
            goto LAB_180a1b7f9;
            if (*(uint32 *)(lVar6 + 24) <= uVar2) {
              uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1801e02d0(uVar7,0);
            }
            lVar1 = (int64)(int)uVar2 * 8 + 32;
            lVar6 = *(int64 *)(lVar1 + lVar6);
            if ((lVar6 == null) || (lVar4 = this.hideInfoType) == null) goto LAB_180a1b7f9;
            uVar3 = *(uint32 *)(lVar6 + 32);
            if (*(uint32 *)(lVar4 + 24) <= uVar3) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            if (*(char *)(*(int64 *)(lVar4 + 16) + 32 + (int64)(int)uVar3) == false) {
              cVar5 = FUN_1816387f0(uVar7,"",0);
              uVar8 = "\n";
              if (cVar5) {
                uVar8 = "";
              }
              lVar6 = InfoTextList.get_paragraphs(this,0);
              if ((lVar6 == null) || (lVar6 = *(int64 *)(lVar6 + 16)) == null) goto LAB_180a1b7f9;
              if (*(uint32 *)(lVar6 + 24) <= uVar2) {
                uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1801e02d0(uVar7,0);
              }
              lVar6 = *(int64 *)(lVar1 + lVar6);
              if (lVar6 == null) goto LAB_180a1b7f9;
              uVar7 = String.Concat(uVar7,uVar8,*(uint64 *)(lVar6 + 16),0);
            }
          }
          uVar8 = this.textLabel;
          LTLocalization.SetText(uVar8,uVar7,0);
        }
    }

    // Token : 0x60018E9
    // RVA   : 0xA1B820   Offset: 0xA1A620   Length: 0x279
    public void TypeTabClicked(GameObject tab)
    {
        long lVar1;
        uint uVar2;
        uint uVar3;
        ulong uVar4;
        long lVar5;
        uint local_28;
        uint uStack_24;
        uint uStack_20;
        uint32 uStack_1c;
        lVar5 = this.hideInfoType;
        if (tab != null) {
          uVar4 = Object.get_name(tab,0);
          uVar2 = Int32.Parse(uVar4,0);
          lVar1 = this.hideInfoType;
          uVar4 = Object.get_name(tab,0);
          uVar3 = Int32.Parse(uVar4,0);
          if (lVar1 != null) {
            if (lVar1.Count <= uVar3) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            if (lVar5 != null) {
              FUN_18166b1c0(lVar5,uVar2,
                            *(char *)(lVar1._items + 32 + (int64)(int)uVar3) == false,
                            DAT_181e627f8);
              lVar5 = GameObject.get_transform(tab,0);
              if (lVar5 != null) {
                lVar5 = Transform.Find(lVar5,"Text",0);
                if (lVar5 != null) {
                  plVar6 = (int64 *)Component.GetComponent(lVar5);
                  lVar5 = this.hideInfoType;
                  uVar4 = Object.get_name(tab);
                  uVar3 = Int32.Parse(uVar4);
                  if (lVar5 != null) {
                    if (lVar5.Count <= uVar3) {
                      ThrowHelper.ThrowArgumentOutOfRangeException(0);
                    }
                    if (*(char *)(lVar5._items + 32 + (int64)(int)uVar3) == false) {
                      puVar7 = (uint32 *)FUN_180f24d00(&local_28);
                    }
                    else {
                      puVar7 = (uint32 *)FUN_180f24b80();
                    }
                    if (plVar6 != (int64 *)0) {
                      local_28 = *puVar7;
                      uStack_24 = puVar7[1];
                      uStack_20 = puVar7[2];
                      uStack_1c = puVar7[3];
                      (**(code **)(*plVar6 + 0x2a8))(plVar6,&local_28,*(uint64 *)(*plVar6 + 0x2b0));
                      lVar5 = GameObject.get_transform(tab,0);
                      if (lVar5 != null) {
                        lVar5 = Transform.Find(lVar5,"HighLight",0);
                        if (lVar5 != null) {
                          plVar6 = (int64 *)Component.GetComponent(lVar5);
                          lVar5 = this.hideInfoType;
                          uVar4 = Object.get_name(tab);
                          uVar3 = Int32.Parse(uVar4);
                          if (lVar5 != null) {
                            if (lVar5.Count <= uVar3) {
                              ThrowHelper.ThrowArgumentOutOfRangeException(0);
                            }
                            if (*(char *)(lVar5._items + 32 + (int64)(int)uVar3) ==
                                false) {
                              puVar7 = (uint32 *)FUN_180f24d00(&local_28);
                            }
                            else {
                              puVar7 = (uint32 *)FUN_180f24b80();
                            }
                            if (plVar6 != (int64 *)0) {
                              local_28 = *puVar7;
                              uStack_24 = puVar7[1];
                              uStack_20 = puVar7[2];
                              uStack_1c = puVar7[3];
                              (**(code **)(*plVar6 + 0x2a8))
                                        (plVar6,&local_28,*(uint64 *)(*plVar6 + 0x2b0));
                              this.needRebuild = 1;
                              return;
                            }
                          }
                        }
                      }
                    }
                  }
                }
              }
            }
          }
        }
    }

    // Token : 0x60018EA
    // RVA   : 0xA1BB50   Offset: 0xA1A950   Length: 0x7D
    public void /*ctor*/()
    {
        long lVar1;
        ulong uVar2;
        lVar1 = FUN_1801dfd90(DAT_181e81128,1);
        if (lVar1 != null) {
          if (*(int *)(lVar1 + 24) != 0) {
            *(uint16 *)(lVar1 + 32) = 10;
            this.mSeparator = lVar1;
            FUN_180ae8740(this,0);
            return;
          }
          uVar2 = il2cpp_internal();
                          // WARNING: Subroutine does not return
          FUN_1801e02d0(uVar2,0);
        }
    }

    // Token : 0x60018EB
    // RVA   : 0xA1BAC0   Offset: 0xA1A8C0   Length: 0x8E
    private static void /*cctor*/()
    {
        ulong uVar1;
        **(uint32 **)(DAT_181e5fbf8 + 184) = 100;
        uVar1 = il2cpp_internal(DAT_181e623c0);
        FUN_1806e5bc0(uVar1,DAT_181e525a0);
        puVar2 = (uint64 *)(*(int64 *)(DAT_181e5fbf8 + 184) + 8);
        *puVar2 = uVar1;
        il2cpp_internal(puVar2,uVar1);
    }

}
