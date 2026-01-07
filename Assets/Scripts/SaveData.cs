using UnityEngine;
using System.IO;

public class SaveData : MonoBehaviour
{

    public static SaveData Instance;
    public string PlayerName;
    private int Highscore = 0;

    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);

        LoadHighscore();
    }

    public int GetHighscore()
    {
        return Highscore;
    }

    [System.Serializable]
    class SaveFile
    {
        public int score;
    }

    public void SaveHighscore(int score)
    {
        Highscore = score;

        SaveFile data = new SaveFile();
        data.score = score;

        string json = JsonUtility.ToJson(data);
        File.WriteAllText(Application.persistentDataPath + "/dpp2SaveData.json", json);
    }

    public void LoadHighscore()
    {
        string path = Application.persistentDataPath + "/dpp2SaveData.json";
        if (File.Exists(path))
        {
            string json = File.ReadAllText(path);
            SaveFile data = JsonUtility.FromJson<SaveFile>(json);
            Highscore = data.score;
        }
    }
}
