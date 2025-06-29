using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using Unity.VisualScripting;
using UnityEngine;

public class DataLocalProvider : IDataProvider
{
    private const string SAVE_FILE_EXTENTION = ".json";

    private string fileName;
    private PersistentData _persistentData;
    private ConfigData _config;

    public DataLocalProvider(PersistentData persistentData, ConfigData config)
    {
        _persistentData = persistentData;
        _config = config;
    }

    public IPersistentData PersistentData { get => _persistentData; }
    private string SavePath => Application.persistentDataPath;
    private string FullPath => Path.Combine(SavePath, $"{fileName}{SAVE_FILE_EXTENTION}");
    private bool IsDataAlreadyExist() => File.Exists(FullPath);

    public void SaveDataPlayer(PlayerSave data) 
    {
        _persistentData.PlayerData = data;
        Save();
    }
    public void Save()
    {
        fileName = "PlayerSave";
        File.WriteAllText(FullPath, JsonConvert.SerializeObject(_persistentData.PlayerData, Formatting.Indented, new JsonSerializerSettings
        { 
            ReferenceLoopHandling = ReferenceLoopHandling.Ignore,
        }));
        fileName = "Settings";
        File.WriteAllText(FullPath, JsonConvert.SerializeObject(_persistentData.Settings, Formatting.Indented, new JsonSerializerSettings
        {
            ReferenceLoopHandling = ReferenceLoopHandling.Ignore,
        }));
        fileName = "LevelSaves";
        File.WriteAllText(FullPath, JsonConvert.SerializeObject(_persistentData.LevelSaves, Formatting.Indented, new JsonSerializerSettings
        {
            ReferenceLoopHandling = ReferenceLoopHandling.Ignore,
        }));
    }
    public bool TryLoadData()
    {
        fileName = "PlayerSave";
        if (IsDataAlreadyExist() == false)
        {
            var Save = Resources.Load("Configs/PlayerSave") as TextAsset;
            _persistentData.PlayerData = JsonConvert.DeserializeObject<PlayerSave>(Save.text);
        }
        else
        {
            _persistentData.PlayerData = JsonConvert.DeserializeObject<PlayerSave>(File.ReadAllText(FullPath));
        }

        fileName = "Settings";
        if (IsDataAlreadyExist() == false)
        {
            var Settings = Resources.Load("Configs/Settings") as TextAsset;
            _persistentData.Settings = JsonConvert.DeserializeObject<Settings>(Settings.text);
        }
        else
        {
            _persistentData.Settings = JsonConvert.DeserializeObject<Settings>(File.ReadAllText(FullPath));
        }

        return true;
    }
    public bool TryLoadSavesData()
    {
        fileName = "LevelSaves";
        if (IsDataAlreadyExist() == false)
            return false;
        List<LevelSave> allSaves = JsonConvert.DeserializeObject<List<LevelSave>>(File.ReadAllText(FullPath));

        if (allSaves == null)
        {
            _persistentData.levelSaves = new List<LevelSave>();
            return false;
        }
        else
        {
            _persistentData.levelSaves = new List<LevelSave>();
            for (int i = 0; i < allSaves.Count; i++)
            {
                _persistentData.levelSaves.Add(allSaves[i]);
            }
        }
        return true;
    }
    public bool TryLoadConfig()
    {
        LevelsConfig levels = (LevelsConfig)Resources.Load("Configs/LevelListConfig");

        List<LevelViewConfig> levelViews = new();

        for (int i = 0; i < levels.levels.Length; i++)
        {
            levelViews.Add(levels.levels[i]);
        }
        _config.levels = levelViews;

        if(_config.levels == null)
            return false;

        return true;
    }
    public bool TryLoadLocalization() 
    {
        LocalizationData localization = new LocalizationData();

        fileName = "Ru";
        var RuObj = Resources.Load("Configs/Ru") as TextAsset;
        localization.Ru = JsonConvert.DeserializeObject<Dictionary<string, string>>(RuObj.text);


        fileName = "Eng";
        var EngObj = Resources.Load("Configs/Eng") as TextAsset;
        localization.Eng = JsonConvert.DeserializeObject<Dictionary<string, string>>(EngObj.text);




        _persistentData.LocalizateData = localization;
        return true;
    }
}
