// 27/8/2025 AI-Tag
// This was created with the help of Assistant, a Unity Artificial Intelligence product.

using System;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class CharacterControlWithZoom : MonoBehaviour
{
    [Header("Zoom Settings")]
    public Camera playerCamera; // The camera to control zoom
    public float zoomSpeed = 2f; // Speed at which zoom occurs
    public float minZoom = 5f; // Minimum zoom distance
    public float maxZoom = 40f; // Maximum zoom distance

    [Header("Character Rotation Settings")]
    public Transform character; // The character to rotate
    public float rotationSpeed = 50f; // Speed of rotation

    [Header("Camera Movement Settings")]
    public Transform cameraTransform; // The camera to move
    public float verticalMoveSpeed = 2f; // Speed of vertical movement
    public float minCameraHeight = 1f; // Minimum height of the camera
    public float maxCameraHeight = 10f; // Maximum height of the camera

    [Header("UI Buttons")]
    public Button zoomInButton; // Button for zooming in
    public Button zoomOutButton; // Button for zooming out
    public Button rotateLeftButton; // Button to rotate character left
    public Button rotateRightButton; // Button to rotate character right
    public Button moveCameraUpButton; // Button to move camera up
    public Button moveCameraDownButton; // Button to move camera down

    private void Start()
    {
        // Assign button listeners for zoom
        if (zoomInButton != null)
            zoomInButton.onClick.AddListener(ZoomIn);

        if (zoomOutButton != null)
            zoomOutButton.onClick.AddListener(ZoomOut);

        // Assign button listeners for rotation
        if (rotateLeftButton != null)
            rotateLeftButton.onClick.AddListener(RotateLeft);

        if (rotateRightButton != null)
            rotateRightButton.onClick.AddListener(RotateRight);

        // Assign button listeners for camera movement
        if (moveCameraUpButton != null)
            moveCameraUpButton.onClick.AddListener(MoveCameraUp);

        if (moveCameraDownButton != null)
            moveCameraDownButton.onClick.AddListener(MoveCameraDown);
    }

    private void ZoomIn()
    {
        if (playerCamera != null)
        {
            playerCamera.fieldOfView = Mathf.Clamp(playerCamera.fieldOfView - zoomSpeed, minZoom, maxZoom);
        }
    }

    private void ZoomOut()
    {
        if (playerCamera != null)
        {
            playerCamera.fieldOfView = Mathf.Clamp(playerCamera.fieldOfView + zoomSpeed, minZoom, maxZoom);
        }
    }

    private void RotateLeft()
    {
        if (character != null)
        {
            character.Rotate(Vector3.up, -rotationSpeed * Time.deltaTime);
        }
    }

    private void RotateRight()
    {
        if (character != null)
        {
            character.Rotate(Vector3.up, rotationSpeed * Time.deltaTime);
        }
    }

    private void MoveCameraUp()
    {
        if (cameraTransform != null)
        {
            float newY = Mathf.Clamp(cameraTransform.position.y + verticalMoveSpeed * Time.deltaTime, minCameraHeight, maxCameraHeight);
            cameraTransform.position = new Vector3(cameraTransform.position.x, newY, cameraTransform.position.z);
        }
    }

    private void MoveCameraDown()
    {
        if (cameraTransform != null)
        {
            float newY = Mathf.Clamp(cameraTransform.position.y - verticalMoveSpeed * Time.deltaTime, minCameraHeight, maxCameraHeight);
            cameraTransform.position = new Vector3(cameraTransform.position.x, newY, cameraTransform.position.z);
        }
    }
}
