using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Entrée_classes;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Side_Classes;
using BleakwindBuffet.Data.Sides;
using Xunit;

namespace BleakwindBuffet.DataTests
{
    public class ComboTests
    {
        public void IfPricePropertyIsCorrect()
        {
            BriarheartBurger b = new BriarheartBurger();
            AretinoAppleJuice a = new AretinoAppleJuice() ;
            VokunSalad v = new VokunSalad();
            ImplementFunctionalityCombo combo = new ImplementFunctionalityCombo(b, a, v);
            double price = (b.Price + a.Price + v.Price) - 1;
            Assert.Equal(price, combo.Price);


        }
        public void IfCaloriesPropertyIsCorrect()
        {
            BriarheartBurger b = new BriarheartBurger();
            AretinoAppleJuice a = new AretinoAppleJuice();
            VokunSalad v = new VokunSalad();
            ImplementFunctionalityCombo combo = new ImplementFunctionalityCombo(b, a, v);
            //similar 
            double cal = (b.Calories + a.Calories + v.Calories);
            Assert.Equal(cal, combo.Calories);
        }

    }
}
