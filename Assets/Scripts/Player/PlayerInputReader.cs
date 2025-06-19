using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(PlayerMover))]
public class PlayerInputReader : MonoBehaviour
{
    private PlayerInputActions _inputActions;
    private PlayerMover _playerMover;

    private void Awake()
    {
        _inputActions = new PlayerInputActions();
        _playerMover = GetComponent<PlayerMover>();
    }

    private void OnEnable()
    {
        _inputActions.Player.Enable();
    }

    private void OnDisable()
    {
        _inputActions.Player.Disable();
    }

    private void Update()
    {
        Vector2 moveInput = _inputActions.Player.Move.ReadValue<Vector2>();
        _playerMover.Move(moveInput);
    }
}