// ============================================================
// Type  : StudyDodgeTileController
// Token : 0x2000382
// ============================================================

public class StudyDodgeTileController
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001CB6
    public int column;

    // Token: 0x4001CB7
    public int row;

    // Token: 0x4001CB8
    public bool attacking;

    // Token: 0x4001CB9
    public float nextAttackTime;

    // Token: 0x4001CBA
    public float nextAttackTimeCount;

    // Token: 0x4001CBB
    public bool nailOut;

    // Token: 0x4001CBC
    public GameObject attackRange;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6002259
    // RVA   : 0xFDB090   Offset: 0xFDA490   Length: 0x4F2
    private void Update()
    {
        var pStatics = *(int64*)(DAT_181da8028 + 184);
        bool cVar1;
        long lVar2;
        ulong uVar4;
        ulong uVar5;
        float fVar6;
        float fVar7;
        ulong local_58;
        float local_50;
        ulong local_48;
        float local_40;
        byte[] local_38 = new byte[16];
        byte[] local_28 = new byte[32];
        if (!this.attacking) {
          if (this.attackRange == null) throw; // [null/range check failed]
          lVar2 = GameObject.get_transform(this.attackRange,0);
          puVar3 = (uint64 *)Vector3.get_zero(local_38,0);
          if (lVar2 == null) throw; // [null/range check failed]
          local_50 = *(float *)(puVar3 + 1);
          local_58 = *puVar3;
          Transform.set_localScale(lVar2,&local_58,0);
        }
        else {
          fVar7 = this.nextAttackTimeCount;
          fVar6 = (float)Time.get_deltaTime(0);
          this.nextAttackTimeCount = fVar6 + fVar7;
          if (this.attackRange == null) throw; // [null/range check failed]
          lVar2 = GameObject.get_transform(this.attackRange,0);
          fVar7 = this.nextAttackTimeCount;
          puVar3 = (uint64 *)Vector3.get_one(local_28,0);
          local_40 = *(float *)(puVar3 + 1);
          local_48 = *puVar3;
          local_50 = this.nextAttackTime;
          local_58 = CONCAT44(((float)((uint64)local_48 >> 32) * fVar7) / local_50,
                              ((float)local_48 * fVar7) / local_50);
          local_50 = (local_40 * fVar7) / local_50;
          if (lVar2 == null) throw; // [null/range check failed]
          local_48 = local_58;
          local_40 = local_50;
          Transform.set_localScale(lVar2,&local_48,0);
          if (this.nextAttackTime <= this.nextAttackTimeCount) {
            this.attacking = 0;
            this.nextAttackTime = 0;
            lVar2 = Component.get_transform(this,0);
            if (lVar2 == null) throw; // [null/range check failed]
            uVar5 = Transform.Find(lVar2,"Nail",0);
            uVar5 = ShortcutExtensions.DOScaleY(uVar5,0x3f19999a,0x3dcccccd,0);
            uVar4 = new OnTooltipCB(this,DAT_181db7130,0);
            TweenSettingsExtensions.OnComplete(uVar5,uVar4,DAT_181dc0380);
            lVar2 = Component.get_transform(this,0);
            if (lVar2 == null) throw; // [null/range check failed]
            uVar5 = Transform.Find(lVar2,"Nail",0);
            uVar5 = ShortcutExtensions.DOScaleY(uVar5,0,0x3dcccccd,0);
            uVar5 = TweenSettingsExtensions.SetDelay(uVar5,0x3f000000,DAT_181dc0e10);
            uVar4 = new OnTooltipCB(this,DAT_181db71b8,0);
            TweenSettingsExtensions.OnComplete(uVar5,uVar4,DAT_181dc0380);
            lVar2 = Component.GetComponent(this,DAT_181d93378);
            if (lVar2 == null) throw; // [null/range check failed]
            fVar7 = (float)AudioSource.get_volume(lVar2,0);
            AudioSource.set_volume
                      (lVar2,fVar7 * *(float *)(*(int64 *)(DAT_181d72d50 + 184) + 16),0);
            lVar2 = Component.GetComponent(this,DAT_181d93378);
            if (lVar2 == null) throw; // [null/range check failed]
            AudioSource.Play(lVar2,0);
          }
        }
        if (*pStatics != 0) {
          uVar5 = *(uint64 *)(*pStatics + 24);
          uVar4 = Component.get_gameObject(this,0);
          cVar1 = Object.op_Equality(uVar5,uVar4,0);
          if ((!cVar1) || (!this.nailOut)) {
            return;
          }
          lVar2 = *pStatics;
          uVar5 = Component.get_gameObject(this,0);
          if (lVar2 != null) {
            StudyDodgePlayer.OnHit(lVar2,uVar5,0);
            StudyDodgeTileController.NailBack(this,0);
            lVar2 = Component.get_transform(this,0);
            if (lVar2 != null) {
              uVar5 = Transform.Find(lVar2,"Nail",0);
              DOTween.Kill(uVar5,0,0);
              lVar2 = Component.get_transform(this,0);
              if (lVar2 != null) {
                uVar5 = Transform.Find(lVar2,"Nail",0);
                ShortcutExtensions.DOScaleY(uVar5,0,0x3dcccccd,0);
                return;
              }
            }
          }
        }
    }

    // Token : 0x600225A
    // RVA   : 0xFDAEF0   Offset: 0xFDA2F0   Length: 0x177
    private void NailBack()
    {
        var pStatics = *(int64*)(DAT_181da80a8 + 184);
        long lVar1;
        ulong uVar2;
        this.nailOut = 0;
        lVar1 = *(int64 *)(pStatics + 8);
        if (lVar1 != null) {
          lVar1 = *(int64 *)(lVar1 + 104);
          uVar2 = Component.get_gameObject(this,0);
          if (lVar1 != null) {
            FUN_1817ef410(lVar1,uVar2,DAT_181d89630);
            lVar1 = *(int64 *)(pStatics + 8);
            if (lVar1 != null) {
              lVar1 = *(int64 *)(lVar1 + 96);
              uVar2 = Component.get_gameObject(this,0);
              if (lVar1 != null) {
                FUN_18181e6b0(lVar1,uVar2,DAT_181d893b0);
                return;
              }
            }
          }
        }
    }

    // Token : 0x600225B
    // RVA   : 0x3A17B0   Offset: 0x3A0BB0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_18044ef50(this,0);
    }

    // Token : 0x600225C
    // RVA   : 0xFDB070   Offset: 0xFDA470   Length: 0x5
    private void <Update>b__7_0()
    {
        void FUN_180fdb070(int64 this)
        {
        this.nailOut = 1;
    }

    // Token : 0x600225D
    // RVA   : 0xFDB080   Offset: 0xFDA480   Length: 0x7
    private void <Update>b__7_1()
    {
        void FUN_180fdb080(uint64 this)
        {
        StudyDodgeTileController.NailBack(this,0);
    }

}
