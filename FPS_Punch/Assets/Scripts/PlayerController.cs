using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float gravityScale = 1f;

    private CharacterController characterController;

    private float yVelocity = 0f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        characterController = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        ApplyGravity();
    }

    private void ApplyGravity()
    {
        yVelocity += Physics.gravity.y * gravityScale * Time.deltaTime;
        characterController.Move(new Vector3(0f, yVelocity, 0f) * Time.deltaTime);
    }
}
