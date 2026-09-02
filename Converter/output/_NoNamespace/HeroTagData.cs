// ============================================================
// Type  : HeroTagData
// Token : 0x2000231
// ============================================================

public class HeroTagData
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x400111B
    public int tagID;

    // Token: 0x400111C
    public float leftTime;

    // Token: 0x400111D
    public string sourceHero;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x600126F
    // RVA   : 0xB3D900   Offset: 0xB3C100   Length: 0x51
    public void /*ctor*/(int _tagID, float _leftTime, string _sourceHero)
    {
        ZhSegment.Initialize(this,0);
        this.sourceHero = _sourceHero;
        this.leftTime = _leftTime;
        this.tagID = _tagID;
    }

    // Token : 0x6001270
    // RVA   : 0xB3D870   Offset: 0xB3C070   Length: 0x69
    public bool IsPermanentTag()
    {
        byte uVar1;
        long lVar2;
        if (this.leftTime != -1.0) {
          return false;
        }
        lVar2 = HeroTagData.DataBase(this,0);
        if (lVar2 == null) {
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
        uVar1 = String.op_Inequality(*(uint64 *)(lVar2 + 80),"特效",0);
        return uVar1;
    }

    // Token : 0x6001271
    // RVA   : 0xB3D160   Offset: 0xB3B960   Length: 0x705
    public string GetDescribe(bool showEffectTarget, TagIconType tagIconType)
    {
        var pStatics = *(int64*)(DAT_181d4ef00 + 184);
        bool cVar1;
        ulong uVar2;
        ulong uVar3;
        long lVar4;
        ulong uVar5;
        ulong uVar6;
        ulong uVar7;
        long lVar8;
        int iVar9;
        int iVar10;
        uint[] local_res8 = new uint[2];
        float[] local_res10 = new float[2];
        uVar7 = "";
        local_res10[0] = 0.0;
        uVar2 = "";
        if (this.sourceHero != null) {
          uVar2 = String.Format("<i>来自{0}</i>\n",this.sourceHero,0);
        }
        uVar3 = "";
        if (0.0 < this.leftTime) {
          local_res8[0] = Mathf.CeilToInt();
          uVar3 = il2cpp_value_box(DAT_181d5b2f8,local_res8);
          uVar3 = String.Format("[{0}日]\n",uVar3,0);
        }
        lVar4 = HeroTagData.DataBase(this,0);
        if (lVar4 == null) throw; // [null/range check failed]
        uVar5 = "";
        if ((showEffectTarget) &&
           (((iVar9 = *(int *)(lVar4 + 36), uVar6 = "战时敌方全体:\n", iVar9 == 0 ||
             (uVar6 = "战时我方全体:\n", iVar9 == 1)) || ((iVar9 != 2 && (uVar6 = "战时我方队友:\n", iVar9 == 3)))
            ))) {
          uVar5 = String.Concat("",uVar6,0);
        }
        if (*(int64 *)(lVar4 + 88) == 0) throw; // [null/range check failed]
        iVar9 = 0;
        uVar6 = HeroSpeAddData.GetDescribe(*(int64 *)(lVar4 + 88),0,999999,1,1,1,1,0);
        uVar5 = String.Concat(uVar5,uVar6,0);
        uVar7 = String.Concat(uVar7,uVar2,uVar3,uVar5,0);
        if (tagIconType == null) {
          return uVar7;
        }
        if ((tagIconType == 2) || (tagIconType == 3)) {
          lVar4 = HeroTagData.DataBase(this,0);
          if (lVar4 == null) throw; // [null/range check failed]
          if (*(char *)(lVar4 + 56) == false)
          {
            uVar7 = String.Concat(uVar7,"\n<color=red>初始不可领悟</color>",0);
            }
            else {
          }
          lVar4 = HeroTagData.DataBase(this,0);
          uVar2 = "\n领悟消耗: ";
          if (lVar4 == null) throw; // [null/range check failed]
          iVar10 = *(int *)(lVar4 + 32);
          if (iVar10 < 0) {
            if (tagIconType != 2 && tagIconType != 3) {
              iVar10 = -iVar10;
            }
          }
          else {
            iVar10 = iVar10 * 4;
          }
          local_res10[0] = (float)iVar10;
          uVar3 = Single.ToString(local_res10,0);
          uVar7 = String.Concat(uVar7,uVar2,uVar3,0);
        }
        if (tagIconType == 1) {
        LAB_180b3d4d3:
          lVar4 = HeroTagData.DataBase(this,0);
          if ((lVar4 == null) || (*(int64 *)(lVar4 + 64) == 0)) throw; // [null/range check failed]
          if (0 < *(int *)(*(int64 *)(lVar4 + 64) + 24)) {
            uVar7 = String.Concat(uVar7,"\n\n领悟需求:\n",0);
            lVar4 = HeroTagData.DataBase(this,0);
            iVar10 = iVar9;
            if (lVar4 != null) {
              while (*(int64 *)(lVar4 + 64) != 0) {
                if (*(int *)(*(int64 *)(lVar4 + 64) + 24) <= iVar10) goto LAB_180b3d771;
                uVar2 = "\n";
                if (iVar10 == 0) {
                  uVar2 = "";
                }
                uVar3 = FUN_18046c340(0);
                cVar1 = Object.op_Equality(uVar3,0,0);
                uVar3 = "{0}";
                if (!cVar1) {
                  lVar4 = FUN_18046c340(0);
                  if (lVar4 == null) break;
                  uVar3 = "{0}";
                  if (*(int64 *)(lVar4 + 32) != 0) {
                    lVar4 = FUN_18046c340(0);
                    lVar8 = FUN_18046c340(0);
                    if (lVar8 == null) break;
                    uVar3 = *(uint64 *)(lVar8 + 32);
                    lVar8 = HeroTagData.DataBase(this,0);
                    if (((lVar8 == null) || (*(int64 *)(lVar8 + 64) == 0)) ||
                       (uVar5 = FUN_180002f80(*(int64 *)(lVar8 + 64),iVar10,DAT_181d7c9c0),
                       lVar4 == null)) break;
                    cVar1 = ManageTagController.CheckMeetOneCondition(lVar4,uVar3,uVar5);
                    if (!cVar1) {
                      uVar3 = String.Concat(*(uint64 *)(pStatics + 0x2d0),
                                             "{0}</color>",0);
                    }
                    else {
                      uVar3 = String.Concat(*(uint64 *)(pStatics + 0x268),
                                             "{0}</color>",0);
                    }
                  }
                }
                lVar4 = HeroTagData.DataBase(this,0);
                if ((lVar4 == null) || (*(int64 *)(lVar4 + 64) == 0)) break;
                uVar5 = FUN_180002f80(*(int64 *)(lVar4 + 64),iVar10,DAT_181d7c9c0);
                uVar3 = String.Format(uVar3,uVar5,0);
                uVar7 = String.Concat(uVar7,uVar2,uVar3,0);
                iVar10 = iVar10 + 1;
                lVar4 = HeroTagData.DataBase(this);
                if (lVar4 == null) break;
              }
            }
            throw; // [null/range check failed]
          }
        }
        else if (tagIconType == 2) {
          lVar4 = HeroTagData.DataBase(this,0);
          if (lVar4 == null) throw; // [null/range check failed]
          if (*(char *)(lVar4 + 56) == false) goto LAB_180b3d4d3;
        }
        LAB_180b3d771:
        lVar4 = HeroTagData.DataBase(this,0);
        if ((lVar4 != null) && (*(int64 *)(lVar4 + 72) != 0)) {
          if (*(int *)(*(int64 *)(lVar4 + 72) + 24) < 1) {
            return uVar7;
          }
          uVar7 = String.Concat(uVar7,"\n\n替换天赋:\n",0);
          lVar4 = HeroTagData.DataBase(this,0);
          if (lVar4 != null) {
            while (*(int64 *)(lVar4 + 72) != 0) {
              if (*(int *)(*(int64 *)(lVar4 + 72) + 24) <= iVar9) {
                return uVar7;
              }
              uVar2 = "/";
              if (iVar9 == 0) {
                uVar2 = "";
              }
              lVar4 = HeroTagData.DataBase(this,0);
              if ((lVar4 == null) || (*(int64 *)(lVar4 + 72) == 0)) break;
              uVar3 = FUN_180002f80(*(int64 *)(lVar4 + 72),iVar9,DAT_181d7c9c0);
              uVar7 = String.Concat(uVar7,uVar2,uVar3,0);
              iVar9 = iVar9 + 1;
              lVar4 = HeroTagData.DataBase(this,0);
              if (lVar4 == null) break;
            }
          }
        }
    }

    // Token : 0x6001272
    // RVA   : 0xB3D8E0   Offset: 0xB3C0E0   Length: 0x1E
    public bool StartChooseAble()
    {
        long lVar1;
        lVar1 = HeroTagData.DataBase(this,0);
        if (lVar1 != null) {
          return *(uint8 *)(lVar1 + 56);
        }
    }

    // Token : 0x6001273
    // RVA   : 0xB3D0A0   Offset: 0xB3B8A0   Length: 0xB6
    public HeroTagDataBase DataBase()
    {
        long lVar1;
        lVar1 = *(int64 *)(*(int64 *)(DAT_181d4e010 + 184) + 32);
        if (lVar1 != null) {
          GameDataController.GetTagDataBase(lVar1,this.tagID,0);
          return;
        }
    }

    // Token : 0x6001274
    // RVA   : 0xB3CF20   Offset: 0xB3B720   Length: 0x175
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
