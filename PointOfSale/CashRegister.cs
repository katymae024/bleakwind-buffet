using RoundRegister;
using System;
using System.Collections.Generic;
using System.Text;

namespace PointOfSale
{
    public class CashRegister
    {
        public void Checking()
        {
            CardReader.RunCard(0);
        }
        
    }
}
