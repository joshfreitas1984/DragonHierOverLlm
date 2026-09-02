// ============================================================
// Type  : OnCustomWrite
// Token : 0x20000A6
// ============================================================

public class OnCustomWrite
{
    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60004D2
    // RVA   : 0x210320   Offset: 0x20EB20   Length: 0x6A
    public void /*ctor*/(object object, IntPtr method)
    {
        bool cVar1;
        ulong uVar2;
        if (object == null) {
          cVar1 = FUN_1800d6050(method);
          if (!cVar1) {
            uVar2 = il2cpp_internal(0,"Delegate to an instance method cannot have null \'this\'.");
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar2,0);
          }
        }
        *(uint64 *)(this + 16) = *method;
        *(int64 *)(this + 32) = object;
        *(uint64 **)(this + 40) = method;
    }

    // Token : 0x60004D3
    // RVA   : 0xB080B0   Offset: 0xB068B0   Length: 0x420
    public virtual void Invoke(List<Vector3> v, List<Vector2> u, List<Color> c, List<Vector3> n, List<Vector4> t, List<Vector4> u2)
    {
        void OnCustomWrite.Invoke
                     (int64 this,int64 *v,uint64 u,uint64 c,
                     uint64 n,uint64 t,uint64 u2)
        {
        code *pcVar1;
        int64 *plVar2;
        char cVar3;
        int64 lVar4;
        uint64 *puVar5;
        int64 lVar6;
        uint16 uVar7;
        uint16 uVar8;
        uint64 uVar9;
        int64 *plVar10;
        int64 lVar11;
        int64 local_res8;
        uint64 local_58;
        uint64 local_50;
        local_res8 = this;
        lVar11 = *(int64 *)(this + 104);
        if (lVar11 == null) {
          plVar10 = &local_res8;
          local_50 = 1;
        }
        else {
          local_50 = *(uint64 *)(lVar11 + 24);
          plVar10 = (int64 *)(lVar11 + 32);
          if (local_50 == 0) {
            return;
          }
        }
        local_58 = 0;
        do {
          lVar11 = plVar10[local_58];
          pcVar1 = *(code **)(lVar11 + 16);
          plVar2 = *(int64 **)(lVar11 + 32);
          lVar11 = *(int64 *)(lVar11 + 40);
          if (*(short *)(lVar11 + 72) == -1) {
            il2cpp_internal(lVar11);
          }
          cVar3 = FUN_1800d6050(lVar11);
          if (!cVar3) {
            if (*(char *)(lVar11 + 74) == '\x06') {
              if ((((plVar2 == (int64 *)0) || (*(short *)(lVar11 + 72) == -1)) ||
                  ((*(uint32 *)(*plVar2 + 0x114) >> 8 & 1) != 0)) || (*(int64 *)(local_res8 + 24) == 0)
                 ) goto LAB_180b08592;
              cVar3 = il2cpp_internal(lVar11);
              if (!cVar3) {
                cVar3 = FUN_1800d65c0(lVar11);
                if (!cVar3) {
                  lVar11 = (uint64)*(uint16 *)(lVar11 + 72) * 16 + *plVar2;
                  (**(code **)(lVar11 + 0x138))
                            (plVar2,v,u,c,n,t,u2,
                             *(uint64 *)(lVar11 + 0x140));
                }
                else {
                  lVar6 = il2cpp_class_get_namespace(lVar11);
                  lVar4 = *plVar2;
                  uVar8 = 0;
                  if (*(uint16 *)(lVar4 + 0x12a) != 0) {
                    do {
                      if (*(int64 *)(*(int64 *)(lVar4 + 176) + (uint64)uVar8 * 16) == lVar6) {
                        puVar5 = (uint64 *)
                                 ((int64)
                                  (int)((uint32)*(uint16 *)(lVar11 + 72) +
                                       *(int *)(*(int64 *)(lVar4 + 176) + 8 + (uint64)uVar8 * 16)
                                       ) * 16 + 0x138 + lVar4);
                        goto LAB_180b08506;
                      }
                      uVar8 = uVar8 + 1;
                    } while (uVar8 < *(uint16 *)(lVar4 + 0x12a));
                  }
                  puVar5 = (uint64 *)FUN_1800914f0(plVar2,lVar6,*(uint16 *)(lVar11 + 72));
        LAB_180b08506:
                  (*(code *)*puVar5)(plVar2,v,u,c,n,t,u2,puVar5[1]);
                }
              }
              else {
                cVar3 = FUN_1800d65c0(lVar11);
                uVar8 = *(uint16 *)(lVar11 + 72);
                if (!cVar3) {
                  uVar9 = *(uint64 *)(*plVar2 + ((uint64)uVar8 + 20) * 16);
                }
                else {
                  lVar4 = *plVar2;
                  uVar7 = 0;
                  if (*(uint16 *)(lVar4 + 0x12a) != 0) {
                    do {
                      if (*(int64 *)(*(int64 *)(lVar4 + 176) + (uint64)uVar7 * 16) ==
                          *(int64 *)(lVar11 + 24)) {
                        lVar4 = (int64)
                                (int)((uint32)uVar8 +
                                     *(int *)(*(int64 *)(lVar4 + 176) + 8 + (uint64)uVar7 * 16))
                                * 16 + 0x138 + lVar4;
                        goto LAB_180b08436;
                      }
                      uVar7 = uVar7 + 1;
                    } while (uVar7 < *(uint16 *)(lVar4 + 0x12a));
                  }
                  lVar4 = FUN_1800914f0(plVar2,*(int64 *)(lVar11 + 24),uVar8);
        LAB_180b08436:
                  uVar9 = *(uint64 *)(lVar4 + 8);
                }
                puVar5 = (uint64 *)il2cpp_internal(uVar9,lVar11);
                (*(code *)*puVar5)(plVar2,v,u,c,n,t,u2,puVar5);
              }
            }
            else {
              if ((*(short *)(lVar11 + 72) == -1) || (*(int64 *)(local_res8 + 24) == 0))
              goto LAB_180b08187;
              cVar3 = il2cpp_internal(lVar11);
              if (!cVar3) {
                cVar3 = FUN_1800d65c0(lVar11);
                if (!cVar3) {
                  lVar11 = (uint64)*(uint16 *)(lVar11 + 72) * 16 + *v;
                  (**(code **)(lVar11 + 0x138))
                            (v,u,c,n,t,u2,
                             *(uint64 *)(lVar11 + 0x140));
                }
                else {
                  lVar6 = il2cpp_class_get_namespace(lVar11);
                  lVar4 = *v;
                  uVar8 = 0;
                  if (*(uint16 *)(lVar4 + 0x12a) != 0) {
                    do {
                      if (*(int64 *)(*(int64 *)(lVar4 + 176) + (uint64)uVar8 * 16) == lVar6) {
                        puVar5 = (uint64 *)
                                 ((int64)
                                  (int)((uint32)*(uint16 *)(lVar11 + 72) +
                                       *(int *)(*(int64 *)(lVar4 + 176) + 8 + (uint64)uVar8 * 16)
                                       ) * 16 + 0x138 + lVar4);
                        goto LAB_180b08306;
                      }
                      uVar8 = uVar8 + 1;
                    } while (uVar8 < *(uint16 *)(lVar4 + 0x12a));
                  }
                  puVar5 = (uint64 *)FUN_1800914f0(v,lVar6,*(uint16 *)(lVar11 + 72));
        LAB_180b08306:
                  (*(code *)*puVar5)(v,u,c,n,t,u2,puVar5[1]);
                }
              }
              else {
                cVar3 = FUN_1800d65c0(lVar11);
                uVar8 = *(uint16 *)(lVar11 + 72);
                if (!cVar3) {
                  uVar9 = *(uint64 *)(*v + ((uint64)uVar8 + 20) * 16);
                }
                else {
                  lVar4 = *v;
                  uVar7 = 0;
                  if (*(uint16 *)(lVar4 + 0x12a) != 0) {
                    do {
                      if (*(int64 *)(*(int64 *)(lVar4 + 176) + (uint64)uVar7 * 16) ==
                          *(int64 *)(lVar11 + 24)) {
                        uVar9 = *(uint64 *)
                                 ((int64)
                                  (int)((uint32)uVar8 +
                                       *(int *)(*(int64 *)(lVar4 + 176) + 8 + (uint64)uVar7 * 16)
                                       ) * 16 + lVar4 + 0x140);
                        goto LAB_180b0826b;
                      }
                      uVar7 = uVar7 + 1;
                    } while (uVar7 < *(uint16 *)(lVar4 + 0x12a));
                  }
                  lVar4 = FUN_1800914f0(v,*(int64 *)(lVar11 + 24),uVar8);
                  uVar9 = *(uint64 *)(lVar4 + 8);
                }
        LAB_180b0826b:
                puVar5 = (uint64 *)il2cpp_internal(uVar9,lVar11);
                (*(code *)*puVar5)(v,u,c,n,t,u2,puVar5);
              }
            }
          }
          else if (*(char *)(lVar11 + 74) == '\x06') {
        LAB_180b08187:
            (*pcVar1)(v,u,c,n,t,u2,lVar11);
          }
          else {
        LAB_180b08592:
            (*pcVar1)(plVar2,v,u,c,n,t,u2,lVar11);
          }
          local_58 = local_58 + 1;
          if (local_50 <= local_58) {
            return;
          }
        } while( true );
    }

    // Token : 0x60004D4
    // RVA   : 0xB08050   Offset: 0xB06850   Length: 0x5D
    public virtual IAsyncResult BeginInvoke(List<Vector3> v, List<Vector2> u, List<Color> c, List<Vector3> n, List<Vector4> t, List<Vector4> u2, AsyncCallback callback, object object)
    {
        void OnCustomWrite.BeginInvoke
                     (uint64 this,uint64 v,uint64 u,uint64 c,
                     uint64 n,uint64 t,uint64 u2,uint64 callback,
                     uint64 object)
        {
        uint64 local_48;
        uint64 local_40;
        uint64 local_38;
        uint64 local_30;
        uint64 local_28;
        uint64 local_20;
        uint64 local_18;
        local_30 = n;
        local_28 = t;
        local_20 = u2;
        local_18 = 0;
        local_48 = v;
        local_40 = u;
        local_38 = c;
        il2cpp_internal(this,&local_48,callback,object);
    }

    // Token : 0x60004D5
    // RVA   : 0x210040   Offset: 0x20E840   Length: 0xA
    public virtual void EndInvoke(IAsyncResult result)
    {
        il2cpp_internal(result,0);
    }

}
