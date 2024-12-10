using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Documents;
using RoomTool.Helpers;
using RoomTool.Models;
using Teigha.Runtime;

namespace RoomTool.Views
{
    public partial class CoefficientModalWindow : Window
    {

        public CoefficientModalWindow()
        {
            InitializeComponent();
        }

        private void SaveButton_OnClick(object sender, RoutedEventArgs e)
        {
            SetCoefficients();
            DialogResult = true;
        }

        private void SetCoefficients()
        {
            var coefficient = new List<double>
            {
                double.Parse(LivingSpacesApartments.Text),
                double.Parse(UnlivingSpacesApartments.Text),
                double.Parse(Logia.Text),
                double.Parse(BalconyOrTerrace.Text),
                double.Parse(UnlivingSpacesPublic.Text),
                double.Parse(Offices.Text),
                double.Parse(WarmLogia.Text),
            };
            var names = new List<string>()
            {
                "Жилые помещения квартиры",
                "Нежилые помещения квартиры",
                "Лоджия",
                "Балкон, терраса",
                "Нежилые помещения общественные",
                "Офисы",
                "Теплые лоджии",
            };
            var result = new Dictionary<string, double>();
            for (var i = 0; i < names.Count; i++)
                result.Add(names[i], coefficient[i]);
            
            Coefficients.CoefficientsDictionary = result;
        }
    }
}