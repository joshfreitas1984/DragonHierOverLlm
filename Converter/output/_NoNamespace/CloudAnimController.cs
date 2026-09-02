// ============================================================
// Type  : CloudAnimController
// Token : 0x200024C
// ============================================================

public class CloudAnimController
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x40011F4
    public List<GameObject> bigClouds;

    // Token: 0x40011F5
    public GameObject bigCloudPrefab;

    // Token: 0x40011F6
    private GameObject newCloud;

    // Token: 0x40011F7
    private static CloudAnimController _instance;

    // Token: 0x40011F8
    private static List<Vector2> allArea;

    // Token: 0x40011F9
    private List<int> distanceNumTotal;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60012E7
    // RVA   : 0x9FCE90   Offset: 0x9FB690   Length: 0x57
    public static CloudAnimController get_Instance()
    {
        return **(uint64 **)(DAT_181d92bf0 + 184);
    }

    // Token : 0x60012E8
    // RVA   : 0x9FC340   Offset: 0x9FAB40   Length: 0x201
    private void Awake()
    {
        ulong uVar2;
        ulong uVar3;
        long lVar4;
        long lVar5;
        long lVar6;
        int iVar7;
        plVar1 = *(int64 **)(DAT_181d92bf0 + 184);
        *plVar1 = this;
        il2cpp_internal(plVar1,this);
        iVar7 = 0;
        while( true ) {
          lVar4 = this.bigClouds;
          uVar2 = Component.get_gameObject(this,0);
          uVar3 = this.bigCloudPrefab;
          uVar3 = GlobalData.AddChild(uVar2,uVar3,0);
          if (lVar4 == null) break;
          FUN_181827900(lVar4,uVar3,DAT_181d61bf8);
          if (this.bigClouds == null) break;
          lVar4 = FUN_180002f80(this.bigClouds,iVar7,DAT_181d62178);
          if (lVar4 == null) break;
          GameObject.SetActive(lVar4,0,0);
          if (this.bigClouds == null) break;
          lVar4 = FUN_180002f80(this.bigClouds,iVar7,DAT_181d62178);
          if (lVar4 == null) break;
          lVar4 = GameObject.GetComponent(lVar4,DAT_181da19b0);
          lVar5 = FUN_1809d4a70(0);
          if (lVar5 == null) break;
          lVar5 = *(int64 *)(lVar5 + 24);
          lVar6 = FUN_1809d4a70(0);
          if (((lVar6 == null) || (*(int64 *)(lVar6 + 24) == 0)) || (lVar5 == null)) break;
          FUN_180002f80(lVar5,(int64)iVar7 % (int64)*(int *)(*(int64 *)(lVar6 + 24) + 24) &
                              0xffffffff);
          if (lVar4 == null) break;
          SpriteRenderer.set_sprite(lVar4);
          iVar7 = iVar7 + 1;
          if (39 < iVar7) {
            return;
          }
        }
    }

    // Token : 0x60012E9
    // RVA   : 0x9FC550   Offset: 0x9FAD50   Length: 0x722
    public void PlayerCloudAnim()
    {
        int iVar1;
        int iVar2;
        ulong uVar3;
        long lVar4;
        long lVar5;
        long lVar7;
        int iVar8;
        int iVar9;
        float fVar10;
        float fVar11;
        float fVar12;
        uint uVar13;
        float fVar14;
        int local_res18;
        float local_res20;
        float fStackX_24;
        ulong local_188;
        uint local_180;
        float local_178;
        float fStack_174;
        float local_170;
        ulong local_168;
        ulong uStack_160;
        ulong local_158;
        uint local_150;
        float local_140;
        ulong local_138;
        float local_130;
        float local_120;
        byte[] local_118 = new byte[16];
        byte[] local_108 = new byte[16];
        byte[] local_f8 = new byte[16];
        byte[] local_e8 = new byte[176];
        iVar9 = 0;
        local_188 = 0;
        local_180 = 0;
        local_res18 = 0;
        while( true ) {
          fVar14 = 0.0;
          if (this.distanceNumTotal == null) break;
          uVar3 = FUN_180f582c0(this.distanceNumTotal,DAT_181d680f0);
          lVar4 = il2cpp_internal(DAT_181d6f030);
          FUN_18182e120(lVar4,uVar3,DAT_181d67978);
          iVar8 = 0;
          do {
            if (lVar4 == null) throw; // [null/range check failed]
            iVar1 = FUN_1800d6750(lVar4,(int)fVar14,DAT_181d68270);
            if (iVar1 < 1) {
              fVar14 = fVar14 + 1.0;
            }
            fVar10 = (float)Random.Range();
            fVar10 = fVar10 + fVar14 + fVar10 + fVar14;
            Random.Range();
            if (this.distanceNumTotal == null) throw; // [null/range check failed]
            iVar1 = (int)fVar14;
            FUN_1800d6750(this.distanceNumTotal,iVar1,DAT_181d68270);
            FUN_1800d6750(lVar4,iVar1,DAT_181d68270);
            if (this.distanceNumTotal == null) throw; // [null/range check failed]
            FUN_1800d6750(this.distanceNumTotal,iVar1,DAT_181d68270);
            if (this.bigClouds == null) throw; // [null/range check failed]
            uVar3 = FUN_180002f80(this.bigClouds,iVar8 + iVar9,DAT_181d62178);
            this.newCloud = uVar3;
            if (this.newCloud == null) throw; // [null/range check failed]
            GameObject.SetActive(this.newCloud,1,0);
            if (this.newCloud == null) throw; // [null/range check failed]
            lVar5 = GameObject.GetComponent(this.newCloud,DAT_181da19b0);
            puVar6 = (uint64 *)FUN_181098a50(local_e8,0);
            if (lVar5 == null) throw; // [null/range check failed]
            local_168 = *puVar6;
            uStack_160 = puVar6[1];
            SpriteRenderer.set_color(lVar5,&local_168,0);
            if (this.newCloud == null) throw; // [null/range check failed]
            lVar5 = GameObject.get_transform(this.newCloud,0);
            fVar11 = (float)FUN_1801e72c0();
            fVar12 = (float)FUN_1801e67c0();
            lVar7 = *(int64 *)(*(int64 *)(DAT_181d92bf0 + 184) + 8);
            if (lVar7 == null) throw; // [null/range check failed]
            uVar3 = FUN_180132c70(lVar7,local_res18,DAT_181d840f8);
            local_res20 = (float)uVar3;
            fStackX_24 = (float)((uint64)uVar3 >> 32);
            if (lVar5 == null) throw; // [null/range check failed]
            local_158 = CONCAT44(fStackX_24 * fVar11 * fVar10,local_res20 * fVar12 * fVar10);
            local_150 = 0;
            Transform.set_localPosition(lVar5,&local_158,0);
            if (this.newCloud == null) throw; // [null/range check failed]
            lVar5 = GameObject.get_transform(this.newCloud,0);
            puVar6 = (uint64 *)Vector3.get_one(local_118,0);
            local_140 = *(float *)(puVar6 + 1);
            uStack_160 = CONCAT44((int)((uint64)uStack_160 >> 32),local_140);
            local_168 = *puVar6;
            fVar11 = fVar10 / 5.0 + 0.1;
            if (lVar5 == null) throw; // [null/range check failed]
            local_138 = CONCAT44((float)((uint64)local_168 >> 32) * fVar11,(float)local_168 * fVar11)
            ;
            local_130 = local_140 * fVar11;
            Transform.set_localScale(lVar5,&local_138,0);
            if (this.newCloud == null) throw; // [null/range check failed]
            uVar3 = GameObject.get_transform(this.newCloud,0);
            uVar3 = ShortcutExtensions.DOScale(uVar3,0x40300000,0x3fa00000,0);
            uVar3 = TweenSettingsExtensions.SetEase(uVar3,3,DAT_181d97ca8);
            TweenSettingsExtensions.SetUpdate(uVar3,1,DAT_181d98af0);
            if (this.newCloud == null) throw; // [null/range check failed]
            lVar5 = GameObject.GetComponent(this.newCloud,DAT_181da10b0);
            Random.Range();
            uVar13 = Mathf.Max();
            if (lVar5 == null) throw; // [null/range check failed]
            *(uint32 *)(lVar5 + 24) = uVar13;
            if (this.newCloud == null) throw; // [null/range check failed]
            lVar5 = GameObject.GetComponent(this.newCloud,DAT_181da10b0);
            uVar13 = Random.Range();
            if (lVar5 == null) throw; // [null/range check failed]
            *(uint32 *)(lVar5 + 28) = uVar13;
            if (this.newCloud == null) throw; // [null/range check failed]
            lVar5 = GameObject.GetComponent(this.newCloud,DAT_181d9e228);
            if (this.newCloud == null) throw; // [null/range check failed]
            lVar7 = GameObject.get_transform(this.newCloud,0);
            if (lVar7 == null) throw; // [null/range check failed]
            puVar6 = (uint64 *)Transform.get_localPosition(local_108,lVar7,0);
            local_188 = *puVar6;
            local_180 = *(uint32 *)(puVar6 + 1);
            puVar6 = (uint64 *)Vector3.get_normalized(local_f8,&local_188,0);
            uVar3 = *puVar6;
            local_120 = *(float *)(puVar6 + 1);
            local_170 = (float)Mathf.Max(5.0 - fVar10 / 1.6,0x3e800000,0);
            local_178 = (float)uVar3 * local_170;
            fStack_174 = (float)((uint64)uVar3 >> 32) * local_170;
            local_170 = local_120 * local_170;
            if (lVar5 == null) throw; // [null/range check failed]
            *(uint64 *)(lVar5 + 28) = CONCAT44(fStack_174,local_178);
            *(float *)(lVar5 + 36) = local_170;
            if (this.newCloud == null) throw; // [null/range check failed]
            lVar5 = GameObject.GetComponent(this.newCloud,DAT_181d9e228);
            if (lVar5 == null) throw; // [null/range check failed]
            *(uint32 *)(lVar5 + 48) = 0x3dcccccd;
            iVar2 = FUN_1800d6750(lVar4,iVar1,DAT_181d68270);
            FUN_18181e970(lVar4,iVar1,iVar2 + -1);
            iVar8 = iVar8 + 1;
          } while (iVar8 < 10);
          local_res18 = local_res18 + 1;
          iVar9 = iVar9 + 10;
          if (39 < iVar9) {
            return;
          }
        }
    }

    // Token : 0x60012EA
    // RVA   : 0x9FCDB0   Offset: 0x9FB5B0   Length: 0xDC
    public void /*ctor*/()
    {
        long lVar1;
        lVar1 = il2cpp_internal(DAT_181d6f030);
        FUN_180f58a90(lVar1,DAT_181d678f8);
        if (lVar1 != null) {
          FUN_181814fa0(lVar1,2,DAT_181d67a78);
          FUN_181814fa0(lVar1,2,DAT_181d67a78);
          FUN_181814fa0(lVar1,3,DAT_181d67a78);
          FUN_181814fa0(lVar1,3,DAT_181d67a78);
          this.distanceNumTotal = lVar1;
          FUN_18044ef50(this,0);
          return;
        }
    }

    // Token : 0x60012EB
    // RVA   : 0x9FCC80   Offset: 0x9FB480   Length: 0x12A
    private static void /*cctor*/()
    {
        long lVar1;
        lVar1 = il2cpp_internal(DAT_181d73e30);
        FUN_180f58a90(lVar1,DAT_181d83ef8);
        if (lVar1 != null) {
          FUN_181814e80(lVar1,0x3f8000003f800000,DAT_181d83f78);
          FUN_181814e80(lVar1,0xbf8000003f800000,DAT_181d83f78);
          FUN_181814e80(lVar1,0x3f800000bf800000,DAT_181d83f78);
          FUN_181814e80(lVar1,0xbf800000bf800000,DAT_181d83f78);
          plVar2 = (int64 *)(*(int64 *)(DAT_181d92bf0 + 184) + 8);
          *plVar2 = lVar1;
          il2cpp_internal(plVar2,lVar1);
          return;
        }
    }

}
