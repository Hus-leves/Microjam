using UnityEngine;

public class Savehits : MonoBehaviour
{
    public int hitsAmount;
    void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }
}
