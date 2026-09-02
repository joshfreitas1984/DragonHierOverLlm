// ============================================================
// Type  : UIRoot
// Token : 0x2000108
// ============================================================

public class UIRoot
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4000686
    public static List<UIRoot> list;

    // Token: 0x4000687
    public Scaling scalingStyle;

    // Token: 0x4000688
    public int manualWidth;

    // Token: 0x4000689
    public int manualHeight;

    // Token: 0x400068A
    public int minimumHeight;

    // Token: 0x400068B
    public int maximumHeight;

    // Token: 0x400068C
    public bool fitWidth;

    // Token: 0x400068D
    public bool fitHeight;

    // Token: 0x400068E
    public bool adjustByDPI;

    // Token: 0x400068F
    public bool shrinkPortraitUI;

    // Token: 0x4000690
    private Transform mTrans;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60008D2
    // RVA   : 0x1585E80   Offset: 0x1584680   Length: 0x27
    public Constraint get_constraint()
    {
        uint64 FUN_181585e80(int64 this)
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

    // Token : 0x60008D3
    // RVA   : 0x1585E70   Offset: 0x1584670   Length: 0xB
    public Scaling get_activeScaling()
    {
        uint32 FUN_181585e70(int64 this)
        {
        uint32 uVar1;
        uVar1 = 0;
        if (this.scalingStyle != 2) {
          uVar1 = this.scalingStyle;
        }
        return uVar1;
    }

    // Token : 0x60008D4
    // RVA   : 0x1585CD0   Offset: 0x15844D0   Length: 0x19A
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

    // Token : 0x60008D5
    // RVA   : 0x1585EB0   Offset: 0x15846B0   Length: 0x81
    public float get_pixelSizeAdjustment()
    {
        int iVar1;
        uint32 extraout_var;
        uint64 uVar2;
        NGUITools.get_screenSize(0);
        iVar1 = Mathf.RoundToInt(extraout_var,0);
        if (iVar1 == -1) {
          return 0x3f800000;
        }
        uVar2 = UIRoot.GetPixelSizeAdjustment(this,iVar1,0);
        return uVar2;
    }

    // Token : 0x60008D6
    // RVA   : 0x1585710   Offset: 0x1583F10   Length: 0xC3
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

    // Token : 0x60008D7
    // RVA   : 0x1585690   Offset: 0x1583E90   Length: 0x73
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

    // Token : 0x60008D8
    // RVA   : 0xB005C0   Offset: 0xAFEDC0   Length: 0x24
    protected virtual void Awake()
    {
        ulong uVar1;
        uVar1 = Component.get_transform(this,0);
        this.mTrans = uVar1;
    }

    // Token : 0x60008D9
    // RVA   : 0x1585870   Offset: 0x1584070   Length: 0x81
    protected virtual void OnEnable()
    {
        var pStatics = *(int64*)(DAT_181d8af58 + 184);
        if (*pStatics != 0) {
          FUN_181827900(*pStatics,this,DAT_181d82b78);
          return;
        }
    }

    // Token : 0x60008DA
    // RVA   : 0x15857E0   Offset: 0x1583FE0   Length: 0x81
    protected virtual void OnDisable()
    {
        var pStatics = *(int64*)(DAT_181d8af58 + 184);
        if (*pStatics != 0) {
          FUN_181801c10(*pStatics,this,DAT_181d82c78);
          return;
        }
    }

    // Token : 0x60008DB
    // RVA   : 0x1585900   Offset: 0x1584100   Length: 0x173
    protected virtual void Start()
    {
        long lVar1;
        bool cVar2;
        long lVar3;
        lVar1 = Component.GetComponentInChildren(this,DAT_181d6ed40);
        cVar2 = Object.op_Inequality(lVar1,0,0);
        if (cVar2) {
          Debug.LogWarning("UIRoot should not be active at the same time as UIOrthoCamera. Disabling UIOrthoCamera.",lVar1,0);
          if ((lVar1 != null) && (lVar3 = Component.get_gameObject(lVar1,0)) != null) {
            lVar3 = GameObject.GetComponent(lVar3,DAT_181d9ef70);
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

    // Token : 0x60008DC
    // RVA   : 0x1585C10   Offset: 0x1584410   Length: 0xA
    private void Update()
    {
        void FUN_181585c10(uint64 this)
        {
        UIRoot.UpdateScale(this,1,0);
    }

    // Token : 0x60008DD
    // RVA   : 0x1585A80   Offset: 0x1584280   Length: 0x183
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
        LAB_181585bfe:
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            puVar4 = (uint64 *)Transform.get_localScale(local_28,this.mTrans,0);
            local_38 = *puVar4;
            local_30 = *(float *)(puVar4 + 1);
            if (((1.4013e-45 < ABS((float)local_38 - fVar5)) ||
                (local_38 = *puVar4, 1.4013e-45 < ABS((float)((uint64)local_38 >> 32) - fVar5))) ||
               (1.4013e-45 < ABS(local_30 - fVar5))) {
              if (this.mTrans == null) goto LAB_181585bfe;
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

    // Token : 0x60008DE
    // RVA   : 0x1585360   Offset: 0x1583B60   Length: 0x150
    public static void Broadcast(string funcName)
    {
        var pStatics = *(int64*)(DAT_181d8af58 + 184);
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
        LAB_181585680:
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
        iVar1 = *(int *)(*pStatics + 24);
        if (0 < iVar1) {
          do {
            if (*pStatics == 0) goto LAB_181585680;
            lVar3 = FUN_180002f80(*pStatics,iVar4,DAT_181d82d78);
            cVar2 = Object.op_Inequality(lVar3,0,0);
            if (cVar2) {
              if (lVar3 == null) goto LAB_181585680;
              Component.BroadcastMessage(lVar3,funcName,param_2,1,0);
            }
            iVar4 = iVar4 + 1;
          } while (iVar4 < iVar1);
        }
    }

    // Token : 0x60008DF
    // RVA   : 0x15854C0   Offset: 0x1583CC0   Length: 0x1C5
    public static void Broadcast(string funcName, object param)
    {
        var pStatics = *(int64*)(DAT_181d8af58 + 184);
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
        LAB_181585680:
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
        iVar1 = *(int *)(*pStatics + 24);
        if (0 < iVar1) {
          do {
            if (*pStatics == 0) goto LAB_181585680;
            lVar3 = FUN_180002f80(*pStatics,iVar4,DAT_181d82d78);
            cVar2 = Object.op_Inequality(lVar3,0,0);
            if (cVar2) {
              if (lVar3 == null) goto LAB_181585680;
              Component.BroadcastMessage(lVar3,funcName,param,1,0);
            }
            iVar4 = iVar4 + 1;
          } while (iVar4 < iVar1);
        }
    }

    // Token : 0x60008E0
    // RVA   : 0x1585CA0   Offset: 0x15844A0   Length: 0x27
    public void /*ctor*/()
    {
        void FUN_181585ca0(int64 this)
        {
        this.manualWidth = 0x500;
        this.manualHeight = 0x2d0;
        this.minimumHeight = 0x140;
        this.maximumHeight = 0x600;
        this.fitHeight = 1;
        FUN_18044ef50(this,0);
    }

    // Token : 0x60008E1
    // RVA   : 0x1585C20   Offset: 0x1584420   Length: 0x76
    private static void /*cctor*/()
    {
        ulong uVar2;
        uVar2 = il2cpp_internal(DAT_181d73b30);
        FUN_180f58a90(uVar2,DAT_181d82af8);
        puVar1 = *(uint64 **)(DAT_181d8af58 + 184);
        *puVar1 = uVar2;
        il2cpp_internal(puVar1,uVar2);
    }

}
