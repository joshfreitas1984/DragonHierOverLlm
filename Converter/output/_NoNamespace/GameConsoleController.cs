// ============================================================
// Type  : GameConsoleController
// Token : 0x2000297
// ============================================================

public class GameConsoleController
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x400143E
    private GameObject gameConsole;

    // Token: 0x400143F
    private InputField inputField;

    // Token: 0x4001440
    private Text ouputText;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60014FE
    // RVA   : 0x245810   Offset: 0x244010   Length: 0x3
    private void Start()
    {
    }

    // Token : 0x60014FF
    // RVA   : 0x7905A0   Offset: 0x78EDA0   Length: 0x33B
    private void Update()
    {
        bool cVar2;
        ulong uVar3;
        long lVar4;
        cVar2 = FUN_1804625f0(0x132,0);
        if ((cVar2) && (cVar2 = FUN_1804625b0(96), cVar2)) {
          lVar4 = this.gameConsole;
          if (lVar4 == null) throw; // [null/range check failed]
          cVar2 = GameObject.get_activeSelf(lVar4,0);
          GameObject.SetActive(lVar4,!cVar2,0);
          if (this.gameConsole == null) throw; // [null/range check failed]
          cVar2 = GameObject.get_activeSelf(this.gameConsole,0);
          if (cVar2) {
            if (this.inputField == null) throw; // [null/range check failed]
            InputField.ActivateInputField(this.inputField,0);
          }
        }
        if (this.gameConsole != null) {
          cVar2 = GameObject.get_activeInHierarchy(this.gameConsole,0);
          if (!cVar2) {
            return;
          }
          cVar2 = GlobalData.IsInputing(0);
          if (!cVar2) {
            return;
          }
          if (this.inputField != null) {
            lVar4 = *(int64 *)(this.inputField + 0x170);
            cVar2 = FUN_1804625b0(13);
            if (!cVar2) {
              cVar2 = FUN_1804625b0(0x111,0);
              if (!cVar2) {
                cVar2 = FUN_1804625b0(0x112,0);
                if (!cVar2) {
                  return;
                }
                lVar4 = this.inputField;
                uVar3 = Console.Next(0);
              }
              else {
                lVar4 = this.inputField;
                uVar3 = Console.Last(0);
              }
            }
            else {
              if (lVar4 == null) throw; // [null/range check failed]
              cVar2 = String.Equals(lVar4,"",0);
              if (cVar2) {
                return;
              }
              plVar1 = this.ouputText;
              if (plVar1 == (int64 *)0) throw; // [null/range check failed]
              uVar3 = (**(code **)(*plVar1 + 0x5d8))(plVar1,*(uint64 *)(*plVar1 + 0x5e0));
              uVar3 = String.Concat(uVar3,">>",lVar4,"\n",0);
              (**(code **)(*plVar1 + 0x5e8))(plVar1,uVar3,*(uint64 *)(*plVar1 + 0x5f0));
              lVar4 = Console.Input(lVar4,0);
              if (lVar4 != null) {
                cVar2 = String.Equals(lVar4,"cls",0);
                plVar1 = this.ouputText;
                if (!cVar2) {
                  if (plVar1 == (int64 *)0) throw; // [null/range check failed]
                  uVar3 = (**(code **)(*plVar1 + 0x5d8))(plVar1,*(uint64 *)(*plVar1 + 0x5e0));
                  uVar3 = String.Concat(uVar3,lVar4,"\n",0);
                  (**(code **)(*plVar1 + 0x5e8))(plVar1,uVar3,*(uint64 *)(*plVar1 + 0x5f0));
                }
                else {
                  if (plVar1 == (int64 *)0) throw; // [null/range check failed]
                  (**(code **)(*plVar1 + 0x5e8))(plVar1,"",*(uint64 *)(*plVar1 + 0x5f0));
                }
              }
              lVar4 = this.inputField;
              uVar3 = "";
            }
            if (lVar4 != null) {
              InputField.set_text(lVar4,uVar3,0);
              if (this.inputField != null) {
                InputField.ActivateInputField(this.inputField,0);
                return;
              }
            }
          }
        }
    }

    // Token : 0x6001500
    // RVA   : 0x790570   Offset: 0x78ED70   Length: 0x20
    public void CloseButtonClicked()
    {
        if (this.gameConsole != null) {
          GameObject.SetActive(this.gameConsole,0,0);
          return;
        }
    }

    // Token : 0x6001501
    // RVA   : 0x3A17B0   Offset: 0x39FFB0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_18044ef50(this,0);
    }

}
