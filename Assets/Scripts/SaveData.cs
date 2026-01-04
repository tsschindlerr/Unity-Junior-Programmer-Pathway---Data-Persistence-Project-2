using UnityEngine;

public class SaveData : MonoBehaviour
{
    
    public static SaveData Instance;
    public string PlayerName;


    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);
    }
}
