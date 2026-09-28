// ============================================================
// Type  : TutorialPlotData
// Token : 0x20003A8
// ============================================================

public class TutorialPlotData
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001DB8
    public string tutorialText;

    // Token: 0x4001DB9
    public string tutorialPic;

    // Token: 0x4001DBA
    public GameObject highLightTarget;

    // Token: 0x4001DBB
    public bool useSpeHightLightPos;

    // Token: 0x4001DBC
    public Vector3 hightLightPos;

    // Token: 0x4001DBD
    public Vector3 hightLightSize;

    // Token: 0x4001DBE
    public bool needClickHighLightArea;

    // Token: 0x4001DBF
    public GameObject autoClickTarget;

    // Token: 0x4001DC0
    public string tutorialSpeFuc;

    // Token: 0x4001DC1
    public string tutorialEndSpeFuc;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x600231B
    // RVA   : 0xAE83A0   Offset: 0xAE77A0   Length: 0x175
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
        plVar1 = (int64 *)il2cpp_internal(DAT_181d89210);
        plVar4 = plVar1;
        MemoryStream.ctor(plVar1,1000,0);
        local_38 = 0;
        uStack_30 = 0;
        StreamingContext.ctor(&local_38,64,0);
        lVar2 = il2cpp_internal(DAT_181db1730);
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
            FUN_180002970(0,DAT_181d78da0,plVar1);
            return uVar3;
          }
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
    }

    // Token : 0x600231C
    // RVA   : 0x210B70   Offset: 0x20FF70   Length: 0x7
    public void /*ctor*/()
    {
        ZhSegment.Initialize(this,0);
    }

}
