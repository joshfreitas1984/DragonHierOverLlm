// ============================================================
// Type  : Sprite
// Token : 0x200010F
// ============================================================

public class Sprite
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x40006D0
    public UISpriteData sprite;

    // Token: 0x40006D1
    public Vector2 pos;

    // Token: 0x40006D2
    public float rot;

    // Token: 0x40006D3
    public float width;

    // Token: 0x40006D4
    public float height;

    // Token: 0x40006D5
    public Color32 color;

    // Token: 0x40006D6
    public Vector2 pivot;

    // Token: 0x40006D7
    public Type type;

    // Token: 0x40006D8
    public Flip flip;

    // Token: 0x40006D9
    public bool enabled;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x600094D
    // RVA   : 0x183DF20   Offset: 0x183D320   Length: 0x25C
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
        FUN_1809dcfa0(this);
        return this;
    }

}
