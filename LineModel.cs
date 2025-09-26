public class LineModel
{
  public double CoefficientA { get; set; }
  public double CoefficientB { get; set; }
  public PointD PointO1 { get; set; }
  public PointD PointO2 { get; set; }

  public double CalculateOrdinate(double x)
  {
    return CoefficientA * x + CoefficientB;
  }
}

public class PointD
{
  public double X { get; set; }
  public double Y { get; set; }

  public PointD(double x, double y)
  {
    X = x;
    Y = y;
  }
}