using System;
using System.Collections.Generic;
using System.Linq;
using Cirrious.CrossCore.UI;
using Cirrious.MvvmCross.ViewModels;

namespace SpinnerTest.Core.ViewModels
{
    public class FirstViewModel : MvxViewModel
    {
        public FirstViewModel() 
        {
            var random = new Random();

            var colors = new List<MvxColor>();
            for(var i = 0; i < 10; i++)
            {
                var color = new MvxColor(random.Next(0, 255), random.Next(0, 255), random.Next(0, 255));
                colors.Add(color);
            }

            Colors = colors;
            SelectedColor = Colors.First();
        }

        private MvxColor _selectedColor;
        public MvxColor SelectedColor
        {
            get { return _selectedColor; }
            set 
            {
                _selectedColor = value; 
                RaisePropertyChanged(() => SelectedColor);
            }
        }

        private IEnumerable<MvxColor> _colors;
        public IEnumerable<MvxColor> Colors
        {
            get { return _colors; }
            set
            {
                _colors = value;
                RaisePropertyChanged(() => Colors);
            }
        }
    }
}
