using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestClickApplication.UI
{
    internal class FormModel : INotifyPropertyChanged
    {
        uint m_clickCount = 0;
        string m_refreshedOn = string.Empty;
        Control control;

        public FormModel(Control control)
        {
            this.control = control;
        }

        #region INotifyPropertyChanged Members

        public event PropertyChangedEventHandler PropertyChanged;
        #endregion

        public uint ClickCount
        {
            get
            {
                return m_clickCount;
            }
            set
            {
                m_clickCount = value;
                control.Invoke(new Action(() =>
                {
                    PropertyChanged(
                        this,
                        new PropertyChangedEventArgs("ClickCount"));
                }));

            }
        }

        public string RefreshedOn
        {
            get
            {
                return m_refreshedOn;
            }
            set
            {
                m_refreshedOn = value;
                control.Invoke(new Action(() =>
                {
                    PropertyChanged(
                        this,
                        new PropertyChangedEventArgs("RefreshedOn"));
                }));

            }
        }
    }
}
