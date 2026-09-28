// ============================================================
// Type  : MouseOrTouch
// Token : 0x20000DB
// ============================================================

public class MouseOrTouch
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x40005A3
    public KeyCode key;

    // Token: 0x40005A4
    public Vector2 pos;

    // Token: 0x40005A5
    public Vector2 lastPos;

    // Token: 0x40005A6
    public Vector2 delta;

    // Token: 0x40005A7
    public Vector2 totalDelta;

    // Token: 0x40005A8
    public Camera pressedCam;

    // Token: 0x40005A9
    public GameObject last;

    // Token: 0x40005AA
    public GameObject current;

    // Token: 0x40005AB
    public GameObject pressed;

    // Token: 0x40005AC
    public GameObject dragged;

    // Token: 0x40005AD
    public GameObject lastClickGO;

    // Token: 0x40005AE
    public float pressTime;

    // Token: 0x40005AF
    public float clickTime;

    // Token: 0x40005B0
    public ClickNotification clickNotification;

    // Token: 0x40005B1
    public bool touchBegan;

    // Token: 0x40005B2
    public bool pressStarted;

    // Token: 0x40005B3
    public bool dragStarted;

    // Token: 0x40005B4
    public int ignoreDelta;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x600073B
    // RVA   : 0x8E67A0   Offset: 0x8E5BA0   Length: 0x1B
    public float get_deltaTime()
    {
        float fVar1;
        fVar1 = (float)RealTime.get_time(0);
        return fVar1 - this.pressTime;
    }

    // Token : 0x600073C
    // RVA   : 0x8E67C0   Offset: 0x8E5BC0   Length: 0x16E
    public bool get_isOverUI()
    {
        ulong uVar1;
        ulong uVar2;
        ulong uVar3;
        uVar3 = this.current;
        uVar2 = Object.op_Inequality(uVar3,0,0);
        if ((char)uVar2) {
          uVar3 = this.current;
          uVar1 = *(uint64 *)(*(int64 *)(DAT_181daf678 + 184) + 248);
          uVar2 = Object.op_Inequality(uVar3,uVar1,0);
          if ((char)uVar2) {
            uVar3 = this.current;
            uVar3 = NGUITools.FindInParents(uVar3,DAT_181d8f820);
            uVar2 = Object.op_Inequality(uVar3,0,0);
            return uVar2;
          }
        }
        return uVar2 & 0xffffffffffffff00;
    }

    // Token : 0x600073D
    // RVA   : 0x8E6780   Offset: 0x8E5B80   Length: 0x12
    public void /*ctor*/()
    {
        this.clickNotification = 1;
        this.touchBegan = 1;
        ZhSegment.Initialize(this,0);
    }

}
