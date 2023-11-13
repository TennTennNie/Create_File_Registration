using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrganizationProfile
{
    public partial class frmRegistration : Form
    {

        public frmRegistration()
        {
            InitializeComponent();
        }

        private void frmRegistration_Load(object sender, EventArgs e)
        {
            string[] ListOfProgram = new string[]{
            "BS Information Technology",
            "BS Computer Science",
            "BS Information Systems",
            "BS in Accountancy",
            "BS in Hospitality Management",
            "BS in Tourism Management"
            };

            for (int i = 0; i < 6; i++)
            {
                cbPrograms.Items.Add(ListOfProgram[i].ToString());
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string[] Data =
            {
                $"Student Number: {txtStudentNo.Text}",
                $"Full Name: {txtLastName.Text}, {txtFirstName.Text}, {txtMiddleInitial.Text}",
                $"Program: {cbPrograms.Text}",
                $"Gender: {cbGender.Text}",
                $"Age: {txtAge.Text}",
                $"Birthday: {datePickerBirthday.Value.ToString("yyyy-mm-dd")}",
                $"Contact Number: {txtContactNo.Text}"
            };

            using (StreamWriter outputFile = new StreamWriter($"{docPath}\\{txtStudentNo.Text}.txt"))
            {
                foreach (var item in Data)
                {
                    outputFile.WriteLine(item);
                }
            }

            Close();
        }
    }
}
