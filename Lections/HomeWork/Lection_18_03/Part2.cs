using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lection_18_03
{
    class Part2
    {
        //Почему NotifyCollectionChangedEventArgs e.NewItems это list, в котором
        // сегда хранится один объект
        class Person
        {
            public int Age { get; set; }
            public string Name { get; set; }

            public override string ToString()
            {
                return $"Person: Age<{Age}> Name<{Name}>";
            }
        }
        internal static void Run()
        {
            ObservableCollection<Person> people = new ObservableCollection<Person>();
            people.CollectionChanged += Method;
            people.Add(new Person { Age = 1, Name = "Test1" });
            people.Add(new Person { Age = 2, Name = "Test2" });
            people.Add(new Person { Age = 3, Name = "Test3" });

            Console.WriteLine("\n");

            people[0] = new Person() { Age = 4, Name = "Test4" };
            people.Clear();

        }

        private static void Method(object sender, NotifyCollectionChangedEventArgs e)
        {
            switch (e.Action)
            {
                case NotifyCollectionChangedAction.Add:
                    Console.WriteLine($"Add: {(e.NewItems[0] as Person).ToString()}");
                    break;
                case NotifyCollectionChangedAction.Remove:
                    Console.WriteLine($"Remove: {e.OldItems[0] as Person}");
                    break;
                case NotifyCollectionChangedAction.Replace:
                    Console.WriteLine($"Replace: Old:{e.OldItems[0] as Person}, New:{e.NewItems[0] as Person}");
                    break;
                case NotifyCollectionChangedAction.Move:
                    break;
                case NotifyCollectionChangedAction.Reset:
                    Console.WriteLine("Reset");
                    break;
            }

            
            if (e.NewItems != null)
            {
                Console.WriteLine("\t\t======>Foreach new items");
                foreach (var item in e.NewItems)
                {
                    Console.WriteLine("\t\t" + item);
                }
                Console.WriteLine("\t\t======>end foreach");
            }
        }
    }
}
