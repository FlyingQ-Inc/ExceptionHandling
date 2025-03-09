namespace ExceptionHandling
{
    public partial class Form1 : Form
    {
        // Random generator for simulating errors
        private readonly Random randomGenerator = new Random();
        public Form1()
        {
            InitializeComponent();
        }
        // Button click event handler to simulate errors and add them to the log
        private void btnSimulateError_Click(object sender, EventArgs e)
        {
            // Clear existing items for fresh simulation
            lstErrorLog.Items.Clear();

            int errorCount = 0;

            // Loop simulates multiple error occurrences
            while (errorCount < 10)
            {
                try
                {
                    // Randomly generate errors
                    GenerateRandomError();
                }
                catch (DivideByZeroException ex)
                {
                    lstErrorLog.Items.Add($"[{DateTime.Now}] ERROR: Division by zero. {ex.Message}");
                }
                catch (FormatException ex)
                {
                    lstErrorLog.Items.Add($"[{DateTime.Now}] ERROR: Format issue encountered. {ex.Message}");
                }
                catch (Exception ex)
                {
                    // General catch-all for unexpected exceptions
                    lstErrorLog.Items.Add($"[{DateTime.Now}] UNKNOWN ERROR: {ex.Message}");
                }

                errorCount++;

                // Simulate delay for real-time effect
                System.Threading.Thread.Sleep(200);

                // Keep UI responsive
                Application.DoEvents();
            }
        }

        // Method to randomly generate exceptions
        private void GenerateRandomError()
        {
            int choice = randomGenerator.Next(0, 3);

            switch (choice)
            {
                case 0:
                    // Force a DivideByZeroException
                    int zero = 0;
                    int fail = 10 / zero;
                    break;

                case 1:
                    // Force a FormatException
                    int invalidNumber = int.Parse("NotANumber");
                    break;

                default:
                    // No exception, simulates successful operation
                    lstErrorLog.Items.Add($"[{DateTime.Now}] INFO: Operation successful.");
                    break;
            }
        }
    }
}

