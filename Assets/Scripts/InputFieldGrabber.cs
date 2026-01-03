using TMPro;
using UnityEngine;

public class InputFieldGrabber : MonoBehaviour
{
    [Header("The value we got from the input field")]
    [SerializeField] private string inputText;

    [Header("Showing the reaction to the player")]
    [SerializeField] private GameObject reactionGroup;
    [SerializeField] private TMP_Text reactionTextBox;


    public void GrabFromInputField (string input)
    {
        inputText = input;
        DisplayReactionToInput();
    }

    private void DisplayReactionToInput()
    {
        reactionTextBox.text = "Welcome " + inputText + "!";
        reactionGroup.SetActive(true);
    }
}
