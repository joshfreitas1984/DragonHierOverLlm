// ============================================================
// Type  : CFX_Demo
// Token : 0x20003C7
// ============================================================

public class CFX_Demo
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001EB6
    public bool orderedSpawns;

    // Token: 0x4001EB7
    public float step;

    // Token: 0x4001EB8
    public float range;

    // Token: 0x4001EB9
    private float order;

    // Token: 0x4001EBA
    public Material groundMat;

    // Token: 0x4001EBB
    public Material waterMat;

    // Token: 0x4001EBC
    public GameObject[] ParticleExamples;

    // Token: 0x4001EBD
    private Dictionary<string, float> ParticlesYOffsetD;

    // Token: 0x4001EBE
    private int exampleIndex;

    // Token: 0x4001EBF
    private string randomSpawnsDelay;

    // Token: 0x4001EC0
    private bool randomSpawns;

    // Token: 0x4001EC1
    private bool slowMo;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6002475
    // RVA   : 0x9384B0   Offset: 0x9372B0   Length: 0x1D0
    private void OnMouseDown()
    {
        bool cVar1;
        long lVar2;
        long lVar3;
        ulong local_a8;
        float local_a0;
        ulong local_98;
        float local_90;
        ulong local_88;
        float local_80;
        byte[] local_78 = new byte[32];
        uint local_58;
        uint uStack_54;
        uint uStack_50;
        uint32 uStack_4c;
        uint64 local_48;
        uint64 local_38;
        uint64 uStack_30;
        uint64 local_28;
        uint64 uStack_20;
        uint64 local_18;
        uint32 local_10;
        local_38 = 0;
        uStack_30 = 0;
        local_18 = 0;
        local_28 = 0;
        uStack_20 = 0;
        local_10 = 0;
        lVar2 = Component.GetComponent(this,DAT_181e76eb8);
        lVar3 = Camera.get_main(0);
        puVar4 = (uint64 *)Input.get_mousePosition(local_78,0);
        if (lVar3 != null) {
          local_a0 = *(float *)(puVar4 + 1);
          local_a8 = *puVar4;
          puVar5 = (uint32 *)Camera.ScreenPointToRay(local_78,lVar3,&local_a8,0);
          if (lVar2 != null) {
            local_58 = *puVar5;
            uStack_54 = puVar5[1];
            uStack_50 = puVar5[2];
            uStack_4c = puVar5[3];
            local_48 = *(uint64 *)(puVar5 + 4);
            cVar1 = Collider.Raycast(lVar2,&local_58,&local_38,0x461c3c00,0);
            if (!cVar1) {
              return;
            }
            lVar2 = CFX_Demo.spawnParticle(this,0);
            if (lVar2 != null) {
              lVar3 = GameObject.get_transform(lVar2,0);
              puVar4 = (uint64 *)FUN_180af1d30(local_78,&local_38,0);
              local_80 = *(float *)(puVar4 + 1);
              local_88 = *puVar4;
              lVar2 = GameObject.get_transform(lVar2,0);
              if (lVar2 != null) {
                puVar4 = (uint64 *)Transform.get_position(&local_58,lVar2,0);
                local_98 = *puVar4;
                local_90 = *(float *)(puVar4 + 1);
                local_a0 = local_80 + local_90;
                local_a8 = CONCAT44(local_88._4_4_ + (float)((uint64)local_98 >> 32),
                                    (float)local_88 + (float)local_98);
                if (lVar3 != null) {
                  local_98 = local_a8;
                  local_90 = local_a0;
                  Transform.set_position(lVar3,&local_98,0);
                  return;
                }
              }
            }
          }
        }
    }

    // Token : 0x6002476
    // RVA   : 0x939540   Offset: 0x938340   Length: 0x309
    private GameObject spawnParticle()
    {
        uint uVar1;
        bool cVar2;
        int iVar3;
        long lVar4;
        long lVar5;
        ulong uVar6;
        int iVar7;
        uint uVar8;
        long local_98;
        uint uStack_90;
        uint32 uStack_8c;
        uint64 local_88;
        uint64 uStack_80;
        int64 local_78;
        uint64 uStack_70;
        uint64 local_68;
        uint64 local_58;
        uint64 uStack_50;
        int64 local_48;
        uint64 uStack_40;
        uint64 local_38;
        local_88 = 0;
        uStack_80 = 0;
        local_78 = 0;
        uStack_70 = 0;
        local_68 = 0;
        lVar4 = this.ParticleExamples;
        if (lVar4 != null) {
          if (*(uint32 *)(lVar4 + 24) <= this.exampleIndex) {
            uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1801e02d0(uVar6,0);
          }
          uVar6 = *(uint64 *)(lVar4 + 32 + (int64)(int)this.exampleIndex * 8);
          lVar4 = Object.Instantiate(uVar6,DAT_181e75ef8);
          if (lVar4 != null) {
            GameObject.SetActive(lVar4,1,0);
            iVar7 = 0;
            while( true ) {
              lVar5 = GameObject.get_transform(lVar4,0);
              if (lVar5 == null) break;
              iVar3 = Transform.get_childCount(lVar5,0);
              if (iVar3 <= iVar7) {
                uVar8 = 0;
                if (this.ParticlesYOffsetD != null) {
                  FUN_1806db990(&local_58,this.ParticlesYOffsetD,DAT_181e56808);
                  local_88 = local_58;
                  uStack_80 = uStack_50;
                  local_78 = local_48;
                  uStack_70 = uStack_40;
                  local_68 = local_38;
                  goto LAB_180939710;
                }
                break;
              }
              lVar5 = GameObject.get_transform(lVar4,0);
              if (lVar5 == null) break;
              lVar5 = Transform.GetChild(lVar5,iVar7,0);
              if (lVar5 == null) break;
              lVar5 = Component.get_gameObject(lVar5,0);
              if (lVar5 == null) break;
              GameObject.SetActive(lVar5);
              iVar7 = iVar7 + 1;
            }
          }
        }
        throw; // [null/range check failed]
        while( true ) {
          local_98 = local_78;
          uStack_90 = (uint32)uStack_70;
          uStack_8c = uStack_70._4_4_;
          lVar5 = Object.get_name(lVar4,0);
          if (lVar5 == null) {
                          // WARNING: Subroutine does not return
            FUN_1801e0300();
          }
          cVar2 = String.StartsWith(lVar5,local_98,0);
          uVar1 = uStack_90;
          if (cVar2) break;
        LAB_180939710:
          cVar2 = FUN_180fe6a80(&local_88,DAT_181e83780);
          if (!cVar2) {
            ZhSegment.Initialize(&local_88,DAT_181e83700);
            goto LAB_1809397be;
          }
        }
        ZhSegment.Initialize(&local_88,DAT_181e83700);
        uVar8 = uVar1;
        LAB_1809397be:
        lVar5 = GameObject.get_transform(lVar4,0);
        if (lVar5 != null) {
          local_98 = (uint64)uVar8 << 32;
          uStack_90 = 0;
          Transform.set_position(lVar5,&local_98,0);
          return lVar4;
        }
    }

    // Token : 0x6002477
    // RVA   : 0x937B50   Offset: 0x936950   Length: 0x95F
    private void OnGUI()
    {
        bool cVar1;
        ulong uVar2;
        long lVar4;
        long lVar5;
        uint uVar6;
        ulong local_38;
        ulong uStack_30;
        uint local_28;
        uint uStack_24;
        uint uStack_20;
        uint32 uStack_1c;
        Screen.get_width(0);
        local_38 = 0;
        uStack_30 = 0;
        FUN_1807282e0(&local_38,0x40a00000,0x41a00000);
        local_28 = (uint32)local_38;
        uStack_24 = local_38._4_4_;
        uStack_20 = (uint32)uStack_30;
        uStack_1c = uStack_30._4_4_;
        GUILayout.BeginArea(&local_28,0);
        uVar2 = FUN_1802100c0(DAT_181e6da98);
        GUILayout.BeginHorizontal(uVar2,0);
        plVar3 = (int64 *)FUN_1801dfd90(DAT_181e82a00,1);
        lVar4 = GUILayout.Width(0x42480000,0);
        if (plVar3 != (int64 *)0) {
          if (lVar4 != null) {
            lVar5 = il2cpp_internal(lVar4,*(uint64 *)(*plVar3 + 64));
            if (lVar5 == null) {
              uVar2 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1801e02d0(uVar2,0);
            }
          }
          if ((int)plVar3[3] == 0) {
            uVar2 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1801e02d0(uVar2,0);
          }
          plVar3[4] = lVar4;
          il2cpp_internal(plVar3 + 4,lVar4);
          GUILayout.Label("Effect",plVar3,0);
          plVar3 = (int64 *)FUN_1801dfd90(DAT_181e82a00,1);
          lVar4 = GUILayout.Width(0x41a00000,0);
          if (plVar3 != (int64 *)0) {
            if (lVar4 != null) {
              lVar5 = il2cpp_internal(lVar4,*(uint64 *)(*plVar3 + 64));
              if (lVar5 == null) {
                uVar2 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1801e02d0(uVar2,0);
              }
            }
            if ((int)plVar3[3] == 0) {
              uVar2 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1801e02d0(uVar2,0);
            }
            plVar3[4] = lVar4;
            il2cpp_internal(plVar3 + 4,lVar4);
            cVar1 = GUILayout.Button("<",plVar3,0);
            if (cVar1) {
              CFX_Demo.prevParticle(this,0);
            }
            lVar4 = this.ParticleExamples;
            if (lVar4 != null) {
              if (*(uint32 *)(lVar4 + 24) <= this.exampleIndex) {
                uVar2 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1801e02d0(uVar2,0);
              }
              lVar4 = *(int64 *)(lVar4 + 32 + (int64)(int)this.exampleIndex * 8);
              if (lVar4 != null) {
                uVar2 = Object.get_name(lVar4,0);
                plVar3 = (int64 *)FUN_1801dfd90(DAT_181e82a00,1);
                lVar4 = GUILayout.Width(0x433e0000,0);
                if (plVar3 != (int64 *)0) {
                  if (lVar4 != null) {
                    lVar5 = il2cpp_internal(lVar4,*(uint64 *)(*plVar3 + 64));
                    if (lVar5 == null) {
                      uVar2 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                      FUN_1801e02d0(uVar2,0);
                    }
                  }
                  if ((int)plVar3[3] == 0) {
                    uVar2 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                    FUN_1801e02d0(uVar2,0);
                  }
                  plVar3[4] = lVar4;
                  il2cpp_internal(plVar3 + 4,lVar4);
                  GUILayout.Label(uVar2,plVar3,0);
                  plVar3 = (int64 *)FUN_1801dfd90(DAT_181e82a00,1);
                  lVar4 = GUILayout.Width(0x41a00000,0);
                  if (plVar3 != (int64 *)0) {
                    if (lVar4 != null) {
                      lVar5 = il2cpp_internal(lVar4,*(uint64 *)(*plVar3 + 64));
                      if (lVar5 == null) {
                        uVar2 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                        FUN_1801e02d0(uVar2,0);
                      }
                    }
                    if ((int)plVar3[3] == 0) {
                      uVar2 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                      FUN_1801e02d0(uVar2,0);
                    }
                    plVar3[4] = lVar4;
                    il2cpp_internal(plVar3 + 4,lVar4);
                    cVar1 = GUILayout.Button(">",plVar3,0);
                    if (cVar1) {
                      CFX_Demo.nextParticle(this,0);
                    }
                    uVar2 = FUN_1802100c0(DAT_181e6da98);
                    GUILayout.Label("Click on the ground to spawn selected particles",uVar2,0);
                    uVar2 = "Rotate Camera";
                    if (**(char **)(DAT_181e951b8 + 184) != false) {
                      uVar2 = "Pause Camera";
                    }
                    plVar3 = (int64 *)FUN_1801dfd90(DAT_181e82a00,1);
                    lVar4 = GUILayout.Width(0x430c0000,0);
                    if (plVar3 != (int64 *)0) {
                      if (lVar4 != null) {
                        lVar5 = il2cpp_internal(lVar4,*(uint64 *)(*plVar3 + 64));
                        if (lVar5 == null) {
                          uVar2 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                          FUN_1801e02d0(uVar2,0);
                        }
                      }
                      if ((int)plVar3[3] == 0) {
                        uVar2 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                        FUN_1801e02d0(uVar2,0);
                      }
                      plVar3[4] = lVar4;
                      il2cpp_internal(plVar3 + 4,lVar4);
                      cVar1 = GUILayout.Button(uVar2,plVar3,0);
                      if (cVar1) {
                        **(char **)(DAT_181e951b8 + 184) = **(char **)(DAT_181e951b8 + 184) == false;
                      }
                      uVar2 = "Start Random Spawns";
                      if (this.randomSpawns) {
                        uVar2 = "Stop Random Spawns";
                      }
                      plVar3 = (int64 *)FUN_1801dfd90(DAT_181e82a00,1);
                      lVar4 = GUILayout.Width(0x430c0000,0);
                      if (plVar3 != (int64 *)0) {
                        if (lVar4 != null) {
                          lVar5 = il2cpp_internal(lVar4,*(uint64 *)(*plVar3 + 64));
                          if (lVar5 == null) {
                            uVar2 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                            FUN_1801e02d0(uVar2,0);
                          }
                        }
                        if ((int)plVar3[3] == 0) {
                          uVar2 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                          FUN_1801e02d0(uVar2,0);
                        }
                        plVar3[4] = lVar4;
                        il2cpp_internal(plVar3 + 4,lVar4);
                        cVar1 = GUILayout.Button(uVar2,plVar3,0);
                        if (cVar1) {
                          cVar1 = this.randomSpawns;
                          this.randomSpawns = !cVar1;
                          if (!cVar1) {
                            MonoBehaviour.StartCoroutine(this,"RandomSpawnsCoroutine",0);
                          }
                          else {
                            MonoBehaviour.StopCoroutine();
                          }
                        }
                        uVar2 = this.randomSpawnsDelay;
                        plVar3 = (int64 *)FUN_1801dfd90(DAT_181e82a00,1);
                        lVar4 = GUILayout.Width(0x42280000,0);
                        if (plVar3 != (int64 *)0) {
                          if (lVar4 != null) {
                            lVar5 = il2cpp_internal(lVar4,*(uint64 *)(*plVar3 + 64));
                            if (lVar5 == null) {
                              uVar2 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                              FUN_1801e02d0(uVar2,0);
                            }
                          }
                          if ((int)plVar3[3] == 0) {
                            uVar2 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                            FUN_1801e02d0(uVar2,0);
                          }
                          plVar3[4] = lVar4;
                          il2cpp_internal(plVar3 + 4,lVar4);
                          uVar2 = GUILayout.TextField(uVar2,10,plVar3);
                          this.randomSpawnsDelay = uVar2;
                          uVar2 = this.randomSpawnsDelay;
                          uVar2 = Regex.Replace(uVar2,"[^0-9.]","",0);
                          this.randomSpawnsDelay = uVar2;
                          lVar4 = Component.GetComponent(this,DAT_181e78338);
                          if (lVar4 != null) {
                            cVar1 = Renderer.get_enabled(lVar4,0);
                            uVar2 = "Show Ground";
                            if (cVar1) {
                              uVar2 = "Hide Ground";
                            }
                            plVar3 = (int64 *)FUN_1801dfd90(DAT_181e82a00,1);
                            lVar4 = GUILayout.Width(0x42b40000,0);
                            if (plVar3 != (int64 *)0) {
                              if (lVar4 != null) {
                                lVar5 = il2cpp_internal(lVar4,*(uint64 *)(*plVar3 + 64));
                                if (lVar5 == null) {
                                  uVar2 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                  FUN_1801e02d0(uVar2,0);
                                }
                              }
                              if ((int)plVar3[3] == 0) {
                                uVar2 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                FUN_1801e02d0(uVar2,0);
                              }
                              plVar3[4] = lVar4;
                              il2cpp_internal(plVar3 + 4,lVar4);
                              cVar1 = GUILayout.Button(uVar2,plVar3,0);
                              if (cVar1) {
                                lVar4 = Component.GetComponent(this,DAT_181e78338);
                                lVar5 = Component.GetComponent(this,DAT_181e78338);
                                if (lVar5 == null) goto LAB_1809384aa;
                                cVar1 = Renderer.get_enabled(lVar5,0);
                                if (lVar4 == null) goto LAB_1809384aa;
                                Renderer.set_enabled(lVar4,!cVar1,0);
                              }
                              uVar2 = "Slow Motion";
                              if (this.slowMo) {
                                uVar2 = "Normal Speed";
                              }
                              plVar3 = (int64 *)FUN_1801dfd90(DAT_181e82a00,1);
                              lVar4 = GUILayout.Width(0x42c80000,0);
                              if (plVar3 != (int64 *)0) {
                                if (lVar4 != null) {
                                  lVar5 = il2cpp_internal(lVar4,*(uint64 *)(*plVar3 + 64));
                                  if (lVar5 == null) {
                                    uVar2 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                    FUN_1801e02d0(uVar2,0);
                                  }
                                }
                                if ((int)plVar3[3] != 0) {
                                  plVar3[4] = lVar4;
                                  il2cpp_internal(plVar3 + 4,lVar4);
                                  cVar1 = GUILayout.Button(uVar2,plVar3,0);
                                  if (cVar1) {
                                    cVar1 = this.slowMo;
                                    this.slowMo = !cVar1;
                                    if (!cVar1) {
                                      uVar6 = 0x3ea8f5c3;
                                    }
                                    else {
                                      uVar6 = 0x3f800000;
                                    }
                                    Time.set_timeScale(uVar6,0);
                                  }
                                  GUILayout.EndHorizontal(0);
                                  GUILayout.EndArea(0);
                                  return;
                                }
                                uVar2 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                FUN_1801e02d0(uVar2,0);
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
        LAB_1809384aa:
                          // WARNING: Subroutine does not return
            FUN_1801e0300();
          }
        }
    }

    // Token : 0x6002478
    // RVA   : 0x938AA0   Offset: 0x9378A0   Length: 0x6C
    private IEnumerator RandomSpawnsCoroutine()
    {
        long lVar1;
        lVar1 = new WarpText_d__8(0,0);
        if (lVar1 != null) {
          *(uint64 *)(lVar1 + 32) = this;
          return lVar1;
        }
    }

    // Token : 0x6002479
    // RVA   : 0x938CB0   Offset: 0x937AB0   Length: 0x4B
    private void Update()
    {
        bool cVar1;
        cVar1 = FUN_181844860(0x114,0);
        if (cVar1) {
          CFX_Demo.prevParticle(this,0);
          return;
        }
        cVar1 = FUN_181844860(0x113);
        if (cVar1) {
          CFX_Demo.nextParticle(this,0);
          return;
        }
    }

    // Token : 0x600247A
    // RVA   : 0x939370   Offset: 0x938170   Length: 0x1C4
    private void prevParticle()
    {
        bool cVar1;
        uint uVar2;
        long lVar3;
        ulong uVar4;
        uVar2 = this.exampleIndex - 1;
        this.exampleIndex = uVar2;
        if ((int)uVar2 < 0) {
          if (this.ParticleExamples == null) throw; // [null/range check failed]
          uVar2 = *(int *)(this.ParticleExamples + 24) - 1;
          this.exampleIndex = uVar2;
        }
        lVar3 = this.ParticleExamples;
        if (lVar3 != null) {
          if (*(uint32 *)(lVar3 + 24) <= uVar2) {
            uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1801e02d0(uVar4,0);
          }
          lVar3 = lVar3[uVar2];
          if (lVar3 != null) {
            lVar3 = Object.get_name(lVar3,0);
            if (lVar3 != null) {
              cVar1 = String.Contains(lVar3,"Splash",0);
              if (!cVar1) {
                lVar3 = this.ParticleExamples;
                if (lVar3 == null) throw; // [null/range check failed]
                if (*(uint32 *)(lVar3 + 24) <= this.exampleIndex) {
                  uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1801e02d0(uVar4,0);
                }
                lVar3 = *(int64 *)(lVar3 + 32 + (int64)(int)this.exampleIndex * 8);
                if (lVar3 == null) throw; // [null/range check failed]
                uVar4 = Object.get_name(lVar3,0);
                cVar1 = FUN_1816387f0(uVar4,"CFX_Ripple",0);
                if (!cVar1) {
                  lVar3 = this.ParticleExamples;
                  if (lVar3 == null) throw; // [null/range check failed]
                  if (*(uint32 *)(lVar3 + 24) <= this.exampleIndex) {
                    uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                    FUN_1801e02d0(uVar4,0);
                  }
                  lVar3 = *(int64 *)(lVar3 + 32 + (int64)(int)this.exampleIndex * 8);
                  if (lVar3 == null) throw; // [null/range check failed]
                  uVar4 = Object.get_name(lVar3,0);
                  cVar1 = FUN_1816387f0(uVar4,"CFX_Fountain",0);
                  if (!cVar1) {
                    lVar3 = Component.GetComponent(this,DAT_181e78338);
                    if (lVar3 != null) {
                      FUN_180af99b0(lVar3,this.groundMat,0);
                      return;
                    }
                    throw; // [null/range check failed]
                  }
                }
              }
              lVar3 = Component.GetComponent(this,DAT_181e78338);
              if (lVar3 != null) {
                FUN_180af99b0(lVar3,this.waterMat,0);
                return;
              }
            }
          }
        }
    }

    // Token : 0x600247B
    // RVA   : 0x9391B0   Offset: 0x937FB0   Length: 0x1B6
    private void nextParticle()
    {
        bool cVar1;
        uint uVar2;
        long lVar3;
        ulong uVar4;
        lVar3 = this.ParticleExamples;
        uVar2 = this.exampleIndex + 1;
        this.exampleIndex = uVar2;
        if (lVar3 != null) {
          bVar5 = uVar2 < *(uint32 *)(lVar3 + 24);
          if ((int)*(uint32 *)(lVar3 + 24) <= (int)uVar2) {
            uVar2 = 0;
            this.exampleIndex = 0;
            bVar5 = *(int *)(lVar3 + 24) != 0;
          }
          if (!bVar5) {
            uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1801e02d0(uVar4,0);
          }
          lVar3 = lVar3[uVar2];
          if (lVar3 != null) {
            lVar3 = Object.get_name(lVar3,0);
            if (lVar3 != null) {
              cVar1 = String.Contains(lVar3,"Splash",0);
              if (!cVar1) {
                lVar3 = this.ParticleExamples;
                if (lVar3 == null) throw; // [null/range check failed]
                if (*(uint32 *)(lVar3 + 24) <= this.exampleIndex) {
                  uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1801e02d0(uVar4,0);
                }
                lVar3 = *(int64 *)(lVar3 + 32 + (int64)(int)this.exampleIndex * 8);
                if (lVar3 == null) throw; // [null/range check failed]
                uVar4 = Object.get_name(lVar3,0);
                cVar1 = FUN_1816387f0(uVar4,"CFX_Ripple",0);
                if (!cVar1) {
                  lVar3 = this.ParticleExamples;
                  if (lVar3 == null) throw; // [null/range check failed]
                  if (*(uint32 *)(lVar3 + 24) <= this.exampleIndex) {
                    uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                    FUN_1801e02d0(uVar4,0);
                  }
                  lVar3 = *(int64 *)(lVar3 + 32 + (int64)(int)this.exampleIndex * 8);
                  if (lVar3 == null) throw; // [null/range check failed]
                  uVar4 = Object.get_name(lVar3,0);
                  cVar1 = FUN_1816387f0(uVar4,"CFX_Fountain",0);
                  if (!cVar1) {
                    lVar3 = Component.GetComponent(this,DAT_181e78338);
                    if (lVar3 != null) {
                      FUN_180af99b0(lVar3,this.groundMat,0);
                      return;
                    }
                    throw; // [null/range check failed]
                  }
                }
              }
              lVar3 = Component.GetComponent(this,DAT_181e78338);
              if (lVar3 != null) {
                FUN_180af99b0(lVar3,this.waterMat,0);
                return;
              }
            }
          }
        }
    }

    // Token : 0x600247C
    // RVA   : 0x938D00   Offset: 0x937B00   Length: 0x4A6
    public void /*ctor*/()
    {
        long lVar1;
        this.orderedSpawns = 1;
        this.step = 0x3f800000;
        this.range = 0x40a00000;
        this.order = 0xc0a00000;
        lVar1 = il2cpp_internal(DAT_181e630c0);
        FUN_1806e5bc0(lVar1,DAT_181e566f8);
        if (lVar1 != null) {
          FUN_1816f1570(lVar1,"CFX_ElectricGround",0x3e19999a,DAT_181e56780);
          FUN_1816f1570(lVar1,"CFX_ElectricityBall",0x3f800000,DAT_181e56780);
          FUN_1816f1570(lVar1,"CFX_ElectricityBolt",0x3f800000,DAT_181e56780);
          FUN_1816f1570(lVar1,"CFX_Explosion",0x40000000,DAT_181e56780);
          FUN_1816f1570(lVar1,"CFX_SmallExplosion",0x3fc00000,DAT_181e56780);
          FUN_1816f1570(lVar1,"CFX_SmokeExplosion",0x40200000,DAT_181e56780);
          FUN_1816f1570(lVar1,"CFX_Flame",0x3f800000,DAT_181e56780);
          FUN_1816f1570(lVar1,"CFX_DoubleFlame",0x3f800000,DAT_181e56780);
          FUN_1816f1570(lVar1,"CFX_Hit",0x3f800000,DAT_181e56780);
          FUN_1816f1570(lVar1,"CFX_CircularLightWall",0x3d4ccccd,DAT_181e56780);
          FUN_1816f1570(lVar1,"CFX_LightWall",0x3d4ccccd,DAT_181e56780);
          FUN_1816f1570(lVar1,"CFX_Flash",0x40000000,DAT_181e56780);
          FUN_1816f1570(lVar1,"CFX_Poof",0x3fc00000,DAT_181e56780);
          FUN_1816f1570(lVar1,"CFX_Virus",0x3f800000,DAT_181e56780);
          FUN_1816f1570(lVar1,"CFX_SmokePuffs",0x40000000,DAT_181e56780);
          FUN_1816f1570(lVar1,"CFX_Slash",0x3f800000,DAT_181e56780);
          FUN_1816f1570(lVar1,"CFX_Splash",0x3d4ccccd,DAT_181e56780);
          FUN_1816f1570(lVar1,"CFX_Fountain",0x3d4ccccd,DAT_181e56780);
          FUN_1816f1570(lVar1,"CFX_Ripple",0x3d4ccccd,DAT_181e56780);
          FUN_1816f1570(lVar1,"CFX_Magic",0x40000000,DAT_181e56780);
          FUN_1816f1570(lVar1,"CFX_SoftStar",0x3f800000,DAT_181e56780);
          FUN_1816f1570(lVar1,"CFX_SpikyAura_Sphere",0x3f800000,DAT_181e56780);
          FUN_1816f1570(lVar1,"CFX_Firework",0x4019999a,DAT_181e56780);
          FUN_1816f1570(lVar1,"CFX_GroundA",0x3d4ccccd,DAT_181e56780);
          this.ParticlesYOffsetD = lVar1;
          this.randomSpawnsDelay = "0.5";
          FUN_180ae8740(this,0);
          return;
        }
    }

}
