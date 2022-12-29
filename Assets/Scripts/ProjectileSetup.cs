using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileSetup : MonoBehaviour
{
    [SerializeField] private float projectileSpeed = 20f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        MoveForward();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("enemy"))
        {
            Destroy(other.gameObject);
            Destroy(gameObject);
        }
    }

    void MoveForward()
    {
        transform.Translate(Vector3.up * Time.deltaTime * projectileSpeed);
    }
}
