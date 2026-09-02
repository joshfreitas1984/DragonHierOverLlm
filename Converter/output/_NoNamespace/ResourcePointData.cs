// ============================================================
// Type  : ResourcePointData
// Token : 0x20001EF
// ============================================================

public class ResourcePointData
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4000D66
    public int resourcePointID;

    // Token: 0x4000D67
    public int resourcePointTypeID;

    // Token: 0x4000D68
    public string resourcePointName;

    // Token: 0x4000D69
    public string resourcePointFullName;

    // Token: 0x4000D6A
    public string spriteName;

    // Token: 0x4000D6B
    public BigMapPos bigMapPos;

    // Token: 0x4000D6C
    public int belongForceID;

    // Token: 0x4000D6D
    public int connectAreaID;

    // Token: 0x4000D6E
    public List<float> changeResource;

    // Token: 0x4000D6F
    public ForceSpeAddData resourceSpeAddData;

    // Token: 0x4000D70
    public bool thisMonthExplored;

    // Token: 0x4000D71
    public bool resourcePointDetailDirty;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000F60
    // RVA   : 0xC65E50   Offset: 0xC64650   Length: 0x137
    public void /*ctor*/()
    {
        ulong uVar1;
        long lVar2;
        this.connectAreaID = 0xffffffff;
        ZhSegment.Initialize(this,0);
        this.bigMapPos = new c.DisplayClass9_0(0);
        lVar2 = il2cpp_internal(DAT_181d721b0);
        FUN_180f58a90(lVar2,DAT_181d79358);
        if (lVar2 != null) {
          FUN_181805690(lVar2,0,DAT_181d79458);
          FUN_181805690(lVar2,0,DAT_181d79458);
          FUN_181805690(lVar2,0,DAT_181d79458);
          FUN_181805690(lVar2,0,DAT_181d79458);
          FUN_181805690(lVar2,0,DAT_181d79458);
          FUN_181805690(lVar2,0,DAT_181d79458);
          this.changeResource = lVar2;
          return;
        }
    }

    // Token : 0x6000F61
    // RVA   : 0xC65880   Offset: 0xC64080   Length: 0xD2
    public ResourcePointTypeData DataBase()
    {
        long lVar1;
        lVar1 = *(int64 *)(*(int64 *)(DAT_181d4e010 + 184) + 32);
        if ((lVar1 != null) && (lVar1 = *(int64 *)(lVar1 + 0x188)) != null) {
          FUN_1817cc780(lVar1,this.resourcePointTypeID,DAT_181d98100);
          return;
        }
    }

    // Token : 0x6000F62
    // RVA   : 0xC65A30   Offset: 0xC64230   Length: 0x1E
    public HeroSpeAddData GetDefenceSpeAddData()
    {
        long lVar1;
        lVar1 = ResourcePointData.DataBase(this,0);
        if (lVar1 != null) {
          return *(uint64 *)(lVar1 + 48);
        }
    }

    // Token : 0x6000F63
    // RVA   : 0xC65E00   Offset: 0xC64600   Length: 0x4E
    public void RefreshData()
    {
        long lVar1;
        lVar1 = ResourcePointData.DataBase(this,0);
        if (lVar1 != null) {
          this.changeResource = *(uint64 *)(lVar1 + 32);
          lVar1 = ResourcePointData.DataBase(this,0);
          if (lVar1 != null) {
            this.resourceSpeAddData = *(uint64 *)(lVar1 + 40);
            return;
          }
        }
    }

    // Token : 0x6000F64
    // RVA   : 0xC65D00   Offset: 0xC64500   Length: 0xF8
    public List<float> GetTotalChangeResource()
    {
        ulong uVar1;
        long lVar2;
        float fVar3;
        float fVar4;
        fVar4 = 0.0;
        uVar1 = this.changeResource;
        if (this.belongForceID < 0) {
          fVar3 = 0.0;
        }
        else {
          lVar2 = ResourcePointData.GetForce(this,0);
          if (!((lVar2 == null) || (*(int64 *)(lVar2 + 0x148) == 0)))
          {
            fVar3 = (float)ForceSpeAddData.Get(*(int64 *)(lVar2 + 0x148),14);
            }
            if (-1 < this.connectAreaID) {
            lVar2 = ResourcePointData.GetArea(this,0);
            if ((lVar2 == null) || (*(int64 *)(lVar2 + 176) == 0)) {
          }
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          fVar4 = (float)ForceSpeAddData.Get(*(int64 *)(lVar2 + 176),15);
        }
        GlobalData.ListMulti(uVar1,fVar3 + 1.0 + fVar4,0);
    }

    // Token : 0x6000F65
    // RVA   : 0x20F150   Offset: 0x20D950   Length: 0x5
    public ForceSpeAddData GetTotalResourceSpeAddData()
    {
        return this.resourceSpeAddData;
    }

    // Token : 0x6000F66
    // RVA   : 0xC65C60   Offset: 0xC64460   Length: 0x9C
    public float GetProduceRate()
    {
        long lVar1;
        float fVar2;
        float fVar3;
        fVar3 = 0.0;
        if (this.belongForceID < 0) {
          fVar2 = 0.0;
        }
        else {
          lVar1 = ResourcePointData.GetForce(this,0);
          if (!((lVar1 == null) || (*(int64 *)(lVar1 + 0x148) == 0)))
          {
            fVar2 = (float)ForceSpeAddData.Get(*(int64 *)(lVar1 + 0x148),14);
            }
            if (-1 < this.connectAreaID) {
            lVar1 = ResourcePointData.GetArea(this,0);
            if ((lVar1 == null) || (*(int64 *)(lVar1 + 176) == 0)) {
          }
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          fVar3 = (float)ForceSpeAddData.Get(*(int64 *)(lVar1 + 176),15);
        }
        return fVar2 + 1.0 + fVar3;
    }

    // Token : 0x6000F67
    // RVA   : 0xC65A50   Offset: 0xC64250   Length: 0x13E
    public Color GetForceColor()
    {
        long lVar1;
        long lVar2;
        ulong uVar3;
        ulong local_28;
        ulong uStack_20;
        byte[] local_18 = new byte[16];
        local_28 = 0;
        uStack_20 = 0;
        if (*(int *)(param_2 + 56) < 0) {
          puVar4 = (uint64 *)FUN_180d904c0(local_18);
          uVar3 = puVar4[1];
          *this = *puVar4;
          this[1] = uVar3;
          return this;
        }
        lVar1 = ResourcePointData.GetForce(param_2);
        uVar3 = "#";
        if (lVar1 == null) throw; // [null/range check failed]
        if (*(int *)(lVar1 + 60) < 0) {
          lVar1 = ResourcePointData.GetForce(param_2,0);
        }
        else {
          lVar1 = FUN_18046c0a0(0);
          if (lVar1 == null) throw; // [null/range check failed]
          lVar1 = *(int64 *)(lVar1 + 32);
          lVar2 = ResourcePointData.GetForce(param_2,0);
          if ((lVar2 == null) || (lVar1 == null)) throw; // [null/range check failed]
          lVar1 = WorldData.GetForce(lVar1,*(uint32 *)(lVar2 + 60),0);
        }
        if (lVar1 != null) {
          uVar3 = String.Concat(uVar3,*(uint64 *)(lVar1 + 80),0);
          ColorUtility.TryParseHtmlString(uVar3,&local_28,0);
          *this = local_28;
          this[1] = uStack_20;
          return this;
        }
    }

    // Token : 0x6000F68
    // RVA   : 0xC65B90   Offset: 0xC64390   Length: 0xCC
    public ForceData GetForce()
    {
        var pStatics = *(int64*)(DAT_181d4df90 + 184);
        long lVar1;
        ulong uVar2;
        if (this.belongForceID < 0) {
          return 0;
        }
        if ((*pStatics != 0) &&
           (lVar1 = *(int64 *)(*pStatics + 32)) != null) {
          uVar2 = WorldData.GetForce(lVar1,this.belongForceID,0);
          return uVar2;
        }
    }

    // Token : 0x6000F69
    // RVA   : 0xC65960   Offset: 0xC64160   Length: 0xCC
    public AreaData GetArea()
    {
        var pStatics = *(int64*)(DAT_181d4df90 + 184);
        long lVar1;
        ulong uVar2;
        if (this.connectAreaID < 0) {
          return 0;
        }
        if ((*pStatics != 0) &&
           (lVar1 = *(int64 *)(*pStatics + 32)) != null) {
          uVar2 = WorldData.GetArea(lVar1,this.connectAreaID,0);
          return uVar2;
        }
    }

    // Token : 0x6000F6A
    // RVA   : 0xC65700   Offset: 0xC63F00   Length: 0x175
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
