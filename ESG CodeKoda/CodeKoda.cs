namespace ESG_CodeKoda
{
    public partial class CodeKoda : Form
    {

        private StringCalculator stringCalulator = new();


        public CodeKoda()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                var result = StringCalculator.Add(txtNumbers.Text);

                txtResult.Text = $"Sum of numbers is {result}";
            }
            catch (Exception ex)
            {
                txtResult.Text = $"StringCalculator errored with {ex.Message}";
            }
        }
    }
}
