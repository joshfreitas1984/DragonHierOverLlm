// ============================================================
// Type  : BookWriterUIController
// Token : 0x20001A3
// ============================================================

public class BookWriterUIController
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4000B7D
    public ForceData targetForce;

    // Token: 0x4000B7E
    public List<BookWriterData> targetBookWriterList;

    // Token: 0x4000B7F
    public GameObject bookWriterUI;

    // Token: 0x4000B80
    public int activeID;

    // Token: 0x4000B81
    private static readonly int MaxBookWriterNum;

    // Token: 0x4000B82
    private GameObject temp;

    // Token: 0x4000B83
    private static BookWriterUIController _instance;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000D62
    // RVA   : 0x9F3D50   Offset: 0x9F2B50   Length: 0x58
    public static BookWriterUIController get_Instance()
    {
        return *(uint64 *)(*(int64 *)(DAT_181e92c98 + 184) + 8);
    }

    // Token : 0x6000D63
    // RVA   : 0x9EED40   Offset: 0x9EDB40   Length: 0x68
    private void Awake()
    {
        puVar1 = (uint64 *)(*(int64 *)(DAT_181e92c98 + 184) + 8);
        *puVar1 = this;
        il2cpp_internal(puVar1,this);
    }

    // Token : 0x6000D64
    // RVA   : 0x9EF7B0   Offset: 0x9EE5B0   Length: 0x8D
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

    // Token : 0x6000D65
    // RVA   : 0x9F0CC0   Offset: 0x9EFAC0   Length: 0x9F
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

    // Token : 0x6000D66
    // RVA   : 0x9F0E50   Offset: 0x9EFC50   Length: 0x244E
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
        LAB_1809f1150:
        if (**(int **)(DAT_181e92c98 + 184) <= iVar14) {
          if ((((this.bookWriterUI != null) &&
               (lVar7 = GameObject.get_transform(this.bookWriterUI,0)) != null) &&
              (lVar7 = Transform.Find(lVar7,"BookWriterGrid",0)) != null) &&
             (lVar7 = Component.GetComponent(lVar7,DAT_181e79d38)) != null) {
            UIGrid.set_repositionNow(lVar7,1,0);
            return;
          }
          goto LAB_1809f328d;
        }
        if (this.targetBookWriterList == null) goto LAB_1809f3299;
        if (iVar14 < this.targetBookWriterList.Count) {
          lVar7 = BookWriterUIController.GetWriterRoot(this);
          if ((lVar7 == null) || (lVar7 = FUN_180b05920(lVar7,0)) == null) goto LAB_1809f3299;
          lVar7 = Component.get_gameObject(lVar7,0);
          if (lVar7 == null) goto LAB_1809f3299;
          GameObject.SetActive(lVar7,1,0);
          if (0 < iVar14) {
            lVar7 = BookWriterUIController.GetWriterRoot(this,iVar14,0);
            if (lVar7 == null) {
        LAB_1809f3299:
                          // WARNING: Subroutine does not return
              FUN_1801e0300();
            }
            lVar7 = Component.get_gameObject(lVar7,0);
            uVar2 = BookWriterUIController.BookWriterUnlocked(this,iVar14,0);
            if (lVar7 == null) goto LAB_1809f3299;
            GameObject.SetActive(lVar7,uVar2,0);
            lVar7 = BookWriterUIController.GetWriterRoot(this,iVar14,0);
            if (((lVar7 == null) || (lVar7 = FUN_180b05920(lVar7,0)) == null) ||
               (lVar7 = Transform.Find(lVar7,"Lock",0)) == null) goto LAB_1809f3299;
            lVar7 = Component.get_gameObject(lVar7,0);
            cVar3 = BookWriterUIController.BookWriterUnlocked(this,iVar14,0);
            if (lVar7 == null) goto LAB_1809f3299;
            GameObject.SetActive(lVar7,!cVar3,0);
            lVar7 = BookWriterUIController.GetWriterRoot(this,iVar14,0);
            if (((lVar7 == null) || (lVar7 = FUN_180b05920(lVar7,0)) == null) ||
               ((lVar7 = Transform.Find(lVar7,"Lock",0), lVar7 == null ||
                (lVar7 = Transform.Find(lVar7,"Text",0)) == null))) goto LAB_1809f3299;
            uVar8 = Component.GetComponent(lVar7,DAT_181e79538);
            uVar9 = GlobalData.GetNumText(iVar14 * 3,0);
            uVar9 = String.Format("建筑{0}级解锁",uVar9,0);
            LTLocalization.SetText(uVar8,uVar9,0);
          }
          lVar7 = BookWriterUIController.GetWriterRoot(this,iVar14,0);
          if ((lVar7 == null) || (lVar7 = Transform.Find(lVar7,"ActiveCover",0)) == null)
          goto LAB_1809f3299;
          lVar7 = Component.get_gameObject(lVar7,0);
          if (lVar7 == null) goto LAB_1809f3299;
          GameObject.SetActive(lVar7,this.activeID != iVar14,0);
          local_res18[0] = 0;
          do {
            lVar7 = BookWriterUIController.GetWriterRoot(this,iVar14,0);
            if (lVar7 == null) goto LAB_1809f3299;
            lVar7 = Transform.Find(lVar7,"Tabs",0);
            uVar8 = Int32.ToString(local_res18,0);
            if ((lVar7 == null) || (lVar7 = Transform.Find(lVar7,uVar8,0)) == null) goto LAB_1809f3299;
            lVar7 = Component.GetComponent(lVar7,DAT_181e796b8);
            if ((this.targetBookWriterList == null) ||
               ((lVar10 = FUN_1800024b0(this.targetBookWriterList,iVar14,DAT_181e62478), lVar10 == null
                || (lVar7 == null)))) goto LAB_1809f3299;
            bVar15 = false;
            Selectable.set_interactable(lVar7,*(char *)(lVar10 + 56) == false,0);
            if ((this.targetBookWriterList == null) ||
               (lVar7 = FUN_1800024b0(this.targetBookWriterList,iVar14)) == null)
            goto LAB_1809f3299;
            if (*(int *)(lVar7 + 20) == local_res18[0]) {
              lVar7 = BookWriterUIController.GetWriterRoot(this,iVar14);
              if (lVar7 == null) goto LAB_1809f3299;
              lVar7 = Transform.Find(lVar7,"Tabs");
              uVar8 = Int32.ToString(local_res18,0);
              if (((lVar7 == null) || (lVar7 = Transform.Find(lVar7,uVar8)) == null) ||
                 (lVar7 = Component.GetComponent(lVar7,DAT_181e796b8)) == null) goto LAB_1809f3299;
              if (*(char *)(lVar7 + 0x118) == false) {
                lVar7 = BookWriterUIController.GetWriterRoot(this,iVar14);
                if (lVar7 == null) goto LAB_1809f3299;
                lVar7 = Transform.Find(lVar7,"Tabs");
                uVar8 = Int32.ToString(local_res18,0);
                if (((lVar7 == null) || (lVar7 = Transform.Find(lVar7,uVar8)) == null) ||
                   (lVar7 = Component.GetComponent(lVar7,DAT_181e796b8)) == null) goto LAB_1809f3299;
                Toggle.set_isOn(lVar7,1);
              }
            }
            local_res18[0] = local_res18[0] + 1;
          } while (local_res18[0] < 3);
          lVar7 = BookWriterUIController.GetWriterRoot(this,iVar14,0);
          if ((lVar7 == null) || (lVar7 = Transform.Find(lVar7,"Hero",0)) == null)
          goto LAB_1809f3299;
          uVar8 = Transform.Find(lVar7,"icon",0);
          cVar3 = Object.op_Inequality(uVar8,0,0);
          if (cVar3) {
            lVar7 = BookWriterUIController.GetWriterRoot(this,iVar14,0);
            if ((((lVar7 == null) || (lVar7 = Transform.Find(lVar7,"Hero",0)) == null) ||
                (lVar7 = Transform.Find(lVar7,"icon",0)) == null) ||
               (lVar7 = Component.GetComponent(lVar7,DAT_181e77438)) == null) goto LAB_1809f3299;
            lVar7 = *(int64 *)(lVar7 + 32);
            if ((this.targetBookWriterList == null) ||
               (lVar10 = FUN_1800024b0(this.targetBookWriterList,iVar14,DAT_181e62478)) == null)
            goto LAB_1809f3299;
            lVar10 = BookWriterData.GetBookWriterHero(lVar10,0);
            if (lVar7 != lVar10) {
              lVar7 = BookWriterUIController.GetWriterRoot(this,iVar14,0);
              if (((lVar7 == null) || (lVar7 = Transform.Find(lVar7,"Hero",0)) == null) ||
                 (lVar7 = Transform.Find(lVar7,"icon",0)) == null) goto LAB_1809f3299;
              uVar8 = Component.get_gameObject(lVar7,0);
              Object.Destroy(uVar8,0);
            }
          }
          if ((this.targetBookWriterList == null) ||
             (lVar7 = FUN_1800024b0(this.targetBookWriterList,iVar14,DAT_181e62478)) == null)
          goto LAB_1809f3299;
          lVar7 = BookWriterData.GetBookWriterHero(lVar7,0);
          if (lVar7 != null) {
            lVar7 = BookWriterUIController.GetWriterRoot(this,iVar14,0);
            if ((lVar7 == null) || (lVar7 = Transform.Find(lVar7,"Hero",0)) == null)
            goto LAB_1809f3299;
            uVar8 = Transform.Find(lVar7,"icon",0);
            cVar3 = Object.op_Equality(uVar8,0,0);
            if (cVar3) {
              lVar7 = BookWriterUIController.GetWriterRoot(this,iVar14,0);
              if ((lVar7 == null) || (lVar7 = Transform.Find(lVar7,"Hero",0)) == null)
              goto LAB_1809f3299;
              uVar8 = Component.get_gameObject(lVar7,0);
              lVar7 = FUN_1802107e0(0);
              if (lVar7 == null) goto LAB_1809f3299;
              uVar9 = *(uint64 *)(lVar7 + 144);
              uVar8 = GlobalData.AddChild(uVar8,uVar9,0);
              this.temp = uVar8;
              if (this.temp == null) goto LAB_1809f3299;
              lVar7 = GameObject.GetComponent(this.temp,DAT_181e54c18);
              if (((this.targetBookWriterList == null) ||
                  (lVar10 = FUN_1800024b0(this.targetBookWriterList,iVar14,DAT_181e62478), lVar10 == null
                  )) || (uVar8 = BookWriterData.GetBookWriterHero(lVar10,0), lVar7 == null))
              goto LAB_1809f3299;
              *(uint64 *)(lVar7 + 32) = uVar8;
              if ((this.temp == null) ||
                 (lVar7 = GameObject.GetComponent(this.temp,DAT_181e54c18),
                 lVar7 == null)) goto LAB_1809f3299;
              *(uint32 *)(lVar7 + 24) = 0;
              if ((this.temp == null) ||
                 (lVar7 = GameObject.GetComponent(this.temp,DAT_181e54c18),
                 lVar7 == null)) goto LAB_1809f3299;
              Object.set_name(lVar7,"icon",0);
            }
          }
          lVar7 = BookWriterUIController.GetWriterRoot(this,iVar14,0);
          if ((lVar7 == null) || (lVar7 = Transform.Find(lVar7,"ClearHeroButton",0)) == null)
          goto LAB_1809f3299;
          lVar7 = Component.get_gameObject(lVar7,0);
          if ((this.targetBookWriterList == null) ||
             (lVar10 = FUN_1800024b0(this.targetBookWriterList,iVar14,DAT_181e62478)) == null)
          goto LAB_1809f3299;
          lVar10 = BookWriterData.GetBookWriterHero(lVar10,0);
          bVar4 = bVar15;
          if (lVar10 != null) {
            if ((this.targetBookWriterList == null) ||
               (lVar10 = FUN_1800024b0(this.targetBookWriterList,iVar14,DAT_181e62478)) == null)
            goto LAB_1809f3299;
            bVar4 = *(char *)(lVar10 + 56) == false;
          }
          if (lVar7 == null) goto LAB_1809f3299;
          GameObject.SetActive(lVar7,bVar4,0);
          lVar7 = BookWriterUIController.GetWriterRoot(this,iVar14,0);
          if (((lVar7 == null) || (lVar7 = Transform.Find(lVar7,"Combine",0)) == null) ||
             (lVar7 = Transform.Find(lVar7,"CombineTarget",0)) == null) goto LAB_1809f3299;
          uVar8 = Transform.Find(lVar7,"icon",0);
          cVar3 = Object.op_Inequality(uVar8,0,0);
          if (cVar3) {
            lVar7 = BookWriterUIController.GetWriterRoot(this,iVar14,0);
            if (((lVar7 == null) || (lVar7 = Transform.Find(lVar7,"Combine",0)) == null) ||
               ((lVar7 = Transform.Find(lVar7,"CombineTarget",0), lVar7 == null ||
                (lVar7 = Transform.Find(lVar7,"icon",0)) == null))) goto LAB_1809f3299;
            uVar8 = Component.get_gameObject(lVar7,0);
            Object.Destroy(uVar8,0);
          }
          lVar7 = BookWriterUIController.GetWriterRoot(this,iVar14,0);
          if (((lVar7 == null) || (lVar7 = Transform.Find(lVar7,"Combine",0)) == null) ||
             (lVar7 = Transform.Find(lVar7,"CombineTarget2",0)) == null) goto LAB_1809f3299;
          uVar8 = Transform.Find(lVar7,"icon",0);
          cVar3 = Object.op_Inequality(uVar8,0,0);
          if (cVar3) {
            lVar7 = BookWriterUIController.GetWriterRoot(this,iVar14,0);
            if (((lVar7 == null) || (lVar7 = Transform.Find(lVar7,"Combine",0)) == null) ||
               ((lVar7 = Transform.Find(lVar7,"CombineTarget2",0), lVar7 == null ||
                (lVar7 = Transform.Find(lVar7,"icon",0)) == null))) goto LAB_1809f3299;
            uVar8 = Component.get_gameObject(lVar7,0);
            Object.Destroy(uVar8,0);
          }
          lVar7 = BookWriterUIController.GetWriterRoot(this,iVar14,0);
          if (((lVar7 == null) || (lVar7 = Transform.Find(lVar7,"Copy",0)) == null) ||
             (lVar7 = Transform.Find(lVar7,"CopyTarget",0)) == null) goto LAB_1809f3299;
          uVar8 = Transform.Find(lVar7,"icon",0);
          cVar3 = Object.op_Inequality(uVar8,0,0);
          if (cVar3) {
            lVar7 = BookWriterUIController.GetWriterRoot(this,iVar14,0);
            if (((lVar7 == null) || (lVar7 = Transform.Find(lVar7,"Copy",0)) == null) ||
               ((lVar7 = Transform.Find(lVar7,"CopyTarget",0), lVar7 == null ||
                (lVar7 = Transform.Find(lVar7,"icon",0)) == null))) goto LAB_1809f3299;
            uVar8 = Component.get_gameObject(lVar7,0);
            Object.Destroy(uVar8,0);
          }
          lVar7 = BookWriterUIController.GetWriterRoot(this,iVar14,0);
          if (((lVar7 == null) || (lVar7 = Transform.Find(lVar7,"Memory",0)) == null) ||
             (lVar7 = Transform.Find(lVar7,"MemoryTarget",0)) == null) goto LAB_1809f3299;
          uVar8 = Transform.Find(lVar7,"icon",0);
          cVar3 = Object.op_Inequality(uVar8,0,0);
          if (cVar3) {
            lVar7 = BookWriterUIController.GetWriterRoot(this,iVar14,0);
            if (((lVar7 == null) || (lVar7 = Transform.Find(lVar7,"Memory",0)) == null) ||
               ((lVar7 = Transform.Find(lVar7,"MemoryTarget",0), lVar7 == null ||
                (lVar7 = Transform.Find(lVar7,"icon",0)) == null))) goto LAB_1809f3299;
            uVar8 = Component.get_gameObject(lVar7,0);
            Object.Destroy(uVar8,0);
          }
          if ((this.targetBookWriterList == null) ||
             (lVar7 = FUN_1800024b0(this.targetBookWriterList,iVar14,DAT_181e62478)) == null)
          goto LAB_1809f3299;
          iVar6 = *(int *)(lVar7 + 20);
          if (iVar6 == 0) {
            if ((this.targetBookWriterList == null) ||
               (lVar7 = FUN_1800024b0(this.targetBookWriterList,iVar14,DAT_181e62478)) == null)
            goto LAB_1809f3299;
            if (*(int64 *)(lVar7 + 32) != 0) {
              lVar7 = BookWriterUIController.GetWriterRoot(this,iVar14,0);
              if (((lVar7 == null) || (lVar7 = Transform.Find(lVar7,"Combine",0)) == null) ||
                 (lVar7 = Transform.Find(lVar7,"CombineTarget",0)) == null) goto LAB_1809f3299;
              uVar8 = Component.get_gameObject(lVar7,0);
              lVar7 = FUN_1802107e0(0);
              if (lVar7 == null) goto LAB_1809f3299;
              uVar9 = *(uint64 *)(lVar7 + 160);
              uVar8 = GlobalData.AddChild(uVar8,uVar9,0);
              this.temp = uVar8;
              if (this.temp == null) goto LAB_1809f3299;
              lVar7 = GameObject.GetComponent(this.temp,DAT_181e55168);
              if (((this.targetBookWriterList == null) ||
                  (lVar10 = FUN_1800024b0(this.targetBookWriterList,iVar14,DAT_181e62478), lVar10 == null
                  )) || (lVar7 == null)) goto LAB_1809f3299;
              *(uint64 *)(lVar7 + 32) = *(uint64 *)(lVar10 + 32);
              if ((this.temp == null) ||
                 (lVar7 = GameObject.GetComponent(this.temp,DAT_181e55168),
                 lVar7 == null)) goto LAB_1809f3299;
              *(uint32 *)(lVar7 + 40) = 1;
              if ((this.temp == null) ||
                 (lVar7 = GameObject.GetComponent(this.temp,DAT_181e55168),
                 lVar7 == null)) goto LAB_1809f3299;
              Object.set_name(lVar7,"icon",0);
              lVar7 = BookWriterUIController.GetWriterRoot(this,iVar14,0);
              if (((lVar7 == null) || (lVar7 = Transform.Find(lVar7,"Combine",0)) == null) ||
                 (lVar7 = Transform.Find(lVar7,"CombineTarget2",0)) == null) goto LAB_1809f3299;
              uVar8 = Component.get_gameObject(lVar7,0);
              lVar7 = FUN_1802107e0(0);
              if (lVar7 == null) goto LAB_1809f3299;
              uVar8 = GlobalData.AddChild(uVar8,*(uint64 *)(lVar7 + 160),0);
              this.temp = uVar8;
              if (this.temp == null) goto LAB_1809f3299;
              lVar7 = GameObject.GetComponent(this.temp,DAT_181e55168);
              if ((this.targetBookWriterList == null) ||
                 (lVar10 = FUN_1800024b0(this.targetBookWriterList,iVar14,DAT_181e62478)) == null
                 ) goto LAB_1809f3299;
              uVar8 = *(uint64 *)(lVar10 + 40);
        LAB_1809f2400:
              if (lVar7 == null) goto LAB_1809f3299;
              *(uint64 *)(lVar7 + 32) = uVar8;
              if ((this.temp == null) ||
                 (lVar7 = GameObject.GetComponent(this.temp,DAT_181e55168),
                 lVar7 == null)) goto LAB_1809f3299;
              *(uint32 *)(lVar7 + 40) = 1;
              lVar7 = this.temp;
              uVar8 = DAT_181e55168;
              if (lVar7 == null) goto LAB_1809f3299;
        LAB_1809f2452:
              lVar7 = GameObject.GetComponent(lVar7,uVar8);
              if (lVar7 == null) goto LAB_1809f3299;
              Object.set_name(lVar7,"icon",0);
            }
          }
          else if (iVar6 == 1) {
            if ((this.targetBookWriterList == null) ||
               (lVar7 = FUN_1800024b0(this.targetBookWriterList,iVar14,DAT_181e62478)) == null)
            goto LAB_1809f3299;
            if (*(int64 *)(lVar7 + 32) != 0) {
              lVar7 = BookWriterUIController.GetWriterRoot(this,iVar14,0);
              if (((lVar7 != null) && (lVar7 = Transform.Find(lVar7,"Copy",0)) != null) &&
                 (lVar7 = Transform.Find(lVar7,"CopyTarget",0)) != null) {
                uVar8 = Component.get_gameObject(lVar7,0);
                lVar7 = FUN_1802107e0(0);
                if (lVar7 != null) {
                  uVar9 = *(uint64 *)(lVar7 + 160);
                  uVar8 = GlobalData.AddChild(uVar8,uVar9,0);
                  this.temp = uVar8;
                  if (this.temp != null) {
                    lVar7 = GameObject.GetComponent(this.temp,DAT_181e55168);
                    if ((this.targetBookWriterList != null) &&
                       (lVar10 = FUN_1800024b0(this.targetBookWriterList,iVar14,DAT_181e62478),
                       lVar10 != null)) {
                      uVar8 = *(uint64 *)(lVar10 + 32);
                      goto LAB_1809f2400;
                    }
                  }
                }
              }
              goto LAB_1809f3299;
            }
          }
          else if (iVar6 == 2) {
            if ((this.targetBookWriterList == null) ||
               (lVar7 = FUN_1800024b0(this.targetBookWriterList,iVar14,DAT_181e62478)) == null)
            goto LAB_1809f3299;
            if (*(int64 *)(lVar7 + 48) != 0) {
              lVar7 = BookWriterUIController.GetWriterRoot(this,iVar14,0);
              if (((lVar7 != null) && (lVar7 = Transform.Find(lVar7,"Memory",0)) != null) &&
                 (lVar7 = Transform.Find(lVar7,"MemoryTarget",0)) != null) {
                uVar8 = Component.get_gameObject(lVar7,0);
                lVar7 = FUN_1802107e0(0);
                if (lVar7 != null) {
                  uVar9 = *(uint64 *)(lVar7 + 168);
                  uVar8 = GlobalData.AddChild(uVar8,uVar9,0);
                  this.temp = uVar8;
                  if (this.temp != null) {
                    lVar7 = GameObject.GetComponent(this.temp,DAT_181e568c8);
                    if (((this.targetBookWriterList != null) &&
                        (lVar10 = FUN_1800024b0(this.targetBookWriterList,iVar14,DAT_181e62478),
                        lVar10 != null)) && (lVar7 != null)) {
                      *(uint64 *)(lVar7 + 32) = *(uint64 *)(lVar10 + 48);
                      if ((this.temp != null) &&
                         (lVar7 = GameObject.GetComponent(this.temp,DAT_181e568c8),
                         lVar7 != null)) {
                        *(uint32 *)(lVar7 + 40) = 2;
                        lVar7 = this.temp;
                        uVar8 = DAT_181e568c8;
                        if (lVar7 != null) goto LAB_1809f2452;
                      }
                    }
                  }
                }
              }
              goto LAB_1809f3299;
            }
          }
          lVar7 = BookWriterUIController.GetWriterRoot(this,iVar14,0);
          if ((lVar7 == null) || (lVar7 = Transform.Find(lVar7,"ClearBookButton",0)) == null)
          goto LAB_1809f3299;
          lVar7 = Component.get_gameObject(lVar7,0);
          if ((this.targetBookWriterList == null) ||
             (lVar10 = FUN_1800024b0(this.targetBookWriterList,iVar14,DAT_181e62478)) == null)
          goto LAB_1809f3299;
          if (*(int64 *)(lVar10 + 32) == 0) {
            if ((this.targetBookWriterList == null) ||
               (lVar10 = FUN_1800024b0(this.targetBookWriterList,iVar14,DAT_181e62478)) == null)
            goto LAB_1809f3299;
            if (*(int64 *)(lVar10 + 48) == 0)
            {
              }
              else {
            }
            if ((this.targetBookWriterList == null) ||
               (lVar10 = FUN_1800024b0(this.targetBookWriterList,iVar14,DAT_181e62478)) == null)
            goto LAB_1809f3299;
            bVar15 = *(char *)(lVar10 + 56) == false;
          }
          if (lVar7 == null) goto LAB_1809f3299;
          GameObject.SetActive(lVar7,bVar15,0);
          if ((this.targetBookWriterList == null) ||
             (lVar7 = FUN_1800024b0(this.targetBookWriterList,iVar14,DAT_181e62478)) == null)
          goto LAB_1809f3299;
          iVar6 = *(int *)(lVar7 + 20);
          if ((iVar6 == 0) || (iVar6 == 1)) {
            lVar7 = *(int64 *)(lVar7 + 32);
        LAB_1809f258e:
            if (lVar7 == null) goto LAB_1809f29ef;
            if ((this.targetBookWriterList == null) ||
               (lVar7 = FUN_1800024b0(this.targetBookWriterList,iVar14,DAT_181e62478)) == null)
            goto LAB_1809f3299;
            if (*(char *)(lVar7 + 56) != false) goto LAB_1809f29ef;
            lVar7 = BookWriterUIController.GetWriterRoot(this,iVar14,0);
            if ((lVar7 == null) || (lVar7 = Transform.Find(lVar7,"CostTime",0)) == null)
            goto LAB_1809f3299;
            uVar8 = Component.GetComponent(lVar7,DAT_181e79538);
            if ((this.targetBookWriterList == null) ||
               (lVar7 = FUN_1800024b0(this.targetBookWriterList,iVar14,DAT_181e62478)) == null)
            goto LAB_1809f3299;
            fVar16 = (float)BookWriterData.GetEachDayWorkPercent(lVar7,0);
            local_res20[0] = Mathf.CeilToInt(1.0 / fVar16,0);
            uVar9 = Int32.ToString(local_res20,0);
            uVar9 = String.Concat("预计时间: ",uVar9,"天",0);
            LTLocalization.SetText(uVar8,uVar9,0);
            lVar7 = BookWriterUIController.GetWriterRoot(this,iVar14,0);
            if ((lVar7 == null) || (lVar7 = Transform.Find(lVar7,"CostMoney",0)) == null)
            goto LAB_1809f3299;
            uVar8 = Component.GetComponent(lVar7,DAT_181e79538);
            if ((this.targetBookWriterList == null) ||
               (lVar7 = FUN_1800024b0(this.targetBookWriterList,iVar14,DAT_181e62478)) == null)
            goto LAB_1809f3299;
            local_res20[0] = BookWriterData.GetMoneyCost(lVar7,0);
            uVar9 = Int32.ToString(local_res20,0);
            uVar9 = String.Concat("消耗银两: ",uVar9,0);
            LTLocalization.SetText(uVar8,uVar9,0);
            lVar7 = BookWriterUIController.GetWriterRoot(this,iVar14,0);
            if ((lVar7 == null) || (lVar7 = Transform.Find(lVar7,"CostMoney",0)) == null)
            goto LAB_1809f3299;
            plVar11 = (int64 *)Component.GetComponent(lVar7,DAT_181e79538);
            if ((this.targetBookWriterList == null) ||
               (lVar7 = FUN_1800024b0(this.targetBookWriterList,iVar14,DAT_181e62478)) == null)
            goto LAB_1809f3299;
            cVar3 = BookWriterData.HaveMoney(lVar7,0);
            if (!cVar3) {
              puVar12 = (uint32 *)Color.get_red(local_98,0);
            }
            else {
              puVar12 = (uint32 *)Color.get_black(local_a8);
            }
            if (plVar11 == (int64 *)0) {
        LAB_1809f3293:
                          // WARNING: Subroutine does not return
              FUN_1801e0300();
            }
            local_b8 = *puVar12;
            uStack_b4 = puVar12[1];
            uStack_b0 = puVar12[2];
            uStack_ac = puVar12[3];
            (**(code **)(*plVar11 + 0x2a8))(plVar11,&local_b8,*(uint64 *)(*plVar11 + 0x2b0));
            lVar7 = BookWriterUIController.GetWriterRoot(this,iVar14,0);
            if ((lVar7 == null) || (lVar7 = Transform.Find(lVar7,"MinKnowledge",0)) == null)
            goto LAB_1809f3293;
            uVar8 = Component.GetComponent(lVar7,DAT_181e79538);
            if ((this.targetBookWriterList == null) ||
               (lVar7 = FUN_1800024b0(this.targetBookWriterList,iVar14,DAT_181e62478)) == null)
            goto LAB_1809f3293;
            local_c4[0] = BookWriterData.GetMinSkillLv(lVar7,0);
            uVar9 = il2cpp_value_box(DAT_181e60808,local_c4);
            lVar7 = *(int64 *)(*(int64 *)(DAT_181e538e8 + 184) + 0x4a8);
            if (((this.targetBookWriterList == null) ||
                (lVar10 = FUN_1800024b0(this.targetBookWriterList,iVar14,DAT_181e62478)) == null)
               || (uVar5 = BookWriterData.GetTargetSkillType(lVar10,0), lVar7 == null)) goto LAB_1809f3293;
            uVar13 = FUN_1800024b0(lVar7,uVar5,DAT_181e86970);
            uVar9 = String.Format("需要学识{0}/{1}{0}",uVar9,uVar13,0);
            LTLocalization.SetText(uVar8,uVar9,0);
            lVar7 = BookWriterUIController.GetWriterRoot(this,iVar14,0);
            if ((lVar7 == null) || (lVar7 = Transform.Find(lVar7,"MinKnowledge",0)) == null)
            goto LAB_1809f3293;
            plVar11 = (int64 *)Component.GetComponent(lVar7,DAT_181e79538);
            if ((this.targetBookWriterList == null) ||
               (lVar7 = FUN_1800024b0(this.targetBookWriterList,iVar14,DAT_181e62478)) == null)
            goto LAB_1809f3293;
            cVar3 = BookWriterData.HaveEnoughSkill(lVar7,0);
            if (!cVar3) {
              puVar12 = (uint32 *)Color.get_red(local_78,0);
            }
            else {
              puVar12 = (uint32 *)Color.get_black(local_88);
            }
            if (plVar11 == (int64 *)0) goto LAB_1809f3299;
            local_b8 = *puVar12;
            uStack_b4 = puVar12[1];
            uStack_b0 = puVar12[2];
            uStack_ac = puVar12[3];
            (**(code **)(*plVar11 + 0x2a8))(plVar11,&local_b8,*(uint64 *)(*plVar11 + 0x2b0));
          }
          else {
            if (iVar6 == 2) {
              lVar7 = *(int64 *)(lVar7 + 48);
              goto LAB_1809f258e;
            }
        LAB_1809f29ef:
            lVar7 = BookWriterUIController.GetWriterRoot(this,iVar14,0);
            if ((lVar7 == null) || (lVar7 = Transform.Find(lVar7,"CostTime",0)) == null)
            goto LAB_1809f328d;
            uVar8 = Component.GetComponent(lVar7,DAT_181e79538);
            if ((this.targetBookWriterList == null) ||
               (lVar7 = FUN_1800024b0(this.targetBookWriterList,iVar14,DAT_181e62478)) == null)
            goto LAB_1809f328d;
            uVar9 = "";
            if (*(char *)(lVar7 + 56) != false) {
              if ((this.targetBookWriterList == null) ||
                 (lVar7 = FUN_1800024b0(this.targetBookWriterList,iVar14,DAT_181e62478)) == null)
              goto LAB_1809f328d;
              fVar16 = (float)BookWriterData.GetEachDayWorkPercent(lVar7,0);
              iVar6 = Mathf.CeilToInt(1.0 / fVar16,0);
              if ((this.targetBookWriterList == null) ||
                 (lVar7 = FUN_1800024b0(this.targetBookWriterList,iVar14,DAT_181e62478)) == null)
              goto LAB_1809f328d;
              local_res20[0] = Mathf.CeilToInt((1.0 - *(float *)(lVar7 + 60)) * (float)iVar6,0);
              uVar9 = Int32.ToString(local_res20,0);
              uVar9 = String.Concat("预计时间:",uVar9,"天",0);
            }
            LTLocalization.SetText(uVar8,uVar9,0);
            lVar7 = BookWriterUIController.GetWriterRoot(this,iVar14,0);
            if ((lVar7 == null) || (lVar7 = Transform.Find(lVar7,"CostMoney",0)) == null)
            goto LAB_1809f328d;
            uVar8 = Component.GetComponent(lVar7,DAT_181e79538);
            if ((this.targetBookWriterList == null) ||
               (lVar7 = FUN_1800024b0(this.targetBookWriterList,iVar14,DAT_181e62478)) == null)
            goto LAB_1809f328d;
            uVar9 = "";
            if (*(char *)(lVar7 + 56) != false) {
              if ((this.targetBookWriterList == null) ||
                 (lVar7 = FUN_1800024b0(this.targetBookWriterList,iVar14,DAT_181e62478)) == null)
              goto LAB_1809f328d;
              local_c8 = (float)BookWriterData.GetEachDayWorkPercent(lVar7,0);
              local_c8 = local_c8 * 100.0;
              uVar9 = Single.ToString(&local_c8,"+0",0);
              uVar9 = String.Concat("每日进度:",uVar9,"%",0);
            }
            LTLocalization.SetText(uVar8,uVar9,0);
            lVar7 = BookWriterUIController.GetWriterRoot(this,iVar14,0);
            if ((lVar7 == null) || (lVar7 = Transform.Find(lVar7,"MinKnowledge",0)) == null)
            goto LAB_1809f328d;
            uVar8 = Component.GetComponent(lVar7,DAT_181e79538);
            LTLocalization.SetText(uVar8,"",0);
          }
          if ((this.targetBookWriterList == null) ||
             (lVar7 = FUN_1800024b0(this.targetBookWriterList,iVar14,DAT_181e62478)) == null)
          goto LAB_1809f328d;
          if (*(char *)(lVar7 + 56) == false) {
            lVar7 = BookWriterUIController.GetWriterRoot(this,iVar14);
            if ((lVar7 == null) || (lVar7 = Transform.Find(lVar7,"SureButton",0)) == null)
            goto LAB_1809f328d;
            lVar7 = Component.GetComponent(lVar7,DAT_181e76ab8);
            if ((this.targetBookWriterList == null) ||
               (lVar10 = FUN_1800024b0(this.targetBookWriterList,iVar14,DAT_181e62478)) == null)
            goto LAB_1809f328d;
            iVar6 = *(int *)(lVar10 + 20);
            if ((iVar6 == 0) || (iVar6 == 1)) {
              lVar1 = *(int64 *)(lVar10 + 32);
        LAB_1809f2d48:
              if ((lVar1 == null) || (*(int *)(lVar10 + 24) == -1)) goto LAB_1809f2d5c;
              uVar2 = BookWriterData.HaveMoney(lVar10,0);
            }
            else {
              if (iVar6 == 2) {
                lVar1 = *(int64 *)(lVar10 + 48);
                goto LAB_1809f2d48;
              }
        LAB_1809f2d5c:
              uVar2 = 0;
            }
            if (lVar7 != null) {
              Selectable.set_interactable(lVar7,uVar2,0);
              lVar7 = BookWriterUIController.GetWriterRoot(this,iVar14,0);
              if (((lVar7 == null) || (lVar7 = Transform.Find(lVar7,"SureButton",0)) == null) ||
                 (lVar7 = Transform.Find(lVar7,"Label",0)) == null) goto LAB_1809f328d;
              uVar8 = Component.GetComponent(lVar7,DAT_181e79538);
              LTLocalization.SetText(uVar8,"开始",0);
              lVar7 = BookWriterUIController.GetWriterRoot(this,iVar14,0);
              if ((lVar7 == null) || (lVar7 = Transform.Find(lVar7,"SureButton",0)) == null)
              goto LAB_1809f328d;
              plVar11 = (int64 *)Component.GetComponent(lVar7,DAT_181e777b8);
              puVar12 = (uint32 *)FUN_180f24d00(local_68,0);
              if (plVar11 == (int64 *)0) goto LAB_1809f328d;
              local_b8 = *puVar12;
              uStack_b4 = puVar12[1];
              uStack_b0 = puVar12[2];
              uStack_ac = puVar12[3];
              (**(code **)(*plVar11 + 0x2a8))(plVar11,&local_b8);
              lVar7 = BookWriterUIController.GetWriterRoot(this,iVar14);
              if (((lVar7 == null) || (lVar7 = Transform.Find(lVar7)) == null) ||
                 (lVar7 = Component.get_gameObject(lVar7)) == null) goto LAB_1809f328d;
              goto LAB_1809f31fe;
            }
          }
          else {
            lVar7 = BookWriterUIController.GetWriterRoot(this,iVar14,0);
            if (((lVar7 != null) && (lVar7 = Transform.Find(lVar7,"SureButton",0)) != null) &&
               (lVar7 = Component.GetComponent(lVar7,DAT_181e76ab8)) != null) {
              Selectable.set_interactable(lVar7,1,0);
              lVar7 = BookWriterUIController.GetWriterRoot(this,iVar14,0);
              if (((lVar7 != null) && (lVar7 = Transform.Find(lVar7,"SureButton",0)) != null) &&
                 (lVar7 = Transform.Find(lVar7,"Label",0)) != null) {
                uVar8 = Component.GetComponent(lVar7,DAT_181e79538);
                LTLocalization.SetText(uVar8,"取消",0);
                lVar7 = BookWriterUIController.GetWriterRoot(this,iVar14,0);
                if ((lVar7 != null) && (lVar7 = Transform.Find(lVar7,"SureButton",0)) != null) {
                  plVar11 = (int64 *)Component.GetComponent(lVar7,DAT_181e777b8);
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
                          lVar7 = Component.GetComponent(lVar7,DAT_181e777b8);
                          if (((this.targetBookWriterList != null) &&
                              (lVar10 = FUN_1800024b0(this.targetBookWriterList,iVar14,DAT_181e62478),
                              lVar10 != null)) && (lVar7 != null)) {
                            Image.set_fillAmount(lVar7);
                            lVar7 = BookWriterUIController.GetWriterRoot(this,iVar14,0);
                            if (((lVar7 != null) &&
                                (lVar7 = Transform.Find(lVar7,"PercentBarBack",0)) != null) &&
                               (lVar7 = Transform.Find(lVar7,"PercentNum",0)) != null) {
                              uVar8 = Component.GetComponent(lVar7,DAT_181e79538);
                              if ((this.targetBookWriterList == null) ||
                                 (lVar7 = FUN_1800024b0(this.targetBookWriterList,iVar14)) == null
                                 ) goto LAB_1809f328d;
                              local_c8 = *(float *)(lVar7 + 60) * 100.0;
                              uVar9 = Single.ToString(&local_c8,"f0");
                              String.Concat(uVar9,"%");
                              LTLocalization.SetText(uVar8);
                              iVar14 = iVar14 + 1;
                              goto LAB_1809f1150;
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
        LAB_1809f328d:
                          // WARNING: Subroutine does not return
          FUN_1801e0300();
        }
        lVar7 = BookWriterUIController.GetWriterRoot(this);
        if (((lVar7 == null) || (lVar7 = FUN_180b05920(lVar7)) == null) ||
           (lVar7 = Component.get_gameObject(lVar7)) == null) goto LAB_1809f3299;
        LAB_1809f31fe:
        GameObject.SetActive(lVar7);
        iVar14 = iVar14 + 1;
        goto LAB_1809f1150;
    }

    // Token : 0x6000D67
    // RVA   : 0x9EEDB0   Offset: 0x9EDBB0   Length: 0x2F1
    public void BookWriterActiveCoverClicked(GameObject buttonClicked)
    {
        uint uVar1;
        bool cVar2;
        uint uVar3;
        long lVar4;
        ulong uVar5;
        if ((((buttonClicked != null) && (lVar4 = GameObject.get_transform(buttonClicked,0)) != null) &&
            (lVar4 = FUN_180b05920(lVar4,0)) != null) && (lVar4 = FUN_180b05920(lVar4,0)) != null)
        {
          uVar5 = Object.get_name(lVar4,0);
          uVar3 = Int32.Parse(uVar5,0);
          cVar2 = BookWriterUIController.BookWriterUnlocked(this,uVar3,0);
          if (!cVar2) {
            if (GameController._instance != null) {
              GameController.ShowTextOnMouse(GameController._instance,"未解锁",0);
              plVar6 = (int64 *)Resources.Load("Sound/SoundEffect/WrongClick",0);
              plVar7 = (int64 *)0;
              if ((plVar6 != (int64 *)0) && (*plVar6 == DAT_181e8f4a0)) {
                plVar7 = plVar6;
              }
              NGUITools.PlaySound(plVar7,0);
              return;
            }
          }
          else {
            plVar6 = (int64 *)Resources.Load("Sound/SoundEffect/PaperQuick",0);
            plVar7 = (int64 *)0;
            if ((plVar6 != (int64 *)0) && (*plVar6 == DAT_181e8f4a0)) {
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
            if (((lVar4 != null) && (lVar4 = FUN_180b05920(lVar4,0)) != null) &&
               (lVar4 = FUN_180b05920(lVar4,0)) != null) {
              uVar5 = Object.get_name(lVar4,0);
              uVar3 = Int32.Parse(uVar5,0);
              this.activeID = uVar3;
              BookWriterUIController.RefreshUI(this,0);
              return;
            }
          }
        }
    }

    // Token : 0x6000D68
    // RVA   : 0x9EF580   Offset: 0x9EE380   Length: 0x224
    public void BookWriterTypeTabClicked(GameObject tabClicked)
    {
        uint uVar1;
        uint uVar2;
        long lVar3;
        long lVar4;
        ulong uVar5;
        if ((tabClicked != null) && (lVar3 = GameObject.GetComponent(tabClicked,DAT_181e57478)) != null) {
          if (*(char *)(lVar3 + 0x118) == false) {
            return;
          }
          lVar3 = this.targetBookWriterList;
          lVar4 = GameObject.get_transform(tabClicked,0);
          if ((((lVar4 != null) && (lVar4 = FUN_180b05920(lVar4,0)) != null) &&
              (lVar4 = FUN_180b05920(lVar4,0)) != null) &&
             (lVar4 = FUN_180b05920(lVar4,0)) != null) {
            uVar5 = Object.get_name(lVar4,0);
            uVar1 = Int32.Parse(uVar5,0);
            if (lVar3 != null) {
              if (lVar3.Count <= uVar1) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              lVar3 = lVar3._items[uVar1];
              if (lVar3 != null) {
                if (*(char *)(lVar3 + 56) != false) {
        LAB_1809ef780:
                  BookWriterUIController.RefreshUI(this,0);
                  return;
                }
                lVar3 = this.targetBookWriterList;
                lVar4 = GameObject.get_transform(tabClicked,0);
                if (((lVar4 != null) && (lVar4 = FUN_180b05920(lVar4,0)) != null) &&
                   ((lVar4 = FUN_180b05920(lVar4,0), lVar4 != null &&
                    (lVar4 = FUN_180b05920(lVar4,0)) != null))) {
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
                      if (((lVar3 != null) && (lVar3 = FUN_180b05920(lVar3,0)) != null) &&
                         ((lVar3 = FUN_180b05920(lVar3,0), lVar3 != null &&
                          (lVar3 = FUN_180b05920(lVar3,0)) != null))) {
                        uVar5 = Object.get_name(lVar3,0);
                        BookWriterUIController.ClearChoosenBook(this,uVar5,0,0);
                        goto LAB_1809ef780;
                      }
                    }
                  }
                }
              }
            }
          }
        }
    }

    // Token : 0x6000D69
    // RVA   : 0x9EFE20   Offset: 0x9EEC20   Length: 0x9CA
    public void ChooseHeroButtonClicked(GameObject buttonClick)
    {
        bool cVar1;
        long lVar2;
        long lVar3;
        ulong uVar4;
        long lVar5;
        ulong uVar6;
        int iVar7;
        lVar2 = il2cpp_internal(DAT_181e73338);
        FUN_1810f3480(lVar2,DAT_181e6d6f0);
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
              FUN_18175de30(lVar2,uVar4,DAT_181e6d770);
            }
            if (this.targetForce == null) {
              if ((GameController._instance == null) ||
                 (lVar3 = GameController._instance.worldData) == null)
              throw; // [null/range check failed]
              lVar3 = WorldData.Player(lVar3,0);
              if (lVar3 == null) throw; // [null/range check failed]
              cVar1 = HeroData.HaveLover(lVar3,0);
              if (cVar1) {
                lVar3 = FUN_1802106e0(0);
                if (lVar3 == null) throw; // [null/range check failed]
                lVar3 = lVar3.villageAreaID;
                lVar5 = FUN_1802106e0(0);
                if ((lVar5 == null) || (*(int64 *)(lVar5 + 32) == 0)) throw; // [null/range check failed]
                lVar5 = WorldData.Player(*(int64 *)(lVar5 + 32),0);
                if ((lVar5 == null) || (lVar3 == null)) throw; // [null/range check failed]
                lVar3 = WorldData.GetHero(lVar3,*(uint32 *)(lVar5 + 0x328),0);
                if (lVar3 == null) throw; // [null/range check failed]
                if (!lVar3.BigMapRandomEventDatas) {
                  lVar3 = FUN_1802106e0(0);
                  if (lVar3 == null) throw; // [null/range check failed]
                  lVar3 = lVar3.villageAreaID;
                  lVar5 = FUN_1802106e0(0);
                  if ((lVar5 == null) || (*(int64 *)(lVar5 + 32) == 0)) throw; // [null/range check failed]
                  lVar5 = WorldData.Player(*(int64 *)(lVar5 + 32),0);
                  if ((lVar5 == null) || (lVar3 == null)) throw; // [null/range check failed]
                  lVar3 = WorldData.GetHero(lVar3,*(uint32 *)(lVar5 + 0x328),0);
                  if (lVar3 == null) throw; // [null/range check failed]
                  if (*(char *)(lVar3 + 209) == false) {
                    lVar3 = FUN_1802106e0(0);
                    if (lVar3 == null) throw; // [null/range check failed]
                    lVar3 = lVar3.villageAreaID;
                    lVar5 = FUN_1802106e0(0);
                    if ((lVar5 == null) || (*(int64 *)(lVar5 + 32) == 0)) throw; // [null/range check failed]
                    lVar5 = WorldData.Player(*(int64 *)(lVar5 + 32),0);
                    if ((lVar5 == null) || (lVar3 == null)) throw; // [null/range check failed]
                    lVar3 = WorldData.GetHero(lVar3,*(uint32 *)(lVar5 + 0x328),0);
                    if (lVar3 == null) throw; // [null/range check failed]
                    if (*(char *)(lVar3 + 0x370) == false) {
                      lVar3 = FUN_1802106e0(0);
                      if (lVar3 == null) throw; // [null/range check failed]
                      lVar3 = lVar3.villageAreaID;
                      lVar5 = FUN_1802106e0(0);
                      if ((lVar5 == null) || (*(int64 *)(lVar5 + 32) == 0)) throw; // [null/range check failed]
                      lVar5 = WorldData.Player(*(int64 *)(lVar5 + 32),0);
                      if ((lVar5 == null) || (lVar3 == null)) throw; // [null/range check failed]
                      uVar4 = WorldData.GetHero(lVar3,*(uint32 *)(lVar5 + 0x328),0);
                      if (lVar2 == null) throw; // [null/range check failed]
                      FUN_18175de30(lVar2,uVar4,DAT_181e6d770);
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
                  if (*(int *)(lVar3.lastRandomWorldEventDay + 24) <= iVar7) goto LAB_1809f030a;
                  lVar3 = FUN_1802106e0(0);
                  if ((lVar3 == null) || (lVar3.villageAreaID == null)) break;
                  lVar3 = WorldData.Player(lVar3.villageAreaID,0);
                  if (lVar3 == null) break;
                  lVar3 = HeroData.GetForce(lVar3,0,0);
                  if (lVar3 == null) break;
                  ForceData.GetOwnHero(lVar3,iVar7,0);
                  if (lVar2 == null) break;
                  cVar1 = FUN_18175e190(lVar2);
                  if (!cVar1) {
                    lVar3 = FUN_1802106e0(0);
                    if ((lVar3 == null) || (lVar3.villageAreaID == null)) break;
                    lVar3 = WorldData.Player(lVar3.villageAreaID,0);
                    if (lVar3 == null) break;
                    lVar3 = HeroData.GetForce(lVar3,0);
                    if (lVar3 == null) break;
                    lVar3 = ForceData.GetOwnHero(lVar3);
                    if (lVar3 == null) break;
                    if (!lVar3.BigMapRandomEventDatas) {
                      lVar3 = FUN_1802106e0(0);
                      if ((lVar3 == null) || (lVar3.villageAreaID == null)) break;
                      lVar3 = WorldData.Player(lVar3.villageAreaID,0);
                      if (lVar3 == null) break;
                      lVar3 = HeroData.GetForce(lVar3,0);
                      if (lVar3 == null) break;
                      lVar3 = ForceData.GetOwnHero(lVar3);
                      if (lVar3 == null) break;
                      if (*(char *)(lVar3 + 209) == false) {
                        lVar3 = FUN_1802106e0(0);
                        if ((lVar3 == null) || (lVar3.villageAreaID == null)) break;
                        lVar3 = WorldData.Player(lVar3.villageAreaID,0);
                        if (lVar3 == null) break;
                        lVar3 = HeroData.GetForce(lVar3,0);
                        if (lVar3 == null) break;
                        lVar3 = ForceData.GetOwnHero(lVar3);
                        if (lVar3 == null) break;
                        if (*(char *)(lVar3 + 0x370) == false) {
                          lVar3 = FUN_1802106e0(0);
                          if ((lVar3 == null) || (lVar3.villageAreaID == null)) break;
                          lVar3 = WorldData.Player(lVar3.villageAreaID,0);
                          if (lVar3 == null) break;
                          lVar3 = HeroData.GetForce(lVar3,0,0);
                          if (lVar3 == null) break;
                          ForceData.GetOwnHero(lVar3,iVar7,0);
                          FUN_18175de30(lVar2);
                        }
                      }
                    }
                  }
                  iVar7 = iVar7 + 1;
                }
                throw; // [null/range check failed]
              }
            }
        LAB_1809f030a:
            lVar3 = **(int64 **)(DAT_181e977e8 + 184);
            uVar4 = Component.get_gameObject(this,0);
            if (buttonClick != null) {
              lVar5 = GameObject.get_transform(buttonClick,0);
              if (lVar5 != null) {
                lVar5 = FUN_180b05920(lVar5,0);
                if (lVar5 != null) {
                  lVar5 = FUN_180b05920(lVar5,0);
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

    // Token : 0x6000D6A
    // RVA   : 0x9EF440   Offset: 0x9EE240   Length: 0x137
    public void BookWriterTargetHeroChoosen(string writerID)
    {
        var pStatics = *(int64*)(DAT_181e977e8 + 184);
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
                  (lVar3 = GameObject.GetComponent(lVar3,DAT_181e54c18)) != null) &&
                 ((*(int64 *)(lVar3 + 32) != 0 && (lVar1 != null)))) {
                lVar1.Count = *(uint32 *)(*(int64 *)(lVar3 + 32) + 88);
                BookWriterUIController.RefreshUI(this,0);
                return;
              }
            }
          }
        }
    }

    // Token : 0x6000D6B
    // RVA   : 0x9F0A90   Offset: 0x9EF890   Length: 0x12B
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

    // Token : 0x6000D6C
    // RVA   : 0x9F0BC0   Offset: 0x9EF9C0   Length: 0xF1
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

    // Token : 0x6000D6D
    // RVA   : 0x9EF840   Offset: 0x9EE640   Length: 0x5DF
    public void ChooseBookButtonClicked(GameObject buttonClick)
    {
        var pStatics = *(int64*)(DAT_181e977e8 + 184);
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
            (lVar4 = FUN_180b05920(lVar4,0)) == null) ||
           ((lVar4 = FUN_180b05920(lVar4,0), lVar4 == null || (lVar4 = FUN_180b05920(lVar4,0)) == null)))
        {
        LAB_1809efe08:
                          // WARNING: Subroutine does not return
          FUN_1801e0300();
        }
        uVar5 = Object.get_name(lVar4,0);
        lVar4 = this.targetBookWriterList;
        uVar2 = Int32.Parse(uVar5,0);
        if (lVar4 == null) goto LAB_1809efe08;
        if (lVar4.Count <= uVar2) {
          ThrowHelper.ThrowArgumentOutOfRangeException(0);
        }
        lVar4 = lVar4._items[uVar2];
        if (lVar4 == null) goto LAB_1809efe08;
        iVar1 = *(int *)(lVar4 + 20);
        if (iVar1 == 0) {
          lVar4 = this.targetBookWriterList;
          uVar2 = Int32.Parse(uVar5,0);
          if (lVar4 == null) goto LAB_1809efe08;
          if (lVar4.Count <= uVar2) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          lVar4 = lVar4._items[uVar2];
          if (lVar4 == null) goto LAB_1809efe08;
          if (*(int64 *)(lVar4 + 32) != 0) {
            return;
          }
          lVar4 = *pStatics;
          lVar6 = il2cpp_internal(DAT_181e74e38);
          FUN_1810f3480(lVar6,DAT_181e77ae0);
          local_res10[0] = 0;
          uVar8 = il2cpp_value_box(DAT_181e60808,local_res10);
          if (lVar6 == null) {
        LAB_1809efe1a:
                          // WARNING: Subroutine does not return
            FUN_1801e0300();
          }
          FUN_18175de30(lVar6,uVar8,DAT_181e77be0);
          local_res20[0] = 3;
          uVar8 = il2cpp_value_box(DAT_181e60808,local_res20);
          FUN_18175de30(lVar6,uVar8,DAT_181e77be0);
          uVar8 = Component.get_gameObject(this,0);
          if (lVar4 == null) goto LAB_1809efe1a;
          uVar3 = 6;
        }
        else {
          if (iVar1 != 1) {
            if (iVar1 != 2) {
              return;
            }
            lVar4 = this.targetBookWriterList;
            uVar2 = Int32.Parse(uVar5,0);
            if (lVar4 == null) goto LAB_1809efe08;
            if (lVar4.Count <= uVar2) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            lVar4 = lVar4._items[uVar2];
            if (lVar4 == null) goto LAB_1809efe08;
            if (*(int64 *)(lVar4 + 48) != 0) {
              return;
            }
            lVar4 = this.targetBookWriterList;
            uVar2 = Int32.Parse(uVar5,0);
            if (lVar4 == null) goto LAB_1809efe08;
            if (lVar4.Count <= uVar2) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            lVar4 = lVar4._items[uVar2];
            if (lVar4 == null) goto LAB_1809efe08;
            lVar4 = BookWriterData.GetBookWriterHero(lVar4,0);
            if (lVar4 == null) {
              lVar4 = FUN_1802106e0(0);
              if (lVar4 != null) {
                GameController.ShowTextOnMouse(lVar4,"需先选择编纂角色",0);
                plVar9 = (int64 *)Resources.Load("Sound/SoundEffect/WrongClick",0);
                plVar11 = (int64 *)0;
                if ((plVar9 != (int64 *)0) && (*plVar9 == DAT_181e8f4a0)) {
                  plVar11 = plVar9;
                }
                NGUITools.PlaySound(plVar11,0);
                return;
              }
              goto LAB_1809efe08;
            }
            lVar4 = FUN_1802103a0(0);
            lVar6 = il2cpp_internal(DAT_181e74e38);
            FUN_1810f3480(lVar6,DAT_181e77ae0);
            lVar7 = this.targetBookWriterList;
            uVar3 = Int32.Parse(uVar5,0);
            if ((lVar7 == null) || (lVar7 = FUN_1800024b0(lVar7,uVar3,DAT_181e62478)) == null) {
        LAB_1809efe0e:
                          // WARNING: Subroutine does not return
              FUN_1801e0300();
            }
            local_res10[0] = lVar7.Count;
            uVar8 = il2cpp_value_box(DAT_181e60808,local_res10);
            if (lVar6 == null) goto LAB_1809efe0e;
            FUN_18175de30(lVar6,uVar8,DAT_181e77be0);
            uVar8 = Component.get_gameObject(this,0);
            if (lVar4 == null) goto LAB_1809efe0e;
            uVar10 = 0;
            uVar3 = 0;
            goto LAB_1809efcc9;
          }
          lVar4 = this.targetBookWriterList;
          uVar2 = Int32.Parse(uVar5,0);
          if (lVar4 == null) goto LAB_1809efe08;
          if (lVar4.Count <= uVar2) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          lVar4 = lVar4._items[uVar2];
          if (lVar4 == null) goto LAB_1809efe08;
          if (*(int64 *)(lVar4 + 32) != 0) {
            return;
          }
          lVar4 = *pStatics;
          lVar6 = il2cpp_internal(DAT_181e74e38);
          FUN_1810f3480(lVar6,DAT_181e77ae0);
          local_res10[0] = 0;
          uVar8 = il2cpp_value_box(DAT_181e60808,local_res10);
          if (lVar6 == null) {
        LAB_1809efe14:
                          // WARNING: Subroutine does not return
            FUN_1801e0300();
          }
          FUN_18175de30(lVar6,uVar8,DAT_181e77be0);
          local_res20[0] = 3;
          uVar8 = il2cpp_value_box(DAT_181e60808,local_res20);
          FUN_18175de30(lVar6,uVar8,DAT_181e77be0);
          uVar8 = Component.get_gameObject(this,0);
          if (lVar4 == null) goto LAB_1809efe14;
          uVar3 = 25;
        }
        uVar10 = 1;
        LAB_1809efcc9:
        ChooseController.ShowChoosePanel(lVar4,uVar10,lVar6,uVar8,"BookWriterTargetBookChoosen",uVar5,uVar3,0,0,0);
    }

    // Token : 0x6000D6E
    // RVA   : 0x9EF0B0   Offset: 0x9EDEB0   Length: 0x388
    public void BookWriterTargetBookChoosen(string writerID)
    {
        var pStatics = *(int64*)(DAT_181e977e8 + 184);
        int iVar1;
        long lVar2;
        uint uVar3;
        long lVar4;
        long lVar5;
        ulong uVar6;
        lVar2 = this.targetBookWriterList;
        uVar3 = Int32.Parse(writerID,0);
        if (lVar2 == null) {
        LAB_1809ef433:
                          // WARNING: Subroutine does not return
          FUN_1801e0300();
        }
        if (lVar2.Count <= uVar3) {
          ThrowHelper.ThrowArgumentOutOfRangeException(0);
        }
        lVar2 = lVar2._items[uVar3];
        if (lVar2 == null) goto LAB_1809ef433;
        iVar1 = *(int *)(lVar2 + 20);
        if (iVar1 == 0) {
          lVar2 = this.targetBookWriterList;
          uVar3 = Int32.Parse(writerID,0);
          if (lVar2 == null) goto LAB_1809ef433;
          if (lVar2.Count <= uVar3) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          lVar2 = lVar2._items[uVar3];
          if ((*pStatics == 0) ||
             (lVar4 = *(int64 *)(*pStatics + 72)) == null)
          goto LAB_1809ef433;
          lVar4 = GameObject.GetComponent(lVar4,DAT_181e55168);
          if ((lVar4 == null) || (lVar2 == null)) goto LAB_1809ef433;
          *(uint64 *)(lVar2 + 32) = *(uint64 *)(lVar4 + 32);
          lVar2 = this.targetBookWriterList;
          uVar3 = Int32.Parse(writerID,0);
          if (lVar2 == null) goto LAB_1809ef433;
          if (lVar2.Count <= uVar3) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          lVar2 = lVar2._items[uVar3];
          lVar4 = FUN_1802106e0(0);
          if ((lVar4 == null) || (*(int64 *)(lVar4 + 32) == 0)) goto LAB_1809ef433;
          lVar5 = WorldData.Player(*(int64 *)(lVar4 + 32),0);
          lVar4 = this.targetBookWriterList;
          uVar3 = Int32.Parse(writerID,0);
          if (lVar4 == null) goto LAB_1809ef433;
          if (lVar4.Count <= uVar3) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          lVar4 = lVar4._items[uVar3];
          if ((lVar4 == null) || (lVar5 == null)) goto LAB_1809ef433;
          uVar6 = HeroData.FindSameBook(lVar5,*(uint64 *)(lVar4 + 32),0);
          if (lVar2 == null) goto LAB_1809ef433;
          puVar7 = (uint64 *)(lVar2 + 40);
          *puVar7 = uVar6;
        }
        else if (iVar1 == 1) {
          lVar2 = this.targetBookWriterList;
          uVar3 = Int32.Parse(writerID,0);
          if (lVar2 == null) goto LAB_1809ef433;
          if (lVar2.Count <= uVar3) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          lVar2 = lVar2._items[uVar3];
          if ((*pStatics == 0) ||
             (lVar4 = *(int64 *)(*pStatics + 72)) == null)
          goto LAB_1809ef433;
          lVar4 = GameObject.GetComponent(lVar4,DAT_181e55168);
          if ((lVar4 == null) || (uVar6 = *(uint64 *)(lVar4 + 32), lVar2 == null)) goto LAB_1809ef433;
          puVar7 = (uint64 *)(lVar2 + 32);
          *puVar7 = uVar6;
        }
        else {
          if (iVar1 != 2) goto LAB_1809ef410;
          lVar2 = this.targetBookWriterList;
          uVar3 = Int32.Parse(writerID,0);
          if (lVar2 == null) goto LAB_1809ef433;
          if (lVar2.Count <= uVar3) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          lVar2 = lVar2._items[uVar3];
          if ((*pStatics == 0) ||
             (lVar4 = *(int64 *)(*pStatics + 72)) == null)
          goto LAB_1809ef433;
          lVar4 = GameObject.GetComponent(lVar4,DAT_181e568c8);
          if ((lVar4 == null) || (uVar6 = *(uint64 *)(lVar4 + 32), lVar2 == null)) goto LAB_1809ef433;
          puVar7 = (uint64 *)(lVar2 + 48);
          *puVar7 = uVar6;
        }
        il2cpp_internal(puVar7,uVar6);
        LAB_1809ef410:
        BookWriterUIController.RefreshUI(this,0);
    }

    // Token : 0x6000D6F
    // RVA   : 0x9F0A20   Offset: 0x9EF820   Length: 0x63
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

    // Token : 0x6000D70
    // RVA   : 0x9F08D0   Offset: 0x9EF6D0   Length: 0x141
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

    // Token : 0x6000D71
    // RVA   : 0x9F3310   Offset: 0x9F2110   Length: 0x9FF
    public void SureButtonClicked(GameObject buttonClick)
    {
        bool cVar1;
        uint uVar2;
        int iVar3;
        long lVar4;
        ulong uVar5;
        long lVar6;
        if ((((buttonClick != null) && (lVar4 = GameObject.get_transform(buttonClick,0)) != null) &&
            (lVar4 = FUN_180b05920(lVar4,0)) != null) && (lVar4 = FUN_180b05920(lVar4,0)) != null)
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
                      lVar4 = FUN_1802106e0(0);
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
                      cVar1 = FUN_18175e190(lVar4,*(uint64 *)(lVar6 + 32),DAT_181e72df0);
                      if (!cVar1) {
                        lVar4 = FUN_1802106e0(0);
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
                        lVar4 = FUN_1802106e0(0);
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
                          lVar4 = FUN_1802106e0(0);
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
                          cVar1 = FUN_18175e190(lVar4,*(uint64 *)(lVar6 + 40),DAT_181e72df0);
                          if (!cVar1) {
                            lVar4 = FUN_1802106e0(0);
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
                            lVar4 = FUN_1802106e0(0);
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
                                      goto LAB_1809f3cc9;
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
                      lVar4 = FUN_1802106e0(0);
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
                          lVar4 = FUN_1802106e0(0);
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
        LAB_1809f3cc9:
                        plVar8 = (int64 *)0;
                        if ((plVar7 != (int64 *)0) && (*plVar7 == DAT_181e8f4a0)) {
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

    // Token : 0x6000D72
    // RVA   : 0x9F07F0   Offset: 0x9EF5F0   Length: 0xD5
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
                 (lVar1 = FUN_1800024b0(this.targetBookWriterList,uVar3,DAT_181e62478)) == null)
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

    // Token : 0x6000D73
    // RVA   : 0x9F0D60   Offset: 0x9EFB60   Length: 0xEC
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
              if ((this.targetBookWriterList == null) || (lVar1 = FUN_1800024b0()) == null)
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

    // Token : 0x6000D74
    // RVA   : 0x9F32A0   Offset: 0x9F20A0   Length: 0x6E
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

    // Token : 0x6000D75
    // RVA   : 0x2110A0   Offset: 0x20FEA0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_180ae8740(this,0);
    }

    // Token : 0x6000D76
    // RVA   : 0x9F3D10   Offset: 0x9F2B10   Length: 0x39
    private static void /*cctor*/()
    {
        **(uint32 **)(DAT_181e92c98 + 184) = 4;
    }

}
