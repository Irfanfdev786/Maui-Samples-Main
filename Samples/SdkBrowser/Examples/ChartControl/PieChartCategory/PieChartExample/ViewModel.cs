﻿using SDKBrowserMaui;
using System.Collections.ObjectModel;

namespace SDKBrowser.Examples.ChartControl.PieChartCategory.PieChartExample
{
    // >> chart-piechart-view-model
    public class ViewModel
    {
        public ObservableCollection<CategoricalData> Data { get; set; }

        public ViewModel()
        {
            this.Data = GetCategoricalData();
        }

        private static ObservableCollection<CategoricalData> GetCategoricalData()
        {
            var data = new ObservableCollection<CategoricalData>
            {
                new CategoricalData { Category = "Greenings", Value = 52 },
                new CategoricalData { Category = "Perfecto", Value = 19 },
                new CategoricalData { Category = "NearBy", Value = 82 },
                new CategoricalData { Category = "Family", Value = 23 },
                new CategoricalData { Category = "Fresh", Value = 56 },
            };
            return data;
        }
    }
    // << chart-piechart-view-model
}
