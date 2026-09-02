// ============================================================
// Type  : InvGameItem
// Token : 0x200000F
// ============================================================

public class InvGameItem
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4000042
    private int mBaseItemID;

    // Token: 0x4000043
    public Quality quality;

    // Token: 0x4000044
    public int itemLevel;

    // Token: 0x4000045
    private InvBaseItem mBaseItem;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x600003A
    // RVA   : 0x20F070   Offset: 0x20D870   Length: 0xC8
    public int get_baseItemID()
    {
        return this.mBaseItemID;
    }

    // Token : 0x600003B
    // RVA   : 0xB72A60   Offset: 0xB71260   Length: 0x7A
    public InvBaseItem get_baseItem()
    {
        uint uVar2;
        ulong uVar3;
        puVar1 = &this.mBaseItem;
        if (this.mBaseItem == null) {
          uVar2 = this.mBaseItemID;
          uVar3 = InvDatabase.FindByID(uVar2,0);
          this.mBaseItem = uVar3;
          il2cpp_internal(puVar1,uVar3);
        }
        return this.mBaseItem;
    }

    // Token : 0x600003C
    // RVA   : 0xB72C80   Offset: 0xB71480   Length: 0xD3
    public string get_name()
    {
        long lVar1;
        ulong uVar3;
        lVar1 = InvGameItem.get_baseItem(this,0);
        if (lVar1 != null) {
          plVar2 = (int64 *)il2cpp_value_box(DAT_181d55bf0,this + 20);
          if (plVar2 != (int64 *)0) {
            uVar3 = (**(code **)(*plVar2 + 0x168))(plVar2,*(uint64 *)(*plVar2 + 0x170));
            puVar4 = (uint32 *)il2cpp_object_unbox(plVar2);
            this.quality = *puVar4;
            lVar1 = InvGameItem.get_baseItem(this,0);
            if (lVar1 != null) {
              String.Concat(uVar3," ",*(uint64 *)(lVar1 + 24),0);
              return;
            }
          }
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
    }

    // Token : 0x600003D
    // RVA   : 0xB72D60   Offset: 0xB71560   Length: 0x24
    public float get_statMultiplier()
    {
        float fVar1;
        byte[] auVar2 = new byte[16];
        byte[] auVar3 = new byte[16];
        float fVar4;
        uint64 extraout_XMM0_Qb;
        fVar4 = 0.0;
        switch(this.quality) {
        case 1:
          fVar4 = -1.0;
          break;
        case 2:
          fVar4 = 0.25;
          break;
        case 3:
          fVar4 = 0.9;
          break;
        case 4:
          fVar4 = 1.0;
          break;
        case 5:
          fVar4 = 1.1;
          break;
        case 6:
          fVar4 = 1.25;
          break;
        case 7:
          fVar4 = 1.5;
          break;
        case 8:
          fVar4 = 1.75;
          break;
        case 9:
          fVar4 = 2.0;
          break;
        case 10:
          fVar4 = 2.5;
          break;
        case 11:
          fVar4 = 3.0;
        }
        fVar1 = (float)this.itemLevel / 50.0;
        auVar2._0_8_ = Mathf.Lerp(fVar1,fVar1 * fVar1,0x3f000000,0);
        auVar2._8_8_ = extraout_XMM0_Qb;
        auVar3._4_12_ = auVar2._4_12_;
        auVar3._0_4_ = (float)auVar2._0_8_ * fVar4;
        return auVar3._0_8_;
    }

    // Token : 0x600003E
    // RVA   : 0xB72AE0   Offset: 0xB712E0   Length: 0x164
    public Color get_color()
    {
        uint uVar1;
        uint uVar2;
        uint uVar3;
        ulong uVar6;
        byte[] local_18 = new byte[16];
        *this = 0;
        this[1] = 0;
        puVar4 = (uint32 *)FUN_181098a50(local_18,0);
        uVar1 = puVar4[1];
        uVar2 = puVar4[2];
        uVar3 = puVar4[3];
        *(uint32 *)this = *puVar4;
        *(uint32 *)((int64)this + 4) = uVar1;
        *(uint32 *)(this + 1) = uVar2;
        *(uint32 *)((int64)this + 12) = uVar3;
        switch(*(uint32 *)(param_2 + 20)) {
        case 0:
          Color.ctor(this,0x3ecccccd,0x3e4ccccd,0x3e4ccccd,0);
          return this;
        case 1:
          puVar5 = (uint64 *)Color.get_red(local_18,0);
          goto LAB_180b72c2e;
        case 2:
          Color.ctor(this,0x180000000,0x3ecccccd,0x3ecccccd,0);
          return this;
        case 3:
          Color.ctor(this,0x180000000,0x3f333333,0x3f333333,0);
          return this;
        case 4:
          Color.ctor(this,0x180000000,0x3f800000,0x3f800000,0);
          return this;
        case 5:
          uVar6 = 0xe0ffbeff;
          break;
        case 6:
          uVar6 = 0x93d749ff;
          break;
        case 7:
          uVar6 = 0x4eff00ff;
          break;
        case 8:
          uVar6 = 0xbaffff;
          break;
        case 9:
          uVar6 = 0x7376fdff;
          break;
        case 10:
          uVar6 = 0x9600ffff;
          break;
        case 11:
          uVar6 = 0xff9000ff;
          break;
        default:
          goto switchD_180b72b26_default;
        }
        puVar5 = (uint64 *)NGUIMath.HexToColor(local_18,uVar6,0);
        LAB_180b72c2e:
        uVar6 = puVar5[1];
        *this = *puVar5;
        this[1] = uVar6;
        switchD_180b72b26_default:
        return this;
    }

    // Token : 0x600003F
    // RVA   : 0xB72A20   Offset: 0xB71220   Length: 0x32
    public void /*ctor*/(int id)
    {
        this.quality = 4;
        this.itemLevel = 1;
        ZhSegment.Initialize(this,0);
        this.mBaseItem = param_3;
        this.mBaseItemID = id;
    }

    // Token : 0x6000040
    // RVA   : 0xB729D0   Offset: 0xB711D0   Length: 0x4D
    public void /*ctor*/(int id, InvBaseItem bi)
    {
        this.quality = 4;
        this.itemLevel = 1;
        ZhSegment.Initialize(this,0);
        this.mBaseItem = bi;
        this.mBaseItemID = id;
    }

    // Token : 0x6000041
    // RVA   : 0xB72640   Offset: 0xB70E40   Length: 0x104
    public List<InvStat> CalculateStats()
    {
        int iVar1;
        int iVar2;
        long lVar3;
        int iVar4;
        long lVar5;
        long lVar6;
        long lVar7;
        ulong uVar8;
        int iVar9;
        long lVar10;
        uint uVar11;
        long lVar12;
        float fVar13;
        float fVar14;
        lVar5 = il2cpp_internal(DAT_181d6f3b0);
        FUN_180f58a90(lVar5,DAT_181d68f70);
        lVar6 = InvGameItem.get_baseItem(this,0);
        if (lVar6 == null) {
          return lVar5;
        }
        fVar14 = 0.0;
        switch(this.quality) {
        case 1:
          fVar14 = -1.0;
          break;
        case 2:
          fVar14 = 0.25;
          break;
        case 3:
          fVar14 = 0.9;
          break;
        case 4:
          fVar14 = 1.0;
          break;
        case 5:
          fVar14 = 1.1;
          break;
        case 6:
          fVar14 = 1.25;
          break;
        case 7:
          fVar14 = 1.5;
          break;
        case 8:
          fVar14 = 1.75;
          break;
        case 9:
          fVar14 = 2.0;
          break;
        case 10:
          fVar14 = 2.5;
          break;
        case 11:
          fVar14 = 3.0;
        }
        fVar13 = (float)this.itemLevel / 50.0;
        fVar13 = (float)Mathf.Lerp(fVar13,fVar13 * fVar13,0x3f000000,0);
        lVar6 = InvGameItem.get_baseItem(this,0);
        if (lVar6 != null) {
          lVar6 = *(int64 *)(lVar6 + 56);
          uVar11 = 0;
          if (lVar6 != null) {
            iVar1 = *(int *)(lVar6 + 24);
            if (0 < iVar1) {
              lVar10 = 32;
              lVar12 = 0;
              do {
                if (*(uint32 *)(lVar6 + 24) <= uVar11) {
                  ThrowHelper.ThrowArgumentOutOfRangeException(0);
                }
                lVar3 = *(int64 *)(lVar10 + *(int64 *)(lVar6 + 16));
                if (lVar3 == null) throw; // [null/range check failed]
                iVar4 = Mathf.RoundToInt((float)*(int *)(lVar3 + 24) * fVar13 * fVar14,0);
                if (iVar4 != 0) {
                  iVar9 = 0;
                  if (lVar5 == null) throw; // [null/range check failed]
                  iVar2 = *(int *)(lVar5 + 24);
                  if (0 < iVar2) {
                    do {
                      lVar7 = FUN_180002f80(lVar5,iVar9,DAT_181d69170);
                      if (lVar7 == null) throw; // [null/range check failed]
                      if ((*(int *)(lVar7 + 16) == *(int *)(lVar3 + 16)) &&
                         (*(int *)(lVar7 + 20) == *(int *)(lVar3 + 20))) {
                        *(int *)(lVar7 + 24) = *(int *)(lVar7 + 24) + iVar4;
                        goto LAB_180b72900;
                      }
                      iVar9 = iVar9 + 1;
                    } while (iVar9 < iVar2);
                  }
                  lVar7 = new ZhSegment(0);
                  if (lVar7 == null) throw; // [null/range check failed]
                  *(uint32 *)(lVar7 + 16) = *(uint32 *)(lVar3 + 16);
                  *(int *)(lVar7 + 24) = iVar4;
                  *(uint32 *)(lVar7 + 20) = *(uint32 *)(lVar3 + 20);
                  FUN_181827900(lVar5,lVar7,DAT_181d68ff0);
                }
        LAB_180b72900:
                uVar11 = uVar11 + 1;
                lVar12 = lVar12 + 1;
                lVar10 = lVar10 + 8;
              } while (lVar12 < iVar1);
            }
            uVar8 = new OnTooltipCB(0,DAT_181d53e78,DAT_181d86098);
            if (lVar5 != null) {
              List_1.Sort(lVar5,uVar8,DAT_181d69070);
              return lVar5;
            }
          }
        }
    }

}
