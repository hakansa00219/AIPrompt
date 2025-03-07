using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Test : MonoBehaviour 
{
    // Start is called before the first frame update
    void Start()
    {
        //Default args
        var prompt = "make a picture of green tree with flowers around it and a red sky";
        // Number of steps
        var num_inference_steps = 10;

        // Scale for classifier-free guidance
        var guidance_scale = 7.5;
        //num of images requested
        var batch_size = 1;

       
    }
}
