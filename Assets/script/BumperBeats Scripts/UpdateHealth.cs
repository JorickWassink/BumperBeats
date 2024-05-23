using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UpdateHealth : MonoBehaviour
{
    PlayerTurning playerTurning;
    [SerializeField] TMP_Text healthText;
    private void Start()
    {
        playerTurning = FindAnyObjectByType<PlayerTurning>();
    }

    void Update()
    {
        healthText.SetText("HEALTH: " + playerTurning.health);
    }
}
