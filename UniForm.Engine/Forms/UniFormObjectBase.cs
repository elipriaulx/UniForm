using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace UniForm.Engine.Forms
{
    public abstract class UniFormObjectBase : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}