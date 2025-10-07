using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;



public class CoinTrigger : MonoBehaviour
{
    // Effect when coins are collected
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private Collider2D collision;

    //For the explosion effect of coins
    public GameObject explosionEffect;

    // All the things needed for the Timer Label and Score Label
    public UIDocument uiDocument;
    private float timeCurrent = 0f;
    private float timeStart = 60f;
    private Label scoreText;
    private Label timeLeft;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // Starts the timer (I made it 60 seconds long)
        timeCurrent = timeStart;

        //Initializing Coin Stuff
        rb = GetComponent<Rigidbody2D>();
        collision = GetComponent<Collider2D>();

        //Setting the Labels
        scoreText = uiDocument.rootVisualElement.Q<Label>("ScoreLabel");
        timeLeft = uiDocument.rootVisualElement.Q<Label>("TimeLeft");
    }

    // Update is called once per frame
    void Update()
    {
        // Updates the countdown every second
        timeCurrent -= Time.deltaTime;
        timeLeft.text = ("Time Left:" + Mathf.FloorToInt(timeCurrent));

        // If the timer runs out
        if (timeCurrent <= 0f){
            timeCurrent = 0f;
            timeLeft.text = ("You Lose!");
            //End game function
            Invoke("EndGame", 3f);
        }
    }
    void OnTriggerEnter2D(Collider2D collision)
    {   
        int layer = collision.gameObject.layer;
        int playerIndexLayer = LayerMask.NameToLayer("Player");        

        // Destroys the Coin 
        // Uses game tags to check if player collides w/ coins
        if (layer == playerIndexLayer){
            int score = Int32.Parse(scoreText.text.Substring(scoreText.text.Length - 2));
            score += 1;
            scoreText.text = ("Coins Collected:" + score.ToString("D2"));
            Destroy(gameObject);

            //Sparkle on collection
            GameObject coinSparkle = Instantiate(explosionEffect, transform.position, transform.rotation);
            Destroy(coinSparkle, 1f);

            //End Game if all coins collected
            if (score == 22)
            {
                timeLeft.text = ("You Win!");
                EndGame();
            }
        }
    }
    void EndGame()
    {
        //Restart scene, add you lost title, and restart button
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
