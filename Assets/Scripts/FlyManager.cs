using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class FlyManager : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private float _velocity = 1.5f;
    [SerializeField] private float _rotateSpeed = 10f;
    Rigidbody2D rigidbody2D;
    void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Mouse.current.leftButton.wasPressedThisFrame)
        {
            rigidbody2D.velocity =Vector2.up * _velocity;
        }
    }
    private void FixedUpdate()
    {
        transform.rotation =Quaternion.Euler(0, 0, rigidbody2D.velocity.y*_rotateSpeed); 
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        StartCoroutine(WaitAndGameOver());
    }
    IEnumerator WaitAndGameOver()
    {
        yield return new WaitForSeconds(0.011f);
        if (GameManager.instance != null)
        {
            GameManager.instance.GameOver();
        }
    }
}
