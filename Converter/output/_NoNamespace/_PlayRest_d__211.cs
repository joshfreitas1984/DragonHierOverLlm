// ============================================================
// Type  : <PlayRest>d__211
// Token : 0x2000163
// ============================================================

public class <PlayRest>d__211
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4000944
    private int <>1__state;

    // Token: 0x4000945
    private object <>2__current;

    // Token: 0x4000946
    public BattleController <>4__this;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000BA4
    // RVA   : 0x219070   Offset: 0x217870   Length: 0x24
    public void /*ctor*/(int <>1__state)
    {
        ZhSegment.Initialize(this,0);
        this.<>1__state = <>1__state;
    }

    // Token : 0x6000BA5
    // RVA   : 0x245810   Offset: 0x244010   Length: 0x3
    private virtual void System.IDisposable.Dispose()
    {
    }

    // Token : 0x6000BA6
    // RVA   : 0xB25110   Offset: 0xB23910   Length: 0x3A8
    private virtual bool MoveNext()
    {
        float fVar1;
        int iVar2;
        long lVar3;
        ulong uVar5;
        long lVar6;
        long lVar7;
        float fVar8;
        float fVar9;
        uint uVar10;
        ulong in_stack_ffffffffffffff98;
        ulong uVar11;
        uint local_38;
        uint uStack_34;
        uint uStack_30;
        uint32 uStack_2c;
        uVar10 = (uint32)((uint64)in_stack_ffffffffffffff98 >> 32);
        iVar2 = this.<>1__state;
        lVar6 = this.<>4__this;
        if (iVar2 == 0) {
          this.<>1__state = 0xffffffff;
          if (lVar6 != null) {
            lVar7 = *(int64 *)(lVar6 + 0x110);
            *(uint8 *)(lVar6 + 0x128) = 1;
            puVar4 = (uint32 *)Color.get_yellow(&local_38,0);
            if (lVar7 != null) {
              local_38 = *puVar4;
              uStack_34 = puVar4[1];
              uStack_30 = puVar4[2];
              uStack_2c = puVar4[3];
              uVar11 = CONCAT44(uVar10,24);
              BattleUnit.ShowTextOnHead(lVar7,"休息",&local_38,18,uVar11,"UIAtlas",0,0,0);
              lVar7 = *(int64 *)(lVar6 + 0x110);
              if ((lVar7 != null) && (lVar3 = *(int64 *)(lVar7 + 64)) != null) {
                if (*(char *)(lVar3 + 16) == false) {
                  if (*(float *)(lVar3 + 0x23c) <= 0.1) {
                    fVar1 = *(float *)(lVar3 + 0x178);
                    fVar9 = *(float *)(lVar3 + 0x17c);
                    fVar8 = (float)HeroData.GetRestCureRate(lVar3,0);
                    BattleUnit.ChangeHp(lVar7,fVar8 * fVar9,0,1,uVar11 & 0xffffffffffffff00,0);
                    if ((*(int64 *)(lVar6 + 0x110) == 0) ||
                       (lVar7 = *(int64 *)(*(int64 *)(lVar6 + 0x110) + 64)) == null)
                    throw; // [null/range check failed]
                    *(float *)(lVar7 + 0x23c) =
                         (*(float *)(lVar7 + 0x178) - fVar1) / *(float *)(lVar7 + 0x17c) +
                         *(float *)(lVar7 + 0x23c);
                    lVar7 = *(int64 *)(lVar6 + 0x110);
                  }
                  if ((lVar7 == null) || (lVar3 = *(int64 *)(lVar7 + 64)) == null)
                  throw; // [null/range check failed]
                  fVar1 = *(float *)(lVar3 + 0x194);
                  fVar9 = (float)HeroData.GetRestCureRate(lVar3,0);
                  fVar9 = fVar9 * fVar1;
                  BattleUnit.ChangeMana(lVar7,fVar9 + fVar9,0,1,0);
                  lVar7 = *(int64 *)(lVar6 + 0x110);
                  if ((lVar7 == null) || (*(int64 *)(lVar7 + 64) == 0)) throw; // [null/range check failed]
                  uVar10 = HeroData.GetRestCurePower(*(int64 *)(lVar7 + 64),0);
                  BattleUnit.ChangePower(lVar7,uVar10,0,0);
                  lVar7 = *(int64 *)(lVar6 + 0x110);
                  if ((lVar7 == null) || (*(int64 *)(lVar7 + 64) == 0)) throw; // [null/range check failed]
                  uVar10 = HeroData.GetRestCurePostureRate(*(int64 *)(lVar7 + 64),0);
                  BattleUnit.RecoverPartPosture(lVar7,uVar10,0);
                  lVar7 = *(int64 *)(lVar6 + 0x110);
                }
                if ((lVar7 != null) && (*(int64 *)(lVar7 + 64) != 0)) {
                  uVar5 = HeroData.Name(*(int64 *)(lVar7 + 64),1,0);
                  uVar5 = String.Format("{0}进行休息。",uVar5,0);
                  BattleController.AddInfoText(lVar6,uVar5,1,0);
                  lVar6 = FUN_18046c0a0(0);
                  if ((lVar6 != null) && (*(int64 *)(lVar6 + 32) != 0)) {
                    fVar1 = *(float *)(*(int64 *)(lVar6 + 32) + 0x1d8);
                    uVar5 = new WaitForSeconds(1.0 / fVar1,0);
                    this.<>2__current = uVar5;
                    this.<>1__state = 1;
                    return true;
                  }
                }
              }
            }
          }
        }
        else {
          if (iVar2 != 1) {
            if (iVar2 == 2) {
              this.<>1__state = 0xffffffff;
              return false;
            }
            return false;
          }
          this.<>1__state = 0xffffffff;
          if (lVar6 != null) {
            *(uint8 *)(lVar6 + 0x128) = 0;
            *(uint8 *)(lVar6 + 0x121) = 1;
            *(uint32 *)(lVar6 + 0x124) = 12;
            this.<>2__current = 0;
            this.<>1__state = 2;
            return true;
          }
        }
    }

    // Token : 0x6000BA7
    // RVA   : 0x20F140   Offset: 0x20D940   Length: 0x5
    private virtual object System.Collections.Generic.IEnumerator<System.object>.get_Current()
    {
        return this.<>2__current;
    }

    // Token : 0x6000BA8
    // RVA   : 0xB254C0   Offset: 0xB23CC0   Length: 0x3E
    private virtual void System.Collections.IEnumerator.Reset()
    {
        ulong uVar1;
        ulong uVar2;
        uVar1 = il2cpp_runtime_class_init(&DAT_181d682e8);
        uVar1 = il2cpp_internal(uVar1);
        NotSupportedException.ctor(uVar1,0);
        uVar2 = il2cpp_runtime_class_init(&DAT_181d6ed18);
    }

    // Token : 0x6000BA9
    // RVA   : 0x20F140   Offset: 0x20D940   Length: 0x5
    private virtual object System.Collections.IEnumerator.get_Current()
    {
        return this.<>2__current;
    }

}
