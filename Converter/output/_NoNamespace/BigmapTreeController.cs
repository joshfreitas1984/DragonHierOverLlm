// ============================================================
// Type  : BigmapTreeController
// Token : 0x200019D
// ============================================================

public class BigmapTreeController
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4000B5D
    private readonly List<Collider> colliders;

    // Token: 0x4000B5E
    private static Color hideColor;

    // Token: 0x4000B5F
    private float refreshTime;

    // Token: 0x4000B60
    private bool tweening;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000D51
    // RVA   : 0xC82DB0   Offset: 0xC821B0   Length: 0x37E
    private void Update()
    {
        long lVar1;
        bool cVar2;
        ulong uVar4;
        ulong uVar5;
        ulong uVar6;
        uint uVar7;
        long lVar8;
        float fVar9;
        float fVar10;
        ulong local_38;
        ulong uStack_30;
        ulong local_28;
        ulong uStack_20;
        fVar10 = this.refreshTime;
        fVar9 = (float)Time.get_deltaTime(0);
        fVar10 = fVar10 - fVar9;
        this.refreshTime = fVar10;
        if (fVar10 <= 0.0) {
          lVar8 = this.colliders;
          this.refreshTime = 0x3e4ccccd;
          if (lVar8 == null) {
        LAB_180c83129:
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          uVar7 = lVar8.Count - 1;
          if (-1 < (int)uVar7) {
            lVar8 = (int64)(int)uVar7 * 8 + 32;
            do {
              lVar1 = this.colliders;
              if (lVar1 == null) goto LAB_180c83129;
              if (lVar1.Count <= uVar7) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              uVar4 = *(uint64 *)(lVar8 + lVar1._items);
              cVar2 = Object.op_Equality(uVar4,0,0);
              if (cVar2) {
                if (this.colliders == null) goto LAB_180c83129;
                FUN_181823590();
              }
              lVar8 = lVar8 + -8;
              uVar7 = uVar7 - 1;
            } while (-1 < (int)uVar7);
            lVar8 = this.colliders;
            if (lVar8 == null) goto LAB_180c83129;
          }
          if (lVar8.Count < 1) {
            lVar8 = Component.GetComponent(this,DAT_181d95de0);
            if (lVar8 == null) goto LAB_180c83129;
            puVar3 = (uint64 *)SpriteRenderer.get_color(&local_28,lVar8,0);
            uVar4 = *puVar3;
            uVar5 = puVar3[1];
            puVar3 = (uint64 *)FUN_1810d3570(&local_28,0);
            local_38 = *puVar3;
            uStack_30 = puVar3[1];
            local_28 = uVar4;
            uStack_20 = uVar5;
            cVar2 = Color.op_Inequality(&local_28,&local_38,0);
            if (!cVar2) {
              return;
            }
            if (this.tweening) {
              return;
            }
            this.tweening = 1;
            uVar4 = Component.GetComponent(this,DAT_181d95de0);
            puVar3 = (uint64 *)FUN_1810d3570(&local_28,0);
            local_28 = *puVar3;
            uStack_20 = puVar3[1];
            uVar5 = DOTweenModuleSprite.DOColor(uVar4,&local_28,0x3e4ccccd,0);
            uVar6 = il2cpp_internal(DAT_181daddf8);
            uVar4 = DAT_181d8a770;
          }
          else {
            lVar8 = Component.GetComponent(this,DAT_181d95de0);
            if (lVar8 == null) goto LAB_180c83129;
            puVar3 = (uint64 *)SpriteRenderer.get_color(&local_28,lVar8,0);
            local_38 = *puVar3;
            uStack_30 = puVar3[1];
            local_28 = **(uint64 **)(DAT_181db0ec8 + 184);
            uStack_20 = (*(uint64 **)(DAT_181db0ec8 + 184))[1];
            cVar2 = Color.op_Inequality(&local_38,&local_28,0);
            if (!cVar2) {
              return;
            }
            if (this.tweening) {
              return;
            }
            this.tweening = 1;
            uVar4 = Component.GetComponent(this,DAT_181d95de0);
            local_28 = **(uint64 **)(DAT_181db0ec8 + 184);
            uStack_20 = (*(uint64 **)(DAT_181db0ec8 + 184))[1];
            uVar5 = DOTweenModuleSprite.DOColor(uVar4,&local_28,0x3e4ccccd,0);
            uVar6 = il2cpp_internal(DAT_181daddf8);
            uVar4 = DAT_181d8a6f0;
          }
          OnTooltipCB.ctor(uVar6,this,uVar4,0);
          TweenSettingsExtensions.OnComplete(uVar5,uVar6,DAT_181dbffb0);
        }
    }

    // Token : 0x6000D52
    // RVA   : 0xC82BE0   Offset: 0xC81FE0   Length: 0x111
    private void OnTriggerEnter(Collider other)
    {
        bool cVar1;
        long lVar2;
        if (other != null) {
          cVar1 = Component.CompareTag(other,"ResourcePoint",0);
          if (!cVar1) {
            cVar1 = Component.CompareTag(other,"HeroInteractRange",0);
            if ((!cVar1) && (cVar1 = Component.CompareTag(other,"BigmapRandomEvent",0), !cVar1)
               ) {
              return;
            }
            if (this.colliders != null) {
              cVar1 = FUN_18181e400(this.colliders,other,DAT_181d828a0);
              if (!cVar1) {
                if (this.colliders == null) throw; // [null/range check failed]
                FUN_18181e0a0(this.colliders,other,DAT_181d827a0);
              }
              return;
            }
          }
          else {
            lVar2 = Component.get_gameObject(this,0);
            if (lVar2 != null) {
              GameObject.SetActive(lVar2,0,0);
              return;
            }
          }
        }
    }

    // Token : 0x6000D53
    // RVA   : 0xC82D00   Offset: 0xC82100   Length: 0x9D
    private void OnTriggerExit(Collider other)
    {
        bool cVar1;
        if (other != null) {
          cVar1 = Component.CompareTag(other,"HeroInteractRange",0);
          if ((!cVar1) && (cVar1 = Component.CompareTag(other,"BigmapRandomEvent",0), !cVar1))
          {
            return;
          }
          if (this.colliders != null) {
            FUN_1817eee00(this.colliders,other,DAT_181d829a0);
            return;
          }
        }
    }

    // Token : 0x6000D54
    // RVA   : 0xC831B0   Offset: 0xC825B0   Length: 0x76
    public void /*ctor*/()
    {
        ulong uVar1;
        uVar1 = il2cpp_internal(DAT_181d91cd8);
        FUN_18132faf0(uVar1,DAT_181d826a0);
        this.colliders = uVar1;
        FUN_18044ef50(this,0);
    }

    // Token : 0x6000D55
    // RVA   : 0xC83130   Offset: 0xC82530   Length: 0x72
    private static void /*cctor*/()
    {
        ulong local_18;
        ulong uStack_10;
        local_18 = 0;
        uStack_10 = 0;
        FUN_1809dc910(&local_18,0x3f800000,0x3f800000,0x3f800000,0x3e99999a,0);
        puVar1 = *(uint64 **)(DAT_181db0ec8 + 184);
        *puVar1 = local_18;
        puVar1[1] = uStack_10;
    }

    // Token : 0x6000D56
    // RVA   : 0xC82DA0   Offset: 0xC821A0   Length: 0x5
    private void <Update>b__4_0()
    {
        void FUN_180c82da0(int64 this)
        {
        this.tweening = 0;
    }

    // Token : 0x6000D57
    // RVA   : 0xC82DA0   Offset: 0xC821A0   Length: 0x5
    private void <Update>b__4_1()
    {
        void FUN_180c82da0(int64 this)
        {
        this.tweening = 0;
    }

}
