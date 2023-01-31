using FigureLibrary;
using FigureLibrary.Figures;
using Spectre.Console;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace MindBox_Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConsoleController controller = new(new List<Figure>());

            while (true)
            {
                var action = AnsiConsole.Prompt(new SelectionPrompt<string>()
                    .Title("What to do?")
                    .AddChoices("Add", "Delete", "Get Square", "Rectification Check", "Show All"));
                switch (action)
                {
                    case "Add":
                        var add = AnsiConsole.Prompt(new SelectionPrompt<string>()
                            .Title("What to add?")
                            .AddChoices("Circle", "Triangle"));
                        switch (add)
                        {
                            case "Circle":
                                controller.AddCircle(
                                    AnsiConsole.Prompt(new TextPrompt<double>("Radius:")));
                                break;
                            case "Triangle":
                                controller.AddTriangle(
                                    AnsiConsole.Prompt(new TextPrompt<double>("Side A:")),
                                    AnsiConsole.Prompt(new TextPrompt<double>("Side B:")),
                                    AnsiConsole.Prompt(new TextPrompt<double>("Side C:")));
                                break;
                        };
                        break;
                    case "Delete":
                        var delete = AnsiConsole.Prompt(new SelectionPrompt<string>()
                            .Title("What to delete?")
                            .AddChoices("Delete Item", "Delete All"));
                        switch (delete)
                        {
                            case "Delete Item":
                                controller.DeleteFigure(AnsiConsole.Prompt(new TextPrompt<int>("Delete Index :")));
                                break;
                            case "Delete All":
                                controller.DeleteAll();
                                break;
                        };
                        break;
                    case "Get Square":
                        int index = AnsiConsole.Prompt(new TextPrompt<int>(" Index :"));
                        Figure figure = controller.GetFigure(index);
                        if (figure != null)
                        {
                            AnsiConsole.Write(figure.GetSquare());
                        }
                        else
                        {
                            AnsiConsole.Write("Figure not found");
                        }
                        Console.ReadKey(true);
                        break;
                    case "Rectification Check":
                        int indexCheck = AnsiConsole.Prompt(new TextPrompt<int>(" Index :"));
                        Figure figureCheck = controller.GetFigure(indexCheck);
                        if (figureCheck != null)
                        {
                            if (figureCheck is Triangle triangle)
                            {
                                AnsiConsole.Write(((Triangle)figureCheck).RectificationCheck());
                            }
                            else
                            {
                                AnsiConsole.Write("Is Not Triangle");
                            }
                        }
                        else
                        {
                            AnsiConsole.Write("Figure not found");
                        }
                        Console.ReadKey(true);
                        break;
                    case "Show All":
                        foreach(Figure fig in controller.GetFigures())
                        {
                            AnsiConsole.Write(fig.GetType().Name + ": " +  fig.ToString() + "\n");
                        }
                        Console.ReadKey(true);
                        break;
                };
                AnsiConsole.Clear();
            }
        }
    }
}

