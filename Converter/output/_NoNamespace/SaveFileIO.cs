// ============================================================
// Type  : SaveFileIO
// Token : 0x200012F
// ============================================================

public class SaveFileIO
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4000762
    private const int BufferSize;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60009D2
    // RVA   : 0x978B70   Offset: 0x977F70   Length: 0xAE
    private static bool IsGzip(FileStream fs)
    {
        int iVar1;
        int iVar2;
        long lVar3;
        if (fs == (int64 *)0) {
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
        lVar3 = (**(code **)(*fs + 0x1d8))(fs,*(uint64 *)(*fs + 0x1e0));
        if (1 < lVar3) {
          iVar1 = (**(code **)(*fs + 0x2e8))(fs,*(uint64 *)(*fs + 0x2f0));
          iVar2 = (**(code **)(*fs + 0x2e8))(fs,*(uint64 *)(*fs + 0x2f0));
          (**(code **)(*fs + 0x2c8))(fs,0,0,*(uint64 *)(*fs + 0x2d0));
          if (iVar1 != 31) {
            return false;
          }
          return iVar2 == 139;
        }
        return false;
    }

    // Token : 0x60009D3
    // RVA   : 0xBB22D0   Offset: 0xBB16D0   Length: 0x34D
    public static void WriteJson<T>(string path, T data, bool compress)
    {
        bool cVar1;
        ulong uVar2;
        long lVar3;
        long lVar4;
        long lVar5;
        ulong uVar6;
        long lVar7;
        ulong in_stack_ffffffffffffff58;
        uint uVar8;
        uVar8 = (uint32)((uint64)in_stack_ffffffffffffff58 >> 32);
        uVar2 = String.Concat(path,".tmp",0);
        lVar3 = JsonSerializer.CreateDefault(0);
        lVar4 = new FileStream(uVar2,2,2,(uint64)uVar8 << 32,0x10000,0);
        lVar5 = lVar4;
        if (compress) {
          lVar5 = new GZipStream(lVar4,1,1,0);
        }
        uVar6 = new UTF8Encoding(0,0);
        lVar7 = new StreamWriter(lVar5,uVar6,0x10000,0);
        lVar5 = new JsonTextWriter(lVar7,0);
        if (lVar3 != null) {
          JsonSerializer.Serialize(lVar3,lVar5,data,0);
          if (lVar5 != null) {
            FUN_180002970(0,DAT_181d78db8,lVar5);
          }
          if (lVar7 != null) {
            FUN_180002970(0,DAT_181d78db8,lVar7);
          }
          if (lVar4 != null) {
            FUN_180002970(0,DAT_181d78db8,lVar4);
          }
          cVar1 = File.Exists(path);
          if (cVar1) {
            File.Delete(path,0);
          }
          File.Move(uVar2,path,0);
          cVar1 = File.Exists(uVar2,0);
          if (cVar1) {
            File.Delete(uVar2,0);
          }
          return;
        }
    }

    // Token : 0x60009D4
    // RVA   : 0xBB1FF0   Offset: 0xBB13F0   Length: 0x2D2
    public static T ReadJson<T>(string path)
    {
        bool cVar1;
        long lVar2;
        long lVar3;
        long lVar4;
        ulong uVar5;
        long lVar6;
        ulong in_stack_ffffffffffffff70;
        uint uVar7;
        uVar7 = (uint32)((uint64)in_stack_ffffffffffffff70 >> 32);
        lVar2 = new JsonSerializerSettings(0);
        if (lVar2 == null) {
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
        JsonSerializerSettings.set_ObjectCreationHandling(lVar2,2,0);
        lVar3 = JsonSerializer.Create(lVar2,0);
        lVar4 = new FileStream(path,3,1,1,CONCAT44(uVar7,0x10000),0);
        cVar1 = SaveFileIO.IsGzip(lVar4,0);
        lVar2 = lVar4;
        if (cVar1) {
          lVar2 = new GZipStream(lVar4,0,0);
        }
        uVar5 = Encoding.get_UTF8(0);
        lVar6 = new StreamReader(lVar2,uVar5,1,0x10000,0);
        lVar2 = new JsonTextReader(lVar6,0);
        if (lVar3 != null) {
          uVar5 = (**(code **)**(uint64 **)(param_2 + 48))
                            (lVar3,lVar2,(uint64 *)**(uint64 **)(param_2 + 48));
          if (lVar2 != null) {
            FUN_180002970(0,DAT_181d78db8,lVar2);
          }
          if (lVar6 != null) {
            FUN_180002970(0,DAT_181d78db8,lVar6);
          }
          if (lVar4 != null) {
            FUN_180002970(0,DAT_181d78db8,lVar4);
          }
          return uVar5;
        }
    }

}
