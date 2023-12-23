using System;
using Avalonia.Controls;
using Avalonia.Input;
using Avalonia.Interactivity;

namespace CalculatorAvalonia;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void Calculate(string sign)
    {
        if (double.TryParse(TxtNo1.Text, out double n1) && double.TryParse(TxtNo2.Text, out double n2))
        {
            double ans;
            n1 = Convert.ToDouble(TxtNo1.Text);
            n2 = Convert.ToDouble(TxtNo2.Text);
            if (sign == "+")
            {
                ans = n1 + n2;
            }
            else if (sign == "-")
            {
                ans = n1 - n2;
            }
            else if (sign == "*")
            {
                ans = n1 * n2;
            }
            else
            {
                ans = n1 / n2;
            }

            LblNo1.Text = "Answer is : " + String.Format("{0:0.00}", ans);
            TxtNo1.Clear();
            TxtNo2.Clear();
            
        }
        else
        {
            LblNo1.Text = "The given numbers are not valid";
        }
    }

    private void BtnAdd_OnClick(object? sender, RoutedEventArgs e)
    {
        Calculate("+");
    }

    private void BtnSub_OnClick(object? sender, RoutedEventArgs e)
    {
        Calculate("-");
    }

    private void BtnMul_OnClick(object? sender, RoutedEventArgs e)
    {
        Calculate("*");
    }

    private void BtnDiv_OnClick(object? sender, RoutedEventArgs e)
    {
        Calculate("/");
    }

    private void TxtNo1_OnKeyDown(object? sender, KeyEventArgs e)
    {
        CheckNumber(sender, e);
    }
    
    private void TxtNo2_OnKeyDown(object? sender, KeyEventArgs e)
    {
        CheckNumber(sender, e);
    }

    private void CheckNumber(object? sender, KeyEventArgs e)
    {
        if (e.KeySymbol is not null && !char.IsDigit(e.KeySymbol, 0) && e.Key != Key.OemPeriod)
        {
            e.Handled = true;
        }

        if (e.Key == Key.OemPeriod && ((sender as TextBox)?.Text?.Contains('.') ?? false))
        {
            e.Handled = true;
        }
    }

}