using System;
using TextAdventure.TALib;
namespace TextAdventure {

    public class TAFuncLib {
        bool game;
        string input = Console.ReadLine ();
        public Room RoomSearch (int id, World thisworld) {
            Room result = null;
            foreach (Room foundroom in thisworld.places) {
                if (foundroom.id == id) {
                    result = foundroom;
                }
            }
            return result;
        }
        public void Buffer (Player one, string input, Room roomyouarein, World world) {
            while (game == true) {
                switch (input.Split (" ") [0]) {
                    case "look":
                        break;
                    case "use":
                        Item useditem = Itemsearch (input.Split (" ") [1], one, roomyouarein);
                        Item otheritem = Itemsearch (input.Split (" ") [2], one, roomyouarein);
                        UseItem (useditem, roomyouarein, otheritem);
                        break;
                    case "go":
                        foreach (Exit thisexit in roomyouarein.exits) {
                            if (thisexit.name == input.Split (" ") [1] + input.Split (" ") [2]) {
                                one.position = thisexit.goesto;
                                Look (one, RoomSearch (one.position, world).lookDesc, world);
                            }
                        }
                        break;
                }
            }
        }
        public void UseItem (Item theitem, Room place, dynamic otheritem) {
            Item thisObject = theitem;
            Item otherobject = otheritem;
            foreach (Trigger thisTrig in theitem.trigarray) {
                foreach (Trigger otherTrig in otherobject.trigarray) {
                    if (otherTrig.usable && otherTrig.id == thisTrig.id) {
                        if (thisTrig.reusable == false) {
                            thisTrig.usable = false;
                        }
                    }
                }

            }
        }
        public void Look (Player one, string lookobject, World thisworld) {
            if (lookobject.Length > 0) {
                Console.WriteLine (lookobject);
            } else {
                Console.WriteLine (RoomSearch (one.position, thisworld).lookDesc);
            }
        }

        public Item Itemsearch (string itemname, Player one, Room isin) {
            Item emptyItem = new Item("Sorry nothing",0,new Trigger[0], "I AM ERROR");
            Item result = emptyItem;
            foreach (Item thisitem in one.inventory) {
                if (thisitem.name == itemname) {
                    result = thisitem;
                }
                else{
                    
                    result = emptyItem;
                }
            }
            foreach (Item thisitem in isin.items) {
                if (thisitem.name == itemname) {
                    result = thisitem;
                }
                else{
                    //string name, int id, Trigger[] trigArray, string lookDesc                    
                    result = emptyItem;
                }
            }
            return result;
        }
    }
    
}