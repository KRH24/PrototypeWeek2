using UnityEngine;
using TMPro;

public class NewMonoBehaviourScript : MonoBehaviour
{
     private int score = 0;

    public TextMeshProUGUI scoreText;


    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Coin")){
            Destroy(other.gameObject);
            Debug.Log("hiting");
            score += 1;
            scoreText.text = "Score: " + score.ToString();
        }

    }
}
