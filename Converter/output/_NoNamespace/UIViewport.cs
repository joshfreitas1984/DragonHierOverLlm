// ============================================================
// Type  : UIViewport
// Token : 0x200011D
// ============================================================

public class UIViewport
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4000723
    public Camera sourceCamera;

    // Token: 0x4000724
    public Transform topLeft;

    // Token: 0x4000725
    public Transform bottomRight;

    // Token: 0x4000726
    public float fullSize;

    // Token: 0x4000727
    private Camera mCam;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60009A1
    // RVA   : 0xC09BF0   Offset: 0xC08FF0   Length: 0xA8
    private void Start()
    {
        bool cVar1;
        ulong uVar2;
        uVar2 = Component.GetComponent(this,DAT_181d937e0);
        this.mCam = uVar2;
        uVar2 = this.sourceCamera;
        cVar1 = Object.op_Equality(uVar2,0,0);
        if (cVar1) {
          uVar2 = Camera.get_main(0);
          this.sourceCamera = uVar2;
        }
    }

    // Token : 0x60009A2
    // RVA   : 0xC098D0   Offset: 0xC08CD0   Length: 0x31A
    private void LateUpdate()
    {
        ulong uVar1;
        bool cVar2;
        int iVar3;
        int iVar4;
        int iVar5;
        int iVar6;
        long lVar7;
        ulong uVar9;
        float fVar10;
        float fVar11;
        ulong local_68;
        uint local_60;
        ulong local_58;
        ulong uStack_50;
        ulong local_48;
        ulong uStack_40;
        ulong local_38;
        ulong uStack_30;
        uVar9 = this.topLeft;
        local_38 = 0;
        uStack_30 = 0;
        cVar2 = Object.op_Inequality(uVar9,0,0);
        if (cVar2) {
          uVar9 = this.bottomRight;
          cVar2 = Object.op_Inequality(uVar9,0,0);
          if (cVar2) {
            if ((this.topLeft == null) ||
               (lVar7 = Component.get_gameObject(this.topLeft,0)) == null)
            goto LAB_180c09be5;
            cVar2 = GameObject.get_activeInHierarchy(lVar7,0);
            if (!cVar2) {
              lVar7 = this.mCam;
              if (lVar7 == null) goto LAB_180c09be5;
              uVar9 = 0;
            }
            else {
              lVar7 = this.sourceCamera;
              if ((this.topLeft == null) ||
                 (puVar8 = (uint64 *)
                           Transform.get_position(&local_58,this.topLeft,0), lVar7 == null)
                 ) {
        LAB_180c09be5:
                          // WARNING: Subroutine does not return
                FUN_1800d6620();
              }
              local_68 = *puVar8;
              local_60 = *(uint32 *)(puVar8 + 1);
              puVar8 = (uint64 *)Camera.WorldToScreenPoint(&local_58,lVar7,&local_68,0);
              lVar7 = this.sourceCamera;
              local_68 = *puVar8;
              if ((this.bottomRight == null) ||
                 (puVar8 = (uint64 *)
                           Transform.get_position(&local_48,this.bottomRight,0), lVar7 == null)
                 ) goto LAB_180c09be5;
              local_58 = *puVar8;
              uStack_50._0_4_ = *(uint32 *)(puVar8 + 1);
              puVar8 = (uint64 *)Camera.WorldToScreenPoint(&local_48,lVar7,&local_58,0);
              uVar9 = *puVar8;
              fVar10 = (float)((uint64)uVar9 >> 32);
              uStack_50 = CONCAT44(uStack_50._4_4_,*(uint32 *)(puVar8 + 1));
              iVar3 = Screen.get_width(0);
              iVar4 = Screen.get_height(0);
              iVar5 = Screen.get_width(0);
              iVar6 = Screen.get_height(0);
              local_58._0_4_ = (float)uVar9;
              fVar11 = (float)local_58 - (float)local_68;
              local_58 = uVar9;
              FUN_1809dc910(&local_38,(float)local_68 / (float)iVar3,fVar10 / (float)iVar4,
                            fVar11 / (float)iVar5,(local_68._4_4_ - fVar10) / (float)iVar6,0);
              fVar11 = this.fullSize;
              fVar10 = (float)FUN_18044e2b0(&local_38,0);
              uVar1 = uStack_30;
              uVar9 = local_38;
              fVar10 = fVar10 * fVar11;
              if (this.mCam == null) goto LAB_180c09be5;
              puVar8 = (uint64 *)Camera.get_rect(&local_48,this.mCam,0);
              local_58 = uVar9;
              uStack_50 = uVar1;
              local_48 = *puVar8;
              uStack_40 = puVar8[1];
              cVar2 = Rect.op_Inequality(&local_58,&local_48,0);
              if (cVar2) {
                if (this.mCam == null) goto LAB_180c09be5;
                local_48 = local_38;
                uStack_40 = uStack_30;
                Camera.set_rect(this.mCam,&local_48,0);
              }
              if (this.mCam == null) goto LAB_180c09be5;
              fVar11 = (float)Camera.get_orthographicSize(this.mCam,0);
              if (fVar11 != fVar10) {
                if (this.mCam == null) goto LAB_180c09be5;
                Camera.set_orthographicSize(this.mCam,fVar10,0);
              }
              lVar7 = this.mCam;
              if (lVar7 == null) goto LAB_180c09be5;
              uVar9 = 1;
            }
            Behaviour.set_enabled(lVar7,uVar9,0);
          }
        }
    }

    // Token : 0x60009A3
    // RVA   : 0xC09CA0   Offset: 0xC090A0   Length: 0xE
    public void /*ctor*/()
    {
        void FUN_180c09ca0(int64 this)
        {
        this.fullSize = 0x3f800000;
        FUN_18044ef50(this,0);
    }

}
