using FigureLibrary;
using FigureLibrary.Figures;
using System;
using System.Collections.Generic;

namespace MindBox_Test
{
    public class ConsoleController
    {
        private List<Figure> _figures = null;

        public ConsoleController(List<Figure> figures)
        {
            _figures = figures;
        }

        public void AddCircle(double radius)
        {
            AddFigure(new Circle(radius));
        }

        public void AddTriangle(double sideA, double sideB, double sideC)
        {
            AddFigure(new Triangle(sideA, sideB, sideC));
        }

        public void AddFigure(Figure figure)
        {
            _figures.Insert(_figures.Count, figure);
        }

        public void DeleteFigure(int index)
        {
            if (CheckIndex(index))
            {
                _figures.RemoveAt(index);
            }
        }

        public void DeleteAll()
        {
            _figures.RemoveRange(0, _figures.Count);
        }

        public Figure GetFigure(int index)
        {
            if (CheckIndex(index))
            {
                return _figures[index];
            }
            return null;
        }

        public List<Figure> GetFigures()
        {
            return _figures;
        }

        private bool CheckIndex(int index)
        {
            if (_figures != null)
            {
                if ((index < _figures.Count) && (index >= 0))
                {
                    return true;
                }
            }
            return false;
        }
    }
}

