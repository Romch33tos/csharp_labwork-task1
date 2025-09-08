using System;

public interface ILineView
{
  event EventHandler CalculateRequested;
  double CoefficientA { get; set; }
  double PointO1X { get; set; }
  double PointO1Y { get; set; }
  double PointO2X { get; set; }
  string Result { set; }
  void ShowError(string message);
  void ClearInputFields();
}
