// ============================================================
// Type  : StudyAttackRange
// Token : 0x2000378
// ============================================================

public class StudyAttackRange
{
    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6002217
    // RVA   : 0xFD3620   Offset: 0xFD2A20   Length: 0x151
    private void OnTriggerEnter2D(Collider2D other)
    {
        var pStatics = *(int64*)(DAT_181da7f28 + 184);
        long lVar1;
        bool cVar2;
        ulong uVar3;
        if (((*pStatics != 0) &&
            (lVar1 = *(int64 *)(*pStatics + 72), other != null)) &&
           (uVar3 = Component.get_gameObject(other,0), lVar1 != null)) {
          cVar2 = FUN_18181ea10(lVar1,uVar3,DAT_181d894b0);
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
              FUN_18181e6b0(lVar1,uVar3,DAT_181d893b0);
              return;
            }
          }
        }
    }

    // Token : 0x6002218
    // RVA   : 0xFD3780   Offset: 0xFD2B80   Length: 0xDE
    private void OnTriggerExit2D(Collider2D other)
    {
        var pStatics = *(int64*)(DAT_181da7f28 + 184);
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
              FUN_1817ef410(lVar1,uVar3,DAT_181d89630);
              return;
            }
          }
        }
    }

    // Token : 0x6002219
    // RVA   : 0x3A17B0   Offset: 0x3A0BB0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_18044ef50(this,0);
    }

}
