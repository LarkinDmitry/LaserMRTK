using System.Collections.Generic;
using UnityEngine;

class Laser : MonoBehaviour
{
    public GameObject LinePrefab;

    private LineRenderer laserLine;

    private List<Vector3> laserBreakpoints = new List<Vector3>();

    private float laserRange = 0;

    private float maxLaserRange = 100;

    private float laserPower = 0;

    private float maxLaserPower = 100;

    private float upOffset = 0.0f;

    private float forwardOffset = 0.0f;

    private float rightOffset = 0.0f;

    private bool isActiv;


    private void Start()
    {
        laserLine = Instantiate(LinePrefab, Vector3.zero, Quaternion.identity).GetComponent<LineRenderer>();
    }

    private void Update()
    {
        if (isActiv)
        {
            if (!laserLine.gameObject.activeSelf) laserLine.gameObject.SetActive(true);

            if (laserBreakpoints.Count != 0) laserBreakpoints.Clear();

            Vector3 startLaserPoint = transform.position + transform.up * upOffset + transform.forward * forwardOffset + transform.right * rightOffset;

            laserBreakpoints.Add(startLaserPoint);

            // create new ray (recursive function)
            BuildRays(startLaserPoint, -transform.forward, laserRange, laserPower);

            DrawLines();
        }
        else
        {
            if(laserLine.gameObject.activeSelf) laserLine.gameObject.SetActive(false);
        }
        
    }

    private void BuildRays(Vector3 startPosition, Vector3 direction, float laserRange, float power)
    {
        Ray ray = new Ray(startPosition, direction);

        // intersection point calculation
        bool intersect = Physics.Raycast(ray, out RaycastHit hit, laserRange);
        Vector3 hitPosition = intersect ? hit.point : startPosition + direction * laserRange;

        // add new intersect point or finish point
        laserBreakpoints.Add(hitPosition);

        // calculation remainder laser length
        float remaindLaserRange = laserRange - hit.distance;

        // calculation remainder power (in case of intersect)
        float remainderPower = power;
        
        if (intersect)
        {
            remainderPower--;

            // if there is still laser power, create new ray
            if (remainderPower > 0)
            {
                BuildRays(hitPosition, Vector3.Reflect(direction, hit.normal), remaindLaserRange, remainderPower);
            }
        }
    }

    private void DrawLines()
    {
        laserLine.positionCount = laserBreakpoints.Count;
        laserLine.SetPositions(laserBreakpoints.ToArray());
    }

    public void SetLaserRange(float range)
    {
        // range >= 0
        if (range < 0) range = 0;

        // range <= maxLaserRange
        if (range > maxLaserRange) range = maxLaserRange;

        laserRange = range;
    }

    public void SetLaserPower(float power)
    {
        // power >= 0
        if (power < 0) power = 0;

        // power <= maxLaserPower
        if (power > maxLaserPower) power = maxLaserPower;

        laserPower = power;
    }

    public void SetActiv(bool state)
    {
        isActiv = state;
    }

    public float GetLaserRange() => laserRange;

    public float GetLaserPower() => laserPower;

    public bool GetActivState() => isActiv;
}
