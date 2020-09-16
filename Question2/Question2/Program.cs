using System;

namespace Question2
{
    class Program
    {
        static void Main(string[] args)
        {
            var human = new Human<Creature>();
            human.Addcharacteristic(new Creature { Name = "Asian", Details = "Most of them are brown, short etc etc etc" },
                new Creature { Name = "African", Details = "Most of them are tall, black etc etc etc" });
            human.RemoveCharacteristic(new Creature { Name = "African", Details = "Most of them are tall, black etc etc etc" });
        }
    }
}
