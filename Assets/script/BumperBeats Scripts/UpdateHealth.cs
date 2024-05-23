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
    // Update is called once per frame
    void Update()
    {
        healthText.SetText("helf: " + playerTurning.health);
    }
}
