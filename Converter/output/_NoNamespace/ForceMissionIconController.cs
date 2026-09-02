// ============================================================
// Type  : ForceMissionIconController
// Token : 0x2000289
// ============================================================

public class ForceMissionIconController
{
    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6001488
    // RVA   : 0x77EF20   Offset: 0x77D720   Length: 0x560
    public void OnClick()
    {
        var pStatics_df90 = *(int64*)(DAT_181d4df90 + 184);
        var pStatics_e188 = *(int64*)(DAT_181d4e188 + 184);
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
        if (*pStatics_df90 == 0) throw; // [null/range check failed]
        cVar1 = GameController.HaveSpeUI(*pStatics_df90,1,0);
        uVar7 = "Sound/SoundEffect/WrongClick";
        if (cVar1) {
        LAB_18077f423:
          plVar6 = (int64 *)Resources.Load(uVar7,0);
          plVar8 = (int64 *)0;
          if ((plVar6 != (int64 *)0) && (*plVar6 == DAT_181d8a228)) {
            plVar8 = plVar6;
          }
          NGUITools.PlaySound(plVar8,0);
          return;
        }
        if ((*pStatics_e188 == 0) ||
           (lVar2 = *(int64 *)(*pStatics_e188 + 32)) == null)
        throw; // [null/range check failed]
        cVar1 = GameObject.get_activeSelf(lVar2,0);
        uVar7 = "Sound/SoundEffect/WrongClick";
        if (!cVar1) goto LAB_18077f423;
        lVar2 = FUN_18046c0a0(0);
        if (((lVar2 == null) || (*(int64 *)(lVar2 + 32) == 0)) ||
           (lVar2 = WorldData.Player(*(int64 *)(lVar2 + 32),0)) == null) throw; // [null/range check failed]
        if (*(int64 *)(lVar2 + 0x2e0) != 0) {
          lVar2 = FUN_18046c0a0(0);
          if (((lVar2 == null) || (*(int64 *)(lVar2 + 32) == 0)) ||
             ((lVar2 = WorldData.Player(*(int64 *)(lVar2 + 32),0), lVar2 == null ||
              ((*(int64 *)(lVar2 + 0x2e0) == 0 ||
               (lVar2 = MissionData.GetTargetAreaID(*(int64 *)(lVar2 + 0x2e0),0)) == null)))))
          throw; // [null/range check failed]
          if (0 < *(int *)(lVar2 + 24)) {
            lVar2 = FUN_18046bbe0(0);
            lVar3 = FUN_18046bbe0(0);
            if (lVar3 != null) {
              lVar3 = *(int64 *)(lVar3 + 96);
              lVar4 = FUN_18046c0a0(0);
              if ((((lVar4 != null) && (*(int64 *)(lVar4 + 32) != 0)) &&
                  (lVar4 = WorldData.Player(*(int64 *)(lVar4 + 32),0)) != null) &&
                 ((*(int64 *)(lVar4 + 0x2e0) != 0 &&
                  (lVar4 = MissionData.GetTargetAreaID(*(int64 *)(lVar4 + 0x2e0),0)) != null))) {
                if (*(int *)(lVar4 + 24) == 0) {
                  ThrowHelper.ThrowArgumentOutOfRangeException(0);
                }
                if (((lVar3 != null) &&
                    (lVar3 = FUN_1817cc780(lVar3,*(uint32 *)(*(int64 *)(lVar4 + 16) + 32),
                                           DAT_181d946c8), lVar3 != null)) &&
                   (lVar3 = GameObject.get_transform(lVar3,0)) != null) {
                  puVar5 = (uint64 *)Transform.get_localPosition(local_18,lVar3,0);
                  if (lVar2 != null) {
                    local_38 = (uint32)*puVar5;
                    uStack_24 = (uint32)((uint64)*puVar5 >> 32);
                    *(uint32 *)(lVar2 + 160) = local_38;
                    *(uint32 *)(lVar2 + 164) = uStack_24;
                    uVar7 = "Sound/SoundEffect/Woosh";
                    goto LAB_18077f423;
                  }
                }
              }
            }
            throw; // [null/range check failed]
          }
        }
        lVar2 = FUN_18046c0a0(0);
        if (((lVar2 != null) && (*(int64 *)(lVar2 + 32) != 0)) &&
           (lVar2 = WorldData.Player(*(int64 *)(lVar2 + 32),0)) != null) {
          if (*(int *)(lVar2 + 132) < 0) {
            return;
          }
          lVar2 = FUN_18046bbe0(0);
          lVar3 = FUN_18046bbe0(0);
          if (lVar3 != null) {
            lVar3 = *(int64 *)(lVar3 + 96);
            lVar4 = FUN_18046c0a0(0);
            if ((((lVar4 != null) && (*(int64 *)(lVar4 + 32) != 0)) &&
                (lVar4 = WorldData.Player(*(int64 *)(lVar4 + 32),0)) != null) &&
               (((lVar4 = HeroData.GetForce(lVar4,0,0), lVar4 != null && (lVar3 != null)) &&
                ((lVar3 = FUN_1817cc780(lVar3,*(uint32 *)(lVar4 + 56),DAT_181d946c8), lVar3 != null &&
                 (lVar3 = GameObject.get_transform(lVar3,0)) != null))))) {
              puVar5 = (uint64 *)Transform.get_localPosition(local_18,lVar3,0);
              if (lVar2 != null) {
                local_28 = (uint32)*puVar5;
                uStack_34 = (uint32)((uint64)*puVar5 >> 32);
                *(uint32 *)(lVar2 + 160) = local_28;
                *(uint32 *)(lVar2 + 164) = uStack_34;
                uVar7 = "Sound/SoundEffect/Woosh";
                goto LAB_18077f423;
              }
            }
          }
        }
    }

    // Token : 0x6001489
    // RVA   : 0x3A17B0   Offset: 0x39FFB0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_18044ef50(this,0);
    }

}
