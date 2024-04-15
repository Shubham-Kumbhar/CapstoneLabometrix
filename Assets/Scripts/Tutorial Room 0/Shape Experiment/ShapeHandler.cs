using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShapeHandler : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private ShapeChecker[] _checker;
    [SerializeField] private ExperimentEvents CompletionEvent;

    // Update is called once per frame
    void Update()
    {
        allShapeCorrect();
    }

    void allShapeCorrect()
    {
        foreach (ShapeChecker checker in _checker)
        {
            if (!checker.shape.isCorrect)
            {
                return;
            }
        }
        CompletionEvent.ExperimentCompleted = true;
    }
}
