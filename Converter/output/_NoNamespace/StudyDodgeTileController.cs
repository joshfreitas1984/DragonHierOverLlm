// ============================================================
// Type  : StudyDodgeTileController
// Token : 0x200038F
// ============================================================

public class StudyDodgeTileController
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001D48
    public int column;

    // Token: 0x4001D49
    public int row;

    // Token: 0x4001D4A
    public bool attacking;

    // Token: 0x4001D4B
    public float nextAttackTime;

    // Token: 0x4001D4C
    public float nextAttackTimeCount;

    // Token: 0x4001D4D
    public bool nailOut;

    // Token: 0x4001D4E
    public GameObject attackRange;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6002303
    // RVA   : 0xDAC150   Offset: 0xDAAF50   Length: 0x4F2
    private void Update()
    {
        var pStatics = *(int64*)(DAT_181e88468 + 184);
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
            uVar4 = new OnTooltipCB(this,DAT_181e9aa88,0);
            TweenSettingsExtensions.OnComplete(uVar5,uVar4,DAT_181ea3dc0);
            lVar2 = Component.get_transform(this,0);
            if (lVar2 == null) throw; // [null/range check failed]
            uVar5 = Transform.Find(lVar2,"Nail",0);
            uVar5 = ShortcutExtensions.DOScaleY(uVar5,0,0x3dcccccd,0);
            uVar5 = TweenSettingsExtensions.SetDelay(uVar5,0x3f000000,DAT_181ea4858);
            uVar4 = new OnTooltipCB(this,DAT_181e9ab10,0);
            TweenSettingsExtensions.OnComplete(uVar5,uVar4,DAT_181ea3dc0);
            lVar2 = Component.GetComponent(this,DAT_181e766c0);
            if (lVar2 == null) throw; // [null/range check failed]
            fVar7 = (float)AudioSource.get_volume(lVar2,0);
            AudioSource.set_volume
                      (lVar2,fVar7 * *(float *)(*(int64 *)(DAT_181e528f8 + 184) + 16),0);
            lVar2 = Component.GetComponent(this,DAT_181e766c0);
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

    // Token : 0x6002304
    // RVA   : 0xDABFB0   Offset: 0xDAADB0   Length: 0x177
    private void NailBack()
    {
        var pStatics = *(int64*)(DAT_181e884e8 + 184);
        long lVar1;
        ulong uVar2;
        this.nailOut = 0;
        lVar1 = *(int64 *)(pStatics + 8);
        if (lVar1 != null) {
          lVar1 = *(int64 *)(lVar1 + 104);
          uVar2 = Component.get_gameObject(this,0);
          if (lVar1 != null) {
            FUN_181665e90(lVar1,uVar2,DAT_181e6b978);
            lVar1 = *(int64 *)(pStatics + 8);
            if (lVar1 != null) {
              lVar1 = *(int64 *)(lVar1 + 96);
              uVar2 = Component.get_gameObject(this,0);
              if (lVar1 != null) {
                FUN_18175de30(lVar1,uVar2,DAT_181e6b6f8);
                return;
              }
            }
          }
        }
    }

    // Token : 0x6002305
    // RVA   : 0x2110A0   Offset: 0x20FEA0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_180ae8740(this,0);
    }

    // Token : 0x6002306
    // RVA   : 0xDAC130   Offset: 0xDAAF30   Length: 0x5
    private void <Update>b__7_0()
    {
        void FUN_180dac130(int64 this)
        {
        this.nailOut = 1;
    }

    // Token : 0x6002307
    // RVA   : 0xDAC140   Offset: 0xDAAF40   Length: 0x7
    private void <Update>b__7_1()
    {
        void FUN_180dac140(uint64 this)
        {
        StudyDodgeTileController.NailBack(this,0);
    }

}
