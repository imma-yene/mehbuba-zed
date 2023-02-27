using calculation;

namespace TestDill
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
           
        }
        Calculate calculate = new Calculate();

        private void button1_Click(object sender, EventArgs e)
        {
            
            try
            {
                int ans = calculate.addtion(int.Parse(textBox1.Text), int.Parse(textBox2.Text));
    
            textBox3.Text = ans.ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show("please enter the numbers");
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                
 int ans=calculate.subtract( int.Parse(textBox1.Text),int.Parse(textBox2.Text));
            textBox3.Text=ans.ToString();
                
            }
            catch(Exception EX)
            {
                MessageBox.Show("please enter the numbers");
            }
           

        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1 == null || textBox2 == null)
                {

                    textBox3.Text = "please enter number";

                }

                else
                {
                    int ans = calculate.addtion(int.Parse(textBox1.Text), int.Parse(textBox2.Text));
                    textBox3.Text = ans.ToString();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("please enter the numbers");
            }
           
        }

        private void subtructToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                    int ans = calculate.subtract(int.Parse(textBox1.Text) , int.Parse(textBox2.Text));
                    textBox3.Text = ans.ToString();
                }
            
            catch(Exception EX)
            {
                MessageBox.Show("please enter the numbers");
            }
        }

        private void multiplyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {



                    int ans =calculate.multiply( int.Parse(textBox1.Text) , int.Parse(textBox2.Text));
                    textBox3.Text = ans.ToString();
                
            }
            catch(Exception EX) { 
            MessageBox.Show("please enter the numbers");
            }
        }

        private void divideToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {



                int num1 = int.Parse(textBox1.Text);
                int num2 = int.Parse(textBox2.Text);
                if (num2 == 0)
                {
                    textBox3.Text = "can't divide by 0";
                }
                else
                {
                    double ans=calculate.divide(num1, num2);
                    textBox3.Text = ans.ToString();
                }
            }
            catch(Exception EX)
            {
                MessageBox.Show("please enter the numbers");
            }
        }
    }
}