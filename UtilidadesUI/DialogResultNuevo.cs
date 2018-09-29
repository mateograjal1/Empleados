using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UtilidadesUI
{
    public class DialogResultNuevo
    {
        private DialogResult dialogResult;
        private object data;

        public DialogResult DialogResult { get => dialogResult; set => dialogResult = value; }
        public object Data { get => data; set => data = value; }

        public DialogResultNuevo(DialogResult dialogResult, object data)
        {
            this.dialogResult = dialogResult;
            this.data = data;
        }
    }
}
