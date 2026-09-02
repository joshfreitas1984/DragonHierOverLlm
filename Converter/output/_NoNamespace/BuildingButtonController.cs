// ============================================================
// Type  : BuildingButtonController
// Token : 0x20001A9
// ============================================================

public class BuildingButtonController
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4000B2E
    public AreaBuildingChoice areaBuildingChoice;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000D9B
    // RVA   : 0xBB5CD0   Offset: 0xBB44D0   Length: 0x226
    public void OnClick()
    {
        var pStatics = *(int64*)(DAT_181d4df90 + 184);
        bool cVar1;
        long lVar2;
        long lVar3;
        if (this.areaBuildingChoice == null) throw; // [null/range check failed]
        lVar2 = this.areaBuildingChoice.callFuc;
        if (lVar2 != null) {
          cVar1 = FUN_1816fd990(lVar2,"",0);
          if (!cVar1) {
            lVar2 = FUN_18046bca0(0);
            if (lVar2 != null) {
              lVar2.subCondition = this.areaBuildingChoice;
              if (this.areaBuildingChoice != null) {
                cVar1 = FUN_1816fd990(this.areaBuildingChoice.callFucParam,"",
                                      0);
                if (!cVar1) {
                  if (this.areaBuildingChoice == null) throw; // [null/range check failed]
                  if (this.areaBuildingChoice.callFucParam != null) {
                    lVar3 = FUN_18046bca0(0);
                    lVar2 = this.areaBuildingChoice;
                    if ((lVar2 != null) && (lVar3 != null)) {
                      Component.SendMessage
                                (lVar3,lVar2.callFuc,lVar2.callFucParam,0);
                      return;
                    }
                    throw; // [null/range check failed]
                  }
                }
                lVar2 = FUN_18046bca0(0);
                if ((this.areaBuildingChoice != null) && (lVar2 != null)) {
                  Component.SendMessage(lVar2,this.areaBuildingChoice.callFuc,0);
                  return;
                }
              }
            }
            throw; // [null/range check failed]
          }
        }
        if (*pStatics != 0) {
          GameController.ShowTextOnMouse(*pStatics,"功能未解锁！",0);
          return;
        }
    }

    // Token : 0x6000D9C
    // RVA   : 0x3A17B0   Offset: 0x39FFB0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_18044ef50(this,0);
    }

}
