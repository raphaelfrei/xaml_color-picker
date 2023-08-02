namespace ColorPicker;

public partial class MainPage : ContentPage{

    public MainPage(){
        InitializeComponent();

    }

    void ChangeColor() {
        Color color = new Color(Convert.ToInt32(SldRed.Value), Convert.ToInt32(SldGreen.Value), Convert.ToInt32(SldBlue.Value));
        ContPage.BackgroundColor = color;

        BtnCopy.Text = $"{color.ToHex()}";
    }

    void SldRed_ValueChanged(System.Object sender, Microsoft.Maui.Controls.ValueChangedEventArgs e){
        LblRed.Text = Convert.ToInt32(SldRed.Value).ToString();
        ChangeColor();
    }

    void SldGreen_ValueChanged(System.Object sender, Microsoft.Maui.Controls.ValueChangedEventArgs e){
        LblGreen.Text = Convert.ToInt32(SldGreen.Value).ToString();
        ChangeColor();
    }

    void SldBlue_ValueChanged(System.Object sender, Microsoft.Maui.Controls.ValueChangedEventArgs e){
        LblBlue.Text = Convert.ToInt32(SldBlue.Value).ToString();
        ChangeColor();
    }

    void BtnCopy_Clicked(System.Object sender, System.EventArgs e){

        Clipboard.SetTextAsync(BtnCopy.Text);

        DisplayAlert("Copy", "Color copied into clipboard!", "OK");

    }
}