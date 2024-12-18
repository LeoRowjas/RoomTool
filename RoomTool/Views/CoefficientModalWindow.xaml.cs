using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using RoomTool.Helpers;

namespace RoomTool.Views
{
    public partial class CoefficientModalWindow : Window
    {

        public CoefficientModalWindow()
        {
            InitializeComponent();
            SetDefaultValues();
        }

        private void SaveButton_OnClick(object sender, RoutedEventArgs e)
        {
            SetCoefficients();
            DialogResult = true;
            Close();
        }
        
        private void SetDefaultValues()
        {
            var textBoxes = GetAllTextBoxes(this);

            foreach (var textBox in textBoxes)
            {
                if (Coefficients.CoefficientsDictionary.TryGetValue(textBox.Name, out var value))
                {
                    textBox.Text = value.ToString(CultureInfo.InvariantCulture);
                }
            }
        }

        private void SetCoefficients()
        {
            var textBoxes = GetAllTextBoxes(this);
            var coefficient = textBoxes
                .Select(tb => double.Parse(tb.Text, CultureInfo.InvariantCulture))
                .ToList();
            
            var names = Coefficients.CoefficientsDictionary.Keys.ToList();
            var result = new Dictionary<string, double>();
            for (var i = 0; i < names.Count; i++)
                result[names[i]] = coefficient[i];

            Coefficients.CoefficientsDictionary = result;
        }

        private List<TextBox> GetAllTextBoxes(DependencyObject parent)
        {
            var textBoxes = new List<TextBox>();
            foreach (var child in LogicalTreeHelper.GetChildren(parent))
            {
                if (child is TextBox textBox)
                {
                    textBoxes.Add(textBox);
                }
                else if (child is DependencyObject dependencyObject)
                {
                    textBoxes.AddRange(GetAllTextBoxes(dependencyObject));
                }
            }
            return textBoxes;
        }
    }
}