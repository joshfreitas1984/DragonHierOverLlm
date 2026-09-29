// ============================================================
// Type  : <StartAuctionRound>d__42
// Token : 0x200014D
// ============================================================

public class <StartAuctionRound>d__42
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4000867
    private int <>1__state;

    // Token: 0x4000868
    private object <>2__current;

    // Token: 0x4000869
    public AuctionController <>4__this;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000ACE
    // RVA   : 0x219070   Offset: 0x218470   Length: 0x24
    public void /*ctor*/(int <>1__state)
    {
        ZhSegment.Initialize(this,0);
        this.<>1__state = <>1__state;
    }

    // Token : 0x6000ACF
    // RVA   : 0x245810   Offset: 0x244C10   Length: 0x3
    private virtual void System.IDisposable.Dispose()
    {
    }

    // Token : 0x6000AD0
    // RVA   : 0x9C6820   Offset: 0x9C5C20   Length: 0x36E
    private virtual bool MoveNext()
    {
        long lVar1;
        long lVar2;
        long lVar3;
        long lVar4;
        ulong uVar5;
        ulong local_28;
        uint local_20;
        byte[] local_18 = new byte[16];
        lVar1 = this.<>4__this;
        if (this.<>1__state == 0) {
          this.<>1__state = 0xffffffff;
          if ((lVar1 != null) && (lVar2 = *(int64 *)(lVar1 + 104)) != null) {
            if (*(int *)(lVar2 + 24) == 0) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            lVar2 = *(int64 *)(*(int64 *)(lVar2 + 16) + 32);
            if ((((lVar2 != null) && (lVar2 = GameObject.get_transform(lVar2,0)) != null) &&
                (lVar2 = Transform.Find(lVar2,"ItemIconPos",0)) != null) &&
               ((lVar2 = Transform.GetChild(lVar2,0,0), lVar2 != null &&
                (lVar2 = Component.get_gameObject(lVar2,0)) != null))) {
              lVar3 = GameObject.get_transform(lVar2,0);
              if ((*(int64 *)(lVar1 + 24) != 0) &&
                 ((lVar4 = GameObject.get_transform(*(int64 *)(lVar1 + 24),0), lVar4 != null &&
                  (uVar5 = Transform.Find(lVar4,"AuctionItemNow",0), lVar3 != null)))) {
                FUN_180daae30(lVar3,uVar5,0);
                uVar5 = GameObject.get_transform(lVar2,0);
                puVar6 = (uint64 *)Vector3.get_zero(local_18,0);
                local_20 = *(uint32 *)(puVar6 + 1);
                local_28 = *puVar6;
                ShortcutExtensions.DOLocalMove(uVar5,&local_28,0x3f19999a,0,0);
                uVar5 = GameObject.get_transform(lVar2,0);
                puVar6 = (uint64 *)Vector3.get_one(local_18,0);
                local_20 = *(uint32 *)(puVar6 + 1);
                local_28 = *puVar6;
                ShortcutExtensions.DOScale(uVar5,&local_28,0x3f19999a,0);
                lVar2 = GameObject.GetComponent(lVar2,DAT_181d720a0);
                if ((lVar2 != null) && (*(int64 *)(lVar2 + 32) != 0)) {
                  ItemData.PlayItemSound(*(int64 *)(lVar2 + 32),0);
                  lVar2 = *(int64 *)(lVar1 + 104);
                  if (lVar2 != null) {
                    if (*(int *)(lVar2 + 24) == 0) {
                      ThrowHelper.ThrowArgumentOutOfRangeException(0);
                    }
                    uVar5 = *(uint64 *)(*(int64 *)(lVar2 + 16) + 32);
                    Object.Destroy(uVar5,0);
                    if (*(int64 *)(lVar1 + 104) != 0) {
                      FUN_181823ba0(*(int64 *)(lVar1 + 104),0,DAT_181d896b0);
                      lVar2 = *(int64 *)(lVar1 + 88);
                      if (lVar2 != null) {
                        if (*(int *)(lVar2 + 24) == 0) {
                          ThrowHelper.ThrowArgumentOutOfRangeException(0);
                        }
                        lVar2 = *(int64 *)(*(int64 *)(lVar2 + 16) + 32);
                        if (lVar2 != null) {
                          AuctionController.SetOfferMoney(lVar1,(float)*(int *)(lVar2 + 56) * 0.5,0);
                          uVar5 = new WaitForSeconds();
                          this.<>2__current = uVar5;
                          this.<>1__state = 1;
                          return true;
                        }
                      }
                    }
                  }
                }
              }
            }
          }
        }
        else {
          if (this.<>1__state != 1) {
            return false;
          }
          this.<>1__state = 0xffffffff;
          if ((lVar1 != null) && (*(int64 *)(lVar1 + 40) != 0)) {
            GameObject.SetActive(*(int64 *)(lVar1 + 40),1,0);
            if (*(int64 *)(lVar1 + 48) != 0) {
              GameObject.SetActive(*(int64 *)(lVar1 + 48),1,0);
              return false;
            }
          }
        }
    }

    // Token : 0x6000AD1
    // RVA   : 0x20F140   Offset: 0x20E540   Length: 0x5
    private virtual object System.Collections.Generic.IEnumerator<System.object>.get_Current()
    {
        return this.<>2__current;
    }

    // Token : 0x6000AD2
    // RVA   : 0x9C6B90   Offset: 0x9C5F90   Length: 0x3E
    private virtual void System.Collections.IEnumerator.Reset()
    {
        ulong uVar1;
        ulong uVar2;
        uVar1 = il2cpp_runtime_class_init(&DAT_181d8d528);
        uVar1 = il2cpp_internal(uVar1);
        NotSupportedException.ctor(uVar1,0);
        uVar2 = il2cpp_runtime_class_init(&DAT_181d97250);
    }

    // Token : 0x6000AD3
    // RVA   : 0x20F140   Offset: 0x20E540   Length: 0x5
    private virtual object System.Collections.IEnumerator.get_Current()
    {
        return this.<>2__current;
    }

}
