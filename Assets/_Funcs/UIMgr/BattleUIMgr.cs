//------------------------------------------------------------------------------
// BattleUIMgr.cs
// Created by CYM on 2021/12/6
// 填写类的描述...
//------------------------------------------------------------------------------
using CYM;
using CYM.UI;
namespace NationWar
{
    public class BattleUIMgr : BaseBattleUIMgr
    {
        #region prop
        public static BattleMainView BattleMainView { get; private set; }
        public static UBattleMenuView BattleMenuView { get; private set; }
        #endregion

        #region life
        protected override void OnCreateUIView1()
        {
            base.OnCreateUIView1();
            BattleMainView = CreateView<BattleMainView>("BattleMainView");
            BattleMenuView = CreateView<UBattleMenuView>("BattleMenuView");
        }
        #endregion
    }
}