// ============================================================
// Type  : UIGeometry
// Token : 0x20000A5
// ============================================================

public class UIGeometry
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x40003E0
    public List<Vector3> verts;

    // Token: 0x40003E1
    public List<Vector2> uvs;

    // Token: 0x40003E2
    public List<Color> cols;

    // Token: 0x40003E3
    public OnCustomWrite onCustomWrite;

    // Token: 0x40003E4
    private List<Vector3> mRtpVerts;

    // Token: 0x40003E5
    private Vector3 mRtpNormal;

    // Token: 0x40003E6
    private Vector4 mRtpTan;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60004CC
    // RVA   : 0x10EBDA0   Offset: 0x10EA5A0   Length: 0x40
    public bool get_hasVertices()
    {
        long lVar1;
        lVar1 = this.verts;
        if (lVar1 != null) {
          return CONCAT71((int7)((uint64)lVar1 >> 8),0 < lVar1.Count);
        }
    }

    // Token : 0x60004CD
    // RVA   : 0x10EBD40   Offset: 0x10EA540   Length: 0x57
    public bool get_hasTransformed()
    {
        ulong uVar1;
        long lVar2;
        uVar1 = this.mRtpVerts;
        if (uVar1 != 0) {
          if (0 < uVar1.Count) {
            lVar2 = this.verts;
            if (lVar2 != null) {
              return CONCAT71((int7)((uint64)lVar2 >> 8),
                              uVar1.Count == lVar2.Count);
            }
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
        }
        return uVar1 & 0xffffffffffffff00;
    }

    // Token : 0x60004CE
    // RVA   : 0x10EB660   Offset: 0x10E9E60   Length: 0x9B
    public void Clear()
    {
        if (this.verts != null) {
          FUN_180f56130(this.verts,DAT_181d84378);
          if (this.uvs != null) {
            FUN_180f56130(this.uvs,DAT_181d83ff8);
            if (this.cols != null) {
              FUN_180f56130(this.cols,DAT_181d5b700);
              if (this.mRtpVerts != null) {
                FUN_180f56130(this.mRtpVerts,DAT_181d84378);
                return;
              }
            }
          }
        }
    }

    // Token : 0x60004CF
    // RVA   : 0x10EB3A0   Offset: 0x10E9BA0   Length: 0x2B5
    public void ApplyTransform(Matrix4x4 widgetToPanel, bool generateNormals)
    {
        long lVar1;
        long lVar2;
        long lVar4;
        long lVar5;
        uint uVar6;
        long lVar7;
        ulong local_78;
        uint local_70;
        ulong local_68;
        ulong uStack_60;
        ulong local_58;
        uint local_50;
        byte[] local_48 = new byte[16];
        local_78 = 0;
        local_70 = 0;
        if (this.verts != null) {
          lVar5 = this.mRtpVerts;
          if (this.verts.Count < 1) {
            if (lVar5 != null) {
              FUN_180f56130(lVar5,DAT_181d84378);
              return;
            }
          }
          else if (lVar5 != null) {
            FUN_180f56130(lVar5,DAT_181d84378);
            uVar6 = 0;
            if (this.verts != null) {
              lVar5 = (int64)this.verts.Count;
              if (0 < lVar5) {
                lVar7 = 0;
                lVar4 = 0;
                do {
                  lVar1 = this.verts;
                  lVar2 = this.mRtpVerts;
                  if (lVar1 == null) throw; // [null/range check failed]
                  if (lVar1.Count <= uVar6) {
                    ThrowHelper.ThrowArgumentOutOfRangeException(0);
                  }
                  local_68 = *(uint64 *)(lVar1._items + 32 + lVar4);
                  uStack_60 = CONCAT44(uStack_60._4_4_,
                                       *(uint32 *)(lVar1._items + 40 + lVar4));
                  puVar3 = (uint64 *)Matrix4x4.MultiplyPoint3x4(local_48,widgetToPanel,&local_68,0);
                  if (lVar2 == null) throw; // [null/range check failed]
                  local_58 = *puVar3;
                  local_50 = *(uint32 *)(puVar3 + 1);
                  FUN_181805a40(lVar2,&local_58,DAT_181d84278);
                  uVar6 = uVar6 + 1;
                  lVar7 = lVar7 + 1;
                  lVar4 = lVar4 + 12;
                } while (lVar7 < lVar5);
              }
              if (!generateNormals) {
                return;
              }
              puVar3 = (uint64 *)Vector3.get_back(local_48,0);
              local_58 = *puVar3;
              local_50 = *(uint32 *)(puVar3 + 1);
              puVar3 = (uint64 *)Matrix4x4.MultiplyVector(local_48,widgetToPanel,&local_58,0);
              local_78 = *puVar3;
              local_70 = *(uint32 *)(puVar3 + 1);
              puVar3 = (uint64 *)Vector3.get_normalized(local_48,&local_78,0);
              this.mRtpNormal = *puVar3;
              *(uint32 *)(this + 64) = *(uint32 *)(puVar3 + 1);
              puVar3 = (uint64 *)Vector3.get_right(local_48,0);
              local_58 = *puVar3;
              local_50 = *(uint32 *)(puVar3 + 1);
              puVar3 = (uint64 *)Matrix4x4.MultiplyVector(local_48,widgetToPanel,&local_58,0);
              local_78 = *puVar3;
              local_70 = *(uint32 *)(puVar3 + 1);
              puVar3 = (uint64 *)Vector3.get_normalized(local_48,&local_78,0);
              local_50 = *(uint32 *)(puVar3 + 1);
              local_68 = 0;
              uStack_60 = 0;
              FUN_1809981e0(&local_68,(int)*puVar3,(int)((uint64)*puVar3 >> 32),local_50,0xbf800000,0
                           );
              this.mRtpTan = local_68;
              *(uint64 *)(this + 76) = uStack_60;
              return;
            }
          }
        }
    }

    // Token : 0x60004D0
    // RVA   : 0x10EB700   Offset: 0x10E9F00   Length: 0x509
    public void WriteToBuffers(List<Vector3> v, List<Vector2> u, List<Color> c, List<Vector3> n, List<Vector4> t, List<Vector4> u2)
    {
        void UIGeometry.WriteToBuffers
                     (int64 this,int64 v,int64 u,int64 c,int64 n
                     ,int64 t,int64 u2)
        {
        uint32 *puVar1;
        int iVar2;
        int64 lVar3;
        uint32 uVar4;
        uint32 uVar5;
        uint64 *puVar6;
        uint32 uVar7;
        int64 lVar8;
        int64 lVar9;
        int64 lVar10;
        int64 lVar11;
        uint64 local_res8;
        uint64 local_98;
        uint32 local_90;
        uint64 local_88;
        uint32 uStack_80;
        uint32 uStack_7c;
        uint32 local_78;
        uint32 uStack_74;
        uint32 uStack_70;
        uint32 uStack_6c;
        if (this.mRtpVerts != null) {
          iVar2 = this.mRtpVerts.Count;
          if (0 < iVar2) {
            uVar7 = 0;
            if (n == null) {
              if (0 < iVar2) {
                lVar9 = 0;
                lVar10 = 32;
                lVar8 = 0;
                lVar11 = 32;
                do {
                  lVar3 = this.mRtpVerts;
                  if (lVar3 == null) goto LAB_1810ebc04;
                  if (lVar3.Count <= uVar7) {
                    ThrowHelper.ThrowArgumentOutOfRangeException(0);
                  }
                  if (v == null) goto LAB_1810ebc04;
                  local_88 = *(uint64 *)(lVar3._items + 32 + lVar8);
                  uStack_80 = *(uint32 *)(lVar3._items + 40 + lVar8);
                  FUN_181805a40(v,&local_88,DAT_181d84278);
                  lVar3 = this.uvs;
                  if (lVar3 == null) goto LAB_1810ebc04;
                  if (lVar3.Count <= uVar7) {
                    ThrowHelper.ThrowArgumentOutOfRangeException(0);
                  }
                  local_res8 = CONCAT44(*(uint32 *)(lVar3._items + 4 + lVar11),
                                        *(uint32 *)(lVar3._items + lVar11));
                  if (u == null) goto LAB_1810ebc04;
                  FUN_181814e80(u,local_res8,DAT_181d83f78);
                  lVar3 = this.cols;
                  if (lVar3 == null) goto LAB_1810ebc04;
                  if (lVar3.Count <= uVar7) {
                    ThrowHelper.ThrowArgumentOutOfRangeException(0);
                  }
                  if (c == null) goto LAB_1810ebc04;
                  puVar1 = (uint32 *)(lVar3._items + lVar10);
                  local_78 = *puVar1;
                  uStack_74 = puVar1[1];
                  uStack_70 = puVar1[2];
                  uStack_6c = puVar1[3];
                  FUN_1818059b0(c,&local_78,DAT_181d5b680);
                  uVar7 = uVar7 + 1;
                  lVar9 = lVar9 + 1;
                  lVar11 = lVar11 + 8;
                  lVar10 = lVar10 + 16;
                  lVar8 = lVar8 + 12;
                } while (lVar9 < iVar2);
              }
            }
            else if (0 < iVar2) {
              lVar9 = 0;
              lVar10 = 32;
              lVar8 = 0;
              lVar11 = 32;
              do {
                lVar3 = this.mRtpVerts;
                if (lVar3 == null) goto LAB_1810ebc04;
                if (lVar3.Count <= uVar7) {
                  ThrowHelper.ThrowArgumentOutOfRangeException(0);
                }
                if (v == null) goto LAB_1810ebc04;
                local_98 = *(uint64 *)(lVar3._items + 32 + lVar8);
                local_90 = *(uint32 *)(lVar3._items + 40 + lVar8);
                FUN_181805a40(v,&local_98,DAT_181d84278);
                lVar3 = this.uvs;
                if (lVar3 == null) goto LAB_1810ebc04;
                if (lVar3.Count <= uVar7) {
                  ThrowHelper.ThrowArgumentOutOfRangeException(0);
                }
                local_res8 = CONCAT44(*(uint32 *)(lVar3._items + 4 + lVar11),
                                      *(uint32 *)(lVar3._items + lVar11));
                if (u == null) goto LAB_1810ebc04;
                FUN_181814e80(u,local_res8,DAT_181d83f78);
                lVar3 = this.cols;
                if (lVar3 == null) goto LAB_1810ebc04;
                if (lVar3.Count <= uVar7) {
                  ThrowHelper.ThrowArgumentOutOfRangeException(0);
                }
                if (c == null) goto LAB_1810ebc04;
                puVar1 = (uint32 *)(lVar3._items + lVar10);
                local_78 = *puVar1;
                uStack_74 = puVar1[1];
                uStack_70 = puVar1[2];
                uStack_6c = puVar1[3];
                FUN_1818059b0(c,&local_78,DAT_181d5b680);
                local_88 = this.mRtpNormal;
                uStack_80 = *(uint32 *)(this + 64);
                FUN_181805a40(n,&local_88,DAT_181d84278);
                if (t == null) goto LAB_1810ebc04;
                local_78 = this.mRtpTan;
                uStack_74 = *(uint32 *)(this + 72);
                uStack_70 = *(uint32 *)(this + 76);
                uStack_6c = *(uint32 *)(this + 80);
                FUN_1818059b0(t,&local_78,DAT_181d845f8);
                uVar7 = uVar7 + 1;
                lVar9 = lVar9 + 1;
                lVar11 = lVar11 + 8;
                lVar10 = lVar10 + 16;
                lVar8 = lVar8 + 12;
              } while (lVar9 < iVar2);
            }
            if (u2 != null) {
              puVar6 = (uint64 *)Vector4.get_zero(&local_78,0);
              uVar7 = 0;
              local_88 = *puVar6;
              uVar4 = *(uint32 *)(puVar6 + 1);
              uVar5 = *(uint32 *)((int64)puVar6 + 12);
              uStack_80 = uVar4;
              uStack_7c = uVar5;
              if (this.verts == null) {
        LAB_1810ebc04:
                          // WARNING: Subroutine does not return
                FUN_1800d6620();
              }
              lVar8 = (int64)this.verts.Count;
              if (0 < lVar8) {
                lVar9 = 0;
                local_res8 = 0;
                do {
                  lVar10 = this.verts;
                  if (lVar10 == null) goto LAB_1810ebc04;
                  lVar11 = lVar10;
                  if (lVar10.Count <= uVar7) {
                    ThrowHelper.ThrowArgumentOutOfRangeException(0);
                    lVar11 = this.verts;
                  }
                  local_88 = *(uint64 *)(lVar10._items + 32 + lVar9);
                  if (lVar11 == null) goto LAB_1810ebc04;
                  if (lVar11.Count <= uVar7) {
                    ThrowHelper.ThrowArgumentOutOfRangeException(0);
                  }
                  uStack_74 = *(uint32 *)(lVar11._items + 36 + lVar9);
                  local_78 = (uint32)local_88;
                  uStack_70 = uVar4;
                  uStack_6c = uVar5;
                  FUN_1818059b0(u2,&local_78,DAT_181d845f8);
                  uVar7 = uVar7 + 1;
                  local_res8 = local_res8 + 1;
                  lVar9 = lVar9 + 12;
                } while (local_res8 < lVar8);
              }
            }
            if (this.onCustomWrite != null) {
              OnCustomWrite.Invoke
                        (this.onCustomWrite,v,u,c,n,t,u2,0);
            }
          }
        }
    }

    // Token : 0x60004D1
    // RVA   : 0x10EBC10   Offset: 0x10EA410   Length: 0x12D
    public void /*ctor*/()
    {
        ulong uVar1;
        uVar1 = il2cpp_internal(DAT_181d73eb0);
        FUN_180f58a90(uVar1,DAT_181d841f8);
        this.verts = uVar1;
        uVar1 = il2cpp_internal(DAT_181d73e30);
        FUN_180f58a90(uVar1,DAT_181d83ef8);
        this.uvs = uVar1;
        uVar1 = il2cpp_internal(DAT_181d6d130);
        FUN_180f58a90(uVar1,DAT_181d5b600);
        this.cols = uVar1;
        uVar1 = il2cpp_internal(DAT_181d73eb0);
        FUN_180f58a90(uVar1,DAT_181d841f8);
        this.mRtpVerts = uVar1;
        ZhSegment.Initialize(this,0);
    }

}
