namespace Calculator1;

public partial class CalcPage1 : ContentPage
{
    private int num1 = 0;
    private int num2 = 0;
    private string oprtr = "";
    private int total = 0;

    public CalcPage1()
	{
		InitializeComponent();
	}

	private void Button_Clicked_num(object sender, EventArgs e)
	{
		Button but = (Button)sender;
		int buttonNumber = int.Parse(but.Text);
		if(oprtr == "")
		{
			num1 = num1*10 + buttonNumber;
		} else
		{
            num2 = num2*10 + buttonNumber;
        }
		lblResult.Text += but.Text;

    }
	private void Button_Clicked_operator(object sender, EventArgs e)
	{
        Button but = (Button)sender;
        oprtr = but.Text;
        lblResult.Text += " " + but.Text + " ";
    }
    private void Button_Clicked_clear(object sender, EventArgs e)
    {

        lblResult.Text = string.Empty;
        num1 = 0;
        num2 = 0;
        oprtr = "";
        total = 0;

    }
    private void Button_Clicked_equal(object sender, EventArgs e)
    {
        if (oprtr == "+")
        {
            total = num1 + num2; ;
        }
        else if (oprtr == "-")
        {
            total = num1 - num2; ;
        }
        else if (oprtr == "*")
        {
            total = num1 * num2; ;
        }
        else if (oprtr == "/")
        {
            total = num1 / num2; ;
        }
        else
        {
            total = num1;
        }
            lblResult.Text += " = " + total;
    }
}