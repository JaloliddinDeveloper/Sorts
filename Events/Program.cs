class Program
{
    public delegate void ButtonClickEventHandler(object sender, EventArgs e);

    public event ButtonClickEventHandler ButtonClick;

    static void Main(string[] args)
    {
        Program program = new Program();

        program.ButtonClick += Program_ButtonClick;

        program.OnButtonClick();
    }
    protected virtual void OnButtonClick()
    {
        ButtonClick?.Invoke(this, EventArgs.Empty);
    }

    private static void Program_ButtonClick(object sender, EventArgs e)
    {
        Console.WriteLine("Tugma bosildi!");
    }
}
