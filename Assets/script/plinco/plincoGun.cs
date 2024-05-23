using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;

public class PlincoGun : MonoBehaviour
{
    [SerializeField] GameObject bullet;// een refernece naar de bullet gameobject
    [SerializeField] Rigidbody2D rb;// een reference naar een rigidbody2D
    [SerializeField] TMP_Text balltext;// een reference naar een TMP_text voor de aantal ballen
    public pointsystem PS;// een reference naar pointsystem script
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

        float distanceToStart = Vector3.Distance(currentPos, startPos.position);//float dat kijkt naar de afstand van de currentpos tot de startpos
        float distanceToEnd = Vector3.Distance(currentPos, endPos.position);//float dat kijkt naar de afstand vand currentpos tot de eindpos

        Vector3 targetDirection = (targetPos - currentPos).normalized;//berekent de afstand to de targetpos

       
        rb.MovePosition(currentPos + targetDirection * Time.deltaTime * 5f);//verplaats de gun naar de positie
    }

    private void Update()
    {
        activebullet = GameObject.Find("BulletClone") != null;//zoekt naar een gameobject met de naar BulletClone en kijkt of het niet null is en slaat het op in activebullet
        if (Input.GetKeyDown(KeyCode.Space))//kijkt of je spacebar indrukt
        {
            if (bulletcount > 0)//kijkt of bullet count hoger dan 0 is
            {
                bulletcount--;//verlaagt bulletcount met 1
                GameObject clone = Instantiate(bullet, transform.position - new Vector3(0, 1, 0), Quaternion.identity);// instantiate een bullet op de positie van deze transform maar met 1 lager y level 
                clone.name = "BulletClone";//maakt de naam BulletClone 
            }
        }
        if (activebullet == false && bulletcount == 0)//kijkt of activebullet false is en bulletcount 0
        {
            PS.savescore();
            SceneManager.LoadScene("GameOver");//laadt de GameOver scene
        }
        if (bulletcount != 0 && balltext != null)// checkt of bulletcount niet 0 is en of balltext niet leeg is
        {
            balltext.text = bulletcount.ToString();// zet bulletcount naar een string en zet dat op de text van balltext
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "StartPos")// kijkt of het een object raakt met de naam StartPos
        {
            targetPos = endPos.position;//zet targetPos naar endPost posistion
        }
        if (collision.gameObject.name == "EndPos")
        {
            targetPos = startPos.position;
        }
    }
}
