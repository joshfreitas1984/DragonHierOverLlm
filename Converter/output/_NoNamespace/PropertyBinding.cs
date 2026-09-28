// ============================================================
// Type  : PropertyBinding
// Token : 0x200008E
// ============================================================

public class PropertyBinding
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4000374
    public PropertyReference source;

    // Token: 0x4000375
    public PropertyReference target;

    // Token: 0x4000376
    public Direction direction;

    // Token: 0x4000377
    public UpdateCondition update;

    // Token: 0x4000378
    public bool editMode;

    // Token: 0x4000379
    private object mLastValue;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x600043B
    // RVA   : 0xB11CA0   Offset: 0xB110A0   Length: 0x2E
    private void Start()
    {
        PropertyBinding.UpdateTarget(this,0);
        if (this.update == null) {
          Behaviour.set_enabled(this,0,0);
          return;
        }
    }

    // Token : 0x600043C
    // RVA   : 0xB11EC0   Offset: 0xB112C0   Length: 0xE
    private void Update()
    {
        void FUN_180b11ec0(int64 this)
        {
        if (this.update == 1) {
          PropertyBinding.UpdateTarget(this,0);
          return;
        }
    }

    // Token : 0x600043D
    // RVA   : 0xB11C20   Offset: 0xB11020   Length: 0xE
    private void LateUpdate()
    {
        void FUN_180b11c20(int64 this)
        {
        if (this.update == 2) {
          PropertyBinding.UpdateTarget(this,0);
          return;
        }
    }

    // Token : 0x600043E
    // RVA   : 0xB11C10   Offset: 0xB11010   Length: 0xE
    private void FixedUpdate()
    {
        void FUN_180b11c10(int64 this)
        {
        if (this.update == 3) {
          PropertyBinding.UpdateTarget(this,0);
          return;
        }
    }

    // Token : 0x600043F
    // RVA   : 0xB11C30   Offset: 0xB11030   Length: 0x6E
    private void OnValidate()
    {
        long lVar1;
        lVar1 = this.source;
        if (lVar1 != null) {
          lVar1.mField = 0;
          lVar1.mProperty = 0;
        }
        lVar1 = this.target;
        if (lVar1 != null) {
          lVar1.mField = 0;
          lVar1.mProperty = 0;
        }
    }

    // Token : 0x6000440
    // RVA   : 0xB11CD0   Offset: 0xB110D0   Length: 0x1EF
    public void UpdateTarget()
    {
        long lVar1;
        long lVar3;
        bool cVar4;
        ulong uVar5;
        ulong uVar6;
        if (((this.source != null) && (this.target != null)) &&
           (cVar4 = PropertyReference.get_isValid(this.source,0), cVar4)) {
          if (this.target == null) goto LAB_180b11eba;
          cVar4 = PropertyReference.get_isValid(this.target,0);
          if (!cVar4) {
            return;
          }
          lVar1 = this.source;
          if (this.direction == null) {
            lVar3 = this.target;
            if (lVar1 == null) goto LAB_180b11eba;
            uVar5 = PropertyReference.Get(lVar1,0);
            lVar1 = lVar3;
          }
          else if (this.direction == 1) {
            if (this.target == null) goto LAB_180b11eba;
            uVar5 = PropertyReference.Get(this.target,0);
          }
          else {
            if (lVar1 == null) goto LAB_180b11eba;
            uVar5 = PropertyReference.GetPropertyType(lVar1,0);
            if (this.target == null) goto LAB_180b11eba;
            uVar6 = PropertyReference.GetPropertyType(this.target,0);
            cVar4 = FUN_180295d70(uVar5,uVar6,0);
            if (!cVar4) {
              return;
            }
            if (this.source == null) goto LAB_180b11eba;
            uVar5 = PropertyReference.Get(this.source,0);
            plVar2 = this.mLastValue;
            if ((plVar2 == (int64 *)0) ||
               (cVar4 = (**(code **)(*plVar2 + 0x138))(plVar2,uVar5,*(uint64 *)(*plVar2 + 0x140)),
               !cVar4)) {
              this.mLastValue = uVar5;
              lVar1 = this.target;
            }
            else {
              if (this.target == null) goto LAB_180b11eba;
              uVar5 = PropertyReference.Get(this.target,0);
              plVar2 = this.mLastValue;
              if (plVar2 == (int64 *)0) goto LAB_180b11eba;
              cVar4 = (**(code **)(*plVar2 + 0x138))(plVar2,uVar5,*(uint64 *)(*plVar2 + 0x140));
              if (cVar4) {
                return;
              }
              this.mLastValue = uVar5;
              lVar1 = this.source;
            }
          }
          if (lVar1 == null) {
        LAB_180b11eba:
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          PropertyReference.Set(lVar1,uVar5,0);
        }
    }

    // Token : 0x6000441
    // RVA   : 0xB11ED0   Offset: 0xB112D0   Length: 0x12
    public void /*ctor*/()
    {
        void FUN_180b11ed0(int64 this)
        {
        this.update = 1;
        this.editMode = 1;
        FUN_18044ef50(this,0);
    }

}
