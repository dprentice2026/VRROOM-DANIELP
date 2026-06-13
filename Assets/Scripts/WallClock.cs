using UnityEngine;
using TMPro;
using System;

public class WallClock : MonoBehaviour
{
    [Header("Digital Clock (Optional)")]
    public TextMeshProUGUI digitalClockText;

    [Header("Analog Clock (Optional)")]
    public Transform hourHand;
    public Transform minuteHand;
    public Transform secondHand;

    void Update()
    {
        DateTime now = DateTime.Now;

        // DIGITAL
        if (digitalClockText != null)
            digitalClockText.text = now.ToString("hh:mm:ss tt");

        // ANALOG
        if (hourHand != null)
            hourHand.localRotation = Quaternion.Euler(0, 0, -((now.Hour % 12) * 30f + now.Minute * 0.5f));

        if (minuteHand != null)
            minuteHand.localRotation = Quaternion.Euler(0, 0, -(now.Minute * 6f));

        if (secondHand != null)
            secondHand.localRotation = Quaternion.Euler(0, 0, -(now.Second * 6f));
    }
}
