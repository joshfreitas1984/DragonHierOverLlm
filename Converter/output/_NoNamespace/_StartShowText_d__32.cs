// ============================================================
// Type  : <StartShowText>d__32
// Token : 0x2000333
// ============================================================

public class <StartShowText>d__32
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x40019F0
    private int <>1__state;

    // Token: 0x40019F1
    private object <>2__current;

    // Token: 0x40019F2
    public ReadBookController <>4__this;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6001FFA
    // RVA   : 0x219070   Offset: 0x217870   Length: 0x24
    public void /*ctor*/(int <>1__state)
    {
        ZhSegment.Initialize(this,0);
        this.<>1__state = <>1__state;
    }

    // Token : 0x6001FFB
    // RVA   : 0x245810   Offset: 0x244010   Length: 0x3
    private virtual void System.IDisposable.Dispose()
    {
    }

    // Token : 0x6001FFC
    // RVA   : 0x8D1FA0   Offset: 0x8D07A0   Length: 0x611
    private virtual bool MoveNext()
    {
        var pStatics = *(int64*)(DAT_181d88ad8 + 184);
        int iVar1;
        int iVar2;
        ulong uVar3;
        long lVar4;
        long lVar6;
        long lVar7;
        long lVar8;
        float fVar9;
        ulong local_48;
        uint local_40;
        byte[] local_38 = new byte[48];
        lVar6 = this.<>4__this;
        if (this.<>1__state == 0) {
          this.<>1__state = 0xffffffff;
          uVar3 = new WaitForSecondsRealtime(0x3fc00000,0);
          this.<>2__current = uVar3;
          this.<>1__state = 1;
          return true;
        }
        if (this.<>1__state != 1) {
          return false;
        }
        this.<>1__state = 0xffffffff;
        if (lVar6 == null) throw; // [null/range check failed]
        iVar1 = FUN_180d8cf10(0,(int)((float)*(int *)(lVar6 + 112) * 0.5),0);
        lVar7 = (int64)iVar1;
        iVar2 = FUN_180d8cf10(0,(int)((float)*(int *)(lVar6 + 116) * 0.5),0);
        lVar8 = (int64)iVar2;
        fVar9 = (float)Random.get_value(0);
        lVar4 = *(int64 *)(lVar6 + 72);
        if (fVar9 <= 0.2) {
          if (lVar4 == null) throw; // [null/range check failed]
          lVar4 = FUN_180127f50(lVar4,lVar7,(int64)(int)((float)*(int *)(lVar6 + 116) * 0.5));
          if (lVar4 == null) throw; // [null/range check failed]
          lVar4 = GameObject.GetComponent(lVar4,DAT_181da0a88);
          if (lVar4 == null) throw; // [null/range check failed]
          ReadBookTextController.SeeText(lVar4,0);
          if (*(int64 *)(lVar6 + 72) == 0) throw; // [null/range check failed]
          lVar4 = FUN_180127f50(*(int64 *)(lVar6 + 72),
                                (int64)((*(int *)(lVar6 + 112) - iVar1) + -1),
                                (int64)(int)((float)*(int *)(lVar6 + 116) * 0.5));
          if (lVar4 == null) throw; // [null/range check failed]
          lVar4 = GameObject.GetComponent(lVar4,DAT_181da0a88);
          if (lVar4 == null) throw; // [null/range check failed]
          ReadBookTextController.SeeText(lVar4,0);
          if (*(int64 *)(lVar6 + 72) == 0) throw; // [null/range check failed]
          lVar4 = FUN_180127f50(*(int64 *)(lVar6 + 72),
                                (int64)(int)((float)*(int *)(lVar6 + 112) * 0.5),lVar8);
          if (lVar4 == null) throw; // [null/range check failed]
          lVar4 = GameObject.GetComponent(lVar4,DAT_181da0a88);
          if (lVar4 == null) throw; // [null/range check failed]
          ReadBookTextController.SeeText(lVar4,0);
          lVar4 = *(int64 *)(lVar6 + 72);
          if (lVar4 == null) throw; // [null/range check failed]
          iVar2 = *(int *)(lVar6 + 116) - iVar2;
          iVar1 = (int)((float)*(int *)(lVar6 + 112) * 0.5);
        }
        else {
          if (lVar4 == null) throw; // [null/range check failed]
          lVar4 = FUN_180127f50(lVar4,lVar7,lVar8);
          if (lVar4 == null) throw; // [null/range check failed]
          lVar4 = GameObject.GetComponent(lVar4,DAT_181da0a88);
          if (lVar4 == null) throw; // [null/range check failed]
          ReadBookTextController.SeeText(lVar4,0);
          if (*(int64 *)(lVar6 + 72) == 0) throw; // [null/range check failed]
          lVar4 = FUN_180127f50(*(int64 *)(lVar6 + 72),lVar7,
                                (int64)((*(int *)(lVar6 + 116) - iVar2) + -1));
          if (lVar4 == null) throw; // [null/range check failed]
          lVar4 = GameObject.GetComponent(lVar4,DAT_181da0a88);
          if (lVar4 == null) throw; // [null/range check failed]
          ReadBookTextController.SeeText(lVar4,0);
          if (*(int64 *)(lVar6 + 72) == 0) throw; // [null/range check failed]
          lVar4 = FUN_180127f50(*(int64 *)(lVar6 + 72),
                                (int64)((*(int *)(lVar6 + 112) - iVar1) + -1),lVar8);
          if (lVar4 == null) throw; // [null/range check failed]
          lVar4 = GameObject.GetComponent(lVar4,DAT_181da0a88);
          if (lVar4 == null) throw; // [null/range check failed]
          ReadBookTextController.SeeText(lVar4,0);
          lVar4 = *(int64 *)(lVar6 + 72);
          if (lVar4 == null) throw; // [null/range check failed]
          iVar2 = *(int *)(lVar6 + 116) - iVar2;
          iVar1 = (*(int *)(lVar6 + 112) - iVar1) + -1;
        }
        lVar4 = FUN_180127f50(lVar4,(int64)iVar1,(int64)(iVar2 + -1));
        if (lVar4 != null) {
          lVar4 = GameObject.GetComponent(lVar4,DAT_181da0a88);
          if (lVar4 != null) {
            ReadBookTextController.SeeText(lVar4,0);
            if (*(int64 *)(lVar6 + 48) != 0) {
              lVar4 = GameObject.get_transform(*(int64 *)(lVar6 + 48),0);
              if (lVar4 != null) {
                uVar3 = Transform.Find(lVar4,"FinishReadButton",0);
                puVar5 = (uint64 *)Vector3.get_one(local_38,0);
                local_40 = *(uint32 *)(puVar5 + 1);
                local_48 = *puVar5;
                uVar3 = ShortcutExtensions.DOScale(uVar3,&local_48,0x3e4ccccd,0);
                TweenSettingsExtensions.SetUpdate(uVar3,1,DAT_181d98af0);
                if (*(int64 *)(lVar6 + 48) != 0) {
                  lVar4 = GameObject.get_transform(*(int64 *)(lVar6 + 48),0);
                  if (lVar4 != null) {
                    uVar3 = Transform.Find(lVar4,"TotalExp",0);
                    puVar5 = (uint64 *)Vector3.get_one(local_38,0);
                    local_40 = *(uint32 *)(puVar5 + 1);
                    local_48 = *puVar5;
                    uVar3 = ShortcutExtensions.DOScale(uVar3,&local_48,0x3e4ccccd,0);
                    TweenSettingsExtensions.SetUpdate(uVar3,1,DAT_181d98af0);
                    if (*(int64 *)(lVar6 + 48) != 0) {
                      lVar4 = GameObject.get_transform(*(int64 *)(lVar6 + 48),0);
                      if (lVar4 != null) {
                        uVar3 = Transform.Find(lVar4,"Patient",0);
                        puVar5 = (uint64 *)Vector3.get_one(local_38,0);
                        local_40 = *(uint32 *)(puVar5 + 1);
                        local_48 = *puVar5;
                        uVar3 = ShortcutExtensions.DOScale(uVar3,&local_48,0x3e4ccccd,0);
                        TweenSettingsExtensions.SetUpdate(uVar3,1,DAT_181d98af0);
                        if (*(int64 *)(lVar6 + 48) != 0) {
                          lVar6 = GameObject.get_transform(*(int64 *)(lVar6 + 48),0);
                          if (lVar6 != null) {
                            uVar3 = Transform.Find(lVar6,"Question",0);
                            puVar5 = (uint64 *)Vector3.get_one(local_38,0);
                            local_40 = *(uint32 *)(puVar5 + 1);
                            local_48 = *puVar5;
                            uVar3 = ShortcutExtensions.DOScale(uVar3,&local_48,0x3e4ccccd,0);
                            TweenSettingsExtensions.SetUpdate(uVar3,1,DAT_181d98af0);
                            if (*pStatics != 0) {
                              TutorialController.StartTutorial
                                        (*pStatics,"读书系统",0);
                              return false;
                            }
                          }
                        }
                      }
                    }
                  }
                }
              }
            }
          }
        }
    }

    // Token : 0x6001FFD
    // RVA   : 0x20F140   Offset: 0x20D940   Length: 0x5
    private virtual object System.Collections.Generic.IEnumerator<System.object>.get_Current()
    {
        return this.<>2__current;
    }

    // Token : 0x6001FFE
    // RVA   : 0x8D25C0   Offset: 0x8D0DC0   Length: 0x3E
    private virtual void System.Collections.IEnumerator.Reset()
    {
        ulong uVar1;
        ulong uVar2;
        uVar1 = il2cpp_runtime_class_init(&DAT_181d682e8);
        uVar1 = il2cpp_internal(uVar1);
        NotSupportedException.ctor(uVar1,0);
        uVar2 = il2cpp_runtime_class_init(&DAT_181d825a8);
    }

    // Token : 0x6001FFF
    // RVA   : 0x20F140   Offset: 0x20D940   Length: 0x5
    private virtual object System.Collections.IEnumerator.get_Current()
    {
        return this.<>2__current;
    }

}
