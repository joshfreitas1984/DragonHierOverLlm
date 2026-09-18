using System.Text;
using System.Text.RegularExpressions;
using FanslationStudio.LlmKit;
using FanslationStudio.LlmKit.Support;
using FanslationStudio.LlmKit.Utility;
using FanslationStudio.LlmKit.Workflow;

namespace Tests
{
    // Packages translated CSV/PrefabText/DynamicStringsIL2CPP files into the final mod output,
    // including the forced result overrides and junk-entry filtering applied at packaging time.
    // See docs/gamefilehandling-reference.md.
    public static class TranslationPackaging
    {
        // Forced Result overrides for known-problematic DynamicStringsIL2CPP Raw templates,
        // applied unconditionally at packaging time (see ApplyDynamicStringResultOverrides) because
        // CompoundFieldSplitter.Reconstruct glues translated fragments directly against "{n}"
        // placeholders with no separator - individually-correct fragment translations (e.g.
        // "年"->"Year") still reconstruct unreadably ("1Year1Month17Day"). Keyed by the exact Raw
        // string. See docs/gamefilehandling-reference.md.
        private static readonly Dictionary<string, string> DynamicStringResultOverrides = new()
        {
            ["{0}年{1}月{2}日"] = "{0} Year {1} Month {2} Day",

            // Both entries below were reported garbled in-game (e.g. "Will do this previously
            // Jianghu Ranger XuanyuanChengXiu在Cancong Village And 仙霞 Sect Master He Chitchat
            // One 阵...and hear the tale of their encounter...") - the ORIGINAL LLM translations
            // were produced from fragments split right at the "{n}" placeholder boundary with no
            // surrounding-sentence context, so each half was translated blind and came out
            // ungrammatical. Overridden here to read as a single coherent sentence instead. NOTE:
            // the reported instance additionally has a "{2}他" (title+pronoun) variant of the
            // second raw string that this exact-Raw-match override does NOT fix - that variant
            // was never captured as its own dumped Raw entry, so it still falls through to
            // per-word dictionary substitution at runtime regardless of this fix.
            ["#TargetInteractName#将此前{0}之遭遇向你娓娓道来......"] =
                "#TargetInteractName# recounts to you in detail their previous encounter with {0}......",
            ["{0}在{1}与{2}闲聊一阵。"] = "{0} chatted with {2} for a while at {1}.",

            // The HeroData.AddLog/AreaData.AddLog "log narrative" family (see
            // DynamicStringSources.LogNarrativeTemplates and dynamicStringsLogNarratives.txt) -
            // added 2026-09-13 after inspecting this family's actual packaged Results in
            // Files/Mod/dynamicStrings.txt.yaml. Every one of them showed the same
            // fragment-translation symptoms: a capitalized fragment mid-sentence right after the
            // "{0}"/"{1}" placeholder (translated independently of the words around it, so it reads
            // like a sentence fragment rather than a continuation - "{0} In {1} Practiced martial
            // arts {2}."), retained full-width Chinese punctuation ("，"/"。") glued onto an English
            // sentence, and missing connective words ("and", "at", possessives) that a human
            // translator would supply from context a template-fragment translation never sees.
            // Rewritten below as single natural sentences with a placeholder kept only where it
            // carries real content (a name, place, or number) - never as a sentence-initial
            // fragment. Uses gender-neutral "they/their" throughout since {0} may be any hero
            // regardless of gender (the original fragment translation hardcoded "he" in at least one
            // case - "被晋升为" below).
            ["{0}在{1}结束关押，恢复了自由之身。"] = "{0} was released from custody at {1} and regained their freedom.",
            ["{0}在{1}闲逛之时，意外获取了{2}两银钱。"] = "{0} was strolling around {1} and unexpectedly came into {2} silver.",
            ["{0}在{1}闲逛之时，意外获取了一件{2}。"] = "{0} was strolling around {1} and unexpectedly picked up a {2}.",
            ["{0}在{1}修习了武功{2}。"] = "{0} practiced the martial art {2} at {1}.",
            ["{0}在{1}修习了{2}技艺。"] = "{0} practiced the {2} skill at {1}.",
            ["{0}在{1}辛勤劳作，为门派收获了{2}。"] = "{0} worked hard at {1} and brought in {2} for the sect.",
            ["{0}在{1}打工赚钱，获取了{2}两银钱。"] = "{0} took on odd jobs at {1} and earned {2} silver.",
            ["{0}在{1}四下探索之时，意外发现了{2}。"] = "{0} was exploring around {1} and stumbled upon {2}.",
            ["{0}在{1}与{2}相谈盛欢，一见如故，结为知己好友。"] =
                "{0} had a wonderful conversation with {2} at {1}; they hit it off at once and became close friends.",
            ["{0}在{1}欲下毒暗害{2}，{3}。"] = "{0} tried to poison {2} at {1} - {3}.",
            ["{0}在{1}欲{5}{2}的{3}，{4}。"] = "{0} tried to {5} {2}'s {3} at {1} - {4}.",
            ["{0}在{1}欲偷师{2}的{3}，{4}。"] = "{0} tried to secretly learn {2}'s {3} at {1} - {4}.",
            ["{0}在{1}与{2}心生嫌隙，结下了深仇大恨。"] = "{0} had a falling out with {2} at {1}, and a deep grudge formed between them.",
            ["{0}在{1}与{2}交流心得，切磋武艺，最终{3}。"] = "{0} traded notes and sparred with {2} at {1}, and in the end {3}.",
            ["{0}在{1}袭击了{2}，血战一场最终{3}。"] = "{0} attacked {2} at {1}; after a bloody battle, {3}",
            ["{0}在{1}完成了重要委托，名望{2}，银两{3}，并获得了{4}。"] =
                "{0} completed an important commission at {1}, gaining {2} renown and {3} silver, and receiving {4}.",
            ["{0}在{1}遭逢{5}奇遇，名望{2}，银两{3}，并获得了{4}。"] =
                "{0} had a {5} encounter at {1}, gaining {2} renown and {3} silver, and receiving {4}.",
            ["{0}在{1}上下打点，花费{3}银两降低了{2}点恶名。"] = "{0} greased some palms at {1}, spending {3} silver to lower their infamy by {2}.",
            ["{0}在{1}习得了新武功{2}。"] = "{0} learned the new martial art {2} at {1}.",
            ["{0}在{1}暗中破坏，使该地{2}降低{3}点。"] = "{0} secretly sabotaged {1}, lowering its {2} by {3}.",
            ["{0}烹饪了{1}并放入行囊(消耗{2}银钱{3})"] = "{0} cooked {1} and put it in their bag (spent {2} silver{3})",
            ["{0}烹饪了{1}并放入门派仓库(消耗{2}粮食{3})"] = "{0} cooked {1} and put it in the sect's storehouse (spent {2} food{3})",
            ["{0}烹饪了{1}，由于门派仓库已满只得放入行囊(消耗{2}粮食{3})"] =
                "{0} cooked {1}, but the sect's storehouse was full, so it went into their bag instead (spent {2} food{3})",
            ["{0}炼制了{1}并放入行囊(消耗{2}银钱{3})"] = "{0} crafted {1} and put it in their bag (spent {2} silver{3})",
            ["{0}炼制了{1}并放入门派仓库(消耗{2}药材{3})"] = "{0} crafted {1} and put it in the sect's storehouse (spent {2} herbs{3})",
            ["{0}炼制了{1}，由于门派仓库已满只得放入行囊(消耗{2}药材{3})"] =
                "{0} crafted {1}, but the sect's storehouse was full, so it went into their bag instead (spent {2} herbs{3})",
            ["{0}制造了{1}并放入行囊(消耗{2}银钱{3})"] = "{0} made {1} and put it in their bag (spent {2} silver{3})",
            ["{0}制造了{1}并放入门派仓库(消耗{2}木料矿石{3})"] = "{0} made {1} and put it in the sect's storehouse (spent {2} timber and ore{3})",
            ["{0}制造了{1}，由于门派仓库已满只得放入行囊(消耗{2}木料矿石{3})"] =
                "{0} made {1}, but the sect's storehouse was full, so it went into their bag instead (spent {2} timber and ore{3})",
            ["{0}在{1}买卖交易，出售了闲置物品{2}{3}。"] = "{0} traded at {1}, selling off unused {2}{3}.",
            ["{0}使用门派银钱{1}两，购买{2}。"] = "{0} spent {1} silver from the sect's coffers to buy {2}.",
            ["{0}出售门派{1}，换取门派银钱{2}两。"] = "{0} sold {1} from the sect, earning {2} silver for the sect's coffers.",
            ["{0}与{1}情谊渐浅，断绝了好友关系。"] = "{0} and {1} grew apart, and their friendship came to an end.",
            ["{0}与{1}冰释前嫌，化解了二人间的仇恨。"] = "{0} and {1} put their old grievances behind them and made peace.",
            ["{0}被{1}抓捕入狱，关押在{2}之中。"] = "{0} was captured by {1} and thrown into {2}.",
            ["{0}向{3}仓库捐赠了{1}，获取功绩{2}"] = "{0} donated {1} to {3}'s storehouse, earning {2} merit",
            ["{0}从{3}仓库购买了{1}，花费银两{2}"] = "{0} bought {1} from {3}'s storehouse, spending {2} silver",
            // {0} is a product/listing name, {1} an area, {2} either "风靡" (a hit) or "滞销"
            // (unsold) - see GameController.cs:20086-20091.
            ["{0}的{1}结束{2}了。"] = "{0}'s {1} run at {2} has ended.",
            ["{0}<b>{1}</b>{2}，买卖价格{3}。"] = "{0} <b>{1}</b>{2}, trade price {3}.",
            ["{0}收到门派{1}银钱嘉奖，忠诚+3"] = "{0} received a {1} silver reward from the sect, loyalty +3",
            ["{0}在{1}参加{6}，勇夺第{2}名，银两+{3}，{4}，并获得了奖品{5}。"] =
                "{0} took part in {6} at {1}, took {2} place, +{3} silver, {4}, and won the prize {5}.",
            ["{0}在{1}参加{5}赛马大会，勇夺第{2}名，银两+{3}，声望+{4}。"] =
                "{0} took part in the {5} horse race at {1}, took {2} place, +{3} silver, +{4} renown.",
            ["{0}在{1}参加{2}拍卖大会，花费{3}两购得一件{4}。"] = "{0} attended the {2} auction at {1}, spending {3} silver to win {4}.",
            ["{0}吉人天相，寻得高人所刻石碑，潜心研读后提升了{1}潜力。"] =
                "{0} had a stroke of good fortune, finding a stone tablet carved by a master. Studying it closely raised their {1} potential.",
            ["{0}吉人天相，{2}，学会了武功{1}。"] = "{0} had a stroke of good fortune - {2} - and learned the martial art {1}.",
            ["{0}吉人天相，寻得前朝皇家宝库，获得了{1}等诸多珍宝。"] =
                "{0} had a stroke of good fortune, finding a royal treasury from the last dynasty and coming away with {1} and other treasures.",
            ["{0}气运过人，寻得一本失传秘籍，鉴别后竟是传说中的{1}。"] =
                "{0}'s luck ran high - they found a lost manual, and on closer inspection it turned out to be the legendary {1}.",
            ["{0}吉星高照，得到一株异草，服食后生命上限增加{1}。"] =
                "{0}'s stars aligned, and they found a strange herb; eating it raised their max health by {1}.",
            ["{0}吉星高照，寻得失落宝藏，搜刮后获得了{1}两银钱。"] =
                "{0}'s stars aligned, and they found a lost treasure, coming away with {1} silver.",
            ["{0}吉星高照，得到一枚灵果，服食后内力上限增加{1}。"] =
                "{0}'s stars aligned, and they found a spirit fruit; eating it raised their max internal energy by {1}.",
            ["{0}气运过人，寻得一件神兵利器，鉴别后竟是传说中的{1}。"] =
                "{0}'s luck ran high - they found a divine weapon, and on closer inspection it turned out to be the legendary {1}.",
            ["{0}气运过人，寻得一匹千里名驹，鉴别后竟是传说中的{1}。"] =
                "{0}'s luck ran high - they found a swift, thousand-mile steed, and on closer inspection it turned out to be the legendary {1}.",
            ["{0}近日大兴土木，开始修缮升级{1}{2}({3}级)"] = "{0} has begun major construction, upgrading {1} {2} (Level {3})",
            ["{0}近日大兴土木，开始在{1}新建{2}"] = "{0} has begun major construction, building a new {2} at {1}",
            ["{0}近日大兴土木，开始拆除{1}{2}({3}级)"] = "{0} has begun major construction, demolishing {1} {2} (Level {3})",
            // {0} is the sect name, {1} its Sect Master - see GameController.cs:28074.
            ["{0}掌门{1}将《{2}》{3}秘籍放入藏经阁，供全派弟子参阅。"] =
                "{0}'s Sect Master {1} placed the manual 《{2}》 ({3}) in the Scripture Pavilion for all disciples to study.",
            ["{0}掌门{1}用《{2}》{3}替换了藏经阁内的《{2}》{4}秘籍，供全派弟子参阅。"] =
                "{0}'s Sect Master {1} replaced the Scripture Pavilion's 《{2}》 ({4}) with 《{2}》 ({3}), for all disciples to study.",
            ["{0}因功勋卓著，被晋升为{1}。"] = "{0} was promoted to {1} for their outstanding service.",
            ["{0}攻击了{2}掌控下的{1}，最终{3}。"] = "{0} attacked {1}, under {2}'s control, and in the end {3}.",
            ["{0}加入了由{1}领导的队伍。"] = "{0} joined the team led by {1}.",
            ["{0}离开了由{1}领导的队伍。"] = "{0} left the team led by {1}.",
            ["{0}对自身装备的{1}进行了粹毒。"] = "{0} coated their own {1} with poison.",
            ["{0}对自身的{1}上进行了下毒。"] = "{0} poisoned their own {1}.",
            ["{0}领悟了天赋：{1}"] = "{0} gained the talent: {1}",
            ["{0}近日开始加强{1}分舵之{2}防御等级({3}级)"] = "{0} has begun reinforcing the {2} defenses of the {1} branch (Level {3})",
            ["{0}在{1}暗中破坏，使该地{2}降低了{3}点。"] = "{0} secretly sabotaged {1}, lowering its {2} by {3}.",
            ["{0}在{1}开展治理，使该地{2}提升了{3}点。"] = "{0} carried out improvements at {1}, raising its {2} by {3}.",
            // "{0}{1}{2}，{3}" (HeroData.cs:18642) is deliberately NOT overridden here - it has no
            // fixed literal words at all (every segment is a placeholder), so there is no
            // connective-tissue mistranslation to fix; whatever awkwardness it has comes entirely
            // from its own filled-in argument values, which this exact-Raw override mechanism can't
            // address.

            // Runtime-color-placeholder templates: a "{n}" placeholder is a game-code-computed
            // "<color=...>" opening tag (see EnhanceUIController.cs's plVar7 argument array,
            // decompiled: {0}/{2} are dynamically chosen red/green tags depending on whether a
            // requirement is met), paired with a LITERAL closing tag baked into the raw text a few
            // tokens later. Originally attempted as a GameHooks.CustomTranslationExclusionRule
            // (LlmKit) keyed on the full raw template, on the theory that keeping these away from
            // the LLM/QC entirely up front would be strictly safer - but that hook is checked
            // per-TranslationSplit, and CompoundFieldSplitter decomposes every one of these raw
            // strings into multiple fragments plus a "templates:" reconstruction list (confirmed:
            // no single split's Text ever equals the full raw with its "{n}" tokens), so the hook's
            // raw parameter never matches these dictionary keys and it silently never fired.
            // Belongs here instead - this dictionary already operates at the correct level (the
            // whole reconstructed Raw -> whole Result, post-packaging), for the same underlying
            // reason as every other entry in this dictionary: CompoundFieldSplitter.Reconstruct
            // glues per-fragment translations back together and neither the LLM nor QC ever sees the
            // whole templated string at once. Confirmed the QC-caused bug this list starts with: the
            // "提升强化等级至" Enhance-UI string's QC correction dropped the literal "级</color>" off
            // the end of its first line, leaving that line's color span unclosed - see
            // docs/dynamicstrings-dangling-color-tag-templates.md for the full investigation and the
            // scan that found all 44 raw strings with this shape (a "{n}" placeholder plus a literal
            // closing tag with no matching literal opening tag in the same raw text) in
            // Files/Converted/dynamicStrings*.yaml - zero in Files/Converted/dumpedPrefabText*.yaml.
            // Every value below keeps the exact "{n}" placeholder order/position from its raw key -
            // only the literal text between them was translated.
            ["<b>门派特性</b>\n{1}{0}</color>"] = "<b>Sect Traits</b>\n{1} {0}</color>",
            ["<i>{2}(因超过{0}级，练习只获取{1}%经验！)</color></i>"] =
                "<i>{2} (Due to exceeding Level {0}, practice only grants {1}% experience!)</color></i>",
            ["{0}(已习得 第{1}重)</color>"] = "{0} (Already learned Tier {1})</color>",
            ["{0}<b>作恶导致禁用{1}个月</b></color>"] = "{0}<b>Banned for {1} months due to misconduct</b></color>",
            // Confirmed via QuickDetail.cs/decompile: {1} is a pre-concatenated "{skillName}{level}"
            // blob (e.g. "Qinggong 3") and {2} is a pass/fail color tag - the line reads "Requires:
            // <color>SkillName Level</color>", not literal "passing" (通行 = "passage/traversal" here,
            // a terrain-obstacle skill gate, not the English verb "pass").
            ["{0}\n通行{2}{1}</color>"] = "{0}\nRequires {2}{1}</color>",
            ["{0}{1}日</color>"] = "{0} {1} Day</color>",
            ["{0}同盟</color>"] = "{0} Alliance</color>",
            ["{0}宗主</color>"] = "{0} Sect Leader</color>",
            ["{0}已{1}至满级</color>"] = "{0} has {1} reached the level cap</color>",
            ["{0}已拥有</color>"] = "{0} is already owned</color>",
            ["{0}未拥有</color>"] = "{0} Not owned</color>",
            ["{0}本门</color>"] = "{0} This Sect</color>",
            ["{0}禁用{1}个月</color>"] = "{0} Banned for {1} months</color>",
            ["{0}终点</color>"] = "{0} Finish</color>",
            ["{0}耐药性 {1}%</color>"] = "{0} Drug resistance {1}%</color>",
            ["{0}耐药性{1}%</color>"] = "{0} Drug resistance {1}%</color>",
            ["{0}附庸</color>"] = "{0} Vassal</color>",
            ["{1}[有毒{0}]</color>"] = "{1}[Toxic {0}]</color>",
            ["{1}休战{0}日</color>"] = "{1} Truce {0} Days</color>",
            ["{1}困难{0}</color>"] = "{1} Difficulty {0}</color>",
            ["{1}守卫熟络{0}</color>"] = "{1} Guard familiarity {0}</color>",
            ["{1}守卫警戒{0}</color>"] = "{1} Guard alertness {0}</color>",
            ["{1}容易{0}</color>"] = "{1} Easy {0}</color>",
            ["{1}有毒 {0}</color>"] = "{1} Toxic {0}</color>",
            ["{1}极易{0}</color>"] = "{1} is very easy {0}</color>",
            ["{1}极难{0}</color>"] = "{1} Extremely difficult {0}</color>",
            ["{1}较易{0}</color>"] = "{1} Easier {0}</color>",
            ["{1}较难{0}</color>"] = "{1} More difficult {0}</color>",
            ["♦忠诚小于50时，每月有概率叛离门派。\n{1}每月叛离概率:{0}%</color>"] =
                "♦When loyalty is less than 50, there is a monthly chance of defecting from the Sect.\n{1} Monthly chance of defection: {0}%</color>",
            ["体力{0}</color>"] = "Stamina {0}</color>",
            ["内力{0}</color>"] = "Inner Power {0}</color>",
            ["因招募{4}{0}，所有门派对{1}{5}好感{2}</color>且全弟子{5}忠诚{3}</color>！"] =
                "Recruiting {4} {0} increases all sects' {1} {5} favorability by {2}</color> and all disciples' {5} loyalty by {3}</color>!",
            ["因门派银钱告罄，全弟子{0}忠诚-20</color>！"] =
                "Due to the sect's treasury being exhausted, all disciples' {0} loyalty -20</color>!",
            ["对方好感 60{1}(当前{0})</color>"] = "The other party's affinity 60 {1} (Current: {0})</color>",
            ["提升强化等级至+{6}\n{0}需要建筑等级 {1}级</color>\n{2}需要{5}技能 {3}</color>\n{4}"] =
                "Increase the enhancement level to +{6}\n{0}Requires building level {1}</color>\n{2}Requires {5} skill {3}</color>\n{4}",
            ["每月产出\n{2}{0}</color>\n\n周边效率+{1}%"] = "Monthly production\n{2} {0}</color>\n\nSurrounding efficiency+{1}%",
            ["特殊建筑 {0}({1}</color>)"] = "Special buildings {0} ({1}</color>)",
            ["生命{0}</color>"] = "Health {0}</color>",
            ["随机打通下{0}个穴位</color>"] = "Randomly unblock {0} acupoints</color>",
            ["随机揭示{0}个点</color>"] = "Randomly reveal {0} points</color>",
            ["需要:{2}{0}{1}</color>"] = "Need: {2} {0} {1}</color>",
            ["需要\n{0} {1}级</color>"] = "Need\n{0} {1} Level</color>",
            ["需要\n{0}人口 {1}</color>"] = "Need\n{0} Population {1}</color>",
            ["需要\n{0}弟子 {1}</color>"] = "Need\n{0} Disciple {1}</color>",
        };

