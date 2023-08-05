using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundTest : MonoBehaviour
{
    public AudioClip runningSoundClip;
    public AudioClip jumpSoundClip;

    private AudioSource audioSource;
    private bool isJumping = false;

    public float jumpForce = 5f;
    public Rigidbody2D rb;
    public float runSpeed = 5f;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        // Get the AudioSource component attached to the GameObject
        audioSource = GetComponent<AudioSource>();

        // Set the running sound to loop
        audioSource.clip = runningSoundClip;
        audioSource.loop = true;
        // Play the running sound
        audioSource.Play();
    }

    private void Update()
    {
        // Check if the space key is pressed
        if (Input.GetKeyDown(KeyCode.Space) && !isJumping)
        {
            Jump();
            // Stop the running sound
            audioSource.Stop();

            // Play the jump sound
            audioSource.PlayOneShot(jumpSoundClip);

            // Set isJumping to true to prevent multiple jumps at once
            isJumping = true;

            // Add jump logic here (e.g., applying a force to the player for jumping)
            // For simplicity, I'll just wait for a short time and then resume the running sound.
            Invoke("ResumeRunningSound", 0.5f); // Wait for 0.5 seconds and then resume the running sound
        }
    }

    private void FixedUpdate()
    {
        // Apply a constant horizontal force to make the player run to the right
        rb.velocity = new Vector2(runSpeed, rb.velocity.y);
    }

    private void ResumeRunningSound()
    {
        // Resume the running sound
        audioSource.Play();

        // Set isJumping to false, allowing the player to jump again
        isJumping = false;
    }

    private void Jump()
    {
        // Add vertical force to make the player jump
        rb.AddForce(new Vector2(0f, jumpForce), ForceMode2D.Impulse);
    }

}