using System;
namespace TextAdventure
{
    class TaLib
    {
        Room(Player you, string name, int id, int[] trigArray, string lookDesc, Item[] items)
        {
            this.name = name;
            this.id = id;
            this.trigArray = trigArray;
            this.lookDesc = lookDesc;
            this.exits = exits;
            this.items = items;
        }
        Exit(string name, string LookDesc, int goesto)
        {
            this.goesto = goesto;
            this.lookDesc = LookDesc;
            this.name = name;
        }
        Item(string name, int id, int[] trigArray, string lookDesc)
        {
            this.name = name;
            this.id = id;
            this.trigarray = trigArray;
            this.lookDesc = lookDesc;
        }
        public void UseItem(string theitem, Room place, string targetobject)
        {
           Object thisObject = Itemsearch(theitem);
           Object otherobject = Itemsearch(theitem);
            foreach(Trigger thisTrig in thisObject.trigArray){
            
            }
        }
        Player(Item[] inventory, int[] flags, int room)
        {
            this.inventory = inventory;
            this.flags = flags;
            this.position = room;
        }
        public void Buffer(Player one, string input, Room roomyouarein)
        {
            switch (input.Split(" ")[0])
            {
                case "look":
                    break;
                case "use":
                    UseItem(Itemsearch(input.Split(" ")[1]));
                    break;
                case "go":
                    foreach (Exit thisexit in roomyouarein.exits)
                    {
                        if (thisexit.name == input.Split(" ")[1])
                        {
                            one.position = thisexit.goesto;
                            one.position.Look();
                        }
                    }
                    break;
            }

        }
        public void Look(object lookingat)
        {
            Console.WriteLine(lookingat.lookDesc);
        }
        public Item Itemsearch(string itemname, object roomorplayer)
        {
            Item result;
            foreach (item thisitem in roomorplayer.items)
            {
                if (thisitem.name == itemname)
                {
                    result = thisitem;
                }
            }
            if (result != null)
            {
                return result;
            }
        }
        Trigger(string name, int id, string sequence, string DevDesc, bool flag)
        {
            this.name = name;
            this.id = id;
            this.sequence = sequence;
            this.DevDesc = DevDesc;
            this.flag = flag;
        }
    }

}