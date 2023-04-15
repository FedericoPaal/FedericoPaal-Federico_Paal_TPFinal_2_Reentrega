using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] private CinemachineVirtualCamera camera1;
    [SerializeField] private CinemachineVirtualCamera camera2;

    private void Update()
    {
        if (Input.GetKeyUp(KeyCode.Mouse1))
        {
            TurnOnCamera(camToTurnOn: camera1, camera2);
        }

        if (Input.GetKeyDown(KeyCode.Mouse1))
        {
            TurnOnCamera(camToTurnOn: camera2, camera1);
        }


    }

    private void TurnOnCamera(CinemachineVirtualCamera camToTurnOn, CinemachineVirtualCamera camToTunOff)
    {
        camToTurnOn.gameObject.SetActive(true);
        camToTunOff.gameObject.SetActive(false);

    }

}
