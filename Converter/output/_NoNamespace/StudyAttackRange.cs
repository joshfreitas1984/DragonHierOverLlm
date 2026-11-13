// ============================================================
// Type  : StudyAttackRange
// Token : 0x2000385
// ============================================================

public class StudyAttackRange
{
    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60022C1
    // RVA   : 0xDA46E0   Offset: 0xDA34E0   Length: 0x151
    private void OnTriggerEnter2D(Collider2D other)
    {
        var pStatics = *(int64*)(DAT_181e88368 + 184);
        long lVar1;
        bool cVar2;
        ulong uVar3;
        if (((*pStatics != 0) &&
            (lVar1 = *(int64 *)(*pStatics + 72), other != null)) &&
           (uVar3 = Component.get_gameObject(other,0), lVar1 != null)) {
          cVar2 = FUN_18175e190(lVar1,uVar3,DAT_181e6b7f8);
          if (cVar2) {
            return;
          }
          cVar2 = Component.CompareTag(other,"StudyAttackBullet",0);
          if ((!cVar2) && (cVar2 = Component.CompareTag(other,"StudySkillStar",0), !cVar2))
          {
            return;
          }
          if (*pStatics != 0) {
            lVar1 = *(int64 *)(*pStatics + 72);
            uVar3 = Component.get_gameObject(other,0);
            if (lVar1 != null) {
              FUN_18175de30(lVar1,uVar3,DAT_181e6b6f8);
              return;
            }
          }
        }
    }

    // Token : 0x60022C2
    // RVA   : 0xDA4840   Offset: 0xDA3640   Length: 0xDE
    private void OnTriggerExit2D(Collider2D other)
    {
        var pStatics = *(int64*)(DAT_181e88368 + 184);
        long lVar1;
        bool cVar2;
        ulong uVar3;
        if (other != null) {
          cVar2 = Component.CompareTag(other,"StudyAttackBullet",0);
          if ((!cVar2) && (cVar2 = Component.CompareTag(other,"StudySkillStar",0), !cVar2))
          {
            return;
          }
          if (*pStatics != 0) {
            lVar1 = *(int64 *)(*pStatics + 72);
            uVar3 = Component.get_gameObject(other,0);
            if (lVar1 != null) {
              FUN_181665e90(lVar1,uVar3,DAT_181e6b978);
              return;
            }
          }
        }
    }

    // Token : 0x60022C3
    // RVA   : 0x2110A0   Offset: 0x20FEA0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_180ae8740(this,0);
    }

}
