using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NFM_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string path_00 = "";



        private void button1_Click(object sender, EventArgs e)
        {

            folderBrowserDialog1.ShowNewFolderButton = true;

            folderBrowserDialog1.RootFolder = System.Environment.SpecialFolder.MyComputer;


            try
            {
                folderBrowserDialog1.SelectedPath = textBox_path_00.Text;
            }
            catch (Exception xcp)
            {


            }

            if (folderBrowserDialog1.ShowDialog() ==
                System.Windows.Forms.DialogResult.OK)
            {

                path_00 = folderBrowserDialog1.SelectedPath;

                textBox_path_00.Text = path_00;
            }


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Top = 0;

            this.Left = 100;

            this.Height = Screen.PrimaryScreen.Bounds.Height - 150;
        }

        private void Form1_Shown(object sender, EventArgs e)
        {



            //textBox_path_00.Text = Application.StartupPath;


        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

            MessageBox.Show("Tooltip");
            //e.AssociatedControl.Text;
        }

        private void button_Create_New_Folders_Click(object sender, EventArgs e)
        {
            if (checkBox_I_am_sure.Checked)
            {
                Create_New_Folders();
            }
            else
            {
                MessageBox.Show("While you are not sure to create folders, nothing will be happen.");
            }
        }

        private void Create_New_Folders()
        {


            //throw new NotImplementedException();

            bool error_too_long = false;

            try
            {

                path_00 = textBox_path_00.Text;

                int length_02 = path_00.Length +
                            textBox_start_of_folders_names.Text.Length +
                            textBox_end_of_folders_names.Text.Length +
                            20;

                if (path_00.Length > 45 || length_02 > 100)
                {


                    MessageBox.Show("\n\n  The folders names are TOO LONG to create. \n\n" +

                        "  path_00.Length = " + path_00.Length.ToString() + " , \n" +

                        "  length_02 = " + length_02.ToString() + "\n\n");



                    error_too_long = true;

                    goto label_a;
                }


                string current_path = "";

                int start = (int)numericUpDown_sequ_num_start_from.Value;

                int end = (int)numericUpDown_sequ_num_up_to.Value;

                if (end >= start)
                {

                    listBox1.Items.Add("  *************  START  *************  ");

                    string str_i2 = "";

                    for (
                        int i = start;
                        i <= end;
                        i++
                        )
                    {


                        if (radioButton_Type_of_nums_01.Checked)
                        {
                            str_i2 = i.ToString();
                        }
                        else if (radioButton_Type_of_nums_02.Checked)
                        {
                            if (Math.Abs(i).ToString().Length == 1)
                            {
                                str_i2 = "0" + i.ToString();
                            }
                            else if (Math.Abs(i).ToString().Length >= 2)
                            {
                                str_i2 = i.ToString();
                            }
                        }
                        else if (radioButton_Type_of_nums_03.Checked)
                        {
                            if (Math.Abs(i).ToString().Length == 1)
                            {
                                str_i2 = "00" + i.ToString();
                            }
                            else if (Math.Abs(i).ToString().Length == 2)
                            {
                                str_i2 = "0" + i.ToString();
                            }
                            else if (Math.Abs(i).ToString().Length >= 3)
                            {
                                str_i2 = i.ToString();
                            }
                        }
                        else if (radioButton_Type_of_nums_04.Checked)
                        {
                            if (Math.Abs(i).ToString().Length == 1)
                            {
                                str_i2 = "000" + i.ToString();
                            }
                            else if (Math.Abs(i).ToString().Length == 2)
                            {
                                str_i2 = "00" + i.ToString();
                            }
                            else if (Math.Abs(i).ToString().Length == 3)
                            {
                                str_i2 = "0" + i.ToString();
                            }
                            else if (Math.Abs(i).ToString().Length >= 4)
                            {
                                str_i2 = "" + i.ToString();
                            }
                        }

                        current_path =
                            path_00 + @"\" +
                            textBox_start_of_folders_names.Text +
                            str_i2 +
                            textBox_end_of_folders_names.Text
                            ;

                        if (current_path.Length <= 150)
                        {

                            System.IO.Directory.CreateDirectory(current_path);

                            listBox1.Items.Add(current_path);

                        }
                        else
                        {
                            MessageBox.Show("\n\n  The folders names are TOO LONG to create. \n\n");

                            error_too_long = true;

                            break;
                        }
                    }

                    listBox1.Items.Add("  *************  END  *************  ");


                }



            label_a:

                if (error_too_long == true)
                {
                    //MessageBox.Show("\n\n  The folders names are TOO LONG to create. \n\n");
                }
                else
                {
                    MessageBox.Show("\n\n  The folders that you had specified, were created successfully. \n\n");

                }


                System.Diagnostics.Process.Start(path_00 + "\\");




            }
            catch (Exception xcp)
            {


                MessageBox.Show(xcp.Message);

            }



        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button_Go_to_Startup_Path_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(Application.StartupPath);
        }
    }
}
