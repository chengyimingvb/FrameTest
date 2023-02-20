//------------------------------------------------------------------------------
// MainMenuView.cs
// Created by CYM on 2022/7/23
// 填写类的描述...
//------------------------------------------------------------------------------
using CYM;
using CYM.UI;
using UnityEngine;
using UnityEngine.EventSystems;
namespace NationWar
{
    public class MainMenuView : UMainMenuView
    {
        protected override void OnClickNewGame(UControl arg1, PointerEventData arg2)
        {

        }

        protected override void OnTutorial(UControl arg1, PointerEventData arg2)
        {
            MainUIMgr.TestLuaView.Show();
        }

        protected override Sprite GetGameLogo()
        {
            return "Logo".GetIcon();
        }
    }
}