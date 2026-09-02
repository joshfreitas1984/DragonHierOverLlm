// ============================================================
// Type  : Sprite
// Token : 0x200010E
// ============================================================

public class Sprite
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x40006B4
    public UISpriteData sprite;

    // Token: 0x40006B5
    public Vector2 pos;

    // Token: 0x40006B6
    public float rot;

    // Token: 0x40006B7
    public float width;

    // Token: 0x40006B8
    public float height;

    // Token: 0x40006B9
    public Color32 color;

    // Token: 0x40006BA
    public Vector2 pivot;

    // Token: 0x40006BB
    public Type type;

    // Token: 0x40006BC
    public Flip flip;

    // Token: 0x40006BD
    public bool enabled;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000935
    // RVA   : 0xB09EC0   Offset: 0xB086C0   Length: 0x25C
    public Vector4 GetDrawingDimensions(float pixelSize)
    {
        int iVar1;
        int iVar2;
        int iVar3;
        long lVar4;
        lVar4 = *pixelSize;
        if ((lVar4 != null) && ((int)pixelSize[5] != 2)) {
          iVar1 = *(int *)(lVar4 + 68);
          iVar2 = *(int *)(lVar4 + 60);
          iVar3 = *(int *)(lVar4 + 64);
          if (((int)pixelSize[5] != 0) && (param_3 != 1.0)) {
            Mathf.RoundToInt((float)*(int *)(lVar4 + 56) * param_3,0);
            Mathf.RoundToInt((float)iVar1 * param_3,0);
            Mathf.RoundToInt((float)iVar2 * param_3,0);
            Mathf.RoundToInt((float)iVar3 * param_3,0);
            if (*pixelSize == null) {
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
          }
        }
        *this = 0;
        this[1] = 0;
        FUN_1809981e0(this);
        return this;
    }

}
