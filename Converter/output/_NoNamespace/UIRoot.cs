// ============================================================
// Type  : UIRoot
// Token : 0x2000108
// ============================================================

public class UIRoot
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4000682
    public static List<UIRoot> list;

    // Token: 0x4000683
    public Scaling scalingStyle;

    // Token: 0x4000684
    public int manualWidth;

    // Token: 0x4000685
    public int manualHeight;

    // Token: 0x4000686
    public int minimumHeight;

    // Token: 0x4000687
    public int maximumHeight;

    // Token: 0x4000688
    public bool fitWidth;

    // Token: 0x4000689
    public bool fitHeight;

    // Token: 0x400068A
    public bool adjustByDPI;

    // Token: 0x400068B
    public bool shrinkPortraitUI;

    // Token: 0x400068C
    private Transform mTrans;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60008D1
    // RVA   : 0x1602A50   Offset: 0x1601850   Length: 0x27
    public Constraint get_constraint()
    {
        uint64 FUN_181602a50(int64 this)
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

    // Token : 0x60008D2
    // RVA   : 0x1602A40   Offset: 0x1601840   Length: 0xB
    public Scaling get_activeScaling()
    {
        uint32 FUN_181602a40(int64 this)
        {
        uint32 uVar1;
        uVar1 = 0;
        if (this.scalingStyle != 2) {
          uVar1 = this.scalingStyle;
        }
        return uVar1;
    }

    // Token : 0x60008D3
    // RVA   : 0x16028A0   Offset: 0x16016A0   Length: 0x19A
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

    // Token : 0x60008D4
    // RVA   : 0x1602A80   Offset: 0x1601880   Length: 0x102
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

    // Token : 0x60008D5
    // RVA   : 0x16022E0   Offset: 0x16010E0   Length: 0xC3
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

    // Token : 0x60008D6
    // RVA   : 0x1602260   Offset: 0x1601060   Length: 0x73
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

    // Token : 0x60008D7
    // RVA   : 0x857A60   Offset: 0x856860   Length: 0x24
    protected virtual void Awake()
    {
        ulong uVar1;
        uVar1 = Component.get_transform(this,0);
        this.mTrans = uVar1;
    }

    // Token : 0x60008D8
    // RVA   : 0x1602440   Offset: 0x1601240   Length: 0x81
    protected virtual void OnEnable()
    {
        var pStatics = *(int64*)(DAT_181e905d0 + 184);
        if (*pStatics != 0) {
          FUN_18175de30(*pStatics,this,DAT_181e8cb68);
          return;
        }
    }

    // Token : 0x60008D9
    // RVA   : 0x16023B0   Offset: 0x16011B0   Length: 0x81
    protected virtual void OnDisable()
    {
        var pStatics = *(int64*)(DAT_181e905d0 + 184);
        if (*pStatics != 0) {
          FUN_181665e90(*pStatics,this,DAT_181e8cc68);
          return;
        }
    }

    // Token : 0x60008DA
    // RVA   : 0x16024D0   Offset: 0x16012D0   Length: 0x173
    protected virtual void Start()
    {
        long lVar1;
        bool cVar2;
        long lVar3;
        lVar1 = Component.GetComponentInChildren(this,DAT_181e7a9b8);
        cVar2 = Object.op_Inequality(lVar1,0,0);
        if (cVar2) {
          Debug.LogWarning("UIRoot should not be active at the same time as UIOrthoCamera. Disabling UIOrthoCamera.",lVar1,0);
          if ((lVar1 != null) && (lVar3 = Component.get_gameObject(lVar1,0)) != null) {
            lVar3 = GameObject.GetComponent(lVar3,DAT_181e53dc0);
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
          FUN_1801e0300();
        }
        UIRoot.UpdateScale(this,0,0);
    }

    // Token : 0x60008DB
    // RVA   : 0x16027E0   Offset: 0x16015E0   Length: 0xA
    private void Update()
    {
        void FUN_1816027e0(uint64 this)
        {
        UIRoot.UpdateScale(this,1,0);
    }

    // Token : 0x60008DC
    // RVA   : 0x1602650   Offset: 0x1601450   Length: 0x183
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
        LAB_1816027ce:
                          // WARNING: Subroutine does not return
              FUN_1801e0300();
            }
            puVar4 = (uint64 *)Transform.get_localScale(local_28,this.mTrans,0);
            local_38 = *puVar4;
            local_30 = *(float *)(puVar4 + 1);
            if (((1.4013e-45 < ABS((float)local_38 - fVar5)) ||
                (local_38 = *puVar4, 1.4013e-45 < ABS((float)((uint64)local_38 >> 32) - fVar5))) ||
               (1.4013e-45 < ABS(local_30 - fVar5))) {
              if (this.mTrans == null) goto LAB_1816027ce;
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

    // Token : 0x60008DD
    // RVA   : 0x1601F30   Offset: 0x1600D30   Length: 0x150
    public static void Broadcast(string funcName)
    {
        var pStatics = *(int64*)(DAT_181e905d0 + 184);
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
        LAB_181602250:
                          // WARNING: Subroutine does not return
          FUN_1801e0300();
        }
        iVar1 = *(int *)(*pStatics + 24);
        if (0 < iVar1) {
          do {
            if (*pStatics == 0) goto LAB_181602250;
            lVar3 = FUN_1800024b0(*pStatics,iVar4,DAT_181e8cd68);
            cVar2 = Object.op_Inequality(lVar3,0,0);
            if (cVar2) {
              if (lVar3 == null) goto LAB_181602250;
              Component.BroadcastMessage(lVar3,funcName,param_2,1,0);
            }
            iVar4 = iVar4 + 1;
          } while (iVar4 < iVar1);
        }
    }

    // Token : 0x60008DE
    // RVA   : 0x1602090   Offset: 0x1600E90   Length: 0x1C5
    public static void Broadcast(string funcName, object param)
    {
        var pStatics = *(int64*)(DAT_181e905d0 + 184);
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
        LAB_181602250:
                          // WARNING: Subroutine does not return
          FUN_1801e0300();
        }
        iVar1 = *(int *)(*pStatics + 24);
        if (0 < iVar1) {
          do {
            if (*pStatics == 0) goto LAB_181602250;
            lVar3 = FUN_1800024b0(*pStatics,iVar4,DAT_181e8cd68);
            cVar2 = Object.op_Inequality(lVar3,0,0);
            if (cVar2) {
              if (lVar3 == null) goto LAB_181602250;
              Component.BroadcastMessage(lVar3,funcName,param,1,0);
            }
            iVar4 = iVar4 + 1;
          } while (iVar4 < iVar1);
        }
    }

    // Token : 0x60008DF
    // RVA   : 0x1602870   Offset: 0x1601670   Length: 0x27
    public void /*ctor*/()
    {
        void FUN_181602870(int64 this)
        {
        this.manualWidth = 0x500;
        this.manualHeight = 0x2d0;
        this.minimumHeight = 0x140;
        this.maximumHeight = 0x600;
        this.fitHeight = 1;
        FUN_180ae8740(this,0);
    }

    // Token : 0x60008E0
    // RVA   : 0x16027F0   Offset: 0x16015F0   Length: 0x76
    private static void /*cctor*/()
    {
        ulong uVar2;
        uVar2 = il2cpp_internal(DAT_181e78828);
        FUN_1810f3480(uVar2,DAT_181e8cae8);
        puVar1 = *(uint64 **)(DAT_181e905d0 + 184);
        *puVar1 = uVar2;
        il2cpp_internal(puVar1,uVar2);
    }

}
