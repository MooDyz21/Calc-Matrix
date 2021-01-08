using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Matrix2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Det 2x2 and 3x3
            TextBox[] array = new TextBox[9];
            TextBox[] array1 = new TextBox[4];
            array1[0] = textBox122;
            array1[1] = textBox123;
            array1[2] = textBox124;
            array1[3] = textBox125;

            array[0] = textBox1;
            array[1] = textBox4;
            array[2] = textBox7;
            array[3] = textBox8;
            array[4] = textBox5;
            array[5] = textBox2;
            array[6] = textBox9;
            array[7] = textBox6;
            array[8] = textBox3;
            if (array[0].Text != "" && array[1].Text != "" && array[2].Text != "" && array[3].Text != "" && array[4].Text != "" && array[5].Text != "" && array[6].Text != "" && array[7].Text != "" && array[8].Text != "")
            {
                // caculations 
                double a = double.Parse(textBox1.Text);
                double b = double.Parse(textBox2.Text);
                double c = double.Parse(textBox3.Text);
                double d = a * ((double.Parse(textBox5.Text) * double.Parse(textBox9.Text)) - (double.Parse(textBox6.Text) * double.Parse(textBox8.Text))) - b * ((double.Parse(textBox4.Text) * double.Parse(textBox9.Text)) - (double.Parse(textBox6.Text) * double.Parse(textBox7.Text))) + c * ((double.Parse(textBox4.Text) * double.Parse(textBox8.Text)) - (double.Parse(textBox5.Text) * double.Parse(textBox7.Text)));

                textBox10.Text = d.ToString();

                //Det 2x2
            }
            else if (array1[0].Text != "" && array1[1].Text != "" && array1[2].Text != "" && array1[3].Text != "")
            {
                double d = ((double.Parse(textBox122.Text) * (double.Parse(textBox125.Text))) - (double.Parse(textBox123.Text)) * (double.Parse(textBox124.Text)));

                textBox10.Text = d.ToString();
            }
            else
            {

                label1.Text = "Please Fill the Text boxes with numbers";

            }
        }

        //panels to Switch Pages/panels.

        private void button2_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = true;
            panel3.Visible = false;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel2.Visible = false;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = true;
            panel3.Visible = false;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel2.Visible = false;
            panel3.Visible = false;

        }

        private void button6_Click(object sender, EventArgs e)
        {
            // transpose
            TextBox[] array = new TextBox[9];
            array[0] = textBox11;
            array[1] = textBox12;
            array[2] = textBox13;
            array[3] = textBox14;
            array[4] = textBox15;
            array[5] = textBox16;
            array[6] = textBox17;
            array[7] = textBox18;
            array[8] = textBox19;
            if (array[0].Text != "" && array[1].Text != "" && array[2].Text != "" && array[3].Text != "" && array[4].Text != "" && array[5].Text != "" && array[6].Text != "" && array[7].Text != "" && array[8].Text != "")
            {
                // here we are switching the places accourding to the Rules of the Transpose
                textBox20.Text = textBox11.Text.ToString();
                textBox21.Text = textBox14.Text.ToString();
                textBox22.Text = textBox17.Text.ToString();
                textBox23.Text = textBox12.Text.ToString();
                textBox24.Text = textBox15.Text.ToString();
                textBox25.Text = textBox18.Text.ToString();
                textBox26.Text = textBox17.Text.ToString();
                textBox27.Text = textBox16.Text.ToString();
                textBox28.Text = textBox19.Text.ToString();


            }
            else
            {

                label3.Text = "Please Fill the boxes with Numbers";

            }
        }

        //panels to Switch Pages/panels.
        private void button7_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel2.Visible = false;

        }

        private void button8_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = true;

        }

        private void button9_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = false;

        }

        private void button10_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = true;

        }

        private void button11_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = true;

        }

        private void button12_Click(object sender, EventArgs e)
        {

            panel1.Visible = true;
            panel2.Visible = false;

        }

        private void button13_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = true;

        }

        private void button14_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = false;

        }

        private void button15_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = false;

        }

        private void button16_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = false;

        }

        private void button17_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = false;

        }

        private void button18_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = false;

        }

        private void button12_Click_1(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel2.Visible = false;

        }

        private void button15_Click_1(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = false;

        }

        private void button13_Click_1(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = true;

        }

        private void button14_Click_1(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = false;

        }


        //panels to Switch Pages/panels.
        private void button7_Click_1(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = true;
            panel4.Visible = false;
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = true;
            panel3.Visible = false;
            panel4.Visible = false;
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = false;
        }

        private void button12_Click_2(object sender, EventArgs e)
        {
            //Adjoint starting point
            TextBox[] array = new TextBox[9];
            array[0] = textBox29;
            array[1] = textBox30;
            array[2] = textBox31;
            array[3] = textBox32;
            array[4] = textBox33;
            array[5] = textBox34;
            array[6] = textBox35;
            array[7] = textBox36;
            array[8] = textBox37;
            if (array[0].Text != "" && array[1].Text != "" && array[2].Text != "" && array[3].Text != "" && array[4].Text != "" && array[5].Text != "" && array[6].Text != "" && array[7].Text != "" && array[8].Text != "")
            {

                // We get the Cofactor Calcuations down there and we get the Transpose of it to get the Adjoint

                double textBox38 = ((double.Parse(textBox33.Text) * double.Parse(textBox37.Text)) - (double.Parse(textBox34.Text)) * (double.Parse(textBox36.Text)));
                double textBox39 = -((double.Parse(textBox32.Text) * double.Parse(textBox37.Text)) - (double.Parse(textBox34.Text)) * (double.Parse(textBox35.Text)));
                double textBox40 = ((double.Parse(textBox32.Text) * double.Parse(textBox36.Text)) - (double.Parse(textBox33.Text)) * (double.Parse(textBox35.Text)));
                double textBox41 = -((double.Parse(textBox30.Text) * double.Parse(textBox37.Text)) - (double.Parse(textBox31.Text)) * (double.Parse(textBox36.Text)));
                double textBox42 = ((double.Parse(textBox29.Text) * double.Parse(textBox37.Text)) - (double.Parse(textBox31.Text)) * (double.Parse(textBox35.Text)));
                double textBox43 = -((double.Parse(textBox29.Text) * double.Parse(textBox36.Text)) - (double.Parse(textBox30.Text)) * (double.Parse(textBox35.Text)));
                double textBox44 = ((double.Parse(textBox30.Text) * double.Parse(textBox34.Text)) - (double.Parse(textBox31.Text)) * (double.Parse(textBox33.Text)));
                double textBox45 = -((double.Parse(textBox29.Text) * double.Parse(textBox34.Text)) - (double.Parse(textBox31.Text)) * (double.Parse(textBox32.Text)));
                double textBox46 = ((double.Parse(textBox29.Text) * double.Parse(textBox33.Text)) - (double.Parse(textBox30.Text)) * (double.Parse(textBox32.Text)));
                //Transpose of the Cofactor = Adjoint.
                textBox47.Text = textBox38.ToString();
                textBox48.Text = textBox41.ToString();
                textBox49.Text = textBox44.ToString();
                textBox50.Text = textBox39.ToString();
                textBox51.Text = textBox42.ToString();
                textBox52.Text = textBox45.ToString();
                textBox53.Text = textBox40.ToString();
                textBox54.Text = textBox43.ToString();
                textBox55.Text = textBox46.ToString();





            }
            else
            {

                label5.Text = "Please Fill the Boxes with Numbers";
            }
        }

        private void button13_Click_2(object sender, EventArgs e)
        {
            // Here we start the Inverse
            TextBox[] array = new TextBox[9];
            TextBox[] array1 = new TextBox[4];
            array1[0] = textBox83;
            array1[1] = textBox84;
            array1[2] = textBox85;
            array1[3] = textBox86;
            array[0] = textBox56;
            array[1] = textBox57;
            array[2] = textBox58;
            array[3] = textBox59;   //( tx56 tx57 tx58   (tx65 tx66 tx67
            array[4] = textBox60;   //( tx59 tx60 tx61   (tx68  tx69 tx70
            array[5] = textBox61;   // (tx62 tx63 tx 64  (tx 71  tx72 tx73
            array[6] = textBox62;
            array[7] = textBox63;
            array[8] = textBox64;
            if (array[0].Text != "" && array[1].Text != "" && array[2].Text != "" && array[3].Text != "" && array[4].Text != "" && array[5].Text != "" && array[6].Text != "" && array[7].Text != "" && array[8].Text != "")
            {
                //Determnate starts from here

                double f = double.Parse(textBox56.Text);
                double g = double.Parse(textBox57.Text);
                double j = double.Parse(textBox58.Text);
                double k = f * ((double.Parse(textBox60.Text) * double.Parse(textBox64.Text)) - (double.Parse(textBox61.Text) * double.Parse(textBox63.Text))) - g * ((double.Parse(textBox59.Text) * double.Parse(textBox64.Text)) - (double.Parse(textBox61.Text) * double.Parse(textBox62.Text))) + j * ((double.Parse(textBox59.Text) * double.Parse(textBox63.Text)) - (double.Parse(textBox60.Text) * double.Parse(textBox62.Text)));

                //cofactor * 1/det startes from here
                // 1/Det * cofactor so we can transpose it and get the inverse of the 3x3
                double textBox65 = (1 / k) * ((double.Parse(textBox60.Text) * double.Parse(textBox64.Text)) - (double.Parse(textBox61.Text)) * (double.Parse(textBox63.Text)));
                double textBox66 = (1 / k) * -((double.Parse(textBox59.Text) * double.Parse(textBox64.Text)) - (double.Parse(textBox61.Text)) * (double.Parse(textBox62.Text)));
                double textBox67 = (1 / k) * ((double.Parse(textBox59.Text) * double.Parse(textBox63.Text)) - (double.Parse(textBox60.Text)) * (double.Parse(textBox62.Text)));
                double textBox68 = (1 / k) * -((double.Parse(textBox57.Text) * double.Parse(textBox64.Text)) - (double.Parse(textBox58.Text)) * (double.Parse(textBox63.Text)));
                double textBox69 = (1 / k) * ((double.Parse(textBox56.Text) * double.Parse(textBox64.Text)) - (double.Parse(textBox58.Text)) * (double.Parse(textBox62.Text)));
                double textBox70 = (1 / k) * -((double.Parse(textBox56.Text) * double.Parse(textBox63.Text)) - (double.Parse(textBox57.Text)) * (double.Parse(textBox62.Text)));
                double textBox71 = (1 / k) * ((double.Parse(textBox57.Text) * double.Parse(textBox61.Text)) - (double.Parse(textBox58.Text)) * (double.Parse(textBox60.Text)));
                double textBox72 = (1 / k) * -((double.Parse(textBox56.Text) * double.Parse(textBox61.Text)) - (double.Parse(textBox58.Text)) * (double.Parse(textBox59.Text)));
                double textBox73 = (1 / k) * ((double.Parse(textBox56.Text) * double.Parse(textBox60.Text)) - (double.Parse(textBox57.Text)) * (double.Parse(textBox59.Text)));

                //transpose starts here

                textBox74.Text = textBox65.ToString();
                textBox75.Text = textBox68.ToString();
                textBox76.Text = textBox71.ToString();
                textBox77.Text = textBox66.ToString();
                textBox78.Text = textBox69.ToString();
                textBox79.Text = textBox72.ToString();
                textBox80.Text = textBox67.ToString();
                textBox81.Text = textBox70.ToString();
                textBox82.Text = textBox73.ToString();





            }
            //Inverse of the 2x2 starts from here
            else if (array1[0].Text != "" && array1[1].Text != "" && array1[2].Text != "" && array1[3].Text != "")
            {
                // Since the inverse 
                double d = ((double.Parse(textBox83.Text) * (double.Parse(textBox86.Text))) - (double.Parse(textBox84.Text)) * (double.Parse(textBox85.Text)));
                double textBox91 = (1 / d) * (double.Parse(textBox83.Text));
                double textBox92 = (1 / d) * -(double.Parse(textBox84.Text));
                double textBox93 = -(1 / d) * -(double.Parse(textBox85.Text));
                double textBox94 = (1 / d) * (double.Parse(textBox86.Text));
                textBox87.Text = textBox94.ToString();
                textBox88.Text = textBox92.ToString();
                textBox89.Text = textBox93.ToString();
                textBox90.Text = textBox91.ToString();
            }
            else
                label6.Text = "Please fill the Boxes with numbers";







        }

        

        private void button14_Click_2(object sender, EventArgs e)
        {
            //buttons to make the inverse insead of 2x2 to 3x3
            textBox56.Visible = true;
            textBox57.Visible = true;
            textBox58.Visible = true;
            textBox59.Visible = true;
            textBox60.Visible = true;
            textBox61.Visible = true;
            textBox62.Visible = true;
            textBox63.Visible = true;
            textBox64.Visible = true;
            textBox74.Visible = true;
            textBox75.Visible = true;
            textBox76.Visible = true;
            textBox77.Visible = true;
            textBox78.Visible = true;
            textBox79.Visible = true;
            textBox80.Visible = true;
            textBox81.Visible = true;
            textBox82.Visible = true;
            textBox83.Visible = false;
            textBox84.Visible = false;
            textBox85.Visible = false;
            textBox86.Visible = false;
            textBox87.Visible = false;
            textBox88.Visible = false;
            textBox89.Visible = false;
            textBox90.Visible = false;

        }

        private void button15_Click_2(object sender, EventArgs e)
        {
            //buttons to make the 3x3 to 2x2
            textBox56.Visible = false;
            textBox57.Visible = false;
            textBox58.Visible = false;
            textBox59.Visible = false;
            textBox60.Visible = false;
            textBox61.Visible = false;
            textBox62.Visible = false;
            textBox63.Visible = false;
            textBox64.Visible = false;
            textBox74.Visible = false;
            textBox75.Visible = false;
            textBox76.Visible = false;
            textBox77.Visible = false;
            textBox78.Visible = false;
            textBox79.Visible = false;
            textBox80.Visible = false;
            textBox81.Visible = false;
            textBox82.Visible = false;
            textBox83.Visible = true;
            textBox84.Visible = true;
            textBox85.Visible = true;
            textBox86.Visible = true;
            textBox87.Visible = true;
            textBox88.Visible = true;
            textBox89.Visible = true;
            textBox90.Visible = true;

        }



        private void button16_Click_1(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = false;
        }

        private void button17_Click_1(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = true;
            panel3.Visible = false;
            panel4.Visible = false;
        }

        private void button18_Click_1(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = true;
            panel4.Visible = false;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = true;
        }

        private void button21_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = true;
        }

        private void button23_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = true;
        }

        private void button20_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = true;
        }



        public void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            //combobox1 to choose which TextBoxes depends on the user Matrix of choice
            string x = "3 x 3";
            string y = "3 x 2";
            string z = "3 x 1";
            string a = "2 x 3";
            string b = "2 x 2";
            string d = "1 x 3";

            TextBox[] array = new TextBox[9];
            array[0] = textBox95;
            array[1] = textBox95;
            array[2] = textBox95;
            array[3] = textBox95;
            array[4] = textBox95;
            array[5] = textBox95;
            array[6] = textBox95;
            array[7] = textBox95;
            array[8] = textBox95;




            if (comboBox1.SelectedItem.Equals(x))
            {
                textBox95.Visible = true;
                textBox96.Visible = true;
                textBox97.Visible = true;
                textBox98.Visible = true;
                textBox99.Visible = true;
                textBox100.Visible = true;
                textBox101.Visible = true;
                textBox102.Visible = true;
                textBox103.Visible = true;





            }
            else if (comboBox1.SelectedItem.Equals(y))
            {
                textBox95.Visible = true;
                textBox96.Visible = true;
                textBox97.Visible = false;
                textBox98.Visible = true;
                textBox99.Visible = true;
                textBox100.Visible = false;
                textBox101.Visible = true;
                textBox102.Visible = true;
                textBox103.Visible = false;

            }
            else if (comboBox1.SelectedItem.Equals(z))
            {
                textBox95.Visible = true;
                textBox96.Visible = false;
                textBox97.Visible = false;
                textBox98.Visible = true;
                textBox99.Visible = false;
                textBox100.Visible = false;
                textBox101.Visible = true;
                textBox102.Visible = false;
                textBox103.Visible = false;

            }
            else if (comboBox1.SelectedItem.Equals(a))
            {

                textBox95.Visible = true;
                textBox96.Visible = true;
                textBox97.Visible = true;
                textBox98.Visible = true;
                textBox99.Visible = true;
                textBox100.Visible = true;
                textBox101.Visible = false;
                textBox102.Visible = false;
                textBox103.Visible = false;

            }
            else if (comboBox1.SelectedItem.Equals(b))
            {
                textBox95.Visible = true;
                textBox96.Visible = true;
                textBox97.Visible = false;
                textBox98.Visible = true;
                textBox99.Visible = true;
                textBox100.Visible = false;
                textBox101.Visible = false;
                textBox102.Visible = false;
                textBox103.Visible = false;

            }


            else if (comboBox1.SelectedItem.Equals(d))
            {
                textBox95.Visible = true;
                textBox96.Visible = true;
                textBox97.Visible = true;
                textBox98.Visible = false;
                textBox99.Visible = false;
                textBox100.Visible = false;
                textBox101.Visible = false;
                textBox102.Visible = false;
                textBox103.Visible = false;

            }

        }

        public void comboBox2_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            //combobox2 to choose which TextBoxes depends on the user Matrix of choice
            string i = "3 x 3";
            string j = "3 x 2";
            string k = "3 x 1";
            string l = "2 x 3";
            string m = "2 x 2";
            string n = "1 x 3";



            if (comboBox2.SelectedItem.Equals(i))
            {
                textBox104.Visible = true;
                textBox105.Visible = true;
                textBox106.Visible = true;
                textBox107.Visible = true;
                textBox108.Visible = true;
                textBox109.Visible = true;
                textBox110.Visible = true;
                textBox111.Visible = true;
                textBox112.Visible = true;




            }
            else if (comboBox2.SelectedItem.Equals(j))
            {
                textBox104.Visible = true;
                textBox105.Visible = true;
                textBox106.Visible = false;
                textBox107.Visible = true;
                textBox108.Visible = true;
                textBox109.Visible = false;
                textBox110.Visible = true;
                textBox111.Visible = true;
                textBox112.Visible = false;

            }
            else if (comboBox2.SelectedItem.Equals(k))
            {
                textBox104.Visible = true;
                textBox105.Visible = false;
                textBox106.Visible = false;
                textBox107.Visible = true;
                textBox108.Visible = false;
                textBox109.Visible = false;
                textBox110.Visible = true;
                textBox111.Visible = false;
                textBox112.Visible = false;

            }
            else if (comboBox2.SelectedItem.Equals(l))
            {

                textBox104.Visible = true;
                textBox105.Visible = true;
                textBox106.Visible = true;
                textBox107.Visible = true;
                textBox108.Visible = true;
                textBox109.Visible = true;
                textBox110.Visible = false;
                textBox111.Visible = false;
                textBox112.Visible = false;

            }
            else if (comboBox2.SelectedItem.Equals(m))
            {
                textBox104.Visible = true;
                textBox105.Visible = true;
                textBox106.Visible = false;
                textBox107.Visible = true;
                textBox108.Visible = true;
                textBox109.Visible = false;
                textBox110.Visible = false;
                textBox111.Visible = false;
                textBox112.Visible = false;

            }


            else if (comboBox2.SelectedItem.Equals(n))
            {
                textBox104.Visible = true;
                textBox105.Visible = true;
                textBox106.Visible = true;
                textBox107.Visible = false;
                textBox108.Visible = false;
                textBox109.Visible = false;
                textBox110.Visible = false;
                textBox111.Visible = false;
                textBox112.Visible = false;

            }
        }

        private void button22_Click(object sender, EventArgs e)
        {
            //Multiplication starts from here
            TextBox[] array = new TextBox[18];
            array[0] = textBox95;
            array[1] = textBox96;
            array[2] = textBox97;
            array[3] = textBox98;
            array[4] = textBox99;
            array[5] = textBox100;
            array[6] = textBox101;
            array[7] = textBox102;
            array[8] = textBox103;
            array[9] = textBox104;
            array[10] = textBox105;
            array[11] = textBox106;                                                                                                     //(tx95 tx96 tx97       tx104 tx105 tx106
            array[12] = textBox107;                                                                                                     // tx98 tx99 tx100      tx107  tx108 tx109
            array[13] = textBox108;                                                                                                     // tx101 tx102 tx103    tx 110 tx 111 tx 112
            array[14] = textBox109;
            array[15] = textBox110;
            array[16] = textBox111;
            array[17] = textBox112;


            if (array[0].Text != "" || array[1].Text != "" || array[2].Text != "" || array[3].Text != "" || array[4].Text != "" || array[5].Text != "" || array[6].Text != "" || array[7].Text != "" || array[8].Text != "" || array[9].Text != "" || array[10].Text != "" || array[11].Text != "" || array[12].Text != "" || array[13].Text != "" || array[14].Text != "" || array[15].Text != "" || array[16].Text != "" || array[17].Text != "")
            {
                // deleting the boxes that don't appear and then rewrite them with Zeros to stop getting errors
                for (int i = 0; i < array.Length; i++)
                {
                    
                    if (array[i].Visible == false)
                    {
                        array[i].Text = String.Empty;

                    }
                    if (array[i].Text == "")
                    {

                        array[i].Text = "0";
                        
                    }
                }
                // putting the answers in the answer textboxes
                    double a = ((double.Parse(textBox95.Text)) * (double.Parse(textBox104.Text))) + (double.Parse(textBox96.Text)) * (double.Parse(textBox107.Text)) + ((double.Parse(textBox97.Text)) * (double.Parse(textBox110.Text)));
                    double b = ((double.Parse(textBox95.Text)) * (double.Parse(textBox105.Text))) + (double.Parse(textBox96.Text)) * (double.Parse(textBox108.Text)) + ((double.Parse(textBox97.Text)) * (double.Parse(textBox111.Text)));
                    double c = ((double.Parse(textBox95.Text)) * (double.Parse(textBox106.Text))) + (double.Parse(textBox96.Text)) * (double.Parse(textBox109.Text)) + ((double.Parse(textBox97.Text)) * (double.Parse(textBox112.Text)));
                    double x = ((double.Parse(textBox98.Text)) * (double.Parse(textBox104.Text))) + (double.Parse(textBox99.Text)) * (double.Parse(textBox107.Text)) + ((double.Parse(textBox100.Text)) * (double.Parse(textBox110.Text)));
                    double y = ((double.Parse(textBox98.Text)) * (double.Parse(textBox105.Text))) + (double.Parse(textBox99.Text)) * (double.Parse(textBox108.Text)) + ((double.Parse(textBox100.Text)) * (double.Parse(textBox111.Text)));
                    double z = ((double.Parse(textBox98.Text)) * (double.Parse(textBox106.Text))) + (double.Parse(textBox99.Text)) * (double.Parse(textBox109.Text)) + ((double.Parse(textBox100.Text)) * (double.Parse(textBox112.Text)));
                    double q = ((double.Parse(textBox101.Text)) * (double.Parse(textBox104.Text))) + (double.Parse(textBox102.Text)) * (double.Parse(textBox107.Text)) + ((double.Parse(textBox103.Text)) * (double.Parse(textBox110.Text)));
                    double j = ((double.Parse(textBox101.Text)) * (double.Parse(textBox105.Text))) + (double.Parse(textBox102.Text)) * (double.Parse(textBox108.Text)) + ((double.Parse(textBox103.Text)) * (double.Parse(textBox111.Text)));
                    double k = ((double.Parse(textBox101.Text)) * (double.Parse(textBox106.Text))) + (double.Parse(textBox102.Text)) * (double.Parse(textBox109.Text)) + ((double.Parse(textBox103.Text)) * (double.Parse(textBox112.Text)));

                    textBox113.Text = a.ToString();
                    textBox114.Text = b.ToString();
                    textBox115.Text = c.ToString();
                    textBox116.Text = x.ToString();
                    textBox117.Text = y.ToString();
                    textBox118.Text = z.ToString();
                    textBox119.Text = q.ToString();
                    textBox120.Text = j.ToString();
                    textBox121.Text = k.ToString();


               








            }
            //here deteting the 0 valuses since it have no use in the matrix except the 0 included in the matrix itself
            TextBox[] array1 = new TextBox[9];
            array1[0] = textBox113;
            array1[1] = textBox114;
            array1[2] = textBox115;
            array1[3] = textBox116;
            array1[4] = textBox117;
            array1[5] = textBox118;
            array1[6] = textBox119;
            array1[7] = textBox120;
            array1[8] = textBox121;
            for (int w = 0; w < array1.Length; w++)
            {
                if (array1[w].Text == "")
                {

                    array1[w].Text = "0";
                }
                if (array1[w].Text == "0")
                {
                    array1[w].Visible = false;

                }
                else if (array1[w].Visible == false)
                {
                    array1[w].Text = String.Empty;
                    array1[w].Visible = true;
                    

                }
               

            }
            
        }
        // determinate 2x2 textboxes.
        private void button24_Click(object sender, EventArgs e)
        {
            textBox1.Visible = true;
            textBox2.Visible = true;
            textBox3.Visible = true;
            textBox4.Visible = true;
            textBox5.Visible = true;
            textBox6.Visible = true;
            textBox7.Visible = true;
            textBox8.Visible = true;
            textBox9.Visible = true;
            textBox122.Visible = false;
            textBox123.Visible = false;
            textBox124.Visible = false;
            textBox125.Visible = false;
        }

        private void button25_Click(object sender, EventArgs e)
        {
            textBox1.Visible = false;
            textBox2.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            textBox5.Visible = false;
            textBox6.Visible = false;
            textBox7.Visible = false;
            textBox8.Visible = false;
            textBox9.Visible = false;
            textBox122.Visible = true;
            textBox123.Visible = true;
            textBox124.Visible = true;
            textBox125.Visible = true;
        }

        private void button26_Click(object sender, EventArgs e)
        {
            textBox113.Visible = true;
            textBox114.Visible = true;
            textBox115.Visible = true;
            textBox116.Visible = true;
            textBox117.Visible = true;
            textBox118.Visible = true;
            textBox119.Visible = true;
            textBox120.Visible = true;
            textBox121.Visible = true;
            
        }
    }
}

