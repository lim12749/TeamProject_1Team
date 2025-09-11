using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class CoinPickUpZone : MonoBehaviour
{
    public TextMeshProUGUI coinText;  // UI 텍스트를 연결할 변수
    public int coinValue = 10;  // 코인 값
    private bool playerInRange = false;  // 플레이어가 범위 안에 있는지 여부

    private void Start()
    {
        // 기본값 설정: "Coin : 0"
        coinText.text = "Coin : 0";  // 시작 시 UI 텍스트를 "Coin : 0"으로 설정
    }

    private void Update()
    {
        if (playerInRange && Input.GetKeyDown(KeyCode.E))
        {
            // 빈 오브젝트와 자식인 코인 오브젝트를 모두 제거
            Destroy(gameObject);  // 빈 오브젝트 자체를 삭제

            // 코인 값 UI 업데이트
            int currentCoins = int.Parse(coinText.text.Split(':')[1].Trim());  // 기존 코인 값 추출
            currentCoins += coinValue;  // 코인 값 10 추가
            coinText.text = "Coin : " + currentCoins.ToString();  // UI에 코인 값 반영
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        // 플레이어가 범위에 들어갔을 때
        if (other.CompareTag("Player"))
        {
            playerInRange = true;
            Debug.Log("플레이어가 범위에 들어왔습니다.");
        }
    }

    private void OnTriggerExit(Collider other)
    {
        // 플레이어가 범위를 벗어났을 때
        if (other.CompareTag("Player"))
        {
            playerInRange = false;
            Debug.Log("플레이어가 범위를 벗어났습니다.");
        }
    }
}
