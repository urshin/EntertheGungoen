using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Croshair_June : MonoBehaviour
{
    public Rigidbody2D rb; //�÷��̾� ������ �ٵ�
    private Camera _camera; //���� ī�޶� �ޱ�
    // Start is called before the first frame update
    void Start()
    {
        _camera = Camera.main; //ī�޶� �޾ƿ���.

    }

    // Update is called once per frame
    void Update()
    {
        Vector2 mousePos = _camera.ScreenToWorldPoint(Input.mousePosition);
        // ���콺 ��ġ == ũ�ν���� ��ġ
        Vector2 dirVec = mousePos;



        gameObject.transform.position = dirVec;
        
    }
}
