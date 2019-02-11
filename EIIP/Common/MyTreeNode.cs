using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EIIP.Common
{
    class MyTreeNode: TreeNode
    {
        private int _Id;
        private string _MenuNo;
        private string _Name;
        private string _OperMode;
        private string _OperContex;
        private string _PermId;
        private string _ParentId;


        public int Id
        {
            set { _Id = value; }
            get { return _Id; }
        }
        public string MenuNo
        {
            set { _MenuNo = value; }
            get { return _MenuNo; }
        }
        public string Name
        {
            set { _Name = value; }
            get { return _Name; }
        }
        public string OperMode
        {
            set { _OperMode = value; }
            get { return _OperMode; }
        }

        public string OperContex
        {
            set { _OperContex = value; }
            get { return _OperContex; }
        }
        public string PermId
        {
            set { _PermId = value; }
            get { return _PermId; }
        }
        public string ParentId
        {
            set { _ParentId = value; }
            get { return _ParentId; }
        }
    }
}
