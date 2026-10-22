
using UnityEngine;
using UnityEngine.InputSystem;
//hello its me verity your personal helper friend🙂
public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float gravity = -9.81f;

    private PlayerInput playerInput;
    private CharacterController controller;
    private InputAction moveAction;
    private InputAction interactAction;

    private Vector3 velocity;

    void Awake()
    {
        playerInput = GetComponent<PlayerInput>();
        controller = GetComponent<CharacterController>();

        moveAction = playerInput.actions["Move"];
        interactAction = playerInput.actions["Interact"];
    }

    void Update()
    {
        Vector2 input = moveAction.ReadValue<Vector2>();

        Vector3 move = new Vector3(input.x, 0f, input.y);

        move = Vector3.ClampMagnitude(move, 1f);
        //gravity which i dont rlly need i think but its here from a previous project
        if (controller.isGrounded && velocity.y < 0f)
        {
            velocity.y = -2f;
        }

        velocity.y += gravity * Time.deltaTime;

        Vector3 movement = move * moveSpeed;
        movement.y = velocity.y;

        controller.Move(movement * Time.deltaTime);

        //interaction

        if (interactAction.WasPressedThisFrame())
        {
            Interact();
        }
    }

    //actual interaction code that will 100% work 😀😀😀

    void Interact()
    {
        Debug.Log("You interacted!");
    }
}
