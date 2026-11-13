// ============================================================
// Type  : PlayerInteractionTimeData
// Token : 0x200021C
// ============================================================

public class PlayerInteractionTimeData
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4000F77
    public List<int> playerInteractTimeList;

    // Token: 0x4000F78
    public int selfBountyType;

    // Token: 0x4000F79
    public MissionData selfBountyMission;

    // Token: 0x4000F7A
    public int releaseHateTime;

    // Token: 0x4000F7B
    public int attackPlayerTime;

    // Token: 0x4000F7C
    public int givePlayerGiftTime;

    // Token: 0x4000F7D
    public bool teachPlayerSkill;

    // Token: 0x4000F7E
    public int invitePlayTime;

    // Token: 0x4000F7F
    public int invitePlayType;

    // Token: 0x4000F80
    public int askItemTime;

    // Token: 0x4000F81
    public int releasePlayerHateTime;

    // Token: 0x4000F82
    public int speMailMissionID;

    // Token: 0x4000F83
    public string speMailMissionTarget;

    // Token: 0x4000F84
    public bool loverUnhappy;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6001083
    // RVA   : 0x211A00   Offset: 0x210800   Length: 0xF0
    public void ResetTime()
    {
        long lVar1;
        int iVar2;
        lVar1 = this.playerInteractTimeList;
        iVar2 = 0;
        do {
          if (lVar1 == null) {
        LAB_180211aeb:
                          // WARNING: Subroutine does not return
            FUN_1801e0300();
          }
          if (lVar1.Count <= iVar2) {
            this.releaseHateTime = 1;
            this.attackPlayerTime = 1;
            if (lVar1 != null) {
              FUN_181774110(lVar1,20,3,DAT_181e71cf0);
              if (this.playerInteractTimeList != null) {
                FUN_181774110(this.playerInteractTimeList,7,0,DAT_181e71cf0);
                this.selfBountyMission = 0;
                this.selfBountyType = 0xffffffff;
                return;
              }
            }
            goto LAB_180211aeb;
          }
          if (lVar1 == null) goto LAB_180211aeb;
          FUN_181774110(lVar1,iVar2,1,DAT_181e71cf0);
          lVar1 = this.playerInteractTimeList;
          iVar2 = iVar2 + 1;
        } while( true );
    }

    // Token : 0x6001084
    // RVA   : 0x211B00   Offset: 0x210900   Length: 0x215
    public void /*ctor*/()
    {
        uint uVar1;
        ulong uVar2;
        long lVar3;
        ulong uVar4;
        int iVar5;
        uVar2 = DAT_181e9ea30;
        uVar2 = Type.GetTypeFromHandle(uVar2,0);
        lVar3 = Enum.GetValues(uVar2,0);
        if (lVar3 != null) {
          uVar1 = FUN_181162560(lVar3,0);
          uVar2 = FUN_1801dfd90(DAT_181e836f8,uVar1);
          uVar4 = il2cpp_internal(DAT_181e73cb8);
          FUN_18177a7d0(uVar4,uVar2,DAT_181e712f0);
          this.playerInteractTimeList = uVar4;
          ZhSegment.Initialize(this);
          iVar5 = 0;
          lVar3 = this.playerInteractTimeList;
          while (lVar3 != null) {
            if (lVar3.Count <= iVar5) {
              this.releaseHateTime = 1;
              this.attackPlayerTime = 1;
              if (lVar3 != null) {
                FUN_181774110(lVar3,20,3,DAT_181e71cf0);
                if (this.playerInteractTimeList != null) {
                  FUN_181774110(this.playerInteractTimeList,7,0,DAT_181e71cf0);
                  this.selfBountyMission = 0;
                  this.selfBountyType = 0xffffffff;
                  return;
                }
              }
              break;
            }
            if (lVar3 == null) break;
            FUN_181774110(lVar3,iVar5,1,DAT_181e71cf0);
            iVar5 = iVar5 + 1;
            lVar3 = this.playerInteractTimeList;
          }
        }
    }

    // Token : 0x6001085
    // RVA   : 0x211760   Offset: 0x210560   Length: 0x11D
    public void CheckGameUpdate()
    {
        int iVar1;
        int iVar2;
        ulong uVar3;
        long lVar4;
        lVar4 = this.playerInteractTimeList;
        uVar3 = DAT_181e9ea30;
        while (DAT_181e9ea30 = uVar3, lVar4 != null) {
          iVar1 = lVar4.Count;
          uVar3 = Type.GetTypeFromHandle(uVar3,0);
          lVar4 = Enum.GetValues(uVar3,0);
          if (lVar4 == null) break;
          iVar2 = FUN_181162560(lVar4,0);
          if (iVar2 <= iVar1) {
            return;
          }
          if (this.playerInteractTimeList == null) break;
          FUN_181769fe0(this.playerInteractTimeList,1,DAT_181e713f0);
          uVar3 = DAT_181e9ea30;
          lVar4 = this.playerInteractTimeList;
        }
    }

    // Token : 0x6001086
    // RVA   : 0x211880   Offset: 0x210680   Length: 0x175
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
        plVar1 = (int64 *)il2cpp_internal(DAT_181e695f0);
        plVar4 = plVar1;
        MemoryStream.ctor(plVar1,1000,0);
        local_38 = 0;
        uStack_30 = 0;
        StreamingContext.ctor(&local_38,64,0);
        lVar2 = il2cpp_internal(DAT_181e91a00);
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
            FUN_180002280(0,DAT_181e58ab8,plVar1);
            return uVar3;
          }
                          // WARNING: Subroutine does not return
          FUN_1801e0300();
        }
    }

}
