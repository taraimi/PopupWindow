using UnityEngine;
using UnityEngine.EventSystems;

public class PopupButton : MonoBehaviour
{
    [SerializeField] int count;

    public void clickPopupWindowButton()
    {
        GameObject popupWindowCanvas = GameObject.Find("PopupWindowCanvas");

        if (popupWindowCanvas != null)
        {
            ExecuteEvents.Execute<PopupWindowInterface>(
              target: popupWindowCanvas,
              eventData: null,
              functor: (reciever, eventData) => reciever.OnReceive(count)
            );
        } else {
            Debug.Log("POPUPウインドウが見つかりませんでした");
        }
    }
}
