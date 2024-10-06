namespace Calculator
{
    public partial class Calculator : Form
    {
        decimal value = 0;
        decimal userInput;
        decimal previousValue;

        string operation = "";
        bool operationPressed = false;

        private void btn1_Click(object sender, EventArgs e)
        {
            if ((screen.Text == "0") || (operationPressed))
                screen.Clear(); //eðer ilk sayý giriliyorsa ve iþlem butonuna basýlmýþsa ekraný temizler

            operationPressed = false;
            Button btn1 = (Button)sender;
            screen.Text += btn1.Text;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if ((screen.Text == "0") || (operationPressed))
                screen.Clear(); //eðer ilk sayý giriliyorsa ve iþlem butonuna basýlmýþsa ekraný temizler

            operationPressed = false;
            Button btn2 = (Button)sender;
            screen.Text += btn2.Text;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if ((screen.Text == "0") || (operationPressed))
                screen.Clear(); //eðer ilk sayý giriliyorsa ve iþlem butonuna basýlmýþsa ekraný temizler

            operationPressed = false;
            Button btn3 = (Button)sender;
            screen.Text += btn3.Text;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if ((screen.Text == "0") || (operationPressed))
                screen.Clear(); //eðer ilk sayý giriliyorsa ve iþlem butonuna basýlmýþsa ekraný temizler

            operationPressed = false;
            Button btn4 = (Button)sender;
            screen.Text += btn4.Text;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if ((screen.Text == "0") || (operationPressed))
                screen.Clear(); //eðer ilk sayý giriliyorsa ve iþlem butonuna basýlmýþsa ekraný temizler

            operationPressed = false;
            Button btn5 = (Button)sender;
            screen.Text += btn5.Text;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if ((screen.Text == "0") || (operationPressed))
                screen.Clear(); //eðer ilk sayý giriliyorsa ve iþlem butonuna basýlmýþsa ekraný temizler

            operationPressed = false;
            Button btn6 = (Button)sender;
            screen.Text += btn6.Text;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if ((screen.Text == "0") || (operationPressed))
                screen.Clear(); //eðer ilk sayý giriliyorsa ve iþlem butonuna basýlmýþsa ekraný temizler

            operationPressed = false;
            Button btn7 = (Button)sender;
            screen.Text += btn7.Text;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if ((screen.Text == "0") || (operationPressed))
                screen.Clear(); //eðer ilk sayý giriliyorsa ve iþlem butonuna basýlmýþsa ekraný temizler

            operationPressed = false;
            Button btn8 = (Button)sender;
            screen.Text += btn8.Text;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if ((screen.Text == "0") || (operationPressed))
                screen.Clear(); //eðer ilk sayý giriliyorsa ve iþlem butonuna basýlmýþsa ekraný temizler

            operationPressed = false;
            Button btn9 = (Button)sender;
            screen.Text += btn9.Text;
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if ((screen.Text == "0") || (operationPressed))
                screen.Clear(); //eðer ilk sayý giriliyorsa ve iþlem butonuna basýlmýþsa ekraný temizler

            operationPressed = false;
            Button btn0 = (Button)sender;
            screen.Text += btn0.Text;
        }


        private void btnMultiply_Click(object sender, EventArgs e)
        {
            Button multiply = (Button)sender;
            operation = multiply.Text;
            value = Decimal.Parse(screen.Text);
            operationPressed = true;
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            Button divide = (Button)sender;
            operation = divide.Text;
            value = Decimal.Parse(screen.Text);
            operationPressed = true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Button add = (Button)sender;
            operation = add.Text;
            value = Decimal.Parse(screen.Text);
            operationPressed = true;
        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            Button subtract = (Button)sender;
            operation = subtract.Text;
            value = Decimal.Parse(screen.Text);
            operationPressed = true;
        }

        private void btnDot_Click(object sender, EventArgs e)
        {
            if (!screen.Text.Contains(","))
                screen.Text += ",";
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            decimal result = 0;
            
            switch (operation)
            {
                case "+":
                    result = value + Decimal.Parse(screen.Text);
                    break;
                case "-":
                    result = value - Decimal.Parse(screen.Text);
                    break;
                case "*":
                    result = value * Decimal.Parse(screen.Text);
                    break;
                case "/":
                    result = value / Decimal.Parse(screen.Text);
                    break;
            }
            operationPressed = false;
            screen.Text = result.ToString();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            screen.Text = "";
            value = 0;
        }

        public Calculator()
        {
            InitializeComponent();
        }

    }
}