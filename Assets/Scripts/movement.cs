using UnityEngine;

public class movement : MonoBehaviour
{
   public float XForce = 10f;
    public float YForce = 10f;
    private Rigidbody2D rb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            rb.AddForce(new Vector2(XForce, 0f));
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rb.AddForce(new Vector2(-XForce, 0f));
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            rb.AddForce(new Vector2(0f, -YForce));
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            rb.AddForce(new Vector2(0f, YForce));
        }
        
    }
}
