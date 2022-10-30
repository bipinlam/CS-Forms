using System.Data;

namespace project_notes
{
    public partial class Form1 : Form
    {

        DataTable notes = new DataTable();  
        bool editing = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            titleBox.Text = notes.Rows[previousNotes.CurrentCell.RowIndex].ItemArray[0].ToString();
            noteBox.Text = notes.Rows[previousNotes.CurrentCell.RowIndex].ItemArray[1].ToString();
            editing = true;

        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            try
            {

                notes.Rows[previousNotes.CurrentCell.RowIndex].Delete(); 


            }
            catch(Exception ex) { Console.WriteLine("Not a valid note"); }

        }

        private void newNoteButton_Click(object sender, EventArgs e)
        {
            titleBox.Text = "";
            noteBox.Text = "";

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if(editing)
                {
                    notes.Rows[previousNotes.CurrentCell.RowIndex]["Title"] = titleBox.Text;
                    notes.Rows[previousNotes.CurrentCell.RowIndex]["Note"] = noteBox.Text;
                }
                else
                {
                    notes.Rows.Add(titleBox.Text, noteBox.Text);
                }
                titleBox.Text = "";
                noteBox.Text = "";
                editing = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            notes.Columns.Add("Title");
            notes.Columns.Add("Note");

            previousNotes.DataSource = notes;
        }

        private void previousNotes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            titleBox.Text = notes.Rows[previousNotes.CurrentCell.RowIndex].ItemArray[0].ToString();
            noteBox.Text = notes.Rows[previousNotes.CurrentCell.RowIndex].ItemArray[1].ToString();
            editing = true;


        }
    }
}