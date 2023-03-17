using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class CameraMOvement : MonoBehaviour
{
    [SerializeField] Joystick Joystick;
    [SerializeField] CinemachineFreeLook FreeLook;
    [Range(0f, 0.3f)]
    public float cameraRotateFactor = 0.2f;    

    // Update is called once per frame
    void Update()
    {
        FreeLook.m_XAxis.m_InputAxisValue = Joystick.Horizontal * cameraRotateFactor;
        FreeLook.m_YAxis.m_InputAxisValue = Joystick.Vertical * cameraRotateFactor;
            
    }
}
