// ============================================================
// Type  : EnvMapAnimator
// Token : 0x20003DD
// ============================================================

public class EnvMapAnimator
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001EEC
    public Vector3 RotationSpeeds;

    // Token: 0x4001EED
    private TMP_Text m_textMeshPro;

    // Token: 0x4001EEE
    private Material m_material;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6002456
    // RVA   : 0x944A60   Offset: 0x943E60   Length: 0x7F
    private void Awake()
    {
        ulong uVar2;
        uVar2 = Component.GetComponent(this,DAT_181d96078);
        this.m_textMeshPro = uVar2;
        plVar1 = this.m_textMeshPro;
        if (plVar1 != (int64 *)0) {
          uVar2 = (**(code **)(*plVar1 + 0x568))(plVar1,*(uint64 *)(*plVar1 + 0x570));
          this.m_material = uVar2;
          return;
        }
    }

    // Token : 0x6002457
    // RVA   : 0x944AE0   Offset: 0x943EE0   Length: 0x6C
    private IEnumerator Start()
    {
        long lVar1;
        lVar1 = new WarpText_d__8(0,0);
        if (lVar1 != null) {
          *(uint64 *)(lVar1 + 32) = this;
          return lVar1;
        }
    }

    // Token : 0x6002458
    // RVA   : 0x3A17B0   Offset: 0x3A0BB0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_18044ef50(this,0);
    }

}
