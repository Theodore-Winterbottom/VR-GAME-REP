using System.Collections;
using System.Collections.Generic;
using Unity.XR.CoreUtils;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

/*public class ChracterMovementHelper : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField] XROrigin xROrigin;
    [SerializeField] CharacterController characterController;
    [SerializeField] CharacterControllerDriver driver;
    void Start()
    {
        xROrigin = GetComponent<XROrigin>();
        characterController = GetComponent<CharacterController>();
        driver = GetComponent<CharacterControllerDriver>();
    }

    // Update is called once per frame
    void Update()
    {
        UpdateCharacterController();
    }

    /// <summary>
    /// Updates the <see cref="CharacterController.height"/> and <see cref="CharacterController.center"/>
    /// based on the camera's position.
    /// </summary>
    protected virtual void UpdateCharacterController()
    {
        if (m_XROrigin == null || m_CharacterController == null)
            return;

        var height = Mathf.Clamp(m_XROrigin.CameraInOriginSpaceHeight, driver.MinHeight, driver.MaxHeight);

        Vector3 center = m_XROrigin.CameraInOriginSpacePos;
        center.y = height / 2f + m_CharacterController.skinWidth;

        m_CharacterController.height = height;
        m_CharacterController.center = center;
    }
}*/
