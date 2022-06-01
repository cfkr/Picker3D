using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MovementController : MonoBehaviour
{
    public float _forwardSpeed = -5f;
    private float _horizontalInput;
    private float _horizontalSpeed = 5.0f;
    private Rigidbody _rigidBody;
    private bool move;


    void Start()
    {
        _rigidBody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    
    private void FixedUpdate()
    {

        LeftRightMovement();
        BordersofMovement();
    }

    void LeftRightMovement()
    {
        if (!move)
        {
            
            _horizontalInput = Input.GetAxis("Horizontal") * _horizontalSpeed;
            //_verticalInput = Input.GetAxis("Vertical") * _verticalSpeed;
            // transform.Translate(-_horizontalInput*Time.deltaTime*_forwardSpeed, 0, 0);
            _rigidBody.velocity = new Vector3(_horizontalInput, 0, 20f);
        }
        else
            _rigidBody.velocity = Vector3.zero;
            
        
    }
    void BordersofMovement()
    {
        if (transform.position.x < -7.5f)
        {
            transform.position = new Vector3(-7.5f, transform.position.y, transform.position.z);
        }
        if (transform.position.x > 7.5f)
        {
            transform.position = new Vector3(7.5f, transform.position.y, transform.position.z);
            
        }
    }
      


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "TriggerArea")
        {

            move = true;
            StartCoroutine(xd());
            
        }
        if(other.gameObject.tag=="finish")
        {
            move = true;
        }
        
        
    }
    IEnumerator xd()
    {
        yield return new WaitForSeconds(2);
        move = false;
    }
}
    


