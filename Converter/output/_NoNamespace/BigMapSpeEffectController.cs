// ============================================================
// Type  : BigMapSpeEffectController
// Token : 0x2000192
// ============================================================

public class BigMapSpeEffectController
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4000A9E
    public BigMapSpeEffectType bigMapSpeEffectType;

    // Token: 0x4000A9F
    public static List<string> bigMapSpeEffectTypeName;

    // Token: 0x4000AA0
    public static List<string> bigMapSpeEffectTypeDescribe;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000CF3
    // RVA   : 0x3A17B0   Offset: 0x39FFB0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_18044ef50(this,0);
    }

    // Token : 0x6000CF4
    // RVA   : 0xCD6A00   Offset: 0xCD5200   Length: 0x1E4
    private static void /*cctor*/()
    {
        var pStatics = *(int64*)(DAT_181d8bc28 + 184);
        long lVar1;
        lVar1 = il2cpp_internal(DAT_181d72a30);
        FUN_180f58a90(lVar1,DAT_181d7c250);
        if (lVar1 != null) {
          FUN_181827900(lVar1,"旱",DAT_181d7c3d0);
          FUN_181827900(lVar1,"寒",DAT_181d7c3d0);
          FUN_181827900(lVar1,"瘴",DAT_181d7c3d0);
          FUN_181827900(lVar1,"毒",DAT_181d7c3d0);
          plVar2 = pStatics;
          *plVar2 = lVar1;
          il2cpp_internal(plVar2,lVar1);
          lVar1 = il2cpp_internal(DAT_181d72a30);
          FUN_180f58a90(lVar1,DAT_181d7c250);
          if (lVar1 != null) {
            FUN_181827900(lVar1,"干旱区域\n缓慢减少生命",DAT_181d7c3d0);
            FUN_181827900(lVar1,"极寒区域\n缓慢减少内力",DAT_181d7c3d0);
            FUN_181827900(lVar1,"瘴气区域\n缓慢减少生命内力",DAT_181d7c3d0);
            FUN_181827900(lVar1,"毒雾区域\n缓慢积累中毒",DAT_181d7c3d0);
            plVar2 = (int64 *)(pStatics + 8);
            *plVar2 = lVar1;
            il2cpp_internal(plVar2,lVar1);
            return;
          }
        }
    }

}
