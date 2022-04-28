using System;
using System.Collections.Generic;

namespace IceCreamShop
{
    class Program
    {
        static void Main(string[] args)
        {
            Case menu = new Case();
            List<Flavor> availableFlavors = menu.Flavors;
            List<Cone> availableCones = menu.Cones;
            FlavorComparer comparer = new FlavorComparer();
            ConeComparer coneComparer = new ConeComparer();
            // TODO: Use a Comparer class to sort the 'flavors' array alphabetically by the 'name'
            //  field.
            availableFlavors.Sort(comparer);
            foreach (Flavor flavor in availableFlavors)
            {
                foreach(string allergens in flavor.Allergens)
                {
                    Console.WriteLine(allergens); //TODO: Print list of Allergens in more readable format
                }
            }

            availableCones.Sort(coneComparer);
            //foreach(Cone cone in availableCones)
            //{
            //    Console.WriteLine($"{cone.Name} - {cone.Cost}");
            //}
        // TODO: Use a Comparator class to sort the 'cones' array in increasing order by the 'cost'
        //  field.

        // TODO: Print the 'flavors' and 'cones' lists (in a clear manner) to verify the sorting.
        }
    }
}
