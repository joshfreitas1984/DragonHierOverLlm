// ============================================================
// Type  : CustomSkillChooseSpeAddController
// Token : 0x2000002
// ============================================================

public class CustomSkillChooseSpeAddController
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4000001
    public int speAddType;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000001
    // RVA   : 0x655440   Offset: 0x654240   Length: 0x1D5
    public void Init(int _speAddType)
    {
        uint uVar1;
        long lVar2;
        long lVar3;
        ulong uVar5;
        this.speAddType = _speAddType;
        lVar2 = *(int64 *)(*(int64 *)(DAT_181e528f8 + 184) + 32);
        if ((lVar2 != null) && (lVar2 = *(int64 *)(lVar2 + 144)) != null) {
          uVar1 = this.speAddType;
          if (*(uint32 *)(lVar2 + 24) <= uVar1) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          lVar2 = lVar2[uVar1];
          lVar3 = Component.get_transform(this,0);
          if ((((lVar3 != null) && (lVar3 = Transform.Find(lVar3,"Text",0)) != null) &&
              (plVar4 = (int64 *)Component.GetComponent(lVar3,DAT_181e79538), lVar2 != null)) &&
             (plVar4 != (int64 *)0)) {
            (**(code **)(*plVar4 + 0x5e8))
                      (plVar4,*(uint64 *)(lVar2 + 16),*(uint64 *)(*plVar4 + 0x5f0));
            if (((*(char *)(lVar2 + 89) == false) && (14 < this.speAddType)) &&
               (8 < this.speAddType - 24)) {
              return;
            }
            lVar3 = Component.get_gameObject(this,0);
            if (lVar3 != null) {
              lVar3 = GameObject.GetComponent(lVar3,DAT_181e56510);
              uVar5 = HeroSpeAddDataBase.GetDescribe(lVar2,0);
              if (lVar3 != null) {
                *(uint64 *)(lVar3 + 24) = uVar5;
                return;
              }
            }
          }
        }
    }

    // Token : 0x6000002
    // RVA   : 0x655380   Offset: 0x654180   Length: 0xB5
    public void ButtonClicked()
    {
        if (CustomSkillCreateController._instance != null) {
          CustomSkillCreateController.ChooseSpeAddData
                    (CustomSkillCreateController._instance,this.speAddType,0);
          return;
        }
    }

    // Token : 0x6000003
    // RVA   : 0x2110A0   Offset: 0x20FEA0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_180ae8740(this,0);
    }

}
