namespace TextAdventure
{

    public class TAFuncLib
    {
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
                        if (thisexit.name == input.Split(" ")[1] + input.Split(" ")[2])
                        {
                            one.position = thisexit.goesto;
                            one.position.Look();
                        }
                    }
                    break;
            }
        }
        public void UseItem(string theitem, Room place, string targetobject)
        {
            Object thisObject = Itemsearch(theitem);
            Object otherobject = Itemsearch(targetobject);
            foreach (Trigger thisTrig in thisObject.trigArray)
            {
                foreach (Trigger otherTrig in otherobject.trigArray)
                {
                    if (otherTrig.id == thisTrig.id)
                    {
                        if (thisTrig.used && otherTrig.used)
                        {
                            if (thisTrig.reusable == false)
                            {
                                thisTrig.usable = false;
                            }
                        }
                    }
                }
            }
        }
        public void Look(string lookobject)
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
    }
}