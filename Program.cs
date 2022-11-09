using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Xml;

namespace NorthWind.Linq
{
    internal class Program
    {
       public static void Main(string[] args)
        {

            var repo = EmployeeRepository.CreateInstance();
            var employees = repo.GetAllEmployees();
            Employee[] employees_arr = employees;
            //Q1.
            //Console.WriteLine(employees.Count());

            // Q2.
            //for (int i = 0; i < employees_arr.Length; i++)
            //{
            //    Employee employee = employees_arr[i];
            //    string FirstNaame = employee.FirstName;
            //    string LastNaame = employee.LastName;
            //    Console.WriteLine(FirstNaame + " " + LastNaame);
            //}

            //Q3.
            //for (int i = 0; i < employees_arr.Length; i++)
            //{
            //    Employee employee = employees_arr[i];
            //    if (employee != null && employee.Title.Contains("Accountant"))
            //    { 
            //        Console.WriteLine(employee.FirstName+ " " +employee.LastName);
            //    }
            //}

            //Q4.
            //for (int i = 0; i < employees_arr.Length; i++)
            //{
            //    Employee employee = employees_arr[i];
            //    if (employee != null && employee.Title.Contains("Operations"))
            //    {
            //        Console.WriteLine(employee.DisplayName + " " + employee.HireDate);
            //    }
            //}

            //Q5
            //HashSet<string> Titles_set = new HashSet<string>();
            //for (int i = 0; i < employees_arr.Length; i++)
            //{
            //    Titles_set.Add(employees_arr[i].Title);
            //}
            //Console.WriteLine(Titles_set.Count);

            //Q6
            //HashSet<string> Titles_set = new HashSet<string>();
            //for (int i = 0; i < employees_arr.Length; i++)
            //{
            //    Titles_set.Add(employees_arr[i].Title);
            //}
            //foreach (string title in Titles_set)
            //    Console.WriteLine(title);

            //Q7

            //List<Employee> employees_list = employees.ToList();

            //employees_list.Sort(delegate (Employee x, Employee y)
            //{
            //    return x.DisplayName.CompareTo(y.DisplayName);
            //}
            //);
            //foreach (Employee employee in employees_list)
            //    Console.WriteLine(employee.ToPrettyString());

            //Q8

            //List<Employee> employees_list = employees.ToList();

            //employees_list.Sort(delegate (Employee x, Employee y)
            //{
            //    return x.DisplayName.CompareTo(y.DisplayName);
            //}
            //);
            //foreach (Employee employee in employees_list)
            //{
            //    if (employee.DisplayName.ToLower().StartsWith("j"))
            //    Console.WriteLine(employee.ToPrettyString());
            //}

            //Q9
            //int year = ((DateTime)employees_arr[0].HireDate).Year;
            //int month = ((DateTime)employees_arr[0].HireDate).Month;
            //int day = ((DateTime)employees_arr[0].HireDate).Day;
            //Employee oldest_employee = employees_arr[0];

            //for (int i = 1; i < employees_arr.Length; i++)
            //{
            //    Employee employee = employees_arr[i];

            //    if (employee!=null && employee.HireDate!=null && ((DateTime)employee.HireDate).Year < year)
            //    {
            //        if (((DateTime)employee.HireDate).Month < month)
            //        {
            //            if (((DateTime)employee.HireDate).Day < day)
            //            {
            //                year = ((DateTime)employee.HireDate).Year;
            //                month = ((DateTime)employee.HireDate).Month;
            //                day = ((DateTime)employee.HireDate).Day;
            //                oldest_employee = employees_arr[i];
            //            }
            //        }
            //    }
            //}    
            //            Console.WriteLine(oldest_employee.ToPrettyString());

            //Q10

            //Dictionary<string, int> dict = new Dictionary<string, int>();

            //foreach (Employee employee in employees)
            //{
            //    if (dict.ContainsKey(employee.Title))
            //        dict[employee.Title]++;
            //    else { dict.Add(employee.Title, 1); }
            //}
            //foreach (var item in dict.OrderByDescending(key => key.Value))
            //{
            //    Console.WriteLine(item);
            //}

            //Q11

            //Dictionary<string, int> dict_team_count = new Dictionary<string, int>();
            //Dictionary<string, string> dict_team_name = new Dictionary<string, string>();
            //foreach (Employee employee in employees)
            //{
            //    if (employee.Team.Equals(""))
            //        continue;
            //    if (!dict_team_name.ContainsKey(employee.Team))
            //        dict_team_name.Add(employee.Team, employee.TeamLeader);

            //    if (dict_team_count.ContainsKey(employee.Team))
            //        dict_team_count[employee.Team]++;
            //    else
            //        dict_team_count.Add(employee.Team, 1);
            //}
            //int i = 0;
            //string First = "";
            //string Last = "";
            //int dict_size = dict_team_count.Count - 1;

            //foreach (var item in dict_team_count.OrderByDescending(key => key.Value))
            //{
            //    if (i == 0)
            //        First = item.Key;
            //    if (i == dict_size)
            //        Last = item.Key;
            //    i++;

            //}

            //Console.WriteLine("HighestTeamLeaderName is {0}\nLowestTeamLeaderName is {1}", dict_team_name[First], dict_team_name[Last]);

            //Q12
            //foreach (Employee employee in employees_arr)
            //{
            //    if(employee.TeamLeader.Equals(""))
            //       Console.WriteLine(employee.ToPrettyString());
            //}

            //Q13

            //Dictionary<string, List<string>> dict_team_leader = new Dictionary<string, List<string>>();
            //foreach (Employee employee in employees_arr)
            //{
            //    if (!employee.TeamLeader.Equals(""))
            //    {
            //        List<string> employee_list;
            //        if (dict_team_leader.ContainsKey(employee.TeamLeader))
            //        {
            //           employee_list = dict_team_leader[employee.TeamLeader]; 
            //        }
            //        else
            //        {
            //           employee_list = new List<string>();  
            //        }
            //        employee_list.Add(employee.FirstName);
            //        dict_team_leader[employee.TeamLeader] = employee_list;
            //    }
            //}
            //foreach (KeyValuePair<string, List<string>>entry in dict_team_leader)
            //{
            //    Console.WriteLine(entry.Key);
            //    Console.WriteLine("------------------------------");
            //    string temp = "";
            //    foreach(string name in entry.Value)
            //    {
            //        temp+=name+",";
            //    }
            //    temp=temp.Substring(0,temp.Length-1)+"\n";
            //    Console.WriteLine(temp);
            //}

            //Q14
            //Dictionary<int, int> year_dict = new Dictionary<int, int>();

            //for (int i = 0; i < employees_arr.Length; i++)
            //{
            //    Employee employee = employees_arr[i];
            //    DateTime hire_date = (DateTime)employee.HireDate;
            //     int year = hire_date.Year;
            //    if (year_dict.ContainsKey(year))
            //    {
            //        year_dict[year]++;
            //    }
            //    else
            //    {
            //        year_dict.Add(year, 1);
            //    }
            //        Console.WriteLine(employee.DisplayName + " " + hire_date.Year);
            //}
            //int count = 0;
            //foreach (var item in year_dict.OrderByDescending(key => key.Value))
            //{
            //if (count == 3)
            //   break;
            // Console.WriteLine(item.Key+"-------"+item.Value);
            //    count++;
            //}

            //Q16.
            //List<Employee> employees_list = employees.ToList();
            //employees_list.Sort(delegate (Employee x, Employee y)
            //{
            //    return x.DisplayName.CompareTo(y.DisplayName);
            //}
            //);
            //int pagenumber = 1;
            //for(int i = 0; i < employees_list.Count; i++)
            //{
            //    if(i ==0 || i % 10 == 0)
            //    {
            //        Console.WriteLine("Page Number = "+pagenumber);
            //        Console.WriteLine("-----------------");
            //        Console.WriteLine("[");
            //    }
            //    Console.WriteLine("\"" + employees_list[i].DisplayName +"\"");
            //    if(((i+1) % 10) == 0)
            //    {
            //        Console.WriteLine("]");
            //        pagenumber++;   
            //    }
            //}    

            //Q17
            //    int sum = 0;
            //    for (int i = 0; i < employees_arr.Length; i++)
            //    {
            //        Employee employee = employees_arr[i];
            //        if (employee != null && employee.HireDate != null && ((DateTime)employee.HireDate).Year >= 2012)
            //        {
            //            sum=sum+Numberofdays((DateTime)employees_arr[i].HireDate);
            //        }
            //    }
            //    Console.WriteLine(sum);
            //    // Dumper.Dump(employees);
            //    Console.ReadKey();
            //}
            // public static int Numberofdays(DateTime start)
            //{
            //    int days = -1;
            //    DateTime end = DateTime.Now;
            //    days = (int)(end - start).TotalDays;
            //    return days;
            //}
        }
    }
}
