
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.Collections;


public class PlayerController : MonoBehaviour
{

    private Rigidbody rb_player;
    public float speed = 1500f;
    private int score = 0;
    public int health = 5;
    
    public Text scoreText;
    public Text healthText;
    public Text winlose;
    public Image screen;

    // Start is called before the first frame update
    void Start()
    {
        rb_player = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // Move Up
        if (Input.GetKey("w") || Input.GetKey("up"))
        {
            rb_player.AddForce(0, 0, speed * Time.deltaTime);
        }
        // Move Down
        if (Input.GetKey("s") || Input.GetKey("down"))
        {
            rb_player.AddForce(0, 0, -speed * Time.deltaTime);
        }
        // Move Left
        if (Input.GetKey("a") || Input.GetKey("left"))
        {
            rb_player.AddForce(-speed * Time.deltaTime, 0, 0);
        }
        // Move Right
        if (Input.GetKey("d") || Input.GetKey("right"))
        {
            rb_player.AddForce(speed * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey(KeyCode.Escape))
        {
            SceneManager.LoadScene("menu");
        }

        if (health == 0)
        {
            screen.gameObject.SetActive(true);
            winlose.color = Color.white;
            screen.color = Color.red;
            winlose.text = "Game Over!";
            StartCoroutine(LoadScene(3f));
            health = 5;
            score = 0;
        }
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Pickup"))
        {
            score++;
            // Debug.Log($"Score: {score}");
            SetScoreText();
            Destroy(other.gameObject);
        }
        if (other.CompareTag("Trap"))
        {
            health--;
            //Debug.Log($"Health: {health}");
            SetHealthText();
        }
        if (other.CompareTag("Goal"))
        {
            //Debug.Log("You win!");
            screen.gameObject.SetActive(true);
            winlose.color = Color.black;
            winlose.text = "You Win!";
            screen.color = Color.green;
            StartCoroutine(LoadScene(3f));
        }
    }
    void SetScoreText()
    {
        scoreText.text = "Score: " + score;
    }
    void SetHealthText()
    {
        healthText.text = "Health: " + health;
    }
    IEnumerator LoadScene(float seconds)
    {
        yield return new WaitForSeconds(seconds);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
