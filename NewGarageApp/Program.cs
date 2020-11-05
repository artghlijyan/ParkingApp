using NewGarageApp.Camera_;
using System;

namespace NewGarageApp
{
    class Program
    {
        static void Main(string[] args)
        {
            SmartMenu.EnterYourCarData();
            SmartMenu.Camera("Audi", "11KK122", "red", DateTime.Parse("11:00"), DateTime.Parse("12:00"));
            SmartMenu smartMenu = new SmartMenu();
            smartMenu.Table();
            SmartMenu.Terminal();
        }
    }
}
