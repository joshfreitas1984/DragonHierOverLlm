// ============================================================
// Type  : BuildingButtonController
// Token : 0x20001B1
// ============================================================

public class BuildingButtonController
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4000BCB
    public AreaBuildingChoice areaBuildingChoice;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000DD2
    // RVA   : 0x919140   Offset: 0x917F40   Length: 0x226
    public void OnClick()
    {
        bool cVar1;
        long lVar2;
        long lVar3;
        if (this.areaBuildingChoice == null) throw; // [null/range check failed]
        lVar2 = this.areaBuildingChoice.callFuc;
        if (lVar2 != null) {
          cVar1 = FUN_1816387f0(lVar2,"",0);
          if (!cVar1) {
            lVar2 = FUN_1802102e0(0);
            if (lVar2 != null) {
              lVar2.subCondition = this.areaBuildingChoice;
              if (this.areaBuildingChoice != null) {
                cVar1 = FUN_1816387f0(this.areaBuildingChoice.callFucParam,"",
                                      0);
                if (!cVar1) {
                  if (this.areaBuildingChoice == null) throw; // [null/range check failed]
                  if (this.areaBuildingChoice.callFucParam != null) {
                    lVar3 = FUN_1802102e0(0);
                    lVar2 = this.areaBuildingChoice;
                    if ((lVar2 != null) && (lVar3 != null)) {
                      Component.SendMessage
                                (lVar3,lVar2.callFuc,lVar2.callFucParam,0);
                      return;
                    }
                    throw; // [null/range check failed]
                  }
                }
                lVar2 = FUN_1802102e0(0);
                if ((this.areaBuildingChoice != null) && (lVar2 != null)) {
                  Component.SendMessage(lVar2,this.areaBuildingChoice.callFuc,0);
                  return;
                }
              }
            }
            throw; // [null/range check failed]
          }
        }
        if (GameController._instance != null) {
          GameController.ShowTextOnMouse(GameController._instance,"功能未解锁！",0);
          return;
        }
    }

    // Token : 0x6000DD3
    // RVA   : 0x2110A0   Offset: 0x20FEA0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_180ae8740(this,0);
    }

}
