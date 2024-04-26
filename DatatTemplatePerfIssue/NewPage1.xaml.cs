using System.Collections.ObjectModel;
using System.Diagnostics;

namespace DatatTemplatePerfIssue;

public partial class NewPage1 : ContentPage
{
    public NewPage1()
    {
        InitializeComponent();
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        var timer = new Stopwatch();
        timer.Start();
        tb1.Load();

        timer.Stop();

        TimeSpan timeTaken = timer.Elapsed;
        string foo = "Time taken: " + timeTaken.ToString(@"m\:ss\.fff");
        Console.Out.WriteLine(foo);
        lb1.Text = foo;
    }

    private void Button_Clicked_1(object sender, EventArgs e)
    {
        var timer = new Stopwatch();
        timer.Start();
        tb2.Load();

        timer.Stop();

        TimeSpan timeTaken = timer.Elapsed;
        string foo = "Time taken: " + timeTaken.ToString(@"m\:ss\.fff");
        Console.Out.WriteLine(foo);
        lb2.Text = foo;
    }

    private void Button_Clicked_2(object sender, EventArgs e)
    {
        var timer = new Stopwatch();
        timer.Start();
        tb3.Load();

        timer.Stop();

        TimeSpan timeTaken = timer.Elapsed;
        string foo = "Time taken: " + timeTaken.ToString(@"m\:ss\.fff");
        Console.Out.WriteLine(foo);
        lb3.Text = foo;
    }
}