        // Same placeholder-adjacency problem as DynamicStringResultOverrides, but for a fragment
        // that recurs at varying placeholder indices (e.g. "{0}级"/"{1}级", the "Level N" reader
        // stat). Applied as substring fixups against the already-translated Result (not rebuilt
        // from Raw) so the rest of the sentence's translation survives.
        private static readonly (Regex Pattern, MatchEvaluator Evaluator)[] DynamicStringRegexResultOverrides =
        [
            // "{i}Level{j}"/"{i} Level {j}" -> "Level {i} {j}" - must run before the standalone
            // rule below so the trailing "{j}" isn't left to match on its own first.
            (new Regex(@"\{(\d+)\}\s*Level\s*\{(\d+)\}", RegexOptions.Compiled),
                m => $"Level {{{m.Groups[1].Value}}} {{{m.Groups[2].Value}}}"),

            // "{i}Level"/"{i} Level" standalone -> "Level {i}".
            (new Regex(@"\{(\d+)\}\s*Level\b", RegexOptions.Compiled),
                m => $"Level {{{m.Groups[1].Value}}}"),
        ];

        // Re-reads the just-packaged Files/Mod/{textFile.Path}.yaml and force-overwrites any
        // entry whose Raw matches DynamicStringResultOverrides, then rewrites the file. Runs
        // AFTER DynamicStringWorkflow.PackageDynamicStringsAsync on every packaging pass -
        // regardless of what's currently translated in Files/Converted - so a future re-export or
        // re-translation of this raw string can never silently regress the fix (editing the
        // Converted/Mod YAML directly, as done previously, gets undone the next time either step
        // re-runs).
        private static void ApplyDynamicStringResultOverrides(string workingDirectory, TextFileToSplit textFile)
        {
            var modPath = $"{workingDirectory}/Mod/{textFile.Path}.yaml";
            if (!File.Exists(modPath))
                return;

            var deserializer = YamlHelper.CreateDeserializer();
            var results = deserializer.Deserialize<List<DynamicStringResult>>(File.ReadAllText(modPath)) ?? new();

            var changed = false;
            foreach (var entry in results)
            {
                string? forcedResult = null;

                if (DynamicStringResultOverrides.TryGetValue(entry.Raw, out var exactResult))
                    forcedResult = exactResult;
                else
                {
                    var fixedResult = entry.Result;
                    foreach (var (pattern, evaluator) in DynamicStringRegexResultOverrides)
                        fixedResult = pattern.Replace(fixedResult, evaluator);

                    if (fixedResult != entry.Result)
                        forcedResult = fixedResult;
                }

                if (forcedResult != null && entry.Result != forcedResult)
                {
                    entry.Result = forcedResult;
                    changed = true;
                }
            }

            if (!changed)
                return;

            var serializer = YamlHelper.CreateSerializer();
            FileHelper.WriteAllTextWithRetry(modPath, serializer.Serialize(results));
        }

