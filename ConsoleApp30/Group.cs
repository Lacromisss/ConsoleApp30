using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp30
{
    internal class Group
    {
        public Group(string noo, string studentlimittt)
        {
            this._no = noo;
            this._studentlimit = studentlimittt;
        }

        private string __no;
        private string _password;

        public string _no
        {
            get => this.__no;
            set
            {
                if (!string.IsNullOrWhiteSpace(value) && value.Length==5)
                    this.__no = value;
            }
        }
        public string _studentlimit
        {
            get => this._studentlimit;
            set
            {
                if (HasDigit1(value))
                    this._studentlimit = value;
            }
        }





        public bool HasUpper(string str)
        {
            int count = 0;
            if (!string.IsNullOrWhiteSpace(str))
            {
                for (int i = 0; i < str.Length; i++)
                {
                    if (char.IsUpper(str[i]))
                        count++;
                }
                if (count==2)
                {
                    return true;

                }
            }

            return false;
        }
        public bool Hasnumber(string str)
        {
            int count = 0;
            if (!string.IsNullOrWhiteSpace(str))
            {
                for (int i = 0; i < str.Length; i++)
                {
                    if (char.IsDigit (str[i]))
                        count++;
                }
                if (count == 3)
                {
                    return true;

                }

            }

            return false;
        }
        public bool HasDigit1(string str)
        {
            if (!string.IsNullOrWhiteSpace(str))
            {
                for (int i = 0; i < str.Length; i++)
                {
                    if (char.IsDigit(str[i]))
                        return true;
                }
            }


            return false;
        }







    }





    }

    

    
    
    
    
    

