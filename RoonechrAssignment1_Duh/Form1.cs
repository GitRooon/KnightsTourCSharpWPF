using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RoonechrAssignment1_Duh
{
    public partial class Form1 : Form
    {

        void AppendText(RichTextBox box, Color color, string text)
        {
            int start = box.TextLength;
            box.AppendText(text);
            int end = box.TextLength;

            // Textbox may transform chars, so (end-start) != text.Length
            box.Select(start, end - start);
            {
                box.SelectionColor = color;
                // could set box.SelectionBackColor, box.SelectionFont too.
            }
            box.SelectionLength = 0; // clear
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            try {
                int xPos = Convert.ToInt32(xposTbox.Text);
                int yPos = Convert.ToInt32(yPosTbox.Text);
                int iterations = Convert.ToInt32(iterationsTbox.Text);
                List<string> results = new List<string>();
                List<int> moves = new List<int>();

                if (iterations > 0) { 

                for (int i = 0; i < iterations; i++)
                {
                    int numberofMoves = 0;
                    Knight k = new Knight(xPos, yPos);

                    if (dumbRadio.Checked)
                    {
                        do
                        {
                            moves = k.getMoves();
                            k.doMove();
                            numberofMoves++;
                        }
                        while (moves.Count > 0);


                        // if (iterations == 1)
                        //{
                        for (int x = 0; x < 8; x++)
                        {
                            for (int j = 0; j < 8; j++)
                            {
                                string num = k.movesDone[x, j].ToString();
                                if (k.movesDone[x, j] < 10)
                                {
                                    num = "0" + num;

                                }

                                    if (k.movesDone[x, j] == numberofMoves)
                                    {
                                        richTextBox1.AppendText(num + " ");
                                       
                                        //richTextBox1.Select(k.movesDone[x+1, j+1],2);
                                        richTextBox1.SelectionColor = Color.Red;
                                       // AppendText(richTextBox1, Color.Red, num + " ");
                                    }

                                    else
                                    {
                                       // richTextBox1.Text += (num + ", ");
                                        AppendText(richTextBox1, Color.Black, num + " ");
                                    }
                                }

                            richTextBox1.Text += "\n";

                        }

                        richTextBox1.Text += "\n";
                            //}

                            if (iterations > 1)
                            {
                                richTextBox1.Text = "";
                            }

                        int trial = i + 1;
                        string trialResult = "Knight " + trial + " did " + numberofMoves + " moves";
                        results.Add(trialResult);


                    }//end of dumb Radio

                    if (smartRadio.Checked)
                    {
                        do
                        {
                            moves = k.getMoves();
                            k.moveSmart();
                            numberofMoves++;
                        }
                        while (moves.Count > 0);


                        //  if (iterations == 1)
                        // {
                        for (int x = 0; x < 8; x++)
                        {
                            for (int j = 0; j < 8; j++)
                            {
                                string num = k.movesDone[x, j].ToString();
                                if (k.movesDone[x, j] < 10)
                                {
                                    num = "0" + num;

                                }
                                richTextBox1.Text += (num + ", ");
                                 

                            }

                            richTextBox1.Text += "\n";

                        }
                        richTextBox1.Text += "\n";
                            //}

                            if (iterations > 1)
                            {
                                richTextBox1.Text = "";
                            }

                            int trial = i + 1;
                        string trialResult = "Knight " + trial + " did " + numberofMoves + " moves";

                        results.Add(trialResult);


                    }//end of smart method loop


                }//end of for loops

                for (int z = 0; z < results.Count; z++)
                {
                    richTextBox1.Text += results[z] + "\n";
                }

                using (StreamWriter writer = new StreamWriter("Output.txt"))
                { }
                using (StreamWriter writer = new StreamWriter("Output.txt", true)) {

                    writer.WriteLine("Last trial results: ");
                    for (int z = 0; z < results.Count; z++)
                    {
                        writer.WriteLine(results[z]);
                    }
                }//stream wrtie done
            }//end of if >0
                else
                {
                    var error = MessageBox.Show("Please input integer between 0-7 for position, and posotive integer for iterations", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex )
            {
                var error =  MessageBox.Show("Please input integer between 0-7 for position, and integer for iterations","Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {

           
        }
    }
}
