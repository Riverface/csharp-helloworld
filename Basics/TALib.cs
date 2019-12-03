using System;
namespace TextAdventure
{
    public class TaLib
    {
        public static Room(Player you, string name, int id, int[] trigArray, string lookDesc, Item[] items)
        {
            this.name = name;
            this.id = id;
            this.trigArray = trigArray;
            this.lookDesc = lookDesc;
            this.exits = exits;
            this.items = items;
        }
        public static Exit(string name, string LookDesc, int goesto)
        {
            this.goesto = goesto;
            this.lookDesc = LookDesc;
            this.name = name;
        }
        public static Item(string name, int id, int[] trigArray, string lookDesc)
        {
            this.name = name;
            this.id = id;
            this.trigarray = trigArray;
            this.lookDesc = lookDesc;
        }

        public static Player(Item[] inventory, int[] flags, int room)
        {
            this.inventory = inventory;
            this.flags = flags;
            this.position = room;
        }
        public static Trigger(string name, int id, string sequence, string DevDesc, bool flag)
        {
            this.name = name;
            this.id = id;
            this.sequence = sequence;
            this.DevDesc = DevDesc;
            this.flag = flag;
            this.reusable = new bool();
            this.usable = new bool();
        }
    }
}