using Expendiary.Data;

namespace Expendiary
{
    public partial class TransactionLog : Form
    {
        Database data = new Database();
        public TransactionLog()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            data.CreateConnection(TransactionGrid);
            data.OpenConnection();
        }
    }
}
