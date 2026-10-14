using UnityEngine;
using TMPro;

public class ScoreCalc : MonoBehaviour
{
    public int scor = 0;
    public TextMeshProUGUI textScor;
    public Transform jucator;

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "minge")
        {
            float dist = Vector3.Distance(jucator.position, transform.position);
            if (dist > 4f)
            { scor = scor + 30;}
            else
            {scor = scor + 10;}
            textScor.text = "Scor: " + scor;
        }
    }
}