// ============================================================
// Type  : HeroAISettingData
// Token : 0x200012F
// ============================================================

public class HeroAISettingData
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x400076C
    public Dictionary<AISettingType, AISettingData> heroAISettingDatas;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60009B6
    // RVA   : 0x877B40   Offset: 0x876340   Length: 0x199
    public void /*ctor*/()
    {
        long lVar2;
        ulong uVar3;
        bool cVar4;
        int iVar5;
        ZhSegment.Initialize(this,0);
        lVar2 = il2cpp_internal(DAT_181d5afc8);
        FUN_1808ae540(lVar2,DAT_181d8d3a8);
        this.heroAISettingDatas = lVar2;
        iVar5 = 0;
        while( true ) {
          uVar3 = DAT_181d8e748;
          uVar3 = Type.GetTypeFromHandle(uVar3,0);
          lVar2 = Enum.GetNames(uVar3,0);
          if (lVar2 == null) break;
          if (*(int *)(lVar2 + 24) <= iVar5) {
            return;
          }
          lVar2 = *plVar1;
          if (iVar5 < 2) {
            cVar4 = '\x03';
          }
          else {
            cVar4 = (iVar5 < 4) + true;
          }
          uVar3 = new AISettingData(cVar4,0);
          if (lVar2 == null) break;
          FUN_1808ab680(lVar2,iVar5,uVar3,DAT_181d8d430);
          iVar5 = iVar5 + 1;
        }
    }

    // Token : 0x60009B7
    // RVA   : 0x8779F0   Offset: 0x8761F0   Length: 0x14A
    public void Reset()
    {
        ulong uVar1;
        long lVar2;
        bool cVar3;
        int iVar4;
        iVar4 = 0;
        while( true ) {
          uVar1 = DAT_181d8e748;
          uVar1 = Type.GetTypeFromHandle(uVar1,0);
          lVar2 = Enum.GetNames(uVar1,0);
          if (lVar2 == null) break;
          if (lVar2.entries <= iVar4) {
            return;
          }
          lVar2 = this.heroAISettingDatas;
          if (iVar4 < 2) {
            cVar3 = '\x03';
          }
          else {
            cVar3 = (iVar4 < 4) + true;
          }
          uVar1 = new AISettingData(cVar3,0);
          if (lVar2 == null) break;
          FUN_1808aec90(lVar2,iVar4,uVar1,DAT_181d8d5c8);
          iVar4 = iVar4 + 1;
        }
    }

    // Token : 0x60009B8
    // RVA   : 0x877700   Offset: 0x875F00   Length: 0x2E3
    public string GetFocusText(int AISettingID)
    {
        var pStatics = *(int64*)(DAT_181d4ef00 + 184);
        long lVar1;
        long lVar2;
        ulong uVar3;
        long lVar4;
        if ((this.heroAISettingDatas != null) &&
           (lVar1 = FUN_1817cc3c0(this.heroAISettingDatas,AISettingID,DAT_181d8d540)) != null) {
          if (*(int *)(lVar1 + 20) < 0) {
            return "";
          }
          if (AISettingID == 1) {
            lVar1 = FUN_18046c100(0);
            if (((this.heroAISettingDatas != null) &&
                (lVar2 = FUN_1817cc3c0(this.heroAISettingDatas,1,DAT_181d8d540)) != null) &&
               (lVar1 != null)) {
              lVar1 = GameDataController.GetSkillDataBase(lVar1,*(uint32 *)(lVar2 + 20),0);
              if (lVar1 != null) {
                uVar3 = KungfuSkillData.Name(lVar1,1,0);
                return uVar3;
              }
            }
          }
          else if (AISettingID == 2) {
            lVar1 = *(int64 *)(pStatics + 0x4a8);
            if (((this.heroAISettingDatas != null) &&
                (lVar2 = FUN_1817cc3c0(this.heroAISettingDatas,2,DAT_181d8d540)) != null) &&
               (lVar1 != null)) {
              lVar4 = (int64)(int)*(uint32 *)(lVar2 + 20);
              if (*(uint32 *)(lVar1 + 24) <= *(uint32 *)(lVar2 + 20)) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
        LAB_1808778d1:
              return *(uint64 *)(*(int64 *)(lVar1 + 16) + 32 + lVar4 * 8);
            }
          }
          else if (AISettingID == 3) {
            lVar1 = *(int64 *)(pStatics + 0x430);
            if (((this.heroAISettingDatas != null) &&
                (lVar2 = FUN_1817cc3c0(this.heroAISettingDatas,3,DAT_181d8d540)) != null) &&
               (lVar1 != null)) {
              lVar4 = (int64)(int)*(uint32 *)(lVar2 + 20);
              if (*(uint32 *)(lVar1 + 24) <= *(uint32 *)(lVar2 + 20)) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              goto LAB_1808778d1;
            }
          }
          else {
            if ((AISettingID != 4) && (AISettingID != 5)) {
              return "";
            }
            lVar1 = FUN_18046c0a0(0);
            if (lVar1 != null) {
              lVar1 = *(int64 *)(lVar1 + 32);
              if ((((this.heroAISettingDatas != null) &&
                   (lVar2 = FUN_1817cc3c0(this.heroAISettingDatas,AISettingID,DAT_181d8d540), lVar2 != null
                   )) && (lVar1 != null)) &&
                 (lVar1 = WorldData.GetArea(lVar1,*(uint32 *)(lVar2 + 20),0)) != null) {
                return *(uint64 *)(lVar1 + 24);
              }
            }
          }
        }
    }

}
