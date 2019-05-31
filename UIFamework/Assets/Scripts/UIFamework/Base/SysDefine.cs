using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SysDefine 
{
    /// <summary>
    /// UI窗体（位置）类型
    /// </summary>
    public enum UIFormType
    {
        //普通窗体
        Normal,
        //固定窗体
        Fixed,
        //弹出窗体
        PopUp
    }

    /// <summary>
    /// UI窗体的显示类型
    /// </summary>
    public enum UiFormShowMode
    {
        //普通
        Normal,
        //反向切换
        ReverseChange,
        //隐藏其他
        HideOther
    }

    /// <summary>
    /// UI窗体透明度类型
    /// </summary>
    public enum UiFormLucencyType
    {
        //完全透明,不能穿透
        Lucency,
        //半透明,不能穿透
        Translucence,
        //低透明度,不能穿透
        ImPenetrable,
        //可以穿透
        Pentrate
    }
}
