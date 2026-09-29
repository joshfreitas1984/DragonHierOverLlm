// ============================================================
// Type  : UIOrthoCamera
// Token : 0x2000103
// ============================================================

public class UIOrthoCamera
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x400066E
    private Camera mCam;

    // Token: 0x400066F
    private Transform mTrans;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x600088C
    // RVA   : 0x1196B00   Offset: 0x1195F00   Length: 0x83
    private void Start()
    {
        ulong uVar1;
        uVar1 = Component.GetComponent(this,DAT_181d937f8);
        this.mCam = uVar1;
        uVar1 = Component.get_transform(this,0);
        this.mTrans = uVar1;
        if (this.mCam != null) {
          Camera.set_orthographic(this.mCam,1,0);
          return;
        }
    }

    // Token : 0x600088D
    // RVA   : 0x1196B90   Offset: 0x1195F90   Length: 0x132
    private void Update()
    {
        long lVar2;
        bool cVar3;
        int iVar4;
        int iVar5;
        float fVar6;
        float fVar7;
        ulong uVar8;
        byte[] local_58 = new byte[16];
        ulong local_48;
        ulong uStack_40;
        if (this.mCam != null) {
          puVar1 = (uint64 *)Camera.get_rect(local_58,this.mCam,0);
          local_48 = *puVar1;
          uStack_40 = puVar1[1];
          fVar6 = (float)FUN_18044df60(&local_48,0);
          iVar4 = Screen.get_height(0);
          if (this.mCam != null) {
            puVar1 = (uint64 *)Camera.get_rect(local_58,this.mCam,0);
            local_48 = *puVar1;
            uStack_40 = puVar1[1];
            fVar7 = (float)Rect.get_yMax(&local_48,0);
            iVar5 = Screen.get_height(0);
            if (this.mTrans != null) {
              lVar2 = Transform.get_lossyScale(local_58,this.mTrans,0);
              fVar6 = ((float)iVar5 * fVar7 - (float)iVar4 * fVar6) * 0.5 * *(float *)(lVar2 + 4);
              if (this.mCam != null) {
                uVar8 = Camera.get_orthographicSize(this.mCam,0);
                cVar3 = Mathf.Approximately(uVar8,fVar6,0);
                if (!cVar3) {
                  if (this.mCam == null) throw; // [null/range check failed]
                  Camera.set_orthographicSize(this.mCam,fVar6,0);
                }
                return;
              }
            }
          }
        }
    }

    // Token : 0x600088E
    // RVA   : 0x3A17B0   Offset: 0x3A0BB0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_18044ef50(this,0);
    }

}
