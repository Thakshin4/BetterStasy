using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BetterStasy
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void register_btn_Click(object sender, EventArgs e)
        {
            ArrayList modules = new ArrayList();

            foreach (object module in modules_clb.CheckedItems)
            { modules.Add(module.ToString()); }

            foreach (object rmodule in rmodules_clb.CheckedItems)
            { modules.Add(rmodule.ToString()); }
            
            // New Student Objects
            StudentInfo si = new StudentInfo(studentno_txb.Text, pasword_txb.Text, firstname_txb.Text, lastname_txb.Text);
            StudentCourse sc = new StudentCourse(course_cmb.Text, modules, group_cmb.Text);

            // Registration Message Box
            string m = "";
            foreach (object module in sc.modules)
            { m += module.ToString() + " "; }

            MessageBox.Show("You have successfully Registered!");
            MessageBox.Show("Student Number: " + si.student_number + "\nPassword: " + si.student_password + "\nFirst Name: " + si.student_firstname + "\nLast Name: " + si.student_lastname +
                "\nCourse: " + sc.course + "\nModules: " + m + "\nGroup: " + sc.group);

            // Back to Login Page
            this.Hide();

            Form1 f = new Form1();
            f.ShowDialog();        

            // Write Student to Database
            if (result == DialogResult.Yes)
            {
                try
                {
                    string connectonString = @"Data Source=ML-RefVm-631348\\SQLEXPRESS;database=BetterStasy;Integrated Security = True";

                    string query = "Insert Into Orders Values (@student_number,@student_firstname,@student_lastname,@student_password,@student_course, @student_modules, @student_rmodules, @student_group)";

                    SqlConnection connecton = new SqlConnection(connectonString);

                    connecton.Open();

                    using (SqlCommand cmd = new SqlCommand(query, connecton))
                    {
                        cmd.Parameters.Add("@student_number", SqlDbType.Int).Value = student_number;
                        cmd.Parameters.Add("@student_firstname", SqlDbType.Int).Value = student_firstname;
                        cmd.Parameters.Add("@student_lastname", SqlDbType.Int).Value = student_lastname;
                        cmd.Parameters.Add("@student_password", SqlDbType.Int).Value = student_password;
                        cmd.Parameters.Add("@student_course", SqlDbType.Int).Value = course;
                        cmd.Parameters.Add("@student_modules", SqlDbType.Int).Value = modules;
                        cmd.Parameters.Add("@student_rmodules", SqlDbType.Int).Value = rmodules;                        
                        cmd.Parameters.Add("@student_group", SqlDbType.Int).Value = group;
                        

                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                }
            }
            else
            {
                MessageBox.Show("Registration Cancelled", "Cancel Registration", MessageBoxButtons.OK);
            }
        }

        private void course_cmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            modules_clb.Items.Clear();
            rmodules_clb.Items.Clear();
            group_cmb.Items.Clear();

            var modules = new ArrayList() { };
            var rmodules = new ArrayList() { };
            var groups = new ArrayList() { };

            // Displays Modules Depending on selected Course
            if (course_cmb.Text.Equals("BCAD1"))
            {
                modules = new ArrayList() { "PROG1", "MAPC", "NWEG", "PRLD" };
                groups = new ArrayList() { 1, 2, 3 };
            }
            else if (course_cmb.Text.Equals("BCAD2"))
            {
                modules = new ArrayList() { "PROG2", "CLDV", "DBAS", "SAND" };
                rmodules = new ArrayList() { "PROG1", "MAPC", "NWEG", "PRLD" };
                groups = new ArrayList() { 1, 2};
            }
            else if (course_cmb.Text.Equals("BCAD3"))
            {
                modules = new ArrayList() { "PROG3", "DBAS2", "Data", "Software" };
                rmodules = new ArrayList() { "PROG1", "MAPC", "NWEG", "PRLD", "PROG2", "CLDV", "DBAS", "SAND" };
                groups = new ArrayList() { 1, 2};
            }

            foreach (var module in modules)
            { modules_clb.Items.Add(module); }

            foreach (var rmodule in rmodules)
            { rmodules_clb.Items.Add(rmodule); }

            foreach (var group in groups)
            { group_cmb.Items.Add(group); }
        }

        private void rmodule_cbx_CheckedChanged(object sender, EventArgs e)
        {
            rmodules_clb.Visible = rmodule_cbx.Checked;
        }
    }
}
