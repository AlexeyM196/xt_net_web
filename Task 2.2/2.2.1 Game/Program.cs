using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._2._1_Game
{
    
    public class GameObject
    {
        public int X { get; set; }
        public int Y { get; set; }
        public char Sprite { get; private set; }
        static public ConsoleColor Color { get; private set; }
        public GameObject(int x, int y, char sprite, ConsoleColor color)
        {
            Sprite = sprite;
            Color = color;
        }
        
    }
    public class Player : GameObject
    {
        public int Health { get; set; }
        public int Energy { get; set; }

        public Player(int x, int y, char sprite, ConsoleColor color, int health, int energy): base(x, y, sprite, color)
        {
            Health = health;
            Energy = energy;
        }
        public  void Draw()
        {
            Console.ForegroundColor = Color;
            Console.SetCursorPosition(X, Y);
            Console.Write(Sprite);
        }
        public void Remove()
        {
            Console.SetCursorPosition(X, Y);
            Console.Write(" ");
        }
    }
    public class ItemEnergy : GameObject
    {
        public int Energy { get; set; }
        public ItemEnergy(int x, int y, char sprite, ConsoleColor color): base(x, y, sprite, color)
        {
            Energy = 20;
        }
    }
    public class ItemHealth : GameObject
    {
        public int Health { get; set; }
        public ItemHealth(int x, int y, char sprite, ConsoleColor color) : base(x, y, sprite, color)
        {
            Health = 2;
        }
    }
    public class Wall : GameObject
    {
        public Wall(int x, int y, char sprite, ConsoleColor color) : base(x, y, sprite, color)
        {

        }
    }
    public class ActionEnemy : GameObject
    {
        public int Damage { get; set; }
        public ActionEnemy(int x, int y, char sprite, ConsoleColor color, int damage) : base(x, y, sprite, color)
        {
            Damage = damage;
        }
    }
    public class StaticEnemy : GameObject
    {
        public int Damage { get; set; }
        public StaticEnemy(int x, int y, char sprite, ConsoleColor color, int damage) : base(x, y, sprite, color)
        {
            Damage = damage;
        }
    }
    class Program
    {
        
        static Player player = new Player(1, 1, 'D', ConsoleColor.Blue, 5, 0);
        static void Main(string[] args)
        {

            Console.CursorVisible = false;
            
            while(true)
            {
                player.Draw();
                switch (Console.ReadKey(true).Key)
                {
                    case ConsoleKey.A:
                        player.Remove();
                        player.X--;
                        break;
                    case ConsoleKey.W:
                        player.Remove();
                        player.Y--;
                        break;
                    case ConsoleKey.D:
                        player.Remove();
                        player.X++;
                        break;
                    case ConsoleKey.S:
                        player.Remove();
                        player.Y++;
                        break;
                }
            }
        }
    }
}
