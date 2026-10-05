using TMPro;
using UnityEngine;

public class GameoverHitsText : MonoBehaviour
{
    public TextMeshProUGUI text;
    void Start()
    {
        if (text == null)
            text = gameObject.GetComponent<TextMeshProUGUI>();
        Savehits save = GameObject.FindAnyObjectByType<Savehits>();
        text.text = ("Hits: " + save.hitsAmount);
    }
}
