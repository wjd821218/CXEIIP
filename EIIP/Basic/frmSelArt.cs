using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using EIIP.Common;

namespace EIIP.Basic
{
    public partial class frmSelArt : frmBasicSel
    {
        public frmSelArt()
        {
            InitializeComponent();
        }
        public override void Valid()
        {
            string sArtId = ((DataRowView)(gridView1.GetFocusedRow())).Row["ARTID"].ToString();
        }
    }
}