        // Re-reads the just-packaged Files/Mod/PlotData.csv and force-corrects column 9's
        // "{0};RobHeroItemChoose;{1}" template's {1} slot (PlotController.RobHeroItemChoose(n)'s
        // callParam) back to its own raw Chinese text - see
        // Tests/docs/plotdata-column9-crash-and-repair-pattern.md and
        // DragonHeirPlugin/docs/robheroitemchoose-getherofix.md for why: that callParam is passed
        // straight into WorldData.GetHero, which looks a hero up by raw (dot-stripped) Chinese name,
        // never its translated display name.
        //
        // Deliberately scoped by the ACTUAL template text read back from
        // Files/Converted/PlotData.csv.yaml (line.Templates, Split == 9, Template ==
        // "{0};RobHeroItemChoose;{1}" exactly) rather than by fragment position (SubIndex == 1)
        // alone - column 9 is shared by every choice function in this game, and a different
        // template shape could in principle also land a second fragment at SubIndex 1 for an
        // unrelated reason. Matching the literal template text first, then reconstructing BOTH the
        // translated and raw versions of that exact template from the SAME fragments
        // (CompoundFieldSplitter.Reconstruct with .Translated vs .Text), guarantees the correction
        // only ever touches a row confirmed to be this exact shape, and uses the fragment's own raw
        // text (never a reverse-translation/name-dictionary lookup that could miss or mismatch).
        //
        // Runs as a packaging-time-only fixup (post-file rewrite, same pattern as
        // ApplyDynamicStringResultOverrides above) rather than a CustomColumnRepair/translation-time
        // hook, since the {1} slot must never be translated in the first place, not merely repaired
        // after an LLM call.
        private const string RobHeroItemChooseTemplate = "{0};RobHeroItemChoose;{1}";

