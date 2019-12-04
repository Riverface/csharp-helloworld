using System;
namespace TextAdventure.TALib {
    public class Item {
        public string name;
        public int id;
        public Trigger[] trigarray;
        public string lookDesc;

        public Item (string name, int id, string lookDesc) {
            this.name = name;
            this.id = id;
            this.trigarray = new Trigger[255];
            this.lookDesc = lookDesc;
        }
    }
    public class Trigger {
        public string name;
        public int id;
        public string[] sequence;
        public string[] DevDesc;
        public bool reusable;
        public bool usable;
        public int used;

        public Trigger (string name, int id, string[] sequence, string[] DevDesc, int used) {
            this.name = name;
            this.id = id;
            this.sequence = new string[255];
            this.DevDesc = DevDesc;
            this.used = used;
            this.reusable = new bool ();
            this.usable = new bool ();
        }
    }
    public class Player {
        public Object[] inventory;
        public bool[] flags;
        public int position;
        public Player () {
            this.inventory = inventory;
            this.flags = flags;
            this.position = position;
        }
    }
    public class Room {
        public Player you;
        public string name;
        public int id;
        public Trigger[] trigArray;
        public string lookDesc;
        public Item[] items;
        public Exit[] exits;

        public Room (int id, string name, string lookDesc) {
            this.name = name;
            this.id = id;
            this.trigArray = new Trigger[255];
            this.lookDesc = lookDesc;
            this.exits = new Exit[255];
            this.items = new Item[255];
        }
    }
    public class Exit {
        public int goesto;
        public string lookDesc;
        public string name;
        public Exit (string name, string LookDesc, int goesto) {
            this.goesto = goesto;
            this.lookDesc = LookDesc;
            this.name = name;
        }
    }

    public class World {
        public Room[] places = new Room[255];
        public bool game = false;
        public Player player;
        public World () {
            this.player = new Player ();
            this.game = game;
        }
    }
}