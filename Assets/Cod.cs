using UnityEngine;

public class Cod : MonoBehaviour
{
    public Transform lup1;
    public Transform lup2;
    public Animator animatielup1;
    public Animator animatielup2;

    void Start()
    {
    }

    void Update()
    {
        float diferentaX = lup1.position.x - lup2.position.x;
        float diferentaY = lup1.position.y - lup2.position.y;
        float diferentaZ = lup1.position.z - lup2.position.z;

        float distanta = Mathf.Sqrt(diferentaX * diferentaX + diferentaY * diferentaY + diferentaZ * diferentaZ);

        if (distanta < 0.5)
        {
            animatielup1.SetBool("isAttacking", true);
            animatielup2.SetBool("isAttacking", true);

            animatielup1.SetBool("isBarking", false);
            animatielup2.SetBool("isBarking", false);
        }
        else if (distanta < 1.0)
        {
            animatielup1.SetBool("isAttacking", false);
            animatielup2.SetBool("isAttacking", false);

            animatielup1.SetBool("isBarking", true);
            animatielup2.SetBool("isBarking", true);
        }
        else
        {
            animatielup1.SetBool("isAttacking", false);
            animatielup2.SetBool("isAttacking", false);

            animatielup1.SetBool("isBarking", false);
            animatielup2.SetBool("isBarking", false);
        }
    }
}