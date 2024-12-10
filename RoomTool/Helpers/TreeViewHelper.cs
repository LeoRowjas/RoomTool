using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using RoomTool.Views;

namespace RoomTool.Helpers;

public static class TreeViewHelper
{
    #region Logic of tree view
     /// <summary>
    /// Обработчик изменения состояния чекбокса
    /// </summary>
    public static void CheckBox_CheckedChanged(object sender, RoutedEventArgs e)
    {
        if (sender is CheckBox checkBox && GetParentTreeViewItem(checkBox) is { } parentItem)
        {
            var isChecked = checkBox.IsChecked;
            SetChildCheckBoxes(parentItem, isChecked);
        }
    }
    
    /// <summary>
    /// Задает значение всем дочерним чекбоксам
    /// </summary>
    private static void SetChildCheckBoxes(TreeViewItem item, bool? state)
    {
        foreach (var subItem in item.Items)
        {
            var checkBox = subItem as CheckBox;

            checkBox!.IsChecked = state;
        }
    }
    
    /// <summary>
    /// Нахождение родительского элемента TreeViewItem
    /// </summary>
    private static TreeViewItem? GetParentTreeViewItem(DependencyObject? item)
    {
        while (item != null && item is not TreeViewItem)
        {
            item = VisualTreeHelper.GetParent(item);
        }
        return item as TreeViewItem;
    }
    
    /// <summary>
    /// Обновлят состояние родительского CheckBox при изменении выборки дочерних CheckBox
    /// </summary>
    private static void UpdateParentCheckBoxState(TreeViewItem parentItem)
    {
        var parentCheckBox = (CheckBox)parentItem.Header;
        var childCheckBoxes = parentItem.Items.OfType<CheckBox>().ToList();

        // Проверяем состояния дочерних CheckBox
        var allChecked = childCheckBoxes.All(cb => cb.IsChecked == true);
        var allUnchecked = childCheckBoxes.All(cb => cb.IsChecked == false);

        if (allChecked)
        {
            parentCheckBox.IsChecked = true; 
        }
        else if (allUnchecked)
        {
            parentCheckBox.IsChecked = false;
        }
        else
        {
            parentCheckBox.IsChecked = null;
        }
    }
    #endregion
    public static void CreateSubCheckBoxes(string[] subFloors, TreeViewItem parentItem, TreeView treeView)
    {
        foreach (var subFloor in subFloors)
        {
            var childCheckBox = new CheckBox
            {
                Content = subFloor,
            };

            childCheckBox.Checked += (s, args) => UpdateParentCheckBoxState(parentItem);
            childCheckBox.Checked += (s, args) =>
            {
                var checkBoxes = GetCheckedCheckBoxes(treeView);
                SetParams(checkBoxes);
            };
            childCheckBox.Unchecked += (s, args) => UpdateParentCheckBoxState(parentItem);
            childCheckBox.Unchecked += (s, args) =>
            {
                var checkBoxes = GetCheckedCheckBoxes(treeView);
                SetParams(checkBoxes);
            };

            parentItem.Items.Add(childCheckBox);
        }
    }

    private static void SetParams(List<CheckBox> apartmentsCheckBoxes)
    {
        var param = new List<string>();
        for (int i = 1; i < apartmentsCheckBoxes.Count; i++)
        {
            
        }
    }
    
    private static List<CheckBox> GetCheckedCheckBoxes(TreeView treeView)
    {
        var checkedBoxes = new List<CheckBox>();
        foreach (var item in treeView.Items)
        {
            if (item is TreeViewItem treeViewItem)
            {
                FindCheckedCheckBoxes(treeViewItem, checkedBoxes);
            }
        }
        return checkedBoxes;
    }

    private static void FindCheckedCheckBoxes(ItemsControl parent, List<CheckBox> result)
    {
        foreach (var item in parent.Items)
        {
            if (item is TreeViewItem treeViewItem)
            {
                if (treeViewItem.Header is CheckBox checkBox && checkBox.IsChecked == true)
                {
                    result.Add(checkBox);
                }
                
                FindCheckedCheckBoxes(treeViewItem, result);
            }
        }
    }
    
    
    
    
    #region Tree Bottom Buttons
    public static void SelectAllItems(TreeView treeView)
    {
        foreach (TreeViewItem item in treeView.Items)
        {
            if (item.Header is CheckBox parentCheckBox)
            {
                parentCheckBox.IsChecked = true;
                SetChildCheckBoxes(item, true);
            }
        }
    }

    public static void ClearAllItems(TreeView treeView)
    {
        foreach (TreeViewItem item in treeView.Items)
        {
            if (item.Header is CheckBox parentCheckBox)
            {
                parentCheckBox.IsChecked = false;
                SetChildCheckBoxes(item, false);
            }
        }
    }

    public static void ExpandAllItems(TreeView treeView)
    {
        foreach (TreeViewItem item in treeView.Items)
            item.IsExpanded = true;
    }

    public static void CollapseAllItems(TreeView treeView)
    {
        foreach (TreeViewItem item in treeView.Items)
            item.IsExpanded = false;
    }
    #endregion
}