using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Netcode;

public class PlayerMovement : NetworkBehaviour
{
    public float speed = 5f;
    public float rotationSpeed = 5f;
    private Rigidbody rb;
    public AudioClip movementSound;
    // public ParticleSystem movementParticles;
    private AudioSource audioSource;
    private Animator animator;

    public override void OnNetworkSpawn() {
        // Debug.Log(IsOwner);
        // if (!IsOwner) Destroy(this);
    }

    void Start()
    {
        rb = GetComponent<Rigidbody>();   
        audioSource = GetComponent<AudioSource>(); 
        animator = GetComponent<Animator>(); 
        audioSource.clip = movementSound;  
    }

    void Update()
    {
        
    }

    void FixedUpdate() {
        // moveToCamera();
        if (IsOwner)
            normalMovement();
        // cameraFollowPlayer();
    }

    void normalMovement() {
        
		Vector2 playerInput;
        playerInput.x = Input.GetAxis("Horizontal");
		playerInput.y = Input.GetAxis("Vertical");
		playerInput.Normalize();

        Vector3 direction = new Vector3(playerInput.x, 0f, playerInput.y);
        
        // rb.AddForce(direction * speed);

        if (playerInput.x != 0 || playerInput.y != 0)
            animator.Play("mixamo_com");
        else
            animator.Play("Breathing Idle");
		transform.localPosition += direction * speed;
    }

    float AngleBetweenTwoPoints(Vector3 a, Vector3 b) {
		return Mathf.Atan2(a.y - b.y, a.x - b.x) * Mathf.Rad2Deg;
	}
}
