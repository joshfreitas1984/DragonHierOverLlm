// ============================================================
// Type  : TutorialPlotData
// Token : 0x20003A1
// ============================================================

public class TutorialPlotData
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001CB3
    public string tutorialText;

    // Token: 0x4001CB4
    public string tutorialPic;

    // Token: 0x4001CB5
    public GameObject highLightTarget;

    // Token: 0x4001CB6
    public bool useSpeHightLightPos;

    // Token: 0x4001CB7
    public Vector3 hightLightPos;

    // Token: 0x4001CB8
    public Vector3 hightLightSize;

    // Token: 0x4001CB9
    public bool needClickHighLightArea;

    // Token: 0x4001CBA
    public GameObject autoClickTarget;

    // Token: 0x4001CBB
    public string tutorialSpeFuc;

    // Token: 0x4001CBC
    public string tutorialEndSpeFuc;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6002299
    // RVA   : 0xA6E6B0   Offset: 0xA6CEB0   Length: 0x175
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

    // Token : 0x600229A
    // RVA   : 0x210B70   Offset: 0x20F370   Length: 0x7
    public void /*ctor*/()
    {
        ZhSegment.Initialize(this,0);
    }

}
