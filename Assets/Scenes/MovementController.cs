
using UnityEngine;

public class MovementController : MonoBehaviour
{

    public float MovementSpeed = 1;
    public float JumpForce = 1;

    private Rigidbody _rigidbody;
    // Start is called before the first frame update
    void Start()
    {
        Rigidbody2D rigidbody2D1 = GetComponent<Rigidbody2D>();
        _rigidbody = rigsidbody2D1;

    // Update is called once per frame
    void Update()
    {
        //makes the movement happen you can changes the speed in unity under the compent throught the public float
        var movement = Input.GetAxis("Horizontal");
        transform.position += new Vector3(movement, 0, 0) * Time.deltaTime * MovementSpeed;

        // makes the jump happen the speed and hight can be determent in unity throught the public float
        if(Input.GetButtonDown("Jump") && Mathf.Abs(_rigidbody.velocity.y)< 0.001f)
        {
            _rigidbody.AddForce(new Vector2(0, JumpForce), (ForceMode)ForceMode2D.Impulse);
        }
    }
}
