using TMPro;
using UnityEngine;

public class Hits : MonoBehaviour
{
    public int hits;
    private GameObject HitText;
    private TextMeshProUGUI hitText;

    public void HitTextUpdate()
    {
        hits++;
        if (HitText == null)
            HitText = GameObject.FindGameObjectWithTag("Hits");
        if (hitText == null)
            hitText = HitText.GetComponent<TextMeshProUGUI>();
        hitText.text = ("Hits: " + hits);
    }
    public void Save()
    {
        Savehits save = GameObject.FindAnyObjectByType<Savehits>();
        save.hitsAmount = hits;
    }
}
