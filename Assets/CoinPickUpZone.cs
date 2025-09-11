using UnityEngine;
using UnityEngine.UI;

public class CoinPickUpZone : MonoBehaviour
{
    public Text coinText;  // UI 텍스트
    public int coinValue = 10;  // 코인 값
    private bool playerInRange = false;  // 플레이어가 범위 안에 있는지 여부
    private GameObject coinObject;  // 코인 오브젝트

    private void Start()
    {
        // 코인 오브젝트를 찾아서 저장 (이 코드를 필요에 맞게 수정할 수 있음)
        coinObject = GameObject.Find("Coin"); // 코인 오브젝트 이름
    }

    private void Update()
    {
        if (playerInRange && Input.GetKeyDown(KeyCode.E))
        {
            // 코인 오브젝트 제거
            Destroy(coinObject);

            // 코인 값 UI 업데이트
            int currentCoins = int.Parse(coinText.text);  // 기존 코인 값
            currentCoins += coinValue;  // 코인 값 10 추가
            coinText.text = currentCoins.ToString();  // UI에 코인 값 반영
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))  // 플레이어가 범위에 들어왔을 때
        {
            playerInRange = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))  // 플레이어가 범위를 벗어났을 때
        {
            playerInRange = false;
        }
    }
}
