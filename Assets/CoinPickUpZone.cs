using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class CoinPickUpZone : MonoBehaviour
{
    public TextMeshProUGUI coinText;  // UI �ؽ�Ʈ�� ������ ����
    public int coinValue = 10;  // ���� ��
    private bool playerInRange = false;  // �÷��̾ ���� �ȿ� �ִ��� ����

    private void Start()
    {
        // �⺻�� ����: "Coin : 0"
        coinText.text = "Coin : 0";  // ���� �� UI �ؽ�Ʈ�� "Coin : 0"���� ����
    }

    private void Update()
    {
        if (playerInRange && Input.GetKeyDown(KeyCode.E))
        {
            // �� ������Ʈ�� �ڽ��� ���� ������Ʈ�� ��� ����
            Destroy(gameObject);  // �� ������Ʈ ��ü�� ����

            // ���� �� UI ������Ʈ
            int currentCoins = int.Parse(coinText.text.Split(':')[1].Trim());  // ���� ���� �� ����
            currentCoins += coinValue;  // ���� �� 10 �߰�
            coinText.text = "Coin : " + currentCoins.ToString();  // UI�� ���� �� �ݿ�
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        // �÷��̾ ������ ���� ��
        if (other.CompareTag("Player"))
        {
            playerInRange = true;
            Debug.Log("�÷��̾ ������ ���Խ��ϴ�.");
        }
    }

    private void OnTriggerExit(Collider other)
    {
        // �÷��̾ ������ ����� ��
        if (other.CompareTag("Player"))
        {
            playerInRange = false;
            Debug.Log("�÷��̾ ������ ������ϴ�.");
        }
    }
}
