// ============================================================
// Type  : CloudController
// Token : 0x200024D
// ============================================================

public class CloudController
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x40011FA
    public SkyObjType skyObjType;

    // Token: 0x40011FB
    public bool moveRight;

    // Token: 0x40011FC
    public float moveSpeed;

    // Token: 0x40011FD
    public float originAlpha;

    // Token: 0x40011FE
    public Color nowColor;

    // Token: 0x40011FF
    public Color targetColor;

    // Token: 0x4001200
    public bool destroying;

    // Token: 0x4001201
    private float refreshTime;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60012EC
    // RVA   : 0x9FD010   Offset: 0x9FB810   Length: 0x5B
    private void Start()
    {
        ulong uVar1;
        long lVar2;
        byte[] local_18 = new byte[16];
        lVar2 = Component.GetComponent(this,DAT_181d6d540);
        if (lVar2 != null) {
          puVar3 = (uint64 *)SpriteRenderer.get_color(local_18,lVar2,0);
          uVar1 = puVar3[1];
          this.nowColor = *puVar3;
          *(uint64 *)(this + 48) = uVar1;
          return;
        }
    }

    // Token : 0x60012ED
    // RVA   : 0x9FD070   Offset: 0x9FB870   Length: 0x7A3
    private void Update()
    {
        var pStatics_e3b0 = *(int64*)(DAT_181d7e3b0 + 184);
        var pStatics_fc60 = *(int64*)(DAT_181d8fc60 + 184);
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
          fVar15 = this.moveSpeed;
          local_88 = uVar7;
          fVar11 = (float)Time.get_deltaTime(0);
          fVar12 = (float)local_98 * fVar15;
          fVar14 = local_98._4_4_ * fVar15;
          fVar15 = fStack_90 * fVar15;
          if ((*pStatics_fc60 != 0) &&
             (lVar6 = WeatherController.GetNowWeather(*pStatics_fc60,0),
             lVar6 != null)) {
            fVar1 = *(float *)(lVar6 + 92);
            fStack_90 = fVar1 * fVar15 * fVar11 + (float)uStack_80;
            uStack_80 = CONCAT44(uStack_80._4_4_,fStack_90);
            local_88 = CONCAT44(fVar1 * fVar14 * fVar11 + local_88._4_4_,
                                fVar12 * fVar11 * fVar1 + (float)local_88);
            Transform.set_localPosition(lVar4,&local_88,0);
            fVar15 = this.refreshTime;
            fVar11 = (float)RealTime.get_deltaTime(0);
            fVar15 = fVar15 - fVar11;
            uVar13 = 0;
            this.refreshTime = fVar15;
            if (0.0 < fVar15) {
              return;
            }
            bVar10 = !DAT_181e78390;
            this.refreshTime = 0x3dcccccd;
            if (bVar10) {
              il2cpp_runtime_class_init(&DAT_181d4ef00);
              DAT_181e78390 = true;
            }
            if ((*pStatics_fc60 != 0) &&
               (lVar4 = WeatherController.GetNowWeather(*pStatics_fc60,0),
               lVar4 != null)) {
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
                fVar15 = this.nowColor;
                fVar11 = this.targetColor;
                if (fVar15 != fVar11) {
                  if (fVar11 < fVar15) {
                    fVar15 = (float)Mathf.Max(fVar15 - 0.01,fVar11,0);
                  }
                  else {
                    fVar15 = (float)Mathf.Min(fVar15 + 0.01);
                  }
                }
                fVar11 = *(float *)(this + 44);
                fVar12 = *(float *)(this + 60);
                if (fVar11 != fVar12) {
                  if (fVar12 < fVar11) {
                    fVar11 = (float)Mathf.Max(fVar11 - 0.01,fVar12,0);
                  }
                  else {
                    fVar11 = (float)Mathf.Min(fVar11 + 0.01);
                  }
                }
                fVar12 = *(float *)(this + 48);
                fVar14 = *(float *)(this + 64);
                if (fVar12 != fVar14) {
                  if (fVar14 < fVar12) {
                    fVar12 = (float)Mathf.Max(fVar12 - 0.01,fVar14,0);
                  }
                  else {
                    fVar12 = (float)Mathf.Min(fVar12 + 0.01);
                  }
                }
                fVar14 = *(float *)(this + 52);
                fVar1 = *(float *)(this + 68);
                if (fVar14 != fVar1) {
                  if (fVar1 < fVar14) {
                    fVar14 = (float)Mathf.Max(fVar14 - 0.01,fVar1,0);
                  }
                  else {
                    fVar14 = (float)Mathf.Min(fVar14 + 0.01);
                  }
                }
                local_88 = 0;
                uStack_80 = 0;
                FUN_1809981e0(&local_88,fVar15,fVar11,fVar12,CONCAT44(uVar16,fVar14),0);
                this.nowColor = (float)local_88;
                *(float *)(this + 44) = local_88._4_4_;
                *(float *)(this + 48) = (float)uStack_80;
                *(uint32 *)(this + 52) = uStack_80._4_4_;
              }
              lVar4 = Component.GetComponent(this,DAT_181d6d540);
              uVar7 = this.nowColor;
              uVar2 = *(uint64 *)(this + 48);
              fVar15 = *(float *)(this + 52);
              if (*pStatics_e3b0 != 0) {
                fVar11 = (float)SkyController.GetScaleAlphaPercent
                                          (*pStatics_e3b0,
                                           this.skyObjType,0);
                local_88 = uVar7;
                uStack_80 = uVar2;
                puVar5 = (uint64 *)GlobalData.SetColorAlpha(&local_98,&local_88,fVar11 * fVar15,0);
                if (lVar4 != null) {
                  local_88 = *puVar5;
                  uStack_80 = puVar5[1];
                  SpriteRenderer.set_color(lVar4,&local_88,0);
                  lVar4 = Component.get_transform(this,0);
                  if (lVar4 != null) {
                    pfVar8 = (float *)Transform.get_localPosition(&local_88,lVar4,0);
                    fVar15 = *pfVar8;
                    if (*pStatics_e3b0 != 0) {
                      fVar11 = (float)SkyController.GetMapSize
                                                (*pStatics_e3b0,
                                                 this.skyObjType,1,0);
                      lVar4 = Component.GetComponent(this,DAT_181d6d540);
                      if ((lVar4 != null) && (lVar4 = SpriteRenderer.get_sprite(lVar4,0)) != null) {
                        puVar9 = (uint32 *)Sprite.get_bounds(&local_88,lVar4,0);
                        local_68 = *puVar9;
                        uStack_64 = puVar9[1];
                        uStack_60 = puVar9[2];
                        uStack_5c = puVar9[3];
                        local_58 = *(uint64 *)(puVar9 + 4);
                        pfVar8 = (float *)Bounds.get_size(&local_88,&local_68,0);
                        fVar12 = *pfVar8;
                        lVar4 = Component.get_transform(this,0);
                        if (lVar4 != null) {
                          pfVar8 = (float *)Transform.get_localScale(&local_88,lVar4,0);
                          if (fVar11 * -0.5 - fVar12 * 0.5 * *pfVar8 < fVar15) {
                            lVar4 = Component.get_transform(this,0);
                            if (lVar4 == null) throw; // [null/range check failed]
                            pfVar8 = (float *)Transform.get_localPosition(&local_88,lVar4,0);
                            fVar15 = *pfVar8;
                            if (*pStatics_e3b0 == 0) throw; // [null/range check failed]
                            fVar11 = (float)SkyController.GetMapSize
                                                      (*pStatics_e3b0,
                                                       this.skyObjType,1,0);
                            lVar4 = Component.GetComponent(this,DAT_181d6d540);
                            if ((lVar4 == null) || (lVar4 = SpriteRenderer.get_sprite(lVar4,0)) == null)
                            throw; // [null/range check failed]
                            puVar9 = (uint32 *)Sprite.get_bounds(&local_88,lVar4,0);
                            local_68 = *puVar9;
                            uStack_64 = puVar9[1];
                            uStack_60 = puVar9[2];
                            uStack_5c = puVar9[3];
                            local_58 = *(uint64 *)(puVar9 + 4);
                            pfVar8 = (float *)Bounds.get_size(&local_88,&local_68,0);
                            fVar12 = *pfVar8;
                            lVar4 = Component.get_transform(this,0);
                            if (lVar4 == null) throw; // [null/range check failed]
                            pfVar8 = (float *)Transform.get_localScale(&local_88,lVar4,0);
                            if (fVar15 < fVar12 * 0.5 * *pfVar8 + fVar11 * 0.5) {
                              return;
                            }
                          }
                          lVar4 = *pStatics_e3b0;
                          uVar7 = Component.get_gameObject(this,0);
                          if (lVar4 != null) {
                            SkyController.DestroyCloud(lVar4,uVar7,0);
                            if (*pStatics_e3b0 != 0) {
                              SkyController.GenerateCloud
                                        (*pStatics_e3b0,
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

    // Token : 0x60012EE
    // RVA   : 0x9FCF20   Offset: 0x9FB720   Length: 0xE8
    public Color GetTargetColor()
    {
        var pStatics = *(int64*)(DAT_181d8fc60 + 184);
        ulong uVar1;
        ulong uVar2;
        long lVar3;
        uint uVar5;
        ulong local_48;
        ulong uStack_40;
        byte[] local_38 = new byte[48];
        if (*pStatics != 0) {
          lVar3 = WeatherController.GetNowWeather(*pStatics,0);
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

    // Token : 0x60012EF
    // RVA   : 0x9FCEF0   Offset: 0x9FB6F0   Length: 0x28
    public float GetChangeColor(float nowColor, float targetColor, float delta)
    {
        void FUN_1809fcef0(uint64 this,float nowColor,float targetColor,float delta)
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

    // Token : 0x60012F0
    // RVA   : 0x3A17B0   Offset: 0x39FFB0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_18044ef50(this,0);
    }

}
