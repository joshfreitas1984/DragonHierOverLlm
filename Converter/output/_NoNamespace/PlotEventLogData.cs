// ============================================================
// Type  : PlotEventLogData
// Token : 0x20001CE
// ============================================================

public class PlotEventLogData
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4000C75
    public Dictionary<string, string> plotEventLogData;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000EAE
    // RVA   : 0x8AF520   Offset: 0x8AE320   Length: 0x76
    public void /*ctor*/()
    {
        ulong uVar1;
        ZhSegment.Initialize(this,0);
        uVar1 = il2cpp_internal(DAT_181e631c0);
        FUN_1806e5bc0(uVar1,DAT_181e56ab0);
        this.plotEventLogData = uVar1;
    }

    // Token : 0x6000EAF
    // RVA   : 0x8AF370   Offset: 0x8AE170   Length: 0x94
    public void Reset()
    {
        ulong uVar1;
        if (this.plotEventLogData != null) {
          Dictionary_2.Clear(this.plotEventLogData,DAT_181e56cd0);
          return;
        }
        uVar1 = il2cpp_internal(DAT_181e631c0);
        FUN_1806e5bc0(uVar1,DAT_181e56ab0);
        this.plotEventLogData = uVar1;
    }

    // Token : 0x6000EB0
    // RVA   : 0x8AF410   Offset: 0x8AE210   Length: 0x10A
    public PlotEventLogData Set(string key, string value)
    {
        long lVar1;
        bool cVar2;
        if (this.plotEventLogData != null) {
          cVar2 = FUN_1806da450(this.plotEventLogData,key,DAT_181e56d58);
          if (!cVar2) {
            if (value == null) {
              return this;
            }
            if (this.plotEventLogData != null) {
              FUN_1806da2f0(this.plotEventLogData,key,value,DAT_181e56c48);
              return this;
            }
          }
          else {
            lVar1 = this.plotEventLogData;
            if (value == null) {
              if (lVar1 != null) {
                FUN_1816f8d70(lVar1,key,DAT_181e56e68);
                return this;
              }
            }
            else if (lVar1 != null) {
              FUN_1806e7630(lVar1,key,value,DAT_181e57110);
              return this;
            }
          }
        }
    }

    // Token : 0x6000EB1
    // RVA   : 0x8AF290   Offset: 0x8AE090   Length: 0x78
    public string Get(string key)
    {
        bool cVar1;
        ulong local_res8;
        local_res8 = 0;
        if (this.plotEventLogData != null) {
          cVar1 = FUN_1806e3f90(this.plotEventLogData,key,&local_res8,DAT_181e56ef0);
          if (!cVar1) {
            local_res8 = 0;
          }
          return local_res8;
        }
    }

    // Token : 0x6000EB2
    // RVA   : 0x8AF1B0   Offset: 0x8ADFB0   Length: 0x7F
    public int GetInt(string key)
    {
        bool cVar1;
        ulong uVar2;
        ulong local_res8;
        local_res8 = 0;
        if (this.plotEventLogData != null) {
          cVar1 = FUN_1806e3f90(this.plotEventLogData,key,&local_res8,DAT_181e56ef0);
          if (!cVar1) {
            return 0;
          }
          uVar2 = Int32.Parse(local_res8,0);
          return uVar2;
        }
    }

    // Token : 0x6000EB3
    // RVA   : 0x8AF120   Offset: 0x8ADF20   Length: 0x80
    public float GetFloat(string key)
    {
        bool cVar1;
        ulong uVar2;
        ulong local_res8;
        local_res8 = 0;
        if (this.plotEventLogData != null) {
          cVar1 = FUN_1806e3f90(this.plotEventLogData,key,&local_res8,DAT_181e56ef0);
          if (!cVar1) {
            return 0;
          }
          uVar2 = Single.Parse(local_res8,0);
          return uVar2;
        }
    }

    // Token : 0x6000EB4
    // RVA   : 0x8AF230   Offset: 0x8AE030   Length: 0x5F
    public List<string> GetKeys()
    {
        ulong uVar1;
        if (this.plotEventLogData != null) {
          uVar1 = Dictionary_2.get_Keys(this.plotEventLogData,DAT_181e57088);
          Enumerable.ToList(uVar1,DAT_181e98f58);
          return;
        }
    }

    // Token : 0x6000EB5
    // RVA   : 0x8AF310   Offset: 0x8AE110   Length: 0x53
    public bool HaveKey(string key)
    {
        if (this.plotEventLogData != null) {
          FUN_1806da450(this.plotEventLogData,key,DAT_181e56d58);
          return;
        }
    }

    // Token : 0x6000EB6
    // RVA   : 0x8AF5A0   Offset: 0x8AE3A0   Length: 0x1D8
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
          lVar2 = Dictionary_2.get_Keys(this.plotEventLogData,DAT_181e57088);
          if (lVar2 != null) {
            ValueCollection.GetEnumerator(&local_28,lVar2,DAT_181e50f80);
            local_40 = local_28;
            uStack_3c = uStack_24;
            uStack_38 = uStack_20;
            uStack_34 = uStack_1c;
            local_30 = local_18;
            do {
              cVar1 = FUN_180fe59f0(&local_40,DAT_181e83a80);
              if (!cVar1) {
                aiStack_54[1] = 70;
                iVar3 = aiStack_54[3] + 1;
                aiStack_54[3] = iVar3;
                ZhSegment.Initialize(&local_40,DAT_181e83a00);
                goto LAB_1808af72d;
              }
              if (this.plotEventLogData == null) {
                          // WARNING: Subroutine does not return
                FUN_1801e0300();
              }
              lVar2 = FUN_1817072e0(this.plotEventLogData,local_30,DAT_181e57000);
            } while (lVar2 == null);
            aiStack_54[1] = 72;
            iVar3 = aiStack_54[3] + 1;
            aiStack_54[3] = iVar3;
            ZhSegment.Initialize(&local_40,DAT_181e83a00);
        LAB_1808af72d:
            if ((iVar3 != 0) && (aiStack_54[iVar3] == 72)) {
              return false;
            }
            return true;
          }
        }
    }

    // Token : 0x6000EB7
    // RVA   : 0x8AEFA0   Offset: 0x8ADDA0   Length: 0x175
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
        plVar1 = (int64 *)il2cpp_internal(DAT_181e695f0);
        plVar4 = plVar1;
        MemoryStream.ctor(plVar1,1000,0);
        local_38 = 0;
        uStack_30 = 0;
        StreamingContext.ctor(&local_38,64,0);
        lVar2 = il2cpp_internal(DAT_181e91a00);
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
            FUN_180002280(0,DAT_181e58ab8,plVar1);
            return uVar3;
          }
                          // WARNING: Subroutine does not return
          FUN_1801e0300();
        }
    }

}
