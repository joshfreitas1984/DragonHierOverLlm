// ============================================================
// Type  : PlayerPrefDictionary
// Token : 0x20001CC
// ============================================================

public class PlayerPrefDictionary
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4000C72
    public List<PlayerPrefDictionaryCell> playerPrefDictionary;

    // Token: 0x4000C73
    private Dictionary<string, PlayerPrefDictionaryCell> keyIndex;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000EA1
    // RVA   : 0x212600   Offset: 0x211400   Length: 0x1C5
    private Dictionary<string, PlayerPrefDictionaryCell> get_Index()
    {
        uint uVar1;
        bool cVar2;
        ulong uVar3;
        long lVar4;
        long lVar5;
        uint uVar6;
        if (this.keyIndex != null) {
        LAB_1802127a1:
          return this.keyIndex;
        }
        lVar4 = this.playerPrefDictionary;
        if (lVar4 == null) {
          uVar3 = il2cpp_internal(DAT_181e751b8);
          FUN_1810f3480(uVar3,DAT_181e79160);
          this.playerPrefDictionary = uVar3;
          lVar4 = this.playerPrefDictionary;
          if (lVar4 == null) throw; // [null/range check failed]
        }
        uVar1 = lVar4.Count;
        uVar3 = il2cpp_internal(DAT_181e62d40);
        FUN_1806e5e00(uVar3,uVar1,DAT_181e558a0);
        this.keyIndex = uVar3;
        lVar4 = this.playerPrefDictionary;
        uVar6 = 0;
        if (lVar4 != null) {
          lVar5 = 32;
          do {
            if (lVar4.Count <= (int)uVar6) goto LAB_1802127a1;
            if (lVar4 == null) break;
            if (lVar4.Count <= uVar6) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            lVar4 = *(int64 *)(lVar5 + lVar4._items);
            if ((lVar4 != null) && (lVar4._items != null)) {
              if (this.keyIndex == null) break;
              cVar2 = FUN_1806da450(this.keyIndex,lVar4._items,
                                    DAT_181e55a38);
              if (!cVar2) {
                if (this.keyIndex == null) break;
                FUN_1806da2f0(this.keyIndex,lVar4._items,lVar4,
                              DAT_181e55928);
              }
            }
            lVar4 = this.playerPrefDictionary;
            uVar6 = uVar6 + 1;
            lVar5 = lVar5 + 8;
          } while (lVar4 != null);
        }
    }

    // Token : 0x6000EA2
    // RVA   : 0x2120A0   Offset: 0x210EA0   Length: 0x12
    public void RebuildIndex()
    {
        void FUN_1802120a0(int64 this)
        {
        this.keyIndex = 0;
    }

    // Token : 0x6000EA3
    // RVA   : 0x211EB0   Offset: 0x210CB0   Length: 0x97
    public float GetFloat(string key)
    {
        bool cVar1;
        long lVar2;
        ulong uVar3;
        long[] local_res10 = new long[3];
        local_res10[0] = 0;
        if (key == null) {
          return 0;
        }
        lVar2 = PlayerPrefDictionary.get_Index(this,0);
        if (lVar2 != null) {
          cVar1 = FUN_1806e3f90(lVar2,key,local_res10,DAT_181e55b48);
          if (!cVar1) {
            return 0;
          }
          if (local_res10[0] != 0) {
            uVar3 = Single.Parse(*(uint64 *)(local_res10[0] + 24),0);
            return uVar3;
          }
        }
    }

    // Token : 0x6000EA4
    // RVA   : 0x211F50   Offset: 0x210D50   Length: 0x96
    public int GetInt(string key)
    {
        bool cVar1;
        long lVar2;
        ulong uVar3;
        long[] local_res10 = new long[3];
        local_res10[0] = 0;
        if (key == null) {
          return 0;
        }
        lVar2 = PlayerPrefDictionary.get_Index(this,0);
        if (lVar2 != null) {
          cVar1 = FUN_1806e3f90(lVar2,key,local_res10,DAT_181e55b48);
          if (!cVar1) {
            return 0;
          }
          if (local_res10[0] != 0) {
            uVar3 = Int32.Parse(*(uint64 *)(local_res10[0] + 24),0);
            return uVar3;
          }
        }
    }

    // Token : 0x6000EA5
    // RVA   : 0x211FF0   Offset: 0x210DF0   Length: 0xA0
    public string GetString(string key)
    {
        bool cVar1;
        long lVar2;
        long[] local_res10 = new long[3];
        local_res10[0] = 0;
        if (key == null) {
          return "";
        }
        lVar2 = PlayerPrefDictionary.get_Index(this,0);
        if (lVar2 != null) {
          cVar1 = FUN_1806e3f90(lVar2,key,local_res10,DAT_181e55b48);
          if (!cVar1) {
            return "";
          }
          if (local_res10[0] != 0) {
            return *(uint64 *)(local_res10[0] + 24);
          }
        }
    }

    // Token : 0x6000EA6
    // RVA   : 0x212180   Offset: 0x210F80   Length: 0x15C
    public void SetKey(string key, float value)
    {
        bool cVar1;
        long lVar2;
        long local_res10;
        local_res10 = 0;
        lVar2 = PlayerPrefDictionary.get_Index(this,0);
        if (lVar2 != null) {
          cVar1 = FUN_1806e3f90(lVar2,key,&local_res10,DAT_181e55b48);
          if (!cVar1) {
            lVar2 = new ZhSegment(0);
            *(uint64 *)(lVar2 + 16) = key;
            *(uint64 *)(lVar2 + 24) = value;
            local_res10 = lVar2;
            if (this.playerPrefDictionary != null) {
              FUN_18175de30(this.playerPrefDictionary,lVar2,DAT_181e791e0);
              if (this.keyIndex != null) {
                FUN_1806da2f0(this.keyIndex,key,local_res10,DAT_181e55928);
                return;
              }
            }
          }
          else if (local_res10 != 0) {
            *(uint64 *)(local_res10 + 24) = value;
            return;
          }
        }
    }

    // Token : 0x6000EA7
    // RVA   : 0x212420   Offset: 0x211220   Length: 0x15B
    public void SetKey(string key, int value)
    {
        bool cVar1;
        long lVar2;
        long local_res10;
        local_res10 = 0;
        lVar2 = PlayerPrefDictionary.get_Index(this,0);
        if (lVar2 != null) {
          cVar1 = FUN_1806e3f90(lVar2,key,&local_res10,DAT_181e55b48);
          if (!cVar1) {
            lVar2 = new ZhSegment(0);
            *(uint64 *)(lVar2 + 16) = key;
            *(uint64 *)(lVar2 + 24) = value;
            local_res10 = lVar2;
            if (this.playerPrefDictionary != null) {
              FUN_18175de30(this.playerPrefDictionary,lVar2,DAT_181e791e0);
              if (this.keyIndex != null) {
                FUN_1806da2f0(this.keyIndex,key,local_res10,DAT_181e55928);
                return;
              }
            }
          }
          else if (local_res10 != 0) {
            *(uint64 *)(local_res10 + 24) = value;
            return;
          }
        }
    }

    // Token : 0x6000EA8
    // RVA   : 0x2122E0   Offset: 0x2110E0   Length: 0x13E
    public void SetKey(string key, string value)
    {
        bool cVar1;
        long lVar2;
        long local_res10;
        local_res10 = 0;
        lVar2 = PlayerPrefDictionary.get_Index(this,0);
        if (lVar2 != null) {
          cVar1 = FUN_1806e3f90(lVar2,key,&local_res10,DAT_181e55b48);
          if (!cVar1) {
            lVar2 = new ZhSegment(0);
            *(uint64 *)(lVar2 + 16) = key;
            *(uint64 *)(lVar2 + 24) = value;
            local_res10 = lVar2;
            if (this.playerPrefDictionary != null) {
              FUN_18175de30(this.playerPrefDictionary,lVar2,DAT_181e791e0);
              if (this.keyIndex != null) {
                FUN_1806da2f0(this.keyIndex,key,local_res10,DAT_181e55928);
                return;
              }
            }
          }
          else if (local_res10 != 0) {
            *(uint64 *)(local_res10 + 24) = value;
            return;
          }
        }
    }

    // Token : 0x6000EA9
    // RVA   : 0x211E40   Offset: 0x210C40   Length: 0x6E
    public bool ContainsKey(string key)
    {
        byte uVar1;
        long lVar2;
        if (key == null) {
          return false;
        }
        lVar2 = PlayerPrefDictionary.get_Index(this,0);
        if (lVar2 != null) {
          uVar1 = FUN_1806da450(lVar2,key,DAT_181e55a38);
          return uVar1;
        }
    }

    // Token : 0x6000EAA
    // RVA   : 0x2120C0   Offset: 0x210EC0   Length: 0xBE
    public void RemoveKey(string key)
    {
        bool cVar1;
        long lVar2;
        ulong[] local_res10 = new ulong[3];
        local_res10[0] = 0;
        if (key == null) {
          return;
        }
        lVar2 = PlayerPrefDictionary.get_Index(this,0);
        if (lVar2 != null) {
          cVar1 = FUN_1806e3f90(lVar2,key,local_res10,DAT_181e55b48);
          if (!cVar1) {
            return;
          }
          if (this.keyIndex != null) {
            FUN_1816f8d70(this.keyIndex,key,DAT_181e55ac0);
            if (this.playerPrefDictionary != null) {
              FUN_181665e90(this.playerPrefDictionary,local_res10[0],DAT_181e792e0);
              return;
            }
          }
        }
    }

    // Token : 0x6000EAB
    // RVA   : 0x211DD0   Offset: 0x210BD0   Length: 0x6B
    public void Clear()
    {
        if (this.playerPrefDictionary != null) {
          FUN_18115d8f0(this.playerPrefDictionary,DAT_181e79260);
          if (this.keyIndex != null) {
            Dictionary_2.Clear(this.keyIndex,DAT_181e559b0);
            return;
          }
          return;
        }
    }

    // Token : 0x6000EAC
    // RVA   : 0x212580   Offset: 0x211380   Length: 0x76
    public void /*ctor*/()
    {
        ulong uVar1;
        ZhSegment.Initialize(this,0);
        uVar1 = il2cpp_internal(DAT_181e751b8);
        FUN_1810f3480(uVar1,DAT_181e79160);
        this.playerPrefDictionary = uVar1;
    }

}
