// ============================================================
// Type  : BigMapSpriteController
// Token : 0x2000193
// ============================================================

public class BigMapSpriteController
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4000AA1
    private static BigMapSpriteController _instance;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000CF5
    // RVA   : 0xCD7780   Offset: 0xCD5F80   Length: 0x36
    public static BigMapSpriteController get_Instance()
    {
        return **(uint64 **)(DAT_181d8bca8 + 184);
    }

    // Token : 0x6000CF6
    // RVA   : 0xCD6BF0   Offset: 0xCD53F0   Length: 0x43
    private void Awake()
    {
        puVar1 = *(uint64 **)(DAT_181d8bca8 + 184);
        *puVar1 = this;
        il2cpp_internal(puVar1,this);
    }

    // Token : 0x6000CF7
    // RVA   : 0xCD7450   Offset: 0xCD5C50   Length: 0x326
    private void Update()
    {
        var pStatics = *(int64*)(DAT_181d4df90 + 184);
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
        LAB_180cd7771:
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
        cVar1 = GameObject.get_activeInHierarchy(lVar2,0);
        if (cVar1) {
          if (*pStatics == 0) goto LAB_180cd7771;
          cVar1 = GameController.HaveSpeUI(*pStatics,1,0);
          if (!cVar1) {
            lVar2 = FUN_18046bbe0(0);
            if (lVar2 == null) goto LAB_180cd7771;
            cVar1 = BigMapController.CanDrag(lVar2,0);
            if (cVar1) {
              uVar3 = Vector2.get_zero(0);
              cVar1 = FUN_1804625f0(119);
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
              cVar1 = FUN_1804625f0(115);
              if (cVar1) {
                uVar3 = Vector2.get_down(0);
                local_res18 = (float)uVar3;
                fStackX_1c = (float)((uint64)uVar3 >> 32);
                fVar4 = local_res18 + fVar4;
                fVar6 = fStackX_1c + fVar6;
              }
              cVar1 = FUN_1804625f0(97);
              if (cVar1) {
                uVar3 = Vector2.get_left(0);
                local_res18 = (float)uVar3;
                fStackX_1c = (float)((uint64)uVar3 >> 32);
                fVar4 = local_res18 + fVar4;
                fVar6 = fStackX_1c + fVar6;
              }
              cVar1 = FUN_1804625f0(100);
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
                lVar2 = FUN_18046bbe0(0);
                fVar5 = (float)Time.get_deltaTime(0);
                if (lVar2 == null) goto LAB_180cd7771;
                local_38 = CONCAT44(fVar6 * fVar5 * -1000.0,fVar4 * fVar5 * -1000.0);
                local_30 = 0;
                BigMapController.OnDrag(lVar2,&local_38,0);
              }
            }
          }
        }
    }

    // Token : 0x6000CF8
    // RVA   : 0xCD6C40   Offset: 0xCD5440   Length: 0x395
    public void OnClick()
    {
        var pStatics_baa8 = *(int64*)(DAT_181d8baa8 + 184);
        var pStatics_df90 = *(int64*)(DAT_181d4df90 + 184);
        ulong uVar1;
        long lVar2;
        long lVar3;
        long lVar4;
        ulong local_28;
        uint local_20;
        byte[] local_18 = new byte[16];
        lVar2 = *(int64 *)(pStatics_baa8 + 16);
        if (lVar2 != null) {
          if (*(char *)(lVar2 + 248) != false) {
            return;
          }
          if ((((*pStatics_df90 != 0) &&
               (lVar2 = *(int64 *)(*pStatics_df90 + 32)) != null) &&
              (lVar2 = WorldData.Player(lVar2,0)) != null) && (*(int64 *)(lVar2 + 64) != 0)) {
            lVar2 = *(int64 *)(*(int64 *)(lVar2 + 64) + 56);
            lVar3 = *(int64 *)(pStatics_baa8 + 16);
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
                    *(float *)(lVar2 + 16) = (float)uVar1 * 100.0;
                    *(float *)(lVar2 + 20) = (float)((uint64)uVar1 >> 32) * 100.0;
                    lVar2 = *(int64 *)(pStatics_baa8 + 16);
                    if (lVar2 != null) {
                      puVar5 = (uint64 *)(lVar2 + 152);
                      *puVar5 = 0;
                      il2cpp_internal(puVar5,0);
                      lVar2 = *(int64 *)(pStatics_baa8 + 16);
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

    // Token : 0x6000CF9
    // RVA   : 0xCD6FE0   Offset: 0xCD57E0   Length: 0xED
    public void OnDrag(Vector2 delta)
    {
        long lVar1;
        ulong local_18;
        uint local_10;
        lVar1 = *(int64 *)(*(int64 *)(DAT_181d8baa8 + 184) + 16);
        if (lVar1 != null) {
          local_10 = 0;
          local_18 = delta;
          BigMapController.OnDrag(lVar1,&local_18,0);
          return;
        }
    }

    // Token : 0x6000CFA
    // RVA   : 0xCD70D0   Offset: 0xCD58D0   Length: 0x37C
    public void OnScroll(float delta)
    {
        float fVar1;
        float fVar2;
        bool cVar3;
        long lVar4;
        ulong uVar5;
        long lVar6;
        uint uVar8;
        lVar4 = *(int64 *)(*(int64 *)(DAT_181d8baa8 + 184) + 16);
        if (lVar4 != null) {
          if ((*(char *)(lVar4 + 248) != false) || (delta == null.0)) {
            return;
          }
          lVar4 = FUN_18046bbe0(0);
          if ((lVar4 != null) && (*(int64 *)(lVar4 + 64) != 0)) {
            uVar5 = GameObject.GetComponent(*(int64 *)(lVar4 + 64),DAT_181da1930);
            cVar3 = Object.op_Equality(uVar5,0,0);
            if (!cVar3) {
              lVar4 = FUN_18046bbe0(0);
              if (((lVar4 == null) || (*(int64 *)(lVar4 + 64) == 0)) ||
                 (lVar4 = GameObject.GetComponent(*(int64 *)(lVar4 + 64),DAT_181da1930)) == null
                 ) throw; // [null/range check failed]
              cVar3 = Behaviour.get_isActiveAndEnabled(lVar4,0);
              if (cVar3) {
                return;
              }
            }
            lVar4 = FUN_18046bbe0(0);
            lVar6 = FUN_18046bbe0(0);
            if (lVar6 != null) {
              fVar1 = *(float *)(lVar6 + 32);
              lVar6 = FUN_18046bbe0(0);
              if (lVar6 != null) {
                fVar2 = *(float *)(lVar6 + 36);
                lVar6 = FUN_18046c0a0(0);
                if ((((lVar6 != null) && (*(int64 *)(lVar6 + 32) != 0)) &&
                    (lVar6 = WorldData.Player(*(int64 *)(lVar6 + 32),0)) != null) &&
                   ((*(int64 *)(lVar6 + 64) != 0 &&
                    (lVar6 = *(int64 *)(*(int64 *)(lVar6 + 64) + 56)) != null))) {
                  if ((*(float *)(lVar6 + 16) == 0.0) && (*(float *)(lVar6 + 20) == 0.0)) {
                    lVar6 = FUN_18046bbe0(0);
                    if (lVar6 == null) throw; // [null/range check failed]
                    puVar7 = (uint32 *)(lVar6 + 28);
                  }
                  else {
                    puVar7 = *(uint32 **)(DAT_181d8baa8 + 184);
                  }
                  uVar8 = *puVar7;
                  lVar6 = FUN_18046bbe0(0);
                  if ((lVar6 != null) &&
                     (uVar8 = FUN_1810a8ba0(fVar2 * delta + fVar1,uVar8,*(uint32 *)(lVar6 + 24),0)
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

    // Token : 0x6000CFB
    // RVA   : 0x3A17B0   Offset: 0x39FFB0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_18044ef50(this,0);
    }

}
