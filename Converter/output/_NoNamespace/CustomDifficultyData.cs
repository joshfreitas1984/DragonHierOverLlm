// ============================================================
// Type  : CustomDifficultyData
// Token : 0x20001E3
// ============================================================

public class CustomDifficultyData
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4000CD4
    public Dictionary<int, int> customDifficultyLv;

    // Token: 0x4000CD5
    public static List<string> customDifficultyName;

    // Token: 0x4000CD6
    public static List<int> customDifficultyLvRate;

    // Token: 0x4000CD7
    public static List<string> teammateLimitName;

    // Token: 0x4000CD8
    public static List<string> teammateLimitDescribe;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000EE9
    // RVA   : 0xA45790   Offset: 0xA44B90   Length: 0x76
    public void /*ctor*/()
    {
        ulong uVar1;
        ZhSegment.Initialize(this,0);
        uVar1 = il2cpp_internal(DAT_181d81000);
        FUN_1808b1370(uVar1,DAT_181dba768);
        this.customDifficultyLv = uVar1;
    }

    // Token : 0x6000EEA
    // RVA   : 0xA44AA0   Offset: 0xA43EA0   Length: 0x8
    public int GetDifficultyLv(CustomDifficultyType customDifficultyType)
    {
        bool cVar1;
        ulong uVar2;
        if (this.customDifficultyLv != null) {
          cVar1 = FUN_1808ab490(this.customDifficultyLv,customDifficultyType,DAT_181dbaa10);
          if (!cVar1) {
            return 0;
          }
          if (this.customDifficultyLv != null) {
            uVar2 = FUN_181467b40(this.customDifficultyLv,customDifficultyType,DAT_181dbb068);
            return uVar2;
          }
        }
    }

    // Token : 0x6000EEB
    // RVA   : 0xA44AB0   Offset: 0xA43EB0   Length: 0x85
    public int GetDifficultyLv(int customDifficultyType)
    {
        bool cVar1;
        ulong uVar2;
        if (this.customDifficultyLv != null) {
          cVar1 = FUN_1808ab490(this.customDifficultyLv,customDifficultyType,DAT_181dbaa10);
          if (!cVar1) {
            return 0;
          }
          if (this.customDifficultyLv != null) {
            uVar2 = FUN_181467b40(this.customDifficultyLv,customDifficultyType,DAT_181dbb068);
            return uVar2;
          }
        }
    }

    // Token : 0x6000EEC
    // RVA   : 0xA451A0   Offset: 0xA445A0   Length: 0xB9
    public void SetDifficultyLv(CustomDifficultyType customDifficultyType, int lv)
    {
        long lVar1;
        bool cVar2;
        if (this.customDifficultyLv != null) {
          cVar2 = FUN_1808ab490(this.customDifficultyLv,customDifficultyType,DAT_181dbaa10);
          lVar1 = this.customDifficultyLv;
          if (!cVar2) {
            if (lVar1 != null) {
              FUN_1808ab370(lVar1,customDifficultyType,lv,DAT_181dba900);
              return;
            }
          }
          else if (lVar1 != null) {
            FUN_1808b2160(lVar1,customDifficultyType,lv,DAT_181dbb178);
            return;
          }
        }
    }

    // Token : 0x6000EED
    // RVA   : 0xA451A0   Offset: 0xA445A0   Length: 0xB9
    public void SetDifficultyLv(int customDifficultyType, int lv)
    {
        long lVar1;
        bool cVar2;
        if (this.customDifficultyLv != null) {
          cVar2 = FUN_1808ab490(this.customDifficultyLv,customDifficultyType,DAT_181dbaa10);
          lVar1 = this.customDifficultyLv;
          if (!cVar2) {
            if (lVar1 != null) {
              FUN_1808ab370(lVar1,customDifficultyType,lv,DAT_181dba900);
              return;
            }
          }
          else if (lVar1 != null) {
            FUN_1808b2160(lVar1,customDifficultyType,lv,DAT_181dbb178);
            return;
          }
        }
    }

    // Token : 0x6000EEE
    // RVA   : 0xA44B40   Offset: 0xA43F40   Length: 0x1B4
    public float GetDifficultyRate(CustomDifficultyType customDifficultyType)
    {
        int iVar1;
        ulong uVar2;
        float fVar3;
        fVar3 = 0.0;
        switch(customDifficultyType) {
        case 0:
          iVar1 = CustomDifficultyData.GetDifficultyLv(this,0,0);
          uVar2 = 0;
          break;
        case 1:
          iVar1 = CustomDifficultyData.GetDifficultyLv(this,1);
          uVar2 = 1;
          break;
        case 2:
          iVar1 = CustomDifficultyData.GetDifficultyLv(this,2);
          uVar2 = 2;
          break;
        case 3:
          iVar1 = CustomDifficultyData.GetDifficultyLv(this,3);
          uVar2 = 3;
          break;
        case 4:
          iVar1 = CustomDifficultyData.GetDifficultyLv(this,4);
          fVar3 = (float)iVar1;
          iVar1 = CustomDifficultyData.GetDifficultyLv(this,4);
          if (0 < iVar1) {
            return fVar3 * 0.4;
          }
          goto LAB_180a44baf;
        case 5:
          iVar1 = CustomDifficultyData.GetDifficultyLv(this,5);
          uVar2 = 5;
          break;
        case 6:
          iVar1 = CustomDifficultyData.GetDifficultyLv(this,6);
          uVar2 = 6;
          break;
        case 7:
          iVar1 = CustomDifficultyData.GetDifficultyLv(this,7);
          uVar2 = 7;
          break;
        case 8:
          iVar1 = CustomDifficultyData.GetDifficultyLv(this,8);
          if (iVar1 < 5) {
            uVar2 = 8;
            goto LAB_180a44cd3;
          }
          iVar1 = 99;
          goto LAB_180a44cde;
        default:
          goto switchD_180a44b6e_caseD_9;
        case 10:
          uVar2 = 10;
        LAB_180a44cd3:
          iVar1 = CustomDifficultyData.GetDifficultyLv(this,uVar2,0);
        LAB_180a44cde:
          fVar3 = (float)iVar1;
        switchD_180a44b6e_caseD_9:
          return fVar3;
        }
        fVar3 = (float)iVar1;
        iVar1 = CustomDifficultyData.GetDifficultyLv(this,uVar2,0);
        if (0 < iVar1) {
          return fVar3 * 0.2;
        }
        LAB_180a44baf:
        return fVar3 * 0.1;
    }

    // Token : 0x6000EEF
    // RVA   : 0xA43C40   Offset: 0xA43040   Length: 0xE50
    public string GetDescribe(int customDifficultyType)
    {
        var pStatics_3d40 = *(int64*)(DAT_181d73d40 + 184);
        int iVar1;
        long lVar3;
        long lVar4;
        ulong uVar5;
        float fVar7;
        float[] local_res10 = new float[2];
        local_res10[0] = 0.0;
        if (7 < (int)customDifficultyType) {
          if (customDifficultyType == 8) {
            plVar2 = (int64 *)FUN_1800d60b0(DAT_181da5cf8,5);
            lVar3 = CustomDifficultyData.customDifficultyName;
            if (lVar3 == null) goto LAB_180a4480b;
            if (*(uint32 *)(lVar3 + 24) < 9) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            lVar3 = *(int64 *)(*(int64 *)(lVar3 + 16) + 96);
            if (plVar2 == (int64 *)0) goto LAB_180a4480b;
            if ((lVar3 != null) &&
               (lVar4 = il2cpp_internal(lVar3,*(uint64 *)(*plVar2 + 64))) == null) {
              uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar5,0);
            }
            if ((int)plVar2[3] == 0) {
              uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar5,0);
            }
            plVar2[4] = lVar3;
            il2cpp_internal(plVar2 + 4,lVar3);
            if ((" " != 0) &&
               (lVar3 = il2cpp_internal(" ",*(uint64 *)(*plVar2 + 64))) == null) {
              uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar5,0);
            }
            lVar3 = " ";
            if (*(uint32 *)(plVar2 + 3) < 2) {
              uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar5,0);
            }
            plVar2[5] = " ";
            il2cpp_internal(plVar2 + 5,lVar3);
            iVar1 = CustomDifficultyData.GetDifficultyLv(this,8);
            lVar3 = "";
            if (iVar1 != 0) {
              iVar1 = CustomDifficultyData.GetDifficultyLv(this,8);
              if (iVar1 < 1) {
                lVar3 = *(int64 *)(pStatics_3d40 + 0x2d8);
              }
              else {
                lVar3 = *(int64 *)(pStatics_3d40 + 0x270);
              }
            }
            if ((lVar3 != null) &&
               (lVar4 = il2cpp_internal(lVar3,*(uint64 *)(*plVar2 + 64))) == null) {
              uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar5,0);
            }
            if (*(uint32 *)(plVar2 + 3) < 3) {
              uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar5,0);
            }
            plVar2[6] = lVar3;
            il2cpp_internal(plVar2 + 6,lVar3);
            fVar7 = (float)CustomDifficultyData.GetDifficultyRate(this,8);
            lVar3 = "∞";
            if (fVar7 < 5.0) {
              local_res10[0] = (float)CustomDifficultyData.GetDifficultyRate(this,8);
              lVar3 = Single.ToString(local_res10,"+0;-0;+0",0);
            }
            if ((lVar3 != null) &&
               (lVar4 = il2cpp_internal(lVar3,*(uint64 *)(*plVar2 + 64))) == null) {
              uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar5,0);
            }
            if (*(uint32 *)(plVar2 + 3) < 4) {
              uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar5,0);
            }
            plVar2[7] = lVar3;
            il2cpp_internal(plVar2 + 7,lVar3);
            iVar1 = CustomDifficultyData.GetDifficultyLv(this,8);
            lVar3 = "</color>";
            if (iVar1 == 0) {
              lVar3 = "";
            }
            if ((lVar3 != null) &&
               (lVar4 = il2cpp_internal(lVar3,*(uint64 *)(*plVar2 + 64))) == null) {
              uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar5,0);
            }
            if (*(uint32 *)(plVar2 + 3) < 5) {
              uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar5,0);
            }
          }
          else {
            if (customDifficultyType != 9) {
              if (customDifficultyType != 10) {
                return "";
              }
              plVar2 = (int64 *)FUN_1800d60b0(DAT_181da5cf8,5);
              if ((CustomDifficultyData.customDifficultyName != null) &&
                 (lVar3 = FUN_180002f80(CustomDifficultyData.customDifficultyName,10,DAT_181da4370),
                 plVar2 != (int64 *)0)) {
                if ((lVar3 != null) &&
                   (lVar4 = il2cpp_internal(lVar3,*(uint64 *)(*plVar2 + 64))) == null) {
                  uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1800d65f0(uVar5,0);
                }
                if ((int)plVar2[3] == 0) {
                  uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1800d65f0(uVar5,0);
                }
                plVar2[4] = lVar3;
                il2cpp_internal(plVar2 + 4,lVar3);
                if ((" " != 0) &&
                   (lVar3 = il2cpp_internal(" ",*(uint64 *)(*plVar2 + 64)), lVar3 == null
                   )) {
                  uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1800d65f0(uVar5,0);
                }
                lVar3 = " ";
                if (*(uint32 *)(plVar2 + 3) < 2) {
                  uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1800d65f0(uVar5,0);
                }
                plVar2[5] = " ";
                il2cpp_internal(plVar2 + 5,lVar3);
                iVar1 = CustomDifficultyData.GetDifficultyLv(this,10);
                lVar3 = "";
                if (iVar1 != 0) {
                  iVar1 = CustomDifficultyData.GetDifficultyLv(this,10);
                  if (iVar1 < 1) {
                    lVar3 = *(int64 *)(pStatics_3d40 + 0x270);
                  }
                  else {
                    lVar3 = *(int64 *)(pStatics_3d40 + 0x2d8);
                  }
                }
                if ((lVar3 != null) &&
                   (lVar4 = il2cpp_internal(lVar3,*(uint64 *)(*plVar2 + 64))) == null) {
                  uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1800d65f0(uVar5,0);
                }
                FUN_180002fd0(plVar2,2,lVar3);
                local_res10[0] = (float)CustomDifficultyData.GetDifficultyRate(this,10);
                lVar3 = Single.ToString(local_res10,"+0;-0;+0",0);
                if ((lVar3 != null) &&
                   (lVar4 = il2cpp_internal(lVar3,*(uint64 *)(*plVar2 + 64))) == null) {
                  uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1800d65f0(uVar5,0);
                }
                if (*(uint32 *)(plVar2 + 3) < 4) {
                  uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1800d65f0(uVar5,0);
                }
                plVar2[7] = lVar3;
                il2cpp_internal(plVar2 + 7,lVar3);
                iVar1 = CustomDifficultyData.GetDifficultyLv(this,10);
                lVar3 = "</color>";
                if (iVar1 == 0) {
                  lVar3 = "";
                }
                if ((lVar3 != null) &&
                   (lVar4 = il2cpp_internal(lVar3,*(uint64 *)(*plVar2 + 64))) == null) {
                  uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1800d65f0(uVar5,0);
                }
                FUN_180002fd0(plVar2,4,lVar3);
                lVar3 = String.Concat(plVar2,0);
                return lVar3;
              }
              goto LAB_180a4480b;
            }
            plVar2 = (int64 *)FUN_1800d60b0(DAT_181da5cf8,5);
            lVar3 = CustomDifficultyData.customDifficultyName;
            if (lVar3 == null) goto LAB_180a4480b;
            if (*(uint32 *)(lVar3 + 24) < 10) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            lVar3 = *(int64 *)(*(int64 *)(lVar3 + 16) + 104);
            if (plVar2 == (int64 *)0) goto LAB_180a4480b;
            if ((lVar3 != null) &&
               (lVar4 = il2cpp_internal(lVar3,*(uint64 *)(*plVar2 + 64))) == null) {
              uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar5,0);
            }
            if ((int)plVar2[3] == 0) {
              uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar5,0);
            }
            plVar2[4] = lVar3;
            il2cpp_internal(plVar2 + 4,lVar3);
            if ((" " != 0) &&
               (lVar3 = il2cpp_internal(" ",*(uint64 *)(*plVar2 + 64))) == null) {
              uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar5,0);
            }
            lVar3 = " ";
            if (*(uint32 *)(plVar2 + 3) < 2) {
              uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar5,0);
            }
            plVar2[5] = " ";
            il2cpp_internal(plVar2 + 5,lVar3);
            iVar1 = CustomDifficultyData.GetDifficultyLv(this,9);
            lVar3 = "";
            if (iVar1 != 0) {
              iVar1 = CustomDifficultyData.GetDifficultyLv(this,9);
              if (iVar1 < 1) {
                lVar3 = *(int64 *)(pStatics_3d40 + 0x2d8);
              }
              else {
                lVar3 = *(int64 *)(pStatics_3d40 + 0x270);
              }
            }
            if ((lVar3 != null) &&
               (lVar4 = il2cpp_internal(lVar3,*(uint64 *)(*plVar2 + 64))) == null) {
              uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar5,0);
            }
            if (*(uint32 *)(plVar2 + 3) < 3) {
              uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar5,0);
            }
            plVar2[6] = lVar3;
            il2cpp_internal(plVar2 + 6,lVar3);
            lVar3 = CustomDifficultyData.teammateLimitName;
            iVar1 = CustomDifficultyData.GetDifficultyLv(this,9);
            if (lVar3 == null) goto LAB_180a4480b;
            if (*(uint32 *)(lVar3 + 24) <= iVar1 + 3U) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            lVar3 = *(int64 *)(*(int64 *)(lVar3 + 16) + 32 + (int64)(int)(iVar1 + 3U) * 8);
            if ((lVar3 != null) &&
               (lVar4 = il2cpp_internal(lVar3,*(uint64 *)(*plVar2 + 64))) == null) {
              uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar5,0);
            }
            if (*(uint32 *)(plVar2 + 3) < 4) {
              uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar5,0);
            }
            plVar2[7] = lVar3;
            il2cpp_internal(plVar2 + 7,lVar3);
            iVar1 = CustomDifficultyData.GetDifficultyLv(this,9);
            lVar3 = "</color>";
            if (iVar1 == 0) {
              lVar3 = "";
            }
            if ((lVar3 != null) &&
               (lVar4 = il2cpp_internal(lVar3,*(uint64 *)(*plVar2 + 64))) == null) {
              uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar5,0);
            }
            if (*(uint32 *)(plVar2 + 3) < 5) {
              uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar5,0);
            }
          }
          plVar6 = plVar2 + 8;
          goto LAB_180a447f1;
        }
        plVar2 = (int64 *)FUN_1800d60b0(DAT_181da5cf8,6);
        lVar3 = CustomDifficultyData.customDifficultyName;
        if (lVar3 == null) {
        LAB_180a4480b:
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
        if (*(uint32 *)(lVar3 + 24) <= customDifficultyType) {
          ThrowHelper.ThrowArgumentOutOfRangeException(0);
        }
        lVar3 = lVar3[customDifficultyType];
        if (plVar2 == (int64 *)0) goto LAB_180a4480b;
        if ((lVar3 != null) &&
           (lVar4 = il2cpp_internal(lVar3,*(uint64 *)(*plVar2 + 64))) == null) {
          uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
          FUN_1800d65f0(uVar5,0);
        }
        if ((int)plVar2[3] == 0) {
          uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
          FUN_1800d65f0(uVar5,0);
        }
        plVar2[4] = lVar3;
        il2cpp_internal(plVar2 + 4,lVar3);
        if ((" " != 0) &&
           (lVar3 = il2cpp_internal(" ",*(uint64 *)(*plVar2 + 64))) == null) {
          uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
          FUN_1800d65f0(uVar5,0);
        }
        lVar3 = " ";
        if (*(uint32 *)(plVar2 + 3) < 2) {
          uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
          FUN_1800d65f0(uVar5,0);
        }
        plVar2[5] = " ";
        il2cpp_internal(plVar2 + 5,lVar3);
        iVar1 = CustomDifficultyData.GetDifficultyLv(this,customDifficultyType);
        lVar3 = "";
        if (iVar1 != 0) {
          lVar3 = CustomDifficultyData.customDifficultyLvRate;
          if (lVar3 == null) goto LAB_180a4480b;
          if (*(uint32 *)(lVar3 + 24) <= customDifficultyType) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          if (lVar3[customDifficultyType] < 1) {
            iVar1 = CustomDifficultyData.GetDifficultyLv(this,customDifficultyType);
            if (-1 >= iVar1)
            {
              }
              else {
              iVar1 = CustomDifficultyData.GetDifficultyLv(this,customDifficultyType);
              if (iVar1 < 1) {
            }
              lVar3 = *(int64 *)(pStatics_3d40 + 0x2d8);
              goto LAB_180a446c6;
            }
            if (((*(byte *)(DAT_181d73d40 + 0x133) & 4) != 0) && (*(int *)(DAT_181d73d40 + 224) == 0)) {
              il2cpp_runtime_class_init(DAT_181d73d40);
              lVar3 = *(int64 *)(pStatics_3d40 + 0x270);
              goto LAB_180a446c6;
            }
          }
          lVar3 = *(int64 *)(pStatics_3d40 + 0x270);
        }
        LAB_180a446c6:
        if ((lVar3 != null) &&
           (lVar4 = il2cpp_internal(lVar3,*(uint64 *)(*plVar2 + 64))) == null) {
          uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
          FUN_1800d65f0(uVar5,0);
        }
        if (*(uint32 *)(plVar2 + 3) < 3) {
          uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
          FUN_1800d65f0(uVar5,0);
        }
        plVar2[6] = lVar3;
        il2cpp_internal(plVar2 + 6,lVar3);
        local_res10[0] = (float)CustomDifficultyData.GetDifficultyRate(this,customDifficultyType,0);
        local_res10[0] = local_res10[0] * 100.0;
        lVar3 = Single.ToString(local_res10,"+0;-0;+0",0);
        if ((lVar3 != null) &&
           (lVar4 = il2cpp_internal(lVar3,*(uint64 *)(*plVar2 + 64))) == null) {
          uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
          FUN_1800d65f0(uVar5,0);
        }
        if (*(uint32 *)(plVar2 + 3) < 4) {
          uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
          FUN_1800d65f0(uVar5,0);
        }
        plVar2[7] = lVar3;
        il2cpp_internal(plVar2 + 7,lVar3);
        if (("%" != 0) &&
           (lVar3 = il2cpp_internal("%",*(uint64 *)(*plVar2 + 64))) == null) {
          uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
          FUN_1800d65f0(uVar5,0);
        }
        lVar3 = "%";
        if (*(uint32 *)(plVar2 + 3) < 5) {
          uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
          FUN_1800d65f0(uVar5,0);
        }
        plVar2[8] = "%";
        il2cpp_internal(plVar2 + 8,lVar3);
        iVar1 = CustomDifficultyData.GetDifficultyLv(this,customDifficultyType,0);
        lVar3 = "</color>";
        if (iVar1 == 0) {
          lVar3 = "";
        }
        if ((lVar3 != null) &&
           (lVar4 = il2cpp_internal(lVar3,*(uint64 *)(*plVar2 + 64))) == null) {
          uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
          FUN_1800d65f0(uVar5,0);
        }
        if (*(uint32 *)(plVar2 + 3) < 6) {
          uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
          FUN_1800d65f0(uVar5,0);
        }
        plVar6 = plVar2 + 9;
        LAB_180a447f1:
        *plVar6 = lVar3;
        il2cpp_internal(plVar6,lVar3);
        lVar3 = String.Concat(plVar2,0);
        return lVar3;
    }

    // Token : 0x6000EF0
    // RVA   : 0xA45040   Offset: 0xA44440   Length: 0x151
    public int GetTotalDifficultyLv()
    {
        int iVar1;
        int iVar2;
        ulong uVar3;
        long lVar4;
        int iVar5;
        int iVar6;
        iVar5 = 0;
        iVar6 = 0;
        while( true ) {
          uVar3 = DAT_181db6510;
          uVar3 = Type.GetTypeFromHandle(uVar3,0);
          lVar4 = Enum.GetNames(uVar3,0);
          if (lVar4 == null) break;
          if (*(int *)(lVar4 + 24) <= iVar6) {
            return iVar5;
          }
          iVar1 = CustomDifficultyData.GetDifficultyLv(this,iVar6,0);
          if (*(int64 *)(*(int64 *)(DAT_181dbb6e0 + 184) + 8) == 0) break;
          iVar2 = FUN_1800d6760();
          iVar5 = iVar5 + iVar2 * iVar1;
          iVar6 = iVar6 + 1;
        }
    }

    // Token : 0x6000EF1
    // RVA   : 0xA44D50   Offset: 0xA44150   Length: 0x2E3
    public string GetTotalDifficultyLvDescribe()
    {
        var pStatics = *(int64*)(DAT_181d73d40 + 184);
        ulong uVar1;
        int[] local_res18 = new int[4];
        local_res18[0] = CustomDifficultyData.GetTotalDifficultyLv(this,0);
        if (local_res18[0] < -19) {
          uVar1 = Int32.ToString(local_res18,"+0;-0;0",0);
          String.Format("{1}极难{0}</color>",uVar1,*(uint64 *)(pStatics + 0x2d0),
                         0);
          return;
        }
        if (local_res18[0] < -9) {
          uVar1 = Int32.ToString(local_res18,"+0;-0;0",0);
          String.Format("{1}困难{0}</color>",uVar1,*(uint64 *)(pStatics + 0x2d8),
                         0);
          return;
        }
        if (-3 < local_res18[0]) {
          if (local_res18[0] < 3) {
            uVar1 = Int32.ToString(local_res18,"+0;-0;0",0);
            String.Format("平衡{0}",uVar1,0);
            return;
          }
          if (9 < local_res18[0]) {
            if (19 < local_res18[0]) {
              uVar1 = Int32.ToString(local_res18,"+0;-0;0");
              String.Format("{1}极易{0}</color>",uVar1,
                             *(uint64 *)(pStatics + 0x268),0);
              return;
            }
            uVar1 = Int32.ToString(local_res18,"+0;-0;0");
            String.Format("{1}容易{0}</color>",uVar1,
                           *(uint64 *)(pStatics + 0x270),0);
            return;
          }
          uVar1 = Int32.ToString(local_res18,"+0;-0;0");
          String.Format("{1}较易{0}</color>",uVar1,*(uint64 *)(pStatics + 0x270),
                         0);
          return;
        }
        uVar1 = Int32.ToString(local_res18,"+0;-0;0",0);
        String.Format("{1}较难{0}</color>",uVar1,*(uint64 *)(pStatics + 0x2d8),0)
        ;
    }

    // Token : 0x6000EF2
    // RVA   : 0xA43A20   Offset: 0xA42E20   Length: 0x21A
    public string GetCustomDifficultyFullDescribe()
    {
        int iVar1;
        ulong uVar2;
        ulong uVar3;
        long lVar4;
        int iVar5;
        uint[] local_res18 = new uint[2];
        iVar5 = 0;
        local_res18[0] = 0;
        uVar2 = CustomDifficultyData.GetTotalDifficultyLvDescribe(this,0);
        iVar1 = CustomDifficultyData.GetTotalDifficultyLv(this,0);
        uVar3 = "[可获取成就]";
        if (2 < iVar1) {
          uVar3 = "[不可获取成就]";
        }
        uVar3 = String.Format("<size=20>{0}</size>\n{1}",uVar2,uVar3,0);
        iVar1 = CustomDifficultyData.GetTotalDifficultyLv(this,0);
        iVar1 = Mathf.Clamp((int)((float)iVar1 * -0.1),0,10);
        if (iVar1 != 0) {
          iVar1 = CustomDifficultyData.GetTotalDifficultyLv(this,0);
          local_res18[0] = Mathf.Clamp((int)((float)iVar1 * -0.1),0,10);
          uVar2 = Int32.ToString(local_res18,"+0;-0;0",0);
          uVar2 = String.Format("\n[天赋数上限{0}]",uVar2,0);
          uVar3 = String.Concat(uVar3,uVar2,0);
        }
        while( true ) {
          uVar2 = DAT_181db6510;
          uVar2 = Type.GetTypeFromHandle(uVar2,0);
          lVar4 = Enum.GetNames(uVar2,0);
          if (lVar4 == null) break;
          if (*(int *)(lVar4 + 24) <= iVar5) {
            return uVar3;
          }
          uVar2 = CustomDifficultyData.GetDescribe(this,iVar5,0);
          uVar3 = String.Concat(uVar3,"\n",uVar2,0);
          iVar5 = iVar5 + 1;
        }
    }

    // Token : 0x6000EF3
    // RVA   : 0xA43A00   Offset: 0xA42E00   Length: 0x16
    public bool CanUnlockAchievement()
    {
        int iVar1;
        iVar1 = CustomDifficultyData.GetTotalDifficultyLv(this,0);
        return iVar1 < 3;
    }

    // Token : 0x6000EF4
    // RVA   : 0xA44D20   Offset: 0xA44120   Length: 0x30
    public int GetExtraMaxTagNum()
    {
        int iVar1;
        iVar1 = CustomDifficultyData.GetTotalDifficultyLv(this,0);
        Mathf.Clamp((int)((float)iVar1 * -0.1),0,10);
    }

    // Token : 0x6000EF5
    // RVA   : 0xA45260   Offset: 0xA44660   Length: 0x52A
    private static void /*cctor*/()
    {
        var pStatics = *(int64*)(DAT_181dbb6e0 + 184);
        long lVar1;
        lVar1 = il2cpp_internal(DAT_181d97768);
        FUN_181330100(lVar1,DAT_181da3bf0);
        if (lVar1 != null) {
          FUN_18181e6b0(lVar1,"经验倍率",DAT_181da3d70);
          FUN_18181e6b0(lVar1,"声望倍率",DAT_181da3d70);
          FUN_18181e6b0(lVar1,"负重倍率",DAT_181da3d70);
          FUN_18181e6b0(lVar1,"本门弟子经验",DAT_181da3d70);
          FUN_18181e6b0(lVar1,"非本门弟子经验",DAT_181da3d70);
          FUN_18181e6b0(lVar1,"随机敌人强度",DAT_181da3d70);
          FUN_18181e6b0(lVar1,"随机敌人数量",DAT_181da3d70);
          FUN_18181e6b0(lVar1,"恶名获取",DAT_181da3d70);
          FUN_18181e6b0(lVar1,"武学上限",DAT_181da3d70);
          FUN_18181e6b0(lVar1,"组队限制",DAT_181da3d70);
          FUN_18181e6b0(lVar1,"AI门派发展速度",DAT_181da3d70);
          plVar2 = pStatics;
          *plVar2 = lVar1;
          il2cpp_internal(plVar2,lVar1);
          lVar1 = il2cpp_internal(DAT_181d93ce8);
          FUN_181330100(lVar1,DAT_181d8f0b0);
          if (lVar1 != null) {
            FUN_18182a6c0(lVar1,2,DAT_181d8f230);
            FUN_18182a6c0(lVar1,1,DAT_181d8f230);
            FUN_18182a6c0(lVar1,1,DAT_181d8f230);
            FUN_18182a6c0(lVar1,1,DAT_181d8f230);
            FUN_18182a6c0(lVar1,0xfffffffe,DAT_181d8f230);
            FUN_18182a6c0(lVar1,0xfffffffe,DAT_181d8f230);
            FUN_18182a6c0(lVar1,0xfffffffe,DAT_181d8f230);
            FUN_18182a6c0(lVar1,0xffffffff,DAT_181d8f230);
            FUN_18182a6c0(lVar1,2,DAT_181d8f230);
            FUN_18182a6c0(lVar1,2,DAT_181d8f230);
            FUN_18182a6c0(lVar1,0xffffffff,DAT_181d8f230);
            CustomDifficultyData.customDifficultyLvRate = lVar1;
            lVar1 = il2cpp_internal(DAT_181d97768);
            FUN_181330100(lVar1,DAT_181da3bf0);
            if (lVar1 != null) {
              FUN_18181e6b0(lVar1,"苛刻",DAT_181da3d70);
              FUN_18181e6b0(lVar1,"严格",DAT_181da3d70);
              FUN_18181e6b0(lVar1,"限制",DAT_181da3d70);
              FUN_18181e6b0(lVar1,"适中",DAT_181da3d70);
              FUN_18181e6b0(lVar1,"自由",DAT_181da3d70);
              CustomDifficultyData.teammateLimitName = lVar1;
              lVar1 = il2cpp_internal(DAT_181d97768);
              FUN_181330100(lVar1,DAT_181da3bf0);
              if (lVar1 != null) {
                FUN_18181e6b0(lVar1,"入队好感消耗20\n对方最高比玩家低1级",DAT_181da3d70);
                FUN_18181e6b0(lVar1,"入队好感消耗15\n对方最高与玩家同级",DAT_181da3d70);
                FUN_18181e6b0(lVar1,"入队好感消耗10\n对方最高比玩家高1级",DAT_181da3d70);
                FUN_18181e6b0(lVar1,"入队好感消耗5\n对方最高比玩家高2级",DAT_181da3d70);
                FUN_18181e6b0(lVar1,"入队无好感消耗\n无等级限制",DAT_181da3d70);
                CustomDifficultyData.teammateLimitDescribe = lVar1;
                return;
              }
            }
          }
        }
    }

}
