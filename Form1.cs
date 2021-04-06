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

namespace PT_W_DB_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Random rand = new Random();      
        int  count_db_pipes, count_dgv_pipes = 0;     
        public string pipeLen, jobno, coilno, fpipno, data;
        public int scrapColIndex = 7;
        public int cutLength, sumScrapLen, countGoodPipes, countScrapPipes, countDropPipes = 0;

        public string Connect_to_DB() 
        {
            SqlConnection sqlCon = new SqlConnection(@"Data Source=localhost\sqlexpress; Initial Catalog=Pipes; Integrated Security=true");
            DataTable dtbl = new DataTable();

            SqlDataAdapter sqlda = new SqlDataAdapter("Select * From tblPipe", sqlCon);
            sqlda.Fill(dtbl);
            using (SqlConnection connection = new SqlConnection(sqlCon.ConnectionString))
            {
                connection.Open();             
                foreach (DataRow row in dtbl.Rows)
                {
                    pipeLen = row["PipeLength"].ToString() + "," + pipeLen;
                    count_db_pipes++;
                }

                pipeLen = count_db_pipes.ToString()+ "," + pipeLen;
                return pipeLen;
            }          
        }

        public void Upload_to_DB() 
        {
            int lpipno = Int16.Parse(lblCurrentPipeNo.Text);
            string spipno = getPipeNum(lpipno.ToString());

            SqlConnection con = new SqlConnection(@"Data Source=localhost\sqlexpress; Initial Catalog=Pipes; Integrated Security=true");
            con.Open();
            SqlCommand cmd = new SqlCommand("sp_insert", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@JobNumber", jobno);
            cmd.Parameters.AddWithValue("@CoilNumber", coilno);
            cmd.Parameters.AddWithValue("@LastPipeNumber", spipno);
            cmd.Parameters.AddWithValue("@TotalGoodPipes", countGoodPipes);
            cmd.Parameters.AddWithValue("@TotalScrapLength", sumScrapLen);

            con.Close();
        }

        public string getPipeNum(string pNum) 
        {           
            int numLen = pNum.Length;
            string pipestr = "";
            string zeroes = "";

            switch (numLen)
            {
                case 1:
                    zeroes = "0000";
                    break;
                case 2:
                    zeroes = "000";
                    break;
                case 3:
                    zeroes = "00";
                    break;
                case 4:
                    zeroes = "0";
                    break;
            }
            pipestr = "EX" + zeroes + pNum + '\n' + '\n';
            return pipestr;
        }

        private void btnNextPipe_Click(object sender, EventArgs e)
        {
            int npipno = Int16.Parse(lblCurrentPipeNo.Text) + 1;
            lblCurrentPipeNo.Text = npipno.ToString();
            string gnpipno = getPipeNum(npipno.ToString());
            string pipeLens = Connect_to_DB();
            string[] splitLens = pipeLens.Split(",");

            string tempo = jobno + "," + coilno + "," + gnpipno + "," + splitLens[count_dgv_pipes+1];
            string[] splitTempo = tempo.Split(",");
            dgvPipes.Rows.Add(splitTempo);
            count_dgv_pipes++;

            DataGridViewCellEventArgs c = new DataGridViewCellEventArgs(4, count_dgv_pipes-1);          
            if (cutLength == Int16.Parse(splitLens[count_dgv_pipes]))
            {
                dgvPipes[c.ColumnIndex, c.RowIndex].Value = true;
                countGoodPipes++;
            }          
            lblCount.Text = count_dgv_pipes.ToString();
        }


        private void btnEndOfCoil_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvPipes.Rows)
            {
                if ((string)row.Cells[scrapColIndex].Value == null)
                {
                    row.Cells[scrapColIndex].Value = "0";
                    data = (string)row.Cells[scrapColIndex].Value + "," + data;
                }
                else
                {
                    data = (string)row.Cells[scrapColIndex].Value + "," + data;
                }               
            }
            string[] splitData = data.Split(",");
            foreach (string lop in splitData) { countScrapPipes++; }

            for (int loop = 0; loop < countScrapPipes - 1 ; loop++)
            {
                sumScrapLen = sumScrapLen + Int16.Parse(splitData[loop]);
            }

            lblTotalScrap.Visible = true;
            lblTotalGoodPipes.Visible = true;
            lblTotalScrap.Text = sumScrapLen.ToString() + "m";
            lblTotalGoodPipes.Text = countGoodPipes.ToString();

            Upload_to_DB();           
        }


        private void dgvPipes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4) // if good is selected
            {
                dgvPipes[e.ColumnIndex + 3, e.RowIndex].Value = "";
                dgvPipes[e.ColumnIndex + 1, e.RowIndex].Value = false;
                dgvPipes[e.ColumnIndex + 2, e.RowIndex].Value = false;
                countGoodPipes++;
            }
            if (e.ColumnIndex == 5)  /// if scrap is selected
            {
                string mlen = dgvPipes.Rows[e.RowIndex].Cells[3].Value.ToString();
                dgvPipes[e.ColumnIndex + 2, e.RowIndex].Value = mlen;
                dgvPipes[e.ColumnIndex - 1, e.RowIndex].Value = false;
                dgvPipes[e.ColumnIndex + 1, e.RowIndex].Value = false;
            }
            if (e.ColumnIndex == 6) /// if dropout is selected 
            {
                string mlen = dgvPipes.Rows[e.RowIndex].Cells[3].Value.ToString();
                string dlenS = dgvPipes.Rows[e.RowIndex].Cells[8].Value.ToString();
                countDropPipes++;

                if (Int16.Parse(dlenS) > Int16.Parse(mlen)) { MessageBox.Show("Invalid Dropout Length"); }
                else 
                {
                    int diff = Int16.Parse(mlen) - Int16.Parse(dlenS);
                    dgvPipes[e.ColumnIndex + 1, e.RowIndex].Value = diff.ToString();
                    dgvPipes[e.ColumnIndex - 2, e.RowIndex].Value = false;
                    dgvPipes[e.ColumnIndex - 1, e.RowIndex].Value = false;
                }              
            }            
        }


        private void btnEnter_Click(object sender, EventArgs e)
        {
            jobno = txtJobNo.Text;
            coilno = txtCoilNo.Text;
            fpipno = txtNextPipeNo.Text;
            lblCurrentPipeNo.Text = fpipno;
            cutLength = Int16.Parse(txtCutLength.Text);
            btnNextPipe.Visible = true;
            btnEndOfCoil.Visible = true;
            lblCount.Visible = true;

            lblJobNo.Visible = false;
            lblCoilNo.Visible = false;
            lblNextPipeNo.Visible = false;
            txtJobNo.Visible = false;
            txtCoilNo.Visible = false;
            txtNextPipeNo.Visible = false;
            btnEnter.Visible = false;
            lblCutLength.Visible = false;
            txtCutLength.Visible = false;           
        }


        private void Wipe() 
        {
            btnNextPipe.Visible = false;
            btnEndOfCoil.Visible = false;
            dgvPipes.Rows.Clear();

            lblJobNo.Visible = true;
            lblCoilNo.Visible = true;
            lblNextPipeNo.Visible = true;
            txtJobNo.Visible = true;
            txtCoilNo.Visible = true;
            txtNextPipeNo.Visible = true;
            btnEnter.Visible = true;
            lblCutLength.Visible = true;
            txtCutLength.Visible = true;

            txtJobNo.Text = "";
            txtCoilNo.Text = "";
            txtNextPipeNo.Text = "";
            txtCutLength.Text = "";

            count_dgv_pipes = 0;
            count_db_pipes = 0;
            countScrapPipes = 0;
            sumScrapLen = 0;
            data = "";
            countGoodPipes = 0;
            lblCurrentPipeNo.Visible = false;
            lblTotalGoodPipes.Visible = false;

            lblTotalScrap.Visible = false;
            lblCount.Visible = false;
        }


        private void btnClear_Click(object sender, EventArgs e)
        {
            Wipe();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Wipe();
        }
    }
}
