using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GoogleARCore;
using UnityEngine.SpatialTracking;
using UnityEngine.UI;

public class MovingCamera : MonoBehaviour
{
    public GameObject ARcamera;
    public Text DevicePosition;
    public Text FramePosePosition;

    void Start()
    {
        this.gameObject.transform.position = Frame.Pose.position;
    }

    void Update()
    {
        this.gameObject.transform.position = Frame.Pose.position * (-1);

        DevicePosition.text = "Postions: \nX:" + ARcamera.transform.position.x.ToString() +
            "\nY:" + ARcamera.transform.position.y.ToString() +
            "\nZ:" + ARcamera.transform.position.z.ToString();

        FramePosePosition.text = "Postions: \nX:" + Frame.Pose.position.x.ToString() +
            "\nY:" + Frame.Pose.position.y.ToString() +
            "\nZ:" + Frame.Pose.position.z.ToString();
    }
}
