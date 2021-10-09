using HatShop.Models;
using MvvmHelpers;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace HatShop.ViewModels
{
    public class HomeViewModel : ViewModelBase
    {
        public ObservableRangeCollection<Hat> Hat { get; set; }
        public ObservableRangeCollection<Grouping<string, Hat>> HatGroups { get; set; }

        public HomeViewModel()
        {
            Title = "Home";

            Hat = new ObservableRangeCollection<Hat>();
            HatGroups = new ObservableRangeCollection<Grouping<string, Hat>>();

            Hat.Add(new Hat { Style = "Baseball Cap", Price = "P50", Image = "baseball_cap.jpg" });
            Hat.Add(new Hat { Style = "Beanie", Price = "P60", Image = "beanie.jpg" });
            Hat.Add(new Hat { Style = "Fedora", Price = "P150", Image = "fedora.jpg" });

        }
    }
}
