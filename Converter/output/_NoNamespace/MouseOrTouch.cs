// ============================================================
// Type  : MouseOrTouch
// Token : 0x20000DA
// ============================================================

public class MouseOrTouch
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4000587
    public KeyCode key;

    // Token: 0x4000588
    public Vector2 pos;

    // Token: 0x4000589
    public Vector2 lastPos;

    // Token: 0x400058A
    public Vector2 delta;

    // Token: 0x400058B
    public Vector2 totalDelta;

    // Token: 0x400058C
    public Camera pressedCam;

    // Token: 0x400058D
    public GameObject last;

    // Token: 0x400058E
    public GameObject current;

    // Token: 0x400058F
    public GameObject pressed;

    // Token: 0x4000590
    public GameObject dragged;

    // Token: 0x4000591
    public GameObject lastClickGO;

    // Token: 0x4000592
    public float pressTime;

    // Token: 0x4000593
    public float clickTime;

    // Token: 0x4000594
    public ClickNotification clickNotification;

    // Token: 0x4000595
    public bool touchBegan;

    // Token: 0x4000596
    public bool pressStarted;

    // Token: 0x4000597
    public bool dragStarted;

    // Token: 0x4000598
    public int ignoreDelta;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000723
    // RVA   : 0xB07290   Offset: 0xB05A90   Length: 0x1B
    public float get_deltaTime()
    {
        float fVar1;
        fVar1 = (float)RealTime.get_time(0);
        return fVar1 - this.pressTime;
    }

    // Token : 0x6000724
    // RVA   : 0xB072B0   Offset: 0xB05AB0   Length: 0x16E
    public bool get_isOverUI()
    {
        ulong uVar1;
        ulong uVar2;
        ulong uVar3;
        uVar3 = this.current;
        uVar2 = Object.op_Inequality(uVar3,0,0);
        if ((char)uVar2) {
          uVar3 = this.current;
          uVar1 = *(uint64 *)(*(int64 *)(DAT_181d8a458 + 184) + 248);
          uVar2 = Object.op_Inequality(uVar3,uVar1,0);
          if ((char)uVar2) {
            uVar3 = this.current;
            uVar3 = NGUITools.FindInParents(uVar3,DAT_181d66b00);
            uVar2 = Object.op_Inequality(uVar3,0,0);
            return uVar2;
          }
        }
        return uVar2 & 0xffffffffffffff00;
    }

    // Token : 0x6000725
    // RVA   : 0xB07270   Offset: 0xB05A70   Length: 0x12
    public void /*ctor*/()
    {
        this.clickNotification = 1;
        this.touchBegan = 1;
        ZhSegment.Initialize(this,0);
    }

}
