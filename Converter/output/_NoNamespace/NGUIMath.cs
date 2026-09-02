// ============================================================
// Type  : NGUIMath
// Token : 0x2000085
// ============================================================

public class NGUIMath
{
    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000355
    // RVA   : 0xB02EB0   Offset: 0xB016B0   Length: 0x1C
    public static float Lerp(float from, float to, float factor)
    {
        return (1.0 - factor) * from + to * factor;
    }

    // Token : 0x6000356
    // RVA   : 0xB01E90   Offset: 0xB00690   Length: 0x11
    public static int ClampIndex(int val, int max)
    {
        int FUN_180b01e90(int val,int max)
        {
        if (val < 0) {
          return 0;
        }
        if (max <= val) {
          val = max + -1;
        }
        return val;
    }

    // Token : 0x6000357
    // RVA   : 0xB038B0   Offset: 0xB020B0   Length: 0x24
    public static int RepeatIndex(int val, int max)
    {
        if (0 < max) {
          for (; val < 0; val = val + max) {
          }
          for (; max <= val; val = val - max) {
          }
          return val;
        }
        return 0;
    }

    // Token : 0x6000358
    // RVA   : 0xB048C0   Offset: 0xB030C0   Length: 0xF6
    public static float WrapAngle(float angle)
    {
        for (; 180.0 < angle; angle = angle + -360.0) {
        }
        for (; angle < -180.0; angle = angle + 360.0) {
        }
    }

    // Token : 0x6000359
    // RVA   : 0xB04890   Offset: 0xB03090   Length: 0x2B
    public static float Wrap01(float val)
    {
        int iVar1;
        iVar1 = Mathf.FloorToInt(val,0);
        return val - (float)iVar1;
    }

    // Token : 0x600035A
    // RVA   : 0xB02C20   Offset: 0xB01420   Length: 0x18
    public static int HexToDecimal(char ch)
    {
        switch(ch) {
        case 48:
          return 0;
        case 49:
          return 1;
        case 50:
          return 2;
        case 51:
          return 3;
        case 52:
          return 4;
        case 53:
          return 5;
        case 54:
          return 6;
        case 55:
          return 7;
        case 56:
          return 8;
        case 57:
          return 9;
        case 58:
        case 59:
        case 60:
        case 61:
        case 62:
        case 63:
        case 64:
        case 70:
          goto switchD_180b02c3f_caseD_3a;
        case 65:
        switchD_180b02c3f_caseD_41:
          return 10;
        case 66:
        switchD_180b02c3f_caseD_42:
          return 11;
        case 67:
        switchD_180b02c3f_caseD_43:
          return 12;
        case 68:
        switchD_180b02c3f_caseD_44:
          return 13;
        case 69:
        switchD_180b02c3f_caseD_45:
          return 14;
        default:
          switch(ch) {
          case 97:
            goto switchD_180b02c3f_caseD_41;
          case 98:
            goto switchD_180b02c3f_caseD_42;
          case 99:
            goto switchD_180b02c3f_caseD_43;
          case 100:
            goto switchD_180b02c3f_caseD_44;
          case 101:
            goto switchD_180b02c3f_caseD_45;
          }
        switchD_180b02c3f_caseD_3a:
          return 15;
        }
    }

    // Token : 0x600035B
    // RVA   : 0xB023F0   Offset: 0xB00BF0   Length: 0x18
    public static char DecimalToHexChar(int num)
    {
        int FUN_180b023f0(int num)
        {
        if (15 < num) {
          return 70;
        }
        if (9 < num) {
          return num + 55;
        }
        return num + 48;
    }

    // Token : 0x600035C
    // RVA   : 0xB023A0   Offset: 0xB00BA0   Length: 0x48
    public static string DecimalToHex8(int num)
    {
        uint[] local_res8 = new uint[8];
        if (!DAT_181e787fe) {
          local_res8[0] = num;
          il2cpp_internal(&"X2");
          DAT_181e787fe = true;
          num = local_res8[0];
        }
        local_res8[0] = num & 255;
        Int32.ToString(local_res8,"X2",0);
    }

    // Token : 0x600035D
    // RVA   : 0xB02310   Offset: 0xB00B10   Length: 0x4B
    public static string DecimalToHex24(int num)
    {
        uint[] local_res8 = new uint[8];
        if (!DAT_181e787ff) {
          local_res8[0] = num;
          il2cpp_internal(&"X6");
          DAT_181e787ff = true;
          num = local_res8[0];
        }
        local_res8[0] = num & 0xffffff;
        Int32.ToString(local_res8,"X6",0);
    }

    // Token : 0x600035E
    // RVA   : 0xB02360   Offset: 0xB00B60   Length: 0x3D
    public static string DecimalToHex32(int num)
    {
        uint[] local_res8 = new uint[8];
        local_res8[0] = num;
        Int32.ToString(local_res8,"X8",0);
    }

    // Token : 0x600035F
    // RVA   : 0xB01EB0   Offset: 0xB006B0   Length: 0x92
    public static int ColorToInt(Color c)
    {
        int iVar1;
        uint uVar2;
        uint uVar3;
        uint uVar4;
        iVar1 = Mathf.RoundToInt(*c * 255.0,0);
        uVar2 = Mathf.RoundToInt(c[1] * 255.0,0);
        uVar3 = Mathf.RoundToInt(c[2] * 255.0,0);
        uVar4 = Mathf.RoundToInt(c[3] * 255.0,0);
        return uVar4 | ((iVar1 << 8 | uVar2) << 8 | uVar3) << 8;
    }

    // Token : 0x6000360
    // RVA   : 0xB02E10   Offset: 0xB01610   Length: 0x91
    public static Color IntToColor(int val)
    {
        byte[] local_18 = new byte[16];
        val[0] = 0.0;
        val[1] = 0.0;
        val[2] = 0.0;
        val[3] = 0.0;
        Color.get_black(local_18,0);
        *val = (float)((int)param_2 >> 24 & 255) * 0.003921569;
        val[1] = (float)((int)param_2 >> 16 & 255) * 0.003921569;
        val[2] = (float)((int)param_2 >> 8 & 255) * 0.003921569;
        val[3] = (float)(param_2 & 255) * 0.003921569;
        return val;
    }

    // Token : 0x6000361
    // RVA   : 0xB02D30   Offset: 0xB01530   Length: 0xD7
    public static string IntToBinary(int val, int bits)
    {
        ulong uVar1;
        ulong uVar2;
        local_res10[0] = 0;
        uVar1 = "";
        if ((int)bits < 1) {
          return "";
        }
        do {
          if (((bits - 8 & 0xfffffff7) == 0) || (bits == 24)) {
            uVar1 = String.Concat(uVar1," ",0);
          }
          bits = bits - 1;
          local_res10[0] = ((val >> (bits & 31) & 1) != 0) + 48;
          uVar2 = Char.ToString(local_res10,0);
          uVar1 = String.Concat(uVar1,uVar2,0);
        } while (0 < (int)bits);
        return uVar1;
    }

    // Token : 0x6000362
    // RVA   : 0xB02B80   Offset: 0xB01380   Length: 0x97
    public static Color HexToColor(uint val)
    {
        byte[] local_18 = new byte[16];
        Color.get_black(local_18,0);
        *val = (float)((int)param_2 >> 24 & 255) * 0.003921569;
        val[1] = (float)((int)param_2 >> 16 & 255) * 0.003921569;
        val[2] = (float)((int)param_2 >> 8 & 255) * 0.003921569;
        val[3] = (float)(param_2 & 255) * 0.003921569;
        return val;
    }

    // Token : 0x6000363
    // RVA   : 0xB02220   Offset: 0xB00A20   Length: 0xE1
    public static Rect ConvertToTexCoords(Rect rect, int width, int height)
    {
        uint32 *
        NGUIMath.ConvertToTexCoords(uint32 *rect,uint32 *width,int height,int param_4)
        {
        uint32 uVar1;
        uint32 uVar2;
        uint32 uVar3;
        float fVar4;
        float fVar5;
        float fVar6;
        uVar1 = width[1];
        uVar2 = width[2];
        uVar3 = width[3];
        fVar5 = (float)height;
        *rect = *width;
        rect[1] = uVar1;
        rect[2] = uVar2;
        rect[3] = uVar3;
        if ((fVar5 != 0.0) && (fVar6 = (float)param_4, fVar6 != 0.0)) {
          fVar4 = (float)FUN_180d904a0(width,0);
          Rect.set_xMin(rect,fVar4 / fVar5,0);
          fVar4 = (float)Rect.get_xMax(width,0);
          Rect.set_xMax(rect,fVar4 / fVar5,0);
          fVar5 = (float)Rect.get_yMax(width,0);
          Rect.set_yMin(rect,1.0 - fVar5 / fVar6,0);
          fVar5 = (float)FUN_18044df60(width,0);
          Rect.set_yMax(rect,1.0 - fVar5 / fVar6,0);
        }
        return rect;
    }

    // Token : 0x6000364
    // RVA   : 0xB020A0   Offset: 0xB008A0   Length: 0x176
    public static Rect ConvertToPixels(Rect rect, int width, int height, bool round)
    {
        uint32 *
        NGUIMath.ConvertToPixels
                (uint32 *rect,uint32 *width,int height,int round,char param_5)
        {
        uint32 uVar1;
        uint32 uVar2;
        uint32 uVar3;
        float fVar4;
        float fVar5;
        uVar1 = width[1];
        uVar2 = width[2];
        uVar3 = width[3];
        *rect = *width;
        rect[1] = uVar1;
        rect[2] = uVar2;
        rect[3] = uVar3;
        fVar5 = (float)round;
        fVar4 = (float)FUN_180d904a0(width,0);
        fVar4 = (float)height * fVar4;
        if (!param_5) {
          Rect.set_xMin(rect,fVar4,0);
          Rect.get_xMax(width,0);
          Rect.set_xMax(rect);
          fVar4 = (float)Rect.get_yMax(width,0);
          Rect.set_yMin(rect,(1.0 - fVar4) * fVar5,0);
          FUN_18044df60(width,0);
        }
        else {
          Mathf.RoundToInt(fVar4,0);
          Rect.set_xMin(rect);
          fVar4 = (float)Rect.get_xMax(width,0);
          Mathf.RoundToInt((float)height * fVar4,0);
          Rect.set_xMax(rect);
          fVar4 = (float)Rect.get_yMax(width,0);
          Mathf.RoundToInt((1.0 - fVar4) * fVar5,0);
          Rect.set_yMin(rect);
          fVar4 = (float)FUN_18044df60(width,0);
          Mathf.RoundToInt((1.0 - fVar4) * fVar5,0);
        }
        Rect.set_yMax(rect);
        return rect;
    }

    // Token : 0x6000365
    // RVA   : 0xB02ED0   Offset: 0xB016D0   Length: 0xB0
    public static Rect MakePixelPerfect(Rect rect)
    {
        uint64 *
        NGUIMath.MakePixelPerfect(uint64 *rect,uint64 *param_2,int param_3,int param_4)
        {
        float fVar1;
        uint32 uVar2;
        float fVar3;
        float fVar4;
        uint64 local_58;
        uint64 uStack_50;
        uint64 local_48;
        uint64 uStack_40;
        local_58._0_4_ = *(uint32 *)param_2;
        local_58._4_4_ = *(uint32 *)((int64)param_2 + 4);
        local_48 = *param_2;
        uStack_50._0_4_ = *(uint32 *)(param_2 + 1);
        uStack_50._4_4_ = *(uint32 *)((int64)param_2 + 12);
        uStack_40 = param_2[1];
        fVar4 = (float)param_3;
        fVar3 = (float)param_4;
        fVar1 = (float)FUN_180d904a0(&local_48,0);
        Mathf.RoundToInt(fVar4 * fVar1,0);
        Rect.set_xMin(&local_58);
        fVar1 = (float)Rect.get_xMax(&local_48,0);
        Mathf.RoundToInt(fVar4 * fVar1,0);
        Rect.set_xMax(&local_58);
        fVar1 = (float)Rect.get_yMax(&local_48,0);
        Mathf.RoundToInt((1.0 - fVar1) * fVar3,0);
        Rect.set_yMin(&local_58);
        fVar1 = (float)FUN_18044df60(&local_48,0);
        Mathf.RoundToInt((1.0 - fVar1) * fVar3,0);
        Rect.set_yMax(&local_58);
        *(uint32 *)param_2 = (uint32)local_58;
        *(uint32 *)((int64)param_2 + 4) = local_58._4_4_;
        *(uint32 *)(param_2 + 1) = (uint32)uStack_50;
        *(uint32 *)((int64)param_2 + 12) = uStack_50._4_4_;
        uVar2 = FUN_180d904a0(param_2,0);
        Mathf.RoundToInt(uVar2,0);
        Rect.set_xMin(param_2);
        uVar2 = FUN_18044df60(param_2,0);
        Mathf.RoundToInt(uVar2,0);
        Rect.set_yMin(param_2);
        uVar2 = Rect.get_xMax(param_2,0);
        Mathf.RoundToInt(uVar2,0);
        Rect.set_xMax(param_2);
        uVar2 = Rect.get_yMax(param_2,0);
        Mathf.RoundToInt(uVar2,0);
        Rect.set_yMax(param_2);
        local_58 = *param_2;
        uStack_50 = param_2[1];
        if ((fVar4 != 0.0) && (fVar3 != 0.0)) {
          local_48 = local_58;
          uStack_40 = uStack_50;
          FUN_180d904a0(&local_48,0);
          Rect.set_xMin(&local_58);
          Rect.get_xMax(&local_48,0);
          Rect.set_xMax(&local_58);
          fVar1 = (float)Rect.get_yMax(&local_48,0);
          Rect.set_yMin(&local_58,1.0 - fVar1 / fVar3,0);
          FUN_18044df60(&local_48,0);
          Rect.set_yMax(&local_58);
        }
        *rect = local_58;
        rect[1] = uStack_50;
        return rect;
    }

    // Token : 0x6000366
    // RVA   : 0xB02F80   Offset: 0xB01780   Length: 0x281
    public static Rect MakePixelPerfect(Rect rect, int width, int height)
    {
        uint64 *
        NGUIMath.MakePixelPerfect(uint64 *rect,uint64 *width,int height,int param_4)
        {
        float fVar1;
        uint32 uVar2;
        float fVar3;
        float fVar4;
        uint64 local_58;
        uint64 uStack_50;
        uint64 local_48;
        uint64 uStack_40;
        local_58._0_4_ = *(uint32 *)width;
        local_58._4_4_ = *(uint32 *)((int64)width + 4);
        local_48 = *width;
        uStack_50._0_4_ = *(uint32 *)(width + 1);
        uStack_50._4_4_ = *(uint32 *)((int64)width + 12);
        uStack_40 = width[1];
        fVar4 = (float)height;
        fVar3 = (float)param_4;
        fVar1 = (float)FUN_180d904a0(&local_48,0);
        Mathf.RoundToInt(fVar4 * fVar1,0);
        Rect.set_xMin(&local_58);
        fVar1 = (float)Rect.get_xMax(&local_48,0);
        Mathf.RoundToInt(fVar4 * fVar1,0);
        Rect.set_xMax(&local_58);
        fVar1 = (float)Rect.get_yMax(&local_48,0);
        Mathf.RoundToInt((1.0 - fVar1) * fVar3,0);
        Rect.set_yMin(&local_58);
        fVar1 = (float)FUN_18044df60(&local_48,0);
        Mathf.RoundToInt((1.0 - fVar1) * fVar3,0);
        Rect.set_yMax(&local_58);
        *(uint32 *)width = (uint32)local_58;
        *(uint32 *)((int64)width + 4) = local_58._4_4_;
        *(uint32 *)(width + 1) = (uint32)uStack_50;
        *(uint32 *)((int64)width + 12) = uStack_50._4_4_;
        uVar2 = FUN_180d904a0(width,0);
        Mathf.RoundToInt(uVar2,0);
        Rect.set_xMin(width);
        uVar2 = FUN_18044df60(width,0);
        Mathf.RoundToInt(uVar2,0);
        Rect.set_yMin(width);
        uVar2 = Rect.get_xMax(width,0);
        Mathf.RoundToInt(uVar2,0);
        Rect.set_xMax(width);
        uVar2 = Rect.get_yMax(width,0);
        Mathf.RoundToInt(uVar2,0);
        Rect.set_yMax(width);
        local_58 = *width;
        uStack_50 = width[1];
        if ((fVar4 != 0.0) && (fVar3 != 0.0)) {
          local_48 = local_58;
          uStack_40 = uStack_50;
          FUN_180d904a0(&local_48,0);
          Rect.set_xMin(&local_58);
          Rect.get_xMax(&local_48,0);
          Rect.set_xMax(&local_58);
          fVar1 = (float)Rect.get_yMax(&local_48,0);
          Rect.set_yMin(&local_58,1.0 - fVar1 / fVar3,0);
          FUN_18044df60(&local_48,0);
          Rect.set_yMax(&local_58);
        }
        *rect = local_58;
        rect[1] = uStack_50;
        return rect;
    }

    // Token : 0x6000367
    // RVA   : 0xB01F50   Offset: 0xB00750   Length: 0x14B
    public static Vector2 ConstrainRect(Vector2 minRect, Vector2 maxRect, Vector2 minArea, Vector2 maxArea)
    {
        uint64
        NGUIMath.ConstrainRect(uint64 minRect,uint64 maxRect,uint64 minArea,uint64 maxArea)
        {
        uint64 uVar1;
        float fVar2;
        uint32 local_a8;
        uint32 uStack_a4;
        uint32 local_a0;
        uint32 uStack_9c;
        uint32 local_98;
        uint32 uStack_94;
        uint32 local_90;
        uint32 uStack_8c;
        uint32 local_88;
        uint32 uStack_84;
        uVar1 = Vector2.get_zero(0);
        local_98 = (float)maxRect;
        local_90 = (float)maxArea;
        local_88 = (float)minArea;
        local_a8 = (float)minRect;
        uStack_94 = (float)((uint64)maxRect >> 32);
        uStack_8c = (float)((uint64)maxArea >> 32);
        uStack_84 = (float)((uint64)minArea >> 32);
        uStack_a4 = (float)((uint64)minRect >> 32);
        local_a0 = (float)uVar1;
        uStack_9c = (float)((uint64)uVar1 >> 32);
        if (local_90 - local_88 < local_98 - local_a8) {
          fVar2 = (local_98 - local_a8) - (local_90 - local_88);
          local_88 = local_88 - fVar2;
          local_90 = local_90 + fVar2;
        }
        if (uStack_8c - uStack_84 < uStack_94 - uStack_a4) {
          fVar2 = (uStack_94 - uStack_a4) - (uStack_8c - uStack_84);
          uStack_84 = uStack_84 - fVar2;
          uStack_8c = uStack_8c + fVar2;
        }
        if (local_a8 < local_88) {
          local_a0 = (local_88 - local_a8) + local_a0;
        }
        if (local_90 < local_98) {
          local_a0 = local_a0 - (local_98 - local_90);
        }
        if (uStack_a4 < uStack_84) {
          uStack_9c = (uStack_84 - uStack_a4) + uStack_9c;
        }
        if (uStack_8c < uStack_94) {
          uStack_9c = uStack_9c - (uStack_94 - uStack_8c);
        }
        return CONCAT44(uStack_9c,local_a0);
    }

    // Token : 0x6000368
    // RVA   : 0xB01120   Offset: 0xAFF920   Length: 0x4A3
    public static Bounds CalculateAbsoluteWidgetBounds(Transform trans)
    {
        uint uVar1;
        bool cVar3;
        long lVar5;
        long lVar6;
        ulong uVar7;
        uint uVar8;
        uint uVar9;
        int iVar10;
        float fVar11;
        float fVar12;
        float fVar13;
        float fVar14;
        float fVar15;
        float fVar16;
        float fVar17;
        float fVar18;
        ulong local_118;
        float local_110;
        ulong local_108;
        float local_100;
        ulong local_f8;
        float local_f0;
        ulong local_e8;
        float local_e0;
        ulong local_d8;
        ulong uStack_d0;
        ulong local_c8;
        ulong local_b8;
        ulong uStack_b0;
        ulong local_a8;
        float local_98;
        ulong local_90;
        ulong uStack_88;
        ulong local_80;
        local_80 = 0;
        local_90 = 0;
        uStack_88 = 0;
        local_108 = 0;
        local_100 = 0.0;
        local_f8 = 0;
        local_f0 = 0.0;
        cVar3 = Object.op_Inequality(param_2,0,0);
        if (!cVar3) {
          puVar4 = (uint64 *)Vector3.get_zero(&local_118,0);
          uVar7 = *puVar4;
          uVar1 = *(uint32 *)(puVar4 + 1);
          puVar4 = (uint64 *)Vector3.get_zero(&local_118,0);
          local_f0 = *(float *)(puVar4 + 1);
          local_f8 = *puVar4;
          local_c8 = 0;
          local_d8 = 0;
          uStack_d0 = 0;
          local_108 = uVar7;
          local_100 = (float)uVar1;
          Bounds.ctor(&local_d8,&local_108,&local_f8,0);
          *trans = local_d8;
          trans[1] = uStack_d0;
        }
        else {
          if ((param_2 == 0) || (lVar5 = FUN_180956bf0(param_2,DAT_181d70140)) == null) {
        LAB_180b015ae:
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          if (*(int64 *)(lVar5 + 24) == 0) {
            puVar4 = (uint64 *)Transform.get_position(&local_118,param_2,0);
            uVar7 = *puVar4;
            uVar1 = *(uint32 *)(puVar4 + 1);
            puVar4 = (uint64 *)Vector3.get_zero(&local_118,0);
            local_d8 = *puVar4;
            uStack_d0 = CONCAT44(uStack_d0._4_4_,*(uint32 *)(puVar4 + 1));
            local_a8 = 0;
            local_b8 = 0;
            uStack_b0 = 0;
            local_e8 = uVar7;
            local_e0 = (float)uVar1;
            Bounds.ctor(&local_b8,&local_e8,&local_d8,0);
            *trans = local_b8;
            trans[1] = uStack_b0;
            local_c8 = local_a8;
          }
          else {
            fVar15 = 3.4028235e+38;
            uVar8 = 0;
            fVar16 = -3.4028235e+38;
            fVar13 = 3.4028235e+38;
            fVar14 = -3.4028235e+38;
            fVar17 = 3.4028235e+38;
            local_108 = 0x7f7fffff7f7fffff;
            fVar18 = -3.4028235e+38;
            local_100 = 3.4028235e+38;
            local_f8 = 0xff7fffffff7fffff;
            local_f0 = -3.4028235e+38;
            iVar10 = (int)*(int64 *)(lVar5 + 24);
            if (0 < iVar10) {
              do {
                if (*(uint32 *)(lVar5 + 24) <= uVar8) {
                  uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1800d65f0(uVar7,0);
                }
                plVar2 = lVar5[uVar8];
                if (plVar2 == (int64 *)0) goto LAB_180b015ae;
                cVar3 = Behaviour.get_enabled(plVar2);
                if (cVar3) {
                  lVar6 = (**(code **)(*plVar2 + 0x1e8))(plVar2,*(uint64 *)(*plVar2 + 0x1f0));
                  uVar9 = 0;
                  do {
                    if (lVar6 == null) goto LAB_180b015ae;
                    if (*(uint32 *)(lVar6 + 24) <= uVar9) {
                      uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                      FUN_1800d65f0(uVar7,0);
                    }
                    local_118 = lVar6[uVar9];
                    fVar11 = (float)local_118;
                    local_110 = *(float *)(lVar6 + 40 + (int64)(int)uVar9 * 12);
                    if (fVar16 < fVar11) {
                      local_f8 = CONCAT44(local_f8._4_4_,fVar11);
                      fVar16 = fVar11;
                    }
                    fVar12 = (float)((uint64)local_118 >> 32);
                    if (fVar14 < fVar12) {
                      local_f8 = CONCAT44(fVar12,(uint32)local_f8);
                      fVar14 = fVar12;
                    }
                    if (fVar18 < local_110) {
                      uStack_b0 = CONCAT44(uStack_b0._4_4_,local_110);
                      fVar18 = local_110;
                      local_f0 = local_110;
                    }
                    if (fVar11 < fVar15) {
                      local_108 = CONCAT44(local_108._4_4_,fVar11);
                      fVar15 = fVar11;
                    }
                    if (fVar12 < fVar13) {
                      local_108 = CONCAT44(fVar12,(uint32)local_108);
                      fVar13 = fVar12;
                    }
                    if (local_110 < fVar17) {
                      uStack_d0 = CONCAT44(uStack_d0._4_4_,local_110);
                      fVar17 = local_110;
                      local_100 = local_110;
                      local_d8 = local_118;
                    }
                    uVar9 = uVar9 + 1;
                    local_e8 = local_118;
                    local_e0 = local_110;
                    local_98 = local_110;
                  } while ((int)uVar9 < 4);
                }
                uVar8 = uVar8 + 1;
              } while ((int)uVar8 < iVar10);
            }
            puVar4 = (uint64 *)Vector3.get_zero(&local_118,0);
            local_d8 = *puVar4;
            local_e8 = local_108;
            local_e0 = local_100;
            uStack_d0._0_4_ = *(uint32 *)(puVar4 + 1);
            Bounds.ctor(&local_90,&local_e8,&local_d8,0);
            local_d8 = local_f8;
            uStack_d0 = CONCAT44(uStack_d0._4_4_,local_f0);
            Bounds.Encapsulate(&local_90,&local_d8,0);
            *trans = local_90;
            trans[1] = uStack_88;
            local_c8 = local_80;
          }
        }
        trans[2] = local_c8;
        return trans;
    }

    // Token : 0x6000369
    // RVA   : 0xB015D0   Offset: 0xAFFDD0   Length: 0x75
    public static Bounds CalculateRelativeWidgetBounds(Transform trans)
    {
        void NGUIMath.CalculateRelativeWidgetBounds
                     (int64 trans,char param_2,char param_3,uint64 param_4,float *param_5,
                     float *param_6,uint8 *param_7,char param_8)
        {
        float fVar1;
        char cVar2;
        int iVar3;
        uint64 uVar4;
        int64 lVar5;
        uint64 *puVar6;
        int64 *plVar7;
        uint32 uVar8;
        float fVar10;
        float fStack_54;
        uint64 local_48;
        uint32 local_40;
        uint8 local_38 [16];
        int64 *plVar9;
        cVar2 = Object.op_Equality(trans,0,0);
        if (!cVar2) {
          if (!param_2) {
            if (trans == null) goto LAB_180b01dd9;
            uVar4 = Component.get_gameObject(trans,0);
            cVar2 = NGUITools.GetActive(uVar4,0);
            if (!cVar2) {
              return;
            }
          }
          plVar9 = (int64 *)0;
          plVar7 = plVar9;
          if (!param_3) {
            if (trans == null) goto LAB_180b01dd9;
            plVar7 = (int64 *)Component.GetComponent(trans,DAT_181d6e2c0);
          }
          cVar2 = Object.op_Inequality(plVar7,0,0);
          if (cVar2) {
            if (plVar7 == (int64 *)0) goto LAB_180b01dd9;
            cVar2 = Behaviour.get_enabled(plVar7,0);
            if (!cVar2) {
              return;
            }
          }
          cVar2 = Object.op_Inequality(plVar7,0,0);
          if (cVar2) {
            if (plVar7 == (int64 *)0) goto LAB_180b01dd9;
            if (*(int *)((int64)plVar7 + 0x134) != 0) {
              lVar5 = (**(code **)(*plVar7 + 0x1e8))(plVar7,*(uint64 *)(*plVar7 + 0x1f0));
              while (lVar5 != null) {
                uVar8 = (uint32)plVar9;
                if (*(uint32 *)(lVar5 + 24) <= uVar8) {
                  uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1800d65f0(uVar4,0);
                }
                local_48 = lVar5[uVar8];
                local_40 = *(uint32 *)(lVar5 + 40 + (int64)(int)uVar8 * 12);
                puVar6 = (uint64 *)Matrix4x4.MultiplyPoint3x4(local_38,param_4,&local_48,0);
                uVar4 = *puVar6;
                fVar10 = (float)uVar4;
                fVar1 = *(float *)(puVar6 + 1);
                if (*param_6 <= fVar10 && fVar10 != *param_6) {
                  *param_6 = fVar10;
                }
                fStack_54 = (float)((uint64)uVar4 >> 32);
                if (param_6[1] <= fStack_54 && fStack_54 != param_6[1]) {
                  param_6[1] = fStack_54;
                }
                if (param_6[2] <= fVar1 && fVar1 != param_6[2]) {
                  param_6[2] = fVar1;
                }
                if (fVar10 < *param_5) {
                  *param_5 = fVar10;
                }
                if (fStack_54 < param_5[1]) {
                  param_5[1] = fStack_54;
                }
                if (fVar1 < param_5[2]) {
                  param_5[2] = fVar1;
                }
                plVar9 = (int64 *)(uint64)(uVar8 + 1);
                *param_7 = 1;
                if (3 < (int)(uVar8 + 1)) {
                  return;
                }
              }
              goto LAB_180b01dd9;
            }
          }
          if (trans == null) {
        LAB_180b01dd9:
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          plVar7 = (int64 *)Component.GetComponent(trans,DAT_181d6e7c0);
          cVar2 = Object.op_Inequality(plVar7,0,0);
          if (cVar2) {
            if (plVar7 == (int64 *)0) goto LAB_180b01dd9;
            cVar2 = Behaviour.get_enabled(plVar7,0);
            if (cVar2) {
              lVar5 = (**(code **)(*plVar7 + 0x1e8))(plVar7,*(uint64 *)(*plVar7 + 0x1f0));
              plVar7 = plVar9;
              do {
                if (lVar5 == null) goto LAB_180b01dd9;
                uVar8 = (uint32)plVar7;
                if (*(uint32 *)(lVar5 + 24) <= uVar8) {
                  uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1800d65f0(uVar4,0);
                }
                local_48 = lVar5[uVar8];
                local_40 = *(uint32 *)(lVar5 + 40 + (int64)(int)uVar8 * 12);
                puVar6 = (uint64 *)Matrix4x4.MultiplyPoint3x4(local_38,param_4,&local_48,0);
                uVar4 = *puVar6;
                fVar10 = (float)uVar4;
                fVar1 = *(float *)(puVar6 + 1);
                if (*param_6 <= fVar10 && fVar10 != *param_6) {
                  *param_6 = fVar10;
                }
                fStack_54 = (float)((uint64)uVar4 >> 32);
                if (param_6[1] <= fStack_54 && fStack_54 != param_6[1]) {
                  param_6[1] = fStack_54;
                }
                if (param_6[2] <= fVar1 && fVar1 != param_6[2]) {
                  param_6[2] = fVar1;
                }
                if (fVar10 < *param_5) {
                  *param_5 = fVar10;
                }
                if (fStack_54 < param_5[1]) {
                  param_5[1] = fStack_54;
                }
                if (fVar1 < param_5[2]) {
                  param_5[2] = fVar1;
                }
                plVar7 = (int64 *)(uint64)(uVar8 + 1);
                *param_7 = 1;
              } while ((int)(uVar8 + 1) < 4);
              if (!param_8) {
                return;
              }
            }
          }
          iVar3 = Transform.get_childCount(trans,0);
          if (0 < iVar3) {
            do {
              uVar4 = Transform.GetChild(trans,plVar9,0);
              NGUIMath.CalculateRelativeWidgetBounds(uVar4,param_2,0,param_4,param_5,param_6,param_7,1,0)
              ;
              uVar8 = (int)plVar9 + 1;
              plVar9 = (int64 *)(uint64)uVar8;
            } while ((int)uVar8 < iVar3);
          }
        }
    }

    // Token : 0x600036A
    // RVA   : 0xB018F0   Offset: 0xB000F0   Length: 0x41
    public static Bounds CalculateRelativeWidgetBounds(Transform trans, bool considerInactive)
    {
        void NGUIMath.CalculateRelativeWidgetBounds
                     (int64 trans,char considerInactive,char param_3,uint64 param_4,float *param_5,
                     float *param_6,uint8 *param_7,char param_8)
        {
        float fVar1;
        char cVar2;
        int iVar3;
        uint64 uVar4;
        int64 lVar5;
        uint64 *puVar6;
        int64 *plVar7;
        uint32 uVar8;
        float fVar10;
        float fStack_54;
        uint64 local_48;
        uint32 local_40;
        uint8 local_38 [16];
        int64 *plVar9;
        cVar2 = Object.op_Equality(trans,0,0);
        if (!cVar2) {
          if (!considerInactive) {
            if (trans == null) goto LAB_180b01dd9;
            uVar4 = Component.get_gameObject(trans,0);
            cVar2 = NGUITools.GetActive(uVar4,0);
            if (!cVar2) {
              return;
            }
          }
          plVar9 = (int64 *)0;
          plVar7 = plVar9;
          if (!param_3) {
            if (trans == null) goto LAB_180b01dd9;
            plVar7 = (int64 *)Component.GetComponent(trans,DAT_181d6e2c0);
          }
          cVar2 = Object.op_Inequality(plVar7,0,0);
          if (cVar2) {
            if (plVar7 == (int64 *)0) goto LAB_180b01dd9;
            cVar2 = Behaviour.get_enabled(plVar7,0);
            if (!cVar2) {
              return;
            }
          }
          cVar2 = Object.op_Inequality(plVar7,0,0);
          if (cVar2) {
            if (plVar7 == (int64 *)0) goto LAB_180b01dd9;
            if (*(int *)((int64)plVar7 + 0x134) != 0) {
              lVar5 = (**(code **)(*plVar7 + 0x1e8))(plVar7,*(uint64 *)(*plVar7 + 0x1f0));
              while (lVar5 != null) {
                uVar8 = (uint32)plVar9;
                if (*(uint32 *)(lVar5 + 24) <= uVar8) {
                  uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1800d65f0(uVar4,0);
                }
                local_48 = lVar5[uVar8];
                local_40 = *(uint32 *)(lVar5 + 40 + (int64)(int)uVar8 * 12);
                puVar6 = (uint64 *)Matrix4x4.MultiplyPoint3x4(local_38,param_4,&local_48,0);
                uVar4 = *puVar6;
                fVar10 = (float)uVar4;
                fVar1 = *(float *)(puVar6 + 1);
                if (*param_6 <= fVar10 && fVar10 != *param_6) {
                  *param_6 = fVar10;
                }
                fStack_54 = (float)((uint64)uVar4 >> 32);
                if (param_6[1] <= fStack_54 && fStack_54 != param_6[1]) {
                  param_6[1] = fStack_54;
                }
                if (param_6[2] <= fVar1 && fVar1 != param_6[2]) {
                  param_6[2] = fVar1;
                }
                if (fVar10 < *param_5) {
                  *param_5 = fVar10;
                }
                if (fStack_54 < param_5[1]) {
                  param_5[1] = fStack_54;
                }
                if (fVar1 < param_5[2]) {
                  param_5[2] = fVar1;
                }
                plVar9 = (int64 *)(uint64)(uVar8 + 1);
                *param_7 = 1;
                if (3 < (int)(uVar8 + 1)) {
                  return;
                }
              }
              goto LAB_180b01dd9;
            }
          }
          if (trans == null) {
        LAB_180b01dd9:
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          plVar7 = (int64 *)Component.GetComponent(trans,DAT_181d6e7c0);
          cVar2 = Object.op_Inequality(plVar7,0,0);
          if (cVar2) {
            if (plVar7 == (int64 *)0) goto LAB_180b01dd9;
            cVar2 = Behaviour.get_enabled(plVar7,0);
            if (cVar2) {
              lVar5 = (**(code **)(*plVar7 + 0x1e8))(plVar7,*(uint64 *)(*plVar7 + 0x1f0));
              plVar7 = plVar9;
              do {
                if (lVar5 == null) goto LAB_180b01dd9;
                uVar8 = (uint32)plVar7;
                if (*(uint32 *)(lVar5 + 24) <= uVar8) {
                  uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1800d65f0(uVar4,0);
                }
                local_48 = lVar5[uVar8];
                local_40 = *(uint32 *)(lVar5 + 40 + (int64)(int)uVar8 * 12);
                puVar6 = (uint64 *)Matrix4x4.MultiplyPoint3x4(local_38,param_4,&local_48,0);
                uVar4 = *puVar6;
                fVar10 = (float)uVar4;
                fVar1 = *(float *)(puVar6 + 1);
                if (*param_6 <= fVar10 && fVar10 != *param_6) {
                  *param_6 = fVar10;
                }
                fStack_54 = (float)((uint64)uVar4 >> 32);
                if (param_6[1] <= fStack_54 && fStack_54 != param_6[1]) {
                  param_6[1] = fStack_54;
                }
                if (param_6[2] <= fVar1 && fVar1 != param_6[2]) {
                  param_6[2] = fVar1;
                }
                if (fVar10 < *param_5) {
                  *param_5 = fVar10;
                }
                if (fStack_54 < param_5[1]) {
                  param_5[1] = fStack_54;
                }
                if (fVar1 < param_5[2]) {
                  param_5[2] = fVar1;
                }
                plVar7 = (int64 *)(uint64)(uVar8 + 1);
                *param_7 = 1;
              } while ((int)(uVar8 + 1) < 4);
              if (!param_8) {
                return;
              }
            }
          }
          iVar3 = Transform.get_childCount(trans,0);
          if (0 < iVar3) {
            do {
              uVar4 = Transform.GetChild(trans,plVar9,0);
              NGUIMath.CalculateRelativeWidgetBounds(uVar4,considerInactive,0,param_4,param_5,param_6,param_7,1,0)
              ;
              uVar8 = (int)plVar9 + 1;
              plVar9 = (int64 *)(uint64)uVar8;
            } while ((int)uVar8 < iVar3);
          }
        }
    }

    // Token : 0x600036B
    // RVA   : 0xB01E00   Offset: 0xB00600   Length: 0x82
    public static Bounds CalculateRelativeWidgetBounds(Transform relativeTo, Transform content)
    {
        void NGUIMath.CalculateRelativeWidgetBounds
                     (int64 relativeTo,char content,char param_3,uint64 param_4,float *param_5,
                     float *param_6,uint8 *param_7,char param_8)
        {
        float fVar1;
        char cVar2;
        int iVar3;
        uint64 uVar4;
        int64 lVar5;
        uint64 *puVar6;
        int64 *plVar7;
        uint32 uVar8;
        float fVar10;
        float fStack_54;
        uint64 local_48;
        uint32 local_40;
        uint8 local_38 [16];
        int64 *plVar9;
        cVar2 = Object.op_Equality(relativeTo,0,0);
        if (!cVar2) {
          if (!content) {
            if (relativeTo == null) goto LAB_180b01dd9;
            uVar4 = Component.get_gameObject(relativeTo,0);
            cVar2 = NGUITools.GetActive(uVar4,0);
            if (!cVar2) {
              return;
            }
          }
          plVar9 = (int64 *)0;
          plVar7 = plVar9;
          if (!param_3) {
            if (relativeTo == null) goto LAB_180b01dd9;
            plVar7 = (int64 *)Component.GetComponent(relativeTo,DAT_181d6e2c0);
          }
          cVar2 = Object.op_Inequality(plVar7,0,0);
          if (cVar2) {
            if (plVar7 == (int64 *)0) goto LAB_180b01dd9;
            cVar2 = Behaviour.get_enabled(plVar7,0);
            if (!cVar2) {
              return;
            }
          }
          cVar2 = Object.op_Inequality(plVar7,0,0);
          if (cVar2) {
            if (plVar7 == (int64 *)0) goto LAB_180b01dd9;
            if (*(int *)((int64)plVar7 + 0x134) != 0) {
              lVar5 = (**(code **)(*plVar7 + 0x1e8))(plVar7,*(uint64 *)(*plVar7 + 0x1f0));
              while (lVar5 != null) {
                uVar8 = (uint32)plVar9;
                if (*(uint32 *)(lVar5 + 24) <= uVar8) {
                  uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1800d65f0(uVar4,0);
                }
                local_48 = lVar5[uVar8];
                local_40 = *(uint32 *)(lVar5 + 40 + (int64)(int)uVar8 * 12);
                puVar6 = (uint64 *)Matrix4x4.MultiplyPoint3x4(local_38,param_4,&local_48,0);
                uVar4 = *puVar6;
                fVar10 = (float)uVar4;
                fVar1 = *(float *)(puVar6 + 1);
                if (*param_6 <= fVar10 && fVar10 != *param_6) {
                  *param_6 = fVar10;
                }
                fStack_54 = (float)((uint64)uVar4 >> 32);
                if (param_6[1] <= fStack_54 && fStack_54 != param_6[1]) {
                  param_6[1] = fStack_54;
                }
                if (param_6[2] <= fVar1 && fVar1 != param_6[2]) {
                  param_6[2] = fVar1;
                }
                if (fVar10 < *param_5) {
                  *param_5 = fVar10;
                }
                if (fStack_54 < param_5[1]) {
                  param_5[1] = fStack_54;
                }
                if (fVar1 < param_5[2]) {
                  param_5[2] = fVar1;
                }
                plVar9 = (int64 *)(uint64)(uVar8 + 1);
                *param_7 = 1;
                if (3 < (int)(uVar8 + 1)) {
                  return;
                }
              }
              goto LAB_180b01dd9;
            }
          }
          if (relativeTo == null) {
        LAB_180b01dd9:
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          plVar7 = (int64 *)Component.GetComponent(relativeTo,DAT_181d6e7c0);
          cVar2 = Object.op_Inequality(plVar7,0,0);
          if (cVar2) {
            if (plVar7 == (int64 *)0) goto LAB_180b01dd9;
            cVar2 = Behaviour.get_enabled(plVar7,0);
            if (cVar2) {
              lVar5 = (**(code **)(*plVar7 + 0x1e8))(plVar7,*(uint64 *)(*plVar7 + 0x1f0));
              plVar7 = plVar9;
              do {
                if (lVar5 == null) goto LAB_180b01dd9;
                uVar8 = (uint32)plVar7;
                if (*(uint32 *)(lVar5 + 24) <= uVar8) {
                  uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1800d65f0(uVar4,0);
                }
                local_48 = lVar5[uVar8];
                local_40 = *(uint32 *)(lVar5 + 40 + (int64)(int)uVar8 * 12);
                puVar6 = (uint64 *)Matrix4x4.MultiplyPoint3x4(local_38,param_4,&local_48,0);
                uVar4 = *puVar6;
                fVar10 = (float)uVar4;
                fVar1 = *(float *)(puVar6 + 1);
                if (*param_6 <= fVar10 && fVar10 != *param_6) {
                  *param_6 = fVar10;
                }
                fStack_54 = (float)((uint64)uVar4 >> 32);
                if (param_6[1] <= fStack_54 && fStack_54 != param_6[1]) {
                  param_6[1] = fStack_54;
                }
                if (param_6[2] <= fVar1 && fVar1 != param_6[2]) {
                  param_6[2] = fVar1;
                }
                if (fVar10 < *param_5) {
                  *param_5 = fVar10;
                }
                if (fStack_54 < param_5[1]) {
                  param_5[1] = fStack_54;
                }
                if (fVar1 < param_5[2]) {
                  param_5[2] = fVar1;
                }
                plVar7 = (int64 *)(uint64)(uVar8 + 1);
                *param_7 = 1;
              } while ((int)(uVar8 + 1) < 4);
              if (!param_8) {
                return;
              }
            }
          }
          iVar3 = Transform.get_childCount(relativeTo,0);
          if (0 < iVar3) {
            do {
              uVar4 = Transform.GetChild(relativeTo,plVar9,0);
              NGUIMath.CalculateRelativeWidgetBounds(uVar4,content,0,param_4,param_5,param_6,param_7,1,0)
              ;
              uVar8 = (int)plVar9 + 1;
              plVar9 = (int64 *)(uint64)uVar8;
            } while ((int)uVar8 < iVar3);
          }
        }
    }

    // Token : 0x600036C
    // RVA   : 0xB01650   Offset: 0xAFFE50   Length: 0x29B
    public static Bounds CalculateRelativeWidgetBounds(Transform relativeTo, Transform content, bool considerInactive, bool considerChildren)
    {
        void NGUIMath.CalculateRelativeWidgetBounds
                     (int64 relativeTo,char content,char considerInactive,uint64 considerChildren,float *param_5,
                     float *param_6,uint8 *param_7,char param_8)
        {
        float fVar1;
        char cVar2;
        int iVar3;
        uint64 uVar4;
        int64 lVar5;
        uint64 *puVar6;
        int64 *plVar7;
        uint32 uVar8;
        float fVar10;
        float fStack_54;
        uint64 local_48;
        uint32 local_40;
        uint8 local_38 [16];
        int64 *plVar9;
        cVar2 = Object.op_Equality(relativeTo,0,0);
        if (!cVar2) {
          if (!content) {
            if (relativeTo == null) goto LAB_180b01dd9;
            uVar4 = Component.get_gameObject(relativeTo,0);
            cVar2 = NGUITools.GetActive(uVar4,0);
            if (!cVar2) {
              return;
            }
          }
          plVar9 = (int64 *)0;
          plVar7 = plVar9;
          if (!considerInactive) {
            if (relativeTo == null) goto LAB_180b01dd9;
            plVar7 = (int64 *)Component.GetComponent(relativeTo,DAT_181d6e2c0);
          }
          cVar2 = Object.op_Inequality(plVar7,0,0);
          if (cVar2) {
            if (plVar7 == (int64 *)0) goto LAB_180b01dd9;
            cVar2 = Behaviour.get_enabled(plVar7,0);
            if (!cVar2) {
              return;
            }
          }
          cVar2 = Object.op_Inequality(plVar7,0,0);
          if (cVar2) {
            if (plVar7 == (int64 *)0) goto LAB_180b01dd9;
            if (*(int *)((int64)plVar7 + 0x134) != 0) {
              lVar5 = (**(code **)(*plVar7 + 0x1e8))(plVar7,*(uint64 *)(*plVar7 + 0x1f0));
              while (lVar5 != null) {
                uVar8 = (uint32)plVar9;
                if (*(uint32 *)(lVar5 + 24) <= uVar8) {
                  uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1800d65f0(uVar4,0);
                }
                local_48 = lVar5[uVar8];
                local_40 = *(uint32 *)(lVar5 + 40 + (int64)(int)uVar8 * 12);
                puVar6 = (uint64 *)Matrix4x4.MultiplyPoint3x4(local_38,considerChildren,&local_48,0);
                uVar4 = *puVar6;
                fVar10 = (float)uVar4;
                fVar1 = *(float *)(puVar6 + 1);
                if (*param_6 <= fVar10 && fVar10 != *param_6) {
                  *param_6 = fVar10;
                }
                fStack_54 = (float)((uint64)uVar4 >> 32);
                if (param_6[1] <= fStack_54 && fStack_54 != param_6[1]) {
                  param_6[1] = fStack_54;
                }
                if (param_6[2] <= fVar1 && fVar1 != param_6[2]) {
                  param_6[2] = fVar1;
                }
                if (fVar10 < *param_5) {
                  *param_5 = fVar10;
                }
                if (fStack_54 < param_5[1]) {
                  param_5[1] = fStack_54;
                }
                if (fVar1 < param_5[2]) {
                  param_5[2] = fVar1;
                }
                plVar9 = (int64 *)(uint64)(uVar8 + 1);
                *param_7 = 1;
                if (3 < (int)(uVar8 + 1)) {
                  return;
                }
              }
              goto LAB_180b01dd9;
            }
          }
          if (relativeTo == null) {
        LAB_180b01dd9:
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          plVar7 = (int64 *)Component.GetComponent(relativeTo,DAT_181d6e7c0);
          cVar2 = Object.op_Inequality(plVar7,0,0);
          if (cVar2) {
            if (plVar7 == (int64 *)0) goto LAB_180b01dd9;
            cVar2 = Behaviour.get_enabled(plVar7,0);
            if (cVar2) {
              lVar5 = (**(code **)(*plVar7 + 0x1e8))(plVar7,*(uint64 *)(*plVar7 + 0x1f0));
              plVar7 = plVar9;
              do {
                if (lVar5 == null) goto LAB_180b01dd9;
                uVar8 = (uint32)plVar7;
                if (*(uint32 *)(lVar5 + 24) <= uVar8) {
                  uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1800d65f0(uVar4,0);
                }
                local_48 = lVar5[uVar8];
                local_40 = *(uint32 *)(lVar5 + 40 + (int64)(int)uVar8 * 12);
                puVar6 = (uint64 *)Matrix4x4.MultiplyPoint3x4(local_38,considerChildren,&local_48,0);
                uVar4 = *puVar6;
                fVar10 = (float)uVar4;
                fVar1 = *(float *)(puVar6 + 1);
                if (*param_6 <= fVar10 && fVar10 != *param_6) {
                  *param_6 = fVar10;
                }
                fStack_54 = (float)((uint64)uVar4 >> 32);
                if (param_6[1] <= fStack_54 && fStack_54 != param_6[1]) {
                  param_6[1] = fStack_54;
                }
                if (param_6[2] <= fVar1 && fVar1 != param_6[2]) {
                  param_6[2] = fVar1;
                }
                if (fVar10 < *param_5) {
                  *param_5 = fVar10;
                }
                if (fStack_54 < param_5[1]) {
                  param_5[1] = fStack_54;
                }
                if (fVar1 < param_5[2]) {
                  param_5[2] = fVar1;
                }
                plVar7 = (int64 *)(uint64)(uVar8 + 1);
                *param_7 = 1;
              } while ((int)(uVar8 + 1) < 4);
              if (!param_8) {
                return;
              }
            }
          }
          iVar3 = Transform.get_childCount(relativeTo,0);
          if (0 < iVar3) {
            do {
              uVar4 = Transform.GetChild(relativeTo,plVar9,0);
              NGUIMath.CalculateRelativeWidgetBounds(uVar4,content,0,considerChildren,param_5,param_6,param_7,1,0)
              ;
              uVar8 = (int)plVar9 + 1;
              plVar9 = (int64 *)(uint64)uVar8;
            } while ((int)uVar8 < iVar3);
          }
        }
    }

    // Token : 0x600036D
    // RVA   : 0xB01940   Offset: 0xB00140   Length: 0x4BE
    private static void CalculateRelativeWidgetBounds(Transform content, bool considerInactive, bool isRoot, ref Matrix4x4 toLocal, ref Vector3 vMin, ref Vector3 vMax, ref bool isSet, bool considerChildren)
    {
        void NGUIMath.CalculateRelativeWidgetBounds
                     (int64 content,char considerInactive,char isRoot,uint64 toLocal,float *vMin,
                     float *vMax,uint8 *isSet,char considerChildren)
        {
        float fVar1;
        char cVar2;
        int iVar3;
        uint64 uVar4;
        int64 lVar5;
        uint64 *puVar6;
        int64 *plVar7;
        uint32 uVar8;
        float fVar10;
        float fStack_54;
        uint64 local_48;
        uint32 local_40;
        uint8 local_38 [16];
        int64 *plVar9;
        cVar2 = Object.op_Equality(content,0,0);
        if (!cVar2) {
          if (!considerInactive) {
            if (content == null) goto LAB_180b01dd9;
            uVar4 = Component.get_gameObject(content,0);
            cVar2 = NGUITools.GetActive(uVar4,0);
            if (!cVar2) {
              return;
            }
          }
          plVar9 = (int64 *)0;
          plVar7 = plVar9;
          if (!isRoot) {
            if (content == null) goto LAB_180b01dd9;
            plVar7 = (int64 *)Component.GetComponent(content,DAT_181d6e2c0);
          }
          cVar2 = Object.op_Inequality(plVar7,0,0);
          if (cVar2) {
            if (plVar7 == (int64 *)0) goto LAB_180b01dd9;
            cVar2 = Behaviour.get_enabled(plVar7,0);
            if (!cVar2) {
              return;
            }
          }
          cVar2 = Object.op_Inequality(plVar7,0,0);
          if (cVar2) {
            if (plVar7 == (int64 *)0) goto LAB_180b01dd9;
            if (*(int *)((int64)plVar7 + 0x134) != 0) {
              lVar5 = (**(code **)(*plVar7 + 0x1e8))(plVar7,*(uint64 *)(*plVar7 + 0x1f0));
              while (lVar5 != null) {
                uVar8 = (uint32)plVar9;
                if (*(uint32 *)(lVar5 + 24) <= uVar8) {
                  uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1800d65f0(uVar4,0);
                }
                local_48 = lVar5[uVar8];
                local_40 = *(uint32 *)(lVar5 + 40 + (int64)(int)uVar8 * 12);
                puVar6 = (uint64 *)Matrix4x4.MultiplyPoint3x4(local_38,toLocal,&local_48,0);
                uVar4 = *puVar6;
                fVar10 = (float)uVar4;
                fVar1 = *(float *)(puVar6 + 1);
                if (*vMax <= fVar10 && fVar10 != *vMax) {
                  *vMax = fVar10;
                }
                fStack_54 = (float)((uint64)uVar4 >> 32);
                if (vMax[1] <= fStack_54 && fStack_54 != vMax[1]) {
                  vMax[1] = fStack_54;
                }
                if (vMax[2] <= fVar1 && fVar1 != vMax[2]) {
                  vMax[2] = fVar1;
                }
                if (fVar10 < *vMin) {
                  *vMin = fVar10;
                }
                if (fStack_54 < vMin[1]) {
                  vMin[1] = fStack_54;
                }
                if (fVar1 < vMin[2]) {
                  vMin[2] = fVar1;
                }
                plVar9 = (int64 *)(uint64)(uVar8 + 1);
                *isSet = 1;
                if (3 < (int)(uVar8 + 1)) {
                  return;
                }
              }
              goto LAB_180b01dd9;
            }
          }
          if (content == null) {
        LAB_180b01dd9:
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          plVar7 = (int64 *)Component.GetComponent(content,DAT_181d6e7c0);
          cVar2 = Object.op_Inequality(plVar7,0,0);
          if (cVar2) {
            if (plVar7 == (int64 *)0) goto LAB_180b01dd9;
            cVar2 = Behaviour.get_enabled(plVar7,0);
            if (cVar2) {
              lVar5 = (**(code **)(*plVar7 + 0x1e8))(plVar7,*(uint64 *)(*plVar7 + 0x1f0));
              plVar7 = plVar9;
              do {
                if (lVar5 == null) goto LAB_180b01dd9;
                uVar8 = (uint32)plVar7;
                if (*(uint32 *)(lVar5 + 24) <= uVar8) {
                  uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1800d65f0(uVar4,0);
                }
                local_48 = lVar5[uVar8];
                local_40 = *(uint32 *)(lVar5 + 40 + (int64)(int)uVar8 * 12);
                puVar6 = (uint64 *)Matrix4x4.MultiplyPoint3x4(local_38,toLocal,&local_48,0);
                uVar4 = *puVar6;
                fVar10 = (float)uVar4;
                fVar1 = *(float *)(puVar6 + 1);
                if (*vMax <= fVar10 && fVar10 != *vMax) {
                  *vMax = fVar10;
                }
                fStack_54 = (float)((uint64)uVar4 >> 32);
                if (vMax[1] <= fStack_54 && fStack_54 != vMax[1]) {
                  vMax[1] = fStack_54;
                }
                if (vMax[2] <= fVar1 && fVar1 != vMax[2]) {
                  vMax[2] = fVar1;
                }
                if (fVar10 < *vMin) {
                  *vMin = fVar10;
                }
                if (fStack_54 < vMin[1]) {
                  vMin[1] = fStack_54;
                }
                if (fVar1 < vMin[2]) {
                  vMin[2] = fVar1;
                }
                plVar7 = (int64 *)(uint64)(uVar8 + 1);
                *isSet = 1;
              } while ((int)(uVar8 + 1) < 4);
              if (!considerChildren) {
                return;
              }
            }
          }
          iVar3 = Transform.get_childCount(content,0);
          if (0 < iVar3) {
            do {
              uVar4 = Transform.GetChild(content,plVar9,0);
              NGUIMath.CalculateRelativeWidgetBounds(uVar4,considerInactive,0,toLocal,vMin,vMax,isSet,1,0)
              ;
              uVar8 = (int)plVar9 + 1;
              plVar9 = (int64 *)(uint64)uVar8;
            } while ((int)uVar8 < iVar3);
          }
        }
    }

    // Token : 0x600036E
    // RVA   : 0xB041A0   Offset: 0xB029A0   Length: 0x169
    public static Vector3 SpringDampen(ref Vector3 velocity, float strength, float deltaTime)
    {
        float fVar1;
        float fVar2;
        float fVar3;
        float fVar4;
        fVar1 = 1.0;
        if (deltaTime <= 1.0) {
          fVar1 = deltaTime;
        }
        fVar4 = 1.0 - strength * 0.001;
        Mathf.RoundToInt(fVar1 * 1000.0,0);
        fVar1 = (float)FUN_1801f7f00(fVar4);
        fVar2 = (float)*velocity;
        fVar3 = (float)((uint64)*velocity >> 32);
        fVar4 = (float)FUN_1801f94f0(fVar4);
        fVar4 = (fVar1 - 1.0) / fVar4;
        *velocity = CONCAT44(fVar3 * fVar1,fVar2 * fVar1);
        return CONCAT44(fVar3 * fVar4 * 0.06,fVar2 * fVar4 * 0.06);
    }

    // Token : 0x600036F
    // RVA   : 0xB04310   Offset: 0xB02B10   Length: 0xE4
    public static Vector2 SpringDampen(ref Vector2 velocity, float strength, float deltaTime)
    {
        float fVar1;
        float fVar2;
        float fVar3;
        float fVar4;
        fVar1 = 1.0;
        if (deltaTime <= 1.0) {
          fVar1 = deltaTime;
        }
        fVar4 = 1.0 - strength * 0.001;
        Mathf.RoundToInt(fVar1 * 1000.0,0);
        fVar1 = (float)FUN_1801f7f00(fVar4);
        fVar2 = (float)*velocity;
        fVar3 = (float)((uint64)*velocity >> 32);
        fVar4 = (float)FUN_1801f94f0(fVar4);
        fVar4 = (fVar1 - 1.0) / fVar4;
        *velocity = CONCAT44(fVar3 * fVar1,fVar2 * fVar1);
        return CONCAT44(fVar3 * fVar4 * 0.06,fVar2 * fVar4 * 0.06);
    }

    // Token : 0x6000370
    // RVA   : 0xB04620   Offset: 0xB02E20   Length: 0x78
    public static float SpringLerp(float strength, float deltaTime)
    {
        uint64 *
        NGUIMath.SpringLerp
                (uint64 *strength,uint32 *deltaTime,uint32 *param_3,uint32 param_4,
                uint32 param_5)
        {
        uint64 uVar1;
        uint64 *puVar2;
        uint32 uVar3;
        uint32 local_38;
        uint32 uStack_34;
        uint32 uStack_30;
        uint32 uStack_2c;
        uint32 local_28;
        uint32 uStack_24;
        uint32 uStack_20;
        uint32 uStack_1c;
        uint8 local_18 [16];
        uVar3 = NGUIMath.SpringLerp(param_4,param_5,0);
        local_38 = *param_3;
        uStack_34 = param_3[1];
        uStack_30 = param_3[2];
        uStack_2c = param_3[3];
        local_28 = *deltaTime;
        uStack_24 = deltaTime[1];
        uStack_20 = deltaTime[2];
        uStack_1c = deltaTime[3];
        puVar2 = (uint64 *)Quaternion.Slerp(local_18,&local_28,&local_38,uVar3,0);
        uVar1 = puVar2[1];
        *strength = *puVar2;
        strength[1] = uVar1;
        return strength;
    }

    // Token : 0x6000371
    // RVA   : 0xB04480   Offset: 0xB02C80   Length: 0x8D
    public static float SpringLerp(float from, float to, float strength, float deltaTime)
    {
        uint64 *
        NGUIMath.SpringLerp
                (uint64 *from,uint32 *to,uint32 *strength,uint32 deltaTime,
                uint32 param_5)
        {
        uint64 uVar1;
        uint64 *puVar2;
        uint32 uVar3;
        uint32 local_38;
        uint32 uStack_34;
        uint32 uStack_30;
        uint32 uStack_2c;
        uint32 local_28;
        uint32 uStack_24;
        uint32 uStack_20;
        uint32 uStack_1c;
        uint8 local_18 [16];
        uVar3 = NGUIMath.SpringLerp(deltaTime,param_5,0);
        local_38 = *strength;
        uStack_34 = strength[1];
        uStack_30 = strength[2];
        uStack_2c = strength[3];
        local_28 = *to;
        uStack_24 = to[1];
        uStack_20 = to[2];
        uStack_1c = to[3];
        puVar2 = (uint64 *)Quaternion.Slerp(local_18,&local_28,&local_38,uVar3,0);
        uVar1 = puVar2[1];
        *from = *puVar2;
        from[1] = uVar1;
        return from;
    }

    // Token : 0x6000372
    // RVA   : 0xB046A0   Offset: 0xB02EA0   Length: 0x5F
    public static Vector2 SpringLerp(Vector2 from, Vector2 to, float strength, float deltaTime)
    {
        uint64 *
        NGUIMath.SpringLerp
                (uint64 *from,uint32 *to,uint32 *strength,uint32 deltaTime,
                uint32 param_5)
        {
        uint64 uVar1;
        uint64 *puVar2;
        uint32 uVar3;
        uint32 local_38;
        uint32 uStack_34;
        uint32 uStack_30;
        uint32 uStack_2c;
        uint32 local_28;
        uint32 uStack_24;
        uint32 uStack_20;
        uint32 uStack_1c;
        uint8 local_18 [16];
        uVar3 = NGUIMath.SpringLerp(deltaTime,param_5,0);
        local_38 = *strength;
        uStack_34 = strength[1];
        uStack_30 = strength[2];
        uStack_2c = strength[3];
        local_28 = *to;
        uStack_24 = to[1];
        uStack_20 = to[2];
        uStack_1c = to[3];
        puVar2 = (uint64 *)Quaternion.Slerp(local_18,&local_28,&local_38,uVar3,0);
        uVar1 = puVar2[1];
        *from = *puVar2;
        from[1] = uVar1;
        return from;
    }

    // Token : 0x6000373
    // RVA   : 0xB04510   Offset: 0xB02D10   Length: 0x10C
    public static Vector3 SpringLerp(Vector3 from, Vector3 to, float strength, float deltaTime)
    {
        uint64 *
        NGUIMath.SpringLerp
                (uint64 *from,uint32 *to,uint32 *strength,uint32 deltaTime,
                uint32 param_5)
        {
        uint64 uVar1;
        uint64 *puVar2;
        uint32 uVar3;
        uint32 local_38;
        uint32 uStack_34;
        uint32 uStack_30;
        uint32 uStack_2c;
        uint32 local_28;
        uint32 uStack_24;
        uint32 uStack_20;
        uint32 uStack_1c;
        uint8 local_18 [16];
        uVar3 = NGUIMath.SpringLerp(deltaTime,param_5,0);
        local_38 = *strength;
        uStack_34 = strength[1];
        uStack_30 = strength[2];
        uStack_2c = strength[3];
        local_28 = *to;
        uStack_24 = to[1];
        uStack_20 = to[2];
        uStack_1c = to[3];
        puVar2 = (uint64 *)Quaternion.Slerp(local_18,&local_28,&local_38,uVar3,0);
        uVar1 = puVar2[1];
        *from = *puVar2;
        from[1] = uVar1;
        return from;
    }

    // Token : 0x6000374
    // RVA   : 0xB04400   Offset: 0xB02C00   Length: 0x75
    public static Quaternion SpringLerp(Quaternion from, Quaternion to, float strength, float deltaTime)
    {
        uint64 *
        NGUIMath.SpringLerp
                (uint64 *from,uint32 *to,uint32 *strength,uint32 deltaTime,
                uint32 param_5)
        {
        uint64 uVar1;
        uint64 *puVar2;
        uint32 uVar3;
        uint32 local_38;
        uint32 uStack_34;
        uint32 uStack_30;
        uint32 uStack_2c;
        uint32 local_28;
        uint32 uStack_24;
        uint32 uStack_20;
        uint32 uStack_1c;
        uint8 local_18 [16];
        uVar3 = NGUIMath.SpringLerp(deltaTime,param_5,0);
        local_38 = *strength;
        uStack_34 = strength[1];
        uStack_30 = strength[2];
        uStack_2c = strength[3];
        local_28 = *to;
        uStack_24 = to[1];
        uStack_20 = to[2];
        uStack_1c = to[3];
        puVar2 = (uint64 *)Quaternion.Slerp(local_18,&local_28,&local_38,uVar3,0);
        uVar1 = puVar2[1];
        *from = *puVar2;
        from[1] = uVar1;
        return from;
    }

    // Token : 0x6000375
    // RVA   : 0xB03C80   Offset: 0xB02480   Length: 0x8F
    public static float RotateTowards(float from, float to, float maxAngle)
    {
        ulong uVar1;
        float fVar2;
        uint uVar3;
        uVar3 = (uint32)((uint64)to >> 32);
        for (fVar2 = (float)to - from; 180.0 < fVar2; fVar2 = fVar2 + -360.0) {
        }
        for (; fVar2 < -180.0; fVar2 = fVar2 + 360.0) {
        }
        if (maxAngle < ABS(fVar2)) {
          uVar1 = Mathf.Sign(fVar2,0);
          uVar3 = (uint32)((uint64)uVar1 >> 32);
          fVar2 = (float)uVar1 * maxAngle;
        }
        return CONCAT44(uVar3,fVar2 + from);
    }

    // Token : 0x6000376
    // RVA   : 0xB02410   Offset: 0xB00C10   Length: 0x162
    private static float DistancePointToLineSegment(Vector2 point, Vector2 a, Vector2 b)
    {
        float fVar1;
        float fVar2;
        float fVar3;
        float fVar4;
        float fVar5;
        ulong local_88;
        ulong local_80;
        ulong local_78;
        local_78._4_4_ = (float)((uint64)b >> 32);
        local_78._0_4_ = (float)b;
        local_88._0_4_ = (float)a;
        fVar2 = (float)local_88;
        local_88._4_4_ = (float)((uint64)a >> 32);
        fVar3 = local_88._4_4_;
        fVar4 = (float)local_78 - (float)local_88;
        fVar5 = local_78._4_4_ - local_88._4_4_;
        local_88 = CONCAT44(fVar5,fVar4);
        local_80 = point;
        local_78 = b;
        fVar1 = (float)Vector2.get_sqrMagnitude(&local_88,0);
        if ((fVar1 == 0.0) ||
           (fVar1 = (((float)local_80 - fVar2) * fVar4 + (local_80._4_4_ - fVar3) * fVar5) / fVar1,
           fVar1 < 0.0)) {
          fVar3 = local_80._4_4_ - fVar3;
          fVar2 = (float)local_80 - fVar2;
        }
        else if (1.0 < fVar1) {
          fVar2 = (float)local_80 - (float)local_78;
          fVar3 = local_80._4_4_ - local_78._4_4_;
        }
        else {
          fVar2 = (float)local_80 - (fVar2 + fVar4 * fVar1);
          fVar3 = local_80._4_4_ - (fVar3 + fVar5 * fVar1);
        }
        local_88 = CONCAT44(fVar3,fVar2);
        Vector2.get_magnitude(&local_88,0);
    }

    // Token : 0x6000377
    // RVA   : 0xB026D0   Offset: 0xB00ED0   Length: 0x366
    public static float DistanceToRectangle(Vector2[] screenPoints, Vector2 mousePos)
    {
        long lVar1;
        ulong uVar3;
        uint uVar4;
        long lVar5;
        ulong local_58;
        uint local_50;
        ulong local_48;
        ulong local_38;
        byte[] local_28 = new byte[32];
        lVar1 = FUN_1800d60b0(DAT_181d81bc0,4);
        uVar4 = 0;
        while (screenPoints != null) {
          lVar5 = (int64)(int)uVar4;
          if (*(uint32 *)(screenPoints + 24) <= uVar4) {
            uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar3,0);
          }
          if (param_3 == 0) break;
          local_58 = *(uint64 *)(screenPoints + 32 + lVar5 * 12);
          local_50 = *(uint32 *)(screenPoints + 40 + lVar5 * 12);
          puVar2 = (uint64 *)Camera.WorldToScreenPoint(local_28,param_3,&local_58,0);
          local_48 = *puVar2;
          local_38 = local_48;
          if (lVar1 == null) break;
          if (*(uint32 *)(lVar1 + 24) <= uVar4) {
            uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar3,0);
          }
          uVar4 = uVar4 + 1;
          local_38._4_4_ = (uint32)((uint64)local_48 >> 32);
          *(uint32 *)(lVar1 + 32 + lVar5 * 8) = (uint32)local_48;
          *(uint32 *)(lVar1 + 36 + lVar5 * 8) = local_38._4_4_;
          if (3 < (int)uVar4) {
            NGUIMath.DistanceToRectangle(lVar1,mousePos,0);
            return;
          }
        }
    }

    // Token : 0x6000378
    // RVA   : 0xB02580   Offset: 0xB00D80   Length: 0x140
    public static float DistanceToRectangle(Vector3[] worldPoints, Vector2 mousePos, Camera cam)
    {
        long lVar1;
        ulong uVar3;
        uint uVar4;
        long lVar5;
        ulong local_58;
        uint local_50;
        ulong local_48;
        ulong local_38;
        byte[] local_28 = new byte[32];
        lVar1 = FUN_1800d60b0(DAT_181d81bc0,4);
        uVar4 = 0;
        while (worldPoints != null) {
          lVar5 = (int64)(int)uVar4;
          if (*(uint32 *)(worldPoints + 24) <= uVar4) {
            uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar3,0);
          }
          if (cam == null) break;
          local_58 = *(uint64 *)(worldPoints + 32 + lVar5 * 12);
          local_50 = *(uint32 *)(worldPoints + 40 + lVar5 * 12);
          puVar2 = (uint64 *)Camera.WorldToScreenPoint(local_28,cam,&local_58,0);
          local_48 = *puVar2;
          local_38 = local_48;
          if (lVar1 == null) break;
          if (*(uint32 *)(lVar1 + 24) <= uVar4) {
            uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar3,0);
          }
          uVar4 = uVar4 + 1;
          local_38._4_4_ = (uint32)((uint64)local_48 >> 32);
          *(uint32 *)(lVar1 + 32 + lVar5 * 8) = (uint32)local_48;
          *(uint32 *)(lVar1 + 36 + lVar5 * 8) = local_38._4_4_;
          if (3 < (int)uVar4) {
            NGUIMath.DistanceToRectangle(lVar1,mousePos,0);
            return;
          }
        }
    }

    // Token : 0x6000379
    // RVA   : 0xB02A40   Offset: 0xB01240   Length: 0x99
    public static Vector2 GetPivotOffset(Pivot pv)
    {
        uint local_res18;
        Vector2.get_zero(0);
        if (((pv == 1) || (pv == 4)) || (pv == 7)) {
          local_res18 = 0x3f000000;
        }
        else if (((pv == 2) || (pv == 5)) || (pv == 8)) {
          local_res18 = 0x3f800000;
        }
        else {
          local_res18 = 0;
        }
        if ((1 < pv - 3) && (pv != 5)) {
          if ((1 < pv) && (pv != 2)) {
            return (uint64)local_res18;
          }
          return CONCAT44(0x3f800000,local_res18);
        }
        return CONCAT44(0x3f000000,local_res18);
    }

    // Token : 0x600037A
    // RVA   : 0xB02AE0   Offset: 0xB012E0   Length: 0x96
    public static Pivot GetPivot(Vector2 offset)
    {
        ulong uVar1;
        uint local_res18;
        uint32 uStackX_1c;
        local_res18 = (float)offset;
        uStackX_1c = (float)((uint64)offset >> 32);
        if (local_res18 == 0.0) {
          if (uStackX_1c == 0.0) {
            return 6;
          }
          if (uStackX_1c != 1.0) {
            return 3;
          }
          return 0;
        }
        if (local_res18 != 1.0) {
          if (uStackX_1c != 0.0) {
            uVar1 = 1;
            if (uStackX_1c != 1.0) {
              uVar1 = 4;
            }
            return uVar1;
          }
          return 7;
        }
        if (uStackX_1c != 0.0) {
          if (uStackX_1c != 1.0) {
            return 5;
          }
          return 2;
        }
        return 8;
    }

    // Token : 0x600037B
    // RVA   : 0xB034A0   Offset: 0xB01CA0   Length: 0x8
    public static void MoveWidget(UIRect w, float x, float y)
    {
        void FUN_180b034a0(void)
        {
        NGUIMath.MoveRect();
    }

    // Token : 0x600037C
    // RVA   : 0xB03210   Offset: 0xB01A10   Length: 0x28A
    public static void MoveRect(UIRect rect, float x, float y)
    {
        ulong uVar2;
        bool cVar3;
        int iVar4;
        int iVar5;
        long lVar6;
        int iVar8;
        ulong local_58;
        float local_50;
        float local_40;
        byte[] local_38 = new byte[48];
        iVar4 = Mathf.FloorToInt(x + 0.5,0);
        iVar5 = Mathf.FloorToInt(y + 0.5,0);
        if (rect != null) {
          lVar6 = UIRect.get_cachedTransform(rect,0);
          if (lVar6 != null) {
            puVar7 = (uint64 *)Transform.get_localPosition(local_38,lVar6,0);
            local_50 = *(float *)(puVar7 + 1) + 0.0;
            local_58 = CONCAT44((float)iVar5 + (float)((uint64)*puVar7 >> 32),
                                (float)iVar4 + (float)*puVar7);
            local_40 = local_50;
            Transform.set_localPosition(lVar6,&local_58,0);
            iVar8 = 0;
            if (*(int64 *)(rect + 24) != 0) {
              uVar2 = *(uint64 *)(*(int64 *)(rect + 24) + 16);
              cVar3 = Object.op_Implicit(uVar2,0);
              if (cVar3) {
                iVar8 = 1;
                if (*(int64 *)(rect + 24) == 0) throw; // [null/range check failed]
                piVar1 = (int *)(*(int64 *)(rect + 24) + 28);
                *piVar1 = *piVar1 + iVar4;
              }
              if (*(int64 *)(rect + 32) != 0) {
                uVar2 = *(uint64 *)(*(int64 *)(rect + 32) + 16);
                cVar3 = Object.op_Implicit(uVar2,0);
                if (cVar3) {
                  iVar8 = iVar8 + 1;
                  if (*(int64 *)(rect + 32) == 0) throw; // [null/range check failed]
                  piVar1 = (int *)(*(int64 *)(rect + 32) + 28);
                  *piVar1 = *piVar1 + iVar4;
                }
                if (*(int64 *)(rect + 40) != 0) {
                  uVar2 = *(uint64 *)(*(int64 *)(rect + 40) + 16);
                  cVar3 = Object.op_Implicit(uVar2,0);
                  if (cVar3) {
                    iVar8 = iVar8 + 1;
                    if (*(int64 *)(rect + 40) == 0) throw; // [null/range check failed]
                    piVar1 = (int *)(*(int64 *)(rect + 40) + 28);
                    *piVar1 = *piVar1 + iVar5;
                  }
                  if (*(int64 *)(rect + 48) != 0) {
                    uVar2 = *(uint64 *)(*(int64 *)(rect + 48) + 16);
                    cVar3 = Object.op_Implicit(uVar2,0);
                    if (cVar3) {
                      iVar8 = iVar8 + 1;
                      if (*(int64 *)(rect + 48) == 0) throw; // [null/range check failed]
                      piVar1 = (int *)(*(int64 *)(rect + 48) + 28);
                      *piVar1 = *piVar1 + iVar5;
                    }
                    if (iVar8 != 0) {
                      UIRect.UpdateAnchors(rect,0);
                    }
                    return;
                  }
                }
              }
            }
          }
        }
    }

    // Token : 0x600037D
    // RVA   : 0xB038E0   Offset: 0xB020E0   Length: 0x37
    public static void ResizeWidget(UIWidget w, Pivot pivot, float x, float y, int minWidth, int minHeight)
    {
        uint uVar1;
        uint uVar2;
        long lVar3;
        ulong local_58;
        uint local_50;
        ulong local_48;
        ulong uStack_40;
        ulong local_38;
        ulong uStack_30;
        if (w == null) {
        LAB_180b03c52:
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
        if (pivot == 4) {
          uVar1 = Mathf.RoundToInt(w,0);
          uVar2 = Mathf.RoundToInt();
          if (uVar2 == (uVar2 & 1) && uVar1 == (uVar1 & 1)) {
            return;
          }
        }
        else {
          lVar3 = UIRect.get_cachedTransform();
          if (lVar3 == null) goto LAB_180b03c52;
          puVar4 = (uint64 *)Transform.get_localRotation(&local_38,lVar3,0);
          local_58 = CONCAT44(y,x);
          local_50 = 0;
          local_48 = *puVar4;
          uStack_40 = puVar4[1];
          puVar4 = (uint64 *)Quaternion.Inverse(&local_38,&local_48,0);
          local_38 = *puVar4;
          uStack_30 = puVar4[1];
          puVar4 = (uint64 *)Quaternion.op_Multiply(&local_48,&local_38,&local_58,0);
          local_58 = *puVar4;
          switch(pivot) {
          case 0:
            break;
          case 1:
            break;
          case 2:
            break;
          case 3:
            break;
          default:
            goto switchD_180b039e6_caseD_4;
          case 5:
            break;
          case 6:
            break;
          case 7:
            break;
          case 8:
          }
        }
        NGUIMath.AdjustWidget(w);
        switchD_180b039e6_caseD_4:
    }

    // Token : 0x600037E
    // RVA   : 0xB03920   Offset: 0xB02120   Length: 0x338
    public static void ResizeWidget(UIWidget w, Pivot pivot, float x, float y, int minWidth, int minHeight, int maxWidth, int maxHeight)
    {
        uint uVar1;
        uint uVar2;
        long lVar3;
        ulong local_58;
        uint local_50;
        ulong local_48;
        ulong uStack_40;
        ulong local_38;
        ulong uStack_30;
        if (w == null) {
        LAB_180b03c52:
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
        if (pivot == 4) {
          uVar1 = Mathf.RoundToInt(w,0);
          uVar2 = Mathf.RoundToInt();
          if (uVar2 == (uVar2 & 1) && uVar1 == (uVar1 & 1)) {
            return;
          }
        }
        else {
          lVar3 = UIRect.get_cachedTransform();
          if (lVar3 == null) goto LAB_180b03c52;
          puVar4 = (uint64 *)Transform.get_localRotation(&local_38,lVar3,0);
          local_58 = CONCAT44(y,x);
          local_50 = 0;
          local_48 = *puVar4;
          uStack_40 = puVar4[1];
          puVar4 = (uint64 *)Quaternion.Inverse(&local_38,&local_48,0);
          local_38 = *puVar4;
          uStack_30 = puVar4[1];
          puVar4 = (uint64 *)Quaternion.op_Multiply(&local_48,&local_38,&local_58,0);
          local_58 = *puVar4;
          switch(pivot) {
          case 0:
            break;
          case 1:
            break;
          case 2:
            break;
          case 3:
            break;
          default:
            goto switchD_180b039e6_caseD_4;
          case 5:
            break;
          case 6:
            break;
          case 7:
            break;
          case 8:
          }
        }
        NGUIMath.AdjustWidget(w);
        switchD_180b039e6_caseD_4:
    }

    // Token : 0x600037F
    // RVA   : 0xB010D0   Offset: 0xAFF8D0   Length: 0x46
    public static void AdjustWidget(UIWidget w, float left, float bottom, float right, float top)
    {
        ulong uVar1;
        ulong uVar2;
        float fVar3;
        float fVar4;
        long lVar5;
        bool cVar6;
        uint uVar7;
        uint uVar8;
        uint uVar9;
        uint uVar10;
        uint uVar11;
        uint uVar12;
        ulong uVar14;
        float fVar15;
        float fVar16;
        float fVar17;
        float fVar18;
        uint local_res8;
        float in_stack_00000028;
        uint in_stack_00000030;
        uint in_stack_00000038;
        uint in_stack_00000040;
        uint in_stack_00000048;
        float local_168;
        float fStack_164;
        float fStack_160;
        ulong local_158;
        ulong local_148;
        ulong uStack_140;
        ulong local_138;
        float local_130;
        ulong local_128;
        ulong uStack_120;
        ulong local_118;
        ulong uStack_110;
        ulong local_108;
        ulong local_f8;
        ulong local_e8;
        float local_e0;
        ulong local_d8;
        long local_c8;
        if (w != (int64 *)0) {
          local_128 = UIWidget.get_pivotOffset(w,0);
          local_c8 = UIRect.get_cachedTransform(w,0);
          if (local_c8 != 0) {
            puVar13 = (uint64 *)Transform.get_localRotation(&local_148,local_c8,0);
            uVar14 = *puVar13;
            uVar2 = puVar13[1];
            uVar7 = Mathf.FloorToInt();
            uVar8 = Mathf.FloorToInt();
            uVar9 = Mathf.FloorToInt();
            local_res8 = Mathf.FloorToInt(in_stack_00000028 + 0.5,0);
            fVar3 = (float)local_128;
            if (((float)local_128 == 0.5) && ((uVar7 == 0 || (uVar9 == 0)))) {
              uVar7 = uVar7 & 0xfffffffe;
              uVar9 = uVar9 & 0xfffffffe;
            }
            fVar4 = local_128._4_4_;
            if ((local_128._4_4_ == null.5) && ((uVar8 == 0 || (local_res8 == 0)))) {
              uVar8 = uVar8 & 0xfffffffe;
              local_res8 = local_res8 & 0xfffffffe;
            }
            fVar16 = (float)(int)uVar7;
            fStack_160 = 0.0;
            fVar18 = (float)(int)local_res8;
            local_168 = fVar16;
            fStack_164 = fVar18;
            local_148 = uVar14;
            uStack_140 = uVar2;
            puVar13 = (uint64 *)Quaternion.op_Multiply(&local_138,&local_148,&local_168,0);
            fVar15 = (float)(int)uVar9;
            fStack_160 = 0.0;
            local_d8 = *puVar13;
            local_168 = fVar15;
            fStack_164 = fVar18;
            local_148 = uVar14;
            uStack_140 = uVar2;
            puVar13 = (uint64 *)Quaternion.op_Multiply(&local_e8,&local_148,&local_168,0);
            fVar17 = (float)(int)uVar8;
            fStack_160 = 0.0;
            local_138 = *puVar13;
            local_130 = *(float *)(puVar13 + 1);
            local_168 = fVar16;
            fStack_164 = fVar17;
            local_148 = uVar14;
            uStack_140 = uVar2;
            puVar13 = (uint64 *)Quaternion.op_Multiply(&local_118,&local_148,&local_168,0);
            fStack_160 = 0.0;
            local_e8 = *puVar13;
            local_e0 = *(float *)(puVar13 + 1);
            local_168 = fVar15;
            fStack_164 = fVar17;
            local_148 = uVar14;
            uStack_140 = uVar2;
            puVar13 = (uint64 *)Quaternion.op_Multiply(&local_158,&local_148,&local_168,0);
            fStack_164 = 0.0;
            fStack_160 = 0.0;
            local_118 = *puVar13;
            uStack_110 = CONCAT44(uStack_110._4_4_,*(uint32 *)(puVar13 + 1));
            local_168 = fVar16;
            local_148 = uVar14;
            uStack_140 = uVar2;
            puVar13 = (uint64 *)Quaternion.op_Multiply(&local_158,&local_148,&local_168,0);
            fStack_164 = 0.0;
            fStack_160 = 0.0;
            local_f8 = *puVar13;
            local_168 = fVar15;
            local_148 = uVar14;
            uStack_140 = uVar2;
            puVar13 = (uint64 *)Quaternion.op_Multiply(&local_108,&local_148,&local_168,0);
            local_168 = 0.0;
            local_158 = *puVar13;
            fStack_160 = 0.0;
            fStack_164 = fVar18;
            local_148 = uVar14;
            uStack_140 = uVar2;
            puVar13 = (uint64 *)Quaternion.op_Multiply(&local_128,&local_148,&local_168,0);
            local_168 = 0.0;
            fStack_160 = 0.0;
            local_108 = *puVar13;
            fStack_164 = fVar17;
            local_128 = uVar14;
            uStack_120 = uVar2;
            puVar13 = (uint64 *)Quaternion.op_Multiply(&local_148,&local_128,&local_168,0);
            local_128 = *puVar13;
            puVar13 = (uint64 *)Vector3.get_zero(&local_148,0);
            fStack_160 = *(float *)(puVar13 + 1);
            local_168 = (float)*puVar13;
            fStack_164 = (float)((uint64)*puVar13 >> 32);
            if ((fVar3 == 0.0) && (fVar4 == 1.0)) {
              fVar15 = local_d8._4_4_;
              fVar16 = (float)local_d8;
            }
            else if ((fVar3 == 1.0) && (fVar4 == 0.0)) {
              fVar15 = local_118._4_4_;
              fVar16 = (float)local_118;
            }
            else if ((fVar3 == 0.0) && (fVar4 == 0.0)) {
              fVar15 = local_e8._4_4_;
              fVar16 = (float)local_e8;
            }
            else if ((fVar3 == 1.0) && (fVar4 == 1.0)) {
              fVar15 = local_138._4_4_;
              fVar16 = (float)local_138;
            }
            else if ((fVar3 == 0.0) && (fVar4 == 0.5)) {
              fVar16 = ((float)local_128 + (float)local_108) * 0.5 + (float)local_f8;
              fVar15 = (local_128._4_4_ + local_108._4_4_) * 0.5 + local_f8._4_4_;
            }
            else if ((fVar3 == 1.0) && (fVar4 == 0.5)) {
              fVar16 = ((float)local_128 + (float)local_108) * 0.5 + (float)local_158;
              fVar15 = (local_128._4_4_ + local_108._4_4_) * 0.5 + local_158._4_4_;
            }
            else {
              fVar15 = fStack_164;
              fVar16 = local_168;
              if (fVar3 == 0.5) {
                if (fVar4 == 1.0) {
                  fVar16 = ((float)local_158 + (float)local_f8) * 0.5 + (float)local_108;
                  fVar15 = (local_158._4_4_ + local_f8._4_4_) * 0.5 + local_108._4_4_;
                }
                else if (fVar4 == 0.0) {
                  fVar16 = ((float)local_158 + (float)local_f8) * 0.5 + (float)local_128;
                  fVar15 = (local_158._4_4_ + local_f8._4_4_) * 0.5 + local_128._4_4_;
                }
                else if (fVar4 == 0.5) {
                  fVar16 = ((float)local_158 + (float)local_f8 + (float)local_108 + (float)local_128) *
                           0.5;
                  fVar15 = (local_128._4_4_ + local_108._4_4_ + local_f8._4_4_ + local_158._4_4_) * 0.5;
                }
              }
            }
            uVar10 = (**(code **)(*w + 0x358))(w,*(uint64 *)(*w + 0x360));
            uVar11 = Mathf.Max(in_stack_00000030,uVar10,0);
            uVar10 = (**(code **)(*w + 0x368))(w,*(uint64 *)(*w + 0x370));
            uVar12 = Mathf.Max(in_stack_00000038,uVar10,0);
            uVar9 = (*(int *)((int64)w + 164) - uVar7) + uVar9;
            local_res8 = ((int)w[21] - uVar8) + local_res8;
            puVar13 = (uint64 *)Vector3.get_zero(&local_148,0);
            local_158 = *puVar13;
            uVar10 = *(uint32 *)(puVar13 + 1);
            if (((int)uVar9 < (int)uVar11) ||
               (uVar11 = in_stack_00000040, (int)in_stack_00000040 < (int)uVar9)) {
              uVar9 = uVar11;
              if (uVar7 == 0) {
                fVar17 = (float)Mathf.Lerp();
                local_158 = CONCAT44(local_158._4_4_,fVar17 + (float)local_158);
              }
              else {
                fVar17 = (float)Mathf.Lerp();
                local_158 = CONCAT44(local_158._4_4_,(float)local_158 - fVar17);
              }
            }
            if (((int)local_res8 < (int)uVar12) ||
               (uVar12 = in_stack_00000048, (int)in_stack_00000048 < (int)local_res8)) {
              local_res8 = uVar12;
              if (uVar8 == 0) {
                fVar17 = (float)Mathf.Lerp();
                local_158 = CONCAT44(fVar17 + local_158._4_4_,(float)local_158);
              }
              else {
                fVar17 = (float)Mathf.Lerp();
                local_158 = CONCAT44(local_158._4_4_ - fVar17,(float)local_158);
              }
            }
            lVar5 = local_c8;
            if (fVar3 == 0.5) {
              uVar9 = uVar9 & 0xfffffffe;
            }
            if (fVar4 == 0.5) {
              local_res8 = local_res8 & 0xfffffffe;
            }
            puVar13 = (uint64 *)Transform.get_localPosition(&local_148,local_c8,0);
            local_e0 = *(float *)(puVar13 + 1);
            uVar1 = *puVar13;
            local_138 = local_158;
            local_130 = (float)uVar10;
            local_118 = uVar14;
            uStack_110 = uVar2;
            puVar13 = (uint64 *)Quaternion.op_Multiply(&local_148,&local_118,&local_138,0);
            fVar16 = (float)uVar1 + fVar16 + (float)*puVar13;
            fVar15 = (float)((uint64)uVar1 >> 32) + fVar15 + (float)((uint64)*puVar13 >> 32);
            local_130 = fStack_160 + local_e0 + *(float *)(puVar13 + 1);
            local_138 = CONCAT44(fVar15,fVar16);
            local_e0 = local_130;
            Transform.set_localPosition(lVar5,&local_138,0);
            UIWidget.SetDimensions(w,uVar9,local_res8,0);
            cVar6 = UIRect.get_isAnchored(w,0);
            if (!cVar6) {
              return;
            }
            uVar14 = FUN_180da0f00(lVar5,0);
            fVar16 = fVar16 - fVar3 * (float)(int)uVar9;
            fVar15 = fVar15 - fVar4 * (float)(int)local_res8;
            if (w[3] != 0) {
              uVar2 = *(uint64 *)(w[3] + 16);
              cVar6 = Object.op_Implicit(uVar2,0);
              if (cVar6) {
                if (w[3] == 0) throw; // [null/range check failed]
                AnchorPoint.SetHorizontal(w[3],uVar14,fVar16,0);
              }
              if (w[4] != 0) {
                uVar2 = *(uint64 *)(w[4] + 16);
                cVar6 = Object.op_Implicit(uVar2,0);
                if (cVar6) {
                  if (w[4] == 0) throw; // [null/range check failed]
                  AnchorPoint.SetHorizontal(w[4],uVar14,fVar16 + (float)(int)uVar9,0);
                }
                if (w[5] != 0) {
                  uVar2 = *(uint64 *)(w[5] + 16);
                  cVar6 = Object.op_Implicit(uVar2,0);
                  if (cVar6) {
                    if (w[5] == 0) throw; // [null/range check failed]
                    AnchorPoint.SetVertical(w[5],uVar14,fVar15,0);
                  }
                  if (w[6] != 0) {
                    uVar2 = *(uint64 *)(w[6] + 16);
                    cVar6 = Object.op_Implicit(uVar2,0);
                    if (cVar6) {
                      if (w[6] == 0) throw; // [null/range check failed]
                      AnchorPoint.SetVertical(w[6],uVar14,fVar15 + (float)(int)local_res8,0);
                    }
                    return;
                  }
                }
              }
            }
          }
        }
    }

    // Token : 0x6000380
    // RVA   : 0xB01080   Offset: 0xAFF880   Length: 0x4C
    public static void AdjustWidget(UIWidget w, float left, float bottom, float right, float top, int minWidth, int minHeight)
    {
        ulong uVar1;
        ulong uVar2;
        float fVar3;
        float fVar4;
        long lVar5;
        bool cVar6;
        uint uVar7;
        uint uVar8;
        uint uVar9;
        uint uVar10;
        uint uVar11;
        uint uVar12;
        ulong uVar14;
        float fVar15;
        float fVar16;
        float fVar17;
        float fVar18;
        uint local_res8;
        float in_stack_00000028;
        uint in_stack_00000030;
        uint in_stack_00000038;
        uint in_stack_00000040;
        uint in_stack_00000048;
        float local_168;
        float fStack_164;
        float fStack_160;
        ulong local_158;
        ulong local_148;
        ulong uStack_140;
        ulong local_138;
        float local_130;
        ulong local_128;
        ulong uStack_120;
        ulong local_118;
        ulong uStack_110;
        ulong local_108;
        ulong local_f8;
        ulong local_e8;
        float local_e0;
        ulong local_d8;
        long local_c8;
        if (w != (int64 *)0) {
          local_128 = UIWidget.get_pivotOffset(w,0);
          local_c8 = UIRect.get_cachedTransform(w,0);
          if (local_c8 != 0) {
            puVar13 = (uint64 *)Transform.get_localRotation(&local_148,local_c8,0);
            uVar14 = *puVar13;
            uVar2 = puVar13[1];
            uVar7 = Mathf.FloorToInt();
            uVar8 = Mathf.FloorToInt();
            uVar9 = Mathf.FloorToInt();
            local_res8 = Mathf.FloorToInt(in_stack_00000028 + 0.5,0);
            fVar3 = (float)local_128;
            if (((float)local_128 == 0.5) && ((uVar7 == 0 || (uVar9 == 0)))) {
              uVar7 = uVar7 & 0xfffffffe;
              uVar9 = uVar9 & 0xfffffffe;
            }
            fVar4 = local_128._4_4_;
            if ((local_128._4_4_ == null.5) && ((uVar8 == 0 || (local_res8 == 0)))) {
              uVar8 = uVar8 & 0xfffffffe;
              local_res8 = local_res8 & 0xfffffffe;
            }
            fVar16 = (float)(int)uVar7;
            fStack_160 = 0.0;
            fVar18 = (float)(int)local_res8;
            local_168 = fVar16;
            fStack_164 = fVar18;
            local_148 = uVar14;
            uStack_140 = uVar2;
            puVar13 = (uint64 *)Quaternion.op_Multiply(&local_138,&local_148,&local_168,0);
            fVar15 = (float)(int)uVar9;
            fStack_160 = 0.0;
            local_d8 = *puVar13;
            local_168 = fVar15;
            fStack_164 = fVar18;
            local_148 = uVar14;
            uStack_140 = uVar2;
            puVar13 = (uint64 *)Quaternion.op_Multiply(&local_e8,&local_148,&local_168,0);
            fVar17 = (float)(int)uVar8;
            fStack_160 = 0.0;
            local_138 = *puVar13;
            local_130 = *(float *)(puVar13 + 1);
            local_168 = fVar16;
            fStack_164 = fVar17;
            local_148 = uVar14;
            uStack_140 = uVar2;
            puVar13 = (uint64 *)Quaternion.op_Multiply(&local_118,&local_148,&local_168,0);
            fStack_160 = 0.0;
            local_e8 = *puVar13;
            local_e0 = *(float *)(puVar13 + 1);
            local_168 = fVar15;
            fStack_164 = fVar17;
            local_148 = uVar14;
            uStack_140 = uVar2;
            puVar13 = (uint64 *)Quaternion.op_Multiply(&local_158,&local_148,&local_168,0);
            fStack_164 = 0.0;
            fStack_160 = 0.0;
            local_118 = *puVar13;
            uStack_110 = CONCAT44(uStack_110._4_4_,*(uint32 *)(puVar13 + 1));
            local_168 = fVar16;
            local_148 = uVar14;
            uStack_140 = uVar2;
            puVar13 = (uint64 *)Quaternion.op_Multiply(&local_158,&local_148,&local_168,0);
            fStack_164 = 0.0;
            fStack_160 = 0.0;
            local_f8 = *puVar13;
            local_168 = fVar15;
            local_148 = uVar14;
            uStack_140 = uVar2;
            puVar13 = (uint64 *)Quaternion.op_Multiply(&local_108,&local_148,&local_168,0);
            local_168 = 0.0;
            local_158 = *puVar13;
            fStack_160 = 0.0;
            fStack_164 = fVar18;
            local_148 = uVar14;
            uStack_140 = uVar2;
            puVar13 = (uint64 *)Quaternion.op_Multiply(&local_128,&local_148,&local_168,0);
            local_168 = 0.0;
            fStack_160 = 0.0;
            local_108 = *puVar13;
            fStack_164 = fVar17;
            local_128 = uVar14;
            uStack_120 = uVar2;
            puVar13 = (uint64 *)Quaternion.op_Multiply(&local_148,&local_128,&local_168,0);
            local_128 = *puVar13;
            puVar13 = (uint64 *)Vector3.get_zero(&local_148,0);
            fStack_160 = *(float *)(puVar13 + 1);
            local_168 = (float)*puVar13;
            fStack_164 = (float)((uint64)*puVar13 >> 32);
            if ((fVar3 == 0.0) && (fVar4 == 1.0)) {
              fVar15 = local_d8._4_4_;
              fVar16 = (float)local_d8;
            }
            else if ((fVar3 == 1.0) && (fVar4 == 0.0)) {
              fVar15 = local_118._4_4_;
              fVar16 = (float)local_118;
            }
            else if ((fVar3 == 0.0) && (fVar4 == 0.0)) {
              fVar15 = local_e8._4_4_;
              fVar16 = (float)local_e8;
            }
            else if ((fVar3 == 1.0) && (fVar4 == 1.0)) {
              fVar15 = local_138._4_4_;
              fVar16 = (float)local_138;
            }
            else if ((fVar3 == 0.0) && (fVar4 == 0.5)) {
              fVar16 = ((float)local_128 + (float)local_108) * 0.5 + (float)local_f8;
              fVar15 = (local_128._4_4_ + local_108._4_4_) * 0.5 + local_f8._4_4_;
            }
            else if ((fVar3 == 1.0) && (fVar4 == 0.5)) {
              fVar16 = ((float)local_128 + (float)local_108) * 0.5 + (float)local_158;
              fVar15 = (local_128._4_4_ + local_108._4_4_) * 0.5 + local_158._4_4_;
            }
            else {
              fVar15 = fStack_164;
              fVar16 = local_168;
              if (fVar3 == 0.5) {
                if (fVar4 == 1.0) {
                  fVar16 = ((float)local_158 + (float)local_f8) * 0.5 + (float)local_108;
                  fVar15 = (local_158._4_4_ + local_f8._4_4_) * 0.5 + local_108._4_4_;
                }
                else if (fVar4 == 0.0) {
                  fVar16 = ((float)local_158 + (float)local_f8) * 0.5 + (float)local_128;
                  fVar15 = (local_158._4_4_ + local_f8._4_4_) * 0.5 + local_128._4_4_;
                }
                else if (fVar4 == 0.5) {
                  fVar16 = ((float)local_158 + (float)local_f8 + (float)local_108 + (float)local_128) *
                           0.5;
                  fVar15 = (local_128._4_4_ + local_108._4_4_ + local_f8._4_4_ + local_158._4_4_) * 0.5;
                }
              }
            }
            uVar10 = (**(code **)(*w + 0x358))(w,*(uint64 *)(*w + 0x360));
            uVar11 = Mathf.Max(in_stack_00000030,uVar10,0);
            uVar10 = (**(code **)(*w + 0x368))(w,*(uint64 *)(*w + 0x370));
            uVar12 = Mathf.Max(in_stack_00000038,uVar10,0);
            uVar9 = (*(int *)((int64)w + 164) - uVar7) + uVar9;
            local_res8 = ((int)w[21] - uVar8) + local_res8;
            puVar13 = (uint64 *)Vector3.get_zero(&local_148,0);
            local_158 = *puVar13;
            uVar10 = *(uint32 *)(puVar13 + 1);
            if (((int)uVar9 < (int)uVar11) ||
               (uVar11 = in_stack_00000040, (int)in_stack_00000040 < (int)uVar9)) {
              uVar9 = uVar11;
              if (uVar7 == 0) {
                fVar17 = (float)Mathf.Lerp();
                local_158 = CONCAT44(local_158._4_4_,fVar17 + (float)local_158);
              }
              else {
                fVar17 = (float)Mathf.Lerp();
                local_158 = CONCAT44(local_158._4_4_,(float)local_158 - fVar17);
              }
            }
            if (((int)local_res8 < (int)uVar12) ||
               (uVar12 = in_stack_00000048, (int)in_stack_00000048 < (int)local_res8)) {
              local_res8 = uVar12;
              if (uVar8 == 0) {
                fVar17 = (float)Mathf.Lerp();
                local_158 = CONCAT44(fVar17 + local_158._4_4_,(float)local_158);
              }
              else {
                fVar17 = (float)Mathf.Lerp();
                local_158 = CONCAT44(local_158._4_4_ - fVar17,(float)local_158);
              }
            }
            lVar5 = local_c8;
            if (fVar3 == 0.5) {
              uVar9 = uVar9 & 0xfffffffe;
            }
            if (fVar4 == 0.5) {
              local_res8 = local_res8 & 0xfffffffe;
            }
            puVar13 = (uint64 *)Transform.get_localPosition(&local_148,local_c8,0);
            local_e0 = *(float *)(puVar13 + 1);
            uVar1 = *puVar13;
            local_138 = local_158;
            local_130 = (float)uVar10;
            local_118 = uVar14;
            uStack_110 = uVar2;
            puVar13 = (uint64 *)Quaternion.op_Multiply(&local_148,&local_118,&local_138,0);
            fVar16 = (float)uVar1 + fVar16 + (float)*puVar13;
            fVar15 = (float)((uint64)uVar1 >> 32) + fVar15 + (float)((uint64)*puVar13 >> 32);
            local_130 = fStack_160 + local_e0 + *(float *)(puVar13 + 1);
            local_138 = CONCAT44(fVar15,fVar16);
            local_e0 = local_130;
            Transform.set_localPosition(lVar5,&local_138,0);
            UIWidget.SetDimensions(w,uVar9,local_res8,0);
            cVar6 = UIRect.get_isAnchored(w,0);
            if (!cVar6) {
              return;
            }
            uVar14 = FUN_180da0f00(lVar5,0);
            fVar16 = fVar16 - fVar3 * (float)(int)uVar9;
            fVar15 = fVar15 - fVar4 * (float)(int)local_res8;
            if (w[3] != 0) {
              uVar2 = *(uint64 *)(w[3] + 16);
              cVar6 = Object.op_Implicit(uVar2,0);
              if (cVar6) {
                if (w[3] == 0) throw; // [null/range check failed]
                AnchorPoint.SetHorizontal(w[3],uVar14,fVar16,0);
              }
              if (w[4] != 0) {
                uVar2 = *(uint64 *)(w[4] + 16);
                cVar6 = Object.op_Implicit(uVar2,0);
                if (cVar6) {
                  if (w[4] == 0) throw; // [null/range check failed]
                  AnchorPoint.SetHorizontal(w[4],uVar14,fVar16 + (float)(int)uVar9,0);
                }
                if (w[5] != 0) {
                  uVar2 = *(uint64 *)(w[5] + 16);
                  cVar6 = Object.op_Implicit(uVar2,0);
                  if (cVar6) {
                    if (w[5] == 0) throw; // [null/range check failed]
                    AnchorPoint.SetVertical(w[5],uVar14,fVar15,0);
                  }
                  if (w[6] != 0) {
                    uVar2 = *(uint64 *)(w[6] + 16);
                    cVar6 = Object.op_Implicit(uVar2,0);
                    if (cVar6) {
                      if (w[6] == 0) throw; // [null/range check failed]
                      AnchorPoint.SetVertical(w[6],uVar14,fVar15 + (float)(int)local_res8,0);
                    }
                    return;
                  }
                }
              }
            }
          }
        }
    }

    // Token : 0x6000381
    // RVA   : 0xB00670   Offset: 0xAFEE70   Length: 0xA07
    public static void AdjustWidget(UIWidget w, float left, float bottom, float right, float top, int minWidth, int minHeight, int maxWidth, int maxHeight)
    {
        ulong uVar1;
        ulong uVar2;
        float fVar3;
        float fVar4;
        long lVar5;
        bool cVar6;
        uint uVar7;
        uint uVar8;
        uint uVar9;
        uint uVar10;
        uint uVar11;
        uint uVar12;
        ulong uVar14;
        float fVar15;
        float fVar16;
        float fVar17;
        float fVar18;
        uint local_res8;
        float in_stack_00000028;
        uint in_stack_00000030;
        uint in_stack_00000038;
        uint in_stack_00000040;
        uint in_stack_00000048;
        float local_168;
        float fStack_164;
        float fStack_160;
        ulong local_158;
        ulong local_148;
        ulong uStack_140;
        ulong local_138;
        float local_130;
        ulong local_128;
        ulong uStack_120;
        ulong local_118;
        ulong uStack_110;
        ulong local_108;
        ulong local_f8;
        ulong local_e8;
        float local_e0;
        ulong local_d8;
        long local_c8;
        if (w != (int64 *)0) {
          local_128 = UIWidget.get_pivotOffset(w,0);
          local_c8 = UIRect.get_cachedTransform(w,0);
          if (local_c8 != 0) {
            puVar13 = (uint64 *)Transform.get_localRotation(&local_148,local_c8,0);
            uVar14 = *puVar13;
            uVar2 = puVar13[1];
            uVar7 = Mathf.FloorToInt();
            uVar8 = Mathf.FloorToInt();
            uVar9 = Mathf.FloorToInt();
            local_res8 = Mathf.FloorToInt(in_stack_00000028 + 0.5,0);
            fVar3 = (float)local_128;
            if (((float)local_128 == 0.5) && ((uVar7 == 0 || (uVar9 == 0)))) {
              uVar7 = uVar7 & 0xfffffffe;
              uVar9 = uVar9 & 0xfffffffe;
            }
            fVar4 = local_128._4_4_;
            if ((local_128._4_4_ == null.5) && ((uVar8 == 0 || (local_res8 == 0)))) {
              uVar8 = uVar8 & 0xfffffffe;
              local_res8 = local_res8 & 0xfffffffe;
            }
            fVar16 = (float)(int)uVar7;
            fStack_160 = 0.0;
            fVar18 = (float)(int)local_res8;
            local_168 = fVar16;
            fStack_164 = fVar18;
            local_148 = uVar14;
            uStack_140 = uVar2;
            puVar13 = (uint64 *)Quaternion.op_Multiply(&local_138,&local_148,&local_168,0);
            fVar15 = (float)(int)uVar9;
            fStack_160 = 0.0;
            local_d8 = *puVar13;
            local_168 = fVar15;
            fStack_164 = fVar18;
            local_148 = uVar14;
            uStack_140 = uVar2;
            puVar13 = (uint64 *)Quaternion.op_Multiply(&local_e8,&local_148,&local_168,0);
            fVar17 = (float)(int)uVar8;
            fStack_160 = 0.0;
            local_138 = *puVar13;
            local_130 = *(float *)(puVar13 + 1);
            local_168 = fVar16;
            fStack_164 = fVar17;
            local_148 = uVar14;
            uStack_140 = uVar2;
            puVar13 = (uint64 *)Quaternion.op_Multiply(&local_118,&local_148,&local_168,0);
            fStack_160 = 0.0;
            local_e8 = *puVar13;
            local_e0 = *(float *)(puVar13 + 1);
            local_168 = fVar15;
            fStack_164 = fVar17;
            local_148 = uVar14;
            uStack_140 = uVar2;
            puVar13 = (uint64 *)Quaternion.op_Multiply(&local_158,&local_148,&local_168,0);
            fStack_164 = 0.0;
            fStack_160 = 0.0;
            local_118 = *puVar13;
            uStack_110 = CONCAT44(uStack_110._4_4_,*(uint32 *)(puVar13 + 1));
            local_168 = fVar16;
            local_148 = uVar14;
            uStack_140 = uVar2;
            puVar13 = (uint64 *)Quaternion.op_Multiply(&local_158,&local_148,&local_168,0);
            fStack_164 = 0.0;
            fStack_160 = 0.0;
            local_f8 = *puVar13;
            local_168 = fVar15;
            local_148 = uVar14;
            uStack_140 = uVar2;
            puVar13 = (uint64 *)Quaternion.op_Multiply(&local_108,&local_148,&local_168,0);
            local_168 = 0.0;
            local_158 = *puVar13;
            fStack_160 = 0.0;
            fStack_164 = fVar18;
            local_148 = uVar14;
            uStack_140 = uVar2;
            puVar13 = (uint64 *)Quaternion.op_Multiply(&local_128,&local_148,&local_168,0);
            local_168 = 0.0;
            fStack_160 = 0.0;
            local_108 = *puVar13;
            fStack_164 = fVar17;
            local_128 = uVar14;
            uStack_120 = uVar2;
            puVar13 = (uint64 *)Quaternion.op_Multiply(&local_148,&local_128,&local_168,0);
            local_128 = *puVar13;
            puVar13 = (uint64 *)Vector3.get_zero(&local_148,0);
            fStack_160 = *(float *)(puVar13 + 1);
            local_168 = (float)*puVar13;
            fStack_164 = (float)((uint64)*puVar13 >> 32);
            if ((fVar3 == 0.0) && (fVar4 == 1.0)) {
              fVar15 = local_d8._4_4_;
              fVar16 = (float)local_d8;
            }
            else if ((fVar3 == 1.0) && (fVar4 == 0.0)) {
              fVar15 = local_118._4_4_;
              fVar16 = (float)local_118;
            }
            else if ((fVar3 == 0.0) && (fVar4 == 0.0)) {
              fVar15 = local_e8._4_4_;
              fVar16 = (float)local_e8;
            }
            else if ((fVar3 == 1.0) && (fVar4 == 1.0)) {
              fVar15 = local_138._4_4_;
              fVar16 = (float)local_138;
            }
            else if ((fVar3 == 0.0) && (fVar4 == 0.5)) {
              fVar16 = ((float)local_128 + (float)local_108) * 0.5 + (float)local_f8;
              fVar15 = (local_128._4_4_ + local_108._4_4_) * 0.5 + local_f8._4_4_;
            }
            else if ((fVar3 == 1.0) && (fVar4 == 0.5)) {
              fVar16 = ((float)local_128 + (float)local_108) * 0.5 + (float)local_158;
              fVar15 = (local_128._4_4_ + local_108._4_4_) * 0.5 + local_158._4_4_;
            }
            else {
              fVar15 = fStack_164;
              fVar16 = local_168;
              if (fVar3 == 0.5) {
                if (fVar4 == 1.0) {
                  fVar16 = ((float)local_158 + (float)local_f8) * 0.5 + (float)local_108;
                  fVar15 = (local_158._4_4_ + local_f8._4_4_) * 0.5 + local_108._4_4_;
                }
                else if (fVar4 == 0.0) {
                  fVar16 = ((float)local_158 + (float)local_f8) * 0.5 + (float)local_128;
                  fVar15 = (local_158._4_4_ + local_f8._4_4_) * 0.5 + local_128._4_4_;
                }
                else if (fVar4 == 0.5) {
                  fVar16 = ((float)local_158 + (float)local_f8 + (float)local_108 + (float)local_128) *
                           0.5;
                  fVar15 = (local_128._4_4_ + local_108._4_4_ + local_f8._4_4_ + local_158._4_4_) * 0.5;
                }
              }
            }
            uVar10 = (**(code **)(*w + 0x358))(w,*(uint64 *)(*w + 0x360));
            uVar11 = Mathf.Max(in_stack_00000030,uVar10,0);
            uVar10 = (**(code **)(*w + 0x368))(w,*(uint64 *)(*w + 0x370));
            uVar12 = Mathf.Max(in_stack_00000038,uVar10,0);
            uVar9 = (*(int *)((int64)w + 164) - uVar7) + uVar9;
            local_res8 = ((int)w[21] - uVar8) + local_res8;
            puVar13 = (uint64 *)Vector3.get_zero(&local_148,0);
            local_158 = *puVar13;
            uVar10 = *(uint32 *)(puVar13 + 1);
            if (((int)uVar9 < (int)uVar11) ||
               (uVar11 = in_stack_00000040, (int)in_stack_00000040 < (int)uVar9)) {
              uVar9 = uVar11;
              if (uVar7 == 0) {
                fVar17 = (float)Mathf.Lerp();
                local_158 = CONCAT44(local_158._4_4_,fVar17 + (float)local_158);
              }
              else {
                fVar17 = (float)Mathf.Lerp();
                local_158 = CONCAT44(local_158._4_4_,(float)local_158 - fVar17);
              }
            }
            if (((int)local_res8 < (int)uVar12) ||
               (uVar12 = in_stack_00000048, (int)in_stack_00000048 < (int)local_res8)) {
              local_res8 = uVar12;
              if (uVar8 == 0) {
                fVar17 = (float)Mathf.Lerp();
                local_158 = CONCAT44(fVar17 + local_158._4_4_,(float)local_158);
              }
              else {
                fVar17 = (float)Mathf.Lerp();
                local_158 = CONCAT44(local_158._4_4_ - fVar17,(float)local_158);
              }
            }
            lVar5 = local_c8;
            if (fVar3 == 0.5) {
              uVar9 = uVar9 & 0xfffffffe;
            }
            if (fVar4 == 0.5) {
              local_res8 = local_res8 & 0xfffffffe;
            }
            puVar13 = (uint64 *)Transform.get_localPosition(&local_148,local_c8,0);
            local_e0 = *(float *)(puVar13 + 1);
            uVar1 = *puVar13;
            local_138 = local_158;
            local_130 = (float)uVar10;
            local_118 = uVar14;
            uStack_110 = uVar2;
            puVar13 = (uint64 *)Quaternion.op_Multiply(&local_148,&local_118,&local_138,0);
            fVar16 = (float)uVar1 + fVar16 + (float)*puVar13;
            fVar15 = (float)((uint64)uVar1 >> 32) + fVar15 + (float)((uint64)*puVar13 >> 32);
            local_130 = fStack_160 + local_e0 + *(float *)(puVar13 + 1);
            local_138 = CONCAT44(fVar15,fVar16);
            local_e0 = local_130;
            Transform.set_localPosition(lVar5,&local_138,0);
            UIWidget.SetDimensions(w,uVar9,local_res8,0);
            cVar6 = UIRect.get_isAnchored(w,0);
            if (!cVar6) {
              return;
            }
            uVar14 = FUN_180da0f00(lVar5,0);
            fVar16 = fVar16 - fVar3 * (float)(int)uVar9;
            fVar15 = fVar15 - fVar4 * (float)(int)local_res8;
            if (w[3] != 0) {
              uVar2 = *(uint64 *)(w[3] + 16);
              cVar6 = Object.op_Implicit(uVar2,0);
              if (cVar6) {
                if (w[3] == 0) throw; // [null/range check failed]
                AnchorPoint.SetHorizontal(w[3],uVar14,fVar16,0);
              }
              if (w[4] != 0) {
                uVar2 = *(uint64 *)(w[4] + 16);
                cVar6 = Object.op_Implicit(uVar2,0);
                if (cVar6) {
                  if (w[4] == 0) throw; // [null/range check failed]
                  AnchorPoint.SetHorizontal(w[4],uVar14,fVar16 + (float)(int)uVar9,0);
                }
                if (w[5] != 0) {
                  uVar2 = *(uint64 *)(w[5] + 16);
                  cVar6 = Object.op_Implicit(uVar2,0);
                  if (cVar6) {
                    if (w[5] == 0) throw; // [null/range check failed]
                    AnchorPoint.SetVertical(w[5],uVar14,fVar15,0);
                  }
                  if (w[6] != 0) {
                    uVar2 = *(uint64 *)(w[6] + 16);
                    cVar6 = Object.op_Implicit(uVar2,0);
                    if (cVar6) {
                      if (w[6] == 0) throw; // [null/range check failed]
                      AnchorPoint.SetVertical(w[6],uVar14,fVar15 + (float)(int)local_res8,0);
                    }
                    return;
                  }
                }
              }
            }
          }
        }
    }

    // Token : 0x6000382
    // RVA   : 0xB00600   Offset: 0xAFEE00   Length: 0x6F
    public static int AdjustByDPI(float height)
    {
        int iVar1;
        ulong uVar2;
        float fVar3;
        fVar3 = (float)Screen.get_dpi(0);
        iVar1 = Application.get_platform(0);
        if (fVar3 == 0.0) {
          if ((iVar1 == 11) || (iVar1 == 8)) {
            fVar3 = 160.0;
          }
          else {
            fVar3 = 96.0;
          }
        }
        uVar2 = Mathf.RoundToInt((96.0 / fVar3) * height,0);
        if ((uVar2 & 1) != 0) {
          uVar2 = (uint64)((int)uVar2 + 1);
        }
        return uVar2;
    }

    // Token : 0x6000383
    // RVA   : 0xB03FA0   Offset: 0xB027A0   Length: 0x1F2
    public static Vector2 ScreenToPixels(Vector2 pos, Transform relativeTo)
    {
        uint64
        NGUIMath.ScreenToPixels(uint64 pos,int64 relativeTo,uint64 param_3,uint64 param_4)
        {
        char cVar1;
        uint32 uVar2;
        int64 lVar3;
        uint64 *puVar4;
        uint64 uVar5;
        uint64 uVar6;
        uint32 local_res10 [2];
        uint32 local_40;
        uint32 uStack_3c;
        uint32 local_38;
        uint64 local_28;
        uint32 local_20;
        uVar6 = pos;
        if (relativeTo != null) {
          lVar3 = Component.get_gameObject(relativeTo,0);
          if (lVar3 != null) {
            uVar2 = GameObject.get_layer(lVar3,0);
            local_res10[0] = uVar2;
            lVar3 = NGUITools.FindCameraForLayer(uVar2,0);
            cVar1 = Object.op_Equality(lVar3,0,0);
            if (cVar1) {
              uVar5 = Int32.ToString(local_res10,0);
              uVar5 = String.Concat("No camera found for layer ",uVar5,0);
              Debug.LogWarning(uVar5,0);
              return uVar6;
            }
            local_40 = (uint32)pos;
            uStack_3c = (uint32)((uint64)pos >> 32);
            local_38 = 0;
            if (lVar3 != null) {
              local_20 = 0;
              local_28 = pos;
              puVar4 = (uint64 *)Camera.ScreenToWorldPoint(&local_40,lVar3,&local_28,0);
              local_28 = *puVar4;
              local_20 = *(uint32 *)(puVar4 + 1);
              puVar4 = (uint64 *)Transform.InverseTransformPoint(&local_40,relativeTo,&local_28,0);
              return *puVar4;
            }
          }
        }
    }

    // Token : 0x6000384
    // RVA   : 0xB03D10   Offset: 0xB02510   Length: 0x28E
    public static Vector2 ScreenToParentPixels(Vector2 pos, Transform relativeTo)
    {
        uint uVar1;
        bool cVar2;
        long lVar3;
        ulong uVar4;
        uint[] local_res10 = new uint[2];
        ulong local_50;
        uint local_48;
        ulong local_38;
        uint local_30;
        byte[] local_28 = new byte[32];
        if ((relativeTo != null) && (lVar3 = Component.get_gameObject(relativeTo,0)) != null) {
          local_res10[0] = GameObject.get_layer(lVar3,0);
          uVar4 = FUN_180da0f00(relativeTo,0);
          cVar2 = Object.op_Inequality(uVar4,0,0);
          if (cVar2) {
            relativeTo = FUN_180da0f00(relativeTo,0);
          }
          uVar1 = local_res10[0];
          lVar3 = NGUITools.FindCameraForLayer(uVar1,0);
          cVar2 = Object.op_Equality(lVar3,0,0);
          if (cVar2) {
            uVar4 = Int32.ToString(local_res10,0);
            uVar4 = String.Concat("No camera found for layer ",uVar4,0);
            Debug.LogWarning(uVar4,0);
            return pos;
          }
          local_48 = 0;
          local_50 = pos;
          if (lVar3 != null) {
            local_30 = 0;
            local_38 = pos;
            puVar5 = (uint64 *)Camera.ScreenToWorldPoint(&local_50,lVar3,&local_38,0);
            uVar4 = *puVar5;
            uVar1 = *(uint32 *)(puVar5 + 1);
            cVar2 = Object.op_Inequality(relativeTo,0,0);
            if (cVar2) {
              if (relativeTo == null) throw; // [null/range check failed]
              local_38 = uVar4;
              local_30 = uVar1;
              puVar5 = (uint64 *)Transform.InverseTransformPoint(local_28,relativeTo,&local_38,0);
              uVar4 = *puVar5;
            }
            local_50 = uVar4;
            return local_50;
          }
        }
    }

    // Token : 0x6000385
    // RVA   : 0xB04700   Offset: 0xB02F00   Length: 0x18F
    public static Vector3 WorldToLocalPoint(Vector3 worldPos, Camera worldCam, Camera uiCam, Transform relativeTo)
    {
        uint64 *
        NGUIMath.WorldToLocalPoint
                (uint64 *worldPos,uint64 *worldCam,int64 uiCam,int64 relativeTo,
                int64 param_5)
        {
        uint64 uVar1;
        byte bVar2;
        char cVar3;
        uint32 uVar4;
        uint64 *puVar5;
        int64 lVar6;
        uint64 local_28;
        uint32 local_20;
        uint8 local_18 [16];
        if (uiCam == null) {
        LAB_180b0488a:
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
        local_28 = *worldCam;
        local_20 = *(uint32 *)(worldCam + 1);
        puVar5 = (uint64 *)Camera.WorldToViewportPoint(local_18,uiCam,&local_28,0);
        uVar1 = *puVar5;
        uVar4 = *(uint32 *)(puVar5 + 1);
        *worldCam = uVar1;
        *(uint32 *)(worldCam + 1) = uVar4;
        if (relativeTo == null) goto LAB_180b0488a;
        local_28 = uVar1;
        local_20 = uVar4;
        puVar5 = (uint64 *)Camera.ViewportToWorldPoint(local_18,relativeTo,&local_28,0);
        lVar6 = DAT_181d68fe8;
        bVar2 = *(byte *)(DAT_181d68fe8 + 0x133);
        uVar4 = *(uint32 *)(puVar5 + 1);
        *worldCam = *puVar5;
        *(uint32 *)(worldCam + 1) = uVar4;
        if (((bVar2 & 4) != 0) && (*(int *)(lVar6 + 224) == 0)) {
          il2cpp_runtime_class_init();
        }
        cVar3 = Object.op_Equality(param_5,0,0);
        if (!cVar3) {
          if (param_5 == 0) goto LAB_180b0488a;
          lVar6 = FUN_180da0f00(param_5,0);
          cVar3 = Object.op_Equality(lVar6,0,0);
          if (!cVar3) {
            if (lVar6 == null) goto LAB_180b0488a;
            local_28 = *worldCam;
            local_20 = *(uint32 *)(worldCam + 1);
            puVar5 = (uint64 *)Transform.InverseTransformPoint(local_18,lVar6,&local_28,0);
            uVar4 = *(uint32 *)(puVar5 + 1);
            *worldPos = *puVar5;
            goto LAB_180b04862;
          }
        }
        uVar4 = *(uint32 *)(worldCam + 1);
        *worldPos = *worldCam;
        LAB_180b04862:
        *(uint32 *)(worldPos + 1) = uVar4;
        return worldPos;
    }

    // Token : 0x6000386
    // RVA   : 0xB03740   Offset: 0xB01F40   Length: 0x163
    public static void OverlayPosition(Transform trans, Vector3 worldPos, Camera worldCam, Camera myCam)
    {
        bool cVar1;
        uint uVar2;
        long lVar3;
        ulong uVar4;
        ulong uVar5;
        ulong local_28;
        uint local_20;
        byte[] local_18 = new byte[16];
        if (trans != null) {
          lVar3 = Component.get_gameObject(trans,0);
          if (lVar3 != null) {
            uVar2 = GameObject.get_layer(lVar3,0);
            uVar4 = NGUITools.FindCameraForLayer(uVar2,0);
            if (worldPos != null) {
              lVar3 = Component.get_gameObject(worldPos,0);
              if (lVar3 != null) {
                uVar2 = GameObject.get_layer(lVar3,0);
                uVar5 = NGUITools.FindCameraForLayer(uVar2,0);
                cVar1 = Object.op_Inequality(uVar4,0,0);
                if (cVar1) {
                  cVar1 = Object.op_Inequality(uVar5,0,0);
                  if (cVar1) {
                    puVar6 = (uint64 *)Transform.get_position(local_18,worldPos,0);
                    local_28 = *puVar6;
                    local_20 = *(uint32 *)(puVar6 + 1);
                    NGUIMath.OverlayPosition(trans,&local_28,uVar5,uVar4,0);
                  }
                }
                return;
              }
            }
          }
        }
    }

    // Token : 0x6000387
    // RVA   : 0xB034B0   Offset: 0xB01CB0   Length: 0x10D
    public static void OverlayPosition(Transform trans, Vector3 worldPos, Camera worldCam)
    {
        bool cVar1;
        uint uVar2;
        long lVar3;
        ulong uVar4;
        ulong uVar5;
        ulong local_28;
        uint local_20;
        byte[] local_18 = new byte[16];
        if (trans != null) {
          lVar3 = Component.get_gameObject(trans,0);
          if (lVar3 != null) {
            uVar2 = GameObject.get_layer(lVar3,0);
            uVar4 = NGUITools.FindCameraForLayer(uVar2,0);
            if (worldPos != null) {
              lVar3 = Component.get_gameObject(worldPos,0);
              if (lVar3 != null) {
                uVar2 = GameObject.get_layer(lVar3,0);
                uVar5 = NGUITools.FindCameraForLayer(uVar2,0);
                cVar1 = Object.op_Inequality(uVar4,0,0);
                if (cVar1) {
                  cVar1 = Object.op_Inequality(uVar5,0,0);
                  if (cVar1) {
                    puVar6 = (uint64 *)Transform.get_position(local_18,worldPos,0);
                    local_28 = *puVar6;
                    local_20 = *(uint32 *)(puVar6 + 1);
                    NGUIMath.OverlayPosition(trans,&local_28,uVar5,uVar4,0);
                  }
                }
                return;
              }
            }
          }
        }
    }

    // Token : 0x6000388
    // RVA   : 0xB035C0   Offset: 0xB01DC0   Length: 0x17B
    public static void OverlayPosition(Transform trans, Transform target)
    {
        bool cVar1;
        uint uVar2;
        long lVar3;
        ulong uVar4;
        ulong uVar5;
        ulong local_28;
        uint local_20;
        byte[] local_18 = new byte[16];
        if (trans != null) {
          lVar3 = Component.get_gameObject(trans,0);
          if (lVar3 != null) {
            uVar2 = GameObject.get_layer(lVar3,0);
            uVar4 = NGUITools.FindCameraForLayer(uVar2,0);
            if (target != null) {
              lVar3 = Component.get_gameObject(target,0);
              if (lVar3 != null) {
                uVar2 = GameObject.get_layer(lVar3,0);
                uVar5 = NGUITools.FindCameraForLayer(uVar2,0);
                cVar1 = Object.op_Inequality(uVar4,0,0);
                if (cVar1) {
                  cVar1 = Object.op_Inequality(uVar5,0,0);
                  if (cVar1) {
                    puVar6 = (uint64 *)Transform.get_position(local_18,target,0);
                    local_28 = *puVar6;
                    local_20 = *(uint32 *)(puVar6 + 1);
                    NGUIMath.OverlayPosition(trans,&local_28,uVar5,uVar4,0);
                  }
                }
                return;
              }
            }
          }
        }
    }

}
