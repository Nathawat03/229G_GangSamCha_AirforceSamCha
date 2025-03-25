using System;
using UnityEngine;
using TMPro;
public class PointUI : MonoBehaviour
{
    private TextMeshProUGUI pointText;

    private void Start()
    {
        pointText = GetComponent<TextMeshProUGUI>();
    }

    public void Update (PlaneController planeController)
    {
        pointText.text = planeController.NumberOfPoints.ToString();
    }
}
