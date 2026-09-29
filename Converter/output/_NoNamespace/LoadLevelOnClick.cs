// ============================================================
// Type  : LoadLevelOnClick
// Token : 0x200001C
// ============================================================

public class LoadLevelOnClick
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4000098
    public string levelName;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x600007B
    // RVA   : 0xA80FD0   Offset: 0xA803D0   Length: 0x6B
    private void OnClick()
    {
        ulong uVar1;
        bool cVar2;
        cVar2 = FUN_180d75bc0(this.levelName,0);
        if (!cVar2) {
          uVar1 = this.levelName;
          SceneManager.LoadScene(uVar1,0);
          return;
        }
    }

    // Token : 0x600007C
    // RVA   : 0x3A17B0   Offset: 0x3A0BB0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_18044ef50(this,0);
    }

}
