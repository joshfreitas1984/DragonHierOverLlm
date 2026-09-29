// ============================================================
// Type  : PlayerPrefDictionary
// Token : 0x20001CA
// ============================================================

public class PlayerPrefDictionary
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4000C60
    public List<PlayerPrefDictionaryCell> playerPrefDictionary;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000E9D
    // RVA   : 0x46D820   Offset: 0x46CC20   Length: 0xFC
    public float GetFloat(string key)
    {
        bool cVar1;
        long lVar2;
        long lVar3;
        uint uVar4;
        ulong uVar5;
        lVar2 = this.playerPrefDictionary;
        uVar4 = 0;
        if (lVar2 != null) {
          lVar3 = 32;
          do {
            if (lVar2.Count <= (int)uVar4) {
              return 0;
            }
            if (lVar2 == null) break;
            if (lVar2.Count <= uVar4) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            lVar2 = *(int64 *)(lVar3 + lVar2._items);
            if (lVar2 == null) break;
            cVar1 = FUN_18171eb50(lVar2._items,key,0);
            lVar2 = this.playerPrefDictionary;
            if (cVar1) {
              if ((lVar2 != null) && (lVar2 = FUN_180002f80(lVar2,uVar4,DAT_181d970a0)) != null) {
                uVar5 = Single.Parse(lVar2.Count,0);
                return uVar5;
              }
              break;
            }
            uVar4 = uVar4 + 1;
            lVar3 = lVar3 + 8;
          } while (lVar2 != null);
        }
    }

    // Token : 0x6000E9E
    // RVA   : 0x46D920   Offset: 0x46CD20   Length: 0xFB
    public int GetInt(string key)
    {
        bool cVar1;
        long lVar2;
        ulong uVar3;
        long lVar4;
        uint uVar5;
        lVar2 = this.playerPrefDictionary;
        uVar5 = 0;
        if (lVar2 != null) {
          lVar4 = 32;
          do {
            if (lVar2.Count <= (int)uVar5) {
              return 0;
            }
            if (lVar2 == null) break;
            if (lVar2.Count <= uVar5) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            lVar2 = *(int64 *)(lVar4 + lVar2._items);
            if (lVar2 == null) break;
            cVar1 = FUN_18171eb50(lVar2._items,key,0);
            lVar2 = this.playerPrefDictionary;
            if (cVar1) {
              if ((lVar2 != null) && (lVar2 = FUN_180002f80(lVar2,uVar5,DAT_181d970a0)) != null) {
                uVar3 = Int32.Parse(lVar2.Count,0);
                return uVar3;
              }
              break;
            }
            uVar5 = uVar5 + 1;
            lVar4 = lVar4 + 8;
          } while (lVar2 != null);
        }
    }

    // Token : 0x6000E9F
    // RVA   : 0x46DA20   Offset: 0x46CE20   Length: 0x109
    public string GetString(string key)
    {
        bool cVar1;
        long lVar2;
        long lVar3;
        uint uVar4;
        lVar2 = this.playerPrefDictionary;
        uVar4 = 0;
        if (lVar2 != null) {
          lVar3 = 32;
          do {
            if (lVar2.Count <= (int)uVar4) {
              return "";
            }
            if (lVar2 == null) break;
            if (lVar2.Count <= uVar4) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            lVar2 = *(int64 *)(lVar3 + lVar2._items);
            if (lVar2 == null) break;
            cVar1 = FUN_18171eb50(lVar2._items,key,0);
            lVar2 = this.playerPrefDictionary;
            if (cVar1) {
              if ((lVar2 != null) && (lVar2 = FUN_180002f80(lVar2,uVar4,DAT_181d970a0)) != null) {
                return lVar2.Count;
              }
              break;
            }
            uVar4 = uVar4 + 1;
            lVar3 = lVar3 + 8;
          } while (lVar2 != null);
        }
    }

    // Token : 0x6000EA0
    // RVA   : 0x46DC40   Offset: 0x46D040   Length: 0x186
    public void SetKey(string key, float value)
    {
        bool cVar1;
        long lVar2;
        long lVar3;
        uint uVar4;
        lVar2 = this.playerPrefDictionary;
        uVar4 = 0;
        if (lVar2 != null) {
          lVar3 = 32;
          do {
            if (lVar2.Count <= (int)uVar4) {
              lVar3 = new ZhSegment(0);
              *(uint64 *)(lVar3 + 16) = key;
              *(uint64 *)(lVar3 + 24) = value;
              if (lVar2 != null) {
                FUN_18181e6b0(lVar2,lVar3,DAT_181d96ea0);
                return;
              }
              break;
            }
            if (lVar2 == null) break;
            if (lVar2.Count <= uVar4) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            lVar2 = *(int64 *)(lVar3 + lVar2._items);
            if (lVar2 == null) break;
            cVar1 = FUN_18171eb50(lVar2._items,key,0);
            lVar2 = this.playerPrefDictionary;
            if (cVar1) {
              if ((lVar2 != null) && (lVar2 = FUN_180002f80(lVar2,uVar4,DAT_181d970a0)) != null) {
                lVar2.Count = value;
                return;
              }
              break;
            }
            uVar4 = uVar4 + 1;
            lVar3 = lVar3 + 8;
          } while (lVar2 != null);
        }
    }

    // Token : 0x6000EA1
    // RVA   : 0x46DF50   Offset: 0x46D350   Length: 0x185
    public void SetKey(string key, int value)
    {
        bool cVar1;
        long lVar2;
        long lVar3;
        uint uVar4;
        lVar2 = this.playerPrefDictionary;
        uVar4 = 0;
        if (lVar2 != null) {
          lVar3 = 32;
          do {
            if (lVar2.Count <= (int)uVar4) {
              lVar3 = new ZhSegment(0);
              *(uint64 *)(lVar3 + 16) = key;
              *(uint64 *)(lVar3 + 24) = value;
              if (lVar2 != null) {
                FUN_18181e6b0(lVar2,lVar3,DAT_181d96ea0);
                return;
              }
              break;
            }
            if (lVar2 == null) break;
            if (lVar2.Count <= uVar4) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            lVar2 = *(int64 *)(lVar3 + lVar2._items);
            if (lVar2 == null) break;
            cVar1 = FUN_18171eb50(lVar2._items,key,0);
            lVar2 = this.playerPrefDictionary;
            if (cVar1) {
              if ((lVar2 != null) && (lVar2 = FUN_180002f80(lVar2,uVar4,DAT_181d970a0)) != null) {
                lVar2.Count = value;
                return;
              }
              break;
            }
            uVar4 = uVar4 + 1;
            lVar3 = lVar3 + 8;
          } while (lVar2 != null);
        }
    }

    // Token : 0x6000EA2
    // RVA   : 0x46DDD0   Offset: 0x46D1D0   Length: 0x175
    public void SetKey(string key, string value)
    {
        bool cVar1;
        long lVar2;
        long lVar3;
        uint uVar4;
        lVar2 = this.playerPrefDictionary;
        uVar4 = 0;
        if (lVar2 != null) {
          lVar3 = 32;
          do {
            if (lVar2.Count <= (int)uVar4) {
              lVar3 = new ZhSegment(0);
              *(uint64 *)(lVar3 + 16) = key;
              *(uint64 *)(lVar3 + 24) = value;
              if (lVar2 != null) {
                FUN_18181e6b0(lVar2,lVar3,DAT_181d96ea0);
                return;
              }
              break;
            }
            if (lVar2 == null) break;
            if (lVar2.Count <= uVar4) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            lVar2 = *(int64 *)(lVar3 + lVar2._items);
            if (lVar2 == null) break;
            cVar1 = FUN_18171eb50(lVar2._items,key,0);
            lVar2 = this.playerPrefDictionary;
            if (cVar1) {
              if ((lVar2 != null) && (lVar2 = FUN_180002f80(lVar2,uVar4,DAT_181d970a0)) != null) {
                lVar2.Count = value;
                return;
              }
              break;
            }
            uVar4 = uVar4 + 1;
            lVar3 = lVar3 + 8;
          } while (lVar2 != null);
        }
    }

    // Token : 0x6000EA3
    // RVA   : 0x46D740   Offset: 0x46CB40   Length: 0xD2
    public bool ContainsKey(string key)
    {
        bool cVar1;
        long lVar2;
        long lVar3;
        uint uVar4;
        lVar2 = this.playerPrefDictionary;
        uVar4 = 0;
        if (lVar2 != null) {
          lVar3 = 32;
          do {
            if (lVar2.Count <= (int)uVar4) {
              return false;
            }
            if (lVar2 == null) break;
            if (lVar2.Count <= uVar4) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            lVar2 = *(int64 *)(lVar3 + lVar2._items);
            if (lVar2 == null) break;
            cVar1 = FUN_18171eb50(lVar2._items,key,0);
            if (cVar1) {
              return true;
            }
            lVar2 = this.playerPrefDictionary;
            uVar4 = uVar4 + 1;
            lVar3 = lVar3 + 8;
          } while (lVar2 != null);
        }
    }

    // Token : 0x6000EA4
    // RVA   : 0x46DB30   Offset: 0x46CF30   Length: 0x105
    public void RemoveKey(string key)
    {
        bool cVar1;
        ulong uVar2;
        long lVar3;
        uint uVar4;
        long lVar5;
        lVar3 = this.playerPrefDictionary;
        uVar4 = 0;
        if (lVar3 != null) {
          lVar5 = 32;
          do {
            if (lVar3.Count <= (int)uVar4) {
              return;
            }
            if (lVar3 == null) break;
            if (lVar3.Count <= uVar4) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            lVar3 = *(int64 *)(lVar5 + lVar3._items);
            if (lVar3 == null) break;
            cVar1 = FUN_18171eb50(lVar3._items,key,0);
            lVar3 = this.playerPrefDictionary;
            if (cVar1) {
              if (lVar3 != null) {
                uVar2 = FUN_180002f80(lVar3,uVar4,DAT_181d970a0);
                FUN_1817ef410(lVar3,uVar2,DAT_181d96fa0);
                return;
              }
              break;
            }
            uVar4 = uVar4 + 1;
            lVar5 = lVar5 + 8;
          } while (lVar3 != null);
        }
    }

    // Token : 0x6000EA5
    // RVA   : 0x46D6F0   Offset: 0x46CAF0   Length: 0x44
    public void Clear()
    {
        if (this.playerPrefDictionary != null) {
          FUN_1812fa020(this.playerPrefDictionary,DAT_181d96f20);
          return;
        }
    }

    // Token : 0x6000EA6
    // RVA   : 0x46E0E0   Offset: 0x46D4E0   Length: 0x76
    public void /*ctor*/()
    {
        ulong uVar1;
        ZhSegment.Initialize(this,0);
        uVar1 = il2cpp_internal(DAT_181d951e8);
        FUN_181330100(uVar1,DAT_181d96e20);
        this.playerPrefDictionary = uVar1;
    }

}
