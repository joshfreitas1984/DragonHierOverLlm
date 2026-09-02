// ============================================================
// Type  : <StartAuctionDeal>d__46
// Token : 0x200014A
// ============================================================

public class <StartAuctionDeal>d__46
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4000843
    private int <>1__state;

    // Token: 0x4000844
    private object <>2__current;

    // Token: 0x4000845
    public AuctionController <>4__this;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000AB1
    // RVA   : 0x219070   Offset: 0x217870   Length: 0x24
    public void /*ctor*/(int <>1__state)
    {
        ZhSegment.Initialize(this,0);
        this.<>1__state = <>1__state;
    }

    // Token : 0x6000AB2
    // RVA   : 0x245810   Offset: 0x244010   Length: 0x3
    private virtual void System.IDisposable.Dispose()
    {
    }

    // Token : 0x6000AB3
    // RVA   : 0xB26650   Offset: 0xB24E50   Length: 0x80C
    private virtual bool MoveNext()
    {
        long lVar1;
        long lVar2;
        long lVar3;
        uint uVar4;
        long lVar6;
        ulong uVar7;
        ulong uVar9;
        ulong uVar10;
        ulong uVar11;
        float fVar13;
        int[] local_res8 = new int[2];
        ulong in_stack_ffffffffffffff68;
        uint uVar14;
        uint in_stack_ffffffffffffff70;
        ulong local_68;
        float local_60;
        byte[] local_58 = new byte[8];
        float local_50;
        byte[] local_48 = new byte[32];
        uVar14 = (uint32)((uint64)in_stack_ffffffffffffff68 >> 32);
        lVar1 = this.<>4__this;
        local_res8[0] = 0;
        if (this.<>1__state == 0) {
          this.<>1__state = 0xffffffff;
          if (lVar1 == null) goto LAB_180b26e57;
          *(uint32 *)(lVar1 + 72) = 4;
          plVar5 = (int64 *)Resources.Load("Sound/SoundEffect/EndBell",0);
          plVar12 = (int64 *)0;
          if ((plVar5 != (int64 *)0) && (*plVar5 == DAT_181d8a228)) {
            plVar12 = plVar5;
          }
          NGUITools.PlaySound(plVar12,0);
          if (*(int64 *)(lVar1 + 152) == 0) {
            lVar6 = *(int64 *)(lVar1 + 88);
            if (lVar6 == null) goto LAB_180b26e57;
            if (*(int *)(lVar6 + 24) == 0) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            if (*(int64 *)(*(int64 *)(lVar6 + 16) + 32) == *(int64 *)(lVar1 + 96)) {
              lVar6 = FUN_18046c0a0(0);
              if ((lVar6 == null) || (*(int64 *)(lVar6 + 32) == 0)) goto LAB_180b26e57;
              lVar6 = WorldData.Player(*(int64 *)(lVar6 + 32),0);
              if (lVar6 == null) goto LAB_180b26e57;
              HeroData.GetItem(lVar6,*(uint64 *)(lVar1 + 96),1,0,CONCAT44(uVar14,0xffffffff),
                                in_stack_ffffffffffffff70 & 0xffffff00,0);
            }
            if (*(int64 *)(lVar1 + 88) == 0) goto LAB_180b26e57;
            FUN_18182b220(*(int64 *)(lVar1 + 88),0,DAT_181d695f0);
            if (*(int64 *)(lVar1 + 24) == 0) goto LAB_180b26e57;
            lVar6 = GameObject.get_transform(*(int64 *)(lVar1 + 24),0);
            if (lVar6 == null) goto LAB_180b26e57;
            lVar6 = Transform.Find(lVar6,"AuctionItemNow",0);
            if (lVar6 == null) goto LAB_180b26e57;
            uVar7 = Transform.GetChild(lVar6,0,0);
            if (*(int64 *)(lVar1 + 24) == 0) goto LAB_180b26e57;
            lVar6 = GameObject.get_transform(*(int64 *)(lVar1 + 24),0);
            if (lVar6 == null) goto LAB_180b26e57;
            lVar6 = Transform.Find(lVar6,"AuctionItemNow",0);
            if (lVar6 == null) goto LAB_180b26e57;
            puVar8 = (uint64 *)Transform.get_position(local_58,lVar6,0);
            uVar9 = *puVar8;
            fVar13 = *(float *)(puVar8 + 1);
            puVar8 = (uint64 *)Vector3.get_one(local_48,0);
            local_60 = fVar13 + *(float *)(puVar8 + 1);
            local_68 = CONCAT44((float)((uint64)uVar9 >> 32) + (float)((uint64)*puVar8 >> 32),
                                (float)*puVar8 + (float)uVar9);
            local_50 = local_60;
            uVar9 = ShortcutExtensions.DOMove(uVar7,&local_68,0x3f19999a,0,0);
            uVar10 = il2cpp_internal(DAT_181d88bd8);
            uVar7 = DAT_181d5fad0;
          }
          else {
            lVar6 = *(int64 *)(lVar1 + 120);
            lVar2 = **(int64 **)(DAT_181d51180 + 184);
            if (*(int64 *)(lVar1 + 112) == 0) goto LAB_180b26e57;
            uVar4 = FUN_1817ff280(*(int64 *)(lVar1 + 112),*(uint64 *)(lVar1 + 152),DAT_181d63ff8)
            ;
            if (lVar6 == null) goto LAB_180b26e57;
            if (*(uint32 *)(lVar6 + 24) <= uVar4) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            uVar7 = lVar6[uVar4];
            lVar6 = *(int64 *)(*(int64 *)(DAT_181d8a1a8 + 184) + 16);
            if (lVar6 == null) goto LAB_180b26e57;
            uVar4 = FUN_180d8cf10(0,*(uint32 *)(lVar6 + 24),0);
            if (*(uint32 *)(lVar6 + 24) <= uVar4) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            uVar9 = lVar6[uVar4];
            local_res8[0] = (int)*(float *)(lVar1 + 144);
            uVar10 = Int32.ToString(local_res8,0);
            lVar6 = *(int64 *)(lVar1 + 88);
            if (lVar6 == null) goto LAB_180b26e57;
            if (*(int *)(lVar6 + 24) == 0) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            lVar3 = *(int64 *)(*(int64 *)(lVar6 + 16) + 32);
            if (lVar3 == null) goto LAB_180b26e57;
            uVar11 = ItemData.Name(lVar3,CONCAT71((int7)((uint64)*(int64 *)(lVar6 + 16) >> 8),1),
                                    0);
            uVar9 = String.Format(uVar9,uVar10,uVar11,0);
            if (lVar2 == null) goto LAB_180b26e57;
            HeroLittleTalkController.HeroTalk
                      (lVar2,uVar7,uVar9,0x40400000,*(uint64 *)(lVar1 + 192),2,0);
            lVar6 = *(int64 *)(lVar1 + 88);
            lVar2 = *(int64 *)(lVar1 + 152);
            if (lVar6 == null) goto LAB_180b26e57;
            if (*(int *)(lVar6 + 24) == 0) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            if (lVar2 == null) goto LAB_180b26e57;
            HeroData.GetItem(lVar2,*(uint64 *)(*(int64 *)(lVar6 + 16) + 32),1,0);
            if (*(int64 *)(lVar1 + 152) == 0) goto LAB_180b26e57;
            HeroData.ChangeMoney(*(int64 *)(lVar1 + 152),-(int)*(float *)(lVar1 + 144),1,0);
            lVar6 = *(int64 *)(lVar1 + 88);
            if (lVar6 == null) goto LAB_180b26e57;
            if (*(int *)(lVar6 + 24) == 0) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            if (*(int64 *)(*(int64 *)(lVar6 + 16) + 32) == *(int64 *)(lVar1 + 96)) {
              lVar6 = FUN_18046c0a0(0);
              if ((lVar6 == null) || (*(int64 *)(lVar6 + 32) == 0)) goto LAB_180b26e57;
              lVar6 = WorldData.Player(*(int64 *)(lVar6 + 32),0);
              if (lVar6 == null) goto LAB_180b26e57;
              HeroData.ChangeMoney(lVar6,(int)((float)(int)*(float *)(lVar1 + 144) * 0.9),1,0);
            }
            if (*(int64 *)(lVar1 + 88) == 0) goto LAB_180b26e57;
            FUN_18182b220(*(int64 *)(lVar1 + 88),0,DAT_181d695f0);
            if (*(int64 *)(lVar1 + 24) == 0) goto LAB_180b26e57;
            lVar6 = GameObject.get_transform(*(int64 *)(lVar1 + 24),0);
            if (lVar6 == null) goto LAB_180b26e57;
            lVar6 = Transform.Find(lVar6,"AuctionItemNow",0);
            if (lVar6 == null) goto LAB_180b26e57;
            uVar7 = Transform.GetChild(lVar6,0,0);
            lVar6 = *(int64 *)(lVar1 + 120);
            if (*(int64 *)(lVar1 + 112) == 0) goto LAB_180b26e57;
            uVar4 = FUN_1817ff280(*(int64 *)(lVar1 + 112),*(uint64 *)(lVar1 + 152),DAT_181d63ff8)
            ;
            if (lVar6 == null) goto LAB_180b26e57;
            if (*(uint32 *)(lVar6 + 24) <= uVar4) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            lVar6 = lVar6[uVar4];
            if (lVar6 == null) goto LAB_180b26e57;
            lVar6 = GameObject.get_transform(lVar6,0);
            if (lVar6 == null) goto LAB_180b26e57;
            puVar8 = (uint64 *)Transform.get_position(local_48,lVar6,0);
            local_68 = *puVar8;
            local_60 = *(float *)(puVar8 + 1);
            uVar9 = ShortcutExtensions.DOMove(uVar7,&local_68,0x3f19999a,0,0);
            uVar10 = il2cpp_internal(DAT_181d88bd8);
            uVar7 = DAT_181d5fa50;
          }
          OnTooltipCB.ctor(uVar10,lVar1,uVar7,0);
          TweenSettingsExtensions.OnComplete(uVar9,uVar10,DAT_181d96ee8);
          if (*(char *)(lVar1 + 180) == false) {
            fVar13 = 1.0;
          }
          else {
            fVar13 = 0.5;
          }
          uVar7 = new WaitForSeconds(fVar13 + fVar13,0);
          this.<>2__current = uVar7;
          uVar7 = 1;
          this.<>1__state = 1;
        }
        else {
          if (this.<>1__state == 1) {
            this.<>1__state = 0xffffffff;
            if (lVar1 == null) {
        LAB_180b26e57:
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            AuctionController.SetOfferMoney(lVar1,0,0);
            AuctionController.SetOfferHero(lVar1,0,0);
            if (*(int64 *)(lVar1 + 88) == 0) goto LAB_180b26e57;
            if (*(int *)(*(int64 *)(lVar1 + 88) + 24) < 1) {
              *(uint32 *)(lVar1 + 72) = 5;
              AuctionController.EndAuction();
            }
            else {
              AuctionController.StartAuctionRoundPlot(lVar1,0);
            }
          }
          uVar7 = 0;
        }
        return uVar7;
    }

    // Token : 0x6000AB4
    // RVA   : 0x20F140   Offset: 0x20D940   Length: 0x5
    private virtual object System.Collections.Generic.IEnumerator<System.object>.get_Current()
    {
        return this.<>2__current;
    }

    // Token : 0x6000AB5
    // RVA   : 0xB26E60   Offset: 0xB25660   Length: 0x3E
    private virtual void System.Collections.IEnumerator.Reset()
    {
        ulong uVar1;
        ulong uVar2;
        uVar1 = il2cpp_runtime_class_init(&DAT_181d682e8);
        uVar1 = il2cpp_internal(uVar1);
        NotSupportedException.ctor(uVar1,0);
        uVar2 = il2cpp_runtime_class_init(&DAT_181d6e198);
    }

    // Token : 0x6000AB6
    // RVA   : 0x20F140   Offset: 0x20D940   Length: 0x5
    private virtual object System.Collections.IEnumerator.get_Current()
    {
        return this.<>2__current;
    }

}
