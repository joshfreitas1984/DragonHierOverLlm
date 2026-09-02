// ============================================================
// Type  : InfoTextList
// Token : 0x20002E2
// ============================================================

public class InfoTextList
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x400173D
    public List<bool> hideInfoType;

    // Token: 0x400173E
    public Text textLabel;

    // Token: 0x400173F
    public Scrollbar scrollBar;

    // Token: 0x4001740
    public Style style;

    // Token: 0x4001741
    public static int paragraphHistory;

    // Token: 0x4001742
    protected char[] mSeparator;

    // Token: 0x4001743
    private BetterList<Paragraph> mParagraphs;

    // Token: 0x4001744
    private static Dictionary<string, BetterList<Paragraph>> mHistory;

    // Token: 0x4001745
    public bool needRebuild;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6001820
    // RVA   : 0xB6FBB0   Offset: 0xB6E3B0   Length: 0x16C
    protected BetterList<Paragraph> get_paragraphs()
    {
        var pStatics = *(int64*)(DAT_181d5a6f8 + 184);
        long lVar1;
        bool cVar2;
        ulong uVar3;
        if (this.mParagraphs == null) {
          lVar1 = *(int64 *)(pStatics + 8);
          uVar3 = Object.get_name(this,0);
          if (lVar1 == null) {
        LAB_180b6fd17:
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          cVar2 = FUN_1808addd0(lVar1,uVar3,this + 64,DAT_181da20f8);
          if (!cVar2) {
            this.mParagraphs = new BetterList_1(DAT_181d82218);
            lVar1 = *(int64 *)(pStatics + 8);
            uVar3 = Object.get_name(this,0);
            if (lVar1 == null) goto LAB_180b6fd17;
            FUN_1808ab680(lVar1,uVar3,this.mParagraphs,DAT_181da2078);
          }
        }
        return this.mParagraphs;
    }

    // Token : 0x6001821
    // RVA   : 0xB6FB90   Offset: 0xB6E390   Length: 0x1D
    public int get_paragraphCount()
    {
        long lVar1;
        lVar1 = InfoTextList.get_paragraphs(this,0);
        if (lVar1 != null) {
          return *(uint32 *)(lVar1 + 24);
        }
    }

    // Token : 0x6001822
    // RVA   : 0xB6FB30   Offset: 0xB6E330   Length: 0x59
    public bool get_isValid()
    {
        ulong uVar1;
        uVar1 = this.textLabel;
        Object.op_Inequality(uVar1,0,0);
    }

    // Token : 0x6001823
    // RVA   : 0xB6F540   Offset: 0xB6DD40   Length: 0x4D
    public void Clear()
    {
        long lVar1;
        lVar1 = InfoTextList.get_paragraphs(this,0);
        if (lVar1 != null) {
          BetterList_1.Clear(lVar1,DAT_181d82318);
          return;
        }
    }

    // Token : 0x6001824
    // RVA   : 0xB6FA00   Offset: 0xB6E200   Length: 0x20
    private void Update()
    {
        if (this.needRebuild) {
          InfoTextList.Rebuild(this,0);
          this.needRebuild = 0;
        }
    }

    // Token : 0x6001825
    // RVA   : 0xB6EF90   Offset: 0xB6D790   Length: 0x144
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
          if (iVar1 < **(int **)(DAT_181d5a6f8 + 184)) {
            lVar2 = new c.DisplayClass9_0(0);
          }
          else {
            lVar5 = this.mParagraphs;
            if ((lVar5 == null) || (lVar2 = lVar5.buffer) == null) throw; // [null/range check failed]
            if (*(int *)(lVar2 + 24) == 0) {
              uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar6,0);
            }
            lVar2 = *(int64 *)(lVar2 + 32);
            FUN_18154e570(lVar5,0,DAT_181d82398);
          }
          if (lVar2 != null) {
            *(int64 *)(lVar2 + 40) = text;
            *(uint32 *)(lVar2 + 32) = type;
            plVar3 = (int64 *)FUN_1800d60b0(DAT_181d7f180,5);
            lVar5 = *(int64 *)(*(int64 *)(DAT_181d4ef00 + 184) + 0x418);
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
                    FUN_1800d65f0(uVar6,0);
                  }
                }
                if ((int)plVar3[3] == 0) {
                  uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1800d65f0(uVar6,0);
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
                      FUN_1800d65f0(uVar6,0);
                    }
                  }
                  if (*(uint32 *)(plVar3 + 3) < 2) {
                    uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                    FUN_1800d65f0(uVar6,0);
                  }
                  plVar3[5] = lVar5;
                  il2cpp_internal(plVar3 + 5,lVar5);
                  lVar5 = Int32.ToString(text + 20,0);
                  if (lVar5 != null) {
                    lVar4 = il2cpp_internal(lVar5,*(uint64 *)(*plVar3 + 64));
                    if (lVar4 == null) {
                      uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                      FUN_1800d65f0(uVar6,0);
                    }
                  }
                  if (*(uint32 *)(plVar3 + 3) < 3) {
                    uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                    FUN_1800d65f0(uVar6,0);
                  }
                  plVar3[6] = lVar5;
                  il2cpp_internal(plVar3 + 6,lVar5);
                  lVar5 = Int32.ToString(text + 24,0);
                  if (lVar5 != null) {
                    lVar4 = il2cpp_internal(lVar5,*(uint64 *)(*plVar3 + 64));
                    if (lVar4 == null) {
                      uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                      FUN_1800d65f0(uVar6,0);
                    }
                  }
                  if (*(uint32 *)(plVar3 + 3) < 4) {
                    uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                    FUN_1800d65f0(uVar6,0);
                  }
                  plVar3[7] = lVar5;
                  il2cpp_internal(plVar3 + 7,lVar5);
                  if (param_4 != 0) {
                    lVar5 = il2cpp_internal(param_4,*(uint64 *)(*plVar3 + 64));
                    if (lVar5 == null) {
                      uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                      FUN_1800d65f0(uVar6,0);
                    }
                  }
                  if (*(uint32 *)(plVar3 + 3) < 5) {
                    uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                    FUN_1800d65f0(uVar6,0);
                  }
                  plVar3[8] = param_4;
                  il2cpp_internal(plVar3 + 8,param_4);
                  uVar6 = String.Format("[{0}{1}.{2}.{3}]{4}",plVar3,0);
                  *(uint64 *)(lVar2 + 16) = uVar6;
                  if (this.mParagraphs != null) {
                    FUN_18154cb60(this.mParagraphs,lVar2,DAT_181d82298);
                    this.needRebuild = 1;
                    return;
                  }
                }
              }
            }
          }
        }
    }

    // Token : 0x6001826
    // RVA   : 0xB6F500   Offset: 0xB6DD00   Length: 0x31
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
          if (iVar1 < **(int **)(DAT_181d5a6f8 + 184)) {
            lVar2 = new c.DisplayClass9_0(0);
          }
          else {
            lVar5 = this.mParagraphs;
            if ((lVar5 == null) || (lVar2 = lVar5.buffer) == null) throw; // [null/range check failed]
            if (*(int *)(lVar2 + 24) == 0) {
              uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar6,0);
            }
            lVar2 = *(int64 *)(lVar2 + 32);
            FUN_18154e570(lVar5,0,DAT_181d82398);
          }
          if (lVar2 != null) {
            *(int64 *)(lVar2 + 40) = param_3;
            *(uint32 *)(lVar2 + 32) = info;
            plVar3 = (int64 *)FUN_1800d60b0(DAT_181d7f180,5);
            lVar5 = *(int64 *)(*(int64 *)(DAT_181d4ef00 + 184) + 0x418);
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
                    FUN_1800d65f0(uVar6,0);
                  }
                }
                if ((int)plVar3[3] == 0) {
                  uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1800d65f0(uVar6,0);
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
                      FUN_1800d65f0(uVar6,0);
                    }
                  }
                  if (*(uint32 *)(plVar3 + 3) < 2) {
                    uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                    FUN_1800d65f0(uVar6,0);
                  }
                  plVar3[5] = lVar5;
                  il2cpp_internal(plVar3 + 5,lVar5);
                  lVar5 = Int32.ToString(param_3 + 20,0);
                  if (lVar5 != null) {
                    lVar4 = il2cpp_internal(lVar5,*(uint64 *)(*plVar3 + 64));
                    if (lVar4 == null) {
                      uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                      FUN_1800d65f0(uVar6,0);
                    }
                  }
                  if (*(uint32 *)(plVar3 + 3) < 3) {
                    uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                    FUN_1800d65f0(uVar6,0);
                  }
                  plVar3[6] = lVar5;
                  il2cpp_internal(plVar3 + 6,lVar5);
                  lVar5 = Int32.ToString(param_3 + 24,0);
                  if (lVar5 != null) {
                    lVar4 = il2cpp_internal(lVar5,*(uint64 *)(*plVar3 + 64));
                    if (lVar4 == null) {
                      uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                      FUN_1800d65f0(uVar6,0);
                    }
                  }
                  if (*(uint32 *)(plVar3 + 3) < 4) {
                    uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                    FUN_1800d65f0(uVar6,0);
                  }
                  plVar3[7] = lVar5;
                  il2cpp_internal(plVar3 + 7,lVar5);
                  if (param_4 != 0) {
                    lVar5 = il2cpp_internal(param_4,*(uint64 *)(*plVar3 + 64));
                    if (lVar5 == null) {
                      uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                      FUN_1800d65f0(uVar6,0);
                    }
                  }
                  if (*(uint32 *)(plVar3 + 3) < 5) {
                    uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                    FUN_1800d65f0(uVar6,0);
                  }
                  plVar3[8] = param_4;
                  il2cpp_internal(plVar3 + 8,param_4);
                  uVar6 = String.Format("[{0}{1}.{2}.{3}]{4}",plVar3,0);
                  *(uint64 *)(lVar2 + 16) = uVar6;
                  if (this.mParagraphs != null) {
                    FUN_18154cb60(this.mParagraphs,lVar2,DAT_181d82298);
                    this.needRebuild = 1;
                    return;
                  }
                }
              }
            }
          }
        }
    }

    // Token : 0x6001827
    // RVA   : 0xB6F0E0   Offset: 0xB6D8E0   Length: 0x412
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
          if (iVar1 < **(int **)(DAT_181d5a6f8 + 184)) {
            lVar2 = new c.DisplayClass9_0(0);
          }
          else {
            lVar5 = this.mParagraphs;
            if ((lVar5 == null) || (lVar2 = lVar5.buffer) == null) throw; // [null/range check failed]
            if (*(int *)(lVar2 + 24) == 0) {
              uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar6,0);
            }
            lVar2 = *(int64 *)(lVar2 + 32);
            FUN_18154e570(lVar5,0,DAT_181d82398);
          }
          if (lVar2 != null) {
            *(int64 *)(lVar2 + 40) = time;
            *(uint32 *)(lVar2 + 32) = type;
            plVar3 = (int64 *)FUN_1800d60b0(DAT_181d7f180,5);
            lVar5 = *(int64 *)(*(int64 *)(DAT_181d4ef00 + 184) + 0x418);
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
                    FUN_1800d65f0(uVar6,0);
                  }
                }
                if ((int)plVar3[3] == 0) {
                  uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1800d65f0(uVar6,0);
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
                      FUN_1800d65f0(uVar6,0);
                    }
                  }
                  if (*(uint32 *)(plVar3 + 3) < 2) {
                    uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                    FUN_1800d65f0(uVar6,0);
                  }
                  plVar3[5] = lVar5;
                  il2cpp_internal(plVar3 + 5,lVar5);
                  lVar5 = Int32.ToString(time + 20,0);
                  if (lVar5 != null) {
                    lVar4 = il2cpp_internal(lVar5,*(uint64 *)(*plVar3 + 64));
                    if (lVar4 == null) {
                      uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                      FUN_1800d65f0(uVar6,0);
                    }
                  }
                  if (*(uint32 *)(plVar3 + 3) < 3) {
                    uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                    FUN_1800d65f0(uVar6,0);
                  }
                  plVar3[6] = lVar5;
                  il2cpp_internal(plVar3 + 6,lVar5);
                  lVar5 = Int32.ToString(time + 24,0);
                  if (lVar5 != null) {
                    lVar4 = il2cpp_internal(lVar5,*(uint64 *)(*plVar3 + 64));
                    if (lVar4 == null) {
                      uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                      FUN_1800d65f0(uVar6,0);
                    }
                  }
                  if (*(uint32 *)(plVar3 + 3) < 4) {
                    uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                    FUN_1800d65f0(uVar6,0);
                  }
                  plVar3[7] = lVar5;
                  il2cpp_internal(plVar3 + 7,lVar5);
                  if (text != null) {
                    lVar5 = il2cpp_internal(text,*(uint64 *)(*plVar3 + 64));
                    if (lVar5 == null) {
                      uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                      FUN_1800d65f0(uVar6,0);
                    }
                  }
                  if (*(uint32 *)(plVar3 + 3) < 5) {
                    uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                    FUN_1800d65f0(uVar6,0);
                  }
                  plVar3[8] = text;
                  il2cpp_internal(plVar3 + 8,text);
                  uVar6 = String.Format("[{0}{1}.{2}.{3}]{4}",plVar3,0);
                  *(uint64 *)(lVar2 + 16) = uVar6;
                  if (this.mParagraphs != null) {
                    FUN_18154cb60(this.mParagraphs,lVar2,DAT_181d82298);
                    this.needRebuild = 1;
                    return;
                  }
                }
              }
            }
          }
        }
    }

    // Token : 0x6001828
    // RVA   : 0xB6F590   Offset: 0xB6DD90   Length: 0x1E9
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
        LAB_180b6f754:
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          uVar2 = *(uint32 *)(lVar6 + 24);
          while (uVar2 = uVar2 - 1, -1 < (int)uVar2) {
            if ((this.mParagraphs == null) ||
               (lVar6 = this.mParagraphs.buffer) == null)
            goto LAB_180b6f754;
            if (*(uint32 *)(lVar6 + 24) <= uVar2) {
              uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar7,0);
            }
            lVar1 = (int64)(int)uVar2 * 8 + 32;
            lVar6 = *(int64 *)(lVar1 + lVar6);
            if ((lVar6 == null) || (lVar4 = this.hideInfoType) == null) goto LAB_180b6f754;
            uVar3 = *(uint32 *)(lVar6 + 32);
            if (*(uint32 *)(lVar4 + 24) <= uVar3) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            if (*(char *)(*(int64 *)(lVar4 + 16) + 32 + (int64)(int)uVar3) == false) {
              cVar5 = FUN_1816fd990(uVar7,"",0);
              uVar8 = "\n";
              if (cVar5) {
                uVar8 = "";
              }
              lVar6 = InfoTextList.get_paragraphs(this,0);
              if ((lVar6 == null) || (lVar6 = *(int64 *)(lVar6 + 16)) == null) goto LAB_180b6f754;
              if (*(uint32 *)(lVar6 + 24) <= uVar2) {
                uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar7,0);
              }
              lVar6 = *(int64 *)(lVar1 + lVar6);
              if (lVar6 == null) goto LAB_180b6f754;
              uVar7 = String.Concat(uVar7,uVar8,*(uint64 *)(lVar6 + 16),0);
            }
          }
          LTLocalization.SetText(this.textLabel,uVar7,0);
        }
    }

    // Token : 0x6001829
    // RVA   : 0xB6F780   Offset: 0xB6DF80   Length: 0x279
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
              FUN_181814bb0(lVar5,uVar2,
                            *(char *)(lVar1._items + 32 + (int64)(int)uVar3) == false,
                            DAT_181d58f90);
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
                      puVar7 = (uint32 *)FUN_181098a50(&local_28);
                    }
                    else {
                      puVar7 = (uint32 *)FUN_1810988d0();
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
                              puVar7 = (uint32 *)FUN_181098a50(&local_28);
                            }
                            else {
                              puVar7 = (uint32 *)FUN_1810988d0();
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

    // Token : 0x600182A
    // RVA   : 0xB6FAB0   Offset: 0xB6E2B0   Length: 0x7D
    public void /*ctor*/()
    {
        long lVar1;
        ulong uVar2;
        lVar1 = FUN_1800d60b0(DAT_181d7c118,1);
        if (lVar1 != null) {
          if (*(int *)(lVar1 + 24) != 0) {
            *(uint16 *)(lVar1 + 32) = 10;
            this.mSeparator = lVar1;
            FUN_18044ef50(this,0);
            return;
          }
          uVar2 = il2cpp_internal();
                          // WARNING: Subroutine does not return
          FUN_1800d65f0(uVar2,0);
        }
    }

    // Token : 0x600182B
    // RVA   : 0xB6FA20   Offset: 0xB6E220   Length: 0x8E
    private static void /*cctor*/()
    {
        ulong uVar1;
        **(uint32 **)(DAT_181d5a6f8 + 184) = 100;
        uVar1 = il2cpp_internal(DAT_181d5db48);
        FUN_1808ae540(uVar1,DAT_181da1ff8);
        puVar2 = (uint64 *)(*(int64 *)(DAT_181d5a6f8 + 184) + 8);
        *puVar2 = uVar1;
        il2cpp_internal(puVar2,uVar1);
    }

}
