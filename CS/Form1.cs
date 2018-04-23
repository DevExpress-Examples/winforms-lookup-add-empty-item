using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.Xpo;
using DevExpress.XtraEditors;

namespace LookUpListWithNullEntry {
	public partial class Form1 : Form {
		public Form1() {
			InitializeComponent();

            FillData();

            this.repositoryItemLookUpEdit1.DataSource = new DataSourceWithEmptyItem(this.xpc2);
		}

        private void FillData() {
            if(xpc2.Count == 0) {
                Lookup lookup = new Lookup();
                lookup.Description = "Description 1";
                lookup.Save();
                xpc2.Add(lookup);
            }
        }

        private void repositoryItemLookUpEdit1_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e) {
            if(e.Button.Kind == DevExpress.XtraEditors.Controls.ButtonPredefines.Delete) {
                LookUpEdit editor = (LookUpEdit)sender;
                editor.CancelPopup();
                editor.EditValue = null;
            }
        }
	}

    public class Main : XPObject {
        public string Name;
        public Lookup Description;
    }

    public class Lookup : XPObject {
        public string Description;
    }
}