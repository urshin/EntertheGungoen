using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.PlayerSettings;

public class Player_June : MonoBehaviour
{
    public Rigidbody2D rb; //�÷��̾� ������ �ٵ�
    private Camera _camera; //���� ī�޶� �ޱ�

    Animator anim;

    public GameObject bulletPrefeb;//������ �Ѿ� �� ������Ʈ
    public Transform pos;//������ �Ѿ� ��ġ

    [Header("�÷��̾� ������")]
    [SerializeField]
    private float moveSpeed;
    

    float xInput;
    float yInput;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponentInChildren<Animator>();
        _camera = Camera.main; //ī�޶� �޾ƿ���.

    }

    void Update()
    {
        PlayerMoveAndAim();

    }

    private void PlayerMoveAndAim()
    {
        xInput = Input.GetAxisRaw("Horizontal");
        yInput = Input.GetAxisRaw("Vertical");

        // ScreenToWorldPoint() �Լ��� �̿��� ���콺�� ��ǥ�� ���� ��ǥ�� ��ȯ�Ѵ�.
        // 2D�����̱⿡ Vector2�� ��ȯ
        Vector2 mousePos = _camera.ScreenToWorldPoint(Input.mousePosition);
        // (���콺 ��ġ - ������Ʈ ��ġ)�� ���콺�� ������ ���Ѵ�.
        Vector2 dirVec = mousePos - (Vector2)transform.position;

        // ���⺤�͸� ����ȭ�� ���� transform.up ���Ϳ� ��� ����
        transform.up = dirVec.normalized;
        //Debug.Log(point);
        if (Input.GetMouseButton(1))
        {
            rb.velocity = new Vector2(xInput * moveSpeed / 2, yInput * moveSpeed / 2);
            anim.SetBool("isAim", true);

            if(Input.GetMouseButtonDown(0))
            {
                var _bullet = Instantiate(bulletPrefeb, pos.position, Quaternion.identity);
            }


        }
        else
        {

            anim.SetBool("isAim", false);
            rb.velocity = new Vector2(xInput * moveSpeed, yInput * moveSpeed);
        }
    }
}
