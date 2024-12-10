using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using RoomTool.Helpers;
using RoomTool.Models;

namespace RoomTool.Views
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private static BuildingModel _buildingModel;

        public MainWindow()
        {
            InitializeComponent();
            _buildingModel = SpaceHelper.GetBuildingModel();
        }
        
        private void FloorTree_Loaded(object sender, RoutedEventArgs e)
        {
            foreach (var floor in _buildingModel.ApartmentsByFloor)
            {
                var rootCheckBox = new CheckBox
                {
                    Content = floor.Key,
                    IsChecked = false,
                };
                
                var parentItem = new TreeViewItem { Header = rootCheckBox };
                
                //по идее нужно добавить чтобы при Checked брались параметры от конкретного объекта SpaceEntity
                rootCheckBox.Click += (s, args) => TreeViewHelper.CheckBox_CheckedChanged(rootCheckBox, e);
                
                TreeViewHelper.CreateSubCheckBoxes(floor.Value, parentItem, FloorTree);
                FloorTree.Items.Add(parentItem);
            }
        }
        
        private void CoefficientSettingsButton_OnClick(object sender, RoutedEventArgs e)
        {
            var coefficientSettingsWindow = new CoefficientModalWindow();
            coefficientSettingsWindow.ShowDialog();
        }
        
        // Обработчик для кнопки "Выбрать все"
        private void SelectAll_Click(object sender, RoutedEventArgs e) => TreeViewHelper.SelectAllItems(FloorTree);
        // Обработчик для кнопки "Сбросить"
        private void ClearAll_Click(object sender, RoutedEventArgs e) => TreeViewHelper.ClearAllItems(FloorTree);
        // Обработчик для кнопки "Раскрыть все"
        private void ExpandAll_Click(object sender, RoutedEventArgs e) => TreeViewHelper.ExpandAllItems(FloorTree); 
        // Обработчик для кнопки "Спрятать все"
        private void CollapseAll_Click(object sender, RoutedEventArgs e) => TreeViewHelper.CollapseAllItems(FloorTree);
        
        private void OkButton_OnClick(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
        }
    }
}