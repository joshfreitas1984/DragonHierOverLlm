// ============================================================
// Type  : EnvMapAnimator
// Token : 0x20003D6
// ============================================================

public class EnvMapAnimator
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001DE1
    public Vector3 RotationSpeeds;

    // Token: 0x4001DE2
    private TMP_Text m_textMeshPro;

    // Token: 0x4001DE3
    private Material m_material;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60023D3
    // RVA   : 0x934950   Offset: 0x933150   Length: 0x7F
    private void Awake()
    {
        ulong uVar2;
        uVar2 = Component.GetComponent(this,DAT_181d6d7c0);
        this.m_textMeshPro = uVar2;
        plVar1 = this.m_textMeshPro;
        if (plVar1 != (int64 *)0) {
          uVar2 = (**(code **)(*plVar1 + 0x568))(plVar1,*(uint64 *)(*plVar1 + 0x570));
          this.m_material = uVar2;
          return;
        }
    }

    // Token : 0x60023D4
    // RVA   : 0x9349D0   Offset: 0x9331D0   Length: 0x6C
    private IEnumerator Start()
    {
        long lVar1;
        lVar1 = new WarpText_d__8(0,0);
        if (lVar1 != null) {
          *(uint64 *)(lVar1 + 32) = this;
          return lVar1;
        }
    }

    // Token : 0x60023D5
    // RVA   : 0x3A17B0   Offset: 0x39FFB0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_18044ef50(this,0);
    }

}
