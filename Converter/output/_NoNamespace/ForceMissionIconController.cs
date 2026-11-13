// ============================================================
// Type  : ForceMissionIconController
// Token : 0x2000297
// ============================================================

public class ForceMissionIconController
{
    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6001538
    // RVA   : 0x1850D10   Offset: 0x184FB10   Length: 0x565
    public void OnClick()
    {
        var pStatics_2a90 = *(int64*)(DAT_181e52a90 + 184);
        bool cVar1;
        long lVar2;
        long lVar3;
        long lVar4;
        ulong uVar7;
        uint local_38;
        uint uStack_34;
        uint local_28;
        uint uStack_24;
        byte[] local_18 = new byte[16];
        if (GameController._instance == null) throw; // [null/range check failed]
        cVar1 = GameController.HaveSpeUI(GameController._instance,1,0);
        uVar7 = "Sound/SoundEffect/WrongClick";
        if (cVar1) {
        LAB_181851218:
          plVar6 = (int64 *)Resources.Load(uVar7,0);
          plVar8 = (int64 *)0;
          if ((plVar6 != (int64 *)0) && (*plVar6 == DAT_181e8f4a0)) {
            plVar8 = plVar6;
          }
          NGUITools.PlaySound(plVar8,0);
          return;
        }
        if ((*pStatics_2a90 == 0) ||
           (lVar2 = *(int64 *)(*pStatics_2a90 + 32)) == null)
        throw; // [null/range check failed]
        cVar1 = GameObject.get_activeSelf(lVar2,0);
        uVar7 = "Sound/SoundEffect/WrongClick";
        if (!cVar1) goto LAB_181851218;
        lVar2 = FUN_1802106e0(0);
        if (((lVar2 == null) || (*(int64 *)(lVar2 + 32) == 0)) ||
           (lVar2 = WorldData.Player(*(int64 *)(lVar2 + 32),0)) == null) throw; // [null/range check failed]
        if (*(int64 *)(lVar2 + 0x2e0) != 0) {
          lVar2 = FUN_1802106e0(0);
          if (((lVar2 == null) || (*(int64 *)(lVar2 + 32) == 0)) ||
             ((lVar2 = WorldData.Player(*(int64 *)(lVar2 + 32),0), lVar2 == null ||
              ((*(int64 *)(lVar2 + 0x2e0) == 0 ||
               (lVar2 = MissionData.GetTargetAreaID(*(int64 *)(lVar2 + 0x2e0),0)) == null)))))
          throw; // [null/range check failed]
          if (0 < *(int *)(lVar2 + 24)) {
            lVar2 = FUN_180210220(0);
            lVar3 = FUN_180210220(0);
            if (lVar3 != null) {
              lVar3 = *(int64 *)(lVar3 + 96);
              lVar4 = FUN_1802106e0(0);
              if ((((lVar4 != null) && (*(int64 *)(lVar4 + 32) != 0)) &&
                  (lVar4 = WorldData.Player(*(int64 *)(lVar4 + 32),0)) != null) &&
                 ((*(int64 *)(lVar4 + 0x2e0) != 0 &&
                  (lVar4 = MissionData.GetTargetAreaID(*(int64 *)(lVar4 + 0x2e0),0)) != null))) {
                if (*(int *)(lVar4 + 24) == 0) {
                  ThrowHelper.ThrowArgumentOutOfRangeException(0);
                }
                if (((lVar3 != null) &&
                    (lVar3 = FUN_18171b450(lVar3,*(uint32 *)(*(int64 *)(lVar4 + 16) + 32),
                                           DAT_181e9b4c0), lVar3 != null)) &&
                   (lVar3 = GameObject.get_transform(lVar3,0)) != null) {
                  puVar5 = (uint64 *)Transform.get_localPosition(local_18,lVar3,0);
                  if (lVar2 != null) {
                    local_38 = (uint32)*puVar5;
                    uStack_24 = (uint32)((uint64)*puVar5 >> 32);
                    *(uint32 *)(lVar2 + 168) = local_38;
                    *(uint32 *)(lVar2 + 172) = uStack_24;
                    uVar7 = "Sound/SoundEffect/Woosh";
                    goto LAB_181851218;
                  }
                }
              }
            }
            throw; // [null/range check failed]
          }
        }
        lVar2 = FUN_1802106e0(0);
        if (((lVar2 != null) && (*(int64 *)(lVar2 + 32) != 0)) &&
           (lVar2 = WorldData.Player(*(int64 *)(lVar2 + 32),0)) != null) {
          cVar1 = HeroData.HaveForce(lVar2,0);
          if (!cVar1) {
            return;
          }
          lVar2 = FUN_180210220(0);
          lVar3 = FUN_180210220(0);
          if (lVar3 != null) {
            lVar3 = *(int64 *)(lVar3 + 96);
            lVar4 = FUN_1802106e0(0);
            if ((((lVar4 != null) && (*(int64 *)(lVar4 + 32) != 0)) &&
                (lVar4 = WorldData.Player(*(int64 *)(lVar4 + 32),0)) != null) &&
               (((lVar4 = HeroData.GetForce(lVar4,0,0), lVar4 != null && (lVar3 != null)) &&
                ((lVar3 = FUN_18171b450(lVar3,*(uint32 *)(lVar4 + 56),DAT_181e9b4c0), lVar3 != null &&
                 (lVar3 = GameObject.get_transform(lVar3,0)) != null))))) {
              puVar5 = (uint64 *)Transform.get_localPosition(local_18,lVar3,0);
              if (lVar2 != null) {
                local_28 = (uint32)*puVar5;
                uStack_34 = (uint32)((uint64)*puVar5 >> 32);
                *(uint32 *)(lVar2 + 168) = local_28;
                *(uint32 *)(lVar2 + 172) = uStack_34;
                uVar7 = "Sound/SoundEffect/Woosh";
                goto LAB_181851218;
              }
            }
          }
        }
    }

    // Token : 0x6001539
    // RVA   : 0x2110A0   Offset: 0x20FEA0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_180ae8740(this,0);
    }

}
