// ============================================================
// Type  : PropertyBinding
// Token : 0x200008D
// ============================================================

public class PropertyBinding
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4000358
    public PropertyReference source;

    // Token: 0x4000359
    public PropertyReference target;

    // Token: 0x400035A
    public Direction direction;

    // Token: 0x400035B
    public UpdateCondition update;

    // Token: 0x400035C
    public bool editMode;

    // Token: 0x400035D
    private object mLastValue;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000423
    // RVA   : 0xBDD7D0   Offset: 0xBDBFD0   Length: 0x2E
    private void Start()
    {
        PropertyBinding.UpdateTarget(this,0);
        if (this.update == null) {
          Behaviour.set_enabled(this,0,0);
          return;
        }
    }

    // Token : 0x6000424
    // RVA   : 0xBDD9F0   Offset: 0xBDC1F0   Length: 0xE
    private void Update()
    {
        void FUN_180bdd9f0(int64 this)
        {
        if (this.update == 1) {
          PropertyBinding.UpdateTarget(this,0);
          return;
        }
    }

    // Token : 0x6000425
    // RVA   : 0xBDD750   Offset: 0xBDBF50   Length: 0xE
    private void LateUpdate()
    {
        void FUN_180bdd750(int64 this)
        {
        if (this.update == 2) {
          PropertyBinding.UpdateTarget(this,0);
          return;
        }
    }

    // Token : 0x6000426
    // RVA   : 0xBDD740   Offset: 0xBDBF40   Length: 0xE
    private void FixedUpdate()
    {
        void FUN_180bdd740(int64 this)
        {
        if (this.update == 3) {
          PropertyBinding.UpdateTarget(this,0);
          return;
        }
    }

    // Token : 0x6000427
    // RVA   : 0xBDD760   Offset: 0xBDBF60   Length: 0x6E
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

    // Token : 0x6000428
    // RVA   : 0xBDD800   Offset: 0xBDC000   Length: 0x1EF
    public void UpdateTarget()
    {
        long lVar1;
        long lVar3;
        bool cVar4;
        ulong uVar5;
        ulong uVar6;
        if (((this.source != null) && (this.target != null)) &&
           (cVar4 = PropertyReference.get_isValid(this.source,0), cVar4)) {
          if (this.target == null) goto LAB_180bdd9ea;
          cVar4 = PropertyReference.get_isValid(this.target,0);
          if (!cVar4) {
            return;
          }
          lVar1 = this.source;
          if (this.direction == null) {
            lVar3 = this.target;
            if (lVar1 == null) goto LAB_180bdd9ea;
            uVar5 = PropertyReference.Get(lVar1,0);
            lVar1 = lVar3;
          }
          else if (this.direction == 1) {
            if (this.target == null) goto LAB_180bdd9ea;
            uVar5 = PropertyReference.Get(this.target,0);
          }
          else {
            if (lVar1 == null) goto LAB_180bdd9ea;
            uVar5 = PropertyReference.GetPropertyType(lVar1,0);
            if (this.target == null) goto LAB_180bdd9ea;
            uVar6 = PropertyReference.GetPropertyType(this.target,0);
            cVar4 = FUN_180295d70(uVar5,uVar6,0);
            if (!cVar4) {
              return;
            }
            if (this.source == null) goto LAB_180bdd9ea;
            uVar5 = PropertyReference.Get(this.source,0);
            plVar2 = this.mLastValue;
            if ((plVar2 == (int64 *)0) ||
               (cVar4 = (**(code **)(*plVar2 + 0x138))(plVar2,uVar5,*(uint64 *)(*plVar2 + 0x140)),
               !cVar4)) {
              this.mLastValue = uVar5;
              lVar1 = this.target;
            }
            else {
              if (this.target == null) goto LAB_180bdd9ea;
              uVar5 = PropertyReference.Get(this.target,0);
              plVar2 = this.mLastValue;
              if (plVar2 == (int64 *)0) goto LAB_180bdd9ea;
              cVar4 = (**(code **)(*plVar2 + 0x138))(plVar2,uVar5,*(uint64 *)(*plVar2 + 0x140));
              if (cVar4) {
                return;
              }
              this.mLastValue = uVar5;
              lVar1 = this.source;
            }
          }
          if (lVar1 == null) {
        LAB_180bdd9ea:
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          PropertyReference.Set(lVar1,uVar5,0);
        }
    }

    // Token : 0x6000429
    // RVA   : 0xBDDA00   Offset: 0xBDC200   Length: 0x12
    public void /*ctor*/()
    {
        void FUN_180bdda00(int64 this)
        {
        this.update = 1;
        this.editMode = 1;
        FUN_18044ef50(this,0);
    }

}
