namespace Bank_Deposit
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            txtInitialDeposit.Text = Properties.Settings.Default.initialDeposit.ToString();
            txtExpectedIncrease.Text = Properties.Settings.Default.expectedIncrease.ToString();
            txtExpectedDeposit.Text = Properties.Settings.Default.expectedDeposit.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void CalcMonthByIncr_Click(object sender, EventArgs e)
        {
            double initialDeposit, expectedIncrease;
            try
            {
                initialDeposit = Logic.ReadFrom(txtInitialDeposit);
                expectedIncrease = Logic.ReadFrom(txtExpectedIncrease);
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message, "ќшибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            catch (ArgumentOutOfRangeException ex)
            {
                MessageBox.Show(ex.Message, "ќшибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Properties.Settings.Default.initialDeposit = initialDeposit;
            Properties.Settings.Default.expectedIncrease = expectedIncrease;
            Properties.Settings.Default.expectedDeposit = double.Parse(txtExpectedDeposit.Text);
            Properties.Settings.Default.Save();

            var declinedMessage = Logic.DeclineBySum(expectedIncrease);

            MessageBox.Show($"¬ этот мес€ц ежемес€чное увеличение превысит {declinedMessage}: " +
                Logic.CalcIncrease(initialDeposit, expectedIncrease));
        }

        private void CalcMonthByDeposit_Click(object sender, EventArgs e)
        {
            double initialDeposit, expectedDeposit;
            try
            {
                initialDeposit = Logic.ReadFrom(txtInitialDeposit);
                expectedDeposit = Logic.ReadFrom(txtExpectedDeposit);
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message, "ќшибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            catch (ArgumentOutOfRangeException ex)
            {
                MessageBox.Show(ex.Message, "ќшибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Properties.Settings.Default.initialDeposit = initialDeposit;
            Properties.Settings.Default.expectedIncrease = double.Parse(txtExpectedIncrease.Text);
            Properties.Settings.Default.expectedDeposit = expectedDeposit;
            Properties.Settings.Default.Save();

            var declinedMessage = Logic.DeclineBySum(expectedDeposit);
            MessageBox.Show($"„ерез это кол-во мес€цев сумма вклада превысит {declinedMessage}: " +
                Logic.CalcDeposit(initialDeposit, expectedDeposit));
        }
    }

    public class Logic
    {
        private static DateOnly initialDate = new DateOnly(2026, 3, 1);

        public static double ReadFrom(TextBox inputField)
        {
            var result = 0d;
            try
            {
                // берЄм только 2 цифры после зап€той
                var input = double.Parse(inputField.Text);
                result = Math.Truncate(input * 100) / 100;
                if (result < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(inputField), "—умма не может быть меньше нул€");
                }
            }
            catch (FormatException e)
            {
                throw;
            }
            catch (ArgumentOutOfRangeException e)
            {
                throw;
            }
            return result;
        }

        public static string CalcIncrease(double initialDeposit, double expectedIncrease)
        {
            var month = 0;
            while (true)
            {
                var currIncrease = Math.Round(initialDeposit * 0.02, 2);
                initialDeposit += currIncrease;
                if (currIncrease > expectedIncrease)
                    return initialDate.AddMonths(month).ToString("MMMM");
                month++;
            }
        }

        public static int CalcDeposit(double initialDeposit, double expectedDeposit)
        {
            if (initialDeposit > expectedDeposit)
                return 0;

            var currDeposit = initialDeposit;
            var month = 1;
            while (true)
            {
                currDeposit = Math.Round(currDeposit * 1.02, 2);
                if (currDeposit > expectedDeposit)
                    return month;
                month++;
            }
        }

        public static string DeclineBySum(double inputSum)
        {
            int rubles = (int)inputSum;
            int cents = (int)(inputSum * 100 % 100);

            var rubleLine = "";
            var centLine = "";
            if (rubles >= 10 && rubles <= 14 || rubles % 10 == 0)
            {
                rubleLine = " рублей";
            }
            else if (rubles % 10 == 1)
            {
                rubleLine = " рубль";
            }
            else if (rubles % 10 >= 2 && rubles % 10 <= 4)
            {
                rubleLine = " рубл€";
            }
            else if (rubles % 10 >= 5 && rubles % 10 <= 9)
            {
                rubleLine = " рублей";
            }

            if (cents >= 10 && cents <= 14 || cents % 10 == 0)
            {
                centLine = " копеек";
            }
            else if (cents % 10 == 1)
            {
                centLine = " копейка";
            }
            else if (cents % 10 >= 2 && cents % 10 <= 4)
            {
                centLine = " копейки";
            }
            else if (cents % 10 >= 5 && cents % 10 <= 9)
            {
                centLine = " копеек";
            }

            var outMsg = "";
            if (rubles != 0 && cents != 0)
                outMsg = rubles + rubleLine + " " + cents + centLine;
            else if (cents != 0)
                outMsg = cents + centLine;
            else
                outMsg = rubles + rubleLine + " ровно";

            return outMsg;
        }
    }
}
