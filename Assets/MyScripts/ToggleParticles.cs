using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleParticles : MonoBehaviour
{
    public KeyCode toggleKey = KeyCode.B;

    private ParticleSystem radianceParticle;
    private bool isPlaying = true;

    // Start is called before the first frame update
    void Start()
    {
        radianceParticle = GetComponent<ParticleSystem>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(toggleKey))
        {
            if (isPlaying)
            {
                radianceParticle.Stop();
                isPlaying = false;
            }
            else
            {
                radianceParticle.Play();
                isPlaying = true;
            }
        }
    }
}
