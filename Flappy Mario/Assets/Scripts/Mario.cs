using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mario : MonoBehaviour
{
    public AudioSource sonidoMuerte;
    public Rigidbody2D rb;
    public float jumpSpeed;

    // Start is called before the first frame update
    void Start()
    {
      sonidoMuerte = GetComponent<AudioSource> ();
    }

    // Update is called once per frame
    void Update()
    {

        if(Input.GetKeyDown(KeyCode.Space)){
            rb.velocity = new Vector2(0, jumpSpeed);
        }

        if (rb.velocity.y > 0){
            transform.eulerAngles = new Vector3(0, 0, 30);
        }
        if (rb.velocity.y < 0){
            transform.eulerAngles = new Vector3(0, 0, -30);
        }
        if (rb.velocity.y == 0){
            transform.eulerAngles = new Vector3(0, 0, 0);
        }
    }

    void OnTriggerEnter2D(Collider2D other){
      if (other.CompareTag("Tuberia")){
        sonidoMuerte.Play();
        transform.position = new Vector3(0,0,0);
        rb.velocity = new Vector2(0,0);

        var tuberias = FindObjectsOfType<Tuberia>();
        foreach (var tuberia in tuberias)
        {
          Destroy(tuberia.gameObject);
        }
      }
    }
}
