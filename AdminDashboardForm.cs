using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;

namespace CafeShopManagementSystem
{
    public partial class AdminDashboardForm : UserControl
    {
        static string conn = ConfigurationManager.ConnectionStrings["myDatabaseConnection"].ConnectionString;

        public AdminDashboardForm()
        {
            InitializeComponent();
            displayTotalCashier();
            displayTotalCustomers();
            displayTotalIncome();
            displayTodaysIncome();
        }

        public void refreshData()
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)refreshData);
                return;
            }
            displayTotalCashier();
            displayTotalCustomers();
            displayTotalIncome();
            displayTodaysIncome();
        }

        public void displayTotalCashier()
        {
            string query = "SELECT COUNT(id) FROM users WHERE role = @role AND status = @status";

            try
            {
                using (SqlConnection connect = new SqlConnection(conn))
                {
                    connect.Open();

                    using (SqlCommand cmd = new SqlCommand(query, connect))
                    {
                        cmd.Parameters.AddWithValue("@role", "Cashier");
                        cmd.Parameters.AddWithValue("@status", "Active");

                        int count = (int)cmd.ExecuteScalar();
                        dashboard_TC.Text = count.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed connection: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void displayTotalCustomers()
        {
            string query = "SELECT COUNT(id) FROM customers";

            try
            {
                using (SqlConnection connect = new SqlConnection(conn))
                {
                    connect.Open();

                    using (SqlCommand cmd = new SqlCommand(query, connect))
                    {
                        int count = (int)cmd.ExecuteScalar();
                        dashboard_TCust.Text = count.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed connection: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void displayTodaysIncome()
        {
            string query = "SELECT SUM(total_price) FROM customers WHERE DATE = @date";

            try
            {
                using (SqlConnection connect = new SqlConnection(conn))
                {
                    connect.Open();

                    using (SqlCommand cmd = new SqlCommand(query, connect))
                    {
                        DateTime today = DateTime.Today;
                        string getToday = today.ToString("yyyy-MM-dd");
                        cmd.Parameters.AddWithValue("@date", getToday);

                        object result = cmd.ExecuteScalar();

                        if (result != DBNull.Value)
                        {
                            float count = Convert.ToSingle(result);
                            dashboard_TI.Text = "$" + count.ToString("0.00");
                        }
                        else
                        {
                            dashboard_TI.Text = "$0.00";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed connection: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void displayTotalIncome()
        {
            string query = "SELECT SUM(total_price) FROM customers";

            try
            {
                using (SqlConnection connect = new SqlConnection(conn))
                {
                    connect.Open();

                    using (SqlCommand cmd = new SqlCommand(query, connect))
                    {
                        object result = cmd.ExecuteScalar();

                        if (result != DBNull.Value)
                        {
                            float count = Convert.ToSingle(result);
                            dashboard_TIn.Text = "$" + count.ToString("0.00");
                        }
                        else
                        {
                            dashboard_TIn.Text = "$0.00";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed connection: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            // Custom paint logic can go here if required.
        }
    }
}
