using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;  // �̵� �ӵ�
    private Rigidbody rb;  // Rigidbody ������Ʈ

    private void Start()
    {
        // Rigidbody ������Ʈ ��������
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        // Ű �Է��� �޾Ƽ� �̵� ���� ����
        float horizontal = Input.GetAxis("Horizontal");  // A/D (��/��)
        float vertical = Input.GetAxis("Vertical");  // W/S (��/��)

        // �̵� ���� ���
        Vector3 moveDirection = new Vector3(horizontal, 0f, vertical).normalized;

        // Rigidbody�� �̵�
        rb.MovePosition(transform.position + moveDirection * moveSpeed * Time.deltaTime);
    }
}
