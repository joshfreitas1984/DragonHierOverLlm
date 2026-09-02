// ============================================================
// Type  : InfoTabData
// Token : 0x20001C9
// ============================================================

public class InfoTabData
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4000BDF
    public string infoText;

    // Token: 0x4000BE0
    public string atlasName;

    // Token: 0x4000BE1
    public string infoPic;

    // Token: 0x4000BE2
    public Color picColor;

    // Token: 0x4000BE3
    public string soundName;

    // Token: 0x4000BE4
    public float volumn;

    // Token: 0x4000BE5
    public float lastTime;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000E81
    // RVA   : 0xB6EE30   Offset: 0xB6D630   Length: 0x15D
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
          puVar1 = (uint32 *)FUN_180d904c0(&local_28,0);
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
            puVar2 = (uint64 *)FUN_181098a50(&local_28,0);
            uVar6 = puVar2[1];
            this.picColor = *puVar2;
            *(uint64 *)(this + 48) = uVar6;
          }
        }
    }

    // Token : 0x6000E82
    // RVA   : 0xB6ECB0   Offset: 0xB6D4B0   Length: 0x175
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
