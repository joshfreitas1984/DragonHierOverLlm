// ============================================================
// Type  : QuickTravelBigMapSpriteController
// Token : 0x2000328
// ============================================================

public class QuickTravelBigMapSpriteController
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001984
    private static QuickTravelBigMapSpriteController _instance;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6001F9A
    // RVA   : 0xC4EEF0   Offset: 0xC4D6F0   Length: 0x36
    public static QuickTravelBigMapSpriteController get_Instance()
    {
        return **(uint64 **)(DAT_181d6ed60 + 184);
    }

    // Token : 0x6001F9B
    // RVA   : 0xC4EA00   Offset: 0xC4D200   Length: 0x43
    private void Awake()
    {
        puVar1 = *(uint64 **)(DAT_181d6ed60 + 184);
        *puVar1 = this;
        il2cpp_internal(puVar1,this);
    }

    // Token : 0x6001F9C
    // RVA   : 0xC4EA50   Offset: 0xC4D250   Length: 0x301
    public virtual void OnDrag(PointerEventData eventData)
    {
        var plVar2 = *(int64*)(lVar2 + 184);
        var pStatics = *(int64*)(DAT_181d6ede0 + 184);
        float fVar1;
        long lVar2;
        ulong uVar3;
        ulong uVar4;
        long lVar5;
        long lVar7;
        ulong local_48;
        float local_40;
        ulong local_38;
        float local_30;
        byte[] local_28 = new byte[8];
        float local_20;
        byte[] local_18 = new byte[16];
        lVar2 = *pStatics;
        if (eventData != null) {
          uVar4 = *(uint64 *)(eventData + 0x108);
          if (*pStatics != 0) {
            uVar3 = *(uint64 *)(*pStatics + 176);
            if ((*pStatics != 0) &&
               (lVar5 = *(int64 *)(*pStatics + 32)) != null) {
              lVar5 = GameObject.get_transform(lVar5,0);
              if (lVar5 != null) {
                lVar5 = Transform.Find(lVar5,"MapRoot",0);
                if (lVar5 != null) {
                  puVar6 = (uint64 *)Transform.get_localPosition(local_28,lVar5,0);
                  local_48 = *puVar6;
                  local_40 = *(float *)(puVar6 + 1);
                  if (*pStatics != 0) {
                    fVar1 = *(float *)(*pStatics + 192);
                    local_30 = local_40 / fVar1;
                    local_38 = CONCAT44(local_48._4_4_ / fVar1,(float)local_48 / fVar1);
                    local_48 = local_38;
                    local_40 = local_30;
                    puVar6 = (uint64 *)
                             GlobalData.TransformScreenDeltaToLocalDelta
                                       (local_28,uVar4,uVar3,&local_48,0);
                    if (lVar2 != null) {
                      local_38 = *puVar6;
                      local_30 = *(float *)(puVar6 + 1);
                      if (plVar2 != 0) {
                        lVar5 = GameObject.get_transform(plVar2,0);
                        if (plVar2 != 0) {
                          lVar7 = GameObject.get_transform(plVar2,0);
                          if (lVar7 != null) {
                            puVar6 = (uint64 *)Transform.get_localPosition(local_18,lVar7,0);
                            local_40 = *(float *)(puVar6 + 1);
                            local_30 = local_30 + local_40;
                            local_38 = CONCAT44(local_38._4_4_ + (float)((uint64)*puVar6 >> 32),
                                                (float)*puVar6 + (float)local_38);
                            local_20 = local_30;
                            puVar6 = (uint64 *)
                                     QuickTravelUIController.LimitMapPos
                                               (local_18,lVar2,&local_38,*(uint32 *)(lVar2 + 192),0);
                            if (lVar5 != null) {
                              local_38 = *puVar6;
                              local_30 = *(float *)(puVar6 + 1);
                              Transform.set_localPosition(lVar5,&local_38,0);
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
          }
        }
    }

    // Token : 0x6001F9D
    // RVA   : 0xC4ED60   Offset: 0xC4D560   Length: 0x186
    public virtual void OnScroll(PointerEventData eventData)
    {
        long lVar1;
        float fVar4;
        float fVar5;
        lVar1 = **(int64 **)(DAT_181d6ede0 + 184);
        if ((eventData != null) && (fVar5 = *(float *)(eventData + 0x13c), lVar1 != null)) {
          plVar2 = *(int64 **)(lVar1 + 144);
          if (plVar2 != (int64 *)0) {
            fVar4 = (float)(**(code **)(*plVar2 + 0x418))(plVar2,*(uint64 *)(*plVar2 + 0x420));
            plVar2 = *(int64 **)(lVar1 + 144);
            if (plVar2 != (int64 *)0) {
              (**(code **)(*plVar2 + 0x428))
                        (plVar2,(*(float *)(lVar1 + 192) - 1.0) + fVar5 * 0.1,
                         *(uint64 *)(*plVar2 + 0x430));
              plVar2 = *(int64 **)(lVar1 + 144);
              if (plVar2 != (int64 *)0) {
                fVar5 = (float)(**(code **)(*plVar2 + 0x418))(plVar2,*(uint64 *)(*plVar2 + 0x420));
                if (fVar4 != fVar5) {
                  plVar2 = (int64 *)Resources.Load("Sound/SoundEffect/摩擦",0);
                  plVar3 = (int64 *)0;
                  if ((plVar2 != (int64 *)0) && (*plVar2 == DAT_181d8a228)) {
                    plVar3 = plVar2;
                  }
                  NGUITools.PlaySound(plVar3,0x3d75c28f,0);
                }
                return;
              }
            }
          }
        }
    }

    // Token : 0x6001F9E
    // RVA   : 0x3A17B0   Offset: 0x39FFB0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_18044ef50(this,0);
    }

}
