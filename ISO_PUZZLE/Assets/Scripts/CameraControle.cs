using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class CameraControle : MonoBehaviour
{
    public GameObject target;
    public GameObject VantagePoint;
    public float VantageSize = 10;
    public Vector3 Offset;

    public int interpolationFrames = 45; // Number of frames to completely interpolate between the 2 positions
    private int elapsedFrames = 0;

    private Vector3 lastTargetPos;
    private Vector3 TargetPos;
    private Camera cam;
    private float defaultSize;
    private float activeSize;
    // Start is called before the first frame update
    void Start()
    {
        cam = GetComponent<Camera>();
        TargetPos = transform.position;
        lastTargetPos = TargetPos;
        defaultSize = cam.orthographicSize;
        activeSize = defaultSize;
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.M))
        {
            TargetPos = VantagePoint.transform.position;
            activeSize = VantageSize;
        }
        else
        {
            TargetPos = target.transform.position + Offset;
            activeSize = defaultSize;
        }

        if (lastTargetPos != TargetPos)
        {
            elapsedFrames = 0;
        }
        float interpolationRatio = (float)elapsedFrames / interpolationFrames;
        transform.position = Vector3.Lerp(transform.position, TargetPos, interpolationRatio);
        cam.orthographicSize = Mathf.Lerp(cam.orthographicSize, activeSize, interpolationRatio);
        elapsedFrames = (elapsedFrames + 1) % (interpolationFrames + 1);  // reset elapsedFrames to zero after it reached (interpolationFramesCount + 1)
        lastTargetPos = TargetPos;
    }
}
