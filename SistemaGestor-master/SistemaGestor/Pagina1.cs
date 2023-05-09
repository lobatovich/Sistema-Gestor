using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using Microsoft.Data.SqlClient;
using MODEL;
using BLL;
using System.Windows.Forms;


namespace SistemaGestor
{
    public partial class Pagina : Form
    {
        public Pagina()
        {
            InitializeComponent();

            //this.Enter += Pagina_Enter;
        }

        private void Pagina_Load(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\igor\source\repos\SistemaGestor\DAL\database\Database.mdf;Integrated Security=True;";
            SqlConnection connection = new SqlConnection(connectionString);

            string query = "SELECT * FROM Projetos";
            SqlCommand command = new SqlCommand(query, connection);


            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            dataGridView1.DataSource = dataTable;
        }
        //private void Pagina_Enter(object sender, EventArgs e)
        //{

        //  string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\igor\source\repos\SistemaGestor\DAL\database\Database.mdf;Integrated Security=True;";
        // SqlConnection connection = new SqlConnection(connectionString);
        //
        //  string query = "SELECT * FROM Projetos";
        //   SqlCommand command = new SqlCommand(query, connection);

        //
        //   SqlDataAdapter adapter = new SqlDataAdapter(command);
        //  DataTable dataTable = new DataTable();
        //   adapter.Fill(dataTable);
        //
        //   dataGridView1.DataSource = dataTable;
        //
        //    dataGridView1.Refresh();
        //}


        private void BotaoAddProjeto_Click(object sender, EventArgs e)
        {
            Pagina2 Pagina2 = new Pagina2();
            Pagina2.ShowDialog();
            //this.Close();
        }

        private void BotaoExcluirProjeto_Click(object sender, EventArgs e)
        {
            Pagina3 Pagina3 = new Pagina3();
            Pagina3.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Pagina4 Pagina4 = new Pagina4();
            Pagina4.ShowDialog();
        }

        private void BotaoUpdateLista_Click(object sender, EventArgs e)
        {
            dataGridView1.ClearSelection();
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\igor\source\repos\SistemaGestor\DAL\database\Database.mdf;Integrated Security=True;";
            SqlConnection connection = new SqlConnection(connectionString);

            string query = "SELECT * FROM Projetos";
            SqlCommand command = new SqlCommand(query, connection);


            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            dataGridView1.DataSource = dataTable;

            dataGridView1.Refresh();

        }
    }
}