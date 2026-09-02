// ============================================================
// Type  : StudyUniqueSkillController
// Token : 0x200038E
// ============================================================

public class StudyUniqueSkillController
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001C3C
    public bool inStudy;

    // Token: 0x4001C3D
    public bool finishing;

    // Token: 0x4001C3E
    public float totalExp;

    // Token: 0x4001C3F
    public int combo;

    // Token: 0x4001C40
    public int hit;

    // Token: 0x4001C41
    public int leftBulletCount;

    // Token: 0x4001C42
    public float flyTime;

    // Token: 0x4001C43
    public float baseDamage;

    // Token: 0x4001C44
    public bool nowClick;

    // Token: 0x4001C45
    public StudyUniqueDefenceType studyUniqueDefenceType;

    // Token: 0x4001C46
    public KungfuSkillLvData targetSkill;

    // Token: 0x4001C47
    public GameObject studyUniqueSkillRoot;

    // Token: 0x4001C48
    public GameObject studyUniqueUIPanel;

    // Token: 0x4001C49
    public GameObject selfObj;

    // Token: 0x4001C4A
    public GameObject bulletObjs;

    // Token: 0x4001C4B
    public GameObject dartPrefab;

    // Token: 0x4001C4C
    public GameObject arrowPrefab;

    // Token: 0x4001C4D
    public GameObject bombPrefab;

    // Token: 0x4001C4E
    public List<GameObject> defencePoint;

    // Token: 0x4001C4F
    public List<Sprite> uniqueUnitSprites;

    // Token: 0x4001C50
    public List<Vector3> directionPos;

    // Token: 0x4001C51
    private GameObject newObj;

    // Token: 0x4001C52
    private static StudyUniqueSkillController _instance;

    // Token: 0x4001C53
    private float generateTime;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6002237
    // RVA   : 0xB9A1F0   Offset: 0xB989F0   Length: 0x36
    public static StudyUniqueSkillController get_Instance()
    {
        return **(uint64 **)(DAT_181d83070 + 184);
    }

    // Token : 0x6002238
    // RVA   : 0xB97840   Offset: 0xB96040   Length: 0x43
    private void Awake()
    {
        puVar1 = *(uint64 **)(DAT_181d83070 + 184);
        *puVar1 = this;
        il2cpp_internal(puVar1,this);
    }

    // Token : 0x6002239
    // RVA   : 0xB99310   Offset: 0xB97B10   Length: 0xD78
    private void Update()
    {
        var pStatics_2f70 = *(int64*)(DAT_181d82f70 + 184);
        var pStatics_2ff0 = *(int64*)(DAT_181d82ff0 + 184);
        var pStatics_df90 = *(int64*)(DAT_181d4df90 + 184);
        var pStatics_e010 = *(int64*)(DAT_181d4e010 + 184);
        var pStatics_ef00 = *(int64*)(DAT_181d4ef00 + 184);
        bool cVar2;
        ulong uVar3;
        long lVar4;
        ulong uVar7;
        int iVar8;
        uint uVar9;
        uint uVar10;
        float fVar11;
        uint uVar12;
        ulong local_78;
        float local_70;
        ulong local_68;
        float local_60;
        ulong local_58;
        float fStack_50;
        uint32 uStack_4c;
        uint8 local_48 [16];
        uint64 local_38 [6];
        if (!this.inStudy) {
          return;
        }
        if (*pStatics_2f70 == 0) throw; // [null/range check failed]
        uVar7 = *(uint64 *)(*pStatics_2f70 + 80);
        uVar3 = Single.ToString(this + 28,0);
        uVar3 = String.Concat("经验 ",uVar3,0);
        LTLocalization.SetText(uVar7,uVar3,0);
        if (*pStatics_2f70 == 0) throw; // [null/range check failed]
        uVar7 = *(uint64 *)(*pStatics_2f70 + 88);
        uVar3 = Int32.ToString(this + 32,0);
        LTLocalization.SetText(uVar7,uVar3,0);
        if ((*pStatics_df90 == 0) ||
           (lVar4 = *(int64 *)(*pStatics_df90 + 32)) == null)
        throw; // [null/range check failed]
        lVar4 = WorldData.Player(lVar4,0);
        if ((*pStatics_2f70 == 0) || (lVar4 == null)) throw; // [null/range check failed]
        HeroData.SetHpBar(lVar4,*(uint64 *)(*pStatics_2f70 + 96),0);
        if (this.finishing) {
          return;
        }
        cVar2 = GlobalData.GetKeyDown(119);
        iVar8 = 0;
        if (!cVar2) {
          cVar2 = GlobalData.GetKeyDown(115);
          if (cVar2) {
            this.studyUniqueDefenceType = 1;
            this.nowClick = 1;
            lVar4 = FUN_180b04980(0);
            if (((lVar4 == null) || (lVar4.Count == null)) ||
               (lVar4 = SkeletonAnimation.get_AnimationState(lVar4.Count,0)) == null)
            throw; // [null/range check failed]
            AnimationState.SetAnimation(lVar4,1,"defence",0,0);
            lVar4 = FUN_180b04980(0);
            if (((lVar4 == null) || (lVar4.Count == null)) ||
               (lVar4 = SkeletonAnimation.get_AnimationState(lVar4.Count,0)) == null)
            throw; // [null/range check failed]
            AnimationState.AddEmptyAnimation(lVar4,1,0x3dcccccd,0,0);
            lVar4 = this.defencePoint;
            if (lVar4 == null) throw; // [null/range check failed]
            if (lVar4.Count < 2) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            lVar4 = *(int64 *)(lVar4._items + 40);
            if (lVar4 == null) throw; // [null/range check failed]
            lVar4 = GameObject.GetComponent(lVar4,DAT_181d9e558);
            if (lVar4 == null) throw; // [null/range check failed]
            AudioSource.set_volume(lVar4,*(float *)(pStatics_e010 + 16) * 0.2,0);
            lVar4 = this.defencePoint;
            if (lVar4 == null) throw; // [null/range check failed]
            if (lVar4.Count < 2) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            lVar4 = *(int64 *)(lVar4._items + 40);
            goto LAB_180b99e93;
          }
          cVar2 = GlobalData.GetKeyDown(97);
          if (cVar2) {
            lVar4 = FUN_180b04980(0);
            if ((lVar4 == null) || (lVar4.Count == null)) throw; // [null/range check failed]
            lVar4 = Component.get_transform(lVar4.Count,0);
            local_58 = *(uint64 *)(pStatics_ef00 + 0x154);
            fStack_50 = *(float *)(pStatics_ef00 + 0x15c);
            local_70 = fStack_50 * 0.5;
            local_78 = CONCAT44((float)((uint64)local_58 >> 32) * 0.5,(float)local_58 * 0.5);
            local_68 = local_58;
            local_60 = fStack_50;
            if (lVar4 == null) throw; // [null/range check failed]
            local_68 = local_78;
            local_60 = local_70;
            Transform.set_localScale(lVar4,&local_68,0);
            this.studyUniqueDefenceType = 2;
            this.nowClick = 1;
            lVar4 = FUN_180b04980(0);
            if (((lVar4 == null) || (lVar4.Count == null)) ||
               (lVar4 = SkeletonAnimation.get_AnimationState(lVar4.Count,0)) == null)
            throw; // [null/range check failed]
            AnimationState.SetAnimation(lVar4,1,"defence",0,0);
            lVar4 = FUN_180b04980(0);
            if (((lVar4 == null) || (lVar4.Count == null)) ||
               (lVar4 = SkeletonAnimation.get_AnimationState(lVar4.Count,0)) == null)
            throw; // [null/range check failed]
            AnimationState.AddEmptyAnimation(lVar4,1,0x3dcccccd,0,0);
            lVar4 = this.defencePoint;
            if (lVar4 == null) throw; // [null/range check failed]
            if (lVar4.Count < 3) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            lVar4 = *(int64 *)(lVar4._items + 48);
            if (lVar4 == null) throw; // [null/range check failed]
            lVar4 = GameObject.GetComponent(lVar4,DAT_181d9e558);
            if (lVar4 == null) throw; // [null/range check failed]
            AudioSource.set_volume(lVar4,*(float *)(pStatics_e010 + 16) * 0.2,0);
            lVar4 = this.defencePoint;
            if (lVar4 == null) throw; // [null/range check failed]
            if (lVar4.Count < 3) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            lVar4 = *(int64 *)(lVar4._items + 48);
            goto LAB_180b99e93;
          }
          cVar2 = GlobalData.GetKeyDown(100);
          if (cVar2) {
            lVar4 = FUN_180b04980(0);
            if ((lVar4 == null) || (lVar4.Count == null)) throw; // [null/range check failed]
            lVar4 = Component.get_transform(lVar4.Count,0);
            local_78 = 0x3f0000003f000000;
            local_70 = 0.5;
            if (lVar4 == null) throw; // [null/range check failed]
            local_60 = 0.5;
            local_68 = 0x3f0000003f000000;
            Transform.set_localScale(lVar4,&local_68,0);
            this.studyUniqueDefenceType = 3;
            this.nowClick = 1;
            lVar4 = FUN_180b04980(0);
            if (((lVar4 == null) || (lVar4.Count == null)) ||
               (lVar4 = SkeletonAnimation.get_AnimationState(lVar4.Count,0)) == null)
            throw; // [null/range check failed]
            AnimationState.SetAnimation(lVar4,1,"defence",0,0);
            lVar4 = FUN_180b04980(0);
            if (((lVar4 == null) || (lVar4.Count == null)) ||
               (lVar4 = SkeletonAnimation.get_AnimationState(lVar4.Count,0)) == null)
            throw; // [null/range check failed]
            AnimationState.AddEmptyAnimation(lVar4,1,0x3dcccccd,0,0);
            lVar4 = this.defencePoint;
            if (lVar4 == null) throw; // [null/range check failed]
            if (lVar4.Count < 4) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            lVar4 = *(int64 *)(lVar4._items + 56);
            if (lVar4 == null) throw; // [null/range check failed]
            lVar4 = GameObject.GetComponent(lVar4,DAT_181d9e558);
            if (lVar4 == null) throw; // [null/range check failed]
            AudioSource.set_volume(lVar4,*(float *)(pStatics_e010 + 16) * 0.2,0);
            lVar4 = this.defencePoint;
            if (lVar4 == null) throw; // [null/range check failed]
            if (lVar4.Count < 4) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            lVar4 = *(int64 *)(lVar4._items + 56);
            goto LAB_180b99e93;
          }
          cVar2 = GlobalData.GetKey(119);
          if ((!cVar2) || (this.studyUniqueDefenceType != null)) {
            cVar2 = GlobalData.GetKey(115);
            if ((cVar2) && (this.studyUniqueDefenceType == 1)) goto LAB_180b997a7;
            cVar2 = GlobalData.GetKey(97);
            if ((cVar2) && (this.studyUniqueDefenceType == 2)) goto LAB_180b997a7;
            cVar2 = GlobalData.GetKey(100);
            if ((cVar2) && (this.studyUniqueDefenceType == 3)) goto LAB_180b997a7;
            this.studyUniqueDefenceType = -1;
            this.nowClick = 0;
          }
          else {
        LAB_180b997a7:
            this.nowClick = 0;
          }
        }
        else {
          this.nowClick = 1;
          this.studyUniqueDefenceType = 0;
          if (((*pStatics_2ff0 == 0) ||
              (lVar4 = *(int64 *)(*pStatics_2ff0 + 24)) == null) ||
             (lVar4 = SkeletonAnimation.get_AnimationState(lVar4,0)) == null) throw; // [null/range check failed]
          AnimationState.SetAnimation(lVar4,1,"defence",0,0);
          if (((*pStatics_2ff0 == 0) ||
              (lVar4 = *(int64 *)(*pStatics_2ff0 + 24)) == null) ||
             (lVar4 = SkeletonAnimation.get_AnimationState(lVar4,0)) == null) throw; // [null/range check failed]
          AnimationState.AddEmptyAnimation(lVar4,1,0x3dcccccd,0,0);
          lVar4 = this.defencePoint;
          if (lVar4 == null) throw; // [null/range check failed]
          if (lVar4.Count == null) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          lVar4 = *(int64 *)(lVar4._items + 32);
          if (lVar4 == null) throw; // [null/range check failed]
          lVar4 = GameObject.GetComponent(lVar4,DAT_181d9e558);
          if (lVar4 == null) throw; // [null/range check failed]
          AudioSource.set_volume(lVar4,*(float *)(pStatics_e010 + 16) * 0.2,0);
          lVar4 = this.defencePoint;
          if (lVar4 == null) throw; // [null/range check failed]
          if (lVar4.Count == null) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          lVar4 = *(int64 *)(lVar4._items + 32);
        LAB_180b99e93:
          if ((lVar4 == null) || (lVar4 = GameObject.GetComponent(lVar4,DAT_181d9e558)) == null)
          throw; // [null/range check failed]
          AudioSource.Play(lVar4,0);
        }
        lVar4 = this.defencePoint;
        while (lVar4 != null) {
          if (lVar4.Count <= iVar8) {
            StudyUniqueSkillController.ClearDefencePoint(this,0);
            StudyUniqueSkillController.ManageBulletGenerate(this,0);
            if (0 < this.leftBulletCount) {
              return;
            }
            if ((this.bulletObjs != null) &&
               (lVar4 = GameObject.get_transform(this.bulletObjs,0)) != null) {
              iVar8 = Transform.get_childCount(lVar4,0);
              if (0 < iVar8) {
                return;
              }
              uVar7 = StudyUniqueSkillController.FinishStudyUniqueSkill(this,2);
              FUN_180d837c0(this,uVar7,0);
              return;
            }
            break;
          }
          if (lVar4 == null) break;
          if (iVar8 == this.studyUniqueDefenceType) {
            lVar4 = FUN_180002f80(lVar4,iVar8);
            if (lVar4 == null) break;
            lVar4 = GameObject.GetComponent(lVar4,DAT_181da19b0);
            puVar5 = (uint32 *)Color.get_green(local_48,0);
            uVar9 = *puVar5;
            uVar10 = puVar5[1];
            fVar11 = (float)puVar5[2];
            uVar12 = puVar5[3];
            puVar6 = local_38;
          }
          else {
            lVar4 = FUN_180002f80(lVar4,iVar8);
            if (lVar4 == null) break;
            lVar4 = GameObject.GetComponent(lVar4,DAT_181da19b0);
            puVar5 = (uint32 *)Color.get_black(&local_68,0);
            uVar9 = *puVar5;
            uVar10 = puVar5[1];
            fVar11 = (float)puVar5[2];
            uVar12 = puVar5[3];
            puVar6 = &local_78;
          }
          local_58 = CONCAT44(uVar10,uVar9);
          fStack_50 = fVar11;
          uStack_4c = uVar12;
          puVar6 = (uint64 *)GlobalData.SetColorAlpha(puVar6,&local_58,0x3ecccccd,0);
          if (lVar4 == null) break;
          local_58 = *puVar6;
          fStack_50 = *(float *)(puVar6 + 1);
          uStack_4c = *(uint32 *)((int64)puVar6 + 12);
          SpriteRenderer.set_color(lVar4,&local_58);
          iVar8 = iVar8 + 1;
          lVar4 = this.defencePoint;
        }
    }

    // Token : 0x600223A
    // RVA   : 0xB97A70   Offset: 0xB96270   Length: 0x730
    public void ClearDefencePoint()
    {
        var pStatics = *(int64*)(DAT_181d82ff0 + 184);
        uint uVar1;
        ulong uVar2;
        bool cVar3;
        long lVar4;
        long lVar5;
        ulong uVar6;
        ulong uVar9;
        long lVar10;
        uint uVar12;
        long lVar13;
        float fVar14;
        float fVar15;
        float[] local_res8 = new float[2];
        ulong in_stack_fffffffffffffea0;
        ulong local_138;
        ulong uStack_130;
        float local_120;
        ulong local_118;
        float local_110;
        ulong local_108;
        uint local_100;
        ulong local_f8;
        uint local_f0;
        ulong local_e8;
        uint local_e0;
        ulong local_d8;
        uint local_d0;
        byte[] local_c8 = new byte[16];
        byte[] local_b8 = new byte[16];
        byte[] local_a8 = new byte[16];
        byte[] local_98 = new byte[16];
        byte[] local_88 = new byte[16];
        byte[] local_78 = new byte[80];
        uVar12 = this.studyUniqueDefenceType;
        local_res8[0] = 0.0;
        if (uVar12 == 0xffffffff) {
          return;
        }
        lVar4 = this.defencePoint;
        if (lVar4 != null) {
          if (lVar4.Count <= uVar12) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          lVar4 = lVar4._items[uVar12];
          if (lVar4 != null) {
            lVar4 = GameObject.GetComponent(lVar4,DAT_181da1cb0);
            uVar12 = 0;
            if (lVar4 != null) {
              lVar13 = 32;
              while (lVar5 = lVar4.Count) != null {
                if ((int)*(uint32 *)(lVar5 + 24) <= (int)uVar12) {
                  GlobalData.DestroyAll(lVar5,0);
                  if (*pStatics != 0) {
                    StudyUniquePlayer.PlayerOnHit(*pStatics,0,0);
                    return;
                  }
                  break;
                }
                if (*(uint32 *)(lVar5 + 24) <= uVar12) {
                  ThrowHelper.ThrowArgumentOutOfRangeException(0);
                }
                if (*(int64 *)(*(int64 *)(lVar5 + 16) + lVar13) == 0) break;
                cVar3 = GameObject.CompareTag();
                if (cVar3) {
                  fVar14 = (float)(this.combo + 1);
                  this.totalExp = fVar14 + fVar14 + this.totalExp;
                  StudyUniqueSkillController.ChangeCombo(this,1);
                  uVar9 = this.bulletObjs;
                  if (((lVar4.Count == null) ||
                      (lVar5 = FUN_180002f80(lVar4.Count,uVar12,DAT_181d62178), lVar5 == null
                      )) || (lVar5 = GameObject.GetComponent(lVar5,DAT_181da1a30)) == null) break;
                  uVar6 = String.Concat("SpeEffect/",*(uint64 *)(lVar5 + 40),0);
                  plVar7 = (int64 *)Resources.Load(uVar6,0);
                  if (((lVar4.Count == null) ||
                      (lVar5 = FUN_180002f80(lVar4.Count,uVar12,DAT_181d62178), lVar5 == null
                      )) || (lVar5 = GameObject.get_transform(lVar5,0)) == null) break;
                  puVar8 = (uint64 *)Transform.get_localPosition(local_c8,lVar5,0);
                  uVar6 = *puVar8;
                  uVar1 = *(uint32 *)(puVar8 + 1);
                  puVar8 = (uint64 *)Vector3.get_one(local_b8,0);
                  local_138 = *puVar8;
                  local_120 = *(float *)(puVar8 + 1);
                  fVar15 = (float)local_138;
                  uVar2 = (uint64)local_138 >> 32;
                  fVar14 = local_120 * 0.5;
                  uStack_130 = CONCAT44((int)((uint64)uStack_130 >> 32),local_120);
                  local_118 = CONCAT44((float)uVar2 * 0.5,fVar15 * 0.5);
                  plVar11 = (int64 *)0;
                  if ((plVar7 != (int64 *)0) && (*plVar7 == DAT_181d4e110)) {
                    plVar11 = plVar7;
                  }
                  local_110 = fVar14;
                  local_108 = uVar6;
                  local_100 = uVar1;
                  uVar9 = GlobalData.AddChild(uVar9,plVar11,&local_108,&local_118,0);
                  this.newObj = uVar9;
                  if (this.newObj == null) break;
                  uVar9 = GameObject.GetComponent(this.newObj,DAT_181d9e558);
                  cVar3 = Object.op_Inequality(uVar9,0,0);
                  if (cVar3) {
                    if ((this.newObj == null) ||
                       (lVar5 = GameObject.GetComponent(this.newObj,DAT_181d9e558),
                       lVar5 == null)) break;
                    fVar14 = (float)AudioSource.get_volume(lVar5,0);
                    AudioSource.set_volume
                              (lVar5,fVar14 * *(float *)(*(int64 *)(DAT_181d4e010 + 184) + 16),0);
                  }
                  lVar5 = Component.get_transform(lVar4,0);
                  if (lVar5 == null) break;
                  puVar8 = (uint64 *)Transform.get_localPosition(local_a8,lVar5,0);
                  uVar9 = *puVar8;
                  uVar1 = *(uint32 *)(puVar8 + 1);
                  if (((lVar4.Count == null) ||
                      (lVar5 = FUN_180002f80(lVar4.Count,uVar12)) == null) ||
                     (lVar5 = GameObject.get_transform(lVar5,0)) == null) break;
                  puVar8 = (uint64 *)Transform.get_localPosition(local_98,lVar5);
                  local_f8 = *puVar8;
                  local_f0 = *(uint32 *)(puVar8 + 1);
                  local_e8 = uVar9;
                  local_e0 = uVar1;
                  fVar14 = (float)Vector3.Distance(&local_e8);
                  if (0.2 < fVar14) {
                    if (((lVar4.Count == null) ||
                        (lVar5 = FUN_180002f80(lVar4.Count,uVar12,DAT_181d62178),
                        lVar5 == null)) ||
                       (lVar5 = GameObject.GetComponent(lVar5,DAT_181da1a30)) == null) break;
                    local_res8[0] = *(float *)(lVar5 + 24) * -10.0 * this.baseDamage;
                    lVar5 = FUN_18046c0a0(0);
                    if (((lVar5 == null) || (*(int64 *)(lVar5 + 32) == 0)) ||
                       (lVar5 = WorldData.Player(*(int64 *)(lVar5 + 32),0)) == null) break;
                    HeroData.ChangeHp(lVar5,local_res8[0],0,0,1,
                                       in_stack_fffffffffffffea0 & 0xffffffffffffff00,0);
                    lVar5 = FUN_18046c0a0(0);
                    uVar9 = Single.ToString(local_res8,0);
                    if (((lVar4.Count == null) ||
                        (lVar10 = FUN_180002f80(lVar4.Count,uVar12,DAT_181d62178),
                        lVar10 == null)) || (lVar10 = GameObject.get_transform(lVar10,0)) == null)
                    break;
                    puVar8 = (uint64 *)Transform.get_position(local_88,lVar10,0);
                    uVar6 = *puVar8;
                    uVar1 = *(uint32 *)(puVar8 + 1);
                    puVar8 = (uint64 *)Color.get_yellow(local_78,0);
                    if (lVar5 == null) break;
                    local_138 = *puVar8;
                    uStack_130 = puVar8[1];
                    in_stack_fffffffffffffea0 = 0;
                    local_d8 = uVar6;
                    local_d0 = uVar1;
                    GameController.ShowTextAtPos(lVar5,uVar9,&local_d8,21,&local_138,0);
                  }
                }
                uVar12 = uVar12 + 1;
                lVar13 = lVar13 + 8;
              }
            }
          }
        }
    }

    // Token : 0x600223B
    // RVA   : 0xB986C0   Offset: 0xB96EC0   Length: 0x3EE
    public void ManageBulletGenerate()
    {
        uint uVar1;
        int iVar2;
        uint uVar3;
        long lVar4;
        ulong uVar5;
        long lVar6;
        ulong uVar8;
        float fVar9;
        float fVar10;
        ulong local_58;
        ulong local_48;
        float local_40;
        ulong local_38;
        float local_30;
        if (0 < this.leftBulletCount) {
          fVar10 = this.generateTime;
          fVar9 = (float)Time.get_deltaTime(0);
          fVar10 = fVar10 - fVar9;
          this.generateTime = fVar10;
          if (0.0 < fVar10) {
            return;
          }
          fVar10 = (float)Random.get_value(0);
          if (fVar10 < 0.125) {
            uVar5 = this.bulletObjs;
            lVar4 = FUN_18046c660(0);
            fVar10 = local_40;
            if (lVar4 == null) goto LAB_180b98aa9;
            fVar10 = (float)Random.get_value(0);
            if (fVar10 < 0.6) {
              uVar8 = *(uint64 *)(lVar4 + 104);
            }
            else if (fVar10 < 0.8) {
              uVar8 = *(uint64 *)(lVar4 + 112);
            }
            else {
              uVar8 = *(uint64 *)(lVar4 + 120);
            }
            uVar5 = GlobalData.AddChild(uVar5,uVar8,0);
            this.newObj = uVar5;
            fVar10 = local_40;
            if (this.newObj == null) goto LAB_180b98aa9;
            lVar6 = GameObject.get_transform(this.newObj,0);
            lVar4 = this.directionPos;
            fVar10 = local_40;
            if (lVar4 == null) goto LAB_180b98aa9;
            uVar3 = FUN_180d8cf10(0,lVar4.Count,0);
            if (lVar4.Count <= uVar3) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            local_38 = lVar4._items[uVar3];
            local_30 = *(float *)(lVar4._items + 40 + (int64)(int)uVar3 * 12);
            local_40 = local_30 * 10.0;
            local_58 = CONCAT44((float)((uint64)local_38 >> 32) * 10.0,(float)local_38 * 10.0);
            local_48 = local_38;
            fVar10 = local_30;
            if (lVar6 == null) goto LAB_180b98aa9;
            local_48 = local_58;
            Transform.set_localPosition(lVar6,&local_48,0);
            fVar10 = local_40;
            if (this.newObj == null) goto LAB_180b98aa9;
            uVar5 = GameObject.get_transform(this.newObj,0);
            uVar1 = this.flyTime;
            puVar7 = (uint64 *)Vector3.get_zero(&local_38,0);
            local_40 = *(float *)(puVar7 + 1);
            local_48 = *puVar7;
            uVar5 = ShortcutExtensions.DOMove(uVar5,&local_48,uVar1,0,0);
            TweenSettingsExtensions.SetEase(uVar5,1,DAT_181d97ca8);
          }
          else {
            this.leftBulletCount = this.leftBulletCount + -1;
            fVar9 = (float)Random.get_value(0);
            fVar10 = local_40;
            if ((this.targetSkill == null) ||
               (lVar4 = KungfuSkillLvData.DataBase(this.targetSkill,0), fVar10 = local_40,
               lVar4 == null)) goto LAB_180b98aa9;
            if (fVar9 < (float)*(int *)(lVar4 + 52) * 0.1 + 0.15) {
              fVar10 = (float)Random.get_value(0);
              if (fVar10 < 0.75) {
                uVar5 = this.arrowPrefab;
              }
              else {
                uVar5 = this.bombPrefab;
              }
            }
            else {
              uVar5 = this.dartPrefab;
            }
            uVar5 = StudyUniqueSkillController.CreateStudyUniqueBullet(this,uVar5,0);
            this.newObj = uVar5;
          }
          fVar10 = local_40;
          if ((this.targetSkill == null) ||
             (lVar4 = KungfuSkillLvData.DataBase(this.targetSkill,0), fVar10 = local_40,
             lVar4 == null)) {
        LAB_180b98aa9:
            local_40 = fVar10;
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          iVar2 = *(int *)(lVar4 + 52);
          fVar10 = (float)Mathf.Max();
          this.generateTime = fVar10 * (0.6 - (float)iVar2 * 0.05);
        }
    }

    // Token : 0x600223C
    // RVA   : 0xB981B0   Offset: 0xB969B0   Length: 0x458
    public GameObject CreateStudyUniqueBullet(GameObject targetPrefab)
    {
        uint uVar1;
        float fVar2;
        bool cVar3;
        uint uVar4;
        long lVar5;
        long lVar6;
        ulong uVar7;
        long lVar9;
        float fVar10;
        ulong local_78;
        ulong local_68;
        float local_60;
        ulong local_58;
        float local_50;
        byte[] local_48 = new byte[16];
        byte[] local_38 = new byte[32];
        uVar7 = this.bulletObjs;
        lVar5 = GlobalData.AddChild(uVar7,targetPrefab,0);
        fVar10 = local_60;
        if (lVar5 != null) {
          lVar6 = GameObject.get_transform(lVar5,0);
          lVar9 = this.directionPos;
          fVar10 = local_60;
          if (lVar9 != null) {
            uVar4 = FUN_180d8cf10(0,lVar9.Count,0);
            if (lVar9.Count <= uVar4) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            local_58 = lVar9._items[uVar4];
            local_50 = *(float *)(lVar9._items + 40 + (int64)(int)uVar4 * 12);
            local_60 = local_50 * 10.0;
            local_78 = CONCAT44((float)((uint64)local_58 >> 32) * 10.0,(float)local_58 * 10.0);
            local_68 = local_58;
            fVar10 = local_50;
            if (lVar6 != null) {
              local_68 = local_78;
              Transform.set_localPosition(lVar6,&local_68,0);
              uVar7 = GameObject.get_transform(lVar5,0);
              uVar1 = this.flyTime;
              puVar8 = (uint64 *)Vector3.get_zero(local_48,0);
              local_60 = *(float *)(puVar8 + 1);
              local_68 = *puVar8;
              uVar7 = ShortcutExtensions.DOMove(uVar7,&local_68,uVar1,0,0);
              TweenSettingsExtensions.SetEase(uVar7,1,DAT_181d97ca8);
              lVar9 = GameObject.GetComponent(lVar5,DAT_181da1a30);
              fVar10 = local_60;
              if (lVar9 != null) {
                if (0.0 < *(float *)(lVar9 + 32)) {
                  uVar7 = GameObject.get_transform(lVar5,0);
                  lVar9 = GameObject.GetComponent(lVar5,DAT_181da1a30);
                  fVar10 = local_60;
                  if (lVar9 == null) goto LAB_180b98603;
                  local_60 = 360.0;
                  local_68 = 0;
                  uVar7 = ShortcutExtensions.DORotate(uVar7,&local_68,*(uint32 *)(lVar9 + 32),1,0);
                  uVar7 = TweenSettingsExtensions.SetLoops(uVar7,0xffffffff,0,DAT_181d97fd8);
                  TweenSettingsExtensions.SetEase(uVar7,1,DAT_181d97a88);
                }
                lVar9 = GameObject.GetComponent(lVar5,DAT_181da1a30);
                fVar10 = local_60;
                if (lVar9 != null) {
                  if (*(char *)(lVar9 + 36) != false) {
                    lVar9 = GameObject.get_transform(lVar5,0);
                    puVar8 = (uint64 *)Vector3.get_zero(local_48,0);
                    fVar2 = *(float *)(puVar8 + 1);
                    uVar7 = *puVar8;
                    lVar6 = GameObject.get_transform(lVar5,0);
                    fVar10 = local_60;
                    if (lVar6 == null) goto LAB_180b98603;
                    puVar8 = (uint64 *)Transform.get_localPosition(local_38,lVar6,0);
                    local_78._0_4_ = (float)uVar7;
                    local_78._4_4_ = (float)((uint64)uVar7 >> 32);
                    local_58 = *puVar8;
                    local_50 = *(float *)(puVar8 + 1);
                    local_60 = fVar2 - local_50;
                    local_68 = CONCAT44(local_78._4_4_ - (float)((uint64)local_58 >> 32),
                                        (float)local_78 - (float)local_58);
                    fVar10 = local_60;
                    if (lVar9 == null) goto LAB_180b98603;
                    local_58 = local_68;
                    local_50 = local_60;
                    Transform.set_right(lVar9,&local_58,0);
                  }
                  uVar7 = GameObject.GetComponent(lVar5,DAT_181d9e558);
                  cVar3 = Object.op_Inequality(uVar7,0,0);
                  if (cVar3) {
                    lVar9 = GameObject.GetComponent(lVar5,DAT_181d9e558);
                    fVar10 = local_60;
                    if (lVar9 == null) goto LAB_180b98603;
                    fVar10 = (float)AudioSource.get_volume(lVar9,0);
                    AudioSource.set_volume
                              (lVar9,fVar10 * *(float *)(*(int64 *)(DAT_181d4e010 + 184) + 16),0);
                  }
                  return lVar5;
                }
              }
            }
          }
        }
        LAB_180b98603:
        local_60 = fVar10;
    }

    // Token : 0x600223D
    // RVA   : 0xB98BC0   Offset: 0xB973C0   Length: 0x6D8
    public void StartStudyUniqueSkill(KungfuSkillLvData target)
    {
        var pStatics_2f70 = *(int64*)(DAT_181d82f70 + 184);
        var pStatics_2ff0 = *(int64*)(DAT_181d82ff0 + 184);
        var pStatics_df90 = *(int64*)(DAT_181d4df90 + 184);
        int iVar1;
        bool cVar2;
        long lVar3;
        long lVar4;
        ulong uVar5;
        float fVar7;
        uint uVar8;
        ulong local_68;
        float local_60;
        ulong local_58;
        float local_50;
        byte[] local_38 = new byte[48];
        if (this.studyUniqueSkillRoot != null) {
          GameObject.SetActive(this.studyUniqueSkillRoot,1,0);
          if (this.studyUniqueUIPanel != null) {
            GameObject.SetActive(this.studyUniqueUIPanel,1,0);
            if ((*pStatics_2f70 != 0) &&
               (lVar3 = *(int64 *)(*pStatics_2f70 + 96)) != null) {
              GameObject.SetActive(lVar3,1,0);
              this.inStudy = 1;
              this.targetSkill = target;
              if (*pStatics_2ff0 != 0) {
                uVar5 = *(uint64 *)(*pStatics_2ff0 + 24);
                cVar2 = Object.op_Equality(uVar5,0,0);
                if (!cVar2) {
                  if ((*pStatics_df90 == 0) ||
                     (lVar3 = *(int64 *)(*pStatics_df90 + 32)) == null)
                  throw; // [null/range check failed]
                  lVar3 = WorldData.Player(lVar3,0);
                  if ((*pStatics_2ff0 == 0) || (lVar3 == null)) throw; // [null/range check failed]
                  HeroData.RefreshHeroSkeleton
                            (lVar3,*(uint64 *)(*pStatics_2ff0 + 24),0);
                }
                else {
                  lVar3 = *pStatics_2ff0;
                  if ((*pStatics_df90 == 0) ||
                     (lVar4 = *(int64 *)(*pStatics_df90 + 32)) == null)
                  throw; // [null/range check failed]
                  lVar4 = WorldData.Player(lVar4,0);
                  if (*pStatics_2ff0 == 0) throw; // [null/range check failed]
                  uVar5 = Component.get_gameObject(*pStatics_2ff0,0);
                  puVar6 = (uint64 *)Vector3.get_one(local_38,0);
                  local_58 = *puVar6;
                  local_50 = *(float *)(puVar6 + 1);
                  local_60 = local_50 * 0.5;
                  local_68 = CONCAT44((float)((uint64)local_58 >> 32) * 0.5,(float)local_58 * 0.5);
                  if (lVar4 == null) throw; // [null/range check failed]
                  local_58 = local_68;
                  local_50 = local_60;
                  uVar5 = HeroData.GenerateHeroSkeleton(lVar4,uVar5,&local_58,0);
                  if (lVar3 == null) throw; // [null/range check failed]
                  puVar6 = (uint64 *)(lVar3 + 24);
                  *puVar6 = uVar5;
                  il2cpp_internal(puVar6,uVar5);
                  if ((*pStatics_2ff0 == 0) ||
                     (lVar3 = *(int64 *)(*pStatics_2ff0 + 24)) == null)
                  throw; // [null/range check failed]
                  lVar3 = Component.get_transform(lVar3,0);
                  if (lVar3 == null) throw; // [null/range check failed]
                  local_60 = -0.1;
                  local_68 = 0;
                  Transform.set_localPosition(lVar3,&local_68,0);
                }
                if ((*pStatics_2ff0 != 0) &&
                   (lVar3 = *(int64 *)(*pStatics_2ff0 + 24)) != null) {
                  lVar3 = SkeletonAnimation.get_AnimationState(lVar3,0);
                  if (lVar3 != null) {
                    uVar8 = 0;
                    AnimationState.SetAnimation(lVar3,0,"cure",0,0);
                    if ((*pStatics_2ff0 != 0) &&
                       (lVar3 = *(int64 *)(*pStatics_2ff0 + 24)) != null)
                    {
                      lVar3 = SkeletonAnimation.get_AnimationState(lVar3,0);
                      if (lVar3 != null) {
                        AnimationState.AddAnimation(lVar3,0,"idle",1,CONCAT44(uVar8,0x3f800000),0)
                        ;
                        if (this.targetSkill != null) {
                          lVar3 = KungfuSkillLvData.DataBase(this.targetSkill,0);
                          if (lVar3 != null) {
                            this.flyTime = 4.0 / ((float)*(int *)(lVar3 + 52) * 0.2 + 1.0)
                            ;
                            if (this.targetSkill != null) {
                              lVar3 = KungfuSkillLvData.DataBase(this.targetSkill,0);
                              if (lVar3 != null) {
                                fVar7 = (float)Mathf.Max(0x3f000000);
                                this.totalExp = 0;
                                this.baseDamage = fVar7 * 4.0;
                                StudyUniqueSkillController.ResetCombo(this,0);
                                this.hit = 0;
                                if (this.targetSkill != null) {
                                  lVar3 = KungfuSkillLvData.DataBase(this.targetSkill,0);
                                  if (lVar3 != null) {
                                    iVar1 = *(int *)(lVar3 + 52);
                                    this.generateTime = 0x3f800000;
                                    this.leftBulletCount = iVar1 * 3 + 20;
                                    MonoBehaviour.Invoke(this,"StartUniqueTutorial",0x3f800000,0);
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

    // Token : 0x600223E
    // RVA   : 0xB992A0   Offset: 0xB97AA0   Length: 0x6A
    public void StartUniqueTutorial()
    {
        var pStatics = *(int64*)(DAT_181d88ad8 + 184);
        if (*pStatics != 0) {
          TutorialController.StartTutorial(*pStatics,"修炼绝技",0);
          return;
        }
    }

    // Token : 0x600223F
    // RVA   : 0xB98610   Offset: 0xB96E10   Length: 0x28
    public void FinishButtonClicked()
    {
        ulong uVar1;
        uVar1 = StudyUniqueSkillController.FinishStudyUniqueSkill(this,1);
        FUN_180d837c0(this,uVar1,0);
    }

    // Token : 0x6002240
    // RVA   : 0xB98640   Offset: 0xB96E40   Length: 0x7B
    public IEnumerator FinishStudyUniqueSkill(StudySkillResult studyUniqueResult)
    {
        long lVar1;
        lVar1 = new WarpText_d__8(0,0);
        if (lVar1 != null) {
          *(uint64 *)(lVar1 + 32) = this;
          *(uint32 *)(lVar1 + 40) = studyUniqueResult;
          return lVar1;
        }
    }

    // Token : 0x6002241
    // RVA   : 0xB97890   Offset: 0xB96090   Length: 0x1DB
    public void ChangeCombo(int num)
    {
        var pStatics = *(int64*)(DAT_181d82f70 + 184);
        long lVar1;
        ulong uVar3;
        uint uVar4;
        ulong local_28;
        uint local_20;
        byte[] local_18 = new byte[16];
        this.combo = this.combo + num;
        if ((*pStatics != 0) &&
           (lVar1 = *(int64 *)(*pStatics + 88)) != null) {
          lVar1 = Component.get_transform(lVar1,0);
          if (lVar1 != null) {
            lVar1 = FUN_180da0f00(lVar1,0);
            puVar2 = (uint64 *)Vector3.get_one(local_18,0);
            if (lVar1 != null) {
              local_20 = *(uint32 *)(puVar2 + 1);
              local_28 = *puVar2;
              Transform.set_localScale(lVar1,&local_28,0);
              if ((*pStatics != 0) &&
                 (lVar1 = *(int64 *)(*pStatics + 88)) != null) {
                lVar1 = Component.get_transform(lVar1,0);
                if (lVar1 != null) {
                  uVar3 = FUN_180da0f00(lVar1,0);
                  if (num < 1) {
                    uVar4 = 0x3f333333;
                  }
                  else {
                    uVar4 = 0x3fa66666;
                  }
                  uVar3 = ShortcutExtensions.DOScale(uVar3,uVar4,0x3dcccccd,0);
                  TweenSettingsExtensions.SetLoops(uVar3,2,1,DAT_181d98060);
                  return;
                }
              }
            }
          }
        }
    }

    // Token : 0x6002242
    // RVA   : 0xB98AB0   Offset: 0xB972B0   Length: 0x106
    public void ResetCombo()
    {
        var pStatics = *(int64*)(DAT_181d82f70 + 184);
        long lVar1;
        ulong local_28;
        uint local_20;
        byte[] local_18 = new byte[16];
        this.combo = 0;
        if ((*pStatics != 0) &&
           (lVar1 = *(int64 *)(*pStatics + 88)) != null) {
          lVar1 = Component.get_transform(lVar1,0);
          if (lVar1 != null) {
            lVar1 = FUN_180da0f00(lVar1,0);
            puVar2 = (uint64 *)Vector3.get_zero(local_18,0);
            if (lVar1 != null) {
              local_20 = *(uint32 *)(puVar2 + 1);
              local_28 = *puVar2;
              Transform.set_localScale(lVar1,&local_28,0);
              return;
            }
          }
        }
    }

    // Token : 0x6002243
    // RVA   : 0xB9A090   Offset: 0xB98890   Length: 0x157
    public void /*ctor*/()
    {
        long lVar1;
        ulong local_28;
        uint local_20;
        byte[] local_18 = new byte[16];
        lVar1 = il2cpp_internal(DAT_181d73eb0);
        FUN_180f58a90(lVar1,DAT_181d841f8);
        puVar2 = (uint64 *)Vector3.get_up(local_18,0);
        if (lVar1 != null) {
          local_20 = *(uint32 *)(puVar2 + 1);
          local_28 = *puVar2;
          FUN_181805a40(lVar1,&local_28,DAT_181d84278);
          puVar2 = (uint64 *)Vector3.get_down(local_18,0);
          local_28 = *puVar2;
          local_20 = *(uint32 *)(puVar2 + 1);
          FUN_181805a40(lVar1,&local_28,DAT_181d84278);
          puVar2 = (uint64 *)Vector3.get_left(local_18,0);
          local_28 = *puVar2;
          local_20 = *(uint32 *)(puVar2 + 1);
          FUN_181805a40(lVar1,&local_28,DAT_181d84278);
          puVar2 = (uint64 *)Vector3.get_right(local_18,0);
          local_28 = *puVar2;
          local_20 = *(uint32 *)(puVar2 + 1);
          FUN_181805a40(lVar1,&local_28,DAT_181d84278);
          this.directionPos = lVar1;
          FUN_18044ef50(this,0);
          return;
        }
    }

}
