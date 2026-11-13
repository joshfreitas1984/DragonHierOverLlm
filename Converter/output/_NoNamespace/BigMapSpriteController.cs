// ============================================================
// Type  : BigMapSpriteController
// Token : 0x200019B
// ============================================================

public class BigMapSpriteController
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4000B39
    private static BigMapSpriteController _instance;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000D25
    // RVA   : 0x9E6350   Offset: 0x9E5150   Length: 0x36
    public static BigMapSpriteController get_Instance()
    {
        return **(uint64 **)(DAT_181e91070 + 184);
    }

    // Token : 0x6000D26
    // RVA   : 0x9E57C0   Offset: 0x9E45C0   Length: 0x43
    private void Awake()
    {
        puVar1 = *(uint64 **)(DAT_181e91070 + 184);
        *puVar1 = this;
        il2cpp_internal(puVar1,this);
    }

    // Token : 0x6000D27
    // RVA   : 0x9E6020   Offset: 0x9E4E20   Length: 0x326
    private void Update()
    {
        bool cVar1;
        long lVar2;
        ulong uVar3;
        float fVar4;
        float fVar5;
        float fVar6;
        float local_res18;
        float fStackX_1c;
        float local_res20;
        float fStackX_24;
        uint64 local_38;
        uint32 local_30;
        lVar2 = Component.get_gameObject(this,0);
        if (lVar2 == null) {
        LAB_1809e6341:
                          // WARNING: Subroutine does not return
          FUN_1801e0300();
        }
        cVar1 = GameObject.get_activeInHierarchy(lVar2,0);
        if (cVar1) {
          if (GameController._instance == null) goto LAB_1809e6341;
          cVar1 = GameController.HaveSpeUI(GameController._instance,1,0);
          if (!cVar1) {
            lVar2 = FUN_180210220(0);
            if (lVar2 == null) goto LAB_1809e6341;
            cVar1 = BigMapController.CanDrag(lVar2,0);
            if (cVar1) {
              uVar3 = Vector2.get_zero(0);
              cVar1 = FUN_1818448a0(119);
              local_res18 = (float)uVar3;
              fStackX_1c = (float)((uint64)uVar3 >> 32);
              fVar4 = local_res18;
              fVar6 = fStackX_1c;
              if (cVar1) {
                uVar3 = Vector2.get_up(0);
                local_res20 = (float)uVar3;
                fStackX_24 = (float)((uint64)uVar3 >> 32);
                fVar4 = local_res18 + local_res20;
                fVar6 = fStackX_1c + fStackX_24;
              }
              cVar1 = FUN_1818448a0(115);
              if (cVar1) {
                uVar3 = Vector2.get_down(0);
                local_res18 = (float)uVar3;
                fStackX_1c = (float)((uint64)uVar3 >> 32);
                fVar4 = local_res18 + fVar4;
                fVar6 = fStackX_1c + fVar6;
              }
              cVar1 = FUN_1818448a0(97);
              if (cVar1) {
                uVar3 = Vector2.get_left(0);
                local_res18 = (float)uVar3;
                fStackX_1c = (float)((uint64)uVar3 >> 32);
                fVar4 = local_res18 + fVar4;
                fVar6 = fStackX_1c + fVar6;
              }
              cVar1 = FUN_1818448a0(100);
              if (cVar1) {
                uVar3 = Vector2.get_right(0);
                local_res18 = (float)uVar3;
                fStackX_1c = (float)((uint64)uVar3 >> 32);
                fVar4 = local_res18 + fVar4;
                fVar6 = fStackX_1c + fVar6;
              }
              uVar3 = Vector2.get_zero(0);
              local_res18 = (float)uVar3;
              fStackX_1c = (float)((uint64)uVar3 >> 32);
              if (9.9999994e-11 <=
                  (fVar6 - fStackX_1c) * (fVar6 - fStackX_1c) +
                  (fVar4 - local_res18) * (fVar4 - local_res18)) {
                lVar2 = FUN_180210220(0);
                fVar5 = (float)Time.get_deltaTime(0);
                if (lVar2 == null) goto LAB_1809e6341;
                local_38 = CONCAT44(fVar6 * fVar5 * -1000.0,fVar4 * fVar5 * -1000.0);
                local_30 = 0;
                BigMapController.OnDrag(lVar2,&local_38,0);
              }
            }
          }
        }
    }

    // Token : 0x6000D28
    // RVA   : 0x9E5810   Offset: 0x9E4610   Length: 0x395
    public void OnClick()
    {
        ulong uVar1;
        long lVar2;
        long lVar3;
        long lVar4;
        ulong local_28;
        uint local_20;
        byte[] local_18 = new byte[16];
        lVar2 = GameController.CheckShowSpeHero;
        if (lVar2 != null) {
          if (lVar2.tutorialFinished) {
            return;
          }
          if ((((GameController._instance != null) &&
               (lVar2 = GameController._instance.worldData) != null) &&
              (lVar2 = WorldData.Player(lVar2,0)) != null) && (lVar2.ResourcePoints != null)) {
            lVar2 = *(int64 *)(lVar2.ResourcePoints + 56);
            lVar3 = GameController.CheckShowSpeHero;
            if ((lVar3 != null) && (lVar3 = *(int64 *)(lVar3 + 64)) != null) {
              lVar3 = GameObject.get_transform(lVar3,0);
              lVar4 = Camera.get_main(0);
              puVar5 = (uint64 *)Input.get_mousePosition(local_18,0);
              if (lVar4 != null) {
                local_20 = *(uint32 *)(puVar5 + 1);
                local_28 = *puVar5;
                puVar5 = (uint64 *)Camera.ScreenToWorldPoint(local_18,lVar4,&local_28,0);
                if (lVar3 != null) {
                  local_28 = *puVar5;
                  local_20 = *(uint32 *)(puVar5 + 1);
                  puVar5 = (uint64 *)Transform.InverseTransformPoint(local_18,lVar3,&local_28,0);
                  if (lVar2 != null) {
                    uVar1 = *puVar5;
                    lVar2.chapter = (float)uVar1 * 100.0;
                    *(float *)(lVar2 + 20) = (float)((uint64)uVar1 >> 32) * 100.0;
                    lVar2 = GameController.CheckShowSpeHero;
                    if (lVar2 != null) {
                      puVar5 = (uint64 *)(lVar2 + 160);
                      *puVar5 = 0;
                      il2cpp_internal(puVar5,0);
                      lVar2 = GameController.CheckShowSpeHero;
                      if (lVar2 != null) {
                        BigMapController.SetHorseButton(lVar2,0,0);
                        return;
                      }
                    }
                  }
                }
              }
            }
          }
        }
    }

    // Token : 0x6000D29
    // RVA   : 0x9E5BB0   Offset: 0x9E49B0   Length: 0xED
    public void OnDrag(Vector2 delta)
    {
        long lVar1;
        ulong local_18;
        uint local_10;
        lVar1 = *(int64 *)(*(int64 *)(DAT_181e90e50 + 184) + 16);
        if (lVar1 != null) {
          local_10 = 0;
          local_18 = delta;
          BigMapController.OnDrag(lVar1,&local_18,0);
          return;
        }
    }

    // Token : 0x6000D2A
    // RVA   : 0x9E5CA0   Offset: 0x9E4AA0   Length: 0x37C
    public void OnScroll(float delta)
    {
        float fVar1;
        float fVar2;
        bool cVar3;
        long lVar4;
        ulong uVar5;
        long lVar6;
        uint uVar8;
        lVar4 = *(int64 *)(*(int64 *)(DAT_181e90e50 + 184) + 16);
        if (lVar4 != null) {
          if ((*(char *)(lVar4 + 0x100) != false) || (delta == null.0)) {
            return;
          }
          lVar4 = FUN_180210220(0);
          if ((lVar4 != null) && (*(int64 *)(lVar4 + 64) != 0)) {
            uVar5 = GameObject.GetComponent(*(int64 *)(lVar4 + 64),DAT_181e56bf8);
            cVar3 = Object.op_Equality(uVar5,0,0);
            if (!cVar3) {
              lVar4 = FUN_180210220(0);
              if (((lVar4 == null) || (*(int64 *)(lVar4 + 64) == 0)) ||
                 (lVar4 = GameObject.GetComponent(*(int64 *)(lVar4 + 64),DAT_181e56bf8)) == null
                 ) throw; // [null/range check failed]
              cVar3 = Behaviour.get_isActiveAndEnabled(lVar4,0);
              if (cVar3) {
                return;
              }
            }
            lVar4 = FUN_180210220(0);
            lVar6 = FUN_180210220(0);
            if (lVar6 != null) {
              fVar1 = *(float *)(lVar6 + 32);
              lVar6 = FUN_180210220(0);
              if (lVar6 != null) {
                fVar2 = *(float *)(lVar6 + 36);
                lVar6 = FUN_1802106e0(0);
                if ((((lVar6 != null) && (*(int64 *)(lVar6 + 32) != 0)) &&
                    (lVar6 = WorldData.Player(*(int64 *)(lVar6 + 32),0)) != null) &&
                   ((*(int64 *)(lVar6 + 64) != 0 &&
                    (lVar6 = *(int64 *)(*(int64 *)(lVar6 + 64) + 56)) != null))) {
                  if ((*(float *)(lVar6 + 16) == 0.0) && (*(float *)(lVar6 + 20) == 0.0)) {
                    lVar6 = FUN_180210220(0);
                    if (lVar6 == null) throw; // [null/range check failed]
                    puVar7 = (uint32 *)(lVar6 + 28);
                  }
                  else {
                    puVar7 = *(uint32 **)(DAT_181e90e50 + 184);
                  }
                  uVar8 = *puVar7;
                  lVar6 = FUN_180210220(0);
                  if ((lVar6 != null) &&
                     (uVar8 = FUN_180f34e60(fVar2 * delta + fVar1,uVar8,*(uint32 *)(lVar6 + 24),0)
                     , lVar4 != null)) {
                    *(uint32 *)(lVar4 + 32) = uVar8;
                    return;
                  }
                }
              }
            }
          }
        }
    }

    // Token : 0x6000D2B
    // RVA   : 0x2110A0   Offset: 0x20FEA0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_180ae8740(this,0);
    }

}
