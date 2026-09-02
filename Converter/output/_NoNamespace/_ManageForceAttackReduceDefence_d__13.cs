// ============================================================
// Type  : <ManageForceAttackReduceDefence>d__13
// Token : 0x2000282
// ============================================================

public class <ManageForceAttackReduceDefence>d__13
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x40013AF
    private int <>1__state;

    // Token: 0x40013B0
    private object <>2__current;

    // Token: 0x40013B1
    public ForceAttackAreaResultController <>4__this;

    // Token: 0x40013B2
    private float <originDeltaFightScore>5__2;

    // Token: 0x40013B3
    private float <deltaOneTime>5__3;

    // Token: 0x40013B4
    private int <i>5__4;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x600145A
    // RVA   : 0x219070   Offset: 0x217870   Length: 0x24
    public void /*ctor*/(int <>1__state)
    {
        ZhSegment.Initialize(this,0);
        this.<>1__state = <>1__state;
    }

    // Token : 0x600145B
    // RVA   : 0x245810   Offset: 0x244010   Length: 0x3
    private virtual void System.IDisposable.Dispose()
    {
    }

    // Token : 0x600145C
    // RVA   : 0x8CD5A0   Offset: 0x8CBDA0   Length: 0x6C9
    private virtual bool MoveNext()
    {
        var pStatics = *(int64*)(DAT_181d4ef00 + 184);
        ulong uVar1;
        uint uVar2;
        long lVar3;
        long lVar5;
        long lVar6;
        ulong uVar9;
        float fVar12;
        float fVar13;
        float[] local_res8 = new float[2];
        ulong local_88;
        uint local_80;
        uint local_78;
        uint uStack_74;
        uint uStack_70;
        uint32 uStack_6c;
        lVar3 = this.<>4__this;
        local_res8[0] = 0.0;
        if (this.<>1__state == 0) {
          this.<>1__state = 0xffffffff;
          if (lVar3 == null) goto LAB_1808cdc64;
          this.<originDeltaFightScore>5__2 = *(uint32 *)(lVar3 + 48);
          fVar12 = *(float *)(lVar3 + 48);
          fVar13 = *(float *)(pStatics + 136);
          this.<i>5__4 = 0;
          this.<deltaOneTime>5__3 = fVar12 * 0.1 * fVar13;
        LAB_1808cdb77:
          *(float *)(lVar3 + 48) = *(float *)(lVar3 + 48) - this.<originDeltaFightScore>5__2 * 0.1;
          uVar9 = new WaitForSeconds(0x3f000000,0);
          this.<>2__current = uVar9;
          uVar9 = 1;
          this.<>1__state = 1;
        }
        else {
          if (this.<>1__state == 1) {
            this.<>1__state = 0xffffffff;
            plVar4 = (int64 *)Resources.Load("Sound/SoundEffect/AtkHit0",0);
            plVar11 = (int64 *)0;
            plVar10 = plVar11;
            if ((plVar4 != (int64 *)0) && (plVar10 = (int64 *)0, *plVar4 == DAT_181d8a228)) {
              plVar10 = plVar4;
            }
            NGUITools.PlaySound(plVar10,0);
            fVar12 = -1.0;
            if ((lVar3 == null) || (lVar5 = *(int64 *)(lVar3 + 40)) == null) goto LAB_1808cdc64;
            if (0.0 < *(float *)(lVar5 + 88)) {
              if (((*(byte *)(DAT_181d4ef00 + 0x133) & 4) != 0) && (*(int *)(DAT_181d4ef00 + 224) == 0))
              {
                il2cpp_runtime_class_init(DAT_181d4ef00);
                lVar5 = *(int64 *)(lVar3 + 40);
              }
              if (lVar5 == null) goto LAB_1808cdc64;
              fVar12 = (*(float *)(pStatics + 132) * *(float *)(lVar5 + 88))
                       / 100.0;
              local_res8[0] = -fVar12 * this.<deltaOneTime>5__3;
              if (*(int64 *)(lVar3 + 40) == 0) goto LAB_1808cdc64;
              AreaData.ChangeSupport(*(int64 *)(lVar3 + 40),local_res8[0],0);
              lVar5 = FUN_18046c0a0(0);
              uVar9 = Single.ToString(local_res8,"f0",0);
              if (*(int64 *)(lVar3 + 64) == 0) goto LAB_1808cdc64;
              lVar6 = GameObject.get_transform(*(int64 *)(lVar3 + 64),0);
              if (lVar6 == null) goto LAB_1808cdc64;
              lVar6 = Transform.Find(lVar6,"Support",0);
              if (lVar6 == null) goto LAB_1808cdc64;
              puVar7 = (uint64 *)Transform.get_position(&local_88,lVar6,0);
              uVar1 = *puVar7;
              uVar2 = *(uint32 *)(puVar7 + 1);
              puVar8 = (uint32 *)Color.get_red(&local_78,0);
              if (lVar5 == null) goto LAB_1808cdc64;
              local_78 = *puVar8;
              uStack_74 = puVar8[1];
              uStack_70 = puVar8[2];
              uStack_6c = puVar8[3];
              local_88 = uVar1;
              local_80 = uVar2;
              GameController.ShowTextAtPos(lVar5,uVar9,&local_88,20,&local_78,0);
              lVar5 = *(int64 *)(lVar3 + 40);
              fVar12 = fVar12 - 1.0;
            }
            if (lVar5 == null) goto LAB_1808cdc64;
            if (0.0 < *(float *)(lVar5 + 84)) {
              if (((*(byte *)(DAT_181d4ef00 + 0x133) & 4) != 0) && (*(int *)(DAT_181d4ef00 + 224) == 0))
              {
                il2cpp_runtime_class_init(DAT_181d4ef00);
                lVar5 = *(int64 *)(lVar3 + 40);
              }
              if (lVar5 == null) goto LAB_1808cdc64;
              fVar13 = (*(float *)(pStatics + 132) * *(float *)(lVar5 + 84))
                       / 100.0;
              local_res8[0] = -fVar13 * this.<deltaOneTime>5__3;
              if (*(int64 *)(lVar3 + 40) == 0) goto LAB_1808cdc64;
              AreaData.ChangeSafe(*(int64 *)(lVar3 + 40),local_res8[0],0);
              lVar5 = FUN_18046c0a0(0);
              uVar9 = Single.ToString(local_res8,"f0",0);
              if (*(int64 *)(lVar3 + 64) == 0) goto LAB_1808cdc64;
              lVar6 = GameObject.get_transform(*(int64 *)(lVar3 + 64),0);
              if (lVar6 == null) goto LAB_1808cdc64;
              lVar6 = Transform.Find(lVar6,"Safe",0);
              if (lVar6 == null) goto LAB_1808cdc64;
              puVar7 = (uint64 *)Transform.get_position(&local_88,lVar6,0);
              uVar1 = *puVar7;
              uVar2 = *(uint32 *)(puVar7 + 1);
              puVar8 = (uint32 *)Color.get_red(&local_78,0);
              if (lVar5 == null) goto LAB_1808cdc64;
              local_78 = *puVar8;
              uStack_74 = puVar8[1];
              uStack_70 = puVar8[2];
              uStack_6c = puVar8[3];
              local_88 = uVar1;
              local_80 = uVar2;
              GameController.ShowTextAtPos(lVar5,uVar9,&local_88,20,&local_78,0);
              fVar12 = fVar12 + fVar13;
            }
            local_res8[0] = fVar12 * this.<deltaOneTime>5__3;
            if (*(int64 *)(lVar3 + 40) == 0) {
        LAB_1808cdc64:
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            AreaData.ChangeDefence(*(int64 *)(lVar3 + 40),local_res8[0],0);
            lVar5 = FUN_18046c0a0(0);
            uVar9 = Single.ToString(local_res8,"f0",0);
            if (*(int64 *)(lVar3 + 64) == 0) goto LAB_1808cdc64;
            lVar6 = GameObject.get_transform(*(int64 *)(lVar3 + 64),0);
            if (lVar6 == null) goto LAB_1808cdc64;
            lVar6 = Transform.Find(lVar6,"DefenceText",0);
            if (lVar6 == null) goto LAB_1808cdc64;
            puVar7 = (uint64 *)Transform.get_position(&local_88,lVar6,0);
            uVar1 = *puVar7;
            uVar2 = *(uint32 *)(puVar7 + 1);
            puVar8 = (uint32 *)Color.get_red(&local_78,0);
            if (lVar5 == null) goto LAB_1808cdc64;
            local_78 = *puVar8;
            uStack_74 = puVar8[1];
            uStack_70 = puVar8[2];
            uStack_6c = puVar8[3];
            local_88 = uVar1;
            local_80 = uVar2;
            GameController.ShowTextAtPos(lVar5,uVar9,&local_88,20,&local_78,0);
            ForceAttackAreaResultController.RefreshUI(lVar3,0);
            if (*(int64 *)(lVar3 + 40) == 0) goto LAB_1808cdc64;
            if (*(float *)(*(int64 *)(lVar3 + 40) + 92) <= 0.0) {
              plVar4 = (int64 *)Resources.Load("Sound/SoundEffect/TearDown",0);
              if ((plVar4 != (int64 *)0) && (*plVar4 == DAT_181d8a228)) {
                plVar11 = plVar4;
              }
              NGUITools.PlaySound(plVar11,0);
            }
            else {
              this.<i>5__4 = this.<i>5__4 + 1;
              if (this.<i>5__4 < 10) goto LAB_1808cdb77;
            }
            *(uint8 *)(lVar3 + 56) = 0;
          }
          uVar9 = 0;
        }
        return uVar9;
    }

    // Token : 0x600145D
    // RVA   : 0x20F140   Offset: 0x20D940   Length: 0x5
    private virtual object System.Collections.Generic.IEnumerator<System.object>.get_Current()
    {
        return this.<>2__current;
    }

    // Token : 0x600145E
    // RVA   : 0x8CDC70   Offset: 0x8CC470   Length: 0x3E
    private virtual void System.Collections.IEnumerator.Reset()
    {
        ulong uVar1;
        ulong uVar2;
        uVar1 = il2cpp_runtime_class_init(&DAT_181d682e8);
        uVar1 = il2cpp_internal(uVar1);
        NotSupportedException.ctor(uVar1,0);
        uVar2 = il2cpp_runtime_class_init(&DAT_181d7aa08);
    }

    // Token : 0x600145F
    // RVA   : 0x20F140   Offset: 0x20D940   Length: 0x5
    private virtual object System.Collections.IEnumerator.get_Current()
    {
        return this.<>2__current;
    }

}
