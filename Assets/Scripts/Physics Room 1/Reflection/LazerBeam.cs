using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class LazerBeam : MonoBehaviour
{

    private LineRenderer _lr;
    [SerializeField] private Transform _startPoint;
    [SerializeField] private int _noOfMirrors;
    [SerializeField] private bool reflectOnlyMirror;
    [SerializeField] private ExperimentEvents EventCompletions;
    // Start is called before the first frame update
    void Start()
    {
        _lr = GetComponent<LineRenderer>();
        if (_startPoint == null)
        {
            _startPoint = transform;
        }
        _lr.SetPosition(0, _startPoint.position);
        _lr.positionCount = _noOfMirrors + 1;
    }

    // Update is called once per frame
    void Update()
    {
        CastLazer(transform.position, -transform.forward);
    }

    void CastLazer(Vector3 position, Vector3 direction)
    {
        _lr.SetPosition(0, _startPoint.position);
        for (int i = 0; i < _noOfMirrors; i++)
        {
            Ray ray = new Ray(position, direction);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit, 300))
            {
                position = hit.point;
                direction = Vector3.Reflect(direction, hit.normal);
                _lr.SetPosition(i + 1, hit.point);

                if (hit.transform.tag != "Mirror" && reflectOnlyMirror)
                {
                    for (int j = (i + 1); j <= _noOfMirrors; j++)
                    {
                        _lr.SetPosition(j, hit.point);
                        if (hit.transform.tag == "Target")
                        {
                            EventCompletions.ExperimentCompleted = true;
                        }
                        else
                        {
                            EventCompletions.ExperimentCompleted = false;
                        }
                    }
                    break;
                }
            }
        }
    }
}
