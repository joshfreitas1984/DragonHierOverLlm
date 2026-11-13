// ============================================================
// Type  : CloudAnimController
// Token : 0x2000256
// ============================================================

public class CloudAnimController
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x40012B5
    public List<GameObject> bigClouds;

    // Token: 0x40012B6
    public GameObject bigCloudPrefab;

    // Token: 0x40012B7
    private GameObject newCloud;

    // Token: 0x40012B8
    private static CloudAnimController _instance;

    // Token: 0x40012B9
    private static List<Vector2> allArea;

    // Token: 0x40012BA
    private List<int> distanceNumTotal;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x600134C
    // RVA   : 0x6FE7E0   Offset: 0x6FD5E0   Length: 0x57
    public static CloudAnimController get_Instance()
    {
        return **(uint64 **)(DAT_181e98068 + 184);
    }

    // Token : 0x600134D
    // RVA   : 0x6FDCB0   Offset: 0x6FCAB0   Length: 0x201
    private void Awake()
    {
        ulong uVar2;
        ulong uVar3;
        long lVar4;
        long lVar5;
        long lVar6;
        int iVar7;
        plVar1 = *(int64 **)(DAT_181e98068 + 184);
        *plVar1 = this;
        il2cpp_internal(plVar1,this);
        iVar7 = 0;
        while( true ) {
          lVar4 = this.bigClouds;
          uVar2 = Component.get_gameObject(this,0);
          uVar3 = this.bigCloudPrefab;
          uVar3 = GlobalData.AddChild(uVar2,uVar3,0);
          if (lVar4 == null) break;
          FUN_18175de30(lVar4,uVar3,DAT_181e6b6f8);
          if (this.bigClouds == null) break;
          lVar4 = FUN_1800024b0(this.bigClouds,iVar7,DAT_181e6bc70);
          if (lVar4 == null) break;
          GameObject.SetActive(lVar4,0,0);
          if (this.bigClouds == null) break;
          lVar4 = FUN_1800024b0(this.bigClouds,iVar7,DAT_181e6bc70);
          if (lVar4 == null) break;
          lVar4 = GameObject.GetComponent(lVar4,DAT_181e56c80);
          lVar5 = FUN_1806ef720(0);
          if (lVar5 == null) break;
          lVar5 = *(int64 *)(lVar5 + 24);
          lVar6 = FUN_1806ef720(0);
          if (((lVar6 == null) || (*(int64 *)(lVar6 + 24) == 0)) || (lVar5 == null)) break;
          FUN_1800024b0(lVar5,(int64)iVar7 % (int64)*(int *)(*(int64 *)(lVar6 + 24) + 24) &
                              0xffffffff);
          if (lVar4 == null) break;
          SpriteRenderer.set_sprite(lVar4);
          iVar7 = iVar7 + 1;
          if (39 < iVar7) {
            return;
          }
        }
    }

    // Token : 0x600134E
    // RVA   : 0x6FDEC0   Offset: 0x6FCCC0   Length: 0x70E
    public void PlayerCloudAnim()
    {
        int iVar1;
        int iVar2;
        long lVar3;
        ulong uVar4;
        long lVar5;
        long lVar7;
        int iVar8;
        int iVar9;
        float fVar10;
        float fVar11;
        float fVar12;
        ulong uVar13;
        uint64 extraout_XMM0_Qa;
        uint64 extraout_XMM0_Qa_00;
        uint64 extraout_XMM0_Qa_01;
        uint64 extraout_XMM0_Qa_02;
        float fVar14;
        int local_res18;
        float local_res20;
        float fStackX_24;
        uint64 local_188;
        uint32 local_180;
        float local_178;
        float fStack_174;
        float local_170;
        uint64 local_168;
        uint64 uStack_160;
        uint64 local_158;
        uint32 local_150;
        float local_140;
        uint64 local_138;
        float local_130;
        float local_120;
        uint8 local_118 [16];
        uint8 local_108 [16];
        uint8 local_f8 [16];
        uint8 local_e8 [176];
        iVar9 = 0;
        local_188 = 0;
        local_180 = 0;
        local_res18 = 0;
        do {
          fVar14 = 0.0;
          uVar4 = this.distanceNumTotal;
          lVar3 = il2cpp_internal(DAT_181e73cb8);
          uVar13 = FUN_18177a7d0(lVar3,uVar4,DAT_181e712f0);
          iVar8 = 0;
          do {
            if (lVar3 == null) {
        LAB_1806fe5c9:
                          // WARNING: Subroutine does not return
              FUN_1801e0300(uVar13);
            }
            iVar1 = FUN_180002480(lVar3,(int)fVar14,DAT_181e71bf0);
            if (iVar1 < 1) {
              fVar14 = fVar14 + 1.0;
            }
            fVar10 = (float)Random.Range();
            fVar10 = fVar10 + fVar14 + fVar10 + fVar14;
            uVar13 = Random.Range();
            if (this.distanceNumTotal == null) goto LAB_1806fe5c9;
            iVar1 = (int)fVar14;
            FUN_180002480(this.distanceNumTotal,iVar1,DAT_181e71bf0);
            uVar13 = FUN_180002480(lVar3,iVar1,DAT_181e71bf0);
            if (this.distanceNumTotal == null) goto LAB_1806fe5c9;
            iVar2 = FUN_180002480(this.distanceNumTotal,iVar1,DAT_181e71bf0);
            uVar13 = (uint64)(uint32)((float)iVar2 * 4.0);
            if (this.bigClouds == null) goto LAB_1806fe5c9;
            uVar4 = FUN_1800024b0(this.bigClouds,iVar8 + iVar9,DAT_181e6bc70);
            this.newCloud = uVar4;
            uVar13 = il2cpp_internal(this + 40,uVar4);
            if (this.newCloud == null) goto LAB_1806fe5c9;
            uVar13 = GameObject.SetActive(this.newCloud,1,0);
            if (this.newCloud == null) goto LAB_1806fe5c9;
            lVar5 = GameObject.GetComponent(this.newCloud,DAT_181e56c80);
            puVar6 = (uint64 *)FUN_180f24d00(local_e8,0);
            uVar13 = extraout_XMM0_Qa;
            if (lVar5 == null) goto LAB_1806fe5c9;
            local_168 = *puVar6;
            uStack_160 = puVar6[1];
            uVar13 = SpriteRenderer.set_color(lVar5,&local_168,0);
            if (this.newCloud == null) goto LAB_1806fe5c9;
            lVar5 = GameObject.get_transform(this.newCloud,0);
            fVar11 = (float)FUN_1801e84c0();
            uVar13 = FUN_1801e7fc0();
            fVar12 = (float)uVar13;
            if (((*(byte *)(DAT_181e98068 + 0x133) & 4) != 0) && (*(int *)(DAT_181e98068 + 224) == 0)) {
              uVar13 = il2cpp_runtime_class_init(DAT_181e98068);
            }
            lVar7 = *(int64 *)(*(int64 *)(DAT_181e98068 + 184) + 8);
            if (lVar7 == null) goto LAB_1806fe5c9;
            uVar4 = FUN_18005f0b0(lVar7,local_res18,DAT_181e8e0d8);
            local_res20 = (float)uVar4;
            fStackX_24 = (float)((uint64)uVar4 >> 32);
            fStackX_24 = fStackX_24 * fVar11 * fVar10;
            uVar13 = (uint64)(uint32)fStackX_24;
            if (lVar5 == null) goto LAB_1806fe5c9;
            local_158 = CONCAT44(fStackX_24,local_res20 * fVar12 * fVar10);
            local_150 = 0;
            uVar13 = Transform.set_localPosition(lVar5,&local_158,0);
            if (this.newCloud == null) goto LAB_1806fe5c9;
            lVar5 = GameObject.get_transform(this.newCloud,0);
            puVar6 = (uint64 *)Vector3.get_one(local_118,0);
            local_140 = *(float *)(puVar6 + 1);
            uStack_160 = CONCAT44((int)((uint64)uStack_160 >> 32),local_140);
            local_168 = *puVar6;
            fVar11 = fVar10 / 5.0 + 0.1;
            uVar13 = (uint64)(uint32)(local_140 * fVar11);
            if (lVar5 == null) goto LAB_1806fe5c9;
            local_138 = CONCAT44((float)((uint64)local_168 >> 32) * fVar11,(float)local_168 * fVar11)
            ;
            local_130 = local_140 * fVar11;
            uVar13 = Transform.set_localScale(lVar5,&local_138,0);
            if (this.newCloud == null) goto LAB_1806fe5c9;
            uVar4 = GameObject.get_transform(this.newCloud,0);
            uVar4 = ShortcutExtensions.DOScale(uVar4,0x40300000,0x3fa00000,0);
            uVar4 = TweenSettingsExtensions.SetEase(uVar4,3,DAT_181ea4b88);
            uVar13 = TweenSettingsExtensions.SetUpdate(uVar4,1,DAT_181ea59e0);
            if (this.newCloud == null) goto LAB_1806fe5c9;
            lVar5 = GameObject.GetComponent(this.newCloud,DAT_181e562f0);
            Random.Range();
            uVar13 = Mathf.Max();
            if (lVar5 == null) goto LAB_1806fe5c9;
            *(int *)(lVar5 + 24) = (int)uVar13;
            if (this.newCloud == null) goto LAB_1806fe5c9;
            lVar5 = GameObject.GetComponent(this.newCloud,DAT_181e562f0);
            uVar13 = Random.Range();
            if (lVar5 == null) goto LAB_1806fe5c9;
            *(int *)(lVar5 + 28) = (int)uVar13;
            if (this.newCloud == null) goto LAB_1806fe5c9;
            lVar5 = GameObject.GetComponent(this.newCloud,DAT_181e53078);
            uVar13 = extraout_XMM0_Qa_00;
            if (this.newCloud == null) goto LAB_1806fe5c9;
            lVar7 = GameObject.get_transform(this.newCloud,0);
            uVar13 = extraout_XMM0_Qa_01;
            if (lVar7 == null) goto LAB_1806fe5c9;
            puVar6 = (uint64 *)Transform.get_localPosition(local_108,lVar7,0);
            local_188 = *puVar6;
            local_180 = *(uint32 *)(puVar6 + 1);
            puVar6 = (uint64 *)Vector3.get_normalized(local_f8,&local_188,0);
            uVar4 = *puVar6;
            local_120 = *(float *)(puVar6 + 1);
            uVar13 = Mathf.Max(5.0 - fVar10 / 1.6,0x3e800000,0);
            local_170 = (float)uVar13;
            local_178 = (float)uVar4 * local_170;
            fStack_174 = (float)((uint64)uVar4 >> 32) * local_170;
            local_170 = local_120 * local_170;
            if (lVar5 == null) goto LAB_1806fe5c9;
            uVar13 = CONCAT44(fStack_174,local_178);
            *(uint64 *)(lVar5 + 28) = uVar13;
            *(float *)(lVar5 + 36) = local_170;
            if (this.newCloud == null) goto LAB_1806fe5c9;
            lVar5 = GameObject.GetComponent(this.newCloud,DAT_181e53078);
            uVar13 = extraout_XMM0_Qa_02;
            if (lVar5 == null) goto LAB_1806fe5c9;
            *(uint32 *)(lVar5 + 48) = 0x3dcccccd;
            iVar2 = FUN_180002480(lVar3,iVar1,DAT_181e71bf0);
            uVar13 = FUN_181774110(lVar3,iVar1,iVar2 + -1);
            iVar8 = iVar8 + 1;
          } while (iVar8 < 10);
          local_res18 = local_res18 + 1;
          iVar9 = iVar9 + 10;
          if (39 < iVar9) {
            return;
          }
        } while( true );
    }

    // Token : 0x600134F
    // RVA   : 0x6FE700   Offset: 0x6FD500   Length: 0xDC
    public void /*ctor*/()
    {
        long lVar1;
        lVar1 = il2cpp_internal(DAT_181e73cb8);
        FUN_1810f3480(lVar1,DAT_181e71270);
        if (lVar1 != null) {
          FUN_181769fe0(lVar1,2,DAT_181e713f0);
          FUN_181769fe0(lVar1,2,DAT_181e713f0);
          FUN_181769fe0(lVar1,3,DAT_181e713f0);
          FUN_181769fe0(lVar1,3,DAT_181e713f0);
          this.distanceNumTotal = lVar1;
          FUN_180ae8740(this,0);
          return;
        }
    }

    // Token : 0x6001350
    // RVA   : 0x6FE5D0   Offset: 0x6FD3D0   Length: 0x12A
    private static void /*cctor*/()
    {
        long lVar1;
        lVar1 = il2cpp_internal(DAT_181e78b28);
        FUN_1810f3480(lVar1,DAT_181e8ded8);
        if (lVar1 != null) {
          FUN_181769ec0(lVar1,0x3f8000003f800000,DAT_181e8df58);
          FUN_181769ec0(lVar1,0xbf8000003f800000,DAT_181e8df58);
          FUN_181769ec0(lVar1,0x3f800000bf800000,DAT_181e8df58);
          FUN_181769ec0(lVar1,0xbf800000bf800000,DAT_181e8df58);
          plVar2 = (int64 *)(*(int64 *)(DAT_181e98068 + 184) + 8);
          *plVar2 = lVar1;
          il2cpp_internal(plVar2,lVar1);
          return;
        }
    }

}
