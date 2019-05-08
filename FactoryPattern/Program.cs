using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //Shape Factory take in different inputs and outputs a shape
            //How does the factory figure out what shape to make?
            ShapeFactory s = new ShapeFactory();
            IShape squ = s.GetShape("square");
            squ.Draw();
            IShape cir = s.GetShape("circle");
            cir.Draw();
            IShape tri = s.GetShape("triangle");
            tri.Draw();
            //IShape nan = s.GetShape("");
            //nan.Draw();

            List<IShape> shapes = new List<IShape>();

            for(int i = 0; i<100; i++)
            {
                IShape sha = s.GetShape("square");
                shapes.Add(sha);
                Console.WriteLine(i);
            }

            foreach(IShape shape in shapes)
            {
                shape.Draw();
            }

        }
    }
}
