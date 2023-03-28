using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace MiniManager
{
    public partial class mainForm : Form
    {
        int default_item_height = 40; // item height
        int default_item_loc_x = 1; // keep 1
        int default_item_loc_y = 160; // item location startpoint
        int default_item_spacer = 40; // spacer between item to item

        public Color idleText = Color.LightGray;
        public Color idleColor = Color.FromArgb(255, 35, 35, 40);
        public Color hoverColor = Color.FromArgb(255, 32, 32, 35);
        public Color selectColor = Color.FromArgb(255, 31, 31, 34);
        public Font idleFont = new Font("Bahnschrift Light", 11, FontStyle.Regular);

        public string[] tabContents = {
            "Client mods",
            "Server mods",
            "App settings",
            "Close"
        };

        public mainForm()
        {
            InitializeComponent();
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            clientModsPanel.Visible = false;
            serverModsPanel.Visible = false;
            appSettingsPanel.Visible = false;

            default_item_loc_y = tabPanel.Size.Height / 3;
            listSystem(tabPanel, tabContents);
        }

        private void clearUI(Panel control)
        {
            // server box
            for (int i = control.Controls.Count - 1; i >= 0; i--)
            {
                Label selected = control.Controls[i] as Label;
                if (selected != null)
                {
                    try
                    {
                        control.Controls.RemoveAt(i);
                        selected.Dispose();
                    }
                    catch (Exception err)
                    {
                        Debug.WriteLine($"ERROR: {err.ToString()}");
                        MessageBox.Show($"Oops! It seems like we received an error. If you're uncertain what it\'s about, please message the developer with a screenshot:\n\n{err.ToString()}", this.Text, MessageBoxButtons.OK);
                    }
                }
            }
        }

        public void listSystem(Control component, string[] arr)
        {
            clearUI(tabPanel);
            for (int i = 0; i < arr.Length; i++)
            {
                Label lbl = new Label();
                lbl.Text = arr[i];
                lbl.AutoSize = false;
                lbl.Anchor = (AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Right);
                lbl.TextAlign = ContentAlignment.MiddleLeft;
                lbl.Size = new Size(component.Size.Width - 2, default_item_height);
                lbl.Location = new Point(default_item_loc_x, default_item_loc_y + (i * default_item_spacer));
                lbl.Font = idleFont;
                lbl.BackColor = idleColor;
                lbl.ForeColor = idleText;
                lbl.Margin = new Padding(1, 1, 1, 1);
                lbl.Cursor = Cursors.Hand;
                lbl.MouseEnter += new EventHandler(lbl_MouseEnter);
                lbl.MouseLeave += new EventHandler(lbl_MouseLeave);
                lbl.MouseDown += new MouseEventHandler(lbl_MouseDown);
                lbl.MouseUp += new MouseEventHandler(lbl_MouseUp);
                lbl.TextAlign = ContentAlignment.MiddleCenter;
                lbl.Visible = true;
                component.Controls.Add(lbl);
            }
        }

        private void lbl_MouseEnter(object sender, EventArgs e)
        {
            System.Windows.Forms.Label label = (System.Windows.Forms.Label)sender;
            if (label.Text != "")
            {
                if (label.BackColor != selectColor)
                {
                    label.BackColor = hoverColor;
                }
            }
        }

        private void lbl_MouseLeave(object sender, EventArgs e)
        {
            System.Windows.Forms.Label label = (System.Windows.Forms.Label)sender;
            if (label.Text != "")
            {
                if (label.BackColor != selectColor)
                {
                    label.BackColor = idleColor;
                }
            }
        }

        private void lbl_MouseUp(object sender, EventArgs e)
        {
            System.Windows.Forms.Label label = (System.Windows.Forms.Label)sender;
            if (label.Text != "") { }
        }

        private void lbl_MouseDown(object sender, EventArgs e)
        {
            Control list = this.Controls["tabPanel"];

            clientModsPanel.Visible = true;
            serverModsPanel.Visible = true;
            appSettingsPanel.Visible = true;

            System.Windows.Forms.Label lbl = (System.Windows.Forms.Label)sender;

            if (lbl.Text != "")
            {
                foreach (Control component in list.Controls)
                {
                    if (component.Text.Contains("> "))
                    {
                        component.Text = component.Text.Remove(0, 2);
                    }

                    if (component is Label && component.Text != lbl.Text)
                    {
                        component.BackColor = idleColor;
                        component.ForeColor = idleText;
                    }
                }

                lbl.BackColor = selectColor;

                if (lbl.Text.ToLower() == "client mods")
                {
                    clientModsPanel.BringToFront();


                }
                else if (lbl.Text.ToLower() == "server mods")
                {
                    serverModsPanel.BringToFront();


                }
                else if (lbl.Text.ToLower() == "app settings")
                {
                    appSettingsPanel.BringToFront();


                }
                else if (lbl.Text.ToLower() == "close")
                {
                    Application.Exit();
                }

                /*
                string activeItem = lbl.Text;
                activeItem = "> " + activeItem;
                lbl.Text = activeItem;
                lbl.ForeColor = Color.DodgerBlue;
                */
            }
        }
    }
}
