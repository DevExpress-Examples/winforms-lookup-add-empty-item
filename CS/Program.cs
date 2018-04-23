using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.ComponentModel;
using System.Collections;
using System.Data;
using DevExpress.Xpo;
using DevExpress.Xpo.DB;

namespace LookUpListWithNullEntry {
	static class Program {
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() {
            InitDal();
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new Form1());
		}

        private static void InitDal() {
            InMemoryDataStore provider = new InMemoryDataStore(new DataSet(), AutoCreateOption.DatabaseAndSchema);
            XpoDefault.DataLayer = new SimpleDataLayer(provider);
        }
	}
}