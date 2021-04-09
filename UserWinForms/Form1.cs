using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _2K2SNP.Repositories;
using _2K2SNP.Units;
using Tools;

namespace UserWinForms
{
    public partial class Form1 : Form
    {
        private IRepository authorRepository { get; set; }
        private IRepository bookRepository { get; set; }
        public Form1()
        {
            InitializeComponent();
        }
        //
        //
        //Helpers
        //
        //
        void RefreshAuthorGrid() => Authors_dataGrid.DataSource = authorRepository.GetData().Cast<Author>().ToList();
        void RefreshBookGrid() => Books_dataGrid.DataSource = bookRepository.GetData().Cast<Book>().ToList();
        //
        //
        //
        //
        //

        private void Form1_Load(object sender, EventArgs e)
        {
            authorRepository = AppConfigurator.getFactory().createAuthorRepository();
            bookRepository = AppConfigurator.getFactory().createBookRepository(authorRepository);

            RefreshAuthorGrid();
            Authors_dataGrid.Columns[0].HeaderText = "Year Of Birth";
            Authors_dataGrid.Columns[1].HeaderText = "Year Of Death";
            Authors_dataGrid.Columns[2].HeaderText = "First Name";
            Authors_dataGrid.Columns[3].HeaderText = "Middle Name";
            Authors_dataGrid.Columns[4].HeaderText = "Last Name";

            Authors_dataGrid.Columns[0].DisplayIndex = 4;
            Authors_dataGrid.Columns[1].DisplayIndex = 4;
            
            RefreshBookGrid();

            Books_dataGrid.Columns[0].HeaderText = "Author";
            Books_dataGrid.Columns[1].HeaderText = "Title";
            Books_dataGrid.Columns[2].HeaderText = "Publication Year";
            Books_dataGrid.Columns[3].HeaderText = "Pages";

            Units_Tab_SelectedIndexChanged(Units_Tab,null);
        }

        
        private void Units_Tab_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch ((sender as TabControl).SelectedIndex)
            {
                case 0:
                    label1.Text = "First Name";
                    label2.Text = "Middle Name";
                    label3.Text = "Last Name";
                    label4.Text = "Year Of Birth";
                    label5.Text = "Year Of Death";
                    break;
                case 1:
                    label1.Text = "Author (Pos)";
                    label2.Text = "Title";
                    label3.Text = "Publication Year";
                    label4.Text = "Pages";
                    label5.Text = "ISBN";
                    break;
            }
        }

        private void Add_Button_Click(object sender, EventArgs e)
        {
            try
            {
                switch (Units_Tab.SelectedIndex)
                {
                    case 0:
                        authorRepository.Add(new Author(
                            Field1.Text,
                            Field2.Text,
                            Field3.Text,
                            int.Parse(Field4.Text),
                            int.Parse(Field5.Text)
                            )
                        );
                        RefreshAuthorGrid();
                        break;
                    case 1:
                        bookRepository.Add(new Book(
                                (Author)authorRepository[int.Parse(Field1.Text) - 1],
                                Field2.Text,
                                int.Parse(Field3.Text),
                                int.Parse(Field4.Text),
                                Field5.Text
                                )
                        );
                        RefreshBookGrid();
                        break;
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("Wrong Data", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Remove_button_Click(object sender, EventArgs e)
        {
            try
            {
                switch (Units_Tab.SelectedIndex)
                {
                    case 0:
                        authorRepository.Remove(int.Parse(ID_textBox.Text) - 1);
                        RefreshAuthorGrid();
                        break;
                    case 1:
                        bookRepository.Remove(int.Parse(ID_textBox.Text) - 1);
                        RefreshBookGrid();
                        break;
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("Wrong ID", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void Refresh_button_Click(object sender, EventArgs e)
        {
            switch (Units_Tab.SelectedIndex)
            {
                case 0:
                    RefreshAuthorGrid();
                    break;
                case 1:
                    RefreshBookGrid();
                    break;
            }
        }
    }
}
