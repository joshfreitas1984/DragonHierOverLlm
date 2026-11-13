// ============================================================
// Type  : KeepSubmeshGraphicSameSize
// Token : 0x20002FF
// ============================================================

public class KeepSubmeshGraphicSameSize
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x40018DF
    public int frameCount;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6001925
    // RVA   : 0x7B9EE0   Offset: 0x7B8CE0   Length: 0x40A
    private void LateUpdate()
    {
        ulong uVar1;
        ulong uVar2;
        bool cVar3;
        int iVar4;
        long lVar5;
        long lVar6;
        ulong uVar7;
        ulong uVar8;
        int iVar9;
        ulong uVar10;
        int[] local_res8 = new int[2];
        if (this.frameCount != null) {
        LAB_1807ba294:
          if (this.frameCount == 1) {
            Object.Destroy(this,0);
          }
          this.frameCount = this.frameCount + 1;
          return;
        }
        uVar7 = 0;
        lVar5 = Component.get_transform(this,0);
        uVar8 = uVar7;
        uVar10 = uVar7;
        while (lVar5 != null) {
          iVar4 = Transform.get_childCount(lVar5,0);
          iVar9 = (int)uVar10;
          if (iVar4 <= (int)uVar7) {
            if (3 < iVar9) {
              lVar5 = Component.GetComponent(this,DAT_181e78a38);
              if (lVar5 == null) {
                          // WARNING: Subroutine does not return
                FUN_1801e0300();
              }
              uVar1 = *(uint64 *)(lVar5 + 248);
              local_res8[0] = iVar9;
              uVar2 = il2cpp_value_box(DAT_181e60808,local_res8);
              uVar1 = String.Format("{0} submesh num {1}! ",uVar1,uVar2,0);
              Debug.Log(uVar1,0);
            }
            goto LAB_1807ba294;
          }
          lVar5 = Component.get_transform(this,0);
          if ((lVar5 == null) || (lVar5 = Transform.GetChild(lVar5,uVar7,0)) == null) break;
          uVar1 = Component.GetComponent(lVar5);
          cVar3 = Object.op_Inequality(uVar1);
          if (cVar3) {
            uVar10 = (uint64)(iVar9 + 1);
            cVar3 = Object.op_Equality(uVar8,0);
            if (!cVar3) {
              lVar5 = Component.get_transform(this,0);
              if (((((lVar5 == null) || (lVar5 = Transform.GetChild(lVar5,uVar7,0)) == null) ||
                   (lVar5 = Component.GetComponent(lVar5,DAT_181e78d38)) == null) ||
                  ((lVar5 = Graphic.get_rectTransform(lVar5,0), uVar8 == 0 ||
                   (lVar6 = Graphic.get_rectTransform(uVar8,0)) == null))) ||
                 (uVar1 = RectTransform.get_pivot(lVar6,0), lVar5 == null)) break;
              RectTransform.set_pivot(lVar5,uVar1);
              lVar5 = Component.get_transform(this,0);
              if (((lVar5 == null) || (lVar5 = Transform.GetChild(lVar5,uVar7,0)) == null) ||
                 (lVar5 = Component.GetComponent(lVar5,DAT_181e78d38)) == null) break;
              lVar5 = Graphic.get_rectTransform(lVar5,0);
              lVar6 = Graphic.get_rectTransform(uVar8,0);
              if ((lVar6 == null) || (uVar1 = RectTransform.get_anchoredPosition(lVar6,0), lVar5 == null))
              break;
              RectTransform.set_anchoredPosition(lVar5,uVar1);
              lVar5 = Component.get_transform(this,0);
              if ((lVar5 == null) ||
                 ((lVar5 = Transform.GetChild(lVar5,uVar7,0), lVar5 == null ||
                  (lVar5 = Component.GetComponent(lVar5,DAT_181e78d38)) == null))) break;
              lVar5 = Graphic.get_rectTransform(lVar5,0);
              lVar6 = Graphic.get_rectTransform(uVar8,0);
              if ((lVar6 == null) || (RectTransform.get_sizeDelta(lVar6,0), lVar5 == null)) break;
              RectTransform.set_sizeDelta(lVar5);
            }
            else {
              lVar5 = Component.get_transform(this,0);
              if ((lVar5 == null) || (lVar5 = Transform.GetChild(lVar5,uVar7,0)) == null) break;
              uVar8 = Component.GetComponent(lVar5);
            }
          }
          uVar7 = (uint64)((int)uVar7 + 1);
          lVar5 = Component.get_transform(this);
        }
    }

    // Token : 0x6001926
    // RVA   : 0x2110A0   Offset: 0x20FEA0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_180ae8740(this,0);
    }

}
