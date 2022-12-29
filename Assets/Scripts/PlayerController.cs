using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float playerSpeed = 30f;
    [SerializeField] private GameObject projectileObject;
    private float xBound = 16f;
    private float xRange = 15.8f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        PlayerMovement();

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(projectileObject, transform.position, projectileObject.transform.rotation);
        }
    }

    void PlayerMovement()
    {
        if (transform.position.x < xBound)
        {
            HorizontalInput();
        }
        else
        {
            transform.position = new Vector3(xRange, 1, -11);
        }

        if (transform.position.x > -xBound)
        {
            HorizontalInput();
        }
        else
        {
            transform.position = new Vector3(-xRange, 1, -11);
        }
    }

    void HorizontalInput()
    {
        transform.Translate(Vector3.right * Time.deltaTime * playerSpeed * Input.GetAxis("Horizontal"));
    }
}
