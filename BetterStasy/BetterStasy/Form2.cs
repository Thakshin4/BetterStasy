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
