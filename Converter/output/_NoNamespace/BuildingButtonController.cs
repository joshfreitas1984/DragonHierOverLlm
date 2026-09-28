// ============================================================
// Type  : BuildingButtonController
// Token : 0x20001AF
// ============================================================

public class BuildingButtonController
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4000BBA
    public AreaBuildingChoice areaBuildingChoice;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000DCF
    // RVA   : 0xB5F860   Offset: 0xB5EC60   Length: 0x226
    public void OnClick()
    {
        var pStatics = *(int64*)(DAT_181d72cc8 + 184);
        bool cVar1;
        long lVar2;
        long lVar3;
        if (this.areaBuildingChoice == null) throw; // [null/range check failed]
        lVar2 = this.areaBuildingChoice.callFuc;
        if (lVar2 != null) {
          cVar1 = FUN_18171e540(lVar2,"",0);
          if (!cVar1) {
            lVar2 = FUN_18046bca0(0);
            if (lVar2 != null) {
              lVar2.subCondition = this.areaBuildingChoice;
              if (this.areaBuildingChoice != null) {
                cVar1 = FUN_18171e540(this.areaBuildingChoice.callFucParam,"",
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

    // Token : 0x6000DD0
    // RVA   : 0x3A17B0   Offset: 0x3A0BB0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_18044ef50(this,0);
    }

}
