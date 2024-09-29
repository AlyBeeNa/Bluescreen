using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Analysistest
{
    public partial class menufrm : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-VOINQ58;Initial Catalog=anomalies;Integrated Security=True");

        public menufrm()
        {
            InitializeComponent();
            overviewpnl.Visible = false;    
            emotionspnl.Visible = false;  
            Trendspnl.Visible = false;
            queriespnl.Visible = false;
        }
        void FillChartqueries()
        {
            try
            {
                DataTable dt = new DataTable();
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT problem, frqncy FROM queries WHERE frqncy<80 ", conn);

                da.Fill(dt);
                querieschrt.DataSource = dt;



                querieschrt.Series["queries"].XValueMember = "problem";
                querieschrt.Series["queries"].YValueMembers = "frqncy";
                querieschrt.Titles.Add("Queries problems");


                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT frqncy FROM queries where problem = 'TotalQueries'";
                Object temp = cmd.ExecuteScalar();
                label7.Text = temp.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                conn.Close();
            }
        }

        void FillChartOverview()
        {
            try
            {
                DataTable dt = new DataTable();
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT response, nr FROM General_analysis WHERE nr<100", conn);

                da.Fill(dt);
                chart1.DataSource = dt;



                chart1.Series["chat_session"].XValueMember = "response";
                chart1.Series["chat_session"].YValueMembers = "nr";
                chart1.Titles.Add("Frequency");


                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT nr FROM General_analysis where response = 'TotalResponses'";
                Object temp = cmd.ExecuteScalar();
                label2.Text = temp.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                conn.Close();
            }
        }


        void FillChartEmotional()
        {
            try
            {
                DataTable dt = new DataTable();
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT prcntg, id_r FROM Rating order by prcntg asc", conn);

                da.Fill(dt);
                chart2.DataSource = dt;



                chart2.Series["rating"].XValueMember = "prcntg";
                chart2.Series["rating"].YValueMembers = "prcntg";
                chart2.Titles.Add("User experience rating");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                conn.Close();
            }
        }


        void FillChartTrends()
        {
            try
            {
                DataTable dt = new DataTable();
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT prcntg, id_r FROM Rating order by prcntg asc", conn);

                da.Fill(dt);
                chart2.DataSource = dt;



                chart2.Series["rating"].XValueMember = "prcntg";
                chart2.Series["rating"].YValueMembers = "prcntg";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                conn.Close();
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'anomaliesDataSet.topic' table. You can move, or remove it, as needed.
            this.topicTableAdapter.Fill(this.anomaliesDataSet.topic);
            FillChartOverview();
            FillChartEmotional();
            FillChartTrends();
            FillChartqueries();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            queriespnl.Visible = true;
            emotionspnl.Hide();
            Trendspnl.Hide();
            overviewpnl.Hide(); 
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void overviewbtn_Click(object sender, EventArgs e)
        {
            overviewpnl.Visible = true;
            emotionspnl.Hide();
            Trendspnl.Hide();
            queriespnl.Hide();

        }

        private void emotionbtn_Click(object sender, EventArgs e)
        {
            emotionspnl.Visible = true; 
            overviewpnl.Hide();
            Trendspnl.Hide();
            queriespnl.Hide();

        }

        private void topicbtn_Click(object sender, EventArgs e)
        {
            Trendspnl.Visible = true;
            overviewpnl.Hide();
            emotionspnl.Hide();
            queriespnl.Hide();

        }
    }
}
