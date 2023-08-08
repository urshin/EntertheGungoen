using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_June : MonoBehaviour
{
    public Rigidbody2D rb; //플레이어 리지드 바디
    private Camera _camera; //메인 카메라 받기




    [Header("플레이어 움직임")]
    [SerializeField]
    private float moveSpeed;

    float xInput;
    float yInput;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        _camera = Camera.main; //카메라 받아오기.

    }

    void Update()
    {
        xInput = Input.GetAxisRaw("Horizontal");
        yInput = Input.GetAxisRaw("Vertical");
        rb.velocity = new Vector2(xInput * moveSpeed, yInput*moveSpeed);

        // ScreenToWorldPoint() 함수를 이용해 마우스의 좌표를 게임 좌표로 변환한다.
        // 2D게임이기에 Vector2로 변환
        Vector2 mousePos = _camera.ScreenToWorldPoint(Input.mousePosition);
        // (마우스 위치 - 오브젝트 위치)로 마우스의 방향을 구한다.
        Vector2 dirVec = mousePos - (Vector2)transform.position;

        // 방향벡터를 정규화한 다음 transform.up 벡터에 계속 대입
        transform.up = dirVec.normalized;
        //Vector3 point = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x,
        //Input.mousePosition.y, -Camera.main.transform.position.z));
        //Debug.Log(point);
    }
}
