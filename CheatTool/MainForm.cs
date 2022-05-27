using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace CheatTool
{

	public partial class MainForm : Form
	{
		#region DLL IMPORT
		[System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern bool RegisterHotKey(IntPtr hWnd, int id, int fsModifiers, int vk);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern bool UnregisterHotKey(IntPtr hWnd, int id);
        #endregion
        
       	#region Key Modifier
        enum KeyModifier
        {
            None = 0,
            Alt = 1,
            Control = 2,
            Shift = 4,
            WinKey = 8
        }
        #endregion
        
        #region Variables
        internal static bool tHide;
        internal bool dragging = false;
		internal Point pointClicked;
		#endregion
		
		#region Main Constructor
		public MainForm()
		{
			InitializeComponent();
			richTextBox1.BackColor = Color.FromArgb(100,100,100);
			BackColor = Color.FromArgb(100,100,100);
			TransparencyKey = Color.FromArgb(100,100,100);
			TopMost = true;
			tHide = true;
    		RegisterHotKey(this.Handle, 0, (int)KeyModifier.None, Keys.CapsLock.GetHashCode());
    		RegisterHotKey(this.Handle, 1, (int)KeyModifier.None, Keys.Z.GetHashCode());
    		//RegisterHotKey(this.Handle, 2, (int)KeyModifier.Control, Keys.S.GetHashCode());
		}
		#endregion
		
		#region HotKey WndProc
		protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (m.Msg == 0x0312)
            {
                Keys key = (Keys)(((int)m.LParam >> 16) & 0xFFFF);                  // The key of the hotkey that was pressed.
                KeyModifier modifier = (KeyModifier)((int)m.LParam & 0xFFFF);       // The modifier of the hotkey that was pressed.
                int id = m.WParam.ToInt32();                                        // The id of the hotkey that was pressed.
                switch(m.WParam.ToInt32()){
                	case 0:
                		if (!tHide){
                			this.Visible = true;
                			tHide = true;
                		} else {
                			this.Visible = false;
                			tHide = false;
                		}
                		break;
                	case 1:
						Environment.Exit(0);
                		break;
                	case 2:
                		richTextBox1.SaveFile("C:/NewData.dat");
                		break;
                }
                
            }
        }
		#endregion

		#region MouseButtonDown
		void MoveMouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left){
            	dragging = true;
            	pointClicked = new Point(e.X, e.Y);
			} else {
				dragging = false;
			}
		}
		#endregion
		
		#region MouseMove
		void MoveMouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			if (dragging){
            Point pointMoveTo;
            pointMoveTo = this.PointToScreen(new Point(e.X, e.Y));
            pointMoveTo.Offset(-pointClicked.X, -pointClicked.Y);
            this.Location = pointMoveTo;
        	} 
		}
		#endregion
		
		#region MouseButtonUp
		void MoveMouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			dragging = false;	
		}
		#endregion
		
		#region MouseClick
		void MoveMouseClick(object sender, MouseEventArgs e)
		{
			switch (e.Button)
			{
					case MouseButtons.Right:
						Environment.Exit(0);
					break;
			}
		}
		#endregion
		
		#region MouseDoubleClick
		void MoveFormMouseDoubleClick(object sender, MouseEventArgs e)
		{
			switch (e.Button)
			{
					case MouseButtons.Left:
					if (this.TopMost == true){
						this.TopMost = false;
					} else {
						this.TopMost = true;
					}
					break;
			}
		}
		#endregion
		
		void ComboBox1SelectedIndexChanged(object sender, EventArgs e)
		{
			richTextBox1.Focus();
			try
			{
				richTextBox1.LoadFile(comboBox1.SelectedIndex.ToString() + ".dat");
			} catch {
				MessageBox.Show(@"Can't read '" + comboBox1.SelectedIndex.ToString() + ".dat'");
				Environment.Exit(0);
			}
		}
		
		void ComboBox1KeyDown(object sender, KeyEventArgs e)
		{
			if(e.KeyCode == Keys.Z)
			{
				Environment.Exit(0);
			}
		}
		
		void MoveFormClick(object sender, EventArgs e)
		{
		}
	
	}
}
