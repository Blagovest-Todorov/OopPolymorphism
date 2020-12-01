using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.OopPolymorphysm
{
               //Polimorphism, many forms, object of Parent Class can take value of Object of child class
               //Child class inherits the Parent class
    class Shape 
    {
    
    }

    class Rect : Shape
    { 
    
    }
    interface IMovable
    {
        void Move(int dx, int dy);
    }
    class MovableRect : Rect, IMovable 
    {
        public void Move(int dx, int dy)
        {
            Console.WriteLine("Rect Moed");
        }
    }
    class Image 
    {
      
    }
    class MovableImage : Image, IMovable
    {
        public void Move(int dx, int dy)
        {
            Console.WriteLine("Image  moved");
        }
    }

    public class Class1
    {

        static void Print<Т>(IEnumerable<T> items)
        {
            string line = new string('-', 30);
            Console.WriteLine(line);
            foreach (var item in items)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(line);
        }

        static void MoveObject(IMovable obj)
        {
            obj.Move(5, 1); 
        }

        public static void Main(string[] args)
        {

            MoveObject(new MovableImage());
            MoveObject(new MovableRect());
            

            //IMovable[] movables =
            //{
            //    new MovableRect(),
            //    new MovableImage() 
            //};
            //foreach (var movable in movables) 
            //{
            //    movable.Move(5, 6);
            //}
        }
    }
}
