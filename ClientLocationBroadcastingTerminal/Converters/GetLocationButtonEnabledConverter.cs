﻿using System;
using System.Globalization;
using System.Windows.Data;

namespace ClientLocationBroadcastingTerminal.Converters
{
    public class GetLocationButtonEnabledConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return value == null ? false : true;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}