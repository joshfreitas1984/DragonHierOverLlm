// ============================================================
// Type  : NGUIAtlas
// Token : 0x20000CA
// ============================================================

public class NGUIAtlas
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x40004C4
    private Material material;

    // Token: 0x40004C5
    private List<UISpriteData> mSprites;

    // Token: 0x40004C6
    private float mPixelSize;

    // Token: 0x40004C7
    private object mReplacement;

    // Token: 0x40004C8
    private int mPMA;

    // Token: 0x40004C9
    private Dictionary<string, int> mSpriteIndices;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000631
    // RVA   : 0xAFB690   Offset: 0xAF9E90   Length: 0x54
    public virtual Material get_spriteMaterial()
    {
        long lVar1;
        ulong uVar2;
        lVar1 = NGUIAtlas.get_replacement(this,0);
        if (lVar1 != null) {
          uVar2 = FUN_180002970(0,DAT_181d55650,lVar1);
          return uVar2;
        }
        return this.material;
    }

    // Token : 0x6000632
    // RVA   : 0xAFBB00   Offset: 0xAFA300   Length: 0x10D
    public virtual void set_spriteMaterial(Material value)
    {
        ulong uVar1;
        bool cVar2;
        long lVar3;
        lVar3 = NGUIAtlas.get_replacement(this,0);
        if (lVar3 != null) {
          FUN_180004720(1,DAT_181d55650,lVar3,value);
          return;
        }
        uVar1 = this.material;
        cVar2 = Object.op_Equality(uVar1,0,0);
        if (!cVar2) {
          NGUIAtlas.MarkAsChanged(this,0);
          this.mPMA = 0xffffffff;
          this.material = value;
          NGUIAtlas.MarkAsChanged(this,0);
          return;
        }
        this.mPMA = 0;
        this.material = value;
    }

    // Token : 0x6000633
    // RVA   : 0xAFB390   Offset: 0xAF9B90   Length: 0x197
    public virtual bool get_premultipliedAlpha()
    {
        bool cVar1;
        long lVar2;
        ulong uVar3;
        ulong uVar4;
        lVar2 = NGUIAtlas.get_replacement(this,0);
        if (lVar2 != null) {
          uVar3 = FUN_180002970(7,DAT_181d55650,lVar2);
          return uVar3;
        }
        uVar4 = (uint64)this.mPMA;
        if (this.mPMA != 0xffffffff) goto LAB_180afb4f8;
        lVar2 = NGUIAtlas.get_replacement(this,0);
        if (lVar2 == null) {
          lVar2 = this.material;
        }
        else {
          lVar2 = FUN_180002970(0,DAT_181d55650,lVar2);
        }
        cVar1 = Object.op_Inequality(lVar2,0,0);
        if (!cVar1) {
        LAB_180afb4f3:
          uVar4 = 0;
        }
        else {
          if (lVar2 == null) goto LAB_180afb522;
          uVar3 = Material.get_shader(lVar2,0);
          cVar1 = Object.op_Inequality(uVar3,0,0);
          if (!cVar1) goto LAB_180afb4f3;
          lVar2 = Material.get_shader(lVar2,0);
          if (lVar2 == null) {
        LAB_180afb522:
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          lVar2 = Object.get_name(lVar2,0);
          if (lVar2 == null) goto LAB_180afb522;
          cVar1 = String.Contains(lVar2,"Premultiplied",0);
          if (!cVar1) goto LAB_180afb4f3;
          uVar4 = 1;
        }
        this.mPMA = (int)uVar4;
        LAB_180afb4f8:
        return CONCAT71((int7)(uVar4 >> 8),(int)uVar4 == 1);
    }

    // Token : 0x6000634
    // RVA   : 0xAFB5C0   Offset: 0xAF9DC0   Length: 0xC3
    public virtual List<UISpriteData> get_spriteList()
    {
        long lVar1;
        ulong uVar4;
        ushort uVar5;
        plVar2 = (int64 *)NGUIAtlas.get_replacement(this,0);
        if (plVar2 == (int64 *)0) {
          return this.mSprites;
        }
        lVar1 = *plVar2;
        uVar5 = 0;
        if (*(uint16 *)(lVar1 + 0x12a) != 0) {
          do {
            if (*(int64 *)(*(int64 *)(lVar1 + 176) + (uint64)uVar5 * 16) == DAT_181d55650) {
              puVar3 = (uint64 *)
                       ((int64)*(int *)(*(int64 *)(lVar1 + 176) + 8 + (uint64)uVar5 * 16) *
                        16 + 0x158 + lVar1);
              goto LAB_180afb658;
            }
            uVar5 = uVar5 + 1;
          } while (uVar5 < *(uint16 *)(lVar1 + 0x12a));
        }
        puVar3 = (uint64 *)FUN_1800914f0(plVar2,DAT_181d55650,2);
        LAB_180afb658:
                          // WARNING: Could not recover jumptable at 0x000180afb669. Too many branches
                          // WARNING: Treating indirect jump as call
        uVar4 = (*(code *)*puVar3)(plVar2,puVar3[1]);
        return uVar4;
    }

    // Token : 0x6000635
    // RVA   : 0xAFBA20   Offset: 0xAFA220   Length: 0xDD
    public virtual void set_spriteList(List<UISpriteData> value)
    {
        long lVar1;
        ushort uVar4;
        plVar2 = (int64 *)NGUIAtlas.get_replacement(this,0);
        if (plVar2 == (int64 *)0) {
          this.mSprites = value;
          return;
        }
        lVar1 = *plVar2;
        uVar4 = 0;
        if (*(uint16 *)(lVar1 + 0x12a) != 0) {
          do {
            if (*(int64 *)(*(int64 *)(lVar1 + 176) + (uint64)uVar4 * 16) == DAT_181d55650) {
              puVar3 = (uint64 *)
                       ((int64)*(int *)(*(int64 *)(lVar1 + 176) + 8 + (uint64)uVar4 * 16) *
                        16 + 0x168 + lVar1);
              goto LAB_180afbaca;
            }
            uVar4 = uVar4 + 1;
          } while (uVar4 < *(uint16 *)(lVar1 + 0x12a));
        }
        puVar3 = (uint64 *)FUN_1800914f0(plVar2,DAT_181d55650,3);
        LAB_180afbaca:
                          // WARNING: Could not recover jumptable at 0x000180afbae3. Too many branches
                          // WARNING: Treating indirect jump as call
        (*(code *)*puVar3)(plVar2,value,puVar3[1]);
    }

    // Token : 0x6000636
    // RVA   : 0xAFB6F0   Offset: 0xAF9EF0   Length: 0xB8
    public virtual Texture get_texture()
    {
        bool cVar1;
        long lVar2;
        ulong uVar3;
        lVar2 = NGUIAtlas.get_replacement(this,0);
        if (lVar2 != null) {
          uVar3 = FUN_180002970(4,DAT_181d55650,lVar2);
          return uVar3;
        }
        uVar3 = this.material;
        cVar1 = Object.op_Inequality(uVar3,0,0);
        if (cVar1) {
          if (this.material != null) {
            uVar3 = Material.get_mainTexture(this.material,0);
            return uVar3;
          }
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
        return 0;
    }

    // Token : 0x6000637
    // RVA   : 0xAFB2C0   Offset: 0xAF9AC0   Length: 0xC3
    public virtual float get_pixelSize()
    {
        long lVar1;
        ushort uVar4;
        ulong uVar5;
        plVar2 = (int64 *)NGUIAtlas.get_replacement(this,0);
        if (plVar2 == (int64 *)0) {
          return (uint64)this.mPixelSize;
        }
        lVar1 = *plVar2;
        uVar4 = 0;
        if (*(uint16 *)(lVar1 + 0x12a) != 0) {
          do {
            if (*(int64 *)(*(int64 *)(lVar1 + 176) + (uint64)uVar4 * 16) == DAT_181d55650) {
              puVar3 = (uint64 *)
                       ((int64)*(int *)(*(int64 *)(lVar1 + 176) + 8 + (uint64)uVar4 * 16) *
                        16 + 0x188 + lVar1);
              goto LAB_180afb348;
            }
            uVar4 = uVar4 + 1;
          } while (uVar4 < *(uint16 *)(lVar1 + 0x12a));
        }
        puVar3 = (uint64 *)FUN_1800914f0(plVar2,DAT_181d55650,5);
        LAB_180afb348:
                          // WARNING: Could not recover jumptable at 0x000180afb359. Too many branches
                          // WARNING: Treating indirect jump as call
        uVar5 = (*(code *)*puVar3)(plVar2,puVar3[1]);
        return uVar5;
    }

    // Token : 0x6000638
    // RVA   : 0xAFB7B0   Offset: 0xAF9FB0   Length: 0x10B
    public virtual void set_pixelSize(float value)
    {
        long lVar1;
        ushort uVar4;
        float fVar5;
        plVar2 = (int64 *)NGUIAtlas.get_replacement(this,0);
        if (plVar2 == (int64 *)0) {
          fVar5 = (float)FUN_1810a8ba0(value,0x3e800000,0x40800000,0);
          if (this.mPixelSize != fVar5) {
            this.mPixelSize = fVar5;
            NGUIAtlas.MarkAsChanged(this,0);
            return;
          }
        }
        else {
          lVar1 = *plVar2;
          uVar4 = 0;
          if (*(uint16 *)(lVar1 + 0x12a) != 0) {
            do {
              if (*(int64 *)(*(int64 *)(lVar1 + 176) + (uint64)uVar4 * 16) == DAT_181d55650) {
                puVar3 = (uint64 *)
                         ((int64)*(int *)(*(int64 *)(lVar1 + 176) + 8 + (uint64)uVar4 * 16) *
                          16 + 0x198 + lVar1);
                goto LAB_180afb888;
              }
              uVar4 = uVar4 + 1;
            } while (uVar4 < *(uint16 *)(lVar1 + 0x12a));
          }
          puVar3 = (uint64 *)FUN_1800914f0(plVar2,DAT_181d55650,6);
        LAB_180afb888:
          (*(code *)*puVar3)(plVar2,value,puVar3[1]);
        }
    }

    // Token : 0x6000639
    // RVA   : 0xAFB530   Offset: 0xAF9D30   Length: 0x8F
    public virtual INGUIAtlas get_replacement()
    {
        bool cVar1;
        ulong uVar2;
        uVar2 = this.mReplacement;
        cVar1 = Object.op_Equality(uVar2,0,0);
        if (!cVar1) {
          uVar2 = il2cpp_internal(this.mReplacement,DAT_181d55650);
          return uVar2;
        }
        return 0;
    }

    // Token : 0x600063A
    // RVA   : 0xAFB8C0   Offset: 0xAFA0C0   Length: 0x157
    public virtual void set_replacement(INGUIAtlas value)
    {
        long lVar1;
        bool cVar3;
        plVar5 = (int64 *)0;
        if (value != this) {
          plVar5 = value;
        }
        plVar6 = this + 6;
        plVar4 = (int64 *)il2cpp_internal(this[6],DAT_181d55650);
        if (plVar4 != plVar5) {
          if (plVar5 != (int64 *)0) {
            plVar4 = (int64 *)FUN_180002970(8,DAT_181d55650,plVar5);
            if (plVar4 == this) {
              FUN_180004720(9,DAT_181d55650,plVar5,0);
            }
          }
          lVar1 = *plVar6;
          cVar3 = Object.op_Inequality(lVar1,0,0);
          if (cVar3) {
            NGUIAtlas.MarkAsChanged(this,0);
          }
          if (plVar5 != (int64 *)0) {
            plVar4 = plVar5;
            *plVar6 = (int64)plVar4;
            il2cpp_internal(plVar6);
            plVar6 = this + 3;
          }
          *plVar6 = 0;
          il2cpp_internal(plVar6,0);
          NGUIAtlas.MarkAsChanged(this,0);
        }
    }

    // Token : 0x600063B
    // RVA   : 0xAFA830   Offset: 0xAF9030   Length: 0x264
    public virtual UISpriteData GetSprite(string name)
    {
        long lVar1;
        bool cVar2;
        int iVar3;
        long lVar4;
        ulong uVar5;
        ulong uVar6;
        long lVar7;
        uint[] local_res20 = new uint[2];
        uVar5 = 0;
        local_res20[0] = 0;
        lVar4 = NGUIAtlas.get_replacement(this,0);
        if (lVar4 != null) {
          lVar4 = FUN_180002aa0(10,DAT_181d55650,lVar4,name);
          return lVar4;
        }
        cVar2 = FUN_180d6ca90(name,0);
        if (cVar2) {
          return 0;
        }
        if (this.mSprites != null) {
          if (this.mSprites.Count == null) {
            return 0;
          }
          if (this.mSpriteIndices != null) {
            iVar3 = Dictionary_2.get_Count(this.mSpriteIndices,DAT_181d4dde8);
            if (this.mSprites != null) {
              if (iVar3 != this.mSprites.Count) {
                NGUIAtlas.MarkSpriteListAsChanged(this,0);
              }
              if (this.mSpriteIndices != null) {
                cVar2 = FUN_181783810(this.mSpriteIndices,name,local_res20,DAT_181d4dd68);
                if (!cVar2) {
                  if (this.mSprites != null) {
                    lVar4 = (int64)this.mSprites.Count;
                    if (lVar4 < 1) {
                      return 0;
                    }
                    lVar7 = 32;
                    uVar6 = uVar5;
                    while (lVar1 = this.mSprites) != null {
                      if (*(uint32 *)(lVar1 + 24) <= (uint32)uVar6) {
                        ThrowHelper.ThrowArgumentOutOfRangeException(0);
                      }
                      lVar1 = *(int64 *)(lVar7 + *(int64 *)(lVar1 + 16));
                      if (lVar1 == null) break;
                      cVar2 = FUN_180d6ca90(*(uint64 *)(lVar1 + 16),0);
                      if ((!cVar2) &&
                         (cVar2 = FUN_1816fd990(name,*(uint64 *)(lVar1 + 16),0), cVar2))
                      {
                        NGUIAtlas.MarkSpriteListAsChanged(this,0);
                        return lVar1;
                      }
                      uVar6 = (uint64)((uint32)uVar6 + 1);
                      uVar5 = uVar5 + 1;
                      lVar7 = lVar7 + 8;
                      if (lVar4 <= (int64)uVar5) {
                        return 0;
                      }
                    }
                  }
                }
                else {
                  lVar4 = (int64)(int)local_res20[0];
                  if (-1 < (int)local_res20[0]) {
                    lVar7 = this.mSprites;
                    if (lVar7 == null) throw; // [null/range check failed]
                    if ((int)local_res20[0] < (int)lVar7.Count) {
                      if (lVar7.Count <= local_res20[0]) {
                        ThrowHelper.ThrowArgumentOutOfRangeException(0);
                      }
                      return *(int64 *)(lVar7._items + 32 + lVar4 * 8);
                    }
                  }
                  NGUIAtlas.MarkSpriteListAsChanged(this,0);
                  if (this.mSpriteIndices != null) {
                    cVar2 = FUN_181783810(this.mSpriteIndices,name,local_res20,DAT_181d4dd68)
                    ;
                    if (!cVar2) {
                      return 0;
                    }
                    lVar4 = this.mSprites;
                    lVar7 = (int64)(int)local_res20[0];
                    if (lVar4 != null) {
                      if (lVar4.Count <= local_res20[0]) {
                        ThrowHelper.ThrowArgumentOutOfRangeException(0);
                      }
                      return *(int64 *)(lVar4._items + 32 + lVar7 * 8);
                    }
                  }
                }
              }
            }
          }
        }
    }

    // Token : 0x600063C
    // RVA   : 0xAFAF20   Offset: 0xAF9720   Length: 0x118
    public void MarkSpriteListAsChanged()
    {
        long lVar1;
        long lVar2;
        uint uVar3;
        long lVar4;
        long lVar5;
        long lVar6;
        if (this.mSpriteIndices != null) {
          Dictionary_2.Clear(this.mSpriteIndices,DAT_181d4db68);
          uVar3 = 0;
          if (this.mSprites != null) {
            lVar4 = (int64)this.mSprites.Count;
            if (0 < lVar4) {
              lVar6 = 0;
              lVar5 = 32;
              do {
                lVar1 = this.mSprites;
                lVar2 = this.mSpriteIndices;
                if (lVar1 == null) throw; // [null/range check failed]
                if (lVar1.Count <= uVar3) {
                  ThrowHelper.ThrowArgumentOutOfRangeException(0);
                }
                lVar1 = *(int64 *)(lVar5 + lVar1._items);
                if ((lVar1 == null) || (lVar2 == null)) throw; // [null/range check failed]
                FUN_1808aec90(lVar2,lVar1._items,uVar3,DAT_181d4dee8);
                uVar3 = uVar3 + 1;
                lVar6 = lVar6 + 1;
                lVar5 = lVar5 + 8;
              } while (lVar6 < lVar4);
            }
            return;
          }
        }
    }

    // Token : 0x600063D
    // RVA   : 0xAFB0C0   Offset: 0xAF98C0   Length: 0x12E
    public virtual void SortAlphabetically()
    {
        var pStatics = *(int64*)(DAT_181d59230 + 184);
        long lVar1;
        ulong uVar2;
        long lVar3;
        lVar1 = this.mSprites;
        lVar3 = *(int64 *)(pStatics + 8);
        if (lVar3 == null) {
          uVar2 = **(uint64 **)(DAT_181d59230 + 184);
          lVar3 = new OnTooltipCB(uVar2,DAT_181d7f7e8,DAT_181d86598);
          plVar4 = (int64 *)(pStatics + 8);
          *plVar4 = lVar3;
          il2cpp_internal(plVar4,lVar3);
        }
        if (lVar1 != null) {
          List_1.Sort(lVar1,lVar3,DAT_181d82ef8);
          return;
        }
    }

    // Token : 0x600063E
    // RVA   : 0xAFA1C0   Offset: 0xAF89C0   Length: 0x1D9
    public virtual BetterList<string> GetListOfSprites()
    {
        int iVar1;
        long lVar2;
        bool cVar3;
        long lVar5;
        ulong uVar7;
        uint uVar8;
        uint uVar9;
        ulong uVar10;
        ulong uVar11;
        long lVar12;
        ulong uVar13;
        ulong uVar14;
        long lVar15;
        ushort uVar16;
        ulong uVar17;
        long local_48;
        plVar4 = (int64 *)NGUIAtlas.get_replacement(this,0);
        if (plVar4 != (int64 *)0) {
          lVar5 = *plVar4;
          uVar16 = 0;
          if (*(uint16 *)(lVar5 + 0x12a) != 0) {
            do {
              if (*(int64 *)(*(int64 *)(lVar5 + 176) + (uint64)uVar16 * 16) == DAT_181d55650)
              {
                puVar6 = (uint64 *)
                         ((int64)*(int *)(*(int64 *)(lVar5 + 176) + 8 + (uint64)uVar16 * 16) *
                          16 + 0x1f8 + lVar5);
                goto LAB_180afa79a;
              }
              uVar16 = uVar16 + 1;
            } while (uVar16 < *(uint16 *)(lVar5 + 0x12a));
          }
          puVar6 = (uint64 *)FUN_1800914f0(plVar4,DAT_181d55650,12);
        LAB_180afa79a:
                          // WARNING: Could not recover jumptable at 0x000180afa7b2. Too many branches
                          // WARNING: Treating indirect jump as call
          lVar5 = (*(code *)*puVar6)(plVar4,param_2,puVar6[1]);
          return lVar5;
        }
        cVar3 = FUN_180d6ca90(param_2,0);
        if (cVar3) {
          lVar5 = NGUIAtlas.GetListOfSprites(this,0);
          return lVar5;
        }
        lVar5 = new BetterList_1(DAT_181d81118);
        uVar17 = 0;
        if (this.mSprites != null) {
          lVar12 = (int64)this.mSprites.Count;
          lVar15 = 32;
          local_48 = 32;
          uVar10 = uVar17;
          uVar13 = uVar17;
          if (0 < lVar12) {
            do {
              lVar2 = this.mSprites;
              if (lVar2 == null) throw; // [null/range check failed]
              if (lVar2.Count <= (uint32)uVar10) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              lVar2 = *(int64 *)(lVar15 + lVar2._items);
              if (((lVar2 != null) && (cVar3 = FUN_180d6ca90(lVar2._items,0), !cVar3)
                  ) && (cVar3 = String.Equals(param_2,lVar2._items,5), cVar3)) {
                if (lVar5 != null) {
                  FUN_18154cb60(lVar5,lVar2._items,DAT_181d81198);
                  return lVar5;
                }
                throw; // [null/range check failed]
              }
              uVar13 = uVar13 + 1;
              lVar15 = lVar15 + 8;
              uVar10 = (uint64)((uint32)uVar10 + 1);
            } while ((int64)uVar13 < lVar12);
          }
          lVar12 = FUN_1800d60b0(DAT_181d7c118,1);
          if (lVar12 != null) {
            if (lVar12.Count == null) {
              uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar7,0);
            }
            *(uint16 *)(lVar12 + 32) = 32;
            if ((param_2 != 0) &&
               (plVar4 = (int64 *)String.Split(param_2,lVar12,1), uVar10 = uVar17,
               plVar4 != (int64 *)0)) {
              while( true ) {
                uVar8 = (uint32)uVar10;
                if ((int)*(uint32 *)(plVar4 + 3) <= (int)uVar8) break;
                if (*(uint32 *)(plVar4 + 3) <= uVar8) {
                  uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1800d65f0(uVar7,0);
                }
                if (plVar4[(int64)(int)uVar8 + 4] == 0) throw; // [null/range check failed]
                lVar12 = String.ToLower(plVar4[(int64)(int)uVar8 + 4],0);
                if ((lVar12 != null) &&
                   (lVar15 = il2cpp_internal(lVar12,*(uint64 *)(*plVar4 + 64))) == null) {
                  uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1800d65f0(uVar7,0);
                }
                if (*(uint32 *)(plVar4 + 3) <= uVar8) {
                  uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1800d65f0(uVar7,0);
                }
                plVar4[(int64)(int)uVar8 + 4] = lVar12;
                il2cpp_internal(plVar4 + (int64)(int)uVar8 + 4);
                uVar10 = (uint64)(uVar8 + 1);
              }
              if (this.mSprites != null) {
                iVar1 = this.mSprites.Count;
                uVar10 = uVar17;
                uVar13 = uVar17;
                if (0 < iVar1) {
                  do {
                    lVar12 = this.mSprites;
                    if (lVar12 == null) throw; // [null/range check failed]
                    if (lVar12.Count <= (uint32)uVar10) {
                      ThrowHelper.ThrowArgumentOutOfRangeException(0);
                    }
                    lVar12 = *(int64 *)(local_48 + lVar12._items);
                    if ((lVar12 != null) &&
                       (cVar3 = FUN_180d6ca90(lVar12._items,0), !cVar3)) {
                      if (lVar12._items == null) throw; // [null/range check failed]
                      lVar15 = String.ToLower();
                      uVar11 = uVar17;
                      uVar14 = uVar17;
                      while( true ) {
                        uVar8 = *(uint32 *)(plVar4 + 3);
                        uVar9 = (uint32)uVar11;
                        if ((int)uVar8 <= (int)uVar9) break;
                        if (uVar8 <= uVar9) {
                          uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                          FUN_1800d65f0(uVar7,0);
                        }
                        if (lVar15 == null) throw; // [null/range check failed]
                        cVar3 = String.Contains(lVar15,plVar4[(int64)(int)uVar9 + 4],0);
                        if (cVar3) {
                          uVar14 = (uint64)((uint32)uVar14 + 1);
                        }
                        uVar11 = (uint64)(uVar9 + 1);
                      }
                      if ((uint32)uVar14 == uVar8) {
                        if (lVar5 == null) throw; // [null/range check failed]
                        FUN_18154cb60(lVar5,lVar12._items,DAT_181d81198);
                      }
                    }
                    local_48 = local_48 + 8;
                    uVar13 = uVar13 + 1;
                    uVar10 = (uint64)((uint32)uVar10 + 1);
                  } while ((int64)uVar13 < (int64)iVar1);
                }
                return lVar5;
              }
            }
          }
        }
    }

    // Token : 0x600063F
    // RVA   : 0xAFA3A0   Offset: 0xAF8BA0   Length: 0x481
    public virtual BetterList<string> GetListOfSprites(string match)
    {
        int iVar1;
        long lVar2;
        bool cVar3;
        long lVar5;
        ulong uVar7;
        uint uVar8;
        uint uVar9;
        ulong uVar10;
        ulong uVar11;
        long lVar12;
        ulong uVar13;
        ulong uVar14;
        long lVar15;
        ushort uVar16;
        ulong uVar17;
        long local_48;
        plVar4 = (int64 *)NGUIAtlas.get_replacement(this,0);
        if (plVar4 != (int64 *)0) {
          lVar5 = *plVar4;
          uVar16 = 0;
          if (*(uint16 *)(lVar5 + 0x12a) != 0) {
            do {
              if (*(int64 *)(*(int64 *)(lVar5 + 176) + (uint64)uVar16 * 16) == DAT_181d55650)
              {
                puVar6 = (uint64 *)
                         ((int64)*(int *)(*(int64 *)(lVar5 + 176) + 8 + (uint64)uVar16 * 16) *
                          16 + 0x1f8 + lVar5);
                goto LAB_180afa79a;
              }
              uVar16 = uVar16 + 1;
            } while (uVar16 < *(uint16 *)(lVar5 + 0x12a));
          }
          puVar6 = (uint64 *)FUN_1800914f0(plVar4,DAT_181d55650,12);
        LAB_180afa79a:
                          // WARNING: Could not recover jumptable at 0x000180afa7b2. Too many branches
                          // WARNING: Treating indirect jump as call
          lVar5 = (*(code *)*puVar6)(plVar4,match,puVar6[1]);
          return lVar5;
        }
        cVar3 = FUN_180d6ca90(match,0);
        if (cVar3) {
          lVar5 = NGUIAtlas.GetListOfSprites(this,0);
          return lVar5;
        }
        lVar5 = new BetterList_1(DAT_181d81118);
        uVar17 = 0;
        if (this.mSprites != null) {
          lVar12 = (int64)this.mSprites.Count;
          lVar15 = 32;
          local_48 = 32;
          uVar10 = uVar17;
          uVar13 = uVar17;
          if (0 < lVar12) {
            do {
              lVar2 = this.mSprites;
              if (lVar2 == null) throw; // [null/range check failed]
              if (lVar2.Count <= (uint32)uVar10) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              lVar2 = *(int64 *)(lVar15 + lVar2._items);
              if (((lVar2 != null) && (cVar3 = FUN_180d6ca90(lVar2._items,0), !cVar3)
                  ) && (cVar3 = String.Equals(match,lVar2._items,5), cVar3)) {
                if (lVar5 != null) {
                  FUN_18154cb60(lVar5,lVar2._items,DAT_181d81198);
                  return lVar5;
                }
                throw; // [null/range check failed]
              }
              uVar13 = uVar13 + 1;
              lVar15 = lVar15 + 8;
              uVar10 = (uint64)((uint32)uVar10 + 1);
            } while ((int64)uVar13 < lVar12);
          }
          lVar12 = FUN_1800d60b0(DAT_181d7c118,1);
          if (lVar12 != null) {
            if (lVar12.Count == null) {
              uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar7,0);
            }
            *(uint16 *)(lVar12 + 32) = 32;
            if ((match != null) &&
               (plVar4 = (int64 *)String.Split(match,lVar12,1), uVar10 = uVar17,
               plVar4 != (int64 *)0)) {
              while( true ) {
                uVar8 = (uint32)uVar10;
                if ((int)*(uint32 *)(plVar4 + 3) <= (int)uVar8) break;
                if (*(uint32 *)(plVar4 + 3) <= uVar8) {
                  uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1800d65f0(uVar7,0);
                }
                if (plVar4[(int64)(int)uVar8 + 4] == 0) throw; // [null/range check failed]
                lVar12 = String.ToLower(plVar4[(int64)(int)uVar8 + 4],0);
                if ((lVar12 != null) &&
                   (lVar15 = il2cpp_internal(lVar12,*(uint64 *)(*plVar4 + 64))) == null) {
                  uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1800d65f0(uVar7,0);
                }
                if (*(uint32 *)(plVar4 + 3) <= uVar8) {
                  uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1800d65f0(uVar7,0);
                }
                plVar4[(int64)(int)uVar8 + 4] = lVar12;
                il2cpp_internal(plVar4 + (int64)(int)uVar8 + 4);
                uVar10 = (uint64)(uVar8 + 1);
              }
              if (this.mSprites != null) {
                iVar1 = this.mSprites.Count;
                uVar10 = uVar17;
                uVar13 = uVar17;
                if (0 < iVar1) {
                  do {
                    lVar12 = this.mSprites;
                    if (lVar12 == null) throw; // [null/range check failed]
                    if (lVar12.Count <= (uint32)uVar10) {
                      ThrowHelper.ThrowArgumentOutOfRangeException(0);
                    }
                    lVar12 = *(int64 *)(local_48 + lVar12._items);
                    if ((lVar12 != null) &&
                       (cVar3 = FUN_180d6ca90(lVar12._items,0), !cVar3)) {
                      if (lVar12._items == null) throw; // [null/range check failed]
                      lVar15 = String.ToLower();
                      uVar11 = uVar17;
                      uVar14 = uVar17;
                      while( true ) {
                        uVar8 = *(uint32 *)(plVar4 + 3);
                        uVar9 = (uint32)uVar11;
                        if ((int)uVar8 <= (int)uVar9) break;
                        if (uVar8 <= uVar9) {
                          uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                          FUN_1800d65f0(uVar7,0);
                        }
                        if (lVar15 == null) throw; // [null/range check failed]
                        cVar3 = String.Contains(lVar15,plVar4[(int64)(int)uVar9 + 4],0);
                        if (cVar3) {
                          uVar14 = (uint64)((uint32)uVar14 + 1);
                        }
                        uVar11 = (uint64)(uVar9 + 1);
                      }
                      if ((uint32)uVar14 == uVar8) {
                        if (lVar5 == null) throw; // [null/range check failed]
                        FUN_18154cb60(lVar5,lVar12._items,DAT_181d81198);
                      }
                    }
                    local_48 = local_48 + 8;
                    uVar13 = uVar13 + 1;
                    uVar10 = (uint64)((uint32)uVar10 + 1);
                  } while ((int64)uVar13 < (int64)iVar1);
                }
                return lVar5;
              }
            }
          }
        }
    }

    // Token : 0x6000640
    // RVA   : 0xAFB040   Offset: 0xAF9840   Length: 0x80
    public virtual bool References(INGUIAtlas atlas)
    {
        byte uVar1;
        long lVar2;
        if (atlas != null) {
          if (atlas == this) {
            return true;
          }
          lVar2 = NGUIAtlas.get_replacement(this,0);
          if (lVar2 != null) {
            uVar1 = FUN_180002aa0(13,DAT_181d55650,lVar2,atlas);
            return uVar1;
          }
        }
        return false;
    }

    // Token : 0x6000641
    // RVA   : 0xAFAAA0   Offset: 0xAF92A0   Length: 0x478
    public virtual void MarkAsChanged()
    {
        int iVar1;
        long lVar2;
        bool cVar3;
        long lVar4;
        ulong uVar5;
        long lVar6;
        uint uVar7;
        uint uVar8;
        lVar4 = NGUIAtlas.get_replacement(this,0);
        if (lVar4 != null) {
          FUN_180002970(14,DAT_181d55650,lVar4);
        }
        lVar4 = NGUITools.FindActive(DAT_181d66500);
        uVar7 = 0;
        uVar8 = 0;
        if (lVar4 != null) {
          iVar1 = *(int *)(lVar4 + 24);
          if (0 < iVar1) {
            do {
              if (*(uint32 *)(lVar4 + 24) <= uVar8) {
                uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar5,0);
              }
              lVar2 = lVar4[uVar8];
              if (lVar2 == null) throw; // [null/range check failed]
              uVar5 = UISprite.get_atlas(lVar2,0);
              cVar3 = NGUITools.CheckIfRelated(this,uVar5,0);
              if (cVar3) {
                UISprite.get_atlas(lVar2,0);
                UISprite.set_atlas(lVar2,0);
                UISprite.set_atlas(lVar2);
              }
              uVar8 = uVar8 + 1;
            } while ((int)uVar8 < iVar1);
          }
          lVar4 = Resources.FindObjectsOfTypeAll(DAT_181d76f60);
          uVar8 = 0;
          if (lVar4 != null) {
            iVar1 = *(int *)(lVar4 + 24);
            if (0 < iVar1) {
              do {
                if (*(uint32 *)(lVar4 + 24) <= uVar8) {
                  uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1800d65f0(uVar5,0);
                }
                lVar2 = lVar4[uVar8];
                if (lVar2 == null) throw; // [null/range check failed]
                lVar6 = NGUIFont.get_replacement(lVar2,0);
                if (lVar6 == null) {
                  lVar6 = il2cpp_internal(*(uint64 *)(lVar2 + 56));
                }
                else {
                  lVar6 = FUN_180002970(9,DAT_181d556d0,lVar6);
                }
                if (lVar6 != null) {
                  uVar5 = NGUIFont.get_atlas(lVar2,0);
                  cVar3 = NGUITools.CheckIfRelated(this,uVar5,0);
                  if (cVar3) {
                    NGUIFont.get_atlas(lVar2,0);
                    NGUIFont.set_atlas(lVar2,0);
                    NGUIFont.set_atlas(lVar2);
                  }
                }
                uVar8 = uVar8 + 1;
              } while ((int)uVar8 < iVar1);
            }
            lVar4 = Resources.FindObjectsOfTypeAll(DAT_181d76fe0);
            uVar8 = 0;
            if (lVar4 != null) {
              iVar1 = *(int *)(lVar4 + 24);
              if (0 < iVar1) {
                do {
                  if (*(uint32 *)(lVar4 + 24) <= uVar8) {
                    uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                    FUN_1800d65f0(uVar5,0);
                  }
                  lVar2 = lVar4[uVar8];
                  if (lVar2 == null) throw; // [null/range check failed]
                  uVar5 = UIFont.get_atlas(lVar2,0);
                  cVar3 = NGUITools.CheckIfRelated(this,uVar5,0);
                  if (cVar3) {
                    UIFont.get_atlas(lVar2,0);
                    UIFont.set_atlas(lVar2,0);
                    UIFont.set_atlas(lVar2);
                  }
                  uVar8 = uVar8 + 1;
                } while ((int)uVar8 < iVar1);
              }
              lVar4 = NGUITools.FindActive(DAT_181d66400);
              if (lVar4 != null) {
                iVar1 = *(int *)(lVar4 + 24);
                if (0 < iVar1) {
                  do {
                    if (*(uint32 *)(lVar4 + 24) <= uVar7) {
                      uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                      FUN_1800d65f0(uVar5,0);
                    }
                    lVar2 = lVar4[uVar7];
                    if (lVar2 == null) throw; // [null/range check failed]
                    lVar6 = UILabel.get_atlas(lVar2);
                    if (lVar6 != null) {
                      uVar5 = UILabel.get_atlas(lVar2,0);
                      cVar3 = NGUITools.CheckIfRelated(this,uVar5,0);
                      if (cVar3) {
                        UILabel.get_atlas(lVar2,0);
                        UILabel.get_bitmapFont(lVar2,0);
                        UILabel.set_bitmapFont(lVar2,0);
                        UILabel.set_bitmapFont(lVar2);
                      }
                    }
                    uVar7 = uVar7 + 1;
                  } while ((int)uVar7 < iVar1);
                }
                return;
              }
            }
          }
        }
    }

    // Token : 0x6000642
    // RVA   : 0xAFB1F0   Offset: 0xAF99F0   Length: 0xC9
    public void /*ctor*/()
    {
        ulong uVar1;
        uVar1 = il2cpp_internal(DAT_181d73bb0);
        FUN_180f58a90(uVar1,DAT_181d82df8);
        this.mSprites = uVar1;
        this.mPixelSize = 0x3f800000;
        this.mPMA = 0xffffffff;
        uVar1 = il2cpp_internal(DAT_181d5e248);
        FUN_1808ae540(uVar1,DAT_181d4d968);
        this.mSpriteIndices = uVar1;
        ScriptableObject.ctor(this,0);
    }

}
