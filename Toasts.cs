using System.Collections.Generic;
using UnityEngine;

public static class Toasts
{
    private class ToastMessage
    {
        public string Text;
        public float CreatedAt;
        public float Duration;
        public float FadeDuration;

        public ToastMessage(string text, float duration, float fadeDuration)
        {
            Text = text;
            CreatedAt = Time.unscaledTime;
            Duration = duration;
            FadeDuration = fadeDuration;
        }
    }

    private static readonly List<ToastMessage> _toasts = new List<ToastMessage>();

    // Newest toast appears at top.
    public static void AddNew(string text, float duration = 5.0f, float fadeDuration = 1.0f)
    {
        _toasts.Insert(0, new ToastMessage(text, duration, fadeDuration));
    }

    public static void Render(float startX = 20f, float startY = 20f, float width = 1000f, float lineHeight = 24f, float gap = 1f)
    {
        // Remove expired toasts first.
        float now = Time.unscaledTime;
        _toasts.RemoveAll(t => now > t.CreatedAt + t.Duration + t.FadeDuration);

        if (_toasts.Count == 0) return;

        Color oldColor = GUI.color;

        for (int i = 0; i < _toasts.Count; i++)
        {
            var t = _toasts[i];
            float age = now - t.CreatedAt;

            // Per-toast alpha: full during duration, then fade.
            float alpha = 1f;
            if (age > t.Duration)
            {
                float fadeT = (age - t.Duration) / Mathf.Max(0.001f, t.FadeDuration);
                alpha = 1f - Mathf.Clamp01(fadeT);
            }

            GUI.color = new Color(1f, 1f, 1f, alpha);

            float y = startY + i * (lineHeight + gap);
            Rect rect = new Rect(startX, y, width, lineHeight);

            // Draw dark background
            GUI.color = new Color(0f, 0f, 0f, 0.6f * alpha);
            GUI.DrawTexture(rect, Texture2D.whiteTexture);

            // Draw left-aligned text on top
            GUI.color = new Color(1f, 1f, 1f, alpha);
            GUIStyle labelStyle = new GUIStyle(GUI.skin.label) {richText = true};
            GUI.Label(rect, t.Text, labelStyle);
        }

        GUI.color = oldColor;
    }
}