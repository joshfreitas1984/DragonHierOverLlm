// ============================================================
// Type  : LoadLevelOnClick
// Token : 0x200001B
// ============================================================

public class LoadLevelOnClick
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x400007C
    public string levelName;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000063
    // RVA   : 0xA85550   Offset: 0xA83D50   Length: 0x6B
    private void OnClick()
    {
        ulong uVar1;
        bool cVar2;
        cVar2 = FUN_180d6ca90(this.levelName,0);
        if (!cVar2) {
          uVar1 = this.levelName;
          SceneManager.LoadScene(uVar1,0);
          return;
        }
    }

    // Token : 0x6000064
    // RVA   : 0x3A17B0   Offset: 0x39FFB0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_18044ef50(this,0);
    }

}
