// ============================================================
// Type  : AreaBuildingShopData
// Token : 0x20001ED
// ============================================================

public class AreaBuildingShopData
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4000DAA
    public float money;

    // Token: 0x4000DAB
    public float itemNum;

    // Token: 0x4000DAC
    public float itemBossLv;

    // Token: 0x4000DAD
    public List<int> itemType;

    // Token: 0x4000DAE
    public int subType;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000F4D
    // RVA   : 0xA2C9E0   Offset: 0xA2BDE0   Length: 0x2D0
    public void /*ctor*/(string param)
    {
        bool cVar1;
        long lVar2;
        long lVar3;
        long lVar4;
        ulong uVar5;
        uint uVar6;
        uint uVar7;
        this.subType = 0xffffffff;
        ZhSegment.Initialize(this,0);
        lVar2 = FUN_1800d60b0(DAT_181da1058,1);
        if (lVar2 != null) {
          if (*(int *)(lVar2 + 24) == 0) {
            uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar5,0);
          }
          *(uint16 *)(lVar2 + 32) = 45;
          if ((param != null) && (lVar2 = String.Split(param,lVar2,0)) != null) {
            if (*(int *)(lVar2 + 24) == 0) {
              uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar5,0);
            }
            uVar7 = Single.Parse(*(uint64 *)(lVar2 + 32),0);
            this.money = uVar7;
            if (*(uint32 *)(lVar2 + 24) < 2) {
              uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar5,0);
            }
            uVar7 = Single.Parse(*(uint64 *)(lVar2 + 40),0);
            this.itemNum = uVar7;
            if (*(uint32 *)(lVar2 + 24) < 3) {
              uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar5,0);
            }
            uVar7 = Single.Parse(*(uint64 *)(lVar2 + 48),0);
            this.itemBossLv = uVar7;
            if (*(uint32 *)(lVar2 + 24) < 4) {
              uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar5,0);
            }
            lVar4 = *(int64 *)(lVar2 + 56);
            lVar3 = FUN_1800d60b0(DAT_181da1058,1);
            if (lVar3 != null) {
              if (lVar3.Count == null) {
                uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar5,0);
              }
              *(uint16 *)(lVar3 + 32) = 47;
              if (lVar4 != null) {
                lVar4 = String.Split(lVar4,lVar3,0);
                uVar5 = il2cpp_internal(DAT_181d93ce8);
                FUN_181330100(uVar5,DAT_181d8f0b0);
                this.itemType = uVar5;
                uVar6 = 0;
                if (lVar4 != null) {
                  while( true ) {
                    if ((int)*(uint32 *)(lVar4 + 24) <= (int)uVar6) {
                      if (4 < (int)*(uint32 *)(lVar2 + 24)) {
                        if (*(uint32 *)(lVar2 + 24) < 5) {
                          uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                          FUN_1800d65f0(uVar5,0);
                        }
                        cVar1 = FUN_180d75bc0(*(uint64 *)(lVar2 + 64),0);
                        if (!cVar1) {
                          if (4 < *(uint32 *)(lVar2 + 24)) {
                            uVar7 = Int32.Parse(*(uint64 *)(lVar2 + 64),0);
                            this.subType = uVar7;
                            return;
                          }
                          uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                          FUN_1800d65f0(uVar5,0);
                        }
                      }
                      this.subType = 0xffffffff;
                      return;
                    }
                    lVar3 = this.itemType;
                    if (*(uint32 *)(lVar4 + 24) <= uVar6) {
                      uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                      FUN_1800d65f0(uVar5,0);
                    }
                    uVar7 = Int32.Parse(lVar4[uVar6],0);
                    if (lVar3 == null) break;
                    FUN_18182a6c0(lVar3,uVar7,DAT_181d8f230);
                    uVar6 = uVar6 + 1;
                  }
                }
              }
            }
          }
        }
    }

    // Token : 0x6000F4E
    // RVA   : 0xA2C860   Offset: 0xA2BC60   Length: 0x175
    public virtual object Clone()
    {
        long lVar2;
        ulong uVar3;
        ulong local_38;
        ulong uStack_30;
        uint local_28;
        uint uStack_24;
        uint uStack_20;
        uint32 uStack_1c;
        plVar1 = (int64 *)il2cpp_internal(DAT_181d89228);
        plVar4 = plVar1;
        MemoryStream.ctor(plVar1,1000,0);
        local_38 = 0;
        uStack_30 = 0;
        StreamingContext.ctor(&local_38,64,0);
        lVar2 = il2cpp_internal(DAT_181db1748);
        local_28 = (uint32)local_38;
        uStack_24 = local_38._4_4_;
        uStack_20 = (uint32)uStack_30;
        uStack_1c = uStack_30._4_4_;
        BinaryFormatter.ctor(lVar2,0,&local_28,0,plVar4);
        if (lVar2 != null) {
          BinaryFormatter.Serialize(lVar2,plVar1,this,0);
          if (plVar1 != (int64 *)0) {
            (**(code **)(*plVar1 + 0x2c8))(plVar1,0,0,*(uint64 *)(*plVar1 + 0x2d0));
            uVar3 = BinaryFormatter.Deserialize(lVar2,plVar1,0);
            (**(code **)(*plVar1 + 0x238))(plVar1,*(uint64 *)(*plVar1 + 0x240));
            FUN_180002970(0,DAT_181d78db8,plVar1);
            return uVar3;
          }
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
    }

}
