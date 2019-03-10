using System;
using System.Collections.Generic;
using System.Text;

namespace SkyNewsArticles.Models
{
    public enum MenuItemType
    {
        Articles,
        menulist2,
        menulist3
    }
    public class HomeMenuItem
    {
        public MenuItemType Id { get; set; }

        public string Title { get; set; }
    }
}
