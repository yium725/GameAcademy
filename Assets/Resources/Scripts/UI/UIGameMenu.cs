using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIGameMenu : MenuBase
{
    public bool Init()
    {
        return true;
    }

    public override void OnClick(Button btn)
    {
        string name = btn.name;
        if(CompareTo(name, "Button - A") == 0)
        {
            UIManager.Instance.OpenPopup<PopupSample>("PopupSample");
            SetText("Text - C", "a clicked");
        }
        else if (CompareTo(name, "Button - B") == 0)
        {
            SoundManager.Instance.PlayEffect("EFF_shoot", 1);
            SetText("Text - C", "b clicked");
        }
    }
}
