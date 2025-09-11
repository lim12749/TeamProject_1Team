using UnityEngine;

// 몬스터가 지정된 웨이포인트 경로를 따라 반복적으로 이동하고,
// 플레이어와 충돌 시 플레이어를 사망 처리하는 스크립트
public class MonsterAI : MonoBehaviour
{
    public Transform[] waypoints; // 몬스터가 이동할 웨이포인트
    public float speed = 2f;      // 몬스터 이동 속도

    private int currentWaypointIndex = 0; // 현재 이동 중인 웨이포인트

    void Update()
    {
        // 웨이포인트가 없으면 이동하지 않음
        if (waypoints == null || waypoints.Length == 0)
            return;

        // 현재 웨이포인트 방향으로 이동
        Transform targetWaypoint = waypoints[currentWaypointIndex];
        Vector3 direction = (targetWaypoint.position - transform.position).normalized;
        transform.position += direction * speed * Time.deltaTime;

        // 웨이포인트에 거의 도달하면 다음 웨이포인트로 인덱스 변경 (순환)
        if (Vector3.Distance(transform.position, targetWaypoint.position) < 0.1f)
        {
            currentWaypointIndex = (currentWaypointIndex + 1) % waypoints.Length;
        }
    }

    // 트리거 콜라이더에 다른 오브젝트가 닿았을 때 호출됨
    private void OnTriggerEnter(Collider other)
    {
        // 닿은 오브젝트가 "Player" 태그를 가지고 있으면
        if (other.CompareTag("Player"))
        {
            // 플레이어 오브젝트를 비활성화하여 사망 처리
            other.gameObject.SetActive(false);
            // 디버그 로그로 사망 메시지 출력
            Debug.Log("플레이어 사망");
        }
    }
}
