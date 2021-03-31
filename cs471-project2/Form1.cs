using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cs471_project2
{
    public partial class Form1 : Form
    {
        private MemoryList m = new MemoryList();
        private List<Process> plist = new List<Process>();
        private int spawncounter = 1;
        private bool processesCreated = false;
        private String id_tbTerm;
        private bool memorySetUp = false;

        public Form1()
        {
            this.Load += new EventHandler(Form1_Load);
            InitializeComponent();
        }

        private void Form1_Load(System.Object sender, System.EventArgs e)
        {
            SetupLayout();
            SetupDataGridView();

        }


        private void button1_Click(object sender, EventArgs e) //autogenerate
        {
            if (!processesCreated)
            {
                processesCreated = true;
            }
            FillGridWithProcesses();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (memorySetUp == true)
            {
                m.garbageCollection();
                BlockList_text.Text = m.getBlockList();
            }
            else
            {
                MessageBox.Show("Please choose a memory setup.", "Wait a second!");
            }
        }

        //Terminates the currently running process. Does not work if the Queue isnt running.
        private void button_Terminate_Click(object sender, EventArgs e)
        {       
            m.RemovefromBlockList(Convert.ToInt32(id_tbTerm));
            BlockList_text.Text = m.getBlockList();
        }

        private void createProcess_Button_Click(object sender, EventArgs e)
        {

            String processName = "gaming";
            String processSize = newProcessName_TextBox.Text;

            if (SanityCheck1(processSize))
            {
                spawncounter++;
                processName = spawncounter.ToString();
                string[] row0 = new string[2];
                Process process0 = new Process(spawncounter, processName, Convert.ToInt32(processSize));

                plist.Add(process0);

                row0[0] = process0.getID().ToString();
                row0[1] = process0.getSize().ToString();
                
                this.dataGridView1.Rows.Add(row0);

                if (!processesCreated)
                {
                    processesCreated = true;
                }
            }
        }

        private void SetUp_Button_Click(object sender, EventArgs e)
        {
            string selectedItem = "";
            bool ok = false;
            
            try
            {
                selectedItem = setup_selection_box.Items[setup_selection_box.SelectedIndex].ToString();
                ok = true;
            }
            catch
            {
                MessageBox.Show("Please choose a memory setup.", "Wait a second!");
                ok = false;
            }
            
           
            
            if (ok == true)
            {
                switch (selectedItem)
                {
                    case "1":
                        m.setupOption1();
                        memorySetUp = true;
                        break;
                    case "2":
                        m.setupOption2();
                        memorySetUp = true;
                        break;
                    case "3":
                        m.setupOption3();
                        memorySetUp = true;
                        break;
                    case "4":
                        m.setupOption4();
                        memorySetUp = true;
                        break;
                    default:
                        m.setupOption1();
                        memorySetUp = true;
                        break;
                }

                BlockList_text.Text = m.getBlockList();
            }
            
        }



        private void allocateButton_Click_1(object sender, EventArgs e)
        {
            bool attemptAdd = false;

            try
            {
                attemptAdd = m.AddProcesstoBlock(plist[0]);
            }
            catch 
            {
                MessageBox.Show("Please Create a Process", "Wait a second!");
            }

            if (attemptAdd == true)
            {
                plist.RemoveAt(0);
                this.dataGridView1.Rows.RemoveAt(0); 
            }
            else
                MessageBox.Show("Insufficient memory to load the top Process", "Wait a second!");

            BlockList_text.Text = m.getBlockList();

        }
        //Error Checking
        private bool SanityCheck1(String _size)
        {
            bool priflag = false;
            bool burflag = false;
            double Num;
            bool isNum;
            int size = 0;
            try { size = Convert.ToInt32(_size); }
            catch
            {
                MessageBox.Show("Please Enter a Value", "Wait a second!");
            }
            isNum = double.TryParse(_size, out Num);
            if (!isNum)
            {
                MessageBox.Show("Invalid Size Value", "Wait a second!");
                return priflag;
            }
            else
                priflag = true;

            //isNum = double.TryParse(bur, out Num);
            if (size < 1 ||size>5)
            {
                MessageBox.Show("Please Enter a value between 1 and 5", "Wait a second!");
            }
            else
                burflag = true;

            return priflag && burflag;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            id_tbTerm = textBox1.Text.ToString();
        }

        private void SetupLayout()
        {
            //this.Size = new Size(1450, 650);
            AutoCreate_button.Text = "AutoCreate";
            
        }

        private void SetupDataGridView()
        {
            dataGridView1.Name = "Program List";
            dataGridView1.ColumnCount = 2;

            dataGridView1.Columns[0].Name = "ID";
            dataGridView1.Columns[1].Name = "Size";
            dataGridView1.AutoSizeRowsMode =
                DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            dataGridView1.ColumnHeadersBorderStyle =
                DataGridViewHeaderBorderStyle.Single;
            dataGridView1.RowHeadersVisible = false;

        }
        
        private void FillGridWithProcesses()
        {
            var rand = new Random();

            Process process0 = new Process(spawncounter, "gaming" + spawncounter, rand.Next(1, 4));
            plist.Add(process0);


            string[] row0 = new string[2];
            spawncounter++;

            row0[0] = process0.getID().ToString();
            row0[1] = process0.getSize().ToString();

            this.dataGridView1.Rows.Add(row0);

            Process process1 = new Process(spawncounter, "gaming" + spawncounter, rand.Next(1, 4));
            plist.Add(process1);


            string[] row1 = new string[2];
            spawncounter++;

            row1[0] = process1.getID().ToString();
            row1[1] = process1.getSize().ToString();

            this.dataGridView1.Rows.Add(row1);

            Process process2 = new Process(spawncounter, "gaming" + spawncounter, rand.Next(1, 4));
            plist.Add(process2);


            string[] row2 = new string[2];
            spawncounter++;

            row2[0] = process2.getID().ToString();
            row2[1] = process2.getSize().ToString();

            this.dataGridView1.Rows.Add(row2);


            if (!processesCreated)
            {
                processesCreated = true;
            }
        }

    }
}
