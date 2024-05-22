using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;

public class PlincoGun : MonoBehaviour
{
    [SerializeField] GameObject bullet;// een refernece naar de bullet gameobject
    [SerializeField] Rigidbody2D rb;// een reference naar een rigidbody2D
    [SerializeField] TMP_Text balltext;// een reference naar een TMP_text voor de aantal ballen
    public Transform startPos;// public transform voor de begin positie waar de gun naar toe gaat
    public Transform endPos;// public transform voor de eind positie waar de gun naar toe gaat
    private Vector3 targetPos;// een vector3 dat de target positie pakt en waar de gun dus ook naar toe gaat
    int bulletcount;// een int voor de aantal bullets dat je nog over hebt
    bool activebullet;// bool dat checkt of er nog bullets op het scherm zijn

    public void Start()
    {
        activebullet = GameObject.Find("BulletClone") != null;// zet activebullet op tekijken naar gameobject met de naam BulletClone en kijkt of het niet null is
        bulletcount = 10;//zet bulletcount naar 10
        targetPos = startPos.position;// zet de targetpos naar de position van startpos
    }
    public void plusbullets()
    {
        bulletcount += 5;// voegt 5 value to aan bulletcount
    }


    private void FixedUpdate()
    {
        Vector3 currentPos = transform.position;// vector3 voor de currentPos dat de transform position pakt van waar de script opstaat

        float distanceToStart = Vector3.Distance(currentPos, startPos.position);
        float distanceToEnd = Vector3.Distance(currentPos, endPos.position);


        // Calculate the direction to the target position
        Vector3 targetDirection = (targetPos - currentPos).normalized;

       
        rb.MovePosition(currentPos + targetDirection * Time.deltaTime * 5f);//verplaats de gun naar de positie
    }

    private void Update()
    {
        activebullet = GameObject.Find("BulletClone") != null;
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (bulletcount > 0)
            {
                bulletcount--;
                GameObject clone = Instantiate(bullet, transform.position - new Vector3(0, 1, 0), Quaternion.identity);
                clone.transform.parent = this.transform;
                clone.name = "BulletClone";
            }
        }
        if (activebullet == false && bulletcount == 0)
        {
            SceneManager.LoadScene("GameOver");
        }
        if (bulletcount != 0 && balltext != null)// checkt of bulletcount niet 0 is en of balltext niet leeg is
        {
            balltext.text = bulletcount.ToString();// zet bulletcount naar een string en zet dat op de text van balltext
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "StartPos")
        {
            targetPos = endPos.position;
        }
        if (collision.gameObject.name == "EndPos")
        {
            targetPos = startPos.position;
        }
    }
}
