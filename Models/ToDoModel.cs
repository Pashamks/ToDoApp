using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDo.Models
{
    class ToDoModel: INotifyPropertyChanged
    {
        public DateTime CreationData { get; set; } = DateTime.Now;
        //[JsonProperty(PropertyName = "creationDate")]
        private bool _IsDone;
        //[JsonProperty(PropertyName = "isDone")]
        public bool IsDone
        {
            get { return _IsDone; }
            set {
                if (_IsDone == value)
                    return;
                _IsDone = value;
                OnPropertyChanged("IsDone");
            }
        }
        private string _text;

        public event PropertyChangedEventHandler PropertyChanged;
        //[JsonProperty(PropertyName = "text")]
        public string text
        {
            get { return _text; }
            set {
                if (_text == value)
                    return;
                _text = value;
                OnPropertyChanged("Text");
            }
        }

        protected virtual void OnPropertyChanged(string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
