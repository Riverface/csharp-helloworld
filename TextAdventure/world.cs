using System;
namespace TextAdventure.MainGame {
    using TextAdventure.TALib;
    using TextAdventure;
    public class mainworld {
        public void Enter () {
            World activeworld = new World ();
            Room bedroom = new Room ("Bedroom", 0, new Trigger[255], "Your room. In it is a Bed, a Desk with a computer, a few garments littering the floor, and a brand new drum set is in the corner.", new Item[255]);
            Room hallway = new Room("Hallway", 1, new Trigger[255], "The hallway. There are doors to Your Room, the bathroom, and The Closet here.",new Item[255] );
            Room bathroom = new Room("Bathroom",2,new Trigger[255], "The Bathroom. There is a door to the Hallway, a Toilet, a Sink, and a Shower. On the sink is a bar of soap.",new Item[255]);
            activeworld.places[0] = bedroom;
            activeworld.places[1] = hallway;
            activeworld.player.position = 0;
        }
    }   
}