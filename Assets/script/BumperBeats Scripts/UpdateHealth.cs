using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UpdateHealth : MonoBehaviour
{
    PlayerTurning playerturning;
    [SerializeField] TMP_Text healthText;
    private void Start()
    {
        playerturning = FindAnyObjectByType<PlayerTurning>();
    }
    // Update is called once per frame
    void Update()
    {
        healthText.SetText("helf: " + playerturning.health);
    }
}
