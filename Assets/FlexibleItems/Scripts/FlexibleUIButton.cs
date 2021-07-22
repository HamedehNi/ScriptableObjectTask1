using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
[RequireComponent(typeof(Image))]
public class FlexibleUIButton : FlexibleUI
{
    public enum ButtonType
	{
        Left,
        Right
	}

	Image image;
	Image icon;
    Button button;

    public ButtonType buttonType;


    protected override void OnskinUI()
    {
        base.OnskinUI();

        image = GetComponent<Image>();
        icon = transform.Find("Icon").GetComponent<Image>();
		button = GetComponent<Button>();

        button.transition = Selectable.Transition.SpriteSwap;
        button.targetGraphic = image;

        image.sprite = skinData.buttonSprite;
		image.type = Image.Type.Sliced;
        button.spriteState = skinData.buttonSpriteState;

        switch (buttonType)
		{
            case ButtonType.Left:
				icon.sprite = skinData.LeftSprite;
				break;

			case ButtonType.Right:
				icon.sprite = skinData.RightSprite;
                break;

		}

	}
    
}
