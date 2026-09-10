using TMPro;
using UnityEngine;

public class DEMO : MonoBehaviour
{
    public TextMeshProUGUI textbox;
 
 public void OnCLick()
    {
        textbox.text = "I have changed";
    }
}
