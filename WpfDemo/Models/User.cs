using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;

namespace WpfDemo.Models
{
    internal class User : ObservableObject
    {
        private int _id;
        public int Id 
        { 
            get 
            { 
                return _id; 
            } 
            set {
                _id = value; 
            } 
        }
    }
}
