// ============================================================
// Type  : <ShowHighLightLine>d__40
// Token : 0x2000393
// ============================================================

public class <ShowHighLightLine>d__40
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001D70
    private int <>1__state;

    // Token: 0x4001D71
    private object <>2__current;

    // Token: 0x4001D72
    public StudyInternalPointController <>4__this;

    // Token: 0x4001D73
    private int <i>5__2;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6002329
    // RVA   : 0x608BA0   Offset: 0x6079A0   Length: 0x24
    public void /*ctor*/(int <>1__state)
    {
        ZhSegment.Initialize(this,0);
        this.<>1__state = <>1__state;
    }

    // Token : 0x600232A
    // RVA   : 0x51CF50   Offset: 0x51BD50   Length: 0x3
    private virtual void System.IDisposable.Dispose()
    {
    }

    // Token : 0x600232B
    // RVA   : 0x612750   Offset: 0x611550   Length: 0x5BB
    private virtual bool MoveNext()
    {
        var pStatics = *(int64*)(DAT_181e88568 + 184);
        ulong uVar1;
        float fVar2;
        float fVar3;
        long lVar4;
        bool cVar5;
        long lVar6;
        long lVar8;
        ulong uVar9;
        float fVar10;
        float local_78;
        float fStack_74;
        float local_68;
        float fStack_64;
        ulong local_58;
        float local_50;
        ulong local_48;
        float local_40;
        byte[] local_38 = new byte[16];
        byte[] local_28 = new byte[32];
        lVar8 = this.<>4__this;
        if (this.<>1__state == 0) {
          this.<>1__state = 0xffffffff;
          if ((lVar8 == null) || (*(int64 *)(lVar8 + 88) == 0)) throw; // [null/range check failed]
          LineRenderer.set_positionCount(*(int64 *)(lVar8 + 88),2,0);
          lVar4 = *(int64 *)(lVar8 + 88);
          lVar6 = Component.get_transform(lVar8,0);
          if (lVar6 == null) throw; // [null/range check failed]
          puVar7 = (uint64 *)Transform.get_position(local_38,lVar6,0);
          local_58 = *puVar7;
          local_50 = *(float *)(puVar7 + 1);
          puVar7 = (uint64 *)GlobalData.SetZToZero(local_38,&local_58,0);
          if (lVar4 == null) throw; // [null/range check failed]
          local_58 = *puVar7;
          local_50 = *(float *)(puVar7 + 1);
          LineRenderer.SetPosition(lVar4,0,&local_58);
          lVar4 = *(int64 *)(lVar8 + 88);
          lVar6 = Component.get_transform(lVar8,0);
          if (lVar6 == null) throw; // [null/range check failed]
          puVar7 = (uint64 *)Transform.get_position(local_38,lVar6,0);
          local_58 = *puVar7;
          local_50 = *(float *)(puVar7 + 1);
          puVar7 = (uint64 *)GlobalData.SetZToZero(local_38,&local_58,0);
          if (lVar4 == null) throw; // [null/range check failed]
          local_58 = *puVar7;
          local_50 = *(float *)(puVar7 + 1);
          LineRenderer.SetPosition(lVar4,1,&local_58);
          this.<i>5__2 = 0;
        }
        else {
          if (this.<>1__state != 1) {
            return false;
          }
          this.<i>5__2 = this.<i>5__2 + 1;
          this.<>1__state = 0xffffffff;
          if (50 < this.<i>5__2) {
            if (lVar8 != null) {
              uVar9 = *(uint64 *)(lVar8 + 96);
              if (*pStatics != 0) {
                uVar1 = *(uint64 *)(*pStatics + 120);
                cVar5 = Object.op_Equality(uVar9,uVar1,0);
                if (!cVar5) {
                  if (*pStatics != 0) {
                    *(uint8 *)(*pStatics + 128) = 1;
                    if (*pStatics != 0) {
                      StudyInternalSkillController.SetCrashingPoint
                                (*pStatics,*(uint64 *)(lVar8 + 96),0);
                      return false;
                    }
                  }
                }
                else {
                  lVar4 = *pStatics;
                  if (*pStatics != 0) {
                    if (*(int *)(*pStatics + 32) < 18) {
                      if (*pStatics == 0) throw; // [null/range check failed]
                      cVar5 = (8 < *(int *)(*pStatics + 32)) + '\x02';
                    }
                    else {
                      cVar5 = '\x04';
                    }
                    if (lVar4 != null) {
                      uVar9 = StudyInternalSkillController.FinishStudyInternalSkill(lVar4,cVar5,0);
                      FUN_180ae80b0(lVar8,uVar9,0);
                      return false;
                    }
                  }
                }
              }
            }
            throw; // [null/range check failed]
          }
          if (lVar8 == null) throw; // [null/range check failed]
        }
        lVar4 = *(int64 *)(lVar8 + 88);
        lVar6 = Component.get_transform(lVar8,0);
        if (lVar6 != null) {
          puVar7 = (uint64 *)Transform.get_position(local_38,lVar6,0);
          uVar9 = *puVar7;
          fVar2 = *(float *)(puVar7 + 1);
          local_58 = uVar9;
          local_50 = fVar2;
          puVar7 = (uint64 *)GlobalData.SetZToZero(local_38,&local_58,0);
          uVar9 = *puVar7;
          fVar2 = *(float *)(puVar7 + 1);
          if ((*(int64 *)(lVar8 + 96) != 0) &&
             (lVar6 = GameObject.get_transform(*(int64 *)(lVar8 + 96),0)) != null) {
            puVar7 = (uint64 *)Transform.get_position(local_38,lVar6,0);
            local_58 = *puVar7;
            local_50 = *(float *)(puVar7 + 1);
            puVar7 = (uint64 *)GlobalData.SetZToZero(local_38,&local_58,0);
            uVar1 = *puVar7;
            fVar3 = *(float *)(puVar7 + 1);
            lVar8 = Component.get_transform(lVar8,0);
            if (lVar8 != null) {
              puVar7 = (uint64 *)Transform.get_position(local_38,lVar8,0);
              local_58 = *puVar7;
              local_50 = *(float *)(puVar7 + 1);
              puVar7 = (uint64 *)GlobalData.SetZToZero(local_28,&local_58,0);
              local_40 = *(float *)(puVar7 + 1);
              local_48 = *puVar7;
              fVar10 = (float)this.<i>5__2;
              local_78 = (float)uVar1;
              fStack_74 = (float)((uint64)uVar1 >> 32);
              local_68 = (float)uVar9;
              fStack_64 = (float)((uint64)uVar9 >> 32);
              local_50 = ((fVar3 - local_40) * fVar10) / 50.0 + fVar2;
              local_58 = CONCAT44(((fStack_74 - (float)((uint64)local_48 >> 32)) * fVar10) / 50.0 +
                                  fStack_64,((local_78 - (float)local_48) * fVar10) / 50.0 + local_68);
              if (lVar4 != null) {
                local_48 = local_58;
                local_40 = local_50;
                LineRenderer.SetPosition(lVar4,1,&local_48);
                uVar9 = new WaitForSecondsRealtime(0x3c23d70a,0);
                this.<>2__current = uVar9;
                this.<>1__state = 1;
                return true;
              }
            }
          }
        }
    }

    // Token : 0x600232C
    // RVA   : 0x608B50   Offset: 0x607950   Length: 0x5
    private virtual object System.Collections.Generic.IEnumerator<System.object>.get_Current()
    {
        return this.<>2__current;
    }

    // Token : 0x600232D
    // RVA   : 0x612D10   Offset: 0x611B10   Length: 0x3E
    private virtual void System.Collections.IEnumerator.Reset()
    {
        ulong uVar1;
        ulong uVar2;
        uVar1 = il2cpp_runtime_class_init(&DAT_181e6d8e8);
        uVar1 = il2cpp_internal(uVar1);
        NotSupportedException.ctor(uVar1,0);
        uVar2 = il2cpp_runtime_class_init(&DAT_181e989e0);
    }

    // Token : 0x600232E
    // RVA   : 0x608B50   Offset: 0x607950   Length: 0x5
    private virtual object System.Collections.IEnumerator.get_Current()
    {
        return this.<>2__current;
    }

}
