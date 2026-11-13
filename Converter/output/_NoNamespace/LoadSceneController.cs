// ============================================================
// Type  : LoadSceneController
// Token : 0x2000306
// ============================================================

public class LoadSceneController
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x40018FC
    private AsyncOperation async;

    // Token: 0x40018FD
    public VideoClip[] videoClip;

    // Token: 0x40018FE
    public SubTitleData[] subTitleDatas;

    // Token: 0x40018FF
    public int videoClipID;

    // Token: 0x4001900
    public int subTitleID;

    // Token: 0x4001901
    public VideoPlayer videoPlayer;

    // Token: 0x4001902
    public GameObject Subtitle;

    // Token: 0x4001903
    public Text progressText;

    // Token: 0x4001904
    public GameObject circle;

    // Token: 0x4001905
    public Text tipsText;

    // Token: 0x4001906
    private float progress;

    // Token: 0x4001907
    private bool gcCollected;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6001952
    // RVA   : 0x7C5030   Offset: 0x7C3E30   Length: 0x780
    private void Start()
    {
        var pStatics_6be8 = *(int64*)(DAT_181e86be8 + 184);
        bool cVar1;
        uint uVar2;
        uint uVar3;
        ulong uVar4;
        long lVar7;
        long lVar8;
        ulong local_28;
        uint local_20;
        byte[] local_18 = new byte[16];
        Resources.UnloadUnusedAssets(0);
        GC.Collect(0);
        uVar4 = **(uint64 **)(DAT_181e86be8 + 184);
        cVar1 = Object.op_Inequality(uVar4,0,0);
        if (!cVar1) {
          plVar5 = this.tipsText;
          lVar7 = GameController.ChangeAllAreaStateIDs;
          if (lVar7 == null) throw; // [null/range check failed]
          lVar7 = *(int64 *)(lVar7 + 0x1d8);
          lVar8 = GameController.ChangeAllAreaStateIDs;
          if ((lVar8 == null) || (lVar8 = *(int64 *)(lVar8 + 0x1d8)) == null) throw; // [null/range check failed]
          uVar2 = FUN_180af1860(0,*(uint32 *)(lVar8 + 24),0);
          if (lVar7 == null) throw; // [null/range check failed]
          if (*(uint32 *)(lVar7 + 24) <= uVar2) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          uVar4 = lVar7[uVar2];
          uVar4 = LTLocalization.GetText(uVar4,0,1,0);
          if (plVar5 == (int64 *)0) throw; // [null/range check failed]
          (**(code **)(*plVar5 + 0x5e8))(plVar5,uVar4,*(uint64 *)(*plVar5 + 0x5f0));
          LTLocalization.CheckTextFont(plVar5,0);
        }
        else {
          if (((*pStatics_6be8 == 0) ||
              (lVar7 = Component.get_gameObject(*pStatics_6be8,0)) == null) ||
             (lVar7 = GameObject.GetComponent(lVar7,DAT_181e533a8)) == null) throw; // [null/range check failed]
          AudioSource.Stop(lVar7,0);
          lVar7 = this.videoClip;
          if (lVar7 == null) throw; // [null/range check failed]
          if (*(int *)(lVar7 + 24) == 0) {
            uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1801e02d0(uVar4,0);
          }
          if (this.videoPlayer == null) throw; // [null/range check failed]
          VideoPlayer.set_clip(this.videoPlayer,*(uint64 *)(lVar7 + 32),0);
          lVar7 = this.videoPlayer;
          uVar3 = AudioListener.get_volume(0);
          if (lVar7 == null) throw; // [null/range check failed]
          VideoPlayer.SetDirectAudioVolume(lVar7,0,uVar3,0);
          if (this.videoPlayer == null) throw; // [null/range check failed]
          lVar7 = Component.get_gameObject(this.videoPlayer,0);
          if (lVar7 == null) throw; // [null/range check failed]
          GameObject.SetActive(lVar7,1,0);
          if (this.videoPlayer == null) throw; // [null/range check failed]
          VideoPlayer.Play(this.videoPlayer,0);
          if (this.Subtitle == null) throw; // [null/range check failed]
          GameObject.SetActive(this.Subtitle,1,0);
          lVar7 = this.videoPlayer;
          uVar4 = new OnTooltipCB(this,DAT_181e6b600,0);
          if (lVar7 == null) throw; // [null/range check failed]
          VideoPlayer.add_loopPointReached(lVar7,uVar4,0);
          if ((this.Subtitle == null) ||
             (lVar7 = GameObject.get_transform(this.Subtitle,0)) == null)
          throw; // [null/range check failed]
          lVar7 = Transform.Find(lVar7,"Text",0);
          if (lVar7 == null) throw; // [null/range check failed]
          plVar5 = (int64 *)Component.GetComponent(lVar7,DAT_181e79538);
          uVar4 = "";
          uVar4 = LTLocalization.GetText(uVar4,0,1,0);
          if (plVar5 == (int64 *)0) throw; // [null/range check failed]
          (**(code **)(*plVar5 + 0x5e8))(plVar5,uVar4,*(uint64 *)(*plVar5 + 0x5f0));
          LTLocalization.CheckTextFont(plVar5,0);
          if (this.progressText == null) throw; // [null/range check failed]
          lVar7 = Component.get_transform(this.progressText,0);
          puVar6 = (uint64 *)Vector3.get_zero(local_18,0);
          if (lVar7 == null) throw; // [null/range check failed]
          local_20 = *(uint32 *)(puVar6 + 1);
          local_28 = *puVar6;
          Transform.set_localScale(lVar7,&local_28,0);
          if (this.circle == null) throw; // [null/range check failed]
          lVar7 = GameObject.get_transform(this.circle,0);
          puVar6 = (uint64 *)Vector3.get_zero(local_18,0);
          if (lVar7 == null) throw; // [null/range check failed]
          local_20 = *(uint32 *)(puVar6 + 1);
          local_28 = *puVar6;
          Transform.set_localScale(lVar7,&local_28,0);
        }
        uVar4 = "MainGame";
        lVar7 = new WarpText_d__8(0,0);
        if (lVar7 != null) {
          *(int64 *)(lVar7 + 32) = this;
          *(uint64 *)(lVar7 + 40) = uVar4;
          FUN_180ae80b0(this,lVar7,0);
          uVar4 = GameObject.FindGameObjectWithTag("LoadSaveIDTag",0);
          cVar1 = Object.op_Inequality(uVar4,0,0);
          if (!cVar1) {
            return;
          }
          lVar7 = GameController.ChangeAllAreaStateIDs;
          lVar8 = GameObject.FindGameObjectWithTag("LoadSaveIDTag",0);
          if (lVar8 != null) {
            uVar4 = Object.get_name(lVar8,0);
            uVar3 = Int32.Parse(uVar4,0);
            if (lVar7 != null) {
              GameDataController.Load(lVar7,uVar3,0);
              return;
            }
          }
        }
    }

    // Token : 0x6001953
    // RVA   : 0x7C4FA0   Offset: 0x7C3DA0   Length: 0x88
    private IEnumerator LoadScene(string sceneName)
    {
        long lVar1;
        lVar1 = new WarpText_d__8(0,0);
        if (lVar1 != null) {
          *(uint64 *)(lVar1 + 32) = this;
          *(uint64 *)(lVar1 + 40) = sceneName;
          return lVar1;
        }
    }

    // Token : 0x6001954
    // RVA   : 0x7C5E90   Offset: 0x7C4C90   Length: 0x359
    public void VideoPlayFinished(VideoPlayer vp)
    {
        var pStatics = *(int64*)(DAT_181e86be8 + 184);
        uint uVar1;
        long lVar2;
        bool cVar3;
        long lVar4;
        ulong uVar6;
        ulong local_28;
        uint local_20;
        byte[] local_18 = new byte[16];
        uVar6 = **(uint64 **)(DAT_181e86be8 + 184);
        cVar3 = Object.op_Inequality(uVar6,0,0);
        if (!cVar3) {
        LAB_1807c5f96:
          this.videoClipID = this.videoClipID + 1;
          uVar1 = this.videoClipID;
          lVar4 = this.videoClip;
          if (lVar4 == null) throw; // [null/range check failed]
        }
        else {
          if (*pStatics == 0) throw; // [null/range check failed]
          if (*(int *)(*pStatics + 44) != 1) goto LAB_1807c5f96;
          lVar4 = this.videoClip;
          if (lVar4 == null) throw; // [null/range check failed]
          uVar1 = *(uint32 *)(lVar4 + 24);
          this.videoClipID = uVar1;
        }
        lVar2 = this.videoPlayer;
        if (uVar1 == *(uint32 *)(lVar4 + 24)) {
          if (lVar2 != null) {
            VideoPlayer.Stop(lVar2,0);
            if (this.videoPlayer != null) {
              lVar4 = Component.get_gameObject(this.videoPlayer,0);
              if (lVar4 != null) {
                GameObject.SetActive(lVar4,0,0);
                if (this.Subtitle != null) {
                  GameObject.SetActive(this.Subtitle,0,0);
                  if (this.progressText != null) {
                    lVar4 = Component.get_transform(this.progressText,0);
                    puVar7 = (uint64 *)Vector3.get_one(local_18,0);
                    if (lVar4 != null) {
                      local_20 = *(uint32 *)(puVar7 + 1);
                      local_28 = *puVar7;
                      Transform.set_localScale(lVar4,&local_28,0);
                      if (this.circle != null) {
                        lVar4 = GameObject.get_transform(this.circle,0);
                        puVar7 = (uint64 *)Vector3.get_one(local_18,0);
                        if (lVar4 != null) {
                          local_20 = *(uint32 *)(puVar7 + 1);
                          local_28 = *puVar7;
                          Transform.set_localScale(lVar4,&local_28,0);
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
        else {
          if (*(uint32 *)(lVar4 + 24) <= uVar1) {
            uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1801e02d0(uVar6,0);
          }
          if (lVar2 != null) {
            VideoPlayer.set_clip(lVar2,lVar4[uVar1],0);
            if (this.videoPlayer != null) {
              VideoPlayer.Play(this.videoPlayer,0);
              this.subTitleID = 0;
              if (this.Subtitle != null) {
                lVar4 = GameObject.get_transform(this.Subtitle,0);
                if (lVar4 != null) {
                  lVar4 = Transform.Find(lVar4,"Text",0);
                  if (lVar4 != null) {
                    plVar5 = (int64 *)Component.GetComponent(lVar4,DAT_181e79538);
                    uVar6 = "";
                    uVar6 = LTLocalization.GetText(uVar6,0,1,0);
                    if (plVar5 != (int64 *)0) {
                      (**(code **)(*plVar5 + 0x5e8))(plVar5,uVar6,*(uint64 *)(*plVar5 + 0x5f0));
                      LTLocalization.CheckTextFont(plVar5,0);
                      return;
                    }
                  }
                }
              }
            }
          }
        }
    }

    // Token : 0x6001955
    // RVA   : 0x7C57C0   Offset: 0x7C45C0   Length: 0x6CC
    private void Update()
    {
        float fVar1;
        uint uVar2;
        ulong uVar3;
        double dVar4;
        bool cVar5;
        long lVar6;
        ulong uVar7;
        float fVar10;
        float fVar11;
        int[] local_res8 = new int[2];
        uint local_28;
        uint uStack_24;
        uint uStack_20;
        uint32 uStack_1c;
        if (this.async == null) {
          return;
        }
        if (this.videoPlayer == null) throw; // [null/range check failed]
        cVar5 = VideoPlayer.get_isPlaying(this.videoPlayer,0);
        if (cVar5) {
          cVar5 = FUN_181844860(27);
          if (cVar5) {
            LoadSceneController.VideoPlayFinished(this,0,0);
          }
          if (this.videoClip == null) throw; // [null/range check failed]
          uVar2 = this.videoClipID;
          if ((int)uVar2 < *(int *)(this.videoClip + 24)) {
            lVar6 = this.subTitleDatas;
            if (lVar6 == null) throw; // [null/range check failed]
            if (*(uint32 *)(lVar6 + 24) <= uVar2) {
              uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1801e02d0(uVar7,0);
            }
            lVar6 = lVar6[uVar2];
            if ((lVar6 == null) || (lVar6 = *(int64 *)(lVar6 + 16)) == null) throw; // [null/range check failed]
            if (this.subTitleID < *(int *)(lVar6 + 24)) {
              if (this.videoPlayer == null) throw; // [null/range check failed]
              dVar4 = (double)VideoPlayer.get_time(this.videoPlayer,0);
              lVar6 = this.subTitleDatas;
              if (lVar6 == null) throw; // [null/range check failed]
              if (*(uint32 *)(lVar6 + 24) <= this.videoClipID) {
                uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1801e02d0(uVar7,0);
              }
              lVar6 = *(int64 *)(lVar6 + 32 + (int64)(int)this.videoClipID * 8);
              if (((lVar6 == null) || (lVar6 = *(int64 *)(lVar6 + 16)) == null) ||
                 (lVar6 = FUN_1800024b0(lVar6,this.subTitleID,DAT_181e86cf0)) == null)
              throw; // [null/range check failed]
              if ((double)*(float *)(lVar6 + 16) <= dVar4) {
                if (((this.Subtitle == null) ||
                    (lVar6 = GameObject.get_transform(this.Subtitle,0)) == null) ||
                   (lVar6 = Transform.Find(lVar6,"Text",0)) == null) throw; // [null/range check failed]
                uVar7 = Component.GetComponent(lVar6,DAT_181e79538);
                lVar6 = this.subTitleDatas;
                if (lVar6 == null) throw; // [null/range check failed]
                if (*(uint32 *)(lVar6 + 24) <= this.videoClipID) {
                  uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1801e02d0(uVar7,0);
                }
                lVar6 = *(int64 *)(lVar6 + 32 + (int64)(int)this.videoClipID * 8);
                if (((lVar6 == null) || (lVar6 = *(int64 *)(lVar6 + 16)) == null) ||
                   (lVar6 = FUN_1800024b0(lVar6,this.subTitleID,DAT_181e86cf0), lVar6 == null
                   )) throw; // [null/range check failed]
                uVar3 = *(uint64 *)(lVar6 + 24);
                LTLocalization.SetText(uVar7,uVar3,0);
                if (((this.Subtitle == null) ||
                    (lVar6 = GameObject.get_transform(this.Subtitle,0)) == null) ||
                   (lVar6 = Transform.Find(lVar6,"Text",0)) == null) throw; // [null/range check failed]
                plVar8 = (int64 *)Component.GetComponent(lVar6,DAT_181e79538);
                puVar9 = (uint32 *)FUN_180af4e90(&local_28,0);
                if (plVar8 == (int64 *)0) throw; // [null/range check failed]
                local_28 = *puVar9;
                uStack_24 = puVar9[1];
                uStack_20 = puVar9[2];
                uStack_1c = puVar9[3];
                (**(code **)(*plVar8 + 0x2a8))(plVar8,&local_28,*(uint64 *)(*plVar8 + 0x2b0));
                if (((this.Subtitle == null) ||
                    (lVar6 = GameObject.get_transform(this.Subtitle,0)) == null) ||
                   (lVar6 = Transform.Find(lVar6,"Text",0)) == null) throw; // [null/range check failed]
                uVar7 = Component.GetComponent(lVar6,DAT_181e79538);
                puVar9 = (uint32 *)FUN_180f24d00(&local_28,0);
                local_28 = *puVar9;
                uStack_24 = puVar9[1];
                uStack_20 = puVar9[2];
                uStack_1c = puVar9[3];
                DOTweenModuleUI.DOColor(uVar7,&local_28,0x3e99999a,0);
                this.subTitleID = this.subTitleID + 1;
              }
            }
          }
        }
        fVar1 = this.progress;
        if (fVar1 < 0.9) {
          if (this.async != null) {
            fVar10 = (float)AsyncOperation.get_progress(this.async,0);
            fVar11 = this.progress;
            if (fVar1 < fVar10) {
              fVar11 = fVar11 + 0.01;
              this.progress = fVar11;
            }
            plVar8 = this.progressText;
            local_res8[0] = (int)(fVar11 * 100.0);
            uVar7 = Int32.ToString(local_res8,0);
            uVar7 = String.Concat(uVar7,"%",0);
            uVar7 = LTLocalization.GetText(uVar7,0,1,0);
            if (plVar8 != (int64 *)0) {
              (**(code **)(*plVar8 + 0x5e8))(plVar8,uVar7,*(uint64 *)(*plVar8 + 0x5f0));
              LTLocalization.CheckTextFont(plVar8,0);
              return;
            }
          }
          throw; // [null/range check failed]
        }
        this.progress = 0x3f8147ae;
        uVar7 = GameObject.FindGameObjectWithTag("LoadSaveIDTag",0);
        cVar5 = Object.op_Inequality(uVar7,0,0);
        uVar7 = this.progressText;
        if (!cVar5) {
          LTLocalization.SetText(uVar7,"正在生成世界\n请耐心等待...",0);
          LTLocalization.SetText(this.tipsText,"请勿点击鼠标\n否则可能导致程序未响应",0);
          if (this.videoPlayer == null) throw; // [null/range check failed]
          cVar5 = VideoPlayer.get_isPlaying(this.videoPlayer,0);
          if (cVar5) {
            return;
          }
          if (this.videoClip == null) throw; // [null/range check failed]
          if (this.videoClipID != *(int *)(this.videoClip + 24)) {
            return;
          }
        }
        else {
          LTLocalization.SetText(uVar7,"正在踏入江湖...",0);
          lVar6 = FUN_180210740(0);
          if ((lVar6 == null) || (*(int64 *)(lVar6 + 48) == 0)) throw; // [null/range check failed]
          cVar5 = GameSaveData.CheckAllFinished(*(int64 *)(lVar6 + 48),0);
          if (!cVar5) {
            return;
          }
        }
        if (*(char *)(this + 100) == false) {
          *(uint8 *)(this + 100) = 1;
          GC.Collect(0);
        }
        if (**(int **)(DAT_181e538e8 + 184) == 1) {
          lVar6 = RailManager.get_Instance(0);
          if (lVar6 == null) throw; // [null/range check failed]
          if (*(char *)(lVar6 + 25) != false) {
            return;
          }
        }
        if (this.async != null) {
          AsyncOperation.set_allowSceneActivation(this.async,1,0);
          return;
        }
    }

    // Token : 0x6001956
    // RVA   : 0x2110A0   Offset: 0x20FEA0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_180ae8740(this,0);
    }

}
