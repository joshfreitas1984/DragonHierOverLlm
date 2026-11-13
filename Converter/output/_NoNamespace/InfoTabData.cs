// ============================================================
// Type  : InfoTabData
// Token : 0x20001D1
// ============================================================

public class InfoTabData
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4000C7F
    public string infoText;

    // Token: 0x4000C80
    public string atlasName;

    // Token: 0x4000C81
    public string infoPic;

    // Token: 0x4000C82
    public Color picColor;

    // Token: 0x4000C83
    public string soundName;

    // Token: 0x4000C84
    public float volumn;

    // Token: 0x4000C85
    public float lastTime;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000EBC
    // RVA   : 0xA1AEA0   Offset: 0xA19CA0   Length: 0x15D
    public void /*ctor*/(string _infoText, string _atlasName, string _infoPic, string _soundName, float _volumn, float _lastTime, Color _picColor)
    {
                            uint64 _soundName,uint32 _volumn,uint32 _lastTime,uint32 *_picColor)
        {
        uint32 *puVar1;
        uint64 *puVar2;
        uint32 uVar3;
        uint32 uVar4;
        uint32 uVar5;
        uint64 uVar6;
        char cVar7;
        uint32 local_38;
        uint32 uStack_34;
        uint32 uStack_30;
        uint32 uStack_2c;
        uint32 local_28;
        uint32 uStack_24;
        uint32 uStack_20;
        uint32 uStack_1c;
        this.atlasName = "UIAtlas";
        this.soundName = "Woosh";
        this.volumn = 0x3f800000;
        this.lastTime = 0x40a00000;
        ZhSegment.Initialize(this,0);
        this.infoText = _infoText;
        this.atlasName = _atlasName;
        this.infoPic = _infoPic;
        this.soundName = _soundName;
        this.volumn = _volumn;
        this.lastTime = _lastTime;
        uVar3 = _picColor[1];
        uVar4 = _picColor[2];
        uVar5 = _picColor[3];
        this.picColor = *_picColor;
        *(uint32 *)(this + 44) = uVar3;
        *(uint32 *)(this + 48) = uVar4;
        *(uint32 *)(this + 52) = uVar5;
        if (_infoPic != null) {
          puVar1 = (uint32 *)FUN_180af4e90(&local_28,0);
          local_28 = *_picColor;
          uStack_24 = _picColor[1];
          uStack_20 = _picColor[2];
          uStack_1c = _picColor[3];
          local_38 = *puVar1;
          uStack_34 = puVar1[1];
          uStack_30 = puVar1[2];
          uStack_2c = puVar1[3];
          cVar7 = Color.op_Equality(&local_28,&local_38,0);
          if (cVar7) {
            puVar2 = (uint64 *)FUN_180f24d00(&local_28,0);
            uVar6 = puVar2[1];
            this.picColor = *puVar2;
            *(uint64 *)(this + 48) = uVar6;
          }
        }
    }

    // Token : 0x6000EBD
    // RVA   : 0xA1AD20   Offset: 0xA19B20   Length: 0x175
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
        plVar1 = (int64 *)il2cpp_internal(DAT_181e695f0);
        plVar4 = plVar1;
        MemoryStream.ctor(plVar1,1000,0);
        local_38 = 0;
        uStack_30 = 0;
        StreamingContext.ctor(&local_38,64,0);
        lVar2 = il2cpp_internal(DAT_181e91a00);
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
            FUN_180002280(0,DAT_181e58ab8,plVar1);
            return uVar3;
          }
                          // WARNING: Subroutine does not return
          FUN_1801e0300();
        }
    }

}
