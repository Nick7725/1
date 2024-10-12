using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _1
{
    class discep
    {
        string name = "history";
        int hours = 144;
        int groupenum = 30;
        int semestri = 3;
        string tipexam = "exam";
        public discep(string n, int h, int g, int s, string ex)
    {
            name = n;
            hours = h;
            groupenum = g;
            semestri = s;
            tipexam = ex;

    }
        public string GetName()
        {
            return name;
        }
        public void SetName(string value)
        {
            if (Regex.IsMatch(value, "^[А-ЯЁ][а-яё]{2,}$"))
            {
                name = value;
            }
            else
            {
                throw new Exception("Wrong format!");
            }
        }
        public int Gethours()
        {
            return hours;
        }
        //public void SetName(string value)
        //{
        //    name = value;
        //}
        public string GetFullString()
        {
            return $"Название: {name}, часы: {hours}, количество групп: {groupenum}, количество семестров: {semestri}, тип экзамена: {tipexam}";
        }
    }
    
}
