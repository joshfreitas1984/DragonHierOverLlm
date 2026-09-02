// ============================================================
// Type  : EnterSceneController
// Token : 0x2000264
// ============================================================

public class EnterSceneController
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x40012D0
    public VideoPlayer logoVideo;

    // Token: 0x40012D1
    public bool videoPlayFinished;

    // Token: 0x40012D2
    public Image noiseLogo;

    // Token: 0x40012D3
    public bool noiseLogFinished;

    // Token: 0x40012D4
    private AsyncOperation async;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60013B4
    // RVA   : 0x934680   Offset: 0x932E80   Length: 0x121
    private void Start()
    {
        long lVar1;
        ulong uVar2;
        GlobalData.AutoSetWindowResolution(0);
        lVar1 = this.logoVideo;
        uVar2 = new OnTooltipCB(this,DAT_181d872c8,0);
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

    // Token : 0x60013B5
    // RVA   : 0x9347C0   Offset: 0x932FC0   Length: 0x9A
    private void Update()
    {
        long lVar1;
        if ((!this.videoPlayFinished) || (!this.noiseLogFinished)) {
          return;
        }
        if (**(int **)(DAT_181d4ef00 + 184) == 1) {
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

    // Token : 0x60013B6
    // RVA   : 0x934860   Offset: 0x933060   Length: 0xE8
    private void VideoPlayFinished(VideoPlayer vp)
    {
        ulong uVar1;
        ulong uVar2;
        this.videoPlayFinished = 1;
        DOTweenModuleUI.DOFade(this.noiseLogo,0x3f800000,0x3f000000,0);
        uVar1 = DOTweenModuleUI.DOFade(this.noiseLogo,0,0x3f000000,0);
        uVar1 = TweenSettingsExtensions.SetDelay(uVar1,0x40000000,DAT_181d977e0);
        uVar2 = new OnTooltipCB(this,DAT_181d87248,0);
        TweenSettingsExtensions.OnComplete(uVar1,uVar2,DAT_181d96cc8);
    }

    // Token : 0x60013B7
    // RVA   : 0x3A17B0   Offset: 0x39FFB0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_18044ef50(this,0);
    }

    // Token : 0x60013B8
    // RVA   : 0x9347B0   Offset: 0x932FB0   Length: 0x5
    private void <VideoPlayFinished>b__7_0()
    {
        void FUN_1809347b0(int64 this)
        {
        this.noiseLogFinished = 1;
    }

}
