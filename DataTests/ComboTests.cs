/*Author: Katayoun Katy Davoudi
 * Class: ComboTests.cs
 * Purpose: has tests that relate to the ImplementFuntionalityCombo class
 */
using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Drink_Classes;
using BleakwindBuffet.Data.Entrée_classes;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Side_Classes;
using BleakwindBuffet.Data.Sides;
using Xunit;

namespace BleakwindBuffet.DataTests
{
    /// <summary>
    /// class comboTest that contains the tests of combo class
    /// </summary>
    public class ComboTests
    {
        /// <summary>
        /// checks if variety of combo items are correct
        /// </summary>
        [Fact]
        public void IfSpecialInstructionsSSIsCorrect()
        {
            SmokehouseSkeleton s = new SmokehouseSkeleton();
            CandlehearthCoffee c = new CandlehearthCoffee();
            MadOtarGrits m = new MadOtarGrits();
            ImplementFunctionalityCombo combo = new ImplementFunctionalityCombo(s, c, m);

            List<string> list = new List<string>();
            list.Add(s.ToString());
            list.Add(c.ToString());
            list.Add(m.ToString());

            list.AddRange(s.SpecialInstructions);
            list.AddRange(c.SpecialInstructions);
            list.AddRange(m.SpecialInstructions);
            Assert.Equal(list, combo.SpecialInstructions);

            
        }
        /// <summary>
        /// checks if variety of combo items are correct
        /// </summary>
        [Fact]
        public void IfSpecialInstructionsPropertyIsCorrect()
        {
            PhillyPoacher p = new PhillyPoacher();
            MarkarthMilk m = new MarkarthMilk();
            FriedMiraak f = new FriedMiraak();
            ImplementFunctionalityCombo combo = new ImplementFunctionalityCombo(p, m, f);

            List<string> list = new List<string>();
            list.Add(p.ToString());
            list.Add(m.ToString());
            list.Add(f.ToString());

            list.AddRange(p.SpecialInstructions);
            list.AddRange(m.SpecialInstructions);
            list.AddRange(f.SpecialInstructions);
            Assert.Equal(list, combo.SpecialInstructions);

            
        }
        /// <summary>
        /// checks if price is correct
        /// </summary>
        [Fact]
        public void IfPricePropertyIsCorrect()
        {
            BriarheartBurger b = new BriarheartBurger();
            AretinoAppleJuice a = new AretinoAppleJuice() ;
            VokunSalad v = new VokunSalad();
            ImplementFunctionalityCombo combo = new ImplementFunctionalityCombo(b, a, v);
            double price = (b.Price + a.Price + v.Price) - 1;
            Assert.Equal(price, combo.Price);


        }
        /// <summary>
        /// checks if calories is correct
        /// </summary>
        [Fact]
        public void IfCaloriesPropertyIsCorrect()
        {
            BriarheartBurger b = new BriarheartBurger();
            AretinoAppleJuice a = new AretinoAppleJuice();
            VokunSalad v = new VokunSalad();
            ImplementFunctionalityCombo combo = new ImplementFunctionalityCombo(b, a, v);
         
            double cal = (b.Calories + a.Calories + v.Calories);
            Assert.Equal(cal, combo.Calories);
        }
        /// <summary>
        /// checks if variety of combo items are correct
        /// </summary>
        [Fact]
        public void IfSpecialInstructionsBBIsCorrect()
        {
            BriarheartBurger b = new BriarheartBurger();
            AretinoAppleJuice a = new AretinoAppleJuice();
            VokunSalad v = new VokunSalad();
            ImplementFunctionalityCombo combo = new ImplementFunctionalityCombo(b, a, v);
            
            List<string> list = new List<string>();
            list.Add(b.ToString());
            list.Add(a.ToString());
            list.Add(v.ToString());

            list.AddRange(b.SpecialInstructions);
            list.AddRange(a.SpecialInstructions);
            list.AddRange(v.SpecialInstructions);
            Assert.Equal(list, combo.SpecialInstructions);
            
            
        }

        /// <summary>
        /// checks if variety of combo items are correct
        /// </summary>
        [Fact]
        public void IfSpecialInstructionsGOIsCorrect()
        {
            GardenOrcOmelette b = new GardenOrcOmelette();
            WarriorWater v = new WarriorWater();
            MadOtarGrits a = new MadOtarGrits();
            ImplementFunctionalityCombo combo = new ImplementFunctionalityCombo(b, v, a);

            List<string> list = new List<string>();
            list.Add(b.ToString());
            list.Add(v.ToString());
            list.Add(a.ToString());

            list.AddRange(b.SpecialInstructions);
            list.AddRange(v.SpecialInstructions);
            list.AddRange(a.SpecialInstructions);
            Assert.Equal(list, combo.SpecialInstructions);


        }
        /// <summary>
        /// checks if variety of combo items are correct
        /// </summary>
        [Fact]
        public void IfSpecialInstructionsTTIsCorrect()
        {
            ThalmorTriple b = new ThalmorTriple();
            SailorSoda v = new SailorSoda();
            DragonbornWaffleFries a = new DragonbornWaffleFries();
            ImplementFunctionalityCombo combo = new ImplementFunctionalityCombo(b, v, a);

            List<string> list = new List<string>();
            list.Add(b.ToString());
            list.Add(v.ToString());
            list.Add(a.ToString());

            list.AddRange(b.SpecialInstructions);
            list.AddRange(v.SpecialInstructions);
            list.AddRange(a.SpecialInstructions);
            Assert.Equal(list, combo.SpecialInstructions);


        }
        /// <summary>
        /// checks if variety of combo items are correct
        /// </summary>
        [Fact]
        public void IfSpecialInstructionsTTBIsCorrect()
        {
            ThugsTBone b = new ThugsTBone();
            AretinoAppleJuice v = new AretinoAppleJuice();
            VokunSalad a = new VokunSalad();
            ImplementFunctionalityCombo combo = new ImplementFunctionalityCombo(b, v, a);

            List<string> list = new List<string>();
            list.Add(b.ToString());
            list.Add(v.ToString());
            list.Add(a.ToString());

            list.AddRange(b.SpecialInstructions);
            list.AddRange(v.SpecialInstructions);
            list.AddRange(a.SpecialInstructions);
            Assert.Equal(list, combo.SpecialInstructions);


        }
        /// <summary>
        /// checks if variety of combo items are correct
        /// </summary>
        [Fact]
        public void IfSpecialInstructionsDDIsCorrect()
        {
            DoubleDraugr b = new DoubleDraugr();
            MarkarthMilk v = new MarkarthMilk();
            MadOtarGrits a = new MadOtarGrits();
            ImplementFunctionalityCombo combo = new ImplementFunctionalityCombo(b, v, a);

            List<string> list = new List<string>();
            list.Add(b.ToString());
            list.Add(v.ToString());
            list.Add(a.ToString());

            list.AddRange(b.SpecialInstructions);
            list.AddRange(v.SpecialInstructions);
            list.AddRange(a.SpecialInstructions);
            Assert.Equal(list, combo.SpecialInstructions);


        }





    }
}
