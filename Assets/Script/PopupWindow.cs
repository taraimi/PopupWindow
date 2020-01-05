using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class PopupWindow : MonoBehaviour, PopupWindowInterface
{
    [SerializeField] GameObject popupWindow;
    [SerializeField] Text popupWindowText;

    // Popupボタンから
    public void OnReceive(int count)
    {
        popupWindowText.text = string.Format("POPUPウインドウの表示:{0}", count);
        popupWindow.SetActive(true);
    }
}

public interface PopupWindowInterface : IEventSystemHandler
{
    void OnReceive(int count);

}
