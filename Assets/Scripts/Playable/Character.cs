using UnityEngine;

/// <summary>
/// Base class for character behavior.
/// </summary>
public class Character : MonoBehaviour
{
    protected Rigidbody2D rb;
    protected SpriteRenderer sprite;
    [SerializeField] protected float speed = 7f;
    protected bool isMoving = false;
    protected AudioManager audioManager;

    /// <summary>
    /// Initializes the character's components.
    /// </summary>
    protected virtual void Start()
    {
        InitializeComponents();
        FindAudioManager();
    }

    /// <summary>
    /// Updates the character's movement and sprite flipping.
    /// </summary>
    protected virtual void Update()
    {
        HandleMovementInput();
        FlipSprite();
    }

    /// <summary>
    /// Initializes the Rigidbody2D and SpriteRenderer components.
    /// </summary>
    protected void InitializeComponents()
    {
        rb = GetComponent<Rigidbody2D>();
        sprite = GetComponent<SpriteRenderer>();
    }

    /// <summary>
    /// Handles movement input and updates the isMoving flag.
    /// </summary>
    protected void HandleMovementInput()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");
        rb.velocity = new Vector2(horizontal * speed, vertical * speed);
        isMoving = (horizontal != 0 || vertical != 0);
    }

    /// <summary>
    /// Flips the character's sprite based on movement direction.
    /// </summary>
    protected void FlipSprite()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        sprite.flipX = horizontal < 0f;
    }
    /// <summary>
    /// Finds the AudioManager in the scene.
    /// </summary>
    protected void FindAudioManager()
    {
        GameObject audioManagerObject = GameObject.FindGameObjectWithTag("AudioManager");
        if(audioManagerObject != null)
        {
            audioManager = audioManagerObject.GetComponent<AudioManager>();
        }
        else
        {
            Debug.LogError("No AudioManager found in the scene.");
        }
    }

    /// <summary>
    /// Handles collisions by stopping movement and freezing rotation.
    /// </summary>
    protected virtual void OnCollisionEnter2D(Collision2D collision)
    {
        HandleCollision();
    }

    /// <summary>
    /// Stops the character's movement and freezes its rotation.
    /// </summary>
    protected void HandleCollision()
    {
        rb.velocity = Vector2.zero;
        rb.constraints = RigidbodyConstraints2D.FreezeRotation;
    }
}