        private static void RepairRobHeroItemChooseCallParam(string workingDirectory, TextFileToSplit textFile)
        {
            if (textFile.Path != "PlotData.csv")
                return;

            var modPath = $"{workingDirectory}/Mod/{textFile.Path}";
            var convertedPath = $"{workingDirectory}/Converted/{textFile.Path}.yaml";
            if (!File.Exists(modPath) || !File.Exists(convertedPath))
                return;

            var deserializer = YamlHelper.CreateDeserializer();
            var lines = deserializer.Deserialize<List<TranslationLine>>(File.ReadAllText(convertedPath)) ?? new();

            var packagedToRaw = new Dictionary<string, string>();

            foreach (var line in lines)
            {
                var template = line.Templates.FirstOrDefault(t => t.Split == 9 && t.Template == RobHeroItemChooseTemplate);
                if (template == null)
                    continue;

                var fragments = line.Splits.Where(s => s.Split == 9).OrderBy(s => s.SubIndex).ToList();
                if (fragments.Count != 2 || fragments.Any(f => string.IsNullOrEmpty(f.Translated)))
                    continue;

                var translatedReconstructed = CompoundFieldSplitter.Reconstruct(template.Template, fragments.Select(f => f.Translated).ToList());

                // Only {1} (SubIndex 1, the callParam) goes back to its own raw text - {0}
                // (choiceText, SubIndex 0) stays translated. Reconstructing with a fully-raw
                // fragment list here would revert the whole cell, not just the callParam slot.
                var mixedFragments = fragments.Select(f => f.SubIndex == 1 ? f.Text : f.Translated).ToList();
                var correctedReconstructed = CompoundFieldSplitter.Reconstruct(template.Template, mixedFragments);

                packagedToRaw[translatedReconstructed] = correctedReconstructed;
            }

            if (packagedToRaw.Count == 0)
                return;

            // NOT File.ReadAllLines: PlotData.csv's own narrative column routinely embeds a real
            // "\n" inside a quoted field (RFC 4180-style), so naive line-splitting chops a single
            // logical row into multiple array entries whenever that row's own last column spans
            // multiple physical lines. Re-parsing/rebuilding a truncated fragment as if it were the
            // whole row loses track of the still-open quote, dropping it entirely once rebuilt -
            // exactly the "one bad row poisons the whole sequential load" IndexOutOfRangeException
            // crash documented in plotdata-column9-crash-and-repair-pattern.md, just introduced here
            // instead of by the LLM. SplitCsvRecords below only splits on an unquoted newline, so
            // each entry is always one full logical row (which may itself still contain an embedded
            // "\n").
            var csvLines = SplitCsvRecords(File.ReadAllText(modPath));
            var changed = false;

            for (var i = 0; i < csvLines.Count; i++)
            {
                var columns = CompoundFieldSplitter.ParseCsvRow(csvLines[i]);
                if (columns.Length <= 9 || !packagedToRaw.TryGetValue(columns[9], out var rawValue) || columns[9] == rawValue)
                    continue;

                columns[9] = rawValue;
                csvLines[i] = CompoundFieldSplitter.RebuildCsvRow(columns);
                changed = true;
            }

            if (changed)
                FileHelper.WriteAllLinesWithRetry(modPath, csvLines);
        }

