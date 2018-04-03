using System;
using System.Diagnostics;
using System.Linq;

#pragma warning disable 169
// ReSharper disable ArrangeTypeMemberModifiers
// ReSharper disable UnusedMember.Global

namespace ReSharper20181CSharp
{
    // EditorConfig, StyleCop
    public class FormattingInspections
    {
        Basket CreateNewBasket () => new Basket(); Basket CreateSurpriseBasket() =>
                new SurpriseBasket();

        public int Balance; int _sneaky
                = 1000;

        public void M (bool condition)
        {
            if (condition)
                DoConditionally();
                DoAlways();

            if (condition) DoConditionally(); DoAlways();
        }

        public void N (bool condition)
        {
        if (condition)
            DoConditionally();
        }

        public void O (bool condition)
        {
            if (condition)
                DoConditionally();
            }
            
            int TypeOrLocalFunction () => 0;

        public void P (bool condition)
        {
            if (condition)
                DoConditionally();
			DoAlways();
        }
        
        private static void DoAlways ()
        {
            Console.WriteLine("oijsdofijdf");
        }

        private static void DoConditionally ()
        {
            throw new NotImplementedException();
        }

        public class Basket
        {
        }

        class SurpriseBasket : Basket
        {
        }
    }
}
