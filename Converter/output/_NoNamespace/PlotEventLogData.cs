// ============================================================
// Type  : PlotEventLogData
// Token : 0x20001CC
// ============================================================

public class PlotEventLogData
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4000C62
    public Dictionary<string, string> plotEventLogData;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000EA8
    // RVA   : 0xB0D0A0   Offset: 0xB0C4A0   Length: 0x76
    public void /*ctor*/()
    {
        ulong uVar1;
        ZhSegment.Initialize(this,0);
        uVar1 = il2cpp_internal(DAT_181d83380);
        FUN_1808b1370(uVar1,DAT_181d75830);
        this.plotEventLogData = uVar1;
    }

    // Token : 0x6000EA9
    // RVA   : 0xB0CEF0   Offset: 0xB0C2F0   Length: 0x94
    public void Reset()
    {
        ulong uVar1;
        if (this.plotEventLogData != null) {
          Dictionary_2.Clear(this.plotEventLogData,DAT_181d75a50);
          return;
        }
        uVar1 = il2cpp_internal(DAT_181d83380);
        FUN_1808b1370(uVar1,DAT_181d75830);
        this.plotEventLogData = uVar1;
    }

    // Token : 0x6000EAA
    // RVA   : 0xB0CF90   Offset: 0xB0C390   Length: 0x10A
    public PlotEventLogData Set(string key, string value)
    {
        long lVar1;
        bool cVar2;
        if (this.plotEventLogData != null) {
          cVar2 = FUN_1808ab490(this.plotEventLogData,key,DAT_181d75ad8);
          if (!cVar2) {
            if (value == null) {
              return this;
            }
            if (this.plotEventLogData != null) {
              FUN_1808ab370(this.plotEventLogData,key,value,DAT_181d759c8);
              return this;
            }
          }
          else {
            lVar1 = this.plotEventLogData;
            if (value == null) {
              if (lVar1 != null) {
                FUN_1817b7860(lVar1,key,DAT_181d75be8);
                return this;
              }
            }
            else if (lVar1 != null) {
              FUN_1808b2160(lVar1,key,value,DAT_181d75e90);
              return this;
            }
          }
        }
    }

    // Token : 0x6000EAB
    // RVA   : 0xB0CE00   Offset: 0xB0C200   Length: 0x88
    public string Get(string key)
    {
        bool cVar1;
        ulong uVar2;
        if (this.plotEventLogData != null) {
          cVar1 = FUN_1808ab490(this.plotEventLogData,key,DAT_181d75ad8);
          if (!cVar1) {
            return 0;
          }
          if (this.plotEventLogData != null) {
            uVar2 = FUN_1817c69b0(this.plotEventLogData,key,DAT_181d75d80);
            return uVar2;
          }
        }
    }

    // Token : 0x6000EAC
    // RVA   : 0xB0CD00   Offset: 0xB0C100   Length: 0x92
    public int GetInt(string key)
    {
        bool cVar1;
        ulong uVar2;
        if (this.plotEventLogData != null) {
          cVar1 = FUN_1808ab490(this.plotEventLogData,key,DAT_181d75ad8);
          if (!cVar1) {
            return 0;
          }
          if (this.plotEventLogData != null) {
            uVar2 = FUN_1817c69b0(this.plotEventLogData,key,DAT_181d75d80);
            uVar2 = Int32.Parse(uVar2,0);
            return uVar2;
          }
        }
    }

    // Token : 0x6000EAD
    // RVA   : 0xB0CC60   Offset: 0xB0C060   Length: 0x93
    public float GetFloat(string key)
    {
        bool cVar1;
        ulong uVar2;
        if (this.plotEventLogData != null) {
          cVar1 = FUN_1808ab490(this.plotEventLogData,key,DAT_181d75ad8);
          if (!cVar1) {
            return 0;
          }
          if (this.plotEventLogData != null) {
            uVar2 = FUN_1817c69b0(this.plotEventLogData,key,DAT_181d75d80);
            uVar2 = Single.Parse(uVar2,0);
            return uVar2;
          }
        }
    }

    // Token : 0x6000EAE
    // RVA   : 0xB0CDA0   Offset: 0xB0C1A0   Length: 0x5F
    public List<string> GetKeys()
    {
        ulong uVar1;
        if (this.plotEventLogData != null) {
          uVar1 = Dictionary_2.get_Keys(this.plotEventLogData,DAT_181d75e08);
          Enumerable.ToList(uVar1,DAT_181db5790);
          return;
        }
    }

    // Token : 0x6000EAF
    // RVA   : 0xB0CE90   Offset: 0xB0C290   Length: 0x53
    public bool HaveKey(string key)
    {
        if (this.plotEventLogData != null) {
          FUN_1808ab490(this.plotEventLogData,key,DAT_181d75ad8);
          return;
        }
    }

    // Token : 0x6000EB0
    // RVA   : 0xB0D120   Offset: 0xB0C520   Length: 0x1D8
    public bool isEmpty()
    {
        bool cVar1;
        long lVar2;
        int iVar3;
        int[] aiStack_54 = new int[5];
        uint local_40;
        uint32 uStack_3c;
        uint32 uStack_38;
        uint32 uStack_34;
        uint64 local_30;
        uint32 local_28;
        uint32 uStack_24;
        uint32 uStack_20;
        uint32 uStack_1c;
        uint64 local_18;
        aiStack_54[3] = 0;
        if (this.plotEventLogData != null) {
          lVar2 = Dictionary_2.get_Keys(this.plotEventLogData,DAT_181d75e08);
          if (lVar2 != null) {
            ValueCollection.GetEnumerator(&local_28,lVar2,DAT_181dc6538);
            local_40 = local_28;
            uStack_3c = uStack_24;
            uStack_38 = uStack_20;
            uStack_34 = uStack_1c;
            local_30 = local_18;
            do {
              cVar1 = FUN_1811c2d30(&local_40,DAT_181da1bd0);
              if (!cVar1) {
                aiStack_54[1] = 70;
                iVar3 = aiStack_54[3] + 1;
                aiStack_54[3] = iVar3;
                ZhSegment.Initialize(&local_40,DAT_181da1b50);
                goto LAB_180b0d2ad;
              }
              if (this.plotEventLogData == null) {
                          // WARNING: Subroutine does not return
                FUN_1800d6620();
              }
              lVar2 = FUN_1817c69b0(this.plotEventLogData,local_30,DAT_181d75d80);
            } while (lVar2 == null);
            aiStack_54[1] = 72;
            iVar3 = aiStack_54[3] + 1;
            aiStack_54[3] = iVar3;
            ZhSegment.Initialize(&local_40,DAT_181da1b50);
        LAB_180b0d2ad:
            if ((iVar3 != 0) && (aiStack_54[iVar3] == 72)) {
              return false;
            }
            return true;
          }
        }
    }

    // Token : 0x6000EB1
    // RVA   : 0xB0CAE0   Offset: 0xB0BEE0   Length: 0x175
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
