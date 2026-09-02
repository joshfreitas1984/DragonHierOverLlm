// ============================================================
// Type  : PlotEventLogData
// Token : 0x20001C6
// ============================================================

public class PlotEventLogData
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4000BD5
    public Dictionary<string, string> plotEventLogData;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000E73
    // RVA   : 0xBD85B0   Offset: 0xBD6DB0   Length: 0x76
    public void /*ctor*/()
    {
        ulong uVar1;
        ZhSegment.Initialize(this,0);
        uVar1 = il2cpp_internal(DAT_181d5e848);
        FUN_1808ae540(uVar1,DAT_181d4f5d8);
        this.plotEventLogData = uVar1;
    }

    // Token : 0x6000E74
    // RVA   : 0xBD8400   Offset: 0xBD6C00   Length: 0x94
    public void Reset()
    {
        ulong uVar1;
        if (this.plotEventLogData != null) {
          Dictionary_2.Clear(this.plotEventLogData,DAT_181d4f7d8);
          return;
        }
        uVar1 = il2cpp_internal(DAT_181d5e848);
        FUN_1808ae540(uVar1,DAT_181d4f5d8);
        this.plotEventLogData = uVar1;
    }

    // Token : 0x6000E75
    // RVA   : 0xBD84A0   Offset: 0xBD6CA0   Length: 0x10A
    public PlotEventLogData Set(string key, string value)
    {
        long lVar1;
        bool cVar2;
        if (this.plotEventLogData != null) {
          cVar2 = FUN_1808ab750(this.plotEventLogData,key,DAT_181d4f858);
          if (!cVar2) {
            if (value == null) {
              return this;
            }
            if (this.plotEventLogData != null) {
              FUN_1808ab680(this.plotEventLogData,key,value,DAT_181d4f758);
              return this;
            }
          }
          else {
            lVar1 = this.plotEventLogData;
            if (value == null) {
              if (lVar1 != null) {
                FUN_18177a010(lVar1,key,DAT_181d4f958);
                return this;
              }
            }
            else if (lVar1 != null) {
              FUN_1808aec90(lVar1,key,value,DAT_181d4fbd8);
              return this;
            }
          }
        }
    }

    // Token : 0x6000E76
    // RVA   : 0xBD8310   Offset: 0xBD6B10   Length: 0x88
    public string Get(string key)
    {
        bool cVar1;
        ulong uVar2;
        if (this.plotEventLogData != null) {
          cVar1 = FUN_1808ab750(this.plotEventLogData,key,DAT_181d4f858);
          if (!cVar1) {
            return 0;
          }
          if (this.plotEventLogData != null) {
            uVar2 = FUN_1817897a0(this.plotEventLogData,key,DAT_181d4fad8);
            return uVar2;
          }
        }
    }

    // Token : 0x6000E77
    // RVA   : 0xBD8210   Offset: 0xBD6A10   Length: 0x92
    public int GetInt(string key)
    {
        bool cVar1;
        ulong uVar2;
        if (this.plotEventLogData != null) {
          cVar1 = FUN_1808ab750(this.plotEventLogData,key,DAT_181d4f858);
          if (!cVar1) {
            return 0;
          }
          if (this.plotEventLogData != null) {
            uVar2 = FUN_1817897a0(this.plotEventLogData,key,DAT_181d4fad8);
            uVar2 = Int32.Parse(uVar2,0);
            return uVar2;
          }
        }
    }

    // Token : 0x6000E78
    // RVA   : 0xBD8170   Offset: 0xBD6970   Length: 0x93
    public float GetFloat(string key)
    {
        bool cVar1;
        ulong uVar2;
        if (this.plotEventLogData != null) {
          cVar1 = FUN_1808ab750(this.plotEventLogData,key,DAT_181d4f858);
          if (!cVar1) {
            return 0;
          }
          if (this.plotEventLogData != null) {
            uVar2 = FUN_1817897a0(this.plotEventLogData,key,DAT_181d4fad8);
            uVar2 = Single.Parse(uVar2,0);
            return uVar2;
          }
        }
    }

    // Token : 0x6000E79
    // RVA   : 0xBD82B0   Offset: 0xBD6AB0   Length: 0x5F
    public List<string> GetKeys()
    {
        ulong uVar1;
        if (this.plotEventLogData != null) {
          uVar1 = Dictionary_2.get_Keys(this.plotEventLogData,DAT_181d4fb58);
          Enumerable.ToList(uVar1,DAT_181d8c9d8);
          return;
        }
    }

    // Token : 0x6000E7A
    // RVA   : 0xBD83A0   Offset: 0xBD6BA0   Length: 0x53
    public bool HaveKey(string key)
    {
        if (this.plotEventLogData != null) {
          FUN_1808ab750(this.plotEventLogData,key,DAT_181d4f858);
          return;
        }
    }

    // Token : 0x6000E7B
    // RVA   : 0xBD8630   Offset: 0xBD6E30   Length: 0x1D8
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
          lVar2 = Dictionary_2.get_Keys(this.plotEventLogData,DAT_181d4fb58);
          if (lVar2 != null) {
            ValueCollection.GetEnumerator(&local_28,lVar2,DAT_181d9f078);
            local_40 = local_28;
            uStack_3c = uStack_24;
            uStack_38 = uStack_20;
            uStack_34 = uStack_1c;
            local_30 = local_18;
            do {
              cVar1 = FUN_1811d5c70(&local_40,DAT_181d7afa8);
              if (!cVar1) {
                aiStack_54[1] = 70;
                iVar3 = aiStack_54[3] + 1;
                aiStack_54[3] = iVar3;
                ZhSegment.Initialize(&local_40,DAT_181d7af28);
                goto LAB_180bd87bd;
              }
              if (this.plotEventLogData == null) {
                          // WARNING: Subroutine does not return
                FUN_1800d6620();
              }
              lVar2 = FUN_1817897a0(this.plotEventLogData,local_30,DAT_181d4fad8);
            } while (lVar2 == null);
            aiStack_54[1] = 72;
            iVar3 = aiStack_54[3] + 1;
            aiStack_54[3] = iVar3;
            ZhSegment.Initialize(&local_40,DAT_181d7af28);
        LAB_180bd87bd:
            if ((iVar3 != 0) && (aiStack_54[iVar3] == 72)) {
              return false;
            }
            return true;
          }
        }
    }

    // Token : 0x6000E7C
    // RVA   : 0xBD7FF0   Offset: 0xBD67F0   Length: 0x175
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
        plVar1 = (int64 *)il2cpp_internal(DAT_181d63ff0);
        plVar4 = plVar1;
        MemoryStream.ctor(plVar1,1000,0);
        local_38 = 0;
        uStack_30 = 0;
        StreamingContext.ctor(&local_38,64,0);
        lVar2 = il2cpp_internal(DAT_181d8c5a8);
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
            FUN_180002970(0,DAT_181d53c70,plVar1);
            return uVar3;
          }
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
    }

}
