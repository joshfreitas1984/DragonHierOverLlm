// ============================================================
// Type  : UIRoot
// Token : 0x2000109
// ============================================================

public class UIRoot
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x40006A2
    public static List<UIRoot> list;

    // Token: 0x40006A3
    public Scaling scalingStyle;

    // Token: 0x40006A4
    public int manualWidth;

    // Token: 0x40006A5
    public int manualHeight;

    // Token: 0x40006A6
    public int minimumHeight;

    // Token: 0x40006A7
    public int maximumHeight;

    // Token: 0x40006A8
    public bool fitWidth;

    // Token: 0x40006A9
    public bool fitHeight;

    // Token: 0x40006AA
    public bool adjustByDPI;

    // Token: 0x40006AB
    public bool shrinkPortraitUI;

    // Token: 0x40006AC
    private Transform mTrans;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60008EA
    // RVA   : 0x1700110   Offset: 0x16FF510   Length: 0x27
    public Constraint get_constraint()
    {
        uint64 FUN_181700110(int64 this)
        {
        uint64 uVar1;
        if (!this.fitWidth) {
          uVar1 = 3;
          if (!this.fitHeight) {
            uVar1 = 1;
          }
          return uVar1;
        }
        uVar1 = 0;
        if (!this.fitHeight) {
          uVar1 = 2;
        }
        return uVar1;
    }

    // Token : 0x60008EB
    // RVA   : 0x1700100   Offset: 0x16FF500   Length: 0xB
    public Scaling get_activeScaling()
    {
        uint32 FUN_181700100(int64 this)
        {
        uint32 uVar1;
        uVar1 = 0;
        if (this.scalingStyle != 2) {
          uVar1 = this.scalingStyle;
        }
        return uVar1;
    }

    // Token : 0x60008EC
    // RVA   : 0x16FFF60   Offset: 0x16FF360   Length: 0x19A
    public int get_activeHeight()
    {
        int iVar1;
        ulong uVar2;
        ulong uVar3;
        float fVar5;
        float local_res8;
        float fStackX_c;
        iVar1 = this.scalingStyle;
        if (iVar1 == 2) {
          iVar1 = 0;
        }
        if (iVar1 == 0) {
          NGUITools.get_screenSize(0);
          uVar3 = Mathf.RoundToInt();
          if (this.adjustByDPI) {
            uVar3 = NGUIMath.AdjustByDPI();
          }
        }
        else {
          if (!this.fitWidth) {
            if (this.fitHeight) {
              return (uint64)this.manualHeight;
            }
            iVar1 = 1;
          }
          else {
            iVar1 = 0;
            if (!this.fitHeight) {
              iVar1 = 2;
            }
          }
          uVar2 = NGUITools.get_screenSize(0);
          uVar3 = (uint64)this.manualHeight;
          local_res8 = (float)uVar2;
          fStackX_c = (float)((uint64)uVar2 >> 32);
          local_res8 = local_res8 / fStackX_c;
          fVar5 = (float)this.manualWidth / (float)(int)this.manualHeight;
          if (iVar1 == 0) {
            bVar4 = fVar5 < local_res8;
          }
          else {
            if (iVar1 != 1) {
              if (iVar1 != 2) {
                return uVar3;
              }
              uVar3 = Mathf.RoundToInt();
              return uVar3;
            }
            bVar4 = local_res8 < fVar5;
          }
          if (!bVar4 && local_res8 != fVar5) {
            uVar3 = Mathf.RoundToInt();
            return uVar3;
          }
        }
        return uVar3;
    }

    // Token : 0x60008ED
    // RVA   : 0x1700140   Offset: 0x16FF540   Length: 0x102
    public float get_pixelSizeAdjustment()
    {
        int iVar1;
        int iVar2;
        NGUITools.get_screenSize(0);
        iVar1 = Mathf.RoundToInt();
        if (iVar1 == -1) {
          return;
        }
        iVar2 = Mathf.Max(2,iVar1);
        iVar1 = this.scalingStyle;
        if (iVar1 == 2) {
          iVar1 = 0;
        }
        if (iVar1 != 1) {
          if ((this.minimumHeight <= iVar2) && (iVar2 <= this.maximumHeight)) {
            return;
          }
          return;
        }
        UIRoot.get_activeHeight(this,0);
    }

    // Token : 0x60008EE
    // RVA   : 0x16FF9A0   Offset: 0x16FEDA0   Length: 0xC3
    public static float GetPixelSizeAdjustment(GameObject go)
    {
        int iVar1;
        int iVar2;
        iVar1 = Mathf.Max(2);
        iVar2 = *(int *)(go + 24);
        if (iVar2 == 2) {
          iVar2 = 0;
        }
        if (iVar2 == 1) {
          iVar2 = UIRoot.get_activeHeight(go,0);
        }
        else {
          iVar2 = *(int *)(go + 36);
          if ((iVar2 <= iVar1) && (iVar2 = *(int *)(go + 40), iVar1 <= iVar2)) {
            return 1.0;
          }
        }
        return (float)iVar2 / (float)iVar1;
    }

    // Token : 0x60008EF
    // RVA   : 0x16FF920   Offset: 0x16FED20   Length: 0x73
    public float GetPixelSizeAdjustment(int height)
    {
        int iVar1;
        int iVar2;
        iVar1 = Mathf.Max(2);
        iVar2 = this.scalingStyle;
        if (iVar2 == 2) {
          iVar2 = 0;
        }
        if (iVar2 == 1) {
          iVar2 = UIRoot.get_activeHeight(this,0);
        }
        else {
          iVar2 = this.minimumHeight;
          if ((iVar2 <= iVar1) && (iVar2 = this.maximumHeight, iVar1 <= iVar2)) {
            return 1.0;
          }
        }
        return (float)iVar2 / (float)iVar1;
    }

    // Token : 0x60008F0
    // RVA   : 0xDFABC0   Offset: 0xDF9FC0   Length: 0x24
    protected virtual void Awake()
    {
        ulong uVar1;
        uVar1 = Component.get_transform(this,0);
        this.mTrans = uVar1;
    }

    // Token : 0x60008F1
    // RVA   : 0x16FFB00   Offset: 0x16FEF00   Length: 0x81
    protected virtual void OnEnable()
    {
        var pStatics = *(int64*)(DAT_181db0178 + 184);
        if (*pStatics != 0) {
          FUN_18181e0a0(*pStatics,this,DAT_181daa518);
          return;
        }
    }

    // Token : 0x60008F2
    // RVA   : 0x16FFA70   Offset: 0x16FEE70   Length: 0x81
    protected virtual void OnDisable()
    {
        var pStatics = *(int64*)(DAT_181db0178 + 184);
        if (*pStatics != 0) {
          FUN_1817eee00(*pStatics,this,DAT_181daa618);
          return;
        }
    }

    // Token : 0x60008F3
    // RVA   : 0x16FFB90   Offset: 0x16FEF90   Length: 0x173
    protected virtual void Start()
    {
        long lVar1;
        bool cVar2;
        long lVar3;
        lVar1 = Component.GetComponentInChildren(this,DAT_181d975e0);
        cVar2 = Object.op_Inequality(lVar1,0,0);
        if (cVar2) {
          Debug.LogWarning("UIRoot should not be active at the same time as UIOrthoCamera. Disabling UIOrthoCamera.",lVar1,0);
          if ((lVar1 != null) && (lVar3 = Component.get_gameObject(lVar1,0)) != null) {
            lVar3 = GameObject.GetComponent(lVar3,DAT_181dc7d10);
            Behaviour.set_enabled(lVar1,0,0);
            cVar2 = Object.op_Inequality(lVar3,0,0);
            if (!cVar2) {
              return;
            }
            if (lVar3 != null) {
              Camera.set_orthographicSize(lVar3,0x3f800000,0);
              return;
            }
          }
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
        UIRoot.UpdateScale(this,0,0);
    }

    // Token : 0x60008F4
    // RVA   : 0x16FFEA0   Offset: 0x16FF2A0   Length: 0xA
    private void Update()
    {
        void FUN_1816ffea0(uint64 this)
        {
        UIRoot.UpdateScale(this,1,0);
    }

    // Token : 0x60008F5
    // RVA   : 0x16FFD10   Offset: 0x16FF110   Length: 0x183
    public void UpdateScale(bool updateAnchors)
    {
        ulong uVar1;
        bool cVar2;
        int iVar3;
        float fVar5;
        ulong local_38;
        float local_30;
        byte[] local_28 = new byte[32];
        uVar1 = this.mTrans;
        cVar2 = Object.op_Inequality(uVar1,0,0);
        if (cVar2) {
          iVar3 = UIRoot.get_activeHeight(this,0);
          if (0.0 < (float)iVar3) {
            fVar5 = 2.0 / (float)iVar3;
            if (this.mTrans == null) {
        LAB_1816ffe8e:
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            puVar4 = (uint64 *)Transform.get_localScale(local_28,this.mTrans,0);
            local_38 = *puVar4;
            local_30 = *(float *)(puVar4 + 1);
            if (((1.4013e-45 < ABS((float)local_38 - fVar5)) ||
                (local_38 = *puVar4, 1.4013e-45 < ABS((float)((uint64)local_38 >> 32) - fVar5))) ||
               (1.4013e-45 < ABS(local_30 - fVar5))) {
              if (this.mTrans == null) goto LAB_1816ffe8e;
              local_38 = CONCAT44(fVar5,fVar5);
              local_30 = fVar5;
              Transform.set_localScale(this.mTrans,&local_38,0);
              if (updateAnchors) {
                Component.BroadcastMessage(this,"UpdateAnchors",1);
              }
            }
          }
        }
    }

    // Token : 0x60008F6
    // RVA   : 0x16FF5F0   Offset: 0x16FE9F0   Length: 0x150
    public static void Broadcast(string funcName)
    {
        var pStatics = *(int64*)(DAT_181db0178 + 184);
        int iVar1;
        bool cVar2;
        long lVar3;
        int iVar4;
        if (param_2 == 0) {
          Debug.LogError("SendMessage is bugged when you try to pass 'null' in the parameter field. It behaves as if no parameter was specified.",0);
          return;
        }
        iVar4 = 0;
        if (*pStatics == 0) {
        LAB_1816ff910:
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
        iVar1 = *(int *)(*pStatics + 24);
        if (0 < iVar1) {
          do {
            if (*pStatics == 0) goto LAB_1816ff910;
            lVar3 = FUN_180002f80(*pStatics,iVar4,DAT_181daa718);
            cVar2 = Object.op_Inequality(lVar3,0,0);
            if (cVar2) {
              if (lVar3 == null) goto LAB_1816ff910;
              Component.BroadcastMessage(lVar3,funcName,param_2,1,0);
            }
            iVar4 = iVar4 + 1;
          } while (iVar4 < iVar1);
        }
    }

    // Token : 0x60008F7
    // RVA   : 0x16FF750   Offset: 0x16FEB50   Length: 0x1C5
    public static void Broadcast(string funcName, object param)
    {
        var pStatics = *(int64*)(DAT_181db0178 + 184);
        int iVar1;
        bool cVar2;
        long lVar3;
        int iVar4;
        if (param == null) {
          Debug.LogError("SendMessage is bugged when you try to pass 'null' in the parameter field. It behaves as if no parameter was specified.",0);
          return;
        }
        iVar4 = 0;
        if (*pStatics == 0) {
        LAB_1816ff910:
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
        iVar1 = *(int *)(*pStatics + 24);
        if (0 < iVar1) {
          do {
            if (*pStatics == 0) goto LAB_1816ff910;
            lVar3 = FUN_180002f80(*pStatics,iVar4,DAT_181daa718);
            cVar2 = Object.op_Inequality(lVar3,0,0);
            if (cVar2) {
              if (lVar3 == null) goto LAB_1816ff910;
              Component.BroadcastMessage(lVar3,funcName,param,1,0);
            }
            iVar4 = iVar4 + 1;
          } while (iVar4 < iVar1);
        }
    }

    // Token : 0x60008F8
    // RVA   : 0x16FFF30   Offset: 0x16FF330   Length: 0x27
    public void /*ctor*/()
    {
        void FUN_1816fff30(int64 this)
        {
        this.manualWidth = 0x500;
        this.manualHeight = 0x2d0;
        this.minimumHeight = 0x140;
        this.maximumHeight = 0x600;
        this.fitHeight = 1;
        FUN_18044ef50(this,0);
    }

    // Token : 0x60008F9
    // RVA   : 0x16FFEB0   Offset: 0x16FF2B0   Length: 0x76
    private static void /*cctor*/()
    {
        ulong uVar2;
        uVar2 = il2cpp_internal(DAT_181d98850);
        FUN_18132faf0(uVar2,DAT_181daa498);
        puVar1 = *(uint64 **)(DAT_181db0178 + 184);
        *puVar1 = uVar2;
        il2cpp_internal(puVar1,uVar2);
    }

}
