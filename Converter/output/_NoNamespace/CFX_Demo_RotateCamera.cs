// ============================================================
// Type  : CFX_Demo_RotateCamera
// Token : 0x20003CB
// ============================================================

public class CFX_Demo_RotateCamera
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001ECC
    public static bool rotating;

    // Token: 0x4001ECD
    public float speed;

    // Token: 0x4001ECE
    public Transform rotationCenter;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6002488
    // RVA   : 0x938B10   Offset: 0x937910   Length: 0x148
    private void Update()
    {
        float fVar1;
        ulong uVar2;
        ulong uVar3;
        uint uVar4;
        uint uVar5;
        long lVar6;
        float fVar8;
        ulong local_58;
        uint local_50;
        ulong local_48;
        uint local_40;
        if (**(char **)(DAT_181e951b8 + 184) == false) {
          return;
        }
        lVar6 = Component.get_transform(this,0);
        if (this.rotationCenter != null) {
          puVar7 = (uint64 *)Transform.get_position(&local_48,this.rotationCenter,0);
          uVar2 = *puVar7;
          uVar4 = *(uint32 *)(puVar7 + 1);
          puVar7 = (uint64 *)Vector3.get_up(&local_48,0);
          fVar1 = this.speed;
          uVar3 = *puVar7;
          uVar5 = *(uint32 *)(puVar7 + 1);
          fVar8 = (float)Time.get_deltaTime(0);
          if (lVar6 != null) {
            local_58 = uVar3;
            local_50 = uVar5;
            local_48 = uVar2;
            local_40 = uVar4;
            Transform.RotateAround(lVar6,&local_48,&local_58,fVar8 * fVar1,0);
            return;
          }
        }
    }

    // Token : 0x6002489
    // RVA   : 0x938CA0   Offset: 0x937AA0   Length: 0xE
    public void /*ctor*/()
    {
        void FUN_180938ca0(int64 this)
        {
        this.speed = 0x41f00000;
        FUN_180ae8740(this,0);
    }

    // Token : 0x600248A
    // RVA   : 0x938C60   Offset: 0x937A60   Length: 0x36
    private static void /*cctor*/()
    {
        **(uint8 **)(DAT_181e951b8 + 184) = 1;
    }

}
