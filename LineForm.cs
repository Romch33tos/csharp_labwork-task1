public partial class LineForm : Form, ILineView
{
  public event EventHandler CalculateRequested;

  public LineForm()
  {
    InitializeComponent();
  }

  public double CoefficientA
  {
    get
    {
      if (double.TryParse(textBoxA.Text, out double result))
        return result;
      throw new FormatException("Некорректное значение коэффициента a");
    }
    set => textBoxA.Text = value.ToString();
  }

  public double PointO1X
  {
    get
    {
      if (double.TryParse(textBoxO1X.Text, out double result))
        return result;
      throw new FormatException("Некорректное значение координаты x точки O1");
    }
    set => textBoxO1X.Text = value.ToString();
  }

  public double PointO1Y
  {
    get
    {
      if (double.TryParse(textBoxO1Y.Text, out double result))
        return result;
      throw new FormatException("Некорректное значение координаты y точки O1");
    }
    set => textBoxO1Y.Text = value.ToString();
  }

  public double PointO2X
  {
    get
    {
      if (double.TryParse(textBoxO2X.Text, out double result))
        return result;
      throw new FormatException("Некорректное значение координаты x точки O2");
    }
    set => textBoxO2X.Text = value.ToString();
  }

  public string Result
  {
    set => labelResult.Text = value;
  }

  public void ShowError(string message)
  {
    MessageBox.Show(message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
  }

  private void CalculateButton_Click(object sender, EventArgs e)
  {
    CalculateRequested?.Invoke(this, EventArgs.Empty);
  }

  private void LineForm_Load(object sender, EventArgs e)
  {

  }

  private void label3_Click(object sender, EventArgs e)
  {

  }
}