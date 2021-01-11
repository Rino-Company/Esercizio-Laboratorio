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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace EsercizioGit
{
    public partial class Progetto : Form
    {
        public Progetto()
        {
            InitializeComponent();
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {

            if (textBox1.Text.Length < 1)
            {
                MessageBox.Show("Compilare tutti i campi obbligatori");
                return;
            }
            if (textBox2.Text.Length < 1)
            {
                MessageBox.Show("Compilare tutti i campi obbligatori");
                return;
            }
            int x = int.Parse(textBox1.Text) ;
            int y = int.Parse(textBox2.Text) ;

            //int[,] tabella = new int[x,y];

            dataGridView1.ColumnCount = y + 1;
            dataGridView1.ColumnHeadersVisible = true;

            dataGridView1.RowCount = x + 1;
            dataGridView1.RowHeadersVisible = true;
            dataGridView1.ReadOnly = true;
            for (int i = 0; i < x; i++)
            {
                dataGridView1.Rows[i].HeaderCell.Value = "Produttore" + (i + 1);
            }
            for (int i = 0; i < y; i++)
            {
                dataGridView1.Columns[i].HeaderCell.Value = "Consumatore" + (i + 1);
            }
            dataGridView1.RowHeadersWidth = 100;
            dataGridView1.Rows[x].HeaderCell.Value = "Fabbisogno";
            dataGridView1.Columns[y].HeaderCell.Value = "Produzione";

        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            dataGridView1.DataSource = null;
        }

        private void RandomButton_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length < 1)
            {
                MessageBox.Show("Compilare tutti i campi obbligatori");
                return;
            }
            if (textBox2.Text.Length < 1)
            {
                MessageBox.Show("Compilare tutti i campi obbligatori");
                return;
            }


            if (textBox3.Text.Length < 1)
            {
                MessageBox.Show("Compilare tutti i campi obbligatori");
                return;
            }
            if (textBox4.Text.Length < 1)
            {
                MessageBox.Show("Compilare tutti i campi obbligatori");
                return;
            }
            if (textBox5.Text.Length < 1)
            {
                MessageBox.Show("Compilare tutti i campi obbligatori");
                return;
            }
            if (textBox6.Text.Length < 1)
            {
                MessageBox.Show("Compilare tutti i campi obbligatori");
                return;
            }

            int x = int.Parse(textBox1.Text);
            int y = int.Parse(textBox2.Text);
            Random random = new Random();
            int Var1 = int.Parse(textBox3.Text);
            int Var2 = int.Parse(textBox4.Text);
            int Var3 = int.Parse(textBox5.Text);
            int Var4 = int.Parse(textBox6.Text);


            int count = 0;
            int count2 = 0;

            dataGridView1.RowCount = x + 1;
            dataGridView1.ColumnCount = y + 1;

            for (int r = 0; r < x ; r++)
            {
                for (int c = 0; c < y; c++)
                {
                    int n = random.Next(Var1, Var2+1);
                    dataGridView1.Rows[r].Cells[c].Value = n;
                }
            }
            for (int c2 = 0; c2 <= y - 1; c2++)
            {
                int n2 = random.Next(Var3, Var4+1);
                dataGridView1.Rows[x].Cells[c2].Value = n2;
                count = count + n2;
            }
            dataGridView1.Rows[x].Cells[y].Value = count;

            for (int r2 = 0; r2 < x-1; r2++)
            {
                int n2 = random.Next(Var3, Var4+1);
                dataGridView1.Rows[r2].Cells[y].Value = n2;
                count2 = count2 + n2;
            }
            dataGridView1.Rows[x-1].Cells[y].Value = count - count2;
            
        }

   
    }

        }
    
