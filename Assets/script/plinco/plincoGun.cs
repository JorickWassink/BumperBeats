using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;

public class PlincoGun : MonoBehaviour
{
    [SerializeField] GameObject bullet;
    [SerializeField] Rigidbody2D rb;
    [SerializeField] TMP_Text balltext;
    public Transform startPos;
    public Transform endPos;
    private Vector3 targetPos;
    int bulletcount;
    bool activebullet;

    public void Start()
    {
        activebullet = GameObject.Find("BulletClone") != null;
        bulletcount = 0;
        targetPos = startPos.position;
    }
    public void plusbullet()
    {
        bulletcount -= 5;
    }


    private void FixedUpdate()
    {
        Vector3 currentPos = transform.position;

        float distanceToStart = Vector3.Distance(currentPos, startPos.position);
        float distanceToEnd = Vector3.Distance(currentPos, endPos.position);


        // Calculate the direction to the target position
        Vector3 targetDirection = (targetPos - currentPos).normalized;

        // Move gun towards the target position
        rb.MovePosition(currentPos + targetDirection * Time.deltaTime * 5f);
    }

    private void Update()
    {
        activebullet = GameObject.Find("BulletClone") != null;
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (bulletcount < 10)
            {
                bulletcount++;
                GameObject clone = Instantiate(bullet, transform.position - new Vector3(0, 1, 0), Quaternion.identity);
                clone.transform.parent = this.transform;
                clone.name = "BulletClone";
            }
        }
        if (activebullet == false && bulletcount == 10)
        {
            SceneManager.LoadScene("Leon");
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
