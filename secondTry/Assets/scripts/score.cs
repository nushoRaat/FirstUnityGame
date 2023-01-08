using UnityEngine;
using TMPro;
public class score : MonoBehaviour
{
    public Transform player;
   // public Text scoreText;
    public TextMeshProUGUI scoreText;
   
    void Update()
    {
       // Debug.Log(player.position.z);
       // scoreText = GetComponent<Text>();
        scoreText.SetText(player.position.z.ToString("0"));
        
    }
}
