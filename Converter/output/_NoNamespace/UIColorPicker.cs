// ============================================================
// Type  : UIColorPicker
// Token : 0x20000F2
// ============================================================

public class UIColorPicker
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x40005AC
    public static UIColorPicker current;

    // Token: 0x40005AD
    public Color value;

    // Token: 0x40005AE
    public UIWidget selectionWidget;

    // Token: 0x40005AF
    public List<EventDelegate> onChange;

    // Token: 0x40005B0
    private Transform mTrans;

    // Token: 0x40005B1
    private UITexture mUITex;

    // Token: 0x40005B2
    private Texture2D mTex;

    // Token: 0x40005B3
    private UICamera mCam;

    // Token: 0x40005B4
    private Vector2 mPos;

    // Token: 0x40005B5
    private int mWidth;

    // Token: 0x40005B6
    private int mHeight;

    // Token: 0x40005B7
    private static AnimationCurve mRed;

    // Token: 0x40005B8
    private static AnimationCurve mGreen;

    // Token: 0x40005B9
    private static AnimationCurve mBlue;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x600077A
    // RVA   : 0x13D4BA0   Offset: 0x13D33A0   Length: 0x306
    private void Start()
    {
        uint uVar3;
        ulong uVar4;
        long lVar5;
        int iVar7;
        uint uVar8;
        int iVar9;
        int iVar10;
        int iVar11;
        ulong local_48;
        ulong uStack_40;
        uVar4 = Component.get_transform(this,0);
        this.mTrans = uVar4;
        uVar4 = Component.GetComponent(this,DAT_181d6e6c0);
        this.mUITex = uVar4;
        lVar5 = Component.get_gameObject(this,0);
        if (lVar5 != null) {
          uVar3 = GameObject.get_layer(lVar5,0);
          uVar4 = UICamera.FindCameraForLayer(uVar3,0);
          this.mCam = uVar4;
          lVar5 = this.mUITex;
          if (lVar5 != null) {
            iVar9 = *(int *)(lVar5 + 164);
            this.mWidth = iVar9;
            iVar11 = *(int *)(lVar5 + 168);
            *(int *)(this + 100) = iVar11;
            lVar5 = FUN_1800d60b0(DAT_181d7c218,iVar11 * iVar9);
            iVar9 = *(int *)(this + 100);
            iVar11 = 0;
            if (iVar9 < 1) {
              iVar10 = this.mWidth;
            }
            else {
              do {
                iVar10 = this.mWidth;
                iVar7 = 0;
                if (0 < iVar10) {
                  do {
                    uVar8 = iVar10 * iVar11 + iVar7;
                    puVar6 = (uint64 *)
                             UIColorPicker.Sample
                                       (&local_48,((float)iVar7 - 1.0) / (float)iVar10,
                                        ((float)iVar11 - 1.0) / (float)iVar9,0);
                    if (lVar5 == null) throw; // [null/range check failed]
                    if (*(uint32 *)(lVar5 + 24) <= uVar8) {
                      uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                      FUN_1800d65f0(uVar4,0);
                    }
                    uVar4 = puVar6[1];
                    iVar7 = iVar7 + 1;
                    puVar1 = (uint64 *)(lVar5 + ((int64)(int)uVar8 + 2) * 16);
                    *puVar1 = *puVar6;
                    puVar1[1] = uVar4;
                    iVar10 = this.mWidth;
                  } while (iVar7 < iVar10);
                }
                iVar9 = *(int *)(this + 100);
                iVar11 = iVar11 + 1;
              } while (iVar11 < iVar9);
            }
            this.mTex = new Texture2D(iVar10,iVar9,3,0,0);
            if (this.mTex != null) {
              Texture2D.SetPixels(this.mTex,lVar5,0);
              if (this.mTex != null) {
                Texture.set_filterMode(this.mTex,2);
                if (this.mTex != null) {
                  Texture.set_wrapMode(this.mTex,1);
                  if (this.mTex != null) {
                    Texture2D.Apply(this.mTex,0);
                    plVar2 = this.mUITex;
                    if (plVar2 != (int64 *)0) {
                      (**(code **)(*plVar2 + 0x2f8))
                                (plVar2,this.mTex,*(uint64 *)(*plVar2 + 0x300));
                      local_48 = this.value;
                      uStack_40 = *(uint64 *)(this + 32);
                      UIColorPicker.Select(this,&local_48,0);
                      return;
                    }
                  }
                }
              }
            }
          }
        }
    }

    // Token : 0x600077B
    // RVA   : 0x13D3210   Offset: 0x13D1A10   Length: 0x72
    private void OnDestroy()
    {
        ulong uVar1;
        uVar1 = this.mTex;
        Object.Destroy(uVar1,0);
        this.mTex = 0;
    }

    // Token : 0x600077C
    // RVA   : 0x13D3330   Offset: 0x13D1B30   Length: 0x7A
    private void OnPress(bool pressed)
    {
        int iVar2;
        bVar1 = Behaviour.get_enabled(this,0);
        if ((pressed & bVar1) != 0) {
          iVar2 = UICamera.get_currentScheme(0);
          if (iVar2 != 2) {
            UIColorPicker.Sample(this,0);
          }
        }
    }

    // Token : 0x600077D
    // RVA   : 0x13D3290   Offset: 0x13D1A90   Length: 0x29
    private void OnDrag(Vector2 delta)
    {
        bool cVar1;
        cVar1 = Behaviour.get_enabled(this,0);
        if (cVar1) {
          UIColorPicker.Sample(this,0);
          return;
        }
    }

    // Token : 0x600077E
    // RVA   : 0x13D32C0   Offset: 0x13D1AC0   Length: 0x6D
    private void OnPan(Vector2 delta)
    {
        bool cVar1;
        uint uVar2;
        uint local_18;
        uint uStack_14;
        cVar1 = Behaviour.get_enabled(this,0);
        if (cVar1) {
          local_18 = (float)delta;
          uVar2 = Mathf.Clamp01(local_18 + this.mPos,0);
          this.mPos = uVar2;
          uStack_14 = (float)((uint64)delta >> 32);
          uVar2 = Mathf.Clamp01(uStack_14 + *(float *)(this + 92),0);
          *(uint32 *)(this + 92) = uVar2;
          UIColorPicker.Select(this,CONCAT44(uVar2,this.mPos),0);
          return;
        }
    }

    // Token : 0x600077F
    // RVA   : 0x13D40E0   Offset: 0x13D28E0   Length: 0x3A1
    private void Sample()
    {
        var pStatics = *(int64*)(DAT_181d8a558 + 184);
        long lVar1;
        ulong uVar2;
        float fVar4;
        float fVar5;
        float fVar6;
        float fVar7;
        byte[] local_388 = new byte[8];
        float local_380;
        ulong local_378;
        ulong uStack_370;
        ulong local_368;
        uint local_360;
        ulong local_358;
        ulong uStack_350;
        ulong local_348;
        uint local_340;
        ulong local_338;
        ulong uStack_330;
        ulong local_328;
        uint local_320;
        ulong local_318;
        ulong uStack_310;
        ulong local_308;
        uint local_300;
        uint64 local_2f8;
        uint64 uStack_2f0;
        uint64 local_2e8;
        uint32 local_2e0;
        uint64 local_2d8;
        uint64 uStack_2d0;
        uint64 local_2c8;
        uint32 local_2c0;
        uint64 local_2b8;
        uint64 uStack_2b0;
        uint64 local_2a8;
        uint32 local_2a0;
        uint64 local_298;
        uint64 uStack_290;
        uint64 local_288;
        uint32 local_280;
        uint64 local_278;
        uint64 uStack_270;
        uint64 local_268;
        uint32 local_260;
        uint64 local_258;
        uint64 uStack_250;
        uint64 local_248;
        uint32 local_240;
        uint64 local_238;
        uint64 uStack_230;
        uint64 local_228;
        uint32 local_220;
        uint64 local_218;
        uint64 uStack_210;
        uint64 local_208;
        uint32 local_200;
        uint64 local_1f8;
        uint64 uStack_1f0;
        uint64 local_1e8;
        uint32 local_1e0;
        uint64 local_1d8;
        uint64 uStack_1d0;
        uint64 local_1c8;
        uint32 local_1c0;
        uint64 local_1b8;
        uint64 uStack_1b0;
        uint64 local_1a8;
        uint32 local_1a0;
        uint64 local_198;
        uint64 uStack_190;
        uint64 local_188;
        uint32 local_180;
        uint64 local_178;
        uint64 uStack_170;
        uint64 local_168;
        uint32 local_160;
        uint64 local_158;
        uint64 uStack_150;
        uint64 local_148;
        uint32 local_140;
        uint64 local_138;
        uint64 uStack_130;
        uint64 local_128;
        uint32 local_120;
        uint64 local_118;
        uint64 uStack_110;
        uint64 local_108;
        uint32 local_100;
        uint64 local_f8;
        uint64 uStack_f0;
        uint64 local_e8;
        uint32 local_e0;
        uint64 local_d8;
        uint64 uStack_d0;
        uint64 local_c8;
        uint32 local_c0;
        uint64 local_b8;
        uint64 uStack_b0;
        uint64 local_a8;
        uint32 local_a0;
        uint64 local_98;
        uint64 uStack_90;
        uint64 local_88;
        uint32 local_80;
        if (*(int64 *)(pStatics + 8) != 0) {
        LAB_1813d3dda:
          lVar1 = *(int64 *)(pStatics + 8);
          if (lVar1 != null) {
            fVar4 = (float)AnimationCurve.Evaluate(lVar1,param_2,0);
            lVar1 = *(int64 *)(pStatics + 16);
            if (lVar1 != null) {
              fVar5 = (float)AnimationCurve.Evaluate(lVar1,param_2,0);
              lVar1 = *(int64 *)(pStatics + 24);
              if (lVar1 != null) {
                fVar6 = (float)AnimationCurve.Evaluate(lVar1,param_2,0);
                fVar7 = param_3 + param_3;
                if (param_3 < 0.5) {
                  fVar5 = fVar5 * fVar7;
                  fVar4 = fVar4 * fVar7;
                  fVar6 = fVar6 * fVar7;
                }
                else {
                  puVar3 = (uint64 *)Vector3.get_one(local_388,0);
                  uVar2 = *puVar3;
                  local_380 = *(float *)(puVar3 + 1);
                  fVar7 = (float)Mathf.Clamp01(fVar7 - 1.0,0);
                  fVar6 = (local_380 - fVar6) * fVar7 + fVar6;
                  fVar5 = ((float)((uint64)uVar2 >> 32) - fVar5) * fVar7 + fVar5;
                  fVar4 = ((float)uVar2 - fVar4) * fVar7 + fVar4;
                }
                *this = 0;
                this[1] = 0;
                FUN_1809981e0(this,fVar4,fVar5,fVar6,0x3f800000,0);
                return this;
              }
            }
          }
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
        lVar1 = FUN_1800d60b0(DAT_181d7ec00,8);
        local_368 = 0;
        local_360 = 0;
        local_378 = 0;
        uStack_370 = 0;
        Keyframe.ctor(&local_378,0,0x3f800000,0);
        if (lVar1 != null) {
          if (*(int *)(lVar1 + 24) == 0) {
            uVar2 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar2,0);
          }
          *(uint64 *)(lVar1 + 32) = local_378;
          *(uint64 *)(lVar1 + 40) = uStack_370;
          *(uint64 *)(lVar1 + 48) = local_368;
          *(uint32 *)(lVar1 + 56) = local_360;
          local_348 = 0;
          local_340 = 0;
          local_358 = 0;
          uStack_350 = 0;
          Keyframe.ctor(&local_358,0x3e124925,0x3f800000,0);
          if (*(uint32 *)(lVar1 + 24) < 2) {
            uVar2 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar2,0);
          }
          *(uint64 *)(lVar1 + 60) = local_358;
          *(uint64 *)(lVar1 + 68) = uStack_350;
          *(uint64 *)(lVar1 + 76) = local_348;
          *(uint32 *)(lVar1 + 84) = local_340;
          local_328 = 0;
          local_320 = 0;
          local_338 = 0;
          uStack_330 = 0;
          Keyframe.ctor(&local_338,0x3e924925,0,0);
          if (*(uint32 *)(lVar1 + 24) < 3) {
            uVar2 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar2,0);
          }
          *(uint64 *)(lVar1 + 88) = local_338;
          *(uint64 *)(lVar1 + 96) = uStack_330;
          *(uint64 *)(lVar1 + 104) = local_328;
          *(uint32 *)(lVar1 + 112) = local_320;
          local_308 = 0;
          local_300 = 0;
          local_318 = 0;
          uStack_310 = 0;
          Keyframe.ctor(&local_318,0x3edb6db7,0,0);
          if (*(uint32 *)(lVar1 + 24) < 4) {
            uVar2 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar2,0);
          }
          *(uint64 *)(lVar1 + 116) = local_318;
          *(uint64 *)(lVar1 + 124) = uStack_310;
          *(uint64 *)(lVar1 + 132) = local_308;
          *(uint32 *)(lVar1 + 140) = local_300;
          local_2e8 = 0;
          local_2e0 = 0;
          local_2f8 = 0;
          uStack_2f0 = 0;
          Keyframe.ctor(&local_2f8,0x3f124925,0,0);
          if (*(uint32 *)(lVar1 + 24) < 5) {
            uVar2 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar2,0);
          }
          *(uint64 *)(lVar1 + 144) = local_2f8;
          *(uint64 *)(lVar1 + 152) = uStack_2f0;
          *(uint64 *)(lVar1 + 160) = local_2e8;
          *(uint32 *)(lVar1 + 168) = local_2e0;
          local_2c8 = 0;
          local_2c0 = 0;
          local_2d8 = 0;
          uStack_2d0 = 0;
          Keyframe.ctor(&local_2d8,0x3f36db6e,0x3f800000,0);
          if (*(uint32 *)(lVar1 + 24) < 6) {
            uVar2 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar2,0);
          }
          *(uint64 *)(lVar1 + 172) = local_2d8;
          *(uint64 *)(lVar1 + 180) = uStack_2d0;
          *(uint64 *)(lVar1 + 188) = local_2c8;
          *(uint32 *)(lVar1 + 196) = local_2c0;
          local_2a8 = 0;
          local_2a0 = 0;
          local_2b8 = 0;
          uStack_2b0 = 0;
          Keyframe.ctor(&local_2b8,0x3f5b6db7,0x3f800000,0);
          if (*(uint32 *)(lVar1 + 24) < 7) {
            uVar2 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar2,0);
          }
          *(uint64 *)(lVar1 + 200) = local_2b8;
          *(uint64 *)(lVar1 + 208) = uStack_2b0;
          *(uint64 *)(lVar1 + 216) = local_2a8;
          *(uint32 *)(lVar1 + 224) = local_2a0;
          local_288 = 0;
          local_280 = 0;
          local_298 = 0;
          uStack_290 = 0;
          Keyframe.ctor(&local_298,0x3f800000,0x3f000000,0);
          if (*(uint32 *)(lVar1 + 24) < 8) {
            uVar2 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar2,0);
          }
          *(uint32 *)(lVar1 + 228) = (uint32)local_298;
          *(uint32 *)(lVar1 + 232) = local_298._4_4_;
          *(uint32 *)(lVar1 + 236) = (uint32)uStack_290;
          *(uint32 *)(lVar1 + 240) = uStack_290._4_4_;
          *(uint64 *)(lVar1 + 244) = local_288;
          *(uint32 *)(lVar1 + 252) = local_280;
          uVar2 = new AnimationCurve(lVar1,0);
          puVar3 = (uint64 *)(pStatics + 8);
          *puVar3 = uVar2;
          il2cpp_internal(puVar3,uVar2);
          lVar1 = FUN_1800d60b0(DAT_181d7ec00,8);
          local_268 = 0;
          local_260 = 0;
          local_278 = 0;
          uStack_270 = 0;
          Keyframe.ctor(&local_278,0,0,0);
          if (lVar1 != null) {
            if (*(int *)(lVar1 + 24) == 0) {
              uVar2 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar2,0);
            }
            *(uint64 *)(lVar1 + 32) = local_278;
            *(uint64 *)(lVar1 + 40) = uStack_270;
            *(uint64 *)(lVar1 + 48) = local_268;
            *(uint32 *)(lVar1 + 56) = local_260;
            local_248 = 0;
            local_240 = 0;
            local_258 = 0;
            uStack_250 = 0;
            Keyframe.ctor(&local_258,0x3e124925,0x3f800000,0);
            if (*(uint32 *)(lVar1 + 24) < 2) {
              uVar2 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar2,0);
            }
            *(uint64 *)(lVar1 + 60) = local_258;
            *(uint64 *)(lVar1 + 68) = uStack_250;
            *(uint64 *)(lVar1 + 76) = local_248;
            *(uint32 *)(lVar1 + 84) = local_240;
            local_228 = 0;
            local_220 = 0;
            local_238 = 0;
            uStack_230 = 0;
            Keyframe.ctor(&local_238,0x3e924925,0x3f800000,0);
            if (*(uint32 *)(lVar1 + 24) < 3) {
              uVar2 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar2,0);
            }
            *(uint64 *)(lVar1 + 88) = local_238;
            *(uint64 *)(lVar1 + 96) = uStack_230;
            *(uint64 *)(lVar1 + 104) = local_228;
            *(uint32 *)(lVar1 + 112) = local_220;
            local_208 = 0;
            local_200 = 0;
            local_218 = 0;
            uStack_210 = 0;
            Keyframe.ctor(&local_218,0x3edb6db7,0x3f800000,0);
            if (*(uint32 *)(lVar1 + 24) < 4) {
              uVar2 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar2,0);
            }
            *(uint64 *)(lVar1 + 116) = local_218;
            *(uint64 *)(lVar1 + 124) = uStack_210;
            *(uint64 *)(lVar1 + 132) = local_208;
            *(uint32 *)(lVar1 + 140) = local_200;
            local_1e8 = 0;
            local_1e0 = 0;
            local_1f8 = 0;
            uStack_1f0 = 0;
            Keyframe.ctor(&local_1f8,0x3f124925,0,0);
            if (*(uint32 *)(lVar1 + 24) < 5) {
              uVar2 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar2,0);
            }
            *(uint64 *)(lVar1 + 144) = local_1f8;
            *(uint64 *)(lVar1 + 152) = uStack_1f0;
            *(uint64 *)(lVar1 + 160) = local_1e8;
            *(uint32 *)(lVar1 + 168) = local_1e0;
            local_1c8 = 0;
            local_1c0 = 0;
            local_1d8 = 0;
            uStack_1d0 = 0;
            Keyframe.ctor(&local_1d8,0x3f36db6e,0,0);
            if (*(uint32 *)(lVar1 + 24) < 6) {
              uVar2 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar2,0);
            }
            *(uint64 *)(lVar1 + 172) = local_1d8;
            *(uint64 *)(lVar1 + 180) = uStack_1d0;
            *(uint64 *)(lVar1 + 188) = local_1c8;
            *(uint32 *)(lVar1 + 196) = local_1c0;
            local_1a8 = 0;
            local_1a0 = 0;
            local_1b8 = 0;
            uStack_1b0 = 0;
            Keyframe.ctor(&local_1b8,0x3f5b6db7,0,0);
            if (*(uint32 *)(lVar1 + 24) < 7) {
              uVar2 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar2,0);
            }
            *(uint64 *)(lVar1 + 200) = local_1b8;
            *(uint64 *)(lVar1 + 208) = uStack_1b0;
            *(uint64 *)(lVar1 + 216) = local_1a8;
            *(uint32 *)(lVar1 + 224) = local_1a0;
            local_188 = 0;
            local_180 = 0;
            local_198 = 0;
            uStack_190 = 0;
            Keyframe.ctor(&local_198,0x3f800000,0x3f000000,0);
            if (*(uint32 *)(lVar1 + 24) < 8) {
              uVar2 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar2,0);
            }
            *(uint32 *)(lVar1 + 228) = (uint32)local_198;
            *(uint32 *)(lVar1 + 232) = local_198._4_4_;
            *(uint32 *)(lVar1 + 236) = (uint32)uStack_190;
            *(uint32 *)(lVar1 + 240) = uStack_190._4_4_;
            *(uint64 *)(lVar1 + 244) = local_188;
            *(uint32 *)(lVar1 + 252) = local_180;
            uVar2 = new AnimationCurve(lVar1,0);
            puVar3 = (uint64 *)(pStatics + 16);
            *puVar3 = uVar2;
            il2cpp_internal(puVar3,uVar2);
            lVar1 = FUN_1800d60b0(DAT_181d7ec00,8);
            local_168 = 0;
            local_160 = 0;
            local_178 = 0;
            uStack_170 = 0;
            Keyframe.ctor(&local_178,0,0,0);
            if (lVar1 != null) {
              if (*(int *)(lVar1 + 24) == 0) {
                uVar2 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar2,0);
              }
              *(uint64 *)(lVar1 + 32) = local_178;
              *(uint64 *)(lVar1 + 40) = uStack_170;
              *(uint64 *)(lVar1 + 48) = local_168;
              *(uint32 *)(lVar1 + 56) = local_160;
              local_148 = 0;
              local_140 = 0;
              local_158 = 0;
              uStack_150 = 0;
              Keyframe.ctor(&local_158,0x3e124925,0,0);
              if (*(uint32 *)(lVar1 + 24) < 2) {
                uVar2 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar2,0);
              }
              *(uint64 *)(lVar1 + 60) = local_158;
              *(uint64 *)(lVar1 + 68) = uStack_150;
              *(uint64 *)(lVar1 + 76) = local_148;
              *(uint32 *)(lVar1 + 84) = local_140;
              local_128 = 0;
              local_120 = 0;
              local_138 = 0;
              uStack_130 = 0;
              Keyframe.ctor(&local_138,0x3e924925,0,0);
              if (*(uint32 *)(lVar1 + 24) < 3) {
                uVar2 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar2,0);
              }
              *(uint64 *)(lVar1 + 88) = local_138;
              *(uint64 *)(lVar1 + 96) = uStack_130;
              *(uint64 *)(lVar1 + 104) = local_128;
              *(uint32 *)(lVar1 + 112) = local_120;
              local_108 = 0;
              local_100 = 0;
              local_118 = 0;
              uStack_110 = 0;
              Keyframe.ctor(&local_118,0x3edb6db7,0x3f800000,0);
              if (*(uint32 *)(lVar1 + 24) < 4) {
                uVar2 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar2,0);
              }
              *(uint64 *)(lVar1 + 116) = local_118;
              *(uint64 *)(lVar1 + 124) = uStack_110;
              *(uint64 *)(lVar1 + 132) = local_108;
              *(uint32 *)(lVar1 + 140) = local_100;
              local_e8 = 0;
              local_e0 = 0;
              local_f8 = 0;
              uStack_f0 = 0;
              Keyframe.ctor(&local_f8,0x3f124925,0x3f800000,0);
              if (*(uint32 *)(lVar1 + 24) < 5) {
                uVar2 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar2,0);
              }
              *(uint64 *)(lVar1 + 144) = local_f8;
              *(uint64 *)(lVar1 + 152) = uStack_f0;
              *(uint64 *)(lVar1 + 160) = local_e8;
              *(uint32 *)(lVar1 + 168) = local_e0;
              local_c8 = 0;
              local_c0 = 0;
              local_d8 = 0;
              uStack_d0 = 0;
              Keyframe.ctor(&local_d8,0x3f36db6e,0x3f800000,0);
              if (*(uint32 *)(lVar1 + 24) < 6) {
                uVar2 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar2,0);
              }
              *(uint64 *)(lVar1 + 172) = local_d8;
              *(uint64 *)(lVar1 + 180) = uStack_d0;
              *(uint64 *)(lVar1 + 188) = local_c8;
              *(uint32 *)(lVar1 + 196) = local_c0;
              local_a8 = 0;
              local_a0 = 0;
              local_b8 = 0;
              uStack_b0 = 0;
              Keyframe.ctor(&local_b8,0x3f5b6db7,0,0);
              if (*(uint32 *)(lVar1 + 24) < 7) {
                uVar2 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar2,0);
              }
              *(uint64 *)(lVar1 + 200) = local_b8;
              *(uint64 *)(lVar1 + 208) = uStack_b0;
              *(uint64 *)(lVar1 + 216) = local_a8;
              *(uint32 *)(lVar1 + 224) = local_a0;
              local_88 = 0;
              local_80 = 0;
              local_98 = 0;
              uStack_90 = 0;
              Keyframe.ctor(&local_98,0x3f800000,0x3f000000,0);
              if (*(uint32 *)(lVar1 + 24) < 8) {
                uVar2 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar2,0);
              }
              *(uint32 *)(lVar1 + 228) = (uint32)local_98;
              *(uint32 *)(lVar1 + 232) = local_98._4_4_;
              *(uint32 *)(lVar1 + 236) = (uint32)uStack_90;
              *(uint32 *)(lVar1 + 240) = uStack_90._4_4_;
              *(uint64 *)(lVar1 + 244) = local_88;
              *(uint32 *)(lVar1 + 252) = local_80;
              uVar2 = new AnimationCurve(lVar1,0);
              puVar3 = (uint64 *)(pStatics + 24);
              *puVar3 = uVar2;
              il2cpp_internal(puVar3,uVar2);
              goto LAB_1813d3dda;
            }
          }
        }
    }

    // Token : 0x6000780
    // RVA   : 0x13D4490   Offset: 0x13D2C90   Length: 0x2C4
    public void Select(Vector2 v)
    {
        float fVar1;
        float fVar3;
        float fVar4;
        bool cVar5;
        int iVar6;
        int iVar7;
        long lVar9;
        ulong uVar11;
        ulong uVar12;
        ulong uVar13;
        int iVar14;
        int iVar15;
        uint uVar16;
        float fVar17;
        float fVar18;
        float fVar19;
        float fVar20;
        ulong local_a8;
        ulong uStack_a0;
        ulong local_98;
        ulong uStack_90;
        byte[] local_88 = new byte[128];
        uVar13 = this.mUITex;
        cVar5 = Object.op_Equality(uVar13,0,0);
        if (!cVar5) {
          iVar6 = *(int *)(this + 100);
          iVar14 = 0;
          fVar20 = 3.4028235e+38;
          if (0 < iVar6) {
            do {
              iVar15 = 0;
              iVar7 = this.mWidth;
              fVar18 = ((float)iVar14 - 1.0) / (float)iVar6;
              if (0 < iVar7) {
                local_a8 = *(uint64 *)v;
                uStack_a0 = *(uint64 *)(v + 2);
                fVar1 = *v;
                local_98._4_4_ = (float)((uint64)local_a8 >> 32);
                fVar4 = local_98._4_4_;
                fVar3 = (float)uStack_a0;
                local_98 = local_a8;
                uStack_90 = uStack_a0;
                do {
                  fVar19 = ((float)iVar15 - 1.0) / (float)iVar7;
                  pfVar8 = (float *)UIColorPicker.Sample(local_88,fVar19,fVar18,0);
                  fVar17 = (pfVar8[1] - fVar4) * (pfVar8[1] - fVar4) +
                           (*pfVar8 - fVar1) * (*pfVar8 - fVar1) +
                           (pfVar8[2] - fVar3) * (pfVar8[2] - fVar3);
                  if (fVar17 < fVar20) {
                    this.mPos = fVar19;
                    *(float *)(this + 92) = fVar18;
                    fVar20 = fVar17;
                  }
                  iVar7 = this.mWidth;
                  iVar15 = iVar15 + 1;
                } while (iVar15 < iVar7);
              }
              iVar6 = *(int *)(this + 100);
              iVar14 = iVar14 + 1;
            } while (iVar14 < iVar6);
          }
          uVar13 = this.selectionWidget;
          cVar5 = Object.op_Inequality(uVar13,0,0);
          if (cVar5) {
            plVar2 = this.mUITex;
            if ((plVar2 == (int64 *)0) ||
               (lVar9 = (**(code **)(*plVar2 + 0x1d8))(plVar2,*(uint64 *)(*plVar2 + 0x1e0)),
               lVar9 == null)) {
        LAB_1813d4b4d:
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            if (*(uint32 *)(lVar9 + 24) == 0) {
              uVar13 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar13,0);
            }
            if (*(uint32 *)(lVar9 + 24) < 3) {
              uVar13 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar13,0);
            }
            uVar16 = Mathf.Lerp();
            local_a8 = CONCAT44(local_a8._4_4_,uVar16);
            if (*(uint32 *)(lVar9 + 24) == 0) {
              uVar13 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar13,0);
            }
            if (*(uint32 *)(lVar9 + 24) < 3) {
              uVar13 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar13,0);
            }
            uVar16 = Mathf.Lerp();
            local_a8 = CONCAT44(uVar16,(uint32)local_a8);
            uStack_a0 = uStack_a0 & 0xffffffff00000000;
            if (this.mTrans == null) goto LAB_1813d4b4d;
            local_98 = local_a8;
            uStack_90 = uStack_90 & 0xffffffff00000000;
            puVar10 = (uint64 *)
                      Transform.TransformPoint(&local_a8,this.mTrans,&local_98,0);
            uVar13 = *puVar10;
            uVar16 = *(uint32 *)(puVar10 + 1);
            if (this.selectionWidget == null) goto LAB_1813d4b4d;
            uVar11 = Component.get_transform(this.selectionWidget,0);
            if (this.mCam == null) goto LAB_1813d4b4d;
            uVar12 = UICamera.get_cachedCamera(this.mCam,0);
            uStack_90 = CONCAT44(uStack_90._4_4_,uVar16);
            local_98 = uVar13;
            NGUIMath.OverlayPosition(uVar11,&local_98,uVar12,0);
          }
          uVar13 = *(uint64 *)(v + 2);
          this.value = *(uint64 *)v;
          *(uint64 *)(this + 32) = uVar13;
          plVar2 = *(int64 **)(DAT_181d8a558 + 184);
          *plVar2 = this;
          il2cpp_internal(plVar2,this);
          uVar13 = this.onChange;
          EventDelegate.Execute(uVar13,0);
          puVar10 = *(uint64 **)(DAT_181d8a558 + 184);
          *puVar10 = 0;
          il2cpp_internal(puVar10,0);
          uVar13 = this.mPos;
        }
        else {
          uVar13 = *(uint64 *)(v + 2);
          this.value = *(uint64 *)v;
          *(uint64 *)(this + 32) = uVar13;
          uVar13 = CONCAT44(*(uint32 *)(this + 92),this.mPos);
        }
        return uVar13;
    }

    // Token : 0x6000781
    // RVA   : 0x13D4760   Offset: 0x13D2F60   Length: 0x432
    public Vector2 Select(Color c)
    {
        float fVar1;
        float fVar3;
        float fVar4;
        bool cVar5;
        int iVar6;
        int iVar7;
        long lVar9;
        ulong uVar11;
        ulong uVar12;
        ulong uVar13;
        int iVar14;
        int iVar15;
        uint uVar16;
        float fVar17;
        float fVar18;
        float fVar19;
        float fVar20;
        ulong local_a8;
        ulong uStack_a0;
        ulong local_98;
        ulong uStack_90;
        byte[] local_88 = new byte[128];
        uVar13 = this.mUITex;
        cVar5 = Object.op_Equality(uVar13,0,0);
        if (!cVar5) {
          iVar6 = *(int *)(this + 100);
          iVar14 = 0;
          fVar20 = 3.4028235e+38;
          if (0 < iVar6) {
            do {
              iVar15 = 0;
              iVar7 = this.mWidth;
              fVar18 = ((float)iVar14 - 1.0) / (float)iVar6;
              if (0 < iVar7) {
                local_a8 = *(uint64 *)c;
                uStack_a0 = *(uint64 *)(c + 2);
                fVar1 = *c;
                local_98._4_4_ = (float)((uint64)local_a8 >> 32);
                fVar4 = local_98._4_4_;
                fVar3 = (float)uStack_a0;
                local_98 = local_a8;
                uStack_90 = uStack_a0;
                do {
                  fVar19 = ((float)iVar15 - 1.0) / (float)iVar7;
                  pfVar8 = (float *)UIColorPicker.Sample(local_88,fVar19,fVar18,0);
                  fVar17 = (pfVar8[1] - fVar4) * (pfVar8[1] - fVar4) +
                           (*pfVar8 - fVar1) * (*pfVar8 - fVar1) +
                           (pfVar8[2] - fVar3) * (pfVar8[2] - fVar3);
                  if (fVar17 < fVar20) {
                    this.mPos = fVar19;
                    *(float *)(this + 92) = fVar18;
                    fVar20 = fVar17;
                  }
                  iVar7 = this.mWidth;
                  iVar15 = iVar15 + 1;
                } while (iVar15 < iVar7);
              }
              iVar6 = *(int *)(this + 100);
              iVar14 = iVar14 + 1;
            } while (iVar14 < iVar6);
          }
          uVar13 = this.selectionWidget;
          cVar5 = Object.op_Inequality(uVar13,0,0);
          if (cVar5) {
            plVar2 = this.mUITex;
            if ((plVar2 == (int64 *)0) ||
               (lVar9 = (**(code **)(*plVar2 + 0x1d8))(plVar2,*(uint64 *)(*plVar2 + 0x1e0)),
               lVar9 == null)) {
        LAB_1813d4b4d:
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            if (*(uint32 *)(lVar9 + 24) == 0) {
              uVar13 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar13,0);
            }
            if (*(uint32 *)(lVar9 + 24) < 3) {
              uVar13 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar13,0);
            }
            uVar16 = Mathf.Lerp();
            local_a8 = CONCAT44(local_a8._4_4_,uVar16);
            if (*(uint32 *)(lVar9 + 24) == 0) {
              uVar13 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar13,0);
            }
            if (*(uint32 *)(lVar9 + 24) < 3) {
              uVar13 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar13,0);
            }
            uVar16 = Mathf.Lerp();
            local_a8 = CONCAT44(uVar16,(uint32)local_a8);
            uStack_a0 = uStack_a0 & 0xffffffff00000000;
            if (this.mTrans == null) goto LAB_1813d4b4d;
            local_98 = local_a8;
            uStack_90 = uStack_90 & 0xffffffff00000000;
            puVar10 = (uint64 *)
                      Transform.TransformPoint(&local_a8,this.mTrans,&local_98,0);
            uVar13 = *puVar10;
            uVar16 = *(uint32 *)(puVar10 + 1);
            if (this.selectionWidget == null) goto LAB_1813d4b4d;
            uVar11 = Component.get_transform(this.selectionWidget,0);
            if (this.mCam == null) goto LAB_1813d4b4d;
            uVar12 = UICamera.get_cachedCamera(this.mCam,0);
            uStack_90 = CONCAT44(uStack_90._4_4_,uVar16);
            local_98 = uVar13;
            NGUIMath.OverlayPosition(uVar11,&local_98,uVar12,0);
          }
          uVar13 = *(uint64 *)(c + 2);
          this.value = *(uint64 *)c;
          *(uint64 *)(this + 32) = uVar13;
          plVar2 = *(int64 **)(DAT_181d8a558 + 184);
          *plVar2 = this;
          il2cpp_internal(plVar2,this);
          uVar13 = this.onChange;
          EventDelegate.Execute(uVar13,0);
          puVar10 = *(uint64 **)(DAT_181d8a558 + 184);
          *puVar10 = 0;
          il2cpp_internal(puVar10,0);
          uVar13 = this.mPos;
        }
        else {
          uVar13 = *(uint64 *)(c + 2);
          this.value = *(uint64 *)c;
          *(uint64 *)(this + 32) = uVar13;
          uVar13 = CONCAT44(*(uint32 *)(this + 92),this.mPos);
        }
        return uVar13;
    }

    // Token : 0x6000782
    // RVA   : 0x13D33B0   Offset: 0x13D1BB0   Length: 0xD2C
    public static Color Sample(float x, float y)
    {
        var pStatics = *(int64*)(DAT_181d8a558 + 184);
        long lVar1;
        ulong uVar2;
        float fVar4;
        float fVar5;
        float fVar6;
        float fVar7;
        byte[] local_388 = new byte[8];
        float local_380;
        ulong local_378;
        ulong uStack_370;
        ulong local_368;
        uint local_360;
        ulong local_358;
        ulong uStack_350;
        ulong local_348;
        uint local_340;
        ulong local_338;
        ulong uStack_330;
        ulong local_328;
        uint local_320;
        ulong local_318;
        ulong uStack_310;
        ulong local_308;
        uint local_300;
        uint64 local_2f8;
        uint64 uStack_2f0;
        uint64 local_2e8;
        uint32 local_2e0;
        uint64 local_2d8;
        uint64 uStack_2d0;
        uint64 local_2c8;
        uint32 local_2c0;
        uint64 local_2b8;
        uint64 uStack_2b0;
        uint64 local_2a8;
        uint32 local_2a0;
        uint64 local_298;
        uint64 uStack_290;
        uint64 local_288;
        uint32 local_280;
        uint64 local_278;
        uint64 uStack_270;
        uint64 local_268;
        uint32 local_260;
        uint64 local_258;
        uint64 uStack_250;
        uint64 local_248;
        uint32 local_240;
        uint64 local_238;
        uint64 uStack_230;
        uint64 local_228;
        uint32 local_220;
        uint64 local_218;
        uint64 uStack_210;
        uint64 local_208;
        uint32 local_200;
        uint64 local_1f8;
        uint64 uStack_1f0;
        uint64 local_1e8;
        uint32 local_1e0;
        uint64 local_1d8;
        uint64 uStack_1d0;
        uint64 local_1c8;
        uint32 local_1c0;
        uint64 local_1b8;
        uint64 uStack_1b0;
        uint64 local_1a8;
        uint32 local_1a0;
        uint64 local_198;
        uint64 uStack_190;
        uint64 local_188;
        uint32 local_180;
        uint64 local_178;
        uint64 uStack_170;
        uint64 local_168;
        uint32 local_160;
        uint64 local_158;
        uint64 uStack_150;
        uint64 local_148;
        uint32 local_140;
        uint64 local_138;
        uint64 uStack_130;
        uint64 local_128;
        uint32 local_120;
        uint64 local_118;
        uint64 uStack_110;
        uint64 local_108;
        uint32 local_100;
        uint64 local_f8;
        uint64 uStack_f0;
        uint64 local_e8;
        uint32 local_e0;
        uint64 local_d8;
        uint64 uStack_d0;
        uint64 local_c8;
        uint32 local_c0;
        uint64 local_b8;
        uint64 uStack_b0;
        uint64 local_a8;
        uint32 local_a0;
        uint64 local_98;
        uint64 uStack_90;
        uint64 local_88;
        uint32 local_80;
        if (*(int64 *)(pStatics + 8) != 0) {
        LAB_1813d3dda:
          lVar1 = *(int64 *)(pStatics + 8);
          if (lVar1 != null) {
            fVar4 = (float)AnimationCurve.Evaluate(lVar1,y,0);
            lVar1 = *(int64 *)(pStatics + 16);
            if (lVar1 != null) {
              fVar5 = (float)AnimationCurve.Evaluate(lVar1,y,0);
              lVar1 = *(int64 *)(pStatics + 24);
              if (lVar1 != null) {
                fVar6 = (float)AnimationCurve.Evaluate(lVar1,y,0);
                fVar7 = param_3 + param_3;
                if (param_3 < 0.5) {
                  fVar5 = fVar5 * fVar7;
                  fVar4 = fVar4 * fVar7;
                  fVar6 = fVar6 * fVar7;
                }
                else {
                  puVar3 = (uint64 *)Vector3.get_one(local_388,0);
                  uVar2 = *puVar3;
                  local_380 = *(float *)(puVar3 + 1);
                  fVar7 = (float)Mathf.Clamp01(fVar7 - 1.0,0);
                  fVar6 = (local_380 - fVar6) * fVar7 + fVar6;
                  fVar5 = ((float)((uint64)uVar2 >> 32) - fVar5) * fVar7 + fVar5;
                  fVar4 = ((float)uVar2 - fVar4) * fVar7 + fVar4;
                }
                *x = 0;
                x[1] = 0;
                FUN_1809981e0(x,fVar4,fVar5,fVar6,0x3f800000,0);
                return x;
              }
            }
          }
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
        lVar1 = FUN_1800d60b0(DAT_181d7ec00,8);
        local_368 = 0;
        local_360 = 0;
        local_378 = 0;
        uStack_370 = 0;
        Keyframe.ctor(&local_378,0,0x3f800000,0);
        if (lVar1 != null) {
          if (*(int *)(lVar1 + 24) == 0) {
            uVar2 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar2,0);
          }
          *(uint64 *)(lVar1 + 32) = local_378;
          *(uint64 *)(lVar1 + 40) = uStack_370;
          *(uint64 *)(lVar1 + 48) = local_368;
          *(uint32 *)(lVar1 + 56) = local_360;
          local_348 = 0;
          local_340 = 0;
          local_358 = 0;
          uStack_350 = 0;
          Keyframe.ctor(&local_358,0x3e124925,0x3f800000,0);
          if (*(uint32 *)(lVar1 + 24) < 2) {
            uVar2 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar2,0);
          }
          *(uint64 *)(lVar1 + 60) = local_358;
          *(uint64 *)(lVar1 + 68) = uStack_350;
          *(uint64 *)(lVar1 + 76) = local_348;
          *(uint32 *)(lVar1 + 84) = local_340;
          local_328 = 0;
          local_320 = 0;
          local_338 = 0;
          uStack_330 = 0;
          Keyframe.ctor(&local_338,0x3e924925,0,0);
          if (*(uint32 *)(lVar1 + 24) < 3) {
            uVar2 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar2,0);
          }
          *(uint64 *)(lVar1 + 88) = local_338;
          *(uint64 *)(lVar1 + 96) = uStack_330;
          *(uint64 *)(lVar1 + 104) = local_328;
          *(uint32 *)(lVar1 + 112) = local_320;
          local_308 = 0;
          local_300 = 0;
          local_318 = 0;
          uStack_310 = 0;
          Keyframe.ctor(&local_318,0x3edb6db7,0,0);
          if (*(uint32 *)(lVar1 + 24) < 4) {
            uVar2 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar2,0);
          }
          *(uint64 *)(lVar1 + 116) = local_318;
          *(uint64 *)(lVar1 + 124) = uStack_310;
          *(uint64 *)(lVar1 + 132) = local_308;
          *(uint32 *)(lVar1 + 140) = local_300;
          local_2e8 = 0;
          local_2e0 = 0;
          local_2f8 = 0;
          uStack_2f0 = 0;
          Keyframe.ctor(&local_2f8,0x3f124925,0,0);
          if (*(uint32 *)(lVar1 + 24) < 5) {
            uVar2 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar2,0);
          }
          *(uint64 *)(lVar1 + 144) = local_2f8;
          *(uint64 *)(lVar1 + 152) = uStack_2f0;
          *(uint64 *)(lVar1 + 160) = local_2e8;
          *(uint32 *)(lVar1 + 168) = local_2e0;
          local_2c8 = 0;
          local_2c0 = 0;
          local_2d8 = 0;
          uStack_2d0 = 0;
          Keyframe.ctor(&local_2d8,0x3f36db6e,0x3f800000,0);
          if (*(uint32 *)(lVar1 + 24) < 6) {
            uVar2 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar2,0);
          }
          *(uint64 *)(lVar1 + 172) = local_2d8;
          *(uint64 *)(lVar1 + 180) = uStack_2d0;
          *(uint64 *)(lVar1 + 188) = local_2c8;
          *(uint32 *)(lVar1 + 196) = local_2c0;
          local_2a8 = 0;
          local_2a0 = 0;
          local_2b8 = 0;
          uStack_2b0 = 0;
          Keyframe.ctor(&local_2b8,0x3f5b6db7,0x3f800000,0);
          if (*(uint32 *)(lVar1 + 24) < 7) {
            uVar2 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar2,0);
          }
          *(uint64 *)(lVar1 + 200) = local_2b8;
          *(uint64 *)(lVar1 + 208) = uStack_2b0;
          *(uint64 *)(lVar1 + 216) = local_2a8;
          *(uint32 *)(lVar1 + 224) = local_2a0;
          local_288 = 0;
          local_280 = 0;
          local_298 = 0;
          uStack_290 = 0;
          Keyframe.ctor(&local_298,0x3f800000,0x3f000000,0);
          if (*(uint32 *)(lVar1 + 24) < 8) {
            uVar2 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar2,0);
          }
          *(uint32 *)(lVar1 + 228) = (uint32)local_298;
          *(uint32 *)(lVar1 + 232) = local_298._4_4_;
          *(uint32 *)(lVar1 + 236) = (uint32)uStack_290;
          *(uint32 *)(lVar1 + 240) = uStack_290._4_4_;
          *(uint64 *)(lVar1 + 244) = local_288;
          *(uint32 *)(lVar1 + 252) = local_280;
          uVar2 = new AnimationCurve(lVar1,0);
          puVar3 = (uint64 *)(pStatics + 8);
          *puVar3 = uVar2;
          il2cpp_internal(puVar3,uVar2);
          lVar1 = FUN_1800d60b0(DAT_181d7ec00,8);
          local_268 = 0;
          local_260 = 0;
          local_278 = 0;
          uStack_270 = 0;
          Keyframe.ctor(&local_278,0,0,0);
          if (lVar1 != null) {
            if (*(int *)(lVar1 + 24) == 0) {
              uVar2 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar2,0);
            }
            *(uint64 *)(lVar1 + 32) = local_278;
            *(uint64 *)(lVar1 + 40) = uStack_270;
            *(uint64 *)(lVar1 + 48) = local_268;
            *(uint32 *)(lVar1 + 56) = local_260;
            local_248 = 0;
            local_240 = 0;
            local_258 = 0;
            uStack_250 = 0;
            Keyframe.ctor(&local_258,0x3e124925,0x3f800000,0);
            if (*(uint32 *)(lVar1 + 24) < 2) {
              uVar2 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar2,0);
            }
            *(uint64 *)(lVar1 + 60) = local_258;
            *(uint64 *)(lVar1 + 68) = uStack_250;
            *(uint64 *)(lVar1 + 76) = local_248;
            *(uint32 *)(lVar1 + 84) = local_240;
            local_228 = 0;
            local_220 = 0;
            local_238 = 0;
            uStack_230 = 0;
            Keyframe.ctor(&local_238,0x3e924925,0x3f800000,0);
            if (*(uint32 *)(lVar1 + 24) < 3) {
              uVar2 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar2,0);
            }
            *(uint64 *)(lVar1 + 88) = local_238;
            *(uint64 *)(lVar1 + 96) = uStack_230;
            *(uint64 *)(lVar1 + 104) = local_228;
            *(uint32 *)(lVar1 + 112) = local_220;
            local_208 = 0;
            local_200 = 0;
            local_218 = 0;
            uStack_210 = 0;
            Keyframe.ctor(&local_218,0x3edb6db7,0x3f800000,0);
            if (*(uint32 *)(lVar1 + 24) < 4) {
              uVar2 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar2,0);
            }
            *(uint64 *)(lVar1 + 116) = local_218;
            *(uint64 *)(lVar1 + 124) = uStack_210;
            *(uint64 *)(lVar1 + 132) = local_208;
            *(uint32 *)(lVar1 + 140) = local_200;
            local_1e8 = 0;
            local_1e0 = 0;
            local_1f8 = 0;
            uStack_1f0 = 0;
            Keyframe.ctor(&local_1f8,0x3f124925,0,0);
            if (*(uint32 *)(lVar1 + 24) < 5) {
              uVar2 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar2,0);
            }
            *(uint64 *)(lVar1 + 144) = local_1f8;
            *(uint64 *)(lVar1 + 152) = uStack_1f0;
            *(uint64 *)(lVar1 + 160) = local_1e8;
            *(uint32 *)(lVar1 + 168) = local_1e0;
            local_1c8 = 0;
            local_1c0 = 0;
            local_1d8 = 0;
            uStack_1d0 = 0;
            Keyframe.ctor(&local_1d8,0x3f36db6e,0,0);
            if (*(uint32 *)(lVar1 + 24) < 6) {
              uVar2 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar2,0);
            }
            *(uint64 *)(lVar1 + 172) = local_1d8;
            *(uint64 *)(lVar1 + 180) = uStack_1d0;
            *(uint64 *)(lVar1 + 188) = local_1c8;
            *(uint32 *)(lVar1 + 196) = local_1c0;
            local_1a8 = 0;
            local_1a0 = 0;
            local_1b8 = 0;
            uStack_1b0 = 0;
            Keyframe.ctor(&local_1b8,0x3f5b6db7,0,0);
            if (*(uint32 *)(lVar1 + 24) < 7) {
              uVar2 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar2,0);
            }
            *(uint64 *)(lVar1 + 200) = local_1b8;
            *(uint64 *)(lVar1 + 208) = uStack_1b0;
            *(uint64 *)(lVar1 + 216) = local_1a8;
            *(uint32 *)(lVar1 + 224) = local_1a0;
            local_188 = 0;
            local_180 = 0;
            local_198 = 0;
            uStack_190 = 0;
            Keyframe.ctor(&local_198,0x3f800000,0x3f000000,0);
            if (*(uint32 *)(lVar1 + 24) < 8) {
              uVar2 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar2,0);
            }
            *(uint32 *)(lVar1 + 228) = (uint32)local_198;
            *(uint32 *)(lVar1 + 232) = local_198._4_4_;
            *(uint32 *)(lVar1 + 236) = (uint32)uStack_190;
            *(uint32 *)(lVar1 + 240) = uStack_190._4_4_;
            *(uint64 *)(lVar1 + 244) = local_188;
            *(uint32 *)(lVar1 + 252) = local_180;
            uVar2 = new AnimationCurve(lVar1,0);
            puVar3 = (uint64 *)(pStatics + 16);
            *puVar3 = uVar2;
            il2cpp_internal(puVar3,uVar2);
            lVar1 = FUN_1800d60b0(DAT_181d7ec00,8);
            local_168 = 0;
            local_160 = 0;
            local_178 = 0;
            uStack_170 = 0;
            Keyframe.ctor(&local_178,0,0,0);
            if (lVar1 != null) {
              if (*(int *)(lVar1 + 24) == 0) {
                uVar2 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar2,0);
              }
              *(uint64 *)(lVar1 + 32) = local_178;
              *(uint64 *)(lVar1 + 40) = uStack_170;
              *(uint64 *)(lVar1 + 48) = local_168;
              *(uint32 *)(lVar1 + 56) = local_160;
              local_148 = 0;
              local_140 = 0;
              local_158 = 0;
              uStack_150 = 0;
              Keyframe.ctor(&local_158,0x3e124925,0,0);
              if (*(uint32 *)(lVar1 + 24) < 2) {
                uVar2 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar2,0);
              }
              *(uint64 *)(lVar1 + 60) = local_158;
              *(uint64 *)(lVar1 + 68) = uStack_150;
              *(uint64 *)(lVar1 + 76) = local_148;
              *(uint32 *)(lVar1 + 84) = local_140;
              local_128 = 0;
              local_120 = 0;
              local_138 = 0;
              uStack_130 = 0;
              Keyframe.ctor(&local_138,0x3e924925,0,0);
              if (*(uint32 *)(lVar1 + 24) < 3) {
                uVar2 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar2,0);
              }
              *(uint64 *)(lVar1 + 88) = local_138;
              *(uint64 *)(lVar1 + 96) = uStack_130;
              *(uint64 *)(lVar1 + 104) = local_128;
              *(uint32 *)(lVar1 + 112) = local_120;
              local_108 = 0;
              local_100 = 0;
              local_118 = 0;
              uStack_110 = 0;
              Keyframe.ctor(&local_118,0x3edb6db7,0x3f800000,0);
              if (*(uint32 *)(lVar1 + 24) < 4) {
                uVar2 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar2,0);
              }
              *(uint64 *)(lVar1 + 116) = local_118;
              *(uint64 *)(lVar1 + 124) = uStack_110;
              *(uint64 *)(lVar1 + 132) = local_108;
              *(uint32 *)(lVar1 + 140) = local_100;
              local_e8 = 0;
              local_e0 = 0;
              local_f8 = 0;
              uStack_f0 = 0;
              Keyframe.ctor(&local_f8,0x3f124925,0x3f800000,0);
              if (*(uint32 *)(lVar1 + 24) < 5) {
                uVar2 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar2,0);
              }
              *(uint64 *)(lVar1 + 144) = local_f8;
              *(uint64 *)(lVar1 + 152) = uStack_f0;
              *(uint64 *)(lVar1 + 160) = local_e8;
              *(uint32 *)(lVar1 + 168) = local_e0;
              local_c8 = 0;
              local_c0 = 0;
              local_d8 = 0;
              uStack_d0 = 0;
              Keyframe.ctor(&local_d8,0x3f36db6e,0x3f800000,0);
              if (*(uint32 *)(lVar1 + 24) < 6) {
                uVar2 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar2,0);
              }
              *(uint64 *)(lVar1 + 172) = local_d8;
              *(uint64 *)(lVar1 + 180) = uStack_d0;
              *(uint64 *)(lVar1 + 188) = local_c8;
              *(uint32 *)(lVar1 + 196) = local_c0;
              local_a8 = 0;
              local_a0 = 0;
              local_b8 = 0;
              uStack_b0 = 0;
              Keyframe.ctor(&local_b8,0x3f5b6db7,0,0);
              if (*(uint32 *)(lVar1 + 24) < 7) {
                uVar2 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar2,0);
              }
              *(uint64 *)(lVar1 + 200) = local_b8;
              *(uint64 *)(lVar1 + 208) = uStack_b0;
              *(uint64 *)(lVar1 + 216) = local_a8;
              *(uint32 *)(lVar1 + 224) = local_a0;
              local_88 = 0;
              local_80 = 0;
              local_98 = 0;
              uStack_90 = 0;
              Keyframe.ctor(&local_98,0x3f800000,0x3f000000,0);
              if (*(uint32 *)(lVar1 + 24) < 8) {
                uVar2 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar2,0);
              }
              *(uint32 *)(lVar1 + 228) = (uint32)local_98;
              *(uint32 *)(lVar1 + 232) = local_98._4_4_;
              *(uint32 *)(lVar1 + 236) = (uint32)uStack_90;
              *(uint32 *)(lVar1 + 240) = uStack_90._4_4_;
              *(uint64 *)(lVar1 + 244) = local_88;
              *(uint32 *)(lVar1 + 252) = local_80;
              uVar2 = new AnimationCurve(lVar1,0);
              puVar3 = (uint64 *)(pStatics + 24);
              *puVar3 = uVar2;
              il2cpp_internal(puVar3,uVar2);
              goto LAB_1813d3dda;
            }
          }
        }
    }

    // Token : 0x6000783
    // RVA   : 0x13D4EB0   Offset: 0x13D36B0   Length: 0x89
    public void /*ctor*/()
    {
        uint uVar1;
        uint uVar2;
        uint uVar3;
        ulong uVar5;
        byte[] local_18 = new byte[16];
        puVar4 = (uint32 *)FUN_181098a50(local_18,0);
        uVar1 = puVar4[1];
        uVar2 = puVar4[2];
        uVar3 = puVar4[3];
        this.value = *puVar4;
        *(uint32 *)(this + 28) = uVar1;
        *(uint32 *)(this + 32) = uVar2;
        *(uint32 *)(this + 36) = uVar3;
        uVar5 = il2cpp_internal(DAT_181d6d9b0);
        FUN_180f58a90(uVar5,DAT_181d5e700);
        this.onChange = uVar5;
        FUN_18044ef50(this,0);
    }

}
