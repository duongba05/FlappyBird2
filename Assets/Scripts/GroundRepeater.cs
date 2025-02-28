using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundRepeater : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private float _speed = 2f;
    [SerializeField] private float _width=10f;
    private SpriteRenderer _spriteRenderer;
    private Vector2 startSize;
    void Start()
    {
        _spriteRenderer =GetComponent<SpriteRenderer>();
        startSize = new Vector2(_spriteRenderer.size.x, _spriteRenderer.size.y);    
    }

    // Update is called once per frame
    void Update()
    {
        _spriteRenderer.size = new Vector2(_spriteRenderer.size.x + _speed * Time.deltaTime, _spriteRenderer.size.y);
        if (_spriteRenderer.size.x >_width)
        {
            _spriteRenderer.size = startSize;
        }
    }
}
