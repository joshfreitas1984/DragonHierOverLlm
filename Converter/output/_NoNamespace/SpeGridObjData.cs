// ============================================================
// Type  : SpeGridObjData
// Token : 0x2000187
// ============================================================

public class SpeGridObjData
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4000AA1
    public SpeGridObjType speGridObjType;

    // Token: 0x4000AA2
    public string name;

    // Token: 0x4000AA3
    public string describe;

    // Token: 0x4000AA4
    public bool destroyAfterTrigger;

    // Token: 0x4000AA5
    public float valueRate;

    // Token: 0x4000AA6
    public int teamID;

    // Token: 0x4000AA7
    public float hp;

    // Token: 0x4000AA8
    public float maxHp;

    // Token: 0x4000AA9
    public bool abovePlayer;

    // Token: 0x4000AAA
    public bool onGround;

    // Token: 0x4000AAB
    public string soundEffect;

    // Token: 0x4000AAC
    public bool flipX;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000CA3
    // RVA   : 0xC55BE0   Offset: 0xC54FE0   Length: 0xE
    public void /*ctor*/()
    {
        this.teamID = 0xffffffff;
        ZhSegment.Initialize(this,0);
    }

    // Token : 0x6000CA4
    // RVA   : 0xC55BD0   Offset: 0xC54FD0   Length: 0x10
    public float GetValueRate()
    {
        if (this.teamID == -1) {
          return this.valueRate;
        }
        return 0;
    }

    // Token : 0x6000CA5
    // RVA   : 0xC559F0   Offset: 0xC54DF0   Length: 0x1DD
    public virtual object Clone()
    {
        long lVar2;
        ulong uVar3;
        ushort uVar5;
        ulong local_38;
        ulong uStack_30;
        uint local_28;
        uint uStack_24;
        uint uStack_20;
        uint32 uStack_1c;
        uint64 uVar6;
        uVar6 = 0;
        plVar1 = (int64 *)il2cpp_internal(DAT_181d89228);
        plVar7 = plVar1;
        MemoryStream.ctor(plVar1,1000,0);
        local_38 = 0;
        uStack_30 = 0;
        StreamingContext.ctor(&local_38,64,0);
        lVar2 = il2cpp_internal(DAT_181db1748);
        local_28 = (uint32)local_38;
        uStack_24 = local_38._4_4_;
        uStack_20 = (uint32)uStack_30;
        uStack_1c = uStack_30._4_4_;
        BinaryFormatter.ctor(lVar2,0,&local_28,0,plVar7);
        if (lVar2 == null) {
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
        BinaryFormatter.Serialize(lVar2,plVar1,this,0);
        if (plVar1 == (int64 *)0) {
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
        (**(code **)(*plVar1 + 0x2c8))(plVar1,0,0,*(uint64 *)(*plVar1 + 0x2d0));
        uVar3 = BinaryFormatter.Deserialize(lVar2,plVar1,0);
        (**(code **)(*plVar1 + 0x238))(plVar1,*(uint64 *)(*plVar1 + 0x240));
        lVar2 = *plVar1;
        if (*(uint16 *)(lVar2 + 0x12a) != 0) {
          do {
            if (*(int64 *)(*(int64 *)(lVar2 + 176) + uVar6 * 16) == DAT_181d78db8) {
              puVar4 = (uint64 *)
                       ((int64)*(int *)(*(int64 *)(lVar2 + 176) + 8 + uVar6 * 16) * 16 + 0x138
                       + lVar2);
              goto LAB_180c55b74;
            }
            uVar5 = (short)uVar6 + 1;
            uVar6 = (uint64)uVar5;
          } while (uVar5 < *(uint16 *)(lVar2 + 0x12a));
        }
        puVar4 = (uint64 *)FUN_1800914f0(plVar1,DAT_181d78db8,0);
        LAB_180c55b74:
        (*(code *)*puVar4)(plVar1,puVar4[1]);
        return uVar3;
    }

}
