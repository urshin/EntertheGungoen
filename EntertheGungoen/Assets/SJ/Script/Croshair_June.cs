using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Croshair_June : MonoBehaviour
{
    public Rigidbody2D rb; //플레이어 리지드 바디
    private Camera _camera; //메인 카메라 받기
    // Start is called before the first frame update
    void Start()
    {
        _camera = Camera.main; //카메라 받아오기.

    }

    // Update is called once per frame
    void Update()
    {
        Vector2 mousePos = _camera.ScreenToWorldPoint(Input.mousePosition);
        // 마우스 위치 == 크로스헤어 위치
        Vector2 dirVec = mousePos;



        gameObject.transform.position = dirVec;
        
    }
}
