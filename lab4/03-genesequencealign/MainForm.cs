using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;


namespace GeneticsLab
{
    public partial class MainForm : Form
    {
        ResultTable m_resultTable;
        GeneSequence[] m_sequences;
        public const int NUMBER_OF_SEQUENCES = 10;
        const int PREFIX_SIZE = 100;
        const string GENOME_FILE = "genomes.txt";

        public MainForm()
        {
            bool failed = false;

            InitializeComponent();

            statusMessage.Text = "Loading Database...";

            // load database here

            try
            {
                m_sequences = loadFile("../../" + GENOME_FILE);
            }
            catch (FileNotFoundException)
            {
                try // Failed, try one level down...
                {
                    m_sequences = loadFile("../" + GENOME_FILE);
                }
                catch (FileNotFoundException)
                {
                    try // Failed, try same folder
                    {
                        m_sequences = loadFile(GENOME_FILE);
                    }
                    catch 
                    {
                        statusMessage.Text = "Failed to load database: " + GENOME_FILE + " not found.";
                        Refresh();
                        failed = true;
                    }
                }
            }

            if (!failed)
            {   
                string [] names = new string[NUMBER_OF_SEQUENCES];

                for (int i = 0; i < NUMBER_OF_SEQUENCES; i++)
                {
                    names[i] = m_sequences[i].Name;
                }
                m_resultTable = new ResultTable(this.dataGridViewResults, names);
                statusMessage.Text = "Loaded Database.";
            }
            else
            {
                processButton.Enabled = false;
            }
        }

        private GeneSequence[] loadFile(string fileName)
        {
            StreamReader reader = new StreamReader(fileName);
            string input = "";

            try
            {
                input = reader.ReadToEnd();
            }
            catch
            {
                Console.WriteLine("Error Parsing File...");
                return null;
            }
            finally
            {
                reader.Close();
            }

            GeneSequence[] temp = new GeneSequence[NUMBER_OF_SEQUENCES];
            string[] inputLines = input.Split('\r');

            for (int i = 0; i < NUMBER_OF_SEQUENCES; i++)
            {
                string[] line = inputLines[i].Replace("\n","").Split('#');
                temp[i] = new GeneSequence(line[0], line[1]);
            }
            return temp;
        }

        private void fillMatrix()
        {
            int alignLen = int.Parse(bandlengthBox.Text);
            ResultTable.Result result;
            PairWiseAlign processor = new PairWiseAlign(alignLen);
            for (int x = 0; x < NUMBER_OF_SEQUENCES; ++x)
            {
                for (int y = x; y < NUMBER_OF_SEQUENCES; ++y)
                {
                    result = processor.Align_And_Extract(m_sequences[x], m_sequences[y], bandCheckBox.Checked);                 // ********* hook to the student's code
                    m_resultTable.AddResult(x,y,result);
                    m_resultTable.DisplayResult(x, y);
                }
            }
        }

        private void cell_Click(object sender, DataGridViewCellEventArgs e)
        {
        // added this handler to display results in new textboxes when a cell is clicked in the results table
            string seq1, seq2;

            string sequence;
            try
            {
                seq1 = m_resultTable.GetCell(e.RowIndex, e.ColumnIndex).GetFirst();
            }
            catch(NullReferenceException)
            {
                seq1 = "";
            }
            try
            {
                seq2 = m_resultTable.GetCell(e.RowIndex, e.ColumnIndex).GetSecond();
            }
            catch
            {
                seq2 = "";
            }
            file1Box.Text = m_sequences[e.RowIndex].Name;
            try
            {
                sequence = seq1.Substring(0, Math.Min(seq1.Length,PREFIX_SIZE));
                if (seq1.Length > PREFIX_SIZE)
                    sequence = sequence + "...";
                sequence1Box.Text = sequence;
            }
            catch(NullReferenceException)
            {
                sequence1Box.Text = "";
            }
            try
            {
                sequence = seq2.Substring(0, Math.Min(seq2.Length, PREFIX_SIZE));
                if (seq2.Length > PREFIX_SIZE)
                    sequence = sequence + "...";
                sequence2Box.Text = sequence;
            }
            catch(NullReferenceException)
            {
                sequence2Box.Text = "";
            }
            file2Box.Text = m_sequences[e.ColumnIndex].Name;
        }

        private void processButton_Click(object sender, EventArgs e)
        {
            statusMessage.Text = "Processing...";
            Refresh();
            statusStrip1.PerformLayout();
            Stopwatch timer = new Stopwatch();
            timer.Start();
               fillMatrix();
            timer.Stop();
            statusMessage.Text = "Done.  Time taken: " + timer.Elapsed;
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
           //added this handler for the new clear button that clears table cells
            m_resultTable.Clear();
            file1Box.Text = "";
            sequence1Box.Text = "";
            sequence2Box.Text = "";
            file2Box.Text = "";
            Refresh();
        }
    }
}