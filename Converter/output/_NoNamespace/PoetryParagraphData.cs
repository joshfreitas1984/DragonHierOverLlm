// ============================================================
// Type  : PoetryParagraphData
// Token : 0x2000249
// ============================================================

public class PoetryParagraphData
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x40011EE
    public string paragraphText;

    // Token: 0x40011EF
    public List<int> paragraphTextNum;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60012E1
    // RVA   : 0xBD9AA0   Offset: 0xBD82A0   Length: 0x16E
    public void /*ctor*/(string _paragraphText)
    {
        ulong uVar1;
        long lVar2;
        long lVar3;
        ZhSegment.Initialize(this,0);
        this.paragraphText = _paragraphText;
        uVar1 = il2cpp_internal(DAT_181d6f030);
        FUN_180f58a90(uVar1,DAT_181d678f8);
        this.paragraphTextNum = uVar1;
        lVar3 = this.paragraphText;
        lVar2 = FUN_1800d60b0(DAT_181d7c118,1);
        if (lVar2 != null) {
          if (*(int *)(lVar2 + 24) == 0) {
            uVar1 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar1,0);
          }
          *(uint16 *)(lVar2 + 32) = 0xff0c;
          if ((lVar3 != null) && (lVar3 = String.Split(lVar3,lVar2,0)) != null) {
            if (*(int *)(lVar3 + 24) != 2) {
              return;
            }
            if ((*(int64 *)(lVar3 + 32) != 0) && (this.paragraphTextNum != null)) {
              FUN_181814fa0(this.paragraphTextNum,
                            *(uint32 *)(*(int64 *)(lVar3 + 32) + 16),DAT_181d67a78);
              if (*(uint32 *)(lVar3 + 24) < 2) {
                uVar1 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar1,0);
              }
              if ((*(int64 *)(lVar3 + 40) != 0) && (this.paragraphTextNum != null)) {
                FUN_181814fa0(this.paragraphTextNum,
                              *(int *)(*(int64 *)(lVar3 + 40) + 16) + -1,DAT_181d67a78);
                return;
              }
            }
          }
        }
    }

    // Token : 0x60012E2
    // RVA   : 0xBD9920   Offset: 0xBD8120   Length: 0x175
    public virtual object Clone()
    {
        long lVar2;
        ulong uVar3;
        ulong local_38;
        ulong uStack_30;
        uint local_28;
        uint uStack_24;
        uint uStack_20;
        uint32 uStack_1c;
        plVar1 = (int64 *)il2cpp_internal(DAT_181d63ff0);
        plVar4 = plVar1;
        MemoryStream.ctor(plVar1,1000,0);
        local_38 = 0;
        uStack_30 = 0;
        StreamingContext.ctor(&local_38,64,0);
        lVar2 = il2cpp_internal(DAT_181d8c5a8);
        local_28 = (uint32)local_38;
        uStack_24 = local_38._4_4_;
        uStack_20 = (uint32)uStack_30;
        uStack_1c = uStack_30._4_4_;
        BinaryFormatter.ctor(lVar2,0,&local_28,0,plVar4);
        if (lVar2 != null) {
          BinaryFormatter.Serialize(lVar2,plVar1,this,0);
          if (plVar1 != (int64 *)0) {
            (**(code **)(*plVar1 + 0x2c8))(plVar1,0,0,*(uint64 *)(*plVar1 + 0x2d0));
            uVar3 = BinaryFormatter.Deserialize(lVar2,plVar1,0);
            (**(code **)(*plVar1 + 0x238))(plVar1,*(uint64 *)(*plVar1 + 0x240));
            FUN_180002970(0,DAT_181d53c70,plVar1);
            return uVar3;
          }
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
    }

}
