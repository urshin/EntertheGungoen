using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_June : MonoBehaviour
{
    public Rigidbody2D rb; //�÷��̾� ������ �ٵ�
    private Camera _camera; //���� ī�޶� �ޱ�




    [Header("�÷��̾� ������")]
    [SerializeField]
    private float moveSpeed;

    float xInput;
    float yInput;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        _camera = Camera.main; //ī�޶� �޾ƿ���.

    }

    void Update()
    {
        xInput = Input.GetAxisRaw("Horizontal");
        yInput = Input.GetAxisRaw("Vertical");
        rb.velocity = new Vector2(xInput * moveSpeed, yInput*moveSpeed);

        // ScreenToWorldPoint() �Լ��� �̿��� ���콺�� ��ǥ�� ���� ��ǥ�� ��ȯ�Ѵ�.
        // 2D�����̱⿡ Vector2�� ��ȯ
        Vector2 mousePos = _camera.ScreenToWorldPoint(Input.mousePosition);
        // (���콺 ��ġ - ������Ʈ ��ġ)�� ���콺�� ������ ���Ѵ�.
        Vector2 dirVec = mousePos - (Vector2)transform.position;

        // ���⺤�͸� ����ȭ�� ���� transform.up ���Ϳ� ��� ����
        transform.up = dirVec.normalized;
        //Vector3 point = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x,
        //Input.mousePosition.y, -Camera.main.transform.position.z));
        //Debug.Log(point);
    }
}
