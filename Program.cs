static class Program
{
  [STAThread]
  static void Main()
  {
    Application.EnableVisualStyles();
    Application.SetCompatibleTextRenderingDefault(false);

    var view = new LineForm();
    var presenter = new LinePresenter(view);

    Application.Run(view);
  }
}