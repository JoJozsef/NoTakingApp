using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoTakingApp
{
    public partial class NoTaker : Form
    {
        DataTable notes = new DataTable();
        bool editing = false;
        public NoTaker()
        {
            InitializeComponent();
        }

        private void NoTaker_Load(object sender, EventArgs e)
        {
            notes.Columns.Add("Title");
            notes.Columns.Add("Note");

            prevNotes.DataSource = notes;
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            txtbTitle.Text = notes.Rows[prevNotes.CurrentCell.RowIndex].ItemArray[0].ToString();
            txtbNote.Text = notes.Rows[prevNotes.CurrentCell.RowIndex].ItemArray[1].ToString();

            editing = true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                notes.Rows[prevNotes.CurrentCell.RowIndex].Delete();
            }
            catch(Exception ex)
            {
                Console.WriteLine("Not a valid note");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (editing)
            {
                notes.Rows[prevNotes.CurrentCell.RowIndex]["Title"] = txtbTitle.Text;
                notes.Rows[prevNotes.CurrentCell.RowIndex]["Note"] = txtbNote.Text;
            }
            else
            {
                notes.Rows.Add(txtbTitle.Text, txtbNote.Text);
            }
            txtbTitle.Text = "";
            txtbNote.Text = "";
            editing = false;
        }

        private void btnNewNote_Click(object sender, EventArgs e)
        {
            txtbTitle.Text = "";
            txtbNote.Text = "";

        }

        private void prevNotes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtbTitle.Text = notes.Rows[prevNotes.CurrentCell.RowIndex].ItemArray[0].ToString();
            txtbNote.Text = notes.Rows[prevNotes.CurrentCell.RowIndex].ItemArray[1].ToString();
            editing = true;
        }
    }
}
