using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class move : MonoBehaviour
{

    private Rigidbody rigidbody;    //reference to the rigidbody component
    public float speed; //[Range(0.0f, 5.0f)]   [SerializeField]

    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();  //get component when scene starts
    }

    // Update is called once per frame
    void Update()
    {
        rigidbody.AddForce(new Vector3(Input.GetAxis("Horizontal") * speed, 0.0f, Input.GetAxis("Vertical") * speed));
    }
}
