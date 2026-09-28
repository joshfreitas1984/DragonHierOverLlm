// ============================================================
// Type  : ReadBookTextController
// Token : 0x200033C
// ============================================================

public class ReadBookTextController
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001AEE
    public int column;

    // Token: 0x4001AEF
    public int row;

    // Token: 0x4001AF0
    public ReadBookTextTypeData textData;

    // Token: 0x4001AF1
    public bool seen;

    // Token: 0x4001AF2
    public bool finished;

    // Token: 0x4001AF3
    public bool inited;

    // Token: 0x4001AF4
    public Sprite expIconSprite;

    // Token: 0x4001AF5
    public Sprite expGoodIconSprite;

    // Token: 0x4001AF6
    public Sprite pantientIconSprite;

    // Token: 0x4001AF7
    public Sprite expGoodBack;

    // Token: 0x4001AF8
    public Sprite expBadBack;

    // Token: 0x4001AF9
    public Sprite speGoodBack;

    // Token: 0x4001AFA
    public Sprite speBadBack;

    // Token: 0x4001AFB
    private static Color TextPositiceColor;

    // Token: 0x4001AFC
    private static Color TextNegaticeColor;

    // Token: 0x4001AFD
    private Vector3 originIconPos;

    // Token: 0x4001AFE
    private GameObject newObj;

    // Token: 0x4001AFF
    private static Color textGrayColor;

    // Token: 0x4001B00
    private static Color textRedColor;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6002086
    // RVA   : 0xD10D90   Offset: 0xD10190   Length: 0x75
    private void Start()
    {
        long lVar1;
        byte[] local_18 = new byte[16];
        lVar1 = Component.get_transform(this,0);
        if (lVar1 != null) {
          lVar1 = Transform.Find(lVar1,"Icon",0);
          if (lVar1 != null) {
            puVar2 = (uint64 *)Transform.get_localPosition(local_18,lVar1,0);
            this.originIconPos = *puVar2;
            *(uint32 *)(this + 112) = *(uint32 *)(puVar2 + 1);
            return;
          }
        }
    }

    // Token : 0x6002087
    // RVA   : 0xD10E10   Offset: 0xD10210   Length: 0x694
    private void Update()
    {
        var pStatics_9c80 = *(int64*)(DAT_181d99c80 + 184);
        var pStatics_9d00 = *(int64*)(DAT_181d99d00 + 184);
        long lVar1;
        bool cVar2;
        int iVar3;
        ulong uVar4;
        long lVar5;
        ulong uVar6;
        ulong uVar7;
        uint[] local_res8 = new uint[2];
        uint[] local_res18 = new uint[2];
        uint local_38;
        uint uStack_34;
        uint uStack_30;
        uint32 uStack_2c;
        local_res18[0] = 0;
        if (!this.inited) {
          this.inited = 1;
          ReadBookTextController.Init(this,0);
        }
        uVar7 = *(uint64 *)(*(int64 *)(DAT_181d8b790 + 184) + 72);
        uVar4 = Component.get_gameObject(this,0);
        cVar2 = Object.op_Equality(uVar7,uVar4,0);
        if (cVar2) {
          lVar5 = Component.GetComponent(this,DAT_181d95560);
          uVar7 = "未知";
          if (this.seen) {
            lVar1 = this.textData;
            if (lVar1 == null) throw; // [null/range check failed]
            local_res8[0] = 0;
            uVar7 = "";
            if (!lVar1.simpleText) {
              uVar7 = lVar1.fullName;
              uVar4 = "red";
              if (!lVar1.negative) {
                uVar4 = "green";
              }
              uVar4 = String.Format("\n<color={0}><i><size=14>{1}</size></i></color>",uVar4,lVar1.describe,0);
              uVar7 = String.Concat(uVar7,uVar4,0);
            }
            if ((lVar1.exp != null.0) && (!lVar1.simpleText)) {
              local_res8[0] = ReadBookTextTypeData.GetExp(lVar1,0);
              uVar4 = Single.ToString(local_res8,"+0;-0;0",0);
              uVar7 = String.Concat(uVar7,"\n经验 ",uVar4,0);
            }
            if (lVar1.costPatient != null) {
              cVar2 = FUN_18171e540(uVar7,"",0);
              uVar4 = "\n";
              if (cVar2) {
                uVar4 = "";
              }
              uVar6 = Int32.ToString(lVar1 + 60,0);
              uVar7 = String.Concat(uVar7,uVar4,"消耗耐心 ",uVar6,0);
            }
          }
          if (lVar5 == null) throw; // [null/range check failed]
          lVar5.fullName = uVar7;
        }
        lVar5 = Component.get_transform(this,0);
        if (((lVar5 == null) || (lVar5 = Transform.Find(lVar5,"Icon",0)) == null) ||
           (lVar5 = Component.get_gameObject(lVar5,0)) == null) throw; // [null/range check failed]
        cVar2 = GameObject.get_activeSelf(lVar5,0);
        if (cVar2) {
          lVar5 = Component.get_transform(this,0);
          if (((lVar5 == null) || (lVar5 = Transform.Find(lVar5,"Icon",0)) == null) ||
             (lVar5 = Transform.Find(lVar5,"Text",0)) == null) throw; // [null/range check failed]
          uVar7 = Component.GetComponent(lVar5,DAT_181d96160);
          lVar5 = this.textData;
          if (lVar5 == null) throw; // [null/range check failed]
          if (lVar5.exp == null.0) {
            uVar4 = Int32.ToString(lVar5 + 56,"#;-#;0",0);
          }
          else {
            local_res18[0] = ReadBookTextTypeData.GetExp(lVar5,0);
            uVar4 = Single.ToString(local_res18,"#;-#;0",0);
          }
          LTLocalization.SetText(uVar7,uVar4,0);
          if (this.textData == null) throw; // [null/range check failed]
          if (this.textData.exp != null.0) {
            lVar5 = Component.get_transform(this,0);
            if (((lVar5 == null) || (lVar5 = Transform.Find(lVar5,"Icon",0)) == null) ||
               (lVar5 = Transform.Find(lVar5,"Text",0)) == null) throw; // [null/range check failed]
            lVar5 = Component.GetComponent(lVar5,DAT_181d96160);
            if ((this.textData == null) ||
               (iVar3 = Mathf.RoundToInt(ABS(this.textData.exp) * 0.1,0),
               lVar5 == null)) throw; // [null/range check failed]
            Text.set_fontSize(lVar5,iVar3 + 15,0);
          }
        }
        plVar8 = (int64 *)Component.GetComponent(this,DAT_181d94460);
        if ((*pStatics_9c80 == 0) ||
           (lVar5 = *(int64 *)(*pStatics_9c80 + 88)) == null)
        throw; // [null/range check failed]
        if ((lVar5.fullName < 1) &&
           ((this.seen && (!this.finished)))) {
          if (this.textData == null) throw; // [null/range check failed]
          cVar2 = FUN_18171e540(this.textData.showName,"缺",0);
          if (cVar2) goto LAB_180d11434;
          if (this.textData == null) throw; // [null/range check failed]
          if (this.textData.costPatient == null) {
        LAB_180d11423:
            puVar9 = (uint32 *)FUN_1810d3570(&local_38,0);
            local_38 = *puVar9;
            uStack_34 = puVar9[1];
            uStack_30 = puVar9[2];
            uStack_2c = puVar9[3];
          }
          else {
            lVar5 = FUN_18046c540(0);
            if ((lVar5 == null) || (this.textData == null)) throw; // [null/range check failed]
            if (this.textData.costPatient <= *(int *)(lVar5 + 124))
            goto LAB_180d11423;
            lVar5 = pStatics_9d00;
            local_38 = lVar5.exp;
            uStack_34 = lVar5.expRate;
            uStack_30 = lVar5.patient;
            uStack_2c = lVar5.costPatient;
          }
        }
        else {
        LAB_180d11434:
          lVar5 = pStatics_9d00;
          local_38 = lVar5.describe;
          uStack_34 = *(uint32 *)(lVar5 + 36);
          uStack_30 = lVar5.simpleText;
          uStack_2c = lVar5.minBookItemLv;
        }
        if (plVar8 != (int64 *)0) {
          (**(code **)(*plVar8 + 0x2a8))(plVar8,&local_38,*(uint64 *)(*plVar8 + 0x2b0));
          return;
        }
    }

    // Token : 0x6002088
    // RVA   : 0xD10C70   Offset: 0xD10070   Length: 0x114
    public void SeeText()
    {
        long lVar1;
        ulong uVar2;
        if (!this.seen) {
          this.seen = 1;
          lVar1 = Component.get_transform(this,0);
          if (lVar1 != null) {
            uVar2 = Transform.Find(lVar1,"Cover",0);
            uVar2 = ShortcutExtensions.DOScale(uVar2,0x40400000,0x3e99999a,0);
            TweenSettingsExtensions.SetUpdate(uVar2,1,DAT_181dc1db0);
            lVar1 = Component.get_transform(this,0);
            if (lVar1 != null) {
              lVar1 = Transform.Find(lVar1,"Cover",0);
              if (lVar1 != null) {
                uVar2 = Component.GetComponent(lVar1,DAT_181d94460);
                uVar2 = DOTweenModuleUI.DOFade(uVar2,0,0x3e99999a,0);
                TweenSettingsExtensions.SetUpdate(uVar2,1,DAT_181dc1c20);
                return;
              }
            }
          }
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
    }

    // Token : 0x6002089
    // RVA   : 0xD0EE90   Offset: 0xD0E290   Length: 0x1AA4
    public void ReadText()
    {
        var pStatics_2ee8 = *(int64*)(DAT_181d72ee8 + 184);
        var pStatics_3d40 = *(int64*)(DAT_181d73d40 + 184);
        var pStatics_9c80 = *(int64*)(DAT_181d99c80 + 184);
        bool cVar2;
        uint uVar3;
        long lVar5;
        ulong uVar7;
        long lVar8;
        long lVar9;
        ulong uVar10;
        int iVar12;
        int iVar14;
        int iVar16;
        uint uVar17;
        float fVar18;
        uint uVar19;
        uint uVar20;
        uint uVar21;
        float[] local_res8 = new float[2];
        ulong local_78;
        uint local_70;
        uint local_68;
        uint uStack_64;
        uint uStack_60;
        uint32 uStack_5c;
        local_res8[0] = 0.0;
        if (this.textData == null) throw; // [null/range check failed]
        cVar2 = FUN_18171e540(this.textData.showName,"缺",0);
        if (cVar2) {
          lVar5 = GameController._instance;
          lVar8 = Component.get_transform(this,0);
          if (lVar8 != null) {
            puVar6 = (uint64 *)Transform.get_position(&local_68,lVar8,0);
            uVar7 = *puVar6;
            uVar17 = *(uint32 *)(puVar6 + 1);
            puVar11 = (uint32 *)Color.get_red(&local_68,0);
            if (lVar5 != null) {
              local_68 = *puVar11;
              uStack_64 = puVar11[1];
              uStack_60 = puVar11[2];
              uStack_5c = puVar11[3];
              local_78 = uVar7;
              local_70 = uVar17;
              GameController.ShowTextAtPos(lVar5,"无法阅读",&local_78,20,&local_68,0);
              return;
            }
          }
          throw; // [null/range check failed]
        }
        this.finished = 1;
        plVar4 = (int64 *)Resources.Load("Sound/SoundEffect/PaperQuick");
        plVar15 = (int64 *)0;
        plVar13 = plVar15;
        if ((plVar4 != (int64 *)0) && (plVar13 = (int64 *)0, *plVar4 == DAT_181daf348)) {
          plVar13 = plVar4;
        }
        NGUITools.PlaySound(plVar13);
        if (this.textData == null) throw; // [null/range check failed]
        if (!this.textData.simpleText) {
          lVar5 = Component.get_transform(this);
          if (lVar5 == null) throw; // [null/range check failed]
          uVar7 = Transform.Find(lVar5,"NameText",0);
          ShortcutExtensions.DOScale(uVar7,0x40400000,0x3e99999a,0);
          lVar5 = Component.get_transform(this,0);
          if ((lVar5 == null) || (lVar5 = Transform.Find(lVar5,"NameText",0)) == null)
          throw; // [null/range check failed]
          uVar7 = Component.GetComponent(lVar5,DAT_181d96160);
          DOTweenModuleUI.DOFade(uVar7,0,0x3e99999a,0);
          if (this.textData == null) throw; // [null/range check failed]
          uVar7 = "Fail";
          if (!this.textData.negative) {
        LAB_180d0f2ea:
            uVar7 = "Success";
          }
        LAB_180d0f2f1:
          uVar7 = String.Concat("Sound/SoundEffect/",uVar7,0);
          plVar4 = (int64 *)Resources.Load(uVar7,0);
          plVar13 = plVar15;
          if ((plVar4 != (int64 *)0) && (*plVar4 == DAT_181daf348)) {
            plVar13 = plVar4;
          }
          NGUITools.PlaySound(plVar13,0x3f19999a,0);
        }
        else {
          lVar5 = Component.get_transform(this);
          if (lVar5 == null) throw; // [null/range check failed]
          lVar5 = Transform.Find(lVar5,"Icon",0);
          puVar6 = (uint64 *)Vector3.get_zero(&local_68,0);
          if (lVar5 == null) throw; // [null/range check failed]
          local_70 = *(uint32 *)(puVar6 + 1);
          local_78 = *puVar6;
          Transform.set_localScale(lVar5,&local_78,0);
          if (this.textData == null) throw; // [null/range check failed]
          iVar16 = this.textData.patient;
          if (iVar16 != 0) {
            uVar7 = "Fail";
            if (-1 < iVar16) goto LAB_180d0f2ea;
            goto LAB_180d0f2f1;
          }
        }
        lVar5 = this.textData;
        if (lVar5 == null) throw; // [null/range check failed]
        if (lVar5.exp != null.0) {
          lVar5 = new c.DisplayClass9_0(0);
          if (this.textData == null) throw; // [null/range check failed]
          local_res8[0] = (float)ReadBookTextTypeData.GetExp(this.textData,0);
          lVar8 = *pStatics_9c80;
          if (lVar8 == null) throw; // [null/range check failed]
          *(float *)(lVar8 + 120) = local_res8[0] + *(float *)(lVar8 + 120);
          if (*pStatics_2ee8 == 0) throw; // [null/range check failed]
          uVar7 = *(uint64 *)(*pStatics_2ee8 + 64);
          if (*pStatics_9c80 == 0) throw; // [null/range check failed]
          uVar10 = *(uint64 *)(*pStatics_9c80 + 136);
          uVar7 = GlobalData.AddChild(uVar7,uVar10,0);
          if (lVar5 == null) throw; // [null/range check failed]
          lVar5.showName = uVar7;
          if (lVar5.showName == null) throw; // [null/range check failed]
          lVar8 = GameObject.get_transform(lVar5.showName,0);
          lVar9 = Component.get_transform(this,0);
          if ((lVar9 == null) ||
             (puVar6 = (uint64 *)Transform.get_position(&local_68,lVar9,0), lVar8 == null))
          throw; // [null/range check failed]
          local_78 = *puVar6;
          local_70 = *(uint32 *)(puVar6 + 1);
          Transform.set_position(lVar8,&local_78,0);
          if (lVar5.showName == null) throw; // [null/range check failed]
          lVar8 = GameObject.GetComponent(lVar5.showName,DAT_181d71e80);
          lVar9 = Component.get_transform(this,0);
          if ((((lVar9 == null) || (lVar9 = Transform.Find(lVar9,"Icon",0)) == null) ||
              (lVar9 = Component.GetComponent(lVar9,DAT_181d94460)) == null) || (lVar8 == null))
          throw; // [null/range check failed]
          Image.set_sprite(lVar8,*(uint64 *)(lVar9 + 216),0);
          if (((lVar5.showName == null) ||
              (lVar8 = GameObject.get_transform(lVar5.showName,0)) == null) ||
             (lVar8 = Transform.Find(lVar8,"Text",0)) == null) throw; // [null/range check failed]
          uVar7 = Component.GetComponent(lVar8,DAT_181d96160);
          uVar10 = Single.ToString(local_res8,"#;-#;0",0);
          LTLocalization.SetText(uVar7,uVar10,0);
          if (((lVar5.showName == null) ||
              (lVar8 = GameObject.get_transform(lVar5.showName,0)) == null) ||
             (lVar8 = Transform.Find(lVar8,"Text",0)) == null) throw; // [null/range check failed]
          plVar4 = (int64 *)Component.GetComponent(lVar8,DAT_181d96160);
          if (local_res8[0] < 0.0) {
            lVar8 = pStatics_3d40;
            uVar17 = *(uint32 *)(lVar8 + 0x2f0);
            uVar19 = *(uint32 *)(lVar8 + 0x2f4);
            uVar20 = *(uint32 *)(lVar8 + 0x2f8);
            uVar21 = *(uint32 *)(lVar8 + 0x2fc);
          }
          else {
            lVar8 = pStatics_3d40;
            uVar17 = *(uint32 *)(lVar8 + 0x288);
            uVar19 = *(uint32 *)(lVar8 + 0x28c);
            uVar20 = *(uint32 *)(lVar8 + 0x290);
            uVar21 = *(uint32 *)(lVar8 + 0x294);
          }
          if (plVar4 == (int64 *)0) throw; // [null/range check failed]
          local_68 = uVar17;
          uStack_64 = uVar19;
          uStack_60 = uVar20;
          uStack_5c = uVar21;
          (**(code **)(*plVar4 + 0x2a8))(plVar4,&local_68,*(uint64 *)(*plVar4 + 0x2b0));
          if (lVar5.showName == null) throw; // [null/range check failed]
          uVar7 = GameObject.get_transform(lVar5.showName,0);
          if ((((*pStatics_9c80 == 0) ||
               (lVar8 = *(int64 *)(*pStatics_9c80 + 48)) == null) ||
              (lVar8 = GameObject.get_transform(lVar8,0)) == null) ||
             (lVar8 = Transform.Find(lVar8,"TotalExp",0)) == null) throw; // [null/range check failed]
          puVar6 = (uint64 *)Transform.get_position(&local_68,lVar8,0);
          local_78 = *puVar6;
          local_70 = *(uint32 *)(puVar6 + 1);
          ShortcutExtensions.DOMove(uVar7,&local_78,0x3f800000,0,0);
          if (lVar5.showName == null) throw; // [null/range check failed]
          uVar7 = GameObject.get_transform(lVar5.showName,0);
          uVar7 = ShortcutExtensions.DOScale(uVar7,0,0x3e800000,0);
          uVar7 = TweenSettingsExtensions.SetDelay(uVar7,0x3f400000,DAT_181dc0c60);
          uVar10 = new OnTooltipCB(lVar5,DAT_181dab548,0);
          TweenSettingsExtensions.OnComplete(uVar7,uVar10,DAT_181dc01d0);
          lVar5 = this.textData;
          if (lVar5 == null) throw; // [null/range check failed]
          if (0.0 < lVar5.exp) {
            plVar4 = (int64 *)Resources.Load("Sound/SoundEffect/NoticeLittleLittle",0);
            plVar13 = plVar15;
            if ((plVar4 != (int64 *)0) && (*plVar4 == DAT_181daf348)) {
              plVar13 = plVar4;
            }
            NGUITools.PlaySound(plVar13,0);
            lVar5 = this.textData;
            if (lVar5 == null) throw; // [null/range check failed]
          }
        }
        if (lVar5.patient != null) {
          lVar5 = new c.DisplayClass9_0(0);
          if ((this.textData == null) || (*pStatics_9c80 == 0))
          throw; // [null/range check failed]
          piVar1 = (int *)(*pStatics_9c80 + 124);
          *piVar1 = *piVar1 + this.textData.patient;
          if (*pStatics_2ee8 == 0) throw; // [null/range check failed]
          uVar7 = *(uint64 *)(*pStatics_2ee8 + 64);
          if (*pStatics_9c80 == 0) throw; // [null/range check failed]
          uVar10 = *(uint64 *)(*pStatics_9c80 + 136);
          uVar7 = GlobalData.AddChild(uVar7,uVar10,0);
          if (lVar5 == null) throw; // [null/range check failed]
          lVar5.showName = uVar7;
          if (lVar5.showName == null) throw; // [null/range check failed]
          lVar8 = GameObject.get_transform(lVar5.showName,0);
          lVar9 = Component.get_transform(this,0);
          if ((lVar9 == null) ||
             (puVar6 = (uint64 *)Transform.get_position(&local_68,lVar9,0), lVar8 == null))
          throw; // [null/range check failed]
          local_78 = *puVar6;
          local_70 = *(uint32 *)(puVar6 + 1);
          Transform.set_position(lVar8,&local_78,0);
          if ((lVar5.showName == null) ||
             (lVar8 = GameObject.GetComponent(lVar5.showName,DAT_181d71e80)) == null)
          throw; // [null/range check failed]
          Image.set_sprite(lVar8,this.pantientIconSprite,0);
          if (((lVar5.showName == null) ||
              (lVar8 = GameObject.get_transform(lVar5.showName,0)) == null) ||
             (lVar8 = Transform.Find(lVar8,"Text",0)) == null) throw; // [null/range check failed]
          uVar7 = Component.GetComponent(lVar8,DAT_181d96160);
          if (this.textData == null) throw; // [null/range check failed]
          uVar10 = Int32.ToString(this.textData + 56,"#;-#;0",0);
          LTLocalization.SetText(uVar7,uVar10,0);
          if (((lVar5.showName == null) ||
              (lVar8 = GameObject.get_transform(lVar5.showName,0)) == null) ||
             (lVar8 = Transform.Find(lVar8,"Text",0)) == null) throw; // [null/range check failed]
          plVar4 = (int64 *)Component.GetComponent(lVar8,DAT_181d96160);
          if (this.textData == null) throw; // [null/range check failed]
          if (this.textData.patient < 0) {
            lVar8 = pStatics_3d40;
            uVar17 = *(uint32 *)(lVar8 + 0x2f0);
            uVar19 = *(uint32 *)(lVar8 + 0x2f4);
            uVar20 = *(uint32 *)(lVar8 + 0x2f8);
            uVar21 = *(uint32 *)(lVar8 + 0x2fc);
          }
          else {
            lVar8 = pStatics_3d40;
            uVar17 = *(uint32 *)(lVar8 + 0x288);
            uVar19 = *(uint32 *)(lVar8 + 0x28c);
            uVar20 = *(uint32 *)(lVar8 + 0x290);
            uVar21 = *(uint32 *)(lVar8 + 0x294);
          }
          if (plVar4 == (int64 *)0) throw; // [null/range check failed]
          local_68 = uVar17;
          uStack_64 = uVar19;
          uStack_60 = uVar20;
          uStack_5c = uVar21;
          (**(code **)(*plVar4 + 0x2a8))(plVar4,&local_68,*(uint64 *)(*plVar4 + 0x2b0));
          if (lVar5.showName == null) throw; // [null/range check failed]
          uVar7 = GameObject.get_transform(lVar5.showName,0);
          if ((((*pStatics_9c80 == 0) ||
               (lVar8 = *(int64 *)(*pStatics_9c80 + 48)) == null) ||
              (lVar8 = GameObject.get_transform(lVar8,0)) == null) ||
             (lVar8 = Transform.Find(lVar8,"Patient",0)) == null) throw; // [null/range check failed]
          puVar6 = (uint64 *)Transform.get_position(&local_68,lVar8,0);
          local_78 = *puVar6;
          local_70 = *(uint32 *)(puVar6 + 1);
          ShortcutExtensions.DOMove(uVar7,&local_78,0x3f800000,0,0);
          if (lVar5.showName == null) throw; // [null/range check failed]
          uVar7 = GameObject.get_transform(lVar5.showName,0);
          uVar7 = ShortcutExtensions.DOScale(uVar7,0,0x3f000000,0);
          uVar7 = TweenSettingsExtensions.SetDelay(uVar7,0x3f000000,DAT_181dc0c60);
          uVar10 = new OnTooltipCB(lVar5,DAT_181dab5c8,0);
          TweenSettingsExtensions.OnComplete(uVar7,uVar10,DAT_181dc01d0);
        }
        if (*pStatics_9c80 != 0) {
          piVar1 = (int *)(*pStatics_9c80 + 132);
          *piVar1 = *piVar1 + 1;
          lVar5 = *pStatics_9c80;
          if (lVar5 != null) {
            iVar16 = -1;
            do {
              iVar12 = this.column + iVar16;
              if ((-1 < iVar12) && (iVar12 < *(int *)(lVar5 + 112))) {
                iVar12 = -1;
                do {
                  iVar14 = this.row + iVar12;
                  if ((-1 < iVar14) && (iVar14 < *(int *)(lVar5 + 116))) {
                    if ((lVar5.enterAreaChallengeHero == null) ||
                       ((lVar8 = FUN_180127f90(lVar5.enterAreaChallengeHero,
                                               (int64)(this.column + iVar16),
                                               (int64)iVar14), lVar8 == null ||
                        (lVar8 = GameObject.GetComponent(lVar8,DAT_181d72ab8)) == null)))
                    throw; // [null/range check failed]
                    ReadBookTextController.SeeText(lVar8,0);
                  }
                  iVar12 = iVar12 + 1;
                } while (iVar12 < 2);
              }
              iVar16 = iVar16 + 1;
            } while (iVar16 < 2);
            lVar5 = Component.get_transform(this,0);
            if ((lVar5 != null) &&
               (plVar4 = (int64 *)Component.GetComponent(lVar5,DAT_181d94460),
               plVar4 != (int64 *)0)) {
              (**(code **)(*plVar4 + 0x2c8))(plVar4,0,*(uint64 *)(*plVar4 + 0x2d0));
              if (this.textData != null) {
                lVar5 = this.textData.showName;
                if (lVar5 == null) {
                  return;
                }
                uVar3 = PrivateImplementationDetails.ComputeStringHash(lVar5,0);
                if (uVar3 < 0x317dfa64) {
                  if (uVar3 < 0x125b2797) {
                    if (uVar3 != 0xba06091) {
                      if (uVar3 != 0x125b2796) {
                        return;
                      }
                      cVar2 = FUN_18171e540(lVar5,"列",0);
                      if (!cVar2) {
                        return;
                      }
                      ReadBookTextController.ReadSameColumn(this,0);
                      return;
                    }
                    cVar2 = FUN_18171e540(lVar5,"明",0);
                    if (!cVar2) {
                      return;
                    }
                    iVar16 = -3;
                    do {
                      iVar12 = this.column + iVar16;
                      if (-1 < iVar12) {
                        lVar5 = FUN_18046c540(0);
                        if (lVar5 == null) throw; // [null/range check failed]
                        if (iVar12 < *(int *)(lVar5 + 112)) {
                          iVar12 = -3;
                          do {
                            iVar14 = this.row + iVar12;
                            if (-1 < iVar14) {
                              lVar5 = FUN_18046c540(0);
                              if (lVar5 == null) throw; // [null/range check failed]
                              if (iVar14 < *(int *)(lVar5 + 116)) {
                                lVar5 = FUN_18046c540(0);
                                if ((((lVar5 == null) || (lVar5.enterAreaChallengeHero == null)) ||
                                    (lVar5 = FUN_180127f90(lVar5.enterAreaChallengeHero,
                                                           (int64)(this.column + iVar16),
                                                           (int64)(this.row + iVar12)),
                                    lVar5 == null)) ||
                                   (lVar5 = GameObject.GetComponent(lVar5,DAT_181d72ab8)) == null)
                                throw; // [null/range check failed]
                                ReadBookTextController.SeeText(lVar5,0);
                              }
                            }
                            iVar12 = iVar12 + 1;
                          } while (iVar12 < 4);
                        }
                      }
                      iVar16 = iVar16 + 1;
                      if (3 < iVar16) {
                        return;
                      }
                    } while( true );
                  }
                  if (uVar3 == 0x1e29d60d) {
                    cVar2 = FUN_18171e540(lVar5,"通",0);
                    if (!cVar2) {
                      return;
                    }
                    ReadBookTextController.ReadSameColumn(this,0);
        LAB_180d101a9:
                    ReadBookTextController.ReadSameRow(this,0);
                    return;
                  }
                  if (uVar3 != 0x317dfa63) {
                    return;
                  }
                  cVar2 = FUN_18171e540(lVar5,"破",0);
                  if (!cVar2) {
                    return;
                  }
                  uVar7 = Component.get_gameObject(this,0);
                  plVar4 = (int64 *)Resources.Load("SpeEffect/InkExplosion",0);
                  if ((plVar4 != (int64 *)0) && (*plVar4 == DAT_181d72e60)) {
                    plVar15 = plVar4;
                  }
                  uVar7 = GlobalData.AddChild(uVar7,plVar15,0);
                  this.newObj = uVar7;
                  if ((this.newObj != null) &&
                     (lVar5 = GameObject.GetComponent(this.newObj,DAT_181dc72f8),
                     lVar5 != null)) {
                    fVar18 = (float)AudioSource.get_volume(lVar5,0);
                    AudioSource.set_volume
                              (lVar5,fVar18 * *(float *)(*(int64 *)(DAT_181d72d50 + 184) + 16),0);
                    iVar16 = -1;
                    do {
                      iVar12 = this.column + iVar16;
                      if (-1 < iVar12) {
                        lVar5 = FUN_18046c540(0);
                        if (lVar5 == null) break;
                        if (iVar12 < *(int *)(lVar5 + 112)) {
                          iVar12 = -1;
                          do {
                            iVar14 = this.row + iVar12;
                            if (-1 < iVar14) {
                              lVar5 = FUN_18046c540(0);
                              if (lVar5 == null) throw; // [null/range check failed]
                              if (iVar14 < *(int *)(lVar5 + 116)) {
                                lVar5 = FUN_18046c540(0);
                                lVar8 = FUN_18046c540(0);
                                if (((lVar8 == null) || (*(int64 *)(lVar8 + 72) == 0)) ||
                                   (uVar7 = FUN_180127f90(*(int64 *)(lVar8 + 72),
                                                          (int64)(this.column + iVar16),
                                                          (int64)(this.row + iVar12)),
                                   lVar5 == null)) throw; // [null/range check failed]
                                uVar7 = ReadBookController.SeeAndReadText(lVar5,uVar7,0);
                                FUN_180d8c2e0(this,uVar7,0);
                              }
                            }
                            iVar12 = iVar12 + 1;
                          } while (iVar12 < 2);
                        }
                      }
                      iVar16 = iVar16 + 1;
                      if (1 < iVar16) {
                        return;
                      }
                    } while( true );
                  }
                }
                else if (uVar3 < 0x7130a4b7) {
                  if (uVar3 == 0x6d8fa9d7) {
                    cVar2 = FUN_18171e540(lVar5,"注",0);
                    if (!cVar2) {
                      return;
                    }
                    iVar16 = -1;
                    do {
                      iVar12 = this.column + iVar16;
                      if (-1 < iVar12) {
                        lVar5 = FUN_18046c540(0);
                        if (lVar5 == null) throw; // [null/range check failed]
                        if (iVar12 < *(int *)(lVar5 + 112)) {
                          iVar12 = -1;
                          do {
                            iVar14 = this.row + iVar12;
                            if (-1 < iVar14) {
                              lVar5 = FUN_18046c540(0);
                              if (lVar5 == null) throw; // [null/range check failed]
                              if (iVar14 < *(int *)(lVar5 + 116)) {
                                lVar5 = FUN_18046c540(0);
                                if ((((lVar5 == null) || (lVar5.enterAreaChallengeHero == null)) ||
                                    (lVar5 = FUN_180127f90(lVar5.enterAreaChallengeHero,
                                                           (int64)(this.column + iVar16),
                                                           (int64)(this.row + iVar12)),
                                    lVar5 == null)) ||
                                   (lVar5 = GameObject.GetComponent(lVar5,DAT_181d72ab8)) == null)
                                throw; // [null/range check failed]
                                ReadBookTextController.ChangeExpRate(lVar5,0x3f800000,1,0);
                              }
                            }
                            iVar12 = iVar12 + 1;
                          } while (iVar12 < 2);
                        }
                      }
                      iVar16 = iVar16 + 1;
                      if (1 < iVar16) {
                        return;
                      }
                    } while( true );
                  }
                  if (uVar3 != 0x7130a4b6) {
                    return;
                  }
                  cVar2 = FUN_18171e540(lVar5,"迷",0);
                  if (!cVar2) {
                    return;
                  }
                  lVar5 = FUN_18046c0a0(0);
                  lVar8 = Component.get_transform(this,0);
                  if (lVar8 != null) {
                    puVar6 = (uint64 *)Transform.get_position(&local_68,lVar8,0);
                    uVar7 = *puVar6;
                    uVar17 = *(uint32 *)(puVar6 + 1);
                    puVar11 = (uint32 *)Color.get_red(&local_68,0);
                    if (lVar5 != null) {
                      local_68 = *puVar11;
                      uStack_64 = puVar11[1];
                      uStack_60 = puVar11[2];
                      uStack_5c = puVar11[3];
                      local_78 = uVar7;
                      local_70 = uVar17;
                      GameController.ShowTextAtPos(lVar5,"<i>全场经验-10%</i>",&local_78,20,&local_68,0);
                      lVar5 = 32;
                      while( true ) {
                        if ((*pStatics_9c80 == 0) ||
                           (lVar8 = *(int64 *)(*pStatics_9c80 + 80),
                           lVar8 == null)) break;
                        uVar3 = (uint32)plVar15;
                        if (*(int *)(lVar8 + 24) <= (int)uVar3) {
                          return;
                        }
                        if ((*pStatics_9c80 == 0) ||
                           (lVar8 = *(int64 *)(*pStatics_9c80 + 80),
                           lVar8 == null)) break;
                        if (*(uint32 *)(lVar8 + 24) <= uVar3) {
                          ThrowHelper.ThrowArgumentOutOfRangeException(0);
                        }
                        lVar8 = *(int64 *)(lVar5 + *(int64 *)(lVar8 + 16));
                        if ((lVar8 == null) ||
                           (lVar8 = GameObject.GetComponent(lVar8,DAT_181d72ab8)) == null) break;
                        lVar8 = *(int64 *)(lVar8 + 32);
                        if (lVar8 == null) {
                          // WARNING: Subroutine does not return
                          FUN_1800d6620();
                        }
                        uVar17 = Mathf.Max(0,*(float *)(lVar8 + 52) - 0.1,0);
                        *(uint32 *)(lVar8 + 52) = uVar17;
                        plVar15 = (int64 *)(uint64)(uVar3 + 1);
                        lVar5 = lVar5 + 8;
                      }
                    }
                  }
                }
                else {
                  if (uVar3 != 0xb77a1455) {
                    if (uVar3 == 0xba2612a1) {
                      cVar2 = FUN_18171e540(lVar5,"难",0);
                      if (!cVar2) {
                        return;
                      }
                      iVar16 = -1;
                      do {
                        iVar12 = this.column + iVar16;
                        if (-1 < iVar12) {
                          lVar5 = FUN_18046c540(0);
                          if (lVar5 == null) throw; // [null/range check failed]
                          if (iVar12 < *(int *)(lVar5 + 112)) {
                            iVar12 = -1;
                            do {
                              iVar14 = this.row + iVar12;
                              if (-1 < iVar14) {
                                lVar5 = FUN_18046c540(0);
                                if (lVar5 == null) throw; // [null/range check failed]
                                if (iVar14 < *(int *)(lVar5 + 116)) {
                                  lVar5 = FUN_18046c540(0);
                                  if ((((lVar5 == null) || (lVar5.enterAreaChallengeHero == null)) ||
                                      (lVar5 = FUN_180127f90(lVar5.enterAreaChallengeHero,
                                                             (int64)(this.column + iVar16)
                                                             ,(int64)
                                                              (this.row + iVar12)),
                                      lVar5 == null)) ||
                                     (lVar5 = GameObject.GetComponent(lVar5,DAT_181d72ab8)) == null)
                                  throw; // [null/range check failed]
                                  ReadBookTextController.ChangeExpRate(lVar5,0xbf000000,1,0);
                                }
                              }
                              iVar12 = iVar12 + 1;
                            } while (iVar12 < 2);
                          }
                        }
                        iVar16 = iVar16 + 1;
                        if (1 < iVar16) {
                          return;
                        }
                      } while( true );
                    }
                    if (uVar3 != 0xc835e6ab) {
                      return;
                    }
                    cVar2 = FUN_18171e540(lVar5,"行",0);
                    if (!cVar2) {
                      return;
                    }
                    goto LAB_180d101a9;
                  }
                  cVar2 = FUN_18171e540(lVar5,"纲",0);
                  if (!cVar2) {
                    return;
                  }
                  lVar5 = FUN_18046c0a0(0);
                  lVar8 = Component.get_transform(this,0);
                  if (lVar8 != null) {
                    puVar6 = (uint64 *)Transform.get_position(&local_68,lVar8,0);
                    uVar7 = *puVar6;
                    uVar17 = *(uint32 *)(puVar6 + 1);
                    puVar11 = (uint32 *)Color.get_green(&local_68,0);
                    if (lVar5 != null) {
                      local_68 = *puVar11;
                      uStack_64 = puVar11[1];
                      uStack_60 = puVar11[2];
                      uStack_5c = puVar11[3];
                      local_78 = uVar7;
                      local_70 = uVar17;
                      GameController.ShowTextAtPos(lVar5,"<i>全场经验+10%</i>",&local_78,20,&local_68,0);
                      lVar5 = 32;
                      while( true ) {
                        if ((*pStatics_9c80 == 0) ||
                           (lVar8 = *(int64 *)(*pStatics_9c80 + 80),
                           lVar8 == null)) break;
                        uVar3 = (uint32)plVar15;
                        if (*(int *)(lVar8 + 24) <= (int)uVar3) {
                          return;
                        }
                        if ((*pStatics_9c80 == 0) ||
                           (lVar8 = *(int64 *)(*pStatics_9c80 + 80),
                           lVar8 == null)) break;
                        if (*(uint32 *)(lVar8 + 24) <= uVar3) {
                          ThrowHelper.ThrowArgumentOutOfRangeException(0);
                        }
                        lVar8 = *(int64 *)(lVar5 + *(int64 *)(lVar8 + 16));
                        if ((lVar8 == null) ||
                           (lVar8 = GameObject.GetComponent(lVar8,DAT_181d72ab8)) == null) break;
                        lVar8 = *(int64 *)(lVar8 + 32);
                        if (lVar8 == null) {
                          // WARNING: Subroutine does not return
                          FUN_1800d6620();
                        }
                        uVar17 = Mathf.Max(0,*(float *)(lVar8 + 52) + 0.1,0);
                        *(uint32 *)(lVar8 + 52) = uVar17;
                        plVar15 = (int64 *)(uint64)(uVar3 + 1);
                        lVar5 = lVar5 + 8;
                      }
                    }
                  }
                }
              }
            }
          }
        }
    }

    // Token : 0x600208A
    // RVA   : 0xD0DA10   Offset: 0xD0CE10   Length: 0x1D3
    public void ChangeExpRate(float changeRate, bool showText)
    {
        ulong uVar1;
        long lVar2;
        ulong uVar3;
        long lVar4;
        uint uVar7;
        float[] local_res8 = new float[2];
        ulong local_58;
        uint local_50;
        uint local_48;
        uint uStack_44;
        uint uStack_40;
        uint32 uStack_3c;
        lVar2 = this.textData;
        if (lVar2 != null) {
          uVar7 = Mathf.Max(0,lVar2.expRate + changeRate,0);
          lVar2.expRate = uVar7;
          if (((!showText) || (this.finished)) ||
             (!this.seen)) {
            return;
          }
          lVar2 = FUN_18046c0a0(0);
          local_res8[0] = changeRate * 100.0;
          uVar3 = Single.ToString(local_res8,"+0;-0;0",0);
          uVar3 = String.Concat("<i>",uVar3,"%</i>",0);
          lVar4 = Component.get_transform(this,0);
          if (lVar4 != null) {
            puVar5 = (uint64 *)Transform.get_position(&local_58,lVar4,0);
            uVar1 = *puVar5;
            uVar7 = *(uint32 *)(puVar5 + 1);
            if (changeRate < 0.0) {
              puVar6 = (uint32 *)Color.get_red(&local_48,0);
            }
            else {
              puVar6 = (uint32 *)Color.get_green();
            }
            local_48 = *puVar6;
            uStack_44 = puVar6[1];
            uStack_40 = puVar6[2];
            uStack_3c = puVar6[3];
            if (lVar2 != null) {
              local_58 = uVar1;
              local_50 = uVar7;
              GameController.ShowTextAtPos(lVar2,uVar3,&local_58,18,&local_48,0);
              return;
            }
          }
        }
    }

    // Token : 0x600208B
    // RVA   : 0xD0E770   Offset: 0xD0DB70   Length: 0x387
    public void ReadSameColumn()
    {
        var pStatics_9c80 = *(int64*)(DAT_181d99c80 + 184);
        var pStatics_be88 = *(int64*)(DAT_181dabe88 + 184);
        long lVar1;
        ulong uVar2;
        long lVar4;
        long lVar5;
        uint uVar7;
        float fVar9;
        uint local_28;
        uint local_24;
        uint local_20;
        uVar2 = Component.get_gameObject(this,0);
        plVar3 = (int64 *)Resources.Load("SpeEffect/InkLine",0);
        plVar8 = (int64 *)0;
        plVar6 = plVar8;
        if ((plVar3 != (int64 *)0) && (plVar6 = (int64 *)0, *plVar3 == DAT_181d72e60)) {
          plVar6 = plVar3;
        }
        uVar2 = GlobalData.AddChild(uVar2,plVar6,0);
        this.newObj = uVar2;
        if (this.newObj != null) {
          uVar2 = GameObject.get_transform(this.newObj,0);
          local_28 = 0x3e99999a;
          local_20 = 0x3f800000;
          local_24 = 0x42480000;
          ShortcutExtensions.DOScale(uVar2,&local_28,0x3f000000,0);
          if (this.newObj != null) {
            lVar4 = GameObject.GetComponent(this.newObj,DAT_181dc72f8);
            if (lVar4 != null) {
              fVar9 = (float)AudioSource.get_volume(lVar4,0);
              AudioSource.set_volume
                        (lVar4,fVar9 * *(float *)(*(int64 *)(DAT_181d72d50 + 184) + 16),0);
              while( true ) {
                if (*pStatics_9c80 == 0) throw; // [null/range check failed]
                uVar7 = (uint32)plVar8;
                if (*(int *)(*pStatics_9c80 + 116) <= (int)uVar7) break;
                lVar4 = *pStatics_9c80;
                if ((*pStatics_9c80 == 0) ||
                   (lVar5 = *(int64 *)(*pStatics_9c80 + 72)) == null)
                throw; // [null/range check failed]
                if (**(uint32 **)(lVar5 + 16) <= this.column) {
                  uVar2 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1800d65f0(uVar2,0);
                }
                lVar1 = *(int64 *)(*(uint32 **)(lVar5 + 16) + 4);
                if ((uint32)lVar1 <= uVar7) {
                  uVar2 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1800d65f0(uVar2,0);
                }
                uVar2 = *(uint64 *)
                         (lVar5 + 32 +
                         ((int)this.column * lVar1 + (int64)(int)uVar7) * 8);
                if (lVar4 == null) throw; // [null/range check failed]
                lVar5 = new WarpText_d__8(0,0);
                if (lVar5 == null) throw; // [null/range check failed]
                *(int64 *)(lVar5 + 40) = lVar4;
                *(uint64 *)(lVar5 + 32) = uVar2;
                FUN_180d8c2e0(this,lVar5,0);
                plVar8 = (int64 *)(uint64)(uVar7 + 1);
              }
              if (*pStatics_be88 != 0) {
                TimeScaleController.SetSlowTime
                          (*pStatics_be88,0x3e4ccccd,0x3e4ccccd,0);
                return;
              }
            }
          }
        }
    }

    // Token : 0x600208C
    // RVA   : 0xD0EB00   Offset: 0xD0DF00   Length: 0x387
    public void ReadSameRow()
    {
        var pStatics_9c80 = *(int64*)(DAT_181d99c80 + 184);
        var pStatics_be88 = *(int64*)(DAT_181dabe88 + 184);
        long lVar1;
        ulong uVar2;
        long lVar4;
        long lVar5;
        uint uVar7;
        float fVar9;
        uint local_28;
        uint local_24;
        uint local_20;
        uVar2 = Component.get_gameObject(this,0);
        plVar3 = (int64 *)Resources.Load("SpeEffect/InkLine",0);
        plVar8 = (int64 *)0;
        plVar6 = plVar8;
        if ((plVar3 != (int64 *)0) && (plVar6 = (int64 *)0, *plVar3 == DAT_181d72e60)) {
          plVar6 = plVar3;
        }
        uVar2 = GlobalData.AddChild(uVar2,plVar6,0);
        this.newObj = uVar2;
        if (this.newObj != null) {
          uVar2 = GameObject.get_transform(this.newObj,0);
          local_28 = 0x42480000;
          local_20 = 0x3f800000;
          local_24 = 0x3e99999a;
          ShortcutExtensions.DOScale(uVar2,&local_28,0x3f000000,0);
          if (this.newObj != null) {
            lVar4 = GameObject.GetComponent(this.newObj,DAT_181dc72f8);
            if (lVar4 != null) {
              fVar9 = (float)AudioSource.get_volume(lVar4,0);
              AudioSource.set_volume
                        (lVar4,fVar9 * *(float *)(*(int64 *)(DAT_181d72d50 + 184) + 16),0);
              while( true ) {
                if (*pStatics_9c80 == 0) throw; // [null/range check failed]
                uVar7 = (uint32)plVar8;
                if (*(int *)(*pStatics_9c80 + 112) <= (int)uVar7) break;
                lVar4 = *pStatics_9c80;
                if ((*pStatics_9c80 == 0) ||
                   (lVar5 = *(int64 *)(*pStatics_9c80 + 72)) == null)
                throw; // [null/range check failed]
                if (**(uint32 **)(lVar5 + 16) <= uVar7) {
                  uVar2 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1800d65f0(uVar2,0);
                }
                lVar1 = *(int64 *)(*(uint32 **)(lVar5 + 16) + 4);
                if ((uint32)lVar1 <= this.row) {
                  uVar2 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1800d65f0(uVar2,0);
                }
                uVar2 = *(uint64 *)
                         (lVar5 + 32 +
                         ((int)uVar7 * lVar1 + (int64)(int)this.row) * 8);
                if (lVar4 == null) throw; // [null/range check failed]
                lVar5 = new WarpText_d__8(0,0);
                if (lVar5 == null) throw; // [null/range check failed]
                *(int64 *)(lVar5 + 40) = lVar4;
                *(uint64 *)(lVar5 + 32) = uVar2;
                FUN_180d8c2e0(this,lVar5,0);
                plVar8 = (int64 *)(uint64)(uVar7 + 1);
              }
              if (*pStatics_be88 != 0) {
                TimeScaleController.SetSlowTime
                          (*pStatics_be88,0x3e4ccccd,0x3e4ccccd,0);
                return;
              }
            }
          }
        }
    }

    // Token : 0x600208D
    // RVA   : 0xD0DDB0   Offset: 0xD0D1B0   Length: 0x768
    public void Init()
    {
        var pStatics = *(int64*)(DAT_181d99d00 + 184);
        ulong uVar1;
        long lVar2;
        ulong uVar3;
        uint uVar6;
        uint uVar7;
        uint uVar8;
        uint uVar9;
        uint local_28;
        uint uStack_24;
        uint uStack_20;
        uint32 uStack_1c;
        if (this.textData != null) {
          if (!this.textData.simpleText) {
            lVar2 = Component.get_transform(this);
            if (((lVar2 != null) && (lVar2 = Transform.Find(lVar2,"Icon",0)) != null) &&
               (lVar2 = Component.get_gameObject(lVar2,0)) != null) {
              GameObject.SetActive(lVar2,0,0);
              lVar2 = Component.get_transform(this,0);
              if ((lVar2 != null) && (lVar2 = Transform.Find(lVar2,"NameText",0)) != null) {
                uVar3 = Component.GetComponent(lVar2,DAT_181d96160);
                if (this.textData != null) {
                  uVar1 = this.textData.showName;
                  LTLocalization.SetText(uVar3,uVar1,0);
                  lVar2 = Component.get_transform(this,0);
                  if ((lVar2 != null) && (lVar2 = Transform.Find(lVar2,"NameText",0)) != null) {
                    plVar4 = (int64 *)Component.GetComponent(lVar2,DAT_181d96160);
                    puVar5 = (uint32 *)Color.get_black(&local_28,0);
                    if (plVar4 != (int64 *)0) {
                      local_28 = *puVar5;
                      uStack_24 = puVar5[1];
                      uStack_20 = puVar5[2];
                      uStack_1c = puVar5[3];
                      (**(code **)(*plVar4 + 0x2a8))(plVar4,&local_28,*(uint64 *)(*plVar4 + 0x2b0));
                      lVar2 = Component.GetComponent(this,DAT_181d94460);
                      if (this.textData != null) {
                        if (!this.textData.negative) {
                          uVar3 = this.speGoodBack;
                        }
                        else {
                          uVar3 = this.speBadBack;
                        }
                        if (lVar2 != null) {
                          Image.set_sprite(lVar2,uVar3,0);
                          return;
                        }
                      }
                    }
                  }
                }
              }
            }
          }
          else {
            lVar2 = Component.get_transform(this);
            if ((lVar2 != null) && (lVar2 = Transform.Find(lVar2,"Icon",0)) != null) {
              lVar2 = Component.get_gameObject(lVar2,0);
              if (lVar2 != null) {
                GameObject.SetActive(lVar2,1,0);
                if (this.textData != null) {
                  if (this.textData.exp == null.0) {
                    lVar2 = Component.get_transform(this,0);
                    if (((lVar2 == null) || (lVar2 = Transform.Find(lVar2,"Icon",0)) == null) ||
                       (lVar2 = Component.GetComponent(lVar2,DAT_181d94460)) == null)
                    throw; // [null/range check failed]
                    Image.set_sprite(lVar2,this.pantientIconSprite,0);
                    lVar2 = Component.get_transform(this,0);
                    if (((lVar2 == null) || (lVar2 = Transform.Find(lVar2,"Icon",0)) == null) ||
                       (plVar4 = (int64 *)Component.GetComponent(lVar2,DAT_181d94460),
                       plVar4 == (int64 *)0)) throw; // [null/range check failed]
                    (**(code **)(*plVar4 + 0x408))(plVar4,*(uint64 *)(*plVar4 + 0x410));
                    lVar2 = Component.get_transform(this,0);
                    if (((lVar2 == null) || (lVar2 = Transform.Find(lVar2,"Icon",0)) == null) ||
                       (lVar2 = Component.GetComponent(lVar2,DAT_181d94f60)) == null)
                    throw; // [null/range check failed]
                    RectTransform.set_sizeDelta(lVar2,0x41a8000041a00000,0);
                    lVar2 = Component.get_transform(this,0);
                    if (((lVar2 == null) || (lVar2 = Transform.Find(lVar2,"Icon",0)) == null) ||
                       (lVar2 = Transform.Find(lVar2,"Text",0)) == null) throw; // [null/range check failed]
                    plVar4 = (int64 *)Component.GetComponent(lVar2,DAT_181d96160);
                    if (this.textData == null) throw; // [null/range check failed]
                    if (this.textData.patient < 0) {
                      lVar2 = pStatics;
                      uVar6 = *(uint32 *)(lVar2 + 16);
                      uVar7 = *(uint32 *)(lVar2 + 20);
                      uVar8 = *(uint32 *)(lVar2 + 24);
                      uVar9 = *(uint32 *)(lVar2 + 28);
                    }
                    else {
                      puVar5 = *(uint32 **)(DAT_181d99d00 + 184);
                      uVar6 = *puVar5;
                      uVar7 = puVar5[1];
                      uVar8 = puVar5[2];
                      uVar9 = puVar5[3];
                    }
                    if (plVar4 == (int64 *)0) throw; // [null/range check failed]
                    local_28 = uVar6;
                    uStack_24 = uVar7;
                    uStack_20 = uVar8;
                    uStack_1c = uVar9;
                    (**(code **)(*plVar4 + 0x2a8))(plVar4,&local_28,*(uint64 *)(*plVar4 + 0x2b0));
                    lVar2 = Component.GetComponent(this,DAT_181d94460);
                    if (this.textData == null) throw; // [null/range check failed]
                    if (this.textData.patient < 0) {
                      uVar3 = this.speBadBack;
                    }
                    else {
                      uVar3 = this.speGoodBack;
                    }
                  }
                  else {
                    lVar2 = Component.get_transform(this,0);
                    if ((lVar2 == null) || (lVar2 = Transform.Find(lVar2,"Icon",0)) == null)
                    throw; // [null/range check failed]
                    lVar2 = Component.GetComponent(lVar2,DAT_181d94460);
                    if (this.textData == null) throw; // [null/range check failed]
                    if (this.textData.exp < 20.0) {
                      uVar3 = this.expIconSprite;
                    }
                    else {
                      uVar3 = this.expGoodIconSprite;
                    }
                    if (lVar2 == null) throw; // [null/range check failed]
                    Image.set_sprite(lVar2,uVar3,0);
                    lVar2 = Component.get_transform(this,0);
                    if (((lVar2 == null) || (lVar2 = Transform.Find(lVar2,"Icon",0)) == null) ||
                       (plVar4 = (int64 *)Component.GetComponent(lVar2,DAT_181d94460),
                       plVar4 == (int64 *)0)) throw; // [null/range check failed]
                    (**(code **)(*plVar4 + 0x408))(plVar4,*(uint64 *)(*plVar4 + 0x410));
                    lVar2 = Component.get_transform(this,0);
                    if (((lVar2 == null) || (lVar2 = Transform.Find(lVar2,"Icon",0)) == null) ||
                       (lVar2 = Transform.Find(lVar2,"Text",0)) == null) throw; // [null/range check failed]
                    plVar4 = (int64 *)Component.GetComponent(lVar2,DAT_181d96160);
                    if (this.textData == null) throw; // [null/range check failed]
                    if (this.textData.exp < 0.0) {
                      lVar2 = pStatics;
                      uVar6 = *(uint32 *)(lVar2 + 16);
                      uVar7 = *(uint32 *)(lVar2 + 20);
                      uVar8 = *(uint32 *)(lVar2 + 24);
                      uVar9 = *(uint32 *)(lVar2 + 28);
                    }
                    else {
                      puVar5 = *(uint32 **)(DAT_181d99d00 + 184);
                      uVar6 = *puVar5;
                      uVar7 = puVar5[1];
                      uVar8 = puVar5[2];
                      uVar9 = puVar5[3];
                    }
                    if (plVar4 == (int64 *)0) throw; // [null/range check failed]
                    local_28 = uVar6;
                    uStack_24 = uVar7;
                    uStack_20 = uVar8;
                    uStack_1c = uVar9;
                    (**(code **)(*plVar4 + 0x2a8))(plVar4,&local_28,*(uint64 *)(*plVar4 + 0x2b0));
                    lVar2 = Component.GetComponent(this,DAT_181d94460);
                    if (this.textData == null) throw; // [null/range check failed]
                    if (this.textData.exp < 0.0) {
                      uVar3 = this.expBadBack;
                    }
                    else {
                      uVar3 = this.expGoodBack;
                    }
                  }
                  if (lVar2 != null) {
                    Image.set_sprite(lVar2,uVar3,0);
                    lVar2 = Component.get_transform(this,0);
                    if ((lVar2 != null) && (lVar2 = Transform.Find(lVar2,"NameText",0)) != null) {
                      plVar4 = (int64 *)Component.GetComponent(lVar2,DAT_181d96160);
                      puVar5 = (uint32 *)FUN_180d98fe0(&local_28,0);
                      if (plVar4 != (int64 *)0) {
                        local_28 = *puVar5;
                        uStack_24 = puVar5[1];
                        uStack_20 = puVar5[2];
                        uStack_1c = puVar5[3];
                        (**(code **)(*plVar4 + 0x2a8))(plVar4,&local_28,*(uint64 *)(*plVar4 + 0x2b0));
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

    // Token : 0x600208E
    // RVA   : 0xD10940   Offset: 0xD0FD40   Length: 0x32A
    public void Reset()
    {
        long lVar1;
        ulong local_28;
        uint local_20;
        uint local_18;
        uint uStack_14;
        uint uStack_10;
        uint32 uStack_c;
        this.finished = 0;
        this.seen = 0;
        lVar1 = Component.get_transform(this,0);
        if (lVar1 != null) {
          plVar2 = (int64 *)Component.GetComponent(lVar1,DAT_181d94460);
          if (plVar2 != (int64 *)0) {
            (**(code **)(*plVar2 + 0x2c8))(plVar2,1,*(uint64 *)(*plVar2 + 0x2d0));
            lVar1 = Component.get_transform(this,0);
            if (lVar1 != null) {
              lVar1 = Transform.Find(lVar1,"Cover",0);
              puVar3 = (uint64 *)Vector3.get_one(&local_18,0);
              if (lVar1 != null) {
                local_20 = *(uint32 *)(puVar3 + 1);
                local_28 = *puVar3;
                Transform.set_localScale(lVar1,&local_28,0);
                lVar1 = Component.get_transform(this,0);
                if (lVar1 != null) {
                  lVar1 = Transform.Find(lVar1,"Cover",0);
                  if (lVar1 != null) {
                    plVar2 = (int64 *)Component.GetComponent(lVar1,DAT_181d94460);
                    puVar4 = (uint32 *)FUN_1810d3570(&local_18,0);
                    if (plVar2 != (int64 *)0) {
                      local_18 = *puVar4;
                      uStack_14 = puVar4[1];
                      uStack_10 = puVar4[2];
                      uStack_c = puVar4[3];
                      (**(code **)(*plVar2 + 0x2a8))(plVar2,&local_18,*(uint64 *)(*plVar2 + 0x2b0));
                      lVar1 = Component.get_transform(this,0);
                      if (lVar1 != null) {
                        lVar1 = Transform.Find(lVar1,"Icon",0);
                        puVar3 = (uint64 *)Vector3.get_one(&local_18,0);
                        if (lVar1 != null) {
                          local_20 = *(uint32 *)(puVar3 + 1);
                          local_28 = *puVar3;
                          Transform.set_localScale(lVar1,&local_28,0);
                          lVar1 = Component.get_transform(this,0);
                          if (lVar1 != null) {
                            lVar1 = Transform.Find(lVar1,"Icon",0);
                            if (lVar1 != null) {
                              lVar1 = Transform.Find(lVar1,"Text",0);
                              if (lVar1 != null) {
                                plVar2 = (int64 *)Component.GetComponent(lVar1,DAT_181d96160);
                                puVar4 = (uint32 *)FUN_1810d3570(&local_18,0);
                                if (plVar2 != (int64 *)0) {
                                  local_18 = *puVar4;
                                  uStack_14 = puVar4[1];
                                  uStack_10 = puVar4[2];
                                  uStack_c = puVar4[3];
                                  (**(code **)(*plVar2 + 0x2a8))
                                            (plVar2,&local_18,*(uint64 *)(*plVar2 + 0x2b0));
                                  lVar1 = Component.get_transform(this,0);
                                  if (lVar1 != null) {
                                    lVar1 = Transform.Find(lVar1,"Icon",0);
                                    if (lVar1 != null) {
                                      local_20 = *(uint32 *)(this + 112);
                                      local_28 = this.originIconPos;
                                      Transform.set_localPosition(lVar1,&local_28,0);
                                      lVar1 = Component.get_transform(this,0);
                                      if (lVar1 != null) {
                                        lVar1 = Transform.Find(lVar1,"NameText",0);
                                        puVar3 = (uint64 *)Vector3.get_one(&local_18,0);
                                        if (lVar1 != null) {
                                          local_20 = *(uint32 *)(puVar3 + 1);
                                          local_28 = *puVar3;
                                          Transform.set_localScale(lVar1,&local_28,0);
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
                      }
                    }
                  }
                }
              }
            }
          }
        }
    }

    // Token : 0x600208F
    // RVA   : 0xD0DBF0   Offset: 0xD0CFF0   Length: 0x1B2
    public Color GetColor()
    {
        var pStatics_9c80 = *(int64*)(DAT_181d99c80 + 184);
        var pStatics_9d00 = *(int64*)(DAT_181d99d00 + 184);
        ulong uVar1;
        bool cVar2;
        long lVar3;
        byte[] local_18 = new byte[16];
        if ((*pStatics_9c80 != 0) &&
           (lVar3 = *(int64 *)(*pStatics_9c80 + 88)) != null) {
          if ((0 < *(int *)(lVar3 + 24)) ||
             ((*(char *)(param_2 + 40) == false || (*(char *)(param_2 + 41) != false)))) {
        LAB_180d0dd59:
            uVar1 = *(uint64 *)(pStatics_9d00 + 40);
            *this = ReadBookTextController.textGrayColor;
            this[1] = uVar1;
            return this;
          }
          if (*(int64 *)(param_2 + 32) != 0) {
            cVar2 = FUN_18171e540(*(uint64 *)(*(int64 *)(param_2 + 32) + 16),"缺",0);
            if (cVar2) goto LAB_180d0dd59;
            if (*(int64 *)(param_2 + 32) != 0) {
              if (*(int *)(*(int64 *)(param_2 + 32) + 60) != 0) {
                lVar3 = FUN_18046c540(0);
                if ((lVar3 == null) || (*(int64 *)(param_2 + 32) == 0)) throw; // [null/range check failed]
                if (*(int *)(lVar3 + 124) < *(int *)(*(int64 *)(param_2 + 32) + 60)) {
                  uVar1 = *(uint64 *)(pStatics_9d00 + 56);
                  *this = ReadBookTextController.textRedColor;
                  this[1] = uVar1;
                  return this;
                }
              }
              puVar4 = (uint64 *)FUN_1810d3570(local_18,0);
              uVar1 = puVar4[1];
              *this = *puVar4;
              this[1] = uVar1;
              return this;
            }
          }
        }
    }

    // Token : 0x6002090
    // RVA   : 0xD0E520   Offset: 0xD0D920   Length: 0x246
    public void OnClick()
    {
        var pStatics = *(int64*)(DAT_181d99c80 + 184);
        long lVar2;
        long lVar3;
        if ((*pStatics != 0) &&
           (lVar3 = *(int64 *)(*pStatics + 88)) != null) {
          if (0 < lVar3.fullName) {
            return;
          }
          if (!this.seen) {
            lVar3 = FUN_18046c0a0(0);
            if (lVar3 != null) {
              GameController.ShowTextOnMouse(lVar3,"未解锁",0);
              return;
            }
          }
          else {
            if (this.finished) {
              return;
            }
            lVar3 = this.textData;
            if (lVar3 != null) {
              if (lVar3.costPatient != null) {
                lVar2 = FUN_18046c540(0);
                if ((lVar2 == null) || (lVar3 = this.textData) == null)
                throw; // [null/range check failed]
                if (*(int *)(lVar2 + 124) < lVar3.costPatient) {
                  lVar3 = FUN_18046c0a0(0);
                  if (lVar3 != null) {
                    GameController.ShowTextOnMouse(lVar3,"耐心不足",0);
                    plVar4 = (int64 *)Resources.Load("Sound/SoundEffect/WrongClick",0);
                    plVar5 = (int64 *)0;
                    if ((plVar4 != (int64 *)0) && (*plVar4 == DAT_181daf348)) {
                      plVar5 = plVar4;
                    }
                    NGUITools.PlaySound(plVar5,0);
                    return;
                  }
                  throw; // [null/range check failed]
                }
              }
              if (!DAT_181e8fc5d) {
                il2cpp_runtime_class_init(&DAT_181d99c80);
                DAT_181e8fc5d = true;
                lVar3 = this.textData;
              }
              if ((lVar3 != null) && (*pStatics != 0)) {
                piVar1 = (int *)(*pStatics + 124);
                *piVar1 = *piVar1 - lVar3.costPatient;
                ReadBookTextController.ReadText(this,0);
                return;
              }
            }
          }
        }
    }

    // Token : 0x6002091
    // RVA   : 0x3A17B0   Offset: 0x3A0BB0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_18044ef50(this,0);
    }

    // Token : 0x6002092
    // RVA   : 0xD114B0   Offset: 0xD108B0   Length: 0x137
    private static void /*cctor*/()
    {
        var pStatics = *(int64*)(DAT_181d99d00 + 184);
        long lVar2;
        uint uVar3;
        ulong local_48;
        ulong uStack_40;
        ulong local_38;
        ulong uStack_30;
        ulong local_28;
        ulong uStack_20;
        ulong local_18;
        ulong uStack_10;
        local_48 = 0;
        uStack_40 = 0;
        Color.ctor(&local_48,0x3e4ccccd,0x3f119192,0x3ea8a8a9,0);
        uVar3 = 0;
        puVar1 = *(uint32 **)(DAT_181d99d00 + 184);
        *puVar1 = (uint32)local_48;
        puVar1[1] = local_48._4_4_;
        puVar1[2] = (uint32)uStack_40;
        puVar1[3] = uStack_40._4_4_;
        local_38 = 0;
        uStack_30 = 0;
        Color.ctor(&local_38,0x3ed8d8d9,0,0,0);
        lVar2 = pStatics;
        *(uint32 *)(lVar2 + 16) = (uint32)local_38;
        *(uint32 *)(lVar2 + 20) = local_38._4_4_;
        *(uint32 *)(lVar2 + 24) = (uint32)uStack_30;
        *(uint32 *)(lVar2 + 28) = uStack_30._4_4_;
        local_28 = 0;
        uStack_20 = 0;
        FUN_1809dc910(&local_28,0x3f000000,0x3f000000,0x3f000000,CONCAT44(uVar3,0x3f000000),0);
        lVar2 = pStatics;
        *(uint64 *)(lVar2 + 32) = local_28;
        *(uint64 *)(lVar2 + 40) = uStack_20;
        local_18 = 0;
        uStack_10 = 0;
        FUN_1809dc910(&local_18,0x3f333333,0x3f333333,0x3f333333,0x3f800000,0);
        lVar2 = pStatics;
        *(uint64 *)(lVar2 + 48) = local_18;
        *(uint64 *)(lVar2 + 56) = uStack_10;
    }

}
