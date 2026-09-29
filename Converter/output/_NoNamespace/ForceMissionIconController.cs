// ============================================================
// Type  : ForceMissionIconController
// Token : 0x200028F
// ============================================================

public class ForceMissionIconController
{
    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60014CC
    // RVA   : 0x77B830   Offset: 0x77AC30   Length: 0x565
    public void OnClick()
    {
        var pStatics_2ee8 = *(int64*)(DAT_181d72ee8 + 184);
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
        LAB_18077bd38:
          plVar6 = (int64 *)Resources.Load(uVar7,0);
          plVar8 = (int64 *)0;
          if ((plVar6 != (int64 *)0) && (*plVar6 == DAT_181daf360)) {
            plVar8 = plVar6;
          }
          NGUITools.PlaySound(plVar8,0);
          return;
        }
        if ((*pStatics_2ee8 == 0) ||
           (lVar2 = *(int64 *)(*pStatics_2ee8 + 32)) == null)
        throw; // [null/range check failed]
        cVar1 = GameObject.get_activeSelf(lVar2,0);
        uVar7 = "Sound/SoundEffect/WrongClick";
        if (!cVar1) goto LAB_18077bd38;
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
                    (lVar3 = FUN_1817da420(lVar3,*(uint32 *)(*(int64 *)(lVar4 + 16) + 32),
                                           DAT_181db9ee8), lVar3 != null)) &&
                   (lVar3 = GameObject.get_transform(lVar3,0)) != null) {
                  puVar5 = (uint64 *)Transform.get_localPosition(local_18,lVar3,0);
                  if (lVar2 != null) {
                    local_38 = (uint32)*puVar5;
                    uStack_24 = (uint32)((uint64)*puVar5 >> 32);
                    *(uint32 *)(lVar2 + 168) = local_38;
                    *(uint32 *)(lVar2 + 172) = uStack_24;
                    uVar7 = "Sound/SoundEffect/Woosh";
                    goto LAB_18077bd38;
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
          cVar1 = HeroData.HaveForce(lVar2,0);
          if (!cVar1) {
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
                ((lVar3 = FUN_1817da420(lVar3,*(uint32 *)(lVar4 + 56),DAT_181db9ee8), lVar3 != null &&
                 (lVar3 = GameObject.get_transform(lVar3,0)) != null))))) {
              puVar5 = (uint64 *)Transform.get_localPosition(local_18,lVar3,0);
              if (lVar2 != null) {
                local_28 = (uint32)*puVar5;
                uStack_34 = (uint32)((uint64)*puVar5 >> 32);
                *(uint32 *)(lVar2 + 168) = local_28;
                *(uint32 *)(lVar2 + 172) = uStack_34;
                uVar7 = "Sound/SoundEffect/Woosh";
                goto LAB_18077bd38;
              }
            }
          }
        }
    }

    // Token : 0x60014CD
    // RVA   : 0x3A17B0   Offset: 0x3A0BB0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_18044ef50(this,0);
    }

}
