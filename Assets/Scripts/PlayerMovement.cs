using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;

    public bool enable = true;
    [Header("Forces")]
    [SerializeField]private float forwardForce = 2000;
    [SerializeField]private float sidewayForce = 1000;

    private float _userInput;
    private void Update()
    {
        _userInput = Input.GetAxis("Horizontal");
    }

    void FixedUpdate()
    {
        if(enable) rb.AddForce(Vector3.right * (sidewayForce * _userInput * Time.fixedDeltaTime) + Vector3.forward *(forwardForce * Time.fixedDeltaTime));

        if (rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().GameOver();
        }
    }
}
