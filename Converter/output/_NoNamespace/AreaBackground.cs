// ============================================================
// Type  : AreaBackground
// Token : 0x200013B
// ============================================================

public class AreaBackground
{
    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000A0E
    // RVA   : 0x786F10   Offset: 0x785D10   Length: 0x2CA
    private void Update()
    {
        bool cVar1;
        long lVar2;
        ulong uVar3;
        float fVar4;
        float fVar5;
        float fVar6;
        ulong local_res18;
        float local_res20;
        float fStackX_24;
        lVar2 = Component.get_gameObject(this,0);
        if (lVar2 == null) {
        LAB_1807871d5:
                          // WARNING: Subroutine does not return
          FUN_1801e0300();
        }
        cVar1 = GameObject.get_activeInHierarchy(lVar2,0);
        if (cVar1) {
          if (GameController._instance == null) goto LAB_1807871d5;
          cVar1 = GameController.HaveSpeUI(GameController._instance,1,0);
          if (!cVar1) {
            lVar2 = FUN_180210060(0);
            if (lVar2 == null) goto LAB_1807871d5;
            cVar1 = AreaController.CanDrag(lVar2,0);
            if (cVar1) {
              uVar3 = Vector2.get_zero(0);
              cVar1 = FUN_1818448a0(119);
              local_res18._0_4_ = (float)uVar3;
              local_res18._4_4_ = (float)((uint64)uVar3 >> 32);
              fVar4 = (float)local_res18;
              fVar6 = local_res18._4_4_;
              if (cVar1) {
                uVar3 = Vector2.get_up(0);
                local_res20 = (float)uVar3;
                fStackX_24 = (float)((uint64)uVar3 >> 32);
                fVar4 = (float)local_res18 + local_res20;
                fVar6 = local_res18._4_4_ + fStackX_24;
              }
              cVar1 = FUN_1818448a0(115);
              if (cVar1) {
                uVar3 = Vector2.get_down(0);
                local_res18._0_4_ = (float)uVar3;
                local_res18._4_4_ = (float)((uint64)uVar3 >> 32);
                fVar4 = (float)local_res18 + fVar4;
                fVar6 = local_res18._4_4_ + fVar6;
              }
              cVar1 = FUN_1818448a0(97);
              if (cVar1) {
                uVar3 = Vector2.get_left(0);
                local_res18._0_4_ = (float)uVar3;
                local_res18._4_4_ = (float)((uint64)uVar3 >> 32);
                fVar4 = (float)local_res18 + fVar4;
                fVar6 = local_res18._4_4_ + fVar6;
              }
              cVar1 = FUN_1818448a0(100);
              if (cVar1) {
                uVar3 = Vector2.get_right(0);
                local_res18._0_4_ = (float)uVar3;
                local_res18._4_4_ = (float)((uint64)uVar3 >> 32);
                fVar4 = (float)local_res18 + fVar4;
                fVar6 = local_res18._4_4_ + fVar6;
              }
              uVar3 = Vector2.get_zero(0);
              local_res18._0_4_ = (float)uVar3;
              local_res18._4_4_ = (float)((uint64)uVar3 >> 32);
              if (9.9999994e-11 <=
                  (fVar6 - local_res18._4_4_) * (fVar6 - local_res18._4_4_) +
                  (fVar4 - (float)local_res18) * (fVar4 - (float)local_res18)) {
                lVar2 = FUN_180210060(0);
                fVar5 = (float)Time.get_deltaTime(0);
                local_res18 = CONCAT44(fVar6 * fVar5 * -1000.0,fVar4 * fVar5 * -1000.0);
                if (lVar2 == null) goto LAB_1807871d5;
                AreaController.OnDrag(lVar2,local_res18,0);
              }
            }
          }
        }
    }

    // Token : 0x6000A0F
    // RVA   : 0x786D80   Offset: 0x785B80   Length: 0xC1
    public void OnDrag(Vector2 delta)
    {
        long lVar1;
        lVar1 = *(int64 *)(*(int64 *)(DAT_181e8c8b0 + 184) + 56);
        if (lVar1 != null) {
          AreaController.OnDrag(lVar1,delta,0);
          return;
        }
    }

    // Token : 0x6000A10
    // RVA   : 0x786E50   Offset: 0x785C50   Length: 0xBD
    public void OnScroll(float delta)
    {
        long lVar1;
        lVar1 = *(int64 *)(*(int64 *)(DAT_181e8c8b0 + 184) + 56);
        if (lVar1 != null) {
          AreaController.OnScroll(lVar1,delta,0);
          return;
        }
    }

    // Token : 0x6000A11
    // RVA   : 0x2110A0   Offset: 0x20FEA0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_180ae8740(this,0);
    }

}
