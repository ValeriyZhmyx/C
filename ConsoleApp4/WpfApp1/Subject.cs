﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    public interface Subject
    {
        void registerObserver(Observer o);
        void removeObserver(Observer o);
        void notifyObservers();
    }
}
