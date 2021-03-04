using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody rb;
    public float speed;
    public float gravityFactor;
    bool isOnGround = true;
    public bool isGameOver = false;
    private Animator anim;
    public ParticleSystem endEffect;
    public ParticleSystem runningEffect;
    public AudioClip jumpAudio;
    public AudioClip deathAudio;
    private AudioSource audioPlayer;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        Physics.gravity *= gravityFactor;
        anim = GetComponent<Animator>();
        audioPlayer = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isOnGround && !isGameOver)
        {
            anim.SetTrigger("Jump_trig");
            audioPlayer.PlayOneShot(jumpAudio, 1.0f);
            rb.AddForce(Vector3.up * speed ,ForceMode.Impulse);
            isOnGround = false;
            runningEffect.Stop();
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("obstacle"))
        {
            audioPlayer.PlayOneShot(deathAudio, 1.0f);
            anim.SetBool("Death_b", true);
            anim.SetInteger("DeathType_int", 1);
            isGameOver = true;
            endEffect.Play();
        }else if (collision.gameObject.CompareTag("ground"))
        {
            isOnGround = true;
            runningEffect.Play();
        }
    }
}
