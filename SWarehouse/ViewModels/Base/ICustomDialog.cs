using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWarehouse.ViewModels.Base
{
    public interface ICustomDialog
    {
        /// <summary>
        /// Is UserControl
        /// </summary>
        object ContentDialog { get; set; }
        /// <summary>
        /// Is Show Popup
        /// </summary>
        bool IsOpenDialog { get; set; }
        void OpenDialog(object uc);
        void CloseDialog();
    }
}
