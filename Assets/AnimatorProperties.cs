using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorProperties : MonoBehaviour
{
    public Animator spinnerAnimator;

    public bool isSpinning;

    private void Start()
    {
        isSpinning = false;
    }

    void Update()
    {
        if ( Input.GetKeyDown(KeyCode.Space) && isSpinning == false )
        {
            isSpinning = true;
            spinnerAnimator.SetBool("SpinOn", true);        
        }

        else if (Input.GetKeyDown(KeyCode.Space) && isSpinning == true)
        {
            isSpinning = false;
            spinnerAnimator.SetBool("SpinOn", false);
        }

    }





}
