using System;
using System.Windows.Forms;

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

  public void ClearInputFields()
  {
    textBoxA.Text = string.Empty;
    textBoxO1X.Text = string.Empty;
    textBoxO1Y.Text = string.Empty;
    textBoxO2X.Text = string.Empty;

    textBoxA.Focus();
  }

  private void CalculateButton_Click(object sender, EventArgs e)
  {
    CalculateRequested?.Invoke(this, EventArgs.Empty);
  }

  private void TextBox_KeyPress(object sender, KeyPressEventArgs e)
  {
    var textBox = (TextBox)sender;

    if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        e.KeyChar != '-' && e.KeyChar != '.' && e.KeyChar != ',')
    {
      e.Handled = true;
      return;
    }

    if (e.KeyChar == '-' && textBox.SelectionStart != 0)
    {
      e.Handled = true;
      return;
    }

    if ((e.KeyChar == '.' || e.KeyChar == ',') &&
        (textBox.Text.Contains('.') || textBox.Text.Contains(',')))
    {
      e.Handled = true;
      return;
    }

    if (e.KeyChar == ',')
    {
      e.KeyChar = '.';
    }
  }

  private void TextBox_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode == Keys.Enter)
    {
      e.SuppressKeyPress = true;
      CalculateButton_Click(sender, e);
    }
  }

  private void LineForm_Load(object sender, EventArgs e)
  {
    textBoxA.Focus();
  }

  private void label3_Click(object sender, EventArgs e)
  {
  }
}
