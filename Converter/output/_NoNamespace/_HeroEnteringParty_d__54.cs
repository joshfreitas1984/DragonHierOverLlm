// ============================================================
// Type  : <HeroEnteringParty>d__54
// Token : 0x2000315
// ============================================================

public class <HeroEnteringParty>d__54
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001971
    private int <>1__state;

    // Token: 0x4001972
    private object <>2__current;

    // Token: 0x4001973
    public PartyController <>4__this;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60019A0
    // RVA   : 0x219070   Offset: 0x218470   Length: 0x24
    public void /*ctor*/(int <>1__state)
    {
        ZhSegment.Initialize(this,0);
        this.<>1__state = <>1__state;
    }

    // Token : 0x60019A1
    // RVA   : 0x245810   Offset: 0x244C10   Length: 0x3
    private virtual void System.IDisposable.Dispose()
    {
    }

    // Token : 0x60019A2
    // RVA   : 0x8ED8B0   Offset: 0x8ECCB0   Length: 0x186F
    private virtual bool MoveNext()
    {
        var plVar14 = *(int64*)(lVar14 + 184);
        var pStatics_0290 = *(int64*)(DAT_181d90290 + 184);
        var pStatics_2ee8 = *(int64*)(DAT_181d72ee8 + 184);
        int iVar2;
        uint uVar3;
        uint uVar4;
        long lVar5;
        ulong uVar6;
        long lVar7;
        ulong uVar8;
        ulong uVar9;
        ulong uVar10;
        long lVar13;
        long lVar14;
        ulong uVar15;
        float[] local_res8 = new float[2];
        uint[] local_res18 = new uint[4];
        ulong in_stack_ffffffffffffff38;
        ulong in_stack_ffffffffffffff40;
        ulong uVar16;
        ulong uVar17;
        uint uVar18;
        ulong in_stack_ffffffffffffff60;
        ulong local_68;
        uint local_60;
        uint local_58;
        uint uStack_54;
        uint uStack_50;
        uint32 uStack_4c;
        uVar18 = (uint32)((uint64)in_stack_ffffffffffffff40 >> 32);
        uVar3 = (uint32)((uint64)in_stack_ffffffffffffff38 >> 32);
        iVar2 = this.<>1__state;
        lVar14 = this.<>4__this;
        if (iVar2 == 0) {
          this.<>1__state = 0xffffffff;
        LAB_1808ee65f:
          if (lVar14 == null) goto LAB_1808ef11a;
        LAB_1808ee668:
          if ((*(int64 *)(lVar14 + 192) == 0) || (plVar14 == 0))
          goto LAB_1808ef11a;
          if (*(int *)(*(int64 *)(lVar14 + 192) + 24) <
              *(int *)(plVar14 + 24)) {
            uVar6 = new WaitForSeconds();
            this.<>2__current = uVar6;
            this.<>1__state = 1;
            goto LAB_1808ee328;
          }
          lVar5 = new PlotData(0);
          iVar2 = *(int *)(lVar14 + 24);
          if (iVar2 == 0) {
            if (lVar5 == null) goto LAB_1808ef11a;
            lVar7 = *(int64 *)(lVar5 + 64);
            if (*(int64 *)(lVar14 + 168) == 0) goto LAB_1808ef11a;
            uVar6 = Int32.ToString(*(int64 *)(lVar14 + 168) + 88,0);
            uVar8 = il2cpp_internal(DAT_181da24d8);
            uVar9 = CONCAT44(uVar18,3);
            SinglePlotData.ctor(uVar8,"看来人已到齐...\n感谢各位同道看在我#$SourceInteractName#三分薄面上赏光莅临，\n有失远迎，还请见谅！",0,1,0,uVar9,uVar6,1,0,0);
            uVar3 = (uint32)((uint64)uVar9 >> 32);
            if (lVar7 == null) goto LAB_1808ef11a;
            FUN_18181e0a0(lVar7,uVar8,DAT_181da13f0);
            lVar7 = *(int64 *)(lVar5 + 64);
            if (*(int64 *)(lVar14 + 168) == 0) goto LAB_1808ef11a;
            uVar8 = Int32.ToString(*(int64 *)(lVar14 + 168) + 88,0);
            uVar9 = il2cpp_internal(DAT_181da24d8);
            uVar6 = "大家皆是武林同道，今日难得共聚一堂，把酒言欢，也算是缘分一场。\n还望各位暂且抛却嫌隙，共叙同道情谊！";
        LAB_1808eef46:
            uVar15 = 1;
            uVar18 = 1;
            uVar10 = 0;
        LAB_1808eef70:
            uVar17 = CONCAT44(uVar3,3);
            SinglePlotData.ctor(uVar9,uVar6,0,uVar15,uVar10,uVar17,uVar8,uVar18,0,0);
            uVar18 = (uint32)((uint64)uVar17 >> 32);
            if (lVar7 == null) goto LAB_1808ef11a;
            FUN_18181e0a0(lVar7,uVar9,DAT_181da13f0);
          }
          else {
            if (iVar2 == 1) {
              if (lVar5 == null) goto LAB_1808ef11a;
              lVar7 = *(int64 *)(lVar5 + 64);
              if (*(int64 *)(lVar14 + 168) == 0) goto LAB_1808ef11a;
              uVar6 = Int32.ToString(*(int64 *)(lVar14 + 168) + 88,0);
              uVar8 = il2cpp_internal(DAT_181da24d8);
              uVar9 = CONCAT44(uVar18,3);
              SinglePlotData.ctor(uVar8,"看来人已到齐...\n各位同门，我作为#SourceForceDescribe#，今日在此置办宴席不为别事，\n只为感谢各位历来尽心竭力，为我#SourceForceName#所立之功劳！",0,1,0,uVar9,uVar6,1,0,0);
              uVar3 = (uint32)((uint64)uVar9 >> 32);
              if (lVar7 == null) goto LAB_1808ef11a;
              FUN_18181e0a0(lVar7,uVar8,DAT_181da13f0);
              lVar7 = *(int64 *)(lVar5 + 64);
              if (*(int64 *)(lVar14 + 168) == 0) goto LAB_1808ef11a;
              uVar8 = Int32.ToString(*(int64 *)(lVar14 + 168) + 88,0);
              uVar9 = il2cpp_internal(DAT_181da24d8);
              uVar6 = "大家虽皆#SourceForceName#子弟，平日忙碌奔波，聚少离多。\n今日能济济一堂，把酒言欢，也算颇为难得。\n还望各位开怀畅饮，大快朵颐，共叙同门情谊！";
              goto LAB_1808eef46;
            }
            if (iVar2 == 2) {
              if (lVar5 == null) goto LAB_1808ef11a;
              lVar7 = *(int64 *)(lVar5 + 64);
              if (*(int64 *)(lVar14 + 176) == 0) goto LAB_1808ef11a;
              uVar6 = Int32.ToString(*(int64 *)(lVar14 + 176) + 88,0);
              if (*(int64 *)(lVar14 + 168) == 0) goto LAB_1808ef11a;
              uVar8 = Int32.ToString(*(int64 *)(lVar14 + 168) + 88,0);
              uVar9 = il2cpp_internal(DAT_181da24d8);
              uVar10 = CONCAT44(uVar18,3);
              SinglePlotData.ctor
                        (uVar9,"看来人已到齐...\n感谢各位赏光莅临我#$SourceInteractName#与#$TargetInteractName#的结婚典仪，\n有失远迎，还请见谅！",0,3,uVar6,uVar10,uVar8,1,0,
                         in_stack_ffffffffffffff60 & 0xffffffffffffff00,"PlotImage/洞房花烛",0,0,0,0);
              uVar3 = (uint32)((uint64)uVar10 >> 32);
              if (lVar7 == null) goto LAB_1808ef11a;
              FUN_18181e0a0(lVar7,uVar9,DAT_181da13f0);
              lVar7 = *(int64 *)(lVar5 + 64);
              if (*(int64 *)(lVar14 + 176) == 0) goto LAB_1808ef11a;
              uVar6 = Int32.ToString(*(int64 *)(lVar14 + 176) + 88,0);
              if (*(int64 *)(lVar14 + 168) == 0) goto LAB_1808ef11a;
              uVar8 = Int32.ToString(*(int64 *)(lVar14 + 168) + 88,0);
              uVar9 = il2cpp_internal(DAT_181da24d8);
              uVar10 = CONCAT44(uVar3,3);
              SinglePlotData.ctor(uVar9,"感谢各位亲朋好友，武林同道，\n今日我两在诸位见证之下拜堂成亲，正式结为夫妻，\n从此永结同心，白首不离！",0,3,uVar6,uVar10,uVar8,0,0,0);
              uVar3 = (uint32)((uint64)uVar10 >> 32);
              if (lVar7 == null) goto LAB_1808ef11a;
              FUN_18181e0a0(lVar7,uVar9,DAT_181da13f0);
              lVar7 = *(int64 *)(lVar5 + 64);
              if (*(int64 *)(lVar14 + 176) == 0) goto LAB_1808ef11a;
              uVar6 = Int32.ToString(*(int64 *)(lVar14 + 176) + 88,0);
              if (*(int64 *)(lVar14 + 168) == 0) goto LAB_1808ef11a;
              uVar8 = Int32.ToString(*(int64 *)(lVar14 + 168) + 88,0);
              uVar9 = il2cpp_internal(DAT_181da24d8);
              uVar10 = CONCAT44(uVar3,3);
              SinglePlotData.ctor(uVar9,"台下客人纷纷欢声喝彩，随后司仪登场，仪式准备开始。",0,3,uVar6,uVar10,uVar8,3,"人群欢呼",0);
              uVar3 = (uint32)((uint64)uVar10 >> 32);
              if (lVar7 == null) goto LAB_1808ef11a;
              FUN_18181e0a0(lVar7,uVar9,DAT_181da13f0);
              lVar7 = *(int64 *)(lVar5 + 64);
              if (*(int64 *)(lVar14 + 176) == 0) goto LAB_1808ef11a;
              uVar6 = Int32.ToString(*(int64 *)(lVar14 + 176) + 88,0);
              if (*(int64 *)(lVar14 + 168) == 0) goto LAB_1808ef11a;
              uVar8 = Int32.ToString(*(int64 *)(lVar14 + 168) + 88,0);
              uVar9 = il2cpp_internal(DAT_181da24d8);
              uVar10 = CONCAT44(uVar3,3);
              SinglePlotData.ctor(uVar9,"但见司仪朗声道：新郎搭躬。\n随后新郎躬身拱手，延请新娘。新娘款款上前，两人并肩伫立。",0,3,uVar6,uVar10,uVar8,3,0,0);
              uVar3 = (uint32)((uint64)uVar10 >> 32);
              if (lVar7 == null) goto LAB_1808ef11a;
              FUN_18181e0a0(lVar7,uVar9,DAT_181da13f0);
              lVar7 = *(int64 *)(lVar5 + 64);
              if (*(int64 *)(lVar14 + 176) == 0) goto LAB_1808ef11a;
              uVar6 = Int32.ToString(*(int64 *)(lVar14 + 176) + 88,0);
              if (*(int64 *)(lVar14 + 168) == 0) goto LAB_1808ef11a;
              uVar8 = Int32.ToString(*(int64 *)(lVar14 + 168) + 88,0);
              uVar9 = il2cpp_internal(DAT_181da24d8);
              uVar10 = CONCAT44(uVar3,3);
              SinglePlotData.ctor(uVar9,"司仪接着道：新郎新娘堂前就位。\n新郎新娘共同走上堂前，只见堂中设一张供桌，\n桌上上供奉着天地君亲师的牌位，后方则悬挂着祖宗神幔",0,3,uVar6,uVar10,uVar8,3,0,0);
              uVar3 = (uint32)((uint64)uVar10 >> 32);
              if (lVar7 == null) goto LAB_1808ef11a;
              FUN_18181e0a0(lVar7,uVar9,DAT_181da13f0);
              lVar7 = *(int64 *)(lVar5 + 64);
              if (*(int64 *)(lVar14 + 176) == 0) goto LAB_1808ef11a;
              uVar6 = Int32.ToString(*(int64 *)(lVar14 + 176) + 88,0);
              if (*(int64 *)(lVar14 + 168) == 0) goto LAB_1808ef11a;
              uVar8 = Int32.ToString(*(int64 *)(lVar14 + 168) + 88,0);
              uVar9 = il2cpp_internal(DAT_181da24d8);
              uVar10 = CONCAT44(uVar3,3);
              SinglePlotData.ctor(uVar9,"一拜天地！",0,3,uVar6,uVar10,uVar8,3,"NoticeImportant",0);
              uVar3 = (uint32)((uint64)uVar10 >> 32);
              if (lVar7 == null) goto LAB_1808ef11a;
              FUN_18181e0a0(lVar7,uVar9,DAT_181da13f0);
              lVar7 = *(int64 *)(lVar5 + 64);
              if (*(int64 *)(lVar14 + 176) == 0) goto LAB_1808ef11a;
              uVar6 = Int32.ToString(*(int64 *)(lVar14 + 176) + 88,0);
              if (*(int64 *)(lVar14 + 168) == 0) goto LAB_1808ef11a;
              uVar8 = Int32.ToString(*(int64 *)(lVar14 + 168) + 88,0);
              uVar9 = il2cpp_internal(DAT_181da24d8);
              uVar10 = CONCAT44(uVar3,3);
              SinglePlotData.ctor(uVar9,"二拜高堂！",0,3,uVar6,uVar10,uVar8,3,"NoticeImportant",0);
              uVar3 = (uint32)((uint64)uVar10 >> 32);
              if (lVar7 == null) goto LAB_1808ef11a;
              FUN_18181e0a0(lVar7,uVar9,DAT_181da13f0);
              lVar7 = *(int64 *)(lVar5 + 64);
              if (*(int64 *)(lVar14 + 176) == 0) goto LAB_1808ef11a;
              uVar6 = Int32.ToString(*(int64 *)(lVar14 + 176) + 88,0);
              if (*(int64 *)(lVar14 + 168) == 0) goto LAB_1808ef11a;
              uVar8 = Int32.ToString(*(int64 *)(lVar14 + 168) + 88,0);
              uVar9 = il2cpp_internal(DAT_181da24d8);
              uVar10 = CONCAT44(uVar3,3);
              SinglePlotData.ctor(uVar9,"夫妻对拜！",0,3,uVar6,uVar10,uVar8,3,"NoticeImportant",0);
              uVar3 = (uint32)((uint64)uVar10 >> 32);
              if (lVar7 == null) goto LAB_1808ef11a;
              FUN_18181e0a0(lVar7,uVar9,DAT_181da13f0);
              lVar7 = *(int64 *)(lVar5 + 64);
              if (*(int64 *)(lVar14 + 176) == 0) goto LAB_1808ef11a;
              uVar6 = Int32.ToString(*(int64 *)(lVar14 + 176) + 88,0);
              if (*(int64 *)(lVar14 + 168) == 0) goto LAB_1808ef11a;
              uVar8 = Int32.ToString(*(int64 *)(lVar14 + 168) + 88,0);
              uVar9 = il2cpp_internal(DAT_181da24d8);
              uVar10 = CONCAT44(uVar3,3);
              SinglePlotData.ctor(uVar9,"礼成！",0,3,uVar6,uVar10,uVar8,3,"人群欢呼",0);
              uVar3 = (uint32)((uint64)uVar10 >> 32);
              if (lVar7 == null) goto LAB_1808ef11a;
              FUN_18181e0a0(lVar7,uVar9,DAT_181da13f0);
              lVar7 = *(int64 *)(lVar5 + 64);
              if (*(int64 *)(lVar14 + 176) == 0) goto LAB_1808ef11a;
              uVar10 = Int32.ToString(*(int64 *)(lVar14 + 176) + 88,0);
              if (*(int64 *)(lVar14 + 168) == 0) goto LAB_1808ef11a;
              uVar8 = Int32.ToString(*(int64 *)(lVar14 + 168) + 88,0);
              uVar9 = il2cpp_internal(DAT_181da24d8);
              uVar15 = 3;
              uVar18 = 0;
              uVar6 = "有劳各位久等，仪式已毕，婚宴即刻开席，\n酒水虽薄，情谊颇厚，还请大家开怀畅饮，同享喜乐。";
              goto LAB_1808eef70;
            }
            if (lVar5 == null) goto LAB_1808ef11a;
          }
          lVar7 = *(int64 *)(lVar5 + 64);
          if (*(int64 *)(lVar14 + 168) == 0) {
        LAB_1808ef11a:
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          uVar6 = Int32.ToString(*(int64 *)(lVar14 + 168) + 88,0);
          uVar8 = il2cpp_internal(DAT_181da24d8);
          uVar9 = CONCAT44(uVar18,3);
          SinglePlotData.ctor(uVar8,"对酒当歌，人生几何，我#$SourceInteractName#先敬各位一杯，请了！",0,0,0,uVar9,uVar6,1,0,0);
          uVar3 = (uint32)((uint64)uVar9 >> 32);
          if (lVar7 == null) goto LAB_1808ef11a;
          FUN_18181e0a0(lVar7,uVar8,DAT_181da13f0);
          lVar7 = *(int64 *)(lVar5 + 64);
          lVar13 = il2cpp_internal(DAT_181d97750);
          FUN_18132faf0(lVar13,DAT_181da3bd8);
          if (lVar13 == null) goto LAB_1808ef11a;
          FUN_18181e0a0(lVar13,"开席入宴;PartyContinue",DAT_181da3d58);
          if (*(int64 *)(lVar14 + 168) == 0) goto LAB_1808ef11a;
          uVar6 = Int32.ToString(*(int64 *)(lVar14 + 168) + 88,0);
          uVar8 = new SinglePlotData("一时觥筹交错，人声鼎沸，好不热闹......",lVar13,0,0,CONCAT44(uVar3,3),uVar6,3,0,0);
          if (lVar7 == null) goto LAB_1808ef11a;
          FUN_18181e0a0(lVar7,uVar8,DAT_181da13f0);
          lVar14 = FUN_18046c400(0);
          if (lVar14 == null) goto LAB_1808ef11a;
          PlotController.AddPlot(lVar14,lVar5,0);
        LAB_1808ef113:
          uVar6 = 0;
        }
        else {
          if (iVar2 == 1) {
            this.<>1__state = 0xffffffff;
            lVar5 = FUN_18046c400(0);
            if (lVar5 == null) goto LAB_1808ef11a;
            if (*(char *)(lVar5 + 24) != false) goto LAB_1808ee65f;
            if (((lVar14 == null) || (*(int64 *)(lVar14 + 32) == 0)) ||
               (lVar5 = GameObject.get_transform(*(int64 *)(lVar14 + 32),0)) == null)
            goto LAB_1808ef11a;
            lVar5 = Transform.Find(lVar5,"HeroGrid",0);
            if (*(int64 *)(lVar14 + 192) == 0) goto LAB_1808ef11a;
            local_res18[0] = *(uint32 *)(*(int64 *)(lVar14 + 192) + 24);
            uVar6 = Int32.ToString(local_res18,0);
            if ((lVar5 == null) || (lVar5 = Transform.Find(lVar5,uVar6,0)) == null) goto LAB_1808ef11a;
            uVar6 = Component.get_gameObject(lVar5,0);
            if (*pStatics_2ee8 == 0) goto LAB_1808ef11a;
            uVar8 = *(uint64 *)(*pStatics_2ee8 + 144);
            lVar5 = GlobalData.AddChild(uVar6,uVar8,0);
            plVar1 = (int64 *)(lVar14 + 216);
            *plVar1 = lVar5;
            il2cpp_internal(plVar1,lVar5);
            if (*plVar1 == 0) goto LAB_1808ef11a;
            lVar5 = GameObject.GetComponent(*plVar1,DAT_181d71b50);
            if ((*(int64 *)(lVar14 + 192) == 0) || (lVar7 = plVar14) == null)
            goto LAB_1808ef11a;
            uVar4 = *(uint32 *)(*(int64 *)(lVar14 + 192) + 24);
            if (*(uint32 *)(lVar7 + 24) <= uVar4) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            if (lVar5 == null) goto LAB_1808ef11a;
            *(uint64 *)(lVar5 + 32) =
                 lVar7[uVar4];
            il2cpp_internal();
            if ((*plVar1 == 0) || (lVar5 = GameObject.GetComponent(*plVar1,DAT_181d71b50)) == null)
            goto LAB_1808ef11a;
            *(uint32 *)(lVar5 + 24) = 0;
            if ((*plVar1 == 0) || (lVar5 = GameObject.GetComponent(*plVar1,DAT_181d71b50)) == null)
            goto LAB_1808ef11a;
            *(uint8 *)(lVar5 + 88) = 1;
            if (*plVar1 == 0) goto LAB_1808ef11a;
            lVar5 = GameObject.get_transform(*plVar1,0);
            puVar11 = (uint64 *)Vector3.get_zero(&local_58,0);
            if (lVar5 == null) goto LAB_1808ef11a;
            local_60 = *(uint32 *)(puVar11 + 1);
            local_68 = *puVar11;
            Transform.set_localScale(lVar5,&local_68,0);
            if (*plVar1 == 0) goto LAB_1808ef11a;
            uVar6 = GameObject.get_transform(*plVar1,0);
            ShortcutExtensions.DOScale(uVar6);
            if (*(int64 *)(lVar14 + 192) == 0) goto LAB_1808ef11a;
            FUN_18181e0a0(*(int64 *)(lVar14 + 192),*plVar1,DAT_181d89398);
            uVar6 = new WaitForSeconds();
            this.<>2__current = uVar6;
            this.<>1__state = 2;
          }
          else {
            if (iVar2 != 2) {
              if (iVar2 == 3) {
                this.<>1__state = 0xffffffff;
                if (lVar14 == null) goto LAB_1808ef11a;
                if (*(int *)(lVar14 + 24) == 2) {
                  lVar5 = *(int64 *)(lVar14 + 192);
                  if ((lVar5 == null) || (lVar7 = plVar14) == null)
                  goto LAB_1808ef11a;
                  iVar2 = *(int *)(lVar5 + 24);
                  if (*(uint32 *)(lVar7 + 24) <= iVar2 - 1U) {
                    ThrowHelper.ThrowArgumentOutOfRangeException(0);
                    lVar5 = *(int64 *)(lVar14 + 192);
                  }
                  lVar7 = *(int64 *)(*(int64 *)(lVar7 + 16) + 24 + (int64)iVar2 * 8);
                  if ((lVar5 == null) || (lVar13 = plVar14) == null)
                  goto LAB_1808ef11a;
                  iVar2 = *(int *)(lVar5 + 24);
                  if (*(uint32 *)(lVar13 + 24) <= iVar2 - 1U) {
                    ThrowHelper.ThrowArgumentOutOfRangeException(0);
                  }
                  lVar5 = *(int64 *)(*(int64 *)(lVar13 + 16) + 24 + (int64)iVar2 * 8);
                  if ((lVar5 == null) || (lVar7 == null)) goto LAB_1808ef11a;
                  uVar16 = 0;
                  uVar6 = CONCAT44(uVar3,0xffffffff);
                  lVar5 = HeroData.FindRandomItem(lVar7,*(uint32 *)(lVar5 + 184),5,0,uVar6,0);
                  uVar3 = (uint32)((uint64)uVar6 >> 32);
                  if (lVar5 == null) {
                    lVar5 = FUN_18046c0a0(0);
                    if ((((*(int64 *)(lVar14 + 192) == 0) || (plVar14 == 0)) ||
                        (lVar7 = FUN_180002f80(plVar14,
                                               *(int *)(*(int64 *)(lVar14 + 192) + 24) + -1,
                                               DAT_181d8bb98), lVar7 == null)) || (lVar5 == null))
                    goto LAB_1808ef11a;
                    uVar16 = 0;
                    uVar3 = 0;
                    lVar5 = GameController.GenerateRandomItem
                                      (lVar5,(float)*(int *)(lVar7 + 184) * 1.8,0x3f000000,1,0,0);
                  }
                  else {
                    if (((*(int64 *)(lVar14 + 192) == 0) || (plVar14 == 0)) ||
                       (lVar7 = FUN_180002f80(plVar14,
                                              *(int *)(*(int64 *)(lVar14 + 192) + 24) + -1,
                                              DAT_181d8bb98), lVar7 == null)) goto LAB_1808ef11a;
                    HeroData.LoseItem(lVar7,lVar5,0,0);
                  }
                  if (*(int64 *)(lVar14 + 168) == 0) goto LAB_1808ef11a;
                  uVar16 = uVar16 & 0xffffffffffffff00;
                  HeroData.GetItem(*(int64 *)(lVar14 + 168),lVar5,1,0,CONCAT44(uVar3,0xffffffff),
                                    uVar16,0);
                  uVar18 = (uint32)(uVar16 >> 32);
                  lVar7 = FUN_18046c400(0);
                  if (lVar7 == null) goto LAB_1808ef11a;
                  PlotController.SetPlotItem(lVar7,lVar5,1,0);
                  lVar5 = *(int64 *)(pStatics_0290 + 16);
                  if (lVar5 == null) goto LAB_1808ef11a;
                  uVar4 = FUN_180d95a30(0,*(uint32 *)(lVar5 + 24),0);
                  if (*(uint32 *)(lVar5 + 24) <= uVar4) {
                    ThrowHelper.ThrowArgumentOutOfRangeException(0);
                  }
                  uVar6 = lVar5[uVar4];
                  lVar5 = FUN_18046c0a0(0);
                  if ((*(int64 *)(lVar14 + 192) == 0) ||
                     (lVar7 = plVar14) == null) goto LAB_1808ef11a;
                  iVar2 = *(int *)(*(int64 *)(lVar14 + 192) + 24);
                  if (*(uint32 *)(lVar7 + 24) <= iVar2 - 1U) {
                    ThrowHelper.ThrowArgumentOutOfRangeException(0);
                  }
                  lVar7 = *(int64 *)(*(int64 *)(lVar7 + 16) + 24 + (int64)iVar2 * 8);
                  if (((lVar7 == null) || (*(int64 *)(lVar14 + 176) == 0)) || (lVar5 == null))
                  goto LAB_1808ef11a;
                  uVar8 = GameController.GetHeroName
                                    (lVar5,*(uint32 *)(lVar7 + 88),
                                     *(uint32 *)(*(int64 *)(lVar14 + 176) + 88),0);
                  uVar6 = String.Format(uVar6,uVar8,0);
                }
                else {
                  if (*(int64 *)(lVar14 + 168) == 0) goto LAB_1808ef11a;
                  if (*(int *)(*(int64 *)(lVar14 + 168) + 88) == 0) {
                    if (((*(int64 *)(lVar14 + 192) == 0) || (plVar14 == 0)) ||
                       (lVar5 = FUN_180002f80(plVar14,
                                              *(int *)(*(int64 *)(lVar14 + 192) + 24) + -1,
                                              DAT_181d8bb98), lVar5 == null)) goto LAB_1808ef11a;
                    if (*(char *)(lVar5 + 0x120) == false) {
                      lVar5 = *(int64 *)(*(int64 *)(DAT_181d91b88 + 184) + 112);
                      if (lVar5 == null) goto LAB_1808ef11a;
                      uVar3 = FUN_180d95a30(0,*(uint32 *)(lVar5 + 24),0);
                      uVar6 = FUN_180002f80(lVar5,uVar3,DAT_181da4358);
                      goto LAB_1808edf8b;
                    }
                  }
                  lVar5 = *(int64 *)(pStatics_0290 + 8);
                  if (lVar5 == null) goto LAB_1808ef11a;
                  uVar4 = FUN_180d95a30(0,*(uint32 *)(lVar5 + 24),0);
                  if (*(uint32 *)(lVar5 + 24) <= uVar4) {
                    ThrowHelper.ThrowArgumentOutOfRangeException(0);
                  }
                  uVar6 = lVar5[uVar4];
                }
        LAB_1808edf8b:
                if ((*(char *)(lVar14 + 204) == false) || (*(int *)(lVar14 + 24) == 2)) {
                  lVar5 = FUN_18046c400(0);
                  if ((*(int64 *)(lVar14 + 192) == 0) ||
                     (lVar7 = plVar14) == null) goto LAB_1808ef11a;
                  iVar2 = *(int *)(*(int64 *)(lVar14 + 192) + 24);
                  if (*(uint32 *)(lVar7 + 24) <= iVar2 - 1U) {
                    ThrowHelper.ThrowArgumentOutOfRangeException(0);
                  }
                  lVar7 = *(int64 *)(*(int64 *)(lVar7 + 16) + 24 + (int64)iVar2 * 8);
                  if (lVar7 == null) goto LAB_1808ef11a;
                  uVar8 = Int32.ToString(lVar7 + 88,0);
                  if (*(int64 *)(lVar14 + 168) == 0) goto LAB_1808ef11a;
                  uVar9 = Int32.ToString(*(int64 *)(lVar14 + 168) + 88,0);
                  uVar10 = il2cpp_internal(DAT_181da24d8);
                  in_stack_ffffffffffffff60 = 0;
                  uVar15 = CONCAT44(uVar18,3);
                  SinglePlotData.ctor(uVar10,uVar6,0,3,uVar8,uVar15,uVar9,0,0,0);
                  uVar18 = (uint32)((uint64)uVar15 >> 32);
                  if (lVar5 == null) goto LAB_1808ef11a;
                  PlotController.ChangePlot(lVar5,uVar10,0);
                }
                goto LAB_1808ee668;
              }
              goto LAB_1808ef113;
            }
            this.<>1__state = 0xffffffff;
            if (((lVar14 == null) || (*(int64 *)(lVar14 + 192) == 0)) ||
               (lVar5 = plVar14) == null) goto LAB_1808ef11a;
            iVar2 = *(int *)(*(int64 *)(lVar14 + 192) + 24);
            if (*(uint32 *)(lVar5 + 24) <= iVar2 - 1U) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            lVar5 = *(int64 *)(*(int64 *)(lVar5 + 16) + 24 + (int64)iVar2 * 8);
            if (lVar5 == null) goto LAB_1808ef11a;
            local_res8[0] = *(float *)(lVar5 + 0x1c4) * 0.1;
            PartyController.ChangeBaseScore(lVar14,lVar5,0);
            lVar7 = FUN_18046c0a0(0);
            uVar6 = Single.ToString(local_res8,"+0;-0;0",0);
            uVar6 = String.Concat("宴会评分",uVar6,0);
            lVar5 = *(int64 *)(lVar14 + 192);
            if (lVar5 == null) goto LAB_1808ef11a;
            uVar4 = *(uint32 *)(lVar5 + 24);
            if (uVar4 <= uVar4 - 1) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            lVar5 = *(int64 *)(*(int64 *)(lVar5 + 16) + 24 + (int64)(int)uVar4 * 8);
            if ((lVar5 == null) || (lVar5 = GameObject.get_transform(lVar5,0)) == null)
            goto LAB_1808ef11a;
            puVar11 = (uint64 *)Transform.get_position(&local_68,lVar5,0);
            uVar8 = *puVar11;
            uVar3 = *(uint32 *)(puVar11 + 1);
            puVar12 = (uint32 *)Color.get_green(&local_58,0);
            if (lVar7 == null) goto LAB_1808ef11a;
            local_58 = *puVar12;
            uStack_54 = puVar12[1];
            uStack_50 = puVar12[2];
            uStack_4c = puVar12[3];
            local_68 = uVar8;
            local_60 = uVar3;
            GameController.ShowTextAtPos(lVar7,uVar6,&local_68,20,&local_58,0);
            lVar5 = *(int64 *)(lVar14 + 192);
            if ((lVar5 == null) || (lVar7 = plVar14) == null) goto LAB_1808ef11a;
            iVar2 = *(int *)(lVar5 + 24);
            if (*(uint32 *)(lVar7 + 24) <= iVar2 - 1U) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
              lVar5 = *(int64 *)(lVar14 + 192);
            }
            lVar7 = *(int64 *)(*(int64 *)(lVar7 + 16) + 24 + (int64)iVar2 * 8);
            if ((lVar5 == null) || (lVar14 = plVar14) == null) goto LAB_1808ef11a;
            iVar2 = *(int *)(lVar5 + 24);
            if (*(uint32 *)(lVar14 + 24) <= iVar2 - 1U) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            lVar14 = *(int64 *)(*(int64 *)(lVar14 + 16) + 24 + (int64)iVar2 * 8);
            if ((lVar14 == null) || (uVar6 = HeroData.GetHeroMeetSound(lVar14,"Greet",0), lVar7 == null))
            goto LAB_1808ef11a;
            HeroData.PlayHeroSound(lVar7,uVar6,0x3f333333,0xbf800000,0);
            uVar6 = new WaitForSeconds();
            this.<>2__current = uVar6;
            this.<>1__state = 3;
          }
        LAB_1808ee328:
          uVar6 = 1;
        }
        return uVar6;
    }

    // Token : 0x60019A3
    // RVA   : 0x20F140   Offset: 0x20E540   Length: 0x5
    private virtual object System.Collections.Generic.IEnumerator<System.object>.get_Current()
    {
        return this.<>2__current;
    }

    // Token : 0x60019A4
    // RVA   : 0x8EF120   Offset: 0x8EE520   Length: 0x3E
    private virtual void System.Collections.IEnumerator.Reset()
    {
        ulong uVar1;
        ulong uVar2;
        uVar1 = il2cpp_runtime_class_init(&DAT_181d8d510);
        uVar1 = il2cpp_internal(uVar1);
        NotSupportedException.ctor(uVar1,0);
        uVar2 = il2cpp_runtime_class_init(&DAT_181da99c8);
    }

    // Token : 0x60019A5
    // RVA   : 0x20F140   Offset: 0x20E540   Length: 0x5
    private virtual object System.Collections.IEnumerator.get_Current()
    {
        return this.<>2__current;
    }

}
