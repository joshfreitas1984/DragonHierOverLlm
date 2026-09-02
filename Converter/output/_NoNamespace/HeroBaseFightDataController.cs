// ============================================================
// Type  : HeroBaseFightDataController
// Token : 0x20002B9
// ============================================================

public class HeroBaseFightDataController
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x400162D
    public HeroBaseFightData heroBaseFightData;

    // Token: 0x400162E
    public HeroData targetHero;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x600172B
    // RVA   : 0x8781B0   Offset: 0x8769B0   Length: 0x173C
    public void RefreshData()
    {
        var pStatics = *(int64*)(DAT_181d4ef00 + 184);
        int iVar1;
        long lVar2;
        int iVar3;
        int iVar4;
        long lVar5;
        ulong uVar6;
        ulong uVar7;
        ulong uVar8;
        ulong uVar9;
        uint uVar10;
        float fVar11;
        float fVar12;
        float fVar13;
        float[] local_res8 = new float[2];
        int[] local_res18 = new int[2];
        uint[] local_res20 = new uint[2];
        int[] local_88 = new int[20];
        local_res8[0] = 0.0;
        switch(this.heroBaseFightData) {
        case 0:
          lVar5 = Component.get_transform(this,0);
          if ((lVar5 == null) || (lVar5 = Transform.Find(lVar5,"Text",0)) == null)
          goto LAB_1808798e0;
          uVar6 = Component.GetComponent(lVar5,DAT_181d6d8c0);
          if ((this.targetHero == null) ||
             (lVar5 = this.targetHero.totalAddData) == null)
          goto LAB_1808798e0;
          local_res8[0] = (float)HeroSpeAddData.Get(lVar5,60);
          local_res8[0] = local_res8[0] * 100.0;
          uVar7 = Single.ToString(local_res8,"0.##",0);
          uVar7 = String.Concat("伤害 ",uVar7,"%",0);
          LTLocalization.SetText(uVar6,uVar7,0);
          lVar5 = Component.GetComponent(this,DAT_181d6ccc0);
          uVar7 = FUN_180004500(DAT_181d63120);
          uVar6 = "增加基础伤害";
          break;
        case 1:
          lVar5 = Component.get_transform(this,0);
          if ((lVar5 == null) || (lVar5 = Transform.Find(lVar5,"Text",0)) == null)
          goto LAB_1808798e0;
          uVar6 = Component.GetComponent(lVar5,DAT_181d6d8c0);
          if (this.targetHero == null) goto LAB_1808798e0;
          uVar7 = Single.ToString(this.targetHero + 0x19c,"0.##",0);
          uVar7 = String.Format("护甲 {0}",uVar7,0);
          LTLocalization.SetText(uVar6,uVar7,0);
          lVar5 = Component.GetComponent(this,DAT_181d6ccc0);
          if (this.targetHero == null) goto LAB_1808798e0;
          uVar10 = this.targetHero.armor;
          fVar11 = (float)GlobalData.CountArmorDamageRate(uVar10,0);
          local_res8[0] = (1.0 - fVar11) * 100.0;
          uVar6 = Single.ToString(local_res8,"f0",0);
          uVar6 = String.Format("减少{0}%所受伤害",uVar6,0);
          goto LAB_1808795a2;
        case 2:
          lVar5 = Component.get_transform(this,0);
          if ((lVar5 == null) || (lVar5 = Transform.Find(lVar5,"Text",0)) == null)
          goto LAB_1808798e0;
          uVar6 = Component.GetComponent(lVar5,DAT_181d6d8c0);
          if ((this.targetHero == null) ||
             (lVar5 = this.targetHero.totalAddData) == null)
          goto LAB_1808798e0;
          local_res8[0] = (float)HeroSpeAddData.Get(lVar5,63);
          local_res8[0] = local_res8[0] * 100.0;
          uVar7 = Single.ToString(local_res8,"0.##",0);
          uVar7 = String.Concat("速度 ",uVar7,"%",0);
          LTLocalization.SetText(uVar6,uVar7,0);
          lVar5 = Component.GetComponent(this,DAT_181d6ccc0);
          uVar7 = FUN_180004500(DAT_181d63120);
          uVar6 = "战斗行动速度";
          break;
        case 3:
          lVar5 = Component.get_transform(this,0);
          if ((lVar5 == null) || (lVar5 = Transform.Find(lVar5,"Text",0)) == null)
          goto LAB_1808798e0;
          uVar6 = Component.GetComponent(lVar5,DAT_181d6d8c0);
          if ((this.targetHero == null) ||
             (lVar5 = this.targetHero.totalAddData) == null)
          goto LAB_1808798e0;
          local_res8[0] = (float)HeroSpeAddData.Get(lVar5,64);
          local_res8[0] = local_res8[0] * 100.0;
          uVar7 = Single.ToString(local_res8,"0.##",0);
          uVar7 = String.Concat("命中 ",uVar7,"%",0);
          LTLocalization.SetText(uVar6,uVar7,0);
          lVar5 = Component.GetComponent(this,DAT_181d6ccc0);
          uVar7 = FUN_180004500(DAT_181d63120);
          uVar6 = "攻击时与对方<b>闪避</b>比较";
          break;
        case 4:
          lVar5 = Component.get_transform(this,0);
          if ((lVar5 == null) || (lVar5 = Transform.Find(lVar5,"Text",0)) == null)
          goto LAB_1808798e0;
          uVar6 = Component.GetComponent(lVar5,DAT_181d6d8c0);
          if ((this.targetHero == null) ||
             (lVar5 = this.targetHero.totalAddData) == null)
          goto LAB_1808798e0;
          local_res8[0] = (float)HeroSpeAddData.Get(lVar5,65);
          local_res8[0] = local_res8[0] * 100.0;
          uVar7 = Single.ToString(local_res8,"0.##",0);
          uVar7 = String.Concat("闪避 ",uVar7,"%",0);
          LTLocalization.SetText(uVar6,uVar7,0);
          lVar5 = Component.GetComponent(this,DAT_181d6ccc0);
          lVar2 = *(int64 *)(*(int64 *)(DAT_181d4e010 + 184) + 8);
          if ((lVar2 == null) || (lVar2 = *(int64 *)(lVar2 + 16)) == null) goto LAB_1808798e0;
          iVar3 = PlayerPrefDictionary.GetInt(lVar2,"NoEvadeBalance",0);
          uVar6 = "/5体力";
          if (iVar3 != 0) {
            uVar6 = "";
          }
          uVar6 = String.Format("受击时与对方<b>命中</b>比较\n触发闪避则躲过本次攻击\n每次消耗5足部架势{0}",uVar6,0);
          goto LAB_1808795a2;
        case 5:
          lVar5 = Component.get_transform(this,0);
          if ((lVar5 == null) || (lVar5 = Transform.Find(lVar5,"Text",0)) == null)
          goto LAB_1808798e0;
          uVar6 = Component.GetComponent(lVar5,DAT_181d6d8c0);
          if ((this.targetHero == null) ||
             (lVar5 = this.targetHero.totalAddData) == null)
          goto LAB_1808798e0;
          local_res8[0] = (float)HeroSpeAddData.Get(lVar5,66);
          local_res8[0] = local_res8[0] * 100.0;
          uVar7 = Single.ToString(local_res8,"0.##",0);
          uVar7 = String.Concat("暴击 ",uVar7,"%",0);
          LTLocalization.SetText(uVar6,uVar7,0);
          lVar5 = Component.GetComponent(this,DAT_181d6ccc0);
          uVar7 = FUN_180004500(DAT_181d63120);
          uVar6 = "攻击时与对方<b>卸力</b>比较\n触发暴击则伤害加倍";
          break;
        case 6:
          lVar5 = Component.get_transform(this,0);
          if ((lVar5 == null) || (lVar5 = Transform.Find(lVar5,"Text",0)) == null)
          goto LAB_1808798e0;
          uVar6 = Component.GetComponent(lVar5,DAT_181d6d8c0);
          if ((this.targetHero == null) ||
             (lVar5 = this.targetHero.totalAddData) == null)
          goto LAB_1808798e0;
          local_res8[0] = (float)HeroSpeAddData.Get(lVar5,67);
          local_res8[0] = local_res8[0] * 100.0;
          uVar7 = Single.ToString(local_res8,"0.##",0);
          uVar7 = String.Concat("卸力 ",uVar7,"%",0);
          LTLocalization.SetText(uVar6,uVar7,0);
          lVar5 = Component.GetComponent(this,DAT_181d6ccc0);
          uVar7 = FUN_180004500(DAT_181d63120);
          uVar6 = "受击时与对方<b>暴击</b>比较\n触发卸力则伤害减半";
          break;
        case 7:
          lVar5 = Component.get_transform(this,0);
          if ((lVar5 == null) || (lVar5 = Transform.Find(lVar5,"Text",0)) == null)
          goto LAB_1808798e0;
          uVar6 = Component.GetComponent(lVar5,DAT_181d6d8c0);
          if ((this.targetHero == null) ||
             (lVar5 = this.targetHero.totalAddData) == null)
          goto LAB_1808798e0;
          local_res8[0] = (float)HeroSpeAddData.Get(lVar5,69);
          local_res8[0] = local_res8[0] * 100.0;
          uVar7 = Single.ToString(local_res8,"0.##",0);
          uVar7 = String.Concat("压制 ",uVar7,"%",0);
          LTLocalization.SetText(uVar6,uVar7,0);
          lVar5 = Component.GetComponent(this,DAT_181d6ccc0);
          uVar7 = FUN_180004500(DAT_181d63120);
          uVar6 = "攻击时与对方<b>反击</b>比较\n触发压制对方行动条减半";
          break;
        case 8:
          lVar5 = Component.get_transform(this,0);
          if ((lVar5 == null) || (lVar5 = Transform.Find(lVar5,"Text",0)) == null)
          goto LAB_1808798e0;
          uVar6 = Component.GetComponent(lVar5,DAT_181d6d8c0);
          if ((this.targetHero == null) ||
             (lVar5 = this.targetHero.totalAddData) == null)
          goto LAB_1808798e0;
          local_res8[0] = (float)HeroSpeAddData.Get(lVar5,68);
          local_res8[0] = local_res8[0] * 100.0;
          uVar7 = Single.ToString(local_res8,"0.##",0);
          uVar7 = String.Concat("反击 ",uVar7,"%",0);
          LTLocalization.SetText(uVar6,uVar7,0);
          lVar5 = Component.GetComponent(this,DAT_181d6ccc0);
          uVar7 = FUN_180004500(DAT_181d63120);
          uVar6 = "受击时与对方<b>压制</b>比较\n触发反击自身行动条加倍";
          break;
        case 9:
          lVar5 = Component.get_transform(this,0);
          if ((lVar5 == null) || (lVar5 = Transform.Find(lVar5,"Text",0)) == null)
          goto LAB_1808798e0;
          uVar6 = Component.GetComponent(lVar5,DAT_181d6d8c0);
          if ((this.targetHero == null) ||
             (lVar5 = this.targetHero.totalAddData) == null)
          goto LAB_1808798e0;
          local_res8[0] = (float)HeroSpeAddData.Get(lVar5,70);
          local_res8[0] = local_res8[0] * 100.0;
          uVar7 = Single.ToString(local_res8,"0.##",0);
          uVar7 = String.Concat("连击 ",uVar7,"%",0);
          LTLocalization.SetText(uVar6,uVar7,0);
          lVar5 = Component.GetComponent(this,DAT_181d6ccc0);
          uVar7 = FUN_180004500(DAT_181d63120);
          uVar6 = "攻击时与对方<b>断连</b>比较\n触发连击则会再次进行攻击";
          break;
        case 10:
          lVar5 = Component.get_transform(this,0);
          if ((lVar5 == null) || (lVar5 = Transform.Find(lVar5,"Text",0)) == null)
          goto LAB_1808798e0;
          uVar6 = Component.GetComponent(lVar5,DAT_181d6d8c0);
          if ((this.targetHero == null) ||
             (lVar5 = this.targetHero.totalAddData) == null)
          goto LAB_1808798e0;
          local_res8[0] = (float)HeroSpeAddData.Get(lVar5,71);
          local_res8[0] = local_res8[0] * 100.0;
          uVar7 = Single.ToString(local_res8,"0.##",0);
          uVar7 = String.Concat("断连 ",uVar7,"%",0);
          LTLocalization.SetText(uVar6,uVar7,0);
          lVar5 = Component.GetComponent(this,DAT_181d6ccc0);
          uVar7 = FUN_180004500(DAT_181d63120);
          uVar6 = "受击时减少对方连击率";
          break;
        case 11:
          lVar5 = Component.get_transform(this,0);
          if ((lVar5 == null) || (lVar5 = Transform.Find(lVar5,"Text",0)) == null)
          goto LAB_1808798e0;
          uVar6 = Component.GetComponent(lVar5,DAT_181d6d8c0);
          if ((this.targetHero == null) ||
             (lVar5 = this.targetHero.totalAddData) == null)
          goto LAB_1808798e0;
          uVar10 = HeroSpeAddData.Get(lVar5,74);
          local_res8[0] = (float)Mathf.Min(uVar10,0x3f59999a,0);
          local_res8[0] = local_res8[0] * 100.0;
          uVar7 = Single.ToString(local_res8,"0.##",0);
          uVar7 = String.Concat("伤害抗性 ",uVar7,"%",0);
          LTLocalization.SetText(uVar6,uVar7,0);
          lVar5 = Component.GetComponent(this,DAT_181d6ccc0);
          uVar7 = FUN_180004500(DAT_181d63120);
          uVar6 = "减少所受伤害\n(最高85%)";
          break;
        case 12:
          lVar5 = Component.get_transform(this,0);
          if ((lVar5 == null) || (lVar5 = Transform.Find(lVar5,"Text",0)) == null)
          goto LAB_1808798e0;
          uVar6 = Component.GetComponent(lVar5,DAT_181d6d8c0);
          if (this.targetHero == null) goto LAB_1808798e0;
          local_res8[0] = (float)HeroData.GetWoundResist(this.targetHero,0);
          local_res8[0] = local_res8[0] * 100.0;
          uVar7 = Single.ToString(local_res8,"0.##",0);
          uVar7 = String.Concat("伤势抗性 ",uVar7,"%",0);
          LTLocalization.SetText(uVar6,uVar7,0);
          lVar5 = Component.GetComponent(this,DAT_181d6ccc0);
          uVar7 = FUN_180004500(DAT_181d63120);
          uVar6 = "减少所受伤势\n(最高85%)";
          break;
        case 13:
          lVar5 = Component.get_transform(this,0);
          if ((lVar5 == null) || (lVar5 = Transform.Find(lVar5,"Text",0)) == null)
          goto LAB_1808798e0;
          uVar6 = Component.GetComponent(lVar5,DAT_181d6d8c0);
          if ((this.targetHero == null) ||
             (lVar5 = this.targetHero.totalAddData) == null)
          goto LAB_1808798e0;
          local_res8[0] = (float)HeroSpeAddData.Get(lVar5,75);
          local_res8[0] = local_res8[0] * 100.0;
          uVar7 = Single.ToString(local_res8,"0.##",0);
          uVar7 = String.Concat("负面加成 ",uVar7,"%",0);
          LTLocalization.SetText(uVar6,uVar7,0);
          lVar5 = Component.GetComponent(this,DAT_181d6ccc0);
          uVar7 = FUN_180004500(DAT_181d63120);
          uVar6 = "增加给对方施加负面状态的概率";
          break;
        case 14:
          lVar5 = Component.get_transform(this,0);
          if ((lVar5 == null) || (lVar5 = Transform.Find(lVar5,"Text",0)) == null)
          goto LAB_1808798e0;
          uVar6 = Component.GetComponent(lVar5,DAT_181d6d8c0);
          if ((this.targetHero == null) ||
             (lVar5 = this.targetHero.totalAddData) == null)
          goto LAB_1808798e0;
          local_res8[0] = (float)HeroSpeAddData.Get(lVar5,76);
          local_res8[0] = local_res8[0] * 100.0;
          uVar7 = Single.ToString(local_res8,"0.##",0);
          uVar7 = String.Concat("负面抗性 ",uVar7,"%",0);
          LTLocalization.SetText(uVar6,uVar7,0);
          lVar5 = Component.GetComponent(this,DAT_181d6ccc0);
          uVar7 = FUN_180004500(DAT_181d63120);
          uVar6 = "降低自身被施加负面状态的概率";
          break;
        case 15:
          lVar5 = Component.get_transform(this,0);
          if ((lVar5 == null) || (lVar5 = Transform.Find(lVar5,"Text",0)) == null)
          goto LAB_1808798e0;
          uVar6 = Component.GetComponent(lVar5,DAT_181d6d8c0);
          if ((this.targetHero == null) ||
             (lVar5 = this.targetHero.totalAddData) == null)
          goto LAB_1808798e0;
          local_res8[0] = (float)HeroSpeAddData.Get(lVar5,73);
          local_res8[0] = local_res8[0] * 100.0;
          uVar7 = Single.ToString(local_res8,"0.##",0);
          uVar7 = String.Concat("恢复效率 ",uVar7,"%",0);
          LTLocalization.SetText(uVar6,uVar7,0);
          lVar5 = Component.GetComponent(this,DAT_181d6ccc0);
          uVar7 = FUN_180004500(DAT_181d63120);
          uVar6 = "增加生命/内力/体力恢复效率";
          break;
        case 16:
          lVar5 = Component.get_transform(this,0);
          if ((lVar5 == null) || (lVar5 = Transform.Find(lVar5,"Text",0)) == null)
          goto LAB_1808798e0;
          uVar6 = Component.GetComponent(lVar5,DAT_181d6d8c0);
          if ((this.targetHero == null) ||
             (lVar5 = this.targetHero.totalAddData) == null)
          goto LAB_1808798e0;
          local_res8[0] = (float)HeroSpeAddData.Get(lVar5,72);
          local_res8[0] = local_res8[0] * 100.0;
          uVar7 = Single.ToString(local_res8,"0.##",0);
          uVar7 = String.Concat("经验获取 ",uVar7,"%",0);
          LTLocalization.SetText(uVar6,uVar7,0);
          lVar5 = Component.GetComponent(this,DAT_181d6ccc0);
          uVar7 = FUN_180004500(DAT_181d63120);
          uVar6 = "增加所有经验的获取效率";
          break;
        case 17:
          lVar5 = Component.get_transform(this,0);
          if ((lVar5 == null) || (lVar5 = Transform.Find(lVar5,"Text",0)) == null)
          goto LAB_1808798e0;
          uVar6 = Component.GetComponent(lVar5,DAT_181d6d8c0);
          if ((this.targetHero == null) ||
             (lVar5 = this.targetHero.baseAddData) == null)
          goto LAB_1808798e0;
          local_res8[0] = (float)HeroSpeAddData.Get(lVar5,57);
          uVar7 = Single.ToString(local_res8,"f0",0);
          uVar7 = String.Concat("额外生命上限 ",uVar7,0);
          LTLocalization.SetText(uVar6,uVar7,0);
          lVar5 = Component.GetComponent(this,DAT_181d6ccc0);
          uVar7 = FUN_180004500(DAT_181d63120);
          uVar6 = "角色获取的额外生命上限";
          break;
        case 18:
          lVar5 = Component.get_transform(this,0);
          if ((lVar5 == null) || (lVar5 = Transform.Find(lVar5,"Text",0)) == null)
          goto LAB_1808798e0;
          uVar6 = Component.GetComponent(lVar5,DAT_181d6d8c0);
          if ((this.targetHero == null) ||
             (lVar5 = this.targetHero.baseAddData) == null)
          goto LAB_1808798e0;
          local_res8[0] = (float)HeroSpeAddData.Get(lVar5,59);
          uVar7 = Single.ToString(local_res8,"f0",0);
          uVar7 = String.Concat("额外内力上限 ",uVar7,0);
          LTLocalization.SetText(uVar6,uVar7,0);
          lVar5 = Component.GetComponent(this,DAT_181d6ccc0);
          uVar7 = FUN_180004500(DAT_181d63120);
          uVar6 = "角色获取的额外内力上限";
          break;
        case 19:
          lVar5 = Component.get_transform(this,0);
          if ((lVar5 != null) && (lVar5 = Transform.Find(lVar5,"Text",0)) != null) {
            uVar6 = Component.GetComponent(lVar5,DAT_181d6d8c0);
            lVar5 = this.targetHero;
            if (lVar5 != null) {
              if (!lVar5.isSummon) {
                iVar3 = HeroData.GetBaseMoveRange(lVar5,0);
                if (lVar5.totalAddData == null) goto LAB_1808798e0;
                fVar11 = (float)HeroSpeAddData.Get(lVar5.totalAddData,166,0);
                fVar13 = 1.0;
                if (lVar5.heroBuff == null) goto LAB_1808798e0;
                fVar12 = (float)HeroSpeAddData.Get(lVar5.heroBuff,167,0);
                if (0.0 < fVar12) {
                  fVar13 = 1.75;
                }
                if (lVar5.heroBuff == null) goto LAB_1808798e0;
                fVar12 = (float)HeroSpeAddData.Get(lVar5.heroBuff,168,0);
                if (0.0 < fVar12) {
                  fVar13 = fVar13 + -0.75;
                }
                local_res18[0] = (int)((fVar11 + (float)iVar3) * fVar13);
              }
              else {
                local_res18[0] = lVar5.summonMoveRange;
              }
              uVar7 = Int32.ToString(local_res18,0);
              uVar7 = String.Concat("移动距离 ",uVar7,0);
              LTLocalization.SetText(uVar6,uVar7,0);
              lVar5 = Component.GetComponent(this,DAT_181d6ccc0);
              uVar6 = FUN_180004500(DAT_181d63120);
              uVar6 = String.Format("战斗中的移动距离\n灵巧轻功之和决定基础移距",uVar6,0);
              if (lVar5 != null) {
                lVar5.summonLv = uVar6;
                if (this.targetHero != null) {
                  iVar4 = HeroData.GetBaseMoveRange(this.targetHero,0);
                  iVar3 = 0;
                  while( true ) {
                    lVar5 = *(int64 *)(pStatics + 0x550);
                    if (lVar5 == null) break;
                    if (lVar5.summonLv + -1 <= iVar3) {
                      return;
                    }
                    lVar5 = Component.GetComponent(this,DAT_181d6ccc0);
                    if (lVar5 == null) break;
                    iVar1 = iVar3 + 1;
                    uVar6 = lVar5.summonLv;
                    uVar7 = "\n{0}";
                    if (iVar4 == iVar1) {
                      uVar7 = "\n<color=#00B400>{0}</color>";
                    }
                    lVar2 = *(int64 *)(pStatics + 0x550);
                    if (lVar2 == null) {
                          // WARNING: Subroutine does not return
                      FUN_1800d6620();
                    }
                    local_res20[0] = FUN_1800d6750(lVar2,iVar3,DAT_181d68270);
                    uVar8 = il2cpp_value_box(DAT_181d5b2f8,local_res20);
                    local_88[0] = iVar1;
                    uVar9 = il2cpp_value_box(DAT_181d5b2f8,local_88);
                    uVar8 = String.Format(">={0} 基础移距{1}",uVar8,uVar9,0);
                    uVar7 = String.Format(uVar7,uVar8,0);
                    uVar6 = String.Concat(uVar6,uVar7,0);
                    lVar5.summonLv = uVar6;
                    iVar3 = iVar1;
                  }
                }
              }
            }
          }
          goto LAB_1808798e0;
        default:
          goto switchD_1808784f1_default;
        }
        uVar6 = String.Format(uVar6,uVar7,0);
        LAB_1808795a2:
        if (lVar5 == null) {
        LAB_1808798e0:
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
        lVar5.summonLv = uVar6;
        switchD_1808784f1_default:
    }

    // Token : 0x600172C
    // RVA   : 0x3A17B0   Offset: 0x39FFB0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_18044ef50(this,0);
    }

}
