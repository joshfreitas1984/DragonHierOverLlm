// ============================================================
// Type  : ResourcePointData
// Token : 0x20001F5
// ============================================================

public class ResourcePointData
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4000DF4
    public int resourcePointID;

    // Token: 0x4000DF5
    public int resourcePointTypeID;

    // Token: 0x4000DF6
    public string resourcePointName;

    // Token: 0x4000DF7
    public string spriteName;

    // Token: 0x4000DF8
    public BigMapPos bigMapPos;

    // Token: 0x4000DF9
    public int belongForceID;

    // Token: 0x4000DFA
    public int connectAreaID;

    // Token: 0x4000DFB
    public List<float> changeResource;

    // Token: 0x4000DFC
    public ForceSpeAddData resourceSpeAddData;

    // Token: 0x4000DFD
    public bool thisMonthExplored;

    // Token: 0x4000DFE
    public bool resourcePointDetailDirty;

    // Token: 0x4000DFF
    public bool resourcePointIconDirty;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000F95
    // RVA   : 0xD17D40   Offset: 0xD17140   Length: 0x137
    public void /*ctor*/()
    {
        ulong uVar1;
        long lVar2;
        this.connectAreaID = 0xffffffff;
        ZhSegment.Initialize(this,0);
        this.bigMapPos = new c.DisplayClass9_0(0);
        lVar2 = il2cpp_internal(DAT_181d96ee8);
        FUN_181330100(lVar2,DAT_181da0d10);
        if (lVar2 != null) {
          FUN_18181e420(lVar2,0,DAT_181da0e10);
          FUN_18181e420(lVar2,0,DAT_181da0e10);
          FUN_18181e420(lVar2,0,DAT_181da0e10);
          FUN_18181e420(lVar2,0,DAT_181da0e10);
          FUN_18181e420(lVar2,0,DAT_181da0e10);
          FUN_18181e420(lVar2,0,DAT_181da0e10);
          this.changeResource = lVar2;
          return;
        }
    }

    // Token : 0x6000F96
    // RVA   : 0xD17CE0   Offset: 0xD170E0   Length: 0x8
    public bool HaveForce()
    {
        return this.belongForceID != -1;
    }

    // Token : 0x6000F97
    // RVA   : 0xD17B00   Offset: 0xD16F00   Length: 0xDC
    public string GetResourcePointFullName()
    {
        long lVar1;
        ulong uVar2;
        if ((GameController._instance != null) &&
           (lVar1 = GameController._instance.worldData) != null) {
          lVar1 = WorldData.GetArea(lVar1,this.connectAreaID,0);
          if (lVar1 != null) {
            uVar2 = AreaData.GetAreaName(lVar1,0);
            String.Concat(uVar2,this.resourcePointName,0);
            return;
          }
        }
    }

    // Token : 0x6000F98
    // RVA   : 0xD17680   Offset: 0xD16A80   Length: 0xD2
    public ResourcePointTypeData DataBase()
    {
        long lVar1;
        lVar1 = *(int64 *)(*(int64 *)(DAT_181d72d50 + 184) + 32);
        if ((lVar1 != null) && (lVar1 = *(int64 *)(lVar1 + 0x188)) != null) {
          FUN_1817da420(lVar1,this.resourcePointTypeID,DAT_181dbdac0);
          return;
        }
    }

    // Token : 0x6000F99
    // RVA   : 0xD17830   Offset: 0xD16C30   Length: 0x1E
    public HeroSpeAddData GetDefenceSpeAddData()
    {
        long lVar1;
        lVar1 = ResourcePointData.DataBase(this,0);
        if (lVar1 != null) {
          return *(uint64 *)(lVar1 + 48);
        }
    }

    // Token : 0x6000F9A
    // RVA   : 0xD17CF0   Offset: 0xD170F0   Length: 0x4E
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

    // Token : 0x6000F9B
    // RVA   : 0xD17BE0   Offset: 0xD16FE0   Length: 0xF8
    public List<float> GetTotalChangeResource()
    {
        ulong uVar1;
        long lVar2;
        float fVar3;
        float fVar4;
        fVar4 = 0.0;
        uVar1 = this.changeResource;
        if (this.belongForceID == -1) {
          fVar3 = 0.0;
        }
        else {
          lVar2 = ResourcePointData.GetForce(this,0);
          if (!((lVar2 == null) || (*(int64 *)(lVar2 + 0x148) == 0)))
          {
            fVar3 = (float)ForceSpeAddData.Get(*(int64 *)(lVar2 + 0x148),14);
            }
            if (this.connectAreaID != -1) {
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

    // Token : 0x6000F9C
    // RVA   : 0x21B670   Offset: 0x21AA70   Length: 0x5
    public ForceSpeAddData GetTotalResourceSpeAddData()
    {
        return this.resourceSpeAddData;
    }

    // Token : 0x6000F9D
    // RVA   : 0xD17A60   Offset: 0xD16E60   Length: 0x9C
    public float GetProduceRate()
    {
        long lVar1;
        float fVar2;
        float fVar3;
        fVar3 = 0.0;
        if (this.belongForceID == -1) {
          fVar2 = 0.0;
        }
        else {
          lVar1 = ResourcePointData.GetForce(this,0);
          if (!((lVar1 == null) || (*(int64 *)(lVar1 + 0x148) == 0)))
          {
            fVar2 = (float)ForceSpeAddData.Get(*(int64 *)(lVar1 + 0x148),14);
            }
            if (this.connectAreaID != -1) {
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

    // Token : 0x6000F9E
    // RVA   : 0xD17850   Offset: 0xD16C50   Length: 0x133
    public Color GetForceColor()
    {
        long lVar2;
        long lVar3;
        ulong uVar4;
        ulong local_28;
        ulong uStack_20;
        byte[] local_18 = new byte[16];
        local_28 = 0;
        uStack_20 = 0;
        if (*(int *)(param_2 + 48) == -1) {
          puVar1 = (uint64 *)FUN_180d995f0(local_18);
          uVar4 = puVar1[1];
          *this = *puVar1;
          this[1] = uVar4;
          return this;
        }
        lVar2 = ResourcePointData.GetForce(param_2,0);
        uVar4 = "#";
        if (lVar2 == null) throw; // [null/range check failed]
        if (*(int *)(lVar2 + 60) < 0) {
          lVar2 = ResourcePointData.GetForce(param_2,0);
        }
        else {
          lVar2 = FUN_18046c0a0(0);
          if (lVar2 == null) throw; // [null/range check failed]
          lVar2 = *(int64 *)(lVar2 + 32);
          lVar3 = ResourcePointData.GetForce(param_2,0);
          if ((lVar3 == null) || (lVar2 == null)) throw; // [null/range check failed]
          lVar2 = WorldData.GetForce(lVar2,*(uint32 *)(lVar3 + 60),0);
        }
        if (lVar2 != null) {
          uVar4 = String.Concat(uVar4,*(uint64 *)(lVar2 + 80),0);
          ColorUtility.TryParseHtmlString(uVar4,&local_28,0);
          *this = local_28;
          this[1] = uStack_20;
          return this;
        }
    }

    // Token : 0x6000F9F
    // RVA   : 0xD17990   Offset: 0xD16D90   Length: 0xCC
    public ForceData GetForce()
    {
        long lVar1;
        ulong uVar2;
        if (this.belongForceID == -1) {
          return 0;
        }
        if ((GameController._instance != null) &&
           (lVar1 = GameController._instance.worldData) != null) {
          uVar2 = WorldData.GetForce(lVar1,this.belongForceID,0);
          return uVar2;
        }
    }

    // Token : 0x6000FA0
    // RVA   : 0xD17760   Offset: 0xD16B60   Length: 0xCC
    public AreaData GetArea()
    {
        long lVar1;
        ulong uVar2;
        if (this.connectAreaID == -1) {
          return 0;
        }
        if ((GameController._instance != null) &&
           (lVar1 = GameController._instance.worldData) != null) {
          uVar2 = WorldData.GetArea(lVar1,this.connectAreaID,0);
          return uVar2;
        }
    }

    // Token : 0x6000FA1
    // RVA   : 0xD17500   Offset: 0xD16900   Length: 0x175
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
        plVar1 = (int64 *)il2cpp_internal(DAT_181d89228);
        plVar4 = plVar1;
        MemoryStream.ctor(plVar1,1000,0);
        local_38 = 0;
        uStack_30 = 0;
        StreamingContext.ctor(&local_38,64,0);
        lVar2 = il2cpp_internal(DAT_181db1748);
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
            FUN_180002970(0,DAT_181d78db8,plVar1);
            return uVar3;
          }
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
    }

}
