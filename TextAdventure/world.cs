using System;
using TextAdventure;
using TextAdventure.TALib;

namespace TextAdventure.MainGame {

    public class mainworld {
        public static void Enter () {
            World activeworld = new World ();
            Room bedroom = new Room (0, "Bedroom", "Your room. In it is a Bed, a Desk with a computer, a few garments littering the floor, and a brand new drum set is in the corner.");
            Room closet = new Room (2, "Closet", "Your small walk-in closet.");

            Exit bedroomdoor = new Exit ("bedroom door", "The door out of your bedroom.", 1);
            bedroom.exits[0] = bedroomdoor;
            bedroomdoor.goesto = 0;
            bedroomdoor.lookDesc = "The door into your bathroom";

            Room hallway = new Room (1, "Hallway", "The hallway. There are doors to Your Room, the bathroom, and The Closet here.");
            hallway.exits[0] = bedroomdoor;

            Exit bathroomdoor = new Exit ("bedroom door", "The door out of your bathroom.", 1);

            Room bathroom = new Room (4, "Bathroom", "The Bathroom. There is a door to the Hallway, a Toilet, a Sink, and a Shower. On the sink is a bar of soap.");
            bathroom.exits[0] = bathroomdoor;
            bathroomdoor.goesto = 1;
            Room livingroom = new Room (3, "Living Room", "The Living Room. There is a TV, a Couch, and a coffee table. On the coffee table is a huge bowl filled with eggs. Too many eggs.");
            Item egg = new Item ("egg", 9, "It's an egg.");
            for (int eggcount = 0; eggcount < 45; eggcount++) {
                switch (eggcount) {
                    case 0:
                        egg.lookDesc = "Some";
                        break;
                    case 1:
                        egg.lookDesc = "BODY Once told me";
                        break;
                    case 2:
                        egg.lookDesc = "The world was gonna roll me";
                        break;
                    case 3:
                        egg.lookDesc = "I ain't the sharpest tool in the shed";
                        break;
                    case 4:
                        egg.lookDesc = "She was lookin' kind of dumb with her finger and her thumb";
                        break;
                    case 5:
                        egg.lookDesc = "in the shape of an L";
                        break;
                    case 6:
                        egg.lookDesc = "On her forehead";
                        break;
                    case 7:
                        egg.lookDesc = "Well, the years start coming and they don't stop coming";
                        break;
                    case 8:
                        egg.lookDesc = "Fed to the rules and I hit the ground running";
                        break;
                    case 9:
                        egg.lookDesc = "Didn't make sense not to live for fun";
                        break;
                    case 10:
                        egg.lookDesc = "Your brain gets smart and your head gets dumb";
                        break;
                    case 11:
                        egg.lookDesc = "So much to do so much to see";
                        break;
                    case 12:
                        egg.lookDesc = "So what's wrong with taking the backstreets?";
                        break;
                    case 13:
                        egg.lookDesc = "Ya never know if ya don't go";
                        break;
                    case 14:
                        egg.lookDesc = "Ya never shine if ya don't glow";
                        break;
                    case 15:
                        egg.lookDesc = "Hey now, you're an allstar, get your game on, go play";
                        break;
                    case 16:
                        egg.lookDesc = "Hey now, you're a rockstar, get the show on, get paid";
                        break;
                    case 17:
                        egg.lookDesc = "and all that glitters is gooooold";
                        break;
                    case 18:
                        egg.lookDesc = "only shootin' stars break the mold";
                        break;
                    case 19:
                        egg.lookDesc = "It's a cool place, and they say it gets colder";
                        break;
                    case 20:
                        egg.lookDesc = "You're bundled up now wait 'till you get older";
                        break;
                    case 21:
                        egg.lookDesc = "but the meteor men beg to differ";
                        break;
                    case 22:
                        egg.lookDesc = "judging by the hole in the satelite picture";
                        break;
                    case 23:
                        egg.lookDesc = "The ice we skate is getting pretty thin";
                        break;
                    case 24:
                        egg.lookDesc = "The water's getting warm so you might as well swim";
                        break;
                    case 25:
                        egg.lookDesc = "My world's on fire, how bout yours?";
                        break;
                    case 26:
                        egg.lookDesc = "That's the way I like it and I never get bored.";
                        break;
                    case 27:
                        egg.lookDesc = "Hey now, you're an allstar, get your game on, go play";
                        break;
                    case 28:
                        egg.lookDesc = "Hey now, you're a rockstar, get the show on, get paid";
                        break;
                    case 29:
                        egg.lookDesc = "All that glitters is gold";
                        break;
                    case 30:
                        egg.lookDesc = "Only shooting stars break the mold";
                        break;
                    case 31:
                        egg.lookDesc = "Somebody once asked could I spare some change for gas?";
                        break;
                    case 32:
                        egg.lookDesc = "I need to get myself away from this place";
                        break;
                    case 33:
                        egg.lookDesc = "I said yep, what a concept, I could use a little fuel myself";
                        break;
                    case 34:
                        egg.lookDesc = "And we could all use a little change";
                        break;
                    case 35:
                        egg.lookDesc = "Well, the years start coming and they don't stop coming";
                        break;
                    case 36:
                        egg.lookDesc = "Fed to the rules and I hit the ground running";
                        break;
                    case 37:
                        egg.lookDesc = "Didn't make sense not to live for fun";
                        break;
                    case 38:
                        egg.lookDesc = "your brain gets smart but your head gets dumb";
                        break;
                    case 39:
                        egg.lookDesc = "So much to do, so much to see, so what's wrong with taking the backstreets?";
                        break;
                    case 40:
                        egg.lookDesc = "You never know if you don't go (GO!)";
                        break;
                    case 41:
                        egg.lookDesc = "Hey now, you're an allstar, get your game on, go play";
                        break;
                    case 42:
                        egg.lookDesc = "Hey now, you're a rockstar, get the show on, get paid";
                        break;
                    case 43:
                        egg.lookDesc = "All that glitters is gold";
                        break;
                    case 44:
                        egg.lookDesc = "Only shooting stars break the mold";
                        break;
                    case 45:
                        egg.lookDesc = "And all that glitters is gold";
                        break;
                    case 46:
                        egg.lookDesc = "Only shooting stars break the mold.";
                        break;
                }
                
                livingroom.items[eggcount] = egg;

            }
            activeworld.places[0] = bedroom;
            activeworld.places[1] = hallway;
            activeworld.player.position = 0;
                activeworld.game = true;
                TALib.TAFuncLib.GameBuffer(activeworld.player, Console.ReadLine(), activeworld.places[0], activeworld);

        }
    }
}