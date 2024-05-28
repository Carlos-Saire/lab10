using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Player : MonoBehaviour
{
    SpriteRenderer _spriterenderer;
    Transform _transform;
    public float _speed;
    sbyte _xdirection=1;
    sbyte _ydirection = 1;
    void Awake()
    {
        _transform = GetComponent<Transform>();
        _spriterenderer = GetComponent<SpriteRenderer>();
    }
    void Update()
    {
        _transform.position = new Vector2(_transform.position.x +_speed*_xdirection * Time.deltaTime, _transform.position.y + _speed * _ydirection*Time.deltaTime);
        if(_transform.position.x> 7.3|| _transform.position.x < -7.3)
        {
            Rotation();
            _xdirection *= -1;
        }
        if (_transform.position.y > 4 || _transform.position.y < -4)
        {
            Rotation();
            _ydirection *= -1;
        }
    }
    void Rotation()
    {
        if (_spriterenderer.flipX == true)
        {
            _spriterenderer.flipX = false;
            _spriterenderer.flipY = false;
        }
        else
        {
            _spriterenderer.flipX = true;
            _spriterenderer.flipY = true;
        }
    } 
}
