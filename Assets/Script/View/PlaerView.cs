using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaerView : MonoBehaviour
{
    [SerializeField] private Rigidbody2D _rb;
    private PlayerInput _plaerInput = new PlayerInput();
    private PlayerController _playerController;
    private bool _onGrounded;
    public Rigidbody2D Rb { get => _rb; }


    void Start()
    {
        _playerController = new PlayerController(_rb);        
    }
    void Update()
    {
        Debug.Log(_plaerInput.PlayerInteract());
        _playerController.JumpMovment(_plaerInput.PlayerInteract());
        if (!_onGrounded) 
        {
            _playerController.HorizontalMovment(0.03f, _plaerInput.PlayerMove);
            _playerController.ChangeRotation(transform);
        }
        else  
        { 
            _playerController.HorizontalMovment(0.001f, _plaerInput.PlayerMove);
        }
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.GetComponent<GroundView>())
        {
            //Debug.Log("Touch");
            _onGrounded = true;
        }
    }

    public void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.GetComponent<GroundView>())
        {
            //Debug.Log("Touch");
            _onGrounded = false;
        }
    }
}


public class PlayerInput
{
    public float PlayerInteract()
    {
        float jumpPower = 3;
        if (Input.GetKeyDown(KeyCode.Space))
        {
            return jumpPower; 
        }
        return 0;
    }
    public float PlayerMove => Input.GetAxis("Horizontal");
}

public class PlayerController
{
    private Rigidbody2D _rb;

    public PlayerController(Rigidbody2D rb)
    {
        _rb = rb;
    }

    public void JumpMovment(float power)
    {
        _rb.AddForce(new Vector2(0 * power , 4 * power ), ForceMode2D.Impulse);
    }
    public void ChangeRotation(Transform player)
    {
        player.rotation = new Quaternion(0,0,0,0);
    }

    public void HorizontalMovment(float power, float playerHorizontalInput)
    {
        _rb.velocity += new Vector2(playerHorizontalInput * power, 0);
    }
}