// ============================================================
// Type  : SinglePlotData
// Token : 0x2000325
// ============================================================

public class SinglePlotData
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001A06
    public string plotText;

    // Token: 0x4001A07
    public HeroFaceHightLightType heroFaceHightLightType;

    // Token: 0x4001A08
    public PlotTargetHeroType plotSource;

    // Token: 0x4001A09
    public string sourceName;

    // Token: 0x4001A0A
    public PlotTargetHeroType plotTarget;

    // Token: 0x4001A0B
    public string targetName;

    // Token: 0x4001A0C
    public List<SinglePlotChoiceData> choices;

    // Token: 0x4001A0D
    public string clickCallFuc;

    // Token: 0x4001A0E
    public bool noAutoJump;

    // Token: 0x4001A0F
    public string backPic;

    // Token: 0x4001A10
    public string backBgm;

    // Token: 0x4001A11
    public string soundEffect;

    // Token: 0x4001A12
    public bool plotShock;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6001A4E
    // RVA   : 0x6AB240   Offset: 0x6AA040   Length: 0xF8
    public void SetChoiceDataTexts(List<string> choiceDataTexts)
    {
        long lVar1;
        ulong uVar2;
        ulong uVar3;
        uint uVar4;
        long lVar5;
        if (choiceDataTexts != null) {
          lVar5 = 32;
          for (uVar4 = 0; (int)uVar4 < (int)*(uint32 *)(choiceDataTexts + 24); uVar4 = uVar4 + 1) {
            lVar1 = this.choices;
            if (*(uint32 *)(choiceDataTexts + 24) <= uVar4) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            uVar2 = *(uint64 *)(lVar5 + *(int64 *)(choiceDataTexts + 16));
            uVar3 = new SinglePlotChoiceData(uVar2,0);
            if (lVar1 == null) {
                          // WARNING: Subroutine does not return
              FUN_1801e0300();
            }
            FUN_18175de30(lVar1,uVar3);
            lVar5 = lVar5 + 8;
          }
        }
    }

    // Token : 0x6001A4F
    // RVA   : 0x6AB340   Offset: 0x6AA140   Length: 0x84
    public void /*ctor*/()
    {
        void SinglePlotData.ctor
                     (int64 this,uint64 param_2,uint64 param_3,uint32 param_4,
                     uint64 param_5,uint32 param_6,uint64 param_7,uint32 param_8,
                     uint64 param_9,uint8 param_10,uint64 param_11,uint64 param_12,
                     uint64 param_13,uint8 param_14)
        {
        uint64 uVar1;
        this.plotSource = 1;
        this.plotTarget = 1;
        uVar1 = il2cpp_internal(DAT_181e76f28);
        FUN_1810f3480(uVar1,DAT_181e83630);
        this.choices = uVar1;
        ZhSegment.Initialize(this,0);
        this.plotText = param_2;
        SinglePlotData.SetChoiceDataTexts(this,param_3,0);
        this.targetName = param_5;
        this.plotTarget = param_4;
        this.sourceName = param_7;
        this.plotSource = param_6;
        this.clickCallFuc = param_9;
        this.heroFaceHightLightType = param_8;
        this.noAutoJump = param_10;
        this.backPic = param_11;
        this.backBgm = param_12;
        this.soundEffect = param_13;
        this.plotShock = param_14;
    }

    // Token : 0x6001A50
    // RVA   : 0x6AB720   Offset: 0x6AA520   Length: 0xD4
    public void /*ctor*/(string targetPlotText, List<string> choiceDataTexts)
    {
        void SinglePlotData.ctor
                     (int64 this,uint64 targetPlotText,uint64 choiceDataTexts,uint32 param_4,
                     uint64 param_5,uint32 param_6,uint64 param_7,uint32 param_8,
                     uint64 param_9,uint8 param_10,uint64 param_11,uint64 param_12,
                     uint64 param_13,uint8 param_14)
        {
        uint64 uVar1;
        this.plotSource = 1;
        this.plotTarget = 1;
        uVar1 = il2cpp_internal(DAT_181e76f28);
        FUN_1810f3480(uVar1,DAT_181e83630);
        this.choices = uVar1;
        ZhSegment.Initialize(this,0);
        this.plotText = targetPlotText;
        SinglePlotData.SetChoiceDataTexts(this,choiceDataTexts,0);
        this.targetName = param_5;
        this.plotTarget = param_4;
        this.sourceName = param_7;
        this.plotSource = param_6;
        this.clickCallFuc = param_9;
        this.heroFaceHightLightType = param_8;
        this.noAutoJump = param_10;
        this.backPic = param_11;
        this.backBgm = param_12;
        this.soundEffect = param_13;
        this.plotShock = param_14;
    }

    // Token : 0x6001A51
    // RVA   : 0x6AB530   Offset: 0x6AA330   Length: 0xD6
    public void /*ctor*/(string targetPlotText, List<string> choiceDataTexts, HeroFaceHightLightType hightLightType)
    {
        void SinglePlotData.ctor
                     (int64 this,uint64 targetPlotText,uint64 choiceDataTexts,uint32 hightLightType,
                     uint64 param_5,uint32 param_6,uint64 param_7,uint32 param_8,
                     uint64 param_9,uint8 param_10,uint64 param_11,uint64 param_12,
                     uint64 param_13,uint8 param_14)
        {
        uint64 uVar1;
        this.plotSource = 1;
        this.plotTarget = 1;
        uVar1 = il2cpp_internal(DAT_181e76f28);
        FUN_1810f3480(uVar1,DAT_181e83630);
        this.choices = uVar1;
        ZhSegment.Initialize(this,0);
        this.plotText = targetPlotText;
        SinglePlotData.SetChoiceDataTexts(this,choiceDataTexts,0);
        this.targetName = param_5;
        this.plotTarget = hightLightType;
        this.sourceName = param_7;
        this.plotSource = param_6;
        this.clickCallFuc = param_9;
        this.heroFaceHightLightType = param_8;
        this.noAutoJump = param_10;
        this.backPic = param_11;
        this.backBgm = param_12;
        this.soundEffect = param_13;
        this.plotShock = param_14;
    }

    // Token : 0x6001A52
    // RVA   : 0x6AB800   Offset: 0x6AA600   Length: 0xDF
    public void /*ctor*/(string targetPlotText, List<string> choiceDataTexts, PlotTargetHeroType targetHeroType)
    {
        void SinglePlotData.ctor
                     (int64 this,uint64 targetPlotText,uint64 choiceDataTexts,uint32 targetHeroType,
                     uint64 param_5,uint32 param_6,uint64 param_7,uint32 param_8,
                     uint64 param_9,uint8 param_10,uint64 param_11,uint64 param_12,
                     uint64 param_13,uint8 param_14)
        {
        uint64 uVar1;
        this.plotSource = 1;
        this.plotTarget = 1;
        uVar1 = il2cpp_internal(DAT_181e76f28);
        FUN_1810f3480(uVar1,DAT_181e83630);
        this.choices = uVar1;
        ZhSegment.Initialize(this,0);
        this.plotText = targetPlotText;
        SinglePlotData.SetChoiceDataTexts(this,choiceDataTexts,0);
        this.targetName = param_5;
        this.plotTarget = targetHeroType;
        this.sourceName = param_7;
        this.plotSource = param_6;
        this.clickCallFuc = param_9;
        this.heroFaceHightLightType = param_8;
        this.noAutoJump = param_10;
        this.backPic = param_11;
        this.backBgm = param_12;
        this.soundEffect = param_13;
        this.plotShock = param_14;
    }

    // Token : 0x6001A53
    // RVA   : 0x6AB8E0   Offset: 0x6AA6E0   Length: 0xDE
    public void /*ctor*/(string targetPlotText, List<string> choiceDataTexts, PlotTargetHeroType targetHeroType, string targetHeroName)
    {
        void SinglePlotData.ctor
                     (int64 this,uint64 targetPlotText,uint64 choiceDataTexts,uint32 targetHeroType,
                     uint64 targetHeroName,uint32 param_6,uint64 param_7,uint32 param_8,
                     uint64 param_9,uint8 param_10,uint64 param_11,uint64 param_12,
                     uint64 param_13,uint8 param_14)
        {
        uint64 uVar1;
        this.plotSource = 1;
        this.plotTarget = 1;
        uVar1 = il2cpp_internal(DAT_181e76f28);
        FUN_1810f3480(uVar1,DAT_181e83630);
        this.choices = uVar1;
        ZhSegment.Initialize(this,0);
        this.plotText = targetPlotText;
        SinglePlotData.SetChoiceDataTexts(this,choiceDataTexts,0);
        this.targetName = targetHeroName;
        this.plotTarget = targetHeroType;
        this.sourceName = param_7;
        this.plotSource = param_6;
        this.clickCallFuc = param_9;
        this.heroFaceHightLightType = param_8;
        this.noAutoJump = param_10;
        this.backPic = param_11;
        this.backBgm = param_12;
        this.soundEffect = param_13;
        this.plotShock = param_14;
    }

    // Token : 0x6001A54
    // RVA   : 0x6AB610   Offset: 0x6AA410   Length: 0x10E
    public void /*ctor*/(string targetPlotText, List<string> choiceDataTexts, PlotTargetHeroType targetHeroType, string targetHeroName, PlotTargetHeroType sourceHeroType, string sourceHeroName, HeroFaceHightLightType hightLightType, string _soundEffect)
    {
        void SinglePlotData.ctor
                     (int64 this,uint64 targetPlotText,uint64 choiceDataTexts,uint32 targetHeroType,
                     uint64 targetHeroName,uint32 sourceHeroType,uint64 sourceHeroName,uint32 hightLightType,
                     uint64 _soundEffect,uint8 param_10,uint64 param_11,uint64 param_12,
                     uint64 param_13,uint8 param_14)
        {
        uint64 uVar1;
        this.plotSource = 1;
        this.plotTarget = 1;
        uVar1 = il2cpp_internal(DAT_181e76f28);
        FUN_1810f3480(uVar1,DAT_181e83630);
        this.choices = uVar1;
        ZhSegment.Initialize(this,0);
        this.plotText = targetPlotText;
        SinglePlotData.SetChoiceDataTexts(this,choiceDataTexts,0);
        this.targetName = targetHeroName;
        this.plotTarget = targetHeroType;
        this.sourceName = sourceHeroName;
        this.plotSource = sourceHeroType;
        this.clickCallFuc = _soundEffect;
        this.heroFaceHightLightType = hightLightType;
        this.noAutoJump = param_10;
        this.backPic = param_11;
        this.backBgm = param_12;
        this.soundEffect = param_13;
        this.plotShock = param_14;
    }

    // Token : 0x6001A55
    // RVA   : 0x6AB3D0   Offset: 0x6AA1D0   Length: 0x15E
    public void /*ctor*/(string targetPlotText, List<string> choiceDataTexts, PlotTargetHeroType targetHeroType, string targetHeroName, PlotTargetHeroType sourceHeroType, string sourceHeroName, HeroFaceHightLightType hightLightType, string _clickCallFuc, bool _noAutoJump, string _backPic, string _backBgm, string _soundEffect, bool _plotShock)
    {
        void SinglePlotData.ctor
                     (int64 this,uint64 targetPlotText,uint64 choiceDataTexts,uint32 targetHeroType,
                     uint64 targetHeroName,uint32 sourceHeroType,uint64 sourceHeroName,uint32 hightLightType,
                     uint64 _clickCallFuc,uint8 _noAutoJump,uint64 _backPic,uint64 _backBgm,
                     uint64 _soundEffect,uint8 _plotShock)
        {
        uint64 uVar1;
        this.plotSource = 1;
        this.plotTarget = 1;
        uVar1 = il2cpp_internal(DAT_181e76f28);
        FUN_1810f3480(uVar1,DAT_181e83630);
        this.choices = uVar1;
        ZhSegment.Initialize(this,0);
        this.plotText = targetPlotText;
        SinglePlotData.SetChoiceDataTexts(this,choiceDataTexts,0);
        this.targetName = targetHeroName;
        this.plotTarget = targetHeroType;
        this.sourceName = sourceHeroName;
        this.plotSource = sourceHeroType;
        this.clickCallFuc = _clickCallFuc;
        this.heroFaceHightLightType = hightLightType;
        this.noAutoJump = _noAutoJump;
        this.backPic = _backPic;
        this.backBgm = _backBgm;
        this.soundEffect = _soundEffect;
        this.plotShock = _plotShock;
    }

    // Token : 0x6001A56
    // RVA   : 0x6AAF30   Offset: 0x6A9D30   Length: 0x308
    public virtual object Clone()
    {
        uint uVar1;
        long lVar2;
        long lVar3;
        ulong uVar4;
        long lVar5;
        uint uVar8;
        long lVar9;
        lVar3 = il2cpp_internal(DAT_181e82930);
        *(uint32 *)(lVar3 + 28) = 1;
        *(uint32 *)(lVar3 + 40) = 1;
        uVar4 = il2cpp_internal(DAT_181e76f28);
        FUN_1810f3480(uVar4,DAT_181e83630);
        *(uint64 *)(lVar3 + 56) = uVar4;
        ZhSegment.Initialize(lVar3,0);
        *(uint64 *)(lVar3 + 16) = this.plotText;
        *(uint32 *)(lVar3 + 24) = this.heroFaceHightLightType;
        *(uint32 *)(lVar3 + 28) = this.plotSource;
        *(uint64 *)(lVar3 + 32) = this.sourceName;
        *(uint32 *)(lVar3 + 40) = this.plotTarget;
        *(uint64 *)(lVar3 + 48) = this.targetName;
        if (this.choices == null) {
          *(uint64 *)(lVar3 + 56) = 0;
        LAB_1806ab1b8:
          *(uint64 *)(lVar3 + 64) = this.clickCallFuc;
          *(uint8 *)(lVar3 + 72) = this.noAutoJump;
          *(uint64 *)(lVar3 + 80) = this.backPic;
          *(uint64 *)(lVar3 + 88) = this.backBgm;
          *(uint64 *)(lVar3 + 96) = this.soundEffect;
          *(uint8 *)(lVar3 + 104) = this.plotShock;
          return lVar3;
        }
        uVar1 = this.choices.Count;
        uVar4 = new List_1(uVar1,DAT_181e836b0);
        *(uint64 *)(lVar3 + 56) = uVar4;
        lVar5 = this.choices;
        uVar8 = 0;
        if (lVar5 != null) {
          lVar9 = 32;
          while( true ) {
            if (lVar5.Count <= (int)uVar8) goto LAB_1806ab1b8;
            lVar2 = *(int64 *)(lVar3 + 56);
            if (lVar5 == null) break;
            if (lVar5.Count <= uVar8) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            plVar7 = (int64 *)0;
            if (*(int64 *)(lVar9 + lVar5._items) != 0) {
              if ((this.choices == null) ||
                 (lVar5 = FUN_1800024b0(this.choices,uVar8,DAT_181e83830)) == null)
              break;
              plVar6 = (int64 *)SinglePlotChoiceData.Clone(lVar5,0);
              if (plVar6 != (int64 *)0) {
              }
            }
            if (lVar2 == null) break;
            FUN_18175de30(lVar2,plVar7,DAT_181e83730);
            lVar5 = this.choices;
            uVar8 = uVar8 + 1;
            lVar9 = lVar9 + 8;
            if (lVar5 == null) break;
          }
        }
    }

}
