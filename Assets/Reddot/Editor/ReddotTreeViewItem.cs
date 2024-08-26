
using System.Collections.Generic;
using UnityEditor.IMGUI.Controls;

/// <summary>
/// 红点树视图条目，继承Unity自身的TreeViewItem
/// </summary>
public class ReddotTreeViewItem : TreeViewItem
{
    private TreeNode m_node;

    /// <summary>
    /// 节点路径
    /// </summary>
    public string Path
    {
        get;
        private set;
    }

    /// <summary>
    /// 节点值
    /// </summary>
    public int Value
    {
        get;
        private set;
    }


    public ReddotTreeViewItem(int id, TreeNode node)
    {
        base.id = id;

        m_node = node;
        Path = node.FullPath;
        Value = node.Value;
    }

    //重写displayName属性，可以在树形图中显示该字符串
    public override string displayName
    {
        get
        {
            return $"{m_node.Name} - 节点值: {m_node.Value} - 子节点数: {m_node.ChildrenCount}";
        }


    }


}
