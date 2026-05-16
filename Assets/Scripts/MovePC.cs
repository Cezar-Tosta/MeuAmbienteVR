using UnityEngine;
using UnityEngine.InputSystem;

public class MovePC : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float mouseSensitivity = 2f;

    private float rotationX = 0f;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    void Update()
    {
        // Rotação com o mouse
        float mouseX = Mouse.current.delta.x.ReadValue() * mouseSensitivity;
        float mouseY = Mouse.current.delta.y.ReadValue() * mouseSensitivity;

        rotationX -= mouseY;
        rotationX = Mathf.Clamp(rotationX, -80f, 80f);

        transform.localRotation = Quaternion.Euler(rotationX, 0f, 0f);
        transform.parent.Rotate(Vector3.up * mouseX);

        // Movimentação com teclado
        Vector2 input = Vector2.zero;

        if (Keyboard.current.wKey.isPressed || Keyboard.current.upArrowKey.isPressed)
            input.y += 1;
        if (Keyboard.current.sKey.isPressed || Keyboard.current.downArrowKey.isPressed)
            input.y -= 1;
        if (Keyboard.current.aKey.isPressed || Keyboard.current.leftArrowKey.isPressed)
            input.x -= 1;
        if (Keyboard.current.dKey.isPressed || Keyboard.current.rightArrowKey.isPressed)
            input.x += 1;

        Vector3 dir = (transform.forward * input.y + transform.right * input.x) * moveSpeed * Time.deltaTime;
        transform.parent.Translate(dir, Space.World);
    }
}