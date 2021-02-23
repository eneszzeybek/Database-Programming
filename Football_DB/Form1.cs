using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Football_DB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'footballDataSet2.Parent' table. You can move, or remove it, as needed.
            this.parentTableAdapter.Fill(this.footballDataSet2.Parent);
            // TODO: This line of code loads data into the 'footballDataSet2.Parent' table. You can move, or remove it, as needed.
            this.parentTableAdapter.Fill(this.footballDataSet2.Parent);
            // TODO: This line of code loads data into the 'footballDataSet1.Team' table. You can move, or remove it, as needed.
            this.teamTableAdapter.Fill(this.footballDataSet1.Team);
            // TODO: This line of code loads data into the 'footballDataSet1.Team' table. You can move, or remove it, as needed.
            this.teamTableAdapter.Fill(this.footballDataSet1.Team);
            // TODO: This line of code loads data into the 'footballDataSet.Enroll' table. You can move, or remove it, as needed.
            this.enrollTableAdapter.Fill(this.footballDataSet.Enroll);
            // TODO: This line of code loads data into the 'footballDataSet.Parent' table. You can move, or remove it, as needed.
            this.parentTableAdapter.Fill(this.footballDataSet.Parent);
            // TODO: This line of code loads data into the 'footballDataSet.Coach' table. You can move, or remove it, as needed.
            this.coachTableAdapter.Fill(this.footballDataSet.Coach);
            // TODO: This line of code loads data into the 'footballDataSet.Player' table. You can move, or remove it, as needed.
            this.playerTableAdapter.Fill(this.footballDataSet.Player);
            // TODO: This line of code loads data into the 'footballDataSet.Team' table. You can move, or remove it, as needed.
            this.teamTableAdapter.Fill(this.footballDataSet.Team);

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e) // INSERT TEAM
        {
            this.teamTableAdapter.InsertQuery(textBox1.Text, textBox2.Text);
            this.teamTableAdapter.Fill(this.footballDataSet.Team);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e) // INSERT PLAYER
        {
            int PL_A, T_ID;
            int.TryParse(textBox5.Text, out PL_A);
            int.TryParse(comboBox1.SelectedValue.ToString(), out T_ID);
            this.playerTableAdapter.InsertQuery(textBox3.Text, textBox4.Text, PL_A, T_ID);
            this.playerTableAdapter.Fill(this.footballDataSet.Player);
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e) // INSERT COACH
        {
            int C_P, T_ID;
            int.TryParse(textBox8.Text, out C_P);
            int.TryParse(comboBox2.SelectedValue.ToString(), out T_ID);
            this.coachTableAdapter.InsertQuery(textBox6.Text, textBox7.Text, C_P, T_ID);
            this.coachTableAdapter.Fill(this.footballDataSet.Coach);
        }

        private void button4_Click(object sender, EventArgs e) // INSERT PARENT
        {
            int PR_P;
            int.TryParse(textBox11.Text, out PR_P);
            this.parentTableAdapter.InsertQuery(textBox9.Text, textBox10.Text, PR_P, textBox12.Text);
            this.parentTableAdapter.Fill(this.footballDataSet.Parent);
        }

        private void button5_Click(object sender, EventArgs e) // INSERT ENROLL
        {
            int PL_ID, PR_ID;
            int.TryParse(comboBox3.SelectedValue.ToString(), out PL_ID);
            int.TryParse(comboBox4.SelectedValue.ToString(), out PR_ID);
            this.enrollTableAdapter.InsertQuery(PL_ID, PR_ID);
            this.enrollTableAdapter.Fill(this.footballDataSet.Enroll);
        }

        private void button6_Click(object sender, EventArgs e) // UPDATE TEAM
        {
            int T_ID;
            int.TryParse(textBox15.Text, out T_ID);
            this.teamTableAdapter.UpdateQuery(textBox13.Text, textBox14.Text, T_ID);
            this.teamTableAdapter.Fill(this.footballDataSet.Team);
        }

        private void button7_Click(object sender, EventArgs e) // DELETE TEAM
        {
            int T_ID;
            int.TryParse(textBox15.Text, out T_ID);
            this.teamTableAdapter.DeleteQuery(T_ID);
            this.playerTableAdapter.UpdateQuery_Delete_Team(T_ID);
            this.playerTableAdapter.Fill(this.footballDataSet.Player);
            this.teamTableAdapter.Fill(this.footballDataSet.Team);
        }

        private void button8_Click(object sender, EventArgs e) // UPDATE PLAYER
        {
            int PL_A, T_ID, PL_ID;
            int.TryParse(textBox20.Text, out PL_ID);
            int.TryParse(textBox19.Text, out PL_A);
            int.TryParse(comboBox5.SelectedValue.ToString(), out T_ID);
            this.playerTableAdapter.UpdateQuery(textBox17.Text, textBox18.Text, PL_A, T_ID, PL_ID);
            this.playerTableAdapter.Fill(this.footballDataSet.Player);
        }

        private void textBox21_TextChanged(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e) // DELETE PLAYER
        {
            int PL_ID;
            int.TryParse(textBox20.Text, out PL_ID);
            this.playerTableAdapter.DeleteQuery(PL_ID);
            this.playerTableAdapter.Fill(this.footballDataSet.Player);
        }

        private void button10_Click(object sender, EventArgs e) // SEARCH TEAM
        {
            int T_ID;
            int.TryParse(textBox15.Text, out T_ID);
            textBox13.Text = this.teamTableAdapter.ScalarQuery(T_ID);
            textBox14.Text = this.teamTableAdapter.ScalarQuery1(T_ID);
            this.teamTableAdapter.Fill(this.footballDataSet.Team);
        }

        private void button11_Click(object sender, EventArgs e) // SEARCH PLAYER
        {
            int PL_ID;
            int PL_A;
            int T_ID;
            int.TryParse(textBox20.Text, out PL_ID);
            int.TryParse(textBox19.Text, out PL_A);
            int.TryParse(comboBox5.Text, out T_ID);
            textBox17.Text = this.playerTableAdapter.ScalarQuery(PL_ID);
            textBox18.Text = this.playerTableAdapter.ScalarQuery1(PL_ID);
            textBox19.Text = Convert.ToString(this.playerTableAdapter.ScalarQuery2(PL_ID));
            comboBox5.Text = Convert.ToString(this.playerTableAdapter.ScalarQuery3(PL_ID));
            this.playerTableAdapter.Fill(this.footballDataSet.Player);
        }

        private void button12_Click(object sender, EventArgs e) // SEARCH COACH
        {
            int C_ID;
            int C_P;
            int T_ID;
            int.TryParse(textBox16.Text, out C_ID);
            int.TryParse(textBox23.Text, out C_P);
            int.TryParse(comboBox6.Text, out T_ID);
            textBox21.Text = this.coachTableAdapter.ScalarQuery(C_ID);
            textBox22.Text = this.coachTableAdapter.ScalarQuery1(C_ID);
            textBox23.Text = Convert.ToString(this.coachTableAdapter.ScalarQuery2(C_ID));
            comboBox6.Text = Convert.ToString(this.coachTableAdapter.ScalarQuery3(C_ID));
            this.coachTableAdapter.Fill(this.footballDataSet.Coach);
        }

        private void button13_Click(object sender, EventArgs e) // UPDATE COACH
        {
            int C_ID;
            int C_P;
            int T_ID;
            int.TryParse(textBox16.Text, out C_ID);
            int.TryParse(textBox23.Text, out C_P);
            int.TryParse(comboBox6.SelectedValue.ToString(), out T_ID);
            this.coachTableAdapter.UpdateQuery(textBox21.Text, textBox22.Text, C_P, T_ID, C_ID);
            this.coachTableAdapter.Fill(this.footballDataSet.Coach);
        }

        private void button14_Click(object sender, EventArgs e) // DELETE COACH
        {
            int C_ID;
            int.TryParse(textBox16.Text, out C_ID);
            this.coachTableAdapter.DeleteQuery(C_ID);
            this.coachTableAdapter.Fill(this.footballDataSet.Coach);
        }

        private void button15_Click(object sender, EventArgs e) // SEARCH PARENT
        {
            int PR_ID;
            int PR_P;
            int.TryParse(textBox24.Text, out PR_ID);
            int.TryParse(textBox27.Text, out PR_P);
            textBox25.Text = this.parentTableAdapter.ScalarQuery(PR_ID);
            textBox26.Text = this.parentTableAdapter.ScalarQuery1(PR_ID);
            textBox27.Text = Convert.ToString(this.parentTableAdapter.ScalarQuery2(PR_ID));
            textBox28.Text = this.parentTableAdapter.ScalarQuery3(PR_ID);
            this.parentTableAdapter.Fill(this.footballDataSet.Parent);
        }

        private void button16_Click(object sender, EventArgs e) // UPDATE PARENT
        {
            int PR_ID;
            int PR_P;
            int.TryParse(textBox24.Text, out PR_ID);
            int.TryParse(textBox27.Text, out PR_P);
            this.parentTableAdapter.UpdateQuery(textBox25.Text, textBox26.Text, PR_P, textBox28.Text, PR_ID);
            this.parentTableAdapter.Fill(this.footballDataSet.Parent);
        }

        private void button17_Click(object sender, EventArgs e) // DELETE PARENT
        {
            int PR_ID;
            int.TryParse(textBox24.Text, out PR_ID);
            this.parentTableAdapter.DeleteQuery(PR_ID);
            this.parentTableAdapter.Fill(this.footballDataSet.Parent);
        }

        private void button18_Click(object sender, EventArgs e) // SELECT ENROLL
        {
            int E_ID, PL_ID, PR_ID;
            int.TryParse(textBox29.Text, out E_ID);
            int.TryParse(comboBox7.SelectedValue.ToString(), out PL_ID);
            int.TryParse(comboBox8.SelectedValue.ToString(), out PR_ID);
            comboBox7.Text = Convert.ToString(this.enrollTableAdapter.ScalarQuery(E_ID));
            comboBox8.Text = Convert.ToString(this.enrollTableAdapter.ScalarQuery1(E_ID));
            this.enrollTableAdapter.Fill(this.footballDataSet.Enroll);
        }

        private void button19_Click(object sender, EventArgs e) // UPDATE ENROLL
        {
            int E_ID;
            int PL_ID;
            int PR_ID;
            int.TryParse(textBox29.Text, out E_ID);
            int.TryParse(comboBox7.SelectedValue.ToString(), out PL_ID);
            int.TryParse(comboBox8.SelectedValue.ToString(), out PR_ID);
            this.enrollTableAdapter.UpdateQuery(PL_ID, PR_ID, E_ID);
            this.enrollTableAdapter.Fill(this.footballDataSet.Enroll);
        }

        private void button20_Click(object sender, EventArgs e) // DELETE ENROLL
        {
            int E_ID;
            int.TryParse(textBox29.Text, out E_ID);
            this.enrollTableAdapter.DeleteQuery(E_ID);
            this.enrollTableAdapter.Fill(this.footballDataSet.Enroll);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}
