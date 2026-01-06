using UnityEngine;
using TMPro;


public class ScoreDisplay : MonoBehaviour
{
    public TextMeshProUGUI score;
    void Start()
    {
        
    }

    
    void Update()
    {
        score.text = SaveData.Instance.PlayerName;
    }
}
