using FanslationStudio.LlmKit.Support;

namespace Code;

public class GameTextFiles
{
    public static readonly TextFileToSplit[] TextFilesToSplit = [
        //Biggest one
        new() {Path = "AchievementData.csv", PackageOutput = true },
        new() {Path = "AreaData.csv", PackageOutput = true },
        new() {Path = "ArmorData.csv", PackageOutput = true },
        new() {Path = "BookTypeIconData.csv", PackageOutput = true },
        new() {Path = "BuildingData.csv", PackageOutput = true },
        new() {Path = "FoodData.csv", PackageOutput = true },
        new() {Path = "ForceData.csv", PackageOutput = true },
        new() {Path = "ForceSpeAddDataBase.csv", PackageOutput = true },
        new() {Path = "HeroNatureTalkText.csv", PackageOutput = true },
        new() {Path = "HeroSpeTalkText.csv", PackageOutput = true },
        new() {Path = "HeroTagData.csv", PackageOutput = true },
        new() {Path = "HorseData.csv", PackageOutput = true },
        new() {Path = "InnData.csv", PackageOutput = true },
        new() {Path = "KungFuData.csv", PackageOutput = true },
        new() {Path = "LoveableSpeHero.csv", PackageOutput = true },
        new() {Path = "MartialClubData.csv", PackageOutput = true },
        new() {Path = "MedData.csv", PackageOutput = true },
        new() {Path = "NameData.csv", PackageOutput = true },        
        new() {Path = "ResourcePointTypeData.csv", PackageOutput = true },
        new() {Path = "SkinDataBase.csv", PackageOutput = true },
        new() {Path = "SpeAddDataBase.csv", PackageOutput = true },
        new() {Path = "SpeHeroData.csv", PackageOutput = true },
        //new() {Path = "SpeHeroFaceData.csv", PackageOutput = true },
        new() {Path = "SummonData.csv", PackageOutput = true },
        new() {Path = "SummonKungFuData.csv", PackageOutput = true },
        new() {Path = "TechDataBase.csv", PackageOutput = true },
        new() {Path = "TipsData.csv", PackageOutput = true },
        new() {Path = "WeaponData.csv", PackageOutput = true },

        // Main one
        new() {Path = "PlotData.csv", PackageOutput = true },
    ];
}