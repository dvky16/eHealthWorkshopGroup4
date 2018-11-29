using System;
using System.Collections.Generic;
using System.Text;

namespace eHealthWorkshopGroup4.Models
{
    public enum MenuItemType
    {
        HomeWorkout,
        Browse,
        Profile,
        About
    }
    public class HomeMenuItem
    {
        public MenuItemType Id { get; set; }

        public string Title { get; set; }
    }
}
