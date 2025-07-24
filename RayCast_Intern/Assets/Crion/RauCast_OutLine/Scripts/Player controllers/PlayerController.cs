using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public CharacterController cc;
    public GameObject player;
    [SerializeField] private Camera cam;
    [SerializeField] private float Sensitivity;
    public float speed = 5f;
    public bool isMoving;
    public float xRotation = 0f;
    public float yRotation = 0f;
    private void Start()
    {
        cc.enabled = true;
        
    }
    private void Update()
    {
        if (Input.GetMouseButton(1))
        {
            float mouseX = Input.GetAxis("Mouse X") * Sensitivity * Time.deltaTime;
            float mouseY = Input.GetAxis("Mouse Y") * Sensitivity * Time.deltaTime;

            xRotation -= mouseY;
            yRotation += mouseX;
            yRotation = Mathf.Clamp(60, -60, yRotation);
            xRotation = Mathf.Clamp(xRotation, -60f, 60f);
            transform.rotation = Quaternion.Euler(xRotation, yRotation, 0);  
        }
            float horizontal = Input.GetAxis("Horizontal");
            float vertical = Input.GetAxis("Vertical");
            Vector3 forward = transform.forward * vertical;
            Vector3 right = transform.right * horizontal;

            cc.SimpleMove(Vector3.Normalize(forward + right) * speed);
            isMoving = cc.velocity.sqrMagnitude > 0.0f ? true : false;
        
    }
}
