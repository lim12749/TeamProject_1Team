using UnityEngine;
using UnityEngine.UI;

public class CoinPickUpZone : MonoBehaviour
{
    public Text coinText;  // UI �ؽ�Ʈ
    public int coinValue = 10;  // ���� ��
    private bool playerInRange = false;  // �÷��̾ ���� �ȿ� �ִ��� ����
    private GameObject coinObject;  // ���� ������Ʈ

    private void Start()
    {
        // ���� ������Ʈ�� ã�Ƽ� ���� (�� �ڵ带 �ʿ信 �°� ������ �� ����)
        coinObject = GameObject.Find("Coin"); // ���� ������Ʈ �̸�
    }

    private void Update()
    {
        if (playerInRange && Input.GetKeyDown(KeyCode.E))
        {
            // ���� ������Ʈ ����
            Destroy(coinObject);

            // ���� �� UI ������Ʈ
            int currentCoins = int.Parse(coinText.text);  // ���� ���� ��
            currentCoins += coinValue;  // ���� �� 10 �߰�
            coinText.text = currentCoins.ToString();  // UI�� ���� �� �ݿ�
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))  // �÷��̾ ������ ������ ��
        {
            playerInRange = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))  // �÷��̾ ������ ����� ��
        {
            playerInRange = false;
        }
    }
}
