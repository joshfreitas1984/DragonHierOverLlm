// ============================================================
// Type  : CFX_SpawnSystem
// Token : 0x20003BF
// ============================================================

public class CFX_SpawnSystem
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001D43
    private static CFX_SpawnSystem instance;

    // Token: 0x4001D44
    public GameObject[] objectsToPreload;

    // Token: 0x4001D45
    public int[] objectsToPreloadTimes;

    // Token: 0x4001D46
    public bool hideObjectsInHierarchy;

    // Token: 0x4001D47
    private bool allObjectsLoaded;

    // Token: 0x4001D48
    private Dictionary<int, List<GameObject>> instantiatedObjects;

    // Token: 0x4001D49
    private Dictionary<int, int> poolCursors;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6002378
    // RVA   : 0xBD5C00   Offset: 0xBD4400   Length: 0x532
    public static GameObject GetNextObject(GameObject sourceObj, bool activateObject)
    {
        var pStatics = *(int64*)(DAT_181d8fdc8 + 184);
        uint uVar1;
        bool cVar2;
        uint uVar3;
        int iVar4;
        long lVar5;
        long lVar7;
        ulong uVar8;
        uint[] local_res8 = new uint[2];
        if (sourceObj != null) {
          local_res8[0] = Object.GetInstanceID(sourceObj,0);
          if ((*pStatics != 0) &&
             (lVar5 = *(int64 *)(*pStatics + 56)) != null) {
            cVar2 = FUN_1808ab750(lVar5,local_res8[0],DAT_181d95278);
            if (!cVar2) {
              plVar6 = (int64 *)FUN_1800d60b0(DAT_181d80cc0,5);
              if (plVar6 != (int64 *)0) {
                if (("[CFX_SpawnSystem.GetNextPoolObject()] Object hasn't been preloaded: " != 0) &&
                   (lVar5 = il2cpp_internal("[CFX_SpawnSystem.GetNextPoolObject()] Object hasn't been preloaded: ",*(uint64 *)(*plVar6 + 64)), lVar5 == null
                   )) {
                  uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1800d65f0(uVar8,0);
                }
                lVar5 = "[CFX_SpawnSystem.GetNextPoolObject()] Object hasn't been preloaded: ";
                if ((int)plVar6[3] == 0) {
                  uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1800d65f0(uVar8,0);
                }
                plVar6[4] = "[CFX_SpawnSystem.GetNextPoolObject()] Object hasn't been preloaded: ";
                il2cpp_internal(plVar6 + 4,lVar5);
                lVar5 = Object.get_name(sourceObj,0);
                if ((lVar5 != null) &&
                   (lVar7 = il2cpp_internal(lVar5,*(uint64 *)(*plVar6 + 64))) == null) {
                  uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1800d65f0(uVar8,0);
                }
                if (*(uint32 *)(plVar6 + 3) < 2) {
                  uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1800d65f0(uVar8,0);
                }
                plVar6[5] = lVar5;
                il2cpp_internal(plVar6 + 5,lVar5);
                if ((" (ID:" != 0) &&
                   (lVar5 = il2cpp_internal(" (ID:",*(uint64 *)(*plVar6 + 64)), lVar5 == null
                   )) {
                  uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1800d65f0(uVar8,0);
                }
                lVar5 = " (ID:";
                if (*(uint32 *)(plVar6 + 3) < 3) {
                  uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1800d65f0(uVar8,0);
                }
                plVar6[6] = " (ID:";
                il2cpp_internal(plVar6 + 6,lVar5);
                lVar5 = Int32.ToString(local_res8,0);
                if ((lVar5 != null) &&
                   (lVar7 = il2cpp_internal(lVar5,*(uint64 *)(*plVar6 + 64))) == null) {
                  uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1800d65f0(uVar8,0);
                }
                if (*(uint32 *)(plVar6 + 3) < 4) {
                  uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1800d65f0(uVar8,0);
                }
                plVar6[7] = lVar5;
                il2cpp_internal(plVar6 + 7,lVar5);
                if ((")" != 0) &&
                   (lVar5 = il2cpp_internal(")",*(uint64 *)(*plVar6 + 64)), lVar5 == null
                   )) {
                  uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1800d65f0(uVar8,0);
                }
                lVar5 = ")";
                if (4 < *(uint32 *)(plVar6 + 3)) {
                  plVar6[8] = ")";
                  il2cpp_internal(plVar6 + 8,lVar5);
                  uVar8 = String.Concat(plVar6,0);
                  Debug.LogError(uVar8,0);
                  return false;
                }
                uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar8,0);
              }
            }
            else if ((*pStatics != 0) &&
                    (lVar5 = *(int64 *)(*pStatics + 56)) != null) {
              uVar3 = FUN_181408420(lVar5,local_res8[0],DAT_181d958d0);
              uVar1 = local_res8[0];
              if ((*pStatics != 0) &&
                 (lVar5 = *(int64 *)(*pStatics + 56)) != null) {
                iVar4 = FUN_181408420(lVar5,local_res8[0],DAT_181d958d0);
                FUN_1808aec90(lVar5,uVar1,iVar4 + 1,DAT_181d959e0);
                if ((*pStatics != 0) &&
                   (lVar5 = *(int64 *)(*pStatics + 56)) != null) {
                  iVar4 = FUN_181408420(lVar5,local_res8[0],DAT_181d958d0);
                  if ((*pStatics != 0) &&
                     ((lVar5 = *(int64 *)(*pStatics + 48), lVar5 != null &&
                      (lVar5 = FUN_1817cc780(lVar5,local_res8[0],DAT_181d919b8)) != null))) {
                    if (*(int *)(lVar5 + 24) <= iVar4) {
                      if ((*pStatics == 0) ||
                         (lVar5 = *(int64 *)(*pStatics + 56)) == null
                         ) throw; // [null/range check failed]
                      FUN_1808aec90(lVar5,local_res8[0],0,DAT_181d959e0);
                    }
                    if (((*pStatics != 0) &&
                        (lVar5 = *(int64 *)(*pStatics + 48)) != null)
                       && (lVar5 = FUN_1817cc780(lVar5,local_res8[0],DAT_181d919b8)) != null) {
                      if (*(uint32 *)(lVar5 + 24) <= uVar3) {
                        ThrowHelper.ThrowArgumentOutOfRangeException(0);
                      }
                      lVar5 = lVar5[uVar3]
                      ;
                      if (activateObject) {
                        if (lVar5 == null) throw; // [null/range check failed]
                        GameObject.SetActive(lVar5,1,0);
                      }
                      return lVar5;
                    }
                  }
                }
              }
            }
          }
        }
    }

    // Token : 0x6002379
    // RVA   : 0xBD6140   Offset: 0xBD4940   Length: 0x5E
    public static void PreloadObject(GameObject sourceObj, int poolSize)
    {
        var pStatics = *(int64*)(DAT_181d8fdc8 + 184);
        if (*pStatics != 0) {
          CFX_SpawnSystem.addObjectToPool(*pStatics,sourceObj,poolSize,0);
          return;
        }
    }

    // Token : 0x600237A
    // RVA   : 0xBD62A0   Offset: 0xBD4AA0   Length: 0x50
    public static void UnloadObjects(GameObject sourceObj)
    {
        var pStatics = *(int64*)(DAT_181d8fdc8 + 184);
        if (*pStatics != 0) {
          CFX_SpawnSystem.removeObjectsFromPool(*pStatics,sourceObj,0);
          return;
        }
    }

    // Token : 0x600237B
    // RVA   : 0xBD66D0   Offset: 0xBD4ED0   Length: 0x44
    public static bool get_AllObjectsLoaded()
    {
        var pStatics = *(int64*)(DAT_181d8fdc8 + 184);
        if (*pStatics != 0) {
          return *(uint8 *)(*pStatics + 41);
        }
    }

    // Token : 0x600237C
    // RVA   : 0xBD6410   Offset: 0xBD4C10   Length: 0x2BA
    private void addObjectToPool(GameObject sourceObject, int number)
    {
        long lVar1;
        bool cVar2;
        uint uVar3;
        ulong uVar4;
        long lVar5;
        long lVar6;
        uint uVar7;
        int iVar8;
        if (sourceObject != null) {
          uVar3 = Object.GetInstanceID(sourceObject,0);
          if (this.instantiatedObjects != null) {
            cVar2 = FUN_1808ab750(this.instantiatedObjects,uVar3,DAT_181d918a8);
            if (cVar2) {
        LAB_180bd655d:
              iVar8 = 0;
              if (0 < number) {
                do {
                  lVar5 = Object.Instantiate(sourceObject,DAT_181d69cf8);
                  if (lVar5 == null) throw; // [null/range check failed]
                  GameObject.SetActive(lVar5,0,0);
                  lVar6 = GameObject.GetComponentsInChildren(lVar5,1,DAT_181da32b0);
                  uVar7 = 0;
                  while( true ) {
                    if (lVar6 == null) throw; // [null/range check failed]
                    if ((int)*(uint32 *)(lVar6 + 24) <= (int)uVar7) break;
                    if (*(uint32 *)(lVar6 + 24) <= uVar7) {
                      uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                      FUN_1800d65f0(uVar4,0);
                    }
                    lVar1 = lVar6[uVar7];
                    if (lVar1 == null) throw; // [null/range check failed]
                    *(uint8 *)(lVar1 + 24) = 1;
                    uVar7 = uVar7 + 1;
                  }
                  lVar6 = GameObject.GetComponentsInChildren(lVar5,1,DAT_181da3330);
                  uVar7 = 0;
                  while( true ) {
                    if (lVar6 == null) throw; // [null/range check failed]
                    if ((int)*(uint32 *)(lVar6 + 24) <= (int)uVar7) break;
                    if (*(uint32 *)(lVar6 + 24) <= uVar7) {
                      uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                      FUN_1800d65f0(uVar4,0);
                    }
                    lVar1 = lVar6[uVar7];
                    if (lVar1 == null) throw; // [null/range check failed]
                    *(uint8 *)(lVar1 + 40) = 0;
                    uVar7 = uVar7 + 1;
                  }
                  if ((this.instantiatedObjects == null) ||
                     (lVar6 = FUN_1817cc780(this.instantiatedObjects,uVar3,DAT_181d919b8), lVar6 == null
                     )) throw; // [null/range check failed]
                  FUN_181827900(lVar6,lVar5);
                  if (this.hideObjectsInHierarchy) {
                    Object.set_hideFlags(lVar5,1);
                  }
                  iVar8 = iVar8 + 1;
                } while (iVar8 < number);
              }
              return;
            }
            lVar5 = this.instantiatedObjects;
            uVar4 = il2cpp_internal(DAT_181d6e2b0);
            FUN_180f58a90(uVar4,DAT_181d61af8);
            if (lVar5 != null) {
              FUN_1808ab680(lVar5,uVar3,uVar4,DAT_181d91820);
              if (this.poolCursors != null) {
                FUN_1808ab680(this.poolCursors,uVar3,0,DAT_181d95168);
                goto LAB_180bd655d;
              }
            }
          }
        }
    }

    // Token : 0x600237D
    // RVA   : 0xBD6720   Offset: 0xBD4F20   Length: 0x489
    private void removeObjectsFromPool(GameObject sourceObject)
    {
        bool cVar1;
        long lVar2;
        long lVar3;
        ulong uVar5;
        uint uVar6;
        uint[] local_res10 = new uint[2];
        if (sourceObject != null) {
          local_res10[0] = Object.GetInstanceID(sourceObject,0);
          if (this.instantiatedObjects != null) {
            cVar1 = FUN_1808ab750(this.instantiatedObjects,local_res10[0],DAT_181d918a8);
            if (!cVar1) {
              plVar4 = (int64 *)FUN_1800d60b0(DAT_181d80cc0,5);
              if (plVar4 != (int64 *)0) {
                if (("[CFX_SpawnSystem.removeObjectsFromPool()] There aren't any preloaded object for: " != 0) &&
                   (lVar2 = il2cpp_internal("[CFX_SpawnSystem.removeObjectsFromPool()] There aren't any preloaded object for: ",*(uint64 *)(*plVar4 + 64)), lVar2 == null
                   )) {
                  uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1800d65f0(uVar5,0);
                }
                lVar2 = "[CFX_SpawnSystem.removeObjectsFromPool()] There aren't any preloaded object for: ";
                if ((int)plVar4[3] == 0) {
                  uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1800d65f0(uVar5,0);
                }
                plVar4[4] = "[CFX_SpawnSystem.removeObjectsFromPool()] There aren't any preloaded object for: ";
                il2cpp_internal(plVar4 + 4,lVar2);
                lVar2 = Object.get_name(sourceObject,0);
                if ((lVar2 != null) &&
                   (lVar3 = il2cpp_internal(lVar2,*(uint64 *)(*plVar4 + 64))) == null) {
                  uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1800d65f0(uVar5,0);
                }
                if (*(uint32 *)(plVar4 + 3) < 2) {
                  uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1800d65f0(uVar5,0);
                }
                plVar4[5] = lVar2;
                il2cpp_internal(plVar4 + 5,lVar2);
                if ((" (ID:" != 0) &&
                   (lVar2 = il2cpp_internal(" (ID:",*(uint64 *)(*plVar4 + 64)), lVar2 == null
                   )) {
                  uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1800d65f0(uVar5,0);
                }
                lVar2 = " (ID:";
                if (*(uint32 *)(plVar4 + 3) < 3) {
                  uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1800d65f0(uVar5,0);
                }
                plVar4[6] = " (ID:";
                il2cpp_internal(plVar4 + 6,lVar2);
                lVar2 = Int32.ToString(local_res10,0);
                if ((lVar2 != null) &&
                   (lVar3 = il2cpp_internal(lVar2,*(uint64 *)(*plVar4 + 64))) == null) {
                  uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1800d65f0(uVar5,0);
                }
                if (*(uint32 *)(plVar4 + 3) < 4) {
                  uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1800d65f0(uVar5,0);
                }
                plVar4[7] = lVar2;
                il2cpp_internal(plVar4 + 7,lVar2);
                if ((")" != 0) &&
                   (lVar2 = il2cpp_internal(")",*(uint64 *)(*plVar4 + 64)), lVar2 == null
                   )) {
                  uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1800d65f0(uVar5,0);
                }
                lVar2 = ")";
                if (4 < *(uint32 *)(plVar4 + 3)) {
                  plVar4[8] = ")";
                  il2cpp_internal(plVar4 + 8,lVar2);
                  uVar5 = String.Concat(plVar4,0);
                  Debug.LogWarning(uVar5,0);
                  return;
                }
                uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar5,0);
              }
            }
            else if ((this.instantiatedObjects != null) &&
                    (lVar2 = FUN_1817cc780(this.instantiatedObjects,local_res10[0],DAT_181d919b8),
                    lVar2 != null)) {
              uVar6 = *(int *)(lVar2 + 24) - 1;
              if (-1 < (int)uVar6) {
                lVar2 = (int64)(int)uVar6 * 8 + 32;
                do {
                  if ((this.instantiatedObjects == null) ||
                     (lVar3 = FUN_1817cc780(this.instantiatedObjects,local_res10[0],DAT_181d919b8),
                     lVar3 == null)) throw; // [null/range check failed]
                  if (*(uint32 *)(lVar3 + 24) <= uVar6) {
                    ThrowHelper.ThrowArgumentOutOfRangeException(0);
                  }
                  uVar5 = *(uint64 *)(lVar2 + *(int64 *)(lVar3 + 16));
                  if ((this.instantiatedObjects == null) ||
                     (lVar3 = FUN_1817cc780(this.instantiatedObjects,local_res10[0],DAT_181d919b8),
                     lVar3 == null)) throw; // [null/range check failed]
                  FUN_18182b220(lVar3,uVar6,DAT_181d61ef8);
                  Object.Destroy(uVar5,0);
                  lVar2 = lVar2 + -8;
                  uVar6 = uVar6 - 1;
                } while (-1 < (int)uVar6);
              }
              if (this.instantiatedObjects != null) {
                FUN_18173cb80(this.instantiatedObjects,local_res10[0],DAT_181d91930);
                if (this.poolCursors != null) {
                  FUN_1813fed40(this.poolCursors,local_res10[0],DAT_181d955a0);
                  return;
                }
              }
            }
          }
        }
    }

    // Token : 0x600237E
    // RVA   : 0xBD5B20   Offset: 0xBD4320   Length: 0xDC
    private void Awake()
    {
        ulong uVar1;
        bool cVar3;
        uVar1 = **(uint64 **)(DAT_181d8fdc8 + 184);
        cVar3 = Object.op_Inequality(uVar1,0,0);
        if (cVar3) {
          Debug.LogWarning("CFX_SpawnSystem: There should only be one instance of CFX_SpawnSystem per Scene!",0);
        }
        puVar2 = *(uint64 **)(DAT_181d8fdc8 + 184);
        *puVar2 = this;
        il2cpp_internal(puVar2,this);
    }

    // Token : 0x600237F
    // RVA   : 0xBD61A0   Offset: 0xBD49A0   Length: 0xF8
    private void Start()
    {
        var pStatics = *(int64*)(DAT_181d8fdc8 + 184);
        uint uVar1;
        long lVar2;
        ulong uVar3;
        uint uVar4;
        this.allObjectsLoaded = 0;
        uVar4 = 0;
        lVar2 = this.objectsToPreload;
        while (lVar2 != null) {
          if (*(int *)(lVar2 + 24) <= (int)uVar4) {
            this.allObjectsLoaded = 1;
            return;
          }
          if (lVar2 == null) break;
          if (*(uint32 *)(lVar2 + 24) <= uVar4) {
            uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar3,0);
          }
          uVar3 = lVar2[uVar4];
          lVar2 = this.objectsToPreloadTimes;
          if (lVar2 == null) break;
          if (*(uint32 *)(lVar2 + 24) <= uVar4) {
            uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar3,0);
          }
          uVar1 = lVar2[uVar4];
          if (*pStatics == 0) break;
          CFX_SpawnSystem.addObjectToPool(*pStatics,uVar3,uVar1,0);
          uVar4 = uVar4 + 1;
          lVar2 = this.objectsToPreload;
        }
    }

    // Token : 0x6002380
    // RVA   : 0xBD6300   Offset: 0xBD4B00   Length: 0x10D
    public void /*ctor*/()
    {
        ulong uVar1;
        uVar1 = FUN_1800d60b0(DAT_181d7db00,0);
        this.objectsToPreload = uVar1;
        uVar1 = FUN_1800d60b0(DAT_181d7e600,0);
        this.objectsToPreloadTimes = uVar1;
        uVar1 = il2cpp_internal(DAT_181d5bd48);
        FUN_1808ae540(uVar1,DAT_181d91798);
        this.instantiatedObjects = uVar1;
        uVar1 = il2cpp_internal(DAT_181d5c6c8);
        FUN_1808ae540(uVar1,DAT_181d94fd0);
        this.poolCursors = uVar1;
        FUN_18044ef50(this,0);
    }

}
