using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
        public class ShapeFactory
        {
            //use getShape method to get object of type shape
            //build a square circle 
            //Why does getShape return an IShape? Why a square or circle?
            public IShape GetShape(string ShapeType)
            {
            //What happens if we get a shape such as a trapazoid?
            if (ShapeType == "square")
            {
                return new Square();
            }
            else if (ShapeType == "circle")
            {
                return new Circle();
            }
            else if (ShapeType == "triangle")
            {
                return new Triangle();
            }

            else
            {
                return null;
            }

            }
        }
    }
