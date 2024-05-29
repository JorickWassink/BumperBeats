using TMPro;
using UnityEngine;

public class UpdateHealth : MonoBehaviour
{
    PlayerTurning playerTurning; //called de PlayerTurning script
    [SerializeField] TMP_Text healthText; //called en haalt de text component op een ander GameObject, via SerializeField om het via de Unity interface erin te zetten

    private void Start() //start method
    {
        playerTurning = FindAnyObjectByType<PlayerTurning>(); //pakt de onderdelen van het script
    }

    void Update() //update method, update elke frame
    {
        healthText.SetText("HEALTH: " + playerTurning.health); //zet elke frame de health op dat moment
    }
}
