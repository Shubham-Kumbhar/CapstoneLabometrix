using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class TagSocketInteractor : XRSocketInteractor
{
    public string objectTag;
    [Space]
    [Space]
    [Space]
    [Space]
    [Header("Electricity")]
    public GameObject ElectricComponent;
    public bool isbulb;
    public bool isBattery;
    public bool isResistor;
    public bool isInParallel;
    public int ResistanceIndex;
    public SeriesResisterGroup Series;
    public ParallerResisterGroup Paraller;
    public BatteyVoltage batteyVoltage;
    public BulbObject Bulb;
    protected override void Start()
    {
        base.Start();
        Initalization();
    }
    public override bool CanHover(IXRHoverInteractable interactable)
    {
        return base.CanHover(interactable) && interactable.transform.tag == objectTag;
    }
    public override bool CanSelect(IXRSelectInteractable interactable)
    {
        return base.CanSelect(interactable) && interactable.transform.tag == objectTag;
    }


    protected override void OnSelectEntering(SelectEnterEventArgs args)
    {
        base.OnSelectEntering(args);
        var ComponentValue = ElectricComponent.transform.GetComponent<IElectricComponents>().GetComponentValue();
        if (isResistor)
        {
            if (isInParallel)
            {
                Paraller.parallelResistor[ResistanceIndex] = ComponentValue;
            }
            else
            {
                Series.SeriesResister[ResistanceIndex] = ComponentValue;
            }
        }
        if (isbulb)
        {
            Bulb.isPlaced = true;
        }
        if (isBattery)
        {
            batteyVoltage.Volatage = ComponentValue;
        }

    }
    protected override void OnSelectExiting(SelectExitEventArgs args)
    {
        base.OnSelectExiting(args);
        if (isResistor)
        {
            if (isInParallel)
            {
                Paraller.parallelResistor[ResistanceIndex] = 0;
            }
            else
            {
                Series.SeriesResister[ResistanceIndex] = 0;
            }
        }
        if (isbulb)
        {
            Bulb.isPlaced = false;
        }
        if (isBattery)
        {
            batteyVoltage.Volatage = 0;
        }

    }
    void Initalization()
    {
        if (isResistor)
        {
            if (isInParallel)
            {
                Paraller.parallelResistor[ResistanceIndex] = 0;
            }
            else
            {
                Series.SeriesResister[ResistanceIndex] = 0;
            }
        }
        if (isbulb)
        {
            Bulb.isPlaced = false;
        }
        if (isBattery)
        {
            batteyVoltage.Volatage = 0;
        }
    }


    protected new void OnTriggerEnter(Collider other)
    {
        ElectricComponent = other.gameObject;
    }

    protected new void OnTriggerExit(Collider other)
    {
        ElectricComponent = null;
    }

}
