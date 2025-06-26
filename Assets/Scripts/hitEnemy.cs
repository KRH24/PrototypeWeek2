using UnityEngine;
using TMPro;

public class NewMonoBehaviourScript : MonoBehaviour
{
    private int score = 0;

    public TextMeshProUGUI scoreText;
    public AudioSource pickUpSound;
    public float pitchIncrease = 0.1f;
    public GameObject panel;

    void Start()
    {

        pickUpSound = GetComponent<AudioSource>();

    }


    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Coin"))
        {
            Destroy(other.gameObject);
            Debug.Log("hiting");
            score += 1;
            scoreText.text = "Score: " + score.ToString();
            pickUpSound.pitch = pickUpSound.pitch + pitchIncrease;
            pickUpSound.Play();

            if (score >= 3)
            {
                panel.SetActive(true);
            }
        }

    }
    

	
}
