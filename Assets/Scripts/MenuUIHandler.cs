using JetBrains.Annotations;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuUIHandler : MonoBehaviour
{
    public TMP_InputField inputField;
    
    private void Start()
    {
        
    }

    private void Update()
    {
        
    }
    public void GrabPlayerName()
    {
        string playerName;
        playerName = inputField.text;
        SaveData.Instance.PlayerName = playerName;
    }

   
    public void StartNew()
    {
        SceneManager.LoadScene(1);
    }

    public void ExitToMenu()
    {
        SceneManager.LoadScene(0);
    }
       
}
