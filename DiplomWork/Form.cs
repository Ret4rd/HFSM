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
using DiplomWork.HelpForms;

namespace DiplomWork
{
    public partial class Form : System.Windows.Forms.Form
    {

        //private List<Graphics> pictures = new List<Graphics> { };
        public static int butFlag = 0;
        public static List<string> itemList = new List<string>();

        List<HierarchicalFSM> allHierFSM = new List<HierarchicalFSM> { };
        //List<ControlHierarchicalFSM> allHierFSM = new List<ControlHierarchicalFSM> { };
        //List<FSM> allFSM = new List<FSM> { };

        SolidBrush c = new SolidBrush(Color.Black);
        Pen p = new Pen(Color.Black);

        public Form()
        {
            InitializeComponent();
        }

        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }
            //comboBoxItem.Items.Clear();
            var filePath = openFileDialog.FileName;
            itemList = Parser.Parse(filePath);
            /*for(int i = 0; i < itemList.Count; i++)
            {
                comboBoxItem.Items.Add(itemList[i]);
            }*/
            
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxItem_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*int i = 0;
            for(i = 0; i < tabControl.TabCount; i++)
            {
                if (comboBoxItem.Text == tabControl.TabPages[i].Text)
                {
                    tabControl.SelectTab(i);
                    return;
                }
            }

            var tabPage = new TabPage(comboBoxItem.Text);//создание tabPage с PaintBox
            tabPage.AutoScroll = true;
            tabPage.AutoScrollMinSize = new System.Drawing.Size(10000, 10000);//размеры tabPage
            //tabPage.AutoScrollMargin = new System.Drawing.Size(10, 10);
            tabPage.Tag = i;
            tabPage.BackColor = Color.White;
            tabPage.MouseDown += tabPage_MouseDown;
            //tabPage.Controls.Add(new PictureBox());
            tabControl.TabPages.Add(tabPage);
            tabControl.SelectTab(i);
            //pictures.Add(tabControl.SelectedTab.CreateGraphics());
            
            allHierFSM.Add(new HierarchicalFSM(tabPage.Text));//создание иерархических автоматов
            //allHierFSM.Add(new ControlHierarchicalFSM());
            //allHierFSM.Last().AddState(new FSM());*/
        }

        void tabPage_MouseDown(object sender, MouseEventArgs e)
        {
            if (tabControl.SelectedIndex != -1)
            {
                switch (butFlag)
                {
                    case 1:
                        //HierarchicalFSM hierFSM = new HierarchicalFSM();
                        allHierFSM[tabControl.SelectedIndex].AddState(e);
                        //allHierFSM[tabControl.SelectedIndex].PrintState(pictures, tabControl, p, e);
                        
                        tabControl.SelectedTab.Controls.Add(allHierFSM[tabControl.SelectedIndex].GetLastState());
                        //allHierFSM.Add(hier);
                        break;
                    case 2:
                        /*int index = allHierFSM[tabControl.SelectedIndex].WhereMouse();
                        if (index != -1)
                        {
                            allHierFSM[tabControl.SelectedIndex].GetState(index).fsm.AddState(e);
                            allHierFSM[tabControl.SelectedIndex].GetState(index).panel.Controls.Add(allHierFSM[tabControl.SelectedIndex].GetState(index).fsm.GetLastState());
                        }*/
                        //allHierFSM[tabControl.SelectedIndex].GetLastFSM().AddState(e);
                        //tabControl.SelectedTab.Controls.Add(allHierFSM[tabControl.SelectedIndex].GetLastFSM().GetLastState());
                        
                        //FSM auto = new FSM();
                        //auto.AddState(new ControlStateFSM(e));
                        //tabControl.SelectedTab.Controls.Add();//
                        //allHierFSM[tabControl.SelectedIndex].LastState().PrintState(pictures, tabControl, p, e);
                        break;
                    case 3:
                        break;
                }
                //Graphics pic = tabControl.SelectedTab.CreateGraphics();// tabControl.SelectedTab.Controls.Find("PictureBox1", false); pictureBox.CreateGraphics();
                //tabControl.SelectedTab.CreateGraphics()
                //SolidBrush d = new SolidBrush(Color.Red);
                
                
            }
        }

        private void tabControl_MouseDown(object sender, MouseEventArgs e)
        {
            
        }

        private void pictureBoxHierarchicalAuto_Click(object sender, EventArgs e)
        {
            pictureBoxHierarchicalAuto.BorderStyle = BorderStyle.Fixed3D;
            butFlag = 1;
        }

        private void pictureBoxAuto_Click(object sender, EventArgs e)
        {
            pictureBoxAuto.BorderStyle = BorderStyle.Fixed3D;
            butFlag = 2;
        }

        private void pictureBoxArrow_Click(object sender, EventArgs e)
        {
            pictureBoxArrow.BorderStyle = BorderStyle.Fixed3D;
            butFlag = 3;
        }

        private void labelItem_Click(object sender, EventArgs e)
        {

        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CreateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var winTab = new CreateTabForm())
            {
                var result = winTab.ShowDialog();
                if (result == DialogResult.OK)
                {
                    int i = 0;
                    for (i = 0; i < tabControl.TabCount; i++)
                    {
                        if (winTab.textBoxTab.Text == tabControl.TabPages[i].Text)
                        {
                            tabControl.SelectTab(i);
                            return;
                        }
                    }
                    var tabPage = new TabPage(winTab.textBoxTab.Text);//создание tabPage с PaintBox
                    tabPage.AutoScroll = true;
                    tabPage.AutoScrollMinSize = new System.Drawing.Size(1000, 10000);//размеры tabPage
                    tabPage.Tag = i;
                    tabPage.BackColor = Color.White;
                    tabPage.MouseDown += tabPage_MouseDown;
                    tabControl.TabPages.Add(tabPage);
                    tabControl.SelectTab(i);

                    allHierFSM.Add(new HierarchicalFSM(winTab.textBoxTab.Text));//создание иерархических автоматов
                }
            }

            

            
        }

        private void Form_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void Form_KeyDown(object sender, KeyEventArgs e)//масштабирование
        {
            if (e.KeyCode == Keys.Scroll && e.Control)
            {
                foreach(var HFSM in allHierFSM)
                {
                    //HFSM.
                }
                
                e.Handled = true;
            }
        }

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(tabControl.SelectedIndex == -1)
            {
                return;
            }
            string script = FromHFSMtoScript.GetScript(allHierFSM[tabControl.SelectedIndex]);
            if(script == null)
            {
                return;
            }
            if (openFileDialog.ShowDialog() == DialogResult.Cancel)
                return;
            var filePath = openFileDialog.FileName;
            try
            {
                if(openFileDialog.CheckFileExists)
                {
                    using (StreamWriter sw = new StreamWriter(filePath, true, System.Text.Encoding.Default))
                    {
                        sw.WriteLine(script);
                    }
                }
                else
                {
                    using (StreamWriter sw = new StreamWriter(filePath, false, System.Text.Encoding.Default))
                    {
                        sw.WriteLine("import java.net.URI");
                        sw.WriteLine(script);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
