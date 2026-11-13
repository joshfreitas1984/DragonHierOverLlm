// ============================================================
// Type  : ResourcePointData
// Token : 0x20001F7
// ============================================================

public class ResourcePointData
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4000E08
    public int resourcePointID;

    // Token: 0x4000E09
    public int resourcePointTypeID;

    // Token: 0x4000E0A
    public string resourcePointName;

    // Token: 0x4000E0B
    public string spriteName;

    // Token: 0x4000E0C
    public BigMapPos bigMapPos;

    // Token: 0x4000E0D
    public int belongForceID;

    // Token: 0x4000E0E
    public int connectAreaID;

    // Token: 0x4000E0F
    public List<float> changeResource;

    // Token: 0x4000E10
    public ForceSpeAddData resourceSpeAddData;

    // Token: 0x4000E11
    public bool thisMonthExplored;

    // Token: 0x4000E12
    public bool resourcePointDetailDirty;

    // Token: 0x4000E13
    public bool resourcePointIconDirty;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000F9E
    // RVA   : 0xA70890   Offset: 0xA6F690   Length: 0x137
    public void /*ctor*/()
    {
        ulong uVar1;
        long lVar2;
        this.connectAreaID = 0xffffffff;
        ZhSegment.Initialize(this,0);
        this.bigMapPos = new c.DisplayClass9_0(0);
        lVar2 = il2cpp_internal(DAT_181e76ea8);
        FUN_1810f3480(lVar2,DAT_181e83230);
        if (lVar2 != null) {
          FUN_18175dba0(lVar2,0,DAT_181e83330);
          FUN_18175dba0(lVar2,0,DAT_181e83330);
          FUN_18175dba0(lVar2,0,DAT_181e83330);
          FUN_18175dba0(lVar2,0,DAT_181e83330);
          FUN_18175dba0(lVar2,0,DAT_181e83330);
          FUN_18175dba0(lVar2,0,DAT_181e83330);
          this.changeResource = lVar2;
          return;
        }
    }

    // Token : 0x6000F9F
    // RVA   : 0xA70830   Offset: 0xA6F630   Length: 0x8
    public bool HaveForce()
    {
        return this.belongForceID != -1;
    }

    // Token : 0x6000FA0
    // RVA   : 0xA70650   Offset: 0xA6F450   Length: 0xDC
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

    // Token : 0x6000FA1
    // RVA   : 0xA701D0   Offset: 0xA6EFD0   Length: 0xD2
    public ResourcePointTypeData DataBase()
    {
        long lVar1;
        lVar1 = *(int64 *)(*(int64 *)(DAT_181e528f8 + 184) + 32);
        if ((lVar1 != null) && (lVar1 = *(int64 *)(lVar1 + 0x198)) != null) {
          FUN_18171b450(lVar1,this.resourcePointTypeID,DAT_181e9f1a8);
          return;
        }
    }

    // Token : 0x6000FA2
    // RVA   : 0xA70380   Offset: 0xA6F180   Length: 0x1E
    public HeroSpeAddData GetDefenceSpeAddData()
    {
        long lVar1;
        lVar1 = ResourcePointData.DataBase(this,0);
        if (lVar1 != null) {
          return *(uint64 *)(lVar1 + 48);
        }
    }

    // Token : 0x6000FA3
    // RVA   : 0xA70840   Offset: 0xA6F640   Length: 0x4E
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

    // Token : 0x6000FA4
    // RVA   : 0xA70730   Offset: 0xA6F530   Length: 0xF8
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
            FUN_1801e0300();
          }
          fVar4 = (float)ForceSpeAddData.Get(*(int64 *)(lVar2 + 176),15);
        }
        GlobalData.ListMulti(uVar1,fVar3 + 1.0 + fVar4,0);
    }

    // Token : 0x6000FA5
    // RVA   : 0x72BF30   Offset: 0x72AD30   Length: 0x5
    public ForceSpeAddData GetTotalResourceSpeAddData()
    {
        return this.resourceSpeAddData;
    }

    // Token : 0x6000FA6
    // RVA   : 0xA705B0   Offset: 0xA6F3B0   Length: 0x9C
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
            FUN_1801e0300();
          }
          fVar3 = (float)ForceSpeAddData.Get(*(int64 *)(lVar1 + 176),15);
        }
        return fVar2 + 1.0 + fVar3;
    }

    // Token : 0x6000FA7
    // RVA   : 0xA703A0   Offset: 0xA6F1A0   Length: 0x133
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
          puVar1 = (uint64 *)FUN_180af4e90(local_18);
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
          lVar2 = FUN_1802106e0(0);
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

    // Token : 0x6000FA8
    // RVA   : 0xA704E0   Offset: 0xA6F2E0   Length: 0xCC
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

    // Token : 0x6000FA9
    // RVA   : 0xA702B0   Offset: 0xA6F0B0   Length: 0xCC
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

    // Token : 0x6000FAA
    // RVA   : 0xA70050   Offset: 0xA6EE50   Length: 0x175
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
