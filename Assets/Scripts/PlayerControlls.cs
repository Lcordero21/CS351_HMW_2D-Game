using System;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;
using static UnityEditor.Searcher.SearcherWindow.Alignment;

public class PlayerControls : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [SerializeField] private float moveSpeed;
    [SerializeField] private float jumpForce;
    [SerializeField] private Rigidbody2D rigidBody;

    private bool canMove = true;
    //[SerializeField] private SpriteRenderer spriteRenderer;
    
    void Start()
    {
       rigidBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!canMove) return;
        //Movement controls

        // Jump (Space)
        if ((Keyboard.current.spaceKey.isPressed) && isgrounded())
        {
            rigidBody.AddForce(Vector3.up * jumpForce, ForceMode2D.Impulse);
        }
        // Left movement (A or Left Arrow)
        if (Keyboard.current.aKey.isPressed || Keyboard.current.leftArrowKey.isPressed)
        {
            rigidBody.AddForce(Vector3.left * moveSpeed);
        }
        // Right movement (D or Right Arrow)
        if (Keyboard.current.dKey.isPressed || Keyboard.current.rightArrowKey.isPressed)
        {
            rigidBody.AddForce(Vector3.right * moveSpeed);
        }

        //Restart game early
        if ((Keyboard.current.rKey.isPressed))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }

    //Will disable all movement
    public void DisableControls() => canMove = false;

    public void EnableControls() => canMove = true;

    //Checks if player is on the ground
    private Boolean isgrounded()
    {
        return Physics2D.Raycast(transform.position,Vector2.down, 1f, LayerMask.GetMask("Floor"));
    }

}

