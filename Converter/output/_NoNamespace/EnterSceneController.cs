// ============================================================
// Type  : EnterSceneController
// Token : 0x2000271
// ============================================================

public class EnterSceneController
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x40013B1
    public VideoPlayer logoVideo;

    // Token: 0x40013B2
    public bool videoPlayFinished;

    // Token: 0x40013B3
    public Image noiseLogo;

    // Token: 0x40013B4
    public bool noiseLogFinished;

    // Token: 0x40013B5
    private AsyncOperation async;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x600145D
    // RVA   : 0x689E90   Offset: 0x688C90   Length: 0x121
    private void Start()
    {
        long lVar1;
        ulong uVar2;
        GlobalData.AutoSetWindowResolution(0);
        lVar1 = this.logoVideo;
        uVar2 = new OnTooltipCB(this,DAT_181e932f8,0);
        if (lVar1 != null) {
          VideoPlayer.add_loopPointReached(lVar1,uVar2,0);
          uVar2 = SceneManager.LoadSceneAsync("TitleScene",0);
          this.async = uVar2;
          if (this.async != null) {
            AsyncOperation.set_allowSceneActivation(this.async,0,0);
            return;
          }
        }
    }

    // Token : 0x600145E
    // RVA   : 0x689FD0   Offset: 0x688DD0   Length: 0x9A
    private void Update()
    {
        long lVar1;
        if ((!this.videoPlayFinished) || (!this.noiseLogFinished)) {
          return;
        }
        if (**(int **)(DAT_181e538e8 + 184) == 1) {
          lVar1 = RailManager.get_Instance(0);
          if (lVar1 == null) throw; // [null/range check failed]
          if (*(char *)(lVar1 + 25) != false) {
            return;
          }
        }
        if (this.async != null) {
          AsyncOperation.set_allowSceneActivation(this.async,1,0);
          return;
        }
    }

    // Token : 0x600145F
    // RVA   : 0x68A070   Offset: 0x688E70   Length: 0xE8
    private void VideoPlayFinished(VideoPlayer vp)
    {
        ulong uVar1;
        ulong uVar2;
        this.videoPlayFinished = 1;
        DOTweenModuleUI.DOFade(this.noiseLogo,0x3f800000,0x3f000000,0);
        uVar1 = DOTweenModuleUI.DOFade(this.noiseLogo,0,0x3f000000,0);
        uVar1 = TweenSettingsExtensions.SetDelay(uVar1,0x40000000,DAT_181ea46c0);
        uVar2 = new OnTooltipCB(this,DAT_181e93278,0);
        TweenSettingsExtensions.OnComplete(uVar1,uVar2,DAT_181ea3ba0);
    }

    // Token : 0x6001460
    // RVA   : 0x2110A0   Offset: 0x20FEA0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_180ae8740(this,0);
    }

    // Token : 0x6001461
    // RVA   : 0x689FC0   Offset: 0x688DC0   Length: 0x5
    private void <VideoPlayFinished>b__7_0()
    {
        void FUN_180689fc0(int64 this)
        {
        this.noiseLogFinished = 1;
    }

}
