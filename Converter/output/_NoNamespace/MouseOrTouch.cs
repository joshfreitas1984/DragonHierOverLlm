// ============================================================
// Type  : MouseOrTouch
// Token : 0x20000DA
// ============================================================

public class MouseOrTouch
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4000583
    public KeyCode key;

    // Token: 0x4000584
    public Vector2 pos;

    // Token: 0x4000585
    public Vector2 lastPos;

    // Token: 0x4000586
    public Vector2 delta;

    // Token: 0x4000587
    public Vector2 totalDelta;

    // Token: 0x4000588
    public Camera pressedCam;

    // Token: 0x4000589
    public GameObject last;

    // Token: 0x400058A
    public GameObject current;

    // Token: 0x400058B
    public GameObject pressed;

    // Token: 0x400058C
    public GameObject dragged;

    // Token: 0x400058D
    public GameObject lastClickGO;

    // Token: 0x400058E
    public float pressTime;

    // Token: 0x400058F
    public float clickTime;

    // Token: 0x4000590
    public ClickNotification clickNotification;

    // Token: 0x4000591
    public bool touchBegan;

    // Token: 0x4000592
    public bool pressStarted;

    // Token: 0x4000593
    public bool dragStarted;

    // Token: 0x4000594
    public int ignoreDelta;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000722
    // RVA   : 0x606240   Offset: 0x605040   Length: 0x1B
    public float get_deltaTime()
    {
        float fVar1;
        fVar1 = (float)RealTime.get_time(0);
        return fVar1 - this.pressTime;
    }

    // Token : 0x6000723
    // RVA   : 0x606260   Offset: 0x605060   Length: 0x16E
    public bool get_isOverUI()
    {
        ulong uVar1;
        ulong uVar2;
        ulong uVar3;
        uVar3 = this.current;
        uVar2 = Object.op_Inequality(uVar3,0,0);
        if ((char)uVar2) {
          uVar3 = this.current;
          uVar1 = *(uint64 *)(*(int64 *)(DAT_181e8fad0 + 184) + 248);
          uVar2 = Object.op_Inequality(uVar3,uVar1,0);
          if ((char)uVar2) {
            uVar3 = this.current;
            uVar3 = NGUITools.FindInParents(uVar3,DAT_181e72cf8);
            uVar2 = Object.op_Inequality(uVar3,0,0);
            return uVar2;
          }
        }
        return uVar2 & 0xffffffffffffff00;
    }

    // Token : 0x6000724
    // RVA   : 0x606220   Offset: 0x605020   Length: 0x12
    public void /*ctor*/()
    {
        this.clickNotification = 1;
        this.touchBegan = 1;
        ZhSegment.Initialize(this,0);
    }

}
