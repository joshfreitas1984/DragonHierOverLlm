// ============================================================
// Type  : StudyDodgePlayer
// Token : 0x200037C
// ============================================================

public class StudyDodgePlayer
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001C81
    public GameObject playerGrid;

    // Token: 0x4001C82
    public SkeletonAnimation playerSkeleton;

    // Token: 0x4001C83
    public GameObject hipPos;

    // Token: 0x4001C84
    public float shieldTime;

    // Token: 0x4001C85
    public GameObject shieldSpe;

    // Token: 0x4001C86
    public bool moving;

    // Token: 0x4001C87
    public GameObject moveTarget;

    // Token: 0x4001C88
    private Tween moveTween;

    // Token: 0x4001C89
    private float moveStartRealtime;

    // Token: 0x4001C8A
    private const float MoveTimeLimit;

    // Token: 0x4001C8B
    private GameObject newObj;

    // Token: 0x4001C8C
    private static StudyDodgePlayer _instance;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x600222E
    // RVA   : 0xFD7970   Offset: 0xFD6D70   Length: 0x36
    public static StudyDodgePlayer get_Instance()
    {
        return **(uint64 **)(DAT_181da8010 + 184);
    }

    // Token : 0x600222F
    // RVA   : 0xFD4E60   Offset: 0xFD4260   Length: 0x43
    private void Awake()
    {
        puVar1 = *(uint64 **)(DAT_181da8010 + 184);
        *puVar1 = this;
        il2cpp_internal(puVar1,this);
    }

    // Token : 0x6002230
    // RVA   : 0xFD71E0   Offset: 0xFD65E0   Length: 0x52
    private void Start()
    {
        long lVar1;
        lVar1 = Component.GetComponent(this,DAT_181d93e60);
        if (lVar1 != null) {
          FootStepController.Init(lVar1,this.playerSkeleton,0);
          return;
        }
    }

    // Token : 0x6002231
    // RVA   : 0xFD7240   Offset: 0xFD6640   Length: 0x723
    private void Update()
    {
        var pStatics = *(int64*)(DAT_181dadcf8 + 184);
        bool cVar1;
        ulong uVar2;
        ulong uVar3;
        long lVar4;
        int iVar6;
        int iVar7;
        float fVar8;
        float fVar9;
        ulong local_38;
        uint local_30;
        if ((this.moving) &&
           (fVar8 = (float)Time.get_realtimeSinceStartup(0), 6.0 < fVar8 - this.moveStartRealtime)) {
          uVar3 = this.playerGrid;
          cVar1 = Object.op_Equality(uVar3,0,0);
          uVar3 = "[StudyDodge] 移动超时，强制复位 moving。playerGrid=";
          uVar2 = "null";
          if (!cVar1) {
            if (this.playerGrid == null) goto LAB_180fd795e;
            uVar2 = Object.get_name(this.playerGrid,0);
          }
          uVar3 = String.Concat(uVar3,uVar2,0);
          Debug.LogWarning(uVar3,0);
          if (this.moveTween != null) {
            TweenExtensions.Kill(this.moveTween,0,0);
            this.moveTween = 0;
          }
          this.moveTarget = 0;
          uVar3 = this.playerSkeleton;
          this.moving = 0;
          cVar1 = Object.op_Inequality(uVar3,0,0);
          if (cVar1) {
            if (this.playerSkeleton == null) goto LAB_180fd795e;
            lVar4 = SkeletonAnimation.get_AnimationState(this.playerSkeleton,0);
            if (lVar4 != null) {
              if ((this.playerSkeleton == null) ||
                 (lVar4 = SkeletonAnimation.get_AnimationState(this.playerSkeleton,0),
                 lVar4 == null)) goto LAB_180fd795e;
              AnimationState.SetAnimation(lVar4,0,"idle",1,0);
            }
          }
          uVar3 = this.playerGrid;
          cVar1 = Object.op_Inequality(uVar3,0,0);
          if (cVar1) {
            if ((this.playerGrid == null) ||
               (lVar4 = GameObject.get_transform(this.playerGrid,0)) == null)
            goto LAB_180fd795e;
            puVar5 = (uint64 *)Transform.get_localPosition(&local_38,lVar4,0);
            uVar3 = *puVar5;
            local_30 = *(uint32 *)(puVar5 + 1);
            lVar4 = Component.get_transform(this,0);
            local_38 = uVar3;
            if (lVar4 == null) goto LAB_180fd795e;
            local_30 = 0xbe4ccccd;
            Transform.set_localPosition(lVar4,&local_38,0);
          }
        }
        lVar4 = *(int64 *)(*(int64 *)(DAT_181da8090 + 184) + 8);
        if (lVar4 == null) goto LAB_180fd795e;
        if (*(char *)(lVar4 + 25) != false) {
          return;
        }
        fVar8 = this.shieldTime;
        if (0.0 < fVar8) {
          fVar9 = (float)Time.get_deltaTime(0);
          fVar8 = fVar8 - fVar9;
          this.shieldTime = fVar8;
          if (fVar8 <= 0.0) {
            StudyDodgePlayer.SetShieldTime(this,0,0);
          }
        }
        if (this.moving) {
          return;
        }
        uVar3 = this.playerGrid;
        cVar1 = Object.op_Inequality(uVar3,0,0);
        if (!cVar1) {
          return;
        }
        if (*pStatics == 0) goto LAB_180fd795e;
        if (*(char *)(*pStatics + 56) != false) {
          return;
        }
        cVar1 = GlobalData.GetKeyDown(119);
        if (cVar1) {
          if ((this.playerGrid == null) ||
             (lVar4 = GameObject.GetComponent(this.playerGrid,DAT_181d73dd8)) == null)
          goto LAB_180fd795e;
          iVar6 = *(int *)(lVar4 + 28);
          lVar4 = FUN_180fd09b0(0);
          if (lVar4 == null) goto LAB_180fd795e;
          if (iVar6 < *(int *)(lVar4 + 68) + -1) {
            if ((this.playerGrid == null) ||
               (lVar4 = GameObject.GetComponent(this.playerGrid,DAT_181d73dd8)) == null
               ) goto LAB_180fd795e;
            iVar6 = *(int *)(lVar4 + 24);
            if ((this.playerGrid == null) ||
               (lVar4 = GameObject.GetComponent(this.playerGrid,DAT_181d73dd8)) == null
               ) goto LAB_180fd795e;
            iVar7 = *(int *)(lVar4 + 28) + 1;
            goto LAB_180fd787d;
          }
        }
        cVar1 = GlobalData.GetKeyDown(115);
        if (cVar1) {
          if ((this.playerGrid == null) ||
             (lVar4 = GameObject.GetComponent(this.playerGrid,DAT_181d73dd8)) == null)
          goto LAB_180fd795e;
          if (0 < *(int *)(lVar4 + 28)) {
            if ((this.playerGrid == null) ||
               (lVar4 = GameObject.GetComponent(this.playerGrid,DAT_181d73dd8)) == null
               ) goto LAB_180fd795e;
            iVar6 = *(int *)(lVar4 + 24);
            if ((this.playerGrid == null) ||
               (lVar4 = GameObject.GetComponent(this.playerGrid,DAT_181d73dd8)) == null
               ) goto LAB_180fd795e;
            iVar7 = *(int *)(lVar4 + 28) + -1;
            goto LAB_180fd787d;
          }
        }
        cVar1 = GlobalData.GetKeyDown(97);
        if (!cVar1) {
        LAB_180fd789b:
          cVar1 = GlobalData.GetKeyDown(100);
          if (!cVar1) {
            return;
          }
          if ((this.playerGrid == null) ||
             (lVar4 = GameObject.GetComponent(this.playerGrid,DAT_181d73dd8)) == null)
          {
        LAB_180fd795e:
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          iVar6 = *(int *)(lVar4 + 24);
          lVar4 = FUN_180fd09b0(0);
          if (lVar4 == null) goto LAB_180fd795e;
          if (*(int *)(lVar4 + 64) + -1 <= iVar6) {
            return;
          }
          if ((this.playerGrid == null) ||
             (lVar4 = GameObject.GetComponent(this.playerGrid,DAT_181d73dd8)) == null)
          goto LAB_180fd795e;
          iVar6 = *(int *)(lVar4 + 24);
          if ((this.playerGrid == null) ||
             (lVar4 = GameObject.GetComponent(this.playerGrid,DAT_181d73dd8)) == null)
          goto LAB_180fd795e;
          iVar6 = iVar6 + 1;
        }
        else {
          if ((this.playerGrid == null) ||
             (lVar4 = GameObject.GetComponent(this.playerGrid,DAT_181d73dd8)) == null)
          goto LAB_180fd795e;
          if (*(int *)(lVar4 + 24) < 1) goto LAB_180fd789b;
          if ((this.playerGrid == null) ||
             (lVar4 = GameObject.GetComponent(this.playerGrid,DAT_181d73dd8)) == null)
          goto LAB_180fd795e;
          iVar6 = *(int *)(lVar4 + 24);
          if ((this.playerGrid == null) ||
             (lVar4 = GameObject.GetComponent(this.playerGrid,DAT_181d73dd8)) == null)
          goto LAB_180fd795e;
          iVar6 = iVar6 + -1;
        }
        iVar7 = *(int *)(lVar4 + 28);
        LAB_180fd787d:
        StudyDodgePlayer.PlayerEnterGrid(this,iVar6,iVar7,0);
    }

    // Token : 0x6002232
    // RVA   : 0xFD6260   Offset: 0xFD5660   Length: 0xB27
    public void PlayerEnterGrid(int column, int row)
    {
        var pStatics = *(int64*)(DAT_181da8090 + 184);
        long lVar1;
        bool cVar2;
        int iVar3;
        long lVar4;
        long lVar5;
        ulong uVar6;
        ulong uVar9;
        ulong uVar11;
        uint uVar14;
        float fVar15;
        float local_68;
        int local_64;
        int[] local_60 = new int[2];
        ulong local_58;
        uint local_50;
        uint local_48;
        uint uStack_44;
        uint uStack_40;
        uint32 uStack_3c;
        uVar6 = *(uint64 *)(pStatics + 8);
        cVar2 = Object.op_Equality(uVar6,0,0);
        if (!cVar2) {
          lVar4 = *(int64 *)(pStatics + 8);
          if (lVar4 == null) goto LAB_180fd6d82;
          if (*(int64 *)(lVar4 + 144) != 0) {
            if ((column < 0) || (row < 0)) {
        LAB_180fd6cf2:
              local_60[0] = column;
              uVar9 = il2cpp_value_box(DAT_181d80418,local_60);
              local_64 = row;
              uVar11 = il2cpp_value_box(DAT_181d80418,&local_64);
              uVar6 = "[StudyDodge] PlayerEnterGrid 越界：{0},{1}";
            }
            else {
              lVar4 = FUN_180fd09b0(0);
              if ((lVar4 == null) || (*(int64 *)(lVar4 + 144) == 0)) goto LAB_180fd6d82;
              iVar3 = Array.GetLength(*(int64 *)(lVar4 + 144),0,0);
              if (iVar3 <= column) goto LAB_180fd6cf2;
              lVar4 = FUN_180fd09b0(0);
              if ((lVar4 == null) || (*(int64 *)(lVar4 + 144) == 0)) goto LAB_180fd6d82;
              iVar3 = Array.GetLength(*(int64 *)(lVar4 + 144),1);
              if (iVar3 <= row) goto LAB_180fd6cf2;
              lVar4 = FUN_180fd09b0(0);
              if ((lVar4 == null) || (*(int64 *)(lVar4 + 144) == 0)) goto LAB_180fd6d82;
              lVar4 = FUN_180127f90(*(int64 *)(lVar4 + 144),(int64)column,(int64)row);
              cVar2 = Object.op_Equality(lVar4,0,0);
              if (!cVar2) {
                uVar6 = this.playerGrid;
                cVar2 = Object.op_Inequality(uVar6,0,0);
                if (cVar2) {
                  uVar6 = this.playerSkeleton;
                  cVar2 = Object.op_Inequality(uVar6,0,0);
                  if (cVar2) {
                    if ((this.playerGrid == null) ||
                       (lVar5 = GameObject.GetComponent(this.playerGrid,DAT_181d73dd8),
                       lVar5 == null)) goto LAB_180fd6d82;
                    if (*(int *)(lVar5 + 24) < column) {
                      if (this.playerSkeleton == null) goto LAB_180fd6d82;
                      lVar5 = Component.get_transform(this.playerSkeleton,0);
                      puVar7 = (uint32 *)Quaternion.get_identity(&local_48,0);
                      if (lVar5 == null) goto LAB_180fd6d82;
                      local_48 = *puVar7;
                      uStack_44 = puVar7[1];
                      uStack_40 = puVar7[2];
                      uStack_3c = puVar7[3];
                    }
                    else {
                      if ((this.playerGrid == null) ||
                         (lVar5 = GameObject.GetComponent(this.playerGrid,DAT_181d73dd8),
                         lVar5 == null)) goto LAB_180fd6d82;
                      if (*(int *)(lVar5 + 24) <= column) goto LAB_180fd676d;
                      if (this.playerSkeleton == null) goto LAB_180fd6d82;
                      lVar5 = Component.get_transform(this.playerSkeleton,0);
                      lVar1 = *(int64 *)(DAT_181d73d40 + 184);
                      if (lVar5 == null) goto LAB_180fd6d82;
                      local_48 = *(uint32 *)(lVar1 + 0x690);
                      uStack_44 = *(uint32 *)(lVar1 + 0x694);
                      uStack_40 = *(uint32 *)(lVar1 + 0x698);
                      uStack_3c = *(uint32 *)(lVar1 + 0x69c);
                    }
                    Transform.set_localRotation(lVar5,&local_48,0);
                  }
                }
        LAB_180fd676d:
                local_68 = 0.0;
                lVar5 = FUN_18046c0a0(0);
                if (((lVar5 != null) && (*(int64 *)(lVar5 + 32) != 0)) &&
                   (lVar5 = WorldData.Player(*(int64 *)(lVar5 + 32),0)) != null) {
                  lVar5 = *(int64 *)(lVar5 + 0x150);
                  if ((lVar5 != null) && (1 < (int)*(uint32 *)(lVar5 + 24))) {
                    if (*(uint32 *)(lVar5 + 24) < 2) {
                      ThrowHelper.ThrowArgumentOutOfRangeException(0);
                    }
                    local_68 = *(float *)(*(int64 *)(lVar5 + 16) + 36);
                  }
                  cVar2 = Single.IsNaN(local_68,0);
                  if (((cVar2) || (cVar2 = Single.IsInfinity(local_68,0), cVar2)) ||
                     (local_68 < 0.0)) {
                    uVar6 = Single.ToString(&local_68,0);
                    uVar6 = String.Concat("[StudyDodge] totalFightSkill[Dodge] 数值异常：",uVar6,0);
                    Debug.LogWarning(uVar6,0);
                    local_68 = 0.0;
                  }
                  lVar5 = FUN_18046c620(0);
                  if (lVar5 != null) {
                    if (*(int64 *)(lVar5 + 40) == 0) {
                      fVar15 = 0.0;
                    }
                    else {
                      lVar5 = FUN_18046c620(0);
                      if ((lVar5 == null) || (*(int64 *)(lVar5 + 40) == 0)) goto LAB_180fd6d82;
                      fVar15 = (float)*(int *)(*(int64 *)(lVar5 + 40) + 20) * 0.1;
                    }
                    fVar15 = 0.75 / (local_68 * 0.02 + fVar15 + 1.0);
                    cVar2 = Single.IsNaN(fVar15,0);
                    if ((cVar2) || (fVar15 <= 0.0)) {
                      fVar15 = 0.75;
                    }
                    this.moveTarget = lVar4;
                    if ((this.moveTween != null) &&
                       (cVar2 = TweenExtensions.IsActive(this.moveTween,0), cVar2)
                       ) {
                      TweenExtensions.Kill(this.moveTween,0,0);
                    }
                    uVar6 = Component.get_transform(this,0);
                    if ((lVar4 != null) && (lVar5 = GameObject.get_transform(lVar4,0)) != null) {
                      puVar7 = (uint32 *)Transform.get_localPosition(&local_48,lVar5,0);
                      uVar14 = *puVar7;
                      lVar5 = GameObject.get_transform(lVar4,0);
                      if (lVar5 != null) {
                        puVar8 = (uint64 *)Transform.get_localPosition(&local_48,lVar5,0);
                        local_58 = CONCAT44((int)((uint64)*puVar8 >> 32),uVar14);
                        uStack_40 = 0xbe4ccccd;
                        local_50 = 0xbe4ccccd;
                        uVar6 = ShortcutExtensions.DOLocalMove(uVar6,&local_58,fVar15,0,0);
                        uVar9 = new OnTooltipCB(this,DAT_181db6ef8,0);
                        uVar6 = TweenSettingsExtensions.OnComplete(uVar6,uVar9,DAT_181dc01d0);
                        this.moveTween = uVar6;
                        uVar14 = Time.get_realtimeSinceStartup(0);
                        bVar13 = !DAT_181ea07a5;
                        this.moveStartRealtime = uVar14;
                        if (bVar13) {
                          il2cpp_runtime_class_init(&DAT_181d89638);
                          DAT_181ea07a5 = true;
                        }
                        lVar5 = new WarpText_d__8(0,0);
                        if (lVar5 != null) {
                          *(int64 *)(lVar5 + 48) = this;
                          *(int64 *)(lVar5 + 40) = lVar4;
                          *(float *)(lVar5 + 32) = fVar15 * 0.5;
                          FUN_180d8c2e0(this,lVar5,0);
                          uVar6 = this.playerSkeleton;
                          cVar2 = Object.op_Inequality(uVar6,0,0);
                          if (cVar2) {
                            if (this.playerSkeleton == null) goto LAB_180fd6d82;
                            lVar4 = SkeletonAnimation.get_AnimationState(this.playerSkeleton,0)
                            ;
                            if (lVar4 == null) goto LAB_180fd6c30;
                            if (this.playerSkeleton == null) goto LAB_180fd6d82;
                            uVar6 = *(uint64 *)(this.playerSkeleton + 24);
                            cVar2 = Object.op_Inequality(uVar6,0,0);
                            if (cVar2) {
                              if ((this.playerSkeleton == null) ||
                                 (lVar4 = *(int64 *)(this.playerSkeleton + 24)) == null
                                 ) goto LAB_180fd6d82;
                              lVar4 = SkeletonDataAsset.GetSkeletonData(lVar4,1,0);
                              if ((lVar4 != null) &&
                                 (lVar4 = SkeletonData.FindAnimation(lVar4,"jump_small",0)) != null)
                              {
                                if (((this.playerSkeleton != null) &&
                                    (lVar5 = SkeletonAnimation.get_AnimationState
                                                       (this.playerSkeleton,0), lVar5 != null)) &&
                                   (lVar5 = AnimationState.SetAnimation(lVar5,0,"jump_small",0,0),
                                   lVar5 != null)) {
                                  *(float *)(lVar5 + 160) = *(float *)(lVar4 + 40) / fVar15;
                                  goto LAB_180fd6c30;
                                }
                                goto LAB_180fd6d82;
                              }
                            }
                            Debug.LogWarning("[StudyDodge] 骨架缺少 jump_small 动画",0);
                          }
        LAB_180fd6c30:
                          this.moving = 1;
                          plVar10 = (int64 *)Resources.Load("Sound/SoundEffect/Bag",0);
                          plVar12 = (int64 *)0;
                          if ((plVar10 != (int64 *)0) && (*plVar10 == DAT_181daf348)) {
                            plVar12 = plVar10;
                          }
                          NGUITools.PlaySound(plVar12);
                          return;
                        }
                      }
                    }
                  }
                }
        LAB_180fd6d82:
                          // WARNING: Subroutine does not return
                FUN_1800d6620();
              }
              local_64 = column;
              uVar9 = il2cpp_value_box(DAT_181d80418,&local_64);
              local_60[0] = row;
              uVar11 = il2cpp_value_box(DAT_181d80418,local_60);
              uVar6 = "[StudyDodge] PlayerEnterGrid 目标格为空：{0},{1}";
            }
            uVar6 = String.Format(uVar6,uVar9,uVar11,0);
            goto LAB_180fd6d49;
          }
        }
        uVar6 = "[StudyDodge] PlayerEnterGrid 中止：gridUnits 未初始化";
        if (((*(byte *)(DAT_181dbfcc8 + 0x133) & 4) != 0) && (*(int *)(DAT_181dbfcc8 + 224) == 0)) {
          il2cpp_runtime_class_init();
          uVar6 = "[StudyDodge] PlayerEnterGrid 中止：gridUnits 未初始化";
        }
        LAB_180fd6d49:
        Debug.LogWarning(uVar6,0);
    }

    // Token : 0x6002233
    // RVA   : 0xFD61C0   Offset: 0xFD55C0   Length: 0x9A
    public IEnumerator PlayerChangeToMoveGrid(float delta, GameObject target)
    {
        int64 StudyDodgePlayer.PlayerChangeToMoveGrid
                         (uint64 this,uint32 delta,uint64 target)
        {
        int64 lVar1;
        var lVar1 = new WarpText_d__8(0,0);
        if (lVar1 != null) {
          *(uint64 *)(lVar1 + 48) = this;
          *(uint64 *)(lVar1 + 40) = target;
          *(uint32 *)(lVar1 + 32) = delta;
          return lVar1;
        }
    }

    // Token : 0x6002234
    // RVA   : 0xFD6D90   Offset: 0xFD6190   Length: 0xE7
    public void PlayerFinishMove()
    {
        ulong uVar1;
        bool cVar2;
        long lVar3;
        this.moveTarget = 0;
        this.moving = 0;
        this.moveTween = 0;
        uVar1 = this.playerSkeleton;
        cVar2 = Object.op_Inequality(uVar1,0,0);
        if (!cVar2) {
          return;
        }
        if (this.playerSkeleton != null) {
          lVar3 = SkeletonAnimation.get_AnimationState(this.playerSkeleton,0);
          if (lVar3 == null) {
            return;
          }
          if ((this.playerSkeleton != null) &&
             (lVar3 = SkeletonAnimation.get_AnimationState(this.playerSkeleton,0)) != null)
          {
            AnimationState.SetAnimation(lVar3,0,"idle",1,0);
            return;
          }
        }
    }

    // Token : 0x6002235
    // RVA   : 0xFD6E80   Offset: 0xFD6280   Length: 0x54
    public void ResetMoveState()
    {
        if (this.moveTween != null) {
          TweenExtensions.Kill(this.moveTween,0,0);
          this.moveTween = 0;
        }
        this.moveTarget = 0;
        this.moving = 0;
    }

    // Token : 0x6002236
    // RVA   : 0xFD4EB0   Offset: 0xFD42B0   Length: 0xB47
    public void OnHit(GameObject hitObj)
    {
        var pStatics_1be0 = *(int64*)(DAT_181da1be0 + 184);
        var pStatics_2cc8 = *(int64*)(DAT_181d72cc8 + 184);
        var pStatics_8090 = *(int64*)(DAT_181da8090 + 184);
        var pStatics_be88 = *(int64*)(DAT_181dabe88 + 184);
        ulong uVar2;
        uint uVar3;
        bool cVar4;
        ulong uVar5;
        long lVar7;
        long lVar9;
        float fVar12;
        ulong local_78;
        float local_70;
        ulong local_68;
        float local_60;
        byte[] local_58 = new byte[16];
        byte[] local_48 = new byte[64];
        if (0.0 < this.shieldTime) {
          StudyDodgePlayer.SetShieldTime(this,0,0);
          plVar6 = (int64 *)Resources.Load("Sound/SoundEffect/Break",0);
          plVar10 = (int64 *)0;
          if ((plVar6 != (int64 *)0) && (plVar10 = (int64 *)0, *plVar6 == DAT_181daf348)) {
            plVar10 = plVar6;
          }
          NGUITools.PlaySound(plVar10,0);
        }
        else {
          if (this.playerSkeleton == null) throw; // [null/range check failed]
          uVar5 = Component.get_gameObject(this.playerSkeleton,0);
          plVar6 = (int64 *)Resources.Load("SpeEffect/劈砍",0);
          if ((hitObj == null) || (lVar7 = GameObject.get_transform(hitObj,0)) == null)
          throw; // [null/range check failed]
          puVar8 = (uint64 *)Transform.get_localPosition(local_58,lVar7,0);
          uVar2 = *puVar8;
          uVar3 = *(uint32 *)(puVar8 + 1);
          puVar8 = (uint64 *)Vector3.get_one(local_48,0);
          local_68 = *puVar8;
          local_60 = *(float *)(puVar8 + 1);
          local_70 = local_60 * 0.5;
          local_78 = CONCAT44((float)((uint64)local_68 >> 32) * 0.5,(float)local_68 * 0.5);
          plVar10 = (int64 *)0;
          local_68 = local_78;
          local_60 = local_70;
          plVar11 = plVar10;
          if ((plVar6 != (int64 *)0) && (*plVar6 == DAT_181d72e60)) {
            plVar11 = plVar6;
          }
          local_78 = uVar2;
          local_70 = (float)uVar3;
          uVar5 = GlobalData.AddChild(uVar5,plVar11,&local_78,&local_68,0);
          this.newObj = uVar5;
          if (this.newObj == null) throw; // [null/range check failed]
          uVar5 = GameObject.GetComponent(this.newObj,DAT_181dc72f8);
          cVar4 = Object.op_Inequality(uVar5,0,0);
          if (cVar4) {
            if ((this.newObj == null) ||
               (lVar7 = GameObject.GetComponent(this.newObj,DAT_181dc72f8)) == null
               ) throw; // [null/range check failed]
            fVar12 = (float)AudioSource.get_volume(lVar7,0);
            AudioSource.set_volume
                      (lVar7,fVar12 * *(float *)(*(int64 *)(DAT_181d72d50 + 184) + 16),0);
          }
          cVar4 = GlobalData.IsCheckVersion(1,0);
          if (!cVar4) {
            if (this.playerSkeleton == null) throw; // [null/range check failed]
            uVar5 = Component.get_gameObject(this.playerSkeleton,0);
            plVar6 = (int64 *)Resources.Load("SpeEffect/BloodSplash",0);
            local_78 = 0x3f80000000000000;
            local_70 = -0.1;
            if ((plVar6 != (int64 *)0) && (*plVar6 == DAT_181d72e60)) {
              plVar10 = plVar6;
            }
            GlobalData.AddChild(uVar5,plVar10,&local_78,0);
          }
          if ((*pStatics_2cc8 == 0) ||
             (lVar7 = *(int64 *)(*pStatics_2cc8 + 32)) == null)
          throw; // [null/range check failed]
          lVar7 = WorldData.Player(lVar7,0);
          if ((((*pStatics_2cc8 == 0) ||
               (lVar9 = *(int64 *)(*pStatics_2cc8 + 32)) == null) ||
              (lVar9 = WorldData.Player(lVar9,0)) == null) || (lVar7 == null)) throw; // [null/range check failed]
          HeroData.ChangeHp(lVar7,*(float *)(lVar9 + 0x17c) * -0.1,1,0,1,0,0);
          lVar7 = *(int64 *)(pStatics_8090 + 8);
          if (lVar7 == null) throw; // [null/range check failed]
          piVar1 = (int *)(lVar7 + 84);
          *piVar1 = *piVar1 + 1;
          lVar7 = *(int64 *)(pStatics_8090 + 8);
          if (lVar7 == null) throw; // [null/range check failed]
          StudyDodgeSkillController.ResetCombo(lVar7,0);
        }
        if (*pStatics_be88 != 0) {
          TimeScaleController.SetSlowTime(*pStatics_be88,0x3f000000,0x3e4ccccd,0);
          if (*pStatics_1be0 != 0) {
            ShakeCam.StartShake(*pStatics_1be0,2,0);
            if (((*pStatics_2cc8 != 0) &&
                (lVar7 = *(int64 *)(*pStatics_2cc8 + 32)) != null) &&
               (lVar7 = WorldData.Player(lVar7,0)) != null) {
              lVar9 = this.playerSkeleton;
              if (*(float *)(lVar7 + 0x178) <= 0.0) {
                if ((lVar9 != null) && (lVar7 = SkeletonAnimation.get_AnimationState(lVar9,0)) != null)
                {
                  AnimationState.SetAnimation(lVar7,1,"die",0,0);
                  if ((*pStatics_2cc8 != 0) &&
                     (lVar7 = *(int64 *)(*pStatics_2cc8 + 32)) != null) {
                    lVar7 = WorldData.Player(lVar7,0);
                    if ((((*pStatics_2cc8 != 0) &&
                         (lVar9 = *(int64 *)(*pStatics_2cc8 + 32)) != null
                         ) && (lVar9 = WorldData.Player(lVar9,0)) != null) &&
                       (uVar5 = HeroData.GetHeroDieSound(lVar9,0), lVar7 != null)) {
                      HeroData.PlayHeroSound(lVar7,uVar5,0x3f000000,0xbf800000,0);
                      lVar7 = *(int64 *)(pStatics_8090 + 8);
                      if (lVar7 != null) {
                        uVar5 = StudyDodgeSkillController.FinishStudyDodgeSkill(lVar7,0,0);
                        FUN_180d8c2e0(this,uVar5,0);
                        return;
                      }
                    }
                  }
                }
              }
              else if ((lVar9 != null) &&
                      (lVar7 = SkeletonAnimation.get_AnimationState(lVar9,0)) != null) {
                AnimationState.SetAnimation(lVar7,1,"hit",0,0);
                if ((this.playerSkeleton != null) &&
                   (lVar7 = SkeletonAnimation.get_AnimationState(this.playerSkeleton,0),
                   lVar7 != null)) {
                  AnimationState.AddEmptyAnimation(lVar7,1,0x3dcccccd,0,0);
                  if ((*pStatics_2cc8 != 0) &&
                     (lVar7 = *(int64 *)(*pStatics_2cc8 + 32)) != null) {
                    lVar7 = WorldData.Player(lVar7,0);
                    if ((((*pStatics_2cc8 != 0) &&
                         (lVar9 = *(int64 *)(*pStatics_2cc8 + 32)) != null
                         ) && (lVar9 = WorldData.Player(lVar9,0)) != null) &&
                       (uVar5 = HeroData.GetHeroHurtSound(lVar9,0), lVar7 != null)) {
                      HeroData.PlayHeroSound(lVar7,uVar5,0x3f000000,0xbf800000,0);
                      return;
                    }
                  }
                }
              }
            }
          }
        }
    }

    // Token : 0x6002237
    // RVA   : 0xFD6EE0   Offset: 0xFD62E0   Length: 0x2F2
    public void SetShieldTime(float targetTime)
    {
        bool cVar2;
        long lVar4;
        ulong uVar6;
        float fVar8;
        ulong local_38;
        float local_30;
        ulong local_28;
        float local_20;
        uVar6 = this.shieldSpe;
        plVar1 = &this.shieldSpe;
        if (0.0 < targetTime) {
          this.shieldTime = targetTime;
          cVar2 = Object.op_Equality(uVar6,0,0);
          if (cVar2) {
            uVar6 = this.hipPos;
            plVar3 = (int64 *)Resources.Load("SpeEffect/光圈持续",0);
            if ((this.playerSkeleton != null) &&
               (lVar4 = Component.get_transform(this.playerSkeleton,0)) != null) {
              pfVar5 = (float *)Transform.get_localScale(&local_28,lVar4,0);
              fVar8 = *pfVar5;
              local_30 = fVar8 + fVar8;
              local_38 = CONCAT44(local_30,fVar8 * 1.2);
              local_20 = local_30;
              local_28 = local_38;
              local_30 = -0.001;
              local_38 = 0;
              plVar7 = (int64 *)0;
              if ((plVar3 != (int64 *)0) && (*plVar3 == DAT_181d72e60)) {
                plVar7 = plVar3;
              }
              lVar4 = GlobalData.AddChild(uVar6,plVar7,&local_38,&local_28,0);
              this.shieldSpe = lVar4;
              il2cpp_internal(plVar1,lVar4);
              if (this.shieldSpe != null) {
                uVar6 = GameObject.GetComponent(this.shieldSpe,DAT_181dc72f8);
                cVar2 = Object.op_Inequality(uVar6,0,0);
                if (!cVar2) {
                  return;
                }
                if ((this.shieldSpe != null) &&
                   (lVar4 = GameObject.GetComponent(this.shieldSpe,DAT_181dc72f8)) != null) {
                  fVar8 = (float)AudioSource.get_volume(lVar4,0);
                  AudioSource.set_volume
                            (lVar4,fVar8 * *(float *)(*(int64 *)(DAT_181d72d50 + 184) + 16),0);
                  return;
                }
              }
            }
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
        }
        else {
          this.shieldTime = 0;
          cVar2 = Object.op_Inequality(uVar6,0,0);
          if (cVar2) {
            lVar4 = this.shieldSpe;
            Object.Destroy(lVar4,0);
          }
        }
    }

    // Token : 0x6002238
    // RVA   : 0xFD5A00   Offset: 0xFD4E00   Length: 0x7BE
    private void OnTriggerEnter2D(Collider2D other)
    {
        int iVar2;
        uint uVar3;
        bool cVar4;
        long lVar5;
        long lVar6;
        ulong uVar7;
        long lVar11;
        ulong uVar13;
        float fVar15;
        ulong in_stack_ffffffffffffffb0;
        ulong local_38;
        uint local_30;
        uint local_28;
        uint uStack_24;
        uint uStack_20;
        uint32 uStack_1c;
        lVar5 = new c.DisplayClass9_0(0);
        if (lVar5 != null) {
          plVar1 = (int64 *)(lVar5 + 16);
          *plVar1 = other;
          il2cpp_internal(plVar1,other);
          if (*plVar1 != 0) {
            cVar4 = Component.CompareTag(*plVar1,"StudyAttackBullet",0);
            lVar6 = *plVar1;
            if (!cVar4) {
              if (lVar6 == null) throw; // [null/range check failed]
              cVar4 = Component.CompareTag(lVar6,"StudySkillStar",0);
              if (!cVar4) {
                return;
              }
              if ((*plVar1 == 0) || (lVar6 = Component.GetComponent(*plVar1,DAT_181d95f60)) == null)
              throw; // [null/range check failed]
              iVar2 = *(int *)(lVar6 + 24);
              if (iVar2 == 0) {
                lVar6 = FUN_180fd09b0(0);
                if (lVar6 != null) {
                  StudyDodgeSkillController.ChangeCombo(lVar6,3);
                  lVar6 = FUN_18046c0a0(0);
                  if ((*plVar1 != 0) && (lVar11 = Component.get_transform(*plVar1,0)) != null) {
                    puVar8 = (uint64 *)Transform.get_position(&local_38,lVar11,0);
                    uVar7 = *puVar8;
                    uVar3 = *(uint32 *)(puVar8 + 1);
                    puVar9 = (uint32 *)Color.get_green(&local_28,0);
                    if (lVar6 != null) {
                      local_28 = *puVar9;
                      uStack_24 = puVar9[1];
                      uStack_20 = puVar9[2];
                      uStack_1c = puVar9[3];
                      local_38 = uVar7;
                      local_30 = uVar3;
                      GameController.ShowTextAtPos(lVar6,"连击+3",&local_38,20,&local_28,0);
                      plVar12 = (int64 *)Resources.Load("Sound/SoundEffect/Success",0);
                      plVar10 = (int64 *)0;
                      if ((plVar12 != (int64 *)0) && (*plVar12 == DAT_181daf348)) {
                        plVar10 = plVar12;
                      }
                      NGUITools.PlaySound(plVar10,0);
                      if (*plVar1 != 0) {
                        uVar7 = Component.get_transform(*plVar1,0);
                        ShortcutExtensions.DOKill(uVar7,0,0);
                        if ((*plVar1 != 0) &&
                           (lVar6 = Component.GetComponent(*plVar1,DAT_181d93a60)) != null) {
                          Behaviour.set_enabled(lVar6,0,0);
                          if (*plVar1 != 0) {
                            uVar7 = Component.get_transform(*plVar1,0);
                            lVar6 = FUN_18046c620(0);
                            if (((lVar6 != null) && (*(int64 *)(lVar6 + 88) != 0)) &&
                               (lVar6 = Component.get_transform(*(int64 *)(lVar6 + 88),0),
                               lVar6 != null)) {
                              puVar8 = (uint64 *)Transform.get_position(&local_28,lVar6,0);
                              local_38 = *puVar8;
                              local_30 = *(uint32 *)(puVar8 + 1);
                              uVar7 = ShortcutExtensions.DOMove(uVar7,&local_38,0x3f000000,0,0);
                              uVar13 = new OnTooltipCB(lVar5,DAT_181db4870,0);
                              TweenSettingsExtensions.OnComplete(uVar7,uVar13,DAT_181dc01d0);
                              return;
                            }
                          }
                        }
                      }
                    }
                  }
                }
                throw; // [null/range check failed]
              }
              if (iVar2 == 1) {
                lVar5 = FUN_18046c0a0(0);
                if ((lVar5 == null) || (*(int64 *)(lVar5 + 32) == 0)) throw; // [null/range check failed]
                lVar5 = WorldData.Player(*(int64 *)(lVar5 + 32),0);
                lVar6 = FUN_18046c0a0(0);
                if ((lVar6 == null) ||
                   (((*(int64 *)(lVar6 + 32) == 0 ||
                     (lVar6 = WorldData.Player(*(int64 *)(lVar6 + 32),0)) == null) ||
                    (lVar5 == null)))) throw; // [null/range check failed]
                plVar12 = (int64 *)0;
                HeroData.ChangeHp(lVar5,*(float *)(lVar6 + 0x17c) * 0.1,1,1,1,
                                   in_stack_ffffffffffffffb0 & 0xffffffffffffff00,0);
                lVar5 = FUN_18046c0a0(0);
                if ((*plVar1 == 0) || (lVar6 = Component.get_transform(*plVar1,0)) == null)
                throw; // [null/range check failed]
                puVar8 = (uint64 *)Transform.get_position(&local_38,lVar6,0);
                uVar7 = *puVar8;
                uVar3 = *(uint32 *)(puVar8 + 1);
                puVar9 = (uint32 *)Color.get_green(&local_28,0);
                if (lVar5 == null) throw; // [null/range check failed]
                local_28 = *puVar9;
                uStack_24 = puVar9[1];
                uStack_20 = puVar9[2];
                uStack_1c = puVar9[3];
                local_38 = uVar7;
                local_30 = uVar3;
                GameController.ShowTextAtPos(lVar5,"生命+10%",&local_38,20,&local_28,0);
                plVar10 = (int64 *)Resources.Load("Sound/SoundEffect/Eat",0);
                plVar14 = plVar12;
                if ((plVar10 != (int64 *)0) && (*plVar10 == DAT_181daf348)) {
                  plVar14 = plVar10;
                }
                NGUITools.PlaySound(plVar14,0);
                if (this.playerSkeleton == null) throw; // [null/range check failed]
                uVar7 = Component.get_gameObject(this.playerSkeleton,0);
                plVar10 = (int64 *)Resources.Load("SpeEffect/治疗",0);
                if ((plVar10 != (int64 *)0) && (*plVar10 == DAT_181d72e60)) {
                  plVar12 = plVar10;
                }
                uVar7 = GlobalData.AddChild(uVar7,plVar12,0);
                this.newObj = uVar7;
                if (this.newObj == null) throw; // [null/range check failed]
                uVar7 = GameObject.GetComponent(this.newObj,DAT_181dc72f8);
                cVar4 = Object.op_Inequality(uVar7,0,0);
                if (cVar4) {
                  if ((this.newObj == null) ||
                     (lVar5 = GameObject.GetComponent(this.newObj,DAT_181dc72f8),
                     lVar5 == null)) throw; // [null/range check failed]
                  fVar15 = (float)AudioSource.get_volume(lVar5,0);
                  AudioSource.set_volume
                            (lVar5,fVar15 * *(float *)(*(int64 *)(DAT_181d72d50 + 184) + 16),0);
                }
              }
              else {
                if (iVar2 != 2) {
                  return;
                }
                StudyDodgePlayer.SetShieldTime(this,0x40a00000,0);
              }
            }
            else {
              if (lVar6 == null) throw; // [null/range check failed]
              uVar7 = Component.get_gameObject(lVar6,0);
              StudyDodgePlayer.OnHit(this,uVar7,0);
            }
            if (*plVar1 != 0) {
              uVar7 = Component.get_gameObject(*plVar1,0);
              Object.Destroy(uVar7,0);
              return;
            }
          }
        }
    }

    // Token : 0x6002239
    // RVA   : 0x3A17B0   Offset: 0x3A0BB0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_18044ef50(this,0);
    }

}
