// ============================================================
// Type  : BookWriterUIController
// Token : 0x20001A1
// ============================================================

public class BookWriterUIController
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4000B6C
    public ForceData targetForce;

    // Token: 0x4000B6D
    public List<BookWriterData> targetBookWriterList;

    // Token: 0x4000B6E
    public GameObject bookWriterUI;

    // Token: 0x4000B6F
    public int activeID;

    // Token: 0x4000B70
    private static readonly int MaxBookWriterNum;

    // Token: 0x4000B71
    private GameObject temp;

    // Token: 0x4000B72
    private static BookWriterUIController _instance;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000D5F
    // RVA   : 0xC8B0E0   Offset: 0xC8A4E0   Length: 0x58
    public static BookWriterUIController get_Instance()
    {
        return *(uint64 *)(*(int64 *)(DAT_181db29d0 + 184) + 8);
    }

    // Token : 0x6000D60
    // RVA   : 0xC860D0   Offset: 0xC854D0   Length: 0x68
    private void Awake()
    {
        puVar1 = (uint64 *)(*(int64 *)(DAT_181db29d0 + 184) + 8);
        *puVar1 = this;
        il2cpp_internal(puVar1,this);
    }

    // Token : 0x6000D61
    // RVA   : 0xC86B40   Offset: 0xC85F40   Length: 0x8D
    public bool BookWriterUnlocked(int writerID)
    {
        long lVar1;
        if (this.targetForce == null) {
          return true;
        }
        lVar1 = ForceData.MainArea(this.targetForce,0);
        if (lVar1 != null) {
          lVar1 = AreaData.FindBuilding(lVar1,"藏经阁",0);
          if (lVar1 != null) {
            return writerID <= (int)((float)*(int *)(lVar1 + 20) / 3.0);
          }
        }
    }

    // Token : 0x6000D62
    // RVA   : 0xC88050   Offset: 0xC87450   Length: 0x9F
    public Transform GetWriterRoot(int writerID)
    {
        long lVar1;
        ulong uVar2;
        uint[] local_res10 = new uint[6];
        local_res10[0] = writerID;
        if (this.bookWriterUI != null) {
          lVar1 = GameObject.get_transform(this.bookWriterUI,0);
          if (lVar1 != null) {
            lVar1 = Transform.Find(lVar1,"BookWriterGrid",0);
            uVar2 = Int32.ToString(local_res10,0);
            if (lVar1 != null) {
              lVar1 = Transform.Find(lVar1,uVar2,0);
              if (lVar1 != null) {
                Transform.Find(lVar1,"Root",0);
                return;
              }
            }
          }
        }
    }

    // Token : 0x6000D63
    // RVA   : 0xC881E0   Offset: 0xC875E0   Length: 0x244E
    public void RefreshUI()
    {
        long lVar1;
        byte uVar2;
        bool cVar3;
        uint uVar5;
        int iVar6;
        long lVar7;
        ulong uVar8;
        ulong uVar9;
        long lVar10;
        ulong uVar13;
        int iVar14;
        float fVar16;
        int[] local_res18 = new int[2];
        uint[] local_res20 = new uint[2];
        float local_c8;
        uint[] local_c4 = new uint[3];
        uint local_b8;
        uint uStack_b4;
        uint uStack_b0;
        uint32 uStack_ac;
        uint8 local_a8 [16];
        uint8 local_98 [16];
        uint8 local_88 [16];
        uint8 local_78 [16];
        uint8 local_68 [16];
        uint8 local_58 [48];
        iVar14 = 0;
        local_c8 = 0.0;
        local_res18[0] = 0;
        local_res20[0] = 0;
        LAB_180c884e0:
        if (**(int **)(DAT_181db29d0 + 184) <= iVar14) {
          if ((((this.bookWriterUI != null) &&
               (lVar7 = GameObject.get_transform(this.bookWriterUI,0)) != null) &&
              (lVar7 = Transform.Find(lVar7,"BookWriterGrid",0)) != null) &&
             (lVar7 = Component.GetComponent(lVar7,DAT_181d96978)) != null) {
            UIGrid.set_repositionNow(lVar7,1,0);
            return;
          }
          goto LAB_180c8a61d;
        }
        if (this.targetBookWriterList == null) goto LAB_180c8a629;
        if (iVar14 < this.targetBookWriterList.Count) {
          lVar7 = BookWriterUIController.GetWriterRoot(this);
          if ((lVar7 == null) || (lVar7 = FUN_180daa030(lVar7,0)) == null) goto LAB_180c8a629;
          lVar7 = Component.get_gameObject(lVar7,0);
          if (lVar7 == null) goto LAB_180c8a629;
          GameObject.SetActive(lVar7,1,0);
          if (0 < iVar14) {
            lVar7 = BookWriterUIController.GetWriterRoot(this,iVar14,0);
            if (lVar7 == null) {
        LAB_180c8a629:
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            lVar7 = Component.get_gameObject(lVar7,0);
            uVar2 = BookWriterUIController.BookWriterUnlocked(this,iVar14,0);
            if (lVar7 == null) goto LAB_180c8a629;
            GameObject.SetActive(lVar7,uVar2,0);
            lVar7 = BookWriterUIController.GetWriterRoot(this,iVar14,0);
            if (((lVar7 == null) || (lVar7 = FUN_180daa030(lVar7,0)) == null) ||
               (lVar7 = Transform.Find(lVar7,"Lock",0)) == null) goto LAB_180c8a629;
            lVar7 = Component.get_gameObject(lVar7,0);
            cVar3 = BookWriterUIController.BookWriterUnlocked(this,iVar14,0);
            if (lVar7 == null) goto LAB_180c8a629;
            GameObject.SetActive(lVar7,!cVar3,0);
            lVar7 = BookWriterUIController.GetWriterRoot(this,iVar14,0);
            if (((lVar7 == null) || (lVar7 = FUN_180daa030(lVar7,0)) == null) ||
               ((lVar7 = Transform.Find(lVar7,"Lock",0), lVar7 == null ||
                (lVar7 = Transform.Find(lVar7,"Text",0)) == null))) goto LAB_180c8a629;
            uVar8 = Component.GetComponent(lVar7,DAT_181d96178);
            uVar9 = GlobalData.GetNumText(iVar14 * 3,0);
            uVar9 = String.Format("建筑{0}级解锁",uVar9,0);
            LTLocalization.SetText(uVar8,uVar9,0);
          }
          lVar7 = BookWriterUIController.GetWriterRoot(this,iVar14,0);
          if ((lVar7 == null) || (lVar7 = Transform.Find(lVar7,"ActiveCover",0)) == null)
          goto LAB_180c8a629;
          lVar7 = Component.get_gameObject(lVar7,0);
          if (lVar7 == null) goto LAB_180c8a629;
          GameObject.SetActive(lVar7,this.activeID != iVar14,0);
          local_res18[0] = 0;
          do {
            lVar7 = BookWriterUIController.GetWriterRoot(this,iVar14,0);
            if (lVar7 == null) goto LAB_180c8a629;
            lVar7 = Transform.Find(lVar7,"Tabs",0);
            uVar8 = Int32.ToString(local_res18,0);
            if ((lVar7 == null) || (lVar7 = Transform.Find(lVar7,uVar8,0)) == null) goto LAB_180c8a629;
            lVar7 = Component.GetComponent(lVar7,DAT_181d962f8);
            if ((this.targetBookWriterList == null) ||
               ((lVar10 = FUN_180002f80(this.targetBookWriterList,iVar14,DAT_181d80438), lVar10 == null
                || (lVar7 == null)))) goto LAB_180c8a629;
            bVar15 = false;
            Selectable.set_interactable(lVar7,*(char *)(lVar10 + 56) == false,0);
            if ((this.targetBookWriterList == null) ||
               (lVar7 = FUN_180002f80(this.targetBookWriterList,iVar14)) == null)
            goto LAB_180c8a629;
            if (*(int *)(lVar7 + 20) == local_res18[0]) {
              lVar7 = BookWriterUIController.GetWriterRoot(this,iVar14);
              if (lVar7 == null) goto LAB_180c8a629;
              lVar7 = Transform.Find(lVar7,"Tabs");
              uVar8 = Int32.ToString(local_res18,0);
              if (((lVar7 == null) || (lVar7 = Transform.Find(lVar7,uVar8)) == null) ||
                 (lVar7 = Component.GetComponent(lVar7,DAT_181d962f8)) == null) goto LAB_180c8a629;
              if (*(char *)(lVar7 + 0x118) == false) {
                lVar7 = BookWriterUIController.GetWriterRoot(this,iVar14);
                if (lVar7 == null) goto LAB_180c8a629;
                lVar7 = Transform.Find(lVar7,"Tabs");
                uVar8 = Int32.ToString(local_res18,0);
                if (((lVar7 == null) || (lVar7 = Transform.Find(lVar7,uVar8)) == null) ||
                   (lVar7 = Component.GetComponent(lVar7,DAT_181d962f8)) == null) goto LAB_180c8a629;
                Toggle.set_isOn(lVar7,1);
              }
            }
            local_res18[0] = local_res18[0] + 1;
          } while (local_res18[0] < 3);
          lVar7 = BookWriterUIController.GetWriterRoot(this,iVar14,0);
          if ((lVar7 == null) || (lVar7 = Transform.Find(lVar7,"Hero",0)) == null)
          goto LAB_180c8a629;
          uVar8 = Transform.Find(lVar7,"icon",0);
          cVar3 = Object.op_Inequality(uVar8,0,0);
          if (cVar3) {
            lVar7 = BookWriterUIController.GetWriterRoot(this,iVar14,0);
            if ((((lVar7 == null) || (lVar7 = Transform.Find(lVar7,"Hero",0)) == null) ||
                (lVar7 = Transform.Find(lVar7,"icon",0)) == null) ||
               (lVar7 = Component.GetComponent(lVar7,DAT_181d940f8)) == null) goto LAB_180c8a629;
            lVar7 = *(int64 *)(lVar7 + 32);
            if ((this.targetBookWriterList == null) ||
               (lVar10 = FUN_180002f80(this.targetBookWriterList,iVar14,DAT_181d80438)) == null)
            goto LAB_180c8a629;
            lVar10 = BookWriterData.GetBookWriterHero(lVar10,0);
            if (lVar7 != lVar10) {
              lVar7 = BookWriterUIController.GetWriterRoot(this,iVar14,0);
              if (((lVar7 == null) || (lVar7 = Transform.Find(lVar7,"Hero",0)) == null) ||
                 (lVar7 = Transform.Find(lVar7,"icon",0)) == null) goto LAB_180c8a629;
              uVar8 = Component.get_gameObject(lVar7,0);
              Object.Destroy(uVar8,0);
            }
          }
          if ((this.targetBookWriterList == null) ||
             (lVar7 = FUN_180002f80(this.targetBookWriterList,iVar14,DAT_181d80438)) == null)
          goto LAB_180c8a629;
          lVar7 = BookWriterData.GetBookWriterHero(lVar7,0);
          if (lVar7 != null) {
            lVar7 = BookWriterUIController.GetWriterRoot(this,iVar14,0);
            if ((lVar7 == null) || (lVar7 = Transform.Find(lVar7,"Hero",0)) == null)
            goto LAB_180c8a629;
            uVar8 = Transform.Find(lVar7,"icon",0);
            cVar3 = Object.op_Equality(uVar8,0,0);
            if (cVar3) {
              lVar7 = BookWriterUIController.GetWriterRoot(this,iVar14,0);
              if ((lVar7 == null) || (lVar7 = Transform.Find(lVar7,"Hero",0)) == null)
              goto LAB_180c8a629;
              uVar8 = Component.get_gameObject(lVar7,0);
              lVar7 = FUN_18046c1a0(0);
              if (lVar7 == null) goto LAB_180c8a629;
              uVar9 = *(uint64 *)(lVar7 + 144);
              uVar8 = GlobalData.AddChild(uVar8,uVar9,0);
              this.temp = uVar8;
              if (this.temp == null) goto LAB_180c8a629;
              lVar7 = GameObject.GetComponent(this.temp,DAT_181d71b50);
              if (((this.targetBookWriterList == null) ||
                  (lVar10 = FUN_180002f80(this.targetBookWriterList,iVar14,DAT_181d80438), lVar10 == null
                  )) || (uVar8 = BookWriterData.GetBookWriterHero(lVar10,0), lVar7 == null))
              goto LAB_180c8a629;
              *(uint64 *)(lVar7 + 32) = uVar8;
              if ((this.temp == null) ||
                 (lVar7 = GameObject.GetComponent(this.temp,DAT_181d71b50),
                 lVar7 == null)) goto LAB_180c8a629;
              *(uint32 *)(lVar7 + 24) = 0;
              if ((this.temp == null) ||
                 (lVar7 = GameObject.GetComponent(this.temp,DAT_181d71b50),
                 lVar7 == null)) goto LAB_180c8a629;
              Object.set_name(lVar7,"icon",0);
            }
          }
          lVar7 = BookWriterUIController.GetWriterRoot(this,iVar14,0);
          if ((lVar7 == null) || (lVar7 = Transform.Find(lVar7,"ClearHeroButton",0)) == null)
          goto LAB_180c8a629;
          lVar7 = Component.get_gameObject(lVar7,0);
          if ((this.targetBookWriterList == null) ||
             (lVar10 = FUN_180002f80(this.targetBookWriterList,iVar14,DAT_181d80438)) == null)
          goto LAB_180c8a629;
          lVar10 = BookWriterData.GetBookWriterHero(lVar10,0);
          bVar4 = bVar15;
          if (lVar10 != null) {
            if ((this.targetBookWriterList == null) ||
               (lVar10 = FUN_180002f80(this.targetBookWriterList,iVar14,DAT_181d80438)) == null)
            goto LAB_180c8a629;
            bVar4 = *(char *)(lVar10 + 56) == false;
          }
          if (lVar7 == null) goto LAB_180c8a629;
          GameObject.SetActive(lVar7,bVar4,0);
          lVar7 = BookWriterUIController.GetWriterRoot(this,iVar14,0);
          if (((lVar7 == null) || (lVar7 = Transform.Find(lVar7,"Combine",0)) == null) ||
             (lVar7 = Transform.Find(lVar7,"CombineTarget",0)) == null) goto LAB_180c8a629;
          uVar8 = Transform.Find(lVar7,"icon",0);
          cVar3 = Object.op_Inequality(uVar8,0,0);
          if (cVar3) {
            lVar7 = BookWriterUIController.GetWriterRoot(this,iVar14,0);
            if (((lVar7 == null) || (lVar7 = Transform.Find(lVar7,"Combine",0)) == null) ||
               ((lVar7 = Transform.Find(lVar7,"CombineTarget",0), lVar7 == null ||
                (lVar7 = Transform.Find(lVar7,"icon",0)) == null))) goto LAB_180c8a629;
            uVar8 = Component.get_gameObject(lVar7,0);
            Object.Destroy(uVar8,0);
          }
          lVar7 = BookWriterUIController.GetWriterRoot(this,iVar14,0);
          if (((lVar7 == null) || (lVar7 = Transform.Find(lVar7,"Combine",0)) == null) ||
             (lVar7 = Transform.Find(lVar7,"CombineTarget2",0)) == null) goto LAB_180c8a629;
          uVar8 = Transform.Find(lVar7,"icon",0);
          cVar3 = Object.op_Inequality(uVar8,0,0);
          if (cVar3) {
            lVar7 = BookWriterUIController.GetWriterRoot(this,iVar14,0);
            if (((lVar7 == null) || (lVar7 = Transform.Find(lVar7,"Combine",0)) == null) ||
               ((lVar7 = Transform.Find(lVar7,"CombineTarget2",0), lVar7 == null ||
                (lVar7 = Transform.Find(lVar7,"icon",0)) == null))) goto LAB_180c8a629;
            uVar8 = Component.get_gameObject(lVar7,0);
            Object.Destroy(uVar8,0);
          }
          lVar7 = BookWriterUIController.GetWriterRoot(this,iVar14,0);
          if (((lVar7 == null) || (lVar7 = Transform.Find(lVar7,"Copy",0)) == null) ||
             (lVar7 = Transform.Find(lVar7,"CopyTarget",0)) == null) goto LAB_180c8a629;
          uVar8 = Transform.Find(lVar7,"icon",0);
          cVar3 = Object.op_Inequality(uVar8,0,0);
          if (cVar3) {
            lVar7 = BookWriterUIController.GetWriterRoot(this,iVar14,0);
            if (((lVar7 == null) || (lVar7 = Transform.Find(lVar7,"Copy",0)) == null) ||
               ((lVar7 = Transform.Find(lVar7,"CopyTarget",0), lVar7 == null ||
                (lVar7 = Transform.Find(lVar7,"icon",0)) == null))) goto LAB_180c8a629;
            uVar8 = Component.get_gameObject(lVar7,0);
            Object.Destroy(uVar8,0);
          }
          lVar7 = BookWriterUIController.GetWriterRoot(this,iVar14,0);
          if (((lVar7 == null) || (lVar7 = Transform.Find(lVar7,"Memory",0)) == null) ||
             (lVar7 = Transform.Find(lVar7,"MemoryTarget",0)) == null) goto LAB_180c8a629;
          uVar8 = Transform.Find(lVar7,"icon",0);
          cVar3 = Object.op_Inequality(uVar8,0,0);
          if (cVar3) {
            lVar7 = BookWriterUIController.GetWriterRoot(this,iVar14,0);
            if (((lVar7 == null) || (lVar7 = Transform.Find(lVar7,"Memory",0)) == null) ||
               ((lVar7 = Transform.Find(lVar7,"MemoryTarget",0), lVar7 == null ||
                (lVar7 = Transform.Find(lVar7,"icon",0)) == null))) goto LAB_180c8a629;
            uVar8 = Component.get_gameObject(lVar7,0);
            Object.Destroy(uVar8,0);
          }
          if ((this.targetBookWriterList == null) ||
             (lVar7 = FUN_180002f80(this.targetBookWriterList,iVar14,DAT_181d80438)) == null)
          goto LAB_180c8a629;
          iVar6 = *(int *)(lVar7 + 20);
          if (iVar6 == 0) {
            if ((this.targetBookWriterList == null) ||
               (lVar7 = FUN_180002f80(this.targetBookWriterList,iVar14,DAT_181d80438)) == null)
            goto LAB_180c8a629;
            if (*(int64 *)(lVar7 + 32) != 0) {
              lVar7 = BookWriterUIController.GetWriterRoot(this,iVar14,0);
              if (((lVar7 == null) || (lVar7 = Transform.Find(lVar7,"Combine",0)) == null) ||
                 (lVar7 = Transform.Find(lVar7,"CombineTarget",0)) == null) goto LAB_180c8a629;
              uVar8 = Component.get_gameObject(lVar7,0);
              lVar7 = FUN_18046c1a0(0);
              if (lVar7 == null) goto LAB_180c8a629;
              uVar9 = *(uint64 *)(lVar7 + 160);
              uVar8 = GlobalData.AddChild(uVar8,uVar9,0);
              this.temp = uVar8;
              if (this.temp == null) goto LAB_180c8a629;
              lVar7 = GameObject.GetComponent(this.temp,DAT_181d720a0);
              if (((this.targetBookWriterList == null) ||
                  (lVar10 = FUN_180002f80(this.targetBookWriterList,iVar14,DAT_181d80438), lVar10 == null
                  )) || (lVar7 == null)) goto LAB_180c8a629;
              *(uint64 *)(lVar7 + 32) = *(uint64 *)(lVar10 + 32);
              if ((this.temp == null) ||
                 (lVar7 = GameObject.GetComponent(this.temp,DAT_181d720a0),
                 lVar7 == null)) goto LAB_180c8a629;
              *(uint32 *)(lVar7 + 40) = 1;
              if ((this.temp == null) ||
                 (lVar7 = GameObject.GetComponent(this.temp,DAT_181d720a0),
                 lVar7 == null)) goto LAB_180c8a629;
              Object.set_name(lVar7,"icon",0);
              lVar7 = BookWriterUIController.GetWriterRoot(this,iVar14,0);
              if (((lVar7 == null) || (lVar7 = Transform.Find(lVar7,"Combine",0)) == null) ||
                 (lVar7 = Transform.Find(lVar7,"CombineTarget2",0)) == null) goto LAB_180c8a629;
              uVar8 = Component.get_gameObject(lVar7,0);
              lVar7 = FUN_18046c1a0(0);
              if (lVar7 == null) goto LAB_180c8a629;
              uVar8 = GlobalData.AddChild(uVar8,*(uint64 *)(lVar7 + 160),0);
              this.temp = uVar8;
              if (this.temp == null) goto LAB_180c8a629;
              lVar7 = GameObject.GetComponent(this.temp,DAT_181d720a0);
              if ((this.targetBookWriterList == null) ||
                 (lVar10 = FUN_180002f80(this.targetBookWriterList,iVar14,DAT_181d80438)) == null
                 ) goto LAB_180c8a629;
              uVar8 = *(uint64 *)(lVar10 + 40);
        LAB_180c89790:
              if (lVar7 == null) goto LAB_180c8a629;
              *(uint64 *)(lVar7 + 32) = uVar8;
              if ((this.temp == null) ||
                 (lVar7 = GameObject.GetComponent(this.temp,DAT_181d720a0),
                 lVar7 == null)) goto LAB_180c8a629;
              *(uint32 *)(lVar7 + 40) = 1;
              lVar7 = this.temp;
              uVar8 = DAT_181d720a0;
              if (lVar7 == null) goto LAB_180c8a629;
        LAB_180c897e2:
              lVar7 = GameObject.GetComponent(lVar7,uVar8);
              if (lVar7 == null) goto LAB_180c8a629;
              Object.set_name(lVar7,"icon",0);
            }
          }
          else if (iVar6 == 1) {
            if ((this.targetBookWriterList == null) ||
               (lVar7 = FUN_180002f80(this.targetBookWriterList,iVar14,DAT_181d80438)) == null)
            goto LAB_180c8a629;
            if (*(int64 *)(lVar7 + 32) != 0) {
              lVar7 = BookWriterUIController.GetWriterRoot(this,iVar14,0);
              if (((lVar7 != null) && (lVar7 = Transform.Find(lVar7,"Copy",0)) != null) &&
                 (lVar7 = Transform.Find(lVar7,"CopyTarget",0)) != null) {
                uVar8 = Component.get_gameObject(lVar7,0);
                lVar7 = FUN_18046c1a0(0);
                if (lVar7 != null) {
                  uVar9 = *(uint64 *)(lVar7 + 160);
                  uVar8 = GlobalData.AddChild(uVar8,uVar9,0);
                  this.temp = uVar8;
                  if (this.temp != null) {
                    lVar7 = GameObject.GetComponent(this.temp,DAT_181d720a0);
                    if ((this.targetBookWriterList != null) &&
                       (lVar10 = FUN_180002f80(this.targetBookWriterList,iVar14,DAT_181d80438),
                       lVar10 != null)) {
                      uVar8 = *(uint64 *)(lVar10 + 32);
                      goto LAB_180c89790;
                    }
                  }
                }
              }
              goto LAB_180c8a629;
            }
          }
          else if (iVar6 == 2) {
            if ((this.targetBookWriterList == null) ||
               (lVar7 = FUN_180002f80(this.targetBookWriterList,iVar14,DAT_181d80438)) == null)
            goto LAB_180c8a629;
            if (*(int64 *)(lVar7 + 48) != 0) {
              lVar7 = BookWriterUIController.GetWriterRoot(this,iVar14,0);
              if (((lVar7 != null) && (lVar7 = Transform.Find(lVar7,"Memory",0)) != null) &&
                 (lVar7 = Transform.Find(lVar7,"MemoryTarget",0)) != null) {
                uVar8 = Component.get_gameObject(lVar7,0);
                lVar7 = FUN_18046c1a0(0);
                if (lVar7 != null) {
                  uVar9 = *(uint64 *)(lVar7 + 168);
                  uVar8 = GlobalData.AddChild(uVar8,uVar9,0);
                  this.temp = uVar8;
                  if (this.temp != null) {
                    lVar7 = GameObject.GetComponent(this.temp,DAT_181d73800);
                    if (((this.targetBookWriterList != null) &&
                        (lVar10 = FUN_180002f80(this.targetBookWriterList,iVar14,DAT_181d80438),
                        lVar10 != null)) && (lVar7 != null)) {
                      *(uint64 *)(lVar7 + 32) = *(uint64 *)(lVar10 + 48);
                      if ((this.temp != null) &&
                         (lVar7 = GameObject.GetComponent(this.temp,DAT_181d73800),
                         lVar7 != null)) {
                        *(uint32 *)(lVar7 + 40) = 2;
                        lVar7 = this.temp;
                        uVar8 = DAT_181d73800;
                        if (lVar7 != null) goto LAB_180c897e2;
                      }
                    }
                  }
                }
              }
              goto LAB_180c8a629;
            }
          }
          lVar7 = BookWriterUIController.GetWriterRoot(this,iVar14,0);
          if ((lVar7 == null) || (lVar7 = Transform.Find(lVar7,"ClearBookButton",0)) == null)
          goto LAB_180c8a629;
          lVar7 = Component.get_gameObject(lVar7,0);
          if ((this.targetBookWriterList == null) ||
             (lVar10 = FUN_180002f80(this.targetBookWriterList,iVar14,DAT_181d80438)) == null)
          goto LAB_180c8a629;
          if (*(int64 *)(lVar10 + 32) == 0) {
            if ((this.targetBookWriterList == null) ||
               (lVar10 = FUN_180002f80(this.targetBookWriterList,iVar14,DAT_181d80438)) == null)
            goto LAB_180c8a629;
            if (*(int64 *)(lVar10 + 48) == 0)
            {
              }
              else {
            }
            if ((this.targetBookWriterList == null) ||
               (lVar10 = FUN_180002f80(this.targetBookWriterList,iVar14,DAT_181d80438)) == null)
            goto LAB_180c8a629;
            bVar15 = *(char *)(lVar10 + 56) == false;
          }
          if (lVar7 == null) goto LAB_180c8a629;
          GameObject.SetActive(lVar7,bVar15,0);
          if ((this.targetBookWriterList == null) ||
             (lVar7 = FUN_180002f80(this.targetBookWriterList,iVar14,DAT_181d80438)) == null)
          goto LAB_180c8a629;
          iVar6 = *(int *)(lVar7 + 20);
          if ((iVar6 == 0) || (iVar6 == 1)) {
            lVar7 = *(int64 *)(lVar7 + 32);
        LAB_180c8991e:
            if (lVar7 == null) goto LAB_180c89d7f;
            if ((this.targetBookWriterList == null) ||
               (lVar7 = FUN_180002f80(this.targetBookWriterList,iVar14,DAT_181d80438)) == null)
            goto LAB_180c8a629;
            if (*(char *)(lVar7 + 56) != false) goto LAB_180c89d7f;
            lVar7 = BookWriterUIController.GetWriterRoot(this,iVar14,0);
            if ((lVar7 == null) || (lVar7 = Transform.Find(lVar7,"CostTime",0)) == null)
            goto LAB_180c8a629;
            uVar8 = Component.GetComponent(lVar7,DAT_181d96178);
            if ((this.targetBookWriterList == null) ||
               (lVar7 = FUN_180002f80(this.targetBookWriterList,iVar14,DAT_181d80438)) == null)
            goto LAB_180c8a629;
            fVar16 = (float)BookWriterData.GetEachDayWorkPercent(lVar7,0);
            local_res20[0] = Mathf.CeilToInt(1.0 / fVar16,0);
            uVar9 = Int32.ToString(local_res20,0);
            uVar9 = String.Concat("预计时间: ",uVar9,"天",0);
            LTLocalization.SetText(uVar8,uVar9,0);
            lVar7 = BookWriterUIController.GetWriterRoot(this,iVar14,0);
            if ((lVar7 == null) || (lVar7 = Transform.Find(lVar7,"CostMoney",0)) == null)
            goto LAB_180c8a629;
            uVar8 = Component.GetComponent(lVar7,DAT_181d96178);
            if ((this.targetBookWriterList == null) ||
               (lVar7 = FUN_180002f80(this.targetBookWriterList,iVar14,DAT_181d80438)) == null)
            goto LAB_180c8a629;
            local_res20[0] = BookWriterData.GetMoneyCost(lVar7,0);
            uVar9 = Int32.ToString(local_res20,0);
            uVar9 = String.Concat("消耗银两: ",uVar9,0);
            LTLocalization.SetText(uVar8,uVar9,0);
            lVar7 = BookWriterUIController.GetWriterRoot(this,iVar14,0);
            if ((lVar7 == null) || (lVar7 = Transform.Find(lVar7,"CostMoney",0)) == null)
            goto LAB_180c8a629;
            plVar11 = (int64 *)Component.GetComponent(lVar7,DAT_181d96178);
            if ((this.targetBookWriterList == null) ||
               (lVar7 = FUN_180002f80(this.targetBookWriterList,iVar14,DAT_181d80438)) == null)
            goto LAB_180c8a629;
            cVar3 = BookWriterData.HaveMoney(lVar7,0);
            if (!cVar3) {
              puVar12 = (uint32 *)Color.get_red(local_98,0);
            }
            else {
              puVar12 = (uint32 *)Color.get_black(local_a8);
            }
            if (plVar11 == (int64 *)0) {
        LAB_180c8a623:
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            local_b8 = *puVar12;
            uStack_b4 = puVar12[1];
            uStack_b0 = puVar12[2];
            uStack_ac = puVar12[3];
            (**(code **)(*plVar11 + 0x2a8))(plVar11,&local_b8,*(uint64 *)(*plVar11 + 0x2b0));
            lVar7 = BookWriterUIController.GetWriterRoot(this,iVar14,0);
            if ((lVar7 == null) || (lVar7 = Transform.Find(lVar7,"MinKnowledge",0)) == null)
            goto LAB_180c8a623;
            uVar8 = Component.GetComponent(lVar7,DAT_181d96178);
            if ((this.targetBookWriterList == null) ||
               (lVar7 = FUN_180002f80(this.targetBookWriterList,iVar14,DAT_181d80438)) == null)
            goto LAB_180c8a623;
            local_c4[0] = BookWriterData.GetMinSkillLv(lVar7,0);
            uVar9 = il2cpp_value_box(DAT_181d80430,local_c4);
            lVar7 = *(int64 *)(*(int64 *)(DAT_181d73d40 + 184) + 0x4a0);
            if (((this.targetBookWriterList == null) ||
                (lVar10 = FUN_180002f80(this.targetBookWriterList,iVar14,DAT_181d80438)) == null)
               || (uVar5 = BookWriterData.GetTargetSkillType(lVar10,0), lVar7 == null)) goto LAB_180c8a623;
            uVar13 = FUN_180002f80(lVar7,uVar5,DAT_181da4370);
            uVar9 = String.Format("需要学识{0}/{1}{0}",uVar9,uVar13,0);
            LTLocalization.SetText(uVar8,uVar9,0);
            lVar7 = BookWriterUIController.GetWriterRoot(this,iVar14,0);
            if ((lVar7 == null) || (lVar7 = Transform.Find(lVar7,"MinKnowledge",0)) == null)
            goto LAB_180c8a623;
            plVar11 = (int64 *)Component.GetComponent(lVar7,DAT_181d96178);
            if ((this.targetBookWriterList == null) ||
               (lVar7 = FUN_180002f80(this.targetBookWriterList,iVar14,DAT_181d80438)) == null)
            goto LAB_180c8a623;
            cVar3 = BookWriterData.HaveEnoughSkill(lVar7,0);
            if (!cVar3) {
              puVar12 = (uint32 *)Color.get_red(local_78,0);
            }
            else {
              puVar12 = (uint32 *)Color.get_black(local_88);
            }
            if (plVar11 == (int64 *)0) goto LAB_180c8a629;
            local_b8 = *puVar12;
            uStack_b4 = puVar12[1];
            uStack_b0 = puVar12[2];
            uStack_ac = puVar12[3];
            (**(code **)(*plVar11 + 0x2a8))(plVar11,&local_b8,*(uint64 *)(*plVar11 + 0x2b0));
          }
          else {
            if (iVar6 == 2) {
              lVar7 = *(int64 *)(lVar7 + 48);
              goto LAB_180c8991e;
            }
        LAB_180c89d7f:
            lVar7 = BookWriterUIController.GetWriterRoot(this,iVar14,0);
            if ((lVar7 == null) || (lVar7 = Transform.Find(lVar7,"CostTime",0)) == null)
            goto LAB_180c8a61d;
            uVar8 = Component.GetComponent(lVar7,DAT_181d96178);
            if ((this.targetBookWriterList == null) ||
               (lVar7 = FUN_180002f80(this.targetBookWriterList,iVar14,DAT_181d80438)) == null)
            goto LAB_180c8a61d;
            uVar9 = "";
            if (*(char *)(lVar7 + 56) != false) {
              if ((this.targetBookWriterList == null) ||
                 (lVar7 = FUN_180002f80(this.targetBookWriterList,iVar14,DAT_181d80438)) == null)
              goto LAB_180c8a61d;
              fVar16 = (float)BookWriterData.GetEachDayWorkPercent(lVar7,0);
              iVar6 = Mathf.CeilToInt(1.0 / fVar16,0);
              if ((this.targetBookWriterList == null) ||
                 (lVar7 = FUN_180002f80(this.targetBookWriterList,iVar14,DAT_181d80438)) == null)
              goto LAB_180c8a61d;
              local_res20[0] = Mathf.CeilToInt((1.0 - *(float *)(lVar7 + 60)) * (float)iVar6,0);
              uVar9 = Int32.ToString(local_res20,0);
              uVar9 = String.Concat("预计时间:",uVar9,"天",0);
            }
            LTLocalization.SetText(uVar8,uVar9,0);
            lVar7 = BookWriterUIController.GetWriterRoot(this,iVar14,0);
            if ((lVar7 == null) || (lVar7 = Transform.Find(lVar7,"CostMoney",0)) == null)
            goto LAB_180c8a61d;
            uVar8 = Component.GetComponent(lVar7,DAT_181d96178);
            if ((this.targetBookWriterList == null) ||
               (lVar7 = FUN_180002f80(this.targetBookWriterList,iVar14,DAT_181d80438)) == null)
            goto LAB_180c8a61d;
            uVar9 = "";
            if (*(char *)(lVar7 + 56) != false) {
              if ((this.targetBookWriterList == null) ||
                 (lVar7 = FUN_180002f80(this.targetBookWriterList,iVar14,DAT_181d80438)) == null)
              goto LAB_180c8a61d;
              local_c8 = (float)BookWriterData.GetEachDayWorkPercent(lVar7,0);
              local_c8 = local_c8 * 100.0;
              uVar9 = Single.ToString(&local_c8,"+0",0);
              uVar9 = String.Concat("每日进度:",uVar9,"%",0);
            }
            LTLocalization.SetText(uVar8,uVar9,0);
            lVar7 = BookWriterUIController.GetWriterRoot(this,iVar14,0);
            if ((lVar7 == null) || (lVar7 = Transform.Find(lVar7,"MinKnowledge",0)) == null)
            goto LAB_180c8a61d;
            uVar8 = Component.GetComponent(lVar7,DAT_181d96178);
            LTLocalization.SetText(uVar8,"",0);
          }
          if ((this.targetBookWriterList == null) ||
             (lVar7 = FUN_180002f80(this.targetBookWriterList,iVar14,DAT_181d80438)) == null)
          goto LAB_180c8a61d;
          if (*(char *)(lVar7 + 56) == false) {
            lVar7 = BookWriterUIController.GetWriterRoot(this,iVar14);
            if ((lVar7 == null) || (lVar7 = Transform.Find(lVar7,"SureButton",0)) == null)
            goto LAB_180c8a61d;
            lVar7 = Component.GetComponent(lVar7,DAT_181d93778);
            if ((this.targetBookWriterList == null) ||
               (lVar10 = FUN_180002f80(this.targetBookWriterList,iVar14,DAT_181d80438)) == null)
            goto LAB_180c8a61d;
            iVar6 = *(int *)(lVar10 + 20);
            if ((iVar6 == 0) || (iVar6 == 1)) {
              lVar1 = *(int64 *)(lVar10 + 32);
        LAB_180c8a0d8:
              if ((lVar1 == null) || (*(int *)(lVar10 + 24) == -1)) goto LAB_180c8a0ec;
              uVar2 = BookWriterData.HaveMoney(lVar10,0);
            }
            else {
              if (iVar6 == 2) {
                lVar1 = *(int64 *)(lVar10 + 48);
                goto LAB_180c8a0d8;
              }
        LAB_180c8a0ec:
              uVar2 = 0;
            }
            if (lVar7 != null) {
              Selectable.set_interactable(lVar7,uVar2,0);
              lVar7 = BookWriterUIController.GetWriterRoot(this,iVar14,0);
              if (((lVar7 == null) || (lVar7 = Transform.Find(lVar7,"SureButton",0)) == null) ||
                 (lVar7 = Transform.Find(lVar7,"Label",0)) == null) goto LAB_180c8a61d;
              uVar8 = Component.GetComponent(lVar7,DAT_181d96178);
              LTLocalization.SetText(uVar8,"开始",0);
              lVar7 = BookWriterUIController.GetWriterRoot(this,iVar14,0);
              if ((lVar7 == null) || (lVar7 = Transform.Find(lVar7,"SureButton",0)) == null)
              goto LAB_180c8a61d;
              plVar11 = (int64 *)Component.GetComponent(lVar7,DAT_181d94478);
              puVar12 = (uint32 *)FUN_1810d3b80(local_68,0);
              if (plVar11 == (int64 *)0) goto LAB_180c8a61d;
              local_b8 = *puVar12;
              uStack_b4 = puVar12[1];
              uStack_b0 = puVar12[2];
              uStack_ac = puVar12[3];
              (**(code **)(*plVar11 + 0x2a8))(plVar11,&local_b8);
              lVar7 = BookWriterUIController.GetWriterRoot(this,iVar14);
              if (((lVar7 == null) || (lVar7 = Transform.Find(lVar7)) == null) ||
                 (lVar7 = Component.get_gameObject(lVar7)) == null) goto LAB_180c8a61d;
              goto LAB_180c8a58e;
            }
          }
          else {
            lVar7 = BookWriterUIController.GetWriterRoot(this,iVar14,0);
            if (((lVar7 != null) && (lVar7 = Transform.Find(lVar7,"SureButton",0)) != null) &&
               (lVar7 = Component.GetComponent(lVar7,DAT_181d93778)) != null) {
              Selectable.set_interactable(lVar7,1,0);
              lVar7 = BookWriterUIController.GetWriterRoot(this,iVar14,0);
              if (((lVar7 != null) && (lVar7 = Transform.Find(lVar7,"SureButton",0)) != null) &&
                 (lVar7 = Transform.Find(lVar7,"Label",0)) != null) {
                uVar8 = Component.GetComponent(lVar7,DAT_181d96178);
                LTLocalization.SetText(uVar8,"取消",0);
                lVar7 = BookWriterUIController.GetWriterRoot(this,iVar14,0);
                if ((lVar7 != null) && (lVar7 = Transform.Find(lVar7,"SureButton",0)) != null) {
                  plVar11 = (int64 *)Component.GetComponent(lVar7,DAT_181d94478);
                  puVar12 = (uint32 *)Color.get_red(local_58,0);
                  if (plVar11 != (int64 *)0) {
                    local_b8 = *puVar12;
                    uStack_b4 = puVar12[1];
                    uStack_b0 = puVar12[2];
                    uStack_ac = puVar12[3];
                    (**(code **)(*plVar11 + 0x2a8))(plVar11,&local_b8,*(uint64 *)(*plVar11 + 0x2b0));
                    lVar7 = BookWriterUIController.GetWriterRoot(this,iVar14,0);
                    if ((lVar7 != null) && (lVar7 = Transform.Find(lVar7,"PercentBarBack",0)) != null) {
                      lVar7 = Component.get_gameObject(lVar7,0);
                      if (lVar7 != null) {
                        GameObject.SetActive(lVar7,1,0);
                        lVar7 = BookWriterUIController.GetWriterRoot(this,iVar14,0);
                        if (((lVar7 != null) && (lVar7 = Transform.Find(lVar7,"PercentBarBack",0)) != null)
                           && (lVar7 = Transform.Find(lVar7,"PercentBar",0)) != null) {
                          lVar7 = Component.GetComponent(lVar7,DAT_181d94478);
                          if (((this.targetBookWriterList != null) &&
                              (lVar10 = FUN_180002f80(this.targetBookWriterList,iVar14,DAT_181d80438),
                              lVar10 != null)) && (lVar7 != null)) {
                            Image.set_fillAmount(lVar7);
                            lVar7 = BookWriterUIController.GetWriterRoot(this,iVar14,0);
                            if (((lVar7 != null) &&
                                (lVar7 = Transform.Find(lVar7,"PercentBarBack",0)) != null) &&
                               (lVar7 = Transform.Find(lVar7,"PercentNum",0)) != null) {
                              uVar8 = Component.GetComponent(lVar7,DAT_181d96178);
                              if ((this.targetBookWriterList == null) ||
                                 (lVar7 = FUN_180002f80(this.targetBookWriterList,iVar14)) == null
                                 ) goto LAB_180c8a61d;
                              local_c8 = *(float *)(lVar7 + 60) * 100.0;
                              uVar9 = Single.ToString(&local_c8,"f0");
                              String.Concat(uVar9,"%");
                              LTLocalization.SetText(uVar8);
                              iVar14 = iVar14 + 1;
                              goto LAB_180c884e0;
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
        LAB_180c8a61d:
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
        lVar7 = BookWriterUIController.GetWriterRoot(this);
        if (((lVar7 == null) || (lVar7 = FUN_180daa030(lVar7)) == null) ||
           (lVar7 = Component.get_gameObject(lVar7)) == null) goto LAB_180c8a629;
        LAB_180c8a58e:
        GameObject.SetActive(lVar7);
        iVar14 = iVar14 + 1;
        goto LAB_180c884e0;
    }

    // Token : 0x6000D64
    // RVA   : 0xC86140   Offset: 0xC85540   Length: 0x2F1
    public void BookWriterActiveCoverClicked(GameObject buttonClicked)
    {
        uint uVar1;
        bool cVar2;
        uint uVar3;
        long lVar4;
        ulong uVar5;
        if ((((buttonClicked != null) && (lVar4 = GameObject.get_transform(buttonClicked,0)) != null) &&
            (lVar4 = FUN_180daa030(lVar4,0)) != null) && (lVar4 = FUN_180daa030(lVar4,0)) != null)
        {
          uVar5 = Object.get_name(lVar4,0);
          uVar3 = Int32.Parse(uVar5,0);
          cVar2 = BookWriterUIController.BookWriterUnlocked(this,uVar3,0);
          if (!cVar2) {
            if (GameController._instance != null) {
              GameController.ShowTextOnMouse(GameController._instance,"未解锁",0);
              plVar6 = (int64 *)Resources.Load("Sound/SoundEffect/WrongClick",0);
              plVar7 = (int64 *)0;
              if ((plVar6 != (int64 *)0) && (*plVar6 == DAT_181daf360)) {
                plVar7 = plVar6;
              }
              NGUITools.PlaySound(plVar7,0);
              return;
            }
          }
          else {
            plVar6 = (int64 *)Resources.Load("Sound/SoundEffect/PaperQuick",0);
            plVar7 = (int64 *)0;
            if ((plVar6 != (int64 *)0) && (*plVar6 == DAT_181daf360)) {
              plVar7 = plVar6;
            }
            NGUITools.PlaySound(plVar7,0);
            uVar1 = this.activeID;
            if (-1 < (int)uVar1) {
              lVar4 = this.targetBookWriterList;
              if (lVar4 == null) throw; // [null/range check failed]
              if (lVar4.Count <= uVar1) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              lVar4 = lVar4._items[uVar1];
              if (lVar4 == null) throw; // [null/range check failed]
              if (*(char *)(lVar4 + 56) == false) {
                lVar4 = this.targetBookWriterList;
                if (lVar4 == null) throw; // [null/range check failed]
                uVar1 = this.activeID;
                if (lVar4.Count <= uVar1) {
                  ThrowHelper.ThrowArgumentOutOfRangeException(0);
                }
                lVar4 = lVar4._items[uVar1];
                if (lVar4 == null) throw; // [null/range check failed]
                BookWriterData.Reset(lVar4,0);
              }
            }
            lVar4 = GameObject.get_transform(buttonClicked,0);
            if (((lVar4 != null) && (lVar4 = FUN_180daa030(lVar4,0)) != null) &&
               (lVar4 = FUN_180daa030(lVar4,0)) != null) {
              uVar5 = Object.get_name(lVar4,0);
              uVar3 = Int32.Parse(uVar5,0);
              this.activeID = uVar3;
              BookWriterUIController.RefreshUI(this,0);
              return;
            }
          }
        }
    }

    // Token : 0x6000D65
    // RVA   : 0xC86910   Offset: 0xC85D10   Length: 0x224
    public void BookWriterTypeTabClicked(GameObject tabClicked)
    {
        uint uVar1;
        uint uVar2;
        long lVar3;
        long lVar4;
        ulong uVar5;
        if ((tabClicked != null) && (lVar3 = GameObject.GetComponent(tabClicked,DAT_181d743b0)) != null) {
          if (*(char *)(lVar3 + 0x118) == false) {
            return;
          }
          lVar3 = this.targetBookWriterList;
          lVar4 = GameObject.get_transform(tabClicked,0);
          if ((((lVar4 != null) && (lVar4 = FUN_180daa030(lVar4,0)) != null) &&
              (lVar4 = FUN_180daa030(lVar4,0)) != null) &&
             (lVar4 = FUN_180daa030(lVar4,0)) != null) {
            uVar5 = Object.get_name(lVar4,0);
            uVar1 = Int32.Parse(uVar5,0);
            if (lVar3 != null) {
              if (lVar3.Count <= uVar1) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              lVar3 = lVar3._items[uVar1];
              if (lVar3 != null) {
                if (*(char *)(lVar3 + 56) != false) {
        LAB_180c86b10:
                  BookWriterUIController.RefreshUI(this,0);
                  return;
                }
                lVar3 = this.targetBookWriterList;
                lVar4 = GameObject.get_transform(tabClicked,0);
                if (((lVar4 != null) && (lVar4 = FUN_180daa030(lVar4,0)) != null) &&
                   ((lVar4 = FUN_180daa030(lVar4,0), lVar4 != null &&
                    (lVar4 = FUN_180daa030(lVar4,0)) != null))) {
                  uVar5 = Object.get_name(lVar4,0);
                  uVar1 = Int32.Parse(uVar5,0);
                  if (lVar3 != null) {
                    if (lVar3.Count <= uVar1) {
                      ThrowHelper.ThrowArgumentOutOfRangeException(0);
                    }
                    lVar3 = lVar3._items[uVar1];
                    uVar5 = Object.get_name(tabClicked,0);
                    uVar2 = Int32.Parse(uVar5,0);
                    if (lVar3 != null) {
                      *(uint32 *)(lVar3 + 20) = uVar2;
                      lVar3 = GameObject.get_transform(tabClicked,0);
                      if (((lVar3 != null) && (lVar3 = FUN_180daa030(lVar3,0)) != null) &&
                         ((lVar3 = FUN_180daa030(lVar3,0), lVar3 != null &&
                          (lVar3 = FUN_180daa030(lVar3,0)) != null))) {
                        uVar5 = Object.get_name(lVar3,0);
                        BookWriterUIController.ClearChoosenBook(this,uVar5,0,0);
                        goto LAB_180c86b10;
                      }
                    }
                  }
                }
              }
            }
          }
        }
    }

    // Token : 0x6000D66
    // RVA   : 0xC871B0   Offset: 0xC865B0   Length: 0x9CA
    public void ChooseHeroButtonClicked(GameObject buttonClick)
    {
        bool cVar1;
        long lVar2;
        long lVar3;
        ulong uVar4;
        long lVar5;
        ulong uVar6;
        int iVar7;
        lVar2 = il2cpp_internal(DAT_181d93368);
        FUN_181330100(lVar2,DAT_181d8b430);
        if ((GameController._instance != null) &&
           (lVar3 = GameController._instance.worldData) != null) {
          lVar3 = WorldData.Player(lVar3,0);
          if (lVar3 != null) {
            if (*(char *)(lVar3 + 0x370) == false) {
              if ((GameController._instance == null) ||
                 (lVar3 = GameController._instance.worldData) == null)
              throw; // [null/range check failed]
              uVar4 = WorldData.Player(lVar3,0);
              if (lVar2 == null) throw; // [null/range check failed]
              FUN_18181e6b0(lVar2,uVar4,DAT_181d8b530);
            }
            if (this.targetForce == null) {
              if ((GameController._instance == null) ||
                 (lVar3 = GameController._instance.worldData) == null)
              throw; // [null/range check failed]
              lVar3 = WorldData.Player(lVar3,0);
              if (lVar3 == null) throw; // [null/range check failed]
              cVar1 = HeroData.HaveLover(lVar3,0);
              if (cVar1) {
                lVar3 = FUN_18046c0a0(0);
                if (lVar3 == null) throw; // [null/range check failed]
                lVar3 = lVar3.villageAreaID;
                lVar5 = FUN_18046c0a0(0);
                if ((lVar5 == null) || (*(int64 *)(lVar5 + 32) == 0)) throw; // [null/range check failed]
                lVar5 = WorldData.Player(*(int64 *)(lVar5 + 32),0);
                if ((lVar5 == null) || (lVar3 == null)) throw; // [null/range check failed]
                lVar3 = WorldData.GetHero(lVar3,*(uint32 *)(lVar5 + 0x328),0);
                if (lVar3 == null) throw; // [null/range check failed]
                if (!lVar3.BigMapRandomEventDatas) {
                  lVar3 = FUN_18046c0a0(0);
                  if (lVar3 == null) throw; // [null/range check failed]
                  lVar3 = lVar3.villageAreaID;
                  lVar5 = FUN_18046c0a0(0);
                  if ((lVar5 == null) || (*(int64 *)(lVar5 + 32) == 0)) throw; // [null/range check failed]
                  lVar5 = WorldData.Player(*(int64 *)(lVar5 + 32),0);
                  if ((lVar5 == null) || (lVar3 == null)) throw; // [null/range check failed]
                  lVar3 = WorldData.GetHero(lVar3,*(uint32 *)(lVar5 + 0x328),0);
                  if (lVar3 == null) throw; // [null/range check failed]
                  if (*(char *)(lVar3 + 209) == false) {
                    lVar3 = FUN_18046c0a0(0);
                    if (lVar3 == null) throw; // [null/range check failed]
                    lVar3 = lVar3.villageAreaID;
                    lVar5 = FUN_18046c0a0(0);
                    if ((lVar5 == null) || (*(int64 *)(lVar5 + 32) == 0)) throw; // [null/range check failed]
                    lVar5 = WorldData.Player(*(int64 *)(lVar5 + 32),0);
                    if ((lVar5 == null) || (lVar3 == null)) throw; // [null/range check failed]
                    lVar3 = WorldData.GetHero(lVar3,*(uint32 *)(lVar5 + 0x328),0);
                    if (lVar3 == null) throw; // [null/range check failed]
                    if (*(char *)(lVar3 + 0x370) == false) {
                      lVar3 = FUN_18046c0a0(0);
                      if (lVar3 == null) throw; // [null/range check failed]
                      lVar3 = lVar3.villageAreaID;
                      lVar5 = FUN_18046c0a0(0);
                      if ((lVar5 == null) || (*(int64 *)(lVar5 + 32) == 0)) throw; // [null/range check failed]
                      lVar5 = WorldData.Player(*(int64 *)(lVar5 + 32),0);
                      if ((lVar5 == null) || (lVar3 == null)) throw; // [null/range check failed]
                      uVar4 = WorldData.GetHero(lVar3,*(uint32 *)(lVar5 + 0x328),0);
                      if (lVar2 == null) throw; // [null/range check failed]
                      FUN_18181e6b0(lVar2,uVar4,DAT_181d8b530);
                    }
                  }
                }
              }
            }
            else {
              if ((GameController._instance == null) ||
                 (lVar3 = GameController._instance.worldData) == null)
              throw; // [null/range check failed]
              lVar3 = WorldData.Player(lVar3,0);
              if (lVar3 == null) throw; // [null/range check failed]
              if (lVar3.hour) {
                iVar7 = 0;
                while( true ) {
                  if ((GameController._instance == null) ||
                     (lVar3 = GameController._instance.worldData) == null)
                  break;
                  lVar3 = WorldData.Player(lVar3,0);
                  if (lVar3 == null) break;
                  lVar3 = HeroData.GetForce(lVar3,0,0);
                  if ((lVar3 == null) || (lVar3.lastRandomWorldEventDay == null)) break;
                  if (*(int *)(lVar3.lastRandomWorldEventDay + 24) <= iVar7) goto LAB_180c8769a;
                  lVar3 = FUN_18046c0a0(0);
                  if ((lVar3 == null) || (lVar3.villageAreaID == null)) break;
                  lVar3 = WorldData.Player(lVar3.villageAreaID,0);
                  if (lVar3 == null) break;
                  lVar3 = HeroData.GetForce(lVar3,0,0);
                  if (lVar3 == null) break;
                  ForceData.GetOwnHero(lVar3,iVar7,0);
                  if (lVar2 == null) break;
                  cVar1 = FUN_18181ea10(lVar2);
                  if (!cVar1) {
                    lVar3 = FUN_18046c0a0(0);
                    if ((lVar3 == null) || (lVar3.villageAreaID == null)) break;
                    lVar3 = WorldData.Player(lVar3.villageAreaID,0);
                    if (lVar3 == null) break;
                    lVar3 = HeroData.GetForce(lVar3,0);
                    if (lVar3 == null) break;
                    lVar3 = ForceData.GetOwnHero(lVar3);
                    if (lVar3 == null) break;
                    if (!lVar3.BigMapRandomEventDatas) {
                      lVar3 = FUN_18046c0a0(0);
                      if ((lVar3 == null) || (lVar3.villageAreaID == null)) break;
                      lVar3 = WorldData.Player(lVar3.villageAreaID,0);
                      if (lVar3 == null) break;
                      lVar3 = HeroData.GetForce(lVar3,0);
                      if (lVar3 == null) break;
                      lVar3 = ForceData.GetOwnHero(lVar3);
                      if (lVar3 == null) break;
                      if (*(char *)(lVar3 + 209) == false) {
                        lVar3 = FUN_18046c0a0(0);
                        if ((lVar3 == null) || (lVar3.villageAreaID == null)) break;
                        lVar3 = WorldData.Player(lVar3.villageAreaID,0);
                        if (lVar3 == null) break;
                        lVar3 = HeroData.GetForce(lVar3,0);
                        if (lVar3 == null) break;
                        lVar3 = ForceData.GetOwnHero(lVar3);
                        if (lVar3 == null) break;
                        if (*(char *)(lVar3 + 0x370) == false) {
                          lVar3 = FUN_18046c0a0(0);
                          if ((lVar3 == null) || (lVar3.villageAreaID == null)) break;
                          lVar3 = WorldData.Player(lVar3.villageAreaID,0);
                          if (lVar3 == null) break;
                          lVar3 = HeroData.GetForce(lVar3,0,0);
                          if (lVar3 == null) break;
                          ForceData.GetOwnHero(lVar3,iVar7,0);
                          FUN_18181e6b0(lVar2);
                        }
                      }
                    }
                  }
                  iVar7 = iVar7 + 1;
                }
                throw; // [null/range check failed]
              }
            }
        LAB_180c8769a:
            lVar3 = **(int64 **)(DAT_181db7530 + 184);
            uVar4 = Component.get_gameObject(this,0);
            if (buttonClick != null) {
              lVar5 = GameObject.get_transform(buttonClick,0);
              if (lVar5 != null) {
                lVar5 = FUN_180daa030(lVar5,0);
                if (lVar5 != null) {
                  lVar5 = FUN_180daa030(lVar5,0);
                  if (lVar5 != null) {
                    uVar6 = Object.get_name(lVar5,0);
                    if (lVar3 != null) {
                      ChooseController.ShowChoosePanel(lVar3,2,lVar2,uVar4,"BookWriterTargetHeroChoosen",uVar6,0,0,0);
                      return;
                    }
                  }
                }
              }
            }
          }
        }
    }

    // Token : 0x6000D67
    // RVA   : 0xC867D0   Offset: 0xC85BD0   Length: 0x137
    public void BookWriterTargetHeroChoosen(string writerID)
    {
        var pStatics = *(int64*)(DAT_181db7530 + 184);
        long lVar1;
        uint uVar2;
        long lVar3;
        lVar1 = this.targetBookWriterList;
        uVar2 = Int32.Parse(writerID,0);
        if (lVar1 != null) {
          if (lVar1.Count <= uVar2) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          lVar1 = lVar1._items[uVar2];
          if (lVar1 != null) {
            if (lVar1.Count != -1) {
              return;
            }
            lVar1 = this.targetBookWriterList;
            uVar2 = Int32.Parse(writerID,0);
            if (lVar1 != null) {
              if (lVar1.Count <= uVar2) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              lVar1 = lVar1._items[uVar2];
              if ((((*pStatics != 0) &&
                   (lVar3 = *(int64 *)(*pStatics + 72)) != null) &&
                  (lVar3 = GameObject.GetComponent(lVar3,DAT_181d71b50)) != null) &&
                 ((*(int64 *)(lVar3 + 32) != 0 && (lVar1 != null)))) {
                lVar1.Count = *(uint32 *)(*(int64 *)(lVar3 + 32) + 88);
                BookWriterUIController.RefreshUI(this,0);
                return;
              }
            }
          }
        }
    }

    // Token : 0x6000D68
    // RVA   : 0xC87E20   Offset: 0xC87220   Length: 0x12B
    public void ClearChoosenHero(GameObject buttonClick)
    {
        long lVar1;
        uint uVar2;
        lVar1 = this.targetBookWriterList;
        uVar2 = Int32.Parse(buttonClick,0);
        if (lVar1 != null) {
          if (lVar1.Count <= uVar2) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          lVar1 = lVar1._items[uVar2];
          if (lVar1 != null) {
            lVar1.Count = 0xffffffff;
            lVar1 = this.targetBookWriterList;
            uVar2 = Int32.Parse(buttonClick,0);
            if (lVar1 != null) {
              if (lVar1.Count <= uVar2) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              lVar1 = lVar1._items[uVar2];
              if (lVar1 != null) {
                if (*(int *)(lVar1 + 20) == 2) {
                  BookWriterUIController.ClearChoosenBook(this,buttonClick,0,0);
                }
                if (param_3) {
                  BookWriterUIController.RefreshUI(this,0);
                }
                return;
              }
            }
          }
        }
    }

    // Token : 0x6000D69
    // RVA   : 0xC87F50   Offset: 0xC87350   Length: 0xF1
    public void ClearChoosenHero(string writerID, bool refresh)
    {
        long lVar1;
        uint uVar2;
        lVar1 = this.targetBookWriterList;
        uVar2 = Int32.Parse(writerID,0);
        if (lVar1 != null) {
          if (lVar1.Count <= uVar2) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          lVar1 = lVar1._items[uVar2];
          if (lVar1 != null) {
            lVar1.Count = 0xffffffff;
            lVar1 = this.targetBookWriterList;
            uVar2 = Int32.Parse(writerID,0);
            if (lVar1 != null) {
              if (lVar1.Count <= uVar2) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              lVar1 = lVar1._items[uVar2];
              if (lVar1 != null) {
                if (*(int *)(lVar1 + 20) == 2) {
                  BookWriterUIController.ClearChoosenBook(this,writerID,0,0);
                }
                if (refresh) {
                  BookWriterUIController.RefreshUI(this,0);
                }
                return;
              }
            }
          }
        }
    }

    // Token : 0x6000D6A
    // RVA   : 0xC86BD0   Offset: 0xC85FD0   Length: 0x5DF
    public void ChooseBookButtonClicked(GameObject buttonClick)
    {
        var pStatics = *(int64*)(DAT_181db7530 + 184);
        int iVar1;
        uint uVar2;
        uint uVar3;
        long lVar4;
        ulong uVar5;
        long lVar6;
        long lVar7;
        ulong uVar8;
        ulong uVar10;
        uint[] local_res10 = new uint[2];
        uint[] local_res20 = new uint[2];
        if ((((buttonClick == null) || (lVar4 = GameObject.get_transform(buttonClick,0)) == null) ||
            (lVar4 = FUN_180daa030(lVar4,0)) == null) ||
           ((lVar4 = FUN_180daa030(lVar4,0), lVar4 == null || (lVar4 = FUN_180daa030(lVar4,0)) == null)))
        {
        LAB_180c87198:
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
        uVar5 = Object.get_name(lVar4,0);
        lVar4 = this.targetBookWriterList;
        uVar2 = Int32.Parse(uVar5,0);
        if (lVar4 == null) goto LAB_180c87198;
        if (lVar4.Count <= uVar2) {
          ThrowHelper.ThrowArgumentOutOfRangeException(0);
        }
        lVar4 = lVar4._items[uVar2];
        if (lVar4 == null) goto LAB_180c87198;
        iVar1 = *(int *)(lVar4 + 20);
        if (iVar1 == 0) {
          lVar4 = this.targetBookWriterList;
          uVar2 = Int32.Parse(uVar5,0);
          if (lVar4 == null) goto LAB_180c87198;
          if (lVar4.Count <= uVar2) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          lVar4 = lVar4._items[uVar2];
          if (lVar4 == null) goto LAB_180c87198;
          if (*(int64 *)(lVar4 + 32) != 0) {
            return;
          }
          lVar4 = *pStatics;
          lVar6 = il2cpp_internal(DAT_181d94e68);
          FUN_181330100(lVar6,DAT_181d957a0);
          local_res10[0] = 0;
          uVar8 = il2cpp_value_box(DAT_181d80430,local_res10);
          if (lVar6 == null) {
        LAB_180c871aa:
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          FUN_18181e6b0(lVar6,uVar8,DAT_181d958a0);
          local_res20[0] = 3;
          uVar8 = il2cpp_value_box(DAT_181d80430,local_res20);
          FUN_18181e6b0(lVar6,uVar8,DAT_181d958a0);
          uVar8 = Component.get_gameObject(this,0);
          if (lVar4 == null) goto LAB_180c871aa;
          uVar3 = 6;
        }
        else {
          if (iVar1 != 1) {
            if (iVar1 != 2) {
              return;
            }
            lVar4 = this.targetBookWriterList;
            uVar2 = Int32.Parse(uVar5,0);
            if (lVar4 == null) goto LAB_180c87198;
            if (lVar4.Count <= uVar2) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            lVar4 = lVar4._items[uVar2];
            if (lVar4 == null) goto LAB_180c87198;
            if (*(int64 *)(lVar4 + 48) != 0) {
              return;
            }
            lVar4 = this.targetBookWriterList;
            uVar2 = Int32.Parse(uVar5,0);
            if (lVar4 == null) goto LAB_180c87198;
            if (lVar4.Count <= uVar2) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            lVar4 = lVar4._items[uVar2];
            if (lVar4 == null) goto LAB_180c87198;
            lVar4 = BookWriterData.GetBookWriterHero(lVar4,0);
            if (lVar4 == null) {
              lVar4 = FUN_18046c0a0(0);
              if (lVar4 != null) {
                GameController.ShowTextOnMouse(lVar4,"需先选择编纂角色",0);
                plVar9 = (int64 *)Resources.Load("Sound/SoundEffect/WrongClick",0);
                plVar11 = (int64 *)0;
                if ((plVar9 != (int64 *)0) && (*plVar9 == DAT_181daf360)) {
                  plVar11 = plVar9;
                }
                NGUITools.PlaySound(plVar11,0);
                return;
              }
              goto LAB_180c87198;
            }
            lVar4 = FUN_18046bd60(0);
            lVar6 = il2cpp_internal(DAT_181d94e68);
            FUN_181330100(lVar6,DAT_181d957a0);
            lVar7 = this.targetBookWriterList;
            uVar3 = Int32.Parse(uVar5,0);
            if ((lVar7 == null) || (lVar7 = FUN_180002f80(lVar7,uVar3,DAT_181d80438)) == null) {
        LAB_180c8719e:
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            local_res10[0] = lVar7.Count;
            uVar8 = il2cpp_value_box(DAT_181d80430,local_res10);
            if (lVar6 == null) goto LAB_180c8719e;
            FUN_18181e6b0(lVar6,uVar8,DAT_181d958a0);
            uVar8 = Component.get_gameObject(this,0);
            if (lVar4 == null) goto LAB_180c8719e;
            uVar10 = 0;
            uVar3 = 0;
            goto LAB_180c87059;
          }
          lVar4 = this.targetBookWriterList;
          uVar2 = Int32.Parse(uVar5,0);
          if (lVar4 == null) goto LAB_180c87198;
          if (lVar4.Count <= uVar2) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          lVar4 = lVar4._items[uVar2];
          if (lVar4 == null) goto LAB_180c87198;
          if (*(int64 *)(lVar4 + 32) != 0) {
            return;
          }
          lVar4 = *pStatics;
          lVar6 = il2cpp_internal(DAT_181d94e68);
          FUN_181330100(lVar6,DAT_181d957a0);
          local_res10[0] = 0;
          uVar8 = il2cpp_value_box(DAT_181d80430,local_res10);
          if (lVar6 == null) {
        LAB_180c871a4:
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          FUN_18181e6b0(lVar6,uVar8,DAT_181d958a0);
          local_res20[0] = 3;
          uVar8 = il2cpp_value_box(DAT_181d80430,local_res20);
          FUN_18181e6b0(lVar6,uVar8,DAT_181d958a0);
          uVar8 = Component.get_gameObject(this,0);
          if (lVar4 == null) goto LAB_180c871a4;
          uVar3 = 25;
        }
        uVar10 = 1;
        LAB_180c87059:
        ChooseController.ShowChoosePanel(lVar4,uVar10,lVar6,uVar8,"BookWriterTargetBookChoosen",uVar5,uVar3,0,0,0);
    }

    // Token : 0x6000D6B
    // RVA   : 0xC86440   Offset: 0xC85840   Length: 0x388
    public void BookWriterTargetBookChoosen(string writerID)
    {
        var pStatics = *(int64*)(DAT_181db7530 + 184);
        int iVar1;
        long lVar2;
        uint uVar3;
        long lVar4;
        long lVar5;
        ulong uVar6;
        lVar2 = this.targetBookWriterList;
        uVar3 = Int32.Parse(writerID,0);
        if (lVar2 == null) {
        LAB_180c867c3:
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
        if (lVar2.Count <= uVar3) {
          ThrowHelper.ThrowArgumentOutOfRangeException(0);
        }
        lVar2 = lVar2._items[uVar3];
        if (lVar2 == null) goto LAB_180c867c3;
        iVar1 = *(int *)(lVar2 + 20);
        if (iVar1 == 0) {
          lVar2 = this.targetBookWriterList;
          uVar3 = Int32.Parse(writerID,0);
          if (lVar2 == null) goto LAB_180c867c3;
          if (lVar2.Count <= uVar3) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          lVar2 = lVar2._items[uVar3];
          if ((*pStatics == 0) ||
             (lVar4 = *(int64 *)(*pStatics + 72)) == null)
          goto LAB_180c867c3;
          lVar4 = GameObject.GetComponent(lVar4,DAT_181d720a0);
          if ((lVar4 == null) || (lVar2 == null)) goto LAB_180c867c3;
          *(uint64 *)(lVar2 + 32) = *(uint64 *)(lVar4 + 32);
          lVar2 = this.targetBookWriterList;
          uVar3 = Int32.Parse(writerID,0);
          if (lVar2 == null) goto LAB_180c867c3;
          if (lVar2.Count <= uVar3) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          lVar2 = lVar2._items[uVar3];
          lVar4 = FUN_18046c0a0(0);
          if ((lVar4 == null) || (*(int64 *)(lVar4 + 32) == 0)) goto LAB_180c867c3;
          lVar5 = WorldData.Player(*(int64 *)(lVar4 + 32),0);
          lVar4 = this.targetBookWriterList;
          uVar3 = Int32.Parse(writerID,0);
          if (lVar4 == null) goto LAB_180c867c3;
          if (lVar4.Count <= uVar3) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          lVar4 = lVar4._items[uVar3];
          if ((lVar4 == null) || (lVar5 == null)) goto LAB_180c867c3;
          uVar6 = HeroData.FindSameBook(lVar5,*(uint64 *)(lVar4 + 32),0);
          if (lVar2 == null) goto LAB_180c867c3;
          puVar7 = (uint64 *)(lVar2 + 40);
          *puVar7 = uVar6;
        }
        else if (iVar1 == 1) {
          lVar2 = this.targetBookWriterList;
          uVar3 = Int32.Parse(writerID,0);
          if (lVar2 == null) goto LAB_180c867c3;
          if (lVar2.Count <= uVar3) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          lVar2 = lVar2._items[uVar3];
          if ((*pStatics == 0) ||
             (lVar4 = *(int64 *)(*pStatics + 72)) == null)
          goto LAB_180c867c3;
          lVar4 = GameObject.GetComponent(lVar4,DAT_181d720a0);
          if ((lVar4 == null) || (uVar6 = *(uint64 *)(lVar4 + 32), lVar2 == null)) goto LAB_180c867c3;
          puVar7 = (uint64 *)(lVar2 + 32);
          *puVar7 = uVar6;
        }
        else {
          if (iVar1 != 2) goto LAB_180c867a0;
          lVar2 = this.targetBookWriterList;
          uVar3 = Int32.Parse(writerID,0);
          if (lVar2 == null) goto LAB_180c867c3;
          if (lVar2.Count <= uVar3) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          lVar2 = lVar2._items[uVar3];
          if ((*pStatics == 0) ||
             (lVar4 = *(int64 *)(*pStatics + 72)) == null)
          goto LAB_180c867c3;
          lVar4 = GameObject.GetComponent(lVar4,DAT_181d73800);
          if ((lVar4 == null) || (uVar6 = *(uint64 *)(lVar4 + 32), lVar2 == null)) goto LAB_180c867c3;
          puVar7 = (uint64 *)(lVar2 + 48);
          *puVar7 = uVar6;
        }
        il2cpp_internal(puVar7,uVar6);
        LAB_180c867a0:
        BookWriterUIController.RefreshUI(this,0);
    }

    // Token : 0x6000D6C
    // RVA   : 0xC87DB0   Offset: 0xC871B0   Length: 0x63
    public void ClearChoosenBook(GameObject buttonClick)
    {
        long lVar1;
        uint uVar2;
        lVar1 = this.targetBookWriterList;
        uVar2 = Int32.Parse(buttonClick,0);
        if (lVar1 != null) {
          if (lVar1.Count <= uVar2) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          lVar1 = lVar1._items[uVar2];
          if (lVar1 != null) {
            puVar3 = (uint64 *)(lVar1 + 32);
            *puVar3 = 0;
            il2cpp_internal(puVar3,0);
            lVar1 = this.targetBookWriterList;
            uVar2 = Int32.Parse(buttonClick,0);
            if (lVar1 != null) {
              if (lVar1.Count <= uVar2) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              lVar1 = lVar1._items[uVar2];
              if (lVar1 != null) {
                puVar3 = (uint64 *)(lVar1 + 40);
                *puVar3 = 0;
                il2cpp_internal(puVar3,0);
                lVar1 = this.targetBookWriterList;
                uVar2 = Int32.Parse(buttonClick,0);
                if (lVar1 != null) {
                  if (lVar1.Count <= uVar2) {
                    ThrowHelper.ThrowArgumentOutOfRangeException(0);
                  }
                  lVar1 = lVar1._items[uVar2];
                  if (lVar1 != null) {
                    puVar3 = (uint64 *)(lVar1 + 48);
                    *puVar3 = 0;
                    il2cpp_internal(puVar3,0);
                    if (param_3) {
                      BookWriterUIController.RefreshUI(this,0);
                    }
                    return;
                  }
                }
              }
            }
          }
        }
    }

    // Token : 0x6000D6D
    // RVA   : 0xC87C60   Offset: 0xC87060   Length: 0x141
    public void ClearChoosenBook(string writerID, bool refresh)
    {
        long lVar1;
        uint uVar2;
        lVar1 = this.targetBookWriterList;
        uVar2 = Int32.Parse(writerID,0);
        if (lVar1 != null) {
          if (lVar1.Count <= uVar2) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          lVar1 = lVar1._items[uVar2];
          if (lVar1 != null) {
            puVar3 = (uint64 *)(lVar1 + 32);
            *puVar3 = 0;
            il2cpp_internal(puVar3,0);
            lVar1 = this.targetBookWriterList;
            uVar2 = Int32.Parse(writerID,0);
            if (lVar1 != null) {
              if (lVar1.Count <= uVar2) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              lVar1 = lVar1._items[uVar2];
              if (lVar1 != null) {
                puVar3 = (uint64 *)(lVar1 + 40);
                *puVar3 = 0;
                il2cpp_internal(puVar3,0);
                lVar1 = this.targetBookWriterList;
                uVar2 = Int32.Parse(writerID,0);
                if (lVar1 != null) {
                  if (lVar1.Count <= uVar2) {
                    ThrowHelper.ThrowArgumentOutOfRangeException(0);
                  }
                  lVar1 = lVar1._items[uVar2];
                  if (lVar1 != null) {
                    puVar3 = (uint64 *)(lVar1 + 48);
                    *puVar3 = 0;
                    il2cpp_internal(puVar3,0);
                    if (refresh) {
                      BookWriterUIController.RefreshUI(this,0);
                    }
                    return;
                  }
                }
              }
            }
          }
        }
    }

    // Token : 0x6000D6E
    // RVA   : 0xC8A6A0   Offset: 0xC89AA0   Length: 0x9FF
    public void SureButtonClicked(GameObject buttonClick)
    {
        bool cVar1;
        uint uVar2;
        int iVar3;
        long lVar4;
        ulong uVar5;
        long lVar6;
        if ((((buttonClick != null) && (lVar4 = GameObject.get_transform(buttonClick,0)) != null) &&
            (lVar4 = FUN_180daa030(lVar4,0)) != null) && (lVar4 = FUN_180daa030(lVar4,0)) != null)
        {
          uVar5 = Object.get_name(lVar4,0);
          lVar4 = this.targetBookWriterList;
          uVar2 = Int32.Parse(uVar5,0);
          if (lVar4 != null) {
            if (lVar4.Count <= uVar2) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            lVar4 = lVar4._items[uVar2];
            if (lVar4 != null) {
              lVar6 = this.targetBookWriterList;
              if (!lVar4.Inns) {
                uVar2 = Int32.Parse(uVar5,0);
                if (lVar6 != null) {
                  if (lVar6.Count <= uVar2) {
                    ThrowHelper.ThrowArgumentOutOfRangeException(0);
                  }
                  lVar4 = lVar6._items[uVar2];
                  if (lVar4 != null) {
                    if (lVar4.villageAreaID != null) {
                      lVar4 = FUN_18046c0a0(0);
                      if ((((lVar4 == null) || (lVar4.villageAreaID == null)) ||
                          (lVar4 = WorldData.Player(lVar4.villageAreaID,0)) == null) ||
                         (lVar4.speBookStorageSpeAdd == null)) throw; // [null/range check failed]
                      lVar4 = *(int64 *)(lVar4.speBookStorageSpeAdd + 40);
                      lVar6 = this.targetBookWriterList;
                      uVar2 = Int32.Parse(uVar5,0);
                      if (lVar6 == null) throw; // [null/range check failed]
                      if (lVar6.Count <= uVar2) {
                        ThrowHelper.ThrowArgumentOutOfRangeException(0);
                      }
                      lVar6 = lVar6._items[uVar2]
                      ;
                      if ((lVar6 == null) || (lVar4 == null)) throw; // [null/range check failed]
                      cVar1 = FUN_18181ea10(lVar4,*(uint64 *)(lVar6 + 32),DAT_181d90bb0);
                      if (!cVar1) {
                        lVar4 = FUN_18046c0a0(0);
                        if (((lVar4 == null) || (lVar4.villageAreaID == null)) ||
                           (lVar4 = WorldData.Player(lVar4.villageAreaID,0)) == null)
                        throw; // [null/range check failed]
                        lVar4 = lVar4.speSummonResearchData;
                        lVar6 = this.targetBookWriterList;
                        uVar2 = Int32.Parse(uVar5,0);
                        if (lVar6 == null) throw; // [null/range check failed]
                        if (lVar6.Count <= uVar2) {
                          ThrowHelper.ThrowArgumentOutOfRangeException(0);
                        }
                        lVar6 = *(int64 *)
                                 (lVar6._items + 32 + (int64)(int)uVar2 * 8);
                        if ((lVar6 == null) || (lVar4 == null)) throw; // [null/range check failed]
                        ItemListData.LoseItem(lVar4,*(uint64 *)(lVar6 + 32),1,0);
                      }
                      else {
                        lVar4 = FUN_18046c0a0(0);
                        if ((lVar4 == null) || (lVar4.villageAreaID == null)) throw; // [null/range check failed]
                        lVar6 = WorldData.Player(lVar4.villageAreaID,0);
                        lVar4 = this.targetBookWriterList;
                        uVar2 = Int32.Parse(uVar5,0);
                        if (lVar4 == null) throw; // [null/range check failed]
                        if (lVar4.Count <= uVar2) {
                          ThrowHelper.ThrowArgumentOutOfRangeException(0);
                        }
                        lVar4 = *(int64 *)
                                 (lVar4._items + 32 + (int64)(int)uVar2 * 8);
                        if ((lVar4 == null) || (lVar6 == null)) throw; // [null/range check failed]
                        HeroData.LoseItem(lVar6,lVar4.villageAreaID,1,0);
                      }
                    }
                    lVar4 = this.targetBookWriterList;
                    uVar2 = Int32.Parse(uVar5,0);
                    if (lVar4 != null) {
                      if (lVar4.Count <= uVar2) {
                        ThrowHelper.ThrowArgumentOutOfRangeException(0);
                      }
                      lVar4 = lVar4._items[uVar2]
                      ;
                      if (lVar4 != null) {
                        if (lVar4.forceAreaID != null) {
                          lVar4 = FUN_18046c0a0(0);
                          if ((((lVar4 == null) || (lVar4.villageAreaID == null)) ||
                              (lVar4 = WorldData.Player(lVar4.villageAreaID,0)) == null) ||
                             (lVar4.speBookStorageSpeAdd == null)) throw; // [null/range check failed]
                          lVar4 = *(int64 *)(lVar4.speBookStorageSpeAdd + 40);
                          lVar6 = this.targetBookWriterList;
                          uVar2 = Int32.Parse(uVar5,0);
                          if (lVar6 == null) throw; // [null/range check failed]
                          if (lVar6.Count <= uVar2) {
                            ThrowHelper.ThrowArgumentOutOfRangeException(0);
                          }
                          lVar6 = *(int64 *)
                                   (lVar6._items + 32 + (int64)(int)uVar2 * 8);
                          if ((lVar6 == null) || (lVar4 == null)) throw; // [null/range check failed]
                          cVar1 = FUN_18181ea10(lVar4,*(uint64 *)(lVar6 + 40),DAT_181d90bb0);
                          if (!cVar1) {
                            lVar4 = FUN_18046c0a0(0);
                            if (((lVar4 == null) || (lVar4.villageAreaID == null)) ||
                               (lVar4 = WorldData.Player(lVar4.villageAreaID,0)) == null)
                            throw; // [null/range check failed]
                            lVar4 = lVar4.speSummonResearchData;
                            lVar6 = this.targetBookWriterList;
                            uVar2 = Int32.Parse(uVar5,0);
                            if (lVar6 == null) throw; // [null/range check failed]
                            if (lVar6.Count <= uVar2) {
                              ThrowHelper.ThrowArgumentOutOfRangeException(0);
                            }
                            lVar6 = *(int64 *)
                                     (lVar6._items + 32 + (int64)(int)uVar2 * 8);
                            if ((lVar6 == null) || (lVar4 == null)) throw; // [null/range check failed]
                            ItemListData.LoseItem(lVar4,*(uint64 *)(lVar6 + 40),1,0);
                          }
                          else {
                            lVar4 = FUN_18046c0a0(0);
                            if ((lVar4 == null) || (lVar4.villageAreaID == null)) throw; // [null/range check failed]
                            lVar6 = WorldData.Player(lVar4.villageAreaID,0);
                            lVar4 = this.targetBookWriterList;
                            uVar2 = Int32.Parse(uVar5,0);
                            if (lVar4 == null) throw; // [null/range check failed]
                            if (lVar4.Count <= uVar2) {
                              ThrowHelper.ThrowArgumentOutOfRangeException(0);
                            }
                            lVar4 = *(int64 *)
                                     (lVar4._items + 32 + (int64)(int)uVar2 * 8);
                            if ((lVar4 == null) || (lVar6 == null)) throw; // [null/range check failed]
                            HeroData.LoseItem(lVar6,lVar4.forceAreaID,1,0);
                          }
                        }
                        if ((GameController._instance != null) &&
                           (lVar4 = GameController._instance.worldData,
                           lVar4 != null)) {
                          lVar6 = WorldData.Player(lVar4,0);
                          lVar4 = this.targetBookWriterList;
                          uVar2 = Int32.Parse(uVar5,0);
                          if (lVar4 != null) {
                            if (lVar4.Count <= uVar2) {
                              ThrowHelper.ThrowArgumentOutOfRangeException(0);
                            }
                            lVar4 = *(int64 *)
                                     (lVar4._items + 32 + (int64)(int)uVar2 * 8);
                            if ((lVar4 != null) &&
                               (iVar3 = BookWriterData.GetMoneyCost(lVar4,0), lVar6 != null)) {
                              HeroData.ChangeMoney(lVar6,-iVar3,1,0);
                              lVar4 = this.targetBookWriterList;
                              uVar2 = Int32.Parse(uVar5,0);
                              if (lVar4 != null) {
                                if (lVar4.Count <= uVar2) {
                                  ThrowHelper.ThrowArgumentOutOfRangeException(0);
                                }
                                lVar4 = *(int64 *)
                                         (lVar4._items + 32 + (int64)(int)uVar2 * 8);
                                if ((lVar4 != null) &&
                                   (lVar4 = BookWriterData.GetBookWriterHero(lVar4,0)) != null) {
                                  *(uint8 *)(lVar4 + 0x370) = 1;
                                  lVar4 = this.targetBookWriterList;
                                  uVar2 = Int32.Parse(uVar5,0);
                                  if (lVar4 != null) {
                                    if (lVar4.Count <= uVar2) {
                                      ThrowHelper.ThrowArgumentOutOfRangeException(0);
                                    }
                                    lVar4 = *(int64 *)
                                             (lVar4._items + 32 +
                                             (int64)(int)uVar2 * 8);
                                    if (lVar4 != null) {
                                      lVar4.Inns = 1;
                                      plVar7 = (int64 *)Resources.Load("Sound/SoundEffect/PencilWriting",0);
                                      goto LAB_180c8b059;
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
              else {
                uVar2 = Int32.Parse(uVar5,0);
                if (lVar6 != null) {
                  if (lVar6.Count <= uVar2) {
                    ThrowHelper.ThrowArgumentOutOfRangeException(0);
                  }
                  lVar4 = lVar6._items[uVar2];
                  if (lVar4 != null) {
                    if (lVar4.villageAreaID != null) {
                      lVar4 = FUN_18046c0a0(0);
                      if ((lVar4 == null) || (lVar4.villageAreaID == null)) throw; // [null/range check failed]
                      lVar6 = WorldData.Player(lVar4.villageAreaID,0);
                      lVar4 = this.targetBookWriterList;
                      uVar2 = Int32.Parse(uVar5,0);
                      if (lVar4 == null) throw; // [null/range check failed]
                      if (lVar4.Count <= uVar2) {
                        ThrowHelper.ThrowArgumentOutOfRangeException(0);
                      }
                      lVar4 = lVar4._items[uVar2]
                      ;
                      if ((lVar4 == null) || (lVar6 == null)) throw; // [null/range check failed]
                      HeroData.GetItem(lVar6,lVar4.villageAreaID,1,0,0xffffffff,0,0);
                    }
                    lVar4 = this.targetBookWriterList;
                    uVar2 = Int32.Parse(uVar5,0);
                    if (lVar4 != null) {
                      if (lVar4.Count <= uVar2) {
                        ThrowHelper.ThrowArgumentOutOfRangeException(0);
                      }
                      lVar4 = lVar4._items[uVar2]
                      ;
                      if (lVar4 != null) {
                        if (lVar4.forceAreaID != null) {
                          lVar4 = FUN_18046c0a0(0);
                          if ((lVar4 == null) || (lVar4.villageAreaID == null)) throw; // [null/range check failed]
                          lVar6 = WorldData.Player(lVar4.villageAreaID,0);
                          lVar4 = this.targetBookWriterList;
                          uVar2 = Int32.Parse(uVar5,0);
                          if (lVar4 == null) throw; // [null/range check failed]
                          if (lVar4.Count <= uVar2) {
                            ThrowHelper.ThrowArgumentOutOfRangeException(0);
                          }
                          lVar4 = *(int64 *)
                                   (lVar4._items + 32 + (int64)(int)uVar2 * 8);
                          if ((lVar4 == null) || (lVar6 == null)) throw; // [null/range check failed]
                          HeroData.GetItem(lVar6,lVar4.forceAreaID,1,0,0xffffffff,0,0);
                        }
                        lVar4 = this.targetBookWriterList;
                        uVar2 = Int32.Parse(uVar5,0);
                        if (lVar4 == null) throw; // [null/range check failed]
                        if (lVar4.Count <= uVar2) {
                          ThrowHelper.ThrowArgumentOutOfRangeException(0);
                        }
                        lVar4 = *(int64 *)
                                 (lVar4._items + 32 + (int64)(int)uVar2 * 8);
                        if (lVar4 == null) throw; // [null/range check failed]
                        if (lVar4.Count != -1) {
                          lVar6 = BookWriterData.GetBookWriterHero(lVar4,0);
                          if (lVar6 == null) throw; // [null/range check failed]
                          *(uint8 *)(lVar6 + 0x370) = 0;
                        }
                        lVar4.villageAreaID = 0;
                        lVar4.Count = 0xffffffff;
                        lVar4.Areas = 0;
                        lVar4.Inns = 0;
                        *(uint32 *)(lVar4 + 60) = 0;
                        plVar7 = (int64 *)Resources.Load("Sound/SoundEffect/WrongClick",0);
        LAB_180c8b059:
                        plVar8 = (int64 *)0;
                        if ((plVar7 != (int64 *)0) && (*plVar7 == DAT_181daf360)) {
                          plVar8 = plVar7;
                        }
                        NGUITools.PlaySound(plVar8,0);
                        BookWriterUIController.RefreshUI(this,0);
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

    // Token : 0x6000D6F
    // RVA   : 0xC87B80   Offset: 0xC86F80   Length: 0xD5
    public void ClearAll()
    {
        long lVar1;
        long lVar2;
        uint uVar3;
        lVar1 = this.targetBookWriterList;
        uVar3 = 0;
        if (lVar1 != null) {
          lVar2 = 32;
          while( true ) {
            if (lVar1.Count <= (int)uVar3) {
              return;
            }
            if (lVar1 == null) break;
            if (lVar1.Count <= uVar3) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            lVar1 = *(int64 *)(lVar2 + lVar1._items);
            if (lVar1 == null) break;
            if (*(char *)(lVar1 + 56) == false) {
              if ((this.targetBookWriterList == null) ||
                 (lVar1 = FUN_180002f80(this.targetBookWriterList,uVar3,DAT_181d80438)) == null)
              break;
              BookWriterData.Reset(lVar1,0);
            }
            lVar1 = this.targetBookWriterList;
            uVar3 = uVar3 + 1;
            lVar2 = lVar2 + 8;
            if (lVar1 == null) break;
          }
        }
    }

    // Token : 0x6000D70
    // RVA   : 0xC880F0   Offset: 0xC874F0   Length: 0xEC
    public void HideBookWriterUI()
    {
        long lVar1;
        uint uVar2;
        long lVar3;
        lVar1 = this.targetBookWriterList;
        uVar2 = 0;
        if (lVar1 != null) {
          lVar3 = 32;
          while ((int)uVar2 < lVar1.Count) {
            if (lVar1 == null) throw; // [null/range check failed]
            if (lVar1.Count <= uVar2) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            lVar1 = *(int64 *)(lVar3 + lVar1._items);
            if (lVar1 == null) throw; // [null/range check failed]
            if (*(char *)(lVar1 + 56) == false) {
              if ((this.targetBookWriterList == null) || (lVar1 = FUN_180002f80()) == null)
              throw; // [null/range check failed]
              BookWriterData.Reset(lVar1);
            }
            lVar1 = this.targetBookWriterList;
            uVar2 = uVar2 + 1;
            lVar3 = lVar3 + 8;
            if (lVar1 == null) throw; // [null/range check failed]
          }
          if (this.bookWriterUI != null) {
            GameObject.SetActive(this.bookWriterUI,0,0);
            return;
          }
        }
    }

    // Token : 0x6000D71
    // RVA   : 0xC8A630   Offset: 0xC89A30   Length: 0x6E
    public void ShowBookWriterUI(List<BookWriterData> _bookWriterList, ForceData _targetForce)
    {
        void BookWriterUIController.ShowBookWriterUI
                     (int64 this,uint64 _bookWriterList,uint64 _targetForce)
        {
        if (this.bookWriterUI != null) {
          GameObject.SetActive(this.bookWriterUI,1,0);
          this.targetBookWriterList = _bookWriterList;
          this.targetForce = _targetForce;
          this.activeID = 0;
          BookWriterUIController.RefreshUI(this,0);
          return;
        }
    }

    // Token : 0x6000D72
    // RVA   : 0x3A17B0   Offset: 0x3A0BB0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_18044ef50(this,0);
    }

    // Token : 0x6000D73
    // RVA   : 0xC8B0A0   Offset: 0xC8A4A0   Length: 0x39
    private static void /*cctor*/()
    {
        **(uint32 **)(DAT_181db29d0 + 184) = 4;
    }

}
