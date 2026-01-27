using UnityEngine;
using UnityEngine.InputSystem;

namespace BaldeX.Player {
    [RequireComponent(typeof(CharacterController))]
    public class PlayerController : MonoBehaviour {
        [Header("Movement Stats")]
        public float walkSpeed = 4.0f;
        public float sprintSpeed = 7.5f;
        public float rotationSmoothTime = 0.12f;
        public float speedChangeRate = 10.0f;

        [Header("Jump & Gravity")]
        public float jumpHeight = 1.2f;
        public float gravity = -15.0f;
        public float terminalVelocity = -53.0f;

        [Header("Player State")]
        public bool isSprinting;
        public bool isGrounded;
        public bool isCrouching;

        // Références internes
        private CharacterController _controller;
        private GameObject _mainCamera;
        private Animator _animator;

        // Variables de calcul
        private float _speed;
        private float _animationBlend;
        private float _targetRotation = 0.0f;
        private float _rotationVelocity;
        private float _verticalVelocity;

        private void Awake() {
            if (_mainCamera == null) _mainCamera = GameObject.FindGameObjectWithTag("MainCamera");
            _controller = GetComponent<CharacterController>();
            _animator = GetComponent<Animator>();
        }

        private void Update() {
            ApplyGravity();
            CheckGrounded();
            HandleMovement();
        }

        private void HandleMovement() {
            // Lecture des inputs (Simulé ici, mais lié à l'Input System)
            Vector2 input = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
            float targetSpeed = isSprinting ? sprintSpeed : walkSpeed;

            if (input == Vector2.zero) targetSpeed = 0.0f;

            float currentHorizontalSpeed = new Vector3(_controller.velocity.x, 0.0f, _controller.velocity.z).magnitude;
            float speedOffset = 0.1f;

            // Accélération/Décélération fluide
            if (currentHorizontalSpeed < targetSpeed - speedOffset || currentHorizontalSpeed > targetSpeed + speedOffset) {
                _speed = Mathf.Lerp(currentHorizontalSpeed, targetSpeed, Time.deltaTime * speedChangeRate);
                _speed = Mathf.Round(_speed * 1000f) / 1000f;
            } else {
                _speed = targetSpeed;
            }

            Vector3 inputDirection = new Vector3(input.x, 0.0f, input.y).normalized;

            if (input != Vector2.zero) {
                _targetRotation = Mathf.Atan2(inputDirection.x, inputDirection.z) * Mathf.Rad2Deg + _mainCamera.transform.eulerAngles.y;
                float rotation = Mathf.SmoothDampAngle(transform.eulerAngles.y, _targetRotation, ref _rotationVelocity, rotationSmoothTime);
                transform.rotation = Quaternion.Euler(0.0f, rotation, 0.0f);
            }

            Vector3 targetDirection = Quaternion.Euler(0.0f, _targetRotation, 0.0f) * Vector3.forward;

            _controller.Move(targetDirection.normalized * (_speed * Time.deltaTime) + new Vector3(0.0f, _verticalVelocity, 0.0f) * Time.deltaTime);

            // Mise à jour Animator
            _animationBlend = Mathf.Lerp(_animationBlend, targetSpeed, Time.deltaTime * speedChangeRate);
            _animator.SetFloat("Speed", _animationBlend);
            _animator.SetBool("Grounded", isGrounded);
        }

        private void ApplyGravity() {
            if (isGrounded) {
                if (_verticalVelocity < 0.0f) _verticalVelocity = -2f;
                if (Input.GetButtonDown("Jump")) {
                    _verticalVelocity = Mathf.Sqrt(jumpHeight * -2f * gravity);
                    _animator.SetTrigger("Jump");
                }
            }
            if (_verticalVelocity > terminalVelocity) _verticalVelocity += gravity * Time.deltaTime;
        }

        private void CheckGrounded() {
            isGrounded = _controller.isGrounded;
        }
    }
}
