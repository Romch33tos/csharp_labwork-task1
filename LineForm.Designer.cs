partial class LineForm
{
  private System.ComponentModel.IContainer components = null;

  protected override void Dispose(bool disposing)
  {
    if (disposing && (components != null))
    {
      components.Dispose();
    }
    base.Dispose(disposing);
  }

  #region Windows Form Designer generated code

  private void InitializeComponent()
  {
    label1 = new Label();
    label2 = new Label();
    textBoxA = new TextBox();
    textBoxO1Y = new TextBox();
    textBoxO1X = new TextBox();
    calculateButton = new Button();
    label3 = new Label();
    textBoxO2X = new TextBox();
    labelResult = new Label();
    SuspendLayout();
    // 
    // label1
    // 
    label1.AutoSize = true;
    label1.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
    label1.ForeColor = Color.Black;
    label1.Location = new Point(20, 99);
    label1.Name = "label1";
    label1.Size = new Size(291, 18);
    label1.TabIndex = 8;
    label1.Text = "Введите значение коэффициента «a»: ";
    // 
    // label2
    // 
    label2.AutoSize = true;
    label2.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
    label2.ForeColor = Color.Black;
    label2.Location = new Point(20, 135);
    label2.Name = "label2";
    label2.Size = new Size(285, 18);
    label2.TabIndex = 7;
    label2.Text = "Введите координаты известной точки:";
    // 
    // textBoxA
    // 
    textBoxA.BackColor = Color.White;
    textBoxA.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
    textBoxA.ForeColor = Color.Black;
    textBoxA.Location = new Point(350, 96);
    textBoxA.Name = "textBoxA";
    textBoxA.PlaceholderText = "а";
    textBoxA.Size = new Size(70, 26);
    textBoxA.TabIndex = 0;
    textBoxA.TextAlign = HorizontalAlignment.Center;
    textBoxA.KeyDown += TextBox_KeyDown;
    textBoxA.KeyPress += TextBox_KeyPress;
    // 
    // textBoxO1Y
    // 
    textBoxO1Y.BackColor = Color.White;
    textBoxO1Y.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
    textBoxO1Y.ForeColor = Color.Black;
    textBoxO1Y.Location = new Point(388, 132);
    textBoxO1Y.Name = "textBoxO1Y";
    textBoxO1Y.PlaceholderText = "y1";
    textBoxO1Y.Size = new Size(32, 26);
    textBoxO1Y.TabIndex = 2;
    textBoxO1Y.TextAlign = HorizontalAlignment.Center;
    textBoxO1Y.KeyDown += TextBox_KeyDown;
    textBoxO1Y.KeyPress += TextBox_KeyPress;
    // 
    // textBoxO1X
    // 
    textBoxO1X.BackColor = Color.White;
    textBoxO1X.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
    textBoxO1X.ForeColor = Color.Black;
    textBoxO1X.Location = new Point(350, 132);
    textBoxO1X.Name = "textBoxO1X";
    textBoxO1X.PlaceholderText = "х1";
    textBoxO1X.Size = new Size(32, 26);
    textBoxO1X.TabIndex = 1;
    textBoxO1X.TextAlign = HorizontalAlignment.Center;
    textBoxO1X.KeyDown += TextBox_KeyDown;
    textBoxO1X.KeyPress += TextBox_KeyPress;
    // 
    // calculateButton
    // 
    calculateButton.BackColor = Color.Transparent;
    calculateButton.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
    calculateButton.Location = new Point(145, 209);
    calculateButton.Name = "calculateButton";
    calculateButton.Size = new Size(160, 30);
    calculateButton.TabIndex = 4;
    calculateButton.Text = "Рассчитать";
    calculateButton.UseVisualStyleBackColor = false;
    calculateButton.Click += CalculateButton_Click;
    // 
    // label3
    // 
    label3.AutoSize = true;
    label3.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
    label3.ForeColor = Color.Black;
    label3.Location = new Point(20, 169);
    label3.Name = "label3";
    label3.Size = new Size(234, 18);
    label3.TabIndex = 2;
    label3.Text = "Введите абсциссу новой точки:";
    label3.Click += label3_Click;
    // 
    // textBoxO2X
    // 
    textBoxO2X.BackColor = Color.White;
    textBoxO2X.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
    textBoxO2X.ForeColor = Color.Black;
    textBoxO2X.Location = new Point(350, 169);
    textBoxO2X.Name = "textBoxO2X";
    textBoxO2X.PlaceholderText = "x2";
    textBoxO2X.Size = new Size(70, 26);
    textBoxO2X.TabIndex = 3;
    textBoxO2X.TextAlign = HorizontalAlignment.Center;
    textBoxO2X.KeyDown += TextBox_KeyDown;
    textBoxO2X.KeyPress += TextBox_KeyPress;
    // 
    // labelResult
    // 
    labelResult.BackColor = Color.White;
    labelResult.BorderStyle = BorderStyle.FixedSingle;
    labelResult.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
    labelResult.ForeColor = Color.Black;
    labelResult.Location = new Point(20, 9);
    labelResult.Name = "labelResult";
    labelResult.Padding = new Padding(5);
    labelResult.Size = new Size(400, 73);
    labelResult.TabIndex = 0;
    // 
    // LineForm
    // 
    AutoScaleDimensions = new SizeF(7F, 15F);
    AutoScaleMode = AutoScaleMode.Font;
    BackColor = Color.WhiteSmoke;
    ClientSize = new Size(437, 251);
    Controls.Add(labelResult);
    Controls.Add(textBoxO2X);
    Controls.Add(label3);
    Controls.Add(calculateButton);
    Controls.Add(textBoxO1X);
    Controls.Add(textBoxO1Y);
    Controls.Add(textBoxA);
    Controls.Add(label2);
    Controls.Add(label1);
    FormBorderStyle = FormBorderStyle.FixedDialog;
    MaximizeBox = false;
    Name = "LineForm";
    StartPosition = FormStartPosition.CenterScreen;
    Text = "Расчет ординаты точки на прямой";
    Load += LineForm_Load;
    ResumeLayout(false);
    PerformLayout();
  }

  #endregion

  private Label label1;
  private Label label2;
  private TextBox textBoxA;
  private TextBox textBoxO1Y;
  private TextBox textBoxO1X;
  private Button calculateButton;
  private Label label3;
  private TextBox textBoxO2X;
  private Label labelResult;
}
