using UnityEngine;

public class FPSDisplay : MonoBehaviour
{
    [SerializeField] private float updateInterval = 0.5f;
    [SerializeField] private int fontSize = 48;
    [SerializeField] private Color textColor = Color.white;
    [SerializeField] private Vector2 padding = new Vector2(10, 10);

    private float accumulatedTime;
    private int frameCount;
    private float currentFps;
    private GUIStyle style;

    private void Awake()
    {
        QualitySettings.vSyncCount = 0;
        Application.targetFrameRate = -1; // uncapped, or use a number like 240
    }
    private void Update()
    {
        accumulatedTime += Time.unscaledDeltaTime;
        frameCount++;

        if (accumulatedTime >= updateInterval)
        {
            currentFps = frameCount / accumulatedTime;
            accumulatedTime = 0f;
            frameCount = 0;
        }
    }

    private void OnGUI()
    {
        if (style == null)
            style = new GUIStyle(GUI.skin.label) { fontStyle = FontStyle.Bold };

        style.fontSize = fontSize;
        style.normal.textColor = textColor;
        style.wordWrap = false;

        float ms = currentFps > 0 ? 1000f / currentFps : 0f;

        var content = new GUIContent(
            $"{currentFps:0} FPS ({ms:0.0} ms)\n" +
            $"{QualitySettings.names[QualitySettings.GetQualityLevel()]} | VSync {QualitySettings.vSyncCount} | Target {Application.targetFrameRate}");

        Vector2 size = style.CalcSize(content);
        GUI.Label(new Rect(padding.x, padding.y, size.x, size.y), content, style);
    }
}