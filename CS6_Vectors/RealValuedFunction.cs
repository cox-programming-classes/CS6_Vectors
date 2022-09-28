using System.Xml.Linq;
using Csv;

namespace CS6_Vectors;

public class RealValuedFunction
{
    private readonly Func<double, double> _f;

    public RealValuedFunction(Func<double, double> function)
    {
        _f = function;
    }

    public RealValuedFunction ComposeWith(RealValuedFunction inner)
    {
        var g = inner._f; // ease of reading, I'm just labeling this function g(x)
        return new RealValuedFunction(x => _f(g(x)));
    }

    /// <summary>
    /// Evalutate this function at a given point
    /// </summary>
    /// <param name="x">input</param>
    /// <returns></returns>
    public double EvaluateAt(double x) => _f(x);

    public double EstimateSlopeAt(double x, double dX = 0.00001)
    {
        decimal dYp = (decimal)_f(x + dX) - (decimal)_f(x);
        decimal dYn = (decimal)_f(x) - (decimal)_f(x - dX);
        var dY = (dYp + dYn) / 2;
        return (double)(dY / (decimal)dX);
    }

    public RealValuedFunction Derivative => new(x => EstimateSlopeAt(x));
    
    public CSV GenerateGraphSpreadsheet(double xMin, double xMax, double xStep)
    {
        CSV output = new();
        for (double x = xMin; x < xMax; x += xStep)
        {
            output.Add(new Row()
            {
                { "X", $"{x}"},
                { "f(x)", $"{EvaluateAt(x)}"},
                { "f'(x)", $"{EstimateSlopeAt(x)}"},
                { "f''(x)", $"{Derivative.EstimateSlopeAt(x)}"}
            });
        }

        return output;
    }
    
}