using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIMenuIntro : MenuBase
{
    public override void OnInit()
    {

    }

    public bool InitMenu()
    {
        return true;
    }

    protected override void OnClick(Button btn)
    {
        string name = btn.name;
        if(name == "Button - Start")
        {
            AppManager.Instance.ChangeScene(SceneBase.SCENES.MENU);
        }
    }
}
