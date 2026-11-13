// ============================================================
// Type  : StudyDodgeArrowController
// Token : 0x2000388
// ============================================================

public class StudyDodgeArrowController
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001D0E
    public GameObject barBack;

    // Token: 0x4001D0F
    public GameObject bar;

    // Token: 0x4001D10
    public Vector3 direction;

    // Token: 0x4001D11
    public float generateTime;

    // Token: 0x4001D12
    public float lifeTime;

    // Token: 0x4001D13
    private float speed;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60022D4
    // RVA   : 0xDA61F0   Offset: 0xDA4FF0   Length: 0x6B
    private void Start()
    {
        long lVar1;
        uint local_18;
        uint uStack_14;
        uint uStack_10;
        uint32 uStack_c;
        lVar1 = Component.GetComponent(this,DAT_181e791b8);
        puVar2 = (uint32 *)FUN_180af4e90(&local_18,0);
        if (lVar1 != null) {
          local_18 = *puVar2;
          uStack_14 = puVar2[1];
          uStack_10 = puVar2[2];
          uStack_c = puVar2[3];
          SpriteRenderer.set_color(lVar1,&local_18,0);
          return;
        }
    }

    // Token : 0x60022D5
    // RVA   : 0xDA6260   Offset: 0xDA5060   Length: 0x2A6
    private void Update()
    {
        long lVar1;
        ulong uVar4;
        float fVar5;
        float fVar6;
        ulong local_48;
        float local_40;
        uint local_38;
        uint uStack_34;
        float fStack_30;
        uint32 uStack_2c;
        fVar6 = this.lifeTime;
        if (fVar6 <= 0.0) {
          uVar4 = Component.get_gameObject(this,0);
          Object.Destroy(uVar4,0);
          return;
        }
        fVar5 = (float)Time.get_deltaTime(0);
        this.lifeTime = fVar6 - fVar5;
        fVar6 = this.generateTime;
        if (0.0 < fVar6) {
          fVar5 = (float)Time.get_deltaTime(0);
          this.generateTime = fVar6 - fVar5;
          if (0.0 < fVar6 - fVar5) {
            return;
          }
          if (this.barBack == null) goto LAB_180da6501;
          GameObject.SetActive(this.barBack,0,0);
          lVar1 = Component.GetComponent(this,DAT_181e791b8);
          puVar2 = (uint32 *)FUN_180f24d00(&local_38,0);
          if (lVar1 == null) goto LAB_180da6501;
          local_38 = *puVar2;
          uStack_34 = puVar2[1];
          fStack_30 = (float)puVar2[2];
          uStack_2c = puVar2[3];
          SpriteRenderer.set_color(lVar1,&local_38,0);
          lVar1 = Component.GetComponent(this,DAT_181e766c0);
          if (lVar1 == null) goto LAB_180da6501;
          fVar6 = (float)AudioSource.get_volume(lVar1,0);
          AudioSource.set_volume(lVar1,fVar6 * *(float *)(*(int64 *)(DAT_181e528f8 + 184) + 16),0);
          lVar1 = Component.GetComponent(this,DAT_181e766c0);
          if (lVar1 == null) goto LAB_180da6501;
          AudioSource.Play(lVar1,0);
          fVar6 = this.generateTime;
        }
        if (fVar6 <= 0.0) {
          lVar1 = Component.get_transform(this,0);
          if (lVar1 == null) {
        LAB_180da6501:
                          // WARNING: Subroutine does not return
            FUN_1801e0300();
          }
          puVar3 = (uint64 *)Transform.get_localPosition(&local_38,lVar1,0);
          local_40 = *(float *)(puVar3 + 1);
          uVar4 = *puVar3;
          fVar6 = (float)Time.get_deltaTime(0);
          fVar6 = fVar6 * this.speed;
          local_40 = *(float *)(this + 48) * fVar6 + local_40;
          local_48 = CONCAT44((float)((uint64)this.direction >> 32) * fVar6 +
                              (float)((uint64)uVar4 >> 32),
                              (float)this.direction * fVar6 + (float)uVar4);
          fStack_30 = local_40;
          Transform.set_localPosition(lVar1,&local_48,0);
        }
    }

    // Token : 0x60022D6
    // RVA   : 0xDA6100   Offset: 0xDA4F00   Length: 0xE6
    private void OnDestroy()
    {
        long lVar1;
        ulong uVar2;
        lVar1 = *(int64 *)(*(int64 *)(DAT_181e884e8 + 184) + 8);
        if (lVar1 != null) {
          lVar1 = *(int64 *)(lVar1 + 112);
          uVar2 = Component.get_gameObject(this,0);
          if (lVar1 != null) {
            FUN_181665e90(lVar1,uVar2,DAT_181e6b978);
            return;
          }
        }
    }

    // Token : 0x60022D7
    // RVA   : 0xDA6510   Offset: 0xDA5310   Length: 0x1C
    public void /*ctor*/()
    {
        void FUN_180da6510(int64 this)
        {
        this.generateTime = 0x3f800000;
        this.lifeTime = 0x40a00000;
        this.speed = 0x40a00000;
        FUN_180ae8740(this,0);
    }

}
