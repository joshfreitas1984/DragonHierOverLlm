// ============================================================
// Type  : BigMapSpeEffectController
// Token : 0x2000198
// ============================================================

public class BigMapSpeEffectController
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4000B25
    public BigMapSpeEffectType bigMapSpeEffectType;

    // Token: 0x4000B26
    public static List<string> bigMapSpeEffectTypeName;

    // Token: 0x4000B27
    public static List<string> bigMapSpeEffectTypeDescribe;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000D22
    // RVA   : 0x3A17B0   Offset: 0x3A0BB0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_18044ef50(this,0);
    }

    // Token : 0x6000D23
    // RVA   : 0xC7C440   Offset: 0xC7B840   Length: 0x1E4
    private static void /*cctor*/()
    {
        var pStatics = *(int64*)(DAT_181db0d48 + 184);
        long lVar1;
        lVar1 = il2cpp_internal(DAT_181d97750);
        FUN_18132faf0(lVar1,DAT_181da3bd8);
        if (lVar1 != null) {
          FUN_18181e0a0(lVar1,"旱",DAT_181da3d58);
          FUN_18181e0a0(lVar1,"寒",DAT_181da3d58);
          FUN_18181e0a0(lVar1,"瘴",DAT_181da3d58);
          FUN_18181e0a0(lVar1,"毒",DAT_181da3d58);
          plVar2 = pStatics;
          *plVar2 = lVar1;
          il2cpp_internal(plVar2,lVar1);
          lVar1 = il2cpp_internal(DAT_181d97750);
          FUN_18132faf0(lVar1,DAT_181da3bd8);
          if (lVar1 != null) {
            FUN_18181e0a0(lVar1,"干旱区域\n缓慢减少生命",DAT_181da3d58);
            FUN_18181e0a0(lVar1,"极寒区域\n缓慢减少内力",DAT_181da3d58);
            FUN_18181e0a0(lVar1,"瘴气区域\n缓慢减少生命内力",DAT_181da3d58);
            FUN_18181e0a0(lVar1,"毒雾区域\n缓慢积累中毒",DAT_181da3d58);
            BigMapSpeEffectController.bigMapSpeEffectTypeDescribe = lVar1;
            return;
          }
        }
    }

}
