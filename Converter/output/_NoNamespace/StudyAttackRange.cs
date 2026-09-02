// ============================================================
// Type  : StudyAttackRange
// Token : 0x2000371
// ============================================================

public class StudyAttackRange
{
    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6002196
    // RVA   : 0xB84A80   Offset: 0xB83280   Length: 0x151
    private void OnTriggerEnter2D(Collider2D other)
    {
        var pStatics = *(int64*)(DAT_181d82cf0 + 184);
        long lVar1;
        bool cVar2;
        ulong uVar3;
        if (((*pStatics != 0) &&
            (lVar1 = *(int64 *)(*pStatics + 72), other != null)) &&
           (uVar3 = Component.get_gameObject(other,0), lVar1 != null)) {
          cVar2 = FUN_1818279a0(lVar1,uVar3,DAT_181d61cf8);
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
              FUN_181827900(lVar1,uVar3,DAT_181d61bf8);
              return;
            }
          }
        }
    }

    // Token : 0x6002197
    // RVA   : 0xB84BE0   Offset: 0xB833E0   Length: 0xDE
    private void OnTriggerExit2D(Collider2D other)
    {
        var pStatics = *(int64*)(DAT_181d82cf0 + 184);
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
              FUN_181801c10(lVar1,uVar3,DAT_181d61e78);
              return;
            }
          }
        }
    }

    // Token : 0x6002198
    // RVA   : 0x3A17B0   Offset: 0x39FFB0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_18044ef50(this,0);
    }

}
