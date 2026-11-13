// ============================================================
// Type  : EnvMapAnimator
// Token : 0x20003EA
// ============================================================

public class EnvMapAnimator
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001F7E
    public Vector3 RotationSpeeds;

    // Token: 0x4001F7F
    private TMP_Text m_textMeshPro;

    // Token: 0x4001F80
    private Material m_material;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6002500
    // RVA   : 0x68A160   Offset: 0x688F60   Length: 0x7F
    private void Awake()
    {
        ulong uVar2;
        uVar2 = Component.GetComponent(this,DAT_181e79438);
        this.m_textMeshPro = uVar2;
        plVar1 = this.m_textMeshPro;
        if (plVar1 != (int64 *)0) {
          uVar2 = (**(code **)(*plVar1 + 0x568))(plVar1,*(uint64 *)(*plVar1 + 0x570));
          this.m_material = uVar2;
          return;
        }
    }

    // Token : 0x6002501
    // RVA   : 0x68A1E0   Offset: 0x688FE0   Length: 0x6C
    private IEnumerator Start()
    {
        long lVar1;
        lVar1 = new WarpText_d__8(0,0);
        if (lVar1 != null) {
          *(uint64 *)(lVar1 + 32) = this;
          return lVar1;
        }
    }

    // Token : 0x6002502
    // RVA   : 0x2110A0   Offset: 0x20FEA0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_180ae8740(this,0);
    }

}
