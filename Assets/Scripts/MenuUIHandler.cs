using JetBrains.Annotations;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuUIHandler : MonoBehaviour
{
    public TMP_InputField inputField;
    public void StartNew()
    {
        SceneManager.LoadScene(1);
    }

    public void ExitToMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void GrabPlayerName()
    {
        string playerName;
        playerName = inputField.text;
        SaveData.Instance.PlayerName = playerName;
    }
}
