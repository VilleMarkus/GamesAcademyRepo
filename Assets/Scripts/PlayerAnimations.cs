using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class PlayerAnimations : MonoBehaviour
{
    // Start is called before the first frame update
    public Animator myAnimator;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxis("Horizontal") != 0)
        {
            myAnimator.SetBool("running", true);

        }
        else
        {
            myAnimator.SetBool("running", false);
        }
        if (Input.GetKeyDown(KeyCode.Space) is true)
        {
            myAnimator.SetBool("jumping", true);
        }
        else
        {
            myAnimator.SetBool("jumping", false);
        }
    }
}
