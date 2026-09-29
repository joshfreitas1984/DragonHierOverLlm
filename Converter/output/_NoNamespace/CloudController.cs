// ============================================================
// Type  : CloudController
// Token : 0x2000253
// ============================================================

public class CloudController
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x400129D
    public SkyObjType skyObjType;

    // Token: 0x400129E
    public bool moveRight;

    // Token: 0x400129F
    public float moveSpeed;

    // Token: 0x40012A0
    public float originAlpha;

    // Token: 0x40012A1
    public Color nowColor;

    // Token: 0x40012A2
    public Color targetColor;

    // Token: 0x40012A3
    public bool destroying;

    // Token: 0x40012A4
    private float refreshTime;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x600132D
    // RVA   : 0x9A0090   Offset: 0x99F490   Length: 0x5B
    private void Start()
    {
        ulong uVar1;
        long lVar2;
        byte[] local_18 = new byte[16];
        lVar2 = Component.GetComponent(this,DAT_181d95df8);
        if (lVar2 != null) {
          puVar3 = (uint64 *)SpriteRenderer.get_color(local_18,lVar2,0);
          uVar1 = puVar3[1];
          this.nowColor = *puVar3;
          *(uint64 *)(this + 48) = uVar1;
          return;
        }
    }

    // Token : 0x600132E
    // RVA   : 0x9A00F0   Offset: 0x99F4F0   Length: 0x850
    private void Update()
    {
        var pStatics_35e8 = *(int64*)(DAT_181da35e8 + 184);
        float fVar1;
        ulong uVar2;
        bool cVar3;
        long lVar4;
        long lVar6;
        ulong uVar7;
        float fVar11;
        float fVar12;
        uint uVar13;
        float fVar14;
        float fVar15;
        ulong in_stack_ffffffffffffff58;
        uint uVar16;
        ulong local_98;
        float fStack_90;
        uint32 uStack_8c;
        uint64 local_88;
        uint64 uStack_80;
        uint32 local_68;
        uint32 uStack_64;
        uint32 uStack_60;
        uint32 uStack_5c;
        uint64 local_58;
        uVar16 = (uint32)((uint64)in_stack_ffffffffffffff58 >> 32);
        lVar4 = Component.get_transform(this,0);
        if (lVar4 != null) {
          puVar5 = (uint64 *)Transform.get_localPosition(&local_88,lVar4,0);
          uVar7 = *puVar5;
          uVar13 = *(uint32 *)(puVar5 + 1);
          if (!this.moveRight) {
            puVar5 = (uint64 *)Vector3.get_left(&local_88);
          }
          else {
            puVar5 = (uint64 *)Vector3.get_right();
          }
          local_98 = *puVar5;
          fStack_90 = *(float *)(puVar5 + 1);
          uStack_80 = CONCAT44(uStack_80._4_4_,uVar13);
          fVar12 = this.moveSpeed;
          local_88 = uVar7;
          fVar11 = (float)Time.get_deltaTime(0);
          fVar14 = (float)local_98 * fVar12;
          fVar15 = local_98._4_4_ * fVar12;
          fVar12 = fStack_90 * fVar12;
          lVar6 = BattleController.AttackAreaTypeStartMovePower;
          if ((lVar6 != null) && (lVar6 = WeatherController.GetNowWeather(lVar6,0)) != null) {
            fVar1 = *(float *)(lVar6 + 92);
            fStack_90 = fVar12 * fVar11 * fVar1 + (float)uStack_80;
            uStack_80 = CONCAT44(uStack_80._4_4_,fStack_90);
            local_88 = CONCAT44(fVar15 * fVar11 * fVar1 + local_88._4_4_,
                                fVar14 * fVar11 * fVar1 + (float)local_88);
            Transform.set_localPosition(lVar4,&local_88,0);
            fVar12 = this.refreshTime;
            fVar11 = (float)RealTime.get_deltaTime(0);
            fVar12 = fVar12 - fVar11;
            uVar13 = 0;
            this.refreshTime = fVar12;
            if (0.0 < fVar12) {
              return;
            }
            bVar10 = !DAT_181e9d714;
            this.refreshTime = 0x3dcccccd;
            if (bVar10) {
              il2cpp_runtime_class_init(&DAT_181d73d40);
              il2cpp_runtime_class_init(&DAT_181db4f30);
              DAT_181e9d714 = true;
            }
            lVar4 = BattleController.AttackAreaTypeStartMovePower;
            if ((lVar4 != null) && (lVar4 = WeatherController.GetNowWeather(lVar4,0)) != null) {
              uVar7 = *(uint64 *)(lVar4 + 96);
              uVar2 = *(uint64 *)(lVar4 + 104);
              if (!this.destroying) {
                uVar13 = this.originAlpha;
              }
              local_88 = uVar7;
              uStack_80 = uVar2;
              puVar5 = (uint64 *)GlobalData.SetColorAlpha(&local_98,&local_88,uVar13,0);
              uVar7 = puVar5[1];
              this.targetColor = *puVar5;
              *(uint64 *)(this + 64) = uVar7;
              local_88 = *puVar5;
              uStack_80 = puVar5[1];
              local_98 = this.nowColor;
              fStack_90 = *(float *)(this + 48);
              uStack_8c = *(uint32 *)(this + 52);
              cVar3 = Color.op_Inequality(&local_98,&local_88,0);
              if (!cVar3) {
                if (this.destroying) {
                  uVar7 = Component.get_gameObject(this,0);
                  Object.Destroy(uVar7,0);
                  return;
                }
              }
              else {
                fVar12 = this.nowColor;
                fVar11 = this.targetColor;
                if (fVar12 != fVar11) {
                  if (fVar11 < fVar12) {
                    fVar12 = (float)Mathf.Max(fVar12 - 0.01,fVar11,0);
                  }
                  else {
                    fVar12 = (float)Mathf.Min(fVar12 + 0.01);
                  }
                }
                fVar11 = *(float *)(this + 44);
                fVar14 = *(float *)(this + 60);
                if (fVar11 != fVar14) {
                  if (fVar14 < fVar11) {
                    fVar11 = (float)Mathf.Max(fVar11 - 0.01,fVar14,0);
                  }
                  else {
                    fVar11 = (float)Mathf.Min(fVar11 + 0.01);
                  }
                }
                fVar14 = *(float *)(this + 48);
                fVar15 = *(float *)(this + 64);
                if (fVar14 != fVar15) {
                  if (fVar15 < fVar14) {
                    fVar14 = (float)Mathf.Max(fVar14 - 0.01,fVar15,0);
                  }
                  else {
                    fVar14 = (float)Mathf.Min(fVar14 + 0.01);
                  }
                }
                fVar15 = *(float *)(this + 52);
                fVar1 = *(float *)(this + 68);
                if (fVar15 != fVar1) {
                  if (fVar1 < fVar15) {
                    fVar15 = (float)Mathf.Max(fVar15 - 0.01,fVar1,0);
                  }
                  else {
                    fVar15 = (float)Mathf.Min(fVar15 + 0.01);
                  }
                }
                local_88 = 0;
                uStack_80 = 0;
                FUN_1809dcfa0(&local_88,fVar12,fVar11,fVar14,CONCAT44(uVar16,fVar15),0);
                this.nowColor = (float)local_88;
                *(float *)(this + 44) = local_88._4_4_;
                *(float *)(this + 48) = (float)uStack_80;
                *(uint32 *)(this + 52) = uStack_80._4_4_;
              }
              lVar4 = Component.GetComponent(this,DAT_181d95df8);
              uVar7 = this.nowColor;
              uVar2 = *(uint64 *)(this + 48);
              fVar12 = *(float *)(this + 52);
              if (*pStatics_35e8 != 0) {
                fVar11 = (float)SkyController.GetScaleAlphaPercent
                                          (*pStatics_35e8,
                                           this.skyObjType,0);
                local_88 = uVar7;
                uStack_80 = uVar2;
                puVar5 = (uint64 *)GlobalData.SetColorAlpha(&local_98,&local_88,fVar11 * fVar12,0);
                if (lVar4 != null) {
                  local_88 = *puVar5;
                  uStack_80 = puVar5[1];
                  SpriteRenderer.set_color(lVar4,&local_88,0);
                  lVar4 = Component.get_transform(this,0);
                  if (lVar4 != null) {
                    pfVar8 = (float *)Transform.get_localPosition(&local_88,lVar4,0);
                    fVar12 = *pfVar8;
                    if (*pStatics_35e8 != 0) {
                      fVar11 = (float)SkyController.GetMapSize
                                                (*pStatics_35e8,
                                                 this.skyObjType,1,0);
                      lVar4 = Component.GetComponent(this,DAT_181d95df8);
                      if ((lVar4 != null) && (lVar4 = SpriteRenderer.get_sprite(lVar4,0)) != null) {
                        puVar9 = (uint32 *)Sprite.get_bounds(&local_88,lVar4,0);
                        local_68 = *puVar9;
                        uStack_64 = puVar9[1];
                        uStack_60 = puVar9[2];
                        uStack_5c = puVar9[3];
                        local_58 = *(uint64 *)(puVar9 + 4);
                        pfVar8 = (float *)Bounds.get_size(&local_88,&local_68,0);
                        fVar14 = *pfVar8;
                        lVar4 = Component.get_transform(this,0);
                        if (lVar4 != null) {
                          pfVar8 = (float *)Transform.get_localScale(&local_88,lVar4,0);
                          if (fVar11 * -0.5 - fVar14 * 0.5 * *pfVar8 < fVar12) {
                            lVar4 = Component.get_transform(this,0);
                            if (lVar4 == null) throw; // [null/range check failed]
                            pfVar8 = (float *)Transform.get_localPosition(&local_88,lVar4,0);
                            fVar12 = *pfVar8;
                            if (*pStatics_35e8 == 0) throw; // [null/range check failed]
                            fVar11 = (float)SkyController.GetMapSize
                                                      (*pStatics_35e8,
                                                       this.skyObjType,1,0);
                            lVar4 = Component.GetComponent(this,DAT_181d95df8);
                            if ((lVar4 == null) || (lVar4 = SpriteRenderer.get_sprite(lVar4,0)) == null)
                            throw; // [null/range check failed]
                            puVar9 = (uint32 *)Sprite.get_bounds(&local_88,lVar4,0);
                            local_68 = *puVar9;
                            uStack_64 = puVar9[1];
                            uStack_60 = puVar9[2];
                            uStack_5c = puVar9[3];
                            local_58 = *(uint64 *)(puVar9 + 4);
                            pfVar8 = (float *)Bounds.get_size(&local_88,&local_68,0);
                            fVar14 = *pfVar8;
                            lVar4 = Component.get_transform(this,0);
                            if (lVar4 == null) throw; // [null/range check failed]
                            pfVar8 = (float *)Transform.get_localScale(&local_88,lVar4,0);
                            if (fVar12 < fVar14 * 0.5 * *pfVar8 + fVar11 * 0.5) {
                              return;
                            }
                          }
                          lVar4 = *pStatics_35e8;
                          uVar7 = Component.get_gameObject(this,0);
                          if (lVar4 != null) {
                            SkyController.DestroyCloud(lVar4,uVar7,0);
                            if (*pStatics_35e8 != 0) {
                              SkyController.GenerateCloud
                                        (*pStatics_35e8,
                                         this.skyObjType,1,0,0);
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

    // Token : 0x600132F
    // RVA   : 0x99FF50   Offset: 0x99F350   Length: 0x13E
    public Color GetTargetColor()
    {
        ulong uVar1;
        ulong uVar2;
        long lVar3;
        uint uVar5;
        ulong local_48;
        ulong uStack_40;
        byte[] local_38 = new byte[48];
        lVar3 = *(int64 *)(*(int64 *)(DAT_181db4f30 + 184) + 8);
        if (lVar3 != null) {
          lVar3 = WeatherController.GetNowWeather(lVar3,0);
          if (lVar3 != null) {
            uVar1 = *(uint64 *)(lVar3 + 96);
            uVar2 = *(uint64 *)(lVar3 + 104);
            if (*(char *)(param_2 + 72) == false) {
              uVar5 = *(uint32 *)(param_2 + 36);
            }
            else {
              uVar5 = 0;
            }
            local_48 = uVar1;
            uStack_40 = uVar2;
            puVar4 = (uint64 *)GlobalData.SetColorAlpha(local_38,&local_48,uVar5,0);
            uVar1 = puVar4[1];
            *this = *puVar4;
            this[1] = uVar1;
            return this;
          }
        }
    }

    // Token : 0x6001330
    // RVA   : 0x99FF20   Offset: 0x99F320   Length: 0x28
    public float GetChangeColor(float nowColor, float targetColor, float delta)
    {
        void FUN_18099ff20(uint64 this,float nowColor,float targetColor,float delta)
        {
        if (nowColor == targetColor) {
          return;
        }
        if (targetColor < nowColor) {
          Mathf.Max(nowColor - delta,targetColor,0);
          return;
        }
        Mathf.Min(nowColor + delta);
    }

    // Token : 0x6001331
    // RVA   : 0x3A17B0   Offset: 0x3A0BB0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_18044ef50(this,0);
    }

}
