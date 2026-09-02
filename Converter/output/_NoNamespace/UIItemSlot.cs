// ============================================================
// Type  : UIItemSlot
// Token : 0x2000007
// ============================================================

public class UIItemSlot
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4000010
    public UISprite icon;

    // Token: 0x4000011
    public UIWidget background;

    // Token: 0x4000012
    public UILabel label;

    // Token: 0x4000013
    public AudioClip grabSound;

    // Token: 0x4000014
    public AudioClip placeSound;

    // Token: 0x4000015
    public AudioClip errorSound;

    // Token: 0x4000016
    private InvGameItem mItem;

    // Token: 0x4000017
    private string mText;

    // Token: 0x4000018
    private static InvGameItem mDraggedItem;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000013
    // (no native address)
    protected virtual InvGameItem get_observedItem()
    {
    }

    // Token : 0x6000014
    // (no native address)
    protected virtual InvGameItem Replace(InvGameItem item)
    {
    }

    // Token : 0x6000015
    // RVA   : 0x10F29B0   Offset: 0x10F11B0   Length: 0x789
    private void OnTooltip(bool show)
    {
        int iVar1;
        long lVar2;
        bool cVar3;
        long lVar4;
        long lVar6;
        long lVar8;
        ulong uVar11;
        long lVar12;
        ulong uVar13;
        ulong uVar14;
        uint uVar15;
        ulong local_48;
        ulong uStack_40;
        if (((!show) || (lVar12 = this.mItem) == null) ||
           (lVar4 = InvGameItem.get_baseItem(lVar12,0)) == null) {
          UITooltip.Hide(0);
          return;
        }
        plVar5 = (int64 *)FUN_1800d60b0(DAT_181d80cc0,5);
        if (plVar5 != (int64 *)0) {
          if (("[" != 0) &&
             (lVar6 = il2cpp_internal("[",*(uint64 *)(*plVar5 + 64))) == null) {
            uVar11 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar11,0);
          }
          lVar6 = "[";
          if ((int)plVar5[3] == 0) {
            uVar11 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar11,0);
          }
          plVar5[4] = "[";
          il2cpp_internal(plVar5 + 4,lVar6);
          puVar7 = (uint64 *)InvGameItem.get_color(&local_48,lVar12,0);
          local_48 = *puVar7;
          uStack_40 = puVar7[1];
          lVar6 = NGUIText.EncodeColor(&local_48,0);
          if ((lVar6 != null) &&
             (lVar8 = il2cpp_internal(lVar6,*(uint64 *)(*plVar5 + 64))) == null) {
            uVar11 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar11,0);
          }
          if (*(uint32 *)(plVar5 + 3) < 2) {
            uVar11 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar11,0);
          }
          plVar5[5] = lVar6;
          il2cpp_internal(plVar5 + 5,lVar6);
          if (("]" != 0) &&
             (lVar6 = il2cpp_internal("]",*(uint64 *)(*plVar5 + 64))) == null) {
            uVar11 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar11,0);
          }
          lVar6 = "]";
          if (*(uint32 *)(plVar5 + 3) < 3) {
            uVar11 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar11,0);
          }
          plVar5[6] = "]";
          il2cpp_internal(plVar5 + 6,lVar6);
          lVar6 = InvGameItem.get_name(lVar12,0);
          if ((lVar6 != null) &&
             (lVar8 = il2cpp_internal(lVar6,*(uint64 *)(*plVar5 + 64))) == null) {
            uVar11 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar11,0);
          }
          if (*(uint32 *)(plVar5 + 3) < 4) {
            uVar11 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar11,0);
          }
          plVar5[7] = lVar6;
          il2cpp_internal(plVar5 + 7,lVar6);
          if (("[-]\n" != 0) &&
             (lVar6 = il2cpp_internal("[-]\n",*(uint64 *)(*plVar5 + 64))) == null) {
            uVar11 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar11,0);
          }
          lVar6 = "[-]\n";
          if (*(uint32 *)(plVar5 + 3) < 5) {
            uVar11 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar11,0);
          }
          plVar5[8] = "[-]\n";
          il2cpp_internal(plVar5 + 8,lVar6);
          lVar6 = String.Concat(plVar5,0);
          plVar5 = (int64 *)FUN_1800d60b0(DAT_181d80cc0,5);
          if (plVar5 != (int64 *)0) {
            if ((lVar6 != null) &&
               (lVar8 = il2cpp_internal(lVar6,*(uint64 *)(*plVar5 + 64))) == null) {
              uVar11 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar11,0);
            }
            if ((int)plVar5[3] == 0) {
              uVar11 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar11,0);
            }
            plVar5[4] = lVar6;
            il2cpp_internal(plVar5 + 4,lVar6);
            if (("[AFAFAF]Level " != 0) &&
               (lVar6 = il2cpp_internal("[AFAFAF]Level ",*(uint64 *)(*plVar5 + 64))) == null) {
              uVar11 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar11,0);
            }
            lVar6 = "[AFAFAF]Level ";
            if (*(uint32 *)(plVar5 + 3) < 2) {
              uVar11 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar11,0);
            }
            plVar5[5] = "[AFAFAF]Level ";
            il2cpp_internal(plVar5 + 5,lVar6);
            lVar6 = Int32.ToString(lVar12 + 24,0);
            if ((lVar6 != null) &&
               (lVar8 = il2cpp_internal(lVar6,*(uint64 *)(*plVar5 + 64))) == null) {
              uVar11 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar11,0);
            }
            if (*(uint32 *)(plVar5 + 3) < 3) {
              uVar11 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar11,0);
            }
            plVar5[6] = lVar6;
            il2cpp_internal(plVar5 + 6,lVar6);
            if ((" " != 0) &&
               (lVar6 = il2cpp_internal(" ",*(uint64 *)(*plVar5 + 64))) == null) {
              uVar11 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar11,0);
            }
            lVar6 = " ";
            if (*(uint32 *)(plVar5 + 3) < 4) {
              uVar11 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar11,0);
            }
            plVar5[7] = " ";
            il2cpp_internal(plVar5 + 7,lVar6);
            plVar9 = (int64 *)il2cpp_value_box(DAT_181d55b70,lVar4 + 40);
            if (plVar9 != (int64 *)0) {
              lVar6 = (**(code **)(*plVar9 + 0x168))(plVar9,*(uint64 *)(*plVar9 + 0x170));
              puVar10 = (uint32 *)il2cpp_object_unbox(plVar9);
              *(uint32 *)(lVar4 + 40) = *puVar10;
              if ((lVar6 != null) &&
                 (lVar8 = il2cpp_internal(lVar6,*(uint64 *)(*plVar5 + 64))) == null) {
                uVar11 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar11,0);
              }
              if (*(uint32 *)(plVar5 + 3) < 5) {
                uVar11 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar11,0);
              }
              plVar5[8] = lVar6;
              il2cpp_internal(plVar5 + 8,lVar6);
              uVar11 = String.Concat(plVar5,0);
              lVar12 = InvGameItem.CalculateStats(lVar12,0);
              uVar15 = 0;
              if (lVar12 != null) {
                iVar1 = *(int *)(lVar12 + 24);
                if (0 < iVar1) {
                  lVar8 = 32;
                  lVar6 = 0;
                  do {
                    if (*(uint32 *)(lVar12 + 24) <= uVar15) {
                      ThrowHelper.ThrowArgumentOutOfRangeException(0);
                    }
                    lVar2 = *(int64 *)(lVar8 + *(int64 *)(lVar12 + 16));
                    if (lVar2 == null) throw; // [null/range check failed]
                    if (*(int *)(lVar2 + 24) != 0) {
                      if (*(int *)(lVar2 + 24) < 0) {
                        uVar13 = Int32.ToString(lVar2 + 24,0);
                        uVar14 = "\n[FF0000]";
                      }
                      else {
                        uVar13 = Int32.ToString(lVar2 + 24,0);
                        uVar14 = "\n[00FF00]+";
                      }
                      uVar11 = String.Concat(uVar11,uVar14,uVar13,0);
                      if (*(int *)(lVar2 + 20) == 1) {
                        uVar11 = String.Concat(uVar11,"%",0);
                      }
                      plVar5 = (int64 *)il2cpp_value_box(DAT_181d55c70,(uint32 *)(lVar2 + 16));
                      if (plVar5 == (int64 *)0) throw; // [null/range check failed]
                      uVar14 = (**(code **)(*plVar5 + 0x168))(plVar5,*(uint64 *)(*plVar5 + 0x170));
                      puVar10 = (uint32 *)il2cpp_object_unbox(plVar5);
                      *(uint32 *)(lVar2 + 16) = *puVar10;
                      uVar11 = String.Concat(uVar11," ",uVar14,0);
                      uVar11 = String.Concat(uVar11,"[-]",0);
                    }
                    uVar15 = uVar15 + 1;
                    lVar6 = lVar6 + 1;
                    lVar8 = lVar8 + 8;
                  } while (lVar6 < iVar1);
                }
                cVar3 = FUN_180d6ca90(*(uint64 *)(lVar4 + 32),0);
                if (!cVar3) {
                  uVar11 = String.Concat(uVar11,"\n[FF9900]",*(uint64 *)(lVar4 + 32),0);
                }
                UITooltip.Show(uVar11,0);
                return;
              }
            }
          }
        }
    }

    // Token : 0x6000016
    // RVA   : 0x10F25E0   Offset: 0x10F0DE0   Length: 0x1B3
    private void OnClick()
    {
        var pStatics = *(int64*)(DAT_181d8a9d8 + 184);
        ulong uVar3;
        long lVar4;
        long lVar5;
        if (*pStatics == 0) {
          if (this[9] != 0) {
            uVar3 = (**(code **)(*this + 0x188))(this,0,*(uint64 *)(*this + 400));
            puVar1 = *(uint64 **)(DAT_181d8a9d8 + 184);
            *puVar1 = uVar3;
            il2cpp_internal(puVar1,uVar3);
            if (*pStatics != 0) {
              lVar4 = this[6];
              NGUITools.PlaySound(lVar4,0);
            }
            UIItemSlot.UpdateCursor(this,0);
            return;
          }
        }
        else {
          lVar4 = (**(code **)(*this + 0x188))
                            (this,**(uint64 **)(DAT_181d8a9d8 + 184),
                             *(uint64 *)(*this + 400));
          if (*pStatics == lVar4) {
            lVar5 = this[8];
          }
          else if (lVar4 == null) {
            lVar5 = this[7];
          }
          else {
            lVar5 = this[6];
          }
          NGUITools.PlaySound(lVar5,0);
          plVar2 = pStatics;
          *plVar2 = lVar4;
          il2cpp_internal(plVar2,lVar4);
          UIItemSlot.UpdateCursor(this,0);
        }
    }

    // Token : 0x6000017
    // RVA   : 0x10F27A0   Offset: 0x10F0FA0   Length: 0x11B
    private void OnDrag(Vector2 delta)
    {
        long lVar1;
        ulong uVar3;
        if ((**(int64 **)(DAT_181d8a9d8 + 184) == 0) && (this[9] != 0)) {
          lVar1 = *(int64 *)(*(int64 *)(DAT_181d8a458 + 184) + 224);
          if (lVar1 == null) {
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          *(uint32 *)(lVar1 + 112) = 2;
          uVar3 = (**(code **)(*this + 0x188))(this,0,*(uint64 *)(*this + 400));
          puVar2 = *(uint64 **)(DAT_181d8a9d8 + 184);
          *puVar2 = uVar3;
          il2cpp_internal(puVar2,uVar3);
          lVar1 = this[6];
          NGUITools.PlaySound(lVar1,0);
          UIItemSlot.UpdateCursor(this,0);
        }
    }

    // Token : 0x6000018
    // RVA   : 0x10F28C0   Offset: 0x10F10C0   Length: 0xE3
    private void OnDrop(GameObject go)
    {
        var pStatics = *(int64*)(DAT_181d8a9d8 + 184);
        long lVar2;
        long lVar3;
        lVar2 = (**(code **)(*this + 0x188))
                          (this,**(uint64 **)(DAT_181d8a9d8 + 184),*(uint64 *)(*this + 400)
                          );
        if (*pStatics == lVar2) {
          lVar3 = this[8];
        }
        else if (lVar2 == null) {
          lVar3 = this[7];
        }
        else {
          lVar3 = this[6];
        }
        NGUITools.PlaySound(lVar3,0);
        plVar1 = pStatics;
        *plVar1 = lVar2;
        il2cpp_internal(plVar1,lVar2);
        UIItemSlot.UpdateCursor(this,0);
    }

    // Token : 0x6000019
    // RVA   : 0x10F3140   Offset: 0x10F1940   Length: 0xE7
    private void UpdateCursor()
    {
        var pStatics = *(int64*)(DAT_181d8a9d8 + 184);
        ulong uVar1;
        long lVar2;
        ulong uVar3;
        if (*pStatics != 0) {
          lVar2 = InvGameItem.get_baseItem(*pStatics,0);
          if (lVar2 != null) {
            if (*pStatics != 0) {
              lVar2 = InvGameItem.get_baseItem(*pStatics,0);
              if (lVar2 != null) {
                uVar3 = *(uint64 *)(lVar2 + 88);
                if (*pStatics != 0) {
                  lVar2 = InvGameItem.get_baseItem(*pStatics,0);
                  if (lVar2 != null) {
                    uVar1 = *(uint64 *)(lVar2 + 96);
                    uVar3 = il2cpp_internal(uVar3,DAT_181d55650);
                    UICursor.Set(uVar3,uVar1,0);
                    return;
                  }
                }
              }
            }
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
        }
        UICursor.Clear(0);
    }

    // Token : 0x600001A
    // RVA   : 0x10F3230   Offset: 0x10F1A30   Length: 0x2B6
    private void Update()
    {
        long lVar1;
        bool cVar3;
        long lVar4;
        long lVar5;
        long lVar6;
        ulong uVar7;
        uint local_18;
        uint uStack_14;
        uint uStack_10;
        uint32 uStack_c;
        lVar4 = (**(code **)(*this + 0x178))(this,*(uint64 *)(*this + 0x180));
        plVar2 = this + 9;
        if (*plVar2 == lVar4) {
          return;
        }
        *plVar2 = lVar4;
        il2cpp_internal(plVar2,lVar4);
        lVar6 = 0;
        lVar5 = lVar6;
        if (lVar4 != null) {
          lVar5 = InvGameItem.get_baseItem(lVar4,0);
        }
        lVar1 = this[5];
        cVar3 = Object.op_Inequality(lVar1,0,0);
        if (cVar3) {
          if (lVar4 != null) {
            lVar6 = InvGameItem.get_name(lVar4,0);
          }
          cVar3 = FUN_180d6ca90(this[10],0);
          if (cVar3) {
            if (this[5] == 0) goto LAB_1810f34e1;
            this[10] = *(int64 *)(this[5] + 0x1a0);
            il2cpp_internal(this + 10);
          }
          if (lVar6 == null) {
            lVar6 = this[10];
          }
          if (this[5] == 0) goto LAB_1810f34e1;
          UILabel.set_text(this[5],lVar6,0);
        }
        lVar6 = this[3];
        cVar3 = Object.op_Inequality(lVar6,0,0);
        if (cVar3) {
          if (lVar5 != null) {
            uVar7 = *(uint64 *)(lVar5 + 88);
            cVar3 = Object.op_Equality(uVar7,0,0);
            if (!cVar3) {
              lVar6 = this[3];
              if (lVar6 == null) goto LAB_1810f34e1;
              uVar7 = il2cpp_internal(*(uint64 *)(lVar5 + 88),DAT_181d55650);
              UISprite.set_atlas(lVar6,uVar7,0);
              if (this[3] == 0) goto LAB_1810f34e1;
              UISprite.set_spriteName(this[3],*(uint64 *)(lVar5 + 96),0);
              if (this[3] == 0) goto LAB_1810f34e1;
              Behaviour.set_enabled(this[3],1,0);
              plVar2 = (int64 *)this[3];
              if (plVar2 == (int64 *)0) goto LAB_1810f34e1;
              (**(code **)(*plVar2 + 0x348))(plVar2,*(uint64 *)(*plVar2 + 0x350));
              goto LAB_1810f3454;
            }
          }
          if (this[3] == 0) goto LAB_1810f34e1;
          Behaviour.set_enabled(this[3],0,0);
        }
        LAB_1810f3454:
        lVar6 = this[4];
        cVar3 = Object.op_Inequality(lVar6,0,0);
        if (cVar3) {
          lVar6 = this[4];
          if (lVar4 == null) {
            puVar8 = (uint32 *)FUN_181098a50(&local_18,0);
          }
          else {
            puVar8 = (uint32 *)InvGameItem.get_color(&local_18,lVar4,0);
          }
          local_18 = *puVar8;
          uStack_14 = puVar8[1];
          uStack_10 = puVar8[2];
          uStack_c = puVar8[3];
          if (lVar6 == null) {
        LAB_1810f34e1:
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          UIWidget.set_color(lVar6,&local_18,0);
        }
    }

    // Token : 0x600001B
    // RVA   : 0x10E65F0   Offset: 0x10E4DF0   Length: 0x47
    protected void /*ctor*/()
    {
        this.mText = "";
        FUN_18044ef50(this,0);
    }

}
