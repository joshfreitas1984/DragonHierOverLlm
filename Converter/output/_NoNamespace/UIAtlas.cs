// ============================================================
// Type  : UIAtlas
// Token : 0x20000D4
// ============================================================

public class UIAtlas
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x400051C
    private Material material;

    // Token: 0x400051D
    private List<UISpriteData> mSprites;

    // Token: 0x400051E
    private float mPixelSize;

    // Token: 0x400051F
    private object mReplacement;

    // Token: 0x4000520
    private Coordinates mCoordinates;

    // Token: 0x4000521
    private List<Sprite> sprites;

    // Token: 0x4000522
    private int mPMA;

    // Token: 0x4000523
    private Dictionary<string, int> mSpriteIndices;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60006D8
    // RVA   : 0x1528A00   Offset: 0x1527E00   Length: 0xDF
    public virtual Material get_spriteMaterial()
    {
        long lVar1;
        ulong uVar4;
        ushort uVar5;
        plVar2 = (int64 *)il2cpp_internal(this.mReplacement,DAT_181d7a7a0);
        if (plVar2 == (int64 *)0) {
          return this.material;
        }
        lVar1 = *plVar2;
        uVar5 = 0;
        if (*(uint16 *)(lVar1 + 0x12a) != 0) {
          do {
            if (*(int64 *)(*(int64 *)(lVar1 + 176) + (uint64)uVar5 * 16) == DAT_181d7a7a0) {
              puVar3 = (uint64 *)
                       ((int64)*(int *)(*(int64 *)(lVar1 + 176) + 8 + (uint64)uVar5 * 16) *
                        16 + 0x138 + lVar1);
              goto LAB_181528aa5;
            }
            uVar5 = uVar5 + 1;
          } while (uVar5 < *(uint16 *)(lVar1 + 0x12a));
        }
        puVar3 = (uint64 *)FUN_1800914f0(plVar2,DAT_181d7a7a0,0);
        LAB_181528aa5:
                          // WARNING: Could not recover jumptable at 0x000181528ab6. Too many branches
                          // WARNING: Treating indirect jump as call
        uVar4 = (*(code *)*puVar3)(plVar2,puVar3[1]);
        return uVar4;
    }

    // Token : 0x60006D9
    // RVA   : 0x15290A0   Offset: 0x15284A0   Length: 0x18B
    public virtual void set_spriteMaterial(Material value)
    {
        ulong uVar1;
        long lVar2;
        bool cVar3;
        ushort uVar6;
        plVar4 = (int64 *)il2cpp_internal(this.mReplacement,DAT_181d7a7a0);
        if (plVar4 == (int64 *)0) {
          uVar1 = this.material;
          cVar3 = Object.op_Equality(uVar1,0,0);
          if (!cVar3) {
            UIAtlas.MarkAsChanged(this,0);
            this.mPMA = 0xffffffff;
            this.material = value;
            UIAtlas.MarkAsChanged(this,0);
            return;
          }
          this.material = value;
          this.mPMA = 0;
          return;
        }
        lVar2 = *plVar4;
        uVar6 = 0;
        if (*(uint16 *)(lVar2 + 0x12a) != 0) {
          do {
            if (*(int64 *)(*(int64 *)(lVar2 + 176) + (uint64)uVar6 * 16) == DAT_181d7a7a0) {
              puVar5 = (uint64 *)
                       ((int64)*(int *)(*(int64 *)(lVar2 + 176) + 8 + (uint64)uVar6 * 16) *
                        16 + 0x148 + lVar2);
              goto LAB_1815291f8;
            }
            uVar6 = uVar6 + 1;
          } while (uVar6 < *(uint16 *)(lVar2 + 0x12a));
        }
        puVar5 = (uint64 *)FUN_1800914f0(plVar4,DAT_181d7a7a0,1);
        LAB_1815291f8:
                          // WARNING: Could not recover jumptable at 0x000181529211. Too many branches
                          // WARNING: Treating indirect jump as call
        (*(code *)*puVar5)(plVar4,value,puVar5[1]);
    }

    // Token : 0x60006DA
    // RVA   : 0x15285E0   Offset: 0x15279E0   Length: 0x2BC
    public virtual bool get_premultipliedAlpha()
    {
        bool cVar1;
        byte uVar2;
        long lVar5;
        ulong uVar6;
        ushort uVar7;
        int iVar9;
        ulong uVar8;
        plVar3 = (int64 *)il2cpp_internal(this.mReplacement,DAT_181d7a7a0);
        if (plVar3 != (int64 *)0) {
          lVar5 = *plVar3;
          uVar7 = 0;
          if (*(uint16 *)(lVar5 + 0x12a) != 0) {
            do {
              if (*(int64 *)(*(int64 *)(lVar5 + 176) + (uint64)uVar7 * 16) == DAT_181d7a7a0) {
                puVar4 = (uint64 *)
                         ((int64)*(int *)(*(int64 *)(lVar5 + 176) + 8 + (uint64)uVar7 * 16) *
                          16 + 0x1a8 + lVar5);
                goto LAB_181528867;
              }
              uVar7 = uVar7 + 1;
            } while (uVar7 < *(uint16 *)(lVar5 + 0x12a));
          }
          puVar4 = (uint64 *)FUN_1800914f0(plVar3,DAT_181d7a7a0,7);
        LAB_181528867:
                          // WARNING: Could not recover jumptable at 0x00018152887d. Too many branches
                          // WARNING: Treating indirect jump as call
          uVar2 = (*(code *)*puVar4)(plVar3,puVar4[1]);
          return (bool)uVar2;
        }
        iVar9 = this.mPMA;
        if (iVar9 == -1) {
          plVar3 = (int64 *)il2cpp_internal(this.mReplacement,DAT_181d7a7a0);
          iVar9 = 0;
          if (plVar3 == (int64 *)0) {
            lVar5 = this.material;
          }
          else {
            lVar5 = *plVar3;
            uVar8 = 0;
            if (*(uint16 *)(lVar5 + 0x12a) != 0) {
              do {
                if (*(int64 *)(*(int64 *)(lVar5 + 176) + uVar8 * 16) == DAT_181d7a7a0) {
                  puVar4 = (uint64 *)
                           ((int64)*(int *)(*(int64 *)(lVar5 + 176) + 8 + uVar8 * 16) * 16 +
                            0x138 + lVar5);
                  lVar5 = (*(code *)*puVar4)(plVar3,puVar4[1]);
                  goto LAB_18152873b;
                }
                uVar7 = (short)uVar8 + 1;
                uVar8 = (uint64)uVar7;
              } while (uVar7 < *(uint16 *)(lVar5 + 0x12a));
            }
            puVar4 = (uint64 *)FUN_1800914f0(plVar3,DAT_181d7a7a0,0);
            lVar5 = (*(code *)*puVar4)(plVar3,puVar4[1]);
          }
        LAB_18152873b:
          cVar1 = Object.op_Inequality(lVar5,0,0);
          if (cVar1) {
            if (lVar5 == null) goto LAB_181528897;
            uVar6 = Material.get_shader(lVar5,0);
            cVar1 = Object.op_Inequality(uVar6,0,0);
            if (cVar1) {
              lVar5 = Material.get_shader(lVar5,0);
              if (lVar5 == null) {
        LAB_181528897:
                          // WARNING: Subroutine does not return
                FUN_1800d6620();
              }
              lVar5 = Object.get_name(lVar5,0);
              if (lVar5 == null) goto LAB_181528897;
              cVar1 = String.Contains(lVar5,"Premultiplied",0);
              if (cVar1) {
                iVar9 = 1;
              }
            }
          }
          this.mPMA = iVar9;
        }
        return iVar9 == 1;
    }

    // Token : 0x60006DB
    // RVA   : 0x15288E0   Offset: 0x1527CE0   Length: 0x118
    public virtual List<UISpriteData> get_spriteList()
    {
        long lVar3;
        ushort uVar4;
        plVar1 = (int64 *)il2cpp_internal(this.mReplacement,DAT_181d7a7a0);
        if (plVar1 == (int64 *)0) {
          lVar3 = this.mSprites;
          if (lVar3 == null) {
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          if (lVar3.Count == null) {
            UIAtlas.Upgrade(this,0);
            return this.mSprites;
          }
        }
        else {
          lVar3 = *plVar1;
          uVar4 = 0;
          if (*(uint16 *)(lVar3 + 0x12a) != 0) {
            do {
              if (*(int64 *)(*(int64 *)(lVar3 + 176) + (uint64)uVar4 * 16) == DAT_181d7a7a0) {
                puVar2 = (uint64 *)
                         ((int64)*(int *)(*(int64 *)(lVar3 + 176) + 8 + (uint64)uVar4 * 16) *
                          16 + 0x158 + lVar3);
                goto LAB_1815289c8;
              }
              uVar4 = uVar4 + 1;
            } while (uVar4 < *(uint16 *)(lVar3 + 0x12a));
          }
          puVar2 = (uint64 *)FUN_1800914f0(plVar1,DAT_181d7a7a0,2);
        LAB_1815289c8:
          lVar3 = (*(code *)*puVar2)(plVar1,puVar2[1]);
        }
        return lVar3;
    }

    // Token : 0x60006DC
    // RVA   : 0x1528F90   Offset: 0x1528390   Length: 0x10B
    public virtual void set_spriteList(List<UISpriteData> value)
    {
        long lVar1;
        ushort uVar4;
        plVar2 = (int64 *)il2cpp_internal(this.mReplacement,DAT_181d7a7a0);
        if (plVar2 == (int64 *)0) {
          this.mSprites = value;
          return;
        }
        lVar1 = *plVar2;
        uVar4 = 0;
        if (*(uint16 *)(lVar1 + 0x12a) != 0) {
          do {
            if (*(int64 *)(*(int64 *)(lVar1 + 176) + (uint64)uVar4 * 16) == DAT_181d7a7a0) {
              puVar3 = (uint64 *)
                       ((int64)*(int *)(*(int64 *)(lVar1 + 176) + 8 + (uint64)uVar4 * 16) *
                        16 + 0x168 + lVar1);
              goto LAB_181529068;
            }
            uVar4 = uVar4 + 1;
          } while (uVar4 < *(uint16 *)(lVar1 + 0x12a));
        }
        puVar3 = (uint64 *)FUN_1800914f0(plVar2,DAT_181d7a7a0,3);
        LAB_181529068:
                          // WARNING: Could not recover jumptable at 0x000181529081. Too many branches
                          // WARNING: Treating indirect jump as call
        (*(code *)*puVar3)(plVar2,value,puVar3[1]);
    }

    // Token : 0x60006DD
    // RVA   : 0x1528AE0   Offset: 0x1527EE0   Length: 0x142
    public virtual Texture get_texture()
    {
        long lVar1;
        bool cVar2;
        ulong uVar5;
        ushort uVar6;
        plVar3 = (int64 *)il2cpp_internal(this.mReplacement,DAT_181d7a7a0);
        if (plVar3 == (int64 *)0) {
          uVar5 = this.material;
          cVar2 = Object.op_Inequality(uVar5,0,0);
          if (cVar2) {
            if (this.material != null) {
              uVar5 = Material.get_mainTexture(this.material,0);
              return uVar5;
            }
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          return 0;
        }
        lVar1 = *plVar3;
        uVar6 = 0;
        if (*(uint16 *)(lVar1 + 0x12a) != 0) {
          do {
            if (*(int64 *)(*(int64 *)(lVar1 + 176) + (uint64)uVar6 * 16) == DAT_181d7a7a0) {
              puVar4 = (uint64 *)
                       ((int64)*(int *)(*(int64 *)(lVar1 + 176) + 8 + (uint64)uVar6 * 16) *
                        16 + 0x178 + lVar1);
              goto LAB_181528b98;
            }
            uVar6 = uVar6 + 1;
          } while (uVar6 < *(uint16 *)(lVar1 + 0x12a));
        }
        puVar4 = (uint64 *)FUN_1800914f0(plVar3,DAT_181d7a7a0,4);
        LAB_181528b98:
                          // WARNING: Could not recover jumptable at 0x000181528ba9. Too many branches
                          // WARNING: Treating indirect jump as call
        uVar5 = (*(code *)*puVar4)(plVar3,puVar4[1]);
        return uVar5;
    }

    // Token : 0x60006DE
    // RVA   : 0x15284F0   Offset: 0x15278F0   Length: 0xE3
    public virtual float get_pixelSize()
    {
        long lVar1;
        ushort uVar4;
        ulong uVar5;
        plVar2 = (int64 *)il2cpp_internal(this.mReplacement,DAT_181d7a7a0);
        if (plVar2 == (int64 *)0) {
          return (uint64)this.mPixelSize;
        }
        lVar1 = *plVar2;
        uVar4 = 0;
        if (*(uint16 *)(lVar1 + 0x12a) != 0) {
          do {
            if (*(int64 *)(*(int64 *)(lVar1 + 176) + (uint64)uVar4 * 16) == DAT_181d7a7a0) {
              puVar3 = (uint64 *)
                       ((int64)*(int *)(*(int64 *)(lVar1 + 176) + 8 + (uint64)uVar4 * 16) *
                        16 + 0x188 + lVar1);
              goto LAB_181528598;
            }
            uVar4 = uVar4 + 1;
          } while (uVar4 < *(uint16 *)(lVar1 + 0x12a));
        }
        puVar3 = (uint64 *)FUN_1800914f0(plVar2,DAT_181d7a7a0,5);
        LAB_181528598:
                          // WARNING: Could not recover jumptable at 0x0001815285a9. Too many branches
                          // WARNING: Treating indirect jump as call
        uVar5 = (*(code *)*puVar3)(plVar2,puVar3[1]);
        return uVar5;
    }

    // Token : 0x60006DF
    // RVA   : 0x1528C30   Offset: 0x1528030   Length: 0x12B
    public virtual void set_pixelSize(float value)
    {
        long lVar1;
        ushort uVar4;
        float fVar5;
        plVar2 = (int64 *)il2cpp_internal(this.mReplacement,DAT_181d7a7a0);
        if (plVar2 == (int64 *)0) {
          fVar5 = (float)FUN_1810e3cd0(value,0x3e800000,0x40800000,0);
          if (this.mPixelSize != fVar5) {
            this.mPixelSize = fVar5;
            UIAtlas.MarkAsChanged(this,0);
            return;
          }
        }
        else {
          lVar1 = *plVar2;
          uVar4 = 0;
          if (*(uint16 *)(lVar1 + 0x12a) != 0) {
            do {
              if (*(int64 *)(*(int64 *)(lVar1 + 176) + (uint64)uVar4 * 16) == DAT_181d7a7a0) {
                puVar3 = (uint64 *)
                         ((int64)*(int *)(*(int64 *)(lVar1 + 176) + 8 + (uint64)uVar4 * 16) *
                          16 + 0x198 + lVar1);
                goto LAB_181528d28;
              }
              uVar4 = uVar4 + 1;
            } while (uVar4 < *(uint16 *)(lVar1 + 0x12a));
          }
          puVar3 = (uint64 *)FUN_1800914f0(plVar2,DAT_181d7a7a0,6);
        LAB_181528d28:
          (*(code *)*puVar3)(plVar2,value,puVar3[1]);
        }
    }

    // Token : 0x60006E0
    // RVA   : 0x15288A0   Offset: 0x1527CA0   Length: 0x3A
    public virtual INGUIAtlas get_replacement()
    {
        il2cpp_internal(this.mReplacement,DAT_181d7a7a0);
    }

    // Token : 0x60006E1
    // RVA   : 0x1528D60   Offset: 0x1528160   Length: 0x223
    public virtual void set_replacement(INGUIAtlas value)
    {
        long lVar1;
        bool cVar3;
        ushort uVar6;
        ushort uVar7;
        plVar9 = this + 6;
        plVar8 = (int64 *)0;
        if (value != this) {
          plVar8 = value;
        }
        plVar4 = (int64 *)il2cpp_internal(*plVar9,DAT_181d7a7a0);
        if (plVar4 != plVar8) {
          if (plVar8 != (int64 *)0) {
            lVar1 = *plVar8;
            uVar7 = 0;
            if (*(uint16 *)(lVar1 + 0x12a) != 0) {
              uVar6 = uVar7;
              do {
                if (*(int64 *)(*(int64 *)(lVar1 + 176) + (uint64)uVar6 * 16) == DAT_181d7a7a0)
                {
                  puVar5 = (uint64 *)
                           ((int64)*(int *)(*(int64 *)(lVar1 + 176) + 8 + (uint64)uVar6 * 16)
                            * 16 + 0x1b8 + lVar1);
                  goto LAB_181528e2c;
                }
                uVar6 = uVar6 + 1;
              } while (uVar6 < *(uint16 *)(lVar1 + 0x12a));
            }
            puVar5 = (uint64 *)FUN_1800914f0(plVar8,DAT_181d7a7a0,8);
        LAB_181528e2c:
            plVar4 = (int64 *)(*(code *)*puVar5)(plVar8,puVar5[1]);
            if (plVar4 == this) {
              lVar1 = *plVar8;
              if (*(uint16 *)(lVar1 + 0x12a) != 0) {
                do {
                  if (*(int64 *)(*(int64 *)(lVar1 + 176) + (uint64)uVar7 * 16) ==
                      DAT_181d7a7a0) {
                    puVar5 = (uint64 *)
                             ((int64)
                              *(int *)(*(int64 *)(lVar1 + 176) + 8 + (uint64)uVar7 * 16) * 16 +
                              0x1c8 + lVar1);
                    goto LAB_181528e8c;
                  }
                  uVar7 = uVar7 + 1;
                } while (uVar7 < *(uint16 *)(lVar1 + 0x12a));
              }
              puVar5 = (uint64 *)FUN_1800914f0(plVar8,DAT_181d7a7a0,9);
        LAB_181528e8c:
              (*(code *)*puVar5)(plVar8,0,puVar5[1]);
            }
          }
          lVar1 = *plVar9;
          cVar3 = Object.op_Inequality(lVar1,0,0);
          if (cVar3) {
            UIAtlas.MarkAsChanged(this,0);
          }
          if (plVar8 != (int64 *)0) {
            plVar4 = plVar8;
            *plVar9 = (int64)plVar4;
            il2cpp_internal(plVar9);
            plVar9 = this + 3;
          }
          *plVar9 = 0;
          il2cpp_internal(plVar9,0);
          UIAtlas.MarkAsChanged(this,0);
        }
    }

    // Token : 0x60006E2
    // RVA   : 0x1527350   Offset: 0x1526750   Length: 0x2FA
    public virtual UISpriteData GetSprite(string name)
    {
        long lVar1;
        bool cVar2;
        int iVar3;
        ushort uVar6;
        ulong uVar8;
        long lVar9;
        long lVar10;
        uint[] local_res8 = new uint[2];
        ulong uVar7;
        uVar7 = 0;
        local_res8[0] = 0;
        plVar4 = (int64 *)il2cpp_internal(this.mReplacement,DAT_181d7a7a0);
        if (plVar4 != (int64 *)0) {
          lVar10 = *plVar4;
          if (*(uint16 *)(lVar10 + 0x12a) != 0) {
            do {
              if (*(int64 *)(*(int64 *)(lVar10 + 176) + uVar7 * 16) == DAT_181d7a7a0) {
                puVar5 = (uint64 *)
                         ((int64)*(int *)(*(int64 *)(lVar10 + 176) + 8 + uVar7 * 16) * 16 +
                          0x1d8 + lVar10);
                goto LAB_181527618;
              }
              uVar6 = (short)uVar7 + 1;
              uVar7 = (uint64)uVar6;
            } while (uVar6 < *(uint16 *)(lVar10 + 0x12a));
          }
          puVar5 = (uint64 *)FUN_1800914f0(plVar4,DAT_181d7a7a0,10);
        LAB_181527618:
          lVar10 = (*(code *)*puVar5)(plVar4,name,puVar5[1]);
          return lVar10;
        }
        cVar2 = FUN_180d75bc0(name,0);
        if (cVar2) {
          return 0;
        }
        if (this.mSprites != null) {
          if (this.mSprites.Count == null) {
            UIAtlas.Upgrade(this,0);
            if (this.mSprites == null) throw; // [null/range check failed]
            if (this.mSprites.Count == null) {
              return 0;
            }
          }
          if (this.mSpriteIndices != null) {
            iVar3 = Dictionary_2.get_Count(this.mSpriteIndices,DAT_181d73eb0);
            if (this.mSprites != null) {
              if (iVar3 != this.mSprites.Count) {
                UIAtlas.MarkSpriteListAsChanged(this,0);
              }
              if (this.mSpriteIndices != null) {
                cVar2 = FUN_1817c0aa0(this.mSpriteIndices,name,local_res8,DAT_181d73e28);
                if (!cVar2) {
                  if (this.mSprites != null) {
                    lVar10 = (int64)this.mSprites.Count;
                    if (lVar10 < 1) {
                      return 0;
                    }
                    lVar9 = 32;
                    uVar8 = uVar7;
                    while (lVar1 = this.mSprites) != null {
                      if (*(uint32 *)(lVar1 + 24) <= (uint32)uVar7) {
                        ThrowHelper.ThrowArgumentOutOfRangeException(0);
                      }
                      lVar1 = *(int64 *)(lVar9 + *(int64 *)(lVar1 + 16));
                      if (lVar1 == null) break;
                      cVar2 = FUN_180d75bc0(*(uint64 *)(lVar1 + 16),0);
                      if ((!cVar2) &&
                         (cVar2 = FUN_18171eb50(name,*(uint64 *)(lVar1 + 16),0), cVar2))
                      {
                        UIAtlas.MarkSpriteListAsChanged(this,0);
                        return lVar1;
                      }
                      uVar7 = (uint64)((uint32)uVar7 + 1);
                      uVar8 = uVar8 + 1;
                      lVar9 = lVar9 + 8;
                      if (lVar10 <= (int64)uVar8) {
                        return 0;
                      }
                    }
                  }
                }
                else {
                  lVar10 = (int64)(int)local_res8[0];
                  if (-1 < (int)local_res8[0]) {
                    lVar9 = this.mSprites;
                    if (lVar9 == null) throw; // [null/range check failed]
                    if ((int)local_res8[0] < (int)lVar9.Count) {
                      if (lVar9.Count <= local_res8[0]) {
                        ThrowHelper.ThrowArgumentOutOfRangeException(0);
                      }
                      return *(int64 *)(lVar9._items + 32 + lVar10 * 8);
                    }
                  }
                  UIAtlas.MarkSpriteListAsChanged(this,0);
                  if (this.mSpriteIndices != null) {
                    cVar2 = FUN_1817c0aa0(this.mSpriteIndices,name,local_res8,DAT_181d73e28);
                    if (!cVar2) {
                      return 0;
                    }
                    lVar10 = this.mSprites;
                    lVar9 = (int64)(int)local_res8[0];
                    if (lVar10 != null) {
                      if (lVar10.Count <= local_res8[0]) {
                        ThrowHelper.ThrowArgumentOutOfRangeException(0);
                      }
                      return *(int64 *)(lVar10._items + 32 + lVar9 * 8);
                    }
                  }
                }
              }
            }
          }
        }
    }

    // Token : 0x60006E3
    // RVA   : 0x1527B10   Offset: 0x1526F10   Length: 0x118
    public void MarkSpriteListAsChanged()
    {
        long lVar1;
        long lVar2;
        uint uVar3;
        long lVar4;
        long lVar5;
        long lVar6;
        if (this.mSpriteIndices != null) {
          Dictionary_2.Clear(this.mSpriteIndices,DAT_181d73c08);
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
                FUN_1808b2160(lVar2,lVar1._items,uVar3,DAT_181d73fc0);
                uVar3 = uVar3 + 1;
                lVar6 = lVar6 + 1;
                lVar5 = lVar5 + 8;
              } while (lVar6 < lVar4);
            }
            return;
          }
        }
    }

    // Token : 0x60006E4
    // RVA   : 0x1527D40   Offset: 0x1527140   Length: 0x12E
    public virtual void SortAlphabetically()
    {
        var pStatics = *(int64*)(DAT_181d8d150 + 184);
        long lVar1;
        ulong uVar2;
        long lVar3;
        lVar1 = this.mSprites;
        lVar3 = *(int64 *)(pStatics + 8);
        if (lVar3 == null) {
          uVar2 = **(uint64 **)(DAT_181d8d150 + 184);
          lVar3 = new OnTooltipCB(uVar2,DAT_181db76b0,DAT_181dab950);
          plVar4 = (int64 *)(pStatics + 8);
          *plVar4 = lVar3;
          il2cpp_internal(plVar4,lVar3);
        }
        if (lVar1 != null) {
          List_1.Sort(lVar1,lVar3,DAT_181daa8b0);
          return;
        }
    }

    // Token : 0x60006E5
    // RVA   : 0x1526C60   Offset: 0x1526060   Length: 0x219
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
        plVar4 = (int64 *)il2cpp_internal(this.mReplacement,DAT_181d7a7a0);
        if (plVar4 != (int64 *)0) {
          lVar5 = *plVar4;
          uVar16 = 0;
          if (*(uint16 *)(lVar5 + 0x12a) != 0) {
            do {
              if (*(int64 *)(*(int64 *)(lVar5 + 176) + (uint64)uVar16 * 16) == DAT_181d7a7a0)
              {
                puVar6 = (uint64 *)
                         ((int64)*(int *)(*(int64 *)(lVar5 + 176) + 8 + (uint64)uVar16 * 16) *
                          16 + 0x1f8 + lVar5);
                goto LAB_1815272ba;
              }
              uVar16 = uVar16 + 1;
            } while (uVar16 < *(uint16 *)(lVar5 + 0x12a));
          }
          puVar6 = (uint64 *)FUN_1800914f0(plVar4,DAT_181d7a7a0,12);
        LAB_1815272ba:
                          // WARNING: Could not recover jumptable at 0x0001815272d1. Too many branches
                          // WARNING: Treating indirect jump as call
          lVar5 = (*(code *)*puVar6)(plVar4,param_2,puVar6[1]);
          return lVar5;
        }
        cVar3 = FUN_180d75bc0(param_2,0);
        if (cVar3) {
          lVar5 = UIAtlas.GetListOfSprites(this,0);
          return lVar5;
        }
        if (this.mSprites != null) {
          if (this.mSprites.Count == null) {
            UIAtlas.Upgrade(this,0);
          }
          lVar5 = new BetterList_1(DAT_181da64d0);
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
                if (((lVar2 != null) &&
                    (cVar3 = FUN_180d75bc0(lVar2._items,0), !cVar3)) &&
                   (cVar3 = String.Equals(param_2,lVar2._items,5), cVar3)) {
                  if (lVar5 != null) {
                    FUN_181584270(lVar5,lVar2._items,DAT_181da6550);
                    return lVar5;
                  }
                  throw; // [null/range check failed]
                }
                uVar13 = uVar13 + 1;
                lVar15 = lVar15 + 8;
                uVar10 = (uint64)((uint32)uVar10 + 1);
              } while ((int64)uVar13 < lVar12);
            }
            lVar12 = FUN_1800d60b0(DAT_181da1058,1);
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
                     (lVar15 = il2cpp_internal(lVar12,*(uint64 *)(*plVar4 + 64))) == null)
                  {
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
                         (cVar3 = FUN_180d75bc0(lVar12._items,0), !cVar3)) {
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
                          FUN_181584270(lVar5,lVar12._items,DAT_181da6550);
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
    }

    // Token : 0x60006E6
    // RVA   : 0x1526E80   Offset: 0x1526280   Length: 0x4C0
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
        plVar4 = (int64 *)il2cpp_internal(this.mReplacement,DAT_181d7a7a0);
        if (plVar4 != (int64 *)0) {
          lVar5 = *plVar4;
          uVar16 = 0;
          if (*(uint16 *)(lVar5 + 0x12a) != 0) {
            do {
              if (*(int64 *)(*(int64 *)(lVar5 + 176) + (uint64)uVar16 * 16) == DAT_181d7a7a0)
              {
                puVar6 = (uint64 *)
                         ((int64)*(int *)(*(int64 *)(lVar5 + 176) + 8 + (uint64)uVar16 * 16) *
                          16 + 0x1f8 + lVar5);
                goto LAB_1815272ba;
              }
              uVar16 = uVar16 + 1;
            } while (uVar16 < *(uint16 *)(lVar5 + 0x12a));
          }
          puVar6 = (uint64 *)FUN_1800914f0(plVar4,DAT_181d7a7a0,12);
        LAB_1815272ba:
                          // WARNING: Could not recover jumptable at 0x0001815272d1. Too many branches
                          // WARNING: Treating indirect jump as call
          lVar5 = (*(code *)*puVar6)(plVar4,match,puVar6[1]);
          return lVar5;
        }
        cVar3 = FUN_180d75bc0(match,0);
        if (cVar3) {
          lVar5 = UIAtlas.GetListOfSprites(this,0);
          return lVar5;
        }
        if (this.mSprites != null) {
          if (this.mSprites.Count == null) {
            UIAtlas.Upgrade(this,0);
          }
          lVar5 = new BetterList_1(DAT_181da64d0);
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
                if (((lVar2 != null) &&
                    (cVar3 = FUN_180d75bc0(lVar2._items,0), !cVar3)) &&
                   (cVar3 = String.Equals(match,lVar2._items,5), cVar3)) {
                  if (lVar5 != null) {
                    FUN_181584270(lVar5,lVar2._items,DAT_181da6550);
                    return lVar5;
                  }
                  throw; // [null/range check failed]
                }
                uVar13 = uVar13 + 1;
                lVar15 = lVar15 + 8;
                uVar10 = (uint64)((uint32)uVar10 + 1);
              } while ((int64)uVar13 < lVar12);
            }
            lVar12 = FUN_1800d60b0(DAT_181da1058,1);
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
                     (lVar15 = il2cpp_internal(lVar12,*(uint64 *)(*plVar4 + 64))) == null)
                  {
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
                         (cVar3 = FUN_180d75bc0(lVar12._items,0), !cVar3)) {
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
                          FUN_181584270(lVar5,lVar12._items,DAT_181da6550);
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
    }

    // Token : 0x60006E7
    // RVA   : 0x1527C30   Offset: 0x1527030   Length: 0x110
    public virtual bool References(INGUIAtlas atlas)
    {
        long lVar1;
        ulong uVar4;
        ushort uVar5;
        if (atlas != null) {
          if (atlas == this) {
            return true;
          }
          plVar2 = (int64 *)il2cpp_internal(this.mReplacement,DAT_181d7a7a0);
          if (plVar2 != (int64 *)0) {
            lVar1 = *plVar2;
            uVar5 = 0;
            if (*(uint16 *)(lVar1 + 0x12a) != 0) {
              do {
                if (*(int64 *)(*(int64 *)(lVar1 + 176) + (uint64)uVar5 * 16) == DAT_181d7a7a0)
                {
                  puVar3 = (uint64 *)
                           ((int64)*(int *)(*(int64 *)(lVar1 + 176) + 8 + (uint64)uVar5 * 16)
                            * 16 + 0x208 + lVar1);
                  goto LAB_181527cf8;
                }
                uVar5 = uVar5 + 1;
              } while (uVar5 < *(uint16 *)(lVar1 + 0x12a));
            }
            puVar3 = (uint64 *)FUN_1800914f0(plVar2,DAT_181d7a7a0,13);
        LAB_181527cf8:
                          // WARNING: Could not recover jumptable at 0x000181527d0c. Too many branches
                          // WARNING: Treating indirect jump as call
            uVar4 = (*(code *)*puVar3)(plVar2,atlas,puVar3[1]);
            return uVar4;
          }
        }
        return false;
    }

    // Token : 0x60006E8
    // RVA   : 0x1527650   Offset: 0x1526A50   Length: 0x4B0
    public virtual void MarkAsChanged()
    {
        int iVar1;
        long lVar2;
        bool cVar3;
        long lVar6;
        ulong uVar7;
        long lVar8;
        ushort uVar9;
        uint uVar10;
        uint uVar11;
        plVar4 = (int64 *)il2cpp_internal(this.mReplacement,DAT_181d7a7a0);
        uVar10 = 0;
        if (plVar4 != (int64 *)0) {
          lVar6 = *plVar4;
          uVar9 = 0;
          if (*(uint16 *)(lVar6 + 0x12a) != 0) {
            do {
              if (*(int64 *)(*(int64 *)(lVar6 + 176) + (uint64)uVar9 * 16) == DAT_181d7a7a0) {
                puVar5 = (uint64 *)
                         ((int64)*(int *)(*(int64 *)(lVar6 + 176) + 8 + (uint64)uVar9 * 16) *
                          16 + 0x218 + lVar6);
                goto LAB_18152774c;
              }
              uVar9 = uVar9 + 1;
            } while (uVar9 < *(uint16 *)(lVar6 + 0x12a));
          }
          puVar5 = (uint64 *)FUN_1800914f0(plVar4,DAT_181d7a7a0,14);
        LAB_18152774c:
          (*(code *)*puVar5)(plVar4,puVar5[1]);
        }
        lVar6 = NGUITools.FindActive(DAT_181d8f0b8);
        uVar11 = 0;
        if (lVar6 != null) {
          iVar1 = *(int *)(lVar6 + 24);
          if (0 < iVar1) {
            do {
              if (*(uint32 *)(lVar6 + 24) <= uVar11) {
                uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar7,0);
              }
              lVar2 = lVar6[uVar11];
              if (lVar2 == null) throw; // [null/range check failed]
              uVar7 = UISprite.get_atlas(lVar2,0);
              cVar3 = NGUITools.CheckIfRelated(this,uVar7,0);
              if (cVar3) {
                UISprite.get_atlas(lVar2,0);
                UISprite.set_atlas(lVar2,0);
                UISprite.set_atlas(lVar2);
              }
              uVar11 = uVar11 + 1;
            } while ((int)uVar11 < iVar1);
          }
          lVar6 = Resources.FindObjectsOfTypeAll(DAT_181d9fc98);
          uVar11 = 0;
          if (lVar6 != null) {
            iVar1 = *(int *)(lVar6 + 24);
            if (0 < iVar1) {
              do {
                if (*(uint32 *)(lVar6 + 24) <= uVar11) {
                  uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1800d65f0(uVar7,0);
                }
                lVar2 = lVar6[uVar11];
                if (lVar2 == null) throw; // [null/range check failed]
                lVar8 = NGUIFont.get_atlas(lVar2);
                if (lVar8 != null) {
                  uVar7 = NGUIFont.get_atlas(lVar2,0);
                  cVar3 = NGUITools.CheckIfRelated(this,uVar7,0);
                  if (cVar3) {
                    NGUIFont.get_atlas(lVar2,0);
                    NGUIFont.set_atlas(lVar2,0);
                    NGUIFont.set_atlas(lVar2);
                  }
                }
                uVar11 = uVar11 + 1;
              } while ((int)uVar11 < iVar1);
            }
            lVar6 = Resources.FindObjectsOfTypeAll(DAT_181d9fd18);
            uVar11 = 0;
            if (lVar6 != null) {
              iVar1 = *(int *)(lVar6 + 24);
              if (0 < iVar1) {
                do {
                  if (*(uint32 *)(lVar6 + 24) <= uVar11) {
                    uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                    FUN_1800d65f0(uVar7,0);
                  }
                  lVar2 = lVar6[uVar11];
                  if (lVar2 == null) throw; // [null/range check failed]
                  uVar7 = UIFont.get_atlas(lVar2,0);
                  cVar3 = NGUITools.CheckIfRelated(this,uVar7,0);
                  if (cVar3) {
                    UIFont.get_atlas(lVar2,0);
                    UIFont.set_atlas(lVar2,0);
                    UIFont.set_atlas(lVar2);
                  }
                  uVar11 = uVar11 + 1;
                } while ((int)uVar11 < iVar1);
              }
              lVar6 = NGUITools.FindActive(DAT_181d8efb8);
              if (lVar6 != null) {
                iVar1 = *(int *)(lVar6 + 24);
                if (0 < iVar1) {
                  do {
                    if (*(uint32 *)(lVar6 + 24) <= uVar10) {
                      uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                      FUN_1800d65f0(uVar7,0);
                    }
                    lVar2 = lVar6[uVar10];
                    if (lVar2 == null) throw; // [null/range check failed]
                    lVar8 = UILabel.get_atlas(lVar2);
                    if (lVar8 != null) {
                      uVar7 = UILabel.get_atlas(lVar2,0);
                      cVar3 = NGUITools.CheckIfRelated(this,uVar7,0);
                      if (cVar3) {
                        UILabel.get_atlas(lVar2,0);
                        UILabel.get_bitmapFont(lVar2,0);
                        UILabel.set_bitmapFont(lVar2,0);
                        UILabel.set_bitmapFont(lVar2);
                      }
                    }
                    uVar10 = uVar10 + 1;
                  } while ((int)uVar10 < iVar1);
                }
                return;
              }
            }
          }
        }
    }

    // Token : 0x60006E9
    // RVA   : 0x1527E70   Offset: 0x1527270   Length: 0x56E
    private bool Upgrade()
    {
        bool cVar2;
        uint uVar3;
        uint uVar4;
        ulong uVar6;
        long lVar7;
        long lVar8;
        uint uVar9;
        long lVar12;
        uint uVar13;
        float fVar14;
        float fVar15;
        ulong local_88;
        ulong uStack_80;
        uint local_78;
        uint uStack_74;
        uint uStack_70;
        uint32 uStack_6c;
        uint32 local_68;
        uint32 uStack_64;
        uint32 uStack_60;
        uint32 uStack_5c;
        uint8 local_58 [16];
        uint8 local_48 [32];
        local_88 = 0;
        uStack_80 = 0;
        local_78 = 0;
        uStack_74 = 0;
        uStack_70 = 0;
        uStack_6c = 0;
        plVar5 = (int64 *)il2cpp_internal(this.mReplacement,DAT_181d7a7a0);
        plVar11 = (int64 *)0;
        if (plVar5 != (int64 *)0) {
          if ((*(byte *)(*plVar5 + 300) < *(byte *)(DAT_181daf510 + 300)) ||
             (*(int64 *)
               (*(int64 *)(*plVar5 + 200) + -8 + (uint64)*(byte *)(DAT_181daf510 + 300) * 8) !=
              DAT_181daf510)) {
            bVar1 = false;
          }
          else {
            bVar1 = true;
          }
          plVar10 = plVar11;
          if (bVar1) {
            plVar10 = plVar5;
          }
          cVar2 = Object.op_Inequality(plVar10,0,0);
          if (cVar2) {
            if (plVar10 != (int64 *)0) {
              uVar6 = UIAtlas.Upgrade(plVar10,0);
              return uVar6;
            }
            goto LAB_1815283d9;
          }
        }
        if (this.mSprites == null) {
        LAB_1815283d9:
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
        if (this.mSprites.Count == null) {
          if (this.sprites == null) goto LAB_1815283d9;
          if (0 < this.sprites.Count) {
            uVar6 = this.material;
            cVar2 = Object.op_Implicit(uVar6,0);
            if (cVar2) {
              if (this.material != null) {
                plVar5 = (int64 *)Material.get_mainTexture(this.material,0);
                cVar2 = Object.op_Inequality(plVar5,0,0);
                uVar4 = 0x200;
                if (!cVar2) {
                  uVar3 = 0x200;
                }
                else {
                  if (plVar5 == (int64 *)0) goto LAB_1815283d9;
                  uVar3 = (**(code **)(*plVar5 + 0x178))(plVar5,*(uint64 *)(*plVar5 + 0x180));
                }
                cVar2 = Object.op_Inequality(plVar5,0,0);
                if (cVar2) {
                  if (plVar5 == (int64 *)0) goto LAB_1815283d9;
                  uVar4 = (**(code **)(*plVar5 + 0x198))(plVar5,*(uint64 *)(*plVar5 + 0x1a0));
                }
                lVar7 = this.sprites;
                if (lVar7 != null) {
                  lVar12 = 32;
                  do {
                    uVar9 = (uint32)plVar11;
                    if (lVar7.Count <= (int)uVar9) {
                      FUN_1812fa020(lVar7,DAT_181db3db0);
                      return true;
                    }
                    if (lVar7 == null) break;
                    if (lVar7.Count <= uVar9) {
                      ThrowHelper.ThrowArgumentOutOfRangeException(0);
                    }
                    lVar7 = *(int64 *)(lVar12 + lVar7._items);
                    if (lVar7 == null) break;
                    local_88 = lVar7.Count;
                    uStack_80 = *(uint64 *)(lVar7 + 32);
                    local_78 = *(uint32 *)(lVar7 + 40);
                    uStack_74 = *(uint32 *)(lVar7 + 44);
                    uStack_70 = *(uint32 *)(lVar7 + 48);
                    uStack_6c = *(uint32 *)(lVar7 + 52);
                    if (this.mCoordinates == 1) {
                      local_68 = lVar7.Count;
                      uStack_64 = lVar7._version;
                      uStack_60 = *(uint32 *)(lVar7 + 32);
                      uStack_5c = *(uint32 *)(lVar7 + 36);
                      NGUIMath.ConvertToPixels(local_58,&local_68,uVar3,uVar4,1,0);
                      local_68 = local_78;
                      uStack_64 = uStack_74;
                      uStack_60 = uStack_70;
                      uStack_5c = uStack_6c;
                      NGUIMath.ConvertToPixels(local_48,&local_68,uVar3,uVar4,1,0);
                    }
                    lVar8 = new UISpriteData(0);
                    if (lVar8 == null) break;
                    *(uint64 *)(lVar8 + 16) = lVar7._items;
                    uVar13 = FUN_180d995d0(&local_88,0);
                    uVar13 = Mathf.RoundToInt(uVar13,0);
                    *(uint32 *)(lVar8 + 24) = uVar13;
                    uVar13 = FUN_18044df60(&local_88,0);
                    uVar13 = Mathf.RoundToInt(uVar13,0);
                    *(uint32 *)(lVar8 + 28) = uVar13;
                    uVar13 = FUN_180d995b0(&local_88,0);
                    uVar13 = Mathf.RoundToInt(uVar13,0);
                    *(uint32 *)(lVar8 + 32) = uVar13;
                    uVar13 = FUN_18044e2b0(&local_88,0);
                    uVar13 = Mathf.RoundToInt(uVar13,0);
                    *(uint32 *)(lVar8 + 36) = uVar13;
                    fVar15 = *(float *)(lVar7 + 60);
                    fVar14 = (float)FUN_180d995b0(&local_88,0);
                    uVar13 = Mathf.RoundToInt(fVar14 * fVar15,0);
                    *(uint32 *)(lVar8 + 56) = uVar13;
                    fVar15 = *(float *)(lVar7 + 64);
                    fVar14 = (float)FUN_180d995b0(&local_88,0);
                    uVar13 = Mathf.RoundToInt(fVar14 * fVar15,0);
                    *(uint32 *)(lVar8 + 60) = uVar13;
                    fVar15 = *(float *)(lVar7 + 72);
                    fVar14 = (float)FUN_18044e2b0(&local_88,0);
                    uVar13 = Mathf.RoundToInt(fVar14 * fVar15,0);
                    *(uint32 *)(lVar8 + 68) = uVar13;
                    fVar15 = *(float *)(lVar7 + 68);
                    fVar14 = (float)FUN_18044e2b0(&local_88,0);
                    uVar13 = Mathf.RoundToInt(fVar14 * fVar15,0);
                    *(uint32 *)(lVar8 + 64) = uVar13;
                    fVar15 = (float)FUN_180d995d0(&local_78,0);
                    fVar14 = (float)FUN_180d995d0(&local_88,0);
                    uVar13 = Mathf.RoundToInt(fVar15 - fVar14,0);
                    *(uint32 *)(lVar8 + 40) = uVar13;
                    fVar15 = (float)Rect.get_xMax(&local_88,0);
                    fVar14 = (float)Rect.get_xMax(&local_78,0);
                    uVar13 = Mathf.RoundToInt(fVar15 - fVar14,0);
                    *(uint32 *)(lVar8 + 44) = uVar13;
                    fVar15 = (float)Rect.get_yMax(&local_88,0);
                    fVar14 = (float)Rect.get_yMax(&local_78,0);
                    uVar13 = Mathf.RoundToInt(fVar15 - fVar14,0);
                    *(uint32 *)(lVar8 + 52) = uVar13;
                    fVar15 = (float)FUN_18044df60(&local_78,0);
                    fVar14 = (float)FUN_18044df60(&local_88,0);
                    uVar13 = Mathf.RoundToInt(fVar15 - fVar14,0);
                    *(uint32 *)(lVar8 + 48) = uVar13;
                    if (this.mSprites == null) break;
                    FUN_18181e6b0(this.mSprites,lVar8,DAT_181daa830);
                    lVar7 = this.sprites;
                    plVar11 = (int64 *)(uint64)(uVar9 + 1);
                    lVar12 = lVar12 + 8;
                  } while (lVar7 != null);
                }
              }
              goto LAB_1815283d9;
            }
          }
        }
        return false;
    }

    // Token : 0x60006EA
    // RVA   : 0x15283E0   Offset: 0x15277E0   Length: 0x10E
    public void /*ctor*/()
    {
        ulong uVar1;
        uVar1 = il2cpp_internal(DAT_181d988e8);
        FUN_181330100(uVar1,DAT_181daa7b0);
        this.mSprites = uVar1;
        this.mPixelSize = 0x3f800000;
        uVar1 = il2cpp_internal(DAT_181d9a768);
        FUN_181330100(uVar1,DAT_181db3d28);
        this.sprites = uVar1;
        this.mPMA = 0xffffffff;
        uVar1 = il2cpp_internal(DAT_181d82d80);
        FUN_1808b1370(uVar1,DAT_181d739e8);
        this.mSpriteIndices = uVar1;
        FUN_18044ef50(this,0);
    }

}
