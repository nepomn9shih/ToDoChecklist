﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoChecklist.Models
{
    class TodoModel:INotifyPropertyChanged
    {
        public DateTime CreationDate { get; set; } = DateTime.Now;

        private bool _isDone;

        public bool IsDone
        {
            get { return _isDone; }
            set {
                if (_isDone == value) return;
                
                _isDone = value;
                OnPropertyChanged("IsDone");
            }
        }

        private string _text;

        public event PropertyChangedEventHandler PropertyChanged;

        public string Text
        { get { return _text; }
          set {
                if (_text == value) return;
                _text = value;
                OnPropertyChanged("Text");
            }
        }

        protected virtual void OnPropertyChanged(string propertyName="")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
