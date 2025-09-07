public class LinePresenter
{
  private readonly ILineView _view;
  private readonly LineModel _model;

  public LinePresenter(ILineView view)
  {
    _view = view;
    _model = new LineModel();

    _view.CalculateRequested += OnCalculateRequested;
  }

  private void OnCalculateRequested(object sender, EventArgs e)
  {
    try
    {
      var coefficientA = _view.CoefficientA;
      var pointO1X = _view.PointO1X;
      var pointO1Y = _view.PointO1Y;
      var pointO2X = _view.PointO2X;

      var coefficientB = pointO1Y - coefficientA * pointO1X;

      _model.CoefficientA = coefficientA;
      _model.CoefficientB = coefficientB;
      _model.PointO1 = new PointD(pointO1X, pointO1Y);

      var ordinateO2 = _model.CalculateOrdinate(pointO2X);
      _model.PointO2 = new PointD(pointO2X, ordinateO2);

      _view.Result = $"Ордината точки O2: y = {ordinateO2:F2}";
    }
    catch (FormatException)
    {
      _view.ShowError("Пожалуйста, введите корректные числовые значения.");
    }
    catch (Exception ex)
    {
      _view.ShowError($"Произошла ошибка: {ex.Message}");
    }
  }
}