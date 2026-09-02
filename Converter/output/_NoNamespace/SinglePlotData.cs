// ============================================================
// Type  : SinglePlotData
// Token : 0x2000314
// ============================================================

public class SinglePlotData
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x400189B
    public string plotText;

    // Token: 0x400189C
    public HeroFaceHightLightType heroFaceHightLightType;

    // Token: 0x400189D
    public PlotTargetHeroType plotSource;

    // Token: 0x400189E
    public string sourceName;

    // Token: 0x400189F
    public PlotTargetHeroType plotTarget;

    // Token: 0x40018A0
    public string targetName;

    // Token: 0x40018A1
    public List<SinglePlotChoiceData> choices;

    // Token: 0x40018A2
    public string clickCallFuc;

    // Token: 0x40018A3
    public bool noAutoJump;

    // Token: 0x40018A4
    public string backPic;

    // Token: 0x40018A5
    public string backBgm;

    // Token: 0x40018A6
    public string soundEffect;

    // Token: 0x40018A7
    public bool plotShock;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6001959
    // RVA   : 0x970480   Offset: 0x96EC80   Length: 0xF8
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
              FUN_1800d6620();
            }
            FUN_181827900(lVar1,uVar3);
            lVar5 = lVar5 + 8;
          }
        }
    }

    // Token : 0x600195A
    // RVA   : 0x970580   Offset: 0x96ED80   Length: 0x84
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
        uVar1 = il2cpp_internal(DAT_181d72230);
        FUN_180f58a90(uVar1,DAT_181d797d8);
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

    // Token : 0x600195B
    // RVA   : 0x970960   Offset: 0x96F160   Length: 0xD4
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
        uVar1 = il2cpp_internal(DAT_181d72230);
        FUN_180f58a90(uVar1,DAT_181d797d8);
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

    // Token : 0x600195C
    // RVA   : 0x970770   Offset: 0x96EF70   Length: 0xD6
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
        uVar1 = il2cpp_internal(DAT_181d72230);
        FUN_180f58a90(uVar1,DAT_181d797d8);
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

    // Token : 0x600195D
    // RVA   : 0x970A40   Offset: 0x96F240   Length: 0xDF
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
        uVar1 = il2cpp_internal(DAT_181d72230);
        FUN_180f58a90(uVar1,DAT_181d797d8);
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

    // Token : 0x600195E
    // RVA   : 0x970B20   Offset: 0x96F320   Length: 0xDE
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
        uVar1 = il2cpp_internal(DAT_181d72230);
        FUN_180f58a90(uVar1,DAT_181d797d8);
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

    // Token : 0x600195F
    // RVA   : 0x970850   Offset: 0x96F050   Length: 0x10E
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
        uVar1 = il2cpp_internal(DAT_181d72230);
        FUN_180f58a90(uVar1,DAT_181d797d8);
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

    // Token : 0x6001960
    // RVA   : 0x970610   Offset: 0x96EE10   Length: 0x15E
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
        uVar1 = il2cpp_internal(DAT_181d72230);
        FUN_180f58a90(uVar1,DAT_181d797d8);
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

    // Token : 0x6001961
    // RVA   : 0x970300   Offset: 0x96EB00   Length: 0x175
    public virtual object Clone()
    {
        long lVar2;
        ulong uVar3;
        ulong local_38;
        ulong uStack_30;
        uint local_28;
        uint uStack_24;
        uint uStack_20;
        uint32 uStack_1c;
        plVar1 = (int64 *)il2cpp_internal(DAT_181d63ff0);
        plVar4 = plVar1;
        MemoryStream.ctor(plVar1,1000,0);
        local_38 = 0;
        uStack_30 = 0;
        StreamingContext.ctor(&local_38,64,0);
        lVar2 = il2cpp_internal(DAT_181d8c5a8);
        local_28 = (uint32)local_38;
        uStack_24 = local_38._4_4_;
        uStack_20 = (uint32)uStack_30;
        uStack_1c = uStack_30._4_4_;
        BinaryFormatter.ctor(lVar2,0,&local_28,0,plVar4);
        if (lVar2 != null) {
          BinaryFormatter.Serialize(lVar2,plVar1,this,0);
          if (plVar1 != (int64 *)0) {
            (**(code **)(*plVar1 + 0x2c8))(plVar1,0,0,*(uint64 *)(*plVar1 + 0x2d0));
            uVar3 = BinaryFormatter.Deserialize(lVar2,plVar1,0);
            (**(code **)(*plVar1 + 0x238))(plVar1,*(uint64 *)(*plVar1 + 0x240));
            FUN_180002970(0,DAT_181d53c70,plVar1);
            return uVar3;
          }
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
    }

}
