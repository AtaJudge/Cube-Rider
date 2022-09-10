using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{
   public Transform player;
   public TextMeshProUGUI scoreText;

   private void Update()
   {
      scoreText.text = transform.position.z.ToString("0");
   }
}
