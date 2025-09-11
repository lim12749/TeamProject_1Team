using UnityEngine;

// ���Ͱ� ������ ��������Ʈ ��θ� ���� �ݺ������� �̵��ϰ�,
// �÷��̾�� �浹 �� �÷��̾ ��� ó���ϴ� ��ũ��Ʈ
public class MonsterAI : MonoBehaviour
{
    public Transform[] waypoints; // ���Ͱ� �̵��� ��������Ʈ
    public float speed = 2f;      // ���� �̵� �ӵ�

    private int currentWaypointIndex = 0; // ���� �̵� ���� ��������Ʈ

    void Update()
    {
        // ��������Ʈ�� ������ �̵����� ����
        if (waypoints == null || waypoints.Length == 0)
            return;

        // ���� ��������Ʈ �������� �̵�
        Transform targetWaypoint = waypoints[currentWaypointIndex];
        Vector3 direction = (targetWaypoint.position - transform.position).normalized;
        transform.position += direction * speed * Time.deltaTime;

        // ��������Ʈ�� ���� �����ϸ� ���� ��������Ʈ�� �ε��� ���� (��ȯ)
        if (Vector3.Distance(transform.position, targetWaypoint.position) < 0.1f)
        {
            currentWaypointIndex = (currentWaypointIndex + 1) % waypoints.Length;
        }
    }

    // Ʈ���� �ݶ��̴��� �ٸ� ������Ʈ�� ����� �� ȣ���
    private void OnTriggerEnter(Collider other)
    {
        // ���� ������Ʈ�� "Player" �±׸� ������ ������
        if (other.CompareTag("Player"))
        {
            // �÷��̾� ������Ʈ�� ��Ȱ��ȭ�Ͽ� ��� ó��
            other.gameObject.SetActive(false);
            // ����� �α׷� ��� �޽��� ���
            Debug.Log("�÷��̾� ���");
        }
    }
}
