// 27/8/2025 AI-Tag
// This was created with the help of Assistant, a Unity Artificial Intelligence product.

using System;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class CharacterZoom : MonoBehaviour
{
    [Header("Zoom Settings")]
    public Camera playerCamera; // The camera to control zoom
    public float zoomSpeed = 2f; // Speed at which zoom occurs
    public float minZoom = 5f; // Minimum zoom distance
    public float maxZoom = 20f; // Maximum zoom distance

    [Header("UI Elements")]
    public Button zoomInButton; // Button for zooming in
    public Button zoomOutButton; // Button for zooming out

    private void Start()
    {
        // Ensure the buttons are assigned
        if (zoomInButton != null)
            zoomInButton.onClick.AddListener(ZoomIn);

        if (zoomOutButton != null)
            zoomOutButton.onClick.AddListener(ZoomOut);
    }

    private void ZoomIn()
    {
        // Decrease the camera's field of view to zoom in
        if (playerCamera != null)
        {
            playerCamera.fieldOfView = Mathf.Clamp(playerCamera.fieldOfView - zoomSpeed, minZoom, maxZoom);
        }
    }

    private void ZoomOut()
    {
        // Increase the camera's field of view to zoom out
        if (playerCamera != null)
        {
            playerCamera.fieldOfView = Mathf.Clamp(playerCamera.fieldOfView + zoomSpeed, minZoom, maxZoom);
        }
    }
}
