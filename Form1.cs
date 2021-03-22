using System;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        double skat = 0.39;
        double am = 0.08;
        double indkomst = 0;
        double fradrag = 0;
        double udbetaling = 0;
        public object Messagebox { get; private set; }

        public Form1()
        {
            InitializeComponent();
           
        
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }


        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                indkomst = double.Parse(indkomstbox.Text);
                fradrag = double.Parse(fradragbox.Text);
                udbetaling = indkomst - ((indkomst - fradrag) * skat);
                udbetaltlabel.Text = Convert.ToString(udbetaling);
                
            if (udbetaling < 10000)
            {

                udbetaltlabel.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                    udbetaltlabel.ForeColor = System.Drawing.Color.Green;
            }
                indkomstbox.Clear();
                fradragbox.Clear();
            }
            catch (Exception ex)
            {
                 MessageBox.Show("Exception catch here - details  : " + ex.ToString());
                indkomstbox.Clear();
                fradragbox.Clear();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try 
            {
                indkomst = double.Parse(indkomstbox.Text);
                fradrag = double.Parse(fradragbox.Text);
                udbetaling = indkomst - (indkomst * am) - ((indkomst - (indkomst * am) - fradrag) * skat);
                udbetaltlabel.Text = Convert.ToString(udbetaling);
            if (udbetaling < 17000)
            {

                udbetaltlabel.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                udbetaltlabel.ForeColor = System.Drawing.Color.Green;
            }
                indkomstbox.Clear();
                fradragbox.Clear();
            }   
            catch (Exception ex)
            {
                MessageBox.Show("Exception catch here - details  : " + ex.ToString());
                indkomstbox.Clear();
                fradragbox.Clear();
            }
          
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            string todo = textBox1.Text;
            if (textBox1.Text == "")
            {
                MessageBox.Show("  Skrive noget i tekstfeltet foroven");
            }
            else
            {
                todolist.Items.Add(todo);
                textBox1.Clear();
            }
        }

        private void todolist_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            todolist.Items.Remove(todolist.SelectedItem);

        }

        private void label9_Click_2(object sender, EventArgs e)
        {

        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
       

        }

        private void udbetaltlabel_Click(object sender, EventArgs e)
        {
        
            
        }
    }
}
