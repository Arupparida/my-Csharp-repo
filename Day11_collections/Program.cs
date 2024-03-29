﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day11_collections
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //creating a list of integers
            List<int> New_List = new List<int>();
            //<int> Nlist = new <int>
            //adding items to list
            for(int i = 0; i<10;i++)
            {
                New_List.Add(i * 3);                
            }         
            //display list items
            foreach (var items in New_List)
            {
                Console.WriteLine(items);
            }
            
            
            //starting all non generic collections 
            //creating arraylist 
            //arraylist - It is similar to array but array list can store more than one datatype.
            //comment section not in use for Csharp collection section '
            ArrayList al =  new ArrayList();
            string sent =  "This is today's push";
            int x =  7;
            DateTime d = DateTime.Parse("10-Oct-2022");
            al.Add(sent);
            al.Add(x);
            al.Add(d);
            
            foreach(object obj in al){
                Response.Write (obj);
                Resonse.Write("<br>");
            }
            
            
            
            //creating hashtable 
            //hashtable - It is similar to arraylist but represents item as a combination of a key and value. 
            Hashtable ht = new Hashtable();
            ht.Add("ora", "orange");
            ht.Add("pine","pineapple");
            ht.Add("app","apple");
            ht.Add("bana","Banana");
            
            foreach(DictionaryEntry d in ht)
                //DictionaryEntry is a class whose objects represents key and value pairs.
            {
                Response.Write(d.key + " " + d.Value);
                Response.Write("<br>");
                    
            }
            
            
            //creating sorted list 
            SortedList Sl1 = new SortedList();
            sl1.Add("ora" , "Orange");
            sl1.Add("pine", "pineapple");
            sl1.Add("app", "apple");
            sl1.Add("bana","Banana");
            
            foreach(DictionaryEntry d in ht)
            {
                Response.Write(d.key + " " + d.Value);
                Resposne.Write("<br>");
                    
            }
            
            
            
                
            
        }
    }
}
