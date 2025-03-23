using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float movementSpeed = 2f; // speed = riz levels

    private Rigidbody2D rb; // physics go brrr

    private Vector2 movementDirection; // where bro movin?



    // start of the grindset
    void Start()
    {
        rb = GetComponent<Rigidbody2D>(); // lock in the physics fr
    }

    // every frame, never stop hustlin
    void Update()
    {
        // input from the NPC behind the keyboard
        movementDirection = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical")); // What the sigma moment fr fr
    }

    // physics loop, we movin diff now
    void FixedUpdate()
    {
        rb.linearVelocity = movementDirection * movementSpeed; // giga drift unlocked
    }
}