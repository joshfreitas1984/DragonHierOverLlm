// ============================================================
// Type  : LoadLevelOnClick
// Token : 0x200001B
// ============================================================

public class LoadLevelOnClick
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4000078
    public string levelName;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000062
    // RVA   : 0x7C4F30   Offset: 0x7C3D30   Length: 0x6B
    private void OnClick()
    {
        ulong uVar1;
        bool cVar2;
        cVar2 = FUN_180ad1200(this.levelName,0);
        if (!cVar2) {
          uVar1 = this.levelName;
          SceneManager.LoadScene(uVar1,0);
          return;
        }
    }

    // Token : 0x6000063
    // RVA   : 0x2110A0   Offset: 0x20FEA0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_180ae8740(this,0);
    }

}
