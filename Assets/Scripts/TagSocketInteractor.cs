using UnityEngine.XR.Interaction.Toolkit;

public class TagSocketInteractor : XRSocketInteractor
{
    public string objectTag;
    public override bool CanHover(IXRHoverInteractable interactable)
    {
        return base.CanHover(interactable)&&interactable.transform.tag ==objectTag;
    }
    public override bool CanSelect(IXRSelectInteractable interactable)
    {
        return base.CanSelect(interactable)&&interactable.transform.tag ==objectTag;
    }
}