        // Quote-aware record split: only breaks on '\n' when not inside a quoted field, so a
        // narrative cell's own embedded newline never gets mistaken for a row boundary. Toggling
        // in/out-of-quotes on every literal '"' (rather than look-ahead matching) already handles
        // RFC 4180's doubled-quote escape correctly, since a "" pair toggles twice and nets out to
        // no state change - same convention CompoundFieldSplitter.ParseCsvRow relies on.
        private static List<string> SplitCsvRecords(string content)
        {
            var records = new List<string>();
            var current = new StringBuilder();
            var inQuotes = false;

            foreach (var c in content)
            {
                if (c == '"')
                    inQuotes = !inQuotes;

                if (c == '\n' && !inQuotes)
                {
                    records.Add(StripTrailingCr(current.ToString()));
                    current.Clear();
                    continue;
                }

                current.Append(c);
            }

            if (current.Length > 0)
                records.Add(StripTrailingCr(current.ToString()));

            return records;
        }

        private static string StripTrailingCr(string line) =>
            line.EndsWith('\r') ? line[..^1] : line;

        // Drops junk dynamic-string dictionary entries whose Raw contains no Chinese characters at
        // all (same pattern as DragonHeirPlugin/MainPlugin.cs's ChineseCharPattern) - only text
        // containing real Chinese characters is ever a genuine translatable fragment. Filtering
        // here at packaging time means the plugin's runtime dictionary never re-checks this per
        // match on every hot-path call. See docs/gamefilehandling-reference.md.
        internal static readonly Regex ChineseCharPattern = new(@"\p{IsCJKUnifiedIdeographs}", RegexOptions.Compiled);

