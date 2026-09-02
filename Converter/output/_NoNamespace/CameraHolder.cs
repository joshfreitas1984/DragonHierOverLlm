// ============================================================
// Type  : CameraHolder
// Token : 0x20003C3
// ============================================================

public class CameraHolder
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001D55
    public Transform Holder;

    // Token: 0x4001D56
    public float currDistance;

    // Token: 0x4001D57
    public float xRotate;

    // Token: 0x4001D58
    public float yRotate;

    // Token: 0x4001D59
    public float yMinLimit;

    // Token: 0x4001D5A
    public float yMaxLimit;

    // Token: 0x4001D5B
    public float prevDistance;

    // Token: 0x4001D5C
    private float x;

    // Token: 0x4001D5D
    private float y;

    // Token: 0x4001D5E
    private float windowDpi;

    // Token: 0x4001D5F
    public GameObject[] Prefabs;

    // Token: 0x4001D60
    private int Prefab;

    // Token: 0x4001D61
    private GameObject Instance;

    // Token: 0x4001D62
    private float StartColor;

    // Token: 0x4001D63
    private float HueColor;

    // Token: 0x4001D64
    public Texture HueTexture;

    // Token: 0x4001D65
    private ParticleSystem[] particleSystems;

    // Token: 0x4001D66
    private List<SVA> svList;

    // Token: 0x4001D67
    private float H;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6002389
    // RVA   : 0x9EFEC0   Offset: 0x9EE6C0   Length: 0xAA
    private void Start()
    {
        ulong uVar1;
        long lVar2;
        float fVar4;
        float fVar5;
        byte[] local_38 = new byte[48];
        fVar4 = (float)Screen.get_dpi(0);
        fVar5 = 1.0;
        if (fVar4 < 1.0) {
          this.windowDpi = 0x3f800000;
        }
        fVar4 = (float)Screen.get_dpi(0);
        if (200.0 <= fVar4) {
          fVar5 = (float)Screen.get_dpi(0);
          fVar5 = fVar5 / 200.0;
        }
        this.windowDpi = fVar5;
        lVar2 = Component.get_transform(this,0);
        if (lVar2 != null) {
          puVar3 = (uint64 *)Transform.get_eulerAngles(local_38,lVar2,0);
          uVar1 = *puVar3;
          this.y = (int)uVar1;
          this.x = (int)((uint64)uVar1 >> 32);
          CameraHolder.Counter(this,0,0);
          return;
        }
    }

    // Token : 0x600238A
    // RVA   : 0x9EF930   Offset: 0x9EE130   Length: 0x58B
    private void OnGUI()
    {
        float fVar1;
        float fVar2;
        long lVar3;
        long lVar4;
        bool cVar5;
        ulong uVar8;
        uint uVar9;
        ulong uVar10;
        long lVar11;
        ulong uVar12;
        uint uVar13;
        ulong local_res8;
        ulong in_stack_fffffffffffffeb8;
        uint uVar14;
        ulong local_138;
        ulong uStack_130;
        ulong local_128;
        ulong uStack_120;
        ulong local_118;
        ulong uStack_110;
        ulong local_108;
        ulong local_f8;
        ulong uStack_f0;
        ulong local_e8;
        ulong uStack_e0;
        uint local_d8;
        uint uStack_d4;
        uint uStack_d0;
        uint32 uStack_cc;
        uint64 local_c8;
        uint8 local_b8 [16];
        uint8 local_a8 [128];
        uVar13 = (uint32)((uint64)in_stack_fffffffffffffeb8 >> 32);
        fVar1 = this.windowDpi;
        uVar10 = 0;
        local_138 = 0;
        uStack_130 = 0;
        local_res8 = 0;
        uVar8 = CONCAT44(uVar13,fVar1 * 35.0);
        FUN_1809981e0(&local_138,fVar1 * 5.0,fVar1 * 5.0,fVar1 * 110.0,uVar8,0);
        uVar13 = (uint32)((uint64)uVar8 >> 32);
        local_128 = local_138;
        uStack_120 = uStack_130;
        cVar5 = GUI.Button(&local_128,"Previous effect",0);
        if (cVar5) {
          CameraHolder.Counter(this,0xffffffff);
        }
        fVar1 = this.windowDpi;
        uVar8 = CONCAT44(uVar13,fVar1 * 35.0);
        local_138 = 0;
        uStack_130 = 0;
        FUN_1809981e0(&local_138,fVar1 * 120.0,fVar1 * 5.0,fVar1 * 110.0,uVar8,0);
        uVar13 = (uint32)((uint64)uVar8 >> 32);
        local_128 = local_138;
        uStack_120 = uStack_130;
        cVar5 = GUI.Button(&local_128,"Play again",0);
        if (cVar5) {
          CameraHolder.Counter(this,0,0);
        }
        fVar1 = this.windowDpi;
        uVar8 = CONCAT44(uVar13,fVar1 * 35.0);
        local_138 = 0;
        uStack_130 = 0;
        FUN_1809981e0(&local_138,fVar1 * 235.0,fVar1 * 5.0,fVar1 * 110.0,uVar8,0);
        uVar13 = (uint32)((uint64)uVar8 >> 32);
        local_128 = local_138;
        uStack_120 = uStack_130;
        cVar5 = GUI.Button(&local_128,"Next effect",0);
        if (cVar5) {
          CameraHolder.Counter(this,1);
        }
        fVar1 = this.windowDpi;
        this.StartColor = *(uint32 *)(this + 100);
        local_138._0_4_ = 0;
        local_138._4_4_ = 0;
        uStack_130 = 0;
        FUN_1809981e0(&local_138,fVar1 * 5.0,fVar1 * 45.0,fVar1 * 340.0,CONCAT44(uVar13,fVar1 * 35.0),0);
        uVar13 = *(uint32 *)(this + 100);
        uVar14 = 0;
        local_128 = CONCAT44(local_138._4_4_,(uint32)local_138);
        uStack_120 = uStack_130;
        uVar13 = GUI.HorizontalSlider(&local_128,uVar13,0,0x3f800000,0);
        *(uint32 *)(this + 100) = uVar13;
        local_118 = 0;
        uStack_110 = 0;
        fVar1 = this.windowDpi;
        uVar12 = CONCAT44(uVar14,fVar1 * 15.0);
        FUN_1809981e0(&local_118,fVar1 * 5.0,fVar1 * 65.0,fVar1 * 340.0,uVar12,0);
        local_128 = local_118;
        uStack_120 = uStack_110;
        GUI.DrawTexture(&local_128,this.HueTexture,0,0,uVar12 & 0xffffffff00000000,0);
        if (*(float *)(this + 100) != this.StartColor) {
          lVar3 = this.particleSystems;
          uVar12 = uVar10;
          if (lVar3 == null) {
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          while( true ) {
            uVar9 = (uint32)uVar10;
            if ((int)*(uint32 *)(lVar3 + 24) <= (int)uVar9) break;
            if (*(uint32 *)(lVar3 + 24) <= uVar9) {
              uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar8,0);
            }
            lVar4 = lVar3[uVar9];
            if (lVar4 == null) {
        LAB_1809efea0:
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            local_res8 = FUN_1804651e0(lVar4,0);
            lVar4 = this.svList;
            fVar1 = *(float *)(this + 100);
            fVar2 = this.H;
            if (lVar4 == null) goto LAB_1809efea0;
            lVar11 = lVar4;
            if (lVar4.Count <= uVar9) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
              lVar11 = this.svList;
            }
            local_108 = *(uint64 *)(lVar4._items + 32 + uVar12);
            if (lVar11 == null) goto LAB_1809efea0;
            if (lVar11.Count <= uVar9) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            uVar13 = 0;
            local_138 = *(uint64 *)(lVar11._items + 32 + uVar12);
            uStack_130 = CONCAT44(uStack_130._4_4_,
                                  *(uint32 *)(lVar11._items + 40 + uVar12));
            puVar6 = (uint32 *)
                     Color.HSVToRGB(local_b8,fVar2 * 0.0 + fVar1,local_108 & 0xffffffff,
                                     (int)((uint64)local_138 >> 32),0);
            lVar4 = this.svList;
            local_138._0_4_ = *puVar6;
            local_138._4_4_ = puVar6[1];
            uStack_130 = *(uint64 *)(puVar6 + 2);
            if (lVar4 == null) goto LAB_1809efea0;
            if (lVar4.Count <= uVar9) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            uVar14 = *(uint32 *)(lVar4._items + 40 + uVar12);
            uStack_110 = CONCAT44(uStack_110._4_4_,uVar14);
            local_128 = 0;
            uStack_120 = 0;
            FUN_1809981e0(&local_128,(uint32)local_138,local_138._4_4_,(uint32)uStack_130,
                          CONCAT44(uVar13,uVar14),0);
            local_138._0_4_ = (uint32)local_128;
            local_138._4_4_ = local_128._4_4_;
            uStack_130 = uStack_120;
            puVar7 = (uint64 *)MinMaxGradient.op_Implicit(local_a8,&local_138,0);
            local_f8 = *puVar7;
            uStack_f0 = puVar7[1];
            local_e8 = puVar7[2];
            uStack_e0 = puVar7[3];
            local_d8 = *(uint32 *)(puVar7 + 4);
            uStack_d4 = *(uint32 *)((int64)puVar7 + 36);
            uStack_d0 = *(uint32 *)(puVar7 + 5);
            uStack_cc = *(uint32 *)((int64)puVar7 + 44);
            local_c8 = puVar7[6];
            MainModule.set_startColor(&local_res8);
            uVar10 = (uint64)(uVar9 + 1);
            uVar12 = uVar12 + 12;
          }
        }
    }

    // Token : 0x600238B
    // RVA   : 0x9EF180   Offset: 0x9ED980   Length: 0x309
    private void Counter(int count)
    {
        long lVar1;
        long lVar2;
        uint uVar3;
        bool cVar4;
        int iVar5;
        ulong uVar6;
        uint uVar9;
        ulong local_res8;
        ulong local_e8;
        uint local_e0;
        ulong local_d8;
        uint local_d0;
        ulong local_c8;
        ulong uStack_c0;
        ulong local_b8;
        ulong uStack_b0;
        ulong local_a8;
        ulong uStack_a0;
        ulong local_98;
        uint local_88;
        uint uStack_84;
        uint uStack_80;
        uint32 uStack_7c;
        uint8 local_78 [16];
        uint8 local_68 [80];
        local_e8 = 0;
        uVar9 = 0;
        local_e0 = 0;
        count = this.Prefab + count;
        local_98 = 0;
        local_res8 = 0;
        this.Prefab = count;
        local_c8 = 0;
        uStack_c0 = 0;
        local_b8 = 0;
        uStack_b0 = 0;
        local_a8 = 0;
        uStack_a0 = 0;
        if (this.Prefabs != null) {
          iVar5 = *(int *)(this.Prefabs + 24) + -1;
          if (iVar5 < count) {
            this.Prefab = 0;
          }
          else if (count < 0) {
            this.Prefab = iVar5;
          }
          uVar6 = this.Instance;
          cVar4 = Object.op_Inequality(uVar6,0,0);
          if (cVar4) {
            uVar6 = this.Instance;
            Object.Destroy(uVar6,0);
          }
          lVar1 = this.Prefabs;
          if (lVar1 != null) {
            if (*(uint32 *)(lVar1 + 24) <= this.Prefab) {
              uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar6,0);
            }
            uVar6 = *(uint64 *)(lVar1 + 32 + (int64)(int)this.Prefab * 8);
            uVar6 = Object.Instantiate(uVar6,DAT_181d69cf8);
            this.Instance = uVar6;
            if (this.Instance != null) {
              uVar6 = FUN_180956bf0(this.Instance,DAT_181da2f30);
              this.particleSystems = uVar6;
              if (this.svList != null) {
                FUN_180f56130(this.svList,DAT_181d86ef0);
                lVar1 = this.particleSystems;
                if (lVar1 != null) {
                  while( true ) {
                    if ((int)*(uint32 *)(lVar1 + 24) <= (int)uVar9) {
                      return;
                    }
                    if (*(uint32 *)(lVar1 + 24) <= uVar9) {
                      uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                      FUN_1800d65f0(uVar6,0);
                    }
                    lVar2 = lVar1[uVar9];
                    if (lVar2 == null) break;
                    local_res8 = FUN_1804651e0(lVar2,0);
                    puVar7 = (uint64 *)MainModule.get_startColor(local_68,&local_res8,0);
                    local_c8 = *puVar7;
                    uStack_c0 = puVar7[1];
                    local_b8 = puVar7[2];
                    uStack_b0 = puVar7[3];
                    local_a8 = puVar7[4];
                    uStack_a0 = puVar7[5];
                    local_98 = puVar7[6];
                    puVar8 = (uint32 *)FUN_180464b40(local_78,&local_c8,0);
                    local_88 = *puVar8;
                    uStack_84 = puVar8[1];
                    uStack_80 = puVar8[2];
                    uVar3 = puVar8[3];
                    local_e8 = 0;
                    local_e0 = 0;
                    uStack_7c = uVar3;
                    Color.RGBToHSV(&local_88,this + 128,&local_e8,(int64)&local_e8 + 4,0);
                    local_e0 = uVar3;
                    if (this.svList == null) break;
                    local_d8 = local_e8;
                    local_d0 = uVar3;
                    FUN_181805a40();
                    uVar9 = uVar9 + 1;
                  }
                }
              }
            }
          }
        }
    }

    // Token : 0x600238C
    // RVA   : 0x9EF490   Offset: 0x9EDC90   Length: 0x49D
    private void LateUpdate()
    {
        ulong uVar1;
        ulong uVar2;
        bool cVar3;
        int iVar4;
        long lVar6;
        float fVar7;
        float fVar8;
        float fVar9;
        ulong uVar10;
        ulong local_78;
        ulong local_68;
        float local_60;
        ulong local_58;
        float local_50;
        ulong local_48;
        ulong uStack_40;
        ulong local_38;
        ulong uStack_30;
        fVar8 = this.currDistance;
        if (this.currDistance < 2.0) {
          this.currDistance = 0x40000000;
          fVar8 = 2.0;
        }
        fVar7 = (float)Input.GetAxis("Mouse ScrollWheel",0);
        uVar10 = this.Holder;
        this.currDistance = fVar8 - (fVar7 + fVar7);
        cVar3 = Object.op_Implicit(uVar10,0);
        if ((!cVar3) ||
           ((cVar3 = Input.GetMouseButton(0,0), !cVar3 &&
            (cVar3 = Input.GetMouseButton(1,0), !cVar3)))) {
          Cursor.set_visible(1,0);
          Cursor.set_lockState(0,0);
        }
        else {
          puVar5 = (uint64 *)Input.get_mousePosition(&local_48,0);
          local_68 = *puVar5;
          local_60 = *(float *)(puVar5 + 1);
          Screen.get_dpi(0);
          fVar8 = (float)Screen.get_dpi(0);
          if (fVar8 < 200.0) {
            fVar8 = 1.0;
          }
          else {
            fVar8 = (float)Screen.get_dpi(0);
            fVar8 = fVar8 / 200.0;
          }
          if ((float)local_68 < fVar8 * 380.0) {
            iVar4 = Screen.get_height(0);
            if ((float)iVar4 - local_68._4_4_ < fVar8 * 250.0) {
              return;
            }
          }
          Cursor.set_visible(0,0);
          Cursor.set_lockState(1);
          fVar8 = this.x;
          fVar9 = (float)Input.GetAxis("Mouse X",0);
          fVar7 = this.y;
          this.x = fVar9 * this.xRotate * 0.02 + fVar8;
          fVar8 = (float)Input.GetAxis("Mouse Y",0);
          this.y = fVar7 - fVar8 * this.yRotate * 0.02;
          uVar10 = FUN_1810a8ba0();
          this.y = (int)uVar10;
          puVar5 = (uint64 *)Quaternion.Euler(&local_38,uVar10,this.x,0,0);
          local_60 = -this.currDistance;
          uVar1 = *puVar5;
          uVar2 = puVar5[1];
          local_68 = 0;
          local_38 = uVar1;
          uStack_30 = uVar2;
          puVar5 = (uint64 *)Quaternion.op_Multiply(&local_48,&local_38,&local_68,0);
          uVar10 = *puVar5;
          fVar8 = *(float *)(puVar5 + 1);
          if (this.Holder == null) throw; // [null/range check failed]
          puVar5 = (uint64 *)Transform.get_position(&local_38,this.Holder,0);
          local_78._0_4_ = (float)uVar10;
          local_78._4_4_ = (float)((uint64)uVar10 >> 32);
          local_58 = *puVar5;
          local_50 = *(float *)(puVar5 + 1);
          local_60 = fVar8 + local_50;
          local_68 = CONCAT44(local_78._4_4_ + (float)((uint64)local_58 >> 32),
                              (float)local_78 + (float)local_58);
          uStack_40 = CONCAT44(uStack_40._4_4_,local_50);
          local_48 = local_58;
          lVar6 = Component.get_transform(this,0);
          if (lVar6 == null) throw; // [null/range check failed]
          local_38 = uVar1;
          uStack_30 = uVar2;
          Transform.set_rotation(lVar6,&local_38,0);
          lVar6 = Component.get_transform(this,0);
          if (lVar6 == null) throw; // [null/range check failed]
          local_50 = local_60;
          local_58 = local_68;
          Transform.set_position(lVar6,&local_58,0);
        }
        if (this.prevDistance == this.currDistance) {
          return;
        }
        this.prevDistance = this.currDistance;
        puVar5 = (uint64 *)
                 Quaternion.Euler(&local_38,this.y,
                                   this.x,0,0);
        local_60 = (float)(this.currDistance ^ 0x80000000);
        uVar10 = *puVar5;
        uVar1 = puVar5[1];
        local_68 = 0;
        local_48 = uVar10;
        uStack_40 = uVar1;
        puVar5 = (uint64 *)Quaternion.op_Multiply(&local_38,&local_48,&local_68,0);
        local_68 = *puVar5;
        local_60 = *(float *)(puVar5 + 1);
        if (this.Holder != null) {
          puVar5 = (uint64 *)Transform.get_position(&local_38,this.Holder,0);
          local_58 = *puVar5;
          local_50 = *(float *)(puVar5 + 1);
          fVar8 = local_60 + local_50;
          local_78 = CONCAT44(local_68._4_4_ + (float)((uint64)local_58 >> 32),
                              (float)local_68 + (float)local_58);
          lVar6 = Component.get_transform(this,0);
          if (lVar6 != null) {
            local_38 = uVar10;
            uStack_30 = uVar1;
            Transform.set_rotation(lVar6,&local_38,0);
            lVar6 = Component.get_transform(this,0);
            if (lVar6 != null) {
              local_58 = local_78;
              local_50 = fVar8;
              Transform.set_position(lVar6,&local_58,0);
              return;
            }
          }
        }
    }

    // Token : 0x600238D
    // RVA   : 0x9EF150   Offset: 0x9ED950   Length: 0x2A
    private static float ClampAngle(float angle, float min, float max)
    {
        void FUN_1809ef150(float angle,uint64 min,uint64 max)
        {
        if (angle < -360.0) {
          angle = angle + 360.0;
        }
        if (360.0 < angle) {
          angle = angle + -360.0;
        }
        FUN_1810a8ba0(angle,min,max,0);
    }

    // Token : 0x600238E
    // RVA   : 0x9EFF70   Offset: 0x9EE770   Length: 0xC2
    public void /*ctor*/()
    {
        ulong uVar1;
        this.currDistance = 0x40a00000;
        this.xRotate = 0x437a0000;
        this.yRotate = 0x42f00000;
        this.yMinLimit = 0xc1a00000;
        this.yMaxLimit = 0x42a00000;
        uVar1 = FUN_1800d60b0(DAT_181d7f500,0);
        this.particleSystems = uVar1;
        uVar1 = il2cpp_internal(DAT_181d74630);
        FUN_180f58a90(uVar1,DAT_181d86df0);
        this.svList = uVar1;
        FUN_18044ef50(this,0);
    }

}
