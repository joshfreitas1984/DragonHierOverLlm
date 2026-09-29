// ============================================================
// Type  : HeroLittleTalkController
// Token : 0x20002D0
// ============================================================

public class HeroLittleTalkController
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x400173D
    public GameObject heroLittleTalkPrefab;

    // Token: 0x400173E
    public GameObject heroLittleTalkPanel;

    // Token: 0x400173F
    public List<LittleTalkData> heroLittleTalkData;

    // Token: 0x4001740
    private GameObject newObj;

    // Token: 0x4001741
    private static HeroLittleTalkController _instance;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60017E2
    // RVA   : 0xAF8220   Offset: 0xAF7620   Length: 0x36
    public static HeroLittleTalkController get_Instance()
    {
        return **(uint64 **)(DAT_181d761e8 + 184);
    }

    // Token : 0x60017E3
    // RVA   : 0xAF71E0   Offset: 0xAF65E0   Length: 0xD7
    private void Awake()
    {
        bool cVar2;
        ulong uVar3;
        uVar3 = **(uint64 **)(DAT_181d761e8 + 184);
        cVar2 = Object.op_Equality(uVar3,0,0);
        if (!cVar2) {
          uVar3 = Component.get_gameObject(this,0);
          Object.Destroy(uVar3,0);
          return;
        }
        puVar1 = *(uint64 **)(DAT_181d761e8 + 184);
        *puVar1 = this;
        il2cpp_internal(puVar1,this);
    }

    // Token : 0x60017E4
    // RVA   : 0xAF73F0   Offset: 0xAF67F0   Length: 0x108
    public GameObject HeroTalk(GameObject target, string talkText)
    {
        uint64
        HeroLittleTalkController.HeroTalk
                (int64 this,int64 target,uint64 talkText,uint32 param_4,int param_5,
                int64 param_6,int param_7)
        {
        float fVar1;
        char cVar2;
        int64 lVar3;
        float *pfVar4;
        uint64 uVar5;
        uint64 uVar6;
        int64 lVar7;
        uint64 *puVar8;
        uint32 uVar9;
        bool bVar10;
        uint64 local_58;
        uint32 local_50;
        uint8 local_48 [32];
        uVar9 = 0;
        if (param_7 == 2) {
          if ((target == null) || (lVar3 = GameObject.get_transform(target,0)) == null)
          throw; // [null/range check failed]
          pfVar4 = (float *)Transform.get_position(&local_58,lVar3,0);
          fVar1 = *pfVar4;
          bVar10 = 0.0 < *pfVar4;
        LAB_180af78ba:
          param_7 = 1;
          if (!bVar10 && fVar1 != 0.0) {
            param_7 = 0;
          }
        }
        else if (param_7 == 3) {
          if ((target == null) || (lVar3 = GameObject.get_transform(target,0)) == null)
          throw; // [null/range check failed]
          pfVar4 = (float *)Transform.get_position(&local_58,lVar3,0);
          fVar1 = *pfVar4;
          bVar10 = fVar1 < 0.0;
          goto LAB_180af78ba;
        }
        cVar2 = Object.op_Equality(param_6,0,0);
        if (cVar2) {
          param_6 = target;
        }
        uVar5 = this.heroLittleTalkPrefab;
        uVar5 = GlobalData.AddChild(param_6,uVar5,0);
        this.newObj = uVar5;
        if ((((this.newObj == null) ||
             (lVar3 = GameObject.get_transform(this.newObj,0)) == null) ||
            (lVar3 = Transform.Find(lVar3,"Back",0)) == null) ||
           (lVar3 = Transform.Find(lVar3,"Text",0)) == null) throw; // [null/range check failed]
        uVar5 = Component.GetComponent(lVar3,DAT_181d96178);
        uVar6 = GlobalData.ReplaceSpeString(talkText,param_5,0);
        LTLocalization.SetText(uVar5,uVar6,0);
        if (-1 < param_5) {
          if ((GameController._instance == null) ||
             (lVar3 = GameController._instance.worldData) == null)
          throw; // [null/range check failed]
          lVar3 = WorldData.GetHero(lVar3,param_5,0);
          if ((((GameController._instance == null) ||
               (lVar7 = GameController._instance.worldData) == null) ||
              (lVar7 = WorldData.GetHero(lVar7,param_5,0)) == null) ||
             (uVar5 = HeroData.GetHeroLittleTalkSound(lVar7,0), lVar3 == null)) throw; // [null/range check failed]
          HeroData.PlayHeroSound(lVar3,uVar5,0x3f800000,0xbf800000,0);
        }
        if ((this.newObj != null) &&
           (lVar3 = GameObject.GetComponent(this.newObj,DAT_181d71c60)) != null) {
          lVar3.Count = target;
          if ((this.newObj != null) &&
             (lVar3 = GameObject.GetComponent(this.newObj,DAT_181d71c60)) != null)
          {
            *(int *)(lVar3 + 44) = param_7;
            if ((this.newObj != null) &&
               (lVar3 = GameObject.GetComponent(this.newObj,DAT_181d71c60)) != null
               ) {
              lVar3.Areas = param_4;
              if (this.newObj != null) {
                lVar3 = GameObject.get_transform(this.newObj,0);
                puVar8 = (uint64 *)Vector3.get_zero(local_48,0);
                if (lVar3 != null) {
                  local_50 = *(uint32 *)(puVar8 + 1);
                  local_58 = *puVar8;
                  Transform.set_localScale(lVar3,&local_58,0);
                  if (this.newObj != null) {
                    uVar5 = GameObject.get_transform(this.newObj,0);
                    puVar8 = (uint64 *)Vector3.get_one(local_48,0);
                    local_50 = *(uint32 *)(puVar8 + 1);
                    local_58 = *puVar8;
                    uVar5 = ShortcutExtensions.DOScale(uVar5,&local_58,0x3e800000,0);
                    uVar5 = TweenSettingsExtensions.SetEase(uVar5,8,DAT_181dc1128);
                    TweenSettingsExtensions.SetUpdate(uVar5,1,DAT_181dc1f60);
                    lVar3 = this.heroLittleTalkData;
                    if (lVar3 != null) {
                      lVar7 = 32;
                      do {
                        if (lVar3.Count <= (int)uVar9) {
                          var uVar5 = new LittleTalkData(target,0);
                          if (lVar3 != null) {
                            FUN_18181e6b0(lVar3,uVar5,DAT_181d92d28);
                            lVar3 = this.heroLittleTalkData;
                            if (lVar3 != null) {
                              uVar9 = lVar3.Count;
                              if (uVar9 <= uVar9 - 1) {
                                ThrowHelper.ThrowArgumentOutOfRangeException(0);
                              }
                              lVar3 = *(int64 *)
                                       (lVar3._items + 24 + (int64)(int)uVar9 * 8);
                              if ((lVar3 = lVar3?.Count) != null) {
                                FUN_18181e6b0(lVar3,this.newObj,DAT_181d893b0);
                                return this.newObj;
                              }
                            }
                          }
                          break;
                        }
                        if (lVar3 == null) break;
                        if (lVar3.Count <= uVar9) {
                          ThrowHelper.ThrowArgumentOutOfRangeException(0);
                        }
                        lVar3 = *(int64 *)(lVar7 + lVar3._items);
                        if (lVar3 == null) break;
                        uVar5 = lVar3._items;
                        cVar2 = Object.op_Equality(uVar5,target);
                        lVar3 = this.heroLittleTalkData;
                        if (cVar2) {
                          if (((lVar3 != null) &&
                              (lVar3 = FUN_180002f80(lVar3,uVar9,DAT_181d92f28)) != null) &&
                             (lVar3.Count != null)) {
                            FUN_18181e6b0(lVar3.Count,this.newObj,
                                          DAT_181d893b0);
                            if (this.heroLittleTalkData != null) {
                              uVar5 = FUN_180002f80(this.heroLittleTalkData,uVar9,DAT_181d92f28);
                              uVar5 = HeroLittleTalkController.SortHeroLittleTalk(this,uVar5,0);
                              FUN_180d8c8f0(this,uVar5,0);
                              return this.newObj;
                            }
                          }
                          break;
                        }
                        uVar9 = uVar9 + 1;
                        lVar7 = lVar7 + 8;
                      } while (lVar3 != null);
                    }
                  }
                }
              }
            }
          }
        }
    }

    // Token : 0x60017E5
    // RVA   : 0xAF7500   Offset: 0xAF6900   Length: 0x110
    public GameObject HeroTalk(GameObject target, string talkText, float lifeTime)
    {
        uint64
        HeroLittleTalkController.HeroTalk
                (int64 this,int64 target,uint64 talkText,uint32 lifeTime,int param_5,
                int64 param_6,int param_7)
        {
        float fVar1;
        char cVar2;
        int64 lVar3;
        float *pfVar4;
        uint64 uVar5;
        uint64 uVar6;
        int64 lVar7;
        uint64 *puVar8;
        uint32 uVar9;
        bool bVar10;
        uint64 local_58;
        uint32 local_50;
        uint8 local_48 [32];
        uVar9 = 0;
        if (param_7 == 2) {
          if ((target == null) || (lVar3 = GameObject.get_transform(target,0)) == null)
          throw; // [null/range check failed]
          pfVar4 = (float *)Transform.get_position(&local_58,lVar3,0);
          fVar1 = *pfVar4;
          bVar10 = 0.0 < *pfVar4;
        LAB_180af78ba:
          param_7 = 1;
          if (!bVar10 && fVar1 != 0.0) {
            param_7 = 0;
          }
        }
        else if (param_7 == 3) {
          if ((target == null) || (lVar3 = GameObject.get_transform(target,0)) == null)
          throw; // [null/range check failed]
          pfVar4 = (float *)Transform.get_position(&local_58,lVar3,0);
          fVar1 = *pfVar4;
          bVar10 = fVar1 < 0.0;
          goto LAB_180af78ba;
        }
        cVar2 = Object.op_Equality(param_6,0,0);
        if (cVar2) {
          param_6 = target;
        }
        uVar5 = this.heroLittleTalkPrefab;
        uVar5 = GlobalData.AddChild(param_6,uVar5,0);
        this.newObj = uVar5;
        if ((((this.newObj == null) ||
             (lVar3 = GameObject.get_transform(this.newObj,0)) == null) ||
            (lVar3 = Transform.Find(lVar3,"Back",0)) == null) ||
           (lVar3 = Transform.Find(lVar3,"Text",0)) == null) throw; // [null/range check failed]
        uVar5 = Component.GetComponent(lVar3,DAT_181d96178);
        uVar6 = GlobalData.ReplaceSpeString(talkText,param_5,0);
        LTLocalization.SetText(uVar5,uVar6,0);
        if (-1 < param_5) {
          if ((GameController._instance == null) ||
             (lVar3 = GameController._instance.worldData) == null)
          throw; // [null/range check failed]
          lVar3 = WorldData.GetHero(lVar3,param_5,0);
          if ((((GameController._instance == null) ||
               (lVar7 = GameController._instance.worldData) == null) ||
              (lVar7 = WorldData.GetHero(lVar7,param_5,0)) == null) ||
             (uVar5 = HeroData.GetHeroLittleTalkSound(lVar7,0), lVar3 == null)) throw; // [null/range check failed]
          HeroData.PlayHeroSound(lVar3,uVar5,0x3f800000,0xbf800000,0);
        }
        if ((this.newObj != null) &&
           (lVar3 = GameObject.GetComponent(this.newObj,DAT_181d71c60)) != null) {
          lVar3.Count = target;
          if ((this.newObj != null) &&
             (lVar3 = GameObject.GetComponent(this.newObj,DAT_181d71c60)) != null)
          {
            *(int *)(lVar3 + 44) = param_7;
            if ((this.newObj != null) &&
               (lVar3 = GameObject.GetComponent(this.newObj,DAT_181d71c60)) != null
               ) {
              lVar3.Areas = lifeTime;
              if (this.newObj != null) {
                lVar3 = GameObject.get_transform(this.newObj,0);
                puVar8 = (uint64 *)Vector3.get_zero(local_48,0);
                if (lVar3 != null) {
                  local_50 = *(uint32 *)(puVar8 + 1);
                  local_58 = *puVar8;
                  Transform.set_localScale(lVar3,&local_58,0);
                  if (this.newObj != null) {
                    uVar5 = GameObject.get_transform(this.newObj,0);
                    puVar8 = (uint64 *)Vector3.get_one(local_48,0);
                    local_50 = *(uint32 *)(puVar8 + 1);
                    local_58 = *puVar8;
                    uVar5 = ShortcutExtensions.DOScale(uVar5,&local_58,0x3e800000,0);
                    uVar5 = TweenSettingsExtensions.SetEase(uVar5,8,DAT_181dc1128);
                    TweenSettingsExtensions.SetUpdate(uVar5,1,DAT_181dc1f60);
                    lVar3 = this.heroLittleTalkData;
                    if (lVar3 != null) {
                      lVar7 = 32;
                      do {
                        if (lVar3.Count <= (int)uVar9) {
                          var uVar5 = new LittleTalkData(target,0);
                          if (lVar3 != null) {
                            FUN_18181e6b0(lVar3,uVar5,DAT_181d92d28);
                            lVar3 = this.heroLittleTalkData;
                            if (lVar3 != null) {
                              uVar9 = lVar3.Count;
                              if (uVar9 <= uVar9 - 1) {
                                ThrowHelper.ThrowArgumentOutOfRangeException(0);
                              }
                              lVar3 = *(int64 *)
                                       (lVar3._items + 24 + (int64)(int)uVar9 * 8);
                              if ((lVar3 = lVar3?.Count) != null) {
                                FUN_18181e6b0(lVar3,this.newObj,DAT_181d893b0);
                                return this.newObj;
                              }
                            }
                          }
                          break;
                        }
                        if (lVar3 == null) break;
                        if (lVar3.Count <= uVar9) {
                          ThrowHelper.ThrowArgumentOutOfRangeException(0);
                        }
                        lVar3 = *(int64 *)(lVar7 + lVar3._items);
                        if (lVar3 == null) break;
                        uVar5 = lVar3._items;
                        cVar2 = Object.op_Equality(uVar5,target);
                        lVar3 = this.heroLittleTalkData;
                        if (cVar2) {
                          if (((lVar3 != null) &&
                              (lVar3 = FUN_180002f80(lVar3,uVar9,DAT_181d92f28)) != null) &&
                             (lVar3.Count != null)) {
                            FUN_18181e6b0(lVar3.Count,this.newObj,
                                          DAT_181d893b0);
                            if (this.heroLittleTalkData != null) {
                              uVar5 = FUN_180002f80(this.heroLittleTalkData,uVar9,DAT_181d92f28);
                              uVar5 = HeroLittleTalkController.SortHeroLittleTalk(this,uVar5,0);
                              FUN_180d8c8f0(this,uVar5,0);
                              return this.newObj;
                            }
                          }
                          break;
                        }
                        uVar9 = uVar9 + 1;
                        lVar7 = lVar7 + 8;
                      } while (lVar3 != null);
                    }
                  }
                }
              }
            }
          }
        }
    }

    // Token : 0x60017E6
    // RVA   : 0xAF7620   Offset: 0xAF6A20   Length: 0x11D
    public GameObject HeroTalk(GameObject target, string talkText, float lifeTime, GameObject parentObj, TalkTextPosType talkTextPosType)
    {
        uint64
        HeroLittleTalkController.HeroTalk
                (int64 this,int64 target,uint64 talkText,uint32 lifeTime,int parentObj,
                int64 talkTextPosType,int param_7)
        {
        float fVar1;
        char cVar2;
        int64 lVar3;
        float *pfVar4;
        uint64 uVar5;
        uint64 uVar6;
        int64 lVar7;
        uint64 *puVar8;
        uint32 uVar9;
        bool bVar10;
        uint64 local_58;
        uint32 local_50;
        uint8 local_48 [32];
        uVar9 = 0;
        if (param_7 == 2) {
          if ((target == null) || (lVar3 = GameObject.get_transform(target,0)) == null)
          throw; // [null/range check failed]
          pfVar4 = (float *)Transform.get_position(&local_58,lVar3,0);
          fVar1 = *pfVar4;
          bVar10 = 0.0 < *pfVar4;
        LAB_180af78ba:
          param_7 = 1;
          if (!bVar10 && fVar1 != 0.0) {
            param_7 = 0;
          }
        }
        else if (param_7 == 3) {
          if ((target == null) || (lVar3 = GameObject.get_transform(target,0)) == null)
          throw; // [null/range check failed]
          pfVar4 = (float *)Transform.get_position(&local_58,lVar3,0);
          fVar1 = *pfVar4;
          bVar10 = fVar1 < 0.0;
          goto LAB_180af78ba;
        }
        cVar2 = Object.op_Equality(talkTextPosType,0,0);
        if (cVar2) {
          talkTextPosType = target;
        }
        uVar5 = this.heroLittleTalkPrefab;
        uVar5 = GlobalData.AddChild(talkTextPosType,uVar5,0);
        this.newObj = uVar5;
        if ((((this.newObj == null) ||
             (lVar3 = GameObject.get_transform(this.newObj,0)) == null) ||
            (lVar3 = Transform.Find(lVar3,"Back",0)) == null) ||
           (lVar3 = Transform.Find(lVar3,"Text",0)) == null) throw; // [null/range check failed]
        uVar5 = Component.GetComponent(lVar3,DAT_181d96178);
        uVar6 = GlobalData.ReplaceSpeString(talkText,parentObj,0);
        LTLocalization.SetText(uVar5,uVar6,0);
        if (-1 < parentObj) {
          if ((GameController._instance == null) ||
             (lVar3 = GameController._instance.worldData) == null)
          throw; // [null/range check failed]
          lVar3 = WorldData.GetHero(lVar3,parentObj,0);
          if ((((GameController._instance == null) ||
               (lVar7 = GameController._instance.worldData) == null) ||
              (lVar7 = WorldData.GetHero(lVar7,parentObj,0)) == null) ||
             (uVar5 = HeroData.GetHeroLittleTalkSound(lVar7,0), lVar3 == null)) throw; // [null/range check failed]
          HeroData.PlayHeroSound(lVar3,uVar5,0x3f800000,0xbf800000,0);
        }
        if ((this.newObj != null) &&
           (lVar3 = GameObject.GetComponent(this.newObj,DAT_181d71c60)) != null) {
          lVar3.Count = target;
          if ((this.newObj != null) &&
             (lVar3 = GameObject.GetComponent(this.newObj,DAT_181d71c60)) != null)
          {
            *(int *)(lVar3 + 44) = param_7;
            if ((this.newObj != null) &&
               (lVar3 = GameObject.GetComponent(this.newObj,DAT_181d71c60)) != null
               ) {
              lVar3.Areas = lifeTime;
              if (this.newObj != null) {
                lVar3 = GameObject.get_transform(this.newObj,0);
                puVar8 = (uint64 *)Vector3.get_zero(local_48,0);
                if (lVar3 != null) {
                  local_50 = *(uint32 *)(puVar8 + 1);
                  local_58 = *puVar8;
                  Transform.set_localScale(lVar3,&local_58,0);
                  if (this.newObj != null) {
                    uVar5 = GameObject.get_transform(this.newObj,0);
                    puVar8 = (uint64 *)Vector3.get_one(local_48,0);
                    local_50 = *(uint32 *)(puVar8 + 1);
                    local_58 = *puVar8;
                    uVar5 = ShortcutExtensions.DOScale(uVar5,&local_58,0x3e800000,0);
                    uVar5 = TweenSettingsExtensions.SetEase(uVar5,8,DAT_181dc1128);
                    TweenSettingsExtensions.SetUpdate(uVar5,1,DAT_181dc1f60);
                    lVar3 = this.heroLittleTalkData;
                    if (lVar3 != null) {
                      lVar7 = 32;
                      do {
                        if (lVar3.Count <= (int)uVar9) {
                          var uVar5 = new LittleTalkData(target,0);
                          if (lVar3 != null) {
                            FUN_18181e6b0(lVar3,uVar5,DAT_181d92d28);
                            lVar3 = this.heroLittleTalkData;
                            if (lVar3 != null) {
                              uVar9 = lVar3.Count;
                              if (uVar9 <= uVar9 - 1) {
                                ThrowHelper.ThrowArgumentOutOfRangeException(0);
                              }
                              lVar3 = *(int64 *)
                                       (lVar3._items + 24 + (int64)(int)uVar9 * 8);
                              if ((lVar3 = lVar3?.Count) != null) {
                                FUN_18181e6b0(lVar3,this.newObj,DAT_181d893b0);
                                return this.newObj;
                              }
                            }
                          }
                          break;
                        }
                        if (lVar3 == null) break;
                        if (lVar3.Count <= uVar9) {
                          ThrowHelper.ThrowArgumentOutOfRangeException(0);
                        }
                        lVar3 = *(int64 *)(lVar7 + lVar3._items);
                        if (lVar3 == null) break;
                        uVar5 = lVar3._items;
                        cVar2 = Object.op_Equality(uVar5,target);
                        lVar3 = this.heroLittleTalkData;
                        if (cVar2) {
                          if (((lVar3 != null) &&
                              (lVar3 = FUN_180002f80(lVar3,uVar9,DAT_181d92f28)) != null) &&
                             (lVar3.Count != null)) {
                            FUN_18181e6b0(lVar3.Count,this.newObj,
                                          DAT_181d893b0);
                            if (this.heroLittleTalkData != null) {
                              uVar5 = FUN_180002f80(this.heroLittleTalkData,uVar9,DAT_181d92f28);
                              uVar5 = HeroLittleTalkController.SortHeroLittleTalk(this,uVar5,0);
                              FUN_180d8c8f0(this,uVar5,0);
                              return this.newObj;
                            }
                          }
                          break;
                        }
                        uVar9 = uVar9 + 1;
                        lVar7 = lVar7 + 8;
                      } while (lVar3 != null);
                    }
                  }
                }
              }
            }
          }
        }
    }

    // Token : 0x60017E7
    // RVA   : 0xAF73C0   Offset: 0xAF67C0   Length: 0x2A
    public GameObject HeroTalk(GameObject target, string talkText, float lifeTime, int sourceHeroID)
    {
        uint64
        HeroLittleTalkController.HeroTalk
                (int64 this,int64 target,uint64 talkText,uint32 lifeTime,int sourceHeroID,
                int64 param_6,int param_7)
        {
        float fVar1;
        char cVar2;
        int64 lVar3;
        float *pfVar4;
        uint64 uVar5;
        uint64 uVar6;
        int64 lVar7;
        uint64 *puVar8;
        uint32 uVar9;
        bool bVar10;
        uint64 local_58;
        uint32 local_50;
        uint8 local_48 [32];
        uVar9 = 0;
        if (param_7 == 2) {
          if ((target == null) || (lVar3 = GameObject.get_transform(target,0)) == null)
          throw; // [null/range check failed]
          pfVar4 = (float *)Transform.get_position(&local_58,lVar3,0);
          fVar1 = *pfVar4;
          bVar10 = 0.0 < *pfVar4;
        LAB_180af78ba:
          param_7 = 1;
          if (!bVar10 && fVar1 != 0.0) {
            param_7 = 0;
          }
        }
        else if (param_7 == 3) {
          if ((target == null) || (lVar3 = GameObject.get_transform(target,0)) == null)
          throw; // [null/range check failed]
          pfVar4 = (float *)Transform.get_position(&local_58,lVar3,0);
          fVar1 = *pfVar4;
          bVar10 = fVar1 < 0.0;
          goto LAB_180af78ba;
        }
        cVar2 = Object.op_Equality(param_6,0,0);
        if (cVar2) {
          param_6 = target;
        }
        uVar5 = this.heroLittleTalkPrefab;
        uVar5 = GlobalData.AddChild(param_6,uVar5,0);
        this.newObj = uVar5;
        if ((((this.newObj == null) ||
             (lVar3 = GameObject.get_transform(this.newObj,0)) == null) ||
            (lVar3 = Transform.Find(lVar3,"Back",0)) == null) ||
           (lVar3 = Transform.Find(lVar3,"Text",0)) == null) throw; // [null/range check failed]
        uVar5 = Component.GetComponent(lVar3,DAT_181d96178);
        uVar6 = GlobalData.ReplaceSpeString(talkText,sourceHeroID,0);
        LTLocalization.SetText(uVar5,uVar6,0);
        if (-1 < sourceHeroID) {
          if ((GameController._instance == null) ||
             (lVar3 = GameController._instance.worldData) == null)
          throw; // [null/range check failed]
          lVar3 = WorldData.GetHero(lVar3,sourceHeroID,0);
          if ((((GameController._instance == null) ||
               (lVar7 = GameController._instance.worldData) == null) ||
              (lVar7 = WorldData.GetHero(lVar7,sourceHeroID,0)) == null) ||
             (uVar5 = HeroData.GetHeroLittleTalkSound(lVar7,0), lVar3 == null)) throw; // [null/range check failed]
          HeroData.PlayHeroSound(lVar3,uVar5,0x3f800000,0xbf800000,0);
        }
        if ((this.newObj != null) &&
           (lVar3 = GameObject.GetComponent(this.newObj,DAT_181d71c60)) != null) {
          lVar3.Count = target;
          if ((this.newObj != null) &&
             (lVar3 = GameObject.GetComponent(this.newObj,DAT_181d71c60)) != null)
          {
            *(int *)(lVar3 + 44) = param_7;
            if ((this.newObj != null) &&
               (lVar3 = GameObject.GetComponent(this.newObj,DAT_181d71c60)) != null
               ) {
              lVar3.Areas = lifeTime;
              if (this.newObj != null) {
                lVar3 = GameObject.get_transform(this.newObj,0);
                puVar8 = (uint64 *)Vector3.get_zero(local_48,0);
                if (lVar3 != null) {
                  local_50 = *(uint32 *)(puVar8 + 1);
                  local_58 = *puVar8;
                  Transform.set_localScale(lVar3,&local_58,0);
                  if (this.newObj != null) {
                    uVar5 = GameObject.get_transform(this.newObj,0);
                    puVar8 = (uint64 *)Vector3.get_one(local_48,0);
                    local_50 = *(uint32 *)(puVar8 + 1);
                    local_58 = *puVar8;
                    uVar5 = ShortcutExtensions.DOScale(uVar5,&local_58,0x3e800000,0);
                    uVar5 = TweenSettingsExtensions.SetEase(uVar5,8,DAT_181dc1128);
                    TweenSettingsExtensions.SetUpdate(uVar5,1,DAT_181dc1f60);
                    lVar3 = this.heroLittleTalkData;
                    if (lVar3 != null) {
                      lVar7 = 32;
                      do {
                        if (lVar3.Count <= (int)uVar9) {
                          var uVar5 = new LittleTalkData(target,0);
                          if (lVar3 != null) {
                            FUN_18181e6b0(lVar3,uVar5,DAT_181d92d28);
                            lVar3 = this.heroLittleTalkData;
                            if (lVar3 != null) {
                              uVar9 = lVar3.Count;
                              if (uVar9 <= uVar9 - 1) {
                                ThrowHelper.ThrowArgumentOutOfRangeException(0);
                              }
                              lVar3 = *(int64 *)
                                       (lVar3._items + 24 + (int64)(int)uVar9 * 8);
                              if ((lVar3 = lVar3?.Count) != null) {
                                FUN_18181e6b0(lVar3,this.newObj,DAT_181d893b0);
                                return this.newObj;
                              }
                            }
                          }
                          break;
                        }
                        if (lVar3 == null) break;
                        if (lVar3.Count <= uVar9) {
                          ThrowHelper.ThrowArgumentOutOfRangeException(0);
                        }
                        lVar3 = *(int64 *)(lVar7 + lVar3._items);
                        if (lVar3 == null) break;
                        uVar5 = lVar3._items;
                        cVar2 = Object.op_Equality(uVar5,target);
                        lVar3 = this.heroLittleTalkData;
                        if (cVar2) {
                          if (((lVar3 != null) &&
                              (lVar3 = FUN_180002f80(lVar3,uVar9,DAT_181d92f28)) != null) &&
                             (lVar3.Count != null)) {
                            FUN_18181e6b0(lVar3.Count,this.newObj,
                                          DAT_181d893b0);
                            if (this.heroLittleTalkData != null) {
                              uVar5 = FUN_180002f80(this.heroLittleTalkData,uVar9,DAT_181d92f28);
                              uVar5 = HeroLittleTalkController.SortHeroLittleTalk(this,uVar5,0);
                              FUN_180d8c8f0(this,uVar5,0);
                              return this.newObj;
                            }
                          }
                          break;
                        }
                        uVar9 = uVar9 + 1;
                        lVar7 = lVar7 + 8;
                      } while (lVar3 != null);
                    }
                  }
                }
              }
            }
          }
        }
    }

    // Token : 0x60017E8
    // RVA   : 0xAF7740   Offset: 0xAF6B40   Length: 0x6E6
    public GameObject HeroTalk(GameObject target, string talkText, float lifeTime, int sourceHeroID, GameObject parentObj, TalkTextPosType talkTextPosType)
    {
        uint64
        HeroLittleTalkController.HeroTalk
                (int64 this,int64 target,uint64 talkText,uint32 lifeTime,int sourceHeroID,
                int64 parentObj,int talkTextPosType)
        {
        float fVar1;
        char cVar2;
        int64 lVar3;
        float *pfVar4;
        uint64 uVar5;
        uint64 uVar6;
        int64 lVar7;
        uint64 *puVar8;
        uint32 uVar9;
        bool bVar10;
        uint64 local_58;
        uint32 local_50;
        uint8 local_48 [32];
        uVar9 = 0;
        if (talkTextPosType == 2) {
          if ((target == null) || (lVar3 = GameObject.get_transform(target,0)) == null)
          throw; // [null/range check failed]
          pfVar4 = (float *)Transform.get_position(&local_58,lVar3,0);
          fVar1 = *pfVar4;
          bVar10 = 0.0 < *pfVar4;
        LAB_180af78ba:
          talkTextPosType = 1;
          if (!bVar10 && fVar1 != 0.0) {
            talkTextPosType = 0;
          }
        }
        else if (talkTextPosType == 3) {
          if ((target == null) || (lVar3 = GameObject.get_transform(target,0)) == null)
          throw; // [null/range check failed]
          pfVar4 = (float *)Transform.get_position(&local_58,lVar3,0);
          fVar1 = *pfVar4;
          bVar10 = fVar1 < 0.0;
          goto LAB_180af78ba;
        }
        cVar2 = Object.op_Equality(parentObj,0,0);
        if (cVar2) {
          parentObj = target;
        }
        uVar5 = this.heroLittleTalkPrefab;
        uVar5 = GlobalData.AddChild(parentObj,uVar5,0);
        this.newObj = uVar5;
        if ((((this.newObj == null) ||
             (lVar3 = GameObject.get_transform(this.newObj,0)) == null) ||
            (lVar3 = Transform.Find(lVar3,"Back",0)) == null) ||
           (lVar3 = Transform.Find(lVar3,"Text",0)) == null) throw; // [null/range check failed]
        uVar5 = Component.GetComponent(lVar3,DAT_181d96178);
        uVar6 = GlobalData.ReplaceSpeString(talkText,sourceHeroID,0);
        LTLocalization.SetText(uVar5,uVar6,0);
        if (-1 < sourceHeroID) {
          if ((GameController._instance == null) ||
             (lVar3 = GameController._instance.worldData) == null)
          throw; // [null/range check failed]
          lVar3 = WorldData.GetHero(lVar3,sourceHeroID,0);
          if ((((GameController._instance == null) ||
               (lVar7 = GameController._instance.worldData) == null) ||
              (lVar7 = WorldData.GetHero(lVar7,sourceHeroID,0)) == null) ||
             (uVar5 = HeroData.GetHeroLittleTalkSound(lVar7,0), lVar3 == null)) throw; // [null/range check failed]
          HeroData.PlayHeroSound(lVar3,uVar5,0x3f800000,0xbf800000,0);
        }
        if ((this.newObj != null) &&
           (lVar3 = GameObject.GetComponent(this.newObj,DAT_181d71c60)) != null) {
          lVar3.Count = target;
          if ((this.newObj != null) &&
             (lVar3 = GameObject.GetComponent(this.newObj,DAT_181d71c60)) != null)
          {
            *(int *)(lVar3 + 44) = talkTextPosType;
            if ((this.newObj != null) &&
               (lVar3 = GameObject.GetComponent(this.newObj,DAT_181d71c60)) != null
               ) {
              lVar3.Areas = lifeTime;
              if (this.newObj != null) {
                lVar3 = GameObject.get_transform(this.newObj,0);
                puVar8 = (uint64 *)Vector3.get_zero(local_48,0);
                if (lVar3 != null) {
                  local_50 = *(uint32 *)(puVar8 + 1);
                  local_58 = *puVar8;
                  Transform.set_localScale(lVar3,&local_58,0);
                  if (this.newObj != null) {
                    uVar5 = GameObject.get_transform(this.newObj,0);
                    puVar8 = (uint64 *)Vector3.get_one(local_48,0);
                    local_50 = *(uint32 *)(puVar8 + 1);
                    local_58 = *puVar8;
                    uVar5 = ShortcutExtensions.DOScale(uVar5,&local_58,0x3e800000,0);
                    uVar5 = TweenSettingsExtensions.SetEase(uVar5,8,DAT_181dc1128);
                    TweenSettingsExtensions.SetUpdate(uVar5,1,DAT_181dc1f60);
                    lVar3 = this.heroLittleTalkData;
                    if (lVar3 != null) {
                      lVar7 = 32;
                      do {
                        if (lVar3.Count <= (int)uVar9) {
                          var uVar5 = new LittleTalkData(target,0);
                          if (lVar3 != null) {
                            FUN_18181e6b0(lVar3,uVar5,DAT_181d92d28);
                            lVar3 = this.heroLittleTalkData;
                            if (lVar3 != null) {
                              uVar9 = lVar3.Count;
                              if (uVar9 <= uVar9 - 1) {
                                ThrowHelper.ThrowArgumentOutOfRangeException(0);
                              }
                              lVar3 = *(int64 *)
                                       (lVar3._items + 24 + (int64)(int)uVar9 * 8);
                              if ((lVar3 = lVar3?.Count) != null) {
                                FUN_18181e6b0(lVar3,this.newObj,DAT_181d893b0);
                                return this.newObj;
                              }
                            }
                          }
                          break;
                        }
                        if (lVar3 == null) break;
                        if (lVar3.Count <= uVar9) {
                          ThrowHelper.ThrowArgumentOutOfRangeException(0);
                        }
                        lVar3 = *(int64 *)(lVar7 + lVar3._items);
                        if (lVar3 == null) break;
                        uVar5 = lVar3._items;
                        cVar2 = Object.op_Equality(uVar5,target);
                        lVar3 = this.heroLittleTalkData;
                        if (cVar2) {
                          if (((lVar3 != null) &&
                              (lVar3 = FUN_180002f80(lVar3,uVar9,DAT_181d92f28)) != null) &&
                             (lVar3.Count != null)) {
                            FUN_18181e6b0(lVar3.Count,this.newObj,
                                          DAT_181d893b0);
                            if (this.heroLittleTalkData != null) {
                              uVar5 = FUN_180002f80(this.heroLittleTalkData,uVar9,DAT_181d92f28);
                              uVar5 = HeroLittleTalkController.SortHeroLittleTalk(this,uVar5,0);
                              FUN_180d8c8f0(this,uVar5,0);
                              return this.newObj;
                            }
                          }
                          break;
                        }
                        uVar9 = uVar9 + 1;
                        lVar7 = lVar7 + 8;
                      } while (lVar3 != null);
                    }
                  }
                }
              }
            }
          }
        }
    }

    // Token : 0x60017E9
    // RVA   : 0xAF81A0   Offset: 0xAF75A0   Length: 0x6C
    public IEnumerator SortHeroLittleTalk(LittleTalkData targetTalkData)
    {
        long lVar1;
        lVar1 = new WarpText_d__8(0,0);
        if (lVar1 != null) {
          *(uint64 *)(lVar1 + 32) = targetTalkData;
          return lVar1;
        }
    }

    // Token : 0x60017EA
    // RVA   : 0xAF72C0   Offset: 0xAF66C0   Length: 0xFD
    public void ClearAll()
    {
        ulong uVar1;
        long lVar2;
        long lVar3;
        uint uVar4;
        lVar2 = this.heroLittleTalkData;
        uVar4 = 0;
        if (lVar2 != null) {
          lVar3 = 32;
          do {
            if (lVar2.Count <= (int)uVar4) {
              FUN_1812fa020(lVar2,DAT_181d92da8);
              return;
            }
            if (lVar2 == null) break;
            if (lVar2.Count <= uVar4) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            lVar2 = *(int64 *)(lVar3 + lVar2._items);
            if (lVar2 == null) break;
            uVar1 = lVar2.Count;
            GlobalData.DestroyAll(uVar1,0);
            lVar2 = this.heroLittleTalkData;
            uVar4 = uVar4 + 1;
            lVar3 = lVar3 + 8;
          } while (lVar2 != null);
        }
    }

    // Token : 0x60017EB
    // RVA   : 0xAF8210   Offset: 0xAF7610   Length: 0x7
    private void Update()
    {
        void FUN_180af8210(uint64 this)
        {
        HeroLittleTalkController.RefreshHeroLittleTalkData(this,0);
    }

    // Token : 0x60017EC
    // RVA   : 0xAF7E30   Offset: 0xAF7230   Length: 0x36D
    public void RefreshHeroLittleTalkData()
    {
        bool cVar2;
        long lVar3;
        ulong uVar4;
        int iVar5;
        uint uVar6;
        long lVar7;
        if (this.heroLittleTalkData != null) {
          uVar6 = this.heroLittleTalkData.Count - 1;
          if (-1 < (int)uVar6) {
            lVar7 = (int64)(int)uVar6 * 8 + 32;
            do {
              lVar3 = this.heroLittleTalkData;
              if (lVar3 == null) throw; // [null/range check failed]
              if (lVar3.Count <= uVar6) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              lVar3 = *(int64 *)(lVar7 + lVar3._items);
              if (lVar3 == null) throw; // [null/range check failed]
              uVar4 = lVar3._items;
              cVar2 = Object.op_Equality(uVar4,0,0);
              if (!cVar2) {
                if (this.heroLittleTalkData == null) throw; // [null/range check failed]
                lVar3 = FUN_180002f80(this.heroLittleTalkData,uVar6,DAT_181d92f28);
                if ((lVar3 == null) || (lVar3.Count == null)) throw; // [null/range check failed]
                if (*(int *)(lVar3.Count + 24) == 0) goto LAB_180af8109;
                bVar1 = false;
                if (this.heroLittleTalkData == null) throw; // [null/range check failed]
                lVar3 = FUN_180002f80();
                if ((lVar3 == null) || (lVar3.Count == null)) throw; // [null/range check failed]
                iVar5 = *(int *)(lVar3.Count + 24) + -1;
                if (-1 < iVar5) {
                  do {
                    if (this.heroLittleTalkData == null) throw; // [null/range check failed]
                    lVar3 = FUN_180002f80(this.heroLittleTalkData,uVar6,DAT_181d92f28);
                    if ((lVar3 == null) || (lVar3.Count == null)) throw; // [null/range check failed]
                    uVar4 = FUN_180002f80();
                    cVar2 = Object.op_Equality(uVar4,0,0);
                    if (cVar2) {
                      bVar1 = true;
                      if (this.heroLittleTalkData == null) throw; // [null/range check failed]
                      lVar3 = FUN_180002f80(this.heroLittleTalkData,uVar6,DAT_181d92f28);
                      if ((lVar3 == null) || (lVar3.Count == null)) throw; // [null/range check failed]
                      FUN_181823ba0();
                    }
                    iVar5 = iVar5 + -1;
                  } while (-1 < iVar5);
                  if (bVar1) {
                    if (this.heroLittleTalkData == null) throw; // [null/range check failed]
                    lVar3 = FUN_180002f80();
                    if ((lVar3 == null) || (lVar3.Count == null)) throw; // [null/range check failed]
                    if (0 < *(int *)(lVar3.Count + 24)) {
                      if (this.heroLittleTalkData == null) throw; // [null/range check failed]
                      uVar4 = FUN_180002f80(this.heroLittleTalkData,uVar6);
                      HeroLittleTalkController.SortHeroLittleTalk(this,uVar4);
                      FUN_180d8c8f0();
                    }
                  }
                }
              }
              else {
        LAB_180af8109:
                if (this.heroLittleTalkData == null) throw; // [null/range check failed]
                lVar3 = FUN_180002f80(this.heroLittleTalkData,uVar6,DAT_181d92f28);
                if (lVar3 == null) throw; // [null/range check failed]
                uVar4 = lVar3.Count;
                GlobalData.DestroyAll(uVar4,0);
                if (this.heroLittleTalkData == null) throw; // [null/range check failed]
                FUN_181823ba0();
              }
              lVar7 = lVar7 + -8;
              uVar6 = uVar6 - 1;
            } while (-1 < (int)uVar6);
          }
          return;
        }
    }

    // Token : 0x60017ED
    // RVA   : 0x3A17B0   Offset: 0x3A0BB0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_18044ef50(this,0);
    }

}
