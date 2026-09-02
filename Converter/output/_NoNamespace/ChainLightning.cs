// ============================================================
// Type  : ChainLightning
// Token : 0x20001AF
// ============================================================

public class ChainLightning
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4000B46
    public float detail;

    // Token: 0x4000B47
    public float displacement;

    // Token: 0x4000B48
    public Vector3 EndPostion;

    // Token: 0x4000B49
    public Vector3 StartPosition;

    // Token: 0x4000B4A
    public float yOffset;

    // Token: 0x4000B4B
    private LineRenderer _lineRender;

    // Token: 0x4000B4C
    private List<Vector3> _linePosList;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000E3D
    // RVA   : 0x9F0040   Offset: 0x9EE840   Length: 0x96
    private void Awake()
    {
        ulong uVar1;
        uVar1 = Component.GetComponent(this,DAT_181d6c040);
        this._lineRender = uVar1;
        uVar1 = il2cpp_internal(DAT_181d73eb0);
        FUN_180f58a90(uVar1,DAT_181d841f8);
        this._linePosList = uVar1;
    }

    // Token : 0x6000E3E
    // RVA   : 0x9F0330   Offset: 0x9EEB30   Length: 0x32F
    private void Update()
    {
        ulong uVar1;
        ulong uVar2;
        long lVar3;
        long lVar4;
        float fVar5;
        ulong uVar7;
        ulong uVar8;
        long lVar9;
        ulong uVar10;
        float fVar11;
        float fVar12;
        float fVar13;
        ulong local_b8;
        float local_b0;
        ulong local_a8;
        float local_a0;
        float local_90;
        byte[] local_88 = new byte[8];
        float local_80;
        byte[] local_78 = new byte[80];
        fVar11 = (float)Time.get_timeScale(0);
        if (fVar11 == 0.0) {
          return;
        }
        if (this._linePosList != null) {
          FUN_180f56130(this._linePosList,DAT_181d84378);
          Vector3.get_zero(local_88,0);
          Vector3.get_zero(local_88,0);
          local_a0 = *(float *)(this + 40);
          uVar1 = this.EndPostion;
          fVar11 = this.yOffset;
          puVar6 = (uint64 *)Vector3.get_up(local_88,0);
          local_90 = *(float *)(puVar6 + 1);
          local_b8 = *puVar6;
          fVar13 = (float)local_b8 * fVar11 + (float)uVar1;
          local_80 = local_90 * fVar11 + local_a0;
          fVar12 = (float)((uint64)local_b8 >> 32) * fVar11 + (float)((uint64)uVar1 >> 32);
          local_b0 = *(float *)(this + 52);
          uVar2 = this.StartPosition;
          fVar11 = this.yOffset;
          local_a8 = uVar1;
          puVar6 = (uint64 *)Vector3.get_up(local_78,0);
          fVar5 = local_80;
          local_b0 = *(float *)(puVar6 + 1) * fVar11 + local_b0;
          local_a0 = local_80;
          local_b8 = CONCAT44((float)((uint64)*puVar6 >> 32) * fVar11 +
                              (float)((uint64)uVar2 >> 32),(float)*puVar6 * fVar11 + (float)uVar2);
          uVar7 = 0;
          local_a8 = CONCAT44(fVar12,fVar13);
          local_90 = local_b0;
          ChainLightning.CollectLinPos(this,&local_b8,&local_a8,this.displacement,0);
          if (this._linePosList != null) {
            local_a8 = CONCAT44(fVar12,fVar13);
            local_a0 = fVar5;
            FUN_181805a40(this._linePosList,&local_a8,DAT_181d84278);
            if ((this._linePosList != null) && (this._lineRender != null)) {
              LineRenderer.set_positionCount
                        (this._lineRender,
                         this._linePosList.Count,0);
              if (this._linePosList != null) {
                lVar9 = (int64)this._linePosList.Count;
                uVar8 = uVar7;
                uVar10 = uVar7;
                if (lVar9 < 1) {
                  return;
                }
                while( true ) {
                  lVar3 = this._linePosList;
                  lVar4 = this._lineRender;
                  if (lVar3 == null) break;
                  if (lVar3.Count <= (uint32)uVar7) {
                    ThrowHelper.ThrowArgumentOutOfRangeException(0);
                  }
                  if (lVar4 == null) break;
                  local_a8 = *(uint64 *)(lVar3._items + 32 + uVar8);
                  local_a0 = *(float *)(lVar3._items + 40 + uVar8);
                  LineRenderer.SetPosition(lVar4,uVar7,&local_a8,0);
                  uVar7 = (uint64)((uint32)uVar7 + 1);
                  uVar10 = uVar10 + 1;
                  uVar8 = uVar8 + 12;
                  if (lVar9 <= (int64)uVar10) {
                    return;
                  }
                }
              }
            }
          }
        }
    }

    // Token : 0x6000E3F
    // RVA   : 0x9F00E0   Offset: 0x9EE8E0   Length: 0x241
    private void CollectLinPos(Vector3 startPos, Vector3 destPos, float displace)
    {
        ulong uVar1;
        ulong uVar2;
        float fVar3;
        float fVar4;
        float fVar5;
        ulong local_a8;
        float local_a0;
        ulong local_98;
        float local_90;
        if (displace < this.detail) {
          if (this._linePosList == null) {
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          local_98 = *(uint64 *)startPos;
          local_90 = startPos[2];
          FUN_181805a40(this._linePosList,&local_98,DAT_181d84278);
        }
        else {
          local_a0 = startPos[2];
          uVar1 = *(uint64 *)startPos;
          uVar2 = *(uint64 *)destPos;
          local_90 = destPos[2];
          local_a8 = uVar1;
          local_98 = uVar2;
          fVar3 = (float)Random.get_value(0);
          fVar5 = (fVar3 - 0.5) * displace + (*startPos + *destPos) * 0.5;
          fVar3 = (float)Random.get_value(0);
          fVar4 = (fVar3 - 0.5) * displace +
                  ((float)((uint64)uVar1 >> 32) + (float)((uint64)uVar2 >> 32)) * 0.5;
          fVar3 = (float)Random.get_value(0);
          local_a8 = CONCAT44(fVar4,fVar5);
          fVar3 = (fVar3 - 0.5) * displace + (local_a0 + local_90) * 0.5;
          local_a0 = fVar3;
          local_98 = uVar1;
          local_90 = startPos[2];
          ChainLightning.CollectLinPos(this,&local_98,&local_a8,displace * 0.5,0);
          local_90 = destPos[2];
          local_a8 = CONCAT44(fVar4,fVar5);
          local_a0 = fVar3;
          local_98 = uVar2;
          ChainLightning.CollectLinPos(this,&local_a8,&local_98,displace * 0.5,0);
        }
    }

    // Token : 0x6000E40
    // RVA   : 0x9F0660   Offset: 0x9EEE60   Length: 0x15
    public void /*ctor*/()
    {
        void FUN_1809f0660(int64 this)
        {
        this.detail = 0x3f800000;
        this.displacement = 0x41700000;
        FUN_18044ef50(this,0);
    }

}
