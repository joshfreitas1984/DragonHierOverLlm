// ============================================================
// Type  : PlayerPrefDictionary
// Token : 0x20001C4
// ============================================================

public class PlayerPrefDictionary
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4000BD3
    public List<PlayerPrefDictionaryCell> playerPrefDictionary;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000E68
    // RVA   : 0x479750   Offset: 0x477F50   Length: 0xFC
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
            cVar1 = FUN_1816fd990(lVar2._items,key,0);
            lVar2 = this.playerPrefDictionary;
            if (cVar1) {
              if ((lVar2 != null) && (lVar2 = FUN_180002f80(lVar2,uVar4,DAT_181d6f6e8)) != null) {
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

    // Token : 0x6000E69
    // RVA   : 0x479850   Offset: 0x478050   Length: 0xFB
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
            cVar1 = FUN_1816fd990(lVar2._items,key,0);
            lVar2 = this.playerPrefDictionary;
            if (cVar1) {
              if ((lVar2 != null) && (lVar2 = FUN_180002f80(lVar2,uVar5,DAT_181d6f6e8)) != null) {
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

    // Token : 0x6000E6A
    // RVA   : 0x479950   Offset: 0x478150   Length: 0x109
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
            cVar1 = FUN_1816fd990(lVar2._items,key,0);
            lVar2 = this.playerPrefDictionary;
            if (cVar1) {
              if ((lVar2 != null) && (lVar2 = FUN_180002f80(lVar2,uVar4,DAT_181d6f6e8)) != null) {
                return lVar2.Count;
              }
              break;
            }
            uVar4 = uVar4 + 1;
            lVar3 = lVar3 + 8;
          } while (lVar2 != null);
        }
    }

    // Token : 0x6000E6B
    // RVA   : 0x479B70   Offset: 0x478370   Length: 0x186
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
                FUN_181827900(lVar2,lVar3,DAT_181d6f4e8);
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
            cVar1 = FUN_1816fd990(lVar2._items,key,0);
            lVar2 = this.playerPrefDictionary;
            if (cVar1) {
              if ((lVar2 != null) && (lVar2 = FUN_180002f80(lVar2,uVar4,DAT_181d6f6e8)) != null) {
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

    // Token : 0x6000E6C
    // RVA   : 0x479E80   Offset: 0x478680   Length: 0x185
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
                FUN_181827900(lVar2,lVar3,DAT_181d6f4e8);
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
            cVar1 = FUN_1816fd990(lVar2._items,key,0);
            lVar2 = this.playerPrefDictionary;
            if (cVar1) {
              if ((lVar2 != null) && (lVar2 = FUN_180002f80(lVar2,uVar4,DAT_181d6f6e8)) != null) {
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

    // Token : 0x6000E6D
    // RVA   : 0x479D00   Offset: 0x478500   Length: 0x175
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
                FUN_181827900(lVar2,lVar3,DAT_181d6f4e8);
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
            cVar1 = FUN_1816fd990(lVar2._items,key,0);
            lVar2 = this.playerPrefDictionary;
            if (cVar1) {
              if ((lVar2 != null) && (lVar2 = FUN_180002f80(lVar2,uVar4,DAT_181d6f6e8)) != null) {
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

    // Token : 0x6000E6E
    // RVA   : 0x479670   Offset: 0x477E70   Length: 0xD2
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
            cVar1 = FUN_1816fd990(lVar2._items,key,0);
            if (cVar1) {
              return true;
            }
            lVar2 = this.playerPrefDictionary;
            uVar4 = uVar4 + 1;
            lVar3 = lVar3 + 8;
          } while (lVar2 != null);
        }
    }

    // Token : 0x6000E6F
    // RVA   : 0x479A60   Offset: 0x478260   Length: 0x105
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
            cVar1 = FUN_1816fd990(lVar3._items,key,0);
            lVar3 = this.playerPrefDictionary;
            if (cVar1) {
              if (lVar3 != null) {
                uVar2 = FUN_180002f80(lVar3,uVar4,DAT_181d6f6e8);
                FUN_181801c10(lVar3,uVar2,DAT_181d6f5e8);
                return;
              }
              break;
            }
            uVar4 = uVar4 + 1;
            lVar5 = lVar5 + 8;
          } while (lVar3 != null);
        }
    }

    // Token : 0x6000E70
    // RVA   : 0x479620   Offset: 0x477E20   Length: 0x44
    public void Clear()
    {
        if (this.playerPrefDictionary != null) {
          FUN_180f56130(this.playerPrefDictionary,DAT_181d6f568);
          return;
        }
    }

    // Token : 0x6000E71
    // RVA   : 0x47A010   Offset: 0x478810   Length: 0x76
    public void /*ctor*/()
    {
        ulong uVar1;
        ZhSegment.Initialize(this,0);
        uVar1 = il2cpp_internal(DAT_181d704b0);
        FUN_180f58a90(uVar1,DAT_181d6f468);
        this.playerPrefDictionary = uVar1;
    }

}
