using UnityEngine;

public class AnimationControl : MonoBehaviour
{
    Animator anim;

    void Start()
    {
        // Get a reference to the animator
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        anim.SetFloat("Speed", Mathf.Abs(Input.GetAxis("Vertical")));
        anim.SetFloat("Direction", Input.GetAxis("Horizontal"));
    }
}
