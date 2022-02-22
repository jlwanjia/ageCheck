namespace ageCheck
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int birYr,birMt, birDy,curYr,curMt,curDy;
        bool borrw, birCheck, curCheck;
        private void button1_Click(object sender, EventArgs e)
        {
            
            birYr = Convert.ToInt32(textBox1.Text);
            
            birMt = Convert.ToInt32(textBox2.Text);
            
            birDy = Convert.ToInt32(textBox3.Text);
           
            curYr = Convert.ToInt32(textBox4.Text);
            
            curMt = Convert.ToInt32(textBox5.Text);
           
            curDy = Convert.ToInt32(textBox6.Text);

            birCheck = InpuCheck(birYr, birMt, birDy);
            if (birCheck == false)
            {
                textBox7.Text = "";
                return;               
            }
            
            curCheck = InpuCheck(curYr, curMt,curDy);
            if (curCheck == false)
            {
                textBox7.Text = "";
                return;
            }

            int ageDy;
            ageDy = curDy - birDy;

            if (ageDy < 0)
            {
                ageDy += 30;
                borrw = true;
            }
            int ageMt;
            ageMt = curMt - birMt;
            if (borrw)
            {
                ageMt -= 1;
                borrw = false;
            }
            if (ageMt < 0)
            {
                ageMt += 12;
                borrw = true;
            }
            int ageYr;
            ageYr = curYr - birYr;
            if (borrw)
            {
                ageYr -= 1;
                borrw = false;
            }
            if (ageYr < 0)
            {
                MessageBox.Show("Current value cannot be less than the Birth value");
                textBox7.Text = "";
                return;
            }

            textBox7.Text = ageYr.ToString() + "Year" + ageMt.ToString() + "Month" + ageDy.ToString() + "Day";
        }

        private  Boolean InpuCheck(int Yr, int Mt, int Dy)
        {

            if (Yr < 0)
            {
                MessageBox.Show("wrong input ");
                return false;
            }

            else if (Mt < 0)
            {
                MessageBox.Show("wrong input ");
                return false;
            }

            else if (Mt > 12)
            {
                MessageBox.Show("wrong input ");
                return false;
            }

            else if (Dy < 0)
            {
                MessageBox.Show("wrong input ");
                return false;
            }
            else if (Dy > 30)
            {
                MessageBox.Show("wrong input ");
                return false;
            }
            else
                return true;          

        }

    }
}