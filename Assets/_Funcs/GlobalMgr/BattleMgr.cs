//------------------------------------------------------------------------------
// BattleMgr.cs
// Created by CYM on 2022/7/23
// 填写类的描述...
//------------------------------------------------------------------------------
using CYM;
namespace NationWar
{
    public class BattleMgr : BaseBattleMgr<TDBattleData>
    {
        protected override bool NeedPauseLoading => true;
    }
}