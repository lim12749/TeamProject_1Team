using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;  // 이동 속도
    private Rigidbody rb;  // Rigidbody 컴포넌트

    private void Start()
    {
        // Rigidbody 컴포넌트 가져오기
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        // 키 입력을 받아서 이동 방향 결정
        float horizontal = Input.GetAxis("Horizontal");  // A/D (좌/우)
        float vertical = Input.GetAxis("Vertical");  // W/S (상/하)

        // 이동 벡터 계산
        Vector3 moveDirection = new Vector3(horizontal, 0f, vertical).normalized;

        // Rigidbody의 이동
        rb.MovePosition(transform.position + moveDirection * moveSpeed * Time.deltaTime);
    }
}
