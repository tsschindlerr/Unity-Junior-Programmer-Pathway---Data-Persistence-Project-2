using UnityEngine;
using TMPro;


public class ScoreDisplay : MonoBehaviour
{
    public TextMeshProUGUI score;
    void Start()
    {
        if(SaveData.Instance != null)
        {
            score.text = SaveData.Instance.PlayerName;
        }
    }

    
    void Update()
    {
        
    }
}
