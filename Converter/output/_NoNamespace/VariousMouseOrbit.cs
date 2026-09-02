// ============================================================
// Type  : VariousMouseOrbit
// Token : 0x20003D1
// ============================================================

public class VariousMouseOrbit
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001DC5
    private Transform Target;

    // Token: 0x4001DC6
    public Transform[] Targets;

    // Token: 0x4001DC7
    private int i;

    // Token: 0x4001DC8
    public float distance;

    // Token: 0x4001DC9
    public float xSpeed;

    // Token: 0x4001DCA
    public float ySpeed;

    // Token: 0x4001DCB
    public float yMinLimit;

    // Token: 0x4001DCC
    public float yMaxLimit;

    // Token: 0x4001DCD
    private float x;

    // Token: 0x4001DCE
    private float y;

    // Token: 0x4001DCF
    public float CameraDist;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60023C3
    // RVA   : 0x9DCD20   Offset: 0x9DB520   Length: 0x12B
    private void Start()
    {
        ulong uVar1;
        bool cVar3;
        long lVar4;
        byte[] local_18 = new byte[16];
        lVar4 = Component.get_transform(this,0);
        if (lVar4 != null) {
          puVar2 = (uint64 *)Transform.get_eulerAngles(local_18,lVar4,0);
          lVar4 = this.Targets;
          uVar1 = *puVar2;
          this.distance = 0x41f00000;
          this.y = (int)((uint64)uVar1 >> 32);
          this.x = (float)uVar1 + 50.0;
          if (lVar4 != null) {
            if (*(int *)(lVar4 + 24) == 0) {
              uVar1 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar1,0);
            }
            this.Target = *(uint64 *)(lVar4 + 32);
            uVar1 = Component.GetComponent(this,DAT_181d6c840);
            cVar3 = Object.op_Implicit(uVar1,0);
            if (!cVar3) {
              return;
            }
            lVar4 = Component.GetComponent(this,DAT_181d6c840);
            if (lVar4 != null) {
              Rigidbody.set_freezeRotation(lVar4,1,0);
              return;
            }
          }
        }
    }

    // Token : 0x60023C4
    // RVA   : 0x9DC9B0   Offset: 0x9DB1B0   Length: 0x360
    private void LateUpdate()
    {
        ulong uVar1;
        ulong uVar2;
        bool cVar3;
        uint uVar4;
        long lVar6;
        float fVar7;
        float fVar8;
        float fVar9;
        uint uVar10;
        ulong uVar11;
        float local_68;
        float fStack_64;
        ulong local_58;
        float local_50;
        ulong local_48;
        float local_40;
        byte[] local_38 = new byte[16];
        ulong local_28;
        ulong uStack_20;
        cVar3 = FUN_1804625b0(118);
        if (cVar3) {
          lVar6 = this.Targets;
          if (lVar6 == null) goto LAB_1809dccfb;
          if (this.i < *(int *)(lVar6 + 24) + -1) {
            uVar4 = this.i + 1;
          }
          else {
            uVar4 = 0;
          }
          this.i = uVar4;
          if (*(uint32 *)(lVar6 + 24) <= uVar4) {
            uVar11 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar11,0);
          }
          this.Target = lVar6[uVar4];
        }
        cVar3 = FUN_1804625f0(0x144,0);
        if (cVar3) {
          uVar11 = this.Target;
          cVar3 = Object.op_Implicit(uVar11,0);
          if (cVar3) {
            fVar8 = this.x;
            fVar7 = (float)Input.GetAxis("Mouse X",0);
            fVar9 = this.y;
            this.x = fVar7 * this.xSpeed * 0.02 + fVar8;
            fVar8 = (float)Input.GetAxis("Mouse Y",0);
            fVar9 = fVar8 * this.ySpeed * 0.05 + fVar9;
            this.y = fVar9;
            if (fVar9 < -360.0) {
              fVar9 = fVar9 + 360.0;
            }
            if (360.0 < fVar9) {
              fVar9 = fVar9 + -360.0;
            }
            uVar11 = FUN_1810a8ba0(fVar9,this.yMinLimit,this.yMaxLimit,0
                                  );
            this.y = (int)uVar11;
            puVar5 = (uint64 *)Quaternion.Euler(&local_28,uVar11,this.x,0,0)
            ;
            local_50 = -this.distance;
            uVar1 = *puVar5;
            uVar2 = puVar5[1];
            local_58 = 0;
            local_28 = uVar1;
            uStack_20 = uVar2;
            puVar5 = (uint64 *)Quaternion.op_Multiply(local_38,&local_28,&local_58,0);
            uVar11 = *puVar5;
            fVar8 = *(float *)(puVar5 + 1);
            if (this.Target != null) {
              puVar5 = (uint64 *)Transform.get_position(&local_28,this.Target,0);
              local_68 = (float)uVar11;
              fStack_64 = (float)((uint64)uVar11 >> 32);
              local_48 = *puVar5;
              local_40 = *(float *)(puVar5 + 1);
              local_50 = fVar8 + local_40;
              local_58 = CONCAT44(fStack_64 + (float)((uint64)local_48 >> 32),
                                  local_68 + (float)local_48);
              lVar6 = Component.get_transform(this,0);
              if (lVar6 != null) {
                local_28 = uVar1;
                uStack_20 = uVar2;
                Transform.set_rotation(lVar6,&local_28,0);
                lVar6 = Component.get_transform(this,0);
                if (lVar6 != null) {
                  local_40 = local_50;
                  local_48 = local_58;
                  Transform.set_position(lVar6,&local_48,0);
                  this.distance = this.CameraDist;
                  cVar3 = FUN_1804625f0(119);
                  if (cVar3) {
                    fVar8 = this.CameraDist;
                    fVar9 = (float)Time.get_deltaTime(0);
                    fVar8 = fVar8 - fVar9 * 20.0;
                    this.CameraDist = fVar8;
                    uVar10 = FUN_1810a8ba0(fVar8,0x40000000,0x42a00000,0);
                    this.CameraDist = uVar10;
                  }
                  cVar3 = FUN_1804625f0(115);
                  if (!cVar3) {
                    return;
                  }
                  fVar8 = this.CameraDist;
                  fVar9 = (float)Time.get_deltaTime(0);
                  fVar8 = fVar9 * 20.0 + fVar8;
                  this.CameraDist = fVar8;
                  uVar10 = FUN_1810a8ba0(fVar8,0x40000000,0x42a00000,0);
                  this.CameraDist = uVar10;
                  return;
                }
              }
            }
        LAB_1809dccfb:
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
        }
    }

    // Token : 0x60023C5
    // RVA   : 0x9DC970   Offset: 0x9DB170   Length: 0x36
    private float ClampAngle(float ag, float min, float max)
    {
        void FUN_1809dc970(uint64 this,float ag,uint32 min,uint32 max)
        {
        if (ag < -360.0) {
          ag = ag + 360.0;
        }
        if (360.0 < ag) {
          ag = ag + -360.0;
        }
        FUN_1810a8ba0(ag,min,max,0);
    }

    // Token : 0x60023C6
    // RVA   : 0x9DCE50   Offset: 0x9DB650   Length: 0x2A
    public void /*ctor*/()
    {
        void FUN_1809dce50(int64 this)
        {
        this.xSpeed = 0x437a0000;
        this.ySpeed = 0x42f00000;
        this.yMinLimit = 0xc1a00000;
        this.yMaxLimit = 0x42a00000;
        this.CameraDist = 0x41200000;
        FUN_18044ef50(this,0);
    }

}
