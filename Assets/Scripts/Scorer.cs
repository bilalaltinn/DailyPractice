using UnityEngine;

public class Scorer : MonoBehaviour
{
    int hits = 0;

    private void OnCollisionEnter(Collision collision)
    {
        hits++;
        Debug.Log("You are bumped into a thing many times:" + hits);
    }
}