        private static void RemoveNonChineseDynamicStringEntries(string workingDirectory, TextFileToSplit textFile)
        {
            var modPath = $"{workingDirectory}/Mod/{textFile.Path}.yaml";
            if (!File.Exists(modPath))
                return;

            var deserializer = YamlHelper.CreateDeserializer();
            var results = deserializer.Deserialize<List<DynamicStringResult>>(File.ReadAllText(modPath)) ?? new();

            var filtered = results.Where(entry => !string.IsNullOrEmpty(entry.Raw) && ChineseCharPattern.IsMatch(entry.Raw)).ToList();
            if (filtered.Count == results.Count)
                return;

            var serializer = YamlHelper.CreateSerializer();
            FileHelper.WriteAllTextWithRetry(modPath, serializer.Serialize(filtered));
        }

        public static async Task PackageFinalTranslationAsync(string workingDirectory, TextFileToSplit[] textFiles)
        {
            string outputPath = $"{workingDirectory}/Mod";

            if (Directory.Exists(outputPath))
                Directory.Delete(outputPath, true);

            Directory.CreateDirectory(outputPath);

            var passedCount = 0;
            var qcRejectedCount = 0;
            var rawFallbackCount = 0;

            // Flat-text workflows are packaged separately from CSV files.
            var csvTextFiles = textFiles.Where(t => t.TextFileType == TextFileType.RawCsv);
            var prefabTextFiles = textFiles.Where(t => t.TextFileType == TextFileType.PrefabText);
            var dynamicStringFiles = textFiles.Where(t => t.TextFileType == TextFileType.DynamicStringsIL2CPP);

            foreach (var prefabTextFile in prefabTextFiles)
            {
                var (passed, qcRejected, rawFallback) = await PrefabTextWorkflow.PackagePrefabTextAsync(workingDirectory, prefabTextFile);
                passedCount += passed;
                qcRejectedCount += qcRejected;
                rawFallbackCount += rawFallback;
            }

            foreach (var dynamicStringFile in dynamicStringFiles)
            {
                var (passed, qcRejected, rawFallback) = await DynamicStringWorkflow.PackageDynamicStringsAsync(workingDirectory, dynamicStringFile);
                passedCount += passed;
                qcRejectedCount += qcRejected;
                rawFallbackCount += rawFallback;

                // Force known-bad reconstructed template results regardless of whatever
                // translation currently sits in Files/Converted - see
                // DynamicStringResultOverrides for why this can't just be fixed by editing the
                // Converted/Mod YAML directly (re-export/re-translation would silently undo it).
                ApplyDynamicStringResultOverrides(workingDirectory, dynamicStringFile);

                // Drop junk entries whose Raw has no Chinese at all - see
                // RemoveNonChineseDynamicStringEntries.
                RemoveNonChineseDynamicStringEntries(workingDirectory, dynamicStringFile);
            }

            // Collected via CsvGameDataWorkflow.PackageAsync's onColumnPackaged callback below -
            // see DynamicStringSources.AtlasSpriteNameColumnSources.
            var atlasSpriteNamePairs = new Dictionary<string, List<(string Raw, string Result)>>();

            foreach (var textFile in csvTextFiles)
            {
                var atlasSpriteNameSources = DynamicStringSources.AtlasSpriteNameColumnSources
                    .Where(s => s.CsvFileName == textFile.Path)
                    .ToArray();

                var (passed, qcRejected, rawFallback) = await CsvGameDataWorkflow.PackageAsync(
                    workingDirectory,
                    textFile,
                    onColumnPackaged: (column, rawText, packagedText) =>
                    {
                        // Copy this row's already-translated (Text, Translated) pair for any
                        // AtlasSpriteNameColumnSources column - see that array's comment.
                        foreach (var source in atlasSpriteNameSources.Where(s => s.Column == column))
                        {
                            if (string.IsNullOrEmpty(rawText) || string.IsNullOrEmpty(packagedText))
                                continue;
                            if (!atlasSpriteNamePairs.TryGetValue(source.OutputFileName, out var pairs))
                                atlasSpriteNamePairs[source.OutputFileName] = pairs = new();
                            pairs.Add((rawText, packagedText));
                        }
                    },
                    rowPostProcess: splits =>
                    {
                        // A translated cell ending in a bare comma (e.g. an LLM ending a sentence
                        // with "," instead of a period) is always safe per RFC 4180 quoting, but
                        // the game's own hand-rolled CSV parser (LTCSVLoader) miscounts quote
                        // balance when a quoted field's content ends in ",\"" - it treats the
                        // record as still open and silently merges the NEXT row into it,
                        // permanently dropping that next row from whatever dictionary/list it
                        // should have populated (see KungFuData.csv id=733's description
                        // swallowing id=734's row entirely). Skipped columns keep the raw row's
                        // byte-for-byte value and must not be touched.
                        for (var i = 0; i < splits.Length; i++)
                        {
                            if (textFile.SkipColumns.Contains(i))
                                continue;

                            splits[i] = GameFileHandling.StripTrailingCommaBeforeQuote(splits[i]);
                        }

                        return splits;
                    });

                passedCount += passed;
                qcRejectedCount += qcRejected;
                rawFallbackCount += rawFallback;

                // Runs AFTER CsvGameDataWorkflow.PackageAsync has written this file, same pattern
                // as ApplyDynamicStringResultOverrides below - see that method's own comment for why.
                RepairRobHeroItemChooseCallParam(workingDirectory, textFile);
            }

            // Write out the small, dedicated atlas-sprite-name lookup file(s) collected above -
            // see DynamicStringSources.AtlasSpriteNameColumnSources. Flat raw/result YAML, same
            // shape as the packaged dynamicStrings*.txt.yaml files, so the plugin's existing
            // DictionaryEntry deserializer can load it directly.
            foreach (var (outputFileName, pairs) in atlasSpriteNamePairs)
            {
                var deduped = pairs
                    .GroupBy(p => p.Raw)
                    .Select(g => g.First());

                var yamlLines = deduped.Select(p =>
                    $"- raw: \"{EscapeYamlDoubleQuoted(p.Raw)}\"\n  result: \"{EscapeYamlDoubleQuoted(p.Result)}\"");

                FileHelper.WriteAllTextWithRetry($"{outputPath}/{outputFileName}.yaml", string.Join("\n", yamlLines) + "\n");
            }

            Console.WriteLine($"Passed: {passedCount}");
            Console.WriteLine($"QC failures: {qcRejectedCount}");
            Console.WriteLine($"Fell back to raw: {rawFallbackCount}");
        }

        // Minimal YAML double-quoted scalar escaping (backslash and double-quote only - none of
        // these source strings are expected to contain other control characters).
        private static string EscapeYamlDoubleQuoted(string s) => s.Replace("\\", "\\\\").Replace("\"", "\\\"");
    }
}
