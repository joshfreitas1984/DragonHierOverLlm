// ============================================================
// Type  : BigMapSpeEffectController
// Token : 0x200019A
// ============================================================

public class BigMapSpeEffectController
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4000B36
    public BigMapSpeEffectType bigMapSpeEffectType;

    // Token: 0x4000B37
    public static List<string> bigMapSpeEffectTypeName;

    // Token: 0x4000B38
    public static List<string> bigMapSpeEffectTypeDescribe;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000D23
    // RVA   : 0x2110A0   Offset: 0x20FEA0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_180ae8740(this,0);
    }

    // Token : 0x6000D24
    // RVA   : 0x9E55D0   Offset: 0x9E43D0   Length: 0x1E4
    private static void /*cctor*/()
    {
        var pStatics = *(int64*)(DAT_181e90fe8 + 184);
        long lVar1;
        lVar1 = il2cpp_internal(DAT_181e77728);
        FUN_1810f3480(lVar1,DAT_181e861f0);
        if (lVar1 != null) {
          FUN_18175de30(lVar1,"旱",DAT_181e86370);
          FUN_18175de30(lVar1,"寒",DAT_181e86370);
          FUN_18175de30(lVar1,"瘴",DAT_181e86370);
          FUN_18175de30(lVar1,"毒",DAT_181e86370);
          plVar2 = pStatics;
          *plVar2 = lVar1;
          il2cpp_internal(plVar2,lVar1);
          lVar1 = il2cpp_internal(DAT_181e77728);
          FUN_1810f3480(lVar1,DAT_181e861f0);
          if (lVar1 != null) {
            FUN_18175de30(lVar1,"干旱区域\n缓慢减少生命",DAT_181e86370);
            FUN_18175de30(lVar1,"极寒区域\n缓慢减少内力",DAT_181e86370);
            FUN_18175de30(lVar1,"瘴气区域\n缓慢减少生命内力",DAT_181e86370);
            FUN_18175de30(lVar1,"毒雾区域\n缓慢积累中毒",DAT_181e86370);
            BigMapSpeEffectController.bigMapSpeEffectTypeDescribe = lVar1;
            return;
          }
        }
    }

}
