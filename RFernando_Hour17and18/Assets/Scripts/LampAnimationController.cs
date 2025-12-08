using UnityEngine;

public class LampAnimationController : MonoBehaviour
{
    Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            anim.SetTrigger("ColorTrigger");

        if (Input.GetKeyDown(KeyCode.Q))
            anim.SetTrigger("ScaleTrigger");

        if (Input.GetKeyDown(KeyCode.E))
            anim.SetTrigger("SpinTrigger");

        if (Input.GetKeyDown(KeyCode.R))
            anim.SetTrigger("HoverTrigger");
    }
}
