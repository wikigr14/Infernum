using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float movementSpeed = 2f; // speed = riz levels

    private Rigidbody2D rb; // physics go brrr

    public KeyCode left;
    public KeyCode right;
    public KeyCode up;
    public KeyCode down;

    private Vector2 movementDirection; // where bro movin?



    // start of the grindset
    void Start()
    {
        rb = GetComponent<Rigidbody2D>(); // lock in the physics fr
    }

    // every frame, never stop hustlin
    void Update()
    {
        float moveX = 0f;
        float moveY = 0f;

        if (Input.GetKey(right)) moveX += 1;
        if (Input.GetKey(left)) moveX -= 1;     //Not bussin
        if (Input.GetKey(up)) moveY += 1;
        if (Input.GetKey(down)) moveY -= 1;

        movementDirection = new Vector2(moveX, moveY).normalized; //What the sigma fr fr
    }

    // physics loop, we movin diff now
    void FixedUpdate()
    {
        rb.linearVelocity = movementDirection * movementSpeed; // giga drift unlocked
    }
}