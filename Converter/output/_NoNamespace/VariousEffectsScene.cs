// ============================================================
// Type  : VariousEffectsScene
// Token : 0x20003E4
// ============================================================

public class VariousEffectsScene
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001F58
    public Transform[] m_effects;

    // Token: 0x4001F59
    public GameObject scaleform;

    // Token: 0x4001F5A
    public GameObject[] m_destroyObjects;

    // Token: 0x4001F5B
    public GameObject FriendlyEnemyObject;

    // Token: 0x4001F5C
    private GameObject gm;

    // Token: 0x4001F5D
    public int inputLocation;

    // Token: 0x4001F5E
    public Text m_scalefactor;

    // Token: 0x4001F5F
    public static float m_gaph_scenesizefactor;

    // Token: 0x4001F60
    public Text m_effectName;

    // Token: 0x4001F61
    private int index;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60024E8
    // RVA   : 0x969910   Offset: 0x968710   Length: 0x99
    private void Awake()
    {
        long lVar2;
        ulong uVar4;
        plVar1 = this.m_effectName;
        this.inputLocation = 0;
        lVar2 = this.m_effects;
        if (lVar2 != null) {
          if (*(uint32 *)(lVar2 + 24) <= this.index) {
            uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1801e02d0(uVar4,0);
          }
          lVar2 = *(int64 *)(lVar2 + 32 + (int64)(int)this.index * 8);
          if (lVar2 != null) {
            plVar3 = (int64 *)Object.get_name(lVar2,0);
            if (plVar3 != (int64 *)0) {
              uVar4 = (**(code **)(*plVar3 + 0x168))(plVar3,*(uint64 *)(*plVar3 + 0x170));
              if (plVar1 != (int64 *)0) {
                (**(code **)(*plVar1 + 0x5e8))(plVar1,uVar4,*(uint64 *)(*plVar1 + 0x5f0));
                VariousEffectsScene.MakeObject(this,0);
                return;
              }
            }
          }
        }
    }

    // Token : 0x60024E9
    // RVA   : 0x96A0E0   Offset: 0x968EE0   Length: 0xC3
    private void Update()
    {
        long lVar1;
        bool cVar2;
        int iVar3;
        cVar2 = FUN_181844860(122);
        if (cVar2) {
          iVar3 = this.index;
          if (iVar3 < 1) {
            if (this.m_effects == null) throw; // [null/range check failed]
            iVar3 = *(int *)(this.m_effects + 24);
          }
          this.index = iVar3 + -1;
          VariousEffectsScene.MakeObject(this,0);
        }
        cVar2 = FUN_181844860(120);
        if (cVar2) {
          if (this.m_effects == null) throw; // [null/range check failed]
          if (this.index < *(int *)(this.m_effects + 24) + -1) {
            iVar3 = this.index + 1;
          }
          else {
            iVar3 = 0;
          }
          this.index = iVar3;
          VariousEffectsScene.MakeObject(this,0);
        }
        cVar2 = FUN_181844860(99);
        if (cVar2) {
          VariousEffectsScene.MakeObject(this,0);
        }
        lVar1 = this.FriendlyEnemyObject;
        if (this.index < 70) {
          if (lVar1 != null) {
            GameObject.SetActive(lVar1,0,0);
            return;
          }
        }
        else if (lVar1 != null) {
          GameObject.SetActive(lVar1,1,0);
          return;
        }
    }

    // Token : 0x60024EA
    // RVA   : 0x969B70   Offset: 0x968970   Length: 0x99
    private void InputKey()
    {
        bool cVar1;
        int iVar2;
        cVar1 = FUN_181844860(122);
        if (cVar1) {
          iVar2 = this.index;
          if (iVar2 < 1) {
            if (this.m_effects != null)
            {
              iVar2 = *(int *)(this.m_effects + 24);
              }
              this.index = iVar2 + -1;
              VariousEffectsScene.MakeObject(this,0);
              }
              cVar1 = FUN_181844860(120);
              if (cVar1) {
              if (this.m_effects == null) {
            }
                          // WARNING: Subroutine does not return
            FUN_1801e0300();
          }
          iVar2 = this.index + 1;
          if (*(int *)(this.m_effects + 24) + -1 <= this.index) {
            iVar2 = 0;
          }
          this.index = iVar2;
          VariousEffectsScene.MakeObject(this,0);
        }
        cVar1 = FUN_181844860(99);
        if (cVar1) {
          VariousEffectsScene.MakeObject(this,0);
          return;
        }
    }

    // Token : 0x60024EB
    // RVA   : 0x969C10   Offset: 0x968A10   Length: 0x4CA
    private void MakeObject()
    {
        long lVar2;
        long lVar4;
        ulong uVar5;
        ulong uVar7;
        uint uVar8;
        float fVar9;
        int[] local_res8 = new int[2];
        ulong local_48;
        float local_40;
        ulong local_38;
        ulong uStack_30;
        local_res8[0] = 0;
        uVar8 = 0;
        if (0 < this.inputLocation) {
          do {
            lVar4 = this.m_destroyObjects;
            if (lVar4 == null) throw; // [null/range check failed]
            if (*(uint32 *)(lVar4 + 24) <= uVar8) {
              uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1801e02d0(uVar5,0);
            }
            uVar5 = lVar4[uVar8];
            Object.Destroy(uVar5);
            uVar8 = uVar8 + 1;
          } while ((int)uVar8 < this.inputLocation);
        }
        lVar4 = this.m_effects;
        this.inputLocation = 0;
        if (lVar4 != null) {
          if (*(uint32 *)(lVar4 + 24) <= this.index) {
            uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1801e02d0(uVar5,0);
          }
          lVar4 = *(int64 *)(lVar4 + 32 + (int64)(int)this.index * 8);
          if ((lVar4 != null) && (lVar2 = Component.get_transform(lVar4,0)) != null) {
            puVar3 = (uint64 *)Transform.get_position(&local_48,lVar2,0);
            lVar2 = this.m_effects;
            uVar5 = *puVar3;
            fVar9 = *(float *)(puVar3 + 1);
            if (lVar2 != null) {
              if (*(uint32 *)(lVar2 + 24) <= this.index) {
                uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1801e02d0(uVar5,0);
              }
              lVar2 = *(int64 *)(lVar2 + 32 + (int64)(int)this.index * 8);
              if ((lVar2 != null) && (lVar2 = Component.get_transform(lVar2,0)) != null) {
                puVar3 = (uint64 *)Transform.get_rotation(&local_38,lVar2,0);
                local_38 = *puVar3;
                uStack_30 = puVar3[1];
                local_48 = uVar5;
                local_40 = fVar9;
                lVar4 = Object.Instantiate(lVar4,&local_48,&local_38,DAT_181e763f8);
                if (lVar4 != null) {
                  uVar5 = Component.get_gameObject(lVar4,0);
                  this.gm = uVar5;
                  plVar1 = this.m_effectName;
                  local_res8[0] = this.index + 1;
                  uVar5 = Int32.ToString(local_res8,0);
                  lVar4 = this.m_effects;
                  if (lVar4 != null) {
                    if (*(uint32 *)(lVar4 + 24) <= this.index) {
                      uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                      FUN_1801e02d0(uVar5,0);
                    }
                    lVar4 = *(int64 *)(lVar4 + 32 + (int64)(int)this.index * 8);
                    if ((lVar4 != null) &&
                       (plVar6 = (int64 *)Object.get_name(lVar4,0), plVar6 != (int64 *)0)) {
                      uVar7 = (**(code **)(*plVar6 + 0x168))(plVar6,*(uint64 *)(*plVar6 + 0x170));
                      uVar5 = String.Concat(uVar5," : ",uVar7,0);
                      if (plVar1 != (int64 *)0) {
                        (**(code **)(*plVar1 + 0x5e8))(plVar1,uVar5,*(uint64 *)(*plVar1 + 0x5f0));
                        if (this.scaleform != null) {
                          lVar4 = GameObject.get_transform(this.scaleform,0);
                          if (((this.gm != null) &&
                              (lVar2 = GameObject.get_transform(this.gm,0),
                              lVar2 != null)) &&
                             (puVar3 = (uint64 *)Transform.get_position(&local_38,lVar2,0),
                             lVar4 != null)) {
                            local_48 = *puVar3;
                            local_40 = *(float *)(puVar3 + 1);
                            Transform.set_position(lVar4,&local_48,0);
                            if (this.gm != null) {
                              lVar4 = GameObject.get_transform(this.gm,0);
                              if ((this.scaleform != null) &&
                                 (uVar5 = GameObject.get_transform(this.scaleform,0),
                                 lVar4 != null)) {
                                Transform.set_parent(lVar4,uVar5,0);
                                if ((this.gm != null) &&
                                   (lVar4 = GameObject.get_transform(this.gm,0),
                                   lVar4 != null)) {
                                  local_48 = 0x3f8000003f800000;
                                  local_40 = 1.0;
                                  Transform.set_localScale(lVar4,&local_48,0);
                                  fVar9 = **(float **)(DAT_181e93db8 + 184);
                                  if (this.index < 70) {
                                    fVar9 = fVar9 * 0.5;
                                  }
                                  if ((this.gm != null) &&
                                     (lVar4 = GameObject.get_transform(this.gm,0),
                                     lVar4 != null)) {
                                    local_48 = CONCAT44(fVar9,fVar9);
                                    local_40 = fVar9;
                                    Transform.set_localScale(lVar4,&local_48,0);
                                    plVar1 = this.m_destroyObjects;
                                    uVar8 = this.inputLocation;
                                    lVar4 = this.gm;
                                    if (plVar1 != (int64 *)0) {
                                      if ((lVar4 != null) &&
                                         (lVar2 = il2cpp_internal(lVar4,*(uint64 *)
                                                                             (*plVar1 + 64)), lVar2 == null
                                         )) {
                                        uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                        FUN_1801e02d0(uVar5,0);
                                      }
                                      if (*(uint32 *)(plVar1 + 3) <= uVar8) {
                                        uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                        FUN_1801e02d0(uVar5,0);
                                      }
                                      plVar1[(int64)(int)uVar8 + 4] = lVar4;
                                      il2cpp_internal(plVar1 + (int64)(int)uVar8 + 4,lVar4);
                                      this.inputLocation = this.inputLocation + 1;
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
            }
          }
        }
    }

    // Token : 0x60024EC
    // RVA   : 0x9699B0   Offset: 0x9687B0   Length: 0xA6
    private void DestroyGameObject()
    {
        long lVar1;
        ulong uVar2;
        uint uVar3;
        uVar3 = 0;
        if (0 < this.inputLocation) {
          do {
            lVar1 = this.m_destroyObjects;
            if (lVar1 == null) {
                          // WARNING: Subroutine does not return
              FUN_1801e0300();
            }
            if (*(uint32 *)(lVar1 + 24) <= uVar3) {
              uVar2 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1801e02d0(uVar2,0);
            }
            uVar2 = lVar1[uVar3];
            Object.Destroy(uVar2);
            uVar3 = uVar3 + 1;
          } while ((int)uVar3 < this.inputLocation);
        }
        this.inputLocation = 0;
    }

    // Token : 0x60024ED
    // RVA   : 0x969A60   Offset: 0x968860   Length: 0x10B
    public void GetSizeFactor()
    {
        ulong uVar2;
        long lVar3;
        uint uVar4;
        float fVar5;
        float local_28;
        float local_24;
        float local_20;
        plVar1 = this.m_scalefactor;
        if (plVar1 != (int64 *)0) {
          plVar1 = (int64 *)(**(code **)(*plVar1 + 0x5d8))(plVar1,*(uint64 *)(*plVar1 + 0x5e0));
          if (plVar1 != (int64 *)0) {
            uVar2 = (**(code **)(*plVar1 + 0x168))(plVar1,*(uint64 *)(*plVar1 + 0x170));
            uVar4 = Single.Parse(uVar2,0);
            **(uint32 **)(DAT_181e93db8 + 184) = uVar4;
            fVar5 = **(float **)(DAT_181e93db8 + 184);
            if (this.index < 70) {
              fVar5 = fVar5 * 0.5;
            }
            if (this.gm != null) {
              lVar3 = GameObject.get_transform(this.gm,0);
              if (lVar3 != null) {
                local_28 = fVar5;
                local_24 = fVar5;
                local_20 = fVar5;
                Transform.set_localScale(lVar3,&local_28,0);
                return;
              }
            }
          }
        }
    }

    // Token : 0x60024EE
    // RVA   : 0x96A1F0   Offset: 0x968FF0   Length: 0x54
    public void /*ctor*/()
    {
        ulong uVar1;
        uVar1 = FUN_1801dfd90(DAT_181e82b00,30);
        this.m_destroyObjects = uVar1;
        FUN_180ae8740(this,0);
    }

    // Token : 0x60024EF
    // RVA   : 0x96A1B0   Offset: 0x968FB0   Length: 0x39
    private static void /*cctor*/()
    {
        **(uint32 **)(DAT_181e93db8 + 184) = 0x3f800000;
    }

}
