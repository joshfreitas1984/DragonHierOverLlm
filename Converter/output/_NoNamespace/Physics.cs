// ============================================================
// Type  : Physics
// Token : 0x2000492
// ============================================================

public class Physics
{
    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6002777
    // RVA   : 0x92ACD0   Offset: 0x92A0D0   Length: 0xE0
    public static void SetOrientationOnPath(PathOptions options, Tween t, Quaternion newRot, Transform trans)
    {
        void Physics.SetOrientationOnPath
                     (int64 options,int64 t,uint32 *newRot,int64 trans)
        {
        int64 *plVar1;
        uint32 local_88;
        uint32 uStack_84;
        uint32 uStack_80;
        uint32 uStack_7c;
        if (*(char *)(options + 80) == false) {
          if (trans != null) {
            local_88 = *newRot;
            uStack_84 = newRot[1];
            uStack_80 = newRot[2];
            uStack_7c = newRot[3];
            Transform.set_rotation(trans,&local_88,0);
            return;
          }
        }
        else if ((t != null) && (plVar1 = *(int64 **)(t + 72), plVar1 != (int64 *)0)) {
          if ((*(byte *)(DAT_181d9cd80 + 300) <= *(byte *)(*plVar1 + 300)) &&
             (*(int64 *)
               (*(int64 *)(*plVar1 + 200) + -8 + (uint64)*(byte *)(DAT_181d9cd80 + 300) * 8) ==
              DAT_181d9cd80)) {
            local_88 = *newRot;
            uStack_84 = newRot[1];
            uStack_80 = newRot[2];
            uStack_7c = newRot[3];
            Rigidbody.set_rotation(plVar1,&local_88,0);
            return;
          }
                          // WARNING: Subroutine does not return
          FUN_1800d6070(plVar1);
        }
    }

    // Token : 0x6002778
    // RVA   : 0x92ABD0   Offset: 0x929FD0   Length: 0x7D
    public static bool HasRigidbody2D(Component target)
    {
        ulong uVar1;
        if (target != null) {
          uVar1 = Component.GetComponent(target,DAT_181d95160);
          Object.op_Inequality(uVar1,0,0);
          return;
        }
    }

    // Token : 0x6002779
    // RVA   : 0x92AC50   Offset: 0x92A050   Length: 0x7D
    public static bool HasRigidbody(Component target)
    {
        ulong uVar1;
        if (target != null) {
          uVar1 = Component.GetComponent(target,DAT_181d950e0);
          Object.op_Inequality(uVar1,0,0);
          return;
        }
    }

    // Token : 0x600277A
    // RVA   : 0x92AA00   Offset: 0x929E00   Length: 0x1CE
    public static TweenerCore<Vector3, Path, PathOptions> CreateDOTweenPathTween(MonoBehaviour target, bool tweenRigidbody, bool isLocal, Path path, float duration, PathMode pathMode)
    {
        uint64
        Physics.CreateDOTweenPathTween
                (int64 target,byte tweenRigidbody,char isLocal,uint64 path,uint32 duration,
                uint32 pathMode)
        {
        char cVar1;
        uint64 uVar2;
        uint64 uVar3;
        byte bVar4;
        uVar3 = 0;
        bVar4 = 0;
        if (tweenRigidbody != null) {
          if (target == null) throw; // [null/range check failed]
          uVar2 = Component.GetComponent(target,DAT_181d950e0);
          cVar1 = Object.op_Inequality(uVar2,0,0);
          if (cVar1) {
            bVar4 = 1;
            if (!isLocal) {
              uVar3 = DOTweenModulePhysics.DOPath(uVar2,path,duration,pathMode,0);
            }
            else {
              uVar3 = DOTweenModulePhysics.DOLocalPath();
            }
          }
          if ((tweenRigidbody & (bVar4 ^ 1)) != 0) {
            uVar2 = Component.GetComponent(target,DAT_181d95160);
            cVar1 = Object.op_Inequality(uVar2,0,0);
            if (cVar1) {
              if (isLocal) {
                uVar3 = DOTweenModulePhysics2D.DOLocalPath();
                return uVar3;
              }
              uVar3 = DOTweenModulePhysics2D.DOPath(uVar2,path,duration,pathMode,0);
              return uVar3;
            }
          }
          if (bVar4 != 0) {
            return uVar3;
          }
        }
        if (target != null) {
          uVar3 = Component.get_transform(target,0);
          if (!isLocal) {
            uVar3 = ShortcutExtensions.DOPath(uVar3,path,duration,pathMode,0);
          }
          else {
            uVar3 = ShortcutExtensions.DOLocalPath();
          }
          return uVar3;
        }
    }

}
